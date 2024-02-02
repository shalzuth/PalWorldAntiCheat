using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.LiveLinkInterfaceSDK;
namespace SDK.Script.LiveLinkComponentsSDK
{
    public class LiveLinkComponentSettings : Object
    {
        public LiveLinkComponentSettings(nint addr) : base(addr) { }
        public Object DefaultControllerForRole { get { return this[nameof(DefaultControllerForRole)]; } set { this[nameof(DefaultControllerForRole)] = value; } }
    }
    public class LiveLinkControllerBase : Object
    {
        public LiveLinkControllerBase(nint addr) : base(addr) { }
        public ComponentReference ComponentPicker { get { return this[nameof(ComponentPicker)].As<ComponentReference>(); } set { this["ComponentPicker"] = value; } }
    }
    public class LiveLinkLightController : LiveLinkControllerBase
    {
        public LiveLinkLightController(nint addr) : base(addr) { }
    }
    public class LiveLinkTransformController : LiveLinkControllerBase
    {
        public LiveLinkTransformController(nint addr) : base(addr) { }
        public LiveLinkTransformControllerData TransformData { get { return this[nameof(TransformData)].As<LiveLinkTransformControllerData>(); } set { this["TransformData"] = value; } }
    }
    public class LiveLinkComponentController : ActorComponent
    {
        public LiveLinkComponentController(nint addr) : base(addr) { }
        public LiveLinkSubjectRepresentation SubjectRepresentation { get { return this[nameof(SubjectRepresentation)].As<LiveLinkSubjectRepresentation>(); } set { this["SubjectRepresentation"] = value; } }
        public Object ControllerMap { get { return this[nameof(ControllerMap)]; } set { this[nameof(ControllerMap)] = value; } }
        public bool bUpdateInEditor { get { return this[nameof(bUpdateInEditor)].Flag; } set { this[nameof(bUpdateInEditor)].Flag = value; } }
        public Object OnLiveLinkUpdated { get { return this[nameof(OnLiveLinkUpdated)]; } set { this[nameof(OnLiveLinkUpdated)] = value; } }
        public Object OnControllerMapUpdatedDelegate { get { return this[nameof(OnControllerMapUpdatedDelegate)]; } set { this[nameof(OnControllerMapUpdatedDelegate)] = value; } }
        public bool bDisableEvaluateLiveLinkWhenSpawnable { get { return this[nameof(bDisableEvaluateLiveLinkWhenSpawnable)].Flag; } set { this[nameof(bDisableEvaluateLiveLinkWhenSpawnable)].Flag = value; } }
        public bool bEvaluateLiveLink { get { return this[nameof(bEvaluateLiveLink)].Flag; } set { this[nameof(bEvaluateLiveLink)].Flag = value; } }
        public bool bUpdateInPreviewEditor { get { return this[nameof(bUpdateInPreviewEditor)].Flag; } set { this[nameof(bUpdateInPreviewEditor)].Flag = value; } }
        public void SetSubjectRepresentation(LiveLinkSubjectRepresentation InSubjectRepresentation) { Invoke(nameof(SetSubjectRepresentation), InSubjectRepresentation); }
        public LiveLinkSubjectRepresentation GetSubjectRepresentation() { return Invoke<LiveLinkSubjectRepresentation>(nameof(GetSubjectRepresentation)); }
    }
    public class LiveLinkTransformControllerData : Object
    {
        public LiveLinkTransformControllerData(nint addr) : base(addr) { }
        public bool bWorldTransform { get { return this[nameof(bWorldTransform)].Flag; } set { this[nameof(bWorldTransform)].Flag = value; } }
        public bool bUseLocation { get { return this[nameof(bUseLocation)].Flag; } set { this[nameof(bUseLocation)].Flag = value; } }
        public bool bUseRotation { get { return this[nameof(bUseRotation)].Flag; } set { this[nameof(bUseRotation)].Flag = value; } }
        public bool bUseScale { get { return this[nameof(bUseScale)].Flag; } set { this[nameof(bUseScale)].Flag = value; } }
        public bool bSweep { get { return this[nameof(bSweep)].Flag; } set { this[nameof(bSweep)].Flag = value; } }
        public bool bTeleport { get { return this[nameof(bTeleport)].Flag; } set { this[nameof(bTeleport)].Flag = value; } }
    }
}
