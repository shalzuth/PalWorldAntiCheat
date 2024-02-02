using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.LevelSequenceSDK;
using SDK.Script.CinematicCameraSDK;
namespace SDK.Script.DatasmithContentSDK
{
    public class DatasmithObjectTemplate : Object
    {
        public DatasmithObjectTemplate(nint addr) : base(addr) { }
    }
    public class DatasmithActorTemplate : DatasmithObjectTemplate
    {
        public DatasmithActorTemplate(nint addr) : base(addr) { }
        public Object Layers { get { return this[nameof(Layers)]; } set { this[nameof(Layers)] = value; } }
        public Object Tags { get { return this[nameof(Tags)]; } set { this[nameof(Tags)] = value; } }
    }
    public class DatasmithAdditionalData : Object
    {
        public DatasmithAdditionalData(nint addr) : base(addr) { }
    }
    public class DatasmithAreaLightActor : Actor
    {
        public DatasmithAreaLightActor(nint addr) : base(addr) { }
        public byte Mobility { get { return this[nameof(Mobility)].GetValue<byte>(); } set { this[nameof(Mobility)].SetValue<byte>(value); } }
        public EDatasmithAreaLightActorType LightType { get { return (EDatasmithAreaLightActorType)this[nameof(LightType)].GetValue<int>(); } set { this[nameof(LightType)].SetValue<int>((int)value); } }
        public EDatasmithAreaLightActorShape LightShape { get { return (EDatasmithAreaLightActorShape)this[nameof(LightShape)].GetValue<int>(); } set { this[nameof(LightShape)].SetValue<int>((int)value); } }
        public Vector2D Dimensions { get { return this[nameof(Dimensions)].As<Vector2D>(); } set { this["Dimensions"] = value; } }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public ELightUnits IntensityUnits { get { return (ELightUnits)this[nameof(IntensityUnits)].GetValue<int>(); } set { this[nameof(IntensityUnits)].SetValue<int>((int)value); } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public TextureLightProfile IESTexture { get { return this[nameof(IESTexture)].As<TextureLightProfile>(); } set { this["IESTexture"] = value; } }
        public bool bUseIESBrightness { get { return this[nameof(bUseIESBrightness)].Flag; } set { this[nameof(bUseIESBrightness)].Flag = value; } }
        public float IESBrightnessScale { get { return this[nameof(IESBrightnessScale)].GetValue<float>(); } set { this[nameof(IESBrightnessScale)].SetValue<float>(value); } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public float SourceRadius { get { return this[nameof(SourceRadius)].GetValue<float>(); } set { this[nameof(SourceRadius)].SetValue<float>(value); } }
        public float SourceLength { get { return this[nameof(SourceLength)].GetValue<float>(); } set { this[nameof(SourceLength)].SetValue<float>(value); } }
        public float AttenuationRadius { get { return this[nameof(AttenuationRadius)].GetValue<float>(); } set { this[nameof(AttenuationRadius)].SetValue<float>(value); } }
        public float SpotlightInnerAngle { get { return this[nameof(SpotlightInnerAngle)].GetValue<float>(); } set { this[nameof(SpotlightInnerAngle)].SetValue<float>(value); } }
        public float SpotlightOuterAngle { get { return this[nameof(SpotlightOuterAngle)].GetValue<float>(); } set { this[nameof(SpotlightOuterAngle)].SetValue<float>(value); } }
    }
    public class DatasmithAreaLightActorTemplate : DatasmithObjectTemplate
    {
        public DatasmithAreaLightActorTemplate(nint addr) : base(addr) { }
        public EDatasmithAreaLightActorType LightType { get { return (EDatasmithAreaLightActorType)this[nameof(LightType)].GetValue<int>(); } set { this[nameof(LightType)].SetValue<int>((int)value); } }
        public EDatasmithAreaLightActorShape LightShape { get { return (EDatasmithAreaLightActorShape)this[nameof(LightShape)].GetValue<int>(); } set { this[nameof(LightShape)].SetValue<int>((int)value); } }
        public Vector2D Dimensions { get { return this[nameof(Dimensions)].As<Vector2D>(); } set { this["Dimensions"] = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public ELightUnits IntensityUnits { get { return (ELightUnits)this[nameof(IntensityUnits)].GetValue<int>(); } set { this[nameof(IntensityUnits)].SetValue<int>((int)value); } }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public Object IESTexture { get { return this[nameof(IESTexture)]; } set { this[nameof(IESTexture)] = value; } }
        public bool bUseIESBrightness { get { return this[nameof(bUseIESBrightness)].Flag; } set { this[nameof(bUseIESBrightness)].Flag = value; } }
        public float IESBrightnessScale { get { return this[nameof(IESBrightnessScale)].GetValue<float>(); } set { this[nameof(IESBrightnessScale)].SetValue<float>(value); } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public float SourceRadius { get { return this[nameof(SourceRadius)].GetValue<float>(); } set { this[nameof(SourceRadius)].SetValue<float>(value); } }
        public float SourceLength { get { return this[nameof(SourceLength)].GetValue<float>(); } set { this[nameof(SourceLength)].SetValue<float>(value); } }
        public float AttenuationRadius { get { return this[nameof(AttenuationRadius)].GetValue<float>(); } set { this[nameof(AttenuationRadius)].SetValue<float>(value); } }
    }
    public class DatasmithAssetImportData : AssetImportData
    {
        public DatasmithAssetImportData(nint addr) : base(addr) { }
    }
    public class DatasmithStaticMeshImportData : DatasmithAssetImportData
    {
        public DatasmithStaticMeshImportData(nint addr) : base(addr) { }
    }
    public class DatasmithStaticMeshCADImportData : DatasmithStaticMeshImportData
    {
        public DatasmithStaticMeshCADImportData(nint addr) : base(addr) { }
    }
    public class DatasmithSceneImportData : AssetImportData
    {
        public DatasmithSceneImportData(nint addr) : base(addr) { }
    }
    public class DatasmithTranslatedSceneImportData : DatasmithSceneImportData
    {
        public DatasmithTranslatedSceneImportData(nint addr) : base(addr) { }
    }
    public class DatasmithCADImportSceneData : DatasmithSceneImportData
    {
        public DatasmithCADImportSceneData(nint addr) : base(addr) { }
    }
    public class DatasmithMDLSceneImportData : DatasmithSceneImportData
    {
        public DatasmithMDLSceneImportData(nint addr) : base(addr) { }
    }
    public class DatasmithGLTFSceneImportData : DatasmithSceneImportData
    {
        public DatasmithGLTFSceneImportData(nint addr) : base(addr) { }
        public Object Generator { get { return this[nameof(Generator)]; } set { this[nameof(Generator)] = value; } }
        public float Version { get { return this[nameof(Version)].GetValue<float>(); } set { this[nameof(Version)].SetValue<float>(value); } }
        public Object Author { get { return this[nameof(Author)]; } set { this[nameof(Author)] = value; } }
        public Object License { get { return this[nameof(License)]; } set { this[nameof(License)] = value; } }
        public Object Source { get { return this[nameof(Source)]; } set { this[nameof(Source)] = value; } }
    }
    public class DatasmithStaticMeshGLTFImportData : DatasmithStaticMeshImportData
    {
        public DatasmithStaticMeshGLTFImportData(nint addr) : base(addr) { }
        public Object SourceMeshName { get { return this[nameof(SourceMeshName)]; } set { this[nameof(SourceMeshName)] = value; } }
    }
    public class DatasmithFBXSceneImportData : DatasmithSceneImportData
    {
        public DatasmithFBXSceneImportData(nint addr) : base(addr) { }
        public bool bGenerateLightmapUVs { get { return this[nameof(bGenerateLightmapUVs)].Flag; } set { this[nameof(bGenerateLightmapUVs)].Flag = value; } }
        public Object TexturesDir { get { return this[nameof(TexturesDir)]; } set { this[nameof(TexturesDir)] = value; } }
        public byte IntermediateSerialization { get { return this[nameof(IntermediateSerialization)].GetValue<byte>(); } set { this[nameof(IntermediateSerialization)].SetValue<byte>(value); } }
        public bool bColorizeMaterials { get { return this[nameof(bColorizeMaterials)].Flag; } set { this[nameof(bColorizeMaterials)].Flag = value; } }
    }
    public class DatasmithDeltaGenAssetImportData : DatasmithAssetImportData
    {
        public DatasmithDeltaGenAssetImportData(nint addr) : base(addr) { }
    }
    public class DatasmithDeltaGenSceneImportData : DatasmithFBXSceneImportData
    {
        public DatasmithDeltaGenSceneImportData(nint addr) : base(addr) { }
        public bool bMergeNodes { get { return this[nameof(bMergeNodes)].Flag; } set { this[nameof(bMergeNodes)].Flag = value; } }
        public bool bOptimizeDuplicatedNodes { get { return this[nameof(bOptimizeDuplicatedNodes)].Flag; } set { this[nameof(bOptimizeDuplicatedNodes)].Flag = value; } }
        public bool bRemoveInvisibleNodes { get { return this[nameof(bRemoveInvisibleNodes)].Flag; } set { this[nameof(bRemoveInvisibleNodes)].Flag = value; } }
        public bool bSimplifyNodeHierarchy { get { return this[nameof(bSimplifyNodeHierarchy)].Flag; } set { this[nameof(bSimplifyNodeHierarchy)].Flag = value; } }
        public bool bImportVar { get { return this[nameof(bImportVar)].Flag; } set { this[nameof(bImportVar)].Flag = value; } }
        public Object VarPath { get { return this[nameof(VarPath)]; } set { this[nameof(VarPath)] = value; } }
        public bool bImportPos { get { return this[nameof(bImportPos)].Flag; } set { this[nameof(bImportPos)].Flag = value; } }
        public Object PosPath { get { return this[nameof(PosPath)]; } set { this[nameof(PosPath)] = value; } }
        public bool bImportTml { get { return this[nameof(bImportTml)].Flag; } set { this[nameof(bImportTml)].Flag = value; } }
        public Object TmlPath { get { return this[nameof(TmlPath)]; } set { this[nameof(TmlPath)] = value; } }
    }
    public class DatasmithVREDAssetImportData : DatasmithAssetImportData
    {
        public DatasmithVREDAssetImportData(nint addr) : base(addr) { }
    }
    public class DatasmithVREDSceneImportData : DatasmithFBXSceneImportData
    {
        public DatasmithVREDSceneImportData(nint addr) : base(addr) { }
        public bool bMergeNodes { get { return this[nameof(bMergeNodes)].Flag; } set { this[nameof(bMergeNodes)].Flag = value; } }
        public bool bOptimizeDuplicatedNodes { get { return this[nameof(bOptimizeDuplicatedNodes)].Flag; } set { this[nameof(bOptimizeDuplicatedNodes)].Flag = value; } }
        public bool bImportMats { get { return this[nameof(bImportMats)].Flag; } set { this[nameof(bImportMats)].Flag = value; } }
        public Object MatsPath { get { return this[nameof(MatsPath)]; } set { this[nameof(MatsPath)] = value; } }
        public bool bImportVar { get { return this[nameof(bImportVar)].Flag; } set { this[nameof(bImportVar)].Flag = value; } }
        public bool bCleanVar { get { return this[nameof(bCleanVar)].Flag; } set { this[nameof(bCleanVar)].Flag = value; } }
        public Object VarPath { get { return this[nameof(VarPath)]; } set { this[nameof(VarPath)] = value; } }
        public bool bImportLightInfo { get { return this[nameof(bImportLightInfo)].Flag; } set { this[nameof(bImportLightInfo)].Flag = value; } }
        public Object LightInfoPath { get { return this[nameof(LightInfoPath)]; } set { this[nameof(LightInfoPath)] = value; } }
        public bool bImportClipInfo { get { return this[nameof(bImportClipInfo)].Flag; } set { this[nameof(bImportClipInfo)].Flag = value; } }
        public Object ClipInfoPath { get { return this[nameof(ClipInfoPath)]; } set { this[nameof(ClipInfoPath)] = value; } }
    }
    public class DatasmithIFCSceneImportData : DatasmithSceneImportData
    {
        public DatasmithIFCSceneImportData(nint addr) : base(addr) { }
    }
    public class DatasmithStaticMeshIFCImportData : DatasmithStaticMeshImportData
    {
        public DatasmithStaticMeshIFCImportData(nint addr) : base(addr) { }
        public Object SourceGlobalId { get { return this[nameof(SourceGlobalId)]; } set { this[nameof(SourceGlobalId)] = value; } }
    }
    public class DatasmithAssetUserData : AssetUserData
    {
        public DatasmithAssetUserData(nint addr) : base(addr) { }
        public Object MetaData { get { return this[nameof(MetaData)]; } set { this[nameof(MetaData)] = value; } }
    }
    public class DatasmithCineCameraActorTemplate : DatasmithObjectTemplate
    {
        public DatasmithCineCameraActorTemplate(nint addr) : base(addr) { }
        public DatasmithCameraLookatTrackingSettingsTemplate LookatTrackingSettings { get { return this[nameof(LookatTrackingSettings)].As<DatasmithCameraLookatTrackingSettingsTemplate>(); } set { this["LookatTrackingSettings"] = value; } }
    }
    public class DatasmithCineCameraComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithCineCameraComponentTemplate(nint addr) : base(addr) { }
        public DatasmithCameraFilmbackSettingsTemplate FilmbackSettings { get { return this[nameof(FilmbackSettings)].As<DatasmithCameraFilmbackSettingsTemplate>(); } set { this["FilmbackSettings"] = value; } }
        public DatasmithCameraLensSettingsTemplate LensSettings { get { return this[nameof(LensSettings)].As<DatasmithCameraLensSettingsTemplate>(); } set { this["LensSettings"] = value; } }
        public DatasmithCameraFocusSettingsTemplate FocusSettings { get { return this[nameof(FocusSettings)].As<DatasmithCameraFocusSettingsTemplate>(); } set { this["FocusSettings"] = value; } }
        public float CurrentFocalLength { get { return this[nameof(CurrentFocalLength)].GetValue<float>(); } set { this[nameof(CurrentFocalLength)].SetValue<float>(value); } }
        public float CurrentAperture { get { return this[nameof(CurrentAperture)].GetValue<float>(); } set { this[nameof(CurrentAperture)].SetValue<float>(value); } }
        public DatasmithPostProcessSettingsTemplate PostProcessSettings { get { return this[nameof(PostProcessSettings)].As<DatasmithPostProcessSettingsTemplate>(); } set { this["PostProcessSettings"] = value; } }
    }
    public class DatasmithContentBlueprintLibrary : BlueprintFunctionLibrary
    {
        public DatasmithContentBlueprintLibrary(nint addr) : base(addr) { }
        public Array<Object> GetDatasmithUserDataValuesForKey(Object Object, Object Key, bool bPartialMatchKey) { return Invoke<Array<Object>>(nameof(GetDatasmithUserDataValuesForKey), Object, Key, bPartialMatchKey); }
        public Object GetDatasmithUserDataValueForKey(Object Object, Object Key, bool bPartialMatchKey) { return Invoke<Object>(nameof(GetDatasmithUserDataValueForKey), Object, Key, bPartialMatchKey); }
        public void GetDatasmithUserDataKeysAndValuesForValue(Object Object, Object StringToMatch, Array<Object> OutKeys, Array<Object> OutValues) { Invoke(nameof(GetDatasmithUserDataKeysAndValuesForValue), Object, StringToMatch, OutKeys, OutValues); }
        public DatasmithAssetUserData GetDatasmithUserData(Object Object) { return Invoke<DatasmithAssetUserData>(nameof(GetDatasmithUserData), Object); }
    }
    public class DatasmithCustomActionBase : Object
    {
        public DatasmithCustomActionBase(nint addr) : base(addr) { }
    }
    public class DatasmithDecalComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithDecalComponentTemplate(nint addr) : base(addr) { }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public Vector DecalSize { get { return this[nameof(DecalSize)].As<Vector>(); } set { this["DecalSize"] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
    }
    public class DatasmithImportedSequencesActor : Actor
    {
        public DatasmithImportedSequencesActor(nint addr) : base(addr) { }
        public Array<LevelSequence> ImportedSequences { get { return new Array<LevelSequence>(this[nameof(ImportedSequences)].Address); } }
        public void PlayLevelSequence(LevelSequence SequenceToPlay) { Invoke(nameof(PlayLevelSequence), SequenceToPlay); }
    }
    public class DatasmithOptionsBase : Object
    {
        public DatasmithOptionsBase(nint addr) : base(addr) { }
    }
    public class DatasmithCommonTessellationOptions : DatasmithOptionsBase
    {
        public DatasmithCommonTessellationOptions(nint addr) : base(addr) { }
        public DatasmithTessellationOptions Options { get { return this[nameof(Options)].As<DatasmithTessellationOptions>(); } set { this["Options"] = value; } }
    }
    public class DatasmithImportOptions : DatasmithOptionsBase
    {
        public DatasmithImportOptions(nint addr) : base(addr) { }
        public EDatasmithImportSearchPackagePolicy SearchPackagePolicy { get { return (EDatasmithImportSearchPackagePolicy)this[nameof(SearchPackagePolicy)].GetValue<int>(); } set { this[nameof(SearchPackagePolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportAssetConflictPolicy MaterialConflictPolicy { get { return (EDatasmithImportAssetConflictPolicy)this[nameof(MaterialConflictPolicy)].GetValue<int>(); } set { this[nameof(MaterialConflictPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportAssetConflictPolicy TextureConflictPolicy { get { return (EDatasmithImportAssetConflictPolicy)this[nameof(TextureConflictPolicy)].GetValue<int>(); } set { this[nameof(TextureConflictPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportActorPolicy StaticMeshActorImportPolicy { get { return (EDatasmithImportActorPolicy)this[nameof(StaticMeshActorImportPolicy)].GetValue<int>(); } set { this[nameof(StaticMeshActorImportPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportActorPolicy LightImportPolicy { get { return (EDatasmithImportActorPolicy)this[nameof(LightImportPolicy)].GetValue<int>(); } set { this[nameof(LightImportPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportActorPolicy CameraImportPolicy { get { return (EDatasmithImportActorPolicy)this[nameof(CameraImportPolicy)].GetValue<int>(); } set { this[nameof(CameraImportPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportActorPolicy OtherActorImportPolicy { get { return (EDatasmithImportActorPolicy)this[nameof(OtherActorImportPolicy)].GetValue<int>(); } set { this[nameof(OtherActorImportPolicy)].SetValue<int>((int)value); } }
        public EDatasmithImportMaterialQuality MaterialQuality { get { return (EDatasmithImportMaterialQuality)this[nameof(MaterialQuality)].GetValue<int>(); } set { this[nameof(MaterialQuality)].SetValue<int>((int)value); } }
        public DatasmithImportBaseOptions BaseOptions { get { return this[nameof(BaseOptions)].As<DatasmithImportBaseOptions>(); } set { this["BaseOptions"] = value; } }
        public DatasmithReimportOptions ReimportOptions { get { return this[nameof(ReimportOptions)].As<DatasmithReimportOptions>(); } set { this["ReimportOptions"] = value; } }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public Object FilePath { get { return this[nameof(FilePath)]; } set { this[nameof(FilePath)] = value; } }
        public Object SourceUri { get { return this[nameof(SourceUri)]; } set { this[nameof(SourceUri)] = value; } }
    }
    public class DatasmithLandscapeTemplate : DatasmithObjectTemplate
    {
        public DatasmithLandscapeTemplate(nint addr) : base(addr) { }
        public MaterialInterface LandscapeMaterial { get { return this[nameof(LandscapeMaterial)].As<MaterialInterface>(); } set { this["LandscapeMaterial"] = value; } }
        public int StaticLightingLOD { get { return this[nameof(StaticLightingLOD)].GetValue<int>(); } set { this[nameof(StaticLightingLOD)].SetValue<int>(value); } }
    }
    public class DatasmithLightComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithLightComponentTemplate(nint addr) : base(addr) { }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool CastShadows { get { return this[nameof(CastShadows)].Flag; } set { this[nameof(CastShadows)].Flag = value; } }
        public bool bUseTemperature { get { return this[nameof(bUseTemperature)].Flag; } set { this[nameof(bUseTemperature)].Flag = value; } }
        public bool bUseIESBrightness { get { return this[nameof(bUseIESBrightness)].Flag; } set { this[nameof(bUseIESBrightness)].Flag = value; } }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
        public float Temperature { get { return this[nameof(Temperature)].GetValue<float>(); } set { this[nameof(Temperature)].SetValue<float>(value); } }
        public float IESBrightnessScale { get { return this[nameof(IESBrightnessScale)].GetValue<float>(); } set { this[nameof(IESBrightnessScale)].SetValue<float>(value); } }
        public LinearColor LightColor { get { return this[nameof(LightColor)].As<LinearColor>(); } set { this["LightColor"] = value; } }
        public MaterialInterface LightFunctionMaterial { get { return this[nameof(LightFunctionMaterial)].As<MaterialInterface>(); } set { this["LightFunctionMaterial"] = value; } }
        public TextureLightProfile IESTexture { get { return this[nameof(IESTexture)].As<TextureLightProfile>(); } set { this["IESTexture"] = value; } }
    }
    public class DatasmithMaterialInstanceTemplate : DatasmithObjectTemplate
    {
        public DatasmithMaterialInstanceTemplate(nint addr) : base(addr) { }
        public Object ParentMaterial { get { return this[nameof(ParentMaterial)]; } set { this[nameof(ParentMaterial)] = value; } }
        public Object ScalarParameterValues { get { return this[nameof(ScalarParameterValues)]; } set { this[nameof(ScalarParameterValues)] = value; } }
        public Object VectorParameterValues { get { return this[nameof(VectorParameterValues)]; } set { this[nameof(VectorParameterValues)] = value; } }
        public Object TextureParameterValues { get { return this[nameof(TextureParameterValues)]; } set { this[nameof(TextureParameterValues)] = value; } }
        public DatasmithStaticParameterSetTemplate StaticParameters { get { return this[nameof(StaticParameters)].As<DatasmithStaticParameterSetTemplate>(); } set { this["StaticParameters"] = value; } }
    }
    public class DatasmithPointLightComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithPointLightComponentTemplate(nint addr) : base(addr) { }
        public ELightUnits IntensityUnits { get { return (ELightUnits)this[nameof(IntensityUnits)].GetValue<int>(); } set { this[nameof(IntensityUnits)].SetValue<int>((int)value); } }
        public float SourceRadius { get { return this[nameof(SourceRadius)].GetValue<float>(); } set { this[nameof(SourceRadius)].SetValue<float>(value); } }
        public float SourceLength { get { return this[nameof(SourceLength)].GetValue<float>(); } set { this[nameof(SourceLength)].SetValue<float>(value); } }
        public float AttenuationRadius { get { return this[nameof(AttenuationRadius)].GetValue<float>(); } set { this[nameof(AttenuationRadius)].SetValue<float>(value); } }
    }
    public class DatasmithPostProcessVolumeTemplate : DatasmithObjectTemplate
    {
        public DatasmithPostProcessVolumeTemplate(nint addr) : base(addr) { }
        public DatasmithPostProcessSettingsTemplate Settings { get { return this[nameof(Settings)].As<DatasmithPostProcessSettingsTemplate>(); } set { this["Settings"] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool bUnbound { get { return this[nameof(bUnbound)].Flag; } set { this[nameof(bUnbound)].Flag = value; } }
    }
    public class DatasmithScene : Object
    {
        public DatasmithScene(nint addr) : base(addr) { }
    }
    public class DatasmithSceneActor : Actor
    {
        public DatasmithSceneActor(nint addr) : base(addr) { }
        public DatasmithScene Scene { get { return this[nameof(Scene)].As<DatasmithScene>(); } set { this["Scene"] = value; } }
        public Object RelatedActors { get { return this[nameof(RelatedActors)]; } set { this[nameof(RelatedActors)] = value; } }
    }
    public class DatasmithSceneComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithSceneComponentTemplate(nint addr) : base(addr) { }
        public Transform RelativeTransform { get { return this[nameof(RelativeTransform)].As<Transform>(); } set { this["RelativeTransform"] = value; } }
        public byte Mobility { get { return this[nameof(Mobility)].GetValue<byte>(); } set { this[nameof(Mobility)].SetValue<byte>(value); } }
        public Object AttachParent { get { return this[nameof(AttachParent)]; } set { this[nameof(AttachParent)] = value; } }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool bCastShadow { get { return this[nameof(bCastShadow)].Flag; } set { this[nameof(bCastShadow)].Flag = value; } }
        public Object Tags { get { return this[nameof(Tags)]; } set { this[nameof(Tags)] = value; } }
    }
    public class DatasmithSkyLightComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithSkyLightComponentTemplate(nint addr) : base(addr) { }
        public byte SourceType { get { return this[nameof(SourceType)].GetValue<byte>(); } set { this[nameof(SourceType)].SetValue<byte>(value); } }
        public int CubemapResolution { get { return this[nameof(CubemapResolution)].GetValue<int>(); } set { this[nameof(CubemapResolution)].SetValue<int>(value); } }
        public TextureCube Cubemap { get { return this[nameof(Cubemap)].As<TextureCube>(); } set { this["Cubemap"] = value; } }
    }
    public class DatasmithSpotLightComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithSpotLightComponentTemplate(nint addr) : base(addr) { }
        public float InnerConeAngle { get { return this[nameof(InnerConeAngle)].GetValue<float>(); } set { this[nameof(InnerConeAngle)].SetValue<float>(value); } }
        public float OuterConeAngle { get { return this[nameof(OuterConeAngle)].GetValue<float>(); } set { this[nameof(OuterConeAngle)].SetValue<float>(value); } }
    }
    public class DatasmithStaticMeshComponentTemplate : DatasmithObjectTemplate
    {
        public DatasmithStaticMeshComponentTemplate(nint addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public Array<MaterialInterface> OverrideMaterials { get { return new Array<MaterialInterface>(this[nameof(OverrideMaterials)].Address); } }
    }
    public class DatasmithStaticMeshTemplate : DatasmithObjectTemplate
    {
        public DatasmithStaticMeshTemplate(nint addr) : base(addr) { }
        public DatasmithMeshSectionInfoMapTemplate SectionInfoMap { get { return this[nameof(SectionInfoMap)].As<DatasmithMeshSectionInfoMapTemplate>(); } set { this["SectionInfoMap"] = value; } }
        public int LightMapCoordinateIndex { get { return this[nameof(LightMapCoordinateIndex)].GetValue<int>(); } set { this[nameof(LightMapCoordinateIndex)].SetValue<int>(value); } }
        public int LightMapResolution { get { return this[nameof(LightMapResolution)].GetValue<int>(); } set { this[nameof(LightMapResolution)].SetValue<int>(value); } }
        public Array<DatasmithMeshBuildSettingsTemplate> BuildSettings { get { return new Array<DatasmithMeshBuildSettingsTemplate>(this[nameof(BuildSettings)].Address); } }
        public Array<DatasmithStaticMaterialTemplate> StaticMaterials { get { return new Array<DatasmithStaticMaterialTemplate>(this[nameof(StaticMaterials)].Address); } }
    }
    public enum EDatasmithAreaLightActorShape : int
    {
        Rectangle = 0,
        Disc = 1,
        Sphere = 2,
        Cylinder = 3,
        None = 4,
        EDatasmithAreaLightActorShape_MAX = 5,
    }
    public enum EDatasmithAreaLightActorType : int
    {
        Point = 0,
        Spot = 1,
        Rect = 2,
        EDatasmithAreaLightActorType_MAX = 3,
    }
    public enum EDatasmithImportSearchPackagePolicy : int
    {
        Current = 0,
        All = 1,
        EDatasmithImportSearchPackagePolicy_MAX = 2,
    }
    public enum EDatasmithImportAssetConflictPolicy : int
    {
        Replace = 0,
        Update = 1,
        Use = 2,
        Ignore = 3,
        EDatasmithImportAssetConflictPolicy_MAX = 4,
    }
    public enum EDatasmithImportActorPolicy : int
    {
        Update = 0,
        Full = 1,
        Ignore = 2,
        EDatasmithImportActorPolicy_MAX = 3,
    }
    public enum EDatasmithImportMaterialQuality : int
    {
        UseNoFresnelCurves = 0,
        UseSimplifierFresnelCurves = 1,
        UseRealFresnelCurves = 2,
        EDatasmithImportMaterialQuality_MAX = 3,
    }
    public enum EDatasmithImportLightmapMin : int
    {
        LIGHTMAP_17 = 0,
        LIGHTMAP_33 = 1,
        LIGHTMAP_65 = 2,
        LIGHTMAP_129 = 3,
        LIGHTMAP_257 = 4,
        LIGHTMAP_513 = 5,
        LIGHTMAP_MAX = 6,
    }
    public enum EDatasmithImportLightmapMax : int
    {
        LIGHTMAP_65 = 0,
        LIGHTMAP_129 = 1,
        LIGHTMAP_257 = 2,
        LIGHTMAP_513 = 3,
        LIGHTMAP_1025 = 4,
        LIGHTMAP_2049 = 5,
        LIGHTMAP_4097 = 6,
        LIGHTMAP_MAX = 7,
    }
    public enum EDatasmithImportScene : int
    {
        NewLevel = 0,
        CurrentLevel = 1,
        AssetsOnly = 2,
        EDatasmithImportScene_MAX = 3,
    }
    public enum EDatasmithCADStitchingTechnique : int
    {
        StitchingNone = 0,
        StitchingHeal = 1,
        StitchingSew = 2,
        EDatasmithCADStitchingTechnique_MAX = 3,
    }
    public enum EDatasmithCADRetessellationRule : int
    {
        All = 0,
        SkipDeletedSurfaces = 1,
        EDatasmithCADRetessellationRule_MAX = 2,
    }
    public class DatasmithImportInfo : Object
    {
        public DatasmithImportInfo(nint addr) : base(addr) { }
    }
    public class DatasmithCameraLookatTrackingSettingsTemplate : Object
    {
        public DatasmithCameraLookatTrackingSettingsTemplate(nint addr) : base(addr) { }
        public bool bEnableLookAtTracking { get { return this[nameof(bEnableLookAtTracking)].Flag; } set { this[nameof(bEnableLookAtTracking)].Flag = value; } }
        public bool bAllowRoll { get { return this[nameof(bAllowRoll)].Flag; } set { this[nameof(bAllowRoll)].Flag = value; } }
        public Object ActorToTrack { get { return this[nameof(ActorToTrack)]; } set { this[nameof(ActorToTrack)] = value; } }
    }
    public class DatasmithCameraFilmbackSettingsTemplate : Object
    {
        public DatasmithCameraFilmbackSettingsTemplate(nint addr) : base(addr) { }
        public float SensorWidth { get { return this[nameof(SensorWidth)].GetValue<float>(); } set { this[nameof(SensorWidth)].SetValue<float>(value); } }
        public float SensorHeight { get { return this[nameof(SensorHeight)].GetValue<float>(); } set { this[nameof(SensorHeight)].SetValue<float>(value); } }
    }
    public class DatasmithCameraLensSettingsTemplate : Object
    {
        public DatasmithCameraLensSettingsTemplate(nint addr) : base(addr) { }
        public float MaxFStop { get { return this[nameof(MaxFStop)].GetValue<float>(); } set { this[nameof(MaxFStop)].SetValue<float>(value); } }
    }
    public class DatasmithCameraFocusSettingsTemplate : Object
    {
        public DatasmithCameraFocusSettingsTemplate(nint addr) : base(addr) { }
        public ECameraFocusMethod FocusMethod { get { return (ECameraFocusMethod)this[nameof(FocusMethod)].GetValue<int>(); } set { this[nameof(FocusMethod)].SetValue<int>((int)value); } }
        public float ManualFocusDistance { get { return this[nameof(ManualFocusDistance)].GetValue<float>(); } set { this[nameof(ManualFocusDistance)].SetValue<float>(value); } }
    }
    public class DatasmithPostProcessSettingsTemplate : Object
    {
        public DatasmithPostProcessSettingsTemplate(nint addr) : base(addr) { }
        public bool bOverride_WhiteTemp { get { return this[nameof(bOverride_WhiteTemp)].Flag; } set { this[nameof(bOverride_WhiteTemp)].Flag = value; } }
        public bool bOverride_ColorSaturation { get { return this[nameof(bOverride_ColorSaturation)].Flag; } set { this[nameof(bOverride_ColorSaturation)].Flag = value; } }
        public bool bOverride_VignetteIntensity { get { return this[nameof(bOverride_VignetteIntensity)].Flag; } set { this[nameof(bOverride_VignetteIntensity)].Flag = value; } }
        public bool bOverride_AutoExposureMethod { get { return this[nameof(bOverride_AutoExposureMethod)].Flag; } set { this[nameof(bOverride_AutoExposureMethod)].Flag = value; } }
        public bool bOverride_CameraISO { get { return this[nameof(bOverride_CameraISO)].Flag; } set { this[nameof(bOverride_CameraISO)].Flag = value; } }
        public bool bOverride_CameraShutterSpeed { get { return this[nameof(bOverride_CameraShutterSpeed)].Flag; } set { this[nameof(bOverride_CameraShutterSpeed)].Flag = value; } }
        public bool bOverride_DepthOfFieldFstop { get { return this[nameof(bOverride_DepthOfFieldFstop)].Flag; } set { this[nameof(bOverride_DepthOfFieldFstop)].Flag = value; } }
        public float WhiteTemp { get { return this[nameof(WhiteTemp)].GetValue<float>(); } set { this[nameof(WhiteTemp)].SetValue<float>(value); } }
        public float VignetteIntensity { get { return this[nameof(VignetteIntensity)].GetValue<float>(); } set { this[nameof(VignetteIntensity)].SetValue<float>(value); } }
        public Vector4 ColorSaturation { get { return this[nameof(ColorSaturation)].As<Vector4>(); } set { this["ColorSaturation"] = value; } }
        public byte AutoExposureMethod { get { return this[nameof(AutoExposureMethod)].GetValue<byte>(); } set { this[nameof(AutoExposureMethod)].SetValue<byte>(value); } }
        public float CameraISO { get { return this[nameof(CameraISO)].GetValue<float>(); } set { this[nameof(CameraISO)].SetValue<float>(value); } }
        public float CameraShutterSpeed { get { return this[nameof(CameraShutterSpeed)].GetValue<float>(); } set { this[nameof(CameraShutterSpeed)].SetValue<float>(value); } }
        public float DepthOfFieldFstop { get { return this[nameof(DepthOfFieldFstop)].GetValue<float>(); } set { this[nameof(DepthOfFieldFstop)].SetValue<float>(value); } }
    }
    public class DatasmithAssetImportOptions : Object
    {
        public DatasmithAssetImportOptions(nint addr) : base(addr) { }
        public Object PackagePath { get { return this[nameof(PackagePath)]; } set { this[nameof(PackagePath)] = value; } }
    }
    public class DatasmithStaticMeshImportOptions : Object
    {
        public DatasmithStaticMeshImportOptions(nint addr) : base(addr) { }
        public EDatasmithImportLightmapMin MinLightmapResolution { get { return (EDatasmithImportLightmapMin)this[nameof(MinLightmapResolution)].GetValue<int>(); } set { this[nameof(MinLightmapResolution)].SetValue<int>((int)value); } }
        public EDatasmithImportLightmapMax MaxLightmapResolution { get { return (EDatasmithImportLightmapMax)this[nameof(MaxLightmapResolution)].GetValue<int>(); } set { this[nameof(MaxLightmapResolution)].SetValue<int>((int)value); } }
        public bool bGenerateLightmapUVs { get { return this[nameof(bGenerateLightmapUVs)].Flag; } set { this[nameof(bGenerateLightmapUVs)].Flag = value; } }
        public bool bRemoveDegenerates { get { return this[nameof(bRemoveDegenerates)].Flag; } set { this[nameof(bRemoveDegenerates)].Flag = value; } }
    }
    public class DatasmithReimportOptions : Object
    {
        public DatasmithReimportOptions(nint addr) : base(addr) { }
        public bool bUpdateActors { get { return this[nameof(bUpdateActors)].Flag; } set { this[nameof(bUpdateActors)].Flag = value; } }
        public bool bRespawnDeletedActors { get { return this[nameof(bRespawnDeletedActors)].Flag; } set { this[nameof(bRespawnDeletedActors)].Flag = value; } }
    }
    public class DatasmithImportBaseOptions : Object
    {
        public DatasmithImportBaseOptions(nint addr) : base(addr) { }
        public EDatasmithImportScene SceneHandling { get { return (EDatasmithImportScene)this[nameof(SceneHandling)].GetValue<int>(); } set { this[nameof(SceneHandling)].SetValue<int>((int)value); } }
        public bool bIncludeGeometry { get { return this[nameof(bIncludeGeometry)].Flag; } set { this[nameof(bIncludeGeometry)].Flag = value; } }
        public bool bIncludeMaterial { get { return this[nameof(bIncludeMaterial)].Flag; } set { this[nameof(bIncludeMaterial)].Flag = value; } }
        public bool bIncludeLight { get { return this[nameof(bIncludeLight)].Flag; } set { this[nameof(bIncludeLight)].Flag = value; } }
        public bool bIncludeCamera { get { return this[nameof(bIncludeCamera)].Flag; } set { this[nameof(bIncludeCamera)].Flag = value; } }
        public bool bIncludeAnimation { get { return this[nameof(bIncludeAnimation)].Flag; } set { this[nameof(bIncludeAnimation)].Flag = value; } }
        public DatasmithAssetImportOptions AssetOptions { get { return this[nameof(AssetOptions)].As<DatasmithAssetImportOptions>(); } set { this["AssetOptions"] = value; } }
        public DatasmithStaticMeshImportOptions StaticMeshOptions { get { return this[nameof(StaticMeshOptions)].As<DatasmithStaticMeshImportOptions>(); } set { this["StaticMeshOptions"] = value; } }
    }
    public class DatasmithTessellationOptions : Object
    {
        public DatasmithTessellationOptions(nint addr) : base(addr) { }
        public float ChordTolerance { get { return this[nameof(ChordTolerance)].GetValue<float>(); } set { this[nameof(ChordTolerance)].SetValue<float>(value); } }
        public float MaxEdgeLength { get { return this[nameof(MaxEdgeLength)].GetValue<float>(); } set { this[nameof(MaxEdgeLength)].SetValue<float>(value); } }
        public float NormalTolerance { get { return this[nameof(NormalTolerance)].GetValue<float>(); } set { this[nameof(NormalTolerance)].SetValue<float>(value); } }
        public EDatasmithCADStitchingTechnique StitchingTechnique { get { return (EDatasmithCADStitchingTechnique)this[nameof(StitchingTechnique)].GetValue<int>(); } set { this[nameof(StitchingTechnique)].SetValue<int>((int)value); } }
    }
    public class DatasmithRetessellationOptions : DatasmithTessellationOptions
    {
        public DatasmithRetessellationOptions(nint addr) : base(addr) { }
        public EDatasmithCADRetessellationRule RetessellationRule { get { return (EDatasmithCADRetessellationRule)this[nameof(RetessellationRule)].GetValue<int>(); } set { this[nameof(RetessellationRule)].SetValue<int>((int)value); } }
    }
    public class DatasmithStaticParameterSetTemplate : Object
    {
        public DatasmithStaticParameterSetTemplate(nint addr) : base(addr) { }
        public Object StaticSwitchParameters { get { return this[nameof(StaticSwitchParameters)]; } set { this[nameof(StaticSwitchParameters)] = value; } }
    }
    public class DatasmithMeshBuildSettingsTemplate : Object
    {
        public DatasmithMeshBuildSettingsTemplate(nint addr) : base(addr) { }
        public bool bUseMikkTSpace { get { return this[nameof(bUseMikkTSpace)].Flag; } set { this[nameof(bUseMikkTSpace)].Flag = value; } }
        public bool bRecomputeNormals { get { return this[nameof(bRecomputeNormals)].Flag; } set { this[nameof(bRecomputeNormals)].Flag = value; } }
        public bool bRecomputeTangents { get { return this[nameof(bRecomputeTangents)].Flag; } set { this[nameof(bRecomputeTangents)].Flag = value; } }
        public bool bRemoveDegenerates { get { return this[nameof(bRemoveDegenerates)].Flag; } set { this[nameof(bRemoveDegenerates)].Flag = value; } }
        public bool bUseHighPrecisionTangentBasis { get { return this[nameof(bUseHighPrecisionTangentBasis)].Flag; } set { this[nameof(bUseHighPrecisionTangentBasis)].Flag = value; } }
        public bool bUseFullPrecisionUVs { get { return this[nameof(bUseFullPrecisionUVs)].Flag; } set { this[nameof(bUseFullPrecisionUVs)].Flag = value; } }
        public bool bGenerateLightmapUVs { get { return this[nameof(bGenerateLightmapUVs)].Flag; } set { this[nameof(bGenerateLightmapUVs)].Flag = value; } }
        public int MinLightmapResolution { get { return this[nameof(MinLightmapResolution)].GetValue<int>(); } set { this[nameof(MinLightmapResolution)].SetValue<int>(value); } }
        public int SrcLightmapIndex { get { return this[nameof(SrcLightmapIndex)].GetValue<int>(); } set { this[nameof(SrcLightmapIndex)].SetValue<int>(value); } }
        public int DstLightmapIndex { get { return this[nameof(DstLightmapIndex)].GetValue<int>(); } set { this[nameof(DstLightmapIndex)].SetValue<int>(value); } }
    }
    public class DatasmithStaticMaterialTemplate : Object
    {
        public DatasmithStaticMaterialTemplate(nint addr) : base(addr) { }
        public Object MaterialSlotName { get { return this[nameof(MaterialSlotName)]; } set { this[nameof(MaterialSlotName)] = value; } }
        public MaterialInterface MaterialInterface { get { return this[nameof(MaterialInterface)].As<MaterialInterface>(); } set { this["MaterialInterface"] = value; } }
    }
    public class DatasmithMeshSectionInfoTemplate : Object
    {
        public DatasmithMeshSectionInfoTemplate(nint addr) : base(addr) { }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
    }
    public class DatasmithMeshSectionInfoMapTemplate : Object
    {
        public DatasmithMeshSectionInfoMapTemplate(nint addr) : base(addr) { }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
    }
}
