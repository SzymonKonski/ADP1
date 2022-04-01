namespace SoundAnalysis1
{
    public partial class IntervalStatisticsForm : Form
    {
        private Statistics statistics;
        private StatisticsType statisticsType;

        public IntervalStatisticsForm(Statistics statistics, StatisticsType statisticsType)
        {
            InitializeComponent();

            this.statistics = statistics;
            this.statisticsType = statisticsType;
            statisticLabel.Text = statisticsType + @" Statistics";
            listView.Items.AddRange(statistics.GetListViewItemsByType(statisticsType));
        }
    }
}