using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ImageWriteQueueSDK;
namespace SDK.Script.MediaIOCoreSDK
{
    public class MediaCapture : Object
    {
        public MediaCapture(nint addr) : base(addr) { }
        public Object OnStateChanged { get { return this[nameof(OnStateChanged)]; } set { this[nameof(OnStateChanged)] = value; } }
        public MediaOutput MediaOutput { get { return this[nameof(MediaOutput)].As<MediaOutput>(); } set { this["MediaOutput"] = value; } }
        public TextureRenderTarget2D CapturingRenderTarget { get { return this[nameof(CapturingRenderTarget)].As<TextureRenderTarget2D>(); } set { this["CapturingRenderTarget"] = value; } }
        public bool UpdateTextureRenderTarget2D(TextureRenderTarget2D RenderTarget) { return Invoke<bool>(nameof(UpdateTextureRenderTarget2D), RenderTarget); }
        public void StopCapture(bool bAllowPendingFrameToBeProcess) { Invoke(nameof(StopCapture), bAllowPendingFrameToBeProcess); }
        public void SetMediaOutput(MediaOutput InMediaOutput) { Invoke(nameof(SetMediaOutput), InMediaOutput); }
        public EMediaCaptureState GetState() { return Invoke<EMediaCaptureState>(nameof(GetState)); }
        public IntPoint GetDesiredSize() { return Invoke<IntPoint>(nameof(GetDesiredSize)); }
        public byte GetDesiredPixelFormat() { return Invoke<byte>(nameof(GetDesiredPixelFormat)); }
        public bool CaptureTextureRenderTarget2D(TextureRenderTarget2D RenderTarget, MediaCaptureOptions CaptureOptions) { return Invoke<bool>(nameof(CaptureTextureRenderTarget2D), RenderTarget, CaptureOptions); }
        public bool CaptureActiveSceneViewport(MediaCaptureOptions CaptureOptions) { return Invoke<bool>(nameof(CaptureActiveSceneViewport), CaptureOptions); }
    }
    public class FileMediaCapture : MediaCapture
    {
        public FileMediaCapture(nint addr) : base(addr) { }
    }
    public class MediaOutput : Object
    {
        public MediaOutput(nint addr) : base(addr) { }
        public int NumberOfTextureBuffers { get { return this[nameof(NumberOfTextureBuffers)].GetValue<int>(); } set { this[nameof(NumberOfTextureBuffers)].SetValue<int>(value); } }
        public bool Validate(Object OutFailureReason) { return Invoke<bool>(nameof(Validate), OutFailureReason); }
        public MediaCapture CreateMediaCapture() { return Invoke<MediaCapture>(nameof(CreateMediaCapture)); }
    }
    public class FileMediaOutput : MediaOutput
    {
        public FileMediaOutput(nint addr) : base(addr) { }
        public ImageWriteOptions WriteOptions { get { return this[nameof(WriteOptions)].As<ImageWriteOptions>(); } set { this["WriteOptions"] = value; } }
        public DirectoryPath FilePath { get { return this[nameof(FilePath)].As<DirectoryPath>(); } set { this["FilePath"] = value; } }
        public Object BaseFileName { get { return this[nameof(BaseFileName)]; } set { this[nameof(BaseFileName)] = value; } }
        public bool bOverrideDesiredSize { get { return this[nameof(bOverrideDesiredSize)].Flag; } set { this[nameof(bOverrideDesiredSize)].Flag = value; } }
        public IntPoint DesiredSize { get { return this[nameof(DesiredSize)].As<IntPoint>(); } set { this["DesiredSize"] = value; } }
        public bool bOverridePixelFormat { get { return this[nameof(bOverridePixelFormat)].Flag; } set { this[nameof(bOverridePixelFormat)].Flag = value; } }
        public EFileMediaOutputPixelFormat DesiredPixelFormat { get { return (EFileMediaOutputPixelFormat)this[nameof(DesiredPixelFormat)].GetValue<int>(); } set { this[nameof(DesiredPixelFormat)].SetValue<int>((int)value); } }
        public bool bInvertAlpha { get { return this[nameof(bInvertAlpha)].Flag; } set { this[nameof(bInvertAlpha)].Flag = value; } }
    }
    public class MediaIOCoreSubsystem : EngineSubsystem
    {
        public MediaIOCoreSubsystem(nint addr) : base(addr) { }
    }
    public enum EFileMediaOutputPixelFormat : int
    {
        B8G8R8A8 = 0,
        FloatRGBA = 1,
        EFileMediaOutputPixelFormat_MAX = 2,
    }
    public enum EMediaCaptureState : int
    {
        Error = 0,
        Capturing = 1,
        Preparing = 2,
        StopRequested = 3,
        Stopped = 4,
        EMediaCaptureState_MAX = 5,
    }
    public enum EMediaCaptureResourceType : int
    {
        Texture = 0,
        Buffer = 1,
        EMediaCaptureResourceType_MAX = 2,
    }
    public enum EMediaCaptureCroppingType : int
    {
        None = 0,
        Center = 1,
        TopLeft = 2,
        Custom = 3,
        EMediaCaptureCroppingType_MAX = 4,
    }
    public enum EMediaCaptureOverrunAction : int
    {
        Flush = 0,
        Skip = 1,
        EMediaCaptureOverrunAction_MAX = 2,
    }
    public enum EMediaIOTransportType : int
    {
        SingleLink = 0,
        DualLink = 1,
        QuadLink = 2,
        HDMI = 3,
        EMediaIOTransportType_MAX = 4,
    }
    public enum EMediaIOQuadLinkTransportType : int
    {
        SquareDivision = 0,
        TwoSampleInterleave = 1,
        EMediaIOQuadLinkTransportType_MAX = 2,
    }
    public enum EMediaIOStandardType : int
    {
        Progressive = 0,
        Interlaced = 1,
        ProgressiveSegmentedFrame = 2,
        EMediaIOStandardType_MAX = 3,
    }
    public enum EMediaIOTimecodeFormat : int
    {
        None = 0,
        LTC = 1,
        VITC = 2,
        EMediaIOTimecodeFormat_MAX = 3,
    }
    public enum EMediaIOAutoDetectableTimecodeFormat : int
    {
        None = 0,
        LTC = 1,
        VITC = 2,
        Auto = 255,
        EMediaIOAutoDetectableTimecodeFormat_MAX = 256,
    }
    public enum EMediaIOInputType : int
    {
        Fill = 0,
        FillAndKey = 1,
        EMediaIOInputType_MAX = 2,
    }
    public enum EMediaIOOutputType : int
    {
        Fill = 0,
        FillAndKey = 1,
        EMediaIOOutputType_MAX = 2,
    }
    public enum EMediaIOReferenceType : int
    {
        FreeRun = 0,
        External = 1,
        Input = 2,
        EMediaIOReferenceType_MAX = 3,
    }
    public class MediaCaptureOptions : Object
    {
        public MediaCaptureOptions(nint addr) : base(addr) { }
        public EMediaCaptureOverrunAction OverrunAction { get { return (EMediaCaptureOverrunAction)this[nameof(OverrunAction)].GetValue<int>(); } set { this[nameof(OverrunAction)].SetValue<int>((int)value); } }
        public EMediaCaptureCroppingType Crop { get { return (EMediaCaptureCroppingType)this[nameof(Crop)].GetValue<int>(); } set { this[nameof(Crop)].SetValue<int>((int)value); } }
        public IntPoint CustomCapturePoint { get { return this[nameof(CustomCapturePoint)].As<IntPoint>(); } set { this["CustomCapturePoint"] = value; } }
        public bool bResizeSourceBuffer { get { return this[nameof(bResizeSourceBuffer)].Flag; } set { this[nameof(bResizeSourceBuffer)].Flag = value; } }
        public bool bSkipFrameWhenRunningExpensiveTasks { get { return this[nameof(bSkipFrameWhenRunningExpensiveTasks)].Flag; } set { this[nameof(bSkipFrameWhenRunningExpensiveTasks)].Flag = value; } }
        public bool bConvertToDesiredPixelFormat { get { return this[nameof(bConvertToDesiredPixelFormat)].Flag; } set { this[nameof(bConvertToDesiredPixelFormat)].Flag = value; } }
        public bool bForceAlphaToOneOnConversion { get { return this[nameof(bForceAlphaToOneOnConversion)].Flag; } set { this[nameof(bForceAlphaToOneOnConversion)].Flag = value; } }
        public bool bApplyLinearToSRGBConversion { get { return this[nameof(bApplyLinearToSRGBConversion)].Flag; } set { this[nameof(bApplyLinearToSRGBConversion)].Flag = value; } }
        public bool bAutostopOnCapture { get { return this[nameof(bAutostopOnCapture)].Flag; } set { this[nameof(bAutostopOnCapture)].Flag = value; } }
        public int NumberOfFramesToCapture { get { return this[nameof(NumberOfFramesToCapture)].GetValue<int>(); } set { this[nameof(NumberOfFramesToCapture)].SetValue<int>(value); } }
    }
    public class MediaIOAutoDetectableTimecodeFormat_Backup : Object
    {
        public MediaIOAutoDetectableTimecodeFormat_Backup(nint addr) : base(addr) { }
        public EMediaIOTimecodeFormat TimecodeFormat { get { return (EMediaIOTimecodeFormat)this[nameof(TimecodeFormat)].GetValue<int>(); } set { this[nameof(TimecodeFormat)].SetValue<int>((int)value); } }
        public bool bAutoDetect { get { return this[nameof(bAutoDetect)].Flag; } set { this[nameof(bAutoDetect)].Flag = value; } }
    }
    public class MediaIODevice : Object
    {
        public MediaIODevice(nint addr) : base(addr) { }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public int DeviceIdentifier { get { return this[nameof(DeviceIdentifier)].GetValue<int>(); } set { this[nameof(DeviceIdentifier)].SetValue<int>(value); } }
    }
    public class MediaIOConnection : Object
    {
        public MediaIOConnection(nint addr) : base(addr) { }
        public MediaIODevice Device { get { return this[nameof(Device)].As<MediaIODevice>(); } set { this["Device"] = value; } }
        public Object protocol { get { return this[nameof(protocol)]; } set { this[nameof(protocol)] = value; } }
        public EMediaIOTransportType TransportType { get { return (EMediaIOTransportType)this[nameof(TransportType)].GetValue<int>(); } set { this[nameof(TransportType)].SetValue<int>((int)value); } }
        public EMediaIOQuadLinkTransportType QuadTransportType { get { return (EMediaIOQuadLinkTransportType)this[nameof(QuadTransportType)].GetValue<int>(); } set { this[nameof(QuadTransportType)].SetValue<int>((int)value); } }
        public int PortIdentifier { get { return this[nameof(PortIdentifier)].GetValue<int>(); } set { this[nameof(PortIdentifier)].SetValue<int>(value); } }
    }
    public class MediaIOMode : Object
    {
        public MediaIOMode(nint addr) : base(addr) { }
        public FrameRate FrameRate { get { return this[nameof(FrameRate)].As<FrameRate>(); } set { this["FrameRate"] = value; } }
        public IntPoint Resolution { get { return this[nameof(Resolution)].As<IntPoint>(); } set { this["Resolution"] = value; } }
        public EMediaIOStandardType Standard { get { return (EMediaIOStandardType)this[nameof(Standard)].GetValue<int>(); } set { this[nameof(Standard)].SetValue<int>((int)value); } }
        public int DeviceModeIdentifier { get { return this[nameof(DeviceModeIdentifier)].GetValue<int>(); } set { this[nameof(DeviceModeIdentifier)].SetValue<int>(value); } }
    }
    public class MediaIOConfiguration : Object
    {
        public MediaIOConfiguration(nint addr) : base(addr) { }
        public bool bIsInput { get { return this[nameof(bIsInput)].Flag; } set { this[nameof(bIsInput)].Flag = value; } }
        public MediaIOConnection MediaConnection { get { return this[nameof(MediaConnection)].As<MediaIOConnection>(); } set { this["MediaConnection"] = value; } }
        public MediaIOMode MediaMode { get { return this[nameof(MediaMode)].As<MediaIOMode>(); } set { this["MediaMode"] = value; } }
    }
    public class MediaIOInputConfiguration : Object
    {
        public MediaIOInputConfiguration(nint addr) : base(addr) { }
        public MediaIOConfiguration MediaConfiguration { get { return this[nameof(MediaConfiguration)].As<MediaIOConfiguration>(); } set { this["MediaConfiguration"] = value; } }
        public EMediaIOInputType InputType { get { return (EMediaIOInputType)this[nameof(InputType)].GetValue<int>(); } set { this[nameof(InputType)].SetValue<int>((int)value); } }
        public int KeyPortIdentifier { get { return this[nameof(KeyPortIdentifier)].GetValue<int>(); } set { this[nameof(KeyPortIdentifier)].SetValue<int>(value); } }
    }
    public class MediaIOOutputConfiguration : Object
    {
        public MediaIOOutputConfiguration(nint addr) : base(addr) { }
        public MediaIOConfiguration MediaConfiguration { get { return this[nameof(MediaConfiguration)].As<MediaIOConfiguration>(); } set { this["MediaConfiguration"] = value; } }
        public EMediaIOOutputType OutputType { get { return (EMediaIOOutputType)this[nameof(OutputType)].GetValue<int>(); } set { this[nameof(OutputType)].SetValue<int>((int)value); } }
        public int KeyPortIdentifier { get { return this[nameof(KeyPortIdentifier)].GetValue<int>(); } set { this[nameof(KeyPortIdentifier)].SetValue<int>(value); } }
        public EMediaIOReferenceType OutputReference { get { return (EMediaIOReferenceType)this[nameof(OutputReference)].GetValue<int>(); } set { this[nameof(OutputReference)].SetValue<int>((int)value); } }
        public int ReferencePortIdentifier { get { return this[nameof(ReferencePortIdentifier)].GetValue<int>(); } set { this[nameof(ReferencePortIdentifier)].SetValue<int>(value); } }
    }
    public class MediaIOVideoTimecodeConfiguration : Object
    {
        public MediaIOVideoTimecodeConfiguration(nint addr) : base(addr) { }
        public MediaIOConfiguration MediaConfiguration { get { return this[nameof(MediaConfiguration)].As<MediaIOConfiguration>(); } set { this["MediaConfiguration"] = value; } }
        public EMediaIOAutoDetectableTimecodeFormat TimecodeFormat { get { return (EMediaIOAutoDetectableTimecodeFormat)this[nameof(TimecodeFormat)].GetValue<int>(); } set { this[nameof(TimecodeFormat)].SetValue<int>((int)value); } }
    }
}
