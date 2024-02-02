using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.ClothingSystemRuntimeCommonSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ClothingSystemRuntimeInterfaceSDK;
namespace SDK.Script.ChaosClothSDK
{
    public class ChaosClothConfig : ClothConfigCommon
    {
        public ChaosClothConfig(nint addr) : base(addr) { }
        public EClothMassMode MassMode { get { return (EClothMassMode)this[nameof(MassMode)].GetValue<int>(); } set { this[nameof(MassMode)].SetValue<int>((int)value); } }
        public float UniformMass { get { return this[nameof(UniformMass)].GetValue<float>(); } set { this[nameof(UniformMass)].SetValue<float>(value); } }
        public float TotalMass { get { return this[nameof(TotalMass)].GetValue<float>(); } set { this[nameof(TotalMass)].SetValue<float>(value); } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float MinPerParticleMass { get { return this[nameof(MinPerParticleMass)].GetValue<float>(); } set { this[nameof(MinPerParticleMass)].SetValue<float>(value); } }
        public ChaosClothWeightedValue EdgeStiffnessWeighted { get { return this[nameof(EdgeStiffnessWeighted)].As<ChaosClothWeightedValue>(); } set { this["EdgeStiffnessWeighted"] = value; } }
        public ChaosClothWeightedValue BendingStiffnessWeighted { get { return this[nameof(BendingStiffnessWeighted)].As<ChaosClothWeightedValue>(); } set { this["BendingStiffnessWeighted"] = value; } }
        public bool bUseBendingElements { get { return this[nameof(bUseBendingElements)].Flag; } set { this[nameof(bUseBendingElements)].Flag = value; } }
        public float BucklingRatio { get { return this[nameof(BucklingRatio)].GetValue<float>(); } set { this[nameof(BucklingRatio)].SetValue<float>(value); } }
        public ChaosClothWeightedValue BucklingStiffnessWeighted { get { return this[nameof(BucklingStiffnessWeighted)].As<ChaosClothWeightedValue>(); } set { this["BucklingStiffnessWeighted"] = value; } }
        public ChaosClothWeightedValue AreaStiffnessWeighted { get { return this[nameof(AreaStiffnessWeighted)].As<ChaosClothWeightedValue>(); } set { this["AreaStiffnessWeighted"] = value; } }
        public float VolumeStiffness { get { return this[nameof(VolumeStiffness)].GetValue<float>(); } set { this[nameof(VolumeStiffness)].SetValue<float>(value); } }
        public ChaosClothWeightedValue TetherStiffness { get { return this[nameof(TetherStiffness)].As<ChaosClothWeightedValue>(); } set { this["TetherStiffness"] = value; } }
        public ChaosClothWeightedValue TetherScale { get { return this[nameof(TetherScale)].As<ChaosClothWeightedValue>(); } set { this["TetherScale"] = value; } }
        public bool bUseGeodesicDistance { get { return this[nameof(bUseGeodesicDistance)].Flag; } set { this[nameof(bUseGeodesicDistance)].Flag = value; } }
        public float ShapeTargetStiffness { get { return this[nameof(ShapeTargetStiffness)].GetValue<float>(); } set { this[nameof(ShapeTargetStiffness)].SetValue<float>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public float FrictionCoefficient { get { return this[nameof(FrictionCoefficient)].GetValue<float>(); } set { this[nameof(FrictionCoefficient)].SetValue<float>(value); } }
        public bool bUseCCD { get { return this[nameof(bUseCCD)].Flag; } set { this[nameof(bUseCCD)].Flag = value; } }
        public bool bUseSelfCollisions { get { return this[nameof(bUseSelfCollisions)].Flag; } set { this[nameof(bUseSelfCollisions)].Flag = value; } }
        public float SelfCollisionThickness { get { return this[nameof(SelfCollisionThickness)].GetValue<float>(); } set { this[nameof(SelfCollisionThickness)].SetValue<float>(value); } }
        public float SelfCollisionFriction { get { return this[nameof(SelfCollisionFriction)].GetValue<float>(); } set { this[nameof(SelfCollisionFriction)].SetValue<float>(value); } }
        public bool bUseSelfIntersections { get { return this[nameof(bUseSelfIntersections)].Flag; } set { this[nameof(bUseSelfIntersections)].Flag = value; } }
        public bool bUseLegacyBackstop { get { return this[nameof(bUseLegacyBackstop)].Flag; } set { this[nameof(bUseLegacyBackstop)].Flag = value; } }
        public float DampingCoefficient { get { return this[nameof(DampingCoefficient)].GetValue<float>(); } set { this[nameof(DampingCoefficient)].SetValue<float>(value); } }
        public float LocalDampingCoefficient { get { return this[nameof(LocalDampingCoefficient)].GetValue<float>(); } set { this[nameof(LocalDampingCoefficient)].SetValue<float>(value); } }
        public bool bUsePointBasedWindModel { get { return this[nameof(bUsePointBasedWindModel)].Flag; } set { this[nameof(bUsePointBasedWindModel)].Flag = value; } }
        public ChaosClothWeightedValue Drag { get { return this[nameof(Drag)].As<ChaosClothWeightedValue>(); } set { this["Drag"] = value; } }
        public ChaosClothWeightedValue Lift { get { return this[nameof(Lift)].As<ChaosClothWeightedValue>(); } set { this["Lift"] = value; } }
        public bool bUseGravityOverride { get { return this[nameof(bUseGravityOverride)].Flag; } set { this[nameof(bUseGravityOverride)].Flag = value; } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public Vector Gravity { get { return this[nameof(Gravity)].As<Vector>(); } set { this["Gravity"] = value; } }
        public ChaosClothWeightedValue Pressure { get { return this[nameof(Pressure)].As<ChaosClothWeightedValue>(); } set { this["Pressure"] = value; } }
        public ChaosClothWeightedValue AnimDriveStiffness { get { return this[nameof(AnimDriveStiffness)].As<ChaosClothWeightedValue>(); } set { this["AnimDriveStiffness"] = value; } }
        public ChaosClothWeightedValue AnimDriveDamping { get { return this[nameof(AnimDriveDamping)].As<ChaosClothWeightedValue>(); } set { this["AnimDriveDamping"] = value; } }
        public Vector LinearVelocityScale { get { return this[nameof(LinearVelocityScale)].As<Vector>(); } set { this["LinearVelocityScale"] = value; } }
        public float AngularVelocityScale { get { return this[nameof(AngularVelocityScale)].GetValue<float>(); } set { this[nameof(AngularVelocityScale)].SetValue<float>(value); } }
        public float FictitiousAngularScale { get { return this[nameof(FictitiousAngularScale)].GetValue<float>(); } set { this[nameof(FictitiousAngularScale)].SetValue<float>(value); } }
        public bool bUseTetrahedralConstraints { get { return this[nameof(bUseTetrahedralConstraints)].Flag; } set { this[nameof(bUseTetrahedralConstraints)].Flag = value; } }
        public bool bUseThinShellVolumeConstraints { get { return this[nameof(bUseThinShellVolumeConstraints)].Flag; } set { this[nameof(bUseThinShellVolumeConstraints)].Flag = value; } }
        public bool bUseContinuousCollisionDetection { get { return this[nameof(bUseContinuousCollisionDetection)].Flag; } set { this[nameof(bUseContinuousCollisionDetection)].Flag = value; } }
    }
    public class ChaosClothSharedSimConfig : ClothSharedConfigCommon
    {
        public ChaosClothSharedSimConfig(nint addr) : base(addr) { }
        public int IterationCount { get { return this[nameof(IterationCount)].GetValue<int>(); } set { this[nameof(IterationCount)].SetValue<int>(value); } }
        public int MaxIterationCount { get { return this[nameof(MaxIterationCount)].GetValue<int>(); } set { this[nameof(MaxIterationCount)].SetValue<int>(value); } }
        public int SubdivisionCount { get { return this[nameof(SubdivisionCount)].GetValue<int>(); } set { this[nameof(SubdivisionCount)].SetValue<int>(value); } }
        public bool bUseLocalSpaceSimulation { get { return this[nameof(bUseLocalSpaceSimulation)].Flag; } set { this[nameof(bUseLocalSpaceSimulation)].Flag = value; } }
        public bool bUseXPBDConstraints { get { return this[nameof(bUseXPBDConstraints)].Flag; } set { this[nameof(bUseXPBDConstraints)].Flag = value; } }
    }
    public class ChaosClothingSimulationFactory : ClothingSimulationFactory
    {
        public ChaosClothingSimulationFactory(nint addr) : base(addr) { }
    }
    public class ChaosClothingInteractor : ClothingInteractor
    {
        public ChaosClothingInteractor(nint addr) : base(addr) { }
        public void SetWind(Vector2D Drag, Vector2D Lift, float AirDensity, Vector WindVelocity) { Invoke(nameof(SetWind), Drag, Lift, AirDensity, WindVelocity); }
        public void SetVelocityScale(Vector LinearVelocityScale, float AngularVelocityScale, float FictitiousAngularScale) { Invoke(nameof(SetVelocityScale), LinearVelocityScale, AngularVelocityScale, FictitiousAngularScale); }
        public void SetPressure(Vector2D Pressure) { Invoke(nameof(SetPressure), Pressure); }
        public void SetMaterialLinear(float EdgeStiffness, float BendingStiffness, float AreaStiffness) { Invoke(nameof(SetMaterialLinear), EdgeStiffness, BendingStiffness, AreaStiffness); }
        public void SetMaterial(Vector2D EdgeStiffness, Vector2D BendingStiffness, Vector2D AreaStiffness) { Invoke(nameof(SetMaterial), EdgeStiffness, BendingStiffness, AreaStiffness); }
        public void SetLongRangeAttachmentLinear(float TetherStiffness, float TetherScale) { Invoke(nameof(SetLongRangeAttachmentLinear), TetherStiffness, TetherScale); }
        public void SetLongRangeAttachment(Vector2D TetherStiffness, Vector2D TetherScale) { Invoke(nameof(SetLongRangeAttachment), TetherStiffness, TetherScale); }
        public void SetGravity(float GravityScale, bool bIsGravityOverridden, Vector GravityOverride) { Invoke(nameof(SetGravity), GravityScale, bIsGravityOverridden, GravityOverride); }
        public void SetDamping(float DampingCoefficient, float LocalDampingCoefficient) { Invoke(nameof(SetDamping), DampingCoefficient, LocalDampingCoefficient); }
        public void SetCollision(float CollisionThickness, float FrictionCoefficient, bool bUseCCD, float SelfCollisionThickness) { Invoke(nameof(SetCollision), CollisionThickness, FrictionCoefficient, bUseCCD, SelfCollisionThickness); }
        public void SetBackstop(bool bEnabled) { Invoke(nameof(SetBackstop), bEnabled); }
        public void SetAnimDriveLinear(float AnimDriveStiffness) { Invoke(nameof(SetAnimDriveLinear), AnimDriveStiffness); }
        public void SetAnimDrive(Vector2D AnimDriveStiffness, Vector2D AnimDriveDamping) { Invoke(nameof(SetAnimDrive), AnimDriveStiffness, AnimDriveDamping); }
        public void SetAerodynamics(float DragCoefficient, float LiftCoefficient, Vector WindVelocity) { Invoke(nameof(SetAerodynamics), DragCoefficient, LiftCoefficient, WindVelocity); }
        public void ResetAndTeleport(bool bReset, bool bTeleport) { Invoke(nameof(ResetAndTeleport), bReset, bTeleport); }
    }
    public class ChaosClothingSimulationInteractor : ClothingSimulationInteractor
    {
        public ChaosClothingSimulationInteractor(nint addr) : base(addr) { }
    }
    public enum EChaosWeightMapTarget : int
    {
        None = 0,
        MaxDistance = 1,
        BackstopDistance = 2,
        BackstopRadius = 3,
        AnimDriveStiffness = 4,
        AnimDriveDamping = 5,
        TetherStiffness = 6,
        TetherScale = 7,
        Drag = 8,
        Lift = 9,
        EdgeStiffness = 10,
        BendingStiffness = 11,
        AreaStiffness = 12,
        BucklingStiffness = 13,
        Pressure = 14,
        EChaosWeightMapTarget_MAX = 15,
    }
    public enum EChaosClothTetherMode : int
    {
        FastTetherFastLength = 0,
        AccurateTetherFastLength = 1,
        AccurateTetherAccurateLength = 2,
        MaxChaosClothTetherMode = 3,
        EChaosClothTetherMode_MAX = 4,
    }
    public class ChaosClothWeightedValue : Object
    {
        public ChaosClothWeightedValue(nint addr) : base(addr) { }
        public float Low { get { return this[nameof(Low)].GetValue<float>(); } set { this[nameof(Low)].SetValue<float>(value); } }
        public float High { get { return this[nameof(High)].GetValue<float>(); } set { this[nameof(High)].SetValue<float>(value); } }
    }
}
