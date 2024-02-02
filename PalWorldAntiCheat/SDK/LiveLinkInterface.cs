using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.LiveLinkInterfaceSDK
{
    public class LiveLinkFrameInterpolationProcessor : Object
    {
        public LiveLinkFrameInterpolationProcessor(nint addr) : base(addr) { }
    }
    public class LiveLinkVirtualSubject : Object
    {
        public LiveLinkVirtualSubject(nint addr) : base(addr) { }
        public Object Role { get { return this[nameof(Role)]; } set { this[nameof(Role)] = value; } }
        public Array<LiveLinkSubjectName> Subjects { get { return new Array<LiveLinkSubjectName>(this[nameof(Subjects)].Address); } }
        public Array<LiveLinkFrameTranslator> FrameTranslators { get { return new Array<LiveLinkFrameTranslator>(this[nameof(FrameTranslators)].Address); } }
        public bool bRebroadcastSubject { get { return this[nameof(bRebroadcastSubject)].Flag; } set { this[nameof(bRebroadcastSubject)].Flag = value; } }
    }
    public class LiveLinkSourceFactory : Object
    {
        public LiveLinkSourceFactory(nint addr) : base(addr) { }
    }
    public class LiveLinkSourceSettings : Object
    {
        public LiveLinkSourceSettings(nint addr) : base(addr) { }
        public ELiveLinkSourceMode Mode { get { return (ELiveLinkSourceMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public LiveLinkSourceBufferManagementSettings BufferSettings { get { return this[nameof(BufferSettings)].As<LiveLinkSourceBufferManagementSettings>(); } set { this["BufferSettings"] = value; } }
        public Object ConnectionString { get { return this[nameof(ConnectionString)]; } set { this[nameof(ConnectionString)] = value; } }
        public Object Factory { get { return this[nameof(Factory)]; } set { this[nameof(Factory)] = value; } }
    }
    public class LiveLinkFramePreProcessor : Object
    {
        public LiveLinkFramePreProcessor(nint addr) : base(addr) { }
    }
    public class LiveLinkFrameTranslator : Object
    {
        public LiveLinkFrameTranslator(nint addr) : base(addr) { }
    }
    public class LiveLinkController : Object
    {
        public LiveLinkController(nint addr) : base(addr) { }
    }
    public class LiveLinkRole : Object
    {
        public LiveLinkRole(nint addr) : base(addr) { }
    }
    public class LiveLinkCurveRemapSettings : LiveLinkSourceSettings
    {
        public LiveLinkCurveRemapSettings(nint addr) : base(addr) { }
        public LiveLinkCurveConversionSettings CurveConversionSettings { get { return this[nameof(CurveConversionSettings)].As<LiveLinkCurveConversionSettings>(); } set { this["CurveConversionSettings"] = value; } }
    }
    public class LiveLinkSubjectSettings : Object
    {
        public LiveLinkSubjectSettings(nint addr) : base(addr) { }
        public Array<LiveLinkFramePreProcessor> PreProcessors { get { return new Array<LiveLinkFramePreProcessor>(this[nameof(PreProcessors)].Address); } }
        public LiveLinkFrameInterpolationProcessor InterpolationProcessor { get { return this[nameof(InterpolationProcessor)].As<LiveLinkFrameInterpolationProcessor>(); } set { this["InterpolationProcessor"] = value; } }
        public Array<LiveLinkFrameTranslator> Translators { get { return new Array<LiveLinkFrameTranslator>(this[nameof(Translators)].Address); } }
        public Object Role { get { return this[nameof(Role)]; } set { this[nameof(Role)] = value; } }
        public FrameRate FrameRate { get { return this[nameof(FrameRate)].As<FrameRate>(); } set { this["FrameRate"] = value; } }
        public bool bRebroadcastSubject { get { return this[nameof(bRebroadcastSubject)].Flag; } set { this[nameof(bRebroadcastSubject)].Flag = value; } }
    }
    public class LiveLinkBasicRole : LiveLinkRole
    {
        public LiveLinkBasicRole(nint addr) : base(addr) { }
    }
    public class LiveLinkAnimationRole : LiveLinkBasicRole
    {
        public LiveLinkAnimationRole(nint addr) : base(addr) { }
    }
    public class LiveLinkTransformRole : LiveLinkBasicRole
    {
        public LiveLinkTransformRole(nint addr) : base(addr) { }
    }
    public class LiveLinkCameraRole : LiveLinkTransformRole
    {
        public LiveLinkCameraRole(nint addr) : base(addr) { }
    }
    public class LiveLinkLightRole : LiveLinkTransformRole
    {
        public LiveLinkLightRole(nint addr) : base(addr) { }
    }
    public enum ELiveLinkCameraProjectionMode : int
    {
        Perspective = 0,
        Orthographic = 1,
        ELiveLinkCameraProjectionMode_MAX = 2,
    }
    public enum ELiveLinkSourceMode : int
    {
        Latest = 0,
        EngineTime = 1,
        Timecode = 2,
        ELiveLinkSourceMode_MAX = 3,
    }
    public class LiveLinkSubjectPreset : Object
    {
        public LiveLinkSubjectPreset(nint addr) : base(addr) { }
        public LiveLinkSubjectKey Key { get { return this[nameof(Key)].As<LiveLinkSubjectKey>(); } set { this["Key"] = value; } }
        public Object Role { get { return this[nameof(Role)]; } set { this[nameof(Role)] = value; } }
        public LiveLinkSubjectSettings Settings { get { return this[nameof(Settings)].As<LiveLinkSubjectSettings>(); } set { this["Settings"] = value; } }
        public LiveLinkVirtualSubject VirtualSubject { get { return this[nameof(VirtualSubject)].As<LiveLinkVirtualSubject>(); } set { this["VirtualSubject"] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class LiveLinkSubjectKey : Object
    {
        public LiveLinkSubjectKey(nint addr) : base(addr) { }
        public Guid Source { get { return this[nameof(Source)].As<Guid>(); } set { this["Source"] = value; } }
        public LiveLinkSubjectName SubjectName { get { return this[nameof(SubjectName)].As<LiveLinkSubjectName>(); } set { this["SubjectName"] = value; } }
    }
    public class LiveLinkSubjectName : Object
    {
        public LiveLinkSubjectName(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class LiveLinkSourceHandle : Object
    {
        public LiveLinkSourceHandle(nint addr) : base(addr) { }
    }
    public class LiveLinkBaseStaticData : Object
    {
        public LiveLinkBaseStaticData(nint addr) : base(addr) { }
        public Array<Object> PropertyNames { get { return new Array<Object>(this[nameof(PropertyNames)].Address); } }
    }
    public class LiveLinkSkeletonStaticData : LiveLinkBaseStaticData
    {
        public LiveLinkSkeletonStaticData(nint addr) : base(addr) { }
        public Array<Object> BoneNames { get { return new Array<Object>(this[nameof(BoneNames)].Address); } }
        public Array<int> BoneParents { get { return new Array<int>(this[nameof(BoneParents)].Address); } }
    }
    public class LiveLinkBaseFrameData : Object
    {
        public LiveLinkBaseFrameData(nint addr) : base(addr) { }
        public LiveLinkWorldTime WorldTime { get { return this[nameof(WorldTime)].As<LiveLinkWorldTime>(); } set { this["WorldTime"] = value; } }
        public LiveLinkMetaData MetaData { get { return this[nameof(MetaData)].As<LiveLinkMetaData>(); } set { this["MetaData"] = value; } }
        public Array<float> PropertyValues { get { return new Array<float>(this[nameof(PropertyValues)].Address); } }
    }
    public class LiveLinkMetaData : Object
    {
        public LiveLinkMetaData(nint addr) : base(addr) { }
        public Object StringMetaData { get { return this[nameof(StringMetaData)]; } set { this[nameof(StringMetaData)] = value; } }
        public QualifiedFrameTime SceneTime { get { return this[nameof(SceneTime)].As<QualifiedFrameTime>(); } set { this["SceneTime"] = value; } }
    }
    public class LiveLinkWorldTime : Object
    {
        public LiveLinkWorldTime(nint addr) : base(addr) { }
        public double Time { get { return this[nameof(Time)].GetValue<double>(); } set { this[nameof(Time)].SetValue<double>(value); } }
        public double Offset { get { return this[nameof(Offset)].GetValue<double>(); } set { this[nameof(Offset)].SetValue<double>(value); } }
    }
    public class LiveLinkAnimationFrameData : LiveLinkBaseFrameData
    {
        public LiveLinkAnimationFrameData(nint addr) : base(addr) { }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
    }
    public class LiveLinkBaseBlueprintData : Object
    {
        public LiveLinkBaseBlueprintData(nint addr) : base(addr) { }
    }
    public class LiveLinkBasicBlueprintData : LiveLinkBaseBlueprintData
    {
        public LiveLinkBasicBlueprintData(nint addr) : base(addr) { }
        public LiveLinkBaseStaticData StaticData { get { return this[nameof(StaticData)].As<LiveLinkBaseStaticData>(); } set { this["StaticData"] = value; } }
        public LiveLinkBaseFrameData FrameData { get { return this[nameof(FrameData)].As<LiveLinkBaseFrameData>(); } set { this["FrameData"] = value; } }
    }
    public class LiveLinkTransformStaticData : LiveLinkBaseStaticData
    {
        public LiveLinkTransformStaticData(nint addr) : base(addr) { }
        public bool bIsLocationSupported { get { return this[nameof(bIsLocationSupported)].Flag; } set { this[nameof(bIsLocationSupported)].Flag = value; } }
        public bool bIsRotationSupported { get { return this[nameof(bIsRotationSupported)].Flag; } set { this[nameof(bIsRotationSupported)].Flag = value; } }
        public bool bIsScaleSupported { get { return this[nameof(bIsScaleSupported)].Flag; } set { this[nameof(bIsScaleSupported)].Flag = value; } }
    }
    public class LiveLinkCameraStaticData : LiveLinkTransformStaticData
    {
        public LiveLinkCameraStaticData(nint addr) : base(addr) { }
        public bool bIsFieldOfViewSupported { get { return this[nameof(bIsFieldOfViewSupported)].Flag; } set { this[nameof(bIsFieldOfViewSupported)].Flag = value; } }
        public bool bIsAspectRatioSupported { get { return this[nameof(bIsAspectRatioSupported)].Flag; } set { this[nameof(bIsAspectRatioSupported)].Flag = value; } }
        public bool bIsFocalLengthSupported { get { return this[nameof(bIsFocalLengthSupported)].Flag; } set { this[nameof(bIsFocalLengthSupported)].Flag = value; } }
        public bool bIsProjectionModeSupported { get { return this[nameof(bIsProjectionModeSupported)].Flag; } set { this[nameof(bIsProjectionModeSupported)].Flag = value; } }
        public float FilmBackWidth { get { return this[nameof(FilmBackWidth)].GetValue<float>(); } set { this[nameof(FilmBackWidth)].SetValue<float>(value); } }
        public float FilmBackHeight { get { return this[nameof(FilmBackHeight)].GetValue<float>(); } set { this[nameof(FilmBackHeight)].SetValue<float>(value); } }
        public bool bIsApertureSupported { get { return this[nameof(bIsApertureSupported)].Flag; } set { this[nameof(bIsApertureSupported)].Flag = value; } }
        public bool bIsFocusDistanceSupported { get { return this[nameof(bIsFocusDistanceSupported)].Flag; } set { this[nameof(bIsFocusDistanceSupported)].Flag = value; } }
        public bool bIsDepthOfFieldSupported { get { return this[nameof(bIsDepthOfFieldSupported)].Flag; } set { this[nameof(bIsDepthOfFieldSupported)].Flag = value; } }
    }
    public class LiveLinkTransformFrameData : LiveLinkBaseFrameData
    {
        public LiveLinkTransformFrameData(nint addr) : base(addr) { }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
    }
    public class LiveLinkCameraFrameData : LiveLinkTransformFrameData
    {
        public LiveLinkCameraFrameData(nint addr) : base(addr) { }
        public float FieldOfView { get { return this[nameof(FieldOfView)].GetValue<float>(); } set { this[nameof(FieldOfView)].SetValue<float>(value); } }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
        public float FocalLength { get { return this[nameof(FocalLength)].GetValue<float>(); } set { this[nameof(FocalLength)].SetValue<float>(value); } }
        public float Aperture { get { return this[nameof(Aperture)].GetValue<float>(); } set { this[nameof(Aperture)].SetValue<float>(value); } }
        public float FocusDistance { get { return this[nameof(FocusDistance)].GetValue<float>(); } set { this[nameof(FocusDistance)].SetValue<float>(value); } }
        public ELiveLinkCameraProjectionMode ProjectionMode { get { return (ELiveLinkCameraProjectionMode)this[nameof(ProjectionMode)].GetValue<int>(); } set { this[nameof(ProjectionMode)].SetValue<int>((int)value); } }
    }
    public class LiveLinkCameraBlueprintData : LiveLinkBaseBlueprintData
    {
        public LiveLinkCameraBlueprintData(nint addr) : base(addr) { }
        public LiveLinkCameraStaticData StaticData { get { return this[nameof(StaticData)].As<LiveLinkCameraStaticData>(); } set { this["StaticData"] = value; } }
        public LiveLinkCameraFrameData FrameData { get { return this[nameof(FrameData)].As<LiveLinkCameraFrameData>(); } set { this["FrameData"] = value; } }
    }
    public class LiveLinkLightStaticData : LiveLinkTransformStaticData
    {
        public LiveLinkLightStaticData(nint addr) : base(addr) { }
        public bool bIsTemperatureSupported { get { return this[nameof(bIsTemperatureSupported)].Flag; } set { this[nameof(bIsTemperatureSupported)].Flag = value; } }
        public bool bIsIntensitySupported { get { return this[nameof(bIsIntensitySupported)].Flag; } set { this[nameof(bIsIntensitySupported)].Flag = value; } }
        public bool bIsLightColorSupported { get { return this[nameof(bIsLightColorSupported)].Flag; } set { this[nameof(bIsLightColorSupported)].Flag = value; } }
        public bool bIsInnerConeAngleSupported { get { return this[nameof(bIsInnerConeAngleSupported)].Flag; } set { this[nameof(bIsInnerConeAngleSupported)].Flag = value; } }
        public bool bIsOuterConeAngleSupported { get { return this[nameof(bIsOuterConeAngleSupported)].Flag; } set { this[nameof(bIsOuterConeAngleSupported)].Flag = value; } }
        public bool bIsAttenuationRadiusSupported { get { return this[nameof(bIsAttenuationRadiusSupported)].Flag; } set { this[nameof(bIsAttenuationRadiusSupported)].Flag = value; } }
        public bool bIsSourceLenghtSupported { get { return this[nameof(bIsSourceLenghtSupported)].Flag; } set { this[nameof(bIsSourceLenghtSupported)].Flag = value; } }
        public bool bIsSourceRadiusSupported { get { return this[nameof(bIsSourceRadiusSupported)].Flag; } set { this[nameof(bIsSourceRadiusSupported)].Flag = value; } }
        public bool bIsSoftSourceRadiusSupported { get { return this[nameof(bIsSoftSourceRadiusSupported)].Flag; } set { this[nameof(bIsSoftSourceRadiusSupported)].Flag = value; } }
    }
    public class LiveLinkLightFrameData : LiveLinkTransformFrameData
    {
        public LiveLinkLightFrameData(nint addr) : base(addr) { }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public Color LightColor { get { return this[nameof(LightColor)].As<Color>(); } set { this["LightColor"] = value; } }
        public float InnerConeAngle { get { return this[nameof(InnerConeAngle)].GetValue<float>(); } set { this[nameof(InnerConeAngle)].SetValue<float>(value); } }
        public float OuterConeAngle { get { return this[nameof(OuterConeAngle)].GetValue<float>(); } set { this[nameof(OuterConeAngle)].SetValue<float>(value); } }
        public float AttenuationRadius { get { return this[nameof(AttenuationRadius)].GetValue<float>(); } set { this[nameof(AttenuationRadius)].SetValue<float>(value); } }
        public float SourceRadius { get { return this[nameof(SourceRadius)].GetValue<float>(); } set { this[nameof(SourceRadius)].SetValue<float>(value); } }
        public float SoftSourceRadius { get { return this[nameof(SoftSourceRadius)].GetValue<float>(); } set { this[nameof(SoftSourceRadius)].SetValue<float>(value); } }
        public float SourceLength { get { return this[nameof(SourceLength)].GetValue<float>(); } set { this[nameof(SourceLength)].SetValue<float>(value); } }
    }
    public class LiveLinkLightBlueprintData : LiveLinkBaseBlueprintData
    {
        public LiveLinkLightBlueprintData(nint addr) : base(addr) { }
        public LiveLinkLightStaticData StaticData { get { return this[nameof(StaticData)].As<LiveLinkLightStaticData>(); } set { this["StaticData"] = value; } }
        public LiveLinkLightFrameData FrameData { get { return this[nameof(FrameData)].As<LiveLinkLightFrameData>(); } set { this["FrameData"] = value; } }
    }
    public class LiveLinkSourcePreset : Object
    {
        public LiveLinkSourcePreset(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public LiveLinkSourceSettings Settings { get { return this[nameof(Settings)].As<LiveLinkSourceSettings>(); } set { this["Settings"] = value; } }
        public Object SourceType { get { return this[nameof(SourceType)]; } set { this[nameof(SourceType)] = value; } }
    }
    public class LiveLinkRefSkeleton : Object
    {
        public LiveLinkRefSkeleton(nint addr) : base(addr) { }
        public Array<Object> BoneNames { get { return new Array<Object>(this[nameof(BoneNames)].Address); } }
        public Array<int> BoneParents { get { return new Array<int>(this[nameof(BoneParents)].Address); } }
    }
    public class LiveLinkSubjectRepresentation : Object
    {
        public LiveLinkSubjectRepresentation(nint addr) : base(addr) { }
        public LiveLinkSubjectName Subject { get { return this[nameof(Subject)].As<LiveLinkSubjectName>(); } set { this["Subject"] = value; } }
        public Object Role { get { return this[nameof(Role)]; } set { this[nameof(Role)] = value; } }
    }
    public class LiveLinkTransformBlueprintData : LiveLinkBaseBlueprintData
    {
        public LiveLinkTransformBlueprintData(nint addr) : base(addr) { }
        public LiveLinkTransformStaticData StaticData { get { return this[nameof(StaticData)].As<LiveLinkTransformStaticData>(); } set { this["StaticData"] = value; } }
        public LiveLinkTransformFrameData FrameData { get { return this[nameof(FrameData)].As<LiveLinkTransformFrameData>(); } set { this["FrameData"] = value; } }
    }
    public class LiveLinkCurveConversionSettings : Object
    {
        public LiveLinkCurveConversionSettings(nint addr) : base(addr) { }
        public Object CurveConversionAssetMap { get { return this[nameof(CurveConversionAssetMap)]; } set { this[nameof(CurveConversionAssetMap)] = value; } }
    }
    public class LiveLinkSourceBufferManagementSettings : Object
    {
        public LiveLinkSourceBufferManagementSettings(nint addr) : base(addr) { }
        public bool bValidEngineTimeEnabled { get { return this[nameof(bValidEngineTimeEnabled)].Flag; } set { this[nameof(bValidEngineTimeEnabled)].Flag = value; } }
        public float ValidEngineTime { get { return this[nameof(ValidEngineTime)].GetValue<float>(); } set { this[nameof(ValidEngineTime)].SetValue<float>(value); } }
        public float EngineTimeOffset { get { return this[nameof(EngineTimeOffset)].GetValue<float>(); } set { this[nameof(EngineTimeOffset)].SetValue<float>(value); } }
        public double EngineTimeClockOffset { get { return this[nameof(EngineTimeClockOffset)].GetValue<double>(); } set { this[nameof(EngineTimeClockOffset)].SetValue<double>(value); } }
        public double SmoothEngineTimeOffset { get { return this[nameof(SmoothEngineTimeOffset)].GetValue<double>(); } set { this[nameof(SmoothEngineTimeOffset)].SetValue<double>(value); } }
        public bool bGenerateSubFrame { get { return this[nameof(bGenerateSubFrame)].Flag; } set { this[nameof(bGenerateSubFrame)].Flag = value; } }
        public FrameRate DetectedFrameRate { get { return this[nameof(DetectedFrameRate)].As<FrameRate>(); } set { this["DetectedFrameRate"] = value; } }
        public bool bUseTimecodeSmoothLatest { get { return this[nameof(bUseTimecodeSmoothLatest)].Flag; } set { this[nameof(bUseTimecodeSmoothLatest)].Flag = value; } }
        public FrameRate SourceTimecodeFrameRate { get { return this[nameof(SourceTimecodeFrameRate)].As<FrameRate>(); } set { this["SourceTimecodeFrameRate"] = value; } }
        public bool bValidTimecodeFrameEnabled { get { return this[nameof(bValidTimecodeFrameEnabled)].Flag; } set { this[nameof(bValidTimecodeFrameEnabled)].Flag = value; } }
        public int ValidTimecodeFrame { get { return this[nameof(ValidTimecodeFrame)].GetValue<int>(); } set { this[nameof(ValidTimecodeFrame)].SetValue<int>(value); } }
        public float TimecodeFrameOffset { get { return this[nameof(TimecodeFrameOffset)].GetValue<float>(); } set { this[nameof(TimecodeFrameOffset)].SetValue<float>(value); } }
        public double TimecodeClockOffset { get { return this[nameof(TimecodeClockOffset)].GetValue<double>(); } set { this[nameof(TimecodeClockOffset)].SetValue<double>(value); } }
        public int LatestOffset { get { return this[nameof(LatestOffset)].GetValue<int>(); } set { this[nameof(LatestOffset)].SetValue<int>(value); } }
        public int MaxNumberOfFrameToBuffered { get { return this[nameof(MaxNumberOfFrameToBuffered)].GetValue<int>(); } set { this[nameof(MaxNumberOfFrameToBuffered)].SetValue<int>(value); } }
        public bool bKeepAtLeastOneFrame { get { return this[nameof(bKeepAtLeastOneFrame)].Flag; } set { this[nameof(bKeepAtLeastOneFrame)].Flag = value; } }
    }
    public class LiveLinkSourceDebugInfo : Object
    {
        public LiveLinkSourceDebugInfo(nint addr) : base(addr) { }
        public LiveLinkSubjectName SubjectName { get { return this[nameof(SubjectName)].As<LiveLinkSubjectName>(); } set { this["SubjectName"] = value; } }
        public int SnapshotIndex { get { return this[nameof(SnapshotIndex)].GetValue<int>(); } set { this[nameof(SnapshotIndex)].SetValue<int>(value); } }
        public int NumberOfBufferAtSnapshot { get { return this[nameof(NumberOfBufferAtSnapshot)].GetValue<int>(); } set { this[nameof(NumberOfBufferAtSnapshot)].SetValue<int>(value); } }
    }
    public class LiveLinkTimeSynchronizationSettings : Object
    {
        public LiveLinkTimeSynchronizationSettings(nint addr) : base(addr) { }
        public FrameRate FrameRate { get { return this[nameof(FrameRate)].As<FrameRate>(); } set { this["FrameRate"] = value; } }
        public FrameNumber FrameOffset { get { return this[nameof(FrameOffset)].As<FrameNumber>(); } set { this["FrameOffset"] = value; } }
    }
    public class LiveLinkInterpolationSettings : Object
    {
        public LiveLinkInterpolationSettings(nint addr) : base(addr) { }
        public bool bUseInterpolation { get { return this[nameof(bUseInterpolation)].Flag; } set { this[nameof(bUseInterpolation)].Flag = value; } }
        public float InterpolationOffset { get { return this[nameof(InterpolationOffset)].GetValue<float>(); } set { this[nameof(InterpolationOffset)].SetValue<float>(value); } }
    }
    public class LiveLinkTime : Object
    {
        public LiveLinkTime(nint addr) : base(addr) { }
        public double WorldTime { get { return this[nameof(WorldTime)].GetValue<double>(); } set { this[nameof(WorldTime)].SetValue<double>(value); } }
        public QualifiedFrameTime SceneTime { get { return this[nameof(SceneTime)].As<QualifiedFrameTime>(); } set { this["SceneTime"] = value; } }
    }
    public class LiveLinkFrameRate : FrameRate
    {
        public LiveLinkFrameRate(nint addr) : base(addr) { }
    }
    public class LiveLinkTimeCode_Base_DEPRECATED : Object
    {
        public LiveLinkTimeCode_Base_DEPRECATED(nint addr) : base(addr) { }
        public int Seconds { get { return this[nameof(Seconds)].GetValue<int>(); } set { this[nameof(Seconds)].SetValue<int>(value); } }
        public int Frames { get { return this[nameof(Frames)].GetValue<int>(); } set { this[nameof(Frames)].SetValue<int>(value); } }
        public LiveLinkFrameRate FrameRate { get { return this[nameof(FrameRate)].As<LiveLinkFrameRate>(); } set { this["FrameRate"] = value; } }
    }
    public class LiveLinkTimeCode : LiveLinkTimeCode_Base_DEPRECATED
    {
        public LiveLinkTimeCode(nint addr) : base(addr) { }
    }
    public class LiveLinkCurveElement : Object
    {
        public LiveLinkCurveElement(nint addr) : base(addr) { }
        public Object CurveName { get { return this[nameof(CurveName)]; } set { this[nameof(CurveName)] = value; } }
        public float CurveValue { get { return this[nameof(CurveValue)].GetValue<float>(); } set { this[nameof(CurveValue)].SetValue<float>(value); } }
    }
    public class LiveLinkFrameData : Object
    {
        public LiveLinkFrameData(nint addr) : base(addr) { }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
        public Array<LiveLinkCurveElement> CurveElements { get { return new Array<LiveLinkCurveElement>(this[nameof(CurveElements)].Address); } }
        public LiveLinkWorldTime WorldTime { get { return this[nameof(WorldTime)].As<LiveLinkWorldTime>(); } set { this["WorldTime"] = value; } }
        public LiveLinkMetaData MetaData { get { return this[nameof(MetaData)].As<LiveLinkMetaData>(); } set { this["MetaData"] = value; } }
    }
    public class SubjectMetadata : Object
    {
        public SubjectMetadata(nint addr) : base(addr) { }
        public Object StringMetaData { get { return this[nameof(StringMetaData)]; } set { this[nameof(StringMetaData)] = value; } }
        public Timecode SceneTimecode { get { return this[nameof(SceneTimecode)].As<Timecode>(); } set { this["SceneTimecode"] = value; } }
        public FrameRate SceneFramerate { get { return this[nameof(SceneFramerate)].As<FrameRate>(); } set { this["SceneFramerate"] = value; } }
    }
    public class CachedSubjectFrame : Object
    {
        public CachedSubjectFrame(nint addr) : base(addr) { }
    }
    public class LiveLinkTransform : Object
    {
        public LiveLinkTransform(nint addr) : base(addr) { }
    }
    public class SubjectFrameHandle : LiveLinkBaseBlueprintData
    {
        public SubjectFrameHandle(nint addr) : base(addr) { }
    }
}
