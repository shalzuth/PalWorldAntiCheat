using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ReplicationGraphSDK
{
    public class ReplicationGraph : ReplicationDriver
    {
        public ReplicationGraph(nint addr) : base(addr) { }
        public Object ReplicationConnectionManagerClass { get { return this[nameof(ReplicationConnectionManagerClass)]; } set { this[nameof(ReplicationConnectionManagerClass)] = value; } }
        public NetDriver NetDriver { get { return this[nameof(NetDriver)].As<NetDriver>(); } set { this["NetDriver"] = value; } }
        public Array<NetReplicationGraphConnection> Connections { get { return new Array<NetReplicationGraphConnection>(this[nameof(Connections)].Address); } }
        public Array<NetReplicationGraphConnection> PendingConnections { get { return new Array<NetReplicationGraphConnection>(this[nameof(PendingConnections)].Address); } }
        public Array<ReplicationGraphNode> GlobalGraphNodes { get { return new Array<ReplicationGraphNode>(this[nameof(GlobalGraphNodes)].Address); } }
        public Array<ReplicationGraphNode> PrepareForReplicationNodes { get { return new Array<ReplicationGraphNode>(this[nameof(PrepareForReplicationNodes)].Address); } }
    }
    public class BasicReplicationGraph : ReplicationGraph
    {
        public BasicReplicationGraph(nint addr) : base(addr) { }
        public ReplicationGraphNode_GridSpatialization2D GridNode { get { return this[nameof(GridNode)].As<ReplicationGraphNode_GridSpatialization2D>(); } set { this["GridNode"] = value; } }
        public ReplicationGraphNode_ActorList AlwaysRelevantNode { get { return this[nameof(AlwaysRelevantNode)].As<ReplicationGraphNode_ActorList>(); } set { this["AlwaysRelevantNode"] = value; } }
        public Array<ConnectionAlwaysRelevantNodePair> AlwaysRelevantForConnectionList { get { return new Array<ConnectionAlwaysRelevantNodePair>(this[nameof(AlwaysRelevantForConnectionList)].Address); } }
        public Array<Actor> ActorsWithoutNetConnection { get { return new Array<Actor>(this[nameof(ActorsWithoutNetConnection)].Address); } }
    }
    public class ReplicationGraphNode : Object
    {
        public ReplicationGraphNode(nint addr) : base(addr) { }
        public Array<ReplicationGraphNode> AllChildNodes { get { return new Array<ReplicationGraphNode>(this[nameof(AllChildNodes)].Address); } }
    }
    public class ReplicationGraphNode_ActorList : ReplicationGraphNode
    {
        public ReplicationGraphNode_ActorList(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_ActorListFrequencyBuckets : ReplicationGraphNode
    {
        public ReplicationGraphNode_ActorListFrequencyBuckets(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_DynamicSpatialFrequency : ReplicationGraphNode_ActorList
    {
        public ReplicationGraphNode_DynamicSpatialFrequency(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_ConnectionDormancyNode : ReplicationGraphNode_ActorList
    {
        public ReplicationGraphNode_ConnectionDormancyNode(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_DormancyNode : ReplicationGraphNode_ActorList
    {
        public ReplicationGraphNode_DormancyNode(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_GridCell : ReplicationGraphNode_ActorList
    {
        public ReplicationGraphNode_GridCell(nint addr) : base(addr) { }
        public ReplicationGraphNode DynamicNode { get { return this[nameof(DynamicNode)].As<ReplicationGraphNode>(); } set { this["DynamicNode"] = value; } }
        public ReplicationGraphNode_DormancyNode DormancyNode { get { return this[nameof(DormancyNode)].As<ReplicationGraphNode_DormancyNode>(); } set { this["DormancyNode"] = value; } }
    }
    public class ReplicationGraphNode_GridSpatialization2D : ReplicationGraphNode
    {
        public ReplicationGraphNode_GridSpatialization2D(nint addr) : base(addr) { }
    }
    public class ReplicationGraphNode_AlwaysRelevant : ReplicationGraphNode
    {
        public ReplicationGraphNode_AlwaysRelevant(nint addr) : base(addr) { }
        public ReplicationGraphNode ChildNode { get { return this[nameof(ChildNode)].As<ReplicationGraphNode>(); } set { this["ChildNode"] = value; } }
    }
    public class ReplicationGraphNode_AlwaysRelevant_ForConnection : ReplicationGraphNode_ActorList
    {
        public ReplicationGraphNode_AlwaysRelevant_ForConnection(nint addr) : base(addr) { }
        public Array<AlwaysRelevantActorInfo> PastRelevantActors { get { return new Array<AlwaysRelevantActorInfo>(this[nameof(PastRelevantActors)].Address); } }
    }
    public class ReplicationGraphNode_TearOff_ForConnection : ReplicationGraphNode
    {
        public ReplicationGraphNode_TearOff_ForConnection(nint addr) : base(addr) { }
        public Array<TearOffActorInfo> TearOffActors { get { return new Array<TearOffActorInfo>(this[nameof(TearOffActors)].Address); } }
    }
    public class NetReplicationGraphConnection : ReplicationConnectionDriver
    {
        public NetReplicationGraphConnection(nint addr) : base(addr) { }
        public NetConnection NetConnection { get { return this[nameof(NetConnection)].As<NetConnection>(); } set { this["NetConnection"] = value; } }
        public ReplicationGraphDebugActor DebugActor { get { return this[nameof(DebugActor)].As<ReplicationGraphDebugActor>(); } set { this["DebugActor"] = value; } }
        public Array<LastLocationGatherInfo> LastGatherLocations { get { return new Array<LastLocationGatherInfo>(this[nameof(LastGatherLocations)].Address); } }
        public Array<ReplicationGraphNode> ConnectionGraphNodes { get { return new Array<ReplicationGraphNode>(this[nameof(ConnectionGraphNodes)].Address); } }
        public ReplicationGraphNode_TearOff_ForConnection TearOffNode { get { return this[nameof(TearOffNode)].As<ReplicationGraphNode_TearOff_ForConnection>(); } set { this["TearOffNode"] = value; } }
    }
    public class ReplicationGraphDebugActor : Actor
    {
        public ReplicationGraphDebugActor(nint addr) : base(addr) { }
        public ReplicationGraph ReplicationGraph { get { return this[nameof(ReplicationGraph)].As<ReplicationGraph>(); } set { this["ReplicationGraph"] = value; } }
        public NetReplicationGraphConnection ConnectionManager { get { return this[nameof(ConnectionManager)].As<NetReplicationGraphConnection>(); } set { this["ConnectionManager"] = value; } }
        public void ServerStopDebugging() { Invoke(nameof(ServerStopDebugging)); }
        public void ServerStartDebugging() { Invoke(nameof(ServerStartDebugging)); }
        public void ServerSetPeriodFrameForClass(Object Class, int PeriodFrame) { Invoke(nameof(ServerSetPeriodFrameForClass), Class, PeriodFrame); }
        public void ServerSetCullDistanceForClass(Object Class, float CullDistance) { Invoke(nameof(ServerSetCullDistanceForClass), Class, CullDistance); }
        public void ServerSetConditionalActorBreakpoint(Actor Actor) { Invoke(nameof(ServerSetConditionalActorBreakpoint), Actor); }
        public void ServerPrintCullDistances() { Invoke(nameof(ServerPrintCullDistances)); }
        public void ServerPrintAllActorInfo(Object Str) { Invoke(nameof(ServerPrintAllActorInfo), Str); }
        public void ServerCellInfo() { Invoke(nameof(ServerCellInfo)); }
        public void ClientCellInfo(Vector CellLocation, Vector CellExtent, Array<Actor> Actors) { Invoke(nameof(ClientCellInfo), CellLocation, CellExtent, Actors); }
    }
    public class ConnectionAlwaysRelevantNodePair : Object
    {
        public ConnectionAlwaysRelevantNodePair(nint addr) : base(addr) { }
        public NetConnection NetConnection { get { return this[nameof(NetConnection)].As<NetConnection>(); } set { this["NetConnection"] = value; } }
        public ReplicationGraphNode_AlwaysRelevant_ForConnection Node { get { return this[nameof(Node)].As<ReplicationGraphNode_AlwaysRelevant_ForConnection>(); } set { this["Node"] = value; } }
    }
    public class AlwaysRelevantActorInfo : Object
    {
        public AlwaysRelevantActorInfo(nint addr) : base(addr) { }
        public NetConnection Connection { get { return this[nameof(Connection)].As<NetConnection>(); } set { this["Connection"] = value; } }
        public Actor LastViewer { get { return this[nameof(LastViewer)].As<Actor>(); } set { this["LastViewer"] = value; } }
        public Actor LastViewTarget { get { return this[nameof(LastViewTarget)].As<Actor>(); } set { this["LastViewTarget"] = value; } }
    }
    public class TearOffActorInfo : Object
    {
        public TearOffActorInfo(nint addr) : base(addr) { }
        public Actor Actor { get { return this[nameof(Actor)].As<Actor>(); } set { this["Actor"] = value; } }
    }
    public class LastLocationGatherInfo : Object
    {
        public LastLocationGatherInfo(nint addr) : base(addr) { }
        public NetConnection Connection { get { return this[nameof(Connection)].As<NetConnection>(); } set { this["Connection"] = value; } }
        public Vector LastLocation { get { return this[nameof(LastLocation)].As<Vector>(); } set { this["LastLocation"] = value; } }
        public Vector LastOutOfRangeLocationCheck { get { return this[nameof(LastOutOfRangeLocationCheck)].As<Vector>(); } set { this["LastOutOfRangeLocationCheck"] = value; } }
    }
    public class ClassReplicationInfo : Object
    {
        public ClassReplicationInfo(nint addr) : base(addr) { }
        public float DistancePriorityScale { get { return this[nameof(DistancePriorityScale)].GetValue<float>(); } set { this[nameof(DistancePriorityScale)].SetValue<float>(value); } }
        public float StarvationPriorityScale { get { return this[nameof(StarvationPriorityScale)].GetValue<float>(); } set { this[nameof(StarvationPriorityScale)].SetValue<float>(value); } }
        public float AccumulatedNetPriorityBias { get { return this[nameof(AccumulatedNetPriorityBias)].GetValue<float>(); } set { this[nameof(AccumulatedNetPriorityBias)].SetValue<float>(value); } }
        public ushort ReplicationPeriodFrame { get { return this[nameof(ReplicationPeriodFrame)].GetValue<ushort>(); } set { this[nameof(ReplicationPeriodFrame)].SetValue<ushort>(value); } }
        public ushort FastPath_ReplicationPeriodFrame { get { return this[nameof(FastPath_ReplicationPeriodFrame)].GetValue<ushort>(); } set { this[nameof(FastPath_ReplicationPeriodFrame)].SetValue<ushort>(value); } }
        public ushort ActorChannelFrameTimeout { get { return this[nameof(ActorChannelFrameTimeout)].GetValue<ushort>(); } set { this[nameof(ActorChannelFrameTimeout)].SetValue<ushort>(value); } }
        public float CullDistance { get { return this[nameof(CullDistance)].GetValue<float>(); } set { this[nameof(CullDistance)].SetValue<float>(value); } }
        public float CullDistanceSquared { get { return this[nameof(CullDistanceSquared)].GetValue<float>(); } set { this[nameof(CullDistanceSquared)].SetValue<float>(value); } }
    }
}
