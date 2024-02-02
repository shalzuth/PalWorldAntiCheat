using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioAnalyzerSDK
{
    public class AudioAnalyzerAssetBase : Object
    {
        public AudioAnalyzerAssetBase(nint addr) : base(addr) { }
    }
    public class AudioAnalyzerSettings : AudioAnalyzerAssetBase
    {
        public AudioAnalyzerSettings(nint addr) : base(addr) { }
    }
    public class AudioAnalyzer : Object
    {
        public AudioAnalyzer(nint addr) : base(addr) { }
        public AudioBus AudioBus { get { return this[nameof(AudioBus)].As<AudioBus>(); } set { this["AudioBus"] = value; } }
        public AudioAnalyzerSubsystem AudioAnalyzerSubsystem { get { return this[nameof(AudioAnalyzerSubsystem)].As<AudioAnalyzerSubsystem>(); } set { this["AudioAnalyzerSubsystem"] = value; } }
        public void StopAnalyzing(Object WorldContextObject) { Invoke(nameof(StopAnalyzing), WorldContextObject); }
        public void StartAnalyzing(Object WorldContextObject, AudioBus AudioBusToAnalyze) { Invoke(nameof(StartAnalyzing), WorldContextObject, AudioBusToAnalyze); }
    }
    public class AudioAnalyzerNRTSettings : AudioAnalyzerAssetBase
    {
        public AudioAnalyzerNRTSettings(nint addr) : base(addr) { }
    }
    public class AudioAnalyzerNRT : AudioAnalyzerAssetBase
    {
        public AudioAnalyzerNRT(nint addr) : base(addr) { }
        public SoundWave Sound { get { return this[nameof(Sound)].As<SoundWave>(); } set { this["Sound"] = value; } }
        public float DurationInSeconds { get { return this[nameof(DurationInSeconds)].GetValue<float>(); } set { this[nameof(DurationInSeconds)].SetValue<float>(value); } }
    }
    public class AudioAnalyzerSubsystem : EngineSubsystem
    {
        public AudioAnalyzerSubsystem(nint addr) : base(addr) { }
        public Array<AudioAnalyzer> AudioAnalyzers { get { return new Array<AudioAnalyzer>(this[nameof(AudioAnalyzers)].Address); } }
    }
}
