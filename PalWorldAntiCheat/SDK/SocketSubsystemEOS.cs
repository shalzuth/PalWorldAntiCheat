using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.SocketSubsystemEOSSDK
{
    public class NetDriverEOSBase : IpNetDriver
    {
        public NetDriverEOSBase(nint addr) : base(addr) { }
        public bool bIsPassthrough { get { return this[nameof(bIsPassthrough)].Flag; } set { this[nameof(bIsPassthrough)].Flag = value; } }
        public bool bIsUsingP2PSockets { get { return this[nameof(bIsUsingP2PSockets)].Flag; } set { this[nameof(bIsUsingP2PSockets)].Flag = value; } }
    }
    public class NetConnectionEOS : IpConnection
    {
        public NetConnectionEOS(nint addr) : base(addr) { }
    }
}
