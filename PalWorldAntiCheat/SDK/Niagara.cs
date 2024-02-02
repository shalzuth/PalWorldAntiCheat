using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.NiagaraCoreSDK;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.PhysicsCoreSDK;
using SDK.Script.NiagaraShaderSDK;
namespace SDK.Script.NiagaraSDK
{
    public class NiagaraDataInterface : NiagaraDataInterfaceBase
    {
        public NiagaraDataInterface(nint addr) : base(addr) { }
    }
    public class NiagaraConvertInPlaceUtilityBase : Object
    {
        public NiagaraConvertInPlaceUtilityBase(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceSimCacheReader : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSimCacheReader(nint addr) : base(addr) { }
        public NiagaraUserParameterBinding SimCacheBinding { get { return this[nameof(SimCacheBinding)].As<NiagaraUserParameterBinding>(); } set { this["SimCacheBinding"] = value; } }
        public NiagaraSimCache SimCache { get { return this[nameof(SimCache)].As<NiagaraSimCache>(); } set { this["SimCache"] = value; } }
        public Object EmitterBinding { get { return this[nameof(EmitterBinding)]; } set { this[nameof(EmitterBinding)] = value; } }
    }
    public class NiagaraDataInterfaceSpriteRendererInfo : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSpriteRendererInfo(nint addr) : base(addr) { }
        public NiagaraSpriteRendererProperties SpriteRenderer { get { return this[nameof(SpriteRenderer)].As<NiagaraSpriteRendererProperties>(); } set { this["SpriteRenderer"] = value; } }
    }
    public class NiagaraDataInterfaceVirtualTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVirtualTexture(nint addr) : base(addr) { }
        public RuntimeVirtualTexture Texture { get { return this[nameof(Texture)].As<RuntimeVirtualTexture>(); } set { this["Texture"] = value; } }
        public NiagaraUserParameterBinding TextureUserParameter { get { return this[nameof(TextureUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["TextureUserParameter"] = value; } }
    }
    public class NiagaraMessageDataBase : Object
    {
        public NiagaraMessageDataBase(nint addr) : base(addr) { }
    }
    public class NiagaraParameterDefinitionsBase : Object
    {
        public NiagaraParameterDefinitionsBase(nint addr) : base(addr) { }
    }
    public class NiagaraScriptSourceBase : Object
    {
        public NiagaraScriptSourceBase(nint addr) : base(addr) { }
    }
    public class NiagaraSettings : DeveloperSettings
    {
        public NiagaraSettings(nint addr) : base(addr) { }
        public bool bSystemsSupportLargeWorldCoordinates { get { return this[nameof(bSystemsSupportLargeWorldCoordinates)].Flag; } set { this[nameof(bSystemsSupportLargeWorldCoordinates)].Flag = value; } }
        public bool bEnforceStrictStackTypes { get { return this[nameof(bEnforceStrictStackTypes)].Flag; } set { this[nameof(bEnforceStrictStackTypes)].Flag = value; } }
        public bool bExperimentalVMEnabled { get { return this[nameof(bExperimentalVMEnabled)].Flag; } set { this[nameof(bExperimentalVMEnabled)].Flag = value; } }
        public SoftObjectPath DefaultEffectType { get { return this[nameof(DefaultEffectType)].As<SoftObjectPath>(); } set { this["DefaultEffectType"] = value; } }
        public LinearColor PositionPinTypeColor { get { return this[nameof(PositionPinTypeColor)].As<LinearColor>(); } set { this["PositionPinTypeColor"] = value; } }
        public Array<Object> QualityLevels { get { return new Array<Object>(this[nameof(QualityLevels)].Address); } }
        public Object ComponentRendererWarningsPerClass { get { return this[nameof(ComponentRendererWarningsPerClass)]; } set { this[nameof(ComponentRendererWarningsPerClass)] = value; } }
        public byte DefaultRenderTargetFormat { get { return this[nameof(DefaultRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(DefaultRenderTargetFormat)].SetValue<byte>(value); } }
        public ENiagaraGpuBufferFormat DefaultGridFormat { get { return (ENiagaraGpuBufferFormat)this[nameof(DefaultGridFormat)].GetValue<int>(); } set { this[nameof(DefaultGridFormat)].SetValue<int>((int)value); } }
        public ENiagaraDefaultRendererMotionVectorSetting DefaultRendererMotionVectorSetting { get { return (ENiagaraDefaultRendererMotionVectorSetting)this[nameof(DefaultRendererMotionVectorSetting)].GetValue<int>(); } set { this[nameof(DefaultRendererMotionVectorSetting)].SetValue<int>((int)value); } }
        public ENiagaraDefaultRendererPixelCoverageMode DefaultPixelCoverageMode { get { return (ENiagaraDefaultRendererPixelCoverageMode)this[nameof(DefaultPixelCoverageMode)].GetValue<int>(); } set { this[nameof(DefaultPixelCoverageMode)].SetValue<int>((int)value); } }
        public ENiagaraDefaultSortPrecision DefaultSortPrecision { get { return (ENiagaraDefaultSortPrecision)this[nameof(DefaultSortPrecision)].GetValue<int>(); } set { this[nameof(DefaultSortPrecision)].SetValue<int>((int)value); } }
        public ENiagaraDefaultGpuTranslucentLatency DefaultGpuTranslucentLatency { get { return (ENiagaraDefaultGpuTranslucentLatency)this[nameof(DefaultGpuTranslucentLatency)].GetValue<int>(); } set { this[nameof(DefaultGpuTranslucentLatency)].SetValue<int>((int)value); } }
        public float DefaultLightInverseExposureBlend { get { return this[nameof(DefaultLightInverseExposureBlend)].GetValue<float>(); } set { this[nameof(DefaultLightInverseExposureBlend)].SetValue<float>(value); } }
        public byte NDISkelMesh_GpuMaxInfluences { get { return this[nameof(NDISkelMesh_GpuMaxInfluences)].GetValue<byte>(); } set { this[nameof(NDISkelMesh_GpuMaxInfluences)].SetValue<byte>(value); } }
        public byte NDISkelMesh_GpuUniformSamplingFormat { get { return this[nameof(NDISkelMesh_GpuUniformSamplingFormat)].GetValue<byte>(); } set { this[nameof(NDISkelMesh_GpuUniformSamplingFormat)].SetValue<byte>(value); } }
        public byte NDISkelMesh_AdjacencyTriangleIndexFormat { get { return this[nameof(NDISkelMesh_AdjacencyTriangleIndexFormat)].GetValue<byte>(); } set { this[nameof(NDISkelMesh_AdjacencyTriangleIndexFormat)].SetValue<byte>(value); } }
        public bool NDIStaticMesh_AllowDistanceFields { get { return this[nameof(NDIStaticMesh_AllowDistanceFields)].Flag; } set { this[nameof(NDIStaticMesh_AllowDistanceFields)].Flag = value; } }
        public Array<byte> NDICollisionQuery_AsyncGpuTraceProviderOrder { get { return new Array<byte>(this[nameof(NDICollisionQuery_AsyncGpuTraceProviderOrder)].Address); } }
        public Array<NiagaraPlatformSetRedirect> PlatformSetRedirects { get { return new Array<NiagaraPlatformSetRedirect>(this[nameof(PlatformSetRedirects)].Address); } }
    }
    public class NiagaraDataInterfaceActorComponent : NiagaraDataInterface
    {
        public NiagaraDataInterfaceActorComponent(nint addr) : base(addr) { }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
        public ENDIActorComponentSourceMode SourceMode { get { return (ENDIActorComponentSourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public int LocalPlayerIndex { get { return this[nameof(LocalPlayerIndex)].GetValue<int>(); } set { this[nameof(LocalPlayerIndex)].SetValue<int>(value); } }
        public Object SourceActor { get { return this[nameof(SourceActor)]; } set { this[nameof(SourceActor)] = value; } }
        public NiagaraUserParameterBinding ActorOrComponentParameter { get { return this[nameof(ActorOrComponentParameter)].As<NiagaraUserParameterBinding>(); } set { this["ActorOrComponentParameter"] = value; } }
    }
    public class NiagaraDataInterfaceAsyncGpuTrace : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAsyncGpuTrace(nint addr) : base(addr) { }
        public int MaxTracesPerParticle { get { return this[nameof(MaxTracesPerParticle)].GetValue<int>(); } set { this[nameof(MaxTracesPerParticle)].SetValue<int>(value); } }
        public int MaxRetraces { get { return this[nameof(MaxRetraces)].GetValue<int>(); } set { this[nameof(MaxRetraces)].SetValue<int>(value); } }
        public byte TraceProvider { get { return this[nameof(TraceProvider)].GetValue<byte>(); } set { this[nameof(TraceProvider)].SetValue<byte>(value); } }
    }
    public class NiagaraDataInterfaceDebugDraw : NiagaraDataInterface
    {
        public NiagaraDataInterfaceDebugDraw(nint addr) : base(addr) { }
        public uint OverrideMaxLineInstances { get { return this[nameof(OverrideMaxLineInstances)].GetValue<uint>(); } set { this[nameof(OverrideMaxLineInstances)].SetValue<uint>(value); } }
    }
    public class NiagaraDataInterfaceEmitterProperties : NiagaraDataInterface
    {
        public NiagaraDataInterfaceEmitterProperties(nint addr) : base(addr) { }
        public NiagaraDataInterfaceEmitterBinding EmitterBinding { get { return this[nameof(EmitterBinding)].As<NiagaraDataInterfaceEmitterBinding>(); } set { this["EmitterBinding"] = value; } }
    }
    public class NiagaraDataInterfaceGBuffer : NiagaraDataInterface
    {
        public NiagaraDataInterfaceGBuffer(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfacePhysicsAsset : NiagaraDataInterface
    {
        public NiagaraDataInterfacePhysicsAsset(nint addr) : base(addr) { }
        public PhysicsAsset DefaultSource { get { return this[nameof(DefaultSource)].As<PhysicsAsset>(); } set { this["DefaultSource"] = value; } }
        public Object SoftSourceActor { get { return this[nameof(SoftSourceActor)]; } set { this[nameof(SoftSourceActor)] = value; } }
        public NiagaraUserParameterBinding MeshUserParameter { get { return this[nameof(MeshUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["MeshUserParameter"] = value; } }
    }
    public class NiagaraPhysicsAssetDICollectorInterface : Interface
    {
        public NiagaraPhysicsAssetDICollectorInterface(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceSimpleCounter : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSimpleCounter(nint addr) : base(addr) { }
        public ENiagaraGpuSyncMode GpuSyncMode { get { return (ENiagaraGpuSyncMode)this[nameof(GpuSyncMode)].GetValue<int>(); } set { this[nameof(GpuSyncMode)].SetValue<int>((int)value); } }
        public int InitialValue { get { return this[nameof(InitialValue)].GetValue<int>(); } set { this[nameof(InitialValue)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceStaticMesh : NiagaraDataInterface
    {
        public NiagaraDataInterfaceStaticMesh(nint addr) : base(addr) { }
        public ENDIStaticMesh_SourceMode SourceMode { get { return (ENDIStaticMesh_SourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public StaticMesh DefaultMesh { get { return this[nameof(DefaultMesh)].As<StaticMesh>(); } set { this["DefaultMesh"] = value; } }
        public Object SoftSourceActor { get { return this[nameof(SoftSourceActor)]; } set { this[nameof(SoftSourceActor)] = value; } }
        public StaticMeshComponent SourceComponent { get { return this[nameof(SourceComponent)].As<StaticMeshComponent>(); } set { this["SourceComponent"] = value; } }
        public NDIStaticMeshSectionFilter SectionFilter { get { return this[nameof(SectionFilter)].As<NDIStaticMeshSectionFilter>(); } set { this["SectionFilter"] = value; } }
        public bool bUsePhysicsBodyVelocity { get { return this[nameof(bUsePhysicsBodyVelocity)].Flag; } set { this[nameof(bUsePhysicsBodyVelocity)].Flag = value; } }
        public Array<Object> FilteredSockets { get { return new Array<Object>(this[nameof(FilteredSockets)].Address); } }
        public void OnSourceEndPlay(Actor InSource, byte Reason) { Invoke(nameof(OnSourceEndPlay), InSource, Reason); }
    }
    public class NiagaraDataInterfaceUObjectPropertyReader : NiagaraDataInterface
    {
        public NiagaraDataInterfaceUObjectPropertyReader(nint addr) : base(addr) { }
        public NiagaraUserParameterBinding UObjectParameterBinding { get { return this[nameof(UObjectParameterBinding)].As<NiagaraUserParameterBinding>(); } set { this["UObjectParameterBinding"] = value; } }
        public Array<NiagaraUObjectPropertyReaderRemap> PropertyRemap { get { return new Array<NiagaraUObjectPropertyReaderRemap>(this[nameof(PropertyRemap)].Address); } }
        public Object SourceActor { get { return this[nameof(SourceActor)]; } set { this[nameof(SourceActor)] = value; } }
        public Object SourceActorComponentClass { get { return this[nameof(SourceActorComponentClass)].As<Object>(); } set { this["SourceActorComponentClass"] = value; } } // ClassPtrProperty
        public void SetUObjectReaderPropertyRemap(NiagaraComponent NiagaraComponent, Object UserParameterName, Object GraphName, Object RemapName) { Invoke(nameof(SetUObjectReaderPropertyRemap), NiagaraComponent, UserParameterName, GraphName, RemapName); }
    }
    public class MovieSceneNiagaraSystemSpawnSection : MovieSceneSection
    {
        public MovieSceneNiagaraSystemSpawnSection(nint addr) : base(addr) { }
        public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior { get { return (ENiagaraSystemSpawnSectionStartBehavior)this[nameof(SectionStartBehavior)].GetValue<int>(); } set { this[nameof(SectionStartBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior { get { return (ENiagaraSystemSpawnSectionEvaluateBehavior)this[nameof(SectionEvaluateBehavior)].GetValue<int>(); } set { this[nameof(SectionEvaluateBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior { get { return (ENiagaraSystemSpawnSectionEndBehavior)this[nameof(SectionEndBehavior)].GetValue<int>(); } set { this[nameof(SectionEndBehavior)].SetValue<int>((int)value); } }
        public ENiagaraAgeUpdateMode AgeUpdateMode { get { return (ENiagaraAgeUpdateMode)this[nameof(AgeUpdateMode)].GetValue<int>(); } set { this[nameof(AgeUpdateMode)].SetValue<int>((int)value); } }
        public bool bAllowScalability { get { return this[nameof(bAllowScalability)].Flag; } set { this[nameof(bAllowScalability)].Flag = value; } }
    }
    public class MovieSceneNiagaraTrack : MovieSceneNameableTrack
    {
        public MovieSceneNiagaraTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneNiagaraSystemTrack : MovieSceneNiagaraTrack
    {
        public MovieSceneNiagaraSystemTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraParameterTrack : MovieSceneNiagaraTrack
    {
        public MovieSceneNiagaraParameterTrack(nint addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class MovieSceneNiagaraBoolParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraBoolParameterTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraColorParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraColorParameterTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraFloatParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraFloatParameterTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraIntegerParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraIntegerParameterTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraVectorParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraVectorParameterTrack(nint addr) : base(addr) { }
        public int ChannelsUsed { get { return this[nameof(ChannelsUsed)].GetValue<int>(); } set { this[nameof(ChannelsUsed)].SetValue<int>(value); } }
    }
    public class NiagaraActor : Actor
    {
        public NiagaraActor(nint addr) : base(addr) { }
        public NiagaraComponent NiagaraComponent { get { return this[nameof(NiagaraComponent)].As<NiagaraComponent>(); } set { this["NiagaraComponent"] = value; } }
        public bool bDestroyOnSystemFinish { get { return this[nameof(bDestroyOnSystemFinish)].Flag; } set { this[nameof(bDestroyOnSystemFinish)].Flag = value; } }
        public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish) { Invoke(nameof(SetDestroyOnSystemFinish), bShouldDestroyOnSystemFinish); }
        public void OnNiagaraSystemFinished(NiagaraComponent FinishedComponent) { Invoke(nameof(OnNiagaraSystemFinished), FinishedComponent); }
    }
    public class NiagaraBakerOutput : Object
    {
        public NiagaraBakerOutput(nint addr) : base(addr) { }
        public Object OutputName { get { return this[nameof(OutputName)]; } set { this[nameof(OutputName)] = value; } }
    }
    public class NiagaraBakerOutputSimCache : NiagaraBakerOutput
    {
        public NiagaraBakerOutputSimCache(nint addr) : base(addr) { }
        public Object SimCacheAssetPathFormat { get { return this[nameof(SimCacheAssetPathFormat)]; } set { this[nameof(SimCacheAssetPathFormat)] = value; } }
        public NiagaraSimCacheCreateParameters CreateParameters { get { return this[nameof(CreateParameters)].As<NiagaraSimCacheCreateParameters>(); } set { this["CreateParameters"] = value; } }
    }
    public class NiagaraBakerOutputTexture2D : NiagaraBakerOutput
    {
        public NiagaraBakerOutputTexture2D(nint addr) : base(addr) { }
        public NiagaraBakerTextureSource SourceBinding { get { return this[nameof(SourceBinding)].As<NiagaraBakerTextureSource>(); } set { this["SourceBinding"] = value; } }
        public bool bGenerateAtlas { get { return this[nameof(bGenerateAtlas)].Flag; } set { this[nameof(bGenerateAtlas)].Flag = value; } }
        public bool bGenerateFrames { get { return this[nameof(bGenerateFrames)].Flag; } set { this[nameof(bGenerateFrames)].Flag = value; } }
        public bool bExportFrames { get { return this[nameof(bExportFrames)].Flag; } set { this[nameof(bExportFrames)].Flag = value; } }
        public bool bSetTextureAddressX { get { return this[nameof(bSetTextureAddressX)].Flag; } set { this[nameof(bSetTextureAddressX)].Flag = value; } }
        public bool bSetTextureAddressY { get { return this[nameof(bSetTextureAddressY)].Flag; } set { this[nameof(bSetTextureAddressY)].Flag = value; } }
        public IntPoint FrameSize { get { return this[nameof(FrameSize)].As<IntPoint>(); } set { this["FrameSize"] = value; } }
        public IntPoint AtlasTextureSize { get { return this[nameof(AtlasTextureSize)].As<IntPoint>(); } set { this["AtlasTextureSize"] = value; } }
        public byte TextureAddressX { get { return this[nameof(TextureAddressX)].GetValue<byte>(); } set { this[nameof(TextureAddressX)].SetValue<byte>(value); } }
        public byte TextureAddressY { get { return this[nameof(TextureAddressY)].GetValue<byte>(); } set { this[nameof(TextureAddressY)].SetValue<byte>(value); } }
        public Object AtlasAssetPathFormat { get { return this[nameof(AtlasAssetPathFormat)]; } set { this[nameof(AtlasAssetPathFormat)] = value; } }
        public Object FramesAssetPathFormat { get { return this[nameof(FramesAssetPathFormat)]; } set { this[nameof(FramesAssetPathFormat)] = value; } }
        public Object FramesExportPathFormat { get { return this[nameof(FramesExportPathFormat)]; } set { this[nameof(FramesExportPathFormat)] = value; } }
    }
    public class NiagaraBakerOutputVolumeTexture : NiagaraBakerOutput
    {
        public NiagaraBakerOutputVolumeTexture(nint addr) : base(addr) { }
        public NiagaraBakerTextureSource SourceBinding { get { return this[nameof(SourceBinding)].As<NiagaraBakerTextureSource>(); } set { this["SourceBinding"] = value; } }
        public bool bGenerateAtlas { get { return this[nameof(bGenerateAtlas)].Flag; } set { this[nameof(bGenerateAtlas)].Flag = value; } }
        public bool bGenerateFrames { get { return this[nameof(bGenerateFrames)].Flag; } set { this[nameof(bGenerateFrames)].Flag = value; } }
        public bool bExportFrames { get { return this[nameof(bExportFrames)].Flag; } set { this[nameof(bExportFrames)].Flag = value; } }
        public Object AtlasAssetPathFormat { get { return this[nameof(AtlasAssetPathFormat)]; } set { this[nameof(AtlasAssetPathFormat)] = value; } }
        public Object FramesAssetPathFormat { get { return this[nameof(FramesAssetPathFormat)]; } set { this[nameof(FramesAssetPathFormat)] = value; } }
        public Object FramesExportPathFormat { get { return this[nameof(FramesExportPathFormat)]; } set { this[nameof(FramesExportPathFormat)] = value; } }
    }
    public class NiagaraBakerSettings : Object
    {
        public NiagaraBakerSettings(nint addr) : base(addr) { }
        public float StartSeconds { get { return this[nameof(StartSeconds)].GetValue<float>(); } set { this[nameof(StartSeconds)].SetValue<float>(value); } }
        public float DurationSeconds { get { return this[nameof(DurationSeconds)].GetValue<float>(); } set { this[nameof(DurationSeconds)].SetValue<float>(value); } }
        public int FramesPerSecond { get { return this[nameof(FramesPerSecond)].GetValue<int>(); } set { this[nameof(FramesPerSecond)].SetValue<int>(value); } }
        public bool bPreviewLooping { get { return this[nameof(bPreviewLooping)].Flag; } set { this[nameof(bPreviewLooping)].Flag = value; } }
        public IntPoint FramesPerDimension { get { return this[nameof(FramesPerDimension)].As<IntPoint>(); } set { this["FramesPerDimension"] = value; } }
        public Array<NiagaraBakerOutput> Outputs { get { return new Array<NiagaraBakerOutput>(this[nameof(Outputs)].Address); } }
        public Array<NiagaraBakerCameraSettings> CameraSettings { get { return new Array<NiagaraBakerCameraSettings>(this[nameof(CameraSettings)].Address); } }
        public int CurrentCameraIndex { get { return this[nameof(CurrentCameraIndex)].GetValue<int>(); } set { this[nameof(CurrentCameraIndex)].SetValue<int>(value); } }
        public Object BakeQualityLevel { get { return this[nameof(BakeQualityLevel)]; } set { this[nameof(BakeQualityLevel)] = value; } }
        public bool bRenderComponentOnly { get { return this[nameof(bRenderComponentOnly)].Flag; } set { this[nameof(bRenderComponentOnly)].Flag = value; } }
        public Array<NiagaraBakerTextureSettings> OutputTextures { get { return new Array<NiagaraBakerTextureSettings>(this[nameof(OutputTextures)].Address); } }
        public ENiagaraBakerViewMode CameraViewportMode { get { return (ENiagaraBakerViewMode)this[nameof(CameraViewportMode)].GetValue<int>(); } set { this[nameof(CameraViewportMode)].SetValue<int>((int)value); } }
        public Vector CameraViewportLocation { get { return this[nameof(CameraViewportLocation)].As<Vector>(); } set { this["CameraViewportLocation"] = value; } }
        public Rotator CameraViewportRotation { get { return this[nameof(CameraViewportRotation)].As<Rotator>(); } set { this["CameraViewportRotation"] = value; } }
        public float CameraOrbitDistance { get { return this[nameof(CameraOrbitDistance)].GetValue<float>(); } set { this[nameof(CameraOrbitDistance)].SetValue<float>(value); } }
        public float CameraFOV { get { return this[nameof(CameraFOV)].GetValue<float>(); } set { this[nameof(CameraFOV)].SetValue<float>(value); } }
        public float CameraOrthoWidth { get { return this[nameof(CameraOrthoWidth)].GetValue<float>(); } set { this[nameof(CameraOrthoWidth)].SetValue<float>(value); } }
        public bool bUseCameraAspectRatio { get { return this[nameof(bUseCameraAspectRatio)].Flag; } set { this[nameof(bUseCameraAspectRatio)].Flag = value; } }
        public float CameraAspectRatio { get { return this[nameof(CameraAspectRatio)].GetValue<float>(); } set { this[nameof(CameraAspectRatio)].SetValue<float>(value); } }
    }
    public class NiagaraComponent : FXSystemComponent
    {
        public NiagaraComponent(nint addr) : base(addr) { }
        public NiagaraSystem Asset { get { return this[nameof(Asset)].As<NiagaraSystem>(); } set { this["Asset"] = value; } }
        public ENiagaraTickBehavior TickBehavior { get { return (ENiagaraTickBehavior)this[nameof(TickBehavior)].GetValue<int>(); } set { this[nameof(TickBehavior)].SetValue<int>((int)value); } }
        public int RandomSeedOffset { get { return this[nameof(RandomSeedOffset)].GetValue<int>(); } set { this[nameof(RandomSeedOffset)].SetValue<int>(value); } }
        public NiagaraUserRedirectionParameterStore OverrideParameters { get { return this[nameof(OverrideParameters)].As<NiagaraUserRedirectionParameterStore>(); } set { this["OverrideParameters"] = value; } }
        public bool bForceSolo { get { return this[nameof(bForceSolo)].Flag; } set { this[nameof(bForceSolo)].Flag = value; } }
        public bool bEnableGpuComputeDebug { get { return this[nameof(bEnableGpuComputeDebug)].Flag; } set { this[nameof(bEnableGpuComputeDebug)].Flag = value; } }
        public bool bAutoDestroy { get { return this[nameof(bAutoDestroy)].Flag; } set { this[nameof(bAutoDestroy)].Flag = value; } }
        public bool bRenderingEnabled { get { return this[nameof(bRenderingEnabled)].Flag; } set { this[nameof(bRenderingEnabled)].Flag = value; } }
        public bool bAutoManageAttachment { get { return this[nameof(bAutoManageAttachment)].Flag; } set { this[nameof(bAutoManageAttachment)].Flag = value; } }
        public bool bAutoAttachWeldSimulatedBodies { get { return this[nameof(bAutoAttachWeldSimulatedBodies)].Flag; } set { this[nameof(bAutoAttachWeldSimulatedBodies)].Flag = value; } }
        public float MaxTimeBeforeForceUpdateTransform { get { return this[nameof(MaxTimeBeforeForceUpdateTransform)].GetValue<float>(); } set { this[nameof(MaxTimeBeforeForceUpdateTransform)].SetValue<float>(value); } }
        public Object OnSystemFinished { get { return this[nameof(OnSystemFinished)]; } set { this[nameof(OnSystemFinished)] = value; } }
        public Object AutoAttachParent { get { return this[nameof(AutoAttachParent)]; } set { this[nameof(AutoAttachParent)] = value; } }
        public Object AutoAttachSocketName { get { return this[nameof(AutoAttachSocketName)]; } set { this[nameof(AutoAttachSocketName)] = value; } }
        public EAttachmentRule AutoAttachLocationRule { get { return (EAttachmentRule)this[nameof(AutoAttachLocationRule)].GetValue<int>(); } set { this[nameof(AutoAttachLocationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AutoAttachRotationRule { get { return (EAttachmentRule)this[nameof(AutoAttachRotationRule)].GetValue<int>(); } set { this[nameof(AutoAttachRotationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AutoAttachScaleRule { get { return (EAttachmentRule)this[nameof(AutoAttachScaleRule)].GetValue<int>(); } set { this[nameof(AutoAttachScaleRule)].SetValue<int>((int)value); } }
        public bool bAllowScalability { get { return this[nameof(bAllowScalability)].Flag; } set { this[nameof(bAllowScalability)].Flag = value; } }
        public NiagaraSimCache SimCache { get { return this[nameof(SimCache)].As<NiagaraSimCache>(); } set { this["SimCache"] = value; } }
        public NiagaraCullProxyComponent CullProxy { get { return this[nameof(CullProxy)].As<NiagaraCullProxyComponent>(); } set { this["CullProxy"] = value; } }
        public void SetVariableVec4(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetVariableVec4), InVariableName, InValue); }
        public void SetVariableVec3(Object InVariableName, Vector InValue) { Invoke(nameof(SetVariableVec3), InVariableName, InValue); }
        public void SetVariableVec2(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetVariableVec2), InVariableName, InValue); }
        public void SetVariableTextureRenderTarget(Object InVariableName, TextureRenderTarget TextureRenderTarget) { Invoke(nameof(SetVariableTextureRenderTarget), InVariableName, TextureRenderTarget); }
        public void SetVariableTexture(Object InVariableName, Texture Texture) { Invoke(nameof(SetVariableTexture), InVariableName, Texture); }
        public void SetVariableStaticMesh(Object InVariableName, StaticMesh InValue) { Invoke(nameof(SetVariableStaticMesh), InVariableName, InValue); }
        public void SetVariableQuat(Object InVariableName, Quat InValue) { Invoke(nameof(SetVariableQuat), InVariableName, InValue); }
        public void SetVariablePosition(Object InVariableName, Vector InValue) { Invoke(nameof(SetVariablePosition), InVariableName, InValue); }
        public void SetVariableObject(Object InVariableName, Object Object) { Invoke(nameof(SetVariableObject), InVariableName, Object); }
        public void SetVariableMatrix(Object InVariableName, Matrix InValue) { Invoke(nameof(SetVariableMatrix), InVariableName, InValue); }
        public void SetVariableMaterial(Object InVariableName, MaterialInterface Object) { Invoke(nameof(SetVariableMaterial), InVariableName, Object); }
        public void SetVariableLinearColor(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetVariableLinearColor), InVariableName, InValue); }
        public void SetVariableInt(Object InVariableName, int InValue) { Invoke(nameof(SetVariableInt), InVariableName, InValue); }
        public void SetVariableFloat(Object InVariableName, float InValue) { Invoke(nameof(SetVariableFloat), InVariableName, InValue); }
        public void SetVariableBool(Object InVariableName, bool InValue) { Invoke(nameof(SetVariableBool), InVariableName, InValue); }
        public void SetVariableActor(Object InVariableName, Actor Actor) { Invoke(nameof(SetVariableActor), InVariableName, Actor); }
        public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior) { Invoke(nameof(SetTickBehavior), NewTickBehavior); }
        public void SetSystemFixedBounds(Box LocalBounds) { Invoke(nameof(SetSystemFixedBounds), LocalBounds); }
        public void SetSimCache(NiagaraSimCache SimCache, bool bResetSystem) { Invoke(nameof(SetSimCache), SimCache, bResetSystem); }
        public void SetSeekDelta(float InSeekDelta) { Invoke(nameof(SetSeekDelta), InSeekDelta); }
        public void SetRenderingEnabled(bool bInRenderingEnabled) { Invoke(nameof(SetRenderingEnabled), bInRenderingEnabled); }
        public void SetRandomSeedOffset(int NewRandomSeedOffset) { Invoke(nameof(SetRandomSeedOffset), NewRandomSeedOffset); }
        public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance, float PreviewMaxDistance) { Invoke(nameof(SetPreviewLODDistance), bEnablePreviewLODDistance, PreviewLODDistance, PreviewMaxDistance); }
        public void SetPaused(bool bInPaused) { Invoke(nameof(SetPaused), bInPaused); }
        public void SetNiagaraVariableVec4(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetNiagaraVariableVec4), InVariableName, InValue); }
        public void SetNiagaraVariableVec3(Object InVariableName, Vector InValue) { Invoke(nameof(SetNiagaraVariableVec3), InVariableName, InValue); }
        public void SetNiagaraVariableVec2(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetNiagaraVariableVec2), InVariableName, InValue); }
        public void SetNiagaraVariableQuat(Object InVariableName, Quat InValue) { Invoke(nameof(SetNiagaraVariableQuat), InVariableName, InValue); }
        public void SetNiagaraVariablePosition(Object InVariableName, Vector InValue) { Invoke(nameof(SetNiagaraVariablePosition), InVariableName, InValue); }
        public void SetNiagaraVariableObject(Object InVariableName, Object Object) { Invoke(nameof(SetNiagaraVariableObject), InVariableName, Object); }
        public void SetNiagaraVariableMatrix(Object InVariableName, Matrix InValue) { Invoke(nameof(SetNiagaraVariableMatrix), InVariableName, InValue); }
        public void SetNiagaraVariableLinearColor(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetNiagaraVariableLinearColor), InVariableName, InValue); }
        public void SetNiagaraVariableInt(Object InVariableName, int InValue) { Invoke(nameof(SetNiagaraVariableInt), InVariableName, InValue); }
        public void SetNiagaraVariableFloat(Object InVariableName, float InValue) { Invoke(nameof(SetNiagaraVariableFloat), InVariableName, InValue); }
        public void SetNiagaraVariableBool(Object InVariableName, bool InValue) { Invoke(nameof(SetNiagaraVariableBool), InVariableName, InValue); }
        public void SetNiagaraVariableActor(Object InVariableName, Actor Actor) { Invoke(nameof(SetNiagaraVariableActor), InVariableName, Actor); }
        public void SetMaxSimTime(float InMaxTime) { Invoke(nameof(SetMaxSimTime), InMaxTime); }
        public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock) { Invoke(nameof(SetLockDesiredAgeDeltaTimeToSeekDelta), bLock); }
        public void SetGpuComputeDebug(bool bEnableDebug) { Invoke(nameof(SetGpuComputeDebug), bEnableDebug); }
        public void SetForceSolo(bool bInForceSolo) { Invoke(nameof(SetForceSolo), bInForceSolo); }
        public void SetForceLocalPlayerEffect(bool bIsPlayerEffect) { Invoke(nameof(SetForceLocalPlayerEffect), bIsPlayerEffect); }
        public void SetEmitterFixedBounds(Object EmitterName, Box LocalBounds) { Invoke(nameof(SetEmitterFixedBounds), EmitterName, LocalBounds); }
        public void SetDesiredAge(float InDesiredAge) { Invoke(nameof(SetDesiredAge), InDesiredAge); }
        public void SetCustomTimeDilation(float Dilation) { Invoke(nameof(SetCustomTimeDilation), Dilation); }
        public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking) { Invoke(nameof(SetCanRenderWhileSeeking), bInCanRenderWhileSeeking); }
        public void SetAutoDestroy(bool bInAutoDestroy) { Invoke(nameof(SetAutoDestroy), bInAutoDestroy); }
        public void SetAsset(NiagaraSystem InAsset, bool bResetExistingOverrideParameters) { Invoke(nameof(SetAsset), InAsset, bResetExistingOverrideParameters); }
        public void SetAllowScalability(bool bAllow) { Invoke(nameof(SetAllowScalability), bAllow); }
        public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode) { Invoke(nameof(SetAgeUpdateMode), InAgeUpdateMode); }
        public void SeekToDesiredAge(float InDesiredAge) { Invoke(nameof(SeekToDesiredAge), InDesiredAge); }
        public void ResetSystem() { Invoke(nameof(ResetSystem)); }
        public void ReinitializeSystem() { Invoke(nameof(ReinitializeSystem)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
        public void InitForPerformanceBaseline() { Invoke(nameof(InitForPerformanceBaseline)); }
        public ENiagaraTickBehavior GetTickBehavior() { return Invoke<ENiagaraTickBehavior>(nameof(GetTickBehavior)); }
        public Box GetSystemFixedBounds() { return Invoke<Box>(nameof(GetSystemFixedBounds)); }
        public NiagaraSimCache GetSimCache() { return Invoke<NiagaraSimCache>(nameof(GetSimCache)); }
        public float GetSeekDelta() { return Invoke<float>(nameof(GetSeekDelta)); }
        public int GetRandomSeedOffset() { return Invoke<int>(nameof(GetRandomSeedOffset)); }
        public bool GetPreviewLODDistanceEnabled() { return Invoke<bool>(nameof(GetPreviewLODDistanceEnabled)); }
        public float GetPreviewLODDistance() { return Invoke<float>(nameof(GetPreviewLODDistance)); }
        public Array<Vector> GetNiagaraParticleValueVec3_DebugOnly(Object InEmitterName, Object InValueName) { return Invoke<Array<Vector>>(nameof(GetNiagaraParticleValueVec3_DebugOnly), InEmitterName, InValueName); }
        public Array<float> GetNiagaraParticleValues_DebugOnly(Object InEmitterName, Object InValueName) { return Invoke<Array<float>>(nameof(GetNiagaraParticleValues_DebugOnly), InEmitterName, InValueName); }
        public Array<Vector> GetNiagaraParticlePositions_DebugOnly(Object InEmitterName) { return Invoke<Array<Vector>>(nameof(GetNiagaraParticlePositions_DebugOnly), InEmitterName); }
        public float GetMaxSimTime() { return Invoke<float>(nameof(GetMaxSimTime)); }
        public bool GetLockDesiredAgeDeltaTimeToSeekDelta() { return Invoke<bool>(nameof(GetLockDesiredAgeDeltaTimeToSeekDelta)); }
        public bool GetForceSolo() { return Invoke<bool>(nameof(GetForceSolo)); }
        public bool GetForceLocalPlayerEffect() { return Invoke<bool>(nameof(GetForceLocalPlayerEffect)); }
        public Box GetEmitterFixedBounds(Object EmitterName) { return Invoke<Box>(nameof(GetEmitterFixedBounds), EmitterName); }
        public float GetDesiredAge() { return Invoke<float>(nameof(GetDesiredAge)); }
        public NiagaraDataInterface GetDataInterface(Object Name) { return Invoke<NiagaraDataInterface>(nameof(GetDataInterface), Name); }
        public float GetCustomTimeDilation() { return Invoke<float>(nameof(GetCustomTimeDilation)); }
        public NiagaraSystem GetAsset() { return Invoke<NiagaraSystem>(nameof(GetAsset)); }
        public bool GetAllowScalability() { return Invoke<bool>(nameof(GetAllowScalability)); }
        public ENiagaraAgeUpdateMode GetAgeUpdateMode() { return Invoke<ENiagaraAgeUpdateMode>(nameof(GetAgeUpdateMode)); }
        public void ClearSystemFixedBounds() { Invoke(nameof(ClearSystemFixedBounds)); }
        public void ClearSimCache(bool bResetSystem) { Invoke(nameof(ClearSimCache), bResetSystem); }
        public void ClearEmitterFixedBounds(Object EmitterName) { Invoke(nameof(ClearEmitterFixedBounds), EmitterName); }
        public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds) { Invoke(nameof(AdvanceSimulationByTime), SimulateTime, TickDeltaSeconds); }
        public void AdvanceSimulation(int TickCount, float TickDeltaSeconds) { Invoke(nameof(AdvanceSimulation), TickCount, TickDeltaSeconds); }
    }
    public class NiagaraComponentPool : Object
    {
        public NiagaraComponentPool(nint addr) : base(addr) { }
        public Object WorldParticleSystemPools { get { return this[nameof(WorldParticleSystemPools)]; } set { this[nameof(WorldParticleSystemPools)] = value; } }
    }
    public class NiagaraRendererProperties : NiagaraMergeable
    {
        public NiagaraRendererProperties(nint addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public int SortOrderHint { get { return this[nameof(SortOrderHint)].GetValue<int>(); } set { this[nameof(SortOrderHint)].SetValue<int>(value); } }
        public ENiagaraRendererMotionVectorSetting MotionVectorSetting { get { return (ENiagaraRendererMotionVectorSetting)this[nameof(MotionVectorSetting)].GetValue<int>(); } set { this[nameof(MotionVectorSetting)].SetValue<int>((int)value); } }
        public NiagaraVariableAttributeBinding RendererEnabledBinding { get { return this[nameof(RendererEnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererEnabledBinding"] = value; } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public bool bAllowInCullProxies { get { return this[nameof(bAllowInCullProxies)].Flag; } set { this[nameof(bAllowInCullProxies)].Flag = value; } }
        public Guid OuterEmitterVersion { get { return this[nameof(OuterEmitterVersion)].As<Guid>(); } set { this["OuterEmitterVersion"] = value; } }
        public bool bMotionBlurEnabled { get { return this[nameof(bMotionBlurEnabled)].Flag; } set { this[nameof(bMotionBlurEnabled)].Flag = value; } }
    }
    public class NiagaraComponentRendererProperties : NiagaraRendererProperties
    {
        public NiagaraComponentRendererProperties(nint addr) : base(addr) { }
        public Object ComponentType { get { return this[nameof(ComponentType)]; } set { this[nameof(ComponentType)] = value; } }
        public uint ComponentCountLimit { get { return this[nameof(ComponentCountLimit)].GetValue<uint>(); } set { this[nameof(ComponentCountLimit)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding EnabledBinding { get { return this[nameof(EnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["EnabledBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
        public bool bAssignComponentsOnParticleID { get { return this[nameof(bAssignComponentsOnParticleID)].Flag; } set { this[nameof(bAssignComponentsOnParticleID)].Flag = value; } }
        public bool bCreateComponentFirstParticleFrame { get { return this[nameof(bCreateComponentFirstParticleFrame)].Flag; } set { this[nameof(bCreateComponentFirstParticleFrame)].Flag = value; } }
        public bool bOnlyActivateNewlyAquiredComponents { get { return this[nameof(bOnlyActivateNewlyAquiredComponents)].Flag; } set { this[nameof(bOnlyActivateNewlyAquiredComponents)].Flag = value; } }
        public int RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<int>(); } set { this[nameof(RendererVisibility)].SetValue<int>(value); } }
        public SceneComponent TemplateComponent { get { return this[nameof(TemplateComponent)].As<SceneComponent>(); } set { this["TemplateComponent"] = value; } }
        public Array<NiagaraComponentPropertyBinding> PropertyBindings { get { return new Array<NiagaraComponentPropertyBinding>(this[nameof(PropertyBindings)].Address); } }
    }
    public class NiagaraComponentSettings : Object
    {
        public NiagaraComponentSettings(nint addr) : base(addr) { }
        public Object SuppressActivationList { get { return this[nameof(SuppressActivationList)]; } set { this[nameof(SuppressActivationList)] = value; } }
        public Object ForceAutoPooolingList { get { return this[nameof(ForceAutoPooolingList)]; } set { this[nameof(ForceAutoPooolingList)] = value; } }
        public Object SuppressEmitterList { get { return this[nameof(SuppressEmitterList)]; } set { this[nameof(SuppressEmitterList)] = value; } }
        public Object GPUEmitterAllowList { get { return this[nameof(GPUEmitterAllowList)]; } set { this[nameof(GPUEmitterAllowList)] = value; } }
        public Object GpuDataInterfaceDenyList { get { return this[nameof(GpuDataInterfaceDenyList)]; } set { this[nameof(GpuDataInterfaceDenyList)] = value; } }
    }
    public class NiagaraCullProxyComponent : NiagaraComponent
    {
        public NiagaraCullProxyComponent(nint addr) : base(addr) { }
        public Array<NiagaraCulledComponentInfo> Instances { get { return new Array<NiagaraCulledComponentInfo>(this[nameof(Instances)].Address); } }
    }
    public class NiagaraDataInterface2DArrayTexture : NiagaraDataInterface
    {
        public NiagaraDataInterface2DArrayTexture(nint addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
        public NiagaraUserParameterBinding TextureUserParameter { get { return this[nameof(TextureUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["TextureUserParameter"] = value; } }
    }
    public class NiagaraDataInterfaceRWBase : NiagaraDataInterface
    {
        public NiagaraDataInterfaceRWBase(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceArray : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceArray(nint addr) : base(addr) { }
        public ENiagaraGpuSyncMode GpuSyncMode { get { return (ENiagaraGpuSyncMode)this[nameof(GpuSyncMode)].GetValue<int>(); } set { this[nameof(GpuSyncMode)].SetValue<int>((int)value); } }
        public int MaxElements { get { return this[nameof(MaxElements)].GetValue<int>(); } set { this[nameof(MaxElements)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceArrayFloat : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat(nint addr) : base(addr) { }
        //public Array<float> FloatData { get { return new Array<float>(this[nameof(FloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat2 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat2(nint addr) : base(addr) { }
        public Array<Vector2f> InternalFloatData { get { return new Array<Vector2f>(this[nameof(InternalFloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat3 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat3(nint addr) : base(addr) { }
        public Array<Vector3f> InternalFloatData { get { return new Array<Vector3f>(this[nameof(InternalFloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayPosition : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayPosition(nint addr) : base(addr) { }
        public Array<NiagaraPosition> PositionData { get { return new Array<NiagaraPosition>(this[nameof(PositionData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat4 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat4(nint addr) : base(addr) { }
        public Array<Vector4f> InternalFloatData { get { return new Array<Vector4f>(this[nameof(InternalFloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayColor : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayColor(nint addr) : base(addr) { }
        public Array<LinearColor> ColorData { get { return new Array<LinearColor>(this[nameof(ColorData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayQuat : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayQuat(nint addr) : base(addr) { }
        public Array<Quat4f> InternalQuatData { get { return new Array<Quat4f>(this[nameof(InternalQuatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraDataInterfaceArrayFunctionLibrary(nint addr) : base(addr) { }
        public void SetNiagaraArrayVectorValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, Vector Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayVectorValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayVector4Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, Vector4 Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayVector4Value), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayVector4(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector4> ArrayData) { Invoke(nameof(SetNiagaraArrayVector4), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayVector2DValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, Vector2D Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayVector2DValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayVector2D(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector2D> ArrayData) { Invoke(nameof(SetNiagaraArrayVector2D), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayVector(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector> ArrayData) { Invoke(nameof(SetNiagaraArrayVector), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayUInt8Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, int Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayUInt8Value), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayUInt8(NiagaraComponent NiagaraSystem, Object OverrideName, Array<int> ArrayData) { Invoke(nameof(SetNiagaraArrayUInt8), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayQuatValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, Quat Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayQuatValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayQuat(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Quat> ArrayData) { Invoke(nameof(SetNiagaraArrayQuat), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayPositionValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, Vector Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayPositionValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayPosition(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector> ArrayData) { Invoke(nameof(SetNiagaraArrayPosition), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayInt32Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, int Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayInt32Value), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayInt32(NiagaraComponent NiagaraSystem, Object OverrideName, Array<int> ArrayData) { Invoke(nameof(SetNiagaraArrayInt32), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayFloatValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, float Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayFloatValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayFloat(NiagaraComponent NiagaraSystem, Object OverrideName, Array<float> ArrayData) { Invoke(nameof(SetNiagaraArrayFloat), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayColorValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, LinearColor Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayColorValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayColor(NiagaraComponent NiagaraSystem, Object OverrideName, Array<LinearColor> ArrayData) { Invoke(nameof(SetNiagaraArrayColor), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayBoolValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index, bool Value, bool bSizeToFit) { Invoke(nameof(SetNiagaraArrayBoolValue), NiagaraSystem, OverrideName, Index, Value, bSizeToFit); }
        public void SetNiagaraArrayBool(NiagaraComponent NiagaraSystem, Object OverrideName, Array<bool> ArrayData) { Invoke(nameof(SetNiagaraArrayBool), NiagaraSystem, OverrideName, ArrayData); }
        public Vector GetNiagaraArrayVectorValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<Vector>(nameof(GetNiagaraArrayVectorValue), NiagaraSystem, OverrideName, Index); }
        public Vector4 GetNiagaraArrayVector4Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<Vector4>(nameof(GetNiagaraArrayVector4Value), NiagaraSystem, OverrideName, Index); }
        public Array<Vector4> GetNiagaraArrayVector4(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector4>>(nameof(GetNiagaraArrayVector4), NiagaraSystem, OverrideName); }
        public Vector2D GetNiagaraArrayVector2DValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<Vector2D>(nameof(GetNiagaraArrayVector2DValue), NiagaraSystem, OverrideName, Index); }
        public Array<Vector2D> GetNiagaraArrayVector2D(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector2D>>(nameof(GetNiagaraArrayVector2D), NiagaraSystem, OverrideName); }
        public Array<Vector> GetNiagaraArrayVector(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector>>(nameof(GetNiagaraArrayVector), NiagaraSystem, OverrideName); }
        public int GetNiagaraArrayUInt8Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<int>(nameof(GetNiagaraArrayUInt8Value), NiagaraSystem, OverrideName, Index); }
        public Array<int> GetNiagaraArrayUInt8(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<int>>(nameof(GetNiagaraArrayUInt8), NiagaraSystem, OverrideName); }
        public Quat GetNiagaraArrayQuatValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<Quat>(nameof(GetNiagaraArrayQuatValue), NiagaraSystem, OverrideName, Index); }
        public Array<Quat> GetNiagaraArrayQuat(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Quat>>(nameof(GetNiagaraArrayQuat), NiagaraSystem, OverrideName); }
        public Vector GetNiagaraArrayPositionValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<Vector>(nameof(GetNiagaraArrayPositionValue), NiagaraSystem, OverrideName, Index); }
        public Array<Vector> GetNiagaraArrayPosition(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector>>(nameof(GetNiagaraArrayPosition), NiagaraSystem, OverrideName); }
        public int GetNiagaraArrayInt32Value(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<int>(nameof(GetNiagaraArrayInt32Value), NiagaraSystem, OverrideName, Index); }
        public Array<int> GetNiagaraArrayInt32(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<int>>(nameof(GetNiagaraArrayInt32), NiagaraSystem, OverrideName); }
        public float GetNiagaraArrayFloatValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<float>(nameof(GetNiagaraArrayFloatValue), NiagaraSystem, OverrideName, Index); }
        public Array<float> GetNiagaraArrayFloat(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<float>>(nameof(GetNiagaraArrayFloat), NiagaraSystem, OverrideName); }
        public LinearColor GetNiagaraArrayColorValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<LinearColor>(nameof(GetNiagaraArrayColorValue), NiagaraSystem, OverrideName, Index); }
        public Array<LinearColor> GetNiagaraArrayColor(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<LinearColor>>(nameof(GetNiagaraArrayColor), NiagaraSystem, OverrideName); }
        public bool GetNiagaraArrayBoolValue(NiagaraComponent NiagaraSystem, Object OverrideName, int Index) { return Invoke<bool>(nameof(GetNiagaraArrayBoolValue), NiagaraSystem, OverrideName, Index); }
        public Array<bool> GetNiagaraArrayBool(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<bool>>(nameof(GetNiagaraArrayBool), NiagaraSystem, OverrideName); }
    }
    public class NiagaraDataInterfaceArrayInt32 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayInt32(nint addr) : base(addr) { }
        public Array<int> IntData { get { return new Array<int>(this[nameof(IntData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayUInt8 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayUInt8(nint addr) : base(addr) { }
        public Array<byte> InternalIntData { get { return new Array<byte>(this[nameof(InternalIntData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayBool : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayBool(nint addr) : base(addr) { }
        public Array<bool> BoolData { get { return new Array<bool>(this[nameof(BoolData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayNiagaraID : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayNiagaraID(nint addr) : base(addr) { }
        public Array<NiagaraID> IntData { get { return new Array<NiagaraID>(this[nameof(IntData)].Address); } }
    }
    public class NiagaraDataInterfaceAudioSubmix : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioSubmix(nint addr) : base(addr) { }
        public SoundSubmix Submix { get { return this[nameof(Submix)].As<SoundSubmix>(); } set { this["Submix"] = value; } }
    }
    public class NiagaraDataInterfaceAudioOscilloscope : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioOscilloscope(nint addr) : base(addr) { }
        public SoundSubmix Submix { get { return this[nameof(Submix)].As<SoundSubmix>(); } set { this["Submix"] = value; } }
        public int Resolution { get { return this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>(value); } }
        public float ScopeInMilliseconds { get { return this[nameof(ScopeInMilliseconds)].GetValue<float>(); } set { this[nameof(ScopeInMilliseconds)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceAudioPlayer : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioPlayer(nint addr) : base(addr) { }
        public SoundBase SoundToPlay { get { return this[nameof(SoundToPlay)].As<SoundBase>(); } set { this["SoundToPlay"] = value; } }
        public SoundAttenuation Attenuation { get { return this[nameof(Attenuation)].As<SoundAttenuation>(); } set { this["Attenuation"] = value; } }
        public SoundConcurrency Concurrency { get { return this[nameof(Concurrency)].As<SoundConcurrency>(); } set { this["Concurrency"] = value; } }
        public Array<Object> ParameterNames { get { return new Array<Object>(this[nameof(ParameterNames)].Address); } }
        public bool bLimitPlaysPerTick { get { return this[nameof(bLimitPlaysPerTick)].Flag; } set { this[nameof(bLimitPlaysPerTick)].Flag = value; } }
        public int MaxPlaysPerTick { get { return this[nameof(MaxPlaysPerTick)].GetValue<int>(); } set { this[nameof(MaxPlaysPerTick)].SetValue<int>(value); } }
        public bool bStopWhenComponentIsDestroyed { get { return this[nameof(bStopWhenComponentIsDestroyed)].Flag; } set { this[nameof(bStopWhenComponentIsDestroyed)].Flag = value; } }
        public bool bAllowLoopingOneShotSounds { get { return this[nameof(bAllowLoopingOneShotSounds)].Flag; } set { this[nameof(bAllowLoopingOneShotSounds)].Flag = value; } }
    }
    public class NiagaraDataInterfaceAudioSpectrum : NiagaraDataInterfaceAudioSubmix
    {
        public NiagaraDataInterfaceAudioSpectrum(nint addr) : base(addr) { }
        public int Resolution { get { return this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceCamera : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCamera(nint addr) : base(addr) { }
        public int PlayerControllerIndex { get { return this[nameof(PlayerControllerIndex)].GetValue<int>(); } set { this[nameof(PlayerControllerIndex)].SetValue<int>(value); } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
    }
    public class NiagaraDataInterfaceCollisionQuery : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCollisionQuery(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceCurveBase : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCurveBase(nint addr) : base(addr) { }
        public Array<float> ShaderLUT { get { return new Array<float>(this[nameof(ShaderLUT)].Address); } }
        public float LUTMinTime { get { return this[nameof(LUTMinTime)].GetValue<float>(); } set { this[nameof(LUTMinTime)].SetValue<float>(value); } }
        public float LUTMaxTime { get { return this[nameof(LUTMaxTime)].GetValue<float>(); } set { this[nameof(LUTMaxTime)].SetValue<float>(value); } }
        public float LUTInvTimeRange { get { return this[nameof(LUTInvTimeRange)].GetValue<float>(); } set { this[nameof(LUTInvTimeRange)].SetValue<float>(value); } }
        public float LUTNumSamplesMinusOne { get { return this[nameof(LUTNumSamplesMinusOne)].GetValue<float>(); } set { this[nameof(LUTNumSamplesMinusOne)].SetValue<float>(value); } }
        public bool bUseLUT { get { return this[nameof(bUseLUT)].Flag; } set { this[nameof(bUseLUT)].Flag = value; } }
        public bool bExposeCurve { get { return this[nameof(bExposeCurve)].Flag; } set { this[nameof(bExposeCurve)].Flag = value; } }
        public Object ExposedName { get { return this[nameof(ExposedName)]; } set { this[nameof(ExposedName)] = value; } }
        public Texture2D ExposedTexture { get { return this[nameof(ExposedTexture)].As<Texture2D>(); } set { this["ExposedTexture"] = value; } }
    }
    public class NiagaraDataInterfaceColorCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceColorCurve(nint addr) : base(addr) { }
        public RichCurve RedCurve { get { return this[nameof(RedCurve)].As<RichCurve>(); } set { this["RedCurve"] = value; } }
        public RichCurve GreenCurve { get { return this[nameof(GreenCurve)].As<RichCurve>(); } set { this["GreenCurve"] = value; } }
        public RichCurve BlueCurve { get { return this[nameof(BlueCurve)].As<RichCurve>(); } set { this["BlueCurve"] = value; } }
        public RichCurve AlphaCurve { get { return this[nameof(AlphaCurve)].As<RichCurve>(); } set { this["AlphaCurve"] = value; } }
    }
    public class NiagaraDataInterfaceCubeTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCubeTexture(nint addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
        public NiagaraUserParameterBinding TextureUserParameter { get { return this[nameof(TextureUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["TextureUserParameter"] = value; } }
    }
    public class NiagaraDataInterfaceCurlNoise : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCurlNoise(nint addr) : base(addr) { }
        public uint Seed { get { return this[nameof(Seed)].GetValue<uint>(); } set { this[nameof(Seed)].SetValue<uint>(value); } }
    }
    public class NiagaraDataInterfaceCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceCurve(nint addr) : base(addr) { }
        public RichCurve Curve { get { return this[nameof(Curve)].As<RichCurve>(); } set { this["Curve"] = value; } }
    }
    public class NiagaraParticleCallbackHandler : Interface
    {
        public NiagaraParticleCallbackHandler(nint addr) : base(addr) { }
        public void ReceiveParticleData(Array<BasicParticleData> Data, NiagaraSystem NiagaraSystem, Vector SimulationPositionOffset) { Invoke(nameof(ReceiveParticleData), Data, NiagaraSystem, SimulationPositionOffset); }
    }
    public class NiagaraDataInterfaceExport : NiagaraDataInterface
    {
        public NiagaraDataInterfaceExport(nint addr) : base(addr) { }
        public NiagaraUserParameterBinding CallbackHandlerParameter { get { return this[nameof(CallbackHandlerParameter)].As<NiagaraUserParameterBinding>(); } set { this["CallbackHandlerParameter"] = value; } }
        public ENDIExport_GPUAllocationMode GPUAllocationMode { get { return (ENDIExport_GPUAllocationMode)this[nameof(GPUAllocationMode)].GetValue<int>(); } set { this[nameof(GPUAllocationMode)].SetValue<int>((int)value); } }
        public int GPUAllocationFixedSize { get { return this[nameof(GPUAllocationFixedSize)].GetValue<int>(); } set { this[nameof(GPUAllocationFixedSize)].SetValue<int>(value); } }
        public float GPUAllocationPerParticleSize { get { return this[nameof(GPUAllocationPerParticleSize)].GetValue<float>(); } set { this[nameof(GPUAllocationPerParticleSize)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceGrid2D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceGrid2D(nint addr) : base(addr) { }
        public int NumCellsX { get { return this[nameof(NumCellsX)].GetValue<int>(); } set { this[nameof(NumCellsX)].SetValue<int>(value); } }
        public int NumCellsY { get { return this[nameof(NumCellsY)].GetValue<int>(); } set { this[nameof(NumCellsY)].SetValue<int>(value); } }
        public int NumCellsMaxAxis { get { return this[nameof(NumCellsMaxAxis)].GetValue<int>(); } set { this[nameof(NumCellsMaxAxis)].SetValue<int>(value); } }
        public int NumAttributes { get { return this[nameof(NumAttributes)].GetValue<int>(); } set { this[nameof(NumAttributes)].SetValue<int>(value); } }
        public bool SetGridFromMaxAxis { get { return this[nameof(SetGridFromMaxAxis)].Flag; } set { this[nameof(SetGridFromMaxAxis)].Flag = value; } }
        public Vector2D WorldBBoxSize { get { return this[nameof(WorldBBoxSize)].As<Vector2D>(); } set { this["WorldBBoxSize"] = value; } }
    }
    public class NiagaraDataInterfaceGrid2DCollection : NiagaraDataInterfaceGrid2D
    {
        public NiagaraDataInterfaceGrid2DCollection(nint addr) : base(addr) { }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public ENiagaraGpuBufferFormat OverrideBufferFormat { get { return (ENiagaraGpuBufferFormat)this[nameof(OverrideBufferFormat)].GetValue<int>(); } set { this[nameof(OverrideBufferFormat)].SetValue<int>((int)value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
        public void GetTextureSize(NiagaraComponent Component, int SizeX, int SizeY) { Invoke(nameof(GetTextureSize), Component, SizeX, SizeY); }
        public void GetRawTextureSize(NiagaraComponent Component, int SizeX, int SizeY) { Invoke(nameof(GetRawTextureSize), Component, SizeX, SizeY); }
        public bool FillTexture2D(NiagaraComponent Component, TextureRenderTarget2D Dest, int AttributeIndex) { return Invoke<bool>(nameof(FillTexture2D), Component, Dest, AttributeIndex); }
        public bool FillRawTexture2D(NiagaraComponent Component, TextureRenderTarget2D Dest, int TilesX, int TilesY) { return Invoke<bool>(nameof(FillRawTexture2D), Component, Dest, TilesX, TilesY); }
    }
    public class NiagaraDataInterfaceGrid2DCollectionReader : NiagaraDataInterfaceGrid2DCollection
    {
        public NiagaraDataInterfaceGrid2DCollectionReader(nint addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
        public Object DIName { get { return this[nameof(DIName)]; } set { this[nameof(DIName)] = value; } }
    }
    public class NiagaraDataInterfaceGrid3D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceGrid3D(nint addr) : base(addr) { }
        public IntVector NumCells { get { return this[nameof(NumCells)].As<IntVector>(); } set { this["NumCells"] = value; } }
        public float CellSize { get { return this[nameof(CellSize)].GetValue<float>(); } set { this[nameof(CellSize)].SetValue<float>(value); } }
        public int NumCellsMaxAxis { get { return this[nameof(NumCellsMaxAxis)].GetValue<int>(); } set { this[nameof(NumCellsMaxAxis)].SetValue<int>(value); } }
        public ESetResolutionMethod SetResolutionMethod { get { return (ESetResolutionMethod)this[nameof(SetResolutionMethod)].GetValue<int>(); } set { this[nameof(SetResolutionMethod)].SetValue<int>((int)value); } }
        public Vector WorldBBoxSize { get { return this[nameof(WorldBBoxSize)].As<Vector>(); } set { this["WorldBBoxSize"] = value; } }
    }
    public class NiagaraDataInterfaceGrid3DCollection : NiagaraDataInterfaceGrid3D
    {
        public NiagaraDataInterfaceGrid3DCollection(nint addr) : base(addr) { }
        public int NumAttributes { get { return this[nameof(NumAttributes)].GetValue<int>(); } set { this[nameof(NumAttributes)].SetValue<int>(value); } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public ENiagaraGpuBufferFormat OverrideBufferFormat { get { return (ENiagaraGpuBufferFormat)this[nameof(OverrideBufferFormat)].GetValue<int>(); } set { this[nameof(OverrideBufferFormat)].SetValue<int>((int)value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public void GetTextureSize(NiagaraComponent Component, int SizeX, int SizeY, int SizeZ) { Invoke(nameof(GetTextureSize), Component, SizeX, SizeY, SizeZ); }
        public void GetRawTextureSize(NiagaraComponent Component, int SizeX, int SizeY, int SizeZ) { Invoke(nameof(GetRawTextureSize), Component, SizeX, SizeY, SizeZ); }
        public bool FillVolumeTexture(NiagaraComponent Component, VolumeTexture Dest, int AttributeIndex) { return Invoke<bool>(nameof(FillVolumeTexture), Component, Dest, AttributeIndex); }
        public bool FillRawVolumeTexture(NiagaraComponent Component, VolumeTexture Dest, int TilesX, int TilesY, int TileZ) { return Invoke<bool>(nameof(FillRawVolumeTexture), Component, Dest, TilesX, TilesY, TileZ); }
    }
    public class NiagaraDataInterfaceGrid3DCollectionReader : NiagaraDataInterfaceGrid3DCollection
    {
        public NiagaraDataInterfaceGrid3DCollectionReader(nint addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
        public Object DIName { get { return this[nameof(DIName)]; } set { this[nameof(DIName)] = value; } }
    }
    public class NiagaraDataInterfaceIntRenderTarget2D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceIntRenderTarget2D(nint addr) : base(addr) { }
        public IntPoint Size { get { return this[nameof(Size)].As<IntPoint>(); } set { this["Size"] = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceLandscape : NiagaraDataInterface
    {
        public NiagaraDataInterfaceLandscape(nint addr) : base(addr) { }
        public Actor SourceLandscape { get { return this[nameof(SourceLandscape)].As<Actor>(); } set { this["SourceLandscape"] = value; } }
        public ENDILandscape_SourceMode SourceMode { get { return (ENDILandscape_SourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public Array<PhysicalMaterial> PhysicalMaterials { get { return new Array<PhysicalMaterial>(this[nameof(PhysicalMaterials)].Address); } }
    }
    public class NiagaraDataInterfaceMeshRendererInfo : NiagaraDataInterface
    {
        public NiagaraDataInterfaceMeshRendererInfo(nint addr) : base(addr) { }
        public NiagaraMeshRendererProperties MeshRenderer { get { return this[nameof(MeshRenderer)].As<NiagaraMeshRendererProperties>(); } set { this["MeshRenderer"] = value; } }
    }
    public class NiagaraDataInterfaceNeighborGrid3D : NiagaraDataInterfaceGrid3D
    {
        public NiagaraDataInterfaceNeighborGrid3D(nint addr) : base(addr) { }
        public uint MaxNeighborsPerCell { get { return this[nameof(MaxNeighborsPerCell)].GetValue<uint>(); } set { this[nameof(MaxNeighborsPerCell)].SetValue<uint>(value); } }
    }
    public class NiagaraDataInterfaceOcclusion : NiagaraDataInterface
    {
        public NiagaraDataInterfaceOcclusion(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceParticleRead : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceParticleRead(nint addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
    }
    public class NiagaraDataInterfacePlatformSet : NiagaraDataInterface
    {
        public NiagaraDataInterfacePlatformSet(nint addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
    }
    public class NiagaraDataInterfaceRasterizationGrid3D : NiagaraDataInterfaceGrid3D
    {
        public NiagaraDataInterfaceRasterizationGrid3D(nint addr) : base(addr) { }
        public int NumAttributes { get { return this[nameof(NumAttributes)].GetValue<int>(); } set { this[nameof(NumAttributes)].SetValue<int>(value); } }
        public float Precision { get { return this[nameof(Precision)].GetValue<float>(); } set { this[nameof(Precision)].SetValue<float>(value); } }
        public int ResetValue { get { return this[nameof(ResetValue)].GetValue<int>(); } set { this[nameof(ResetValue)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceRenderTarget2D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTarget2D(nint addr) : base(addr) { }
        public IntPoint Size { get { return this[nameof(Size)].As<IntPoint>(); } set { this["Size"] = value; } }
        public ENiagaraMipMapGeneration MipMapGeneration { get { return (ENiagaraMipMapGeneration)this[nameof(MipMapGeneration)].GetValue<int>(); } set { this[nameof(MipMapGeneration)].SetValue<int>((int)value); } }
        public ENiagaraMipMapGenerationType MipMapGenerationType { get { return (ENiagaraMipMapGenerationType)this[nameof(MipMapGenerationType)].GetValue<int>(); } set { this[nameof(MipMapGenerationType)].SetValue<int>((int)value); } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bInheritUserParameterSettings { get { return this[nameof(bInheritUserParameterSettings)].Flag; } set { this[nameof(bInheritUserParameterSettings)].Flag = value; } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRenderTarget2DArray : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTarget2DArray(nint addr) : base(addr) { }
        public IntVector Size { get { return this[nameof(Size)].As<IntVector>(); } set { this["Size"] = value; } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bInheritUserParameterSettings { get { return this[nameof(bInheritUserParameterSettings)].Flag; } set { this[nameof(bInheritUserParameterSettings)].Flag = value; } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRenderTargetCube : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTargetCube(nint addr) : base(addr) { }
        public int Size { get { return this[nameof(Size)].GetValue<int>(); } set { this[nameof(Size)].SetValue<int>(value); } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bInheritUserParameterSettings { get { return this[nameof(bInheritUserParameterSettings)].Flag; } set { this[nameof(bInheritUserParameterSettings)].Flag = value; } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRenderTargetVolume : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTargetVolume(nint addr) : base(addr) { }
        public IntVector Size { get { return this[nameof(Size)].As<IntVector>(); } set { this["Size"] = value; } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bInheritUserParameterSettings { get { return this[nameof(bInheritUserParameterSettings)].Flag; } set { this[nameof(bInheritUserParameterSettings)].Flag = value; } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRigidMeshCollisionQuery : NiagaraDataInterface
    {
        public NiagaraDataInterfaceRigidMeshCollisionQuery(nint addr) : base(addr) { }
        public Array<Object> ActorTags { get { return new Array<Object>(this[nameof(ActorTags)].Address); } }
        public Array<Object> ComponentTags { get { return new Array<Object>(this[nameof(ComponentTags)].Address); } }
        public Array<Object> SourceActors { get { return new Array<Object>(this[nameof(SourceActors)].Address); } }
        public bool OnlyUseMoveable { get { return this[nameof(OnlyUseMoveable)].Flag; } set { this[nameof(OnlyUseMoveable)].Flag = value; } }
        public bool GlobalSearchAllowed { get { return this[nameof(GlobalSearchAllowed)].Flag; } set { this[nameof(GlobalSearchAllowed)].Flag = value; } }
        public bool GlobalSearchForced { get { return this[nameof(GlobalSearchForced)].Flag; } set { this[nameof(GlobalSearchForced)].Flag = value; } }
        public bool GlobalSearchFallback_Unscripted { get { return this[nameof(GlobalSearchFallback_Unscripted)].Flag; } set { this[nameof(GlobalSearchFallback_Unscripted)].Flag = value; } }
        public int MaxNumPrimitives { get { return this[nameof(MaxNumPrimitives)].GetValue<int>(); } set { this[nameof(MaxNumPrimitives)].SetValue<int>(value); } }
    }
    public class NiagaraDIRigidMeshCollisionFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraDIRigidMeshCollisionFunctionLibrary(nint addr) : base(addr) { }
        public void SetSourceActors(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Actor> SourceActors) { Invoke(nameof(SetSourceActors), NiagaraSystem, OverrideName, SourceActors); }
    }
    public class NiagaraDataInterfaceSkeletalMesh : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSkeletalMesh(nint addr) : base(addr) { }
        public ENDISkeletalMesh_SourceMode SourceMode { get { return (ENDISkeletalMesh_SourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public Object SoftSourceActor { get { return this[nameof(SoftSourceActor)]; } set { this[nameof(SoftSourceActor)] = value; } }
        public Array<Object> ComponentTags { get { return new Array<Object>(this[nameof(ComponentTags)].Address); } }
        public SkeletalMeshComponent SourceComponent { get { return this[nameof(SourceComponent)].As<SkeletalMeshComponent>(); } set { this["SourceComponent"] = value; } }
        public NiagaraUserParameterBinding MeshUserParameter { get { return this[nameof(MeshUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["MeshUserParameter"] = value; } }
        public ENDISkeletalMesh_SkinningMode SkinningMode { get { return (ENDISkeletalMesh_SkinningMode)this[nameof(SkinningMode)].GetValue<int>(); } set { this[nameof(SkinningMode)].SetValue<int>((int)value); } }
        public Array<Object> SamplingRegions { get { return new Array<Object>(this[nameof(SamplingRegions)].Address); } }
        public int WholeMeshLOD { get { return this[nameof(WholeMeshLOD)].GetValue<int>(); } set { this[nameof(WholeMeshLOD)].SetValue<int>(value); } }
        public Array<Object> FilteredBones { get { return new Array<Object>(this[nameof(FilteredBones)].Address); } }
        public Array<Object> FilteredSockets { get { return new Array<Object>(this[nameof(FilteredSockets)].Address); } }
        public Object ExcludeBoneName { get { return this[nameof(ExcludeBoneName)]; } set { this[nameof(ExcludeBoneName)] = value; } }
        public bool bExcludeBone { get { return this[nameof(bExcludeBone)].Flag; } set { this[nameof(bExcludeBone)].Flag = value; } }
        public int UvSetIndex { get { return this[nameof(UvSetIndex)].GetValue<int>(); } set { this[nameof(UvSetIndex)].SetValue<int>(value); } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
        public void OnSourceEndPlay(Actor InSource, byte Reason) { Invoke(nameof(OnSourceEndPlay), InSource, Reason); }
    }
    public class NiagaraDataInterfaceSpline : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSpline(nint addr) : base(addr) { }
        public Actor Source { get { return this[nameof(Source)].As<Actor>(); } set { this["Source"] = value; } }
        public NiagaraUserParameterBinding SplineUserParameter { get { return this[nameof(SplineUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["SplineUserParameter"] = value; } }
        public bool bUseLUT { get { return this[nameof(bUseLUT)].Flag; } set { this[nameof(bUseLUT)].Flag = value; } }
        public int NumLUTSteps { get { return this[nameof(NumLUTSteps)].GetValue<int>(); } set { this[nameof(NumLUTSteps)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceTexture(nint addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
        public NiagaraUserParameterBinding TextureUserParameter { get { return this[nameof(TextureUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["TextureUserParameter"] = value; } }
    }
    public class NiagaraDataInterfaceVector2DCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVector2DCurve(nint addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVector4Curve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVector4Curve(nint addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
        public RichCurve ZCurve { get { return this[nameof(ZCurve)].As<RichCurve>(); } set { this["ZCurve"] = value; } }
        public RichCurve WCurve { get { return this[nameof(WCurve)].As<RichCurve>(); } set { this["WCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVectorCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVectorCurve(nint addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
        public RichCurve ZCurve { get { return this[nameof(ZCurve)].As<RichCurve>(); } set { this["ZCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVectorField : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVectorField(nint addr) : base(addr) { }
        public VectorField Field { get { return this[nameof(Field)].As<VectorField>(); } set { this["Field"] = value; } }
        public bool bTileX { get { return this[nameof(bTileX)].Flag; } set { this[nameof(bTileX)].Flag = value; } }
        public bool bTileY { get { return this[nameof(bTileY)].Flag; } set { this[nameof(bTileY)].Flag = value; } }
        public bool bTileZ { get { return this[nameof(bTileZ)].Flag; } set { this[nameof(bTileZ)].Flag = value; } }
    }
    public class NiagaraDataInterfaceVolumeCache : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVolumeCache(nint addr) : base(addr) { }
        public VolumeCache VolumeCache { get { return this[nameof(VolumeCache)].As<VolumeCache>(); } set { this["VolumeCache"] = value; } }
    }
    public class NiagaraDataInterfaceVolumeTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVolumeTexture(nint addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
        public NiagaraUserParameterBinding TextureUserParameter { get { return this[nameof(TextureUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["TextureUserParameter"] = value; } }
    }
    public class NiagaraDebugHUDSettings : Object
    {
        public NiagaraDebugHUDSettings(nint addr) : base(addr) { }
        public NiagaraDebugHUDSettingsData Data { get { return this[nameof(Data)].As<NiagaraDebugHUDSettingsData>(); } set { this["Data"] = value; } }
    }
    public class NiagaraEditorDataBase : Object
    {
        public NiagaraEditorDataBase(nint addr) : base(addr) { }
    }
    public class NiagaraEditorParametersAdapterBase : Object
    {
        public NiagaraEditorParametersAdapterBase(nint addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandler : Object
    {
        public NiagaraSignificanceHandler(nint addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandlerDistance : NiagaraSignificanceHandler
    {
        public NiagaraSignificanceHandlerDistance(nint addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandlerAge : NiagaraSignificanceHandler
    {
        public NiagaraSignificanceHandlerAge(nint addr) : base(addr) { }
    }
    public class NiagaraEffectType : Object
    {
        public NiagaraEffectType(nint addr) : base(addr) { }
        public bool bAllowCullingForLocalPlayers { get { return this[nameof(bAllowCullingForLocalPlayers)].Flag; } set { this[nameof(bAllowCullingForLocalPlayers)].Flag = value; } }
        public ENiagaraScalabilityUpdateFrequency UpdateFrequency { get { return (ENiagaraScalabilityUpdateFrequency)this[nameof(UpdateFrequency)].GetValue<int>(); } set { this[nameof(UpdateFrequency)].SetValue<int>((int)value); } }
        public ENiagaraCullReaction CullReaction { get { return (ENiagaraCullReaction)this[nameof(CullReaction)].GetValue<int>(); } set { this[nameof(CullReaction)].SetValue<int>((int)value); } }
        public NiagaraSignificanceHandler SignificanceHandler { get { return this[nameof(SignificanceHandler)].As<NiagaraSignificanceHandler>(); } set { this["SignificanceHandler"] = value; } }
        public Array<NiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings { get { return new Array<NiagaraSystemScalabilitySettings>(this[nameof(DetailLevelScalabilitySettings)].Address); } }
        public NiagaraSystemScalabilitySettingsArray SystemScalabilitySettings { get { return this[nameof(SystemScalabilitySettings)].As<NiagaraSystemScalabilitySettingsArray>(); } set { this["SystemScalabilitySettings"] = value; } }
        public NiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings { get { return this[nameof(EmitterScalabilitySettings)].As<NiagaraEmitterScalabilitySettingsArray>(); } set { this["EmitterScalabilitySettings"] = value; } }
        public Array<NiagaraValidationRule> ValidationRules { get { return new Array<NiagaraValidationRule>(this[nameof(ValidationRules)].Address); } }
        public NiagaraBaselineController PerformanceBaselineController { get { return this[nameof(PerformanceBaselineController)].As<NiagaraBaselineController>(); } set { this["PerformanceBaselineController"] = value; } }
        public NiagaraPerfBaselineStats PerfBaselineStats { get { return this[nameof(PerfBaselineStats)].As<NiagaraPerfBaselineStats>(); } set { this["PerfBaselineStats"] = value; } }
        public Guid PerfBaselineVersion { get { return this[nameof(PerfBaselineVersion)].As<Guid>(); } set { this["PerfBaselineVersion"] = value; } }
    }
    public class NiagaraEmitter : Object
    {
        public NiagaraEmitter(nint addr) : base(addr) { }
        public Guid ExposedVersion { get { return this[nameof(ExposedVersion)].As<Guid>(); } set { this["ExposedVersion"] = value; } }
        public bool bVersioningEnabled { get { return this[nameof(bVersioningEnabled)].Flag; } set { this[nameof(bVersioningEnabled)].Flag = value; } }
        public Array<VersionedNiagaraEmitterData> VersionData { get { return new Array<VersionedNiagaraEmitterData>(this[nameof(VersionData)].Address); } }
        public Object UniqueEmitterName { get { return this[nameof(UniqueEmitterName)]; } set { this[nameof(UniqueEmitterName)] = value; } }
        public Array<NiagaraRendererProperties> RendererProperties { get { return new Array<NiagaraRendererProperties>(this[nameof(RendererProperties)].Address); } }
        public Array<NiagaraEventScriptProperties> EventHandlerScriptProps { get { return new Array<NiagaraEventScriptProperties>(this[nameof(EventHandlerScriptProps)].Address); } }
        public Array<NiagaraSimulationStageBase> SimulationStages { get { return new Array<NiagaraSimulationStageBase>(this[nameof(SimulationStages)].Address); } }
        public NiagaraScript GPUComputeScript { get { return this[nameof(GPUComputeScript)].As<NiagaraScript>(); } set { this["GPUComputeScript"] = value; } }
        public Array<Object> SharedEventGeneratorIds { get { return new Array<Object>(this[nameof(SharedEventGeneratorIds)].Address); } }
    }
    public class NiagaraEventReceiverEmitterAction : Object
    {
        public NiagaraEventReceiverEmitterAction(nint addr) : base(addr) { }
    }
    public class NiagaraEventReceiverEmitterAction_SpawnParticles : NiagaraEventReceiverEmitterAction
    {
        public NiagaraEventReceiverEmitterAction_SpawnParticles(nint addr) : base(addr) { }
        public uint NumParticles { get { return this[nameof(NumParticles)].GetValue<uint>(); } set { this[nameof(NumParticles)].SetValue<uint>(value); } }
    }
    public class NiagaraFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraFunctionLibrary(nint addr) : base(addr) { }
        public NiagaraComponent SpawnSystemAttachedWithParams(FXSystemSpawnParameters SpawnParams) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAttachedWithParams), SpawnParams); }
        public NiagaraComponent SpawnSystemAttached(NiagaraSystem SystemTemplate, SceneComponent AttachToComponent, Object AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAttached), SystemTemplate, AttachToComponent, AttachPointName, Location, Rotation, LocationType, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck); }
        public NiagaraComponent SpawnSystemAtLocationWithParams(FXSystemSpawnParameters SpawnParams) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAtLocationWithParams), SpawnParams); }
        public NiagaraComponent SpawnSystemAtLocation(Object WorldContextObject, NiagaraSystem SystemTemplate, Vector Location, Rotator Rotation, Vector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAtLocation), WorldContextObject, SystemTemplate, Location, Rotation, Scale, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck); }
        public void SetVolumeTextureObject(NiagaraComponent NiagaraSystem, Object OverrideName, VolumeTexture Texture) { Invoke(nameof(SetVolumeTextureObject), NiagaraSystem, OverrideName, Texture); }
        public void SetTextureObject(NiagaraComponent NiagaraSystem, Object OverrideName, Texture Texture) { Invoke(nameof(SetTextureObject), NiagaraSystem, OverrideName, Texture); }
        public void SetTexture2DArrayObject(NiagaraComponent NiagaraSystem, Object OverrideName, Texture2DArray Texture) { Invoke(nameof(SetTexture2DArrayObject), NiagaraSystem, OverrideName, Texture); }
        public void SetSkeletalMeshDataInterfaceSamplingRegions(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Object> SamplingRegions) { Invoke(nameof(SetSkeletalMeshDataInterfaceSamplingRegions), NiagaraSystem, OverrideName, SamplingRegions); }
        public void SetSkeletalMeshDataInterfaceFilteredSockets(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Object> FilteredSockets) { Invoke(nameof(SetSkeletalMeshDataInterfaceFilteredSockets), NiagaraSystem, OverrideName, FilteredSockets); }
        public void SetSkeletalMeshDataInterfaceFilteredBones(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Object> FilteredBones) { Invoke(nameof(SetSkeletalMeshDataInterfaceFilteredBones), NiagaraSystem, OverrideName, FilteredBones); }
        public void SetComponentNiagaraGPURayTracedCollisionGroup(Object WorldContextObject, PrimitiveComponent Primitive, int CollisionGroup) { Invoke(nameof(SetComponentNiagaraGPURayTracedCollisionGroup), WorldContextObject, Primitive, CollisionGroup); }
        public void SetActorNiagaraGPURayTracedCollisionGroup(Object WorldContextObject, Actor Actor, int CollisionGroup) { Invoke(nameof(SetActorNiagaraGPURayTracedCollisionGroup), WorldContextObject, Actor, CollisionGroup); }
        public void ReleaseNiagaraGPURayTracedCollisionGroup(Object WorldContextObject, int CollisionGroup) { Invoke(nameof(ReleaseNiagaraGPURayTracedCollisionGroup), WorldContextObject, CollisionGroup); }
        public void OverrideSystemUserVariableStaticMeshComponent(NiagaraComponent NiagaraSystem, Object OverrideName, StaticMeshComponent StaticMeshComponent) { Invoke(nameof(OverrideSystemUserVariableStaticMeshComponent), NiagaraSystem, OverrideName, StaticMeshComponent); }
        public void OverrideSystemUserVariableStaticMesh(NiagaraComponent NiagaraSystem, Object OverrideName, StaticMesh StaticMesh) { Invoke(nameof(OverrideSystemUserVariableStaticMesh), NiagaraSystem, OverrideName, StaticMesh); }
        public void OverrideSystemUserVariableSkeletalMeshComponent(NiagaraComponent NiagaraSystem, Object OverrideName, SkeletalMeshComponent SkeletalMeshComponent) { Invoke(nameof(OverrideSystemUserVariableSkeletalMeshComponent), NiagaraSystem, OverrideName, SkeletalMeshComponent); }
        public NiagaraParameterCollectionInstance GetNiagaraParameterCollection(Object WorldContextObject, NiagaraParameterCollection Collection) { return Invoke<NiagaraParameterCollectionInstance>(nameof(GetNiagaraParameterCollection), WorldContextObject, Collection); }
        public int AcquireNiagaraGPURayTracedCollisionGroup(Object WorldContextObject) { return Invoke<int>(nameof(AcquireNiagaraGPURayTracedCollisionGroup), WorldContextObject); }
    }
    public class NiagaraLensEffectBase : NiagaraActor
    {
        public NiagaraLensEffectBase(nint addr) : base(addr) { }
        public Transform DesiredRelativeTransform { get { return this[nameof(DesiredRelativeTransform)].As<Transform>(); } set { this["DesiredRelativeTransform"] = value; } }
        public float BaseAuthoredFOV { get { return this[nameof(BaseAuthoredFOV)].GetValue<float>(); } set { this[nameof(BaseAuthoredFOV)].SetValue<float>(value); } }
        public bool bAllowMultipleInstances { get { return this[nameof(bAllowMultipleInstances)].Flag; } set { this[nameof(bAllowMultipleInstances)].Flag = value; } }
        public bool bResetWhenRetriggered { get { return this[nameof(bResetWhenRetriggered)].Flag; } set { this[nameof(bResetWhenRetriggered)].Flag = value; } }
        public Array<Object> EmittersToTreatAsSame { get { return new Array<Object>(this[nameof(EmittersToTreatAsSame)].Address); } }
        public PlayerCameraManager OwningCameraManager { get { return this[nameof(OwningCameraManager)].As<PlayerCameraManager>(); } set { this["OwningCameraManager"] = value; } }
    }
    public class NiagaraLightRendererProperties : NiagaraRendererProperties
    {
        public NiagaraLightRendererProperties(nint addr) : base(addr) { }
        public bool bUseInverseSquaredFalloff { get { return this[nameof(bUseInverseSquaredFalloff)].Flag; } set { this[nameof(bUseInverseSquaredFalloff)].Flag = value; } }
        public bool bAffectsTranslucency { get { return this[nameof(bAffectsTranslucency)].Flag; } set { this[nameof(bAffectsTranslucency)].Flag = value; } }
        public bool bAlphaScalesBrightness { get { return this[nameof(bAlphaScalesBrightness)].Flag; } set { this[nameof(bAlphaScalesBrightness)].Flag = value; } }
        public bool bOverrideInverseExposureBlend { get { return this[nameof(bOverrideInverseExposureBlend)].Flag; } set { this[nameof(bOverrideInverseExposureBlend)].Flag = value; } }
        public float RadiusScale { get { return this[nameof(RadiusScale)].GetValue<float>(); } set { this[nameof(RadiusScale)].SetValue<float>(value); } }
        public float DefaultExponent { get { return this[nameof(DefaultExponent)].GetValue<float>(); } set { this[nameof(DefaultExponent)].SetValue<float>(value); } }
        public Vector3f ColorAdd { get { return this[nameof(ColorAdd)].As<Vector3f>(); } set { this["ColorAdd"] = value; } }
        public float InverseExposureBlend { get { return this[nameof(InverseExposureBlend)].GetValue<float>(); } set { this[nameof(InverseExposureBlend)].SetValue<float>(value); } }
        public int RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<int>(); } set { this[nameof(RendererVisibility)].SetValue<int>(value); } }
        public NiagaraVariableAttributeBinding LightRenderingEnabledBinding { get { return this[nameof(LightRenderingEnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["LightRenderingEnabledBinding"] = value; } }
        public NiagaraVariableAttributeBinding LightExponentBinding { get { return this[nameof(LightExponentBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["LightExponentBinding"] = value; } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding RadiusBinding { get { return this[nameof(RadiusBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RadiusBinding"] = value; } }
        public NiagaraVariableAttributeBinding VolumetricScatteringBinding { get { return this[nameof(VolumetricScatteringBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VolumetricScatteringBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
    }
    public class NiagaraMeshRendererProperties : NiagaraRendererProperties
    {
        public NiagaraMeshRendererProperties(nint addr) : base(addr) { }
        public Array<NiagaraMeshRendererMeshProperties> Meshes { get { return new Array<NiagaraMeshRendererMeshProperties>(this[nameof(Meshes)].Address); } }
        public ENiagaraRendererSourceDataMode SourceMode { get { return (ENiagaraRendererSourceDataMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public ENiagaraSortMode SortMode { get { return (ENiagaraSortMode)this[nameof(SortMode)].GetValue<int>(); } set { this[nameof(SortMode)].SetValue<int>((int)value); } }
        public bool bOverrideMaterials { get { return this[nameof(bOverrideMaterials)].Flag; } set { this[nameof(bOverrideMaterials)].Flag = value; } }
        public bool bSortOnlyWhenTranslucent { get { return this[nameof(bSortOnlyWhenTranslucent)].Flag; } set { this[nameof(bSortOnlyWhenTranslucent)].Flag = value; } }
        public ENiagaraRendererSortPrecision SortPrecision { get { return (ENiagaraRendererSortPrecision)this[nameof(SortPrecision)].GetValue<int>(); } set { this[nameof(SortPrecision)].SetValue<int>((int)value); } }
        public ENiagaraRendererGpuTranslucentLatency GpuTranslucentLatency { get { return (ENiagaraRendererGpuTranslucentLatency)this[nameof(GpuTranslucentLatency)].GetValue<int>(); } set { this[nameof(GpuTranslucentLatency)].SetValue<int>((int)value); } }
        public bool bSubImageBlend { get { return this[nameof(bSubImageBlend)].Flag; } set { this[nameof(bSubImageBlend)].Flag = value; } }
        public bool bEnableFrustumCulling { get { return this[nameof(bEnableFrustumCulling)].Flag; } set { this[nameof(bEnableFrustumCulling)].Flag = value; } }
        public bool bEnableCameraDistanceCulling { get { return this[nameof(bEnableCameraDistanceCulling)].Flag; } set { this[nameof(bEnableCameraDistanceCulling)].Flag = value; } }
        public bool bEnableMeshFlipbook { get { return this[nameof(bEnableMeshFlipbook)].Flag; } set { this[nameof(bEnableMeshFlipbook)].Flag = value; } }
        public Array<NiagaraMeshMaterialOverride> OverrideMaterials { get { return new Array<NiagaraMeshMaterialOverride>(this[nameof(OverrideMaterials)].Address); } }
        public Vector2D SubImageSize { get { return this[nameof(SubImageSize)].As<Vector2D>(); } set { this["SubImageSize"] = value; } }
        public ENiagaraMeshFacingMode FacingMode { get { return (ENiagaraMeshFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public bool bLockedAxisEnable { get { return this[nameof(bLockedAxisEnable)].Flag; } set { this[nameof(bLockedAxisEnable)].Flag = value; } }
        public Vector LockedAxis { get { return this[nameof(LockedAxis)].As<Vector>(); } set { this["LockedAxis"] = value; } }
        public ENiagaraMeshLockedAxisSpace LockedAxisSpace { get { return (ENiagaraMeshLockedAxisSpace)this[nameof(LockedAxisSpace)].GetValue<int>(); } set { this[nameof(LockedAxisSpace)].SetValue<int>((int)value); } }
        public float MinCameraDistance { get { return this[nameof(MinCameraDistance)].GetValue<float>(); } set { this[nameof(MinCameraDistance)].SetValue<float>(value); } }
        public float MaxCameraDistance { get { return this[nameof(MaxCameraDistance)].GetValue<float>(); } set { this[nameof(MaxCameraDistance)].SetValue<float>(value); } }
        public uint RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<uint>(); } set { this[nameof(RendererVisibility)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding MeshOrientationBinding { get { return this[nameof(MeshOrientationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MeshOrientationBinding"] = value; } }
        public NiagaraVariableAttributeBinding ScaleBinding { get { return this[nameof(ScaleBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ScaleBinding"] = value; } }
        public NiagaraVariableAttributeBinding SubImageIndexBinding { get { return this[nameof(SubImageIndexBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SubImageIndexBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding CustomSortingBinding { get { return this[nameof(CustomSortingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CustomSortingBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding CameraOffsetBinding { get { return this[nameof(CameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
        public NiagaraVariableAttributeBinding MeshIndexBinding { get { return this[nameof(MeshIndexBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MeshIndexBinding"] = value; } }
        public NiagaraRendererMaterialParameters MaterialParameters { get { return this[nameof(MaterialParameters)].As<NiagaraRendererMaterialParameters>(); } set { this["MaterialParameters"] = value; } }
        public NiagaraVariableAttributeBinding PrevPositionBinding { get { return this[nameof(PrevPositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevPositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevScaleBinding { get { return this[nameof(PrevScaleBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevScaleBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevMeshOrientationBinding { get { return this[nameof(PrevMeshOrientationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevMeshOrientationBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevCameraOffsetBinding { get { return this[nameof(PrevCameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevCameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevVelocityBinding { get { return this[nameof(PrevVelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevVelocityBinding"] = value; } }
        public StaticMesh ParticleMesh { get { return this[nameof(ParticleMesh)].As<StaticMesh>(); } set { this["ParticleMesh"] = value; } }
        public Vector PivotOffset { get { return this[nameof(PivotOffset)].As<Vector>(); } set { this["PivotOffset"] = value; } }
        public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace { get { return (ENiagaraMeshPivotOffsetSpace)this[nameof(PivotOffsetSpace)].GetValue<int>(); } set { this[nameof(PivotOffsetSpace)].SetValue<int>((int)value); } }
    }
    public class NiagaraParameterCollectionInstance : Object
    {
        public NiagaraParameterCollectionInstance(nint addr) : base(addr) { }
        public NiagaraParameterCollection Collection { get { return this[nameof(Collection)].As<NiagaraParameterCollection>(); } set { this["Collection"] = value; } }
        public Array<NiagaraVariable> OverridenParameters { get { return new Array<NiagaraVariable>(this[nameof(OverridenParameters)].Address); } }
        public NiagaraParameterStore ParameterStorage { get { return this[nameof(ParameterStorage)].As<NiagaraParameterStore>(); } set { this["ParameterStorage"] = value; } }
        public void SetVectorParameter(Object InVariableName, Vector InValue) { Invoke(nameof(SetVectorParameter), InVariableName, InValue); }
        public void SetVector4Parameter(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetVector4Parameter), InVariableName, InValue); }
        public void SetVector2DParameter(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetVector2DParameter), InVariableName, InValue); }
        public void SetQuatParameter(Object InVariableName, Quat InValue) { Invoke(nameof(SetQuatParameter), InVariableName, InValue); }
        public void SetIntParameter(Object InVariableName, int InValue) { Invoke(nameof(SetIntParameter), InVariableName, InValue); }
        public void SetFloatParameter(Object InVariableName, float InValue) { Invoke(nameof(SetFloatParameter), InVariableName, InValue); }
        public void SetColorParameter(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetColorParameter), InVariableName, InValue); }
        public void SetBoolParameter(Object InVariableName, bool InValue) { Invoke(nameof(SetBoolParameter), InVariableName, InValue); }
        public Vector GetVectorParameter(Object InVariableName) { return Invoke<Vector>(nameof(GetVectorParameter), InVariableName); }
        public Vector4 GetVector4Parameter(Object InVariableName) { return Invoke<Vector4>(nameof(GetVector4Parameter), InVariableName); }
        public Vector2D GetVector2DParameter(Object InVariableName) { return Invoke<Vector2D>(nameof(GetVector2DParameter), InVariableName); }
        public Quat GetQuatParameter(Object InVariableName) { return Invoke<Quat>(nameof(GetQuatParameter), InVariableName); }
        public int GetIntParameter(Object InVariableName) { return Invoke<int>(nameof(GetIntParameter), InVariableName); }
        public float GetFloatParameter(Object InVariableName) { return Invoke<float>(nameof(GetFloatParameter), InVariableName); }
        public LinearColor GetColorParameter(Object InVariableName) { return Invoke<LinearColor>(nameof(GetColorParameter), InVariableName); }
        public bool GetBoolParameter(Object InVariableName) { return Invoke<bool>(nameof(GetBoolParameter), InVariableName); }
    }
    public class NiagaraParameterCollection : Object
    {
        public NiagaraParameterCollection(nint addr) : base(addr) { }
        public Object Namespace { get { return this[nameof(Namespace)]; } set { this[nameof(Namespace)] = value; } }
        public Array<NiagaraVariable> Parameters { get { return new Array<NiagaraVariable>(this[nameof(Parameters)].Address); } }
        public MaterialParameterCollection SourceMaterialCollection { get { return this[nameof(SourceMaterialCollection)].As<MaterialParameterCollection>(); } set { this["SourceMaterialCollection"] = value; } }
        public NiagaraParameterCollectionInstance DefaultInstance { get { return this[nameof(DefaultInstance)].As<NiagaraParameterCollectionInstance>(); } set { this["DefaultInstance"] = value; } }
        public Guid CompileId { get { return this[nameof(CompileId)].As<Guid>(); } set { this["CompileId"] = value; } }
    }
    public class NiagaraBaselineController : Object
    {
        public NiagaraBaselineController(nint addr) : base(addr) { }
        public float TestDuration { get { return this[nameof(TestDuration)].GetValue<float>(); } set { this[nameof(TestDuration)].SetValue<float>(value); } }
        public NiagaraEffectType EffectType { get { return this[nameof(EffectType)].As<NiagaraEffectType>(); } set { this["EffectType"] = value; } }
        public NiagaraPerfBaselineActor Owner { get { return this[nameof(Owner)].As<NiagaraPerfBaselineActor>(); } set { this["Owner"] = value; } }
        public Object System { get { return this[nameof(System)]; } set { this[nameof(System)] = value; } }
        public bool OnTickTest() { return Invoke<bool>(nameof(OnTickTest)); }
        public void OnOwnerTick(float DeltaTime) { Invoke(nameof(OnOwnerTick), DeltaTime); }
        public void OnEndTest(NiagaraPerfBaselineStats Stats) { Invoke(nameof(OnEndTest), Stats); }
        public void OnBeginTest() { Invoke(nameof(OnBeginTest)); }
        public NiagaraSystem GetSystem() { return Invoke<NiagaraSystem>(nameof(GetSystem)); }
    }
    public class NiagaraBaselineController_Basic : NiagaraBaselineController
    {
        public NiagaraBaselineController_Basic(nint addr) : base(addr) { }
        public int NumInstances { get { return this[nameof(NumInstances)].GetValue<int>(); } set { this[nameof(NumInstances)].SetValue<int>(value); } }
        public Array<NiagaraComponent> SpawnedComponents { get { return new Array<NiagaraComponent>(this[nameof(SpawnedComponents)].Address); } }
    }
    public class NiagaraPerfBaselineActor : Actor
    {
        public NiagaraPerfBaselineActor(nint addr) : base(addr) { }
        public NiagaraBaselineController Controller { get { return this[nameof(Controller)].As<NiagaraBaselineController>(); } set { this["Controller"] = value; } }
        public TextRenderComponent Label { get { return this[nameof(Label)].As<TextRenderComponent>(); } set { this["Label"] = value; } }
    }
    public class NiagaraPrecompileContainer : Object
    {
        public NiagaraPrecompileContainer(nint addr) : base(addr) { }
        public Array<NiagaraScript> Scripts { get { return new Array<NiagaraScript>(this[nameof(Scripts)].Address); } }
        public NiagaraSystem System { get { return this[nameof(System)].As<NiagaraSystem>(); } set { this["System"] = value; } }
    }
    public class NiagaraPreviewBase : Actor
    {
        public NiagaraPreviewBase(nint addr) : base(addr) { }
        public void SetSystem(NiagaraSystem InSystem) { Invoke(nameof(SetSystem), InSystem); }
        public void SetLabelText(Object InXAxisText, Object InYAxisText) { Invoke(nameof(SetLabelText), InXAxisText, InYAxisText); }
    }
    public class NiagaraPreviewAxis : Object
    {
        public NiagaraPreviewAxis(nint addr) : base(addr) { }
        public int Num() { return Invoke<int>(nameof(Num)); }
        public void ApplyToPreview(NiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, Object OutLabelText) { Invoke(nameof(ApplyToPreview), PreviewComponent, PreviewIndex, bIsXAxis, OutLabelText); }
    }
    public class NiagaraPreviewAxis_InterpParamBase : NiagaraPreviewAxis
    {
        public NiagaraPreviewAxis_InterpParamBase(nint addr) : base(addr) { }
        public Object Param { get { return this[nameof(Param)]; } set { this[nameof(Param)] = value; } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamInt32 : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamInt32(nint addr) : base(addr) { }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamFloat : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamFloat(nint addr) : base(addr) { }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamVector2D : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector2D(nint addr) : base(addr) { }
        public Vector2D Min { get { return this[nameof(Min)].As<Vector2D>(); } set { this["Min"] = value; } }
        public Vector2D Max { get { return this[nameof(Max)].As<Vector2D>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamVector : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector(nint addr) : base(addr) { }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamVector4 : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector4(nint addr) : base(addr) { }
        public Vector4 Min { get { return this[nameof(Min)].As<Vector4>(); } set { this["Min"] = value; } }
        public Vector4 Max { get { return this[nameof(Max)].As<Vector4>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamLinearColor : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamLinearColor(nint addr) : base(addr) { }
        public LinearColor Min { get { return this[nameof(Min)].As<LinearColor>(); } set { this["Min"] = value; } }
        public LinearColor Max { get { return this[nameof(Max)].As<LinearColor>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewGrid : Actor
    {
        public NiagaraPreviewGrid(nint addr) : base(addr) { }
        public NiagaraSystem System { get { return this[nameof(System)].As<NiagaraSystem>(); } set { this["System"] = value; } }
        public ENiagaraPreviewGridResetMode ResetMode { get { return (ENiagaraPreviewGridResetMode)this[nameof(ResetMode)].GetValue<int>(); } set { this[nameof(ResetMode)].SetValue<int>((int)value); } }
        public NiagaraPreviewAxis PreviewAxisX { get { return this[nameof(PreviewAxisX)].As<NiagaraPreviewAxis>(); } set { this["PreviewAxisX"] = value; } }
        public NiagaraPreviewAxis PreviewAxisY { get { return this[nameof(PreviewAxisY)].As<NiagaraPreviewAxis>(); } set { this["PreviewAxisY"] = value; } }
        public Object PreviewClass { get { return this[nameof(PreviewClass)]; } set { this[nameof(PreviewClass)] = value; } }
        public float SpacingX { get { return this[nameof(SpacingX)].GetValue<float>(); } set { this[nameof(SpacingX)].SetValue<float>(value); } }
        public float SpacingY { get { return this[nameof(SpacingY)].GetValue<float>(); } set { this[nameof(SpacingY)].SetValue<float>(value); } }
        public int NumX { get { return this[nameof(NumX)].GetValue<int>(); } set { this[nameof(NumX)].SetValue<int>(value); } }
        public int NumY { get { return this[nameof(NumY)].GetValue<int>(); } set { this[nameof(NumY)].SetValue<int>(value); } }
        public Array<ChildActorComponent> PreviewComponents { get { return new Array<ChildActorComponent>(this[nameof(PreviewComponents)].Address); } }
        public void SetPaused(bool bPaused) { Invoke(nameof(SetPaused), bPaused); }
        public void GetPreviews(Array<NiagaraComponent> OutPreviews) { Invoke(nameof(GetPreviews), OutPreviews); }
        public void DeactivatePreviews() { Invoke(nameof(DeactivatePreviews)); }
        public void ActivatePreviews(bool bReset) { Invoke(nameof(ActivatePreviews), bReset); }
    }
    public class NiagaraRibbonRendererProperties : NiagaraRendererProperties
    {
        public NiagaraRibbonRendererProperties(nint addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public NiagaraUserParameterBinding MaterialUserParamBinding { get { return this[nameof(MaterialUserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["MaterialUserParamBinding"] = value; } }
        public ENiagaraRibbonFacingMode FacingMode { get { return (ENiagaraRibbonFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public NiagaraRibbonUVSettings UV0Settings { get { return this[nameof(UV0Settings)].As<NiagaraRibbonUVSettings>(); } set { this["UV0Settings"] = value; } }
        public NiagaraRibbonUVSettings UV1Settings { get { return this[nameof(UV1Settings)].As<NiagaraRibbonUVSettings>(); } set { this["UV1Settings"] = value; } }
        public int MaxNumRibbons { get { return this[nameof(MaxNumRibbons)].GetValue<int>(); } set { this[nameof(MaxNumRibbons)].SetValue<int>(value); } }
        public bool bUseGPUInit { get { return this[nameof(bUseGPUInit)].Flag; } set { this[nameof(bUseGPUInit)].Flag = value; } }
        public ENiagaraRibbonDrawDirection DrawDirection { get { return (ENiagaraRibbonDrawDirection)this[nameof(DrawDirection)].GetValue<int>(); } set { this[nameof(DrawDirection)].SetValue<int>((int)value); } }
        public ENiagaraRibbonShapeMode Shape { get { return (ENiagaraRibbonShapeMode)this[nameof(Shape)].GetValue<int>(); } set { this[nameof(Shape)].SetValue<int>((int)value); } }
        public bool bEnableAccurateGeometry { get { return this[nameof(bEnableAccurateGeometry)].Flag; } set { this[nameof(bEnableAccurateGeometry)].Flag = value; } }
        public int WidthSegmentationCount { get { return this[nameof(WidthSegmentationCount)].GetValue<int>(); } set { this[nameof(WidthSegmentationCount)].SetValue<int>(value); } }
        public int MultiPlaneCount { get { return this[nameof(MultiPlaneCount)].GetValue<int>(); } set { this[nameof(MultiPlaneCount)].SetValue<int>(value); } }
        public int TubeSubdivisions { get { return this[nameof(TubeSubdivisions)].GetValue<int>(); } set { this[nameof(TubeSubdivisions)].SetValue<int>(value); } }
        public Array<NiagaraRibbonShapeCustomVertex> CustomVertices { get { return new Array<NiagaraRibbonShapeCustomVertex>(this[nameof(CustomVertices)].Address); } }
        public float CurveTension { get { return this[nameof(CurveTension)].GetValue<float>(); } set { this[nameof(CurveTension)].SetValue<float>(value); } }
        public ENiagaraRibbonTessellationMode TessellationMode { get { return (ENiagaraRibbonTessellationMode)this[nameof(TessellationMode)].GetValue<int>(); } set { this[nameof(TessellationMode)].SetValue<int>((int)value); } }
        public int TessellationFactor { get { return this[nameof(TessellationFactor)].GetValue<int>(); } set { this[nameof(TessellationFactor)].SetValue<int>(value); } }
        public bool bUseConstantFactor { get { return this[nameof(bUseConstantFactor)].Flag; } set { this[nameof(bUseConstantFactor)].Flag = value; } }
        public float TessellationAngle { get { return this[nameof(TessellationAngle)].GetValue<float>(); } set { this[nameof(TessellationAngle)].SetValue<float>(value); } }
        public bool bScreenSpaceTessellation { get { return this[nameof(bScreenSpaceTessellation)].Flag; } set { this[nameof(bScreenSpaceTessellation)].Flag = value; } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonTwistBinding { get { return this[nameof(RibbonTwistBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonTwistBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonWidthBinding { get { return this[nameof(RibbonWidthBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonWidthBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonFacingBinding { get { return this[nameof(RibbonFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonIdBinding { get { return this[nameof(RibbonIdBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonIdBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonLinkOrderBinding { get { return this[nameof(RibbonLinkOrderBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonLinkOrderBinding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonUVDistance { get { return this[nameof(RibbonUVDistance)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonUVDistance"] = value; } }
        public NiagaraVariableAttributeBinding U0OverrideBinding { get { return this[nameof(U0OverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["U0OverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding V0RangeOverrideBinding { get { return this[nameof(V0RangeOverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["V0RangeOverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding U1OverrideBinding { get { return this[nameof(U1OverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["U1OverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding V1RangeOverrideBinding { get { return this[nameof(V1RangeOverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["V1RangeOverrideBinding"] = value; } }
        public NiagaraRendererMaterialParameters MaterialParameters { get { return this[nameof(MaterialParameters)].As<NiagaraRendererMaterialParameters>(); } set { this["MaterialParameters"] = value; } }
        public NiagaraVariableAttributeBinding PrevPositionBinding { get { return this[nameof(PrevPositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevPositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevRibbonWidthBinding { get { return this[nameof(PrevRibbonWidthBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevRibbonWidthBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevRibbonFacingBinding { get { return this[nameof(PrevRibbonFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevRibbonFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevRibbonTwistBinding { get { return this[nameof(PrevRibbonTwistBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevRibbonTwistBinding"] = value; } }
    }
    public class NiagaraScratchPadContainer : Object
    {
        public NiagaraScratchPadContainer(nint addr) : base(addr) { }
    }
    public class NiagaraScript : NiagaraScriptBase
    {
        public NiagaraScript(nint addr) : base(addr) { }
        public ENiagaraScriptUsage Usage { get { return (ENiagaraScriptUsage)this[nameof(Usage)].GetValue<int>(); } set { this[nameof(Usage)].SetValue<int>((int)value); } }
        public Guid UsageId { get { return this[nameof(UsageId)].As<Guid>(); } set { this["UsageId"] = value; } }
        public NiagaraParameterStore RapidIterationParameters { get { return this[nameof(RapidIterationParameters)].As<NiagaraParameterStore>(); } set { this["RapidIterationParameters"] = value; } }
        public NiagaraScriptExecutionParameterStore ScriptExecutionParamStore { get { return this[nameof(ScriptExecutionParamStore)].As<NiagaraScriptExecutionParameterStore>(); } set { this["ScriptExecutionParamStore"] = value; } }
        public Array<NiagaraBoundParameter> ScriptExecutionBoundParameters { get { return new Array<NiagaraBoundParameter>(this[nameof(ScriptExecutionBoundParameters)].Address); } }
        public NiagaraVMExecutableDataId CachedScriptVMId { get { return this[nameof(CachedScriptVMId)].As<NiagaraVMExecutableDataId>(); } set { this["CachedScriptVMId"] = value; } }
        public NiagaraVMExecutableData CachedScriptVM { get { return this[nameof(CachedScriptVM)].As<NiagaraVMExecutableData>(); } set { this["CachedScriptVM"] = value; } }
        public Array<NiagaraParameterCollection> CachedParameterCollectionReferences { get { return new Array<NiagaraParameterCollection>(this[nameof(CachedParameterCollectionReferences)].Address); } }
        public Array<NiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces { get { return new Array<NiagaraScriptDataInterfaceInfo>(this[nameof(CachedDefaultDataInterfaces)].Address); } }
        public void RaiseOnGPUCompilationComplete() { Invoke(nameof(RaiseOnGPUCompilationComplete)); }
    }
    public class NiagaraSimCache : Object
    {
        public NiagaraSimCache(nint addr) : base(addr) { }
        public Object SoftNiagaraSystem { get { return this[nameof(SoftNiagaraSystem)]; } set { this[nameof(SoftNiagaraSystem)] = value; } }
        public float StartSeconds { get { return this[nameof(StartSeconds)].GetValue<float>(); } set { this[nameof(StartSeconds)].SetValue<float>(value); } }
        public float DurationSeconds { get { return this[nameof(DurationSeconds)].GetValue<float>(); } set { this[nameof(DurationSeconds)].SetValue<float>(value); } }
        public NiagaraSimCacheCreateParameters CreateParameters { get { return this[nameof(CreateParameters)].As<NiagaraSimCacheCreateParameters>(); } set { this["CreateParameters"] = value; } }
        public bool bNeedsReadComponentMappingRecache { get { return this[nameof(bNeedsReadComponentMappingRecache)].Flag; } set { this[nameof(bNeedsReadComponentMappingRecache)].Flag = value; } }
        public NiagaraSimCacheLayout CacheLayout { get { return this[nameof(CacheLayout)].As<NiagaraSimCacheLayout>(); } set { this["CacheLayout"] = value; } }
        public Array<NiagaraSimCacheFrame> CacheFrames { get { return new Array<NiagaraSimCacheFrame>(this[nameof(CacheFrames)].Address); } }
        public Object DataInterfaceStorage { get { return this[nameof(DataInterfaceStorage)]; } set { this[nameof(DataInterfaceStorage)] = value; } }
        public void ReadVectorAttribute(Array<Vector> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadVectorAttribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public void ReadVector4Attribute(Array<Vector4> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadVector4Attribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public void ReadVector2Attribute(Array<Vector2D> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadVector2Attribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public void ReadQuatAttributeWithRebase(Array<Quat> OutValues, Quat Quat, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadQuatAttributeWithRebase), OutValues, Quat, AttributeName, EmitterName, FrameIndex); }
        public void ReadQuatAttribute(Array<Quat> OutValues, Object AttributeName, Object EmitterName, bool bLocalSpaceToWorld, int FrameIndex) { Invoke(nameof(ReadQuatAttribute), OutValues, AttributeName, EmitterName, bLocalSpaceToWorld, FrameIndex); }
        public void ReadPositionAttributeWithRebase(Array<Vector> OutValues, Transform Transform, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadPositionAttributeWithRebase), OutValues, Transform, AttributeName, EmitterName, FrameIndex); }
        public void ReadPositionAttribute(Array<Vector> OutValues, Object AttributeName, Object EmitterName, bool bLocalSpaceToWorld, int FrameIndex) { Invoke(nameof(ReadPositionAttribute), OutValues, AttributeName, EmitterName, bLocalSpaceToWorld, FrameIndex); }
        public void ReadIntAttribute(Array<int> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadIntAttribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public void ReadFloatAttribute(Array<float> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadFloatAttribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public void ReadColorAttribute(Array<LinearColor> OutValues, Object AttributeName, Object EmitterName, int FrameIndex) { Invoke(nameof(ReadColorAttribute), OutValues, AttributeName, EmitterName, FrameIndex); }
        public bool IsEmpty() { return Invoke<bool>(nameof(IsEmpty)); }
        public bool IsCacheValid() { return Invoke<bool>(nameof(IsCacheValid)); }
        public float GetStartSeconds() { return Invoke<float>(nameof(GetStartSeconds)); }
        public int GetNumFrames() { return Invoke<int>(nameof(GetNumFrames)); }
        public int GetNumEmitters() { return Invoke<int>(nameof(GetNumEmitters)); }
        public Array<Object> GetEmitterNames() { return Invoke<Array<Object>>(nameof(GetEmitterNames)); }
        public Object GetEmitterName(int EmitterIndex) { return Invoke<Object>(nameof(GetEmitterName), EmitterIndex); }
        public ENiagaraSimCacheAttributeCaptureMode GetAttributeCaptureMode() { return Invoke<ENiagaraSimCacheAttributeCaptureMode>(nameof(GetAttributeCaptureMode)); }
    }
    public class AsyncNiagaraCaptureSimCache : BlueprintAsyncActionBase
    {
        public AsyncNiagaraCaptureSimCache(nint addr) : base(addr) { }
        public NiagaraSimCache CaptureSimCache { get { return this[nameof(CaptureSimCache)].As<NiagaraSimCache>(); } set { this["CaptureSimCache"] = value; } }
        public NiagaraComponent CaptureComponent { get { return this[nameof(CaptureComponent)].As<NiagaraComponent>(); } set { this["CaptureComponent"] = value; } }
        public int CaptureNumFrames { get { return this[nameof(CaptureNumFrames)].GetValue<int>(); } set { this[nameof(CaptureNumFrames)].SetValue<int>(value); } }
        public int CaptureFrameRate { get { return this[nameof(CaptureFrameRate)].GetValue<int>(); } set { this[nameof(CaptureFrameRate)].SetValue<int>(value); } }
        public int CaptureFrameCounter { get { return this[nameof(CaptureFrameCounter)].GetValue<int>(); } set { this[nameof(CaptureFrameCounter)].SetValue<int>(value); } }
        public int TimeOutCounter { get { return this[nameof(TimeOutCounter)].GetValue<int>(); } set { this[nameof(TimeOutCounter)].SetValue<int>(value); } }
        public Object CaptureComplete { get { return this[nameof(CaptureComplete)]; } set { this[nameof(CaptureComplete)] = value; } }
        public bool bAdvanceSimulation { get { return this[nameof(bAdvanceSimulation)].Flag; } set { this[nameof(bAdvanceSimulation)].Flag = value; } }
        public float AdvanceDeltaTime { get { return this[nameof(AdvanceDeltaTime)].GetValue<float>(); } set { this[nameof(AdvanceDeltaTime)].SetValue<float>(value); } }
        public void OnCaptureComplete__DelegateSignature(bool bSuccess) { Invoke(nameof(OnCaptureComplete__DelegateSignature), bSuccess); }
        public AsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheUntilComplete(NiagaraSimCache SimCache, NiagaraSimCacheCreateParameters CreateParameters, NiagaraComponent NiagaraComponent, NiagaraSimCache OutSimCache, int CaptureRate, bool bAdvanceSimulation, float AdvanceDeltaTime) { return Invoke<AsyncNiagaraCaptureSimCache>(nameof(CaptureNiagaraSimCacheUntilComplete), SimCache, CreateParameters, NiagaraComponent, OutSimCache, CaptureRate, bAdvanceSimulation, AdvanceDeltaTime); }
        public AsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheMultiFrame(NiagaraSimCache SimCache, NiagaraSimCacheCreateParameters CreateParameters, NiagaraComponent NiagaraComponent, NiagaraSimCache OutSimCache, int NumFrames, int CaptureRate, bool bAdvanceSimulation, float AdvanceDeltaTime) { return Invoke<AsyncNiagaraCaptureSimCache>(nameof(CaptureNiagaraSimCacheMultiFrame), SimCache, CreateParameters, NiagaraComponent, OutSimCache, NumFrames, CaptureRate, bAdvanceSimulation, AdvanceDeltaTime); }
    }
    public class NiagaraSimCacheFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraSimCacheFunctionLibrary(nint addr) : base(addr) { }
        public NiagaraSimCache CreateNiagaraSimCache(Object WorldContextObject) { return Invoke<NiagaraSimCache>(nameof(CreateNiagaraSimCache), WorldContextObject); }
        public bool CaptureNiagaraSimCacheImmediate(NiagaraSimCache SimCache, NiagaraSimCacheCreateParameters CreateParameters, NiagaraComponent NiagaraComponent, NiagaraSimCache OutSimCache, bool bAdvanceSimulation, float AdvanceDeltaTime) { return Invoke<bool>(nameof(CaptureNiagaraSimCacheImmediate), SimCache, CreateParameters, NiagaraComponent, OutSimCache, bAdvanceSimulation, AdvanceDeltaTime); }
    }
    public class NiagaraSimulationStageBase : NiagaraMergeable
    {
        public NiagaraSimulationStageBase(nint addr) : base(addr) { }
        public NiagaraScript Script { get { return this[nameof(Script)].As<NiagaraScript>(); } set { this["Script"] = value; } }
        public Object SimulationStageName { get { return this[nameof(SimulationStageName)]; } set { this[nameof(SimulationStageName)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class NiagaraSimulationStageGeneric : NiagaraSimulationStageBase
    {
        public NiagaraSimulationStageGeneric(nint addr) : base(addr) { }
        public NiagaraVariableAttributeBinding EnabledBinding { get { return this[nameof(EnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["EnabledBinding"] = value; } }
        public NiagaraVariableAttributeBinding ElementCountBinding { get { return this[nameof(ElementCountBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ElementCountBinding"] = value; } }
        public NiagaraVariableAttributeBinding ElementCountXBinding { get { return this[nameof(ElementCountXBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ElementCountXBinding"] = value; } }
        public NiagaraVariableAttributeBinding ElementCountYBinding { get { return this[nameof(ElementCountYBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ElementCountYBinding"] = value; } }
        public NiagaraVariableAttributeBinding ElementCountZBinding { get { return this[nameof(ElementCountZBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ElementCountZBinding"] = value; } }
        public ENiagaraIterationSource IterationSource { get { return (ENiagaraIterationSource)this[nameof(IterationSource)].GetValue<int>(); } set { this[nameof(IterationSource)].SetValue<int>((int)value); } }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public NiagaraVariableAttributeBinding NumIterationsBinding { get { return this[nameof(NumIterationsBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NumIterationsBinding"] = value; } }
        public bool bSpawnOnly { get { return this[nameof(bSpawnOnly)].Flag; } set { this[nameof(bSpawnOnly)].Flag = value; } }
        public ENiagaraSimStageExecuteBehavior ExecuteBehavior { get { return (ENiagaraSimStageExecuteBehavior)this[nameof(ExecuteBehavior)].GetValue<int>(); } set { this[nameof(ExecuteBehavior)].SetValue<int>((int)value); } }
        public bool bDisablePartialParticleUpdate { get { return this[nameof(bDisablePartialParticleUpdate)].Flag; } set { this[nameof(bDisablePartialParticleUpdate)].Flag = value; } }
        public NiagaraVariableDataInterfaceBinding DataInterface { get { return this[nameof(DataInterface)].As<NiagaraVariableDataInterfaceBinding>(); } set { this["DataInterface"] = value; } }
        public bool bParticleIterationStateEnabled { get { return this[nameof(bParticleIterationStateEnabled)].Flag; } set { this[nameof(bParticleIterationStateEnabled)].Flag = value; } }
        public NiagaraVariableAttributeBinding ParticleIterationStateBinding { get { return this[nameof(ParticleIterationStateBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ParticleIterationStateBinding"] = value; } }
        public IntPoint ParticleIterationStateRange { get { return this[nameof(ParticleIterationStateRange)].As<IntPoint>(); } set { this["ParticleIterationStateRange"] = value; } }
        public bool bGpuDispatchForceLinear { get { return this[nameof(bGpuDispatchForceLinear)].Flag; } set { this[nameof(bGpuDispatchForceLinear)].Flag = value; } }
        public bool bOverrideGpuDispatchType { get { return this[nameof(bOverrideGpuDispatchType)].Flag; } set { this[nameof(bOverrideGpuDispatchType)].Flag = value; } }
        public ENiagaraGpuDispatchType OverrideGpuDispatchType { get { return (ENiagaraGpuDispatchType)this[nameof(OverrideGpuDispatchType)].GetValue<int>(); } set { this[nameof(OverrideGpuDispatchType)].SetValue<int>((int)value); } }
        public bool bOverrideGpuDispatchNumThreads { get { return this[nameof(bOverrideGpuDispatchNumThreads)].Flag; } set { this[nameof(bOverrideGpuDispatchNumThreads)].Flag = value; } }
        public IntVector OverrideGpuDispatchNumThreads { get { return this[nameof(OverrideGpuDispatchNumThreads)].As<IntVector>(); } set { this["OverrideGpuDispatchNumThreads"] = value; } }
    }
    public class NiagaraSpriteRendererProperties : NiagaraRendererProperties
    {
        public NiagaraSpriteRendererProperties(nint addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public ENiagaraRendererSourceDataMode SourceMode { get { return (ENiagaraRendererSourceDataMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public NiagaraUserParameterBinding MaterialUserParamBinding { get { return this[nameof(MaterialUserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["MaterialUserParamBinding"] = value; } }
        public ENiagaraSpriteAlignment Alignment { get { return (ENiagaraSpriteAlignment)this[nameof(Alignment)].GetValue<int>(); } set { this[nameof(Alignment)].SetValue<int>((int)value); } }
        public ENiagaraSpriteFacingMode FacingMode { get { return (ENiagaraSpriteFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public Vector2D PivotInUVSpace { get { return this[nameof(PivotInUVSpace)].As<Vector2D>(); } set { this["PivotInUVSpace"] = value; } }
        public float MacroUVRadius { get { return this[nameof(MacroUVRadius)].GetValue<float>(); } set { this[nameof(MacroUVRadius)].SetValue<float>(value); } }
        public ENiagaraSortMode SortMode { get { return (ENiagaraSortMode)this[nameof(SortMode)].GetValue<int>(); } set { this[nameof(SortMode)].SetValue<int>((int)value); } }
        public Vector2D SubImageSize { get { return this[nameof(SubImageSize)].As<Vector2D>(); } set { this["SubImageSize"] = value; } }
        public bool bSubImageBlend { get { return this[nameof(bSubImageBlend)].Flag; } set { this[nameof(bSubImageBlend)].Flag = value; } }
        public bool bRemoveHMDRollInVR { get { return this[nameof(bRemoveHMDRollInVR)].Flag; } set { this[nameof(bRemoveHMDRollInVR)].Flag = value; } }
        public bool bSortOnlyWhenTranslucent { get { return this[nameof(bSortOnlyWhenTranslucent)].Flag; } set { this[nameof(bSortOnlyWhenTranslucent)].Flag = value; } }
        public ENiagaraRendererSortPrecision SortPrecision { get { return (ENiagaraRendererSortPrecision)this[nameof(SortPrecision)].GetValue<int>(); } set { this[nameof(SortPrecision)].SetValue<int>((int)value); } }
        public ENiagaraRendererGpuTranslucentLatency GpuTranslucentLatency { get { return (ENiagaraRendererGpuTranslucentLatency)this[nameof(GpuTranslucentLatency)].GetValue<int>(); } set { this[nameof(GpuTranslucentLatency)].SetValue<int>((int)value); } }
        public ENiagaraRendererPixelCoverageMode PixelCoverageMode { get { return (ENiagaraRendererPixelCoverageMode)this[nameof(PixelCoverageMode)].GetValue<int>(); } set { this[nameof(PixelCoverageMode)].SetValue<int>((int)value); } }
        public float PixelCoverageBlend { get { return this[nameof(PixelCoverageBlend)].GetValue<float>(); } set { this[nameof(PixelCoverageBlend)].SetValue<float>(value); } }
        public float MinFacingCameraBlendDistance { get { return this[nameof(MinFacingCameraBlendDistance)].GetValue<float>(); } set { this[nameof(MinFacingCameraBlendDistance)].SetValue<float>(value); } }
        public float MaxFacingCameraBlendDistance { get { return this[nameof(MaxFacingCameraBlendDistance)].GetValue<float>(); } set { this[nameof(MaxFacingCameraBlendDistance)].SetValue<float>(value); } }
        public bool bEnableCameraDistanceCulling { get { return this[nameof(bEnableCameraDistanceCulling)].Flag; } set { this[nameof(bEnableCameraDistanceCulling)].Flag = value; } }
        public float MinCameraDistance { get { return this[nameof(MinCameraDistance)].GetValue<float>(); } set { this[nameof(MinCameraDistance)].SetValue<float>(value); } }
        public float MaxCameraDistance { get { return this[nameof(MaxCameraDistance)].GetValue<float>(); } set { this[nameof(MaxCameraDistance)].SetValue<float>(value); } }
        public uint RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<uint>(); } set { this[nameof(RendererVisibility)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteRotationBinding { get { return this[nameof(SpriteRotationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteRotationBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteSizeBinding { get { return this[nameof(SpriteSizeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteSizeBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteFacingBinding { get { return this[nameof(SpriteFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteAlignmentBinding { get { return this[nameof(SpriteAlignmentBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteAlignmentBinding"] = value; } }
        public NiagaraVariableAttributeBinding SubImageIndexBinding { get { return this[nameof(SubImageIndexBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SubImageIndexBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding CameraOffsetBinding { get { return this[nameof(CameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding UVScaleBinding { get { return this[nameof(UVScaleBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["UVScaleBinding"] = value; } }
        public NiagaraVariableAttributeBinding PivotOffsetBinding { get { return this[nameof(PivotOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PivotOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding CustomSortingBinding { get { return this[nameof(CustomSortingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CustomSortingBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
        public NiagaraRendererMaterialParameters MaterialParameters { get { return this[nameof(MaterialParameters)].As<NiagaraRendererMaterialParameters>(); } set { this["MaterialParameters"] = value; } }
        public NiagaraVariableAttributeBinding PrevPositionBinding { get { return this[nameof(PrevPositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevPositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevVelocityBinding { get { return this[nameof(PrevVelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevVelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevSpriteRotationBinding { get { return this[nameof(PrevSpriteRotationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevSpriteRotationBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevSpriteSizeBinding { get { return this[nameof(PrevSpriteSizeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevSpriteSizeBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevSpriteFacingBinding { get { return this[nameof(PrevSpriteFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevSpriteFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevSpriteAlignmentBinding { get { return this[nameof(PrevSpriteAlignmentBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevSpriteAlignmentBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevCameraOffsetBinding { get { return this[nameof(PrevCameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevCameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding PrevPivotOffsetBinding { get { return this[nameof(PrevPivotOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PrevPivotOffsetBinding"] = value; } }
    }
    public class NiagaraSystem : FXSystemAsset
    {
        public NiagaraSystem(nint addr) : base(addr) { }
        public bool bSupportLargeWorldCoordinates { get { return this[nameof(bSupportLargeWorldCoordinates)].Flag; } set { this[nameof(bSupportLargeWorldCoordinates)].Flag = value; } }
        public bool bOverrideCastShadow { get { return this[nameof(bOverrideCastShadow)].Flag; } set { this[nameof(bOverrideCastShadow)].Flag = value; } }
        public bool bOverrideReceivesDecals { get { return this[nameof(bOverrideReceivesDecals)].Flag; } set { this[nameof(bOverrideReceivesDecals)].Flag = value; } }
        public bool bOverrideRenderCustomDepth { get { return this[nameof(bOverrideRenderCustomDepth)].Flag; } set { this[nameof(bOverrideRenderCustomDepth)].Flag = value; } }
        public bool bOverrideCustomDepthStencilValue { get { return this[nameof(bOverrideCustomDepthStencilValue)].Flag; } set { this[nameof(bOverrideCustomDepthStencilValue)].Flag = value; } }
        public bool bOverrideCustomDepthStencilWriteMask { get { return this[nameof(bOverrideCustomDepthStencilWriteMask)].Flag; } set { this[nameof(bOverrideCustomDepthStencilWriteMask)].Flag = value; } }
        public bool bOverrideTranslucencySortPriority { get { return this[nameof(bOverrideTranslucencySortPriority)].Flag; } set { this[nameof(bOverrideTranslucencySortPriority)].Flag = value; } }
        public bool bOverrideTranslucencySortDistanceOffset { get { return this[nameof(bOverrideTranslucencySortDistanceOffset)].Flag; } set { this[nameof(bOverrideTranslucencySortDistanceOffset)].Flag = value; } }
        public bool bCastShadow { get { return this[nameof(bCastShadow)].Flag; } set { this[nameof(bCastShadow)].Flag = value; } }
        public bool bReceivesDecals { get { return this[nameof(bReceivesDecals)].Flag; } set { this[nameof(bReceivesDecals)].Flag = value; } }
        public bool bRenderCustomDepth { get { return this[nameof(bRenderCustomDepth)].Flag; } set { this[nameof(bRenderCustomDepth)].Flag = value; } }
        public bool bDisableExperimentalVM { get { return this[nameof(bDisableExperimentalVM)].Flag; } set { this[nameof(bDisableExperimentalVM)].Flag = value; } }
        public ERendererStencilMask CustomDepthStencilWriteMask { get { return (ERendererStencilMask)this[nameof(CustomDepthStencilWriteMask)].GetValue<int>(); } set { this[nameof(CustomDepthStencilWriteMask)].SetValue<int>((int)value); } }
        public int CustomDepthStencilValue { get { return this[nameof(CustomDepthStencilValue)].GetValue<int>(); } set { this[nameof(CustomDepthStencilValue)].SetValue<int>(value); } }
        public int TranslucencySortPriority { get { return this[nameof(TranslucencySortPriority)].GetValue<int>(); } set { this[nameof(TranslucencySortPriority)].SetValue<int>(value); } }
        public float TranslucencySortDistanceOffset { get { return this[nameof(TranslucencySortDistanceOffset)].GetValue<float>(); } set { this[nameof(TranslucencySortDistanceOffset)].SetValue<float>(value); } }
        public bool bDumpDebugSystemInfo { get { return this[nameof(bDumpDebugSystemInfo)].Flag; } set { this[nameof(bDumpDebugSystemInfo)].Flag = value; } }
        public bool bDumpDebugEmitterInfo { get { return this[nameof(bDumpDebugEmitterInfo)].Flag; } set { this[nameof(bDumpDebugEmitterInfo)].Flag = value; } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
        public bool bFixedBounds { get { return this[nameof(bFixedBounds)].Flag; } set { this[nameof(bFixedBounds)].Flag = value; } }
        public NiagaraEffectType EffectType { get { return this[nameof(EffectType)].As<NiagaraEffectType>(); } set { this["EffectType"] = value; } }
        public bool bOverrideScalabilitySettings { get { return this[nameof(bOverrideScalabilitySettings)].Flag; } set { this[nameof(bOverrideScalabilitySettings)].Flag = value; } }
        public bool bOverrideAllowCullingForLocalPlayers { get { return this[nameof(bOverrideAllowCullingForLocalPlayers)].Flag; } set { this[nameof(bOverrideAllowCullingForLocalPlayers)].Flag = value; } }
        public bool bAllowCullingForLocalPlayersOverride { get { return this[nameof(bAllowCullingForLocalPlayersOverride)].Flag; } set { this[nameof(bAllowCullingForLocalPlayersOverride)].Flag = value; } }
        public Array<NiagaraSystemScalabilityOverride> ScalabilityOverrides { get { return new Array<NiagaraSystemScalabilityOverride>(this[nameof(ScalabilityOverrides)].Address); } }
        public NiagaraSystemScalabilityOverrides SystemScalabilityOverrides { get { return this[nameof(SystemScalabilityOverrides)].As<NiagaraSystemScalabilityOverrides>(); } set { this["SystemScalabilityOverrides"] = value; } }
        public Array<NiagaraEmitterHandle> EmitterHandles { get { return new Array<NiagaraEmitterHandle>(this[nameof(EmitterHandles)].Address); } }
        public Array<NiagaraParameterCollectionInstance> ParameterCollectionOverrides { get { return new Array<NiagaraParameterCollectionInstance>(this[nameof(ParameterCollectionOverrides)].Address); } }
        public NiagaraScript SystemSpawnScript { get { return this[nameof(SystemSpawnScript)].As<NiagaraScript>(); } set { this["SystemSpawnScript"] = value; } }
        public NiagaraScript SystemUpdateScript { get { return this[nameof(SystemUpdateScript)].As<NiagaraScript>(); } set { this["SystemUpdateScript"] = value; } }
        public NiagaraSystemCompiledData SystemCompiledData { get { return this[nameof(SystemCompiledData)].As<NiagaraSystemCompiledData>(); } set { this["SystemCompiledData"] = value; } }
        public NiagaraUserRedirectionParameterStore ExposedParameters { get { return this[nameof(ExposedParameters)].As<NiagaraUserRedirectionParameterStore>(); } set { this["ExposedParameters"] = value; } }
        public Box FixedBounds { get { return this[nameof(FixedBounds)].As<Box>(); } set { this["FixedBounds"] = value; } }
        public bool bAutoDeactivate { get { return this[nameof(bAutoDeactivate)].Flag; } set { this[nameof(bAutoDeactivate)].Flag = value; } }
        public bool bDeterminism { get { return this[nameof(bDeterminism)].Flag; } set { this[nameof(bDeterminism)].Flag = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public float WarmupTime { get { return this[nameof(WarmupTime)].GetValue<float>(); } set { this[nameof(WarmupTime)].SetValue<float>(value); } }
        public int WarmupTickCount { get { return this[nameof(WarmupTickCount)].GetValue<int>(); } set { this[nameof(WarmupTickCount)].SetValue<int>(value); } }
        public float WarmupTickDelta { get { return this[nameof(WarmupTickDelta)].GetValue<float>(); } set { this[nameof(WarmupTickDelta)].SetValue<float>(value); } }
        public bool bFixedTickDelta { get { return this[nameof(bFixedTickDelta)].Flag; } set { this[nameof(bFixedTickDelta)].Flag = value; } }
        public float FixedTickDeltaTime { get { return this[nameof(FixedTickDeltaTime)].GetValue<float>(); } set { this[nameof(FixedTickDeltaTime)].SetValue<float>(value); } }
        public bool bHasSystemScriptDIsWithPerInstanceData { get { return this[nameof(bHasSystemScriptDIsWithPerInstanceData)].Flag; } set { this[nameof(bHasSystemScriptDIsWithPerInstanceData)].Flag = value; } }
        public bool bNeedsGPUContextInitForDataInterfaces { get { return this[nameof(bNeedsGPUContextInitForDataInterfaces)].Flag; } set { this[nameof(bNeedsGPUContextInitForDataInterfaces)].Flag = value; } }
        public Array<Object> UserDINamesReadInSystemScripts { get { return new Array<Object>(this[nameof(UserDINamesReadInSystemScripts)].Address); } }
    }
    public class NiagaraValidationRule : Object
    {
        public NiagaraValidationRule(nint addr) : base(addr) { }
    }
    public class VolumeCache : Object
    {
        public VolumeCache(nint addr) : base(addr) { }
        public Object FilePath { get { return this[nameof(FilePath)]; } set { this[nameof(FilePath)] = value; } }
        public EVolumeCacheType CacheType { get { return (EVolumeCacheType)this[nameof(CacheType)].GetValue<int>(); } set { this[nameof(CacheType)].SetValue<int>((int)value); } }
        public IntVector Resolution { get { return this[nameof(Resolution)].As<IntVector>(); } set { this["Resolution"] = value; } }
        public int FrameRangeStart { get { return this[nameof(FrameRangeStart)].GetValue<int>(); } set { this[nameof(FrameRangeStart)].SetValue<int>(value); } }
        public int FrameRangeEnd { get { return this[nameof(FrameRangeEnd)].GetValue<int>(); } set { this[nameof(FrameRangeEnd)].SetValue<int>(value); } }
    }
    public class NiagaraSimCacheCreateParameters : Object
    {
        public NiagaraSimCacheCreateParameters(nint addr) : base(addr) { }
        public ENiagaraSimCacheAttributeCaptureMode AttributeCaptureMode { get { return (ENiagaraSimCacheAttributeCaptureMode)this[nameof(AttributeCaptureMode)].GetValue<int>(); } set { this[nameof(AttributeCaptureMode)].SetValue<int>((int)value); } }
        public bool bAllowRebasing { get { return this[nameof(bAllowRebasing)].Flag; } set { this[nameof(bAllowRebasing)].Flag = value; } }
        public bool bAllowDataInterfaceCaching { get { return this[nameof(bAllowDataInterfaceCaching)].Flag; } set { this[nameof(bAllowDataInterfaceCaching)].Flag = value; } }
        public Array<Object> RebaseIncludeAttributes { get { return new Array<Object>(this[nameof(RebaseIncludeAttributes)].Address); } }
        public Array<Object> RebaseExcludeAttributes { get { return new Array<Object>(this[nameof(RebaseExcludeAttributes)].Address); } }
        public Array<Object> ExplicitCaptureAttributes { get { return new Array<Object>(this[nameof(ExplicitCaptureAttributes)].Address); } }
    }
    public enum ENiagaraSimCacheAttributeCaptureMode : int
    {
        All = 0,
        RenderingOnly = 1,
        ExplicitAttributes = 2,
        ENiagaraSimCacheAttributeCaptureMode_MAX = 3,
    }
    public enum ENiagaraCollisionMode : int
    {
        None = 0,
        SceneGeometry = 1,
        DepthBuffer = 2,
        DistanceField = 3,
        ENiagaraCollisionMode_MAX = 4,
    }
    public enum ENiagaraTickBehavior : int
    {
        UsePrereqs = 0,
        UseComponentTickGroup = 1,
        ForceTickFirst = 2,
        ForceTickLast = 3,
        ENiagaraTickBehavior_MAX = 4,
    }
    public enum ENiagaraGpuBufferFormat : int
    {
        Float = 0,
        HalfFloat = 1,
        UnsignedNormalizedByte = 2,
        Max = 3,
    }
    public enum ENiagaraGpuSyncMode : int
    {
        None = 0,
        SyncCpuToGpu = 1,
        SyncGpuToCpu = 2,
        SyncBoth = 3,
        ENiagaraGpuSyncMode_MAX = 4,
    }
    public enum ENiagaraMipMapGeneration : int
    {
        Disabled = 0,
        PostStage = 1,
        PostSimulate = 2,
        ENiagaraMipMapGeneration_MAX = 3,
    }
    public enum ENiagaraDefaultMode : int
    {
        Value = 0,
        Binding = 1,
        Custom = 2,
        FailIfPreviouslyNotSet = 3,
        ENiagaraDefaultMode_MAX = 4,
    }
    public enum ENiagaraDefaultRendererMotionVectorSetting : int
    {
        Precise = 0,
        Approximate = 1,
        ENiagaraDefaultRendererMotionVectorSetting_MAX = 2,
    }
    public enum ENiagaraRendererMotionVectorSetting : int
    {
        AutoDetect = 0,
        Precise = 1,
        Approximate = 2,
        Disable = 3,
        ENiagaraRendererMotionVectorSetting_MAX = 4,
    }
    public enum ENiagaraSimTarget : int
    {
        CPUSim = 0,
        GPUComputeSim = 1,
        ENiagaraSimTarget_MAX = 2,
    }
    public enum ENiagaraAgeUpdateMode : int
    {
        TickDeltaTime = 0,
        DesiredAge = 1,
        DesiredAgeNoSeek = 2,
        ENiagaraAgeUpdateMode_MAX = 3,
    }
    public enum ENiagaraStatEvaluationType : int
    {
        Average = 0,
        Maximum = 1,
        ENiagaraStatEvaluationType_MAX = 2,
    }
    public enum ENiagaraStatDisplayMode : int
    {
        Percent = 0,
        Absolute = 1,
        ENiagaraStatDisplayMode_MAX = 2,
    }
    public enum ENiagaraDataSetType : int
    {
        ParticleData = 0,
        Shared = 1,
        Event = 2,
        ENiagaraDataSetType_MAX = 3,
    }
    public enum ENiagaraInputNodeUsage : int
    {
        Undefined = 0,
        Parameter = 1,
        Attribute = 2,
        SystemConstant = 3,
        TranslatorConstant = 4,
        RapidIterationParameter = 5,
        ENiagaraInputNodeUsage_MAX = 6,
    }
    public enum ENiagaraScriptCompileStatus : int
    {
        NCS_Unknown = 0,
        NCS_Dirty = 1,
        NCS_Error = 2,
        NCS_UpToDate = 3,
        NCS_BeingCreated = 4,
        NCS_UpToDateWithWarnings = 5,
        NCS_ComputeUpToDateWithWarnings = 6,
        NCS_MAX = 7,
    }
    public enum ENiagaraScriptUsage : int
    {
        Function = 0,
        Module = 1,
        DynamicInput = 2,
        ParticleSpawnScript = 3,
        ParticleSpawnScriptInterpolated = 4,
        ParticleUpdateScript = 5,
        ParticleEventScript = 6,
        ParticleSimulationStageScript = 7,
        ParticleGPUComputeScript = 8,
        EmitterSpawnScript = 9,
        EmitterUpdateScript = 10,
        SystemSpawnScript = 11,
        SystemUpdateScript = 12,
        ENiagaraScriptUsage_MAX = 13,
    }
    public enum ENiagaraCompileUsageStaticSwitch : int
    {
        Spawn = 0,
        Update = 1,
        Event = 2,
        SimulationStage = 3,
        Default = 4,
        ENiagaraCompileUsageStaticSwitch_MAX = 5,
    }
    public enum ENiagaraScriptContextStaticSwitch : int
    {
        System = 0,
        Emitter = 1,
        Particle = 2,
        ENiagaraScriptContextStaticSwitch_MAX = 3,
    }
    public enum ENiagaraScriptGroup : int
    {
        Particle = 0,
        Emitter = 1,
        System = 2,
        Max = 3,
    }
    public enum ENiagaraIterationSource : int
    {
        Particles = 0,
        DataInterface = 1,
        ENiagaraIterationSource_MAX = 2,
    }
    public enum ENiagaraBindingSource : int
    {
        ImplicitFromSource = 0,
        ExplicitParticles = 1,
        ExplicitEmitter = 2,
        ExplicitSystem = 3,
        ExplicitUser = 4,
        MaxBindingSource = 5,
        ENiagaraBindingSource_MAX = 6,
    }
    public enum ENiagaraRendererSourceDataMode : int
    {
        Particles = 0,
        Emitter = 1,
        ENiagaraRendererSourceDataMode_MAX = 2,
    }
    public enum ENiagaraLegacyTrailWidthMode : int
    {
        FromCentre = 0,
        FromFirst = 1,
        FromSecond = 2,
        ENiagaraLegacyTrailWidthMode_MAX = 3,
    }
    public enum ENCPoolMethod : int
    {
        None = 0,
        AutoRelease = 1,
        ManualRelease = 2,
        ManualRelease_OnComplete = 3,
        FreeInPool = 4,
        ENCPoolMethod_MAX = 5,
    }
    public enum ENiagaraSystemInstanceState : int
    {
        None = 0,
        PendingSpawn = 1,
        PendingSpawnPaused = 2,
        Spawning = 3,
        Running = 4,
        Paused = 5,
        Num = 6,
        ENiagaraSystemInstanceState_MAX = 7,
    }
    public enum ENiagaraFunctionDebugState : int
    {
        NoDebug = 0,
        Basic = 1,
        ENiagaraFunctionDebugState_MAX = 2,
    }
    public enum ENiagaraGpuComputeTickStage : int
    {
        PreInitViews = 0,
        PostInitViews = 1,
        PostOpaqueRender = 2,
        Max = 3,
        First = 0,
        Last = 2,
    }
    public enum ENiagaraSortMode : int
    {
        None = 0,
        ViewDepth = 1,
        ViewDistance = 2,
        CustomAscending = 3,
        CustomDecending = 4,
        ENiagaraSortMode_MAX = 5,
    }
    public enum ENDISkelMesh_GpuMaxInfluences : int
    {
        AllowMax4 = 0,
        AllowMax8 = 1,
        Unlimited = 2,
        ENDISkelMesh_MAX = 3,
    }
    public enum ENDISkelMesh_GpuUniformSamplingFormat : int
    {
        Full = 0,
        Limited_24_9 = 1,
        Limited_23_10 = 2,
        ENDISkelMesh_MAX = 3,
    }
    public enum ENDISkelMesh_AdjacencyTriangleIndexFormat : int
    {
        Full = 0,
        Half = 1,
        ENDISkelMesh_MAX = 2,
    }
    public enum ENiagaraDefaultRendererPixelCoverageMode : int
    {
        Enabled = 0,
        Disabled = 1,
        ENiagaraDefaultRendererPixelCoverageMode_MAX = 2,
    }
    public enum ENiagaraDefaultSortPrecision : int
    {
        Low = 0,
        High = 1,
        ENiagaraDefaultSortPrecision_MAX = 2,
    }
    public enum ENiagaraDefaultGpuTranslucentLatency : int
    {
        Immediate = 0,
        Latent = 1,
        ENiagaraDefaultGpuTranslucentLatency_MAX = 2,
    }
    public enum ENDICollisionQuery_AsyncGpuTraceProvider : int
    {
        Default = 0,
        HWRT = 1,
        GSDF = 2,
        None = 3,
        ENDICollisionQuery_MAX = 4,
    }
    public enum ENDIActorComponentSourceMode : int
    {
        Default = 0,
        AttachParent = 1,
        LocalPlayer = 2,
        ENDIActorComponentSourceMode_MAX = 3,
    }
    public enum ENDIStaticMesh_SourceMode : int
    {
        Default = 0,
        Source = 1,
        AttachParent = 2,
        DefaultMeshOnly = 3,
        ENDIStaticMesh_MAX = 4,
    }
    public enum ENiagaraSystemSpawnSectionStartBehavior : int
    {
        Activate = 0,
        ENiagaraSystemSpawnSectionStartBehavior_MAX = 1,
    }
    public enum ENiagaraSystemSpawnSectionEvaluateBehavior : int
    {
        ActivateIfInactive = 0,
        None = 1,
        ENiagaraSystemSpawnSectionEvaluateBehavior_MAX = 2,
    }
    public enum ENiagaraSystemSpawnSectionEndBehavior : int
    {
        SetSystemInactive = 0,
        Deactivate = 1,
        None = 2,
        ENiagaraSystemSpawnSectionEndBehavior_MAX = 3,
    }
    public enum ENiagaraCompilationState : int
    {
        CheckDDC = 0,
        Precompile = 1,
        StartCompileJob = 2,
        AwaitResult = 3,
        OptimizeByteCode = 4,
        ProcessResult = 5,
        PutToDDC = 6,
        Finished = 7,
        Aborted = 8,
        ENiagaraCompilationState_MAX = 9,
    }
    public enum ENiagaraBakerViewMode : int
    {
        Perspective = 0,
        OrthoFront = 1,
        OrthoBack = 2,
        OrthoLeft = 3,
        OrthoRight = 4,
        OrthoTop = 5,
        OrthoBottom = 6,
        Num = 7,
        ENiagaraBakerViewMode_MAX = 8,
    }
    public enum ENiagaraDataInterfaceEmitterBindingMode : int
    {
        Self = 0,
        Other = 1,
        ENiagaraDataInterfaceEmitterBindingMode_MAX = 2,
    }
    public enum ENDIExport_GPUAllocationMode : int
    {
        FixedSize = 0,
        PerParticle = 1,
        ENDIExport_MAX = 2,
    }
    public enum ENDILandscape_SourceMode : int
    {
        Default = 0,
        Source = 1,
        AttachParent = 2,
        ENDILandscape_MAX = 3,
    }
    public enum ESetResolutionMethod : int
    {
        Independent = 0,
        MaxAxis = 1,
        CellSize = 2,
        ESetResolutionMethod_MAX = 3,
    }
    public enum ENDISkeletalMesh_SourceMode : int
    {
        Default = 0,
        Source = 1,
        AttachParent = 2,
        ENDISkeletalMesh_MAX = 3,
    }
    public enum ENDISkeletalMesh_SkinningMode : int
    {
        Invalid = 255,
        None = 0,
        SkinOnTheFly = 1,
        PreSkin = 2,
        ENDISkeletalMesh_MAX = 256,
    }
    public enum ENiagaraDebugPlaybackMode : int
    {
        Play = 0,
        Loop = 1,
        Paused = 2,
        Step = 3,
        ENiagaraDebugPlaybackMode_MAX = 4,
    }
    public enum ENiagaraDebugHudHAlign : int
    {
        Left = 0,
        Center = 1,
        Right = 2,
        ENiagaraDebugHudHAlign_MAX = 3,
    }
    public enum ENiagaraDebugHudVAlign : int
    {
        Top = 0,
        Center = 1,
        Bottom = 2,
        ENiagaraDebugHudVAlign_MAX = 3,
    }
    public enum ENiagaraDebugHudFont : int
    {
        Small = 0,
        Normal = 1,
        ENiagaraDebugHudFont_MAX = 2,
    }
    public enum ENiagaraDebugHudVerbosity : int
    {
        None = 0,
        Basic = 1,
        Verbose = 2,
        ENiagaraDebugHudVerbosity_MAX = 3,
    }
    public enum ENiagaraDebugHUDOverviewMode : int
    {
        Overview = 0,
        Scalability = 1,
        Performance = 2,
        GpuComputePerformance = 3,
        ENiagaraDebugHUDOverviewMode_MAX = 4,
    }
    public enum ENiagaraDebugHUDPerfGraphMode : int
    {
        None = 0,
        GameThread = 1,
        RenderThread = 2,
        GPU = 3,
        ENiagaraDebugHUDPerfGraphMode_MAX = 4,
    }
    public enum ENiagaraDebugHUDPerfSampleMode : int
    {
        FrameTotal = 0,
        PerInstanceAverage = 1,
        ENiagaraDebugHUDPerfSampleMode_MAX = 2,
    }
    public enum ENiagaraCullReaction : int
    {
        Deactivate = 0,
        DeactivateImmediate = 1,
        DeactivateResume = 2,
        DeactivateImmediateResume = 3,
        ENiagaraCullReaction_MAX = 4,
    }
    public enum ENiagaraScalabilityUpdateFrequency : int
    {
        SpawnOnly = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Continuous = 4,
        ENiagaraScalabilityUpdateFrequency_MAX = 5,
    }
    public enum ENiagaraCullProxyMode : int
    {
        None = 0,
        Instanced_Rendered = 1,
        ENiagaraCullProxyMode_MAX = 2,
    }
    public enum EScriptExecutionMode : int
    {
        EveryParticle = 0,
        SpawnedParticles = 1,
        SingleParticle = 2,
        EScriptExecutionMode_MAX = 3,
    }
    public enum EParticleAllocationMode : int
    {
        AutomaticEstimate = 0,
        ManualEstimate = 1,
        FixedCount = 2,
        EParticleAllocationMode_MAX = 3,
    }
    public enum ENiagaraEmitterCalculateBoundMode : int
    {
        Dynamic = 0,
        Fixed = 1,
        Programmable = 2,
        ENiagaraEmitterCalculateBoundMode_MAX = 3,
    }
    public enum ENiagaraMeshFacingMode : int
    {
        Default = 0,
        Velocity = 1,
        CameraPosition = 2,
        CameraPlane = 3,
        ENiagaraMeshFacingMode_MAX = 4,
    }
    public enum ENiagaraMeshPivotOffsetSpace : int
    {
        Mesh = 0,
        Simulation = 1,
        World = 2,
        Local = 3,
        ENiagaraMeshPivotOffsetSpace_MAX = 4,
    }
    public enum ENiagaraMeshLockedAxisSpace : int
    {
        Simulation = 0,
        World = 1,
        Local = 2,
        ENiagaraMeshLockedAxisSpace_MAX = 3,
    }
    public enum ENiagaraPlatformSelectionState : int
    {
        Default = 0,
        Enabled = 1,
        Disabled = 2,
        ENiagaraPlatformSelectionState_MAX = 3,
    }
    public enum ENiagaraPlatformSetState : int
    {
        Disabled = 0,
        Enabled = 1,
        Active = 2,
        Unknown = 3,
        ENiagaraPlatformSetState_MAX = 4,
    }
    public enum ENiagaraCVarConditionResponse : int
    {
        None = 0,
        Enable = 1,
        Disable = 2,
        ENiagaraCVarConditionResponse_MAX = 3,
    }
    public enum ENiagaraDeviceProfileRedirectMode : int
    {
        CVar = 0,
        DeviceProfile = 1,
        ENiagaraDeviceProfileRedirectMode_MAX = 2,
    }
    public enum ENiagaraPreviewGridResetMode : int
    {
        Never = 0,
        Individual = 1,
        All = 2,
        ENiagaraPreviewGridResetMode_MAX = 3,
    }
    public enum ENiagaraRendererSortPrecision : int
    {
        Default = 0,
        Low = 1,
        High = 2,
        ENiagaraRendererSortPrecision_MAX = 3,
    }
    public enum ENiagaraRendererGpuTranslucentLatency : int
    {
        ProjectDefault = 0,
        Immediate = 1,
        Latent = 2,
        ENiagaraRendererGpuTranslucentLatency_MAX = 3,
    }
    public enum ENiagaraRibbonFacingMode : int
    {
        Screen = 0,
        Custom = 1,
        CustomSideVector = 2,
        ENiagaraRibbonFacingMode_MAX = 3,
    }
    public enum ENiagaraRibbonAgeOffsetMode : int
    {
        Scale = 0,
        Clip = 1,
        ENiagaraRibbonAgeOffsetMode_MAX = 2,
    }
    public enum ENiagaraRibbonDrawDirection : int
    {
        FrontToBack = 0,
        BackToFront = 1,
        ENiagaraRibbonDrawDirection_MAX = 2,
    }
    public enum ENiagaraRibbonShapeMode : int
    {
        Plane = 0,
        MultiPlane = 1,
        Tube = 2,
        Custom = 3,
        ENiagaraRibbonShapeMode_MAX = 4,
    }
    public enum ENiagaraRibbonTessellationMode : int
    {
        Automatic = 0,
        Custom = 1,
        Disabled = 2,
        ENiagaraRibbonTessellationMode_MAX = 3,
    }
    public enum ENiagaraRibbonUVEdgeMode : int
    {
        SmoothTransition = 0,
        Locked = 1,
        ENiagaraRibbonUVEdgeMode_MAX = 2,
    }
    public enum ENiagaraRibbonUVDistributionMode : int
    {
        ScaledUniformly = 0,
        ScaledUsingRibbonSegmentLength = 1,
        TiledOverRibbonLength = 2,
        TiledFromStartOverRibbonLength = 3,
        ENiagaraRibbonUVDistributionMode_MAX = 4,
    }
    public enum EUnusedAttributeBehaviour : int
    {
        Copy = 0,
        Zero = 1,
        None = 2,
        MarkInvalid = 3,
        PassThrough = 4,
        EUnusedAttributeBehaviour_MAX = 5,
    }
    public enum ENiagaraModuleDependencyType : int
    {
        PreDependency = 0,
        PostDependency = 1,
        ENiagaraModuleDependencyType_MAX = 2,
    }
    public enum ENiagaraModuleDependencyScriptConstraint : int
    {
        SameScript = 0,
        AllScripts = 1,
        ENiagaraModuleDependencyScriptConstraint_MAX = 2,
    }
    public enum ENiagaraScriptLibraryVisibility : int
    {
        Invalid = 0,
        Unexposed = 1,
        Library = 2,
        Hidden = 3,
        ENiagaraScriptLibraryVisibility_MAX = 4,
    }
    public enum ENiagaraScriptTemplateSpecification : int
    {
        None = 0,
        Template = 1,
        Behavior = 2,
        ENiagaraScriptTemplateSpecification_MAX = 3,
    }
    public enum ENiagaraModuleDependencyUsage : int
    {
        None = 0,
        Spawn = 1,
        Update = 2,
        Event = 3,
        SimulationStage = 4,
        ENiagaraModuleDependencyUsage_MAX = 5,
    }
    public enum ENiagaraSpriteAlignment : int
    {
        Unaligned = 0,
        VelocityAligned = 1,
        CustomAlignment = 2,
        ENiagaraSpriteAlignment_MAX = 3,
    }
    public enum ENiagaraSpriteFacingMode : int
    {
        FaceCamera = 0,
        FaceCameraPlane = 1,
        CustomFacingVector = 2,
        FaceCameraPosition = 3,
        FaceCameraDistanceBlend = 4,
        ENiagaraSpriteFacingMode_MAX = 5,
    }
    public enum ENiagaraRendererPixelCoverageMode : int
    {
        Automatic = 0,
        Disabled = 1,
        Enabled = 2,
        Enabled_RGBA = 3,
        Enabled_RGB = 4,
        Enabled_A = 5,
        ENiagaraRendererPixelCoverageMode_MAX = 6,
    }
    public enum ENiagaraStructConversionType : int
    {
        CopyOnly = 0,
        DoubleToFloat = 1,
        Vector2 = 2,
        Vector3 = 3,
        Vector4 = 4,
        Quat = 5,
        ENiagaraStructConversionType_MAX = 6,
    }
    public enum ENiagaraNumericOutputTypeSelectionMode : int
    {
        None = 0,
        Largest = 1,
        Smallest = 2,
        Scalar = 3,
        Custom = 4,
        ENiagaraNumericOutputTypeSelectionMode_MAX = 5,
    }
    public enum ENiagaraExecutionStateSource : int
    {
        Scalability = 0,
        Internal = 1,
        Owner = 2,
        InternalCompletion = 3,
        ENiagaraExecutionStateSource_MAX = 4,
    }
    public enum ENiagaraExecutionState : int
    {
        Active = 0,
        Inactive = 1,
        InactiveClear = 2,
        Complete = 3,
        Disabled = 4,
        Num = 5,
        ENiagaraExecutionState_MAX = 6,
    }
    public enum ENiagaraCoordinateSpace : int
    {
        Simulation = 0,
        World = 1,
        Local = 2,
        ENiagaraCoordinateSpace_MAX = 3,
    }
    public enum ENiagaraPythonUpdateScriptReference : int
    {
        None = 0,
        ScriptAsset = 1,
        DirectTextEntry = 2,
        ENiagaraPythonUpdateScriptReference_MAX = 3,
    }
    public enum ENiagaraOrientationAxis : int
    {
        XAxis = 0,
        YAxis = 1,
        ZAxis = 2,
        ENiagaraOrientationAxis_MAX = 3,
    }
    public enum ENiagaraBoolDisplayMode : int
    {
        DisplayAlways = 0,
        DisplayIfTrue = 1,
        DisplayIfFalse = 2,
        ENiagaraBoolDisplayMode_MAX = 3,
    }
    public enum ENiagaraValidationSeverity : int
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        ENiagaraValidationSeverity_MAX = 3,
    }
    public enum ENiagaraVariantMode : int
    {
        None = 0,
        Object = 1,
        DataInterface = 2,
        Bytes = 3,
        ENiagaraVariantMode_MAX = 4,
    }
    public enum EVolumeCacheType : int
    {
        OpenVDB = 0,
        EVolumeCacheType_MAX = 1,
    }
    public class NiagaraDataSetID : Object
    {
        public NiagaraDataSetID(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public ENiagaraDataSetType Type { get { return (ENiagaraDataSetType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class NiagaraDataSetProperties : Object
    {
        public NiagaraDataSetProperties(nint addr) : base(addr) { }
        public NiagaraDataSetID ID { get { return this[nameof(ID)].As<NiagaraDataSetID>(); } set { this["ID"] = value; } }
        public Array<NiagaraVariable> Variables { get { return new Array<NiagaraVariable>(this[nameof(Variables)].Address); } }
    }
    public class NiagaraVariableBase : Object
    {
        public NiagaraVariableBase(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public NiagaraTypeDefinitionHandle TypeDefHandle { get { return this[nameof(TypeDefHandle)].As<NiagaraTypeDefinitionHandle>(); } set { this["TypeDefHandle"] = value; } }
    }
    public class NiagaraTypeDefinitionHandle : Object
    {
        public NiagaraTypeDefinitionHandle(nint addr) : base(addr) { }
        public int RegisteredTypeIndex { get { return this[nameof(RegisteredTypeIndex)].GetValue<int>(); } set { this[nameof(RegisteredTypeIndex)].SetValue<int>(value); } }
    }
    public class NiagaraVariable : NiagaraVariableBase
    {
        public NiagaraVariable(nint addr) : base(addr) { }
        public Array<byte> VarData { get { return new Array<byte>(this[nameof(VarData)].Address); } }
    }
    public class NiagaraScriptDataUsageInfo : Object
    {
        public NiagaraScriptDataUsageInfo(nint addr) : base(addr) { }
        public bool bReadsAttributeData { get { return this[nameof(bReadsAttributeData)].Flag; } set { this[nameof(bReadsAttributeData)].Flag = value; } }
    }
    public class NiagaraFunctionSignature : Object
    {
        public NiagaraFunctionSignature(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Array<NiagaraVariable> Inputs { get { return new Array<NiagaraVariable>(this[nameof(Inputs)].Address); } }
        public Array<NiagaraVariable> Outputs { get { return new Array<NiagaraVariable>(this[nameof(Outputs)].Address); } }
        public Object OwnerName { get { return this[nameof(OwnerName)]; } set { this[nameof(OwnerName)] = value; } }
        public bool bRequiresContext { get { return this[nameof(bRequiresContext)].Flag; } set { this[nameof(bRequiresContext)].Flag = value; } }
        public bool bRequiresExecPin { get { return this[nameof(bRequiresExecPin)].Flag; } set { this[nameof(bRequiresExecPin)].Flag = value; } }
        public bool bMemberFunction { get { return this[nameof(bMemberFunction)].Flag; } set { this[nameof(bMemberFunction)].Flag = value; } }
        public bool bExperimental { get { return this[nameof(bExperimental)].Flag; } set { this[nameof(bExperimental)].Flag = value; } }
        public bool bSupportsCPU { get { return this[nameof(bSupportsCPU)].Flag; } set { this[nameof(bSupportsCPU)].Flag = value; } }
        public bool bSupportsGPU { get { return this[nameof(bSupportsGPU)].Flag; } set { this[nameof(bSupportsGPU)].Flag = value; } }
        public bool bWriteFunction { get { return this[nameof(bWriteFunction)].Flag; } set { this[nameof(bWriteFunction)].Flag = value; } }
        public bool bReadFunction { get { return this[nameof(bReadFunction)].Flag; } set { this[nameof(bReadFunction)].Flag = value; } }
        public bool bSoftDeprecatedFunction { get { return this[nameof(bSoftDeprecatedFunction)].Flag; } set { this[nameof(bSoftDeprecatedFunction)].Flag = value; } }
        public bool bIsCompileTagGenerator { get { return this[nameof(bIsCompileTagGenerator)].Flag; } set { this[nameof(bIsCompileTagGenerator)].Flag = value; } }
        public bool bHidden { get { return this[nameof(bHidden)].Flag; } set { this[nameof(bHidden)].Flag = value; } }
        public int ModuleUsageBitmask { get { return this[nameof(ModuleUsageBitmask)].GetValue<int>(); } set { this[nameof(ModuleUsageBitmask)].SetValue<int>(value); } }
        public int ContextStageIndex { get { return this[nameof(ContextStageIndex)].GetValue<int>(); } set { this[nameof(ContextStageIndex)].SetValue<int>(value); } }
        public Object FunctionSpecifiers { get { return this[nameof(FunctionSpecifiers)]; } set { this[nameof(FunctionSpecifiers)] = value; } }
    }
    public class NiagaraScriptDataInterfaceInfo : Object
    {
        public NiagaraScriptDataInterfaceInfo(nint addr) : base(addr) { }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int UserPtrIdx { get { return this[nameof(UserPtrIdx)].GetValue<int>(); } set { this[nameof(UserPtrIdx)].SetValue<int>(value); } }
        public NiagaraTypeDefinition Type { get { return this[nameof(Type)].As<NiagaraTypeDefinition>(); } set { this["Type"] = value; } }
        public Object RegisteredParameterMapRead { get { return this[nameof(RegisteredParameterMapRead)]; } set { this[nameof(RegisteredParameterMapRead)] = value; } }
        public Object RegisteredParameterMapWrite { get { return this[nameof(RegisteredParameterMapWrite)]; } set { this[nameof(RegisteredParameterMapWrite)] = value; } }
    }
    public class NiagaraTypeDefinition : Object
    {
        public NiagaraTypeDefinition(nint addr) : base(addr) { }
        public Object ClassStructOrEnum { get { return this[nameof(ClassStructOrEnum)].As<Object>(); } set { this["ClassStructOrEnum"] = value; } }
        public ushort UnderlyingType { get { return this[nameof(UnderlyingType)].GetValue<ushort>(); } set { this[nameof(UnderlyingType)].SetValue<ushort>(value); } }
        public byte Flags { get { return this[nameof(Flags)].GetValue<byte>(); } set { this[nameof(Flags)].SetValue<byte>(value); } }
    }
    public class NiagaraScriptDataInterfaceCompileInfo : Object
    {
        public NiagaraScriptDataInterfaceCompileInfo(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int UserPtrIdx { get { return this[nameof(UserPtrIdx)].GetValue<int>(); } set { this[nameof(UserPtrIdx)].SetValue<int>(value); } }
        public NiagaraTypeDefinition Type { get { return this[nameof(Type)].As<NiagaraTypeDefinition>(); } set { this["Type"] = value; } }
        public Object RegisteredParameterMapRead { get { return this[nameof(RegisteredParameterMapRead)]; } set { this[nameof(RegisteredParameterMapRead)] = value; } }
        public Object RegisteredParameterMapWrite { get { return this[nameof(RegisteredParameterMapWrite)]; } set { this[nameof(RegisteredParameterMapWrite)] = value; } }
        public bool bIsPlaceholder { get { return this[nameof(bIsPlaceholder)].Flag; } set { this[nameof(bIsPlaceholder)].Flag = value; } }
    }
    public class NiagaraStatScope : Object
    {
        public NiagaraStatScope(nint addr) : base(addr) { }
        public Object FullName { get { return this[nameof(FullName)]; } set { this[nameof(FullName)] = value; } }
        public Object FriendlyName { get { return this[nameof(FriendlyName)]; } set { this[nameof(FriendlyName)] = value; } }
    }
    public class VMFunctionSpecifier : Object
    {
        public VMFunctionSpecifier(nint addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class VMExternalFunctionBindingInfo : Object
    {
        public VMExternalFunctionBindingInfo(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object OwnerName { get { return this[nameof(OwnerName)]; } set { this[nameof(OwnerName)] = value; } }
        public Array<bool> InputParamLocations { get { return new Array<bool>(this[nameof(InputParamLocations)].Address); } }
        public int NumOutputs { get { return this[nameof(NumOutputs)].GetValue<int>(); } set { this[nameof(NumOutputs)].SetValue<int>(value); } }
        public Array<VMFunctionSpecifier> FunctionSpecifiers { get { return new Array<VMFunctionSpecifier>(this[nameof(FunctionSpecifiers)].Address); } }
    }
    public class NiagaraSystemUpdateContext : Object
    {
        public NiagaraSystemUpdateContext(nint addr) : base(addr) { }
        public Array<NiagaraComponent> ComponentsToReset { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToReset)].Address); } }
        public Array<NiagaraComponent> ComponentsToReInit { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToReInit)].Address); } }
        public Array<NiagaraComponent> ComponentsToNotifySimDestroy { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToNotifySimDestroy)].Address); } }
        public Array<NiagaraSystem> SystemSimsToDestroy { get { return new Array<NiagaraSystem>(this[nameof(SystemSimsToDestroy)].Address); } }
        public Array<NiagaraSystem> SystemSimsToRecache { get { return new Array<NiagaraSystem>(this[nameof(SystemSimsToRecache)].Address); } }
    }
    public class NiagaraVariableInfo : Object
    {
        public NiagaraVariableInfo(nint addr) : base(addr) { }
        public NiagaraVariable Variable { get { return this[nameof(Variable)].As<NiagaraVariable>(); } set { this["Variable"] = value; } }
        public Object Definition { get { return this[nameof(Definition)]; } set { this[nameof(Definition)] = value; } }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
    }
    public class NiagaraVariableAttributeBinding : Object
    {
        public NiagaraVariableAttributeBinding(nint addr) : base(addr) { }
        public NiagaraVariableBase ParamMapVariable { get { return this[nameof(ParamMapVariable)].As<NiagaraVariableBase>(); } set { this["ParamMapVariable"] = value; } }
        public NiagaraVariable DataSetVariable { get { return this[nameof(DataSetVariable)].As<NiagaraVariable>(); } set { this["DataSetVariable"] = value; } }
        public NiagaraVariable RootVariable { get { return this[nameof(RootVariable)].As<NiagaraVariable>(); } set { this["RootVariable"] = value; } }
        public byte BindingSourceMode { get { return this[nameof(BindingSourceMode)].GetValue<byte>(); } set { this[nameof(BindingSourceMode)].SetValue<byte>(value); } }
        public bool bBindingExistsOnSource { get { return this[nameof(bBindingExistsOnSource)].Flag; } set { this[nameof(bBindingExistsOnSource)].Flag = value; } }
        public bool bIsCachedParticleValue { get { return this[nameof(bIsCachedParticleValue)].Flag; } set { this[nameof(bIsCachedParticleValue)].Flag = value; } }
    }
    public class NiagaraMaterialAttributeBinding : Object
    {
        public NiagaraMaterialAttributeBinding(nint addr) : base(addr) { }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public NiagaraVariableBase NiagaraVariable { get { return this[nameof(NiagaraVariable)].As<NiagaraVariableBase>(); } set { this["NiagaraVariable"] = value; } }
        public NiagaraVariableBase ResolvedNiagaraVariable { get { return this[nameof(ResolvedNiagaraVariable)].As<NiagaraVariableBase>(); } set { this["ResolvedNiagaraVariable"] = value; } }
        public NiagaraVariableBase NiagaraChildVariable { get { return this[nameof(NiagaraChildVariable)].As<NiagaraVariableBase>(); } set { this["NiagaraChildVariable"] = value; } }
    }
    public class NiagaraVariableDataInterfaceBinding : Object
    {
        public NiagaraVariableDataInterfaceBinding(nint addr) : base(addr) { }
        public NiagaraVariable BoundVariable { get { return this[nameof(BoundVariable)].As<NiagaraVariable>(); } set { this["BoundVariable"] = value; } }
    }
    public class NiagaraScriptVariableBinding : Object
    {
        public NiagaraScriptVariableBinding(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class NiagaraUserParameterBinding : Object
    {
        public NiagaraUserParameterBinding(nint addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class NiagaraCompileDependency : Object
    {
        public NiagaraCompileDependency(nint addr) : base(addr) { }
        public Object LinkerErrorMessage { get { return this[nameof(LinkerErrorMessage)]; } set { this[nameof(LinkerErrorMessage)] = value; } }
        public Guid NodeGuid { get { return this[nameof(NodeGuid)].As<Guid>(); } set { this["NodeGuid"] = value; } }
        public Guid PinGuid { get { return this[nameof(PinGuid)].As<Guid>(); } set { this["PinGuid"] = value; } }
        public Array<Guid> StackGuids { get { return new Array<Guid>(this[nameof(StackGuids)].Address); } }
        public NiagaraVariableBase DependentVariable { get { return this[nameof(DependentVariable)].As<NiagaraVariableBase>(); } set { this["DependentVariable"] = value; } }
        public bool bDependentVariableFromCustomIterationNamespace { get { return this[nameof(bDependentVariableFromCustomIterationNamespace)].Flag; } set { this[nameof(bDependentVariableFromCustomIterationNamespace)].Flag = value; } }
    }
    public class NiagaraScalabilityState : Object
    {
        public NiagaraScalabilityState(nint addr) : base(addr) { }
        public float Significance { get { return this[nameof(Significance)].GetValue<float>(); } set { this[nameof(Significance)].SetValue<float>(value); } }
        public float LastVisibleTime { get { return this[nameof(LastVisibleTime)].GetValue<float>(); } set { this[nameof(LastVisibleTime)].SetValue<float>(value); } }
        public bool bCulled { get { return this[nameof(bCulled)].Flag; } set { this[nameof(bCulled)].Flag = value; } }
        public bool bPreviousCulled { get { return this[nameof(bPreviousCulled)].Flag; } set { this[nameof(bPreviousCulled)].Flag = value; } }
        public bool bCulledByDistance { get { return this[nameof(bCulledByDistance)].Flag; } set { this[nameof(bCulledByDistance)].Flag = value; } }
        public bool bCulledByInstanceCount { get { return this[nameof(bCulledByInstanceCount)].Flag; } set { this[nameof(bCulledByInstanceCount)].Flag = value; } }
        public bool bCulledByVisibility { get { return this[nameof(bCulledByVisibility)].Flag; } set { this[nameof(bCulledByVisibility)].Flag = value; } }
        public bool bCulledByGlobalBudget { get { return this[nameof(bCulledByGlobalBudget)].Flag; } set { this[nameof(bCulledByGlobalBudget)].Flag = value; } }
    }
    public class NiagaraStackSection : Object
    {
        public NiagaraStackSection(nint addr) : base(addr) { }
        public Object SectionIdentifier { get { return this[nameof(SectionIdentifier)]; } set { this[nameof(SectionIdentifier)] = value; } }
        public Object SectionDisplayName { get { return this[nameof(SectionDisplayName)]; } set { this[nameof(SectionDisplayName)] = value; } }
        public Array<Object> Categories { get { return new Array<Object>(this[nameof(Categories)].Address); } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class NDIStaticMeshSectionFilter : Object
    {
        public NDIStaticMeshSectionFilter(nint addr) : base(addr) { }
        public Array<int> AllowedMaterialSlots { get { return new Array<int>(this[nameof(AllowedMaterialSlots)].Address); } }
    }
    public class NiagaraUObjectPropertyReaderRemap : Object
    {
        public NiagaraUObjectPropertyReaderRemap(nint addr) : base(addr) { }
        public Object GraphName { get { return this[nameof(GraphName)]; } set { this[nameof(GraphName)] = value; } }
        public Object RemapName { get { return this[nameof(RemapName)]; } set { this[nameof(RemapName)] = value; } }
    }
    public class MovieSceneNiagaraSystemTrackTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneNiagaraSystemTrackTemplate(nint addr) : base(addr) { }
    }
    public class MovieSceneNiagaraSystemTrackImplementation : MovieSceneTrackImplementation
    {
        public MovieSceneNiagaraSystemTrackImplementation(nint addr) : base(addr) { }
        public FrameNumber SpawnSectionStartFrame { get { return this[nameof(SpawnSectionStartFrame)].As<FrameNumber>(); } set { this["SpawnSectionStartFrame"] = value; } }
        public FrameNumber SpawnSectionEndFrame { get { return this[nameof(SpawnSectionEndFrame)].As<FrameNumber>(); } set { this["SpawnSectionEndFrame"] = value; } }
        public ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior { get { return (ENiagaraSystemSpawnSectionStartBehavior)this[nameof(SpawnSectionStartBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionStartBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior { get { return (ENiagaraSystemSpawnSectionEvaluateBehavior)this[nameof(SpawnSectionEvaluateBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionEvaluateBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior { get { return (ENiagaraSystemSpawnSectionEndBehavior)this[nameof(SpawnSectionEndBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionEndBehavior)].SetValue<int>((int)value); } }
        public ENiagaraAgeUpdateMode AgeUpdateMode { get { return (ENiagaraAgeUpdateMode)this[nameof(AgeUpdateMode)].GetValue<int>(); } set { this[nameof(AgeUpdateMode)].SetValue<int>((int)value); } }
        public bool bAllowScalability { get { return this[nameof(bAllowScalability)].Flag; } set { this[nameof(bAllowScalability)].Flag = value; } }
    }
    public class MovieSceneNiagaraParameterSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneNiagaraParameterSectionTemplate(nint addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class MovieSceneNiagaraBoolParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraBoolParameterSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneBoolChannel BoolChannel { get { return this[nameof(BoolChannel)].As<MovieSceneBoolChannel>(); } set { this["BoolChannel"] = value; } }
    }
    public class MovieSceneNiagaraColorParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraColorParameterSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneFloatChannel RedChannel { get { return this[nameof(RedChannel)].As<MovieSceneFloatChannel>(); } set { this["RedChannel"] = value; } }
        public MovieSceneFloatChannel GreenChannel { get { return this[nameof(GreenChannel)].As<MovieSceneFloatChannel>(); } set { this["GreenChannel"] = value; } }
        public MovieSceneFloatChannel BlueChannel { get { return this[nameof(BlueChannel)].As<MovieSceneFloatChannel>(); } set { this["BlueChannel"] = value; } }
        public MovieSceneFloatChannel AlphaChannel { get { return this[nameof(AlphaChannel)].As<MovieSceneFloatChannel>(); } set { this["AlphaChannel"] = value; } }
    }
    public class MovieSceneNiagaraFloatParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraFloatParameterSectionTemplate(nint addr) : base(addr) { }
        //public MovieSceneFloatChannel FloatChannel { get { return this[nameof(FloatChannel)].As<MovieSceneFloatChannel>(); } set { this["FloatChannel"] = value; } }
    }
    public class MovieSceneNiagaraIntegerParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraIntegerParameterSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneIntegerChannel IntegerChannel { get { return this[nameof(IntegerChannel)].As<MovieSceneIntegerChannel>(); } set { this["IntegerChannel"] = value; } }
    }
    public class MovieSceneNiagaraVectorParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraVectorParameterSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneFloatChannel VectorChannels { get { return this[nameof(VectorChannels)].As<MovieSceneFloatChannel>(); } set { this["VectorChannels"] = value; } }
        public int ChannelsUsed { get { return this[nameof(ChannelsUsed)].GetValue<int>(); } set { this[nameof(ChannelsUsed)].SetValue<int>(value); } }
    }
    public class EmitterCompiledScriptPair : Object
    {
        public EmitterCompiledScriptPair(nint addr) : base(addr) { }
    }
    public class NiagaraBakerTextureSource : Object
    {
        public NiagaraBakerTextureSource(nint addr) : base(addr) { }
        public Object DisplayString { get { return this[nameof(DisplayString)]; } set { this[nameof(DisplayString)] = value; } }
        public Object SourceName { get { return this[nameof(SourceName)]; } set { this[nameof(SourceName)] = value; } }
    }
    public class NiagaraBakerCameraSettings : Object
    {
        public NiagaraBakerCameraSettings(nint addr) : base(addr) { }
        public ENiagaraBakerViewMode ViewMode { get { return (ENiagaraBakerViewMode)this[nameof(ViewMode)].GetValue<int>(); } set { this[nameof(ViewMode)].SetValue<int>((int)value); } }
        public Vector ViewportLocation { get { return this[nameof(ViewportLocation)].As<Vector>(); } set { this["ViewportLocation"] = value; } }
        public Rotator ViewportRotation { get { return this[nameof(ViewportRotation)].As<Rotator>(); } set { this["ViewportRotation"] = value; } }
        public float OrbitDistance { get { return this[nameof(OrbitDistance)].GetValue<float>(); } set { this[nameof(OrbitDistance)].SetValue<float>(value); } }
        public float FOV { get { return this[nameof(FOV)].GetValue<float>(); } set { this[nameof(FOV)].SetValue<float>(value); } }
        public float OrthoWidth { get { return this[nameof(OrthoWidth)].GetValue<float>(); } set { this[nameof(OrthoWidth)].SetValue<float>(value); } }
        public bool bUseAspectRatio { get { return this[nameof(bUseAspectRatio)].Flag; } set { this[nameof(bUseAspectRatio)].Flag = value; } }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
    }
    public class NiagaraBakerTextureSettings : Object
    {
        public NiagaraBakerTextureSettings(nint addr) : base(addr) { }
        public Object OutputName { get { return this[nameof(OutputName)]; } set { this[nameof(OutputName)] = value; } }
        public NiagaraBakerTextureSource SourceBinding { get { return this[nameof(SourceBinding)].As<NiagaraBakerTextureSource>(); } set { this["SourceBinding"] = value; } }
        public bool bUseFrameSize { get { return this[nameof(bUseFrameSize)].Flag; } set { this[nameof(bUseFrameSize)].Flag = value; } }
        public IntPoint FrameSize { get { return this[nameof(FrameSize)].As<IntPoint>(); } set { this["FrameSize"] = value; } }
        public IntPoint TextureSize { get { return this[nameof(TextureSize)].As<IntPoint>(); } set { this["TextureSize"] = value; } }
        public Texture2D GeneratedTexture { get { return this[nameof(GeneratedTexture)].As<Texture2D>(); } set { this["GeneratedTexture"] = value; } }
    }
    public class NCPoolElement : Object
    {
        public NCPoolElement(nint addr) : base(addr) { }
        public NiagaraComponent Component { get { return this[nameof(Component)].As<NiagaraComponent>(); } set { this["Component"] = value; } }
    }
    public class NCPool : Object
    {
        public NCPool(nint addr) : base(addr) { }
        public Array<NCPoolElement> FreeElements { get { return new Array<NCPoolElement>(this[nameof(FreeElements)].Address); } }
    }
    public class NiagaraComponentPropertyBinding : Object
    {
        public NiagaraComponentPropertyBinding(nint addr) : base(addr) { }
        public NiagaraVariableAttributeBinding AttributeBinding { get { return this[nameof(AttributeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["AttributeBinding"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public NiagaraTypeDefinition PropertyType { get { return this[nameof(PropertyType)].As<NiagaraTypeDefinition>(); } set { this["PropertyType"] = value; } }
        public Object MetadataSetterName { get { return this[nameof(MetadataSetterName)]; } set { this[nameof(MetadataSetterName)] = value; } }
        public Object PropertySetterParameterDefaults { get { return this[nameof(PropertySetterParameterDefaults)]; } set { this[nameof(PropertySetterParameterDefaults)] = value; } }
    }
    public class NiagaraEmitterNameSettingsRef : Object
    {
        public NiagaraEmitterNameSettingsRef(nint addr) : base(addr) { }
        public Object SystemName { get { return this[nameof(SystemName)]; } set { this[nameof(SystemName)] = value; } }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
    }
    public class NiagaraCulledComponentInfo : Object
    {
        public NiagaraCulledComponentInfo(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceEmitterBinding : Object
    {
        public NiagaraDataInterfaceEmitterBinding(nint addr) : base(addr) { }
        public ENiagaraDataInterfaceEmitterBindingMode BindingMode { get { return (ENiagaraDataInterfaceEmitterBindingMode)this[nameof(BindingMode)].GetValue<int>(); } set { this[nameof(BindingMode)].SetValue<int>((int)value); } }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
    }
    public class BasicParticleData : Object
    {
        public BasicParticleData(nint addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public float Size { get { return this[nameof(Size)].GetValue<float>(); } set { this[nameof(Size)].SetValue<float>(value); } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
    }
    public class MeshTriCoordinate : Object
    {
        public MeshTriCoordinate(nint addr) : base(addr) { }
        public int Tri { get { return this[nameof(Tri)].GetValue<int>(); } set { this[nameof(Tri)].SetValue<int>(value); } }
        public Vector3f BaryCoord { get { return this[nameof(BaryCoord)].As<Vector3f>(); } set { this["BaryCoord"] = value; } }
    }
    public class NiagaraDataInterfaceSplineLUT : Object
    {
        public NiagaraDataInterfaceSplineLUT(nint addr) : base(addr) { }
        public Array<Vector> Positions { get { return new Array<Vector>(this[nameof(Positions)].Address); } }
        public Array<Vector> Scales { get { return new Array<Vector>(this[nameof(Scales)].Address); } }
        public Array<Quat> Rotations { get { return new Array<Quat>(this[nameof(Rotations)].Address); } }
        public float SplineLength { get { return this[nameof(SplineLength)].GetValue<float>(); } set { this[nameof(SplineLength)].SetValue<float>(value); } }
        public float SplineDistanceStep { get { return this[nameof(SplineDistanceStep)].GetValue<float>(); } set { this[nameof(SplineDistanceStep)].SetValue<float>(value); } }
        public float InvSplineDistanceStep { get { return this[nameof(InvSplineDistanceStep)].GetValue<float>(); } set { this[nameof(InvSplineDistanceStep)].SetValue<float>(value); } }
        public int MaxIndex { get { return this[nameof(MaxIndex)].GetValue<int>(); } set { this[nameof(MaxIndex)].SetValue<int>(value); } }
    }
    public class NiagaraVariableLayoutInfo : Object
    {
        public NiagaraVariableLayoutInfo(nint addr) : base(addr) { }
        //public uint FloatComponentStart { get { return this[nameof(FloatComponentStart)].GetValue<uint>(); } set { this[nameof(FloatComponentStart)].SetValue<uint>(value); } }
        public uint Int32ComponentStart { get { return this[nameof(Int32ComponentStart)].GetValue<uint>(); } set { this[nameof(Int32ComponentStart)].SetValue<uint>(value); } }
        public uint HalfComponentStart { get { return this[nameof(HalfComponentStart)].GetValue<uint>(); } set { this[nameof(HalfComponentStart)].SetValue<uint>(value); } }
        public NiagaraTypeLayoutInfo LayoutInfo { get { return this[nameof(LayoutInfo)].As<NiagaraTypeLayoutInfo>(); } set { this["LayoutInfo"] = value; } }
    }
    public class NiagaraTypeLayoutInfo : Object
    {
        public NiagaraTypeLayoutInfo(nint addr) : base(addr) { }
        //public Array<uint> FloatComponentByteOffsets { get { return new Array<uint>(this[nameof(FloatComponentByteOffsets)].Address); } }
        //public Array<uint> FloatComponentRegisterOffsets { get { return new Array<uint>(this[nameof(FloatComponentRegisterOffsets)].Address); } }
        public Array<uint> Int32ComponentByteOffsets { get { return new Array<uint>(this[nameof(Int32ComponentByteOffsets)].Address); } }
        public Array<uint> Int32ComponentRegisterOffsets { get { return new Array<uint>(this[nameof(Int32ComponentRegisterOffsets)].Address); } }
        public Array<uint> HalfComponentByteOffsets { get { return new Array<uint>(this[nameof(HalfComponentByteOffsets)].Address); } }
        public Array<uint> HalfComponentRegisterOffsets { get { return new Array<uint>(this[nameof(HalfComponentRegisterOffsets)].Address); } }
    }
    public class NiagaraDataSetCompiledData : Object
    {
        public NiagaraDataSetCompiledData(nint addr) : base(addr) { }
        public Array<NiagaraVariable> Variables { get { return new Array<NiagaraVariable>(this[nameof(Variables)].Address); } }
        public Array<NiagaraVariableLayoutInfo> VariableLayouts { get { return new Array<NiagaraVariableLayoutInfo>(this[nameof(VariableLayouts)].Address); } }
        public NiagaraDataSetID ID { get { return this[nameof(ID)].As<NiagaraDataSetID>(); } set { this["ID"] = value; } }
        public uint TotalFloatComponents { get { return this[nameof(TotalFloatComponents)].GetValue<uint>(); } set { this[nameof(TotalFloatComponents)].SetValue<uint>(value); } }
        public uint TotalInt32Components { get { return this[nameof(TotalInt32Components)].GetValue<uint>(); } set { this[nameof(TotalInt32Components)].SetValue<uint>(value); } }
        public uint TotalHalfComponents { get { return this[nameof(TotalHalfComponents)].GetValue<uint>(); } set { this[nameof(TotalHalfComponents)].SetValue<uint>(value); } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
    }
    public class NiagaraOutlinerTimingData : Object
    {
        public NiagaraOutlinerTimingData(nint addr) : base(addr) { }
        public float GameThread { get { return this[nameof(GameThread)].GetValue<float>(); } set { this[nameof(GameThread)].SetValue<float>(value); } }
        public float RenderThread { get { return this[nameof(RenderThread)].GetValue<float>(); } set { this[nameof(RenderThread)].SetValue<float>(value); } }
    }
    public class NiagaraOutlinerEmitterInstanceData : Object
    {
        public NiagaraOutlinerEmitterInstanceData(nint addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
        public ENiagaraExecutionState ExecState { get { return (ENiagaraExecutionState)this[nameof(ExecState)].GetValue<int>(); } set { this[nameof(ExecState)].SetValue<int>((int)value); } }
        public int NumParticles { get { return this[nameof(NumParticles)].GetValue<int>(); } set { this[nameof(NumParticles)].SetValue<int>(value); } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
    }
    public class NiagaraOutlinerSystemInstanceData : Object
    {
        public NiagaraOutlinerSystemInstanceData(nint addr) : base(addr) { }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public Vector3f LWCTile { get { return this[nameof(LWCTile)].As<Vector3f>(); } set { this["LWCTile"] = value; } }
        public Array<NiagaraOutlinerEmitterInstanceData> Emitters { get { return new Array<NiagaraOutlinerEmitterInstanceData>(this[nameof(Emitters)].Address); } }
        public ENiagaraExecutionState ActualExecutionState { get { return (ENiagaraExecutionState)this[nameof(ActualExecutionState)].GetValue<int>(); } set { this[nameof(ActualExecutionState)].SetValue<int>((int)value); } }
        public ENiagaraExecutionState RequestedExecutionState { get { return (ENiagaraExecutionState)this[nameof(RequestedExecutionState)].GetValue<int>(); } set { this[nameof(RequestedExecutionState)].SetValue<int>((int)value); } }
        public NiagaraScalabilityState ScalabilityState { get { return this[nameof(ScalabilityState)].As<NiagaraScalabilityState>(); } set { this["ScalabilityState"] = value; } }
        public bool bPendingKill { get { return this[nameof(bPendingKill)].Flag; } set { this[nameof(bPendingKill)].Flag = value; } }
        public bool bUsingCullProxy { get { return this[nameof(bUsingCullProxy)].Flag; } set { this[nameof(bUsingCullProxy)].Flag = value; } }
        public ENCPoolMethod PoolMethod { get { return (ENCPoolMethod)this[nameof(PoolMethod)].GetValue<int>(); } set { this[nameof(PoolMethod)].SetValue<int>((int)value); } }
        public NiagaraOutlinerTimingData AverageTime { get { return this[nameof(AverageTime)].As<NiagaraOutlinerTimingData>(); } set { this["AverageTime"] = value; } }
        public NiagaraOutlinerTimingData MaxTime { get { return this[nameof(MaxTime)].As<NiagaraOutlinerTimingData>(); } set { this["MaxTime"] = value; } }
        public byte TickGroup { get { return this[nameof(TickGroup)].GetValue<byte>(); } set { this[nameof(TickGroup)].SetValue<byte>(value); } }
        public byte GpuTickStage { get { return this[nameof(GpuTickStage)].GetValue<byte>(); } set { this[nameof(GpuTickStage)].SetValue<byte>(value); } }
        public bool bIsSolo { get { return this[nameof(bIsSolo)].Flag; } set { this[nameof(bIsSolo)].Flag = value; } }
        public bool bRequiresDistanceFieldData { get { return this[nameof(bRequiresDistanceFieldData)].Flag; } set { this[nameof(bRequiresDistanceFieldData)].Flag = value; } }
        public bool bRequiresDepthBuffer { get { return this[nameof(bRequiresDepthBuffer)].Flag; } set { this[nameof(bRequiresDepthBuffer)].Flag = value; } }
        public bool bRequiresEarlyViewData { get { return this[nameof(bRequiresEarlyViewData)].Flag; } set { this[nameof(bRequiresEarlyViewData)].Flag = value; } }
        public bool bRequiresViewUniformBuffer { get { return this[nameof(bRequiresViewUniformBuffer)].Flag; } set { this[nameof(bRequiresViewUniformBuffer)].Flag = value; } }
        public bool bRequiresRayTracingScene { get { return this[nameof(bRequiresRayTracingScene)].Flag; } set { this[nameof(bRequiresRayTracingScene)].Flag = value; } }
    }
    public class NiagaraOutlinerSystemData : Object
    {
        public NiagaraOutlinerSystemData(nint addr) : base(addr) { }
        public Array<NiagaraOutlinerSystemInstanceData> SystemInstances { get { return new Array<NiagaraOutlinerSystemInstanceData>(this[nameof(SystemInstances)].Address); } }
        public NiagaraOutlinerTimingData AveragePerFrameTime { get { return this[nameof(AveragePerFrameTime)].As<NiagaraOutlinerTimingData>(); } set { this["AveragePerFrameTime"] = value; } }
        public NiagaraOutlinerTimingData MaxPerFrameTime { get { return this[nameof(MaxPerFrameTime)].As<NiagaraOutlinerTimingData>(); } set { this["MaxPerFrameTime"] = value; } }
        public NiagaraOutlinerTimingData AveragePerInstanceTime { get { return this[nameof(AveragePerInstanceTime)].As<NiagaraOutlinerTimingData>(); } set { this["AveragePerInstanceTime"] = value; } }
        public NiagaraOutlinerTimingData MaxPerInstanceTime { get { return this[nameof(MaxPerInstanceTime)].As<NiagaraOutlinerTimingData>(); } set { this["MaxPerInstanceTime"] = value; } }
    }
    public class NiagaraOutlinerWorldData : Object
    {
        public NiagaraOutlinerWorldData(nint addr) : base(addr) { }
        public Object Systems { get { return this[nameof(Systems)]; } set { this[nameof(Systems)] = value; } }
        public bool bHasBegunPlay { get { return this[nameof(bHasBegunPlay)].Flag; } set { this[nameof(bHasBegunPlay)].Flag = value; } }
        public byte WorldType { get { return this[nameof(WorldType)].GetValue<byte>(); } set { this[nameof(WorldType)].SetValue<byte>(value); } }
        public byte NetMode { get { return this[nameof(NetMode)].GetValue<byte>(); } set { this[nameof(NetMode)].SetValue<byte>(value); } }
        public NiagaraOutlinerTimingData AveragePerFrameTime { get { return this[nameof(AveragePerFrameTime)].As<NiagaraOutlinerTimingData>(); } set { this["AveragePerFrameTime"] = value; } }
        public NiagaraOutlinerTimingData MaxPerFrameTime { get { return this[nameof(MaxPerFrameTime)].As<NiagaraOutlinerTimingData>(); } set { this["MaxPerFrameTime"] = value; } }
    }
    public class NiagaraOutlinerData : Object
    {
        public NiagaraOutlinerData(nint addr) : base(addr) { }
        public Object WorldData { get { return this[nameof(WorldData)]; } set { this[nameof(WorldData)] = value; } }
    }
    public class NiagaraDebuggerRequestConnection : Object
    {
        public NiagaraDebuggerRequestConnection(nint addr) : base(addr) { }
        public Guid SessionId { get { return this[nameof(SessionId)].As<Guid>(); } set { this["SessionId"] = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
    }
    public class NiagaraDebuggerAcceptConnection : Object
    {
        public NiagaraDebuggerAcceptConnection(nint addr) : base(addr) { }
        public Guid SessionId { get { return this[nameof(SessionId)].As<Guid>(); } set { this["SessionId"] = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
    }
    public class NiagaraDebuggerConnectionClosed : Object
    {
        public NiagaraDebuggerConnectionClosed(nint addr) : base(addr) { }
        public Guid SessionId { get { return this[nameof(SessionId)].As<Guid>(); } set { this["SessionId"] = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
    }
    public class NiagaraDebuggerExecuteConsoleCommand : Object
    {
        public NiagaraDebuggerExecuteConsoleCommand(nint addr) : base(addr) { }
        public Object Command { get { return this[nameof(Command)]; } set { this[nameof(Command)] = value; } }
        public bool bRequiresWorld { get { return this[nameof(bRequiresWorld)].Flag; } set { this[nameof(bRequiresWorld)].Flag = value; } }
    }
    public class NiagaraDebuggerOutlinerUpdate : Object
    {
        public NiagaraDebuggerOutlinerUpdate(nint addr) : base(addr) { }
        public NiagaraOutlinerData OutlinerData { get { return this[nameof(OutlinerData)].As<NiagaraOutlinerData>(); } set { this["OutlinerData"] = value; } }
    }
    public class NiagaraDebugHudTextOptions : Object
    {
        public NiagaraDebugHudTextOptions(nint addr) : base(addr) { }
        public ENiagaraDebugHudFont Font { get { return (ENiagaraDebugHudFont)this[nameof(Font)].GetValue<int>(); } set { this[nameof(Font)].SetValue<int>((int)value); } }
        public ENiagaraDebugHudHAlign HorizontalAlignment { get { return (ENiagaraDebugHudHAlign)this[nameof(HorizontalAlignment)].GetValue<int>(); } set { this[nameof(HorizontalAlignment)].SetValue<int>((int)value); } }
        public ENiagaraDebugHudVAlign VerticalAlignment { get { return (ENiagaraDebugHudVAlign)this[nameof(VerticalAlignment)].GetValue<int>(); } set { this[nameof(VerticalAlignment)].SetValue<int>((int)value); } }
        public Vector2D ScreenOffset { get { return this[nameof(ScreenOffset)].As<Vector2D>(); } set { this["ScreenOffset"] = value; } }
    }
    public class NiagaraDebugHUDVariable : Object
    {
        public NiagaraDebugHUDVariable(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class NiagaraDebugHUDSettingsData : Object
    {
        public NiagaraDebugHUDSettingsData(nint addr) : base(addr) { }
        public bool bHudEnabled { get { return this[nameof(bHudEnabled)].Flag; } set { this[nameof(bHudEnabled)].Flag = value; } }
        public bool bHudRenderingEnabled { get { return this[nameof(bHudRenderingEnabled)].Flag; } set { this[nameof(bHudRenderingEnabled)].Flag = value; } }
        public bool bValidateSystemSimulationDataBuffers { get { return this[nameof(bValidateSystemSimulationDataBuffers)].Flag; } set { this[nameof(bValidateSystemSimulationDataBuffers)].Flag = value; } }
        public bool bValidateParticleDataBuffers { get { return this[nameof(bValidateParticleDataBuffers)].Flag; } set { this[nameof(bValidateParticleDataBuffers)].Flag = value; } }
        public bool bOverviewEnabled { get { return this[nameof(bOverviewEnabled)].Flag; } set { this[nameof(bOverviewEnabled)].Flag = value; } }
        public ENiagaraDebugHUDOverviewMode OverviewMode { get { return (ENiagaraDebugHUDOverviewMode)this[nameof(OverviewMode)].GetValue<int>(); } set { this[nameof(OverviewMode)].SetValue<int>((int)value); } }
        public ENiagaraDebugHudFont OverviewFont { get { return (ENiagaraDebugHudFont)this[nameof(OverviewFont)].GetValue<int>(); } set { this[nameof(OverviewFont)].SetValue<int>((int)value); } }
        public Vector2D OverviewLocation { get { return this[nameof(OverviewLocation)].As<Vector2D>(); } set { this["OverviewLocation"] = value; } }
        public bool bShowRegisteredComponents { get { return this[nameof(bShowRegisteredComponents)].Flag; } set { this[nameof(bShowRegisteredComponents)].Flag = value; } }
        public bool bOverviewShowFilteredSystemOnly { get { return this[nameof(bOverviewShowFilteredSystemOnly)].Flag; } set { this[nameof(bOverviewShowFilteredSystemOnly)].Flag = value; } }
        public Object ActorFilter { get { return this[nameof(ActorFilter)]; } set { this[nameof(ActorFilter)] = value; } }
        public bool bComponentFilterEnabled { get { return this[nameof(bComponentFilterEnabled)].Flag; } set { this[nameof(bComponentFilterEnabled)].Flag = value; } }
        public Object ComponentFilter { get { return this[nameof(ComponentFilter)]; } set { this[nameof(ComponentFilter)] = value; } }
        public bool bSystemFilterEnabled { get { return this[nameof(bSystemFilterEnabled)].Flag; } set { this[nameof(bSystemFilterEnabled)].Flag = value; } }
        public Object SystemFilter { get { return this[nameof(SystemFilter)]; } set { this[nameof(SystemFilter)] = value; } }
        public bool bEmitterFilterEnabled { get { return this[nameof(bEmitterFilterEnabled)].Flag; } set { this[nameof(bEmitterFilterEnabled)].Flag = value; } }
        public Object EmitterFilter { get { return this[nameof(EmitterFilter)]; } set { this[nameof(EmitterFilter)] = value; } }
        public bool bActorFilterEnabled { get { return this[nameof(bActorFilterEnabled)].Flag; } set { this[nameof(bActorFilterEnabled)].Flag = value; } }
        public ENiagaraDebugHudVerbosity SystemDebugVerbosity { get { return (ENiagaraDebugHudVerbosity)this[nameof(SystemDebugVerbosity)].GetValue<int>(); } set { this[nameof(SystemDebugVerbosity)].SetValue<int>((int)value); } }
        public ENiagaraDebugHudVerbosity SystemEmitterVerbosity { get { return (ENiagaraDebugHudVerbosity)this[nameof(SystemEmitterVerbosity)].GetValue<int>(); } set { this[nameof(SystemEmitterVerbosity)].SetValue<int>((int)value); } }
        public ENiagaraDebugHudVerbosity DataInterfaceVerbosity { get { return (ENiagaraDebugHudVerbosity)this[nameof(DataInterfaceVerbosity)].GetValue<int>(); } set { this[nameof(DataInterfaceVerbosity)].SetValue<int>((int)value); } }
        public bool bSystemShowBounds { get { return this[nameof(bSystemShowBounds)].Flag; } set { this[nameof(bSystemShowBounds)].Flag = value; } }
        public bool bSystemShowActiveOnlyInWorld { get { return this[nameof(bSystemShowActiveOnlyInWorld)].Flag; } set { this[nameof(bSystemShowActiveOnlyInWorld)].Flag = value; } }
        public bool bShowSystemVariables { get { return this[nameof(bShowSystemVariables)].Flag; } set { this[nameof(bShowSystemVariables)].Flag = value; } }
        public Array<NiagaraDebugHUDVariable> SystemVariables { get { return new Array<NiagaraDebugHUDVariable>(this[nameof(SystemVariables)].Address); } }
        public NiagaraDebugHudTextOptions SystemTextOptions { get { return this[nameof(SystemTextOptions)].As<NiagaraDebugHudTextOptions>(); } set { this["SystemTextOptions"] = value; } }
        public bool bShowParticleVariables { get { return this[nameof(bShowParticleVariables)].Flag; } set { this[nameof(bShowParticleVariables)].Flag = value; } }
        public bool bEnableGpuParticleReadback { get { return this[nameof(bEnableGpuParticleReadback)].Flag; } set { this[nameof(bEnableGpuParticleReadback)].Flag = value; } }
        public bool bShowParticleIndex { get { return this[nameof(bShowParticleIndex)].Flag; } set { this[nameof(bShowParticleIndex)].Flag = value; } }
        public Array<NiagaraDebugHUDVariable> ParticlesVariables { get { return new Array<NiagaraDebugHUDVariable>(this[nameof(ParticlesVariables)].Address); } }
        public NiagaraDebugHudTextOptions ParticleTextOptions { get { return this[nameof(ParticleTextOptions)].As<NiagaraDebugHudTextOptions>(); } set { this["ParticleTextOptions"] = value; } }
        public bool bShowParticlesVariablesWithSystem { get { return this[nameof(bShowParticlesVariablesWithSystem)].Flag; } set { this[nameof(bShowParticlesVariablesWithSystem)].Flag = value; } }
        public bool bShowParticleVariablesVertical { get { return this[nameof(bShowParticleVariablesVertical)].Flag; } set { this[nameof(bShowParticleVariablesVertical)].Flag = value; } }
        public bool bUseMaxParticlesToDisplay { get { return this[nameof(bUseMaxParticlesToDisplay)].Flag; } set { this[nameof(bUseMaxParticlesToDisplay)].Flag = value; } }
        public bool bUseParticleDisplayClip { get { return this[nameof(bUseParticleDisplayClip)].Flag; } set { this[nameof(bUseParticleDisplayClip)].Flag = value; } }
        public Vector2D ParticleDisplayClip { get { return this[nameof(ParticleDisplayClip)].As<Vector2D>(); } set { this["ParticleDisplayClip"] = value; } }
        public bool bUseParticleDisplayCenterRadius { get { return this[nameof(bUseParticleDisplayCenterRadius)].Flag; } set { this[nameof(bUseParticleDisplayCenterRadius)].Flag = value; } }
        public float ParticleDisplayCenterRadius { get { return this[nameof(ParticleDisplayCenterRadius)].GetValue<float>(); } set { this[nameof(ParticleDisplayCenterRadius)].SetValue<float>(value); } }
        public int MaxParticlesToDisplay { get { return this[nameof(MaxParticlesToDisplay)].GetValue<int>(); } set { this[nameof(MaxParticlesToDisplay)].SetValue<int>(value); } }
        public int PerfReportFrames { get { return this[nameof(PerfReportFrames)].GetValue<int>(); } set { this[nameof(PerfReportFrames)].SetValue<int>(value); } }
        public ENiagaraDebugHUDPerfSampleMode PerfSampleMode { get { return (ENiagaraDebugHUDPerfSampleMode)this[nameof(PerfSampleMode)].GetValue<int>(); } set { this[nameof(PerfSampleMode)].SetValue<int>((int)value); } }
        public ENiagaraDebugHUDPerfGraphMode PerfGraphMode { get { return (ENiagaraDebugHUDPerfGraphMode)this[nameof(PerfGraphMode)].GetValue<int>(); } set { this[nameof(PerfGraphMode)].SetValue<int>((int)value); } }
        public int PerfHistoryFrames { get { return this[nameof(PerfHistoryFrames)].GetValue<int>(); } set { this[nameof(PerfHistoryFrames)].SetValue<int>(value); } }
        public float PerfGraphTimeRange { get { return this[nameof(PerfGraphTimeRange)].GetValue<float>(); } set { this[nameof(PerfGraphTimeRange)].SetValue<float>(value); } }
        public Vector2D PerfGraphSize { get { return this[nameof(PerfGraphSize)].As<Vector2D>(); } set { this["PerfGraphSize"] = value; } }
        public LinearColor PerfGraphAxisColor { get { return this[nameof(PerfGraphAxisColor)].As<LinearColor>(); } set { this["PerfGraphAxisColor"] = value; } }
        public bool bEnableSmoothing { get { return this[nameof(bEnableSmoothing)].Flag; } set { this[nameof(bEnableSmoothing)].Flag = value; } }
        public int SmoothingWidth { get { return this[nameof(SmoothingWidth)].GetValue<int>(); } set { this[nameof(SmoothingWidth)].SetValue<int>(value); } }
        public LinearColor DefaultBackgroundColor { get { return this[nameof(DefaultBackgroundColor)].As<LinearColor>(); } set { this["DefaultBackgroundColor"] = value; } }
        public LinearColor OverviewHeadingColor { get { return this[nameof(OverviewHeadingColor)].As<LinearColor>(); } set { this["OverviewHeadingColor"] = value; } }
        public LinearColor OverviewDetailColor { get { return this[nameof(OverviewDetailColor)].As<LinearColor>(); } set { this["OverviewDetailColor"] = value; } }
        public LinearColor OverviewDetailHighlightColor { get { return this[nameof(OverviewDetailHighlightColor)].As<LinearColor>(); } set { this["OverviewDetailHighlightColor"] = value; } }
        public LinearColor InWorldErrorTextColor { get { return this[nameof(InWorldErrorTextColor)].As<LinearColor>(); } set { this["InWorldErrorTextColor"] = value; } }
        public LinearColor InWorldTextColor { get { return this[nameof(InWorldTextColor)].As<LinearColor>(); } set { this["InWorldTextColor"] = value; } }
        public LinearColor MessageInfoTextColor { get { return this[nameof(MessageInfoTextColor)].As<LinearColor>(); } set { this["MessageInfoTextColor"] = value; } }
        public LinearColor MessageWarningTextColor { get { return this[nameof(MessageWarningTextColor)].As<LinearColor>(); } set { this["MessageWarningTextColor"] = value; } }
        public LinearColor MessageErrorTextColor { get { return this[nameof(MessageErrorTextColor)].As<LinearColor>(); } set { this["MessageErrorTextColor"] = value; } }
        public float SystemColorTableOpacity { get { return this[nameof(SystemColorTableOpacity)].GetValue<float>(); } set { this[nameof(SystemColorTableOpacity)].SetValue<float>(value); } }
        public uint SystemColorSeed { get { return this[nameof(SystemColorSeed)].GetValue<uint>(); } set { this[nameof(SystemColorSeed)].SetValue<uint>(value); } }
        public Vector SystemColorHSVMin { get { return this[nameof(SystemColorHSVMin)].As<Vector>(); } set { this["SystemColorHSVMin"] = value; } }
        public Vector SystemColorHSVMax { get { return this[nameof(SystemColorHSVMax)].As<Vector>(); } set { this["SystemColorHSVMax"] = value; } }
        public ENiagaraDebugPlaybackMode PlaybackMode { get { return (ENiagaraDebugPlaybackMode)this[nameof(PlaybackMode)].GetValue<int>(); } set { this[nameof(PlaybackMode)].SetValue<int>((int)value); } }
        public bool bPlaybackRateEnabled { get { return this[nameof(bPlaybackRateEnabled)].Flag; } set { this[nameof(bPlaybackRateEnabled)].Flag = value; } }
        public float PlaybackRate { get { return this[nameof(PlaybackRate)].GetValue<float>(); } set { this[nameof(PlaybackRate)].SetValue<float>(value); } }
        public bool bLoopTimeEnabled { get { return this[nameof(bLoopTimeEnabled)].Flag; } set { this[nameof(bLoopTimeEnabled)].Flag = value; } }
        public float LoopTime { get { return this[nameof(LoopTime)].GetValue<float>(); } set { this[nameof(LoopTime)].SetValue<float>(value); } }
        public bool bShowGlobalBudgetInfo { get { return this[nameof(bShowGlobalBudgetInfo)].Flag; } set { this[nameof(bShowGlobalBudgetInfo)].Flag = value; } }
    }
    public class NiagaraRequestSimpleClientInfoMessage : Object
    {
        public NiagaraRequestSimpleClientInfoMessage(nint addr) : base(addr) { }
    }
    public class NiagaraOutlinerCaptureSettings : Object
    {
        public NiagaraOutlinerCaptureSettings(nint addr) : base(addr) { }
        public bool bTriggerCapture { get { return this[nameof(bTriggerCapture)].Flag; } set { this[nameof(bTriggerCapture)].Flag = value; } }
        public uint CaptureDelayFrames { get { return this[nameof(CaptureDelayFrames)].GetValue<uint>(); } set { this[nameof(CaptureDelayFrames)].SetValue<uint>(value); } }
        public bool bGatherPerfData { get { return this[nameof(bGatherPerfData)].Flag; } set { this[nameof(bGatherPerfData)].Flag = value; } }
        public uint SimCacheCaptureFrames { get { return this[nameof(SimCacheCaptureFrames)].GetValue<uint>(); } set { this[nameof(SimCacheCaptureFrames)].SetValue<uint>(value); } }
    }
    public class NiagaraSimpleClientInfo : Object
    {
        public NiagaraSimpleClientInfo(nint addr) : base(addr) { }
        public Array<Object> Systems { get { return new Array<Object>(this[nameof(Systems)].Address); } }
        public Array<Object> Actors { get { return new Array<Object>(this[nameof(Actors)].Address); } }
        public Array<Object> Components { get { return new Array<Object>(this[nameof(Components)].Address); } }
        public Array<Object> Emitters { get { return new Array<Object>(this[nameof(Emitters)].Address); } }
    }
    public class NiagaraSystemSimCacheCaptureRequest : Object
    {
        public NiagaraSystemSimCacheCaptureRequest(nint addr) : base(addr) { }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public uint CaptureDelayFrames { get { return this[nameof(CaptureDelayFrames)].GetValue<uint>(); } set { this[nameof(CaptureDelayFrames)].SetValue<uint>(value); } }
        public uint CaptureFrames { get { return this[nameof(CaptureFrames)].GetValue<uint>(); } set { this[nameof(CaptureFrames)].SetValue<uint>(value); } }
    }
    public class NiagaraSystemSimCacheCaptureReply : Object
    {
        public NiagaraSystemSimCacheCaptureReply(nint addr) : base(addr) { }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public Array<byte> SimCacheData { get { return new Array<byte>(this[nameof(SimCacheData)].Address); } }
    }
    public class NiagaraGraphViewSettings : Object
    {
        public NiagaraGraphViewSettings(nint addr) : base(addr) { }
        public Vector2D Location { get { return this[nameof(Location)].As<Vector2D>(); } set { this["Location"] = value; } }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public bool bIsValid { get { return this[nameof(bIsValid)].Flag; } set { this[nameof(bIsValid)].Flag = value; } }
    }
    public class NiagaraLinearRamp : Object
    {
        public NiagaraLinearRamp(nint addr) : base(addr) { }
        public float StartX { get { return this[nameof(StartX)].GetValue<float>(); } set { this[nameof(StartX)].SetValue<float>(value); } }
        public float StartY { get { return this[nameof(StartY)].GetValue<float>(); } set { this[nameof(StartY)].SetValue<float>(value); } }
        public float EndX { get { return this[nameof(EndX)].GetValue<float>(); } set { this[nameof(EndX)].SetValue<float>(value); } }
        public float EndY { get { return this[nameof(EndY)].GetValue<float>(); } set { this[nameof(EndY)].SetValue<float>(value); } }
    }
    public class NiagaraGlobalBudgetScaling : Object
    {
        public NiagaraGlobalBudgetScaling(nint addr) : base(addr) { }
        public bool bCullByGlobalBudget { get { return this[nameof(bCullByGlobalBudget)].Flag; } set { this[nameof(bCullByGlobalBudget)].Flag = value; } }
        public bool bScaleMaxDistanceByGlobalBudgetUse { get { return this[nameof(bScaleMaxDistanceByGlobalBudgetUse)].Flag; } set { this[nameof(bScaleMaxDistanceByGlobalBudgetUse)].Flag = value; } }
        public bool bScaleMaxInstanceCountByGlobalBudgetUse { get { return this[nameof(bScaleMaxInstanceCountByGlobalBudgetUse)].Flag; } set { this[nameof(bScaleMaxInstanceCountByGlobalBudgetUse)].Flag = value; } }
        public bool bScaleSystemInstanceCountByGlobalBudgetUse { get { return this[nameof(bScaleSystemInstanceCountByGlobalBudgetUse)].Flag; } set { this[nameof(bScaleSystemInstanceCountByGlobalBudgetUse)].Flag = value; } }
        public float MaxGlobalBudgetUsage { get { return this[nameof(MaxGlobalBudgetUsage)].GetValue<float>(); } set { this[nameof(MaxGlobalBudgetUsage)].SetValue<float>(value); } }
        public NiagaraLinearRamp MaxDistanceScaleByGlobalBudgetUse { get { return this[nameof(MaxDistanceScaleByGlobalBudgetUse)].As<NiagaraLinearRamp>(); } set { this["MaxDistanceScaleByGlobalBudgetUse"] = value; } }
        public NiagaraLinearRamp MaxInstanceCountScaleByGlobalBudgetUse { get { return this[nameof(MaxInstanceCountScaleByGlobalBudgetUse)].As<NiagaraLinearRamp>(); } set { this["MaxInstanceCountScaleByGlobalBudgetUse"] = value; } }
        public NiagaraLinearRamp MaxSystemInstanceCountScaleByGlobalBudgetUse { get { return this[nameof(MaxSystemInstanceCountScaleByGlobalBudgetUse)].As<NiagaraLinearRamp>(); } set { this["MaxSystemInstanceCountScaleByGlobalBudgetUse"] = value; } }
    }
    public class NiagaraSystemVisibilityCullingSettings : Object
    {
        public NiagaraSystemVisibilityCullingSettings(nint addr) : base(addr) { }
        public bool bCullWhenNotRendered { get { return this[nameof(bCullWhenNotRendered)].Flag; } set { this[nameof(bCullWhenNotRendered)].Flag = value; } }
        public bool bCullByViewFrustum { get { return this[nameof(bCullByViewFrustum)].Flag; } set { this[nameof(bCullByViewFrustum)].Flag = value; } }
        public bool bAllowPreCullingByViewFrustum { get { return this[nameof(bAllowPreCullingByViewFrustum)].Flag; } set { this[nameof(bAllowPreCullingByViewFrustum)].Flag = value; } }
        public float MaxTimeOutsideViewFrustum { get { return this[nameof(MaxTimeOutsideViewFrustum)].GetValue<float>(); } set { this[nameof(MaxTimeOutsideViewFrustum)].SetValue<float>(value); } }
        public float MaxTimeWithoutRender { get { return this[nameof(MaxTimeWithoutRender)].GetValue<float>(); } set { this[nameof(MaxTimeWithoutRender)].SetValue<float>(value); } }
    }
    public class NiagaraSystemScalabilitySettings : Object
    {
        public NiagaraSystemScalabilitySettings(nint addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public bool bCullByDistance { get { return this[nameof(bCullByDistance)].Flag; } set { this[nameof(bCullByDistance)].Flag = value; } }
        public bool bCullMaxInstanceCount { get { return this[nameof(bCullMaxInstanceCount)].Flag; } set { this[nameof(bCullMaxInstanceCount)].Flag = value; } }
        public bool bCullPerSystemMaxInstanceCount { get { return this[nameof(bCullPerSystemMaxInstanceCount)].Flag; } set { this[nameof(bCullPerSystemMaxInstanceCount)].Flag = value; } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public bool bCullByMaxTimeWithoutRender { get { return this[nameof(bCullByMaxTimeWithoutRender)].Flag; } set { this[nameof(bCullByMaxTimeWithoutRender)].Flag = value; } }
        public int MaxInstances { get { return this[nameof(MaxInstances)].GetValue<int>(); } set { this[nameof(MaxInstances)].SetValue<int>(value); } }
        public int MaxSystemInstances { get { return this[nameof(MaxSystemInstances)].GetValue<int>(); } set { this[nameof(MaxSystemInstances)].SetValue<int>(value); } }
        public float MaxTimeWithoutRender { get { return this[nameof(MaxTimeWithoutRender)].GetValue<float>(); } set { this[nameof(MaxTimeWithoutRender)].SetValue<float>(value); } }
        public ENiagaraCullProxyMode CullProxyMode { get { return (ENiagaraCullProxyMode)this[nameof(CullProxyMode)].GetValue<int>(); } set { this[nameof(CullProxyMode)].SetValue<int>((int)value); } }
        public int MaxSystemProxies { get { return this[nameof(MaxSystemProxies)].GetValue<int>(); } set { this[nameof(MaxSystemProxies)].SetValue<int>(value); } }
        public NiagaraSystemVisibilityCullingSettings VisibilityCulling { get { return this[nameof(VisibilityCulling)].As<NiagaraSystemVisibilityCullingSettings>(); } set { this["VisibilityCulling"] = value; } }
        public NiagaraGlobalBudgetScaling BudgetScaling { get { return this[nameof(BudgetScaling)].As<NiagaraGlobalBudgetScaling>(); } set { this["BudgetScaling"] = value; } }
    }
    public class NiagaraPlatformSet : Object
    {
        public NiagaraPlatformSet(nint addr) : base(addr) { }
        public int QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<int>(); } set { this[nameof(QualityLevelMask)].SetValue<int>(value); } }
        public Array<NiagaraDeviceProfileStateEntry> DeviceProfileStates { get { return new Array<NiagaraDeviceProfileStateEntry>(this[nameof(DeviceProfileStates)].Address); } }
        public Array<NiagaraPlatformSetCVarCondition> CVarConditions { get { return new Array<NiagaraPlatformSetCVarCondition>(this[nameof(CVarConditions)].Address); } }
    }
    public class NiagaraPlatformSetCVarCondition : Object
    {
        public NiagaraPlatformSetCVarCondition(nint addr) : base(addr) { }
        public Object CVarName { get { return this[nameof(CVarName)]; } set { this[nameof(CVarName)] = value; } }
        public ENiagaraCVarConditionResponse PassResponse { get { return (ENiagaraCVarConditionResponse)this[nameof(PassResponse)].GetValue<int>(); } set { this[nameof(PassResponse)].SetValue<int>((int)value); } }
        public ENiagaraCVarConditionResponse FailResponse { get { return (ENiagaraCVarConditionResponse)this[nameof(FailResponse)].GetValue<int>(); } set { this[nameof(FailResponse)].SetValue<int>((int)value); } }
        public bool Value { get { return this[nameof(Value)].Flag; } set { this[nameof(Value)].Flag = value; } }
        public int MinInt { get { return this[nameof(MinInt)].GetValue<int>(); } set { this[nameof(MinInt)].SetValue<int>(value); } }
        public int MaxInt { get { return this[nameof(MaxInt)].GetValue<int>(); } set { this[nameof(MaxInt)].SetValue<int>(value); } }
        public float MinFloat { get { return this[nameof(MinFloat)].GetValue<float>(); } set { this[nameof(MinFloat)].SetValue<float>(value); } }
        public float MaxFloat { get { return this[nameof(MaxFloat)].GetValue<float>(); } set { this[nameof(MaxFloat)].SetValue<float>(value); } }
        public bool bUseMinInt { get { return this[nameof(bUseMinInt)].Flag; } set { this[nameof(bUseMinInt)].Flag = value; } }
        public bool bUseMaxInt { get { return this[nameof(bUseMaxInt)].Flag; } set { this[nameof(bUseMaxInt)].Flag = value; } }
        public bool bUseMinFloat { get { return this[nameof(bUseMinFloat)].Flag; } set { this[nameof(bUseMinFloat)].Flag = value; } }
        public bool bUseMaxFloat { get { return this[nameof(bUseMaxFloat)].Flag; } set { this[nameof(bUseMaxFloat)].Flag = value; } }
    }
    public class NiagaraDeviceProfileStateEntry : Object
    {
        public NiagaraDeviceProfileStateEntry(nint addr) : base(addr) { }
        public Object ProfileName { get { return this[nameof(ProfileName)]; } set { this[nameof(ProfileName)] = value; } }
        public uint QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<uint>(); } set { this[nameof(QualityLevelMask)].SetValue<uint>(value); } }
        public uint SetQualityLevelMask { get { return this[nameof(SetQualityLevelMask)].GetValue<uint>(); } set { this[nameof(SetQualityLevelMask)].SetValue<uint>(value); } }
    }
    public class NiagaraSystemScalabilitySettingsArray : Object
    {
        public NiagaraSystemScalabilitySettingsArray(nint addr) : base(addr) { }
        public Array<NiagaraSystemScalabilitySettings> Settings { get { return new Array<NiagaraSystemScalabilitySettings>(this[nameof(Settings)].Address); } }
    }
    public class NiagaraSystemScalabilityOverride : NiagaraSystemScalabilitySettings
    {
        public NiagaraSystemScalabilityOverride(nint addr) : base(addr) { }
        public bool bOverrideDistanceSettings { get { return this[nameof(bOverrideDistanceSettings)].Flag; } set { this[nameof(bOverrideDistanceSettings)].Flag = value; } }
        public bool bOverrideInstanceCountSettings { get { return this[nameof(bOverrideInstanceCountSettings)].Flag; } set { this[nameof(bOverrideInstanceCountSettings)].Flag = value; } }
        public bool bOverridePerSystemInstanceCountSettings { get { return this[nameof(bOverridePerSystemInstanceCountSettings)].Flag; } set { this[nameof(bOverridePerSystemInstanceCountSettings)].Flag = value; } }
        public bool bOverrideVisibilitySettings { get { return this[nameof(bOverrideVisibilitySettings)].Flag; } set { this[nameof(bOverrideVisibilitySettings)].Flag = value; } }
        public bool bOverrideGlobalBudgetScalingSettings { get { return this[nameof(bOverrideGlobalBudgetScalingSettings)].Flag; } set { this[nameof(bOverrideGlobalBudgetScalingSettings)].Flag = value; } }
        public bool bOverrideCullProxySettings { get { return this[nameof(bOverrideCullProxySettings)].Flag; } set { this[nameof(bOverrideCullProxySettings)].Flag = value; } }
    }
    public class NiagaraSystemScalabilityOverrides : Object
    {
        public NiagaraSystemScalabilityOverrides(nint addr) : base(addr) { }
        public Array<NiagaraSystemScalabilityOverride> Overrides { get { return new Array<NiagaraSystemScalabilityOverride>(this[nameof(Overrides)].Address); } }
    }
    public class NiagaraEmitterScalabilitySettings : Object
    {
        public NiagaraEmitterScalabilitySettings(nint addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public bool bScaleSpawnCount { get { return this[nameof(bScaleSpawnCount)].Flag; } set { this[nameof(bScaleSpawnCount)].Flag = value; } }
        public float SpawnCountScale { get { return this[nameof(SpawnCountScale)].GetValue<float>(); } set { this[nameof(SpawnCountScale)].SetValue<float>(value); } }
    }
    public class NiagaraEmitterScalabilitySettingsArray : Object
    {
        public NiagaraEmitterScalabilitySettingsArray(nint addr) : base(addr) { }
        public Array<NiagaraEmitterScalabilitySettings> Settings { get { return new Array<NiagaraEmitterScalabilitySettings>(this[nameof(Settings)].Address); } }
    }
    public class NiagaraEmitterScalabilityOverride : NiagaraEmitterScalabilitySettings
    {
        public NiagaraEmitterScalabilityOverride(nint addr) : base(addr) { }
        public bool bOverrideSpawnCountScale { get { return this[nameof(bOverrideSpawnCountScale)].Flag; } set { this[nameof(bOverrideSpawnCountScale)].Flag = value; } }
    }
    public class NiagaraEmitterScalabilityOverrides : Object
    {
        public NiagaraEmitterScalabilityOverrides(nint addr) : base(addr) { }
        public Array<NiagaraEmitterScalabilityOverride> Overrides { get { return new Array<NiagaraEmitterScalabilityOverride>(this[nameof(Overrides)].Address); } }
    }
    public class NiagaraEventReceiverProperties : Object
    {
        public NiagaraEventReceiverProperties(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object SourceEventGenerator { get { return this[nameof(SourceEventGenerator)]; } set { this[nameof(SourceEventGenerator)] = value; } }
        public Object SourceEmitter { get { return this[nameof(SourceEmitter)]; } set { this[nameof(SourceEmitter)] = value; } }
    }
    public class NiagaraEventGeneratorProperties : Object
    {
        public NiagaraEventGeneratorProperties(nint addr) : base(addr) { }
        public int MaxEventsPerFrame { get { return this[nameof(MaxEventsPerFrame)].GetValue<int>(); } set { this[nameof(MaxEventsPerFrame)].SetValue<int>(value); } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
    }
    public class NiagaraEmitterScriptProperties : Object
    {
        public NiagaraEmitterScriptProperties(nint addr) : base(addr) { }
        public NiagaraScript Script { get { return this[nameof(Script)].As<NiagaraScript>(); } set { this["Script"] = value; } }
        public Array<NiagaraEventReceiverProperties> EventReceivers { get { return new Array<NiagaraEventReceiverProperties>(this[nameof(EventReceivers)].Address); } }
        public Array<NiagaraEventGeneratorProperties> EventGenerators { get { return new Array<NiagaraEventGeneratorProperties>(this[nameof(EventGenerators)].Address); } }
    }
    public class NiagaraEventScriptProperties : NiagaraEmitterScriptProperties
    {
        public NiagaraEventScriptProperties(nint addr) : base(addr) { }
        public EScriptExecutionMode ExecutionMode { get { return (EScriptExecutionMode)this[nameof(ExecutionMode)].GetValue<int>(); } set { this[nameof(ExecutionMode)].SetValue<int>((int)value); } }
        public uint SpawnNumber { get { return this[nameof(SpawnNumber)].GetValue<uint>(); } set { this[nameof(SpawnNumber)].SetValue<uint>(value); } }
        public uint MaxEventsPerFrame { get { return this[nameof(MaxEventsPerFrame)].GetValue<uint>(); } set { this[nameof(MaxEventsPerFrame)].SetValue<uint>(value); } }
        public Guid SourceEmitterID { get { return this[nameof(SourceEmitterID)].As<Guid>(); } set { this["SourceEmitterID"] = value; } }
        public Object SourceEventName { get { return this[nameof(SourceEventName)]; } set { this[nameof(SourceEventName)] = value; } }
        public bool bRandomSpawnNumber { get { return this[nameof(bRandomSpawnNumber)].Flag; } set { this[nameof(bRandomSpawnNumber)].Flag = value; } }
        public uint MinSpawnNumber { get { return this[nameof(MinSpawnNumber)].GetValue<uint>(); } set { this[nameof(MinSpawnNumber)].SetValue<uint>(value); } }
        public bool UpdateAttributeInitialValues { get { return this[nameof(UpdateAttributeInitialValues)].Flag; } set { this[nameof(UpdateAttributeInitialValues)].Flag = value; } }
    }
    public class NiagaraDetailsLevelScaleOverrides : Object
    {
        public NiagaraDetailsLevelScaleOverrides(nint addr) : base(addr) { }
        public float Low { get { return this[nameof(Low)].GetValue<float>(); } set { this[nameof(Low)].SetValue<float>(value); } }
        public float Medium { get { return this[nameof(Medium)].GetValue<float>(); } set { this[nameof(Medium)].SetValue<float>(value); } }
        public float High { get { return this[nameof(High)].GetValue<float>(); } set { this[nameof(High)].SetValue<float>(value); } }
        public float Epic { get { return this[nameof(Epic)].GetValue<float>(); } set { this[nameof(Epic)].SetValue<float>(value); } }
        public float Cine { get { return this[nameof(Cine)].GetValue<float>(); } set { this[nameof(Cine)].SetValue<float>(value); } }
    }
    public class VersionedNiagaraEmitterData : Object
    {
        public VersionedNiagaraEmitterData(nint addr) : base(addr) { }
        public NiagaraAssetVersion Version { get { return this[nameof(Version)].As<NiagaraAssetVersion>(); } set { this["Version"] = value; } }
        public Object VersionChangeDescription { get { return this[nameof(VersionChangeDescription)]; } set { this[nameof(VersionChangeDescription)] = value; } }
        public ENiagaraPythonUpdateScriptReference UpdateScriptExecution { get { return (ENiagaraPythonUpdateScriptReference)this[nameof(UpdateScriptExecution)].GetValue<int>(); } set { this[nameof(UpdateScriptExecution)].SetValue<int>((int)value); } }
        public Object PythonUpdateScript { get { return this[nameof(PythonUpdateScript)]; } set { this[nameof(PythonUpdateScript)] = value; } }
        public FilePath ScriptAsset { get { return this[nameof(ScriptAsset)].As<FilePath>(); } set { this["ScriptAsset"] = value; } }
        public bool bDeprecated { get { return this[nameof(bDeprecated)].Flag; } set { this[nameof(bDeprecated)].Flag = value; } }
        public Object DeprecationMessage { get { return this[nameof(DeprecationMessage)]; } set { this[nameof(DeprecationMessage)] = value; } }
        public bool bLocalSpace { get { return this[nameof(bLocalSpace)].Flag; } set { this[nameof(bLocalSpace)].Flag = value; } }
        public bool bDeterminism { get { return this[nameof(bDeterminism)].Flag; } set { this[nameof(bDeterminism)].Flag = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public bool bInterpolatedSpawning { get { return this[nameof(bInterpolatedSpawning)].Flag; } set { this[nameof(bInterpolatedSpawning)].Flag = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
        public ENiagaraEmitterCalculateBoundMode CalculateBoundsMode { get { return (ENiagaraEmitterCalculateBoundMode)this[nameof(CalculateBoundsMode)].GetValue<int>(); } set { this[nameof(CalculateBoundsMode)].SetValue<int>((int)value); } }
        public Box FixedBounds { get { return this[nameof(FixedBounds)].As<Box>(); } set { this["FixedBounds"] = value; } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public bool bCombineEventSpawn { get { return this[nameof(bCombineEventSpawn)].Flag; } set { this[nameof(bCombineEventSpawn)].Flag = value; } }
        public Array<NiagaraEventScriptProperties> EventHandlerScriptProps { get { return new Array<NiagaraEventScriptProperties>(this[nameof(EventHandlerScriptProps)].Address); } }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public NiagaraEmitterScalabilityOverrides ScalabilityOverrides { get { return this[nameof(ScalabilityOverrides)].As<NiagaraEmitterScalabilityOverrides>(); } set { this["ScalabilityOverrides"] = value; } }
        public bool bLimitDeltaTime { get { return this[nameof(bLimitDeltaTime)].Flag; } set { this[nameof(bLimitDeltaTime)].Flag = value; } }
        public int MaxGPUParticlesSpawnPerFrame { get { return this[nameof(MaxGPUParticlesSpawnPerFrame)].GetValue<int>(); } set { this[nameof(MaxGPUParticlesSpawnPerFrame)].SetValue<int>(value); } }
        public float MaxDeltaTimePerTick { get { return this[nameof(MaxDeltaTimePerTick)].GetValue<float>(); } set { this[nameof(MaxDeltaTimePerTick)].SetValue<float>(value); } }
        public EParticleAllocationMode AllocationMode { get { return (EParticleAllocationMode)this[nameof(AllocationMode)].GetValue<int>(); } set { this[nameof(AllocationMode)].SetValue<int>((int)value); } }
        public int PreAllocationCount { get { return this[nameof(PreAllocationCount)].GetValue<int>(); } set { this[nameof(PreAllocationCount)].SetValue<int>(value); } }
        public NiagaraEmitterScriptProperties UpdateScriptProps { get { return this[nameof(UpdateScriptProps)].As<NiagaraEmitterScriptProperties>(); } set { this["UpdateScriptProps"] = value; } }
        public NiagaraEmitterScriptProperties SpawnScriptProps { get { return this[nameof(SpawnScriptProps)].As<NiagaraEmitterScriptProperties>(); } set { this["SpawnScriptProps"] = value; } }
        public NiagaraParameterStore RendererBindings { get { return this[nameof(RendererBindings)].As<NiagaraParameterStore>(); } set { this["RendererBindings"] = value; } }
        public Array<NiagaraRendererProperties> RendererProperties { get { return new Array<NiagaraRendererProperties>(this[nameof(RendererProperties)].Address); } }
        public Array<NiagaraSimulationStageBase> SimulationStages { get { return new Array<NiagaraSimulationStageBase>(this[nameof(SimulationStages)].Address); } }
        public NiagaraScript GPUComputeScript { get { return this[nameof(GPUComputeScript)].As<NiagaraScript>(); } set { this["GPUComputeScript"] = value; } }
        public Array<Object> SharedEventGeneratorIds { get { return new Array<Object>(this[nameof(SharedEventGeneratorIds)].Address); } }
        public NiagaraEmitterScalabilitySettings CurrentScalabilitySettings { get { return this[nameof(CurrentScalabilitySettings)].As<NiagaraEmitterScalabilitySettings>(); } set { this["CurrentScalabilitySettings"] = value; } }
    }
    public class NiagaraParameterStore : Object
    {
        public NiagaraParameterStore(nint addr) : base(addr) { }
        public Object Owner { get { return this[nameof(Owner)]; } set { this[nameof(Owner)] = value; } }
        public Array<NiagaraVariableWithOffset> SortedParameterOffsets { get { return new Array<NiagaraVariableWithOffset>(this[nameof(SortedParameterOffsets)].Address); } }
        public Array<byte> ParameterData { get { return new Array<byte>(this[nameof(ParameterData)].Address); } }
        public Array<NiagaraDataInterface> DataInterfaces { get { return new Array<NiagaraDataInterface>(this[nameof(DataInterfaces)].Address); } }
        public Array<Object> UObjects { get { return new Array<Object>(this[nameof(UObjects)].Address); } }
        public Array<NiagaraPositionSource> OriginalPositionData { get { return new Array<NiagaraPositionSource>(this[nameof(OriginalPositionData)].Address); } }
    }
    public class NiagaraPositionSource : Object
    {
        public NiagaraPositionSource(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Vector Value { get { return this[nameof(Value)].As<Vector>(); } set { this["Value"] = value; } }
    }
    public class NiagaraVariableWithOffset : NiagaraVariableBase
    {
        public NiagaraVariableWithOffset(nint addr) : base(addr) { }
        public int Offset { get { return this[nameof(Offset)].GetValue<int>(); } set { this[nameof(Offset)].SetValue<int>(value); } }
        public NiagaraLwcStructConverter StructConverter { get { return this[nameof(StructConverter)].As<NiagaraLwcStructConverter>(); } set { this["StructConverter"] = value; } }
    }
    public class NiagaraLwcStructConverter : Object
    {
        public NiagaraLwcStructConverter(nint addr) : base(addr) { }
        public Array<NiagaraStructConversionStep> ConversionSteps { get { return new Array<NiagaraStructConversionStep>(this[nameof(ConversionSteps)].Address); } }
    }
    public class NiagaraStructConversionStep : Object
    {
        public NiagaraStructConversionStep(nint addr) : base(addr) { }
        public int SourceBytes { get { return this[nameof(SourceBytes)].GetValue<int>(); } set { this[nameof(SourceBytes)].SetValue<int>(value); } }
        public int SourceOffset { get { return this[nameof(SourceOffset)].GetValue<int>(); } set { this[nameof(SourceOffset)].SetValue<int>(value); } }
        public int SimulationBytes { get { return this[nameof(SimulationBytes)].GetValue<int>(); } set { this[nameof(SimulationBytes)].SetValue<int>(value); } }
        public int SimulationOffset { get { return this[nameof(SimulationOffset)].GetValue<int>(); } set { this[nameof(SimulationOffset)].SetValue<int>(value); } }
        public ENiagaraStructConversionType ConversionType { get { return (ENiagaraStructConversionType)this[nameof(ConversionType)].GetValue<int>(); } set { this[nameof(ConversionType)].SetValue<int>((int)value); } }
    }
    public class NiagaraAssetVersion : Object
    {
        public NiagaraAssetVersion(nint addr) : base(addr) { }
        public int MajorVersion { get { return this[nameof(MajorVersion)].GetValue<int>(); } set { this[nameof(MajorVersion)].SetValue<int>(value); } }
        public int MinorVersion { get { return this[nameof(MinorVersion)].GetValue<int>(); } set { this[nameof(MinorVersion)].SetValue<int>(value); } }
        public Guid VersionGuid { get { return this[nameof(VersionGuid)].As<Guid>(); } set { this["VersionGuid"] = value; } }
        public bool bIsVisibleInVersionSelector { get { return this[nameof(bIsVisibleInVersionSelector)].Flag; } set { this[nameof(bIsVisibleInVersionSelector)].Flag = value; } }
    }
    public class NiagaraEmitterHandle : Object
    {
        public NiagaraEmitterHandle(nint addr) : base(addr) { }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Object IdName { get { return this[nameof(IdName)]; } set { this[nameof(IdName)] = value; } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public NiagaraEmitter Instance { get { return this[nameof(Instance)].As<NiagaraEmitter>(); } set { this["Instance"] = value; } }
        public VersionedNiagaraEmitter VersionedInstance { get { return this[nameof(VersionedInstance)].As<VersionedNiagaraEmitter>(); } set { this["VersionedInstance"] = value; } }
    }
    public class VersionedNiagaraEmitter : Object
    {
        public VersionedNiagaraEmitter(nint addr) : base(addr) { }
        public NiagaraEmitter Emitter { get { return this[nameof(Emitter)].As<NiagaraEmitter>(); } set { this["Emitter"] = value; } }
        public Guid Version { get { return this[nameof(Version)].As<Guid>(); } set { this["Version"] = value; } }
    }
    public class NiagaraCollisionEventPayload : Object
    {
        public NiagaraCollisionEventPayload(nint addr) : base(addr) { }
        public Vector CollisionPos { get { return this[nameof(CollisionPos)].As<Vector>(); } set { this["CollisionPos"] = value; } }
        public Vector CollisionNormal { get { return this[nameof(CollisionNormal)].As<Vector>(); } set { this["CollisionNormal"] = value; } }
        public Vector CollisionVelocity { get { return this[nameof(CollisionVelocity)].As<Vector>(); } set { this["CollisionVelocity"] = value; } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int PhysicalMaterialIndex { get { return this[nameof(PhysicalMaterialIndex)].GetValue<int>(); } set { this[nameof(PhysicalMaterialIndex)].SetValue<int>(value); } }
    }
    public class NiagaraMeshMaterialOverride : Object
    {
        public NiagaraMeshMaterialOverride(nint addr) : base(addr) { }
        public MaterialInterface ExplicitMat { get { return this[nameof(ExplicitMat)].As<MaterialInterface>(); } set { this["ExplicitMat"] = value; } }
        public NiagaraUserParameterBinding UserParamBinding { get { return this[nameof(UserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["UserParamBinding"] = value; } }
    }
    public class NiagaraMeshRendererMeshProperties : Object
    {
        public NiagaraMeshRendererMeshProperties(nint addr) : base(addr) { }
        public StaticMesh Mesh { get { return this[nameof(Mesh)].As<StaticMesh>(); } set { this["Mesh"] = value; } }
        public NiagaraUserParameterBinding UserParamBinding { get { return this[nameof(UserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["UserParamBinding"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector PivotOffset { get { return this[nameof(PivotOffset)].As<Vector>(); } set { this["PivotOffset"] = value; } }
        public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace { get { return (ENiagaraMeshPivotOffsetSpace)this[nameof(PivotOffsetSpace)].GetValue<int>(); } set { this[nameof(PivotOffsetSpace)].SetValue<int>((int)value); } }
    }
    public class ParameterDefinitionsSubscription : Object
    {
        public ParameterDefinitionsSubscription(nint addr) : base(addr) { }
    }
    public class NiagaraParameters : Object
    {
        public NiagaraParameters(nint addr) : base(addr) { }
        public Array<NiagaraVariable> Parameters { get { return new Array<NiagaraVariable>(this[nameof(Parameters)].Address); } }
    }
    public class NiagaraBoundParameter : Object
    {
        public NiagaraBoundParameter(nint addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
        public int SrcOffset { get { return this[nameof(SrcOffset)].GetValue<int>(); } set { this[nameof(SrcOffset)].SetValue<int>(value); } }
        public int DestOffset { get { return this[nameof(DestOffset)].GetValue<int>(); } set { this[nameof(DestOffset)].SetValue<int>(value); } }
    }
    public class NiagaraPerfBaselineStats : Object
    {
        public NiagaraPerfBaselineStats(nint addr) : base(addr) { }
        public float PerInstanceAvg_GT { get { return this[nameof(PerInstanceAvg_GT)].GetValue<float>(); } set { this[nameof(PerInstanceAvg_GT)].SetValue<float>(value); } }
        public float PerInstanceAvg_RT { get { return this[nameof(PerInstanceAvg_RT)].GetValue<float>(); } set { this[nameof(PerInstanceAvg_RT)].SetValue<float>(value); } }
        public float PerInstanceMax_GT { get { return this[nameof(PerInstanceMax_GT)].GetValue<float>(); } set { this[nameof(PerInstanceMax_GT)].SetValue<float>(value); } }
        public float PerInstanceMax_RT { get { return this[nameof(PerInstanceMax_RT)].GetValue<float>(); } set { this[nameof(PerInstanceMax_RT)].SetValue<float>(value); } }
    }
    public class NiagaraPlatformSetConflictEntry : Object
    {
        public NiagaraPlatformSetConflictEntry(nint addr) : base(addr) { }
        public Object ProfileName { get { return this[nameof(ProfileName)]; } set { this[nameof(ProfileName)] = value; } }
        public int QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<int>(); } set { this[nameof(QualityLevelMask)].SetValue<int>(value); } }
    }
    public class NiagaraPlatformSetConflictInfo : Object
    {
        public NiagaraPlatformSetConflictInfo(nint addr) : base(addr) { }
        public int SetAIndex { get { return this[nameof(SetAIndex)].GetValue<int>(); } set { this[nameof(SetAIndex)].SetValue<int>(value); } }
        public int SetBIndex { get { return this[nameof(SetBIndex)].GetValue<int>(); } set { this[nameof(SetBIndex)].SetValue<int>(value); } }
        public Array<NiagaraPlatformSetConflictEntry> Conflicts { get { return new Array<NiagaraPlatformSetConflictEntry>(this[nameof(Conflicts)].Address); } }
    }
    public class NiagaraPlatformSetRedirect : Object
    {
        public NiagaraPlatformSetRedirect(nint addr) : base(addr) { }
        public Array<Object> ProfileNames { get { return new Array<Object>(this[nameof(ProfileNames)].Address); } }
        public ENiagaraDeviceProfileRedirectMode Mode { get { return (ENiagaraDeviceProfileRedirectMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public Object RedirectProfileName { get { return this[nameof(RedirectProfileName)]; } set { this[nameof(RedirectProfileName)] = value; } }
        public NiagaraPlatformSetCVarCondition CVarConditionEnabled { get { return this[nameof(CVarConditionEnabled)].As<NiagaraPlatformSetCVarCondition>(); } set { this["CVarConditionEnabled"] = value; } }
        public NiagaraPlatformSetCVarCondition CVarConditionDisabled { get { return this[nameof(CVarConditionDisabled)].As<NiagaraPlatformSetCVarCondition>(); } set { this["CVarConditionDisabled"] = value; } }
    }
    public class NiagaraRendererMaterialScalarParameter : Object
    {
        public NiagaraRendererMaterialScalarParameter(nint addr) : base(addr) { }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class NiagaraRendererMaterialVectorParameter : Object
    {
        public NiagaraRendererMaterialVectorParameter(nint addr) : base(addr) { }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public LinearColor Value { get { return this[nameof(Value)].As<LinearColor>(); } set { this["Value"] = value; } }
    }
    public class NiagaraRendererMaterialTextureParameter : Object
    {
        public NiagaraRendererMaterialTextureParameter(nint addr) : base(addr) { }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
    }
    public class NiagaraRendererMaterialParameters : Object
    {
        public NiagaraRendererMaterialParameters(nint addr) : base(addr) { }
        public Array<NiagaraMaterialAttributeBinding> AttributeBindings { get { return new Array<NiagaraMaterialAttributeBinding>(this[nameof(AttributeBindings)].Address); } }
        public Array<NiagaraRendererMaterialScalarParameter> ScalarParameters { get { return new Array<NiagaraRendererMaterialScalarParameter>(this[nameof(ScalarParameters)].Address); } }
        public Array<NiagaraRendererMaterialVectorParameter> VectorParameters { get { return new Array<NiagaraRendererMaterialVectorParameter>(this[nameof(VectorParameters)].Address); } }
        public Array<NiagaraRendererMaterialTextureParameter> TextureParameters { get { return new Array<NiagaraRendererMaterialTextureParameter>(this[nameof(TextureParameters)].Address); } }
    }
    public class NiagaraRibbonShapeCustomVertex : Object
    {
        public NiagaraRibbonShapeCustomVertex(nint addr) : base(addr) { }
        public Vector2f Position { get { return this[nameof(Position)].As<Vector2f>(); } set { this["Position"] = value; } }
        public Vector2f Normal { get { return this[nameof(Normal)].As<Vector2f>(); } set { this["Normal"] = value; } }
        public float TextureV { get { return this[nameof(TextureV)].GetValue<float>(); } set { this[nameof(TextureV)].SetValue<float>(value); } }
    }
    public class NiagaraRibbonUVSettings : Object
    {
        public NiagaraRibbonUVSettings(nint addr) : base(addr) { }
        public ENiagaraRibbonUVDistributionMode DistributionMode { get { return (ENiagaraRibbonUVDistributionMode)this[nameof(DistributionMode)].GetValue<int>(); } set { this[nameof(DistributionMode)].SetValue<int>((int)value); } }
        public ENiagaraRibbonUVEdgeMode LeadingEdgeMode { get { return (ENiagaraRibbonUVEdgeMode)this[nameof(LeadingEdgeMode)].GetValue<int>(); } set { this[nameof(LeadingEdgeMode)].SetValue<int>((int)value); } }
        public ENiagaraRibbonUVEdgeMode TrailingEdgeMode { get { return (ENiagaraRibbonUVEdgeMode)this[nameof(TrailingEdgeMode)].GetValue<int>(); } set { this[nameof(TrailingEdgeMode)].SetValue<int>((int)value); } }
        public float TilingLength { get { return this[nameof(TilingLength)].GetValue<float>(); } set { this[nameof(TilingLength)].SetValue<float>(value); } }
        public Vector2D Offset { get { return this[nameof(Offset)].As<Vector2D>(); } set { this["Offset"] = value; } }
        public Vector2D Scale { get { return this[nameof(Scale)].As<Vector2D>(); } set { this["Scale"] = value; } }
        public bool bEnablePerParticleUOverride { get { return this[nameof(bEnablePerParticleUOverride)].Flag; } set { this[nameof(bEnablePerParticleUOverride)].Flag = value; } }
        public bool bEnablePerParticleVRangeOverride { get { return this[nameof(bEnablePerParticleVRangeOverride)].Flag; } set { this[nameof(bEnablePerParticleVRangeOverride)].Flag = value; } }
    }
    public class NiagaraScalabilityManager : Object
    {
        public NiagaraScalabilityManager(nint addr) : base(addr) { }
        public NiagaraEffectType EffectType { get { return this[nameof(EffectType)].As<NiagaraEffectType>(); } set { this["EffectType"] = value; } }
        public Array<NiagaraComponent> ManagedComponents { get { return new Array<NiagaraComponent>(this[nameof(ManagedComponents)].Address); } }
    }
    public class NiagaraModuleDependency : Object
    {
        public NiagaraModuleDependency(nint addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public ENiagaraModuleDependencyType Type { get { return (ENiagaraModuleDependencyType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ENiagaraModuleDependencyScriptConstraint ScriptConstraint { get { return (ENiagaraModuleDependencyScriptConstraint)this[nameof(ScriptConstraint)].GetValue<int>(); } set { this[nameof(ScriptConstraint)].SetValue<int>((int)value); } }
        public Object RequiredVersion { get { return this[nameof(RequiredVersion)]; } set { this[nameof(RequiredVersion)] = value; } }
        public int OnlyEvaluateInScriptUsage { get { return this[nameof(OnlyEvaluateInScriptUsage)].GetValue<int>(); } set { this[nameof(OnlyEvaluateInScriptUsage)].SetValue<int>(value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
    }
    public class NiagaraCompilerTag : Object
    {
        public NiagaraCompilerTag(nint addr) : base(addr) { }
        public NiagaraVariable Variable { get { return this[nameof(Variable)].As<NiagaraVariable>(); } set { this["Variable"] = value; } }
        public Object StringValue { get { return this[nameof(StringValue)]; } set { this[nameof(StringValue)] = value; } }
    }
    public class NiagaraVMExecutableDataId : Object
    {
        public NiagaraVMExecutableDataId(nint addr) : base(addr) { }
        public Guid CompilerVersionID { get { return this[nameof(CompilerVersionID)].As<Guid>(); } set { this["CompilerVersionID"] = value; } }
        public ENiagaraScriptUsage ScriptUsageType { get { return (ENiagaraScriptUsage)this[nameof(ScriptUsageType)].GetValue<int>(); } set { this[nameof(ScriptUsageType)].SetValue<int>((int)value); } }
        public Guid ScriptUsageTypeID { get { return this[nameof(ScriptUsageTypeID)].As<Guid>(); } set { this["ScriptUsageTypeID"] = value; } }
        public bool bUsesRapidIterationParams { get { return this[nameof(bUsesRapidIterationParams)].Flag; } set { this[nameof(bUsesRapidIterationParams)].Flag = value; } }
        public bool bDisableDebugSwitches { get { return this[nameof(bDisableDebugSwitches)].Flag; } set { this[nameof(bDisableDebugSwitches)].Flag = value; } }
        public bool bInterpolatedSpawn { get { return this[nameof(bInterpolatedSpawn)].Flag; } set { this[nameof(bInterpolatedSpawn)].Flag = value; } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public Guid BaseScriptID { get { return this[nameof(BaseScriptID)].As<Guid>(); } set { this["BaseScriptID"] = value; } }
        public NiagaraCompileHash BaseScriptCompileHash { get { return this[nameof(BaseScriptCompileHash)].As<NiagaraCompileHash>(); } set { this["BaseScriptCompileHash"] = value; } }
        public Guid ScriptVersionID { get { return this[nameof(ScriptVersionID)].As<Guid>(); } set { this["ScriptVersionID"] = value; } }
    }
    public class NiagaraVMExecutableByteCode : Object
    {
        public NiagaraVMExecutableByteCode(nint addr) : base(addr) { }
        public Array<byte> Data { get { return new Array<byte>(this[nameof(Data)].Address); } }
        public int UncompressedSize { get { return this[nameof(UncompressedSize)].GetValue<int>(); } set { this[nameof(UncompressedSize)].SetValue<int>(value); } }
    }
    public class NiagaraVMExecutableData : Object
    {
        public NiagaraVMExecutableData(nint addr) : base(addr) { }
        public NiagaraVMExecutableByteCode ByteCode { get { return this[nameof(ByteCode)].As<NiagaraVMExecutableByteCode>(); } set { this["ByteCode"] = value; } }
        public NiagaraVMExecutableByteCode OptimizedByteCode { get { return this[nameof(OptimizedByteCode)].As<NiagaraVMExecutableByteCode>(); } set { this["OptimizedByteCode"] = value; } }
        public int NumTempRegisters { get { return this[nameof(NumTempRegisters)].GetValue<int>(); } set { this[nameof(NumTempRegisters)].SetValue<int>(value); } }
        public int NumUserPtrs { get { return this[nameof(NumUserPtrs)].GetValue<int>(); } set { this[nameof(NumUserPtrs)].SetValue<int>(value); } }
        public Array<NiagaraCompilerTag> CompileTags { get { return new Array<NiagaraCompilerTag>(this[nameof(CompileTags)].Address); } }
        public Array<byte> ScriptLiterals { get { return new Array<byte>(this[nameof(ScriptLiterals)].Address); } }
        public Array<NiagaraVariable> Attributes { get { return new Array<NiagaraVariable>(this[nameof(Attributes)].Address); } }
        public NiagaraScriptDataUsageInfo DataUsage { get { return this[nameof(DataUsage)].As<NiagaraScriptDataUsageInfo>(); } set { this["DataUsage"] = value; } }
        public Array<NiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo { get { return new Array<NiagaraScriptDataInterfaceCompileInfo>(this[nameof(DataInterfaceInfo)].Address); } }
        public Array<VMExternalFunctionBindingInfo> CalledVMExternalFunctions { get { return new Array<VMExternalFunctionBindingInfo>(this[nameof(CalledVMExternalFunctions)].Address); } }
        public Array<NiagaraDataSetID> ReadDataSets { get { return new Array<NiagaraDataSetID>(this[nameof(ReadDataSets)].Address); } }
        public Array<NiagaraDataSetProperties> WriteDataSets { get { return new Array<NiagaraDataSetProperties>(this[nameof(WriteDataSets)].Address); } }
        public Array<NiagaraStatScope> StatScopes { get { return new Array<NiagaraStatScope>(this[nameof(StatScopes)].Address); } }
        public NiagaraShaderScriptParametersMetadata ShaderScriptParametersMetadata { get { return this[nameof(ShaderScriptParametersMetadata)].As<NiagaraShaderScriptParametersMetadata>(); } set { this["ShaderScriptParametersMetadata"] = value; } }
        public ENiagaraScriptCompileStatus LastCompileStatus { get { return (ENiagaraScriptCompileStatus)this[nameof(LastCompileStatus)].GetValue<int>(); } set { this[nameof(LastCompileStatus)].SetValue<int>((int)value); } }
        public Array<SimulationStageMetaData> SimulationStageMetaData { get { return new Array<SimulationStageMetaData>(this[nameof(SimulationStageMetaData)].Address); } }
        public Array<byte> ExperimentalContextData { get { return new Array<byte>(this[nameof(ExperimentalContextData)].Address); } }
        public bool bReadsSignificanceIndex { get { return this[nameof(bReadsSignificanceIndex)].Flag; } set { this[nameof(bReadsSignificanceIndex)].Flag = value; } }
        public bool bNeedsGPUContextInit { get { return this[nameof(bNeedsGPUContextInit)].Flag; } set { this[nameof(bNeedsGPUContextInit)].Flag = value; } }
    }
    public class VersionedNiagaraScriptData : Object
    {
        public VersionedNiagaraScriptData(nint addr) : base(addr) { }
    }
    public class NiagaraScriptExecutionPaddingInfo : Object
    {
        public NiagaraScriptExecutionPaddingInfo(nint addr) : base(addr) { }
        public ushort SrcOffset { get { return this[nameof(SrcOffset)].GetValue<ushort>(); } set { this[nameof(SrcOffset)].SetValue<ushort>(value); } }
        public ushort DestOffset { get { return this[nameof(DestOffset)].GetValue<ushort>(); } set { this[nameof(DestOffset)].SetValue<ushort>(value); } }
        public ushort SrcSize { get { return this[nameof(SrcSize)].GetValue<ushort>(); } set { this[nameof(SrcSize)].SetValue<ushort>(value); } }
        public ushort DestSize { get { return this[nameof(DestSize)].GetValue<ushort>(); } set { this[nameof(DestSize)].SetValue<ushort>(value); } }
    }
    public class NiagaraScriptExecutionParameterStore : NiagaraParameterStore
    {
        public NiagaraScriptExecutionParameterStore(nint addr) : base(addr) { }
        public int ParameterSize { get { return this[nameof(ParameterSize)].GetValue<int>(); } set { this[nameof(ParameterSize)].SetValue<int>(value); } }
        public uint PaddedParameterSize { get { return this[nameof(PaddedParameterSize)].GetValue<uint>(); } set { this[nameof(PaddedParameterSize)].SetValue<uint>(value); } }
        public Array<NiagaraScriptExecutionPaddingInfo> PaddingInfo { get { return new Array<NiagaraScriptExecutionPaddingInfo>(this[nameof(PaddingInfo)].Address); } }
        public bool bInitialized { get { return this[nameof(bInitialized)].Flag; } set { this[nameof(bInitialized)].Flag = value; } }
    }
    public class NiagaraScriptInstanceParameterStore : NiagaraParameterStore
    {
        public NiagaraScriptInstanceParameterStore(nint addr) : base(addr) { }
    }
    public class NiagaraScriptHighlight : Object
    {
        public NiagaraScriptHighlight(nint addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
    }
    public class NiagaraSimCacheDataBuffers : Object
    {
        public NiagaraSimCacheDataBuffers(nint addr) : base(addr) { }
        public uint NumInstances { get { return this[nameof(NumInstances)].GetValue<uint>(); } set { this[nameof(NumInstances)].SetValue<uint>(value); } }
        //public Array<byte> FloatData { get { return new Array<byte>(this[nameof(FloatData)].Address); } }
        public Array<byte> HalfData { get { return new Array<byte>(this[nameof(HalfData)].Address); } }
        public Array<byte> Int32Data { get { return new Array<byte>(this[nameof(Int32Data)].Address); } }
        public Array<int> IDToIndexTable { get { return new Array<int>(this[nameof(IDToIndexTable)].Address); } }
        public uint IDAcquireTag { get { return this[nameof(IDAcquireTag)].GetValue<uint>(); } set { this[nameof(IDAcquireTag)].SetValue<uint>(value); } }
    }
    public class NiagaraSimCacheEmitterFrame : Object
    {
        public NiagaraSimCacheEmitterFrame(nint addr) : base(addr) { }
        public Box LocalBounds { get { return this[nameof(LocalBounds)].As<Box>(); } set { this["LocalBounds"] = value; } }
        public int TotalSpawnedParticles { get { return this[nameof(TotalSpawnedParticles)].GetValue<int>(); } set { this[nameof(TotalSpawnedParticles)].SetValue<int>(value); } }
        public NiagaraSimCacheDataBuffers ParticleDataBuffers { get { return this[nameof(ParticleDataBuffers)].As<NiagaraSimCacheDataBuffers>(); } set { this["ParticleDataBuffers"] = value; } }
    }
    public class NiagaraSimCacheSystemFrame : Object
    {
        public NiagaraSimCacheSystemFrame(nint addr) : base(addr) { }
        public Box LocalBounds { get { return this[nameof(LocalBounds)].As<Box>(); } set { this["LocalBounds"] = value; } }
        public NiagaraSimCacheDataBuffers SystemDataBuffers { get { return this[nameof(SystemDataBuffers)].As<NiagaraSimCacheDataBuffers>(); } set { this["SystemDataBuffers"] = value; } }
    }
    public class NiagaraSimCacheFrame : Object
    {
        public NiagaraSimCacheFrame(nint addr) : base(addr) { }
        public Transform LocalToWorld { get { return this[nameof(LocalToWorld)].As<Transform>(); } set { this["LocalToWorld"] = value; } }
        public Vector3f LWCTile { get { return this[nameof(LWCTile)].As<Vector3f>(); } set { this["LWCTile"] = value; } }
        public NiagaraSimCacheSystemFrame SystemData { get { return this[nameof(SystemData)].As<NiagaraSimCacheSystemFrame>(); } set { this["SystemData"] = value; } }
        public Array<NiagaraSimCacheEmitterFrame> EmitterData { get { return new Array<NiagaraSimCacheEmitterFrame>(this[nameof(EmitterData)].Address); } }
    }
    public class NiagaraSimCacheVariable : Object
    {
        public NiagaraSimCacheVariable(nint addr) : base(addr) { }
        public NiagaraVariableBase Variable { get { return this[nameof(Variable)].As<NiagaraVariableBase>(); } set { this["Variable"] = value; } }
        //public ushort FloatOffset { get { return this[nameof(FloatOffset)].GetValue<ushort>(); } set { this[nameof(FloatOffset)].SetValue<ushort>(value); } }
        //public ushort FloatCount { get { return this[nameof(FloatCount)].GetValue<ushort>(); } set { this[nameof(FloatCount)].SetValue<ushort>(value); } }
        public ushort HalfOffset { get { return this[nameof(HalfOffset)].GetValue<ushort>(); } set { this[nameof(HalfOffset)].SetValue<ushort>(value); } }
        public ushort HalfCount { get { return this[nameof(HalfCount)].GetValue<ushort>(); } set { this[nameof(HalfCount)].SetValue<ushort>(value); } }
        public ushort Int32Offset { get { return this[nameof(Int32Offset)].GetValue<ushort>(); } set { this[nameof(Int32Offset)].SetValue<ushort>(value); } }
        public ushort Int32Count { get { return this[nameof(Int32Count)].GetValue<ushort>(); } set { this[nameof(Int32Count)].SetValue<ushort>(value); } }
    }
    public class NiagaraSimCacheDataBuffersLayout : Object
    {
        public NiagaraSimCacheDataBuffersLayout(nint addr) : base(addr) { }
        public Object LayoutName { get { return this[nameof(LayoutName)]; } set { this[nameof(LayoutName)] = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
        public Array<NiagaraSimCacheVariable> Variables { get { return new Array<NiagaraSimCacheVariable>(this[nameof(Variables)].Address); } }
        //public ushort FloatCount { get { return this[nameof(FloatCount)].GetValue<ushort>(); } set { this[nameof(FloatCount)].SetValue<ushort>(value); } }
        public ushort HalfCount { get { return this[nameof(HalfCount)].GetValue<ushort>(); } set { this[nameof(HalfCount)].SetValue<ushort>(value); } }
        public ushort Int32Count { get { return this[nameof(Int32Count)].GetValue<ushort>(); } set { this[nameof(Int32Count)].SetValue<ushort>(value); } }
        public bool bLocalSpace { get { return this[nameof(bLocalSpace)].Flag; } set { this[nameof(bLocalSpace)].Flag = value; } }
        public Array<Object> RebaseVariableNames { get { return new Array<Object>(this[nameof(RebaseVariableNames)].Address); } }
    }
    public class NiagaraSimCacheLayout : Object
    {
        public NiagaraSimCacheLayout(nint addr) : base(addr) { }
        public NiagaraSimCacheDataBuffersLayout SystemLayout { get { return this[nameof(SystemLayout)].As<NiagaraSimCacheDataBuffersLayout>(); } set { this["SystemLayout"] = value; } }
        public Array<NiagaraSimCacheDataBuffersLayout> EmitterLayouts { get { return new Array<NiagaraSimCacheDataBuffersLayout>(this[nameof(EmitterLayouts)].Address); } }
    }
    public class NiagaraEmitterCompiledData : Object
    {
        public NiagaraEmitterCompiledData(nint addr) : base(addr) { }
        public Array<Object> SpawnAttributes { get { return new Array<Object>(this[nameof(SpawnAttributes)].Address); } }
        public NiagaraVariable EmitterSpawnIntervalVar { get { return this[nameof(EmitterSpawnIntervalVar)].As<NiagaraVariable>(); } set { this["EmitterSpawnIntervalVar"] = value; } }
        public NiagaraVariable EmitterInterpSpawnStartDTVar { get { return this[nameof(EmitterInterpSpawnStartDTVar)].As<NiagaraVariable>(); } set { this["EmitterInterpSpawnStartDTVar"] = value; } }
        public NiagaraVariable EmitterSpawnGroupVar { get { return this[nameof(EmitterSpawnGroupVar)].As<NiagaraVariable>(); } set { this["EmitterSpawnGroupVar"] = value; } }
        public NiagaraVariable EmitterAgeVar { get { return this[nameof(EmitterAgeVar)].As<NiagaraVariable>(); } set { this["EmitterAgeVar"] = value; } }
        public NiagaraVariable EmitterRandomSeedVar { get { return this[nameof(EmitterRandomSeedVar)].As<NiagaraVariable>(); } set { this["EmitterRandomSeedVar"] = value; } }
        public NiagaraVariable EmitterInstanceSeedVar { get { return this[nameof(EmitterInstanceSeedVar)].As<NiagaraVariable>(); } set { this["EmitterInstanceSeedVar"] = value; } }
        public NiagaraVariable EmitterTotalSpawnedParticlesVar { get { return this[nameof(EmitterTotalSpawnedParticlesVar)].As<NiagaraVariable>(); } set { this["EmitterTotalSpawnedParticlesVar"] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
    }
    public class NiagaraParameterDataSetBinding : Object
    {
        public NiagaraParameterDataSetBinding(nint addr) : base(addr) { }
        public int ParameterOffset { get { return this[nameof(ParameterOffset)].GetValue<int>(); } set { this[nameof(ParameterOffset)].SetValue<int>(value); } }
        public int DataSetComponentOffset { get { return this[nameof(DataSetComponentOffset)].GetValue<int>(); } set { this[nameof(DataSetComponentOffset)].SetValue<int>(value); } }
    }
    public class NiagaraParameterDataSetBindingCollection : Object
    {
        public NiagaraParameterDataSetBindingCollection(nint addr) : base(addr) { }
        //public Array<NiagaraParameterDataSetBinding> FloatOffsets { get { return new Array<NiagaraParameterDataSetBinding>(this[nameof(FloatOffsets)].Address); } }
        public Array<NiagaraParameterDataSetBinding> Int32Offsets { get { return new Array<NiagaraParameterDataSetBinding>(this[nameof(Int32Offsets)].Address); } }
    }
    public class NiagaraSystemCompiledData : Object
    {
        public NiagaraSystemCompiledData(nint addr) : base(addr) { }
        public NiagaraParameterStore InstanceParamStore { get { return this[nameof(InstanceParamStore)].As<NiagaraParameterStore>(); } set { this["InstanceParamStore"] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
        public NiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData { get { return this[nameof(SpawnInstanceParamsDataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["SpawnInstanceParamsDataSetCompiledData"] = value; } }
        public NiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData { get { return this[nameof(UpdateInstanceParamsDataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["UpdateInstanceParamsDataSetCompiledData"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding { get { return this[nameof(SpawnInstanceGlobalBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceGlobalBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding { get { return this[nameof(SpawnInstanceSystemBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceSystemBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding { get { return this[nameof(SpawnInstanceOwnerBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceOwnerBinding"] = value; } }
        public Array<NiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings { get { return new Array<NiagaraParameterDataSetBindingCollection>(this[nameof(SpawnInstanceEmitterBindings)].Address); } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding { get { return this[nameof(UpdateInstanceGlobalBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceGlobalBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding { get { return this[nameof(UpdateInstanceSystemBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceSystemBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding { get { return this[nameof(UpdateInstanceOwnerBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceOwnerBinding"] = value; } }
        public Array<NiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings { get { return new Array<NiagaraParameterDataSetBindingCollection>(this[nameof(UpdateInstanceEmitterBindings)].Address); } }
    }
    public class NiagaraSystemCompileRequest : Object
    {
        public NiagaraSystemCompileRequest(nint addr) : base(addr) { }
        public Array<Object> RootObjects { get { return new Array<Object>(this[nameof(RootObjects)].Address); } }
    }
    public class NiagaraWildcard : Object
    {
        public NiagaraWildcard(nint addr) : base(addr) { }
    }
    public class NiagaraFloat : Object
    {
        public NiagaraFloat(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class NiagaraInt32 : Object
    {
        public NiagaraInt32(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class NiagaraBool : Object
    {
        public NiagaraBool(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class NiagaraPosition : Vector3f
    {
        public NiagaraPosition(nint addr) : base(addr) { }
    }
    public class NiagaraHalf : Object
    {
        public NiagaraHalf(nint addr) : base(addr) { }
        public ushort Value { get { return this[nameof(Value)].GetValue<ushort>(); } set { this[nameof(Value)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalfVector2 : Object
    {
        public NiagaraHalfVector2(nint addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalfVector3 : Object
    {
        public NiagaraHalfVector3(nint addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
        public ushort Z { get { return this[nameof(Z)].GetValue<ushort>(); } set { this[nameof(Z)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalfVector4 : Object
    {
        public NiagaraHalfVector4(nint addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
        public ushort Z { get { return this[nameof(Z)].GetValue<ushort>(); } set { this[nameof(Z)].SetValue<ushort>(value); } }
        public ushort W { get { return this[nameof(W)].GetValue<ushort>(); } set { this[nameof(W)].SetValue<ushort>(value); } }
    }
    public class NiagaraNumeric : Object
    {
        public NiagaraNumeric(nint addr) : base(addr) { }
    }
    public class NiagaraParameterMap : Object
    {
        public NiagaraParameterMap(nint addr) : base(addr) { }
    }
    public class NiagaraMatrix : Object
    {
        public NiagaraMatrix(nint addr) : base(addr) { }
        public Vector4f Row0 { get { return this[nameof(Row0)].As<Vector4f>(); } set { this["Row0"] = value; } }
        public Vector4f Row1 { get { return this[nameof(Row1)].As<Vector4f>(); } set { this["Row1"] = value; } }
        public Vector4f Row2 { get { return this[nameof(Row2)].As<Vector4f>(); } set { this["Row2"] = value; } }
        public Vector4f Row3 { get { return this[nameof(Row3)].As<Vector4f>(); } set { this["Row3"] = value; } }
    }
    public class NiagaraSpawnInfo : Object
    {
        public NiagaraSpawnInfo(nint addr) : base(addr) { }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public float InterpStartDt { get { return this[nameof(InterpStartDt)].GetValue<float>(); } set { this[nameof(InterpStartDt)].SetValue<float>(value); } }
        public float IntervalDt { get { return this[nameof(IntervalDt)].GetValue<float>(); } set { this[nameof(IntervalDt)].SetValue<float>(value); } }
        public int SpawnGroup { get { return this[nameof(SpawnGroup)].GetValue<int>(); } set { this[nameof(SpawnGroup)].SetValue<int>(value); } }
    }
    public class NiagaraID : Object
    {
        public NiagaraID(nint addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public int AcquireTag { get { return this[nameof(AcquireTag)].GetValue<int>(); } set { this[nameof(AcquireTag)].SetValue<int>(value); } }
    }
    public class NiagaraRandInfo : Object
    {
        public NiagaraRandInfo(nint addr) : base(addr) { }
        public int Seed1 { get { return this[nameof(Seed1)].GetValue<int>(); } set { this[nameof(Seed1)].SetValue<int>(value); } }
        public int Seed2 { get { return this[nameof(Seed2)].GetValue<int>(); } set { this[nameof(Seed2)].SetValue<int>(value); } }
        public int Seed3 { get { return this[nameof(Seed3)].GetValue<int>(); } set { this[nameof(Seed3)].SetValue<int>(value); } }
    }
    public class NiagaraCompileHashVisitorDebugInfo : Object
    {
        public NiagaraCompileHashVisitorDebugInfo(nint addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public Array<Object> PropertyKeys { get { return new Array<Object>(this[nameof(PropertyKeys)].Address); } }
        public Array<Object> PropertyValues { get { return new Array<Object>(this[nameof(PropertyValues)].Address); } }
    }
    public class NiagaraInputConditionMetadata : Object
    {
        public NiagaraInputConditionMetadata(nint addr) : base(addr) { }
        public Object InputName { get { return this[nameof(InputName)]; } set { this[nameof(InputName)] = value; } }
        public Array<Object> TargetValues { get { return new Array<Object>(this[nameof(TargetValues)].Address); } }
    }
    public class NiagaraEnumParameterMetaData : Object
    {
        public NiagaraEnumParameterMetaData(nint addr) : base(addr) { }
        public Object OverrideName { get { return this[nameof(OverrideName)]; } set { this[nameof(OverrideName)] = value; } }
        public Texture2D IconOverride { get { return this[nameof(IconOverride)].As<Texture2D>(); } set { this["IconOverride"] = value; } }
        public bool bUseColorOverride { get { return this[nameof(bUseColorOverride)].Flag; } set { this[nameof(bUseColorOverride)].Flag = value; } }
        public LinearColor ColorOverride { get { return this[nameof(ColorOverride)].As<LinearColor>(); } set { this["ColorOverride"] = value; } }
    }
    public class NiagaraBoolParameterMetaData : Object
    {
        public NiagaraBoolParameterMetaData(nint addr) : base(addr) { }
        public ENiagaraBoolDisplayMode DisplayMode { get { return (ENiagaraBoolDisplayMode)this[nameof(DisplayMode)].GetValue<int>(); } set { this[nameof(DisplayMode)].SetValue<int>((int)value); } }
        public Object OverrideNameTrue { get { return this[nameof(OverrideNameTrue)]; } set { this[nameof(OverrideNameTrue)] = value; } }
        public Object OverrideNameFalse { get { return this[nameof(OverrideNameFalse)]; } set { this[nameof(OverrideNameFalse)] = value; } }
        public Texture2D IconOverrideTrue { get { return this[nameof(IconOverrideTrue)].As<Texture2D>(); } set { this["IconOverrideTrue"] = value; } }
        public Texture2D IconOverrideFalse { get { return this[nameof(IconOverrideFalse)].As<Texture2D>(); } set { this["IconOverrideFalse"] = value; } }
    }
    public class NiagaraVariableMetaData : Object
    {
        public NiagaraVariableMetaData(nint addr) : base(addr) { }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object CategoryName { get { return this[nameof(CategoryName)]; } set { this[nameof(CategoryName)] = value; } }
        public bool bAdvancedDisplay { get { return this[nameof(bAdvancedDisplay)].Flag; } set { this[nameof(bAdvancedDisplay)].Flag = value; } }
        public bool bDisplayInOverviewStack { get { return this[nameof(bDisplayInOverviewStack)].Flag; } set { this[nameof(bDisplayInOverviewStack)].Flag = value; } }
        public int InlineParameterSortPriority { get { return this[nameof(InlineParameterSortPriority)].GetValue<int>(); } set { this[nameof(InlineParameterSortPriority)].SetValue<int>(value); } }
        public bool bOverrideColor { get { return this[nameof(bOverrideColor)].Flag; } set { this[nameof(bOverrideColor)].Flag = value; } }
        public LinearColor InlineParameterColorOverride { get { return this[nameof(InlineParameterColorOverride)].As<LinearColor>(); } set { this["InlineParameterColorOverride"] = value; } }
        public Array<NiagaraEnumParameterMetaData> InlineParameterEnumOverrides { get { return new Array<NiagaraEnumParameterMetaData>(this[nameof(InlineParameterEnumOverrides)].Address); } }
        public bool bEnableBoolOverride { get { return this[nameof(bEnableBoolOverride)].Flag; } set { this[nameof(bEnableBoolOverride)].Flag = value; } }
        public NiagaraBoolParameterMetaData InlineParameterBoolOverride { get { return this[nameof(InlineParameterBoolOverride)].As<NiagaraBoolParameterMetaData>(); } set { this["InlineParameterBoolOverride"] = value; } }
        public int EditorSortPriority { get { return this[nameof(EditorSortPriority)].GetValue<int>(); } set { this[nameof(EditorSortPriority)].SetValue<int>(value); } }
        public bool bInlineEditConditionToggle { get { return this[nameof(bInlineEditConditionToggle)].Flag; } set { this[nameof(bInlineEditConditionToggle)].Flag = value; } }
        public NiagaraInputConditionMetadata EditCondition { get { return this[nameof(EditCondition)].As<NiagaraInputConditionMetadata>(); } set { this["EditCondition"] = value; } }
        public NiagaraInputConditionMetadata VisibleCondition { get { return this[nameof(VisibleCondition)].As<NiagaraInputConditionMetadata>(); } set { this["VisibleCondition"] = value; } }
        public Object PropertyMetaData { get { return this[nameof(PropertyMetaData)]; } set { this[nameof(PropertyMetaData)] = value; } }
        public Object ParentAttribute { get { return this[nameof(ParentAttribute)]; } set { this[nameof(ParentAttribute)] = value; } }
        public Array<Object> AlternateAliases { get { return new Array<Object>(this[nameof(AlternateAliases)].Address); } }
        public Guid VariableGuid { get { return this[nameof(VariableGuid)].As<Guid>(); } set { this["VariableGuid"] = value; } }
        public bool bIsStaticSwitch { get { return this[nameof(bIsStaticSwitch)].Flag; } set { this[nameof(bIsStaticSwitch)].Flag = value; } }
        public int StaticSwitchDefaultValue { get { return this[nameof(StaticSwitchDefaultValue)].GetValue<int>(); } set { this[nameof(StaticSwitchDefaultValue)].SetValue<int>(value); } }
    }
    public class NiagaraUserRedirectionParameterStore : NiagaraParameterStore
    {
        public NiagaraUserRedirectionParameterStore(nint addr) : base(addr) { }
        public Object UserParameterRedirects { get { return this[nameof(UserParameterRedirects)]; } set { this[nameof(UserParameterRedirects)] = value; } }
    }
    public class NiagaraVariant : Object
    {
        public NiagaraVariant(nint addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)].As<Object>(); } set { this["Object"] = value; } }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
        public Array<byte> Bytes { get { return new Array<byte>(this[nameof(Bytes)].Address); } }
        public ENiagaraVariantMode CurrentMode { get { return (ENiagaraVariantMode)this[nameof(CurrentMode)].GetValue<int>(); } set { this[nameof(CurrentMode)].SetValue<int>((int)value); } }
    }
    public class NiagaraWorldManagerTickFunction : TickFunction
    {
        public NiagaraWorldManagerTickFunction(nint addr) : base(addr) { }
    }
}
