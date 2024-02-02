using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AnimGraphRuntimeSDK;
namespace SDK.Script.KawaiiPhysicsSDK
{
    public class KawaiiPhysicsLimitsDataAsset : DataAsset
    {
        public KawaiiPhysicsLimitsDataAsset(nint addr) : base(addr) { }
        public Array<SphericalLimit> SphericalLimits { get { return new Array<SphericalLimit>(this[nameof(SphericalLimits)].Address); } }
        public Array<CapsuleLimit> CapsuleLimits { get { return new Array<CapsuleLimit>(this[nameof(CapsuleLimits)].Address); } }
        public Array<PlanarLimit> PlanarLimits { get { return new Array<PlanarLimit>(this[nameof(PlanarLimits)].Address); } }
    }
    public enum EPlanarConstraint : int
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
        EPlanarConstraint_MAX = 4,
    }
    public enum EBoneForwardAxis : int
    {
        X_Positive = 0,
        X_Negative = 1,
        Y_Positive = 2,
        Y_Negative = 3,
        Z_Positive = 4,
        Z_Negative = 5,
        EBoneForwardAxis_MAX = 6,
    }
    public enum ECollisionLimitType : int
    {
        None = 0,
        Spherical = 1,
        Capsule = 2,
        Planar = 3,
        ECollisionLimitType_MAX = 4,
    }
    public class CollisionLimitBase : Object
    {
        public CollisionLimitBase(nint addr) : base(addr) { }
        public BoneReference DrivingBone { get { return this[nameof(DrivingBone)].As<BoneReference>(); } set { this["DrivingBone"] = value; } }
        public Vector OffsetLocation { get { return this[nameof(OffsetLocation)].As<Vector>(); } set { this["OffsetLocation"] = value; } }
        public Rotator OffsetRotation { get { return this[nameof(OffsetRotation)].As<Rotator>(); } set { this["OffsetRotation"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class SphericalLimit : CollisionLimitBase
    {
        public SphericalLimit(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public ESphericalLimitType LimitType { get { return (ESphericalLimitType)this[nameof(LimitType)].GetValue<int>(); } set { this[nameof(LimitType)].SetValue<int>((int)value); } }
    }
    public class CapsuleLimit : CollisionLimitBase
    {
        public CapsuleLimit(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
    }
    public class PlanarLimit : CollisionLimitBase
    {
        public PlanarLimit(nint addr) : base(addr) { }
        public Plane Plane { get { return this[nameof(Plane)].As<Plane>(); } set { this["Plane"] = value; } }
    }
    public class KawaiiPhysicsSettings : Object
    {
        public KawaiiPhysicsSettings(nint addr) : base(addr) { }
        public float Damping { get { return this[nameof(Damping)].GetValue<float>(); } set { this[nameof(Damping)].SetValue<float>(value); } }
        public float WorldDampingLocation { get { return this[nameof(WorldDampingLocation)].GetValue<float>(); } set { this[nameof(WorldDampingLocation)].SetValue<float>(value); } }
        public float WorldDampingRotation { get { return this[nameof(WorldDampingRotation)].GetValue<float>(); } set { this[nameof(WorldDampingRotation)].SetValue<float>(value); } }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float LimitAngle { get { return this[nameof(LimitAngle)].GetValue<float>(); } set { this[nameof(LimitAngle)].SetValue<float>(value); } }
    }
    public class KawaiiPhysicsModifyBone : Object
    {
        public KawaiiPhysicsModifyBone(nint addr) : base(addr) { }
        public BoneReference BoneRef { get { return this[nameof(BoneRef)].As<BoneReference>(); } set { this["BoneRef"] = value; } }
        public int ParentIndex { get { return this[nameof(ParentIndex)].GetValue<int>(); } set { this[nameof(ParentIndex)].SetValue<int>(value); } }
        public Array<int> ChildIndexs { get { return new Array<int>(this[nameof(ChildIndexs)].Address); } }
        public KawaiiPhysicsSettings PhysicsSettings { get { return this[nameof(PhysicsSettings)].As<KawaiiPhysicsSettings>(); } set { this["PhysicsSettings"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector PrevLocation { get { return this[nameof(PrevLocation)].As<Vector>(); } set { this["PrevLocation"] = value; } }
        public Quat PrevRotation { get { return this[nameof(PrevRotation)].As<Quat>(); } set { this["PrevRotation"] = value; } }
        public Vector PoseLocation { get { return this[nameof(PoseLocation)].As<Vector>(); } set { this["PoseLocation"] = value; } }
        public Quat PoseRotation { get { return this[nameof(PoseRotation)].As<Quat>(); } set { this["PoseRotation"] = value; } }
        public Vector PoseScale { get { return this[nameof(PoseScale)].As<Vector>(); } set { this["PoseScale"] = value; } }
        public float LengthFromRoot { get { return this[nameof(LengthFromRoot)].GetValue<float>(); } set { this[nameof(LengthFromRoot)].SetValue<float>(value); } }
        public bool bDummy { get { return this[nameof(bDummy)].Flag; } set { this[nameof(bDummy)].Flag = value; } }
    }
    public class AnimNode_KawaiiPhysics : AnimNode_SkeletalControlBase
    {
        public AnimNode_KawaiiPhysics(nint addr) : base(addr) { }
        public BoneReference RootBone { get { return this[nameof(RootBone)].As<BoneReference>(); } set { this["RootBone"] = value; } }
        public Array<BoneReference> ExcludeBones { get { return new Array<BoneReference>(this[nameof(ExcludeBones)].Address); } }
        public int TargetFrameRate { get { return this[nameof(TargetFrameRate)].GetValue<int>(); } set { this[nameof(TargetFrameRate)].SetValue<int>(value); } }
        public bool OverrideTargetFramerate { get { return this[nameof(OverrideTargetFramerate)].Flag; } set { this[nameof(OverrideTargetFramerate)].Flag = value; } }
        public KawaiiPhysicsSettings PhysicsSettings { get { return this[nameof(PhysicsSettings)].As<KawaiiPhysicsSettings>(); } set { this["PhysicsSettings"] = value; } }
        public CurveFloat DampingCurve { get { return this[nameof(DampingCurve)].As<CurveFloat>(); } set { this["DampingCurve"] = value; } }
        public CurveFloat WorldDampingLocationCurve { get { return this[nameof(WorldDampingLocationCurve)].As<CurveFloat>(); } set { this["WorldDampingLocationCurve"] = value; } }
        public CurveFloat WorldDampingRotationCurve { get { return this[nameof(WorldDampingRotationCurve)].As<CurveFloat>(); } set { this["WorldDampingRotationCurve"] = value; } }
        public CurveFloat StiffnessCurve { get { return this[nameof(StiffnessCurve)].As<CurveFloat>(); } set { this["StiffnessCurve"] = value; } }
        public CurveFloat RadiusCurve { get { return this[nameof(RadiusCurve)].As<CurveFloat>(); } set { this["RadiusCurve"] = value; } }
        public CurveFloat LimitAngleCurve { get { return this[nameof(LimitAngleCurve)].As<CurveFloat>(); } set { this["LimitAngleCurve"] = value; } }
        public RuntimeFloatCurve DampingCurveData { get { return this[nameof(DampingCurveData)].As<RuntimeFloatCurve>(); } set { this["DampingCurveData"] = value; } }
        public RuntimeFloatCurve WorldDampingLocationCurveData { get { return this[nameof(WorldDampingLocationCurveData)].As<RuntimeFloatCurve>(); } set { this["WorldDampingLocationCurveData"] = value; } }
        public RuntimeFloatCurve WorldDampingRotationCurveData { get { return this[nameof(WorldDampingRotationCurveData)].As<RuntimeFloatCurve>(); } set { this["WorldDampingRotationCurveData"] = value; } }
        public RuntimeFloatCurve StiffnessCurveData { get { return this[nameof(StiffnessCurveData)].As<RuntimeFloatCurve>(); } set { this["StiffnessCurveData"] = value; } }
        public RuntimeFloatCurve RadiusCurveData { get { return this[nameof(RadiusCurveData)].As<RuntimeFloatCurve>(); } set { this["RadiusCurveData"] = value; } }
        public RuntimeFloatCurve LimitAngleCurveData { get { return this[nameof(LimitAngleCurveData)].As<RuntimeFloatCurve>(); } set { this["LimitAngleCurveData"] = value; } }
        public bool bUpdatePhysicsSettingsInGame { get { return this[nameof(bUpdatePhysicsSettingsInGame)].Flag; } set { this[nameof(bUpdatePhysicsSettingsInGame)].Flag = value; } }
        public float DummyBoneLength { get { return this[nameof(DummyBoneLength)].GetValue<float>(); } set { this[nameof(DummyBoneLength)].SetValue<float>(value); } }
        public EBoneForwardAxis BoneForwardAxis { get { return (EBoneForwardAxis)this[nameof(BoneForwardAxis)].GetValue<int>(); } set { this[nameof(BoneForwardAxis)].SetValue<int>((int)value); } }
        public EPlanarConstraint PlanarConstraint { get { return (EPlanarConstraint)this[nameof(PlanarConstraint)].GetValue<int>(); } set { this[nameof(PlanarConstraint)].SetValue<int>((int)value); } }
        public bool ResetBoneTransformWhenBoneNotFound { get { return this[nameof(ResetBoneTransformWhenBoneNotFound)].Flag; } set { this[nameof(ResetBoneTransformWhenBoneNotFound)].Flag = value; } }
        public Array<SphericalLimit> SphericalLimits { get { return new Array<SphericalLimit>(this[nameof(SphericalLimits)].Address); } }
        public Array<CapsuleLimit> CapsuleLimits { get { return new Array<CapsuleLimit>(this[nameof(CapsuleLimits)].Address); } }
        public Array<PlanarLimit> PlanarLimits { get { return new Array<PlanarLimit>(this[nameof(PlanarLimits)].Address); } }
        public KawaiiPhysicsLimitsDataAsset LimitsDataAsset { get { return this[nameof(LimitsDataAsset)].As<KawaiiPhysicsLimitsDataAsset>(); } set { this["LimitsDataAsset"] = value; } }
        public Array<SphericalLimit> SphericalLimitsData { get { return new Array<SphericalLimit>(this[nameof(SphericalLimitsData)].Address); } }
        public Array<CapsuleLimit> CapsuleLimitsData { get { return new Array<CapsuleLimit>(this[nameof(CapsuleLimitsData)].Address); } }
        public Array<PlanarLimit> PlanarLimitsData { get { return new Array<PlanarLimit>(this[nameof(PlanarLimitsData)].Address); } }
        public float TeleportDistanceThreshold { get { return this[nameof(TeleportDistanceThreshold)].GetValue<float>(); } set { this[nameof(TeleportDistanceThreshold)].SetValue<float>(value); } }
        public float TeleportRotationThreshold { get { return this[nameof(TeleportRotationThreshold)].GetValue<float>(); } set { this[nameof(TeleportRotationThreshold)].SetValue<float>(value); } }
        public Vector Gravity { get { return this[nameof(Gravity)].As<Vector>(); } set { this["Gravity"] = value; } }
        public bool bEnableWind { get { return this[nameof(bEnableWind)].Flag; } set { this[nameof(bEnableWind)].Flag = value; } }
        public float WindScale { get { return this[nameof(WindScale)].GetValue<float>(); } set { this[nameof(WindScale)].SetValue<float>(value); } }
        public bool bAllowWorldCollision { get { return this[nameof(bAllowWorldCollision)].Flag; } set { this[nameof(bAllowWorldCollision)].Flag = value; } }
        public bool bOverrideCollisionParams { get { return this[nameof(bOverrideCollisionParams)].Flag; } set { this[nameof(bOverrideCollisionParams)].Flag = value; } }
        public BodyInstance CollisionChannelSettings { get { return this[nameof(CollisionChannelSettings)].As<BodyInstance>(); } set { this["CollisionChannelSettings"] = value; } }
        public bool bIgnoreSelfComponent { get { return this[nameof(bIgnoreSelfComponent)].Flag; } set { this[nameof(bIgnoreSelfComponent)].Flag = value; } }
        public Array<BoneReference> IgnoreBones { get { return new Array<BoneReference>(this[nameof(IgnoreBones)].Address); } }
        public Array<Object> IgnoreBoneNamePrefix { get { return new Array<Object>(this[nameof(IgnoreBoneNamePrefix)].Address); } }
        public Array<KawaiiPhysicsModifyBone> ModifyBones { get { return new Array<KawaiiPhysicsModifyBone>(this[nameof(ModifyBones)].Address); } }
        public float TotalBoneLength { get { return this[nameof(TotalBoneLength)].GetValue<float>(); } set { this[nameof(TotalBoneLength)].SetValue<float>(value); } }
        public Transform PreSkelCompTransform { get { return this[nameof(PreSkelCompTransform)].As<Transform>(); } set { this["PreSkelCompTransform"] = value; } }
        public bool bInitPhysicsSettings { get { return this[nameof(bInitPhysicsSettings)].Flag; } set { this[nameof(bInitPhysicsSettings)].Flag = value; } }
    }
    public class CollisionLimitDataBase : Object
    {
        public CollisionLimitDataBase(nint addr) : base(addr) { }
        public Object DrivingBoneName { get { return this[nameof(DrivingBoneName)]; } set { this[nameof(DrivingBoneName)] = value; } }
        public Vector OffsetLocation { get { return this[nameof(OffsetLocation)].As<Vector>(); } set { this["OffsetLocation"] = value; } }
        public Rotator OffsetRotation { get { return this[nameof(OffsetRotation)].As<Rotator>(); } set { this["OffsetRotation"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
    }
    public class SphericalLimitData : CollisionLimitDataBase
    {
        public SphericalLimitData(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public ESphericalLimitType LimitType { get { return (ESphericalLimitType)this[nameof(LimitType)].GetValue<int>(); } set { this[nameof(LimitType)].SetValue<int>((int)value); } }
    }
    public class CapsuleLimitData : CollisionLimitDataBase
    {
        public CapsuleLimitData(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
    }
    public class PlanarLimitData : CollisionLimitDataBase
    {
        public PlanarLimitData(nint addr) : base(addr) { }
        public Plane Plane { get { return this[nameof(Plane)].As<Plane>(); } set { this["Plane"] = value; } }
    }
}
