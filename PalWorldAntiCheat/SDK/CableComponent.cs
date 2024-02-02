using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.CableComponentSDK
{
    public class CableActor : Actor
    {
        public CableActor(nint addr) : base(addr) { }
        public CableComponent CableComponent { get { return this[nameof(CableComponent)].As<CableComponent>(); } set { this["CableComponent"] = value; } }
    }
    public class CableComponent : MeshComponent
    {
        public CableComponent(nint addr) : base(addr) { }
        public bool bAttachStart { get { return this[nameof(bAttachStart)].Flag; } set { this[nameof(bAttachStart)].Flag = value; } }
        public bool bAttachEnd { get { return this[nameof(bAttachEnd)].Flag; } set { this[nameof(bAttachEnd)].Flag = value; } }
        public ComponentReference AttachEndTo { get { return this[nameof(AttachEndTo)].As<ComponentReference>(); } set { this["AttachEndTo"] = value; } }
        public Object AttachEndToSocketName { get { return this[nameof(AttachEndToSocketName)]; } set { this[nameof(AttachEndToSocketName)] = value; } }
        public Vector EndLocation { get { return this[nameof(EndLocation)].As<Vector>(); } set { this["EndLocation"] = value; } }
        public float CableLength { get { return this[nameof(CableLength)].GetValue<float>(); } set { this[nameof(CableLength)].SetValue<float>(value); } }
        public int NumSegments { get { return this[nameof(NumSegments)].GetValue<int>(); } set { this[nameof(NumSegments)].SetValue<int>(value); } }
        public float SubstepTime { get { return this[nameof(SubstepTime)].GetValue<float>(); } set { this[nameof(SubstepTime)].SetValue<float>(value); } }
        public int SolverIterations { get { return this[nameof(SolverIterations)].GetValue<int>(); } set { this[nameof(SolverIterations)].SetValue<int>(value); } }
        public bool bEnableStiffness { get { return this[nameof(bEnableStiffness)].Flag; } set { this[nameof(bEnableStiffness)].Flag = value; } }
        public bool bUseSubstepping { get { return this[nameof(bUseSubstepping)].Flag; } set { this[nameof(bUseSubstepping)].Flag = value; } }
        public bool bSkipCableUpdateWhenNotVisible { get { return this[nameof(bSkipCableUpdateWhenNotVisible)].Flag; } set { this[nameof(bSkipCableUpdateWhenNotVisible)].Flag = value; } }
        public bool bSkipCableUpdateWhenNotOwnerRecentlyRendered { get { return this[nameof(bSkipCableUpdateWhenNotOwnerRecentlyRendered)].Flag; } set { this[nameof(bSkipCableUpdateWhenNotOwnerRecentlyRendered)].Flag = value; } }
        public bool bEnableCollision { get { return this[nameof(bEnableCollision)].Flag; } set { this[nameof(bEnableCollision)].Flag = value; } }
        public float CollisionFriction { get { return this[nameof(CollisionFriction)].GetValue<float>(); } set { this[nameof(CollisionFriction)].SetValue<float>(value); } }
        public Vector CableForce { get { return this[nameof(CableForce)].As<Vector>(); } set { this["CableForce"] = value; } }
        public float CableGravityScale { get { return this[nameof(CableGravityScale)].GetValue<float>(); } set { this[nameof(CableGravityScale)].SetValue<float>(value); } }
        public float CableWidth { get { return this[nameof(CableWidth)].GetValue<float>(); } set { this[nameof(CableWidth)].SetValue<float>(value); } }
        public int NumSides { get { return this[nameof(NumSides)].GetValue<int>(); } set { this[nameof(NumSides)].SetValue<int>(value); } }
        public float TileMaterial { get { return this[nameof(TileMaterial)].GetValue<float>(); } set { this[nameof(TileMaterial)].SetValue<float>(value); } }
        public void SetAttachEndToComponent(SceneComponent Component, Object SocketName) { Invoke(nameof(SetAttachEndToComponent), Component, SocketName); }
        public void SetAttachEndTo(Actor Actor, Object ComponentProperty, Object SocketName) { Invoke(nameof(SetAttachEndTo), Actor, ComponentProperty, SocketName); }
        public void GetCableParticleLocations(Array<Vector> locations) { Invoke(nameof(GetCableParticleLocations), locations); }
        public SceneComponent GetAttachedComponent() { return Invoke<SceneComponent>(nameof(GetAttachedComponent)); }
        public Actor GetAttachedActor() { return Invoke<Actor>(nameof(GetAttachedActor)); }
    }
}
