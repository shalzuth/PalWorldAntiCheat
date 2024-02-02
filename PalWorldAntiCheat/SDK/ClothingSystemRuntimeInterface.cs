using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ClothingSystemRuntimeInterfaceSDK
{
    public class ClothConfigBase : Object
    {
        public ClothConfigBase(nint addr) : base(addr) { }
    }
    public class ClothingSimulationFactory : Object
    {
        public ClothingSimulationFactory(nint addr) : base(addr) { }
    }
    public class ClothingInteractor : Object
    {
        public ClothingInteractor(nint addr) : base(addr) { }
    }
    public class ClothingSimulationInteractor : Object
    {
        public ClothingSimulationInteractor(nint addr) : base(addr) { }
        public Object ClothingInteractors { get { return this[nameof(ClothingInteractors)]; } set { this[nameof(ClothingInteractors)] = value; } }
        public void SetNumSubsteps(int NumSubsteps) { Invoke(nameof(SetNumSubsteps), NumSubsteps); }
        public void SetNumIterations(int NumIterations) { Invoke(nameof(SetNumIterations), NumIterations); }
        public void SetMaxNumIterations(int MaxNumIterations) { Invoke(nameof(SetMaxNumIterations), MaxNumIterations); }
        public void SetAnimDriveSpringStiffness(float InStiffness) { Invoke(nameof(SetAnimDriveSpringStiffness), InStiffness); }
        public void PhysicsAssetUpdated() { Invoke(nameof(PhysicsAssetUpdated)); }
        public float GetSimulationTime() { return Invoke<float>(nameof(GetSimulationTime)); }
        public int GetNumSubsteps() { return Invoke<int>(nameof(GetNumSubsteps)); }
        public int GetNumKinematicParticles() { return Invoke<int>(nameof(GetNumKinematicParticles)); }
        public int GetNumIterations() { return Invoke<int>(nameof(GetNumIterations)); }
        public int GetNumDynamicParticles() { return Invoke<int>(nameof(GetNumDynamicParticles)); }
        public int GetNumCloths() { return Invoke<int>(nameof(GetNumCloths)); }
        public ClothingInteractor GetClothingInteractor(Object ClothingAssetName) { return Invoke<ClothingInteractor>(nameof(GetClothingInteractor), ClothingAssetName); }
        public void EnableGravityOverride(Vector InVector) { Invoke(nameof(EnableGravityOverride), InVector); }
        public void DisableGravityOverride() { Invoke(nameof(DisableGravityOverride)); }
        public void ClothConfigUpdated() { Invoke(nameof(ClothConfigUpdated)); }
    }
    public class ClothingAssetBase : Object
    {
        public ClothingAssetBase(nint addr) : base(addr) { }
        public Object ImportedFilePath { get { return this[nameof(ImportedFilePath)]; } set { this[nameof(ImportedFilePath)] = value; } }
        public Guid AssetGuid { get { return this[nameof(AssetGuid)].As<Guid>(); } set { this["AssetGuid"] = value; } }
    }
    public class ClothSharedSimConfigBase : Object
    {
        public ClothSharedSimConfigBase(nint addr) : base(addr) { }
    }
    public class ClothPhysicalMeshDataBase_Legacy : Object
    {
        public ClothPhysicalMeshDataBase_Legacy(nint addr) : base(addr) { }
        public Array<Vector3f> Vertices { get { return new Array<Vector3f>(this[nameof(Vertices)].Address); } }
        public Array<Vector3f> normals { get { return new Array<Vector3f>(this[nameof(normals)].Address); } }
        public Array<uint> Indices { get { return new Array<uint>(this[nameof(Indices)].Address); } }
        public Array<float> InverseMasses { get { return new Array<float>(this[nameof(InverseMasses)].Address); } }
        public Array<ClothVertBoneData> BoneData { get { return new Array<ClothVertBoneData>(this[nameof(BoneData)].Address); } }
        public int NumFixedVerts { get { return this[nameof(NumFixedVerts)].GetValue<int>(); } set { this[nameof(NumFixedVerts)].SetValue<int>(value); } }
        public int MaxBoneWeights { get { return this[nameof(MaxBoneWeights)].GetValue<int>(); } set { this[nameof(MaxBoneWeights)].SetValue<int>(value); } }
        public Array<uint> SelfCollisionIndices { get { return new Array<uint>(this[nameof(SelfCollisionIndices)].Address); } }
    }
    public class ClothCollisionPrim_Sphere : Object
    {
        public ClothCollisionPrim_Sphere(nint addr) : base(addr) { }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector LocalPosition { get { return this[nameof(LocalPosition)].As<Vector>(); } set { this["LocalPosition"] = value; } }
    }
    public class ClothCollisionPrim_SphereConnection : Object
    {
        public ClothCollisionPrim_SphereConnection(nint addr) : base(addr) { }
        public int SphereIndices { get { return this[nameof(SphereIndices)].GetValue<int>(); } set { this[nameof(SphereIndices)].SetValue<int>(value); } }
    }
    public class ClothCollisionPrim_ConvexFace : Object
    {
        public ClothCollisionPrim_ConvexFace(nint addr) : base(addr) { }
        public Plane Plane { get { return this[nameof(Plane)].As<Plane>(); } set { this["Plane"] = value; } }
        public Array<int> Indices { get { return new Array<int>(this[nameof(Indices)].Address); } }
    }
    public class ClothCollisionPrim_Convex : Object
    {
        public ClothCollisionPrim_Convex(nint addr) : base(addr) { }
        public Array<ClothCollisionPrim_ConvexFace> Faces { get { return new Array<ClothCollisionPrim_ConvexFace>(this[nameof(Faces)].Address); } }
        public Array<Vector> SurfacePoints { get { return new Array<Vector>(this[nameof(SurfacePoints)].Address); } }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
    }
    public class ClothCollisionPrim_Box : Object
    {
        public ClothCollisionPrim_Box(nint addr) : base(addr) { }
        public Vector LocalPosition { get { return this[nameof(LocalPosition)].As<Vector>(); } set { this["LocalPosition"] = value; } }
        public Quat LocalRotation { get { return this[nameof(LocalRotation)].As<Quat>(); } set { this["LocalRotation"] = value; } }
        public Vector HalfExtents { get { return this[nameof(HalfExtents)].As<Vector>(); } set { this["HalfExtents"] = value; } }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
    }
    public class ClothVertBoneData : Object
    {
        public ClothVertBoneData(nint addr) : base(addr) { }
        public int NumInfluences { get { return this[nameof(NumInfluences)].GetValue<int>(); } set { this[nameof(NumInfluences)].SetValue<int>(value); } }
        public ushort BoneIndices { get { return this[nameof(BoneIndices)].GetValue<ushort>(); } set { this[nameof(BoneIndices)].SetValue<ushort>(value); } }
        public float BoneWeights { get { return this[nameof(BoneWeights)].GetValue<float>(); } set { this[nameof(BoneWeights)].SetValue<float>(value); } }
    }
    public class ClothCollisionData : Object
    {
        public ClothCollisionData(nint addr) : base(addr) { }
        public Array<ClothCollisionPrim_Sphere> Spheres { get { return new Array<ClothCollisionPrim_Sphere>(this[nameof(Spheres)].Address); } }
        public Array<ClothCollisionPrim_SphereConnection> SphereConnections { get { return new Array<ClothCollisionPrim_SphereConnection>(this[nameof(SphereConnections)].Address); } }
        public Array<ClothCollisionPrim_Convex> Convexes { get { return new Array<ClothCollisionPrim_Convex>(this[nameof(Convexes)].Address); } }
        public Array<ClothCollisionPrim_Box> Boxes { get { return new Array<ClothCollisionPrim_Box>(this[nameof(Boxes)].Address); } }
    }
}
