using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.GameplayTagsSDK;
namespace SDK.Script.DataRegistrySDK
{
    public class DataRegistrySettings : DeveloperSettings
    {
        public DataRegistrySettings(nint addr) : base(addr) { }
        public Array<DirectoryPath> DirectoriesToScan { get { return new Array<DirectoryPath>(this[nameof(DirectoriesToScan)].Address); } }
        public bool bInitializeAllLoadedRegistries { get { return this[nameof(bInitializeAllLoadedRegistries)].Flag; } set { this[nameof(bInitializeAllLoadedRegistries)].Flag = value; } }
        public bool bIgnoreMissingCookedAssetRegistryData { get { return this[nameof(bIgnoreMissingCookedAssetRegistryData)].Flag; } set { this[nameof(bIgnoreMissingCookedAssetRegistryData)].Flag = value; } }
    }
    public class DataRegistry : Object
    {
        public DataRegistry(nint addr) : base(addr) { }
        public Object RegistryType { get { return this[nameof(RegistryType)]; } set { this[nameof(RegistryType)] = value; } }
        public DataRegistryIdFormat IdFormat { get { return this[nameof(IdFormat)].As<DataRegistryIdFormat>(); } set { this["IdFormat"] = value; } }
        public ScriptStruct ItemStruct { get { return this[nameof(ItemStruct)].As<ScriptStruct>(); } set { this["ItemStruct"] = value; } }
        public Array<DataRegistrySource> DataSources { get { return new Array<DataRegistrySource>(this[nameof(DataSources)].Address); } }
        public Array<DataRegistrySource> RuntimeSources { get { return new Array<DataRegistrySource>(this[nameof(RuntimeSources)].Address); } }
        public float TimerUpdateFrequency { get { return this[nameof(TimerUpdateFrequency)].GetValue<float>(); } set { this[nameof(TimerUpdateFrequency)].SetValue<float>(value); } }
        public DataRegistryCachePolicy DefaultCachePolicy { get { return this[nameof(DefaultCachePolicy)].As<DataRegistryCachePolicy>(); } set { this["DefaultCachePolicy"] = value; } }
    }
    public class DataRegistrySource : Object
    {
        public DataRegistrySource(nint addr) : base(addr) { }
        public DataRegistrySource ParentSource { get { return this[nameof(ParentSource)].As<DataRegistrySource>(); } set { this["ParentSource"] = value; } }
    }
    public class MetaDataRegistrySource : DataRegistrySource
    {
        public MetaDataRegistrySource(nint addr) : base(addr) { }
        public EMetaDataRegistrySourceAssetUsage AssetUsage { get { return (EMetaDataRegistrySourceAssetUsage)this[nameof(AssetUsage)].GetValue<int>(); } set { this[nameof(AssetUsage)].SetValue<int>((int)value); } }
        public AssetManagerSearchRules SearchRules { get { return this[nameof(SearchRules)].As<AssetManagerSearchRules>(); } set { this["SearchRules"] = value; } }
        public Object RuntimeChildren { get { return this[nameof(RuntimeChildren)]; } set { this[nameof(RuntimeChildren)] = value; } }
    }
    public class DataRegistrySource_CurveTable : DataRegistrySource
    {
        public DataRegistrySource_CurveTable(nint addr) : base(addr) { }
        public Object SourceTable { get { return this[nameof(SourceTable)]; } set { this[nameof(SourceTable)] = value; } }
        public DataRegistrySource_DataTableRules TableRules { get { return this[nameof(TableRules)].As<DataRegistrySource_DataTableRules>(); } set { this["TableRules"] = value; } }
        public CurveTable CachedTable { get { return this[nameof(CachedTable)].As<CurveTable>(); } set { this["CachedTable"] = value; } }
        public CurveTable PreloadTable { get { return this[nameof(PreloadTable)].As<CurveTable>(); } set { this["PreloadTable"] = value; } }
    }
    public class MetaDataRegistrySource_CurveTable : MetaDataRegistrySource
    {
        public MetaDataRegistrySource_CurveTable(nint addr) : base(addr) { }
        public Object CreatedSource { get { return this[nameof(CreatedSource)]; } set { this[nameof(CreatedSource)] = value; } }
        public DataRegistrySource_DataTableRules TableRules { get { return this[nameof(TableRules)].As<DataRegistrySource_DataTableRules>(); } set { this["TableRules"] = value; } }
    }
    public class DataRegistrySource_DataTable : DataRegistrySource
    {
        public DataRegistrySource_DataTable(nint addr) : base(addr) { }
        public Object SourceTable { get { return this[nameof(SourceTable)]; } set { this[nameof(SourceTable)] = value; } }
        public DataRegistrySource_DataTableRules TableRules { get { return this[nameof(TableRules)].As<DataRegistrySource_DataTableRules>(); } set { this["TableRules"] = value; } }
        public DataTable CachedTable { get { return this[nameof(CachedTable)].As<DataTable>(); } set { this["CachedTable"] = value; } }
        public DataTable PreloadTable { get { return this[nameof(PreloadTable)].As<DataTable>(); } set { this["PreloadTable"] = value; } }
    }
    public class MetaDataRegistrySource_DataTable : MetaDataRegistrySource
    {
        public MetaDataRegistrySource_DataTable(nint addr) : base(addr) { }
        public Object CreatedSource { get { return this[nameof(CreatedSource)]; } set { this[nameof(CreatedSource)] = value; } }
        public DataRegistrySource_DataTableRules TableRules { get { return this[nameof(TableRules)].As<DataRegistrySource_DataTableRules>(); } set { this["TableRules"] = value; } }
    }
    public class DataRegistrySubsystem : EngineSubsystem
    {
        public DataRegistrySubsystem(nint addr) : base(addr) { }
        public bool NotEqual_DataRegistryType(DataRegistryType A, DataRegistryType B) { return Invoke<bool>(nameof(NotEqual_DataRegistryType), A, B); }
        public bool NotEqual_DataRegistryId(DataRegistryId A, DataRegistryId B) { return Invoke<bool>(nameof(NotEqual_DataRegistryId), A, B); }
        public bool IsValidDataRegistryType(DataRegistryType DataRegistryType) { return Invoke<bool>(nameof(IsValidDataRegistryType), DataRegistryType); }
        public bool IsValidDataRegistryId(DataRegistryId DataRegistryId) { return Invoke<bool>(nameof(IsValidDataRegistryId), DataRegistryId); }
        public bool GetCachedItemFromLookupBP(DataRegistryId ItemId, DataRegistryLookup ResolvedLookup, TableRowBase OutItem) { return Invoke<bool>(nameof(GetCachedItemFromLookupBP), ItemId, ResolvedLookup, OutItem); }
        public bool GetCachedItemBP(DataRegistryId ItemId, TableRowBase OutItem) { return Invoke<bool>(nameof(GetCachedItemBP), ItemId, OutItem); }
        public void FindCachedItemBP(DataRegistryId ItemId, EDataRegistrySubsystemGetItemResult OutResult, TableRowBase OutItem) { Invoke(nameof(FindCachedItemBP), ItemId, OutResult, OutItem); }
        public void EvaluateDataRegistryCurve(DataRegistryId ItemId, float InputValue, float DefaultValue, EDataRegistrySubsystemGetItemResult OutResult, float OutValue) { Invoke(nameof(EvaluateDataRegistryCurve), ItemId, InputValue, DefaultValue, OutResult, OutValue); }
        public bool EqualEqual_DataRegistryType(DataRegistryType A, DataRegistryType B) { return Invoke<bool>(nameof(EqualEqual_DataRegistryType), A, B); }
        public bool EqualEqual_DataRegistryId(DataRegistryId A, DataRegistryId B) { return Invoke<bool>(nameof(EqualEqual_DataRegistryId), A, B); }
        public Object Conv_DataRegistryTypeToString(DataRegistryType DataRegistryType) { return Invoke<Object>(nameof(Conv_DataRegistryTypeToString), DataRegistryType); }
        public Object Conv_DataRegistryIdToString(DataRegistryId DataRegistryId) { return Invoke<Object>(nameof(Conv_DataRegistryIdToString), DataRegistryId); }
        public bool AcquireItemBP(DataRegistryId ItemId, Object AcquireCallback) { return Invoke<bool>(nameof(AcquireItemBP), ItemId, AcquireCallback); }
    }
    public enum EDataRegistryAcquireStatus : int
    {
        NotStarted = 0,
        WaitingForInitialAcquire = 1,
        InitialAcquireFinished = 2,
        WaitingForResources = 3,
        AcquireFinished = 4,
        AcquireError = 5,
        DoesNotExist = 6,
        EDataRegistryAcquireStatus_MAX = 7,
    }
    public class DataRegistryLookup : Object
    {
        public DataRegistryLookup(nint addr) : base(addr) { }
    }
    public class DataRegistryId : Object
    {
        public DataRegistryId(nint addr) : base(addr) { }
        public DataRegistryType RegistryType { get { return this[nameof(RegistryType)].As<DataRegistryType>(); } set { this["RegistryType"] = value; } }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
    }
    public class DataRegistryType : Object
    {
        public DataRegistryType(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public enum EMetaDataRegistrySourceAssetUsage : int
    {
        NoAssets = 0,
        SearchAssets = 1,
        RegisterAssets = 2,
        SearchAndRegisterAssets = 3,
        EMetaDataRegistrySourceAssetUsage_MAX = 4,
    }
    public enum EDataRegistrySubsystemGetItemResult : int
    {
        Found = 0,
        NotFound = 1,
        EDataRegistrySubsystemGetItemResult_MAX = 2,
    }
    public enum EDataRegistryAvailability : int
    {
        DoesNotExist = 0,
        Unknown = 1,
        Remote = 2,
        OnDisk = 3,
        LocalAsset = 4,
        PreCached = 5,
        EDataRegistryAvailability_MAX = 6,
    }
    public class DataRegistrySource_DataTableRules : Object
    {
        public DataRegistrySource_DataTableRules(nint addr) : base(addr) { }
        public bool bPrecacheTable { get { return this[nameof(bPrecacheTable)].Flag; } set { this[nameof(bPrecacheTable)].Flag = value; } }
        public float CachedTableKeepSeconds { get { return this[nameof(CachedTableKeepSeconds)].GetValue<float>(); } set { this[nameof(CachedTableKeepSeconds)].SetValue<float>(value); } }
    }
    public class DataRegistryIdFormat : Object
    {
        public DataRegistryIdFormat(nint addr) : base(addr) { }
        public GameplayTag BaseGameplayTag { get { return this[nameof(BaseGameplayTag)].As<GameplayTag>(); } set { this["BaseGameplayTag"] = value; } }
    }
    public class DataRegistryCachePolicy : Object
    {
        public DataRegistryCachePolicy(nint addr) : base(addr) { }
        public bool bCacheIsAlwaysVolatile { get { return this[nameof(bCacheIsAlwaysVolatile)].Flag; } set { this[nameof(bCacheIsAlwaysVolatile)].Flag = value; } }
        public bool bUseCurveTableCacheVersion { get { return this[nameof(bUseCurveTableCacheVersion)].Flag; } set { this[nameof(bUseCurveTableCacheVersion)].Flag = value; } }
        public int MinNumberKept { get { return this[nameof(MinNumberKept)].GetValue<int>(); } set { this[nameof(MinNumberKept)].SetValue<int>(value); } }
        public int MaxNumberKept { get { return this[nameof(MaxNumberKept)].GetValue<int>(); } set { this[nameof(MaxNumberKept)].SetValue<int>(value); } }
        public float ForceKeepSeconds { get { return this[nameof(ForceKeepSeconds)].GetValue<float>(); } set { this[nameof(ForceKeepSeconds)].SetValue<float>(value); } }
        public float ForceReleaseSeconds { get { return this[nameof(ForceReleaseSeconds)].GetValue<float>(); } set { this[nameof(ForceReleaseSeconds)].SetValue<float>(value); } }
    }
    public class DataRegistrySourceItemId : Object
    {
        public DataRegistrySourceItemId(nint addr) : base(addr) { }
    }
}
