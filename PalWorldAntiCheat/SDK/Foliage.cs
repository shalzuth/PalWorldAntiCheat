using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.FoliageSDK
{
    public class FoliageInstancedStaticMeshComponent : HierarchicalInstancedStaticMeshComponent
    {
        public FoliageInstancedStaticMeshComponent(nint addr) : base(addr) { }
        public Object OnInstanceTakePointDamage { get { return this[nameof(OnInstanceTakePointDamage)]; } set { this[nameof(OnInstanceTakePointDamage)] = value; } }
        public Object OnInstanceTakeRadialDamage { get { return this[nameof(OnInstanceTakeRadialDamage)]; } set { this[nameof(OnInstanceTakeRadialDamage)] = value; } }
        public bool bEnableDiscardOnLoad { get { return this[nameof(bEnableDiscardOnLoad)].Flag; } set { this[nameof(bEnableDiscardOnLoad)].Flag = value; } }
        public Guid GenerationGuid { get { return this[nameof(GenerationGuid)].As<Guid>(); } set { this["GenerationGuid"] = value; } }
    }
    public class FoliageType : Object
    {
        public FoliageType(nint addr) : base(addr) { }
        public Guid UpdateGuid { get { return this[nameof(UpdateGuid)].As<Guid>(); } set { this["UpdateGuid"] = value; } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float DensityAdjustmentFactor { get { return this[nameof(DensityAdjustmentFactor)].GetValue<float>(); } set { this[nameof(DensityAdjustmentFactor)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public bool bSingleInstanceModeOverrideRadius { get { return this[nameof(bSingleInstanceModeOverrideRadius)].Flag; } set { this[nameof(bSingleInstanceModeOverrideRadius)].Flag = value; } }
        public float SingleInstanceModeRadius { get { return this[nameof(SingleInstanceModeRadius)].GetValue<float>(); } set { this[nameof(SingleInstanceModeRadius)].SetValue<float>(value); } }
        public EFoliageScaling Scaling { get { return (EFoliageScaling)this[nameof(Scaling)].GetValue<int>(); } set { this[nameof(Scaling)].SetValue<int>((int)value); } }
        public FloatInterval ScaleX { get { return this[nameof(ScaleX)].As<FloatInterval>(); } set { this["ScaleX"] = value; } }
        public FloatInterval ScaleY { get { return this[nameof(ScaleY)].As<FloatInterval>(); } set { this["ScaleY"] = value; } }
        public FloatInterval ScaleZ { get { return this[nameof(ScaleZ)].As<FloatInterval>(); } set { this["ScaleZ"] = value; } }
        public FoliageVertexColorChannelMask VertexColorMaskByChannel { get { return this[nameof(VertexColorMaskByChannel)].As<FoliageVertexColorChannelMask>(); } set { this["VertexColorMaskByChannel"] = value; } }
        public byte VertexColorMask { get { return this[nameof(VertexColorMask)].GetValue<byte>(); } set { this[nameof(VertexColorMask)].SetValue<byte>(value); } }
        public float VertexColorMaskThreshold { get { return this[nameof(VertexColorMaskThreshold)].GetValue<float>(); } set { this[nameof(VertexColorMaskThreshold)].SetValue<float>(value); } }
        public bool VertexColorMaskInvert { get { return this[nameof(VertexColorMaskInvert)].Flag; } set { this[nameof(VertexColorMaskInvert)].Flag = value; } }
        public FloatInterval ZOffset { get { return this[nameof(ZOffset)].As<FloatInterval>(); } set { this["ZOffset"] = value; } }
        public bool AlignToNormal { get { return this[nameof(AlignToNormal)].Flag; } set { this[nameof(AlignToNormal)].Flag = value; } }
        public bool AverageNormal { get { return this[nameof(AverageNormal)].Flag; } set { this[nameof(AverageNormal)].Flag = value; } }
        public bool AverageNormalSingleComponent { get { return this[nameof(AverageNormalSingleComponent)].Flag; } set { this[nameof(AverageNormalSingleComponent)].Flag = value; } }
        public float AlignMaxAngle { get { return this[nameof(AlignMaxAngle)].GetValue<float>(); } set { this[nameof(AlignMaxAngle)].SetValue<float>(value); } }
        public bool RandomYaw { get { return this[nameof(RandomYaw)].Flag; } set { this[nameof(RandomYaw)].Flag = value; } }
        public float RandomPitchAngle { get { return this[nameof(RandomPitchAngle)].GetValue<float>(); } set { this[nameof(RandomPitchAngle)].SetValue<float>(value); } }
        public FloatInterval GroundSlopeAngle { get { return this[nameof(GroundSlopeAngle)].As<FloatInterval>(); } set { this["GroundSlopeAngle"] = value; } }
        public FloatInterval Height { get { return this[nameof(Height)].As<FloatInterval>(); } set { this["Height"] = value; } }
        public Array<Object> LandscapeLayers { get { return new Array<Object>(this[nameof(LandscapeLayers)].Address); } }
        public float MinimumLayerWeight { get { return this[nameof(MinimumLayerWeight)].GetValue<float>(); } set { this[nameof(MinimumLayerWeight)].SetValue<float>(value); } }
        public Array<Object> ExclusionLandscapeLayers { get { return new Array<Object>(this[nameof(ExclusionLandscapeLayers)].Address); } }
        public float MinimumExclusionLayerWeight { get { return this[nameof(MinimumExclusionLayerWeight)].GetValue<float>(); } set { this[nameof(MinimumExclusionLayerWeight)].SetValue<float>(value); } }
        public Object LandscapeLayer { get { return this[nameof(LandscapeLayer)]; } set { this[nameof(LandscapeLayer)] = value; } }
        public bool CollisionWithWorld { get { return this[nameof(CollisionWithWorld)].Flag; } set { this[nameof(CollisionWithWorld)].Flag = value; } }
        public Vector CollisionScale { get { return this[nameof(CollisionScale)].As<Vector>(); } set { this["CollisionScale"] = value; } }
        public int AverageNormalSampleCount { get { return this[nameof(AverageNormalSampleCount)].GetValue<int>(); } set { this[nameof(AverageNormalSampleCount)].SetValue<int>(value); } }
        public BoxSphereBounds MeshBounds { get { return this[nameof(MeshBounds)].As<BoxSphereBounds>(); } set { this["MeshBounds"] = value; } }
        public Vector LowBoundOriginRadius { get { return this[nameof(LowBoundOriginRadius)].As<Vector>(); } set { this["LowBoundOriginRadius"] = value; } }
        public byte Mobility { get { return this[nameof(Mobility)].GetValue<byte>(); } set { this[nameof(Mobility)].SetValue<byte>(value); } }
        public Int32Interval CullDistance { get { return this[nameof(CullDistance)].As<Int32Interval>(); } set { this["CullDistance"] = value; } }
        public bool bEnableStaticLighting { get { return this[nameof(bEnableStaticLighting)].Flag; } set { this[nameof(bEnableStaticLighting)].Flag = value; } }
        public bool CastShadow { get { return this[nameof(CastShadow)].Flag; } set { this[nameof(CastShadow)].Flag = value; } }
        public bool bAffectDynamicIndirectLighting { get { return this[nameof(bAffectDynamicIndirectLighting)].Flag; } set { this[nameof(bAffectDynamicIndirectLighting)].Flag = value; } }
        public bool bAffectDistanceFieldLighting { get { return this[nameof(bAffectDistanceFieldLighting)].Flag; } set { this[nameof(bAffectDistanceFieldLighting)].Flag = value; } }
        public bool bCastDynamicShadow { get { return this[nameof(bCastDynamicShadow)].Flag; } set { this[nameof(bCastDynamicShadow)].Flag = value; } }
        public bool bCastStaticShadow { get { return this[nameof(bCastStaticShadow)].Flag; } set { this[nameof(bCastStaticShadow)].Flag = value; } }
        public bool bCastContactShadow { get { return this[nameof(bCastContactShadow)].Flag; } set { this[nameof(bCastContactShadow)].Flag = value; } }
        public bool bCastShadowAsTwoSided { get { return this[nameof(bCastShadowAsTwoSided)].Flag; } set { this[nameof(bCastShadowAsTwoSided)].Flag = value; } }
        public bool bReceivesDecals { get { return this[nameof(bReceivesDecals)].Flag; } set { this[nameof(bReceivesDecals)].Flag = value; } }
        public bool bOverrideLightMapRes { get { return this[nameof(bOverrideLightMapRes)].Flag; } set { this[nameof(bOverrideLightMapRes)].Flag = value; } }
        public int OverriddenLightMapRes { get { return this[nameof(OverriddenLightMapRes)].GetValue<int>(); } set { this[nameof(OverriddenLightMapRes)].SetValue<int>(value); } }
        public ELightmapType LightmapType { get { return (ELightmapType)this[nameof(LightmapType)].GetValue<int>(); } set { this[nameof(LightmapType)].SetValue<int>((int)value); } }
        public bool bUseAsOccluder { get { return this[nameof(bUseAsOccluder)].Flag; } set { this[nameof(bUseAsOccluder)].Flag = value; } }
        public bool bVisibleInRayTracing { get { return this[nameof(bVisibleInRayTracing)].Flag; } set { this[nameof(bVisibleInRayTracing)].Flag = value; } }
        public bool bEvaluateWorldPositionOffset { get { return this[nameof(bEvaluateWorldPositionOffset)].Flag; } set { this[nameof(bEvaluateWorldPositionOffset)].Flag = value; } }
        public int WorldPositionOffsetDisableDistance { get { return this[nameof(WorldPositionOffsetDisableDistance)].GetValue<int>(); } set { this[nameof(WorldPositionOffsetDisableDistance)].SetValue<int>(value); } }
        public BodyInstance BodyInstance { get { return this[nameof(BodyInstance)].As<BodyInstance>(); } set { this["BodyInstance"] = value; } }
        public byte CustomNavigableGeometry { get { return this[nameof(CustomNavigableGeometry)].GetValue<byte>(); } set { this[nameof(CustomNavigableGeometry)].SetValue<byte>(value); } }
        public LightingChannels LightingChannels { get { return this[nameof(LightingChannels)].As<LightingChannels>(); } set { this["LightingChannels"] = value; } }
        public bool bRenderCustomDepth { get { return this[nameof(bRenderCustomDepth)].Flag; } set { this[nameof(bRenderCustomDepth)].Flag = value; } }
        public ERendererStencilMask CustomDepthStencilWriteMask { get { return (ERendererStencilMask)this[nameof(CustomDepthStencilWriteMask)].GetValue<int>(); } set { this[nameof(CustomDepthStencilWriteMask)].SetValue<int>((int)value); } }
        public int CustomDepthStencilValue { get { return this[nameof(CustomDepthStencilValue)].GetValue<int>(); } set { this[nameof(CustomDepthStencilValue)].SetValue<int>(value); } }
        public int TranslucencySortPriority { get { return this[nameof(TranslucencySortPriority)].GetValue<int>(); } set { this[nameof(TranslucencySortPriority)].SetValue<int>(value); } }
        public float CollisionRadius { get { return this[nameof(CollisionRadius)].GetValue<float>(); } set { this[nameof(CollisionRadius)].SetValue<float>(value); } }
        public float ShadeRadius { get { return this[nameof(ShadeRadius)].GetValue<float>(); } set { this[nameof(ShadeRadius)].SetValue<float>(value); } }
        public int NumSteps { get { return this[nameof(NumSteps)].GetValue<int>(); } set { this[nameof(NumSteps)].SetValue<int>(value); } }
        public float InitialSeedDensity { get { return this[nameof(InitialSeedDensity)].GetValue<float>(); } set { this[nameof(InitialSeedDensity)].SetValue<float>(value); } }
        public float AverageSpreadDistance { get { return this[nameof(AverageSpreadDistance)].GetValue<float>(); } set { this[nameof(AverageSpreadDistance)].SetValue<float>(value); } }
        public float SpreadVariance { get { return this[nameof(SpreadVariance)].GetValue<float>(); } set { this[nameof(SpreadVariance)].SetValue<float>(value); } }
        public int SeedsPerStep { get { return this[nameof(SeedsPerStep)].GetValue<int>(); } set { this[nameof(SeedsPerStep)].SetValue<int>(value); } }
        public int DistributionSeed { get { return this[nameof(DistributionSeed)].GetValue<int>(); } set { this[nameof(DistributionSeed)].SetValue<int>(value); } }
        public float MaxInitialSeedOffset { get { return this[nameof(MaxInitialSeedOffset)].GetValue<float>(); } set { this[nameof(MaxInitialSeedOffset)].SetValue<float>(value); } }
        public bool bCanGrowInShade { get { return this[nameof(bCanGrowInShade)].Flag; } set { this[nameof(bCanGrowInShade)].Flag = value; } }
        public bool bSpawnsInShade { get { return this[nameof(bSpawnsInShade)].Flag; } set { this[nameof(bSpawnsInShade)].Flag = value; } }
        public float MaxInitialAge { get { return this[nameof(MaxInitialAge)].GetValue<float>(); } set { this[nameof(MaxInitialAge)].SetValue<float>(value); } }
        public float MaxAge { get { return this[nameof(MaxAge)].GetValue<float>(); } set { this[nameof(MaxAge)].SetValue<float>(value); } }
        public float OverlapPriority { get { return this[nameof(OverlapPriority)].GetValue<float>(); } set { this[nameof(OverlapPriority)].SetValue<float>(value); } }
        public FloatInterval ProceduralScale { get { return this[nameof(ProceduralScale)].As<FloatInterval>(); } set { this["ProceduralScale"] = value; } }
        public RuntimeFloatCurve ScaleCurve { get { return this[nameof(ScaleCurve)].As<RuntimeFloatCurve>(); } set { this["ScaleCurve"] = value; } }
        public FoliageDensityFalloff DensityFalloff { get { return this[nameof(DensityFalloff)].As<FoliageDensityFalloff>(); } set { this["DensityFalloff"] = value; } }
        public int ChangeCount { get { return this[nameof(ChangeCount)].GetValue<int>(); } set { this[nameof(ChangeCount)].SetValue<int>(value); } }
        public bool ReapplyDensity { get { return this[nameof(ReapplyDensity)].Flag; } set { this[nameof(ReapplyDensity)].Flag = value; } }
        public bool ReapplyRadius { get { return this[nameof(ReapplyRadius)].Flag; } set { this[nameof(ReapplyRadius)].Flag = value; } }
        public bool ReapplyAlignToNormal { get { return this[nameof(ReapplyAlignToNormal)].Flag; } set { this[nameof(ReapplyAlignToNormal)].Flag = value; } }
        public bool ReapplyRandomYaw { get { return this[nameof(ReapplyRandomYaw)].Flag; } set { this[nameof(ReapplyRandomYaw)].Flag = value; } }
        public bool ReapplyScaling { get { return this[nameof(ReapplyScaling)].Flag; } set { this[nameof(ReapplyScaling)].Flag = value; } }
        public bool ReapplyScaleX { get { return this[nameof(ReapplyScaleX)].Flag; } set { this[nameof(ReapplyScaleX)].Flag = value; } }
        public bool ReapplyScaleY { get { return this[nameof(ReapplyScaleY)].Flag; } set { this[nameof(ReapplyScaleY)].Flag = value; } }
        public bool ReapplyScaleZ { get { return this[nameof(ReapplyScaleZ)].Flag; } set { this[nameof(ReapplyScaleZ)].Flag = value; } }
        public bool ReapplyRandomPitchAngle { get { return this[nameof(ReapplyRandomPitchAngle)].Flag; } set { this[nameof(ReapplyRandomPitchAngle)].Flag = value; } }
        public bool ReapplyGroundSlope { get { return this[nameof(ReapplyGroundSlope)].Flag; } set { this[nameof(ReapplyGroundSlope)].Flag = value; } }
        public bool ReapplyHeight { get { return this[nameof(ReapplyHeight)].Flag; } set { this[nameof(ReapplyHeight)].Flag = value; } }
        public bool ReapplyLandscapeLayers { get { return this[nameof(ReapplyLandscapeLayers)].Flag; } set { this[nameof(ReapplyLandscapeLayers)].Flag = value; } }
        public bool ReapplyZOffset { get { return this[nameof(ReapplyZOffset)].Flag; } set { this[nameof(ReapplyZOffset)].Flag = value; } }
        public bool ReapplyCollisionWithWorld { get { return this[nameof(ReapplyCollisionWithWorld)].Flag; } set { this[nameof(ReapplyCollisionWithWorld)].Flag = value; } }
        public bool ReapplyVertexColorMask { get { return this[nameof(ReapplyVertexColorMask)].Flag; } set { this[nameof(ReapplyVertexColorMask)].Flag = value; } }
        public bool bEnableDensityScaling { get { return this[nameof(bEnableDensityScaling)].Flag; } set { this[nameof(bEnableDensityScaling)].Flag = value; } }
        public bool bEnableDiscardOnLoad { get { return this[nameof(bEnableDiscardOnLoad)].Flag; } set { this[nameof(bEnableDiscardOnLoad)].Flag = value; } }
        public Array<RuntimeVirtualTexture> RuntimeVirtualTextures { get { return new Array<RuntimeVirtualTexture>(this[nameof(RuntimeVirtualTextures)].Address); } }
        public int VirtualTextureCullMips { get { return this[nameof(VirtualTextureCullMips)].GetValue<int>(); } set { this[nameof(VirtualTextureCullMips)].SetValue<int>(value); } }
        public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType { get { return (ERuntimeVirtualTextureMainPassType)this[nameof(VirtualTextureRenderPassType)].GetValue<int>(); } set { this[nameof(VirtualTextureRenderPassType)].SetValue<int>((int)value); } }
    }
    public class FoliageType_InstancedStaticMesh : FoliageType
    {
        public FoliageType_InstancedStaticMesh(nint addr) : base(addr) { }
        public StaticMesh Mesh { get { return this[nameof(Mesh)].As<StaticMesh>(); } set { this["Mesh"] = value; } }
        public Array<MaterialInterface> OverrideMaterials { get { return new Array<MaterialInterface>(this[nameof(OverrideMaterials)].Address); } }
        public Array<MaterialInterface> NaniteOverrideMaterials { get { return new Array<MaterialInterface>(this[nameof(NaniteOverrideMaterials)].Address); } }
        public Object ComponentClass { get { return this[nameof(ComponentClass)]; } set { this[nameof(ComponentClass)] = value; } }
    }
    public class ProceduralFoliageComponent : ActorComponent
    {
        public ProceduralFoliageComponent(nint addr) : base(addr) { }
        public ProceduralFoliageSpawner FoliageSpawner { get { return this[nameof(FoliageSpawner)].As<ProceduralFoliageSpawner>(); } set { this["FoliageSpawner"] = value; } }
        public float TileOverlap { get { return this[nameof(TileOverlap)].GetValue<float>(); } set { this[nameof(TileOverlap)].SetValue<float>(value); } }
        public Volume SpawningVolume { get { return this[nameof(SpawningVolume)].As<Volume>(); } set { this["SpawningVolume"] = value; } }
        public Guid ProceduralGuid { get { return this[nameof(ProceduralGuid)].As<Guid>(); } set { this["ProceduralGuid"] = value; } }
    }
    public class FoliageEditPresetData : Object
    {
        public FoliageEditPresetData(nint addr) : base(addr) { }
        public float BrushSize { get { return this[nameof(BrushSize)].GetValue<float>(); } set { this[nameof(BrushSize)].SetValue<float>(value); } }
        public float PaintDensity { get { return this[nameof(PaintDensity)].GetValue<float>(); } set { this[nameof(PaintDensity)].SetValue<float>(value); } }
        public float EraseDensity { get { return this[nameof(EraseDensity)].GetValue<float>(); } set { this[nameof(EraseDensity)].SetValue<float>(value); } }
        public bool bFilterLandscape { get { return this[nameof(bFilterLandscape)].Flag; } set { this[nameof(bFilterLandscape)].Flag = value; } }
        public bool bFilterStaticMeshes { get { return this[nameof(bFilterStaticMeshes)].Flag; } set { this[nameof(bFilterStaticMeshes)].Flag = value; } }
        public bool bFilterBSP { get { return this[nameof(bFilterBSP)].Flag; } set { this[nameof(bFilterBSP)].Flag = value; } }
        public bool bFilterFoliage { get { return this[nameof(bFilterFoliage)].Flag; } set { this[nameof(bFilterFoliage)].Flag = value; } }
        public bool bFilterTranslucent { get { return this[nameof(bFilterTranslucent)].Flag; } set { this[nameof(bFilterTranslucent)].Flag = value; } }
        public Array<FoliageType> FoliageTypes { get { return new Array<FoliageType>(this[nameof(FoliageTypes)].Address); } }
    }
    public class FoliageType_Actor : FoliageType
    {
        public FoliageType_Actor(nint addr) : base(addr) { }
        public Object actorClass { get { return this[nameof(actorClass)]; } set { this[nameof(actorClass)] = value; } }
        public bool bShouldAttachToBaseComponent { get { return this[nameof(bShouldAttachToBaseComponent)].Flag; } set { this[nameof(bShouldAttachToBaseComponent)].Flag = value; } }
        public bool bStaticMeshOnly { get { return this[nameof(bStaticMeshOnly)].Flag; } set { this[nameof(bStaticMeshOnly)].Flag = value; } }
        public Object StaticMeshOnlyComponentClass { get { return this[nameof(StaticMeshOnlyComponentClass)]; } set { this[nameof(StaticMeshOnlyComponentClass)] = value; } }
    }
    public class InstancedFoliageActor : ISMPartitionActor
    {
        public InstancedFoliageActor(nint addr) : base(addr) { }
    }
    public class InteractiveFoliageComponent : StaticMeshComponent
    {
        public InteractiveFoliageComponent(nint addr) : base(addr) { }
    }
    public class FoliageStatistics : BlueprintFunctionLibrary
    {
        public FoliageStatistics(nint addr) : base(addr) { }
        public int FoliageOverlappingSphereCount(Object WorldContextObject, StaticMesh StaticMesh, Vector CenterPosition, float Radius) { return Invoke<int>(nameof(FoliageOverlappingSphereCount), WorldContextObject, StaticMesh, CenterPosition, Radius); }
        public void FoliageOverlappingBoxTransforms(Object WorldContextObject, StaticMesh StaticMesh, Box Box, Array<Transform> OutTransforms) { Invoke(nameof(FoliageOverlappingBoxTransforms), WorldContextObject, StaticMesh, Box, OutTransforms); }
        public int FoliageOverlappingBoxCount(Object WorldContextObject, StaticMesh StaticMesh, Box Box) { return Invoke<int>(nameof(FoliageOverlappingBoxCount), WorldContextObject, StaticMesh, Box); }
    }
    public class GrassInstancedStaticMeshComponent : HierarchicalInstancedStaticMeshComponent
    {
        public GrassInstancedStaticMeshComponent(nint addr) : base(addr) { }
    }
    public class InteractiveFoliageActor : StaticMeshActor
    {
        public InteractiveFoliageActor(nint addr) : base(addr) { }
        public CapsuleComponent CapsuleComponent { get { return this[nameof(CapsuleComponent)].As<CapsuleComponent>(); } set { this["CapsuleComponent"] = value; } }
        public Vector TouchingActorEntryPosition { get { return this[nameof(TouchingActorEntryPosition)].As<Vector>(); } set { this["TouchingActorEntryPosition"] = value; } }
        public Vector FoliageVelocity { get { return this[nameof(FoliageVelocity)].As<Vector>(); } set { this["FoliageVelocity"] = value; } }
        public Vector FoliageForce { get { return this[nameof(FoliageForce)].As<Vector>(); } set { this["FoliageForce"] = value; } }
        public Vector FoliagePosition { get { return this[nameof(FoliagePosition)].As<Vector>(); } set { this["FoliagePosition"] = value; } }
        public float FoliageDamageImpulseScale { get { return this[nameof(FoliageDamageImpulseScale)].GetValue<float>(); } set { this[nameof(FoliageDamageImpulseScale)].SetValue<float>(value); } }
        public float FoliageTouchImpulseScale { get { return this[nameof(FoliageTouchImpulseScale)].GetValue<float>(); } set { this[nameof(FoliageTouchImpulseScale)].SetValue<float>(value); } }
        public float FoliageStiffness { get { return this[nameof(FoliageStiffness)].GetValue<float>(); } set { this[nameof(FoliageStiffness)].SetValue<float>(value); } }
        public float FoliageStiffnessQuadratic { get { return this[nameof(FoliageStiffnessQuadratic)].GetValue<float>(); } set { this[nameof(FoliageStiffnessQuadratic)].SetValue<float>(value); } }
        public float FoliageDamping { get { return this[nameof(FoliageDamping)].GetValue<float>(); } set { this[nameof(FoliageDamping)].SetValue<float>(value); } }
        public float MaxDamageImpulse { get { return this[nameof(MaxDamageImpulse)].GetValue<float>(); } set { this[nameof(MaxDamageImpulse)].SetValue<float>(value); } }
        public float MaxTouchImpulse { get { return this[nameof(MaxTouchImpulse)].GetValue<float>(); } set { this[nameof(MaxTouchImpulse)].SetValue<float>(value); } }
        public float MaxForce { get { return this[nameof(MaxForce)].GetValue<float>(); } set { this[nameof(MaxForce)].SetValue<float>(value); } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public void CapsuleTouched(PrimitiveComponent OverlappedComp, Actor Other, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult OverlapInfo) { Invoke(nameof(CapsuleTouched), OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, OverlapInfo); }
    }
    public class ProceduralFoliageBlockingVolume : Volume
    {
        public ProceduralFoliageBlockingVolume(nint addr) : base(addr) { }
        public ProceduralFoliageVolume ProceduralFoliageVolume { get { return this[nameof(ProceduralFoliageVolume)].As<ProceduralFoliageVolume>(); } set { this["ProceduralFoliageVolume"] = value; } }
        public FoliageDensityFalloff DensityFalloff { get { return this[nameof(DensityFalloff)].As<FoliageDensityFalloff>(); } set { this["DensityFalloff"] = value; } }
    }
    public class ProceduralFoliageSpawner : Object
    {
        public ProceduralFoliageSpawner(nint addr) : base(addr) { }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public float TileSize { get { return this[nameof(TileSize)].GetValue<float>(); } set { this[nameof(TileSize)].SetValue<float>(value); } }
        public int NumUniqueTiles { get { return this[nameof(NumUniqueTiles)].GetValue<int>(); } set { this[nameof(NumUniqueTiles)].SetValue<int>(value); } }
        public float MinimumQuadTreeSize { get { return this[nameof(MinimumQuadTreeSize)].GetValue<float>(); } set { this[nameof(MinimumQuadTreeSize)].SetValue<float>(value); } }
        public Array<FoliageTypeObject> FoliageTypes { get { return new Array<FoliageTypeObject>(this[nameof(FoliageTypes)].Address); } }
        public void Simulate(int NumSteps) { Invoke(nameof(Simulate), NumSteps); }
    }
    public class ProceduralFoliageTile : Object
    {
        public ProceduralFoliageTile(nint addr) : base(addr) { }
        public ProceduralFoliageSpawner FoliageSpawner { get { return this[nameof(FoliageSpawner)].As<ProceduralFoliageSpawner>(); } set { this["FoliageSpawner"] = value; } }
        public Array<ProceduralFoliageInstance> InstancesArray { get { return new Array<ProceduralFoliageInstance>(this[nameof(InstancesArray)].Address); } }
    }
    public class ProceduralFoliageVolume : Volume
    {
        public ProceduralFoliageVolume(nint addr) : base(addr) { }
        public ProceduralFoliageComponent ProceduralComponent { get { return this[nameof(ProceduralComponent)].As<ProceduralFoliageComponent>(); } set { this["ProceduralComponent"] = value; } }
    }
    public enum FoliageVertexColorMask : int
    {
        FOLIAGEVERTEXCOLORMASK_Disabled = 0,
        FOLIAGEVERTEXCOLORMASK_Red = 1,
        FOLIAGEVERTEXCOLORMASK_Green = 2,
        FOLIAGEVERTEXCOLORMASK_Blue = 3,
        FOLIAGEVERTEXCOLORMASK_Alpha = 4,
        FOLIAGEVERTEXCOLORMASK_MAX = 5,
    }
    public enum EVertexColorMaskChannel : int
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Alpha = 3,
        MAX_None = 4,
        EVertexColorMaskChannel_MAX = 5,
    }
    public enum EFoliageScaling : int
    {
        Uniform = 0,
        Free = 1,
        LockXY = 2,
        LockXZ = 3,
        LockYZ = 4,
        EFoliageScaling_MAX = 5,
    }
    public enum ESimulationOverlap : int
    {
        CollisionOverlap = 0,
        ShadeOverlap = 1,
        None = 2,
        ESimulationOverlap_MAX = 3,
    }
    public enum ESimulationQuery : int
    {
        None = 0,
        CollisionOverlap = 1,
        ShadeOverlap = 2,
        AnyOverlap = 3,
        ESimulationQuery_MAX = 4,
    }
    public class FoliageVertexColorChannelMask : Object
    {
        public FoliageVertexColorChannelMask(nint addr) : base(addr) { }
        public bool UseMask { get { return this[nameof(UseMask)].Flag; } set { this[nameof(UseMask)].Flag = value; } }
        public float MaskThreshold { get { return this[nameof(MaskThreshold)].GetValue<float>(); } set { this[nameof(MaskThreshold)].SetValue<float>(value); } }
        public bool InvertMask { get { return this[nameof(InvertMask)].Flag; } set { this[nameof(InvertMask)].Flag = value; } }
    }
    public class FoliageDensityFalloff : Object
    {
        public FoliageDensityFalloff(nint addr) : base(addr) { }
        public bool bUseFalloffCurve { get { return this[nameof(bUseFalloffCurve)].Flag; } set { this[nameof(bUseFalloffCurve)].Flag = value; } }
        public RuntimeFloatCurve FalloffCurve { get { return this[nameof(FalloffCurve)].As<RuntimeFloatCurve>(); } set { this["FalloffCurve"] = value; } }
    }
    public class FoliageTypeObject : Object
    {
        public FoliageTypeObject(nint addr) : base(addr) { }
        public Object FoliageTypeObject_value { get { return this[nameof(FoliageTypeObject)].As<Object>(); } set { this["FoliageTypeObject"] = value; } }
        public FoliageType TypeInstance { get { return this[nameof(TypeInstance)].As<FoliageType>(); } set { this["TypeInstance"] = value; } }
        public bool bIsAsset { get { return this[nameof(bIsAsset)].Flag; } set { this[nameof(bIsAsset)].Flag = value; } }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
    }
    public class ProceduralFoliageInstance : Object
    {
        public ProceduralFoliageInstance(nint addr) : base(addr) { }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public float Age { get { return this[nameof(Age)].GetValue<float>(); } set { this[nameof(Age)].SetValue<float>(value); } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public FoliageType Type { get { return this[nameof(Type)].As<FoliageType>(); } set { this["Type"] = value; } }
    }
}
