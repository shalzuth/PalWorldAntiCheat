using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ControlRigSDK;
namespace SDK.Script.PBIKSDK
{
    public enum EPBIKLimitType : int
    {
        Free = 0,
        Limited = 1,
        Locked = 2,
        EPBIKLimitType_MAX = 3,
    }
    public enum EPBIKRootBehavior : int
    {
        PrePull = 0,
        PinToInput = 1,
        Free = 2,
        EPBIKRootBehavior_MAX = 3,
    }
    public class PBIKBoneSetting : Object
    {
        public PBIKBoneSetting(nint addr) : base(addr) { }
        public Object bone { get { return this[nameof(bone)]; } set { this[nameof(bone)] = value; } }
        public float RotationStiffness { get { return this[nameof(RotationStiffness)].GetValue<float>(); } set { this[nameof(RotationStiffness)].SetValue<float>(value); } }
        public float PositionStiffness { get { return this[nameof(PositionStiffness)].GetValue<float>(); } set { this[nameof(PositionStiffness)].SetValue<float>(value); } }
        public EPBIKLimitType X { get { return (EPBIKLimitType)this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>((int)value); } }
        public float MinX { get { return this[nameof(MinX)].GetValue<float>(); } set { this[nameof(MinX)].SetValue<float>(value); } }
        public float MaxX { get { return this[nameof(MaxX)].GetValue<float>(); } set { this[nameof(MaxX)].SetValue<float>(value); } }
        public EPBIKLimitType Y { get { return (EPBIKLimitType)this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>((int)value); } }
        public float MinY { get { return this[nameof(MinY)].GetValue<float>(); } set { this[nameof(MinY)].SetValue<float>(value); } }
        public float MaxY { get { return this[nameof(MaxY)].GetValue<float>(); } set { this[nameof(MaxY)].SetValue<float>(value); } }
        public EPBIKLimitType Z { get { return (EPBIKLimitType)this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>((int)value); } }
        public float MinZ { get { return this[nameof(MinZ)].GetValue<float>(); } set { this[nameof(MinZ)].SetValue<float>(value); } }
        public float MaxZ { get { return this[nameof(MaxZ)].GetValue<float>(); } set { this[nameof(MaxZ)].SetValue<float>(value); } }
        public bool bUsePreferredAngles { get { return this[nameof(bUsePreferredAngles)].Flag; } set { this[nameof(bUsePreferredAngles)].Flag = value; } }
        public Vector PreferredAngles { get { return this[nameof(PreferredAngles)].As<Vector>(); } set { this["PreferredAngles"] = value; } }
    }
    public class PBIKSolverSettings : Object
    {
        public PBIKSolverSettings(nint addr) : base(addr) { }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public float MassMultiplier { get { return this[nameof(MassMultiplier)].GetValue<float>(); } set { this[nameof(MassMultiplier)].SetValue<float>(value); } }
        public float MinMassMultiplier { get { return this[nameof(MinMassMultiplier)].GetValue<float>(); } set { this[nameof(MinMassMultiplier)].SetValue<float>(value); } }
        public bool bAllowStretch { get { return this[nameof(bAllowStretch)].Flag; } set { this[nameof(bAllowStretch)].Flag = value; } }
        public EPBIKRootBehavior RootBehavior { get { return (EPBIKRootBehavior)this[nameof(RootBehavior)].GetValue<int>(); } set { this[nameof(RootBehavior)].SetValue<int>((int)value); } }
        public bool bStartSolveFromInputPose { get { return this[nameof(bStartSolveFromInputPose)].Flag; } set { this[nameof(bStartSolveFromInputPose)].Flag = value; } }
    }
    public class PBIKSolver : Object
    {
        public PBIKSolver(nint addr) : base(addr) { }
    }
    public class PBIKDebug : Object
    {
        public PBIKDebug(nint addr) : base(addr) { }
        public float DrawScale { get { return this[nameof(DrawScale)].GetValue<float>(); } set { this[nameof(DrawScale)].SetValue<float>(value); } }
        public bool bDrawDebug { get { return this[nameof(bDrawDebug)].Flag; } set { this[nameof(bDrawDebug)].Flag = value; } }
    }
    public class PBIKEffector : Object
    {
        public PBIKEffector(nint addr) : base(addr) { }
        public Object bone { get { return this[nameof(bone)]; } set { this[nameof(bone)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public float PositionAlpha { get { return this[nameof(PositionAlpha)].GetValue<float>(); } set { this[nameof(PositionAlpha)].SetValue<float>(value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public float StrengthAlpha { get { return this[nameof(StrengthAlpha)].GetValue<float>(); } set { this[nameof(StrengthAlpha)].SetValue<float>(value); } }
        public float PullChainAlpha { get { return this[nameof(PullChainAlpha)].GetValue<float>(); } set { this[nameof(PullChainAlpha)].SetValue<float>(value); } }
        public float PinRotation { get { return this[nameof(PinRotation)].GetValue<float>(); } set { this[nameof(PinRotation)].SetValue<float>(value); } }
    }
    public class RigUnit_PBIK : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_PBIK(nint addr) : base(addr) { }
        public Object Root { get { return this[nameof(Root)]; } set { this[nameof(Root)] = value; } }
        public Array<PBIKEffector> Effectors { get { return new Array<PBIKEffector>(this[nameof(Effectors)].Address); } }
        public Array<int> EffectorSolverIndices { get { return new Array<int>(this[nameof(EffectorSolverIndices)].Address); } }
        public Array<PBIKBoneSetting> BoneSettings { get { return new Array<PBIKBoneSetting>(this[nameof(BoneSettings)].Address); } }
        public Array<Object> ExcludedBones { get { return new Array<Object>(this[nameof(ExcludedBones)].Address); } }
        public PBIKSolverSettings Settings { get { return this[nameof(Settings)].As<PBIKSolverSettings>(); } set { this["Settings"] = value; } }
        public PBIKDebug Debug { get { return this[nameof(Debug)].As<PBIKDebug>(); } set { this["Debug"] = value; } }
        public Array<int> BoneSettingToSolverBoneIndex { get { return new Array<int>(this[nameof(BoneSettingToSolverBoneIndex)].Address); } }
        public Array<int> SolverBoneToElementIndex { get { return new Array<int>(this[nameof(SolverBoneToElementIndex)].Address); } }
        public PBIKSolver Solver { get { return this[nameof(Solver)].As<PBIKSolver>(); } set { this["Solver"] = value; } }
        public bool bNeedsInit { get { return this[nameof(bNeedsInit)].Flag; } set { this[nameof(bNeedsInit)].Flag = value; } }
    }
}
