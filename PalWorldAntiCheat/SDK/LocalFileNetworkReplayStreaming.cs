using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.LocalFileNetworkReplayStreamingSDK
{
    public enum ELocalFileReplayResult : int
    {
        Success = 0,
        InvalidReplayInfo = 1,
        StreamChunkIndexMismatch = 2,
        DecompressBuffer = 3,
        CompressionNotSupported = 4,
        DecryptBuffer = 5,
        EncryptionNotSupported = 6,
        Unknown = 7,
        ELocalFileReplayResult_MAX = 8,
    }
}
