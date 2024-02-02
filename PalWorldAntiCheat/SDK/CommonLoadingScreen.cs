using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.CommonLoadingScreenSDK
{
    public class CommonLoadingScreenSettings : DeveloperSettingsBackedByCVars
    {
        public CommonLoadingScreenSettings(nint addr) : base(addr) { }
        public SoftClassPath LoadingScreenWidget { get { return this[nameof(LoadingScreenWidget)].As<SoftClassPath>(); } set { this["LoadingScreenWidget"] = value; } }
        public int LoadingScreenZOrder { get { return this[nameof(LoadingScreenZOrder)].GetValue<int>(); } set { this[nameof(LoadingScreenZOrder)].SetValue<int>(value); } }
        public float HoldLoadingScreenAdditionalSecs { get { return this[nameof(HoldLoadingScreenAdditionalSecs)].GetValue<float>(); } set { this[nameof(HoldLoadingScreenAdditionalSecs)].SetValue<float>(value); } }
        public float LoadingScreenHeartbeatHangDuration { get { return this[nameof(LoadingScreenHeartbeatHangDuration)].GetValue<float>(); } set { this[nameof(LoadingScreenHeartbeatHangDuration)].SetValue<float>(value); } }
        public float LogLoadingScreenHeartbeatInterval { get { return this[nameof(LogLoadingScreenHeartbeatInterval)].GetValue<float>(); } set { this[nameof(LogLoadingScreenHeartbeatInterval)].SetValue<float>(value); } }
        public bool LogLoadingScreenReasonEveryFrame { get { return this[nameof(LogLoadingScreenReasonEveryFrame)].Flag; } set { this[nameof(LogLoadingScreenReasonEveryFrame)].Flag = value; } }
        public bool ForceLoadingScreenVisible { get { return this[nameof(ForceLoadingScreenVisible)].Flag; } set { this[nameof(ForceLoadingScreenVisible)].Flag = value; } }
        public bool HoldLoadingScreenAdditionalSecsEvenInEditor { get { return this[nameof(HoldLoadingScreenAdditionalSecsEvenInEditor)].Flag; } set { this[nameof(HoldLoadingScreenAdditionalSecsEvenInEditor)].Flag = value; } }
        public bool ForceTickLoadingScreenEvenInEditor { get { return this[nameof(ForceTickLoadingScreenEvenInEditor)].Flag; } set { this[nameof(ForceTickLoadingScreenEvenInEditor)].Flag = value; } }
    }
    public class LoadingProcessInterface : Interface
    {
        public LoadingProcessInterface(nint addr) : base(addr) { }
    }
    public class LoadingProcessTask : Object
    {
        public LoadingProcessTask(nint addr) : base(addr) { }
        public void Unregister() { Invoke(nameof(Unregister)); }
        public void SetShowLoadingScreenReason(Object InReason) { Invoke(nameof(SetShowLoadingScreenReason), InReason); }
        public LoadingProcessTask CreateLoadingScreenProcessTask(Object WorldContextObject, Object ShowLoadingScreenReason) { return Invoke<LoadingProcessTask>(nameof(CreateLoadingScreenProcessTask), WorldContextObject, ShowLoadingScreenReason); }
    }
    public class LoadingScreenManager : GameInstanceSubsystem
    {
        public LoadingScreenManager(nint addr) : base(addr) { }
        public Object GetDebugReasonForShowingOrHidingLoadingScreen() { return Invoke<Object>(nameof(GetDebugReasonForShowingOrHidingLoadingScreen)); }
    }
}
