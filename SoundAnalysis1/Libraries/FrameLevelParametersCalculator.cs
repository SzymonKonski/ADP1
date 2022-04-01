using OxyPlot;

namespace SoundAnalysis1.Libraries;

public static class FrameLevelParametersCalculator
{
    public static (double, double[]) CalculateFrameLevelParameter(FrameParameterType parameter, DataPoint[] discreteSignal, int samplesPerFrame, int lag)
    {
        var framesCount = discreteSignal.Length / samplesPerFrame;
        if (discreteSignal.Length % samplesPerFrame != 0)
            framesCount++;

        return parameter switch
        {
            FrameParameterType.Volume => GetVolume(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.ShortTimeEnergy => GetEnergy(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.ZeroCrossingRate => GetZeroCrossingRate(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.SilentRatio => GetSilentRatio(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.SoundlessSpeech => GetSoundlessSpeech(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.SoundSpeech => GetSoundSpeech(discreteSignal, samplesPerFrame, framesCount),
            FrameParameterType.Autocorrelation => GetFundamentalFrequencyFromAutocorrelation(discreteSignal, samplesPerFrame, framesCount,lag),
            FrameParameterType.Amdf => GetFundamentalFrequencyFromAmdf(discreteSignal, samplesPerFrame, framesCount, lag),
            _ => (0.0, new double[framesCount])
        };
    }

    public static (double, double[]) GetVolume(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount)
    {
        return GetEnergy(discreteSignal, samplesPerFrame, framesCount, true);
    }

    public static (double, double[]) GetEnergy(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount, bool sqrt = false)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        for (var i = 0; i < framesCount; i++)
        {
            double squaredSum = 0.0f;

            for (var j = 0; j < samplesPerFrame; j++)
            {
                var sampleIdx = i * samplesPerFrame + j;
                if (sampleIdx >= discreteSignal.Length)
                    break;

                squaredSum += discreteSignal[sampleIdx].Y * discreteSignal[sampleIdx].Y;
            }

            resultInFrames[i] = squaredSum / samplesPerFrame;

            if (sqrt)
                resultInFrames[i] = Math.Sqrt(resultInFrames[i]);

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetFundamentalFrequencyFromAutocorrelation(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount, int lag)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        for (var i = 0; i < framesCount; i++)
        {
            double sum = 0.0f;

            for (var j = 0; j < samplesPerFrame - lag; j++)
            {
                var sampleIdx = i * samplesPerFrame + j;
                if (sampleIdx >= discreteSignal.Length || sampleIdx + lag >= discreteSignal.Length)
                    break;

                sum += discreteSignal[sampleIdx].Y * discreteSignal[sampleIdx+lag].Y;
            }

            resultInFrames[i] = sum;

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetFundamentalFrequencyFromAmdf(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount, int lag)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        for (var i = 0; i < framesCount; i++)
        {
            double sum = 0.0f;

            for (var j = 0; j < samplesPerFrame - lag; j++)
            {
                var sampleIdx = i * samplesPerFrame + j;
                if (sampleIdx >= discreteSignal.Length || sampleIdx + lag >= discreteSignal.Length)
                    break;

                sum += Math.Abs(discreteSignal[sampleIdx + lag].Y - discreteSignal[sampleIdx].Y);
            }

            resultInFrames[i] = sum;

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetZeroCrossingRate(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        for (var i = 0; i < framesCount; i++)
        {
            double squaredSum = 0.0f;
            for (var j = 0; j < samplesPerFrame; j++)
            {
                var sampleIdx = i * samplesPerFrame + j;
                if (sampleIdx >= discreteSignal.Length)
                    break;

                var signI = Math.Sign(discreteSignal[sampleIdx].Y);
                if (sampleIdx > 0)
                {
                    sampleIdx--;
                    squaredSum += Math.Abs(signI - Math.Sign(discreteSignal[sampleIdx].Y));
                }
                else
                {
                    squaredSum += Math.Abs(signI);
                }
            }

            resultInFrames[i] = squaredSum / (2.0 * samplesPerFrame);
            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetSilentRatio(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        var (_, volumeResultInFrame) = GetEnergy(discreteSignal, samplesPerFrame, framesCount, true);
        var (_, zcrResultInFrame) = GetZeroCrossingRate(discreteSignal, samplesPerFrame, framesCount);

        for (var i = 0; i < framesCount; i++)
        {
            if (volumeResultInFrame[i] < 0.02 && zcrResultInFrame[i] <= 0.5)
                resultInFrames[i] = 1;

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetSoundlessSpeech(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        var (_, energyResultInFrame) = GetEnergy(discreteSignal, samplesPerFrame, framesCount);
        var (_, zcrResultInFrame) = GetZeroCrossingRate(discreteSignal, samplesPerFrame, framesCount);

        for (var i = 0; i < framesCount; i++)
        {
            if (energyResultInFrame[i] < 0.003 && zcrResultInFrame[i] >= 0.1)
                resultInFrames[i] = 1;

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }

    public static (double, double[]) GetSoundSpeech(DataPoint[] discreteSignal, int samplesPerFrame, int framesCount)
    {
        double avgResult = 0.0f;
        var resultInFrames = new double[framesCount];

        var (_, energyResultInFrame) = GetEnergy(discreteSignal, samplesPerFrame, framesCount);
        var (_, zcrResultInFrame) = GetZeroCrossingRate(discreteSignal, samplesPerFrame, framesCount);

        for (var i = 0; i < framesCount; i++)
        {
            if (energyResultInFrame[i] >= 0.003 && zcrResultInFrame[i] < 0.1)
                resultInFrames[i] = 1;

            avgResult += resultInFrames[i];
        }

        avgResult /= framesCount;
        return (avgResult, resultInFrames);
    }
}