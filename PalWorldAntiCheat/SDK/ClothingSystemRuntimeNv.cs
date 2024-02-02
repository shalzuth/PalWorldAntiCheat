using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.ClothingSystemRuntimeCommonSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ClothingSystemRuntimeInterfaceSDK;
namespace SDK.Script.ClothingSystemRuntimeNvSDK
{
    public class ClothConfigNv : ClothConfigCommon
    {
        public ClothConfigNv(nint addr) : base(addr) { }
        public EClothingWindMethodNv ClothingWindMethod { get { return (EClothingWindMethodNv)this[nameof(ClothingWindMethod)].GetValue<int>(); } set { this[nameof(ClothingWindMethod)].SetValue<int>((int)value); } }
        public ClothConstraintSetupNv VerticalConstraint { get { return this[nameof(VerticalConstraint)].As<ClothConstraintSetupNv>(); } set { this["VerticalConstraint"] = value; } }
        public ClothConstraintSetupNv HorizontalConstraint { get { return this[nameof(HorizontalConstraint)].As<ClothConstraintSetupNv>(); } set { this["HorizontalConstraint"] = value; } }
        public ClothConstraintSetupNv BendConstraint { get { return this[nameof(BendConstraint)].As<ClothConstraintSetupNv>(); } set { this["BendConstraint"] = value; } }
        public ClothConstraintSetupNv ShearConstraint { get { return this[nameof(ShearConstraint)].As<ClothConstraintSetupNv>(); } set { this["ShearConstraint"] = value; } }
        public float SelfCollisionRadius { get { return this[nameof(SelfCollisionRadius)].GetValue<float>(); } set { this[nameof(SelfCollisionRadius)].SetValue<float>(value); } }
        public float SelfCollisionStiffness { get { return this[nameof(SelfCollisionStiffness)].GetValue<float>(); } set { this[nameof(SelfCollisionStiffness)].SetValue<float>(value); } }
        public float SelfCollisionCullScale { get { return this[nameof(SelfCollisionCullScale)].GetValue<float>(); } set { this[nameof(SelfCollisionCullScale)].SetValue<float>(value); } }
        public Vector Damping { get { return this[nameof(Damping)].As<Vector>(); } set { this["Damping"] = value; } }
        public float Friction { get { return this[nameof(Friction)].GetValue<float>(); } set { this[nameof(Friction)].SetValue<float>(value); } }
        public float WindDragCoefficient { get { return this[nameof(WindDragCoefficient)].GetValue<float>(); } set { this[nameof(WindDragCoefficient)].SetValue<float>(value); } }
        public float WindLiftCoefficient { get { return this[nameof(WindLiftCoefficient)].GetValue<float>(); } set { this[nameof(WindLiftCoefficient)].SetValue<float>(value); } }
        public Vector LinearDrag { get { return this[nameof(LinearDrag)].As<Vector>(); } set { this["LinearDrag"] = value; } }
        public Vector AngularDrag { get { return this[nameof(AngularDrag)].As<Vector>(); } set { this["AngularDrag"] = value; } }
        public Vector LinearInertiaScale { get { return this[nameof(LinearInertiaScale)].As<Vector>(); } set { this["LinearInertiaScale"] = value; } }
        public Vector AngularInertiaScale { get { return this[nameof(AngularInertiaScale)].As<Vector>(); } set { this["AngularInertiaScale"] = value; } }
        public Vector CentrifugalInertiaScale { get { return this[nameof(CentrifugalInertiaScale)].As<Vector>(); } set { this["CentrifugalInertiaScale"] = value; } }
        public float SolverFrequency { get { return this[nameof(SolverFrequency)].GetValue<float>(); } set { this[nameof(SolverFrequency)].SetValue<float>(value); } }
        public float StiffnessFrequency { get { return this[nameof(StiffnessFrequency)].GetValue<float>(); } set { this[nameof(StiffnessFrequency)].SetValue<float>(value); } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public Vector GravityOverride { get { return this[nameof(GravityOverride)].As<Vector>(); } set { this["GravityOverride"] = value; } }
        public bool bUseGravityOverride { get { return this[nameof(bUseGravityOverride)].Flag; } set { this[nameof(bUseGravityOverride)].Flag = value; } }
        public float TetherStiffness { get { return this[nameof(TetherStiffness)].GetValue<float>(); } set { this[nameof(TetherStiffness)].SetValue<float>(value); } }
        public float TetherLimit { get { return this[nameof(TetherLimit)].GetValue<float>(); } set { this[nameof(TetherLimit)].SetValue<float>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public float AnimDriveSpringStiffness { get { return this[nameof(AnimDriveSpringStiffness)].GetValue<float>(); } set { this[nameof(AnimDriveSpringStiffness)].SetValue<float>(value); } }
        public float AnimDriveDamperStiffness { get { return this[nameof(AnimDriveDamperStiffness)].GetValue<float>(); } set { this[nameof(AnimDriveDamperStiffness)].SetValue<float>(value); } }
        public EClothingWindMethod_Legacy WindMethod { get { return (EClothingWindMethod_Legacy)this[nameof(WindMethod)].GetValue<int>(); } set { this[nameof(WindMethod)].SetValue<int>((int)value); } }
        public ClothConstraintSetup_Legacy VerticalConstraintConfig { get { return this[nameof(VerticalConstraintConfig)].As<ClothConstraintSetup_Legacy>(); } set { this["VerticalConstraintConfig"] = value; } }
        public ClothConstraintSetup_Legacy HorizontalConstraintConfig { get { return this[nameof(HorizontalConstraintConfig)].As<ClothConstraintSetup_Legacy>(); } set { this["HorizontalConstraintConfig"] = value; } }
        public ClothConstraintSetup_Legacy BendConstraintConfig { get { return this[nameof(BendConstraintConfig)].As<ClothConstraintSetup_Legacy>(); } set { this["BendConstraintConfig"] = value; } }
        public ClothConstraintSetup_Legacy ShearConstraintConfig { get { return this[nameof(ShearConstraintConfig)].As<ClothConstraintSetup_Legacy>(); } set { this["ShearConstraintConfig"] = value; } }
    }
    public class ClothingSimulationFactoryNv : ClothingSimulationFactory
    {
        public ClothingSimulationFactoryNv(nint addr) : base(addr) { }
    }
    public class ClothingSimulationInteractorNv : ClothingSimulationInteractor
    {
        public ClothingSimulationInteractorNv(nint addr) : base(addr) { }
        public void SetAnimDriveDamperStiffness(float InStiffness) { Invoke(nameof(SetAnimDriveDamperStiffness), InStiffness); }
    }
    public class ClothPhysicalMeshDataNv_Legacy : ClothPhysicalMeshDataBase_Legacy
    {
        public ClothPhysicalMeshDataNv_Legacy(nint addr) : base(addr) { }
        public Array<float> MaxDistances { get { return new Array<float>(this[nameof(MaxDistances)].Address); } }
        public Array<float> BackstopDistances { get { return new Array<float>(this[nameof(BackstopDistances)].Address); } }
        public Array<float> BackstopRadiuses { get { return new Array<float>(this[nameof(BackstopRadiuses)].Address); } }
        public Array<float> AnimDriveMultipliers { get { return new Array<float>(this[nameof(AnimDriveMultipliers)].Address); } }
    }
    public enum EClothingWindMethodNv : int
    {
        Legacy = 0,
        Accurate = 1,
        EClothingWindMethodNv_MAX = 2,
    }
    public class ClothConstraintSetupNv : Object
    {
        public ClothConstraintSetupNv(nint addr) : base(addr) { }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public float StiffnessMultiplier { get { return this[nameof(StiffnessMultiplier)].GetValue<float>(); } set { this[nameof(StiffnessMultiplier)].SetValue<float>(value); } }
        public float StretchLimit { get { return this[nameof(StretchLimit)].GetValue<float>(); } set { this[nameof(StretchLimit)].SetValue<float>(value); } }
        public float CompressionLimit { get { return this[nameof(CompressionLimit)].GetValue<float>(); } set { this[nameof(CompressionLimit)].SetValue<float>(value); } }
    }
}
