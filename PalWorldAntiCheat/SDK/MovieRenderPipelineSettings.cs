using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.UMGSDK;
using SDK.Script.MovieRenderPipelineCoreSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MovieRenderPipelineSettingsSDK
{
    public class MoviePipelineBurnInWidget : UserWidget
    {
        public MoviePipelineBurnInWidget(nint addr) : base(addr) { }
        public void OnOutputFrameStarted(MoviePipeline ForPipeline) { Invoke(nameof(OnOutputFrameStarted), ForPipeline); }
    }
    public class MoviePipelineBurnInSetting : MoviePipelineRenderPass
    {
        public MoviePipelineBurnInSetting(nint addr) : base(addr) { }
        public SoftClassPath BurnInClass { get { return this[nameof(BurnInClass)].As<SoftClassPath>(); } set { this["BurnInClass"] = value; } }
        public bool bCompositeOntoFinalImage { get { return this[nameof(bCompositeOntoFinalImage)].Flag; } set { this[nameof(bCompositeOntoFinalImage)].Flag = value; } }
        public TextureRenderTarget2D RenderTarget { get { return this[nameof(RenderTarget)].As<TextureRenderTarget2D>(); } set { this["RenderTarget"] = value; } }
        public Array<MoviePipelineBurnInWidget> BurnInWidgetInstances { get { return new Array<MoviePipelineBurnInWidget>(this[nameof(BurnInWidgetInstances)].Address); } }
    }
    public class MoviePipelineConsoleVariableSetting : MoviePipelineSetting
    {
        public MoviePipelineConsoleVariableSetting(nint addr) : base(addr) { }
        public Object ConsoleVariables { get { return this[nameof(ConsoleVariables)]; } set { this[nameof(ConsoleVariables)] = value; } }
        public Array<Object> StartConsoleCommands { get { return new Array<Object>(this[nameof(StartConsoleCommands)].Address); } }
        public Array<Object> EndConsoleCommands { get { return new Array<Object>(this[nameof(EndConsoleCommands)].Address); } }
    }
    public class MoviePipelineWidgetRenderer : MoviePipelineRenderPass
    {
        public MoviePipelineWidgetRenderer(nint addr) : base(addr) { }
        public bool bCompositeOntoFinalImage { get { return this[nameof(bCompositeOntoFinalImage)].Flag; } set { this[nameof(bCompositeOntoFinalImage)].Flag = value; } }
        public TextureRenderTarget2D RenderTarget { get { return this[nameof(RenderTarget)].As<TextureRenderTarget2D>(); } set { this["RenderTarget"] = value; } }
    }
}
