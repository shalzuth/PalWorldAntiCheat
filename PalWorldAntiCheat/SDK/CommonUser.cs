using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.GameplayTagsSDK;
using SDK.Script.InputCoreSDK;
namespace SDK.Script.CommonUserSDK
{
    public class AsyncAction_CommonUserInitialize : CancellableAsyncAction
    {
        public AsyncAction_CommonUserInitialize(nint addr) : base(addr) { }
        public Object OnInitializationComplete { get { return this[nameof(OnInitializationComplete)]; } set { this[nameof(OnInitializationComplete)] = value; } }
        public AsyncAction_CommonUserInitialize LoginForOnlinePlay(CommonUserSubsystem Target, int LocalPlayerIndex) { return Invoke<AsyncAction_CommonUserInitialize>(nameof(LoginForOnlinePlay), Target, LocalPlayerIndex); }
        public AsyncAction_CommonUserInitialize InitializeForLocalPlay(CommonUserSubsystem Target, int LocalPlayerIndex, InputDeviceId PrimaryInputDevice, bool bCanUseGuestLogin) { return Invoke<AsyncAction_CommonUserInitialize>(nameof(InitializeForLocalPlay), Target, LocalPlayerIndex, PrimaryInputDevice, bCanUseGuestLogin); }
        public void HandleInitializationComplete(CommonUserInfo UserInfo, bool bSuccess, Object Error, ECommonUserPrivilege RequestedPrivilege, ECommonUserOnlineContext OnlineContext) { Invoke(nameof(HandleInitializationComplete), UserInfo, bSuccess, Error, RequestedPrivilege, OnlineContext); }
    }
    public class CommonSession_HostSessionRequest : Object
    {
        public CommonSession_HostSessionRequest(nint addr) : base(addr) { }
        public ECommonSessionOnlineMode OnlineMode { get { return (ECommonSessionOnlineMode)this[nameof(OnlineMode)].GetValue<int>(); } set { this[nameof(OnlineMode)].SetValue<int>((int)value); } }
        public bool bUseLobbies { get { return this[nameof(bUseLobbies)].Flag; } set { this[nameof(bUseLobbies)].Flag = value; } }
        public Object ModeNameForAdvertisement { get { return this[nameof(ModeNameForAdvertisement)]; } set { this[nameof(ModeNameForAdvertisement)] = value; } }
        public PrimaryAssetId MapID { get { return this[nameof(MapID)].As<PrimaryAssetId>(); } set { this["MapID"] = value; } }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public Object ExtraArgs { get { return this[nameof(ExtraArgs)]; } set { this[nameof(ExtraArgs)] = value; } }
        public int MaxPlayerCount { get { return this[nameof(MaxPlayerCount)].GetValue<int>(); } set { this[nameof(MaxPlayerCount)].SetValue<int>(value); } }
    }
    public class CommonSession_SearchResult : Object
    {
        public CommonSession_SearchResult(nint addr) : base(addr) { }
        public void GetStringSetting(Object Key, Object Value, bool bFoundValue) { Invoke(nameof(GetStringSetting), Key, Value, bFoundValue); }
        public int GetPingInMs() { return Invoke<int>(nameof(GetPingInMs)); }
        public int GetNumOpenPublicConnections() { return Invoke<int>(nameof(GetNumOpenPublicConnections)); }
        public int GetNumOpenPrivateConnections() { return Invoke<int>(nameof(GetNumOpenPrivateConnections)); }
        public int GetMaxPublicConnections() { return Invoke<int>(nameof(GetMaxPublicConnections)); }
        public void GetIntSetting(Object Key, int Value, bool bFoundValue) { Invoke(nameof(GetIntSetting), Key, Value, bFoundValue); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
    }
    public class CommonSession_SearchSessionRequest : Object
    {
        public CommonSession_SearchSessionRequest(nint addr) : base(addr) { }
        public ECommonSessionOnlineMode OnlineMode { get { return (ECommonSessionOnlineMode)this[nameof(OnlineMode)].GetValue<int>(); } set { this[nameof(OnlineMode)].SetValue<int>((int)value); } }
        public bool bUseLobbies { get { return this[nameof(bUseLobbies)].Flag; } set { this[nameof(bUseLobbies)].Flag = value; } }
        public Array<CommonSession_SearchResult> Results { get { return new Array<CommonSession_SearchResult>(this[nameof(Results)].Address); } }
        public Object K2_OnSearchFinished { get { return this[nameof(K2_OnSearchFinished)]; } set { this[nameof(K2_OnSearchFinished)] = value; } }
    }
    public class CommonSessionSubsystem : GameInstanceSubsystem
    {
        public CommonSessionSubsystem(nint addr) : base(addr) { }
        public Object K2_OnUserRequestedSessionEvent { get { return this[nameof(K2_OnUserRequestedSessionEvent)]; } set { this[nameof(K2_OnUserRequestedSessionEvent)] = value; } }
        public Object K2_OnJoinSessionCompleteEvent { get { return this[nameof(K2_OnJoinSessionCompleteEvent)]; } set { this[nameof(K2_OnJoinSessionCompleteEvent)] = value; } }
        public Object K2_OnCreateSessionCompleteEvent { get { return this[nameof(K2_OnCreateSessionCompleteEvent)]; } set { this[nameof(K2_OnCreateSessionCompleteEvent)] = value; } }
        public void QuickPlaySession(PlayerController JoiningOrHostingPlayer, CommonSession_HostSessionRequest Request) { Invoke(nameof(QuickPlaySession), JoiningOrHostingPlayer, Request); }
        public void JoinSession(PlayerController JoiningPlayer, CommonSession_SearchResult Request) { Invoke(nameof(JoinSession), JoiningPlayer, Request); }
        public void HostSession(PlayerController HostingPlayer, CommonSession_HostSessionRequest Request) { Invoke(nameof(HostSession), HostingPlayer, Request); }
        public void FindSessions(PlayerController SearchingPlayer, CommonSession_SearchSessionRequest Request) { Invoke(nameof(FindSessions), SearchingPlayer, Request); }
        public CommonSession_SearchSessionRequest CreateOnlineSearchSessionRequest() { return Invoke<CommonSession_SearchSessionRequest>(nameof(CreateOnlineSearchSessionRequest)); }
        public CommonSession_HostSessionRequest CreateOnlineHostSessionRequest() { return Invoke<CommonSession_HostSessionRequest>(nameof(CreateOnlineHostSessionRequest)); }
        public void CleanUpSessions() { Invoke(nameof(CleanUpSessions)); }
    }
    public class CommonUserInfo : Object
    {
        public CommonUserInfo(nint addr) : base(addr) { }
        public InputDeviceId PrimaryInputDevice { get { return this[nameof(PrimaryInputDevice)].As<InputDeviceId>(); } set { this["PrimaryInputDevice"] = value; } }
        public PlatformUserId PlatformUser { get { return this[nameof(PlatformUser)].As<PlatformUserId>(); } set { this["PlatformUser"] = value; } }
        public int LocalPlayerIndex { get { return this[nameof(LocalPlayerIndex)].GetValue<int>(); } set { this[nameof(LocalPlayerIndex)].SetValue<int>(value); } }
        public bool bCanBeGuest { get { return this[nameof(bCanBeGuest)].Flag; } set { this[nameof(bCanBeGuest)].Flag = value; } }
        public bool bIsGuest { get { return this[nameof(bIsGuest)].Flag; } set { this[nameof(bIsGuest)].Flag = value; } }
        public ECommonUserInitializationState InitializationState { get { return (ECommonUserInitializationState)this[nameof(InitializationState)].GetValue<int>(); } set { this[nameof(InitializationState)].SetValue<int>((int)value); } }
        public ECommonUserAvailability GetPrivilegeAvailability(ECommonUserPrivilege Privilege) { return Invoke<ECommonUserAvailability>(nameof(GetPrivilegeAvailability), Privilege); }
        public Object GetNickname() { return Invoke<Object>(nameof(GetNickname)); }
        public UniqueNetIdRepl GetNetId(ECommonUserOnlineContext Context) { return Invoke<UniqueNetIdRepl>(nameof(GetNetId), Context); }
        public Object GetDebugString() { return Invoke<Object>(nameof(GetDebugString)); }
        public ECommonUserPrivilegeResult GetCachedPrivilegeResult(ECommonUserPrivilege Privilege, ECommonUserOnlineContext Context) { return Invoke<ECommonUserPrivilegeResult>(nameof(GetCachedPrivilegeResult), Privilege, Context); }
    }
    public class CommonUserSubsystem : GameInstanceSubsystem
    {
        public CommonUserSubsystem(nint addr) : base(addr) { }
        public Object OnUserInitializeComplete { get { return this[nameof(OnUserInitializeComplete)]; } set { this[nameof(OnUserInitializeComplete)] = value; } }
        public Object OnHandleSystemMessage { get { return this[nameof(OnHandleSystemMessage)]; } set { this[nameof(OnHandleSystemMessage)] = value; } }
        public Object OnUserPrivilegeChanged { get { return this[nameof(OnUserPrivilegeChanged)]; } set { this[nameof(OnUserPrivilegeChanged)] = value; } }
        public Object LocalUserInfos { get { return this[nameof(LocalUserInfos)]; } set { this[nameof(LocalUserInfos)] = value; } }
        public bool TryToLoginForOnlinePlay(int LocalPlayerIndex) { return Invoke<bool>(nameof(TryToLoginForOnlinePlay), LocalPlayerIndex); }
        public bool TryToInitializeUser(CommonUserInitializeParams Params) { return Invoke<bool>(nameof(TryToInitializeUser), Params); }
        public bool TryToInitializeForLocalPlay(int LocalPlayerIndex, InputDeviceId PrimaryInputDevice, bool bCanUseGuestLogin) { return Invoke<bool>(nameof(TryToInitializeForLocalPlay), LocalPlayerIndex, PrimaryInputDevice, bCanUseGuestLogin); }
        public bool ShouldWaitForStartInput() { return Invoke<bool>(nameof(ShouldWaitForStartInput)); }
        public void SetMaxLocalPlayers(int InMaxLocalPLayers) { Invoke(nameof(SetMaxLocalPlayers), InMaxLocalPLayers); }
        public void SendSystemMessage(GameplayTag MessageType, Object TitleText, Object BodyText) { Invoke(nameof(SendSystemMessage), MessageType, TitleText, BodyText); }
        public void ResetUserState() { Invoke(nameof(ResetUserState)); }
        public void ListenForLoginKeyInput(Array<Key> AnyUserKeys, Array<Key> NewUserKeys, CommonUserInitializeParams Params) { Invoke(nameof(ListenForLoginKeyInput), AnyUserKeys, NewUserKeys, Params); }
        public bool HasTraitTag(GameplayTag TraitTag) { return Invoke<bool>(nameof(HasTraitTag), TraitTag); }
        public CommonUserInfo GetUserInfoForUniqueNetId(UniqueNetIdRepl NetId) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForUniqueNetId), NetId); }
        public CommonUserInfo GetUserInfoForPlatformUserIndex(int PlatformUserIndex) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForPlatformUserIndex), PlatformUserIndex); }
        public CommonUserInfo GetUserInfoForPlatformUser(PlatformUserId PlatformUser) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForPlatformUser), PlatformUser); }
        public CommonUserInfo GetUserInfoForLocalPlayerIndex(int LocalPlayerIndex) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForLocalPlayerIndex), LocalPlayerIndex); }
        public CommonUserInfo GetUserInfoForInputDevice(InputDeviceId InputDevice) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForInputDevice), InputDevice); }
        public CommonUserInfo GetUserInfoForControllerId(int ControllerId) { return Invoke<CommonUserInfo>(nameof(GetUserInfoForControllerId), ControllerId); }
        public int GetNumLocalPlayers() { return Invoke<int>(nameof(GetNumLocalPlayers)); }
        public int GetMaxLocalPlayers() { return Invoke<int>(nameof(GetMaxLocalPlayers)); }
        public ECommonUserInitializationState GetLocalPlayerInitializationState(int LocalPlayerIndex) { return Invoke<ECommonUserInitializationState>(nameof(GetLocalPlayerInitializationState), LocalPlayerIndex); }
        public bool CancelUserInitialization(int LocalPlayerIndex) { return Invoke<bool>(nameof(CancelUserInitialization), LocalPlayerIndex); }
    }
    public class OnlineResultInformation : Object
    {
        public OnlineResultInformation(nint addr) : base(addr) { }
        public bool bWasSuccessful { get { return this[nameof(bWasSuccessful)].Flag; } set { this[nameof(bWasSuccessful)].Flag = value; } }
        public Object ErrorId { get { return this[nameof(ErrorId)]; } set { this[nameof(ErrorId)] = value; } }
        public Object ErrorText { get { return this[nameof(ErrorText)]; } set { this[nameof(ErrorText)] = value; } }
    }
    public enum ECommonUserAvailability : int
    {
        Unknown = 0,
        NowAvailable = 1,
        PossiblyAvailable = 2,
        CurrentlyUnavailable = 3,
        AlwaysUnavailable = 4,
        Invalid = 5,
        ECommonUserAvailability_MAX = 6,
    }
    public enum ECommonUserPrivilege : int
    {
        CanPlay = 0,
        CanPlayOnline = 1,
        CanCommunicateViaTextOnline = 2,
        CanCommunicateViaVoiceOnline = 3,
        CanUseUserGeneratedContent = 4,
        CanUseCrossPlay = 5,
        Invalid_Count = 6,
        ECommonUserPrivilege_MAX = 7,
    }
    public enum ECommonUserOnlineContext : int
    {
        Game = 0,
        Default = 1,
        Service = 2,
        ServiceOrDefault = 3,
        Platform = 4,
        PlatformOrDefault = 5,
        Invalid = 6,
        ECommonUserOnlineContext_MAX = 7,
    }
    public enum ECommonUserInitializationState : int
    {
        Unknown = 0,
        DoingInitialLogin = 1,
        DoingNetworkLogin = 2,
        FailedtoLogin = 3,
        LoggedInOnline = 4,
        LoggedInLocalOnly = 5,
        Invalid = 6,
        ECommonUserInitializationState_MAX = 7,
    }
    public enum ECommonUserPrivilegeResult : int
    {
        Unknown = 0,
        Available = 1,
        UserNotLoggedIn = 2,
        LicenseInvalid = 3,
        VersionOutdated = 4,
        NetworkConnectionUnavailable = 5,
        AgeRestricted = 6,
        AccountTypeRestricted = 7,
        AccountUseRestricted = 8,
        PlatformFailure = 9,
        ECommonUserPrivilegeResult_MAX = 10,
    }
    public enum ECommonSessionOnlineMode : int
    {
        Offline = 0,
        LAN = 1,
        Online = 2,
        ECommonSessionOnlineMode_MAX = 3,
    }
    public class CommonUserInitializeParams : Object
    {
        public CommonUserInitializeParams(nint addr) : base(addr) { }
        public int LocalPlayerIndex { get { return this[nameof(LocalPlayerIndex)].GetValue<int>(); } set { this[nameof(LocalPlayerIndex)].SetValue<int>(value); } }
        public int ControllerId { get { return this[nameof(ControllerId)].GetValue<int>(); } set { this[nameof(ControllerId)].SetValue<int>(value); } }
        public InputDeviceId PrimaryInputDevice { get { return this[nameof(PrimaryInputDevice)].As<InputDeviceId>(); } set { this["PrimaryInputDevice"] = value; } }
        public PlatformUserId PlatformUser { get { return this[nameof(PlatformUser)].As<PlatformUserId>(); } set { this["PlatformUser"] = value; } }
        public ECommonUserPrivilege RequestedPrivilege { get { return (ECommonUserPrivilege)this[nameof(RequestedPrivilege)].GetValue<int>(); } set { this[nameof(RequestedPrivilege)].SetValue<int>((int)value); } }
        public ECommonUserOnlineContext OnlineContext { get { return (ECommonUserOnlineContext)this[nameof(OnlineContext)].GetValue<int>(); } set { this[nameof(OnlineContext)].SetValue<int>((int)value); } }
        public bool bCanCreateNewLocalPlayer { get { return this[nameof(bCanCreateNewLocalPlayer)].Flag; } set { this[nameof(bCanCreateNewLocalPlayer)].Flag = value; } }
        public bool bCanUseGuestLogin { get { return this[nameof(bCanUseGuestLogin)].Flag; } set { this[nameof(bCanUseGuestLogin)].Flag = value; } }
        public bool bSuppressLoginErrors { get { return this[nameof(bSuppressLoginErrors)].Flag; } set { this[nameof(bSuppressLoginErrors)].Flag = value; } }
        public Object OnUserInitializeComplete { get { return this[nameof(OnUserInitializeComplete)]; } set { this[nameof(OnUserInitializeComplete)] = value; } }
    }
}
