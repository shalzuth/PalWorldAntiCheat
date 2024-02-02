using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.DataflowCoreSDK
{
    public class DataflowNode : Object
    {
        public DataflowNode(nint addr) : base(addr) { }
        public bool bActive { get { return this[nameof(bActive)].Flag; } set { this[nameof(bActive)].Flag = value; } }
    }
    public class DataflowConnection : Object
    {
        public DataflowConnection(nint addr) : base(addr) { }
    }
    public class DataflowInput : DataflowConnection
    {
        public DataflowInput(nint addr) : base(addr) { }
    }
    public class DataflowOutput : DataflowConnection
    {
        public DataflowOutput(nint addr) : base(addr) { }
    }
}
