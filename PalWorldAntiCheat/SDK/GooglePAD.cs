using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.GooglePADSDK
{
    public class GooglePADFunctionLibrary : BlueprintFunctionLibrary
    {
        public GooglePADFunctionLibrary(nint addr) : base(addr) { }
        public EGooglePADErrorCode ShowCellularDataConfirmation() { return Invoke<EGooglePADErrorCode>(nameof(ShowCellularDataConfirmation)); }
        public EGooglePADErrorCode RequestRemoval(Object Name) { return Invoke<EGooglePADErrorCode>(nameof(RequestRemoval), Name); }
        public EGooglePADErrorCode RequestInfo(Array<Object> AssetPacks) { return Invoke<EGooglePADErrorCode>(nameof(RequestInfo), AssetPacks); }
        public EGooglePADErrorCode RequestDownload(Array<Object> AssetPacks) { return Invoke<EGooglePADErrorCode>(nameof(RequestDownload), AssetPacks); }
        public void ReleaseDownloadState(int State) { Invoke(nameof(ReleaseDownloadState), State); }
        public void ReleaseAssetPackLocation(int Location) { Invoke(nameof(ReleaseAssetPackLocation), Location); }
        public int GetTotalBytesToDownload(int State) { return Invoke<int>(nameof(GetTotalBytesToDownload), State); }
        public EGooglePADStorageMethod GetStorageMethod(int Location) { return Invoke<EGooglePADStorageMethod>(nameof(GetStorageMethod), Location); }
        public EGooglePADErrorCode GetShowCellularDataConfirmationStatus(EGooglePADCellularDataConfirmStatus Status) { return Invoke<EGooglePADErrorCode>(nameof(GetShowCellularDataConfirmationStatus), Status); }
        public EGooglePADDownloadStatus GetDownloadStatus(int State) { return Invoke<EGooglePADDownloadStatus>(nameof(GetDownloadStatus), State); }
        public EGooglePADErrorCode GetDownloadState(Object Name, int State) { return Invoke<EGooglePADErrorCode>(nameof(GetDownloadState), Name, State); }
        public int GetBytesDownloaded(int State) { return Invoke<int>(nameof(GetBytesDownloaded), State); }
        public Object GetAssetsPath(int Location) { return Invoke<Object>(nameof(GetAssetsPath), Location); }
        public EGooglePADErrorCode GetAssetPackLocation(Object Name, int Location) { return Invoke<EGooglePADErrorCode>(nameof(GetAssetPackLocation), Name, Location); }
        public EGooglePADErrorCode CancelDownload(Array<Object> AssetPacks) { return Invoke<EGooglePADErrorCode>(nameof(CancelDownload), AssetPacks); }
    }
    public enum EGooglePADErrorCode : int
    {
        AssetPack_NO_ERROR = 0,
        AssetPack_APP_UNAVAILABLE = 1,
        AssetPack_UNAVAILABLE = 2,
        AssetPack_INVALID_REQUEST = 3,
        AssetPack_DOWNLOAD_NOT_FOUND = 4,
        AssetPack_API_NOT_AVAILABLE = 5,
        AssetPack_NETWORK_ERROR = 6,
        AssetPack_ACCESS_DENIED = 7,
        AssetPack_INSUFFICIENT_STORAGE = 8,
        AssetPack_PLAY_STORE_NOT_FOUND = 9,
        AssetPack_NETWORK_UNRESTRICTED = 10,
        AssetPack_INTERNAL_ERROR = 11,
        AssetPack_INITIALIZATION_NEEDED = 12,
        AssetPack_INITIALIZATION_FAILED = 13,
        AssetPack_MAX = 14,
    }
    public enum EGooglePADDownloadStatus : int
    {
        AssetPack_UNKNOWN = 0,
        AssetPack_DOWNLOAD_PENDING = 1,
        AssetPack_DOWNLOADING = 2,
        AssetPack_TRANSFERRING = 3,
        AssetPack_DOWNLOAD_COMPLETED = 4,
        AssetPack_DOWNLOAD_FAILED = 5,
        AssetPack_DOWNLOAD_CANCELED = 6,
        AssetPack_WAITING_FOR_WIFI = 7,
        AssetPack_NOT_INSTALLED = 8,
        AssetPack_INFO_PENDING = 9,
        AssetPack_INFO_FAILED = 10,
        AssetPack_REMOVAL_PENDING = 11,
        AssetPack_REMOVAL_FAILED = 12,
        AssetPack_MAX = 13,
    }
    public enum EGooglePADStorageMethod : int
    {
        AssetPack_STORAGE_FILES = 0,
        AssetPack_STORAGE_APK = 1,
        AssetPack_STORAGE_UNKNOWN = 2,
        AssetPack_STORAGE_NOT_INSTALLED = 3,
        AssetPack_STORAGE_MAX = 4,
    }
    public enum EGooglePADCellularDataConfirmStatus : int
    {
        AssetPack_CONFIRM_UNKNOWN = 0,
        AssetPack_CONFIRM_PENDING = 1,
        AssetPack_CONFIRM_USER_APPROVED = 2,
        AssetPack_CONFIRM_USER_CANCELED = 3,
        AssetPack_CONFIRM_MAX = 4,
    }
}
