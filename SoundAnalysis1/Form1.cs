using NAudio.Wave;
using OxyPlot;
using OxyPlot.WindowsForms;
using SoundAnalysis1.Libraries;

namespace SoundAnalysis1;

public partial class Form1 : Form
{
    private DataPoint[] discreteSignal;
    private int millisecondsPerFrame = 40;
    private int lag = 1;
    private double sampleRate;
    private int samplesPerFrame;
    private readonly Statistics statistics;

    public Form1()
    {
        InitializeComponent();
        statistics = new Statistics();
    }

    private void LoadFile(string filePath)
    {
        using var reader = new AudioFileReader(filePath);
        var lengthInBytes = reader.Length;
        var lengthInSamples = (int)lengthInBytes / 4;
        var wholeFile = new List<float>(lengthInSamples);
        //sample rate in samples/sec
        var buffer = new float[reader.WaveFormat.SampleRate * reader.WaveFormat.Channels];
        int samplesRead;
        while ((samplesRead = reader.Read(buffer, 0, buffer.Length)) > 0) 
            wholeFile.AddRange(buffer.Take(samplesRead));

        var fileName = Path.GetFileName(filePath);
        discreteSignal = new DataPoint[wholeFile.Count];
        sampleRate = reader.WaveFormat.SampleRate;
        samplesPerFrame = millisecondsPerFrame * reader.WaveFormat.SampleRate / 1000;
        for (var i = 0; i < wholeFile.Count; i++)
        {
            var timeInSeconds = i / sampleRate;
            discreteSignal[i] = new DataPoint(timeInSeconds, wholeFile[i]);
        }

        soundPlot.Model = PlotLibrary.UpdateWaveformPlot(discreteSignal, "Time [s]", "", fileName);
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var fileDialog = new OpenFileDialog();
        fileDialog.InitialDirectory = "\\.";
        fileDialog.Filter = @"Wave form audio format (*.wav)|*.wav";

        if (fileDialog.ShowDialog() != DialogResult.OK) return;
        var filePath = fileDialog.FileName;

        LoadFile(filePath);
        UpdateSoundParameters();
    }

    private void UpdateSoundParameters()
    {
        var volumePoints = UpdateFrameParameter(FrameParameterType.Volume, volumeValueLabel, volumePlot);
        var energyPoints = UpdateFrameParameter(FrameParameterType.ShortTimeEnergy, steValueLabel, stePlot);
        var zeroCrossingRatePoints = UpdateFrameParameter(FrameParameterType.ZeroCrossingRate, zcrValueLabel, zcrPlot);
        var silencePoints = UpdateFrameParameter(FrameParameterType.SilentRatio, silenceValueLabel, silencePlot);
        var soundlessSpeechPoints = UpdateFrameParameter(FrameParameterType.SoundlessSpeech, soundlessSpeechValueLabel, soundlessSpeechPlot);
        var soundSpeechPoints = UpdateFrameParameter(FrameParameterType.SoundSpeech, soundSpeechValueLabel, soundSpeechPlot);
        UpdateFrameParameter(FrameParameterType.Autocorrelation, autocorValueLabel, autoCorrePlot);
        UpdateFrameParameter(FrameParameterType.Amdf, amdfValueLabel, amdfPlot);

        var volume = volumePoints.Select(p => p.Y).ToArray();
        var energy = energyPoints.Select(p => p.Y).ToArray();
        var zeroCrossingRate = zeroCrossingRatePoints.Select(p => p.Y).ToArray();

        vstdValueLabel.Text = ClipLevelParametersCalculator.GetVolumeStandardDeviation(volume).ToString("0.000");
        vdrValueLabel.Text = ClipLevelParametersCalculator.GetVolumeDynamicRange(volume).ToString("0.000");
        lsterValueLabel.Text = ClipLevelParametersCalculator.GetLowShortTimeEnergyRatio(energy, discreteSignal, sampleRate).ToString("0.000");
        hzcrrValueLabel.Text = ClipLevelParametersCalculator.GetHighZeroCrossingRateRatio(zeroCrossingRate, discreteSignal, sampleRate).ToString("0.000");
        zstdValueLabel.Text = ClipLevelParametersCalculator.GetZcrStandardDeviation(zeroCrossingRate).ToString("0.000");

        UpdateStatistics(silencePoints, soundlessSpeechPoints, soundSpeechPoints);
    }

    private void UpdateStatistics(DataPoint[] silencePoints, DataPoint[] soundlessSpeechPoints, DataPoint[] soundSpeechPoints)
    {
        statistics.ClearAllLists();
        var framesCount = silencePoints.Length;

        for (var i = 0; i < framesCount; i++)
        {
            var silencePoint = silencePoints[i];
            var soundlessSoundPoint = soundlessSpeechPoints[i];
            var soundPoint = soundSpeechPoints[i];
            if (silencePoint.Y == 1)
                statistics.AddMarkerByType(StatisticsType.Silence, Marker.FromSample(silencePoint.X, millisecondsPerFrame));
            if (soundlessSoundPoint.Y == 1)
                statistics.AddMarkerByType(StatisticsType.SoundlessSpeech, Marker.FromSample(silencePoint.X, millisecondsPerFrame));
            if (soundPoint.Y == 1)
                statistics.AddMarkerByType(StatisticsType.SoundSpeech, Marker.FromSample(silencePoint.X, millisecondsPerFrame));
        }
    }

    private DataPoint[] UpdateFrameParameter(FrameParameterType parameter, Label label, PlotView chart)
    {
        var (value, valueInFrames) = FrameLevelParametersCalculator.CalculateFrameLevelParameter(parameter, discreteSignal, samplesPerFrame, lag);
        label.Text = value.ToString("0.000");

        var resultPoints = new DataPoint[valueInFrames.Length];
        var frameCenter = -samplesPerFrame / 2;
        var samplesInLastFrame = discreteSignal.Length % samplesPerFrame;

        for (var i = 0; i < valueInFrames.Length; i++)
        {
            if (i == valueInFrames.Length - 1)
                frameCenter += (samplesPerFrame + samplesInLastFrame) / 2;
            else
                frameCenter += samplesPerFrame;

            var timeInSeconds = frameCenter / sampleRate;
            resultPoints[i] = new DataPoint(timeInSeconds, valueInFrames[i]);
        }

        chart.Model = PlotLibrary.UpdateFrameParameterPlot(resultPoints, valueInFrames.Max());
        return resultPoints;
    }

    private void repaintButton_Click(object sender, EventArgs e)
    {
        millisecondsPerFrame = (int) milisecondPerFrameNumeric.Value;
        samplesPerFrame = millisecondsPerFrame * (int) sampleRate / 1000;
        lag = (int) lagNumericUpDown.Value;

        if(discreteSignal == null)
            return;

        if (discreteSignal.Length != 0)
            UpdateSoundParameters();
    }

    #region Show

    private void showSilenceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new IntervalStatisticsForm(statistics, StatisticsType.Silence);
        form.Show(this);
    }

    private void showSoundlessToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new IntervalStatisticsForm(statistics, StatisticsType.SoundlessSpeech);
        form.Show(this);
    }

    private void showSoundToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new IntervalStatisticsForm(statistics, StatisticsType.SoundSpeech);
        form.Show(this);
    }

    #endregion

    #region Export

    private void exportSilenceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        statistics.ExportStatisticsByType(StatisticsType.Silence);
    }

    private void exportSoundlessToolStripMenuItem_Click(object sender, EventArgs e)
    {
        statistics.ExportStatisticsByType(StatisticsType.SoundlessSpeech);
    }

    private void exportSoundToolStripMenuItem_Click(object sender, EventArgs e)
    {
        statistics.ExportStatisticsByType(StatisticsType.SoundSpeech);
    }

    #endregion
}