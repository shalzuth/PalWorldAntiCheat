using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.OnlineSubsystemSDK
{
    public class NamedInterfaces : Object
    {
        public NamedInterfaces(nint addr) : base(addr) { }
        public Array<NamedInterface> NamedInterfaces_value { get { return new Array<NamedInterface>(this[nameof(NamedInterfaces)].Address); } }
        public Array<NamedInterfaceDef> NamedInterfaceDefs { get { return new Array<NamedInterfaceDef>(this[nameof(NamedInterfaceDefs)].Address); } }
    }
    public class TurnBasedMatchInterface : Interface
    {
        public TurnBasedMatchInterface(nint addr) : base(addr) { }
        public void OnMatchReceivedTurn(Object Match, bool bDidBecomeActive) { Invoke(nameof(OnMatchReceivedTurn), Match, bDidBecomeActive); }
        public void OnMatchEnded(Object Match) { Invoke(nameof(OnMatchEnded), Match); }
    }
    public enum EInAppPurchaseState : int
    {
        Unknown = 0,
        Success = 1,
        Failed = 2,
        Cancelled = 3,
        Invalid = 4,
        NotAllowed = 5,
        Restored = 6,
        AlreadyOwned = 7,
        EInAppPurchaseState_MAX = 8,
    }
    public enum EMPMatchOutcome : int
    {
        None = 0,
        Quit = 1,
        Won = 2,
        Lost = 3,
        Tied = 4,
        TimeExpired = 5,
        First = 6,
        Second = 7,
        Third = 8,
        Fourth = 9,
        EMPMatchOutcome_MAX = 10,
    }
    public class NamedInterface : Object
    {
        public NamedInterface(nint addr) : base(addr) { }
        public Object InterfaceName { get { return this[nameof(InterfaceName)]; } set { this[nameof(InterfaceName)] = value; } }
        public Object InterfaceObject { get { return this[nameof(InterfaceObject)].As<Object>(); } set { this["InterfaceObject"] = value; } }
    }
    public class NamedInterfaceDef : Object
    {
        public NamedInterfaceDef(nint addr) : base(addr) { }
        public Object InterfaceName { get { return this[nameof(InterfaceName)]; } set { this[nameof(InterfaceName)] = value; } }
        public Object InterfaceClassName { get { return this[nameof(InterfaceClassName)]; } set { this[nameof(InterfaceClassName)] = value; } }
    }
}
