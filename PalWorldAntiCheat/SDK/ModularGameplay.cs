using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.GameplayTagsSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ModularGameplaySDK
{
    public class GameFrameworkComponent : ActorComponent
    {
        public GameFrameworkComponent(nint addr) : base(addr) { }
    }
    public class ControllerComponent : GameFrameworkComponent
    {
        public ControllerComponent(nint addr) : base(addr) { }
    }
    public class GameFrameworkComponentManager : GameInstanceSubsystem
    {
        public GameFrameworkComponentManager(nint addr) : base(addr) { }
        public bool UnregisterClassInitStateDelegate(Object actorClass, Object DelegateToRemove) { return Invoke<bool>(nameof(UnregisterClassInitStateDelegate), actorClass, DelegateToRemove); }
        public bool UnregisterActorInitStateDelegate(Actor Actor, Object DelegateToRemove) { return Invoke<bool>(nameof(UnregisterActorInitStateDelegate), Actor, DelegateToRemove); }
        public void SendExtensionEvent(Actor Receiver, Object EventName, bool bOnlyInGameWorlds) { Invoke(nameof(SendExtensionEvent), Receiver, EventName, bOnlyInGameWorlds); }
        public void RemoveReceiver(Actor Receiver) { Invoke(nameof(RemoveReceiver), Receiver); }
        public bool RegisterAndCallForClassInitState(Object actorClass, Object FeatureName, GameplayTag RequiredState, Object Delegate, bool bCallImmediately) { return Invoke<bool>(nameof(RegisterAndCallForClassInitState), actorClass, FeatureName, RequiredState, Delegate, bCallImmediately); }
        public bool RegisterAndCallForActorInitState(Actor Actor, Object FeatureName, GameplayTag RequiredState, Object Delegate, bool bCallImmediately) { return Invoke<bool>(nameof(RegisterAndCallForActorInitState), Actor, FeatureName, RequiredState, Delegate, bCallImmediately); }
        public void AddReceiver(Actor Receiver, bool bAddOnlyInGameWorlds) { Invoke(nameof(AddReceiver), Receiver, bAddOnlyInGameWorlds); }
    }
    public class GameFrameworkInitStateInterface : Interface
    {
        public GameFrameworkInitStateInterface(nint addr) : base(addr) { }
        public bool UnregisterInitStateDelegate(Object Delegate) { return Invoke<bool>(nameof(UnregisterInitStateDelegate), Delegate); }
        public bool RegisterAndCallForInitStateChange(GameplayTag RequiredState, Object Delegate, bool bCallImmediately) { return Invoke<bool>(nameof(RegisterAndCallForInitStateChange), RequiredState, Delegate, bCallImmediately); }
        public bool HasReachedInitState(GameplayTag DesiredState) { return Invoke<bool>(nameof(HasReachedInitState), DesiredState); }
        public GameplayTag GetInitState() { return Invoke<GameplayTag>(nameof(GetInitState)); }
        public Object GetFeatureName() { return Invoke<Object>(nameof(GetFeatureName)); }
    }
    public class GameStateComponent : GameFrameworkComponent
    {
        public GameStateComponent(nint addr) : base(addr) { }
    }
    public class PawnComponent : GameFrameworkComponent
    {
        public PawnComponent(nint addr) : base(addr) { }
    }
    public class PlayerStateComponent : GameFrameworkComponent
    {
        public PlayerStateComponent(nint addr) : base(addr) { }
    }
    public class ActorInitStateChangedParams : Object
    {
        public ActorInitStateChangedParams(nint addr) : base(addr) { }
        public Actor OwningActor { get { return this[nameof(OwningActor)].As<Actor>(); } set { this["OwningActor"] = value; } }
        public Object FeatureName { get { return this[nameof(FeatureName)]; } set { this[nameof(FeatureName)] = value; } }
        public Object Implementer { get { return this[nameof(Implementer)].As<Object>(); } set { this["Implementer"] = value; } }
        public GameplayTag FeatureState { get { return this[nameof(FeatureState)].As<GameplayTag>(); } set { this["FeatureState"] = value; } }
    }
}
