using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.GameplayTasksSDK
{
    public class GameplayTask : Object
    {
        public GameplayTask(nint addr) : base(addr) { }
        public Object InstanceName { get { return this[nameof(InstanceName)]; } set { this[nameof(InstanceName)] = value; } }
        public ETaskResourceOverlapPolicy ResourceOverlapPolicy { get { return (ETaskResourceOverlapPolicy)this[nameof(ResourceOverlapPolicy)].GetValue<int>(); } set { this[nameof(ResourceOverlapPolicy)].SetValue<int>((int)value); } }
        public GameplayTask ChildTask { get { return this[nameof(ChildTask)].As<GameplayTask>(); } set { this["ChildTask"] = value; } }
        public void ReadyForActivation() { Invoke(nameof(ReadyForActivation)); }
        public void GenericGameplayTaskDelegate__DelegateSignature() { Invoke(nameof(GenericGameplayTaskDelegate__DelegateSignature)); }
        public void EndTask() { Invoke(nameof(EndTask)); }
    }
    public class GameplayTaskOwnerInterface : Interface
    {
        public GameplayTaskOwnerInterface(nint addr) : base(addr) { }
    }
    public class GameplayTaskResource : Object
    {
        public GameplayTaskResource(nint addr) : base(addr) { }
        public int ManualResourceID { get { return this[nameof(ManualResourceID)].GetValue<int>(); } set { this[nameof(ManualResourceID)].SetValue<int>(value); } }
        public byte AutoResourceID { get { return this[nameof(AutoResourceID)].GetValue<byte>(); } set { this[nameof(AutoResourceID)].SetValue<byte>(value); } }
        public bool bManuallySetID { get { return this[nameof(bManuallySetID)].Flag; } set { this[nameof(bManuallySetID)].Flag = value; } }
    }
    public class GameplayTasksComponent : ActorComponent
    {
        public GameplayTasksComponent(nint addr) : base(addr) { }
        public bool bIsNetDirty { get { return this[nameof(bIsNetDirty)].Flag; } set { this[nameof(bIsNetDirty)].Flag = value; } }
        public Array<GameplayTask> TaskPriorityQueue { get { return new Array<GameplayTask>(this[nameof(TaskPriorityQueue)].Address); } }
        public Array<GameplayTask> TickingTasks { get { return new Array<GameplayTask>(this[nameof(TickingTasks)].Address); } }
        public Array<GameplayTask> KnownTasks { get { return new Array<GameplayTask>(this[nameof(KnownTasks)].Address); } }
        public Object OnClaimedResourcesChange { get { return this[nameof(OnClaimedResourcesChange)]; } set { this[nameof(OnClaimedResourcesChange)] = value; } }
        public Array<GameplayTask> SimulatedTasks { get { return new Array<GameplayTask>(this[nameof(SimulatedTasks)].Address); } }
        public void OnRep_SimulatedTasks(Array<GameplayTask> PreviousSimulatedTasks) { Invoke(nameof(OnRep_SimulatedTasks), PreviousSimulatedTasks); }
        public EGameplayTaskRunResult K2_RunGameplayTask(Object TaskOwner, GameplayTask Task, byte Priority, Array<Object> AdditionalRequiredResources, Array<Object> AdditionalClaimedResources) { return Invoke<EGameplayTaskRunResult>(nameof(K2_RunGameplayTask), TaskOwner, Task, Priority, AdditionalRequiredResources, AdditionalClaimedResources); }
    }
    public class GameplayTask_ClaimResource : GameplayTask
    {
        public GameplayTask_ClaimResource(nint addr) : base(addr) { }
        public GameplayTask_ClaimResource ClaimResources(Object InTaskOwner, Array<Object> ResourceClasses, byte Priority, Object TaskInstanceName) { return Invoke<GameplayTask_ClaimResource>(nameof(ClaimResources), InTaskOwner, ResourceClasses, Priority, TaskInstanceName); }
        public GameplayTask_ClaimResource ClaimResource(Object InTaskOwner, Object ResourceClass, byte Priority, Object TaskInstanceName) { return Invoke<GameplayTask_ClaimResource>(nameof(ClaimResource), InTaskOwner, ResourceClass, Priority, TaskInstanceName); }
    }
    public class GameplayTask_SpawnActor : GameplayTask
    {
        public GameplayTask_SpawnActor(nint addr) : base(addr) { }
        public Object Success { get { return this[nameof(Success)]; } set { this[nameof(Success)] = value; } }
        public Object DidNotSpawn { get { return this[nameof(DidNotSpawn)]; } set { this[nameof(DidNotSpawn)] = value; } }
        public Object ClassToSpawn { get { return this[nameof(ClassToSpawn)]; } set { this[nameof(ClassToSpawn)] = value; } }
        public GameplayTask_SpawnActor SpawnActor(Object TaskOwner, Vector SpawnLocation, Rotator SpawnRotation, Object Class, bool bSpawnOnlyOnAuthority) { return Invoke<GameplayTask_SpawnActor>(nameof(SpawnActor), TaskOwner, SpawnLocation, SpawnRotation, Class, bSpawnOnlyOnAuthority); }
        public void FinishSpawningActor(Object WorldContextObject, Actor SpawnedActor) { Invoke(nameof(FinishSpawningActor), WorldContextObject, SpawnedActor); }
        public bool BeginSpawningActor(Object WorldContextObject, Actor SpawnedActor) { return Invoke<bool>(nameof(BeginSpawningActor), WorldContextObject, SpawnedActor); }
    }
    public class GameplayTask_TimeLimitedExecution : GameplayTask
    {
        public GameplayTask_TimeLimitedExecution(nint addr) : base(addr) { }
        public Object OnFinished { get { return this[nameof(OnFinished)]; } set { this[nameof(OnFinished)] = value; } }
        public Object OnTimeExpired { get { return this[nameof(OnTimeExpired)]; } set { this[nameof(OnTimeExpired)] = value; } }
    }
    public class GameplayTask_WaitDelay : GameplayTask
    {
        public GameplayTask_WaitDelay(nint addr) : base(addr) { }
        public Object OnFinish { get { return this[nameof(OnFinish)]; } set { this[nameof(OnFinish)] = value; } }
        public GameplayTask_WaitDelay TaskWaitDelay(Object TaskOwner, float Time, byte Priority) { return Invoke<GameplayTask_WaitDelay>(nameof(TaskWaitDelay), TaskOwner, Time, Priority); }
        public void TaskDelayDelegate__DelegateSignature() { Invoke(nameof(TaskDelayDelegate__DelegateSignature)); }
    }
    public class GameplayResourceSet : Object
    {
        public GameplayResourceSet(nint addr) : base(addr) { }
    }
    public enum ETaskResourceOverlapPolicy : int
    {
        StartOnTop = 0,
        StartAtEnd = 1,
        RequestCancelAndStartOnTop = 2,
        RequestCancelAndStartAtEnd = 3,
        ETaskResourceOverlapPolicy_MAX = 4,
    }
    public enum EGameplayTaskState : int
    {
        Uninitialized = 0,
        AwaitingActivation = 1,
        Paused = 2,
        Active = 3,
        Finished = 4,
        EGameplayTaskState_MAX = 5,
    }
    public enum EGameplayTaskRunResult : int
    {
        Error = 0,
        Failed = 1,
        Success_Paused = 2,
        Success_Active = 3,
        Success_Finished = 4,
        EGameplayTaskRunResult_MAX = 5,
    }
}
