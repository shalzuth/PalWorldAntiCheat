using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.DataflowEngineSDK
{
    public class DataflowEdNode : EdGraphNode
    {
        public DataflowEdNode(nint addr) : base(addr) { }
    }
    public class Dataflow : EdGraph
    {
        public Dataflow(nint addr) : base(addr) { }
        public bool bActive { get { return this[nameof(bActive)].Flag; } set { this[nameof(bActive)].Flag = value; } }
        public Array<Object> Targets { get { return new Array<Object>(this[nameof(Targets)].Address); } }
    }
}
