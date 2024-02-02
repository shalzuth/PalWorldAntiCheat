using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.LiveLinkInterfaceSDK;
namespace SDK.Script.LiveLinkAnimationCoreSDK
{
    public class LiveLinkInstance : AnimInstance
    {
        public LiveLinkInstance(nint addr) : base(addr) { }
        public LiveLinkRetargetAsset CurrentRetargetAsset { get { return this[nameof(CurrentRetargetAsset)].As<LiveLinkRetargetAsset>(); } set { this["CurrentRetargetAsset"] = value; } }
        public void SetSubject(LiveLinkSubjectName SubjectName) { Invoke(nameof(SetSubject), SubjectName); }
        public void SetRetargetAsset(Object RetargetAsset) { Invoke(nameof(SetRetargetAsset), RetargetAsset); }
    }
    public class LiveLinkRetargetAsset : Object
    {
        public LiveLinkRetargetAsset(nint addr) : base(addr) { }
    }
    public class LiveLinkRemapAsset : LiveLinkRetargetAsset
    {
        public LiveLinkRemapAsset(nint addr) : base(addr) { }
        public void RemapCurveElements(Object CurveItems) { Invoke(nameof(RemapCurveElements), CurveItems); }
        public Object GetRemappedCurveName(Object CurveName) { return Invoke<Object>(nameof(GetRemappedCurveName), CurveName); }
        public Object GetRemappedBoneName(Object BoneName) { return Invoke<Object>(nameof(GetRemappedBoneName), BoneName); }
    }
    public class AnimNode_LiveLinkPose : AnimNode_Base
    {
        public AnimNode_LiveLinkPose(nint addr) : base(addr) { }
        public PoseLink InputPose { get { return this[nameof(InputPose)].As<PoseLink>(); } set { this["InputPose"] = value; } }
        public LiveLinkSubjectName LiveLinkSubjectName { get { return this[nameof(LiveLinkSubjectName)].As<LiveLinkSubjectName>(); } set { this["LiveLinkSubjectName"] = value; } }
        public Object RetargetAsset { get { return this[nameof(RetargetAsset)]; } set { this[nameof(RetargetAsset)] = value; } }
        public LiveLinkRetargetAsset CurrentRetargetAsset { get { return this[nameof(CurrentRetargetAsset)].As<LiveLinkRetargetAsset>(); } set { this["CurrentRetargetAsset"] = value; } }
    }
    public class LiveLinkInstanceProxy : AnimInstanceProxy
    {
        public LiveLinkInstanceProxy(nint addr) : base(addr) { }
        public AnimNode_LiveLinkPose PoseNode { get { return this[nameof(PoseNode)].As<AnimNode_LiveLinkPose>(); } set { this["PoseNode"] = value; } }
    }
}
