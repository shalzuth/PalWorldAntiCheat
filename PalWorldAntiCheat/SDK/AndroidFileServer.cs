using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.AndroidFileServerSDK
{
    public class AndroidFileServerBPLibrary : BlueprintFunctionLibrary
    {
        public AndroidFileServerBPLibrary(nint addr) : base(addr) { }
        public bool StopFileServer(bool bUSB, bool bNetwork) { return Invoke<bool>(nameof(StopFileServer), bUSB, bNetwork); }
        public bool StartFileServer(bool bUSB, bool bNetwork, int Port) { return Invoke<bool>(nameof(StartFileServer), bUSB, bNetwork, Port); }
        public byte IsFileServerRunning() { return Invoke<byte>(nameof(IsFileServerRunning)); }
    }
    public enum EAFSActiveType : int
    {
        None = 0,
        USBOnly = 1,
        NetworkOnly = 2,
        Combined = 3,
        EAFSActiveType_MAX = 4,
    }
}
