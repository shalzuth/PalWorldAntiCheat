using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.PocketpairUserSDK
{
    public class HTTPRequestAsyncFunction : BlueprintAsyncActionBase
    {
        public HTTPRequestAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public HTTPRequestAsyncFunction HTTPRequestAsyncFunction_value(PocketpairUserSubsystem Target, Object URL, Object Verb) { return Invoke<HTTPRequestAsyncFunction>(nameof(HTTPRequestAsyncFunction_value), Target, URL, Verb); }
    }
    public class SwitchUserUIDefaultOnlineSubsystemAsyncFunction : BlueprintAsyncActionBase
    {
        public SwitchUserUIDefaultOnlineSubsystemAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public SwitchUserUIDefaultOnlineSubsystemAsyncFunction SwitchUserUIAsyncFunction(PocketpairUserSubsystem Target) { return Invoke<SwitchUserUIDefaultOnlineSubsystemAsyncFunction>(nameof(SwitchUserUIAsyncFunction), Target); }
    }
    public class LoginDefaultOnlineSubsystemAsyncFunction : BlueprintAsyncActionBase
    {
        public LoginDefaultOnlineSubsystemAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public LoginDefaultOnlineSubsystemAsyncFunction LoginDefaultAsyncFunction(PocketpairUserSubsystem Target) { return Invoke<LoginDefaultOnlineSubsystemAsyncFunction>(nameof(LoginDefaultAsyncFunction), Target); }
    }
    public class LoginEOSAsyncFunction : BlueprintAsyncActionBase
    {
        public LoginEOSAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public LoginEOSAsyncFunction LoginEOSAsyncFunction_value(PocketpairUserSubsystem Target) { return Invoke<LoginEOSAsyncFunction>(nameof(LoginEOSAsyncFunction_value), Target); }
    }
    public class CreateSessionAsyncFunction : BlueprintAsyncActionBase
    {
        public CreateSessionAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public CreateSessionAsyncFunction CreateSessionAsyncFunction_value(PocketpairUserSubsystem Target, bool IsDedicatedServer, int PublicConnections, Object InviteCode, Object ServerName, Object Desc, Object ServerAddress, int ServerPort, bool IsPassword, Object Version, Object ServerType, Object Region, Object Namespace) { return Invoke<CreateSessionAsyncFunction>(nameof(CreateSessionAsyncFunction_value), Target, IsDedicatedServer, PublicConnections, InviteCode, ServerName, Desc, ServerAddress, ServerPort, IsPassword, Version, ServerType, Region, Namespace); }
    }
    public class FindSessionsAsyncFunction : BlueprintAsyncActionBase
    {
        public FindSessionsAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public FindSessionsAsyncFunction FindSessionsAsyncFunction_value(PocketpairUserSubsystem Target, bool IsDedicatedServer, Object InviteCode, Object ServerType, Object Region, int LessThanTime, Object WorldGUID, Object Namespace) { return Invoke<FindSessionsAsyncFunction>(nameof(FindSessionsAsyncFunction_value), Target, IsDedicatedServer, InviteCode, ServerType, Region, LessThanTime, WorldGUID, Namespace); }
    }
    public class JoinSessionAsyncFunction : BlueprintAsyncActionBase
    {
        public JoinSessionAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public PlayerController Controller { get { return this[nameof(Controller)].As<PlayerController>(); } set { this["Controller"] = value; } }
    }
    public class SanitizeDisplayNameAsyncFunction : BlueprintAsyncActionBase
    {
        public SanitizeDisplayNameAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public SanitizeDisplayNameAsyncFunction SanitizeDisplayNameAsyncFunction_value(PocketpairUserSubsystem Target, Object InString) { return Invoke<SanitizeDisplayNameAsyncFunction>(nameof(SanitizeDisplayNameAsyncFunction_value), Target, InString); }
    }
    public class PingIP : Object
    {
        public PingIP(nint addr) : base(addr) { }
        public Object OnPingComplete { get { return this[nameof(OnPingComplete)]; } set { this[nameof(OnPingComplete)] = value; } }
        public Object OnPingFailure { get { return this[nameof(OnPingFailure)]; } set { this[nameof(OnPingFailure)] = value; } }
        public void SendPing(Object ipAddress) { Invoke(nameof(SendPing), ipAddress); }
        public void PollThread() { Invoke(nameof(PollThread)); }
        public PingIP ConstructPingObject() { return Invoke<PingIP>(nameof(ConstructPingObject)); }
    }
    public class PocketpairUserInfo : Object
    {
        public PocketpairUserInfo(nint addr) : base(addr) { }
        public Object GetOnlineSubsystemName() { return Invoke<Object>(nameof(GetOnlineSubsystemName)); }
        public Object GetNickname() { return Invoke<Object>(nameof(GetNickname)); }
        public UniqueNetIdRepl GetNetId() { return Invoke<UniqueNetIdRepl>(nameof(GetNetId)); }
        public Object GetDebugString() { return Invoke<Object>(nameof(GetDebugString)); }
    }
    public class PocketpairFriend : Object
    {
        public PocketpairFriend(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public UniqueNetIdRepl GetNetId() { return Invoke<UniqueNetIdRepl>(nameof(GetNetId)); }
    }
    public class PocketpairUserSubsystem : GameInstanceSubsystem
    {
        public PocketpairUserSubsystem(nint addr) : base(addr) { }
        public PocketpairUserInfo LocalUserInfo { get { return this[nameof(LocalUserInfo)].As<PocketpairUserInfo>(); } set { this["LocalUserInfo"] = value; } }
        public void UnlockAchievement(Object ID, float Percent) { Invoke(nameof(UnlockAchievement), ID, Percent); }
        public void OnSessionInviteReceived(Object InviteCode) { Invoke(nameof(OnSessionInviteReceived), InviteCode); }
        public Object GetTelemetryUserId() { return Invoke<Object>(nameof(GetTelemetryUserId)); }
        public Object GetTelemetrySessionId() { return Invoke<Object>(nameof(GetTelemetrySessionId)); }
        public SocialId GetSocialId(PlayerController PlayerController) { return Invoke<SocialId>(nameof(GetSocialId), PlayerController); }
        public Object GetSaveDataUserId() { return Invoke<Object>(nameof(GetSaveDataUserId)); }
        public int GetPlayerNo(PlayerController PlayerController) { return Invoke<int>(nameof(GetPlayerNo), PlayerController); }
        public int GetPingResultCache(Object Address) { return Invoke<int>(nameof(GetPingResultCache), Address); }
        public PocketpairUserInfo GetLocalUserInfo() { return Invoke<PocketpairUserInfo>(nameof(GetLocalUserInfo)); }
        public Object GetInviteCode() { return Invoke<Object>(nameof(GetInviteCode)); }
        public Object GetDefaultOnlineSubsystemName() { return Invoke<Object>(nameof(GetDefaultOnlineSubsystemName)); }
        public void AddPingResultCache(Object Address, int Ping) { Invoke(nameof(AddPingResultCache), Address, Ping); }
    }
    public class GDKActivityAsyncFunction : BlueprintAsyncActionBase
    {
        public GDKActivityAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public GDKActivityAsyncFunction GDKActivityAsyncFunction_value(PocketpairUserSubsystem Target, Object ConnectionString, int MaxPlayerNum, int CurrentPlayerNum) { return Invoke<GDKActivityAsyncFunction>(nameof(GDKActivityAsyncFunction_value), Target, ConnectionString, MaxPlayerNum, CurrentPlayerNum); }
    }
    public class GDKInviteAsyncFunction : BlueprintAsyncActionBase
    {
        public GDKInviteAsyncFunction(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public GDKInviteAsyncFunction GDKInviteAsyncFunction_value(PocketpairUserSubsystem Target) { return Invoke<GDKInviteAsyncFunction>(nameof(GDKInviteAsyncFunction_value), Target); }
    }
    public enum JoinSessionResultType : int
    {
        Success = 0,
        SessionIsFull = 1,
        SessionDoesNotExist = 2,
        CouldNotRetrieveAddress = 3,
        AlreadyInSession = 4,
        UnknownError = 5,
        JoinSessionResultType_MAX = 6,
    }
    public enum ELoginStatusType : int
    {
        NotLoggedIn = 0,
        UsingLocalProfile = 1,
        LoggedIn = 2,
        ELoginStatusType_MAX = 3,
    }
    public class SocialId : Object
    {
        public SocialId(nint addr) : base(addr) { }
    }
    public class PocketpairTelemetry : Object
    {
        public PocketpairTelemetry(nint addr) : base(addr) { }
    }
    public class PocketpairTelemetry_Stat : Object
    {
        public PocketpairTelemetry_Stat(nint addr) : base(addr) { }
    }
}
