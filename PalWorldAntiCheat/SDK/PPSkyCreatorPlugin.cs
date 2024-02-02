using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.NiagaraSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.PPSkyCreatorPluginSDK
{
    public class PPSkyCreator : Actor
    {
        public PPSkyCreator(nint addr) : base(addr) { }
        public SceneComponent Root { get { return this[nameof(Root)].As<SceneComponent>(); } set { this["Root"] = value; } }
        public BillboardComponent Billboard { get { return this[nameof(Billboard)].As<BillboardComponent>(); } set { this["Billboard"] = value; } }
        public StaticMeshComponent Compass { get { return this[nameof(Compass)].As<StaticMeshComponent>(); } set { this["Compass"] = value; } }
        public SkyAtmosphereComponent SkyAtmosphere { get { return this[nameof(SkyAtmosphere)].As<SkyAtmosphereComponent>(); } set { this["SkyAtmosphere"] = value; } }
        public VolumetricCloudComponent VolumetricCloud { get { return this[nameof(VolumetricCloud)].As<VolumetricCloudComponent>(); } set { this["VolumetricCloud"] = value; } }
        public SkyLightComponent SkyLight { get { return this[nameof(SkyLight)].As<SkyLightComponent>(); } set { this["SkyLight"] = value; } }
        public DirectionalLightComponent SunLight { get { return this[nameof(SunLight)].As<DirectionalLightComponent>(); } set { this["SunLight"] = value; } }
        public DirectionalLightComponent MoonLight { get { return this[nameof(MoonLight)].As<DirectionalLightComponent>(); } set { this["MoonLight"] = value; } }
        public ExponentialHeightFogComponent ExponentialHeightFog { get { return this[nameof(ExponentialHeightFog)].As<ExponentialHeightFogComponent>(); } set { this["ExponentialHeightFog"] = value; } }
        public PostProcessComponent PostProcess { get { return this[nameof(PostProcess)].As<PostProcessComponent>(); } set { this["PostProcess"] = value; } }
        public StaticMeshComponent StarMap { get { return this[nameof(StarMap)].As<StaticMeshComponent>(); } set { this["StarMap"] = value; } }
        public StaticMeshComponent SunSphere { get { return this[nameof(SunSphere)].As<StaticMeshComponent>(); } set { this["SunSphere"] = value; } }
        public StaticMeshComponent MoonSphere { get { return this[nameof(MoonSphere)].As<StaticMeshComponent>(); } set { this["MoonSphere"] = value; } }
        public SceneCaptureComponent2D OcclusionCapture { get { return this[nameof(OcclusionCapture)].As<SceneCaptureComponent2D>(); } set { this["OcclusionCapture"] = value; } }
        public NiagaraComponent WeatherFX { get { return this[nameof(WeatherFX)].As<NiagaraComponent>(); } set { this["WeatherFX"] = value; } }
        public StaticMeshComponent SkySphere { get { return this[nameof(SkySphere)].As<StaticMeshComponent>(); } set { this["SkySphere"] = value; } }
        public MaterialInterface SkySphereMaterial { get { return this[nameof(SkySphereMaterial)].As<MaterialInterface>(); } set { this["SkySphereMaterial"] = value; } }
        public MaterialInstanceDynamic SkySphereMID { get { return this[nameof(SkySphereMID)].As<MaterialInstanceDynamic>(); } set { this["SkySphereMID"] = value; } }
        public bool bUseEditorTimeOfDay { get { return this[nameof(bUseEditorTimeOfDay)].Flag; } set { this[nameof(bUseEditorTimeOfDay)].Flag = value; } }
        public float EditorTimeOfDay { get { return this[nameof(EditorTimeOfDay)].GetValue<float>(); } set { this[nameof(EditorTimeOfDay)].SetValue<float>(value); } }
        public bool bUseEditorWeatherSettings { get { return this[nameof(bUseEditorWeatherSettings)].Flag; } set { this[nameof(bUseEditorWeatherSettings)].Flag = value; } }
        public byte EditorWeatherType { get { return this[nameof(EditorWeatherType)].GetValue<byte>(); } set { this[nameof(EditorWeatherType)].SetValue<byte>(value); } }
        public PPSkyCreatorWeatherPreset EditorWeatherPreset { get { return this[nameof(EditorWeatherPreset)].As<PPSkyCreatorWeatherPreset>(); } set { this["EditorWeatherPreset"] = value; } }
        public PPSkyCreatorWeatherSettings EditorWeatherSettings { get { return this[nameof(EditorWeatherSettings)].As<PPSkyCreatorWeatherSettings>(); } set { this["EditorWeatherSettings"] = value; } }
        public bool bIsUsedWithSequencer { get { return this[nameof(bIsUsedWithSequencer)].Flag; } set { this[nameof(bIsUsedWithSequencer)].Flag = value; } }
        public bool bIsEditorTickEnabled { get { return this[nameof(bIsEditorTickEnabled)].Flag; } set { this[nameof(bIsEditorTickEnabled)].Flag = value; } }
        public float TimeOfDay { get { return this[nameof(TimeOfDay)].GetValue<float>(); } set { this[nameof(TimeOfDay)].SetValue<float>(value); } }
        public PPSkyCreatorWeatherSettings WeatherSettings { get { return this[nameof(WeatherSettings)].As<PPSkyCreatorWeatherSettings>(); } set { this["WeatherSettings"] = value; } }
        public MaterialParameterCollection CommonMPC { get { return this[nameof(CommonMPC)].As<MaterialParameterCollection>(); } set { this["CommonMPC"] = value; } }
        public float SkySphereRadius { get { return this[nameof(SkySphereRadius)].GetValue<float>(); } set { this[nameof(SkySphereRadius)].SetValue<float>(value); } }
        public bool bShowDebugVariables { get { return this[nameof(bShowDebugVariables)].Flag; } set { this[nameof(bShowDebugVariables)].Flag = value; } }
        public byte SunPositionType { get { return this[nameof(SunPositionType)].GetValue<byte>(); } set { this[nameof(SunPositionType)].SetValue<byte>(value); } }
        public PPCelestialPositionData SunPositionData { get { return this[nameof(SunPositionData)].As<PPCelestialPositionData>(); } set { this["SunPositionData"] = value; } }
        public byte MoonPositionType { get { return this[nameof(MoonPositionType)].GetValue<byte>(); } set { this[nameof(MoonPositionType)].SetValue<byte>(value); } }
        public PPCelestialPositionData MoonPositionData { get { return this[nameof(MoonPositionData)].As<PPCelestialPositionData>(); } set { this["MoonPositionData"] = value; } }
        public float SunriseTime { get { return this[nameof(SunriseTime)].GetValue<float>(); } set { this[nameof(SunriseTime)].SetValue<float>(value); } }
        public float SunsetTime { get { return this[nameof(SunsetTime)].GetValue<float>(); } set { this[nameof(SunsetTime)].SetValue<float>(value); } }
        public float SunDawnOffsetTime { get { return this[nameof(SunDawnOffsetTime)].GetValue<float>(); } set { this[nameof(SunDawnOffsetTime)].SetValue<float>(value); } }
        public float SunDuskOffsetTime { get { return this[nameof(SunDuskOffsetTime)].GetValue<float>(); } set { this[nameof(SunDuskOffsetTime)].SetValue<float>(value); } }
        public float SunDawnTime { get { return this[nameof(SunDawnTime)].GetValue<float>(); } set { this[nameof(SunDawnTime)].SetValue<float>(value); } }
        public float SunDuskTime { get { return this[nameof(SunDuskTime)].GetValue<float>(); } set { this[nameof(SunDuskTime)].SetValue<float>(value); } }
        public float SunElevation { get { return this[nameof(SunElevation)].GetValue<float>(); } set { this[nameof(SunElevation)].SetValue<float>(value); } }
        public float SunAzimuth { get { return this[nameof(SunAzimuth)].GetValue<float>(); } set { this[nameof(SunAzimuth)].SetValue<float>(value); } }
        public float SunMinAngleAtDawnDusk { get { return this[nameof(SunMinAngleAtDawnDusk)].GetValue<float>(); } set { this[nameof(SunMinAngleAtDawnDusk)].SetValue<float>(value); } }
        public float SunFadeInOutTime { get { return this[nameof(SunFadeInOutTime)].GetValue<float>(); } set { this[nameof(SunFadeInOutTime)].SetValue<float>(value); } }
        public float MoonriseTime { get { return this[nameof(MoonriseTime)].GetValue<float>(); } set { this[nameof(MoonriseTime)].SetValue<float>(value); } }
        public float MoonsetTime { get { return this[nameof(MoonsetTime)].GetValue<float>(); } set { this[nameof(MoonsetTime)].SetValue<float>(value); } }
        public float MoonElevation { get { return this[nameof(MoonElevation)].GetValue<float>(); } set { this[nameof(MoonElevation)].SetValue<float>(value); } }
        public float MoonAzimuth { get { return this[nameof(MoonAzimuth)].GetValue<float>(); } set { this[nameof(MoonAzimuth)].SetValue<float>(value); } }
        public float MoonFadeInOutTime { get { return this[nameof(MoonFadeInOutTime)].GetValue<float>(); } set { this[nameof(MoonFadeInOutTime)].SetValue<float>(value); } }
        public float Latitude { get { return this[nameof(Latitude)].GetValue<float>(); } set { this[nameof(Latitude)].SetValue<float>(value); } }
        public float Longitude { get { return this[nameof(Longitude)].GetValue<float>(); } set { this[nameof(Longitude)].SetValue<float>(value); } }
        public float TimeZone { get { return this[nameof(TimeZone)].GetValue<float>(); } set { this[nameof(TimeZone)].SetValue<float>(value); } }
        public bool bDaylightSavingTime { get { return this[nameof(bDaylightSavingTime)].Flag; } set { this[nameof(bDaylightSavingTime)].Flag = value; } }
        public int Year { get { return this[nameof(Year)].GetValue<int>(); } set { this[nameof(Year)].SetValue<int>(value); } }
        public int Month { get { return this[nameof(Month)].GetValue<int>(); } set { this[nameof(Month)].SetValue<int>(value); } }
        public int Day { get { return this[nameof(Day)].GetValue<int>(); } set { this[nameof(Day)].SetValue<int>(value); } }
        public DateTime Date { get { return this[nameof(Date)].As<DateTime>(); } set { this["Date"] = value; } }
        public bool bLightTransition { get { return this[nameof(bLightTransition)].Flag; } set { this[nameof(bLightTransition)].Flag = value; } }
        public float SunSurfaceBrightness { get { return this[nameof(SunSurfaceBrightness)].GetValue<float>(); } set { this[nameof(SunSurfaceBrightness)].SetValue<float>(value); } }
        public float MoonSurfaceBrightness { get { return this[nameof(MoonSurfaceBrightness)].GetValue<float>(); } set { this[nameof(MoonSurfaceBrightness)].SetValue<float>(value); } }
        public float SunCurrentElevation { get { return this[nameof(SunCurrentElevation)].GetValue<float>(); } set { this[nameof(SunCurrentElevation)].SetValue<float>(value); } }
        public float TransitionStartSunAngle { get { return this[nameof(TransitionStartSunAngle)].GetValue<float>(); } set { this[nameof(TransitionStartSunAngle)].SetValue<float>(value); } }
        public float TransitionMiddleSunAngle { get { return this[nameof(TransitionMiddleSunAngle)].GetValue<float>(); } set { this[nameof(TransitionMiddleSunAngle)].SetValue<float>(value); } }
        public float TransitionEndSunAngle { get { return this[nameof(TransitionEndSunAngle)].GetValue<float>(); } set { this[nameof(TransitionEndSunAngle)].SetValue<float>(value); } }
        public float NightIntensityTransitionStartSunAngle { get { return this[nameof(NightIntensityTransitionStartSunAngle)].GetValue<float>(); } set { this[nameof(NightIntensityTransitionStartSunAngle)].SetValue<float>(value); } }
        public float NightIntensityTransitionEndSunAngle { get { return this[nameof(NightIntensityTransitionEndSunAngle)].GetValue<float>(); } set { this[nameof(NightIntensityTransitionEndSunAngle)].SetValue<float>(value); } }
        public byte SkyAtmosphereMobility { get { return this[nameof(SkyAtmosphereMobility)].GetValue<byte>(); } set { this[nameof(SkyAtmosphereMobility)].SetValue<byte>(value); } }
        public ESkyAtmosphereTransformMode TransformMode { get { return (ESkyAtmosphereTransformMode)this[nameof(TransformMode)].GetValue<int>(); } set { this[nameof(TransformMode)].SetValue<int>((int)value); } }
        public float PlanetRadius { get { return this[nameof(PlanetRadius)].GetValue<float>(); } set { this[nameof(PlanetRadius)].SetValue<float>(value); } }
        public float AtmosphereHeight { get { return this[nameof(AtmosphereHeight)].GetValue<float>(); } set { this[nameof(AtmosphereHeight)].SetValue<float>(value); } }
        public float AerialPespectiveViewDistanceScale { get { return this[nameof(AerialPespectiveViewDistanceScale)].GetValue<float>(); } set { this[nameof(AerialPespectiveViewDistanceScale)].SetValue<float>(value); } }
        public Vector PlanetTopPosition { get { return this[nameof(PlanetTopPosition)].As<Vector>(); } set { this["PlanetTopPosition"] = value; } }
        public float TraceSampleCountScale { get { return this[nameof(TraceSampleCountScale)].GetValue<float>(); } set { this[nameof(TraceSampleCountScale)].SetValue<float>(value); } }
        public float GodRaysResolution { get { return this[nameof(GodRaysResolution)].GetValue<float>(); } set { this[nameof(GodRaysResolution)].SetValue<float>(value); } }
        public float LayerBottomAltitude { get { return this[nameof(LayerBottomAltitude)].GetValue<float>(); } set { this[nameof(LayerBottomAltitude)].SetValue<float>(value); } }
        public float LayerHeight { get { return this[nameof(LayerHeight)].GetValue<float>(); } set { this[nameof(LayerHeight)].SetValue<float>(value); } }
        public float TracingStartMaxDistance { get { return this[nameof(TracingStartMaxDistance)].GetValue<float>(); } set { this[nameof(TracingStartMaxDistance)].SetValue<float>(value); } }
        public float TracingMaxDistance { get { return this[nameof(TracingMaxDistance)].GetValue<float>(); } set { this[nameof(TracingMaxDistance)].SetValue<float>(value); } }
        public bool bPerSampleAtmosphericLightTransmittance { get { return this[nameof(bPerSampleAtmosphericLightTransmittance)].Flag; } set { this[nameof(bPerSampleAtmosphericLightTransmittance)].Flag = value; } }
        public MaterialParameterCollection VolumetricCloudsMPC { get { return this[nameof(VolumetricCloudsMPC)].As<MaterialParameterCollection>(); } set { this["VolumetricCloudsMPC"] = value; } }
        public Vector LayerBottomAltitudePosition { get { return this[nameof(LayerBottomAltitudePosition)].As<Vector>(); } set { this["LayerBottomAltitudePosition"] = value; } }
        public Vector LayerTopAltitudePosition { get { return this[nameof(LayerTopAltitudePosition)].As<Vector>(); } set { this["LayerTopAltitudePosition"] = value; } }
        public MaterialInterface CurrentVolumetricCloudMaterial { get { return this[nameof(CurrentVolumetricCloudMaterial)].As<MaterialInterface>(); } set { this["CurrentVolumetricCloudMaterial"] = value; } }
        public MaterialInstanceDynamic VolumetricCloudMID { get { return this[nameof(VolumetricCloudMID)].As<MaterialInstanceDynamic>(); } set { this["VolumetricCloudMID"] = value; } }
        public MaterialInterface VolumetricCloudDensitySampleMaterial { get { return this[nameof(VolumetricCloudDensitySampleMaterial)].As<MaterialInterface>(); } set { this["VolumetricCloudDensitySampleMaterial"] = value; } }
        public MaterialInstanceDynamic VolumetricCloudDensitySampleMID { get { return this[nameof(VolumetricCloudDensitySampleMID)].As<MaterialInstanceDynamic>(); } set { this["VolumetricCloudDensitySampleMID"] = value; } }
        public TextureRenderTarget2D VolumetricCloudDensitySampleRT { get { return this[nameof(VolumetricCloudDensitySampleRT)].As<TextureRenderTarget2D>(); } set { this["VolumetricCloudDensitySampleRT"] = value; } }
        public bool bCinematicQuality { get { return this[nameof(bCinematicQuality)].Flag; } set { this[nameof(bCinematicQuality)].Flag = value; } }
        public byte RenderMode { get { return this[nameof(RenderMode)].GetValue<byte>(); } set { this[nameof(RenderMode)].SetValue<byte>(value); } }
        public bool bHighQualityAerialPerspective { get { return this[nameof(bHighQualityAerialPerspective)].Flag; } set { this[nameof(bHighQualityAerialPerspective)].Flag = value; } }
        public int MultiScatteringApproximationOctaveCount { get { return this[nameof(MultiScatteringApproximationOctaveCount)].GetValue<int>(); } set { this[nameof(MultiScatteringApproximationOctaveCount)].SetValue<int>(value); } }
        public bool bGroundContribution { get { return this[nameof(bGroundContribution)].Flag; } set { this[nameof(bGroundContribution)].Flag = value; } }
        public bool bRayMarchVolumeShadow { get { return this[nameof(bRayMarchVolumeShadow)].Flag; } set { this[nameof(bRayMarchVolumeShadow)].Flag = value; } }
        public float ViewSampleCountScale { get { return this[nameof(ViewSampleCountScale)].GetValue<float>(); } set { this[nameof(ViewSampleCountScale)].SetValue<float>(value); } }
        public float ReflectionSampleCountScale { get { return this[nameof(ReflectionSampleCountScale)].GetValue<float>(); } set { this[nameof(ReflectionSampleCountScale)].SetValue<float>(value); } }
        public float ShadowViewSampleCountScale { get { return this[nameof(ShadowViewSampleCountScale)].GetValue<float>(); } set { this[nameof(ShadowViewSampleCountScale)].SetValue<float>(value); } }
        public float ShadowReflectionSampleCountScale { get { return this[nameof(ShadowReflectionSampleCountScale)].GetValue<float>(); } set { this[nameof(ShadowReflectionSampleCountScale)].SetValue<float>(value); } }
        public float ShadowTracingDistance { get { return this[nameof(ShadowTracingDistance)].GetValue<float>(); } set { this[nameof(ShadowTracingDistance)].SetValue<float>(value); } }
        public float CloudMapScale { get { return this[nameof(CloudMapScale)].GetValue<float>(); } set { this[nameof(CloudMapScale)].SetValue<float>(value); } }
        public Vector2D CloudMapOffset { get { return this[nameof(CloudMapOffset)].As<Vector2D>(); } set { this["CloudMapOffset"] = value; } }
        public float CoverageVariationMapScale { get { return this[nameof(CoverageVariationMapScale)].GetValue<float>(); } set { this[nameof(CoverageVariationMapScale)].SetValue<float>(value); } }
        public byte NoiseShapeResolution { get { return this[nameof(NoiseShapeResolution)].GetValue<byte>(); } set { this[nameof(NoiseShapeResolution)].SetValue<byte>(value); } }
        public byte NoiseDetailResolution { get { return this[nameof(NoiseDetailResolution)].GetValue<byte>(); } set { this[nameof(NoiseDetailResolution)].SetValue<byte>(value); } }
        public float NoiseShapeScale { get { return this[nameof(NoiseShapeScale)].GetValue<float>(); } set { this[nameof(NoiseShapeScale)].SetValue<float>(value); } }
        public float NoiseDetailScale { get { return this[nameof(NoiseDetailScale)].GetValue<float>(); } set { this[nameof(NoiseDetailScale)].SetValue<float>(value); } }
        public float TurbulenceScale { get { return this[nameof(TurbulenceScale)].GetValue<float>(); } set { this[nameof(TurbulenceScale)].SetValue<float>(value); } }
        public float BackgroundCloudsContrast { get { return this[nameof(BackgroundCloudsContrast)].GetValue<float>(); } set { this[nameof(BackgroundCloudsContrast)].SetValue<float>(value); } }
        public float BackgroundCloudsReflectionScale { get { return this[nameof(BackgroundCloudsReflectionScale)].GetValue<float>(); } set { this[nameof(BackgroundCloudsReflectionScale)].SetValue<float>(value); } }
        public byte SkyLightMobility { get { return this[nameof(SkyLightMobility)].GetValue<byte>(); } set { this[nameof(SkyLightMobility)].SetValue<byte>(value); } }
        public bool bRealTimeCapture { get { return this[nameof(bRealTimeCapture)].Flag; } set { this[nameof(bRealTimeCapture)].Flag = value; } }
        public bool bSkyLightCaptureTimeSlice { get { return this[nameof(bSkyLightCaptureTimeSlice)].Flag; } set { this[nameof(bSkyLightCaptureTimeSlice)].Flag = value; } }
        public bool bLowerHemisphereIsSolidColor { get { return this[nameof(bLowerHemisphereIsSolidColor)].Flag; } set { this[nameof(bLowerHemisphereIsSolidColor)].Flag = value; } }
        public bool bCloudAmbientOcclusion { get { return this[nameof(bCloudAmbientOcclusion)].Flag; } set { this[nameof(bCloudAmbientOcclusion)].Flag = value; } }
        public float CloudAmbientOcclusionExtent { get { return this[nameof(CloudAmbientOcclusionExtent)].GetValue<float>(); } set { this[nameof(CloudAmbientOcclusionExtent)].SetValue<float>(value); } }
        public float CloudAmbientOcclusionMapResolutionScale { get { return this[nameof(CloudAmbientOcclusionMapResolutionScale)].GetValue<float>(); } set { this[nameof(CloudAmbientOcclusionMapResolutionScale)].SetValue<float>(value); } }
        public float CloudAmbientOcclusionApertureScale { get { return this[nameof(CloudAmbientOcclusionApertureScale)].GetValue<float>(); } set { this[nameof(CloudAmbientOcclusionApertureScale)].SetValue<float>(value); } }
        public byte SunLightMobility { get { return this[nameof(SunLightMobility)].GetValue<byte>(); } set { this[nameof(SunLightMobility)].SetValue<byte>(value); } }
        public bool bControlSunDirection { get { return this[nameof(bControlSunDirection)].Flag; } set { this[nameof(bControlSunDirection)].Flag = value; } }
        public bool bSunConstantIntensity { get { return this[nameof(bSunConstantIntensity)].Flag; } set { this[nameof(bSunConstantIntensity)].Flag = value; } }
        public float SunIntensity { get { return this[nameof(SunIntensity)].GetValue<float>(); } set { this[nameof(SunIntensity)].SetValue<float>(value); } }
        public float SunCurrentIntensity { get { return this[nameof(SunCurrentIntensity)].GetValue<float>(); } set { this[nameof(SunCurrentIntensity)].SetValue<float>(value); } }
        public bool bSunUseTemperature { get { return this[nameof(bSunUseTemperature)].Flag; } set { this[nameof(bSunUseTemperature)].Flag = value; } }
        public float SunDiskSize { get { return this[nameof(SunDiskSize)].GetValue<float>(); } set { this[nameof(SunDiskSize)].SetValue<float>(value); } }
        public bool bSunConstantAtmosphereDiskColorScale { get { return this[nameof(bSunConstantAtmosphereDiskColorScale)].Flag; } set { this[nameof(bSunConstantAtmosphereDiskColorScale)].Flag = value; } }
        public LinearColor SunAtmosphereDiskColorScale { get { return this[nameof(SunAtmosphereDiskColorScale)].As<LinearColor>(); } set { this["SunAtmosphereDiskColorScale"] = value; } }
        public bool bSunPerPixelAtmosphereTransmittance { get { return this[nameof(bSunPerPixelAtmosphereTransmittance)].Flag; } set { this[nameof(bSunPerPixelAtmosphereTransmittance)].Flag = value; } }
        public float SunCloudShadowExtent { get { return this[nameof(SunCloudShadowExtent)].GetValue<float>(); } set { this[nameof(SunCloudShadowExtent)].SetValue<float>(value); } }
        public float SunCloudShadowMapResolutionScale { get { return this[nameof(SunCloudShadowMapResolutionScale)].GetValue<float>(); } set { this[nameof(SunCloudShadowMapResolutionScale)].SetValue<float>(value); } }
        public float SunCloudShadowRaySampleCountScale { get { return this[nameof(SunCloudShadowRaySampleCountScale)].GetValue<float>(); } set { this[nameof(SunCloudShadowRaySampleCountScale)].SetValue<float>(value); } }
        public byte MoonLightMobility { get { return this[nameof(MoonLightMobility)].GetValue<byte>(); } set { this[nameof(MoonLightMobility)].SetValue<byte>(value); } }
        public bool bControlMoonDirection { get { return this[nameof(bControlMoonDirection)].Flag; } set { this[nameof(bControlMoonDirection)].Flag = value; } }
        public bool bMoonConstantIntensity { get { return this[nameof(bMoonConstantIntensity)].Flag; } set { this[nameof(bMoonConstantIntensity)].Flag = value; } }
        public float MoonIntensity { get { return this[nameof(MoonIntensity)].GetValue<float>(); } set { this[nameof(MoonIntensity)].SetValue<float>(value); } }
        public float MoonCurrentIntensity { get { return this[nameof(MoonCurrentIntensity)].GetValue<float>(); } set { this[nameof(MoonCurrentIntensity)].SetValue<float>(value); } }
        public bool bMoonUseTemperature { get { return this[nameof(bMoonUseTemperature)].Flag; } set { this[nameof(bMoonUseTemperature)].Flag = value; } }
        public float MoonDiskSize { get { return this[nameof(MoonDiskSize)].GetValue<float>(); } set { this[nameof(MoonDiskSize)].SetValue<float>(value); } }
        public float MoonRotation { get { return this[nameof(MoonRotation)].GetValue<float>(); } set { this[nameof(MoonRotation)].SetValue<float>(value); } }
        public float MoonPhase { get { return this[nameof(MoonPhase)].GetValue<float>(); } set { this[nameof(MoonPhase)].SetValue<float>(value); } }
        public bool bMoonPhaseLightIntensityScale { get { return this[nameof(bMoonPhaseLightIntensityScale)].Flag; } set { this[nameof(bMoonPhaseLightIntensityScale)].Flag = value; } }
        public float MoonPhaseLightIntensityMinScale { get { return this[nameof(MoonPhaseLightIntensityMinScale)].GetValue<float>(); } set { this[nameof(MoonPhaseLightIntensityMinScale)].SetValue<float>(value); } }
        public float MoonPhaseLightIntensityMaxScale { get { return this[nameof(MoonPhaseLightIntensityMaxScale)].GetValue<float>(); } set { this[nameof(MoonPhaseLightIntensityMaxScale)].SetValue<float>(value); } }
        public bool bMoonConstantAtmosphereDiskColorScale { get { return this[nameof(bMoonConstantAtmosphereDiskColorScale)].Flag; } set { this[nameof(bMoonConstantAtmosphereDiskColorScale)].Flag = value; } }
        public LinearColor MoonAtmosphereDiskColorScale { get { return this[nameof(MoonAtmosphereDiskColorScale)].As<LinearColor>(); } set { this["MoonAtmosphereDiskColorScale"] = value; } }
        public bool bMoonPerPixelAtmosphereTransmittance { get { return this[nameof(bMoonPerPixelAtmosphereTransmittance)].Flag; } set { this[nameof(bMoonPerPixelAtmosphereTransmittance)].Flag = value; } }
        public float MoonCloudShadowExtent { get { return this[nameof(MoonCloudShadowExtent)].GetValue<float>(); } set { this[nameof(MoonCloudShadowExtent)].SetValue<float>(value); } }
        public float MoonCloudShadowMapResolutionScale { get { return this[nameof(MoonCloudShadowMapResolutionScale)].GetValue<float>(); } set { this[nameof(MoonCloudShadowMapResolutionScale)].SetValue<float>(value); } }
        public float MoonCloudShadowRaySampleCountScale { get { return this[nameof(MoonCloudShadowRaySampleCountScale)].GetValue<float>(); } set { this[nameof(MoonCloudShadowRaySampleCountScale)].SetValue<float>(value); } }
        public byte ExponentialHeightFogMobility { get { return this[nameof(ExponentialHeightFogMobility)].GetValue<byte>(); } set { this[nameof(ExponentialHeightFogMobility)].SetValue<byte>(value); } }
        public bool bEnableExponentialHeightFog { get { return this[nameof(bEnableExponentialHeightFog)].Flag; } set { this[nameof(bEnableExponentialHeightFog)].Flag = value; } }
        public bool bVolumetricFog { get { return this[nameof(bVolumetricFog)].Flag; } set { this[nameof(bVolumetricFog)].Flag = value; } }
        public float FogHeightOffset { get { return this[nameof(FogHeightOffset)].GetValue<float>(); } set { this[nameof(FogHeightOffset)].SetValue<float>(value); } }
        public float SecondFogHeightOffset { get { return this[nameof(SecondFogHeightOffset)].GetValue<float>(); } set { this[nameof(SecondFogHeightOffset)].SetValue<float>(value); } }
        public Texture2D StarMapTexture { get { return this[nameof(StarMapTexture)].As<Texture2D>(); } set { this["StarMapTexture"] = value; } }
        public byte StarMapRotationType { get { return this[nameof(StarMapRotationType)].GetValue<byte>(); } set { this[nameof(StarMapRotationType)].SetValue<byte>(value); } }
        public Vector StarMapAdditionalRotation { get { return this[nameof(StarMapAdditionalRotation)].As<Vector>(); } set { this["StarMapAdditionalRotation"] = value; } }
        public bool bEnableOcclusionCapture { get { return this[nameof(bEnableOcclusionCapture)].Flag; } set { this[nameof(bEnableOcclusionCapture)].Flag = value; } }
        public TextureRenderTarget2D OcclusionRenderTarget { get { return this[nameof(OcclusionRenderTarget)].As<TextureRenderTarget2D>(); } set { this["OcclusionRenderTarget"] = value; } }
        public float OcclusionCaptureWidth { get { return this[nameof(OcclusionCaptureWidth)].GetValue<float>(); } set { this[nameof(OcclusionCaptureWidth)].SetValue<float>(value); } }
        public float OcclusionCaptureHeight { get { return this[nameof(OcclusionCaptureHeight)].GetValue<float>(); } set { this[nameof(OcclusionCaptureHeight)].SetValue<float>(value); } }
        public bool bOcclusionCaptureRealtimeUpdate { get { return this[nameof(bOcclusionCaptureRealtimeUpdate)].Flag; } set { this[nameof(bOcclusionCaptureRealtimeUpdate)].Flag = value; } }
        public float OcclusionCaptureStepDistance { get { return this[nameof(OcclusionCaptureStepDistance)].GetValue<float>(); } set { this[nameof(OcclusionCaptureStepDistance)].SetValue<float>(value); } }
        public float OcclusionCaptureStepSize { get { return this[nameof(OcclusionCaptureStepSize)].GetValue<float>(); } set { this[nameof(OcclusionCaptureStepSize)].SetValue<float>(value); } }
        public float OcclusionBias { get { return this[nameof(OcclusionBias)].GetValue<float>(); } set { this[nameof(OcclusionBias)].SetValue<float>(value); } }
        public int OcclusionBlurSamples { get { return this[nameof(OcclusionBlurSamples)].GetValue<int>(); } set { this[nameof(OcclusionBlurSamples)].SetValue<int>(value); } }
        public float OcclusionBlurDistance { get { return this[nameof(OcclusionBlurDistance)].GetValue<float>(); } set { this[nameof(OcclusionBlurDistance)].SetValue<float>(value); } }
        public float OcclusionMaskFadeHardness { get { return this[nameof(OcclusionMaskFadeHardness)].GetValue<float>(); } set { this[nameof(OcclusionMaskFadeHardness)].SetValue<float>(value); } }
        public Vector CameraLocation { get { return this[nameof(CameraLocation)].As<Vector>(); } set { this["CameraLocation"] = value; } }
        public Vector CameraLocationSnapped { get { return this[nameof(CameraLocationSnapped)].As<Vector>(); } set { this["CameraLocationSnapped"] = value; } }
        public Vector OcclusionCurrentLocation { get { return this[nameof(OcclusionCurrentLocation)].As<Vector>(); } set { this["OcclusionCurrentLocation"] = value; } }
        public float WeatherFXCutoffWorldHeight { get { return this[nameof(WeatherFXCutoffWorldHeight)].GetValue<float>(); } set { this[nameof(WeatherFXCutoffWorldHeight)].SetValue<float>(value); } }
        public float WeatherFXCutoffSoftness { get { return this[nameof(WeatherFXCutoffSoftness)].GetValue<float>(); } set { this[nameof(WeatherFXCutoffSoftness)].SetValue<float>(value); } }
        public float PrecipitationSpawnRadius { get { return this[nameof(PrecipitationSpawnRadius)].GetValue<float>(); } set { this[nameof(PrecipitationSpawnRadius)].SetValue<float>(value); } }
        public bool bEnableGPUPrecipitation { get { return this[nameof(bEnableGPUPrecipitation)].Flag; } set { this[nameof(bEnableGPUPrecipitation)].Flag = value; } }
        public float PrecipitationSpawnRadiusGPU { get { return this[nameof(PrecipitationSpawnRadiusGPU)].GetValue<float>(); } set { this[nameof(PrecipitationSpawnRadiusGPU)].SetValue<float>(value); } }
        public float PrecipitationMaxViewDistance { get { return this[nameof(PrecipitationMaxViewDistance)].GetValue<float>(); } set { this[nameof(PrecipitationMaxViewDistance)].SetValue<float>(value); } }
        public float PrecipitationVerticalCheckDistance { get { return this[nameof(PrecipitationVerticalCheckDistance)].GetValue<float>(); } set { this[nameof(PrecipitationVerticalCheckDistance)].SetValue<float>(value); } }
        public byte PrecipitationCollisionChannel { get { return this[nameof(PrecipitationCollisionChannel)].GetValue<byte>(); } set { this[nameof(PrecipitationCollisionChannel)].SetValue<byte>(value); } }
        public float PrecipitationDepthFadeDistance { get { return this[nameof(PrecipitationDepthFadeDistance)].GetValue<float>(); } set { this[nameof(PrecipitationDepthFadeDistance)].SetValue<float>(value); } }
        public float PrecipitationCameraFadeDistance { get { return this[nameof(PrecipitationCameraFadeDistance)].GetValue<float>(); } set { this[nameof(PrecipitationCameraFadeDistance)].SetValue<float>(value); } }
        public float PrecipitationCameraFadeOffset { get { return this[nameof(PrecipitationCameraFadeOffset)].GetValue<float>(); } set { this[nameof(PrecipitationCameraFadeOffset)].SetValue<float>(value); } }
        public float RainSpawnRateMaxCPU { get { return this[nameof(RainSpawnRateMaxCPU)].GetValue<float>(); } set { this[nameof(RainSpawnRateMaxCPU)].SetValue<float>(value); } }
        public float RainSpawnRateMaxGPU { get { return this[nameof(RainSpawnRateMaxGPU)].GetValue<float>(); } set { this[nameof(RainSpawnRateMaxGPU)].SetValue<float>(value); } }
        public float RainDistanceScaleFactor { get { return this[nameof(RainDistanceScaleFactor)].GetValue<float>(); } set { this[nameof(RainDistanceScaleFactor)].SetValue<float>(value); } }
        public float RainCameraMotionAlignmentScale { get { return this[nameof(RainCameraMotionAlignmentScale)].GetValue<float>(); } set { this[nameof(RainCameraMotionAlignmentScale)].SetValue<float>(value); } }
        public float RainVelocityElongationScale { get { return this[nameof(RainVelocityElongationScale)].GetValue<float>(); } set { this[nameof(RainVelocityElongationScale)].SetValue<float>(value); } }
        public float RainMaskHardness { get { return this[nameof(RainMaskHardness)].GetValue<float>(); } set { this[nameof(RainMaskHardness)].SetValue<float>(value); } }
        public float RainSplashSpawnRateMax { get { return this[nameof(RainSplashSpawnRateMax)].GetValue<float>(); } set { this[nameof(RainSplashSpawnRateMax)].SetValue<float>(value); } }
        public float RainSplashSpawnRateMaxGPU { get { return this[nameof(RainSplashSpawnRateMaxGPU)].GetValue<float>(); } set { this[nameof(RainSplashSpawnRateMaxGPU)].SetValue<float>(value); } }
        public float SnowSpawnRateMaxCPU { get { return this[nameof(SnowSpawnRateMaxCPU)].GetValue<float>(); } set { this[nameof(SnowSpawnRateMaxCPU)].SetValue<float>(value); } }
        public float SnowSpawnRateMaxGPU { get { return this[nameof(SnowSpawnRateMaxGPU)].GetValue<float>(); } set { this[nameof(SnowSpawnRateMaxGPU)].SetValue<float>(value); } }
        public float SnowDistanceScaleFactor { get { return this[nameof(SnowDistanceScaleFactor)].GetValue<float>(); } set { this[nameof(SnowDistanceScaleFactor)].SetValue<float>(value); } }
        public float SnowCameraMotionAlignmentScale { get { return this[nameof(SnowCameraMotionAlignmentScale)].GetValue<float>(); } set { this[nameof(SnowCameraMotionAlignmentScale)].SetValue<float>(value); } }
        public float SnowVelocityElongationScale { get { return this[nameof(SnowVelocityElongationScale)].GetValue<float>(); } set { this[nameof(SnowVelocityElongationScale)].SetValue<float>(value); } }
        public float SnowMaskHardness { get { return this[nameof(SnowMaskHardness)].GetValue<float>(); } set { this[nameof(SnowMaskHardness)].SetValue<float>(value); } }
        public TextureRenderTarget2D LightningsParametersRT { get { return this[nameof(LightningsParametersRT)].As<TextureRenderTarget2D>(); } set { this["LightningsParametersRT"] = value; } }
        public Array<PPSkyCreatorLightningParameters> LightningParameters { get { return new Array<PPSkyCreatorLightningParameters>(this[nameof(LightningParameters)].Address); } }
        public float CurrentLightningInterval { get { return this[nameof(CurrentLightningInterval)].GetValue<float>(); } set { this[nameof(CurrentLightningInterval)].SetValue<float>(value); } }
        public Vector LastLightningPosition { get { return this[nameof(LastLightningPosition)].As<Vector>(); } set { this["LastLightningPosition"] = value; } }
        public Array<Vector> LightningAvailablePositions { get { return new Array<Vector>(this[nameof(LightningAvailablePositions)].Address); } }
        public int LightningCurrentIndex { get { return this[nameof(LightningCurrentIndex)].GetValue<int>(); } set { this[nameof(LightningCurrentIndex)].SetValue<int>(value); } }
        public bool bSampleCloudDensity { get { return this[nameof(bSampleCloudDensity)].Flag; } set { this[nameof(bSampleCloudDensity)].Flag = value; } }
        public int LightningMaxSamples { get { return this[nameof(LightningMaxSamples)].GetValue<int>(); } set { this[nameof(LightningMaxSamples)].SetValue<int>(value); } }
        public float LightningSpawnInnerRadius { get { return this[nameof(LightningSpawnInnerRadius)].GetValue<float>(); } set { this[nameof(LightningSpawnInnerRadius)].SetValue<float>(value); } }
        public float LightningSpawnOuterRadius { get { return this[nameof(LightningSpawnOuterRadius)].GetValue<float>(); } set { this[nameof(LightningSpawnOuterRadius)].SetValue<float>(value); } }
        public float LightningRandomDegreeInConeMax { get { return this[nameof(LightningRandomDegreeInConeMax)].GetValue<float>(); } set { this[nameof(LightningRandomDegreeInConeMax)].SetValue<float>(value); } }
        public float LightningBoltEmissiveScale { get { return this[nameof(LightningBoltEmissiveScale)].GetValue<float>(); } set { this[nameof(LightningBoltEmissiveScale)].SetValue<float>(value); } }
        public float LightningFlashFadeUpdateRate { get { return this[nameof(LightningFlashFadeUpdateRate)].GetValue<float>(); } set { this[nameof(LightningFlashFadeUpdateRate)].SetValue<float>(value); } }
        public float LightningFlashFadeDelta { get { return this[nameof(LightningFlashFadeDelta)].GetValue<float>(); } set { this[nameof(LightningFlashFadeDelta)].SetValue<float>(value); } }
        public float LightningFlashEmissiveScale { get { return this[nameof(LightningFlashEmissiveScale)].GetValue<float>(); } set { this[nameof(LightningFlashEmissiveScale)].SetValue<float>(value); } }
        public float LightningFlashEmissiveReflectionScale { get { return this[nameof(LightningFlashEmissiveReflectionScale)].GetValue<float>(); } set { this[nameof(LightningFlashEmissiveReflectionScale)].SetValue<float>(value); } }
        public float LightningFlashRadiusScale { get { return this[nameof(LightningFlashRadiusScale)].GetValue<float>(); } set { this[nameof(LightningFlashRadiusScale)].SetValue<float>(value); } }
        public float LightningFlashFadeSpeed { get { return this[nameof(LightningFlashFadeSpeed)].GetValue<float>(); } set { this[nameof(LightningFlashFadeSpeed)].SetValue<float>(value); } }
        public float RainbowDistance { get { return this[nameof(RainbowDistance)].GetValue<float>(); } set { this[nameof(RainbowDistance)].SetValue<float>(value); } }
        public float RainbowDepthFadeDistance { get { return this[nameof(RainbowDepthFadeDistance)].GetValue<float>(); } set { this[nameof(RainbowDepthFadeDistance)].SetValue<float>(value); } }
        public float MaterialFXCutoffWorldHeight { get { return this[nameof(MaterialFXCutoffWorldHeight)].GetValue<float>(); } set { this[nameof(MaterialFXCutoffWorldHeight)].SetValue<float>(value); } }
        public float MaterialFXCutoffSoftness { get { return this[nameof(MaterialFXCutoffSoftness)].GetValue<float>(); } set { this[nameof(MaterialFXCutoffSoftness)].SetValue<float>(value); } }
        public float WetnessSlopeAngle { get { return this[nameof(WetnessSlopeAngle)].GetValue<float>(); } set { this[nameof(WetnessSlopeAngle)].SetValue<float>(value); } }
        public float WetnessSlopeSmoothness { get { return this[nameof(WetnessSlopeSmoothness)].GetValue<float>(); } set { this[nameof(WetnessSlopeSmoothness)].SetValue<float>(value); } }
        public float PuddlesMaskScale { get { return this[nameof(PuddlesMaskScale)].GetValue<float>(); } set { this[nameof(PuddlesMaskScale)].SetValue<float>(value); } }
        public float PuddlesRoughness { get { return this[nameof(PuddlesRoughness)].GetValue<float>(); } set { this[nameof(PuddlesRoughness)].SetValue<float>(value); } }
        public float PuddlesSlopeAngle { get { return this[nameof(PuddlesSlopeAngle)].GetValue<float>(); } set { this[nameof(PuddlesSlopeAngle)].SetValue<float>(value); } }
        public float PuddlesSlopeSmoothness { get { return this[nameof(PuddlesSlopeSmoothness)].GetValue<float>(); } set { this[nameof(PuddlesSlopeSmoothness)].SetValue<float>(value); } }
        public bool bEnableRainRipplesSolver { get { return this[nameof(bEnableRainRipplesSolver)].Flag; } set { this[nameof(bEnableRainRipplesSolver)].Flag = value; } }
        public bool bPauseRainRipplesSolver { get { return this[nameof(bPauseRainRipplesSolver)].Flag; } set { this[nameof(bPauseRainRipplesSolver)].Flag = value; } }
        public float RainRipplesUpdateRate { get { return this[nameof(RainRipplesUpdateRate)].GetValue<float>(); } set { this[nameof(RainRipplesUpdateRate)].SetValue<float>(value); } }
        public float RainRipplesScale { get { return this[nameof(RainRipplesScale)].GetValue<float>(); } set { this[nameof(RainRipplesScale)].SetValue<float>(value); } }
        public float RainRipplesMaxDensity { get { return this[nameof(RainRipplesMaxDensity)].GetValue<float>(); } set { this[nameof(RainRipplesMaxDensity)].SetValue<float>(value); } }
        public float WindRipplesScale { get { return this[nameof(WindRipplesScale)].GetValue<float>(); } set { this[nameof(WindRipplesScale)].SetValue<float>(value); } }
        public float RainRipplesSolverDelta { get { return this[nameof(RainRipplesSolverDelta)].GetValue<float>(); } set { this[nameof(RainRipplesSolverDelta)].SetValue<float>(value); } }
        public int RainRipplesSolverHeightState { get { return this[nameof(RainRipplesSolverHeightState)].GetValue<int>(); } set { this[nameof(RainRipplesSolverHeightState)].SetValue<int>(value); } }
        public MaterialInterface RainRipplesPropagation { get { return this[nameof(RainRipplesPropagation)].As<MaterialInterface>(); } set { this["RainRipplesPropagation"] = value; } }
        public MaterialInstanceDynamic RainRipplesPropagationMID { get { return this[nameof(RainRipplesPropagationMID)].As<MaterialInstanceDynamic>(); } set { this["RainRipplesPropagationMID"] = value; } }
        public MaterialInterface RainRipplesForce { get { return this[nameof(RainRipplesForce)].As<MaterialInterface>(); } set { this["RainRipplesForce"] = value; } }
        public MaterialInterface RainRipplesNormal { get { return this[nameof(RainRipplesNormal)].As<MaterialInterface>(); } set { this["RainRipplesNormal"] = value; } }
        public MaterialInstanceDynamic RainRipplesNormalMID { get { return this[nameof(RainRipplesNormalMID)].As<MaterialInstanceDynamic>(); } set { this["RainRipplesNormalMID"] = value; } }
        public TextureRenderTarget2D RainRipplesPropagationFrame0 { get { return this[nameof(RainRipplesPropagationFrame0)].As<TextureRenderTarget2D>(); } set { this["RainRipplesPropagationFrame0"] = value; } }
        public TextureRenderTarget2D RainRipplesPropagationFrame1 { get { return this[nameof(RainRipplesPropagationFrame1)].As<TextureRenderTarget2D>(); } set { this["RainRipplesPropagationFrame1"] = value; } }
        public TextureRenderTarget2D RainRipplesPropagationFrame2 { get { return this[nameof(RainRipplesPropagationFrame2)].As<TextureRenderTarget2D>(); } set { this["RainRipplesPropagationFrame2"] = value; } }
        public TextureRenderTarget2D RainRipplesNormalRT { get { return this[nameof(RainRipplesNormalRT)].As<TextureRenderTarget2D>(); } set { this["RainRipplesNormalRT"] = value; } }
        public float SnowMaskScale { get { return this[nameof(SnowMaskScale)].GetValue<float>(); } set { this[nameof(SnowMaskScale)].SetValue<float>(value); } }
        public float SnowScale { get { return this[nameof(SnowScale)].GetValue<float>(); } set { this[nameof(SnowScale)].SetValue<float>(value); } }
        public float SnowRoughness { get { return this[nameof(SnowRoughness)].GetValue<float>(); } set { this[nameof(SnowRoughness)].SetValue<float>(value); } }
        public float SnowSparklesScale { get { return this[nameof(SnowSparklesScale)].GetValue<float>(); } set { this[nameof(SnowSparklesScale)].SetValue<float>(value); } }
        public float SnowSparklesRoughness { get { return this[nameof(SnowSparklesRoughness)].GetValue<float>(); } set { this[nameof(SnowSparklesRoughness)].SetValue<float>(value); } }
        public float SnowSlopeAngle { get { return this[nameof(SnowSlopeAngle)].GetValue<float>(); } set { this[nameof(SnowSlopeAngle)].SetValue<float>(value); } }
        public float SnowSlopeSmoothness { get { return this[nameof(SnowSlopeSmoothness)].GetValue<float>(); } set { this[nameof(SnowSlopeSmoothness)].SetValue<float>(value); } }
        public bool bEnableWind { get { return this[nameof(bEnableWind)].Flag; } set { this[nameof(bEnableWind)].Flag = value; } }
        public bool bIndependentWindControl { get { return this[nameof(bIndependentWindControl)].Flag; } set { this[nameof(bIndependentWindControl)].Flag = value; } }
        public PPSkyCreatorWindSettings EditorIndependentWindSettings { get { return this[nameof(EditorIndependentWindSettings)].As<PPSkyCreatorWindSettings>(); } set { this["EditorIndependentWindSettings"] = value; } }
        public float CloudWindSkewAmount { get { return this[nameof(CloudWindSkewAmount)].GetValue<float>(); } set { this[nameof(CloudWindSkewAmount)].SetValue<float>(value); } }
        public Vector CloudWindOffset { get { return this[nameof(CloudWindOffset)].As<Vector>(); } set { this["CloudWindOffset"] = value; } }
        public Vector CloudWindSkewDirection { get { return this[nameof(CloudWindSkewDirection)].As<Vector>(); } set { this["CloudWindSkewDirection"] = value; } }
        public float CloudWindSkewForce { get { return this[nameof(CloudWindSkewForce)].GetValue<float>(); } set { this[nameof(CloudWindSkewForce)].SetValue<float>(value); } }
        public Vector CloudNoiseShapeWindOffset { get { return this[nameof(CloudNoiseShapeWindOffset)].As<Vector>(); } set { this["CloudNoiseShapeWindOffset"] = value; } }
        public Vector CloudNoiseDetailWindOffset { get { return this[nameof(CloudNoiseDetailWindOffset)].As<Vector>(); } set { this["CloudNoiseDetailWindOffset"] = value; } }
        public bool bUseExposureSettings { get { return this[nameof(bUseExposureSettings)].Flag; } set { this[nameof(bUseExposureSettings)].Flag = value; } }
        public bool bExtendDefaultLuminanceRange { get { return this[nameof(bExtendDefaultLuminanceRange)].Flag; } set { this[nameof(bExtendDefaultLuminanceRange)].Flag = value; } }
        public float PostProcessPriority { get { return this[nameof(PostProcessPriority)].GetValue<float>(); } set { this[nameof(PostProcessPriority)].SetValue<float>(value); } }
        public byte ExposureMethod { get { return this[nameof(ExposureMethod)].GetValue<byte>(); } set { this[nameof(ExposureMethod)].SetValue<byte>(value); } }
        public CurveFloat ExposureBiasCurve { get { return this[nameof(ExposureBiasCurve)].As<CurveFloat>(); } set { this["ExposureBiasCurve"] = value; } }
        public Texture ExposureMeterMask { get { return this[nameof(ExposureMeterMask)].As<Texture>(); } set { this["ExposureMeterMask"] = value; } }
        public float ExposureMinBrightness { get { return this[nameof(ExposureMinBrightness)].GetValue<float>(); } set { this[nameof(ExposureMinBrightness)].SetValue<float>(value); } }
        public float ExposureMaxBrightness { get { return this[nameof(ExposureMaxBrightness)].GetValue<float>(); } set { this[nameof(ExposureMaxBrightness)].SetValue<float>(value); } }
        public float ExposureMinEV100 { get { return this[nameof(ExposureMinEV100)].GetValue<float>(); } set { this[nameof(ExposureMinEV100)].SetValue<float>(value); } }
        public float ExposureMaxEV100 { get { return this[nameof(ExposureMaxEV100)].GetValue<float>(); } set { this[nameof(ExposureMaxEV100)].SetValue<float>(value); } }
        public float ExposureSpeedUp { get { return this[nameof(ExposureSpeedUp)].GetValue<float>(); } set { this[nameof(ExposureSpeedUp)].SetValue<float>(value); } }
        public float ExposureSpeedDown { get { return this[nameof(ExposureSpeedDown)].GetValue<float>(); } set { this[nameof(ExposureSpeedDown)].SetValue<float>(value); } }
        public float ExposureLowPercent { get { return this[nameof(ExposureLowPercent)].GetValue<float>(); } set { this[nameof(ExposureLowPercent)].SetValue<float>(value); } }
        public float ExposureHighPercent { get { return this[nameof(ExposureHighPercent)].GetValue<float>(); } set { this[nameof(ExposureHighPercent)].SetValue<float>(value); } }
        public float ExposureHistogramLogMin { get { return this[nameof(ExposureHistogramLogMin)].GetValue<float>(); } set { this[nameof(ExposureHistogramLogMin)].SetValue<float>(value); } }
        public float ExposureHistogramLogMax { get { return this[nameof(ExposureHistogramLogMax)].GetValue<float>(); } set { this[nameof(ExposureHistogramLogMax)].SetValue<float>(value); } }
        public float ExposureHistogramMinEV100 { get { return this[nameof(ExposureHistogramMinEV100)].GetValue<float>(); } set { this[nameof(ExposureHistogramMinEV100)].SetValue<float>(value); } }
        public float ExposureHistogramMaxEV100 { get { return this[nameof(ExposureHistogramMaxEV100)].GetValue<float>(); } set { this[nameof(ExposureHistogramMaxEV100)].SetValue<float>(value); } }
        public Object OnLightningStrike { get { return this[nameof(OnLightningStrike)]; } set { this[nameof(OnLightningStrike)] = value; } }
        public void UpdateSettingsSequencer() { Invoke(nameof(UpdateSettingsSequencer)); }
        public void SpawnLightningStrike(Vector LightningPosition) { Invoke(nameof(SpawnLightningStrike), LightningPosition); }
        public void SetYear(int NewValue) { Invoke(nameof(SetYear), NewValue); }
        public void SetWindSettings(PPSkyCreatorWindSettings InWindSettings) { Invoke(nameof(SetWindSettings), InWindSettings); }
        public void SetWindIndependentSettings(PPSkyCreatorWindSettings InWindSettings) { Invoke(nameof(SetWindIndependentSettings), InWindSettings); }
        public void SetWeatherSettings(PPSkyCreatorWeatherSettings InWeatherSettings) { Invoke(nameof(SetWeatherSettings), InWeatherSettings); }
        public void SetWeatherMaterialFXSettings(PPSkyCreatorWeatherMaterialFXSettings InWeatherMaterialFXSettings) { Invoke(nameof(SetWeatherMaterialFXSettings), InWeatherMaterialFXSettings); }
        public void SetWeatherFXSettings(PPSkyCreatorWeatherFXSettings InWeatherFXSettings) { Invoke(nameof(SetWeatherFXSettings), InWeatherFXSettings); }
        public void SetVolumetricCloudSettings(PPSkyCreatorVolumetricCloudSettings InVolumetricCloudSettings) { Invoke(nameof(SetVolumetricCloudSettings), InVolumetricCloudSettings); }
        public void SetTimeZone(float NewValue) { Invoke(nameof(SetTimeZone), NewValue); }
        public void SetTime(float InTime) { Invoke(nameof(SetTime), InTime); }
        public void SetSunSimplePositionSettings(float InSunriseTime, float InSunsetTime, float InSunElevation, float InSunAzimuth) { Invoke(nameof(SetSunSimplePositionSettings), InSunriseTime, InSunsetTime, InSunElevation, InSunAzimuth); }
        public void SetSunsetTime(float NewValue) { Invoke(nameof(SetSunsetTime), NewValue); }
        public void SetSunriseTime(float NewValue) { Invoke(nameof(SetSunriseTime), NewValue); }
        public void SetSunMinAngleAtDawnDusk(float NewValue) { Invoke(nameof(SetSunMinAngleAtDawnDusk), NewValue); }
        public void SetSunLightSettings(PPSkyCreatorSunLightSettings InSunLightSettings) { Invoke(nameof(SetSunLightSettings), InSunLightSettings); }
        public void SetSunIntensity(float NewValue) { Invoke(nameof(SetSunIntensity), NewValue); }
        public void SetSunElevation(float NewValue) { Invoke(nameof(SetSunElevation), NewValue); }
        public void SetSunDuskOffsetTime(float NewValue) { Invoke(nameof(SetSunDuskOffsetTime), NewValue); }
        public void SetSunDiskSize(float NewValue) { Invoke(nameof(SetSunDiskSize), NewValue); }
        public void SetSunDawnOffsetTime(float NewValue) { Invoke(nameof(SetSunDawnOffsetTime), NewValue); }
        public void SetSunAzimuth(float NewValue) { Invoke(nameof(SetSunAzimuth), NewValue); }
        public void SetSunAtmosphereDiskColorScale(LinearColor NewValue) { Invoke(nameof(SetSunAtmosphereDiskColorScale), NewValue); }
        public void SetStarMapSettings(PPSkyCreatorStarMapSettings InStarMapSettings) { Invoke(nameof(SetStarMapSettings), InStarMapSettings); }
        public void SetStarMapAdditionalRotation(Vector NewValue) { Invoke(nameof(SetStarMapAdditionalRotation), NewValue); }
        public void SetSkyLightSettings(PPSkyCreatorSkyLightSettings InSkyLightSettings) { Invoke(nameof(SetSkyLightSettings), InSkyLightSettings); }
        public void SetSkyAtmosphereSettings(PPSkyCreatorSkyAtmosphereSettings InSkyAtmosphereSettings) { Invoke(nameof(SetSkyAtmosphereSettings), InSkyAtmosphereSettings); }
        public void SetRealPositionSettings(float InLatitude, float InLongitude, float InTimeZone, bool InbDaylightSavingTime, int InYear, int InMonth, int InDay) { Invoke(nameof(SetRealPositionSettings), InLatitude, InLongitude, InTimeZone, InbDaylightSavingTime, InYear, InMonth, InDay); }
        public void SetPostProcessSettings(PPSkyCreatorPostProcessSettings InPostProcessSettings) { Invoke(nameof(SetPostProcessSettings), InPostProcessSettings); }
        public void SetMoonSimplePositionSettings(float InMoonriseTime, float InMoonsetTime, float InMoonElevation, float InMoonAzimuth) { Invoke(nameof(SetMoonSimplePositionSettings), InMoonriseTime, InMoonsetTime, InMoonElevation, InMoonAzimuth); }
        public void SetMoonsetTime(float NewValue) { Invoke(nameof(SetMoonsetTime), NewValue); }
        public void SetMoonRotation(float NewValue) { Invoke(nameof(SetMoonRotation), NewValue); }
        public void SetMoonriseTime(float NewValue) { Invoke(nameof(SetMoonriseTime), NewValue); }
        public void SetMoonPhase(float NewValue) { Invoke(nameof(SetMoonPhase), NewValue); }
        public void SetMoonLightSettings(PPSkyCreatorMoonLightSettings InMoonLightSettings) { Invoke(nameof(SetMoonLightSettings), InMoonLightSettings); }
        public void SetMoonIntensity(float NewValue) { Invoke(nameof(SetMoonIntensity), NewValue); }
        public void SetMoonElevation(float NewValue) { Invoke(nameof(SetMoonElevation), NewValue); }
        public void SetMoonDiskSize(float NewValue) { Invoke(nameof(SetMoonDiskSize), NewValue); }
        public void SetMoonAzimuth(float NewValue) { Invoke(nameof(SetMoonAzimuth), NewValue); }
        public void SetMoonAtmosphereDiskColorScale(LinearColor NewValue) { Invoke(nameof(SetMoonAtmosphereDiskColorScale), NewValue); }
        public void SetMonth(int NewValue) { Invoke(nameof(SetMonth), NewValue); }
        public void SetLongitude(float NewValue) { Invoke(nameof(SetLongitude), NewValue); }
        public void SetLayerHeight(float NewValue) { Invoke(nameof(SetLayerHeight), NewValue); }
        public void SetLayerBottomAltitude(float NewValue) { Invoke(nameof(SetLayerBottomAltitude), NewValue); }
        public void SetLatitude(float NewValue) { Invoke(nameof(SetLatitude), NewValue); }
        public void SetExponentialHeightFogSettings(PPSkyCreatorExponentialHeightFogSettings InExponentialHeightFogSettings) { Invoke(nameof(SetExponentialHeightFogSettings), InExponentialHeightFogSettings); }
        public void SetEditorWeatherSettings(PPSkyCreatorWeatherSettings NewValue) { Invoke(nameof(SetEditorWeatherSettings), NewValue); }
        public void SetEditorWeatherPreset(PPSkyCreatorWeatherPreset NewValue) { Invoke(nameof(SetEditorWeatherPreset), NewValue); }
        public void SetEditorTimeOfDay(float NewValue) { Invoke(nameof(SetEditorTimeOfDay), NewValue); }
        public void SetDay(int NewValue) { Invoke(nameof(SetDay), NewValue); }
        public void SetCloudMapOffset(Vector2D NewValue) { Invoke(nameof(SetCloudMapOffset), NewValue); }
        public void SetbDaylightSavingTime(bool NewValue) { Invoke(nameof(SetbDaylightSavingTime), NewValue); }
        public void SetBackgroundCloudSettings(PPSkyCreatorBackgroundCloudSettings InBackgroundCloudSettings) { Invoke(nameof(SetBackgroundCloudSettings), InBackgroundCloudSettings); }
        public void RealtimeTimeOfDay(float DeltaSeconds, float DayCycleDuration) { Invoke(nameof(RealtimeTimeOfDay), DeltaSeconds, DayCycleDuration); }
        public void OnRep_UpdateWeather() { Invoke(nameof(OnRep_UpdateWeather)); }
        public void OnRep_UpdateTime() { Invoke(nameof(OnRep_UpdateTime)); }
        public void LerpWindSettings(PPSkyCreatorWindSettings InWindSettingsA, PPSkyCreatorWindSettings InWindSettingsB, float Alpha) { Invoke(nameof(LerpWindSettings), InWindSettingsA, InWindSettingsB, Alpha); }
        public void LerpWindIndependentSettings(PPSkyCreatorWindSettings InWindSettingsA, PPSkyCreatorWindSettings InWindSettingsB, float Alpha) { Invoke(nameof(LerpWindIndependentSettings), InWindSettingsA, InWindSettingsB, Alpha); }
        public void LerpWetnessAmount(float WetnessAmountA, float WetnessAmountB, float Alpha) { Invoke(nameof(LerpWetnessAmount), WetnessAmountA, WetnessAmountB, Alpha); }
        public void LerpWeatherSettings(PPSkyCreatorWeatherSettings InWeatherSettingsA, PPSkyCreatorWeatherSettings InWeatherSettingsB, float Alpha) { Invoke(nameof(LerpWeatherSettings), InWeatherSettingsA, InWeatherSettingsB, Alpha); }
        public void LerpWeatherMaterialFXSettings(PPSkyCreatorWeatherMaterialFXSettings InWeatherMaterialFXSettingsA, PPSkyCreatorWeatherMaterialFXSettings InWeatherMaterialFXSettingsB, float Alpha) { Invoke(nameof(LerpWeatherMaterialFXSettings), InWeatherMaterialFXSettingsA, InWeatherMaterialFXSettingsB, Alpha); }
        public void LerpWeatherFXSettings(PPSkyCreatorWeatherFXSettings InWeatherFXSettingsA, PPSkyCreatorWeatherFXSettings InWeatherFXSettingsB, float Alpha) { Invoke(nameof(LerpWeatherFXSettings), InWeatherFXSettingsA, InWeatherFXSettingsB, Alpha); }
        public void LerpVolumetricCloudSettings(PPSkyCreatorVolumetricCloudSettings InVolumetricCloudSettingsA, PPSkyCreatorVolumetricCloudSettings InVolumetricCloudSettingsB, float Alpha) { Invoke(nameof(LerpVolumetricCloudSettings), InVolumetricCloudSettingsA, InVolumetricCloudSettingsB, Alpha); }
        public void LerpSunLightSettings(PPSkyCreatorSunLightSettings InSunLightSettingsA, PPSkyCreatorSunLightSettings InSunLightSettingsB, float Alpha) { Invoke(nameof(LerpSunLightSettings), InSunLightSettingsA, InSunLightSettingsB, Alpha); }
        public void LerpStarMapSettings(PPSkyCreatorStarMapSettings InStarMapSettingsA, PPSkyCreatorStarMapSettings InStarMapSettingsB, float Alpha) { Invoke(nameof(LerpStarMapSettings), InStarMapSettingsA, InStarMapSettingsB, Alpha); }
        public void LerpSnowAmount(float SnowAmountA, float SnowAmountB, float Alpha) { Invoke(nameof(LerpSnowAmount), SnowAmountA, SnowAmountB, Alpha); }
        public void LerpSkyLightSettings(PPSkyCreatorSkyLightSettings InSkyLightSettingsA, PPSkyCreatorSkyLightSettings InSkyLightSettingsB, float Alpha) { Invoke(nameof(LerpSkyLightSettings), InSkyLightSettingsA, InSkyLightSettingsB, Alpha); }
        public void LerpSkyAtmosphereSettings(PPSkyCreatorSkyAtmosphereSettings InSkyAtmosphereSettingsA, PPSkyCreatorSkyAtmosphereSettings InSkyAtmosphereSettingsB, float Alpha) { Invoke(nameof(LerpSkyAtmosphereSettings), InSkyAtmosphereSettingsA, InSkyAtmosphereSettingsB, Alpha); }
        public void LerpPuddlesAmount(float PuddlesAmountA, float PuddlesAmountB, float Alpha) { Invoke(nameof(LerpPuddlesAmount), PuddlesAmountA, PuddlesAmountB, Alpha); }
        public void LerpPostProcessSettings(PPSkyCreatorPostProcessSettings InPostProcessSettingsA, PPSkyCreatorPostProcessSettings InPostProcessSettingsB, float Alpha) { Invoke(nameof(LerpPostProcessSettings), InPostProcessSettingsA, InPostProcessSettingsB, Alpha); }
        public void LerpMoonLightSettings(PPSkyCreatorMoonLightSettings InMoonLightSettingsA, PPSkyCreatorMoonLightSettings InMoonLightSettingsB, float Alpha) { Invoke(nameof(LerpMoonLightSettings), InMoonLightSettingsA, InMoonLightSettingsB, Alpha); }
        public void LerpExponentialHeightFogSettings(PPSkyCreatorExponentialHeightFogSettings InExponentialHeightFogSettingsA, PPSkyCreatorExponentialHeightFogSettings InExponentialHeightFogSettingsB, float Alpha) { Invoke(nameof(LerpExponentialHeightFogSettings), InExponentialHeightFogSettingsA, InExponentialHeightFogSettingsB, Alpha); }
        public void LerpBackgroundCloudSettings(PPSkyCreatorBackgroundCloudSettings InBackgroundCloudSettingsA, PPSkyCreatorBackgroundCloudSettings InBackgroundCloudSettingsB, float Alpha) { Invoke(nameof(LerpBackgroundCloudSettings), InBackgroundCloudSettingsA, InBackgroundCloudSettingsB, Alpha); }
        public PPSkyCreatorWindSettings GetWindSettings() { return Invoke<PPSkyCreatorWindSettings>(nameof(GetWindSettings)); }
        public PPSkyCreatorWeatherSettings GetWeatherSettings() { return Invoke<PPSkyCreatorWeatherSettings>(nameof(GetWeatherSettings)); }
        public PPSkyCreatorWeatherMaterialFXSettings GetWeatherMaterialFXSettings() { return Invoke<PPSkyCreatorWeatherMaterialFXSettings>(nameof(GetWeatherMaterialFXSettings)); }
        public PPSkyCreatorWeatherFXSettings GetWeatherFXSettings() { return Invoke<PPSkyCreatorWeatherFXSettings>(nameof(GetWeatherFXSettings)); }
        public PPSkyCreatorVolumetricCloudSettings GetVolumetricCloudSettings() { return Invoke<PPSkyCreatorVolumetricCloudSettings>(nameof(GetVolumetricCloudSettings)); }
        public float GetTime() { return Invoke<float>(nameof(GetTime)); }
        public Rotator GetSunPosition(float Time) { return Invoke<Rotator>(nameof(GetSunPosition), Time); }
        public PPSkyCreatorSunLightSettings GetSunLightSettings() { return Invoke<PPSkyCreatorSunLightSettings>(nameof(GetSunLightSettings)); }
        public PPSkyCreatorStarMapSettings GetStarMapSettings() { return Invoke<PPSkyCreatorStarMapSettings>(nameof(GetStarMapSettings)); }
        public Rotator GetStarMapRotation() { return Invoke<Rotator>(nameof(GetStarMapRotation)); }
        public PPSkyCreatorSkyLightSettings GetSkyLightSettings() { return Invoke<PPSkyCreatorSkyLightSettings>(nameof(GetSkyLightSettings)); }
        public PPSkyCreatorSkyAtmosphereSettings GetSkyAtmosphereSettings() { return Invoke<PPSkyCreatorSkyAtmosphereSettings>(nameof(GetSkyAtmosphereSettings)); }
        public PPSkyCreatorPostProcessSettings GetPostProcessSettings() { return Invoke<PPSkyCreatorPostProcessSettings>(nameof(GetPostProcessSettings)); }
        public Rotator GetMoonPosition(float Time) { return Invoke<Rotator>(nameof(GetMoonPosition), Time); }
        public float GetMoonPhase() { return Invoke<float>(nameof(GetMoonPhase)); }
        public PPSkyCreatorMoonLightSettings GetMoonLightSettings() { return Invoke<PPSkyCreatorMoonLightSettings>(nameof(GetMoonLightSettings)); }
        public Vector GetLastLightningPosition() { return Invoke<Vector>(nameof(GetLastLightningPosition)); }
        public PPSkyCreatorExponentialHeightFogSettings GetExponentialHeightFogSettings() { return Invoke<PPSkyCreatorExponentialHeightFogSettings>(nameof(GetExponentialHeightFogSettings)); }
        public float GetCloudDensityAtPosition(Vector Position) { return Invoke<float>(nameof(GetCloudDensityAtPosition), Position); }
        public PPSkyCreatorBackgroundCloudSettings GetBackgroundCloudSettings() { return Invoke<PPSkyCreatorBackgroundCloudSettings>(nameof(GetBackgroundCloudSettings)); }
        public bool FindLightningPosition(Vector Position, Vector OutPosition) { return Invoke<bool>(nameof(FindLightningPosition), Position, OutPosition); }
    }
    public class PPSkyCreatorFunctionLibrary : BlueprintFunctionLibrary
    {
        public PPSkyCreatorFunctionLibrary(nint addr) : base(addr) { }
        public float KilometersToCentimeters(float Value) { return Invoke<float>(nameof(KilometersToCentimeters), Value); }
        public bool IsApplicationForegroundNow() { return Invoke<bool>(nameof(IsApplicationForegroundNow)); }
        public PPCelestialPositionData GetRealSunPosition(float Latitude, float Longitude, float TimeZone, bool bIsDaylightSavingTime, DateTime DateTime) { return Invoke<PPCelestialPositionData>(nameof(GetRealSunPosition), Latitude, Longitude, TimeZone, bIsDaylightSavingTime, DateTime); }
        public PPCelestialPositionData GetRealMoonPosition(float Latitude, float Longitude, float TimeZone, bool bIsDaylightSavingTime, DateTime DateTime) { return Invoke<PPCelestialPositionData>(nameof(GetRealMoonPosition), Latitude, Longitude, TimeZone, bIsDaylightSavingTime, DateTime); }
        public float GetCloudDensityAtPosition(Object WorldContextObject, Vector Position, MaterialParameterCollection ParameterCollection, MaterialInterface Material, TextureRenderTarget2D RenderTarget) { return Invoke<float>(nameof(GetCloudDensityAtPosition), WorldContextObject, Position, ParameterCollection, Material, RenderTarget); }
        public bool FindLightningPosition(Object WorldContextObject, bool bSampleCloudDensity, int Samples, MaterialParameterCollection ParameterCollection, MaterialInterface Material, TextureRenderTarget2D RenderTarget, Vector Position, float InnerRadius, float OuterRadius, float MinHeight, float MaxHeight, float DensityThreshold, Vector OutPosition) { return Invoke<bool>(nameof(FindLightningPosition), WorldContextObject, bSampleCloudDensity, Samples, ParameterCollection, Material, RenderTarget, Position, InnerRadius, OuterRadius, MinHeight, MaxHeight, DensityThreshold, OutPosition); }
        public double ElevationRefraction(double F) { return Invoke<double>(nameof(ElevationRefraction), F); }
        public Texture2D DynamicConvertRenderTargetToTexture2D(TextureRenderTarget2D RenderTarget) { return Invoke<Texture2D>(nameof(DynamicConvertRenderTargetToTexture2D), RenderTarget); }
        public void CreateAndAssignMID(Object WorldContextObject, MaterialInterface InMaterial, MaterialInstanceDynamic InMID) { Invoke(nameof(CreateAndAssignMID), WorldContextObject, InMaterial, InMID); }
        public void ConvertRenderTargetToTexture2D(TextureRenderTarget2D RenderTarget, Texture2D Texture) { Invoke(nameof(ConvertRenderTargetToTexture2D), RenderTarget, Texture); }
        public bool CheckCloudDensityAtPosition(Object WorldContextObject, Vector Position, MaterialParameterCollection ParameterCollection, MaterialInterface Material, TextureRenderTarget2D RenderTarget) { return Invoke<bool>(nameof(CheckCloudDensityAtPosition), WorldContextObject, Position, ParameterCollection, Material, RenderTarget); }
        public float CentimetersToKilometers(float Value) { return Invoke<float>(nameof(CentimetersToKilometers), Value); }
    }
    public class PPSkyCreatorWeatherPreset : DataAsset
    {
        public PPSkyCreatorWeatherPreset(nint addr) : base(addr) { }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public PPSkyCreatorSkyAtmosphereSettings SkyAtmosphereSettings { get { return this[nameof(SkyAtmosphereSettings)].As<PPSkyCreatorSkyAtmosphereSettings>(); } set { this["SkyAtmosphereSettings"] = value; } }
        public PPSkyCreatorVolumetricCloudSettings VolumetricCloudSettings { get { return this[nameof(VolumetricCloudSettings)].As<PPSkyCreatorVolumetricCloudSettings>(); } set { this["VolumetricCloudSettings"] = value; } }
        public PPSkyCreatorBackgroundCloudSettings BackgroundCloudSettings { get { return this[nameof(BackgroundCloudSettings)].As<PPSkyCreatorBackgroundCloudSettings>(); } set { this["BackgroundCloudSettings"] = value; } }
        public PPSkyCreatorSkyLightSettings SkyLightSettings { get { return this[nameof(SkyLightSettings)].As<PPSkyCreatorSkyLightSettings>(); } set { this["SkyLightSettings"] = value; } }
        public PPSkyCreatorSunLightSettings SunLightSettings { get { return this[nameof(SunLightSettings)].As<PPSkyCreatorSunLightSettings>(); } set { this["SunLightSettings"] = value; } }
        public PPSkyCreatorMoonLightSettings MoonLightSettings { get { return this[nameof(MoonLightSettings)].As<PPSkyCreatorMoonLightSettings>(); } set { this["MoonLightSettings"] = value; } }
        public PPSkyCreatorExponentialHeightFogSettings ExponentialHeightFogSettings { get { return this[nameof(ExponentialHeightFogSettings)].As<PPSkyCreatorExponentialHeightFogSettings>(); } set { this["ExponentialHeightFogSettings"] = value; } }
        public PPSkyCreatorStarMapSettings StarMapSettings { get { return this[nameof(StarMapSettings)].As<PPSkyCreatorStarMapSettings>(); } set { this["StarMapSettings"] = value; } }
        public PPSkyCreatorWeatherFXSettings WeatherFXSettings { get { return this[nameof(WeatherFXSettings)].As<PPSkyCreatorWeatherFXSettings>(); } set { this["WeatherFXSettings"] = value; } }
        public PPSkyCreatorWeatherMaterialFXSettings WeatherMaterialFXSettings { get { return this[nameof(WeatherMaterialFXSettings)].As<PPSkyCreatorWeatherMaterialFXSettings>(); } set { this["WeatherMaterialFXSettings"] = value; } }
        public PPSkyCreatorWindSettings WindSettings { get { return this[nameof(WindSettings)].As<PPSkyCreatorWindSettings>(); } set { this["WindSettings"] = value; } }
        public PPSkyCreatorPostProcessSettings PostProcessSettings { get { return this[nameof(PostProcessSettings)].As<PPSkyCreatorPostProcessSettings>(); } set { this["PostProcessSettings"] = value; } }
        public PPSkyCreatorWeatherSettings GetWeatherPresetSettings() { return Invoke<PPSkyCreatorWeatherSettings>(nameof(GetWeatherPresetSettings)); }
    }
    public enum EPPSkyCreatorEditorWeatherType : int
    {
        EditorWeather_WeatherPreset = 0,
        EditorWeather_WeatherSettings = 1,
        EditorWeather_MAX = 2,
    }
    public enum EPPSkyCreatorSunPositionType : int
    {
        SunPositionType_Simple = 0,
        SunPositionType_Real = 1,
        SunPositionType_MAX = 2,
    }
    public enum EPPSkyCreatorMoonPositionType : int
    {
        MoonPositionType_Simple = 0,
        MoonPositionType_SimpleFixedElevation = 1,
        MoonPositionType_Real = 2,
        MoonPositionType_MAX = 3,
    }
    public enum EPPVolumetricCloudRenderTargetMode : int
    {
        VolumetricCloudRenderTargetMode_Default = 0,
        VolumetricCloudRenderTargetMode_Quality = 1,
        VolumetricCloudRenderTargetMode_Performance = 2,
        VolumetricCloudRenderTargetMode_MAX = 3,
    }
    public enum EPPVolumetricCloudNoiseShapeResolution : int
    {
        VolumetricCloudNoiseShapeResolution_65 = 0,
        VolumetricCloudNoiseShapeResolution_129 = 1,
        VolumetricCloudNoiseShapeResolution_257 = 2,
        VolumetricCloudNoiseShapeResolution_MAX = 3,
    }
    public enum EPPVolumetricCloudNoiseDetailResolution : int
    {
        VolumetricCloudNoiseDetailResolution_33 = 0,
        VolumetricCloudNoiseDetailResolution_65 = 1,
        VolumetricCloudNoiseDetailResolution_MAX = 2,
    }
    public enum EPPSkyCreatorStarMapRotationType : int
    {
        StarMapRotationType_NoRotation = 0,
        StarMapRotationType_FollowSun = 1,
        StarMapRotationType_FollowMoon = 2,
        StarMapRotationType_MAX = 3,
    }
    public class PPSkyCreatorLightningParameters : Object
    {
        public PPSkyCreatorLightningParameters(nint addr) : base(addr) { }
        public LinearColor Position { get { return this[nameof(Position)].As<LinearColor>(); } set { this["Position"] = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
    }
    public class PPCelestialPositionData : Object
    {
        public PPCelestialPositionData(nint addr) : base(addr) { }
        public float Elevation { get { return this[nameof(Elevation)].GetValue<float>(); } set { this[nameof(Elevation)].SetValue<float>(value); } }
        public float Azimuth { get { return this[nameof(Azimuth)].GetValue<float>(); } set { this[nameof(Azimuth)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorSkyAtmosphereSettings : Object
    {
        public PPSkyCreatorSkyAtmosphereSettings(nint addr) : base(addr) { }
        public float RayleighScatteringScale { get { return this[nameof(RayleighScatteringScale)].GetValue<float>(); } set { this[nameof(RayleighScatteringScale)].SetValue<float>(value); } }
        public LinearColor RayleighScattering { get { return this[nameof(RayleighScattering)].As<LinearColor>(); } set { this["RayleighScattering"] = value; } }
        public float RayleighExponentialDistribution { get { return this[nameof(RayleighExponentialDistribution)].GetValue<float>(); } set { this[nameof(RayleighExponentialDistribution)].SetValue<float>(value); } }
        public float MieScatteringScale { get { return this[nameof(MieScatteringScale)].GetValue<float>(); } set { this[nameof(MieScatteringScale)].SetValue<float>(value); } }
        public LinearColor MieScattering { get { return this[nameof(MieScattering)].As<LinearColor>(); } set { this["MieScattering"] = value; } }
        public float MieAbsorptionScale { get { return this[nameof(MieAbsorptionScale)].GetValue<float>(); } set { this[nameof(MieAbsorptionScale)].SetValue<float>(value); } }
        public LinearColor MieAbsorption { get { return this[nameof(MieAbsorption)].As<LinearColor>(); } set { this["MieAbsorption"] = value; } }
        public float MieAnisotropy { get { return this[nameof(MieAnisotropy)].GetValue<float>(); } set { this[nameof(MieAnisotropy)].SetValue<float>(value); } }
        public float MieExponentialDistribution { get { return this[nameof(MieExponentialDistribution)].GetValue<float>(); } set { this[nameof(MieExponentialDistribution)].SetValue<float>(value); } }
        public float AbsorptionScale { get { return this[nameof(AbsorptionScale)].GetValue<float>(); } set { this[nameof(AbsorptionScale)].SetValue<float>(value); } }
        public LinearColor Absorption { get { return this[nameof(Absorption)].As<LinearColor>(); } set { this["Absorption"] = value; } }
        public LinearColor SkyLuminanceFactor { get { return this[nameof(SkyLuminanceFactor)].As<LinearColor>(); } set { this["SkyLuminanceFactor"] = value; } }
        public LinearColor GroundAlbedo { get { return this[nameof(GroundAlbedo)].As<LinearColor>(); } set { this["GroundAlbedo"] = value; } }
        public float HeightFogContribution { get { return this[nameof(HeightFogContribution)].GetValue<float>(); } set { this[nameof(HeightFogContribution)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorVolumetricCloudSettings : Object
    {
        public PPSkyCreatorVolumetricCloudSettings(nint addr) : base(addr) { }
        public float StratusCoverage { get { return this[nameof(StratusCoverage)].GetValue<float>(); } set { this[nameof(StratusCoverage)].SetValue<float>(value); } }
        public float StratusCoverageVariation { get { return this[nameof(StratusCoverageVariation)].GetValue<float>(); } set { this[nameof(StratusCoverageVariation)].SetValue<float>(value); } }
        public float StratusHeightVariation { get { return this[nameof(StratusHeightVariation)].GetValue<float>(); } set { this[nameof(StratusHeightVariation)].SetValue<float>(value); } }
        public float StratocumulusCoverage { get { return this[nameof(StratocumulusCoverage)].GetValue<float>(); } set { this[nameof(StratocumulusCoverage)].SetValue<float>(value); } }
        public float StratocumulusCoverageVariation { get { return this[nameof(StratocumulusCoverageVariation)].GetValue<float>(); } set { this[nameof(StratocumulusCoverageVariation)].SetValue<float>(value); } }
        public float StratocumulusHeightVariation { get { return this[nameof(StratocumulusHeightVariation)].GetValue<float>(); } set { this[nameof(StratocumulusHeightVariation)].SetValue<float>(value); } }
        public float CumulusCoverage { get { return this[nameof(CumulusCoverage)].GetValue<float>(); } set { this[nameof(CumulusCoverage)].SetValue<float>(value); } }
        public float CumulusCoverageVariation { get { return this[nameof(CumulusCoverageVariation)].GetValue<float>(); } set { this[nameof(CumulusCoverageVariation)].SetValue<float>(value); } }
        public float CumulusHeightVariation { get { return this[nameof(CumulusHeightVariation)].GetValue<float>(); } set { this[nameof(CumulusHeightVariation)].SetValue<float>(value); } }
        public float CumulonimbusCoverage { get { return this[nameof(CumulonimbusCoverage)].GetValue<float>(); } set { this[nameof(CumulonimbusCoverage)].SetValue<float>(value); } }
        public float CumulonimbusAnvil { get { return this[nameof(CumulonimbusAnvil)].GetValue<float>(); } set { this[nameof(CumulonimbusAnvil)].SetValue<float>(value); } }
        public float CumulonimbusHeightVariation { get { return this[nameof(CumulonimbusHeightVariation)].GetValue<float>(); } set { this[nameof(CumulonimbusHeightVariation)].SetValue<float>(value); } }
        public float DensityBottom { get { return this[nameof(DensityBottom)].GetValue<float>(); } set { this[nameof(DensityBottom)].SetValue<float>(value); } }
        public float DensityMiddle { get { return this[nameof(DensityMiddle)].GetValue<float>(); } set { this[nameof(DensityMiddle)].SetValue<float>(value); } }
        public float DensityTop { get { return this[nameof(DensityTop)].GetValue<float>(); } set { this[nameof(DensityTop)].SetValue<float>(value); } }
        public LinearColor albedo { get { return this[nameof(albedo)].As<LinearColor>(); } set { this["albedo"] = value; } }
        public LinearColor GroundAlbedo { get { return this[nameof(GroundAlbedo)].As<LinearColor>(); } set { this["GroundAlbedo"] = value; } }
        public float BeersPowderIntensity { get { return this[nameof(BeersPowderIntensity)].GetValue<float>(); } set { this[nameof(BeersPowderIntensity)].SetValue<float>(value); } }
        public float BeersPowderDepth { get { return this[nameof(BeersPowderDepth)].GetValue<float>(); } set { this[nameof(BeersPowderDepth)].SetValue<float>(value); } }
        public float BottomOcclusion { get { return this[nameof(BottomOcclusion)].GetValue<float>(); } set { this[nameof(BottomOcclusion)].SetValue<float>(value); } }
        public float BottomOcclusionHeight { get { return this[nameof(BottomOcclusionHeight)].GetValue<float>(); } set { this[nameof(BottomOcclusionHeight)].SetValue<float>(value); } }
        public LinearColor NightEmissive { get { return this[nameof(NightEmissive)].As<LinearColor>(); } set { this["NightEmissive"] = value; } }
        public float PhaseG { get { return this[nameof(PhaseG)].GetValue<float>(); } set { this[nameof(PhaseG)].SetValue<float>(value); } }
        public float PhaseG2 { get { return this[nameof(PhaseG2)].GetValue<float>(); } set { this[nameof(PhaseG2)].SetValue<float>(value); } }
        public float PhaseBlend { get { return this[nameof(PhaseBlend)].GetValue<float>(); } set { this[nameof(PhaseBlend)].SetValue<float>(value); } }
        public float MultiScatteringContribution { get { return this[nameof(MultiScatteringContribution)].GetValue<float>(); } set { this[nameof(MultiScatteringContribution)].SetValue<float>(value); } }
        public float MultiScatteringOcclusion { get { return this[nameof(MultiScatteringOcclusion)].GetValue<float>(); } set { this[nameof(MultiScatteringOcclusion)].SetValue<float>(value); } }
        public float MultiScatteringEccentricity { get { return this[nameof(MultiScatteringEccentricity)].GetValue<float>(); } set { this[nameof(MultiScatteringEccentricity)].SetValue<float>(value); } }
        public float NoiseShapeIntensityA { get { return this[nameof(NoiseShapeIntensityA)].GetValue<float>(); } set { this[nameof(NoiseShapeIntensityA)].SetValue<float>(value); } }
        public float NoiseShapeIntensityB { get { return this[nameof(NoiseShapeIntensityB)].GetValue<float>(); } set { this[nameof(NoiseShapeIntensityB)].SetValue<float>(value); } }
        public float NoiseShapeIntensityC { get { return this[nameof(NoiseShapeIntensityC)].GetValue<float>(); } set { this[nameof(NoiseShapeIntensityC)].SetValue<float>(value); } }
        public float NoiseShapeIntensityD { get { return this[nameof(NoiseShapeIntensityD)].GetValue<float>(); } set { this[nameof(NoiseShapeIntensityD)].SetValue<float>(value); } }
        public float TurbulenceIntensity { get { return this[nameof(TurbulenceIntensity)].GetValue<float>(); } set { this[nameof(TurbulenceIntensity)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorBackgroundCloudSettings : Object
    {
        public PPSkyCreatorBackgroundCloudSettings(nint addr) : base(addr) { }
        public float BackgroundCloudsIntensity { get { return this[nameof(BackgroundCloudsIntensity)].GetValue<float>(); } set { this[nameof(BackgroundCloudsIntensity)].SetValue<float>(value); } }
        public LinearColor BackgroundCloudsColorTint { get { return this[nameof(BackgroundCloudsColorTint)].As<LinearColor>(); } set { this["BackgroundCloudsColorTint"] = value; } }
        public float BackgroundCloudsLayerA { get { return this[nameof(BackgroundCloudsLayerA)].GetValue<float>(); } set { this[nameof(BackgroundCloudsLayerA)].SetValue<float>(value); } }
        public float BackgroundCloudsLayerB { get { return this[nameof(BackgroundCloudsLayerB)].GetValue<float>(); } set { this[nameof(BackgroundCloudsLayerB)].SetValue<float>(value); } }
        public float BackgroundCloudsLayerC { get { return this[nameof(BackgroundCloudsLayerC)].GetValue<float>(); } set { this[nameof(BackgroundCloudsLayerC)].SetValue<float>(value); } }
        public float BackgroundCloudsLightningPhase { get { return this[nameof(BackgroundCloudsLightningPhase)].GetValue<float>(); } set { this[nameof(BackgroundCloudsLightningPhase)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorSkyLightSettings : Object
    {
        public PPSkyCreatorSkyLightSettings(nint addr) : base(addr) { }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public float NightIntensity { get { return this[nameof(NightIntensity)].GetValue<float>(); } set { this[nameof(NightIntensity)].SetValue<float>(value); } }
        public LinearColor LightColor { get { return this[nameof(LightColor)].As<LinearColor>(); } set { this["LightColor"] = value; } }
        public LinearColor LowerHemisphereColor { get { return this[nameof(LowerHemisphereColor)].As<LinearColor>(); } set { this["LowerHemisphereColor"] = value; } }
        public float CloudAmbientOcclusionStrength { get { return this[nameof(CloudAmbientOcclusionStrength)].GetValue<float>(); } set { this[nameof(CloudAmbientOcclusionStrength)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorSunLightSettings : Object
    {
        public PPSkyCreatorSunLightSettings(nint addr) : base(addr) { }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public LinearColor LightColor { get { return this[nameof(LightColor)].As<LinearColor>(); } set { this["LightColor"] = value; } }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public float VolumetricScatteringIntensity { get { return this[nameof(VolumetricScatteringIntensity)].GetValue<float>(); } set { this[nameof(VolumetricScatteringIntensity)].SetValue<float>(value); } }
        public LinearColor AtmosphereDiskColorScale { get { return this[nameof(AtmosphereDiskColorScale)].As<LinearColor>(); } set { this["AtmosphereDiskColorScale"] = value; } }
        public LinearColor CloudScatteredLuminanceScale { get { return this[nameof(CloudScatteredLuminanceScale)].As<LinearColor>(); } set { this["CloudScatteredLuminanceScale"] = value; } }
        public float CloudShadowStrength { get { return this[nameof(CloudShadowStrength)].GetValue<float>(); } set { this[nameof(CloudShadowStrength)].SetValue<float>(value); } }
        public float CloudShadowOnAtmosphereStrength { get { return this[nameof(CloudShadowOnAtmosphereStrength)].GetValue<float>(); } set { this[nameof(CloudShadowOnAtmosphereStrength)].SetValue<float>(value); } }
        public float CloudShadowOnSurfaceStrength { get { return this[nameof(CloudShadowOnSurfaceStrength)].GetValue<float>(); } set { this[nameof(CloudShadowOnSurfaceStrength)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorMoonLightSettings : Object
    {
        public PPSkyCreatorMoonLightSettings(nint addr) : base(addr) { }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public LinearColor LightColor { get { return this[nameof(LightColor)].As<LinearColor>(); } set { this["LightColor"] = value; } }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public float VolumetricScatteringIntensity { get { return this[nameof(VolumetricScatteringIntensity)].GetValue<float>(); } set { this[nameof(VolumetricScatteringIntensity)].SetValue<float>(value); } }
        public LinearColor AtmosphereDiskColorScale { get { return this[nameof(AtmosphereDiskColorScale)].As<LinearColor>(); } set { this["AtmosphereDiskColorScale"] = value; } }
        public LinearColor CloudScatteredLuminanceScale { get { return this[nameof(CloudScatteredLuminanceScale)].As<LinearColor>(); } set { this["CloudScatteredLuminanceScale"] = value; } }
        public float CloudShadowStrength { get { return this[nameof(CloudShadowStrength)].GetValue<float>(); } set { this[nameof(CloudShadowStrength)].SetValue<float>(value); } }
        public float CloudShadowOnAtmosphereStrength { get { return this[nameof(CloudShadowOnAtmosphereStrength)].GetValue<float>(); } set { this[nameof(CloudShadowOnAtmosphereStrength)].SetValue<float>(value); } }
        public float CloudShadowOnSurfaceStrength { get { return this[nameof(CloudShadowOnSurfaceStrength)].GetValue<float>(); } set { this[nameof(CloudShadowOnSurfaceStrength)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorExponentialHeightFogSettings : Object
    {
        public PPSkyCreatorExponentialHeightFogSettings(nint addr) : base(addr) { }
        public float FogDensity { get { return this[nameof(FogDensity)].GetValue<float>(); } set { this[nameof(FogDensity)].SetValue<float>(value); } }
        public float FogHeightFalloff { get { return this[nameof(FogHeightFalloff)].GetValue<float>(); } set { this[nameof(FogHeightFalloff)].SetValue<float>(value); } }
        public LinearColor FogInscatteringColor { get { return this[nameof(FogInscatteringColor)].As<LinearColor>(); } set { this["FogInscatteringColor"] = value; } }
        public float FogStartDistance { get { return this[nameof(FogStartDistance)].GetValue<float>(); } set { this[nameof(FogStartDistance)].SetValue<float>(value); } }
        public float SecondFogDensity { get { return this[nameof(SecondFogDensity)].GetValue<float>(); } set { this[nameof(SecondFogDensity)].SetValue<float>(value); } }
        public float SecondFogHeightFalloff { get { return this[nameof(SecondFogHeightFalloff)].GetValue<float>(); } set { this[nameof(SecondFogHeightFalloff)].SetValue<float>(value); } }
        public float DirectionalInscatteringExponent { get { return this[nameof(DirectionalInscatteringExponent)].GetValue<float>(); } set { this[nameof(DirectionalInscatteringExponent)].SetValue<float>(value); } }
        public float DirectionalInscatteringStartDistance { get { return this[nameof(DirectionalInscatteringStartDistance)].GetValue<float>(); } set { this[nameof(DirectionalInscatteringStartDistance)].SetValue<float>(value); } }
        public LinearColor DirectionalInscatteringColor { get { return this[nameof(DirectionalInscatteringColor)].As<LinearColor>(); } set { this["DirectionalInscatteringColor"] = value; } }
        public float VolumetricFogScatteringDistribution { get { return this[nameof(VolumetricFogScatteringDistribution)].GetValue<float>(); } set { this[nameof(VolumetricFogScatteringDistribution)].SetValue<float>(value); } }
        public LinearColor VolumetricFogAlbedo { get { return this[nameof(VolumetricFogAlbedo)].As<LinearColor>(); } set { this["VolumetricFogAlbedo"] = value; } }
        public LinearColor VolumetricFogEmissive { get { return this[nameof(VolumetricFogEmissive)].As<LinearColor>(); } set { this["VolumetricFogEmissive"] = value; } }
        public float VolumetricFogExtinctionScale { get { return this[nameof(VolumetricFogExtinctionScale)].GetValue<float>(); } set { this[nameof(VolumetricFogExtinctionScale)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorStarMapSettings : Object
    {
        public PPSkyCreatorStarMapSettings(nint addr) : base(addr) { }
        public float StarMapIntensity { get { return this[nameof(StarMapIntensity)].GetValue<float>(); } set { this[nameof(StarMapIntensity)].SetValue<float>(value); } }
        public LinearColor StarMapColorTint { get { return this[nameof(StarMapColorTint)].As<LinearColor>(); } set { this["StarMapColorTint"] = value; } }
        public float StarMapTwinkleIntensity { get { return this[nameof(StarMapTwinkleIntensity)].GetValue<float>(); } set { this[nameof(StarMapTwinkleIntensity)].SetValue<float>(value); } }
        public float StarMapTwinkleSaturation { get { return this[nameof(StarMapTwinkleSaturation)].GetValue<float>(); } set { this[nameof(StarMapTwinkleSaturation)].SetValue<float>(value); } }
        public float StarMapTwinkleSpeed { get { return this[nameof(StarMapTwinkleSpeed)].GetValue<float>(); } set { this[nameof(StarMapTwinkleSpeed)].SetValue<float>(value); } }
        public float StarMapHorizonThreshold { get { return this[nameof(StarMapHorizonThreshold)].GetValue<float>(); } set { this[nameof(StarMapHorizonThreshold)].SetValue<float>(value); } }
        public float StarMapAtmosphereThreshold { get { return this[nameof(StarMapAtmosphereThreshold)].GetValue<float>(); } set { this[nameof(StarMapAtmosphereThreshold)].SetValue<float>(value); } }
        public LinearColor NightHorizonColor { get { return this[nameof(NightHorizonColor)].As<LinearColor>(); } set { this["NightHorizonColor"] = value; } }
        public LinearColor NightZenithColor { get { return this[nameof(NightZenithColor)].As<LinearColor>(); } set { this["NightZenithColor"] = value; } }
    }
    public class PPSkyCreatorWeatherFXSettings : Object
    {
        public PPSkyCreatorWeatherFXSettings(nint addr) : base(addr) { }
        public float RainAmount { get { return this[nameof(RainAmount)].GetValue<float>(); } set { this[nameof(RainAmount)].SetValue<float>(value); } }
        public LinearColor RainColor { get { return this[nameof(RainColor)].As<LinearColor>(); } set { this["RainColor"] = value; } }
        public float RainGravity { get { return this[nameof(RainGravity)].GetValue<float>(); } set { this[nameof(RainGravity)].SetValue<float>(value); } }
        public float RainLifetimeMin { get { return this[nameof(RainLifetimeMin)].GetValue<float>(); } set { this[nameof(RainLifetimeMin)].SetValue<float>(value); } }
        public float RainLifetimeMax { get { return this[nameof(RainLifetimeMax)].GetValue<float>(); } set { this[nameof(RainLifetimeMax)].SetValue<float>(value); } }
        public float RainSizeMin { get { return this[nameof(RainSizeMin)].GetValue<float>(); } set { this[nameof(RainSizeMin)].SetValue<float>(value); } }
        public float RainSizeMax { get { return this[nameof(RainSizeMax)].GetValue<float>(); } set { this[nameof(RainSizeMax)].SetValue<float>(value); } }
        public float RainSplashLifetimeMin { get { return this[nameof(RainSplashLifetimeMin)].GetValue<float>(); } set { this[nameof(RainSplashLifetimeMin)].SetValue<float>(value); } }
        public float RainSplashLifetimeMax { get { return this[nameof(RainSplashLifetimeMax)].GetValue<float>(); } set { this[nameof(RainSplashLifetimeMax)].SetValue<float>(value); } }
        public Vector2D RainSplashSizeMin { get { return this[nameof(RainSplashSizeMin)].As<Vector2D>(); } set { this["RainSplashSizeMin"] = value; } }
        public Vector2D RainSplashSizeMax { get { return this[nameof(RainSplashSizeMax)].As<Vector2D>(); } set { this["RainSplashSizeMax"] = value; } }
        public float SnowAmount { get { return this[nameof(SnowAmount)].GetValue<float>(); } set { this[nameof(SnowAmount)].SetValue<float>(value); } }
        public LinearColor SnowColor { get { return this[nameof(SnowColor)].As<LinearColor>(); } set { this["SnowColor"] = value; } }
        public float SnowGravity { get { return this[nameof(SnowGravity)].GetValue<float>(); } set { this[nameof(SnowGravity)].SetValue<float>(value); } }
        public float SnowTurbulence { get { return this[nameof(SnowTurbulence)].GetValue<float>(); } set { this[nameof(SnowTurbulence)].SetValue<float>(value); } }
        public float SnowLifetimeMin { get { return this[nameof(SnowLifetimeMin)].GetValue<float>(); } set { this[nameof(SnowLifetimeMin)].SetValue<float>(value); } }
        public float SnowLifetimeMax { get { return this[nameof(SnowLifetimeMax)].GetValue<float>(); } set { this[nameof(SnowLifetimeMax)].SetValue<float>(value); } }
        public float SnowSizeMin { get { return this[nameof(SnowSizeMin)].GetValue<float>(); } set { this[nameof(SnowSizeMin)].SetValue<float>(value); } }
        public float SnowSizeMax { get { return this[nameof(SnowSizeMax)].GetValue<float>(); } set { this[nameof(SnowSizeMax)].SetValue<float>(value); } }
        public bool EnableLightnings { get { return this[nameof(EnableLightnings)].Flag; } set { this[nameof(EnableLightnings)].Flag = value; } }
        public float LightningSpawnIntervalMin { get { return this[nameof(LightningSpawnIntervalMin)].GetValue<float>(); } set { this[nameof(LightningSpawnIntervalMin)].SetValue<float>(value); } }
        public float LightningSpawnIntervalMax { get { return this[nameof(LightningSpawnIntervalMax)].GetValue<float>(); } set { this[nameof(LightningSpawnIntervalMax)].SetValue<float>(value); } }
        public LinearColor LightningColorMin { get { return this[nameof(LightningColorMin)].As<LinearColor>(); } set { this["LightningColorMin"] = value; } }
        public LinearColor LightningColorMax { get { return this[nameof(LightningColorMax)].As<LinearColor>(); } set { this["LightningColorMax"] = value; } }
        public float LightningLifetime { get { return this[nameof(LightningLifetime)].GetValue<float>(); } set { this[nameof(LightningLifetime)].SetValue<float>(value); } }
        public float LightningBoltSpawnChance { get { return this[nameof(LightningBoltSpawnChance)].GetValue<float>(); } set { this[nameof(LightningBoltSpawnChance)].SetValue<float>(value); } }
        public float LightningBoltWidthMin { get { return this[nameof(LightningBoltWidthMin)].GetValue<float>(); } set { this[nameof(LightningBoltWidthMin)].SetValue<float>(value); } }
        public float LightningBoltWidthMax { get { return this[nameof(LightningBoltWidthMax)].GetValue<float>(); } set { this[nameof(LightningBoltWidthMax)].SetValue<float>(value); } }
        public float LightningBoltLengthMin { get { return this[nameof(LightningBoltLengthMin)].GetValue<float>(); } set { this[nameof(LightningBoltLengthMin)].SetValue<float>(value); } }
        public float LightningBoltLengthMax { get { return this[nameof(LightningBoltLengthMax)].GetValue<float>(); } set { this[nameof(LightningBoltLengthMax)].SetValue<float>(value); } }
        public float LightningBoltCurveFrequency { get { return this[nameof(LightningBoltCurveFrequency)].GetValue<float>(); } set { this[nameof(LightningBoltCurveFrequency)].SetValue<float>(value); } }
        public float LightningBoltCurveStrengthMin { get { return this[nameof(LightningBoltCurveStrengthMin)].GetValue<float>(); } set { this[nameof(LightningBoltCurveStrengthMin)].SetValue<float>(value); } }
        public float LightningBoltCurveStrengthMax { get { return this[nameof(LightningBoltCurveStrengthMax)].GetValue<float>(); } set { this[nameof(LightningBoltCurveStrengthMax)].SetValue<float>(value); } }
        public float LightningBoltJitterStrength { get { return this[nameof(LightningBoltJitterStrength)].GetValue<float>(); } set { this[nameof(LightningBoltJitterStrength)].SetValue<float>(value); } }
        public float LightningBranchSpawnChance { get { return this[nameof(LightningBranchSpawnChance)].GetValue<float>(); } set { this[nameof(LightningBranchSpawnChance)].SetValue<float>(value); } }
        public float LightningBranchScaleMin { get { return this[nameof(LightningBranchScaleMin)].GetValue<float>(); } set { this[nameof(LightningBranchScaleMin)].SetValue<float>(value); } }
        public float LightningBranchScaleMax { get { return this[nameof(LightningBranchScaleMax)].GetValue<float>(); } set { this[nameof(LightningBranchScaleMax)].SetValue<float>(value); } }
        public float RainbowAmount { get { return this[nameof(RainbowAmount)].GetValue<float>(); } set { this[nameof(RainbowAmount)].SetValue<float>(value); } }
        public LinearColor RainbowColor { get { return this[nameof(RainbowColor)].As<LinearColor>(); } set { this["RainbowColor"] = value; } }
        public float RainbowRadius { get { return this[nameof(RainbowRadius)].GetValue<float>(); } set { this[nameof(RainbowRadius)].SetValue<float>(value); } }
        public float RainbowThickness { get { return this[nameof(RainbowThickness)].GetValue<float>(); } set { this[nameof(RainbowThickness)].SetValue<float>(value); } }
        public LinearColor SecondaryRainbowColor { get { return this[nameof(SecondaryRainbowColor)].As<LinearColor>(); } set { this["SecondaryRainbowColor"] = value; } }
        public float SecondaryRainbowRadius { get { return this[nameof(SecondaryRainbowRadius)].GetValue<float>(); } set { this[nameof(SecondaryRainbowRadius)].SetValue<float>(value); } }
        public float SecondaryRainbowThickness { get { return this[nameof(SecondaryRainbowThickness)].GetValue<float>(); } set { this[nameof(SecondaryRainbowThickness)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorWeatherMaterialFXSettings : Object
    {
        public PPSkyCreatorWeatherMaterialFXSettings(nint addr) : base(addr) { }
        public float WetnessAmount { get { return this[nameof(WetnessAmount)].GetValue<float>(); } set { this[nameof(WetnessAmount)].SetValue<float>(value); } }
        public LinearColor WetnessColor { get { return this[nameof(WetnessColor)].As<LinearColor>(); } set { this["WetnessColor"] = value; } }
        public float PuddlesAmount { get { return this[nameof(PuddlesAmount)].GetValue<float>(); } set { this[nameof(PuddlesAmount)].SetValue<float>(value); } }
        public LinearColor PuddlesColor { get { return this[nameof(PuddlesColor)].As<LinearColor>(); } set { this["PuddlesColor"] = value; } }
        public float RainRipplesAmount { get { return this[nameof(RainRipplesAmount)].GetValue<float>(); } set { this[nameof(RainRipplesAmount)].SetValue<float>(value); } }
        public float RainRipplesIntensity { get { return this[nameof(RainRipplesIntensity)].GetValue<float>(); } set { this[nameof(RainRipplesIntensity)].SetValue<float>(value); } }
        public float RainRipplesForceMinRadius { get { return this[nameof(RainRipplesForceMinRadius)].GetValue<float>(); } set { this[nameof(RainRipplesForceMinRadius)].SetValue<float>(value); } }
        public float RainRipplesForceMaxRadius { get { return this[nameof(RainRipplesForceMaxRadius)].GetValue<float>(); } set { this[nameof(RainRipplesForceMaxRadius)].SetValue<float>(value); } }
        public float RainRipplesRingsNumber { get { return this[nameof(RainRipplesRingsNumber)].GetValue<float>(); } set { this[nameof(RainRipplesRingsNumber)].SetValue<float>(value); } }
        public float RainRipplesRingsDelay { get { return this[nameof(RainRipplesRingsDelay)].GetValue<float>(); } set { this[nameof(RainRipplesRingsDelay)].SetValue<float>(value); } }
        public float RainRipplesDamping { get { return this[nameof(RainRipplesDamping)].GetValue<float>(); } set { this[nameof(RainRipplesDamping)].SetValue<float>(value); } }
        public float WindRipplesIntensity { get { return this[nameof(WindRipplesIntensity)].GetValue<float>(); } set { this[nameof(WindRipplesIntensity)].SetValue<float>(value); } }
        public float WindRipplesSpeed { get { return this[nameof(WindRipplesSpeed)].GetValue<float>(); } set { this[nameof(WindRipplesSpeed)].SetValue<float>(value); } }
        public float SnowAmount { get { return this[nameof(SnowAmount)].GetValue<float>(); } set { this[nameof(SnowAmount)].SetValue<float>(value); } }
        public LinearColor SnowColor { get { return this[nameof(SnowColor)].As<LinearColor>(); } set { this["SnowColor"] = value; } }
        public float SnowIntensity { get { return this[nameof(SnowIntensity)].GetValue<float>(); } set { this[nameof(SnowIntensity)].SetValue<float>(value); } }
        public float SnowSparklesThreshold { get { return this[nameof(SnowSparklesThreshold)].GetValue<float>(); } set { this[nameof(SnowSparklesThreshold)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorWindSettings : Object
    {
        public PPSkyCreatorWindSettings(nint addr) : base(addr) { }
        public float CloudWindDirection { get { return this[nameof(CloudWindDirection)].GetValue<float>(); } set { this[nameof(CloudWindDirection)].SetValue<float>(value); } }
        public float CloudWindSpeed { get { return this[nameof(CloudWindSpeed)].GetValue<float>(); } set { this[nameof(CloudWindSpeed)].SetValue<float>(value); } }
        public float CloudNoiseShapeWindDirection { get { return this[nameof(CloudNoiseShapeWindDirection)].GetValue<float>(); } set { this[nameof(CloudNoiseShapeWindDirection)].SetValue<float>(value); } }
        public float CloudNoiseShapeWindSpeedHorizontal { get { return this[nameof(CloudNoiseShapeWindSpeedHorizontal)].GetValue<float>(); } set { this[nameof(CloudNoiseShapeWindSpeedHorizontal)].SetValue<float>(value); } }
        public float CloudNoiseDetailWindSpeedVertical { get { return this[nameof(CloudNoiseDetailWindSpeedVertical)].GetValue<float>(); } set { this[nameof(CloudNoiseDetailWindSpeedVertical)].SetValue<float>(value); } }
        public float PrecipitationWindDirection { get { return this[nameof(PrecipitationWindDirection)].GetValue<float>(); } set { this[nameof(PrecipitationWindDirection)].SetValue<float>(value); } }
        public float PrecipitationWindSpeed { get { return this[nameof(PrecipitationWindSpeed)].GetValue<float>(); } set { this[nameof(PrecipitationWindSpeed)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorPostProcessSettings : Object
    {
        public PPSkyCreatorPostProcessSettings(nint addr) : base(addr) { }
        public float BloomIntensity { get { return this[nameof(BloomIntensity)].GetValue<float>(); } set { this[nameof(BloomIntensity)].SetValue<float>(value); } }
        public float BloomThreshold { get { return this[nameof(BloomThreshold)].GetValue<float>(); } set { this[nameof(BloomThreshold)].SetValue<float>(value); } }
        public float ExposureCompensation { get { return this[nameof(ExposureCompensation)].GetValue<float>(); } set { this[nameof(ExposureCompensation)].SetValue<float>(value); } }
    }
    public class PPSkyCreatorWeatherSettings : Object
    {
        public PPSkyCreatorWeatherSettings(nint addr) : base(addr) { }
        public PPSkyCreatorSkyAtmosphereSettings SkyAtmosphereSettings { get { return this[nameof(SkyAtmosphereSettings)].As<PPSkyCreatorSkyAtmosphereSettings>(); } set { this["SkyAtmosphereSettings"] = value; } }
        public PPSkyCreatorVolumetricCloudSettings VolumetricCloudSettings { get { return this[nameof(VolumetricCloudSettings)].As<PPSkyCreatorVolumetricCloudSettings>(); } set { this["VolumetricCloudSettings"] = value; } }
        public PPSkyCreatorBackgroundCloudSettings BackgroundCloudSettings { get { return this[nameof(BackgroundCloudSettings)].As<PPSkyCreatorBackgroundCloudSettings>(); } set { this["BackgroundCloudSettings"] = value; } }
        public PPSkyCreatorSkyLightSettings SkyLightSettings { get { return this[nameof(SkyLightSettings)].As<PPSkyCreatorSkyLightSettings>(); } set { this["SkyLightSettings"] = value; } }
        public PPSkyCreatorSunLightSettings SunLightSettings { get { return this[nameof(SunLightSettings)].As<PPSkyCreatorSunLightSettings>(); } set { this["SunLightSettings"] = value; } }
        public PPSkyCreatorMoonLightSettings MoonLightSettings { get { return this[nameof(MoonLightSettings)].As<PPSkyCreatorMoonLightSettings>(); } set { this["MoonLightSettings"] = value; } }
        public PPSkyCreatorExponentialHeightFogSettings ExponentialHeightFogSettings { get { return this[nameof(ExponentialHeightFogSettings)].As<PPSkyCreatorExponentialHeightFogSettings>(); } set { this["ExponentialHeightFogSettings"] = value; } }
        public PPSkyCreatorStarMapSettings StarMapSettings { get { return this[nameof(StarMapSettings)].As<PPSkyCreatorStarMapSettings>(); } set { this["StarMapSettings"] = value; } }
        public PPSkyCreatorWeatherFXSettings WeatherFXSettings { get { return this[nameof(WeatherFXSettings)].As<PPSkyCreatorWeatherFXSettings>(); } set { this["WeatherFXSettings"] = value; } }
        public PPSkyCreatorWeatherMaterialFXSettings WeatherMaterialFXSettings { get { return this[nameof(WeatherMaterialFXSettings)].As<PPSkyCreatorWeatherMaterialFXSettings>(); } set { this["WeatherMaterialFXSettings"] = value; } }
        public PPSkyCreatorWindSettings WindSettings { get { return this[nameof(WindSettings)].As<PPSkyCreatorWindSettings>(); } set { this["WindSettings"] = value; } }
        public PPSkyCreatorPostProcessSettings PostProcessSettings { get { return this[nameof(PostProcessSettings)].As<PPSkyCreatorPostProcessSettings>(); } set { this["PostProcessSettings"] = value; } }
    }
}
