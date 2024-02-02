using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.PBIKSDK;
namespace SDK.Script.IKRigSDK
{
    public class IKGoalCreatorInterface : Interface
    {
        public IKGoalCreatorInterface(nint addr) : base(addr) { }
        public void AddIKGoals(Object OutGoals) { Invoke(nameof(AddIKGoals), OutGoals); }
    }
    public class IKRigComponent : ActorComponent
    {
        public IKRigComponent(nint addr) : base(addr) { }
        public void SetIKRigGoalTransform(Object GoalName, Transform Transform, float PositionAlpha, float RotationAlpha) { Invoke(nameof(SetIKRigGoalTransform), GoalName, Transform, PositionAlpha, RotationAlpha); }
        public void SetIKRigGoalPositionAndRotation(Object GoalName, Vector Position, Quat Rotation, float PositionAlpha, float RotationAlpha) { Invoke(nameof(SetIKRigGoalPositionAndRotation), GoalName, Position, Rotation, PositionAlpha, RotationAlpha); }
        public void SetIKRigGoal(IKRigGoal Goal) { Invoke(nameof(SetIKRigGoal), Goal); }
        public void ClearAllGoals() { Invoke(nameof(ClearAllGoals)); }
    }
    public class IKRigEffectorGoal : Object
    {
        public IKRigEffectorGoal(nint addr) : base(addr) { }
        public Object GoalName { get { return this[nameof(GoalName)]; } set { this[nameof(GoalName)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public float PositionAlpha { get { return this[nameof(PositionAlpha)].GetValue<float>(); } set { this[nameof(PositionAlpha)].SetValue<float>(value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public Transform CurrentTransform { get { return this[nameof(CurrentTransform)].As<Transform>(); } set { this["CurrentTransform"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class IKRigDefinition : Object
    {
        public IKRigDefinition(nint addr) : base(addr) { }
        public Object PreviewSkeletalMesh { get { return this[nameof(PreviewSkeletalMesh)]; } set { this[nameof(PreviewSkeletalMesh)] = value; } }
        public IKRigSkeleton Skeleton { get { return this[nameof(Skeleton)].As<IKRigSkeleton>(); } set { this["Skeleton"] = value; } }
        public Array<IKRigEffectorGoal> Goals { get { return new Array<IKRigEffectorGoal>(this[nameof(Goals)].Address); } }
        public Array<IKRigSolver> Solvers { get { return new Array<IKRigSolver>(this[nameof(Solvers)].Address); } }
        public RetargetDefinition RetargetDefinition { get { return this[nameof(RetargetDefinition)].As<RetargetDefinition>(); } set { this["RetargetDefinition"] = value; } }
    }
    public class IKRigProcessor : Object
    {
        public IKRigProcessor(nint addr) : base(addr) { }
        public Array<IKRigSolver> Solvers { get { return new Array<IKRigSolver>(this[nameof(Solvers)].Address); } }
    }
    public class IKRigSolver : Object
    {
        public IKRigSolver(nint addr) : base(addr) { }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
    }
    public class RetargetChainSettings : Object
    {
        public RetargetChainSettings(nint addr) : base(addr) { }
        public Object SourceChain { get { return this[nameof(SourceChain)]; } set { this[nameof(SourceChain)] = value; } }
        public Object TargetChain { get { return this[nameof(TargetChain)]; } set { this[nameof(TargetChain)] = value; } }
        public TargetChainSettings Settings { get { return this[nameof(Settings)].As<TargetChainSettings>(); } set { this["Settings"] = value; } }
        public bool CopyPoseUsingFK { get { return this[nameof(CopyPoseUsingFK)].Flag; } set { this[nameof(CopyPoseUsingFK)].Flag = value; } }
        public ERetargetRotationMode RotationMode { get { return (ERetargetRotationMode)this[nameof(RotationMode)].GetValue<int>(); } set { this[nameof(RotationMode)].SetValue<int>((int)value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public ERetargetTranslationMode TranslationMode { get { return (ERetargetTranslationMode)this[nameof(TranslationMode)].GetValue<int>(); } set { this[nameof(TranslationMode)].SetValue<int>((int)value); } }
        public float TranslationAlpha { get { return this[nameof(TranslationAlpha)].GetValue<float>(); } set { this[nameof(TranslationAlpha)].SetValue<float>(value); } }
        public bool DriveIKGoal { get { return this[nameof(DriveIKGoal)].Flag; } set { this[nameof(DriveIKGoal)].Flag = value; } }
        public float BlendToSource { get { return this[nameof(BlendToSource)].GetValue<float>(); } set { this[nameof(BlendToSource)].SetValue<float>(value); } }
        public Vector BlendToSourceWeights { get { return this[nameof(BlendToSourceWeights)].As<Vector>(); } set { this["BlendToSourceWeights"] = value; } }
        public Vector StaticOffset { get { return this[nameof(StaticOffset)].As<Vector>(); } set { this["StaticOffset"] = value; } }
        public Vector StaticLocalOffset { get { return this[nameof(StaticLocalOffset)].As<Vector>(); } set { this["StaticLocalOffset"] = value; } }
        public Rotator StaticRotationOffset { get { return this[nameof(StaticRotationOffset)].As<Rotator>(); } set { this["StaticRotationOffset"] = value; } }
        public float Extension { get { return this[nameof(Extension)].GetValue<float>(); } set { this[nameof(Extension)].SetValue<float>(value); } }
        public bool UseSpeedCurveToPlantIK { get { return this[nameof(UseSpeedCurveToPlantIK)].Flag; } set { this[nameof(UseSpeedCurveToPlantIK)].Flag = value; } }
        public Object SpeedCurveName { get { return this[nameof(SpeedCurveName)]; } set { this[nameof(SpeedCurveName)] = value; } }
        public float VelocityThreshold { get { return this[nameof(VelocityThreshold)].GetValue<float>(); } set { this[nameof(VelocityThreshold)].SetValue<float>(value); } }
        public float UnplantStiffness { get { return this[nameof(UnplantStiffness)].GetValue<float>(); } set { this[nameof(UnplantStiffness)].SetValue<float>(value); } }
        public float UnplantCriticalDamping { get { return this[nameof(UnplantCriticalDamping)].GetValue<float>(); } set { this[nameof(UnplantCriticalDamping)].SetValue<float>(value); } }
    }
    public class RetargetRootSettings : Object
    {
        public RetargetRootSettings(nint addr) : base(addr) { }
        public TargetRootSettings Settings { get { return this[nameof(Settings)].As<TargetRootSettings>(); } set { this["Settings"] = value; } }
        public bool RetargetRootTranslation { get { return this[nameof(RetargetRootTranslation)].Flag; } set { this[nameof(RetargetRootTranslation)].Flag = value; } }
        public float GlobalScaleHorizontal { get { return this[nameof(GlobalScaleHorizontal)].GetValue<float>(); } set { this[nameof(GlobalScaleHorizontal)].SetValue<float>(value); } }
        public float GlobalScaleVertical { get { return this[nameof(GlobalScaleVertical)].GetValue<float>(); } set { this[nameof(GlobalScaleVertical)].SetValue<float>(value); } }
        public Vector BlendToSource { get { return this[nameof(BlendToSource)].As<Vector>(); } set { this["BlendToSource"] = value; } }
        public Vector StaticOffset { get { return this[nameof(StaticOffset)].As<Vector>(); } set { this["StaticOffset"] = value; } }
        public Rotator StaticRotationOffset { get { return this[nameof(StaticRotationOffset)].As<Rotator>(); } set { this["StaticRotationOffset"] = value; } }
    }
    public class IKRetargetGlobalSettings : Object
    {
        public IKRetargetGlobalSettings(nint addr) : base(addr) { }
        public RetargetGlobalSettings Settings { get { return this[nameof(Settings)].As<RetargetGlobalSettings>(); } set { this["Settings"] = value; } }
    }
    public class IKRetargeter : Object
    {
        public IKRetargeter(nint addr) : base(addr) { }
        public Object SourceIKRigAsset { get { return this[nameof(SourceIKRigAsset)]; } set { this[nameof(SourceIKRigAsset)] = value; } }
        public Object TargetIKRigAsset { get { return this[nameof(TargetIKRigAsset)]; } set { this[nameof(TargetIKRigAsset)] = value; } }
        public Array<RetargetChainMap> ChainMapping { get { return new Array<RetargetChainMap>(this[nameof(ChainMapping)].Address); } }
        public Array<RetargetChainSettings> ChainSettings { get { return new Array<RetargetChainSettings>(this[nameof(ChainSettings)].Address); } }
        public RetargetRootSettings RootSettings { get { return this[nameof(RootSettings)].As<RetargetRootSettings>(); } set { this["RootSettings"] = value; } }
        public IKRetargetGlobalSettings GlobalSettings { get { return this[nameof(GlobalSettings)].As<IKRetargetGlobalSettings>(); } set { this["GlobalSettings"] = value; } }
        public Object Profiles { get { return this[nameof(Profiles)]; } set { this[nameof(Profiles)] = value; } }
        public Object CurrentProfile { get { return this[nameof(CurrentProfile)]; } set { this[nameof(CurrentProfile)] = value; } }
        public Object SourceRetargetPoses { get { return this[nameof(SourceRetargetPoses)]; } set { this[nameof(SourceRetargetPoses)] = value; } }
        public Object TargetRetargetPoses { get { return this[nameof(TargetRetargetPoses)]; } set { this[nameof(TargetRetargetPoses)] = value; } }
        public Object CurrentSourceRetargetPose { get { return this[nameof(CurrentSourceRetargetPose)]; } set { this[nameof(CurrentSourceRetargetPose)] = value; } }
        public Object CurrentTargetRetargetPose { get { return this[nameof(CurrentTargetRetargetPose)]; } set { this[nameof(CurrentTargetRetargetPose)] = value; } }
        public Object RetargetPoses { get { return this[nameof(RetargetPoses)]; } set { this[nameof(RetargetPoses)] = value; } }
        public Object CurrentRetargetPose { get { return this[nameof(CurrentRetargetPose)]; } set { this[nameof(CurrentRetargetPose)] = value; } }
        public void SetRootSettingsInRetargetProfile(RetargetProfile RetargetProfile, TargetRootSettings RootSettings) { Invoke(nameof(SetRootSettingsInRetargetProfile), RetargetProfile, RootSettings); }
        public void SetGlobalSettingsInRetargetProfile(RetargetProfile RetargetProfile, RetargetGlobalSettings GlobalSettings) { Invoke(nameof(SetGlobalSettingsInRetargetProfile), RetargetProfile, GlobalSettings); }
        public void SetChainSpeedPlantSettingsInRetargetProfile(RetargetProfile RetargetProfile, TargetChainSpeedPlantSettings SpeedPlantSettings, Object TargetChainName) { Invoke(nameof(SetChainSpeedPlantSettingsInRetargetProfile), RetargetProfile, SpeedPlantSettings, TargetChainName); }
        public void SetChainSettingsInRetargetProfile(RetargetProfile RetargetProfile, TargetChainSettings ChainSettings, Object TargetChainName) { Invoke(nameof(SetChainSettingsInRetargetProfile), RetargetProfile, ChainSettings, TargetChainName); }
        public void SetChainIKSettingsInRetargetProfile(RetargetProfile RetargetProfile, TargetChainIKSettings IKSettings, Object TargetChainName) { Invoke(nameof(SetChainIKSettingsInRetargetProfile), RetargetProfile, IKSettings, TargetChainName); }
        public void SetChainFKSettingsInRetargetProfile(RetargetProfile RetargetProfile, TargetChainFKSettings FKSettings, Object TargetChainName) { Invoke(nameof(SetChainFKSettingsInRetargetProfile), RetargetProfile, FKSettings, TargetChainName); }
        public TargetRootSettings GetRootSettingsFromRetargetProfile(RetargetProfile RetargetProfile) { return Invoke<TargetRootSettings>(nameof(GetRootSettingsFromRetargetProfile), RetargetProfile); }
        public void GetRootSettingsFromRetargetAsset(IKRetargeter RetargetAsset, Object OptionalProfileName, TargetRootSettings OutSettings) { Invoke(nameof(GetRootSettingsFromRetargetAsset), RetargetAsset, OptionalProfileName, OutSettings); }
        public RetargetGlobalSettings GetGlobalSettingsFromRetargetProfile(RetargetProfile RetargetProfile) { return Invoke<RetargetGlobalSettings>(nameof(GetGlobalSettingsFromRetargetProfile), RetargetProfile); }
        public void GetGlobalSettingsFromRetargetAsset(IKRetargeter RetargetAsset, Object OptionalProfileName, RetargetGlobalSettings OutSettings) { Invoke(nameof(GetGlobalSettingsFromRetargetAsset), RetargetAsset, OptionalProfileName, OutSettings); }
        public TargetChainSettings GetChainUsingGoalFromRetargetAsset(IKRetargeter RetargetAsset, Object IKGoalName) { return Invoke<TargetChainSettings>(nameof(GetChainUsingGoalFromRetargetAsset), RetargetAsset, IKGoalName); }
        public TargetChainSettings GetChainSettingsFromRetargetProfile(RetargetProfile RetargetProfile, Object TargetChainName) { return Invoke<TargetChainSettings>(nameof(GetChainSettingsFromRetargetProfile), RetargetProfile, TargetChainName); }
        public TargetChainSettings GetChainSettingsFromRetargetAsset(IKRetargeter RetargetAsset, Object TargetChainName, Object OptionalProfileName) { return Invoke<TargetChainSettings>(nameof(GetChainSettingsFromRetargetAsset), RetargetAsset, TargetChainName, OptionalProfileName); }
    }
    public class IKRetargetProcessor : Object
    {
        public IKRetargetProcessor(nint addr) : base(addr) { }
        public IKRigProcessor IKRigProcessor { get { return this[nameof(IKRigProcessor)].As<IKRigProcessor>(); } set { this["IKRigProcessor"] = value; } }
    }
    public class IKRig_BodyMoverEffector : Object
    {
        public IKRig_BodyMoverEffector(nint addr) : base(addr) { }
        public Object GoalName { get { return this[nameof(GoalName)]; } set { this[nameof(GoalName)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public float InfluenceMultiplier { get { return this[nameof(InfluenceMultiplier)].GetValue<float>(); } set { this[nameof(InfluenceMultiplier)].SetValue<float>(value); } }
    }
    public class IKRig_BodyMover : IKRigSolver
    {
        public IKRig_BodyMover(nint addr) : base(addr) { }
        public Object RootBone { get { return this[nameof(RootBone)]; } set { this[nameof(RootBone)] = value; } }
        public float PositionAlpha { get { return this[nameof(PositionAlpha)].GetValue<float>(); } set { this[nameof(PositionAlpha)].SetValue<float>(value); } }
        public float PositionPositiveX { get { return this[nameof(PositionPositiveX)].GetValue<float>(); } set { this[nameof(PositionPositiveX)].SetValue<float>(value); } }
        public float PositionNegativeX { get { return this[nameof(PositionNegativeX)].GetValue<float>(); } set { this[nameof(PositionNegativeX)].SetValue<float>(value); } }
        public float PositionPositiveY { get { return this[nameof(PositionPositiveY)].GetValue<float>(); } set { this[nameof(PositionPositiveY)].SetValue<float>(value); } }
        public float PositionNegativeY { get { return this[nameof(PositionNegativeY)].GetValue<float>(); } set { this[nameof(PositionNegativeY)].SetValue<float>(value); } }
        public float PositionPositiveZ { get { return this[nameof(PositionPositiveZ)].GetValue<float>(); } set { this[nameof(PositionPositiveZ)].SetValue<float>(value); } }
        public float PositionNegativeZ { get { return this[nameof(PositionNegativeZ)].GetValue<float>(); } set { this[nameof(PositionNegativeZ)].SetValue<float>(value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public float RotateXAlpha { get { return this[nameof(RotateXAlpha)].GetValue<float>(); } set { this[nameof(RotateXAlpha)].SetValue<float>(value); } }
        public float RotateYAlpha { get { return this[nameof(RotateYAlpha)].GetValue<float>(); } set { this[nameof(RotateYAlpha)].SetValue<float>(value); } }
        public float RotateZAlpha { get { return this[nameof(RotateZAlpha)].GetValue<float>(); } set { this[nameof(RotateZAlpha)].SetValue<float>(value); } }
        public Array<IKRig_BodyMoverEffector> Effectors { get { return new Array<IKRig_BodyMoverEffector>(this[nameof(Effectors)].Address); } }
    }
    public class IKRig_LimbEffector : Object
    {
        public IKRig_LimbEffector(nint addr) : base(addr) { }
        public Object GoalName { get { return this[nameof(GoalName)]; } set { this[nameof(GoalName)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
    }
    public class IKRig_LimbSolver : IKRigSolver
    {
        public IKRig_LimbSolver(nint addr) : base(addr) { }
        public Object RootName { get { return this[nameof(RootName)]; } set { this[nameof(RootName)] = value; } }
        public float ReachPrecision { get { return this[nameof(ReachPrecision)].GetValue<float>(); } set { this[nameof(ReachPrecision)].SetValue<float>(value); } }
        public byte HingeRotationAxis { get { return this[nameof(HingeRotationAxis)].GetValue<byte>(); } set { this[nameof(HingeRotationAxis)].SetValue<byte>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public bool bEnableLimit { get { return this[nameof(bEnableLimit)].Flag; } set { this[nameof(bEnableLimit)].Flag = value; } }
        public float MinRotationAngle { get { return this[nameof(MinRotationAngle)].GetValue<float>(); } set { this[nameof(MinRotationAngle)].SetValue<float>(value); } }
        public bool bAveragePull { get { return this[nameof(bAveragePull)].Flag; } set { this[nameof(bAveragePull)].Flag = value; } }
        public float PullDistribution { get { return this[nameof(PullDistribution)].GetValue<float>(); } set { this[nameof(PullDistribution)].SetValue<float>(value); } }
        public float ReachStepAlpha { get { return this[nameof(ReachStepAlpha)].GetValue<float>(); } set { this[nameof(ReachStepAlpha)].SetValue<float>(value); } }
        public bool bEnableTwistCorrection { get { return this[nameof(bEnableTwistCorrection)].Flag; } set { this[nameof(bEnableTwistCorrection)].Flag = value; } }
        public byte EndBoneForwardAxis { get { return this[nameof(EndBoneForwardAxis)].GetValue<byte>(); } set { this[nameof(EndBoneForwardAxis)].SetValue<byte>(value); } }
        public IKRig_LimbEffector Effector { get { return this[nameof(Effector)].As<IKRig_LimbEffector>(); } set { this["Effector"] = value; } }
    }
    public class IKRig_FBIKEffector : Object
    {
        public IKRig_FBIKEffector(nint addr) : base(addr) { }
        public Object GoalName { get { return this[nameof(GoalName)]; } set { this[nameof(GoalName)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public float StrengthAlpha { get { return this[nameof(StrengthAlpha)].GetValue<float>(); } set { this[nameof(StrengthAlpha)].SetValue<float>(value); } }
        public float PullChainAlpha { get { return this[nameof(PullChainAlpha)].GetValue<float>(); } set { this[nameof(PullChainAlpha)].SetValue<float>(value); } }
        public float PinRotation { get { return this[nameof(PinRotation)].GetValue<float>(); } set { this[nameof(PinRotation)].SetValue<float>(value); } }
        public int IndexInSolver { get { return this[nameof(IndexInSolver)].GetValue<int>(); } set { this[nameof(IndexInSolver)].SetValue<int>(value); } }
    }
    public class IKRig_PBIKBoneSettings : Object
    {
        public IKRig_PBIKBoneSettings(nint addr) : base(addr) { }
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
    public class IKRigPBIKSolver : IKRigSolver
    {
        public IKRigPBIKSolver(nint addr) : base(addr) { }
        public Object RootBone { get { return this[nameof(RootBone)]; } set { this[nameof(RootBone)] = value; } }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public float MassMultiplier { get { return this[nameof(MassMultiplier)].GetValue<float>(); } set { this[nameof(MassMultiplier)].SetValue<float>(value); } }
        public float MinMassMultiplier { get { return this[nameof(MinMassMultiplier)].GetValue<float>(); } set { this[nameof(MinMassMultiplier)].SetValue<float>(value); } }
        public bool bAllowStretch { get { return this[nameof(bAllowStretch)].Flag; } set { this[nameof(bAllowStretch)].Flag = value; } }
        public EPBIKRootBehavior RootBehavior { get { return (EPBIKRootBehavior)this[nameof(RootBehavior)].GetValue<int>(); } set { this[nameof(RootBehavior)].SetValue<int>((int)value); } }
        public bool bStartSolveFromInputPose { get { return this[nameof(bStartSolveFromInputPose)].Flag; } set { this[nameof(bStartSolveFromInputPose)].Flag = value; } }
        public Array<IKRig_FBIKEffector> Effectors { get { return new Array<IKRig_FBIKEffector>(this[nameof(Effectors)].Address); } }
        public Array<IKRig_PBIKBoneSettings> BoneSettings { get { return new Array<IKRig_PBIKBoneSettings>(this[nameof(BoneSettings)].Address); } }
    }
    public class IKRig_PoleSolverEffector : Object
    {
        public IKRig_PoleSolverEffector(nint addr) : base(addr) { }
        public Object GoalName { get { return this[nameof(GoalName)]; } set { this[nameof(GoalName)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
    }
    public class IKRig_PoleSolver : IKRigSolver
    {
        public IKRig_PoleSolver(nint addr) : base(addr) { }
        public Object RootName { get { return this[nameof(RootName)]; } set { this[nameof(RootName)] = value; } }
        public Object EndName { get { return this[nameof(EndName)]; } set { this[nameof(EndName)] = value; } }
        public IKRig_PoleSolverEffector Effector { get { return this[nameof(Effector)].As<IKRig_PoleSolverEffector>(); } set { this["Effector"] = value; } }
    }
    public class IKRig_SetTransformEffector : Object
    {
        public IKRig_SetTransformEffector(nint addr) : base(addr) { }
        public bool bEnablePosition { get { return this[nameof(bEnablePosition)].Flag; } set { this[nameof(bEnablePosition)].Flag = value; } }
        public bool bEnableRotation { get { return this[nameof(bEnableRotation)].Flag; } set { this[nameof(bEnableRotation)].Flag = value; } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
    }
    public class IKRig_SetTransform : IKRigSolver
    {
        public IKRig_SetTransform(nint addr) : base(addr) { }
        public Object Goal { get { return this[nameof(Goal)]; } set { this[nameof(Goal)] = value; } }
        public Object RootBone { get { return this[nameof(RootBone)]; } set { this[nameof(RootBone)] = value; } }
        public IKRig_SetTransformEffector Effector { get { return this[nameof(Effector)].As<IKRig_SetTransformEffector>(); } set { this["Effector"] = value; } }
    }
    public enum ERetargetTranslationMode : int
    {
        None = 0,
        GloballyScaled = 1,
        Absolute = 2,
        ERetargetTranslationMode_MAX = 3,
    }
    public enum ERetargetRotationMode : int
    {
        Interpolated = 0,
        OneToOne = 1,
        OneToOneReversed = 2,
        None = 3,
        ERetargetRotationMode_MAX = 4,
    }
    public enum EBasicAxis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        NegX = 3,
        NegY = 4,
        NegZ = 5,
        EBasicAxis_MAX = 6,
    }
    public enum EWarpingDirectionSource : int
    {
        Goals = 0,
        Chain = 1,
        EWarpingDirectionSource_MAX = 2,
    }
    public enum EIKRigGoalSpace : int
    {
        Component = 0,
        Additive = 1,
        World = 2,
        EIKRigGoalSpace_MAX = 3,
    }
    public enum EIKRigGoalTransformSource : int
    {
        Manual = 0,
        Bone = 1,
        ActorComponent = 2,
        EIKRigGoalTransformSource_MAX = 3,
    }
    public class RetargetProfile : Object
    {
        public RetargetProfile(nint addr) : base(addr) { }
        public bool bApplyTargetRetargetPose { get { return this[nameof(bApplyTargetRetargetPose)].Flag; } set { this[nameof(bApplyTargetRetargetPose)].Flag = value; } }
        public Object TargetRetargetPoseName { get { return this[nameof(TargetRetargetPoseName)]; } set { this[nameof(TargetRetargetPoseName)] = value; } }
        public bool bApplySourceRetargetPose { get { return this[nameof(bApplySourceRetargetPose)].Flag; } set { this[nameof(bApplySourceRetargetPose)].Flag = value; } }
        public Object SourceRetargetPoseName { get { return this[nameof(SourceRetargetPoseName)]; } set { this[nameof(SourceRetargetPoseName)] = value; } }
        public bool bApplyChainSettings { get { return this[nameof(bApplyChainSettings)].Flag; } set { this[nameof(bApplyChainSettings)].Flag = value; } }
        public Object ChainSettings { get { return this[nameof(ChainSettings)]; } set { this[nameof(ChainSettings)] = value; } }
        public bool bApplyRootSettings { get { return this[nameof(bApplyRootSettings)].Flag; } set { this[nameof(bApplyRootSettings)].Flag = value; } }
        public TargetRootSettings RootSettings { get { return this[nameof(RootSettings)].As<TargetRootSettings>(); } set { this["RootSettings"] = value; } }
        public bool bApplyGlobalSettings { get { return this[nameof(bApplyGlobalSettings)].Flag; } set { this[nameof(bApplyGlobalSettings)].Flag = value; } }
        public RetargetGlobalSettings GlobalSettings { get { return this[nameof(GlobalSettings)].As<RetargetGlobalSettings>(); } set { this["GlobalSettings"] = value; } }
    }
    public class RetargetGlobalSettings : Object
    {
        public RetargetGlobalSettings(nint addr) : base(addr) { }
        public bool bEnableRoot { get { return this[nameof(bEnableRoot)].Flag; } set { this[nameof(bEnableRoot)].Flag = value; } }
        public bool bEnableFK { get { return this[nameof(bEnableFK)].Flag; } set { this[nameof(bEnableFK)].Flag = value; } }
        public bool bEnableIK { get { return this[nameof(bEnableIK)].Flag; } set { this[nameof(bEnableIK)].Flag = value; } }
        public bool bWarping { get { return this[nameof(bWarping)].Flag; } set { this[nameof(bWarping)].Flag = value; } }
        public EWarpingDirectionSource DirectionSource { get { return (EWarpingDirectionSource)this[nameof(DirectionSource)].GetValue<int>(); } set { this[nameof(DirectionSource)].SetValue<int>((int)value); } }
        public EBasicAxis ForwardDirection { get { return (EBasicAxis)this[nameof(ForwardDirection)].GetValue<int>(); } set { this[nameof(ForwardDirection)].SetValue<int>((int)value); } }
        public Object DirectionChain { get { return this[nameof(DirectionChain)]; } set { this[nameof(DirectionChain)] = value; } }
        public float WarpForwards { get { return this[nameof(WarpForwards)].GetValue<float>(); } set { this[nameof(WarpForwards)].SetValue<float>(value); } }
        public float SidewaysOffset { get { return this[nameof(SidewaysOffset)].GetValue<float>(); } set { this[nameof(SidewaysOffset)].SetValue<float>(value); } }
        public float WarpSplay { get { return this[nameof(WarpSplay)].GetValue<float>(); } set { this[nameof(WarpSplay)].SetValue<float>(value); } }
    }
    public class TargetRootSettings : Object
    {
        public TargetRootSettings(nint addr) : base(addr) { }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public float TranslationAlpha { get { return this[nameof(TranslationAlpha)].GetValue<float>(); } set { this[nameof(TranslationAlpha)].SetValue<float>(value); } }
        public float BlendToSource { get { return this[nameof(BlendToSource)].GetValue<float>(); } set { this[nameof(BlendToSource)].SetValue<float>(value); } }
        public Vector BlendToSourceWeights { get { return this[nameof(BlendToSourceWeights)].As<Vector>(); } set { this["BlendToSourceWeights"] = value; } }
        public float ScaleHorizontal { get { return this[nameof(ScaleHorizontal)].GetValue<float>(); } set { this[nameof(ScaleHorizontal)].SetValue<float>(value); } }
        public float ScaleVertical { get { return this[nameof(ScaleVertical)].GetValue<float>(); } set { this[nameof(ScaleVertical)].SetValue<float>(value); } }
        public Vector TranslationOffset { get { return this[nameof(TranslationOffset)].As<Vector>(); } set { this["TranslationOffset"] = value; } }
        public Rotator RotationOffset { get { return this[nameof(RotationOffset)].As<Rotator>(); } set { this["RotationOffset"] = value; } }
        public float AffectIKHorizontal { get { return this[nameof(AffectIKHorizontal)].GetValue<float>(); } set { this[nameof(AffectIKHorizontal)].SetValue<float>(value); } }
        public float AffectIKVertical { get { return this[nameof(AffectIKVertical)].GetValue<float>(); } set { this[nameof(AffectIKVertical)].SetValue<float>(value); } }
    }
    public class TargetChainSettings : Object
    {
        public TargetChainSettings(nint addr) : base(addr) { }
        public TargetChainFKSettings FK { get { return this[nameof(FK)].As<TargetChainFKSettings>(); } set { this["FK"] = value; } }
        public TargetChainIKSettings IK { get { return this[nameof(IK)].As<TargetChainIKSettings>(); } set { this["IK"] = value; } }
        public TargetChainSpeedPlantSettings SpeedPlanting { get { return this[nameof(SpeedPlanting)].As<TargetChainSpeedPlantSettings>(); } set { this["SpeedPlanting"] = value; } }
    }
    public class TargetChainSpeedPlantSettings : Object
    {
        public TargetChainSpeedPlantSettings(nint addr) : base(addr) { }
        public bool EnableSpeedPlanting { get { return this[nameof(EnableSpeedPlanting)].Flag; } set { this[nameof(EnableSpeedPlanting)].Flag = value; } }
        public Object SpeedCurveName { get { return this[nameof(SpeedCurveName)]; } set { this[nameof(SpeedCurveName)] = value; } }
        public float SpeedThreshold { get { return this[nameof(SpeedThreshold)].GetValue<float>(); } set { this[nameof(SpeedThreshold)].SetValue<float>(value); } }
        public float UnplantStiffness { get { return this[nameof(UnplantStiffness)].GetValue<float>(); } set { this[nameof(UnplantStiffness)].SetValue<float>(value); } }
        public float UnplantCriticalDamping { get { return this[nameof(UnplantCriticalDamping)].GetValue<float>(); } set { this[nameof(UnplantCriticalDamping)].SetValue<float>(value); } }
    }
    public class TargetChainIKSettings : Object
    {
        public TargetChainIKSettings(nint addr) : base(addr) { }
        public bool EnableIK { get { return this[nameof(EnableIK)].Flag; } set { this[nameof(EnableIK)].Flag = value; } }
        public float BlendToSource { get { return this[nameof(BlendToSource)].GetValue<float>(); } set { this[nameof(BlendToSource)].SetValue<float>(value); } }
        public Vector BlendToSourceWeights { get { return this[nameof(BlendToSourceWeights)].As<Vector>(); } set { this["BlendToSourceWeights"] = value; } }
        public Vector StaticOffset { get { return this[nameof(StaticOffset)].As<Vector>(); } set { this["StaticOffset"] = value; } }
        public Vector StaticLocalOffset { get { return this[nameof(StaticLocalOffset)].As<Vector>(); } set { this["StaticLocalOffset"] = value; } }
        public Rotator StaticRotationOffset { get { return this[nameof(StaticRotationOffset)].As<Rotator>(); } set { this["StaticRotationOffset"] = value; } }
        public float Extension { get { return this[nameof(Extension)].GetValue<float>(); } set { this[nameof(Extension)].SetValue<float>(value); } }
        public bool bAffectedByIKWarping { get { return this[nameof(bAffectedByIKWarping)].Flag; } set { this[nameof(bAffectedByIKWarping)].Flag = value; } }
    }
    public class TargetChainFKSettings : Object
    {
        public TargetChainFKSettings(nint addr) : base(addr) { }
        public bool EnableFK { get { return this[nameof(EnableFK)].Flag; } set { this[nameof(EnableFK)].Flag = value; } }
        public ERetargetRotationMode RotationMode { get { return (ERetargetRotationMode)this[nameof(RotationMode)].GetValue<int>(); } set { this[nameof(RotationMode)].SetValue<int>((int)value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public ERetargetTranslationMode TranslationMode { get { return (ERetargetTranslationMode)this[nameof(TranslationMode)].GetValue<int>(); } set { this[nameof(TranslationMode)].SetValue<int>((int)value); } }
        public float TranslationAlpha { get { return this[nameof(TranslationAlpha)].GetValue<float>(); } set { this[nameof(TranslationAlpha)].SetValue<float>(value); } }
        public float PoleVectorMatching { get { return this[nameof(PoleVectorMatching)].GetValue<float>(); } set { this[nameof(PoleVectorMatching)].SetValue<float>(value); } }
        public float PoleVectorOffset { get { return this[nameof(PoleVectorOffset)].GetValue<float>(); } set { this[nameof(PoleVectorOffset)].SetValue<float>(value); } }
    }
    public class AnimNode_IKRig : AnimNode_CustomProperty
    {
        public AnimNode_IKRig(nint addr) : base(addr) { }
        public PoseLink Source { get { return this[nameof(Source)].As<PoseLink>(); } set { this["Source"] = value; } }
        public IKRigDefinition RigDefinitionAsset { get { return this[nameof(RigDefinitionAsset)].As<IKRigDefinition>(); } set { this["RigDefinitionAsset"] = value; } }
        public Array<IKRigGoal> Goals { get { return new Array<IKRigGoal>(this[nameof(Goals)].Address); } }
        public bool bStartFromRefPose { get { return this[nameof(bStartFromRefPose)].Flag; } set { this[nameof(bStartFromRefPose)].Flag = value; } }
        public EAnimAlphaInputType AlphaInputType { get { return (EAnimAlphaInputType)this[nameof(AlphaInputType)].GetValue<int>(); } set { this[nameof(AlphaInputType)].SetValue<int>((int)value); } }
        public bool bAlphaBoolEnabled { get { return this[nameof(bAlphaBoolEnabled)].Flag; } set { this[nameof(bAlphaBoolEnabled)].Flag = value; } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public InputAlphaBoolBlend AlphaBoolBlend { get { return this[nameof(AlphaBoolBlend)].As<InputAlphaBoolBlend>(); } set { this["AlphaBoolBlend"] = value; } }
        public Object AlphaCurveName { get { return this[nameof(AlphaCurveName)]; } set { this[nameof(AlphaCurveName)] = value; } }
        public InputScaleBiasClamp AlphaScaleBiasClamp { get { return this[nameof(AlphaScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["AlphaScaleBiasClamp"] = value; } }
        public IKRigProcessor IKRigProcessor { get { return this[nameof(IKRigProcessor)].As<IKRigProcessor>(); } set { this["IKRigProcessor"] = value; } }
        public float ActualAlpha { get { return this[nameof(ActualAlpha)].GetValue<float>(); } set { this[nameof(ActualAlpha)].SetValue<float>(value); } }
    }
    public class IKRigGoal : Object
    {
        public IKRigGoal(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public EIKRigGoalTransformSource TransformSource { get { return (EIKRigGoalTransformSource)this[nameof(TransformSource)].GetValue<int>(); } set { this[nameof(TransformSource)].SetValue<int>((int)value); } }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public float PositionAlpha { get { return this[nameof(PositionAlpha)].GetValue<float>(); } set { this[nameof(PositionAlpha)].SetValue<float>(value); } }
        public float RotationAlpha { get { return this[nameof(RotationAlpha)].GetValue<float>(); } set { this[nameof(RotationAlpha)].SetValue<float>(value); } }
        public EIKRigGoalSpace PositionSpace { get { return (EIKRigGoalSpace)this[nameof(PositionSpace)].GetValue<int>(); } set { this[nameof(PositionSpace)].SetValue<int>((int)value); } }
        public EIKRigGoalSpace RotationSpace { get { return (EIKRigGoalSpace)this[nameof(RotationSpace)].GetValue<int>(); } set { this[nameof(RotationSpace)].SetValue<int>((int)value); } }
        public Vector FinalBlendedPosition { get { return this[nameof(FinalBlendedPosition)].As<Vector>(); } set { this["FinalBlendedPosition"] = value; } }
        public Quat FinalBlendedRotation { get { return this[nameof(FinalBlendedRotation)].As<Quat>(); } set { this["FinalBlendedRotation"] = value; } }
    }
    public class AnimNode_RetargetPoseFromMesh : AnimNode_Base
    {
        public AnimNode_RetargetPoseFromMesh(nint addr) : base(addr) { }
        public Object SourceMeshComponent { get { return this[nameof(SourceMeshComponent)]; } set { this[nameof(SourceMeshComponent)] = value; } }
        public bool bUseAttachedParent { get { return this[nameof(bUseAttachedParent)].Flag; } set { this[nameof(bUseAttachedParent)].Flag = value; } }
        public IKRetargeter IKRetargeterAsset { get { return this[nameof(IKRetargeterAsset)].As<IKRetargeter>(); } set { this["IKRetargeterAsset"] = value; } }
        public RetargetProfile CustomRetargetProfile { get { return this[nameof(CustomRetargetProfile)].As<RetargetProfile>(); } set { this["CustomRetargetProfile"] = value; } }
        public bool bSuppressWarnings { get { return this[nameof(bSuppressWarnings)].Flag; } set { this[nameof(bSuppressWarnings)].Flag = value; } }
        public bool bCopyCurves { get { return this[nameof(bCopyCurves)].Flag; } set { this[nameof(bCopyCurves)].Flag = value; } }
        public IKRetargetProcessor Processor { get { return this[nameof(Processor)].As<IKRetargetProcessor>(); } set { this["Processor"] = value; } }
    }
    public class IKRigGoalContainer : Object
    {
        public IKRigGoalContainer(nint addr) : base(addr) { }
    }
    public class BoneChain : Object
    {
        public BoneChain(nint addr) : base(addr) { }
        public Object ChainName { get { return this[nameof(ChainName)]; } set { this[nameof(ChainName)] = value; } }
        public BoneReference StartBone { get { return this[nameof(StartBone)].As<BoneReference>(); } set { this["StartBone"] = value; } }
        public BoneReference EndBone { get { return this[nameof(EndBone)].As<BoneReference>(); } set { this["EndBone"] = value; } }
        public Object IKGoalName { get { return this[nameof(IKGoalName)]; } set { this[nameof(IKGoalName)] = value; } }
    }
    public class RetargetDefinition : Object
    {
        public RetargetDefinition(nint addr) : base(addr) { }
        public Object RootBone { get { return this[nameof(RootBone)]; } set { this[nameof(RootBone)] = value; } }
        public Array<BoneChain> BoneChains { get { return new Array<BoneChain>(this[nameof(BoneChains)].Address); } }
    }
    public class GoalBone : Object
    {
        public GoalBone(nint addr) : base(addr) { }
    }
    public class IKRigInputSkeleton : Object
    {
        public IKRigInputSkeleton(nint addr) : base(addr) { }
    }
    public class IKRigSkeleton : Object
    {
        public IKRigSkeleton(nint addr) : base(addr) { }
        public Array<Object> BoneNames { get { return new Array<Object>(this[nameof(BoneNames)].Address); } }
        public Array<int> ParentIndices { get { return new Array<int>(this[nameof(ParentIndices)].Address); } }
        public Array<Object> ExcludedBones { get { return new Array<Object>(this[nameof(ExcludedBones)].Address); } }
        public Array<Transform> CurrentPoseGlobal { get { return new Array<Transform>(this[nameof(CurrentPoseGlobal)].Address); } }
        public Array<Transform> CurrentPoseLocal { get { return new Array<Transform>(this[nameof(CurrentPoseLocal)].Address); } }
        public Array<Transform> RefPoseGlobal { get { return new Array<Transform>(this[nameof(RefPoseGlobal)].Address); } }
    }
    public class RetargetChainMap : Object
    {
        public RetargetChainMap(nint addr) : base(addr) { }
        public Object SourceChain { get { return this[nameof(SourceChain)]; } set { this[nameof(SourceChain)] = value; } }
        public Object TargetChain { get { return this[nameof(TargetChain)]; } set { this[nameof(TargetChain)] = value; } }
    }
    public class IKRetargetPose : Object
    {
        public IKRetargetPose(nint addr) : base(addr) { }
        public Vector RootTranslationOffset { get { return this[nameof(RootTranslationOffset)].As<Vector>(); } set { this["RootTranslationOffset"] = value; } }
        public Object BoneRotationOffsets { get { return this[nameof(BoneRotationOffsets)]; } set { this[nameof(BoneRotationOffsets)] = value; } }
    }
    public class LimbSolverSettings : Object
    {
        public LimbSolverSettings(nint addr) : base(addr) { }
        public float ReachPrecision { get { return this[nameof(ReachPrecision)].GetValue<float>(); } set { this[nameof(ReachPrecision)].SetValue<float>(value); } }
        public byte HingeRotationAxis { get { return this[nameof(HingeRotationAxis)].GetValue<byte>(); } set { this[nameof(HingeRotationAxis)].SetValue<byte>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public bool bEnableLimit { get { return this[nameof(bEnableLimit)].Flag; } set { this[nameof(bEnableLimit)].Flag = value; } }
        public float MinRotationAngle { get { return this[nameof(MinRotationAngle)].GetValue<float>(); } set { this[nameof(MinRotationAngle)].SetValue<float>(value); } }
        public bool bAveragePull { get { return this[nameof(bAveragePull)].Flag; } set { this[nameof(bAveragePull)].Flag = value; } }
        public float PullDistribution { get { return this[nameof(PullDistribution)].GetValue<float>(); } set { this[nameof(PullDistribution)].SetValue<float>(value); } }
        public float ReachStepAlpha { get { return this[nameof(ReachStepAlpha)].GetValue<float>(); } set { this[nameof(ReachStepAlpha)].SetValue<float>(value); } }
        public bool bEnableTwistCorrection { get { return this[nameof(bEnableTwistCorrection)].Flag; } set { this[nameof(bEnableTwistCorrection)].Flag = value; } }
        public byte EndBoneForwardAxis { get { return this[nameof(EndBoneForwardAxis)].GetValue<byte>(); } set { this[nameof(EndBoneForwardAxis)].SetValue<byte>(value); } }
    }
    public class LimbLink : Object
    {
        public LimbLink(nint addr) : base(addr) { }
    }
    public class LimbSolver : Object
    {
        public LimbSolver(nint addr) : base(addr) { }
    }
}
