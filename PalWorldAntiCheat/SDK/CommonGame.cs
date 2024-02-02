using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.GameplayTagsSDK;
using SDK.Script.CommonUserSDK;
using SDK.Script.CommonUISDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.CommonInputSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.UMGSDK;
namespace SDK.Script.CommonGameSDK
{
    public class AsyncAction_CreateWidgetAsync : CancellableAsyncAction
    {
        public AsyncAction_CreateWidgetAsync(nint addr) : base(addr) { }
        public Object OnComplete { get { return this[nameof(OnComplete)]; } set { this[nameof(OnComplete)] = value; } }
        public AsyncAction_CreateWidgetAsync CreateWidgetAsync(Object WorldContextObject, Object UserWidgetSoftClass, PlayerController OwningPlayer, bool bSuspendInputUntilComplete) { return Invoke<AsyncAction_CreateWidgetAsync>(nameof(CreateWidgetAsync), WorldContextObject, UserWidgetSoftClass, OwningPlayer, bSuspendInputUntilComplete); }
    }
    public class AsyncAction_PushContentToLayerForPlayer : CancellableAsyncAction
    {
        public AsyncAction_PushContentToLayerForPlayer(nint addr) : base(addr) { }
        public Object BeforePush { get { return this[nameof(BeforePush)]; } set { this[nameof(BeforePush)] = value; } }
        public Object AfterPush { get { return this[nameof(AfterPush)]; } set { this[nameof(AfterPush)] = value; } }
        public AsyncAction_PushContentToLayerForPlayer PushContentToLayerForPlayer(PlayerController OwningPlayer, Object WidgetClass, GameplayTag LayerName, bool bSuspendInputUntilComplete) { return Invoke<AsyncAction_PushContentToLayerForPlayer>(nameof(PushContentToLayerForPlayer), OwningPlayer, WidgetClass, LayerName, bSuspendInputUntilComplete); }
    }
    public class AsyncAction_ShowConfirmation : BlueprintAsyncActionBase
    {
        public AsyncAction_ShowConfirmation(nint addr) : base(addr) { }
        public Object OnResult { get { return this[nameof(OnResult)]; } set { this[nameof(OnResult)] = value; } }
        public Object WorldContextObject { get { return this[nameof(WorldContextObject)].As<Object>(); } set { this["WorldContextObject"] = value; } }
        public LocalPlayer TargetLocalPlayer { get { return this[nameof(TargetLocalPlayer)].As<LocalPlayer>(); } set { this["TargetLocalPlayer"] = value; } }
        public CommonGameDialogDescriptor Descriptor { get { return this[nameof(Descriptor)].As<CommonGameDialogDescriptor>(); } set { this["Descriptor"] = value; } }
        public AsyncAction_ShowConfirmation ShowConfirmationYesNo(Object InWorldContextObject, Object Title, Object Message) { return Invoke<AsyncAction_ShowConfirmation>(nameof(ShowConfirmationYesNo), InWorldContextObject, Title, Message); }
        public AsyncAction_ShowConfirmation ShowConfirmationOkCancel(Object InWorldContextObject, Object Title, Object Message) { return Invoke<AsyncAction_ShowConfirmation>(nameof(ShowConfirmationOkCancel), InWorldContextObject, Title, Message); }
        public AsyncAction_ShowConfirmation ShowConfirmationCustom(Object InWorldContextObject, CommonGameDialogDescriptor Descriptor) { return Invoke<AsyncAction_ShowConfirmation>(nameof(ShowConfirmationCustom), InWorldContextObject, Descriptor); }
    }
    public class CommonGameInstance : GameInstance
    {
        public CommonGameInstance(nint addr) : base(addr) { }
        public CommonSession_SearchResult RequestedSession { get { return this[nameof(RequestedSession)].As<CommonSession_SearchResult>(); } set { this["RequestedSession"] = value; } }
        public void HandleSystemMessage(GameplayTag MessageType, Object Title, Object Message) { Invoke(nameof(HandleSystemMessage), MessageType, Title, Message); }
        public void HandlePrivilegeChanged(CommonUserInfo UserInfo, ECommonUserPrivilege Privilege, ECommonUserAvailability OldAvailability, ECommonUserAvailability NewAvailability) { Invoke(nameof(HandlePrivilegeChanged), UserInfo, Privilege, OldAvailability, NewAvailability); }
    }
    public class CommonLocalPlayer : LocalPlayer
    {
        public CommonLocalPlayer(nint addr) : base(addr) { }
    }
    public class CommonPlayerInputKey : CommonUserWidget
    {
        public CommonPlayerInputKey(nint addr) : base(addr) { }
        public Object BoundAction { get { return this[nameof(BoundAction)]; } set { this[nameof(BoundAction)] = value; } }
        public float AxisScale { get { return this[nameof(AxisScale)].GetValue<float>(); } set { this[nameof(AxisScale)].SetValue<float>(value); } }
        public Key BoundKeyFallback { get { return this[nameof(BoundKeyFallback)].As<Key>(); } set { this["BoundKeyFallback"] = value; } }
        public ECommonInputType InputTypeOverride { get { return (ECommonInputType)this[nameof(InputTypeOverride)].GetValue<int>(); } set { this[nameof(InputTypeOverride)].SetValue<int>((int)value); } }
        public Object PresetNameOverride { get { return this[nameof(PresetNameOverride)]; } set { this[nameof(PresetNameOverride)] = value; } }
        public ECommonKeybindForcedHoldStatus ForcedHoldKeybindStatus { get { return (ECommonKeybindForcedHoldStatus)this[nameof(ForcedHoldKeybindStatus)].GetValue<int>(); } set { this[nameof(ForcedHoldKeybindStatus)].SetValue<int>((int)value); } }
        public bool bIsHoldKeybind { get { return this[nameof(bIsHoldKeybind)].Flag; } set { this[nameof(bIsHoldKeybind)].Flag = value; } }
        public bool bShowKeybindBorder { get { return this[nameof(bShowKeybindBorder)].Flag; } set { this[nameof(bShowKeybindBorder)].Flag = value; } }
        public Vector2D FrameSize { get { return this[nameof(FrameSize)].As<Vector2D>(); } set { this["FrameSize"] = value; } }
        public bool bShowTimeCountDown { get { return this[nameof(bShowTimeCountDown)].Flag; } set { this[nameof(bShowTimeCountDown)].Flag = value; } }
        public Key BoundKey { get { return this[nameof(BoundKey)].As<Key>(); } set { this["BoundKey"] = value; } }
        public SlateBrush HoldProgressBrush { get { return this[nameof(HoldProgressBrush)].As<SlateBrush>(); } set { this["HoldProgressBrush"] = value; } }
        public SlateBrush KeyBindTextBorder { get { return this[nameof(KeyBindTextBorder)].As<SlateBrush>(); } set { this["KeyBindTextBorder"] = value; } }
        public bool bShowUnboundStatus { get { return this[nameof(bShowUnboundStatus)].Flag; } set { this[nameof(bShowUnboundStatus)].Flag = value; } }
        public SlateFontInfo KeyBindTextFont { get { return this[nameof(KeyBindTextFont)].As<SlateFontInfo>(); } set { this["KeyBindTextFont"] = value; } }
        public SlateFontInfo CountdownTextFont { get { return this[nameof(CountdownTextFont)].As<SlateFontInfo>(); } set { this["CountdownTextFont"] = value; } }
        public MeasuredText CountdownText { get { return this[nameof(CountdownText)].As<MeasuredText>(); } set { this["CountdownText"] = value; } }
        public MeasuredText KeybindText { get { return this[nameof(KeybindText)].As<MeasuredText>(); } set { this["KeybindText"] = value; } }
        public Margin KeybindTextPadding { get { return this[nameof(KeybindTextPadding)].As<Margin>(); } set { this["KeybindTextPadding"] = value; } }
        public Vector2D KeybindFrameMinimumSize { get { return this[nameof(KeybindFrameMinimumSize)].As<Vector2D>(); } set { this["KeybindFrameMinimumSize"] = value; } }
        public Object PercentageMaterialParameterName { get { return this[nameof(PercentageMaterialParameterName)]; } set { this[nameof(PercentageMaterialParameterName)] = value; } }
        public MaterialInstanceDynamic ProgressPercentageMID { get { return this[nameof(ProgressPercentageMID)].As<MaterialInstanceDynamic>(); } set { this["ProgressPercentageMID"] = value; } }
        public SlateBrush CachedKeyBrush { get { return this[nameof(CachedKeyBrush)].As<SlateBrush>(); } set { this["CachedKeyBrush"] = value; } }
        public void UpdateKeybindWidget() { Invoke(nameof(UpdateKeybindWidget)); }
        public void StopHoldProgress(Object HoldActionName, bool bCompletedSuccessfully) { Invoke(nameof(StopHoldProgress), HoldActionName, bCompletedSuccessfully); }
        public void StartHoldProgress(Object HoldActionName, float HoldDuration) { Invoke(nameof(StartHoldProgress), HoldActionName, HoldDuration); }
        public void SetShowProgressCountDown(bool bShow) { Invoke(nameof(SetShowProgressCountDown), bShow); }
        public void SetPresetNameOverride(Object NewValue) { Invoke(nameof(SetPresetNameOverride), NewValue); }
        public void SetForcedHoldKeybindStatus(ECommonKeybindForcedHoldStatus InForcedHoldKeybindStatus) { Invoke(nameof(SetForcedHoldKeybindStatus), InForcedHoldKeybindStatus); }
        public void SetForcedHoldKeybind(bool InForcedHoldKeybind) { Invoke(nameof(SetForcedHoldKeybind), InForcedHoldKeybind); }
        public void SetBoundKey(Key NewBoundAction) { Invoke(nameof(SetBoundKey), NewBoundAction); }
        public void SetBoundAction(Object NewBoundAction) { Invoke(nameof(SetBoundAction), NewBoundAction); }
        public void SetAxisScale(float NewValue) { Invoke(nameof(SetAxisScale), NewValue); }
        public bool IsHoldKeybind() { return Invoke<bool>(nameof(IsHoldKeybind)); }
        public bool IsBoundKeyValid() { return Invoke<bool>(nameof(IsBoundKeyValid)); }
    }
    public class CommonUIExtensions : BlueprintFunctionLibrary
    {
        public CommonUIExtensions(nint addr) : base(addr) { }
        public Object SuspendInputForPlayer(PlayerController PlayerController, Object SuspendReason) { return Invoke<Object>(nameof(SuspendInputForPlayer), PlayerController, SuspendReason); }
        public void ResumeInputForPlayer(PlayerController PlayerController, Object SuspendToken) { Invoke(nameof(ResumeInputForPlayer), PlayerController, SuspendToken); }
        public void PushStreamedContentToLayer_ForPlayer(LocalPlayer LocalPlayer, GameplayTag LayerName, Object WidgetClass) { Invoke(nameof(PushStreamedContentToLayer_ForPlayer), LocalPlayer, LayerName, WidgetClass); }
        public CommonActivatableWidget PushContentToLayer_ForPlayer(LocalPlayer LocalPlayer, GameplayTag LayerName, Object WidgetClass) { return Invoke<CommonActivatableWidget>(nameof(PushContentToLayer_ForPlayer), LocalPlayer, LayerName, WidgetClass); }
        public void PopContentFromLayer(CommonActivatableWidget ActivatableWidget) { Invoke(nameof(PopContentFromLayer), ActivatableWidget); }
        public bool IsOwningPlayerUsingTouch(UserWidget WidgetContextObject) { return Invoke<bool>(nameof(IsOwningPlayerUsingTouch), WidgetContextObject); }
        public bool IsOwningPlayerUsingGamepad(UserWidget WidgetContextObject) { return Invoke<bool>(nameof(IsOwningPlayerUsingGamepad), WidgetContextObject); }
        public ECommonInputType GetOwningPlayerInputType(UserWidget WidgetContextObject) { return Invoke<ECommonInputType>(nameof(GetOwningPlayerInputType), WidgetContextObject); }
        public LocalPlayer GetLocalPlayerFromController(PlayerController PlayerController) { return Invoke<LocalPlayer>(nameof(GetLocalPlayerFromController), PlayerController); }
    }
    public class GameUIManagerSubsystem : GameInstanceSubsystem
    {
        public GameUIManagerSubsystem(nint addr) : base(addr) { }
        public GameUIPolicy CurrentPolicy { get { return this[nameof(CurrentPolicy)].As<GameUIPolicy>(); } set { this["CurrentPolicy"] = value; } }
        public Object DefaultUIPolicyClass { get { return this[nameof(DefaultUIPolicyClass)]; } set { this[nameof(DefaultUIPolicyClass)] = value; } }
    }
    public class GameUIPolicy : Object
    {
        public GameUIPolicy(nint addr) : base(addr) { }
        public Object LayoutClass { get { return this[nameof(LayoutClass)]; } set { this[nameof(LayoutClass)] = value; } }
        public Array<RootViewportLayoutInfo> RootViewportLayouts { get { return new Array<RootViewportLayoutInfo>(this[nameof(RootViewportLayouts)].Address); } }
    }
    public class CommonGameDialogDescriptor : Object
    {
        public CommonGameDialogDescriptor(nint addr) : base(addr) { }
        public Object Header { get { return this[nameof(Header)]; } set { this[nameof(Header)] = value; } }
        public Object Body { get { return this[nameof(Body)]; } set { this[nameof(Body)] = value; } }
        public Array<ConfirmationDialogAction> ButtonActions { get { return new Array<ConfirmationDialogAction>(this[nameof(ButtonActions)].Address); } }
    }
    public class CommonGameDialog : CommonActivatableWidget
    {
        public CommonGameDialog(nint addr) : base(addr) { }
    }
    public class CommonMessagingSubsystem : LocalPlayerSubsystem
    {
        public CommonMessagingSubsystem(nint addr) : base(addr) { }
    }
    public class PrimaryGameLayout : CommonUserWidget
    {
        public PrimaryGameLayout(nint addr) : base(addr) { }
        public Object Layers { get { return this[nameof(Layers)]; } set { this[nameof(Layers)] = value; } }
        public void RegisterLayer(GameplayTag LayerTag, CommonActivatableWidgetContainerBase LayerWidget) { Invoke(nameof(RegisterLayer), LayerTag, LayerWidget); }
    }
    public enum ECommonMessagingResult : int
    {
        Confirmed = 0,
        Declined = 1,
        Cancelled = 2,
        Killed = 3,
        Unknown = 4,
        ECommonMessagingResult_MAX = 5,
    }
    public enum ECommonKeybindForcedHoldStatus : int
    {
        NoForcedHold = 0,
        ForcedHold = 1,
        NeverShowHold = 2,
        ECommonKeybindForcedHoldStatus_MAX = 3,
    }
    public enum ELocalMultiplayerInteractionMode : int
    {
        PrimaryOnly = 0,
        SingleToggle = 1,
        Simultaneous = 2,
        ELocalMultiplayerInteractionMode_MAX = 3,
    }
    public class MeasuredText : Object
    {
        public MeasuredText(nint addr) : base(addr) { }
    }
    public class RootViewportLayoutInfo : Object
    {
        public RootViewportLayoutInfo(nint addr) : base(addr) { }
        public LocalPlayer LocalPlayer { get { return this[nameof(LocalPlayer)].As<LocalPlayer>(); } set { this["LocalPlayer"] = value; } }
        public PrimaryGameLayout RootLayout { get { return this[nameof(RootLayout)].As<PrimaryGameLayout>(); } set { this["RootLayout"] = value; } }
        public bool bAddedToViewport { get { return this[nameof(bAddedToViewport)].Flag; } set { this[nameof(bAddedToViewport)].Flag = value; } }
    }
    public class ConfirmationDialogAction : Object
    {
        public ConfirmationDialogAction(nint addr) : base(addr) { }
        public ECommonMessagingResult Result { get { return (ECommonMessagingResult)this[nameof(Result)].GetValue<int>(); } set { this[nameof(Result)].SetValue<int>((int)value); } }
        public Object OptionalDisplayText { get { return this[nameof(OptionalDisplayText)]; } set { this[nameof(OptionalDisplayText)] = value; } }
    }
}
