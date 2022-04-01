namespace SoundAnalysis1
{
    public struct Marker
    {
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public TimeSpan Duration => End - Start;

        public Marker(TimeSpan start, TimeSpan end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return Start + "," + End + "," + Duration.TotalMilliseconds;
        }

        public static Marker FromSample(double sampleCenter, int millisecondsPerSample)
        {
            var sampleCenterMs = (int) (1000 * sampleCenter);

            var begin = new TimeSpan(0, 0, 0, 0, sampleCenterMs - millisecondsPerSample / 2);
            var end = new TimeSpan(0, 0, 0, 0, sampleCenterMs + millisecondsPerSample / 2);
            return new Marker(begin, end);
        }
    }
}