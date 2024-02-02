using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.LiveLinkInterfaceSDK;
namespace SDK.Script.LiveLinkMessageBusFrameworkSDK
{
    public class LiveLinkPingMessage : Object
    {
        public LiveLinkPingMessage(nint addr) : base(addr) { }
        public Guid PollRequest { get { return this[nameof(PollRequest)].As<Guid>(); } set { this["PollRequest"] = value; } }
        public int LiveLinkVersion { get { return this[nameof(LiveLinkVersion)].GetValue<int>(); } set { this[nameof(LiveLinkVersion)].SetValue<int>(value); } }
    }
    public class LiveLinkPongMessage : Object
    {
        public LiveLinkPongMessage(nint addr) : base(addr) { }
        public Object ProviderName { get { return this[nameof(ProviderName)]; } set { this[nameof(ProviderName)] = value; } }
        public Object MachineName { get { return this[nameof(MachineName)]; } set { this[nameof(MachineName)] = value; } }
        public Guid PollRequest { get { return this[nameof(PollRequest)].As<Guid>(); } set { this["PollRequest"] = value; } }
        public int LiveLinkVersion { get { return this[nameof(LiveLinkVersion)].GetValue<int>(); } set { this[nameof(LiveLinkVersion)].SetValue<int>(value); } }
        public double CreationPlatformTime { get { return this[nameof(CreationPlatformTime)].GetValue<double>(); } set { this[nameof(CreationPlatformTime)].SetValue<double>(value); } }
    }
    public class LiveLinkConnectMessage : Object
    {
        public LiveLinkConnectMessage(nint addr) : base(addr) { }
        public int LiveLinkVersion { get { return this[nameof(LiveLinkVersion)].GetValue<int>(); } set { this[nameof(LiveLinkVersion)].SetValue<int>(value); } }
    }
    public class LiveLinkHeartbeatMessage : Object
    {
        public LiveLinkHeartbeatMessage(nint addr) : base(addr) { }
    }
    public class LiveLinkClearSubject : Object
    {
        public LiveLinkClearSubject(nint addr) : base(addr) { }
        public Object SubjectName { get { return this[nameof(SubjectName)]; } set { this[nameof(SubjectName)] = value; } }
    }
    public class LiveLinkSubjectDataMessage : Object
    {
        public LiveLinkSubjectDataMessage(nint addr) : base(addr) { }
        public LiveLinkRefSkeleton RefSkeleton { get { return this[nameof(RefSkeleton)].As<LiveLinkRefSkeleton>(); } set { this["RefSkeleton"] = value; } }
        public Object SubjectName { get { return this[nameof(SubjectName)]; } set { this[nameof(SubjectName)] = value; } }
    }
    public class LiveLinkSubjectFrameMessage : Object
    {
        public LiveLinkSubjectFrameMessage(nint addr) : base(addr) { }
        public Object SubjectName { get { return this[nameof(SubjectName)]; } set { this[nameof(SubjectName)] = value; } }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
        public Array<LiveLinkCurveElement> Curves { get { return new Array<LiveLinkCurveElement>(this[nameof(Curves)].Address); } }
        public LiveLinkMetaData MetaData { get { return this[nameof(MetaData)].As<LiveLinkMetaData>(); } set { this["MetaData"] = value; } }
        public double Time { get { return this[nameof(Time)].GetValue<double>(); } set { this[nameof(Time)].SetValue<double>(value); } }
    }
}
