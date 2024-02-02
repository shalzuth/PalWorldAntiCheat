using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.PartySDK
{
    public class Chatroom : Object
    {
        public Chatroom(nint addr) : base(addr) { }
        public Object CurrentChatRoomId { get { return this[nameof(CurrentChatRoomId)]; } set { this[nameof(CurrentChatRoomId)] = value; } }
        public int MaxChatRoomRetries { get { return this[nameof(MaxChatRoomRetries)].GetValue<int>(); } set { this[nameof(MaxChatRoomRetries)].SetValue<int>(value); } }
        public int NumChatRoomRetries { get { return this[nameof(NumChatRoomRetries)].GetValue<int>(); } set { this[nameof(NumChatRoomRetries)].SetValue<int>(value); } }
    }
    public class SocialManager : Object
    {
        public SocialManager(nint addr) : base(addr) { }
        public Array<SocialToolkit> SocialToolkits { get { return new Array<SocialToolkit>(this[nameof(SocialToolkits)].Address); } }
        public SocialDebugTools SocialDebugTools { get { return this[nameof(SocialDebugTools)].As<SocialDebugTools>(); } set { this["SocialDebugTools"] = value; } }
    }
    public class SocialToolkit : Object
    {
        public SocialToolkit(nint addr) : base(addr) { }
        public SocialUser LocalUser { get { return this[nameof(LocalUser)].As<SocialUser>(); } set { this["LocalUser"] = value; } }
        public Array<SocialUser> AllUsers { get { return new Array<SocialUser>(this[nameof(AllUsers)].Address); } }
        public Object LocalPlayerOwner { get { return this[nameof(LocalPlayerOwner)]; } set { this[nameof(LocalPlayerOwner)] = value; } }
        public SocialChatManager SocialChatManager { get { return this[nameof(SocialChatManager)].As<SocialChatManager>(); } set { this["SocialChatManager"] = value; } }
    }
    public class SocialChatManager : Object
    {
        public SocialChatManager(nint addr) : base(addr) { }
        public Object DirectChannelsByTargetUser { get { return this[nameof(DirectChannelsByTargetUser)]; } set { this[nameof(DirectChannelsByTargetUser)] = value; } }
        public Object ChatRoomsById { get { return this[nameof(ChatRoomsById)]; } set { this[nameof(ChatRoomsById)] = value; } }
        public Object ReadOnlyChannelsByDisplayName { get { return this[nameof(ReadOnlyChannelsByDisplayName)]; } set { this[nameof(ReadOnlyChannelsByDisplayName)] = value; } }
        public bool bEnableChatSlashCommands { get { return this[nameof(bEnableChatSlashCommands)].Flag; } set { this[nameof(bEnableChatSlashCommands)].Flag = value; } }
        public Object GroupChannels { get { return this[nameof(GroupChannels)]; } set { this[nameof(GroupChannels)] = value; } }
    }
    public class SocialChatChannel : Object
    {
        public SocialChatChannel(nint addr) : base(addr) { }
    }
    public class SocialChatRoom : SocialChatChannel
    {
        public SocialChatRoom(nint addr) : base(addr) { }
    }
    public class SocialGroupChannel : Object
    {
        public SocialGroupChannel(nint addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
        public UniqueNetIdRepl GroupID { get { return this[nameof(GroupID)].As<UniqueNetIdRepl>(); } set { this["GroupID"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Array<SocialUser> Members { get { return new Array<SocialUser>(this[nameof(Members)].Address); } }
    }
    public class SocialPartyChatRoom : SocialChatRoom
    {
        public SocialPartyChatRoom(nint addr) : base(addr) { }
    }
    public class SocialPrivateMessageChannel : SocialChatChannel
    {
        public SocialPrivateMessageChannel(nint addr) : base(addr) { }
        public SocialUser TargetUser { get { return this[nameof(TargetUser)].As<SocialUser>(); } set { this["TargetUser"] = value; } }
    }
    public class SocialReadOnlyChatChannel : SocialChatChannel
    {
        public SocialReadOnlyChatChannel(nint addr) : base(addr) { }
    }
    public class SocialParty : Object
    {
        public SocialParty(nint addr) : base(addr) { }
        public Object ReservationBeaconClientClass { get { return this[nameof(ReservationBeaconClientClass)]; } set { this[nameof(ReservationBeaconClientClass)] = value; } }
        public Object SpectatorBeaconClientClass { get { return this[nameof(SpectatorBeaconClientClass)]; } set { this[nameof(SpectatorBeaconClientClass)] = value; } }
        public UniqueNetIdRepl OwningLocalUserId { get { return this[nameof(OwningLocalUserId)].As<UniqueNetIdRepl>(); } set { this["OwningLocalUserId"] = value; } }
        public UniqueNetIdRepl CurrentLeaderId { get { return this[nameof(CurrentLeaderId)].As<UniqueNetIdRepl>(); } set { this["CurrentLeaderId"] = value; } }
        public Object PartyMembersById { get { return this[nameof(PartyMembersById)]; } set { this[nameof(PartyMembersById)] = value; } }
        public bool bEnableAutomaticPartyRejoin { get { return this[nameof(bEnableAutomaticPartyRejoin)].Flag; } set { this[nameof(bEnableAutomaticPartyRejoin)].Flag = value; } }
        public double PlatformUserInviteCooldown { get { return this[nameof(PlatformUserInviteCooldown)].GetValue<double>(); } set { this[nameof(PlatformUserInviteCooldown)].SetValue<double>(value); } }
        public double PrimaryUserInviteCooldown { get { return this[nameof(PrimaryUserInviteCooldown)].GetValue<double>(); } set { this[nameof(PrimaryUserInviteCooldown)].SetValue<double>(value); } }
        public Object ReservationBeaconClient { get { return this[nameof(ReservationBeaconClient)]; } set { this[nameof(ReservationBeaconClient)] = value; } }
        public Object SpectatorBeaconClient { get { return this[nameof(SpectatorBeaconClient)]; } set { this[nameof(SpectatorBeaconClient)] = value; } }
        public float JoinInProgressTimerRate { get { return this[nameof(JoinInProgressTimerRate)].GetValue<float>(); } set { this[nameof(JoinInProgressTimerRate)].SetValue<float>(value); } }
        public int JoinInProgressRequestTimeout { get { return this[nameof(JoinInProgressRequestTimeout)].GetValue<int>(); } set { this[nameof(JoinInProgressRequestTimeout)].SetValue<int>(value); } }
        public int JoinInProgressResponseTimeout { get { return this[nameof(JoinInProgressResponseTimeout)].GetValue<int>(); } set { this[nameof(JoinInProgressResponseTimeout)].SetValue<int>(value); } }
    }
    public class PartyMember : Object
    {
        public PartyMember(nint addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
    }
    public class SocialDebugTools : Object
    {
        public SocialDebugTools(nint addr) : base(addr) { }
    }
    public class SocialSettings : Object
    {
        public SocialSettings(nint addr) : base(addr) { }
        public Array<Object> OssNamesWithEnvironmentIdPrefix { get { return new Array<Object>(this[nameof(OssNamesWithEnvironmentIdPrefix)].Address); } }
        public int DefaultMaxPartySize { get { return this[nameof(DefaultMaxPartySize)].GetValue<int>(); } set { this[nameof(DefaultMaxPartySize)].SetValue<int>(value); } }
        public bool bPreferPlatformInvites { get { return this[nameof(bPreferPlatformInvites)].Flag; } set { this[nameof(bPreferPlatformInvites)].Flag = value; } }
        public bool bMustSendPrimaryInvites { get { return this[nameof(bMustSendPrimaryInvites)].Flag; } set { this[nameof(bMustSendPrimaryInvites)].Flag = value; } }
        public bool bLeavePartyOnDisconnect { get { return this[nameof(bLeavePartyOnDisconnect)].Flag; } set { this[nameof(bLeavePartyOnDisconnect)].Flag = value; } }
        public bool bSetDesiredPrivacyOnLocalPlayerBecomesLeader { get { return this[nameof(bSetDesiredPrivacyOnLocalPlayerBecomesLeader)].Flag; } set { this[nameof(bSetDesiredPrivacyOnLocalPlayerBecomesLeader)].Flag = value; } }
        public float UserListAutoUpdateRate { get { return this[nameof(UserListAutoUpdateRate)].GetValue<float>(); } set { this[nameof(UserListAutoUpdateRate)].SetValue<float>(value); } }
        public int MinNicknameLength { get { return this[nameof(MinNicknameLength)].GetValue<int>(); } set { this[nameof(MinNicknameLength)].SetValue<int>(value); } }
        public int MaxNicknameLength { get { return this[nameof(MaxNicknameLength)].GetValue<int>(); } set { this[nameof(MaxNicknameLength)].SetValue<int>(value); } }
        public Array<SocialPlatformDescription> SocialPlatformDescriptions { get { return new Array<SocialPlatformDescription>(this[nameof(SocialPlatformDescriptions)].Address); } }
    }
    public class SocialUser : Object
    {
        public SocialUser(nint addr) : base(addr) { }
    }
    public enum ESocialChannelType : int
    {
        General = 0,
        Founder = 1,
        Party = 2,
        Team = 3,
        System = 4,
        Private = 5,
        ESocialChannelType_MAX = 6,
    }
    public enum EPartyType : int
    {
        Public = 0,
        FriendsOnly = 1,
        Private = 2,
        EPartyType_MAX = 3,
    }
    public enum EPartyInviteRestriction : int
    {
        AnyMember = 0,
        LeaderOnly = 1,
        NoInvites = 2,
        EPartyInviteRestriction_MAX = 3,
    }
    public enum EPartyJoinDenialReason : int
    {
        NoReason = 0,
        JoinAttemptAborted = 1,
        Busy = 2,
        OssUnavailable = 3,
        PartyFull = 4,
        GameFull = 5,
        NotPartyLeader = 6,
        PartyPrivate = 7,
        JoinerCrossplayRestricted = 8,
        MemberCrossplayRestricted = 9,
        GameModeRestricted = 10,
        Banned = 11,
        NotLoggedIn = 12,
        CheckingForRejoin = 13,
        TargetUserMissingPresence = 14,
        TargetUserUnjoinable = 15,
        TargetUserAway = 16,
        AlreadyLeaderInPlatformSession = 17,
        TargetUserPlayingDifferentGame = 18,
        TargetUserMissingPlatformSession = 19,
        PlatformSessionMissingJoinInfo = 20,
        FailedToStartFindConsoleSession = 21,
        MissingPartyClassForTypeId = 22,
        TargetUserBlocked = 23,
        CustomReason0 = 24,
        CustomReason1 = 25,
        CustomReason2 = 26,
        CustomReason3 = 27,
        CustomReason4 = 28,
        CustomReason5 = 29,
        CustomReason6 = 30,
        CustomReason7 = 31,
        CustomReason8 = 32,
        CustomReason9 = 33,
        CustomReason10 = 34,
        CustomReason11 = 35,
        CustomReason12 = 36,
        CustomReason13 = 37,
        CustomReason14 = 38,
        CustomReason15 = 39,
        CustomReason16 = 40,
        CustomReason17 = 41,
        CustomReason18 = 42,
        CustomReason19 = 43,
        CustomReason20 = 44,
        CustomReason21 = 45,
        CustomReason22 = 46,
        CustomReason23 = 47,
        CustomReason24 = 48,
        CustomReason25 = 49,
        CustomReason26 = 50,
        CustomReason27 = 51,
        CustomReason28 = 52,
        CustomReason29 = 53,
        CustomReason30 = 54,
        CustomReason31 = 55,
        CustomReason32 = 56,
        CustomReason33 = 57,
        CustomReason34 = 58,
        CustomReason35 = 59,
        CustomReason36 = 60,
        CustomReason37 = 61,
        CustomReason38 = 62,
        CustomReason39 = 63,
        MAX = 64,
    }
    public enum EApprovalAction : int
    {
        Approve = 0,
        Enqueue = 1,
        EnqueueAndStartBeacon = 2,
        Deny = 3,
        EApprovalAction_MAX = 4,
    }
    public enum ESocialPartyInviteMethod : int
    {
        Other = 0,
        Notification = 1,
        Custom1 = 2,
        ESocialPartyInviteMethod_MAX = 3,
    }
    public enum ESocialPartyInviteFailureReason : int
    {
        Success = 0,
        NotOnline = 1,
        NotAcceptingMembers = 2,
        NotFriends = 3,
        AlreadyInParty = 4,
        OssValidationFailed = 5,
        PlatformInviteFailed = 6,
        PartyInviteFailed = 7,
        InviteRateLimitExceeded = 8,
        ESocialPartyInviteFailureReason_MAX = 9,
    }
    public enum ESocialSubsystem : int
    {
        Primary = 0,
        Platform = 1,
        MAX = 2,
    }
    public enum ESocialRelationship : int
    {
        Any = 0,
        FriendInviteReceived = 1,
        FriendInviteSent = 2,
        PartyInvite = 3,
        Friend = 4,
        BlockedPlayer = 5,
        SuggestedFriend = 6,
        RecentPlayer = 7,
        JoinRequest = 8,
        ESocialRelationship_MAX = 9,
    }
    public enum ECrossplayPreference : int
    {
        NoSelection = 0,
        OptedIn = 1,
        OptedOut = 2,
        OptedOutRestricted = 3,
        ECrossplayPreference_MAX = 4,
    }
    public enum EPlatformIconDisplayRule : int
    {
        Always = 0,
        AlwaysIfDifferent = 1,
        AlwaysWhenInCrossplayParty = 2,
        AlwaysIfDifferentWhenInCrossplayParty = 3,
        Never = 4,
        EPlatformIconDisplayRule_MAX = 5,
    }
    public class PartyMemberPlatformData : Object
    {
        public PartyMemberPlatformData(nint addr) : base(addr) { }
        public UserPlatform Platform { get { return this[nameof(Platform)].As<UserPlatform>(); } set { this["Platform"] = value; } }
        public UniqueNetIdRepl UniqueId { get { return this[nameof(UniqueId)].As<UniqueNetIdRepl>(); } set { this["UniqueId"] = value; } }
        public Object SessionId { get { return this[nameof(SessionId)]; } set { this[nameof(SessionId)] = value; } }
    }
    public class UserPlatform : Object
    {
        public UserPlatform(nint addr) : base(addr) { }
        public SocialPlatformDescription PlatformDescription { get { return this[nameof(PlatformDescription)].As<SocialPlatformDescription>(); } set { this["PlatformDescription"] = value; } }
    }
    public class SocialPlatformDescription : Object
    {
        public SocialPlatformDescription(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object PlatformType { get { return this[nameof(PlatformType)]; } set { this[nameof(PlatformType)] = value; } }
        public Object OnlineSubsystem { get { return this[nameof(OnlineSubsystem)]; } set { this[nameof(OnlineSubsystem)] = value; } }
        public Object SessionType { get { return this[nameof(SessionType)]; } set { this[nameof(SessionType)] = value; } }
        public Object ExternalAccountType { get { return this[nameof(ExternalAccountType)]; } set { this[nameof(ExternalAccountType)] = value; } }
        public Object CrossplayPool { get { return this[nameof(CrossplayPool)]; } set { this[nameof(CrossplayPool)] = value; } }
    }
    public class PartyMemberJoinInProgressRequest : Object
    {
        public PartyMemberJoinInProgressRequest(nint addr) : base(addr) { }
        public UniqueNetIdRepl Target { get { return this[nameof(Target)].As<UniqueNetIdRepl>(); } set { this["Target"] = value; } }
        public long Time { get { return this[nameof(Time)].GetValue<long>(); } set { this[nameof(Time)].SetValue<long>(value); } }
    }
    public class PartyMemberJoinInProgressResponse : Object
    {
        public PartyMemberJoinInProgressResponse(nint addr) : base(addr) { }
        public UniqueNetIdRepl Requester { get { return this[nameof(Requester)].As<UniqueNetIdRepl>(); } set { this["Requester"] = value; } }
        public long RequestTime { get { return this[nameof(RequestTime)].GetValue<long>(); } set { this[nameof(RequestTime)].SetValue<long>(value); } }
        public long ResponseTime { get { return this[nameof(ResponseTime)].GetValue<long>(); } set { this[nameof(ResponseTime)].SetValue<long>(value); } }
        public byte DenialReason { get { return this[nameof(DenialReason)].GetValue<byte>(); } set { this[nameof(DenialReason)].SetValue<byte>(value); } }
    }
    public class PartyMemberJoinInProgressData : Object
    {
        public PartyMemberJoinInProgressData(nint addr) : base(addr) { }
        public PartyMemberJoinInProgressRequest Request { get { return this[nameof(Request)].As<PartyMemberJoinInProgressRequest>(); } set { this["Request"] = value; } }
        public Array<PartyMemberJoinInProgressResponse> Responses { get { return new Array<PartyMemberJoinInProgressResponse>(this[nameof(Responses)].Address); } }
    }
    public class OnlinePartyRepDataBase : Object
    {
        public OnlinePartyRepDataBase(nint addr) : base(addr) { }
    }
    public class PartyMemberRepData : OnlinePartyRepDataBase
    {
        public PartyMemberRepData(nint addr) : base(addr) { }
        public PartyMemberPlatformData PlatformData { get { return this[nameof(PlatformData)].As<PartyMemberPlatformData>(); } set { this["PlatformData"] = value; } }
        public ECrossplayPreference CrossplayPreference { get { return (ECrossplayPreference)this[nameof(CrossplayPreference)].GetValue<int>(); } set { this[nameof(CrossplayPreference)].SetValue<int>((int)value); } }
        public Object JoinMethod { get { return this[nameof(JoinMethod)]; } set { this[nameof(JoinMethod)] = value; } }
        public PartyMemberJoinInProgressData JoinInProgressData { get { return this[nameof(JoinInProgressData)].As<PartyMemberJoinInProgressData>(); } set { this["JoinInProgressData"] = value; } }
    }
    public class PartyPlatformSessionInfo : Object
    {
        public PartyPlatformSessionInfo(nint addr) : base(addr) { }
        public Object SessionType { get { return this[nameof(SessionType)]; } set { this[nameof(SessionType)] = value; } }
        public Object SessionId { get { return this[nameof(SessionId)]; } set { this[nameof(SessionId)] = value; } }
        public UniqueNetIdRepl OwnerPrimaryId { get { return this[nameof(OwnerPrimaryId)].As<UniqueNetIdRepl>(); } set { this["OwnerPrimaryId"] = value; } }
    }
    public class PartyPrivacySettings : Object
    {
        public PartyPrivacySettings(nint addr) : base(addr) { }
        public EPartyType PartyType { get { return (EPartyType)this[nameof(PartyType)].GetValue<int>(); } set { this[nameof(PartyType)].SetValue<int>((int)value); } }
        public EPartyInviteRestriction PartyInviteRestriction { get { return (EPartyInviteRestriction)this[nameof(PartyInviteRestriction)].GetValue<int>(); } set { this[nameof(PartyInviteRestriction)].SetValue<int>((int)value); } }
        public bool bOnlyLeaderFriendsCanJoin { get { return this[nameof(bOnlyLeaderFriendsCanJoin)].Flag; } set { this[nameof(bOnlyLeaderFriendsCanJoin)].Flag = value; } }
    }
    public class PartyRepData : OnlinePartyRepDataBase
    {
        public PartyRepData(nint addr) : base(addr) { }
        public PartyPrivacySettings PrivacySettings { get { return this[nameof(PrivacySettings)].As<PartyPrivacySettings>(); } set { this["PrivacySettings"] = value; } }
        public Array<PartyPlatformSessionInfo> PlatformSessions { get { return new Array<PartyPlatformSessionInfo>(this[nameof(PlatformSessions)].Address); } }
    }
    public class SocialChatChannelConfig : Object
    {
        public SocialChatChannelConfig(nint addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
        public Array<SocialChatChannel> ListenChannels { get { return new Array<SocialChatChannel>(this[nameof(ListenChannels)].Address); } }
    }
}
