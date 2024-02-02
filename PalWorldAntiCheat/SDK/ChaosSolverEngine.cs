using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ChaosSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.ChaosSolverEngineSDK
{
    public class ChaosDebugDrawComponent : ActorComponent
    {
        public ChaosDebugDrawComponent(nint addr) : base(addr) { }
    }
    public class ChaosEventListenerComponent : ActorComponent
    {
        public ChaosEventListenerComponent(nint addr) : base(addr) { }
    }
    public class ChaosGameplayEventDispatcher : ChaosEventListenerComponent
    {
        public ChaosGameplayEventDispatcher(nint addr) : base(addr) { }
        public Object CollisionEventRegistrations { get { return this[nameof(CollisionEventRegistrations)]; } set { this[nameof(CollisionEventRegistrations)] = value; } }
        public Object BreakEventRegistrations { get { return this[nameof(BreakEventRegistrations)]; } set { this[nameof(BreakEventRegistrations)] = value; } }
        public Object RemovalEventRegistrations { get { return this[nameof(RemovalEventRegistrations)]; } set { this[nameof(RemovalEventRegistrations)] = value; } }
        public Object CrumblingEventRegistrations { get { return this[nameof(CrumblingEventRegistrations)]; } set { this[nameof(CrumblingEventRegistrations)] = value; } }
    }
    public class ChaosNotifyHandlerInterface : Interface
    {
        public ChaosNotifyHandlerInterface(nint addr) : base(addr) { }
    }
    public class ChaosSolverEngineBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ChaosSolverEngineBlueprintLibrary(nint addr) : base(addr) { }
        public HitResult ConvertPhysicsCollisionToHitResult(ChaosPhysicsCollisionInfo PhysicsCollision) { return Invoke<HitResult>(nameof(ConvertPhysicsCollisionToHitResult), PhysicsCollision); }
    }
    public class ChaosSolver : Object
    {
        public ChaosSolver(nint addr) : base(addr) { }
    }
    public class ChaosSolverActor : Actor
    {
        public ChaosSolverActor(nint addr) : base(addr) { }
        public ChaosSolverConfiguration Properties { get { return this[nameof(Properties)].As<ChaosSolverConfiguration>(); } set { this["Properties"] = value; } }
        public float TimeStepMultiplier { get { return this[nameof(TimeStepMultiplier)].GetValue<float>(); } set { this[nameof(TimeStepMultiplier)].SetValue<float>(value); } }
        public int CollisionIterations { get { return this[nameof(CollisionIterations)].GetValue<int>(); } set { this[nameof(CollisionIterations)].SetValue<int>(value); } }
        public int PushOutIterations { get { return this[nameof(PushOutIterations)].GetValue<int>(); } set { this[nameof(PushOutIterations)].SetValue<int>(value); } }
        public int PushOutPairIterations { get { return this[nameof(PushOutPairIterations)].GetValue<int>(); } set { this[nameof(PushOutPairIterations)].SetValue<int>(value); } }
        public float ClusterConnectionFactor { get { return this[nameof(ClusterConnectionFactor)].GetValue<float>(); } set { this[nameof(ClusterConnectionFactor)].SetValue<float>(value); } }
        public EClusterConnectionTypeEnum ClusterUnionConnectionType { get { return (EClusterConnectionTypeEnum)this[nameof(ClusterUnionConnectionType)].GetValue<int>(); } set { this[nameof(ClusterUnionConnectionType)].SetValue<int>((int)value); } }
        public bool DoGenerateCollisionData { get { return this[nameof(DoGenerateCollisionData)].Flag; } set { this[nameof(DoGenerateCollisionData)].Flag = value; } }
        public SolverCollisionFilterSettings CollisionFilterSettings { get { return this[nameof(CollisionFilterSettings)].As<SolverCollisionFilterSettings>(); } set { this["CollisionFilterSettings"] = value; } }
        public bool DoGenerateBreakingData { get { return this[nameof(DoGenerateBreakingData)].Flag; } set { this[nameof(DoGenerateBreakingData)].Flag = value; } }
        public SolverBreakingFilterSettings BreakingFilterSettings { get { return this[nameof(BreakingFilterSettings)].As<SolverBreakingFilterSettings>(); } set { this["BreakingFilterSettings"] = value; } }
        public bool DoGenerateTrailingData { get { return this[nameof(DoGenerateTrailingData)].Flag; } set { this[nameof(DoGenerateTrailingData)].Flag = value; } }
        public SolverTrailingFilterSettings TrailingFilterSettings { get { return this[nameof(TrailingFilterSettings)].As<SolverTrailingFilterSettings>(); } set { this["TrailingFilterSettings"] = value; } }
        public float MassScale { get { return this[nameof(MassScale)].GetValue<float>(); } set { this[nameof(MassScale)].SetValue<float>(value); } }
        public bool bHasFloor { get { return this[nameof(bHasFloor)].Flag; } set { this[nameof(bHasFloor)].Flag = value; } }
        public float FloorHeight { get { return this[nameof(FloorHeight)].GetValue<float>(); } set { this[nameof(FloorHeight)].SetValue<float>(value); } }
        public ChaosDebugSubstepControl ChaosDebugSubstepControl { get { return this[nameof(ChaosDebugSubstepControl)].As<ChaosDebugSubstepControl>(); } set { this["ChaosDebugSubstepControl"] = value; } }
        public BillboardComponent SpriteComponent { get { return this[nameof(SpriteComponent)].As<BillboardComponent>(); } set { this["SpriteComponent"] = value; } }
        public ChaosGameplayEventDispatcher GameplayEventDispatcherComponent { get { return this[nameof(GameplayEventDispatcherComponent)].As<ChaosGameplayEventDispatcher>(); } set { this["GameplayEventDispatcherComponent"] = value; } }
        public void SetSolverActive(bool bActive) { Invoke(nameof(SetSolverActive), bActive); }
        public void SetAsCurrentWorldSolver() { Invoke(nameof(SetAsCurrentWorldSolver)); }
    }
    public class ChaosSolverSettings : DeveloperSettings
    {
        public ChaosSolverSettings(nint addr) : base(addr) { }
        public SoftClassPath DefaultChaosSolverActorClass { get { return this[nameof(DefaultChaosSolverActorClass)].As<SoftClassPath>(); } set { this["DefaultChaosSolverActorClass"] = value; } }
    }
    public class ChaosPhysicsCollisionInfo : Object
    {
        public ChaosPhysicsCollisionInfo(nint addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public PrimitiveComponent OtherComponent { get { return this[nameof(OtherComponent)].As<PrimitiveComponent>(); } set { this["OtherComponent"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector AccumulatedImpulse { get { return this[nameof(AccumulatedImpulse)].As<Vector>(); } set { this["AccumulatedImpulse"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector OtherVelocity { get { return this[nameof(OtherVelocity)].As<Vector>(); } set { this["OtherVelocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public Vector OtherAngularVelocity { get { return this[nameof(OtherAngularVelocity)].As<Vector>(); } set { this["OtherAngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public float OtherMass { get { return this[nameof(OtherMass)].GetValue<float>(); } set { this[nameof(OtherMass)].SetValue<float>(value); } }
    }
    public enum EClusterConnectionTypeEnum : int
    {
        Chaos_PointImplicit = 0,
        Chaos_DelaunayTriangulation = 1,
        Chaos_MinimalSpanningSubsetDelaunayTriangulation = 2,
        Chaos_PointImplicitAugmentedWithMinimalDelaunay = 3,
        Chaos_BoundsOverlapFilteredDelaunayTriangulation = 4,
        Chaos_None = 5,
        Chaos_EClsuterCreationParameters_Max = 6,
        Chaos_MAX = 7,
    }
    public class ChaosBreakEvent : Object
    {
        public ChaosBreakEvent(nint addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
    }
    public class ChaosCrumblingEvent : Object
    {
        public ChaosCrumblingEvent(nint addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Orientation { get { return this[nameof(Orientation)].As<Quat>(); } set { this["Orientation"] = value; } }
        public Vector LinearVelocity { get { return this[nameof(LinearVelocity)].As<Vector>(); } set { this["LinearVelocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public Box LocalBounds { get { return this[nameof(LocalBounds)].As<Box>(); } set { this["LocalBounds"] = value; } }
        public Array<int> Children { get { return new Array<int>(this[nameof(Children)].Address); } }
    }
    public class ChaosRemovalEvent : Object
    {
        public ChaosRemovalEvent(nint addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
    }
    public class BreakEventCallbackWrapper : Object
    {
        public BreakEventCallbackWrapper(nint addr) : base(addr) { }
    }
    public class RemovalEventCallbackWrapper : Object
    {
        public RemovalEventCallbackWrapper(nint addr) : base(addr) { }
    }
    public class CrumblingEventCallbackWrapper : Object
    {
        public CrumblingEventCallbackWrapper(nint addr) : base(addr) { }
    }
    public class ChaosHandlerSet : Object
    {
        public ChaosHandlerSet(nint addr) : base(addr) { }
        public Object ChaosHandlers { get { return this[nameof(ChaosHandlers)]; } set { this[nameof(ChaosHandlers)] = value; } }
    }
    public class ChaosDebugSubstepControl : Object
    {
        public ChaosDebugSubstepControl(nint addr) : base(addr) { }
        public bool bPause { get { return this[nameof(bPause)].Flag; } set { this[nameof(bPause)].Flag = value; } }
        public bool bSubstep { get { return this[nameof(bSubstep)].Flag; } set { this[nameof(bSubstep)].Flag = value; } }
        public bool bStep { get { return this[nameof(bStep)].Flag; } set { this[nameof(bStep)].Flag = value; } }
    }
}
