using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.RejoinSDK
{
    public class RejoinCheck : Object
    {
        public RejoinCheck(nint addr) : base(addr) { }
        public ERejoinStatus LastKnownStatus { get { return (ERejoinStatus)this[nameof(LastKnownStatus)].GetValue<int>(); } set { this[nameof(LastKnownStatus)].SetValue<int>((int)value); } }
        public bool bRejoinAfterCheck { get { return this[nameof(bRejoinAfterCheck)].Flag; } set { this[nameof(bRejoinAfterCheck)].Flag = value; } }
        public bool bAttemptingRejoin { get { return this[nameof(bAttemptingRejoin)].Flag; } set { this[nameof(bAttemptingRejoin)].Flag = value; } }
    }
    public enum ERejoinStatus : int
    {
        NoMatchToRejoin = 0,
        RejoinAvailable = 1,
        UpdatingStatus = 2,
        NeedsRecheck = 3,
        NoMatchToRejoin_MatchEnded = 4,
        ERejoinStatus_MAX = 5,
    }
}
