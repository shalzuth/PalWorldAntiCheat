using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.UMGSDK;
using SDK.Script.LevelSequenceSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.OpenColorIOSDK;
namespace SDK.Script.MovieRenderPipelineCoreSDK
{
    public class MoviePipelineSetting : Object
    {
        public MoviePipelineSetting(nint addr) : base(addr) { }
        public Object CachedPipeline { get { return this[nameof(CachedPipeline)]; } set { this[nameof(CachedPipeline)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public void SetIsEnabled(bool bInEnabled) { Invoke(nameof(SetIsEnabled), bInEnabled); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public void BuildNewProcessCommandLineArgs(Array<Object> InOutUnrealURLParams, Array<Object> InOutCommandLineArgs, Array<Object> InOutDeviceProfileCvars, Array<Object> InOutExecCmds) { Invoke(nameof(BuildNewProcessCommandLineArgs), InOutUnrealURLParams, InOutCommandLineArgs, InOutDeviceProfileCvars, InOutExecCmds); }
        public void BuildNewProcessCommandLine(Object InOutUnrealURLParams, Object InOutCommandLineArgs) { Invoke(nameof(BuildNewProcessCommandLine), InOutUnrealURLParams, InOutCommandLineArgs); }
    }
    public class MoviePipelineViewFamilySetting : MoviePipelineSetting
    {
        public MoviePipelineViewFamilySetting(nint addr) : base(addr) { }
    }
    public class MoviePipelineCameraSetting : MoviePipelineSetting
    {
        public MoviePipelineCameraSetting(nint addr) : base(addr) { }
        public EMoviePipelineShutterTiming ShutterTiming { get { return (EMoviePipelineShutterTiming)this[nameof(ShutterTiming)].GetValue<int>(); } set { this[nameof(ShutterTiming)].SetValue<int>((int)value); } }
        public float OverscanPercentage { get { return this[nameof(OverscanPercentage)].GetValue<float>(); } set { this[nameof(OverscanPercentage)].SetValue<float>(value); } }
        public bool bRenderAllCameras { get { return this[nameof(bRenderAllCameras)].Flag; } set { this[nameof(bRenderAllCameras)].Flag = value; } }
    }
    public class MoviePipelineGameMode : GameModeBase
    {
        public MoviePipelineGameMode(nint addr) : base(addr) { }
    }
    public class MoviePipelineHighResSetting : MoviePipelineSetting
    {
        public MoviePipelineHighResSetting(nint addr) : base(addr) { }
        public int TileCount { get { return this[nameof(TileCount)].GetValue<int>(); } set { this[nameof(TileCount)].SetValue<int>(value); } }
        public float TextureSharpnessBias { get { return this[nameof(TextureSharpnessBias)].GetValue<float>(); } set { this[nameof(TextureSharpnessBias)].SetValue<float>(value); } }
        public float OverlapRatio { get { return this[nameof(OverlapRatio)].GetValue<float>(); } set { this[nameof(OverlapRatio)].SetValue<float>(value); } }
        public bool bOverrideSubSurfaceScattering { get { return this[nameof(bOverrideSubSurfaceScattering)].Flag; } set { this[nameof(bOverrideSubSurfaceScattering)].Flag = value; } }
        public int BurleySampleCount { get { return this[nameof(BurleySampleCount)].GetValue<int>(); } set { this[nameof(BurleySampleCount)].SetValue<int>(value); } }
        public bool bAllocateHistoryPerTile { get { return this[nameof(bAllocateHistoryPerTile)].Flag; } set { this[nameof(bAllocateHistoryPerTile)].Flag = value; } }
    }
    public class MoviePipelineInProcessExecutorSettings : DeveloperSettings
    {
        public MoviePipelineInProcessExecutorSettings(nint addr) : base(addr) { }
        public bool bCloseEditor { get { return this[nameof(bCloseEditor)].Flag; } set { this[nameof(bCloseEditor)].Flag = value; } }
        public Object AdditionalCommandLineArguments { get { return this[nameof(AdditionalCommandLineArguments)]; } set { this[nameof(AdditionalCommandLineArguments)] = value; } }
        public Object InheritedCommandLineArguments { get { return this[nameof(InheritedCommandLineArguments)]; } set { this[nameof(InheritedCommandLineArguments)] = value; } }
        public int InitialDelayFrameCount { get { return this[nameof(InitialDelayFrameCount)].GetValue<int>(); } set { this[nameof(InitialDelayFrameCount)].SetValue<int>(value); } }
    }
    public class MoviePipelineOutputBase : MoviePipelineSetting
    {
        public MoviePipelineOutputBase(nint addr) : base(addr) { }
    }
    public class MoviePipelineSetting_BlueprintBase : MoviePipelineSetting
    {
        public MoviePipelineSetting_BlueprintBase(nint addr) : base(addr) { }
        public Object CategoryText { get { return this[nameof(CategoryText)]; } set { this[nameof(CategoryText)] = value; } }
        public bool bIsValidOnMaster { get { return this[nameof(bIsValidOnMaster)].Flag; } set { this[nameof(bIsValidOnMaster)].Flag = value; } }
        public bool bIsValidOnShots { get { return this[nameof(bIsValidOnShots)].Flag; } set { this[nameof(bIsValidOnShots)].Flag = value; } }
        public bool bCanBeDisabled { get { return this[nameof(bCanBeDisabled)].Flag; } set { this[nameof(bCanBeDisabled)].Flag = value; } }
        public void ReceiveTeardownForPipelineImpl(MoviePipeline InPipeline) { Invoke(nameof(ReceiveTeardownForPipelineImpl), InPipeline); }
        public void ReceiveSetupForPipelineImpl(MoviePipeline InPipeline) { Invoke(nameof(ReceiveSetupForPipelineImpl), InPipeline); }
        public MoviePipelineFormatArgs ReceiveGetFormatArguments(MoviePipelineFormatArgs InOutFormatArgs) { return Invoke<MoviePipelineFormatArgs>(nameof(ReceiveGetFormatArguments), InOutFormatArgs); }
        public void OnEngineTickBeginFrame() { Invoke(nameof(OnEngineTickBeginFrame)); }
    }
    public class MovieRenderDebugWidget : UserWidget
    {
        public MovieRenderDebugWidget(nint addr) : base(addr) { }
        public void OnInitializedForPipeline(MoviePipeline ForPipeline) { Invoke(nameof(OnInitializedForPipeline), ForPipeline); }
    }
    public class MoviePipeline : Object
    {
        public MoviePipeline(nint addr) : base(addr) { }
        public Object OnMoviePipelineFinishedDelegate { get { return this[nameof(OnMoviePipelineFinishedDelegate)]; } set { this[nameof(OnMoviePipelineFinishedDelegate)] = value; } }
        public Object OnMoviePipelineWorkFinishedDelegate { get { return this[nameof(OnMoviePipelineWorkFinishedDelegate)]; } set { this[nameof(OnMoviePipelineWorkFinishedDelegate)] = value; } }
        public Object OnMoviePipelineShotWorkFinishedDelegate { get { return this[nameof(OnMoviePipelineShotWorkFinishedDelegate)]; } set { this[nameof(OnMoviePipelineShotWorkFinishedDelegate)] = value; } }
        public MoviePipelineCustomTimeStep CustomTimeStep { get { return this[nameof(CustomTimeStep)].As<MoviePipelineCustomTimeStep>(); } set { this["CustomTimeStep"] = value; } }
        public EngineCustomTimeStep CachedPrevCustomTimeStep { get { return this[nameof(CachedPrevCustomTimeStep)].As<EngineCustomTimeStep>(); } set { this["CachedPrevCustomTimeStep"] = value; } }
        public LevelSequence TargetSequence { get { return this[nameof(TargetSequence)].As<LevelSequence>(); } set { this["TargetSequence"] = value; } }
        public LevelSequenceActor LevelSequenceActor { get { return this[nameof(LevelSequenceActor)].As<LevelSequenceActor>(); } set { this["LevelSequenceActor"] = value; } }
        public MovieRenderDebugWidget DebugWidget { get { return this[nameof(DebugWidget)].As<MovieRenderDebugWidget>(); } set { this["DebugWidget"] = value; } }
        public Texture PreviewTexture { get { return this[nameof(PreviewTexture)].As<Texture>(); } set { this["PreviewTexture"] = value; } }
        public Object DebugWidgetClass { get { return this[nameof(DebugWidgetClass)]; } set { this[nameof(DebugWidgetClass)] = value; } }
        public MoviePipelineExecutorJob CurrentJob { get { return this[nameof(CurrentJob)].As<MoviePipelineExecutorJob>(); } set { this["CurrentJob"] = value; } }
        public void Shutdown(bool bError) { Invoke(nameof(Shutdown), bError); }
        public void SetInitializationTime(DateTime InDateTime) { Invoke(nameof(SetInitializationTime), InDateTime); }
        public void RequestShutdown(bool bIsError) { Invoke(nameof(RequestShutdown), bIsError); }
        public void OnMoviePipelineFinishedImpl() { Invoke(nameof(OnMoviePipelineFinishedImpl)); }
        public bool IsShutdownRequested() { return Invoke<bool>(nameof(IsShutdownRequested)); }
        public void Initialize(MoviePipelineExecutorJob InJob) { Invoke(nameof(Initialize), InJob); }
        public Texture GetPreviewTexture() { return Invoke<Texture>(nameof(GetPreviewTexture)); }
        public MoviePipelineMasterConfig GetPipelineMasterConfig() { return Invoke<MoviePipelineMasterConfig>(nameof(GetPipelineMasterConfig)); }
        public DateTime GetInitializationTime() { return Invoke<DateTime>(nameof(GetInitializationTime)); }
        public MoviePipelineExecutorJob GetCurrentJob() { return Invoke<MoviePipelineExecutorJob>(nameof(GetCurrentJob)); }
    }
    public class MoviePipelineCustomTimeStep : EngineCustomTimeStep
    {
        public MoviePipelineCustomTimeStep(nint addr) : base(addr) { }
    }
    public class MoviePipelineAntiAliasingSetting : MoviePipelineSetting
    {
        public MoviePipelineAntiAliasingSetting(nint addr) : base(addr) { }
        public int SpatialSampleCount { get { return this[nameof(SpatialSampleCount)].GetValue<int>(); } set { this[nameof(SpatialSampleCount)].SetValue<int>(value); } }
        public int TemporalSampleCount { get { return this[nameof(TemporalSampleCount)].GetValue<int>(); } set { this[nameof(TemporalSampleCount)].SetValue<int>(value); } }
        public bool bOverrideAntiAliasing { get { return this[nameof(bOverrideAntiAliasing)].Flag; } set { this[nameof(bOverrideAntiAliasing)].Flag = value; } }
        public byte AntiAliasingMethod { get { return this[nameof(AntiAliasingMethod)].GetValue<byte>(); } set { this[nameof(AntiAliasingMethod)].SetValue<byte>(value); } }
        public int RenderWarmUpCount { get { return this[nameof(RenderWarmUpCount)].GetValue<int>(); } set { this[nameof(RenderWarmUpCount)].SetValue<int>(value); } }
        public bool bUseCameraCutForWarmUp { get { return this[nameof(bUseCameraCutForWarmUp)].Flag; } set { this[nameof(bUseCameraCutForWarmUp)].Flag = value; } }
        public int EngineWarmUpCount { get { return this[nameof(EngineWarmUpCount)].GetValue<int>(); } set { this[nameof(EngineWarmUpCount)].SetValue<int>(value); } }
        public bool bRenderWarmUpFrames { get { return this[nameof(bRenderWarmUpFrames)].Flag; } set { this[nameof(bRenderWarmUpFrames)].Flag = value; } }
    }
    public class MoviePipelineBlueprintLibrary : BlueprintFunctionLibrary
    {
        public MoviePipelineBlueprintLibrary(nint addr) : base(addr) { }
        public void UpdateJobShotListFromSequence(LevelSequence InSequence, MoviePipelineExecutorJob InJob, bool bShotsChanged) { Invoke(nameof(UpdateJobShotListFromSequence), InSequence, InJob, bShotsChanged); }
        public int ResolveVersionNumber(MoviePipelineFilenameResolveParams InParams) { return Invoke<int>(nameof(ResolveVersionNumber), InParams); }
        public void ResolveFilenameFormatArguments(Object InFormatString, MoviePipelineFilenameResolveParams InParams, Object OutFinalPath, MoviePipelineFormatArgs OutMergedFormatArgs) { Invoke(nameof(ResolveFilenameFormatArguments), InFormatString, InParams, OutFinalPath, OutMergedFormatArgs); }
        public MoviePipelineQueue LoadManifestFileFromString(Object InManifestFilePath) { return Invoke<MoviePipelineQueue>(nameof(LoadManifestFileFromString), InManifestFilePath); }
        public EMovieRenderPipelineState GetPipelineState(MoviePipeline InPipeline) { return Invoke<EMovieRenderPipelineState>(nameof(GetPipelineState), InPipeline); }
        public void GetOverallSegmentCounts(MoviePipeline InMoviePipeline, int OutCurrentIndex, int OutTotalCount) { Invoke(nameof(GetOverallSegmentCounts), InMoviePipeline, OutCurrentIndex, OutTotalCount); }
        public void GetOverallOutputFrames(MoviePipeline InMoviePipeline, int OutCurrentIndex, int OutTotalCount) { Invoke(nameof(GetOverallOutputFrames), InMoviePipeline, OutCurrentIndex, OutTotalCount); }
        public Object GetMoviePipelineEngineChangelistLabel(MoviePipeline InMoviePipeline) { return Invoke<Object>(nameof(GetMoviePipelineEngineChangelistLabel), InMoviePipeline); }
        public Timecode GetMasterTimecode(MoviePipeline InMoviePipeline) { return Invoke<Timecode>(nameof(GetMasterTimecode), InMoviePipeline); }
        public FrameNumber GetMasterFrameNumber(MoviePipeline InMoviePipeline) { return Invoke<FrameNumber>(nameof(GetMasterFrameNumber), InMoviePipeline); }
        public Object GetMapPackageName(MoviePipelineExecutorJob InJob) { return Invoke<Object>(nameof(GetMapPackageName), InJob); }
        public Object GetJobName(MoviePipeline InMoviePipeline) { return Invoke<Object>(nameof(GetJobName), InMoviePipeline); }
        public DateTime GetJobInitializationTime(MoviePipeline InMoviePipeline) { return Invoke<DateTime>(nameof(GetJobInitializationTime), InMoviePipeline); }
        public Object GetJobAuthor(MoviePipeline InMoviePipeline) { return Invoke<Object>(nameof(GetJobAuthor), InMoviePipeline); }
        public bool GetEstimatedTimeRemaining(MoviePipeline InPipeline, Timespan OutEstimate) { return Invoke<bool>(nameof(GetEstimatedTimeRemaining), InPipeline, OutEstimate); }
        public IntPoint GetEffectiveOutputResolution(MoviePipelineMasterConfig InMasterConfig, MoviePipelineExecutorShot InPipelineExecutorShot) { return Invoke<IntPoint>(nameof(GetEffectiveOutputResolution), InMasterConfig, InPipelineExecutorShot); }
        public Timecode GetCurrentShotTimecode(MoviePipeline InMoviePipeline) { return Invoke<Timecode>(nameof(GetCurrentShotTimecode), InMoviePipeline); }
        public FrameNumber GetCurrentShotFrameNumber(MoviePipeline InMoviePipeline) { return Invoke<FrameNumber>(nameof(GetCurrentShotFrameNumber), InMoviePipeline); }
        public LevelSequence GetCurrentSequence(MoviePipeline InMoviePipeline) { return Invoke<LevelSequence>(nameof(GetCurrentSequence), InMoviePipeline); }
        public MoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(MoviePipeline InMoviePipeline) { return Invoke<MoviePipelineSegmentWorkMetrics>(nameof(GetCurrentSegmentWorkMetrics), InMoviePipeline); }
        public EMovieRenderShotState GetCurrentSegmentState(MoviePipeline InMoviePipeline) { return Invoke<EMovieRenderShotState>(nameof(GetCurrentSegmentState), InMoviePipeline); }
        public void GetCurrentSegmentName(MoviePipeline InMoviePipeline, Object OutOuterName, Object OutInnerName) { Invoke(nameof(GetCurrentSegmentName), InMoviePipeline, OutOuterName, OutInnerName); }
        public float GetCurrentFocusDistance(MoviePipeline InMoviePipeline) { return Invoke<float>(nameof(GetCurrentFocusDistance), InMoviePipeline); }
        public float GetCurrentFocalLength(MoviePipeline InMoviePipeline) { return Invoke<float>(nameof(GetCurrentFocalLength), InMoviePipeline); }
        public MoviePipelineExecutorShot GetCurrentExecutorShot(MoviePipeline InMoviePipeline) { return Invoke<MoviePipelineExecutorShot>(nameof(GetCurrentExecutorShot), InMoviePipeline); }
        public float GetCurrentAperture(MoviePipeline InMoviePipeline) { return Invoke<float>(nameof(GetCurrentAperture), InMoviePipeline); }
        public float GetCompletionPercentage(MoviePipeline InPipeline) { return Invoke<float>(nameof(GetCompletionPercentage), InPipeline); }
        public MoviePipelineSetting FindOrGetDefaultSettingForShot(Object InSettingType, MoviePipelineMasterConfig InMasterConfig, MoviePipelineExecutorShot InShot) { return Invoke<MoviePipelineSetting>(nameof(FindOrGetDefaultSettingForShot), InSettingType, InMasterConfig, InShot); }
        public MovieSceneSequence DuplicateSequence(Object Outer, MovieSceneSequence InSequence) { return Invoke<MovieSceneSequence>(nameof(DuplicateSequence), Outer, InSequence); }
    }
    public class MoviePipelineColorSetting : MoviePipelineSetting
    {
        public MoviePipelineColorSetting(nint addr) : base(addr) { }
        public OpenColorIODisplayConfiguration OCIOConfiguration { get { return this[nameof(OCIOConfiguration)].As<OpenColorIODisplayConfiguration>(); } set { this["OCIOConfiguration"] = value; } }
        public bool bDisableToneCurve { get { return this[nameof(bDisableToneCurve)].Flag; } set { this[nameof(bDisableToneCurve)].Flag = value; } }
    }
    public class MoviePipelineCommandLineEncoder : MoviePipelineSetting
    {
        public MoviePipelineCommandLineEncoder(nint addr) : base(addr) { }
        public Object FileNameFormatOverride { get { return this[nameof(FileNameFormatOverride)]; } set { this[nameof(FileNameFormatOverride)] = value; } }
        public EMoviePipelineEncodeQuality Quality { get { return (EMoviePipelineEncodeQuality)this[nameof(Quality)].GetValue<int>(); } set { this[nameof(Quality)].SetValue<int>((int)value); } }
        public Object AdditionalCommandLineArgs { get { return this[nameof(AdditionalCommandLineArgs)]; } set { this[nameof(AdditionalCommandLineArgs)] = value; } }
        public bool bDeleteSourceFiles { get { return this[nameof(bDeleteSourceFiles)].Flag; } set { this[nameof(bDeleteSourceFiles)].Flag = value; } }
        public bool bSkipEncodeOnRenderCanceled { get { return this[nameof(bSkipEncodeOnRenderCanceled)].Flag; } set { this[nameof(bSkipEncodeOnRenderCanceled)].Flag = value; } }
        public bool bWriteEachFrameDuration { get { return this[nameof(bWriteEachFrameDuration)].Flag; } set { this[nameof(bWriteEachFrameDuration)].Flag = value; } }
    }
    public class MoviePipelineCommandLineEncoderSettings : DeveloperSettings
    {
        public MoviePipelineCommandLineEncoderSettings(nint addr) : base(addr) { }
        public Object ExecutablePath { get { return this[nameof(ExecutablePath)]; } set { this[nameof(ExecutablePath)] = value; } }
        public Object CodecHelpText { get { return this[nameof(CodecHelpText)]; } set { this[nameof(CodecHelpText)] = value; } }
        public Object VideoCodec { get { return this[nameof(VideoCodec)]; } set { this[nameof(VideoCodec)] = value; } }
        public Object AudioCodec { get { return this[nameof(AudioCodec)]; } set { this[nameof(AudioCodec)] = value; } }
        public Object OutputFileExtension { get { return this[nameof(OutputFileExtension)]; } set { this[nameof(OutputFileExtension)] = value; } }
        public Object CommandLineFormat { get { return this[nameof(CommandLineFormat)]; } set { this[nameof(CommandLineFormat)] = value; } }
        public Object VideoInputStringFormat { get { return this[nameof(VideoInputStringFormat)]; } set { this[nameof(VideoInputStringFormat)] = value; } }
        public Object AudioInputStringFormat { get { return this[nameof(AudioInputStringFormat)]; } set { this[nameof(AudioInputStringFormat)] = value; } }
        public Object EncodeSettings_Low { get { return this[nameof(EncodeSettings_Low)]; } set { this[nameof(EncodeSettings_Low)] = value; } }
        public Object EncodeSettings_Med { get { return this[nameof(EncodeSettings_Med)]; } set { this[nameof(EncodeSettings_Med)] = value; } }
        public Object EncodeSettings_High { get { return this[nameof(EncodeSettings_High)]; } set { this[nameof(EncodeSettings_High)] = value; } }
        public Object EncodeSettings_Epic { get { return this[nameof(EncodeSettings_Epic)]; } set { this[nameof(EncodeSettings_Epic)] = value; } }
    }
    public class MoviePipelineConfigBase : Object
    {
        public MoviePipelineConfigBase(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Array<MoviePipelineSetting> Settings { get { return new Array<MoviePipelineSetting>(this[nameof(Settings)].Address); } }
        public void RemoveSetting(MoviePipelineSetting InSetting) { Invoke(nameof(RemoveSetting), InSetting); }
        public Array<MoviePipelineSetting> GetUserSettings() { return Invoke<Array<MoviePipelineSetting>>(nameof(GetUserSettings)); }
        public Array<MoviePipelineSetting> FindSettingsByClass(Object InClass, bool bIncludeDisabledSettings) { return Invoke<Array<MoviePipelineSetting>>(nameof(FindSettingsByClass), InClass, bIncludeDisabledSettings); }
        public MoviePipelineSetting FindSettingByClass(Object InClass, bool bIncludeDisabledSettings) { return Invoke<MoviePipelineSetting>(nameof(FindSettingByClass), InClass, bIncludeDisabledSettings); }
        public MoviePipelineSetting FindOrAddSettingByClass(Object InClass, bool bIncludeDisabledSettings) { return Invoke<MoviePipelineSetting>(nameof(FindOrAddSettingByClass), InClass, bIncludeDisabledSettings); }
        public void CopyFrom(MoviePipelineConfigBase InConfig) { Invoke(nameof(CopyFrom), InConfig); }
    }
    public class MoviePipelineDebugSettings : MoviePipelineSetting
    {
        public MoviePipelineDebugSettings(nint addr) : base(addr) { }
        public bool bWriteAllSamples { get { return this[nameof(bWriteAllSamples)].Flag; } set { this[nameof(bWriteAllSamples)].Flag = value; } }
        public bool bCaptureFramesWithRenderDoc { get { return this[nameof(bCaptureFramesWithRenderDoc)].Flag; } set { this[nameof(bCaptureFramesWithRenderDoc)].Flag = value; } }
        public int CaptureFrame { get { return this[nameof(CaptureFrame)].GetValue<int>(); } set { this[nameof(CaptureFrame)].SetValue<int>(value); } }
        public bool bCaptureUnrealInsightsTrace { get { return this[nameof(bCaptureUnrealInsightsTrace)].Flag; } set { this[nameof(bCaptureUnrealInsightsTrace)].Flag = value; } }
    }
    public class MoviePipelineExecutorBase : Object
    {
        public MoviePipelineExecutorBase(nint addr) : base(addr) { }
        public Object OnExecutorFinishedDelegate { get { return this[nameof(OnExecutorFinishedDelegate)]; } set { this[nameof(OnExecutorFinishedDelegate)] = value; } }
        public Object OnExecutorErroredDelegate { get { return this[nameof(OnExecutorErroredDelegate)]; } set { this[nameof(OnExecutorErroredDelegate)] = value; } }
        public Object SocketMessageRecievedDelegate { get { return this[nameof(SocketMessageRecievedDelegate)]; } set { this[nameof(SocketMessageRecievedDelegate)] = value; } }
        public Object HTTPResponseRecievedDelegate { get { return this[nameof(HTTPResponseRecievedDelegate)]; } set { this[nameof(HTTPResponseRecievedDelegate)] = value; } }
        public Object DebugWidgetClass { get { return this[nameof(DebugWidgetClass)]; } set { this[nameof(DebugWidgetClass)] = value; } }
        public Object UserData { get { return this[nameof(UserData)]; } set { this[nameof(UserData)] = value; } }
        public Object TargetPipelineClass { get { return this[nameof(TargetPipelineClass)]; } set { this[nameof(TargetPipelineClass)] = value; } }
        public void SetStatusProgress(float InProgress) { Invoke(nameof(SetStatusProgress), InProgress); }
        public void SetStatusMessage(Object InStatus) { Invoke(nameof(SetStatusMessage), InStatus); }
        public void SetMoviePipelineClass(Object InPipelineClass) { Invoke(nameof(SetMoviePipelineClass), InPipelineClass); }
        public bool SendSocketMessage(Object InMessage) { return Invoke<bool>(nameof(SendSocketMessage), InMessage); }
        public int SendHTTPRequest(Object InURL, Object InVerb, Object InMessage, Object InHeaders) { return Invoke<int>(nameof(SendHTTPRequest), InURL, InVerb, InMessage, InHeaders); }
        public void OnExecutorFinishedImpl() { Invoke(nameof(OnExecutorFinishedImpl)); }
        public void OnExecutorErroredImpl(MoviePipeline ErroredPipeline, bool bFatal, Object ErrorReason) { Invoke(nameof(OnExecutorErroredImpl), ErroredPipeline, bFatal, ErrorReason); }
        public void OnBeginFrame() { Invoke(nameof(OnBeginFrame)); }
        public bool IsSocketConnected() { return Invoke<bool>(nameof(IsSocketConnected)); }
        public bool IsRendering() { return Invoke<bool>(nameof(IsRendering)); }
        public float GetStatusProgress() { return Invoke<float>(nameof(GetStatusProgress)); }
        public Object GetStatusMessage() { return Invoke<Object>(nameof(GetStatusMessage)); }
        public void Execute(MoviePipelineQueue InPipelineQueue) { Invoke(nameof(Execute), InPipelineQueue); }
        public void DisconnectSocket() { Invoke(nameof(DisconnectSocket)); }
        public bool ConnectSocket(Object InHostName, int InPort) { return Invoke<bool>(nameof(ConnectSocket), InHostName, InPort); }
        public void CancelCurrentJob() { Invoke(nameof(CancelCurrentJob)); }
        public void CancelAllJobs() { Invoke(nameof(CancelAllJobs)); }
    }
    public class MoviePipelineFCPXMLExporter : MoviePipelineOutputBase
    {
        public MoviePipelineFCPXMLExporter(nint addr) : base(addr) { }
        public Object FileNameFormatOverride { get { return this[nameof(FileNameFormatOverride)]; } set { this[nameof(FileNameFormatOverride)] = value; } }
        public FCPXMLExportDataSource DataSource { get { return (FCPXMLExportDataSource)this[nameof(DataSource)].GetValue<int>(); } set { this[nameof(DataSource)].SetValue<int>((int)value); } }
    }
    public class MoviePipelineGameOverrideSetting : MoviePipelineSetting
    {
        public MoviePipelineGameOverrideSetting(nint addr) : base(addr) { }
        public Object GameModeOverride { get { return this[nameof(GameModeOverride)]; } set { this[nameof(GameModeOverride)] = value; } }
        public bool bCinematicQualitySettings { get { return this[nameof(bCinematicQualitySettings)].Flag; } set { this[nameof(bCinematicQualitySettings)].Flag = value; } }
        public EMoviePipelineTextureStreamingMethod TextureStreaming { get { return (EMoviePipelineTextureStreamingMethod)this[nameof(TextureStreaming)].GetValue<int>(); } set { this[nameof(TextureStreaming)].SetValue<int>((int)value); } }
        public bool bUseLODZero { get { return this[nameof(bUseLODZero)].Flag; } set { this[nameof(bUseLODZero)].Flag = value; } }
        public bool bDisableHLODs { get { return this[nameof(bDisableHLODs)].Flag; } set { this[nameof(bDisableHLODs)].Flag = value; } }
        public bool bUseHighQualityShadows { get { return this[nameof(bUseHighQualityShadows)].Flag; } set { this[nameof(bUseHighQualityShadows)].Flag = value; } }
        public int ShadowDistanceScale { get { return this[nameof(ShadowDistanceScale)].GetValue<int>(); } set { this[nameof(ShadowDistanceScale)].SetValue<int>(value); } }
        public float ShadowRadiusThreshold { get { return this[nameof(ShadowRadiusThreshold)].GetValue<float>(); } set { this[nameof(ShadowRadiusThreshold)].SetValue<float>(value); } }
        public bool bOverrideViewDistanceScale { get { return this[nameof(bOverrideViewDistanceScale)].Flag; } set { this[nameof(bOverrideViewDistanceScale)].Flag = value; } }
        public int ViewDistanceScale { get { return this[nameof(ViewDistanceScale)].GetValue<int>(); } set { this[nameof(ViewDistanceScale)].SetValue<int>(value); } }
        public bool bFlushGrassStreaming { get { return this[nameof(bFlushGrassStreaming)].Flag; } set { this[nameof(bFlushGrassStreaming)].Flag = value; } }
        public bool bFlushStreamingManagers { get { return this[nameof(bFlushStreamingManagers)].Flag; } set { this[nameof(bFlushStreamingManagers)].Flag = value; } }
        public bool bOverrideVirtualTextureFeedbackFactor { get { return this[nameof(bOverrideVirtualTextureFeedbackFactor)].Flag; } set { this[nameof(bOverrideVirtualTextureFeedbackFactor)].Flag = value; } }
        public int VirtualTextureFeedbackFactor { get { return this[nameof(VirtualTextureFeedbackFactor)].GetValue<int>(); } set { this[nameof(VirtualTextureFeedbackFactor)].SetValue<int>(value); } }
    }
    public class MoviePipelineLinearExecutorBase : MoviePipelineExecutorBase
    {
        public MoviePipelineLinearExecutorBase(nint addr) : base(addr) { }
        public MoviePipelineQueue Queue { get { return this[nameof(Queue)].As<MoviePipelineQueue>(); } set { this["Queue"] = value; } }
        public MoviePipeline ActiveMoviePipeline { get { return this[nameof(ActiveMoviePipeline)].As<MoviePipeline>(); } set { this["ActiveMoviePipeline"] = value; } }
    }
    public class MoviePipelineInProcessExecutor : MoviePipelineLinearExecutorBase
    {
        public MoviePipelineInProcessExecutor(nint addr) : base(addr) { }
        public bool bUseCurrentLevel { get { return this[nameof(bUseCurrentLevel)].Flag; } set { this[nameof(bUseCurrentLevel)].Flag = value; } }
    }
    public class MoviePipelineMasterConfig : MoviePipelineConfigBase
    {
        public MoviePipelineMasterConfig(nint addr) : base(addr) { }
        public Object PerShotConfigMapping { get { return this[nameof(PerShotConfigMapping)]; } set { this[nameof(PerShotConfigMapping)] = value; } }
        public MoviePipelineOutputSetting OutputSetting { get { return this[nameof(OutputSetting)].As<MoviePipelineOutputSetting>(); } set { this["OutputSetting"] = value; } }
        public Array<MoviePipelineSetting> TransientSettings { get { return new Array<MoviePipelineSetting>(this[nameof(TransientSettings)].Address); } }
        public void InitializeTransientSettings() { Invoke(nameof(InitializeTransientSettings)); }
        public Array<MoviePipelineSetting> GetTransientSettings() { return Invoke<Array<MoviePipelineSetting>>(nameof(GetTransientSettings)); }
        public FrameRate GetEffectiveFrameRate(LevelSequence InSequence) { return Invoke<FrameRate>(nameof(GetEffectiveFrameRate), InSequence); }
        public Array<MoviePipelineSetting> GetAllSettings(bool bIncludeDisabledSettings, bool bIncludeTransientSettings) { return Invoke<Array<MoviePipelineSetting>>(nameof(GetAllSettings), bIncludeDisabledSettings, bIncludeTransientSettings); }
    }
    public class MoviePipelineOutputSetting : MoviePipelineSetting
    {
        public MoviePipelineOutputSetting(nint addr) : base(addr) { }
        public DirectoryPath OutputDirectory { get { return this[nameof(OutputDirectory)].As<DirectoryPath>(); } set { this["OutputDirectory"] = value; } }
        public Object FilenameFormat { get { return this[nameof(FilenameFormat)]; } set { this[nameof(FilenameFormat)] = value; } }
        public IntPoint OutputResolution { get { return this[nameof(OutputResolution)].As<IntPoint>(); } set { this["OutputResolution"] = value; } }
        public bool bUseCustomFrameRate { get { return this[nameof(bUseCustomFrameRate)].Flag; } set { this[nameof(bUseCustomFrameRate)].Flag = value; } }
        public FrameRate OutputFrameRate { get { return this[nameof(OutputFrameRate)].As<FrameRate>(); } set { this["OutputFrameRate"] = value; } }
        public bool bOverrideExistingOutput { get { return this[nameof(bOverrideExistingOutput)].Flag; } set { this[nameof(bOverrideExistingOutput)].Flag = value; } }
        public int HandleFrameCount { get { return this[nameof(HandleFrameCount)].GetValue<int>(); } set { this[nameof(HandleFrameCount)].SetValue<int>(value); } }
        public int OutputFrameStep { get { return this[nameof(OutputFrameStep)].GetValue<int>(); } set { this[nameof(OutputFrameStep)].SetValue<int>(value); } }
        public bool bUseCustomPlaybackRange { get { return this[nameof(bUseCustomPlaybackRange)].Flag; } set { this[nameof(bUseCustomPlaybackRange)].Flag = value; } }
        public int CustomStartFrame { get { return this[nameof(CustomStartFrame)].GetValue<int>(); } set { this[nameof(CustomStartFrame)].SetValue<int>(value); } }
        public int CustomEndFrame { get { return this[nameof(CustomEndFrame)].GetValue<int>(); } set { this[nameof(CustomEndFrame)].SetValue<int>(value); } }
        public int VersionNumber { get { return this[nameof(VersionNumber)].GetValue<int>(); } set { this[nameof(VersionNumber)].SetValue<int>(value); } }
        public bool bAutoVersion { get { return this[nameof(bAutoVersion)].Flag; } set { this[nameof(bAutoVersion)].Flag = value; } }
        public int ZeroPadFrameNumbers { get { return this[nameof(ZeroPadFrameNumbers)].GetValue<int>(); } set { this[nameof(ZeroPadFrameNumbers)].SetValue<int>(value); } }
        public int FrameNumberOffset { get { return this[nameof(FrameNumberOffset)].GetValue<int>(); } set { this[nameof(FrameNumberOffset)].SetValue<int>(value); } }
        public bool bFlushDiskWritesPerShot { get { return this[nameof(bFlushDiskWritesPerShot)].Flag; } set { this[nameof(bFlushDiskWritesPerShot)].Flag = value; } }
    }
    public class MoviePipelinePythonHostExecutor : MoviePipelineExecutorBase
    {
        public MoviePipelinePythonHostExecutor(nint addr) : base(addr) { }
        public Object ExecutorClass { get { return this[nameof(ExecutorClass)]; } set { this[nameof(ExecutorClass)] = value; } }
        public MoviePipelineQueue PipelineQueue { get { return this[nameof(PipelineQueue)].As<MoviePipelineQueue>(); } set { this["PipelineQueue"] = value; } }
        public World LastLoadedWorld { get { return this[nameof(LastLoadedWorld)].As<World>(); } set { this["LastLoadedWorld"] = value; } }
        public void OnMapLoad(World InWorld) { Invoke(nameof(OnMapLoad), InWorld); }
        public World GetLastLoadedWorld() { return Invoke<World>(nameof(GetLastLoadedWorld)); }
        public void ExecuteDelayed(MoviePipelineQueue InPipelineQueue) { Invoke(nameof(ExecuteDelayed), InPipelineQueue); }
    }
    public class MoviePipelineExecutorShot : Object
    {
        public MoviePipelineExecutorShot(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Object OuterName { get { return this[nameof(OuterName)]; } set { this[nameof(OuterName)] = value; } }
        public Object InnerName { get { return this[nameof(InnerName)]; } set { this[nameof(InnerName)] = value; } }
        public Array<MoviePipelineSidecarCamera> SidecarCameras { get { return new Array<MoviePipelineSidecarCamera>(this[nameof(SidecarCameras)].Address); } }
        public float Progress { get { return this[nameof(Progress)].GetValue<float>(); } set { this[nameof(Progress)].SetValue<float>(value); } }
        public Object StatusMessage { get { return this[nameof(StatusMessage)]; } set { this[nameof(StatusMessage)] = value; } }
        public MoviePipelineShotConfig ShotOverrideConfig { get { return this[nameof(ShotOverrideConfig)].As<MoviePipelineShotConfig>(); } set { this["ShotOverrideConfig"] = value; } }
        public Object ShotOverridePresetOrigin { get { return this[nameof(ShotOverridePresetOrigin)]; } set { this[nameof(ShotOverridePresetOrigin)] = value; } }
        public bool ShouldRender() { return Invoke<bool>(nameof(ShouldRender)); }
        public void SetStatusProgress(float InProgress) { Invoke(nameof(SetStatusProgress), InProgress); }
        public void SetStatusMessage(Object InStatus) { Invoke(nameof(SetStatusMessage), InStatus); }
        public void SetShotOverridePresetOrigin(MoviePipelineShotConfig InPreset) { Invoke(nameof(SetShotOverridePresetOrigin), InPreset); }
        public void SetShotOverrideConfiguration(MoviePipelineShotConfig InPreset) { Invoke(nameof(SetShotOverrideConfiguration), InPreset); }
        public float GetStatusProgress() { return Invoke<float>(nameof(GetStatusProgress)); }
        public Object GetStatusMessage() { return Invoke<Object>(nameof(GetStatusMessage)); }
        public MoviePipelineShotConfig GetShotOverridePresetOrigin() { return Invoke<MoviePipelineShotConfig>(nameof(GetShotOverridePresetOrigin)); }
        public MoviePipelineShotConfig GetShotOverrideConfiguration() { return Invoke<MoviePipelineShotConfig>(nameof(GetShotOverrideConfiguration)); }
        public Object GetCameraName(int InCameraIndex) { return Invoke<Object>(nameof(GetCameraName), InCameraIndex); }
        public MoviePipelineShotConfig AllocateNewShotOverrideConfig(Object InConfigType) { return Invoke<MoviePipelineShotConfig>(nameof(AllocateNewShotOverrideConfig), InConfigType); }
    }
    public class MoviePipelineExecutorJob : Object
    {
        public MoviePipelineExecutorJob(nint addr) : base(addr) { }
        public Object JobName { get { return this[nameof(JobName)]; } set { this[nameof(JobName)] = value; } }
        public SoftObjectPath Sequence { get { return this[nameof(Sequence)].As<SoftObjectPath>(); } set { this["Sequence"] = value; } }
        public SoftObjectPath Map { get { return this[nameof(Map)].As<SoftObjectPath>(); } set { this["Map"] = value; } }
        public Object Author { get { return this[nameof(Author)]; } set { this[nameof(Author)] = value; } }
        public Object Comment { get { return this[nameof(Comment)]; } set { this[nameof(Comment)] = value; } }
        public Array<MoviePipelineExecutorShot> ShotInfo { get { return new Array<MoviePipelineExecutorShot>(this[nameof(ShotInfo)].Address); } }
        public Object UserData { get { return this[nameof(UserData)]; } set { this[nameof(UserData)] = value; } }
        public Object StatusMessage { get { return this[nameof(StatusMessage)]; } set { this[nameof(StatusMessage)] = value; } }
        public float StatusProgress { get { return this[nameof(StatusProgress)].GetValue<float>(); } set { this[nameof(StatusProgress)].SetValue<float>(value); } }
        public bool bIsConsumed { get { return this[nameof(bIsConsumed)].Flag; } set { this[nameof(bIsConsumed)].Flag = value; } }
        public MoviePipelineMasterConfig Configuration { get { return this[nameof(Configuration)].As<MoviePipelineMasterConfig>(); } set { this["Configuration"] = value; } }
        public Object PresetOrigin { get { return this[nameof(PresetOrigin)]; } set { this[nameof(PresetOrigin)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public void SetStatusProgress(float InProgress) { Invoke(nameof(SetStatusProgress), InProgress); }
        public void SetStatusMessage(Object InStatus) { Invoke(nameof(SetStatusMessage), InStatus); }
        public void SetSequence(SoftObjectPath InSequence) { Invoke(nameof(SetSequence), InSequence); }
        public void SetPresetOrigin(MoviePipelineMasterConfig InPreset) { Invoke(nameof(SetPresetOrigin), InPreset); }
        public void SetIsEnabled(bool bInEnabled) { Invoke(nameof(SetIsEnabled), bInEnabled); }
        public void SetConsumed(bool bInConsumed) { Invoke(nameof(SetConsumed), bInConsumed); }
        public void SetConfiguration(MoviePipelineMasterConfig InPreset) { Invoke(nameof(SetConfiguration), InPreset); }
        public void OnDuplicated() { Invoke(nameof(OnDuplicated)); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public bool IsConsumed() { return Invoke<bool>(nameof(IsConsumed)); }
        public float GetStatusProgress() { return Invoke<float>(nameof(GetStatusProgress)); }
        public Object GetStatusMessage() { return Invoke<Object>(nameof(GetStatusMessage)); }
        public MoviePipelineMasterConfig GetPresetOrigin() { return Invoke<MoviePipelineMasterConfig>(nameof(GetPresetOrigin)); }
        public MoviePipelineMasterConfig GetConfiguration() { return Invoke<MoviePipelineMasterConfig>(nameof(GetConfiguration)); }
    }
    public class MoviePipelineQueue : Object
    {
        public MoviePipelineQueue(nint addr) : base(addr) { }
        public Array<MoviePipelineExecutorJob> Jobs { get { return new Array<MoviePipelineExecutorJob>(this[nameof(Jobs)].Address); } }
        public void SetJobIndex(MoviePipelineExecutorJob InJob, int Index) { Invoke(nameof(SetJobIndex), InJob, Index); }
        public Array<MoviePipelineExecutorJob> GetJobs() { return Invoke<Array<MoviePipelineExecutorJob>>(nameof(GetJobs)); }
        public MoviePipelineExecutorJob DuplicateJob(MoviePipelineExecutorJob InJob) { return Invoke<MoviePipelineExecutorJob>(nameof(DuplicateJob), InJob); }
        public void DeleteJob(MoviePipelineExecutorJob InJob) { Invoke(nameof(DeleteJob), InJob); }
        public void DeleteAllJobs() { Invoke(nameof(DeleteAllJobs)); }
        public void CopyFrom(MoviePipelineQueue InQueue) { Invoke(nameof(CopyFrom), InQueue); }
        public MoviePipelineExecutorJob AllocateNewJob(Object InJobType) { return Invoke<MoviePipelineExecutorJob>(nameof(AllocateNewJob), InJobType); }
    }
    public class MoviePipelineQueueEngineSubsystem : EngineSubsystem
    {
        public MoviePipelineQueueEngineSubsystem(nint addr) : base(addr) { }
        public Object OnRenderFinished { get { return this[nameof(OnRenderFinished)]; } set { this[nameof(OnRenderFinished)] = value; } }
        public MoviePipelineExecutorBase ActiveExecutor { get { return this[nameof(ActiveExecutor)].As<MoviePipelineExecutorBase>(); } set { this["ActiveExecutor"] = value; } }
        public MoviePipelineQueue CurrentQueue { get { return this[nameof(CurrentQueue)].As<MoviePipelineQueue>(); } set { this["CurrentQueue"] = value; } }
        public void SetConfiguration(Object InProgressWidgetClass, bool bRenderPlayerViewport) { Invoke(nameof(SetConfiguration), InProgressWidgetClass, bRenderPlayerViewport); }
        public void RenderQueueWithExecutorInstance(MoviePipelineExecutorBase InExecutor) { Invoke(nameof(RenderQueueWithExecutorInstance), InExecutor); }
        public MoviePipelineExecutorBase RenderQueueWithExecutor(Object InExecutorType) { return Invoke<MoviePipelineExecutorBase>(nameof(RenderQueueWithExecutor), InExecutorType); }
        public void RenderJob(MoviePipelineExecutorJob InJob) { Invoke(nameof(RenderJob), InJob); }
        public bool IsRendering() { return Invoke<bool>(nameof(IsRendering)); }
        public MoviePipelineQueue GetQueue() { return Invoke<MoviePipelineQueue>(nameof(GetQueue)); }
        public MoviePipelineExecutorBase GetActiveExecutor() { return Invoke<MoviePipelineExecutorBase>(nameof(GetActiveExecutor)); }
        public MoviePipelineExecutorJob AllocateJob(LevelSequence InSequence) { return Invoke<MoviePipelineExecutorJob>(nameof(AllocateJob), InSequence); }
    }
    public class MoviePipelineRenderPass : MoviePipelineSetting
    {
        public MoviePipelineRenderPass(nint addr) : base(addr) { }
    }
    public class MoviePipelineShotConfig : MoviePipelineConfigBase
    {
        public MoviePipelineShotConfig(nint addr) : base(addr) { }
    }
    public class MoviePipelineVideoOutputBase : MoviePipelineOutputBase
    {
        public MoviePipelineVideoOutputBase(nint addr) : base(addr) { }
    }
    public class MoviePipelineOutputData : Object
    {
        public MoviePipelineOutputData(nint addr) : base(addr) { }
        public MoviePipeline Pipeline { get { return this[nameof(Pipeline)].As<MoviePipeline>(); } set { this["Pipeline"] = value; } }
        public MoviePipelineExecutorJob Job { get { return this[nameof(Job)].As<MoviePipelineExecutorJob>(); } set { this["Job"] = value; } }
        public bool bSuccess { get { return this[nameof(bSuccess)].Flag; } set { this[nameof(bSuccess)].Flag = value; } }
        public Array<MoviePipelineShotOutputData> ShotData { get { return new Array<MoviePipelineShotOutputData>(this[nameof(ShotData)].Address); } }
    }
    public class MoviePipelineShotOutputData : Object
    {
        public MoviePipelineShotOutputData(nint addr) : base(addr) { }
        public Object Shot { get { return this[nameof(Shot)]; } set { this[nameof(Shot)] = value; } }
        public Object RenderPassData { get { return this[nameof(RenderPassData)]; } set { this[nameof(RenderPassData)] = value; } }
    }
    public class MoviePipelinePassIdentifier : Object
    {
        public MoviePipelinePassIdentifier(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object CameraName { get { return this[nameof(CameraName)]; } set { this[nameof(CameraName)] = value; } }
    }
    public class MoviePipelineRenderPassOutputData : Object
    {
        public MoviePipelineRenderPassOutputData(nint addr) : base(addr) { }
        public Array<Object> FilePaths { get { return new Array<Object>(this[nameof(FilePaths)].Address); } }
    }
    public enum EMoviePipelineEncodeQuality : int
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Epic = 3,
        EMoviePipelineEncodeQuality_MAX = 4,
    }
    public enum FCPXMLExportDataSource : int
    {
        OutputMetadata = 0,
        SequenceData = 1,
        FCPXMLExportDataSource_MAX = 2,
    }
    public enum EMoviePipelineTextureStreamingMethod : int
    {
        None = 0,
        Disabled = 1,
        FullyLoad = 2,
        EMoviePipelineTextureStreamingMethod_MAX = 3,
    }
    public enum EMovieRenderPipelineState : int
    {
        Uninitialized = 0,
        ProducingFrames = 1,
        Finalize = 2,
        Export = 3,
        Finished = 4,
        EMovieRenderPipelineState_MAX = 5,
    }
    public enum EMovieRenderShotState : int
    {
        Uninitialized = 0,
        WarmingUp = 1,
        MotionBlur = 2,
        Rendering = 3,
        Finished = 4,
        EMovieRenderShotState_MAX = 5,
    }
    public enum EMoviePipelineShutterTiming : int
    {
        FrameOpen = 0,
        FrameCenter = 1,
        FrameClose = 2,
        EMoviePipelineShutterTiming_MAX = 3,
    }
    public class MoviePipelineSidecarCamera : Object
    {
        public MoviePipelineSidecarCamera(nint addr) : base(addr) { }
        public Guid BindingId { get { return this[nameof(BindingId)].As<Guid>(); } set { this["BindingId"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class MoviePipelineSegmentWorkMetrics : Object
    {
        public MoviePipelineSegmentWorkMetrics(nint addr) : base(addr) { }
        public Object SegmentName { get { return this[nameof(SegmentName)]; } set { this[nameof(SegmentName)] = value; } }
        public int OutputFrameIndex { get { return this[nameof(OutputFrameIndex)].GetValue<int>(); } set { this[nameof(OutputFrameIndex)].SetValue<int>(value); } }
        public int TotalOutputFrameCount { get { return this[nameof(TotalOutputFrameCount)].GetValue<int>(); } set { this[nameof(TotalOutputFrameCount)].SetValue<int>(value); } }
        public int OutputSubSampleIndex { get { return this[nameof(OutputSubSampleIndex)].GetValue<int>(); } set { this[nameof(OutputSubSampleIndex)].SetValue<int>(value); } }
        public int TotalSubSampleCount { get { return this[nameof(TotalSubSampleCount)].GetValue<int>(); } set { this[nameof(TotalSubSampleCount)].SetValue<int>(value); } }
        public int EngineWarmUpFrameIndex { get { return this[nameof(EngineWarmUpFrameIndex)].GetValue<int>(); } set { this[nameof(EngineWarmUpFrameIndex)].SetValue<int>(value); } }
        public int TotalEngineWarmUpFrameCount { get { return this[nameof(TotalEngineWarmUpFrameCount)].GetValue<int>(); } set { this[nameof(TotalEngineWarmUpFrameCount)].SetValue<int>(value); } }
    }
    public class MoviePipelineCameraCutInfo : Object
    {
        public MoviePipelineCameraCutInfo(nint addr) : base(addr) { }
    }
    public class MoviePipelineFormatArgs : Object
    {
        public MoviePipelineFormatArgs(nint addr) : base(addr) { }
        public Object FilenameArguments { get { return this[nameof(FilenameArguments)]; } set { this[nameof(FilenameArguments)] = value; } }
        public Object FileMetadata { get { return this[nameof(FileMetadata)]; } set { this[nameof(FileMetadata)] = value; } }
        public MoviePipelineExecutorJob InJob { get { return this[nameof(InJob)].As<MoviePipelineExecutorJob>(); } set { this["InJob"] = value; } }
    }
    public class MoviePipelineFilenameResolveParams : Object
    {
        public MoviePipelineFilenameResolveParams(nint addr) : base(addr) { }
        public int FrameNumber { get { return this[nameof(FrameNumber)].GetValue<int>(); } set { this[nameof(FrameNumber)].SetValue<int>(value); } }
        public int FrameNumberShot { get { return this[nameof(FrameNumberShot)].GetValue<int>(); } set { this[nameof(FrameNumberShot)].SetValue<int>(value); } }
        public int FrameNumberRel { get { return this[nameof(FrameNumberRel)].GetValue<int>(); } set { this[nameof(FrameNumberRel)].SetValue<int>(value); } }
        public int FrameNumberShotRel { get { return this[nameof(FrameNumberShotRel)].GetValue<int>(); } set { this[nameof(FrameNumberShotRel)].SetValue<int>(value); } }
        public Object CameraNameOverride { get { return this[nameof(CameraNameOverride)]; } set { this[nameof(CameraNameOverride)] = value; } }
        public Object ShotNameOverride { get { return this[nameof(ShotNameOverride)]; } set { this[nameof(ShotNameOverride)] = value; } }
        public int ZeroPadFrameNumberCount { get { return this[nameof(ZeroPadFrameNumberCount)].GetValue<int>(); } set { this[nameof(ZeroPadFrameNumberCount)].SetValue<int>(value); } }
        public bool bForceRelativeFrameNumbers { get { return this[nameof(bForceRelativeFrameNumbers)].Flag; } set { this[nameof(bForceRelativeFrameNumbers)].Flag = value; } }
        public Object FileNameOverride { get { return this[nameof(FileNameOverride)]; } set { this[nameof(FileNameOverride)] = value; } }
        public Object FileNameFormatOverrides { get { return this[nameof(FileNameFormatOverrides)]; } set { this[nameof(FileNameFormatOverrides)] = value; } }
        public Object FileMetadata { get { return this[nameof(FileMetadata)]; } set { this[nameof(FileMetadata)] = value; } }
        public DateTime InitializationTime { get { return this[nameof(InitializationTime)].As<DateTime>(); } set { this["InitializationTime"] = value; } }
        public int InitializationVersion { get { return this[nameof(InitializationVersion)].GetValue<int>(); } set { this[nameof(InitializationVersion)].SetValue<int>(value); } }
        public MoviePipelineExecutorJob Job { get { return this[nameof(Job)].As<MoviePipelineExecutorJob>(); } set { this["Job"] = value; } }
        public MoviePipelineExecutorShot ShotOverride { get { return this[nameof(ShotOverride)].As<MoviePipelineExecutorShot>(); } set { this["ShotOverride"] = value; } }
        public int AdditionalFrameNumberOffset { get { return this[nameof(AdditionalFrameNumberOffset)].GetValue<int>(); } set { this[nameof(AdditionalFrameNumberOffset)].SetValue<int>(value); } }
    }
}
