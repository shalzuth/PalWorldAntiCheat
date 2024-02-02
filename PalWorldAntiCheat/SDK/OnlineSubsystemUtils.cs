using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.AudioMixerSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.OnlineSubsystemUtilsSDK
{
    public class AchievementBlueprintLibrary : BlueprintFunctionLibrary
    {
        public AchievementBlueprintLibrary(nint addr) : base(addr) { }
        public void GetCachedAchievementProgress(Object WorldContextObject, PlayerController PlayerController, Object AchievementId, bool bFoundID, float Progress) { Invoke(nameof(GetCachedAchievementProgress), WorldContextObject, PlayerController, AchievementId, bFoundID, Progress); }
        public void GetCachedAchievementDescription(Object WorldContextObject, PlayerController PlayerController, Object AchievementId, bool bFoundID, Object Title, Object LockedDescription, Object UnlockedDescription, bool bHidden) { Invoke(nameof(GetCachedAchievementDescription), WorldContextObject, PlayerController, AchievementId, bFoundID, Title, LockedDescription, UnlockedDescription, bHidden); }
    }
    public class AchievementQueryCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public AchievementQueryCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public AchievementQueryCallbackProxy CacheAchievements(Object WorldContextObject, PlayerController PlayerController) { return Invoke<AchievementQueryCallbackProxy>(nameof(CacheAchievements), WorldContextObject, PlayerController); }
        public AchievementQueryCallbackProxy CacheAchievementDescriptions(Object WorldContextObject, PlayerController PlayerController) { return Invoke<AchievementQueryCallbackProxy>(nameof(CacheAchievementDescriptions), WorldContextObject, PlayerController); }
    }
    public class AchievementWriteCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public AchievementWriteCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public AchievementWriteCallbackProxy WriteAchievementProgress(Object WorldContextObject, PlayerController PlayerController, Object AchievementName, float Progress, int UserTag) { return Invoke<AchievementWriteCallbackProxy>(nameof(WriteAchievementProgress), WorldContextObject, PlayerController, AchievementName, Progress, UserTag); }
    }
    public class ConnectionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public ConnectionCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public ConnectionCallbackProxy ConnectToService(Object WorldContextObject, PlayerController PlayerController) { return Invoke<ConnectionCallbackProxy>(nameof(ConnectToService), WorldContextObject, PlayerController); }
    }
    public class CreateSessionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public CreateSessionCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CreateSessionCallbackProxy CreateSession(Object WorldContextObject, PlayerController PlayerController, int PublicConnections, bool bUseLAN) { return Invoke<CreateSessionCallbackProxy>(nameof(CreateSession), WorldContextObject, PlayerController, PublicConnections, bUseLAN); }
    }
    public class DestroySessionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public DestroySessionCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public DestroySessionCallbackProxy DestroySession(Object WorldContextObject, PlayerController PlayerController) { return Invoke<DestroySessionCallbackProxy>(nameof(DestroySession), WorldContextObject, PlayerController); }
    }
    public class EndMatchCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public EndMatchCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public EndMatchCallbackProxy EndMatch(Object WorldContextObject, PlayerController PlayerController, Object MatchActor, Object MatchID, byte LocalPlayerOutcome, byte OtherPlayersOutcome) { return Invoke<EndMatchCallbackProxy>(nameof(EndMatch), WorldContextObject, PlayerController, MatchActor, MatchID, LocalPlayerOutcome, OtherPlayersOutcome); }
    }
    public class EndTurnCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public EndTurnCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public EndTurnCallbackProxy EndTurn(Object WorldContextObject, PlayerController PlayerController, Object MatchID, Object TurnBasedMatchInterface) { return Invoke<EndTurnCallbackProxy>(nameof(EndTurn), WorldContextObject, PlayerController, MatchID, TurnBasedMatchInterface); }
    }
    public class FindSessionsCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public FindSessionsCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public Object GetServerName(BlueprintSessionResult Result) { return Invoke<Object>(nameof(GetServerName), Result); }
        public int GetPingInMs(BlueprintSessionResult Result) { return Invoke<int>(nameof(GetPingInMs), Result); }
        public int GetMaxPlayers(BlueprintSessionResult Result) { return Invoke<int>(nameof(GetMaxPlayers), Result); }
        public int GetCurrentPlayers(BlueprintSessionResult Result) { return Invoke<int>(nameof(GetCurrentPlayers), Result); }
        public FindSessionsCallbackProxy FindSessions(Object WorldContextObject, PlayerController PlayerController, int MaxResults, bool bUseLAN) { return Invoke<FindSessionsCallbackProxy>(nameof(FindSessions), WorldContextObject, PlayerController, MaxResults, bUseLAN); }
    }
    public class FindTurnBasedMatchCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public FindTurnBasedMatchCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public FindTurnBasedMatchCallbackProxy FindTurnBasedMatch(Object WorldContextObject, PlayerController PlayerController, Object MatchActor, int MinPlayers, int MaxPlayers, int PlayerGroup, bool ShowExistingMatches) { return Invoke<FindTurnBasedMatchCallbackProxy>(nameof(FindTurnBasedMatch), WorldContextObject, PlayerController, MatchActor, MinPlayers, MaxPlayers, PlayerGroup, ShowExistingMatches); }
    }
    public class InAppPurchaseCallbackProxy2 : Object
    {
        public InAppPurchaseCallbackProxy2(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public InAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseUnprocessedPurchases(PlayerController PlayerController) { return Invoke<InAppPurchaseCallbackProxy2>(nameof(CreateProxyObjectForInAppPurchaseUnprocessedPurchases), PlayerController); }
        public InAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseQueryOwned(PlayerController PlayerController) { return Invoke<InAppPurchaseCallbackProxy2>(nameof(CreateProxyObjectForInAppPurchaseQueryOwned), PlayerController); }
        public InAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchase(PlayerController PlayerController, InAppPurchaseProductRequest2 ProductRequest) { return Invoke<InAppPurchaseCallbackProxy2>(nameof(CreateProxyObjectForInAppPurchase), PlayerController, ProductRequest); }
    }
    public class InAppPurchaseQueryCallbackProxy2 : Object
    {
        public InAppPurchaseQueryCallbackProxy2(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public InAppPurchaseQueryCallbackProxy2 CreateProxyObjectForInAppPurchaseQuery(PlayerController PlayerController, Array<Object> ProductIdentifiers) { return Invoke<InAppPurchaseQueryCallbackProxy2>(nameof(CreateProxyObjectForInAppPurchaseQuery), PlayerController, ProductIdentifiers); }
    }
    public class InAppPurchaseRestoreCallbackProxy2 : Object
    {
        public InAppPurchaseRestoreCallbackProxy2(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public InAppPurchaseRestoreCallbackProxy2 CreateProxyObjectForInAppPurchaseRestore(Array<InAppPurchaseProductRequest2> ConsumableProductFlags, PlayerController PlayerController) { return Invoke<InAppPurchaseRestoreCallbackProxy2>(nameof(CreateProxyObjectForInAppPurchaseRestore), ConsumableProductFlags, PlayerController); }
    }
    public class IpConnection : NetConnection
    {
        public IpConnection(nint addr) : base(addr) { }
        public float SocketErrorDisconnectDelay { get { return this[nameof(SocketErrorDisconnectDelay)].GetValue<float>(); } set { this[nameof(SocketErrorDisconnectDelay)].SetValue<float>(value); } }
    }
    public class IpNetDriver : NetDriver
    {
        public IpNetDriver(nint addr) : base(addr) { }
        public bool LogPortUnreach { get { return this[nameof(LogPortUnreach)].Flag; } set { this[nameof(LogPortUnreach)].Flag = value; } }
        public bool AllowPlayerPortUnreach { get { return this[nameof(AllowPlayerPortUnreach)].Flag; } set { this[nameof(AllowPlayerPortUnreach)].Flag = value; } }
        public uint MaxPortCountToTry { get { return this[nameof(MaxPortCountToTry)].GetValue<uint>(); } set { this[nameof(MaxPortCountToTry)].SetValue<uint>(value); } }
        public uint ServerDesiredSocketReceiveBufferBytes { get { return this[nameof(ServerDesiredSocketReceiveBufferBytes)].GetValue<uint>(); } set { this[nameof(ServerDesiredSocketReceiveBufferBytes)].SetValue<uint>(value); } }
        public uint ServerDesiredSocketSendBufferBytes { get { return this[nameof(ServerDesiredSocketSendBufferBytes)].GetValue<uint>(); } set { this[nameof(ServerDesiredSocketSendBufferBytes)].SetValue<uint>(value); } }
        public uint ClientDesiredSocketReceiveBufferBytes { get { return this[nameof(ClientDesiredSocketReceiveBufferBytes)].GetValue<uint>(); } set { this[nameof(ClientDesiredSocketReceiveBufferBytes)].SetValue<uint>(value); } }
        public uint ClientDesiredSocketSendBufferBytes { get { return this[nameof(ClientDesiredSocketSendBufferBytes)].GetValue<uint>(); } set { this[nameof(ClientDesiredSocketSendBufferBytes)].SetValue<uint>(value); } }
        public double MaxSecondsInReceive { get { return this[nameof(MaxSecondsInReceive)].GetValue<double>(); } set { this[nameof(MaxSecondsInReceive)].SetValue<double>(value); } }
        public int NbPacketsBetweenReceiveTimeTest { get { return this[nameof(NbPacketsBetweenReceiveTimeTest)].GetValue<int>(); } set { this[nameof(NbPacketsBetweenReceiveTimeTest)].SetValue<int>(value); } }
        public float ResolutionConnectionTimeout { get { return this[nameof(ResolutionConnectionTimeout)].GetValue<float>(); } set { this[nameof(ResolutionConnectionTimeout)].SetValue<float>(value); } }
    }
    public class JoinSessionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public JoinSessionCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public JoinSessionCallbackProxy JoinSession(Object WorldContextObject, PlayerController PlayerController, BlueprintSessionResult SearchResult) { return Invoke<JoinSessionCallbackProxy>(nameof(JoinSession), WorldContextObject, PlayerController, SearchResult); }
    }
    public class LeaderboardBlueprintLibrary : BlueprintFunctionLibrary
    {
        public LeaderboardBlueprintLibrary(nint addr) : base(addr) { }
        public bool WriteLeaderboardInteger(PlayerController PlayerController, Object StatName, int StatValue) { return Invoke<bool>(nameof(WriteLeaderboardInteger), PlayerController, StatName, StatValue); }
    }
    public class LeaderboardFlushCallbackProxy : Object
    {
        public LeaderboardFlushCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LeaderboardFlushCallbackProxy CreateProxyObjectForFlush(PlayerController PlayerController, Object SessionName) { return Invoke<LeaderboardFlushCallbackProxy>(nameof(CreateProxyObjectForFlush), PlayerController, SessionName); }
    }
    public class LeaderboardQueryCallbackProxy : Object
    {
        public LeaderboardQueryCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LeaderboardQueryCallbackProxy CreateProxyObjectForIntQuery(PlayerController PlayerController, Object StatName) { return Invoke<LeaderboardQueryCallbackProxy>(nameof(CreateProxyObjectForIntQuery), PlayerController, StatName); }
    }
    public class LogoutCallbackProxy : BlueprintAsyncActionBase
    {
        public LogoutCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LogoutCallbackProxy Logout(Object WorldContextObject, PlayerController PlayerController) { return Invoke<LogoutCallbackProxy>(nameof(Logout), WorldContextObject, PlayerController); }
    }
    public class OnlineBeacon : Actor
    {
        public OnlineBeacon(nint addr) : base(addr) { }
        public float BeaconConnectionInitialTimeout { get { return this[nameof(BeaconConnectionInitialTimeout)].GetValue<float>(); } set { this[nameof(BeaconConnectionInitialTimeout)].SetValue<float>(value); } }
        public float BeaconConnectionTimeout { get { return this[nameof(BeaconConnectionTimeout)].GetValue<float>(); } set { this[nameof(BeaconConnectionTimeout)].SetValue<float>(value); } }
        public NetDriver NetDriver { get { return this[nameof(NetDriver)].As<NetDriver>(); } set { this["NetDriver"] = value; } }
    }
    public class OnlineBeaconClient : OnlineBeacon
    {
        public OnlineBeaconClient(nint addr) : base(addr) { }
        public OnlineBeaconHostObject BeaconOwner { get { return this[nameof(BeaconOwner)].As<OnlineBeaconHostObject>(); } set { this["BeaconOwner"] = value; } }
        public NetConnection BeaconConnection { get { return this[nameof(BeaconConnection)].As<NetConnection>(); } set { this["BeaconConnection"] = value; } }
        public EBeaconConnectionState ConnectionState { get { return (EBeaconConnectionState)this[nameof(ConnectionState)].GetValue<int>(); } set { this[nameof(ConnectionState)].SetValue<int>((int)value); } }
        public void ClientOnConnected() { Invoke(nameof(ClientOnConnected)); }
    }
    public class OnlineBeaconHost : OnlineBeacon
    {
        public OnlineBeaconHost(nint addr) : base(addr) { }
        public int ListenPort { get { return this[nameof(ListenPort)].GetValue<int>(); } set { this[nameof(ListenPort)].SetValue<int>(value); } }
        public bool bAuthRequired { get { return this[nameof(bAuthRequired)].Flag; } set { this[nameof(bAuthRequired)].Flag = value; } }
        public uint MaxAuthTokenSize { get { return this[nameof(MaxAuthTokenSize)].GetValue<uint>(); } set { this[nameof(MaxAuthTokenSize)].SetValue<uint>(value); } }
        public Array<OnlineBeaconClient> ClientActors { get { return new Array<OnlineBeaconClient>(this[nameof(ClientActors)].Address); } }
    }
    public class OnlineBeaconHostObject : Actor
    {
        public OnlineBeaconHostObject(nint addr) : base(addr) { }
        public Object BeaconTypeName { get { return this[nameof(BeaconTypeName)]; } set { this[nameof(BeaconTypeName)] = value; } }
        public Object ClientBeaconActorClass { get { return this[nameof(ClientBeaconActorClass)]; } set { this[nameof(ClientBeaconActorClass)] = value; } }
        public Array<OnlineBeaconClient> ClientActors { get { return new Array<OnlineBeaconClient>(this[nameof(ClientActors)].Address); } }
    }
    public class OnlineEngineInterfaceImpl : OnlineEngineInterface
    {
        public OnlineEngineInterfaceImpl(nint addr) : base(addr) { }
        public Object MappedUniqueNetIdTypes { get { return this[nameof(MappedUniqueNetIdTypes)]; } set { this[nameof(MappedUniqueNetIdTypes)] = value; } }
        public Array<Object> CompatibleUniqueNetIdTypes { get { return new Array<Object>(this[nameof(CompatibleUniqueNetIdTypes)].Address); } }
        public Object VoiceSubsystemNameOverride { get { return this[nameof(VoiceSubsystemNameOverride)]; } set { this[nameof(VoiceSubsystemNameOverride)] = value; } }
    }
    public class OnlinePIESettings : DeveloperSettings
    {
        public OnlinePIESettings(nint addr) : base(addr) { }
        public bool bOnlinePIEEnabled { get { return this[nameof(bOnlinePIEEnabled)].Flag; } set { this[nameof(bOnlinePIEEnabled)].Flag = value; } }
        public Array<PIELoginSettingsInternal> Logins { get { return new Array<PIELoginSettingsInternal>(this[nameof(Logins)].Address); } }
    }
    public class OnlineServicesEngineInterfaceImpl : OnlineEngineInterface
    {
        public OnlineServicesEngineInterfaceImpl(nint addr) : base(addr) { }
    }
    public class OnlineSessionClient : OnlineSession
    {
        public OnlineSessionClient(nint addr) : base(addr) { }
        public bool bIsFromInvite { get { return this[nameof(bIsFromInvite)].Flag; } set { this[nameof(bIsFromInvite)].Flag = value; } }
        public bool bHandlingDisconnect { get { return this[nameof(bHandlingDisconnect)].Flag; } set { this[nameof(bHandlingDisconnect)].Flag = value; } }
    }
    public class PartyBeaconClient : OnlineBeaconClient
    {
        public PartyBeaconClient(nint addr) : base(addr) { }
        public Object DestSessionId { get { return this[nameof(DestSessionId)]; } set { this[nameof(DestSessionId)] = value; } }
        public PartyReservation PendingReservation { get { return this[nameof(PendingReservation)].As<PartyReservation>(); } set { this["PendingReservation"] = value; } }
        public EClientRequestType RequestType { get { return (EClientRequestType)this[nameof(RequestType)].GetValue<int>(); } set { this[nameof(RequestType)].SetValue<int>((int)value); } }
        public bool bPendingReservationSent { get { return this[nameof(bPendingReservationSent)].Flag; } set { this[nameof(bPendingReservationSent)].Flag = value; } }
        public bool bCancelReservation { get { return this[nameof(bCancelReservation)].Flag; } set { this[nameof(bCancelReservation)].Flag = value; } }
        public void ServerUpdateReservationRequest(Object SessionId, PartyReservation ReservationUpdate) { Invoke(nameof(ServerUpdateReservationRequest), SessionId, ReservationUpdate); }
        public void ServerReservationRequest(Object SessionId, PartyReservation Reservation) { Invoke(nameof(ServerReservationRequest), SessionId, Reservation); }
        public void ServerRemoveMemberFromReservationRequest(Object SessionId, PartyReservation ReservationUpdate) { Invoke(nameof(ServerRemoveMemberFromReservationRequest), SessionId, ReservationUpdate); }
        public void ServerCancelReservationRequest(UniqueNetIdRepl PartyLeader) { Invoke(nameof(ServerCancelReservationRequest), PartyLeader); }
        public void ServerAddOrUpdateReservationRequest(Object SessionId, PartyReservation Reservation) { Invoke(nameof(ServerAddOrUpdateReservationRequest), SessionId, Reservation); }
        public void ClientSendReservationUpdates(int NumRemainingReservations) { Invoke(nameof(ClientSendReservationUpdates), NumRemainingReservations); }
        public void ClientSendReservationFull() { Invoke(nameof(ClientSendReservationFull)); }
        public void ClientReservationResponse(byte ReservationResponse) { Invoke(nameof(ClientReservationResponse), ReservationResponse); }
        public void ClientCancelReservationResponse(byte ReservationResponse) { Invoke(nameof(ClientCancelReservationResponse), ReservationResponse); }
    }
    public class PartyBeaconHost : OnlineBeaconHostObject
    {
        public PartyBeaconHost(nint addr) : base(addr) { }
        public PartyBeaconState State { get { return this[nameof(State)].As<PartyBeaconState>(); } set { this["State"] = value; } }
        public bool bLogoutOnSessionTimeout { get { return this[nameof(bLogoutOnSessionTimeout)].Flag; } set { this[nameof(bLogoutOnSessionTimeout)].Flag = value; } }
        public float SessionTimeoutSecs { get { return this[nameof(SessionTimeoutSecs)].GetValue<float>(); } set { this[nameof(SessionTimeoutSecs)].SetValue<float>(value); } }
        public float TravelSessionTimeoutSecs { get { return this[nameof(TravelSessionTimeoutSecs)].GetValue<float>(); } set { this[nameof(TravelSessionTimeoutSecs)].SetValue<float>(value); } }
    }
    public class PartyBeaconState : Object
    {
        public PartyBeaconState(nint addr) : base(addr) { }
        public Object SessionName { get { return this[nameof(SessionName)]; } set { this[nameof(SessionName)] = value; } }
        public int NumConsumedReservations { get { return this[nameof(NumConsumedReservations)].GetValue<int>(); } set { this[nameof(NumConsumedReservations)].SetValue<int>(value); } }
        public int MaxReservations { get { return this[nameof(MaxReservations)].GetValue<int>(); } set { this[nameof(MaxReservations)].SetValue<int>(value); } }
        public int NumTeams { get { return this[nameof(NumTeams)].GetValue<int>(); } set { this[nameof(NumTeams)].SetValue<int>(value); } }
        public int NumPlayersPerTeam { get { return this[nameof(NumPlayersPerTeam)].GetValue<int>(); } set { this[nameof(NumPlayersPerTeam)].SetValue<int>(value); } }
        public Object TeamAssignmentMethod { get { return this[nameof(TeamAssignmentMethod)]; } set { this[nameof(TeamAssignmentMethod)] = value; } }
        public int ReservedHostTeamNum { get { return this[nameof(ReservedHostTeamNum)].GetValue<int>(); } set { this[nameof(ReservedHostTeamNum)].SetValue<int>(value); } }
        public int ForceTeamNum { get { return this[nameof(ForceTeamNum)].GetValue<int>(); } set { this[nameof(ForceTeamNum)].SetValue<int>(value); } }
        public bool bRestrictCrossConsole { get { return this[nameof(bRestrictCrossConsole)].Flag; } set { this[nameof(bRestrictCrossConsole)].Flag = value; } }
        public Array<Object> PlatformCrossplayRestrictions { get { return new Array<Object>(this[nameof(PlatformCrossplayRestrictions)].Address); } }
        public Array<PartyBeaconCrossplayPlatformMapping> PlatformTypeMapping { get { return new Array<PartyBeaconCrossplayPlatformMapping>(this[nameof(PlatformTypeMapping)].Address); } }
        public bool bEnableRemovalRequests { get { return this[nameof(bEnableRemovalRequests)].Flag; } set { this[nameof(bEnableRemovalRequests)].Flag = value; } }
        public Array<PartyReservation> Reservations { get { return new Array<PartyReservation>(this[nameof(Reservations)].Address); } }
    }
    public class QuitMatchCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public QuitMatchCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public QuitMatchCallbackProxy QuitMatch(Object WorldContextObject, PlayerController PlayerController, Object MatchID, byte Outcome, int TurnTimeoutInSeconds) { return Invoke<QuitMatchCallbackProxy>(nameof(QuitMatch), WorldContextObject, PlayerController, MatchID, Outcome, TurnTimeoutInSeconds); }
    }
    public class ShowLoginUICallbackProxy : BlueprintAsyncActionBase
    {
        public ShowLoginUICallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public ShowLoginUICallbackProxy ShowExternalLoginUI(Object WorldContextObject, PlayerController InPlayerController) { return Invoke<ShowLoginUICallbackProxy>(nameof(ShowExternalLoginUI), WorldContextObject, InPlayerController); }
    }
    public class SpectatorBeaconClient : OnlineBeaconClient
    {
        public SpectatorBeaconClient(nint addr) : base(addr) { }
        public Object DestSessionId { get { return this[nameof(DestSessionId)]; } set { this[nameof(DestSessionId)] = value; } }
        public SpectatorReservation PendingReservation { get { return this[nameof(PendingReservation)].As<SpectatorReservation>(); } set { this["PendingReservation"] = value; } }
        public ESpectatorClientRequestType RequestType { get { return (ESpectatorClientRequestType)this[nameof(RequestType)].GetValue<int>(); } set { this[nameof(RequestType)].SetValue<int>((int)value); } }
        public bool bPendingReservationSent { get { return this[nameof(bPendingReservationSent)].Flag; } set { this[nameof(bPendingReservationSent)].Flag = value; } }
        public bool bCancelReservation { get { return this[nameof(bCancelReservation)].Flag; } set { this[nameof(bCancelReservation)].Flag = value; } }
        public void ServerReservationRequest(Object SessionId, SpectatorReservation Reservation) { Invoke(nameof(ServerReservationRequest), SessionId, Reservation); }
        public void ServerCancelReservationRequest(UniqueNetIdRepl Spectator) { Invoke(nameof(ServerCancelReservationRequest), Spectator); }
        public void ClientSendReservationUpdates(int NumRemainingReservations) { Invoke(nameof(ClientSendReservationUpdates), NumRemainingReservations); }
        public void ClientSendReservationFull() { Invoke(nameof(ClientSendReservationFull)); }
        public void ClientReservationResponse(byte ReservationResponse) { Invoke(nameof(ClientReservationResponse), ReservationResponse); }
        public void ClientCancelReservationResponse(byte ReservationResponse) { Invoke(nameof(ClientCancelReservationResponse), ReservationResponse); }
    }
    public class SpectatorBeaconHost : OnlineBeaconHostObject
    {
        public SpectatorBeaconHost(nint addr) : base(addr) { }
        public SpectatorBeaconState State { get { return this[nameof(State)].As<SpectatorBeaconState>(); } set { this["State"] = value; } }
        public bool bLogoutOnSessionTimeout { get { return this[nameof(bLogoutOnSessionTimeout)].Flag; } set { this[nameof(bLogoutOnSessionTimeout)].Flag = value; } }
        public float SessionTimeoutSecs { get { return this[nameof(SessionTimeoutSecs)].GetValue<float>(); } set { this[nameof(SessionTimeoutSecs)].SetValue<float>(value); } }
        public float TravelSessionTimeoutSecs { get { return this[nameof(TravelSessionTimeoutSecs)].GetValue<float>(); } set { this[nameof(TravelSessionTimeoutSecs)].SetValue<float>(value); } }
    }
    public class SpectatorBeaconState : Object
    {
        public SpectatorBeaconState(nint addr) : base(addr) { }
        public Object SessionName { get { return this[nameof(SessionName)]; } set { this[nameof(SessionName)] = value; } }
        public int NumConsumedReservations { get { return this[nameof(NumConsumedReservations)].GetValue<int>(); } set { this[nameof(NumConsumedReservations)].SetValue<int>(value); } }
        public int MaxReservations { get { return this[nameof(MaxReservations)].GetValue<int>(); } set { this[nameof(MaxReservations)].SetValue<int>(value); } }
        public bool bRestrictCrossConsole { get { return this[nameof(bRestrictCrossConsole)].Flag; } set { this[nameof(bRestrictCrossConsole)].Flag = value; } }
        public Array<SpectatorReservation> Reservations { get { return new Array<SpectatorReservation>(this[nameof(Reservations)].Address); } }
    }
    public class TestBeaconClient : OnlineBeaconClient
    {
        public TestBeaconClient(nint addr) : base(addr) { }
        public void ServerPong() { Invoke(nameof(ServerPong)); }
        public void ClientPing() { Invoke(nameof(ClientPing)); }
    }
    public class TestBeaconHost : OnlineBeaconHostObject
    {
        public TestBeaconHost(nint addr) : base(addr) { }
    }
    public class TurnBasedBlueprintLibrary : BlueprintFunctionLibrary
    {
        public TurnBasedBlueprintLibrary(nint addr) : base(addr) { }
        public void RegisterTurnBasedMatchInterfaceObject(Object WorldContextObject, PlayerController PlayerController, Object Object) { Invoke(nameof(RegisterTurnBasedMatchInterfaceObject), WorldContextObject, PlayerController, Object); }
        public void GetPlayerDisplayName(Object WorldContextObject, PlayerController PlayerController, Object MatchID, int PlayerIndex, Object PlayerDisplayName) { Invoke(nameof(GetPlayerDisplayName), WorldContextObject, PlayerController, MatchID, PlayerIndex, PlayerDisplayName); }
        public void GetMyPlayerIndex(Object WorldContextObject, PlayerController PlayerController, Object MatchID, int PlayerIndex) { Invoke(nameof(GetMyPlayerIndex), WorldContextObject, PlayerController, MatchID, PlayerIndex); }
        public void GetIsMyTurn(Object WorldContextObject, PlayerController PlayerController, Object MatchID, bool bIsMyTurn) { Invoke(nameof(GetIsMyTurn), WorldContextObject, PlayerController, MatchID, bIsMyTurn); }
    }
    public class VoipListenerSynthComponent : SynthComponent
    {
        public VoipListenerSynthComponent(nint addr) : base(addr) { }
        public bool IsIdling() { return Invoke<bool>(nameof(IsIdling)); }
    }
    public class BlueprintSessionResult : Object
    {
        public BlueprintSessionResult(nint addr) : base(addr) { }
    }
    public class OnlineProxyStoreOffer : Object
    {
        public OnlineProxyStoreOffer(nint addr) : base(addr) { }
        public Object OfferId { get { return this[nameof(OfferId)]; } set { this[nameof(OfferId)] = value; } }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object LongDescription { get { return this[nameof(LongDescription)]; } set { this[nameof(LongDescription)] = value; } }
        public Object RegularPriceText { get { return this[nameof(RegularPriceText)]; } set { this[nameof(RegularPriceText)] = value; } }
        public int RegularPrice { get { return this[nameof(RegularPrice)].GetValue<int>(); } set { this[nameof(RegularPrice)].SetValue<int>(value); } }
        public Object PriceText { get { return this[nameof(PriceText)]; } set { this[nameof(PriceText)] = value; } }
        public int NumericPrice { get { return this[nameof(NumericPrice)].GetValue<int>(); } set { this[nameof(NumericPrice)].SetValue<int>(value); } }
        public Object CurrencyCode { get { return this[nameof(CurrencyCode)]; } set { this[nameof(CurrencyCode)] = value; } }
        public DateTime ReleaseDate { get { return this[nameof(ReleaseDate)].As<DateTime>(); } set { this["ReleaseDate"] = value; } }
        public DateTime ExpirationDate { get { return this[nameof(ExpirationDate)].As<DateTime>(); } set { this["ExpirationDate"] = value; } }
        public EOnlineProxyStoreOfferDiscountType DiscountType { get { return (EOnlineProxyStoreOfferDiscountType)this[nameof(DiscountType)].GetValue<int>(); } set { this[nameof(DiscountType)].SetValue<int>((int)value); } }
        public Object DynamicFields { get { return this[nameof(DynamicFields)]; } set { this[nameof(DynamicFields)] = value; } }
    }
    public enum EOnlineProxyStoreOfferDiscountType : int
    {
        NotOnSale = 0,
        Percentage = 1,
        DiscountAmount = 2,
        PayAmount = 3,
        EOnlineProxyStoreOfferDiscountType_MAX = 4,
    }
    public class InAppPurchaseRestoreInfo2 : Object
    {
        public InAppPurchaseRestoreInfo2(nint addr) : base(addr) { }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
        public Object ItemId { get { return this[nameof(ItemId)]; } set { this[nameof(ItemId)] = value; } }
        public Object ValidationInfo { get { return this[nameof(ValidationInfo)]; } set { this[nameof(ValidationInfo)] = value; } }
    }
    public enum EInAppPurchaseStatus : int
    {
        Invalid = 0,
        Failed = 1,
        Deferred = 2,
        Canceled = 3,
        Purchased = 4,
        Restored = 5,
        EInAppPurchaseStatus_MAX = 6,
    }
    public class InAppPurchaseReceiptInfo2 : Object
    {
        public InAppPurchaseReceiptInfo2(nint addr) : base(addr) { }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
        public Object ItemId { get { return this[nameof(ItemId)]; } set { this[nameof(ItemId)] = value; } }
        public Object ValidationInfo { get { return this[nameof(ValidationInfo)]; } set { this[nameof(ValidationInfo)] = value; } }
    }
    public enum EBeaconConnectionState : int
    {
        Invalid = 0,
        Closed = 1,
        Pending = 2,
        Open = 3,
        EBeaconConnectionState_MAX = 4,
    }
    public enum EClientRequestType : int
    {
        NonePending = 0,
        ExistingSessionReservation = 1,
        ReservationUpdate = 2,
        EmptyServerReservation = 3,
        Reconnect = 4,
        Abandon = 5,
        ReservationRemoveMembers = 6,
        AddOrUpdateReservation = 7,
        EClientRequestType_MAX = 8,
    }
    public enum EPartyReservationResult : int
    {
        NoResult = 0,
        RequestPending = 1,
        GeneralError = 2,
        PartyLimitReached = 3,
        IncorrectPlayerCount = 4,
        RequestTimedOut = 5,
        ReservationDuplicate = 6,
        ReservationNotFound = 7,
        ReservationAccepted = 8,
        ReservationDenied = 9,
        ReservationDenied_CrossPlayRestriction = 10,
        ReservationDenied_Banned = 11,
        ReservationRequestCanceled = 12,
        ReservationInvalid = 13,
        BadSessionId = 14,
        ReservationDenied_ContainsExistingPlayers = 15,
        EPartyReservationResult_MAX = 16,
    }
    public enum ESpectatorClientRequestType : int
    {
        NonePending = 0,
        ExistingSessionReservation = 1,
        ReservationUpdate = 2,
        EmptyServerReservation = 3,
        Reconnect = 4,
        Abandon = 5,
        ESpectatorClientRequestType_MAX = 6,
    }
    public enum ESpectatorReservationResult : int
    {
        NoResult = 0,
        RequestPending = 1,
        GeneralError = 2,
        SpectatorLimitReached = 3,
        IncorrectPlayerCount = 4,
        RequestTimedOut = 5,
        ReservationDuplicate = 6,
        ReservationNotFound = 7,
        ReservationAccepted = 8,
        ReservationDenied = 9,
        ReservationDenied_CrossPlayRestriction = 10,
        ReservationDenied_Banned = 11,
        ReservationRequestCanceled = 12,
        ReservationInvalid = 13,
        BadSessionId = 14,
        ReservationDenied_ContainsExistingPlayers = 15,
        ESpectatorReservationResult_MAX = 16,
    }
    public class PlayerReservation : Object
    {
        public PlayerReservation(nint addr) : base(addr) { }
        public UniqueNetIdRepl UniqueId { get { return this[nameof(UniqueId)].As<UniqueNetIdRepl>(); } set { this["UniqueId"] = value; } }
        public Object ValidationStr { get { return this[nameof(ValidationStr)]; } set { this[nameof(ValidationStr)] = value; } }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public bool bAllowCrossplay { get { return this[nameof(bAllowCrossplay)].Flag; } set { this[nameof(bAllowCrossplay)].Flag = value; } }
        public float ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<float>(); } set { this[nameof(ElapsedTime)].SetValue<float>(value); } }
    }
    public class InAppPurchaseProductRequest2 : Object
    {
        public InAppPurchaseProductRequest2(nint addr) : base(addr) { }
        public Object ProductIdentifier { get { return this[nameof(ProductIdentifier)]; } set { this[nameof(ProductIdentifier)] = value; } }
        public bool bIsConsumable { get { return this[nameof(bIsConsumable)].Flag; } set { this[nameof(bIsConsumable)].Flag = value; } }
    }
    public class InAppPurchaseProductInfo2 : Object
    {
        public InAppPurchaseProductInfo2(nint addr) : base(addr) { }
        public Object Identifier { get { return this[nameof(Identifier)]; } set { this[nameof(Identifier)] = value; } }
        public Object TransactionIdentifier { get { return this[nameof(TransactionIdentifier)]; } set { this[nameof(TransactionIdentifier)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object DisplayDescription { get { return this[nameof(DisplayDescription)]; } set { this[nameof(DisplayDescription)] = value; } }
        public Object DisplayPrice { get { return this[nameof(DisplayPrice)]; } set { this[nameof(DisplayPrice)] = value; } }
        public float RawPrice { get { return this[nameof(RawPrice)].GetValue<float>(); } set { this[nameof(RawPrice)].SetValue<float>(value); } }
        public Object CurrencyCode { get { return this[nameof(CurrencyCode)]; } set { this[nameof(CurrencyCode)] = value; } }
        public Object CurrencySymbol { get { return this[nameof(CurrencySymbol)]; } set { this[nameof(CurrencySymbol)] = value; } }
        public Object DecimalSeparator { get { return this[nameof(DecimalSeparator)]; } set { this[nameof(DecimalSeparator)] = value; } }
        public Object GroupingSeparator { get { return this[nameof(GroupingSeparator)]; } set { this[nameof(GroupingSeparator)] = value; } }
        public Object ReceiptData { get { return this[nameof(ReceiptData)]; } set { this[nameof(ReceiptData)] = value; } }
        public Object DynamicFields { get { return this[nameof(DynamicFields)]; } set { this[nameof(DynamicFields)] = value; } }
    }
    public class PIELoginSettingsInternal : Object
    {
        public PIELoginSettingsInternal(nint addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Token { get { return this[nameof(Token)]; } set { this[nameof(Token)] = value; } }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public Array<byte> TokenBytes { get { return new Array<byte>(this[nameof(TokenBytes)].Address); } }
    }
    public class PartyReservation : Object
    {
        public PartyReservation(nint addr) : base(addr) { }
        public int TeamNum { get { return this[nameof(TeamNum)].GetValue<int>(); } set { this[nameof(TeamNum)].SetValue<int>(value); } }
        public UniqueNetIdRepl PartyLeader { get { return this[nameof(PartyLeader)].As<UniqueNetIdRepl>(); } set { this["PartyLeader"] = value; } }
        public Array<PlayerReservation> PartyMembers { get { return new Array<PlayerReservation>(this[nameof(PartyMembers)].Address); } }
        public Array<PlayerReservation> RemovedPartyMembers { get { return new Array<PlayerReservation>(this[nameof(RemovedPartyMembers)].Address); } }
    }
    public class PartyBeaconCrossplayPlatformMapping : Object
    {
        public PartyBeaconCrossplayPlatformMapping(nint addr) : base(addr) { }
        public Object PlatformName { get { return this[nameof(PlatformName)]; } set { this[nameof(PlatformName)] = value; } }
        public Object PlatformType { get { return this[nameof(PlatformType)]; } set { this[nameof(PlatformType)] = value; } }
    }
    public class SpectatorReservation : Object
    {
        public SpectatorReservation(nint addr) : base(addr) { }
        public UniqueNetIdRepl SpectatorId { get { return this[nameof(SpectatorId)].As<UniqueNetIdRepl>(); } set { this["SpectatorId"] = value; } }
        public PlayerReservation Spectator { get { return this[nameof(Spectator)].As<PlayerReservation>(); } set { this["Spectator"] = value; } }
    }
}
