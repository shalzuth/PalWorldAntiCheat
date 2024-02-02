using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.PacketHandlerSDK
{
    public class HandlerComponentFactory : Object
    {
        public HandlerComponentFactory(nint addr) : base(addr) { }
    }
    public class PacketHandlerProfileConfig : Object
    {
        public PacketHandlerProfileConfig(nint addr) : base(addr) { }
        public Array<Object> Components { get { return new Array<Object>(this[nameof(Components)].Address); } }
    }
}
