using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.PhysicsCoreSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.LandscapeSDK
{
    public class ControlPointMeshComponent : StaticMeshComponent
    {
        public ControlPointMeshComponent(nint addr) : base(addr) { }
        public float VirtualTextureMainPassMaxDrawDistance { get { return this[nameof(VirtualTextureMainPassMaxDrawDistance)].GetValue<float>(); } set { this[nameof(VirtualTextureMainPassMaxDrawDistance)].SetValue<float>(value); } }
    }
    public class LandscapeSplineInterface : Interface
    {
        public LandscapeSplineInterface(nint addr) : base(addr) { }
    }
    public class LandscapeProxy : PartitionActor
    {
        public LandscapeProxy(nint addr) : base(addr) { }
        public LandscapeSplinesComponent SplineComponent { get { return this[nameof(SplineComponent)].As<LandscapeSplinesComponent>(); } set { this["SplineComponent"] = value; } }
        public Guid LandscapeGuid { get { return this[nameof(LandscapeGuid)].As<Guid>(); } set { this["LandscapeGuid"] = value; } }
        public Array<LandscapePerLODMaterialOverride> PerLODOverrideMaterials { get { return new Array<LandscapePerLODMaterialOverride>(this[nameof(PerLODOverrideMaterials)].Address); } }
        public IntPoint LandscapeSectionOffset { get { return this[nameof(LandscapeSectionOffset)].As<IntPoint>(); } set { this["LandscapeSectionOffset"] = value; } }
        public int MaxLODLevel { get { return this[nameof(MaxLODLevel)].GetValue<int>(); } set { this[nameof(MaxLODLevel)].SetValue<int>(value); } }
        public float ComponentScreenSizeToUseSubSections { get { return this[nameof(ComponentScreenSizeToUseSubSections)].GetValue<float>(); } set { this[nameof(ComponentScreenSizeToUseSubSections)].SetValue<float>(value); } }
        public float LOD0ScreenSize { get { return this[nameof(LOD0ScreenSize)].GetValue<float>(); } set { this[nameof(LOD0ScreenSize)].SetValue<float>(value); } }
        public float LOD0DistributionSetting { get { return this[nameof(LOD0DistributionSetting)].GetValue<float>(); } set { this[nameof(LOD0DistributionSetting)].SetValue<float>(value); } }
        public float LODDistributionSetting { get { return this[nameof(LODDistributionSetting)].GetValue<float>(); } set { this[nameof(LODDistributionSetting)].SetValue<float>(value); } }
        public int StaticLightingLOD { get { return this[nameof(StaticLightingLOD)].GetValue<int>(); } set { this[nameof(StaticLightingLOD)].SetValue<int>(value); } }
        public PhysicalMaterial DefaultPhysMaterial { get { return this[nameof(DefaultPhysMaterial)].As<PhysicalMaterial>(); } set { this["DefaultPhysMaterial"] = value; } }
        public float StreamingDistanceMultiplier { get { return this[nameof(StreamingDistanceMultiplier)].GetValue<float>(); } set { this[nameof(StreamingDistanceMultiplier)].SetValue<float>(value); } }
        public MaterialInterface LandscapeMaterial { get { return this[nameof(LandscapeMaterial)].As<MaterialInterface>(); } set { this["LandscapeMaterial"] = value; } }
        public MaterialInterface LandscapeHoleMaterial { get { return this[nameof(LandscapeHoleMaterial)].As<MaterialInterface>(); } set { this["LandscapeHoleMaterial"] = value; } }
        public Array<RuntimeVirtualTexture> RuntimeVirtualTextures { get { return new Array<RuntimeVirtualTexture>(this[nameof(RuntimeVirtualTextures)].Address); } }
        public bool bSetCreateRuntimeVirtualTextureVolumes { get { return this[nameof(bSetCreateRuntimeVirtualTextureVolumes)].Flag; } set { this[nameof(bSetCreateRuntimeVirtualTextureVolumes)].Flag = value; } }
        public int VirtualTextureNumLods { get { return this[nameof(VirtualTextureNumLods)].GetValue<int>(); } set { this[nameof(VirtualTextureNumLods)].SetValue<int>(value); } }
        public int VirtualTextureLodBias { get { return this[nameof(VirtualTextureLodBias)].GetValue<int>(); } set { this[nameof(VirtualTextureLodBias)].SetValue<int>(value); } }
        public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType { get { return (ERuntimeVirtualTextureMainPassType)this[nameof(VirtualTextureRenderPassType)].GetValue<int>(); } set { this[nameof(VirtualTextureRenderPassType)].SetValue<int>((int)value); } }
        public float NegativeZBoundsExtension { get { return this[nameof(NegativeZBoundsExtension)].GetValue<float>(); } set { this[nameof(NegativeZBoundsExtension)].SetValue<float>(value); } }
        public float PositiveZBoundsExtension { get { return this[nameof(PositiveZBoundsExtension)].GetValue<float>(); } set { this[nameof(PositiveZBoundsExtension)].SetValue<float>(value); } }
        public Array<LandscapeComponent> LandscapeComponents { get { return new Array<LandscapeComponent>(this[nameof(LandscapeComponents)].Address); } }
        public Array<LandscapeHeightfieldCollisionComponent> CollisionComponents { get { return new Array<LandscapeHeightfieldCollisionComponent>(this[nameof(CollisionComponents)].Address); } }
        public Array<HierarchicalInstancedStaticMeshComponent> FoliageComponents { get { return new Array<HierarchicalInstancedStaticMeshComponent>(this[nameof(FoliageComponents)].Address); } }
        public LandscapeNaniteComponent NaniteComponent { get { return this[nameof(NaniteComponent)].As<LandscapeNaniteComponent>(); } set { this["NaniteComponent"] = value; } }
        public bool bHasLandscapeGrass { get { return this[nameof(bHasLandscapeGrass)].Flag; } set { this[nameof(bHasLandscapeGrass)].Flag = value; } }
        public float StaticLightingResolution { get { return this[nameof(StaticLightingResolution)].GetValue<float>(); } set { this[nameof(StaticLightingResolution)].SetValue<float>(value); } }
        public bool CastShadow { get { return this[nameof(CastShadow)].Flag; } set { this[nameof(CastShadow)].Flag = value; } }
        public bool bCastDynamicShadow { get { return this[nameof(bCastDynamicShadow)].Flag; } set { this[nameof(bCastDynamicShadow)].Flag = value; } }
        public bool bCastStaticShadow { get { return this[nameof(bCastStaticShadow)].Flag; } set { this[nameof(bCastStaticShadow)].Flag = value; } }
        public bool bCastContactShadow { get { return this[nameof(bCastContactShadow)].Flag; } set { this[nameof(bCastContactShadow)].Flag = value; } }
        public bool bCastFarShadow { get { return this[nameof(bCastFarShadow)].Flag; } set { this[nameof(bCastFarShadow)].Flag = value; } }
        public bool bCastHiddenShadow { get { return this[nameof(bCastHiddenShadow)].Flag; } set { this[nameof(bCastHiddenShadow)].Flag = value; } }
        public bool bCastShadowAsTwoSided { get { return this[nameof(bCastShadowAsTwoSided)].Flag; } set { this[nameof(bCastShadowAsTwoSided)].Flag = value; } }
        public bool bAffectDistanceFieldLighting { get { return this[nameof(bAffectDistanceFieldLighting)].Flag; } set { this[nameof(bAffectDistanceFieldLighting)].Flag = value; } }
        public LightingChannels LightingChannels { get { return this[nameof(LightingChannels)].As<LightingChannels>(); } set { this["LightingChannels"] = value; } }
        public bool bUseMaterialPositionOffsetInStaticLighting { get { return this[nameof(bUseMaterialPositionOffsetInStaticLighting)].Flag; } set { this[nameof(bUseMaterialPositionOffsetInStaticLighting)].Flag = value; } }
        public bool bRenderCustomDepth { get { return this[nameof(bRenderCustomDepth)].Flag; } set { this[nameof(bRenderCustomDepth)].Flag = value; } }
        public ERendererStencilMask CustomDepthStencilWriteMask { get { return (ERendererStencilMask)this[nameof(CustomDepthStencilWriteMask)].GetValue<int>(); } set { this[nameof(CustomDepthStencilWriteMask)].SetValue<int>((int)value); } }
        public int CustomDepthStencilValue { get { return this[nameof(CustomDepthStencilValue)].GetValue<int>(); } set { this[nameof(CustomDepthStencilValue)].SetValue<int>(value); } }
        public float LDMaxDrawDistance { get { return this[nameof(LDMaxDrawDistance)].GetValue<float>(); } set { this[nameof(LDMaxDrawDistance)].SetValue<float>(value); } }
        public LightmassPrimitiveSettings LightmassSettings { get { return this[nameof(LightmassSettings)].As<LightmassPrimitiveSettings>(); } set { this["LightmassSettings"] = value; } }
        public int CollisionMipLevel { get { return this[nameof(CollisionMipLevel)].GetValue<int>(); } set { this[nameof(CollisionMipLevel)].SetValue<int>(value); } }
        public int SimpleCollisionMipLevel { get { return this[nameof(SimpleCollisionMipLevel)].GetValue<int>(); } set { this[nameof(SimpleCollisionMipLevel)].SetValue<int>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public BodyInstance BodyInstance { get { return this[nameof(BodyInstance)].As<BodyInstance>(); } set { this["BodyInstance"] = value; } }
        public bool bGenerateOverlapEvents { get { return this[nameof(bGenerateOverlapEvents)].Flag; } set { this[nameof(bGenerateOverlapEvents)].Flag = value; } }
        public bool bBakeMaterialPositionOffsetIntoCollision { get { return this[nameof(bBakeMaterialPositionOffsetIntoCollision)].Flag; } set { this[nameof(bBakeMaterialPositionOffsetIntoCollision)].Flag = value; } }
        public int ComponentSizeQuads { get { return this[nameof(ComponentSizeQuads)].GetValue<int>(); } set { this[nameof(ComponentSizeQuads)].SetValue<int>(value); } }
        public int SubsectionSizeQuads { get { return this[nameof(SubsectionSizeQuads)].GetValue<int>(); } set { this[nameof(SubsectionSizeQuads)].SetValue<int>(value); } }
        public int NumSubsections { get { return this[nameof(NumSubsections)].GetValue<int>(); } set { this[nameof(NumSubsections)].SetValue<int>(value); } }
        public bool bUsedForNavigation { get { return this[nameof(bUsedForNavigation)].Flag; } set { this[nameof(bUsedForNavigation)].Flag = value; } }
        public bool bFillCollisionUnderLandscapeForNavmesh { get { return this[nameof(bFillCollisionUnderLandscapeForNavmesh)].Flag; } set { this[nameof(bFillCollisionUnderLandscapeForNavmesh)].Flag = value; } }
        public bool bUseDynamicMaterialInstance { get { return this[nameof(bUseDynamicMaterialInstance)].Flag; } set { this[nameof(bUseDynamicMaterialInstance)].Flag = value; } }
        public ENavDataGatheringMode NavigationGeometryGatheringMode { get { return (ENavDataGatheringMode)this[nameof(NavigationGeometryGatheringMode)].GetValue<int>(); } set { this[nameof(NavigationGeometryGatheringMode)].SetValue<int>((int)value); } }
        public bool bUseLandscapeForCullingInvisibleHLODVertices { get { return this[nameof(bUseLandscapeForCullingInvisibleHLODVertices)].Flag; } set { this[nameof(bUseLandscapeForCullingInvisibleHLODVertices)].Flag = value; } }
        public bool bHasLayersContent { get { return this[nameof(bHasLayersContent)].Flag; } set { this[nameof(bHasLayersContent)].Flag = value; } }
        public void SetVirtualTextureRenderPassType(ERuntimeVirtualTextureMainPassType InType) { Invoke(nameof(SetVirtualTextureRenderPassType), InType); }
        public void SetLandscapeMaterialVectorParameterValue(Object ParameterName, LinearColor Value) { Invoke(nameof(SetLandscapeMaterialVectorParameterValue), ParameterName, Value); }
        public void SetLandscapeMaterialTextureParameterValue(Object ParameterName, Texture Value) { Invoke(nameof(SetLandscapeMaterialTextureParameterValue), ParameterName, Value); }
        public void SetLandscapeMaterialScalarParameterValue(Object ParameterName, float Value) { Invoke(nameof(SetLandscapeMaterialScalarParameterValue), ParameterName, Value); }
        public bool LandscapeExportHeightmapToRenderTarget(TextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel, bool InExportLandscapeProxies) { return Invoke<bool>(nameof(LandscapeExportHeightmapToRenderTarget), InRenderTarget, InExportHeightIntoRGChannel, InExportLandscapeProxies); }
        public Landscape GetLandscapeActor() { return Invoke<Landscape>(nameof(GetLandscapeActor)); }
        public void EditorSetLandscapeMaterial(MaterialInterface NewLandscapeMaterial) { Invoke(nameof(EditorSetLandscapeMaterial), NewLandscapeMaterial); }
        public void EditorApplySpline(SplineComponent InSplineComponent, float StartWidth, float EndWidth, float StartSideFalloff, float EndSideFalloff, float StartRoll, float EndRoll, int NumSubdivisions, bool bRaiseHeights, bool bLowerHeights, LandscapeLayerInfoObject PaintLayer, Object EditLayerName) { Invoke(nameof(EditorApplySpline), InSplineComponent, StartWidth, EndWidth, StartSideFalloff, EndSideFalloff, StartRoll, EndRoll, NumSubdivisions, bRaiseHeights, bLowerHeights, PaintLayer, EditLayerName); }
        public void ChangeLODDistanceFactor(float InLODDistanceFactor) { Invoke(nameof(ChangeLODDistanceFactor), InLODDistanceFactor); }
        public void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections) { Invoke(nameof(ChangeComponentScreenSizeToUseSubSections), InComponentScreenSizeToUseSubSections); }
    }
    public class Landscape : LandscapeProxy
    {
        public Landscape(nint addr) : base(addr) { }
        public void RenderHeightmap(Transform InWorldTransform, Box2D InExtents, TextureRenderTarget2D OutRenderTarget) { Invoke(nameof(RenderHeightmap), InWorldTransform, InExtents, OutRenderTarget); }
    }
    public class LandscapeLODStreamingProxy_DEPRECATED : StreamableRenderAsset
    {
        public LandscapeLODStreamingProxy_DEPRECATED(nint addr) : base(addr) { }
    }
    public class LandscapeComponent : PrimitiveComponent
    {
        public LandscapeComponent(nint addr) : base(addr) { }
        public int SectionBaseX { get { return this[nameof(SectionBaseX)].GetValue<int>(); } set { this[nameof(SectionBaseX)].SetValue<int>(value); } }
        public int SectionBaseY { get { return this[nameof(SectionBaseY)].GetValue<int>(); } set { this[nameof(SectionBaseY)].SetValue<int>(value); } }
        public int ComponentSizeQuads { get { return this[nameof(ComponentSizeQuads)].GetValue<int>(); } set { this[nameof(ComponentSizeQuads)].SetValue<int>(value); } }
        public int SubsectionSizeQuads { get { return this[nameof(SubsectionSizeQuads)].GetValue<int>(); } set { this[nameof(SubsectionSizeQuads)].SetValue<int>(value); } }
        public int NumSubsections { get { return this[nameof(NumSubsections)].GetValue<int>(); } set { this[nameof(NumSubsections)].SetValue<int>(value); } }
        public MaterialInterface OverrideMaterial { get { return this[nameof(OverrideMaterial)].As<MaterialInterface>(); } set { this["OverrideMaterial"] = value; } }
        public MaterialInterface OverrideHoleMaterial { get { return this[nameof(OverrideHoleMaterial)].As<MaterialInterface>(); } set { this["OverrideHoleMaterial"] = value; } }
        public Array<MaterialInstanceConstant> MaterialInstances { get { return new Array<MaterialInstanceConstant>(this[nameof(MaterialInstances)].Address); } }
        public Array<MaterialInstanceDynamic> MaterialInstancesDynamic { get { return new Array<MaterialInstanceDynamic>(this[nameof(MaterialInstancesDynamic)].Address); } }
        public Array<byte> LODIndexToMaterialIndex { get { return new Array<byte>(this[nameof(LODIndexToMaterialIndex)].Address); } }
        public Texture2D XYOffsetmapTexture { get { return this[nameof(XYOffsetmapTexture)].As<Texture2D>(); } set { this["XYOffsetmapTexture"] = value; } }
        public Vector4 WeightmapScaleBias { get { return this[nameof(WeightmapScaleBias)].As<Vector4>(); } set { this["WeightmapScaleBias"] = value; } }
        public float WeightmapSubsectionOffset { get { return this[nameof(WeightmapSubsectionOffset)].GetValue<float>(); } set { this[nameof(WeightmapSubsectionOffset)].SetValue<float>(value); } }
        public Vector4 HeightmapScaleBias { get { return this[nameof(HeightmapScaleBias)].As<Vector4>(); } set { this["HeightmapScaleBias"] = value; } }
        public Box CachedLocalBox { get { return this[nameof(CachedLocalBox)].As<Box>(); } set { this["CachedLocalBox"] = value; } }
        public Object CollisionComponent { get { return this[nameof(CollisionComponent)]; } set { this[nameof(CollisionComponent)] = value; } }
        public bool bNaniteActive { get { return this[nameof(bNaniteActive)].Flag; } set { this[nameof(bNaniteActive)].Flag = value; } }
        public Texture2D HeightmapTexture { get { return this[nameof(HeightmapTexture)].As<Texture2D>(); } set { this["HeightmapTexture"] = value; } }
        public Array<WeightmapLayerAllocationInfo> WeightmapLayerAllocations { get { return new Array<WeightmapLayerAllocationInfo>(this[nameof(WeightmapLayerAllocations)].Address); } }
        public Array<Texture2D> WeightmapTextures { get { return new Array<Texture2D>(this[nameof(WeightmapTextures)].Address); } }
        public Array<LandscapePerLODMaterialOverride> PerLODOverrideMaterials { get { return new Array<LandscapePerLODMaterialOverride>(this[nameof(PerLODOverrideMaterials)].Address); } }
        public Guid MapBuildDataId { get { return this[nameof(MapBuildDataId)].As<Guid>(); } set { this["MapBuildDataId"] = value; } }
        public Array<Guid> IrrelevantLights { get { return new Array<Guid>(this[nameof(IrrelevantLights)].Address); } }
        public int CollisionMipLevel { get { return this[nameof(CollisionMipLevel)].GetValue<int>(); } set { this[nameof(CollisionMipLevel)].SetValue<int>(value); } }
        public int SimpleCollisionMipLevel { get { return this[nameof(SimpleCollisionMipLevel)].GetValue<int>(); } set { this[nameof(SimpleCollisionMipLevel)].SetValue<int>(value); } }
        public float NegativeZBoundsExtension { get { return this[nameof(NegativeZBoundsExtension)].GetValue<float>(); } set { this[nameof(NegativeZBoundsExtension)].SetValue<float>(value); } }
        public float PositiveZBoundsExtension { get { return this[nameof(PositiveZBoundsExtension)].GetValue<float>(); } set { this[nameof(PositiveZBoundsExtension)].SetValue<float>(value); } }
        public float StaticLightingResolution { get { return this[nameof(StaticLightingResolution)].GetValue<float>(); } set { this[nameof(StaticLightingResolution)].SetValue<float>(value); } }
        public int ForcedLOD { get { return this[nameof(ForcedLOD)].GetValue<int>(); } set { this[nameof(ForcedLOD)].SetValue<int>(value); } }
        public int LODBias { get { return this[nameof(LODBias)].GetValue<int>(); } set { this[nameof(LODBias)].SetValue<int>(value); } }
        public Guid StateId { get { return this[nameof(StateId)].As<Guid>(); } set { this["StateId"] = value; } }
        public Guid BakedTextureMaterialGuid { get { return this[nameof(BakedTextureMaterialGuid)].As<Guid>(); } set { this["BakedTextureMaterialGuid"] = value; } }
        public Guid LastBakedTextureMaterialGuid { get { return this[nameof(LastBakedTextureMaterialGuid)].As<Guid>(); } set { this["LastBakedTextureMaterialGuid"] = value; } }
        public Texture2D GIBakedBaseColorTexture { get { return this[nameof(GIBakedBaseColorTexture)].As<Texture2D>(); } set { this["GIBakedBaseColorTexture"] = value; } }
        public MaterialInterface MobileMaterialInterface { get { return this[nameof(MobileMaterialInterface)].As<MaterialInterface>(); } set { this["MobileMaterialInterface"] = value; } }
        public Array<MaterialInterface> MobileMaterialInterfaces { get { return new Array<MaterialInterface>(this[nameof(MobileMaterialInterfaces)].Address); } }
        public Array<Texture2D> MobileWeightmapTextures { get { return new Array<Texture2D>(this[nameof(MobileWeightmapTextures)].Address); } }
        public void SetLODBias(int InLODBias) { Invoke(nameof(SetLODBias), InLODBias); }
        public void SetForcedLOD(int InForcedLOD) { Invoke(nameof(SetForcedLOD), InForcedLOD); }
        public MaterialInstanceDynamic GetMaterialInstanceDynamic(int InIndex) { return Invoke<MaterialInstanceDynamic>(nameof(GetMaterialInstanceDynamic), InIndex); }
        public float EditorGetPaintLayerWeightByNameAtLocation(Vector InLocation, Object InPaintLayerName) { return Invoke<float>(nameof(EditorGetPaintLayerWeightByNameAtLocation), InLocation, InPaintLayerName); }
        public float EditorGetPaintLayerWeightAtLocation(Vector InLocation, LandscapeLayerInfoObject PaintLayer) { return Invoke<float>(nameof(EditorGetPaintLayerWeightAtLocation), InLocation, PaintLayer); }
    }
    public class LandscapeGizmoActor : Actor
    {
        public LandscapeGizmoActor(nint addr) : base(addr) { }
    }
    public class LandscapeGizmoActiveActor : LandscapeGizmoActor
    {
        public LandscapeGizmoActiveActor(nint addr) : base(addr) { }
    }
    public class LandscapeGizmoRenderComponent : PrimitiveComponent
    {
        public LandscapeGizmoRenderComponent(nint addr) : base(addr) { }
    }
    public class LandscapeGrassType : Object
    {
        public LandscapeGrassType(nint addr) : base(addr) { }
        public Array<GrassVariety> GrassVarieties { get { return new Array<GrassVariety>(this[nameof(GrassVarieties)].Address); } }
        public bool bEnableDensityScaling { get { return this[nameof(bEnableDensityScaling)].Flag; } set { this[nameof(bEnableDensityScaling)].Flag = value; } }
        public StaticMesh GrassMesh { get { return this[nameof(GrassMesh)].As<StaticMesh>(); } set { this["GrassMesh"] = value; } }
        public float GrassDensity { get { return this[nameof(GrassDensity)].GetValue<float>(); } set { this[nameof(GrassDensity)].SetValue<float>(value); } }
        public float PlacementJitter { get { return this[nameof(PlacementJitter)].GetValue<float>(); } set { this[nameof(PlacementJitter)].SetValue<float>(value); } }
        public int StartCullDistance { get { return this[nameof(StartCullDistance)].GetValue<int>(); } set { this[nameof(StartCullDistance)].SetValue<int>(value); } }
        public int EndCullDistance { get { return this[nameof(EndCullDistance)].GetValue<int>(); } set { this[nameof(EndCullDistance)].SetValue<int>(value); } }
        public bool RandomRotation { get { return this[nameof(RandomRotation)].Flag; } set { this[nameof(RandomRotation)].Flag = value; } }
        public bool AlignToSurface { get { return this[nameof(AlignToSurface)].Flag; } set { this[nameof(AlignToSurface)].Flag = value; } }
    }
    public class LandscapeHeightfieldCollisionComponent : PrimitiveComponent
    {
        public LandscapeHeightfieldCollisionComponent(nint addr) : base(addr) { }
        public Array<LandscapeLayerInfoObject> ComponentLayerInfos { get { return new Array<LandscapeLayerInfoObject>(this[nameof(ComponentLayerInfos)].Address); } }
        public int SectionBaseX { get { return this[nameof(SectionBaseX)].GetValue<int>(); } set { this[nameof(SectionBaseX)].SetValue<int>(value); } }
        public int SectionBaseY { get { return this[nameof(SectionBaseY)].GetValue<int>(); } set { this[nameof(SectionBaseY)].SetValue<int>(value); } }
        public int CollisionSizeQuads { get { return this[nameof(CollisionSizeQuads)].GetValue<int>(); } set { this[nameof(CollisionSizeQuads)].SetValue<int>(value); } }
        public float CollisionScale { get { return this[nameof(CollisionScale)].GetValue<float>(); } set { this[nameof(CollisionScale)].SetValue<float>(value); } }
        public int SimpleCollisionSizeQuads { get { return this[nameof(SimpleCollisionSizeQuads)].GetValue<int>(); } set { this[nameof(SimpleCollisionSizeQuads)].SetValue<int>(value); } }
        public Array<byte> CollisionQuadFlags { get { return new Array<byte>(this[nameof(CollisionQuadFlags)].Address); } }
        public Guid HeightfieldGuid { get { return this[nameof(HeightfieldGuid)].As<Guid>(); } set { this["HeightfieldGuid"] = value; } }
        public Box CachedLocalBox { get { return this[nameof(CachedLocalBox)].As<Box>(); } set { this["CachedLocalBox"] = value; } }
        public Object RenderComponent { get { return this[nameof(RenderComponent)]; } set { this[nameof(RenderComponent)] = value; } }
        public Array<PhysicalMaterial> CookedPhysicalMaterials { get { return new Array<PhysicalMaterial>(this[nameof(CookedPhysicalMaterials)].Address); } }
        public LandscapeComponent GetRenderComponent() { return Invoke<LandscapeComponent>(nameof(GetRenderComponent)); }
    }
    public class LandscapeLayerInfoObject : Object
    {
        public LandscapeLayerInfoObject(nint addr) : base(addr) { }
        public Object LayerName { get { return this[nameof(LayerName)]; } set { this[nameof(LayerName)] = value; } }
        public PhysicalMaterial PhysMaterial { get { return this[nameof(PhysMaterial)].As<PhysicalMaterial>(); } set { this["PhysMaterial"] = value; } }
        public float Hardness { get { return this[nameof(Hardness)].GetValue<float>(); } set { this[nameof(Hardness)].SetValue<float>(value); } }
        public LinearColor LayerUsageDebugColor { get { return this[nameof(LayerUsageDebugColor)].As<LinearColor>(); } set { this["LayerUsageDebugColor"] = value; } }
    }
    public class LandscapeMaterialInstanceConstant : MaterialInstanceConstant
    {
        public LandscapeMaterialInstanceConstant(nint addr) : base(addr) { }
        public Array<LandscapeMaterialTextureStreamingInfo> TextureStreamingInfo { get { return new Array<LandscapeMaterialTextureStreamingInfo>(this[nameof(TextureStreamingInfo)].Address); } }
        public bool bIsLayerThumbnail { get { return this[nameof(bIsLayerThumbnail)].Flag; } set { this[nameof(bIsLayerThumbnail)].Flag = value; } }
        public bool bDisableTessellation { get { return this[nameof(bDisableTessellation)].Flag; } set { this[nameof(bDisableTessellation)].Flag = value; } }
        public bool bMobile { get { return this[nameof(bMobile)].Flag; } set { this[nameof(bMobile)].Flag = value; } }
        public bool bEditorToolUsage { get { return this[nameof(bEditorToolUsage)].Flag; } set { this[nameof(bEditorToolUsage)].Flag = value; } }
    }
    public class LandscapeMeshCollisionComponent : LandscapeHeightfieldCollisionComponent
    {
        public LandscapeMeshCollisionComponent(nint addr) : base(addr) { }
        public Guid MeshGuid { get { return this[nameof(MeshGuid)].As<Guid>(); } set { this["MeshGuid"] = value; } }
    }
    public class LandscapeMeshProxyActor : Actor
    {
        public LandscapeMeshProxyActor(nint addr) : base(addr) { }
        public LandscapeMeshProxyComponent LandscapeMeshProxyComponent { get { return this[nameof(LandscapeMeshProxyComponent)].As<LandscapeMeshProxyComponent>(); } set { this["LandscapeMeshProxyComponent"] = value; } }
    }
    public class LandscapeMeshProxyComponent : StaticMeshComponent
    {
        public LandscapeMeshProxyComponent(nint addr) : base(addr) { }
        public Guid LandscapeGuid { get { return this[nameof(LandscapeGuid)].As<Guid>(); } set { this["LandscapeGuid"] = value; } }
        public Array<IntPoint> ProxyComponentBases { get { return new Array<IntPoint>(this[nameof(ProxyComponentBases)].Address); } }
        public byte ProxyLOD { get { return this[nameof(ProxyLOD)].GetValue<byte>(); } set { this[nameof(ProxyLOD)].SetValue<byte>(value); } }
    }
    public class LandscapeSettings : DeveloperSettings
    {
        public LandscapeSettings(nint addr) : base(addr) { }
        public int MaxNumberOfLayers { get { return this[nameof(MaxNumberOfLayers)].GetValue<int>(); } set { this[nameof(MaxNumberOfLayers)].SetValue<int>(value); } }
        public int SideResolutionLimit { get { return this[nameof(SideResolutionLimit)].GetValue<int>(); } set { this[nameof(SideResolutionLimit)].SetValue<int>(value); } }
        public Object DefaultLandscapeMaterial { get { return this[nameof(DefaultLandscapeMaterial)]; } set { this[nameof(DefaultLandscapeMaterial)] = value; } }
        public Object DefaultLayerInfoObject { get { return this[nameof(DefaultLayerInfoObject)]; } set { this[nameof(DefaultLayerInfoObject)] = value; } }
        public bool bRestrictiveMode { get { return this[nameof(bRestrictiveMode)].Flag; } set { this[nameof(bRestrictiveMode)].Flag = value; } }
    }
    public class LandscapeSplinesComponent : PrimitiveComponent
    {
        public LandscapeSplinesComponent(nint addr) : base(addr) { }
        public Array<LandscapeSplineControlPoint> ControlPoints { get { return new Array<LandscapeSplineControlPoint>(this[nameof(ControlPoints)].Address); } }
        public Array<LandscapeSplineSegment> Segments { get { return new Array<LandscapeSplineSegment>(this[nameof(Segments)].Address); } }
        public Array<MeshComponent> CookedForeignMeshComponents { get { return new Array<MeshComponent>(this[nameof(CookedForeignMeshComponents)].Address); } }
        public Array<SplineMeshComponent> GetSplineMeshComponents() { return Invoke<Array<SplineMeshComponent>>(nameof(GetSplineMeshComponents)); }
    }
    public class LandscapeSplineControlPoint : Object
    {
        public LandscapeSplineControlPoint(nint addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float LayerWidthRatio { get { return this[nameof(LayerWidthRatio)].GetValue<float>(); } set { this[nameof(LayerWidthRatio)].SetValue<float>(value); } }
        public float SideFalloff { get { return this[nameof(SideFalloff)].GetValue<float>(); } set { this[nameof(SideFalloff)].SetValue<float>(value); } }
        public float LeftSideFalloffFactor { get { return this[nameof(LeftSideFalloffFactor)].GetValue<float>(); } set { this[nameof(LeftSideFalloffFactor)].SetValue<float>(value); } }
        public float RightSideFalloffFactor { get { return this[nameof(RightSideFalloffFactor)].GetValue<float>(); } set { this[nameof(RightSideFalloffFactor)].SetValue<float>(value); } }
        public float LeftSideLayerFalloffFactor { get { return this[nameof(LeftSideLayerFalloffFactor)].GetValue<float>(); } set { this[nameof(LeftSideLayerFalloffFactor)].SetValue<float>(value); } }
        public float RightSideLayerFalloffFactor { get { return this[nameof(RightSideLayerFalloffFactor)].GetValue<float>(); } set { this[nameof(RightSideLayerFalloffFactor)].SetValue<float>(value); } }
        public float EndFalloff { get { return this[nameof(EndFalloff)].GetValue<float>(); } set { this[nameof(EndFalloff)].SetValue<float>(value); } }
        public Array<LandscapeSplineConnection> ConnectedSegments { get { return new Array<LandscapeSplineConnection>(this[nameof(ConnectedSegments)].Address); } }
        public Array<LandscapeSplineInterpPoint> Points { get { return new Array<LandscapeSplineInterpPoint>(this[nameof(Points)].Address); } }
        public Box Bounds { get { return this[nameof(Bounds)].As<Box>(); } set { this["Bounds"] = value; } }
        public ControlPointMeshComponent LocalMeshComponent { get { return this[nameof(LocalMeshComponent)].As<ControlPointMeshComponent>(); } set { this["LocalMeshComponent"] = value; } }
    }
    public class LandscapeSplineSegment : Object
    {
        public LandscapeSplineSegment(nint addr) : base(addr) { }
        public LandscapeSplineSegmentConnection Connections { get { return this[nameof(Connections)].As<LandscapeSplineSegmentConnection>(); } set { this["Connections"] = value; } }
        public InterpCurveVector SplineInfo { get { return this[nameof(SplineInfo)].As<InterpCurveVector>(); } set { this["SplineInfo"] = value; } }
        public Array<LandscapeSplineInterpPoint> Points { get { return new Array<LandscapeSplineInterpPoint>(this[nameof(Points)].Address); } }
        public Box Bounds { get { return this[nameof(Bounds)].As<Box>(); } set { this["Bounds"] = value; } }
        public Array<SplineMeshComponent> LocalMeshComponents { get { return new Array<SplineMeshComponent>(this[nameof(LocalMeshComponents)].Address); } }
    }
    public class LandscapeStreamingProxy : LandscapeProxy
    {
        public LandscapeStreamingProxy(nint addr) : base(addr) { }
        public Object LandscapeActor { get { return this[nameof(LandscapeActor)]; } set { this[nameof(LandscapeActor)] = value; } }
    }
    public class LandscapeWeightmapUsage : Object
    {
        public LandscapeWeightmapUsage(nint addr) : base(addr) { }
        public LandscapeComponent ChannelUsage { get { return this[nameof(ChannelUsage)].As<LandscapeComponent>(); } set { this["ChannelUsage"] = value; } }
        public Guid LayerGuid { get { return this[nameof(LayerGuid)].As<Guid>(); } set { this["LayerGuid"] = value; } }
    }
    public class MaterialExpressionLandscapeGrassOutput : MaterialExpressionCustomOutput
    {
        public MaterialExpressionLandscapeGrassOutput(nint addr) : base(addr) { }
        public Array<GrassInput> GrassTypes { get { return new Array<GrassInput>(this[nameof(GrassTypes)].Address); } }
    }
    public class MaterialExpressionLandscapeLayerBlend : MaterialExpression
    {
        public MaterialExpressionLandscapeLayerBlend(nint addr) : base(addr) { }
        public Array<LayerBlendInput> Layers { get { return new Array<LayerBlendInput>(this[nameof(Layers)].Address); } }
    }
    public class MaterialExpressionLandscapeLayerCoords : MaterialExpression
    {
        public MaterialExpressionLandscapeLayerCoords(nint addr) : base(addr) { }
        public byte MappingType { get { return this[nameof(MappingType)].GetValue<byte>(); } set { this[nameof(MappingType)].SetValue<byte>(value); } }
        public byte CustomUVType { get { return this[nameof(CustomUVType)].GetValue<byte>(); } set { this[nameof(CustomUVType)].SetValue<byte>(value); } }
        public float MappingScale { get { return this[nameof(MappingScale)].GetValue<float>(); } set { this[nameof(MappingScale)].SetValue<float>(value); } }
        public float MappingRotation { get { return this[nameof(MappingRotation)].GetValue<float>(); } set { this[nameof(MappingRotation)].SetValue<float>(value); } }
        public float MappingPanU { get { return this[nameof(MappingPanU)].GetValue<float>(); } set { this[nameof(MappingPanU)].SetValue<float>(value); } }
        public float MappingPanV { get { return this[nameof(MappingPanV)].GetValue<float>(); } set { this[nameof(MappingPanV)].SetValue<float>(value); } }
    }
    public class ControlPointMeshActor : Actor
    {
        public ControlPointMeshActor(nint addr) : base(addr) { }
        public ControlPointMeshComponent ControlPointMeshComponent { get { return this[nameof(ControlPointMeshComponent)].As<ControlPointMeshComponent>(); } set { this["ControlPointMeshComponent"] = value; } }
    }
    public class LandscapeBlueprintBrushBase : Actor
    {
        public LandscapeBlueprintBrushBase(nint addr) : base(addr) { }
        public void RequestLandscapeUpdate() { Invoke(nameof(RequestLandscapeUpdate)); }
        public TextureRenderTarget2D Render(bool InIsHeightmap, TextureRenderTarget2D InCombinedResult, Object InWeightmapLayerName) { return Invoke<TextureRenderTarget2D>(nameof(Render), InIsHeightmap, InCombinedResult, InWeightmapLayerName); }
        public void Initialize(Transform InLandscapeTransform, IntPoint InLandscapeSize, IntPoint InLandscapeRenderTargetSize) { Invoke(nameof(Initialize), InLandscapeTransform, InLandscapeSize, InLandscapeRenderTargetSize); }
        public void GetBlueprintRenderDependencies(Array<Object> OutStreamableAssets) { Invoke(nameof(GetBlueprintRenderDependencies), OutStreamableAssets); }
    }
    public class LandscapeHLODBuilder : HLODBuilder
    {
        public LandscapeHLODBuilder(nint addr) : base(addr) { }
    }
    public class LandscapeInfo : Object
    {
        public LandscapeInfo(nint addr) : base(addr) { }
        public Object LandscapeActor { get { return this[nameof(LandscapeActor)]; } set { this[nameof(LandscapeActor)] = value; } }
        public Guid LandscapeGuid { get { return this[nameof(LandscapeGuid)].As<Guid>(); } set { this["LandscapeGuid"] = value; } }
        public int ComponentSizeQuads { get { return this[nameof(ComponentSizeQuads)].GetValue<int>(); } set { this[nameof(ComponentSizeQuads)].SetValue<int>(value); } }
        public int SubsectionSizeQuads { get { return this[nameof(SubsectionSizeQuads)].GetValue<int>(); } set { this[nameof(SubsectionSizeQuads)].SetValue<int>(value); } }
        public int ComponentNumSubsections { get { return this[nameof(ComponentNumSubsections)].GetValue<int>(); } set { this[nameof(ComponentNumSubsections)].SetValue<int>(value); } }
        public Vector DrawScale { get { return this[nameof(DrawScale)].As<Vector>(); } set { this["DrawScale"] = value; } }
        public Array<Object> StreamingProxies { get { return new Array<Object>(this[nameof(StreamingProxies)].Address); } }
    }
    public class LandscapeInfoMap : Object
    {
        public LandscapeInfoMap(nint addr) : base(addr) { }
    }
    public class LandscapeNaniteComponent : StaticMeshComponent
    {
        public LandscapeNaniteComponent(nint addr) : base(addr) { }
        public Guid ProxyContentId { get { return this[nameof(ProxyContentId)].As<Guid>(); } set { this["ProxyContentId"] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class LandscapeSplineActor : Actor
    {
        public LandscapeSplineActor(nint addr) : base(addr) { }
        public Guid LandscapeGuid { get { return this[nameof(LandscapeGuid)].As<Guid>(); } set { this["LandscapeGuid"] = value; } }
    }
    public class LandscapeSplineMeshesActor : PartitionActor
    {
        public LandscapeSplineMeshesActor(nint addr) : base(addr) { }
        public Array<StaticMeshComponent> StaticMeshComponents { get { return new Array<StaticMeshComponent>(this[nameof(StaticMeshComponents)].Address); } }
    }
    public class LandscapeSubsystem : TickableWorldSubsystem
    {
        public LandscapeSubsystem(nint addr) : base(addr) { }
    }
    public class MaterialExpressionLandscapeLayerSample : MaterialExpression
    {
        public MaterialExpressionLandscapeLayerSample(nint addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public float PreviewWeight { get { return this[nameof(PreviewWeight)].GetValue<float>(); } set { this[nameof(PreviewWeight)].SetValue<float>(value); } }
    }
    public class MaterialExpressionLandscapeLayerSwitch : MaterialExpression
    {
        public MaterialExpressionLandscapeLayerSwitch(nint addr) : base(addr) { }
        public ExpressionInput LayerUsed { get { return this[nameof(LayerUsed)].As<ExpressionInput>(); } set { this["LayerUsed"] = value; } }
        public ExpressionInput LayerNotUsed { get { return this[nameof(LayerNotUsed)].As<ExpressionInput>(); } set { this["LayerNotUsed"] = value; } }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public bool PreviewUsed { get { return this[nameof(PreviewUsed)].Flag; } set { this[nameof(PreviewUsed)].Flag = value; } }
    }
    public class MaterialExpressionLandscapeLayerWeight : MaterialExpression
    {
        public MaterialExpressionLandscapeLayerWeight(nint addr) : base(addr) { }
        public ExpressionInput Base { get { return this[nameof(Base)].As<ExpressionInput>(); } set { this["Base"] = value; } }
        public ExpressionInput Layer { get { return this[nameof(Layer)].As<ExpressionInput>(); } set { this["Layer"] = value; } }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public float PreviewWeight { get { return this[nameof(PreviewWeight)].GetValue<float>(); } set { this[nameof(PreviewWeight)].SetValue<float>(value); } }
        public Vector ConstBase { get { return this[nameof(ConstBase)].As<Vector>(); } set { this["ConstBase"] = value; } }
    }
    public class MaterialExpressionLandscapePhysicalMaterialOutput : MaterialExpressionCustomOutput
    {
        public MaterialExpressionLandscapePhysicalMaterialOutput(nint addr) : base(addr) { }
        public Array<PhysicalMaterialInput> Inputs { get { return new Array<PhysicalMaterialInput>(this[nameof(Inputs)].Address); } }
    }
    public class MaterialExpressionLandscapeVisibilityMask : MaterialExpression
    {
        public MaterialExpressionLandscapeVisibilityMask(nint addr) : base(addr) { }
    }
    public enum ELandscapeSetupErrors : int
    {
        LSE_None = 0,
        LSE_NoLandscapeInfo = 1,
        LSE_CollsionXY = 2,
        LSE_NoLayerInfo = 3,
        LSE_MAX = 4,
    }
    public enum ERTDrawingType : int
    {
        RTAtlas = 0,
        RTAtlasToNonAtlas = 1,
        RTNonAtlasToAtlas = 2,
        RTNonAtlas = 3,
        RTMips = 4,
        ERTDrawingType_MAX = 5,
    }
    public enum EHeightmapRTType : int
    {
        HeightmapRT_CombinedAtlas = 0,
        HeightmapRT_CombinedNonAtlas = 1,
        HeightmapRT_Scratch1 = 2,
        HeightmapRT_Scratch2 = 3,
        HeightmapRT_Scratch3 = 4,
        HeightmapRT_Mip1 = 5,
        HeightmapRT_Mip2 = 6,
        HeightmapRT_Mip3 = 7,
        HeightmapRT_Mip4 = 8,
        HeightmapRT_Mip5 = 9,
        HeightmapRT_Mip6 = 10,
        HeightmapRT_Mip7 = 11,
        HeightmapRT_Count = 12,
        HeightmapRT_MAX = 13,
    }
    public enum EWeightmapRTType : int
    {
        WeightmapRT_Scratch_RGBA = 0,
        WeightmapRT_Scratch1 = 1,
        WeightmapRT_Scratch2 = 2,
        WeightmapRT_Scratch3 = 3,
        WeightmapRT_Mip0 = 4,
        WeightmapRT_Mip1 = 5,
        WeightmapRT_Mip2 = 6,
        WeightmapRT_Mip3 = 7,
        WeightmapRT_Mip4 = 8,
        WeightmapRT_Mip5 = 9,
        WeightmapRT_Mip6 = 10,
        WeightmapRT_Mip7 = 11,
        WeightmapRT_Count = 12,
        WeightmapRT_MAX = 13,
    }
    public enum ELandscapeBlendMode : int
    {
        LSBM_AdditiveBlend = 0,
        LSBM_AlphaBlend = 1,
        LSBM_MAX = 2,
    }
    public enum ELandscapeClearMode : int
    {
        Clear_Weightmap = 1,
        Clear_Heightmap = 2,
        Clear_All = 3,
        Clear_MAX = 4,
    }
    public enum ELandscapeGizmoType : int
    {
        LGT_None = 0,
        LGT_Height = 1,
        LGT_Weight = 2,
        LGT_MAX = 3,
    }
    public enum EGrassScaling : int
    {
        Uniform = 0,
        Free = 1,
        LockXY = 2,
        EGrassScaling_MAX = 3,
    }
    public enum ESplineModulationColorMask : int
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Alpha = 3,
        ESplineModulationColorMask_MAX = 4,
    }
    public enum LandscapeSplineMeshOrientation : int
    {
        LSMO_XUp = 0,
        LSMO_YUp = 1,
        LSMO_MAX = 2,
    }
    public enum ELandscapeLayerBlendType : int
    {
        LB_WeightBlend = 0,
        LB_AlphaBlend = 1,
        LB_HeightBlend = 2,
        LB_MAX = 3,
    }
    public enum ETerrainCoordMappingType : int
    {
        TCMT_Auto = 0,
        TCMT_XY = 1,
        TCMT_XZ = 2,
        TCMT_YZ = 3,
        TCMT_MAX = 4,
    }
    public enum ELandscapeCustomizedCoordType : int
    {
        LCCT_None = 0,
        LCCT_CustomUV0 = 1,
        LCCT_CustomUV1 = 2,
        LCCT_CustomUV2 = 3,
        LCCT_WeightMapUV = 4,
        LCCT_MAX = 5,
    }
    public enum ELandscapeResizeMode : int
    {
        Resample = 0,
        Clip = 1,
        Expand = 2,
        ELandscapeResizeMode_MAX = 3,
    }
    public enum ELandscapeImportAlphamapType : int
    {
        Additive = 0,
        Layered = 1,
        ELandscapeImportAlphamapType_MAX = 2,
    }
    public enum ELandscapeLayerPaintingRestriction : int
    {
        None = 0,
        UseMaxLayers = 1,
        ExistingOnly = 2,
        UseComponentAllowList = 3,
        ELandscapeLayerPaintingRestriction_MAX = 4,
    }
    public enum ELandscapeLayerDisplayMode : int
    {
        Default = 0,
        Alphabetical = 1,
        UserSpecific = 2,
        ELandscapeLayerDisplayMode_MAX = 3,
    }
    public enum ELandscapeLODFalloff : int
    {
        Linear = 0,
        SquareRoot = 1,
        ELandscapeLODFalloff_MAX = 2,
    }
    public class LandscapeLayerBrush : Object
    {
        public LandscapeLayerBrush(nint addr) : base(addr) { }
    }
    public class LandscapeLayer : Object
    {
        public LandscapeLayer(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool bLocked { get { return this[nameof(bLocked)].Flag; } set { this[nameof(bLocked)].Flag = value; } }
        public float HeightmapAlpha { get { return this[nameof(HeightmapAlpha)].GetValue<float>(); } set { this[nameof(HeightmapAlpha)].SetValue<float>(value); } }
        public float WeightmapAlpha { get { return this[nameof(WeightmapAlpha)].GetValue<float>(); } set { this[nameof(WeightmapAlpha)].SetValue<float>(value); } }
        public byte BlendMode { get { return this[nameof(BlendMode)].GetValue<byte>(); } set { this[nameof(BlendMode)].SetValue<byte>(value); } }
        public Array<LandscapeLayerBrush> Brushes { get { return new Array<LandscapeLayerBrush>(this[nameof(Brushes)].Address); } }
        public Object WeightmapLayerAllocationBlend { get { return this[nameof(WeightmapLayerAllocationBlend)]; } set { this[nameof(WeightmapLayerAllocationBlend)] = value; } }
    }
    public class LandscapeEditToolRenderData : Object
    {
        public LandscapeEditToolRenderData(nint addr) : base(addr) { }
        public MaterialInterface ToolMaterial { get { return this[nameof(ToolMaterial)].As<MaterialInterface>(); } set { this["ToolMaterial"] = value; } }
        public MaterialInterface GizmoMaterial { get { return this[nameof(GizmoMaterial)].As<MaterialInterface>(); } set { this["GizmoMaterial"] = value; } }
        public int SelectedType { get { return this[nameof(SelectedType)].GetValue<int>(); } set { this[nameof(SelectedType)].SetValue<int>(value); } }
        public int DebugChannelR { get { return this[nameof(DebugChannelR)].GetValue<int>(); } set { this[nameof(DebugChannelR)].SetValue<int>(value); } }
        public int DebugChannelG { get { return this[nameof(DebugChannelG)].GetValue<int>(); } set { this[nameof(DebugChannelG)].SetValue<int>(value); } }
        public int DebugChannelB { get { return this[nameof(DebugChannelB)].GetValue<int>(); } set { this[nameof(DebugChannelB)].SetValue<int>(value); } }
        public Texture2D DataTexture { get { return this[nameof(DataTexture)].As<Texture2D>(); } set { this["DataTexture"] = value; } }
        public Texture2D LayerContributionTexture { get { return this[nameof(LayerContributionTexture)].As<Texture2D>(); } set { this["LayerContributionTexture"] = value; } }
        public Texture2D DirtyTexture { get { return this[nameof(DirtyTexture)].As<Texture2D>(); } set { this["DirtyTexture"] = value; } }
    }
    public class WeightmapLayerAllocationInfo : Object
    {
        public WeightmapLayerAllocationInfo(nint addr) : base(addr) { }
        public LandscapeLayerInfoObject LayerInfo { get { return this[nameof(LayerInfo)].As<LandscapeLayerInfoObject>(); } set { this["LayerInfo"] = value; } }
        public byte WeightmapTextureIndex { get { return this[nameof(WeightmapTextureIndex)].GetValue<byte>(); } set { this[nameof(WeightmapTextureIndex)].SetValue<byte>(value); } }
        public byte WeightmapTextureChannel { get { return this[nameof(WeightmapTextureChannel)].GetValue<byte>(); } set { this[nameof(WeightmapTextureChannel)].SetValue<byte>(value); } }
    }
    public class LandscapeComponentMaterialOverride : Object
    {
        public LandscapeComponentMaterialOverride(nint addr) : base(addr) { }
        public PerPlatformInt LODIndex { get { return this[nameof(LODIndex)].As<PerPlatformInt>(); } set { this["LODIndex"] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
    }
    public class LandscapePerLODMaterialOverride : Object
    {
        public LandscapePerLODMaterialOverride(nint addr) : base(addr) { }
        public int LODIndex { get { return this[nameof(LODIndex)].GetValue<int>(); } set { this[nameof(LODIndex)].SetValue<int>(value); } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
    }
    public class WeightmapData : Object
    {
        public WeightmapData(nint addr) : base(addr) { }
        public Array<Texture2D> Textures { get { return new Array<Texture2D>(this[nameof(Textures)].Address); } }
        public Array<WeightmapLayerAllocationInfo> LayerAllocations { get { return new Array<WeightmapLayerAllocationInfo>(this[nameof(LayerAllocations)].Address); } }
        public Array<LandscapeWeightmapUsage> TextureUsages { get { return new Array<LandscapeWeightmapUsage>(this[nameof(TextureUsages)].Address); } }
    }
    public class HeightmapData : Object
    {
        public HeightmapData(nint addr) : base(addr) { }
        public Texture2D Texture { get { return this[nameof(Texture)].As<Texture2D>(); } set { this["Texture"] = value; } }
    }
    public class LandscapeLayerComponentData : Object
    {
        public LandscapeLayerComponentData(nint addr) : base(addr) { }
        public HeightmapData HeightmapData { get { return this[nameof(HeightmapData)].As<HeightmapData>(); } set { this["HeightmapData"] = value; } }
        public WeightmapData WeightmapData { get { return this[nameof(WeightmapData)].As<WeightmapData>(); } set { this["WeightmapData"] = value; } }
    }
    public class GizmoSelectData : Object
    {
        public GizmoSelectData(nint addr) : base(addr) { }
    }
    public class GrassVariety : Object
    {
        public GrassVariety(nint addr) : base(addr) { }
        public StaticMesh GrassMesh { get { return this[nameof(GrassMesh)].As<StaticMesh>(); } set { this["GrassMesh"] = value; } }
        public Array<MaterialInterface> OverrideMaterials { get { return new Array<MaterialInterface>(this[nameof(OverrideMaterials)].Address); } }
        public PerPlatformFloat GrassDensity { get { return this[nameof(GrassDensity)].As<PerPlatformFloat>(); } set { this["GrassDensity"] = value; } }
        public bool bUseGrid { get { return this[nameof(bUseGrid)].Flag; } set { this[nameof(bUseGrid)].Flag = value; } }
        public float PlacementJitter { get { return this[nameof(PlacementJitter)].GetValue<float>(); } set { this[nameof(PlacementJitter)].SetValue<float>(value); } }
        public PerPlatformInt StartCullDistance { get { return this[nameof(StartCullDistance)].As<PerPlatformInt>(); } set { this["StartCullDistance"] = value; } }
        public PerPlatformInt EndCullDistance { get { return this[nameof(EndCullDistance)].As<PerPlatformInt>(); } set { this["EndCullDistance"] = value; } }
        public int MinLOD { get { return this[nameof(MinLOD)].GetValue<int>(); } set { this[nameof(MinLOD)].SetValue<int>(value); } }
        public EGrassScaling Scaling { get { return (EGrassScaling)this[nameof(Scaling)].GetValue<int>(); } set { this[nameof(Scaling)].SetValue<int>((int)value); } }
        public FloatInterval ScaleX { get { return this[nameof(ScaleX)].As<FloatInterval>(); } set { this["ScaleX"] = value; } }
        public FloatInterval ScaleY { get { return this[nameof(ScaleY)].As<FloatInterval>(); } set { this["ScaleY"] = value; } }
        public FloatInterval ScaleZ { get { return this[nameof(ScaleZ)].As<FloatInterval>(); } set { this["ScaleZ"] = value; } }
        public bool RandomRotation { get { return this[nameof(RandomRotation)].Flag; } set { this[nameof(RandomRotation)].Flag = value; } }
        public bool AlignToSurface { get { return this[nameof(AlignToSurface)].Flag; } set { this[nameof(AlignToSurface)].Flag = value; } }
        public bool bUseLandscapeLightmap { get { return this[nameof(bUseLandscapeLightmap)].Flag; } set { this[nameof(bUseLandscapeLightmap)].Flag = value; } }
        public LightingChannels LightingChannels { get { return this[nameof(LightingChannels)].As<LightingChannels>(); } set { this["LightingChannels"] = value; } }
        public bool bReceivesDecals { get { return this[nameof(bReceivesDecals)].Flag; } set { this[nameof(bReceivesDecals)].Flag = value; } }
        public bool bCastDynamicShadow { get { return this[nameof(bCastDynamicShadow)].Flag; } set { this[nameof(bCastDynamicShadow)].Flag = value; } }
        public bool bCastContactShadow { get { return this[nameof(bCastContactShadow)].Flag; } set { this[nameof(bCastContactShadow)].Flag = value; } }
        public bool bKeepInstanceBufferCPUCopy { get { return this[nameof(bKeepInstanceBufferCPUCopy)].Flag; } set { this[nameof(bKeepInstanceBufferCPUCopy)].Flag = value; } }
        public uint InstanceWorldPositionOffsetDisableDistance { get { return this[nameof(InstanceWorldPositionOffsetDisableDistance)].GetValue<uint>(); } set { this[nameof(InstanceWorldPositionOffsetDisableDistance)].SetValue<uint>(value); } }
    }
    public class LandscapeMaterialTextureStreamingInfo : Object
    {
        public LandscapeMaterialTextureStreamingInfo(nint addr) : base(addr) { }
        public Object TextureName { get { return this[nameof(TextureName)]; } set { this[nameof(TextureName)] = value; } }
        public float TexelFactor { get { return this[nameof(TexelFactor)].GetValue<float>(); } set { this[nameof(TexelFactor)].SetValue<float>(value); } }
    }
    public class LandscapeSplineConnection : Object
    {
        public LandscapeSplineConnection(nint addr) : base(addr) { }
        public LandscapeSplineSegment Segment { get { return this[nameof(Segment)].As<LandscapeSplineSegment>(); } set { this["Segment"] = value; } }
        public bool End { get { return this[nameof(End)].Flag; } set { this[nameof(End)].Flag = value; } }
    }
    public class ForeignControlPointData : Object
    {
        public ForeignControlPointData(nint addr) : base(addr) { }
    }
    public class ForeignSplineSegmentData : Object
    {
        public ForeignSplineSegmentData(nint addr) : base(addr) { }
    }
    public class ForeignWorldSplineData : Object
    {
        public ForeignWorldSplineData(nint addr) : base(addr) { }
    }
    public class LandscapeSplineInterpPoint : Object
    {
        public LandscapeSplineInterpPoint(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Left { get { return this[nameof(Left)].As<Vector>(); } set { this["Left"] = value; } }
        public Vector Right { get { return this[nameof(Right)].As<Vector>(); } set { this["Right"] = value; } }
        public Vector FalloffLeft { get { return this[nameof(FalloffLeft)].As<Vector>(); } set { this["FalloffLeft"] = value; } }
        public Vector FalloffRight { get { return this[nameof(FalloffRight)].As<Vector>(); } set { this["FalloffRight"] = value; } }
        public Vector LayerLeft { get { return this[nameof(LayerLeft)].As<Vector>(); } set { this["LayerLeft"] = value; } }
        public Vector LayerRight { get { return this[nameof(LayerRight)].As<Vector>(); } set { this["LayerRight"] = value; } }
        public Vector LayerFalloffLeft { get { return this[nameof(LayerFalloffLeft)].As<Vector>(); } set { this["LayerFalloffLeft"] = value; } }
        public Vector LayerFalloffRight { get { return this[nameof(LayerFalloffRight)].As<Vector>(); } set { this["LayerFalloffRight"] = value; } }
        public float StartEndFalloff { get { return this[nameof(StartEndFalloff)].GetValue<float>(); } set { this[nameof(StartEndFalloff)].SetValue<float>(value); } }
    }
    public class LandscapeSplineSegmentConnection : Object
    {
        public LandscapeSplineSegmentConnection(nint addr) : base(addr) { }
        public LandscapeSplineControlPoint ControlPoint { get { return this[nameof(ControlPoint)].As<LandscapeSplineControlPoint>(); } set { this["ControlPoint"] = value; } }
        public float TangentLen { get { return this[nameof(TangentLen)].GetValue<float>(); } set { this[nameof(TangentLen)].SetValue<float>(value); } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class LandscapeSplineMeshEntry : Object
    {
        public LandscapeSplineMeshEntry(nint addr) : base(addr) { }
        public StaticMesh Mesh { get { return this[nameof(Mesh)].As<StaticMesh>(); } set { this["Mesh"] = value; } }
        public Array<MaterialInterface> MaterialOverrides { get { return new Array<MaterialInterface>(this[nameof(MaterialOverrides)].Address); } }
        public bool bCenterH { get { return this[nameof(bCenterH)].Flag; } set { this[nameof(bCenterH)].Flag = value; } }
        public Vector2D CenterAdjust { get { return this[nameof(CenterAdjust)].As<Vector2D>(); } set { this["CenterAdjust"] = value; } }
        public bool bScaleToWidth { get { return this[nameof(bScaleToWidth)].Flag; } set { this[nameof(bScaleToWidth)].Flag = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public byte ForwardAxis { get { return this[nameof(ForwardAxis)].GetValue<byte>(); } set { this[nameof(ForwardAxis)].SetValue<byte>(value); } }
        public byte UpAxis { get { return this[nameof(UpAxis)].GetValue<byte>(); } set { this[nameof(UpAxis)].SetValue<byte>(value); } }
    }
    public class GrassInput : Object
    {
        public GrassInput(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public LandscapeGrassType GrassType { get { return this[nameof(GrassType)].As<LandscapeGrassType>(); } set { this["GrassType"] = value; } }
        public ExpressionInput Input { get { return this[nameof(Input)].As<ExpressionInput>(); } set { this["Input"] = value; } }
    }
    public class LayerBlendInput : Object
    {
        public LayerBlendInput(nint addr) : base(addr) { }
        public Object LayerName { get { return this[nameof(LayerName)]; } set { this[nameof(LayerName)] = value; } }
        public byte BlendType { get { return this[nameof(BlendType)].GetValue<byte>(); } set { this[nameof(BlendType)].SetValue<byte>(value); } }
        public ExpressionInput LayerInput { get { return this[nameof(LayerInput)].As<ExpressionInput>(); } set { this["LayerInput"] = value; } }
        public ExpressionInput HeightInput { get { return this[nameof(HeightInput)].As<ExpressionInput>(); } set { this["HeightInput"] = value; } }
        public float PreviewWeight { get { return this[nameof(PreviewWeight)].GetValue<float>(); } set { this[nameof(PreviewWeight)].SetValue<float>(value); } }
        public Vector ConstLayerInput { get { return this[nameof(ConstLayerInput)].As<Vector>(); } set { this["ConstLayerInput"] = value; } }
        public float ConstHeightInput { get { return this[nameof(ConstHeightInput)].GetValue<float>(); } set { this[nameof(ConstHeightInput)].SetValue<float>(value); } }
    }
    public class LandscapeInfoLayerSettings : Object
    {
        public LandscapeInfoLayerSettings(nint addr) : base(addr) { }
        public LandscapeLayerInfoObject LayerInfoObj { get { return this[nameof(LayerInfoObj)].As<LandscapeLayerInfoObject>(); } set { this["LayerInfoObj"] = value; } }
        public Object LayerName { get { return this[nameof(LayerName)]; } set { this[nameof(LayerName)] = value; } }
    }
    public class LandscapeEditorLayerSettings : Object
    {
        public LandscapeEditorLayerSettings(nint addr) : base(addr) { }
    }
    public class LandscapeLayerStruct : Object
    {
        public LandscapeLayerStruct(nint addr) : base(addr) { }
        public LandscapeLayerInfoObject LayerInfoObj { get { return this[nameof(LayerInfoObj)].As<LandscapeLayerInfoObject>(); } set { this["LayerInfoObj"] = value; } }
    }
    public class LandscapeImportLayerInfo : Object
    {
        public LandscapeImportLayerInfo(nint addr) : base(addr) { }
    }
    public class LandscapeProxyMaterialOverride : Object
    {
        public LandscapeProxyMaterialOverride(nint addr) : base(addr) { }
        public PerPlatformInt LODIndex { get { return this[nameof(LODIndex)].As<PerPlatformInt>(); } set { this["LODIndex"] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
    }
    public class PhysicalMaterialInput : Object
    {
        public PhysicalMaterialInput(nint addr) : base(addr) { }
        public PhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<PhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public ExpressionInput Input { get { return this[nameof(Input)].As<ExpressionInput>(); } set { this["Input"] = value; } }
    }
}
