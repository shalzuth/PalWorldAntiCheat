using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.CommonInputSDK
{
    public class CommonInputActionDomain : DataAsset
    {
        public CommonInputActionDomain(nint addr) : base(addr) { }
        public ECommonInputEventFlowBehavior Behavior { get { return (ECommonInputEventFlowBehavior)this[nameof(Behavior)].GetValue<int>(); } set { this[nameof(Behavior)].SetValue<int>((int)value); } }
        public ECommonInputEventFlowBehavior InnerBehavior { get { return (ECommonInputEventFlowBehavior)this[nameof(InnerBehavior)].GetValue<int>(); } set { this[nameof(InnerBehavior)].SetValue<int>((int)value); } }
        public bool bUseActionDomainDesiredInputConfig { get { return this[nameof(bUseActionDomainDesiredInputConfig)].Flag; } set { this[nameof(bUseActionDomainDesiredInputConfig)].Flag = value; } }
        public ECommonInputMode InputMode { get { return (ECommonInputMode)this[nameof(InputMode)].GetValue<int>(); } set { this[nameof(InputMode)].SetValue<int>((int)value); } }
        public EMouseCaptureMode MouseCaptureMode { get { return (EMouseCaptureMode)this[nameof(MouseCaptureMode)].GetValue<int>(); } set { this[nameof(MouseCaptureMode)].SetValue<int>((int)value); } }
    }
    public class CommonInputActionDomainTable : DataAsset
    {
        public CommonInputActionDomainTable(nint addr) : base(addr) { }
        public Array<CommonInputActionDomain> ActionDomains { get { return new Array<CommonInputActionDomain>(this[nameof(ActionDomains)].Address); } }
        public ECommonInputMode InputMode { get { return (ECommonInputMode)this[nameof(InputMode)].GetValue<int>(); } set { this[nameof(InputMode)].SetValue<int>((int)value); } }
        public EMouseCaptureMode MouseCaptureMode { get { return (EMouseCaptureMode)this[nameof(MouseCaptureMode)].GetValue<int>(); } set { this[nameof(MouseCaptureMode)].SetValue<int>((int)value); } }
    }
    public class CommonUIInputData : Object
    {
        public CommonUIInputData(nint addr) : base(addr) { }
        public DataTableRowHandle DefaultClickAction { get { return this[nameof(DefaultClickAction)].As<DataTableRowHandle>(); } set { this["DefaultClickAction"] = value; } }
        public DataTableRowHandle DefaultBackAction { get { return this[nameof(DefaultBackAction)].As<DataTableRowHandle>(); } set { this["DefaultBackAction"] = value; } }
    }
    public class CommonInputBaseControllerData : Object
    {
        public CommonInputBaseControllerData(nint addr) : base(addr) { }
        public ECommonInputType InputType { get { return (ECommonInputType)this[nameof(InputType)].GetValue<int>(); } set { this[nameof(InputType)].SetValue<int>((int)value); } }
        public Object GamepadName { get { return this[nameof(GamepadName)]; } set { this[nameof(GamepadName)] = value; } }
        public Object GamepadDisplayName { get { return this[nameof(GamepadDisplayName)]; } set { this[nameof(GamepadDisplayName)] = value; } }
        public Object GamepadCategory { get { return this[nameof(GamepadCategory)]; } set { this[nameof(GamepadCategory)] = value; } }
        public Object GamepadPlatformName { get { return this[nameof(GamepadPlatformName)]; } set { this[nameof(GamepadPlatformName)] = value; } }
        public Array<InputDeviceIdentifierPair> GamepadHardwareIdMapping { get { return new Array<InputDeviceIdentifierPair>(this[nameof(GamepadHardwareIdMapping)].Address); } }
        public Object ControllerTexture { get { return this[nameof(ControllerTexture)]; } set { this[nameof(ControllerTexture)] = value; } }
        public Object ControllerButtonMaskTexture { get { return this[nameof(ControllerButtonMaskTexture)]; } set { this[nameof(ControllerButtonMaskTexture)] = value; } }
        public Array<CommonInputKeyBrushConfiguration> InputBrushDataMap { get { return new Array<CommonInputKeyBrushConfiguration>(this[nameof(InputBrushDataMap)].Address); } }
        public Array<CommonInputKeySetBrushConfiguration> InputBrushKeySets { get { return new Array<CommonInputKeySetBrushConfiguration>(this[nameof(InputBrushKeySets)].Address); } }
        public Array<Object> GetRegisteredGamepads() { return Invoke<Array<Object>>(nameof(GetRegisteredGamepads)); }
    }
    public class CommonInputPlatformSettings : PlatformSettings
    {
        public CommonInputPlatformSettings(nint addr) : base(addr) { }
        public ECommonInputType DefaultInputType { get { return (ECommonInputType)this[nameof(DefaultInputType)].GetValue<int>(); } set { this[nameof(DefaultInputType)].SetValue<int>((int)value); } }
        public bool bSupportsMouseAndKeyboard { get { return this[nameof(bSupportsMouseAndKeyboard)].Flag; } set { this[nameof(bSupportsMouseAndKeyboard)].Flag = value; } }
        public bool bSupportsTouch { get { return this[nameof(bSupportsTouch)].Flag; } set { this[nameof(bSupportsTouch)].Flag = value; } }
        public bool bSupportsGamepad { get { return this[nameof(bSupportsGamepad)].Flag; } set { this[nameof(bSupportsGamepad)].Flag = value; } }
        public Object DefaultGamepadName { get { return this[nameof(DefaultGamepadName)]; } set { this[nameof(DefaultGamepadName)] = value; } }
        public bool bCanChangeGamepadType { get { return this[nameof(bCanChangeGamepadType)].Flag; } set { this[nameof(bCanChangeGamepadType)].Flag = value; } }
        public Array<Object> ControllerData { get { return new Array<Object>(this[nameof(ControllerData)].Address); } }
        public Array<Object> ControllerDataClasses { get { return new Array<Object>(this[nameof(ControllerDataClasses)].Address); } }
    }
    public class CommonInputSettings : DeveloperSettings
    {
        public CommonInputSettings(nint addr) : base(addr) { }
        public Object InputData { get { return this[nameof(InputData)]; } set { this[nameof(InputData)] = value; } }
        public PerPlatformSettings PlatformInput { get { return this[nameof(PlatformInput)].As<PerPlatformSettings>(); } set { this["PlatformInput"] = value; } }
        public Object CommonInputPlatformData { get { return this[nameof(CommonInputPlatformData)]; } set { this[nameof(CommonInputPlatformData)] = value; } }
        public bool bEnableInputMethodThrashingProtection { get { return this[nameof(bEnableInputMethodThrashingProtection)].Flag; } set { this[nameof(bEnableInputMethodThrashingProtection)].Flag = value; } }
        public int InputMethodThrashingLimit { get { return this[nameof(InputMethodThrashingLimit)].GetValue<int>(); } set { this[nameof(InputMethodThrashingLimit)].SetValue<int>(value); } }
        public double InputMethodThrashingWindowInSeconds { get { return this[nameof(InputMethodThrashingWindowInSeconds)].GetValue<double>(); } set { this[nameof(InputMethodThrashingWindowInSeconds)].SetValue<double>(value); } }
        public double InputMethodThrashingCooldownInSeconds { get { return this[nameof(InputMethodThrashingCooldownInSeconds)].GetValue<double>(); } set { this[nameof(InputMethodThrashingCooldownInSeconds)].SetValue<double>(value); } }
        public bool bAllowOutOfFocusDeviceInput { get { return this[nameof(bAllowOutOfFocusDeviceInput)].Flag; } set { this[nameof(bAllowOutOfFocusDeviceInput)].Flag = value; } }
        public bool bEnableDefaultInputConfig { get { return this[nameof(bEnableDefaultInputConfig)].Flag; } set { this[nameof(bEnableDefaultInputConfig)].Flag = value; } }
        public Object ActionDomainTable { get { return this[nameof(ActionDomainTable)]; } set { this[nameof(ActionDomainTable)] = value; } }
        public Object InputDataClass { get { return this[nameof(InputDataClass)]; } set { this[nameof(InputDataClass)] = value; } }
        public CommonInputActionDomainTable ActionDomainTablePtr { get { return this[nameof(ActionDomainTablePtr)].As<CommonInputActionDomainTable>(); } set { this["ActionDomainTablePtr"] = value; } }
    }
    public class CommonInputSubsystem : LocalPlayerSubsystem
    {
        public CommonInputSubsystem(nint addr) : base(addr) { }
        public Object OnInputMethodChanged { get { return this[nameof(OnInputMethodChanged)]; } set { this[nameof(OnInputMethodChanged)] = value; } }
        public int NumberOfInputMethodChangesRecently { get { return this[nameof(NumberOfInputMethodChangesRecently)].GetValue<int>(); } set { this[nameof(NumberOfInputMethodChangesRecently)].SetValue<int>(value); } }
        public double LastInputMethodChangeTime { get { return this[nameof(LastInputMethodChangeTime)].GetValue<double>(); } set { this[nameof(LastInputMethodChangeTime)].SetValue<double>(value); } }
        public double LastTimeInputMethodThrashingBegan { get { return this[nameof(LastTimeInputMethodThrashingBegan)].GetValue<double>(); } set { this[nameof(LastTimeInputMethodThrashingBegan)].SetValue<double>(value); } }
        public ECommonInputType LastInputType { get { return (ECommonInputType)this[nameof(LastInputType)].GetValue<int>(); } set { this[nameof(LastInputType)].SetValue<int>((int)value); } }
        public ECommonInputType CurrentInputType { get { return (ECommonInputType)this[nameof(CurrentInputType)].GetValue<int>(); } set { this[nameof(CurrentInputType)].SetValue<int>((int)value); } }
        public Object GamepadInputType { get { return this[nameof(GamepadInputType)]; } set { this[nameof(GamepadInputType)] = value; } }
        public Object CurrentInputLocks { get { return this[nameof(CurrentInputLocks)]; } set { this[nameof(CurrentInputLocks)] = value; } }
        public CommonInputActionDomainTable ActionDomainTable { get { return this[nameof(ActionDomainTable)].As<CommonInputActionDomainTable>(); } set { this["ActionDomainTable"] = value; } }
        public bool bIsGamepadSimulatedClick { get { return this[nameof(bIsGamepadSimulatedClick)].Flag; } set { this[nameof(bIsGamepadSimulatedClick)].Flag = value; } }
        public bool ShouldShowInputKeys() { return Invoke<bool>(nameof(ShouldShowInputKeys)); }
        public void SetGamepadInputType(Object InGamepadInputType) { Invoke(nameof(SetGamepadInputType), InGamepadInputType); }
        public void SetCurrentInputType(ECommonInputType NewInputType) { Invoke(nameof(SetCurrentInputType), NewInputType); }
        public bool IsUsingPointerInput() { return Invoke<bool>(nameof(IsUsingPointerInput)); }
        public bool IsInputMethodActive(ECommonInputType InputMethod) { return Invoke<bool>(nameof(IsInputMethodActive), InputMethod); }
        public ECommonInputType GetDefaultInputType() { return Invoke<ECommonInputType>(nameof(GetDefaultInputType)); }
        public ECommonInputType GetCurrentInputType() { return Invoke<ECommonInputType>(nameof(GetCurrentInputType)); }
        public Object GetCurrentGamepadName() { return Invoke<Object>(nameof(GetCurrentGamepadName)); }
    }
    public enum ECommonInputType : int
    {
        MouseAndKeyboard = 0,
        Gamepad = 1,
        Touch = 2,
        Count = 3,
        ECommonInputType_MAX = 4,
    }
    public enum ECommonInputMode : int
    {
        Menu = 0,
        Game = 1,
        All = 2,
        MAX = 3,
    }
    public enum ECommonInputEventFlowBehavior : int
    {
        BlockIfActive = 0,
        BlockIfHandled = 1,
        NeverBlock = 2,
        ECommonInputEventFlowBehavior_MAX = 3,
    }
    public class CommonInputKeyBrushConfiguration : Object
    {
        public CommonInputKeyBrushConfiguration(nint addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public SlateBrush KeyBrush { get { return this[nameof(KeyBrush)].As<SlateBrush>(); } set { this["KeyBrush"] = value; } }
    }
    public class CommonInputKeySetBrushConfiguration : Object
    {
        public CommonInputKeySetBrushConfiguration(nint addr) : base(addr) { }
        public Array<Key> Keys { get { return new Array<Key>(this[nameof(Keys)].Address); } }
        public SlateBrush KeyBrush { get { return this[nameof(KeyBrush)].As<SlateBrush>(); } set { this["KeyBrush"] = value; } }
    }
    public class InputDeviceIdentifierPair : Object
    {
        public InputDeviceIdentifierPair(nint addr) : base(addr) { }
        public Object InputDeviceName { get { return this[nameof(InputDeviceName)]; } set { this[nameof(InputDeviceName)] = value; } }
        public Object HardwareDeviceIdentifier { get { return this[nameof(HardwareDeviceIdentifier)]; } set { this[nameof(HardwareDeviceIdentifier)] = value; } }
    }
    public class CommonInputPlatformBaseData : Object
    {
        public CommonInputPlatformBaseData(nint addr) : base(addr) { }
        public ECommonInputType DefaultInputType { get { return (ECommonInputType)this[nameof(DefaultInputType)].GetValue<int>(); } set { this[nameof(DefaultInputType)].SetValue<int>((int)value); } }
        public bool bSupportsMouseAndKeyboard { get { return this[nameof(bSupportsMouseAndKeyboard)].Flag; } set { this[nameof(bSupportsMouseAndKeyboard)].Flag = value; } }
        public bool bSupportsGamepad { get { return this[nameof(bSupportsGamepad)].Flag; } set { this[nameof(bSupportsGamepad)].Flag = value; } }
        public Object DefaultGamepadName { get { return this[nameof(DefaultGamepadName)]; } set { this[nameof(DefaultGamepadName)] = value; } }
        public bool bCanChangeGamepadType { get { return this[nameof(bCanChangeGamepadType)].Flag; } set { this[nameof(bCanChangeGamepadType)].Flag = value; } }
        public bool bSupportsTouch { get { return this[nameof(bSupportsTouch)].Flag; } set { this[nameof(bSupportsTouch)].Flag = value; } }
        public Array<Object> ControllerData { get { return new Array<Object>(this[nameof(ControllerData)].Address); } }
        public Array<Object> ControllerDataClasses { get { return new Array<Object>(this[nameof(ControllerDataClasses)].Address); } }
    }
}
