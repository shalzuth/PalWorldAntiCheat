using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ControlRigSDK;
namespace SDK.Script.FullBodyIKSDK
{
    public enum EFBIKBoneLimitType : int
    {
        Free = 0,
        Limit = 1,
        Locked = 2,
        EFBIKBoneLimitType_MAX = 3,
    }
    public enum EPoleVectorOption : int
    {
        Direction = 0,
        Location = 1,
        EPoleVectorOption_MAX = 2,
    }
    public class FBIKBoneLimit : Object
    {
        public FBIKBoneLimit(nint addr) : base(addr) { }
        public EFBIKBoneLimitType LimitType_X { get { return (EFBIKBoneLimitType)this[nameof(LimitType_X)].GetValue<int>(); } set { this[nameof(LimitType_X)].SetValue<int>((int)value); } }
        public EFBIKBoneLimitType LimitType_Y { get { return (EFBIKBoneLimitType)this[nameof(LimitType_Y)].GetValue<int>(); } set { this[nameof(LimitType_Y)].SetValue<int>((int)value); } }
        public EFBIKBoneLimitType LimitType_Z { get { return (EFBIKBoneLimitType)this[nameof(LimitType_Z)].GetValue<int>(); } set { this[nameof(LimitType_Z)].SetValue<int>((int)value); } }
        public Vector Limit { get { return this[nameof(Limit)].As<Vector>(); } set { this["Limit"] = value; } }
    }
    public class FBIKConstraintOption : Object
    {
        public FBIKConstraintOption(nint addr) : base(addr) { }
        public RigElementKey Item { get { return this[nameof(Item)].As<RigElementKey>(); } set { this["Item"] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool bUseStiffness { get { return this[nameof(bUseStiffness)].Flag; } set { this[nameof(bUseStiffness)].Flag = value; } }
        public Vector LinearStiffness { get { return this[nameof(LinearStiffness)].As<Vector>(); } set { this["LinearStiffness"] = value; } }
        public Vector AngularStiffness { get { return this[nameof(AngularStiffness)].As<Vector>(); } set { this["AngularStiffness"] = value; } }
        public bool bUseAngularLimit { get { return this[nameof(bUseAngularLimit)].Flag; } set { this[nameof(bUseAngularLimit)].Flag = value; } }
        public FBIKBoneLimit AngularLimit { get { return this[nameof(AngularLimit)].As<FBIKBoneLimit>(); } set { this["AngularLimit"] = value; } }
        public bool bUsePoleVector { get { return this[nameof(bUsePoleVector)].Flag; } set { this[nameof(bUsePoleVector)].Flag = value; } }
        public EPoleVectorOption PoleVectorOption { get { return (EPoleVectorOption)this[nameof(PoleVectorOption)].GetValue<int>(); } set { this[nameof(PoleVectorOption)].SetValue<int>((int)value); } }
        public Vector PoleVector { get { return this[nameof(PoleVector)].As<Vector>(); } set { this["PoleVector"] = value; } }
        public Rotator OffsetRotation { get { return this[nameof(OffsetRotation)].As<Rotator>(); } set { this["OffsetRotation"] = value; } }
    }
    public class MotionProcessInput : Object
    {
        public MotionProcessInput(nint addr) : base(addr) { }
        public bool bForceEffectorRotationTarget { get { return this[nameof(bForceEffectorRotationTarget)].Flag; } set { this[nameof(bForceEffectorRotationTarget)].Flag = value; } }
        public bool bOnlyApplyWhenReachedToTarget { get { return this[nameof(bOnlyApplyWhenReachedToTarget)].Flag; } set { this[nameof(bOnlyApplyWhenReachedToTarget)].Flag = value; } }
    }
    public class FBIKDebugOption : Object
    {
        public FBIKDebugOption(nint addr) : base(addr) { }
        public bool bDrawDebugHierarchy { get { return this[nameof(bDrawDebugHierarchy)].Flag; } set { this[nameof(bDrawDebugHierarchy)].Flag = value; } }
        public bool bColorAngularMotionStrength { get { return this[nameof(bColorAngularMotionStrength)].Flag; } set { this[nameof(bColorAngularMotionStrength)].Flag = value; } }
        public bool bColorLinearMotionStrength { get { return this[nameof(bColorLinearMotionStrength)].Flag; } set { this[nameof(bColorLinearMotionStrength)].Flag = value; } }
        public bool bDrawDebugAxes { get { return this[nameof(bDrawDebugAxes)].Flag; } set { this[nameof(bDrawDebugAxes)].Flag = value; } }
        public bool bDrawDebugEffector { get { return this[nameof(bDrawDebugEffector)].Flag; } set { this[nameof(bDrawDebugEffector)].Flag = value; } }
        public bool bDrawDebugConstraints { get { return this[nameof(bDrawDebugConstraints)].Flag; } set { this[nameof(bDrawDebugConstraints)].Flag = value; } }
        public Transform DrawWorldOffset { get { return this[nameof(DrawWorldOffset)].As<Transform>(); } set { this["DrawWorldOffset"] = value; } }
        public float DrawSize { get { return this[nameof(DrawSize)].GetValue<float>(); } set { this[nameof(DrawSize)].SetValue<float>(value); } }
    }
    public class SolverInput : Object
    {
        public SolverInput(nint addr) : base(addr) { }
        public float LinearMotionStrength { get { return this[nameof(LinearMotionStrength)].GetValue<float>(); } set { this[nameof(LinearMotionStrength)].SetValue<float>(value); } }
        public float MinLinearMotionStrength { get { return this[nameof(MinLinearMotionStrength)].GetValue<float>(); } set { this[nameof(MinLinearMotionStrength)].SetValue<float>(value); } }
        public float AngularMotionStrength { get { return this[nameof(AngularMotionStrength)].GetValue<float>(); } set { this[nameof(AngularMotionStrength)].SetValue<float>(value); } }
        public float MinAngularMotionStrength { get { return this[nameof(MinAngularMotionStrength)].GetValue<float>(); } set { this[nameof(MinAngularMotionStrength)].SetValue<float>(value); } }
        public float DefaultTargetClamp { get { return this[nameof(DefaultTargetClamp)].GetValue<float>(); } set { this[nameof(DefaultTargetClamp)].SetValue<float>(value); } }
        public float Precision { get { return this[nameof(Precision)].GetValue<float>(); } set { this[nameof(Precision)].SetValue<float>(value); } }
        public float Damping { get { return this[nameof(Damping)].GetValue<float>(); } set { this[nameof(Damping)].SetValue<float>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public bool bUseJacobianTranspose { get { return this[nameof(bUseJacobianTranspose)].Flag; } set { this[nameof(bUseJacobianTranspose)].Flag = value; } }
    }
    public class FBIKEndEffector : Object
    {
        public FBIKEndEffector(nint addr) : base(addr) { }
        public RigElementKey Item { get { return this[nameof(Item)].As<RigElementKey>(); } set { this["Item"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public float PositionAlpha { get { return this[nameof(PositionAlpha)].GetValue<float>(); } set { this[nameof(PositionAlpha)].SetValue<float>(value); } }
        public int PositionDepth { get { return this[nameof(PositionDepth)].GetValue<int>(); } set { this[nameof(PositionDepth)].SetValue<int>(value); } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public int RotationDepth { get { return this[nameof(RotationDepth)].GetValue<int>(); } set { this[nameof(RotationDepth)].SetValue<int>(value); } }
        public float Pull { get { return this[nameof(Pull)].GetValue<float>(); } set { this[nameof(Pull)].SetValue<float>(value); } }
    }
    public class RigUnit_FullbodyIK_WorkData : Object
    {
        public RigUnit_FullbodyIK_WorkData(nint addr) : base(addr) { }
    }
    public class RigUnit_FullbodyIK : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_FullbodyIK(nint addr) : base(addr) { }
        public RigElementKey Root { get { return this[nameof(Root)].As<RigElementKey>(); } set { this["Root"] = value; } }
        public Array<FBIKEndEffector> Effectors { get { return new Array<FBIKEndEffector>(this[nameof(Effectors)].Address); } }
        public Array<FBIKConstraintOption> Constraints { get { return new Array<FBIKConstraintOption>(this[nameof(Constraints)].Address); } }
        public SolverInput SolverProperty { get { return this[nameof(SolverProperty)].As<SolverInput>(); } set { this["SolverProperty"] = value; } }
        public MotionProcessInput MotionProperty { get { return this[nameof(MotionProperty)].As<MotionProcessInput>(); } set { this["MotionProperty"] = value; } }
        public bool bPropagateToChildren { get { return this[nameof(bPropagateToChildren)].Flag; } set { this[nameof(bPropagateToChildren)].Flag = value; } }
        public FBIKDebugOption DebugOption { get { return this[nameof(DebugOption)].As<FBIKDebugOption>(); } set { this["DebugOption"] = value; } }
        public RigUnit_FullbodyIK_WorkData WorkData { get { return this[nameof(WorkData)].As<RigUnit_FullbodyIK_WorkData>(); } set { this["WorkData"] = value; } }
    }
}
