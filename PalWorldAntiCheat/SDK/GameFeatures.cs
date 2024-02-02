using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.GameFeaturesSDK
{
    public class GameFeatureStateChangeObserver : Interface
    {
        public GameFeatureStateChangeObserver(nint addr) : base(addr) { }
    }
    public class GameFeatureAction : Object
    {
        public GameFeatureAction(nint addr) : base(addr) { }
    }
    public class GameFeatureAction_AddCheats : GameFeatureAction
    {
        public GameFeatureAction_AddCheats(nint addr) : base(addr) { }
        public Array<Object> CheatManagers { get { return new Array<Object>(this[nameof(CheatManagers)].Address); } }
        public bool bLoadCheatManagersAsync { get { return this[nameof(bLoadCheatManagersAsync)].Flag; } set { this[nameof(bLoadCheatManagersAsync)].Flag = value; } }
        public Array<Object> SpawnedCheatManagers { get { return new Array<Object>(this[nameof(SpawnedCheatManagers)].Address); } }
    }
    public class GameFeatureAction_AddComponents : GameFeatureAction
    {
        public GameFeatureAction_AddComponents(nint addr) : base(addr) { }
        public Array<GameFeatureComponentEntry> ComponentList { get { return new Array<GameFeatureComponentEntry>(this[nameof(ComponentList)].Address); } }
    }
    public class GameFeatureAction_AddWPContent : GameFeatureAction
    {
        public GameFeatureAction_AddWPContent(nint addr) : base(addr) { }
        public ContentBundleDescriptor ContentBundleDescriptor { get { return this[nameof(ContentBundleDescriptor)].As<ContentBundleDescriptor>(); } set { this["ContentBundleDescriptor"] = value; } }
    }
    public class GameFeatureAction_DataRegistry : GameFeatureAction
    {
        public GameFeatureAction_DataRegistry(nint addr) : base(addr) { }
        public Array<Object> RegistriesToAdd { get { return new Array<Object>(this[nameof(RegistriesToAdd)].Address); } }
        public bool bPreloadInEditor { get { return this[nameof(bPreloadInEditor)].Flag; } set { this[nameof(bPreloadInEditor)].Flag = value; } }
    }
    public class GameFeatureAction_DataRegistrySource : GameFeatureAction
    {
        public GameFeatureAction_DataRegistrySource(nint addr) : base(addr) { }
        public Array<DataRegistrySourceToAdd> SourcesToAdd { get { return new Array<DataRegistrySourceToAdd>(this[nameof(SourcesToAdd)].Address); } }
        public bool bPreloadInEditor { get { return this[nameof(bPreloadInEditor)].Flag; } set { this[nameof(bPreloadInEditor)].Flag = value; } }
    }
    public class GameFeatureData : PrimaryDataAsset
    {
        public GameFeatureData(nint addr) : base(addr) { }
        public Array<GameFeatureAction> Actions { get { return new Array<GameFeatureAction>(this[nameof(Actions)].Address); } }
        public Array<PrimaryAssetTypeInfo> PrimaryAssetTypesToScan { get { return new Array<PrimaryAssetTypeInfo>(this[nameof(PrimaryAssetTypesToScan)].Address); } }
    }
    public class GameFeaturePluginStateMachine : Object
    {
        public GameFeaturePluginStateMachine(nint addr) : base(addr) { }
        public GameFeaturePluginStateMachineProperties StateProperties { get { return this[nameof(StateProperties)].As<GameFeaturePluginStateMachineProperties>(); } set { this["StateProperties"] = value; } }
    }
    public class GameFeaturesProjectPolicies : Object
    {
        public GameFeaturesProjectPolicies(nint addr) : base(addr) { }
    }
    public class DefaultGameFeaturesProjectPolicies : GameFeaturesProjectPolicies
    {
        public DefaultGameFeaturesProjectPolicies(nint addr) : base(addr) { }
    }
    public class GameFeaturesSubsystem : EngineSubsystem
    {
        public GameFeaturesSubsystem(nint addr) : base(addr) { }
        public Object GameFeaturePluginStateMachines { get { return this[nameof(GameFeaturePluginStateMachines)]; } set { this[nameof(GameFeaturePluginStateMachines)] = value; } }
        public Array<GameFeaturePluginStateMachine> TerminalGameFeaturePluginStateMachines { get { return new Array<GameFeaturePluginStateMachine>(this[nameof(TerminalGameFeaturePluginStateMachines)].Address); } }
        public Array<Object> Observers { get { return new Array<Object>(this[nameof(Observers)].Address); } }
        public GameFeaturesProjectPolicies GameSpecificPolicies { get { return this[nameof(GameSpecificPolicies)].As<GameFeaturesProjectPolicies>(); } set { this["GameSpecificPolicies"] = value; } }
    }
    public class GameFeaturesSubsystemSettings : DeveloperSettings
    {
        public GameFeaturesSubsystemSettings(nint addr) : base(addr) { }
        public SoftClassPath GameFeaturesManagerClassName { get { return this[nameof(GameFeaturesManagerClassName)].As<SoftClassPath>(); } set { this["GameFeaturesManagerClassName"] = value; } }
        public Array<Object> DisabledPlugins { get { return new Array<Object>(this[nameof(DisabledPlugins)].Address); } }
        public Array<Object> AdditionalPluginMetadataKeys { get { return new Array<Object>(this[nameof(AdditionalPluginMetadataKeys)].Address); } }
    }
    public enum EGameFeatureTargetState : int
    {
        Installed = 0,
        Registered = 1,
        Loaded = 2,
        Active = 3,
        Count = 4,
        EGameFeatureTargetState_MAX = 5,
    }
    public class GameFeatureComponentEntry : Object
    {
        public GameFeatureComponentEntry(nint addr) : base(addr) { }
        public Object actorClass { get { return this[nameof(actorClass)]; } set { this[nameof(actorClass)] = value; } }
        public Object ComponentClass { get { return this[nameof(ComponentClass)]; } set { this[nameof(ComponentClass)] = value; } }
        public bool bClientComponent { get { return this[nameof(bClientComponent)].Flag; } set { this[nameof(bClientComponent)].Flag = value; } }
        public bool bServerComponent { get { return this[nameof(bServerComponent)].Flag; } set { this[nameof(bServerComponent)].Flag = value; } }
    }
    public class DataRegistrySourceToAdd : Object
    {
        public DataRegistrySourceToAdd(nint addr) : base(addr) { }
        public Object RegistryToAddTo { get { return this[nameof(RegistryToAddTo)]; } set { this[nameof(RegistryToAddTo)] = value; } }
        public int AssetPriority { get { return this[nameof(AssetPriority)].GetValue<int>(); } set { this[nameof(AssetPriority)].SetValue<int>(value); } }
        public bool bClientSource { get { return this[nameof(bClientSource)].Flag; } set { this[nameof(bClientSource)].Flag = value; } }
        public bool bServerSource { get { return this[nameof(bServerSource)].Flag; } set { this[nameof(bServerSource)].Flag = value; } }
        public Object DataTableToAdd { get { return this[nameof(DataTableToAdd)]; } set { this[nameof(DataTableToAdd)] = value; } }
        public Object CurveTableToAdd { get { return this[nameof(CurveTableToAdd)]; } set { this[nameof(CurveTableToAdd)] = value; } }
    }
    public class GameFeaturePluginStateMachineProperties : Object
    {
        public GameFeaturePluginStateMachineProperties(nint addr) : base(addr) { }
        public GameFeatureData GameFeatureData { get { return this[nameof(GameFeatureData)].As<GameFeatureData>(); } set { this["GameFeatureData"] = value; } }
    }
    public class GameFeaturePluginIdentifier : Object
    {
        public GameFeaturePluginIdentifier(nint addr) : base(addr) { }
    }
    public class InstallBundlePluginProtocolMetaData : Object
    {
        public InstallBundlePluginProtocolMetaData(nint addr) : base(addr) { }
    }
}
