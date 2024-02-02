using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.HotfixSDK
{
    public class OnlineHotfixManager : Object
    {
        public OnlineHotfixManager(nint addr) : base(addr) { }
        public Object OSSName { get { return this[nameof(OSSName)]; } set { this[nameof(OSSName)] = value; } }
        public Object HotfixManagerClassName { get { return this[nameof(HotfixManagerClassName)]; } set { this[nameof(HotfixManagerClassName)] = value; } }
        public Object DebugPrefix { get { return this[nameof(DebugPrefix)]; } set { this[nameof(DebugPrefix)] = value; } }
        public Array<Object> AssetsHotfixedFromIniFiles { get { return new Array<Object>(this[nameof(AssetsHotfixedFromIniFiles)].Address); } }
        public void StartHotfixProcess() { Invoke(nameof(StartHotfixProcess)); }
    }
    public class UpdateManager : Object
    {
        public UpdateManager(nint addr) : base(addr) { }
        public float HotfixCheckCompleteDelay { get { return this[nameof(HotfixCheckCompleteDelay)].GetValue<float>(); } set { this[nameof(HotfixCheckCompleteDelay)].SetValue<float>(value); } }
        public float UpdateCheckCompleteDelay { get { return this[nameof(UpdateCheckCompleteDelay)].GetValue<float>(); } set { this[nameof(UpdateCheckCompleteDelay)].SetValue<float>(value); } }
        public float HotfixAvailabilityCheckCompleteDelay { get { return this[nameof(HotfixAvailabilityCheckCompleteDelay)].GetValue<float>(); } set { this[nameof(HotfixAvailabilityCheckCompleteDelay)].SetValue<float>(value); } }
        public float UpdateCheckAvailabilityCompleteDelay { get { return this[nameof(UpdateCheckAvailabilityCompleteDelay)].GetValue<float>(); } set { this[nameof(UpdateCheckAvailabilityCompleteDelay)].SetValue<float>(value); } }
        public int AppSuspendedUpdateCheckTimeSeconds { get { return this[nameof(AppSuspendedUpdateCheckTimeSeconds)].GetValue<int>(); } set { this[nameof(AppSuspendedUpdateCheckTimeSeconds)].SetValue<int>(value); } }
        public bool bPlatformEnvironmentDetected { get { return this[nameof(bPlatformEnvironmentDetected)].Flag; } set { this[nameof(bPlatformEnvironmentDetected)].Flag = value; } }
        public bool bInitialUpdateFinished { get { return this[nameof(bInitialUpdateFinished)].Flag; } set { this[nameof(bInitialUpdateFinished)].Flag = value; } }
        public bool bCheckHotfixAvailabilityOnly { get { return this[nameof(bCheckHotfixAvailabilityOnly)].Flag; } set { this[nameof(bCheckHotfixAvailabilityOnly)].Flag = value; } }
        public EUpdateState CurrentUpdateState { get { return (EUpdateState)this[nameof(CurrentUpdateState)].GetValue<int>(); } set { this[nameof(CurrentUpdateState)].SetValue<int>((int)value); } }
        public int WorstNumFilesPendingLoadViewed { get { return this[nameof(WorstNumFilesPendingLoadViewed)].GetValue<int>(); } set { this[nameof(WorstNumFilesPendingLoadViewed)].SetValue<int>(value); } }
        public EHotfixResult LastHotfixResult { get { return (EHotfixResult)this[nameof(LastHotfixResult)].GetValue<int>(); } set { this[nameof(LastHotfixResult)].SetValue<int>((int)value); } }
        public DateTime LastUpdateCheck { get { return this[nameof(LastUpdateCheck)].As<DateTime>(); } set { this["LastUpdateCheck"] = value; } }
        public EUpdateCompletionStatus LastCompletionResult { get { return (EUpdateCompletionStatus)this[nameof(LastCompletionResult)].GetValue<int>(); } set { this[nameof(LastCompletionResult)].SetValue<int>((int)value); } }
        public Enum UpdateStateEnum { get { return this[nameof(UpdateStateEnum)].As<Enum>(); } set { this["UpdateStateEnum"] = value; } }
        public Enum UpdateCompletionEnum { get { return this[nameof(UpdateCompletionEnum)].As<Enum>(); } set { this["UpdateCompletionEnum"] = value; } }
        public UpdateContextDefinition UpdateContextDefinitionUnknown { get { return this[nameof(UpdateContextDefinitionUnknown)].As<UpdateContextDefinition>(); } set { this["UpdateContextDefinitionUnknown"] = value; } }
        public Array<UpdateContextDefinition> UpdateContextDefinitions { get { return new Array<UpdateContextDefinition>(this[nameof(UpdateContextDefinitions)].Address); } }
    }
    public enum EHotfixResult : int
    {
        Failed = 0,
        Success = 1,
        SuccessNoChange = 2,
        SuccessNeedsReload = 3,
        SuccessNeedsRelaunch = 4,
        EHotfixResult_MAX = 5,
    }
    public enum EUpdateState : int
    {
        UpdateIdle = 0,
        UpdatePending = 1,
        CheckingForPatch = 2,
        DetectingPlatformEnvironment = 3,
        CheckingForHotfix = 4,
        WaitingOnInitialLoad = 5,
        InitialLoadComplete = 6,
        UpdateComplete = 7,
        EUpdateState_MAX = 8,
    }
    public enum EUpdateCompletionStatus : int
    {
        UpdateUnknown = 0,
        UpdateSuccess = 1,
        UpdateSuccess_NoChange = 2,
        UpdateSuccess_NeedsReload = 3,
        UpdateSuccess_NeedsRelaunch = 4,
        UpdateSuccess_NeedsPatch = 5,
        UpdateFailure_PatchCheck = 6,
        UpdateFailure_HotfixCheck = 7,
        UpdateFailure_NotLoggedIn = 8,
        EUpdateCompletionStatus_MAX = 9,
    }
    public class UpdateContextDefinition : Object
    {
        public UpdateContextDefinition(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool bCheckAvailabilityOnly { get { return this[nameof(bCheckAvailabilityOnly)].Flag; } set { this[nameof(bCheckAvailabilityOnly)].Flag = value; } }
        public bool bPatchCheckEnabled { get { return this[nameof(bPatchCheckEnabled)].Flag; } set { this[nameof(bPatchCheckEnabled)].Flag = value; } }
        public bool bPlatformEnvironmentDetectionEnabled { get { return this[nameof(bPlatformEnvironmentDetectionEnabled)].Flag; } set { this[nameof(bPlatformEnvironmentDetectionEnabled)].Flag = value; } }
        public Object AdditionalTags { get { return this[nameof(AdditionalTags)]; } set { this[nameof(AdditionalTags)] = value; } }
    }
}
