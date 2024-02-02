using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.PhysicsCoreSDK;
using SDK.Script.FoliageSDK;
namespace SDK.Script.HoudiniEngineRuntimeSDK
{
    public class HoudiniAsset : Object
    {
        public HoudiniAsset(nint addr) : base(addr) { }
        public Object AssetFileName { get { return this[nameof(AssetFileName)]; } set { this[nameof(AssetFileName)] = value; } }
        public Array<byte> AssetBytes { get { return new Array<byte>(this[nameof(AssetBytes)].Address); } }
        public uint AssetBytesCount { get { return this[nameof(AssetBytesCount)].GetValue<uint>(); } set { this[nameof(AssetBytesCount)].SetValue<uint>(value); } }
        public bool bAssetLimitedCommercial { get { return this[nameof(bAssetLimitedCommercial)].Flag; } set { this[nameof(bAssetLimitedCommercial)].Flag = value; } }
        public bool bAssetNonCommercial { get { return this[nameof(bAssetNonCommercial)].Flag; } set { this[nameof(bAssetNonCommercial)].Flag = value; } }
        public bool bAssetExpanded { get { return this[nameof(bAssetExpanded)].Flag; } set { this[nameof(bAssetExpanded)].Flag = value; } }
    }
    public class HoudiniAssetActor : Actor
    {
        public HoudiniAssetActor(nint addr) : base(addr) { }
        public HoudiniAssetComponent HoudiniAssetComponent { get { return this[nameof(HoudiniAssetComponent)].As<HoudiniAssetComponent>(); } set { this["HoudiniAssetComponent"] = value; } }
    }
    public class HoudiniAssetComponent : PrimitiveComponent
    {
        public HoudiniAssetComponent(nint addr) : base(addr) { }
        public HoudiniAsset HoudiniAsset { get { return this[nameof(HoudiniAsset)].As<HoudiniAsset>(); } set { this["HoudiniAsset"] = value; } }
        public bool bCookOnParameterChange { get { return this[nameof(bCookOnParameterChange)].Flag; } set { this[nameof(bCookOnParameterChange)].Flag = value; } }
        public bool bUploadTransformsToHoudiniEngine { get { return this[nameof(bUploadTransformsToHoudiniEngine)].Flag; } set { this[nameof(bUploadTransformsToHoudiniEngine)].Flag = value; } }
        public bool bCookOnTransformChange { get { return this[nameof(bCookOnTransformChange)].Flag; } set { this[nameof(bCookOnTransformChange)].Flag = value; } }
        public bool bCookOnAssetInputCook { get { return this[nameof(bCookOnAssetInputCook)].Flag; } set { this[nameof(bCookOnAssetInputCook)].Flag = value; } }
        public bool bOutputless { get { return this[nameof(bOutputless)].Flag; } set { this[nameof(bOutputless)].Flag = value; } }
        public bool bOutputTemplateGeos { get { return this[nameof(bOutputTemplateGeos)].Flag; } set { this[nameof(bOutputTemplateGeos)].Flag = value; } }
        public bool bUseOutputNodes { get { return this[nameof(bUseOutputNodes)].Flag; } set { this[nameof(bUseOutputNodes)].Flag = value; } }
        public DirectoryPath TemporaryCookFolder { get { return this[nameof(TemporaryCookFolder)].As<DirectoryPath>(); } set { this["TemporaryCookFolder"] = value; } }
        public DirectoryPath BakeFolder { get { return this[nameof(BakeFolder)].As<DirectoryPath>(); } set { this["BakeFolder"] = value; } }
        public EHoudiniStaticMeshMethod StaticMeshMethod { get { return (EHoudiniStaticMeshMethod)this[nameof(StaticMeshMethod)].GetValue<int>(); } set { this[nameof(StaticMeshMethod)].SetValue<int>((int)value); } }
        public HoudiniStaticMeshGenerationProperties StaticMeshGenerationProperties { get { return this[nameof(StaticMeshGenerationProperties)].As<HoudiniStaticMeshGenerationProperties>(); } set { this["StaticMeshGenerationProperties"] = value; } }
        public MeshBuildSettings StaticMeshBuildSettings { get { return this[nameof(StaticMeshBuildSettings)].As<MeshBuildSettings>(); } set { this["StaticMeshBuildSettings"] = value; } }
        public bool bOverrideGlobalProxyStaticMeshSettings { get { return this[nameof(bOverrideGlobalProxyStaticMeshSettings)].Flag; } set { this[nameof(bOverrideGlobalProxyStaticMeshSettings)].Flag = value; } }
        public bool bEnableProxyStaticMeshOverride { get { return this[nameof(bEnableProxyStaticMeshOverride)].Flag; } set { this[nameof(bEnableProxyStaticMeshOverride)].Flag = value; } }
        public bool bEnableProxyStaticMeshRefinementByTimerOverride { get { return this[nameof(bEnableProxyStaticMeshRefinementByTimerOverride)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementByTimerOverride)].Flag = value; } }
        public float ProxyMeshAutoRefineTimeoutSecondsOverride { get { return this[nameof(ProxyMeshAutoRefineTimeoutSecondsOverride)].GetValue<float>(); } set { this[nameof(ProxyMeshAutoRefineTimeoutSecondsOverride)].SetValue<float>(value); } }
        public bool bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride { get { return this[nameof(bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride)].Flag = value; } }
        public bool bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride { get { return this[nameof(bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride)].Flag = value; } }
        public int AssetId { get { return this[nameof(AssetId)].GetValue<int>(); } set { this[nameof(AssetId)].SetValue<int>(value); } }
        public Array<int> NodeIdsToCook { get { return new Array<int>(this[nameof(NodeIdsToCook)].Address); } }
        public Object OutputNodeCookCounts { get { return this[nameof(OutputNodeCookCounts)]; } set { this[nameof(OutputNodeCookCounts)] = value; } }
        public Object DownstreamHoudiniAssets { get { return this[nameof(DownstreamHoudiniAssets)]; } set { this[nameof(DownstreamHoudiniAssets)] = value; } }
        public Guid ComponentGUID { get { return this[nameof(ComponentGUID)].As<Guid>(); } set { this["ComponentGUID"] = value; } }
        public Guid HapiGUID { get { return this[nameof(HapiGUID)].As<Guid>(); } set { this["HapiGUID"] = value; } }
        public Object HapiAssetName { get { return this[nameof(HapiAssetName)]; } set { this[nameof(HapiAssetName)] = value; } }
        public EHoudiniAssetState AssetState { get { return (EHoudiniAssetState)this[nameof(AssetState)].GetValue<int>(); } set { this[nameof(AssetState)].SetValue<int>((int)value); } }
        public EHoudiniAssetState DebugLastAssetState { get { return (EHoudiniAssetState)this[nameof(DebugLastAssetState)].GetValue<int>(); } set { this[nameof(DebugLastAssetState)].SetValue<int>((int)value); } }
        public EHoudiniAssetStateResult AssetStateResult { get { return (EHoudiniAssetStateResult)this[nameof(AssetStateResult)].GetValue<int>(); } set { this[nameof(AssetStateResult)].SetValue<int>((int)value); } }
        public Transform LastComponentTransform { get { return this[nameof(LastComponentTransform)].As<Transform>(); } set { this["LastComponentTransform"] = value; } }
        public uint SubAssetIndex { get { return this[nameof(SubAssetIndex)].GetValue<uint>(); } set { this[nameof(SubAssetIndex)].SetValue<uint>(value); } }
        public int AssetCookCount { get { return this[nameof(AssetCookCount)].GetValue<int>(); } set { this[nameof(AssetCookCount)].SetValue<int>(value); } }
        public bool bHasBeenLoaded { get { return this[nameof(bHasBeenLoaded)].Flag; } set { this[nameof(bHasBeenLoaded)].Flag = value; } }
        public bool bHasBeenDuplicated { get { return this[nameof(bHasBeenDuplicated)].Flag; } set { this[nameof(bHasBeenDuplicated)].Flag = value; } }
        public bool bPendingDelete { get { return this[nameof(bPendingDelete)].Flag; } set { this[nameof(bPendingDelete)].Flag = value; } }
        public bool bRecookRequested { get { return this[nameof(bRecookRequested)].Flag; } set { this[nameof(bRecookRequested)].Flag = value; } }
        public bool bRebuildRequested { get { return this[nameof(bRebuildRequested)].Flag; } set { this[nameof(bRebuildRequested)].Flag = value; } }
        public bool bEnableCooking { get { return this[nameof(bEnableCooking)].Flag; } set { this[nameof(bEnableCooking)].Flag = value; } }
        public bool bForceNeedUpdate { get { return this[nameof(bForceNeedUpdate)].Flag; } set { this[nameof(bForceNeedUpdate)].Flag = value; } }
        public bool bLastCookSuccess { get { return this[nameof(bLastCookSuccess)].Flag; } set { this[nameof(bLastCookSuccess)].Flag = value; } }
        public bool bParameterDefinitionUpdateNeeded { get { return this[nameof(bParameterDefinitionUpdateNeeded)].Flag; } set { this[nameof(bParameterDefinitionUpdateNeeded)].Flag = value; } }
        public bool bBlueprintStructureModified { get { return this[nameof(bBlueprintStructureModified)].Flag; } set { this[nameof(bBlueprintStructureModified)].Flag = value; } }
        public bool bBlueprintModified { get { return this[nameof(bBlueprintModified)].Flag; } set { this[nameof(bBlueprintModified)].Flag = value; } }
        public Array<HoudiniParameter> Parameters { get { return new Array<HoudiniParameter>(this[nameof(Parameters)].Address); } }
        public Array<HoudiniInput> Inputs { get { return new Array<HoudiniInput>(this[nameof(Inputs)].Address); } }
        public Array<HoudiniOutput> Outputs { get { return new Array<HoudiniOutput>(this[nameof(Outputs)].Address); } }
        public Array<HoudiniBakedOutput> BakedOutputs { get { return new Array<HoudiniBakedOutput>(this[nameof(BakedOutputs)].Address); } }
        public Array<Object> UntrackedOutputs { get { return new Array<Object>(this[nameof(UntrackedOutputs)].Address); } }
        public Array<HoudiniHandleComponent> HandleComponents { get { return new Array<HoudiniHandleComponent>(this[nameof(HandleComponents)].Address); } }
        public bool bHasComponentTransformChanged { get { return this[nameof(bHasComponentTransformChanged)].Flag; } set { this[nameof(bHasComponentTransformChanged)].Flag = value; } }
        public bool bFullyLoaded { get { return this[nameof(bFullyLoaded)].Flag; } set { this[nameof(bFullyLoaded)].Flag = value; } }
        public HoudiniPDGAssetLink PDGAssetLink { get { return this[nameof(PDGAssetLink)].As<HoudiniPDGAssetLink>(); } set { this["PDGAssetLink"] = value; } }
        public TimerHandle RefineMeshesTimer { get { return this[nameof(RefineMeshesTimer)].As<TimerHandle>(); } set { this["RefineMeshesTimer"] = value; } }
        public bool bNoProxyMeshNextCookRequested { get { return this[nameof(bNoProxyMeshNextCookRequested)].Flag; } set { this[nameof(bNoProxyMeshNextCookRequested)].Flag = value; } }
        public Object InputPresets { get { return this[nameof(InputPresets)]; } set { this[nameof(InputPresets)] = value; } }
        public bool bBakeAfterNextCook { get { return this[nameof(bBakeAfterNextCook)].Flag; } set { this[nameof(bBakeAfterNextCook)].Flag = value; } }
        public bool bCachedIsPreview { get { return this[nameof(bCachedIsPreview)].Flag; } set { this[nameof(bCachedIsPreview)].Flag = value; } }
        public double LastTickTime { get { return this[nameof(LastTickTime)].GetValue<double>(); } set { this[nameof(LastTickTime)].SetValue<double>(value); } }
    }
    public class HoudiniAssetBlueprintComponent : HoudiniAssetComponent
    {
        public HoudiniAssetBlueprintComponent(nint addr) : base(addr) { }
        public bool FauxBPProperty { get { return this[nameof(FauxBPProperty)].Flag; } set { this[nameof(FauxBPProperty)].Flag = value; } }
        public bool bHoudiniAssetChanged { get { return this[nameof(bHoudiniAssetChanged)].Flag; } set { this[nameof(bHoudiniAssetChanged)].Flag = value; } }
        public bool bUpdatedFromTemplate { get { return this[nameof(bUpdatedFromTemplate)].Flag; } set { this[nameof(bUpdatedFromTemplate)].Flag = value; } }
        public bool bIsInBlueprintEditor { get { return this[nameof(bIsInBlueprintEditor)].Flag; } set { this[nameof(bIsInBlueprintEditor)].Flag = value; } }
        public bool bCanDeleteHoudiniNodes { get { return this[nameof(bCanDeleteHoudiniNodes)].Flag; } set { this[nameof(bCanDeleteHoudiniNodes)].Flag = value; } }
        public bool bHasRegisteredComponentTemplate { get { return this[nameof(bHasRegisteredComponentTemplate)].Flag; } set { this[nameof(bHasRegisteredComponentTemplate)].Flag = value; } }
        public Object CachedOutputNodes { get { return this[nameof(CachedOutputNodes)]; } set { this[nameof(CachedOutputNodes)] = value; } }
        public Object CachedInputNodes { get { return this[nameof(CachedInputNodes)]; } set { this[nameof(CachedInputNodes)] = value; } }
        public void SetToggleValueAt(Object Name, bool Value, int Index) { Invoke(nameof(SetToggleValueAt), Name, Value, Index); }
        public void SetFloatParameter(Object Name, float Value, int Index) { Invoke(nameof(SetFloatParameter), Name, Value, Index); }
        public bool HasParameter(Object Name) { return Invoke<bool>(nameof(HasParameter), Name); }
    }
    public class HoudiniAssetParameter : Object
    {
        public HoudiniAssetParameter(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterButton : HoudiniAssetParameter
    {
        public HoudiniAssetParameterButton(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterChoice : HoudiniAssetParameter
    {
        public HoudiniAssetParameterChoice(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterColor : HoudiniAssetParameter
    {
        public HoudiniAssetParameterColor(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterFile : HoudiniAssetParameter
    {
        public HoudiniAssetParameterFile(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterFloat : HoudiniAssetParameter
    {
        public HoudiniAssetParameterFloat(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterFolder : HoudiniAssetParameter
    {
        public HoudiniAssetParameterFolder(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterFolderList : HoudiniAssetParameter
    {
        public HoudiniAssetParameterFolderList(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterInt : HoudiniAssetParameter
    {
        public HoudiniAssetParameterInt(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterLabel : HoudiniAssetParameter
    {
        public HoudiniAssetParameterLabel(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterMultiparm : HoudiniAssetParameter
    {
        public HoudiniAssetParameterMultiparm(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterRamp : HoudiniAssetParameter
    {
        public HoudiniAssetParameterRamp(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterSeparator : HoudiniAssetParameter
    {
        public HoudiniAssetParameterSeparator(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterString : HoudiniAssetParameter
    {
        public HoudiniAssetParameterString(nint addr) : base(addr) { }
    }
    public class HoudiniAssetParameterToggle : HoudiniAssetParameter
    {
        public HoudiniAssetParameterToggle(nint addr) : base(addr) { }
    }
    public class HoudiniAssetComponentMaterials_V1 : Object
    {
        public HoudiniAssetComponentMaterials_V1(nint addr) : base(addr) { }
    }
    public class HoudiniHandleComponent_V1 : SceneComponent
    {
        public HoudiniHandleComponent_V1(nint addr) : base(addr) { }
    }
    public class HoudiniSplineComponent_V1 : SceneComponent
    {
        public HoudiniSplineComponent_V1(nint addr) : base(addr) { }
    }
    public class HoudiniAssetInput : HoudiniAssetParameter
    {
        public HoudiniAssetInput(nint addr) : base(addr) { }
    }
    public class HoudiniAssetInstanceInput : HoudiniAssetParameter
    {
        public HoudiniAssetInstanceInput(nint addr) : base(addr) { }
    }
    public class HoudiniAssetInstanceInputField : Object
    {
        public HoudiniAssetInstanceInputField(nint addr) : base(addr) { }
    }
    public class HoudiniAssetComponent_V1 : PrimitiveComponent
    {
        public HoudiniAssetComponent_V1(nint addr) : base(addr) { }
        public bool bGeneratedDoubleSidedGeometry { get { return this[nameof(bGeneratedDoubleSidedGeometry)].Flag; } set { this[nameof(bGeneratedDoubleSidedGeometry)].Flag = value; } }
        public PhysicalMaterial GeneratedPhysMaterial { get { return this[nameof(GeneratedPhysMaterial)].As<PhysicalMaterial>(); } set { this["GeneratedPhysMaterial"] = value; } }
        public BodyInstance DefaultBodyInstance { get { return this[nameof(DefaultBodyInstance)].As<BodyInstance>(); } set { this["DefaultBodyInstance"] = value; } }
        public byte GeneratedCollisionTraceFlag { get { return this[nameof(GeneratedCollisionTraceFlag)].GetValue<byte>(); } set { this[nameof(GeneratedCollisionTraceFlag)].SetValue<byte>(value); } }
        public int GeneratedLightMapResolution { get { return this[nameof(GeneratedLightMapResolution)].GetValue<int>(); } set { this[nameof(GeneratedLightMapResolution)].SetValue<int>(value); } }
        public float GeneratedDistanceFieldResolutionScale { get { return this[nameof(GeneratedDistanceFieldResolutionScale)].GetValue<float>(); } set { this[nameof(GeneratedDistanceFieldResolutionScale)].SetValue<float>(value); } }
        public WalkableSlopeOverride GeneratedWalkableSlopeOverride { get { return this[nameof(GeneratedWalkableSlopeOverride)].As<WalkableSlopeOverride>(); } set { this["GeneratedWalkableSlopeOverride"] = value; } }
        public int GeneratedLightMapCoordinateIndex { get { return this[nameof(GeneratedLightMapCoordinateIndex)].GetValue<int>(); } set { this[nameof(GeneratedLightMapCoordinateIndex)].SetValue<int>(value); } }
        public bool bGeneratedUseMaximumStreamingTexelRatio { get { return this[nameof(bGeneratedUseMaximumStreamingTexelRatio)].Flag; } set { this[nameof(bGeneratedUseMaximumStreamingTexelRatio)].Flag = value; } }
        public float GeneratedStreamingDistanceMultiplier { get { return this[nameof(GeneratedStreamingDistanceMultiplier)].GetValue<float>(); } set { this[nameof(GeneratedStreamingDistanceMultiplier)].SetValue<float>(value); } }
        public FoliageType_InstancedStaticMesh GeneratedFoliageDefaultSettings { get { return this[nameof(GeneratedFoliageDefaultSettings)].As<FoliageType_InstancedStaticMesh>(); } set { this["GeneratedFoliageDefaultSettings"] = value; } }
        public Array<AssetUserData> GeneratedAssetUserData { get { return new Array<AssetUserData>(this[nameof(GeneratedAssetUserData)].Address); } }
        public Object BakeFolder { get { return this[nameof(BakeFolder)]; } set { this[nameof(BakeFolder)] = value; } }
        public Object TempCookFolder { get { return this[nameof(TempCookFolder)]; } set { this[nameof(TempCookFolder)] = value; } }
    }
    public class HoudiniInstancedActorComponent_V1 : SceneComponent
    {
        public HoudiniInstancedActorComponent_V1(nint addr) : base(addr) { }
    }
    public class HoudiniMeshSplitInstancerComponent_V1 : SceneComponent
    {
        public HoudiniMeshSplitInstancerComponent_V1(nint addr) : base(addr) { }
    }
    public class HoudiniEngineCopyPropertiesInterface : Interface
    {
        public HoudiniEngineCopyPropertiesInterface(nint addr) : base(addr) { }
    }
    public class HoudiniHandleParameter : Object
    {
        public HoudiniHandleParameter(nint addr) : base(addr) { }
        public HoudiniParameter AssetParameter { get { return this[nameof(AssetParameter)].As<HoudiniParameter>(); } set { this["AssetParameter"] = value; } }
        public int TupleIndex { get { return this[nameof(TupleIndex)].GetValue<int>(); } set { this[nameof(TupleIndex)].SetValue<int>(value); } }
    }
    public class HoudiniHandleComponent : SceneComponent
    {
        public HoudiniHandleComponent(nint addr) : base(addr) { }
        public Array<HoudiniHandleParameter> XformParms { get { return new Array<HoudiniHandleParameter>(this[nameof(XformParms)].Address); } }
        public HoudiniHandleParameter RSTParm { get { return this[nameof(RSTParm)].As<HoudiniHandleParameter>(); } set { this["RSTParm"] = value; } }
        public HoudiniHandleParameter RotOrderParm { get { return this[nameof(RotOrderParm)].As<HoudiniHandleParameter>(); } set { this["RotOrderParm"] = value; } }
        public EHoudiniHandleType HandleType { get { return (EHoudiniHandleType)this[nameof(HandleType)].GetValue<int>(); } set { this[nameof(HandleType)].SetValue<int>((int)value); } }
        public Object HandleName { get { return this[nameof(HandleName)]; } set { this[nameof(HandleName)] = value; } }
    }
    public class HoudiniInput : Object
    {
        public HoudiniInput(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public EHoudiniInputType Type { get { return (EHoudiniInputType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public EHoudiniInputType PreviousType { get { return (EHoudiniInputType)this[nameof(PreviousType)].GetValue<int>(); } set { this[nameof(PreviousType)].SetValue<int>((int)value); } }
        public int AssetNodeId { get { return this[nameof(AssetNodeId)].GetValue<int>(); } set { this[nameof(AssetNodeId)].SetValue<int>(value); } }
        public int InputNodeId { get { return this[nameof(InputNodeId)].GetValue<int>(); } set { this[nameof(InputNodeId)].SetValue<int>(value); } }
        public int InputIndex { get { return this[nameof(InputIndex)].GetValue<int>(); } set { this[nameof(InputIndex)].SetValue<int>(value); } }
        public int ParmId { get { return this[nameof(ParmId)].GetValue<int>(); } set { this[nameof(ParmId)].SetValue<int>(value); } }
        public bool bIsObjectPathParameter { get { return this[nameof(bIsObjectPathParameter)].Flag; } set { this[nameof(bIsObjectPathParameter)].Flag = value; } }
        public Array<int> CreatedDataNodeIds { get { return new Array<int>(this[nameof(CreatedDataNodeIds)].Address); } }
        public bool bHasChanged { get { return this[nameof(bHasChanged)].Flag; } set { this[nameof(bHasChanged)].Flag = value; } }
        public bool bNeedsToTriggerUpdate { get { return this[nameof(bNeedsToTriggerUpdate)].Flag; } set { this[nameof(bNeedsToTriggerUpdate)].Flag = value; } }
        public Box CachedBounds { get { return this[nameof(CachedBounds)].As<Box>(); } set { this["CachedBounds"] = value; } }
        public Object Help { get { return this[nameof(Help)]; } set { this[nameof(Help)] = value; } }
        public EHoudiniXformType KeepWorldTransform { get { return (EHoudiniXformType)this[nameof(KeepWorldTransform)].GetValue<int>(); } set { this[nameof(KeepWorldTransform)].SetValue<int>((int)value); } }
        public bool bPackBeforeMerge { get { return this[nameof(bPackBeforeMerge)].Flag; } set { this[nameof(bPackBeforeMerge)].Flag = value; } }
        public bool bImportAsReference { get { return this[nameof(bImportAsReference)].Flag; } set { this[nameof(bImportAsReference)].Flag = value; } }
        public bool bImportAsReferenceRotScaleEnabled { get { return this[nameof(bImportAsReferenceRotScaleEnabled)].Flag; } set { this[nameof(bImportAsReferenceRotScaleEnabled)].Flag = value; } }
        public bool bImportAsReferenceBboxEnabled { get { return this[nameof(bImportAsReferenceBboxEnabled)].Flag; } set { this[nameof(bImportAsReferenceBboxEnabled)].Flag = value; } }
        public bool bImportAsReferenceMaterialEnabled { get { return this[nameof(bImportAsReferenceMaterialEnabled)].Flag; } set { this[nameof(bImportAsReferenceMaterialEnabled)].Flag = value; } }
        public bool bExportLODs { get { return this[nameof(bExportLODs)].Flag; } set { this[nameof(bExportLODs)].Flag = value; } }
        public bool bExportSockets { get { return this[nameof(bExportSockets)].Flag; } set { this[nameof(bExportSockets)].Flag = value; } }
        public bool bPreferNaniteFallbackMesh { get { return this[nameof(bPreferNaniteFallbackMesh)].Flag; } set { this[nameof(bPreferNaniteFallbackMesh)].Flag = value; } }
        public bool bExportColliders { get { return this[nameof(bExportColliders)].Flag; } set { this[nameof(bExportColliders)].Flag = value; } }
        public bool bExportMaterialParameters { get { return this[nameof(bExportMaterialParameters)].Flag; } set { this[nameof(bExportMaterialParameters)].Flag = value; } }
        public bool bCookOnCurveChanged { get { return this[nameof(bCookOnCurveChanged)].Flag; } set { this[nameof(bCookOnCurveChanged)].Flag = value; } }
        public Array<HoudiniInputObject> GeometryInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(GeometryInputObjects)].Address); } }
        public bool bStaticMeshChanged { get { return this[nameof(bStaticMeshChanged)].Flag; } set { this[nameof(bStaticMeshChanged)].Flag = value; } }
        public Array<HoudiniInputObject> AssetInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(AssetInputObjects)].Address); } }
        public bool bInputAssetConnectedInHoudini { get { return this[nameof(bInputAssetConnectedInHoudini)].Flag; } set { this[nameof(bInputAssetConnectedInHoudini)].Flag = value; } }
        public Array<HoudiniInputObject> CurveInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(CurveInputObjects)].Address); } }
        public float DefaultCurveOffset { get { return this[nameof(DefaultCurveOffset)].GetValue<float>(); } set { this[nameof(DefaultCurveOffset)].SetValue<float>(value); } }
        public bool bAddRotAndScaleAttributesOnCurves { get { return this[nameof(bAddRotAndScaleAttributesOnCurves)].Flag; } set { this[nameof(bAddRotAndScaleAttributesOnCurves)].Flag = value; } }
        public bool bUseLegacyInputCurves { get { return this[nameof(bUseLegacyInputCurves)].Flag; } set { this[nameof(bUseLegacyInputCurves)].Flag = value; } }
        public Array<HoudiniInputObject> LandscapeInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(LandscapeInputObjects)].Address); } }
        public bool bLandscapeHasExportTypeChanged { get { return this[nameof(bLandscapeHasExportTypeChanged)].Flag; } set { this[nameof(bLandscapeHasExportTypeChanged)].Flag = value; } }
        public Array<HoudiniInputObject> WorldInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(WorldInputObjects)].Address); } }
        public Array<Actor> WorldInputBoundSelectorObjects { get { return new Array<Actor>(this[nameof(WorldInputBoundSelectorObjects)].Address); } }
        public bool bIsWorldInputBoundSelector { get { return this[nameof(bIsWorldInputBoundSelector)].Flag; } set { this[nameof(bIsWorldInputBoundSelector)].Flag = value; } }
        public bool bWorldInputBoundSelectorAutoUpdate { get { return this[nameof(bWorldInputBoundSelectorAutoUpdate)].Flag; } set { this[nameof(bWorldInputBoundSelectorAutoUpdate)].Flag = value; } }
        public float UnrealSplineResolution { get { return this[nameof(UnrealSplineResolution)].GetValue<float>(); } set { this[nameof(UnrealSplineResolution)].SetValue<float>(value); } }
        public Array<HoudiniInputObject> SkeletalInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(SkeletalInputObjects)].Address); } }
        public Array<HoudiniInputObject> GeometryCollectionInputObjects { get { return new Array<HoudiniInputObject>(this[nameof(GeometryCollectionInputObjects)].Address); } }
        public Object LandscapeSelectedComponents { get { return this[nameof(LandscapeSelectedComponents)]; } set { this[nameof(LandscapeSelectedComponents)] = value; } }
        public Object InputNodesPendingDelete { get { return this[nameof(InputNodesPendingDelete)]; } set { this[nameof(InputNodesPendingDelete)] = value; } }
        public Array<HoudiniInputHoudiniSplineComponent> LastInsertedInputs { get { return new Array<HoudiniInputHoudiniSplineComponent>(this[nameof(LastInsertedInputs)].Address); } }
        public Array<HoudiniInputObject> LastUndoDeletedInputs { get { return new Array<HoudiniInputObject>(this[nameof(LastUndoDeletedInputs)].Address); } }
        public bool bUpdateInputLandscape { get { return this[nameof(bUpdateInputLandscape)].Flag; } set { this[nameof(bUpdateInputLandscape)].Flag = value; } }
        public EHoudiniLandscapeExportType LandscapeExportType { get { return (EHoudiniLandscapeExportType)this[nameof(LandscapeExportType)].GetValue<int>(); } set { this[nameof(LandscapeExportType)].SetValue<int>((int)value); } }
        public bool bLandscapeExportSelectionOnly { get { return this[nameof(bLandscapeExportSelectionOnly)].Flag; } set { this[nameof(bLandscapeExportSelectionOnly)].Flag = value; } }
        public bool bLandscapeAutoSelectComponent { get { return this[nameof(bLandscapeAutoSelectComponent)].Flag; } set { this[nameof(bLandscapeAutoSelectComponent)].Flag = value; } }
        public bool bLandscapeExportMaterials { get { return this[nameof(bLandscapeExportMaterials)].Flag; } set { this[nameof(bLandscapeExportMaterials)].Flag = value; } }
        public bool bLandscapeExportLighting { get { return this[nameof(bLandscapeExportLighting)].Flag; } set { this[nameof(bLandscapeExportLighting)].Flag = value; } }
        public bool bLandscapeExportNormalizedUVs { get { return this[nameof(bLandscapeExportNormalizedUVs)].Flag; } set { this[nameof(bLandscapeExportNormalizedUVs)].Flag = value; } }
        public bool bLandscapeExportTileUVs { get { return this[nameof(bLandscapeExportTileUVs)].Flag; } set { this[nameof(bLandscapeExportTileUVs)].Flag = value; } }
        public bool bCanDeleteHoudiniNodes { get { return this[nameof(bCanDeleteHoudiniNodes)].Flag; } set { this[nameof(bCanDeleteHoudiniNodes)].Flag = value; } }
    }
    public class HoudiniInputObject : Object
    {
        public HoudiniInputObject(nint addr) : base(addr) { }
        public Object InputObject { get { return this[nameof(InputObject)]; } set { this[nameof(InputObject)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public EHoudiniInputObjectType Type { get { return (EHoudiniInputObjectType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int InputNodeId { get { return this[nameof(InputNodeId)].GetValue<int>(); } set { this[nameof(InputNodeId)].SetValue<int>(value); } }
        public int InputObjectNodeId { get { return this[nameof(InputObjectNodeId)].GetValue<int>(); } set { this[nameof(InputObjectNodeId)].SetValue<int>(value); } }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public bool bHasChanged { get { return this[nameof(bHasChanged)].Flag; } set { this[nameof(bHasChanged)].Flag = value; } }
        public bool bNeedsToTriggerUpdate { get { return this[nameof(bNeedsToTriggerUpdate)].Flag; } set { this[nameof(bNeedsToTriggerUpdate)].Flag = value; } }
        public bool bTransformChanged { get { return this[nameof(bTransformChanged)].Flag; } set { this[nameof(bTransformChanged)].Flag = value; } }
        public bool bImportAsReference { get { return this[nameof(bImportAsReference)].Flag; } set { this[nameof(bImportAsReference)].Flag = value; } }
        public bool bImportAsReferenceRotScaleEnabled { get { return this[nameof(bImportAsReferenceRotScaleEnabled)].Flag; } set { this[nameof(bImportAsReferenceRotScaleEnabled)].Flag = value; } }
        public bool bImportAsReferenceBboxEnabled { get { return this[nameof(bImportAsReferenceBboxEnabled)].Flag; } set { this[nameof(bImportAsReferenceBboxEnabled)].Flag = value; } }
        public bool bImportAsReferenceMaterialEnabled { get { return this[nameof(bImportAsReferenceMaterialEnabled)].Flag; } set { this[nameof(bImportAsReferenceMaterialEnabled)].Flag = value; } }
        public Array<Object> MaterialReferences { get { return new Array<Object>(this[nameof(MaterialReferences)].Address); } }
        public bool bCanDeleteHoudiniNodes { get { return this[nameof(bCanDeleteHoudiniNodes)].Flag; } set { this[nameof(bCanDeleteHoudiniNodes)].Flag = value; } }
    }
    public class HoudiniInputStaticMesh : HoudiniInputObject
    {
        public HoudiniInputStaticMesh(nint addr) : base(addr) { }
    }
    public class HoudiniInputSkeletalMesh : HoudiniInputObject
    {
        public HoudiniInputSkeletalMesh(nint addr) : base(addr) { }
    }
    public class HoudiniInputGeometryCollection : HoudiniInputObject
    {
        public HoudiniInputGeometryCollection(nint addr) : base(addr) { }
    }
    public class HoudiniInputSceneComponent : HoudiniInputObject
    {
        public HoudiniInputSceneComponent(nint addr) : base(addr) { }
        public Transform ActorTransform { get { return this[nameof(ActorTransform)].As<Transform>(); } set { this["ActorTransform"] = value; } }
    }
    public class HoudiniInputMeshComponent : HoudiniInputSceneComponent
    {
        public HoudiniInputMeshComponent(nint addr) : base(addr) { }
        public Object StaticMesh { get { return this[nameof(StaticMesh)]; } set { this[nameof(StaticMesh)] = value; } }
    }
    public class HoudiniInputInstancedMeshComponent : HoudiniInputMeshComponent
    {
        public HoudiniInputInstancedMeshComponent(nint addr) : base(addr) { }
        public Array<Transform> InstanceTransforms { get { return new Array<Transform>(this[nameof(InstanceTransforms)].Address); } }
    }
    public class HoudiniInputSplineComponent : HoudiniInputSceneComponent
    {
        public HoudiniInputSplineComponent(nint addr) : base(addr) { }
        public int NumberOfSplineControlPoints { get { return this[nameof(NumberOfSplineControlPoints)].GetValue<int>(); } set { this[nameof(NumberOfSplineControlPoints)].SetValue<int>(value); } }
        public float SplineLength { get { return this[nameof(SplineLength)].GetValue<float>(); } set { this[nameof(SplineLength)].SetValue<float>(value); } }
        public float SplineResolution { get { return this[nameof(SplineResolution)].GetValue<float>(); } set { this[nameof(SplineResolution)].SetValue<float>(value); } }
        public bool SplineClosed { get { return this[nameof(SplineClosed)].Flag; } set { this[nameof(SplineClosed)].Flag = value; } }
        public Array<Transform> SplineControlPoints { get { return new Array<Transform>(this[nameof(SplineControlPoints)].Address); } }
    }
    public class HoudiniInputGeometryCollectionComponent : HoudiniInputSceneComponent
    {
        public HoudiniInputGeometryCollectionComponent(nint addr) : base(addr) { }
    }
    public class HoudiniInputSkeletalMeshComponent : HoudiniInputSceneComponent
    {
        public HoudiniInputSkeletalMeshComponent(nint addr) : base(addr) { }
    }
    public class HoudiniInputHoudiniSplineComponent : HoudiniInputObject
    {
        public HoudiniInputHoudiniSplineComponent(nint addr) : base(addr) { }
        public EHoudiniCurveType CurveType { get { return (EHoudiniCurveType)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public EHoudiniCurveMethod CurveMethod { get { return (EHoudiniCurveMethod)this[nameof(CurveMethod)].GetValue<int>(); } set { this[nameof(CurveMethod)].SetValue<int>((int)value); } }
        public bool Reversed { get { return this[nameof(Reversed)].Flag; } set { this[nameof(Reversed)].Flag = value; } }
        public HoudiniSplineComponent CachedComponent { get { return this[nameof(CachedComponent)].As<HoudiniSplineComponent>(); } set { this["CachedComponent"] = value; } }
    }
    public class HoudiniInputCameraComponent : HoudiniInputSceneComponent
    {
        public HoudiniInputCameraComponent(nint addr) : base(addr) { }
        public float FOV { get { return this[nameof(FOV)].GetValue<float>(); } set { this[nameof(FOV)].SetValue<float>(value); } }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
        public bool bIsOrthographic { get { return this[nameof(bIsOrthographic)].Flag; } set { this[nameof(bIsOrthographic)].Flag = value; } }
        public float OrthoWidth { get { return this[nameof(OrthoWidth)].GetValue<float>(); } set { this[nameof(OrthoWidth)].SetValue<float>(value); } }
        public float OrthoNearClipPlane { get { return this[nameof(OrthoNearClipPlane)].GetValue<float>(); } set { this[nameof(OrthoNearClipPlane)].SetValue<float>(value); } }
        public float OrthoFarClipPlane { get { return this[nameof(OrthoFarClipPlane)].GetValue<float>(); } set { this[nameof(OrthoFarClipPlane)].SetValue<float>(value); } }
    }
    public class HoudiniInputHoudiniAsset : HoudiniInputObject
    {
        public HoudiniInputHoudiniAsset(nint addr) : base(addr) { }
        public int AssetOutputIndex { get { return this[nameof(AssetOutputIndex)].GetValue<int>(); } set { this[nameof(AssetOutputIndex)].SetValue<int>(value); } }
    }
    public class HoudiniInputActor : HoudiniInputObject
    {
        public HoudiniInputActor(nint addr) : base(addr) { }
        public Array<HoudiniInputSceneComponent> ActorComponents { get { return new Array<HoudiniInputSceneComponent>(this[nameof(ActorComponents)].Address); } }
        public Object ActorSceneComponents { get { return this[nameof(ActorSceneComponents)]; } set { this[nameof(ActorSceneComponents)] = value; } }
        public int LastUpdateNumComponentsAdded { get { return this[nameof(LastUpdateNumComponentsAdded)].GetValue<int>(); } set { this[nameof(LastUpdateNumComponentsAdded)].SetValue<int>(value); } }
        public int LastUpdateNumComponentsRemoved { get { return this[nameof(LastUpdateNumComponentsRemoved)].GetValue<int>(); } set { this[nameof(LastUpdateNumComponentsRemoved)].SetValue<int>(value); } }
    }
    public class HoudiniInputLandscape : HoudiniInputActor
    {
        public HoudiniInputLandscape(nint addr) : base(addr) { }
        public Transform CachedInputLandscapeTraqnsform { get { return this[nameof(CachedInputLandscapeTraqnsform)].As<Transform>(); } set { this["CachedInputLandscapeTraqnsform"] = value; } }
        public int CachedNumLandscapeComponents { get { return this[nameof(CachedNumLandscapeComponents)].GetValue<int>(); } set { this[nameof(CachedNumLandscapeComponents)].SetValue<int>(value); } }
    }
    public class HoudiniInputBrush : HoudiniInputActor
    {
        public HoudiniInputBrush(nint addr) : base(addr) { }
        public Array<HoudiniBrushInfo> BrushesInfo { get { return new Array<HoudiniBrushInfo>(this[nameof(BrushesInfo)].Address); } }
        public Model CombinedModel { get { return this[nameof(CombinedModel)].As<Model>(); } set { this["CombinedModel"] = value; } }
        public bool bIgnoreInputObject { get { return this[nameof(bIgnoreInputObject)].Flag; } set { this[nameof(bIgnoreInputObject)].Flag = value; } }
        public byte CachedInputBrushType { get { return this[nameof(CachedInputBrushType)].GetValue<byte>(); } set { this[nameof(CachedInputBrushType)].SetValue<byte>(value); } }
    }
    public class HoudiniInputDataTable : HoudiniInputObject
    {
        public HoudiniInputDataTable(nint addr) : base(addr) { }
    }
    public class HoudiniInputFoliageType_InstancedStaticMesh : HoudiniInputStaticMesh
    {
        public HoudiniInputFoliageType_InstancedStaticMesh(nint addr) : base(addr) { }
    }
    public class HoudiniInputBlueprint : HoudiniInputObject
    {
        public HoudiniInputBlueprint(nint addr) : base(addr) { }
        public Array<HoudiniInputSceneComponent> BPComponents { get { return new Array<HoudiniInputSceneComponent>(this[nameof(BPComponents)].Address); } }
        public Object BPSceneComponents { get { return this[nameof(BPSceneComponents)]; } set { this[nameof(BPSceneComponents)] = value; } }
        public int LastUpdateNumComponentsAdded { get { return this[nameof(LastUpdateNumComponentsAdded)].GetValue<int>(); } set { this[nameof(LastUpdateNumComponentsAdded)].SetValue<int>(value); } }
        public int LastUpdateNumComponentsRemoved { get { return this[nameof(LastUpdateNumComponentsRemoved)].GetValue<int>(); } set { this[nameof(LastUpdateNumComponentsRemoved)].SetValue<int>(value); } }
    }
    public class HoudiniInstancedActorComponent : SceneComponent
    {
        public HoudiniInstancedActorComponent(nint addr) : base(addr) { }
        public Object InstancedObject { get { return this[nameof(InstancedObject)].As<Object>(); } set { this["InstancedObject"] = value; } }
        public Array<Actor> InstancedActors { get { return new Array<Actor>(this[nameof(InstancedActors)].Address); } }
    }
    public class HoudiniMeshSplitInstancerComponent : SceneComponent
    {
        public HoudiniMeshSplitInstancerComponent(nint addr) : base(addr) { }
        public Array<StaticMeshComponent> Instances { get { return new Array<StaticMeshComponent>(this[nameof(Instances)].Address); } }
        public Array<MaterialInterface> OverrideMaterials { get { return new Array<MaterialInterface>(this[nameof(OverrideMaterials)].Address); } }
        public StaticMesh InstancedMesh { get { return this[nameof(InstancedMesh)].As<StaticMesh>(); } set { this["InstancedMesh"] = value; } }
    }
    public class HoudiniLandscapePtr : Object
    {
        public HoudiniLandscapePtr(nint addr) : base(addr) { }
        public Object LandscapeSoftPtr { get { return this[nameof(LandscapeSoftPtr)]; } set { this[nameof(LandscapeSoftPtr)] = value; } }
        public EHoudiniLandscapeOutputBakeType BakeType { get { return (EHoudiniLandscapeOutputBakeType)this[nameof(BakeType)].GetValue<int>(); } set { this[nameof(BakeType)].SetValue<int>((int)value); } }
        public Object EditLayerName { get { return this[nameof(EditLayerName)]; } set { this[nameof(EditLayerName)] = value; } }
    }
    public class HoudiniLandscapeEditLayer : Object
    {
        public HoudiniLandscapeEditLayer(nint addr) : base(addr) { }
        public Object LandscapeSoftPtr { get { return this[nameof(LandscapeSoftPtr)]; } set { this[nameof(LandscapeSoftPtr)] = value; } }
        public Object LayerName { get { return this[nameof(LayerName)]; } set { this[nameof(LayerName)] = value; } }
    }
    public class HoudiniOutput : Object
    {
        public HoudiniOutput(nint addr) : base(addr) { }
        public EHoudiniOutputType Type { get { return (EHoudiniOutputType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Array<HoudiniGeoPartObject> HoudiniGeoPartObjects { get { return new Array<HoudiniGeoPartObject>(this[nameof(HoudiniGeoPartObjects)].Address); } }
        public Object OutputObjects { get { return this[nameof(OutputObjects)]; } set { this[nameof(OutputObjects)] = value; } }
        public Object InstancedOutputs { get { return this[nameof(InstancedOutputs)]; } set { this[nameof(InstancedOutputs)] = value; } }
        public Object AssignementMaterials { get { return this[nameof(AssignementMaterials)]; } set { this[nameof(AssignementMaterials)] = value; } }
        public Object ReplacementMaterials { get { return this[nameof(ReplacementMaterials)]; } set { this[nameof(ReplacementMaterials)] = value; } }
        public bool bLandscapeWorldComposition { get { return this[nameof(bLandscapeWorldComposition)].Flag; } set { this[nameof(bLandscapeWorldComposition)].Flag = value; } }
        public Array<Actor> HoudiniCreatedSocketActors { get { return new Array<Actor>(this[nameof(HoudiniCreatedSocketActors)].Address); } }
        public Array<Actor> HoudiniAttachedSocketActors { get { return new Array<Actor>(this[nameof(HoudiniAttachedSocketActors)].Address); } }
        public bool bIsEditableNode { get { return this[nameof(bIsEditableNode)].Flag; } set { this[nameof(bIsEditableNode)].Flag = value; } }
        public bool bHasEditableNodeBuilt { get { return this[nameof(bHasEditableNodeBuilt)].Flag; } set { this[nameof(bHasEditableNodeBuilt)].Flag = value; } }
        public bool bIsUpdating { get { return this[nameof(bIsUpdating)].Flag; } set { this[nameof(bIsUpdating)].Flag = value; } }
        public bool bCanDeleteHoudiniNodes { get { return this[nameof(bCanDeleteHoudiniNodes)].Flag; } set { this[nameof(bCanDeleteHoudiniNodes)].Flag = value; } }
    }
    public class HoudiniParameter : Object
    {
        public HoudiniParameter(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public EHoudiniParameterType ParmType { get { return (EHoudiniParameterType)this[nameof(ParmType)].GetValue<int>(); } set { this[nameof(ParmType)].SetValue<int>((int)value); } }
        public uint TupleSize { get { return this[nameof(TupleSize)].GetValue<uint>(); } set { this[nameof(TupleSize)].SetValue<uint>(value); } }
        public int NodeID { get { return this[nameof(NodeID)].GetValue<int>(); } set { this[nameof(NodeID)].SetValue<int>(value); } }
        public int ParmId { get { return this[nameof(ParmId)].GetValue<int>(); } set { this[nameof(ParmId)].SetValue<int>(value); } }
        public int ParentParmId { get { return this[nameof(ParentParmId)].GetValue<int>(); } set { this[nameof(ParentParmId)].SetValue<int>(value); } }
        public int ChildIndex { get { return this[nameof(ChildIndex)].GetValue<int>(); } set { this[nameof(ChildIndex)].SetValue<int>(value); } }
        public bool bIsVisible { get { return this[nameof(bIsVisible)].Flag; } set { this[nameof(bIsVisible)].Flag = value; } }
        public bool bIsParentFolderVisible { get { return this[nameof(bIsParentFolderVisible)].Flag; } set { this[nameof(bIsParentFolderVisible)].Flag = value; } }
        public bool bIsDisabled { get { return this[nameof(bIsDisabled)].Flag; } set { this[nameof(bIsDisabled)].Flag = value; } }
        public bool bHasChanged { get { return this[nameof(bHasChanged)].Flag; } set { this[nameof(bHasChanged)].Flag = value; } }
        public bool bNeedsToTriggerUpdate { get { return this[nameof(bNeedsToTriggerUpdate)].Flag; } set { this[nameof(bNeedsToTriggerUpdate)].Flag = value; } }
        public bool bIsDefault { get { return this[nameof(bIsDefault)].Flag; } set { this[nameof(bIsDefault)].Flag = value; } }
        public bool bIsSpare { get { return this[nameof(bIsSpare)].Flag; } set { this[nameof(bIsSpare)].Flag = value; } }
        public bool bJoinNext { get { return this[nameof(bJoinNext)].Flag; } set { this[nameof(bJoinNext)].Flag = value; } }
        public bool bIsChildOfMultiParm { get { return this[nameof(bIsChildOfMultiParm)].Flag; } set { this[nameof(bIsChildOfMultiParm)].Flag = value; } }
        public bool bIsDirectChildOfMultiParm { get { return this[nameof(bIsDirectChildOfMultiParm)].Flag; } set { this[nameof(bIsDirectChildOfMultiParm)].Flag = value; } }
        public bool bPendingRevertToDefault { get { return this[nameof(bPendingRevertToDefault)].Flag; } set { this[nameof(bPendingRevertToDefault)].Flag = value; } }
        public Array<int> TuplePendingRevertToDefault { get { return new Array<int>(this[nameof(TuplePendingRevertToDefault)].Address); } }
        public Object Help { get { return this[nameof(Help)]; } set { this[nameof(Help)] = value; } }
        public uint TagCount { get { return this[nameof(TagCount)].GetValue<uint>(); } set { this[nameof(TagCount)].SetValue<uint>(value); } }
        public int ValueIndex { get { return this[nameof(ValueIndex)].GetValue<int>(); } set { this[nameof(ValueIndex)].SetValue<int>(value); } }
        public bool bHasExpression { get { return this[nameof(bHasExpression)].Flag; } set { this[nameof(bHasExpression)].Flag = value; } }
        public bool bShowExpression { get { return this[nameof(bShowExpression)].Flag; } set { this[nameof(bShowExpression)].Flag = value; } }
        public Object ParamExpression { get { return this[nameof(ParamExpression)]; } set { this[nameof(ParamExpression)] = value; } }
        public Object Tags { get { return this[nameof(Tags)]; } set { this[nameof(Tags)] = value; } }
        public bool bAutoUpdate { get { return this[nameof(bAutoUpdate)].Flag; } set { this[nameof(bAutoUpdate)].Flag = value; } }
    }
    public class HoudiniParameterButton : HoudiniParameter
    {
        public HoudiniParameterButton(nint addr) : base(addr) { }
    }
    public class HoudiniParameterButtonStrip : HoudiniParameter
    {
        public HoudiniParameterButtonStrip(nint addr) : base(addr) { }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public Array<Object> Labels { get { return new Array<Object>(this[nameof(Labels)].Address); } }
        public Array<int> Values { get { return new Array<int>(this[nameof(Values)].Address); } }
    }
    public class HoudiniParameterChoice : HoudiniParameter
    {
        public HoudiniParameterChoice(nint addr) : base(addr) { }
        public int IntValue { get { return this[nameof(IntValue)].GetValue<int>(); } set { this[nameof(IntValue)].SetValue<int>(value); } }
        public int DefaultIntValue { get { return this[nameof(DefaultIntValue)].GetValue<int>(); } set { this[nameof(DefaultIntValue)].SetValue<int>(value); } }
        public Object StringValue { get { return this[nameof(StringValue)]; } set { this[nameof(StringValue)] = value; } }
        public Object DefaultStringValue { get { return this[nameof(DefaultStringValue)]; } set { this[nameof(DefaultStringValue)] = value; } }
        public Array<Object> StringChoiceValues { get { return new Array<Object>(this[nameof(StringChoiceValues)].Address); } }
        public Array<Object> StringChoiceLabels { get { return new Array<Object>(this[nameof(StringChoiceLabels)].Address); } }
        public bool bIsChildOfRamp { get { return this[nameof(bIsChildOfRamp)].Flag; } set { this[nameof(bIsChildOfRamp)].Flag = value; } }
        public Array<int> IntValuesArray { get { return new Array<int>(this[nameof(IntValuesArray)].Address); } }
    }
    public class HoudiniParameterColor : HoudiniParameter
    {
        public HoudiniParameterColor(nint addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public LinearColor DefaultColor { get { return this[nameof(DefaultColor)].As<LinearColor>(); } set { this["DefaultColor"] = value; } }
        public bool bIsChildOfRamp { get { return this[nameof(bIsChildOfRamp)].Flag; } set { this[nameof(bIsChildOfRamp)].Flag = value; } }
    }
    public class HoudiniParameterFile : HoudiniParameter
    {
        public HoudiniParameterFile(nint addr) : base(addr) { }
        public Array<Object> Values { get { return new Array<Object>(this[nameof(Values)].Address); } }
        public Array<Object> DefaultValues { get { return new Array<Object>(this[nameof(DefaultValues)].Address); } }
        public Object Filters { get { return this[nameof(Filters)]; } set { this[nameof(Filters)] = value; } }
        public bool bIsReadOnly { get { return this[nameof(bIsReadOnly)].Flag; } set { this[nameof(bIsReadOnly)].Flag = value; } }
    }
    public class HoudiniParameterFloat : HoudiniParameter
    {
        public HoudiniParameterFloat(nint addr) : base(addr) { }
        public Array<float> Values { get { return new Array<float>(this[nameof(Values)].Address); } }
        public Array<float> DefaultValues { get { return new Array<float>(this[nameof(DefaultValues)].Address); } }
        public Object Unit { get { return this[nameof(Unit)]; } set { this[nameof(Unit)] = value; } }
        public bool bNoSwap { get { return this[nameof(bNoSwap)].Flag; } set { this[nameof(bNoSwap)].Flag = value; } }
        public bool bHasMin { get { return this[nameof(bHasMin)].Flag; } set { this[nameof(bHasMin)].Flag = value; } }
        public bool bHasMax { get { return this[nameof(bHasMax)].Flag; } set { this[nameof(bHasMax)].Flag = value; } }
        public bool bHasUIMin { get { return this[nameof(bHasUIMin)].Flag; } set { this[nameof(bHasUIMin)].Flag = value; } }
        public bool bHasUIMax { get { return this[nameof(bHasUIMax)].Flag; } set { this[nameof(bHasUIMax)].Flag = value; } }
        public bool bIsLogarithmic { get { return this[nameof(bIsLogarithmic)].Flag; } set { this[nameof(bIsLogarithmic)].Flag = value; } }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
        public float UIMin { get { return this[nameof(UIMin)].GetValue<float>(); } set { this[nameof(UIMin)].SetValue<float>(value); } }
        public float UIMax { get { return this[nameof(UIMax)].GetValue<float>(); } set { this[nameof(UIMax)].SetValue<float>(value); } }
        public bool bIsChildOfRamp { get { return this[nameof(bIsChildOfRamp)].Flag; } set { this[nameof(bIsChildOfRamp)].Flag = value; } }
    }
    public class HoudiniParameterFolder : HoudiniParameter
    {
        public HoudiniParameterFolder(nint addr) : base(addr) { }
        public EHoudiniFolderParameterType FolderType { get { return (EHoudiniFolderParameterType)this[nameof(FolderType)].GetValue<int>(); } set { this[nameof(FolderType)].SetValue<int>((int)value); } }
        public bool bExpanded { get { return this[nameof(bExpanded)].Flag; } set { this[nameof(bExpanded)].Flag = value; } }
        public bool bChosen { get { return this[nameof(bChosen)].Flag; } set { this[nameof(bChosen)].Flag = value; } }
        public int ChildCounter { get { return this[nameof(ChildCounter)].GetValue<int>(); } set { this[nameof(ChildCounter)].SetValue<int>(value); } }
        public bool bIsContentShown { get { return this[nameof(bIsContentShown)].Flag; } set { this[nameof(bIsContentShown)].Flag = value; } }
    }
    public class HoudiniParameterFolderList : HoudiniParameter
    {
        public HoudiniParameterFolderList(nint addr) : base(addr) { }
        public bool bIsTabMenu { get { return this[nameof(bIsTabMenu)].Flag; } set { this[nameof(bIsTabMenu)].Flag = value; } }
        public bool bIsTabsShown { get { return this[nameof(bIsTabsShown)].Flag; } set { this[nameof(bIsTabsShown)].Flag = value; } }
        public Array<HoudiniParameterFolder> TabFolders { get { return new Array<HoudiniParameterFolder>(this[nameof(TabFolders)].Address); } }
    }
    public class HoudiniParameterInt : HoudiniParameter
    {
        public HoudiniParameterInt(nint addr) : base(addr) { }
        public Array<int> Values { get { return new Array<int>(this[nameof(Values)].Address); } }
        public Array<int> DefaultValues { get { return new Array<int>(this[nameof(DefaultValues)].Address); } }
        public Object Unit { get { return this[nameof(Unit)]; } set { this[nameof(Unit)] = value; } }
        public bool bHasMin { get { return this[nameof(bHasMin)].Flag; } set { this[nameof(bHasMin)].Flag = value; } }
        public bool bHasMax { get { return this[nameof(bHasMax)].Flag; } set { this[nameof(bHasMax)].Flag = value; } }
        public bool bHasUIMin { get { return this[nameof(bHasUIMin)].Flag; } set { this[nameof(bHasUIMin)].Flag = value; } }
        public bool bHasUIMax { get { return this[nameof(bHasUIMax)].Flag; } set { this[nameof(bHasUIMax)].Flag = value; } }
        public bool bIsLogarithmic { get { return this[nameof(bIsLogarithmic)].Flag; } set { this[nameof(bIsLogarithmic)].Flag = value; } }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
        public int UIMin { get { return this[nameof(UIMin)].GetValue<int>(); } set { this[nameof(UIMin)].SetValue<int>(value); } }
        public int UIMax { get { return this[nameof(UIMax)].GetValue<int>(); } set { this[nameof(UIMax)].SetValue<int>(value); } }
    }
    public class HoudiniParameterLabel : HoudiniParameter
    {
        public HoudiniParameterLabel(nint addr) : base(addr) { }
        public Array<Object> LabelStrings { get { return new Array<Object>(this[nameof(LabelStrings)].Address); } }
    }
    public class HoudiniParameterMultiParm : HoudiniParameter
    {
        public HoudiniParameterMultiParm(nint addr) : base(addr) { }
        public bool bIsShown { get { return this[nameof(bIsShown)].Flag; } set { this[nameof(bIsShown)].Flag = value; } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public Object TemplateName { get { return this[nameof(TemplateName)]; } set { this[nameof(TemplateName)] = value; } }
        public int MultiparmValue { get { return this[nameof(MultiparmValue)].GetValue<int>(); } set { this[nameof(MultiparmValue)].SetValue<int>(value); } }
        public uint MultiParmInstanceNum { get { return this[nameof(MultiParmInstanceNum)].GetValue<uint>(); } set { this[nameof(MultiParmInstanceNum)].SetValue<uint>(value); } }
        public uint MultiParmInstanceLength { get { return this[nameof(MultiParmInstanceLength)].GetValue<uint>(); } set { this[nameof(MultiParmInstanceLength)].SetValue<uint>(value); } }
        public uint MultiParmInstanceCount { get { return this[nameof(MultiParmInstanceCount)].GetValue<uint>(); } set { this[nameof(MultiParmInstanceCount)].SetValue<uint>(value); } }
        public uint InstanceStartOffset { get { return this[nameof(InstanceStartOffset)].GetValue<uint>(); } set { this[nameof(InstanceStartOffset)].SetValue<uint>(value); } }
        public Array<EHoudiniMultiParmModificationType> MultiParmInstanceLastModifyArray { get { return new Array<EHoudiniMultiParmModificationType>(this[nameof(MultiParmInstanceLastModifyArray)].Address); } }
        public int DefaultInstanceCount { get { return this[nameof(DefaultInstanceCount)].GetValue<int>(); } set { this[nameof(DefaultInstanceCount)].SetValue<int>(value); } }
    }
    public class HoudiniParameterOperatorPath : HoudiniParameter
    {
        public HoudiniParameterOperatorPath(nint addr) : base(addr) { }
        public Object HoudiniInput { get { return this[nameof(HoudiniInput)]; } set { this[nameof(HoudiniInput)] = value; } }
    }
    public class HoudiniParameterRampModificationEvent : Object
    {
        public HoudiniParameterRampModificationEvent(nint addr) : base(addr) { }
        public bool bIsInsertEvent { get { return this[nameof(bIsInsertEvent)].Flag; } set { this[nameof(bIsInsertEvent)].Flag = value; } }
        public bool bIsFloatRamp { get { return this[nameof(bIsFloatRamp)].Flag; } set { this[nameof(bIsFloatRamp)].Flag = value; } }
        public int DeleteInstanceIndex { get { return this[nameof(DeleteInstanceIndex)].GetValue<int>(); } set { this[nameof(DeleteInstanceIndex)].SetValue<int>(value); } }
        public float InsertPosition { get { return this[nameof(InsertPosition)].GetValue<float>(); } set { this[nameof(InsertPosition)].SetValue<float>(value); } }
        public float InsertFloat { get { return this[nameof(InsertFloat)].GetValue<float>(); } set { this[nameof(InsertFloat)].SetValue<float>(value); } }
        public LinearColor InsertColor { get { return this[nameof(InsertColor)].As<LinearColor>(); } set { this["InsertColor"] = value; } }
        public EHoudiniRampInterpolationType InsertInterpolation { get { return (EHoudiniRampInterpolationType)this[nameof(InsertInterpolation)].GetValue<int>(); } set { this[nameof(InsertInterpolation)].SetValue<int>((int)value); } }
    }
    public class HoudiniParameterRampFloatPoint : Object
    {
        public HoudiniParameterRampFloatPoint(nint addr) : base(addr) { }
        public float Position { get { return this[nameof(Position)].GetValue<float>(); } set { this[nameof(Position)].SetValue<float>(value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public EHoudiniRampInterpolationType Interpolation { get { return (EHoudiniRampInterpolationType)this[nameof(Interpolation)].GetValue<int>(); } set { this[nameof(Interpolation)].SetValue<int>((int)value); } }
        public int InstanceIndex { get { return this[nameof(InstanceIndex)].GetValue<int>(); } set { this[nameof(InstanceIndex)].SetValue<int>(value); } }
        public HoudiniParameterFloat PositionParentParm { get { return this[nameof(PositionParentParm)].As<HoudiniParameterFloat>(); } set { this["PositionParentParm"] = value; } }
        public HoudiniParameterFloat ValueParentParm { get { return this[nameof(ValueParentParm)].As<HoudiniParameterFloat>(); } set { this["ValueParentParm"] = value; } }
        public HoudiniParameterChoice InterpolationParentParm { get { return this[nameof(InterpolationParentParm)].As<HoudiniParameterChoice>(); } set { this["InterpolationParentParm"] = value; } }
    }
    public class HoudiniParameterRampColorPoint : Object
    {
        public HoudiniParameterRampColorPoint(nint addr) : base(addr) { }
        public float Position { get { return this[nameof(Position)].GetValue<float>(); } set { this[nameof(Position)].SetValue<float>(value); } }
        public LinearColor Value { get { return this[nameof(Value)].As<LinearColor>(); } set { this["Value"] = value; } }
        public EHoudiniRampInterpolationType Interpolation { get { return (EHoudiniRampInterpolationType)this[nameof(Interpolation)].GetValue<int>(); } set { this[nameof(Interpolation)].SetValue<int>((int)value); } }
        public int InstanceIndex { get { return this[nameof(InstanceIndex)].GetValue<int>(); } set { this[nameof(InstanceIndex)].SetValue<int>(value); } }
        public HoudiniParameterFloat PositionParentParm { get { return this[nameof(PositionParentParm)].As<HoudiniParameterFloat>(); } set { this["PositionParentParm"] = value; } }
        public HoudiniParameterColor ValueParentParm { get { return this[nameof(ValueParentParm)].As<HoudiniParameterColor>(); } set { this["ValueParentParm"] = value; } }
        public HoudiniParameterChoice InterpolationParentParm { get { return this[nameof(InterpolationParentParm)].As<HoudiniParameterChoice>(); } set { this["InterpolationParentParm"] = value; } }
    }
    public class HoudiniParameterRampFloat : HoudiniParameterMultiParm
    {
        public HoudiniParameterRampFloat(nint addr) : base(addr) { }
        public Array<HoudiniParameterRampFloatPoint> Points { get { return new Array<HoudiniParameterRampFloatPoint>(this[nameof(Points)].Address); } }
        public Array<HoudiniParameterRampFloatPoint> CachedPoints { get { return new Array<HoudiniParameterRampFloatPoint>(this[nameof(CachedPoints)].Address); } }
        public Array<float> DefaultPositions { get { return new Array<float>(this[nameof(DefaultPositions)].Address); } }
        public Array<float> DefaultValues { get { return new Array<float>(this[nameof(DefaultValues)].Address); } }
        public Array<int> DefaultChoices { get { return new Array<int>(this[nameof(DefaultChoices)].Address); } }
        public int NumDefaultPoints { get { return this[nameof(NumDefaultPoints)].GetValue<int>(); } set { this[nameof(NumDefaultPoints)].SetValue<int>(value); } }
        public bool bCaching { get { return this[nameof(bCaching)].Flag; } set { this[nameof(bCaching)].Flag = value; } }
        public Array<HoudiniParameterRampModificationEvent> ModificationEvents { get { return new Array<HoudiniParameterRampModificationEvent>(this[nameof(ModificationEvents)].Address); } }
    }
    public class HoudiniParameterRampColor : HoudiniParameterMultiParm
    {
        public HoudiniParameterRampColor(nint addr) : base(addr) { }
        public Array<HoudiniParameterRampColorPoint> Points { get { return new Array<HoudiniParameterRampColorPoint>(this[nameof(Points)].Address); } }
        public bool bCaching { get { return this[nameof(bCaching)].Flag; } set { this[nameof(bCaching)].Flag = value; } }
        public Array<HoudiniParameterRampColorPoint> CachedPoints { get { return new Array<HoudiniParameterRampColorPoint>(this[nameof(CachedPoints)].Address); } }
        public Array<float> DefaultPositions { get { return new Array<float>(this[nameof(DefaultPositions)].Address); } }
        public Array<LinearColor> DefaultValues { get { return new Array<LinearColor>(this[nameof(DefaultValues)].Address); } }
        public Array<int> DefaultChoices { get { return new Array<int>(this[nameof(DefaultChoices)].Address); } }
        public int NumDefaultPoints { get { return this[nameof(NumDefaultPoints)].GetValue<int>(); } set { this[nameof(NumDefaultPoints)].SetValue<int>(value); } }
        public Array<HoudiniParameterRampModificationEvent> ModificationEvents { get { return new Array<HoudiniParameterRampModificationEvent>(this[nameof(ModificationEvents)].Address); } }
    }
    public class HoudiniParameterSeparator : HoudiniParameter
    {
        public HoudiniParameterSeparator(nint addr) : base(addr) { }
    }
    public class HoudiniParameterString : HoudiniParameter
    {
        public HoudiniParameterString(nint addr) : base(addr) { }
        public Array<Object> Values { get { return new Array<Object>(this[nameof(Values)].Address); } }
        public Array<Object> DefaultValues { get { return new Array<Object>(this[nameof(DefaultValues)].Address); } }
        public Array<Object> ChosenAssets { get { return new Array<Object>(this[nameof(ChosenAssets)].Address); } }
        public bool bIsAssetRef { get { return this[nameof(bIsAssetRef)].Flag; } set { this[nameof(bIsAssetRef)].Flag = value; } }
    }
    public class HoudiniParameterToggle : HoudiniParameter
    {
        public HoudiniParameterToggle(nint addr) : base(addr) { }
        public Array<int> Values { get { return new Array<int>(this[nameof(Values)].Address); } }
        public Array<int> DefaultValues { get { return new Array<int>(this[nameof(DefaultValues)].Address); } }
    }
    public class TOPNode : Object
    {
        public TOPNode(nint addr) : base(addr) { }
        public int NodeID { get { return this[nameof(NodeID)].GetValue<int>(); } set { this[nameof(NodeID)].SetValue<int>(value); } }
        public Object NodeName { get { return this[nameof(NodeName)]; } set { this[nameof(NodeName)] = value; } }
        public Object NodePath { get { return this[nameof(NodePath)]; } set { this[nameof(NodePath)] = value; } }
        public Object ParentName { get { return this[nameof(ParentName)]; } set { this[nameof(ParentName)] = value; } }
        public Object WorkResultParent { get { return this[nameof(WorkResultParent)].As<Object>(); } set { this["WorkResultParent"] = value; } }
        public Array<TOPWorkResult> WorkResult { get { return new Array<TOPWorkResult>(this[nameof(WorkResult)].Address); } }
        public bool bHidden { get { return this[nameof(bHidden)].Flag; } set { this[nameof(bHidden)].Flag = value; } }
        public bool bAutoLoad { get { return this[nameof(bAutoLoad)].Flag; } set { this[nameof(bAutoLoad)].Flag = value; } }
        public EPDGNodeState NodeState { get { return (EPDGNodeState)this[nameof(NodeState)].GetValue<int>(); } set { this[nameof(NodeState)].SetValue<int>((int)value); } }
        public bool bCachedHaveNotLoadedWorkResults { get { return this[nameof(bCachedHaveNotLoadedWorkResults)].Flag; } set { this[nameof(bCachedHaveNotLoadedWorkResults)].Flag = value; } }
        public bool bCachedHaveLoadedWorkResults { get { return this[nameof(bCachedHaveLoadedWorkResults)].Flag; } set { this[nameof(bCachedHaveLoadedWorkResults)].Flag = value; } }
        public bool bHasChildNodes { get { return this[nameof(bHasChildNodes)].Flag; } set { this[nameof(bHasChildNodes)].Flag = value; } }
        public Object ClearedLandscapeLayers { get { return this[nameof(ClearedLandscapeLayers)]; } set { this[nameof(ClearedLandscapeLayers)] = value; } }
        public bool bShow { get { return this[nameof(bShow)].Flag; } set { this[nameof(bShow)].Flag = value; } }
        public Object BakedWorkResultObjectOutputs { get { return this[nameof(BakedWorkResultObjectOutputs)]; } set { this[nameof(BakedWorkResultObjectOutputs)] = value; } }
        public WorkItemTally WorkItemTally { get { return this[nameof(WorkItemTally)].As<WorkItemTally>(); } set { this["WorkItemTally"] = value; } }
        public AggregatedWorkItemTally AggregatedWorkItemTally { get { return this[nameof(AggregatedWorkItemTally)].As<AggregatedWorkItemTally>(); } set { this["AggregatedWorkItemTally"] = value; } }
        public bool bHasReceivedCookCompleteEvent { get { return this[nameof(bHasReceivedCookCompleteEvent)].Flag; } set { this[nameof(bHasReceivedCookCompleteEvent)].Flag = value; } }
        public OutputActorOwner OutputActorOwner { get { return this[nameof(OutputActorOwner)].As<OutputActorOwner>(); } set { this["OutputActorOwner"] = value; } }
    }
    public class TOPNetwork : Object
    {
        public TOPNetwork(nint addr) : base(addr) { }
        public int NodeID { get { return this[nameof(NodeID)].GetValue<int>(); } set { this[nameof(NodeID)].SetValue<int>(value); } }
        public Object NodeName { get { return this[nameof(NodeName)]; } set { this[nameof(NodeName)] = value; } }
        public Object NodePath { get { return this[nameof(NodePath)]; } set { this[nameof(NodePath)] = value; } }
        public Array<TOPNode> AllTOPNodes { get { return new Array<TOPNode>(this[nameof(AllTOPNodes)].Address); } }
        public int SelectedTOPIndex { get { return this[nameof(SelectedTOPIndex)].GetValue<int>(); } set { this[nameof(SelectedTOPIndex)].SetValue<int>(value); } }
        public Object ParentName { get { return this[nameof(ParentName)]; } set { this[nameof(ParentName)] = value; } }
        public bool bShowResults { get { return this[nameof(bShowResults)].Flag; } set { this[nameof(bShowResults)].Flag = value; } }
        public bool bAutoLoadResults { get { return this[nameof(bAutoLoadResults)].Flag; } set { this[nameof(bAutoLoadResults)].Flag = value; } }
    }
    public class HoudiniPDGAssetLink : Object
    {
        public HoudiniPDGAssetLink(nint addr) : base(addr) { }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public Object AssetNodePath { get { return this[nameof(AssetNodePath)]; } set { this[nameof(AssetNodePath)] = value; } }
        public int AssetId { get { return this[nameof(AssetId)].GetValue<int>(); } set { this[nameof(AssetId)].SetValue<int>(value); } }
        public Array<TOPNetwork> AllTOPNetworks { get { return new Array<TOPNetwork>(this[nameof(AllTOPNetworks)].Address); } }
        public int SelectedTOPNetworkIndex { get { return this[nameof(SelectedTOPNetworkIndex)].GetValue<int>(); } set { this[nameof(SelectedTOPNetworkIndex)].SetValue<int>(value); } }
        public EPDGLinkState LinkState { get { return (EPDGLinkState)this[nameof(LinkState)].GetValue<int>(); } set { this[nameof(LinkState)].SetValue<int>((int)value); } }
        public bool bAutoCook { get { return this[nameof(bAutoCook)].Flag; } set { this[nameof(bAutoCook)].Flag = value; } }
        public bool bUseTOPNodeFilter { get { return this[nameof(bUseTOPNodeFilter)].Flag; } set { this[nameof(bUseTOPNodeFilter)].Flag = value; } }
        public bool bUseTOPOutputFilter { get { return this[nameof(bUseTOPOutputFilter)].Flag; } set { this[nameof(bUseTOPOutputFilter)].Flag = value; } }
        public Object TOPNodeFilter { get { return this[nameof(TOPNodeFilter)]; } set { this[nameof(TOPNodeFilter)] = value; } }
        public Object TOPOutputFilter { get { return this[nameof(TOPOutputFilter)]; } set { this[nameof(TOPOutputFilter)] = value; } }
        public int NumWorkItems { get { return this[nameof(NumWorkItems)].GetValue<int>(); } set { this[nameof(NumWorkItems)].SetValue<int>(value); } }
        public AggregatedWorkItemTally WorkItemTally { get { return this[nameof(WorkItemTally)].As<AggregatedWorkItemTally>(); } set { this["WorkItemTally"] = value; } }
        public Object OutputCachePath { get { return this[nameof(OutputCachePath)]; } set { this[nameof(OutputCachePath)] = value; } }
        public bool bNeedsUIRefresh { get { return this[nameof(bNeedsUIRefresh)].Flag; } set { this[nameof(bNeedsUIRefresh)].Flag = value; } }
        public Actor OutputParentActor { get { return this[nameof(OutputParentActor)].As<Actor>(); } set { this["OutputParentActor"] = value; } }
        public DirectoryPath BakeFolder { get { return this[nameof(BakeFolder)].As<DirectoryPath>(); } set { this["BakeFolder"] = value; } }
    }
    public class HoudiniRuntimeSettings : Object
    {
        public HoudiniRuntimeSettings(nint addr) : base(addr) { }
        public byte SessionType { get { return this[nameof(SessionType)].GetValue<byte>(); } set { this[nameof(SessionType)].SetValue<byte>(value); } }
        public Object ServerHost { get { return this[nameof(ServerHost)]; } set { this[nameof(ServerHost)] = value; } }
        public int ServerPort { get { return this[nameof(ServerPort)].GetValue<int>(); } set { this[nameof(ServerPort)].SetValue<int>(value); } }
        public Object ServerPipeName { get { return this[nameof(ServerPipeName)]; } set { this[nameof(ServerPipeName)] = value; } }
        public bool bStartAutomaticServer { get { return this[nameof(bStartAutomaticServer)].Flag; } set { this[nameof(bStartAutomaticServer)].Flag = value; } }
        public float AutomaticServerTimeout { get { return this[nameof(AutomaticServerTimeout)].GetValue<float>(); } set { this[nameof(AutomaticServerTimeout)].SetValue<float>(value); } }
        public bool bSyncWithHoudiniCook { get { return this[nameof(bSyncWithHoudiniCook)].Flag; } set { this[nameof(bSyncWithHoudiniCook)].Flag = value; } }
        public bool bCookUsingHoudiniTime { get { return this[nameof(bCookUsingHoudiniTime)].Flag; } set { this[nameof(bCookUsingHoudiniTime)].Flag = value; } }
        public bool bSyncViewport { get { return this[nameof(bSyncViewport)].Flag; } set { this[nameof(bSyncViewport)].Flag = value; } }
        public bool bSyncHoudiniViewport { get { return this[nameof(bSyncHoudiniViewport)].Flag; } set { this[nameof(bSyncHoudiniViewport)].Flag = value; } }
        public bool bSyncUnrealViewport { get { return this[nameof(bSyncUnrealViewport)].Flag; } set { this[nameof(bSyncUnrealViewport)].Flag = value; } }
        public bool bShowMultiAssetDialog { get { return this[nameof(bShowMultiAssetDialog)].Flag; } set { this[nameof(bShowMultiAssetDialog)].Flag = value; } }
        public bool bPreferHdaMemoryCopyOverHdaSourceFile { get { return this[nameof(bPreferHdaMemoryCopyOverHdaSourceFile)].Flag; } set { this[nameof(bPreferHdaMemoryCopyOverHdaSourceFile)].Flag = value; } }
        public bool bPauseCookingOnStart { get { return this[nameof(bPauseCookingOnStart)].Flag; } set { this[nameof(bPauseCookingOnStart)].Flag = value; } }
        public bool bDisplaySlateCookingNotifications { get { return this[nameof(bDisplaySlateCookingNotifications)].Flag; } set { this[nameof(bDisplaySlateCookingNotifications)].Flag = value; } }
        public Object DefaultTemporaryCookFolder { get { return this[nameof(DefaultTemporaryCookFolder)]; } set { this[nameof(DefaultTemporaryCookFolder)] = value; } }
        public Object DefaultBakeFolder { get { return this[nameof(DefaultBakeFolder)]; } set { this[nameof(DefaultBakeFolder)] = value; } }
        public bool bEnableTheReferenceCountedInputSystem { get { return this[nameof(bEnableTheReferenceCountedInputSystem)].Flag; } set { this[nameof(bEnableTheReferenceCountedInputSystem)].Flag = value; } }
        public bool MarshallingLandscapesUseDefaultUnrealScaling { get { return this[nameof(MarshallingLandscapesUseDefaultUnrealScaling)].Flag; } set { this[nameof(MarshallingLandscapesUseDefaultUnrealScaling)].Flag = value; } }
        public bool MarshallingLandscapesUseFullResolution { get { return this[nameof(MarshallingLandscapesUseFullResolution)].Flag; } set { this[nameof(MarshallingLandscapesUseFullResolution)].Flag = value; } }
        public bool MarshallingLandscapesForceMinMaxValues { get { return this[nameof(MarshallingLandscapesForceMinMaxValues)].Flag; } set { this[nameof(MarshallingLandscapesForceMinMaxValues)].Flag = value; } }
        public float MarshallingLandscapesForcedMinValue { get { return this[nameof(MarshallingLandscapesForcedMinValue)].GetValue<float>(); } set { this[nameof(MarshallingLandscapesForcedMinValue)].SetValue<float>(value); } }
        public float MarshallingLandscapesForcedMaxValue { get { return this[nameof(MarshallingLandscapesForcedMaxValue)].GetValue<float>(); } set { this[nameof(MarshallingLandscapesForcedMaxValue)].SetValue<float>(value); } }
        public bool bAddRotAndScaleAttributesOnCurves { get { return this[nameof(bAddRotAndScaleAttributesOnCurves)].Flag; } set { this[nameof(bAddRotAndScaleAttributesOnCurves)].Flag = value; } }
        public bool bUseLegacyInputCurves { get { return this[nameof(bUseLegacyInputCurves)].Flag; } set { this[nameof(bUseLegacyInputCurves)].Flag = value; } }
        public float MarshallingSplineResolution { get { return this[nameof(MarshallingSplineResolution)].GetValue<float>(); } set { this[nameof(MarshallingSplineResolution)].SetValue<float>(value); } }
        public bool bEnableProxyStaticMesh { get { return this[nameof(bEnableProxyStaticMesh)].Flag; } set { this[nameof(bEnableProxyStaticMesh)].Flag = value; } }
        public bool bShowDefaultMesh { get { return this[nameof(bShowDefaultMesh)].Flag; } set { this[nameof(bShowDefaultMesh)].Flag = value; } }
        public bool bPreferNaniteFallbackMesh { get { return this[nameof(bPreferNaniteFallbackMesh)].Flag; } set { this[nameof(bPreferNaniteFallbackMesh)].Flag = value; } }
        public bool bEnableProxyStaticMeshRefinementByTimer { get { return this[nameof(bEnableProxyStaticMeshRefinementByTimer)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementByTimer)].Flag = value; } }
        public float ProxyMeshAutoRefineTimeoutSeconds { get { return this[nameof(ProxyMeshAutoRefineTimeoutSeconds)].GetValue<float>(); } set { this[nameof(ProxyMeshAutoRefineTimeoutSeconds)].SetValue<float>(value); } }
        public bool bEnableProxyStaticMeshRefinementOnPreSaveWorld { get { return this[nameof(bEnableProxyStaticMeshRefinementOnPreSaveWorld)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementOnPreSaveWorld)].Flag = value; } }
        public bool bEnableProxyStaticMeshRefinementOnPreBeginPIE { get { return this[nameof(bEnableProxyStaticMeshRefinementOnPreBeginPIE)].Flag; } set { this[nameof(bEnableProxyStaticMeshRefinementOnPreBeginPIE)].Flag = value; } }
        public bool bDoubleSidedGeometry { get { return this[nameof(bDoubleSidedGeometry)].Flag; } set { this[nameof(bDoubleSidedGeometry)].Flag = value; } }
        public PhysicalMaterial PhysMaterial { get { return this[nameof(PhysMaterial)].As<PhysicalMaterial>(); } set { this["PhysMaterial"] = value; } }
        public BodyInstance DefaultBodyInstance { get { return this[nameof(DefaultBodyInstance)].As<BodyInstance>(); } set { this["DefaultBodyInstance"] = value; } }
        public byte CollisionTraceFlag { get { return this[nameof(CollisionTraceFlag)].GetValue<byte>(); } set { this[nameof(CollisionTraceFlag)].SetValue<byte>(value); } }
        public int LightMapResolution { get { return this[nameof(LightMapResolution)].GetValue<int>(); } set { this[nameof(LightMapResolution)].SetValue<int>(value); } }
        public float LpvBiasMultiplier { get { return this[nameof(LpvBiasMultiplier)].GetValue<float>(); } set { this[nameof(LpvBiasMultiplier)].SetValue<float>(value); } }
        public float GeneratedDistanceFieldResolutionScale { get { return this[nameof(GeneratedDistanceFieldResolutionScale)].GetValue<float>(); } set { this[nameof(GeneratedDistanceFieldResolutionScale)].SetValue<float>(value); } }
        public WalkableSlopeOverride WalkableSlopeOverride { get { return this[nameof(WalkableSlopeOverride)].As<WalkableSlopeOverride>(); } set { this["WalkableSlopeOverride"] = value; } }
        public int LightMapCoordinateIndex { get { return this[nameof(LightMapCoordinateIndex)].GetValue<int>(); } set { this[nameof(LightMapCoordinateIndex)].SetValue<int>(value); } }
        public bool bUseMaximumStreamingTexelRatio { get { return this[nameof(bUseMaximumStreamingTexelRatio)].Flag; } set { this[nameof(bUseMaximumStreamingTexelRatio)].Flag = value; } }
        public float StreamingDistanceMultiplier { get { return this[nameof(StreamingDistanceMultiplier)].GetValue<float>(); } set { this[nameof(StreamingDistanceMultiplier)].SetValue<float>(value); } }
        public FoliageType_InstancedStaticMesh FoliageDefaultSettings { get { return this[nameof(FoliageDefaultSettings)].As<FoliageType_InstancedStaticMesh>(); } set { this["FoliageDefaultSettings"] = value; } }
        public Array<AssetUserData> AssetUserData { get { return new Array<AssetUserData>(this[nameof(AssetUserData)].Address); } }
        public bool bUseFullPrecisionUVs { get { return this[nameof(bUseFullPrecisionUVs)].Flag; } set { this[nameof(bUseFullPrecisionUVs)].Flag = value; } }
        public int SrcLightmapIndex { get { return this[nameof(SrcLightmapIndex)].GetValue<int>(); } set { this[nameof(SrcLightmapIndex)].SetValue<int>(value); } }
        public int DstLightmapIndex { get { return this[nameof(DstLightmapIndex)].GetValue<int>(); } set { this[nameof(DstLightmapIndex)].SetValue<int>(value); } }
        public int MinLightmapResolution { get { return this[nameof(MinLightmapResolution)].GetValue<int>(); } set { this[nameof(MinLightmapResolution)].SetValue<int>(value); } }
        public bool bRemoveDegenerates { get { return this[nameof(bRemoveDegenerates)].Flag; } set { this[nameof(bRemoveDegenerates)].Flag = value; } }
        public byte GenerateLightmapUVsFlag { get { return this[nameof(GenerateLightmapUVsFlag)].GetValue<byte>(); } set { this[nameof(GenerateLightmapUVsFlag)].SetValue<byte>(value); } }
        public byte RecomputeNormalsFlag { get { return this[nameof(RecomputeNormalsFlag)].GetValue<byte>(); } set { this[nameof(RecomputeNormalsFlag)].SetValue<byte>(value); } }
        public byte RecomputeTangentsFlag { get { return this[nameof(RecomputeTangentsFlag)].GetValue<byte>(); } set { this[nameof(RecomputeTangentsFlag)].SetValue<byte>(value); } }
        public bool bUseMikkTSpace { get { return this[nameof(bUseMikkTSpace)].Flag; } set { this[nameof(bUseMikkTSpace)].Flag = value; } }
        public bool bBuildAdjacencyBuffer { get { return this[nameof(bBuildAdjacencyBuffer)].Flag; } set { this[nameof(bBuildAdjacencyBuffer)].Flag = value; } }
        public bool bComputeWeightedNormals { get { return this[nameof(bComputeWeightedNormals)].Flag; } set { this[nameof(bComputeWeightedNormals)].Flag = value; } }
        public bool bBuildReversedIndexBuffer { get { return this[nameof(bBuildReversedIndexBuffer)].Flag; } set { this[nameof(bBuildReversedIndexBuffer)].Flag = value; } }
        public bool bUseHighPrecisionTangentBasis { get { return this[nameof(bUseHighPrecisionTangentBasis)].Flag; } set { this[nameof(bUseHighPrecisionTangentBasis)].Flag = value; } }
        public float DistanceFieldResolutionScale { get { return this[nameof(DistanceFieldResolutionScale)].GetValue<float>(); } set { this[nameof(DistanceFieldResolutionScale)].SetValue<float>(value); } }
        public bool bGenerateDistanceFieldAsIfTwoSided { get { return this[nameof(bGenerateDistanceFieldAsIfTwoSided)].Flag; } set { this[nameof(bGenerateDistanceFieldAsIfTwoSided)].Flag = value; } }
        public bool bSupportFaceRemap { get { return this[nameof(bSupportFaceRemap)].Flag; } set { this[nameof(bSupportFaceRemap)].Flag = value; } }
        public bool bPDGAsyncCommandletImportEnabled { get { return this[nameof(bPDGAsyncCommandletImportEnabled)].Flag; } set { this[nameof(bPDGAsyncCommandletImportEnabled)].Flag = value; } }
        public bool bEnableBackwardCompatibility { get { return this[nameof(bEnableBackwardCompatibility)].Flag; } set { this[nameof(bEnableBackwardCompatibility)].Flag = value; } }
        public bool bAutomaticLegacyHDARebuild { get { return this[nameof(bAutomaticLegacyHDARebuild)].Flag; } set { this[nameof(bAutomaticLegacyHDARebuild)].Flag = value; } }
        public bool bUseCustomHoudiniLocation { get { return this[nameof(bUseCustomHoudiniLocation)].Flag; } set { this[nameof(bUseCustomHoudiniLocation)].Flag = value; } }
        public DirectoryPath CustomHoudiniLocation { get { return this[nameof(CustomHoudiniLocation)].As<DirectoryPath>(); } set { this["CustomHoudiniLocation"] = value; } }
        public byte HoudiniExecutable { get { return this[nameof(HoudiniExecutable)].GetValue<byte>(); } set { this[nameof(HoudiniExecutable)].SetValue<byte>(value); } }
        public int CookingThreadStackSize { get { return this[nameof(CookingThreadStackSize)].GetValue<int>(); } set { this[nameof(CookingThreadStackSize)].SetValue<int>(value); } }
        public Object HoudiniEnvironmentFiles { get { return this[nameof(HoudiniEnvironmentFiles)]; } set { this[nameof(HoudiniEnvironmentFiles)] = value; } }
        public Object OtlSearchPath { get { return this[nameof(OtlSearchPath)]; } set { this[nameof(OtlSearchPath)] = value; } }
        public Object DsoSearchPath { get { return this[nameof(DsoSearchPath)]; } set { this[nameof(DsoSearchPath)] = value; } }
        public Object ImageDsoSearchPath { get { return this[nameof(ImageDsoSearchPath)]; } set { this[nameof(ImageDsoSearchPath)] = value; } }
        public Object AudioDsoSearchPath { get { return this[nameof(AudioDsoSearchPath)]; } set { this[nameof(AudioDsoSearchPath)] = value; } }
    }
    public class HoudiniSplineComponent : SceneComponent
    {
        public HoudiniSplineComponent(nint addr) : base(addr) { }
        public Array<Transform> CurvePoints { get { return new Array<Transform>(this[nameof(CurvePoints)].Address); } }
        public Array<Vector3d> DisplayPoints { get { return new Array<Vector3d>(this[nameof(DisplayPoints)].Address); } }
        public Array<int> DisplayPointIndexDivider { get { return new Array<int>(this[nameof(DisplayPointIndexDivider)].Address); } }
        public Object HoudiniSplineName { get { return this[nameof(HoudiniSplineName)]; } set { this[nameof(HoudiniSplineName)] = value; } }
        public bool bClosed { get { return this[nameof(bClosed)].Flag; } set { this[nameof(bClosed)].Flag = value; } }
        public bool bReversed { get { return this[nameof(bReversed)].Flag; } set { this[nameof(bReversed)].Flag = value; } }
        public int CurveOrder { get { return this[nameof(CurveOrder)].GetValue<int>(); } set { this[nameof(CurveOrder)].SetValue<int>(value); } }
        public bool bIsHoudiniSplineVisible { get { return this[nameof(bIsHoudiniSplineVisible)].Flag; } set { this[nameof(bIsHoudiniSplineVisible)].Flag = value; } }
        public EHoudiniCurveType CurveType { get { return (EHoudiniCurveType)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public EHoudiniCurveMethod CurveMethod { get { return (EHoudiniCurveMethod)this[nameof(CurveMethod)].GetValue<int>(); } set { this[nameof(CurveMethod)].SetValue<int>((int)value); } }
        public EHoudiniCurveBreakpointParameterization CurveBreakpointParameterization { get { return (EHoudiniCurveBreakpointParameterization)this[nameof(CurveBreakpointParameterization)].GetValue<int>(); } set { this[nameof(CurveBreakpointParameterization)].SetValue<int>((int)value); } }
        public bool bIsOutputCurve { get { return this[nameof(bIsOutputCurve)].Flag; } set { this[nameof(bIsOutputCurve)].Flag = value; } }
        public bool bCookOnCurveChanged { get { return this[nameof(bCookOnCurveChanged)].Flag; } set { this[nameof(bCookOnCurveChanged)].Flag = value; } }
        public bool bIsLegacyInputCurve { get { return this[nameof(bIsLegacyInputCurve)].Flag; } set { this[nameof(bIsLegacyInputCurve)].Flag = value; } }
        public bool bHasChanged { get { return this[nameof(bHasChanged)].Flag; } set { this[nameof(bHasChanged)].Flag = value; } }
        public bool bNeedsToTriggerUpdate { get { return this[nameof(bNeedsToTriggerUpdate)].Flag; } set { this[nameof(bNeedsToTriggerUpdate)].Flag = value; } }
        public bool bIsInputCurve { get { return this[nameof(bIsInputCurve)].Flag; } set { this[nameof(bIsInputCurve)].Flag = value; } }
        public bool bIsEditableOutputCurve { get { return this[nameof(bIsEditableOutputCurve)].Flag; } set { this[nameof(bIsEditableOutputCurve)].Flag = value; } }
        public int NodeID { get { return this[nameof(NodeID)].GetValue<int>(); } set { this[nameof(NodeID)].SetValue<int>(value); } }
        public Object PartName { get { return this[nameof(PartName)]; } set { this[nameof(PartName)] = value; } }
    }
    public class HoudiniStaticMesh : Object
    {
        public HoudiniStaticMesh(nint addr) : base(addr) { }
        public bool bHasNormals { get { return this[nameof(bHasNormals)].Flag; } set { this[nameof(bHasNormals)].Flag = value; } }
        public bool bHasTangents { get { return this[nameof(bHasTangents)].Flag; } set { this[nameof(bHasTangents)].Flag = value; } }
        public bool bHasColors { get { return this[nameof(bHasColors)].Flag; } set { this[nameof(bHasColors)].Flag = value; } }
        public uint NumUVLayers { get { return this[nameof(NumUVLayers)].GetValue<uint>(); } set { this[nameof(NumUVLayers)].SetValue<uint>(value); } }
        public bool bHasPerFaceMaterials { get { return this[nameof(bHasPerFaceMaterials)].Flag; } set { this[nameof(bHasPerFaceMaterials)].Flag = value; } }
        public Array<Vector3f> VertexPositions { get { return new Array<Vector3f>(this[nameof(VertexPositions)].Address); } }
        public Array<IntVector> TriangleIndices { get { return new Array<IntVector>(this[nameof(TriangleIndices)].Address); } }
        public Array<Color> VertexInstanceColors { get { return new Array<Color>(this[nameof(VertexInstanceColors)].Address); } }
        public Array<Vector3f> VertexInstanceNormals { get { return new Array<Vector3f>(this[nameof(VertexInstanceNormals)].Address); } }
        public Array<Vector3f> VertexInstanceUTangents { get { return new Array<Vector3f>(this[nameof(VertexInstanceUTangents)].Address); } }
        public Array<Vector3f> VertexInstanceVTangents { get { return new Array<Vector3f>(this[nameof(VertexInstanceVTangents)].Address); } }
        public Array<Vector2D> VertexInstanceUVs { get { return new Array<Vector2D>(this[nameof(VertexInstanceUVs)].Address); } }
        public Array<int> MaterialIDsPerTriangle { get { return new Array<int>(this[nameof(MaterialIDsPerTriangle)].Address); } }
        public Array<StaticMaterial> StaticMaterials { get { return new Array<StaticMaterial>(this[nameof(StaticMaterials)].Address); } }
        public void SetVertexPosition(uint InVertexIndex, Vector3f InPosition) { Invoke(nameof(SetVertexPosition), InVertexIndex, InPosition); }
        public void SetTriangleVertexVTangent(uint InTriangleIndex, byte InTriangleVertexIndex, Vector3f InVTangent) { Invoke(nameof(SetTriangleVertexVTangent), InTriangleIndex, InTriangleVertexIndex, InVTangent); }
        public void SetTriangleVertexUV(uint InTriangleIndex, byte InTriangleVertexIndex, byte InUVLayer, Vector2D InUV) { Invoke(nameof(SetTriangleVertexUV), InTriangleIndex, InTriangleVertexIndex, InUVLayer, InUV); }
        public void SetTriangleVertexUTangent(uint InTriangleIndex, byte InTriangleVertexIndex, Vector3f InUTangent) { Invoke(nameof(SetTriangleVertexUTangent), InTriangleIndex, InTriangleVertexIndex, InUTangent); }
        public void SetTriangleVertexNormal(uint InTriangleIndex, byte InTriangleVertexIndex, Vector3f InNormal) { Invoke(nameof(SetTriangleVertexNormal), InTriangleIndex, InTriangleVertexIndex, InNormal); }
        public void SetTriangleVertexIndices(uint InTriangleIndex, IntVector InTriangleVertexIndices) { Invoke(nameof(SetTriangleVertexIndices), InTriangleIndex, InTriangleVertexIndices); }
        public void SetTriangleVertexColor(uint InTriangleIndex, byte InTriangleVertexIndex, Color inColor) { Invoke(nameof(SetTriangleVertexColor), InTriangleIndex, InTriangleVertexIndex, inColor); }
        public void SetTriangleMaterialID(uint InTriangleIndex, int InMaterialID) { Invoke(nameof(SetTriangleMaterialID), InTriangleIndex, InMaterialID); }
        public void SetStaticMaterial(uint InMaterialIndex, StaticMaterial InStaticMaterial) { Invoke(nameof(SetStaticMaterial), InMaterialIndex, InStaticMaterial); }
        public void SetNumUVLayers(uint InNumUVLayers) { Invoke(nameof(SetNumUVLayers), InNumUVLayers); }
        public void SetNumStaticMaterials(uint InNumStaticMaterials) { Invoke(nameof(SetNumStaticMaterials), InNumStaticMaterials); }
        public void SetHasTangents(bool bInHasTangents) { Invoke(nameof(SetHasTangents), bInHasTangents); }
        public void SetHasPerFaceMaterials(bool bInHasPerFaceMaterials) { Invoke(nameof(SetHasPerFaceMaterials), bInHasPerFaceMaterials); }
        public void SetHasNormals(bool bInHasNormals) { Invoke(nameof(SetHasNormals), bInHasNormals); }
        public void SetHasColors(bool bInHasColors) { Invoke(nameof(SetHasColors), bInHasColors); }
        public void Optimize() { Invoke(nameof(Optimize)); }
        public bool IsValid(bool bInSkipVertexIndicesCheck) { return Invoke<bool>(nameof(IsValid), bInSkipVertexIndicesCheck); }
        public void Initialize(uint InNumVertices, uint InNumTriangles, uint InNumUVLayers, uint InInitialNumStaticMaterials, bool bInHasNormals, bool bInHasTangents, bool bInHasColors, bool bInHasPerFaceMaterials) { Invoke(nameof(Initialize), InNumVertices, InNumTriangles, InNumUVLayers, InInitialNumStaticMaterials, bInHasNormals, bInHasTangents, bInHasColors, bInHasPerFaceMaterials); }
        public bool HasTangents() { return Invoke<bool>(nameof(HasTangents)); }
        public bool HasPerFaceMaterials() { return Invoke<bool>(nameof(HasPerFaceMaterials)); }
        public bool HasNormals() { return Invoke<bool>(nameof(HasNormals)); }
        public bool HasColors() { return Invoke<bool>(nameof(HasColors)); }
        public Array<Vector3f> GetVertexPositions() { return Invoke<Array<Vector3f>>(nameof(GetVertexPositions)); }
        public Array<Vector3f> GetVertexInstanceVTangents() { return Invoke<Array<Vector3f>>(nameof(GetVertexInstanceVTangents)); }
        public Array<Vector2D> GetVertexInstanceUVs() { return Invoke<Array<Vector2D>>(nameof(GetVertexInstanceUVs)); }
        public Array<Vector3f> GetVertexInstanceUTangents() { return Invoke<Array<Vector3f>>(nameof(GetVertexInstanceUTangents)); }
        public Array<Vector3f> GetVertexInstanceNormals() { return Invoke<Array<Vector3f>>(nameof(GetVertexInstanceNormals)); }
        public Array<Color> GetVertexInstanceColors() { return Invoke<Array<Color>>(nameof(GetVertexInstanceColors)); }
        public Array<IntVector> GetTriangleIndices() { return Invoke<Array<IntVector>>(nameof(GetTriangleIndices)); }
        public Array<StaticMaterial> GetStaticMaterials() { return Invoke<Array<StaticMaterial>>(nameof(GetStaticMaterials)); }
        public uint GetNumVertices() { return Invoke<uint>(nameof(GetNumVertices)); }
        public uint GetNumVertexInstances() { return Invoke<uint>(nameof(GetNumVertexInstances)); }
        public uint GetNumUVLayers() { return Invoke<uint>(nameof(GetNumUVLayers)); }
        public uint GetNumTriangles() { return Invoke<uint>(nameof(GetNumTriangles)); }
        public uint GetNumStaticMaterials() { return Invoke<uint>(nameof(GetNumStaticMaterials)); }
        public int GetMaterialIndex(Object InMaterialSlotName) { return Invoke<int>(nameof(GetMaterialIndex), InMaterialSlotName); }
        public Array<int> GetMaterialIDsPerTriangle() { return Invoke<Array<int>>(nameof(GetMaterialIDsPerTriangle)); }
        public MaterialInterface GetMaterial(int InMaterialIndex) { return Invoke<MaterialInterface>(nameof(GetMaterial), InMaterialIndex); }
        public void CalculateTangents(bool bInComputeWeightedNormals) { Invoke(nameof(CalculateTangents), bInComputeWeightedNormals); }
        public void CalculateNormals(bool bInComputeWeightedNormals) { Invoke(nameof(CalculateNormals), bInComputeWeightedNormals); }
        public Box CalcBounds() { return Invoke<Box>(nameof(CalcBounds)); }
        public uint AddStaticMaterial(StaticMaterial InStaticMaterial) { return Invoke<uint>(nameof(AddStaticMaterial), InStaticMaterial); }
    }
    public class HoudiniStaticMeshComponent : MeshComponent
    {
        public HoudiniStaticMeshComponent(nint addr) : base(addr) { }
        public HoudiniStaticMesh Mesh { get { return this[nameof(Mesh)].As<HoudiniStaticMesh>(); } set { this["Mesh"] = value; } }
        public Box LocalBounds { get { return this[nameof(LocalBounds)].As<Box>(); } set { this["LocalBounds"] = value; } }
        public bool bHoudiniIconVisible { get { return this[nameof(bHoudiniIconVisible)].Flag; } set { this[nameof(bHoudiniIconVisible)].Flag = value; } }
        public void SetMesh(HoudiniStaticMesh InMesh) { Invoke(nameof(SetMesh), InMesh); }
        public void SetHoudiniIconVisible(bool bInHoudiniIconVisible) { Invoke(nameof(SetHoudiniIconVisible), bInHoudiniIconVisible); }
        public void NotifyMeshUpdated() { Invoke(nameof(NotifyMeshUpdated)); }
        public bool IsHoudiniIconVisible() { return Invoke<bool>(nameof(IsHoudiniIconVisible)); }
        public HoudiniStaticMesh GetMesh() { return Invoke<HoudiniStaticMesh>(nameof(GetMesh)); }
    }
    public class HoudiniAssetStateEvents : Interface
    {
        public HoudiniAssetStateEvents(nint addr) : base(addr) { }
    }
    public enum EHoudiniStaticMeshMethod : int
    {
        RawMesh = 0,
        FMeshDescription = 1,
        UHoudiniStaticMesh = 2,
        EHoudiniStaticMeshMethod_MAX = 3,
    }
    public enum EHoudiniAssetState : int
    {
        NeedInstantiation = 0,
        NewHDA = 1,
        PreInstantiation = 2,
        Instantiating = 3,
        PreCook = 4,
        Cooking = 5,
        PostCook = 6,
        PreProcess = 7,
        Processing = 8,
        None = 9,
        NeedRebuild = 10,
        NeedDelete = 11,
        Deleting = 12,
        ProcessTemplate = 13,
        EHoudiniAssetState_MAX = 14,
    }
    public enum EHoudiniAssetStateResult : int
    {
        None = 0,
        Working = 1,
        Success = 2,
        FinishedWithError = 3,
        FinishedWithFatalError = 4,
        Aborted = 5,
        EHoudiniAssetStateResult_MAX = 6,
    }
    public enum EHoudiniRampInterpolationType : int
    {
        InValid = -1,
        CONSTANT = 0,
        LINEAR = 1,
        CATMULL_ROM = 2,
        MONOTONE_CUBIC = 3,
        BEZIER = 4,
        BSPLINE = 5,
        HERMITE = 6,
        EHoudiniRampInterpolationType_MAX = 7,
    }
    public enum EHoudiniLandscapeOutputBakeType : int
    {
        Detachment = 0,
        BakeToImage = 1,
        BakeToWorld = 2,
        InValid = 3,
        EHoudiniLandscapeOutputBakeType_MAX = 4,
    }
    public enum EHoudiniInputType : int
    {
        Invalid = 0,
        Geometry = 1,
        Curve = 2,
        Asset = 3,
        Landscape = 4,
        World = 5,
        Skeletal = 6,
        GeometryCollection = 7,
        EHoudiniInputType_MAX = 8,
    }
    public enum EHoudiniOutputType : int
    {
        Invalid = 0,
        Mesh = 1,
        Instancer = 2,
        Landscape = 3,
        Curve = 4,
        Skeletal = 5,
        GeometryCollection = 6,
        DataTable = 7,
        EHoudiniOutputType_MAX = 8,
    }
    public enum EHoudiniCurveType : int
    {
        Invalid = -1,
        Polygon = 0,
        Nurbs = 1,
        Bezier = 2,
        Points = 3,
        EHoudiniCurveType_MAX = 4,
    }
    public enum EHoudiniCurveMethod : int
    {
        Invalid = -1,
        CVs = 0,
        Breakpoints = 1,
        Freehand = 2,
        EHoudiniCurveMethod_MAX = 3,
    }
    public enum EHoudiniCurveBreakpointParameterization : int
    {
        Invalid = -1,
        Uniform = 0,
        Chord = 1,
        Centripetal = 2,
        EHoudiniCurveBreakpointParameterization_MAX = 3,
    }
    public enum EHoudiniLandscapeExportType : int
    {
        Heightfield = 0,
        Mesh = 1,
        Points = 2,
        EHoudiniLandscapeExportType_MAX = 3,
    }
    public enum EHoudiniProxyRefineResult : int
    {
        Invalid = 0,
        Failed = 1,
        Success = 2,
        Skipped = 3,
        EHoudiniProxyRefineResult_MAX = 4,
    }
    public enum EHoudiniProxyRefineRequestResult : int
    {
        Invalid = 0,
        None = 1,
        PendingCooks = 2,
        Refined = 3,
        EHoudiniProxyRefineRequestResult_MAX = 4,
    }
    public enum EAttribStorageType : int
    {
        Invalid = -1,
        INT = 0,
        INT64 = 1,
        FLOAT = 2,
        FLOAT64 = 3,
        STRING = 4,
        EAttribStorageType_MAX = 5,
    }
    public enum EAttribOwner : int
    {
        Invalid = -1,
        Vertex = 0,
        Point = 1,
        Prim = 2,
        Detail = 3,
        EAttribOwner_MAX = 4,
    }
    public enum EHoudiniGeoType : int
    {
        Invalid = 0,
        Default = 1,
        Intermediate = 2,
        Input = 3,
        Curve = 4,
        EHoudiniGeoType_MAX = 5,
    }
    public enum EHoudiniPartType : int
    {
        Invalid = 0,
        Mesh = 1,
        Instancer = 2,
        Curve = 3,
        Volume = 4,
        DataTable = 5,
        EHoudiniPartType_MAX = 6,
    }
    public enum EHoudiniInstancerType : int
    {
        Invalid = 0,
        ObjectInstancer = 1,
        PackedPrimitive = 2,
        AttributeInstancer = 3,
        OldSchoolAttributeInstancer = 4,
        GeometryCollection = 5,
        EHoudiniInstancerType_MAX = 6,
    }
    public enum EXformParameter : int
    {
        TX = 0,
        TY = 1,
        TZ = 2,
        RX = 3,
        RY = 4,
        RZ = 5,
        SX = 6,
        SY = 7,
        SZ = 8,
        COUNT = 9,
        EXformParameter_MAX = 10,
    }
    public enum EHoudiniHandleType : int
    {
        Xform = 0,
        Bounder = 1,
        Unsupported = 2,
        EHoudiniHandleType_MAX = 3,
    }
    public enum EHoudiniInputObjectType : int
    {
        Invalid = 0,
        Object = 1,
        StaticMesh = 2,
        SkeletalMesh = 3,
        SceneComponent = 4,
        StaticMeshComponent = 5,
        InstancedStaticMeshComponent = 6,
        SplineComponent = 7,
        HoudiniSplineComponent = 8,
        HoudiniAssetComponent = 9,
        Actor = 10,
        Landscape = 11,
        Brush = 12,
        CameraComponent = 13,
        DataTable = 14,
        HoudiniAssetActor = 15,
        FoliageType_InstancedStaticMesh = 16,
        GeometryCollection = 17,
        GeometryCollectionComponent = 18,
        GeometryCollectionActor_Deprecated = 19,
        SkeletalMeshComponent = 20,
        Blueprint = 21,
        EHoudiniInputObjectType_MAX = 22,
    }
    public enum EHoudiniXformType : int
    {
        None = 0,
        IntoThisObject = 1,
        Auto = 2,
        EHoudiniXformType_MAX = 3,
    }
    public enum EHoudiniCurveOutputType : int
    {
        UnrealSpline = 0,
        HoudiniSpline = 1,
        EHoudiniCurveOutputType_MAX = 2,
    }
    public enum EHoudiniParameterType : int
    {
        Invalid = 0,
        Button = 1,
        ButtonStrip = 2,
        Color = 3,
        ColorRamp = 4,
        File = 5,
        FileDir = 6,
        FileGeo = 7,
        FileImage = 8,
        Float = 9,
        FloatRamp = 10,
        Folder = 11,
        FolderList = 12,
        Input = 13,
        Int = 14,
        IntChoice = 15,
        Label = 16,
        MultiParm = 17,
        Separator = 18,
        String = 19,
        StringChoice = 20,
        StringAssetRef = 21,
        Toggle = 22,
        EHoudiniParameterType_MAX = 23,
    }
    public enum EHoudiniFolderParameterType : int
    {
        Invalid = 0,
        Collapsible = 1,
        Simple = 2,
        Tabs = 3,
        Radio = 4,
        Other = 5,
        EHoudiniFolderParameterType_MAX = 6,
    }
    public enum EHoudiniMultiParmModificationType : int
    {
        None = 0,
        Inserted = 1,
        Removed = 2,
        Modified = 3,
        EHoudiniMultiParmModificationType_MAX = 4,
    }
    public enum EHoudiniRampPointConstructStatus : int
    {
        None = 0,
        INITIALIZED = 1,
        POSITION_INSERTED = 2,
        VALUE_INSERTED = 3,
        INTERPTYPE_INSERTED = 4,
        EHoudiniRampPointConstructStatus_MAX = 5,
    }
    public enum EPDGLinkState : int
    {
        Inactive = 0,
        Linking = 1,
        Linked = 2,
        Error_Not_Linked = 3,
        EPDGLinkState_MAX = 4,
    }
    public enum EPDGNodeState : int
    {
        None = 0,
        Dirtied = 1,
        Dirtying = 2,
        Cooking = 3,
        Cook_Complete = 4,
        Cook_Failed = 5,
        EPDGNodeState_MAX = 6,
    }
    public enum EPDGWorkResultState : int
    {
        None = 0,
        ToLoad = 1,
        Loading = 2,
        Loaded = 3,
        ToDelete = 4,
        Deleting = 5,
        Deleted = 6,
        NotLoaded = 7,
        EPDGWorkResultState_MAX = 8,
    }
    public enum EHoudiniRuntimeSettingsSessionType : int
    {
        HRSST_InProcess = 0,
        HRSST_Socket = 1,
        HRSST_NamedPipe = 2,
        HRSST_None = 3,
        HRSST_MAX = 4,
    }
    public enum EHoudiniRuntimeSettingsRecomputeFlag : int
    {
        HRSRF_Always = 0,
        HRSRF_OnlyIfMissing = 1,
        HRSRF_Never = 2,
        HRSRF_MAX = 3,
    }
    public enum EHoudiniExecutableType : int
    {
        HRSHE_Houdini = 0,
        HRSHE_HoudiniFX = 1,
        HRSHE_HoudiniCore = 2,
        HRSHE_HoudiniIndie = 3,
        HRSHE_MAX = 4,
    }
    public class HoudiniAssetBlueprintOutput : Object
    {
        public HoudiniAssetBlueprintOutput(nint addr) : base(addr) { }
        public int OutputIndex { get { return this[nameof(OutputIndex)].GetValue<int>(); } set { this[nameof(OutputIndex)].SetValue<int>(value); } }
        public HoudiniOutputObject OutputObject { get { return this[nameof(OutputObject)].As<HoudiniOutputObject>(); } set { this["OutputObject"] = value; } }
    }
    public class HoudiniOutputObject : Object
    {
        public HoudiniOutputObject(nint addr) : base(addr) { }
        public Object OutputObject { get { return this[nameof(OutputObject)].As<Object>(); } set { this["OutputObject"] = value; } }
        public Array<Object> OutputComponents { get { return new Array<Object>(this[nameof(OutputComponents)].Address); } }
        public Object OutputComponent { get { return this[nameof(OutputComponent)].As<Object>(); } set { this["OutputComponent"] = value; } }
        public Object ProxyObject { get { return this[nameof(ProxyObject)].As<Object>(); } set { this["ProxyObject"] = value; } }
        public Object ProxyComponent { get { return this[nameof(ProxyComponent)].As<Object>(); } set { this["ProxyComponent"] = value; } }
        public bool bProxyIsCurrent { get { return this[nameof(bProxyIsCurrent)].Flag; } set { this[nameof(bProxyIsCurrent)].Flag = value; } }
        public bool bIsImplicit { get { return this[nameof(bIsImplicit)].Flag; } set { this[nameof(bIsImplicit)].Flag = value; } }
        public bool bIsGeometryCollectionPiece { get { return this[nameof(bIsGeometryCollectionPiece)].Flag; } set { this[nameof(bIsGeometryCollectionPiece)].Flag = value; } }
        public Object GeometryCollectionPieceName { get { return this[nameof(GeometryCollectionPieceName)]; } set { this[nameof(GeometryCollectionPieceName)] = value; } }
        public Object BakeName { get { return this[nameof(BakeName)]; } set { this[nameof(BakeName)] = value; } }
        public HoudiniCurveOutputProperties CurveOutputProperty { get { return this[nameof(CurveOutputProperty)].As<HoudiniCurveOutputProperties>(); } set { this["CurveOutputProperty"] = value; } }
        public Object CachedAttributes { get { return this[nameof(CachedAttributes)]; } set { this[nameof(CachedAttributes)] = value; } }
        public Object CachedTokens { get { return this[nameof(CachedTokens)]; } set { this[nameof(CachedTokens)] = value; } }
        public Object InstancedObject { get { return this[nameof(InstancedObject)].As<Object>(); } set { this["InstancedObject"] = value; } }
        public FoliageType FoliageType { get { return this[nameof(FoliageType)].As<FoliageType>(); } set { this["FoliageType"] = value; } }
    }
    public class HoudiniCurveOutputProperties : Object
    {
        public HoudiniCurveOutputProperties(nint addr) : base(addr) { }
        public EHoudiniCurveOutputType CurveOutputType { get { return (EHoudiniCurveOutputType)this[nameof(CurveOutputType)].GetValue<int>(); } set { this[nameof(CurveOutputType)].SetValue<int>((int)value); } }
        public int NumPoints { get { return this[nameof(NumPoints)].GetValue<int>(); } set { this[nameof(NumPoints)].SetValue<int>(value); } }
        public bool bClosed { get { return this[nameof(bClosed)].Flag; } set { this[nameof(bClosed)].Flag = value; } }
        public EHoudiniCurveType CurveType { get { return (EHoudiniCurveType)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public EHoudiniCurveMethod CurveMethod { get { return (EHoudiniCurveMethod)this[nameof(CurveMethod)].GetValue<int>(); } set { this[nameof(CurveMethod)].SetValue<int>((int)value); } }
    }
    public class HoudiniAssetBlueprintInstanceData : ActorComponentInstanceData
    {
        public HoudiniAssetBlueprintInstanceData(nint addr) : base(addr) { }
        public HoudiniAsset HoudiniAsset { get { return this[nameof(HoudiniAsset)].As<HoudiniAsset>(); } set { this["HoudiniAsset"] = value; } }
        public int AssetId { get { return this[nameof(AssetId)].GetValue<int>(); } set { this[nameof(AssetId)].SetValue<int>(value); } }
        public EHoudiniAssetState AssetState { get { return (EHoudiniAssetState)this[nameof(AssetState)].GetValue<int>(); } set { this[nameof(AssetState)].SetValue<int>((int)value); } }
        public uint SubAssetIndex { get { return this[nameof(SubAssetIndex)].GetValue<uint>(); } set { this[nameof(SubAssetIndex)].SetValue<uint>(value); } }
        public uint AssetCookCount { get { return this[nameof(AssetCookCount)].GetValue<uint>(); } set { this[nameof(AssetCookCount)].SetValue<uint>(value); } }
        public bool bHasBeenLoaded { get { return this[nameof(bHasBeenLoaded)].Flag; } set { this[nameof(bHasBeenLoaded)].Flag = value; } }
        public bool bHasBeenDuplicated { get { return this[nameof(bHasBeenDuplicated)].Flag; } set { this[nameof(bHasBeenDuplicated)].Flag = value; } }
        public bool bPendingDelete { get { return this[nameof(bPendingDelete)].Flag; } set { this[nameof(bPendingDelete)].Flag = value; } }
        public bool bRecookRequested { get { return this[nameof(bRecookRequested)].Flag; } set { this[nameof(bRecookRequested)].Flag = value; } }
        public bool bRebuildRequested { get { return this[nameof(bRebuildRequested)].Flag; } set { this[nameof(bRebuildRequested)].Flag = value; } }
        public bool bEnableCooking { get { return this[nameof(bEnableCooking)].Flag; } set { this[nameof(bEnableCooking)].Flag = value; } }
        public bool bForceNeedUpdate { get { return this[nameof(bForceNeedUpdate)].Flag; } set { this[nameof(bForceNeedUpdate)].Flag = value; } }
        public bool bLastCookSuccess { get { return this[nameof(bLastCookSuccess)].Flag; } set { this[nameof(bLastCookSuccess)].Flag = value; } }
        public Guid ComponentGUID { get { return this[nameof(ComponentGUID)].As<Guid>(); } set { this["ComponentGUID"] = value; } }
        public Guid HapiGUID { get { return this[nameof(HapiGUID)].As<Guid>(); } set { this["HapiGUID"] = value; } }
        public bool bRegisteredComponentTemplate { get { return this[nameof(bRegisteredComponentTemplate)].Flag; } set { this[nameof(bRegisteredComponentTemplate)].Flag = value; } }
        public Object SourceName { get { return this[nameof(SourceName)]; } set { this[nameof(SourceName)] = value; } }
        public Object Outputs { get { return this[nameof(Outputs)]; } set { this[nameof(Outputs)] = value; } }
        public Array<HoudiniInput> Inputs { get { return new Array<HoudiniInput>(this[nameof(Inputs)].Address); } }
    }
    public class HoudiniOutputObjectIdentifier : Object
    {
        public HoudiniOutputObjectIdentifier(nint addr) : base(addr) { }
        public int ObjectId { get { return this[nameof(ObjectId)].GetValue<int>(); } set { this[nameof(ObjectId)].SetValue<int>(value); } }
        public int GeoId { get { return this[nameof(GeoId)].GetValue<int>(); } set { this[nameof(GeoId)].SetValue<int>(value); } }
        public int PartId { get { return this[nameof(PartId)].GetValue<int>(); } set { this[nameof(PartId)].SetValue<int>(value); } }
        public Object SplitIdentifier { get { return this[nameof(SplitIdentifier)]; } set { this[nameof(SplitIdentifier)] = value; } }
        public Object PartName { get { return this[nameof(PartName)]; } set { this[nameof(PartName)] = value; } }
        public int PrimitiveIndex { get { return this[nameof(PrimitiveIndex)].GetValue<int>(); } set { this[nameof(PrimitiveIndex)].SetValue<int>(value); } }
        public int PointIndex { get { return this[nameof(PointIndex)].GetValue<int>(); } set { this[nameof(PointIndex)].SetValue<int>(value); } }
    }
    public class HoudiniGenericAttributeChangedProperty : Object
    {
        public HoudiniGenericAttributeChangedProperty(nint addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)].As<Object>(); } set { this["Object"] = value; } }
    }
    public class HoudiniGenericAttribute : Object
    {
        public HoudiniGenericAttribute(nint addr) : base(addr) { }
        public Object AttributeName { get { return this[nameof(AttributeName)]; } set { this[nameof(AttributeName)] = value; } }
        public EAttribStorageType AttributeType { get { return (EAttribStorageType)this[nameof(AttributeType)].GetValue<int>(); } set { this[nameof(AttributeType)].SetValue<int>((int)value); } }
        public EAttribOwner AttributeOwner { get { return (EAttribOwner)this[nameof(AttributeOwner)].GetValue<int>(); } set { this[nameof(AttributeOwner)].SetValue<int>((int)value); } }
        public int AttributeCount { get { return this[nameof(AttributeCount)].GetValue<int>(); } set { this[nameof(AttributeCount)].SetValue<int>(value); } }
        public int AttributeTupleSize { get { return this[nameof(AttributeTupleSize)].GetValue<int>(); } set { this[nameof(AttributeTupleSize)].SetValue<int>(value); } }
        public Array<double> DoubleValues { get { return new Array<double>(this[nameof(DoubleValues)].Address); } }
        public Array<long> IntValues { get { return new Array<long>(this[nameof(IntValues)].Address); } }
        public Array<Object> StringValues { get { return new Array<Object>(this[nameof(StringValues)].Address); } }
    }
    public class HoudiniObjectInfo : Object
    {
        public HoudiniObjectInfo(nint addr) : base(addr) { }
    }
    public class HoudiniGeoInfo : Object
    {
        public HoudiniGeoInfo(nint addr) : base(addr) { }
    }
    public class HoudiniPartInfo : Object
    {
        public HoudiniPartInfo(nint addr) : base(addr) { }
    }
    public class HoudiniVolumeInfo : Object
    {
        public HoudiniVolumeInfo(nint addr) : base(addr) { }
    }
    public class HoudiniCurveInfo : Object
    {
        public HoudiniCurveInfo(nint addr) : base(addr) { }
    }
    public class HoudiniMeshSocket : Object
    {
        public HoudiniMeshSocket(nint addr) : base(addr) { }
    }
    public class HoudiniGeoPartObject : Object
    {
        public HoudiniGeoPartObject(nint addr) : base(addr) { }
        public int AssetId { get { return this[nameof(AssetId)].GetValue<int>(); } set { this[nameof(AssetId)].SetValue<int>(value); } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public int ObjectId { get { return this[nameof(ObjectId)].GetValue<int>(); } set { this[nameof(ObjectId)].SetValue<int>(value); } }
        public Object ObjectName { get { return this[nameof(ObjectName)]; } set { this[nameof(ObjectName)] = value; } }
        public int GeoId { get { return this[nameof(GeoId)].GetValue<int>(); } set { this[nameof(GeoId)].SetValue<int>(value); } }
        public int PartId { get { return this[nameof(PartId)].GetValue<int>(); } set { this[nameof(PartId)].SetValue<int>(value); } }
        public Object PartName { get { return this[nameof(PartName)]; } set { this[nameof(PartName)] = value; } }
        public bool bHasCustomPartName { get { return this[nameof(bHasCustomPartName)].Flag; } set { this[nameof(bHasCustomPartName)].Flag = value; } }
        public Array<Object> SplitGroups { get { return new Array<Object>(this[nameof(SplitGroups)].Address); } }
        public Transform TransformMatrix { get { return this[nameof(TransformMatrix)].As<Transform>(); } set { this["TransformMatrix"] = value; } }
        public Object NodePath { get { return this[nameof(NodePath)]; } set { this[nameof(NodePath)] = value; } }
        public EHoudiniPartType Type { get { return (EHoudiniPartType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public EHoudiniInstancerType InstancerType { get { return (EHoudiniInstancerType)this[nameof(InstancerType)].GetValue<int>(); } set { this[nameof(InstancerType)].SetValue<int>((int)value); } }
        public Object VolumeName { get { return this[nameof(VolumeName)]; } set { this[nameof(VolumeName)] = value; } }
        public bool bHasEditLayers { get { return this[nameof(bHasEditLayers)].Flag; } set { this[nameof(bHasEditLayers)].Flag = value; } }
        public Object VolumeLayerName { get { return this[nameof(VolumeLayerName)]; } set { this[nameof(VolumeLayerName)] = value; } }
        public int VolumeTileIndex { get { return this[nameof(VolumeTileIndex)].GetValue<int>(); } set { this[nameof(VolumeTileIndex)].SetValue<int>(value); } }
        public bool bIsVisible { get { return this[nameof(bIsVisible)].Flag; } set { this[nameof(bIsVisible)].Flag = value; } }
        public bool bIsEditable { get { return this[nameof(bIsEditable)].Flag; } set { this[nameof(bIsEditable)].Flag = value; } }
        public bool bIsTemplated { get { return this[nameof(bIsTemplated)].Flag; } set { this[nameof(bIsTemplated)].Flag = value; } }
        public bool bIsInstanced { get { return this[nameof(bIsInstanced)].Flag; } set { this[nameof(bIsInstanced)].Flag = value; } }
        public bool bHasGeoChanged { get { return this[nameof(bHasGeoChanged)].Flag; } set { this[nameof(bHasGeoChanged)].Flag = value; } }
        public bool bHasPartChanged { get { return this[nameof(bHasPartChanged)].Flag; } set { this[nameof(bHasPartChanged)].Flag = value; } }
        public bool bHasTransformChanged { get { return this[nameof(bHasTransformChanged)].Flag; } set { this[nameof(bHasTransformChanged)].Flag = value; } }
        public bool bHasMaterialsChanged { get { return this[nameof(bHasMaterialsChanged)].Flag; } set { this[nameof(bHasMaterialsChanged)].Flag = value; } }
        public Array<HoudiniMeshSocket> AllMeshSockets { get { return new Array<HoudiniMeshSocket>(this[nameof(AllMeshSockets)].Address); } }
    }
    public class HoudiniBrushInfo : Object
    {
        public HoudiniBrushInfo(nint addr) : base(addr) { }
        public Object BrushActor { get { return this[nameof(BrushActor)]; } set { this[nameof(BrushActor)] = value; } }
        public Transform CachedTransform { get { return this[nameof(CachedTransform)].As<Transform>(); } set { this["CachedTransform"] = value; } }
        public Vector CachedOrigin { get { return this[nameof(CachedOrigin)].As<Vector>(); } set { this["CachedOrigin"] = value; } }
        public Vector CachedExtent { get { return this[nameof(CachedExtent)].As<Vector>(); } set { this["CachedExtent"] = value; } }
        public byte CachedBrushType { get { return this[nameof(CachedBrushType)].GetValue<byte>(); } set { this[nameof(CachedBrushType)].SetValue<byte>(value); } }
        public ulong CachedSurfaceHash { get { return this[nameof(CachedSurfaceHash)].GetValue<ulong>(); } set { this[nameof(CachedSurfaceHash)].SetValue<ulong>(value); } }
    }
    public class HoudiniBakedOutputObjectIdentifier : Object
    {
        public HoudiniBakedOutputObjectIdentifier(nint addr) : base(addr) { }
        public int PartId { get { return this[nameof(PartId)].GetValue<int>(); } set { this[nameof(PartId)].SetValue<int>(value); } }
        public Object SplitIdentifier { get { return this[nameof(SplitIdentifier)]; } set { this[nameof(SplitIdentifier)] = value; } }
    }
    public class HoudiniInstancedOutput : Object
    {
        public HoudiniInstancedOutput(nint addr) : base(addr) { }
        public Object OriginalObject { get { return this[nameof(OriginalObject)]; } set { this[nameof(OriginalObject)] = value; } }
        public int OriginalObjectIndex { get { return this[nameof(OriginalObjectIndex)].GetValue<int>(); } set { this[nameof(OriginalObjectIndex)].SetValue<int>(value); } }
        public Array<Transform> OriginalTransforms { get { return new Array<Transform>(this[nameof(OriginalTransforms)].Address); } }
        public Array<Object> VariationObjects { get { return new Array<Object>(this[nameof(VariationObjects)].Address); } }
        public Array<Transform> VariationTransformOffsets { get { return new Array<Transform>(this[nameof(VariationTransformOffsets)].Address); } }
        public Array<int> TransformVariationIndices { get { return new Array<int>(this[nameof(TransformVariationIndices)].Address); } }
        public Array<int> OriginalInstanceIndices { get { return new Array<int>(this[nameof(OriginalInstanceIndices)].Address); } }
        public bool bChanged { get { return this[nameof(bChanged)].Flag; } set { this[nameof(bChanged)].Flag = value; } }
        public bool bStale { get { return this[nameof(bStale)].Flag; } set { this[nameof(bStale)].Flag = value; } }
    }
    public class HoudiniBakedOutputObject : Object
    {
        public HoudiniBakedOutputObject(nint addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Object Blueprint { get { return this[nameof(Blueprint)]; } set { this[nameof(Blueprint)] = value; } }
        public Object ActorBakeName { get { return this[nameof(ActorBakeName)]; } set { this[nameof(ActorBakeName)] = value; } }
        public Object BakedObject { get { return this[nameof(BakedObject)]; } set { this[nameof(BakedObject)] = value; } }
        public Object BakedComponent { get { return this[nameof(BakedComponent)]; } set { this[nameof(BakedComponent)] = value; } }
        public Array<Object> InstancedActors { get { return new Array<Object>(this[nameof(InstancedActors)].Address); } }
        public Array<Object> InstancedComponents { get { return new Array<Object>(this[nameof(InstancedComponents)].Address); } }
        public Object LandscapeLayers { get { return this[nameof(LandscapeLayers)]; } set { this[nameof(LandscapeLayers)] = value; } }
    }
    public class HoudiniBakedOutput : Object
    {
        public HoudiniBakedOutput(nint addr) : base(addr) { }
        public Object BakedOutputObjects { get { return this[nameof(BakedOutputObjects)]; } set { this[nameof(BakedOutputObjects)] = value; } }
    }
    public class OutputActorOwner : Object
    {
        public OutputActorOwner(nint addr) : base(addr) { }
        public Actor OutputActor { get { return this[nameof(OutputActor)].As<Actor>(); } set { this["OutputActor"] = value; } }
    }
    public class TOPWorkResultObject : Object
    {
        public TOPWorkResultObject(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object FilePath { get { return this[nameof(FilePath)]; } set { this[nameof(FilePath)] = value; } }
        public EPDGWorkResultState State { get { return (EPDGWorkResultState)this[nameof(State)].GetValue<int>(); } set { this[nameof(State)].SetValue<int>((int)value); } }
        public int WorkItemResultInfoIndex { get { return this[nameof(WorkItemResultInfoIndex)].GetValue<int>(); } set { this[nameof(WorkItemResultInfoIndex)].SetValue<int>(value); } }
        public Array<HoudiniOutput> ResultOutputs { get { return new Array<HoudiniOutput>(this[nameof(ResultOutputs)].Address); } }
        public bool bAutoBakedSinceLastLoad { get { return this[nameof(bAutoBakedSinceLastLoad)].Flag; } set { this[nameof(bAutoBakedSinceLastLoad)].Flag = value; } }
        public OutputActorOwner OutputActorOwner { get { return this[nameof(OutputActorOwner)].As<OutputActorOwner>(); } set { this["OutputActorOwner"] = value; } }
    }
    public class TOPWorkResult : Object
    {
        public TOPWorkResult(nint addr) : base(addr) { }
        public int WorkItemIndex { get { return this[nameof(WorkItemIndex)].GetValue<int>(); } set { this[nameof(WorkItemIndex)].SetValue<int>(value); } }
        public int WorkItemID { get { return this[nameof(WorkItemID)].GetValue<int>(); } set { this[nameof(WorkItemID)].SetValue<int>(value); } }
        public Array<TOPWorkResultObject> ResultObjects { get { return new Array<TOPWorkResultObject>(this[nameof(ResultObjects)].Address); } }
    }
    public class WorkItemTallyBase : Object
    {
        public WorkItemTallyBase(nint addr) : base(addr) { }
    }
    public class WorkItemTally : WorkItemTallyBase
    {
        public WorkItemTally(nint addr) : base(addr) { }
        public Object AllWorkItems { get { return this[nameof(AllWorkItems)]; } set { this[nameof(AllWorkItems)] = value; } }
        public Object WaitingWorkItems { get { return this[nameof(WaitingWorkItems)]; } set { this[nameof(WaitingWorkItems)] = value; } }
        public Object ScheduledWorkItems { get { return this[nameof(ScheduledWorkItems)]; } set { this[nameof(ScheduledWorkItems)] = value; } }
        public Object CookingWorkItems { get { return this[nameof(CookingWorkItems)]; } set { this[nameof(CookingWorkItems)] = value; } }
        public Object CookedWorkItems { get { return this[nameof(CookedWorkItems)]; } set { this[nameof(CookedWorkItems)] = value; } }
        public Object ErroredWorkItems { get { return this[nameof(ErroredWorkItems)]; } set { this[nameof(ErroredWorkItems)] = value; } }
        public Object CookCancelledWorkItems { get { return this[nameof(CookCancelledWorkItems)]; } set { this[nameof(CookCancelledWorkItems)] = value; } }
    }
    public class AggregatedWorkItemTally : WorkItemTallyBase
    {
        public AggregatedWorkItemTally(nint addr) : base(addr) { }
        public int TotalWorkItems { get { return this[nameof(TotalWorkItems)].GetValue<int>(); } set { this[nameof(TotalWorkItems)].SetValue<int>(value); } }
        public int WaitingWorkItems { get { return this[nameof(WaitingWorkItems)].GetValue<int>(); } set { this[nameof(WaitingWorkItems)].SetValue<int>(value); } }
        public int ScheduledWorkItems { get { return this[nameof(ScheduledWorkItems)].GetValue<int>(); } set { this[nameof(ScheduledWorkItems)].SetValue<int>(value); } }
        public int CookingWorkItems { get { return this[nameof(CookingWorkItems)].GetValue<int>(); } set { this[nameof(CookingWorkItems)].SetValue<int>(value); } }
        public int CookedWorkItems { get { return this[nameof(CookedWorkItems)].GetValue<int>(); } set { this[nameof(CookedWorkItems)].SetValue<int>(value); } }
        public int ErroredWorkItems { get { return this[nameof(ErroredWorkItems)].GetValue<int>(); } set { this[nameof(ErroredWorkItems)].SetValue<int>(value); } }
        public int CookCancelledWorkItems { get { return this[nameof(CookCancelledWorkItems)].GetValue<int>(); } set { this[nameof(CookCancelledWorkItems)].SetValue<int>(value); } }
    }
    public class HoudiniPDGWorkResultObjectBakedOutput : Object
    {
        public HoudiniPDGWorkResultObjectBakedOutput(nint addr) : base(addr) { }
        public Array<HoudiniBakedOutput> BakedOutputs { get { return new Array<HoudiniBakedOutput>(this[nameof(BakedOutputs)].Address); } }
    }
    public class HoudiniStaticMeshGenerationProperties : Object
    {
        public HoudiniStaticMeshGenerationProperties(nint addr) : base(addr) { }
        public bool bGeneratedDoubleSidedGeometry { get { return this[nameof(bGeneratedDoubleSidedGeometry)].Flag; } set { this[nameof(bGeneratedDoubleSidedGeometry)].Flag = value; } }
        public PhysicalMaterial GeneratedPhysMaterial { get { return this[nameof(GeneratedPhysMaterial)].As<PhysicalMaterial>(); } set { this["GeneratedPhysMaterial"] = value; } }
        public BodyInstance DefaultBodyInstance { get { return this[nameof(DefaultBodyInstance)].As<BodyInstance>(); } set { this["DefaultBodyInstance"] = value; } }
        public byte GeneratedCollisionTraceFlag { get { return this[nameof(GeneratedCollisionTraceFlag)].GetValue<byte>(); } set { this[nameof(GeneratedCollisionTraceFlag)].SetValue<byte>(value); } }
        public int GeneratedLightMapResolution { get { return this[nameof(GeneratedLightMapResolution)].GetValue<int>(); } set { this[nameof(GeneratedLightMapResolution)].SetValue<int>(value); } }
        public WalkableSlopeOverride GeneratedWalkableSlopeOverride { get { return this[nameof(GeneratedWalkableSlopeOverride)].As<WalkableSlopeOverride>(); } set { this["GeneratedWalkableSlopeOverride"] = value; } }
        public int GeneratedLightMapCoordinateIndex { get { return this[nameof(GeneratedLightMapCoordinateIndex)].GetValue<int>(); } set { this[nameof(GeneratedLightMapCoordinateIndex)].SetValue<int>(value); } }
        public bool bGeneratedUseMaximumStreamingTexelRatio { get { return this[nameof(bGeneratedUseMaximumStreamingTexelRatio)].Flag; } set { this[nameof(bGeneratedUseMaximumStreamingTexelRatio)].Flag = value; } }
        public float GeneratedStreamingDistanceMultiplier { get { return this[nameof(GeneratedStreamingDistanceMultiplier)].GetValue<float>(); } set { this[nameof(GeneratedStreamingDistanceMultiplier)].SetValue<float>(value); } }
        public FoliageType_InstancedStaticMesh GeneratedFoliageDefaultSettings { get { return this[nameof(GeneratedFoliageDefaultSettings)].As<FoliageType_InstancedStaticMesh>(); } set { this["GeneratedFoliageDefaultSettings"] = value; } }
        public Array<AssetUserData> GeneratedAssetUserData { get { return new Array<AssetUserData>(this[nameof(GeneratedAssetUserData)].Address); } }
    }
    public class HoudiniSplineComponentInstanceData : ActorComponentInstanceData
    {
        public HoudiniSplineComponentInstanceData(nint addr) : base(addr) { }
        public Array<Transform> CurvePoints { get { return new Array<Transform>(this[nameof(CurvePoints)].Address); } }
        public Array<Vector> DisplayPoints { get { return new Array<Vector>(this[nameof(DisplayPoints)].Address); } }
        public Array<int> DisplayPointIndexDivider { get { return new Array<int>(this[nameof(DisplayPointIndexDivider)].Address); } }
    }
}
