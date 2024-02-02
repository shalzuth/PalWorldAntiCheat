using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.SlateSDK;
namespace SDK.Script.EnhancedInputSDK
{
    public class EnhancedInputActionDelegateBinding : InputDelegateBinding
    {
        public EnhancedInputActionDelegateBinding(nint addr) : base(addr) { }
        public Array<BlueprintEnhancedInputActionBinding> InputActionDelegateBindings { get { return new Array<BlueprintEnhancedInputActionBinding>(this[nameof(InputActionDelegateBindings)].Address); } }
    }
    public class EnhancedInputActionValueBinding : InputDelegateBinding
    {
        public EnhancedInputActionValueBinding(nint addr) : base(addr) { }
        public Array<BlueprintEnhancedInputActionBinding> InputActionValueBindings { get { return new Array<BlueprintEnhancedInputActionBinding>(this[nameof(InputActionValueBindings)].Address); } }
    }
    public class EnhancedInputComponent : InputComponent
    {
        public EnhancedInputComponent(nint addr) : base(addr) { }
        public InputActionValue GetBoundActionValue(InputAction action) { return Invoke<InputActionValue>(nameof(GetBoundActionValue), action); }
    }
    public class EnhancedInputDeveloperSettings : DeveloperSettingsBackedByCVars
    {
        public EnhancedInputDeveloperSettings(nint addr) : base(addr) { }
        public PerPlatformSettings PlatformSettings { get { return this[nameof(PlatformSettings)].As<PerPlatformSettings>(); } set { this["PlatformSettings"] = value; } }
        public bool bShouldOnlyTriggerLastActionInChord { get { return this[nameof(bShouldOnlyTriggerLastActionInChord)].Flag; } set { this[nameof(bShouldOnlyTriggerLastActionInChord)].Flag = value; } }
    }
    public class EnhancedInputLibrary : BlueprintFunctionLibrary
    {
        public EnhancedInputLibrary(nint addr) : base(addr) { }
        public void RequestRebuildControlMappingsUsingContext(InputMappingContext Context, bool bForceImmediately) { Invoke(nameof(RequestRebuildControlMappingsUsingContext), Context, bForceImmediately); }
        public InputActionValue MakeInputActionValueOfType(double X, double Y, double Z, EInputActionValueType ValueType) { return Invoke<InputActionValue>(nameof(MakeInputActionValueOfType), X, Y, Z, ValueType); }
        public InputActionValue MakeInputActionValue(double X, double Y, double Z, InputActionValue MatchValueType) { return Invoke<InputActionValue>(nameof(MakeInputActionValue), X, Y, Z, MatchValueType); }
        public InputActionValue GetBoundActionValue(Actor Actor, InputAction action) { return Invoke<InputActionValue>(nameof(GetBoundActionValue), Actor, action); }
        public Object Conv_InputActionValueToString(InputActionValue ActionValue) { return Invoke<Object>(nameof(Conv_InputActionValueToString), ActionValue); }
        public bool Conv_InputActionValueToBool(InputActionValue InValue) { return Invoke<bool>(nameof(Conv_InputActionValueToBool), InValue); }
        public Vector Conv_InputActionValueToAxis3D(InputActionValue ActionValue) { return Invoke<Vector>(nameof(Conv_InputActionValueToAxis3D), ActionValue); }
        public Vector2D Conv_InputActionValueToAxis2D(InputActionValue InValue) { return Invoke<Vector2D>(nameof(Conv_InputActionValueToAxis2D), InValue); }
        public double Conv_InputActionValueToAxis1D(InputActionValue InValue) { return Invoke<double>(nameof(Conv_InputActionValueToAxis1D), InValue); }
        public void BreakInputActionValue(InputActionValue InActionValue, double X, double Y, double Z, EInputActionValueType Type) { Invoke(nameof(BreakInputActionValue), InActionValue, X, Y, Z, Type); }
    }
    public class EnhancedInputPlatformData : Object
    {
        public EnhancedInputPlatformData(nint addr) : base(addr) { }
        public Object MappingContextRedirects { get { return this[nameof(MappingContextRedirects)]; } set { this[nameof(MappingContextRedirects)] = value; } }
        public InputMappingContext GetContextRedirect(InputMappingContext InContext) { return Invoke<InputMappingContext>(nameof(GetContextRedirect), InContext); }
    }
    public class EnhancedInputPlatformSettings : PlatformSettings
    {
        public EnhancedInputPlatformSettings(nint addr) : base(addr) { }
        public Array<Object> InputData { get { return new Array<Object>(this[nameof(InputData)].Address); } }
        public Array<Object> InputDataClasses { get { return new Array<Object>(this[nameof(InputDataClasses)].Address); } }
        public bool bShouldLogMappingContextRedirects { get { return this[nameof(bShouldLogMappingContextRedirects)].Flag; } set { this[nameof(bShouldLogMappingContextRedirects)].Flag = value; } }
    }
    public class EnhancedInputSubsystemInterface : Interface
    {
        public EnhancedInputSubsystemInterface(nint addr) : base(addr) { }
        public void RequestRebuildControlMappings(ModifyContextOptions Options, EInputMappingRebuildType RebuildType) { Invoke(nameof(RequestRebuildControlMappings), Options, RebuildType); }
        public int RemovePlayerMappedKey(Object MappingName, ModifyContextOptions Options) { return Invoke<int>(nameof(RemovePlayerMappedKey), MappingName, Options); }
        public void RemovePlayerMappableConfig(PlayerMappableInputConfig Config, ModifyContextOptions Options) { Invoke(nameof(RemovePlayerMappableConfig), Config, Options); }
        public void RemoveMappingContext(InputMappingContext MappingContext, ModifyContextOptions Options) { Invoke(nameof(RemoveMappingContext), MappingContext, Options); }
        public void RemoveAllPlayerMappedKeys(ModifyContextOptions Options) { Invoke(nameof(RemoveAllPlayerMappedKeys), Options); }
        public EMappingQueryResult QueryMapKeyInContextSet(Array<InputMappingContext> PrioritizedActiveContexts, InputMappingContext InputContext, InputAction action, Key Key, Array<MappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues) { return Invoke<EMappingQueryResult>(nameof(QueryMapKeyInContextSet), PrioritizedActiveContexts, InputContext, action, Key, OutIssues, BlockingIssues); }
        public EMappingQueryResult QueryMapKeyInActiveContextSet(InputMappingContext InputContext, InputAction action, Key Key, Array<MappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues) { return Invoke<EMappingQueryResult>(nameof(QueryMapKeyInActiveContextSet), InputContext, action, Key, OutIssues, BlockingIssues); }
        public Array<Key> QueryKeysMappedToAction(InputAction action) { return Invoke<Array<Key>>(nameof(QueryKeysMappedToAction), action); }
        public void InjectInputVectorForAction(InputAction action, Vector Value, Array<InputModifier> Modifiers, Array<InputTrigger> Triggers) { Invoke(nameof(InjectInputVectorForAction), action, Value, Modifiers, Triggers); }
        public void InjectInputForAction(InputAction action, InputActionValue RawValue, Array<InputModifier> Modifiers, Array<InputTrigger> Triggers) { Invoke(nameof(InjectInputForAction), action, RawValue, Modifiers, Triggers); }
        public bool HasMappingContext(InputMappingContext MappingContext, int OutFoundPriority) { return Invoke<bool>(nameof(HasMappingContext), MappingContext, OutFoundPriority); }
        public Key GetPlayerMappedKey(Object MappingName) { return Invoke<Key>(nameof(GetPlayerMappedKey), MappingName); }
        public Array<EnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings() { return Invoke<Array<EnhancedActionKeyMapping>>(nameof(GetAllPlayerMappableActionKeyMappings)); }
        public void ClearAllMappings() { Invoke(nameof(ClearAllMappings)); }
        public int AddPlayerMappedKey(Object MappingName, Key NewKey, ModifyContextOptions Options) { return Invoke<int>(nameof(AddPlayerMappedKey), MappingName, NewKey, Options); }
        public void AddPlayerMappableConfig(PlayerMappableInputConfig Config, ModifyContextOptions Options) { Invoke(nameof(AddPlayerMappableConfig), Config, Options); }
        public void AddMappingContext(InputMappingContext MappingContext, int Priority, ModifyContextOptions Options) { Invoke(nameof(AddMappingContext), MappingContext, Priority, Options); }
    }
    public class EnhancedInputLocalPlayerSubsystem : LocalPlayerSubsystem
    {
        public EnhancedInputLocalPlayerSubsystem(nint addr) : base(addr) { }
        public Object ControlMappingsRebuiltDelegate { get { return this[nameof(ControlMappingsRebuiltDelegate)]; } set { this[nameof(ControlMappingsRebuiltDelegate)] = value; } }
    }
    public class EnhancedPlayerInput : PlayerInput
    {
        public EnhancedPlayerInput(nint addr) : base(addr) { }
        public Object AppliedInputContexts { get { return this[nameof(AppliedInputContexts)]; } set { this[nameof(AppliedInputContexts)] = value; } }
        public Array<EnhancedActionKeyMapping> EnhancedActionMappings { get { return new Array<EnhancedActionKeyMapping>(this[nameof(EnhancedActionMappings)].Address); } }
        public Object ActionInstanceData { get { return this[nameof(ActionInstanceData)]; } set { this[nameof(ActionInstanceData)] = value; } }
        public Object KeysPressedThisTick { get { return this[nameof(KeysPressedThisTick)]; } set { this[nameof(KeysPressedThisTick)] = value; } }
        public Object InputsInjectedThisTick { get { return this[nameof(InputsInjectedThisTick)]; } set { this[nameof(InputsInjectedThisTick)] = value; } }
        public Object LastInjectedActions { get { return this[nameof(LastInjectedActions)]; } set { this[nameof(LastInjectedActions)] = value; } }
    }
    public class InputAction : DataAsset
    {
        public InputAction(nint addr) : base(addr) { }
        public Object ActionDescription { get { return this[nameof(ActionDescription)]; } set { this[nameof(ActionDescription)] = value; } }
        public bool bConsumeInput { get { return this[nameof(bConsumeInput)].Flag; } set { this[nameof(bConsumeInput)].Flag = value; } }
        public bool bTriggerWhenPaused { get { return this[nameof(bTriggerWhenPaused)].Flag; } set { this[nameof(bTriggerWhenPaused)].Flag = value; } }
        public bool bReserveAllMappings { get { return this[nameof(bReserveAllMappings)].Flag; } set { this[nameof(bReserveAllMappings)].Flag = value; } }
        public EInputActionValueType ValueType { get { return (EInputActionValueType)this[nameof(ValueType)].GetValue<int>(); } set { this[nameof(ValueType)].SetValue<int>((int)value); } }
        public Array<InputTrigger> Triggers { get { return new Array<InputTrigger>(this[nameof(Triggers)].Address); } }
        public Array<InputModifier> Modifiers { get { return new Array<InputModifier>(this[nameof(Modifiers)].Address); } }
    }
    public class InputDebugKeyDelegateBinding : InputDelegateBinding
    {
        public InputDebugKeyDelegateBinding(nint addr) : base(addr) { }
        public Array<BlueprintInputDebugKeyDelegateBinding> InputDebugKeyDelegateBindings { get { return new Array<BlueprintInputDebugKeyDelegateBinding>(this[nameof(InputDebugKeyDelegateBindings)].Address); } }
    }
    public class InputMappingContext : DataAsset
    {
        public InputMappingContext(nint addr) : base(addr) { }
        public Array<EnhancedActionKeyMapping> Mappings { get { return new Array<EnhancedActionKeyMapping>(this[nameof(Mappings)].Address); } }
        public Object ContextDescription { get { return this[nameof(ContextDescription)]; } set { this[nameof(ContextDescription)] = value; } }
        public void UnmapKey(InputAction action, Key Key) { Invoke(nameof(UnmapKey), action, Key); }
        public void UnmapAllKeysFromAction(InputAction action) { Invoke(nameof(UnmapAllKeysFromAction), action); }
        public void UnmapAll() { Invoke(nameof(UnmapAll)); }
        public void UnmapAction(InputAction action) { Invoke(nameof(UnmapAction), action); }
        public EnhancedActionKeyMapping MapKey(InputAction action, Key ToKey) { return Invoke<EnhancedActionKeyMapping>(nameof(MapKey), action, ToKey); }
    }
    public class InputModifier : Object
    {
        public InputModifier(nint addr) : base(addr) { }
        public InputActionValue ModifyRaw(EnhancedPlayerInput PlayerInput, InputActionValue CurrentValue, float DeltaTime) { return Invoke<InputActionValue>(nameof(ModifyRaw), PlayerInput, CurrentValue, DeltaTime); }
        public LinearColor GetVisualizationColor(InputActionValue SampleValue, InputActionValue FinalValue) { return Invoke<LinearColor>(nameof(GetVisualizationColor), SampleValue, FinalValue); }
    }
    public class InputModifierDeadZone : InputModifier
    {
        public InputModifierDeadZone(nint addr) : base(addr) { }
        public float LowerThreshold { get { return this[nameof(LowerThreshold)].GetValue<float>(); } set { this[nameof(LowerThreshold)].SetValue<float>(value); } }
        public float UpperThreshold { get { return this[nameof(UpperThreshold)].GetValue<float>(); } set { this[nameof(UpperThreshold)].SetValue<float>(value); } }
        public EDeadZoneType Type { get { return (EDeadZoneType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class InputModifierScalar : InputModifier
    {
        public InputModifierScalar(nint addr) : base(addr) { }
        public Vector Scalar { get { return this[nameof(Scalar)].As<Vector>(); } set { this["Scalar"] = value; } }
    }
    public class InputModifierScaleByDeltaTime : InputModifier
    {
        public InputModifierScaleByDeltaTime(nint addr) : base(addr) { }
    }
    public class InputModifierNegate : InputModifier
    {
        public InputModifierNegate(nint addr) : base(addr) { }
        public bool bX { get { return this[nameof(bX)].Flag; } set { this[nameof(bX)].Flag = value; } }
        public bool bY { get { return this[nameof(bY)].Flag; } set { this[nameof(bY)].Flag = value; } }
        public bool bZ { get { return this[nameof(bZ)].Flag; } set { this[nameof(bZ)].Flag = value; } }
    }
    public class InputModifierSmooth : InputModifier
    {
        public InputModifierSmooth(nint addr) : base(addr) { }
    }
    public class InputModifierResponseCurveExponential : InputModifier
    {
        public InputModifierResponseCurveExponential(nint addr) : base(addr) { }
        public Vector CurveExponent { get { return this[nameof(CurveExponent)].As<Vector>(); } set { this["CurveExponent"] = value; } }
    }
    public class InputModifierResponseCurveUser : InputModifier
    {
        public InputModifierResponseCurveUser(nint addr) : base(addr) { }
        public CurveFloat ResponseX { get { return this[nameof(ResponseX)].As<CurveFloat>(); } set { this["ResponseX"] = value; } }
        public CurveFloat ResponseY { get { return this[nameof(ResponseY)].As<CurveFloat>(); } set { this["ResponseY"] = value; } }
        public CurveFloat ResponseZ { get { return this[nameof(ResponseZ)].As<CurveFloat>(); } set { this["ResponseZ"] = value; } }
    }
    public class InputModifierFOVScaling : InputModifier
    {
        public InputModifierFOVScaling(nint addr) : base(addr) { }
        public float FOVScale { get { return this[nameof(FOVScale)].GetValue<float>(); } set { this[nameof(FOVScale)].SetValue<float>(value); } }
        public EFOVScalingType FOVScalingType { get { return (EFOVScalingType)this[nameof(FOVScalingType)].GetValue<int>(); } set { this[nameof(FOVScalingType)].SetValue<int>((int)value); } }
    }
    public class InputModifierToWorldSpace : InputModifier
    {
        public InputModifierToWorldSpace(nint addr) : base(addr) { }
    }
    public class InputModifierSwizzleAxis : InputModifier
    {
        public InputModifierSwizzleAxis(nint addr) : base(addr) { }
        public EInputAxisSwizzle Order { get { return (EInputAxisSwizzle)this[nameof(Order)].GetValue<int>(); } set { this[nameof(Order)].SetValue<int>((int)value); } }
    }
    public class InputTrigger : Object
    {
        public InputTrigger(nint addr) : base(addr) { }
        public float ActuationThreshold { get { return this[nameof(ActuationThreshold)].GetValue<float>(); } set { this[nameof(ActuationThreshold)].SetValue<float>(value); } }
        public bool bShouldAlwaysTick { get { return this[nameof(bShouldAlwaysTick)].Flag; } set { this[nameof(bShouldAlwaysTick)].Flag = value; } }
        public InputActionValue LastValue { get { return this[nameof(LastValue)].As<InputActionValue>(); } set { this["LastValue"] = value; } }
        public ETriggerState UpdateState(EnhancedPlayerInput PlayerInput, InputActionValue ModifiedValue, float DeltaTime) { return Invoke<ETriggerState>(nameof(UpdateState), PlayerInput, ModifiedValue, DeltaTime); }
        public bool IsActuated(InputActionValue ForValue) { return Invoke<bool>(nameof(IsActuated), ForValue); }
        public ETriggerType GetTriggerType() { return Invoke<ETriggerType>(nameof(GetTriggerType)); }
    }
    public class InputTriggerTimedBase : InputTrigger
    {
        public InputTriggerTimedBase(nint addr) : base(addr) { }
        public float HeldDuration { get { return this[nameof(HeldDuration)].GetValue<float>(); } set { this[nameof(HeldDuration)].SetValue<float>(value); } }
        public bool bAffectedByTimeDilation { get { return this[nameof(bAffectedByTimeDilation)].Flag; } set { this[nameof(bAffectedByTimeDilation)].Flag = value; } }
    }
    public class InputTriggerDown : InputTrigger
    {
        public InputTriggerDown(nint addr) : base(addr) { }
    }
    public class InputTriggerPressed : InputTrigger
    {
        public InputTriggerPressed(nint addr) : base(addr) { }
    }
    public class InputTriggerReleased : InputTrigger
    {
        public InputTriggerReleased(nint addr) : base(addr) { }
    }
    public class InputTriggerHold : InputTriggerTimedBase
    {
        public InputTriggerHold(nint addr) : base(addr) { }
        public float HoldTimeThreshold { get { return this[nameof(HoldTimeThreshold)].GetValue<float>(); } set { this[nameof(HoldTimeThreshold)].SetValue<float>(value); } }
        public bool bIsOneShot { get { return this[nameof(bIsOneShot)].Flag; } set { this[nameof(bIsOneShot)].Flag = value; } }
    }
    public class InputTriggerHoldAndRelease : InputTriggerTimedBase
    {
        public InputTriggerHoldAndRelease(nint addr) : base(addr) { }
        public float HoldTimeThreshold { get { return this[nameof(HoldTimeThreshold)].GetValue<float>(); } set { this[nameof(HoldTimeThreshold)].SetValue<float>(value); } }
    }
    public class InputTriggerTap : InputTriggerTimedBase
    {
        public InputTriggerTap(nint addr) : base(addr) { }
        public float TapReleaseTimeThreshold { get { return this[nameof(TapReleaseTimeThreshold)].GetValue<float>(); } set { this[nameof(TapReleaseTimeThreshold)].SetValue<float>(value); } }
    }
    public class InputTriggerPulse : InputTriggerTimedBase
    {
        public InputTriggerPulse(nint addr) : base(addr) { }
        public bool bTriggerOnStart { get { return this[nameof(bTriggerOnStart)].Flag; } set { this[nameof(bTriggerOnStart)].Flag = value; } }
        public float Interval { get { return this[nameof(Interval)].GetValue<float>(); } set { this[nameof(Interval)].SetValue<float>(value); } }
        public int TriggerLimit { get { return this[nameof(TriggerLimit)].GetValue<int>(); } set { this[nameof(TriggerLimit)].SetValue<int>(value); } }
    }
    public class InputTriggerChordAction : InputTrigger
    {
        public InputTriggerChordAction(nint addr) : base(addr) { }
        public InputAction ChordAction { get { return this[nameof(ChordAction)].As<InputAction>(); } set { this["ChordAction"] = value; } }
    }
    public class InputTriggerChordBlocker : InputTriggerChordAction
    {
        public InputTriggerChordBlocker(nint addr) : base(addr) { }
    }
    public class InputTriggerCombo : InputTrigger
    {
        public InputTriggerCombo(nint addr) : base(addr) { }
        public int CurrentComboStepIndex { get { return this[nameof(CurrentComboStepIndex)].GetValue<int>(); } set { this[nameof(CurrentComboStepIndex)].SetValue<int>(value); } }
        public float CurrentTimeBetweenComboSteps { get { return this[nameof(CurrentTimeBetweenComboSteps)].GetValue<float>(); } set { this[nameof(CurrentTimeBetweenComboSteps)].SetValue<float>(value); } }
        public Array<InputComboStepData> ComboActions { get { return new Array<InputComboStepData>(this[nameof(ComboActions)].Address); } }
        public Array<InputAction> CancelActions { get { return new Array<InputAction>(this[nameof(CancelActions)].Address); } }
    }
    public class PlayerMappableInputConfig : PrimaryDataAsset
    {
        public PlayerMappableInputConfig(nint addr) : base(addr) { }
        public Object ConfigName { get { return this[nameof(ConfigName)]; } set { this[nameof(ConfigName)] = value; } }
        public Object ConfigDisplayName { get { return this[nameof(ConfigDisplayName)]; } set { this[nameof(ConfigDisplayName)] = value; } }
        public bool bIsDeprecated { get { return this[nameof(bIsDeprecated)].Flag; } set { this[nameof(bIsDeprecated)].Flag = value; } }
        public Object MetaData { get { return this[nameof(MetaData)].As<Object>(); } set { this["MetaData"] = value; } }
        public Object Contexts { get { return this[nameof(Contexts)]; } set { this[nameof(Contexts)] = value; } }
        public void ResetToDefault() { Invoke(nameof(ResetToDefault)); }
        public bool IsDeprecated() { return Invoke<bool>(nameof(IsDeprecated)); }
        public Array<EnhancedActionKeyMapping> GetPlayerMappableKeys() { return Invoke<Array<EnhancedActionKeyMapping>>(nameof(GetPlayerMappableKeys)); }
        public Object GetMetadata() { return Invoke<Object>(nameof(GetMetadata)); }
        public Object GetMappingContexts() { return Invoke<Object>(nameof(GetMappingContexts)); }
        public EnhancedActionKeyMapping GetMappingByName(Object MappingName) { return Invoke<EnhancedActionKeyMapping>(nameof(GetMappingByName), MappingName); }
        public Array<EnhancedActionKeyMapping> GetKeysBoundToAction(InputAction InAction) { return Invoke<Array<EnhancedActionKeyMapping>>(nameof(GetKeysBoundToAction), InAction); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetConfigName() { return Invoke<Object>(nameof(GetConfigName)); }
    }
    public class InputActionValue : Object
    {
        public InputActionValue(nint addr) : base(addr) { }
    }
    public enum EInputActionValueType : int
    {
        Boolean = 0,
        Axis1D = 1,
        Axis2D = 2,
        Axis3D = 3,
        EInputActionValueType_MAX = 4,
    }
    public enum EMappingQueryResult : int
    {
        Error_EnhancedInputNotEnabled = 0,
        Error_InputContextNotInActiveContexts = 1,
        Error_InvalidAction = 2,
        NotMappable = 3,
        MappingAvailable = 4,
        EMappingQueryResult_MAX = 5,
    }
    public enum EMappingQueryIssue : int
    {
        NoIssue = 0,
        ReservedByAction = 1,
        HidesExistingMapping = 2,
        HiddenByExistingMapping = 4,
        CollisionWithMappingInSameContext = 8,
        ForcesTypePromotion = 16,
        ForcesTypeDemotion = 32,
        EMappingQueryIssue_MAX = 33,
    }
    public enum EInputMappingRebuildType : int
    {
        None = 0,
        Rebuild = 1,
        RebuildWithFlush = 2,
        EInputMappingRebuildType_MAX = 3,
    }
    public enum EDeadZoneType : int
    {
        Axial = 0,
        Radial = 1,
        EDeadZoneType_MAX = 2,
    }
    public enum EFOVScalingType : int
    {
        Standard = 0,
        UE4_BackCompat = 1,
        EFOVScalingType_MAX = 2,
    }
    public enum EInputAxisSwizzle : int
    {
        YXZ = 0,
        ZYX = 1,
        XZY = 2,
        YZX = 3,
        ZXY = 4,
        EInputAxisSwizzle_MAX = 5,
    }
    public enum ETriggerState : int
    {
        None = 0,
        Ongoing = 1,
        Triggered = 2,
        ETriggerState_MAX = 3,
    }
    public enum ETriggerEvent : int
    {
        None = 0,
        Triggered = 1,
        Started = 2,
        Ongoing = 3,
        Canceled = 4,
        Completed = 5,
        ETriggerEvent_MAX = 6,
    }
    public enum ETriggerType : int
    {
        Explicit = 0,
        Implicit = 1,
        Blocker = 2,
        ETriggerType_MAX = 3,
    }
    public enum ETriggerEventsSupported : int
    {
        None = 0,
        Instant = 1,
        Uninterruptible = 2,
        Ongoing = 4,
        All = 7,
        ETriggerEventsSupported_MAX = 8,
    }
    public class PlayerMappableKeyOptions : Object
    {
        public PlayerMappableKeyOptions(nint addr) : base(addr) { }
        public Object MetaData { get { return this[nameof(MetaData)].As<Object>(); } set { this["MetaData"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object DisplayCategory { get { return this[nameof(DisplayCategory)]; } set { this[nameof(DisplayCategory)] = value; } }
    }
    public class EnhancedActionKeyMapping : Object
    {
        public EnhancedActionKeyMapping(nint addr) : base(addr) { }
        public PlayerMappableKeyOptions PlayerMappableOptions { get { return this[nameof(PlayerMappableOptions)].As<PlayerMappableKeyOptions>(); } set { this["PlayerMappableOptions"] = value; } }
        public Array<InputTrigger> Triggers { get { return new Array<InputTrigger>(this[nameof(Triggers)].Address); } }
        public Array<InputModifier> Modifiers { get { return new Array<InputModifier>(this[nameof(Modifiers)].Address); } }
        public InputAction action { get { return this[nameof(action)].As<InputAction>(); } set { this["action"] = value; } }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public bool bIsPlayerMappable { get { return this[nameof(bIsPlayerMappable)].Flag; } set { this[nameof(bIsPlayerMappable)].Flag = value; } }
        public bool bShouldBeIgnored { get { return this[nameof(bShouldBeIgnored)].Flag; } set { this[nameof(bShouldBeIgnored)].Flag = value; } }
    }
    public class MappingQueryIssue : Object
    {
        public MappingQueryIssue(nint addr) : base(addr) { }
        public EMappingQueryIssue Issue { get { return (EMappingQueryIssue)this[nameof(Issue)].GetValue<int>(); } set { this[nameof(Issue)].SetValue<int>((int)value); } }
        public InputMappingContext BlockingContext { get { return this[nameof(BlockingContext)].As<InputMappingContext>(); } set { this["BlockingContext"] = value; } }
        public InputAction BlockingAction { get { return this[nameof(BlockingAction)].As<InputAction>(); } set { this["BlockingAction"] = value; } }
    }
    public class BlueprintEnhancedInputActionBinding : Object
    {
        public BlueprintEnhancedInputActionBinding(nint addr) : base(addr) { }
        public InputAction InputAction { get { return this[nameof(InputAction)].As<InputAction>(); } set { this["InputAction"] = value; } }
        public ETriggerEvent TriggerEvent { get { return (ETriggerEvent)this[nameof(TriggerEvent)].GetValue<int>(); } set { this[nameof(TriggerEvent)].SetValue<int>((int)value); } }
        public Object FunctionNameToBind { get { return this[nameof(FunctionNameToBind)]; } set { this[nameof(FunctionNameToBind)] = value; } }
    }
    public class ModifyContextOptions : Object
    {
        public ModifyContextOptions(nint addr) : base(addr) { }
        public bool bIgnoreAllPressedKeysUntilRelease { get { return this[nameof(bIgnoreAllPressedKeysUntilRelease)].Flag; } set { this[nameof(bIgnoreAllPressedKeysUntilRelease)].Flag = value; } }
        public bool bForceImmediately { get { return this[nameof(bForceImmediately)].Flag; } set { this[nameof(bForceImmediately)].Flag = value; } }
    }
    public class InjectedInputArray : Object
    {
        public InjectedInputArray(nint addr) : base(addr) { }
    }
    public class InputActionInstance : Object
    {
        public InputActionInstance(nint addr) : base(addr) { }
        public InputAction SourceAction { get { return this[nameof(SourceAction)].As<InputAction>(); } set { this["SourceAction"] = value; } }
        public ETriggerEvent TriggerEvent { get { return (ETriggerEvent)this[nameof(TriggerEvent)].GetValue<int>(); } set { this[nameof(TriggerEvent)].SetValue<int>((int)value); } }
        public float LastTriggeredWorldTime { get { return this[nameof(LastTriggeredWorldTime)].GetValue<float>(); } set { this[nameof(LastTriggeredWorldTime)].SetValue<float>(value); } }
        public Array<InputTrigger> Triggers { get { return new Array<InputTrigger>(this[nameof(Triggers)].Address); } }
        public Array<InputModifier> Modifiers { get { return new Array<InputModifier>(this[nameof(Modifiers)].Address); } }
        public float ElapsedProcessedTime { get { return this[nameof(ElapsedProcessedTime)].GetValue<float>(); } set { this[nameof(ElapsedProcessedTime)].SetValue<float>(value); } }
        public float ElapsedTriggeredTime { get { return this[nameof(ElapsedTriggeredTime)].GetValue<float>(); } set { this[nameof(ElapsedTriggeredTime)].SetValue<float>(value); } }
    }
    public class BlueprintInputDebugKeyDelegateBinding : Object
    {
        public BlueprintInputDebugKeyDelegateBinding(nint addr) : base(addr) { }
        public InputChord InputChord { get { return this[nameof(InputChord)].As<InputChord>(); } set { this["InputChord"] = value; } }
        public byte InputKeyEvent { get { return this[nameof(InputKeyEvent)].GetValue<byte>(); } set { this[nameof(InputKeyEvent)].SetValue<byte>(value); } }
        public Object FunctionNameToBind { get { return this[nameof(FunctionNameToBind)]; } set { this[nameof(FunctionNameToBind)] = value; } }
        public bool bExecuteWhenPaused { get { return this[nameof(bExecuteWhenPaused)].Flag; } set { this[nameof(bExecuteWhenPaused)].Flag = value; } }
    }
    public class InputComboStepData : Object
    {
        public InputComboStepData(nint addr) : base(addr) { }
        public InputAction ComboStepAction { get { return this[nameof(ComboStepAction)].As<InputAction>(); } set { this["ComboStepAction"] = value; } }
        public float TimeToPressKey { get { return this[nameof(TimeToPressKey)].GetValue<float>(); } set { this[nameof(TimeToPressKey)].SetValue<float>(value); } }
    }
}
