using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.AudioAnalyzerSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioSynesthesiaSDK
{
    public class AudioSynesthesiaSettings : AudioAnalyzerSettings
    {
        public AudioSynesthesiaSettings(nint addr) : base(addr) { }
    }
    public class SynesthesiaSpectrumAnalysisSettings : AudioSynesthesiaSettings
    {
        public SynesthesiaSpectrumAnalysisSettings(nint addr) : base(addr) { }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public EFFTSize FFTSize { get { return (EFFTSize)this[nameof(FFTSize)].GetValue<int>(); } set { this[nameof(FFTSize)].SetValue<int>((int)value); } }
        public EAudioSpectrumType SpectrumType { get { return (EAudioSpectrumType)this[nameof(SpectrumType)].GetValue<int>(); } set { this[nameof(SpectrumType)].SetValue<int>((int)value); } }
        public EFFTWindowType WindowType { get { return (EFFTWindowType)this[nameof(WindowType)].GetValue<int>(); } set { this[nameof(WindowType)].SetValue<int>((int)value); } }
        public bool bDownmixToMono { get { return this[nameof(bDownmixToMono)].Flag; } set { this[nameof(bDownmixToMono)].Flag = value; } }
    }
    public class SynesthesiaSpectrumAnalyzer : AudioAnalyzer
    {
        public SynesthesiaSpectrumAnalyzer(nint addr) : base(addr) { }
        public SynesthesiaSpectrumAnalysisSettings Settings { get { return this[nameof(Settings)].As<SynesthesiaSpectrumAnalysisSettings>(); } set { this["Settings"] = value; } }
        public Object OnSpectrumResults { get { return this[nameof(OnSpectrumResults)]; } set { this[nameof(OnSpectrumResults)] = value; } }
        public Object OnLatestSpectrumResults { get { return this[nameof(OnLatestSpectrumResults)]; } set { this[nameof(OnLatestSpectrumResults)] = value; } }
        public int GetNumCenterFrequencies() { return Invoke<int>(nameof(GetNumCenterFrequencies)); }
        public void GetCenterFrequencies(float InSampleRate, Array<float> OutCenterFrequencies) { Invoke(nameof(GetCenterFrequencies), InSampleRate, OutCenterFrequencies); }
    }
    public class AudioSynesthesiaNRTSettings : AudioAnalyzerNRTSettings
    {
        public AudioSynesthesiaNRTSettings(nint addr) : base(addr) { }
    }
    public class AudioSynesthesiaNRT : AudioAnalyzerNRT
    {
        public AudioSynesthesiaNRT(nint addr) : base(addr) { }
    }
    public class ConstantQNRTSettings : AudioSynesthesiaNRTSettings
    {
        public ConstantQNRTSettings(nint addr) : base(addr) { }
        public float StartingFrequency { get { return this[nameof(StartingFrequency)].GetValue<float>(); } set { this[nameof(StartingFrequency)].SetValue<float>(value); } }
        public int NumBands { get { return this[nameof(NumBands)].GetValue<int>(); } set { this[nameof(NumBands)].SetValue<int>(value); } }
        public float NumBandsPerOctave { get { return this[nameof(NumBandsPerOctave)].GetValue<float>(); } set { this[nameof(NumBandsPerOctave)].SetValue<float>(value); } }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public bool bDownmixToMono { get { return this[nameof(bDownmixToMono)].Flag; } set { this[nameof(bDownmixToMono)].Flag = value; } }
        public EConstantQFFTSizeEnum FFTSize { get { return (EConstantQFFTSizeEnum)this[nameof(FFTSize)].GetValue<int>(); } set { this[nameof(FFTSize)].SetValue<int>((int)value); } }
        public EFFTWindowType WindowType { get { return (EFFTWindowType)this[nameof(WindowType)].GetValue<int>(); } set { this[nameof(WindowType)].SetValue<int>((int)value); } }
        public EAudioSpectrumType SpectrumType { get { return (EAudioSpectrumType)this[nameof(SpectrumType)].GetValue<int>(); } set { this[nameof(SpectrumType)].SetValue<int>((int)value); } }
        public float BandWidthStretch { get { return this[nameof(BandWidthStretch)].GetValue<float>(); } set { this[nameof(BandWidthStretch)].SetValue<float>(value); } }
        public EConstantQNormalizationEnum CQTNormalization { get { return (EConstantQNormalizationEnum)this[nameof(CQTNormalization)].GetValue<int>(); } set { this[nameof(CQTNormalization)].SetValue<int>((int)value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class ConstantQNRT : AudioSynesthesiaNRT
    {
        public ConstantQNRT(nint addr) : base(addr) { }
        public ConstantQNRTSettings Settings { get { return this[nameof(Settings)].As<ConstantQNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, Array<float> OutConstantQ) { Invoke(nameof(GetNormalizedChannelConstantQAtTime), InSeconds, InChannel, OutConstantQ); }
        public void GetChannelConstantQAtTime(float InSeconds, int InChannel, Array<float> OutConstantQ) { Invoke(nameof(GetChannelConstantQAtTime), InSeconds, InChannel, OutConstantQ); }
    }
    public class LoudnessSettings : AudioSynesthesiaSettings
    {
        public LoudnessSettings(nint addr) : base(addr) { }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
        public ELoudnessCurveTypeEnum CurveType { get { return (ELoudnessCurveTypeEnum)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
        public float ExpectedMaxLoudness { get { return this[nameof(ExpectedMaxLoudness)].GetValue<float>(); } set { this[nameof(ExpectedMaxLoudness)].SetValue<float>(value); } }
    }
    public class LoudnessAnalyzer : AudioAnalyzer
    {
        public LoudnessAnalyzer(nint addr) : base(addr) { }
        public LoudnessSettings Settings { get { return this[nameof(Settings)].As<LoudnessSettings>(); } set { this["Settings"] = value; } }
        public Object OnOverallLoudnessResults { get { return this[nameof(OnOverallLoudnessResults)]; } set { this[nameof(OnOverallLoudnessResults)] = value; } }
        public Object OnPerChannelLoudnessResults { get { return this[nameof(OnPerChannelLoudnessResults)]; } set { this[nameof(OnPerChannelLoudnessResults)] = value; } }
        public Object OnLatestOverallLoudnessResults { get { return this[nameof(OnLatestOverallLoudnessResults)]; } set { this[nameof(OnLatestOverallLoudnessResults)] = value; } }
        public Object OnLatestPerChannelLoudnessResults { get { return this[nameof(OnLatestPerChannelLoudnessResults)]; } set { this[nameof(OnLatestPerChannelLoudnessResults)] = value; } }
    }
    public class LoudnessNRTSettings : AudioSynesthesiaNRTSettings
    {
        public LoudnessNRTSettings(nint addr) : base(addr) { }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
        public ELoudnessNRTCurveTypeEnum CurveType { get { return (ELoudnessNRTCurveTypeEnum)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class LoudnessNRT : AudioSynesthesiaNRT
    {
        public LoudnessNRT(nint addr) : base(addr) { }
        public LoudnessNRTSettings Settings { get { return this[nameof(Settings)].As<LoudnessNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedLoudnessAtTime(float InSeconds, float OutLoudness) { Invoke(nameof(GetNormalizedLoudnessAtTime), InSeconds, OutLoudness); }
        public void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, float OutLoudness) { Invoke(nameof(GetNormalizedChannelLoudnessAtTime), InSeconds, InChannel, OutLoudness); }
        public void GetLoudnessAtTime(float InSeconds, float OutLoudness) { Invoke(nameof(GetLoudnessAtTime), InSeconds, OutLoudness); }
        public void GetChannelLoudnessAtTime(float InSeconds, int InChannel, float OutLoudness) { Invoke(nameof(GetChannelLoudnessAtTime), InSeconds, InChannel, OutLoudness); }
    }
    public class MeterSettings : AudioSynesthesiaSettings
    {
        public MeterSettings(nint addr) : base(addr) { }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public EMeterPeakType PeakMode { get { return (EMeterPeakType)this[nameof(PeakMode)].GetValue<int>(); } set { this[nameof(PeakMode)].SetValue<int>((int)value); } }
        public int MeterAttackTime { get { return this[nameof(MeterAttackTime)].GetValue<int>(); } set { this[nameof(MeterAttackTime)].SetValue<int>(value); } }
        public int MeterReleaseTime { get { return this[nameof(MeterReleaseTime)].GetValue<int>(); } set { this[nameof(MeterReleaseTime)].SetValue<int>(value); } }
        public int PeakHoldTime { get { return this[nameof(PeakHoldTime)].GetValue<int>(); } set { this[nameof(PeakHoldTime)].SetValue<int>(value); } }
        public float ClippingThreshold { get { return this[nameof(ClippingThreshold)].GetValue<float>(); } set { this[nameof(ClippingThreshold)].SetValue<float>(value); } }
    }
    public class MeterAnalyzer : AudioAnalyzer
    {
        public MeterAnalyzer(nint addr) : base(addr) { }
        public MeterSettings Settings { get { return this[nameof(Settings)].As<MeterSettings>(); } set { this["Settings"] = value; } }
        public Object OnOverallMeterResults { get { return this[nameof(OnOverallMeterResults)]; } set { this[nameof(OnOverallMeterResults)] = value; } }
        public Object OnPerChannelMeterResults { get { return this[nameof(OnPerChannelMeterResults)]; } set { this[nameof(OnPerChannelMeterResults)] = value; } }
        public Object OnLatestOverallMeterResults { get { return this[nameof(OnLatestOverallMeterResults)]; } set { this[nameof(OnLatestOverallMeterResults)] = value; } }
        public Object OnLatestPerChannelMeterResults { get { return this[nameof(OnLatestPerChannelMeterResults)]; } set { this[nameof(OnLatestPerChannelMeterResults)] = value; } }
    }
    public class OnsetNRTSettings : AudioSynesthesiaNRTSettings
    {
        public OnsetNRTSettings(nint addr) : base(addr) { }
        public bool bDownmixToMono { get { return this[nameof(bDownmixToMono)].Flag; } set { this[nameof(bDownmixToMono)].Flag = value; } }
        public float GranularityInSeconds { get { return this[nameof(GranularityInSeconds)].GetValue<float>(); } set { this[nameof(GranularityInSeconds)].SetValue<float>(value); } }
        public float Sensitivity { get { return this[nameof(Sensitivity)].GetValue<float>(); } set { this[nameof(Sensitivity)].SetValue<float>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
    }
    public class OnsetNRT : AudioSynesthesiaNRT
    {
        public OnsetNRT(nint addr) : base(addr) { }
        public OnsetNRTSettings Settings { get { return this[nameof(Settings)].As<OnsetNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, Array<float> OutOnsetTimestamps, Array<float> OutOnsetStrengths) { Invoke(nameof(GetNormalizedChannelOnsetsBetweenTimes), InStartSeconds, InEndSeconds, InChannel, OutOnsetTimestamps, OutOnsetStrengths); }
        public void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, Array<float> OutOnsetTimestamps, Array<float> OutOnsetStrengths) { Invoke(nameof(GetChannelOnsetsBetweenTimes), InStartSeconds, InEndSeconds, InChannel, OutOnsetTimestamps, OutOnsetStrengths); }
    }
    public class LoudnessResults : Object
    {
        public LoudnessResults(nint addr) : base(addr) { }
        public float Loudness { get { return this[nameof(Loudness)].GetValue<float>(); } set { this[nameof(Loudness)].SetValue<float>(value); } }
        public float NormalizedLoudness { get { return this[nameof(NormalizedLoudness)].GetValue<float>(); } set { this[nameof(NormalizedLoudness)].SetValue<float>(value); } }
        public float PerceptualEnergy { get { return this[nameof(PerceptualEnergy)].GetValue<float>(); } set { this[nameof(PerceptualEnergy)].SetValue<float>(value); } }
        public float TimeSeconds { get { return this[nameof(TimeSeconds)].GetValue<float>(); } set { this[nameof(TimeSeconds)].SetValue<float>(value); } }
    }
    public class MeterResults : Object
    {
        public MeterResults(nint addr) : base(addr) { }
        public float TimeSeconds { get { return this[nameof(TimeSeconds)].GetValue<float>(); } set { this[nameof(TimeSeconds)].SetValue<float>(value); } }
        public float MeterValue { get { return this[nameof(MeterValue)].GetValue<float>(); } set { this[nameof(MeterValue)].SetValue<float>(value); } }
        public float PeakValue { get { return this[nameof(PeakValue)].GetValue<float>(); } set { this[nameof(PeakValue)].SetValue<float>(value); } }
        public int NumSamplesClipping { get { return this[nameof(NumSamplesClipping)].GetValue<int>(); } set { this[nameof(NumSamplesClipping)].SetValue<int>(value); } }
        public float ClippingValue { get { return this[nameof(ClippingValue)].GetValue<float>(); } set { this[nameof(ClippingValue)].SetValue<float>(value); } }
    }
    public class SynesthesiaSpectrumResults : Object
    {
        public SynesthesiaSpectrumResults(nint addr) : base(addr) { }
        public float TimeSeconds { get { return this[nameof(TimeSeconds)].GetValue<float>(); } set { this[nameof(TimeSeconds)].SetValue<float>(value); } }
        public Array<float> SpectrumValues { get { return new Array<float>(this[nameof(SpectrumValues)].Address); } }
    }
    public enum EConstantQNormalizationEnum : int
    {
        EqualEuclideanNorm = 0,
        EqualEnergy = 1,
        EqualAmplitude = 2,
        EConstantQNormalizationEnum_MAX = 3,
    }
    public enum EConstantQFFTSizeEnum : int
    {
        Min = 0,
        XXSmall = 1,
        XSmall = 2,
        Small = 3,
        Medium = 4,
        Large = 5,
        XLarge = 6,
        XXLarge = 7,
        Max = 8,
    }
    public enum ELoudnessCurveTypeEnum : int
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        None = 4,
        ELoudnessCurveTypeEnum_MAX = 5,
    }
    public enum ELoudnessNRTCurveTypeEnum : int
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        None = 4,
        ELoudnessNRTCurveTypeEnum_MAX = 5,
    }
    public enum EMeterPeakType : int
    {
        MeanSquared = 0,
        RootMeanSquared = 1,
        Peak = 2,
        Count = 3,
        EMeterPeakType_MAX = 4,
    }
}
