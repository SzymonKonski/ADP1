using System.Globalization;

namespace SoundAnalysis1;

public class Statistics
{
    public Statistics()
    {
        SilenceTimeMarkers = new List<Marker>();
        SoundlessSpeechTimeMarkers = new List<Marker>();
        SoundSpeechTimeMarkers = new List<Marker>();
    }

    public List<Marker> SilenceTimeMarkers { get; }
    public List<Marker> SoundlessSpeechTimeMarkers { get; }
    public List<Marker> SoundSpeechTimeMarkers { get; }

    public void ClearAllLists()
    {
        SilenceTimeMarkers.Clear();
        SoundlessSpeechTimeMarkers.Clear();
        SoundSpeechTimeMarkers.Clear();
    }

    public List<Marker> GetListByType(StatisticsType type)
    {
        return type switch
        {
            StatisticsType.Silence => SilenceTimeMarkers,
            StatisticsType.SoundlessSpeech => SoundlessSpeechTimeMarkers,
            StatisticsType.SoundSpeech => SoundSpeechTimeMarkers,
            _ => new List<Marker>()
        };
    }

    public void AddMarkerByType(StatisticsType type, Marker markerToAdd)
    {
        var list = GetListByType(type);
        if (list.Count == 0)
        {
            list.Add(markerToAdd);
            return;
        }

        if (list[^1].End == markerToAdd.Start)
            list[^1] = new Marker(list[^1].Start, markerToAdd.End);
        else
            list.Add(markerToAdd);
    }

    public ListViewItem[] GetListViewItemsByType(StatisticsType type)
    {
        var list = GetListByType(type);
        var result = new List<ListViewItem>();

        for (var i = 0; i < list.Count; i++)
        {
            var item = new ListViewItem((i + 1).ToString());
            item.SubItems.Add(list[i].Start.ToString());
            item.SubItems.Add(list[i].End.ToString());
            item.SubItems.Add(list[i].Duration.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));
            result.Add(item);
        }

        return result.ToArray();
    }

    public void ExportStatisticsByType(StatisticsType type)
    {
        var list = GetListByType(type);
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = "\\.";
        saveFileDialog.Filter = @"Comma-separated values (*.csv)|*.csv";
        saveFileDialog.FileName = $"{type} - {DateTime.Now.Ticks} .csv";
        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
        var filePath = saveFileDialog.FileName;
        using var file = new StreamWriter(filePath);
        file.WriteLine("Number,From,To,Duration(in milliseconds)");
        for (var i = 0; i < list.Count; i++) file.WriteLine(i + 1 + "," + list[i]);
    }
}