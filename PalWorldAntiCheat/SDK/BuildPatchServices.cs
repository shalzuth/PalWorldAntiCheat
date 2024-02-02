using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.BuildPatchServicesSDK
{
    public class BuildPatchManifest : Object
    {
        public BuildPatchManifest(nint addr) : base(addr) { }
        public byte ManifestFileVersion { get { return this[nameof(ManifestFileVersion)].GetValue<byte>(); } set { this[nameof(ManifestFileVersion)].SetValue<byte>(value); } }
        public bool bIsFileData { get { return this[nameof(bIsFileData)].Flag; } set { this[nameof(bIsFileData)].Flag = value; } }
        public uint AppID { get { return this[nameof(AppID)].GetValue<uint>(); } set { this[nameof(AppID)].SetValue<uint>(value); } }
        public Object AppName { get { return this[nameof(AppName)]; } set { this[nameof(AppName)] = value; } }
        public Object BuildVersion { get { return this[nameof(BuildVersion)]; } set { this[nameof(BuildVersion)] = value; } }
        public Object LaunchExe { get { return this[nameof(LaunchExe)]; } set { this[nameof(LaunchExe)] = value; } }
        public Object LaunchCommand { get { return this[nameof(LaunchCommand)]; } set { this[nameof(LaunchCommand)] = value; } }
        public Object PrereqIds { get { return this[nameof(PrereqIds)]; } set { this[nameof(PrereqIds)] = value; } }
        public Object PrereqName { get { return this[nameof(PrereqName)]; } set { this[nameof(PrereqName)] = value; } }
        public Object PrereqPath { get { return this[nameof(PrereqPath)]; } set { this[nameof(PrereqPath)] = value; } }
        public Object PrereqArgs { get { return this[nameof(PrereqArgs)]; } set { this[nameof(PrereqArgs)] = value; } }
        public Array<FileManifestData> FileManifestList { get { return new Array<FileManifestData>(this[nameof(FileManifestList)].Address); } }
        public Array<ChunkInfoData> ChunkList { get { return new Array<ChunkInfoData>(this[nameof(ChunkList)].Address); } }
        public Array<CustomFieldData> CustomFields { get { return new Array<CustomFieldData>(this[nameof(CustomFields)].Address); } }
    }
    public class CustomFieldData : Object
    {
        public CustomFieldData(nint addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class SHAHashData : Object
    {
        public SHAHashData(nint addr) : base(addr) { }
        public byte Hash { get { return this[nameof(Hash)].GetValue<byte>(); } set { this[nameof(Hash)].SetValue<byte>(value); } }
    }
    public class ChunkInfoData : Object
    {
        public ChunkInfoData(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public ulong Hash { get { return this[nameof(Hash)].GetValue<ulong>(); } set { this[nameof(Hash)].SetValue<ulong>(value); } }
        public SHAHashData ShaHash { get { return this[nameof(ShaHash)].As<SHAHashData>(); } set { this["ShaHash"] = value; } }
        public long FileSize { get { return this[nameof(FileSize)].GetValue<long>(); } set { this[nameof(FileSize)].SetValue<long>(value); } }
        public byte GroupNumber { get { return this[nameof(GroupNumber)].GetValue<byte>(); } set { this[nameof(GroupNumber)].SetValue<byte>(value); } }
    }
    public class ChunkPartData : Object
    {
        public ChunkPartData(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public uint Offset { get { return this[nameof(Offset)].GetValue<uint>(); } set { this[nameof(Offset)].SetValue<uint>(value); } }
        public uint Size { get { return this[nameof(Size)].GetValue<uint>(); } set { this[nameof(Size)].SetValue<uint>(value); } }
    }
    public class FileManifestData : Object
    {
        public FileManifestData(nint addr) : base(addr) { }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public SHAHashData FileHash { get { return this[nameof(FileHash)].As<SHAHashData>(); } set { this["FileHash"] = value; } }
        public Array<ChunkPartData> FileChunkParts { get { return new Array<ChunkPartData>(this[nameof(FileChunkParts)].Address); } }
        public Array<Object> InstallTags { get { return new Array<Object>(this[nameof(InstallTags)].Address); } }
        public bool bIsUnixExecutable { get { return this[nameof(bIsUnixExecutable)].Flag; } set { this[nameof(bIsUnixExecutable)].Flag = value; } }
        public Object SymlinkTarget { get { return this[nameof(SymlinkTarget)]; } set { this[nameof(SymlinkTarget)] = value; } }
        public bool bIsReadOnly { get { return this[nameof(bIsReadOnly)].Flag; } set { this[nameof(bIsReadOnly)].Flag = value; } }
        public bool bIsCompressed { get { return this[nameof(bIsCompressed)].Flag; } set { this[nameof(bIsCompressed)].Flag = value; } }
    }
}
