using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CinematicCameraSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TemplateSequenceSDK
{
    public class TemplateSequence : MovieSceneSequence
    {
        public TemplateSequence(nint addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public Object BoundActorClass { get { return this[nameof(BoundActorClass)]; } set { this[nameof(BoundActorClass)] = value; } }
        public Object BoundPreviewActor { get { return this[nameof(BoundPreviewActor)]; } set { this[nameof(BoundPreviewActor)] = value; } }
        public Object BoundActorComponents { get { return this[nameof(BoundActorComponents)]; } set { this[nameof(BoundActorComponents)] = value; } }
    }
    public class CameraAnimationSequence : TemplateSequence
    {
        public CameraAnimationSequence(nint addr) : base(addr) { }
    }
    public class CameraAnimationSequenceCameraStandIn : Object
    {
        public CameraAnimationSequenceCameraStandIn(nint addr) : base(addr) { }
        public float FieldOfView { get { return this[nameof(FieldOfView)].GetValue<float>(); } set { this[nameof(FieldOfView)].SetValue<float>(value); } }
        public bool bConstrainAspectRatio { get { return this[nameof(bConstrainAspectRatio)].Flag; } set { this[nameof(bConstrainAspectRatio)].Flag = value; } }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
        public PostProcessSettings PostProcessSettings { get { return this[nameof(PostProcessSettings)].As<PostProcessSettings>(); } set { this["PostProcessSettings"] = value; } }
        public float PostProcessBlendWeight { get { return this[nameof(PostProcessBlendWeight)].GetValue<float>(); } set { this[nameof(PostProcessBlendWeight)].SetValue<float>(value); } }
        public CameraFilmbackSettings Filmback { get { return this[nameof(Filmback)].As<CameraFilmbackSettings>(); } set { this["Filmback"] = value; } }
        public CameraLensSettings LensSettings { get { return this[nameof(LensSettings)].As<CameraLensSettings>(); } set { this["LensSettings"] = value; } }
        public CameraFocusSettings FocusSettings { get { return this[nameof(FocusSettings)].As<CameraFocusSettings>(); } set { this["FocusSettings"] = value; } }
        public float CurrentFocalLength { get { return this[nameof(CurrentFocalLength)].GetValue<float>(); } set { this[nameof(CurrentFocalLength)].SetValue<float>(value); } }
        public float CurrentAperture { get { return this[nameof(CurrentAperture)].GetValue<float>(); } set { this[nameof(CurrentAperture)].SetValue<float>(value); } }
        public float CurrentFocusDistance { get { return this[nameof(CurrentFocusDistance)].GetValue<float>(); } set { this[nameof(CurrentFocusDistance)].SetValue<float>(value); } }
    }
    public class CameraAnimationSequencePlayer : Object
    {
        public CameraAnimationSequencePlayer(nint addr) : base(addr) { }
        public Object BoundObjectOverride { get { return this[nameof(BoundObjectOverride)].As<Object>(); } set { this["BoundObjectOverride"] = value; } }
        public MovieSceneSequence Sequence { get { return this[nameof(Sequence)].As<MovieSceneSequence>(); } set { this["Sequence"] = value; } }
        public MovieSceneRootEvaluationTemplateInstance RootTemplateInstance { get { return this[nameof(RootTemplateInstance)].As<MovieSceneRootEvaluationTemplateInstance>(); } set { this["RootTemplateInstance"] = value; } }
    }
    public class CameraAnimationSpawnableSystem : MovieSceneEntitySystem
    {
        public CameraAnimationSpawnableSystem(nint addr) : base(addr) { }
    }
    public class CameraAnimationBoundObjectInstantiator : MovieSceneEntityInstantiatorSystem
    {
        public CameraAnimationBoundObjectInstantiator(nint addr) : base(addr) { }
    }
    public class CameraAnimationEntitySystemLinker : MovieSceneEntitySystemLinker
    {
        public CameraAnimationEntitySystemLinker(nint addr) : base(addr) { }
    }
    public class CameraAnimationSequenceSubsystem : WorldSubsystem
    {
        public CameraAnimationSequenceSubsystem(nint addr) : base(addr) { }
        public MovieSceneEntitySystemLinker Linker { get { return this[nameof(Linker)].As<MovieSceneEntitySystemLinker>(); } set { this["Linker"] = value; } }
    }
    public class TemplateSequenceSection : MovieSceneSubSection
    {
        public TemplateSequenceSection(nint addr) : base(addr) { }
        public Array<TemplateSectionPropertyScale> PropertyScales { get { return new Array<TemplateSectionPropertyScale>(this[nameof(PropertyScales)].Address); } }
    }
    public class SequenceCameraShakePattern : CameraShakePattern
    {
        public SequenceCameraShakePattern(nint addr) : base(addr) { }
        public CameraAnimationSequence Sequence { get { return this[nameof(Sequence)].As<CameraAnimationSequence>(); } set { this["Sequence"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
        public float RandomSegmentDuration { get { return this[nameof(RandomSegmentDuration)].GetValue<float>(); } set { this[nameof(RandomSegmentDuration)].SetValue<float>(value); } }
        public bool bRandomSegment { get { return this[nameof(bRandomSegment)].Flag; } set { this[nameof(bRandomSegment)].Flag = value; } }
        public CameraAnimationSequencePlayer Player { get { return this[nameof(Player)].As<CameraAnimationSequencePlayer>(); } set { this["Player"] = value; } }
        public CameraAnimationSequenceCameraStandIn CameraStandIn { get { return this[nameof(CameraStandIn)].As<CameraAnimationSequenceCameraStandIn>(); } set { this["CameraStandIn"] = value; } }
    }
    public class TemplateSequenceSystem : MovieSceneEntitySystem
    {
        public TemplateSequenceSystem(nint addr) : base(addr) { }
    }
    public class TemplateSequencePropertyScalingInstantiatorSystem : MovieSceneEntitySystem
    {
        public TemplateSequencePropertyScalingInstantiatorSystem(nint addr) : base(addr) { }
    }
    public class TemplateSequencePropertyScalingEvaluatorSystem : MovieSceneEntitySystem
    {
        public TemplateSequencePropertyScalingEvaluatorSystem(nint addr) : base(addr) { }
    }
    public class TemplateSequenceActor : Actor
    {
        public TemplateSequenceActor(nint addr) : base(addr) { }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public TemplateSequencePlayer SequencePlayer { get { return this[nameof(SequencePlayer)].As<TemplateSequencePlayer>(); } set { this["SequencePlayer"] = value; } }
        public SoftObjectPath TemplateSequence { get { return this[nameof(TemplateSequence)].As<SoftObjectPath>(); } set { this["TemplateSequence"] = value; } }
        public TemplateSequenceBindingOverrideData BindingOverride { get { return this[nameof(BindingOverride)].As<TemplateSequenceBindingOverrideData>(); } set { this["BindingOverride"] = value; } }
        public void SetSequence(TemplateSequence InSequence) { Invoke(nameof(SetSequence), InSequence); }
        public void SetBinding(Actor Actor, bool bOverridesDefault) { Invoke(nameof(SetBinding), Actor, bOverridesDefault); }
        public TemplateSequence LoadSequence() { return Invoke<TemplateSequence>(nameof(LoadSequence)); }
        public TemplateSequencePlayer GetSequencePlayer() { return Invoke<TemplateSequencePlayer>(nameof(GetSequencePlayer)); }
        public TemplateSequence GetSequence() { return Invoke<TemplateSequence>(nameof(GetSequence)); }
    }
    public class TemplateSequencePlayer : MovieSceneSequencePlayer
    {
        public TemplateSequencePlayer(nint addr) : base(addr) { }
        public TemplateSequencePlayer CreateTemplateSequencePlayer(Object WorldContextObject, TemplateSequence TemplateSequence, MovieSceneSequencePlaybackSettings Settings, TemplateSequenceActor OutActor) { return Invoke<TemplateSequencePlayer>(nameof(CreateTemplateSequencePlayer), WorldContextObject, TemplateSequence, Settings, OutActor); }
    }
    public class SequenceCameraShakeTestUtil : BlueprintFunctionLibrary
    {
        public SequenceCameraShakeTestUtil(nint addr) : base(addr) { }
        public bool GetPostProcessBlendCache(PlayerController PlayerController, int PPIndex, PostProcessSettings OutPPSettings, float OutPPBlendWeight) { return Invoke<bool>(nameof(GetPostProcessBlendCache), PlayerController, PPIndex, OutPPSettings, OutPPBlendWeight); }
        public MinimalViewInfo GetLastFrameCameraCachePOV(PlayerController PlayerController) { return Invoke<MinimalViewInfo>(nameof(GetLastFrameCameraCachePOV), PlayerController); }
        public MinimalViewInfo GetCameraCachePOV(PlayerController PlayerController) { return Invoke<MinimalViewInfo>(nameof(GetCameraCachePOV), PlayerController); }
    }
    public class TemplateSequenceTrack : MovieSceneSubTrack
    {
        public TemplateSequenceTrack(nint addr) : base(addr) { }
    }
    public enum ETemplateSectionPropertyScaleType : int
    {
        FloatProperty = 0,
        TransformPropertyLocationOnly = 1,
        TransformPropertyRotationOnly = 2,
        ETemplateSectionPropertyScaleType_MAX = 3,
    }
    public class TemplateSectionPropertyScale : Object
    {
        public TemplateSectionPropertyScale(nint addr) : base(addr) { }
        public Guid ObjectBinding { get { return this[nameof(ObjectBinding)].As<Guid>(); } set { this["ObjectBinding"] = value; } }
        public MovieScenePropertyBinding PropertyBinding { get { return this[nameof(PropertyBinding)].As<MovieScenePropertyBinding>(); } set { this["PropertyBinding"] = value; } }
        public ETemplateSectionPropertyScaleType PropertyScaleType { get { return (ETemplateSectionPropertyScaleType)this[nameof(PropertyScaleType)].GetValue<int>(); } set { this[nameof(PropertyScaleType)].SetValue<int>((int)value); } }
        //public MovieSceneFloatChannel FloatChannel { get { return this[nameof(FloatChannel)].As<MovieSceneFloatChannel>(); } set { this["FloatChannel"] = value; } }
    }
    public class TemplateSequenceBindingOverrideData : Object
    {
        public TemplateSequenceBindingOverrideData(nint addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public bool bOverridesDefault { get { return this[nameof(bOverridesDefault)].Flag; } set { this[nameof(bOverridesDefault)].Flag = value; } }
    }
}
