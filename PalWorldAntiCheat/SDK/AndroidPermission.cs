using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.AndroidPermissionSDK
{
    public class AndroidPermissionCallbackProxy : Object
    {
        public AndroidPermissionCallbackProxy(nint addr) : base(addr) { }
        public Object OnPermissionsGrantedDynamicDelegate { get { return this[nameof(OnPermissionsGrantedDynamicDelegate)]; } set { this[nameof(OnPermissionsGrantedDynamicDelegate)] = value; } }
    }
    public class AndroidPermissionFunctionLibrary : BlueprintFunctionLibrary
    {
        public AndroidPermissionFunctionLibrary(nint addr) : base(addr) { }
        public bool CheckPermission(Object Permission) { return Invoke<bool>(nameof(CheckPermission), Permission); }
        public AndroidPermissionCallbackProxy AcquirePermissions(Array<Object> Permissions) { return Invoke<AndroidPermissionCallbackProxy>(nameof(AcquirePermissions), Permissions); }
    }
}
