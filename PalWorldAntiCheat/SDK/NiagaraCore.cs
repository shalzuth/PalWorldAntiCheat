using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.NiagaraCoreSDK
{
    public class NiagaraMergeable : Object
    {
        public NiagaraMergeable(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceBase : NiagaraMergeable
    {
        public NiagaraDataInterfaceBase(nint addr) : base(addr) { }
    }
    public class NiagaraCompileHash : Object
    {
        public NiagaraCompileHash(nint addr) : base(addr) { }
        public Array<byte> DataHash { get { return new Array<byte>(this[nameof(DataHash)].Address); } }
    }
}
