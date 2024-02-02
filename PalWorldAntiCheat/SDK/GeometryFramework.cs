using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryFrameworkSDK
{
    public class BaseDynamicMeshComponent : MeshComponent
    {
        public BaseDynamicMeshComponent(nint addr) : base(addr) { }
        public bool bExplicitShowWireframe { get { return this[nameof(bExplicitShowWireframe)].Flag; } set { this[nameof(bExplicitShowWireframe)].Flag = value; } }
        public LinearColor WireframeColor { get { return this[nameof(WireframeColor)].As<LinearColor>(); } set { this["WireframeColor"] = value; } }
        public EDynamicMeshComponentColorOverrideMode ColorMode { get { return (EDynamicMeshComponentColorOverrideMode)this[nameof(ColorMode)].GetValue<int>(); } set { this[nameof(ColorMode)].SetValue<int>((int)value); } }
        public Color ConstantColor { get { return this[nameof(ConstantColor)].As<Color>(); } set { this["ConstantColor"] = value; } }
        public bool bEnableFlatShading { get { return this[nameof(bEnableFlatShading)].Flag; } set { this[nameof(bEnableFlatShading)].Flag = value; } }
        public bool bEnableViewModeOverrides { get { return this[nameof(bEnableViewModeOverrides)].Flag; } set { this[nameof(bEnableViewModeOverrides)].Flag = value; } }
        public MaterialInterface OverrideRenderMaterial { get { return this[nameof(OverrideRenderMaterial)].As<MaterialInterface>(); } set { this["OverrideRenderMaterial"] = value; } }
        public MaterialInterface SecondaryRenderMaterial { get { return this[nameof(SecondaryRenderMaterial)].As<MaterialInterface>(); } set { this["SecondaryRenderMaterial"] = value; } }
        public bool bEnableRayTracing { get { return this[nameof(bEnableRayTracing)].Flag; } set { this[nameof(bEnableRayTracing)].Flag = value; } }
        public Array<MaterialInterface> BaseMaterials { get { return new Array<MaterialInterface>(this[nameof(BaseMaterials)].Address); } }
        public void SetViewModeOverridesEnabled(bool bEnabled) { Invoke(nameof(SetViewModeOverridesEnabled), bEnabled); }
        public void SetShadowsEnabled(bool bEnabled) { Invoke(nameof(SetShadowsEnabled), bEnabled); }
        public void SetSecondaryRenderMaterial(MaterialInterface Material) { Invoke(nameof(SetSecondaryRenderMaterial), Material); }
        public void SetSecondaryBuffersVisibility(bool bSetVisible) { Invoke(nameof(SetSecondaryBuffersVisibility), bSetVisible); }
        public void SetOverrideRenderMaterial(MaterialInterface Material) { Invoke(nameof(SetOverrideRenderMaterial), Material); }
        public void SetEnableWireframeRenderPass(bool bEnable) { Invoke(nameof(SetEnableWireframeRenderPass), bEnable); }
        public void SetEnableRaytracing(bool bSetEnabled) { Invoke(nameof(SetEnableRaytracing), bSetEnabled); }
        public void SetEnableFlatShading(bool bEnable) { Invoke(nameof(SetEnableFlatShading), bEnable); }
        public void SetConstantOverrideColor(Color NewColor) { Invoke(nameof(SetConstantOverrideColor), NewColor); }
        public void SetColorOverrideMode(EDynamicMeshComponentColorOverrideMode newMode) { Invoke(nameof(SetColorOverrideMode), newMode); }
        public bool HasOverrideRenderMaterial(int K) { return Invoke<bool>(nameof(HasOverrideRenderMaterial), K); }
        public bool GetViewModeOverridesEnabled() { return Invoke<bool>(nameof(GetViewModeOverridesEnabled)); }
        public bool GetShadowsEnabled() { return Invoke<bool>(nameof(GetShadowsEnabled)); }
        public MaterialInterface GetSecondaryRenderMaterial() { return Invoke<MaterialInterface>(nameof(GetSecondaryRenderMaterial)); }
        public bool GetSecondaryBuffersVisibility() { return Invoke<bool>(nameof(GetSecondaryBuffersVisibility)); }
        public MaterialInterface GetOverrideRenderMaterial(int MaterialIndex) { return Invoke<MaterialInterface>(nameof(GetOverrideRenderMaterial), MaterialIndex); }
        public bool GetFlatShadingEnabled() { return Invoke<bool>(nameof(GetFlatShadingEnabled)); }
        public bool GetEnableWireframeRenderPass() { return Invoke<bool>(nameof(GetEnableWireframeRenderPass)); }
        public bool GetEnableRaytracing() { return Invoke<bool>(nameof(GetEnableRaytracing)); }
        public DynamicMesh GetDynamicMesh() { return Invoke<DynamicMesh>(nameof(GetDynamicMesh)); }
        public Color GetConstantOverrideColor() { return Invoke<Color>(nameof(GetConstantOverrideColor)); }
        public EDynamicMeshComponentColorOverrideMode GetColorOverrideMode() { return Invoke<EDynamicMeshComponentColorOverrideMode>(nameof(GetColorOverrideMode)); }
        public void ClearSecondaryRenderMaterial() { Invoke(nameof(ClearSecondaryRenderMaterial)); }
        public void ClearOverrideRenderMaterial() { Invoke(nameof(ClearOverrideRenderMaterial)); }
    }
    public class MeshCommandChangeTarget : Interface
    {
        public MeshCommandChangeTarget(nint addr) : base(addr) { }
    }
    public class MeshReplacementCommandChangeTarget : Interface
    {
        public MeshReplacementCommandChangeTarget(nint addr) : base(addr) { }
    }
    public class MeshVertexCommandChangeTarget : Interface
    {
        public MeshVertexCommandChangeTarget(nint addr) : base(addr) { }
    }
    public class DynamicMeshComponent : BaseDynamicMeshComponent
    {
        public DynamicMeshComponent(nint addr) : base(addr) { }
        public DynamicMesh MeshObject { get { return this[nameof(MeshObject)].As<DynamicMesh>(); } set { this["MeshObject"] = value; } }
        public EDynamicMeshComponentTangentsMode TangentsType { get { return (EDynamicMeshComponentTangentsMode)this[nameof(TangentsType)].GetValue<int>(); } set { this[nameof(TangentsType)].SetValue<int>((int)value); } }
        public byte CollisionType { get { return this[nameof(CollisionType)].GetValue<byte>(); } set { this[nameof(CollisionType)].SetValue<byte>(value); } }
        public bool bUseAsyncCooking { get { return this[nameof(bUseAsyncCooking)].Flag; } set { this[nameof(bUseAsyncCooking)].Flag = value; } }
        public bool bEnableComplexCollision { get { return this[nameof(bEnableComplexCollision)].Flag; } set { this[nameof(bEnableComplexCollision)].Flag = value; } }
        public bool bDeferCollisionUpdates { get { return this[nameof(bDeferCollisionUpdates)].Flag; } set { this[nameof(bDeferCollisionUpdates)].Flag = value; } }
        public BodySetup MeshBodySetup { get { return this[nameof(MeshBodySetup)].As<BodySetup>(); } set { this["MeshBodySetup"] = value; } }
        public KAggregateGeom AggGeom { get { return this[nameof(AggGeom)].As<KAggregateGeom>(); } set { this["AggGeom"] = value; } }
        public Array<BodySetup> AsyncBodySetupQueue { get { return new Array<BodySetup>(this[nameof(AsyncBodySetupQueue)].Address); } }
        public bool ValidateMaterialSlots(bool bCreateIfMissing, bool bDeleteExtraSlots) { return Invoke<bool>(nameof(ValidateMaterialSlots), bCreateIfMissing, bDeleteExtraSlots); }
        public void UpdateCollision(bool bOnlyIfPending) { Invoke(nameof(UpdateCollision), bOnlyIfPending); }
        public void SetTangentsType(EDynamicMeshComponentTangentsMode NewTangentsType) { Invoke(nameof(SetTangentsType), NewTangentsType); }
        public void SetDynamicMesh(DynamicMesh NewMesh) { Invoke(nameof(SetDynamicMesh), NewMesh); }
        public void SetDeferredCollisionUpdatesEnabled(bool bEnabled, bool bImmediateUpdate) { Invoke(nameof(SetDeferredCollisionUpdatesEnabled), bEnabled, bImmediateUpdate); }
        public void SetComplexAsSimpleCollisionEnabled(bool bEnabled, bool bImmediateUpdate) { Invoke(nameof(SetComplexAsSimpleCollisionEnabled), bEnabled, bImmediateUpdate); }
        public EDynamicMeshComponentTangentsMode GetTangentsType() { return Invoke<EDynamicMeshComponentTangentsMode>(nameof(GetTangentsType)); }
        public void EnableComplexAsSimpleCollision() { Invoke(nameof(EnableComplexAsSimpleCollision)); }
        public void ConfigureMaterialSet(Array<MaterialInterface> NewMaterialSet) { Invoke(nameof(ConfigureMaterialSet), NewMaterialSet); }
    }
    public class DynamicMeshActor : Actor
    {
        public DynamicMeshActor(nint addr) : base(addr) { }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
        public bool bEnableComputeMeshPool { get { return this[nameof(bEnableComputeMeshPool)].Flag; } set { this[nameof(bEnableComputeMeshPool)].Flag = value; } }
        public DynamicMeshPool DynamicMeshPool { get { return this[nameof(DynamicMeshPool)].As<DynamicMeshPool>(); } set { this["DynamicMeshPool"] = value; } }
        public bool ReleaseComputeMesh(DynamicMesh Mesh) { return Invoke<bool>(nameof(ReleaseComputeMesh), Mesh); }
        public void ReleaseAllComputeMeshes() { Invoke(nameof(ReleaseAllComputeMeshes)); }
        public DynamicMeshComponent GetDynamicMeshComponent() { return Invoke<DynamicMeshComponent>(nameof(GetDynamicMeshComponent)); }
        public DynamicMeshPool GetComputeMeshPool() { return Invoke<DynamicMeshPool>(nameof(GetComputeMeshPool)); }
        public void FreeAllComputeMeshes() { Invoke(nameof(FreeAllComputeMeshes)); }
        public DynamicMesh AllocateComputeMesh() { return Invoke<DynamicMesh>(nameof(AllocateComputeMesh)); }
    }
    public class DynamicMeshGenerator : Object
    {
        public DynamicMeshGenerator(nint addr) : base(addr) { }
    }
    public class DynamicMesh : Object
    {
        public DynamicMesh(nint addr) : base(addr) { }
        public Object MeshModifiedBPEvent { get { return this[nameof(MeshModifiedBPEvent)]; } set { this[nameof(MeshModifiedBPEvent)] = value; } }
        public DynamicMeshGenerator MeshGenerator { get { return this[nameof(MeshGenerator)].As<DynamicMeshGenerator>(); } set { this["MeshGenerator"] = value; } }
        public bool bEnableMeshGenerator { get { return this[nameof(bEnableMeshGenerator)].Flag; } set { this[nameof(bEnableMeshGenerator)].Flag = value; } }
        public DynamicMesh ResetToCube() { return Invoke<DynamicMesh>(nameof(ResetToCube)); }
        public DynamicMesh Reset() { return Invoke<DynamicMesh>(nameof(Reset)); }
        public bool IsEmpty() { return Invoke<bool>(nameof(IsEmpty)); }
        public int GetTriangleCount() { return Invoke<int>(nameof(GetTriangleCount)); }
    }
    public class DynamicMeshPool : Object
    {
        public DynamicMeshPool(nint addr) : base(addr) { }
        public Array<DynamicMesh> CachedMeshes { get { return new Array<DynamicMesh>(this[nameof(CachedMeshes)].Address); } }
        public Array<DynamicMesh> AllCreatedMeshes { get { return new Array<DynamicMesh>(this[nameof(AllCreatedMeshes)].Address); } }
        public void ReturnMesh(DynamicMesh Mesh) { Invoke(nameof(ReturnMesh), Mesh); }
        public void ReturnAllMeshes() { Invoke(nameof(ReturnAllMeshes)); }
        public DynamicMesh RequestMesh() { return Invoke<DynamicMesh>(nameof(RequestMesh)); }
        public void FreeAllMeshes() { Invoke(nameof(FreeAllMeshes)); }
    }
    public enum EDynamicMeshComponentTangentsMode : int
    {
        NoTangents = 0,
        AutoCalculated = 1,
        ExternallyProvided = 2,
        EDynamicMeshComponentTangentsMode_MAX = 3,
    }
    public enum EDynamicMeshComponentColorOverrideMode : int
    {
        None = 0,
        VertexColors = 1,
        Polygroups = 2,
        Constant = 3,
        EDynamicMeshComponentColorOverrideMode_MAX = 4,
    }
    public enum EDynamicMeshComponentRenderUpdateMode : int
    {
        NoUpdate = 0,
        FullUpdate = 1,
        FastUpdate = 2,
        EDynamicMeshComponentRenderUpdateMode_MAX = 3,
    }
    public enum EDynamicMeshChangeType : int
    {
        GeneralEdit = 0,
        MeshChange = 1,
        MeshReplacementChange = 2,
        MeshVertexChange = 3,
        DeformationEdit = 4,
        AttributeEdit = 5,
        EDynamicMeshChangeType_MAX = 6,
    }
    public enum EDynamicMeshAttributeChangeFlags : int
    {
        Unknown = 0,
        MeshTopology = 1,
        VertexPositions = 2,
        NormalsTangents = 4,
        VertexColors = 8,
        UVs = 16,
        TriangleGroups = 32,
        EDynamicMeshAttributeChangeFlags_MAX = 33,
    }
    public class DynamicMeshChangeInfo : Object
    {
        public DynamicMeshChangeInfo(nint addr) : base(addr) { }
        public EDynamicMeshChangeType Type { get { return (EDynamicMeshChangeType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public EDynamicMeshAttributeChangeFlags Flags { get { return (EDynamicMeshAttributeChangeFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
        public bool bIsRevertChange { get { return this[nameof(bIsRevertChange)].Flag; } set { this[nameof(bIsRevertChange)].Flag = value; } }
    }
}
