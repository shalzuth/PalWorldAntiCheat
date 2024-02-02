using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.UMGSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CommonInputSDK;
using SDK.Script.GameplayTagsSDK;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.InputCoreSDK;
namespace SDK.Script.CommonUISDK
{
    public class CommonBoundActionButtonInterface : Interface
    {
        public CommonBoundActionButtonInterface(nint addr) : base(addr) { }
    }
    public class CommonStyleSheetTypeBase : Object
    {
        public CommonStyleSheetTypeBase(nint addr) : base(addr) { }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
    }
    public class CommonStyleSheetTypeColor : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeColor(nint addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
    }
    public class CommonStyleSheetTypeOpacity : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeOpacity(nint addr) : base(addr) { }
        public float Opacity { get { return this[nameof(Opacity)].GetValue<float>(); } set { this[nameof(Opacity)].SetValue<float>(value); } }
    }
    public class CommonStyleSheetTypeLineHeightPercentage : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeLineHeightPercentage(nint addr) : base(addr) { }
        public float LineHeightPercentage { get { return this[nameof(LineHeightPercentage)].GetValue<float>(); } set { this[nameof(LineHeightPercentage)].SetValue<float>(value); } }
    }
    public class CommonStyleSheetTypeFontTypeface : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeFontTypeface(nint addr) : base(addr) { }
        public SlateFontInfo Typeface { get { return this[nameof(Typeface)].As<SlateFontInfo>(); } set { this["Typeface"] = value; } }
    }
    public class CommonStyleSheetTypeFontSize : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeFontSize(nint addr) : base(addr) { }
        public int Size { get { return this[nameof(Size)].GetValue<int>(); } set { this[nameof(Size)].SetValue<int>(value); } }
    }
    public class CommonStyleSheetTypeFontLetterSpacing : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeFontLetterSpacing(nint addr) : base(addr) { }
        public int LetterSpacing { get { return this[nameof(LetterSpacing)].GetValue<int>(); } set { this[nameof(LetterSpacing)].SetValue<int>(value); } }
    }
    public class CommonStyleSheetTypeMarginLeft : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeMarginLeft(nint addr) : base(addr) { }
        public float Left { get { return this[nameof(Left)].GetValue<float>(); } set { this[nameof(Left)].SetValue<float>(value); } }
    }
    public class CommonStyleSheetTypeMarginRight : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeMarginRight(nint addr) : base(addr) { }
        public float Right { get { return this[nameof(Right)].GetValue<float>(); } set { this[nameof(Right)].SetValue<float>(value); } }
    }
    public class CommonStyleSheetTypeMarginTop : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeMarginTop(nint addr) : base(addr) { }
        public float Top { get { return this[nameof(Top)].GetValue<float>(); } set { this[nameof(Top)].SetValue<float>(value); } }
    }
    public class CommonStyleSheetTypeMarginBottom : CommonStyleSheetTypeBase
    {
        public CommonStyleSheetTypeMarginBottom(nint addr) : base(addr) { }
        public float Bottom { get { return this[nameof(Bottom)].GetValue<float>(); } set { this[nameof(Bottom)].SetValue<float>(value); } }
    }
    public class AnalogSlider : Slider
    {
        public AnalogSlider(nint addr) : base(addr) { }
        public Object OnAnalogCapture { get { return this[nameof(OnAnalogCapture)]; } set { this[nameof(OnAnalogCapture)] = value; } }
    }
    public class CommonActionHandlerInterface : Interface
    {
        public CommonActionHandlerInterface(nint addr) : base(addr) { }
    }
    public class CommonActionWidget : Widget
    {
        public CommonActionWidget(nint addr) : base(addr) { }
        public Object OnInputMethodChanged { get { return this[nameof(OnInputMethodChanged)]; } set { this[nameof(OnInputMethodChanged)] = value; } }
        public SlateBrush ProgressMaterialBrush { get { return this[nameof(ProgressMaterialBrush)].As<SlateBrush>(); } set { this["ProgressMaterialBrush"] = value; } }
        public Object ProgressMaterialParam { get { return this[nameof(ProgressMaterialParam)]; } set { this[nameof(ProgressMaterialParam)] = value; } }
        public SlateBrush IconRimBrush { get { return this[nameof(IconRimBrush)].As<SlateBrush>(); } set { this["IconRimBrush"] = value; } }
        public Array<DataTableRowHandle> InputActions { get { return new Array<DataTableRowHandle>(this[nameof(InputActions)].Address); } }
        public MaterialInstanceDynamic ProgressDynamicMaterial { get { return this[nameof(ProgressDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["ProgressDynamicMaterial"] = value; } }
        public void SetInputActions(Array<DataTableRowHandle> NewInputActions) { Invoke(nameof(SetInputActions), NewInputActions); }
        public void SetInputAction(DataTableRowHandle InputActionRow) { Invoke(nameof(SetInputAction), InputActionRow); }
        public void SetIconRimBrush(SlateBrush InIconRimBrush) { Invoke(nameof(SetIconRimBrush), InIconRimBrush); }
        public void OnInputMethodChanged__DelegateSignature(bool bUsingGamepad) { Invoke(nameof(OnInputMethodChanged__DelegateSignature), bUsingGamepad); }
        public bool IsHeldAction() { return Invoke<bool>(nameof(IsHeldAction)); }
        public SlateBrush GetIcon() { return Invoke<SlateBrush>(nameof(GetIcon)); }
        public Object GetDisplayText() { return Invoke<Object>(nameof(GetDisplayText)); }
    }
    public class CommonUserWidget : UserWidget
    {
        public CommonUserWidget(nint addr) : base(addr) { }
        public bool bDisplayInActionBar { get { return this[nameof(bDisplayInActionBar)].Flag; } set { this[nameof(bDisplayInActionBar)].Flag = value; } }
        public bool bConsumePointerInput { get { return this[nameof(bConsumePointerInput)].Flag; } set { this[nameof(bConsumePointerInput)].Flag = value; } }
        public void SetConsumePointerInput(bool bInConsumePointerInput) { Invoke(nameof(SetConsumePointerInput), bInConsumePointerInput); }
    }
    public class CommonActivatableWidget : CommonUserWidget
    {
        public CommonActivatableWidget(nint addr) : base(addr) { }
        public bool bIsBackHandler { get { return this[nameof(bIsBackHandler)].Flag; } set { this[nameof(bIsBackHandler)].Flag = value; } }
        public bool bIsBackActionDisplayedInActionBar { get { return this[nameof(bIsBackActionDisplayedInActionBar)].Flag; } set { this[nameof(bIsBackActionDisplayedInActionBar)].Flag = value; } }
        public bool bAutoActivate { get { return this[nameof(bAutoActivate)].Flag; } set { this[nameof(bAutoActivate)].Flag = value; } }
        public bool bSupportsActivationFocus { get { return this[nameof(bSupportsActivationFocus)].Flag; } set { this[nameof(bSupportsActivationFocus)].Flag = value; } }
        public bool bIsModal { get { return this[nameof(bIsModal)].Flag; } set { this[nameof(bIsModal)].Flag = value; } }
        public bool bAutoRestoreFocus { get { return this[nameof(bAutoRestoreFocus)].Flag; } set { this[nameof(bAutoRestoreFocus)].Flag = value; } }
        public bool bOverrideActionDomain { get { return this[nameof(bOverrideActionDomain)].Flag; } set { this[nameof(bOverrideActionDomain)].Flag = value; } }
        public Object ActionDomainOverride { get { return this[nameof(ActionDomainOverride)]; } set { this[nameof(ActionDomainOverride)] = value; } }
        public Object BP_OnWidgetActivated { get { return this[nameof(BP_OnWidgetActivated)]; } set { this[nameof(BP_OnWidgetActivated)] = value; } }
        public Object BP_OnWidgetDeactivated { get { return this[nameof(BP_OnWidgetDeactivated)]; } set { this[nameof(BP_OnWidgetDeactivated)] = value; } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public Array<Object> VisibilityBoundWidgets { get { return new Array<Object>(this[nameof(VisibilityBoundWidgets)].Address); } }
        public bool bSetVisibilityOnActivated { get { return this[nameof(bSetVisibilityOnActivated)].Flag; } set { this[nameof(bSetVisibilityOnActivated)].Flag = value; } }
        public ESlateVisibility ActivatedVisibility { get { return (ESlateVisibility)this[nameof(ActivatedVisibility)].GetValue<int>(); } set { this[nameof(ActivatedVisibility)].SetValue<int>((int)value); } }
        public bool bSetVisibilityOnDeactivated { get { return this[nameof(bSetVisibilityOnDeactivated)].Flag; } set { this[nameof(bSetVisibilityOnDeactivated)].Flag = value; } }
        public ESlateVisibility DeactivatedVisibility { get { return (ESlateVisibility)this[nameof(DeactivatedVisibility)].GetValue<int>(); } set { this[nameof(DeactivatedVisibility)].SetValue<int>((int)value); } }
        public void SetBindVisibilities(ESlateVisibility OnActivatedVisibility, ESlateVisibility OnDeactivatedVisibility, bool bInAllActive) { Invoke(nameof(SetBindVisibilities), OnActivatedVisibility, OnDeactivatedVisibility, bInAllActive); }
        public bool IsActivated() { return Invoke<bool>(nameof(IsActivated)); }
        public Widget GetDesiredFocusTarget() { return Invoke<Widget>(nameof(GetDesiredFocusTarget)); }
        public void DeactivateWidget() { Invoke(nameof(DeactivateWidget)); }
        public bool BP_OnHandleBackAction() { return Invoke<bool>(nameof(BP_OnHandleBackAction)); }
        public void BP_OnDeactivated() { Invoke(nameof(BP_OnDeactivated)); }
        public void BP_OnActivated() { Invoke(nameof(BP_OnActivated)); }
        public Widget BP_GetDesiredFocusTarget() { return Invoke<Widget>(nameof(BP_GetDesiredFocusTarget)); }
        public void BindVisibilityToActivation(CommonActivatableWidget ActivatableWidget) { Invoke(nameof(BindVisibilityToActivation), ActivatableWidget); }
        public void ActivateWidget() { Invoke(nameof(ActivateWidget)); }
    }
    public class CommonAnimatedSwitcher : WidgetSwitcher
    {
        public CommonAnimatedSwitcher(nint addr) : base(addr) { }
        public ECommonSwitcherTransition TransitionType { get { return (ECommonSwitcherTransition)this[nameof(TransitionType)].GetValue<int>(); } set { this[nameof(TransitionType)].SetValue<int>((int)value); } }
        public ETransitionCurve TransitionCurveType { get { return (ETransitionCurve)this[nameof(TransitionCurveType)].GetValue<int>(); } set { this[nameof(TransitionCurveType)].SetValue<int>((int)value); } }
        public float TransitionDuration { get { return this[nameof(TransitionDuration)].GetValue<float>(); } set { this[nameof(TransitionDuration)].SetValue<float>(value); } }
        public void SetDisableTransitionAnimation(bool bDisableAnimation) { Invoke(nameof(SetDisableTransitionAnimation), bDisableAnimation); }
        public bool IsTransitionPlaying() { return Invoke<bool>(nameof(IsTransitionPlaying)); }
        public bool IsCurrentlySwitching() { return Invoke<bool>(nameof(IsCurrentlySwitching)); }
        public bool HasWidgets() { return Invoke<bool>(nameof(HasWidgets)); }
        public void ActivatePreviousWidget(bool bCanWrap) { Invoke(nameof(ActivatePreviousWidget), bCanWrap); }
        public void ActivateNextWidget(bool bCanWrap) { Invoke(nameof(ActivateNextWidget), bCanWrap); }
    }
    public class CommonActivatableWidgetSwitcher : CommonAnimatedSwitcher
    {
        public CommonActivatableWidgetSwitcher(nint addr) : base(addr) { }
    }
    public class CommonBorderStyle : Object
    {
        public CommonBorderStyle(nint addr) : base(addr) { }
        public SlateBrush Background { get { return this[nameof(Background)].As<SlateBrush>(); } set { this["Background"] = value; } }
        public void GetBackgroundBrush(SlateBrush Brush) { Invoke(nameof(GetBackgroundBrush), Brush); }
    }
    public class CommonBorder : Border
    {
        public CommonBorder(nint addr) : base(addr) { }
        public Object Style { get { return this[nameof(Style)]; } set { this[nameof(Style)] = value; } }
        public bool bReducePaddingBySafezone { get { return this[nameof(bReducePaddingBySafezone)].Flag; } set { this[nameof(bReducePaddingBySafezone)].Flag = value; } }
        public Margin MinimumPadding { get { return this[nameof(MinimumPadding)].As<Margin>(); } set { this["MinimumPadding"] = value; } }
        public void SetStyle(Object InStyle) { Invoke(nameof(SetStyle), InStyle); }
    }
    public class CommonButtonStyle : Object
    {
        public CommonButtonStyle(nint addr) : base(addr) { }
        public bool bSingleMaterial { get { return this[nameof(bSingleMaterial)].Flag; } set { this[nameof(bSingleMaterial)].Flag = value; } }
        public SlateBrush SingleMaterialBrush { get { return this[nameof(SingleMaterialBrush)].As<SlateBrush>(); } set { this["SingleMaterialBrush"] = value; } }
        public SlateBrush NormalBase { get { return this[nameof(NormalBase)].As<SlateBrush>(); } set { this["NormalBase"] = value; } }
        public SlateBrush NormalHovered { get { return this[nameof(NormalHovered)].As<SlateBrush>(); } set { this["NormalHovered"] = value; } }
        public SlateBrush NormalPressed { get { return this[nameof(NormalPressed)].As<SlateBrush>(); } set { this["NormalPressed"] = value; } }
        public SlateBrush SelectedBase { get { return this[nameof(SelectedBase)].As<SlateBrush>(); } set { this["SelectedBase"] = value; } }
        public SlateBrush SelectedHovered { get { return this[nameof(SelectedHovered)].As<SlateBrush>(); } set { this["SelectedHovered"] = value; } }
        public SlateBrush SelectedPressed { get { return this[nameof(SelectedPressed)].As<SlateBrush>(); } set { this["SelectedPressed"] = value; } }
        public SlateBrush Disabled { get { return this[nameof(Disabled)].As<SlateBrush>(); } set { this["Disabled"] = value; } }
        public Margin ButtonPadding { get { return this[nameof(ButtonPadding)].As<Margin>(); } set { this["ButtonPadding"] = value; } }
        public Margin CustomPadding { get { return this[nameof(CustomPadding)].As<Margin>(); } set { this["CustomPadding"] = value; } }
        public int MinWidth { get { return this[nameof(MinWidth)].GetValue<int>(); } set { this[nameof(MinWidth)].SetValue<int>(value); } }
        public int MinHeight { get { return this[nameof(MinHeight)].GetValue<int>(); } set { this[nameof(MinHeight)].SetValue<int>(value); } }
        public Object NormalTextStyle { get { return this[nameof(NormalTextStyle)]; } set { this[nameof(NormalTextStyle)] = value; } }
        public Object NormalHoveredTextStyle { get { return this[nameof(NormalHoveredTextStyle)]; } set { this[nameof(NormalHoveredTextStyle)] = value; } }
        public Object SelectedTextStyle { get { return this[nameof(SelectedTextStyle)]; } set { this[nameof(SelectedTextStyle)] = value; } }
        public Object SelectedHoveredTextStyle { get { return this[nameof(SelectedHoveredTextStyle)]; } set { this[nameof(SelectedHoveredTextStyle)] = value; } }
        public Object DisabledTextStyle { get { return this[nameof(DisabledTextStyle)]; } set { this[nameof(DisabledTextStyle)] = value; } }
        public SlateSound PressedSlateSound { get { return this[nameof(PressedSlateSound)].As<SlateSound>(); } set { this["PressedSlateSound"] = value; } }
        public CommonButtonStyleOptionalSlateSound SelectedPressedSlateSound { get { return this[nameof(SelectedPressedSlateSound)].As<CommonButtonStyleOptionalSlateSound>(); } set { this["SelectedPressedSlateSound"] = value; } }
        public CommonButtonStyleOptionalSlateSound LockedPressedSlateSound { get { return this[nameof(LockedPressedSlateSound)].As<CommonButtonStyleOptionalSlateSound>(); } set { this["LockedPressedSlateSound"] = value; } }
        public SlateSound HoveredSlateSound { get { return this[nameof(HoveredSlateSound)].As<SlateSound>(); } set { this["HoveredSlateSound"] = value; } }
        public CommonButtonStyleOptionalSlateSound SelectedHoveredSlateSound { get { return this[nameof(SelectedHoveredSlateSound)].As<CommonButtonStyleOptionalSlateSound>(); } set { this["SelectedHoveredSlateSound"] = value; } }
        public CommonButtonStyleOptionalSlateSound LockedHoveredSlateSound { get { return this[nameof(LockedHoveredSlateSound)].As<CommonButtonStyleOptionalSlateSound>(); } set { this["LockedHoveredSlateSound"] = value; } }
        public CommonTextStyle GetSelectedTextStyle() { return Invoke<CommonTextStyle>(nameof(GetSelectedTextStyle)); }
        public void GetSelectedPressedBrush(SlateBrush Brush) { Invoke(nameof(GetSelectedPressedBrush), Brush); }
        public CommonTextStyle GetSelectedHoveredTextStyle() { return Invoke<CommonTextStyle>(nameof(GetSelectedHoveredTextStyle)); }
        public void GetSelectedHoveredBrush(SlateBrush Brush) { Invoke(nameof(GetSelectedHoveredBrush), Brush); }
        public void GetSelectedBaseBrush(SlateBrush Brush) { Invoke(nameof(GetSelectedBaseBrush), Brush); }
        public CommonTextStyle GetNormalTextStyle() { return Invoke<CommonTextStyle>(nameof(GetNormalTextStyle)); }
        public void GetNormalPressedBrush(SlateBrush Brush) { Invoke(nameof(GetNormalPressedBrush), Brush); }
        public CommonTextStyle GetNormalHoveredTextStyle() { return Invoke<CommonTextStyle>(nameof(GetNormalHoveredTextStyle)); }
        public void GetNormalHoveredBrush(SlateBrush Brush) { Invoke(nameof(GetNormalHoveredBrush), Brush); }
        public void GetNormalBaseBrush(SlateBrush Brush) { Invoke(nameof(GetNormalBaseBrush), Brush); }
        public void GetMaterialBrush(SlateBrush Brush) { Invoke(nameof(GetMaterialBrush), Brush); }
        public CommonTextStyle GetDisabledTextStyle() { return Invoke<CommonTextStyle>(nameof(GetDisabledTextStyle)); }
        public void GetDisabledBrush(SlateBrush Brush) { Invoke(nameof(GetDisabledBrush), Brush); }
        public void GetCustomPadding(Margin OutCustomPadding) { Invoke(nameof(GetCustomPadding), OutCustomPadding); }
        public void GetButtonPadding(Margin OutButtonPadding) { Invoke(nameof(GetButtonPadding), OutButtonPadding); }
    }
    public class CommonButtonInternalBase : Button
    {
        public CommonButtonInternalBase(nint addr) : base(addr) { }
        public Object OnDoubleClicked { get { return this[nameof(OnDoubleClicked)]; } set { this[nameof(OnDoubleClicked)] = value; } }
        public int MinWidth { get { return this[nameof(MinWidth)].GetValue<int>(); } set { this[nameof(MinWidth)].SetValue<int>(value); } }
        public int MinHeight { get { return this[nameof(MinHeight)].GetValue<int>(); } set { this[nameof(MinHeight)].SetValue<int>(value); } }
        public bool bButtonEnabled { get { return this[nameof(bButtonEnabled)].Flag; } set { this[nameof(bButtonEnabled)].Flag = value; } }
        public bool bInteractionEnabled { get { return this[nameof(bInteractionEnabled)].Flag; } set { this[nameof(bInteractionEnabled)].Flag = value; } }
    }
    public class CommonButtonBase : CommonUserWidget
    {
        public CommonButtonBase(nint addr) : base(addr) { }
        public int MinWidth { get { return this[nameof(MinWidth)].GetValue<int>(); } set { this[nameof(MinWidth)].SetValue<int>(value); } }
        public int MinHeight { get { return this[nameof(MinHeight)].GetValue<int>(); } set { this[nameof(MinHeight)].SetValue<int>(value); } }
        public Object Style { get { return this[nameof(Style)]; } set { this[nameof(Style)] = value; } }
        public bool bHideInputAction { get { return this[nameof(bHideInputAction)].Flag; } set { this[nameof(bHideInputAction)].Flag = value; } }
        public SlateSound PressedSlateSoundOverride { get { return this[nameof(PressedSlateSoundOverride)].As<SlateSound>(); } set { this["PressedSlateSoundOverride"] = value; } }
        public SlateSound HoveredSlateSoundOverride { get { return this[nameof(HoveredSlateSoundOverride)].As<SlateSound>(); } set { this["HoveredSlateSoundOverride"] = value; } }
        public SlateSound SelectedPressedSlateSoundOverride { get { return this[nameof(SelectedPressedSlateSoundOverride)].As<SlateSound>(); } set { this["SelectedPressedSlateSoundOverride"] = value; } }
        public SlateSound SelectedHoveredSlateSoundOverride { get { return this[nameof(SelectedHoveredSlateSoundOverride)].As<SlateSound>(); } set { this["SelectedHoveredSlateSoundOverride"] = value; } }
        public SlateSound LockedPressedSlateSoundOverride { get { return this[nameof(LockedPressedSlateSoundOverride)].As<SlateSound>(); } set { this["LockedPressedSlateSoundOverride"] = value; } }
        public SlateSound LockedHoveredSlateSoundOverride { get { return this[nameof(LockedHoveredSlateSoundOverride)].As<SlateSound>(); } set { this["LockedHoveredSlateSoundOverride"] = value; } }
        public bool bApplyAlphaOnDisable { get { return this[nameof(bApplyAlphaOnDisable)].Flag; } set { this[nameof(bApplyAlphaOnDisable)].Flag = value; } }
        public bool bLocked { get { return this[nameof(bLocked)].Flag; } set { this[nameof(bLocked)].Flag = value; } }
        public bool bSelectable { get { return this[nameof(bSelectable)].Flag; } set { this[nameof(bSelectable)].Flag = value; } }
        public bool bShouldSelectUponReceivingFocus { get { return this[nameof(bShouldSelectUponReceivingFocus)].Flag; } set { this[nameof(bShouldSelectUponReceivingFocus)].Flag = value; } }
        public bool bInteractableWhenSelected { get { return this[nameof(bInteractableWhenSelected)].Flag; } set { this[nameof(bInteractableWhenSelected)].Flag = value; } }
        public bool bToggleable { get { return this[nameof(bToggleable)].Flag; } set { this[nameof(bToggleable)].Flag = value; } }
        public bool bTriggerClickedAfterSelection { get { return this[nameof(bTriggerClickedAfterSelection)].Flag; } set { this[nameof(bTriggerClickedAfterSelection)].Flag = value; } }
        public bool bDisplayInputActionWhenNotInteractable { get { return this[nameof(bDisplayInputActionWhenNotInteractable)].Flag; } set { this[nameof(bDisplayInputActionWhenNotInteractable)].Flag = value; } }
        public bool bHideInputActionWithKeyboard { get { return this[nameof(bHideInputActionWithKeyboard)].Flag; } set { this[nameof(bHideInputActionWithKeyboard)].Flag = value; } }
        public bool bShouldUseFallbackDefaultInputAction { get { return this[nameof(bShouldUseFallbackDefaultInputAction)].Flag; } set { this[nameof(bShouldUseFallbackDefaultInputAction)].Flag = value; } }
        public byte ClickMethod { get { return this[nameof(ClickMethod)].GetValue<byte>(); } set { this[nameof(ClickMethod)].SetValue<byte>(value); } }
        public byte TouchMethod { get { return this[nameof(TouchMethod)].GetValue<byte>(); } set { this[nameof(TouchMethod)].SetValue<byte>(value); } }
        public byte PressMethod { get { return this[nameof(PressMethod)].GetValue<byte>(); } set { this[nameof(PressMethod)].SetValue<byte>(value); } }
        public int InputPriority { get { return this[nameof(InputPriority)].GetValue<int>(); } set { this[nameof(InputPriority)].SetValue<int>(value); } }
        public DataTableRowHandle TriggeringInputAction { get { return this[nameof(TriggeringInputAction)].As<DataTableRowHandle>(); } set { this["TriggeringInputAction"] = value; } }
        public Object OnSelectedChangedBase { get { return this[nameof(OnSelectedChangedBase)]; } set { this[nameof(OnSelectedChangedBase)] = value; } }
        public Object OnButtonBaseClicked { get { return this[nameof(OnButtonBaseClicked)]; } set { this[nameof(OnButtonBaseClicked)] = value; } }
        public Object OnButtonBaseDoubleClicked { get { return this[nameof(OnButtonBaseDoubleClicked)]; } set { this[nameof(OnButtonBaseDoubleClicked)] = value; } }
        public Object OnButtonBaseHovered { get { return this[nameof(OnButtonBaseHovered)]; } set { this[nameof(OnButtonBaseHovered)] = value; } }
        public Object OnButtonBaseUnhovered { get { return this[nameof(OnButtonBaseUnhovered)]; } set { this[nameof(OnButtonBaseUnhovered)] = value; } }
        public bool bIsPersistentBinding { get { return this[nameof(bIsPersistentBinding)].Flag; } set { this[nameof(bIsPersistentBinding)].Flag = value; } }
        public ECommonInputMode InputModeOverride { get { return (ECommonInputMode)this[nameof(InputModeOverride)].GetValue<int>(); } set { this[nameof(InputModeOverride)].SetValue<int>((int)value); } }
        public MaterialInstanceDynamic SingleMaterialStyleMID { get { return this[nameof(SingleMaterialStyleMID)].As<MaterialInstanceDynamic>(); } set { this["SingleMaterialStyleMID"] = value; } }
        public ButtonStyle NormalStyle { get { return this[nameof(NormalStyle)].As<ButtonStyle>(); } set { this["NormalStyle"] = value; } }
        public ButtonStyle SelectedStyle { get { return this[nameof(SelectedStyle)].As<ButtonStyle>(); } set { this["SelectedStyle"] = value; } }
        public ButtonStyle DisabledStyle { get { return this[nameof(DisabledStyle)].As<ButtonStyle>(); } set { this["DisabledStyle"] = value; } }
        public ButtonStyle LockedStyle { get { return this[nameof(LockedStyle)].As<ButtonStyle>(); } set { this["LockedStyle"] = value; } }
        public bool bStopDoubleClickPropagation { get { return this[nameof(bStopDoubleClickPropagation)].Flag; } set { this[nameof(bStopDoubleClickPropagation)].Flag = value; } }
        public CommonActionWidget InputActionWidget { get { return this[nameof(InputActionWidget)].As<CommonActionWidget>(); } set { this["InputActionWidget"] = value; } }
        public void StopDoubleClickPropagation() { Invoke(nameof(StopDoubleClickPropagation)); }
        public void SetTriggeringInputAction(DataTableRowHandle InputActionRow) { Invoke(nameof(SetTriggeringInputAction), InputActionRow); }
        public void SetTriggeredInputAction(DataTableRowHandle InputActionRow) { Invoke(nameof(SetTriggeredInputAction), InputActionRow); }
        public void SetTouchMethod(byte InTouchMethod) { Invoke(nameof(SetTouchMethod), InTouchMethod); }
        public void SetStyle(Object InStyle) { Invoke(nameof(SetStyle), InStyle); }
        public void SetShouldUseFallbackDefaultInputAction(bool bInShouldUseFallbackDefaultInputAction) { Invoke(nameof(SetShouldUseFallbackDefaultInputAction), bInShouldUseFallbackDefaultInputAction); }
        public void SetShouldSelectUponReceivingFocus(bool bInShouldSelectUponReceivingFocus) { Invoke(nameof(SetShouldSelectUponReceivingFocus), bInShouldSelectUponReceivingFocus); }
        public void SetSelectedPressedSoundOverride(SoundBase Sound) { Invoke(nameof(SetSelectedPressedSoundOverride), Sound); }
        public void SetSelectedInternal(bool bInSelected, bool bAllowSound, bool bBroadcast) { Invoke(nameof(SetSelectedInternal), bInSelected, bAllowSound, bBroadcast); }
        public void SetSelectedHoveredSoundOverride(SoundBase Sound) { Invoke(nameof(SetSelectedHoveredSoundOverride), Sound); }
        public void SetPressMethod(byte InPressMethod) { Invoke(nameof(SetPressMethod), InPressMethod); }
        public void SetPressedSoundOverride(SoundBase Sound) { Invoke(nameof(SetPressedSoundOverride), Sound); }
        public void SetMinDimensions(int InMinWidth, int InMinHeight) { Invoke(nameof(SetMinDimensions), InMinWidth, InMinHeight); }
        public void SetLockedPressedSoundOverride(SoundBase Sound) { Invoke(nameof(SetLockedPressedSoundOverride), Sound); }
        public void SetLockedHoveredSoundOverride(SoundBase Sound) { Invoke(nameof(SetLockedHoveredSoundOverride), Sound); }
        public void SetIsToggleable(bool bInIsToggleable) { Invoke(nameof(SetIsToggleable), bInIsToggleable); }
        public void SetIsSelected(bool InSelected, bool bGiveClickFeedback) { Invoke(nameof(SetIsSelected), InSelected, bGiveClickFeedback); }
        public void SetIsSelectable(bool bInIsSelectable) { Invoke(nameof(SetIsSelectable), bInIsSelectable); }
        public void SetIsLocked(bool bInIsLocked) { Invoke(nameof(SetIsLocked), bInIsLocked); }
        public void SetIsInteractionEnabled(bool bInIsInteractionEnabled) { Invoke(nameof(SetIsInteractionEnabled), bInIsInteractionEnabled); }
        public void SetIsInteractableWhenSelected(bool bInInteractableWhenSelected) { Invoke(nameof(SetIsInteractableWhenSelected), bInInteractableWhenSelected); }
        public void SetIsFocusable(bool bInIsFocusable) { Invoke(nameof(SetIsFocusable), bInIsFocusable); }
        public void SetInputActionProgressMaterial(SlateBrush InProgressMaterialBrush, Object InProgressMaterialParam) { Invoke(nameof(SetInputActionProgressMaterial), InProgressMaterialBrush, InProgressMaterialParam); }
        public void SetHoveredSoundOverride(SoundBase Sound) { Invoke(nameof(SetHoveredSoundOverride), Sound); }
        public void SetHideInputAction(bool bInHideInputAction) { Invoke(nameof(SetHideInputAction), bInHideInputAction); }
        public void SetClickMethod(byte InClickMethod) { Invoke(nameof(SetClickMethod), InClickMethod); }
        public void OnTriggeringInputActionChanged(DataTableRowHandle NewTriggeredAction) { Invoke(nameof(OnTriggeringInputActionChanged), NewTriggeredAction); }
        public void OnTriggeredInputActionChanged(DataTableRowHandle NewTriggeredAction) { Invoke(nameof(OnTriggeredInputActionChanged), NewTriggeredAction); }
        public void OnInputMethodChanged(ECommonInputType CurrentInputType) { Invoke(nameof(OnInputMethodChanged), CurrentInputType); }
        public void OnCurrentTextStyleChanged() { Invoke(nameof(OnCurrentTextStyleChanged)); }
        public void OnActionProgress(float HeldPercent) { Invoke(nameof(OnActionProgress), HeldPercent); }
        public void OnActionComplete() { Invoke(nameof(OnActionComplete)); }
        public void NativeOnActionProgress(float HeldPercent) { Invoke(nameof(NativeOnActionProgress), HeldPercent); }
        public void NativeOnActionComplete() { Invoke(nameof(NativeOnActionComplete)); }
        public bool IsPressed() { return Invoke<bool>(nameof(IsPressed)); }
        public bool IsInteractionEnabled() { return Invoke<bool>(nameof(IsInteractionEnabled)); }
        public void HandleTriggeringActionCommited(bool bPassThrough) { Invoke(nameof(HandleTriggeringActionCommited), bPassThrough); }
        public void HandleFocusReceived() { Invoke(nameof(HandleFocusReceived)); }
        public void HandleFocusLost() { Invoke(nameof(HandleFocusLost)); }
        public void HandleButtonReleased() { Invoke(nameof(HandleButtonReleased)); }
        public void HandleButtonPressed() { Invoke(nameof(HandleButtonPressed)); }
        public void HandleButtonClicked() { Invoke(nameof(HandleButtonClicked)); }
        public CommonButtonStyle GetStyle() { return Invoke<CommonButtonStyle>(nameof(GetStyle)); }
        public MaterialInstanceDynamic GetSingleMaterialStyleMID() { return Invoke<MaterialInstanceDynamic>(nameof(GetSingleMaterialStyleMID)); }
        public bool GetShouldSelectUponReceivingFocus() { return Invoke<bool>(nameof(GetShouldSelectUponReceivingFocus)); }
        public bool GetSelected() { return Invoke<bool>(nameof(GetSelected)); }
        public bool GetLocked() { return Invoke<bool>(nameof(GetLocked)); }
        public bool GetIsFocusable() { return Invoke<bool>(nameof(GetIsFocusable)); }
        public bool GetInputAction(DataTableRowHandle InputActionRow) { return Invoke<bool>(nameof(GetInputAction), InputActionRow); }
        public Object GetCurrentTextStyleClass() { return Invoke<Object>(nameof(GetCurrentTextStyleClass)); }
        public CommonTextStyle GetCurrentTextStyle() { return Invoke<CommonTextStyle>(nameof(GetCurrentTextStyle)); }
        public void GetCurrentCustomPadding(Margin OutCustomPadding) { Invoke(nameof(GetCurrentCustomPadding), OutCustomPadding); }
        public void GetCurrentButtonPadding(Margin OutButtonPadding) { Invoke(nameof(GetCurrentButtonPadding), OutButtonPadding); }
        public void DisableButtonWithReason(Object DisabledReason) { Invoke(nameof(DisableButtonWithReason), DisabledReason); }
        public void ClearSelection() { Invoke(nameof(ClearSelection)); }
        public void BP_OnUnhovered() { Invoke(nameof(BP_OnUnhovered)); }
        public void BP_OnSelected() { Invoke(nameof(BP_OnSelected)); }
        public void BP_OnReleased() { Invoke(nameof(BP_OnReleased)); }
        public void BP_OnPressed() { Invoke(nameof(BP_OnPressed)); }
        public void BP_OnLockedChanged(bool bIsLocked) { Invoke(nameof(BP_OnLockedChanged), bIsLocked); }
        public void BP_OnLockDoubleClicked() { Invoke(nameof(BP_OnLockDoubleClicked)); }
        public void BP_OnLockClicked() { Invoke(nameof(BP_OnLockClicked)); }
        public void BP_OnInputMethodChanged(ECommonInputType CurrentInputType) { Invoke(nameof(BP_OnInputMethodChanged), CurrentInputType); }
        public void BP_OnHovered() { Invoke(nameof(BP_OnHovered)); }
        public void BP_OnFocusReceived() { Invoke(nameof(BP_OnFocusReceived)); }
        public void BP_OnFocusLost() { Invoke(nameof(BP_OnFocusLost)); }
        public void BP_OnEnabled() { Invoke(nameof(BP_OnEnabled)); }
        public void BP_OnDoubleClicked() { Invoke(nameof(BP_OnDoubleClicked)); }
        public void BP_OnDisabled() { Invoke(nameof(BP_OnDisabled)); }
        public void BP_OnDeselected() { Invoke(nameof(BP_OnDeselected)); }
        public void BP_OnClicked() { Invoke(nameof(BP_OnClicked)); }
    }
    public class CommonCustomNavigation : Border
    {
        public CommonCustomNavigation(nint addr) : base(addr) { }
        public Object OnNavigationEvent { get { return this[nameof(OnNavigationEvent)]; } set { this[nameof(OnNavigationEvent)] = value; } }
    }
    public class CommonTextBlock : TextBlock
    {
        public CommonTextBlock(nint addr) : base(addr) { }
        public Object Style { get { return this[nameof(Style)]; } set { this[nameof(Style)] = value; } }
        public Object ScrollStyle { get { return this[nameof(ScrollStyle)]; } set { this[nameof(ScrollStyle)] = value; } }
        public CommonStyleSheet StyleSheet { get { return this[nameof(StyleSheet)].As<CommonStyleSheet>(); } set { this["StyleSheet"] = value; } }
        public bool bIsScrollingEnabled { get { return this[nameof(bIsScrollingEnabled)].Flag; } set { this[nameof(bIsScrollingEnabled)].Flag = value; } }
        public bool bDisplayAllCaps { get { return this[nameof(bDisplayAllCaps)].Flag; } set { this[nameof(bDisplayAllCaps)].Flag = value; } }
        public bool bAutoCollapseWithEmptyText { get { return this[nameof(bAutoCollapseWithEmptyText)].Flag; } set { this[nameof(bAutoCollapseWithEmptyText)].Flag = value; } }
        public float MobileFontSizeMultiplier { get { return this[nameof(MobileFontSizeMultiplier)].GetValue<float>(); } set { this[nameof(MobileFontSizeMultiplier)].SetValue<float>(value); } }
        public void SetWrapTextWidth(int InWrapTextAt) { Invoke(nameof(SetWrapTextWidth), InWrapTextAt); }
        public void SetTextCase(bool bUseAllCaps) { Invoke(nameof(SetTextCase), bUseAllCaps); }
        public void SetStyle(Object InStyle) { Invoke(nameof(SetStyle), InStyle); }
        public void SetScrollingEnabled(bool bInIsScrollingEnabled) { Invoke(nameof(SetScrollingEnabled), bInIsScrollingEnabled); }
        public void SetMargin(Margin InMargin) { Invoke(nameof(SetMargin), InMargin); }
        public void SetLineHeightPercentage(float InLineHeightPercentage) { Invoke(nameof(SetLineHeightPercentage), InLineHeightPercentage); }
        public void ResetScrollState() { Invoke(nameof(ResetScrollState)); }
        public Margin GetMargin() { return Invoke<Margin>(nameof(GetMargin)); }
    }
    public class CommonDateTimeTextBlock : CommonTextBlock
    {
        public CommonDateTimeTextBlock(nint addr) : base(addr) { }
        public void SetTimespanValue(Timespan InTimespan) { Invoke(nameof(SetTimespanValue), InTimespan); }
        public void SetDateTimeValue(DateTime InDateTime, bool bShowAsCountdown, float InRefreshDelay) { Invoke(nameof(SetDateTimeValue), InDateTime, bShowAsCountdown, InRefreshDelay); }
        public void SetCountDownCompletionText(Object InCompletionText) { Invoke(nameof(SetCountDownCompletionText), InCompletionText); }
        public DateTime GetDateTime() { return Invoke<DateTime>(nameof(GetDateTime)); }
    }
    public class CommonGameViewportClient : GameViewportClient
    {
        public CommonGameViewportClient(nint addr) : base(addr) { }
    }
    public class CommonHardwareVisibilityBorder : CommonBorder
    {
        public CommonHardwareVisibilityBorder(nint addr) : base(addr) { }
        public GameplayTagQuery VisibilityQuery { get { return this[nameof(VisibilityQuery)].As<GameplayTagQuery>(); } set { this["VisibilityQuery"] = value; } }
        public ESlateVisibility VisibleType { get { return (ESlateVisibility)this[nameof(VisibleType)].GetValue<int>(); } set { this[nameof(VisibleType)].SetValue<int>((int)value); } }
        public ESlateVisibility HiddenType { get { return (ESlateVisibility)this[nameof(HiddenType)].GetValue<int>(); } set { this[nameof(HiddenType)].SetValue<int>((int)value); } }
    }
    public class CommonHierarchicalScrollBox : ScrollBox
    {
        public CommonHierarchicalScrollBox(nint addr) : base(addr) { }
    }
    public class CommonLazyImage : Image
    {
        public CommonLazyImage(nint addr) : base(addr) { }
        public SlateBrush LoadingBackgroundBrush { get { return this[nameof(LoadingBackgroundBrush)].As<SlateBrush>(); } set { this["LoadingBackgroundBrush"] = value; } }
        public Object MaterialTextureParamName { get { return this[nameof(MaterialTextureParamName)]; } set { this[nameof(MaterialTextureParamName)] = value; } }
        public Object BP_OnLoadingStateChanged { get { return this[nameof(BP_OnLoadingStateChanged)]; } set { this[nameof(BP_OnLoadingStateChanged)] = value; } }
        public void SetMaterialTextureParamName(Object TextureParamName) { Invoke(nameof(SetMaterialTextureParamName), TextureParamName); }
        public void SetBrushFromLazyTexture(Object LazyTexture, bool bMatchSize) { Invoke(nameof(SetBrushFromLazyTexture), LazyTexture, bMatchSize); }
        public void SetBrushFromLazyMaterial(Object LazyMaterial) { Invoke(nameof(SetBrushFromLazyMaterial), LazyMaterial); }
        public void SetBrushFromLazyDisplayAsset(Object LazyObject, bool bMatchTextureSize) { Invoke(nameof(SetBrushFromLazyDisplayAsset), LazyObject, bMatchTextureSize); }
        public bool IsLoading() { return Invoke<bool>(nameof(IsLoading)); }
    }
    public class CommonLazyWidget : Widget
    {
        public CommonLazyWidget(nint addr) : base(addr) { }
        public SlateBrush LoadingBackgroundBrush { get { return this[nameof(LoadingBackgroundBrush)].As<SlateBrush>(); } set { this["LoadingBackgroundBrush"] = value; } }
        public UserWidget Content { get { return this[nameof(Content)].As<UserWidget>(); } set { this["Content"] = value; } }
        public Object BP_OnLoadingStateChanged { get { return this[nameof(BP_OnLoadingStateChanged)]; } set { this[nameof(BP_OnLoadingStateChanged)] = value; } }
        public void SetLazyContent(Object SoftWidget) { Invoke(nameof(SetLazyContent), SoftWidget); }
        public bool IsLoading() { return Invoke<bool>(nameof(IsLoading)); }
        public UserWidget GetContent() { return Invoke<UserWidget>(nameof(GetContent)); }
    }
    public class CommonListView : ListView
    {
        public CommonListView(nint addr) : base(addr) { }
        public void SetEntrySpacing(float InEntrySpacing) { Invoke(nameof(SetEntrySpacing), InEntrySpacing); }
    }
    public class LoadGuardSlot : PanelSlot
    {
        public LoadGuardSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class CommonLoadGuard : ContentWidget
    {
        public CommonLoadGuard(nint addr) : base(addr) { }
        public SlateBrush LoadingBackgroundBrush { get { return this[nameof(LoadingBackgroundBrush)].As<SlateBrush>(); } set { this["LoadingBackgroundBrush"] = value; } }
        public byte ThrobberAlignment { get { return this[nameof(ThrobberAlignment)].GetValue<byte>(); } set { this[nameof(ThrobberAlignment)].SetValue<byte>(value); } }
        public Margin ThrobberPadding { get { return this[nameof(ThrobberPadding)].As<Margin>(); } set { this["ThrobberPadding"] = value; } }
        public Object LoadingText { get { return this[nameof(LoadingText)]; } set { this[nameof(LoadingText)] = value; } }
        public Object TextStyle { get { return this[nameof(TextStyle)]; } set { this[nameof(TextStyle)] = value; } }
        public Object BP_OnLoadingStateChanged { get { return this[nameof(BP_OnLoadingStateChanged)]; } set { this[nameof(BP_OnLoadingStateChanged)] = value; } }
        public SoftObjectPath SpinnerMaterialPath { get { return this[nameof(SpinnerMaterialPath)].As<SoftObjectPath>(); } set { this["SpinnerMaterialPath"] = value; } }
        public void SetLoadingText(Object InLoadingText) { Invoke(nameof(SetLoadingText), InLoadingText); }
        public void SetIsLoading(bool bInIsLoading) { Invoke(nameof(SetIsLoading), bInIsLoading); }
        public void OnAssetLoaded__DelegateSignature(Object Object) { Invoke(nameof(OnAssetLoaded__DelegateSignature), Object); }
        public bool IsLoading() { return Invoke<bool>(nameof(IsLoading)); }
        public void BP_GuardAndLoadAsset(Object InLazyAsset, Object OnAssetLoaded) { Invoke(nameof(BP_GuardAndLoadAsset), InLazyAsset, OnAssetLoaded); }
    }
    public class CommonNumericTextBlock : CommonTextBlock
    {
        public CommonNumericTextBlock(nint addr) : base(addr) { }
        public Object OnInterpolationStartedEvent { get { return this[nameof(OnInterpolationStartedEvent)]; } set { this[nameof(OnInterpolationStartedEvent)] = value; } }
        public Object OnInterpolationUpdatedEvent { get { return this[nameof(OnInterpolationUpdatedEvent)]; } set { this[nameof(OnInterpolationUpdatedEvent)] = value; } }
        public Object OnOutroEvent { get { return this[nameof(OnOutroEvent)]; } set { this[nameof(OnOutroEvent)] = value; } }
        public Object OnInterpolationEndedEvent { get { return this[nameof(OnInterpolationEndedEvent)]; } set { this[nameof(OnInterpolationEndedEvent)] = value; } }
        public float CurrentNumericValue { get { return this[nameof(CurrentNumericValue)].GetValue<float>(); } set { this[nameof(CurrentNumericValue)].SetValue<float>(value); } }
        public ECommonNumericType NumericType { get { return (ECommonNumericType)this[nameof(NumericType)].GetValue<int>(); } set { this[nameof(NumericType)].SetValue<int>((int)value); } }
        public CommonNumberFormattingOptions FormattingSpecification { get { return this[nameof(FormattingSpecification)].As<CommonNumberFormattingOptions>(); } set { this["FormattingSpecification"] = value; } }
        public float EaseOutInterpolationExponent { get { return this[nameof(EaseOutInterpolationExponent)].GetValue<float>(); } set { this[nameof(EaseOutInterpolationExponent)].SetValue<float>(value); } }
        public float InterpolationUpdateInterval { get { return this[nameof(InterpolationUpdateInterval)].GetValue<float>(); } set { this[nameof(InterpolationUpdateInterval)].SetValue<float>(value); } }
        public float PostInterpolationShrinkDuration { get { return this[nameof(PostInterpolationShrinkDuration)].GetValue<float>(); } set { this[nameof(PostInterpolationShrinkDuration)].SetValue<float>(value); } }
        public bool PerformSizeInterpolation { get { return this[nameof(PerformSizeInterpolation)].Flag; } set { this[nameof(PerformSizeInterpolation)].Flag = value; } }
        public bool IsPercentage { get { return this[nameof(IsPercentage)].Flag; } set { this[nameof(IsPercentage)].Flag = value; } }
        public void SetNumericType(ECommonNumericType InNumericType) { Invoke(nameof(SetNumericType), InNumericType); }
        public void SetCurrentValue(float NewValue) { Invoke(nameof(SetCurrentValue), NewValue); }
        public void OnOutro__DelegateSignature(CommonNumericTextBlock NumericTextBlock) { Invoke(nameof(OnOutro__DelegateSignature), NumericTextBlock); }
        public void OnInterpolationUpdated__DelegateSignature(CommonNumericTextBlock NumericTextBlock, float LastValue, float NewValue) { Invoke(nameof(OnInterpolationUpdated__DelegateSignature), NumericTextBlock, LastValue, NewValue); }
        public void OnInterpolationStarted__DelegateSignature(CommonNumericTextBlock NumericTextBlock) { Invoke(nameof(OnInterpolationStarted__DelegateSignature), NumericTextBlock); }
        public void OnInterpolationEnded__DelegateSignature(CommonNumericTextBlock NumericTextBlock, bool HadCompleted) { Invoke(nameof(OnInterpolationEnded__DelegateSignature), NumericTextBlock, HadCompleted); }
        public bool IsInterpolatingNumericValue() { return Invoke<bool>(nameof(IsInterpolatingNumericValue)); }
        public void InterpolateToValue(float TargetValue, float MaximumInterpolationDuration, float MinimumChangeRate, float OutroOffset) { Invoke(nameof(InterpolateToValue), TargetValue, MaximumInterpolationDuration, MinimumChangeRate, OutroOffset); }
        public float GetTargetValue() { return Invoke<float>(nameof(GetTargetValue)); }
    }
    public class CommonPoolableWidgetInterface : Interface
    {
        public CommonPoolableWidgetInterface(nint addr) : base(addr) { }
        public void OnReleaseToPool() { Invoke(nameof(OnReleaseToPool)); }
        public void OnAcquireFromPool() { Invoke(nameof(OnAcquireFromPool)); }
    }
    public class CommonRichTextBlock : RichTextBlock
    {
        public CommonRichTextBlock(nint addr) : base(addr) { }
        public ERichTextInlineIconDisplayMode InlineIconDisplayMode { get { return (ERichTextInlineIconDisplayMode)this[nameof(InlineIconDisplayMode)].GetValue<int>(); } set { this[nameof(InlineIconDisplayMode)].SetValue<int>((int)value); } }
        public bool bTintInlineIcon { get { return this[nameof(bTintInlineIcon)].Flag; } set { this[nameof(bTintInlineIcon)].Flag = value; } }
        public Object DefaultTextStyleOverrideClass { get { return this[nameof(DefaultTextStyleOverrideClass)]; } set { this[nameof(DefaultTextStyleOverrideClass)] = value; } }
        public float MobileTextBlockScale { get { return this[nameof(MobileTextBlockScale)].GetValue<float>(); } set { this[nameof(MobileTextBlockScale)].SetValue<float>(value); } }
        public Object ScrollStyle { get { return this[nameof(ScrollStyle)]; } set { this[nameof(ScrollStyle)] = value; } }
        public bool bIsScrollingEnabled { get { return this[nameof(bIsScrollingEnabled)].Flag; } set { this[nameof(bIsScrollingEnabled)].Flag = value; } }
        public bool bDisplayAllCaps { get { return this[nameof(bDisplayAllCaps)].Flag; } set { this[nameof(bDisplayAllCaps)].Flag = value; } }
        public bool bAutoCollapseWithEmptyText { get { return this[nameof(bAutoCollapseWithEmptyText)].Flag; } set { this[nameof(bAutoCollapseWithEmptyText)].Flag = value; } }
        public void SetScrollingEnabled(bool bInIsScrollingEnabled) { Invoke(nameof(SetScrollingEnabled), bInIsScrollingEnabled); }
    }
    public class CommonRotator : CommonButtonBase
    {
        public CommonRotator(nint addr) : base(addr) { }
        public Object OnRotated { get { return this[nameof(OnRotated)]; } set { this[nameof(OnRotated)] = value; } }
        public CommonTextBlock MyText { get { return this[nameof(MyText)].As<CommonTextBlock>(); } set { this["MyText"] = value; } }
        public void ShiftTextRight() { Invoke(nameof(ShiftTextRight)); }
        public void ShiftTextLeft() { Invoke(nameof(ShiftTextLeft)); }
        public void SetSelectedItem(int InValue) { Invoke(nameof(SetSelectedItem), InValue); }
        public void PopulateTextLabels(Array<Object> Labels) { Invoke(nameof(PopulateTextLabels), Labels); }
        public Object GetSelectedText() { return Invoke<Object>(nameof(GetSelectedText)); }
        public int GetSelectedIndex() { return Invoke<int>(nameof(GetSelectedIndex)); }
        public void BP_OnOptionsPopulated(int Count) { Invoke(nameof(BP_OnOptionsPopulated), Count); }
        public void BP_OnOptionSelected(int Index) { Invoke(nameof(BP_OnOptionSelected), Index); }
    }
    public class CommonTabListWidgetBase : CommonUserWidget
    {
        public CommonTabListWidgetBase(nint addr) : base(addr) { }
        public Object OnTabSelected { get { return this[nameof(OnTabSelected)]; } set { this[nameof(OnTabSelected)] = value; } }
        public Object OnTabButtonCreation { get { return this[nameof(OnTabButtonCreation)]; } set { this[nameof(OnTabButtonCreation)] = value; } }
        public Object OnTabButtonRemoval { get { return this[nameof(OnTabButtonRemoval)]; } set { this[nameof(OnTabButtonRemoval)] = value; } }
        public Object OnTabListRebuilt { get { return this[nameof(OnTabListRebuilt)]; } set { this[nameof(OnTabListRebuilt)] = value; } }
        public DataTableRowHandle NextTabInputActionData { get { return this[nameof(NextTabInputActionData)].As<DataTableRowHandle>(); } set { this["NextTabInputActionData"] = value; } }
        public DataTableRowHandle PreviousTabInputActionData { get { return this[nameof(PreviousTabInputActionData)].As<DataTableRowHandle>(); } set { this["PreviousTabInputActionData"] = value; } }
        public bool bAutoListenForInput { get { return this[nameof(bAutoListenForInput)].Flag; } set { this[nameof(bAutoListenForInput)].Flag = value; } }
        public bool bDeferRebuildingTabList { get { return this[nameof(bDeferRebuildingTabList)].Flag; } set { this[nameof(bDeferRebuildingTabList)].Flag = value; } }
        public Object LinkedSwitcher { get { return this[nameof(LinkedSwitcher)]; } set { this[nameof(LinkedSwitcher)] = value; } }
        public CommonButtonGroupBase TabButtonGroup { get { return this[nameof(TabButtonGroup)].As<CommonButtonGroupBase>(); } set { this["TabButtonGroup"] = value; } }
        public Object RegisteredTabsByID { get { return this[nameof(RegisteredTabsByID)]; } set { this[nameof(RegisteredTabsByID)] = value; } }
        public void SetTabVisibility(Object TabNameID, ESlateVisibility NewVisibility) { Invoke(nameof(SetTabVisibility), TabNameID, NewVisibility); }
        public void SetTabInteractionEnabled(Object TabNameID, bool bEnable) { Invoke(nameof(SetTabInteractionEnabled), TabNameID, bEnable); }
        public void SetTabEnabled(Object TabNameID, bool bEnable) { Invoke(nameof(SetTabEnabled), TabNameID, bEnable); }
        public void SetListeningForInput(bool bShouldListen) { Invoke(nameof(SetListeningForInput), bShouldListen); }
        public void SetLinkedSwitcher(CommonAnimatedSwitcher CommonSwitcher) { Invoke(nameof(SetLinkedSwitcher), CommonSwitcher); }
        public bool SelectTabByID(Object TabNameID, bool bSuppressClickFeedback) { return Invoke<bool>(nameof(SelectTabByID), TabNameID, bSuppressClickFeedback); }
        public bool RemoveTab(Object TabNameID) { return Invoke<bool>(nameof(RemoveTab), TabNameID); }
        public void RemoveAllTabs() { Invoke(nameof(RemoveAllTabs)); }
        public bool RegisterTab(Object TabNameID, Object ButtonWidgetType, Widget ContentWidget, int TabIndex) { return Invoke<bool>(nameof(RegisterTab), TabNameID, ButtonWidgetType, ContentWidget, TabIndex); }
        public void OnTabSelected__DelegateSignature(Object TabId) { Invoke(nameof(OnTabSelected__DelegateSignature), TabId); }
        public void OnTabListRebuilt__DelegateSignature() { Invoke(nameof(OnTabListRebuilt__DelegateSignature)); }
        public void OnTabButtonRemoval__DelegateSignature(Object TabId, CommonButtonBase TabButton) { Invoke(nameof(OnTabButtonRemoval__DelegateSignature), TabId, TabButton); }
        public void OnTabButtonCreation__DelegateSignature(Object TabId, CommonButtonBase TabButton) { Invoke(nameof(OnTabButtonCreation__DelegateSignature), TabId, TabButton); }
        public void HandleTabRemoval(Object TabNameID, CommonButtonBase TabButton) { Invoke(nameof(HandleTabRemoval), TabNameID, TabButton); }
        public void HandleTabCreation(Object TabNameID, CommonButtonBase TabButton) { Invoke(nameof(HandleTabCreation), TabNameID, TabButton); }
        public void HandleTabButtonSelected(CommonButtonBase SelectedTabButton, int ButtonIndex) { Invoke(nameof(HandleTabButtonSelected), SelectedTabButton, ButtonIndex); }
        public void HandlePreviousTabInputAction(bool bPassThrough) { Invoke(nameof(HandlePreviousTabInputAction), bPassThrough); }
        public void HandlePreLinkedSwitcherChanged_BP() { Invoke(nameof(HandlePreLinkedSwitcherChanged_BP)); }
        public void HandlePostLinkedSwitcherChanged_BP() { Invoke(nameof(HandlePostLinkedSwitcherChanged_BP)); }
        public void HandleNextTabInputAction(bool bPassThrough) { Invoke(nameof(HandleNextTabInputAction), bPassThrough); }
        public Object GetTabIdAtIndex(int Index) { return Invoke<Object>(nameof(GetTabIdAtIndex), Index); }
        public int GetTabCount() { return Invoke<int>(nameof(GetTabCount)); }
        public CommonButtonBase GetTabButtonBaseByID(Object TabNameID) { return Invoke<CommonButtonBase>(nameof(GetTabButtonBaseByID), TabNameID); }
        public Object GetSelectedTabId() { return Invoke<Object>(nameof(GetSelectedTabId)); }
        public CommonAnimatedSwitcher GetLinkedSwitcher() { return Invoke<CommonAnimatedSwitcher>(nameof(GetLinkedSwitcher)); }
        public Object GetActiveTab() { return Invoke<Object>(nameof(GetActiveTab)); }
        public void DisableTabWithReason(Object TabNameID, Object Reason) { Invoke(nameof(DisableTabWithReason), TabNameID, Reason); }
    }
    public class CommonTextStyle : Object
    {
        public CommonTextStyle(nint addr) : base(addr) { }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public bool bUsesDropShadow { get { return this[nameof(bUsesDropShadow)].Flag; } set { this[nameof(bUsesDropShadow)].Flag = value; } }
        public Vector2D ShadowOffset { get { return this[nameof(ShadowOffset)].As<Vector2D>(); } set { this["ShadowOffset"] = value; } }
        public LinearColor ShadowColor { get { return this[nameof(ShadowColor)].As<LinearColor>(); } set { this["ShadowColor"] = value; } }
        public Margin Margin { get { return this[nameof(Margin)].As<Margin>(); } set { this["Margin"] = value; } }
        public SlateBrush StrikeBrush { get { return this[nameof(StrikeBrush)].As<SlateBrush>(); } set { this["StrikeBrush"] = value; } }
        public float LineHeightPercentage { get { return this[nameof(LineHeightPercentage)].GetValue<float>(); } set { this[nameof(LineHeightPercentage)].SetValue<float>(value); } }
        public void GetStrikeBrush(SlateBrush OutStrikeBrush) { Invoke(nameof(GetStrikeBrush), OutStrikeBrush); }
        public void GetShadowOffset(Vector2D OutShadowOffset) { Invoke(nameof(GetShadowOffset), OutShadowOffset); }
        public void GetShadowColor(LinearColor OutColor) { Invoke(nameof(GetShadowColor), OutColor); }
        public void GetMargin(Margin OutMargin) { Invoke(nameof(GetMargin), OutMargin); }
        public float GetLineHeightPercentage() { return Invoke<float>(nameof(GetLineHeightPercentage)); }
        public void GetFont(SlateFontInfo OutFont) { Invoke(nameof(GetFont), OutFont); }
        public void GetColor(LinearColor OutColor) { Invoke(nameof(GetColor), OutColor); }
    }
    public class CommonTextScrollStyle : Object
    {
        public CommonTextScrollStyle(nint addr) : base(addr) { }
        public float Speed { get { return this[nameof(Speed)].GetValue<float>(); } set { this[nameof(Speed)].SetValue<float>(value); } }
        public float StartDelay { get { return this[nameof(StartDelay)].GetValue<float>(); } set { this[nameof(StartDelay)].SetValue<float>(value); } }
        public float EndDelay { get { return this[nameof(EndDelay)].GetValue<float>(); } set { this[nameof(EndDelay)].SetValue<float>(value); } }
        public float FadeInDelay { get { return this[nameof(FadeInDelay)].GetValue<float>(); } set { this[nameof(FadeInDelay)].SetValue<float>(value); } }
        public float FadeOutDelay { get { return this[nameof(FadeOutDelay)].GetValue<float>(); } set { this[nameof(FadeOutDelay)].SetValue<float>(value); } }
    }
    public class CommonTileView : TileView
    {
        public CommonTileView(nint addr) : base(addr) { }
    }
    public class CommonTreeView : TreeView
    {
        public CommonTreeView(nint addr) : base(addr) { }
    }
    public class CommonUIEditorSettings : Object
    {
        public CommonUIEditorSettings(nint addr) : base(addr) { }
        public Object TemplateTextStyle { get { return this[nameof(TemplateTextStyle)]; } set { this[nameof(TemplateTextStyle)] = value; } }
        public Object TemplateButtonStyle { get { return this[nameof(TemplateButtonStyle)]; } set { this[nameof(TemplateButtonStyle)] = value; } }
        public Object TemplateBorderStyle { get { return this[nameof(TemplateBorderStyle)]; } set { this[nameof(TemplateBorderStyle)] = value; } }
    }
    public class CommonUILibrary : BlueprintFunctionLibrary
    {
        public CommonUILibrary(nint addr) : base(addr) { }
        public Widget FindParentWidgetOfType(Widget StartingWidget, Object Type) { return Invoke<Widget>(nameof(FindParentWidgetOfType), StartingWidget, Type); }
    }
    public class CommonUIRichTextData : Object
    {
        public CommonUIRichTextData(nint addr) : base(addr) { }
        public DataTable InlineIconSet { get { return this[nameof(InlineIconSet)].As<DataTable>(); } set { this["InlineIconSet"] = value; } }
    }
    public class CommonUISettings : Object
    {
        public CommonUISettings(nint addr) : base(addr) { }
        public bool bAutoLoadData { get { return this[nameof(bAutoLoadData)].Flag; } set { this[nameof(bAutoLoadData)].Flag = value; } }
        public Object DefaultImageResourceObject { get { return this[nameof(DefaultImageResourceObject)]; } set { this[nameof(DefaultImageResourceObject)] = value; } }
        public Object DefaultThrobberMaterial { get { return this[nameof(DefaultThrobberMaterial)]; } set { this[nameof(DefaultThrobberMaterial)] = value; } }
        public Object DefaultRichTextDataClass { get { return this[nameof(DefaultRichTextDataClass)]; } set { this[nameof(DefaultRichTextDataClass)] = value; } }
        public Array<GameplayTag> PlatformTraits { get { return new Array<GameplayTag>(this[nameof(PlatformTraits)].Address); } }
        public Object DefaultImageResourceObjectInstance { get { return this[nameof(DefaultImageResourceObjectInstance)].As<Object>(); } set { this["DefaultImageResourceObjectInstance"] = value; } }
        public MaterialInterface DefaultThrobberMaterialInstance { get { return this[nameof(DefaultThrobberMaterialInstance)].As<MaterialInterface>(); } set { this["DefaultThrobberMaterialInstance"] = value; } }
        public SlateBrush DefaultThrobberBrush { get { return this[nameof(DefaultThrobberBrush)].As<SlateBrush>(); } set { this["DefaultThrobberBrush"] = value; } }
        public CommonUIRichTextData RichTextDataInstance { get { return this[nameof(RichTextDataInstance)].As<CommonUIRichTextData>(); } set { this["RichTextDataInstance"] = value; } }
    }
    public class CommonUISubsystemBase : GameInstanceSubsystem
    {
        public CommonUISubsystemBase(nint addr) : base(addr) { }
        public SlateBrush GetInputActionButtonIcon(DataTableRowHandle InputActionRowHandle, ECommonInputType InputType, Object GamepadName) { return Invoke<SlateBrush>(nameof(GetInputActionButtonIcon), InputActionRowHandle, InputType, GamepadName); }
    }
    public class CommonUIVisibilitySubsystem : LocalPlayerSubsystem
    {
        public CommonUIVisibilitySubsystem(nint addr) : base(addr) { }
    }
    public class CommonVideoPlayer : Widget
    {
        public CommonVideoPlayer(nint addr) : base(addr) { }
        public MediaSource Video { get { return this[nameof(Video)].As<MediaSource>(); } set { this["Video"] = value; } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public MediaTexture MediaTexture { get { return this[nameof(MediaTexture)].As<MediaTexture>(); } set { this["MediaTexture"] = value; } }
        public Material VideoMaterial { get { return this[nameof(VideoMaterial)].As<Material>(); } set { this["VideoMaterial"] = value; } }
        public MediaSoundComponent SoundComponent { get { return this[nameof(SoundComponent)].As<MediaSoundComponent>(); } set { this["SoundComponent"] = value; } }
        public SlateBrush VideoBrush { get { return this[nameof(VideoBrush)].As<SlateBrush>(); } set { this["VideoBrush"] = value; } }
    }
    public class CommonVisibilitySwitcher : Overlay
    {
        public CommonVisibilitySwitcher(nint addr) : base(addr) { }
        public ESlateVisibility ShownVisibility { get { return (ESlateVisibility)this[nameof(ShownVisibility)].GetValue<int>(); } set { this[nameof(ShownVisibility)].SetValue<int>((int)value); } }
        public int ActiveWidgetIndex { get { return this[nameof(ActiveWidgetIndex)].GetValue<int>(); } set { this[nameof(ActiveWidgetIndex)].SetValue<int>(value); } }
        public bool bAutoActivateSlot { get { return this[nameof(bAutoActivateSlot)].Flag; } set { this[nameof(bAutoActivateSlot)].Flag = value; } }
        public bool bActivateFirstSlotOnAdding { get { return this[nameof(bActivateFirstSlotOnAdding)].Flag; } set { this[nameof(bActivateFirstSlotOnAdding)].Flag = value; } }
        public void SetActiveWidgetIndex(int Index) { Invoke(nameof(SetActiveWidgetIndex), Index); }
        public void SetActiveWidget(Widget Widget) { Invoke(nameof(SetActiveWidget), Widget); }
        public void IncrementActiveWidgetIndex(bool bAllowWrapping) { Invoke(nameof(IncrementActiveWidgetIndex), bAllowWrapping); }
        public int GetActiveWidgetIndex() { return Invoke<int>(nameof(GetActiveWidgetIndex)); }
        public Widget GetActiveWidget() { return Invoke<Widget>(nameof(GetActiveWidget)); }
        public void DecrementActiveWidgetIndex(bool bAllowWrapping) { Invoke(nameof(DecrementActiveWidgetIndex), bAllowWrapping); }
        public void DeactivateVisibleSlot() { Invoke(nameof(DeactivateVisibleSlot)); }
        public void ActivateVisibleSlot() { Invoke(nameof(ActivateVisibleSlot)); }
    }
    public class CommonVisibilitySwitcherSlot : OverlaySlot
    {
        public CommonVisibilitySwitcherSlot(nint addr) : base(addr) { }
    }
    public class UCommonVisibilityWidgetBase : CommonBorder
    {
        public UCommonVisibilityWidgetBase(nint addr) : base(addr) { }
        public Object VisibilityControls { get { return this[nameof(VisibilityControls)]; } set { this[nameof(VisibilityControls)] = value; } }
        public bool bShowForGamepad { get { return this[nameof(bShowForGamepad)].Flag; } set { this[nameof(bShowForGamepad)].Flag = value; } }
        public bool bShowForMouseAndKeyboard { get { return this[nameof(bShowForMouseAndKeyboard)].Flag; } set { this[nameof(bShowForMouseAndKeyboard)].Flag = value; } }
        public bool bShowForTouch { get { return this[nameof(bShowForTouch)].Flag; } set { this[nameof(bShowForTouch)].Flag = value; } }
        public ESlateVisibility VisibleType { get { return (ESlateVisibility)this[nameof(VisibleType)].GetValue<int>(); } set { this[nameof(VisibleType)].SetValue<int>((int)value); } }
        public ESlateVisibility HiddenType { get { return (ESlateVisibility)this[nameof(HiddenType)].GetValue<int>(); } set { this[nameof(HiddenType)].SetValue<int>((int)value); } }
        public Array<Object> GetRegisteredPlatforms() { return Invoke<Array<Object>>(nameof(GetRegisteredPlatforms)); }
    }
    public class CommonVisualAttachment : SizeBox
    {
        public CommonVisualAttachment(nint addr) : base(addr) { }
        public Vector2D ContentAnchor { get { return this[nameof(ContentAnchor)].As<Vector2D>(); } set { this["ContentAnchor"] = value; } }
    }
    public class CommonWidgetCarousel : PanelWidget
    {
        public CommonWidgetCarousel(nint addr) : base(addr) { }
        public int ActiveWidgetIndex { get { return this[nameof(ActiveWidgetIndex)].GetValue<int>(); } set { this[nameof(ActiveWidgetIndex)].SetValue<int>(value); } }
        public Object OnCurrentPageIndexChanged { get { return this[nameof(OnCurrentPageIndexChanged)]; } set { this[nameof(OnCurrentPageIndexChanged)] = value; } }
        public void SetActiveWidgetIndex(int Index) { Invoke(nameof(SetActiveWidgetIndex), Index); }
        public void SetActiveWidget(Widget Widget) { Invoke(nameof(SetActiveWidget), Widget); }
        public void PreviousPage() { Invoke(nameof(PreviousPage)); }
        public void NextPage() { Invoke(nameof(NextPage)); }
        public Widget GetWidgetAtIndex(int Index) { return Invoke<Widget>(nameof(GetWidgetAtIndex), Index); }
        public int GetActiveWidgetIndex() { return Invoke<int>(nameof(GetActiveWidgetIndex)); }
        public void EndAutoScrolling() { Invoke(nameof(EndAutoScrolling)); }
        public void BeginAutoScrolling(float ScrollInterval) { Invoke(nameof(BeginAutoScrolling), ScrollInterval); }
    }
    public class CommonWidgetCarouselNavBar : Widget
    {
        public CommonWidgetCarouselNavBar(nint addr) : base(addr) { }
        public Object ButtonWidgetType { get { return this[nameof(ButtonWidgetType)]; } set { this[nameof(ButtonWidgetType)] = value; } }
        public Margin ButtonPadding { get { return this[nameof(ButtonPadding)].As<Margin>(); } set { this["ButtonPadding"] = value; } }
        public CommonWidgetCarousel LinkedCarousel { get { return this[nameof(LinkedCarousel)].As<CommonWidgetCarousel>(); } set { this["LinkedCarousel"] = value; } }
        public CommonButtonGroupBase ButtonGroup { get { return this[nameof(ButtonGroup)].As<CommonButtonGroupBase>(); } set { this["ButtonGroup"] = value; } }
        public Array<CommonButtonBase> Buttons { get { return new Array<CommonButtonBase>(this[nameof(Buttons)].Address); } }
        public void SetLinkedCarousel(CommonWidgetCarousel CommonCarousel) { Invoke(nameof(SetLinkedCarousel), CommonCarousel); }
        public void HandlePageChanged(CommonWidgetCarousel CommonCarousel, int PageIndex) { Invoke(nameof(HandlePageChanged), CommonCarousel, PageIndex); }
        public void HandleButtonClicked(CommonButtonBase AssociatedButton, int ButtonIndex) { Invoke(nameof(HandleButtonClicked), AssociatedButton, ButtonIndex); }
    }
    public class CommonWidgetGroupBase : Object
    {
        public CommonWidgetGroupBase(nint addr) : base(addr) { }
        public void RemoveWidget(Widget InWidget) { Invoke(nameof(RemoveWidget), InWidget); }
        public void RemoveAll() { Invoke(nameof(RemoveAll)); }
        public void AddWidget(Widget InWidget) { Invoke(nameof(AddWidget), InWidget); }
    }
    public class CommonButtonGroupBase : CommonWidgetGroupBase
    {
        public CommonButtonGroupBase(nint addr) : base(addr) { }
        public Object OnSelectedButtonBaseChanged { get { return this[nameof(OnSelectedButtonBaseChanged)]; } set { this[nameof(OnSelectedButtonBaseChanged)] = value; } }
        public Object OnHoveredButtonBaseChanged { get { return this[nameof(OnHoveredButtonBaseChanged)]; } set { this[nameof(OnHoveredButtonBaseChanged)] = value; } }
        public Object OnButtonBaseClicked { get { return this[nameof(OnButtonBaseClicked)]; } set { this[nameof(OnButtonBaseClicked)] = value; } }
        public Object OnButtonBaseDoubleClicked { get { return this[nameof(OnButtonBaseDoubleClicked)]; } set { this[nameof(OnButtonBaseDoubleClicked)] = value; } }
        public Object OnSelectionCleared { get { return this[nameof(OnSelectionCleared)]; } set { this[nameof(OnSelectionCleared)] = value; } }
        public bool bSelectionRequired { get { return this[nameof(bSelectionRequired)].Flag; } set { this[nameof(bSelectionRequired)].Flag = value; } }
        public void SetSelectionRequired(bool bRequireSelection) { Invoke(nameof(SetSelectionRequired), bRequireSelection); }
        public void SelectPreviousButton(bool bAllowWrap) { Invoke(nameof(SelectPreviousButton), bAllowWrap); }
        public void SelectNextButton(bool bAllowWrap) { Invoke(nameof(SelectNextButton), bAllowWrap); }
        public void SelectButtonAtIndex(int ButtonIndex, bool bAllowSound) { Invoke(nameof(SelectButtonAtIndex), ButtonIndex, bAllowSound); }
        public void OnSelectionStateChangedBase(CommonButtonBase BaseButton, bool bIsSelected) { Invoke(nameof(OnSelectionStateChangedBase), BaseButton, bIsSelected); }
        public void OnHandleButtonBaseDoubleClicked(CommonButtonBase BaseButton) { Invoke(nameof(OnHandleButtonBaseDoubleClicked), BaseButton); }
        public void OnHandleButtonBaseClicked(CommonButtonBase BaseButton) { Invoke(nameof(OnHandleButtonBaseClicked), BaseButton); }
        public void OnButtonBaseUnhovered(CommonButtonBase BaseButton) { Invoke(nameof(OnButtonBaseUnhovered), BaseButton); }
        public void OnButtonBaseHovered(CommonButtonBase BaseButton) { Invoke(nameof(OnButtonBaseHovered), BaseButton); }
        public bool HasAnyButtons() { return Invoke<bool>(nameof(HasAnyButtons)); }
        public int GetSelectedButtonIndex() { return Invoke<int>(nameof(GetSelectedButtonIndex)); }
        public CommonButtonBase GetSelectedButtonBase() { return Invoke<CommonButtonBase>(nameof(GetSelectedButtonBase)); }
        public int GetHoveredButtonIndex() { return Invoke<int>(nameof(GetHoveredButtonIndex)); }
        public int GetButtonCount() { return Invoke<int>(nameof(GetButtonCount)); }
        public CommonButtonBase GetButtonBaseAtIndex(int Index) { return Invoke<CommonButtonBase>(nameof(GetButtonBaseAtIndex), Index); }
        public int FindButtonIndex(CommonButtonBase ButtonToFind) { return Invoke<int>(nameof(FindButtonIndex), ButtonToFind); }
        public void DeselectAll() { Invoke(nameof(DeselectAll)); }
    }
    public class CommonBoundActionBar : DynamicEntryBoxBase
    {
        public CommonBoundActionBar(nint addr) : base(addr) { }
        public Object ActionButtonClass { get { return this[nameof(ActionButtonClass)]; } set { this[nameof(ActionButtonClass)] = value; } }
        public bool bDisplayOwningPlayerActionsOnly { get { return this[nameof(bDisplayOwningPlayerActionsOnly)].Flag; } set { this[nameof(bDisplayOwningPlayerActionsOnly)].Flag = value; } }
        public bool bIgnoreDuplicateActions { get { return this[nameof(bIgnoreDuplicateActions)].Flag; } set { this[nameof(bIgnoreDuplicateActions)].Flag = value; } }
        public void SetDisplayOwningPlayerActionsOnly(bool bShouldOnlyDisplayOwningPlayerActions) { Invoke(nameof(SetDisplayOwningPlayerActionsOnly), bShouldOnlyDisplayOwningPlayerActions); }
    }
    public class CommonBoundActionButton : CommonButtonBase
    {
        public CommonBoundActionButton(nint addr) : base(addr) { }
        public CommonTextBlock Text_ActionName { get { return this[nameof(Text_ActionName)].As<CommonTextBlock>(); } set { this["Text_ActionName"] = value; } }
        public void OnUpdateInputAction() { Invoke(nameof(OnUpdateInputAction)); }
    }
    public class CommonGenericInputActionDataTable : DataTable
    {
        public CommonGenericInputActionDataTable(nint addr) : base(addr) { }
    }
    public class CommonInputActionDataProcessor : Object
    {
        public CommonInputActionDataProcessor(nint addr) : base(addr) { }
    }
    public class CommonUIActionRouterBase : LocalPlayerSubsystem
    {
        public CommonUIActionRouterBase(nint addr) : base(addr) { }
    }
    public class CommonUIInputSettings : Object
    {
        public CommonUIInputSettings(nint addr) : base(addr) { }
        public bool bLinkCursorToGamepadFocus { get { return this[nameof(bLinkCursorToGamepadFocus)].Flag; } set { this[nameof(bLinkCursorToGamepadFocus)].Flag = value; } }
        public int UIActionProcessingPriority { get { return this[nameof(UIActionProcessingPriority)].GetValue<int>(); } set { this[nameof(UIActionProcessingPriority)].SetValue<int>(value); } }
        public Array<UIInputAction> InputActions { get { return new Array<UIInputAction>(this[nameof(InputActions)].Address); } }
        public Array<UIInputAction> ActionOverrides { get { return new Array<UIInputAction>(this[nameof(ActionOverrides)].Address); } }
        public CommonAnalogCursorSettings AnalogCursorSettings { get { return this[nameof(AnalogCursorSettings)].As<CommonAnalogCursorSettings>(); } set { this["AnalogCursorSettings"] = value; } }
    }
    public class CommonStyleSheet : DataAsset
    {
        public CommonStyleSheet(nint addr) : base(addr) { }
        public Array<CommonStyleSheetTypeBase> Properties { get { return new Array<CommonStyleSheetTypeBase>(this[nameof(Properties)].Address); } }
        public Array<CommonStyleSheet> ImportedStyleSheets { get { return new Array<CommonStyleSheet>(this[nameof(ImportedStyleSheets)].Address); } }
    }
    public class CommonActivatableWidgetContainerBase : Widget
    {
        public CommonActivatableWidgetContainerBase(nint addr) : base(addr) { }
        public ECommonSwitcherTransition TransitionType { get { return (ECommonSwitcherTransition)this[nameof(TransitionType)].GetValue<int>(); } set { this[nameof(TransitionType)].SetValue<int>((int)value); } }
        public ETransitionCurve TransitionCurveType { get { return (ETransitionCurve)this[nameof(TransitionCurveType)].GetValue<int>(); } set { this[nameof(TransitionCurveType)].SetValue<int>((int)value); } }
        public float TransitionDuration { get { return this[nameof(TransitionDuration)].GetValue<float>(); } set { this[nameof(TransitionDuration)].SetValue<float>(value); } }
        public Array<CommonActivatableWidget> WidgetList { get { return new Array<CommonActivatableWidget>(this[nameof(WidgetList)].Address); } }
        public CommonActivatableWidget DisplayedWidget { get { return this[nameof(DisplayedWidget)].As<CommonActivatableWidget>(); } set { this["DisplayedWidget"] = value; } }
        public UserWidgetPool GeneratedWidgetsPool { get { return this[nameof(GeneratedWidgetsPool)].As<UserWidgetPool>(); } set { this["GeneratedWidgetsPool"] = value; } }
        public void SetTransitionDuration(float Duration) { Invoke(nameof(SetTransitionDuration), Duration); }
        public void RemoveWidget(CommonActivatableWidget WidgetToRemove) { Invoke(nameof(RemoveWidget), WidgetToRemove); }
        public float GetTransitionDuration() { return Invoke<float>(nameof(GetTransitionDuration)); }
        public CommonActivatableWidget GetActiveWidget() { return Invoke<CommonActivatableWidget>(nameof(GetActiveWidget)); }
        public void ClearWidgets() { Invoke(nameof(ClearWidgets)); }
        public CommonActivatableWidget BP_AddWidget(Object ActivatableWidgetClass) { return Invoke<CommonActivatableWidget>(nameof(BP_AddWidget), ActivatableWidgetClass); }
    }
    public class CommonActivatableWidgetStack : CommonActivatableWidgetContainerBase
    {
        public CommonActivatableWidgetStack(nint addr) : base(addr) { }
        public Object RootContentWidgetClass { get { return this[nameof(RootContentWidgetClass)]; } set { this[nameof(RootContentWidgetClass)] = value; } }
        public CommonActivatableWidget RootContentWidget { get { return this[nameof(RootContentWidget)].As<CommonActivatableWidget>(); } set { this["RootContentWidget"] = value; } }
    }
    public class CommonActivatableWidgetQueue : CommonActivatableWidgetContainerBase
    {
        public CommonActivatableWidgetQueue(nint addr) : base(addr) { }
    }
    public enum ECommonNumericType : int
    {
        Number = 0,
        Percentage = 1,
        Seconds = 2,
        Distance = 3,
        ECommonNumericType_MAX = 4,
    }
    public class CommonNumberFormattingOptions : Object
    {
        public CommonNumberFormattingOptions(nint addr) : base(addr) { }
        public byte RoundingMode { get { return this[nameof(RoundingMode)].GetValue<byte>(); } set { this[nameof(RoundingMode)].SetValue<byte>(value); } }
        public bool UseGrouping { get { return this[nameof(UseGrouping)].Flag; } set { this[nameof(UseGrouping)].Flag = value; } }
        public int MinimumIntegralDigits { get { return this[nameof(MinimumIntegralDigits)].GetValue<int>(); } set { this[nameof(MinimumIntegralDigits)].SetValue<int>(value); } }
        public int MaximumIntegralDigits { get { return this[nameof(MaximumIntegralDigits)].GetValue<int>(); } set { this[nameof(MaximumIntegralDigits)].SetValue<int>(value); } }
        public int MinimumFractionalDigits { get { return this[nameof(MinimumFractionalDigits)].GetValue<int>(); } set { this[nameof(MinimumFractionalDigits)].SetValue<int>(value); } }
        public int MaximumFractionalDigits { get { return this[nameof(MaximumFractionalDigits)].GetValue<int>(); } set { this[nameof(MaximumFractionalDigits)].SetValue<int>(value); } }
    }
    public class CommonRegisteredTabInfo : Object
    {
        public CommonRegisteredTabInfo(nint addr) : base(addr) { }
        public int TabIndex { get { return this[nameof(TabIndex)].GetValue<int>(); } set { this[nameof(TabIndex)].SetValue<int>(value); } }
        public CommonButtonBase TabButton { get { return this[nameof(TabButton)].As<CommonButtonBase>(); } set { this["TabButton"] = value; } }
        public Widget ContentInstance { get { return this[nameof(ContentInstance)].As<Widget>(); } set { this["ContentInstance"] = value; } }
    }
    public enum ERichTextInlineIconDisplayMode : int
    {
        IconOnly = 0,
        TextOnly = 1,
        IconAndText = 2,
        MAX = 3,
    }
    public enum EInputActionState : int
    {
        Enabled = 0,
        Disabled = 1,
        Hidden = 2,
        HiddenAndDisabled = 3,
        EInputActionState_MAX = 4,
    }
    public enum ECommonSwitcherTransition : int
    {
        FadeOnly = 0,
        Horizontal = 1,
        Vertical = 2,
        Zoom = 3,
        ECommonSwitcherTransition_MAX = 4,
    }
    public enum ETransitionCurve : int
    {
        Linear = 0,
        QuadIn = 1,
        QuadOut = 2,
        QuadInOut = 3,
        CubicIn = 4,
        CubicOut = 5,
        CubicInOut = 6,
        ETransitionCurve_MAX = 7,
    }
    public class UITag : GameplayTag
    {
        public UITag(nint addr) : base(addr) { }
    }
    public class UIActionTag : UITag
    {
        public UIActionTag(nint addr) : base(addr) { }
    }
    public class CommonInputActionHandlerData : Object
    {
        public CommonInputActionHandlerData(nint addr) : base(addr) { }
        public DataTableRowHandle InputActionRow { get { return this[nameof(InputActionRow)].As<DataTableRowHandle>(); } set { this["InputActionRow"] = value; } }
        public EInputActionState State { get { return (EInputActionState)this[nameof(State)].GetValue<int>(); } set { this[nameof(State)].SetValue<int>((int)value); } }
    }
    public class CommonButtonStyleOptionalSlateSound : Object
    {
        public CommonButtonStyleOptionalSlateSound(nint addr) : base(addr) { }
        public bool bHasSound { get { return this[nameof(bHasSound)].Flag; } set { this[nameof(bHasSound)].Flag = value; } }
        public SlateSound Sound { get { return this[nameof(Sound)].As<SlateSound>(); } set { this["Sound"] = value; } }
    }
    public class RichTextIconData : TableRowBase
    {
        public RichTextIconData(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object ResourceObject { get { return this[nameof(ResourceObject)]; } set { this[nameof(ResourceObject)] = value; } }
        public Vector2D ImageSize { get { return this[nameof(ImageSize)].As<Vector2D>(); } set { this["ImageSize"] = value; } }
    }
    public class CommonInputTypeInfo : Object
    {
        public CommonInputTypeInfo(nint addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public EInputActionState OverrrideState { get { return (EInputActionState)this[nameof(OverrrideState)].GetValue<int>(); } set { this[nameof(OverrrideState)].SetValue<int>((int)value); } }
        public bool bActionRequiresHold { get { return this[nameof(bActionRequiresHold)].Flag; } set { this[nameof(bActionRequiresHold)].Flag = value; } }
        public float HoldTime { get { return this[nameof(HoldTime)].GetValue<float>(); } set { this[nameof(HoldTime)].SetValue<float>(value); } }
        public SlateBrush OverrideBrush { get { return this[nameof(OverrideBrush)].As<SlateBrush>(); } set { this["OverrideBrush"] = value; } }
    }
    public class CommonInputActionDataBase : TableRowBase
    {
        public CommonInputActionDataBase(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object HoldDisplayName { get { return this[nameof(HoldDisplayName)]; } set { this[nameof(HoldDisplayName)] = value; } }
        public int NavBarPriority { get { return this[nameof(NavBarPriority)].GetValue<int>(); } set { this[nameof(NavBarPriority)].SetValue<int>(value); } }
        public CommonInputTypeInfo KeyboardInputTypeInfo { get { return this[nameof(KeyboardInputTypeInfo)].As<CommonInputTypeInfo>(); } set { this["KeyboardInputTypeInfo"] = value; } }
        public CommonInputTypeInfo DefaultGamepadInputTypeInfo { get { return this[nameof(DefaultGamepadInputTypeInfo)].As<CommonInputTypeInfo>(); } set { this["DefaultGamepadInputTypeInfo"] = value; } }
        public Object GamepadInputOverrides { get { return this[nameof(GamepadInputOverrides)]; } set { this[nameof(GamepadInputOverrides)] = value; } }
        public CommonInputTypeInfo TouchInputTypeInfo { get { return this[nameof(TouchInputTypeInfo)].As<CommonInputTypeInfo>(); } set { this["TouchInputTypeInfo"] = value; } }
    }
    public class UIActionKeyMapping : Object
    {
        public UIActionKeyMapping(nint addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public float HoldTime { get { return this[nameof(HoldTime)].GetValue<float>(); } set { this[nameof(HoldTime)].SetValue<float>(value); } }
    }
    public class UIInputAction : Object
    {
        public UIInputAction(nint addr) : base(addr) { }
        public UIActionTag ActionTag { get { return this[nameof(ActionTag)].As<UIActionTag>(); } set { this["ActionTag"] = value; } }
        public Object DefaultDisplayName { get { return this[nameof(DefaultDisplayName)]; } set { this[nameof(DefaultDisplayName)] = value; } }
        public Array<UIActionKeyMapping> KeyMappings { get { return new Array<UIActionKeyMapping>(this[nameof(KeyMappings)].Address); } }
    }
    public class CommonAnalogCursorSettings : Object
    {
        public CommonAnalogCursorSettings(nint addr) : base(addr) { }
        public int PreprocessorPriority { get { return this[nameof(PreprocessorPriority)].GetValue<int>(); } set { this[nameof(PreprocessorPriority)].SetValue<int>(value); } }
        public bool bEnableCursorAcceleration { get { return this[nameof(bEnableCursorAcceleration)].Flag; } set { this[nameof(bEnableCursorAcceleration)].Flag = value; } }
        public float CursorAcceleration { get { return this[nameof(CursorAcceleration)].GetValue<float>(); } set { this[nameof(CursorAcceleration)].SetValue<float>(value); } }
        public float CursorMaxSpeed { get { return this[nameof(CursorMaxSpeed)].GetValue<float>(); } set { this[nameof(CursorMaxSpeed)].SetValue<float>(value); } }
        public float CursorDeadZone { get { return this[nameof(CursorDeadZone)].GetValue<float>(); } set { this[nameof(CursorDeadZone)].SetValue<float>(value); } }
        public float HoverSlowdownFactor { get { return this[nameof(HoverSlowdownFactor)].GetValue<float>(); } set { this[nameof(HoverSlowdownFactor)].SetValue<float>(value); } }
        public float ScrollDeadZone { get { return this[nameof(ScrollDeadZone)].GetValue<float>(); } set { this[nameof(ScrollDeadZone)].SetValue<float>(value); } }
        public float ScrollUpdatePeriod { get { return this[nameof(ScrollUpdatePeriod)].GetValue<float>(); } set { this[nameof(ScrollUpdatePeriod)].SetValue<float>(value); } }
        public float ScrollMultiplier { get { return this[nameof(ScrollMultiplier)].GetValue<float>(); } set { this[nameof(ScrollMultiplier)].SetValue<float>(value); } }
    }
}
