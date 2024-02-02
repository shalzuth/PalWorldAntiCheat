using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SignificanceManagerSDK
{
    public class SignificanceManager : Object
    {
        public SignificanceManager(nint addr) : base(addr) { }
        public SoftClassPath SignificanceManagerClassName { get { return this[nameof(SignificanceManagerClassName)].As<SoftClassPath>(); } set { this["SignificanceManagerClassName"] = value; } }
    }
}
