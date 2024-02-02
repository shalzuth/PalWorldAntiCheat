using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieRenderPipelineCoreSDK;
using SDK.Script.ActorLayerUtilitiesSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MovieRenderPipelineRenderPassesSDK
{
    public class MoviePipelineImagePassBase : MoviePipelineRenderPass
    {
        public MoviePipelineImagePassBase(nint addr) : base(addr) { }
    }
    public class MoviePipelineDeferredPassBase : MoviePipelineImagePassBase
    {
        public MoviePipelineDeferredPassBase(nint addr) : base(addr) { }
        public bool bAccumulatorIncludesAlpha { get { return this[nameof(bAccumulatorIncludesAlpha)].Flag; } set { this[nameof(bAccumulatorIncludesAlpha)].Flag = value; } }
        public bool bDisableMultisampleEffects { get { return this[nameof(bDisableMultisampleEffects)].Flag; } set { this[nameof(bDisableMultisampleEffects)].Flag = value; } }
        public bool bUse32BitPostProcessMaterials { get { return this[nameof(bUse32BitPostProcessMaterials)].Flag; } set { this[nameof(bUse32BitPostProcessMaterials)].Flag = value; } }
        public Array<MoviePipelinePostProcessPass> AdditionalPostProcessMaterials { get { return new Array<MoviePipelinePostProcessPass>(this[nameof(AdditionalPostProcessMaterials)].Address); } }
        public bool bRenderMainPass { get { return this[nameof(bRenderMainPass)].Flag; } set { this[nameof(bRenderMainPass)].Flag = value; } }
        public bool bAddDefaultLayer { get { return this[nameof(bAddDefaultLayer)].Flag; } set { this[nameof(bAddDefaultLayer)].Flag = value; } }
        public Array<ActorLayer> ActorLayers { get { return new Array<ActorLayer>(this[nameof(ActorLayers)].Address); } }
        public Array<SoftObjectPath> DataLayers { get { return new Array<SoftObjectPath>(this[nameof(DataLayers)].Address); } }
        public Array<MaterialInterface> ActivePostProcessMaterials { get { return new Array<MaterialInterface>(this[nameof(ActivePostProcessMaterials)].Address); } }
        public MaterialInterface StencilLayerMaterial { get { return this[nameof(StencilLayerMaterial)].As<MaterialInterface>(); } set { this["StencilLayerMaterial"] = value; } }
    }
    public class MoviePipelineDeferredPass_Unlit : MoviePipelineDeferredPassBase
    {
        public MoviePipelineDeferredPass_Unlit(nint addr) : base(addr) { }
    }
    public class MoviePipelineDeferredPass_DetailLighting : MoviePipelineDeferredPassBase
    {
        public MoviePipelineDeferredPass_DetailLighting(nint addr) : base(addr) { }
    }
    public class MoviePipelineDeferredPass_LightingOnly : MoviePipelineDeferredPassBase
    {
        public MoviePipelineDeferredPass_LightingOnly(nint addr) : base(addr) { }
    }
    public class MoviePipelineDeferredPass_ReflectionsOnly : MoviePipelineDeferredPassBase
    {
        public MoviePipelineDeferredPass_ReflectionsOnly(nint addr) : base(addr) { }
    }
    public class MoviePipelineDeferredPass_PathTracer : MoviePipelineDeferredPassBase
    {
        public MoviePipelineDeferredPass_PathTracer(nint addr) : base(addr) { }
        public bool bReferenceMotionBlur { get { return this[nameof(bReferenceMotionBlur)].Flag; } set { this[nameof(bReferenceMotionBlur)].Flag = value; } }
    }
    public class MoviePipelineImageSequenceOutputBase : MoviePipelineOutputBase
    {
        public MoviePipelineImageSequenceOutputBase(nint addr) : base(addr) { }
    }
    public class MoviePipelineImageSequenceOutput_EXR : MoviePipelineImageSequenceOutputBase
    {
        public MoviePipelineImageSequenceOutput_EXR(nint addr) : base(addr) { }
        public EEXRCompressionFormat Compression { get { return (EEXRCompressionFormat)this[nameof(Compression)].GetValue<int>(); } set { this[nameof(Compression)].SetValue<int>((int)value); } }
        public bool bMultilayer { get { return this[nameof(bMultilayer)].Flag; } set { this[nameof(bMultilayer)].Flag = value; } }
    }
    public class MoviePipelineImageSequenceOutput_BMP : MoviePipelineImageSequenceOutputBase
    {
        public MoviePipelineImageSequenceOutput_BMP(nint addr) : base(addr) { }
    }
    public class MoviePipelineImageSequenceOutput_PNG : MoviePipelineImageSequenceOutputBase
    {
        public MoviePipelineImageSequenceOutput_PNG(nint addr) : base(addr) { }
        public bool bWriteAlpha { get { return this[nameof(bWriteAlpha)].Flag; } set { this[nameof(bWriteAlpha)].Flag = value; } }
    }
    public class MoviePipelineImageSequenceOutput_JPG : MoviePipelineImageSequenceOutputBase
    {
        public MoviePipelineImageSequenceOutput_JPG(nint addr) : base(addr) { }
    }
    public class MoviePipelineWaveOutput : MoviePipelineOutputBase
    {
        public MoviePipelineWaveOutput(nint addr) : base(addr) { }
        public Object FileNameFormatOverride { get { return this[nameof(FileNameFormatOverride)]; } set { this[nameof(FileNameFormatOverride)] = value; } }
    }
    public enum EEXRCompressionFormat : int
    {
        None = 0,
        PIZ = 1,
        ZIP = 2,
        DWAA = 3,
        DWAB = 4,
        EEXRCompressionFormat_MAX = 5,
    }
    public class MoviePipelinePostProcessPass : Object
    {
        public MoviePipelinePostProcessPass(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Object Material { get { return this[nameof(Material)]; } set { this[nameof(Material)] = value; } }
    }
}
