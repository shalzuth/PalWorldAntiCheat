using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MeshDescriptionSDK
{
    public class MeshDescriptionBase : Object
    {
        public MeshDescriptionBase(nint addr) : base(addr) { }
        public void SetVertexPosition(VertexID VertexID, Vector Position) { Invoke(nameof(SetVertexPosition), VertexID, Position); }
        public void SetPolygonVertexInstances(PolygonID PolygonID, Array<VertexInstanceID> VertexInstanceIDs) { Invoke(nameof(SetPolygonVertexInstances), PolygonID, VertexInstanceIDs); }
        public void SetPolygonPolygonGroup(PolygonID PolygonID, PolygonGroupID PolygonGroupID) { Invoke(nameof(SetPolygonPolygonGroup), PolygonID, PolygonGroupID); }
        public void ReversePolygonFacing(PolygonID PolygonID) { Invoke(nameof(ReversePolygonFacing), PolygonID); }
        public void ReserveNewVertices(int NumberOfNewVertices) { Invoke(nameof(ReserveNewVertices), NumberOfNewVertices); }
        public void ReserveNewVertexInstances(int NumberOfNewVertexInstances) { Invoke(nameof(ReserveNewVertexInstances), NumberOfNewVertexInstances); }
        public void ReserveNewTriangles(int NumberOfNewTriangles) { Invoke(nameof(ReserveNewTriangles), NumberOfNewTriangles); }
        public void ReserveNewPolygons(int NumberOfNewPolygons) { Invoke(nameof(ReserveNewPolygons), NumberOfNewPolygons); }
        public void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups) { Invoke(nameof(ReserveNewPolygonGroups), NumberOfNewPolygonGroups); }
        public void ReserveNewEdges(int NumberOfNewEdges) { Invoke(nameof(ReserveNewEdges), NumberOfNewEdges); }
        public bool IsVertexValid(VertexID VertexID) { return Invoke<bool>(nameof(IsVertexValid), VertexID); }
        public bool IsVertexOrphaned(VertexID VertexID) { return Invoke<bool>(nameof(IsVertexOrphaned), VertexID); }
        public bool IsVertexInstanceValid(VertexInstanceID VertexInstanceID) { return Invoke<bool>(nameof(IsVertexInstanceValid), VertexInstanceID); }
        public bool IsTriangleValid(TriangleID TriangleID) { return Invoke<bool>(nameof(IsTriangleValid), TriangleID); }
        public bool IsTrianglePartOfNgon(TriangleID TriangleID) { return Invoke<bool>(nameof(IsTrianglePartOfNgon), TriangleID); }
        public bool IsPolygonValid(PolygonID PolygonID) { return Invoke<bool>(nameof(IsPolygonValid), PolygonID); }
        public bool IsPolygonGroupValid(PolygonGroupID PolygonGroupID) { return Invoke<bool>(nameof(IsPolygonGroupValid), PolygonGroupID); }
        public bool IsEmpty() { return Invoke<bool>(nameof(IsEmpty)); }
        public bool IsEdgeValid(EdgeID EdgeID) { return Invoke<bool>(nameof(IsEdgeValid), EdgeID); }
        public bool IsEdgeInternalToPolygon(EdgeID EdgeID, PolygonID PolygonID) { return Invoke<bool>(nameof(IsEdgeInternalToPolygon), EdgeID, PolygonID); }
        public bool IsEdgeInternal(EdgeID EdgeID) { return Invoke<bool>(nameof(IsEdgeInternal), EdgeID); }
        public void GetVertexVertexInstances(VertexID VertexID, Array<VertexInstanceID> OutVertexInstanceIDs) { Invoke(nameof(GetVertexVertexInstances), VertexID, OutVertexInstanceIDs); }
        public Vector GetVertexPosition(VertexID VertexID) { return Invoke<Vector>(nameof(GetVertexPosition), VertexID); }
        public EdgeID GetVertexPairEdge(VertexID VertexID0, VertexID VertexID1) { return Invoke<EdgeID>(nameof(GetVertexPairEdge), VertexID0, VertexID1); }
        public VertexID GetVertexInstanceVertex(VertexInstanceID VertexInstanceID) { return Invoke<VertexID>(nameof(GetVertexInstanceVertex), VertexInstanceID); }
        public EdgeID GetVertexInstancePairEdge(VertexInstanceID VertexInstanceID0, VertexInstanceID VertexInstanceID1) { return Invoke<EdgeID>(nameof(GetVertexInstancePairEdge), VertexInstanceID0, VertexInstanceID1); }
        public VertexInstanceID GetVertexInstanceForTriangleVertex(TriangleID TriangleID, VertexID VertexID) { return Invoke<VertexInstanceID>(nameof(GetVertexInstanceForTriangleVertex), TriangleID, VertexID); }
        public VertexInstanceID GetVertexInstanceForPolygonVertex(PolygonID PolygonID, VertexID VertexID) { return Invoke<VertexInstanceID>(nameof(GetVertexInstanceForPolygonVertex), PolygonID, VertexID); }
        public int GetVertexInstanceCount() { return Invoke<int>(nameof(GetVertexInstanceCount)); }
        public void GetVertexInstanceConnectedTriangles(VertexInstanceID VertexInstanceID, Array<TriangleID> OutConnectedTriangleIDs) { Invoke(nameof(GetVertexInstanceConnectedTriangles), VertexInstanceID, OutConnectedTriangleIDs); }
        public void GetVertexInstanceConnectedPolygons(VertexInstanceID VertexInstanceID, Array<PolygonID> OutConnectedPolygonIDs) { Invoke(nameof(GetVertexInstanceConnectedPolygons), VertexInstanceID, OutConnectedPolygonIDs); }
        public int GetVertexCount() { return Invoke<int>(nameof(GetVertexCount)); }
        public void GetVertexConnectedTriangles(VertexID VertexID, Array<TriangleID> OutConnectedTriangleIDs) { Invoke(nameof(GetVertexConnectedTriangles), VertexID, OutConnectedTriangleIDs); }
        public void GetVertexConnectedPolygons(VertexID VertexID, Array<PolygonID> OutConnectedPolygonIDs) { Invoke(nameof(GetVertexConnectedPolygons), VertexID, OutConnectedPolygonIDs); }
        public void GetVertexConnectedEdges(VertexID VertexID, Array<EdgeID> OutEdgeIDs) { Invoke(nameof(GetVertexConnectedEdges), VertexID, OutEdgeIDs); }
        public void GetVertexAdjacentVertices(VertexID VertexID, Array<VertexID> OutAdjacentVertexIDs) { Invoke(nameof(GetVertexAdjacentVertices), VertexID, OutAdjacentVertexIDs); }
        public void GetTriangleVertices(TriangleID TriangleID, Array<VertexID> OutVertexIDs) { Invoke(nameof(GetTriangleVertices), TriangleID, OutVertexIDs); }
        public void GetTriangleVertexInstances(TriangleID TriangleID, Array<VertexInstanceID> OutVertexInstanceIDs) { Invoke(nameof(GetTriangleVertexInstances), TriangleID, OutVertexInstanceIDs); }
        public VertexInstanceID GetTriangleVertexInstance(TriangleID TriangleID, int Index) { return Invoke<VertexInstanceID>(nameof(GetTriangleVertexInstance), TriangleID, Index); }
        public PolygonGroupID GetTrianglePolygonGroup(TriangleID TriangleID) { return Invoke<PolygonGroupID>(nameof(GetTrianglePolygonGroup), TriangleID); }
        public PolygonID GetTrianglePolygon(TriangleID TriangleID) { return Invoke<PolygonID>(nameof(GetTrianglePolygon), TriangleID); }
        public void GetTriangleEdges(TriangleID TriangleID, Array<EdgeID> OutEdgeIDs) { Invoke(nameof(GetTriangleEdges), TriangleID, OutEdgeIDs); }
        public int GetTriangleCount() { return Invoke<int>(nameof(GetTriangleCount)); }
        public void GetTriangleAdjacentTriangles(TriangleID TriangleID, Array<TriangleID> OutTriangleIDs) { Invoke(nameof(GetTriangleAdjacentTriangles), TriangleID, OutTriangleIDs); }
        public void GetPolygonVertices(PolygonID PolygonID, Array<VertexID> OutVertexIDs) { Invoke(nameof(GetPolygonVertices), PolygonID, OutVertexIDs); }
        public void GetPolygonVertexInstances(PolygonID PolygonID, Array<VertexInstanceID> OutVertexInstanceIDs) { Invoke(nameof(GetPolygonVertexInstances), PolygonID, OutVertexInstanceIDs); }
        public void GetPolygonTriangles(PolygonID PolygonID, Array<TriangleID> OutTriangleIDs) { Invoke(nameof(GetPolygonTriangles), PolygonID, OutTriangleIDs); }
        public PolygonGroupID GetPolygonPolygonGroup(PolygonID PolygonID) { return Invoke<PolygonGroupID>(nameof(GetPolygonPolygonGroup), PolygonID); }
        public void GetPolygonPerimeterEdges(PolygonID PolygonID, Array<EdgeID> OutEdgeIDs) { Invoke(nameof(GetPolygonPerimeterEdges), PolygonID, OutEdgeIDs); }
        public void GetPolygonInternalEdges(PolygonID PolygonID, Array<EdgeID> OutEdgeIDs) { Invoke(nameof(GetPolygonInternalEdges), PolygonID, OutEdgeIDs); }
        public void GetPolygonGroupPolygons(PolygonGroupID PolygonGroupID, Array<PolygonID> OutPolygonIDs) { Invoke(nameof(GetPolygonGroupPolygons), PolygonGroupID, OutPolygonIDs); }
        public int GetPolygonGroupCount() { return Invoke<int>(nameof(GetPolygonGroupCount)); }
        public int GetPolygonCount() { return Invoke<int>(nameof(GetPolygonCount)); }
        public void GetPolygonAdjacentPolygons(PolygonID PolygonID, Array<PolygonID> OutPolygonIDs) { Invoke(nameof(GetPolygonAdjacentPolygons), PolygonID, OutPolygonIDs); }
        public int GetNumVertexVertexInstances(VertexID VertexID) { return Invoke<int>(nameof(GetNumVertexVertexInstances), VertexID); }
        public int GetNumVertexInstanceConnectedTriangles(VertexInstanceID VertexInstanceID) { return Invoke<int>(nameof(GetNumVertexInstanceConnectedTriangles), VertexInstanceID); }
        public int GetNumVertexInstanceConnectedPolygons(VertexInstanceID VertexInstanceID) { return Invoke<int>(nameof(GetNumVertexInstanceConnectedPolygons), VertexInstanceID); }
        public int GetNumVertexConnectedTriangles(VertexID VertexID) { return Invoke<int>(nameof(GetNumVertexConnectedTriangles), VertexID); }
        public int GetNumVertexConnectedPolygons(VertexID VertexID) { return Invoke<int>(nameof(GetNumVertexConnectedPolygons), VertexID); }
        public int GetNumVertexConnectedEdges(VertexID VertexID) { return Invoke<int>(nameof(GetNumVertexConnectedEdges), VertexID); }
        public int GetNumPolygonVertices(PolygonID PolygonID) { return Invoke<int>(nameof(GetNumPolygonVertices), PolygonID); }
        public int GetNumPolygonTriangles(PolygonID PolygonID) { return Invoke<int>(nameof(GetNumPolygonTriangles), PolygonID); }
        public int GetNumPolygonInternalEdges(PolygonID PolygonID) { return Invoke<int>(nameof(GetNumPolygonInternalEdges), PolygonID); }
        public int GetNumPolygonGroupPolygons(PolygonGroupID PolygonGroupID) { return Invoke<int>(nameof(GetNumPolygonGroupPolygons), PolygonGroupID); }
        public int GetNumEdgeConnectedTriangles(EdgeID EdgeID) { return Invoke<int>(nameof(GetNumEdgeConnectedTriangles), EdgeID); }
        public int GetNumEdgeConnectedPolygons(EdgeID EdgeID) { return Invoke<int>(nameof(GetNumEdgeConnectedPolygons), EdgeID); }
        public void GetEdgeVertices(EdgeID EdgeID, Array<VertexID> OutVertexIDs) { Invoke(nameof(GetEdgeVertices), EdgeID, OutVertexIDs); }
        public VertexID GetEdgeVertex(EdgeID EdgeID, int VertexNumber) { return Invoke<VertexID>(nameof(GetEdgeVertex), EdgeID, VertexNumber); }
        public int GetEdgeCount() { return Invoke<int>(nameof(GetEdgeCount)); }
        public void GetEdgeConnectedTriangles(EdgeID EdgeID, Array<TriangleID> OutConnectedTriangleIDs) { Invoke(nameof(GetEdgeConnectedTriangles), EdgeID, OutConnectedTriangleIDs); }
        public void GetEdgeConnectedPolygons(EdgeID EdgeID, Array<PolygonID> OutConnectedPolygonIDs) { Invoke(nameof(GetEdgeConnectedPolygons), EdgeID, OutConnectedPolygonIDs); }
        public void Empty() { Invoke(nameof(Empty)); }
        public void DeleteVertexInstance(VertexInstanceID VertexInstanceID, Array<VertexID> OrphanedVertices) { Invoke(nameof(DeleteVertexInstance), VertexInstanceID, OrphanedVertices); }
        public void DeleteVertex(VertexID VertexID) { Invoke(nameof(DeleteVertex), VertexID); }
        public void DeleteTriangle(TriangleID TriangleID, Array<EdgeID> OrphanedEdges, Array<VertexInstanceID> OrphanedVertexInstances, Array<PolygonGroupID> OrphanedPolygonGroupsPtr) { Invoke(nameof(DeleteTriangle), TriangleID, OrphanedEdges, OrphanedVertexInstances, OrphanedPolygonGroupsPtr); }
        public void DeletePolygonGroup(PolygonGroupID PolygonGroupID) { Invoke(nameof(DeletePolygonGroup), PolygonGroupID); }
        public void DeletePolygon(PolygonID PolygonID, Array<EdgeID> OrphanedEdges, Array<VertexInstanceID> OrphanedVertexInstances, Array<PolygonGroupID> OrphanedPolygonGroups) { Invoke(nameof(DeletePolygon), PolygonID, OrphanedEdges, OrphanedVertexInstances, OrphanedPolygonGroups); }
        public void DeleteEdge(EdgeID EdgeID, Array<VertexID> OrphanedVertices) { Invoke(nameof(DeleteEdge), EdgeID, OrphanedVertices); }
        public void CreateVertexWithID(VertexID VertexID) { Invoke(nameof(CreateVertexWithID), VertexID); }
        public void CreateVertexInstanceWithID(VertexInstanceID VertexInstanceID, VertexID VertexID) { Invoke(nameof(CreateVertexInstanceWithID), VertexInstanceID, VertexID); }
        public VertexInstanceID CreateVertexInstance(VertexID VertexID) { return Invoke<VertexInstanceID>(nameof(CreateVertexInstance), VertexID); }
        public VertexID CreateVertex() { return Invoke<VertexID>(nameof(CreateVertex)); }
        public void CreateTriangleWithID(TriangleID TriangleID, PolygonGroupID PolygonGroupID, Array<VertexInstanceID> VertexInstanceIDs, Array<EdgeID> NewEdgeIDs) { Invoke(nameof(CreateTriangleWithID), TriangleID, PolygonGroupID, VertexInstanceIDs, NewEdgeIDs); }
        public TriangleID CreateTriangle(PolygonGroupID PolygonGroupID, Array<VertexInstanceID> VertexInstanceIDs, Array<EdgeID> NewEdgeIDs) { return Invoke<TriangleID>(nameof(CreateTriangle), PolygonGroupID, VertexInstanceIDs, NewEdgeIDs); }
        public void CreatePolygonWithID(PolygonID PolygonID, PolygonGroupID PolygonGroupID, Array<VertexInstanceID> VertexInstanceIDs, Array<EdgeID> NewEdgeIDs) { Invoke(nameof(CreatePolygonWithID), PolygonID, PolygonGroupID, VertexInstanceIDs, NewEdgeIDs); }
        public void CreatePolygonGroupWithID(PolygonGroupID PolygonGroupID) { Invoke(nameof(CreatePolygonGroupWithID), PolygonGroupID); }
        public PolygonGroupID CreatePolygonGroup() { return Invoke<PolygonGroupID>(nameof(CreatePolygonGroup)); }
        public PolygonID CreatePolygon(PolygonGroupID PolygonGroupID, Array<VertexInstanceID> VertexInstanceIDs, Array<EdgeID> NewEdgeIDs) { return Invoke<PolygonID>(nameof(CreatePolygon), PolygonGroupID, VertexInstanceIDs, NewEdgeIDs); }
        public void CreateEdgeWithID(EdgeID EdgeID, VertexID VertexID0, VertexID VertexID1) { Invoke(nameof(CreateEdgeWithID), EdgeID, VertexID0, VertexID1); }
        public EdgeID CreateEdge(VertexID VertexID0, VertexID VertexID1) { return Invoke<EdgeID>(nameof(CreateEdge), VertexID0, VertexID1); }
        public void ComputePolygonTriangulation(PolygonID PolygonID) { Invoke(nameof(ComputePolygonTriangulation), PolygonID); }
    }
    public class MeshDescriptionBaseBulkData : Object
    {
        public MeshDescriptionBaseBulkData(nint addr) : base(addr) { }
    }
    public enum EComputeNTBsOptions : int
    {
        None = 0,
        Normals = 1,
        Tangents = 2,
        WeightedNTBs = 4,
        EComputeNTBsOptions_MAX = 5,
    }
    public class ElementID : Object
    {
        public ElementID(nint addr) : base(addr) { }
        public int IDValue { get { return this[nameof(IDValue)].GetValue<int>(); } set { this[nameof(IDValue)].SetValue<int>(value); } }
    }
    public class VertexID : ElementID
    {
        public VertexID(nint addr) : base(addr) { }
    }
    public class VertexInstanceID : ElementID
    {
        public VertexInstanceID(nint addr) : base(addr) { }
    }
    public class EdgeID : ElementID
    {
        public EdgeID(nint addr) : base(addr) { }
    }
    public class UVID : ElementID
    {
        public UVID(nint addr) : base(addr) { }
    }
    public class TriangleID : ElementID
    {
        public TriangleID(nint addr) : base(addr) { }
    }
    public class PolygonGroupID : ElementID
    {
        public PolygonGroupID(nint addr) : base(addr) { }
    }
    public class PolygonID : ElementID
    {
        public PolygonID(nint addr) : base(addr) { }
    }
}
