using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.CoreOnlineSDK
{
    public class JoinabilitySettings : Object
    {
        public JoinabilitySettings(nint addr) : base(addr) { }
        public Object SessionName { get { return this[nameof(SessionName)]; } set { this[nameof(SessionName)] = value; } }
        public bool bPublicSearchable { get { return this[nameof(bPublicSearchable)].Flag; } set { this[nameof(bPublicSearchable)].Flag = value; } }
        public bool bAllowInvites { get { return this[nameof(bAllowInvites)].Flag; } set { this[nameof(bAllowInvites)].Flag = value; } }
        public bool bJoinViaPresence { get { return this[nameof(bJoinViaPresence)].Flag; } set { this[nameof(bJoinViaPresence)].Flag = value; } }
        public bool bJoinViaPresenceFriendsOnly { get { return this[nameof(bJoinViaPresenceFriendsOnly)].Flag; } set { this[nameof(bJoinViaPresenceFriendsOnly)].Flag = value; } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public int MaxPartySize { get { return this[nameof(MaxPartySize)].GetValue<int>(); } set { this[nameof(MaxPartySize)].SetValue<int>(value); } }
    }
    public class UniqueNetIdWrapper : Object
    {
        public UniqueNetIdWrapper(nint addr) : base(addr) { }
    }
    public enum ECoreOnlineDummy : int
    {
        Dummy = 0,
        ECoreOnlineDummy_MAX = 1,
    }
}
