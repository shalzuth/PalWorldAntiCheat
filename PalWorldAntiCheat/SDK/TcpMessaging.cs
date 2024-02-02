using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.TcpMessagingSDK
{
    public class TcpMessagingSettings : Object
    {
        public TcpMessagingSettings(nint addr) : base(addr) { }
        public bool EnableTransport { get { return this[nameof(EnableTransport)].Flag; } set { this[nameof(EnableTransport)].Flag = value; } }
        public Object ListenEndpoint { get { return this[nameof(ListenEndpoint)]; } set { this[nameof(ListenEndpoint)] = value; } }
        public Array<Object> ConnectToEndpoints { get { return new Array<Object>(this[nameof(ConnectToEndpoints)].Address); } }
        public int ConnectionRetryDelay { get { return this[nameof(ConnectionRetryDelay)].GetValue<int>(); } set { this[nameof(ConnectionRetryDelay)].SetValue<int>(value); } }
        public int ConnectionRetryPeriod { get { return this[nameof(ConnectionRetryPeriod)].GetValue<int>(); } set { this[nameof(ConnectionRetryPeriod)].SetValue<int>(value); } }
        public bool bStopServiceWhenAppDeactivates { get { return this[nameof(bStopServiceWhenAppDeactivates)].Flag; } set { this[nameof(bStopServiceWhenAppDeactivates)].Flag = value; } }
    }
}
