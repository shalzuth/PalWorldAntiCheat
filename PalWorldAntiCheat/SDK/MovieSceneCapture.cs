using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.ImageWriteQueueSDK;
namespace SDK.Script.MovieSceneCaptureSDK
{
    public class MovieSceneCaptureProtocolBase : Object
    {
        public MovieSceneCaptureProtocolBase(nint addr) : base(addr) { }
        public EMovieSceneCaptureProtocolState State { get { return (EMovieSceneCaptureProtocolState)this[nameof(State)].GetValue<int>(); } set { this[nameof(State)].SetValue<int>((int)value); } }
        public bool IsCapturing() { return Invoke<bool>(nameof(IsCapturing)); }
        public EMovieSceneCaptureProtocolState GetState() { return Invoke<EMovieSceneCaptureProtocolState>(nameof(GetState)); }
    }
    public class MovieSceneAudioCaptureProtocolBase : MovieSceneCaptureProtocolBase
    {
        public MovieSceneAudioCaptureProtocolBase(nint addr) : base(addr) { }
    }
    public class NullAudioCaptureProtocol : MovieSceneAudioCaptureProtocolBase
    {
        public NullAudioCaptureProtocol(nint addr) : base(addr) { }
    }
    public class MasterAudioSubmixCaptureProtocol : MovieSceneAudioCaptureProtocolBase
    {
        public MasterAudioSubmixCaptureProtocol(nint addr) : base(addr) { }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
    }
    public class MovieSceneImageCaptureProtocolBase : MovieSceneCaptureProtocolBase
    {
        public MovieSceneImageCaptureProtocolBase(nint addr) : base(addr) { }
    }
    public class CompositionGraphCaptureProtocol : MovieSceneImageCaptureProtocolBase
    {
        public CompositionGraphCaptureProtocol(nint addr) : base(addr) { }
        public CompositionGraphCapturePasses IncludeRenderPasses { get { return this[nameof(IncludeRenderPasses)].As<CompositionGraphCapturePasses>(); } set { this["IncludeRenderPasses"] = value; } }
        public bool bCaptureFramesInHDR { get { return this[nameof(bCaptureFramesInHDR)].Flag; } set { this[nameof(bCaptureFramesInHDR)].Flag = value; } }
        public int HDRCompressionQuality { get { return this[nameof(HDRCompressionQuality)].GetValue<int>(); } set { this[nameof(HDRCompressionQuality)].SetValue<int>(value); } }
        public byte CaptureGamut { get { return this[nameof(CaptureGamut)].GetValue<byte>(); } set { this[nameof(CaptureGamut)].SetValue<byte>(value); } }
        public SoftObjectPath PostProcessingMaterial { get { return this[nameof(PostProcessingMaterial)].As<SoftObjectPath>(); } set { this["PostProcessingMaterial"] = value; } }
        public bool bDisableScreenPercentage { get { return this[nameof(bDisableScreenPercentage)].Flag; } set { this[nameof(bDisableScreenPercentage)].Flag = value; } }
        public MaterialInterface PostProcessingMaterialPtr { get { return this[nameof(PostProcessingMaterialPtr)].As<MaterialInterface>(); } set { this["PostProcessingMaterialPtr"] = value; } }
    }
    public class MovieSceneCaptureInterface : Interface
    {
        public MovieSceneCaptureInterface(nint addr) : base(addr) { }
    }
    public class FrameGrabberProtocol : MovieSceneImageCaptureProtocolBase
    {
        public FrameGrabberProtocol(nint addr) : base(addr) { }
    }
    public class ImageSequenceProtocol : FrameGrabberProtocol
    {
        public ImageSequenceProtocol(nint addr) : base(addr) { }
    }
    public class CompressedImageSequenceProtocol : ImageSequenceProtocol
    {
        public CompressedImageSequenceProtocol(nint addr) : base(addr) { }
        public int CompressionQuality { get { return this[nameof(CompressionQuality)].GetValue<int>(); } set { this[nameof(CompressionQuality)].SetValue<int>(value); } }
    }
    public class ImageSequenceProtocol_BMP : ImageSequenceProtocol
    {
        public ImageSequenceProtocol_BMP(nint addr) : base(addr) { }
    }
    public class ImageSequenceProtocol_PNG : CompressedImageSequenceProtocol
    {
        public ImageSequenceProtocol_PNG(nint addr) : base(addr) { }
    }
    public class ImageSequenceProtocol_JPG : CompressedImageSequenceProtocol
    {
        public ImageSequenceProtocol_JPG(nint addr) : base(addr) { }
    }
    public class ImageSequenceProtocol_EXR : ImageSequenceProtocol
    {
        public ImageSequenceProtocol_EXR(nint addr) : base(addr) { }
        public bool bCompressed { get { return this[nameof(bCompressed)].Flag; } set { this[nameof(bCompressed)].Flag = value; } }
        public byte CaptureGamut { get { return this[nameof(CaptureGamut)].GetValue<byte>(); } set { this[nameof(CaptureGamut)].SetValue<byte>(value); } }
    }
    public class MovieSceneCapture : Object
    {
        public MovieSceneCapture(nint addr) : base(addr) { }
        public SoftClassPath ImageCaptureProtocolType { get { return this[nameof(ImageCaptureProtocolType)].As<SoftClassPath>(); } set { this["ImageCaptureProtocolType"] = value; } }
        public SoftClassPath AudioCaptureProtocolType { get { return this[nameof(AudioCaptureProtocolType)].As<SoftClassPath>(); } set { this["AudioCaptureProtocolType"] = value; } }
        public MovieSceneImageCaptureProtocolBase ImageCaptureProtocol { get { return this[nameof(ImageCaptureProtocol)].As<MovieSceneImageCaptureProtocolBase>(); } set { this["ImageCaptureProtocol"] = value; } }
        public MovieSceneAudioCaptureProtocolBase AudioCaptureProtocol { get { return this[nameof(AudioCaptureProtocol)].As<MovieSceneAudioCaptureProtocolBase>(); } set { this["AudioCaptureProtocol"] = value; } }
        public MovieSceneCaptureSettings Settings { get { return this[nameof(Settings)].As<MovieSceneCaptureSettings>(); } set { this["Settings"] = value; } }
        public bool bUseSeparateProcess { get { return this[nameof(bUseSeparateProcess)].Flag; } set { this[nameof(bUseSeparateProcess)].Flag = value; } }
        public bool bCloseEditorWhenCaptureStarts { get { return this[nameof(bCloseEditorWhenCaptureStarts)].Flag; } set { this[nameof(bCloseEditorWhenCaptureStarts)].Flag = value; } }
        public Object AdditionalCommandLineArguments { get { return this[nameof(AdditionalCommandLineArguments)]; } set { this[nameof(AdditionalCommandLineArguments)] = value; } }
        public Object InheritedCommandLineArguments { get { return this[nameof(InheritedCommandLineArguments)]; } set { this[nameof(InheritedCommandLineArguments)] = value; } }
        public void SetImageCaptureProtocolType(Object ProtocolType) { Invoke(nameof(SetImageCaptureProtocolType), ProtocolType); }
        public void SetAudioCaptureProtocolType(Object ProtocolType) { Invoke(nameof(SetAudioCaptureProtocolType), ProtocolType); }
        public MovieSceneCaptureProtocolBase GetImageCaptureProtocol() { return Invoke<MovieSceneCaptureProtocolBase>(nameof(GetImageCaptureProtocol)); }
        public MovieSceneCaptureProtocolBase GetAudioCaptureProtocol() { return Invoke<MovieSceneCaptureProtocolBase>(nameof(GetAudioCaptureProtocol)); }
    }
    public class LevelCapture : MovieSceneCapture
    {
        public LevelCapture(nint addr) : base(addr) { }
        public bool bAutoStartCapture { get { return this[nameof(bAutoStartCapture)].Flag; } set { this[nameof(bAutoStartCapture)].Flag = value; } }
        public Guid PrerequisiteActorId { get { return this[nameof(PrerequisiteActorId)].As<Guid>(); } set { this["PrerequisiteActorId"] = value; } }
    }
    public class MovieSceneCaptureEnvironment : Object
    {
        public MovieSceneCaptureEnvironment(nint addr) : base(addr) { }
        public bool IsCaptureInProgress() { return Invoke<bool>(nameof(IsCaptureInProgress)); }
        public int GetCaptureFrameNumber() { return Invoke<int>(nameof(GetCaptureFrameNumber)); }
        public float GetCaptureElapsedTime() { return Invoke<float>(nameof(GetCaptureElapsedTime)); }
        public MovieSceneImageCaptureProtocolBase FindImageCaptureProtocol() { return Invoke<MovieSceneImageCaptureProtocolBase>(nameof(FindImageCaptureProtocol)); }
        public MovieSceneAudioCaptureProtocolBase FindAudioCaptureProtocol() { return Invoke<MovieSceneAudioCaptureProtocolBase>(nameof(FindAudioCaptureProtocol)); }
    }
    public class UserDefinedCaptureProtocol : MovieSceneImageCaptureProtocolBase
    {
        public UserDefinedCaptureProtocol(nint addr) : base(addr) { }
        public World World { get { return this[nameof(World)].As<World>(); } set { this["World"] = value; } }
        public void StopCapturingFinalPixels() { Invoke(nameof(StopCapturingFinalPixels)); }
        public void StartCapturingFinalPixels(CapturedPixelsID StreamID) { Invoke(nameof(StartCapturingFinalPixels), StreamID); }
        public void ResolveBuffer(Texture Buffer, CapturedPixelsID BufferID) { Invoke(nameof(ResolveBuffer), Buffer, BufferID); }
        public void OnWarmUp() { Invoke(nameof(OnWarmUp)); }
        public void OnTick() { Invoke(nameof(OnTick)); }
        public void OnStartCapture() { Invoke(nameof(OnStartCapture)); }
        public bool OnSetup() { return Invoke<bool>(nameof(OnSetup)); }
        public void OnPreTick() { Invoke(nameof(OnPreTick)); }
        public void OnPixelsReceived(CapturedPixels Pixels, CapturedPixelsID ID, FrameMetrics FrameMetrics) { Invoke(nameof(OnPixelsReceived), Pixels, ID, FrameMetrics); }
        public void OnPauseCapture() { Invoke(nameof(OnPauseCapture)); }
        public void OnFinalize() { Invoke(nameof(OnFinalize)); }
        public void OnCaptureFrame() { Invoke(nameof(OnCaptureFrame)); }
        public bool OnCanFinalize() { return Invoke<bool>(nameof(OnCanFinalize)); }
        public void OnBeginFinalize() { Invoke(nameof(OnBeginFinalize)); }
        public FrameMetrics GetCurrentFrameMetrics() { return Invoke<FrameMetrics>(nameof(GetCurrentFrameMetrics)); }
        public Object GenerateFilename(FrameMetrics InFrameMetrics) { return Invoke<Object>(nameof(GenerateFilename), InFrameMetrics); }
    }
    public class UserDefinedImageCaptureProtocol : UserDefinedCaptureProtocol
    {
        public UserDefinedImageCaptureProtocol(nint addr) : base(addr) { }
        public EDesiredImageFormat Format { get { return (EDesiredImageFormat)this[nameof(Format)].GetValue<int>(); } set { this[nameof(Format)].SetValue<int>((int)value); } }
        public bool bEnableCompression { get { return this[nameof(bEnableCompression)].Flag; } set { this[nameof(bEnableCompression)].Flag = value; } }
        public int CompressionQuality { get { return this[nameof(CompressionQuality)].GetValue<int>(); } set { this[nameof(CompressionQuality)].SetValue<int>(value); } }
        public void WriteImageToDisk(CapturedPixels PixelData, CapturedPixelsID StreamID, FrameMetrics FrameMetrics, bool bCopyImageData) { Invoke(nameof(WriteImageToDisk), PixelData, StreamID, FrameMetrics, bCopyImageData); }
        public Object GenerateFilenameForCurrentFrame() { return Invoke<Object>(nameof(GenerateFilenameForCurrentFrame)); }
        public Object GenerateFilenameForBuffer(Texture Buffer, CapturedPixelsID StreamID) { return Invoke<Object>(nameof(GenerateFilenameForBuffer), Buffer, StreamID); }
    }
    public class VideoCaptureProtocol : FrameGrabberProtocol
    {
        public VideoCaptureProtocol(nint addr) : base(addr) { }
        public bool bUseCompression { get { return this[nameof(bUseCompression)].Flag; } set { this[nameof(bUseCompression)].Flag = value; } }
        public float CompressionQuality { get { return this[nameof(CompressionQuality)].GetValue<float>(); } set { this[nameof(CompressionQuality)].SetValue<float>(value); } }
    }
    public enum EHDRCaptureGamut : int
    {
        HCGM_Rec709 = 0,
        HCGM_P3DCI = 1,
        HCGM_Rec2020 = 2,
        HCGM_ACES = 3,
        HCGM_ACEScg = 4,
        HCGM_Linear = 5,
        HCGM_MAX = 6,
    }
    public enum EMovieSceneCaptureProtocolState : int
    {
        Idle = 0,
        Initialized = 1,
        Capturing = 2,
        Finalizing = 3,
        EMovieSceneCaptureProtocolState_MAX = 4,
    }
    public class CompositionGraphCapturePasses : Object
    {
        public CompositionGraphCapturePasses(nint addr) : base(addr) { }
        public Array<Object> Value { get { return new Array<Object>(this[nameof(Value)].Address); } }
    }
    public class CaptureResolution : Object
    {
        public CaptureResolution(nint addr) : base(addr) { }
        public int ResX { get { return this[nameof(ResX)].GetValue<int>(); } set { this[nameof(ResX)].SetValue<int>(value); } }
        public int ResY { get { return this[nameof(ResY)].GetValue<int>(); } set { this[nameof(ResY)].SetValue<int>(value); } }
    }
    public class MovieSceneCaptureSettings : Object
    {
        public MovieSceneCaptureSettings(nint addr) : base(addr) { }
        public DirectoryPath OutputDirectory { get { return this[nameof(OutputDirectory)].As<DirectoryPath>(); } set { this["OutputDirectory"] = value; } }
        public Object GameModeOverride { get { return this[nameof(GameModeOverride)]; } set { this[nameof(GameModeOverride)] = value; } }
        public Object OutputFormat { get { return this[nameof(OutputFormat)]; } set { this[nameof(OutputFormat)] = value; } }
        public bool bOverwriteExisting { get { return this[nameof(bOverwriteExisting)].Flag; } set { this[nameof(bOverwriteExisting)].Flag = value; } }
        public bool bUseRelativeFrameNumbers { get { return this[nameof(bUseRelativeFrameNumbers)].Flag; } set { this[nameof(bUseRelativeFrameNumbers)].Flag = value; } }
        public int HandleFrames { get { return this[nameof(HandleFrames)].GetValue<int>(); } set { this[nameof(HandleFrames)].SetValue<int>(value); } }
        public Object MovieExtension { get { return this[nameof(MovieExtension)]; } set { this[nameof(MovieExtension)] = value; } }
        public byte ZeroPadFrameNumbers { get { return this[nameof(ZeroPadFrameNumbers)].GetValue<byte>(); } set { this[nameof(ZeroPadFrameNumbers)].SetValue<byte>(value); } }
        public FrameRate FrameRate { get { return this[nameof(FrameRate)].As<FrameRate>(); } set { this["FrameRate"] = value; } }
        public bool bUseCustomFrameRate { get { return this[nameof(bUseCustomFrameRate)].Flag; } set { this[nameof(bUseCustomFrameRate)].Flag = value; } }
        public FrameRate CustomFrameRate { get { return this[nameof(CustomFrameRate)].As<FrameRate>(); } set { this["CustomFrameRate"] = value; } }
        public CaptureResolution Resolution { get { return this[nameof(Resolution)].As<CaptureResolution>(); } set { this["Resolution"] = value; } }
        public bool bEnableTextureStreaming { get { return this[nameof(bEnableTextureStreaming)].Flag; } set { this[nameof(bEnableTextureStreaming)].Flag = value; } }
        public bool bCinematicEngineScalability { get { return this[nameof(bCinematicEngineScalability)].Flag; } set { this[nameof(bCinematicEngineScalability)].Flag = value; } }
        public bool bCinematicMode { get { return this[nameof(bCinematicMode)].Flag; } set { this[nameof(bCinematicMode)].Flag = value; } }
        public bool bAllowMovement { get { return this[nameof(bAllowMovement)].Flag; } set { this[nameof(bAllowMovement)].Flag = value; } }
        public bool bAllowTurning { get { return this[nameof(bAllowTurning)].Flag; } set { this[nameof(bAllowTurning)].Flag = value; } }
        public bool bShowPlayer { get { return this[nameof(bShowPlayer)].Flag; } set { this[nameof(bShowPlayer)].Flag = value; } }
        public bool bShowHUD { get { return this[nameof(bShowHUD)].Flag; } set { this[nameof(bShowHUD)].Flag = value; } }
        public bool bUsePathTracer { get { return this[nameof(bUsePathTracer)].Flag; } set { this[nameof(bUsePathTracer)].Flag = value; } }
        public int PathTracerSamplePerPixel { get { return this[nameof(PathTracerSamplePerPixel)].GetValue<int>(); } set { this[nameof(PathTracerSamplePerPixel)].SetValue<int>(value); } }
    }
    public class FrameMetrics : Object
    {
        public FrameMetrics(nint addr) : base(addr) { }
        public float TotalElapsedTime { get { return this[nameof(TotalElapsedTime)].GetValue<float>(); } set { this[nameof(TotalElapsedTime)].SetValue<float>(value); } }
        public float FrameDelta { get { return this[nameof(FrameDelta)].GetValue<float>(); } set { this[nameof(FrameDelta)].SetValue<float>(value); } }
        public int FrameNumber { get { return this[nameof(FrameNumber)].GetValue<int>(); } set { this[nameof(FrameNumber)].SetValue<int>(value); } }
        public int NumDroppedFrames { get { return this[nameof(NumDroppedFrames)].GetValue<int>(); } set { this[nameof(NumDroppedFrames)].SetValue<int>(value); } }
    }
    public class CapturedPixelsID : Object
    {
        public CapturedPixelsID(nint addr) : base(addr) { }
        public Object Identifiers { get { return this[nameof(Identifiers)]; } set { this[nameof(Identifiers)] = value; } }
    }
    public class CapturedPixels : Object
    {
        public CapturedPixels(nint addr) : base(addr) { }
    }
}
