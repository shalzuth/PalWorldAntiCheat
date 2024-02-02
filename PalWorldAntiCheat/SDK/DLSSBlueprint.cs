using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.DLSSBlueprintSDK
{
    public class DLSSLibrary : BlueprintFunctionLibrary
    {
        public DLSSLibrary(nint addr) : base(addr) { }
        public void SetDLSSSharpness(float Sharpness) { Invoke(nameof(SetDLSSSharpness), Sharpness); }
        public void SetDLSSMode(Object WorldContextObject, UDLSSMode DLSSMode) { Invoke(nameof(SetDLSSMode), WorldContextObject, DLSSMode); }
        public UDLSSSupport QueryDLSSSupport() { return Invoke<UDLSSSupport>(nameof(QueryDLSSSupport)); }
        public UDLSSSupport QueryDLSSRRSupport() { return Invoke<UDLSSSupport>(nameof(QueryDLSSRRSupport)); }
        public bool IsDLSSSupported() { return Invoke<bool>(nameof(IsDLSSSupported)); }
        public bool IsDLSSRRSupported() { return Invoke<bool>(nameof(IsDLSSRRSupported)); }
        public bool IsDLSSRREnabled() { return Invoke<bool>(nameof(IsDLSSRREnabled)); }
        public bool IsDLSSModeSupported(UDLSSMode DLSSMode) { return Invoke<bool>(nameof(IsDLSSModeSupported), DLSSMode); }
        public bool IsDLSSEnabled() { return Invoke<bool>(nameof(IsDLSSEnabled)); }
        public bool IsDLAAEnabled() { return Invoke<bool>(nameof(IsDLAAEnabled)); }
        public Array<UDLSSMode> GetSupportedDLSSModes() { return Invoke<Array<UDLSSMode>>(nameof(GetSupportedDLSSModes)); }
        public float GetDLSSSharpness() { return Invoke<float>(nameof(GetDLSSSharpness)); }
        public void GetDLSSScreenPercentageRange(float MinScreenPercentage, float MaxScreenPercentage) { Invoke(nameof(GetDLSSScreenPercentageRange), MinScreenPercentage, MaxScreenPercentage); }
        public void GetDLSSRRMinimumDriverVersion(int MinDriverVersionMajor, int MinDriverVersionMinor) { Invoke(nameof(GetDLSSRRMinimumDriverVersion), MinDriverVersionMajor, MinDriverVersionMinor); }
        public void GetDLSSModeInformation(UDLSSMode DLSSMode, Vector2D ScreenResolution, bool bIsSupported, float OptimalScreenPercentage, bool bIsFixedScreenPercentage, float MinScreenPercentage, float MaxScreenPercentage, float OptimalSharpness) { Invoke(nameof(GetDLSSModeInformation), DLSSMode, ScreenResolution, bIsSupported, OptimalScreenPercentage, bIsFixedScreenPercentage, MinScreenPercentage, MaxScreenPercentage, OptimalSharpness); }
        public UDLSSMode GetDLSSMode() { return Invoke<UDLSSMode>(nameof(GetDLSSMode)); }
        public void GetDLSSMinimumDriverVersion(int MinDriverVersionMajor, int MinDriverVersionMinor) { Invoke(nameof(GetDLSSMinimumDriverVersion), MinDriverVersionMajor, MinDriverVersionMinor); }
        public UDLSSMode GetDefaultDLSSMode() { return Invoke<UDLSSMode>(nameof(GetDefaultDLSSMode)); }
        public void EnableDLSSRR(bool bEnabled) { Invoke(nameof(EnableDLSSRR), bEnabled); }
        public void EnableDLSS(bool bEnabled) { Invoke(nameof(EnableDLSS), bEnabled); }
        public void EnableDLAA(bool bEnabled) { Invoke(nameof(EnableDLAA), bEnabled); }
    }
    public enum UDLSSSupport : int
    {
        Supported = 0,
        NotSupported = 1,
        NotSupportedIncompatibleHardware = 2,
        NotSupportedDriverOutOfDate = 3,
        NotSupportedOperatingSystemOutOfDate = 4,
        NotSupportedByPlatformAtBuildTime = 5,
        NotSupportedIncompatibleAPICaptureToolActive = 6,
        UDLSSSupport_MAX = 7,
    }
    public enum UDLSSMode : int
    {
        Off = 0,
        Auto = 1,
        DLAA = 2,
        UltraQuality = 3,
        Quality = 4,
        Balanced = 5,
        Performance = 6,
        UltraPerformance = 7,
        UDLSSMode_MAX = 8,
    }
}
