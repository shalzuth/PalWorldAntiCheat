using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AnimationCoreSDK
{
    public class AnimationDataSourceRegistry : Object
    {
        public AnimationDataSourceRegistry(nint addr) : base(addr) { }
        public Object DataSources { get { return this[nameof(DataSources)]; } set { this[nameof(DataSources)] = value; } }
    }
    public enum EEulerRotationOrder : int
    {
        XYZ = 0,
        XZY = 1,
        YXZ = 2,
        YZX = 3,
        ZXY = 4,
        ZYX = 5,
        EEulerRotationOrder_MAX = 6,
    }
    public enum EConstraintType : int
    {
        Transform = 0,
        Aim = 1,
        MAX = 2,
    }
    public enum ETransformConstraintType : int
    {
        Translation = 0,
        Rotation = 1,
        Scale = 2,
        Parent = 3,
        LookAt = 4,
        ETransformConstraintType_MAX = 5,
    }
    public class TransformConstraint : Object
    {
        public TransformConstraint(nint addr) : base(addr) { }
        public ConstraintDescription Operator { get { return this[nameof(Operator)].As<ConstraintDescription>(); } set { this["Operator"] = value; } }
        public Object SourceNode { get { return this[nameof(SourceNode)]; } set { this[nameof(SourceNode)] = value; } }
        public Object TargetNode { get { return this[nameof(TargetNode)]; } set { this[nameof(TargetNode)] = value; } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool bMaintainOffset { get { return this[nameof(bMaintainOffset)].Flag; } set { this[nameof(bMaintainOffset)].Flag = value; } }
    }
    public class ConstraintDescription : Object
    {
        public ConstraintDescription(nint addr) : base(addr) { }
        public bool bTranslation { get { return this[nameof(bTranslation)].Flag; } set { this[nameof(bTranslation)].Flag = value; } }
        public bool bRotation { get { return this[nameof(bRotation)].Flag; } set { this[nameof(bRotation)].Flag = value; } }
        public bool bScale { get { return this[nameof(bScale)].Flag; } set { this[nameof(bScale)].Flag = value; } }
        public bool bParent { get { return this[nameof(bParent)].Flag; } set { this[nameof(bParent)].Flag = value; } }
        public FilterOptionPerAxis TranslationAxes { get { return this[nameof(TranslationAxes)].As<FilterOptionPerAxis>(); } set { this["TranslationAxes"] = value; } }
        public FilterOptionPerAxis RotationAxes { get { return this[nameof(RotationAxes)].As<FilterOptionPerAxis>(); } set { this["RotationAxes"] = value; } }
        public FilterOptionPerAxis ScaleAxes { get { return this[nameof(ScaleAxes)].As<FilterOptionPerAxis>(); } set { this["ScaleAxes"] = value; } }
    }
    public class FilterOptionPerAxis : Object
    {
        public FilterOptionPerAxis(nint addr) : base(addr) { }
        public bool bX { get { return this[nameof(bX)].Flag; } set { this[nameof(bX)].Flag = value; } }
        public bool bY { get { return this[nameof(bY)].Flag; } set { this[nameof(bY)].Flag = value; } }
        public bool bZ { get { return this[nameof(bZ)].Flag; } set { this[nameof(bZ)].Flag = value; } }
    }
    public class ConstraintOffset : Object
    {
        public ConstraintOffset(nint addr) : base(addr) { }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public Transform Parent { get { return this[nameof(Parent)].As<Transform>(); } set { this["Parent"] = value; } }
    }
    public class NodeHierarchyWithUserData : Object
    {
        public NodeHierarchyWithUserData(nint addr) : base(addr) { }
        public NodeHierarchyData Hierarchy { get { return this[nameof(Hierarchy)].As<NodeHierarchyData>(); } set { this["Hierarchy"] = value; } }
    }
    public class NodeHierarchyData : Object
    {
        public NodeHierarchyData(nint addr) : base(addr) { }
        public Array<NodeObject> Nodes { get { return new Array<NodeObject>(this[nameof(Nodes)].Address); } }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
        public Object NodeNameToIndexMapping { get { return this[nameof(NodeNameToIndexMapping)]; } set { this[nameof(NodeNameToIndexMapping)] = value; } }
    }
    public class NodeObject : Object
    {
        public NodeObject(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ParentName { get { return this[nameof(ParentName)]; } set { this[nameof(ParentName)] = value; } }
    }
    public class TransformFilter : Object
    {
        public TransformFilter(nint addr) : base(addr) { }
        public FilterOptionPerAxis TranslationFilter { get { return this[nameof(TranslationFilter)].As<FilterOptionPerAxis>(); } set { this["TranslationFilter"] = value; } }
        public FilterOptionPerAxis RotationFilter { get { return this[nameof(RotationFilter)].As<FilterOptionPerAxis>(); } set { this["RotationFilter"] = value; } }
        public FilterOptionPerAxis ScaleFilter { get { return this[nameof(ScaleFilter)].As<FilterOptionPerAxis>(); } set { this["ScaleFilter"] = value; } }
    }
    public class EulerTransform : Object
    {
        public EulerTransform(nint addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
    }
    public class ConstraintData : Object
    {
        public ConstraintData(nint addr) : base(addr) { }
        public ConstraintDescriptor Constraint { get { return this[nameof(Constraint)].As<ConstraintDescriptor>(); } set { this["Constraint"] = value; } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool bMaintainOffset { get { return this[nameof(bMaintainOffset)].Flag; } set { this[nameof(bMaintainOffset)].Flag = value; } }
        public Transform Offset { get { return this[nameof(Offset)].As<Transform>(); } set { this["Offset"] = value; } }
        public Transform CurrentTransform { get { return this[nameof(CurrentTransform)].As<Transform>(); } set { this["CurrentTransform"] = value; } }
    }
    public class ConstraintDescriptor : Object
    {
        public ConstraintDescriptor(nint addr) : base(addr) { }
        public EConstraintType Type { get { return (EConstraintType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class CCDIKChainLink : Object
    {
        public CCDIKChainLink(nint addr) : base(addr) { }
    }
    public class FABRIKChainLink : Object
    {
        public FABRIKChainLink(nint addr) : base(addr) { }
    }
    public class Axis : Object
    {
        public Axis(nint addr) : base(addr) { }
        public Vector Axis_value { get { return this[nameof(Axis)].As<Vector>(); } set { this["Axis"] = value; } }
        public bool bInLocalSpace { get { return this[nameof(bInLocalSpace)].Flag; } set { this[nameof(bInLocalSpace)].Flag = value; } }
    }
    public class NodeChain : Object
    {
        public NodeChain(nint addr) : base(addr) { }
        public Array<Object> Nodes { get { return new Array<Object>(this[nameof(Nodes)].Address); } }
    }
    public class ConstraintDescriptionEx : Object
    {
        public ConstraintDescriptionEx(nint addr) : base(addr) { }
        public FilterOptionPerAxis AxesFilterOption { get { return this[nameof(AxesFilterOption)].As<FilterOptionPerAxis>(); } set { this["AxesFilterOption"] = value; } }
    }
    public class TransformConstraintDescription : ConstraintDescriptionEx
    {
        public TransformConstraintDescription(nint addr) : base(addr) { }
        public ETransformConstraintType TransformType { get { return (ETransformConstraintType)this[nameof(TransformType)].GetValue<int>(); } set { this[nameof(TransformType)].SetValue<int>((int)value); } }
    }
    public class AimConstraintDescription : ConstraintDescriptionEx
    {
        public AimConstraintDescription(nint addr) : base(addr) { }
        public Axis LookAt_Axis { get { return this[nameof(LookAt_Axis)].As<Axis>(); } set { this["LookAt_Axis"] = value; } }
        public Axis LookUp_Axis { get { return this[nameof(LookUp_Axis)].As<Axis>(); } set { this["LookUp_Axis"] = value; } }
        public bool bUseLookUp { get { return this[nameof(bUseLookUp)].Flag; } set { this[nameof(bUseLookUp)].Flag = value; } }
        public Vector LookUpTarget { get { return this[nameof(LookUpTarget)].As<Vector>(); } set { this["LookUpTarget"] = value; } }
    }
    public class TransformNoScale : Object
    {
        public TransformNoScale(nint addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
}
