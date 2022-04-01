using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace SoundAnalysis1.Libraries;

public static class PlotLibrary
{
    private static readonly OxyColor Color = OxyColor.FromRgb(System.Drawing.Color.DodgerBlue.R, System.Drawing.Color.DodgerBlue.G, System.Drawing.Color.DodgerBlue.B);

    public static PlotModel UpdateWaveformPlot(DataPoint[] points, string labelX, string labelY, string title)
    {
        var plotModel = new PlotModel
        {
            PlotType = PlotType.XY,
            Background = OxyColors.White,
            Title = title,
            TitleFontSize = 10
        };

        var series = new LineSeries();
        var chartMaxY =  2*points.Max(p => p.Y);
        var chartMinY =  2*points.Min(p => p.Y);
        plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Left, Maximum = chartMaxY, Minimum = chartMinY, IsAxisVisible = false});
        plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Bottom, IsAxisVisible = false });

        series.Points.AddRange(points);
        series.Color = Color;
        plotModel.Series.Add(series);
        return plotModel;
    }

    public static PlotModel UpdateFrameParameterPlot(DataPoint[] resultPoints, double maxY)
    {
        var plotModel = new PlotModel
        {
            PlotType = PlotType.XY,
            Background = OxyColors.White
        };

        var series = new LineSeries();
        plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Left, IsAxisVisible = false});
        plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Bottom, IsAxisVisible = false });

        series.Points.AddRange(resultPoints);
        series.Color = Color;
        plotModel.Series.Add(series);
        return plotModel;
    }
}