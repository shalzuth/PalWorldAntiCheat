using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MotionWarpingSDK
{
    public class AnimNotifyState_MotionWarping : AnimNotifyState
    {
        public AnimNotifyState_MotionWarping(nint addr) : base(addr) { }
        public RootMotionModifier RootMotionModifier { get { return this[nameof(RootMotionModifier)].As<RootMotionModifier>(); } set { this["RootMotionModifier"] = value; } }
        public void OnWarpUpdate(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnWarpUpdate), MotionWarpingComp, Modifier); }
        public void OnWarpEnd(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnWarpEnd), MotionWarpingComp, Modifier); }
        public void OnWarpBegin(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnWarpBegin), MotionWarpingComp, Modifier); }
        public void OnRootMotionModifierUpdate(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnRootMotionModifierUpdate), MotionWarpingComp, Modifier); }
        public void OnRootMotionModifierDeactivate(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnRootMotionModifierDeactivate), MotionWarpingComp, Modifier); }
        public void OnRootMotionModifierActivate(MotionWarpingComponent MotionWarpingComp, RootMotionModifier Modifier) { Invoke(nameof(OnRootMotionModifierActivate), MotionWarpingComp, Modifier); }
        public RootMotionModifier AddRootMotionModifier(MotionWarpingComponent MotionWarpingComp, AnimSequenceBase Animation, float StartTime, float EndTime) { return Invoke<RootMotionModifier>(nameof(AddRootMotionModifier), MotionWarpingComp, Animation, StartTime, EndTime); }
    }
    public class MotionWarpingUtilities : BlueprintFunctionLibrary
    {
        public MotionWarpingUtilities(nint addr) : base(addr) { }
        public void GetMotionWarpingWindowsFromAnimation(AnimSequenceBase Animation, Array<MotionWarpingWindowData> OutWindows) { Invoke(nameof(GetMotionWarpingWindowsFromAnimation), Animation, OutWindows); }
        public void GetMotionWarpingWindowsForWarpTargetFromAnimation(AnimSequenceBase Animation, Object WarpTargetName, Array<MotionWarpingWindowData> OutWindows) { Invoke(nameof(GetMotionWarpingWindowsForWarpTargetFromAnimation), Animation, WarpTargetName, OutWindows); }
        public Transform ExtractRootMotionFromAnimation(AnimSequenceBase Animation, float StartTime, float EndTime) { return Invoke<Transform>(nameof(ExtractRootMotionFromAnimation), Animation, StartTime, EndTime); }
    }
    public class MotionWarpingComponent : ActorComponent
    {
        public MotionWarpingComponent(nint addr) : base(addr) { }
        public bool bSearchForWindowsInAnimsWithinMontages { get { return this[nameof(bSearchForWindowsInAnimsWithinMontages)].Flag; } set { this[nameof(bSearchForWindowsInAnimsWithinMontages)].Flag = value; } }
        public Object OnPreUpdate { get { return this[nameof(OnPreUpdate)]; } set { this[nameof(OnPreUpdate)] = value; } }
        public Object CharacterOwner { get { return this[nameof(CharacterOwner)]; } set { this[nameof(CharacterOwner)] = value; } }
        public Array<RootMotionModifier> Modifiers { get { return new Array<RootMotionModifier>(this[nameof(Modifiers)].Address); } }
        public Array<MotionWarpingTarget> WarpTargets { get { return new Array<MotionWarpingTarget>(this[nameof(WarpTargets)].Address); } }
        public int RemoveWarpTarget(Object WarpTargetName) { return Invoke<int>(nameof(RemoveWarpTarget), WarpTargetName); }
        public void DisableAllRootMotionModifiers() { Invoke(nameof(DisableAllRootMotionModifiers)); }
        public void AddOrUpdateWarpTargetFromTransform(Object WarpTargetName, Transform TargetTransform) { Invoke(nameof(AddOrUpdateWarpTargetFromTransform), WarpTargetName, TargetTransform); }
        public void AddOrUpdateWarpTargetFromLocationAndRotation(Object WarpTargetName, Vector TargetLocation, Rotator TargetRotation) { Invoke(nameof(AddOrUpdateWarpTargetFromLocationAndRotation), WarpTargetName, TargetLocation, TargetRotation); }
        public void AddOrUpdateWarpTargetFromLocation(Object WarpTargetName, Vector TargetLocation) { Invoke(nameof(AddOrUpdateWarpTargetFromLocation), WarpTargetName, TargetLocation); }
        public void AddOrUpdateWarpTargetFromComponent(Object WarpTargetName, SceneComponent Component, Object BoneName, bool bFollowComponent) { Invoke(nameof(AddOrUpdateWarpTargetFromComponent), WarpTargetName, Component, BoneName, bFollowComponent); }
        public void AddOrUpdateWarpTarget(MotionWarpingTarget WarpTarget) { Invoke(nameof(AddOrUpdateWarpTarget), WarpTarget); }
    }
    public class RootMotionModifier : Object
    {
        public RootMotionModifier(nint addr) : base(addr) { }
        public Object Animation { get { return this[nameof(Animation)]; } set { this[nameof(Animation)] = value; } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public float EndTime { get { return this[nameof(EndTime)].GetValue<float>(); } set { this[nameof(EndTime)].SetValue<float>(value); } }
        public float PreviousPosition { get { return this[nameof(PreviousPosition)].GetValue<float>(); } set { this[nameof(PreviousPosition)].SetValue<float>(value); } }
        public float CurrentPosition { get { return this[nameof(CurrentPosition)].GetValue<float>(); } set { this[nameof(CurrentPosition)].SetValue<float>(value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public Transform StartTransform { get { return this[nameof(StartTransform)].As<Transform>(); } set { this["StartTransform"] = value; } }
        public float ActualStartTime { get { return this[nameof(ActualStartTime)].GetValue<float>(); } set { this[nameof(ActualStartTime)].SetValue<float>(value); } }
        public Object OnActivateDelegate { get { return this[nameof(OnActivateDelegate)]; } set { this[nameof(OnActivateDelegate)] = value; } }
        public Object OnUpdateDelegate { get { return this[nameof(OnUpdateDelegate)]; } set { this[nameof(OnUpdateDelegate)] = value; } }
        public Object OnDeactivateDelegate { get { return this[nameof(OnDeactivateDelegate)]; } set { this[nameof(OnDeactivateDelegate)] = value; } }
        public ERootMotionModifierState State { get { return (ERootMotionModifierState)this[nameof(State)].GetValue<int>(); } set { this[nameof(State)].SetValue<int>((int)value); } }
    }
    public class RootMotionModifier_Warp : RootMotionModifier
    {
        public RootMotionModifier_Warp(nint addr) : base(addr) { }
        public Object WarpTargetName { get { return this[nameof(WarpTargetName)]; } set { this[nameof(WarpTargetName)] = value; } }
        public EWarpPointAnimProvider WarpPointAnimProvider { get { return (EWarpPointAnimProvider)this[nameof(WarpPointAnimProvider)].GetValue<int>(); } set { this[nameof(WarpPointAnimProvider)].SetValue<int>((int)value); } }
        public Transform WarpPointAnimTransform { get { return this[nameof(WarpPointAnimTransform)].As<Transform>(); } set { this["WarpPointAnimTransform"] = value; } }
        public Object WarpPointAnimBoneName { get { return this[nameof(WarpPointAnimBoneName)]; } set { this[nameof(WarpPointAnimBoneName)] = value; } }
        public bool bWarpTranslation { get { return this[nameof(bWarpTranslation)].Flag; } set { this[nameof(bWarpTranslation)].Flag = value; } }
        public bool bIgnoreZAxis { get { return this[nameof(bIgnoreZAxis)].Flag; } set { this[nameof(bIgnoreZAxis)].Flag = value; } }
        public EAlphaBlendOption AddTranslationEasingFunc { get { return (EAlphaBlendOption)this[nameof(AddTranslationEasingFunc)].GetValue<int>(); } set { this[nameof(AddTranslationEasingFunc)].SetValue<int>((int)value); } }
        public CurveFloat AddTranslationEasingCurve { get { return this[nameof(AddTranslationEasingCurve)].As<CurveFloat>(); } set { this["AddTranslationEasingCurve"] = value; } }
        public bool bWarpRotation { get { return this[nameof(bWarpRotation)].Flag; } set { this[nameof(bWarpRotation)].Flag = value; } }
        public EMotionWarpRotationType RotationType { get { return (EMotionWarpRotationType)this[nameof(RotationType)].GetValue<int>(); } set { this[nameof(RotationType)].SetValue<int>((int)value); } }
        public float WarpRotationTimeMultiplier { get { return this[nameof(WarpRotationTimeMultiplier)].GetValue<float>(); } set { this[nameof(WarpRotationTimeMultiplier)].SetValue<float>(value); } }
        public Transform CachedTargetTransform { get { return this[nameof(CachedTargetTransform)].As<Transform>(); } set { this["CachedTargetTransform"] = value; } }
    }
    public class RootMotionModifier_SimpleWarp : RootMotionModifier_Warp
    {
        public RootMotionModifier_SimpleWarp(nint addr) : base(addr) { }
    }
    public class RootMotionModifier_Scale : RootMotionModifier
    {
        public RootMotionModifier_Scale(nint addr) : base(addr) { }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public RootMotionModifier_Scale AddRootMotionModifierScale(MotionWarpingComponent InMotionWarpingComp, AnimSequenceBase InAnimation, float InStartTime, float InEndTime, Vector InScale) { return Invoke<RootMotionModifier_Scale>(nameof(AddRootMotionModifierScale), InMotionWarpingComp, InAnimation, InStartTime, InEndTime, InScale); }
    }
    public class RootMotionModifier_AdjustmentBlendWarp : RootMotionModifier_Warp
    {
        public RootMotionModifier_AdjustmentBlendWarp(nint addr) : base(addr) { }
        public bool bWarpIKBones { get { return this[nameof(bWarpIKBones)].Flag; } set { this[nameof(bWarpIKBones)].Flag = value; } }
        public Array<Object> IKBones { get { return new Array<Object>(this[nameof(IKBones)].Address); } }
        public Transform CachedMeshTransform { get { return this[nameof(CachedMeshTransform)].As<Transform>(); } set { this["CachedMeshTransform"] = value; } }
        public Transform CachedMeshRelativeTransform { get { return this[nameof(CachedMeshRelativeTransform)].As<Transform>(); } set { this["CachedMeshRelativeTransform"] = value; } }
        public Transform CachedRootMotion { get { return this[nameof(CachedRootMotion)].As<Transform>(); } set { this["CachedRootMotion"] = value; } }
        public AnimSequenceTrackContainer Result { get { return this[nameof(Result)].As<AnimSequenceTrackContainer>(); } set { this["Result"] = value; } }
    }
    public class RootMotionModifier_SkewWarp : RootMotionModifier_Warp
    {
        public RootMotionModifier_SkewWarp(nint addr) : base(addr) { }
        public RootMotionModifier_SkewWarp AddRootMotionModifierSkewWarp(MotionWarpingComponent InMotionWarpingComp, AnimSequenceBase InAnimation, float InStartTime, float InEndTime, Object InWarpTargetName, EWarpPointAnimProvider InWarpPointAnimProvider, Transform InWarpPointAnimTransform, Object InWarpPointAnimBoneName, bool bInWarpTranslation, bool bInIgnoreZAxis, bool bInWarpRotation, EMotionWarpRotationType InRotationType, float InWarpRotationTimeMultiplier) { return Invoke<RootMotionModifier_SkewWarp>(nameof(AddRootMotionModifierSkewWarp), InMotionWarpingComp, InAnimation, InStartTime, InEndTime, InWarpTargetName, InWarpPointAnimProvider, InWarpPointAnimTransform, InWarpPointAnimBoneName, bInWarpTranslation, bInIgnoreZAxis, bInWarpRotation, InRotationType, InWarpRotationTimeMultiplier); }
    }
    public enum ERootMotionModifierState : int
    {
        Waiting = 0,
        Active = 1,
        MarkedForRemoval = 2,
        Disabled = 3,
        ERootMotionModifierState_MAX = 4,
    }
    public enum EMotionWarpRotationType : int
    {
        Default = 0,
        Facing = 1,
        EMotionWarpRotationType_MAX = 2,
    }
    public enum EWarpPointAnimProvider : int
    {
        None = 0,
        Static = 1,
        Bone = 2,
        EWarpPointAnimProvider_MAX = 3,
    }
    public class MotionWarpingWindowData : Object
    {
        public MotionWarpingWindowData(nint addr) : base(addr) { }
        public AnimNotifyState_MotionWarping AnimNotify { get { return this[nameof(AnimNotify)].As<AnimNotifyState_MotionWarping>(); } set { this["AnimNotify"] = value; } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public float EndTime { get { return this[nameof(EndTime)].GetValue<float>(); } set { this[nameof(EndTime)].SetValue<float>(value); } }
    }
    public class MotionWarpingUpdateContext : Object
    {
        public MotionWarpingUpdateContext(nint addr) : base(addr) { }
        public Object Animation { get { return this[nameof(Animation)]; } set { this[nameof(Animation)] = value; } }
        public float PreviousPosition { get { return this[nameof(PreviousPosition)].GetValue<float>(); } set { this[nameof(PreviousPosition)].SetValue<float>(value); } }
        public float CurrentPosition { get { return this[nameof(CurrentPosition)].GetValue<float>(); } set { this[nameof(CurrentPosition)].SetValue<float>(value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float DeltaSeconds { get { return this[nameof(DeltaSeconds)].GetValue<float>(); } set { this[nameof(DeltaSeconds)].SetValue<float>(value); } }
    }
    public class MotionWarpingTarget : Object
    {
        public MotionWarpingTarget(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Object Component { get { return this[nameof(Component)]; } set { this[nameof(Component)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public bool bFollowComponent { get { return this[nameof(bFollowComponent)].Flag; } set { this[nameof(bFollowComponent)].Flag = value; } }
    }
    public class MotionDeltaTrack : Object
    {
        public MotionDeltaTrack(nint addr) : base(addr) { }
        public Array<Transform> BoneTransformTrack { get { return new Array<Transform>(this[nameof(BoneTransformTrack)].Address); } }
        public Array<Vector> DeltaTranslationTrack { get { return new Array<Vector>(this[nameof(DeltaTranslationTrack)].Address); } }
        public Array<Rotator> DeltaRotationTrack { get { return new Array<Rotator>(this[nameof(DeltaRotationTrack)].Address); } }
        public Vector TotalTranslation { get { return this[nameof(TotalTranslation)].As<Vector>(); } set { this["TotalTranslation"] = value; } }
        public Rotator TotalRotation { get { return this[nameof(TotalRotation)].As<Rotator>(); } set { this["TotalRotation"] = value; } }
    }
    public class MotionDeltaTrackContainer : Object
    {
        public MotionDeltaTrackContainer(nint addr) : base(addr) { }
        public Array<MotionDeltaTrack> Tracks { get { return new Array<MotionDeltaTrack>(this[nameof(Tracks)].Address); } }
    }
}
