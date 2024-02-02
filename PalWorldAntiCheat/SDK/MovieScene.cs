using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MovieSceneSDK
{
    public class MovieSceneSignedObject : Object
    {
        public MovieSceneSignedObject(nint addr) : base(addr) { }
        public Guid Signature { get { return this[nameof(Signature)].As<Guid>(); } set { this["Signature"] = value; } }
    }
    public class MovieSceneSection : MovieSceneSignedObject
    {
        public MovieSceneSection(nint addr) : base(addr) { }
        public MovieSceneSectionEvalOptions EvalOptions { get { return this[nameof(EvalOptions)].As<MovieSceneSectionEvalOptions>(); } set { this["EvalOptions"] = value; } }
        public MovieSceneEasingSettings Easing { get { return this[nameof(Easing)].As<MovieSceneEasingSettings>(); } set { this["Easing"] = value; } }
        public MovieSceneFrameRange SectionRange { get { return this[nameof(SectionRange)].As<MovieSceneFrameRange>(); } set { this["SectionRange"] = value; } }
        public FrameNumber PreRollFrames { get { return this[nameof(PreRollFrames)].As<FrameNumber>(); } set { this["PreRollFrames"] = value; } }
        public FrameNumber PostRollFrames { get { return this[nameof(PostRollFrames)].As<FrameNumber>(); } set { this["PostRollFrames"] = value; } }
        public int RowIndex { get { return this[nameof(RowIndex)].GetValue<int>(); } set { this[nameof(RowIndex)].SetValue<int>(value); } }
        public int OverlapPriority { get { return this[nameof(OverlapPriority)].GetValue<int>(); } set { this[nameof(OverlapPriority)].SetValue<int>(value); } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public bool bIsLocked { get { return this[nameof(bIsLocked)].Flag; } set { this[nameof(bIsLocked)].Flag = value; } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public float EndTime { get { return this[nameof(EndTime)].GetValue<float>(); } set { this[nameof(EndTime)].SetValue<float>(value); } }
        public float PrerollTime { get { return this[nameof(PrerollTime)].GetValue<float>(); } set { this[nameof(PrerollTime)].SetValue<float>(value); } }
        public float PostrollTime { get { return this[nameof(PostrollTime)].GetValue<float>(); } set { this[nameof(PostrollTime)].SetValue<float>(value); } }
        public bool bIsInfinite { get { return this[nameof(bIsInfinite)].Flag; } set { this[nameof(bIsInfinite)].Flag = value; } }
        public bool bSupportsInfiniteRange { get { return this[nameof(bSupportsInfiniteRange)].Flag; } set { this[nameof(bSupportsInfiniteRange)].Flag = value; } }
        public OptionalMovieSceneBlendType BlendType { get { return this[nameof(BlendType)].As<OptionalMovieSceneBlendType>(); } set { this["BlendType"] = value; } }
        public void SetRowIndex(int NewRowIndex) { Invoke(nameof(SetRowIndex), NewRowIndex); }
        public void SetPreRollFrames(int InPreRollFrames) { Invoke(nameof(SetPreRollFrames), InPreRollFrames); }
        public void SetPostRollFrames(int InPostRollFrames) { Invoke(nameof(SetPostRollFrames), InPostRollFrames); }
        public void SetOverlapPriority(int NewPriority) { Invoke(nameof(SetOverlapPriority), NewPriority); }
        public void SetIsLocked(bool bInIsLocked) { Invoke(nameof(SetIsLocked), bInIsLocked); }
        public void SetIsActive(bool bInIsActive) { Invoke(nameof(SetIsActive), bInIsActive); }
        public void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode) { Invoke(nameof(SetCompletionMode), InCompletionMode); }
        public void SetBlendType(EMovieSceneBlendType InBlendType) { Invoke(nameof(SetBlendType), InBlendType); }
        public bool IsLocked() { return Invoke<bool>(nameof(IsLocked)); }
        public bool IsActive() { return Invoke<bool>(nameof(IsActive)); }
        public int GetRowIndex() { return Invoke<int>(nameof(GetRowIndex)); }
        public int GetPreRollFrames() { return Invoke<int>(nameof(GetPreRollFrames)); }
        public int GetPostRollFrames() { return Invoke<int>(nameof(GetPostRollFrames)); }
        public int GetOverlapPriority() { return Invoke<int>(nameof(GetOverlapPriority)); }
        public EMovieSceneCompletionMode GetCompletionMode() { return Invoke<EMovieSceneCompletionMode>(nameof(GetCompletionMode)); }
        public OptionalMovieSceneBlendType GetBlendType() { return Invoke<OptionalMovieSceneBlendType>(nameof(GetBlendType)); }
    }
    public class MovieSceneTrack : MovieSceneSignedObject
    {
        public MovieSceneTrack(nint addr) : base(addr) { }
        public MovieSceneTrackEvalOptions EvalOptions { get { return this[nameof(EvalOptions)].As<MovieSceneTrackEvalOptions>(); } set { this["EvalOptions"] = value; } }
        public bool bIsEvalDisabled { get { return this[nameof(bIsEvalDisabled)].Flag; } set { this[nameof(bIsEvalDisabled)].Flag = value; } }
        public Array<int> RowsDisabled { get { return new Array<int>(this[nameof(RowsDisabled)].Address); } }
        public Guid EvaluationFieldGuid { get { return this[nameof(EvaluationFieldGuid)].As<Guid>(); } set { this["EvaluationFieldGuid"] = value; } }
        public MovieSceneTrackEvaluationField EvaluationField { get { return this[nameof(EvaluationField)].As<MovieSceneTrackEvaluationField>(); } set { this["EvaluationField"] = value; } }
    }
    public class MovieSceneNameableTrack : MovieSceneTrack
    {
        public MovieSceneNameableTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneHookSection : MovieSceneSection
    {
        public MovieSceneHookSection(nint addr) : base(addr) { }
        public bool bRequiresRangedHook { get { return this[nameof(bRequiresRangedHook)].Flag; } set { this[nameof(bRequiresRangedHook)].Flag = value; } }
        public bool bRequiresTriggerHooks { get { return this[nameof(bRequiresTriggerHooks)].Flag; } set { this[nameof(bRequiresTriggerHooks)].Flag = value; } }
    }
    public class MovieSceneSequence : MovieSceneSignedObject
    {
        public MovieSceneSequence(nint addr) : base(addr) { }
        public MovieSceneCompiledData CompiledData { get { return this[nameof(CompiledData)].As<MovieSceneCompiledData>(); } set { this["CompiledData"] = value; } }
        public EMovieSceneCompletionMode DefaultCompletionMode { get { return (EMovieSceneCompletionMode)this[nameof(DefaultCompletionMode)].GetValue<int>(); } set { this[nameof(DefaultCompletionMode)].SetValue<int>((int)value); } }
        public bool bParentContextsAreSignificant { get { return this[nameof(bParentContextsAreSignificant)].Flag; } set { this[nameof(bParentContextsAreSignificant)].Flag = value; } }
        public bool bPlayableDirectly { get { return this[nameof(bPlayableDirectly)].Flag; } set { this[nameof(bPlayableDirectly)].Flag = value; } }
        public EMovieSceneSequenceFlags SequenceFlags { get { return (EMovieSceneSequenceFlags)this[nameof(SequenceFlags)].GetValue<int>(); } set { this[nameof(SequenceFlags)].SetValue<int>((int)value); } }
        public MovieSceneTimecodeSource GetEarliestTimecodeSource() { return Invoke<MovieSceneTimecodeSource>(nameof(GetEarliestTimecodeSource)); }
        public Array<MovieSceneObjectBindingID> FindBindingsByTag(Object InBindingName) { return Invoke<Array<MovieSceneObjectBindingID>>(nameof(FindBindingsByTag), InBindingName); }
        public MovieSceneObjectBindingID FindBindingByTag(Object InBindingName) { return Invoke<MovieSceneObjectBindingID>(nameof(FindBindingByTag), InBindingName); }
    }
    public class MovieSceneEntitySystem : Object
    {
        public MovieSceneEntitySystem(nint addr) : base(addr) { }
        public MovieSceneEntitySystemLinker Linker { get { return this[nameof(Linker)].As<MovieSceneEntitySystemLinker>(); } set { this["Linker"] = value; } }
    }
    public class MovieSceneEntityInstantiatorSystem : MovieSceneEntitySystem
    {
        public MovieSceneEntityInstantiatorSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneEntitySystemLinker : Object
    {
        public MovieSceneEntitySystemLinker(nint addr) : base(addr) { }
        public MovieSceneEntitySystemGraph SystemGraph { get { return this[nameof(SystemGraph)].As<MovieSceneEntitySystemGraph>(); } set { this["SystemGraph"] = value; } }
    }
    public class MovieSceneSubSection : MovieSceneSection
    {
        public MovieSceneSubSection(nint addr) : base(addr) { }
        public MovieSceneSectionParameters Parameters { get { return this[nameof(Parameters)].As<MovieSceneSectionParameters>(); } set { this["Parameters"] = value; } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float TimeScale { get { return this[nameof(TimeScale)].GetValue<float>(); } set { this[nameof(TimeScale)].SetValue<float>(value); } }
        public float PrerollTime { get { return this[nameof(PrerollTime)].GetValue<float>(); } set { this[nameof(PrerollTime)].SetValue<float>(value); } }
        public byte NetworkMask { get { return this[nameof(NetworkMask)].GetValue<byte>(); } set { this[nameof(NetworkMask)].SetValue<byte>(value); } }
        public MovieSceneSequence SubSequence { get { return this[nameof(SubSequence)].As<MovieSceneSequence>(); } set { this["SubSequence"] = value; } }
        public void SetSequence(MovieSceneSequence Sequence) { Invoke(nameof(SetSequence), Sequence); }
        public MovieSceneSequence GetSequence() { return Invoke<MovieSceneSequence>(nameof(GetSequence)); }
    }
    public class MovieSceneSequencePlayer : Object
    {
        public MovieSceneSequencePlayer(nint addr) : base(addr) { }
        public Object Observer { get { return this[nameof(Observer)]; } set { this[nameof(Observer)] = value; } }
        public Object OnPlay { get { return this[nameof(OnPlay)]; } set { this[nameof(OnPlay)] = value; } }
        public Object OnPlayReverse { get { return this[nameof(OnPlayReverse)]; } set { this[nameof(OnPlayReverse)] = value; } }
        public Object OnStop { get { return this[nameof(OnStop)]; } set { this[nameof(OnStop)] = value; } }
        public Object OnPause { get { return this[nameof(OnPause)]; } set { this[nameof(OnPause)] = value; } }
        public Object OnFinished { get { return this[nameof(OnFinished)]; } set { this[nameof(OnFinished)] = value; } }
        public byte Status { get { return this[nameof(Status)].GetValue<byte>(); } set { this[nameof(Status)].SetValue<byte>(value); } }
        public bool bReversePlayback { get { return this[nameof(bReversePlayback)].Flag; } set { this[nameof(bReversePlayback)].Flag = value; } }
        public MovieSceneSequence Sequence { get { return this[nameof(Sequence)].As<MovieSceneSequence>(); } set { this["Sequence"] = value; } }
        public FrameNumber StartTime { get { return this[nameof(StartTime)].As<FrameNumber>(); } set { this["StartTime"] = value; } }
        public int DurationFrames { get { return this[nameof(DurationFrames)].GetValue<int>(); } set { this[nameof(DurationFrames)].SetValue<int>(value); } }
        public float DurationSubFrames { get { return this[nameof(DurationSubFrames)].GetValue<float>(); } set { this[nameof(DurationSubFrames)].SetValue<float>(value); } }
        public int CurrentNumLoops { get { return this[nameof(CurrentNumLoops)].GetValue<int>(); } set { this[nameof(CurrentNumLoops)].SetValue<int>(value); } }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public MovieSceneRootEvaluationTemplateInstance RootTemplateInstance { get { return this[nameof(RootTemplateInstance)].As<MovieSceneRootEvaluationTemplateInstance>(); } set { this["RootTemplateInstance"] = value; } }
        public MovieSceneSequenceReplProperties NetSyncProps { get { return this[nameof(NetSyncProps)].As<MovieSceneSequenceReplProperties>(); } set { this["NetSyncProps"] = value; } }
        public Object PlaybackClient { get { return this[nameof(PlaybackClient)]; } set { this[nameof(PlaybackClient)] = value; } }
        public MovieSceneSequenceTickManager TickManager { get { return this[nameof(TickManager)].As<MovieSceneSequenceTickManager>(); } set { this["TickManager"] = value; } }
        public void StopAtCurrentTime() { Invoke(nameof(StopAtCurrentTime)); }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetTimeRange(float StartTime, float Duration) { Invoke(nameof(SetTimeRange), StartTime, Duration); }
        public void SetPlayRate(float PlayRate) { Invoke(nameof(SetPlayRate), PlayRate); }
        public void SetPlaybackPosition(MovieSceneSequencePlaybackParams PlaybackParams) { Invoke(nameof(SetPlaybackPosition), PlaybackParams); }
        public void SetFrameRate(FrameRate FrameRate) { Invoke(nameof(SetFrameRate), FrameRate); }
        public void SetFrameRange(int StartFrame, int Duration, float SubFrames) { Invoke(nameof(SetFrameRange), StartFrame, Duration, SubFrames); }
        public void SetDisableCameraCuts(bool bInDisableCameraCuts) { Invoke(nameof(SetDisableCameraCuts), bInDisableCameraCuts); }
        public void ScrubToSeconds(float TimeInSeconds) { Invoke(nameof(ScrubToSeconds), TimeInSeconds); }
        public bool ScrubToMarkedFrame(Object InLabel) { return Invoke<bool>(nameof(ScrubToMarkedFrame), InLabel); }
        public void ScrubToFrame(FrameTime NewPosition) { Invoke(nameof(ScrubToFrame), NewPosition); }
        public void Scrub() { Invoke(nameof(Scrub)); }
        public void RPC_OnStopEvent(FrameTime StoppedTime) { Invoke(nameof(RPC_OnStopEvent), StoppedTime); }
        public void RPC_OnFinishPlaybackEvent(FrameTime StoppedTime) { Invoke(nameof(RPC_OnFinishPlaybackEvent), StoppedTime); }
        public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FrameTime RelevantTime) { Invoke(nameof(RPC_ExplicitServerUpdateEvent), Method, RelevantTime); }
        public void RestoreState() { Invoke(nameof(RestoreState)); }
        public void PlayToSeconds(float TimeInSeconds) { Invoke(nameof(PlayToSeconds), TimeInSeconds); }
        public bool PlayToMarkedFrame(Object InLabel) { return Invoke<bool>(nameof(PlayToMarkedFrame), InLabel); }
        public void PlayToFrame(FrameTime NewPosition) { Invoke(nameof(PlayToFrame), NewPosition); }
        public void PlayTo(MovieSceneSequencePlaybackParams PlaybackParams, MovieSceneSequencePlayToParams PlayToParams) { Invoke(nameof(PlayTo), PlaybackParams, PlayToParams); }
        public void PlayReverse() { Invoke(nameof(PlayReverse)); }
        public void PlayLooping(int NumLoops) { Invoke(nameof(PlayLooping), NumLoops); }
        public void Play() { Invoke(nameof(Play)); }
        public void Pause() { Invoke(nameof(Pause)); }
        public void JumpToSeconds(float TimeInSeconds) { Invoke(nameof(JumpToSeconds), TimeInSeconds); }
        public bool JumpToMarkedFrame(Object InLabel) { return Invoke<bool>(nameof(JumpToMarkedFrame), InLabel); }
        public void JumpToFrame(FrameTime NewPosition) { Invoke(nameof(JumpToFrame), NewPosition); }
        public bool IsReversed() { return Invoke<bool>(nameof(IsReversed)); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
        public void GoToEndAndStop() { Invoke(nameof(GoToEndAndStop)); }
        public QualifiedFrameTime GetStartTime() { return Invoke<QualifiedFrameTime>(nameof(GetStartTime)); }
        public Object GetSequenceName(bool bAddClientInfo) { return Invoke<Object>(nameof(GetSequenceName), bAddClientInfo); }
        public MovieSceneSequence GetSequence() { return Invoke<MovieSceneSequence>(nameof(GetSequence)); }
        public float GetPlayRate() { return Invoke<float>(nameof(GetPlayRate)); }
        public Array<MovieSceneObjectBindingID> GetObjectBindings(Object InObject) { return Invoke<Array<MovieSceneObjectBindingID>>(nameof(GetObjectBindings), InObject); }
        public FrameRate GetFrameRate() { return Invoke<FrameRate>(nameof(GetFrameRate)); }
        public int GetFrameDuration() { return Invoke<int>(nameof(GetFrameDuration)); }
        public QualifiedFrameTime GetEndTime() { return Invoke<QualifiedFrameTime>(nameof(GetEndTime)); }
        public QualifiedFrameTime GetDuration() { return Invoke<QualifiedFrameTime>(nameof(GetDuration)); }
        public bool GetDisableCameraCuts() { return Invoke<bool>(nameof(GetDisableCameraCuts)); }
        public QualifiedFrameTime GetCurrentTime() { return Invoke<QualifiedFrameTime>(nameof(GetCurrentTime)); }
        public Array<Object> GetBoundObjects(MovieSceneObjectBindingID ObjectBinding) { return Invoke<Array<Object>>(nameof(GetBoundObjects), ObjectBinding); }
        public void ChangePlaybackDirection() { Invoke(nameof(ChangePlaybackDirection)); }
    }
    public class MovieSceneSubTrack : MovieSceneNameableTrack
    {
        public MovieSceneSubTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneChannelOverrideProvider : Interface
    {
        public MovieSceneChannelOverrideProvider(nint addr) : base(addr) { }
    }
    public class MovieSceneDeterminismSource : Interface
    {
        public MovieSceneDeterminismSource(nint addr) : base(addr) { }
    }
    public class MovieSceneEvaluationHook : Interface
    {
        public MovieSceneEvaluationHook(nint addr) : base(addr) { }
    }
    public class MovieScenePlaybackClient : Interface
    {
        public MovieScenePlaybackClient(nint addr) : base(addr) { }
    }
    public class MovieSceneSequencePlayerObserver : Interface
    {
        public MovieSceneSequencePlayerObserver(nint addr) : base(addr) { }
    }
    public class MovieSceneBindingOwnerInterface : Interface
    {
        public MovieSceneBindingOwnerInterface(nint addr) : base(addr) { }
    }
    public class MovieSceneChannelOverrideContainer : MovieSceneSignedObject
    {
        public MovieSceneChannelOverrideContainer(nint addr) : base(addr) { }
    }
    public class MovieSceneEasingFunction : Interface
    {
        public MovieSceneEasingFunction(nint addr) : base(addr) { }
        public float OnEvaluate(float Interp) { return Invoke<float>(nameof(OnEvaluate), Interp); }
    }
    public class MovieSceneKeyProxy : Interface
    {
        public MovieSceneKeyProxy(nint addr) : base(addr) { }
    }
    public class MovieSceneSequenceTickManagerClient : Interface
    {
        public MovieSceneSequenceTickManagerClient(nint addr) : base(addr) { }
    }
    public class MovieSceneSectionChannelOverrideRegistry : Object
    {
        public MovieSceneSectionChannelOverrideRegistry(nint addr) : base(addr) { }
        public Object Overrides { get { return this[nameof(Overrides)]; } set { this[nameof(Overrides)] = value; } }
    }
    public class MovieSceneTrackTemplateProducer : Interface
    {
        public MovieSceneTrackTemplateProducer(nint addr) : base(addr) { }
    }
    public class MovieSceneCompiledData : Object
    {
        public MovieSceneCompiledData(nint addr) : base(addr) { }
        public MovieSceneEvaluationTemplate EvaluationTemplate { get { return this[nameof(EvaluationTemplate)].As<MovieSceneEvaluationTemplate>(); } set { this["EvaluationTemplate"] = value; } }
        public MovieSceneSequenceHierarchy Hierarchy { get { return this[nameof(Hierarchy)].As<MovieSceneSequenceHierarchy>(); } set { this["Hierarchy"] = value; } }
        public MovieSceneEntityComponentField EntityComponentField { get { return this[nameof(EntityComponentField)].As<MovieSceneEntityComponentField>(); } set { this["EntityComponentField"] = value; } }
        public MovieSceneEvaluationField TrackTemplateField { get { return this[nameof(TrackTemplateField)].As<MovieSceneEvaluationField>(); } set { this["TrackTemplateField"] = value; } }
        public Array<FrameTime> DeterminismFences { get { return new Array<FrameTime>(this[nameof(DeterminismFences)].Address); } }
        public Guid CompiledSignature { get { return this[nameof(CompiledSignature)].As<Guid>(); } set { this["CompiledSignature"] = value; } }
        public Guid CompilerVersion { get { return this[nameof(CompilerVersion)].As<Guid>(); } set { this["CompilerVersion"] = value; } }
        public MovieSceneSequenceCompilerMaskStruct AccumulatedMask { get { return this[nameof(AccumulatedMask)].As<MovieSceneSequenceCompilerMaskStruct>(); } set { this["AccumulatedMask"] = value; } }
        public MovieSceneSequenceCompilerMaskStruct AllocatedMask { get { return this[nameof(AllocatedMask)].As<MovieSceneSequenceCompilerMaskStruct>(); } set { this["AllocatedMask"] = value; } }
        public EMovieSceneSequenceFlags AccumulatedFlags { get { return (EMovieSceneSequenceFlags)this[nameof(AccumulatedFlags)].GetValue<int>(); } set { this[nameof(AccumulatedFlags)].SetValue<int>((int)value); } }
    }
    public class MovieSceneCompiledDataManager : Object
    {
        public MovieSceneCompiledDataManager(nint addr) : base(addr) { }
        public Object Hierarchies { get { return this[nameof(Hierarchies)]; } set { this[nameof(Hierarchies)] = value; } }
        public Object TrackTemplates { get { return this[nameof(TrackTemplates)]; } set { this[nameof(TrackTemplates)] = value; } }
        public Object TrackTemplateFields { get { return this[nameof(TrackTemplateFields)]; } set { this[nameof(TrackTemplateFields)] = value; } }
        public Object EntityComponentFields { get { return this[nameof(EntityComponentFields)]; } set { this[nameof(EntityComponentFields)] = value; } }
    }
    public class MovieSceneEntityProvider : Interface
    {
        public MovieSceneEntityProvider(nint addr) : base(addr) { }
    }
    public class MovieSceneBlenderSystem : MovieSceneEntitySystem
    {
        public MovieSceneBlenderSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneGenericBoundObjectInstantiator : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneGenericBoundObjectInstantiator(nint addr) : base(addr) { }
    }
    public class MovieSceneBoundSceneComponentInstantiator : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneBoundSceneComponentInstantiator(nint addr) : base(addr) { }
    }
    public class MovieSceneValueDecomposer : Interface
    {
        public MovieSceneValueDecomposer(nint addr) : base(addr) { }
    }
    public class MovieSceneEvalTimeSystem : MovieSceneEntitySystem
    {
        public MovieSceneEvalTimeSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneEvaluationHookSystem : MovieSceneEntitySystem
    {
        public MovieSceneEvaluationHookSystem(nint addr) : base(addr) { }
        public Object PendingEventsByRootInstance { get { return this[nameof(PendingEventsByRootInstance)]; } set { this[nameof(PendingEventsByRootInstance)] = value; } }
    }
    public class MovieSceneMasterInstantiatorSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneMasterInstantiatorSystem(nint addr) : base(addr) { }
    }
    public class MovieScenePreAnimatedStateSystemInterface : Interface
    {
        public MovieScenePreAnimatedStateSystemInterface(nint addr) : base(addr) { }
    }
    public class MovieSceneCachePreAnimatedStateSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneCachePreAnimatedStateSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneRestorePreAnimatedStateSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneRestorePreAnimatedStateSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneSpawnablesSystem : MovieSceneEntitySystem
    {
        public MovieSceneSpawnablesSystem(nint addr) : base(addr) { }
    }
    public class MovieSceneTrackInstance : Object
    {
        public MovieSceneTrackInstance(nint addr) : base(addr) { }
        public Object AnimatedObject { get { return this[nameof(AnimatedObject)].As<Object>(); } set { this["AnimatedObject"] = value; } }
        public bool bIsMasterTrackInstance { get { return this[nameof(bIsMasterTrackInstance)].Flag; } set { this[nameof(bIsMasterTrackInstance)].Flag = value; } }
        public MovieSceneEntitySystemLinker PrivateLinker { get { return this[nameof(PrivateLinker)].As<MovieSceneEntitySystemLinker>(); } set { this["PrivateLinker"] = value; } }
        public Array<MovieSceneTrackInstanceInput> Inputs { get { return new Array<MovieSceneTrackInstanceInput>(this[nameof(Inputs)].Address); } }
    }
    public class MovieSceneTrackInstanceInstantiator : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneTrackInstanceInstantiator(nint addr) : base(addr) { }
    }
    public class MovieSceneTrackInstanceSystem : MovieSceneEntitySystem
    {
        public MovieSceneTrackInstanceSystem(nint addr) : base(addr) { }
        public MovieSceneTrackInstanceInstantiator Instantiator { get { return this[nameof(Instantiator)].As<MovieSceneTrackInstanceInstantiator>(); } set { this["Instantiator"] = value; } }
    }
    public class MovieSceneCustomClockSource : Interface
    {
        public MovieSceneCustomClockSource(nint addr) : base(addr) { }
        public void OnTick(float DeltaSeconds, float InPlayRate) { Invoke(nameof(OnTick), DeltaSeconds, InPlayRate); }
        public void OnStopPlaying(QualifiedFrameTime InStopTime) { Invoke(nameof(OnStopPlaying), InStopTime); }
        public void OnStartPlaying(QualifiedFrameTime InStartTime) { Invoke(nameof(OnStartPlaying), InStartTime); }
        public FrameTime OnRequestCurrentTime(QualifiedFrameTime InCurrentTime, float InPlayRate) { return Invoke<FrameTime>(nameof(OnRequestCurrentTime), InCurrentTime, InPlayRate); }
    }
    public class MovieSceneBuiltInEasingFunction : Object
    {
        public MovieSceneBuiltInEasingFunction(nint addr) : base(addr) { }
        public EMovieSceneBuiltInEasing Type { get { return (EMovieSceneBuiltInEasing)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class MovieSceneEasingExternalCurve : Object
    {
        public MovieSceneEasingExternalCurve(nint addr) : base(addr) { }
        public CurveFloat Curve { get { return this[nameof(Curve)].As<CurveFloat>(); } set { this["Curve"] = value; } }
    }
    public class NodeAndChannelMappings : Interface
    {
        public NodeAndChannelMappings(nint addr) : base(addr) { }
    }
    public class MovieSceneNodeGroup : Object
    {
        public MovieSceneNodeGroup(nint addr) : base(addr) { }
    }
    public class MovieSceneNodeGroupCollection : Object
    {
        public MovieSceneNodeGroupCollection(nint addr) : base(addr) { }
    }
    public class MovieScene : MovieSceneSignedObject
    {
        public MovieScene(nint addr) : base(addr) { }
        public Array<MovieSceneSpawnable> Spawnables { get { return new Array<MovieSceneSpawnable>(this[nameof(Spawnables)].Address); } }
        public Array<MovieScenePossessable> Possessables { get { return new Array<MovieScenePossessable>(this[nameof(Possessables)].Address); } }
        public Array<MovieSceneBinding> ObjectBindings { get { return new Array<MovieSceneBinding>(this[nameof(ObjectBindings)].Address); } }
        public Object BindingGroups { get { return this[nameof(BindingGroups)]; } set { this[nameof(BindingGroups)] = value; } }
        public Array<MovieSceneTrack> MasterTracks { get { return new Array<MovieSceneTrack>(this[nameof(MasterTracks)].Address); } }
        public MovieSceneTrack CameraCutTrack { get { return this[nameof(CameraCutTrack)].As<MovieSceneTrack>(); } set { this["CameraCutTrack"] = value; } }
        public MovieSceneFrameRange SelectionRange { get { return this[nameof(SelectionRange)].As<MovieSceneFrameRange>(); } set { this["SelectionRange"] = value; } }
        public MovieSceneFrameRange PlaybackRange { get { return this[nameof(PlaybackRange)].As<MovieSceneFrameRange>(); } set { this["PlaybackRange"] = value; } }
        public FrameRate TickResolution { get { return this[nameof(TickResolution)].As<FrameRate>(); } set { this["TickResolution"] = value; } }
        public FrameRate DisplayRate { get { return this[nameof(DisplayRate)].As<FrameRate>(); } set { this["DisplayRate"] = value; } }
        public EMovieSceneEvaluationType EvaluationType { get { return (EMovieSceneEvaluationType)this[nameof(EvaluationType)].GetValue<int>(); } set { this[nameof(EvaluationType)].SetValue<int>((int)value); } }
        public EUpdateClockSource ClockSource { get { return (EUpdateClockSource)this[nameof(ClockSource)].GetValue<int>(); } set { this[nameof(ClockSource)].SetValue<int>((int)value); } }
        public SoftObjectPath CustomClockSourcePath { get { return this[nameof(CustomClockSourcePath)].As<SoftObjectPath>(); } set { this["CustomClockSourcePath"] = value; } }
        public Array<MovieSceneMarkedFrame> MarkedFrames { get { return new Array<MovieSceneMarkedFrame>(this[nameof(MarkedFrames)].Address); } }
    }
    public class MovieSceneBindingOverrides : Object
    {
        public MovieSceneBindingOverrides(nint addr) : base(addr) { }
        public Array<MovieSceneBindingOverrideData> BindingData { get { return new Array<MovieSceneBindingOverrideData>(this[nameof(BindingData)].Address); } }
    }
    public class MovieSceneFolder : Object
    {
        public MovieSceneFolder(nint addr) : base(addr) { }
        public Object FolderName { get { return this[nameof(FolderName)]; } set { this[nameof(FolderName)] = value; } }
        public Array<MovieSceneFolder> ChildFolders { get { return new Array<MovieSceneFolder>(this[nameof(ChildFolders)].Address); } }
        public Array<MovieSceneTrack> ChildMasterTracks { get { return new Array<MovieSceneTrack>(this[nameof(ChildMasterTracks)].Address); } }
        public Array<Object> ChildObjectBindingStrings { get { return new Array<Object>(this[nameof(ChildObjectBindingStrings)].Address); } }
    }
    public class MovieSceneSequenceTickManager : Object
    {
        public MovieSceneSequenceTickManager(nint addr) : base(addr) { }
    }
    public class MovieSceneBoolSection : MovieSceneSection
    {
        public MovieSceneBoolSection(nint addr) : base(addr) { }
        public bool DefaultValue { get { return this[nameof(DefaultValue)].Flag; } set { this[nameof(DefaultValue)].Flag = value; } }
        public MovieSceneBoolChannel BoolCurve { get { return this[nameof(BoolCurve)].As<MovieSceneBoolChannel>(); } set { this["BoolCurve"] = value; } }
    }
    public class MovieSceneSpawnSection : MovieSceneBoolSection
    {
        public MovieSceneSpawnSection(nint addr) : base(addr) { }
    }
    public class TestMovieSceneTrack : MovieSceneTrack
    {
        public TestMovieSceneTrack(nint addr) : base(addr) { }
        public bool bHighPassFilter { get { return this[nameof(bHighPassFilter)].Flag; } set { this[nameof(bHighPassFilter)].Flag = value; } }
        public Array<MovieSceneSection> SectionArray { get { return new Array<MovieSceneSection>(this[nameof(SectionArray)].Address); } }
    }
    public class TestMovieSceneSection : MovieSceneSection
    {
        public TestMovieSceneSection(nint addr) : base(addr) { }
    }
    public class TestMovieSceneSequence : MovieSceneSequence
    {
        public TestMovieSceneSequence(nint addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
    }
    public class TestMovieSceneSubTrack : MovieSceneSubTrack
    {
        public TestMovieSceneSubTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> SectionArray { get { return new Array<MovieSceneSection>(this[nameof(SectionArray)].Address); } }
    }
    public class TestMovieSceneSubSection : MovieSceneSubSection
    {
        public TestMovieSceneSubSection(nint addr) : base(addr) { }
    }
    public class TestMovieSceneEvalHookTrack : MovieSceneTrack
    {
        public TestMovieSceneEvalHookTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> SectionArray { get { return new Array<MovieSceneSection>(this[nameof(SectionArray)].Address); } }
    }
    public class TestMovieSceneEvalHookSection : MovieSceneHookSection
    {
        public TestMovieSceneEvalHookSection(nint addr) : base(addr) { }
    }
    public class MovieSceneSpawnTrack : MovieSceneTrack
    {
        public MovieSceneSpawnTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
        public Guid ObjectGuid { get { return this[nameof(ObjectGuid)].As<Guid>(); } set { this["ObjectGuid"] = value; } }
    }
    public enum EMovieSceneKeyInterpolation : int
    {
        Auto = 0,
        User = 1,
        Break = 2,
        Linear = 3,
        Constant = 4,
        EMovieSceneKeyInterpolation_MAX = 5,
    }
    public enum EMovieSceneCompletionMode : int
    {
        KeepState = 0,
        RestoreState = 1,
        ProjectDefault = 2,
        EMovieSceneCompletionMode_MAX = 3,
    }
    public enum EMovieScenePlayerStatus : int
    {
        Stopped = 0,
        Playing = 1,
        Scrubbing = 2,
        Jumping = 3,
        Stepping = 4,
        Paused = 5,
        MAX = 6,
    }
    public enum EMovieSceneEvaluationType : int
    {
        FrameLocked = 0,
        WithSubFrames = 1,
        EMovieSceneEvaluationType_MAX = 2,
    }
    public enum EUpdateClockSource : int
    {
        Tick = 0,
        Platform = 1,
        Audio = 2,
        RelativeTimecode = 3,
        Timecode = 4,
        PlayEveryFrame = 5,
        Custom = 6,
        EUpdateClockSource_MAX = 7,
    }
    public enum EMovieSceneSequenceFlags : int
    {
        None = 0,
        Volatile = 1,
        BlockingEvaluation = 2,
        InheritedFlags = 1,
        EMovieSceneSequenceFlags_MAX = 3,
    }
    public enum EMovieSceneServerClientMask : int
    {
        None = 0,
        Server = 1,
        Client = 2,
        All = 3,
        EMovieSceneServerClientMask_MAX = 4,
    }
    public enum ESectionEvaluationFlags : int
    {
        None = 0,
        PreRoll = 1,
        PostRoll = 2,
        ESectionEvaluationFlags_MAX = 3,
    }
    public enum EMovieSceneBlendType : int
    {
        Invalid = 0,
        Absolute = 1,
        Additive = 2,
        Relative = 4,
        AdditiveFromBase = 8,
        EMovieSceneBlendType_MAX = 9,
    }
    public enum EEvaluationMethod : int
    {
        Static = 0,
        Swept = 1,
        EEvaluationMethod_MAX = 2,
    }
    public enum EMovieSceneBuiltInEasing : int
    {
        Linear = 0,
        SinIn = 1,
        SinOut = 2,
        SinInOut = 3,
        QuadIn = 4,
        QuadOut = 5,
        QuadInOut = 6,
        CubicIn = 7,
        CubicOut = 8,
        CubicInOut = 9,
        QuartIn = 10,
        QuartOut = 11,
        QuartInOut = 12,
        QuintIn = 13,
        QuintOut = 14,
        QuintInOut = 15,
        ExpoIn = 16,
        ExpoOut = 17,
        ExpoInOut = 18,
        CircIn = 19,
        CircOut = 20,
        CircInOut = 21,
        EMovieSceneBuiltInEasing_MAX = 22,
    }
    public enum EMovieSceneObjectBindingSpace : int
    {
        Local = 0,
        Root = 1,
        Unused = 2,
        EMovieSceneObjectBindingSpace_MAX = 3,
    }
    public enum EUpdatePositionMethod : int
    {
        Play = 0,
        Jump = 1,
        Scrub = 2,
        EUpdatePositionMethod_MAX = 3,
    }
    public enum EMovieScenePositionType : int
    {
        Frame = 0,
        Time = 1,
        MarkedFrame = 2,
        EMovieScenePositionType_MAX = 3,
    }
    public enum ESpawnOwnership : int
    {
        InnerSequence = 0,
        MasterSequence = 1,
        External = 2,
        ESpawnOwnership_MAX = 3,
    }
    public class MovieSceneEvalTemplateBase : Object
    {
        public MovieSceneEvalTemplateBase(nint addr) : base(addr) { }
    }
    public class MovieSceneEvalTemplate : MovieSceneEvalTemplateBase
    {
        public MovieSceneEvalTemplate(nint addr) : base(addr) { }
        public EMovieSceneCompletionMode CompletionMode { get { return (EMovieSceneCompletionMode)this[nameof(CompletionMode)].GetValue<int>(); } set { this[nameof(CompletionMode)].SetValue<int>((int)value); } }
        public Object SourceSectionPtr { get { return this[nameof(SourceSectionPtr)]; } set { this[nameof(SourceSectionPtr)] = value; } }
    }
    public class MovieSceneTrackImplementation : MovieSceneEvalTemplateBase
    {
        public MovieSceneTrackImplementation(nint addr) : base(addr) { }
    }
    public class MovieSceneChannel : Object
    {
        public MovieSceneChannel(nint addr) : base(addr) { }
    }
    public class MovieSceneBoolChannel : MovieSceneChannel
    {
        public MovieSceneBoolChannel(nint addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public bool DefaultValue { get { return this[nameof(DefaultValue)].Flag; } set { this[nameof(DefaultValue)].Flag = value; } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
        public Array<bool> Values { get { return new Array<bool>(this[nameof(Values)].Address); } }
    }
    public class MovieSceneFloatChannel : MovieSceneChannel
    {
        public MovieSceneFloatChannel(nint addr) : base(addr) { }
        public byte PreInfinityExtrap { get { return this[nameof(PreInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PreInfinityExtrap)].SetValue<byte>(value); } }
        public byte PostInfinityExtrap { get { return this[nameof(PostInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PostInfinityExtrap)].SetValue<byte>(value); } }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<MovieSceneFloatValue> Values { get { return new Array<MovieSceneFloatValue>(this[nameof(Values)].Address); } }
        public float DefaultValue { get { return this[nameof(DefaultValue)].GetValue<float>(); } set { this[nameof(DefaultValue)].SetValue<float>(value); } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
        public MovieSceneKeyHandleMap KeyHandles { get { return this[nameof(KeyHandles)].As<MovieSceneKeyHandleMap>(); } set { this["KeyHandles"] = value; } }
        public FrameRate TickResolution { get { return this[nameof(TickResolution)].As<FrameRate>(); } set { this["TickResolution"] = value; } }
    }
    public class MovieSceneKeyHandleMap : KeyHandleLookupTable
    {
        public MovieSceneKeyHandleMap(nint addr) : base(addr) { }
    }
    public class MovieSceneFloatValue : Object
    {
        public MovieSceneFloatValue(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public MovieSceneTangentData Tangent { get { return this[nameof(Tangent)].As<MovieSceneTangentData>(); } set { this["Tangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
        public byte TangentMode { get { return this[nameof(TangentMode)].GetValue<byte>(); } set { this[nameof(TangentMode)].SetValue<byte>(value); } }
        public byte PaddingByte { get { return this[nameof(PaddingByte)].GetValue<byte>(); } set { this[nameof(PaddingByte)].SetValue<byte>(value); } }
    }
    public class MovieSceneTangentData : Object
    {
        public MovieSceneTangentData(nint addr) : base(addr) { }
        public float ArriveTangent { get { return this[nameof(ArriveTangent)].GetValue<float>(); } set { this[nameof(ArriveTangent)].SetValue<float>(value); } }
        public float LeaveTangent { get { return this[nameof(LeaveTangent)].GetValue<float>(); } set { this[nameof(LeaveTangent)].SetValue<float>(value); } }
        public float ArriveTangentWeight { get { return this[nameof(ArriveTangentWeight)].GetValue<float>(); } set { this[nameof(ArriveTangentWeight)].SetValue<float>(value); } }
        public float LeaveTangentWeight { get { return this[nameof(LeaveTangentWeight)].GetValue<float>(); } set { this[nameof(LeaveTangentWeight)].SetValue<float>(value); } }
        public byte TangentWeightMode { get { return this[nameof(TangentWeightMode)].GetValue<byte>(); } set { this[nameof(TangentWeightMode)].SetValue<byte>(value); } }
    }
    public class MovieSceneIntegerChannel : MovieSceneChannel
    {
        public MovieSceneIntegerChannel(nint addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public int DefaultValue { get { return this[nameof(DefaultValue)].GetValue<int>(); } set { this[nameof(DefaultValue)].SetValue<int>(value); } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
        public Array<int> Values { get { return new Array<int>(this[nameof(Values)].Address); } }
    }
    public class MovieScenePropertySectionTemplate : MovieSceneEvalTemplate
    {
        public MovieScenePropertySectionTemplate(nint addr) : base(addr) { }
        public MovieScenePropertySectionData PropertyData { get { return this[nameof(PropertyData)].As<MovieScenePropertySectionData>(); } set { this["PropertyData"] = value; } }
    }
    public class MovieScenePropertySectionData : Object
    {
        public MovieScenePropertySectionData(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public Object PropertyPath { get { return this[nameof(PropertyPath)]; } set { this[nameof(PropertyPath)] = value; } }
    }
    public class MovieSceneByteChannel : MovieSceneChannel
    {
        public MovieSceneByteChannel(nint addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public byte DefaultValue { get { return this[nameof(DefaultValue)].GetValue<byte>(); } set { this[nameof(DefaultValue)].SetValue<byte>(value); } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
        public Array<byte> Values { get { return new Array<byte>(this[nameof(Values)].Address); } }
        public Enum Enum { get { return this[nameof(Enum)].As<Enum>(); } set { this["Enum"] = value; } }
    }
    public class MovieSceneSequenceInstanceData : Object
    {
        public MovieSceneSequenceInstanceData(nint addr) : base(addr) { }
    }
    public class MovieSceneEvaluationOperand : Object
    {
        public MovieSceneEvaluationOperand(nint addr) : base(addr) { }
        public Guid ObjectBindingID { get { return this[nameof(ObjectBindingID)].As<Guid>(); } set { this["ObjectBindingID"] = value; } }
        public MovieSceneSequenceID SequenceID { get { return this[nameof(SequenceID)].As<MovieSceneSequenceID>(); } set { this["SequenceID"] = value; } }
    }
    public class MovieSceneSequenceID : Object
    {
        public MovieSceneSequenceID(nint addr) : base(addr) { }
        public uint Value { get { return this[nameof(Value)].GetValue<uint>(); } set { this[nameof(Value)].SetValue<uint>(value); } }
    }
    public class MovieScenePropertyBinding : Object
    {
        public MovieScenePropertyBinding(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public Object PropertyPath { get { return this[nameof(PropertyPath)]; } set { this[nameof(PropertyPath)] = value; } }
        public bool bCanUseClassLookup { get { return this[nameof(bCanUseClassLookup)].Flag; } set { this[nameof(bCanUseClassLookup)].Flag = value; } }
    }
    public class ActorForWorldTransforms : Object
    {
        public ActorForWorldTransforms(nint addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Object Component { get { return this[nameof(Component)]; } set { this[nameof(Component)] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class MovieSceneDeterminismData : Object
    {
        public MovieSceneDeterminismData(nint addr) : base(addr) { }
        public Array<FrameTime> Fences { get { return new Array<FrameTime>(this[nameof(Fences)].Address); } }
        public bool bParentSequenceRequiresLowerFence { get { return this[nameof(bParentSequenceRequiresLowerFence)].Flag; } set { this[nameof(bParentSequenceRequiresLowerFence)].Flag = value; } }
        public bool bParentSequenceRequiresUpperFence { get { return this[nameof(bParentSequenceRequiresUpperFence)].Flag; } set { this[nameof(bParentSequenceRequiresUpperFence)].Flag = value; } }
    }
    public class MovieSceneEmptyStruct : Object
    {
        public MovieSceneEmptyStruct(nint addr) : base(addr) { }
    }
    public class MovieSceneEvaluationKey : Object
    {
        public MovieSceneEvaluationKey(nint addr) : base(addr) { }
        public MovieSceneSequenceID SequenceID { get { return this[nameof(SequenceID)].As<MovieSceneSequenceID>(); } set { this["SequenceID"] = value; } }
        public MovieSceneTrackIdentifier TrackIdentifier { get { return this[nameof(TrackIdentifier)].As<MovieSceneTrackIdentifier>(); } set { this["TrackIdentifier"] = value; } }
        public uint SectionIndex { get { return this[nameof(SectionIndex)].GetValue<uint>(); } set { this[nameof(SectionIndex)].SetValue<uint>(value); } }
    }
    public class MovieSceneTrackIdentifier : Object
    {
        public MovieSceneTrackIdentifier(nint addr) : base(addr) { }
        public uint Value { get { return this[nameof(Value)].GetValue<uint>(); } set { this[nameof(Value)].SetValue<uint>(value); } }
    }
    public class MovieSceneKeyStruct : Object
    {
        public MovieSceneKeyStruct(nint addr) : base(addr) { }
    }
    public class GeneratedMovieSceneKeyStruct : Object
    {
        public GeneratedMovieSceneKeyStruct(nint addr) : base(addr) { }
    }
    public class MovieSceneKeyTimeStruct : MovieSceneKeyStruct
    {
        public MovieSceneKeyTimeStruct(nint addr) : base(addr) { }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieSceneSectionParameters : Object
    {
        public MovieSceneSectionParameters(nint addr) : base(addr) { }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public bool bCanLoop { get { return this[nameof(bCanLoop)].Flag; } set { this[nameof(bCanLoop)].Flag = value; } }
        public FrameNumber EndFrameOffset { get { return this[nameof(EndFrameOffset)].As<FrameNumber>(); } set { this["EndFrameOffset"] = value; } }
        public FrameNumber FirstLoopStartFrameOffset { get { return this[nameof(FirstLoopStartFrameOffset)].As<FrameNumber>(); } set { this["FirstLoopStartFrameOffset"] = value; } }
        public float TimeScale { get { return this[nameof(TimeScale)].GetValue<float>(); } set { this[nameof(TimeScale)].SetValue<float>(value); } }
        public int HierarchicalBias { get { return this[nameof(HierarchicalBias)].GetValue<int>(); } set { this[nameof(HierarchicalBias)].SetValue<int>(value); } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float PrerollTime { get { return this[nameof(PrerollTime)].GetValue<float>(); } set { this[nameof(PrerollTime)].SetValue<float>(value); } }
        public float PostrollTime { get { return this[nameof(PostrollTime)].GetValue<float>(); } set { this[nameof(PostrollTime)].SetValue<float>(value); } }
    }
    public class MovieSceneSegmentIdentifier : Object
    {
        public MovieSceneSegmentIdentifier(nint addr) : base(addr) { }
        public int IdentifierIndex { get { return this[nameof(IdentifierIndex)].GetValue<int>(); } set { this[nameof(IdentifierIndex)].SetValue<int>(value); } }
    }
    public class SectionEvaluationData : Object
    {
        public SectionEvaluationData(nint addr) : base(addr) { }
        public int ImplIndex { get { return this[nameof(ImplIndex)].GetValue<int>(); } set { this[nameof(ImplIndex)].SetValue<int>(value); } }
        public FrameNumber ForcedTime { get { return this[nameof(ForcedTime)].As<FrameNumber>(); } set { this["ForcedTime"] = value; } }
        public ESectionEvaluationFlags Flags { get { return (ESectionEvaluationFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
    }
    public class MovieSceneSegment : Object
    {
        public MovieSceneSegment(nint addr) : base(addr) { }
    }
    public class MovieSceneSequenceLoopCount : Object
    {
        public MovieSceneSequenceLoopCount(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class MovieSceneSequencePlaybackSettings : Object
    {
        public MovieSceneSequencePlaybackSettings(nint addr) : base(addr) { }
        public bool bAutoPlay { get { return this[nameof(bAutoPlay)].Flag; } set { this[nameof(bAutoPlay)].Flag = value; } }
        public MovieSceneSequenceLoopCount LoopCount { get { return this[nameof(LoopCount)].As<MovieSceneSequenceLoopCount>(); } set { this["LoopCount"] = value; } }
        public MovieSceneSequenceTickInterval TickInterval { get { return this[nameof(TickInterval)].As<MovieSceneSequenceTickInterval>(); } set { this["TickInterval"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public bool bRandomStartTime { get { return this[nameof(bRandomStartTime)].Flag; } set { this[nameof(bRandomStartTime)].Flag = value; } }
        public bool bRestoreState { get { return this[nameof(bRestoreState)].Flag; } set { this[nameof(bRestoreState)].Flag = value; } }
        public bool bDisableMovementInput { get { return this[nameof(bDisableMovementInput)].Flag; } set { this[nameof(bDisableMovementInput)].Flag = value; } }
        public bool bDisableLookAtInput { get { return this[nameof(bDisableLookAtInput)].Flag; } set { this[nameof(bDisableLookAtInput)].Flag = value; } }
        public bool bHidePlayer { get { return this[nameof(bHidePlayer)].Flag; } set { this[nameof(bHidePlayer)].Flag = value; } }
        public bool bHideHud { get { return this[nameof(bHideHud)].Flag; } set { this[nameof(bHideHud)].Flag = value; } }
        public bool bDisableCameraCuts { get { return this[nameof(bDisableCameraCuts)].Flag; } set { this[nameof(bDisableCameraCuts)].Flag = value; } }
        public bool bPauseAtEnd { get { return this[nameof(bPauseAtEnd)].Flag; } set { this[nameof(bPauseAtEnd)].Flag = value; } }
        public bool bInheritTickIntervalFromOwner { get { return this[nameof(bInheritTickIntervalFromOwner)].Flag; } set { this[nameof(bInheritTickIntervalFromOwner)].Flag = value; } }
    }
    public class MovieSceneSequenceTickInterval : Object
    {
        public MovieSceneSequenceTickInterval(nint addr) : base(addr) { }
        public float TickIntervalSeconds { get { return this[nameof(TickIntervalSeconds)].GetValue<float>(); } set { this[nameof(TickIntervalSeconds)].SetValue<float>(value); } }
        public float EvaluationBudgetMicroseconds { get { return this[nameof(EvaluationBudgetMicroseconds)].GetValue<float>(); } set { this[nameof(EvaluationBudgetMicroseconds)].SetValue<float>(value); } }
        public bool bTickWhenPaused { get { return this[nameof(bTickWhenPaused)].Flag; } set { this[nameof(bTickWhenPaused)].Flag = value; } }
        public bool bAllowRounding { get { return this[nameof(bAllowRounding)].Flag; } set { this[nameof(bAllowRounding)].Flag = value; } }
    }
    public class MovieSceneTimeTransform : Object
    {
        public MovieSceneTimeTransform(nint addr) : base(addr) { }
        public float TimeScale { get { return this[nameof(TimeScale)].GetValue<float>(); } set { this[nameof(TimeScale)].SetValue<float>(value); } }
        public FrameTime Offset { get { return this[nameof(Offset)].As<FrameTime>(); } set { this["Offset"] = value; } }
    }
    public class MovieSceneAudioTriggerChannel : MovieSceneChannel
    {
        public MovieSceneAudioTriggerChannel(nint addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<bool> Values { get { return new Array<bool>(this[nameof(Values)].Address); } }
    }
    public class MovieSceneDoubleValue : Object
    {
        public MovieSceneDoubleValue(nint addr) : base(addr) { }
        public double Value { get { return this[nameof(Value)].GetValue<double>(); } set { this[nameof(Value)].SetValue<double>(value); } }
        public MovieSceneTangentData Tangent { get { return this[nameof(Tangent)].As<MovieSceneTangentData>(); } set { this["Tangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
        public byte TangentMode { get { return this[nameof(TangentMode)].GetValue<byte>(); } set { this[nameof(TangentMode)].SetValue<byte>(value); } }
        public byte PaddingByte { get { return this[nameof(PaddingByte)].GetValue<byte>(); } set { this[nameof(PaddingByte)].SetValue<byte>(value); } }
    }
    public class MovieSceneDoubleChannel : MovieSceneChannel
    {
        public MovieSceneDoubleChannel(nint addr) : base(addr) { }
        public byte PreInfinityExtrap { get { return this[nameof(PreInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PreInfinityExtrap)].SetValue<byte>(value); } }
        public byte PostInfinityExtrap { get { return this[nameof(PostInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PostInfinityExtrap)].SetValue<byte>(value); } }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<MovieSceneDoubleValue> Values { get { return new Array<MovieSceneDoubleValue>(this[nameof(Values)].Address); } }
        public double DefaultValue { get { return this[nameof(DefaultValue)].GetValue<double>(); } set { this[nameof(DefaultValue)].SetValue<double>(value); } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
        public MovieSceneKeyHandleMap KeyHandles { get { return this[nameof(KeyHandles)].As<MovieSceneKeyHandleMap>(); } set { this["KeyHandles"] = value; } }
        public FrameRate TickResolution { get { return this[nameof(TickResolution)].As<FrameRate>(); } set { this["TickResolution"] = value; } }
    }
    public class MovieSceneObjectPathChannelKeyValue : Object
    {
        public MovieSceneObjectPathChannelKeyValue(nint addr) : base(addr) { }
        public Object SoftPtr { get { return this[nameof(SoftPtr)]; } set { this[nameof(SoftPtr)] = value; } }
        public Object HardPtr { get { return this[nameof(HardPtr)].As<Object>(); } set { this["HardPtr"] = value; } }
    }
    public class MovieSceneObjectPathChannel : MovieSceneChannel
    {
        public MovieSceneObjectPathChannel(nint addr) : base(addr) { }
        public Object PropertyClass { get { return this[nameof(PropertyClass)].As<Object>(); } set { this["PropertyClass"] = value; } } // ClassPtrProperty
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<MovieSceneObjectPathChannelKeyValue> Values { get { return new Array<MovieSceneObjectPathChannelKeyValue>(this[nameof(Values)].Address); } }
        public MovieSceneObjectPathChannelKeyValue DefaultValue { get { return this[nameof(DefaultValue)].As<MovieSceneObjectPathChannelKeyValue>(); } set { this["DefaultValue"] = value; } }
    }
    public class MovieSceneSequenceCompilerMaskStruct : Object
    {
        public MovieSceneSequenceCompilerMaskStruct(nint addr) : base(addr) { }
        public bool bHierarchy { get { return this[nameof(bHierarchy)].Flag; } set { this[nameof(bHierarchy)].Flag = value; } }
        public bool bEvaluationTemplate { get { return this[nameof(bEvaluationTemplate)].Flag; } set { this[nameof(bEvaluationTemplate)].Flag = value; } }
        public bool bEvaluationTemplateField { get { return this[nameof(bEvaluationTemplateField)].Flag; } set { this[nameof(bEvaluationTemplateField)].Flag = value; } }
        public bool bEntityComponentField { get { return this[nameof(bEntityComponentField)].Flag; } set { this[nameof(bEntityComponentField)].Flag = value; } }
    }
    public class MovieSceneCompiledSequenceFlagStruct : Object
    {
        public MovieSceneCompiledSequenceFlagStruct(nint addr) : base(addr) { }
        public bool bParentSequenceRequiresLowerFence { get { return this[nameof(bParentSequenceRequiresLowerFence)].Flag; } set { this[nameof(bParentSequenceRequiresLowerFence)].Flag = value; } }
        public bool bParentSequenceRequiresUpperFence { get { return this[nameof(bParentSequenceRequiresUpperFence)].Flag; } set { this[nameof(bParentSequenceRequiresUpperFence)].Flag = value; } }
    }
    public class EasingComponentData : Object
    {
        public EasingComponentData(nint addr) : base(addr) { }
        public MovieSceneSection Section { get { return this[nameof(Section)].As<MovieSceneSection>(); } set { this["Section"] = value; } }
    }
    public class MovieSceneTrackInstanceComponent : Object
    {
        public MovieSceneTrackInstanceComponent(nint addr) : base(addr) { }
        public MovieSceneSection Owner { get { return this[nameof(Owner)].As<MovieSceneSection>(); } set { this["Owner"] = value; } }
        public Object TrackInstanceClass { get { return this[nameof(TrackInstanceClass)]; } set { this[nameof(TrackInstanceClass)] = value; } }
    }
    public class MovieSceneEvaluationHookComponent : Object
    {
        public MovieSceneEvaluationHookComponent(nint addr) : base(addr) { }
        public Object Interface { get { return this[nameof(Interface)]; } set { this[nameof(Interface)] = value; } }
    }
    public class TrackInstanceInputComponent : Object
    {
        public TrackInstanceInputComponent(nint addr) : base(addr) { }
        public MovieSceneSection Section { get { return this[nameof(Section)].As<MovieSceneSection>(); } set { this["Section"] = value; } }
        public int OutputIndex { get { return this[nameof(OutputIndex)].GetValue<int>(); } set { this[nameof(OutputIndex)].SetValue<int>(value); } }
    }
    public class MovieSceneEntitySystemGraphNode : Object
    {
        public MovieSceneEntitySystemGraphNode(nint addr) : base(addr) { }
        public MovieSceneEntitySystem System { get { return this[nameof(System)].As<MovieSceneEntitySystem>(); } set { this["System"] = value; } }
    }
    public class MovieSceneEntitySystemGraphNodes : Object
    {
        public MovieSceneEntitySystemGraphNodes(nint addr) : base(addr) { }
    }
    public class MovieSceneEntitySystemGraph : Object
    {
        public MovieSceneEntitySystemGraph(nint addr) : base(addr) { }
        public MovieSceneEntitySystemGraphNodes Nodes { get { return this[nameof(Nodes)].As<MovieSceneEntitySystemGraphNodes>(); } set { this["Nodes"] = value; } }
    }
    public class MovieSceneEvaluationHookEvent : Object
    {
        public MovieSceneEvaluationHookEvent(nint addr) : base(addr) { }
        public MovieSceneEvaluationHookComponent Hook { get { return this[nameof(Hook)].As<MovieSceneEvaluationHookComponent>(); } set { this["Hook"] = value; } }
    }
    public class MovieSceneEvaluationHookEventContainer : Object
    {
        public MovieSceneEvaluationHookEventContainer(nint addr) : base(addr) { }
        public Array<MovieSceneEvaluationHookEvent> Events { get { return new Array<MovieSceneEvaluationHookEvent>(this[nameof(Events)].Address); } }
    }
    public class MovieSceneEvaluationInstanceKey : Object
    {
        public MovieSceneEvaluationInstanceKey(nint addr) : base(addr) { }
    }
    public class MovieSceneTrackInstanceInput : Object
    {
        public MovieSceneTrackInstanceInput(nint addr) : base(addr) { }
        public MovieSceneSection Section { get { return this[nameof(Section)].As<MovieSceneSection>(); } set { this["Section"] = value; } }
    }
    public class MovieSceneTrackInstanceEntry : Object
    {
        public MovieSceneTrackInstanceEntry(nint addr) : base(addr) { }
        public Object BoundObject { get { return this[nameof(BoundObject)].As<Object>(); } set { this["BoundObject"] = value; } }
        public MovieSceneTrackInstance TrackInstance { get { return this[nameof(TrackInstance)].As<MovieSceneTrackInstance>(); } set { this["TrackInstance"] = value; } }
    }
    public class OptionalMovieSceneBlendType : Object
    {
        public OptionalMovieSceneBlendType(nint addr) : base(addr) { }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
        public bool bIsValid { get { return this[nameof(bIsValid)].Flag; } set { this[nameof(bIsValid)].Flag = value; } }
    }
    public class MovieSceneEvalTemplatePtr : Object
    {
        public MovieSceneEvalTemplatePtr(nint addr) : base(addr) { }
    }
    public class MovieSceneEvaluationFieldEntityKey : Object
    {
        public MovieSceneEvaluationFieldEntityKey(nint addr) : base(addr) { }
        public Object EntityOwner { get { return this[nameof(EntityOwner)]; } set { this[nameof(EntityOwner)] = value; } }
        public uint EntityID { get { return this[nameof(EntityID)].GetValue<uint>(); } set { this[nameof(EntityID)].SetValue<uint>(value); } }
    }
    public class MovieSceneEvaluationFieldEntity : Object
    {
        public MovieSceneEvaluationFieldEntity(nint addr) : base(addr) { }
        public MovieSceneEvaluationFieldEntityKey Key { get { return this[nameof(Key)].As<MovieSceneEvaluationFieldEntityKey>(); } set { this["Key"] = value; } }
        public int SharedMetaDataIndex { get { return this[nameof(SharedMetaDataIndex)].GetValue<int>(); } set { this[nameof(SharedMetaDataIndex)].SetValue<int>(value); } }
    }
    public class MovieSceneEvaluationFieldSharedEntityMetaData : Object
    {
        public MovieSceneEvaluationFieldSharedEntityMetaData(nint addr) : base(addr) { }
        public Guid ObjectBindingID { get { return this[nameof(ObjectBindingID)].As<Guid>(); } set { this["ObjectBindingID"] = value; } }
    }
    public class MovieSceneEvaluationFieldEntityMetaData : Object
    {
        public MovieSceneEvaluationFieldEntityMetaData(nint addr) : base(addr) { }
        public Object OverrideBoundPropertyPath { get { return this[nameof(OverrideBoundPropertyPath)]; } set { this[nameof(OverrideBoundPropertyPath)] = value; } }
        public FrameNumber ForcedTime { get { return this[nameof(ForcedTime)].As<FrameNumber>(); } set { this["ForcedTime"] = value; } }
        public ESectionEvaluationFlags Flags { get { return (ESectionEvaluationFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
        public bool bEvaluateInSequencePreRoll { get { return this[nameof(bEvaluateInSequencePreRoll)].Flag; } set { this[nameof(bEvaluateInSequencePreRoll)].Flag = value; } }
        public bool bEvaluateInSequencePostRoll { get { return this[nameof(bEvaluateInSequencePostRoll)].Flag; } set { this[nameof(bEvaluateInSequencePostRoll)].Flag = value; } }
    }
    public class MovieSceneEvaluationFieldEntityTree : Object
    {
        public MovieSceneEvaluationFieldEntityTree(nint addr) : base(addr) { }
    }
    public class MovieSceneEntityComponentField : Object
    {
        public MovieSceneEntityComponentField(nint addr) : base(addr) { }
        public MovieSceneEvaluationFieldEntityTree PersistentEntityTree { get { return this[nameof(PersistentEntityTree)].As<MovieSceneEvaluationFieldEntityTree>(); } set { this["PersistentEntityTree"] = value; } }
        public MovieSceneEvaluationFieldEntityTree OneShotEntityTree { get { return this[nameof(OneShotEntityTree)].As<MovieSceneEvaluationFieldEntityTree>(); } set { this["OneShotEntityTree"] = value; } }
        public Array<MovieSceneEvaluationFieldEntity> Entities { get { return new Array<MovieSceneEvaluationFieldEntity>(this[nameof(Entities)].Address); } }
        public Array<MovieSceneEvaluationFieldEntityMetaData> EntityMetaData { get { return new Array<MovieSceneEvaluationFieldEntityMetaData>(this[nameof(EntityMetaData)].Address); } }
        public Array<MovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData { get { return new Array<MovieSceneEvaluationFieldSharedEntityMetaData>(this[nameof(SharedMetaData)].Address); } }
    }
    public class MovieSceneEvaluationFieldTrackPtr : Object
    {
        public MovieSceneEvaluationFieldTrackPtr(nint addr) : base(addr) { }
        public MovieSceneSequenceID SequenceID { get { return this[nameof(SequenceID)].As<MovieSceneSequenceID>(); } set { this["SequenceID"] = value; } }
        public MovieSceneTrackIdentifier TrackIdentifier { get { return this[nameof(TrackIdentifier)].As<MovieSceneTrackIdentifier>(); } set { this["TrackIdentifier"] = value; } }
    }
    public class MovieSceneEvaluationFieldSegmentPtr : MovieSceneEvaluationFieldTrackPtr
    {
        public MovieSceneEvaluationFieldSegmentPtr(nint addr) : base(addr) { }
        public MovieSceneSegmentIdentifier SegmentID { get { return this[nameof(SegmentID)].As<MovieSceneSegmentIdentifier>(); } set { this["SegmentID"] = value; } }
    }
    public class MovieSceneFieldEntry_EvaluationTrack : Object
    {
        public MovieSceneFieldEntry_EvaluationTrack(nint addr) : base(addr) { }
        public MovieSceneEvaluationFieldTrackPtr TrackPtr { get { return this[nameof(TrackPtr)].As<MovieSceneEvaluationFieldTrackPtr>(); } set { this["TrackPtr"] = value; } }
        public ushort NumChildren { get { return this[nameof(NumChildren)].GetValue<ushort>(); } set { this[nameof(NumChildren)].SetValue<ushort>(value); } }
    }
    public class MovieSceneFieldEntry_ChildTemplate : Object
    {
        public MovieSceneFieldEntry_ChildTemplate(nint addr) : base(addr) { }
        public ushort ChildIndex { get { return this[nameof(ChildIndex)].GetValue<ushort>(); } set { this[nameof(ChildIndex)].SetValue<ushort>(value); } }
        public ESectionEvaluationFlags Flags { get { return (ESectionEvaluationFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
        public FrameNumber ForcedTime { get { return this[nameof(ForcedTime)].As<FrameNumber>(); } set { this["ForcedTime"] = value; } }
    }
    public class MovieSceneEvaluationGroupLUTIndex : Object
    {
        public MovieSceneEvaluationGroupLUTIndex(nint addr) : base(addr) { }
        public int NumInitPtrs { get { return this[nameof(NumInitPtrs)].GetValue<int>(); } set { this[nameof(NumInitPtrs)].SetValue<int>(value); } }
        public int NumEvalPtrs { get { return this[nameof(NumEvalPtrs)].GetValue<int>(); } set { this[nameof(NumEvalPtrs)].SetValue<int>(value); } }
    }
    public class MovieSceneEvaluationGroup : Object
    {
        public MovieSceneEvaluationGroup(nint addr) : base(addr) { }
        public Array<MovieSceneEvaluationGroupLUTIndex> LUTIndices { get { return new Array<MovieSceneEvaluationGroupLUTIndex>(this[nameof(LUTIndices)].Address); } }
        public Array<MovieSceneFieldEntry_EvaluationTrack> TrackLUT { get { return new Array<MovieSceneFieldEntry_EvaluationTrack>(this[nameof(TrackLUT)].Address); } }
        public Array<MovieSceneFieldEntry_ChildTemplate> SectionLUT { get { return new Array<MovieSceneFieldEntry_ChildTemplate>(this[nameof(SectionLUT)].Address); } }
    }
    public class MovieSceneOrderedEvaluationKey : Object
    {
        public MovieSceneOrderedEvaluationKey(nint addr) : base(addr) { }
        public MovieSceneEvaluationKey Key { get { return this[nameof(Key)].As<MovieSceneEvaluationKey>(); } set { this["Key"] = value; } }
        public ushort SetupIndex { get { return this[nameof(SetupIndex)].GetValue<ushort>(); } set { this[nameof(SetupIndex)].SetValue<ushort>(value); } }
        public ushort TearDownIndex { get { return this[nameof(TearDownIndex)].GetValue<ushort>(); } set { this[nameof(TearDownIndex)].SetValue<ushort>(value); } }
    }
    public class MovieSceneEvaluationMetaData : Object
    {
        public MovieSceneEvaluationMetaData(nint addr) : base(addr) { }
        public Array<MovieSceneSequenceID> ActiveSequences { get { return new Array<MovieSceneSequenceID>(this[nameof(ActiveSequences)].Address); } }
        public Array<MovieSceneOrderedEvaluationKey> ActiveEntities { get { return new Array<MovieSceneOrderedEvaluationKey>(this[nameof(ActiveEntities)].Address); } }
    }
    public class MovieSceneEvaluationField : Object
    {
        public MovieSceneEvaluationField(nint addr) : base(addr) { }
        public Array<MovieSceneFrameRange> Ranges { get { return new Array<MovieSceneFrameRange>(this[nameof(Ranges)].Address); } }
        public Array<MovieSceneEvaluationGroup> Groups { get { return new Array<MovieSceneEvaluationGroup>(this[nameof(Groups)].Address); } }
        public Array<MovieSceneEvaluationMetaData> MetaData { get { return new Array<MovieSceneEvaluationMetaData>(this[nameof(MetaData)].Address); } }
    }
    public class MovieSceneFrameRange : Object
    {
        public MovieSceneFrameRange(nint addr) : base(addr) { }
    }
    public class MovieSceneTemplateGenerationLedger : Object
    {
        public MovieSceneTemplateGenerationLedger(nint addr) : base(addr) { }
        public MovieSceneTrackIdentifier LastTrackIdentifier { get { return this[nameof(LastTrackIdentifier)].As<MovieSceneTrackIdentifier>(); } set { this["LastTrackIdentifier"] = value; } }
        public Object TrackSignatureToTrackIdentifier { get { return this[nameof(TrackSignatureToTrackIdentifier)]; } set { this[nameof(TrackSignatureToTrackIdentifier)] = value; } }
        public Object SubSectionRanges { get { return this[nameof(SubSectionRanges)]; } set { this[nameof(SubSectionRanges)] = value; } }
    }
    public class MovieSceneSubSectionData : Object
    {
        public MovieSceneSubSectionData(nint addr) : base(addr) { }
        public Object Section { get { return this[nameof(Section)]; } set { this[nameof(Section)] = value; } }
        public Guid ObjectBindingID { get { return this[nameof(ObjectBindingID)].As<Guid>(); } set { this["ObjectBindingID"] = value; } }
        public ESectionEvaluationFlags Flags { get { return (ESectionEvaluationFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
    }
    public class MovieSceneEvaluationTemplateSerialNumber : Object
    {
        public MovieSceneEvaluationTemplateSerialNumber(nint addr) : base(addr) { }
        public uint Value { get { return this[nameof(Value)].GetValue<uint>(); } set { this[nameof(Value)].SetValue<uint>(value); } }
    }
    public class MovieSceneEvaluationTemplate : Object
    {
        public MovieSceneEvaluationTemplate(nint addr) : base(addr) { }
        public Object Tracks { get { return this[nameof(Tracks)]; } set { this[nameof(Tracks)] = value; } }
        public Guid SequenceSignature { get { return this[nameof(SequenceSignature)].As<Guid>(); } set { this["SequenceSignature"] = value; } }
        public MovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber { get { return this[nameof(TemplateSerialNumber)].As<MovieSceneEvaluationTemplateSerialNumber>(); } set { this["TemplateSerialNumber"] = value; } }
        public MovieSceneTemplateGenerationLedger TemplateLedger { get { return this[nameof(TemplateLedger)].As<MovieSceneTemplateGenerationLedger>(); } set { this["TemplateLedger"] = value; } }
    }
    public class MovieSceneEvaluationTrack : Object
    {
        public MovieSceneEvaluationTrack(nint addr) : base(addr) { }
        public Guid ObjectBindingID { get { return this[nameof(ObjectBindingID)].As<Guid>(); } set { this["ObjectBindingID"] = value; } }
        public ushort EvaluationPriority { get { return this[nameof(EvaluationPriority)].GetValue<ushort>(); } set { this[nameof(EvaluationPriority)].SetValue<ushort>(value); } }
        public EEvaluationMethod EvaluationMethod { get { return (EEvaluationMethod)this[nameof(EvaluationMethod)].GetValue<int>(); } set { this[nameof(EvaluationMethod)].SetValue<int>((int)value); } }
        public Object SourceTrack { get { return this[nameof(SourceTrack)]; } set { this[nameof(SourceTrack)] = value; } }
        public Array<MovieSceneEvalTemplatePtr> ChildTemplates { get { return new Array<MovieSceneEvalTemplatePtr>(this[nameof(ChildTemplates)].Address); } }
        public MovieSceneTrackImplementationPtr TrackTemplate { get { return this[nameof(TrackTemplate)].As<MovieSceneTrackImplementationPtr>(); } set { this["TrackTemplate"] = value; } }
        public Object EvaluationGroup { get { return this[nameof(EvaluationGroup)]; } set { this[nameof(EvaluationGroup)] = value; } }
        public bool bEvaluateInPreroll { get { return this[nameof(bEvaluateInPreroll)].Flag; } set { this[nameof(bEvaluateInPreroll)].Flag = value; } }
        public bool bEvaluateInPostroll { get { return this[nameof(bEvaluateInPostroll)].Flag; } set { this[nameof(bEvaluateInPostroll)].Flag = value; } }
        public bool bTearDownPriority { get { return this[nameof(bTearDownPriority)].Flag; } set { this[nameof(bTearDownPriority)].Flag = value; } }
    }
    public class MovieSceneTrackImplementationPtr : Object
    {
        public MovieSceneTrackImplementationPtr(nint addr) : base(addr) { }
    }
    public class MovieSceneRootEvaluationTemplateInstance : Object
    {
        public MovieSceneRootEvaluationTemplateInstance(nint addr) : base(addr) { }
        public Object WeakRootSequence { get { return this[nameof(WeakRootSequence)]; } set { this[nameof(WeakRootSequence)] = value; } }
        public MovieSceneCompiledDataManager CompiledDataManager { get { return this[nameof(CompiledDataManager)].As<MovieSceneCompiledDataManager>(); } set { this["CompiledDataManager"] = value; } }
        public MovieSceneEntitySystemLinker EntitySystemLinker { get { return this[nameof(EntitySystemLinker)].As<MovieSceneEntitySystemLinker>(); } set { this["EntitySystemLinker"] = value; } }
        public Object DirectorInstances { get { return this[nameof(DirectorInstances)]; } set { this[nameof(DirectorInstances)] = value; } }
    }
    public class MovieSceneSubSequenceData : Object
    {
        public MovieSceneSubSequenceData(nint addr) : base(addr) { }
        public SoftObjectPath Sequence { get { return this[nameof(Sequence)].As<SoftObjectPath>(); } set { this["Sequence"] = value; } }
        public MovieSceneSequenceTransform OuterToInnerTransform { get { return this[nameof(OuterToInnerTransform)].As<MovieSceneSequenceTransform>(); } set { this["OuterToInnerTransform"] = value; } }
        public MovieSceneSequenceTransform RootToSequenceTransform { get { return this[nameof(RootToSequenceTransform)].As<MovieSceneSequenceTransform>(); } set { this["RootToSequenceTransform"] = value; } }
        public FrameRate TickResolution { get { return this[nameof(TickResolution)].As<FrameRate>(); } set { this["TickResolution"] = value; } }
        public MovieSceneSequenceID DeterministicSequenceID { get { return this[nameof(DeterministicSequenceID)].As<MovieSceneSequenceID>(); } set { this["DeterministicSequenceID"] = value; } }
        public MovieSceneFrameRange ParentPlayRange { get { return this[nameof(ParentPlayRange)].As<MovieSceneFrameRange>(); } set { this["ParentPlayRange"] = value; } }
        public FrameNumber ParentStartFrameOffset { get { return this[nameof(ParentStartFrameOffset)].As<FrameNumber>(); } set { this["ParentStartFrameOffset"] = value; } }
        public FrameNumber ParentEndFrameOffset { get { return this[nameof(ParentEndFrameOffset)].As<FrameNumber>(); } set { this["ParentEndFrameOffset"] = value; } }
        public FrameNumber ParentFirstLoopStartFrameOffset { get { return this[nameof(ParentFirstLoopStartFrameOffset)].As<FrameNumber>(); } set { this["ParentFirstLoopStartFrameOffset"] = value; } }
        public bool bCanLoop { get { return this[nameof(bCanLoop)].Flag; } set { this[nameof(bCanLoop)].Flag = value; } }
        public MovieSceneFrameRange PlayRange { get { return this[nameof(PlayRange)].As<MovieSceneFrameRange>(); } set { this["PlayRange"] = value; } }
        public MovieSceneFrameRange FullPlayRange { get { return this[nameof(FullPlayRange)].As<MovieSceneFrameRange>(); } set { this["FullPlayRange"] = value; } }
        public MovieSceneFrameRange UnwarpedPlayRange { get { return this[nameof(UnwarpedPlayRange)].As<MovieSceneFrameRange>(); } set { this["UnwarpedPlayRange"] = value; } }
        public MovieSceneFrameRange PreRollRange { get { return this[nameof(PreRollRange)].As<MovieSceneFrameRange>(); } set { this["PreRollRange"] = value; } }
        public MovieSceneFrameRange PostRollRange { get { return this[nameof(PostRollRange)].As<MovieSceneFrameRange>(); } set { this["PostRollRange"] = value; } }
        public short HierarchicalBias { get { return this[nameof(HierarchicalBias)].GetValue<short>(); } set { this[nameof(HierarchicalBias)].SetValue<short>(value); } }
        public bool bHasHierarchicalEasing { get { return this[nameof(bHasHierarchicalEasing)].Flag; } set { this[nameof(bHasHierarchicalEasing)].Flag = value; } }
        public MovieSceneSequenceInstanceDataPtr InstanceData { get { return this[nameof(InstanceData)].As<MovieSceneSequenceInstanceDataPtr>(); } set { this["InstanceData"] = value; } }
        public Guid SubSectionSignature { get { return this[nameof(SubSectionSignature)].As<Guid>(); } set { this["SubSectionSignature"] = value; } }
    }
    public class MovieSceneSequenceInstanceDataPtr : Object
    {
        public MovieSceneSequenceInstanceDataPtr(nint addr) : base(addr) { }
    }
    public class MovieSceneSequenceTransform : Object
    {
        public MovieSceneSequenceTransform(nint addr) : base(addr) { }
        public MovieSceneTimeTransform LinearTransform { get { return this[nameof(LinearTransform)].As<MovieSceneTimeTransform>(); } set { this["LinearTransform"] = value; } }
        public Array<MovieSceneNestedSequenceTransform> NestedTransforms { get { return new Array<MovieSceneNestedSequenceTransform>(this[nameof(NestedTransforms)].Address); } }
    }
    public class MovieSceneNestedSequenceTransform : Object
    {
        public MovieSceneNestedSequenceTransform(nint addr) : base(addr) { }
        public MovieSceneTimeTransform LinearTransform { get { return this[nameof(LinearTransform)].As<MovieSceneTimeTransform>(); } set { this["LinearTransform"] = value; } }
        public MovieSceneTimeWarping Warping { get { return this[nameof(Warping)].As<MovieSceneTimeWarping>(); } set { this["Warping"] = value; } }
    }
    public class MovieSceneTimeWarping : Object
    {
        public MovieSceneTimeWarping(nint addr) : base(addr) { }
        public FrameNumber Start { get { return this[nameof(Start)].As<FrameNumber>(); } set { this["Start"] = value; } }
        public FrameNumber End { get { return this[nameof(End)].As<FrameNumber>(); } set { this["End"] = value; } }
    }
    public class MovieSceneSequenceHierarchyNode : Object
    {
        public MovieSceneSequenceHierarchyNode(nint addr) : base(addr) { }
        public MovieSceneSequenceID ParentID { get { return this[nameof(ParentID)].As<MovieSceneSequenceID>(); } set { this["ParentID"] = value; } }
        public Array<MovieSceneSequenceID> Children { get { return new Array<MovieSceneSequenceID>(this[nameof(Children)].Address); } }
    }
    public class MovieSceneSubSequenceTreeEntry : Object
    {
        public MovieSceneSubSequenceTreeEntry(nint addr) : base(addr) { }
    }
    public class MovieSceneSubSequenceTree : Object
    {
        public MovieSceneSubSequenceTree(nint addr) : base(addr) { }
    }
    public class MovieSceneSequenceHierarchy : Object
    {
        public MovieSceneSequenceHierarchy(nint addr) : base(addr) { }
        public MovieSceneSequenceHierarchyNode RootNode { get { return this[nameof(RootNode)].As<MovieSceneSequenceHierarchyNode>(); } set { this["RootNode"] = value; } }
        public MovieSceneSubSequenceTree Tree { get { return this[nameof(Tree)].As<MovieSceneSubSequenceTree>(); } set { this["Tree"] = value; } }
        public Object SubSequences { get { return this[nameof(SubSequences)]; } set { this[nameof(SubSequences)] = value; } }
        public Object Hierarchy { get { return this[nameof(Hierarchy)]; } set { this[nameof(Hierarchy)] = value; } }
    }
    public class MovieSceneWarpCounter : Object
    {
        public MovieSceneWarpCounter(nint addr) : base(addr) { }
        public Array<uint> WarpCounts { get { return new Array<uint>(this[nameof(WarpCounts)].Address); } }
    }
    public class MovieSceneExpansionState : Object
    {
        public MovieSceneExpansionState(nint addr) : base(addr) { }
        public bool bExpanded { get { return this[nameof(bExpanded)].Flag; } set { this[nameof(bExpanded)].Flag = value; } }
    }
    public class MovieSceneMarkedFrame : Object
    {
        public MovieSceneMarkedFrame(nint addr) : base(addr) { }
        public FrameNumber FrameNumber { get { return this[nameof(FrameNumber)].As<FrameNumber>(); } set { this["FrameNumber"] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public bool bIsDeterminismFence { get { return this[nameof(bIsDeterminismFence)].Flag; } set { this[nameof(bIsDeterminismFence)].Flag = value; } }
    }
    public class MovieSceneEditorData : Object
    {
        public MovieSceneEditorData(nint addr) : base(addr) { }
        public Object ExpansionStates { get { return this[nameof(ExpansionStates)]; } set { this[nameof(ExpansionStates)] = value; } }
        public Array<Object> PinnedNodes { get { return new Array<Object>(this[nameof(PinnedNodes)].Address); } }
        public double ViewStart { get { return this[nameof(ViewStart)].GetValue<double>(); } set { this[nameof(ViewStart)].SetValue<double>(value); } }
        public double ViewEnd { get { return this[nameof(ViewEnd)].GetValue<double>(); } set { this[nameof(ViewEnd)].SetValue<double>(value); } }
        public double WorkStart { get { return this[nameof(WorkStart)].GetValue<double>(); } set { this[nameof(WorkStart)].SetValue<double>(value); } }
        public double WorkEnd { get { return this[nameof(WorkEnd)].GetValue<double>(); } set { this[nameof(WorkEnd)].SetValue<double>(value); } }
        public Object MarkedFrames { get { return this[nameof(MarkedFrames)]; } set { this[nameof(MarkedFrames)] = value; } }
        public FloatRange WorkingRange { get { return this[nameof(WorkingRange)].As<FloatRange>(); } set { this["WorkingRange"] = value; } }
        public FloatRange ViewRange { get { return this[nameof(ViewRange)].As<FloatRange>(); } set { this["ViewRange"] = value; } }
    }
    public class MovieSceneTrackLabels : Object
    {
        public MovieSceneTrackLabels(nint addr) : base(addr) { }
        public Array<Object> Strings { get { return new Array<Object>(this[nameof(Strings)].Address); } }
    }
    public class MovieSceneObjectBindingIDs : Object
    {
        public MovieSceneObjectBindingIDs(nint addr) : base(addr) { }
        public Array<MovieSceneObjectBindingID> IDs { get { return new Array<MovieSceneObjectBindingID>(this[nameof(IDs)].Address); } }
    }
    public class MovieSceneObjectBindingID : Object
    {
        public MovieSceneObjectBindingID(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public int SequenceID { get { return this[nameof(SequenceID)].GetValue<int>(); } set { this[nameof(SequenceID)].SetValue<int>(value); } }
        public int ResolveParentIndex { get { return this[nameof(ResolveParentIndex)].GetValue<int>(); } set { this[nameof(ResolveParentIndex)].SetValue<int>(value); } }
    }
    public class MovieSceneSectionGroup : Object
    {
        public MovieSceneSectionGroup(nint addr) : base(addr) { }
        public Array<Object> Sections { get { return new Array<Object>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneBinding : Object
    {
        public MovieSceneBinding(nint addr) : base(addr) { }
        public Guid ObjectGuid { get { return this[nameof(ObjectGuid)].As<Guid>(); } set { this["ObjectGuid"] = value; } }
        public Object BindingName { get { return this[nameof(BindingName)]; } set { this[nameof(BindingName)] = value; } }
        public Array<MovieSceneTrack> Tracks { get { return new Array<MovieSceneTrack>(this[nameof(Tracks)].Address); } }
    }
    public class MovieSceneBindingOverrideData : Object
    {
        public MovieSceneBindingOverrideData(nint addr) : base(addr) { }
        public MovieSceneObjectBindingID ObjectBindingID { get { return this[nameof(ObjectBindingID)].As<MovieSceneObjectBindingID>(); } set { this["ObjectBindingID"] = value; } }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public bool bOverridesDefault { get { return this[nameof(bOverridesDefault)].Flag; } set { this[nameof(bOverridesDefault)].Flag = value; } }
    }
    public class MovieSceneBindingProxy : Object
    {
        public MovieSceneBindingProxy(nint addr) : base(addr) { }
        public Guid BindingId { get { return this[nameof(BindingId)].As<Guid>(); } set { this["BindingId"] = value; } }
        public MovieSceneSequence Sequence { get { return this[nameof(Sequence)].As<MovieSceneSequence>(); } set { this["Sequence"] = value; } }
    }
    public class MovieScenePossessable : Object
    {
        public MovieScenePossessable(nint addr) : base(addr) { }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Guid ParentGuid { get { return this[nameof(ParentGuid)].As<Guid>(); } set { this["ParentGuid"] = value; } }
        public MovieSceneObjectBindingID SpawnableObjectBindingID { get { return this[nameof(SpawnableObjectBindingID)].As<MovieSceneObjectBindingID>(); } set { this["SpawnableObjectBindingID"] = value; } }
    }
    public class MovieSceneSectionEvalOptions : Object
    {
        public MovieSceneSectionEvalOptions(nint addr) : base(addr) { }
        public bool bCanEditCompletionMode { get { return this[nameof(bCanEditCompletionMode)].Flag; } set { this[nameof(bCanEditCompletionMode)].Flag = value; } }
        public EMovieSceneCompletionMode CompletionMode { get { return (EMovieSceneCompletionMode)this[nameof(CompletionMode)].GetValue<int>(); } set { this[nameof(CompletionMode)].SetValue<int>((int)value); } }
    }
    public class MovieSceneEasingSettings : Object
    {
        public MovieSceneEasingSettings(nint addr) : base(addr) { }
        public int AutoEaseInDuration { get { return this[nameof(AutoEaseInDuration)].GetValue<int>(); } set { this[nameof(AutoEaseInDuration)].SetValue<int>(value); } }
        public int AutoEaseOutDuration { get { return this[nameof(AutoEaseOutDuration)].GetValue<int>(); } set { this[nameof(AutoEaseOutDuration)].SetValue<int>(value); } }
        public Object EaseIn { get { return this[nameof(EaseIn)]; } set { this[nameof(EaseIn)] = value; } }
        public bool bManualEaseIn { get { return this[nameof(bManualEaseIn)].Flag; } set { this[nameof(bManualEaseIn)].Flag = value; } }
        public int ManualEaseInDuration { get { return this[nameof(ManualEaseInDuration)].GetValue<int>(); } set { this[nameof(ManualEaseInDuration)].SetValue<int>(value); } }
        public Object EaseOut { get { return this[nameof(EaseOut)]; } set { this[nameof(EaseOut)] = value; } }
        public bool bManualEaseOut { get { return this[nameof(bManualEaseOut)].Flag; } set { this[nameof(bManualEaseOut)].Flag = value; } }
        public int ManualEaseOutDuration { get { return this[nameof(ManualEaseOutDuration)].GetValue<int>(); } set { this[nameof(ManualEaseOutDuration)].SetValue<int>(value); } }
    }
    public class MovieSceneTimecodeSource : Object
    {
        public MovieSceneTimecodeSource(nint addr) : base(addr) { }
        public Timecode Timecode { get { return this[nameof(Timecode)].As<Timecode>(); } set { this["Timecode"] = value; } }
    }
    public class MovieSceneSequenceReplProperties : Object
    {
        public MovieSceneSequenceReplProperties(nint addr) : base(addr) { }
        public FrameTime LastKnownPosition { get { return this[nameof(LastKnownPosition)].As<FrameTime>(); } set { this["LastKnownPosition"] = value; } }
        public byte LastKnownStatus { get { return this[nameof(LastKnownStatus)].GetValue<byte>(); } set { this[nameof(LastKnownStatus)].SetValue<byte>(value); } }
        public int LastKnownNumLoops { get { return this[nameof(LastKnownNumLoops)].GetValue<int>(); } set { this[nameof(LastKnownNumLoops)].SetValue<int>(value); } }
    }
    public class MovieSceneSequencePlaybackParams : Object
    {
        public MovieSceneSequencePlaybackParams(nint addr) : base(addr) { }
        public FrameTime Frame { get { return this[nameof(Frame)].As<FrameTime>(); } set { this["Frame"] = value; } }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
        public Object MarkedFrame { get { return this[nameof(MarkedFrame)]; } set { this[nameof(MarkedFrame)] = value; } }
        public EMovieScenePositionType PositionType { get { return (EMovieScenePositionType)this[nameof(PositionType)].GetValue<int>(); } set { this[nameof(PositionType)].SetValue<int>((int)value); } }
        public EUpdatePositionMethod UpdateMethod { get { return (EUpdatePositionMethod)this[nameof(UpdateMethod)].GetValue<int>(); } set { this[nameof(UpdateMethod)].SetValue<int>((int)value); } }
        public bool bHasJumped { get { return this[nameof(bHasJumped)].Flag; } set { this[nameof(bHasJumped)].Flag = value; } }
    }
    public class MovieSceneSequencePlayToParams : Object
    {
        public MovieSceneSequencePlayToParams(nint addr) : base(addr) { }
        public bool bExclusive { get { return this[nameof(bExclusive)].Flag; } set { this[nameof(bExclusive)].Flag = value; } }
    }
    public class MovieSceneSpawnable : Object
    {
        public MovieSceneSpawnable(nint addr) : base(addr) { }
        public Transform SpawnTransform { get { return this[nameof(SpawnTransform)].As<Transform>(); } set { this["SpawnTransform"] = value; } }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
        public bool bContinuouslyRespawn { get { return this[nameof(bContinuouslyRespawn)].Flag; } set { this[nameof(bContinuouslyRespawn)].Flag = value; } }
        public bool bNetAddressableName { get { return this[nameof(bNetAddressableName)].Flag; } set { this[nameof(bNetAddressableName)].Flag = value; } }
        public bool bEvaluateTracksWhenNotSpawned { get { return this[nameof(bEvaluateTracksWhenNotSpawned)].Flag; } set { this[nameof(bEvaluateTracksWhenNotSpawned)].Flag = value; } }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ObjectTemplate { get { return this[nameof(ObjectTemplate)].As<Object>(); } set { this["ObjectTemplate"] = value; } }
        public Array<Guid> ChildPossessables { get { return new Array<Guid>(this[nameof(ChildPossessables)].Address); } }
        public ESpawnOwnership Ownership { get { return (ESpawnOwnership)this[nameof(Ownership)].GetValue<int>(); } set { this[nameof(Ownership)].SetValue<int>((int)value); } }
        public Object LevelName { get { return this[nameof(LevelName)]; } set { this[nameof(LevelName)] = value; } }
    }
    public class MovieSceneTrackEvalOptions : Object
    {
        public MovieSceneTrackEvalOptions(nint addr) : base(addr) { }
        public bool bCanEvaluateNearestSection { get { return this[nameof(bCanEvaluateNearestSection)].Flag; } set { this[nameof(bCanEvaluateNearestSection)].Flag = value; } }
        public bool bEvalNearestSection { get { return this[nameof(bEvalNearestSection)].Flag; } set { this[nameof(bEvalNearestSection)].Flag = value; } }
        public bool bEvaluateInPreroll { get { return this[nameof(bEvaluateInPreroll)].Flag; } set { this[nameof(bEvaluateInPreroll)].Flag = value; } }
        public bool bEvaluateInPostroll { get { return this[nameof(bEvaluateInPostroll)].Flag; } set { this[nameof(bEvaluateInPostroll)].Flag = value; } }
        public bool bEvaluateNearestSection { get { return this[nameof(bEvaluateNearestSection)].Flag; } set { this[nameof(bEvaluateNearestSection)].Flag = value; } }
    }
    public class MovieSceneTrackDisplayOptions : Object
    {
        public MovieSceneTrackDisplayOptions(nint addr) : base(addr) { }
        public bool bShowVerticalFrames { get { return this[nameof(bShowVerticalFrames)].Flag; } set { this[nameof(bShowVerticalFrames)].Flag = value; } }
    }
    public class MovieSceneTrackEvaluationFieldEntry : Object
    {
        public MovieSceneTrackEvaluationFieldEntry(nint addr) : base(addr) { }
        public MovieSceneSection Section { get { return this[nameof(Section)].As<MovieSceneSection>(); } set { this["Section"] = value; } }
        public FrameNumberRange Range { get { return this[nameof(Range)].As<FrameNumberRange>(); } set { this["Range"] = value; } }
        public FrameNumber ForcedTime { get { return this[nameof(ForcedTime)].As<FrameNumber>(); } set { this["ForcedTime"] = value; } }
        public ESectionEvaluationFlags Flags { get { return (ESectionEvaluationFlags)this[nameof(Flags)].GetValue<int>(); } set { this[nameof(Flags)].SetValue<int>((int)value); } }
        public short LegacySortOrder { get { return this[nameof(LegacySortOrder)].GetValue<short>(); } set { this[nameof(LegacySortOrder)].SetValue<short>(value); } }
    }
    public class MovieSceneTrackEvaluationField : Object
    {
        public MovieSceneTrackEvaluationField(nint addr) : base(addr) { }
        public Array<MovieSceneTrackEvaluationFieldEntry> Entries { get { return new Array<MovieSceneTrackEvaluationFieldEntry>(this[nameof(Entries)].Address); } }
    }
    public class TestMovieSceneEvalTemplate : MovieSceneEvalTemplate
    {
        public TestMovieSceneEvalTemplate(nint addr) : base(addr) { }
    }
}
