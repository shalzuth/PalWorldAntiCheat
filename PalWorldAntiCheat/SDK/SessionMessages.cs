using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SessionMessagesSDK
{
    public class SessionServicePing : Object
    {
        public SessionServicePing(nint addr) : base(addr) { }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
    }
    public class SessionServicePong : Object
    {
        public SessionServicePong(nint addr) : base(addr) { }
        public bool Authorized { get { return this[nameof(Authorized)].Flag; } set { this[nameof(Authorized)].Flag = value; } }
        public Object BuildDate { get { return this[nameof(BuildDate)]; } set { this[nameof(BuildDate)] = value; } }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
        public Object InstanceName { get { return this[nameof(InstanceName)]; } set { this[nameof(InstanceName)] = value; } }
        public Object PlatformName { get { return this[nameof(PlatformName)]; } set { this[nameof(PlatformName)] = value; } }
        public Guid SessionId { get { return this[nameof(SessionId)].As<Guid>(); } set { this["SessionId"] = value; } }
        public Object SessionName { get { return this[nameof(SessionName)]; } set { this[nameof(SessionName)] = value; } }
        public Object SessionOwner { get { return this[nameof(SessionOwner)]; } set { this[nameof(SessionOwner)] = value; } }
        public bool Standalone { get { return this[nameof(Standalone)].Flag; } set { this[nameof(Standalone)].Flag = value; } }
    }
    public class SessionServiceLog : Object
    {
        public SessionServiceLog(nint addr) : base(addr) { }
        public Object Category { get { return this[nameof(Category)]; } set { this[nameof(Category)] = value; } }
        public Object Data { get { return this[nameof(Data)]; } set { this[nameof(Data)] = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
        public double TimeSeconds { get { return this[nameof(TimeSeconds)].GetValue<double>(); } set { this[nameof(TimeSeconds)].SetValue<double>(value); } }
        public byte Verbosity { get { return this[nameof(Verbosity)].GetValue<byte>(); } set { this[nameof(Verbosity)].SetValue<byte>(value); } }
    }
    public class SessionServiceLogSubscribe : Object
    {
        public SessionServiceLogSubscribe(nint addr) : base(addr) { }
    }
    public class SessionServiceLogUnsubscribe : Object
    {
        public SessionServiceLogUnsubscribe(nint addr) : base(addr) { }
    }
}
