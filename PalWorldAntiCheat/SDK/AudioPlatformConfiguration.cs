using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.AudioPlatformConfigurationSDK
{
    public enum ESoundwaveSampleRateSettings : int
    {
        Max = 0,
        High = 1,
        Medium = 2,
        Low = 3,
        Min = 4,
        MatchDevice_DEPRECATED = 5,
    }
    public class PlatformRuntimeAudioCompressionOverrides : Object
    {
        public PlatformRuntimeAudioCompressionOverrides(nint addr) : base(addr) { }
        public bool bOverrideCompressionTimes { get { return this[nameof(bOverrideCompressionTimes)].Flag; } set { this[nameof(bOverrideCompressionTimes)].Flag = value; } }
        public float DurationThreshold { get { return this[nameof(DurationThreshold)].GetValue<float>(); } set { this[nameof(DurationThreshold)].SetValue<float>(value); } }
        public int MaxNumRandomBranches { get { return this[nameof(MaxNumRandomBranches)].GetValue<int>(); } set { this[nameof(MaxNumRandomBranches)].SetValue<int>(value); } }
        public int SoundCueQualityIndex { get { return this[nameof(SoundCueQualityIndex)].GetValue<int>(); } set { this[nameof(SoundCueQualityIndex)].SetValue<int>(value); } }
    }
}
