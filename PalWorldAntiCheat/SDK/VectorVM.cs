using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.VectorVMSDK
{
    public enum EVectorVMBaseTypes : int
    {
        Float = 0,
        Int = 1,
        Bool = 2,
        Num = 3,
        EVectorVMBaseTypes_MAX = 4,
    }
    public enum EVectorVMOperandLocation : int
    {
        Register = 0,
        Constant = 1,
        Num = 2,
        EVectorVMOperandLocation_MAX = 3,
    }
}
