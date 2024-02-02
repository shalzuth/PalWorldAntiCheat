using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.AnimationCoreSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ConstraintsSDK
{
    public class TransformableHandle : Object
    {
        public TransformableHandle(nint addr) : base(addr) { }
        public MovieSceneObjectBindingID ConstraintBindingID { get { return this[nameof(ConstraintBindingID)].As<MovieSceneObjectBindingID>(); } set { this["ConstraintBindingID"] = value; } }
    }
    public class ConstraintsActor : Actor
    {
        public ConstraintsActor(nint addr) : base(addr) { }
        public ConstraintsManager ConstraintsManager { get { return this[nameof(ConstraintsManager)].As<ConstraintsManager>(); } set { this["ConstraintsManager"] = value; } }
    }
    public class TickableConstraint : Object
    {
        public TickableConstraint(nint addr) : base(addr) { }
        public ConstraintTickFunction ConstraintTick { get { return this[nameof(ConstraintTick)].As<ConstraintTickFunction>(); } set { this["ConstraintTick"] = value; } }
        public bool Active { get { return this[nameof(Active)].Flag; } set { this[nameof(Active)].Flag = value; } }
    }
    public class ConstraintsManager : Object
    {
        public ConstraintsManager(nint addr) : base(addr) { }
        public Object OnConstraintAdded_BP { get { return this[nameof(OnConstraintAdded_BP)]; } set { this[nameof(OnConstraintAdded_BP)] = value; } }
        public Object OnConstraintRemoved_BP { get { return this[nameof(OnConstraintRemoved_BP)]; } set { this[nameof(OnConstraintRemoved_BP)] = value; } }
        public Array<TickableConstraint> Constraints { get { return new Array<TickableConstraint>(this[nameof(Constraints)].Address); } }
    }
    public class ConstraintsScriptingLibrary : BlueprintFunctionLibrary
    {
        public ConstraintsScriptingLibrary(nint addr) : base(addr) { }
        public bool RemoveConstraint(World InWorld, int InIndex) { return Invoke<bool>(nameof(RemoveConstraint), InWorld, InIndex); }
        public ConstraintsManager GetManager(World InWorld) { return Invoke<ConstraintsManager>(nameof(GetManager), InWorld); }
        public TransformableComponentHandle CreateTransformableComponentHandle(World InWorld, SceneComponent InSceneComponent, Object InSocketName) { return Invoke<TransformableComponentHandle>(nameof(CreateTransformableComponentHandle), InWorld, InSceneComponent, InSocketName); }
        public TickableTransformConstraint CreateFromType(World InWorld, ETransformConstraintType InType) { return Invoke<TickableTransformConstraint>(nameof(CreateFromType), InWorld, InType); }
        public bool AddConstraint(World InWorld, TransformableHandle InParentHandle, TransformableHandle InChildHandle, TickableTransformConstraint InConstraint, bool bMaintainOffset) { return Invoke<bool>(nameof(AddConstraint), InWorld, InParentHandle, InChildHandle, InConstraint, bMaintainOffset); }
    }
    public class TransformableComponentHandle : TransformableHandle
    {
        public TransformableComponentHandle(nint addr) : base(addr) { }
        public Object Component { get { return this[nameof(Component)]; } set { this[nameof(Component)] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class TickableTransformConstraint : TickableConstraint
    {
        public TickableTransformConstraint(nint addr) : base(addr) { }
        public TransformableHandle ParentTRSHandle { get { return this[nameof(ParentTRSHandle)].As<TransformableHandle>(); } set { this["ParentTRSHandle"] = value; } }
        public TransformableHandle ChildTRSHandle { get { return this[nameof(ChildTRSHandle)].As<TransformableHandle>(); } set { this["ChildTRSHandle"] = value; } }
        public bool bMaintainOffset { get { return this[nameof(bMaintainOffset)].Flag; } set { this[nameof(bMaintainOffset)].Flag = value; } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool bDynamicOffset { get { return this[nameof(bDynamicOffset)].Flag; } set { this[nameof(bDynamicOffset)].Flag = value; } }
        public ETransformConstraintType Type { get { return (ETransformConstraintType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class TickableTranslationConstraint : TickableTransformConstraint
    {
        public TickableTranslationConstraint(nint addr) : base(addr) { }
        public Vector OffsetTranslation { get { return this[nameof(OffsetTranslation)].As<Vector>(); } set { this["OffsetTranslation"] = value; } }
    }
    public class TickableRotationConstraint : TickableTransformConstraint
    {
        public TickableRotationConstraint(nint addr) : base(addr) { }
        public Quat OffsetRotation { get { return this[nameof(OffsetRotation)].As<Quat>(); } set { this["OffsetRotation"] = value; } }
    }
    public class TickableScaleConstraint : TickableTransformConstraint
    {
        public TickableScaleConstraint(nint addr) : base(addr) { }
        public Vector OffsetScale { get { return this[nameof(OffsetScale)].As<Vector>(); } set { this["OffsetScale"] = value; } }
    }
    public class TickableParentConstraint : TickableTransformConstraint
    {
        public TickableParentConstraint(nint addr) : base(addr) { }
        public Transform OffsetTransform { get { return this[nameof(OffsetTransform)].As<Transform>(); } set { this["OffsetTransform"] = value; } }
        public bool bScaling { get { return this[nameof(bScaling)].Flag; } set { this[nameof(bScaling)].Flag = value; } }
    }
    public class TickableLookAtConstraint : TickableTransformConstraint
    {
        public TickableLookAtConstraint(nint addr) : base(addr) { }
        public Vector Axis { get { return this[nameof(Axis)].As<Vector>(); } set { this["Axis"] = value; } }
    }
    public enum EHandleEvent : int
    {
        LocalTransformUpdated = 0,
        GlobalTransformUpdated = 1,
        ComponentUpdated = 2,
        Max = 3,
    }
    public class ConstraintAndActiveChannel : Object
    {
        public ConstraintAndActiveChannel(nint addr) : base(addr) { }
        public Object Constraint { get { return this[nameof(Constraint)]; } set { this[nameof(Constraint)] = value; } }
        public MovieSceneConstraintChannel ActiveChannel { get { return this[nameof(ActiveChannel)].As<MovieSceneConstraintChannel>(); } set { this["ActiveChannel"] = value; } }
        public TickableConstraint ConstraintCopyToSpawn { get { return this[nameof(ConstraintCopyToSpawn)].As<TickableConstraint>(); } set { this["ConstraintCopyToSpawn"] = value; } }
    }
    public class MovieSceneConstraintChannel : MovieSceneBoolChannel
    {
        public MovieSceneConstraintChannel(nint addr) : base(addr) { }
    }
    public class ConstraintTickFunction : TickFunction
    {
        public ConstraintTickFunction(nint addr) : base(addr) { }
    }
}
