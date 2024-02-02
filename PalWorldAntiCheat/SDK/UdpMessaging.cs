using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.UdpMessagingSDK
{
    public class UdpMessagingSettings : Object
    {
        public UdpMessagingSettings(nint addr) : base(addr) { }
        public bool EnabledByDefault { get { return this[nameof(EnabledByDefault)].Flag; } set { this[nameof(EnabledByDefault)].Flag = value; } }
        public bool EnableTransport { get { return this[nameof(EnableTransport)].Flag; } set { this[nameof(EnableTransport)].Flag = value; } }
        public bool bAutoRepair { get { return this[nameof(bAutoRepair)].Flag; } set { this[nameof(bAutoRepair)].Flag = value; } }
        public float MaxSendRate { get { return this[nameof(MaxSendRate)].GetValue<float>(); } set { this[nameof(MaxSendRate)].SetValue<float>(value); } }
        public uint AutoRepairAttemptLimit { get { return this[nameof(AutoRepairAttemptLimit)].GetValue<uint>(); } set { this[nameof(AutoRepairAttemptLimit)].SetValue<uint>(value); } }
        public ushort WorkQueueSize { get { return this[nameof(WorkQueueSize)].GetValue<ushort>(); } set { this[nameof(WorkQueueSize)].SetValue<ushort>(value); } }
        public bool bStopServiceWhenAppDeactivates { get { return this[nameof(bStopServiceWhenAppDeactivates)].Flag; } set { this[nameof(bStopServiceWhenAppDeactivates)].Flag = value; } }
        public Object UnicastEndpoint { get { return this[nameof(UnicastEndpoint)]; } set { this[nameof(UnicastEndpoint)] = value; } }
        public Object MulticastEndpoint { get { return this[nameof(MulticastEndpoint)]; } set { this[nameof(MulticastEndpoint)] = value; } }
        public EUdpMessageFormat MessageFormat { get { return (EUdpMessageFormat)this[nameof(MessageFormat)].GetValue<int>(); } set { this[nameof(MessageFormat)].SetValue<int>((int)value); } }
        public byte MulticastTimeToLive { get { return this[nameof(MulticastTimeToLive)].GetValue<byte>(); } set { this[nameof(MulticastTimeToLive)].SetValue<byte>(value); } }
        public Array<Object> StaticEndpoints { get { return new Array<Object>(this[nameof(StaticEndpoints)].Address); } }
        public Array<Object> ExcludedEndpoints { get { return new Array<Object>(this[nameof(ExcludedEndpoints)].Address); } }
        public bool EnableTunnel { get { return this[nameof(EnableTunnel)].Flag; } set { this[nameof(EnableTunnel)].Flag = value; } }
        public Object TunnelUnicastEndpoint { get { return this[nameof(TunnelUnicastEndpoint)]; } set { this[nameof(TunnelUnicastEndpoint)] = value; } }
        public Object TunnelMulticastEndpoint { get { return this[nameof(TunnelMulticastEndpoint)]; } set { this[nameof(TunnelMulticastEndpoint)] = value; } }
        public Array<Object> RemoteTunnelEndpoints { get { return new Array<Object>(this[nameof(RemoteTunnelEndpoints)].Address); } }
    }
    public enum EUdpMessageFormat : int
    {
        None = 0,
        Json = 1,
        TaggedProperty = 2,
        CborPlatformEndianness = 3,
        CborStandardEndianness = 4,
        EUdpMessageFormat_MAX = 5,
    }
    public class UdpMockMessage : Object
    {
        public UdpMockMessage(nint addr) : base(addr) { }
        public Array<byte> Data { get { return new Array<byte>(this[nameof(Data)].Address); } }
    }
}
