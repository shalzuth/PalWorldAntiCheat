using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.UMGSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.AudioWidgetsSDK
{
    public class AudioMeter : Widget
    {
        public AudioMeter(nint addr) : base(addr) { }
        public Array<MeterChannelInfo> MeterChannelInfo { get { return new Array<MeterChannelInfo>(this[nameof(MeterChannelInfo)].Address); } }
        public Object MeterChannelInfoDelegate { get { return this[nameof(MeterChannelInfoDelegate)]; } set { this[nameof(MeterChannelInfoDelegate)] = value; } }
        public AudioMeterStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<AudioMeterStyle>(); } set { this["WidgetStyle"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public LinearColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<LinearColor>(); } set { this["BackgroundColor"] = value; } }
        public LinearColor MeterBackgroundColor { get { return this[nameof(MeterBackgroundColor)].As<LinearColor>(); } set { this["MeterBackgroundColor"] = value; } }
        public LinearColor MeterValueColor { get { return this[nameof(MeterValueColor)].As<LinearColor>(); } set { this["MeterValueColor"] = value; } }
        public LinearColor MeterPeakColor { get { return this[nameof(MeterPeakColor)].As<LinearColor>(); } set { this["MeterPeakColor"] = value; } }
        public LinearColor MeterClippingColor { get { return this[nameof(MeterClippingColor)].As<LinearColor>(); } set { this["MeterClippingColor"] = value; } }
        public LinearColor MeterScaleColor { get { return this[nameof(MeterScaleColor)].As<LinearColor>(); } set { this["MeterScaleColor"] = value; } }
        public LinearColor MeterScaleLabelColor { get { return this[nameof(MeterScaleLabelColor)].As<LinearColor>(); } set { this["MeterScaleLabelColor"] = value; } }
        public void SetMeterValueColor(LinearColor InValue) { Invoke(nameof(SetMeterValueColor), InValue); }
        public void SetMeterScaleLabelColor(LinearColor InValue) { Invoke(nameof(SetMeterScaleLabelColor), InValue); }
        public void SetMeterScaleColor(LinearColor InValue) { Invoke(nameof(SetMeterScaleColor), InValue); }
        public void SetMeterPeakColor(LinearColor InValue) { Invoke(nameof(SetMeterPeakColor), InValue); }
        public void SetMeterClippingColor(LinearColor InValue) { Invoke(nameof(SetMeterClippingColor), InValue); }
        public void SetMeterChannelInfo(Array<MeterChannelInfo> InMeterChannelInfo) { Invoke(nameof(SetMeterChannelInfo), InMeterChannelInfo); }
        public void SetMeterBackgroundColor(LinearColor InValue) { Invoke(nameof(SetMeterBackgroundColor), InValue); }
        public void SetBackgroundColor(LinearColor InValue) { Invoke(nameof(SetBackgroundColor), InValue); }
        public Array<MeterChannelInfo> GetMeterChannelInfo__DelegateSignature() { return Invoke<Array<MeterChannelInfo>>(nameof(GetMeterChannelInfo__DelegateSignature)); }
        public Array<MeterChannelInfo> GetMeterChannelInfo() { return Invoke<Array<MeterChannelInfo>>(nameof(GetMeterChannelInfo)); }
    }
    public class AudioRadialSlider : Widget
    {
        public AudioRadialSlider(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public byte WidgetLayout { get { return this[nameof(WidgetLayout)].GetValue<byte>(); } set { this[nameof(WidgetLayout)].SetValue<byte>(value); } }
        public LinearColor CenterBackgroundColor { get { return this[nameof(CenterBackgroundColor)].As<LinearColor>(); } set { this["CenterBackgroundColor"] = value; } }
        public LinearColor SliderProgressColor { get { return this[nameof(SliderProgressColor)].As<LinearColor>(); } set { this["SliderProgressColor"] = value; } }
        public LinearColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<LinearColor>(); } set { this["SliderBarColor"] = value; } }
        public Vector2D HandStartEndRatio { get { return this[nameof(HandStartEndRatio)].As<Vector2D>(); } set { this["HandStartEndRatio"] = value; } }
        public Object UnitsText { get { return this[nameof(UnitsText)]; } set { this[nameof(UnitsText)] = value; } }
        public LinearColor TextLabelBackgroundColor { get { return this[nameof(TextLabelBackgroundColor)].As<LinearColor>(); } set { this["TextLabelBackgroundColor"] = value; } }
        public bool ShowLabelOnlyOnHover { get { return this[nameof(ShowLabelOnlyOnHover)].Flag; } set { this[nameof(ShowLabelOnlyOnHover)].Flag = value; } }
        public bool ShowUnitsText { get { return this[nameof(ShowUnitsText)].Flag; } set { this[nameof(ShowUnitsText)].Flag = value; } }
        public bool IsUnitsTextReadOnly { get { return this[nameof(IsUnitsTextReadOnly)].Flag; } set { this[nameof(IsUnitsTextReadOnly)].Flag = value; } }
        public bool IsValueTextReadOnly { get { return this[nameof(IsValueTextReadOnly)].Flag; } set { this[nameof(IsValueTextReadOnly)].Flag = value; } }
        public float SliderThickness { get { return this[nameof(SliderThickness)].GetValue<float>(); } set { this[nameof(SliderThickness)].SetValue<float>(value); } }
        public Vector2D OutputRange { get { return this[nameof(OutputRange)].As<Vector2D>(); } set { this["OutputRange"] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public void SetWidgetLayout(byte InLayout) { Invoke(nameof(SetWidgetLayout), InLayout); }
        public void SetValueTextReadOnly(bool bIsReadOnly) { Invoke(nameof(SetValueTextReadOnly), bIsReadOnly); }
        public void SetUnitsTextReadOnly(bool bIsReadOnly) { Invoke(nameof(SetUnitsTextReadOnly), bIsReadOnly); }
        public void SetUnitsText(Object Units) { Invoke(nameof(SetUnitsText), Units); }
        public void SetTextLabelBackgroundColor(SlateColor inColor) { Invoke(nameof(SetTextLabelBackgroundColor), inColor); }
        public void SetSliderThickness(float InThickness) { Invoke(nameof(SetSliderThickness), InThickness); }
        public void SetSliderProgressColor(LinearColor InValue) { Invoke(nameof(SetSliderProgressColor), InValue); }
        public void SetSliderBarColor(LinearColor InValue) { Invoke(nameof(SetSliderBarColor), InValue); }
        public void SetShowUnitsText(bool bShowUnitsText) { Invoke(nameof(SetShowUnitsText), bShowUnitsText); }
        public void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) { Invoke(nameof(SetShowLabelOnlyOnHover), bShowLabelOnlyOnHover); }
        public void SetOutputRange(Vector2D InOutputRange) { Invoke(nameof(SetOutputRange), InOutputRange); }
        public void SetHandStartEndRatio(Vector2D InHandStartEndRatio) { Invoke(nameof(SetHandStartEndRatio), InHandStartEndRatio); }
        public void SetCenterBackgroundColor(LinearColor InValue) { Invoke(nameof(SetCenterBackgroundColor), InValue); }
        public float GetSliderValue(float OutputValue) { return Invoke<float>(nameof(GetSliderValue), OutputValue); }
        public float GetOutputValue(float InSliderValue) { return Invoke<float>(nameof(GetOutputValue), InSliderValue); }
    }
    public class AudioVolumeRadialSlider : AudioRadialSlider
    {
        public AudioVolumeRadialSlider(nint addr) : base(addr) { }
    }
    public class AudioFrequencyRadialSlider : AudioRadialSlider
    {
        public AudioFrequencyRadialSlider(nint addr) : base(addr) { }
    }
    public class AudioSliderBase : Widget
    {
        public AudioSliderBase(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object UnitsText { get { return this[nameof(UnitsText)]; } set { this[nameof(UnitsText)] = value; } }
        public LinearColor TextLabelBackgroundColor { get { return this[nameof(TextLabelBackgroundColor)].As<LinearColor>(); } set { this["TextLabelBackgroundColor"] = value; } }
        public Object TextLabelBackgroundColorDelegate { get { return this[nameof(TextLabelBackgroundColorDelegate)]; } set { this[nameof(TextLabelBackgroundColorDelegate)] = value; } }
        public bool ShowLabelOnlyOnHover { get { return this[nameof(ShowLabelOnlyOnHover)].Flag; } set { this[nameof(ShowLabelOnlyOnHover)].Flag = value; } }
        public bool ShowUnitsText { get { return this[nameof(ShowUnitsText)].Flag; } set { this[nameof(ShowUnitsText)].Flag = value; } }
        public bool IsUnitsTextReadOnly { get { return this[nameof(IsUnitsTextReadOnly)].Flag; } set { this[nameof(IsUnitsTextReadOnly)].Flag = value; } }
        public bool IsValueTextReadOnly { get { return this[nameof(IsValueTextReadOnly)].Flag; } set { this[nameof(IsValueTextReadOnly)].Flag = value; } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public LinearColor SliderBackgroundColor { get { return this[nameof(SliderBackgroundColor)].As<LinearColor>(); } set { this["SliderBackgroundColor"] = value; } }
        public Object SliderBackgroundColorDelegate { get { return this[nameof(SliderBackgroundColorDelegate)]; } set { this[nameof(SliderBackgroundColorDelegate)] = value; } }
        public LinearColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<LinearColor>(); } set { this["SliderBarColor"] = value; } }
        public Object SliderBarColorDelegate { get { return this[nameof(SliderBarColorDelegate)]; } set { this[nameof(SliderBarColorDelegate)] = value; } }
        public LinearColor SliderThumbColor { get { return this[nameof(SliderThumbColor)].As<LinearColor>(); } set { this["SliderThumbColor"] = value; } }
        public Object SliderThumbColorDelegate { get { return this[nameof(SliderThumbColorDelegate)]; } set { this[nameof(SliderThumbColorDelegate)] = value; } }
        public LinearColor WidgetBackgroundColor { get { return this[nameof(WidgetBackgroundColor)].As<LinearColor>(); } set { this["WidgetBackgroundColor"] = value; } }
        public Object WidgetBackgroundColorDelegate { get { return this[nameof(WidgetBackgroundColorDelegate)]; } set { this[nameof(WidgetBackgroundColorDelegate)] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public void SetWidgetBackgroundColor(LinearColor InValue) { Invoke(nameof(SetWidgetBackgroundColor), InValue); }
        public void SetValueTextReadOnly(bool bIsReadOnly) { Invoke(nameof(SetValueTextReadOnly), bIsReadOnly); }
        public void SetUnitsTextReadOnly(bool bIsReadOnly) { Invoke(nameof(SetUnitsTextReadOnly), bIsReadOnly); }
        public void SetUnitsText(Object Units) { Invoke(nameof(SetUnitsText), Units); }
        public void SetTextLabelBackgroundColor(SlateColor inColor) { Invoke(nameof(SetTextLabelBackgroundColor), inColor); }
        public void SetSliderThumbColor(LinearColor InValue) { Invoke(nameof(SetSliderThumbColor), InValue); }
        public void SetSliderBarColor(LinearColor InValue) { Invoke(nameof(SetSliderBarColor), InValue); }
        public void SetSliderBackgroundColor(LinearColor InValue) { Invoke(nameof(SetSliderBackgroundColor), InValue); }
        public void SetShowUnitsText(bool bShowUnitsText) { Invoke(nameof(SetShowUnitsText), bShowUnitsText); }
        public void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) { Invoke(nameof(SetShowLabelOnlyOnHover), bShowLabelOnlyOnHover); }
        public float GetSliderValue(float OutputValue) { return Invoke<float>(nameof(GetSliderValue), OutputValue); }
        public float GetOutputValue(float InSliderValue) { return Invoke<float>(nameof(GetOutputValue), InSliderValue); }
        public float GetLinValue(float OutputValue) { return Invoke<float>(nameof(GetLinValue), OutputValue); }
    }
    public class AudioSlider : AudioSliderBase
    {
        public AudioSlider(nint addr) : base(addr) { }
        public Object LinToOutputCurve { get { return this[nameof(LinToOutputCurve)]; } set { this[nameof(LinToOutputCurve)] = value; } }
        public Object OutputToLinCurve { get { return this[nameof(OutputToLinCurve)]; } set { this[nameof(OutputToLinCurve)] = value; } }
    }
    public class AudioVolumeSlider : AudioSlider
    {
        public AudioVolumeSlider(nint addr) : base(addr) { }
    }
    public class AudioFrequencySlider : AudioSliderBase
    {
        public AudioFrequencySlider(nint addr) : base(addr) { }
        public Vector2D OutputRange { get { return this[nameof(OutputRange)].As<Vector2D>(); } set { this["OutputRange"] = value; } }
    }
    public class MeterChannelInfo : Object
    {
        public MeterChannelInfo(nint addr) : base(addr) { }
        public float MeterValue { get { return this[nameof(MeterValue)].GetValue<float>(); } set { this[nameof(MeterValue)].SetValue<float>(value); } }
        public float PeakValue { get { return this[nameof(PeakValue)].GetValue<float>(); } set { this[nameof(PeakValue)].SetValue<float>(value); } }
        public float ClippingValue { get { return this[nameof(ClippingValue)].GetValue<float>(); } set { this[nameof(ClippingValue)].SetValue<float>(value); } }
    }
    public class AudioMeterStyle : SlateWidgetStyle
    {
        public AudioMeterStyle(nint addr) : base(addr) { }
        public SlateBrush MeterValueImage { get { return this[nameof(MeterValueImage)].As<SlateBrush>(); } set { this["MeterValueImage"] = value; } }
        public SlateBrush BackgroundImage { get { return this[nameof(BackgroundImage)].As<SlateBrush>(); } set { this["BackgroundImage"] = value; } }
        public SlateBrush MeterBackgroundImage { get { return this[nameof(MeterBackgroundImage)].As<SlateBrush>(); } set { this["MeterBackgroundImage"] = value; } }
        public SlateBrush MeterValueBackgroundImage { get { return this[nameof(MeterValueBackgroundImage)].As<SlateBrush>(); } set { this["MeterValueBackgroundImage"] = value; } }
        public SlateBrush MeterPeakImage { get { return this[nameof(MeterPeakImage)].As<SlateBrush>(); } set { this["MeterPeakImage"] = value; } }
        public Vector2D MeterSize { get { return this[nameof(MeterSize)].As<Vector2D>(); } set { this["MeterSize"] = value; } }
        public Vector2D MeterPadding { get { return this[nameof(MeterPadding)].As<Vector2D>(); } set { this["MeterPadding"] = value; } }
        public float MeterValuePadding { get { return this[nameof(MeterValuePadding)].GetValue<float>(); } set { this[nameof(MeterValuePadding)].SetValue<float>(value); } }
        public float PeakValueWidth { get { return this[nameof(PeakValueWidth)].GetValue<float>(); } set { this[nameof(PeakValueWidth)].SetValue<float>(value); } }
        public Vector2D ValueRangeDb { get { return this[nameof(ValueRangeDb)].As<Vector2D>(); } set { this["ValueRangeDb"] = value; } }
        public bool bShowScale { get { return this[nameof(bShowScale)].Flag; } set { this[nameof(bShowScale)].Flag = value; } }
        public bool bScaleSide { get { return this[nameof(bScaleSide)].Flag; } set { this[nameof(bScaleSide)].Flag = value; } }
        public float ScaleHashOffset { get { return this[nameof(ScaleHashOffset)].GetValue<float>(); } set { this[nameof(ScaleHashOffset)].SetValue<float>(value); } }
        public float ScaleHashWidth { get { return this[nameof(ScaleHashWidth)].GetValue<float>(); } set { this[nameof(ScaleHashWidth)].SetValue<float>(value); } }
        public float ScaleHashHeight { get { return this[nameof(ScaleHashHeight)].GetValue<float>(); } set { this[nameof(ScaleHashHeight)].SetValue<float>(value); } }
        public int DecibelsPerHash { get { return this[nameof(DecibelsPerHash)].GetValue<int>(); } set { this[nameof(DecibelsPerHash)].SetValue<int>(value); } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
    }
    public enum EAudioRadialSliderLayout : int
    {
        Layout_LabelTop = 0,
        Layout_LabelCenter = 1,
        Layout_LabelBottom = 2,
        Layout_MAX = 3,
    }
    public class AudioTextBoxStyle : SlateWidgetStyle
    {
        public AudioTextBoxStyle(nint addr) : base(addr) { }
        public SlateBrush BackgroundImage { get { return this[nameof(BackgroundImage)].As<SlateBrush>(); } set { this["BackgroundImage"] = value; } }
        public SlateColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<SlateColor>(); } set { this["BackgroundColor"] = value; } }
    }
    public class AudioSliderStyle : SlateWidgetStyle
    {
        public AudioSliderStyle(nint addr) : base(addr) { }
        public SliderStyle SliderStyle { get { return this[nameof(SliderStyle)].As<SliderStyle>(); } set { this["SliderStyle"] = value; } }
        public AudioTextBoxStyle TextBoxStyle { get { return this[nameof(TextBoxStyle)].As<AudioTextBoxStyle>(); } set { this["TextBoxStyle"] = value; } }
        public SlateBrush WidgetBackgroundImage { get { return this[nameof(WidgetBackgroundImage)].As<SlateBrush>(); } set { this["WidgetBackgroundImage"] = value; } }
        public SlateColor SliderBackgroundColor { get { return this[nameof(SliderBackgroundColor)].As<SlateColor>(); } set { this["SliderBackgroundColor"] = value; } }
        public Vector2D SliderBackgroundSize { get { return this[nameof(SliderBackgroundSize)].As<Vector2D>(); } set { this["SliderBackgroundSize"] = value; } }
        public float LabelPadding { get { return this[nameof(LabelPadding)].GetValue<float>(); } set { this[nameof(LabelPadding)].SetValue<float>(value); } }
        public SlateColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<SlateColor>(); } set { this["SliderBarColor"] = value; } }
        public SlateColor SliderThumbColor { get { return this[nameof(SliderThumbColor)].As<SlateColor>(); } set { this["SliderThumbColor"] = value; } }
        public SlateColor WidgetBackgroundColor { get { return this[nameof(WidgetBackgroundColor)].As<SlateColor>(); } set { this["WidgetBackgroundColor"] = value; } }
    }
    public class AudioRadialSliderStyle : SlateWidgetStyle
    {
        public AudioRadialSliderStyle(nint addr) : base(addr) { }
        public AudioTextBoxStyle TextBoxStyle { get { return this[nameof(TextBoxStyle)].As<AudioTextBoxStyle>(); } set { this["TextBoxStyle"] = value; } }
        public SlateColor CenterBackgroundColor { get { return this[nameof(CenterBackgroundColor)].As<SlateColor>(); } set { this["CenterBackgroundColor"] = value; } }
        public SlateColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<SlateColor>(); } set { this["SliderBarColor"] = value; } }
        public SlateColor SliderProgressColor { get { return this[nameof(SliderProgressColor)].As<SlateColor>(); } set { this["SliderProgressColor"] = value; } }
        public float LabelPadding { get { return this[nameof(LabelPadding)].GetValue<float>(); } set { this[nameof(LabelPadding)].SetValue<float>(value); } }
        public float DefaultSliderRadius { get { return this[nameof(DefaultSliderRadius)].GetValue<float>(); } set { this[nameof(DefaultSliderRadius)].SetValue<float>(value); } }
    }
}
