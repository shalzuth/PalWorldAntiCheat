using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AnimationSharingSDK
{
    public class AnimationSharingStateProcessor : Object
    {
        public AnimationSharingStateProcessor(nint addr) : base(addr) { }
        public Object AnimationStateEnum { get { return this[nameof(AnimationStateEnum)]; } set { this[nameof(AnimationStateEnum)] = value; } }
        public void ProcessActorState(int OutState, Actor InActor, byte CurrentState, byte OnDemandState, bool bShouldProcess) { Invoke(nameof(ProcessActorState), OutState, InActor, CurrentState, OnDemandState, bShouldProcess); }
        public Enum GetAnimationStateEnum() { return Invoke<Enum>(nameof(GetAnimationStateEnum)); }
    }
    public class AnimSharingStateInstance : AnimInstance
    {
        public AnimSharingStateInstance(nint addr) : base(addr) { }
        public AnimSequence AnimationToPlay { get { return this[nameof(AnimationToPlay)].As<AnimSequence>(); } set { this["AnimationToPlay"] = value; } }
        public float PermutationTimeOffset { get { return this[nameof(PermutationTimeOffset)].GetValue<float>(); } set { this[nameof(PermutationTimeOffset)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bStateBool { get { return this[nameof(bStateBool)].Flag; } set { this[nameof(bStateBool)].Flag = value; } }
        public AnimSharingInstance Instance { get { return this[nameof(Instance)].As<AnimSharingInstance>(); } set { this["Instance"] = value; } }
        public void GetInstancedActors(Array<Actor> Actors) { Invoke(nameof(GetInstancedActors), Actors); }
    }
    public class AnimSharingTransitionInstance : AnimInstance
    {
        public AnimSharingTransitionInstance(nint addr) : base(addr) { }
        public Object FromComponent { get { return this[nameof(FromComponent)]; } set { this[nameof(FromComponent)] = value; } }
        public Object ToComponent { get { return this[nameof(ToComponent)]; } set { this[nameof(ToComponent)] = value; } }
        public float BlendTime { get { return this[nameof(BlendTime)].GetValue<float>(); } set { this[nameof(BlendTime)].SetValue<float>(value); } }
        public bool bBlendBool { get { return this[nameof(bBlendBool)].Flag; } set { this[nameof(bBlendBool)].Flag = value; } }
    }
    public class AnimSharingAdditiveInstance : AnimInstance
    {
        public AnimSharingAdditiveInstance(nint addr) : base(addr) { }
        public Object BaseComponent { get { return this[nameof(BaseComponent)]; } set { this[nameof(BaseComponent)] = value; } }
        public Object AdditiveAnimation { get { return this[nameof(AdditiveAnimation)]; } set { this[nameof(AdditiveAnimation)] = value; } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
        public bool bStateBool { get { return this[nameof(bStateBool)].Flag; } set { this[nameof(bStateBool)].Flag = value; } }
    }
    public class AnimSharingInstance : Object
    {
        public AnimSharingInstance(nint addr) : base(addr) { }
        public Array<Actor> RegisteredActors { get { return new Array<Actor>(this[nameof(RegisteredActors)].Address); } }
        public AnimationSharingStateProcessor StateProcessor { get { return this[nameof(StateProcessor)].As<AnimationSharingStateProcessor>(); } set { this["StateProcessor"] = value; } }
        public Array<AnimSequence> UsedAnimationSequences { get { return new Array<AnimSequence>(this[nameof(UsedAnimationSequences)].Address); } }
        public Enum StateEnum { get { return this[nameof(StateEnum)].As<Enum>(); } set { this["StateEnum"] = value; } }
        public Actor SharingActor { get { return this[nameof(SharingActor)].As<Actor>(); } set { this["SharingActor"] = value; } }
    }
    public class AnimationSharingManager : Object
    {
        public AnimationSharingManager(nint addr) : base(addr) { }
        public Array<Skeleton> Skeletons { get { return new Array<Skeleton>(this[nameof(Skeletons)].Address); } }
        public Array<AnimSharingInstance> PerSkeletonData { get { return new Array<AnimSharingInstance>(this[nameof(PerSkeletonData)].Address); } }
        public void RegisterActorWithSkeletonBP(Actor InActor, Skeleton SharingSkeleton) { Invoke(nameof(RegisterActorWithSkeletonBP), InActor, SharingSkeleton); }
        public AnimationSharingManager GetAnimationSharingManager(Object WorldContextObject) { return Invoke<AnimationSharingManager>(nameof(GetAnimationSharingManager), WorldContextObject); }
        public bool CreateAnimationSharingManager(Object WorldContextObject, AnimationSharingSetup Setup) { return Invoke<bool>(nameof(CreateAnimationSharingManager), WorldContextObject, Setup); }
        public bool AnimationSharingEnabled() { return Invoke<bool>(nameof(AnimationSharingEnabled)); }
    }
    public class AnimationSharingSetup : Object
    {
        public AnimationSharingSetup(nint addr) : base(addr) { }
        public Array<PerSkeletonAnimationSharingSetup> SkeletonSetups { get { return new Array<PerSkeletonAnimationSharingSetup>(this[nameof(SkeletonSetups)].Address); } }
        public AnimationSharingScalability ScalabilitySettings { get { return this[nameof(ScalabilitySettings)].As<AnimationSharingScalability>(); } set { this["ScalabilitySettings"] = value; } }
    }
    public class AnimationSetup : Object
    {
        public AnimationSetup(nint addr) : base(addr) { }
        public AnimSequence AnimSequence { get { return this[nameof(AnimSequence)].As<AnimSequence>(); } set { this["AnimSequence"] = value; } }
        public Object AnimBlueprint { get { return this[nameof(AnimBlueprint)]; } set { this[nameof(AnimBlueprint)] = value; } }
        public PerPlatformInt NumRandomizedInstances { get { return this[nameof(NumRandomizedInstances)].As<PerPlatformInt>(); } set { this["NumRandomizedInstances"] = value; } }
        public PerPlatformBool Enabled { get { return this[nameof(Enabled)].As<PerPlatformBool>(); } set { this["Enabled"] = value; } }
    }
    public class AnimationStateEntry : Object
    {
        public AnimationStateEntry(nint addr) : base(addr) { }
        public byte State { get { return this[nameof(State)].GetValue<byte>(); } set { this[nameof(State)].SetValue<byte>(value); } }
        public Array<AnimationSetup> AnimationSetups { get { return new Array<AnimationSetup>(this[nameof(AnimationSetups)].Address); } }
        public bool bOnDemand { get { return this[nameof(bOnDemand)].Flag; } set { this[nameof(bOnDemand)].Flag = value; } }
        public bool bAdditive { get { return this[nameof(bAdditive)].Flag; } set { this[nameof(bAdditive)].Flag = value; } }
        public float BlendTime { get { return this[nameof(BlendTime)].GetValue<float>(); } set { this[nameof(BlendTime)].SetValue<float>(value); } }
        public bool bReturnToPreviousState { get { return this[nameof(bReturnToPreviousState)].Flag; } set { this[nameof(bReturnToPreviousState)].Flag = value; } }
        public bool bSetNextState { get { return this[nameof(bSetNextState)].Flag; } set { this[nameof(bSetNextState)].Flag = value; } }
        public byte NextState { get { return this[nameof(NextState)].GetValue<byte>(); } set { this[nameof(NextState)].SetValue<byte>(value); } }
        public PerPlatformInt MaximumNumberOfConcurrentInstances { get { return this[nameof(MaximumNumberOfConcurrentInstances)].As<PerPlatformInt>(); } set { this["MaximumNumberOfConcurrentInstances"] = value; } }
        public float WiggleTimePercentage { get { return this[nameof(WiggleTimePercentage)].GetValue<float>(); } set { this[nameof(WiggleTimePercentage)].SetValue<float>(value); } }
        public bool bRequiresCurves { get { return this[nameof(bRequiresCurves)].Flag; } set { this[nameof(bRequiresCurves)].Flag = value; } }
    }
    public class PerSkeletonAnimationSharingSetup : Object
    {
        public PerSkeletonAnimationSharingSetup(nint addr) : base(addr) { }
        public Skeleton Skeleton { get { return this[nameof(Skeleton)].As<Skeleton>(); } set { this["Skeleton"] = value; } }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public Object BlendAnimBlueprint { get { return this[nameof(BlendAnimBlueprint)]; } set { this[nameof(BlendAnimBlueprint)] = value; } }
        public Object AdditiveAnimBlueprint { get { return this[nameof(AdditiveAnimBlueprint)]; } set { this[nameof(AdditiveAnimBlueprint)] = value; } }
        public Object StateProcessorClass { get { return this[nameof(StateProcessorClass)]; } set { this[nameof(StateProcessorClass)] = value; } }
        public Array<AnimationStateEntry> AnimationStates { get { return new Array<AnimationStateEntry>(this[nameof(AnimationStates)].Address); } }
    }
    public class AnimationSharingScalability : Object
    {
        public AnimationSharingScalability(nint addr) : base(addr) { }
        public PerPlatformBool UseBlendTransitions { get { return this[nameof(UseBlendTransitions)].As<PerPlatformBool>(); } set { this["UseBlendTransitions"] = value; } }
        public PerPlatformFloat BlendSignificanceValue { get { return this[nameof(BlendSignificanceValue)].As<PerPlatformFloat>(); } set { this["BlendSignificanceValue"] = value; } }
        public PerPlatformInt MaximumNumberConcurrentBlends { get { return this[nameof(MaximumNumberConcurrentBlends)].As<PerPlatformInt>(); } set { this["MaximumNumberConcurrentBlends"] = value; } }
        public PerPlatformFloat TickSignificanceValue { get { return this[nameof(TickSignificanceValue)].As<PerPlatformFloat>(); } set { this["TickSignificanceValue"] = value; } }
    }
    public class TickAnimationSharingFunction : TickFunction
    {
        public TickAnimationSharingFunction(nint addr) : base(addr) { }
    }
}
