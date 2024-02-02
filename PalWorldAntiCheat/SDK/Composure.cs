using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.MediaIOCoreSDK;
using SDK.Script.OpenColorIOSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.MovieSceneTracksSDK;
namespace SDK.Script.ComposureSDK
{
    public class CompEditorImagePreviewInterface : Interface
    {
        public CompEditorImagePreviewInterface(nint addr) : base(addr) { }
    }
    public class CompImageColorPickerInterface : CompEditorImagePreviewInterface
    {
        public CompImageColorPickerInterface(nint addr) : base(addr) { }
    }
    public class ComposurePipelineBaseActor : Actor
    {
        public ComposurePipelineBaseActor(nint addr) : base(addr) { }
        public bool bAutoRun { get { return this[nameof(bAutoRun)].Flag; } set { this[nameof(bAutoRun)].Flag = value; } }
        public bool bAutoRunChildElementsAndSelf { get { return this[nameof(bAutoRunChildElementsAndSelf)].Flag; } set { this[nameof(bAutoRunChildElementsAndSelf)].Flag = value; } }
        public void SetAutoRunChildrenAndSelf(bool bAutoRunChildAndSelf) { Invoke(nameof(SetAutoRunChildrenAndSelf), bAutoRunChildAndSelf); }
        public void SetAutoRun(bool bNewAutoRunVal) { Invoke(nameof(SetAutoRun), bNewAutoRunVal); }
        public bool IsActivelyRunning() { return Invoke<bool>(nameof(IsActivelyRunning)); }
        public void EnqueueRendering(bool bCameraCutThisFrame) { Invoke(nameof(EnqueueRendering), bCameraCutThisFrame); }
        public bool AreChildrenAndSelfAutoRun() { return Invoke<bool>(nameof(AreChildrenAndSelfAutoRun)); }
    }
    public class CompositingElement : ComposurePipelineBaseActor
    {
        public CompositingElement(nint addr) : base(addr) { }
        public ComposureCompositingTargetComponent CompositingTarget { get { return this[nameof(CompositingTarget)].As<ComposureCompositingTargetComponent>(); } set { this["CompositingTarget"] = value; } }
        public ComposurePostProcessingPassProxy PostProcessProxy { get { return this[nameof(PostProcessProxy)].As<ComposurePostProcessingPassProxy>(); } set { this["PostProcessProxy"] = value; } }
        public Array<CompositingElementInput> Inputs { get { return new Array<CompositingElementInput>(this[nameof(Inputs)].Address); } }
        public Array<CompositingElementTransform> TransformPasses { get { return new Array<CompositingElementTransform>(this[nameof(TransformPasses)].Address); } }
        public Array<CompositingElementOutput> Outputs { get { return new Array<CompositingElementOutput>(this[nameof(Outputs)].Address); } }
        public ESceneCameraLinkType CameraSource { get { return (ESceneCameraLinkType)this[nameof(CameraSource)].GetValue<int>(); } set { this[nameof(CameraSource)].SetValue<int>((int)value); } }
        public Object TargetCameraActor { get { return this[nameof(TargetCameraActor)]; } set { this[nameof(TargetCameraActor)] = value; } }
        public EInheritedSourceType ResolutionSource { get { return (EInheritedSourceType)this[nameof(ResolutionSource)].GetValue<int>(); } set { this[nameof(ResolutionSource)].SetValue<int>((int)value); } }
        public IntPoint RenderResolution { get { return this[nameof(RenderResolution)].As<IntPoint>(); } set { this["RenderResolution"] = value; } }
        public byte RenderFormat { get { return this[nameof(RenderFormat)].GetValue<byte>(); } set { this[nameof(RenderFormat)].SetValue<byte>(value); } }
        public bool bUseSharedTargetPool { get { return this[nameof(bUseSharedTargetPool)].Flag; } set { this[nameof(bUseSharedTargetPool)].Flag = value; } }
        public int FreezeFrameMask { get { return this[nameof(FreezeFrameMask)].GetValue<int>(); } set { this[nameof(FreezeFrameMask)].SetValue<int>(value); } }
        public Object OnTransformPassRendered_BP { get { return this[nameof(OnTransformPassRendered_BP)]; } set { this[nameof(OnTransformPassRendered_BP)] = value; } }
        public Object OnFinalPassRendered_BP { get { return this[nameof(OnFinalPassRendered_BP)]; } set { this[nameof(OnFinalPassRendered_BP)] = value; } }
        public Object CompShotIdName { get { return this[nameof(CompShotIdName)]; } set { this[nameof(CompShotIdName)] = value; } }
        public CompositingElement Parent { get { return this[nameof(Parent)].As<CompositingElement>(); } set { this["Parent"] = value; } }
        public Array<CompositingElement> ChildLayers { get { return new Array<CompositingElement>(this[nameof(ChildLayers)].Address); } }
        public float OutputOpacity { get { return this[nameof(OutputOpacity)].GetValue<float>(); } set { this[nameof(OutputOpacity)].SetValue<float>(value); } }
        public Object UserConstructedInputs { get { return this[nameof(UserConstructedInputs)]; } set { this[nameof(UserConstructedInputs)] = value; } }
        public Object UserConstructedTransforms { get { return this[nameof(UserConstructedTransforms)]; } set { this[nameof(UserConstructedTransforms)] = value; } }
        public Object UserConstructedOutputs { get { return this[nameof(UserConstructedOutputs)]; } set { this[nameof(UserConstructedOutputs)] = value; } }
        public Array<CompositingElementInput> InternalInputs { get { return new Array<CompositingElementInput>(this[nameof(InternalInputs)].Address); } }
        public Array<CompositingElementTransform> InternalTransformPasses { get { return new Array<CompositingElementTransform>(this[nameof(InternalTransformPasses)].Address); } }
        public Array<CompositingElementOutput> InternalOutputs { get { return new Array<CompositingElementOutput>(this[nameof(InternalOutputs)].Address); } }
        public AlphaTransformPass InternalAlphaPass { get { return this[nameof(InternalAlphaPass)].As<AlphaTransformPass>(); } set { this["InternalAlphaPass"] = value; } }
        public void SetTargetCamera(CameraActor NewCameraActor) { Invoke(nameof(SetTargetCamera), NewCameraActor); }
        public void SetRenderResolution(IntPoint NewResolution) { Invoke(nameof(SetRenderResolution), NewResolution); }
        public void SetOpacity(float NewOpacity) { Invoke(nameof(SetOpacity), NewOpacity); }
        public void SetElementName(Object NewName) { Invoke(nameof(SetElementName), NewName); }
        public void SetEditorColorPickingTarget(TextureRenderTarget2D PickingTarget) { Invoke(nameof(SetEditorColorPickingTarget), PickingTarget); }
        public void SetEditorColorPickerDisplayImage(Texture PickerDisplayImage) { Invoke(nameof(SetEditorColorPickerDisplayImage), PickerDisplayImage); }
        public TextureRenderTarget2D RequestNamedRenderTarget(Object ReferenceName, float RenderPercentage, ETargetUsageFlags UsageTag) { return Invoke<TextureRenderTarget2D>(nameof(RequestNamedRenderTarget), ReferenceName, RenderPercentage, UsageTag); }
        public TextureRenderTarget2D RenderCompositingMaterialToTarget(CompositingMaterial CompMaterial, TextureRenderTarget2D RenderTarget, Object ResultLookupName) { return Invoke<TextureRenderTarget2D>(nameof(RenderCompositingMaterialToTarget), CompMaterial, RenderTarget, ResultLookupName); }
        public Texture RenderCompositingMaterial(CompositingMaterial CompMaterial, float RenderScale, Object ResultLookupName, ETargetUsageFlags UsageTag) { return Invoke<Texture>(nameof(RenderCompositingMaterial), CompMaterial, RenderScale, ResultLookupName, UsageTag); }
        public Texture RenderCompElement(bool bCameraCutThisFrame) { return Invoke<Texture>(nameof(RenderCompElement), bCameraCutThisFrame); }
        public bool ReleaseOwnedTarget(TextureRenderTarget2D OwnedTarget) { return Invoke<bool>(nameof(ReleaseOwnedTarget), OwnedTarget); }
        public void RegisterPassResult(Object ReferenceName, Texture PassResult, bool bSetAsLatestRenderResult) { Invoke(nameof(RegisterPassResult), ReferenceName, PassResult, bSetAsLatestRenderResult); }
        public bool IsSubElement() { return Invoke<bool>(nameof(IsSubElement)); }
        public Array<CompositingElementTransform> GetTransformsList() { return Invoke<Array<CompositingElementTransform>>(nameof(GetTransformsList)); }
        public IntPoint GetRenderResolution() { return Invoke<IntPoint>(nameof(GetRenderResolution)); }
        public int GetRenderPriority() { return Invoke<int>(nameof(GetRenderPriority)); }
        public Array<CompositingElementOutput> GetOutputsList() { return Invoke<Array<CompositingElementOutput>>(nameof(GetOutputsList)); }
        public float GetOpacity() { return Invoke<float>(nameof(GetOpacity)); }
        public Texture GetLatestRenderResult() { return Invoke<Texture>(nameof(GetLatestRenderResult)); }
        public Array<CompositingElementInput> GetInputsList() { return Invoke<Array<CompositingElementInput>>(nameof(GetInputsList)); }
        public CompositingElement GetElementParent() { return Invoke<CompositingElement>(nameof(GetElementParent)); }
        public Object GetCompElementName() { return Invoke<Object>(nameof(GetCompElementName)); }
        public Array<CompositingElement> GetChildElements() { return Invoke<Array<CompositingElement>>(nameof(GetChildElements)); }
        public CompositingElementTransform FindTransformPass(Object TransformType, Texture PassResult, Object OptionalPassName) { return Invoke<CompositingElementTransform>(nameof(FindTransformPass), TransformType, PassResult, OptionalPassName); }
        public CameraActor FindTargetCamera() { return Invoke<CameraActor>(nameof(FindTargetCamera)); }
        public CompositingElementOutput FindOutputPass(Object OutputType, Object OptionalPassName) { return Invoke<CompositingElementOutput>(nameof(FindOutputPass), OutputType, OptionalPassName); }
        public Texture FindNamedRenderResult(Object PassName, bool bSearchSubElements) { return Invoke<Texture>(nameof(FindNamedRenderResult), PassName, bSearchSubElements); }
        public CompositingElementInput FindInputPass(Object InputType, Texture PassResult, Object OptionalPassName) { return Invoke<CompositingElementInput>(nameof(FindInputPass), InputType, PassResult, OptionalPassName); }
        public bool DeletePass(CompositingElementPass PassToDelete) { return Invoke<bool>(nameof(DeletePass), PassToDelete); }
        public CompositingElementTransform CreateNewTransformPass(Object PassName, Object TransformType) { return Invoke<CompositingElementTransform>(nameof(CreateNewTransformPass), PassName, TransformType); }
        public CompositingElementOutput CreateNewOutputPass(Object PassName, Object OutputType) { return Invoke<CompositingElementOutput>(nameof(CreateNewOutputPass), PassName, OutputType); }
        public CompositingElementInput CreateNewInputPass(Object PassName, Object InputType) { return Invoke<CompositingElementInput>(nameof(CreateNewInputPass), PassName, InputType); }
        public CompositingElementTransform AddNewTransformPass(Object PassName, Object TransformType) { return Invoke<CompositingElementTransform>(nameof(AddNewTransformPass), PassName, TransformType); }
        public CompositingElementOutput AddNewOutputPass(Object PassName, Object OutputType) { return Invoke<CompositingElementOutput>(nameof(AddNewOutputPass), PassName, OutputType); }
        public CompositingElementInput AddNewInputPass(Object PassName, Object InputType) { return Invoke<CompositingElementInput>(nameof(AddNewInputPass), PassName, InputType); }
    }
    public class CompositingCaptureBase : CompositingElement
    {
        public CompositingCaptureBase(nint addr) : base(addr) { }
        public SceneCaptureComponent2D SceneCaptureComponent2D { get { return this[nameof(SceneCaptureComponent2D)].As<SceneCaptureComponent2D>(); } set { this["SceneCaptureComponent2D"] = value; } }
        public bool bApplyDistortion { get { return this[nameof(bApplyDistortion)].Flag; } set { this[nameof(bApplyDistortion)].Flag = value; } }
        public ComponentReference LensComponentPicker { get { return this[nameof(LensComponentPicker)].As<ComponentReference>(); } set { this["LensComponentPicker"] = value; } }
        public float OverscanFactor { get { return this[nameof(OverscanFactor)].GetValue<float>(); } set { this[nameof(OverscanFactor)].SetValue<float>(value); } }
        public float OriginalFocalLength { get { return this[nameof(OriginalFocalLength)].GetValue<float>(); } set { this[nameof(OriginalFocalLength)].SetValue<float>(value); } }
        public MaterialInstanceDynamic LastDistortionMID { get { return this[nameof(LastDistortionMID)].As<MaterialInstanceDynamic>(); } set { this["LastDistortionMID"] = value; } }
        public void UpdateDistortion() { Invoke(nameof(UpdateDistortion)); }
    }
    public class CompositingPickerAsyncTask : BlueprintAsyncActionBase
    {
        public CompositingPickerAsyncTask(nint addr) : base(addr) { }
        public Object OnPick { get { return this[nameof(OnPick)]; } set { this[nameof(OnPick)] = value; } }
        public Object OnCancel { get { return this[nameof(OnCancel)]; } set { this[nameof(OnCancel)] = value; } }
        public Object OnAccept { get { return this[nameof(OnAccept)]; } set { this[nameof(OnAccept)] = value; } }
        public TextureRenderTarget2D PickerTarget { get { return this[nameof(PickerTarget)].As<TextureRenderTarget2D>(); } set { this["PickerTarget"] = value; } }
        public Texture PickerDisplayImage { get { return this[nameof(PickerDisplayImage)].As<Texture>(); } set { this["PickerDisplayImage"] = value; } }
        public CompositingPickerAsyncTask OpenCompositingPicker(TextureRenderTarget2D PickerTarget, Texture DisplayImage, Object WindowTitle, bool bAverageColorOnDrag, bool bUseImplicitGamma) { return Invoke<CompositingPickerAsyncTask>(nameof(OpenCompositingPicker), PickerTarget, DisplayImage, WindowTitle, bAverageColorOnDrag, bUseImplicitGamma); }
    }
    public class CompositingElementPass : Object
    {
        public CompositingElementPass(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Object PassName { get { return this[nameof(PassName)]; } set { this[nameof(PassName)] = value; } }
        public void SetPassEnabled(bool bSetEnabledTo) { Invoke(nameof(SetPassEnabled), bSetEnabledTo); }
        public void Reset() { Invoke(nameof(Reset)); }
        public TextureRenderTarget2D RequestRenderTarget(IntPoint Dimensions, byte Format) { return Invoke<TextureRenderTarget2D>(nameof(RequestRenderTarget), Dimensions, Format); }
        public TextureRenderTarget2D RequestNativelyFormattedTarget(float RenderScale) { return Invoke<TextureRenderTarget2D>(nameof(RequestNativelyFormattedTarget), RenderScale); }
        public bool ReleaseRenderTarget(TextureRenderTarget2D AssignedTarget) { return Invoke<bool>(nameof(ReleaseRenderTarget), AssignedTarget); }
        public void OnFrameEnd() { Invoke(nameof(OnFrameEnd)); }
        public void OnFrameBegin(bool bCameraCutThisFrame) { Invoke(nameof(OnFrameBegin), bCameraCutThisFrame); }
        public void OnEnabled() { Invoke(nameof(OnEnabled)); }
        public void OnDisabled() { Invoke(nameof(OnDisabled)); }
        public bool IsPassEnabled() { return Invoke<bool>(nameof(IsPassEnabled)); }
    }
    public class CompositingElementInput : CompositingElementPass
    {
        public CompositingElementInput(nint addr) : base(addr) { }
        public bool bIntermediate { get { return this[nameof(bIntermediate)].Flag; } set { this[nameof(bIntermediate)].Flag = value; } }
        public Texture GenerateInput() { return Invoke<Texture>(nameof(GenerateInput)); }
    }
    public class CompositingMediaInput : CompositingElementInput
    {
        public CompositingMediaInput(nint addr) : base(addr) { }
        public CompositingMaterial MediaTransformMaterial { get { return this[nameof(MediaTransformMaterial)].As<CompositingMaterial>(); } set { this["MediaTransformMaterial"] = value; } }
        public MaterialInterface DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInterface>(); } set { this["DefaultMaterial"] = value; } }
        public MaterialInterface DefaultTestPlateMaterial { get { return this[nameof(DefaultTestPlateMaterial)].As<MaterialInterface>(); } set { this["DefaultTestPlateMaterial"] = value; } }
        public MaterialInstanceDynamic FallbackMID { get { return this[nameof(FallbackMID)].As<MaterialInstanceDynamic>(); } set { this["FallbackMID"] = value; } }
    }
    public class MediaTextureCompositingInput : CompositingMediaInput
    {
        public MediaTextureCompositingInput(nint addr) : base(addr) { }
        public MediaTexture MediaSource { get { return this[nameof(MediaSource)].As<MediaTexture>(); } set { this["MediaSource"] = value; } }
    }
    public class CompositingInputInterface : Interface
    {
        public CompositingInputInterface(nint addr) : base(addr) { }
        public void OnFrameEnd(CompositingInputInterfaceProxy Proxy) { Invoke(nameof(OnFrameEnd), Proxy); }
        public void OnFrameBegin(CompositingInputInterfaceProxy Proxy, bool bCameraCutThisFrame) { Invoke(nameof(OnFrameBegin), Proxy, bCameraCutThisFrame); }
        public Texture GenerateInput(CompositingInputInterfaceProxy Proxy) { return Invoke<Texture>(nameof(GenerateInput), Proxy); }
    }
    public class CompositingInputInterfaceProxy : CompositingElementInput
    {
        public CompositingInputInterfaceProxy(nint addr) : base(addr) { }
        public Object CompositingInput { get { return this[nameof(CompositingInput)]; } set { this[nameof(CompositingInput)] = value; } }
    }
    public class CompositingElementOutput : CompositingElementPass
    {
        public CompositingElementOutput(nint addr) : base(addr) { }
        public void RelayOutput(Texture FinalResult, ComposurePostProcessingPassProxy PostProcessProxy) { Invoke(nameof(RelayOutput), FinalResult, PostProcessProxy); }
    }
    public class ColorConverterOutputPass : CompositingElementOutput
    {
        public ColorConverterOutputPass(nint addr) : base(addr) { }
        public CompositingElementTransform ColorConverter { get { return this[nameof(ColorConverter)].As<CompositingElementTransform>(); } set { this["ColorConverter"] = value; } }
        public Object DefaultConverterClass { get { return this[nameof(DefaultConverterClass)]; } set { this[nameof(DefaultConverterClass)] = value; } }
    }
    public class CompositingMediaCaptureOutput : ColorConverterOutputPass
    {
        public CompositingMediaCaptureOutput(nint addr) : base(addr) { }
        public MediaOutput CaptureOutput { get { return this[nameof(CaptureOutput)].As<MediaOutput>(); } set { this["CaptureOutput"] = value; } }
        public MediaCapture ActiveCapture { get { return this[nameof(ActiveCapture)].As<MediaCapture>(); } set { this["ActiveCapture"] = value; } }
    }
    public class RenderTargetCompositingOutput : CompositingElementOutput
    {
        public RenderTargetCompositingOutput(nint addr) : base(addr) { }
        public TextureRenderTarget2D RenderTarget { get { return this[nameof(RenderTarget)].As<TextureRenderTarget2D>(); } set { this["RenderTarget"] = value; } }
    }
    public class EXRFileCompositingOutput : CompositingElementOutput
    {
        public EXRFileCompositingOutput(nint addr) : base(addr) { }
        public DirectoryPath OutputDirectiory { get { return this[nameof(OutputDirectiory)].As<DirectoryPath>(); } set { this["OutputDirectiory"] = value; } }
        public Object FilenameFormat { get { return this[nameof(FilenameFormat)]; } set { this[nameof(FilenameFormat)] = value; } }
        public FrameRate OutputFrameRate { get { return this[nameof(OutputFrameRate)].As<FrameRate>(); } set { this["OutputFrameRate"] = value; } }
        public EExrCompressionOptions Compression { get { return (EExrCompressionOptions)this[nameof(Compression)].GetValue<int>(); } set { this[nameof(Compression)].SetValue<int>((int)value); } }
    }
    public class CompositingElementTransform : CompositingElementPass
    {
        public CompositingElementTransform(nint addr) : base(addr) { }
        public bool bIntermediate { get { return this[nameof(bIntermediate)].Flag; } set { this[nameof(bIntermediate)].Flag = value; } }
        public Texture FindNamedPrePassResult(Object PassLookupName) { return Invoke<Texture>(nameof(FindNamedPrePassResult), PassLookupName); }
        public Texture ApplyTransform(Texture Input, ComposurePostProcessingPassProxy PostProcessProxy, CameraActor TargetCamera) { return Invoke<Texture>(nameof(ApplyTransform), Input, PostProcessProxy, TargetCamera); }
    }
    public class CompositingPostProcessPass : CompositingElementTransform
    {
        public CompositingPostProcessPass(nint addr) : base(addr) { }
        public float RenderScale { get { return this[nameof(RenderScale)].GetValue<float>(); } set { this[nameof(RenderScale)].SetValue<float>(value); } }
        public Array<ComposurePostProcessPassPolicy> PostProcessPasses { get { return new Array<ComposurePostProcessPassPolicy>(this[nameof(PostProcessPasses)].Address); } }
    }
    public class CompositingElementMaterialPass : CompositingPostProcessPass
    {
        public CompositingElementMaterialPass(nint addr) : base(addr) { }
        public CompositingMaterial Material { get { return this[nameof(Material)].As<CompositingMaterial>(); } set { this["Material"] = value; } }
        public bool SetParameterMapping(Object TextureParamName, Object ComposureLayerName) { return Invoke<bool>(nameof(SetParameterMapping), TextureParamName, ComposureLayerName); }
        public void SetMaterialInterface(MaterialInterface NewMaterial) { Invoke(nameof(SetMaterialInterface), NewMaterial); }
        public void ApplyMaterialParams(MaterialInstanceDynamic Mid) { Invoke(nameof(ApplyMaterialParams), Mid); }
    }
    public class CompositingTonemapPass : CompositingElementTransform
    {
        public CompositingTonemapPass(nint addr) : base(addr) { }
        public ColorGradingSettings ColorGradingSettings { get { return this[nameof(ColorGradingSettings)].As<ColorGradingSettings>(); } set { this["ColorGradingSettings"] = value; } }
        public FilmStockSettings FilmStockSettings { get { return this[nameof(FilmStockSettings)].As<FilmStockSettings>(); } set { this["FilmStockSettings"] = value; } }
        public float ChromaticAberration { get { return this[nameof(ChromaticAberration)].GetValue<float>(); } set { this[nameof(ChromaticAberration)].SetValue<float>(value); } }
        public ComposureTonemapperPassPolicy TonemapPolicy { get { return this[nameof(TonemapPolicy)].As<ComposureTonemapperPassPolicy>(); } set { this["TonemapPolicy"] = value; } }
    }
    public class MultiPassChromaKeyer : CompositingElementTransform
    {
        public MultiPassChromaKeyer(nint addr) : base(addr) { }
        public Array<LinearColor> KeyColors { get { return new Array<LinearColor>(this[nameof(KeyColors)].Address); } }
        public CompositingMaterial KeyerMaterial { get { return this[nameof(KeyerMaterial)].As<CompositingMaterial>(); } set { this["KeyerMaterial"] = value; } }
        public Texture DefaultWhiteTexture { get { return this[nameof(DefaultWhiteTexture)].As<Texture>(); } set { this["DefaultWhiteTexture"] = value; } }
    }
    public class MultiPassDespill : CompositingElementTransform
    {
        public MultiPassDespill(nint addr) : base(addr) { }
        public Array<LinearColor> KeyColors { get { return new Array<LinearColor>(this[nameof(KeyColors)].Address); } }
        public CompositingMaterial KeyerMaterial { get { return this[nameof(KeyerMaterial)].As<CompositingMaterial>(); } set { this["KeyerMaterial"] = value; } }
        public Texture DefaultWhiteTexture { get { return this[nameof(DefaultWhiteTexture)].As<Texture>(); } set { this["DefaultWhiteTexture"] = value; } }
    }
    public class AlphaTransformPass : CompositingElementTransform
    {
        public AlphaTransformPass(nint addr) : base(addr) { }
        public float AlphaScale { get { return this[nameof(AlphaScale)].GetValue<float>(); } set { this[nameof(AlphaScale)].SetValue<float>(value); } }
        public MaterialInterface DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInterface>(); } set { this["DefaultMaterial"] = value; } }
        public MaterialInstanceDynamic AlphaTransformMID { get { return this[nameof(AlphaTransformMID)].As<MaterialInstanceDynamic>(); } set { this["AlphaTransformMID"] = value; } }
    }
    public class CompositingOpenColorIOPass : CompositingElementTransform
    {
        public CompositingOpenColorIOPass(nint addr) : base(addr) { }
        public OpenColorIOColorConversionSettings ColorConversionSettings { get { return this[nameof(ColorConversionSettings)].As<OpenColorIOColorConversionSettings>(); } set { this["ColorConversionSettings"] = value; } }
    }
    public class ComposureBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ComposureBlueprintLibrary(nint addr) : base(addr) { }
        public void SetUVMapSettingsToMaterialParameters(ComposureUVMapSettings UVMapSettings, MaterialInstanceDynamic Material) { Invoke(nameof(SetUVMapSettingsToMaterialParameters), UVMapSettings, Material); }
        public void RequestRedrawComposureViewport() { Invoke(nameof(RequestRedrawComposureViewport)); }
        public bool RenameComposureElement(Object OriginalElementName, Object NewElementName) { return Invoke<bool>(nameof(RenameComposureElement), OriginalElementName, NewElementName); }
        public void RefreshComposureElementList() { Invoke(nameof(RefreshComposureElementList)); }
        public bool IsComposureElementDrawing(CompositingElement CompElement) { return Invoke<bool>(nameof(IsComposureElementDrawing), CompElement); }
        public void InvertUVDisplacementMapEncodingParameters(Vector2D In, Vector2D Out) { Invoke(nameof(InvertUVDisplacementMapEncodingParameters), In, Out); }
        public void GetRedGreenUVFactorsFromChromaticAberration(float ChromaticAberrationAmount, Vector2D RedGreenUVFactors) { Invoke(nameof(GetRedGreenUVFactorsFromChromaticAberration), ChromaticAberrationAmount, RedGreenUVFactors); }
        public void GetProjectionMatrixFromPostMoveSettings(ComposurePostMoveSettings PostMoveSettings, float HorizontalFOVAngle, float AspectRatio, Matrix ProjectionMatrix) { Invoke(nameof(GetProjectionMatrixFromPostMoveSettings), PostMoveSettings, HorizontalFOVAngle, AspectRatio, ProjectionMatrix); }
        public void GetPlayerDisplayGamma(PlayerCameraManager PlayerCameraManager, float DisplayGamma) { Invoke(nameof(GetPlayerDisplayGamma), PlayerCameraManager, DisplayGamma); }
        public void GetCroppingUVTransformationMatrixFromPostMoveSettings(ComposurePostMoveSettings PostMoveSettings, float AspectRatio, Matrix CropingUVTransformationMatrix, Matrix UncropingUVTransformationMatrix) { Invoke(nameof(GetCroppingUVTransformationMatrixFromPostMoveSettings), PostMoveSettings, AspectRatio, CropingUVTransformationMatrix, UncropingUVTransformationMatrix); }
        public CompositingElement GetComposureElement(Object ElementName) { return Invoke<CompositingElement>(nameof(GetComposureElement), ElementName); }
        public void DeleteComposureElementAndChildren(Object ElementToDelete) { Invoke(nameof(DeleteComposureElementAndChildren), ElementToDelete); }
        public ComposurePlayerCompositingTarget CreatePlayerCompositingTarget(Object WorldContextObject) { return Invoke<ComposurePlayerCompositingTarget>(nameof(CreatePlayerCompositingTarget), WorldContextObject); }
        public CompositingElement CreateComposureElement(Object ElementName, Object ClassType, Actor LevelContext) { return Invoke<CompositingElement>(nameof(CreateComposureElement), ElementName, ClassType, LevelContext); }
        public void CopyCameraSettingsToSceneCapture(CameraComponent SrcCamera, SceneCaptureComponent2D DstCaptureComponent, float OriginalFocalLength, float OverscanFactor) { Invoke(nameof(CopyCameraSettingsToSceneCapture), SrcCamera, DstCaptureComponent, OriginalFocalLength, OverscanFactor); }
        public bool AttachComposureElement(Object ParentName, Object ChildName) { return Invoke<bool>(nameof(AttachComposureElement), ParentName, ChildName); }
    }
    public class ComposureGameSettings : Object
    {
        public ComposureGameSettings(nint addr) : base(addr) { }
        public SoftObjectPath StaticVideoPlateDebugImage { get { return this[nameof(StaticVideoPlateDebugImage)].As<SoftObjectPath>(); } set { this["StaticVideoPlateDebugImage"] = value; } }
        public bool bSceneCapWarnOfMissingCam { get { return this[nameof(bSceneCapWarnOfMissingCam)].Flag; } set { this[nameof(bSceneCapWarnOfMissingCam)].Flag = value; } }
        public SoftObjectPath FallbackCompositingTexture { get { return this[nameof(FallbackCompositingTexture)].As<SoftObjectPath>(); } set { this["FallbackCompositingTexture"] = value; } }
        public Texture FallbackCompositingTextureObj { get { return this[nameof(FallbackCompositingTextureObj)].As<Texture>(); } set { this["FallbackCompositingTextureObj"] = value; } }
    }
    public class ComposurePostProcessPass : SceneComponent
    {
        public ComposurePostProcessPass(nint addr) : base(addr) { }
        public SceneCaptureComponent2D SceneCapture { get { return this[nameof(SceneCapture)].As<SceneCaptureComponent2D>(); } set { this["SceneCapture"] = value; } }
        public ComposurePostProcessBlendable BlendableInterface { get { return this[nameof(BlendableInterface)].As<ComposurePostProcessBlendable>(); } set { this["BlendableInterface"] = value; } }
        public MaterialInterface SetupMaterial { get { return this[nameof(SetupMaterial)].As<MaterialInterface>(); } set { this["SetupMaterial"] = value; } }
        public MaterialInterface TonemapperReplacement { get { return this[nameof(TonemapperReplacement)].As<MaterialInterface>(); } set { this["TonemapperReplacement"] = value; } }
        public void SetSetupMaterial(MaterialInterface Material) { Invoke(nameof(SetSetupMaterial), Material); }
        public void SetOutputRenderTarget(TextureRenderTarget2D RenderTarget) { Invoke(nameof(SetOutputRenderTarget), RenderTarget); }
        public MaterialInterface GetSetupMaterial() { return Invoke<MaterialInterface>(nameof(GetSetupMaterial)); }
        public TextureRenderTarget2D GetOutputRenderTarget() { return Invoke<TextureRenderTarget2D>(nameof(GetOutputRenderTarget)); }
    }
    public class ComposureLensBloomPass : ComposurePostProcessPass
    {
        public ComposureLensBloomPass(nint addr) : base(addr) { }
        public LensBloomSettings Settings { get { return this[nameof(Settings)].As<LensBloomSettings>(); } set { this["Settings"] = value; } }
        public MaterialInstanceDynamic TonemapperReplacingMID { get { return this[nameof(TonemapperReplacingMID)].As<MaterialInstanceDynamic>(); } set { this["TonemapperReplacingMID"] = value; } }
        public void SetTonemapperReplacingMaterial(MaterialInstanceDynamic Material) { Invoke(nameof(SetTonemapperReplacingMaterial), Material); }
        public void BloomToRenderTarget() { Invoke(nameof(BloomToRenderTarget)); }
    }
    public class ComposurePostProcessPassPolicy : Object
    {
        public ComposurePostProcessPassPolicy(nint addr) : base(addr) { }
        public void SetupPostProcess(SceneCaptureComponent2D SceneCapture, MaterialInterface TonemapperOverride) { Invoke(nameof(SetupPostProcess), SceneCapture, TonemapperOverride); }
    }
    public class ComposureLensBloomPassPolicy : ComposurePostProcessPassPolicy
    {
        public ComposureLensBloomPassPolicy(nint addr) : base(addr) { }
        public LensBloomSettings Settings { get { return this[nameof(Settings)].As<LensBloomSettings>(); } set { this["Settings"] = value; } }
        public MaterialInterface ReplacementMaterial { get { return this[nameof(ReplacementMaterial)].As<MaterialInterface>(); } set { this["ReplacementMaterial"] = value; } }
        public Object BloomIntensityParamName { get { return this[nameof(BloomIntensityParamName)]; } set { this[nameof(BloomIntensityParamName)] = value; } }
        public MaterialInstanceDynamic TonemapperReplacmentMID { get { return this[nameof(TonemapperReplacmentMID)].As<MaterialInstanceDynamic>(); } set { this["TonemapperReplacmentMID"] = value; } }
    }
    public class ComposurePlayerCompositingCameraModifier : CameraModifier
    {
        public ComposurePlayerCompositingCameraModifier(nint addr) : base(addr) { }
        public Object Target { get { return this[nameof(Target)]; } set { this[nameof(Target)] = value; } }
    }
    public class ComposurePlayerCompositingInterface : Interface
    {
        public ComposurePlayerCompositingInterface(nint addr) : base(addr) { }
    }
    public class ComposurePlayerCompositingTarget : Object
    {
        public ComposurePlayerCompositingTarget(nint addr) : base(addr) { }
        public PlayerCameraManager PlayerCameraManager { get { return this[nameof(PlayerCameraManager)].As<PlayerCameraManager>(); } set { this["PlayerCameraManager"] = value; } }
        public ComposurePlayerCompositingCameraModifier PlayerCameraModifier { get { return this[nameof(PlayerCameraModifier)].As<ComposurePlayerCompositingCameraModifier>(); } set { this["PlayerCameraModifier"] = value; } }
        public MaterialInstanceDynamic ReplaceTonemapperMID { get { return this[nameof(ReplaceTonemapperMID)].As<MaterialInstanceDynamic>(); } set { this["ReplaceTonemapperMID"] = value; } }
        public void SetRenderTarget(TextureRenderTarget2D RenderTarget) { Invoke(nameof(SetRenderTarget), RenderTarget); }
        public PlayerCameraManager SetPlayerCameraManager(PlayerCameraManager PlayerCameraManager) { return Invoke<PlayerCameraManager>(nameof(SetPlayerCameraManager), PlayerCameraManager); }
        public PlayerCameraManager GetPlayerCameraManager() { return Invoke<PlayerCameraManager>(nameof(GetPlayerCameraManager)); }
    }
    public class ComposureCompositingTargetComponent : ActorComponent
    {
        public ComposureCompositingTargetComponent(nint addr) : base(addr) { }
        public Texture DisplayTexture { get { return this[nameof(DisplayTexture)].As<Texture>(); } set { this["DisplayTexture"] = value; } }
        public void SetDisplayTexture(Texture DisplayTexture) { Invoke(nameof(SetDisplayTexture), DisplayTexture); }
        public Texture GetDisplayTexture() { return Invoke<Texture>(nameof(GetDisplayTexture)); }
    }
    public class ComposurePostProcessBlendable : Object
    {
        public ComposurePostProcessBlendable(nint addr) : base(addr) { }
        public ComposurePostProcessPass Target { get { return this[nameof(Target)].As<ComposurePostProcessPass>(); } set { this["Target"] = value; } }
    }
    public class ComposurePostProcessingPassProxy : ComposurePostProcessPass
    {
        public ComposurePostProcessingPassProxy(nint addr) : base(addr) { }
        public MaterialInstanceDynamic SetupMID { get { return this[nameof(SetupMID)].As<MaterialInstanceDynamic>(); } set { this["SetupMID"] = value; } }
        public void Execute(Texture PrePassInput, ComposurePostProcessPassPolicy PostProcessPass) { Invoke(nameof(Execute), PrePassInput, PostProcessPass); }
    }
    public class ComposureTonemapperPass : ComposurePostProcessPass
    {
        public ComposureTonemapperPass(nint addr) : base(addr) { }
        public ColorGradingSettings ColorGradingSettings { get { return this[nameof(ColorGradingSettings)].As<ColorGradingSettings>(); } set { this["ColorGradingSettings"] = value; } }
        public FilmStockSettings FilmStockSettings { get { return this[nameof(FilmStockSettings)].As<FilmStockSettings>(); } set { this["FilmStockSettings"] = value; } }
        public float ChromaticAberration { get { return this[nameof(ChromaticAberration)].GetValue<float>(); } set { this[nameof(ChromaticAberration)].SetValue<float>(value); } }
        public void TonemapToRenderTarget() { Invoke(nameof(TonemapToRenderTarget)); }
    }
    public class ComposureTonemapperPassPolicy : ComposurePostProcessPassPolicy
    {
        public ComposureTonemapperPassPolicy(nint addr) : base(addr) { }
        public ColorGradingSettings ColorGradingSettings { get { return this[nameof(ColorGradingSettings)].As<ColorGradingSettings>(); } set { this["ColorGradingSettings"] = value; } }
        public FilmStockSettings FilmStockSettings { get { return this[nameof(FilmStockSettings)].As<FilmStockSettings>(); } set { this["FilmStockSettings"] = value; } }
        public float ChromaticAberration { get { return this[nameof(ChromaticAberration)].GetValue<float>(); } set { this[nameof(ChromaticAberration)].SetValue<float>(value); } }
    }
    public class CompositingTextureLookupTable : Interface
    {
        public CompositingTextureLookupTable(nint addr) : base(addr) { }
        public bool FindNamedPassResult(Object LookupName, Texture OutTexture) { return Invoke<bool>(nameof(FindNamedPassResult), LookupName, OutTexture); }
    }
    public class MovieSceneComposureExportClient : Interface
    {
        public MovieSceneComposureExportClient(nint addr) : base(addr) { }
        public void InitializeForExport(MovieSceneComposureExportInitializer ExportInitializer) { Invoke(nameof(InitializeForExport), ExportInitializer); }
    }
    public class MovieSceneComposureExportInitializer : Object
    {
        public MovieSceneComposureExportInitializer(nint addr) : base(addr) { }
        public void ExportSceneCaptureBuffers(CompositingElement CompShotElement, SceneCaptureComponent2D SceneCapture, Array<Object> BuffersToExport) { Invoke(nameof(ExportSceneCaptureBuffers), CompShotElement, SceneCapture, BuffersToExport); }
    }
    public class MovieSceneComposureExportTrack : MovieSceneTrack
    {
        public MovieSceneComposureExportTrack(nint addr) : base(addr) { }
        public MovieSceneComposureExportPass Pass { get { return this[nameof(Pass)].As<MovieSceneComposureExportPass>(); } set { this["Pass"] = value; } }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneComposureExportSection : MovieSceneSection
    {
        public MovieSceneComposureExportSection(nint addr) : base(addr) { }
    }
    public class MovieSceneComposurePostMoveSettingsSection : MovieSceneSection
    {
        public MovieSceneComposurePostMoveSettingsSection(nint addr) : base(addr) { }
        public MovieSceneFloatChannel Pivot { get { return this[nameof(Pivot)].As<MovieSceneFloatChannel>(); } set { this["Pivot"] = value; } }
        public MovieSceneFloatChannel Translation { get { return this[nameof(Translation)].As<MovieSceneFloatChannel>(); } set { this["Translation"] = value; } }
        public MovieSceneFloatChannel RotationAngle { get { return this[nameof(RotationAngle)].As<MovieSceneFloatChannel>(); } set { this["RotationAngle"] = value; } }
        public MovieSceneFloatChannel Scale { get { return this[nameof(Scale)].As<MovieSceneFloatChannel>(); } set { this["Scale"] = value; } }
    }
    public class MovieSceneComposurePostMoveSettingsTrack : MovieScenePropertyTrack
    {
        public MovieSceneComposurePostMoveSettingsTrack(nint addr) : base(addr) { }
    }
    public class PlayerViewportCompositingOutput : ColorConverterOutputPass
    {
        public PlayerViewportCompositingOutput(nint addr) : base(addr) { }
        public int PlayerIndex { get { return this[nameof(PlayerIndex)].GetValue<int>(); } set { this[nameof(PlayerIndex)].SetValue<int>(value); } }
        public bool ApplyToneCurve { get { return this[nameof(ApplyToneCurve)].Flag; } set { this[nameof(ApplyToneCurve)].Flag = value; } }
        public PlayerCompOutputCameraModifier ActiveCamModifier { get { return this[nameof(ActiveCamModifier)].As<PlayerCompOutputCameraModifier>(); } set { this["ActiveCamModifier"] = value; } }
        public MaterialInterface TonemapperBaseMat { get { return this[nameof(TonemapperBaseMat)].As<MaterialInterface>(); } set { this["TonemapperBaseMat"] = value; } }
        public MaterialInterface PreTonemapBaseMat { get { return this[nameof(PreTonemapBaseMat)].As<MaterialInterface>(); } set { this["PreTonemapBaseMat"] = value; } }
        public MaterialInstanceDynamic ViewportOverrideMID { get { return this[nameof(ViewportOverrideMID)].As<MaterialInstanceDynamic>(); } set { this["ViewportOverrideMID"] = value; } }
    }
    public class PlayerCompOutputCameraModifier : CameraModifier
    {
        public PlayerCompOutputCameraModifier(nint addr) : base(addr) { }
        public PlayerViewportCompositingOutput Owner { get { return this[nameof(Owner)].As<PlayerViewportCompositingOutput>(); } set { this["Owner"] = value; } }
    }
    public enum ESceneCameraLinkType : int
    {
        Inherited = 0,
        Override = 1,
        Unused = 2,
        ESceneCameraLinkType_MAX = 3,
    }
    public enum EInheritedSourceType : int
    {
        Inherited = 0,
        Override = 1,
        EInheritedSourceType_MAX = 2,
    }
    public enum ETargetUsageFlags : int
    {
        USAGE_None = 0,
        USAGE_Input = 1,
        USAGE_Transform = 2,
        USAGE_Output = 4,
        USAGE_Persistent = 32,
        USAGE_Intermediate0 = 8,
        USAGE_Intermediate1 = 16,
        USAGE_MAX = 33,
    }
    public enum ECompPassConstructionType : int
    {
        Unknown = 0,
        EditorConstructed = 1,
        BlueprintConstructed = 2,
        CodeConstructed = 3,
        ECompPassConstructionType_MAX = 4,
    }
    public enum EExrCompressionOptions : int
    {
        Compressed = 0,
        Uncompressed = 1,
        EExrCompressionOptions_MAX = 2,
    }
    public enum EParamType : int
    {
        UnknownParamType = 0,
        ScalarParam = 1,
        VectorParam = 2,
        TextureParam = 3,
        MediaTextureParam = 4,
        EParamType_MAX = 5,
    }
    public class CompositingParamPayload : Object
    {
        public CompositingParamPayload(nint addr) : base(addr) { }
        public Object ScalarParamOverrides { get { return this[nameof(ScalarParamOverrides)]; } set { this[nameof(ScalarParamOverrides)] = value; } }
        public Object VectorParamOverrides { get { return this[nameof(VectorParamOverrides)]; } set { this[nameof(VectorParamOverrides)] = value; } }
        public Object TextureParamOverrides { get { return this[nameof(TextureParamOverrides)]; } set { this[nameof(TextureParamOverrides)] = value; } }
    }
    public class NamedCompMaterialParam : Object
    {
        public NamedCompMaterialParam(nint addr) : base(addr) { }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
    }
    public class CompositingMaterial : CompositingParamPayload
    {
        public CompositingMaterial(nint addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public Object ParamPassMappings { get { return this[nameof(ParamPassMappings)]; } set { this[nameof(ParamPassMappings)] = value; } }
        public Object RequiredMaterialParams { get { return this[nameof(RequiredMaterialParams)]; } set { this[nameof(RequiredMaterialParams)] = value; } }
        public MaterialInstanceDynamic CachedMID { get { return this[nameof(CachedMID)].As<MaterialInstanceDynamic>(); } set { this["CachedMID"] = value; } }
    }
    public class ComposurePostMoveSettings : Object
    {
        public ComposurePostMoveSettings(nint addr) : base(addr) { }
        public Vector2D Pivot { get { return this[nameof(Pivot)].As<Vector2D>(); } set { this["Pivot"] = value; } }
        public Vector2D Translation { get { return this[nameof(Translation)].As<Vector2D>(); } set { this["Translation"] = value; } }
        public float RotationAngle { get { return this[nameof(RotationAngle)].GetValue<float>(); } set { this[nameof(RotationAngle)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
    }
    public class ComposureUVMapSettings : Object
    {
        public ComposureUVMapSettings(nint addr) : base(addr) { }
        public Matrix PreUVDisplacementMatrix { get { return this[nameof(PreUVDisplacementMatrix)].As<Matrix>(); } set { this["PreUVDisplacementMatrix"] = value; } }
        public Matrix PostUVDisplacementMatrix { get { return this[nameof(PostUVDisplacementMatrix)].As<Matrix>(); } set { this["PostUVDisplacementMatrix"] = value; } }
        public Vector2D DisplacementDecodeParameters { get { return this[nameof(DisplacementDecodeParameters)].As<Vector2D>(); } set { this["DisplacementDecodeParameters"] = value; } }
        public Texture DisplacementTexture { get { return this[nameof(DisplacementTexture)].As<Texture>(); } set { this["DisplacementTexture"] = value; } }
        public bool bUseDisplacementBlueAndAlphaChannels { get { return this[nameof(bUseDisplacementBlueAndAlphaChannels)].Flag; } set { this[nameof(bUseDisplacementBlueAndAlphaChannels)].Flag = value; } }
    }
    public class MovieSceneComposureExportSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneComposureExportSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneComposureExportPass Pass { get { return this[nameof(Pass)].As<MovieSceneComposureExportPass>(); } set { this["Pass"] = value; } }
    }
    public class MovieSceneComposureExportPass : Object
    {
        public MovieSceneComposureExportPass(nint addr) : base(addr) { }
        public Object TransformPassName { get { return this[nameof(TransformPassName)]; } set { this[nameof(TransformPassName)] = value; } }
        public bool bRenamePass { get { return this[nameof(bRenamePass)].Flag; } set { this[nameof(bRenamePass)].Flag = value; } }
        public Object ExportedAs { get { return this[nameof(ExportedAs)]; } set { this[nameof(ExportedAs)] = value; } }
    }
    public class MovieSceneComposurePostMoveSettingsSectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneComposurePostMoveSettingsSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneFloatChannel Pivot { get { return this[nameof(Pivot)].As<MovieSceneFloatChannel>(); } set { this["Pivot"] = value; } }
        public MovieSceneFloatChannel Translation { get { return this[nameof(Translation)].As<MovieSceneFloatChannel>(); } set { this["Translation"] = value; } }
        public MovieSceneFloatChannel RotationAngle { get { return this[nameof(RotationAngle)].As<MovieSceneFloatChannel>(); } set { this["RotationAngle"] = value; } }
        public MovieSceneFloatChannel Scale { get { return this[nameof(Scale)].As<MovieSceneFloatChannel>(); } set { this["Scale"] = value; } }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
    }
}
