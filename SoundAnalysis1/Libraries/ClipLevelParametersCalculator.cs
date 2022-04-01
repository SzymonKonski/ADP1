using OxyPlot;

namespace SoundAnalysis1.Libraries
{
    public static class ClipLevelParametersCalculator
    {
        public static double GetVolumeStandardDeviation(double[] volume)
        {
            if (volume.Length <= 1)
                return 0.0;

            var avg = volume.Average();
            var sum = volume.Sum(value => (value - avg) * (value - avg));
            sum /= volume.Length;

            return Math.Sqrt(sum) / volume.Max();
        }

        public static double GetZcrStandardDeviation(double[] zeroCrossingRate)
        {
            if (zeroCrossingRate.Length <= 1)
                return 0.0;

            var avg = zeroCrossingRate.Average();
            var sum = zeroCrossingRate.Sum(value => (value - avg) * (value - avg));
            sum /= zeroCrossingRate.Length;

            return Math.Sqrt(sum) / zeroCrossingRate.Max();
        }

        public static double GetVolumeDynamicRange(double[] volume)
        {
            var max = volume.Max();
            var min = volume.Min();

            return (max - min) / max;
        }

        public static double GetLowShortTimeEnergyRatio(double[] energy, DataPoint[] discreteSignal, double sampleRate)
        {
            var framesCount = discreteSignal.Length / (int)sampleRate;
            if (discreteSignal.Length % sampleRate != 0)
                framesCount++;

            var (_, energyInOneSecFrame) = FrameLevelParametersCalculator.GetEnergy(discreteSignal, (int)sampleRate, framesCount);

            var avg = energyInOneSecFrame.Average();
            var sum = energy.Sum(value => Math.Sign(0.5 * avg - value) + 1);

            return sum / (2.0 * energy.Length);
        }

        public static double GetHighZeroCrossingRateRatio(double[] zeroCrossingRate, DataPoint[] discreteSignal, double sampleRate)
        {
            var framesCount = discreteSignal.Length / (int)sampleRate;
            if (discreteSignal.Length % sampleRate != 0)
                framesCount++;

            var (_, zcrInOneSecFrame) = FrameLevelParametersCalculator.GetZeroCrossingRate(discreteSignal, (int)sampleRate, framesCount);

            var avg = zcrInOneSecFrame.Average();
            var sum = zeroCrossingRate.Sum(value => Math.Sign(value - 1.5 * avg) + 1);

            return sum / (2.0 * zeroCrossingRate.Length);
        }
    }
}
