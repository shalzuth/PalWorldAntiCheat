using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.GLTFExporterSDK
{
    public class GLTFExporter : Exporter
    {
        public GLTFExporter(nint addr) : base(addr) { }
        public bool ExportToGLTF(Object Object, Object FilePath, GLTFExportOptions Options, Object SelectedActors, GLTFExportMessages OutMessages) { return Invoke<bool>(nameof(ExportToGLTF), Object, FilePath, Options, SelectedActors, OutMessages); }
    }
    public class GLTFAnimSequenceExporter : GLTFExporter
    {
        public GLTFAnimSequenceExporter(nint addr) : base(addr) { }
    }
    public class GLTFExportOptions : Object
    {
        public GLTFExportOptions(nint addr) : base(addr) { }
        public float ExportUniformScale { get { return this[nameof(ExportUniformScale)].GetValue<float>(); } set { this[nameof(ExportUniformScale)].SetValue<float>(value); } }
        public bool bExportPreviewMesh { get { return this[nameof(bExportPreviewMesh)].Flag; } set { this[nameof(bExportPreviewMesh)].Flag = value; } }
        public bool bStrictCompliance { get { return this[nameof(bStrictCompliance)].Flag; } set { this[nameof(bStrictCompliance)].Flag = value; } }
        public bool bSkipNearDefaultValues { get { return this[nameof(bSkipNearDefaultValues)].Flag; } set { this[nameof(bSkipNearDefaultValues)].Flag = value; } }
        public bool bIncludeGeneratorVersion { get { return this[nameof(bIncludeGeneratorVersion)].Flag; } set { this[nameof(bIncludeGeneratorVersion)].Flag = value; } }
        public bool bExportProxyMaterials { get { return this[nameof(bExportProxyMaterials)].Flag; } set { this[nameof(bExportProxyMaterials)].Flag = value; } }
        public bool bExportUnlitMaterials { get { return this[nameof(bExportUnlitMaterials)].Flag; } set { this[nameof(bExportUnlitMaterials)].Flag = value; } }
        public bool bExportClearCoatMaterials { get { return this[nameof(bExportClearCoatMaterials)].Flag; } set { this[nameof(bExportClearCoatMaterials)].Flag = value; } }
        public bool bExportExtraBlendModes { get { return this[nameof(bExportExtraBlendModes)].Flag; } set { this[nameof(bExportExtraBlendModes)].Flag = value; } }
        public EGLTFMaterialBakeMode BakeMaterialInputs { get { return (EGLTFMaterialBakeMode)this[nameof(BakeMaterialInputs)].GetValue<int>(); } set { this[nameof(BakeMaterialInputs)].SetValue<int>((int)value); } }
        public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize { get { return (EGLTFMaterialBakeSizePOT)this[nameof(DefaultMaterialBakeSize)].GetValue<int>(); } set { this[nameof(DefaultMaterialBakeSize)].SetValue<int>((int)value); } }
        public byte DefaultMaterialBakeFilter { get { return this[nameof(DefaultMaterialBakeFilter)].GetValue<byte>(); } set { this[nameof(DefaultMaterialBakeFilter)].SetValue<byte>(value); } }
        public byte DefaultMaterialBakeTiling { get { return this[nameof(DefaultMaterialBakeTiling)].GetValue<byte>(); } set { this[nameof(DefaultMaterialBakeTiling)].SetValue<byte>(value); } }
        public Object DefaultInputBakeSettings { get { return this[nameof(DefaultInputBakeSettings)]; } set { this[nameof(DefaultInputBakeSettings)] = value; } }
        public int DefaultLevelOfDetail { get { return this[nameof(DefaultLevelOfDetail)].GetValue<int>(); } set { this[nameof(DefaultLevelOfDetail)].SetValue<int>(value); } }
        public bool bExportVertexColors { get { return this[nameof(bExportVertexColors)].Flag; } set { this[nameof(bExportVertexColors)].Flag = value; } }
        public bool bExportVertexSkinWeights { get { return this[nameof(bExportVertexSkinWeights)].Flag; } set { this[nameof(bExportVertexSkinWeights)].Flag = value; } }
        public bool bUseMeshQuantization { get { return this[nameof(bUseMeshQuantization)].Flag; } set { this[nameof(bUseMeshQuantization)].Flag = value; } }
        public bool bExportLevelSequences { get { return this[nameof(bExportLevelSequences)].Flag; } set { this[nameof(bExportLevelSequences)].Flag = value; } }
        public bool bExportAnimationSequences { get { return this[nameof(bExportAnimationSequences)].Flag; } set { this[nameof(bExportAnimationSequences)].Flag = value; } }
        public bool bExportPlaybackSettings { get { return this[nameof(bExportPlaybackSettings)].Flag; } set { this[nameof(bExportPlaybackSettings)].Flag = value; } }
        public EGLTFTextureImageFormat TextureImageFormat { get { return (EGLTFTextureImageFormat)this[nameof(TextureImageFormat)].GetValue<int>(); } set { this[nameof(TextureImageFormat)].SetValue<int>((int)value); } }
        public int TextureImageQuality { get { return this[nameof(TextureImageQuality)].GetValue<int>(); } set { this[nameof(TextureImageQuality)].SetValue<int>(value); } }
        public int NoLossyImageFormatFor { get { return this[nameof(NoLossyImageFormatFor)].GetValue<int>(); } set { this[nameof(NoLossyImageFormatFor)].SetValue<int>(value); } }
        public bool bExportTextureTransforms { get { return this[nameof(bExportTextureTransforms)].Flag; } set { this[nameof(bExportTextureTransforms)].Flag = value; } }
        public bool bExportLightmaps { get { return this[nameof(bExportLightmaps)].Flag; } set { this[nameof(bExportLightmaps)].Flag = value; } }
        public EGLTFTextureHDREncoding TextureHDREncoding { get { return (EGLTFTextureHDREncoding)this[nameof(TextureHDREncoding)].GetValue<int>(); } set { this[nameof(TextureHDREncoding)].SetValue<int>((int)value); } }
        public bool bAdjustNormalmaps { get { return this[nameof(bAdjustNormalmaps)].Flag; } set { this[nameof(bAdjustNormalmaps)].Flag = value; } }
        public bool bExportHiddenInGame { get { return this[nameof(bExportHiddenInGame)].Flag; } set { this[nameof(bExportHiddenInGame)].Flag = value; } }
        public int ExportLights { get { return this[nameof(ExportLights)].GetValue<int>(); } set { this[nameof(ExportLights)].SetValue<int>(value); } }
        public bool bExportCameras { get { return this[nameof(bExportCameras)].Flag; } set { this[nameof(bExportCameras)].Flag = value; } }
        public bool bExportHDRIBackdrops { get { return this[nameof(bExportHDRIBackdrops)].Flag; } set { this[nameof(bExportHDRIBackdrops)].Flag = value; } }
        public bool bExportSkySpheres { get { return this[nameof(bExportSkySpheres)].Flag; } set { this[nameof(bExportSkySpheres)].Flag = value; } }
        public EGLTFVariantSetsMode VariantSetsMode { get { return (EGLTFVariantSetsMode)this[nameof(VariantSetsMode)].GetValue<int>(); } set { this[nameof(VariantSetsMode)].SetValue<int>((int)value); } }
        public EGLTFMaterialVariantMode ExportMaterialVariants { get { return (EGLTFMaterialVariantMode)this[nameof(ExportMaterialVariants)].GetValue<int>(); } set { this[nameof(ExportMaterialVariants)].SetValue<int>((int)value); } }
        public bool bExportMeshVariants { get { return this[nameof(bExportMeshVariants)].Flag; } set { this[nameof(bExportMeshVariants)].Flag = value; } }
        public bool bExportVisibilityVariants { get { return this[nameof(bExportVisibilityVariants)].Flag; } set { this[nameof(bExportVisibilityVariants)].Flag = value; } }
        public void ResetToDefault() { Invoke(nameof(ResetToDefault)); }
    }
    public class GLTFLevelExporter : GLTFExporter
    {
        public GLTFLevelExporter(nint addr) : base(addr) { }
    }
    public class GLTFLevelSequenceExporter : GLTFExporter
    {
        public GLTFLevelSequenceExporter(nint addr) : base(addr) { }
    }
    public class GLTFLevelVariantSetsExporter : GLTFExporter
    {
        public GLTFLevelVariantSetsExporter(nint addr) : base(addr) { }
    }
    public class GLTFMaterialExporter : GLTFExporter
    {
        public GLTFMaterialExporter(nint addr) : base(addr) { }
        public StaticMesh DefaultPreviewMesh { get { return this[nameof(DefaultPreviewMesh)].As<StaticMesh>(); } set { this["DefaultPreviewMesh"] = value; } }
    }
    public class GLTFMaterialExportOptions : AssetUserData
    {
        public GLTFMaterialExportOptions(nint addr) : base(addr) { }
        public MaterialInterface Proxy { get { return this[nameof(Proxy)].As<MaterialInterface>(); } set { this["Proxy"] = value; } }
        public GLTFOverrideMaterialBakeSettings Default { get { return this[nameof(Default)].As<GLTFOverrideMaterialBakeSettings>(); } set { this["Default"] = value; } }
        public Object Inputs { get { return this[nameof(Inputs)]; } set { this[nameof(Inputs)] = value; } }
    }
    public class GLTFProxyOptions : Object
    {
        public GLTFProxyOptions(nint addr) : base(addr) { }
        public bool bBakeMaterialInputs { get { return this[nameof(bBakeMaterialInputs)].Flag; } set { this[nameof(bBakeMaterialInputs)].Flag = value; } }
        public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize { get { return (EGLTFMaterialBakeSizePOT)this[nameof(DefaultMaterialBakeSize)].GetValue<int>(); } set { this[nameof(DefaultMaterialBakeSize)].SetValue<int>((int)value); } }
        public byte DefaultMaterialBakeFilter { get { return this[nameof(DefaultMaterialBakeFilter)].GetValue<byte>(); } set { this[nameof(DefaultMaterialBakeFilter)].SetValue<byte>(value); } }
        public byte DefaultMaterialBakeTiling { get { return this[nameof(DefaultMaterialBakeTiling)].GetValue<byte>(); } set { this[nameof(DefaultMaterialBakeTiling)].SetValue<byte>(value); } }
        public Object DefaultInputBakeSettings { get { return this[nameof(DefaultInputBakeSettings)]; } set { this[nameof(DefaultInputBakeSettings)] = value; } }
        public void ResetToDefault() { Invoke(nameof(ResetToDefault)); }
    }
    public class GLTFSkeletalMeshExporter : GLTFExporter
    {
        public GLTFSkeletalMeshExporter(nint addr) : base(addr) { }
    }
    public class GLTFStaticMeshExporter : GLTFExporter
    {
        public GLTFStaticMeshExporter(nint addr) : base(addr) { }
    }
    public enum EGLTFTextureImageFormat : int
    {
        None = 0,
        PNG = 1,
        JPEG = 2,
        EGLTFTextureImageFormat_MAX = 3,
    }
    public enum EGLTFTextureType : int
    {
        None = 0,
        HDR = 1,
        Normalmaps = 2,
        Lightmaps = 4,
        All = 7,
        EGLTFTextureType_MAX = 8,
    }
    public enum EGLTFTextureHDREncoding : int
    {
        None = 0,
        RGBM = 1,
        EGLTFTextureHDREncoding_MAX = 2,
    }
    public enum EGLTFSceneMobility : int
    {
        None = 0,
        Static = 1,
        Stationary = 2,
        Movable = 4,
        All = 7,
        EGLTFSceneMobility_MAX = 8,
    }
    public enum EGLTFVariantSetsMode : int
    {
        None = 0,
        Khronos = 1,
        Epic = 2,
        EGLTFVariantSetsMode_MAX = 3,
    }
    public enum EGLTFMaterialVariantMode : int
    {
        None = 0,
        Simple = 1,
        UseMeshData = 2,
        EGLTFMaterialVariantMode_MAX = 3,
    }
    public enum EGLTFMaterialBakeMode : int
    {
        Disabled = 0,
        Simple = 1,
        UseMeshData = 2,
        EGLTFMaterialBakeMode_MAX = 3,
    }
    public enum EGLTFMaterialBakeSizePOT : int
    {
        POT_2 = 0,
        POT_3 = 1,
        POT_5 = 2,
        POT_9 = 3,
        POT_17 = 4,
        POT_33 = 5,
        POT_65 = 6,
        POT_129 = 7,
        POT_257 = 8,
        POT_513 = 9,
        POT_1025 = 10,
        POT_2049 = 11,
        POT_4097 = 12,
        POT_8193 = 13,
        POT_MAX = 14,
    }
    public enum EGLTFMaterialPropertyGroup : int
    {
        None = 0,
        BaseColorOpacity = 1,
        MetallicRoughness = 2,
        EmissiveColor = 3,
        Normal = 4,
        AmbientOcclusion = 5,
        ClearCoatRoughness = 6,
        ClearCoatBottomNormal = 7,
        EGLTFMaterialPropertyGroup_MAX = 8,
    }
    public class GLTFExportMessages : Object
    {
        public GLTFExportMessages(nint addr) : base(addr) { }
        public Array<Object> Suggestions { get { return new Array<Object>(this[nameof(Suggestions)].Address); } }
        public Array<Object> Warnings { get { return new Array<Object>(this[nameof(Warnings)].Address); } }
        public Array<Object> Errors { get { return new Array<Object>(this[nameof(Errors)].Address); } }
    }
    public class GLTFOverrideMaterialBakeSettings : Object
    {
        public GLTFOverrideMaterialBakeSettings(nint addr) : base(addr) { }
        public bool bOverrideSize { get { return this[nameof(bOverrideSize)].Flag; } set { this[nameof(bOverrideSize)].Flag = value; } }
        public EGLTFMaterialBakeSizePOT Size { get { return (EGLTFMaterialBakeSizePOT)this[nameof(Size)].GetValue<int>(); } set { this[nameof(Size)].SetValue<int>((int)value); } }
        public bool bOverrideFilter { get { return this[nameof(bOverrideFilter)].Flag; } set { this[nameof(bOverrideFilter)].Flag = value; } }
        public byte Filter { get { return this[nameof(Filter)].GetValue<byte>(); } set { this[nameof(Filter)].SetValue<byte>(value); } }
        public bool bOverrideTiling { get { return this[nameof(bOverrideTiling)].Flag; } set { this[nameof(bOverrideTiling)].Flag = value; } }
        public byte Tiling { get { return this[nameof(Tiling)].GetValue<byte>(); } set { this[nameof(Tiling)].SetValue<byte>(value); } }
    }
}
