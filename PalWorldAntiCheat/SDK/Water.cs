using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AIModuleSDK;
using SDK.Script.NiagaraSDK;
using SDK.Script.PhysicsCoreSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.WaterSDK
{
    public class BuoyancyComponent : ActorComponent
    {
        public BuoyancyComponent(nint addr) : base(addr) { }
        public Array<SphericalPontoon> Pontoons { get { return new Array<SphericalPontoon>(this[nameof(Pontoons)].Address); } }
        public Object OnEnteredWaterDelegate { get { return this[nameof(OnEnteredWaterDelegate)]; } set { this[nameof(OnEnteredWaterDelegate)] = value; } }
        public Object OnExitedWaterDelegate { get { return this[nameof(OnExitedWaterDelegate)]; } set { this[nameof(OnExitedWaterDelegate)] = value; } }
        public BuoyancyData BuoyancyData { get { return this[nameof(BuoyancyData)].As<BuoyancyData>(); } set { this["BuoyancyData"] = value; } }
        public Array<WaterBodyComponent> CurrentWaterBodyComponents { get { return new Array<WaterBodyComponent>(this[nameof(CurrentWaterBodyComponents)].Address); } }
        public PrimitiveComponent SimulatingComponent { get { return this[nameof(SimulatingComponent)].As<PrimitiveComponent>(); } set { this["SimulatingComponent"] = value; } }
        public void OnPontoonExitedWater(SphericalPontoon Pontoon) { Invoke(nameof(OnPontoonExitedWater), Pontoon); }
        public void OnPontoonEnteredWater(SphericalPontoon Pontoon) { Invoke(nameof(OnPontoonEnteredWater), Pontoon); }
        public bool IsOverlappingWaterBody() { return Invoke<bool>(nameof(IsOverlappingWaterBody)); }
        public bool IsInWaterBody() { return Invoke<bool>(nameof(IsInWaterBody)); }
        public void GetLastWaterSurfaceInfo(Vector OutWaterPlaneLocation, Vector OutWaterPlaneNormal, Vector OutWaterSurfacePosition, float OutWaterDepth, int OutWaterBodyIdx, Vector OutWaterVelocity) { Invoke(nameof(GetLastWaterSurfaceInfo), OutWaterPlaneLocation, OutWaterPlaneNormal, OutWaterSurfacePosition, OutWaterDepth, OutWaterBodyIdx, OutWaterVelocity); }
        public Array<WaterBodyComponent> GetCurrentWaterBodyComponents() { return Invoke<Array<WaterBodyComponent>>(nameof(GetCurrentWaterBodyComponents)); }
    }
    public class BuoyancyManager : Actor
    {
        public BuoyancyManager(nint addr) : base(addr) { }
        public Array<BuoyancyComponent> BuoyancyComponents { get { return new Array<BuoyancyComponent>(this[nameof(BuoyancyComponents)].Address); } }
        public bool GetBuoyancyComponentManager(Object WorldContextObject, BuoyancyManager Manager) { return Invoke<bool>(nameof(GetBuoyancyComponentManager), WorldContextObject, Manager); }
    }
    public class EnvQueryTest_InsideWaterBody : EnvQueryTest
    {
        public EnvQueryTest_InsideWaterBody(nint addr) : base(addr) { }
        public bool bIncludeWaves { get { return this[nameof(bIncludeWaves)].Flag; } set { this[nameof(bIncludeWaves)].Flag = value; } }
        public bool bSimpleWaves { get { return this[nameof(bSimpleWaves)].Flag; } set { this[nameof(bSimpleWaves)].Flag = value; } }
        public bool bIgnoreExclusionVolumes { get { return this[nameof(bIgnoreExclusionVolumes)].Flag; } set { this[nameof(bIgnoreExclusionVolumes)].Flag = value; } }
    }
    public class GerstnerWaterWaveGeneratorBase : Object
    {
        public GerstnerWaterWaveGeneratorBase(nint addr) : base(addr) { }
        public void GenerateGerstnerWaves(Array<GerstnerWave> OutWaves) { Invoke(nameof(GenerateGerstnerWaves), OutWaves); }
    }
    public class GerstnerWaterWaveGeneratorSimple : GerstnerWaterWaveGeneratorBase
    {
        public GerstnerWaterWaveGeneratorSimple(nint addr) : base(addr) { }
        public int NumWaves { get { return this[nameof(NumWaves)].GetValue<int>(); } set { this[nameof(NumWaves)].SetValue<int>(value); } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public float Randomness { get { return this[nameof(Randomness)].GetValue<float>(); } set { this[nameof(Randomness)].SetValue<float>(value); } }
        public float MinWavelength { get { return this[nameof(MinWavelength)].GetValue<float>(); } set { this[nameof(MinWavelength)].SetValue<float>(value); } }
        public float MaxWavelength { get { return this[nameof(MaxWavelength)].GetValue<float>(); } set { this[nameof(MaxWavelength)].SetValue<float>(value); } }
        public float WavelengthFalloff { get { return this[nameof(WavelengthFalloff)].GetValue<float>(); } set { this[nameof(WavelengthFalloff)].SetValue<float>(value); } }
        public float MinAmplitude { get { return this[nameof(MinAmplitude)].GetValue<float>(); } set { this[nameof(MinAmplitude)].SetValue<float>(value); } }
        public float MaxAmplitude { get { return this[nameof(MaxAmplitude)].GetValue<float>(); } set { this[nameof(MaxAmplitude)].SetValue<float>(value); } }
        public float AmplitudeFalloff { get { return this[nameof(AmplitudeFalloff)].GetValue<float>(); } set { this[nameof(AmplitudeFalloff)].SetValue<float>(value); } }
        public float WindAngleDeg { get { return this[nameof(WindAngleDeg)].GetValue<float>(); } set { this[nameof(WindAngleDeg)].SetValue<float>(value); } }
        public float DirectionAngularSpreadDeg { get { return this[nameof(DirectionAngularSpreadDeg)].GetValue<float>(); } set { this[nameof(DirectionAngularSpreadDeg)].SetValue<float>(value); } }
        public float SmallWaveSteepness { get { return this[nameof(SmallWaveSteepness)].GetValue<float>(); } set { this[nameof(SmallWaveSteepness)].SetValue<float>(value); } }
        public float LargeWaveSteepness { get { return this[nameof(LargeWaveSteepness)].GetValue<float>(); } set { this[nameof(LargeWaveSteepness)].SetValue<float>(value); } }
        public float SteepnessFalloff { get { return this[nameof(SteepnessFalloff)].GetValue<float>(); } set { this[nameof(SteepnessFalloff)].SetValue<float>(value); } }
    }
    public class GerstnerWaterWaveGeneratorSpectrum : GerstnerWaterWaveGeneratorBase
    {
        public GerstnerWaterWaveGeneratorSpectrum(nint addr) : base(addr) { }
        public EWaveSpectrumType SpectrumType { get { return (EWaveSpectrumType)this[nameof(SpectrumType)].GetValue<int>(); } set { this[nameof(SpectrumType)].SetValue<int>((int)value); } }
        public Array<GerstnerWaveOctave> Octaves { get { return new Array<GerstnerWaveOctave>(this[nameof(Octaves)].Address); } }
    }
    public class WaterWavesBase : Object
    {
        public WaterWavesBase(nint addr) : base(addr) { }
    }
    public class WaterWaves : WaterWavesBase
    {
        public WaterWaves(nint addr) : base(addr) { }
    }
    public class GerstnerWaterWaves : WaterWaves
    {
        public GerstnerWaterWaves(nint addr) : base(addr) { }
        public GerstnerWaterWaveGeneratorBase GerstnerWaveGenerator { get { return this[nameof(GerstnerWaveGenerator)].As<GerstnerWaterWaveGeneratorBase>(); } set { this["GerstnerWaveGenerator"] = value; } }
        public Array<GerstnerWave> GerstnerWaves { get { return new Array<GerstnerWave>(this[nameof(GerstnerWaves)].Address); } }
        public float MaxWaveHeight { get { return this[nameof(MaxWaveHeight)].GetValue<float>(); } set { this[nameof(MaxWaveHeight)].SetValue<float>(value); } }
    }
    public class GerstnerWaterWaveSubsystem : EngineSubsystem
    {
        public GerstnerWaterWaveSubsystem(nint addr) : base(addr) { }
    }
    public class LakeCollisionComponent : PrimitiveComponent
    {
        public LakeCollisionComponent(nint addr) : base(addr) { }
        public BodySetup CachedBodySetup { get { return this[nameof(CachedBodySetup)].As<BodySetup>(); } set { this["CachedBodySetup"] = value; } }
        public Vector BoxExtent { get { return this[nameof(BoxExtent)].As<Vector>(); } set { this["BoxExtent"] = value; } }
    }
    public class NiagaraDataInterfaceWater : NiagaraDataInterface
    {
        public NiagaraDataInterfaceWater(nint addr) : base(addr) { }
        public WaterBodyComponent SourceBodyComponent { get { return this[nameof(SourceBodyComponent)].As<WaterBodyComponent>(); } set { this["SourceBodyComponent"] = value; } }
    }
    public class NiagaraWaterFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraWaterFunctionLibrary(nint addr) : base(addr) { }
        public void SetWaterBodyComponent(NiagaraComponent NiagaraSystem, Object OverrideName, WaterBodyComponent WaterBodyComponent) { Invoke(nameof(SetWaterBodyComponent), NiagaraSystem, OverrideName, WaterBodyComponent); }
        public void SetWaterBody(NiagaraComponent NiagaraSystem, Object OverrideName, WaterBody WaterBody) { Invoke(nameof(SetWaterBody), NiagaraSystem, OverrideName, WaterBody); }
    }
    public class OceanCollisionComponent : PrimitiveComponent
    {
        public OceanCollisionComponent(nint addr) : base(addr) { }
        public BodySetup CachedBodySetup { get { return this[nameof(CachedBodySetup)].As<BodySetup>(); } set { this["CachedBodySetup"] = value; } }
    }
    public class OceanBoxCollisionComponent : BoxComponent
    {
        public OceanBoxCollisionComponent(nint addr) : base(addr) { }
    }
    public class WaterBody : Actor
    {
        public WaterBody(nint addr) : base(addr) { }
        public WaterSplineComponent SplineComp { get { return this[nameof(SplineComp)].As<WaterSplineComponent>(); } set { this["SplineComp"] = value; } }
        public WaterSplineMetadata WaterSplineMetadata { get { return this[nameof(WaterSplineMetadata)].As<WaterSplineMetadata>(); } set { this["WaterSplineMetadata"] = value; } }
        public WaterBodyComponent WaterBodyComponent { get { return this[nameof(WaterBodyComponent)].As<WaterBodyComponent>(); } set { this["WaterBodyComponent"] = value; } }
        public int WaterBodyIndex { get { return this[nameof(WaterBodyIndex)].GetValue<int>(); } set { this[nameof(WaterBodyIndex)].SetValue<int>(value); } }
        public EWaterBodyType WaterBodyType { get { return (EWaterBodyType)this[nameof(WaterBodyType)].GetValue<int>(); } set { this[nameof(WaterBodyType)].SetValue<int>((int)value); } }
        public WaterWavesBase WaterWaves { get { return this[nameof(WaterWaves)].As<WaterWavesBase>(); } set { this["WaterWaves"] = value; } }
        public void SetWaterWaves(WaterWavesBase InWaterWaves) { Invoke(nameof(SetWaterWaves), InWaterWaves); }
        public void SetWaterMaterial(MaterialInterface InMaterial) { Invoke(nameof(SetWaterMaterial), InMaterial); }
        public void OnWaterBodyChanged(bool bShapeOrPositionChanged, bool bWeightmapSettingsChanged) { Invoke(nameof(OnWaterBodyChanged), bShapeOrPositionChanged, bWeightmapSettingsChanged); }
        public Vector GetWaterVelocityVectorAtSplineInputKey(float InKey) { return Invoke<Vector>(nameof(GetWaterVelocityVectorAtSplineInputKey), InKey); }
        public float GetWaterVelocityAtSplineInputKey(float InKey) { return Invoke<float>(nameof(GetWaterVelocityAtSplineInputKey), InKey); }
        public WaterSplineComponent GetWaterSpline() { return Invoke<WaterSplineComponent>(nameof(GetWaterSpline)); }
        public MaterialInstanceDynamic GetWaterMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetWaterMaterialInstance)); }
        public EWaterBodyType GetWaterBodyType() { return Invoke<EWaterBodyType>(nameof(GetWaterBodyType)); }
        public WaterBodyComponent GetWaterBodyComponent() { return Invoke<WaterBodyComponent>(nameof(GetWaterBodyComponent)); }
        public MaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetRiverToOceanTransitionMaterialInstance)); }
        public MaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetRiverToLakeTransitionMaterialInstance)); }
        public Array<WaterBodyIsland> GetIslands() { return Invoke<Array<WaterBodyIsland>>(nameof(GetIslands)); }
        public Array<WaterBodyExclusionVolume> GetExclusionVolumes() { return Invoke<Array<WaterBodyExclusionVolume>>(nameof(GetExclusionVolumes)); }
        public float GetAudioIntensityAtSplineInputKey(float InKey) { return Invoke<float>(nameof(GetAudioIntensityAtSplineInputKey), InKey); }
    }
    public class WaterBodyGenerator : Object
    {
        public WaterBodyGenerator(nint addr) : base(addr) { }
    }
    public class WaterBodyComponent : PrimitiveComponent
    {
        public WaterBodyComponent(nint addr) : base(addr) { }
        public PhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<PhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public float TargetWaveMaskDepth { get { return this[nameof(TargetWaveMaskDepth)].GetValue<float>(); } set { this[nameof(TargetWaveMaskDepth)].SetValue<float>(value); } }
        public float MaxWaveHeightOffset { get { return this[nameof(MaxWaveHeightOffset)].GetValue<float>(); } set { this[nameof(MaxWaveHeightOffset)].SetValue<float>(value); } }
        public UnderwaterPostProcessSettings UnderwaterPostProcessSettings { get { return this[nameof(UnderwaterPostProcessSettings)].As<UnderwaterPostProcessSettings>(); } set { this["UnderwaterPostProcessSettings"] = value; } }
        public WaterCurveSettings CurveSettings { get { return this[nameof(CurveSettings)].As<WaterCurveSettings>(); } set { this["CurveSettings"] = value; } }
        public MaterialInterface WaterMaterial { get { return this[nameof(WaterMaterial)].As<MaterialInterface>(); } set { this["WaterMaterial"] = value; } }
        public MaterialInterface WaterHLODMaterial { get { return this[nameof(WaterHLODMaterial)].As<MaterialInterface>(); } set { this["WaterHLODMaterial"] = value; } }
        public MaterialInterface WaterLODMaterial { get { return this[nameof(WaterLODMaterial)].As<MaterialInterface>(); } set { this["WaterLODMaterial"] = value; } }
        public MaterialInterface UnderwaterPostProcessMaterial { get { return this[nameof(UnderwaterPostProcessMaterial)].As<MaterialInterface>(); } set { this["UnderwaterPostProcessMaterial"] = value; } }
        public MaterialInterface WaterInfoMaterial { get { return this[nameof(WaterInfoMaterial)].As<MaterialInterface>(); } set { this["WaterInfoMaterial"] = value; } }
        public WaterBodyHeightmapSettings WaterHeightmapSettings { get { return this[nameof(WaterHeightmapSettings)].As<WaterBodyHeightmapSettings>(); } set { this["WaterHeightmapSettings"] = value; } }
        public float ShapeDilation { get { return this[nameof(ShapeDilation)].GetValue<float>(); } set { this[nameof(ShapeDilation)].SetValue<float>(value); } }
        public float CollisionHeightOffset { get { return this[nameof(CollisionHeightOffset)].GetValue<float>(); } set { this[nameof(CollisionHeightOffset)].SetValue<float>(value); } }
        public bool bAffectsLandscape { get { return this[nameof(bAffectsLandscape)].Flag; } set { this[nameof(bAffectsLandscape)].Flag = value; } }
        public int WaterBodyIndex { get { return this[nameof(WaterBodyIndex)].GetValue<int>(); } set { this[nameof(WaterBodyIndex)].SetValue<int>(value); } }
        public StaticMesh WaterMeshOverride { get { return this[nameof(WaterMeshOverride)].As<StaticMesh>(); } set { this["WaterMeshOverride"] = value; } }
        public bool bAlwaysGenerateWaterMeshTiles { get { return this[nameof(bAlwaysGenerateWaterMeshTiles)].Flag; } set { this[nameof(bAlwaysGenerateWaterMeshTiles)].Flag = value; } }
        public int OverlapMaterialPriority { get { return this[nameof(OverlapMaterialPriority)].GetValue<int>(); } set { this[nameof(OverlapMaterialPriority)].SetValue<int>(value); } }
        public WaterSplineMetadata WaterSplineMetadata { get { return this[nameof(WaterSplineMetadata)].As<WaterSplineMetadata>(); } set { this["WaterSplineMetadata"] = value; } }
        public MaterialInstanceDynamic WaterMID { get { return this[nameof(WaterMID)].As<MaterialInstanceDynamic>(); } set { this["WaterMID"] = value; } }
        public MaterialInstanceDynamic WaterLODMID { get { return this[nameof(WaterLODMID)].As<MaterialInstanceDynamic>(); } set { this["WaterLODMID"] = value; } }
        public MaterialInstanceDynamic UnderwaterPostProcessMID { get { return this[nameof(UnderwaterPostProcessMID)].As<MaterialInstanceDynamic>(); } set { this["UnderwaterPostProcessMID"] = value; } }
        public MaterialInstanceDynamic WaterInfoMID { get { return this[nameof(WaterInfoMID)].As<MaterialInstanceDynamic>(); } set { this["WaterInfoMID"] = value; } }
        public Array<Object> WaterBodyIslands { get { return new Array<Object>(this[nameof(WaterBodyIslands)].Address); } }
        public Array<Object> WaterBodyExclusionVolumes { get { return new Array<Object>(this[nameof(WaterBodyExclusionVolumes)].Address); } }
        public Object Landscape { get { return this[nameof(Landscape)]; } set { this[nameof(Landscape)] = value; } }
        public Object OwningWaterZone { get { return this[nameof(OwningWaterZone)]; } set { this[nameof(OwningWaterZone)] = value; } }
        public Object WaterZoneOverride { get { return this[nameof(WaterZoneOverride)]; } set { this[nameof(WaterZoneOverride)] = value; } }
        public PostProcessSettings CurrentPostProcessSettings { get { return this[nameof(CurrentPostProcessSettings)].As<PostProcessSettings>(); } set { this["CurrentPostProcessSettings"] = value; } }
        public Object WaterNavAreaClass { get { return this[nameof(WaterNavAreaClass)]; } set { this[nameof(WaterNavAreaClass)] = value; } }
        public double FixedWaterDepth { get { return this[nameof(FixedWaterDepth)].GetValue<double>(); } set { this[nameof(FixedWaterDepth)].SetValue<double>(value); } }
        public void SetWaterAndUnderWaterPostProcessMaterial(MaterialInterface InWaterMaterial, MaterialInterface InUnderWaterPostProcessMaterial) { Invoke(nameof(SetWaterAndUnderWaterPostProcessMaterial), InWaterMaterial, InUnderWaterPostProcessMaterial); }
        public void OnWaterBodyChanged(bool bShapeOrPositionChanged, bool bWeightmapSettingsChanged) { Invoke(nameof(OnWaterBodyChanged), bShapeOrPositionChanged, bWeightmapSettingsChanged); }
        public WaterWavesBase GetWaterWaves() { return Invoke<WaterWavesBase>(nameof(GetWaterWaves)); }
        public float GetWaterVelocityAtSplineInputKey(float InKey) { return Invoke<float>(nameof(GetWaterVelocityAtSplineInputKey), InKey); }
        public void GetWaterSurfaceInfoAtLocation(Vector InLocation, Vector OutWaterSurfaceLocation, Vector OutWaterSurfaceNormal, Vector OutWaterVelocity, float OutWaterDepth, bool bIncludeDepth) { Invoke(nameof(GetWaterSurfaceInfoAtLocation), InLocation, OutWaterSurfaceLocation, OutWaterSurfaceNormal, OutWaterVelocity, OutWaterDepth, bIncludeDepth); }
        public WaterSplineComponent GetWaterSpline() { return Invoke<WaterSplineComponent>(nameof(GetWaterSpline)); }
        public MaterialInstanceDynamic GetWaterMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetWaterMaterialInstance)); }
        public MaterialInterface GetWaterMaterial() { return Invoke<MaterialInterface>(nameof(GetWaterMaterial)); }
        public MaterialInstanceDynamic GetWaterLODMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetWaterLODMaterialInstance)); }
        public MaterialInstanceDynamic GetWaterInfoMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetWaterInfoMaterialInstance)); }
        public WaterBody GetWaterBodyActor() { return Invoke<WaterBody>(nameof(GetWaterBodyActor)); }
        public MaterialInstanceDynamic GetUnderwaterPostProcessMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetUnderwaterPostProcessMaterialInstance)); }
        public Array<PrimitiveComponent> GetStandardRenderableComponents() { return Invoke<Array<PrimitiveComponent>>(nameof(GetStandardRenderableComponents)); }
        public MaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetRiverToOceanTransitionMaterialInstance)); }
        public MaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance() { return Invoke<MaterialInstanceDynamic>(nameof(GetRiverToLakeTransitionMaterialInstance)); }
        public float GetMaxWaveHeight() { return Invoke<float>(nameof(GetMaxWaveHeight)); }
        public Array<WaterBodyIsland> GetIslands() { return Invoke<Array<WaterBodyIsland>>(nameof(GetIslands)); }
        public Array<WaterBodyExclusionVolume> GetExclusionVolumes() { return Invoke<Array<WaterBodyExclusionVolume>>(nameof(GetExclusionVolumes)); }
        public Array<PrimitiveComponent> GetCollisionComponents(bool bInOnlyEnabledComponents) { return Invoke<Array<PrimitiveComponent>>(nameof(GetCollisionComponents), bInOnlyEnabledComponents); }
    }
    public class CustomMeshGenerator : WaterBodyGenerator
    {
        public CustomMeshGenerator(nint addr) : base(addr) { }
        public StaticMeshComponent MeshComp { get { return this[nameof(MeshComp)].As<StaticMeshComponent>(); } set { this["MeshComp"] = value; } }
    }
    public class WaterBodyCustom : WaterBody
    {
        public WaterBodyCustom(nint addr) : base(addr) { }
    }
    public class WaterBodyCustomComponent : WaterBodyComponent
    {
        public WaterBodyCustomComponent(nint addr) : base(addr) { }
        public StaticMeshComponent MeshComp { get { return this[nameof(MeshComp)].As<StaticMeshComponent>(); } set { this["MeshComp"] = value; } }
    }
    public class WaterBodyExclusionVolume : PhysicsVolume
    {
        public WaterBodyExclusionVolume(nint addr) : base(addr) { }
        public bool bExcludeAllOverlappingWaterBodies { get { return this[nameof(bExcludeAllOverlappingWaterBodies)].Flag; } set { this[nameof(bExcludeAllOverlappingWaterBodies)].Flag = value; } }
        public Array<WaterBody> WaterBodiesToExclude { get { return new Array<WaterBody>(this[nameof(WaterBodiesToExclude)].Address); } }
    }
    public class WaterBodyHLODBuilder : HLODBuilder
    {
        public WaterBodyHLODBuilder(nint addr) : base(addr) { }
    }
    public class WaterBodyIsland : Actor
    {
        public WaterBodyIsland(nint addr) : base(addr) { }
        public WaterSplineComponent SplineComp { get { return this[nameof(SplineComp)].As<WaterSplineComponent>(); } set { this["SplineComp"] = value; } }
        public WaterSplineComponent GetWaterSpline() { return Invoke<WaterSplineComponent>(nameof(GetWaterSpline)); }
    }
    public class LakeGenerator : WaterBodyGenerator
    {
        public LakeGenerator(nint addr) : base(addr) { }
        public StaticMeshComponent LakeMeshComp { get { return this[nameof(LakeMeshComp)].As<StaticMeshComponent>(); } set { this["LakeMeshComp"] = value; } }
        public BoxComponent LakeCollisionComp { get { return this[nameof(LakeCollisionComp)].As<BoxComponent>(); } set { this["LakeCollisionComp"] = value; } }
        public LakeCollisionComponent LakeCollision { get { return this[nameof(LakeCollision)].As<LakeCollisionComponent>(); } set { this["LakeCollision"] = value; } }
    }
    public class WaterBodyLake : WaterBody
    {
        public WaterBodyLake(nint addr) : base(addr) { }
    }
    public class WaterBodyLakeComponent : WaterBodyComponent
    {
        public WaterBodyLakeComponent(nint addr) : base(addr) { }
        public StaticMeshComponent LakeMeshComp { get { return this[nameof(LakeMeshComp)].As<StaticMeshComponent>(); } set { this["LakeMeshComp"] = value; } }
        public LakeCollisionComponent LakeCollision { get { return this[nameof(LakeCollision)].As<LakeCollisionComponent>(); } set { this["LakeCollision"] = value; } }
    }
    public class OceanGenerator : WaterBodyGenerator
    {
        public OceanGenerator(nint addr) : base(addr) { }
        public Array<OceanBoxCollisionComponent> CollisionBoxes { get { return new Array<OceanBoxCollisionComponent>(this[nameof(CollisionBoxes)].Address); } }
        public Array<OceanCollisionComponent> CollisionHullSets { get { return new Array<OceanCollisionComponent>(this[nameof(CollisionHullSets)].Address); } }
    }
    public class WaterBodyOcean : WaterBody
    {
        public WaterBodyOcean(nint addr) : base(addr) { }
    }
    public class WaterBodyOceanComponent : WaterBodyComponent
    {
        public WaterBodyOceanComponent(nint addr) : base(addr) { }
        public Array<OceanBoxCollisionComponent> CollisionBoxes { get { return new Array<OceanBoxCollisionComponent>(this[nameof(CollisionBoxes)].Address); } }
        public Array<OceanCollisionComponent> CollisionHullSets { get { return new Array<OceanCollisionComponent>(this[nameof(CollisionHullSets)].Address); } }
        public Vector2D VisualExtents { get { return this[nameof(VisualExtents)].As<Vector2D>(); } set { this["VisualExtents"] = value; } }
        public Vector CollisionExtents { get { return this[nameof(CollisionExtents)].As<Vector>(); } set { this["CollisionExtents"] = value; } }
        public float HeightOffset { get { return this[nameof(HeightOffset)].GetValue<float>(); } set { this[nameof(HeightOffset)].SetValue<float>(value); } }
    }
    public class RiverGenerator : WaterBodyGenerator
    {
        public RiverGenerator(nint addr) : base(addr) { }
        public Array<SplineMeshComponent> SplineMeshComponents { get { return new Array<SplineMeshComponent>(this[nameof(SplineMeshComponents)].Address); } }
    }
    public class WaterBodyRiver : WaterBody
    {
        public WaterBodyRiver(nint addr) : base(addr) { }
    }
    public class WaterBodyRiverComponent : WaterBodyComponent
    {
        public WaterBodyRiverComponent(nint addr) : base(addr) { }
        public Array<SplineMeshComponent> SplineMeshComponents { get { return new Array<SplineMeshComponent>(this[nameof(SplineMeshComponents)].Address); } }
        public MaterialInterface LakeTransitionMaterial { get { return this[nameof(LakeTransitionMaterial)].As<MaterialInterface>(); } set { this["LakeTransitionMaterial"] = value; } }
        public MaterialInstanceDynamic LakeTransitionMID { get { return this[nameof(LakeTransitionMID)].As<MaterialInstanceDynamic>(); } set { this["LakeTransitionMID"] = value; } }
        public MaterialInterface OceanTransitionMaterial { get { return this[nameof(OceanTransitionMaterial)].As<MaterialInterface>(); } set { this["OceanTransitionMaterial"] = value; } }
        public MaterialInstanceDynamic OceanTransitionMID { get { return this[nameof(OceanTransitionMID)].As<MaterialInstanceDynamic>(); } set { this["OceanTransitionMID"] = value; } }
    }
    public class WaterBrushActorInterface : Interface
    {
        public WaterBrushActorInterface(nint addr) : base(addr) { }
    }
    public class WaterMeshComponent : MeshComponent
    {
        public WaterMeshComponent(nint addr) : base(addr) { }
        public int ForceCollapseDensityLevel { get { return this[nameof(ForceCollapseDensityLevel)].GetValue<int>(); } set { this[nameof(ForceCollapseDensityLevel)].SetValue<int>(value); } }
        public MaterialInterface FarDistanceMaterial { get { return this[nameof(FarDistanceMaterial)].As<MaterialInterface>(); } set { this["FarDistanceMaterial"] = value; } }
        public float FarDistanceMeshExtent { get { return this[nameof(FarDistanceMeshExtent)].GetValue<float>(); } set { this[nameof(FarDistanceMeshExtent)].SetValue<float>(value); } }
        public float TileSize { get { return this[nameof(TileSize)].GetValue<float>(); } set { this[nameof(TileSize)].SetValue<float>(value); } }
        public IntPoint ExtentInTiles { get { return this[nameof(ExtentInTiles)].As<IntPoint>(); } set { this["ExtentInTiles"] = value; } }
        public Object UsedMaterials { get { return this[nameof(UsedMaterials)]; } set { this[nameof(UsedMaterials)] = value; } }
        public int TessellationFactor { get { return this[nameof(TessellationFactor)].GetValue<int>(); } set { this[nameof(TessellationFactor)].SetValue<int>(value); } }
        public float LODScale { get { return this[nameof(LODScale)].GetValue<float>(); } set { this[nameof(LODScale)].SetValue<float>(value); } }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
    }
    public class WaterRuntimeSettings : DeveloperSettings
    {
        public WaterRuntimeSettings(nint addr) : base(addr) { }
        public byte CollisionChannelForWaterTraces { get { return this[nameof(CollisionChannelForWaterTraces)].GetValue<byte>(); } set { this[nameof(CollisionChannelForWaterTraces)].SetValue<byte>(value); } }
        public Object MaterialParameterCollection { get { return this[nameof(MaterialParameterCollection)]; } set { this[nameof(MaterialParameterCollection)] = value; } }
        public float WaterBodyIconWorldZOffset { get { return this[nameof(WaterBodyIconWorldZOffset)].GetValue<float>(); } set { this[nameof(WaterBodyIconWorldZOffset)].SetValue<float>(value); } }
        public Object DefaultWaterCollisionProfileName { get { return this[nameof(DefaultWaterCollisionProfileName)]; } set { this[nameof(DefaultWaterCollisionProfileName)] = value; } }
        public Object DefaultWaterInfoMaterial { get { return this[nameof(DefaultWaterInfoMaterial)]; } set { this[nameof(DefaultWaterInfoMaterial)] = value; } }
        public Object WaterBodyRiverComponentClass { get { return this[nameof(WaterBodyRiverComponentClass)]; } set { this[nameof(WaterBodyRiverComponentClass)] = value; } }
        public Object WaterBodyLakeComponentClass { get { return this[nameof(WaterBodyLakeComponentClass)]; } set { this[nameof(WaterBodyLakeComponentClass)] = value; } }
        public Object WaterBodyOceanComponentClass { get { return this[nameof(WaterBodyOceanComponentClass)]; } set { this[nameof(WaterBodyOceanComponentClass)] = value; } }
        public Object WaterBodyCustomComponentClass { get { return this[nameof(WaterBodyCustomComponentClass)]; } set { this[nameof(WaterBodyCustomComponentClass)] = value; } }
    }
    public class WaterSplineComponent : SplineComponent
    {
        public WaterSplineComponent(nint addr) : base(addr) { }
        public WaterSplineCurveDefaults WaterSplineDefaults { get { return this[nameof(WaterSplineDefaults)].As<WaterSplineCurveDefaults>(); } set { this["WaterSplineDefaults"] = value; } }
        public WaterSplineCurveDefaults PreviousWaterSplineDefaults { get { return this[nameof(PreviousWaterSplineDefaults)].As<WaterSplineCurveDefaults>(); } set { this["PreviousWaterSplineDefaults"] = value; } }
    }
    public class WaterSplineMetadata : SplineMetadata
    {
        public WaterSplineMetadata(nint addr) : base(addr) { }
        public InterpCurveFloat Depth { get { return this[nameof(Depth)].As<InterpCurveFloat>(); } set { this["Depth"] = value; } }
        public InterpCurveFloat WaterVelocityScalar { get { return this[nameof(WaterVelocityScalar)].As<InterpCurveFloat>(); } set { this["WaterVelocityScalar"] = value; } }
        public InterpCurveFloat RiverWidth { get { return this[nameof(RiverWidth)].As<InterpCurveFloat>(); } set { this["RiverWidth"] = value; } }
        public InterpCurveFloat AudioIntensity { get { return this[nameof(AudioIntensity)].As<InterpCurveFloat>(); } set { this["AudioIntensity"] = value; } }
        public InterpCurveVector WaterVelocity { get { return this[nameof(WaterVelocity)].As<InterpCurveVector>(); } set { this["WaterVelocity"] = value; } }
    }
    public class WaterSubsystem : TickableWorldSubsystem
    {
        public WaterSubsystem(nint addr) : base(addr) { }
        public BuoyancyManager BuoyancyManager { get { return this[nameof(BuoyancyManager)].As<BuoyancyManager>(); } set { this["BuoyancyManager"] = value; } }
        public Object OnCameraUnderwaterStateChanged { get { return this[nameof(OnCameraUnderwaterStateChanged)]; } set { this[nameof(OnCameraUnderwaterStateChanged)] = value; } }
        public Object OnWaterScalabilityChanged { get { return this[nameof(OnWaterScalabilityChanged)]; } set { this[nameof(OnWaterScalabilityChanged)] = value; } }
        public StaticMesh DefaultRiverMesh { get { return this[nameof(DefaultRiverMesh)].As<StaticMesh>(); } set { this["DefaultRiverMesh"] = value; } }
        public StaticMesh DefaultLakeMesh { get { return this[nameof(DefaultLakeMesh)].As<StaticMesh>(); } set { this["DefaultLakeMesh"] = value; } }
        public MaterialParameterCollection MaterialParameterCollection { get { return this[nameof(MaterialParameterCollection)].As<MaterialParameterCollection>(); } set { this["MaterialParameterCollection"] = value; } }
        public void SetOceanFloodHeight(float InFloodHeight) { Invoke(nameof(SetOceanFloodHeight), InFloodHeight); }
        public void PrintToWaterLog(Object Message, bool bWarning) { Invoke(nameof(PrintToWaterLog), Message, bWarning); }
        public bool IsWaterRenderingEnabled() { return Invoke<bool>(nameof(IsWaterRenderingEnabled)); }
        public bool IsUnderwaterPostProcessEnabled() { return Invoke<bool>(nameof(IsUnderwaterPostProcessEnabled)); }
        public bool IsShallowWaterSimulationEnabled() { return Invoke<bool>(nameof(IsShallowWaterSimulationEnabled)); }
        public float GetWaterTimeSeconds() { return Invoke<float>(nameof(GetWaterTimeSeconds)); }
        public float GetSmoothedWorldTimeSeconds() { return Invoke<float>(nameof(GetSmoothedWorldTimeSeconds)); }
        public int GetShallowWaterSimulationRenderTargetSize() { return Invoke<int>(nameof(GetShallowWaterSimulationRenderTargetSize)); }
        public int GetShallowWaterMaxImpulseForces() { return Invoke<int>(nameof(GetShallowWaterMaxImpulseForces)); }
        public int GetShallowWaterMaxDynamicForces() { return Invoke<int>(nameof(GetShallowWaterMaxDynamicForces)); }
        public float GetOceanTotalHeight() { return Invoke<float>(nameof(GetOceanTotalHeight)); }
        public float GetOceanFloodHeight() { return Invoke<float>(nameof(GetOceanFloodHeight)); }
        public float GetOceanBaseHeight() { return Invoke<float>(nameof(GetOceanBaseHeight)); }
        public float GetCameraUnderwaterDepth() { return Invoke<float>(nameof(GetCameraUnderwaterDepth)); }
    }
    public class WaterWavesAsset : Object
    {
        public WaterWavesAsset(nint addr) : base(addr) { }
        public WaterWaves WaterWaves { get { return this[nameof(WaterWaves)].As<WaterWaves>(); } set { this["WaterWaves"] = value; } }
    }
    public class WaterWavesAssetReference : WaterWavesBase
    {
        public WaterWavesAssetReference(nint addr) : base(addr) { }
        public WaterWavesAsset WaterWavesAsset { get { return this[nameof(WaterWavesAsset)].As<WaterWavesAsset>(); } set { this["WaterWavesAsset"] = value; } }
    }
    public class WaterZone : Actor
    {
        public WaterZone(nint addr) : base(addr) { }
        public TextureRenderTarget2D WaterInfoTexture { get { return this[nameof(WaterInfoTexture)].As<TextureRenderTarget2D>(); } set { this["WaterInfoTexture"] = value; } }
        public Array<Object> OwnedWaterBodies { get { return new Array<Object>(this[nameof(OwnedWaterBodies)].Address); } }
        public IntPoint RenderTargetResolution { get { return this[nameof(RenderTargetResolution)].As<IntPoint>(); } set { this["RenderTargetResolution"] = value; } }
        public WaterMeshComponent WaterMesh { get { return this[nameof(WaterMesh)].As<WaterMeshComponent>(); } set { this["WaterMesh"] = value; } }
        public Vector2D ZoneExtent { get { return this[nameof(ZoneExtent)].As<Vector2D>(); } set { this["ZoneExtent"] = value; } }
        public float CaptureZOffset { get { return this[nameof(CaptureZOffset)].GetValue<float>(); } set { this[nameof(CaptureZOffset)].SetValue<float>(value); } }
        public bool bHalfPrecisionTexture { get { return this[nameof(bHalfPrecisionTexture)].Flag; } set { this[nameof(bHalfPrecisionTexture)].Flag = value; } }
        public int VelocityBlurRadius { get { return this[nameof(VelocityBlurRadius)].GetValue<int>(); } set { this[nameof(VelocityBlurRadius)].SetValue<int>(value); } }
        public Vector TessellatedWaterMeshExtent { get { return this[nameof(TessellatedWaterMeshExtent)].As<Vector>(); } set { this["TessellatedWaterMeshExtent"] = value; } }
        public uint NonTessellatedLODSectionScale { get { return this[nameof(NonTessellatedLODSectionScale)].GetValue<uint>(); } set { this[nameof(NonTessellatedLODSectionScale)].SetValue<uint>(value); } }
        public int OverlapPriority { get { return this[nameof(OverlapPriority)].GetValue<int>(); } set { this[nameof(OverlapPriority)].SetValue<int>(value); } }
        public bool bEnableNonTessellatedLODMesh { get { return this[nameof(bEnableNonTessellatedLODMesh)].Flag; } set { this[nameof(bEnableNonTessellatedLODMesh)].Flag = value; } }
    }
    public class SphericalPontoon : Object
    {
        public SphericalPontoon(nint addr) : base(addr) { }
        public Object CenterSocket { get { return this[nameof(CenterSocket)]; } set { this[nameof(CenterSocket)] = value; } }
        public Vector RelativeLocation { get { return this[nameof(RelativeLocation)].As<Vector>(); } set { this["RelativeLocation"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public bool bFXEnabled { get { return this[nameof(bFXEnabled)].Flag; } set { this[nameof(bFXEnabled)].Flag = value; } }
        public Vector LocalForce { get { return this[nameof(LocalForce)].As<Vector>(); } set { this["LocalForce"] = value; } }
        public Vector CenterLocation { get { return this[nameof(CenterLocation)].As<Vector>(); } set { this["CenterLocation"] = value; } }
        public Quat SocketRotation { get { return this[nameof(SocketRotation)].As<Quat>(); } set { this["SocketRotation"] = value; } }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
        public float WaterHeight { get { return this[nameof(WaterHeight)].GetValue<float>(); } set { this[nameof(WaterHeight)].SetValue<float>(value); } }
        public float WaterDepth { get { return this[nameof(WaterDepth)].GetValue<float>(); } set { this[nameof(WaterDepth)].SetValue<float>(value); } }
        public float ImmersionDepth { get { return this[nameof(ImmersionDepth)].GetValue<float>(); } set { this[nameof(ImmersionDepth)].SetValue<float>(value); } }
        public Vector WaterPlaneLocation { get { return this[nameof(WaterPlaneLocation)].As<Vector>(); } set { this["WaterPlaneLocation"] = value; } }
        public Vector WaterPlaneNormal { get { return this[nameof(WaterPlaneNormal)].As<Vector>(); } set { this["WaterPlaneNormal"] = value; } }
        public Vector WaterSurfacePosition { get { return this[nameof(WaterSurfacePosition)].As<Vector>(); } set { this["WaterSurfacePosition"] = value; } }
        public Vector WaterVelocity { get { return this[nameof(WaterVelocity)].As<Vector>(); } set { this["WaterVelocity"] = value; } }
        public int WaterBodyIndex { get { return this[nameof(WaterBodyIndex)].GetValue<int>(); } set { this[nameof(WaterBodyIndex)].SetValue<int>(value); } }
        public bool bIsInWater { get { return this[nameof(bIsInWater)].Flag; } set { this[nameof(bIsInWater)].Flag = value; } }
        public WaterBodyComponent CurrentWaterBodyComponent { get { return this[nameof(CurrentWaterBodyComponent)].As<WaterBodyComponent>(); } set { this["CurrentWaterBodyComponent"] = value; } }
    }
    public enum EBuoyancyEvent : int
    {
        EnteredWaterBody = 0,
        ExitedWaterBody = 1,
        EBuoyancyEvent_MAX = 2,
    }
    public enum EWaveSpectrumType : int
    {
        Phillips = 0,
        PiersonMoskowitz = 1,
        JONSWAP = 2,
        EWaveSpectrumType_MAX = 3,
    }
    public enum EWaterBrushBlendType : int
    {
        AlphaBlend = 0,
        Min = 1,
        Max = 2,
        Additive = 3,
    }
    public enum EWaterBodyType : int
    {
        River = 0,
        Lake = 1,
        Ocean = 2,
        Transition = 3,
        Num = 4,
        EWaterBodyType_MAX = 5,
    }
    public enum EWaterBrushFalloffMode : int
    {
        Angle = 0,
        Width = 1,
        EWaterBrushFalloffMode_MAX = 2,
    }
    public class BuoyancyData : Object
    {
        public BuoyancyData(nint addr) : base(addr) { }
        public Array<SphericalPontoon> Pontoons { get { return new Array<SphericalPontoon>(this[nameof(Pontoons)].Address); } }
        public bool bCenterPontoonsOnCOM { get { return this[nameof(bCenterPontoonsOnCOM)].Flag; } set { this[nameof(bCenterPontoonsOnCOM)].Flag = value; } }
        public float BuoyancyCoefficient { get { return this[nameof(BuoyancyCoefficient)].GetValue<float>(); } set { this[nameof(BuoyancyCoefficient)].SetValue<float>(value); } }
        public float BuoyancyDamp { get { return this[nameof(BuoyancyDamp)].GetValue<float>(); } set { this[nameof(BuoyancyDamp)].SetValue<float>(value); } }
        public float BuoyancyDamp2 { get { return this[nameof(BuoyancyDamp2)].GetValue<float>(); } set { this[nameof(BuoyancyDamp2)].SetValue<float>(value); } }
        public float BuoyancyRampMinVelocity { get { return this[nameof(BuoyancyRampMinVelocity)].GetValue<float>(); } set { this[nameof(BuoyancyRampMinVelocity)].SetValue<float>(value); } }
        public float BuoyancyRampMaxVelocity { get { return this[nameof(BuoyancyRampMaxVelocity)].GetValue<float>(); } set { this[nameof(BuoyancyRampMaxVelocity)].SetValue<float>(value); } }
        public float BuoyancyRampMax { get { return this[nameof(BuoyancyRampMax)].GetValue<float>(); } set { this[nameof(BuoyancyRampMax)].SetValue<float>(value); } }
        public float MaxBuoyantForce { get { return this[nameof(MaxBuoyantForce)].GetValue<float>(); } set { this[nameof(MaxBuoyantForce)].SetValue<float>(value); } }
        public bool bApplyDragForcesInWater { get { return this[nameof(bApplyDragForcesInWater)].Flag; } set { this[nameof(bApplyDragForcesInWater)].Flag = value; } }
        public float DragCoefficient { get { return this[nameof(DragCoefficient)].GetValue<float>(); } set { this[nameof(DragCoefficient)].SetValue<float>(value); } }
        public float DragCoefficient2 { get { return this[nameof(DragCoefficient2)].GetValue<float>(); } set { this[nameof(DragCoefficient2)].SetValue<float>(value); } }
        public float AngularDragCoefficient { get { return this[nameof(AngularDragCoefficient)].GetValue<float>(); } set { this[nameof(AngularDragCoefficient)].SetValue<float>(value); } }
        public float MaxDragSpeed { get { return this[nameof(MaxDragSpeed)].GetValue<float>(); } set { this[nameof(MaxDragSpeed)].SetValue<float>(value); } }
        public bool bApplyRiverForces { get { return this[nameof(bApplyRiverForces)].Flag; } set { this[nameof(bApplyRiverForces)].Flag = value; } }
        public int RiverPontoonIndex { get { return this[nameof(RiverPontoonIndex)].GetValue<int>(); } set { this[nameof(RiverPontoonIndex)].SetValue<int>(value); } }
        public float WaterShorePushFactor { get { return this[nameof(WaterShorePushFactor)].GetValue<float>(); } set { this[nameof(WaterShorePushFactor)].SetValue<float>(value); } }
        public float RiverTraversalPathWidth { get { return this[nameof(RiverTraversalPathWidth)].GetValue<float>(); } set { this[nameof(RiverTraversalPathWidth)].SetValue<float>(value); } }
        public float MaxShorePushForce { get { return this[nameof(MaxShorePushForce)].GetValue<float>(); } set { this[nameof(MaxShorePushForce)].SetValue<float>(value); } }
        public float WaterVelocityStrength { get { return this[nameof(WaterVelocityStrength)].GetValue<float>(); } set { this[nameof(WaterVelocityStrength)].SetValue<float>(value); } }
        public float MaxWaterForce { get { return this[nameof(MaxWaterForce)].GetValue<float>(); } set { this[nameof(MaxWaterForce)].SetValue<float>(value); } }
        public bool bAlwaysAllowLateralPush { get { return this[nameof(bAlwaysAllowLateralPush)].Flag; } set { this[nameof(bAlwaysAllowLateralPush)].Flag = value; } }
        public bool bAllowCurrentWhenMovingFastUpstream { get { return this[nameof(bAllowCurrentWhenMovingFastUpstream)].Flag; } set { this[nameof(bAllowCurrentWhenMovingFastUpstream)].Flag = value; } }
        public bool bApplyDownstreamAngularRotation { get { return this[nameof(bApplyDownstreamAngularRotation)].Flag; } set { this[nameof(bApplyDownstreamAngularRotation)].Flag = value; } }
        public Vector DownstreamAxisOfRotation { get { return this[nameof(DownstreamAxisOfRotation)].As<Vector>(); } set { this["DownstreamAxisOfRotation"] = value; } }
        public float DownstreamRotationStrength { get { return this[nameof(DownstreamRotationStrength)].GetValue<float>(); } set { this[nameof(DownstreamRotationStrength)].SetValue<float>(value); } }
        public float DownstreamRotationStiffness { get { return this[nameof(DownstreamRotationStiffness)].GetValue<float>(); } set { this[nameof(DownstreamRotationStiffness)].SetValue<float>(value); } }
        public float DownstreamRotationAngularDamping { get { return this[nameof(DownstreamRotationAngularDamping)].GetValue<float>(); } set { this[nameof(DownstreamRotationAngularDamping)].SetValue<float>(value); } }
        public float DownstreamMaxAcceleration { get { return this[nameof(DownstreamMaxAcceleration)].GetValue<float>(); } set { this[nameof(DownstreamMaxAcceleration)].SetValue<float>(value); } }
    }
    public class WaterBodyWeightmapSettings : Object
    {
        public WaterBodyWeightmapSettings(nint addr) : base(addr) { }
        public float FalloffWidth { get { return this[nameof(FalloffWidth)].GetValue<float>(); } set { this[nameof(FalloffWidth)].SetValue<float>(value); } }
        public float EdgeOffset { get { return this[nameof(EdgeOffset)].GetValue<float>(); } set { this[nameof(EdgeOffset)].SetValue<float>(value); } }
        public Texture2D ModulationTexture { get { return this[nameof(ModulationTexture)].As<Texture2D>(); } set { this["ModulationTexture"] = value; } }
        public float TextureTiling { get { return this[nameof(TextureTiling)].GetValue<float>(); } set { this[nameof(TextureTiling)].SetValue<float>(value); } }
        public float TextureInfluence { get { return this[nameof(TextureInfluence)].GetValue<float>(); } set { this[nameof(TextureInfluence)].SetValue<float>(value); } }
        public float Midpoint { get { return this[nameof(Midpoint)].GetValue<float>(); } set { this[nameof(Midpoint)].SetValue<float>(value); } }
        public float FinalOpacity { get { return this[nameof(FinalOpacity)].GetValue<float>(); } set { this[nameof(FinalOpacity)].SetValue<float>(value); } }
    }
    public class WaterCurveSettings : Object
    {
        public WaterCurveSettings(nint addr) : base(addr) { }
        public bool bUseCurveChannel { get { return this[nameof(bUseCurveChannel)].Flag; } set { this[nameof(bUseCurveChannel)].Flag = value; } }
        public CurveFloat ElevationCurveAsset { get { return this[nameof(ElevationCurveAsset)].As<CurveFloat>(); } set { this["ElevationCurveAsset"] = value; } }
        public float ChannelEdgeOffset { get { return this[nameof(ChannelEdgeOffset)].GetValue<float>(); } set { this[nameof(ChannelEdgeOffset)].SetValue<float>(value); } }
        public float ChannelDepth { get { return this[nameof(ChannelDepth)].GetValue<float>(); } set { this[nameof(ChannelDepth)].SetValue<float>(value); } }
        public float CurveRampWidth { get { return this[nameof(CurveRampWidth)].GetValue<float>(); } set { this[nameof(CurveRampWidth)].SetValue<float>(value); } }
    }
    public class GerstnerWave : Object
    {
        public GerstnerWave(nint addr) : base(addr) { }
        public float WaveLength { get { return this[nameof(WaveLength)].GetValue<float>(); } set { this[nameof(WaveLength)].SetValue<float>(value); } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Steepness { get { return this[nameof(Steepness)].GetValue<float>(); } set { this[nameof(Steepness)].SetValue<float>(value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public Vector2D WaveVector { get { return this[nameof(WaveVector)].As<Vector2D>(); } set { this["WaveVector"] = value; } }
        public float WaveSpeed { get { return this[nameof(WaveSpeed)].GetValue<float>(); } set { this[nameof(WaveSpeed)].SetValue<float>(value); } }
        public float WKA { get { return this[nameof(WKA)].GetValue<float>(); } set { this[nameof(WKA)].SetValue<float>(value); } }
        public float Q { get { return this[nameof(Q)].GetValue<float>(); } set { this[nameof(Q)].SetValue<float>(value); } }
        public float PhaseOffset { get { return this[nameof(PhaseOffset)].GetValue<float>(); } set { this[nameof(PhaseOffset)].SetValue<float>(value); } }
    }
    public class GerstnerWaveOctave : Object
    {
        public GerstnerWaveOctave(nint addr) : base(addr) { }
        public int NumWaves { get { return this[nameof(NumWaves)].GetValue<int>(); } set { this[nameof(NumWaves)].SetValue<int>(value); } }
        public float AmplitudeScale { get { return this[nameof(AmplitudeScale)].GetValue<float>(); } set { this[nameof(AmplitudeScale)].SetValue<float>(value); } }
        public float MainDirection { get { return this[nameof(MainDirection)].GetValue<float>(); } set { this[nameof(MainDirection)].SetValue<float>(value); } }
        public float SpreadAngle { get { return this[nameof(SpreadAngle)].GetValue<float>(); } set { this[nameof(SpreadAngle)].SetValue<float>(value); } }
        public bool bUniformSpread { get { return this[nameof(bUniformSpread)].Flag; } set { this[nameof(bUniformSpread)].Flag = value; } }
    }
    public class UnderwaterPostProcessSettings : Object
    {
        public UnderwaterPostProcessSettings(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public float Priority { get { return this[nameof(Priority)].GetValue<float>(); } set { this[nameof(Priority)].SetValue<float>(value); } }
        public float BlendRadius { get { return this[nameof(BlendRadius)].GetValue<float>(); } set { this[nameof(BlendRadius)].SetValue<float>(value); } }
        public float BlendWeight { get { return this[nameof(BlendWeight)].GetValue<float>(); } set { this[nameof(BlendWeight)].SetValue<float>(value); } }
        public PostProcessSettings PostProcessSettings { get { return this[nameof(PostProcessSettings)].As<PostProcessSettings>(); } set { this["PostProcessSettings"] = value; } }
        public MaterialInterface UnderwaterPostProcessMaterial { get { return this[nameof(UnderwaterPostProcessMaterial)].As<MaterialInterface>(); } set { this["UnderwaterPostProcessMaterial"] = value; } }
    }
    public class WaterBodyHeightmapSettings : Object
    {
        public WaterBodyHeightmapSettings(nint addr) : base(addr) { }
        public EWaterBrushBlendType BlendMode { get { return (EWaterBrushBlendType)this[nameof(BlendMode)].GetValue<int>(); } set { this[nameof(BlendMode)].SetValue<int>((int)value); } }
        public bool bInvertShape { get { return this[nameof(bInvertShape)].Flag; } set { this[nameof(bInvertShape)].Flag = value; } }
        public WaterFalloffSettings FalloffSettings { get { return this[nameof(FalloffSettings)].As<WaterFalloffSettings>(); } set { this["FalloffSettings"] = value; } }
        public WaterBrushEffects Effects { get { return this[nameof(Effects)].As<WaterBrushEffects>(); } set { this["Effects"] = value; } }
        public int Priority { get { return this[nameof(Priority)].GetValue<int>(); } set { this[nameof(Priority)].SetValue<int>(value); } }
    }
    public class WaterBrushEffects : Object
    {
        public WaterBrushEffects(nint addr) : base(addr) { }
        public WaterBrushEffectBlurring Blurring { get { return this[nameof(Blurring)].As<WaterBrushEffectBlurring>(); } set { this["Blurring"] = value; } }
        public WaterBrushEffectCurlNoise CurlNoise { get { return this[nameof(CurlNoise)].As<WaterBrushEffectCurlNoise>(); } set { this["CurlNoise"] = value; } }
        public WaterBrushEffectDisplacement Displacement { get { return this[nameof(Displacement)].As<WaterBrushEffectDisplacement>(); } set { this["Displacement"] = value; } }
        public WaterBrushEffectSmoothBlending SmoothBlending { get { return this[nameof(SmoothBlending)].As<WaterBrushEffectSmoothBlending>(); } set { this["SmoothBlending"] = value; } }
        public WaterBrushEffectTerracing Terracing { get { return this[nameof(Terracing)].As<WaterBrushEffectTerracing>(); } set { this["Terracing"] = value; } }
    }
    public class WaterBrushEffectTerracing : Object
    {
        public WaterBrushEffectTerracing(nint addr) : base(addr) { }
        public float TerraceAlpha { get { return this[nameof(TerraceAlpha)].GetValue<float>(); } set { this[nameof(TerraceAlpha)].SetValue<float>(value); } }
        public float TerraceSpacing { get { return this[nameof(TerraceSpacing)].GetValue<float>(); } set { this[nameof(TerraceSpacing)].SetValue<float>(value); } }
        public float TerraceSmoothness { get { return this[nameof(TerraceSmoothness)].GetValue<float>(); } set { this[nameof(TerraceSmoothness)].SetValue<float>(value); } }
        public float MaskLength { get { return this[nameof(MaskLength)].GetValue<float>(); } set { this[nameof(MaskLength)].SetValue<float>(value); } }
        public float MaskStartOffset { get { return this[nameof(MaskStartOffset)].GetValue<float>(); } set { this[nameof(MaskStartOffset)].SetValue<float>(value); } }
    }
    public class WaterBrushEffectSmoothBlending : Object
    {
        public WaterBrushEffectSmoothBlending(nint addr) : base(addr) { }
        public float InnerSmoothDistance { get { return this[nameof(InnerSmoothDistance)].GetValue<float>(); } set { this[nameof(InnerSmoothDistance)].SetValue<float>(value); } }
        public float OuterSmoothDistance { get { return this[nameof(OuterSmoothDistance)].GetValue<float>(); } set { this[nameof(OuterSmoothDistance)].SetValue<float>(value); } }
    }
    public class WaterBrushEffectDisplacement : Object
    {
        public WaterBrushEffectDisplacement(nint addr) : base(addr) { }
        public float DisplacementHeight { get { return this[nameof(DisplacementHeight)].GetValue<float>(); } set { this[nameof(DisplacementHeight)].SetValue<float>(value); } }
        public float DisplacementTiling { get { return this[nameof(DisplacementTiling)].GetValue<float>(); } set { this[nameof(DisplacementTiling)].SetValue<float>(value); } }
        public Texture2D Texture { get { return this[nameof(Texture)].As<Texture2D>(); } set { this["Texture"] = value; } }
        public float Midpoint { get { return this[nameof(Midpoint)].GetValue<float>(); } set { this[nameof(Midpoint)].SetValue<float>(value); } }
        public LinearColor Channel { get { return this[nameof(Channel)].As<LinearColor>(); } set { this["Channel"] = value; } }
        public float WeightmapInfluence { get { return this[nameof(WeightmapInfluence)].GetValue<float>(); } set { this[nameof(WeightmapInfluence)].SetValue<float>(value); } }
    }
    public class WaterBrushEffectCurlNoise : Object
    {
        public WaterBrushEffectCurlNoise(nint addr) : base(addr) { }
        public float Curl1Amount { get { return this[nameof(Curl1Amount)].GetValue<float>(); } set { this[nameof(Curl1Amount)].SetValue<float>(value); } }
        public float Curl2Amount { get { return this[nameof(Curl2Amount)].GetValue<float>(); } set { this[nameof(Curl2Amount)].SetValue<float>(value); } }
        public float Curl1Tiling { get { return this[nameof(Curl1Tiling)].GetValue<float>(); } set { this[nameof(Curl1Tiling)].SetValue<float>(value); } }
        public float Curl2Tiling { get { return this[nameof(Curl2Tiling)].GetValue<float>(); } set { this[nameof(Curl2Tiling)].SetValue<float>(value); } }
    }
    public class WaterBrushEffectBlurring : Object
    {
        public WaterBrushEffectBlurring(nint addr) : base(addr) { }
        public bool bBlurShape { get { return this[nameof(bBlurShape)].Flag; } set { this[nameof(bBlurShape)].Flag = value; } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
    }
    public class WaterFalloffSettings : Object
    {
        public WaterFalloffSettings(nint addr) : base(addr) { }
        public EWaterBrushFalloffMode FalloffMode { get { return (EWaterBrushFalloffMode)this[nameof(FalloffMode)].GetValue<int>(); } set { this[nameof(FalloffMode)].SetValue<int>((int)value); } }
        public float FalloffAngle { get { return this[nameof(FalloffAngle)].GetValue<float>(); } set { this[nameof(FalloffAngle)].SetValue<float>(value); } }
        public float FalloffWidth { get { return this[nameof(FalloffWidth)].GetValue<float>(); } set { this[nameof(FalloffWidth)].SetValue<float>(value); } }
        public float EdgeOffset { get { return this[nameof(EdgeOffset)].GetValue<float>(); } set { this[nameof(EdgeOffset)].SetValue<float>(value); } }
        public float ZOffset { get { return this[nameof(ZOffset)].GetValue<float>(); } set { this[nameof(ZOffset)].SetValue<float>(value); } }
    }
    public class WaterBrushEffectCurves : Object
    {
        public WaterBrushEffectCurves(nint addr) : base(addr) { }
        public bool bUseCurveChannel { get { return this[nameof(bUseCurveChannel)].Flag; } set { this[nameof(bUseCurveChannel)].Flag = value; } }
        public CurveFloat ElevationCurveAsset { get { return this[nameof(ElevationCurveAsset)].As<CurveFloat>(); } set { this["ElevationCurveAsset"] = value; } }
        public float ChannelEdgeOffset { get { return this[nameof(ChannelEdgeOffset)].GetValue<float>(); } set { this[nameof(ChannelEdgeOffset)].SetValue<float>(value); } }
        public float ChannelDepth { get { return this[nameof(ChannelDepth)].GetValue<float>(); } set { this[nameof(ChannelDepth)].SetValue<float>(value); } }
        public float CurveRampWidth { get { return this[nameof(CurveRampWidth)].GetValue<float>(); } set { this[nameof(CurveRampWidth)].SetValue<float>(value); } }
    }
    public class WaterSplineCurveDefaults : Object
    {
        public WaterSplineCurveDefaults(nint addr) : base(addr) { }
        public float DefaultDepth { get { return this[nameof(DefaultDepth)].GetValue<float>(); } set { this[nameof(DefaultDepth)].SetValue<float>(value); } }
        public float DefaultWidth { get { return this[nameof(DefaultWidth)].GetValue<float>(); } set { this[nameof(DefaultWidth)].SetValue<float>(value); } }
        public float DefaultVelocity { get { return this[nameof(DefaultVelocity)].GetValue<float>(); } set { this[nameof(DefaultVelocity)].SetValue<float>(value); } }
        public float DefaultAudioIntensity { get { return this[nameof(DefaultAudioIntensity)].GetValue<float>(); } set { this[nameof(DefaultAudioIntensity)].SetValue<float>(value); } }
    }
}
