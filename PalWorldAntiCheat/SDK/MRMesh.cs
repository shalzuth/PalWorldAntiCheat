using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MRMeshSDK
{
    public class MockDataMeshTrackerComponent : SceneComponent
    {
        public MockDataMeshTrackerComponent(nint addr) : base(addr) { }
        public Object OnMeshTrackerUpdated { get { return this[nameof(OnMeshTrackerUpdated)]; } set { this[nameof(OnMeshTrackerUpdated)] = value; } }
        public bool ScanWorld { get { return this[nameof(ScanWorld)].Flag; } set { this[nameof(ScanWorld)].Flag = value; } }
        public bool RequestNormals { get { return this[nameof(RequestNormals)].Flag; } set { this[nameof(RequestNormals)].Flag = value; } }
        public bool RequestVertexConfidence { get { return this[nameof(RequestVertexConfidence)].Flag; } set { this[nameof(RequestVertexConfidence)].Flag = value; } }
        public EMeshTrackerVertexColorMode VertexColorMode { get { return (EMeshTrackerVertexColorMode)this[nameof(VertexColorMode)].GetValue<int>(); } set { this[nameof(VertexColorMode)].SetValue<int>((int)value); } }
        public Array<Color> BlockVertexColors { get { return new Array<Color>(this[nameof(BlockVertexColors)].Address); } }
        public LinearColor VertexColorFromConfidenceZero { get { return this[nameof(VertexColorFromConfidenceZero)].As<LinearColor>(); } set { this["VertexColorFromConfidenceZero"] = value; } }
        public LinearColor VertexColorFromConfidenceOne { get { return this[nameof(VertexColorFromConfidenceOne)].As<LinearColor>(); } set { this["VertexColorFromConfidenceOne"] = value; } }
        public float UpdateInterval { get { return this[nameof(UpdateInterval)].GetValue<float>(); } set { this[nameof(UpdateInterval)].SetValue<float>(value); } }
        public MRMeshComponent MRMesh { get { return this[nameof(MRMesh)].As<MRMeshComponent>(); } set { this["MRMesh"] = value; } }
        public void OnMockDataMeshTrackerUpdated__DelegateSignature(int Index, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<float> Confidence) { Invoke(nameof(OnMockDataMeshTrackerUpdated__DelegateSignature), Index, Vertices, Triangles, normals, Confidence); }
        public void DisconnectMRMesh(MRMeshComponent InMRMeshPtr) { Invoke(nameof(DisconnectMRMesh), InMRMeshPtr); }
        public void ConnectMRMesh(MRMeshComponent InMRMeshPtr) { Invoke(nameof(ConnectMRMesh), InMRMeshPtr); }
    }
    public class MRMeshBodyHolder : Object
    {
        public MRMeshBodyHolder(nint addr) : base(addr) { }
        public BodySetup BodySetup { get { return this[nameof(BodySetup)].As<BodySetup>(); } set { this["BodySetup"] = value; } }
        public BodyInstance BodyInstance { get { return this[nameof(BodyInstance)].As<BodyInstance>(); } set { this["BodyInstance"] = value; } }
    }
    public class MRMeshComponent : PrimitiveComponent
    {
        public MRMeshComponent(nint addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public MaterialInterface WireframeMaterial { get { return this[nameof(WireframeMaterial)].As<MaterialInterface>(); } set { this["WireframeMaterial"] = value; } }
        public bool bCreateMeshProxySections { get { return this[nameof(bCreateMeshProxySections)].Flag; } set { this[nameof(bCreateMeshProxySections)].Flag = value; } }
        public bool bUpdateNavMeshOnMeshUpdate { get { return this[nameof(bUpdateNavMeshOnMeshUpdate)].Flag; } set { this[nameof(bUpdateNavMeshOnMeshUpdate)].Flag = value; } }
        public bool bNeverCreateCollisionMesh { get { return this[nameof(bNeverCreateCollisionMesh)].Flag; } set { this[nameof(bNeverCreateCollisionMesh)].Flag = value; } }
        public Array<MRMeshBodyHolder> BodyHolders { get { return new Array<MRMeshBodyHolder>(this[nameof(BodyHolders)].Address); } }
        public void SetWireframeMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetWireframeMaterial), InMaterial); }
        public void SetWireframeColor(LinearColor inColor) { Invoke(nameof(SetWireframeColor), inColor); }
        public void SetUseWireframe(bool bUseWireframe) { Invoke(nameof(SetUseWireframe), bUseWireframe); }
        public void SetEnableMeshOcclusion(bool bEnable) { Invoke(nameof(SetEnableMeshOcclusion), bEnable); }
        public void RequestNavMeshUpdate() { Invoke(nameof(RequestNavMeshUpdate)); }
        public bool IsConnected() { return Invoke<bool>(nameof(IsConnected)); }
        public LinearColor GetWireframeColor() { return Invoke<LinearColor>(nameof(GetWireframeColor)); }
        public bool GetUseWireframe() { return Invoke<bool>(nameof(GetUseWireframe)); }
        public bool GetEnableMeshOcclusion() { return Invoke<bool>(nameof(GetEnableMeshOcclusion)); }
        public void ForceNavMeshUpdate() { Invoke(nameof(ForceNavMeshUpdate)); }
        public void Clear() { Invoke(nameof(Clear)); }
    }
    public class MeshReconstructorBase : Object
    {
        public MeshReconstructorBase(nint addr) : base(addr) { }
        public void StopReconstruction() { Invoke(nameof(StopReconstruction)); }
        public void StartReconstruction() { Invoke(nameof(StartReconstruction)); }
        public void PauseReconstruction() { Invoke(nameof(PauseReconstruction)); }
        public bool IsReconstructionStarted() { return Invoke<bool>(nameof(IsReconstructionStarted)); }
        public bool IsReconstructionPaused() { return Invoke<bool>(nameof(IsReconstructionPaused)); }
        public void DisconnectMRMesh() { Invoke(nameof(DisconnectMRMesh)); }
        public void ConnectMRMesh(MRMeshComponent Mesh) { Invoke(nameof(ConnectMRMesh), Mesh); }
    }
    public enum EMeshTrackerVertexColorMode : int
    {
        None = 0,
        Confidence = 1,
        Block = 2,
        EMeshTrackerVertexColorMode_MAX = 3,
    }
    public class MRMeshConfiguration : Object
    {
        public MRMeshConfiguration(nint addr) : base(addr) { }
    }
}
