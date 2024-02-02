using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.LiveLinkInterfaceSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.TimeManagementSDK;
namespace SDK.Script.LiveLinkSDK
{
    public class LiveLinkBasicFrameInterpolationProcessor : LiveLinkFrameInterpolationProcessor
    {
        public LiveLinkBasicFrameInterpolationProcessor(nint addr) : base(addr) { }
        public bool bInterpolatePropertyValues { get { return this[nameof(bInterpolatePropertyValues)].Flag; } set { this[nameof(bInterpolatePropertyValues)].Flag = value; } }
    }
    public class LiveLinkAnimationFrameInterpolationProcessor : LiveLinkBasicFrameInterpolationProcessor
    {
        public LiveLinkAnimationFrameInterpolationProcessor(nint addr) : base(addr) { }
    }
    public class LiveLinkAnimationVirtualSubject : LiveLinkVirtualSubject
    {
        public LiveLinkAnimationVirtualSubject(nint addr) : base(addr) { }
        public bool bAppendSubjectNameToBones { get { return this[nameof(bAppendSubjectNameToBones)].Flag; } set { this[nameof(bAppendSubjectNameToBones)].Flag = value; } }
    }
    public class LiveLinkBlueprintLibrary : BlueprintFunctionLibrary
    {
        public LiveLinkBlueprintLibrary(nint addr) : base(addr) { }
        public void TransformNames(SubjectFrameHandle SubjectFrameHandle, Array<Object> TransformNames) { Invoke(nameof(TransformNames), SubjectFrameHandle, TransformNames); }
        public void TransformName(LiveLinkTransform LiveLinkTransform, Object Name) { Invoke(nameof(TransformName), LiveLinkTransform, Name); }
        public void SetLiveLinkSubjectEnabled(LiveLinkSubjectKey SubjectKey, bool bEnabled) { Invoke(nameof(SetLiveLinkSubjectEnabled), SubjectKey, bEnabled); }
        public bool RemoveSource(LiveLinkSourceHandle SourceHandle) { return Invoke<bool>(nameof(RemoveSource), SourceHandle); }
        public void ParentBoneSpaceTransform(LiveLinkTransform LiveLinkTransform, Transform Transform) { Invoke(nameof(ParentBoneSpaceTransform), LiveLinkTransform, Transform); }
        public int NumberOfTransforms(SubjectFrameHandle SubjectFrameHandle) { return Invoke<int>(nameof(NumberOfTransforms), SubjectFrameHandle); }
        public bool IsSpecificLiveLinkSubjectEnabled(LiveLinkSubjectKey SubjectKey, bool bForThisFrame) { return Invoke<bool>(nameof(IsSpecificLiveLinkSubjectEnabled), SubjectKey, bForThisFrame); }
        public bool IsSourceStillValid(LiveLinkSourceHandle SourceHandle) { return Invoke<bool>(nameof(IsSourceStillValid), SourceHandle); }
        public bool IsLiveLinkSubjectEnabled(LiveLinkSubjectName SubjectName) { return Invoke<bool>(nameof(IsLiveLinkSubjectEnabled), SubjectName); }
        public bool HasParent(LiveLinkTransform LiveLinkTransform) { return Invoke<bool>(nameof(HasParent), LiveLinkTransform); }
        public void GetTransformByName(SubjectFrameHandle SubjectFrameHandle, Object TransformName, LiveLinkTransform LiveLinkTransform) { Invoke(nameof(GetTransformByName), SubjectFrameHandle, TransformName, LiveLinkTransform); }
        public void GetTransformByIndex(SubjectFrameHandle SubjectFrameHandle, int TransformIndex, LiveLinkTransform LiveLinkTransform) { Invoke(nameof(GetTransformByIndex), SubjectFrameHandle, TransformIndex, LiveLinkTransform); }
        public Object GetSpecificLiveLinkSubjectRole(LiveLinkSubjectKey SubjectKey) { return Invoke<Object>(nameof(GetSpecificLiveLinkSubjectRole), SubjectKey); }
        public Object GetSourceTypeFromGuid(Guid SourceGuid) { return Invoke<Object>(nameof(GetSourceTypeFromGuid), SourceGuid); }
        public Object GetSourceType(LiveLinkSourceHandle SourceHandle) { return Invoke<Object>(nameof(GetSourceType), SourceHandle); }
        public Object GetSourceStatus(LiveLinkSourceHandle SourceHandle) { return Invoke<Object>(nameof(GetSourceStatus), SourceHandle); }
        public Object GetSourceMachineName(LiveLinkSourceHandle SourceHandle) { return Invoke<Object>(nameof(GetSourceMachineName), SourceHandle); }
        public void GetRootTransform(SubjectFrameHandle SubjectFrameHandle, LiveLinkTransform LiveLinkTransform) { Invoke(nameof(GetRootTransform), SubjectFrameHandle, LiveLinkTransform); }
        public bool GetPropertyValue(LiveLinkBasicBlueprintData BasicData, Object PropertyName, float Value) { return Invoke<bool>(nameof(GetPropertyValue), BasicData, PropertyName, Value); }
        public void GetParent(LiveLinkTransform LiveLinkTransform, LiveLinkTransform Parent) { Invoke(nameof(GetParent), LiveLinkTransform, Parent); }
        public void GetMetadata(SubjectFrameHandle SubjectFrameHandle, SubjectMetadata MetaData) { Invoke(nameof(GetMetadata), SubjectFrameHandle, MetaData); }
        public Array<LiveLinkSubjectKey> GetLiveLinkSubjects(bool bIncludeDisabledSubject, bool bIncludeVirtualSubject) { return Invoke<Array<LiveLinkSubjectKey>>(nameof(GetLiveLinkSubjects), bIncludeDisabledSubject, bIncludeVirtualSubject); }
        public Object GetLiveLinkSubjectRole(LiveLinkSubjectName SubjectName) { return Invoke<Object>(nameof(GetLiveLinkSubjectRole), SubjectName); }
        public Array<LiveLinkSubjectName> GetLiveLinkEnabledSubjectNames(bool bIncludeVirtualSubject) { return Invoke<Array<LiveLinkSubjectName>>(nameof(GetLiveLinkEnabledSubjectNames), bIncludeVirtualSubject); }
        public void GetCurves(SubjectFrameHandle SubjectFrameHandle, Object Curves) { Invoke(nameof(GetCurves), SubjectFrameHandle, Curves); }
        public void GetChildren(LiveLinkTransform LiveLinkTransform, Array<LiveLinkTransform> Children) { Invoke(nameof(GetChildren), LiveLinkTransform, Children); }
        public void GetBasicData(SubjectFrameHandle SubjectFrameHandle, LiveLinkBasicBlueprintData BasicBlueprintData) { Invoke(nameof(GetBasicData), SubjectFrameHandle, BasicBlueprintData); }
        public bool GetAnimationStaticData(SubjectFrameHandle SubjectFrameHandle, LiveLinkSkeletonStaticData AnimationStaticData) { return Invoke<bool>(nameof(GetAnimationStaticData), SubjectFrameHandle, AnimationStaticData); }
        public bool GetAnimationFrameData(SubjectFrameHandle SubjectFrameHandle, LiveLinkAnimationFrameData AnimationFrameData) { return Invoke<bool>(nameof(GetAnimationFrameData), SubjectFrameHandle, AnimationFrameData); }
        public bool EvaluateLiveLinkFrameWithSpecificRole(LiveLinkSubjectName SubjectName, Object Role, LiveLinkBaseBlueprintData OutBlueprintData) { return Invoke<bool>(nameof(EvaluateLiveLinkFrameWithSpecificRole), SubjectName, Role, OutBlueprintData); }
        public bool EvaluateLiveLinkFrameAtWorldTimeOffset(LiveLinkSubjectName SubjectName, Object Role, float WorldTimeOffset, LiveLinkBaseBlueprintData OutBlueprintData) { return Invoke<bool>(nameof(EvaluateLiveLinkFrameAtWorldTimeOffset), SubjectName, Role, WorldTimeOffset, OutBlueprintData); }
        public bool EvaluateLiveLinkFrameAtSceneTime(LiveLinkSubjectName SubjectName, Object Role, Timecode SceneTime, LiveLinkBaseBlueprintData OutBlueprintData) { return Invoke<bool>(nameof(EvaluateLiveLinkFrameAtSceneTime), SubjectName, Role, SceneTime, OutBlueprintData); }
        public bool EvaluateLiveLinkFrame(LiveLinkSubjectRepresentation SubjectRepresentation, LiveLinkBaseBlueprintData OutBlueprintData) { return Invoke<bool>(nameof(EvaluateLiveLinkFrame), SubjectRepresentation, OutBlueprintData); }
        public void ComponentSpaceTransform(LiveLinkTransform LiveLinkTransform, Transform Transform) { Invoke(nameof(ComponentSpaceTransform), LiveLinkTransform, Transform); }
        public int ChildCount(LiveLinkTransform LiveLinkTransform) { return Invoke<int>(nameof(ChildCount), LiveLinkTransform); }
    }
    public class LiveLinkComponent : ActorComponent
    {
        public LiveLinkComponent(nint addr) : base(addr) { }
        public Object OnLiveLinkUpdated { get { return this[nameof(OnLiveLinkUpdated)]; } set { this[nameof(OnLiveLinkUpdated)] = value; } }
        public void GetSubjectDataAtWorldTime(Object SubjectName, float WorldTime, bool bSuccess, SubjectFrameHandle SubjectFrameHandle) { Invoke(nameof(GetSubjectDataAtWorldTime), SubjectName, WorldTime, bSuccess, SubjectFrameHandle); }
        public void GetSubjectDataAtSceneTime(Object SubjectName, Timecode SceneTime, bool bSuccess, SubjectFrameHandle SubjectFrameHandle) { Invoke(nameof(GetSubjectDataAtSceneTime), SubjectName, SceneTime, bSuccess, SubjectFrameHandle); }
        public void GetSubjectData(Object SubjectName, bool bSuccess, SubjectFrameHandle SubjectFrameHandle) { Invoke(nameof(GetSubjectData), SubjectName, bSuccess, SubjectFrameHandle); }
        public void GetAvailableSubjectNames(Array<Object> SubjectNames) { Invoke(nameof(GetAvailableSubjectNames), SubjectNames); }
    }
    public class LiveLinkDrivenComponent : ActorComponent
    {
        public LiveLinkDrivenComponent(nint addr) : base(addr) { }
        public LiveLinkSubjectName SubjectName { get { return this[nameof(SubjectName)].As<LiveLinkSubjectName>(); } set { this["SubjectName"] = value; } }
        public Object ActorTransformBone { get { return this[nameof(ActorTransformBone)]; } set { this[nameof(ActorTransformBone)] = value; } }
        public bool bModifyActorTransform { get { return this[nameof(bModifyActorTransform)].Flag; } set { this[nameof(bModifyActorTransform)].Flag = value; } }
        public bool bSetRelativeLocation { get { return this[nameof(bSetRelativeLocation)].Flag; } set { this[nameof(bSetRelativeLocation)].Flag = value; } }
    }
    public class LiveLinkMessageBusFinder : Object
    {
        public LiveLinkMessageBusFinder(nint addr) : base(addr) { }
        public void GetAvailableProviders(Object WorldContextObject, LatentActionInfo LatentInfo, float Duration, Array<ProviderPollResult> AvailableProviders) { Invoke(nameof(GetAvailableProviders), WorldContextObject, LatentInfo, Duration, AvailableProviders); }
        public LiveLinkMessageBusFinder ConstructMessageBusFinder() { return Invoke<LiveLinkMessageBusFinder>(nameof(ConstructMessageBusFinder)); }
        public void ConnectToProvider(ProviderPollResult Provider, LiveLinkSourceHandle SourceHandle) { Invoke(nameof(ConnectToProvider), Provider, SourceHandle); }
    }
    public class LiveLinkMessageBusSourceFactory : LiveLinkSourceFactory
    {
        public LiveLinkMessageBusSourceFactory(nint addr) : base(addr) { }
    }
    public class LiveLinkMessageBusSourceSettings : LiveLinkSourceSettings
    {
        public LiveLinkMessageBusSourceSettings(nint addr) : base(addr) { }
    }
    public class LiveLinkPreset : Object
    {
        public LiveLinkPreset(nint addr) : base(addr) { }
        public Array<LiveLinkSourcePreset> Sources { get { return new Array<LiveLinkSourcePreset>(this[nameof(Sources)].Address); } }
        public Array<LiveLinkSubjectPreset> Subjects { get { return new Array<LiveLinkSubjectPreset>(this[nameof(Subjects)].Address); } }
        public void BuildFromClient() { Invoke(nameof(BuildFromClient)); }
        public void ApplyToClientLatent(Object WorldContextObject, LatentActionInfo LatentInfo) { Invoke(nameof(ApplyToClientLatent), WorldContextObject, LatentInfo); }
        public bool ApplyToClient() { return Invoke<bool>(nameof(ApplyToClient)); }
        public bool AddToClient(bool bRecreatePresets) { return Invoke<bool>(nameof(AddToClient), bRecreatePresets); }
    }
    public class LiveLinkUserSettings : Object
    {
        public LiveLinkUserSettings(nint addr) : base(addr) { }
        public DirectoryPath PresetSaveDir { get { return this[nameof(PresetSaveDir)].As<DirectoryPath>(); } set { this["PresetSaveDir"] = value; } }
    }
    public class LiveLinkSettings : Object
    {
        public LiveLinkSettings(nint addr) : base(addr) { }
        public Array<LiveLinkRoleProjectSetting> DefaultRoleSettings { get { return new Array<LiveLinkRoleProjectSetting>(this[nameof(DefaultRoleSettings)].Address); } }
        public Object FrameInterpolationProcessor { get { return this[nameof(FrameInterpolationProcessor)]; } set { this[nameof(FrameInterpolationProcessor)] = value; } }
        public Object DefaultLiveLinkPreset { get { return this[nameof(DefaultLiveLinkPreset)]; } set { this[nameof(DefaultLiveLinkPreset)] = value; } }
        public float ClockOffsetCorrectionStep { get { return this[nameof(ClockOffsetCorrectionStep)].GetValue<float>(); } set { this[nameof(ClockOffsetCorrectionStep)].SetValue<float>(value); } }
        public ELiveLinkSourceMode DefaultMessageBusSourceMode { get { return (ELiveLinkSourceMode)this[nameof(DefaultMessageBusSourceMode)].GetValue<int>(); } set { this[nameof(DefaultMessageBusSourceMode)].SetValue<int>((int)value); } }
        public double MessageBusPingRequestFrequency { get { return this[nameof(MessageBusPingRequestFrequency)].GetValue<double>(); } set { this[nameof(MessageBusPingRequestFrequency)].SetValue<double>(value); } }
        public double MessageBusHeartbeatFrequency { get { return this[nameof(MessageBusHeartbeatFrequency)].GetValue<double>(); } set { this[nameof(MessageBusHeartbeatFrequency)].SetValue<double>(value); } }
        public double MessageBusHeartbeatTimeout { get { return this[nameof(MessageBusHeartbeatTimeout)].GetValue<double>(); } set { this[nameof(MessageBusHeartbeatTimeout)].SetValue<double>(value); } }
        public double MessageBusTimeBeforeRemovingInactiveSource { get { return this[nameof(MessageBusTimeBeforeRemovingInactiveSource)].GetValue<double>(); } set { this[nameof(MessageBusTimeBeforeRemovingInactiveSource)].SetValue<double>(value); } }
        public double TimeWithoutFrameToBeConsiderAsInvalid { get { return this[nameof(TimeWithoutFrameToBeConsiderAsInvalid)].GetValue<double>(); } set { this[nameof(TimeWithoutFrameToBeConsiderAsInvalid)].SetValue<double>(value); } }
        public LinearColor ValidColor { get { return this[nameof(ValidColor)].As<LinearColor>(); } set { this["ValidColor"] = value; } }
        public LinearColor InvalidColor { get { return this[nameof(InvalidColor)].As<LinearColor>(); } set { this["InvalidColor"] = value; } }
        public byte TextSizeSource { get { return this[nameof(TextSizeSource)].GetValue<byte>(); } set { this[nameof(TextSizeSource)].SetValue<byte>(value); } }
        public byte TextSizeSubject { get { return this[nameof(TextSizeSubject)].GetValue<byte>(); } set { this[nameof(TextSizeSubject)].SetValue<byte>(value); } }
    }
    public class LiveLinkTimecodeProvider : TimecodeProvider
    {
        public LiveLinkTimecodeProvider(nint addr) : base(addr) { }
        public LiveLinkSubjectKey SubjectKey { get { return this[nameof(SubjectKey)].As<LiveLinkSubjectKey>(); } set { this["SubjectKey"] = value; } }
        public ELiveLinkTimecodeProviderEvaluationType Evaluation { get { return (ELiveLinkTimecodeProviderEvaluationType)this[nameof(Evaluation)].GetValue<int>(); } set { this[nameof(Evaluation)].SetValue<int>((int)value); } }
        public bool bOverrideFrameRate { get { return this[nameof(bOverrideFrameRate)].Flag; } set { this[nameof(bOverrideFrameRate)].Flag = value; } }
        public FrameRate OverrideFrameRate { get { return this[nameof(OverrideFrameRate)].As<FrameRate>(); } set { this["OverrideFrameRate"] = value; } }
        public int BufferSize { get { return this[nameof(BufferSize)].GetValue<int>(); } set { this[nameof(BufferSize)].SetValue<int>(value); } }
    }
    public class LiveLinkTimeSynchronizationSource : TimeSynchronizationSource
    {
        public LiveLinkTimeSynchronizationSource(nint addr) : base(addr) { }
        public LiveLinkSubjectName SubjectName { get { return this[nameof(SubjectName)].As<LiveLinkSubjectName>(); } set { this["SubjectName"] = value; } }
    }
    public class LiveLinkVirtualSubjectSourceSettings : LiveLinkSourceSettings
    {
        public LiveLinkVirtualSubjectSourceSettings(nint addr) : base(addr) { }
        public Object SourceName { get { return this[nameof(SourceName)]; } set { this[nameof(SourceName)] = value; } }
    }
    public class LiveLinkTransformAxisSwitchPreProcessor : LiveLinkFramePreProcessor
    {
        public LiveLinkTransformAxisSwitchPreProcessor(nint addr) : base(addr) { }
        public ELiveLinkAxis FrontAxis { get { return (ELiveLinkAxis)this[nameof(FrontAxis)].GetValue<int>(); } set { this[nameof(FrontAxis)].SetValue<int>((int)value); } }
        public ELiveLinkAxis RightAxis { get { return (ELiveLinkAxis)this[nameof(RightAxis)].GetValue<int>(); } set { this[nameof(RightAxis)].SetValue<int>((int)value); } }
        public ELiveLinkAxis UpAxis { get { return (ELiveLinkAxis)this[nameof(UpAxis)].GetValue<int>(); } set { this[nameof(UpAxis)].SetValue<int>((int)value); } }
        public bool bUseOffsetPosition { get { return this[nameof(bUseOffsetPosition)].Flag; } set { this[nameof(bUseOffsetPosition)].Flag = value; } }
        public bool bUseOffsetOrientation { get { return this[nameof(bUseOffsetOrientation)].Flag; } set { this[nameof(bUseOffsetOrientation)].Flag = value; } }
        public Vector OffsetPosition { get { return this[nameof(OffsetPosition)].As<Vector>(); } set { this["OffsetPosition"] = value; } }
        public Rotator OffsetOrientation { get { return this[nameof(OffsetOrientation)].As<Rotator>(); } set { this["OffsetOrientation"] = value; } }
    }
    public class LiveLinkAnimationAxisSwitchPreProcessor : LiveLinkTransformAxisSwitchPreProcessor
    {
        public LiveLinkAnimationAxisSwitchPreProcessor(nint addr) : base(addr) { }
    }
    public class LiveLinkAnimationRoleToTransform : LiveLinkFrameTranslator
    {
        public LiveLinkAnimationRoleToTransform(nint addr) : base(addr) { }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
    }
    public class LiveLinkBlueprintVirtualSubject : LiveLinkVirtualSubject
    {
        public LiveLinkBlueprintVirtualSubject(nint addr) : base(addr) { }
        public bool UpdateVirtualSubjectStaticData_Internal(LiveLinkBaseStaticData InStruct) { return Invoke<bool>(nameof(UpdateVirtualSubjectStaticData_Internal), InStruct); }
        public bool UpdateVirtualSubjectFrameData_Internal(LiveLinkBaseFrameData InStruct, bool bInShouldStampCurrentTime) { return Invoke<bool>(nameof(UpdateVirtualSubjectFrameData_Internal), InStruct, bInShouldStampCurrentTime); }
        public void OnUpdate() { Invoke(nameof(OnUpdate)); }
        public void OnInitialize() { Invoke(nameof(OnInitialize)); }
    }
    public enum ELiveLinkTimecodeProviderEvaluationType : int
    {
        Lerp = 0,
        Nearest = 1,
        Latest = 2,
        ELiveLinkTimecodeProviderEvaluationType_MAX = 3,
    }
    public enum ELiveLinkAxis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        XNeg = 3,
        YNeg = 4,
        ZNeg = 5,
        ELiveLinkAxis_MAX = 6,
    }
    public class LiveLinkRetargetAssetReference : Object
    {
        public LiveLinkRetargetAssetReference(nint addr) : base(addr) { }
    }
    public class ProviderPollResult : Object
    {
        public ProviderPollResult(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object MachineName { get { return this[nameof(MachineName)]; } set { this[nameof(MachineName)] = value; } }
        public double MachineTimeOffset { get { return this[nameof(MachineTimeOffset)].GetValue<double>(); } set { this[nameof(MachineTimeOffset)].SetValue<double>(value); } }
        public bool bIsValidProvider { get { return this[nameof(bIsValidProvider)].Flag; } set { this[nameof(bIsValidProvider)].Flag = value; } }
    }
    public class LiveLinkRoleProjectSetting : Object
    {
        public LiveLinkRoleProjectSetting(nint addr) : base(addr) { }
        public Object Role { get { return this[nameof(Role)]; } set { this[nameof(Role)] = value; } }
        public Object SettingClass { get { return this[nameof(SettingClass)]; } set { this[nameof(SettingClass)] = value; } }
        public Object FrameInterpolationProcessor { get { return this[nameof(FrameInterpolationProcessor)]; } set { this[nameof(FrameInterpolationProcessor)] = value; } }
        public Array<Object> FramePreProcessors { get { return new Array<Object>(this[nameof(FramePreProcessors)].Address); } }
    }
}
