namespace SoundAnalysis1;

public enum FrameParameterType
{
    Volume,
    ShortTimeEnergy,
    ZeroCrossingRate,
    SilentRatio,
    Autocorrelation,
    Amdf,
    SoundlessSpeech,
    SoundSpeech
}

public enum StatisticsType
{
    Silence,
    SoundlessSpeech,
    SoundSpeech
}