using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.UMGSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.AdvancedWidgetsSDK
{
    public class RadialSlider : Widget
    {
        public RadialSlider(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public bool bUseCustomDefaultValue { get { return this[nameof(bUseCustomDefaultValue)].Flag; } set { this[nameof(bUseCustomDefaultValue)].Flag = value; } }
        public float CustomDefaultValue { get { return this[nameof(CustomDefaultValue)].GetValue<float>(); } set { this[nameof(CustomDefaultValue)].SetValue<float>(value); } }
        public RuntimeFloatCurve SliderRange { get { return this[nameof(SliderRange)].As<RuntimeFloatCurve>(); } set { this["SliderRange"] = value; } }
        public Array<float> ValueTags { get { return new Array<float>(this[nameof(ValueTags)].Address); } }
        public float SliderHandleStartAngle { get { return this[nameof(SliderHandleStartAngle)].GetValue<float>(); } set { this[nameof(SliderHandleStartAngle)].SetValue<float>(value); } }
        public float SliderHandleEndAngle { get { return this[nameof(SliderHandleEndAngle)].GetValue<float>(); } set { this[nameof(SliderHandleEndAngle)].SetValue<float>(value); } }
        public float AngularOffset { get { return this[nameof(AngularOffset)].GetValue<float>(); } set { this[nameof(AngularOffset)].SetValue<float>(value); } }
        public Vector2D HandStartEndRatio { get { return this[nameof(HandStartEndRatio)].As<Vector2D>(); } set { this["HandStartEndRatio"] = value; } }
        public SliderStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SliderStyle>(); } set { this["WidgetStyle"] = value; } }
        public LinearColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<LinearColor>(); } set { this["SliderBarColor"] = value; } }
        public LinearColor SliderProgressColor { get { return this[nameof(SliderProgressColor)].As<LinearColor>(); } set { this["SliderProgressColor"] = value; } }
        public LinearColor SliderHandleColor { get { return this[nameof(SliderHandleColor)].As<LinearColor>(); } set { this["SliderHandleColor"] = value; } }
        public LinearColor CenterBackgroundColor { get { return this[nameof(CenterBackgroundColor)].As<LinearColor>(); } set { this["CenterBackgroundColor"] = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public bool MouseUsesStep { get { return this[nameof(MouseUsesStep)].Flag; } set { this[nameof(MouseUsesStep)].Flag = value; } }
        public bool RequiresControllerLock { get { return this[nameof(RequiresControllerLock)].Flag; } set { this[nameof(RequiresControllerLock)].Flag = value; } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public bool UseVerticalDrag { get { return this[nameof(UseVerticalDrag)].Flag; } set { this[nameof(UseVerticalDrag)].Flag = value; } }
        public bool ShowSliderHandle { get { return this[nameof(ShowSliderHandle)].Flag; } set { this[nameof(ShowSliderHandle)].Flag = value; } }
        public bool ShowSliderHand { get { return this[nameof(ShowSliderHand)].Flag; } set { this[nameof(ShowSliderHand)].Flag = value; } }
        public Object OnMouseCaptureBegin { get { return this[nameof(OnMouseCaptureBegin)]; } set { this[nameof(OnMouseCaptureBegin)] = value; } }
        public Object OnMouseCaptureEnd { get { return this[nameof(OnMouseCaptureEnd)]; } set { this[nameof(OnMouseCaptureEnd)] = value; } }
        public Object OnControllerCaptureBegin { get { return this[nameof(OnControllerCaptureBegin)]; } set { this[nameof(OnControllerCaptureBegin)] = value; } }
        public Object OnControllerCaptureEnd { get { return this[nameof(OnControllerCaptureEnd)]; } set { this[nameof(OnControllerCaptureEnd)] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public void SetValueTags(Array<float> InValueTags) { Invoke(nameof(SetValueTags), InValueTags); }
        public void SetValue(float InValue) { Invoke(nameof(SetValue), InValue); }
        public void SetUseVerticalDrag(bool InUseVerticalDrag) { Invoke(nameof(SetUseVerticalDrag), InUseVerticalDrag); }
        public void SetStepSize(float InValue) { Invoke(nameof(SetStepSize), InValue); }
        public void SetSliderRange(RuntimeFloatCurve InSliderRange) { Invoke(nameof(SetSliderRange), InSliderRange); }
        public void SetSliderProgressColor(LinearColor InValue) { Invoke(nameof(SetSliderProgressColor), InValue); }
        public void SetSliderHandleStartAngle(float InValue) { Invoke(nameof(SetSliderHandleStartAngle), InValue); }
        public void SetSliderHandleEndAngle(float InValue) { Invoke(nameof(SetSliderHandleEndAngle), InValue); }
        public void SetSliderHandleColor(LinearColor InValue) { Invoke(nameof(SetSliderHandleColor), InValue); }
        public void SetSliderBarColor(LinearColor InValue) { Invoke(nameof(SetSliderBarColor), InValue); }
        public void SetShowSliderHandle(bool InShowSliderHandle) { Invoke(nameof(SetShowSliderHandle), InShowSliderHandle); }
        public void SetShowSliderHand(bool InShowSliderHand) { Invoke(nameof(SetShowSliderHand), InShowSliderHand); }
        public void SetLocked(bool InValue) { Invoke(nameof(SetLocked), InValue); }
        public void SetHandStartEndRatio(Vector2D InValue) { Invoke(nameof(SetHandStartEndRatio), InValue); }
        public void SetCustomDefaultValue(float InValue) { Invoke(nameof(SetCustomDefaultValue), InValue); }
        public void SetCenterBackgroundColor(LinearColor InValue) { Invoke(nameof(SetCenterBackgroundColor), InValue); }
        public void SetAngularOffset(float InValue) { Invoke(nameof(SetAngularOffset), InValue); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public float GetNormalizedSliderHandlePosition() { return Invoke<float>(nameof(GetNormalizedSliderHandlePosition)); }
        public float GetCustomDefaultValue() { return Invoke<float>(nameof(GetCustomDefaultValue)); }
    }
}
