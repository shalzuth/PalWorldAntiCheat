using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.EngineSDK;
using SDK.Script.SlateSDK;
using SDK.Script.MovieSceneTracksSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.PropertyPathSDK;
namespace SDK.Script.UMGSDK
{
    public class Visual : Object
    {
        public Visual(nint addr) : base(addr) { }
    }
    public class Widget : Visual
    {
        public Widget(nint addr) : base(addr) { }
        public PanelSlot Slot { get { return this[nameof(Slot)].As<PanelSlot>(); } set { this["Slot"] = value; } }
        public Object bIsEnabledDelegate { get { return this[nameof(bIsEnabledDelegate)]; } set { this[nameof(bIsEnabledDelegate)] = value; } }
        public Object ToolTipText { get { return this[nameof(ToolTipText)]; } set { this[nameof(ToolTipText)] = value; } }
        public Object ToolTipTextDelegate { get { return this[nameof(ToolTipTextDelegate)]; } set { this[nameof(ToolTipTextDelegate)] = value; } }
        public Widget ToolTipWidget { get { return this[nameof(ToolTipWidget)].As<Widget>(); } set { this["ToolTipWidget"] = value; } }
        public Object ToolTipWidgetDelegate { get { return this[nameof(ToolTipWidgetDelegate)]; } set { this[nameof(ToolTipWidgetDelegate)] = value; } }
        public Object VisibilityDelegate { get { return this[nameof(VisibilityDelegate)]; } set { this[nameof(VisibilityDelegate)] = value; } }
        public WidgetTransform RenderTransform { get { return this[nameof(RenderTransform)].As<WidgetTransform>(); } set { this["RenderTransform"] = value; } }
        public Vector2D RenderTransformPivot { get { return this[nameof(RenderTransformPivot)].As<Vector2D>(); } set { this["RenderTransformPivot"] = value; } }
        public EFlowDirectionPreference FlowDirectionPreference { get { return (EFlowDirectionPreference)this[nameof(FlowDirectionPreference)].GetValue<int>(); } set { this[nameof(FlowDirectionPreference)].SetValue<int>((int)value); } }
        public bool bIsVariable { get { return this[nameof(bIsVariable)].Flag; } set { this[nameof(bIsVariable)].Flag = value; } }
        public bool bCreatedByConstructionScript { get { return this[nameof(bCreatedByConstructionScript)].Flag; } set { this[nameof(bCreatedByConstructionScript)].Flag = value; } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public bool bOverride_Cursor { get { return this[nameof(bOverride_Cursor)].Flag; } set { this[nameof(bOverride_Cursor)].Flag = value; } }
        public bool bIsVolatile { get { return this[nameof(bIsVolatile)].Flag; } set { this[nameof(bIsVolatile)].Flag = value; } }
        public byte Cursor { get { return this[nameof(Cursor)].GetValue<byte>(); } set { this[nameof(Cursor)].SetValue<byte>(value); } }
        public EWidgetClipping Clipping { get { return (EWidgetClipping)this[nameof(Clipping)].GetValue<int>(); } set { this[nameof(Clipping)].SetValue<int>((int)value); } }
        public ESlateVisibility Visibility { get { return (ESlateVisibility)this[nameof(Visibility)].GetValue<int>(); } set { this[nameof(Visibility)].SetValue<int>((int)value); } }
        public float RenderOpacity { get { return this[nameof(RenderOpacity)].GetValue<float>(); } set { this[nameof(RenderOpacity)].SetValue<float>(value); } }
        public SlateAccessibleWidgetData AccessibleWidgetData { get { return this[nameof(AccessibleWidgetData)].As<SlateAccessibleWidgetData>(); } set { this["AccessibleWidgetData"] = value; } }
        public WidgetNavigation Navigation { get { return this[nameof(Navigation)].As<WidgetNavigation>(); } set { this["Navigation"] = value; } }
        public Array<PropertyBinding> NativeBindings { get { return new Array<PropertyBinding>(this[nameof(NativeBindings)].Address); } }
        public void SetVisibility(ESlateVisibility InVisibility) { Invoke(nameof(SetVisibility), InVisibility); }
        public void SetUserFocus(PlayerController PlayerController) { Invoke(nameof(SetUserFocus), PlayerController); }
        public void SetToolTipText(Object InToolTipText) { Invoke(nameof(SetToolTipText), InToolTipText); }
        public void SetToolTip(Widget Widget) { Invoke(nameof(SetToolTip), Widget); }
        public void SetRenderTranslation(Vector2D Translation) { Invoke(nameof(SetRenderTranslation), Translation); }
        public void SetRenderTransformPivot(Vector2D Pivot) { Invoke(nameof(SetRenderTransformPivot), Pivot); }
        public void SetRenderTransformAngle(float Angle) { Invoke(nameof(SetRenderTransformAngle), Angle); }
        public void SetRenderTransform(WidgetTransform InTransform) { Invoke(nameof(SetRenderTransform), InTransform); }
        public void SetRenderShear(Vector2D Shear) { Invoke(nameof(SetRenderShear), Shear); }
        public void SetRenderScale(Vector2D Scale) { Invoke(nameof(SetRenderScale), Scale); }
        public void SetRenderOpacity(float InOpacity) { Invoke(nameof(SetRenderOpacity), InOpacity); }
        public void SetNavigationRuleExplicit(EUINavigation Direction, Widget InWidget) { Invoke(nameof(SetNavigationRuleExplicit), Direction, InWidget); }
        public void SetNavigationRuleCustomBoundary(EUINavigation Direction, Object InCustomDelegate) { Invoke(nameof(SetNavigationRuleCustomBoundary), Direction, InCustomDelegate); }
        public void SetNavigationRuleCustom(EUINavigation Direction, Object InCustomDelegate) { Invoke(nameof(SetNavigationRuleCustom), Direction, InCustomDelegate); }
        public void SetNavigationRuleBase(EUINavigation Direction, EUINavigationRule Rule) { Invoke(nameof(SetNavigationRuleBase), Direction, Rule); }
        public void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, Object WidgetToFocus) { Invoke(nameof(SetNavigationRule), Direction, Rule, WidgetToFocus); }
        public void SetKeyboardFocus() { Invoke(nameof(SetKeyboardFocus)); }
        public void SetIsEnabled(bool bInIsEnabled) { Invoke(nameof(SetIsEnabled), bInIsEnabled); }
        public void SetFocus() { Invoke(nameof(SetFocus)); }
        public void SetCursor(byte InCursor) { Invoke(nameof(SetCursor), InCursor); }
        public void SetClipping(EWidgetClipping InClipping) { Invoke(nameof(SetClipping), InClipping); }
        public void SetAllNavigationRules(EUINavigationRule Rule, Object WidgetToFocus) { Invoke(nameof(SetAllNavigationRules), Rule, WidgetToFocus); }
        public void ResetCursor() { Invoke(nameof(ResetCursor)); }
        public void RemoveFromParent() { Invoke(nameof(RemoveFromParent)); }
        public EventReply OnReply__DelegateSignature() { return Invoke<EventReply>(nameof(OnReply__DelegateSignature)); }
        public EventReply OnPointerEvent__DelegateSignature(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnPointerEvent__DelegateSignature), MyGeometry, MouseEvent); }
        public void K2_RemoveFieldValueChangedDelegate(FieldNotificationId FieldId, Object Delegate) { Invoke(nameof(K2_RemoveFieldValueChangedDelegate), FieldId, Delegate); }
        public void K2_BroadcastFieldValueChanged(FieldNotificationId FieldId) { Invoke(nameof(K2_BroadcastFieldValueChanged), FieldId); }
        public void K2_AddFieldValueChangedDelegate(FieldNotificationId FieldId, Object Delegate) { Invoke(nameof(K2_AddFieldValueChangedDelegate), FieldId, Delegate); }
        public bool IsVisible() { return Invoke<bool>(nameof(IsVisible)); }
        public bool IsRendered() { return Invoke<bool>(nameof(IsRendered)); }
        public bool IsInViewport() { return Invoke<bool>(nameof(IsInViewport)); }
        public bool IsHovered() { return Invoke<bool>(nameof(IsHovered)); }
        public void InvalidateLayoutAndVolatility() { Invoke(nameof(InvalidateLayoutAndVolatility)); }
        public bool HasUserFocusedDescendants(PlayerController PlayerController) { return Invoke<bool>(nameof(HasUserFocusedDescendants), PlayerController); }
        public bool HasUserFocus(PlayerController PlayerController) { return Invoke<bool>(nameof(HasUserFocus), PlayerController); }
        public bool HasMouseCaptureByUser(int UserIndex, int PointerIndex) { return Invoke<bool>(nameof(HasMouseCaptureByUser), UserIndex, PointerIndex); }
        public bool HasMouseCapture() { return Invoke<bool>(nameof(HasMouseCapture)); }
        public bool HasKeyboardFocus() { return Invoke<bool>(nameof(HasKeyboardFocus)); }
        public bool HasFocusedDescendants() { return Invoke<bool>(nameof(HasFocusedDescendants)); }
        public bool HasAnyUserFocus() { return Invoke<bool>(nameof(HasAnyUserFocus)); }
        public Widget GetWidget__DelegateSignature() { return Invoke<Widget>(nameof(GetWidget__DelegateSignature)); }
        public ESlateVisibility GetVisibility() { return Invoke<ESlateVisibility>(nameof(GetVisibility)); }
        public Geometry GetTickSpaceGeometry() { return Invoke<Geometry>(nameof(GetTickSpaceGeometry)); }
        public Object GetText__DelegateSignature() { return Invoke<Object>(nameof(GetText__DelegateSignature)); }
        public ESlateVisibility GetSlateVisibility__DelegateSignature() { return Invoke<ESlateVisibility>(nameof(GetSlateVisibility__DelegateSignature)); }
        public SlateColor GetSlateColor__DelegateSignature() { return Invoke<SlateColor>(nameof(GetSlateColor__DelegateSignature)); }
        public SlateBrush GetSlateBrush__DelegateSignature() { return Invoke<SlateBrush>(nameof(GetSlateBrush__DelegateSignature)); }
        public float GetRenderTransformAngle() { return Invoke<float>(nameof(GetRenderTransformAngle)); }
        public float GetRenderOpacity() { return Invoke<float>(nameof(GetRenderOpacity)); }
        public PanelWidget GetParent() { return Invoke<PanelWidget>(nameof(GetParent)); }
        public Geometry GetPaintSpaceGeometry() { return Invoke<Geometry>(nameof(GetPaintSpaceGeometry)); }
        public PlayerController GetOwningPlayer() { return Invoke<PlayerController>(nameof(GetOwningPlayer)); }
        public LocalPlayer GetOwningLocalPlayer() { return Invoke<LocalPlayer>(nameof(GetOwningLocalPlayer)); }
        public byte GetMouseCursor__DelegateSignature() { return Invoke<byte>(nameof(GetMouseCursor__DelegateSignature)); }
        public LinearColor GetLinearColor__DelegateSignature() { return Invoke<LinearColor>(nameof(GetLinearColor__DelegateSignature)); }
        public bool GetIsEnabled() { return Invoke<bool>(nameof(GetIsEnabled)); }
        public int GetInt32__DelegateSignature() { return Invoke<int>(nameof(GetInt32__DelegateSignature)); }
        public GameInstance GetGameInstance() { return Invoke<GameInstance>(nameof(GetGameInstance)); }
        public float GetFloat__DelegateSignature() { return Invoke<float>(nameof(GetFloat__DelegateSignature)); }
        public Vector2D GetDesiredSize() { return Invoke<Vector2D>(nameof(GetDesiredSize)); }
        public EWidgetClipping GetClipping() { return Invoke<EWidgetClipping>(nameof(GetClipping)); }
        public ECheckBoxState GetCheckBoxState__DelegateSignature() { return Invoke<ECheckBoxState>(nameof(GetCheckBoxState__DelegateSignature)); }
        public Geometry GetCachedGeometry() { return Invoke<Geometry>(nameof(GetCachedGeometry)); }
        public bool GetBool__DelegateSignature() { return Invoke<bool>(nameof(GetBool__DelegateSignature)); }
        public Object GetAccessibleText() { return Invoke<Object>(nameof(GetAccessibleText)); }
        public Object GetAccessibleSummaryText() { return Invoke<Object>(nameof(GetAccessibleSummaryText)); }
        public Widget GenerateWidgetForString__DelegateSignature(Object Item) { return Invoke<Widget>(nameof(GenerateWidgetForString__DelegateSignature), Item); }
        public Widget GenerateWidgetForObject__DelegateSignature(Object Item) { return Invoke<Widget>(nameof(GenerateWidgetForObject__DelegateSignature), Item); }
        public void ForceVolatile(bool bForce) { Invoke(nameof(ForceVolatile), bForce); }
        public void ForceLayoutPrepass() { Invoke(nameof(ForceLayoutPrepass)); }
    }
    public class Slider : Widget
    {
        public Slider(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public float MinValue { get { return this[nameof(MinValue)].GetValue<float>(); } set { this[nameof(MinValue)].SetValue<float>(value); } }
        public float MaxValue { get { return this[nameof(MaxValue)].GetValue<float>(); } set { this[nameof(MaxValue)].SetValue<float>(value); } }
        public SliderStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SliderStyle>(); } set { this["WidgetStyle"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public LinearColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<LinearColor>(); } set { this["SliderBarColor"] = value; } }
        public LinearColor SliderHandleColor { get { return this[nameof(SliderHandleColor)].As<LinearColor>(); } set { this["SliderHandleColor"] = value; } }
        public bool IndentHandle { get { return this[nameof(IndentHandle)].Flag; } set { this[nameof(IndentHandle)].Flag = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public bool MouseUsesStep { get { return this[nameof(MouseUsesStep)].Flag; } set { this[nameof(MouseUsesStep)].Flag = value; } }
        public bool RequiresControllerLock { get { return this[nameof(RequiresControllerLock)].Flag; } set { this[nameof(RequiresControllerLock)].Flag = value; } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public Object OnMouseCaptureBegin { get { return this[nameof(OnMouseCaptureBegin)]; } set { this[nameof(OnMouseCaptureBegin)] = value; } }
        public Object OnMouseCaptureEnd { get { return this[nameof(OnMouseCaptureEnd)]; } set { this[nameof(OnMouseCaptureEnd)] = value; } }
        public Object OnControllerCaptureBegin { get { return this[nameof(OnControllerCaptureBegin)]; } set { this[nameof(OnControllerCaptureBegin)] = value; } }
        public Object OnControllerCaptureEnd { get { return this[nameof(OnControllerCaptureEnd)]; } set { this[nameof(OnControllerCaptureEnd)] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public void SetValue(float InValue) { Invoke(nameof(SetValue), InValue); }
        public void SetStepSize(float InValue) { Invoke(nameof(SetStepSize), InValue); }
        public void SetSliderHandleColor(LinearColor InValue) { Invoke(nameof(SetSliderHandleColor), InValue); }
        public void SetSliderBarColor(LinearColor InValue) { Invoke(nameof(SetSliderBarColor), InValue); }
        public void SetMinValue(float InValue) { Invoke(nameof(SetMinValue), InValue); }
        public void SetMaxValue(float InValue) { Invoke(nameof(SetMaxValue), InValue); }
        public void SetLocked(bool InValue) { Invoke(nameof(SetLocked), InValue); }
        public void SetIndentHandle(bool InValue) { Invoke(nameof(SetIndentHandle), InValue); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public float GetNormalizedValue() { return Invoke<float>(nameof(GetNormalizedValue)); }
    }
    public class UserWidget : Widget
    {
        public UserWidget(nint addr) : base(addr) { }
        public LinearColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<LinearColor>(); } set { this["ColorAndOpacity"] = value; } }
        public Object ColorAndOpacityDelegate { get { return this[nameof(ColorAndOpacityDelegate)]; } set { this[nameof(ColorAndOpacityDelegate)] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public Object ForegroundColorDelegate { get { return this[nameof(ForegroundColorDelegate)]; } set { this[nameof(ForegroundColorDelegate)] = value; } }
        public Object OnVisibilityChanged { get { return this[nameof(OnVisibilityChanged)]; } set { this[nameof(OnVisibilityChanged)] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public Array<UMGSequencePlayer> ActiveSequencePlayers { get { return new Array<UMGSequencePlayer>(this[nameof(ActiveSequencePlayers)].Address); } }
        public UMGSequenceTickManager AnimationTickManager { get { return this[nameof(AnimationTickManager)].As<UMGSequenceTickManager>(); } set { this["AnimationTickManager"] = value; } }
        public Array<UMGSequencePlayer> StoppedSequencePlayers { get { return new Array<UMGSequencePlayer>(this[nameof(StoppedSequencePlayers)].Address); } }
        public Array<NamedSlotBinding> NamedSlotBindings { get { return new Array<NamedSlotBinding>(this[nameof(NamedSlotBindings)].Address); } }
        public Array<UserWidgetExtension> Extensions { get { return new Array<UserWidgetExtension>(this[nameof(Extensions)].Address); } }
        public WidgetTree WidgetTree { get { return this[nameof(WidgetTree)].As<WidgetTree>(); } set { this["WidgetTree"] = value; } }
        public int Priority { get { return this[nameof(Priority)].GetValue<int>(); } set { this[nameof(Priority)].SetValue<int>(value); } }
        public bool bIsFocusable { get { return this[nameof(bIsFocusable)].Flag; } set { this[nameof(bIsFocusable)].Flag = value; } }
        public bool bStopAction { get { return this[nameof(bStopAction)].Flag; } set { this[nameof(bStopAction)].Flag = value; } }
        public bool bHasScriptImplementedTick { get { return this[nameof(bHasScriptImplementedTick)].Flag; } set { this[nameof(bHasScriptImplementedTick)].Flag = value; } }
        public bool bHasScriptImplementedPaint { get { return this[nameof(bHasScriptImplementedPaint)].Flag; } set { this[nameof(bHasScriptImplementedPaint)].Flag = value; } }
        public EWidgetTickFrequency TickFrequency { get { return (EWidgetTickFrequency)this[nameof(TickFrequency)].GetValue<int>(); } set { this[nameof(TickFrequency)].SetValue<int>((int)value); } }
        public InputComponent InputComponent { get { return this[nameof(InputComponent)].As<InputComponent>(); } set { this["InputComponent"] = value; } }
        public Array<AnimationEventBinding> AnimationCallbacks { get { return new Array<AnimationEventBinding>(this[nameof(AnimationCallbacks)].Address); } }
        public void UnregisterInputComponent() { Invoke(nameof(UnregisterInputComponent)); }
        public void UnbindFromAnimationStarted(WidgetAnimation Animation, Object Delegate) { Invoke(nameof(UnbindFromAnimationStarted), Animation, Delegate); }
        public void UnbindFromAnimationFinished(WidgetAnimation Animation, Object Delegate) { Invoke(nameof(UnbindFromAnimationFinished), Animation, Delegate); }
        public void UnbindAllFromAnimationStarted(WidgetAnimation Animation) { Invoke(nameof(UnbindAllFromAnimationStarted), Animation); }
        public void UnbindAllFromAnimationFinished(WidgetAnimation Animation) { Invoke(nameof(UnbindAllFromAnimationFinished), Animation); }
        public void Tick(Geometry MyGeometry, float InDeltaTime) { Invoke(nameof(Tick), MyGeometry, InDeltaTime); }
        public void StopListeningForInputAction(Object ActionName, byte EventType) { Invoke(nameof(StopListeningForInputAction), ActionName, EventType); }
        public void StopListeningForAllInputActions() { Invoke(nameof(StopListeningForAllInputActions)); }
        public void StopAnimationsAndLatentActions() { Invoke(nameof(StopAnimationsAndLatentActions)); }
        public void StopAnimation(WidgetAnimation InAnimation) { Invoke(nameof(StopAnimation), InAnimation); }
        public void StopAllAnimations() { Invoke(nameof(StopAllAnimations)); }
        public void SetPositionInViewport(Vector2D Position, bool bRemoveDPIScale) { Invoke(nameof(SetPositionInViewport), Position, bRemoveDPIScale); }
        public void SetPlaybackSpeed(WidgetAnimation InAnimation, float PlaybackSpeed) { Invoke(nameof(SetPlaybackSpeed), InAnimation, PlaybackSpeed); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetOwningPlayer(PlayerController LocalPlayerController) { Invoke(nameof(SetOwningPlayer), LocalPlayerController); }
        public void SetNumLoopsToPlay(WidgetAnimation InAnimation, int NumLoopsToPlay) { Invoke(nameof(SetNumLoopsToPlay), InAnimation, NumLoopsToPlay); }
        public void SetInputActionPriority(int NewPriority) { Invoke(nameof(SetInputActionPriority), NewPriority); }
        public void SetInputActionBlocking(bool bShouldBlock) { Invoke(nameof(SetInputActionBlocking), bShouldBlock); }
        public void SetForegroundColor(SlateColor InForegroundColor) { Invoke(nameof(SetForegroundColor), InForegroundColor); }
        public void SetDesiredSizeInViewport(Vector2D Size) { Invoke(nameof(SetDesiredSizeInViewport), Size); }
        public void SetColorAndOpacity(LinearColor InColorAndOpacity) { Invoke(nameof(SetColorAndOpacity), InColorAndOpacity); }
        public void SetAnimationCurrentTime(WidgetAnimation InAnimation, float InTime) { Invoke(nameof(SetAnimationCurrentTime), InAnimation, InTime); }
        public void SetAnchorsInViewport(Anchors Anchors) { Invoke(nameof(SetAnchorsInViewport), Anchors); }
        public void SetAlignmentInViewport(Vector2D Alignment) { Invoke(nameof(SetAlignmentInViewport), Alignment); }
        public void ReverseAnimation(WidgetAnimation InAnimation) { Invoke(nameof(ReverseAnimation), InAnimation); }
        public void RemoveFromViewport() { Invoke(nameof(RemoveFromViewport)); }
        public void RemoveExtensions(Object InExtensionType) { Invoke(nameof(RemoveExtensions), InExtensionType); }
        public void RemoveExtension(UserWidgetExtension InExtension) { Invoke(nameof(RemoveExtension), InExtension); }
        public void RegisterInputComponent() { Invoke(nameof(RegisterInputComponent)); }
        public void PreConstruct(bool IsDesignTime) { Invoke(nameof(PreConstruct), IsDesignTime); }
        public void PlaySound(SoundBase SoundToPlay) { Invoke(nameof(PlaySound), SoundToPlay); }
        public UMGSequencePlayer PlayAnimationTimeRange(WidgetAnimation InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed, bool bRestoreState) { return Invoke<UMGSequencePlayer>(nameof(PlayAnimationTimeRange), InAnimation, StartAtTime, EndAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed, bRestoreState); }
        public UMGSequencePlayer PlayAnimationReverse(WidgetAnimation InAnimation, float PlaybackSpeed, bool bRestoreState) { return Invoke<UMGSequencePlayer>(nameof(PlayAnimationReverse), InAnimation, PlaybackSpeed, bRestoreState); }
        public UMGSequencePlayer PlayAnimationForward(WidgetAnimation InAnimation, float PlaybackSpeed, bool bRestoreState) { return Invoke<UMGSequencePlayer>(nameof(PlayAnimationForward), InAnimation, PlaybackSpeed, bRestoreState); }
        public UMGSequencePlayer PlayAnimation(WidgetAnimation InAnimation, float StartAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed, bool bRestoreState) { return Invoke<UMGSequencePlayer>(nameof(PlayAnimation), InAnimation, StartAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed, bRestoreState); }
        public float PauseAnimation(WidgetAnimation InAnimation) { return Invoke<float>(nameof(PauseAnimation), InAnimation); }
        public EventReply OnTouchStarted(Geometry MyGeometry, PointerEvent InTouchEvent) { return Invoke<EventReply>(nameof(OnTouchStarted), MyGeometry, InTouchEvent); }
        public EventReply OnTouchMoved(Geometry MyGeometry, PointerEvent InTouchEvent) { return Invoke<EventReply>(nameof(OnTouchMoved), MyGeometry, InTouchEvent); }
        public EventReply OnTouchGesture(Geometry MyGeometry, PointerEvent GestureEvent) { return Invoke<EventReply>(nameof(OnTouchGesture), MyGeometry, GestureEvent); }
        public EventReply OnTouchForceChanged(Geometry MyGeometry, PointerEvent InTouchEvent) { return Invoke<EventReply>(nameof(OnTouchForceChanged), MyGeometry, InTouchEvent); }
        public EventReply OnTouchEnded(Geometry MyGeometry, PointerEvent InTouchEvent) { return Invoke<EventReply>(nameof(OnTouchEnded), MyGeometry, InTouchEvent); }
        public void OnRemovedFromFocusPath(FocusEvent InFocusEvent) { Invoke(nameof(OnRemovedFromFocusPath), InFocusEvent); }
        public EventReply OnPreviewMouseButtonDown(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnPreviewMouseButtonDown), MyGeometry, MouseEvent); }
        public EventReply OnPreviewKeyDown(Geometry MyGeometry, KeyEvent InKeyEvent) { return Invoke<EventReply>(nameof(OnPreviewKeyDown), MyGeometry, InKeyEvent); }
        public void OnPaint(PaintContext Context) { Invoke(nameof(OnPaint), Context); }
        public EventReply OnMouseWheel(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnMouseWheel), MyGeometry, MouseEvent); }
        public EventReply OnMouseMove(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnMouseMove), MyGeometry, MouseEvent); }
        public void OnMouseLeave(PointerEvent MouseEvent) { Invoke(nameof(OnMouseLeave), MouseEvent); }
        public void OnMouseEnter(Geometry MyGeometry, PointerEvent MouseEvent) { Invoke(nameof(OnMouseEnter), MyGeometry, MouseEvent); }
        public void OnMouseCaptureLost() { Invoke(nameof(OnMouseCaptureLost)); }
        public EventReply OnMouseButtonUp(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnMouseButtonUp), MyGeometry, MouseEvent); }
        public EventReply OnMouseButtonDown(Geometry MyGeometry, PointerEvent MouseEvent) { return Invoke<EventReply>(nameof(OnMouseButtonDown), MyGeometry, MouseEvent); }
        public EventReply OnMouseButtonDoubleClick(Geometry InMyGeometry, PointerEvent InMouseEvent) { return Invoke<EventReply>(nameof(OnMouseButtonDoubleClick), InMyGeometry, InMouseEvent); }
        public EventReply OnMotionDetected(Geometry MyGeometry, MotionEvent InMotionEvent) { return Invoke<EventReply>(nameof(OnMotionDetected), MyGeometry, InMotionEvent); }
        public EventReply OnKeyUp(Geometry MyGeometry, KeyEvent InKeyEvent) { return Invoke<EventReply>(nameof(OnKeyUp), MyGeometry, InKeyEvent); }
        public EventReply OnKeyDown(Geometry MyGeometry, KeyEvent InKeyEvent) { return Invoke<EventReply>(nameof(OnKeyDown), MyGeometry, InKeyEvent); }
        public EventReply OnKeyChar(Geometry MyGeometry, CharacterEvent InCharacterEvent) { return Invoke<EventReply>(nameof(OnKeyChar), MyGeometry, InCharacterEvent); }
        public void OnInitialized() { Invoke(nameof(OnInitialized)); }
        public EventReply OnFocusReceived(Geometry MyGeometry, FocusEvent InFocusEvent) { return Invoke<EventReply>(nameof(OnFocusReceived), MyGeometry, InFocusEvent); }
        public void OnFocusLost(FocusEvent InFocusEvent) { Invoke(nameof(OnFocusLost), InFocusEvent); }
        public bool OnDrop(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) { return Invoke<bool>(nameof(OnDrop), MyGeometry, PointerEvent, Operation); }
        public bool OnDragOver(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) { return Invoke<bool>(nameof(OnDragOver), MyGeometry, PointerEvent, Operation); }
        public void OnDragLeave(PointerEvent PointerEvent, DragDropOperation Operation) { Invoke(nameof(OnDragLeave), PointerEvent, Operation); }
        public void OnDragEnter(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) { Invoke(nameof(OnDragEnter), MyGeometry, PointerEvent, Operation); }
        public void OnDragDetected(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) { Invoke(nameof(OnDragDetected), MyGeometry, PointerEvent, Operation); }
        public void OnDragCancelled(PointerEvent PointerEvent, DragDropOperation Operation) { Invoke(nameof(OnDragCancelled), PointerEvent, Operation); }
        public void OnAnimationStarted(WidgetAnimation Animation) { Invoke(nameof(OnAnimationStarted), Animation); }
        public void OnAnimationFinished(WidgetAnimation Animation) { Invoke(nameof(OnAnimationFinished), Animation); }
        public EventReply OnAnalogValueChanged(Geometry MyGeometry, AnalogInputEvent InAnalogInputEvent) { return Invoke<EventReply>(nameof(OnAnalogValueChanged), MyGeometry, InAnalogInputEvent); }
        public void OnAddedToFocusPath(FocusEvent InFocusEvent) { Invoke(nameof(OnAddedToFocusPath), InFocusEvent); }
        public void ListenForInputAction(Object ActionName, byte EventType, bool bConsume, Object Callback) { Invoke(nameof(ListenForInputAction), ActionName, EventType, bConsume, Callback); }
        public bool IsPlayingAnimation() { return Invoke<bool>(nameof(IsPlayingAnimation)); }
        public bool IsListeningForInputAction(Object ActionName) { return Invoke<bool>(nameof(IsListeningForInputAction), ActionName); }
        public bool IsInteractable() { return Invoke<bool>(nameof(IsInteractable)); }
        public bool IsAnyAnimationPlaying() { return Invoke<bool>(nameof(IsAnyAnimationPlaying)); }
        public bool IsAnimationPlayingForward(WidgetAnimation InAnimation) { return Invoke<bool>(nameof(IsAnimationPlayingForward), InAnimation); }
        public bool IsAnimationPlaying(WidgetAnimation InAnimation) { return Invoke<bool>(nameof(IsAnimationPlaying), InAnimation); }
        public Pawn GetOwningPlayerPawn() { return Invoke<Pawn>(nameof(GetOwningPlayerPawn)); }
        public PlayerCameraManager GetOwningPlayerCameraManager() { return Invoke<PlayerCameraManager>(nameof(GetOwningPlayerCameraManager)); }
        public bool GetIsVisible() { return Invoke<bool>(nameof(GetIsVisible)); }
        public Array<UserWidgetExtension> GetExtensions(Object ExtensionType) { return Invoke<Array<UserWidgetExtension>>(nameof(GetExtensions), ExtensionType); }
        public UserWidgetExtension GetExtension(Object ExtensionType) { return Invoke<UserWidgetExtension>(nameof(GetExtension), ExtensionType); }
        public float GetAnimationCurrentTime(WidgetAnimation InAnimation) { return Invoke<float>(nameof(GetAnimationCurrentTime), InAnimation); }
        public Anchors GetAnchorsInViewport() { return Invoke<Anchors>(nameof(GetAnchorsInViewport)); }
        public Vector2D GetAlignmentInViewport() { return Invoke<Vector2D>(nameof(GetAlignmentInViewport)); }
        public void FlushAnimations() { Invoke(nameof(FlushAnimations)); }
        public void Destruct() { Invoke(nameof(Destruct)); }
        public void Construct() { Invoke(nameof(Construct)); }
        public void CancelLatentActions() { Invoke(nameof(CancelLatentActions)); }
        public void BindToAnimationStarted(WidgetAnimation Animation, Object Delegate) { Invoke(nameof(BindToAnimationStarted), Animation, Delegate); }
        public void BindToAnimationFinished(WidgetAnimation Animation, Object Delegate) { Invoke(nameof(BindToAnimationFinished), Animation, Delegate); }
        public void BindToAnimationEvent(WidgetAnimation Animation, Object Delegate, EWidgetAnimationEvent AnimationEvent, Object UserTag) { Invoke(nameof(BindToAnimationEvent), Animation, Delegate, AnimationEvent, UserTag); }
        public void AddToViewport(int ZOrder) { Invoke(nameof(AddToViewport), ZOrder); }
        public bool AddToPlayerScreen(int ZOrder) { return Invoke<bool>(nameof(AddToPlayerScreen), ZOrder); }
        public UserWidgetExtension AddExtension(Object InExtensionType) { return Invoke<UserWidgetExtension>(nameof(AddExtension), InExtensionType); }
    }
    public class PanelWidget : Widget
    {
        public PanelWidget(nint addr) : base(addr) { }
        public Array<PanelSlot> Slots { get { return new Array<PanelSlot>(this[nameof(Slots)].Address); } }
        public bool RemoveChildAt(int Index) { return Invoke<bool>(nameof(RemoveChildAt), Index); }
        public bool RemoveChild(Widget Content) { return Invoke<bool>(nameof(RemoveChild), Content); }
        public bool HasChild(Widget Content) { return Invoke<bool>(nameof(HasChild), Content); }
        public bool HasAnyChildren() { return Invoke<bool>(nameof(HasAnyChildren)); }
        public int GetChildrenCount() { return Invoke<int>(nameof(GetChildrenCount)); }
        public int GetChildIndex(Widget Content) { return Invoke<int>(nameof(GetChildIndex), Content); }
        public Widget GetChildAt(int Index) { return Invoke<Widget>(nameof(GetChildAt), Index); }
        public Array<Widget> GetAllChildren() { return Invoke<Array<Widget>>(nameof(GetAllChildren)); }
        public void ClearChildren() { Invoke(nameof(ClearChildren)); }
        public PanelSlot AddChild(Widget Content) { return Invoke<PanelSlot>(nameof(AddChild), Content); }
    }
    public class WidgetSwitcher : PanelWidget
    {
        public WidgetSwitcher(nint addr) : base(addr) { }
        public int ActiveWidgetIndex { get { return this[nameof(ActiveWidgetIndex)].GetValue<int>(); } set { this[nameof(ActiveWidgetIndex)].SetValue<int>(value); } }
        public void SetActiveWidgetIndex(int Index) { Invoke(nameof(SetActiveWidgetIndex), Index); }
        public void SetActiveWidget(Widget Widget) { Invoke(nameof(SetActiveWidget), Widget); }
        public Widget GetWidgetAtIndex(int Index) { return Invoke<Widget>(nameof(GetWidgetAtIndex), Index); }
        public int GetNumWidgets() { return Invoke<int>(nameof(GetNumWidgets)); }
        public int GetActiveWidgetIndex() { return Invoke<int>(nameof(GetActiveWidgetIndex)); }
        public Widget GetActiveWidget() { return Invoke<Widget>(nameof(GetActiveWidget)); }
    }
    public class ContentWidget : PanelWidget
    {
        public ContentWidget(nint addr) : base(addr) { }
        public PanelSlot SetContent(Widget Content) { return Invoke<PanelSlot>(nameof(SetContent), Content); }
        public PanelSlot GetContentSlot() { return Invoke<PanelSlot>(nameof(GetContentSlot)); }
        public Widget GetContent() { return Invoke<Widget>(nameof(GetContent)); }
    }
    public class Border : ContentWidget
    {
        public Border(nint addr) : base(addr) { }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public bool bShowEffectWhenDisabled { get { return this[nameof(bShowEffectWhenDisabled)].Flag; } set { this[nameof(bShowEffectWhenDisabled)].Flag = value; } }
        public LinearColor ContentColorAndOpacity { get { return this[nameof(ContentColorAndOpacity)].As<LinearColor>(); } set { this["ContentColorAndOpacity"] = value; } }
        public Object ContentColorAndOpacityDelegate { get { return this[nameof(ContentColorAndOpacityDelegate)]; } set { this[nameof(ContentColorAndOpacityDelegate)] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public SlateBrush Background { get { return this[nameof(Background)].As<SlateBrush>(); } set { this["Background"] = value; } }
        public Object BackgroundDelegate { get { return this[nameof(BackgroundDelegate)]; } set { this[nameof(BackgroundDelegate)] = value; } }
        public LinearColor BrushColor { get { return this[nameof(BrushColor)].As<LinearColor>(); } set { this["BrushColor"] = value; } }
        public Object BrushColorDelegate { get { return this[nameof(BrushColorDelegate)]; } set { this[nameof(BrushColorDelegate)] = value; } }
        public Vector2D DesiredSizeScale { get { return this[nameof(DesiredSizeScale)].As<Vector2D>(); } set { this["DesiredSizeScale"] = value; } }
        public bool bFlipForRightToLeftFlowDirection { get { return this[nameof(bFlipForRightToLeftFlowDirection)].Flag; } set { this[nameof(bFlipForRightToLeftFlowDirection)].Flag = value; } }
        public Object OnMouseButtonDownEvent { get { return this[nameof(OnMouseButtonDownEvent)]; } set { this[nameof(OnMouseButtonDownEvent)] = value; } }
        public Object OnMouseButtonUpEvent { get { return this[nameof(OnMouseButtonUpEvent)]; } set { this[nameof(OnMouseButtonUpEvent)] = value; } }
        public Object OnMouseMoveEvent { get { return this[nameof(OnMouseMoveEvent)]; } set { this[nameof(OnMouseMoveEvent)] = value; } }
        public Object OnMouseDoubleClickEvent { get { return this[nameof(OnMouseDoubleClickEvent)]; } set { this[nameof(OnMouseDoubleClickEvent)] = value; } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetShowEffectWhenDisabled(bool bInShowEffectWhenDisabled) { Invoke(nameof(SetShowEffectWhenDisabled), bInShowEffectWhenDisabled); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public void SetDesiredSizeScale(Vector2D InScale) { Invoke(nameof(SetDesiredSizeScale), InScale); }
        public void SetContentColorAndOpacity(LinearColor InContentColorAndOpacity) { Invoke(nameof(SetContentColorAndOpacity), InContentColorAndOpacity); }
        public void SetBrushFromTexture(Texture2D Texture) { Invoke(nameof(SetBrushFromTexture), Texture); }
        public void SetBrushFromMaterial(MaterialInterface Material) { Invoke(nameof(SetBrushFromMaterial), Material); }
        public void SetBrushFromAsset(SlateBrushAsset Asset) { Invoke(nameof(SetBrushFromAsset), Asset); }
        public void SetBrushColor(LinearColor InBrushColor) { Invoke(nameof(SetBrushColor), InBrushColor); }
        public void SetBrush(SlateBrush InBrush) { Invoke(nameof(SetBrush), InBrush); }
        public MaterialInstanceDynamic GetDynamicMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetDynamicMaterial)); }
    }
    public class Button : ContentWidget
    {
        public Button(nint addr) : base(addr) { }
        public ButtonStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ButtonStyle>(); } set { this["WidgetStyle"] = value; } }
        public LinearColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<LinearColor>(); } set { this["ColorAndOpacity"] = value; } }
        public LinearColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<LinearColor>(); } set { this["BackgroundColor"] = value; } }
        public byte ClickMethod { get { return this[nameof(ClickMethod)].GetValue<byte>(); } set { this[nameof(ClickMethod)].SetValue<byte>(value); } }
        public byte TouchMethod { get { return this[nameof(TouchMethod)].GetValue<byte>(); } set { this[nameof(TouchMethod)].SetValue<byte>(value); } }
        public byte PressMethod { get { return this[nameof(PressMethod)].GetValue<byte>(); } set { this[nameof(PressMethod)].SetValue<byte>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public Object OnClicked { get { return this[nameof(OnClicked)]; } set { this[nameof(OnClicked)] = value; } }
        public Object OnPressed { get { return this[nameof(OnPressed)]; } set { this[nameof(OnPressed)] = value; } }
        public Object OnReleased { get { return this[nameof(OnReleased)]; } set { this[nameof(OnReleased)] = value; } }
        public Object OnHovered { get { return this[nameof(OnHovered)]; } set { this[nameof(OnHovered)] = value; } }
        public Object OnUnhovered { get { return this[nameof(OnUnhovered)]; } set { this[nameof(OnUnhovered)] = value; } }
        public void SetTouchMethod(byte InTouchMethod) { Invoke(nameof(SetTouchMethod), InTouchMethod); }
        public void SetStyle(ButtonStyle InStyle) { Invoke(nameof(SetStyle), InStyle); }
        public void SetPressMethod(byte InPressMethod) { Invoke(nameof(SetPressMethod), InPressMethod); }
        public void SetColorAndOpacity(LinearColor InColorAndOpacity) { Invoke(nameof(SetColorAndOpacity), InColorAndOpacity); }
        public void SetClickMethod(byte InClickMethod) { Invoke(nameof(SetClickMethod), InClickMethod); }
        public void SetBackgroundColor(LinearColor InBackgroundColor) { Invoke(nameof(SetBackgroundColor), InBackgroundColor); }
        public bool IsPressed() { return Invoke<bool>(nameof(IsPressed)); }
    }
    public class TextLayoutWidget : Widget
    {
        public TextLayoutWidget(nint addr) : base(addr) { }
        public ShapedTextOptions ShapedTextOptions { get { return this[nameof(ShapedTextOptions)].As<ShapedTextOptions>(); } set { this["ShapedTextOptions"] = value; } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
        public ETextWrappingPolicy WrappingPolicy { get { return (ETextWrappingPolicy)this[nameof(WrappingPolicy)].GetValue<int>(); } set { this[nameof(WrappingPolicy)].SetValue<int>((int)value); } }
        public bool AutoWrapText { get { return this[nameof(AutoWrapText)].Flag; } set { this[nameof(AutoWrapText)].Flag = value; } }
        public float WrapTextAt { get { return this[nameof(WrapTextAt)].GetValue<float>(); } set { this[nameof(WrapTextAt)].SetValue<float>(value); } }
        public Margin Margin { get { return this[nameof(Margin)].As<Margin>(); } set { this["Margin"] = value; } }
        public float LineHeightPercentage { get { return this[nameof(LineHeightPercentage)].GetValue<float>(); } set { this[nameof(LineHeightPercentage)].SetValue<float>(value); } }
        public void SetJustification(byte InJustification) { Invoke(nameof(SetJustification), InJustification); }
    }
    public class TextBlock : TextLayoutWidget
    {
        public TextBlock(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object TextDelegate { get { return this[nameof(TextDelegate)]; } set { this[nameof(TextDelegate)] = value; } }
        public SlateColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<SlateColor>(); } set { this["ColorAndOpacity"] = value; } }
        public Object ColorAndOpacityDelegate { get { return this[nameof(ColorAndOpacityDelegate)]; } set { this[nameof(ColorAndOpacityDelegate)] = value; } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public SlateBrush StrikeBrush { get { return this[nameof(StrikeBrush)].As<SlateBrush>(); } set { this["StrikeBrush"] = value; } }
        public Vector2D ShadowOffset { get { return this[nameof(ShadowOffset)].As<Vector2D>(); } set { this["ShadowOffset"] = value; } }
        public LinearColor ShadowColorAndOpacity { get { return this[nameof(ShadowColorAndOpacity)].As<LinearColor>(); } set { this["ShadowColorAndOpacity"] = value; } }
        public Object ShadowColorAndOpacityDelegate { get { return this[nameof(ShadowColorAndOpacityDelegate)]; } set { this[nameof(ShadowColorAndOpacityDelegate)] = value; } }
        public float MinDesiredWidth { get { return this[nameof(MinDesiredWidth)].GetValue<float>(); } set { this[nameof(MinDesiredWidth)].SetValue<float>(value); } }
        public bool bWrapWithInvalidationPanel { get { return this[nameof(bWrapWithInvalidationPanel)].Flag; } set { this[nameof(bWrapWithInvalidationPanel)].Flag = value; } }
        public ETextTransformPolicy TextTransformPolicy { get { return (ETextTransformPolicy)this[nameof(TextTransformPolicy)].GetValue<int>(); } set { this[nameof(TextTransformPolicy)].SetValue<int>((int)value); } }
        public ETextOverflowPolicy TextOverflowPolicy { get { return (ETextOverflowPolicy)this[nameof(TextOverflowPolicy)].GetValue<int>(); } set { this[nameof(TextOverflowPolicy)].SetValue<int>((int)value); } }
        public bool bSimpleTextMode { get { return this[nameof(bSimpleTextMode)].Flag; } set { this[nameof(bSimpleTextMode)].Flag = value; } }
        public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) { Invoke(nameof(SetTextTransformPolicy), InTransformPolicy); }
        public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) { Invoke(nameof(SetTextOverflowPolicy), InOverflowPolicy); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetStrikeBrush(SlateBrush InStrikeBrush) { Invoke(nameof(SetStrikeBrush), InStrikeBrush); }
        public void SetShadowOffset(Vector2D InShadowOffset) { Invoke(nameof(SetShadowOffset), InShadowOffset); }
        public void SetShadowColorAndOpacity(LinearColor InShadowColorAndOpacity) { Invoke(nameof(SetShadowColorAndOpacity), InShadowColorAndOpacity); }
        public void SetOpacity(float InOpacity) { Invoke(nameof(SetOpacity), InOpacity); }
        public void SetMinDesiredWidth(float InMinDesiredWidth) { Invoke(nameof(SetMinDesiredWidth), InMinDesiredWidth); }
        public void SetFontOutlineMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontOutlineMaterial), InMaterial); }
        public void SetFontMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontMaterial), InMaterial); }
        public void SetFont(SlateFontInfo InFontInfo) { Invoke(nameof(SetFont), InFontInfo); }
        public void SetColorAndOpacity(SlateColor InColorAndOpacity) { Invoke(nameof(SetColorAndOpacity), InColorAndOpacity); }
        public void SetAutoWrapText(bool InAutoTextWrap) { Invoke(nameof(SetAutoWrapText), InAutoTextWrap); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public MaterialInstanceDynamic GetDynamicOutlineMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetDynamicOutlineMaterial)); }
        public MaterialInstanceDynamic GetDynamicFontMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetDynamicFontMaterial)); }
    }
    public class ScrollBox : PanelWidget
    {
        public ScrollBox(nint addr) : base(addr) { }
        public ScrollBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ScrollBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public ScrollBarStyle WidgetBarStyle { get { return this[nameof(WidgetBarStyle)].As<ScrollBarStyle>(); } set { this["WidgetBarStyle"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public ESlateVisibility ScrollBarVisibility { get { return (ESlateVisibility)this[nameof(ScrollBarVisibility)].GetValue<int>(); } set { this[nameof(ScrollBarVisibility)].SetValue<int>((int)value); } }
        public EConsumeMouseWheel ConsumeMouseWheel { get { return (EConsumeMouseWheel)this[nameof(ConsumeMouseWheel)].GetValue<int>(); } set { this[nameof(ConsumeMouseWheel)].SetValue<int>((int)value); } }
        public Vector2D ScrollbarThickness { get { return this[nameof(ScrollbarThickness)].As<Vector2D>(); } set { this["ScrollbarThickness"] = value; } }
        public Margin ScrollbarPadding { get { return this[nameof(ScrollbarPadding)].As<Margin>(); } set { this["ScrollbarPadding"] = value; } }
        public bool AlwaysShowScrollbar { get { return this[nameof(AlwaysShowScrollbar)].Flag; } set { this[nameof(AlwaysShowScrollbar)].Flag = value; } }
        public bool AlwaysShowScrollbarTrack { get { return this[nameof(AlwaysShowScrollbarTrack)].Flag; } set { this[nameof(AlwaysShowScrollbarTrack)].Flag = value; } }
        public bool AllowOverscroll { get { return this[nameof(AllowOverscroll)].Flag; } set { this[nameof(AllowOverscroll)].Flag = value; } }
        public bool BackPadScrolling { get { return this[nameof(BackPadScrolling)].Flag; } set { this[nameof(BackPadScrolling)].Flag = value; } }
        public bool FrontPadScrolling { get { return this[nameof(FrontPadScrolling)].Flag; } set { this[nameof(FrontPadScrolling)].Flag = value; } }
        public bool bAnimateWheelScrolling { get { return this[nameof(bAnimateWheelScrolling)].Flag; } set { this[nameof(bAnimateWheelScrolling)].Flag = value; } }
        public EDescendantScrollDestination NavigationDestination { get { return (EDescendantScrollDestination)this[nameof(NavigationDestination)].GetValue<int>(); } set { this[nameof(NavigationDestination)].SetValue<int>((int)value); } }
        public float NavigationScrollPadding { get { return this[nameof(NavigationScrollPadding)].GetValue<float>(); } set { this[nameof(NavigationScrollPadding)].SetValue<float>(value); } }
        public EScrollWhenFocusChanges ScrollWhenFocusChanges { get { return (EScrollWhenFocusChanges)this[nameof(ScrollWhenFocusChanges)].GetValue<int>(); } set { this[nameof(ScrollWhenFocusChanges)].SetValue<int>((int)value); } }
        public bool bAllowRightClickDragScrolling { get { return this[nameof(bAllowRightClickDragScrolling)].Flag; } set { this[nameof(bAllowRightClickDragScrolling)].Flag = value; } }
        public float WheelScrollMultiplier { get { return this[nameof(WheelScrollMultiplier)].GetValue<float>(); } set { this[nameof(WheelScrollMultiplier)].SetValue<float>(value); } }
        public Object OnUserScrolled { get { return this[nameof(OnUserScrolled)]; } set { this[nameof(OnUserScrolled)] = value; } }
        public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) { Invoke(nameof(SetWheelScrollMultiplier), NewWheelScrollMultiplier); }
        public void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges) { Invoke(nameof(SetScrollWhenFocusChanges), NewScrollWhenFocusChanges); }
        public void SetScrollOffset(float NewScrollOffset) { Invoke(nameof(SetScrollOffset), NewScrollOffset); }
        public void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility) { Invoke(nameof(SetScrollBarVisibility), NewScrollBarVisibility); }
        public void SetScrollbarThickness(Vector2D NewScrollbarThickness) { Invoke(nameof(SetScrollbarThickness), NewScrollbarThickness); }
        public void SetScrollbarPadding(Margin NewScrollbarPadding) { Invoke(nameof(SetScrollbarPadding), NewScrollbarPadding); }
        public void SetOrientation(byte NewOrientation) { Invoke(nameof(SetOrientation), NewOrientation); }
        public void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination) { Invoke(nameof(SetNavigationDestination), NewNavigationDestination); }
        public void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel) { Invoke(nameof(SetConsumeMouseWheel), NewConsumeMouseWheel); }
        public void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling) { Invoke(nameof(SetAnimateWheelScrolling), bShouldAnimateWheelScrolling); }
        public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar) { Invoke(nameof(SetAlwaysShowScrollbar), NewAlwaysShowScrollbar); }
        public void SetAllowOverscroll(bool NewAllowOverscroll) { Invoke(nameof(SetAllowOverscroll), NewAllowOverscroll); }
        public void ScrollWidgetIntoView(Widget WidgetToFind, bool AnimateScroll, EDescendantScrollDestination ScrollDestination, float Padding) { Invoke(nameof(ScrollWidgetIntoView), WidgetToFind, AnimateScroll, ScrollDestination, Padding); }
        public void ScrollToStart() { Invoke(nameof(ScrollToStart)); }
        public void ScrollToEnd() { Invoke(nameof(ScrollToEnd)); }
        public float GetViewOffsetFraction() { return Invoke<float>(nameof(GetViewOffsetFraction)); }
        public float GetViewFraction() { return Invoke<float>(nameof(GetViewFraction)); }
        public float GetScrollOffsetOfEnd() { return Invoke<float>(nameof(GetScrollOffsetOfEnd)); }
        public float GetScrollOffset() { return Invoke<float>(nameof(GetScrollOffset)); }
        public void EndInertialScrolling() { Invoke(nameof(EndInertialScrolling)); }
    }
    public class Image : Widget
    {
        public Image(nint addr) : base(addr) { }
        public SlateBrush Brush { get { return this[nameof(Brush)].As<SlateBrush>(); } set { this["Brush"] = value; } }
        public Object BrushDelegate { get { return this[nameof(BrushDelegate)]; } set { this[nameof(BrushDelegate)] = value; } }
        public LinearColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<LinearColor>(); } set { this["ColorAndOpacity"] = value; } }
        public Object ColorAndOpacityDelegate { get { return this[nameof(ColorAndOpacityDelegate)]; } set { this[nameof(ColorAndOpacityDelegate)] = value; } }
        public bool bFlipForRightToLeftFlowDirection { get { return this[nameof(bFlipForRightToLeftFlowDirection)].Flag; } set { this[nameof(bFlipForRightToLeftFlowDirection)].Flag = value; } }
        public Object OnMouseButtonDownEvent { get { return this[nameof(OnMouseButtonDownEvent)]; } set { this[nameof(OnMouseButtonDownEvent)] = value; } }
        public void SetOpacity(float InOpacity) { Invoke(nameof(SetOpacity), InOpacity); }
        public void SetDesiredSizeOverride(Vector2D DesiredSize) { Invoke(nameof(SetDesiredSizeOverride), DesiredSize); }
        public void SetColorAndOpacity(LinearColor InColorAndOpacity) { Invoke(nameof(SetColorAndOpacity), InColorAndOpacity); }
        public void SetBrushTintColor(SlateColor TintColor) { Invoke(nameof(SetBrushTintColor), TintColor); }
        public void SetBrushResourceObject(Object ResourceObject) { Invoke(nameof(SetBrushResourceObject), ResourceObject); }
        public void SetBrushFromTextureDynamic(Texture2DDynamic Texture, bool bMatchSize) { Invoke(nameof(SetBrushFromTextureDynamic), Texture, bMatchSize); }
        public void SetBrushFromTexture(Texture2D Texture, bool bMatchSize) { Invoke(nameof(SetBrushFromTexture), Texture, bMatchSize); }
        public void SetBrushFromSoftTexture(Object SoftTexture, bool bMatchSize) { Invoke(nameof(SetBrushFromSoftTexture), SoftTexture, bMatchSize); }
        public void SetBrushFromSoftMaterial(Object SoftMaterial) { Invoke(nameof(SetBrushFromSoftMaterial), SoftMaterial); }
        public void SetBrushFromMaterial(MaterialInterface Material) { Invoke(nameof(SetBrushFromMaterial), Material); }
        public void SetBrushFromAtlasInterface(Object AtlasRegion, bool bMatchSize) { Invoke(nameof(SetBrushFromAtlasInterface), AtlasRegion, bMatchSize); }
        public void SetBrushFromAsset(SlateBrushAsset Asset) { Invoke(nameof(SetBrushFromAsset), Asset); }
        public void SetBrush(SlateBrush InBrush) { Invoke(nameof(SetBrush), InBrush); }
        public MaterialInstanceDynamic GetDynamicMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetDynamicMaterial)); }
    }
    public class ListViewBase : Widget
    {
        public ListViewBase(nint addr) : base(addr) { }
        public Object BP_OnEntryGenerated { get { return this[nameof(BP_OnEntryGenerated)]; } set { this[nameof(BP_OnEntryGenerated)] = value; } }
        public Object EntryWidgetClass { get { return this[nameof(EntryWidgetClass)]; } set { this[nameof(EntryWidgetClass)] = value; } }
        public float WheelScrollMultiplier { get { return this[nameof(WheelScrollMultiplier)].GetValue<float>(); } set { this[nameof(WheelScrollMultiplier)].SetValue<float>(value); } }
        public bool bEnableScrollAnimation { get { return this[nameof(bEnableScrollAnimation)].Flag; } set { this[nameof(bEnableScrollAnimation)].Flag = value; } }
        public bool AllowOverscroll { get { return this[nameof(AllowOverscroll)].Flag; } set { this[nameof(AllowOverscroll)].Flag = value; } }
        public bool bEnableRightClickScrolling { get { return this[nameof(bEnableRightClickScrolling)].Flag; } set { this[nameof(bEnableRightClickScrolling)].Flag = value; } }
        public bool bEnableFixedLineOffset { get { return this[nameof(bEnableFixedLineOffset)].Flag; } set { this[nameof(bEnableFixedLineOffset)].Flag = value; } }
        public float FixedLineScrollOffset { get { return this[nameof(FixedLineScrollOffset)].GetValue<float>(); } set { this[nameof(FixedLineScrollOffset)].SetValue<float>(value); } }
        public bool bAllowDragging { get { return this[nameof(bAllowDragging)].Flag; } set { this[nameof(bAllowDragging)].Flag = value; } }
        public Object BP_OnEntryReleased { get { return this[nameof(BP_OnEntryReleased)]; } set { this[nameof(BP_OnEntryReleased)] = value; } }
        public UserWidgetPool EntryWidgetPool { get { return this[nameof(EntryWidgetPool)].As<UserWidgetPool>(); } set { this["EntryWidgetPool"] = value; } }
        public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) { Invoke(nameof(SetWheelScrollMultiplier), NewWheelScrollMultiplier); }
        public void SetScrollOffset(float InScrollOffset) { Invoke(nameof(SetScrollOffset), InScrollOffset); }
        public void SetScrollBarVisibility(ESlateVisibility InVisibility) { Invoke(nameof(SetScrollBarVisibility), InVisibility); }
        public void ScrollToTop() { Invoke(nameof(ScrollToTop)); }
        public void ScrollToBottom() { Invoke(nameof(ScrollToBottom)); }
        public void RequestRefresh() { Invoke(nameof(RequestRefresh)); }
        public void RegenerateAllEntries() { Invoke(nameof(RegenerateAllEntries)); }
        public float GetScrollOffset() { return Invoke<float>(nameof(GetScrollOffset)); }
        public Array<UserWidget> GetDisplayedEntryWidgets() { return Invoke<Array<UserWidget>>(nameof(GetDisplayedEntryWidgets)); }
    }
    public class ListView : ListViewBase
    {
        public ListView(nint addr) : base(addr) { }
        public TableViewStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<TableViewStyle>(); } set { this["WidgetStyle"] = value; } }
        public ScrollBarStyle ScrollBarStyle { get { return this[nameof(ScrollBarStyle)].As<ScrollBarStyle>(); } set { this["ScrollBarStyle"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public byte SelectionMode { get { return this[nameof(SelectionMode)].GetValue<byte>(); } set { this[nameof(SelectionMode)].SetValue<byte>(value); } }
        public EConsumeMouseWheel ConsumeMouseWheel { get { return (EConsumeMouseWheel)this[nameof(ConsumeMouseWheel)].GetValue<int>(); } set { this[nameof(ConsumeMouseWheel)].SetValue<int>((int)value); } }
        public bool bClearSelectionOnClick { get { return this[nameof(bClearSelectionOnClick)].Flag; } set { this[nameof(bClearSelectionOnClick)].Flag = value; } }
        public bool bIsFocusable { get { return this[nameof(bIsFocusable)].Flag; } set { this[nameof(bIsFocusable)].Flag = value; } }
        public float EntrySpacing { get { return this[nameof(EntrySpacing)].GetValue<float>(); } set { this[nameof(EntrySpacing)].SetValue<float>(value); } }
        public bool bReturnFocusToSelection { get { return this[nameof(bReturnFocusToSelection)].Flag; } set { this[nameof(bReturnFocusToSelection)].Flag = value; } }
        public Array<Object> ListItems { get { return new Array<Object>(this[nameof(ListItems)].Address); } }
        public Object BP_OnEntryInitialized { get { return this[nameof(BP_OnEntryInitialized)]; } set { this[nameof(BP_OnEntryInitialized)] = value; } }
        public Object BP_OnItemClicked { get { return this[nameof(BP_OnItemClicked)]; } set { this[nameof(BP_OnItemClicked)] = value; } }
        public Object BP_OnItemDoubleClicked { get { return this[nameof(BP_OnItemDoubleClicked)]; } set { this[nameof(BP_OnItemDoubleClicked)] = value; } }
        public Object BP_OnItemIsHoveredChanged { get { return this[nameof(BP_OnItemIsHoveredChanged)]; } set { this[nameof(BP_OnItemIsHoveredChanged)] = value; } }
        public Object BP_OnItemSelectionChanged { get { return this[nameof(BP_OnItemSelectionChanged)]; } set { this[nameof(BP_OnItemSelectionChanged)] = value; } }
        public Object BP_OnItemScrolledIntoView { get { return this[nameof(BP_OnItemScrolledIntoView)]; } set { this[nameof(BP_OnItemScrolledIntoView)] = value; } }
        public void SetSelectionMode(byte SelectionMode) { Invoke(nameof(SetSelectionMode), SelectionMode); }
        public void SetSelectedIndex(int Index) { Invoke(nameof(SetSelectedIndex), Index); }
        public void ScrollIndexIntoView(int Index) { Invoke(nameof(ScrollIndexIntoView), Index); }
        public void RemoveItem(Object Item) { Invoke(nameof(RemoveItem), Item); }
        public void OnListItemOuterEndPlayed(Actor ItemOuter, byte EndPlayReason) { Invoke(nameof(OnListItemOuterEndPlayed), ItemOuter, EndPlayReason); }
        public void OnListItemEndPlayed(Actor Item, byte EndPlayReason) { Invoke(nameof(OnListItemEndPlayed), Item, EndPlayReason); }
        public void NavigateToIndex(int Index) { Invoke(nameof(NavigateToIndex), Index); }
        public bool IsRefreshPending() { return Invoke<bool>(nameof(IsRefreshPending)); }
        public int GetNumItems() { return Invoke<int>(nameof(GetNumItems)); }
        public Array<Object> GetListItems() { return Invoke<Array<Object>>(nameof(GetListItems)); }
        public Object GetItemAt(int Index) { return Invoke<Object>(nameof(GetItemAt), Index); }
        public int GetIndexForItem(Object Item) { return Invoke<int>(nameof(GetIndexForItem), Item); }
        public void ClearListItems() { Invoke(nameof(ClearListItems)); }
        public void BP_SetSelectedItem(Object Item) { Invoke(nameof(BP_SetSelectedItem), Item); }
        public void BP_SetListItems(Array<Object> InListItems) { Invoke(nameof(BP_SetListItems), InListItems); }
        public void BP_SetItemSelection(Object Item, bool bSelected) { Invoke(nameof(BP_SetItemSelection), Item, bSelected); }
        public void BP_ScrollItemIntoView(Object Item) { Invoke(nameof(BP_ScrollItemIntoView), Item); }
        public void BP_NavigateToItem(Object Item) { Invoke(nameof(BP_NavigateToItem), Item); }
        public bool BP_IsItemVisible(Object Item) { return Invoke<bool>(nameof(BP_IsItemVisible), Item); }
        public bool BP_GetSelectedItems(Array<Object> Items) { return Invoke<bool>(nameof(BP_GetSelectedItems), Items); }
        public Object BP_GetSelectedItem() { return Invoke<Object>(nameof(BP_GetSelectedItem)); }
        public int BP_GetNumItemsSelected() { return Invoke<int>(nameof(BP_GetNumItemsSelected)); }
        public void BP_ClearSelection() { Invoke(nameof(BP_ClearSelection)); }
        public void BP_CancelScrollIntoView() { Invoke(nameof(BP_CancelScrollIntoView)); }
        public void AddItem(Object Item) { Invoke(nameof(AddItem), Item); }
    }
    public class PanelSlot : Visual
    {
        public PanelSlot(nint addr) : base(addr) { }
        public PanelWidget Parent { get { return this[nameof(Parent)].As<PanelWidget>(); } set { this["Parent"] = value; } }
        public Widget Content { get { return this[nameof(Content)].As<Widget>(); } set { this["Content"] = value; } }
    }
    public class RichTextBlock : TextLayoutWidget
    {
        public RichTextBlock(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public DataTable TextStyleSet { get { return this[nameof(TextStyleSet)].As<DataTable>(); } set { this["TextStyleSet"] = value; } }
        public Array<Object> DecoratorClasses { get { return new Array<Object>(this[nameof(DecoratorClasses)].Address); } }
        public bool bOverrideDefaultStyle { get { return this[nameof(bOverrideDefaultStyle)].Flag; } set { this[nameof(bOverrideDefaultStyle)].Flag = value; } }
        public TextBlockStyle DefaultTextStyleOverride { get { return this[nameof(DefaultTextStyleOverride)].As<TextBlockStyle>(); } set { this["DefaultTextStyleOverride"] = value; } }
        public float MinDesiredWidth { get { return this[nameof(MinDesiredWidth)].GetValue<float>(); } set { this[nameof(MinDesiredWidth)].SetValue<float>(value); } }
        public ETextTransformPolicy TextTransformPolicy { get { return (ETextTransformPolicy)this[nameof(TextTransformPolicy)].GetValue<int>(); } set { this[nameof(TextTransformPolicy)].SetValue<int>((int)value); } }
        public ETextOverflowPolicy TextOverflowPolicy { get { return (ETextOverflowPolicy)this[nameof(TextOverflowPolicy)].GetValue<int>(); } set { this[nameof(TextOverflowPolicy)].SetValue<int>((int)value); } }
        public TextBlockStyle DefaultTextStyle { get { return this[nameof(DefaultTextStyle)].As<TextBlockStyle>(); } set { this["DefaultTextStyle"] = value; } }
        public Array<RichTextBlockDecorator> InstanceDecorators { get { return new Array<RichTextBlockDecorator>(this[nameof(InstanceDecorators)].Address); } }
        public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) { Invoke(nameof(SetTextTransformPolicy), InTransformPolicy); }
        public void SetTextStyleSet(DataTable NewTextStyleSet) { Invoke(nameof(SetTextStyleSet), NewTextStyleSet); }
        public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) { Invoke(nameof(SetTextOverflowPolicy), InOverflowPolicy); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetMinDesiredWidth(float InMinDesiredWidth) { Invoke(nameof(SetMinDesiredWidth), InMinDesiredWidth); }
        public void SetDefaultTextStyle(TextBlockStyle InDefaultTextStyle) { Invoke(nameof(SetDefaultTextStyle), InDefaultTextStyle); }
        public void SetDefaultStrikeBrush(SlateBrush InStrikeBrush) { Invoke(nameof(SetDefaultStrikeBrush), InStrikeBrush); }
        public void SetDefaultShadowOffset(Vector2D InShadowOffset) { Invoke(nameof(SetDefaultShadowOffset), InShadowOffset); }
        public void SetDefaultShadowColorAndOpacity(LinearColor InShadowColorAndOpacity) { Invoke(nameof(SetDefaultShadowColorAndOpacity), InShadowColorAndOpacity); }
        public void SetDefaultMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetDefaultMaterial), InMaterial); }
        public void SetDefaultFont(SlateFontInfo InFontInfo) { Invoke(nameof(SetDefaultFont), InFontInfo); }
        public void SetDefaultColorAndOpacity(SlateColor InColorAndOpacity) { Invoke(nameof(SetDefaultColorAndOpacity), InColorAndOpacity); }
        public void SetDecorators(Array<Object> InDecoratorClasses) { Invoke(nameof(SetDecorators), InDecoratorClasses); }
        public void SetAutoWrapText(bool InAutoTextWrap) { Invoke(nameof(SetAutoWrapText), InAutoTextWrap); }
        public void RefreshTextLayout() { Invoke(nameof(RefreshTextLayout)); }
        public DataTable GetTextStyleSet() { return Invoke<DataTable>(nameof(GetTextStyleSet)); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public MaterialInstanceDynamic GetDefaultDynamicMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetDefaultDynamicMaterial)); }
        public RichTextBlockDecorator GetDecoratorByClass(Object DecoratorClass) { return Invoke<RichTextBlockDecorator>(nameof(GetDecoratorByClass), DecoratorClass); }
        public void ClearAllDefaultStyleOverrides() { Invoke(nameof(ClearAllDefaultStyleOverrides)); }
    }
    public class TileView : ListView
    {
        public TileView(nint addr) : base(addr) { }
        public float EntryHeight { get { return this[nameof(EntryHeight)].GetValue<float>(); } set { this[nameof(EntryHeight)].SetValue<float>(value); } }
        public float EntryWidth { get { return this[nameof(EntryWidth)].GetValue<float>(); } set { this[nameof(EntryWidth)].SetValue<float>(value); } }
        public EListItemAlignment TileAlignment { get { return (EListItemAlignment)this[nameof(TileAlignment)].GetValue<int>(); } set { this[nameof(TileAlignment)].SetValue<int>((int)value); } }
        public bool bWrapHorizontalNavigation { get { return this[nameof(bWrapHorizontalNavigation)].Flag; } set { this[nameof(bWrapHorizontalNavigation)].Flag = value; } }
        public void SetEntryWidth(float NewWidth) { Invoke(nameof(SetEntryWidth), NewWidth); }
        public void SetEntryHeight(float NewHeight) { Invoke(nameof(SetEntryHeight), NewHeight); }
        public float GetEntryWidth() { return Invoke<float>(nameof(GetEntryWidth)); }
        public float GetEntryHeight() { return Invoke<float>(nameof(GetEntryHeight)); }
    }
    public class TreeView : ListView
    {
        public TreeView(nint addr) : base(addr) { }
        public Object BP_OnGetItemChildren { get { return this[nameof(BP_OnGetItemChildren)]; } set { this[nameof(BP_OnGetItemChildren)] = value; } }
        public Object BP_OnItemExpansionChanged { get { return this[nameof(BP_OnItemExpansionChanged)]; } set { this[nameof(BP_OnItemExpansionChanged)] = value; } }
        public void SetItemExpansion(Object Item, bool bExpandItem) { Invoke(nameof(SetItemExpansion), Item, bExpandItem); }
        public void ExpandAll() { Invoke(nameof(ExpandAll)); }
        public void CollapseAll() { Invoke(nameof(CollapseAll)); }
    }
    public class Overlay : PanelWidget
    {
        public Overlay(nint addr) : base(addr) { }
        public OverlaySlot AddChildToOverlay(Widget Content) { return Invoke<OverlaySlot>(nameof(AddChildToOverlay), Content); }
    }
    public class OverlaySlot : PanelSlot
    {
        public OverlaySlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class SizeBox : ContentWidget
    {
        public SizeBox(nint addr) : base(addr) { }
        public float WidthOverride { get { return this[nameof(WidthOverride)].GetValue<float>(); } set { this[nameof(WidthOverride)].SetValue<float>(value); } }
        public float HeightOverride { get { return this[nameof(HeightOverride)].GetValue<float>(); } set { this[nameof(HeightOverride)].SetValue<float>(value); } }
        public float MinDesiredWidth { get { return this[nameof(MinDesiredWidth)].GetValue<float>(); } set { this[nameof(MinDesiredWidth)].SetValue<float>(value); } }
        public float MinDesiredHeight { get { return this[nameof(MinDesiredHeight)].GetValue<float>(); } set { this[nameof(MinDesiredHeight)].SetValue<float>(value); } }
        public float MaxDesiredWidth { get { return this[nameof(MaxDesiredWidth)].GetValue<float>(); } set { this[nameof(MaxDesiredWidth)].SetValue<float>(value); } }
        public float MaxDesiredHeight { get { return this[nameof(MaxDesiredHeight)].GetValue<float>(); } set { this[nameof(MaxDesiredHeight)].SetValue<float>(value); } }
        public float MinAspectRatio { get { return this[nameof(MinAspectRatio)].GetValue<float>(); } set { this[nameof(MinAspectRatio)].SetValue<float>(value); } }
        public float MaxAspectRatio { get { return this[nameof(MaxAspectRatio)].GetValue<float>(); } set { this[nameof(MaxAspectRatio)].SetValue<float>(value); } }
        public bool bOverride_WidthOverride { get { return this[nameof(bOverride_WidthOverride)].Flag; } set { this[nameof(bOverride_WidthOverride)].Flag = value; } }
        public bool bOverride_HeightOverride { get { return this[nameof(bOverride_HeightOverride)].Flag; } set { this[nameof(bOverride_HeightOverride)].Flag = value; } }
        public bool bOverride_MinDesiredWidth { get { return this[nameof(bOverride_MinDesiredWidth)].Flag; } set { this[nameof(bOverride_MinDesiredWidth)].Flag = value; } }
        public bool bOverride_MinDesiredHeight { get { return this[nameof(bOverride_MinDesiredHeight)].Flag; } set { this[nameof(bOverride_MinDesiredHeight)].Flag = value; } }
        public bool bOverride_MaxDesiredWidth { get { return this[nameof(bOverride_MaxDesiredWidth)].Flag; } set { this[nameof(bOverride_MaxDesiredWidth)].Flag = value; } }
        public bool bOverride_MaxDesiredHeight { get { return this[nameof(bOverride_MaxDesiredHeight)].Flag; } set { this[nameof(bOverride_MaxDesiredHeight)].Flag = value; } }
        public bool bOverride_MinAspectRatio { get { return this[nameof(bOverride_MinAspectRatio)].Flag; } set { this[nameof(bOverride_MinAspectRatio)].Flag = value; } }
        public bool bOverride_MaxAspectRatio { get { return this[nameof(bOverride_MaxAspectRatio)].Flag; } set { this[nameof(bOverride_MaxAspectRatio)].Flag = value; } }
        public void SetWidthOverride(float InWidthOverride) { Invoke(nameof(SetWidthOverride), InWidthOverride); }
        public void SetMinDesiredWidth(float InMinDesiredWidth) { Invoke(nameof(SetMinDesiredWidth), InMinDesiredWidth); }
        public void SetMinDesiredHeight(float InMinDesiredHeight) { Invoke(nameof(SetMinDesiredHeight), InMinDesiredHeight); }
        public void SetMinAspectRatio(float InMinAspectRatio) { Invoke(nameof(SetMinAspectRatio), InMinAspectRatio); }
        public void SetMaxDesiredWidth(float InMaxDesiredWidth) { Invoke(nameof(SetMaxDesiredWidth), InMaxDesiredWidth); }
        public void SetMaxDesiredHeight(float InMaxDesiredHeight) { Invoke(nameof(SetMaxDesiredHeight), InMaxDesiredHeight); }
        public void SetMaxAspectRatio(float InMaxAspectRatio) { Invoke(nameof(SetMaxAspectRatio), InMaxAspectRatio); }
        public void SetHeightOverride(float InHeightOverride) { Invoke(nameof(SetHeightOverride), InHeightOverride); }
        public void ClearWidthOverride() { Invoke(nameof(ClearWidthOverride)); }
        public void ClearMinDesiredWidth() { Invoke(nameof(ClearMinDesiredWidth)); }
        public void ClearMinDesiredHeight() { Invoke(nameof(ClearMinDesiredHeight)); }
        public void ClearMinAspectRatio() { Invoke(nameof(ClearMinAspectRatio)); }
        public void ClearMaxDesiredWidth() { Invoke(nameof(ClearMaxDesiredWidth)); }
        public void ClearMaxDesiredHeight() { Invoke(nameof(ClearMaxDesiredHeight)); }
        public void ClearMaxAspectRatio() { Invoke(nameof(ClearMaxAspectRatio)); }
        public void ClearHeightOverride() { Invoke(nameof(ClearHeightOverride)); }
    }
    public class DynamicEntryBoxBase : Widget
    {
        public DynamicEntryBoxBase(nint addr) : base(addr) { }
        public EDynamicBoxType EntryBoxType { get { return (EDynamicBoxType)this[nameof(EntryBoxType)].GetValue<int>(); } set { this[nameof(EntryBoxType)].SetValue<int>((int)value); } }
        public Vector2D EntrySpacing { get { return this[nameof(EntrySpacing)].As<Vector2D>(); } set { this["EntrySpacing"] = value; } }
        public Array<Vector2D> SpacingPattern { get { return new Array<Vector2D>(this[nameof(SpacingPattern)].Address); } }
        public SlateChildSize EntrySizeRule { get { return this[nameof(EntrySizeRule)].As<SlateChildSize>(); } set { this["EntrySizeRule"] = value; } }
        public byte EntryHorizontalAlignment { get { return this[nameof(EntryHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(EntryHorizontalAlignment)].SetValue<byte>(value); } }
        public byte EntryVerticalAlignment { get { return this[nameof(EntryVerticalAlignment)].GetValue<byte>(); } set { this[nameof(EntryVerticalAlignment)].SetValue<byte>(value); } }
        public int MaxElementSize { get { return this[nameof(MaxElementSize)].GetValue<int>(); } set { this[nameof(MaxElementSize)].SetValue<int>(value); } }
        public RadialBoxSettings RadialBoxSettings { get { return this[nameof(RadialBoxSettings)].As<RadialBoxSettings>(); } set { this["RadialBoxSettings"] = value; } }
        public UserWidgetPool EntryWidgetPool { get { return this[nameof(EntryWidgetPool)].As<UserWidgetPool>(); } set { this["EntryWidgetPool"] = value; } }
        public void SetRadialSettings(RadialBoxSettings InSettings) { Invoke(nameof(SetRadialSettings), InSettings); }
        public void SetEntrySpacing(Vector2D InEntrySpacing) { Invoke(nameof(SetEntrySpacing), InEntrySpacing); }
        public int GetNumEntries() { return Invoke<int>(nameof(GetNumEntries)); }
        public Array<UserWidget> GetAllEntries() { return Invoke<Array<UserWidget>>(nameof(GetAllEntries)); }
    }
    public class ProgressBar : Widget
    {
        public ProgressBar(nint addr) : base(addr) { }
        public ProgressBarStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ProgressBarStyle>(); } set { this["WidgetStyle"] = value; } }
        public float Percent { get { return this[nameof(Percent)].GetValue<float>(); } set { this[nameof(Percent)].SetValue<float>(value); } }
        public byte BarFillType { get { return this[nameof(BarFillType)].GetValue<byte>(); } set { this[nameof(BarFillType)].SetValue<byte>(value); } }
        public byte BarFillStyle { get { return this[nameof(BarFillStyle)].GetValue<byte>(); } set { this[nameof(BarFillStyle)].SetValue<byte>(value); } }
        public bool bIsMarquee { get { return this[nameof(bIsMarquee)].Flag; } set { this[nameof(bIsMarquee)].Flag = value; } }
        public Vector2D BorderPadding { get { return this[nameof(BorderPadding)].As<Vector2D>(); } set { this["BorderPadding"] = value; } }
        public Object PercentDelegate { get { return this[nameof(PercentDelegate)]; } set { this[nameof(PercentDelegate)] = value; } }
        public LinearColor FillColorAndOpacity { get { return this[nameof(FillColorAndOpacity)].As<LinearColor>(); } set { this["FillColorAndOpacity"] = value; } }
        public Object FillColorAndOpacityDelegate { get { return this[nameof(FillColorAndOpacityDelegate)]; } set { this[nameof(FillColorAndOpacityDelegate)] = value; } }
        public void SetPercent(float InPercent) { Invoke(nameof(SetPercent), InPercent); }
        public void SetIsMarquee(bool InbIsMarquee) { Invoke(nameof(SetIsMarquee), InbIsMarquee); }
        public void SetFillColorAndOpacity(LinearColor inColor) { Invoke(nameof(SetFillColorAndOpacity), inColor); }
    }
    public class RetainerBox : ContentWidget
    {
        public RetainerBox(nint addr) : base(addr) { }
        public bool bRetainRender { get { return this[nameof(bRetainRender)].Flag; } set { this[nameof(bRetainRender)].Flag = value; } }
        public bool RenderOnInvalidation { get { return this[nameof(RenderOnInvalidation)].Flag; } set { this[nameof(RenderOnInvalidation)].Flag = value; } }
        public bool RenderOnPhase { get { return this[nameof(RenderOnPhase)].Flag; } set { this[nameof(RenderOnPhase)].Flag = value; } }
        public int Phase { get { return this[nameof(Phase)].GetValue<int>(); } set { this[nameof(Phase)].SetValue<int>(value); } }
        public int PhaseCount { get { return this[nameof(PhaseCount)].GetValue<int>(); } set { this[nameof(PhaseCount)].SetValue<int>(value); } }
        public MaterialInterface EffectMaterial { get { return this[nameof(EffectMaterial)].As<MaterialInterface>(); } set { this["EffectMaterial"] = value; } }
        public Object TextureParameter { get { return this[nameof(TextureParameter)]; } set { this[nameof(TextureParameter)] = value; } }
        public void SetTextureParameter(Object TextureParameter) { Invoke(nameof(SetTextureParameter), TextureParameter); }
        public void SetRetainRendering(bool bInRetainRendering) { Invoke(nameof(SetRetainRendering), bInRetainRendering); }
        public void SetRenderingPhase(int RenderPhase, int TotalPhases) { Invoke(nameof(SetRenderingPhase), RenderPhase, TotalPhases); }
        public void SetEffectMaterial(MaterialInterface EffectMaterial) { Invoke(nameof(SetEffectMaterial), EffectMaterial); }
        public void RequestRender() { Invoke(nameof(RequestRender)); }
        public MaterialInstanceDynamic GetEffectMaterial() { return Invoke<MaterialInstanceDynamic>(nameof(GetEffectMaterial)); }
    }
    public class RichTextBlockDecorator : Object
    {
        public RichTextBlockDecorator(nint addr) : base(addr) { }
    }
    public class RichTextBlockImageDecorator : RichTextBlockDecorator
    {
        public RichTextBlockImageDecorator(nint addr) : base(addr) { }
        public DataTable ImageSet { get { return this[nameof(ImageSet)].As<DataTable>(); } set { this["ImageSet"] = value; } }
    }
    public class NotifyFieldValueChanged : Interface
    {
        public NotifyFieldValueChanged(nint addr) : base(addr) { }
    }
    public class ListViewDesignerPreviewItem : Object
    {
        public ListViewDesignerPreviewItem(nint addr) : base(addr) { }
    }
    public class SlateAccessibleWidgetData : Object
    {
        public SlateAccessibleWidgetData(nint addr) : base(addr) { }
        public bool bCanChildrenBeAccessible { get { return this[nameof(bCanChildrenBeAccessible)].Flag; } set { this[nameof(bCanChildrenBeAccessible)].Flag = value; } }
        public ESlateAccessibleBehavior AccessibleBehavior { get { return (ESlateAccessibleBehavior)this[nameof(AccessibleBehavior)].GetValue<int>(); } set { this[nameof(AccessibleBehavior)].SetValue<int>((int)value); } }
        public ESlateAccessibleBehavior AccessibleSummaryBehavior { get { return (ESlateAccessibleBehavior)this[nameof(AccessibleSummaryBehavior)].GetValue<int>(); } set { this[nameof(AccessibleSummaryBehavior)].SetValue<int>((int)value); } }
        public Object AccessibleText { get { return this[nameof(AccessibleText)]; } set { this[nameof(AccessibleText)] = value; } }
        public Object AccessibleTextDelegate { get { return this[nameof(AccessibleTextDelegate)]; } set { this[nameof(AccessibleTextDelegate)] = value; } }
        public Object AccessibleSummaryText { get { return this[nameof(AccessibleSummaryText)]; } set { this[nameof(AccessibleSummaryText)] = value; } }
        public Object AccessibleSummaryTextDelegate { get { return this[nameof(AccessibleSummaryTextDelegate)]; } set { this[nameof(AccessibleSummaryTextDelegate)] = value; } }
    }
    public class UserWidgetBlueprint : Blueprint
    {
        public UserWidgetBlueprint(nint addr) : base(addr) { }
    }
    public class UserWidgetExtension : Object
    {
        public UserWidgetExtension(nint addr) : base(addr) { }
    }
    public class WidgetBlueprintGeneratedClassExtension : Object
    {
        public WidgetBlueprintGeneratedClassExtension(nint addr) : base(addr) { }
    }
    public class WidgetFieldNotificationExtension : UserWidgetExtension
    {
        public WidgetFieldNotificationExtension(nint addr) : base(addr) { }
    }
    public class WidgetNavigation : Object
    {
        public WidgetNavigation(nint addr) : base(addr) { }
        public WidgetNavigationData Up { get { return this[nameof(Up)].As<WidgetNavigationData>(); } set { this["Up"] = value; } }
        public WidgetNavigationData Down { get { return this[nameof(Down)].As<WidgetNavigationData>(); } set { this["Down"] = value; } }
        public WidgetNavigationData Left { get { return this[nameof(Left)].As<WidgetNavigationData>(); } set { this["Left"] = value; } }
        public WidgetNavigationData Right { get { return this[nameof(Right)].As<WidgetNavigationData>(); } set { this["Right"] = value; } }
        public WidgetNavigationData Next { get { return this[nameof(Next)].As<WidgetNavigationData>(); } set { this["Next"] = value; } }
        public WidgetNavigationData Previous { get { return this[nameof(Previous)].As<WidgetNavigationData>(); } set { this["Previous"] = value; } }
    }
    public class MovieScene2DTransformPropertySystem : MovieScenePropertySystem
    {
        public MovieScene2DTransformPropertySystem(nint addr) : base(addr) { }
    }
    public class MovieScene2DTransformSection : MovieSceneSection
    {
        public MovieScene2DTransformSection(nint addr) : base(addr) { }
        public MovieScene2DTransformMask TransformMask { get { return this[nameof(TransformMask)].As<MovieScene2DTransformMask>(); } set { this["TransformMask"] = value; } }
        public MovieSceneFloatChannel Translation { get { return this[nameof(Translation)].As<MovieSceneFloatChannel>(); } set { this["Translation"] = value; } }
        public MovieSceneFloatChannel Rotation { get { return this[nameof(Rotation)].As<MovieSceneFloatChannel>(); } set { this["Rotation"] = value; } }
        public MovieSceneFloatChannel Scale { get { return this[nameof(Scale)].As<MovieSceneFloatChannel>(); } set { this["Scale"] = value; } }
        public MovieSceneFloatChannel Shear { get { return this[nameof(Shear)].As<MovieSceneFloatChannel>(); } set { this["Shear"] = value; } }
    }
    public class MovieScene2DTransformTrack : MovieScenePropertyTrack
    {
        public MovieScene2DTransformTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneMarginPropertySystem : MovieScenePropertySystem
    {
        public MovieSceneMarginPropertySystem(nint addr) : base(addr) { }
    }
    public class MovieSceneMarginSection : MovieSceneSection
    {
        public MovieSceneMarginSection(nint addr) : base(addr) { }
        public MovieSceneFloatChannel TopCurve { get { return this[nameof(TopCurve)].As<MovieSceneFloatChannel>(); } set { this["TopCurve"] = value; } }
        public MovieSceneFloatChannel LeftCurve { get { return this[nameof(LeftCurve)].As<MovieSceneFloatChannel>(); } set { this["LeftCurve"] = value; } }
        public MovieSceneFloatChannel RightCurve { get { return this[nameof(RightCurve)].As<MovieSceneFloatChannel>(); } set { this["RightCurve"] = value; } }
        public MovieSceneFloatChannel BottomCurve { get { return this[nameof(BottomCurve)].As<MovieSceneFloatChannel>(); } set { this["BottomCurve"] = value; } }
    }
    public class MovieSceneMarginTrack : MovieScenePropertyTrack
    {
        public MovieSceneMarginTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneWidgetMaterialSystem : MovieSceneEntitySystem
    {
        public MovieSceneWidgetMaterialSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneWidgetMaterialTrack : MovieSceneMaterialTrack
    {
        public MovieSceneWidgetMaterialTrack(nint addr) : base(addr) { }
        public Array<Object> BrushPropertyNamePath { get { return new Array<Object>(this[nameof(BrushPropertyNamePath)].Address); } }
        public Object TrackName { get { return this[nameof(TrackName)]; } set { this[nameof(TrackName)] = value; } }
    }
    public class UMGSequencePlayer : Object
    {
        public UMGSequencePlayer(nint addr) : base(addr) { }
        public WidgetAnimation Animation { get { return this[nameof(Animation)].As<WidgetAnimation>(); } set { this["Animation"] = value; } }
        public MovieSceneRootEvaluationTemplateInstance RootTemplateInstance { get { return this[nameof(RootTemplateInstance)].As<MovieSceneRootEvaluationTemplateInstance>(); } set { this["RootTemplateInstance"] = value; } }
        public void SetUserTag(Object InUserTag) { Invoke(nameof(SetUserTag), InUserTag); }
        public Object GetUserTag() { return Invoke<Object>(nameof(GetUserTag)); }
    }
    public class UMGSequenceTickManager : Object
    {
        public UMGSequenceTickManager(nint addr) : base(addr) { }
        public Object WeakUserWidgetData { get { return this[nameof(WeakUserWidgetData)]; } set { this[nameof(WeakUserWidgetData)] = value; } }
        public MovieSceneEntitySystemLinker Linker { get { return this[nameof(Linker)].As<MovieSceneEntitySystemLinker>(); } set { this["Linker"] = value; } }
    }
    public class WidgetAnimation : MovieSceneSequence
    {
        public WidgetAnimation(nint addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public Array<WidgetAnimationBinding> AnimationBindings { get { return new Array<WidgetAnimationBinding>(this[nameof(AnimationBindings)].Address); } }
        public bool bLegacyFinishOnStop { get { return this[nameof(bLegacyFinishOnStop)].Flag; } set { this[nameof(bLegacyFinishOnStop)].Flag = value; } }
        public Object DisplayLabel { get { return this[nameof(DisplayLabel)]; } set { this[nameof(DisplayLabel)] = value; } }
        public void UnbindFromAnimationStarted(UserWidget Widget, Object Delegate) { Invoke(nameof(UnbindFromAnimationStarted), Widget, Delegate); }
        public void UnbindFromAnimationFinished(UserWidget Widget, Object Delegate) { Invoke(nameof(UnbindFromAnimationFinished), Widget, Delegate); }
        public void UnbindAllFromAnimationStarted(UserWidget Widget) { Invoke(nameof(UnbindAllFromAnimationStarted), Widget); }
        public void UnbindAllFromAnimationFinished(UserWidget Widget) { Invoke(nameof(UnbindAllFromAnimationFinished), Widget); }
        public float GetStartTime() { return Invoke<float>(nameof(GetStartTime)); }
        public float GetEndTime() { return Invoke<float>(nameof(GetEndTime)); }
        public void BindToAnimationStarted(UserWidget Widget, Object Delegate) { Invoke(nameof(BindToAnimationStarted), Widget, Delegate); }
        public void BindToAnimationFinished(UserWidget Widget, Object Delegate) { Invoke(nameof(BindToAnimationFinished), Widget, Delegate); }
    }
    public class WidgetAnimationDelegateBinding : DynamicBlueprintBinding
    {
        public WidgetAnimationDelegateBinding(nint addr) : base(addr) { }
        public Array<BlueprintWidgetAnimationDelegateBinding> WidgetAnimationDelegateBindings { get { return new Array<BlueprintWidgetAnimationDelegateBinding>(this[nameof(WidgetAnimationDelegateBindings)].Address); } }
    }
    public class WidgetAnimationPlayCallbackProxy : Object
    {
        public WidgetAnimationPlayCallbackProxy(nint addr) : base(addr) { }
        public Object Finished { get { return this[nameof(Finished)]; } set { this[nameof(Finished)] = value; } }
        public WidgetAnimationPlayCallbackProxy CreatePlayAnimationTimeRangeProxyObject(UMGSequencePlayer Result, UserWidget Widget, WidgetAnimation InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed) { return Invoke<WidgetAnimationPlayCallbackProxy>(nameof(CreatePlayAnimationTimeRangeProxyObject), Result, Widget, InAnimation, StartAtTime, EndAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed); }
        public WidgetAnimationPlayCallbackProxy CreatePlayAnimationProxyObject(UMGSequencePlayer Result, UserWidget Widget, WidgetAnimation InAnimation, float StartAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed) { return Invoke<WidgetAnimationPlayCallbackProxy>(nameof(CreatePlayAnimationProxyObject), Result, Widget, InAnimation, StartAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed); }
    }
    public class PropertyBinding : Object
    {
        public PropertyBinding(nint addr) : base(addr) { }
        public Object SourceObject { get { return this[nameof(SourceObject)]; } set { this[nameof(SourceObject)] = value; } }
        public DynamicPropertyPath SourcePath { get { return this[nameof(SourcePath)].As<DynamicPropertyPath>(); } set { this["SourcePath"] = value; } }
        public Object DestinationProperty { get { return this[nameof(DestinationProperty)]; } set { this[nameof(DestinationProperty)] = value; } }
    }
    public class BoolBinding : PropertyBinding
    {
        public BoolBinding(nint addr) : base(addr) { }
        public bool GetValue() { return Invoke<bool>(nameof(GetValue)); }
    }
    public class BrushBinding : PropertyBinding
    {
        public BrushBinding(nint addr) : base(addr) { }
        public SlateBrush GetValue() { return Invoke<SlateBrush>(nameof(GetValue)); }
    }
    public class CheckedStateBinding : PropertyBinding
    {
        public CheckedStateBinding(nint addr) : base(addr) { }
        public ECheckBoxState GetValue() { return Invoke<ECheckBoxState>(nameof(GetValue)); }
    }
    public class ColorBinding : PropertyBinding
    {
        public ColorBinding(nint addr) : base(addr) { }
        public SlateColor GetSlateValue() { return Invoke<SlateColor>(nameof(GetSlateValue)); }
        public LinearColor GetLinearValue() { return Invoke<LinearColor>(nameof(GetLinearValue)); }
    }
    public class FloatBinding : PropertyBinding
    {
        public FloatBinding(nint addr) : base(addr) { }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
    }
    public class Int32Binding : PropertyBinding
    {
        public Int32Binding(nint addr) : base(addr) { }
        public int GetValue() { return Invoke<int>(nameof(GetValue)); }
    }
    public class MouseCursorBinding : PropertyBinding
    {
        public MouseCursorBinding(nint addr) : base(addr) { }
        public byte GetValue() { return Invoke<byte>(nameof(GetValue)); }
    }
    public class TextBinding : PropertyBinding
    {
        public TextBinding(nint addr) : base(addr) { }
        public Object GetTextValue() { return Invoke<Object>(nameof(GetTextValue)); }
        public Object GetStringValue() { return Invoke<Object>(nameof(GetStringValue)); }
    }
    public class VisibilityBinding : PropertyBinding
    {
        public VisibilityBinding(nint addr) : base(addr) { }
        public ESlateVisibility GetValue() { return Invoke<ESlateVisibility>(nameof(GetValue)); }
    }
    public class WidgetBinding : PropertyBinding
    {
        public WidgetBinding(nint addr) : base(addr) { }
        public Widget GetValue() { return Invoke<Widget>(nameof(GetValue)); }
    }
    public class AsyncTaskDownloadImage : BlueprintAsyncActionBase
    {
        public AsyncTaskDownloadImage(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFail { get { return this[nameof(OnFail)]; } set { this[nameof(OnFail)] = value; } }
        public AsyncTaskDownloadImage DownloadImage(Object URL) { return Invoke<AsyncTaskDownloadImage>(nameof(DownloadImage), URL); }
    }
    public class GameViewportSubsystem : GameInstanceSubsystem
    {
        public GameViewportSubsystem(nint addr) : base(addr) { }
        public GameViewportWidgetSlot SetWidgetSlotPosition(GameViewportWidgetSlot Slot, Widget Widget, Vector2D Position, bool bRemoveDPIScale) { return Invoke<GameViewportWidgetSlot>(nameof(SetWidgetSlotPosition), Slot, Widget, Position, bRemoveDPIScale); }
        public GameViewportWidgetSlot SetWidgetSlotDesiredSize(GameViewportWidgetSlot Slot, Vector2D Size) { return Invoke<GameViewportWidgetSlot>(nameof(SetWidgetSlotDesiredSize), Slot, Size); }
        public void SetWidgetSlot(Widget Widget, GameViewportWidgetSlot Slot) { Invoke(nameof(SetWidgetSlot), Widget, Slot); }
        public void RemoveWidget(Widget Widget) { Invoke(nameof(RemoveWidget), Widget); }
        public bool IsWidgetAdded(Widget Widget) { return Invoke<bool>(nameof(IsWidgetAdded), Widget); }
        public GameViewportWidgetSlot GetWidgetSlot(Widget Widget) { return Invoke<GameViewportWidgetSlot>(nameof(GetWidgetSlot), Widget); }
        public void AddWidgetForPlayer(Widget Widget, LocalPlayer Player, GameViewportWidgetSlot Slot) { Invoke(nameof(AddWidgetForPlayer), Widget, Player, Slot); }
        public void AddWidget(Widget Widget, GameViewportWidgetSlot Slot) { Invoke(nameof(AddWidget), Widget, Slot); }
    }
    public class UserListEntry : Interface
    {
        public UserListEntry(nint addr) : base(addr) { }
        public void BP_OnItemSelectionChanged(bool bIsSelected) { Invoke(nameof(BP_OnItemSelectionChanged), bIsSelected); }
        public void BP_OnItemExpansionChanged(bool bIsExpanded) { Invoke(nameof(BP_OnItemExpansionChanged), bIsExpanded); }
        public void BP_OnEntryReleased() { Invoke(nameof(BP_OnEntryReleased)); }
    }
    public class UserListEntryLibrary : BlueprintFunctionLibrary
    {
        public UserListEntryLibrary(nint addr) : base(addr) { }
        public bool IsListItemSelected(Object UserListEntry) { return Invoke<bool>(nameof(IsListItemSelected), UserListEntry); }
        public bool IsListItemExpanded(Object UserListEntry) { return Invoke<bool>(nameof(IsListItemExpanded), UserListEntry); }
        public ListViewBase GetOwningListView(Object UserListEntry) { return Invoke<ListViewBase>(nameof(GetOwningListView), UserListEntry); }
    }
    public class UserObjectListEntry : UserListEntry
    {
        public UserObjectListEntry(nint addr) : base(addr) { }
        public void OnListItemObjectSet(Object ListItemObject) { Invoke(nameof(OnListItemObjectSet), ListItemObject); }
    }
    public class UserObjectListEntryLibrary : BlueprintFunctionLibrary
    {
        public UserObjectListEntryLibrary(nint addr) : base(addr) { }
        public Object GetListItemObject(Object UserObjectListEntry) { return Invoke<Object>(nameof(GetListItemObject), UserObjectListEntry); }
    }
    public class BackgroundBlur : ContentWidget
    {
        public BackgroundBlur(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public bool bApplyAlphaToBlur { get { return this[nameof(bApplyAlphaToBlur)].Flag; } set { this[nameof(bApplyAlphaToBlur)].Flag = value; } }
        public float BlurStrength { get { return this[nameof(BlurStrength)].GetValue<float>(); } set { this[nameof(BlurStrength)].SetValue<float>(value); } }
        public bool bOverrideAutoRadiusCalculation { get { return this[nameof(bOverrideAutoRadiusCalculation)].Flag; } set { this[nameof(bOverrideAutoRadiusCalculation)].Flag = value; } }
        public int BlurRadius { get { return this[nameof(BlurRadius)].GetValue<int>(); } set { this[nameof(BlurRadius)].SetValue<int>(value); } }
        public Vector4 CornerRadius { get { return this[nameof(CornerRadius)].As<Vector4>(); } set { this["CornerRadius"] = value; } }
        public SlateBrush LowQualityFallbackBrush { get { return this[nameof(LowQualityFallbackBrush)].As<SlateBrush>(); } set { this["LowQualityFallbackBrush"] = value; } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetLowQualityFallbackBrush(SlateBrush InBrush) { Invoke(nameof(SetLowQualityFallbackBrush), InBrush); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public void SetCornerRadius(Vector4 InCornerRadius) { Invoke(nameof(SetCornerRadius), InCornerRadius); }
        public void SetBlurStrength(float InStrength) { Invoke(nameof(SetBlurStrength), InStrength); }
        public void SetBlurRadius(int InBlurRadius) { Invoke(nameof(SetBlurRadius), InBlurRadius); }
        public void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur) { Invoke(nameof(SetApplyAlphaToBlur), bInApplyAlphaToBlur); }
    }
    public class BackgroundBlurSlot : PanelSlot
    {
        public BackgroundBlurSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class BorderSlot : PanelSlot
    {
        public BorderSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class ButtonSlot : PanelSlot
    {
        public ButtonSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class CanvasPanel : PanelWidget
    {
        public CanvasPanel(nint addr) : base(addr) { }
        public CanvasPanelSlot AddChildToCanvas(Widget Content) { return Invoke<CanvasPanelSlot>(nameof(AddChildToCanvas), Content); }
    }
    public class CanvasPanelSlot : PanelSlot
    {
        public CanvasPanelSlot(nint addr) : base(addr) { }
        public AnchorData LayoutData { get { return this[nameof(LayoutData)].As<AnchorData>(); } set { this["LayoutData"] = value; } }
        public bool bAutoSize { get { return this[nameof(bAutoSize)].Flag; } set { this[nameof(bAutoSize)].Flag = value; } }
        public int ZOrder { get { return this[nameof(ZOrder)].GetValue<int>(); } set { this[nameof(ZOrder)].SetValue<int>(value); } }
        public void SetZOrder(int InZOrder) { Invoke(nameof(SetZOrder), InZOrder); }
        public void SetSize(Vector2D InSize) { Invoke(nameof(SetSize), InSize); }
        public void SetPosition(Vector2D InPosition) { Invoke(nameof(SetPosition), InPosition); }
        public void SetOffsets(Margin InOffset) { Invoke(nameof(SetOffsets), InOffset); }
        public void SetMinimum(Vector2D InMinimumAnchors) { Invoke(nameof(SetMinimum), InMinimumAnchors); }
        public void SetMaximum(Vector2D InMaximumAnchors) { Invoke(nameof(SetMaximum), InMaximumAnchors); }
        public void SetLayout(AnchorData InLayoutData) { Invoke(nameof(SetLayout), InLayoutData); }
        public void SetAutoSize(bool InbAutoSize) { Invoke(nameof(SetAutoSize), InbAutoSize); }
        public void SetAnchors(Anchors InAnchors) { Invoke(nameof(SetAnchors), InAnchors); }
        public void SetAlignment(Vector2D InAlignment) { Invoke(nameof(SetAlignment), InAlignment); }
        public int GetZOrder() { return Invoke<int>(nameof(GetZOrder)); }
        public Vector2D GetSize() { return Invoke<Vector2D>(nameof(GetSize)); }
        public Vector2D GetPosition() { return Invoke<Vector2D>(nameof(GetPosition)); }
        public Margin GetOffsets() { return Invoke<Margin>(nameof(GetOffsets)); }
        public AnchorData GetLayout() { return Invoke<AnchorData>(nameof(GetLayout)); }
        public bool GetAutoSize() { return Invoke<bool>(nameof(GetAutoSize)); }
        public Anchors GetAnchors() { return Invoke<Anchors>(nameof(GetAnchors)); }
        public Vector2D GetAlignment() { return Invoke<Vector2D>(nameof(GetAlignment)); }
    }
    public class CheckBox : ContentWidget
    {
        public CheckBox(nint addr) : base(addr) { }
        public ECheckBoxState CheckedState { get { return (ECheckBoxState)this[nameof(CheckedState)].GetValue<int>(); } set { this[nameof(CheckedState)].SetValue<int>((int)value); } }
        public Object CheckedStateDelegate { get { return this[nameof(CheckedStateDelegate)]; } set { this[nameof(CheckedStateDelegate)] = value; } }
        public CheckBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<CheckBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte ClickMethod { get { return this[nameof(ClickMethod)].GetValue<byte>(); } set { this[nameof(ClickMethod)].SetValue<byte>(value); } }
        public byte TouchMethod { get { return this[nameof(TouchMethod)].GetValue<byte>(); } set { this[nameof(TouchMethod)].SetValue<byte>(value); } }
        public byte PressMethod { get { return this[nameof(PressMethod)].GetValue<byte>(); } set { this[nameof(PressMethod)].SetValue<byte>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public Object OnCheckStateChanged { get { return this[nameof(OnCheckStateChanged)]; } set { this[nameof(OnCheckStateChanged)] = value; } }
        public void SetTouchMethod(byte InTouchMethod) { Invoke(nameof(SetTouchMethod), InTouchMethod); }
        public void SetPressMethod(byte InPressMethod) { Invoke(nameof(SetPressMethod), InPressMethod); }
        public void SetIsChecked(bool InIsChecked) { Invoke(nameof(SetIsChecked), InIsChecked); }
        public void SetClickMethod(byte InClickMethod) { Invoke(nameof(SetClickMethod), InClickMethod); }
        public void SetCheckedState(ECheckBoxState InCheckedState) { Invoke(nameof(SetCheckedState), InCheckedState); }
        public bool IsPressed() { return Invoke<bool>(nameof(IsPressed)); }
        public bool IsChecked() { return Invoke<bool>(nameof(IsChecked)); }
        public ECheckBoxState GetCheckedState() { return Invoke<ECheckBoxState>(nameof(GetCheckedState)); }
    }
    public class CircularThrobber : Widget
    {
        public CircularThrobber(nint addr) : base(addr) { }
        public int NumberOfPieces { get { return this[nameof(NumberOfPieces)].GetValue<int>(); } set { this[nameof(NumberOfPieces)].SetValue<int>(value); } }
        public float Period { get { return this[nameof(Period)].GetValue<float>(); } set { this[nameof(Period)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public SlateBrush Image { get { return this[nameof(Image)].As<SlateBrush>(); } set { this["Image"] = value; } }
        public bool bEnableRadius { get { return this[nameof(bEnableRadius)].Flag; } set { this[nameof(bEnableRadius)].Flag = value; } }
        public void SetRadius(float InRadius) { Invoke(nameof(SetRadius), InRadius); }
        public void SetPeriod(float InPeriod) { Invoke(nameof(SetPeriod), InPeriod); }
        public void SetNumberOfPieces(int InNumberOfPieces) { Invoke(nameof(SetNumberOfPieces), InNumberOfPieces); }
    }
    public class ComboBox : Widget
    {
        public ComboBox(nint addr) : base(addr) { }
        public Array<Object> Items { get { return new Array<Object>(this[nameof(Items)].Address); } }
        public Object OnGenerateWidgetEvent { get { return this[nameof(OnGenerateWidgetEvent)]; } set { this[nameof(OnGenerateWidgetEvent)] = value; } }
        public bool bIsFocusable { get { return this[nameof(bIsFocusable)].Flag; } set { this[nameof(bIsFocusable)].Flag = value; } }
    }
    public class ComboBoxKey : Widget
    {
        public ComboBoxKey(nint addr) : base(addr) { }
        public Array<Object> Options { get { return new Array<Object>(this[nameof(Options)].Address); } }
        public Object SelectedOption { get { return this[nameof(SelectedOption)]; } set { this[nameof(SelectedOption)] = value; } }
        public ComboBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ComboBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public TableRowStyle ItemStyle { get { return this[nameof(ItemStyle)].As<TableRowStyle>(); } set { this["ItemStyle"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public Margin ContentPadding { get { return this[nameof(ContentPadding)].As<Margin>(); } set { this["ContentPadding"] = value; } }
        public float MaxListHeight { get { return this[nameof(MaxListHeight)].GetValue<float>(); } set { this[nameof(MaxListHeight)].SetValue<float>(value); } }
        public bool bHasDownArrow { get { return this[nameof(bHasDownArrow)].Flag; } set { this[nameof(bHasDownArrow)].Flag = value; } }
        public bool bEnableGamepadNavigationMode { get { return this[nameof(bEnableGamepadNavigationMode)].Flag; } set { this[nameof(bEnableGamepadNavigationMode)].Flag = value; } }
        public bool bIsFocusable { get { return this[nameof(bIsFocusable)].Flag; } set { this[nameof(bIsFocusable)].Flag = value; } }
        public Object OnGenerateContentWidget { get { return this[nameof(OnGenerateContentWidget)]; } set { this[nameof(OnGenerateContentWidget)] = value; } }
        public Object OnGenerateItemWidget { get { return this[nameof(OnGenerateItemWidget)]; } set { this[nameof(OnGenerateItemWidget)] = value; } }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnOpening { get { return this[nameof(OnOpening)]; } set { this[nameof(OnOpening)] = value; } }
        public void SetSelectedOption(Object Option) { Invoke(nameof(SetSelectedOption), Option); }
        public bool RemoveOption(Object Option) { return Invoke<bool>(nameof(RemoveOption), Option); }
        public void OnSelectionChangedEvent__DelegateSignature(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnSelectionChangedEvent__DelegateSignature), SelectedItem, SelectionType); }
        public void OnOpeningEvent__DelegateSignature() { Invoke(nameof(OnOpeningEvent__DelegateSignature)); }
        public bool IsOpen() { return Invoke<bool>(nameof(IsOpen)); }
        public Object GetSelectedOption() { return Invoke<Object>(nameof(GetSelectedOption)); }
        public Widget GenerateWidgetEvent__DelegateSignature(Object Item) { return Invoke<Widget>(nameof(GenerateWidgetEvent__DelegateSignature), Item); }
        public void ClearSelection() { Invoke(nameof(ClearSelection)); }
        public void ClearOptions() { Invoke(nameof(ClearOptions)); }
        public void AddOption(Object Option) { Invoke(nameof(AddOption), Option); }
    }
    public class ComboBoxString : Widget
    {
        public ComboBoxString(nint addr) : base(addr) { }
        public Array<Object> DefaultOptions { get { return new Array<Object>(this[nameof(DefaultOptions)].Address); } }
        public Object SelectedOption { get { return this[nameof(SelectedOption)]; } set { this[nameof(SelectedOption)] = value; } }
        public ComboBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ComboBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public TableRowStyle ItemStyle { get { return this[nameof(ItemStyle)].As<TableRowStyle>(); } set { this["ItemStyle"] = value; } }
        public Margin ContentPadding { get { return this[nameof(ContentPadding)].As<Margin>(); } set { this["ContentPadding"] = value; } }
        public float MaxListHeight { get { return this[nameof(MaxListHeight)].GetValue<float>(); } set { this[nameof(MaxListHeight)].SetValue<float>(value); } }
        public bool HasDownArrow { get { return this[nameof(HasDownArrow)].Flag; } set { this[nameof(HasDownArrow)].Flag = value; } }
        public bool EnableGamepadNavigationMode { get { return this[nameof(EnableGamepadNavigationMode)].Flag; } set { this[nameof(EnableGamepadNavigationMode)].Flag = value; } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public bool bIsFocusable { get { return this[nameof(bIsFocusable)].Flag; } set { this[nameof(bIsFocusable)].Flag = value; } }
        public Object OnGenerateWidgetEvent { get { return this[nameof(OnGenerateWidgetEvent)]; } set { this[nameof(OnGenerateWidgetEvent)] = value; } }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnOpening { get { return this[nameof(OnOpening)]; } set { this[nameof(OnOpening)] = value; } }
        public void SetSelectedOption(Object Option) { Invoke(nameof(SetSelectedOption), Option); }
        public void SetSelectedIndex(int Index) { Invoke(nameof(SetSelectedIndex), Index); }
        public bool RemoveOption(Object Option) { return Invoke<bool>(nameof(RemoveOption), Option); }
        public void RefreshOptions() { Invoke(nameof(RefreshOptions)); }
        public void OnSelectionChangedEvent__DelegateSignature(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnSelectionChangedEvent__DelegateSignature), SelectedItem, SelectionType); }
        public void OnOpeningEvent__DelegateSignature() { Invoke(nameof(OnOpeningEvent__DelegateSignature)); }
        public bool IsOpen() { return Invoke<bool>(nameof(IsOpen)); }
        public Object GetSelectedOption() { return Invoke<Object>(nameof(GetSelectedOption)); }
        public int GetSelectedIndex() { return Invoke<int>(nameof(GetSelectedIndex)); }
        public int GetOptionCount() { return Invoke<int>(nameof(GetOptionCount)); }
        public Object GetOptionAtIndex(int Index) { return Invoke<Object>(nameof(GetOptionAtIndex), Index); }
        public int FindOptionIndex(Object Option) { return Invoke<int>(nameof(FindOptionIndex), Option); }
        public void ClearSelection() { Invoke(nameof(ClearSelection)); }
        public void ClearOptions() { Invoke(nameof(ClearOptions)); }
        public void AddOption(Object Option) { Invoke(nameof(AddOption), Option); }
    }
    public class DynamicEntryBox : DynamicEntryBoxBase
    {
        public DynamicEntryBox(nint addr) : base(addr) { }
        public Object EntryWidgetClass { get { return this[nameof(EntryWidgetClass)]; } set { this[nameof(EntryWidgetClass)] = value; } }
        public void Reset(bool bDeleteWidgets) { Invoke(nameof(Reset), bDeleteWidgets); }
        public void RemoveEntry(UserWidget EntryWidget) { Invoke(nameof(RemoveEntry), EntryWidget); }
        public UserWidget BP_CreateEntryOfClass(Object EntryClass) { return Invoke<UserWidget>(nameof(BP_CreateEntryOfClass), EntryClass); }
        public UserWidget BP_CreateEntry() { return Invoke<UserWidget>(nameof(BP_CreateEntry)); }
    }
    public class EditableText : Widget
    {
        public EditableText(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object TextDelegate { get { return this[nameof(TextDelegate)]; } set { this[nameof(TextDelegate)] = value; } }
        public Object HintText { get { return this[nameof(HintText)]; } set { this[nameof(HintText)] = value; } }
        public Object HintTextDelegate { get { return this[nameof(HintTextDelegate)]; } set { this[nameof(HintTextDelegate)] = value; } }
        public EditableTextStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<EditableTextStyle>(); } set { this["WidgetStyle"] = value; } }
        public bool IsReadOnly { get { return this[nameof(IsReadOnly)].Flag; } set { this[nameof(IsReadOnly)].Flag = value; } }
        public bool IsPassword { get { return this[nameof(IsPassword)].Flag; } set { this[nameof(IsPassword)].Flag = value; } }
        public float MinimumDesiredWidth { get { return this[nameof(MinimumDesiredWidth)].GetValue<float>(); } set { this[nameof(MinimumDesiredWidth)].SetValue<float>(value); } }
        public bool IsCaretMovedWhenGainFocus { get { return this[nameof(IsCaretMovedWhenGainFocus)].Flag; } set { this[nameof(IsCaretMovedWhenGainFocus)].Flag = value; } }
        public bool SelectAllTextWhenFocused { get { return this[nameof(SelectAllTextWhenFocused)].Flag; } set { this[nameof(SelectAllTextWhenFocused)].Flag = value; } }
        public bool RevertTextOnEscape { get { return this[nameof(RevertTextOnEscape)].Flag; } set { this[nameof(RevertTextOnEscape)].Flag = value; } }
        public bool ClearKeyboardFocusOnCommit { get { return this[nameof(ClearKeyboardFocusOnCommit)].Flag; } set { this[nameof(ClearKeyboardFocusOnCommit)].Flag = value; } }
        public bool SelectAllTextOnCommit { get { return this[nameof(SelectAllTextOnCommit)].Flag; } set { this[nameof(SelectAllTextOnCommit)].Flag = value; } }
        public bool AllowContextMenu { get { return this[nameof(AllowContextMenu)].Flag; } set { this[nameof(AllowContextMenu)].Flag = value; } }
        public byte KeyboardType { get { return this[nameof(KeyboardType)].GetValue<byte>(); } set { this[nameof(KeyboardType)].SetValue<byte>(value); } }
        public VirtualKeyboardOptions VirtualKeyboardOptions { get { return this[nameof(VirtualKeyboardOptions)].As<VirtualKeyboardOptions>(); } set { this["VirtualKeyboardOptions"] = value; } }
        public EVirtualKeyboardTrigger VirtualKeyboardTrigger { get { return (EVirtualKeyboardTrigger)this[nameof(VirtualKeyboardTrigger)].GetValue<int>(); } set { this[nameof(VirtualKeyboardTrigger)].SetValue<int>((int)value); } }
        public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction { get { return (EVirtualKeyboardDismissAction)this[nameof(VirtualKeyboardDismissAction)].GetValue<int>(); } set { this[nameof(VirtualKeyboardDismissAction)].SetValue<int>((int)value); } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
        public ETextOverflowPolicy OverflowPolicy { get { return (ETextOverflowPolicy)this[nameof(OverflowPolicy)].GetValue<int>(); } set { this[nameof(OverflowPolicy)].SetValue<int>((int)value); } }
        public ShapedTextOptions ShapedTextOptions { get { return this[nameof(ShapedTextOptions)].As<ShapedTextOptions>(); } set { this["ShapedTextOptions"] = value; } }
        public Object OnTextChanged { get { return this[nameof(OnTextChanged)]; } set { this[nameof(OnTextChanged)] = value; } }
        public Object OnTextCommitted { get { return this[nameof(OnTextCommitted)]; } set { this[nameof(OnTextCommitted)] = value; } }
        public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) { Invoke(nameof(SetTextOverflowPolicy), InOverflowPolicy); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetMinimumDesiredWidth(float InMinDesiredWidth) { Invoke(nameof(SetMinimumDesiredWidth), InMinDesiredWidth); }
        public void SetJustification(byte InJustification) { Invoke(nameof(SetJustification), InJustification); }
        public void SetIsReadOnly(bool InbIsReadyOnly) { Invoke(nameof(SetIsReadOnly), InbIsReadyOnly); }
        public void SetIsPassword(bool InbIsPassword) { Invoke(nameof(SetIsPassword), InbIsPassword); }
        public void SetHintText(Object InHintText) { Invoke(nameof(SetHintText), InHintText); }
        public void SetFontOutlineMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontOutlineMaterial), InMaterial); }
        public void SetFontMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontMaterial), InMaterial); }
        public void SetFont(SlateFontInfo InFontInfo) { Invoke(nameof(SetFont), InFontInfo); }
        public void OnEditableTextCommittedEvent__DelegateSignature(Object Text, byte CommitMethod) { Invoke(nameof(OnEditableTextCommittedEvent__DelegateSignature), Text, CommitMethod); }
        public void OnEditableTextChangedEvent__DelegateSignature(Object Text) { Invoke(nameof(OnEditableTextChangedEvent__DelegateSignature), Text); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public byte GetJustification() { return Invoke<byte>(nameof(GetJustification)); }
        public Object GetHintText() { return Invoke<Object>(nameof(GetHintText)); }
        public SlateFontInfo GetFont() { return Invoke<SlateFontInfo>(nameof(GetFont)); }
    }
    public class EditableTextBox : Widget
    {
        public EditableTextBox(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object TextDelegate { get { return this[nameof(TextDelegate)]; } set { this[nameof(TextDelegate)] = value; } }
        public EditableTextBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<EditableTextBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public Object HintText { get { return this[nameof(HintText)]; } set { this[nameof(HintText)] = value; } }
        public Object HintTextDelegate { get { return this[nameof(HintTextDelegate)]; } set { this[nameof(HintTextDelegate)] = value; } }
        public bool IsReadOnly { get { return this[nameof(IsReadOnly)].Flag; } set { this[nameof(IsReadOnly)].Flag = value; } }
        public bool IsPassword { get { return this[nameof(IsPassword)].Flag; } set { this[nameof(IsPassword)].Flag = value; } }
        public float MinimumDesiredWidth { get { return this[nameof(MinimumDesiredWidth)].GetValue<float>(); } set { this[nameof(MinimumDesiredWidth)].SetValue<float>(value); } }
        public bool IsCaretMovedWhenGainFocus { get { return this[nameof(IsCaretMovedWhenGainFocus)].Flag; } set { this[nameof(IsCaretMovedWhenGainFocus)].Flag = value; } }
        public bool SelectAllTextWhenFocused { get { return this[nameof(SelectAllTextWhenFocused)].Flag; } set { this[nameof(SelectAllTextWhenFocused)].Flag = value; } }
        public bool RevertTextOnEscape { get { return this[nameof(RevertTextOnEscape)].Flag; } set { this[nameof(RevertTextOnEscape)].Flag = value; } }
        public bool ClearKeyboardFocusOnCommit { get { return this[nameof(ClearKeyboardFocusOnCommit)].Flag; } set { this[nameof(ClearKeyboardFocusOnCommit)].Flag = value; } }
        public bool SelectAllTextOnCommit { get { return this[nameof(SelectAllTextOnCommit)].Flag; } set { this[nameof(SelectAllTextOnCommit)].Flag = value; } }
        public bool AllowContextMenu { get { return this[nameof(AllowContextMenu)].Flag; } set { this[nameof(AllowContextMenu)].Flag = value; } }
        public byte KeyboardType { get { return this[nameof(KeyboardType)].GetValue<byte>(); } set { this[nameof(KeyboardType)].SetValue<byte>(value); } }
        public VirtualKeyboardOptions VirtualKeyboardOptions { get { return this[nameof(VirtualKeyboardOptions)].As<VirtualKeyboardOptions>(); } set { this["VirtualKeyboardOptions"] = value; } }
        public EVirtualKeyboardTrigger VirtualKeyboardTrigger { get { return (EVirtualKeyboardTrigger)this[nameof(VirtualKeyboardTrigger)].GetValue<int>(); } set { this[nameof(VirtualKeyboardTrigger)].SetValue<int>((int)value); } }
        public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction { get { return (EVirtualKeyboardDismissAction)this[nameof(VirtualKeyboardDismissAction)].GetValue<int>(); } set { this[nameof(VirtualKeyboardDismissAction)].SetValue<int>((int)value); } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
        public ETextOverflowPolicy OverflowPolicy { get { return (ETextOverflowPolicy)this[nameof(OverflowPolicy)].GetValue<int>(); } set { this[nameof(OverflowPolicy)].SetValue<int>((int)value); } }
        public ShapedTextOptions ShapedTextOptions { get { return this[nameof(ShapedTextOptions)].As<ShapedTextOptions>(); } set { this["ShapedTextOptions"] = value; } }
        public Object OnTextChanged { get { return this[nameof(OnTextChanged)]; } set { this[nameof(OnTextChanged)] = value; } }
        public Object OnTextCommitted { get { return this[nameof(OnTextCommitted)]; } set { this[nameof(OnTextCommitted)] = value; } }
        public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) { Invoke(nameof(SetTextOverflowPolicy), InOverflowPolicy); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetJustification(byte InJustification) { Invoke(nameof(SetJustification), InJustification); }
        public void SetIsReadOnly(bool bReadOnly) { Invoke(nameof(SetIsReadOnly), bReadOnly); }
        public void SetIsPassword(bool bIsPassword) { Invoke(nameof(SetIsPassword), bIsPassword); }
        public void SetHintText(Object InText) { Invoke(nameof(SetHintText), InText); }
        public void SetForegroundColor(LinearColor Color) { Invoke(nameof(SetForegroundColor), Color); }
        public void SetError(Object InError) { Invoke(nameof(SetError), InError); }
        public void OnEditableTextBoxCommittedEvent__DelegateSignature(Object Text, byte CommitMethod) { Invoke(nameof(OnEditableTextBoxCommittedEvent__DelegateSignature), Text, CommitMethod); }
        public void OnEditableTextBoxChangedEvent__DelegateSignature(Object Text) { Invoke(nameof(OnEditableTextBoxChangedEvent__DelegateSignature), Text); }
        public bool HasError() { return Invoke<bool>(nameof(HasError)); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public void ClearError() { Invoke(nameof(ClearError)); }
    }
    public class ExpandableArea : Widget
    {
        public ExpandableArea(nint addr) : base(addr) { }
        public ExpandableAreaStyle Style { get { return this[nameof(Style)].As<ExpandableAreaStyle>(); } set { this["Style"] = value; } }
        public SlateBrush BorderBrush { get { return this[nameof(BorderBrush)].As<SlateBrush>(); } set { this["BorderBrush"] = value; } }
        public SlateColor BorderColor { get { return this[nameof(BorderColor)].As<SlateColor>(); } set { this["BorderColor"] = value; } }
        public bool bIsExpanded { get { return this[nameof(bIsExpanded)].Flag; } set { this[nameof(bIsExpanded)].Flag = value; } }
        public float MaxHeight { get { return this[nameof(MaxHeight)].GetValue<float>(); } set { this[nameof(MaxHeight)].SetValue<float>(value); } }
        public Margin HeaderPadding { get { return this[nameof(HeaderPadding)].As<Margin>(); } set { this["HeaderPadding"] = value; } }
        public Margin AreaPadding { get { return this[nameof(AreaPadding)].As<Margin>(); } set { this["AreaPadding"] = value; } }
        public Object OnExpansionChanged { get { return this[nameof(OnExpansionChanged)]; } set { this[nameof(OnExpansionChanged)] = value; } }
        public Widget HeaderContent { get { return this[nameof(HeaderContent)].As<Widget>(); } set { this["HeaderContent"] = value; } }
        public Widget BodyContent { get { return this[nameof(BodyContent)].As<Widget>(); } set { this["BodyContent"] = value; } }
        public void SetIsExpanded_Animated(bool IsExpanded) { Invoke(nameof(SetIsExpanded_Animated), IsExpanded); }
        public void SetIsExpanded(bool IsExpanded) { Invoke(nameof(SetIsExpanded), IsExpanded); }
        public bool GetIsExpanded() { return Invoke<bool>(nameof(GetIsExpanded)); }
    }
    public class GridPanel : PanelWidget
    {
        public GridPanel(nint addr) : base(addr) { }
        public Array<float> ColumnFill { get { return new Array<float>(this[nameof(ColumnFill)].Address); } }
        public Array<float> RowFill { get { return new Array<float>(this[nameof(RowFill)].Address); } }
        public void SetRowFill(int RowIndex, float Coefficient) { Invoke(nameof(SetRowFill), RowIndex, Coefficient); }
        public void SetColumnFill(int ColumnIndex, float Coefficient) { Invoke(nameof(SetColumnFill), ColumnIndex, Coefficient); }
        public GridSlot AddChildToGrid(Widget Content, int InRow, int InColumn) { return Invoke<GridSlot>(nameof(AddChildToGrid), Content, InRow, InColumn); }
    }
    public class GridSlot : PanelSlot
    {
        public GridSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public int Row { get { return this[nameof(Row)].GetValue<int>(); } set { this[nameof(Row)].SetValue<int>(value); } }
        public int RowSpan { get { return this[nameof(RowSpan)].GetValue<int>(); } set { this[nameof(RowSpan)].SetValue<int>(value); } }
        public int Column { get { return this[nameof(Column)].GetValue<int>(); } set { this[nameof(Column)].SetValue<int>(value); } }
        public int ColumnSpan { get { return this[nameof(ColumnSpan)].GetValue<int>(); } set { this[nameof(ColumnSpan)].SetValue<int>(value); } }
        public int Layer { get { return this[nameof(Layer)].GetValue<int>(); } set { this[nameof(Layer)].SetValue<int>(value); } }
        public Vector2D Nudge { get { return this[nameof(Nudge)].As<Vector2D>(); } set { this["Nudge"] = value; } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetRowSpan(int InRowSpan) { Invoke(nameof(SetRowSpan), InRowSpan); }
        public void SetRow(int InRow) { Invoke(nameof(SetRow), InRow); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetNudge(Vector2D InNudge) { Invoke(nameof(SetNudge), InNudge); }
        public void SetLayer(int InLayer) { Invoke(nameof(SetLayer), InLayer); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public void SetColumnSpan(int InColumnSpan) { Invoke(nameof(SetColumnSpan), InColumnSpan); }
        public void SetColumn(int InColumn) { Invoke(nameof(SetColumn), InColumn); }
    }
    public class HorizontalBox : PanelWidget
    {
        public HorizontalBox(nint addr) : base(addr) { }
        public HorizontalBoxSlot AddChildToHorizontalBox(Widget Content) { return Invoke<HorizontalBoxSlot>(nameof(AddChildToHorizontalBox), Content); }
    }
    public class HorizontalBoxSlot : PanelSlot
    {
        public HorizontalBoxSlot(nint addr) : base(addr) { }
        public SlateChildSize Size { get { return this[nameof(Size)].As<SlateChildSize>(); } set { this["Size"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetSize(SlateChildSize InSize) { Invoke(nameof(SetSize), InSize); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class InputKeySelector : Widget
    {
        public InputKeySelector(nint addr) : base(addr) { }
        public ButtonStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ButtonStyle>(); } set { this["WidgetStyle"] = value; } }
        public TextBlockStyle TextStyle { get { return this[nameof(TextStyle)].As<TextBlockStyle>(); } set { this["TextStyle"] = value; } }
        public InputChord SelectedKey { get { return this[nameof(SelectedKey)].As<InputChord>(); } set { this["SelectedKey"] = value; } }
        public Margin Margin { get { return this[nameof(Margin)].As<Margin>(); } set { this["Margin"] = value; } }
        public Object KeySelectionText { get { return this[nameof(KeySelectionText)]; } set { this[nameof(KeySelectionText)] = value; } }
        public Object NoKeySpecifiedText { get { return this[nameof(NoKeySpecifiedText)]; } set { this[nameof(NoKeySpecifiedText)] = value; } }
        public bool bAllowModifierKeys { get { return this[nameof(bAllowModifierKeys)].Flag; } set { this[nameof(bAllowModifierKeys)].Flag = value; } }
        public bool bAllowGamepadKeys { get { return this[nameof(bAllowGamepadKeys)].Flag; } set { this[nameof(bAllowGamepadKeys)].Flag = value; } }
        public Array<Key> EscapeKeys { get { return new Array<Key>(this[nameof(EscapeKeys)].Address); } }
        public Object OnKeySelected { get { return this[nameof(OnKeySelected)]; } set { this[nameof(OnKeySelected)] = value; } }
        public Object OnIsSelectingKeyChanged { get { return this[nameof(OnIsSelectingKeyChanged)]; } set { this[nameof(OnIsSelectingKeyChanged)] = value; } }
        public void SetTextBlockVisibility(ESlateVisibility InVisibility) { Invoke(nameof(SetTextBlockVisibility), InVisibility); }
        public void SetSelectedKey(InputChord InSelectedKey) { Invoke(nameof(SetSelectedKey), InSelectedKey); }
        public void SetNoKeySpecifiedText(Object InNoKeySpecifiedText) { Invoke(nameof(SetNoKeySpecifiedText), InNoKeySpecifiedText); }
        public void SetKeySelectionText(Object InKeySelectionText) { Invoke(nameof(SetKeySelectionText), InKeySelectionText); }
        public void SetEscapeKeys(Array<Key> InKeys) { Invoke(nameof(SetEscapeKeys), InKeys); }
        public void SetAllowModifierKeys(bool bInAllowModifierKeys) { Invoke(nameof(SetAllowModifierKeys), bInAllowModifierKeys); }
        public void SetAllowGamepadKeys(bool bInAllowGamepadKeys) { Invoke(nameof(SetAllowGamepadKeys), bInAllowGamepadKeys); }
        public void OnKeySelected__DelegateSignature(InputChord SelectedKey) { Invoke(nameof(OnKeySelected__DelegateSignature), SelectedKey); }
        public void OnIsSelectingKeyChanged__DelegateSignature() { Invoke(nameof(OnIsSelectingKeyChanged__DelegateSignature)); }
        public bool GetIsSelectingKey() { return Invoke<bool>(nameof(GetIsSelectingKey)); }
    }
    public class InvalidationBox : ContentWidget
    {
        public InvalidationBox(nint addr) : base(addr) { }
        public bool bCanCache { get { return this[nameof(bCanCache)].Flag; } set { this[nameof(bCanCache)].Flag = value; } }
        public bool CacheRelativeTransforms { get { return this[nameof(CacheRelativeTransforms)].Flag; } set { this[nameof(CacheRelativeTransforms)].Flag = value; } }
        public void SetCanCache(bool CanCache) { Invoke(nameof(SetCanCache), CanCache); }
        public void InvalidateCache() { Invoke(nameof(InvalidateCache)); }
        public bool GetCanCache() { return Invoke<bool>(nameof(GetCanCache)); }
    }
    public class MenuAnchor : ContentWidget
    {
        public MenuAnchor(nint addr) : base(addr) { }
        public Object MenuClass { get { return this[nameof(MenuClass)]; } set { this[nameof(MenuClass)] = value; } }
        public Object OnGetMenuContentEvent { get { return this[nameof(OnGetMenuContentEvent)]; } set { this[nameof(OnGetMenuContentEvent)] = value; } }
        public Object OnGetUserMenuContentEvent { get { return this[nameof(OnGetUserMenuContentEvent)]; } set { this[nameof(OnGetUserMenuContentEvent)] = value; } }
        public byte Placement { get { return this[nameof(Placement)].GetValue<byte>(); } set { this[nameof(Placement)].SetValue<byte>(value); } }
        public bool bFitInWindow { get { return this[nameof(bFitInWindow)].Flag; } set { this[nameof(bFitInWindow)].Flag = value; } }
        public bool ShouldDeferPaintingAfterWindowContent { get { return this[nameof(ShouldDeferPaintingAfterWindowContent)].Flag; } set { this[nameof(ShouldDeferPaintingAfterWindowContent)].Flag = value; } }
        public bool UseApplicationMenuStack { get { return this[nameof(UseApplicationMenuStack)].Flag; } set { this[nameof(UseApplicationMenuStack)].Flag = value; } }
        public Object OnMenuOpenChanged { get { return this[nameof(OnMenuOpenChanged)]; } set { this[nameof(OnMenuOpenChanged)] = value; } }
        public void ToggleOpen(bool bFocusOnOpen) { Invoke(nameof(ToggleOpen), bFocusOnOpen); }
        public bool ShouldOpenDueToClick() { return Invoke<bool>(nameof(ShouldOpenDueToClick)); }
        public void SetPlacement(byte InPlacement) { Invoke(nameof(SetPlacement), InPlacement); }
        public void Open(bool bFocusMenu) { Invoke(nameof(Open), bFocusMenu); }
        public bool IsOpen() { return Invoke<bool>(nameof(IsOpen)); }
        public bool HasOpenSubMenus() { return Invoke<bool>(nameof(HasOpenSubMenus)); }
        public UserWidget GetUserWidget__DelegateSignature() { return Invoke<UserWidget>(nameof(GetUserWidget__DelegateSignature)); }
        public Vector2D GetMenuPosition() { return Invoke<Vector2D>(nameof(GetMenuPosition)); }
        public void FitInWindow(bool bFit) { Invoke(nameof(FitInWindow), bFit); }
        public void Close() { Invoke(nameof(Close)); }
    }
    public class MultiLineEditableText : TextLayoutWidget
    {
        public MultiLineEditableText(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object HintText { get { return this[nameof(HintText)]; } set { this[nameof(HintText)] = value; } }
        public Object HintTextDelegate { get { return this[nameof(HintTextDelegate)]; } set { this[nameof(HintTextDelegate)] = value; } }
        public TextBlockStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<TextBlockStyle>(); } set { this["WidgetStyle"] = value; } }
        public bool bIsReadOnly { get { return this[nameof(bIsReadOnly)].Flag; } set { this[nameof(bIsReadOnly)].Flag = value; } }
        public bool SelectAllTextWhenFocused { get { return this[nameof(SelectAllTextWhenFocused)].Flag; } set { this[nameof(SelectAllTextWhenFocused)].Flag = value; } }
        public bool ClearTextSelectionOnFocusLoss { get { return this[nameof(ClearTextSelectionOnFocusLoss)].Flag; } set { this[nameof(ClearTextSelectionOnFocusLoss)].Flag = value; } }
        public bool RevertTextOnEscape { get { return this[nameof(RevertTextOnEscape)].Flag; } set { this[nameof(RevertTextOnEscape)].Flag = value; } }
        public bool ClearKeyboardFocusOnCommit { get { return this[nameof(ClearKeyboardFocusOnCommit)].Flag; } set { this[nameof(ClearKeyboardFocusOnCommit)].Flag = value; } }
        public bool AllowContextMenu { get { return this[nameof(AllowContextMenu)].Flag; } set { this[nameof(AllowContextMenu)].Flag = value; } }
        public VirtualKeyboardOptions VirtualKeyboardOptions { get { return this[nameof(VirtualKeyboardOptions)].As<VirtualKeyboardOptions>(); } set { this["VirtualKeyboardOptions"] = value; } }
        public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction { get { return (EVirtualKeyboardDismissAction)this[nameof(VirtualKeyboardDismissAction)].GetValue<int>(); } set { this[nameof(VirtualKeyboardDismissAction)].SetValue<int>((int)value); } }
        public Object OnTextChanged { get { return this[nameof(OnTextChanged)]; } set { this[nameof(OnTextChanged)] = value; } }
        public Object OnTextCommitted { get { return this[nameof(OnTextCommitted)]; } set { this[nameof(OnTextCommitted)] = value; } }
        public void SetWidgetStyle(TextBlockStyle InWidgetStyle) { Invoke(nameof(SetWidgetStyle), InWidgetStyle); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetIsReadOnly(bool bReadOnly) { Invoke(nameof(SetIsReadOnly), bReadOnly); }
        public void SetHintText(Object InHintText) { Invoke(nameof(SetHintText), InHintText); }
        public void SetFontOutlineMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontOutlineMaterial), InMaterial); }
        public void SetFontMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetFontMaterial), InMaterial); }
        public void SetFont(SlateFontInfo InFontInfo) { Invoke(nameof(SetFont), InFontInfo); }
        public void OnMultiLineEditableTextCommittedEvent__DelegateSignature(Object Text, byte CommitMethod) { Invoke(nameof(OnMultiLineEditableTextCommittedEvent__DelegateSignature), Text, CommitMethod); }
        public void OnMultiLineEditableTextChangedEvent__DelegateSignature(Object Text) { Invoke(nameof(OnMultiLineEditableTextChangedEvent__DelegateSignature), Text); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public Object GetHintText() { return Invoke<Object>(nameof(GetHintText)); }
        public SlateFontInfo GetFont() { return Invoke<SlateFontInfo>(nameof(GetFont)); }
    }
    public class MultiLineEditableTextBox : TextLayoutWidget
    {
        public MultiLineEditableTextBox(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object HintText { get { return this[nameof(HintText)]; } set { this[nameof(HintText)] = value; } }
        public Object HintTextDelegate { get { return this[nameof(HintTextDelegate)]; } set { this[nameof(HintTextDelegate)] = value; } }
        public EditableTextBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<EditableTextBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public bool bIsReadOnly { get { return this[nameof(bIsReadOnly)].Flag; } set { this[nameof(bIsReadOnly)].Flag = value; } }
        public bool AllowContextMenu { get { return this[nameof(AllowContextMenu)].Flag; } set { this[nameof(AllowContextMenu)].Flag = value; } }
        public VirtualKeyboardOptions VirtualKeyboardOptions { get { return this[nameof(VirtualKeyboardOptions)].As<VirtualKeyboardOptions>(); } set { this["VirtualKeyboardOptions"] = value; } }
        public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction { get { return (EVirtualKeyboardDismissAction)this[nameof(VirtualKeyboardDismissAction)].GetValue<int>(); } set { this[nameof(VirtualKeyboardDismissAction)].SetValue<int>((int)value); } }
        public Object OnTextChanged { get { return this[nameof(OnTextChanged)]; } set { this[nameof(OnTextChanged)] = value; } }
        public Object OnTextCommitted { get { return this[nameof(OnTextCommitted)]; } set { this[nameof(OnTextCommitted)] = value; } }
        public void SetTextStyle(TextBlockStyle InTextStyle) { Invoke(nameof(SetTextStyle), InTextStyle); }
        public void SetText(Object InText) { Invoke(nameof(SetText), InText); }
        public void SetIsReadOnly(bool bReadOnly) { Invoke(nameof(SetIsReadOnly), bReadOnly); }
        public void SetHintText(Object InHintText) { Invoke(nameof(SetHintText), InHintText); }
        public void SetForegroundColor(LinearColor Color) { Invoke(nameof(SetForegroundColor), Color); }
        public void SetError(Object InError) { Invoke(nameof(SetError), InError); }
        public void OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature(Object Text, byte CommitMethod) { Invoke(nameof(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature), Text, CommitMethod); }
        public void OnMultiLineEditableTextBoxChangedEvent__DelegateSignature(Object Text) { Invoke(nameof(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature), Text); }
        public Object GetText() { return Invoke<Object>(nameof(GetText)); }
        public Object GetHintText() { return Invoke<Object>(nameof(GetHintText)); }
    }
    public class NamedSlot : ContentWidget
    {
        public NamedSlot(nint addr) : base(addr) { }
    }
    public class NamedSlotInterface : Interface
    {
        public NamedSlotInterface(nint addr) : base(addr) { }
    }
    public class NativeWidgetHost : Widget
    {
        public NativeWidgetHost(nint addr) : base(addr) { }
    }
    public class SafeZone : ContentWidget
    {
        public SafeZone(nint addr) : base(addr) { }
        public bool PadLeft { get { return this[nameof(PadLeft)].Flag; } set { this[nameof(PadLeft)].Flag = value; } }
        public bool PadRight { get { return this[nameof(PadRight)].Flag; } set { this[nameof(PadRight)].Flag = value; } }
        public bool PadTop { get { return this[nameof(PadTop)].Flag; } set { this[nameof(PadTop)].Flag = value; } }
        public bool PadBottom { get { return this[nameof(PadBottom)].Flag; } set { this[nameof(PadBottom)].Flag = value; } }
        public void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom) { Invoke(nameof(SetSidesToPad), InPadLeft, InPadRight, InPadTop, InPadBottom); }
    }
    public class SafeZoneSlot : PanelSlot
    {
        public SafeZoneSlot(nint addr) : base(addr) { }
        public bool bIsTitleSafe { get { return this[nameof(bIsTitleSafe)].Flag; } set { this[nameof(bIsTitleSafe)].Flag = value; } }
        public Margin SafeAreaScale { get { return this[nameof(SafeAreaScale)].As<Margin>(); } set { this["SafeAreaScale"] = value; } }
        public byte HAlign { get { return this[nameof(HAlign)].GetValue<byte>(); } set { this[nameof(HAlign)].SetValue<byte>(value); } }
        public byte VAlign { get { return this[nameof(VAlign)].GetValue<byte>(); } set { this[nameof(VAlign)].SetValue<byte>(value); } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
    }
    public class ScaleBox : ContentWidget
    {
        public ScaleBox(nint addr) : base(addr) { }
        public byte Stretch { get { return this[nameof(Stretch)].GetValue<byte>(); } set { this[nameof(Stretch)].SetValue<byte>(value); } }
        public byte StretchDirection { get { return this[nameof(StretchDirection)].GetValue<byte>(); } set { this[nameof(StretchDirection)].SetValue<byte>(value); } }
        public float UserSpecifiedScale { get { return this[nameof(UserSpecifiedScale)].GetValue<float>(); } set { this[nameof(UserSpecifiedScale)].SetValue<float>(value); } }
        public bool IgnoreInheritedScale { get { return this[nameof(IgnoreInheritedScale)].Flag; } set { this[nameof(IgnoreInheritedScale)].Flag = value; } }
        public void SetUserSpecifiedScale(float InUserSpecifiedScale) { Invoke(nameof(SetUserSpecifiedScale), InUserSpecifiedScale); }
        public void SetStretchDirection(byte InStretchDirection) { Invoke(nameof(SetStretchDirection), InStretchDirection); }
        public void SetStretch(byte InStretch) { Invoke(nameof(SetStretch), InStretch); }
        public void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale) { Invoke(nameof(SetIgnoreInheritedScale), bInIgnoreInheritedScale); }
    }
    public class ScaleBoxSlot : PanelSlot
    {
        public ScaleBoxSlot(nint addr) : base(addr) { }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class ScrollBar : Widget
    {
        public ScrollBar(nint addr) : base(addr) { }
        public ScrollBarStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<ScrollBarStyle>(); } set { this["WidgetStyle"] = value; } }
        public bool bAlwaysShowScrollbar { get { return this[nameof(bAlwaysShowScrollbar)].Flag; } set { this[nameof(bAlwaysShowScrollbar)].Flag = value; } }
        public bool bAlwaysShowScrollbarTrack { get { return this[nameof(bAlwaysShowScrollbarTrack)].Flag; } set { this[nameof(bAlwaysShowScrollbarTrack)].Flag = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public Vector2D Thickness { get { return this[nameof(Thickness)].As<Vector2D>(); } set { this["Thickness"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public void SetState(float InOffsetFraction, float InThumbSizeFraction) { Invoke(nameof(SetState), InOffsetFraction, InThumbSizeFraction); }
    }
    public class ScrollBoxSlot : PanelSlot
    {
        public ScrollBoxSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class SizeBoxSlot : PanelSlot
    {
        public SizeBoxSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class Spacer : Widget
    {
        public Spacer(nint addr) : base(addr) { }
        public Vector2D Size { get { return this[nameof(Size)].As<Vector2D>(); } set { this["Size"] = value; } }
        public void SetSize(Vector2D InSize) { Invoke(nameof(SetSize), InSize); }
    }
    public class SpinBox : Widget
    {
        public SpinBox(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public SpinBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SpinBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public int MinFractionalDigits { get { return this[nameof(MinFractionalDigits)].GetValue<int>(); } set { this[nameof(MinFractionalDigits)].SetValue<int>(value); } }
        public int MaxFractionalDigits { get { return this[nameof(MaxFractionalDigits)].GetValue<int>(); } set { this[nameof(MaxFractionalDigits)].SetValue<int>(value); } }
        public bool bAlwaysUsesDeltaSnap { get { return this[nameof(bAlwaysUsesDeltaSnap)].Flag; } set { this[nameof(bAlwaysUsesDeltaSnap)].Flag = value; } }
        public bool bEnableSlider { get { return this[nameof(bEnableSlider)].Flag; } set { this[nameof(bEnableSlider)].Flag = value; } }
        public float Delta { get { return this[nameof(Delta)].GetValue<float>(); } set { this[nameof(Delta)].SetValue<float>(value); } }
        public float SliderExponent { get { return this[nameof(SliderExponent)].GetValue<float>(); } set { this[nameof(SliderExponent)].SetValue<float>(value); } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
        public float MinDesiredWidth { get { return this[nameof(MinDesiredWidth)].GetValue<float>(); } set { this[nameof(MinDesiredWidth)].SetValue<float>(value); } }
        public byte KeyboardType { get { return this[nameof(KeyboardType)].GetValue<byte>(); } set { this[nameof(KeyboardType)].SetValue<byte>(value); } }
        public bool ClearKeyboardFocusOnCommit { get { return this[nameof(ClearKeyboardFocusOnCommit)].Flag; } set { this[nameof(ClearKeyboardFocusOnCommit)].Flag = value; } }
        public bool SelectAllTextOnCommit { get { return this[nameof(SelectAllTextOnCommit)].Flag; } set { this[nameof(SelectAllTextOnCommit)].Flag = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public Object OnValueCommitted { get { return this[nameof(OnValueCommitted)]; } set { this[nameof(OnValueCommitted)] = value; } }
        public Object OnBeginSliderMovement { get { return this[nameof(OnBeginSliderMovement)]; } set { this[nameof(OnBeginSliderMovement)] = value; } }
        public Object OnEndSliderMovement { get { return this[nameof(OnEndSliderMovement)]; } set { this[nameof(OnEndSliderMovement)] = value; } }
        public bool bOverride_MinValue { get { return this[nameof(bOverride_MinValue)].Flag; } set { this[nameof(bOverride_MinValue)].Flag = value; } }
        public bool bOverride_MaxValue { get { return this[nameof(bOverride_MaxValue)].Flag; } set { this[nameof(bOverride_MaxValue)].Flag = value; } }
        public bool bOverride_MinSliderValue { get { return this[nameof(bOverride_MinSliderValue)].Flag; } set { this[nameof(bOverride_MinSliderValue)].Flag = value; } }
        public bool bOverride_MaxSliderValue { get { return this[nameof(bOverride_MaxSliderValue)].Flag; } set { this[nameof(bOverride_MaxSliderValue)].Flag = value; } }
        public float MinValue { get { return this[nameof(MinValue)].GetValue<float>(); } set { this[nameof(MinValue)].SetValue<float>(value); } }
        public float MaxValue { get { return this[nameof(MaxValue)].GetValue<float>(); } set { this[nameof(MaxValue)].SetValue<float>(value); } }
        public float MinSliderValue { get { return this[nameof(MinSliderValue)].GetValue<float>(); } set { this[nameof(MinSliderValue)].SetValue<float>(value); } }
        public float MaxSliderValue { get { return this[nameof(MaxSliderValue)].GetValue<float>(); } set { this[nameof(MaxSliderValue)].SetValue<float>(value); } }
        public void SetValue(float NewValue) { Invoke(nameof(SetValue), NewValue); }
        public void SetMinValue(float NewValue) { Invoke(nameof(SetMinValue), NewValue); }
        public void SetMinSliderValue(float NewValue) { Invoke(nameof(SetMinSliderValue), NewValue); }
        public void SetMinFractionalDigits(int NewValue) { Invoke(nameof(SetMinFractionalDigits), NewValue); }
        public void SetMaxValue(float NewValue) { Invoke(nameof(SetMaxValue), NewValue); }
        public void SetMaxSliderValue(float NewValue) { Invoke(nameof(SetMaxSliderValue), NewValue); }
        public void SetMaxFractionalDigits(int NewValue) { Invoke(nameof(SetMaxFractionalDigits), NewValue); }
        public void SetForegroundColor(SlateColor InForegroundColor) { Invoke(nameof(SetForegroundColor), InForegroundColor); }
        public void SetDelta(float NewValue) { Invoke(nameof(SetDelta), NewValue); }
        public void SetAlwaysUsesDeltaSnap(bool bNewValue) { Invoke(nameof(SetAlwaysUsesDeltaSnap), bNewValue); }
        public void OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, byte CommitMethod) { Invoke(nameof(OnSpinBoxValueCommittedEvent__DelegateSignature), InValue, CommitMethod); }
        public void OnSpinBoxValueChangedEvent__DelegateSignature(float InValue) { Invoke(nameof(OnSpinBoxValueChangedEvent__DelegateSignature), InValue); }
        public void OnSpinBoxBeginSliderMovement__DelegateSignature() { Invoke(nameof(OnSpinBoxBeginSliderMovement__DelegateSignature)); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public float GetMinValue() { return Invoke<float>(nameof(GetMinValue)); }
        public float GetMinSliderValue() { return Invoke<float>(nameof(GetMinSliderValue)); }
        public int GetMinFractionalDigits() { return Invoke<int>(nameof(GetMinFractionalDigits)); }
        public float GetMaxValue() { return Invoke<float>(nameof(GetMaxValue)); }
        public float GetMaxSliderValue() { return Invoke<float>(nameof(GetMaxSliderValue)); }
        public int GetMaxFractionalDigits() { return Invoke<int>(nameof(GetMaxFractionalDigits)); }
        public float GetDelta() { return Invoke<float>(nameof(GetDelta)); }
        public bool GetAlwaysUsesDeltaSnap() { return Invoke<bool>(nameof(GetAlwaysUsesDeltaSnap)); }
        public void ClearMinValue() { Invoke(nameof(ClearMinValue)); }
        public void ClearMinSliderValue() { Invoke(nameof(ClearMinSliderValue)); }
        public void ClearMaxValue() { Invoke(nameof(ClearMaxValue)); }
        public void ClearMaxSliderValue() { Invoke(nameof(ClearMaxSliderValue)); }
    }
    public class StackBox : PanelWidget
    {
        public StackBox(nint addr) : base(addr) { }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public StackBoxSlot AddChildToStackBox(Widget Content) { return Invoke<StackBoxSlot>(nameof(AddChildToStackBox), Content); }
    }
    public class StackBoxSlot : PanelSlot
    {
        public StackBoxSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public SlateChildSize Size { get { return this[nameof(Size)].As<SlateChildSize>(); } set { this["Size"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
    }
    public class Throbber : Widget
    {
        public Throbber(nint addr) : base(addr) { }
        public int NumberOfPieces { get { return this[nameof(NumberOfPieces)].GetValue<int>(); } set { this[nameof(NumberOfPieces)].SetValue<int>(value); } }
        public bool bAnimateHorizontally { get { return this[nameof(bAnimateHorizontally)].Flag; } set { this[nameof(bAnimateHorizontally)].Flag = value; } }
        public bool bAnimateVertically { get { return this[nameof(bAnimateVertically)].Flag; } set { this[nameof(bAnimateVertically)].Flag = value; } }
        public bool bAnimateOpacity { get { return this[nameof(bAnimateOpacity)].Flag; } set { this[nameof(bAnimateOpacity)].Flag = value; } }
        public SlateBrush Image { get { return this[nameof(Image)].As<SlateBrush>(); } set { this["Image"] = value; } }
        public void SetNumberOfPieces(int InNumberOfPieces) { Invoke(nameof(SetNumberOfPieces), InNumberOfPieces); }
        public void SetAnimateVertically(bool bInAnimateVertically) { Invoke(nameof(SetAnimateVertically), bInAnimateVertically); }
        public void SetAnimateOpacity(bool bInAnimateOpacity) { Invoke(nameof(SetAnimateOpacity), bInAnimateOpacity); }
        public void SetAnimateHorizontally(bool bInAnimateHorizontally) { Invoke(nameof(SetAnimateHorizontally), bInAnimateHorizontally); }
    }
    public class UniformGridPanel : PanelWidget
    {
        public UniformGridPanel(nint addr) : base(addr) { }
        public Margin SlotPadding { get { return this[nameof(SlotPadding)].As<Margin>(); } set { this["SlotPadding"] = value; } }
        public float MinDesiredSlotWidth { get { return this[nameof(MinDesiredSlotWidth)].GetValue<float>(); } set { this[nameof(MinDesiredSlotWidth)].SetValue<float>(value); } }
        public float MinDesiredSlotHeight { get { return this[nameof(MinDesiredSlotHeight)].GetValue<float>(); } set { this[nameof(MinDesiredSlotHeight)].SetValue<float>(value); } }
        public void SetSlotPadding(Margin InSlotPadding) { Invoke(nameof(SetSlotPadding), InSlotPadding); }
        public void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth) { Invoke(nameof(SetMinDesiredSlotWidth), InMinDesiredSlotWidth); }
        public void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight) { Invoke(nameof(SetMinDesiredSlotHeight), InMinDesiredSlotHeight); }
        public UniformGridSlot AddChildToUniformGrid(Widget Content, int InRow, int InColumn) { return Invoke<UniformGridSlot>(nameof(AddChildToUniformGrid), Content, InRow, InColumn); }
    }
    public class UniformGridSlot : PanelSlot
    {
        public UniformGridSlot(nint addr) : base(addr) { }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public int Row { get { return this[nameof(Row)].GetValue<int>(); } set { this[nameof(Row)].SetValue<int>(value); } }
        public int Column { get { return this[nameof(Column)].GetValue<int>(); } set { this[nameof(Column)].SetValue<int>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetRow(int InRow) { Invoke(nameof(SetRow), InRow); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public void SetColumn(int InColumn) { Invoke(nameof(SetColumn), InColumn); }
    }
    public class VerticalBox : PanelWidget
    {
        public VerticalBox(nint addr) : base(addr) { }
        public VerticalBoxSlot AddChildToVerticalBox(Widget Content) { return Invoke<VerticalBoxSlot>(nameof(AddChildToVerticalBox), Content); }
    }
    public class VerticalBoxSlot : PanelSlot
    {
        public VerticalBoxSlot(nint addr) : base(addr) { }
        public SlateChildSize Size { get { return this[nameof(Size)].As<SlateChildSize>(); } set { this["Size"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetSize(SlateChildSize InSize) { Invoke(nameof(SetSize), InSize); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class Viewport : ContentWidget
    {
        public Viewport(nint addr) : base(addr) { }
        public LinearColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<LinearColor>(); } set { this["BackgroundColor"] = value; } }
        public Actor Spawn(Object actorClass) { return Invoke<Actor>(nameof(Spawn), actorClass); }
        public void SetViewRotation(Rotator Rotation) { Invoke(nameof(SetViewRotation), Rotation); }
        public void SetViewLocation(Vector Location) { Invoke(nameof(SetViewLocation), Location); }
        public Rotator GetViewRotation() { return Invoke<Rotator>(nameof(GetViewRotation)); }
        public World GetViewportWorld() { return Invoke<World>(nameof(GetViewportWorld)); }
        public Vector GetViewLocation() { return Invoke<Vector>(nameof(GetViewLocation)); }
    }
    public class WidgetComponent : MeshComponent
    {
        public WidgetComponent(nint addr) : base(addr) { }
        public EWidgetSpace space { get { return (EWidgetSpace)this[nameof(space)].GetValue<int>(); } set { this[nameof(space)].SetValue<int>((int)value); } }
        public EWidgetTimingPolicy TimingPolicy { get { return (EWidgetTimingPolicy)this[nameof(TimingPolicy)].GetValue<int>(); } set { this[nameof(TimingPolicy)].SetValue<int>((int)value); } }
        public Object WidgetClass { get { return this[nameof(WidgetClass)]; } set { this[nameof(WidgetClass)] = value; } }
        public IntPoint DrawSize { get { return this[nameof(DrawSize)].As<IntPoint>(); } set { this["DrawSize"] = value; } }
        public bool bManuallyRedraw { get { return this[nameof(bManuallyRedraw)].Flag; } set { this[nameof(bManuallyRedraw)].Flag = value; } }
        public bool bRedrawRequested { get { return this[nameof(bRedrawRequested)].Flag; } set { this[nameof(bRedrawRequested)].Flag = value; } }
        public float RedrawTime { get { return this[nameof(RedrawTime)].GetValue<float>(); } set { this[nameof(RedrawTime)].SetValue<float>(value); } }
        public IntPoint CurrentDrawSize { get { return this[nameof(CurrentDrawSize)].As<IntPoint>(); } set { this["CurrentDrawSize"] = value; } }
        public bool bDrawAtDesiredSize { get { return this[nameof(bDrawAtDesiredSize)].Flag; } set { this[nameof(bDrawAtDesiredSize)].Flag = value; } }
        public Vector2D Pivot { get { return this[nameof(Pivot)].As<Vector2D>(); } set { this["Pivot"] = value; } }
        public bool bReceiveHardwareInput { get { return this[nameof(bReceiveHardwareInput)].Flag; } set { this[nameof(bReceiveHardwareInput)].Flag = value; } }
        public bool bWindowFocusable { get { return this[nameof(bWindowFocusable)].Flag; } set { this[nameof(bWindowFocusable)].Flag = value; } }
        public EWindowVisibility WindowVisibility { get { return (EWindowVisibility)this[nameof(WindowVisibility)].GetValue<int>(); } set { this[nameof(WindowVisibility)].SetValue<int>((int)value); } }
        public bool bApplyGammaCorrection { get { return this[nameof(bApplyGammaCorrection)].Flag; } set { this[nameof(bApplyGammaCorrection)].Flag = value; } }
        public LocalPlayer OwnerPlayer { get { return this[nameof(OwnerPlayer)].As<LocalPlayer>(); } set { this["OwnerPlayer"] = value; } }
        public LinearColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<LinearColor>(); } set { this["BackgroundColor"] = value; } }
        public LinearColor TintColorAndOpacity { get { return this[nameof(TintColorAndOpacity)].As<LinearColor>(); } set { this["TintColorAndOpacity"] = value; } }
        public float OpacityFromTexture { get { return this[nameof(OpacityFromTexture)].GetValue<float>(); } set { this[nameof(OpacityFromTexture)].SetValue<float>(value); } }
        public EWidgetBlendMode BlendMode { get { return (EWidgetBlendMode)this[nameof(BlendMode)].GetValue<int>(); } set { this[nameof(BlendMode)].SetValue<int>((int)value); } }
        public bool bIsTwoSided { get { return this[nameof(bIsTwoSided)].Flag; } set { this[nameof(bIsTwoSided)].Flag = value; } }
        public bool TickWhenOffscreen { get { return this[nameof(TickWhenOffscreen)].Flag; } set { this[nameof(TickWhenOffscreen)].Flag = value; } }
        public BodySetup BodySetup { get { return this[nameof(BodySetup)].As<BodySetup>(); } set { this["BodySetup"] = value; } }
        public MaterialInterface TranslucentMaterial { get { return this[nameof(TranslucentMaterial)].As<MaterialInterface>(); } set { this["TranslucentMaterial"] = value; } }
        public MaterialInterface TranslucentMaterial_OneSided { get { return this[nameof(TranslucentMaterial_OneSided)].As<MaterialInterface>(); } set { this["TranslucentMaterial_OneSided"] = value; } }
        public MaterialInterface OpaqueMaterial { get { return this[nameof(OpaqueMaterial)].As<MaterialInterface>(); } set { this["OpaqueMaterial"] = value; } }
        public MaterialInterface OpaqueMaterial_OneSided { get { return this[nameof(OpaqueMaterial_OneSided)].As<MaterialInterface>(); } set { this["OpaqueMaterial_OneSided"] = value; } }
        public MaterialInterface MaskedMaterial { get { return this[nameof(MaskedMaterial)].As<MaterialInterface>(); } set { this["MaskedMaterial"] = value; } }
        public MaterialInterface MaskedMaterial_OneSided { get { return this[nameof(MaskedMaterial_OneSided)].As<MaterialInterface>(); } set { this["MaskedMaterial_OneSided"] = value; } }
        public TextureRenderTarget2D RenderTarget { get { return this[nameof(RenderTarget)].As<TextureRenderTarget2D>(); } set { this["RenderTarget"] = value; } }
        public MaterialInstanceDynamic MaterialInstance { get { return this[nameof(MaterialInstance)].As<MaterialInstanceDynamic>(); } set { this["MaterialInstance"] = value; } }
        public bool bAddedToScreen { get { return this[nameof(bAddedToScreen)].Flag; } set { this[nameof(bAddedToScreen)].Flag = value; } }
        public bool bEditTimeUsable { get { return this[nameof(bEditTimeUsable)].Flag; } set { this[nameof(bEditTimeUsable)].Flag = value; } }
        public Object SharedLayerName { get { return this[nameof(SharedLayerName)]; } set { this[nameof(SharedLayerName)] = value; } }
        public int LayerZOrder { get { return this[nameof(LayerZOrder)].GetValue<int>(); } set { this[nameof(LayerZOrder)].SetValue<int>(value); } }
        public EWidgetGeometryMode GeometryMode { get { return (EWidgetGeometryMode)this[nameof(GeometryMode)].GetValue<int>(); } set { this[nameof(GeometryMode)].SetValue<int>((int)value); } }
        public float CylinderArcAngle { get { return this[nameof(CylinderArcAngle)].GetValue<float>(); } set { this[nameof(CylinderArcAngle)].SetValue<float>(value); } }
        public ETickMode TickMode { get { return (ETickMode)this[nameof(TickMode)].GetValue<int>(); } set { this[nameof(TickMode)].SetValue<int>((int)value); } }
        public UserWidget Widget { get { return this[nameof(Widget)].As<UserWidget>(); } set { this["Widget"] = value; } }
        public void SetWindowVisibility(EWindowVisibility InVisibility) { Invoke(nameof(SetWindowVisibility), InVisibility); }
        public void SetWindowFocusable(bool bInWindowFocusable) { Invoke(nameof(SetWindowFocusable), bInWindowFocusable); }
        public void SetWidgetSpace(EWidgetSpace NewSpace) { Invoke(nameof(SetWidgetSpace), NewSpace); }
        public void SetWidget(UserWidget Widget) { Invoke(nameof(SetWidget), Widget); }
        public void SetTwoSided(bool bWantTwoSided) { Invoke(nameof(SetTwoSided), bWantTwoSided); }
        public void SetTintColorAndOpacity(LinearColor NewTintColorAndOpacity) { Invoke(nameof(SetTintColorAndOpacity), NewTintColorAndOpacity); }
        public void SetTickWhenOffscreen(bool bWantTickWhenOffscreen) { Invoke(nameof(SetTickWhenOffscreen), bWantTickWhenOffscreen); }
        public void SetTickMode(ETickMode InTickMode) { Invoke(nameof(SetTickMode), InTickMode); }
        public void SetRedrawTime(float InRedrawTime) { Invoke(nameof(SetRedrawTime), InRedrawTime); }
        public void SetPivot(Vector2D InPivot) { Invoke(nameof(SetPivot), InPivot); }
        public void SetOwnerPlayer(LocalPlayer LocalPlayer) { Invoke(nameof(SetOwnerPlayer), LocalPlayer); }
        public void SetManuallyRedraw(bool bUseManualRedraw) { Invoke(nameof(SetManuallyRedraw), bUseManualRedraw); }
        public void SetGeometryMode(EWidgetGeometryMode InGeometryMode) { Invoke(nameof(SetGeometryMode), InGeometryMode); }
        public void SetDrawSize(Vector2D Size) { Invoke(nameof(SetDrawSize), Size); }
        public void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize) { Invoke(nameof(SetDrawAtDesiredSize), bInDrawAtDesiredSize); }
        public void SetCylinderArcAngle(float InCylinderArcAngle) { Invoke(nameof(SetCylinderArcAngle), InCylinderArcAngle); }
        public void SetBackgroundColor(LinearColor NewBackgroundColor) { Invoke(nameof(SetBackgroundColor), NewBackgroundColor); }
        public void RequestRenderUpdate() { Invoke(nameof(RequestRenderUpdate)); }
        public void RequestRedraw() { Invoke(nameof(RequestRedraw)); }
        public bool IsWidgetVisible() { return Invoke<bool>(nameof(IsWidgetVisible)); }
        public EWindowVisibility GetWindowVisiblility() { return Invoke<EWindowVisibility>(nameof(GetWindowVisiblility)); }
        public bool GetWindowFocusable() { return Invoke<bool>(nameof(GetWindowFocusable)); }
        public EWidgetSpace GetWidgetSpace() { return Invoke<EWidgetSpace>(nameof(GetWidgetSpace)); }
        public UserWidget GetWidget() { return Invoke<UserWidget>(nameof(GetWidget)); }
        public UserWidget GetUserWidgetObject() { return Invoke<UserWidget>(nameof(GetUserWidgetObject)); }
        public bool GetTwoSided() { return Invoke<bool>(nameof(GetTwoSided)); }
        public bool GetTickWhenOffscreen() { return Invoke<bool>(nameof(GetTickWhenOffscreen)); }
        public TextureRenderTarget2D GetRenderTarget() { return Invoke<TextureRenderTarget2D>(nameof(GetRenderTarget)); }
        public float GetRedrawTime() { return Invoke<float>(nameof(GetRedrawTime)); }
        public Vector2D GetPivot() { return Invoke<Vector2D>(nameof(GetPivot)); }
        public LocalPlayer GetOwnerPlayer() { return Invoke<LocalPlayer>(nameof(GetOwnerPlayer)); }
        public MaterialInstanceDynamic GetMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetMaterialInstance)); }
        public bool GetManuallyRedraw() { return Invoke<bool>(nameof(GetManuallyRedraw)); }
        public EWidgetGeometryMode GetGeometryMode() { return Invoke<EWidgetGeometryMode>(nameof(GetGeometryMode)); }
        public Vector2D GetDrawSize() { return Invoke<Vector2D>(nameof(GetDrawSize)); }
        public bool GetDrawAtDesiredSize() { return Invoke<bool>(nameof(GetDrawAtDesiredSize)); }
        public float GetCylinderArcAngle() { return Invoke<float>(nameof(GetCylinderArcAngle)); }
        public Vector2D GetCurrentDrawSize() { return Invoke<Vector2D>(nameof(GetCurrentDrawSize)); }
    }
    public class WidgetInteractionComponent : SceneComponent
    {
        public WidgetInteractionComponent(nint addr) : base(addr) { }
        public Object OnHoveredWidgetChanged { get { return this[nameof(OnHoveredWidgetChanged)]; } set { this[nameof(OnHoveredWidgetChanged)] = value; } }
        public int VirtualUserIndex { get { return this[nameof(VirtualUserIndex)].GetValue<int>(); } set { this[nameof(VirtualUserIndex)].SetValue<int>(value); } }
        public int PointerIndex { get { return this[nameof(PointerIndex)].GetValue<int>(); } set { this[nameof(PointerIndex)].SetValue<int>(value); } }
        public byte TraceChannel { get { return this[nameof(TraceChannel)].GetValue<byte>(); } set { this[nameof(TraceChannel)].SetValue<byte>(value); } }
        public float InteractionDistance { get { return this[nameof(InteractionDistance)].GetValue<float>(); } set { this[nameof(InteractionDistance)].SetValue<float>(value); } }
        public EWidgetInteractionSource InteractionSource { get { return (EWidgetInteractionSource)this[nameof(InteractionSource)].GetValue<int>(); } set { this[nameof(InteractionSource)].SetValue<int>((int)value); } }
        public bool bEnableHitTesting { get { return this[nameof(bEnableHitTesting)].Flag; } set { this[nameof(bEnableHitTesting)].Flag = value; } }
        public bool bShowDebug { get { return this[nameof(bShowDebug)].Flag; } set { this[nameof(bShowDebug)].Flag = value; } }
        public float DebugSphereLineThickness { get { return this[nameof(DebugSphereLineThickness)].GetValue<float>(); } set { this[nameof(DebugSphereLineThickness)].SetValue<float>(value); } }
        public float DebugLineThickness { get { return this[nameof(DebugLineThickness)].GetValue<float>(); } set { this[nameof(DebugLineThickness)].SetValue<float>(value); } }
        public LinearColor DebugColor { get { return this[nameof(DebugColor)].As<LinearColor>(); } set { this["DebugColor"] = value; } }
        public HitResult CustomHitResult { get { return this[nameof(CustomHitResult)].As<HitResult>(); } set { this["CustomHitResult"] = value; } }
        public Vector2D LocalHitLocation { get { return this[nameof(LocalHitLocation)].As<Vector2D>(); } set { this["LocalHitLocation"] = value; } }
        public Vector2D LastLocalHitLocation { get { return this[nameof(LastLocalHitLocation)].As<Vector2D>(); } set { this["LastLocalHitLocation"] = value; } }
        public WidgetComponent HoveredWidgetComponent { get { return this[nameof(HoveredWidgetComponent)].As<WidgetComponent>(); } set { this["HoveredWidgetComponent"] = value; } }
        public HitResult LastHitResult { get { return this[nameof(LastHitResult)].As<HitResult>(); } set { this["LastHitResult"] = value; } }
        public bool bIsHoveredWidgetInteractable { get { return this[nameof(bIsHoveredWidgetInteractable)].Flag; } set { this[nameof(bIsHoveredWidgetInteractable)].Flag = value; } }
        public bool bIsHoveredWidgetFocusable { get { return this[nameof(bIsHoveredWidgetFocusable)].Flag; } set { this[nameof(bIsHoveredWidgetFocusable)].Flag = value; } }
        public bool bIsHoveredWidgetHitTestVisible { get { return this[nameof(bIsHoveredWidgetHitTestVisible)].Flag; } set { this[nameof(bIsHoveredWidgetHitTestVisible)].Flag = value; } }
        public void SetFocus(Widget FocusWidget) { Invoke(nameof(SetFocus), FocusWidget); }
        public void SetCustomHitResult(HitResult HitResult) { Invoke(nameof(SetCustomHitResult), HitResult); }
        public bool SendKeyChar(Object Characters, bool bRepeat) { return Invoke<bool>(nameof(SendKeyChar), Characters, bRepeat); }
        public void ScrollWheel(float ScrollDelta) { Invoke(nameof(ScrollWheel), ScrollDelta); }
        public void ReleasePointerKey(Key Key) { Invoke(nameof(ReleasePointerKey), Key); }
        public bool ReleaseKey(Key Key) { return Invoke<bool>(nameof(ReleaseKey), Key); }
        public void PressPointerKey(Key Key) { Invoke(nameof(PressPointerKey), Key); }
        public bool PressKey(Key Key, bool bRepeat) { return Invoke<bool>(nameof(PressKey), Key, bRepeat); }
        public bool PressAndReleaseKey(Key Key) { return Invoke<bool>(nameof(PressAndReleaseKey), Key); }
        public bool IsOverInteractableWidget() { return Invoke<bool>(nameof(IsOverInteractableWidget)); }
        public bool IsOverHitTestVisibleWidget() { return Invoke<bool>(nameof(IsOverHitTestVisibleWidget)); }
        public bool IsOverFocusableWidget() { return Invoke<bool>(nameof(IsOverFocusableWidget)); }
        public HitResult GetLastHitResult() { return Invoke<HitResult>(nameof(GetLastHitResult)); }
        public WidgetComponent GetHoveredWidgetComponent() { return Invoke<WidgetComponent>(nameof(GetHoveredWidgetComponent)); }
        public Vector2D Get2DHitLocation() { return Invoke<Vector2D>(nameof(Get2DHitLocation)); }
    }
    public class WidgetSwitcherSlot : PanelSlot
    {
        public WidgetSwitcherSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class WindowTitleBarArea : ContentWidget
    {
        public WindowTitleBarArea(nint addr) : base(addr) { }
        public bool bWindowButtonsEnabled { get { return this[nameof(bWindowButtonsEnabled)].Flag; } set { this[nameof(bWindowButtonsEnabled)].Flag = value; } }
        public bool bDoubleClickTogglesFullscreen { get { return this[nameof(bDoubleClickTogglesFullscreen)].Flag; } set { this[nameof(bDoubleClickTogglesFullscreen)].Flag = value; } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class WindowTitleBarAreaSlot : PanelSlot
    {
        public WindowTitleBarAreaSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
    }
    public class WrapBox : PanelWidget
    {
        public WrapBox(nint addr) : base(addr) { }
        public Vector2D InnerSlotPadding { get { return this[nameof(InnerSlotPadding)].As<Vector2D>(); } set { this["InnerSlotPadding"] = value; } }
        public float WrapSize { get { return this[nameof(WrapSize)].GetValue<float>(); } set { this[nameof(WrapSize)].SetValue<float>(value); } }
        public bool bExplicitWrapSize { get { return this[nameof(bExplicitWrapSize)].Flag; } set { this[nameof(bExplicitWrapSize)].Flag = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public void SetInnerSlotPadding(Vector2D InPadding) { Invoke(nameof(SetInnerSlotPadding), InPadding); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public WrapBoxSlot AddChildToWrapBox(Widget Content) { return Invoke<WrapBoxSlot>(nameof(AddChildToWrapBox), Content); }
    }
    public class WrapBoxSlot : PanelSlot
    {
        public WrapBoxSlot(nint addr) : base(addr) { }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public float FillSpanWhenLessThan { get { return this[nameof(FillSpanWhenLessThan)].GetValue<float>(); } set { this[nameof(FillSpanWhenLessThan)].SetValue<float>(value); } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public bool bFillEmptySpace { get { return this[nameof(bFillEmptySpace)].Flag; } set { this[nameof(bFillEmptySpace)].Flag = value; } }
        public bool bForceNewLine { get { return this[nameof(bForceNewLine)].Flag; } set { this[nameof(bForceNewLine)].Flag = value; } }
        public void SetVerticalAlignment(byte InVerticalAlignment) { Invoke(nameof(SetVerticalAlignment), InVerticalAlignment); }
        public void SetPadding(Margin InPadding) { Invoke(nameof(SetPadding), InPadding); }
        public void SetNewLine(bool InForceNewLine) { Invoke(nameof(SetNewLine), InForceNewLine); }
        public void SetHorizontalAlignment(byte InHorizontalAlignment) { Invoke(nameof(SetHorizontalAlignment), InHorizontalAlignment); }
        public void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan) { Invoke(nameof(SetFillSpanWhenLessThan), InFillSpanWhenLessThan); }
        public void SetFillEmptySpace(bool InbFillEmptySpace) { Invoke(nameof(SetFillEmptySpace), InbFillEmptySpace); }
    }
    public class DragDropOperation : Object
    {
        public DragDropOperation(nint addr) : base(addr) { }
        public Object Tag { get { return this[nameof(Tag)]; } set { this[nameof(Tag)] = value; } }
        public Object Payload { get { return this[nameof(Payload)].As<Object>(); } set { this["Payload"] = value; } }
        public Widget DefaultDragVisual { get { return this[nameof(DefaultDragVisual)].As<Widget>(); } set { this["DefaultDragVisual"] = value; } }
        public EDragPivot Pivot { get { return (EDragPivot)this[nameof(Pivot)].GetValue<int>(); } set { this[nameof(Pivot)].SetValue<int>((int)value); } }
        public Vector2D Offset { get { return this[nameof(Offset)].As<Vector2D>(); } set { this["Offset"] = value; } }
        public Object OnDrop { get { return this[nameof(OnDrop)]; } set { this[nameof(OnDrop)] = value; } }
        public Object OnDragCancelled { get { return this[nameof(OnDragCancelled)]; } set { this[nameof(OnDragCancelled)] = value; } }
        public Object OnDragged { get { return this[nameof(OnDragged)]; } set { this[nameof(OnDragged)] = value; } }
        public void Drop(PointerEvent PointerEvent) { Invoke(nameof(Drop), PointerEvent); }
        public void Dragged(PointerEvent PointerEvent) { Invoke(nameof(Dragged), PointerEvent); }
        public void DragCancelled(PointerEvent PointerEvent) { Invoke(nameof(DragCancelled), PointerEvent); }
    }
    public class SlateBlueprintLibrary : BlueprintFunctionLibrary
    {
        public SlateBlueprintLibrary(nint addr) : base(addr) { }
        public Vector2D TransformVectorLocalToAbsolute(Geometry Geometry, Vector2D LocalVector) { return Invoke<Vector2D>(nameof(TransformVectorLocalToAbsolute), Geometry, LocalVector); }
        public Vector2D TransformVectorAbsoluteToLocal(Geometry Geometry, Vector2D AbsoluteVector) { return Invoke<Vector2D>(nameof(TransformVectorAbsoluteToLocal), Geometry, AbsoluteVector); }
        public float TransformScalarLocalToAbsolute(Geometry Geometry, float LocalScalar) { return Invoke<float>(nameof(TransformScalarLocalToAbsolute), Geometry, LocalScalar); }
        public float TransformScalarAbsoluteToLocal(Geometry Geometry, float AbsoluteScalar) { return Invoke<float>(nameof(TransformScalarAbsoluteToLocal), Geometry, AbsoluteScalar); }
        public void ScreenToWidgetLocal(Object WorldContextObject, Geometry Geometry, Vector2D ScreenPosition, Vector2D LocalCoordinate, bool bIncludeWindowPosition) { Invoke(nameof(ScreenToWidgetLocal), WorldContextObject, Geometry, ScreenPosition, LocalCoordinate, bIncludeWindowPosition); }
        public void ScreenToWidgetAbsolute(Object WorldContextObject, Vector2D ScreenPosition, Vector2D AbsoluteCoordinate, bool bIncludeWindowPosition) { Invoke(nameof(ScreenToWidgetAbsolute), WorldContextObject, ScreenPosition, AbsoluteCoordinate, bIncludeWindowPosition); }
        public void ScreenToViewport(Object WorldContextObject, Vector2D ScreenPosition, Vector2D ViewportPosition) { Invoke(nameof(ScreenToViewport), WorldContextObject, ScreenPosition, ViewportPosition); }
        public void LocalToViewport(Object WorldContextObject, Geometry Geometry, Vector2D LocalCoordinate, Vector2D PixelPosition, Vector2D ViewportPosition) { Invoke(nameof(LocalToViewport), WorldContextObject, Geometry, LocalCoordinate, PixelPosition, ViewportPosition); }
        public Vector2D LocalToAbsolute(Geometry Geometry, Vector2D LocalCoordinate) { return Invoke<Vector2D>(nameof(LocalToAbsolute), Geometry, LocalCoordinate); }
        public bool IsUnderLocation(Geometry Geometry, Vector2D AbsoluteCoordinate) { return Invoke<bool>(nameof(IsUnderLocation), Geometry, AbsoluteCoordinate); }
        public Vector2D GetLocalTopLeft(Geometry Geometry) { return Invoke<Vector2D>(nameof(GetLocalTopLeft), Geometry); }
        public Vector2D GetLocalSize(Geometry Geometry) { return Invoke<Vector2D>(nameof(GetLocalSize), Geometry); }
        public Vector2D GetAbsoluteSize(Geometry Geometry) { return Invoke<Vector2D>(nameof(GetAbsoluteSize), Geometry); }
        public bool EqualEqual_SlateBrush(SlateBrush A, SlateBrush B) { return Invoke<bool>(nameof(EqualEqual_SlateBrush), A, B); }
        public void AbsoluteToViewport(Object WorldContextObject, Vector2D AbsoluteDesktopCoordinate, Vector2D PixelPosition, Vector2D ViewportPosition) { Invoke(nameof(AbsoluteToViewport), WorldContextObject, AbsoluteDesktopCoordinate, PixelPosition, ViewportPosition); }
        public Vector2D AbsoluteToLocal(Geometry Geometry, Vector2D AbsoluteCoordinate) { return Invoke<Vector2D>(nameof(AbsoluteToLocal), Geometry, AbsoluteCoordinate); }
    }
    public class SlateVectorArtData : Object
    {
        public SlateVectorArtData(nint addr) : base(addr) { }
        public Array<SlateMeshVertex> VertexData { get { return new Array<SlateMeshVertex>(this[nameof(VertexData)].Address); } }
        public Array<uint> IndexData { get { return new Array<uint>(this[nameof(IndexData)].Address); } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public Vector2D ExtentMin { get { return this[nameof(ExtentMin)].As<Vector2D>(); } set { this["ExtentMin"] = value; } }
        public Vector2D ExtentMax { get { return this[nameof(ExtentMax)].As<Vector2D>(); } set { this["ExtentMax"] = value; } }
    }
    public class WidgetBlueprintGeneratedClass : BlueprintGeneratedClass
    {
        public WidgetBlueprintGeneratedClass(nint addr) : base(addr) { }
        public WidgetTree WidgetTree { get { return this[nameof(WidgetTree)].As<WidgetTree>(); } set { this["WidgetTree"] = value; } }
        public Array<WidgetBlueprintGeneratedClassExtension> Extensions { get { return new Array<WidgetBlueprintGeneratedClassExtension>(this[nameof(Extensions)].Address); } }
        public Array<FieldNotificationId> FieldNotifyNames { get { return new Array<FieldNotificationId>(this[nameof(FieldNotifyNames)].Address); } }
        public bool bClassRequiresNativeTick { get { return this[nameof(bClassRequiresNativeTick)].Flag; } set { this[nameof(bClassRequiresNativeTick)].Flag = value; } }
        public Array<DelegateRuntimeBinding> Bindings { get { return new Array<DelegateRuntimeBinding>(this[nameof(Bindings)].Address); } }
        public Array<WidgetAnimation> Animations { get { return new Array<WidgetAnimation>(this[nameof(Animations)].Address); } }
        public Array<Object> NamedSlots { get { return new Array<Object>(this[nameof(NamedSlots)].Address); } }
        public Array<Object> AvailableNamedSlots { get { return new Array<Object>(this[nameof(AvailableNamedSlots)].Address); } }
        public Array<Object> InstanceNamedSlots { get { return new Array<Object>(this[nameof(InstanceNamedSlots)].Address); } }
    }
    public class WidgetBlueprintLibrary : BlueprintFunctionLibrary
    {
        public WidgetBlueprintLibrary(nint addr) : base(addr) { }
        public EventReply UnlockMouse(EventReply Reply) { return Invoke<EventReply>(nameof(UnlockMouse), Reply); }
        public EventReply Unhandled() { return Invoke<EventReply>(nameof(Unhandled)); }
        public void SetWindowTitleBarState(Widget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible) { Invoke(nameof(SetWindowTitleBarState), TitleBarContent, Mode, bTitleBarDragEnabled, bWindowButtonsVisible, bTitleBarVisible); }
        public void SetWindowTitleBarOnCloseClickedDelegate(Object Delegate) { Invoke(nameof(SetWindowTitleBarOnCloseClickedDelegate), Delegate); }
        public void SetWindowTitleBarCloseButtonActive(bool bActive) { Invoke(nameof(SetWindowTitleBarCloseButtonActive), bActive); }
        public EventReply SetUserFocus(EventReply Reply, Widget FocusWidget, bool bInAllUsers) { return Invoke<EventReply>(nameof(SetUserFocus), Reply, FocusWidget, bInAllUsers); }
        public EventReply SetMousePosition(EventReply Reply, Vector2D NewMousePosition) { return Invoke<EventReply>(nameof(SetMousePosition), Reply, NewMousePosition); }
        public void SetInputMode_UIOnlyEx(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bFlushInput) { Invoke(nameof(SetInputMode_UIOnlyEx), PlayerController, InWidgetToFocus, InMouseLockMode, bFlushInput); }
        public void SetInputMode_GameOnly(PlayerController PlayerController, bool bFlushInput) { Invoke(nameof(SetInputMode_GameOnly), PlayerController, bFlushInput); }
        public void SetInputMode_GameAndUIEx(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture, bool bFlushInput) { Invoke(nameof(SetInputMode_GameAndUIEx), PlayerController, InWidgetToFocus, InMouseLockMode, bHideCursorDuringCapture, bFlushInput); }
        public bool SetHardwareCursor(Object WorldContextObject, byte CursorShape, Object CursorName, Vector2D HotSpot) { return Invoke<bool>(nameof(SetHardwareCursor), WorldContextObject, CursorShape, CursorName, HotSpot); }
        public void SetFocusToGameViewport() { Invoke(nameof(SetFocusToGameViewport)); }
        public void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency) { Invoke(nameof(SetColorVisionDeficiencyType), Type, Severity, CorrectDeficiency, ShowCorrectionWithDeficiency); }
        public void SetBrushResourceToTexture(SlateBrush Brush, Texture2D Texture) { Invoke(nameof(SetBrushResourceToTexture), Brush, Texture); }
        public void SetBrushResourceToMaterial(SlateBrush Brush, MaterialInterface Material) { Invoke(nameof(SetBrushResourceToMaterial), Brush, Material); }
        public void RestorePreviousWindowTitleBarState() { Invoke(nameof(RestorePreviousWindowTitleBarState)); }
        public EventReply ReleaseMouseCapture(EventReply Reply) { return Invoke<EventReply>(nameof(ReleaseMouseCapture), Reply); }
        public EventReply ReleaseJoystickCapture(EventReply Reply, bool bInAllJoysticks) { return Invoke<EventReply>(nameof(ReleaseJoystickCapture), Reply, bInAllJoysticks); }
        public void OnGameWindowCloseButtonClickedDelegate__DelegateSignature() { Invoke(nameof(OnGameWindowCloseButtonClickedDelegate__DelegateSignature)); }
        public SlateBrush NoResourceBrush() { return Invoke<SlateBrush>(nameof(NoResourceBrush)); }
        public SlateBrush MakeBrushFromTexture(Texture2D Texture, int Width, int Height) { return Invoke<SlateBrush>(nameof(MakeBrushFromTexture), Texture, Width, Height); }
        public SlateBrush MakeBrushFromMaterial(MaterialInterface Material, int Width, int Height) { return Invoke<SlateBrush>(nameof(MakeBrushFromMaterial), Material, Width, Height); }
        public SlateBrush MakeBrushFromAsset(SlateBrushAsset BrushAsset) { return Invoke<SlateBrush>(nameof(MakeBrushFromAsset), BrushAsset); }
        public EventReply LockMouse(EventReply Reply, Widget CapturingWidget) { return Invoke<EventReply>(nameof(LockMouse), Reply, CapturingWidget); }
        public bool IsDragDropping() { return Invoke<bool>(nameof(IsDragDropping)); }
        public EventReply Handled() { return Invoke<EventReply>(nameof(Handled)); }
        public void GetSafeZonePadding(Object WorldContextObject, Vector4 SafePadding, Vector2D SafePaddingScale, Vector4 SpillOverPadding) { Invoke(nameof(GetSafeZonePadding), WorldContextObject, SafePadding, SafePaddingScale, SpillOverPadding); }
        public KeyEvent GetKeyEventFromAnalogInputEvent(AnalogInputEvent Event) { return Invoke<KeyEvent>(nameof(GetKeyEventFromAnalogInputEvent), Event); }
        public InputEvent GetInputEventFromPointerEvent(PointerEvent Event) { return Invoke<InputEvent>(nameof(GetInputEventFromPointerEvent), Event); }
        public InputEvent GetInputEventFromNavigationEvent(NavigationEvent Event) { return Invoke<InputEvent>(nameof(GetInputEventFromNavigationEvent), Event); }
        public InputEvent GetInputEventFromKeyEvent(KeyEvent Event) { return Invoke<InputEvent>(nameof(GetInputEventFromKeyEvent), Event); }
        public InputEvent GetInputEventFromCharacterEvent(CharacterEvent Event) { return Invoke<InputEvent>(nameof(GetInputEventFromCharacterEvent), Event); }
        public MaterialInstanceDynamic GetDynamicMaterial(SlateBrush Brush) { return Invoke<MaterialInstanceDynamic>(nameof(GetDynamicMaterial), Brush); }
        public DragDropOperation GetDragDroppingContent() { return Invoke<DragDropOperation>(nameof(GetDragDroppingContent)); }
        public Texture2D GetBrushResourceAsTexture2D(SlateBrush Brush) { return Invoke<Texture2D>(nameof(GetBrushResourceAsTexture2D), Brush); }
        public MaterialInterface GetBrushResourceAsMaterial(SlateBrush Brush) { return Invoke<MaterialInterface>(nameof(GetBrushResourceAsMaterial), Brush); }
        public Object GetBrushResource(SlateBrush Brush) { return Invoke<Object>(nameof(GetBrushResource), Brush); }
        public void GetAllWidgetsWithInterface(Object WorldContextObject, Array<UserWidget> FoundWidgets, Object Interface, bool TopLevelOnly) { Invoke(nameof(GetAllWidgetsWithInterface), WorldContextObject, FoundWidgets, Interface, TopLevelOnly); }
        public void GetAllWidgetsOfClass(Object WorldContextObject, Array<UserWidget> FoundWidgets, Object WidgetClass, bool TopLevelOnly) { Invoke(nameof(GetAllWidgetsOfClass), WorldContextObject, FoundWidgets, WidgetClass, TopLevelOnly); }
        public EventReply EndDragDrop(EventReply Reply) { return Invoke<EventReply>(nameof(EndDragDrop), Reply); }
        public void DrawTextFormatted(PaintContext Context, Object Text, Vector2D Position, Font Font, int FontSize, Object FontTypeFace, LinearColor Tint) { Invoke(nameof(DrawTextFormatted), Context, Text, Position, Font, FontSize, FontTypeFace, Tint); }
        public void DrawText(PaintContext Context, Object InString, Vector2D Position, LinearColor Tint) { Invoke(nameof(DrawText), Context, InString, Position, Tint); }
        public void DrawSpline(PaintContext Context, Vector2D Start, Vector2D StartDir, Vector2D End, Vector2D EndDir, LinearColor Tint, float Thickness) { Invoke(nameof(DrawSpline), Context, Start, StartDir, End, EndDir, Tint, Thickness); }
        public void DrawLines(PaintContext Context, Array<Vector2D> Points, LinearColor Tint, bool bAntiAlias, float Thickness) { Invoke(nameof(DrawLines), Context, Points, Tint, bAntiAlias, Thickness); }
        public void DrawLine(PaintContext Context, Vector2D PositionA, Vector2D PositionB, LinearColor Tint, bool bAntiAlias, float Thickness) { Invoke(nameof(DrawLine), Context, PositionA, PositionB, Tint, bAntiAlias, Thickness); }
        public void DrawBox(PaintContext Context, Vector2D Position, Vector2D Size, SlateBrushAsset Brush, LinearColor Tint) { Invoke(nameof(DrawBox), Context, Position, Size, Brush, Tint); }
        public void DismissAllMenus() { Invoke(nameof(DismissAllMenus)); }
        public EventReply DetectDragIfPressed(PointerEvent PointerEvent, Widget WidgetDetectingDrag, Key DragKey) { return Invoke<EventReply>(nameof(DetectDragIfPressed), PointerEvent, WidgetDetectingDrag, DragKey); }
        public EventReply DetectDrag(EventReply Reply, Widget WidgetDetectingDrag, Key DragKey) { return Invoke<EventReply>(nameof(DetectDrag), Reply, WidgetDetectingDrag, DragKey); }
        public DragDropOperation CreateDragDropOperation(Object OperationClass) { return Invoke<DragDropOperation>(nameof(CreateDragDropOperation), OperationClass); }
        public UserWidget Create(Object WorldContextObject, Object WidgetType, PlayerController OwningPlayer) { return Invoke<UserWidget>(nameof(Create), WorldContextObject, WidgetType, OwningPlayer); }
        public EventReply ClearUserFocus(EventReply Reply, bool bInAllUsers) { return Invoke<EventReply>(nameof(ClearUserFocus), Reply, bInAllUsers); }
        public EventReply CaptureMouse(EventReply Reply, Widget CapturingWidget) { return Invoke<EventReply>(nameof(CaptureMouse), Reply, CapturingWidget); }
        public EventReply CaptureJoystick(EventReply Reply, Widget CapturingWidget, bool bInAllJoysticks) { return Invoke<EventReply>(nameof(CaptureJoystick), Reply, CapturingWidget, bInAllJoysticks); }
        public void CancelDragDrop() { Invoke(nameof(CancelDragDrop)); }
    }
    public class WidgetLayoutLibrary : BlueprintFunctionLibrary
    {
        public WidgetLayoutLibrary(nint addr) : base(addr) { }
        public WrapBoxSlot SlotAsWrapBoxSlot(Widget Widget) { return Invoke<WrapBoxSlot>(nameof(SlotAsWrapBoxSlot), Widget); }
        public WidgetSwitcherSlot SlotAsWidgetSwitcherSlot(Widget Widget) { return Invoke<WidgetSwitcherSlot>(nameof(SlotAsWidgetSwitcherSlot), Widget); }
        public VerticalBoxSlot SlotAsVerticalBoxSlot(Widget Widget) { return Invoke<VerticalBoxSlot>(nameof(SlotAsVerticalBoxSlot), Widget); }
        public UniformGridSlot SlotAsUniformGridSlot(Widget Widget) { return Invoke<UniformGridSlot>(nameof(SlotAsUniformGridSlot), Widget); }
        public SizeBoxSlot SlotAsSizeBoxSlot(Widget Widget) { return Invoke<SizeBoxSlot>(nameof(SlotAsSizeBoxSlot), Widget); }
        public ScrollBoxSlot SlotAsScrollBoxSlot(Widget Widget) { return Invoke<ScrollBoxSlot>(nameof(SlotAsScrollBoxSlot), Widget); }
        public ScaleBoxSlot SlotAsScaleBoxSlot(Widget Widget) { return Invoke<ScaleBoxSlot>(nameof(SlotAsScaleBoxSlot), Widget); }
        public SafeZoneSlot SlotAsSafeBoxSlot(Widget Widget) { return Invoke<SafeZoneSlot>(nameof(SlotAsSafeBoxSlot), Widget); }
        public OverlaySlot SlotAsOverlaySlot(Widget Widget) { return Invoke<OverlaySlot>(nameof(SlotAsOverlaySlot), Widget); }
        public HorizontalBoxSlot SlotAsHorizontalBoxSlot(Widget Widget) { return Invoke<HorizontalBoxSlot>(nameof(SlotAsHorizontalBoxSlot), Widget); }
        public GridSlot SlotAsGridSlot(Widget Widget) { return Invoke<GridSlot>(nameof(SlotAsGridSlot), Widget); }
        public CanvasPanelSlot SlotAsCanvasSlot(Widget Widget) { return Invoke<CanvasPanelSlot>(nameof(SlotAsCanvasSlot), Widget); }
        public BorderSlot SlotAsBorderSlot(Widget Widget) { return Invoke<BorderSlot>(nameof(SlotAsBorderSlot), Widget); }
        public void RemoveAllWidgets(Object WorldContextObject) { Invoke(nameof(RemoveAllWidgets), WorldContextObject); }
        public bool ProjectWorldLocationToWidgetPosition(PlayerController PlayerController, Vector WorldLocation, Vector2D ScreenPosition, bool bPlayerViewportRelative) { return Invoke<bool>(nameof(ProjectWorldLocationToWidgetPosition), PlayerController, WorldLocation, ScreenPosition, bPlayerViewportRelative); }
        public Geometry GetViewportWidgetGeometry(Object WorldContextObject) { return Invoke<Geometry>(nameof(GetViewportWidgetGeometry), WorldContextObject); }
        public Vector2D GetViewportSize(Object WorldContextObject) { return Invoke<Vector2D>(nameof(GetViewportSize), WorldContextObject); }
        public float GetViewportScale(Object WorldContextObject) { return Invoke<float>(nameof(GetViewportScale), WorldContextObject); }
        public Geometry GetPlayerScreenWidgetGeometry(PlayerController PlayerController) { return Invoke<Geometry>(nameof(GetPlayerScreenWidgetGeometry), PlayerController); }
        public bool GetMousePositionScaledByDPI(PlayerController Player, float LocationX, float LocationY) { return Invoke<bool>(nameof(GetMousePositionScaledByDPI), Player, LocationX, LocationY); }
        public Vector2D GetMousePositionOnViewport(Object WorldContextObject) { return Invoke<Vector2D>(nameof(GetMousePositionOnViewport), WorldContextObject); }
        public Vector2D GetMousePositionOnPlatform() { return Invoke<Vector2D>(nameof(GetMousePositionOnPlatform)); }
    }
    public class WidgetTree : Object
    {
        public WidgetTree(nint addr) : base(addr) { }
        public Widget RootWidget { get { return this[nameof(RootWidget)].As<Widget>(); } set { this["RootWidget"] = value; } }
        public Object NamedSlotBindings { get { return this[nameof(NamedSlotBindings)]; } set { this[nameof(NamedSlotBindings)] = value; } }
    }
    public enum ESlateVisibility : int
    {
        Visible = 0,
        Collapsed = 1,
        Hidden = 2,
        HitTestInvisible = 3,
        SelfHitTestInvisible = 4,
        ESlateVisibility_MAX = 5,
    }
    public class FieldNotificationId : Object
    {
        public FieldNotificationId(nint addr) : base(addr) { }
        public Object FieldName { get { return this[nameof(FieldName)]; } set { this[nameof(FieldName)] = value; } }
    }
    public class EventReply : Object
    {
        public EventReply(nint addr) : base(addr) { }
    }
    public class WidgetTransform : Object
    {
        public WidgetTransform(nint addr) : base(addr) { }
        public Vector2D Translation { get { return this[nameof(Translation)].As<Vector2D>(); } set { this["Translation"] = value; } }
        public Vector2D Scale { get { return this[nameof(Scale)].As<Vector2D>(); } set { this["Scale"] = value; } }
        public Vector2D Shear { get { return this[nameof(Shear)].As<Vector2D>(); } set { this["Shear"] = value; } }
        public float Angle { get { return this[nameof(Angle)].GetValue<float>(); } set { this[nameof(Angle)].SetValue<float>(value); } }
    }
    public class ShapedTextOptions : Object
    {
        public ShapedTextOptions(nint addr) : base(addr) { }
        public bool bOverride_TextShapingMethod { get { return this[nameof(bOverride_TextShapingMethod)].Flag; } set { this[nameof(bOverride_TextShapingMethod)].Flag = value; } }
        public bool bOverride_TextFlowDirection { get { return this[nameof(bOverride_TextFlowDirection)].Flag; } set { this[nameof(bOverride_TextFlowDirection)].Flag = value; } }
        public ETextShapingMethod TextShapingMethod { get { return (ETextShapingMethod)this[nameof(TextShapingMethod)].GetValue<int>(); } set { this[nameof(TextShapingMethod)].SetValue<int>((int)value); } }
        public ETextFlowDirection TextFlowDirection { get { return (ETextFlowDirection)this[nameof(TextFlowDirection)].GetValue<int>(); } set { this[nameof(TextFlowDirection)].SetValue<int>((int)value); } }
    }
    public enum EVirtualKeyboardType : int
    {
        Default = 0,
        Number = 1,
        Web = 2,
        Email = 3,
        Password = 4,
        AlphaNumeric = 5,
        EVirtualKeyboardType_MAX = 6,
    }
    public enum ESlateAccessibleBehavior : int
    {
        NotAccessible = 0,
        Auto = 1,
        Summary = 2,
        Custom = 3,
        ToolTip = 4,
        ESlateAccessibleBehavior_MAX = 5,
    }
    public class PaintContext : Object
    {
        public PaintContext(nint addr) : base(addr) { }
    }
    public enum EWidgetAnimationEvent : int
    {
        Started = 0,
        Finished = 1,
        EWidgetAnimationEvent_MAX = 2,
    }
    public enum EUMGSequencePlayMode : int
    {
        Forward = 0,
        Reverse = 1,
        PingPong = 2,
        EUMGSequencePlayMode_MAX = 3,
    }
    public class AnimationEventBinding : Object
    {
        public AnimationEventBinding(nint addr) : base(addr) { }
        public WidgetAnimation Animation { get { return this[nameof(Animation)].As<WidgetAnimation>(); } set { this["Animation"] = value; } }
        public Object Delegate { get { return this[nameof(Delegate)]; } set { this[nameof(Delegate)] = value; } }
        public EWidgetAnimationEvent AnimationEvent { get { return (EWidgetAnimationEvent)this[nameof(AnimationEvent)].GetValue<int>(); } set { this[nameof(AnimationEvent)].SetValue<int>((int)value); } }
        public Object UserTag { get { return this[nameof(UserTag)]; } set { this[nameof(UserTag)] = value; } }
    }
    public enum EWidgetTickFrequency : int
    {
        Never = 0,
        Auto = 1,
        EWidgetTickFrequency_MAX = 2,
    }
    public class NamedSlotBinding : Object
    {
        public NamedSlotBinding(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Widget Content { get { return this[nameof(Content)].As<Widget>(); } set { this["Content"] = value; } }
    }
    public enum ESlateSizeRule : int
    {
        Automatic = 0,
        Fill = 1,
        ESlateSizeRule_MAX = 2,
    }
    public enum EDynamicBoxType : int
    {
        Horizontal = 0,
        Vertical = 1,
        Wrap = 2,
        VerticalWrap = 3,
        Radial = 4,
        Overlay = 5,
        EDynamicBoxType_MAX = 6,
    }
    public enum EWidgetDesignFlags : int
    {
        None = 0,
        Designing = 1,
        ShowOutline = 2,
        ExecutePreConstruct = 4,
        EWidgetDesignFlags_MAX = 5,
    }
    public enum EWidgetSpace : int
    {
        World = 0,
        Screen = 1,
        EWidgetSpace_MAX = 2,
    }
    public enum EWidgetTimingPolicy : int
    {
        RealTime = 0,
        GameTime = 1,
        EWidgetTimingPolicy_MAX = 2,
    }
    public enum EWidgetBlendMode : int
    {
        Opaque = 0,
        Masked = 1,
        Transparent = 2,
        EWidgetBlendMode_MAX = 3,
    }
    public enum EWidgetGeometryMode : int
    {
        Plane = 0,
        Cylinder = 1,
        EWidgetGeometryMode_MAX = 2,
    }
    public enum EWindowVisibility : int
    {
        Visible = 0,
        SelfHitTestInvisible = 1,
        EWindowVisibility_MAX = 2,
    }
    public enum ETickMode : int
    {
        Disabled = 0,
        Enabled = 1,
        Automatic = 2,
        ETickMode_MAX = 3,
    }
    public enum EWidgetInteractionSource : int
    {
        World = 0,
        Mouse = 1,
        CenterScreen = 2,
        Custom = 3,
        EWidgetInteractionSource_MAX = 4,
    }
    public enum EDragPivot : int
    {
        MouseDown = 0,
        TopLeft = 1,
        TopCenter = 2,
        TopRight = 3,
        CenterLeft = 4,
        CenterCenter = 5,
        CenterRight = 6,
        BottomLeft = 7,
        BottomCenter = 8,
        BottomRight = 9,
        EDragPivot_MAX = 10,
    }
    public enum EBindingKind : int
    {
        Function = 0,
        Property = 1,
        EBindingKind_MAX = 2,
    }
    public class RadialBoxSettings : Object
    {
        public RadialBoxSettings(nint addr) : base(addr) { }
        public float StartingAngle { get { return this[nameof(StartingAngle)].GetValue<float>(); } set { this[nameof(StartingAngle)].SetValue<float>(value); } }
        public bool bDistributeItemsEvenly { get { return this[nameof(bDistributeItemsEvenly)].Flag; } set { this[nameof(bDistributeItemsEvenly)].Flag = value; } }
        public float AngleBetweenItems { get { return this[nameof(AngleBetweenItems)].GetValue<float>(); } set { this[nameof(AngleBetweenItems)].SetValue<float>(value); } }
        public float SectorCentralAngle { get { return this[nameof(SectorCentralAngle)].GetValue<float>(); } set { this[nameof(SectorCentralAngle)].SetValue<float>(value); } }
    }
    public class SlateChildSize : Object
    {
        public SlateChildSize(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public byte SizeRule { get { return this[nameof(SizeRule)].GetValue<byte>(); } set { this[nameof(SizeRule)].SetValue<byte>(value); } }
    }
    public class WidgetNavigationData : Object
    {
        public WidgetNavigationData(nint addr) : base(addr) { }
        public EUINavigationRule Rule { get { return (EUINavigationRule)this[nameof(Rule)].GetValue<int>(); } set { this[nameof(Rule)].SetValue<int>((int)value); } }
        public Object WidgetToFocus { get { return this[nameof(WidgetToFocus)]; } set { this[nameof(WidgetToFocus)] = value; } }
        public Object Widget { get { return this[nameof(Widget)]; } set { this[nameof(Widget)] = value; } }
        public Object CustomDelegate { get { return this[nameof(CustomDelegate)]; } set { this[nameof(CustomDelegate)] = value; } }
    }
    public class MovieScene2DTransformMask : Object
    {
        public MovieScene2DTransformMask(nint addr) : base(addr) { }
        public uint mask { get { return this[nameof(mask)].GetValue<uint>(); } set { this[nameof(mask)].SetValue<uint>(value); } }
    }
    public class SequenceTickManagerWidgetData : Object
    {
        public SequenceTickManagerWidgetData(nint addr) : base(addr) { }
    }
    public class WidgetAnimationBinding : Object
    {
        public WidgetAnimationBinding(nint addr) : base(addr) { }
        public Object WidgetName { get { return this[nameof(WidgetName)]; } set { this[nameof(WidgetName)] = value; } }
        public Object SlotWidgetName { get { return this[nameof(SlotWidgetName)]; } set { this[nameof(SlotWidgetName)] = value; } }
        public Guid AnimationGuid { get { return this[nameof(AnimationGuid)].As<Guid>(); } set { this["AnimationGuid"] = value; } }
        public bool bIsRootWidget { get { return this[nameof(bIsRootWidget)].Flag; } set { this[nameof(bIsRootWidget)].Flag = value; } }
    }
    public class BlueprintWidgetAnimationDelegateBinding : Object
    {
        public BlueprintWidgetAnimationDelegateBinding(nint addr) : base(addr) { }
        public EWidgetAnimationEvent action { get { return (EWidgetAnimationEvent)this[nameof(action)].GetValue<int>(); } set { this[nameof(action)].SetValue<int>((int)value); } }
        public Object AnimationToBind { get { return this[nameof(AnimationToBind)]; } set { this[nameof(AnimationToBind)] = value; } }
        public Object FunctionNameToBind { get { return this[nameof(FunctionNameToBind)]; } set { this[nameof(FunctionNameToBind)] = value; } }
        public Object UserTag { get { return this[nameof(UserTag)]; } set { this[nameof(UserTag)] = value; } }
    }
    public class DynamicPropertyPath : CachedPropertyPath
    {
        public DynamicPropertyPath(nint addr) : base(addr) { }
    }
    public class GameViewportWidgetSlot : Object
    {
        public GameViewportWidgetSlot(nint addr) : base(addr) { }
        public Anchors Anchors { get { return this[nameof(Anchors)].As<Anchors>(); } set { this["Anchors"] = value; } }
        public Margin Offsets { get { return this[nameof(Offsets)].As<Margin>(); } set { this["Offsets"] = value; } }
        public Vector2D Alignment { get { return this[nameof(Alignment)].As<Vector2D>(); } set { this["Alignment"] = value; } }
        public int ZOrder { get { return this[nameof(ZOrder)].GetValue<int>(); } set { this[nameof(ZOrder)].SetValue<int>(value); } }
    }
    public class UserWidgetPool : Object
    {
        public UserWidgetPool(nint addr) : base(addr) { }
        public Array<UserWidget> ActiveWidgets { get { return new Array<UserWidget>(this[nameof(ActiveWidgets)].Address); } }
        public Array<UserWidget> InactiveWidgets { get { return new Array<UserWidget>(this[nameof(InactiveWidgets)].Address); } }
    }
    public class AnchorData : Object
    {
        public AnchorData(nint addr) : base(addr) { }
        public Margin Offsets { get { return this[nameof(Offsets)].As<Margin>(); } set { this["Offsets"] = value; } }
        public Anchors Anchors { get { return this[nameof(Anchors)].As<Anchors>(); } set { this["Anchors"] = value; } }
        public Vector2D Alignment { get { return this[nameof(Alignment)].As<Vector2D>(); } set { this["Alignment"] = value; } }
    }
    public class RichTextStyleRow : TableRowBase
    {
        public RichTextStyleRow(nint addr) : base(addr) { }
        public TextBlockStyle TextStyle { get { return this[nameof(TextStyle)].As<TextBlockStyle>(); } set { this["TextStyle"] = value; } }
    }
    public class RichImageRow : TableRowBase
    {
        public RichImageRow(nint addr) : base(addr) { }
        public SlateBrush Brush { get { return this[nameof(Brush)].As<SlateBrush>(); } set { this["Brush"] = value; } }
    }
    public class WidgetComponentInstanceData : SceneComponentInstanceData
    {
        public WidgetComponentInstanceData(nint addr) : base(addr) { }
    }
    public class SlateMeshVertex : Object
    {
        public SlateMeshVertex(nint addr) : base(addr) { }
        public Vector2f Position { get { return this[nameof(Position)].As<Vector2f>(); } set { this["Position"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public Vector2f UV0 { get { return this[nameof(UV0)].As<Vector2f>(); } set { this["UV0"] = value; } }
        public Vector2f UV1 { get { return this[nameof(UV1)].As<Vector2f>(); } set { this["UV1"] = value; } }
        public Vector2f UV2 { get { return this[nameof(UV2)].As<Vector2f>(); } set { this["UV2"] = value; } }
        public Vector2f UV3 { get { return this[nameof(UV3)].As<Vector2f>(); } set { this["UV3"] = value; } }
        public Vector2f UV4 { get { return this[nameof(UV4)].As<Vector2f>(); } set { this["UV4"] = value; } }
        public Vector2f UV5 { get { return this[nameof(UV5)].As<Vector2f>(); } set { this["UV5"] = value; } }
    }
    public class DelegateRuntimeBinding : Object
    {
        public DelegateRuntimeBinding(nint addr) : base(addr) { }
        public Object ObjectName { get { return this[nameof(ObjectName)]; } set { this[nameof(ObjectName)] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public Object FunctionName { get { return this[nameof(FunctionName)]; } set { this[nameof(FunctionName)] = value; } }
        public DynamicPropertyPath SourcePath { get { return this[nameof(SourcePath)].As<DynamicPropertyPath>(); } set { this["SourcePath"] = value; } }
        public EBindingKind Kind { get { return (EBindingKind)this[nameof(Kind)].GetValue<int>(); } set { this[nameof(Kind)].SetValue<int>((int)value); } }
    }
}
