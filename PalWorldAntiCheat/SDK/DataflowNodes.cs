using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DataflowCoreSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.DataflowNodesSDK
{
    public class GetSkeletalMeshDataflowNode : DataflowNode
    {
        public GetSkeletalMeshDataflowNode(nint addr) : base(addr) { }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
    public class SkeletalMeshBoneDataflowNode : DataflowNode
    {
        public SkeletalMeshBoneDataflowNode(nint addr) : base(addr) { }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public int BoneIndexOut { get { return this[nameof(BoneIndexOut)].GetValue<int>(); } set { this[nameof(BoneIndexOut)].SetValue<int>(value); } }
    }
    public class GetStaticMeshDataflowNode : DataflowNode
    {
        public GetStaticMeshDataflowNode(nint addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
}
