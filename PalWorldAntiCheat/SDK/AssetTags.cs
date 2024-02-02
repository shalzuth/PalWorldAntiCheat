using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AssetTagsSDK
{
    public class AssetTagsSubsystem : EngineSubsystem
    {
        public AssetTagsSubsystem(nint addr) : base(addr) { }
        public Array<Object> K2_GetCollectionsContainingAsset(SoftObjectPath AssetPath) { return Invoke<Array<Object>>(nameof(K2_GetCollectionsContainingAsset), AssetPath); }
        public Array<Object> GetCollectionsContainingAssetPtr(Object AssetPtr) { return Invoke<Array<Object>>(nameof(GetCollectionsContainingAssetPtr), AssetPtr); }
        public Array<Object> GetCollectionsContainingAssetData(AssetData AssetData) { return Invoke<Array<Object>>(nameof(GetCollectionsContainingAssetData), AssetData); }
        public Array<Object> GetCollectionsContainingAsset(Object AssetPathName) { return Invoke<Array<Object>>(nameof(GetCollectionsContainingAsset), AssetPathName); }
        public Array<Object> GetCollections() { return Invoke<Array<Object>>(nameof(GetCollections)); }
        public Array<AssetData> GetAssetsInCollection(Object Name) { return Invoke<Array<AssetData>>(nameof(GetAssetsInCollection), Name); }
        public bool CollectionExists(Object Name) { return Invoke<bool>(nameof(CollectionExists), Name); }
    }
    public enum ECollectionScriptingShareType : int
    {
        Local = 0,
        Private = 1,
        Shared = 2,
        ECollectionScriptingShareType_MAX = 3,
    }
}
