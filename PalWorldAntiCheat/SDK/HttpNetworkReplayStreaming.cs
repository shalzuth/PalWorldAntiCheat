using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.HttpNetworkReplayStreamingSDK
{
    public enum EHttpReplayResult : int
    {
        Success = 0,
        FailedJsonParse = 1,
        DataUnavailable = 2,
        InvalidHttpResponse = 3,
        CompressionFailed = 4,
        DecompressionFailed = 5,
        InvalidPayload = 6,
        Unknown = 7,
        EHttpReplayResult_MAX = 8,
    }
}
