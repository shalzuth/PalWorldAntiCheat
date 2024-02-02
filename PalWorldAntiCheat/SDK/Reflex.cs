using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.ReflexSDK
{
    public class ReflexBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ReflexBlueprintLibrary(nint addr) : base(addr) { }
        public void SetReflexMode(EReflexMode Mode) { Invoke(nameof(SetReflexMode), Mode); }
        public void SetFlashIndicatorEnabled(bool bEnabled) { Invoke(nameof(SetFlashIndicatorEnabled), bEnabled); }
        public float GetRenderLatencyInMs() { return Invoke<float>(nameof(GetRenderLatencyInMs)); }
        public EReflexMode GetReflexMode() { return Invoke<EReflexMode>(nameof(GetReflexMode)); }
        public bool GetReflexAvailable() { return Invoke<bool>(nameof(GetReflexAvailable)); }
        public float GetGameToRenderLatencyInMs() { return Invoke<float>(nameof(GetGameToRenderLatencyInMs)); }
        public float GetGameLatencyInMs() { return Invoke<float>(nameof(GetGameLatencyInMs)); }
        public bool GetFlashIndicatorEnabled() { return Invoke<bool>(nameof(GetFlashIndicatorEnabled)); }
    }
    public enum EReflexMode : int
    {
        Disabled = 0,
        Enabled = 1,
        EnabledPlusBoost = 3,
        EReflexMode_MAX = 4,
    }
}
