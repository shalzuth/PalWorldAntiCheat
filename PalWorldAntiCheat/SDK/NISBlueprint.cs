using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.NISBlueprintSDK
{
    public class NISLibrary : BlueprintFunctionLibrary
    {
        public NISLibrary(nint addr) : base(addr) { }
        public void SetNISSharpness(float Sharpness) { Invoke(nameof(SetNISSharpness), Sharpness); }
        public void SetNISMode(UNISMode NISMode) { Invoke(nameof(SetNISMode), NISMode); }
        public void SetNISCustomScreenPercentage(float CustomScreenPercentage) { Invoke(nameof(SetNISCustomScreenPercentage), CustomScreenPercentage); }
        public bool IsNISSupported() { return Invoke<bool>(nameof(IsNISSupported)); }
        public bool IsNISModeSupported(UNISMode NISMode) { return Invoke<bool>(nameof(IsNISModeSupported), NISMode); }
        public Array<UNISMode> GetSupportedNISModes() { return Invoke<Array<UNISMode>>(nameof(GetSupportedNISModes)); }
        public void GetNISScreenPercentageRange(float MinScreenPercentage, float MaxScreenPercentage) { Invoke(nameof(GetNISScreenPercentageRange), MinScreenPercentage, MaxScreenPercentage); }
        public float GetNISRecommendedScreenPercentage(UNISMode NISMode) { return Invoke<float>(nameof(GetNISRecommendedScreenPercentage), NISMode); }
        public UNISMode GetDefaultNISMode() { return Invoke<UNISMode>(nameof(GetDefaultNISMode)); }
    }
    public enum UNISSupport : int
    {
        Supported = 0,
        NotSupported = 1,
        UNISSupport_MAX = 2,
    }
    public enum UNISMode : int
    {
        Off = 0,
        UltraQuality = 1,
        Quality = 2,
        Balanced = 3,
        Performance = 4,
        Custom = 5,
        UNISMode_MAX = 6,
    }
}
