using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.GameplayTasksSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.NavigationSystemSDK;
using SDK.Script.GameplayTagsSDK;
namespace SDK.Script.AIModuleSDK
{
    public class EnvQueryNode : Object
    {
        public EnvQueryNode(nint addr) : base(addr) { }
        public int VerNum { get { return this[nameof(VerNum)].GetValue<int>(); } set { this[nameof(VerNum)].SetValue<int>(value); } }
    }
    public class EnvQueryTest : EnvQueryNode
    {
        public EnvQueryTest(nint addr) : base(addr) { }
        public int TestOrder { get { return this[nameof(TestOrder)].GetValue<int>(); } set { this[nameof(TestOrder)].SetValue<int>(value); } }
        public byte TestPurpose { get { return this[nameof(TestPurpose)].GetValue<byte>(); } set { this[nameof(TestPurpose)].SetValue<byte>(value); } }
        public Object TestComment { get { return this[nameof(TestComment)]; } set { this[nameof(TestComment)] = value; } }
        public byte MultipleContextFilterOp { get { return this[nameof(MultipleContextFilterOp)].GetValue<byte>(); } set { this[nameof(MultipleContextFilterOp)].SetValue<byte>(value); } }
        public byte MultipleContextScoreOp { get { return this[nameof(MultipleContextScoreOp)].GetValue<byte>(); } set { this[nameof(MultipleContextScoreOp)].SetValue<byte>(value); } }
        public byte FilterType { get { return this[nameof(FilterType)].GetValue<byte>(); } set { this[nameof(FilterType)].SetValue<byte>(value); } }
        public AIDataProviderBoolValue BoolValue { get { return this[nameof(BoolValue)].As<AIDataProviderBoolValue>(); } set { this["BoolValue"] = value; } }
        //public AIDataProviderFloatValue FloatValueMin { get { return this[nameof(FloatValueMin)].As<AIDataProviderFloatValue>(); } set { this["FloatValueMin"] = value; } }
        //public AIDataProviderFloatValue FloatValueMax { get { return this[nameof(FloatValueMax)].As<AIDataProviderFloatValue>(); } set { this["FloatValueMax"] = value; } }
        public byte ScoringEquation { get { return this[nameof(ScoringEquation)].GetValue<byte>(); } set { this[nameof(ScoringEquation)].SetValue<byte>(value); } }
        public byte ClampMinType { get { return this[nameof(ClampMinType)].GetValue<byte>(); } set { this[nameof(ClampMinType)].SetValue<byte>(value); } }
        public byte ClampMaxType { get { return this[nameof(ClampMaxType)].GetValue<byte>(); } set { this[nameof(ClampMaxType)].SetValue<byte>(value); } }
        public EEQSNormalizationType NormalizationType { get { return (EEQSNormalizationType)this[nameof(NormalizationType)].GetValue<int>(); } set { this[nameof(NormalizationType)].SetValue<int>((int)value); } }
        public AIDataProviderFloatValue ScoreClampMin { get { return this[nameof(ScoreClampMin)].As<AIDataProviderFloatValue>(); } set { this["ScoreClampMin"] = value; } }
        public AIDataProviderFloatValue ScoreClampMax { get { return this[nameof(ScoreClampMax)].As<AIDataProviderFloatValue>(); } set { this["ScoreClampMax"] = value; } }
        public AIDataProviderFloatValue ScoringFactor { get { return this[nameof(ScoringFactor)].As<AIDataProviderFloatValue>(); } set { this["ScoringFactor"] = value; } }
        public AIDataProviderFloatValue ReferenceValue { get { return this[nameof(ReferenceValue)].As<AIDataProviderFloatValue>(); } set { this["ReferenceValue"] = value; } }
        public bool bDefineReferenceValue { get { return this[nameof(bDefineReferenceValue)].Flag; } set { this[nameof(bDefineReferenceValue)].Flag = value; } }
        public bool bWorkOnFloatValues { get { return this[nameof(bWorkOnFloatValues)].Flag; } set { this[nameof(bWorkOnFloatValues)].Flag = value; } }
    }
    public class AIController : Controller
    {
        public AIController(nint addr) : base(addr) { }
        public bool bStartAILogicOnPossess { get { return this[nameof(bStartAILogicOnPossess)].Flag; } set { this[nameof(bStartAILogicOnPossess)].Flag = value; } }
        public bool bStopAILogicOnUnposses { get { return this[nameof(bStopAILogicOnUnposses)].Flag; } set { this[nameof(bStopAILogicOnUnposses)].Flag = value; } }
        public bool bLOSflag { get { return this[nameof(bLOSflag)].Flag; } set { this[nameof(bLOSflag)].Flag = value; } }
        public bool bSkipExtraLOSChecks { get { return this[nameof(bSkipExtraLOSChecks)].Flag; } set { this[nameof(bSkipExtraLOSChecks)].Flag = value; } }
        public bool bAllowStrafe { get { return this[nameof(bAllowStrafe)].Flag; } set { this[nameof(bAllowStrafe)].Flag = value; } }
        public bool bWantsPlayerState { get { return this[nameof(bWantsPlayerState)].Flag; } set { this[nameof(bWantsPlayerState)].Flag = value; } }
        public bool bSetControlRotationFromPawnOrientation { get { return this[nameof(bSetControlRotationFromPawnOrientation)].Flag; } set { this[nameof(bSetControlRotationFromPawnOrientation)].Flag = value; } }
        public PathFollowingComponent PathFollowingComponent { get { return this[nameof(PathFollowingComponent)].As<PathFollowingComponent>(); } set { this["PathFollowingComponent"] = value; } }
        public BrainComponent BrainComponent { get { return this[nameof(BrainComponent)].As<BrainComponent>(); } set { this["BrainComponent"] = value; } }
        public AIPerceptionComponent PerceptionComponent { get { return this[nameof(PerceptionComponent)].As<AIPerceptionComponent>(); } set { this["PerceptionComponent"] = value; } }
        public PawnActionsComponent ActionsComp { get { return this[nameof(ActionsComp)].As<PawnActionsComponent>(); } set { this["ActionsComp"] = value; } }
        public BlackboardComponent Blackboard { get { return this[nameof(Blackboard)].As<BlackboardComponent>(); } set { this["Blackboard"] = value; } }
        public GameplayTasksComponent CachedGameplayTasksComponent { get { return this[nameof(CachedGameplayTasksComponent)].As<GameplayTasksComponent>(); } set { this["CachedGameplayTasksComponent"] = value; } }
        public Object DefaultNavigationFilterClass { get { return this[nameof(DefaultNavigationFilterClass)]; } set { this[nameof(DefaultNavigationFilterClass)] = value; } }
        public Object ReceiveMoveCompleted { get { return this[nameof(ReceiveMoveCompleted)]; } set { this[nameof(ReceiveMoveCompleted)] = value; } }
        public bool UseBlackboard(BlackboardData BlackboardAsset, BlackboardComponent BlackboardComponent) { return Invoke<bool>(nameof(UseBlackboard), BlackboardAsset, BlackboardComponent); }
        public void UnclaimTaskResource(Object ResourceClass) { Invoke(nameof(UnclaimTaskResource), ResourceClass); }
        public void SetPathFollowingComponent(PathFollowingComponent NewPFComponent) { Invoke(nameof(SetPathFollowingComponent), NewPFComponent); }
        public void SetMoveBlockDetection(bool bEnable) { Invoke(nameof(SetMoveBlockDetection), bEnable); }
        public bool RunBehaviorTree(BehaviorTree BTAsset) { return Invoke<bool>(nameof(RunBehaviorTree), BTAsset); }
        public void OnUsingBlackBoard(BlackboardComponent BlackboardComp, BlackboardData BlackboardAsset) { Invoke(nameof(OnUsingBlackBoard), BlackboardComp, BlackboardAsset); }
        public void OnGameplayTaskResourcesClaimed(GameplayResourceSet NewlyClaimed, GameplayResourceSet FreshlyReleased) { Invoke(nameof(OnGameplayTaskResourcesClaimed), NewlyClaimed, FreshlyReleased); }
        public byte MoveToLocation(Vector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, Object FilterClass, bool bAllowPartialPath) { return Invoke<byte>(nameof(MoveToLocation), Dest, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bProjectDestinationToNavigation, bCanStrafe, FilterClass, bAllowPartialPath); }
        public byte MoveToActor(Actor Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, Object FilterClass, bool bAllowPartialPath) { return Invoke<byte>(nameof(MoveToActor), Goal, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bCanStrafe, FilterClass, bAllowPartialPath); }
        public void K2_SetFocus(Actor NewFocus) { Invoke(nameof(K2_SetFocus), NewFocus); }
        public void K2_SetFocalPoint(Vector FP) { Invoke(nameof(K2_SetFocalPoint), FP); }
        public void K2_ClearFocus() { Invoke(nameof(K2_ClearFocus)); }
        public bool HasPartialPath() { return Invoke<bool>(nameof(HasPartialPath)); }
        public PathFollowingComponent GetPathFollowingComponent() { return Invoke<PathFollowingComponent>(nameof(GetPathFollowingComponent)); }
        public byte GetMoveStatus() { return Invoke<byte>(nameof(GetMoveStatus)); }
        public Vector GetImmediateMoveDestination() { return Invoke<Vector>(nameof(GetImmediateMoveDestination)); }
        public Actor GetFocusActor() { return Invoke<Actor>(nameof(GetFocusActor)); }
        public Vector GetFocalPointOnActor(Actor Actor) { return Invoke<Vector>(nameof(GetFocalPointOnActor), Actor); }
        public Vector GetFocalPoint() { return Invoke<Vector>(nameof(GetFocalPoint)); }
        public AIPerceptionComponent GetAIPerceptionComponent() { return Invoke<AIPerceptionComponent>(nameof(GetAIPerceptionComponent)); }
        public void ClaimTaskResource(Object ResourceClass) { Invoke(nameof(ClaimTaskResource), ResourceClass); }
    }
    public class PawnAction : Object
    {
        public PawnAction(nint addr) : base(addr) { }
        public PawnAction ChildAction { get { return this[nameof(ChildAction)].As<PawnAction>(); } set { this["ChildAction"] = value; } }
        public PawnAction ParentAction { get { return this[nameof(ParentAction)].As<PawnAction>(); } set { this["ParentAction"] = value; } }
        public PawnActionsComponent OwnerComponent { get { return this[nameof(OwnerComponent)].As<PawnActionsComponent>(); } set { this["OwnerComponent"] = value; } }
        public Object Instigator { get { return this[nameof(Instigator)].As<Object>(); } set { this["Instigator"] = value; } }
        public BrainComponent BrainComp { get { return this[nameof(BrainComp)].As<BrainComponent>(); } set { this["BrainComp"] = value; } }
        public bool bAllowNewSameClassInstance { get { return this[nameof(bAllowNewSameClassInstance)].Flag; } set { this[nameof(bAllowNewSameClassInstance)].Flag = value; } }
        public bool bReplaceActiveSameClassInstance { get { return this[nameof(bReplaceActiveSameClassInstance)].Flag; } set { this[nameof(bReplaceActiveSameClassInstance)].Flag = value; } }
        public bool bShouldPauseMovement { get { return this[nameof(bShouldPauseMovement)].Flag; } set { this[nameof(bShouldPauseMovement)].Flag = value; } }
        public bool bAlwaysNotifyOnFinished { get { return this[nameof(bAlwaysNotifyOnFinished)].Flag; } set { this[nameof(bAlwaysNotifyOnFinished)].Flag = value; } }
        public bool bDoParallelTick { get { return this[nameof(bDoParallelTick)].Flag; } set { this[nameof(bDoParallelTick)].Flag = value; } }
        public byte GetActionPriority() { return Invoke<byte>(nameof(GetActionPriority)); }
        public void Finish(byte WithResult) { Invoke(nameof(Finish), WithResult); }
        public PawnAction CreateActionInstance(Object WorldContextObject, Object actionClass) { return Invoke<PawnAction>(nameof(CreateActionInstance), WorldContextObject, actionClass); }
    }
    public class PawnAction_BlueprintBase : PawnAction
    {
        public PawnAction_BlueprintBase(nint addr) : base(addr) { }
        public void ActionTickAnyThread(Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ActionTickAnyThread), ControlledPawn, DeltaSeconds); }
        public void ActionTick(Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ActionTick), ControlledPawn, DeltaSeconds); }
        public void ActionStart(Pawn ControlledPawn) { Invoke(nameof(ActionStart), ControlledPawn); }
        public void ActionResume(Pawn ControlledPawn) { Invoke(nameof(ActionResume), ControlledPawn); }
        public void ActionPostTick(Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ActionPostTick), ControlledPawn, DeltaSeconds); }
        public void ActionPause(Pawn ControlledPawn) { Invoke(nameof(ActionPause), ControlledPawn); }
        public void ActionFinished(Pawn ControlledPawn, byte WithResult) { Invoke(nameof(ActionFinished), ControlledPawn, WithResult); }
    }
    public class PawnActionsComponent : ActorComponent
    {
        public PawnActionsComponent(nint addr) : base(addr) { }
        public Pawn ControlledPawn { get { return this[nameof(ControlledPawn)].As<Pawn>(); } set { this["ControlledPawn"] = value; } }
        public Array<PawnActionStack> ActionStacks { get { return new Array<PawnActionStack>(this[nameof(ActionStacks)].Address); } }
        public Array<PawnActionEvent> ActionEvents { get { return new Array<PawnActionEvent>(this[nameof(ActionEvents)].Address); } }
        public PawnAction CurrentAction { get { return this[nameof(CurrentAction)].As<PawnAction>(); } set { this["CurrentAction"] = value; } }
        public bool K2_PushAction(PawnAction NewAction, byte Priority, Object Instigator) { return Invoke<bool>(nameof(K2_PushAction), NewAction, Priority, Instigator); }
        public bool K2_PerformAction(Pawn Pawn, PawnAction action, byte Priority) { return Invoke<bool>(nameof(K2_PerformAction), Pawn, action, Priority); }
        public byte K2_ForceAbortAction(PawnAction ActionToAbort) { return Invoke<byte>(nameof(K2_ForceAbortAction), ActionToAbort); }
        public byte K2_AbortAction(PawnAction ActionToAbort) { return Invoke<byte>(nameof(K2_AbortAction), ActionToAbort); }
    }
    public class PathFollowingComponent : ActorComponent
    {
        public PathFollowingComponent(nint addr) : base(addr) { }
        public NavMovementComponent MovementComp { get { return this[nameof(MovementComp)].As<NavMovementComponent>(); } set { this["MovementComp"] = value; } }
        public NavigationData MyNavData { get { return this[nameof(MyNavData)].As<NavigationData>(); } set { this["MyNavData"] = value; } }
        public void OnNavDataRegistered(NavigationData NavData) { Invoke(nameof(OnNavDataRegistered), NavData); }
        public void OnActorBump(Actor SelfActor, Actor OtherActor, Vector NormalImpulse, HitResult Hit) { Invoke(nameof(OnActorBump), SelfActor, OtherActor, NormalImpulse, Hit); }
        public Vector GetPathDestination() { return Invoke<Vector>(nameof(GetPathDestination)); }
        public byte GetPathActionType() { return Invoke<byte>(nameof(GetPathActionType)); }
    }
    public class AIAsyncTaskBlueprintProxy : Object
    {
        public AIAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFail { get { return this[nameof(OnFail)]; } set { this[nameof(OnFail)] = value; } }
        public void OnMoveCompleted(AIRequestID RequestID, byte MovementResult) { Invoke(nameof(OnMoveCompleted), RequestID, MovementResult); }
    }
    public class AIResourceInterface : Interface
    {
        public AIResourceInterface(nint addr) : base(addr) { }
    }
    public class AISenseBlueprintListener : UserDefinedStruct
    {
        public AISenseBlueprintListener(nint addr) : base(addr) { }
    }
    public class AISenseConfig : Object
    {
        public AISenseConfig(nint addr) : base(addr) { }
        public Color DebugColor { get { return this[nameof(DebugColor)].As<Color>(); } set { this["DebugColor"] = value; } }
        public float MaxAge { get { return this[nameof(MaxAge)].GetValue<float>(); } set { this[nameof(MaxAge)].SetValue<float>(value); } }
        public bool bStartsEnabled { get { return this[nameof(bStartsEnabled)].Flag; } set { this[nameof(bStartsEnabled)].Flag = value; } }
    }
    public class AISenseConfig_Blueprint : AISenseConfig
    {
        public AISenseConfig_Blueprint(nint addr) : base(addr) { }
        public Object Implementation { get { return this[nameof(Implementation)]; } set { this[nameof(Implementation)] = value; } }
    }
    public class AISenseConfig_Hearing : AISenseConfig
    {
        public AISenseConfig_Hearing(nint addr) : base(addr) { }
        public Object Implementation { get { return this[nameof(Implementation)]; } set { this[nameof(Implementation)] = value; } }
        public float HearingRange { get { return this[nameof(HearingRange)].GetValue<float>(); } set { this[nameof(HearingRange)].SetValue<float>(value); } }
        public float LoSHearingRange { get { return this[nameof(LoSHearingRange)].GetValue<float>(); } set { this[nameof(LoSHearingRange)].SetValue<float>(value); } }
        public bool bUseLoSHearing { get { return this[nameof(bUseLoSHearing)].Flag; } set { this[nameof(bUseLoSHearing)].Flag = value; } }
        public AISenseAffiliationFilter DetectionByAffiliation { get { return this[nameof(DetectionByAffiliation)].As<AISenseAffiliationFilter>(); } set { this["DetectionByAffiliation"] = value; } }
    }
    public class AISenseConfig_Prediction : AISenseConfig
    {
        public AISenseConfig_Prediction(nint addr) : base(addr) { }
    }
    public class AISenseConfig_Sight : AISenseConfig
    {
        public AISenseConfig_Sight(nint addr) : base(addr) { }
        public Object Implementation { get { return this[nameof(Implementation)]; } set { this[nameof(Implementation)] = value; } }
        public float SightRadius { get { return this[nameof(SightRadius)].GetValue<float>(); } set { this[nameof(SightRadius)].SetValue<float>(value); } }
        public float LoseSightRadius { get { return this[nameof(LoseSightRadius)].GetValue<float>(); } set { this[nameof(LoseSightRadius)].SetValue<float>(value); } }
        public float PeripheralVisionAngleDegrees { get { return this[nameof(PeripheralVisionAngleDegrees)].GetValue<float>(); } set { this[nameof(PeripheralVisionAngleDegrees)].SetValue<float>(value); } }
        public AISenseAffiliationFilter DetectionByAffiliation { get { return this[nameof(DetectionByAffiliation)].As<AISenseAffiliationFilter>(); } set { this["DetectionByAffiliation"] = value; } }
        public float AutoSuccessRangeFromLastSeenLocation { get { return this[nameof(AutoSuccessRangeFromLastSeenLocation)].GetValue<float>(); } set { this[nameof(AutoSuccessRangeFromLastSeenLocation)].SetValue<float>(value); } }
        public float PointOfViewBackwardOffset { get { return this[nameof(PointOfViewBackwardOffset)].GetValue<float>(); } set { this[nameof(PointOfViewBackwardOffset)].SetValue<float>(value); } }
        public float NearClippingRadius { get { return this[nameof(NearClippingRadius)].GetValue<float>(); } set { this[nameof(NearClippingRadius)].SetValue<float>(value); } }
    }
    public class AISenseConfig_Team : AISenseConfig
    {
        public AISenseConfig_Team(nint addr) : base(addr) { }
    }
    public class AISenseConfig_Touch : AISenseConfig
    {
        public AISenseConfig_Touch(nint addr) : base(addr) { }
    }
    public class AISenseEvent : Object
    {
        public AISenseEvent(nint addr) : base(addr) { }
    }
    public class AISenseEvent_Damage : AISenseEvent
    {
        public AISenseEvent_Damage(nint addr) : base(addr) { }
        public AIDamageEvent Event { get { return this[nameof(Event)].As<AIDamageEvent>(); } set { this["Event"] = value; } }
    }
    public class AISenseEvent_Hearing : AISenseEvent
    {
        public AISenseEvent_Hearing(nint addr) : base(addr) { }
        public AINoiseEvent Event { get { return this[nameof(Event)].As<AINoiseEvent>(); } set { this["Event"] = value; } }
    }
    public class CrowdAgentInterface : Interface
    {
        public CrowdAgentInterface(nint addr) : base(addr) { }
    }
    public class EnvQueryTypes : Object
    {
        public EnvQueryTypes(nint addr) : base(addr) { }
    }
    public class EQSQueryResultSourceInterface : Interface
    {
        public EQSQueryResultSourceInterface(nint addr) : base(addr) { }
    }
    public class GenericTeamAgentInterface : Interface
    {
        public GenericTeamAgentInterface(nint addr) : base(addr) { }
    }
    public class PawnAction_Move : PawnAction
    {
        public PawnAction_Move(nint addr) : base(addr) { }
        public Actor GoalActor { get { return this[nameof(GoalActor)].As<Actor>(); } set { this["GoalActor"] = value; } }
        public Vector GoalLocation { get { return this[nameof(GoalLocation)].As<Vector>(); } set { this["GoalLocation"] = value; } }
        public float AcceptableRadius { get { return this[nameof(AcceptableRadius)].GetValue<float>(); } set { this[nameof(AcceptableRadius)].SetValue<float>(value); } }
        public Object FilterClass { get { return this[nameof(FilterClass)]; } set { this[nameof(FilterClass)] = value; } }
        public bool bAllowStrafe { get { return this[nameof(bAllowStrafe)].Flag; } set { this[nameof(bAllowStrafe)].Flag = value; } }
        public bool bFinishOnOverlap { get { return this[nameof(bFinishOnOverlap)].Flag; } set { this[nameof(bFinishOnOverlap)].Flag = value; } }
        public bool bUsePathfinding { get { return this[nameof(bUsePathfinding)].Flag; } set { this[nameof(bUsePathfinding)].Flag = value; } }
        public bool bAllowPartialPath { get { return this[nameof(bAllowPartialPath)].Flag; } set { this[nameof(bAllowPartialPath)].Flag = value; } }
        public bool bProjectGoalToNavigation { get { return this[nameof(bProjectGoalToNavigation)].Flag; } set { this[nameof(bProjectGoalToNavigation)].Flag = value; } }
        public bool bUpdatePathToGoal { get { return this[nameof(bUpdatePathToGoal)].Flag; } set { this[nameof(bUpdatePathToGoal)].Flag = value; } }
        public bool bAbortSubActionOnPathChange { get { return this[nameof(bAbortSubActionOnPathChange)].Flag; } set { this[nameof(bAbortSubActionOnPathChange)].Flag = value; } }
    }
    public class PawnAction_Repeat : PawnAction
    {
        public PawnAction_Repeat(nint addr) : base(addr) { }
        public PawnAction ActionToRepeat { get { return this[nameof(ActionToRepeat)].As<PawnAction>(); } set { this["ActionToRepeat"] = value; } }
        public PawnAction RecentActionCopy { get { return this[nameof(RecentActionCopy)].As<PawnAction>(); } set { this["RecentActionCopy"] = value; } }
        public byte ChildFailureHandlingMode { get { return this[nameof(ChildFailureHandlingMode)].GetValue<byte>(); } set { this[nameof(ChildFailureHandlingMode)].SetValue<byte>(value); } }
    }
    public class PawnAction_Sequence : PawnAction
    {
        public PawnAction_Sequence(nint addr) : base(addr) { }
        public Array<PawnAction> ActionSequence { get { return new Array<PawnAction>(this[nameof(ActionSequence)].Address); } }
        public byte ChildFailureHandlingMode { get { return this[nameof(ChildFailureHandlingMode)].GetValue<byte>(); } set { this[nameof(ChildFailureHandlingMode)].SetValue<byte>(value); } }
        public PawnAction RecentActionCopy { get { return this[nameof(RecentActionCopy)].As<PawnAction>(); } set { this["RecentActionCopy"] = value; } }
    }
    public class PawnAction_Wait : PawnAction
    {
        public PawnAction_Wait(nint addr) : base(addr) { }
        public float TimeToWait { get { return this[nameof(TimeToWait)].GetValue<float>(); } set { this[nameof(TimeToWait)].SetValue<float>(value); } }
    }
    public class AIResource_Movement : GameplayTaskResource
    {
        public AIResource_Movement(nint addr) : base(addr) { }
    }
    public class AIResource_Logic : GameplayTaskResource
    {
        public AIResource_Logic(nint addr) : base(addr) { }
    }
    public class AISubsystem : Object
    {
        public AISubsystem(nint addr) : base(addr) { }
        public AISystem AISystem { get { return this[nameof(AISystem)].As<AISystem>(); } set { this["AISystem"] = value; } }
    }
    public class AISystem : AISystemBase
    {
        public AISystem(nint addr) : base(addr) { }
        public SoftClassPath PerceptionSystemClassName { get { return this[nameof(PerceptionSystemClassName)].As<SoftClassPath>(); } set { this["PerceptionSystemClassName"] = value; } }
        public SoftClassPath HotSpotManagerClassName { get { return this[nameof(HotSpotManagerClassName)].As<SoftClassPath>(); } set { this["HotSpotManagerClassName"] = value; } }
        public SoftClassPath EnvQueryManagerClassName { get { return this[nameof(EnvQueryManagerClassName)].As<SoftClassPath>(); } set { this["EnvQueryManagerClassName"] = value; } }
        public float AcceptanceRadius { get { return this[nameof(AcceptanceRadius)].GetValue<float>(); } set { this[nameof(AcceptanceRadius)].SetValue<float>(value); } }
        public float PathfollowingRegularPathPointAcceptanceRadius { get { return this[nameof(PathfollowingRegularPathPointAcceptanceRadius)].GetValue<float>(); } set { this[nameof(PathfollowingRegularPathPointAcceptanceRadius)].SetValue<float>(value); } }
        public float PathfollowingNavLinkAcceptanceRadius { get { return this[nameof(PathfollowingNavLinkAcceptanceRadius)].GetValue<float>(); } set { this[nameof(PathfollowingNavLinkAcceptanceRadius)].SetValue<float>(value); } }
        public bool bFinishMoveOnGoalOverlap { get { return this[nameof(bFinishMoveOnGoalOverlap)].Flag; } set { this[nameof(bFinishMoveOnGoalOverlap)].Flag = value; } }
        public bool bAcceptPartialPaths { get { return this[nameof(bAcceptPartialPaths)].Flag; } set { this[nameof(bAcceptPartialPaths)].Flag = value; } }
        public bool bAllowStrafing { get { return this[nameof(bAllowStrafing)].Flag; } set { this[nameof(bAllowStrafing)].Flag = value; } }
        public bool bEnableBTAITasks { get { return this[nameof(bEnableBTAITasks)].Flag; } set { this[nameof(bEnableBTAITasks)].Flag = value; } }
        public bool bAllowControllersAsEQSQuerier { get { return this[nameof(bAllowControllersAsEQSQuerier)].Flag; } set { this[nameof(bAllowControllersAsEQSQuerier)].Flag = value; } }
        public bool bEnableDebuggerPlugin { get { return this[nameof(bEnableDebuggerPlugin)].Flag; } set { this[nameof(bEnableDebuggerPlugin)].Flag = value; } }
        public bool bForgetStaleActors { get { return this[nameof(bForgetStaleActors)].Flag; } set { this[nameof(bForgetStaleActors)].Flag = value; } }
        public bool bAddBlackboardSelfKey { get { return this[nameof(bAddBlackboardSelfKey)].Flag; } set { this[nameof(bAddBlackboardSelfKey)].Flag = value; } }
        public bool bClearBBEntryOnBTEQSFail { get { return this[nameof(bClearBBEntryOnBTEQSFail)].Flag; } set { this[nameof(bClearBBEntryOnBTEQSFail)].Flag = value; } }
        public byte DefaultSightCollisionChannel { get { return this[nameof(DefaultSightCollisionChannel)].GetValue<byte>(); } set { this[nameof(DefaultSightCollisionChannel)].SetValue<byte>(value); } }
        public BehaviorTreeManager BehaviorTreeManager { get { return this[nameof(BehaviorTreeManager)].As<BehaviorTreeManager>(); } set { this["BehaviorTreeManager"] = value; } }
        public EnvQueryManager EnvironmentQueryManager { get { return this[nameof(EnvironmentQueryManager)].As<EnvQueryManager>(); } set { this["EnvironmentQueryManager"] = value; } }
        public AIPerceptionSystem PerceptionSystem { get { return this[nameof(PerceptionSystem)].As<AIPerceptionSystem>(); } set { this["PerceptionSystem"] = value; } }
        public Array<AIAsyncTaskBlueprintProxy> AllProxyObjects { get { return new Array<AIAsyncTaskBlueprintProxy>(this[nameof(AllProxyObjects)].Address); } }
        public AIHotSpotManager HotSpotManager { get { return this[nameof(HotSpotManager)].As<AIHotSpotManager>(); } set { this["HotSpotManager"] = value; } }
        public NavLocalGridManager NavLocalGrids { get { return this[nameof(NavLocalGrids)].As<NavLocalGridManager>(); } set { this["NavLocalGrids"] = value; } }
        public void AILoggingVerbose() { Invoke(nameof(AILoggingVerbose)); }
        public void AIIgnorePlayers() { Invoke(nameof(AIIgnorePlayers)); }
    }
    public class BehaviorTree : Object
    {
        public BehaviorTree(nint addr) : base(addr) { }
        public BTCompositeNode RootNode { get { return this[nameof(RootNode)].As<BTCompositeNode>(); } set { this["RootNode"] = value; } }
        public BlackboardData BlackboardAsset { get { return this[nameof(BlackboardAsset)].As<BlackboardData>(); } set { this["BlackboardAsset"] = value; } }
        public Array<BTDecorator> RootDecorators { get { return new Array<BTDecorator>(this[nameof(RootDecorators)].Address); } }
        public Array<BTDecoratorLogic> RootDecoratorOps { get { return new Array<BTDecoratorLogic>(this[nameof(RootDecoratorOps)].Address); } }
    }
    public class BrainComponent : ActorComponent
    {
        public BrainComponent(nint addr) : base(addr) { }
        public BlackboardComponent BlackboardComp { get { return this[nameof(BlackboardComp)].As<BlackboardComponent>(); } set { this["BlackboardComp"] = value; } }
        public AIController AIOwner { get { return this[nameof(AIOwner)].As<AIController>(); } set { this["AIOwner"] = value; } }
        public void StopLogic(Object Reason) { Invoke(nameof(StopLogic), Reason); }
        public void StartLogic() { Invoke(nameof(StartLogic)); }
        public void RestartLogic() { Invoke(nameof(RestartLogic)); }
        public bool IsRunning() { return Invoke<bool>(nameof(IsRunning)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
    }
    public class BehaviorTreeComponent : BrainComponent
    {
        public BehaviorTreeComponent(nint addr) : base(addr) { }
        public Array<BTNode> NodeInstances { get { return new Array<BTNode>(this[nameof(NodeInstances)].Address); } }
        public BehaviorTree DefaultBehaviorTreeAsset { get { return this[nameof(DefaultBehaviorTreeAsset)].As<BehaviorTree>(); } set { this["DefaultBehaviorTreeAsset"] = value; } }
        public void SetDynamicSubtree(GameplayTag InjectTag, BehaviorTree BehaviorAsset) { Invoke(nameof(SetDynamicSubtree), InjectTag, BehaviorAsset); }
        public float GetTagCooldownEndTime(GameplayTag CooldownTag) { return Invoke<float>(nameof(GetTagCooldownEndTime), CooldownTag); }
        public void AddCooldownTagDuration(GameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration) { Invoke(nameof(AddCooldownTagDuration), CooldownTag, CooldownDuration, bAddToExistingDuration); }
    }
    public class BehaviorTreeManager : Object
    {
        public BehaviorTreeManager(nint addr) : base(addr) { }
        public int MaxDebuggerSteps { get { return this[nameof(MaxDebuggerSteps)].GetValue<int>(); } set { this[nameof(MaxDebuggerSteps)].SetValue<int>(value); } }
        public Array<BehaviorTreeTemplateInfo> LoadedTemplates { get { return new Array<BehaviorTreeTemplateInfo>(this[nameof(LoadedTemplates)].Address); } }
        public Array<BehaviorTreeComponent> ActiveComponents { get { return new Array<BehaviorTreeComponent>(this[nameof(ActiveComponents)].Address); } }
    }
    public class BehaviorTreeTypes : Object
    {
        public BehaviorTreeTypes(nint addr) : base(addr) { }
    }
    public class BlackboardAssetProvider : Interface
    {
        public BlackboardAssetProvider(nint addr) : base(addr) { }
        public BlackboardData GetBlackboardAsset() { return Invoke<BlackboardData>(nameof(GetBlackboardAsset)); }
    }
    public class BlackboardComponent : ActorComponent
    {
        public BlackboardComponent(nint addr) : base(addr) { }
        public BrainComponent BrainComp { get { return this[nameof(BrainComp)].As<BrainComponent>(); } set { this["BrainComp"] = value; } }
        public BlackboardData DefaultBlackboardAsset { get { return this[nameof(DefaultBlackboardAsset)].As<BlackboardData>(); } set { this["DefaultBlackboardAsset"] = value; } }
        public BlackboardData BlackboardAsset { get { return this[nameof(BlackboardAsset)].As<BlackboardData>(); } set { this["BlackboardAsset"] = value; } }
        public Array<BlackboardKeyType> KeyInstances { get { return new Array<BlackboardKeyType>(this[nameof(KeyInstances)].Address); } }
        public void SetValueAsVector(Object KeyName, Vector VectorValue) { Invoke(nameof(SetValueAsVector), KeyName, VectorValue); }
        public void SetValueAsString(Object KeyName, Object StringValue) { Invoke(nameof(SetValueAsString), KeyName, StringValue); }
        public void SetValueAsRotator(Object KeyName, Rotator VectorValue) { Invoke(nameof(SetValueAsRotator), KeyName, VectorValue); }
        public void SetValueAsObject(Object KeyName, Object ObjectValue) { Invoke(nameof(SetValueAsObject), KeyName, ObjectValue); }
        public void SetValueAsName(Object KeyName, Object NameValue) { Invoke(nameof(SetValueAsName), KeyName, NameValue); }
        public void SetValueAsInt(Object KeyName, int IntValue) { Invoke(nameof(SetValueAsInt), KeyName, IntValue); }
        public void SetValueAsFloat(Object KeyName, float FloatValue) { Invoke(nameof(SetValueAsFloat), KeyName, FloatValue); }
        public void SetValueAsEnum(Object KeyName, byte EnumValue) { Invoke(nameof(SetValueAsEnum), KeyName, EnumValue); }
        public void SetValueAsClass(Object KeyName, Object ClassValue) { Invoke(nameof(SetValueAsClass), KeyName, ClassValue); }
        public void SetValueAsBool(Object KeyName, bool BoolValue) { Invoke(nameof(SetValueAsBool), KeyName, BoolValue); }
        public bool IsVectorValueSet(Object KeyName) { return Invoke<bool>(nameof(IsVectorValueSet), KeyName); }
        public Vector GetValueAsVector(Object KeyName) { return Invoke<Vector>(nameof(GetValueAsVector), KeyName); }
        public Object GetValueAsString(Object KeyName) { return Invoke<Object>(nameof(GetValueAsString), KeyName); }
        public Rotator GetValueAsRotator(Object KeyName) { return Invoke<Rotator>(nameof(GetValueAsRotator), KeyName); }
        public Object GetValueAsObject(Object KeyName) { return Invoke<Object>(nameof(GetValueAsObject), KeyName); }
        public Object GetValueAsName(Object KeyName) { return Invoke<Object>(nameof(GetValueAsName), KeyName); }
        public int GetValueAsInt(Object KeyName) { return Invoke<int>(nameof(GetValueAsInt), KeyName); }
        public float GetValueAsFloat(Object KeyName) { return Invoke<float>(nameof(GetValueAsFloat), KeyName); }
        public byte GetValueAsEnum(Object KeyName) { return Invoke<byte>(nameof(GetValueAsEnum), KeyName); }
        public Object GetValueAsClass(Object KeyName) { return Invoke<Object>(nameof(GetValueAsClass), KeyName); }
        public bool GetValueAsBool(Object KeyName) { return Invoke<bool>(nameof(GetValueAsBool), KeyName); }
        public bool GetRotationFromEntry(Object KeyName, Rotator ResultRotation) { return Invoke<bool>(nameof(GetRotationFromEntry), KeyName, ResultRotation); }
        public bool GetLocationFromEntry(Object KeyName, Vector ResultLocation) { return Invoke<bool>(nameof(GetLocationFromEntry), KeyName, ResultLocation); }
        public void ClearValue(Object KeyName) { Invoke(nameof(ClearValue), KeyName); }
    }
    public class BlackboardData : DataAsset
    {
        public BlackboardData(nint addr) : base(addr) { }
        public BlackboardData Parent { get { return this[nameof(Parent)].As<BlackboardData>(); } set { this["Parent"] = value; } }
        public Array<BlackboardEntry> Keys { get { return new Array<BlackboardEntry>(this[nameof(Keys)].Address); } }
        public bool bHasSynchronizedKeys { get { return this[nameof(bHasSynchronizedKeys)].Flag; } set { this[nameof(bHasSynchronizedKeys)].Flag = value; } }
    }
    public class BlackboardKeyType : Object
    {
        public BlackboardKeyType(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_Bool : BlackboardKeyType
    {
        public BlackboardKeyType_Bool(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_Class : BlackboardKeyType
    {
        public BlackboardKeyType_Class(nint addr) : base(addr) { }
        public Object BaseClass { get { return this[nameof(BaseClass)].As<Object>(); } set { this["BaseClass"] = value; } } // ClassPtrProperty
    }
    public class BlackboardKeyType_Enum : BlackboardKeyType
    {
        public BlackboardKeyType_Enum(nint addr) : base(addr) { }
        public Enum EnumType { get { return this[nameof(EnumType)].As<Enum>(); } set { this["EnumType"] = value; } }
        public Object EnumName { get { return this[nameof(EnumName)]; } set { this[nameof(EnumName)] = value; } }
        public bool bIsEnumNameValid { get { return this[nameof(bIsEnumNameValid)].Flag; } set { this[nameof(bIsEnumNameValid)].Flag = value; } }
    }
    public class BlackboardKeyType_Float : BlackboardKeyType
    {
        public BlackboardKeyType_Float(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_Int : BlackboardKeyType
    {
        public BlackboardKeyType_Int(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_Name : BlackboardKeyType
    {
        public BlackboardKeyType_Name(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_NativeEnum : BlackboardKeyType
    {
        public BlackboardKeyType_NativeEnum(nint addr) : base(addr) { }
        public Object EnumName { get { return this[nameof(EnumName)]; } set { this[nameof(EnumName)] = value; } }
        public Enum EnumType { get { return this[nameof(EnumType)].As<Enum>(); } set { this["EnumType"] = value; } }
    }
    public class BlackboardKeyType_Object : BlackboardKeyType
    {
        public BlackboardKeyType_Object(nint addr) : base(addr) { }
        public Object BaseClass { get { return this[nameof(BaseClass)].As<Object>(); } set { this["BaseClass"] = value; } } // ClassPtrProperty
    }
    public class BlackboardKeyType_Rotator : BlackboardKeyType
    {
        public BlackboardKeyType_Rotator(nint addr) : base(addr) { }
    }
    public class BlackboardKeyType_String : BlackboardKeyType
    {
        public BlackboardKeyType_String(nint addr) : base(addr) { }
        public Object StringValue { get { return this[nameof(StringValue)]; } set { this[nameof(StringValue)] = value; } }
    }
    public class BlackboardKeyType_Vector : BlackboardKeyType
    {
        public BlackboardKeyType_Vector(nint addr) : base(addr) { }
    }
    public class BTNode : Object
    {
        public BTNode(nint addr) : base(addr) { }
        public Object NodeName { get { return this[nameof(NodeName)]; } set { this[nameof(NodeName)] = value; } }
        public BehaviorTree TreeAsset { get { return this[nameof(TreeAsset)].As<BehaviorTree>(); } set { this["TreeAsset"] = value; } }
        public BTCompositeNode ParentNode { get { return this[nameof(ParentNode)].As<BTCompositeNode>(); } set { this["ParentNode"] = value; } }
    }
    public class BTAuxiliaryNode : BTNode
    {
        public BTAuxiliaryNode(nint addr) : base(addr) { }
    }
    public class BTCompositeNode : BTNode
    {
        public BTCompositeNode(nint addr) : base(addr) { }
        public Array<BTCompositeChild> Children { get { return new Array<BTCompositeChild>(this[nameof(Children)].Address); } }
        public Array<BTService> Services { get { return new Array<BTService>(this[nameof(Services)].Address); } }
        public bool bApplyDecoratorScope { get { return this[nameof(bApplyDecoratorScope)].Flag; } set { this[nameof(bApplyDecoratorScope)].Flag = value; } }
    }
    public class BTDecorator : BTAuxiliaryNode
    {
        public BTDecorator(nint addr) : base(addr) { }
        public bool bInverseCondition { get { return this[nameof(bInverseCondition)].Flag; } set { this[nameof(bInverseCondition)].Flag = value; } }
        public byte FlowAbortMode { get { return this[nameof(FlowAbortMode)].GetValue<byte>(); } set { this[nameof(FlowAbortMode)].SetValue<byte>(value); } }
    }
    public class BTFunctionLibrary : BlueprintFunctionLibrary
    {
        public BTFunctionLibrary(nint addr) : base(addr) { }
        public void StopUsingExternalEvent(BTNode NodeOwner) { Invoke(nameof(StopUsingExternalEvent), NodeOwner); }
        public void StartUsingExternalEvent(BTNode NodeOwner, Actor OwningActor) { Invoke(nameof(StartUsingExternalEvent), NodeOwner, OwningActor); }
        public void SetBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key, Vector Value) { Invoke(nameof(SetBlackboardValueAsVector), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsString(BTNode NodeOwner, BlackboardKeySelector Key, Object Value) { Invoke(nameof(SetBlackboardValueAsString), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsRotator(BTNode NodeOwner, BlackboardKeySelector Key, Rotator Value) { Invoke(nameof(SetBlackboardValueAsRotator), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsObject(BTNode NodeOwner, BlackboardKeySelector Key, Object Value) { Invoke(nameof(SetBlackboardValueAsObject), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsName(BTNode NodeOwner, BlackboardKeySelector Key, Object Value) { Invoke(nameof(SetBlackboardValueAsName), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsInt(BTNode NodeOwner, BlackboardKeySelector Key, int Value) { Invoke(nameof(SetBlackboardValueAsInt), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsFloat(BTNode NodeOwner, BlackboardKeySelector Key, float Value) { Invoke(nameof(SetBlackboardValueAsFloat), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsEnum(BTNode NodeOwner, BlackboardKeySelector Key, byte Value) { Invoke(nameof(SetBlackboardValueAsEnum), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsClass(BTNode NodeOwner, BlackboardKeySelector Key, Object Value) { Invoke(nameof(SetBlackboardValueAsClass), NodeOwner, Key, Value); }
        public void SetBlackboardValueAsBool(BTNode NodeOwner, BlackboardKeySelector Key, bool Value) { Invoke(nameof(SetBlackboardValueAsBool), NodeOwner, Key, Value); }
        public BlackboardComponent GetOwnersBlackboard(BTNode NodeOwner) { return Invoke<BlackboardComponent>(nameof(GetOwnersBlackboard), NodeOwner); }
        public BehaviorTreeComponent GetOwnerComponent(BTNode NodeOwner) { return Invoke<BehaviorTreeComponent>(nameof(GetOwnerComponent), NodeOwner); }
        public Vector GetBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Vector>(nameof(GetBlackboardValueAsVector), NodeOwner, Key); }
        public Object GetBlackboardValueAsString(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Object>(nameof(GetBlackboardValueAsString), NodeOwner, Key); }
        public Rotator GetBlackboardValueAsRotator(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Rotator>(nameof(GetBlackboardValueAsRotator), NodeOwner, Key); }
        public Object GetBlackboardValueAsObject(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Object>(nameof(GetBlackboardValueAsObject), NodeOwner, Key); }
        public Object GetBlackboardValueAsName(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Object>(nameof(GetBlackboardValueAsName), NodeOwner, Key); }
        public int GetBlackboardValueAsInt(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<int>(nameof(GetBlackboardValueAsInt), NodeOwner, Key); }
        public float GetBlackboardValueAsFloat(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<float>(nameof(GetBlackboardValueAsFloat), NodeOwner, Key); }
        public byte GetBlackboardValueAsEnum(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<byte>(nameof(GetBlackboardValueAsEnum), NodeOwner, Key); }
        public Object GetBlackboardValueAsClass(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Object>(nameof(GetBlackboardValueAsClass), NodeOwner, Key); }
        public bool GetBlackboardValueAsBool(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<bool>(nameof(GetBlackboardValueAsBool), NodeOwner, Key); }
        public Actor GetBlackboardValueAsActor(BTNode NodeOwner, BlackboardKeySelector Key) { return Invoke<Actor>(nameof(GetBlackboardValueAsActor), NodeOwner, Key); }
        public void ClearBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key) { Invoke(nameof(ClearBlackboardValueAsVector), NodeOwner, Key); }
        public void ClearBlackboardValue(BTNode NodeOwner, BlackboardKeySelector Key) { Invoke(nameof(ClearBlackboardValue), NodeOwner, Key); }
    }
    public class BTService : BTAuxiliaryNode
    {
        public BTService(nint addr) : base(addr) { }
        public float Interval { get { return this[nameof(Interval)].GetValue<float>(); } set { this[nameof(Interval)].SetValue<float>(value); } }
        public float RandomDeviation { get { return this[nameof(RandomDeviation)].GetValue<float>(); } set { this[nameof(RandomDeviation)].SetValue<float>(value); } }
        public bool bCallTickOnSearchStart { get { return this[nameof(bCallTickOnSearchStart)].Flag; } set { this[nameof(bCallTickOnSearchStart)].Flag = value; } }
        public bool bRestartTimerOnEachActivation { get { return this[nameof(bRestartTimerOnEachActivation)].Flag; } set { this[nameof(bRestartTimerOnEachActivation)].Flag = value; } }
    }
    public class BTTaskNode : BTNode
    {
        public BTTaskNode(nint addr) : base(addr) { }
        public Array<BTService> Services { get { return new Array<BTService>(this[nameof(Services)].Address); } }
        public bool bIgnoreRestartSelf { get { return this[nameof(bIgnoreRestartSelf)].Flag; } set { this[nameof(bIgnoreRestartSelf)].Flag = value; } }
    }
    public class BTComposite_Selector : BTCompositeNode
    {
        public BTComposite_Selector(nint addr) : base(addr) { }
    }
    public class BTComposite_Sequence : BTCompositeNode
    {
        public BTComposite_Sequence(nint addr) : base(addr) { }
    }
    public class BTComposite_SimpleParallel : BTCompositeNode
    {
        public BTComposite_SimpleParallel(nint addr) : base(addr) { }
        public byte FinishMode { get { return this[nameof(FinishMode)].GetValue<byte>(); } set { this[nameof(FinishMode)].SetValue<byte>(value); } }
    }
    public class BTDecorator_BlackboardBase : BTDecorator
    {
        public BTDecorator_BlackboardBase(nint addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKey { get { return this[nameof(BlackboardKey)].As<BlackboardKeySelector>(); } set { this["BlackboardKey"] = value; } }
    }
    public class BTDecorator_Blackboard : BTDecorator_BlackboardBase
    {
        public BTDecorator_Blackboard(nint addr) : base(addr) { }
        public int IntValue { get { return this[nameof(IntValue)].GetValue<int>(); } set { this[nameof(IntValue)].SetValue<int>(value); } }
        //public float FloatValue { get { return this[nameof(FloatValue)].GetValue<float>(); } set { this[nameof(FloatValue)].SetValue<float>(value); } }
        public Object StringValue { get { return this[nameof(StringValue)]; } set { this[nameof(StringValue)] = value; } }
        public Object CachedDescription { get { return this[nameof(CachedDescription)]; } set { this[nameof(CachedDescription)] = value; } }
        public byte operationType { get { return this[nameof(operationType)].GetValue<byte>(); } set { this[nameof(operationType)].SetValue<byte>(value); } }
        public byte NotifyObserver { get { return this[nameof(NotifyObserver)].GetValue<byte>(); } set { this[nameof(NotifyObserver)].SetValue<byte>(value); } }
    }
    public class BTDecorator_BlueprintBase : BTDecorator
    {
        public BTDecorator_BlueprintBase(nint addr) : base(addr) { }
        public AIController AIOwner { get { return this[nameof(AIOwner)].As<AIController>(); } set { this["AIOwner"] = value; } }
        public Actor ActorOwner { get { return this[nameof(ActorOwner)].As<Actor>(); } set { this["ActorOwner"] = value; } }
        public Array<Object> ObservedKeyNames { get { return new Array<Object>(this[nameof(ObservedKeyNames)].Address); } }
        public bool bShowPropertyDetails { get { return this[nameof(bShowPropertyDetails)].Flag; } set { this[nameof(bShowPropertyDetails)].Flag = value; } }
        public bool bCheckConditionOnlyBlackBoardChanges { get { return this[nameof(bCheckConditionOnlyBlackBoardChanges)].Flag; } set { this[nameof(bCheckConditionOnlyBlackBoardChanges)].Flag = value; } }
        public bool bIsObservingBB { get { return this[nameof(bIsObservingBB)].Flag; } set { this[nameof(bIsObservingBB)].Flag = value; } }
        public void ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ReceiveTickAI), OwnerController, ControlledPawn, DeltaSeconds); }
        public void ReceiveTick(Actor ownerActor, float DeltaSeconds) { Invoke(nameof(ReceiveTick), ownerActor, DeltaSeconds); }
        public void ReceiveObserverDeactivatedAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveObserverDeactivatedAI), OwnerController, ControlledPawn); }
        public void ReceiveObserverDeactivated(Actor ownerActor) { Invoke(nameof(ReceiveObserverDeactivated), ownerActor); }
        public void ReceiveObserverActivatedAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveObserverActivatedAI), OwnerController, ControlledPawn); }
        public void ReceiveObserverActivated(Actor ownerActor) { Invoke(nameof(ReceiveObserverActivated), ownerActor); }
        public void ReceiveExecutionStartAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveExecutionStartAI), OwnerController, ControlledPawn); }
        public void ReceiveExecutionStart(Actor ownerActor) { Invoke(nameof(ReceiveExecutionStart), ownerActor); }
        public void ReceiveExecutionFinishAI(AIController OwnerController, Pawn ControlledPawn, byte NodeResult) { Invoke(nameof(ReceiveExecutionFinishAI), OwnerController, ControlledPawn, NodeResult); }
        public void ReceiveExecutionFinish(Actor ownerActor, byte NodeResult) { Invoke(nameof(ReceiveExecutionFinish), ownerActor, NodeResult); }
        public bool PerformConditionCheckAI(AIController OwnerController, Pawn ControlledPawn) { return Invoke<bool>(nameof(PerformConditionCheckAI), OwnerController, ControlledPawn); }
        public bool PerformConditionCheck(Actor ownerActor) { return Invoke<bool>(nameof(PerformConditionCheck), ownerActor); }
        public bool IsDecoratorObserverActive() { return Invoke<bool>(nameof(IsDecoratorObserverActive)); }
        public bool IsDecoratorExecutionActive() { return Invoke<bool>(nameof(IsDecoratorExecutionActive)); }
    }
    public class BTDecorator_CheckGameplayTagsOnActor : BTDecorator
    {
        public BTDecorator_CheckGameplayTagsOnActor(nint addr) : base(addr) { }
        public BlackboardKeySelector ActorToCheck { get { return this[nameof(ActorToCheck)].As<BlackboardKeySelector>(); } set { this["ActorToCheck"] = value; } }
        public EGameplayContainerMatchType TagsToMatch { get { return (EGameplayContainerMatchType)this[nameof(TagsToMatch)].GetValue<int>(); } set { this[nameof(TagsToMatch)].SetValue<int>((int)value); } }
        public GameplayTagContainer GameplayTags { get { return this[nameof(GameplayTags)].As<GameplayTagContainer>(); } set { this["GameplayTags"] = value; } }
        public Object CachedDescription { get { return this[nameof(CachedDescription)]; } set { this[nameof(CachedDescription)] = value; } }
    }
    public class BTDecorator_CompareBBEntries : BTDecorator
    {
        public BTDecorator_CompareBBEntries(nint addr) : base(addr) { }
        public byte Operator { get { return this[nameof(Operator)].GetValue<byte>(); } set { this[nameof(Operator)].SetValue<byte>(value); } }
        public BlackboardKeySelector BlackboardKeyA { get { return this[nameof(BlackboardKeyA)].As<BlackboardKeySelector>(); } set { this["BlackboardKeyA"] = value; } }
        public BlackboardKeySelector BlackboardKeyB { get { return this[nameof(BlackboardKeyB)].As<BlackboardKeySelector>(); } set { this["BlackboardKeyB"] = value; } }
    }
    public class BTDecorator_ConditionalLoop : BTDecorator_Blackboard
    {
        public BTDecorator_ConditionalLoop(nint addr) : base(addr) { }
    }
    public class BTDecorator_ConeCheck : BTDecorator
    {
        public BTDecorator_ConeCheck(nint addr) : base(addr) { }
        public float ConeHalfAngle { get { return this[nameof(ConeHalfAngle)].GetValue<float>(); } set { this[nameof(ConeHalfAngle)].SetValue<float>(value); } }
        public BlackboardKeySelector ConeOrigin { get { return this[nameof(ConeOrigin)].As<BlackboardKeySelector>(); } set { this["ConeOrigin"] = value; } }
        public BlackboardKeySelector ConeDirection { get { return this[nameof(ConeDirection)].As<BlackboardKeySelector>(); } set { this["ConeDirection"] = value; } }
        public BlackboardKeySelector Observed { get { return this[nameof(Observed)].As<BlackboardKeySelector>(); } set { this["Observed"] = value; } }
    }
    public class BTDecorator_Cooldown : BTDecorator
    {
        public BTDecorator_Cooldown(nint addr) : base(addr) { }
        public float CoolDownTime { get { return this[nameof(CoolDownTime)].GetValue<float>(); } set { this[nameof(CoolDownTime)].SetValue<float>(value); } }
    }
    public class BTDecorator_DoesPathExist : BTDecorator
    {
        public BTDecorator_DoesPathExist(nint addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKeyA { get { return this[nameof(BlackboardKeyA)].As<BlackboardKeySelector>(); } set { this["BlackboardKeyA"] = value; } }
        public BlackboardKeySelector BlackboardKeyB { get { return this[nameof(BlackboardKeyB)].As<BlackboardKeySelector>(); } set { this["BlackboardKeyB"] = value; } }
        public bool bUseSelf { get { return this[nameof(bUseSelf)].Flag; } set { this[nameof(bUseSelf)].Flag = value; } }
        public byte PathQueryType { get { return this[nameof(PathQueryType)].GetValue<byte>(); } set { this[nameof(PathQueryType)].SetValue<byte>(value); } }
        public Object FilterClass { get { return this[nameof(FilterClass)]; } set { this[nameof(FilterClass)] = value; } }
    }
    public class BTDecorator_ForceSuccess : BTDecorator
    {
        public BTDecorator_ForceSuccess(nint addr) : base(addr) { }
    }
    public class BTDecorator_IsAtLocation : BTDecorator_BlackboardBase
    {
        public BTDecorator_IsAtLocation(nint addr) : base(addr) { }
        public float AcceptableRadius { get { return this[nameof(AcceptableRadius)].GetValue<float>(); } set { this[nameof(AcceptableRadius)].SetValue<float>(value); } }
        public AIDataProviderFloatValue ParametrizedAcceptableRadius { get { return this[nameof(ParametrizedAcceptableRadius)].As<AIDataProviderFloatValue>(); } set { this["ParametrizedAcceptableRadius"] = value; } }
        public FAIDistanceType GeometricDistanceType { get { return (FAIDistanceType)this[nameof(GeometricDistanceType)].GetValue<int>(); } set { this[nameof(GeometricDistanceType)].SetValue<int>((int)value); } }
        public bool bUseParametrizedRadius { get { return this[nameof(bUseParametrizedRadius)].Flag; } set { this[nameof(bUseParametrizedRadius)].Flag = value; } }
        public bool bUseNavAgentGoalLocation { get { return this[nameof(bUseNavAgentGoalLocation)].Flag; } set { this[nameof(bUseNavAgentGoalLocation)].Flag = value; } }
        public bool bPathFindingBasedTest { get { return this[nameof(bPathFindingBasedTest)].Flag; } set { this[nameof(bPathFindingBasedTest)].Flag = value; } }
    }
    public class BTDecorator_IsBBEntryOfClass : BTDecorator_BlackboardBase
    {
        public BTDecorator_IsBBEntryOfClass(nint addr) : base(addr) { }
        public Object TestClass { get { return this[nameof(TestClass)]; } set { this[nameof(TestClass)] = value; } }
    }
    public class BTDecorator_KeepInCone : BTDecorator
    {
        public BTDecorator_KeepInCone(nint addr) : base(addr) { }
        public float ConeHalfAngle { get { return this[nameof(ConeHalfAngle)].GetValue<float>(); } set { this[nameof(ConeHalfAngle)].SetValue<float>(value); } }
        public BlackboardKeySelector ConeOrigin { get { return this[nameof(ConeOrigin)].As<BlackboardKeySelector>(); } set { this["ConeOrigin"] = value; } }
        public BlackboardKeySelector Observed { get { return this[nameof(Observed)].As<BlackboardKeySelector>(); } set { this["Observed"] = value; } }
        public bool bUseSelfAsOrigin { get { return this[nameof(bUseSelfAsOrigin)].Flag; } set { this[nameof(bUseSelfAsOrigin)].Flag = value; } }
        public bool bUseSelfAsObserved { get { return this[nameof(bUseSelfAsObserved)].Flag; } set { this[nameof(bUseSelfAsObserved)].Flag = value; } }
    }
    public class BTDecorator_Loop : BTDecorator
    {
        public BTDecorator_Loop(nint addr) : base(addr) { }
        public int NumLoops { get { return this[nameof(NumLoops)].GetValue<int>(); } set { this[nameof(NumLoops)].SetValue<int>(value); } }
        public bool bInfiniteLoop { get { return this[nameof(bInfiniteLoop)].Flag; } set { this[nameof(bInfiniteLoop)].Flag = value; } }
        public float InfiniteLoopTimeoutTime { get { return this[nameof(InfiniteLoopTimeoutTime)].GetValue<float>(); } set { this[nameof(InfiniteLoopTimeoutTime)].SetValue<float>(value); } }
    }
    public class BTDecorator_ReachedMoveGoal : BTDecorator
    {
        public BTDecorator_ReachedMoveGoal(nint addr) : base(addr) { }
    }
    public class BTDecorator_SetTagCooldown : BTDecorator
    {
        public BTDecorator_SetTagCooldown(nint addr) : base(addr) { }
        public GameplayTag CooldownTag { get { return this[nameof(CooldownTag)].As<GameplayTag>(); } set { this["CooldownTag"] = value; } }
        public float CooldownDuration { get { return this[nameof(CooldownDuration)].GetValue<float>(); } set { this[nameof(CooldownDuration)].SetValue<float>(value); } }
        public bool bAddToExistingDuration { get { return this[nameof(bAddToExistingDuration)].Flag; } set { this[nameof(bAddToExistingDuration)].Flag = value; } }
    }
    public class BTDecorator_TagCooldown : BTDecorator
    {
        public BTDecorator_TagCooldown(nint addr) : base(addr) { }
        public GameplayTag CooldownTag { get { return this[nameof(CooldownTag)].As<GameplayTag>(); } set { this["CooldownTag"] = value; } }
        public float CooldownDuration { get { return this[nameof(CooldownDuration)].GetValue<float>(); } set { this[nameof(CooldownDuration)].SetValue<float>(value); } }
        public bool bAddToExistingDuration { get { return this[nameof(bAddToExistingDuration)].Flag; } set { this[nameof(bAddToExistingDuration)].Flag = value; } }
        public bool bActivatesCooldown { get { return this[nameof(bActivatesCooldown)].Flag; } set { this[nameof(bActivatesCooldown)].Flag = value; } }
    }
    public class BTDecorator_TimeLimit : BTDecorator
    {
        public BTDecorator_TimeLimit(nint addr) : base(addr) { }
        public float TimeLimit { get { return this[nameof(TimeLimit)].GetValue<float>(); } set { this[nameof(TimeLimit)].SetValue<float>(value); } }
    }
    public class BTService_BlackboardBase : BTService
    {
        public BTService_BlackboardBase(nint addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKey { get { return this[nameof(BlackboardKey)].As<BlackboardKeySelector>(); } set { this["BlackboardKey"] = value; } }
    }
    public class BTService_BlueprintBase : BTService
    {
        public BTService_BlueprintBase(nint addr) : base(addr) { }
        public AIController AIOwner { get { return this[nameof(AIOwner)].As<AIController>(); } set { this["AIOwner"] = value; } }
        public Actor ActorOwner { get { return this[nameof(ActorOwner)].As<Actor>(); } set { this["ActorOwner"] = value; } }
        public bool bShowPropertyDetails { get { return this[nameof(bShowPropertyDetails)].Flag; } set { this[nameof(bShowPropertyDetails)].Flag = value; } }
        public bool bShowEventDetails { get { return this[nameof(bShowEventDetails)].Flag; } set { this[nameof(bShowEventDetails)].Flag = value; } }
        public void ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ReceiveTickAI), OwnerController, ControlledPawn, DeltaSeconds); }
        public void ReceiveTick(Actor ownerActor, float DeltaSeconds) { Invoke(nameof(ReceiveTick), ownerActor, DeltaSeconds); }
        public void ReceiveSearchStartAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveSearchStartAI), OwnerController, ControlledPawn); }
        public void ReceiveSearchStart(Actor ownerActor) { Invoke(nameof(ReceiveSearchStart), ownerActor); }
        public void ReceiveDeactivationAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveDeactivationAI), OwnerController, ControlledPawn); }
        public void ReceiveDeactivation(Actor ownerActor) { Invoke(nameof(ReceiveDeactivation), ownerActor); }
        public void ReceiveActivationAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveActivationAI), OwnerController, ControlledPawn); }
        public void ReceiveActivation(Actor ownerActor) { Invoke(nameof(ReceiveActivation), ownerActor); }
        public bool IsServiceActive() { return Invoke<bool>(nameof(IsServiceActive)); }
    }
    public class BTService_DefaultFocus : BTService_BlackboardBase
    {
        public BTService_DefaultFocus(nint addr) : base(addr) { }
        public byte FocusPriority { get { return this[nameof(FocusPriority)].GetValue<byte>(); } set { this[nameof(FocusPriority)].SetValue<byte>(value); } }
    }
    public class BTService_RunEQS : BTService_BlackboardBase
    {
        public BTService_RunEQS(nint addr) : base(addr) { }
        public EQSParametrizedQueryExecutionRequest EQSRequest { get { return this[nameof(EQSRequest)].As<EQSParametrizedQueryExecutionRequest>(); } set { this["EQSRequest"] = value; } }
        public bool bUpdateBBOnFail { get { return this[nameof(bUpdateBBOnFail)].Flag; } set { this[nameof(bUpdateBBOnFail)].Flag = value; } }
    }
    public class BTTask_BlackboardBase : BTTaskNode
    {
        public BTTask_BlackboardBase(nint addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKey { get { return this[nameof(BlackboardKey)].As<BlackboardKeySelector>(); } set { this["BlackboardKey"] = value; } }
    }
    public class BTTask_BlueprintBase : BTTaskNode
    {
        public BTTask_BlueprintBase(nint addr) : base(addr) { }
        public AIController AIOwner { get { return this[nameof(AIOwner)].As<AIController>(); } set { this["AIOwner"] = value; } }
        public Actor ActorOwner { get { return this[nameof(ActorOwner)].As<Actor>(); } set { this["ActorOwner"] = value; } }
        public IntervalCountdown TickInterval { get { return this[nameof(TickInterval)].As<IntervalCountdown>(); } set { this["TickInterval"] = value; } }
        public bool bShowPropertyDetails { get { return this[nameof(bShowPropertyDetails)].Flag; } set { this[nameof(bShowPropertyDetails)].Flag = value; } }
        public void SetFinishOnMessageWithId(Object MessageName, int RequestID) { Invoke(nameof(SetFinishOnMessageWithId), MessageName, RequestID); }
        public void SetFinishOnMessage(Object MessageName) { Invoke(nameof(SetFinishOnMessage), MessageName); }
        public void ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) { Invoke(nameof(ReceiveTickAI), OwnerController, ControlledPawn, DeltaSeconds); }
        public void ReceiveTick(Actor ownerActor, float DeltaSeconds) { Invoke(nameof(ReceiveTick), ownerActor, DeltaSeconds); }
        public void ReceiveExecuteAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveExecuteAI), OwnerController, ControlledPawn); }
        public void ReceiveExecute(Actor ownerActor) { Invoke(nameof(ReceiveExecute), ownerActor); }
        public void ReceiveAbortAI(AIController OwnerController, Pawn ControlledPawn) { Invoke(nameof(ReceiveAbortAI), OwnerController, ControlledPawn); }
        public void ReceiveAbort(Actor ownerActor) { Invoke(nameof(ReceiveAbort), ownerActor); }
        public bool IsTaskExecuting() { return Invoke<bool>(nameof(IsTaskExecuting)); }
        public bool IsTaskAborting() { return Invoke<bool>(nameof(IsTaskAborting)); }
        public void FinishExecute(bool bSuccess) { Invoke(nameof(FinishExecute), bSuccess); }
        public void FinishAbort() { Invoke(nameof(FinishAbort)); }
    }
    public class BTTask_FinishWithResult : BTTaskNode
    {
        public BTTask_FinishWithResult(nint addr) : base(addr) { }
        public byte Result { get { return this[nameof(Result)].GetValue<byte>(); } set { this[nameof(Result)].SetValue<byte>(value); } }
    }
    public class BTTask_GameplayTaskBase : BTTaskNode
    {
        public BTTask_GameplayTaskBase(nint addr) : base(addr) { }
        public bool bWaitForGameplayTask { get { return this[nameof(bWaitForGameplayTask)].Flag; } set { this[nameof(bWaitForGameplayTask)].Flag = value; } }
    }
    public class BTTask_MakeNoise : BTTaskNode
    {
        public BTTask_MakeNoise(nint addr) : base(addr) { }
        public float Loudnes { get { return this[nameof(Loudnes)].GetValue<float>(); } set { this[nameof(Loudnes)].SetValue<float>(value); } }
    }
    public class BTTask_MoveTo : BTTask_BlackboardBase
    {
        public BTTask_MoveTo(nint addr) : base(addr) { }
        public float AcceptableRadius { get { return this[nameof(AcceptableRadius)].GetValue<float>(); } set { this[nameof(AcceptableRadius)].SetValue<float>(value); } }
        public Object FilterClass { get { return this[nameof(FilterClass)]; } set { this[nameof(FilterClass)] = value; } }
        public float ObservedBlackboardValueTolerance { get { return this[nameof(ObservedBlackboardValueTolerance)].GetValue<float>(); } set { this[nameof(ObservedBlackboardValueTolerance)].SetValue<float>(value); } }
        public bool bObserveBlackboardValue { get { return this[nameof(bObserveBlackboardValue)].Flag; } set { this[nameof(bObserveBlackboardValue)].Flag = value; } }
        public bool bAllowStrafe { get { return this[nameof(bAllowStrafe)].Flag; } set { this[nameof(bAllowStrafe)].Flag = value; } }
        public bool bAllowPartialPath { get { return this[nameof(bAllowPartialPath)].Flag; } set { this[nameof(bAllowPartialPath)].Flag = value; } }
        public bool bTrackMovingGoal { get { return this[nameof(bTrackMovingGoal)].Flag; } set { this[nameof(bTrackMovingGoal)].Flag = value; } }
        public bool bProjectGoalLocation { get { return this[nameof(bProjectGoalLocation)].Flag; } set { this[nameof(bProjectGoalLocation)].Flag = value; } }
        public bool bReachTestIncludesAgentRadius { get { return this[nameof(bReachTestIncludesAgentRadius)].Flag; } set { this[nameof(bReachTestIncludesAgentRadius)].Flag = value; } }
        public bool bReachTestIncludesGoalRadius { get { return this[nameof(bReachTestIncludesGoalRadius)].Flag; } set { this[nameof(bReachTestIncludesGoalRadius)].Flag = value; } }
        public bool bStopOnOverlap { get { return this[nameof(bStopOnOverlap)].Flag; } set { this[nameof(bStopOnOverlap)].Flag = value; } }
        public bool bStopOnOverlapNeedsUpdate { get { return this[nameof(bStopOnOverlapNeedsUpdate)].Flag; } set { this[nameof(bStopOnOverlapNeedsUpdate)].Flag = value; } }
    }
    public class BTTask_MoveDirectlyToward : BTTask_MoveTo
    {
        public BTTask_MoveDirectlyToward(nint addr) : base(addr) { }
        public bool bDisablePathUpdateOnGoalLocationChange { get { return this[nameof(bDisablePathUpdateOnGoalLocationChange)].Flag; } set { this[nameof(bDisablePathUpdateOnGoalLocationChange)].Flag = value; } }
        public bool bProjectVectorGoalToNavigation { get { return this[nameof(bProjectVectorGoalToNavigation)].Flag; } set { this[nameof(bProjectVectorGoalToNavigation)].Flag = value; } }
        public bool bUpdatedDeprecatedProperties { get { return this[nameof(bUpdatedDeprecatedProperties)].Flag; } set { this[nameof(bUpdatedDeprecatedProperties)].Flag = value; } }
    }
    public class BTTask_PawnActionBase : BTTaskNode
    {
        public BTTask_PawnActionBase(nint addr) : base(addr) { }
    }
    public class BTTask_PlayAnimation : BTTaskNode
    {
        public BTTask_PlayAnimation(nint addr) : base(addr) { }
        public AnimationAsset AnimationToPlay { get { return this[nameof(AnimationToPlay)].As<AnimationAsset>(); } set { this["AnimationToPlay"] = value; } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public bool bNonBlocking { get { return this[nameof(bNonBlocking)].Flag; } set { this[nameof(bNonBlocking)].Flag = value; } }
        public BehaviorTreeComponent MyOwnerComp { get { return this[nameof(MyOwnerComp)].As<BehaviorTreeComponent>(); } set { this["MyOwnerComp"] = value; } }
        public SkeletalMeshComponent CachedSkelMesh { get { return this[nameof(CachedSkelMesh)].As<SkeletalMeshComponent>(); } set { this["CachedSkelMesh"] = value; } }
    }
    public class BTTask_PlaySound : BTTaskNode
    {
        public BTTask_PlaySound(nint addr) : base(addr) { }
        public SoundCue SoundToPlay { get { return this[nameof(SoundToPlay)].As<SoundCue>(); } set { this["SoundToPlay"] = value; } }
    }
    public class BTTask_PushPawnAction : BTTask_PawnActionBase
    {
        public BTTask_PushPawnAction(nint addr) : base(addr) { }
        public PawnAction action { get { return this[nameof(action)].As<PawnAction>(); } set { this["action"] = value; } }
    }
    public class BTTask_RotateToFaceBBEntry : BTTask_BlackboardBase
    {
        public BTTask_RotateToFaceBBEntry(nint addr) : base(addr) { }
        public float Precision { get { return this[nameof(Precision)].GetValue<float>(); } set { this[nameof(Precision)].SetValue<float>(value); } }
    }
    public class BTTask_RunBehavior : BTTaskNode
    {
        public BTTask_RunBehavior(nint addr) : base(addr) { }
        public BehaviorTree BehaviorAsset { get { return this[nameof(BehaviorAsset)].As<BehaviorTree>(); } set { this["BehaviorAsset"] = value; } }
    }
    public class BTTask_RunBehaviorDynamic : BTTaskNode
    {
        public BTTask_RunBehaviorDynamic(nint addr) : base(addr) { }
        public GameplayTag InjectionTag { get { return this[nameof(InjectionTag)].As<GameplayTag>(); } set { this["InjectionTag"] = value; } }
        public BehaviorTree DefaultBehaviorAsset { get { return this[nameof(DefaultBehaviorAsset)].As<BehaviorTree>(); } set { this["DefaultBehaviorAsset"] = value; } }
        public BehaviorTree BehaviorAsset { get { return this[nameof(BehaviorAsset)].As<BehaviorTree>(); } set { this["BehaviorAsset"] = value; } }
    }
    public class BTTask_RunEQSQuery : BTTask_BlackboardBase
    {
        public BTTask_RunEQSQuery(nint addr) : base(addr) { }
        public EnvQuery QueryTemplate { get { return this[nameof(QueryTemplate)].As<EnvQuery>(); } set { this["QueryTemplate"] = value; } }
        public Array<EnvNamedValue> QueryParams { get { return new Array<EnvNamedValue>(this[nameof(QueryParams)].Address); } }
        public Array<AIDynamicParam> QueryConfig { get { return new Array<AIDynamicParam>(this[nameof(QueryConfig)].Address); } }
        public byte RunMode { get { return this[nameof(RunMode)].GetValue<byte>(); } set { this[nameof(RunMode)].SetValue<byte>(value); } }
        public BlackboardKeySelector EQSQueryBlackboardKey { get { return this[nameof(EQSQueryBlackboardKey)].As<BlackboardKeySelector>(); } set { this["EQSQueryBlackboardKey"] = value; } }
        public bool bUseBBKey { get { return this[nameof(bUseBBKey)].Flag; } set { this[nameof(bUseBBKey)].Flag = value; } }
        public EQSParametrizedQueryExecutionRequest EQSRequest { get { return this[nameof(EQSRequest)].As<EQSParametrizedQueryExecutionRequest>(); } set { this["EQSRequest"] = value; } }
        public bool bUpdateBBOnFail { get { return this[nameof(bUpdateBBOnFail)].Flag; } set { this[nameof(bUpdateBBOnFail)].Flag = value; } }
    }
    public class BTTask_SetTagCooldown : BTTaskNode
    {
        public BTTask_SetTagCooldown(nint addr) : base(addr) { }
        public GameplayTag CooldownTag { get { return this[nameof(CooldownTag)].As<GameplayTag>(); } set { this["CooldownTag"] = value; } }
        public bool bAddToExistingDuration { get { return this[nameof(bAddToExistingDuration)].Flag; } set { this[nameof(bAddToExistingDuration)].Flag = value; } }
        public float CooldownDuration { get { return this[nameof(CooldownDuration)].GetValue<float>(); } set { this[nameof(CooldownDuration)].SetValue<float>(value); } }
    }
    public class BTTask_Wait : BTTaskNode
    {
        public BTTask_Wait(nint addr) : base(addr) { }
        public float WaitTime { get { return this[nameof(WaitTime)].GetValue<float>(); } set { this[nameof(WaitTime)].SetValue<float>(value); } }
        public float RandomDeviation { get { return this[nameof(RandomDeviation)].GetValue<float>(); } set { this[nameof(RandomDeviation)].SetValue<float>(value); } }
    }
    public class BTTask_WaitBlackboardTime : BTTask_Wait
    {
        public BTTask_WaitBlackboardTime(nint addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKey { get { return this[nameof(BlackboardKey)].As<BlackboardKeySelector>(); } set { this["BlackboardKey"] = value; } }
    }
    public class AIBlueprintHelperLibrary : BlueprintFunctionLibrary
    {
        public AIBlueprintHelperLibrary(nint addr) : base(addr) { }
        public void UnlockAIResourcesWithAnimation(AnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic) { Invoke(nameof(UnlockAIResourcesWithAnimation), AnimInstance, bUnlockMovement, UnlockAILogic); }
        public Pawn SpawnAIFromClass(Object WorldContextObject, Object PawnClass, BehaviorTree BehaviorTree, Vector Location, Rotator Rotation, bool bNoCollisionFail, Actor Owner) { return Invoke<Pawn>(nameof(SpawnAIFromClass), WorldContextObject, PawnClass, BehaviorTree, Location, Rotation, bNoCollisionFail, Owner); }
        public void SimpleMoveToLocation(Controller Controller, Vector Goal) { Invoke(nameof(SimpleMoveToLocation), Controller, Goal); }
        public void SimpleMoveToActor(Controller Controller, Actor Goal) { Invoke(nameof(SimpleMoveToActor), Controller, Goal); }
        public void SendAIMessage(Pawn Target, Object Message, Object MessageSource, bool bSuccess) { Invoke(nameof(SendAIMessage), Target, Message, MessageSource, bSuccess); }
        public void LockAIResourcesWithAnimation(AnimInstance AnimInstance, bool bLockMovement, bool LockAILogic) { Invoke(nameof(LockAIResourcesWithAnimation), AnimInstance, bLockMovement, LockAILogic); }
        public bool IsValidAIRotation(Rotator Rotation) { return Invoke<bool>(nameof(IsValidAIRotation), Rotation); }
        public bool IsValidAILocation(Vector Location) { return Invoke<bool>(nameof(IsValidAILocation), Location); }
        public bool IsValidAIDirection(Vector DirectionVector) { return Invoke<bool>(nameof(IsValidAIDirection), DirectionVector); }
        public int GetNextNavLinkIndex(Controller Controller) { return Invoke<int>(nameof(GetNextNavLinkIndex), Controller); }
        public Array<Vector> GetCurrentPathPoints(Controller Controller) { return Invoke<Array<Vector>>(nameof(GetCurrentPathPoints), Controller); }
        public int GetCurrentPathIndex(Controller Controller) { return Invoke<int>(nameof(GetCurrentPathIndex), Controller); }
        public NavigationPath GetCurrentPath(Controller Controller) { return Invoke<NavigationPath>(nameof(GetCurrentPath), Controller); }
        public BlackboardComponent GetBlackboard(Actor Target) { return Invoke<BlackboardComponent>(nameof(GetBlackboard), Target); }
        public AIController GetAIController(Actor ControlledActor) { return Invoke<AIController>(nameof(GetAIController), ControlledActor); }
        public AIAsyncTaskBlueprintProxy CreateMoveToProxyObject(Object WorldContextObject, Pawn Pawn, Vector Destination, Actor TargetActor, float AcceptanceRadius, bool bStopOnOverlap) { return Invoke<AIAsyncTaskBlueprintProxy>(nameof(CreateMoveToProxyObject), WorldContextObject, Pawn, Destination, TargetActor, AcceptanceRadius, bStopOnOverlap); }
    }
    public class AIDataProvider : Object
    {
        public AIDataProvider(nint addr) : base(addr) { }
    }
    public class AIDataProvider_QueryParams : AIDataProvider
    {
        public AIDataProvider_QueryParams(nint addr) : base(addr) { }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
        //public float FloatValue { get { return this[nameof(FloatValue)].GetValue<float>(); } set { this[nameof(FloatValue)].SetValue<float>(value); } }
        public int IntValue { get { return this[nameof(IntValue)].GetValue<int>(); } set { this[nameof(IntValue)].SetValue<int>(value); } }
        public bool BoolValue { get { return this[nameof(BoolValue)].Flag; } set { this[nameof(BoolValue)].Flag = value; } }
    }
    public class AIDataProvider_Random : AIDataProvider_QueryParams
    {
        public AIDataProvider_Random(nint addr) : base(addr) { }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
        public bool bInteger { get { return this[nameof(bInteger)].Flag; } set { this[nameof(bInteger)].Flag = value; } }
    }
    public class DetourCrowdAIController : AIController
    {
        public DetourCrowdAIController(nint addr) : base(addr) { }
    }
    public class EnvQueryContext : Object
    {
        public EnvQueryContext(nint addr) : base(addr) { }
    }
    public class EnvQueryContext_BlueprintBase : EnvQueryContext
    {
        public EnvQueryContext_BlueprintBase(nint addr) : base(addr) { }
        public void ProvideSingleLocation(Object QuerierObject, Actor QuerierActor, Vector ResultingLocation) { Invoke(nameof(ProvideSingleLocation), QuerierObject, QuerierActor, ResultingLocation); }
        public void ProvideSingleActor(Object QuerierObject, Actor QuerierActor, Actor ResultingActor) { Invoke(nameof(ProvideSingleActor), QuerierObject, QuerierActor, ResultingActor); }
        public void ProvideLocationsSet(Object QuerierObject, Actor QuerierActor, Array<Vector> ResultingLocationSet) { Invoke(nameof(ProvideLocationsSet), QuerierObject, QuerierActor, ResultingLocationSet); }
        public void ProvideActorsSet(Object QuerierObject, Actor QuerierActor, Array<Actor> ResultingActorsSet) { Invoke(nameof(ProvideActorsSet), QuerierObject, QuerierActor, ResultingActorsSet); }
    }
    public class EnvQueryContext_Item : EnvQueryContext
    {
        public EnvQueryContext_Item(nint addr) : base(addr) { }
    }
    public class EnvQueryContext_Querier : EnvQueryContext
    {
        public EnvQueryContext_Querier(nint addr) : base(addr) { }
    }
    public class EnvQuery : DataAsset
    {
        public EnvQuery(nint addr) : base(addr) { }
        public Object QueryName { get { return this[nameof(QueryName)]; } set { this[nameof(QueryName)] = value; } }
        public Array<EnvQueryOption> Options { get { return new Array<EnvQueryOption>(this[nameof(Options)].Address); } }
    }
    public class EnvQueryDebugHelpers : Object
    {
        public EnvQueryDebugHelpers(nint addr) : base(addr) { }
    }
    public class EnvQueryGenerator : EnvQueryNode
    {
        public EnvQueryGenerator(nint addr) : base(addr) { }
        public Object OptionName { get { return this[nameof(OptionName)]; } set { this[nameof(OptionName)] = value; } }
        public Object ItemType { get { return this[nameof(ItemType)]; } set { this[nameof(ItemType)] = value; } }
        public bool bAutoSortTests { get { return this[nameof(bAutoSortTests)].Flag; } set { this[nameof(bAutoSortTests)].Flag = value; } }
    }
    public class EnvQueryInstanceBlueprintWrapper : Object
    {
        public EnvQueryInstanceBlueprintWrapper(nint addr) : base(addr) { }
        public int QueryID { get { return this[nameof(QueryID)].GetValue<int>(); } set { this[nameof(QueryID)].SetValue<int>(value); } }
        public Object ItemType { get { return this[nameof(ItemType)]; } set { this[nameof(ItemType)] = value; } }
        public int OptionIndex { get { return this[nameof(OptionIndex)].GetValue<int>(); } set { this[nameof(OptionIndex)].SetValue<int>(value); } }
        public Object OnQueryFinishedEvent { get { return this[nameof(OnQueryFinishedEvent)]; } set { this[nameof(OnQueryFinishedEvent)] = value; } }
        public void SetNamedParam(Object ParamName, float Value) { Invoke(nameof(SetNamedParam), ParamName, Value); }
        public Array<Vector> GetResultsAsLocations() { return Invoke<Array<Vector>>(nameof(GetResultsAsLocations)); }
        public Array<Actor> GetResultsAsActors() { return Invoke<Array<Actor>>(nameof(GetResultsAsActors)); }
        public bool GetQueryResultsAsLocations(Array<Vector> ResultLocations) { return Invoke<bool>(nameof(GetQueryResultsAsLocations), ResultLocations); }
        public bool GetQueryResultsAsActors(Array<Actor> ResultActors) { return Invoke<bool>(nameof(GetQueryResultsAsActors), ResultActors); }
        public float GetItemScore(int ItemIndex) { return Invoke<float>(nameof(GetItemScore), ItemIndex); }
        public void EQSQueryDoneSignature__DelegateSignature(EnvQueryInstanceBlueprintWrapper QueryInstance, byte QueryStatus) { Invoke(nameof(EQSQueryDoneSignature__DelegateSignature), QueryInstance, QueryStatus); }
    }
    public class EnvQueryManager : AISubsystem
    {
        public EnvQueryManager(nint addr) : base(addr) { }
        public Array<EnvQueryInstanceCache> InstanceCache { get { return new Array<EnvQueryInstanceCache>(this[nameof(InstanceCache)].Address); } }
        public Array<EnvQueryContext> LocalContexts { get { return new Array<EnvQueryContext>(this[nameof(LocalContexts)].Address); } }
        public Array<EnvQueryInstanceBlueprintWrapper> GCShieldedWrappers { get { return new Array<EnvQueryInstanceBlueprintWrapper>(this[nameof(GCShieldedWrappers)].Address); } }
        public float MaxAllowedTestingTime { get { return this[nameof(MaxAllowedTestingTime)].GetValue<float>(); } set { this[nameof(MaxAllowedTestingTime)].SetValue<float>(value); } }
        public bool bTestQueriesUsingBreadth { get { return this[nameof(bTestQueriesUsingBreadth)].Flag; } set { this[nameof(bTestQueriesUsingBreadth)].Flag = value; } }
        public int QueryCountWarningThreshold { get { return this[nameof(QueryCountWarningThreshold)].GetValue<int>(); } set { this[nameof(QueryCountWarningThreshold)].SetValue<int>(value); } }
        public double QueryCountWarningInterval { get { return this[nameof(QueryCountWarningInterval)].GetValue<double>(); } set { this[nameof(QueryCountWarningInterval)].SetValue<double>(value); } }
        public double ExecutionTimeWarningSeconds { get { return this[nameof(ExecutionTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(ExecutionTimeWarningSeconds)].SetValue<double>(value); } }
        public double HandlingResultTimeWarningSeconds { get { return this[nameof(HandlingResultTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(HandlingResultTimeWarningSeconds)].SetValue<double>(value); } }
        public double GenerationTimeWarningSeconds { get { return this[nameof(GenerationTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(GenerationTimeWarningSeconds)].SetValue<double>(value); } }
        public EnvQueryInstanceBlueprintWrapper RunEQSQuery(Object WorldContextObject, EnvQuery QueryTemplate, Object Querier, byte RunMode, Object WrapperClass) { return Invoke<EnvQueryInstanceBlueprintWrapper>(nameof(RunEQSQuery), WorldContextObject, QueryTemplate, Querier, RunMode, WrapperClass); }
    }
    public class EnvQueryOption : Object
    {
        public EnvQueryOption(nint addr) : base(addr) { }
        public EnvQueryGenerator Generator { get { return this[nameof(Generator)].As<EnvQueryGenerator>(); } set { this["Generator"] = value; } }
        public Array<EnvQueryTest> Tests { get { return new Array<EnvQueryTest>(this[nameof(Tests)].Address); } }
    }
    public class EQSRenderingComponent : DebugDrawComponent
    {
        public EQSRenderingComponent(nint addr) : base(addr) { }
    }
    public class EQSTestingPawn : Character
    {
        public EQSTestingPawn(nint addr) : base(addr) { }
        public EnvQuery QueryTemplate { get { return this[nameof(QueryTemplate)].As<EnvQuery>(); } set { this["QueryTemplate"] = value; } }
        public Array<EnvNamedValue> QueryParams { get { return new Array<EnvNamedValue>(this[nameof(QueryParams)].Address); } }
        public Array<AIDynamicParam> QueryConfig { get { return new Array<AIDynamicParam>(this[nameof(QueryConfig)].Address); } }
        public float TimeLimitPerStep { get { return this[nameof(TimeLimitPerStep)].GetValue<float>(); } set { this[nameof(TimeLimitPerStep)].SetValue<float>(value); } }
        public int StepToDebugDraw { get { return this[nameof(StepToDebugDraw)].GetValue<int>(); } set { this[nameof(StepToDebugDraw)].SetValue<int>(value); } }
        public EEnvQueryHightlightMode HighlightMode { get { return (EEnvQueryHightlightMode)this[nameof(HighlightMode)].GetValue<int>(); } set { this[nameof(HighlightMode)].SetValue<int>((int)value); } }
        public bool bDrawLabels { get { return this[nameof(bDrawLabels)].Flag; } set { this[nameof(bDrawLabels)].Flag = value; } }
        public bool bDrawFailedItems { get { return this[nameof(bDrawFailedItems)].Flag; } set { this[nameof(bDrawFailedItems)].Flag = value; } }
        public bool bReRunQueryOnlyOnFinishedMove { get { return this[nameof(bReRunQueryOnlyOnFinishedMove)].Flag; } set { this[nameof(bReRunQueryOnlyOnFinishedMove)].Flag = value; } }
        public bool bShouldBeVisibleInGame { get { return this[nameof(bShouldBeVisibleInGame)].Flag; } set { this[nameof(bShouldBeVisibleInGame)].Flag = value; } }
        public bool bTickDuringGame { get { return this[nameof(bTickDuringGame)].Flag; } set { this[nameof(bTickDuringGame)].Flag = value; } }
        public byte QueryingMode { get { return this[nameof(QueryingMode)].GetValue<byte>(); } set { this[nameof(QueryingMode)].SetValue<byte>(value); } }
        public NavAgentProperties NavAgentProperties { get { return this[nameof(NavAgentProperties)].As<NavAgentProperties>(); } set { this["NavAgentProperties"] = value; } }
    }
    public class EnvQueryGenerator_ActorsOfClass : EnvQueryGenerator
    {
        public EnvQueryGenerator_ActorsOfClass(nint addr) : base(addr) { }
        public Object SearchedActorClass { get { return this[nameof(SearchedActorClass)]; } set { this[nameof(SearchedActorClass)] = value; } }
        public AIDataProviderBoolValue GenerateOnlyActorsInRadius { get { return this[nameof(GenerateOnlyActorsInRadius)].As<AIDataProviderBoolValue>(); } set { this["GenerateOnlyActorsInRadius"] = value; } }
        public AIDataProviderFloatValue SearchRadius { get { return this[nameof(SearchRadius)].As<AIDataProviderFloatValue>(); } set { this["SearchRadius"] = value; } }
        public Object SearchCenter { get { return this[nameof(SearchCenter)]; } set { this[nameof(SearchCenter)] = value; } }
    }
    public class EnvQueryGenerator_BlueprintBase : EnvQueryGenerator
    {
        public EnvQueryGenerator_BlueprintBase(nint addr) : base(addr) { }
        public Object GeneratorsActionDescription { get { return this[nameof(GeneratorsActionDescription)]; } set { this[nameof(GeneratorsActionDescription)] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public Object GeneratedItemType { get { return this[nameof(GeneratedItemType)]; } set { this[nameof(GeneratedItemType)] = value; } }
        public Object GetQuerier() { return Invoke<Object>(nameof(GetQuerier)); }
        public void DoItemGenerationFromActors(Array<Actor> ContextActors) { Invoke(nameof(DoItemGenerationFromActors), ContextActors); }
        public void DoItemGeneration(Array<Vector> ContextLocations) { Invoke(nameof(DoItemGeneration), ContextLocations); }
        public void AddGeneratedVector(Vector GeneratedVector) { Invoke(nameof(AddGeneratedVector), GeneratedVector); }
        public void AddGeneratedActor(Actor GeneratedActor) { Invoke(nameof(AddGeneratedActor), GeneratedActor); }
    }
    public class EnvQueryGenerator_Composite : EnvQueryGenerator
    {
        public EnvQueryGenerator_Composite(nint addr) : base(addr) { }
        public Array<EnvQueryGenerator> Generators { get { return new Array<EnvQueryGenerator>(this[nameof(Generators)].Address); } }
        public bool bAllowDifferentItemTypes { get { return this[nameof(bAllowDifferentItemTypes)].Flag; } set { this[nameof(bAllowDifferentItemTypes)].Flag = value; } }
        public bool bHasMatchingItemType { get { return this[nameof(bHasMatchingItemType)].Flag; } set { this[nameof(bHasMatchingItemType)].Flag = value; } }
        public Object ForcedItemType { get { return this[nameof(ForcedItemType)]; } set { this[nameof(ForcedItemType)] = value; } }
    }
    public class EnvQueryGenerator_ProjectedPoints : EnvQueryGenerator
    {
        public EnvQueryGenerator_ProjectedPoints(nint addr) : base(addr) { }
        public EnvTraceData ProjectionData { get { return this[nameof(ProjectionData)].As<EnvTraceData>(); } set { this["ProjectionData"] = value; } }
    }
    public class EnvQueryGenerator_Cone : EnvQueryGenerator_ProjectedPoints
    {
        public EnvQueryGenerator_Cone(nint addr) : base(addr) { }
        public AIDataProviderFloatValue AlignedPointsDistance { get { return this[nameof(AlignedPointsDistance)].As<AIDataProviderFloatValue>(); } set { this["AlignedPointsDistance"] = value; } }
        public AIDataProviderFloatValue ConeDegrees { get { return this[nameof(ConeDegrees)].As<AIDataProviderFloatValue>(); } set { this["ConeDegrees"] = value; } }
        public AIDataProviderFloatValue AngleStep { get { return this[nameof(AngleStep)].As<AIDataProviderFloatValue>(); } set { this["AngleStep"] = value; } }
        public AIDataProviderFloatValue Range { get { return this[nameof(Range)].As<AIDataProviderFloatValue>(); } set { this["Range"] = value; } }
        public Object CenterActor { get { return this[nameof(CenterActor)]; } set { this[nameof(CenterActor)] = value; } }
        public bool bIncludeContextLocation { get { return this[nameof(bIncludeContextLocation)].Flag; } set { this[nameof(bIncludeContextLocation)].Flag = value; } }
    }
    public class EnvQueryGenerator_CurrentLocation : EnvQueryGenerator
    {
        public EnvQueryGenerator_CurrentLocation(nint addr) : base(addr) { }
        public Object QueryContext { get { return this[nameof(QueryContext)]; } set { this[nameof(QueryContext)] = value; } }
    }
    public class EnvQueryGenerator_Donut : EnvQueryGenerator_ProjectedPoints
    {
        public EnvQueryGenerator_Donut(nint addr) : base(addr) { }
        public AIDataProviderFloatValue InnerRadius { get { return this[nameof(InnerRadius)].As<AIDataProviderFloatValue>(); } set { this["InnerRadius"] = value; } }
        public AIDataProviderFloatValue OuterRadius { get { return this[nameof(OuterRadius)].As<AIDataProviderFloatValue>(); } set { this["OuterRadius"] = value; } }
        public AIDataProviderIntValue NumberOfRings { get { return this[nameof(NumberOfRings)].As<AIDataProviderIntValue>(); } set { this["NumberOfRings"] = value; } }
        public AIDataProviderIntValue PointsPerRing { get { return this[nameof(PointsPerRing)].As<AIDataProviderIntValue>(); } set { this["PointsPerRing"] = value; } }
        public EnvDirection ArcDirection { get { return this[nameof(ArcDirection)].As<EnvDirection>(); } set { this["ArcDirection"] = value; } }
        public AIDataProviderFloatValue ArcAngle { get { return this[nameof(ArcAngle)].As<AIDataProviderFloatValue>(); } set { this["ArcAngle"] = value; } }
        public bool bUseSpiralPattern { get { return this[nameof(bUseSpiralPattern)].Flag; } set { this[nameof(bUseSpiralPattern)].Flag = value; } }
        public Object Center { get { return this[nameof(Center)]; } set { this[nameof(Center)] = value; } }
        public bool bDefineArc { get { return this[nameof(bDefineArc)].Flag; } set { this[nameof(bDefineArc)].Flag = value; } }
    }
    public class EnvQueryGenerator_OnCircle : EnvQueryGenerator_ProjectedPoints
    {
        public EnvQueryGenerator_OnCircle(nint addr) : base(addr) { }
        public AIDataProviderFloatValue CircleRadius { get { return this[nameof(CircleRadius)].As<AIDataProviderFloatValue>(); } set { this["CircleRadius"] = value; } }
        public AIDataProviderFloatValue SpaceBetween { get { return this[nameof(SpaceBetween)].As<AIDataProviderFloatValue>(); } set { this["SpaceBetween"] = value; } }
        public AIDataProviderIntValue NumberOfPoints { get { return this[nameof(NumberOfPoints)].As<AIDataProviderIntValue>(); } set { this["NumberOfPoints"] = value; } }
        public EPointOnCircleSpacingMethod PointOnCircleSpacingMethod { get { return (EPointOnCircleSpacingMethod)this[nameof(PointOnCircleSpacingMethod)].GetValue<int>(); } set { this[nameof(PointOnCircleSpacingMethod)].SetValue<int>((int)value); } }
        public EnvDirection ArcDirection { get { return this[nameof(ArcDirection)].As<EnvDirection>(); } set { this["ArcDirection"] = value; } }
        public AIDataProviderFloatValue ArcAngle { get { return this[nameof(ArcAngle)].As<AIDataProviderFloatValue>(); } set { this["ArcAngle"] = value; } }
        public float AngleRadians { get { return this[nameof(AngleRadians)].GetValue<float>(); } set { this[nameof(AngleRadians)].SetValue<float>(value); } }
        public Object CircleCenter { get { return this[nameof(CircleCenter)]; } set { this[nameof(CircleCenter)] = value; } }
        public bool bIgnoreAnyContextActorsWhenGeneratingCircle { get { return this[nameof(bIgnoreAnyContextActorsWhenGeneratingCircle)].Flag; } set { this[nameof(bIgnoreAnyContextActorsWhenGeneratingCircle)].Flag = value; } }
        public AIDataProviderFloatValue CircleCenterZOffset { get { return this[nameof(CircleCenterZOffset)].As<AIDataProviderFloatValue>(); } set { this["CircleCenterZOffset"] = value; } }
        public EnvTraceData TraceData { get { return this[nameof(TraceData)].As<EnvTraceData>(); } set { this["TraceData"] = value; } }
        public bool bDefineArc { get { return this[nameof(bDefineArc)].Flag; } set { this[nameof(bDefineArc)].Flag = value; } }
    }
    public class EnvQueryGenerator_SimpleGrid : EnvQueryGenerator_ProjectedPoints
    {
        public EnvQueryGenerator_SimpleGrid(nint addr) : base(addr) { }
        public AIDataProviderFloatValue GridSize { get { return this[nameof(GridSize)].As<AIDataProviderFloatValue>(); } set { this["GridSize"] = value; } }
        public AIDataProviderFloatValue SpaceBetween { get { return this[nameof(SpaceBetween)].As<AIDataProviderFloatValue>(); } set { this["SpaceBetween"] = value; } }
        public Object GenerateAround { get { return this[nameof(GenerateAround)]; } set { this[nameof(GenerateAround)] = value; } }
    }
    public class EnvQueryGenerator_PathingGrid : EnvQueryGenerator_SimpleGrid
    {
        public EnvQueryGenerator_PathingGrid(nint addr) : base(addr) { }
        public AIDataProviderBoolValue PathToItem { get { return this[nameof(PathToItem)].As<AIDataProviderBoolValue>(); } set { this["PathToItem"] = value; } }
        public Object NavigationFilter { get { return this[nameof(NavigationFilter)]; } set { this[nameof(NavigationFilter)] = value; } }
        public AIDataProviderFloatValue ScanRangeMultiplier { get { return this[nameof(ScanRangeMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ScanRangeMultiplier"] = value; } }
    }
    public class EnvQueryGenerator_PerceivedActors : EnvQueryGenerator
    {
        public EnvQueryGenerator_PerceivedActors(nint addr) : base(addr) { }
        public Object AllowedActorClass { get { return this[nameof(AllowedActorClass)]; } set { this[nameof(AllowedActorClass)] = value; } }
        public AIDataProviderFloatValue SearchRadius { get { return this[nameof(SearchRadius)].As<AIDataProviderFloatValue>(); } set { this["SearchRadius"] = value; } }
        public Object ListenerContext { get { return this[nameof(ListenerContext)]; } set { this[nameof(ListenerContext)] = value; } }
        public Object SenseToUse { get { return this[nameof(SenseToUse)]; } set { this[nameof(SenseToUse)] = value; } }
        public bool bIncludeKnownActors { get { return this[nameof(bIncludeKnownActors)].Flag; } set { this[nameof(bIncludeKnownActors)].Flag = value; } }
    }
    public class EnvQueryItemType : Object
    {
        public EnvQueryItemType(nint addr) : base(addr) { }
    }
    public class EnvQueryItemType_VectorBase : EnvQueryItemType
    {
        public EnvQueryItemType_VectorBase(nint addr) : base(addr) { }
    }
    public class EnvQueryItemType_ActorBase : EnvQueryItemType_VectorBase
    {
        public EnvQueryItemType_ActorBase(nint addr) : base(addr) { }
    }
    public class EnvQueryItemType_Actor : EnvQueryItemType_ActorBase
    {
        public EnvQueryItemType_Actor(nint addr) : base(addr) { }
    }
    public class EnvQueryItemType_Direction : EnvQueryItemType_VectorBase
    {
        public EnvQueryItemType_Direction(nint addr) : base(addr) { }
    }
    public class EnvQueryItemType_Point : EnvQueryItemType_VectorBase
    {
        public EnvQueryItemType_Point(nint addr) : base(addr) { }
    }
    public class EnvQueryTest_Distance : EnvQueryTest
    {
        public EnvQueryTest_Distance(nint addr) : base(addr) { }
        public byte TestMode { get { return this[nameof(TestMode)].GetValue<byte>(); } set { this[nameof(TestMode)].SetValue<byte>(value); } }
        public Object DistanceTo { get { return this[nameof(DistanceTo)]; } set { this[nameof(DistanceTo)] = value; } }
    }
    public class EnvQueryTest_Dot : EnvQueryTest
    {
        public EnvQueryTest_Dot(nint addr) : base(addr) { }
        public EnvDirection LineA { get { return this[nameof(LineA)].As<EnvDirection>(); } set { this["LineA"] = value; } }
        public EnvDirection LineB { get { return this[nameof(LineB)].As<EnvDirection>(); } set { this["LineB"] = value; } }
        public EEnvTestDot TestMode { get { return (EEnvTestDot)this[nameof(TestMode)].GetValue<int>(); } set { this[nameof(TestMode)].SetValue<int>((int)value); } }
        public bool bAbsoluteValue { get { return this[nameof(bAbsoluteValue)].Flag; } set { this[nameof(bAbsoluteValue)].Flag = value; } }
    }
    public class EnvQueryTest_GameplayTags : EnvQueryTest
    {
        public EnvQueryTest_GameplayTags(nint addr) : base(addr) { }
        public GameplayTagQuery TagQueryToMatch { get { return this[nameof(TagQueryToMatch)].As<GameplayTagQuery>(); } set { this["TagQueryToMatch"] = value; } }
        public bool bRejectIncompatibleItems { get { return this[nameof(bRejectIncompatibleItems)].Flag; } set { this[nameof(bRejectIncompatibleItems)].Flag = value; } }
        public bool bUpdatedToUseQuery { get { return this[nameof(bUpdatedToUseQuery)].Flag; } set { this[nameof(bUpdatedToUseQuery)].Flag = value; } }
        public EGameplayContainerMatchType TagsToMatch { get { return (EGameplayContainerMatchType)this[nameof(TagsToMatch)].GetValue<int>(); } set { this[nameof(TagsToMatch)].SetValue<int>((int)value); } }
        public GameplayTagContainer GameplayTags { get { return this[nameof(GameplayTags)].As<GameplayTagContainer>(); } set { this["GameplayTags"] = value; } }
    }
    public class EnvQueryTest_Overlap : EnvQueryTest
    {
        public EnvQueryTest_Overlap(nint addr) : base(addr) { }
        public EnvOverlapData OverlapData { get { return this[nameof(OverlapData)].As<EnvOverlapData>(); } set { this["OverlapData"] = value; } }
    }
    public class EnvQueryTest_Pathfinding : EnvQueryTest
    {
        public EnvQueryTest_Pathfinding(nint addr) : base(addr) { }
        public byte TestMode { get { return this[nameof(TestMode)].GetValue<byte>(); } set { this[nameof(TestMode)].SetValue<byte>(value); } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public AIDataProviderBoolValue PathFromContext { get { return this[nameof(PathFromContext)].As<AIDataProviderBoolValue>(); } set { this["PathFromContext"] = value; } }
        public AIDataProviderBoolValue SkipUnreachable { get { return this[nameof(SkipUnreachable)].As<AIDataProviderBoolValue>(); } set { this["SkipUnreachable"] = value; } }
        public Object FilterClass { get { return this[nameof(FilterClass)]; } set { this[nameof(FilterClass)] = value; } }
    }
    public class EnvQueryTest_PathfindingBatch : EnvQueryTest_Pathfinding
    {
        public EnvQueryTest_PathfindingBatch(nint addr) : base(addr) { }
        public AIDataProviderFloatValue ScanRangeMultiplier { get { return this[nameof(ScanRangeMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ScanRangeMultiplier"] = value; } }
    }
    public class EnvQueryTest_Project : EnvQueryTest
    {
        public EnvQueryTest_Project(nint addr) : base(addr) { }
        public EnvTraceData ProjectionData { get { return this[nameof(ProjectionData)].As<EnvTraceData>(); } set { this["ProjectionData"] = value; } }
    }
    public class EnvQueryTest_Random : EnvQueryTest
    {
        public EnvQueryTest_Random(nint addr) : base(addr) { }
    }
    public class EnvQueryTest_Trace : EnvQueryTest
    {
        public EnvQueryTest_Trace(nint addr) : base(addr) { }
        public EnvTraceData TraceData { get { return this[nameof(TraceData)].As<EnvTraceData>(); } set { this["TraceData"] = value; } }
        public AIDataProviderBoolValue TraceFromContext { get { return this[nameof(TraceFromContext)].As<AIDataProviderBoolValue>(); } set { this["TraceFromContext"] = value; } }
        public AIDataProviderFloatValue ItemHeightOffset { get { return this[nameof(ItemHeightOffset)].As<AIDataProviderFloatValue>(); } set { this["ItemHeightOffset"] = value; } }
        public AIDataProviderFloatValue ContextHeightOffset { get { return this[nameof(ContextHeightOffset)].As<AIDataProviderFloatValue>(); } set { this["ContextHeightOffset"] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
    }
    public class EnvQueryTest_Volume : EnvQueryTest
    {
        public EnvQueryTest_Volume(nint addr) : base(addr) { }
        public Object VolumeContext { get { return this[nameof(VolumeContext)]; } set { this[nameof(VolumeContext)] = value; } }
        public Object VolumeClass { get { return this[nameof(VolumeClass)]; } set { this[nameof(VolumeClass)] = value; } }
        public bool bDoComplexVolumeTest { get { return this[nameof(bDoComplexVolumeTest)].Flag; } set { this[nameof(bDoComplexVolumeTest)].Flag = value; } }
    }
    public class GridPathAIController : AIController
    {
        public GridPathAIController(nint addr) : base(addr) { }
    }
    public class AIHotSpotManager : Object
    {
        public AIHotSpotManager(nint addr) : base(addr) { }
    }
    public class CrowdFollowingComponent : PathFollowingComponent
    {
        public CrowdFollowingComponent(nint addr) : base(addr) { }
        public Vector CrowdAgentMoveDirection { get { return this[nameof(CrowdAgentMoveDirection)].As<Vector>(); } set { this["CrowdAgentMoveDirection"] = value; } }
        public void SuspendCrowdSteering(bool bSuspend) { Invoke(nameof(SuspendCrowdSteering), bSuspend); }
    }
    public class CrowdManager : CrowdManagerBase
    {
        public CrowdManager(nint addr) : base(addr) { }
        public NavigationData MyNavData { get { return this[nameof(MyNavData)].As<NavigationData>(); } set { this["MyNavData"] = value; } }
        public Array<CrowdAvoidanceConfig> AvoidanceConfig { get { return new Array<CrowdAvoidanceConfig>(this[nameof(AvoidanceConfig)].Address); } }
        public Array<CrowdAvoidanceSamplingPattern> SamplingPatterns { get { return new Array<CrowdAvoidanceSamplingPattern>(this[nameof(SamplingPatterns)].Address); } }
        public int MaxAgents { get { return this[nameof(MaxAgents)].GetValue<int>(); } set { this[nameof(MaxAgents)].SetValue<int>(value); } }
        public float MaxAgentRadius { get { return this[nameof(MaxAgentRadius)].GetValue<float>(); } set { this[nameof(MaxAgentRadius)].SetValue<float>(value); } }
        public int MaxAvoidedAgents { get { return this[nameof(MaxAvoidedAgents)].GetValue<int>(); } set { this[nameof(MaxAvoidedAgents)].SetValue<int>(value); } }
        public int MaxAvoidedWalls { get { return this[nameof(MaxAvoidedWalls)].GetValue<int>(); } set { this[nameof(MaxAvoidedWalls)].SetValue<int>(value); } }
        public float NavmeshCheckInterval { get { return this[nameof(NavmeshCheckInterval)].GetValue<float>(); } set { this[nameof(NavmeshCheckInterval)].SetValue<float>(value); } }
        public float PathOptimizationInterval { get { return this[nameof(PathOptimizationInterval)].GetValue<float>(); } set { this[nameof(PathOptimizationInterval)].SetValue<float>(value); } }
        public float SeparationDirClamp { get { return this[nameof(SeparationDirClamp)].GetValue<float>(); } set { this[nameof(SeparationDirClamp)].SetValue<float>(value); } }
        public float PathOffsetRadiusMultiplier { get { return this[nameof(PathOffsetRadiusMultiplier)].GetValue<float>(); } set { this[nameof(PathOffsetRadiusMultiplier)].SetValue<float>(value); } }
        public bool bResolveCollisions { get { return this[nameof(bResolveCollisions)].Flag; } set { this[nameof(bResolveCollisions)].Flag = value; } }
    }
    public class GridPathFollowingComponent : PathFollowingComponent
    {
        public GridPathFollowingComponent(nint addr) : base(addr) { }
        public NavLocalGridManager GridManager { get { return this[nameof(GridManager)].As<NavLocalGridManager>(); } set { this["GridManager"] = value; } }
    }
    public class NavFilter_AIControllerDefault : NavigationQueryFilter
    {
        public NavFilter_AIControllerDefault(nint addr) : base(addr) { }
    }
    public class NavLinkProxy : Actor
    {
        public NavLinkProxy(nint addr) : base(addr) { }
        public Array<NavigationLink> PointLinks { get { return new Array<NavigationLink>(this[nameof(PointLinks)].Address); } }
        public Array<NavigationSegmentLink> SegmentLinks { get { return new Array<NavigationSegmentLink>(this[nameof(SegmentLinks)].Address); } }
        public NavLinkCustomComponent SmartLinkComp { get { return this[nameof(SmartLinkComp)].As<NavLinkCustomComponent>(); } set { this["SmartLinkComp"] = value; } }
        public bool bSmartLinkIsRelevant { get { return this[nameof(bSmartLinkIsRelevant)].Flag; } set { this[nameof(bSmartLinkIsRelevant)].Flag = value; } }
        public Object OnSmartLinkReached { get { return this[nameof(OnSmartLinkReached)]; } set { this[nameof(OnSmartLinkReached)] = value; } }
        public void SetSmartLinkEnabled(bool bEnabled) { Invoke(nameof(SetSmartLinkEnabled), bEnabled); }
        public void ResumePathFollowing(Actor Agent) { Invoke(nameof(ResumePathFollowing), Agent); }
        public void ReceiveSmartLinkReached(Actor Agent, Vector Destination) { Invoke(nameof(ReceiveSmartLinkReached), Agent, Destination); }
        public bool IsSmartLinkEnabled() { return Invoke<bool>(nameof(IsSmartLinkEnabled)); }
        public bool HasMovingAgents() { return Invoke<bool>(nameof(HasMovingAgents)); }
    }
    public class NavLocalGridManager : Object
    {
        public NavLocalGridManager(nint addr) : base(addr) { }
        public bool SetLocalNavigationGridDensity(Object WorldContextObject, float CellSize) { return Invoke<bool>(nameof(SetLocalNavigationGridDensity), WorldContextObject, CellSize); }
        public void RemoveLocalNavigationGrid(Object WorldContextObject, int GridId, bool bRebuildGrids) { Invoke(nameof(RemoveLocalNavigationGrid), WorldContextObject, GridId, bRebuildGrids); }
        public bool FindLocalNavigationGridPath(Object WorldContextObject, Vector Start, Vector End, Array<Vector> PathPoints) { return Invoke<bool>(nameof(FindLocalNavigationGridPath), WorldContextObject, Start, End, PathPoints); }
        public int AddLocalNavigationGridForPoints(Object WorldContextObject, Array<Vector> locations, int Radius2D, float Height, bool bRebuildGrids) { return Invoke<int>(nameof(AddLocalNavigationGridForPoints), WorldContextObject, locations, Radius2D, Height, bRebuildGrids); }
        public int AddLocalNavigationGridForPoint(Object WorldContextObject, Vector Location, int Radius2D, float Height, bool bRebuildGrids) { return Invoke<int>(nameof(AddLocalNavigationGridForPoint), WorldContextObject, Location, Radius2D, Height, bRebuildGrids); }
        public int AddLocalNavigationGridForCapsule(Object WorldContextObject, Vector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D, float Height, bool bRebuildGrids) { return Invoke<int>(nameof(AddLocalNavigationGridForCapsule), WorldContextObject, Location, CapsuleRadius, CapsuleHalfHeight, Radius2D, Height, bRebuildGrids); }
        public int AddLocalNavigationGridForBox(Object WorldContextObject, Vector Location, Vector Extent, Rotator Rotation, int Radius2D, float Height, bool bRebuildGrids) { return Invoke<int>(nameof(AddLocalNavigationGridForBox), WorldContextObject, Location, Extent, Rotation, Radius2D, Height, bRebuildGrids); }
    }
    public class PathFollowingManager : Object
    {
        public PathFollowingManager(nint addr) : base(addr) { }
    }
    public class AIPerceptionComponent : ActorComponent
    {
        public AIPerceptionComponent(nint addr) : base(addr) { }
        public Array<AISenseConfig> SensesConfig { get { return new Array<AISenseConfig>(this[nameof(SensesConfig)].Address); } }
        public Object DominantSense { get { return this[nameof(DominantSense)]; } set { this[nameof(DominantSense)] = value; } }
        public AIController AIOwner { get { return this[nameof(AIOwner)].As<AIController>(); } set { this["AIOwner"] = value; } }
        public Object OnPerceptionUpdated { get { return this[nameof(OnPerceptionUpdated)]; } set { this[nameof(OnPerceptionUpdated)] = value; } }
        public Object OnTargetPerceptionUpdated { get { return this[nameof(OnTargetPerceptionUpdated)]; } set { this[nameof(OnTargetPerceptionUpdated)] = value; } }
        public Object OnTargetPerceptionInfoUpdated { get { return this[nameof(OnTargetPerceptionInfoUpdated)]; } set { this[nameof(OnTargetPerceptionInfoUpdated)] = value; } }
        public void SetSenseEnabled(Object SenseClass, bool bEnable) { Invoke(nameof(SetSenseEnabled), SenseClass, bEnable); }
        public void RequestStimuliListenerUpdate() { Invoke(nameof(RequestStimuliListenerUpdate)); }
        public void OnOwnerEndPlay(Actor Actor, byte EndPlayReason) { Invoke(nameof(OnOwnerEndPlay), Actor, EndPlayReason); }
        public void GetPerceivedHostileActorsBySense(Object SenseToUse, Array<Actor> OutActors) { Invoke(nameof(GetPerceivedHostileActorsBySense), SenseToUse, OutActors); }
        public void GetPerceivedHostileActors(Array<Actor> OutActors) { Invoke(nameof(GetPerceivedHostileActors), OutActors); }
        public void GetPerceivedActors(Object SenseToUse, Array<Actor> OutActors) { Invoke(nameof(GetPerceivedActors), SenseToUse, OutActors); }
        public void GetKnownPerceivedActors(Object SenseToUse, Array<Actor> OutActors) { Invoke(nameof(GetKnownPerceivedActors), SenseToUse, OutActors); }
        public void GetCurrentlyPerceivedActors(Object SenseToUse, Array<Actor> OutActors) { Invoke(nameof(GetCurrentlyPerceivedActors), SenseToUse, OutActors); }
        public bool GetActorsPerception(Actor Actor, ActorPerceptionBlueprintInfo Info) { return Invoke<bool>(nameof(GetActorsPerception), Actor, Info); }
        public void ForgetAll() { Invoke(nameof(ForgetAll)); }
    }
    public class AIPerceptionListenerInterface : Interface
    {
        public AIPerceptionListenerInterface(nint addr) : base(addr) { }
    }
    public class AIPerceptionStimuliSourceComponent : ActorComponent
    {
        public AIPerceptionStimuliSourceComponent(nint addr) : base(addr) { }
        public bool bAutoRegisterAsSource { get { return this[nameof(bAutoRegisterAsSource)].Flag; } set { this[nameof(bAutoRegisterAsSource)].Flag = value; } }
        public Array<Object> RegisterAsSourceForSenses { get { return new Array<Object>(this[nameof(RegisterAsSourceForSenses)].Address); } }
        public void UnregisterFromSense(Object SenseClass) { Invoke(nameof(UnregisterFromSense), SenseClass); }
        public void UnregisterFromPerceptionSystem() { Invoke(nameof(UnregisterFromPerceptionSystem)); }
        public void RegisterWithPerceptionSystem() { Invoke(nameof(RegisterWithPerceptionSystem)); }
        public void RegisterForSense(Object SenseClass) { Invoke(nameof(RegisterForSense), SenseClass); }
    }
    public class AIPerceptionSystem : AISubsystem
    {
        public AIPerceptionSystem(nint addr) : base(addr) { }
        public Array<AISense> Senses { get { return new Array<AISense>(this[nameof(Senses)].Address); } }
        public float PerceptionAgingRate { get { return this[nameof(PerceptionAgingRate)].GetValue<float>(); } set { this[nameof(PerceptionAgingRate)].SetValue<float>(value); } }
        public void ReportPerceptionEvent(Object WorldContextObject, AISenseEvent PerceptionEvent) { Invoke(nameof(ReportPerceptionEvent), WorldContextObject, PerceptionEvent); }
        public void ReportEvent(AISenseEvent PerceptionEvent) { Invoke(nameof(ReportEvent), PerceptionEvent); }
        public bool RegisterPerceptionStimuliSource(Object WorldContextObject, Object Sense, Actor Target) { return Invoke<bool>(nameof(RegisterPerceptionStimuliSource), WorldContextObject, Sense, Target); }
        public void OnPerceptionStimuliSourceEndPlay(Actor Actor, byte EndPlayReason) { Invoke(nameof(OnPerceptionStimuliSourceEndPlay), Actor, EndPlayReason); }
        public Object GetSenseClassForStimulus(Object WorldContextObject, AIStimulus Stimulus) { return Invoke<Object>(nameof(GetSenseClassForStimulus), WorldContextObject, Stimulus); }
    }
    public class AISense : Object
    {
        public AISense(nint addr) : base(addr) { }
        public float DefaultExpirationAge { get { return this[nameof(DefaultExpirationAge)].GetValue<float>(); } set { this[nameof(DefaultExpirationAge)].SetValue<float>(value); } }
        public EAISenseNotifyType NotifyType { get { return (EAISenseNotifyType)this[nameof(NotifyType)].GetValue<int>(); } set { this[nameof(NotifyType)].SetValue<int>((int)value); } }
        public bool bWantsNewPawnNotification { get { return this[nameof(bWantsNewPawnNotification)].Flag; } set { this[nameof(bWantsNewPawnNotification)].Flag = value; } }
        public bool bAutoRegisterAllPawnsAsSources { get { return this[nameof(bAutoRegisterAllPawnsAsSources)].Flag; } set { this[nameof(bAutoRegisterAllPawnsAsSources)].Flag = value; } }
        public AIPerceptionSystem PerceptionSystemInstance { get { return this[nameof(PerceptionSystemInstance)].As<AIPerceptionSystem>(); } set { this["PerceptionSystemInstance"] = value; } }
    }
    public class AISenseConfig_Damage : AISenseConfig
    {
        public AISenseConfig_Damage(nint addr) : base(addr) { }
        public Object Implementation { get { return this[nameof(Implementation)]; } set { this[nameof(Implementation)] = value; } }
    }
    public class AISense_Blueprint : AISense
    {
        public AISense_Blueprint(nint addr) : base(addr) { }
        public Object ListenerDataType { get { return this[nameof(ListenerDataType)]; } set { this[nameof(ListenerDataType)] = value; } }
        public Array<AIPerceptionComponent> ListenerContainer { get { return new Array<AIPerceptionComponent>(this[nameof(ListenerContainer)].Address); } }
        public Array<AISenseEvent> UnprocessedEvents { get { return new Array<AISenseEvent>(this[nameof(UnprocessedEvents)].Address); } }
        public float OnUpdate(Array<AISenseEvent> EventsToProcess) { return Invoke<float>(nameof(OnUpdate), EventsToProcess); }
        public void OnListenerUpdated(Actor ActorListener, AIPerceptionComponent PerceptionComponent) { Invoke(nameof(OnListenerUpdated), ActorListener, PerceptionComponent); }
        public void OnListenerUnregistered(Actor ActorListener, AIPerceptionComponent PerceptionComponent) { Invoke(nameof(OnListenerUnregistered), ActorListener, PerceptionComponent); }
        public void OnListenerRegistered(Actor ActorListener, AIPerceptionComponent PerceptionComponent) { Invoke(nameof(OnListenerRegistered), ActorListener, PerceptionComponent); }
        public void K2_OnNewPawn(Pawn NewPawn) { Invoke(nameof(K2_OnNewPawn), NewPawn); }
        public void GetAllListenerComponents(Array<AIPerceptionComponent> ListenerComponents) { Invoke(nameof(GetAllListenerComponents), ListenerComponents); }
        public void GetAllListenerActors(Array<Actor> ListenerActors) { Invoke(nameof(GetAllListenerActors), ListenerActors); }
    }
    public class AISense_Damage : AISense
    {
        public AISense_Damage(nint addr) : base(addr) { }
        public Array<AIDamageEvent> RegisteredEvents { get { return new Array<AIDamageEvent>(this[nameof(RegisteredEvents)].Address); } }
        public void ReportDamageEvent(Object WorldContextObject, Actor DamagedActor, Actor Instigator, float DamageAmount, Vector EventLocation, Vector HitLocation, Object Tag) { Invoke(nameof(ReportDamageEvent), WorldContextObject, DamagedActor, Instigator, DamageAmount, EventLocation, HitLocation, Tag); }
    }
    public class AISense_Hearing : AISense
    {
        public AISense_Hearing(nint addr) : base(addr) { }
        public Array<AINoiseEvent> NoiseEvents { get { return new Array<AINoiseEvent>(this[nameof(NoiseEvents)].Address); } }
        public float SpeedOfSoundSq { get { return this[nameof(SpeedOfSoundSq)].GetValue<float>(); } set { this[nameof(SpeedOfSoundSq)].SetValue<float>(value); } }
        public void ReportNoiseEvent(Object WorldContextObject, Vector NoiseLocation, float Loudness, Actor Instigator, float MaxRange, Object Tag) { Invoke(nameof(ReportNoiseEvent), WorldContextObject, NoiseLocation, Loudness, Instigator, MaxRange, Tag); }
    }
    public class AISense_Prediction : AISense
    {
        public AISense_Prediction(nint addr) : base(addr) { }
        public Array<AIPredictionEvent> RegisteredEvents { get { return new Array<AIPredictionEvent>(this[nameof(RegisteredEvents)].Address); } }
        public void RequestPawnPredictionEvent(Pawn Requestor, Actor PredictedActor, float PredictionTime) { Invoke(nameof(RequestPawnPredictionEvent), Requestor, PredictedActor, PredictionTime); }
        public void RequestControllerPredictionEvent(AIController Requestor, Actor PredictedActor, float PredictionTime) { Invoke(nameof(RequestControllerPredictionEvent), Requestor, PredictedActor, PredictionTime); }
    }
    public class AISense_Sight : AISense
    {
        public AISense_Sight(nint addr) : base(addr) { }
        public int MaxTracesPerTick { get { return this[nameof(MaxTracesPerTick)].GetValue<int>(); } set { this[nameof(MaxTracesPerTick)].SetValue<int>(value); } }
        public int MinQueriesPerTimeSliceCheck { get { return this[nameof(MinQueriesPerTimeSliceCheck)].GetValue<int>(); } set { this[nameof(MinQueriesPerTimeSliceCheck)].SetValue<int>(value); } }
        public double MaxTimeSlicePerTick { get { return this[nameof(MaxTimeSlicePerTick)].GetValue<double>(); } set { this[nameof(MaxTimeSlicePerTick)].SetValue<double>(value); } }
        public float HighImportanceQueryDistanceThreshold { get { return this[nameof(HighImportanceQueryDistanceThreshold)].GetValue<float>(); } set { this[nameof(HighImportanceQueryDistanceThreshold)].SetValue<float>(value); } }
        public float MaxQueryImportance { get { return this[nameof(MaxQueryImportance)].GetValue<float>(); } set { this[nameof(MaxQueryImportance)].SetValue<float>(value); } }
        public float SightLimitQueryImportance { get { return this[nameof(SightLimitQueryImportance)].GetValue<float>(); } set { this[nameof(SightLimitQueryImportance)].SetValue<float>(value); } }
    }
    public class AISense_Team : AISense
    {
        public AISense_Team(nint addr) : base(addr) { }
        public Array<AITeamStimulusEvent> RegisteredEvents { get { return new Array<AITeamStimulusEvent>(this[nameof(RegisteredEvents)].Address); } }
    }
    public class AISense_Touch : AISense
    {
        public AISense_Touch(nint addr) : base(addr) { }
        public Array<AITouchEvent> RegisteredEvents { get { return new Array<AITouchEvent>(this[nameof(RegisteredEvents)].Address); } }
        public void ReportTouchEvent(Object WorldContextObject, Actor TouchReceiver, Actor OtherActor, Vector Location) { Invoke(nameof(ReportTouchEvent), WorldContextObject, TouchReceiver, OtherActor, Location); }
    }
    public class AISightTargetInterface : Interface
    {
        public AISightTargetInterface(nint addr) : base(addr) { }
    }
    public class PawnSensingComponent : ActorComponent
    {
        public PawnSensingComponent(nint addr) : base(addr) { }
        public float HearingThreshold { get { return this[nameof(HearingThreshold)].GetValue<float>(); } set { this[nameof(HearingThreshold)].SetValue<float>(value); } }
        public float LOSHearingThreshold { get { return this[nameof(LOSHearingThreshold)].GetValue<float>(); } set { this[nameof(LOSHearingThreshold)].SetValue<float>(value); } }
        public float SightRadius { get { return this[nameof(SightRadius)].GetValue<float>(); } set { this[nameof(SightRadius)].SetValue<float>(value); } }
        public float SensingInterval { get { return this[nameof(SensingInterval)].GetValue<float>(); } set { this[nameof(SensingInterval)].SetValue<float>(value); } }
        public float HearingMaxSoundAge { get { return this[nameof(HearingMaxSoundAge)].GetValue<float>(); } set { this[nameof(HearingMaxSoundAge)].SetValue<float>(value); } }
        public bool bEnableSensingUpdates { get { return this[nameof(bEnableSensingUpdates)].Flag; } set { this[nameof(bEnableSensingUpdates)].Flag = value; } }
        public bool bOnlySensePlayers { get { return this[nameof(bOnlySensePlayers)].Flag; } set { this[nameof(bOnlySensePlayers)].Flag = value; } }
        public bool bSeePawns { get { return this[nameof(bSeePawns)].Flag; } set { this[nameof(bSeePawns)].Flag = value; } }
        public bool bHearNoises { get { return this[nameof(bHearNoises)].Flag; } set { this[nameof(bHearNoises)].Flag = value; } }
        public Object OnSeePawn { get { return this[nameof(OnSeePawn)]; } set { this[nameof(OnSeePawn)] = value; } }
        public Object OnHearNoise { get { return this[nameof(OnHearNoise)]; } set { this[nameof(OnHearNoise)] = value; } }
        public float PeripheralVisionAngle { get { return this[nameof(PeripheralVisionAngle)].GetValue<float>(); } set { this[nameof(PeripheralVisionAngle)].SetValue<float>(value); } }
        public float PeripheralVisionCosine { get { return this[nameof(PeripheralVisionCosine)].GetValue<float>(); } set { this[nameof(PeripheralVisionCosine)].SetValue<float>(value); } }
        public void SetSensingUpdatesEnabled(bool bEnabled) { Invoke(nameof(SetSensingUpdatesEnabled), bEnabled); }
        public void SetSensingInterval(float NewSensingInterval) { Invoke(nameof(SetSensingInterval), NewSensingInterval); }
        public void SetPeripheralVisionAngle(float NewPeripheralVisionAngle) { Invoke(nameof(SetPeripheralVisionAngle), NewPeripheralVisionAngle); }
        public void SeePawnDelegate__DelegateSignature(Pawn Pawn) { Invoke(nameof(SeePawnDelegate__DelegateSignature), Pawn); }
        public void HearNoiseDelegate__DelegateSignature(Pawn Instigator, Vector Location, float Volume) { Invoke(nameof(HearNoiseDelegate__DelegateSignature), Instigator, Location, Volume); }
        public float GetPeripheralVisionCosine() { return Invoke<float>(nameof(GetPeripheralVisionCosine)); }
        public float GetPeripheralVisionAngle() { return Invoke<float>(nameof(GetPeripheralVisionAngle)); }
    }
    public class AITask : GameplayTask
    {
        public AITask(nint addr) : base(addr) { }
        public AIController OwnerController { get { return this[nameof(OwnerController)].As<AIController>(); } set { this["OwnerController"] = value; } }
    }
    public class AITask_LockLogic : AITask
    {
        public AITask_LockLogic(nint addr) : base(addr) { }
    }
    public class AITask_MoveTo : AITask
    {
        public AITask_MoveTo(nint addr) : base(addr) { }
        public Object OnRequestFailed { get { return this[nameof(OnRequestFailed)]; } set { this[nameof(OnRequestFailed)] = value; } }
        public Object OnMoveFinished { get { return this[nameof(OnMoveFinished)]; } set { this[nameof(OnMoveFinished)] = value; } }
        public AIMoveRequest MoveRequest { get { return this[nameof(MoveRequest)].As<AIMoveRequest>(); } set { this["MoveRequest"] = value; } }
        public AITask_MoveTo AIMoveTo(AIController Controller, Vector GoalLocation, Actor GoalActor, float AcceptanceRadius, byte StopOnOverlap, byte AcceptPartialPath, bool bUsePathfinding, bool bLockAILogic, bool bUseContinuousGoalTracking, byte ProjectGoalOnNavigation) { return Invoke<AITask_MoveTo>(nameof(AIMoveTo), Controller, GoalLocation, GoalActor, AcceptanceRadius, StopOnOverlap, AcceptPartialPath, bUsePathfinding, bLockAILogic, bUseContinuousGoalTracking, ProjectGoalOnNavigation); }
    }
    public class AITask_RunEQS : AITask
    {
        public AITask_RunEQS(nint addr) : base(addr) { }
        public AITask_RunEQS RunEQS(AIController Controller, EnvQuery QueryTemplate) { return Invoke<AITask_RunEQS>(nameof(RunEQS), Controller, QueryTemplate); }
    }
    public class VisualLoggerExtension : Object
    {
        public VisualLoggerExtension(nint addr) : base(addr) { }
    }
    public class ActorPerceptionUpdateInfo : Object
    {
        public ActorPerceptionUpdateInfo(nint addr) : base(addr) { }
        public int TargetId { get { return this[nameof(TargetId)].GetValue<int>(); } set { this[nameof(TargetId)].SetValue<int>(value); } }
        public Object Target { get { return this[nameof(Target)]; } set { this[nameof(Target)] = value; } }
        public AIStimulus Stimulus { get { return this[nameof(Stimulus)].As<AIStimulus>(); } set { this["Stimulus"] = value; } }
    }
    public class AIStimulus : Object
    {
        public AIStimulus(nint addr) : base(addr) { }
        public float Age { get { return this[nameof(Age)].GetValue<float>(); } set { this[nameof(Age)].SetValue<float>(value); } }
        public float ExpirationAge { get { return this[nameof(ExpirationAge)].GetValue<float>(); } set { this[nameof(ExpirationAge)].SetValue<float>(value); } }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public Vector StimulusLocation { get { return this[nameof(StimulusLocation)].As<Vector>(); } set { this["StimulusLocation"] = value; } }
        public Vector ReceiverLocation { get { return this[nameof(ReceiverLocation)].As<Vector>(); } set { this["ReceiverLocation"] = value; } }
        public Object Tag { get { return this[nameof(Tag)]; } set { this[nameof(Tag)] = value; } }
        public bool bSuccessfullySensed { get { return this[nameof(bSuccessfullySensed)].Flag; } set { this[nameof(bSuccessfullySensed)].Flag = value; } }
    }
    public enum EPathFollowingResult : int
    {
        Success = 0,
        Blocked = 1,
        OffPath = 2,
        Aborted = 3,
        Skipped_DEPRECATED = 4,
        Invalid = 5,
        EPathFollowingResult_MAX = 6,
    }
    public class AIRequestID : Object
    {
        public AIRequestID(nint addr) : base(addr) { }
        public uint RequestID { get { return this[nameof(RequestID)].GetValue<uint>(); } set { this[nameof(RequestID)].SetValue<uint>(value); } }
    }
    public enum EEnvQueryStatus : int
    {
        Processing = 0,
        Success = 1,
        Failed = 2,
        Aborted = 3,
        OwnerLost = 4,
        MissingParam = 5,
        EEnvQueryStatus_MAX = 6,
    }
    public enum EPawnActionResult : int
    {
        NotStarted = 0,
        InProgress = 1,
        Success = 2,
        Failed = 3,
        Aborted = 4,
        EPawnActionResult_MAX = 5,
    }
    public enum EAIRequestPriority : int
    {
        SoftScript = 0,
        SoftScriptInterrupt = 1,
        Logic = 10,
        HardScript = 11,
        Reaction = 12,
        Ultimate = 13,
        MAX = 14,
    }
    public enum EAIOptionFlag : int
    {
        Default = 0,
        Enable = 1,
        Disable = 2,
        MAX = 3,
    }
    public enum FAIDistanceType : int
    {
        Distance3D = 0,
        Distance2D = 1,
        DistanceZ = 2,
        MAX = 3,
    }
    public enum EPawnActionAbortState : int
    {
        NeverStarted = 0,
        NotBeingAborted = 1,
        MarkPendingAbort = 2,
        LatentAbortInProgress = 3,
        AbortDone = 4,
        MAX = 5,
    }
    public enum EPawnActionEventType : int
    {
        Invalid = 0,
        FailedToStart = 1,
        InstantAbort = 2,
        FinishedAborting = 3,
        FinishedExecution = 4,
        Push = 5,
        EPawnActionEventType_MAX = 6,
    }
    public enum EAILockSource : int
    {
        Animation = 0,
        Logic = 1,
        Script = 2,
        Gameplay = 3,
        MAX = 4,
    }
    public enum EGenericAICheck : int
    {
        Less = 0,
        LessOrEqual = 1,
        Equal = 2,
        NotEqual = 3,
        GreaterOrEqual = 4,
        Greater = 5,
        IsTrue = 6,
        MAX = 7,
    }
    public enum EEnvTestPurpose : int
    {
        Filter = 0,
        Score = 1,
        FilterAndScore = 2,
        EEnvTestPurpose_MAX = 3,
    }
    public enum EEnvTestFilterType : int
    {
        Minimum = 0,
        Maximum = 1,
        Range = 2,
        Match = 3,
        EEnvTestFilterType_MAX = 4,
    }
    public enum EEnvTestScoreEquation : int
    {
        Linear = 0,
        Square = 1,
        InverseLinear = 2,
        SquareRoot = 3,
        Constant = 4,
        EEnvTestScoreEquation_MAX = 5,
    }
    public enum EEnvTestWeight : int
    {
        None = 0,
        Square = 1,
        Inverse = 2,
        Unused = 3,
        Constant = 4,
        Skip = 5,
        EEnvTestWeight_MAX = 6,
    }
    public enum EEnvTestCost : int
    {
        Low = 0,
        Medium = 1,
        High = 2,
        EEnvTestCost_MAX = 3,
    }
    public enum EEnvTestFilterOperator : int
    {
        AllPass = 0,
        AnyPass = 1,
        EEnvTestFilterOperator_MAX = 2,
    }
    public enum EEnvTestScoreOperator : int
    {
        AverageScore = 0,
        MinScore = 1,
        MaxScore = 2,
        Multiply = 3,
        EEnvTestScoreOperator_MAX = 4,
    }
    public enum EEnvQueryRunMode : int
    {
        SingleResult = 0,
        RandomBest5Pct = 1,
        RandomBest25Pct = 2,
        AllMatching = 3,
        EEnvQueryRunMode_MAX = 4,
    }
    public enum EEnvQueryParam : int
    {
        Float = 0,
        Int = 1,
        Bool = 2,
        EEnvQueryParam_MAX = 3,
    }
    public enum EAIParamType : int
    {
        Float = 0,
        Int = 1,
        Bool = 2,
        MAX = 3,
    }
    public enum EEnvQueryTrace : int
    {
        None = 0,
        Navigation = 1,
        GeometryByChannel = 2,
        GeometryByProfile = 3,
        NavigationOverLedges = 4,
        EEnvQueryTrace_MAX = 5,
    }
    public enum EEnvTraceShape : int
    {
        Line = 0,
        Box = 1,
        Sphere = 2,
        Capsule = 3,
        EEnvTraceShape_MAX = 4,
    }
    public enum EEnvOverlapShape : int
    {
        Box = 0,
        Sphere = 1,
        Capsule = 2,
        EEnvOverlapShape_MAX = 3,
    }
    public enum EEnvDirection : int
    {
        TwoPoints = 0,
        Rotation = 1,
        EEnvDirection_MAX = 2,
    }
    public enum EEnvQueryTestClamping : int
    {
        None = 0,
        SpecifiedValue = 1,
        FilterThreshold = 2,
        EEnvQueryTestClamping_MAX = 3,
    }
    public enum ETeamAttitude : int
    {
        Friendly = 0,
        Neutral = 1,
        Hostile = 2,
        ETeamAttitude_MAX = 3,
    }
    public enum EPawnSubActionTriggeringPolicy : int
    {
        CopyBeforeTriggering = 0,
        ReuseInstances = 1,
        EPawnSubActionTriggeringPolicy_MAX = 2,
    }
    public enum EPawnActionFailHandling : int
    {
        RequireSuccess = 0,
        IgnoreFailure = 1,
        EPawnActionFailHandling_MAX = 2,
    }
    public enum EPawnActionMoveMode : int
    {
        UsePathfinding = 0,
        StraightLine = 1,
        EPawnActionMoveMode_MAX = 2,
    }
    public enum EBTNodeResult : int
    {
        Succeeded = 0,
        Failed = 1,
        Aborted = 2,
        InProgress = 3,
        EBTNodeResult_MAX = 4,
    }
    public enum EBTFlowAbortMode : int
    {
        None = 0,
        LowerPriority = 1,
        Self = 2,
        Both = 3,
        EBTFlowAbortMode_MAX = 4,
    }
    public enum EBasicKeyOperation : int
    {
        Set = 0,
        NotSet = 1,
        EBasicKeyOperation_MAX = 2,
    }
    public enum EArithmeticKeyOperation : int
    {
        Equal = 0,
        NotEqual = 1,
        Less = 2,
        LessOrEqual = 3,
        Greater = 4,
        GreaterOrEqual = 5,
        EArithmeticKeyOperation_MAX = 6,
    }
    public enum ETextKeyOperation : int
    {
        Equal = 0,
        NotEqual = 1,
        Contain = 2,
        NotContain = 3,
        ETextKeyOperation_MAX = 4,
    }
    public enum EBTChildIndex : int
    {
        FirstNode = 0,
        TaskNode = 1,
        EBTChildIndex_MAX = 2,
    }
    public enum EBTDecoratorLogic : int
    {
        Invalid = 0,
        Test = 1,
        And = 2,
        Or = 3,
        Not = 4,
        EBTDecoratorLogic_MAX = 5,
    }
    public enum EBTParallelMode : int
    {
        AbortBackground = 0,
        WaitForBackground = 1,
        EBTParallelMode_MAX = 2,
    }
    public enum EBTBlackboardRestart : int
    {
        ValueChange = 0,
        ResultChange = 1,
        EBTBlackboardRestart_MAX = 2,
    }
    public enum EBlackBoardEntryComparison : int
    {
        Equal = 0,
        NotEqual = 1,
        EBlackBoardEntryComparison_MAX = 2,
    }
    public enum EPathExistanceQueryType : int
    {
        NavmeshRaycast2D = 0,
        HierarchicalQuery = 1,
        RegularPathFinding = 2,
        EPathExistanceQueryType_MAX = 3,
    }
    public enum EEQSNormalizationType : int
    {
        Absolute = 0,
        RelativeToScores = 1,
        EEQSNormalizationType_MAX = 2,
    }
    public enum EEnvQueryHightlightMode : int
    {
        All = 0,
        Best5Pct = 1,
        Best25Pct = 2,
        EEnvQueryHightlightMode_MAX = 3,
    }
    public enum EPointOnCircleSpacingMethod : int
    {
        BySpaceBetween = 0,
        ByNumberOfPoints = 1,
        EPointOnCircleSpacingMethod_MAX = 2,
    }
    public enum EEnvTestDistance : int
    {
        Distance3D = 0,
        Distance2D = 1,
        DistanceZ = 2,
        DistanceAbsoluteZ = 3,
        EEnvTestDistance_MAX = 4,
    }
    public enum EEnvTestDot : int
    {
        Dot3D = 0,
        Dot2D = 1,
        EEnvTestDot_MAX = 2,
    }
    public enum EEnvTestPathfinding : int
    {
        PathExist = 0,
        PathCost = 1,
        PathLength = 2,
        EEnvTestPathfinding_MAX = 3,
    }
    public enum EPathFollowingStatus : int
    {
        Idle = 0,
        Waiting = 1,
        Paused = 2,
        Moving = 3,
        EPathFollowingStatus_MAX = 4,
    }
    public enum EPathFollowingAction : int
    {
        Error = 0,
        NoMove = 1,
        DirectMove = 2,
        PartialPath = 3,
        PathToGoal = 4,
        EPathFollowingAction_MAX = 5,
    }
    public enum EPathFollowingRequestResult : int
    {
        Failed = 0,
        AlreadyAtGoal = 1,
        RequestSuccessful = 2,
        EPathFollowingRequestResult_MAX = 3,
    }
    public enum EAISenseNotifyType : int
    {
        OnEveryPerception = 0,
        OnPerceptionChange = 1,
        EAISenseNotifyType_MAX = 2,
    }
    public enum EAITaskPriority : int
    {
        Lowest = 0,
        Low = 64,
        AutonomousAI = 127,
        High = 192,
        Ultimate = 254,
        EAITaskPriority_MAX = 255,
    }
    public class AIMoveRequest : Object
    {
        public AIMoveRequest(nint addr) : base(addr) { }
        public Object GoalActor { get { return this[nameof(GoalActor)]; } set { this[nameof(GoalActor)] = value; } }
    }
    public class IntervalCountdown : Object
    {
        public IntervalCountdown(nint addr) : base(addr) { }
        public float Interval { get { return this[nameof(Interval)].GetValue<float>(); } set { this[nameof(Interval)].SetValue<float>(value); } }
    }
    public class EnvNamedValue : Object
    {
        public EnvNamedValue(nint addr) : base(addr) { }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
        public EAIParamType ParamType { get { return (EAIParamType)this[nameof(ParamType)].GetValue<int>(); } set { this[nameof(ParamType)].SetValue<int>((int)value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class EnvDirection : Object
    {
        public EnvDirection(nint addr) : base(addr) { }
        public Object LineFrom { get { return this[nameof(LineFrom)]; } set { this[nameof(LineFrom)] = value; } }
        public Object LineTo { get { return this[nameof(LineTo)]; } set { this[nameof(LineTo)] = value; } }
        public Object Rotation { get { return this[nameof(Rotation)]; } set { this[nameof(Rotation)] = value; } }
        public byte DirMode { get { return this[nameof(DirMode)].GetValue<byte>(); } set { this[nameof(DirMode)].SetValue<byte>(value); } }
    }
    public class EnvTraceData : Object
    {
        public EnvTraceData(nint addr) : base(addr) { }
        public int VersionNum { get { return this[nameof(VersionNum)].GetValue<int>(); } set { this[nameof(VersionNum)].SetValue<int>(value); } }
        public Object NavigationFilter { get { return this[nameof(NavigationFilter)]; } set { this[nameof(NavigationFilter)] = value; } }
        public float ProjectDown { get { return this[nameof(ProjectDown)].GetValue<float>(); } set { this[nameof(ProjectDown)].SetValue<float>(value); } }
        public float ProjectUp { get { return this[nameof(ProjectUp)].GetValue<float>(); } set { this[nameof(ProjectUp)].SetValue<float>(value); } }
        public float ExtentX { get { return this[nameof(ExtentX)].GetValue<float>(); } set { this[nameof(ExtentX)].SetValue<float>(value); } }
        public float ExtentY { get { return this[nameof(ExtentY)].GetValue<float>(); } set { this[nameof(ExtentY)].SetValue<float>(value); } }
        public float ExtentZ { get { return this[nameof(ExtentZ)].GetValue<float>(); } set { this[nameof(ExtentZ)].SetValue<float>(value); } }
        public float PostProjectionVerticalOffset { get { return this[nameof(PostProjectionVerticalOffset)].GetValue<float>(); } set { this[nameof(PostProjectionVerticalOffset)].SetValue<float>(value); } }
        public byte TraceChannel { get { return this[nameof(TraceChannel)].GetValue<byte>(); } set { this[nameof(TraceChannel)].SetValue<byte>(value); } }
        public byte SerializedChannel { get { return this[nameof(SerializedChannel)].GetValue<byte>(); } set { this[nameof(SerializedChannel)].SetValue<byte>(value); } }
        public Object TraceProfileName { get { return this[nameof(TraceProfileName)]; } set { this[nameof(TraceProfileName)] = value; } }
        public byte TraceShape { get { return this[nameof(TraceShape)].GetValue<byte>(); } set { this[nameof(TraceShape)].SetValue<byte>(value); } }
        public byte TraceMode { get { return this[nameof(TraceMode)].GetValue<byte>(); } set { this[nameof(TraceMode)].SetValue<byte>(value); } }
        public bool bTraceComplex { get { return this[nameof(bTraceComplex)].Flag; } set { this[nameof(bTraceComplex)].Flag = value; } }
        public bool bOnlyBlockingHits { get { return this[nameof(bOnlyBlockingHits)].Flag; } set { this[nameof(bOnlyBlockingHits)].Flag = value; } }
        public bool bCanTraceOnNavMesh { get { return this[nameof(bCanTraceOnNavMesh)].Flag; } set { this[nameof(bCanTraceOnNavMesh)].Flag = value; } }
        public bool bCanTraceOnGeometry { get { return this[nameof(bCanTraceOnGeometry)].Flag; } set { this[nameof(bCanTraceOnGeometry)].Flag = value; } }
        public bool bCanDisableTrace { get { return this[nameof(bCanDisableTrace)].Flag; } set { this[nameof(bCanDisableTrace)].Flag = value; } }
        public bool bCanProjectDown { get { return this[nameof(bCanProjectDown)].Flag; } set { this[nameof(bCanProjectDown)].Flag = value; } }
    }
    public class EnvOverlapData : Object
    {
        public EnvOverlapData(nint addr) : base(addr) { }
        public float ExtentX { get { return this[nameof(ExtentX)].GetValue<float>(); } set { this[nameof(ExtentX)].SetValue<float>(value); } }
        public float ExtentY { get { return this[nameof(ExtentY)].GetValue<float>(); } set { this[nameof(ExtentY)].SetValue<float>(value); } }
        public float ExtentZ { get { return this[nameof(ExtentZ)].GetValue<float>(); } set { this[nameof(ExtentZ)].SetValue<float>(value); } }
        public Vector ShapeOffset { get { return this[nameof(ShapeOffset)].As<Vector>(); } set { this["ShapeOffset"] = value; } }
        public byte OverlapChannel { get { return this[nameof(OverlapChannel)].GetValue<byte>(); } set { this[nameof(OverlapChannel)].SetValue<byte>(value); } }
        public byte OverlapShape { get { return this[nameof(OverlapShape)].GetValue<byte>(); } set { this[nameof(OverlapShape)].SetValue<byte>(value); } }
        public bool bOnlyBlockingHits { get { return this[nameof(bOnlyBlockingHits)].Flag; } set { this[nameof(bOnlyBlockingHits)].Flag = value; } }
        public bool bOverlapComplex { get { return this[nameof(bOverlapComplex)].Flag; } set { this[nameof(bOverlapComplex)].Flag = value; } }
        public bool bSkipOverlapQuerier { get { return this[nameof(bSkipOverlapQuerier)].Flag; } set { this[nameof(bSkipOverlapQuerier)].Flag = value; } }
    }
    public class EnvQueryResult : Object
    {
        public EnvQueryResult(nint addr) : base(addr) { }
        public Object ItemType { get { return this[nameof(ItemType)]; } set { this[nameof(ItemType)] = value; } }
        public int OptionIndex { get { return this[nameof(OptionIndex)].GetValue<int>(); } set { this[nameof(OptionIndex)].SetValue<int>(value); } }
        public int QueryID { get { return this[nameof(QueryID)].GetValue<int>(); } set { this[nameof(QueryID)].SetValue<int>(value); } }
    }
    public class AIDynamicParam : Object
    {
        public AIDynamicParam(nint addr) : base(addr) { }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
        public EAIParamType ParamType { get { return (EAIParamType)this[nameof(ParamType)].GetValue<int>(); } set { this[nameof(ParamType)].SetValue<int>((int)value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public BlackboardKeySelector BBKey { get { return this[nameof(BBKey)].As<BlackboardKeySelector>(); } set { this["BBKey"] = value; } }
    }
    public class BlackboardKeySelector : Object
    {
        public BlackboardKeySelector(nint addr) : base(addr) { }
        public Array<BlackboardKeyType> AllowedTypes { get { return new Array<BlackboardKeyType>(this[nameof(AllowedTypes)].Address); } }
        public Object SelectedKeyName { get { return this[nameof(SelectedKeyName)]; } set { this[nameof(SelectedKeyName)] = value; } }
        public Object SelectedKeyType { get { return this[nameof(SelectedKeyType)]; } set { this[nameof(SelectedKeyType)] = value; } }
        public byte SelectedKeyID { get { return this[nameof(SelectedKeyID)].GetValue<byte>(); } set { this[nameof(SelectedKeyID)].SetValue<byte>(value); } }
        public bool bNoneIsAllowedValue { get { return this[nameof(bNoneIsAllowedValue)].Flag; } set { this[nameof(bNoneIsAllowedValue)].Flag = value; } }
    }
    public class EQSParametrizedQueryExecutionRequest : Object
    {
        public EQSParametrizedQueryExecutionRequest(nint addr) : base(addr) { }
        public EnvQuery QueryTemplate { get { return this[nameof(QueryTemplate)].As<EnvQuery>(); } set { this["QueryTemplate"] = value; } }
        public Array<AIDynamicParam> QueryConfig { get { return new Array<AIDynamicParam>(this[nameof(QueryConfig)].Address); } }
        public BlackboardKeySelector EQSQueryBlackboardKey { get { return this[nameof(EQSQueryBlackboardKey)].As<BlackboardKeySelector>(); } set { this["EQSQueryBlackboardKey"] = value; } }
        public byte RunMode { get { return this[nameof(RunMode)].GetValue<byte>(); } set { this[nameof(RunMode)].SetValue<byte>(value); } }
        public bool bUseBBKeyForQueryTemplate { get { return this[nameof(bUseBBKeyForQueryTemplate)].Flag; } set { this[nameof(bUseBBKeyForQueryTemplate)].Flag = value; } }
    }
    public class GenericTeamId : Object
    {
        public GenericTeamId(nint addr) : base(addr) { }
        public byte TeamID { get { return this[nameof(TeamID)].GetValue<byte>(); } set { this[nameof(TeamID)].SetValue<byte>(value); } }
    }
    public class SimpleIndexedHandleBase : Object
    {
        public SimpleIndexedHandleBase(nint addr) : base(addr) { }
    }
    public class IndexedHandleBase : SimpleIndexedHandleBase
    {
        public IndexedHandleBase(nint addr) : base(addr) { }
    }
    public class CompactIndexedHandleBase : Object
    {
        public CompactIndexedHandleBase(nint addr) : base(addr) { }
    }
    public class SequentialIDBase : Object
    {
        public SequentialIDBase(nint addr) : base(addr) { }
        public uint Value { get { return this[nameof(Value)].GetValue<uint>(); } set { this[nameof(Value)].SetValue<uint>(value); } }
    }
    public class PawnActionEvent : Object
    {
        public PawnActionEvent(nint addr) : base(addr) { }
        public PawnAction action { get { return this[nameof(action)].As<PawnAction>(); } set { this["action"] = value; } }
    }
    public class PawnActionStack : Object
    {
        public PawnActionStack(nint addr) : base(addr) { }
        public PawnAction TopAction { get { return this[nameof(TopAction)].As<PawnAction>(); } set { this["TopAction"] = value; } }
    }
    public class BehaviorTreeTemplateInfo : Object
    {
        public BehaviorTreeTemplateInfo(nint addr) : base(addr) { }
        public BehaviorTree Asset { get { return this[nameof(Asset)].As<BehaviorTree>(); } set { this["Asset"] = value; } }
        public BTCompositeNode Template { get { return this[nameof(Template)].As<BTCompositeNode>(); } set { this["Template"] = value; } }
    }
    public class BlackboardEntry : Object
    {
        public BlackboardEntry(nint addr) : base(addr) { }
        public Object EntryName { get { return this[nameof(EntryName)]; } set { this[nameof(EntryName)] = value; } }
        public BlackboardKeyType KeyType { get { return this[nameof(KeyType)].As<BlackboardKeyType>(); } set { this["KeyType"] = value; } }
        public bool bInstanceSynced { get { return this[nameof(bInstanceSynced)].Flag; } set { this[nameof(bInstanceSynced)].Flag = value; } }
    }
    public class BTDecoratorLogic : Object
    {
        public BTDecoratorLogic(nint addr) : base(addr) { }
        public byte Operation { get { return this[nameof(Operation)].GetValue<byte>(); } set { this[nameof(Operation)].SetValue<byte>(value); } }
        public ushort Number { get { return this[nameof(Number)].GetValue<ushort>(); } set { this[nameof(Number)].SetValue<ushort>(value); } }
    }
    public class BTCompositeChild : Object
    {
        public BTCompositeChild(nint addr) : base(addr) { }
        public BTCompositeNode ChildComposite { get { return this[nameof(ChildComposite)].As<BTCompositeNode>(); } set { this["ChildComposite"] = value; } }
        public BTTaskNode ChildTask { get { return this[nameof(ChildTask)].As<BTTaskNode>(); } set { this["ChildTask"] = value; } }
        public Array<BTDecorator> Decorators { get { return new Array<BTDecorator>(this[nameof(Decorators)].Address); } }
        public Array<BTDecoratorLogic> DecoratorOps { get { return new Array<BTDecoratorLogic>(this[nameof(DecoratorOps)].Address); } }
    }
    public class AIDataProviderValue : Object
    {
        public AIDataProviderValue(nint addr) : base(addr) { }
        public AIDataProvider DataBinding { get { return this[nameof(DataBinding)].As<AIDataProvider>(); } set { this["DataBinding"] = value; } }
        public Object DataField { get { return this[nameof(DataField)]; } set { this[nameof(DataField)] = value; } }
    }
    public class AIDataProviderTypedValue : AIDataProviderValue
    {
        public AIDataProviderTypedValue(nint addr) : base(addr) { }
        public Object PropertyType { get { return this[nameof(PropertyType)].As<Object>(); } set { this["PropertyType"] = value; } } // ClassPtrProperty
    }
    public class AIDataProviderStructValue : AIDataProviderValue
    {
        public AIDataProviderStructValue(nint addr) : base(addr) { }
    }
    public class AIDataProviderIntValue : AIDataProviderTypedValue
    {
        public AIDataProviderIntValue(nint addr) : base(addr) { }
        public int DefaultValue { get { return this[nameof(DefaultValue)].GetValue<int>(); } set { this[nameof(DefaultValue)].SetValue<int>(value); } }
    }
    public class AIDataProviderFloatValue : AIDataProviderTypedValue
    {
        public AIDataProviderFloatValue(nint addr) : base(addr) { }
        public float DefaultValue { get { return this[nameof(DefaultValue)].GetValue<float>(); } set { this[nameof(DefaultValue)].SetValue<float>(value); } }
    }
    public class AIDataProviderBoolValue : AIDataProviderTypedValue
    {
        public AIDataProviderBoolValue(nint addr) : base(addr) { }
        public bool DefaultValue { get { return this[nameof(DefaultValue)].Flag; } set { this[nameof(DefaultValue)].Flag = value; } }
    }
    public class EnvQueryManagerConfig : Object
    {
        public EnvQueryManagerConfig(nint addr) : base(addr) { }
        public float MaxAllowedTestingTime { get { return this[nameof(MaxAllowedTestingTime)].GetValue<float>(); } set { this[nameof(MaxAllowedTestingTime)].SetValue<float>(value); } }
        public bool bTestQueriesUsingBreadth { get { return this[nameof(bTestQueriesUsingBreadth)].Flag; } set { this[nameof(bTestQueriesUsingBreadth)].Flag = value; } }
        public int QueryCountWarningThreshold { get { return this[nameof(QueryCountWarningThreshold)].GetValue<int>(); } set { this[nameof(QueryCountWarningThreshold)].SetValue<int>(value); } }
        public double QueryCountWarningInterval { get { return this[nameof(QueryCountWarningInterval)].GetValue<double>(); } set { this[nameof(QueryCountWarningInterval)].SetValue<double>(value); } }
        public double ExecutionTimeWarningSeconds { get { return this[nameof(ExecutionTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(ExecutionTimeWarningSeconds)].SetValue<double>(value); } }
        public double HandlingResultTimeWarningSeconds { get { return this[nameof(HandlingResultTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(HandlingResultTimeWarningSeconds)].SetValue<double>(value); } }
        public double GenerationTimeWarningSeconds { get { return this[nameof(GenerationTimeWarningSeconds)].GetValue<double>(); } set { this[nameof(GenerationTimeWarningSeconds)].SetValue<double>(value); } }
    }
    public class EnvQueryRequest : Object
    {
        public EnvQueryRequest(nint addr) : base(addr) { }
        public EnvQuery QueryTemplate { get { return this[nameof(QueryTemplate)].As<EnvQuery>(); } set { this["QueryTemplate"] = value; } }
        public Object Owner { get { return this[nameof(Owner)].As<Object>(); } set { this["Owner"] = value; } }
        public World World { get { return this[nameof(World)].As<World>(); } set { this["World"] = value; } }
    }
    public class EnvQueryInstanceCache : Object
    {
        public EnvQueryInstanceCache(nint addr) : base(addr) { }
        public EnvQuery Template { get { return this[nameof(Template)].As<EnvQuery>(); } set { this["Template"] = value; } }
    }
    public class CrowdAvoidanceConfig : Object
    {
        public CrowdAvoidanceConfig(nint addr) : base(addr) { }
        public float VelocityBias { get { return this[nameof(VelocityBias)].GetValue<float>(); } set { this[nameof(VelocityBias)].SetValue<float>(value); } }
        public float DesiredVelocityWeight { get { return this[nameof(DesiredVelocityWeight)].GetValue<float>(); } set { this[nameof(DesiredVelocityWeight)].SetValue<float>(value); } }
        public float CurrentVelocityWeight { get { return this[nameof(CurrentVelocityWeight)].GetValue<float>(); } set { this[nameof(CurrentVelocityWeight)].SetValue<float>(value); } }
        public float SideBiasWeight { get { return this[nameof(SideBiasWeight)].GetValue<float>(); } set { this[nameof(SideBiasWeight)].SetValue<float>(value); } }
        public float ImpactTimeWeight { get { return this[nameof(ImpactTimeWeight)].GetValue<float>(); } set { this[nameof(ImpactTimeWeight)].SetValue<float>(value); } }
        public float ImpactTimeRange { get { return this[nameof(ImpactTimeRange)].GetValue<float>(); } set { this[nameof(ImpactTimeRange)].SetValue<float>(value); } }
        public byte CustomPatternIdx { get { return this[nameof(CustomPatternIdx)].GetValue<byte>(); } set { this[nameof(CustomPatternIdx)].SetValue<byte>(value); } }
        public byte AdaptiveDivisions { get { return this[nameof(AdaptiveDivisions)].GetValue<byte>(); } set { this[nameof(AdaptiveDivisions)].SetValue<byte>(value); } }
        public byte AdaptiveRings { get { return this[nameof(AdaptiveRings)].GetValue<byte>(); } set { this[nameof(AdaptiveRings)].SetValue<byte>(value); } }
        public byte AdaptiveDepth { get { return this[nameof(AdaptiveDepth)].GetValue<byte>(); } set { this[nameof(AdaptiveDepth)].SetValue<byte>(value); } }
    }
    public class CrowdAvoidanceSamplingPattern : Object
    {
        public CrowdAvoidanceSamplingPattern(nint addr) : base(addr) { }
        public Array<float> Angles { get { return new Array<float>(this[nameof(Angles)].Address); } }
        public Array<float> Radii { get { return new Array<float>(this[nameof(Radii)].Address); } }
    }
    public class RecastGraphWrapper : Object
    {
        public RecastGraphWrapper(nint addr) : base(addr) { }
        public RecastNavMesh RecastNavMeshActor { get { return this[nameof(RecastNavMeshActor)].As<RecastNavMesh>(); } set { this["RecastNavMeshActor"] = value; } }
    }
    public class ActorPerceptionBlueprintInfo : Object
    {
        public ActorPerceptionBlueprintInfo(nint addr) : base(addr) { }
        public Actor Target { get { return this[nameof(Target)].As<Actor>(); } set { this["Target"] = value; } }
        public Array<AIStimulus> LastSensedStimuli { get { return new Array<AIStimulus>(this[nameof(LastSensedStimuli)].Address); } }
        public bool bIsHostile { get { return this[nameof(bIsHostile)].Flag; } set { this[nameof(bIsHostile)].Flag = value; } }
    }
    public class AISenseAffiliationFilter : Object
    {
        public AISenseAffiliationFilter(nint addr) : base(addr) { }
        public bool bDetectEnemies { get { return this[nameof(bDetectEnemies)].Flag; } set { this[nameof(bDetectEnemies)].Flag = value; } }
        public bool bDetectNeutrals { get { return this[nameof(bDetectNeutrals)].Flag; } set { this[nameof(bDetectNeutrals)].Flag = value; } }
        public bool bDetectFriendlies { get { return this[nameof(bDetectFriendlies)].Flag; } set { this[nameof(bDetectFriendlies)].Flag = value; } }
    }
    public class AIDamageEvent : Object
    {
        public AIDamageEvent(nint addr) : base(addr) { }
        public float Amount { get { return this[nameof(Amount)].GetValue<float>(); } set { this[nameof(Amount)].SetValue<float>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector HitLocation { get { return this[nameof(HitLocation)].As<Vector>(); } set { this["HitLocation"] = value; } }
        public Actor DamagedActor { get { return this[nameof(DamagedActor)].As<Actor>(); } set { this["DamagedActor"] = value; } }
        public Actor Instigator { get { return this[nameof(Instigator)].As<Actor>(); } set { this["Instigator"] = value; } }
        public Object Tag { get { return this[nameof(Tag)]; } set { this[nameof(Tag)] = value; } }
    }
    public class AINoiseEvent : Object
    {
        public AINoiseEvent(nint addr) : base(addr) { }
        public Vector NoiseLocation { get { return this[nameof(NoiseLocation)].As<Vector>(); } set { this["NoiseLocation"] = value; } }
        public float Loudness { get { return this[nameof(Loudness)].GetValue<float>(); } set { this[nameof(Loudness)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public Actor Instigator { get { return this[nameof(Instigator)].As<Actor>(); } set { this["Instigator"] = value; } }
        public Object Tag { get { return this[nameof(Tag)]; } set { this[nameof(Tag)] = value; } }
    }
    public class AIPredictionEvent : Object
    {
        public AIPredictionEvent(nint addr) : base(addr) { }
        public Actor Requestor { get { return this[nameof(Requestor)].As<Actor>(); } set { this["Requestor"] = value; } }
        public Actor PredictedActor { get { return this[nameof(PredictedActor)].As<Actor>(); } set { this["PredictedActor"] = value; } }
    }
    public class AISightEvent : Object
    {
        public AISightEvent(nint addr) : base(addr) { }
        public Actor SeenActor { get { return this[nameof(SeenActor)].As<Actor>(); } set { this["SeenActor"] = value; } }
        public Actor Observer { get { return this[nameof(Observer)].As<Actor>(); } set { this["Observer"] = value; } }
    }
    public class AITeamStimulusEvent : Object
    {
        public AITeamStimulusEvent(nint addr) : base(addr) { }
        public Actor Broadcaster { get { return this[nameof(Broadcaster)].As<Actor>(); } set { this["Broadcaster"] = value; } }
        public Actor Enemy { get { return this[nameof(Enemy)].As<Actor>(); } set { this["Enemy"] = value; } }
    }
    public class AITouchEvent : Object
    {
        public AITouchEvent(nint addr) : base(addr) { }
        public Actor TouchReceiver { get { return this[nameof(TouchReceiver)].As<Actor>(); } set { this["TouchReceiver"] = value; } }
        public Actor OtherActor { get { return this[nameof(OtherActor)].As<Actor>(); } set { this["OtherActor"] = value; } }
    }
}
