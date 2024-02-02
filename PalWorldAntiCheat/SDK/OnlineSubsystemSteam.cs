using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.PacketHandlerSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.OnlineSubsystemSteamSDK
{
    public class SteamAuthComponentModuleInterface : HandlerComponentFactory
    {
        public SteamAuthComponentModuleInterface(nint addr) : base(addr) { }
    }
    public class SteamNetConnection : IpConnection
    {
        public SteamNetConnection(nint addr) : base(addr) { }
        public bool bIsPassthrough { get { return this[nameof(bIsPassthrough)].Flag; } set { this[nameof(bIsPassthrough)].Flag = value; } }
    }
    public class SteamNetDriver : IpNetDriver
    {
        public SteamNetDriver(nint addr) : base(addr) { }
    }
}
