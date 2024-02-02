using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.MetasoundFrontendSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MetasoundEngineSDK
{
    public class MetaSoundSettings : DeveloperSettings
    {
        public MetaSoundSettings(nint addr) : base(addr) { }
        public bool bAutoUpdateEnabled { get { return this[nameof(bAutoUpdateEnabled)].Flag; } set { this[nameof(bAutoUpdateEnabled)].Flag = value; } }
        public Array<MetasoundFrontendClassName> AutoUpdateDenylist { get { return new Array<MetasoundFrontendClassName>(this[nameof(AutoUpdateDenylist)].Address); } }
        public Array<DefaultMetaSoundAssetAutoUpdateSettings> AutoUpdateAssetDenylist { get { return new Array<DefaultMetaSoundAssetAutoUpdateSettings>(this[nameof(AutoUpdateAssetDenylist)].Address); } }
        public bool bAutoUpdateLogWarningOnDroppedConnection { get { return this[nameof(bAutoUpdateLogWarningOnDroppedConnection)].Flag; } set { this[nameof(bAutoUpdateLogWarningOnDroppedConnection)].Flag = value; } }
        public Array<DirectoryPath> DirectoriesToRegister { get { return new Array<DirectoryPath>(this[nameof(DirectoriesToRegister)].Address); } }
        public int DenyListCacheChangeID { get { return this[nameof(DenyListCacheChangeID)].GetValue<int>(); } set { this[nameof(DenyListCacheChangeID)].SetValue<int>(value); } }
    }
    public class MetasoundEditorGraphBase : EdGraph
    {
        public MetasoundEditorGraphBase(nint addr) : base(addr) { }
    }
    public class MetaSoundPatch : Object
    {
        public MetaSoundPatch(nint addr) : base(addr) { }
        public MetasoundFrontendDocument RootMetaSoundDocument { get { return this[nameof(RootMetaSoundDocument)].As<MetasoundFrontendDocument>(); } set { this["RootMetaSoundDocument"] = value; } }
        public Object ReferencedAssetClassKeys { get { return this[nameof(ReferencedAssetClassKeys)]; } set { this[nameof(ReferencedAssetClassKeys)] = value; } }
        public Object ReferencedAssetClassObjects { get { return this[nameof(ReferencedAssetClassObjects)]; } set { this[nameof(ReferencedAssetClassObjects)] = value; } }
        public Object ReferenceAssetClassCache { get { return this[nameof(ReferenceAssetClassCache)]; } set { this[nameof(ReferenceAssetClassCache)] = value; } }
        public Guid AssetClassID { get { return this[nameof(AssetClassID)].As<Guid>(); } set { this["AssetClassID"] = value; } }
    }
    public class MetaSoundAssetSubsystem : EngineSubsystem
    {
        public MetaSoundAssetSubsystem(nint addr) : base(addr) { }
        public Array<MetaSoundAsyncAssetDependencies> LoadingDependencies { get { return new Array<MetaSoundAsyncAssetDependencies>(this[nameof(LoadingDependencies)].Address); } }
        public void UnregisterAssetClassesInDirectories(Array<MetaSoundAssetDirectory> Directories) { Invoke(nameof(UnregisterAssetClassesInDirectories), Directories); }
        public void RegisterAssetClassesInDirectories(Array<MetaSoundAssetDirectory> Directories) { Invoke(nameof(RegisterAssetClassesInDirectories), Directories); }
    }
    public class MetaSoundSource : SoundWaveProcedural
    {
        public MetaSoundSource(nint addr) : base(addr) { }
        public MetasoundFrontendDocument RootMetaSoundDocument { get { return this[nameof(RootMetaSoundDocument)].As<MetasoundFrontendDocument>(); } set { this["RootMetaSoundDocument"] = value; } }
        public Object ReferencedAssetClassKeys { get { return this[nameof(ReferencedAssetClassKeys)]; } set { this[nameof(ReferencedAssetClassKeys)] = value; } }
        public Object ReferencedAssetClassObjects { get { return this[nameof(ReferencedAssetClassObjects)]; } set { this[nameof(ReferencedAssetClassObjects)] = value; } }
        public Object ReferenceAssetClassCache { get { return this[nameof(ReferenceAssetClassCache)]; } set { this[nameof(ReferenceAssetClassCache)] = value; } }
        public EMetasoundSourceAudioFormat OutputFormat { get { return (EMetasoundSourceAudioFormat)this[nameof(OutputFormat)].GetValue<int>(); } set { this[nameof(OutputFormat)].SetValue<int>((int)value); } }
        public Guid AssetClassID { get { return this[nameof(AssetClassID)].As<Guid>(); } set { this["AssetClassID"] = value; } }
    }
    public enum EMetaSoundMessageLevel : int
    {
        Error = 0,
        Warning = 1,
        Info = 2,
        EMetaSoundMessageLevel_MAX = 3,
    }
    public enum EMetasoundSourceAudioFormat : int
    {
        Mono = 0,
        Stereo = 1,
        Quad = 2,
        FiveDotOne = 3,
        SevenDotOne = 4,
        COUNT = 5,
        EMetasoundSourceAudioFormat_MAX = 6,
    }
    public class DefaultMetaSoundAssetAutoUpdateSettings : Object
    {
        public DefaultMetaSoundAssetAutoUpdateSettings(nint addr) : base(addr) { }
        public SoftObjectPath Metasound { get { return this[nameof(Metasound)].As<SoftObjectPath>(); } set { this["Metasound"] = value; } }
    }
    public class MetaSoundAssetDirectory : Object
    {
        public MetaSoundAssetDirectory(nint addr) : base(addr) { }
        public DirectoryPath Directory { get { return this[nameof(Directory)].As<DirectoryPath>(); } set { this["Directory"] = value; } }
    }
    public class MetaSoundAsyncAssetDependencies : Object
    {
        public MetaSoundAsyncAssetDependencies(nint addr) : base(addr) { }
        public Object Metasound { get { return this[nameof(Metasound)].As<Object>(); } set { this["Metasound"] = value; } }
    }
}
