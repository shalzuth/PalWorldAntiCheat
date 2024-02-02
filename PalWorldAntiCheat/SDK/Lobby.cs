using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreOnlineSDK;
using SDK.Script.NetCoreSDK;
namespace SDK.Script.LobbySDK
{
    public class LobbyBeaconClient : OnlineBeaconClient
    {
        public LobbyBeaconClient(nint addr) : base(addr) { }
        public LobbyBeaconState LobbyState { get { return this[nameof(LobbyState)].As<LobbyBeaconState>(); } set { this["LobbyState"] = value; } }
        public LobbyBeaconPlayerState PlayerState { get { return this[nameof(PlayerState)].As<LobbyBeaconPlayerState>(); } set { this["PlayerState"] = value; } }
        public ELobbyBeaconJoinState LobbyJoinServerState { get { return (ELobbyBeaconJoinState)this[nameof(LobbyJoinServerState)].GetValue<int>(); } set { this[nameof(LobbyJoinServerState)].SetValue<int>((int)value); } }
        public void ServerSetPartyOwner(UniqueNetIdRepl InUniqueId, UniqueNetIdRepl InPartyOwnerId) { Invoke(nameof(ServerSetPartyOwner), InUniqueId, InPartyOwnerId); }
        public void ServerNotifyJoiningServer() { Invoke(nameof(ServerNotifyJoiningServer)); }
        public void ServerLoginPlayer(Object InSessionId, UniqueNetIdRepl InUniqueId, Object UrlString) { Invoke(nameof(ServerLoginPlayer), InSessionId, InUniqueId, UrlString); }
        public void ServerKickPlayer(UniqueNetIdRepl PlayerToKick, Object Reason) { Invoke(nameof(ServerKickPlayer), PlayerToKick, Reason); }
        public void ServerDisconnectFromLobby() { Invoke(nameof(ServerDisconnectFromLobby)); }
        public void ServerCheat(Object Msg) { Invoke(nameof(ServerCheat), Msg); }
        public void ClientWasKicked(Object KickReason) { Invoke(nameof(ClientWasKicked), KickReason); }
        public void ClientSetInviteFlags(JoinabilitySettings Settings) { Invoke(nameof(ClientSetInviteFlags), Settings); }
        public void ClientPlayerLeft(UniqueNetIdRepl InUniqueId) { Invoke(nameof(ClientPlayerLeft), InUniqueId); }
        public void ClientPlayerJoined(Object NewPlayerName, UniqueNetIdRepl InUniqueId) { Invoke(nameof(ClientPlayerJoined), NewPlayerName, InUniqueId); }
        public void ClientLoginComplete(UniqueNetIdRepl InUniqueId, bool bWasSuccessful) { Invoke(nameof(ClientLoginComplete), InUniqueId, bWasSuccessful); }
        public void ClientJoinGame() { Invoke(nameof(ClientJoinGame)); }
        public void ClientAckJoiningServer() { Invoke(nameof(ClientAckJoiningServer)); }
    }
    public class LobbyBeaconHost : OnlineBeaconHostObject
    {
        public LobbyBeaconHost(nint addr) : base(addr) { }
        public Object LobbyStateClass { get { return this[nameof(LobbyStateClass)]; } set { this[nameof(LobbyStateClass)] = value; } }
        public LobbyBeaconState LobbyState { get { return this[nameof(LobbyState)].As<LobbyBeaconState>(); } set { this["LobbyState"] = value; } }
    }
    public class LobbyBeaconPlayerState : Info
    {
        public LobbyBeaconPlayerState(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public UniqueNetIdRepl UniqueId { get { return this[nameof(UniqueId)].As<UniqueNetIdRepl>(); } set { this["UniqueId"] = value; } }
        public UniqueNetIdRepl PartyOwnerUniqueId { get { return this[nameof(PartyOwnerUniqueId)].As<UniqueNetIdRepl>(); } set { this["PartyOwnerUniqueId"] = value; } }
        public bool bInLobby { get { return this[nameof(bInLobby)].Flag; } set { this[nameof(bInLobby)].Flag = value; } }
        public OnlineBeaconClient ClientActor { get { return this[nameof(ClientActor)].As<OnlineBeaconClient>(); } set { this["ClientActor"] = value; } }
        public void OnRep_UniqueId() { Invoke(nameof(OnRep_UniqueId)); }
        public void OnRep_PartyOwner() { Invoke(nameof(OnRep_PartyOwner)); }
        public void OnRep_InLobby() { Invoke(nameof(OnRep_InLobby)); }
    }
    public class LobbyBeaconState : Info
    {
        public LobbyBeaconState(nint addr) : base(addr) { }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public Object LobbyBeaconPlayerStateClass { get { return this[nameof(LobbyBeaconPlayerStateClass)]; } set { this[nameof(LobbyBeaconPlayerStateClass)] = value; } }
        public bool bLobbyStarted { get { return this[nameof(bLobbyStarted)].Flag; } set { this[nameof(bLobbyStarted)].Flag = value; } }
        public float WaitForPlayersTimeRemaining { get { return this[nameof(WaitForPlayersTimeRemaining)].GetValue<float>(); } set { this[nameof(WaitForPlayersTimeRemaining)].SetValue<float>(value); } }
        public LobbyPlayerStateInfoArray Players { get { return this[nameof(Players)].As<LobbyPlayerStateInfoArray>(); } set { this["Players"] = value; } }
        public void OnRep_WaitForPlayersTimeRemaining() { Invoke(nameof(OnRep_WaitForPlayersTimeRemaining)); }
        public void OnRep_LobbyStarted() { Invoke(nameof(OnRep_LobbyStarted)); }
    }
    public enum ELobbyBeaconJoinState : int
    {
        None = 0,
        SentJoinRequest = 1,
        JoinRequestAcknowledged = 2,
        ELobbyBeaconJoinState_MAX = 3,
    }
    public class LobbyPlayerStateActorInfo : FastArraySerializerItem
    {
        public LobbyPlayerStateActorInfo(nint addr) : base(addr) { }
        public LobbyBeaconPlayerState LobbyPlayerState { get { return this[nameof(LobbyPlayerState)].As<LobbyBeaconPlayerState>(); } set { this["LobbyPlayerState"] = value; } }
    }
    public class LobbyPlayerStateInfoArray : FastArraySerializer
    {
        public LobbyPlayerStateInfoArray(nint addr) : base(addr) { }
        public Array<LobbyPlayerStateActorInfo> Players { get { return new Array<LobbyPlayerStateActorInfo>(this[nameof(Players)].Address); } }
        public LobbyBeaconState ParentState { get { return this[nameof(ParentState)].As<LobbyBeaconState>(); } set { this["ParentState"] = value; } }
    }
}
