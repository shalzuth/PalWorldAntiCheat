using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.InteractiveToolsFrameworkSDK;
using SDK.Script.EngineSDK;
using SDK.Script.ModelingComponentsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MeshModelingToolsSDK;
using SDK.Script.GeometryFrameworkSDK;
using SDK.Script.ModelingOperatorsSDK;
namespace SDK.Script.MeshModelingToolsExpSDK
{
    public class BakeInputMeshProperties : InteractiveToolPropertySet
    {
        public BakeInputMeshProperties(nint addr) : base(addr) { }
        public StaticMesh TargetStaticMesh { get { return this[nameof(TargetStaticMesh)].As<StaticMesh>(); } set { this["TargetStaticMesh"] = value; } }
        public SkeletalMesh TargetSkeletalMesh { get { return this[nameof(TargetSkeletalMesh)].As<SkeletalMesh>(); } set { this["TargetSkeletalMesh"] = value; } }
        public Actor TargetDynamicMesh { get { return this[nameof(TargetDynamicMesh)].As<Actor>(); } set { this["TargetDynamicMesh"] = value; } }
        public Object TargetUVLayer { get { return this[nameof(TargetUVLayer)]; } set { this[nameof(TargetUVLayer)] = value; } }
        public bool bHasTargetUVLayer { get { return this[nameof(bHasTargetUVLayer)].Flag; } set { this[nameof(bHasTargetUVLayer)].Flag = value; } }
        public StaticMesh SourceStaticMesh { get { return this[nameof(SourceStaticMesh)].As<StaticMesh>(); } set { this["SourceStaticMesh"] = value; } }
        public SkeletalMesh SourceSkeletalMesh { get { return this[nameof(SourceSkeletalMesh)].As<SkeletalMesh>(); } set { this["SourceSkeletalMesh"] = value; } }
        public Actor SourceDynamicMesh { get { return this[nameof(SourceDynamicMesh)].As<Actor>(); } set { this["SourceDynamicMesh"] = value; } }
        public bool bHideSourceMesh { get { return this[nameof(bHideSourceMesh)].Flag; } set { this[nameof(bHideSourceMesh)].Flag = value; } }
        public Texture2D SourceNormalMap { get { return this[nameof(SourceNormalMap)].As<Texture2D>(); } set { this["SourceNormalMap"] = value; } }
        public Object SourceNormalMapUVLayer { get { return this[nameof(SourceNormalMapUVLayer)]; } set { this[nameof(SourceNormalMapUVLayer)] = value; } }
        public EBakeNormalSpace SourceNormalSpace { get { return (EBakeNormalSpace)this[nameof(SourceNormalSpace)].GetValue<int>(); } set { this[nameof(SourceNormalSpace)].SetValue<int>((int)value); } }
        public bool bHasSourceNormalMap { get { return this[nameof(bHasSourceNormalMap)].Flag; } set { this[nameof(bHasSourceNormalMap)].Flag = value; } }
        public float ProjectionDistance { get { return this[nameof(ProjectionDistance)].GetValue<float>(); } set { this[nameof(ProjectionDistance)].SetValue<float>(value); } }
        public bool bProjectionInWorldSpace { get { return this[nameof(bProjectionInWorldSpace)].Flag; } set { this[nameof(bProjectionInWorldSpace)].Flag = value; } }
        public Array<Object> TargetUVLayerNamesList { get { return new Array<Object>(this[nameof(TargetUVLayerNamesList)].Address); } }
        public Array<Object> SourceUVLayerNamesList { get { return new Array<Object>(this[nameof(SourceUVLayerNamesList)].Address); } }
        public Array<Object> GetTargetUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetTargetUVLayerNamesFunc)); }
        public Array<Object> GetSourceUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetSourceUVLayerNamesFunc)); }
    }
    public class BakeNormalMapToolProperties : InteractiveToolPropertySet
    {
        public BakeNormalMapToolProperties(nint addr) : base(addr) { }
    }
    public class BakeOcclusionMapToolProperties : InteractiveToolPropertySet
    {
        public BakeOcclusionMapToolProperties(nint addr) : base(addr) { }
        public int OcclusionRays { get { return this[nameof(OcclusionRays)].GetValue<int>(); } set { this[nameof(OcclusionRays)].SetValue<int>(value); } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public float SpreadAngle { get { return this[nameof(SpreadAngle)].GetValue<float>(); } set { this[nameof(SpreadAngle)].SetValue<float>(value); } }
        public float BiasAngle { get { return this[nameof(BiasAngle)].GetValue<float>(); } set { this[nameof(BiasAngle)].SetValue<float>(value); } }
    }
    public class BakeCurvatureMapToolProperties : InteractiveToolPropertySet
    {
        public BakeCurvatureMapToolProperties(nint addr) : base(addr) { }
        public EBakeCurvatureTypeMode CurvatureType { get { return (EBakeCurvatureTypeMode)this[nameof(CurvatureType)].GetValue<int>(); } set { this[nameof(CurvatureType)].SetValue<int>((int)value); } }
        public EBakeCurvatureColorMode ColorMapping { get { return (EBakeCurvatureColorMode)this[nameof(ColorMapping)].GetValue<int>(); } set { this[nameof(ColorMapping)].SetValue<int>((int)value); } }
        public float ColorRangeMultiplier { get { return this[nameof(ColorRangeMultiplier)].GetValue<float>(); } set { this[nameof(ColorRangeMultiplier)].SetValue<float>(value); } }
        public float MinRangeMultiplier { get { return this[nameof(MinRangeMultiplier)].GetValue<float>(); } set { this[nameof(MinRangeMultiplier)].SetValue<float>(value); } }
        public EBakeCurvatureClampMode Clamping { get { return (EBakeCurvatureClampMode)this[nameof(Clamping)].GetValue<int>(); } set { this[nameof(Clamping)].SetValue<int>((int)value); } }
    }
    public class BakeTexture2DProperties : InteractiveToolPropertySet
    {
        public BakeTexture2DProperties(nint addr) : base(addr) { }
        public Texture2D SourceTexture { get { return this[nameof(SourceTexture)].As<Texture2D>(); } set { this["SourceTexture"] = value; } }
        public Object UVLayer { get { return this[nameof(UVLayer)]; } set { this[nameof(UVLayer)] = value; } }
        public Array<Object> UVLayerNamesList { get { return new Array<Object>(this[nameof(UVLayerNamesList)].Address); } }
        public Array<Object> GetUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetUVLayerNamesFunc)); }
    }
    public class BakeMultiTexture2DProperties : InteractiveToolPropertySet
    {
        public BakeMultiTexture2DProperties(nint addr) : base(addr) { }
        public Array<Texture2D> MaterialIDSourceTextures { get { return new Array<Texture2D>(this[nameof(MaterialIDSourceTextures)].Address); } }
        public Object UVLayer { get { return this[nameof(UVLayer)]; } set { this[nameof(UVLayer)] = value; } }
        public Array<Object> UVLayerNamesList { get { return new Array<Object>(this[nameof(UVLayerNamesList)].Address); } }
        public Array<Texture2D> AllSourceTextures { get { return new Array<Texture2D>(this[nameof(AllSourceTextures)].Address); } }
        public Array<Object> GetUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetUVLayerNamesFunc)); }
    }
    public class BakeVisualizationProperties : InteractiveToolPropertySet
    {
        public BakeVisualizationProperties(nint addr) : base(addr) { }
        public bool bPreviewAsMaterial { get { return this[nameof(bPreviewAsMaterial)].Flag; } set { this[nameof(bPreviewAsMaterial)].Flag = value; } }
        public float Brightness { get { return this[nameof(Brightness)].GetValue<float>(); } set { this[nameof(Brightness)].SetValue<float>(value); } }
        public float AOMultiplier { get { return this[nameof(AOMultiplier)].GetValue<float>(); } set { this[nameof(AOMultiplier)].SetValue<float>(value); } }
    }
    public class MeshSculptBrushOpProps : InteractiveToolPropertySet
    {
        public MeshSculptBrushOpProps(nint addr) : base(addr) { }
    }
    public class BaseKelvinletBrushOpProps : MeshSculptBrushOpProps
    {
        public BaseKelvinletBrushOpProps(nint addr) : base(addr) { }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public float Incompressiblity { get { return this[nameof(Incompressiblity)].GetValue<float>(); } set { this[nameof(Incompressiblity)].SetValue<float>(value); } }
        public int BrushSteps { get { return this[nameof(BrushSteps)].GetValue<int>(); } set { this[nameof(BrushSteps)].SetValue<int>(value); } }
    }
    public class ScaleKelvinletBrushOpProps : BaseKelvinletBrushOpProps
    {
        public ScaleKelvinletBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class PullKelvinletBrushOpProps : BaseKelvinletBrushOpProps
    {
        public PullKelvinletBrushOpProps(nint addr) : base(addr) { }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
    }
    public class SharpPullKelvinletBrushOpProps : BaseKelvinletBrushOpProps
    {
        public SharpPullKelvinletBrushOpProps(nint addr) : base(addr) { }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
    }
    public class TwistKelvinletBrushOpProps : BaseKelvinletBrushOpProps
    {
        public TwistKelvinletBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class GroupEraseBrushOpProps : MeshSculptBrushOpProps
    {
        public GroupEraseBrushOpProps(nint addr) : base(addr) { }
        public int Group { get { return this[nameof(Group)].GetValue<int>(); } set { this[nameof(Group)].SetValue<int>(value); } }
        public bool bOnlyEraseCurrent { get { return this[nameof(bOnlyEraseCurrent)].Flag; } set { this[nameof(bOnlyEraseCurrent)].Flag = value; } }
    }
    public class GroupPaintBrushOpProps : MeshSculptBrushOpProps
    {
        public GroupPaintBrushOpProps(nint addr) : base(addr) { }
        public int Group { get { return this[nameof(Group)].GetValue<int>(); } set { this[nameof(Group)].SetValue<int>(value); } }
        public bool bOnlyPaintUngrouped { get { return this[nameof(bOnlyPaintUngrouped)].Flag; } set { this[nameof(bOnlyPaintUngrouped)].Flag = value; } }
    }
    public class InflateBrushOpProps : MeshSculptBrushOpProps
    {
        public InflateBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class MoveBrushOpProps : MeshSculptBrushOpProps
    {
        public MoveBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public ModelingToolsAxisFilter AxisFilters { get { return this[nameof(AxisFilters)].As<ModelingToolsAxisFilter>(); } set { this["AxisFilters"] = value; } }
    }
    public class PinchBrushOpProps : MeshSculptBrushOpProps
    {
        public PinchBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public bool bPerpDamping { get { return this[nameof(bPerpDamping)].Flag; } set { this[nameof(bPerpDamping)].Flag = value; } }
    }
    public class BasePlaneBrushOpProps : MeshSculptBrushOpProps
    {
        public BasePlaneBrushOpProps(nint addr) : base(addr) { }
    }
    public class PlaneBrushOpProps : BasePlaneBrushOpProps
    {
        public PlaneBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public EPlaneBrushSideMode WhichSide { get { return (EPlaneBrushSideMode)this[nameof(WhichSide)].GetValue<int>(); } set { this[nameof(WhichSide)].SetValue<int>((int)value); } }
    }
    public class ViewAlignedPlaneBrushOpProps : BasePlaneBrushOpProps
    {
        public ViewAlignedPlaneBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public EPlaneBrushSideMode WhichSide { get { return (EPlaneBrushSideMode)this[nameof(WhichSide)].GetValue<int>(); } set { this[nameof(WhichSide)].SetValue<int>((int)value); } }
    }
    public class FixedPlaneBrushOpProps : BasePlaneBrushOpProps
    {
        public FixedPlaneBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public EPlaneBrushSideMode WhichSide { get { return (EPlaneBrushSideMode)this[nameof(WhichSide)].GetValue<int>(); } set { this[nameof(WhichSide)].SetValue<int>((int)value); } }
    }
    public class StandardSculptBrushOpProps : MeshSculptBrushOpProps
    {
        public StandardSculptBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class ViewAlignedSculptBrushOpProps : MeshSculptBrushOpProps
    {
        public ViewAlignedSculptBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class SculptMaxBrushOpProps : MeshSculptBrushOpProps
    {
        public SculptMaxBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float MaxHeight { get { return this[nameof(MaxHeight)].GetValue<float>(); } set { this[nameof(MaxHeight)].SetValue<float>(value); } }
        public bool bUseFixedHeight { get { return this[nameof(bUseFixedHeight)].Flag; } set { this[nameof(bUseFixedHeight)].Flag = value; } }
        public float FixedHeight { get { return this[nameof(FixedHeight)].GetValue<float>(); } set { this[nameof(FixedHeight)].SetValue<float>(value); } }
    }
    public class BaseSmoothBrushOpProps : MeshSculptBrushOpProps
    {
        public BaseSmoothBrushOpProps(nint addr) : base(addr) { }
    }
    public class SmoothBrushOpProps : BaseSmoothBrushOpProps
    {
        public SmoothBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public bool bPreserveUVFlow { get { return this[nameof(bPreserveUVFlow)].Flag; } set { this[nameof(bPreserveUVFlow)].Flag = value; } }
    }
    public class SecondarySmoothBrushOpProps : BaseSmoothBrushOpProps
    {
        public SecondarySmoothBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public bool bPreserveUVFlow { get { return this[nameof(bPreserveUVFlow)].Flag; } set { this[nameof(bPreserveUVFlow)].Flag = value; } }
    }
    public class SmoothFillBrushOpProps : BaseSmoothBrushOpProps
    {
        public SmoothFillBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public bool bPreserveUVFlow { get { return this[nameof(bPreserveUVFlow)].Flag; } set { this[nameof(bPreserveUVFlow)].Flag = value; } }
    }
    public class FlattenBrushOpProps : MeshSculptBrushOpProps
    {
        public FlattenBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public EPlaneBrushSideMode WhichSide { get { return (EPlaneBrushSideMode)this[nameof(WhichSide)].GetValue<int>(); } set { this[nameof(WhichSide)].SetValue<int>((int)value); } }
    }
    public class EraseBrushOpProps : MeshSculptBrushOpProps
    {
        public EraseBrushOpProps(nint addr) : base(addr) { }
        public float Strength { get { return this[nameof(Strength)].GetValue<float>(); } set { this[nameof(Strength)].SetValue<float>(value); } }
        public float Falloff { get { return this[nameof(Falloff)].GetValue<float>(); } set { this[nameof(Falloff)].SetValue<float>(value); } }
    }
    public class PatternToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public PatternToolBuilder(nint addr) : base(addr) { }
    }
    public class PatternToolSettings : InteractiveToolPropertySet
    {
        public PatternToolSettings(nint addr) : base(addr) { }
        public EPatternToolShape Shape { get { return (EPatternToolShape)this[nameof(Shape)].GetValue<int>(); } set { this[nameof(Shape)].SetValue<int>((int)value); } }
        public EPatternToolSingleAxis SingleAxis { get { return (EPatternToolSingleAxis)this[nameof(SingleAxis)].GetValue<int>(); } set { this[nameof(SingleAxis)].SetValue<int>((int)value); } }
        public EPatternToolSinglePlane SinglePlane { get { return (EPatternToolSinglePlane)this[nameof(SinglePlane)].GetValue<int>(); } set { this[nameof(SinglePlane)].SetValue<int>((int)value); } }
        public bool bHideSources { get { return this[nameof(bHideSources)].Flag; } set { this[nameof(bHideSources)].Flag = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
    }
    public class PatternTool_LinearSettings : InteractiveToolPropertySet
    {
        public PatternTool_LinearSettings(nint addr) : base(addr) { }
        public EPatternToolAxisSpacingMode SpacingMode { get { return (EPatternToolAxisSpacingMode)this[nameof(SpacingMode)].GetValue<int>(); } set { this[nameof(SpacingMode)].SetValue<int>((int)value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public double StepSize { get { return this[nameof(StepSize)].GetValue<double>(); } set { this[nameof(StepSize)].SetValue<double>(value); } }
        public double Extent { get { return this[nameof(Extent)].GetValue<double>(); } set { this[nameof(Extent)].SetValue<double>(value); } }
        public bool bCentered { get { return this[nameof(bCentered)].Flag; } set { this[nameof(bCentered)].Flag = value; } }
    }
    public class PatternTool_GridSettings : InteractiveToolPropertySet
    {
        public PatternTool_GridSettings(nint addr) : base(addr) { }
        public EPatternToolAxisSpacingMode SpacingX { get { return (EPatternToolAxisSpacingMode)this[nameof(SpacingX)].GetValue<int>(); } set { this[nameof(SpacingX)].SetValue<int>((int)value); } }
        public int CountX { get { return this[nameof(CountX)].GetValue<int>(); } set { this[nameof(CountX)].SetValue<int>(value); } }
        public double StepSizeX { get { return this[nameof(StepSizeX)].GetValue<double>(); } set { this[nameof(StepSizeX)].SetValue<double>(value); } }
        public double ExtentX { get { return this[nameof(ExtentX)].GetValue<double>(); } set { this[nameof(ExtentX)].SetValue<double>(value); } }
        public bool bCenteredX { get { return this[nameof(bCenteredX)].Flag; } set { this[nameof(bCenteredX)].Flag = value; } }
        public EPatternToolAxisSpacingMode SpacingY { get { return (EPatternToolAxisSpacingMode)this[nameof(SpacingY)].GetValue<int>(); } set { this[nameof(SpacingY)].SetValue<int>((int)value); } }
        public int CountY { get { return this[nameof(CountY)].GetValue<int>(); } set { this[nameof(CountY)].SetValue<int>(value); } }
        public double StepSizeY { get { return this[nameof(StepSizeY)].GetValue<double>(); } set { this[nameof(StepSizeY)].SetValue<double>(value); } }
        public double ExtentY { get { return this[nameof(ExtentY)].GetValue<double>(); } set { this[nameof(ExtentY)].SetValue<double>(value); } }
        public bool bCenteredY { get { return this[nameof(bCenteredY)].Flag; } set { this[nameof(bCenteredY)].Flag = value; } }
    }
    public class PatternTool_RadialSettings : InteractiveToolPropertySet
    {
        public PatternTool_RadialSettings(nint addr) : base(addr) { }
        public EPatternToolAxisSpacingMode SpacingMode { get { return (EPatternToolAxisSpacingMode)this[nameof(SpacingMode)].GetValue<int>(); } set { this[nameof(SpacingMode)].SetValue<int>((int)value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public double StepSize { get { return this[nameof(StepSize)].GetValue<double>(); } set { this[nameof(StepSize)].SetValue<double>(value); } }
        public double Radius { get { return this[nameof(Radius)].GetValue<double>(); } set { this[nameof(Radius)].SetValue<double>(value); } }
        public double StartAngle { get { return this[nameof(StartAngle)].GetValue<double>(); } set { this[nameof(StartAngle)].SetValue<double>(value); } }
        public double EndAngle { get { return this[nameof(EndAngle)].GetValue<double>(); } set { this[nameof(EndAngle)].SetValue<double>(value); } }
        public double AngleShift { get { return this[nameof(AngleShift)].GetValue<double>(); } set { this[nameof(AngleShift)].SetValue<double>(value); } }
        public bool bOriented { get { return this[nameof(bOriented)].Flag; } set { this[nameof(bOriented)].Flag = value; } }
    }
    public class PatternTool_RotationSettings : InteractiveToolPropertySet
    {
        public PatternTool_RotationSettings(nint addr) : base(addr) { }
        public bool bInterpolate { get { return this[nameof(bInterpolate)].Flag; } set { this[nameof(bInterpolate)].Flag = value; } }
        public bool bJitter { get { return this[nameof(bJitter)].Flag; } set { this[nameof(bJitter)].Flag = value; } }
        public Rotator StartRotation { get { return this[nameof(StartRotation)].As<Rotator>(); } set { this["StartRotation"] = value; } }
        public Rotator EndRotation { get { return this[nameof(EndRotation)].As<Rotator>(); } set { this["EndRotation"] = value; } }
        public Rotator RotationJitterRange { get { return this[nameof(RotationJitterRange)].As<Rotator>(); } set { this["RotationJitterRange"] = value; } }
    }
    public class PatternTool_TranslationSettings : InteractiveToolPropertySet
    {
        public PatternTool_TranslationSettings(nint addr) : base(addr) { }
        public bool bInterpolate { get { return this[nameof(bInterpolate)].Flag; } set { this[nameof(bInterpolate)].Flag = value; } }
        public bool bJitter { get { return this[nameof(bJitter)].Flag; } set { this[nameof(bJitter)].Flag = value; } }
        public Vector StartTranslation { get { return this[nameof(StartTranslation)].As<Vector>(); } set { this["StartTranslation"] = value; } }
        public Vector EndTranslation { get { return this[nameof(EndTranslation)].As<Vector>(); } set { this["EndTranslation"] = value; } }
        public Vector TranslationJitterRange { get { return this[nameof(TranslationJitterRange)].As<Vector>(); } set { this["TranslationJitterRange"] = value; } }
    }
    public class PatternTool_ScaleSettings : InteractiveToolPropertySet
    {
        public PatternTool_ScaleSettings(nint addr) : base(addr) { }
        public bool bUniform { get { return this[nameof(bUniform)].Flag; } set { this[nameof(bUniform)].Flag = value; } }
        public bool bInterpolate { get { return this[nameof(bInterpolate)].Flag; } set { this[nameof(bInterpolate)].Flag = value; } }
        public bool bJitter { get { return this[nameof(bJitter)].Flag; } set { this[nameof(bJitter)].Flag = value; } }
        public Vector StartScale { get { return this[nameof(StartScale)].As<Vector>(); } set { this["StartScale"] = value; } }
        public Vector EndScale { get { return this[nameof(EndScale)].As<Vector>(); } set { this["EndScale"] = value; } }
        public float ScaleJitterRange { get { return this[nameof(ScaleJitterRange)].GetValue<float>(); } set { this[nameof(ScaleJitterRange)].SetValue<float>(value); } }
        public Vector ScaleJitterRangeNonUniform { get { return this[nameof(ScaleJitterRangeNonUniform)].As<Vector>(); } set { this["ScaleJitterRangeNonUniform"] = value; } }
    }
    public class PatternTool_OutputSettings : InteractiveToolPropertySet
    {
        public PatternTool_OutputSettings(nint addr) : base(addr) { }
        public bool bSeparateActors { get { return this[nameof(bSeparateActors)].Flag; } set { this[nameof(bSeparateActors)].Flag = value; } }
        public bool bConvertToDynamic { get { return this[nameof(bConvertToDynamic)].Flag; } set { this[nameof(bConvertToDynamic)].Flag = value; } }
        public bool bCreateISMCs { get { return this[nameof(bCreateISMCs)].Flag; } set { this[nameof(bCreateISMCs)].Flag = value; } }
        public bool bHaveStaticMeshes { get { return this[nameof(bHaveStaticMeshes)].Flag; } set { this[nameof(bHaveStaticMeshes)].Flag = value; } }
    }
    public class PatternTool : MultiSelectionMeshEditingTool
    {
        public PatternTool(nint addr) : base(addr) { }
        public PatternToolSettings Settings { get { return this[nameof(Settings)].As<PatternToolSettings>(); } set { this["Settings"] = value; } }
        public PatternTool_LinearSettings LinearSettings { get { return this[nameof(LinearSettings)].As<PatternTool_LinearSettings>(); } set { this["LinearSettings"] = value; } }
        public PatternTool_GridSettings GridSettings { get { return this[nameof(GridSettings)].As<PatternTool_GridSettings>(); } set { this["GridSettings"] = value; } }
        public PatternTool_RadialSettings RadialSettings { get { return this[nameof(RadialSettings)].As<PatternTool_RadialSettings>(); } set { this["RadialSettings"] = value; } }
        public PatternTool_RotationSettings RotationSettings { get { return this[nameof(RotationSettings)].As<PatternTool_RotationSettings>(); } set { this["RotationSettings"] = value; } }
        public PatternTool_TranslationSettings TranslationSettings { get { return this[nameof(TranslationSettings)].As<PatternTool_TranslationSettings>(); } set { this["TranslationSettings"] = value; } }
        public PatternTool_ScaleSettings ScaleSettings { get { return this[nameof(ScaleSettings)].As<PatternTool_ScaleSettings>(); } set { this["ScaleSettings"] = value; } }
        public PatternTool_OutputSettings OutputSettings { get { return this[nameof(OutputSettings)].As<PatternTool_OutputSettings>(); } set { this["OutputSettings"] = value; } }
        public TransformProxy TransformProxy_End { get { return this[nameof(TransformProxy_End)].As<TransformProxy>(); } set { this["TransformProxy_End"] = value; } }
        public CombinedTransformGizmo TransformGizmo_End { get { return this[nameof(TransformGizmo_End)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo_End"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
        public Object AllComponents { get { return this[nameof(AllComponents)]; } set { this[nameof(AllComponents)] = value; } }
        public PreviewGeometry PreviewGeometry { get { return this[nameof(PreviewGeometry)].As<PreviewGeometry>(); } set { this["PreviewGeometry"] = value; } }
    }
    public class MeshConstraintProperties : InteractiveToolPropertySet
    {
        public MeshConstraintProperties(nint addr) : base(addr) { }
        public bool bPreserveSharpEdges { get { return this[nameof(bPreserveSharpEdges)].Flag; } set { this[nameof(bPreserveSharpEdges)].Flag = value; } }
        public EMeshBoundaryConstraint MeshBoundaryConstraint { get { return (EMeshBoundaryConstraint)this[nameof(MeshBoundaryConstraint)].GetValue<int>(); } set { this[nameof(MeshBoundaryConstraint)].SetValue<int>((int)value); } }
        public EGroupBoundaryConstraint GroupBoundaryConstraint { get { return (EGroupBoundaryConstraint)this[nameof(GroupBoundaryConstraint)].GetValue<int>(); } set { this[nameof(GroupBoundaryConstraint)].SetValue<int>((int)value); } }
        public EMaterialBoundaryConstraint MaterialBoundaryConstraint { get { return (EMaterialBoundaryConstraint)this[nameof(MaterialBoundaryConstraint)].GetValue<int>(); } set { this[nameof(MaterialBoundaryConstraint)].SetValue<int>((int)value); } }
        public bool bPreventNormalFlips { get { return this[nameof(bPreventNormalFlips)].Flag; } set { this[nameof(bPreventNormalFlips)].Flag = value; } }
        public bool bPreventTinyTriangles { get { return this[nameof(bPreventTinyTriangles)].Flag; } set { this[nameof(bPreventTinyTriangles)].Flag = value; } }
    }
    public class RemeshProperties : MeshConstraintProperties
    {
        public RemeshProperties(nint addr) : base(addr) { }
        public float SmoothingStrength { get { return this[nameof(SmoothingStrength)].GetValue<float>(); } set { this[nameof(SmoothingStrength)].SetValue<float>(value); } }
        public bool bFlips { get { return this[nameof(bFlips)].Flag; } set { this[nameof(bFlips)].Flag = value; } }
        public bool bSplits { get { return this[nameof(bSplits)].Flag; } set { this[nameof(bSplits)].Flag = value; } }
        public bool bCollapses { get { return this[nameof(bCollapses)].Flag; } set { this[nameof(bCollapses)].Flag = value; } }
    }
    public class AddPatchToolBuilder : InteractiveToolBuilder
    {
        public AddPatchToolBuilder(nint addr) : base(addr) { }
    }
    public class AddPatchToolProperties : InteractiveToolPropertySet
    {
        public AddPatchToolProperties(nint addr) : base(addr) { }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float Rotation { get { return this[nameof(Rotation)].GetValue<float>(); } set { this[nameof(Rotation)].SetValue<float>(value); } }
        public int Subdivisions { get { return this[nameof(Subdivisions)].GetValue<int>(); } set { this[nameof(Subdivisions)].SetValue<int>(value); } }
        public float Shift { get { return this[nameof(Shift)].GetValue<float>(); } set { this[nameof(Shift)].SetValue<float>(value); } }
    }
    public class AddPatchTool : SingleClickTool
    {
        public AddPatchTool(nint addr) : base(addr) { }
        public AddPatchToolProperties ShapeSettings { get { return this[nameof(ShapeSettings)].As<AddPatchToolProperties>(); } set { this["ShapeSettings"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
    }
    public class AlignObjectsToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public AlignObjectsToolBuilder(nint addr) : base(addr) { }
    }
    public class AlignObjectsToolProperties : InteractiveToolPropertySet
    {
        public AlignObjectsToolProperties(nint addr) : base(addr) { }
        public EAlignObjectsAlignTypes AlignType { get { return (EAlignObjectsAlignTypes)this[nameof(AlignType)].GetValue<int>(); } set { this[nameof(AlignType)].SetValue<int>((int)value); } }
        public EAlignObjectsAlignToOptions AlignTo { get { return (EAlignObjectsAlignToOptions)this[nameof(AlignTo)].GetValue<int>(); } set { this[nameof(AlignTo)].SetValue<int>((int)value); } }
        public EAlignObjectsBoxPoint BoxPosition { get { return (EAlignObjectsBoxPoint)this[nameof(BoxPosition)].GetValue<int>(); } set { this[nameof(BoxPosition)].SetValue<int>((int)value); } }
        public bool bAlignX { get { return this[nameof(bAlignX)].Flag; } set { this[nameof(bAlignX)].Flag = value; } }
        public bool bAlignY { get { return this[nameof(bAlignY)].Flag; } set { this[nameof(bAlignY)].Flag = value; } }
        public bool bAlignZ { get { return this[nameof(bAlignZ)].Flag; } set { this[nameof(bAlignZ)].Flag = value; } }
    }
    public class AlignObjectsTool : MultiSelectionMeshEditingTool
    {
        public AlignObjectsTool(nint addr) : base(addr) { }
        public AlignObjectsToolProperties AlignProps { get { return this[nameof(AlignProps)].As<AlignObjectsToolProperties>(); } set { this["AlignProps"] = value; } }
    }
    public class BakeMeshAttributeMapsToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BakeMeshAttributeMapsToolBuilder(nint addr) : base(addr) { }
    }
    public class BakeMeshAttributeMapsToolProperties : InteractiveToolPropertySet
    {
        public BakeMeshAttributeMapsToolProperties(nint addr) : base(addr) { }
        public int MapTypes { get { return this[nameof(MapTypes)].GetValue<int>(); } set { this[nameof(MapTypes)].SetValue<int>(value); } }
        public Object MapPreview { get { return this[nameof(MapPreview)]; } set { this[nameof(MapPreview)] = value; } }
        public EBakeTextureResolution Resolution { get { return (EBakeTextureResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public EBakeTextureBitDepth BitDepth { get { return (EBakeTextureBitDepth)this[nameof(BitDepth)].GetValue<int>(); } set { this[nameof(BitDepth)].SetValue<int>((int)value); } }
        public EBakeTextureSamplesPerPixel SamplesPerPixel { get { return (EBakeTextureSamplesPerPixel)this[nameof(SamplesPerPixel)].GetValue<int>(); } set { this[nameof(SamplesPerPixel)].SetValue<int>((int)value); } }
        public Texture2D SampleFilterMask { get { return this[nameof(SampleFilterMask)].As<Texture2D>(); } set { this["SampleFilterMask"] = value; } }
        public Array<Object> MapPreviewNamesList { get { return new Array<Object>(this[nameof(MapPreviewNamesList)].Address); } }
        public Array<Object> GetMapPreviewNamesFunc() { return Invoke<Array<Object>>(nameof(GetMapPreviewNamesFunc)); }
    }
    public class BakeMeshAttributeTool : MultiSelectionMeshEditingTool
    {
        public BakeMeshAttributeTool(nint addr) : base(addr) { }
        public BakeOcclusionMapToolProperties OcclusionSettings { get { return this[nameof(OcclusionSettings)].As<BakeOcclusionMapToolProperties>(); } set { this["OcclusionSettings"] = value; } }
        public BakeCurvatureMapToolProperties CurvatureSettings { get { return this[nameof(CurvatureSettings)].As<BakeCurvatureMapToolProperties>(); } set { this["CurvatureSettings"] = value; } }
        public BakeTexture2DProperties TextureSettings { get { return this[nameof(TextureSettings)].As<BakeTexture2DProperties>(); } set { this["TextureSettings"] = value; } }
        public BakeMultiTexture2DProperties MultiTextureSettings { get { return this[nameof(MultiTextureSettings)].As<BakeMultiTexture2DProperties>(); } set { this["MultiTextureSettings"] = value; } }
        public MaterialInstanceDynamic WorkingPreviewMaterial { get { return this[nameof(WorkingPreviewMaterial)].As<MaterialInstanceDynamic>(); } set { this["WorkingPreviewMaterial"] = value; } }
        public MaterialInstanceDynamic ErrorPreviewMaterial { get { return this[nameof(ErrorPreviewMaterial)].As<MaterialInstanceDynamic>(); } set { this["ErrorPreviewMaterial"] = value; } }
    }
    public class BakeMeshAttributeMapsToolBase : BakeMeshAttributeTool
    {
        public BakeMeshAttributeMapsToolBase(nint addr) : base(addr) { }
        public BakeVisualizationProperties VisualizationProps { get { return this[nameof(VisualizationProps)].As<BakeVisualizationProperties>(); } set { this["VisualizationProps"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public MaterialInstanceDynamic PreviewMaterial { get { return this[nameof(PreviewMaterial)].As<MaterialInstanceDynamic>(); } set { this["PreviewMaterial"] = value; } }
        public MaterialInstanceDynamic BentNormalPreviewMaterial { get { return this[nameof(BentNormalPreviewMaterial)].As<MaterialInstanceDynamic>(); } set { this["BentNormalPreviewMaterial"] = value; } }
        public Object CachedMaps { get { return this[nameof(CachedMaps)]; } set { this[nameof(CachedMaps)] = value; } }
        public Texture2D EmptyNormalMap { get { return this[nameof(EmptyNormalMap)].As<Texture2D>(); } set { this["EmptyNormalMap"] = value; } }
        public Texture2D EmptyColorMapBlack { get { return this[nameof(EmptyColorMapBlack)].As<Texture2D>(); } set { this["EmptyColorMapBlack"] = value; } }
        public Texture2D EmptyColorMapWhite { get { return this[nameof(EmptyColorMapWhite)].As<Texture2D>(); } set { this["EmptyColorMapWhite"] = value; } }
    }
    public class BakeMeshAttributeMapsTool : BakeMeshAttributeMapsToolBase
    {
        public BakeMeshAttributeMapsTool(nint addr) : base(addr) { }
        public BakeInputMeshProperties InputMeshSettings { get { return this[nameof(InputMeshSettings)].As<BakeInputMeshProperties>(); } set { this["InputMeshSettings"] = value; } }
        public BakeMeshAttributeMapsToolProperties Settings { get { return this[nameof(Settings)].As<BakeMeshAttributeMapsToolProperties>(); } set { this["Settings"] = value; } }
        public BakeMeshAttributeMapsResultToolProperties ResultSettings { get { return this[nameof(ResultSettings)].As<BakeMeshAttributeMapsResultToolProperties>(); } set { this["ResultSettings"] = value; } }
    }
    public class BakeMeshAttributeMapsResultToolProperties : InteractiveToolPropertySet
    {
        public BakeMeshAttributeMapsResultToolProperties(nint addr) : base(addr) { }
        public Object Result { get { return this[nameof(Result)]; } set { this[nameof(Result)] = value; } }
    }
    public class BakeMeshAttributeVertexToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BakeMeshAttributeVertexToolBuilder(nint addr) : base(addr) { }
    }
    public class BakeMeshAttributeVertexToolProperties : InteractiveToolPropertySet
    {
        public BakeMeshAttributeVertexToolProperties(nint addr) : base(addr) { }
        public EBakeVertexOutput OutputMode { get { return (EBakeVertexOutput)this[nameof(OutputMode)].GetValue<int>(); } set { this[nameof(OutputMode)].SetValue<int>((int)value); } }
        public int OutputType { get { return this[nameof(OutputType)].GetValue<int>(); } set { this[nameof(OutputType)].SetValue<int>(value); } }
        public int OutputTypeR { get { return this[nameof(OutputTypeR)].GetValue<int>(); } set { this[nameof(OutputTypeR)].SetValue<int>(value); } }
        public int OutputTypeG { get { return this[nameof(OutputTypeG)].GetValue<int>(); } set { this[nameof(OutputTypeG)].SetValue<int>(value); } }
        public int OutputTypeB { get { return this[nameof(OutputTypeB)].GetValue<int>(); } set { this[nameof(OutputTypeB)].SetValue<int>(value); } }
        public int OutputTypeA { get { return this[nameof(OutputTypeA)].GetValue<int>(); } set { this[nameof(OutputTypeA)].SetValue<int>(value); } }
        public EBakeVertexChannel PreviewMode { get { return (EBakeVertexChannel)this[nameof(PreviewMode)].GetValue<int>(); } set { this[nameof(PreviewMode)].SetValue<int>((int)value); } }
        public bool bSplitAtNormalSeams { get { return this[nameof(bSplitAtNormalSeams)].Flag; } set { this[nameof(bSplitAtNormalSeams)].Flag = value; } }
        public bool bSplitAtUVSeams { get { return this[nameof(bSplitAtUVSeams)].Flag; } set { this[nameof(bSplitAtUVSeams)].Flag = value; } }
    }
    public class BakeMeshAttributeVertexTool : BakeMeshAttributeTool
    {
        public BakeMeshAttributeVertexTool(nint addr) : base(addr) { }
        public BakeInputMeshProperties InputMeshSettings { get { return this[nameof(InputMeshSettings)].As<BakeInputMeshProperties>(); } set { this["InputMeshSettings"] = value; } }
        public BakeMeshAttributeVertexToolProperties Settings { get { return this[nameof(Settings)].As<BakeMeshAttributeVertexToolProperties>(); } set { this["Settings"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public MaterialInstanceDynamic PreviewMaterial { get { return this[nameof(PreviewMaterial)].As<MaterialInstanceDynamic>(); } set { this["PreviewMaterial"] = value; } }
        public MaterialInstanceDynamic PreviewAlphaMaterial { get { return this[nameof(PreviewAlphaMaterial)].As<MaterialInstanceDynamic>(); } set { this["PreviewAlphaMaterial"] = value; } }
    }
    public class BakeMultiMeshAttributeMapsToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BakeMultiMeshAttributeMapsToolBuilder(nint addr) : base(addr) { }
    }
    public class BakeMultiMeshAttributeMapsToolProperties : InteractiveToolPropertySet
    {
        public BakeMultiMeshAttributeMapsToolProperties(nint addr) : base(addr) { }
        public int MapTypes { get { return this[nameof(MapTypes)].GetValue<int>(); } set { this[nameof(MapTypes)].SetValue<int>(value); } }
        public Object MapPreview { get { return this[nameof(MapPreview)]; } set { this[nameof(MapPreview)] = value; } }
        public EBakeTextureResolution Resolution { get { return (EBakeTextureResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public EBakeTextureBitDepth BitDepth { get { return (EBakeTextureBitDepth)this[nameof(BitDepth)].GetValue<int>(); } set { this[nameof(BitDepth)].SetValue<int>((int)value); } }
        public EBakeTextureSamplesPerPixel SamplesPerPixel { get { return (EBakeTextureSamplesPerPixel)this[nameof(SamplesPerPixel)].GetValue<int>(); } set { this[nameof(SamplesPerPixel)].SetValue<int>((int)value); } }
        public Texture2D SampleFilterMask { get { return this[nameof(SampleFilterMask)].As<Texture2D>(); } set { this["SampleFilterMask"] = value; } }
        public Array<Object> MapPreviewNamesList { get { return new Array<Object>(this[nameof(MapPreviewNamesList)].Address); } }
        public Array<Object> GetMapPreviewNamesFunc() { return Invoke<Array<Object>>(nameof(GetMapPreviewNamesFunc)); }
    }
    public class BakeMultiMeshInputToolProperties : InteractiveToolPropertySet
    {
        public BakeMultiMeshInputToolProperties(nint addr) : base(addr) { }
        public StaticMesh TargetStaticMesh { get { return this[nameof(TargetStaticMesh)].As<StaticMesh>(); } set { this["TargetStaticMesh"] = value; } }
        public SkeletalMesh TargetSkeletalMesh { get { return this[nameof(TargetSkeletalMesh)].As<SkeletalMesh>(); } set { this["TargetSkeletalMesh"] = value; } }
        public Actor TargetDynamicMesh { get { return this[nameof(TargetDynamicMesh)].As<Actor>(); } set { this["TargetDynamicMesh"] = value; } }
        public Object TargetUVLayer { get { return this[nameof(TargetUVLayer)]; } set { this[nameof(TargetUVLayer)] = value; } }
        public Array<BakeMultiMeshDetailProperties> SourceMeshes { get { return new Array<BakeMultiMeshDetailProperties>(this[nameof(SourceMeshes)].Address); } }
        public float ProjectionDistance { get { return this[nameof(ProjectionDistance)].GetValue<float>(); } set { this[nameof(ProjectionDistance)].SetValue<float>(value); } }
        public Array<Object> TargetUVLayerNamesList { get { return new Array<Object>(this[nameof(TargetUVLayerNamesList)].Address); } }
        public Array<Object> GetTargetUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetTargetUVLayerNamesFunc)); }
    }
    public class BakeMultiMeshAttributeMapsTool : BakeMeshAttributeMapsToolBase
    {
        public BakeMultiMeshAttributeMapsTool(nint addr) : base(addr) { }
        public BakeMultiMeshAttributeMapsToolProperties Settings { get { return this[nameof(Settings)].As<BakeMultiMeshAttributeMapsToolProperties>(); } set { this["Settings"] = value; } }
        public BakeMultiMeshInputToolProperties InputMeshSettings { get { return this[nameof(InputMeshSettings)].As<BakeMultiMeshInputToolProperties>(); } set { this["InputMeshSettings"] = value; } }
        public BakeMeshAttributeMapsResultToolProperties ResultSettings { get { return this[nameof(ResultSettings)].As<BakeMeshAttributeMapsResultToolProperties>(); } set { this["ResultSettings"] = value; } }
    }
    public class BakeRenderCaptureResults : InteractiveToolPropertySet
    {
        public BakeRenderCaptureResults(nint addr) : base(addr) { }
        public Texture2D BaseColorMap { get { return this[nameof(BaseColorMap)].As<Texture2D>(); } set { this["BaseColorMap"] = value; } }
        public Texture2D NormalMap { get { return this[nameof(NormalMap)].As<Texture2D>(); } set { this["NormalMap"] = value; } }
        public Texture2D PackedMRSMap { get { return this[nameof(PackedMRSMap)].As<Texture2D>(); } set { this["PackedMRSMap"] = value; } }
        public Texture2D MetallicMap { get { return this[nameof(MetallicMap)].As<Texture2D>(); } set { this["MetallicMap"] = value; } }
        public Texture2D RoughnessMap { get { return this[nameof(RoughnessMap)].As<Texture2D>(); } set { this["RoughnessMap"] = value; } }
        public Texture2D SpecularMap { get { return this[nameof(SpecularMap)].As<Texture2D>(); } set { this["SpecularMap"] = value; } }
        public Texture2D EmissiveMap { get { return this[nameof(EmissiveMap)].As<Texture2D>(); } set { this["EmissiveMap"] = value; } }
    }
    public class BakeRenderCaptureToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BakeRenderCaptureToolBuilder(nint addr) : base(addr) { }
    }
    public class RenderCaptureProperties : InteractiveToolPropertySet
    {
        public RenderCaptureProperties(nint addr) : base(addr) { }
        public EBakeTextureResolution Resolution { get { return (EBakeTextureResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public bool bBaseColorMap { get { return this[nameof(bBaseColorMap)].Flag; } set { this[nameof(bBaseColorMap)].Flag = value; } }
        public bool bNormalMap { get { return this[nameof(bNormalMap)].Flag; } set { this[nameof(bNormalMap)].Flag = value; } }
        public bool bPackedMRSMap { get { return this[nameof(bPackedMRSMap)].Flag; } set { this[nameof(bPackedMRSMap)].Flag = value; } }
        public bool bMetallicMap { get { return this[nameof(bMetallicMap)].Flag; } set { this[nameof(bMetallicMap)].Flag = value; } }
        public bool bRoughnessMap { get { return this[nameof(bRoughnessMap)].Flag; } set { this[nameof(bRoughnessMap)].Flag = value; } }
        public bool bSpecularMap { get { return this[nameof(bSpecularMap)].Flag; } set { this[nameof(bSpecularMap)].Flag = value; } }
        public bool bEmissiveMap { get { return this[nameof(bEmissiveMap)].Flag; } set { this[nameof(bEmissiveMap)].Flag = value; } }
        public bool bAntiAliasing { get { return this[nameof(bAntiAliasing)].Flag; } set { this[nameof(bAntiAliasing)].Flag = value; } }
        public float CaptureFieldOfView { get { return this[nameof(CaptureFieldOfView)].GetValue<float>(); } set { this[nameof(CaptureFieldOfView)].SetValue<float>(value); } }
        public float NearPlaneDist { get { return this[nameof(NearPlaneDist)].GetValue<float>(); } set { this[nameof(NearPlaneDist)].SetValue<float>(value); } }
        public bool bDeviceDepthMap { get { return this[nameof(bDeviceDepthMap)].Flag; } set { this[nameof(bDeviceDepthMap)].Flag = value; } }
    }
    public class BakeRenderCaptureToolProperties : InteractiveToolPropertySet
    {
        public BakeRenderCaptureToolProperties(nint addr) : base(addr) { }
        public Object MapPreview { get { return this[nameof(MapPreview)]; } set { this[nameof(MapPreview)] = value; } }
        public Array<Object> MapPreviewNamesList { get { return new Array<Object>(this[nameof(MapPreviewNamesList)].Address); } }
        public EBakeTextureSamplesPerPixel SamplesPerPixel { get { return (EBakeTextureSamplesPerPixel)this[nameof(SamplesPerPixel)].GetValue<int>(); } set { this[nameof(SamplesPerPixel)].SetValue<int>((int)value); } }
        public EBakeTextureResolution TextureSize { get { return (EBakeTextureResolution)this[nameof(TextureSize)].GetValue<int>(); } set { this[nameof(TextureSize)].SetValue<int>((int)value); } }
        public float ValidSampleDepthThreshold { get { return this[nameof(ValidSampleDepthThreshold)].GetValue<float>(); } set { this[nameof(ValidSampleDepthThreshold)].SetValue<float>(value); } }
        public Array<Object> GetMapPreviewNamesFunc() { return Invoke<Array<Object>>(nameof(GetMapPreviewNamesFunc)); }
    }
    public class BakeRenderCaptureInputToolProperties : InteractiveToolPropertySet
    {
        public BakeRenderCaptureInputToolProperties(nint addr) : base(addr) { }
        public StaticMesh TargetStaticMesh { get { return this[nameof(TargetStaticMesh)].As<StaticMesh>(); } set { this["TargetStaticMesh"] = value; } }
        public Object TargetUVLayer { get { return this[nameof(TargetUVLayer)]; } set { this[nameof(TargetUVLayer)] = value; } }
        public Array<Object> TargetUVLayerNamesList { get { return new Array<Object>(this[nameof(TargetUVLayerNamesList)].Address); } }
        public Array<Object> GetTargetUVLayerNamesFunc() { return Invoke<Array<Object>>(nameof(GetTargetUVLayerNamesFunc)); }
        public int GetTargetUVLayerIndex() { return Invoke<int>(nameof(GetTargetUVLayerIndex)); }
    }
    public class BakeRenderCaptureTool : BakeMeshAttributeMapsToolBase
    {
        public BakeRenderCaptureTool(nint addr) : base(addr) { }
        public Array<Actor> Actors { get { return new Array<Actor>(this[nameof(Actors)].Address); } }
        public BakeRenderCaptureToolProperties Settings { get { return this[nameof(Settings)].As<BakeRenderCaptureToolProperties>(); } set { this["Settings"] = value; } }
        public RenderCaptureProperties RenderCaptureProperties { get { return this[nameof(RenderCaptureProperties)].As<RenderCaptureProperties>(); } set { this["RenderCaptureProperties"] = value; } }
        public BakeRenderCaptureInputToolProperties InputMeshSettings { get { return this[nameof(InputMeshSettings)].As<BakeRenderCaptureInputToolProperties>(); } set { this["InputMeshSettings"] = value; } }
        public BakeRenderCaptureResults ResultSettings { get { return this[nameof(ResultSettings)].As<BakeRenderCaptureResults>(); } set { this["ResultSettings"] = value; } }
        public Texture2D EmptyEmissiveMap { get { return this[nameof(EmptyEmissiveMap)].As<Texture2D>(); } set { this["EmptyEmissiveMap"] = value; } }
        public Texture2D EmptyPackedMRSMap { get { return this[nameof(EmptyPackedMRSMap)].As<Texture2D>(); } set { this["EmptyPackedMRSMap"] = value; } }
        public Texture2D EmptyRoughnessMap { get { return this[nameof(EmptyRoughnessMap)].As<Texture2D>(); } set { this["EmptyRoughnessMap"] = value; } }
        public Texture2D EmptyMetallicMap { get { return this[nameof(EmptyMetallicMap)].As<Texture2D>(); } set { this["EmptyMetallicMap"] = value; } }
        public Texture2D EmptySpecularMap { get { return this[nameof(EmptySpecularMap)].As<Texture2D>(); } set { this["EmptySpecularMap"] = value; } }
        public MaterialInstanceDynamic PreviewMaterialRC { get { return this[nameof(PreviewMaterialRC)].As<MaterialInstanceDynamic>(); } set { this["PreviewMaterialRC"] = value; } }
        public MaterialInstanceDynamic PreviewMaterialPackedRC { get { return this[nameof(PreviewMaterialPackedRC)].As<MaterialInstanceDynamic>(); } set { this["PreviewMaterialPackedRC"] = value; } }
        public RenderCaptureProperties ComputedRenderCaptureProperties { get { return this[nameof(ComputedRenderCaptureProperties)].As<RenderCaptureProperties>(); } set { this["ComputedRenderCaptureProperties"] = value; } }
    }
    public class BakeTransformToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BakeTransformToolBuilder(nint addr) : base(addr) { }
    }
    public class BakeTransformToolProperties : InteractiveToolPropertySet
    {
        public BakeTransformToolProperties(nint addr) : base(addr) { }
        public bool bBakeRotation { get { return this[nameof(bBakeRotation)].Flag; } set { this[nameof(bBakeRotation)].Flag = value; } }
        public EBakeScaleMethod BakeScale { get { return (EBakeScaleMethod)this[nameof(BakeScale)].GetValue<int>(); } set { this[nameof(BakeScale)].SetValue<int>((int)value); } }
        public bool bRecenterPivot { get { return this[nameof(bRecenterPivot)].Flag; } set { this[nameof(bRecenterPivot)].Flag = value; } }
        public bool bAllowNoScale { get { return this[nameof(bAllowNoScale)].Flag; } set { this[nameof(bAllowNoScale)].Flag = value; } }
    }
    public class BakeTransformTool : MultiSelectionMeshEditingTool
    {
        public BakeTransformTool(nint addr) : base(addr) { }
        public BakeTransformToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<BakeTransformToolProperties>(); } set { this["BasicProperties"] = value; } }
    }
    public class ConvertMeshesToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public ConvertMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class ConvertMeshesToolProperties : InteractiveToolPropertySet
    {
        public ConvertMeshesToolProperties(nint addr) : base(addr) { }
        public bool bTransferMaterials { get { return this[nameof(bTransferMaterials)].Flag; } set { this[nameof(bTransferMaterials)].Flag = value; } }
    }
    public class ConvertMeshesTool : MultiSelectionMeshEditingTool
    {
        public ConvertMeshesTool(nint addr) : base(addr) { }
        public ConvertMeshesToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<ConvertMeshesToolProperties>(); } set { this["BasicProperties"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
    }
    public class ConvertToPolygonsToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public ConvertToPolygonsToolBuilder(nint addr) : base(addr) { }
    }
    public class ConvertToPolygonsToolProperties : InteractiveToolPropertySet
    {
        public ConvertToPolygonsToolProperties(nint addr) : base(addr) { }
        public EConvertToPolygonsMode ConversionMode { get { return (EConvertToPolygonsMode)this[nameof(ConversionMode)].GetValue<int>(); } set { this[nameof(ConversionMode)].SetValue<int>((int)value); } }
        public float AngleTolerance { get { return this[nameof(AngleTolerance)].GetValue<float>(); } set { this[nameof(AngleTolerance)].SetValue<float>(value); } }
        public int NumPoints { get { return this[nameof(NumPoints)].GetValue<int>(); } set { this[nameof(NumPoints)].SetValue<int>(value); } }
        public bool bSplitExisting { get { return this[nameof(bSplitExisting)].Flag; } set { this[nameof(bSplitExisting)].Flag = value; } }
        public bool bNormalWeighted { get { return this[nameof(bNormalWeighted)].Flag; } set { this[nameof(bNormalWeighted)].Flag = value; } }
        public float NormalWeighting { get { return this[nameof(NormalWeighting)].GetValue<float>(); } set { this[nameof(NormalWeighting)].SetValue<float>(value); } }
        public float QuadAdjacencyWeight { get { return this[nameof(QuadAdjacencyWeight)].GetValue<float>(); } set { this[nameof(QuadAdjacencyWeight)].SetValue<float>(value); } }
        public float QuadMetricClamp { get { return this[nameof(QuadMetricClamp)].GetValue<float>(); } set { this[nameof(QuadMetricClamp)].SetValue<float>(value); } }
        public int QuadSearchRounds { get { return this[nameof(QuadSearchRounds)].GetValue<int>(); } set { this[nameof(QuadSearchRounds)].SetValue<int>(value); } }
        public bool bRespectUVSeams { get { return this[nameof(bRespectUVSeams)].Flag; } set { this[nameof(bRespectUVSeams)].Flag = value; } }
        public bool bRespectHardNormals { get { return this[nameof(bRespectHardNormals)].Flag; } set { this[nameof(bRespectHardNormals)].Flag = value; } }
        public int MinGroupSize { get { return this[nameof(MinGroupSize)].GetValue<int>(); } set { this[nameof(MinGroupSize)].SetValue<int>(value); } }
        public bool bCalculateNormals { get { return this[nameof(bCalculateNormals)].Flag; } set { this[nameof(bCalculateNormals)].Flag = value; } }
        public bool bShowGroupColors { get { return this[nameof(bShowGroupColors)].Flag; } set { this[nameof(bShowGroupColors)].Flag = value; } }
    }
    public class OutputPolygroupLayerProperties : InteractiveToolPropertySet
    {
        public OutputPolygroupLayerProperties(nint addr) : base(addr) { }
        public Object GroupLayer { get { return this[nameof(GroupLayer)]; } set { this[nameof(GroupLayer)] = value; } }
        public Array<Object> OptionsList { get { return new Array<Object>(this[nameof(OptionsList)].Address); } }
        public bool bShowNewLayerName { get { return this[nameof(bShowNewLayerName)].Flag; } set { this[nameof(bShowNewLayerName)].Flag = value; } }
        public Object NewLayerName { get { return this[nameof(NewLayerName)]; } set { this[nameof(NewLayerName)] = value; } }
        public Array<Object> GetGroupOptionsList() { return Invoke<Array<Object>>(nameof(GetGroupOptionsList)); }
    }
    public class ConvertToPolygonsOperatorFactory : Object
    {
        public ConvertToPolygonsOperatorFactory(nint addr) : base(addr) { }
        public ConvertToPolygonsTool ConvertToPolygonsTool { get { return this[nameof(ConvertToPolygonsTool)].As<ConvertToPolygonsTool>(); } set { this["ConvertToPolygonsTool"] = value; } }
    }
    public class ConvertToPolygonsTool : SingleSelectionMeshEditingTool
    {
        public ConvertToPolygonsTool(nint addr) : base(addr) { }
        public ConvertToPolygonsToolProperties Settings { get { return this[nameof(Settings)].As<ConvertToPolygonsToolProperties>(); } set { this["Settings"] = value; } }
        public PolygroupLayersProperties CopyFromLayerProperties { get { return this[nameof(CopyFromLayerProperties)].As<PolygroupLayersProperties>(); } set { this["CopyFromLayerProperties"] = value; } }
        public OutputPolygroupLayerProperties OutputProperties { get { return this[nameof(OutputProperties)].As<OutputPolygroupLayerProperties>(); } set { this["OutputProperties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute PreviewCompute { get { return this[nameof(PreviewCompute)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["PreviewCompute"] = value; } }
        public PreviewGeometry PreviewGeometry { get { return this[nameof(PreviewGeometry)].As<PreviewGeometry>(); } set { this["PreviewGeometry"] = value; } }
    }
    public class CubeGridToolBuilder : InteractiveToolWithToolTargetsBuilder
    {
        public CubeGridToolBuilder(nint addr) : base(addr) { }
    }
    public class CubeGridToolProperties : InteractiveToolPropertySet
    {
        public CubeGridToolProperties(nint addr) : base(addr) { }
        public Vector GridFrameOrigin { get { return this[nameof(GridFrameOrigin)].As<Vector>(); } set { this["GridFrameOrigin"] = value; } }
        public Rotator GridFrameOrientation { get { return this[nameof(GridFrameOrientation)].As<Rotator>(); } set { this["GridFrameOrientation"] = value; } }
        public bool bShowGizmo { get { return this[nameof(bShowGizmo)].Flag; } set { this[nameof(bShowGizmo)].Flag = value; } }
        public byte GridPower { get { return this[nameof(GridPower)].GetValue<byte>(); } set { this[nameof(GridPower)].SetValue<byte>(value); } }
        public double CurrentBlockSize { get { return this[nameof(CurrentBlockSize)].GetValue<double>(); } set { this[nameof(CurrentBlockSize)].SetValue<double>(value); } }
        public int BlocksPerStep { get { return this[nameof(BlocksPerStep)].GetValue<int>(); } set { this[nameof(BlocksPerStep)].SetValue<int>(value); } }
        public bool bPowerOfTwoBlockSizes { get { return this[nameof(bPowerOfTwoBlockSizes)].Flag; } set { this[nameof(bPowerOfTwoBlockSizes)].Flag = value; } }
        public double BlockBaseSize { get { return this[nameof(BlockBaseSize)].GetValue<double>(); } set { this[nameof(BlockBaseSize)].SetValue<double>(value); } }
        public bool bCrosswiseDiagonal { get { return this[nameof(bCrosswiseDiagonal)].Flag; } set { this[nameof(bCrosswiseDiagonal)].Flag = value; } }
        public bool bKeepSideGroups { get { return this[nameof(bKeepSideGroups)].Flag; } set { this[nameof(bKeepSideGroups)].Flag = value; } }
        public double PlaneTolerance { get { return this[nameof(PlaneTolerance)].GetValue<double>(); } set { this[nameof(PlaneTolerance)].SetValue<double>(value); } }
        public bool bHitUnrelatedGeometry { get { return this[nameof(bHitUnrelatedGeometry)].Flag; } set { this[nameof(bHitUnrelatedGeometry)].Flag = value; } }
        public bool bHitGridGroundPlaneIfCloser { get { return this[nameof(bHitGridGroundPlaneIfCloser)].Flag; } set { this[nameof(bHitGridGroundPlaneIfCloser)].Flag = value; } }
        public ECubeGridToolFaceSelectionMode FaceSelectionMode { get { return (ECubeGridToolFaceSelectionMode)this[nameof(FaceSelectionMode)].GetValue<int>(); } set { this[nameof(FaceSelectionMode)].SetValue<int>((int)value); } }
        public Object ToggleCornerMode { get { return this[nameof(ToggleCornerMode)]; } set { this[nameof(ToggleCornerMode)] = value; } }
        public Object PushPull { get { return this[nameof(PushPull)]; } set { this[nameof(PushPull)] = value; } }
        public Object ResizeGrid { get { return this[nameof(ResizeGrid)]; } set { this[nameof(ResizeGrid)] = value; } }
        public Object SlideSelection { get { return this[nameof(SlideSelection)]; } set { this[nameof(SlideSelection)] = value; } }
        public Object FlipSelection { get { return this[nameof(FlipSelection)]; } set { this[nameof(FlipSelection)] = value; } }
        public Object GridGizmo { get { return this[nameof(GridGizmo)]; } set { this[nameof(GridGizmo)] = value; } }
        public Object QuickShiftGizmo { get { return this[nameof(QuickShiftGizmo)]; } set { this[nameof(QuickShiftGizmo)] = value; } }
        public Object AlignGizmo { get { return this[nameof(AlignGizmo)]; } set { this[nameof(AlignGizmo)] = value; } }
        public bool bInCornerMode { get { return this[nameof(bInCornerMode)].Flag; } set { this[nameof(bInCornerMode)].Flag = value; } }
        public bool bAllowedToEditGrid { get { return this[nameof(bAllowedToEditGrid)].Flag; } set { this[nameof(bAllowedToEditGrid)].Flag = value; } }
    }
    public class CubeGridToolActions : InteractiveToolPropertySet
    {
        public CubeGridToolActions(nint addr) : base(addr) { }
        public Actor GridSourceActor { get { return this[nameof(GridSourceActor)].As<Actor>(); } set { this["GridSourceActor"] = value; } }
        public void SlideForward() { Invoke(nameof(SlideForward)); }
        public void SlideBack() { Invoke(nameof(SlideBack)); }
        public void ResetGridFromActor() { Invoke(nameof(ResetGridFromActor)); }
        public void Push() { Invoke(nameof(Push)); }
        public void Pull() { Invoke(nameof(Pull)); }
        public void Flip() { Invoke(nameof(Flip)); }
        public void CornerMode() { Invoke(nameof(CornerMode)); }
    }
    public class CubeGridDuringActivityActions : InteractiveToolPropertySet
    {
        public CubeGridDuringActivityActions(nint addr) : base(addr) { }
        public void Done() { Invoke(nameof(Done)); }
        public void Cancel() { Invoke(nameof(Cancel)); }
    }
    public class CubeGridTool : InteractiveTool
    {
        public CubeGridTool(nint addr) : base(addr) { }
        public CombinedTransformGizmo GridGizmo { get { return this[nameof(GridGizmo)].As<CombinedTransformGizmo>(); } set { this["GridGizmo"] = value; } }
        public DragAlignmentMechanic GridGizmoAlignmentMechanic { get { return this[nameof(GridGizmoAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["GridGizmoAlignmentMechanic"] = value; } }
        public TransformProxy GridGizmoTransformProxy { get { return this[nameof(GridGizmoTransformProxy)].As<TransformProxy>(); } set { this["GridGizmoTransformProxy"] = value; } }
        public PreviewGeometry LineSets { get { return this[nameof(LineSets)].As<PreviewGeometry>(); } set { this["LineSets"] = value; } }
        public ClickDragInputBehavior ClickDragBehavior { get { return this[nameof(ClickDragBehavior)].As<ClickDragInputBehavior>(); } set { this["ClickDragBehavior"] = value; } }
        public MouseHoverBehavior HoverBehavior { get { return this[nameof(HoverBehavior)].As<MouseHoverBehavior>(); } set { this["HoverBehavior"] = value; } }
        public LocalSingleClickInputBehavior CtrlMiddleClickBehavior { get { return this[nameof(CtrlMiddleClickBehavior)].As<LocalSingleClickInputBehavior>(); } set { this["CtrlMiddleClickBehavior"] = value; } }
        public LocalClickDragInputBehavior MiddleClickDragBehavior { get { return this[nameof(MiddleClickDragBehavior)].As<LocalClickDragInputBehavior>(); } set { this["MiddleClickDragBehavior"] = value; } }
        public CubeGridToolProperties Settings { get { return this[nameof(Settings)].As<CubeGridToolProperties>(); } set { this["Settings"] = value; } }
        public CubeGridToolActions ToolActions { get { return this[nameof(ToolActions)].As<CubeGridToolActions>(); } set { this["ToolActions"] = value; } }
        public CubeGridDuringActivityActions DuringActivityActions { get { return this[nameof(DuringActivityActions)].As<CubeGridDuringActivityActions>(); } set { this["DuringActivityActions"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public ToolTarget Target { get { return this[nameof(Target)].As<ToolTarget>(); } set { this["Target"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class DeformMeshPolygonsToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public DeformMeshPolygonsToolBuilder(nint addr) : base(addr) { }
    }
    public class DeformMeshPolygonsTransformProperties : InteractiveToolPropertySet
    {
        public DeformMeshPolygonsTransformProperties(nint addr) : base(addr) { }
        public EGroupTopologyDeformationStrategy DeformationStrategy { get { return (EGroupTopologyDeformationStrategy)this[nameof(DeformationStrategy)].GetValue<int>(); } set { this[nameof(DeformationStrategy)].SetValue<int>((int)value); } }
        public EQuickTransformerMode TransformMode { get { return (EQuickTransformerMode)this[nameof(TransformMode)].GetValue<int>(); } set { this[nameof(TransformMode)].SetValue<int>((int)value); } }
        public bool bSelectFaces { get { return this[nameof(bSelectFaces)].Flag; } set { this[nameof(bSelectFaces)].Flag = value; } }
        public bool bSelectEdges { get { return this[nameof(bSelectEdges)].Flag; } set { this[nameof(bSelectEdges)].Flag = value; } }
        public bool bSelectVertices { get { return this[nameof(bSelectVertices)].Flag; } set { this[nameof(bSelectVertices)].Flag = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public EWeightScheme SelectedWeightScheme { get { return (EWeightScheme)this[nameof(SelectedWeightScheme)].GetValue<int>(); } set { this[nameof(SelectedWeightScheme)].SetValue<int>((int)value); } }
        public double HandleWeight { get { return this[nameof(HandleWeight)].GetValue<double>(); } set { this[nameof(HandleWeight)].SetValue<double>(value); } }
        public bool bPostFixHandles { get { return this[nameof(bPostFixHandles)].Flag; } set { this[nameof(bPostFixHandles)].Flag = value; } }
    }
    public class DeformMeshPolygonsTool : MeshSurfacePointTool
    {
        public DeformMeshPolygonsTool(nint addr) : base(addr) { }
        public InternalToolFrameworkActor PreviewMeshActor { get { return this[nameof(PreviewMeshActor)].As<InternalToolFrameworkActor>(); } set { this["PreviewMeshActor"] = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
        public DeformMeshPolygonsTransformProperties TransformProps { get { return this[nameof(TransformProps)].As<DeformMeshPolygonsTransformProperties>(); } set { this["TransformProps"] = value; } }
    }
    public class DisplaceMeshCommonProperties : InteractiveToolPropertySet
    {
        public DisplaceMeshCommonProperties(nint addr) : base(addr) { }
        public EDisplaceMeshToolDisplaceType DisplacementType { get { return (EDisplaceMeshToolDisplaceType)this[nameof(DisplacementType)].GetValue<int>(); } set { this[nameof(DisplacementType)].SetValue<int>((int)value); } }
        public float DisplaceIntensity { get { return this[nameof(DisplaceIntensity)].GetValue<float>(); } set { this[nameof(DisplaceIntensity)].SetValue<float>(value); } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public EDisplaceMeshToolSubdivisionType SubdivisionType { get { return (EDisplaceMeshToolSubdivisionType)this[nameof(SubdivisionType)].GetValue<int>(); } set { this[nameof(SubdivisionType)].SetValue<int>((int)value); } }
        public int Subdivisions { get { return this[nameof(Subdivisions)].GetValue<int>(); } set { this[nameof(Subdivisions)].SetValue<int>(value); } }
        public Object WeightMap { get { return this[nameof(WeightMap)]; } set { this[nameof(WeightMap)] = value; } }
        public Array<Object> WeightMapsList { get { return new Array<Object>(this[nameof(WeightMapsList)].Address); } }
        public bool bInvertWeightMap { get { return this[nameof(bInvertWeightMap)].Flag; } set { this[nameof(bInvertWeightMap)].Flag = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public bool bDisableSizeWarning { get { return this[nameof(bDisableSizeWarning)].Flag; } set { this[nameof(bDisableSizeWarning)].Flag = value; } }
        public Array<Object> GetWeightMapsFunc() { return Invoke<Array<Object>>(nameof(GetWeightMapsFunc)); }
    }
    public class SelectiveTessellationProperties : InteractiveToolPropertySet
    {
        public SelectiveTessellationProperties(nint addr) : base(addr) { }
        public EDisplaceMeshToolTriangleSelectionType SelectionType { get { return (EDisplaceMeshToolTriangleSelectionType)this[nameof(SelectionType)].GetValue<int>(); } set { this[nameof(SelectionType)].SetValue<int>((int)value); } }
        public Object ActiveMaterial { get { return this[nameof(ActiveMaterial)]; } set { this[nameof(ActiveMaterial)] = value; } }
        public Array<Object> MaterialIDList { get { return new Array<Object>(this[nameof(MaterialIDList)].Address); } }
        public Array<Object> GetMaterialIDsFunc() { return Invoke<Array<Object>>(nameof(GetMaterialIDsFunc)); }
    }
    public class DisplaceMeshTextureMapProperties : InteractiveToolPropertySet
    {
        public DisplaceMeshTextureMapProperties(nint addr) : base(addr) { }
        public Texture2D DisplacementMap { get { return this[nameof(DisplacementMap)].As<Texture2D>(); } set { this["DisplacementMap"] = value; } }
        public EDisplaceMeshToolChannelType Channel { get { return (EDisplaceMeshToolChannelType)this[nameof(Channel)].GetValue<int>(); } set { this[nameof(Channel)].SetValue<int>((int)value); } }
        public float DisplacementMapBaseValue { get { return this[nameof(DisplacementMapBaseValue)].GetValue<float>(); } set { this[nameof(DisplacementMapBaseValue)].SetValue<float>(value); } }
        public Vector2D UVScale { get { return this[nameof(UVScale)].As<Vector2D>(); } set { this["UVScale"] = value; } }
        public Vector2D UVOffset { get { return this[nameof(UVOffset)].As<Vector2D>(); } set { this["UVOffset"] = value; } }
        public bool bApplyAdjustmentCurve { get { return this[nameof(bApplyAdjustmentCurve)].Flag; } set { this[nameof(bApplyAdjustmentCurve)].Flag = value; } }
        public CurveFloat AdjustmentCurve { get { return this[nameof(AdjustmentCurve)].As<CurveFloat>(); } set { this["AdjustmentCurve"] = value; } }
        public bool bRecalcNormals { get { return this[nameof(bRecalcNormals)].Flag; } set { this[nameof(bRecalcNormals)].Flag = value; } }
    }
    public class DisplaceMeshDirectionalFilterProperties : InteractiveToolPropertySet
    {
        public DisplaceMeshDirectionalFilterProperties(nint addr) : base(addr) { }
        public bool bEnableFilter { get { return this[nameof(bEnableFilter)].Flag; } set { this[nameof(bEnableFilter)].Flag = value; } }
        public Vector FilterDirection { get { return this[nameof(FilterDirection)].As<Vector>(); } set { this["FilterDirection"] = value; } }
        public float FilterWidth { get { return this[nameof(FilterWidth)].GetValue<float>(); } set { this[nameof(FilterWidth)].SetValue<float>(value); } }
    }
    public class DisplaceMeshPerlinNoiseProperties : InteractiveToolPropertySet
    {
        public DisplaceMeshPerlinNoiseProperties(nint addr) : base(addr) { }
        public Array<PerlinLayerProperties> PerlinLayerProperties { get { return new Array<PerlinLayerProperties>(this[nameof(PerlinLayerProperties)].Address); } }
    }
    public class DisplaceMeshSineWaveProperties : InteractiveToolPropertySet
    {
        public DisplaceMeshSineWaveProperties(nint addr) : base(addr) { }
        public float SineWaveFrequency { get { return this[nameof(SineWaveFrequency)].GetValue<float>(); } set { this[nameof(SineWaveFrequency)].SetValue<float>(value); } }
        public float SineWavePhaseShift { get { return this[nameof(SineWavePhaseShift)].GetValue<float>(); } set { this[nameof(SineWavePhaseShift)].SetValue<float>(value); } }
        public Vector SineWaveDirection { get { return this[nameof(SineWaveDirection)].As<Vector>(); } set { this["SineWaveDirection"] = value; } }
    }
    public class DisplaceMeshToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public DisplaceMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class DisplaceMeshTool : SingleSelectionMeshEditingTool
    {
        public DisplaceMeshTool(nint addr) : base(addr) { }
        public DisplaceMeshCommonProperties CommonProperties { get { return this[nameof(CommonProperties)].As<DisplaceMeshCommonProperties>(); } set { this["CommonProperties"] = value; } }
        public DisplaceMeshDirectionalFilterProperties DirectionalFilterProperties { get { return this[nameof(DirectionalFilterProperties)].As<DisplaceMeshDirectionalFilterProperties>(); } set { this["DirectionalFilterProperties"] = value; } }
        public DisplaceMeshTextureMapProperties TextureMapProperties { get { return this[nameof(TextureMapProperties)].As<DisplaceMeshTextureMapProperties>(); } set { this["TextureMapProperties"] = value; } }
        public DisplaceMeshPerlinNoiseProperties NoiseProperties { get { return this[nameof(NoiseProperties)].As<DisplaceMeshPerlinNoiseProperties>(); } set { this["NoiseProperties"] = value; } }
        public DisplaceMeshSineWaveProperties SineWaveProperties { get { return this[nameof(SineWaveProperties)].As<DisplaceMeshSineWaveProperties>(); } set { this["SineWaveProperties"] = value; } }
        public SelectiveTessellationProperties SelectiveTessellationProperties { get { return this[nameof(SelectiveTessellationProperties)].As<SelectiveTessellationProperties>(); } set { this["SelectiveTessellationProperties"] = value; } }
        public CurveFloat ActiveContrastCurveTarget { get { return this[nameof(ActiveContrastCurveTarget)].As<CurveFloat>(); } set { this["ActiveContrastCurveTarget"] = value; } }
        public InternalToolFrameworkActor PreviewMeshActor { get { return this[nameof(PreviewMeshActor)].As<InternalToolFrameworkActor>(); } set { this["PreviewMeshActor"] = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
    }
    public class DrawPolyPathToolBuilder : MeshSurfacePointToolBuilder
    {
        public DrawPolyPathToolBuilder(nint addr) : base(addr) { }
    }
    public class DrawPolyPathProperties : InteractiveToolPropertySet
    {
        public DrawPolyPathProperties(nint addr) : base(addr) { }
        public EDrawPolyPathWidthMode WidthMode { get { return (EDrawPolyPathWidthMode)this[nameof(WidthMode)].GetValue<int>(); } set { this[nameof(WidthMode)].SetValue<int>((int)value); } }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public bool bRoundedCorners { get { return this[nameof(bRoundedCorners)].Flag; } set { this[nameof(bRoundedCorners)].Flag = value; } }
        public EDrawPolyPathRadiusMode RadiusMode { get { return (EDrawPolyPathRadiusMode)this[nameof(RadiusMode)].GetValue<int>(); } set { this[nameof(RadiusMode)].SetValue<int>((int)value); } }
        public float CornerRadius { get { return this[nameof(CornerRadius)].GetValue<float>(); } set { this[nameof(CornerRadius)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public bool bSinglePolyGroup { get { return this[nameof(bSinglePolyGroup)].Flag; } set { this[nameof(bSinglePolyGroup)].Flag = value; } }
        public EDrawPolyPathExtrudeMode ExtrudeMode { get { return (EDrawPolyPathExtrudeMode)this[nameof(ExtrudeMode)].GetValue<int>(); } set { this[nameof(ExtrudeMode)].SetValue<int>((int)value); } }
        public float ExtrudeHeight { get { return this[nameof(ExtrudeHeight)].GetValue<float>(); } set { this[nameof(ExtrudeHeight)].SetValue<float>(value); } }
        public float RampStartRatio { get { return this[nameof(RampStartRatio)].GetValue<float>(); } set { this[nameof(RampStartRatio)].SetValue<float>(value); } }
    }
    public class DrawPolyPathExtrudeProperties : InteractiveToolPropertySet
    {
        public DrawPolyPathExtrudeProperties(nint addr) : base(addr) { }
        public EDrawPolyPathExtrudeDirection Direction { get { return (EDrawPolyPathExtrudeDirection)this[nameof(Direction)].GetValue<int>(); } set { this[nameof(Direction)].SetValue<int>((int)value); } }
    }
    public class DrawPolyPathTool : InteractiveTool
    {
        public DrawPolyPathTool(nint addr) : base(addr) { }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public DrawPolyPathProperties TransformProps { get { return this[nameof(TransformProps)].As<DrawPolyPathProperties>(); } set { this["TransformProps"] = value; } }
        public DrawPolyPathExtrudeProperties ExtrudeProperties { get { return this[nameof(ExtrudeProperties)].As<DrawPolyPathExtrudeProperties>(); } set { this["ExtrudeProperties"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
        public PolyEditPreviewMesh EditPreview { get { return this[nameof(EditPreview)].As<PolyEditPreviewMesh>(); } set { this["EditPreview"] = value; } }
        public PlaneDistanceFromHitMechanic ExtrudeHeightMechanic { get { return this[nameof(ExtrudeHeightMechanic)].As<PlaneDistanceFromHitMechanic>(); } set { this["ExtrudeHeightMechanic"] = value; } }
        public SpatialCurveDistanceMechanic CurveDistMechanic { get { return this[nameof(CurveDistMechanic)].As<SpatialCurveDistanceMechanic>(); } set { this["CurveDistMechanic"] = value; } }
        public CollectSurfacePathMechanic SurfacePathMechanic { get { return this[nameof(SurfacePathMechanic)].As<CollectSurfacePathMechanic>(); } set { this["SurfacePathMechanic"] = value; } }
    }
    public class DynamicMeshBrushTool : BaseBrushTool
    {
        public DynamicMeshBrushTool(nint addr) : base(addr) { }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
    }
    public class DynamicMeshSculptToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public DynamicMeshSculptToolBuilder(nint addr) : base(addr) { }
    }
    public class DynamicMeshBrushProperties : InteractiveToolPropertySet
    {
        public DynamicMeshBrushProperties(nint addr) : base(addr) { }
        public BrushToolRadius BrushSize { get { return this[nameof(BrushSize)].As<BrushToolRadius>(); } set { this["BrushSize"] = value; } }
        public float BrushFalloffAmount { get { return this[nameof(BrushFalloffAmount)].GetValue<float>(); } set { this[nameof(BrushFalloffAmount)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
    }
    public class DynamicMeshBrushSculptProperties : InteractiveToolPropertySet
    {
        public DynamicMeshBrushSculptProperties(nint addr) : base(addr) { }
        public bool bIsRemeshingEnabled { get { return this[nameof(bIsRemeshingEnabled)].Flag; } set { this[nameof(bIsRemeshingEnabled)].Flag = value; } }
        public EDynamicMeshSculptBrushType PrimaryBrushType { get { return (EDynamicMeshSculptBrushType)this[nameof(PrimaryBrushType)].GetValue<int>(); } set { this[nameof(PrimaryBrushType)].SetValue<int>((int)value); } }
        public float PrimaryBrushSpeed { get { return this[nameof(PrimaryBrushSpeed)].GetValue<float>(); } set { this[nameof(PrimaryBrushSpeed)].SetValue<float>(value); } }
        public bool bPreserveUVFlow { get { return this[nameof(bPreserveUVFlow)].Flag; } set { this[nameof(bPreserveUVFlow)].Flag = value; } }
        public bool bFreezeTarget { get { return this[nameof(bFreezeTarget)].Flag; } set { this[nameof(bFreezeTarget)].Flag = value; } }
        public float SmoothBrushSpeed { get { return this[nameof(SmoothBrushSpeed)].GetValue<float>(); } set { this[nameof(SmoothBrushSpeed)].SetValue<float>(value); } }
        public bool bDetailPreservingSmooth { get { return this[nameof(bDetailPreservingSmooth)].Flag; } set { this[nameof(bDetailPreservingSmooth)].Flag = value; } }
    }
    public class DynamicSculptToolActions : InteractiveToolPropertySet
    {
        public DynamicSculptToolActions(nint addr) : base(addr) { }
        public void DiscardAttributes() { Invoke(nameof(DiscardAttributes)); }
    }
    public class BrushRemeshProperties : RemeshProperties
    {
        public BrushRemeshProperties(nint addr) : base(addr) { }
        public bool bEnableRemeshing { get { return this[nameof(bEnableRemeshing)].Flag; } set { this[nameof(bEnableRemeshing)].Flag = value; } }
        public int TriangleSize { get { return this[nameof(TriangleSize)].GetValue<int>(); } set { this[nameof(TriangleSize)].SetValue<int>(value); } }
        public int PreserveDetail { get { return this[nameof(PreserveDetail)].GetValue<int>(); } set { this[nameof(PreserveDetail)].SetValue<int>(value); } }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
    }
    public class FixedPlaneBrushProperties : InteractiveToolPropertySet
    {
        public FixedPlaneBrushProperties(nint addr) : base(addr) { }
        public bool bPropertySetEnabled { get { return this[nameof(bPropertySetEnabled)].Flag; } set { this[nameof(bPropertySetEnabled)].Flag = value; } }
        public bool bShowGizmo { get { return this[nameof(bShowGizmo)].Flag; } set { this[nameof(bShowGizmo)].Flag = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class DynamicMeshSculptTool : MeshSurfacePointTool
    {
        public DynamicMeshSculptTool(nint addr) : base(addr) { }
        public DynamicMeshBrushProperties BrushProperties { get { return this[nameof(BrushProperties)].As<DynamicMeshBrushProperties>(); } set { this["BrushProperties"] = value; } }
        public DynamicMeshBrushSculptProperties SculptProperties { get { return this[nameof(SculptProperties)].As<DynamicMeshBrushSculptProperties>(); } set { this["SculptProperties"] = value; } }
        public SculptMaxBrushProperties SculptMaxBrushProperties { get { return this[nameof(SculptMaxBrushProperties)].As<SculptMaxBrushProperties>(); } set { this["SculptMaxBrushProperties"] = value; } }
        public KelvinBrushProperties KelvinBrushProperties { get { return this[nameof(KelvinBrushProperties)].As<KelvinBrushProperties>(); } set { this["KelvinBrushProperties"] = value; } }
        public BrushRemeshProperties RemeshProperties { get { return this[nameof(RemeshProperties)].As<BrushRemeshProperties>(); } set { this["RemeshProperties"] = value; } }
        public FixedPlaneBrushProperties GizmoProperties { get { return this[nameof(GizmoProperties)].As<FixedPlaneBrushProperties>(); } set { this["GizmoProperties"] = value; } }
        public MeshEditingViewProperties ViewProperties { get { return this[nameof(ViewProperties)].As<MeshEditingViewProperties>(); } set { this["ViewProperties"] = value; } }
        public DynamicSculptToolActions SculptToolActions { get { return this[nameof(SculptToolActions)].As<DynamicSculptToolActions>(); } set { this["SculptToolActions"] = value; } }
        public BrushStampIndicator BrushIndicator { get { return this[nameof(BrushIndicator)].As<BrushStampIndicator>(); } set { this["BrushIndicator"] = value; } }
        public MaterialInstanceDynamic BrushIndicatorMaterial { get { return this[nameof(BrushIndicatorMaterial)].As<MaterialInstanceDynamic>(); } set { this["BrushIndicatorMaterial"] = value; } }
        public PreviewMesh BrushIndicatorMesh { get { return this[nameof(BrushIndicatorMesh)].As<PreviewMesh>(); } set { this["BrushIndicatorMesh"] = value; } }
        public OctreeDynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<OctreeDynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
        public MaterialInstanceDynamic ActiveOverrideMaterial { get { return this[nameof(ActiveOverrideMaterial)].As<MaterialInstanceDynamic>(); } set { this["ActiveOverrideMaterial"] = value; } }
        public CombinedTransformGizmo PlaneTransformGizmo { get { return this[nameof(PlaneTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PlaneTransformGizmo"] = value; } }
        public TransformProxy PlaneTransformProxy { get { return this[nameof(PlaneTransformProxy)].As<TransformProxy>(); } set { this["PlaneTransformProxy"] = value; } }
    }
    public class EditNormalsToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public EditNormalsToolBuilder(nint addr) : base(addr) { }
    }
    public class EditNormalsToolProperties : InteractiveToolPropertySet
    {
        public EditNormalsToolProperties(nint addr) : base(addr) { }
        public bool bRecomputeNormals { get { return this[nameof(bRecomputeNormals)].Flag; } set { this[nameof(bRecomputeNormals)].Flag = value; } }
        public ENormalCalculationMethod NormalCalculationMethod { get { return (ENormalCalculationMethod)this[nameof(NormalCalculationMethod)].GetValue<int>(); } set { this[nameof(NormalCalculationMethod)].SetValue<int>((int)value); } }
        public bool bFixInconsistentNormals { get { return this[nameof(bFixInconsistentNormals)].Flag; } set { this[nameof(bFixInconsistentNormals)].Flag = value; } }
        public bool bInvertNormals { get { return this[nameof(bInvertNormals)].Flag; } set { this[nameof(bInvertNormals)].Flag = value; } }
        public ESplitNormalMethod SplitNormalMethod { get { return (ESplitNormalMethod)this[nameof(SplitNormalMethod)].GetValue<int>(); } set { this[nameof(SplitNormalMethod)].SetValue<int>((int)value); } }
        public float SharpEdgeAngleThreshold { get { return this[nameof(SharpEdgeAngleThreshold)].GetValue<float>(); } set { this[nameof(SharpEdgeAngleThreshold)].SetValue<float>(value); } }
        public bool bAllowSharpVertices { get { return this[nameof(bAllowSharpVertices)].Flag; } set { this[nameof(bAllowSharpVertices)].Flag = value; } }
    }
    public class EditNormalsAdvancedProperties : InteractiveToolPropertySet
    {
        public EditNormalsAdvancedProperties(nint addr) : base(addr) { }
    }
    public class EditNormalsOperatorFactory : Object
    {
        public EditNormalsOperatorFactory(nint addr) : base(addr) { }
        public EditNormalsTool Tool { get { return this[nameof(Tool)].As<EditNormalsTool>(); } set { this["Tool"] = value; } }
    }
    public class EditNormalsTool : MultiSelectionMeshEditingTool
    {
        public EditNormalsTool(nint addr) : base(addr) { }
        public EditNormalsToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<EditNormalsToolProperties>(); } set { this["BasicProperties"] = value; } }
        public EditNormalsAdvancedProperties AdvancedProperties { get { return this[nameof(AdvancedProperties)].As<EditNormalsAdvancedProperties>(); } set { this["AdvancedProperties"] = value; } }
        public PolygroupLayersProperties PolygroupLayerProperties { get { return this[nameof(PolygroupLayerProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayerProperties"] = value; } }
        public Array<MeshOpPreviewWithBackgroundCompute> Previews { get { return new Array<MeshOpPreviewWithBackgroundCompute>(this[nameof(Previews)].Address); } }
    }
    public class EditPivotToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public EditPivotToolBuilder(nint addr) : base(addr) { }
    }
    public class EditPivotToolProperties : InteractiveToolPropertySet
    {
        public EditPivotToolProperties(nint addr) : base(addr) { }
        public bool bEnableSnapDragging { get { return this[nameof(bEnableSnapDragging)].Flag; } set { this[nameof(bEnableSnapDragging)].Flag = value; } }
        public EEditPivotSnapDragRotationMode RotationMode { get { return (EEditPivotSnapDragRotationMode)this[nameof(RotationMode)].GetValue<int>(); } set { this[nameof(RotationMode)].SetValue<int>((int)value); } }
    }
    public class EditPivotToolActionPropertySet : InteractiveToolPropertySet
    {
        public EditPivotToolActionPropertySet(nint addr) : base(addr) { }
        public bool bUseWorldBox { get { return this[nameof(bUseWorldBox)].Flag; } set { this[nameof(bUseWorldBox)].Flag = value; } }
        public void WorldOrigin() { Invoke(nameof(WorldOrigin)); }
        public void Top() { Invoke(nameof(Top)); }
        public void Right() { Invoke(nameof(Right)); }
        public void Left() { Invoke(nameof(Left)); }
        public void Front() { Invoke(nameof(Front)); }
        public void Center() { Invoke(nameof(Center)); }
        public void Bottom() { Invoke(nameof(Bottom)); }
        public void Back() { Invoke(nameof(Back)); }
    }
    public class EditPivotTool : MultiSelectionMeshEditingTool
    {
        public EditPivotTool(nint addr) : base(addr) { }
        public EditPivotToolProperties TransformProps { get { return this[nameof(TransformProps)].As<EditPivotToolProperties>(); } set { this["TransformProps"] = value; } }
        public EditPivotToolActionPropertySet EditPivotActions { get { return this[nameof(EditPivotActions)].As<EditPivotToolActionPropertySet>(); } set { this["EditPivotActions"] = value; } }
        public Array<EditPivotTarget> ActiveGizmos { get { return new Array<EditPivotTarget>(this[nameof(ActiveGizmos)].Address); } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
    }
    public class EditUVIslandsToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public EditUVIslandsToolBuilder(nint addr) : base(addr) { }
    }
    public class EditUVIslandsTool : MeshSurfacePointTool
    {
        public EditUVIslandsTool(nint addr) : base(addr) { }
        public ExistingMeshMaterialProperties MaterialSettings { get { return this[nameof(MaterialSettings)].As<ExistingMeshMaterialProperties>(); } set { this["MaterialSettings"] = value; } }
        public MaterialInstanceDynamic CheckerMaterial { get { return this[nameof(CheckerMaterial)].As<MaterialInstanceDynamic>(); } set { this["CheckerMaterial"] = value; } }
        public InternalToolFrameworkActor PreviewMeshActor { get { return this[nameof(PreviewMeshActor)].As<InternalToolFrameworkActor>(); } set { this["PreviewMeshActor"] = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
        public PolygonSelectionMechanic SelectionMechanic { get { return this[nameof(SelectionMechanic)].As<PolygonSelectionMechanic>(); } set { this["SelectionMechanic"] = value; } }
        public MultiTransformer MultiTransformer { get { return this[nameof(MultiTransformer)].As<MultiTransformer>(); } set { this["MultiTransformer"] = value; } }
    }
    public class HoleFillToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public HoleFillToolBuilder(nint addr) : base(addr) { }
    }
    public class SmoothHoleFillProperties : InteractiveToolPropertySet
    {
        public SmoothHoleFillProperties(nint addr) : base(addr) { }
        public bool bConstrainToHoleInterior { get { return this[nameof(bConstrainToHoleInterior)].Flag; } set { this[nameof(bConstrainToHoleInterior)].Flag = value; } }
        public int RemeshingExteriorRegionWidth { get { return this[nameof(RemeshingExteriorRegionWidth)].GetValue<int>(); } set { this[nameof(RemeshingExteriorRegionWidth)].SetValue<int>(value); } }
        public int SmoothingExteriorRegionWidth { get { return this[nameof(SmoothingExteriorRegionWidth)].GetValue<int>(); } set { this[nameof(SmoothingExteriorRegionWidth)].SetValue<int>(value); } }
        public int SmoothingInteriorRegionWidth { get { return this[nameof(SmoothingInteriorRegionWidth)].GetValue<int>(); } set { this[nameof(SmoothingInteriorRegionWidth)].SetValue<int>(value); } }
        public float InteriorSmoothness { get { return this[nameof(InteriorSmoothness)].GetValue<float>(); } set { this[nameof(InteriorSmoothness)].SetValue<float>(value); } }
        public double FillDensityScalar { get { return this[nameof(FillDensityScalar)].GetValue<double>(); } set { this[nameof(FillDensityScalar)].SetValue<double>(value); } }
        public bool bProjectDuringRemesh { get { return this[nameof(bProjectDuringRemesh)].Flag; } set { this[nameof(bProjectDuringRemesh)].Flag = value; } }
    }
    public class HoleFillToolProperties : InteractiveToolPropertySet
    {
        public HoleFillToolProperties(nint addr) : base(addr) { }
        public EHoleFillOpFillType FillType { get { return (EHoleFillOpFillType)this[nameof(FillType)].GetValue<int>(); } set { this[nameof(FillType)].SetValue<int>((int)value); } }
        public bool bRemoveIsolatedTriangles { get { return this[nameof(bRemoveIsolatedTriangles)].Flag; } set { this[nameof(bRemoveIsolatedTriangles)].Flag = value; } }
        public bool bQuickFillSmallHoles { get { return this[nameof(bQuickFillSmallHoles)].Flag; } set { this[nameof(bQuickFillSmallHoles)].Flag = value; } }
    }
    public class HoleFillToolActions : InteractiveToolPropertySet
    {
        public HoleFillToolActions(nint addr) : base(addr) { }
        public void SelectAll() { Invoke(nameof(SelectAll)); }
        public void Clear() { Invoke(nameof(Clear)); }
    }
    public class HoleFillStatisticsProperties : InteractiveToolPropertySet
    {
        public HoleFillStatisticsProperties(nint addr) : base(addr) { }
        public Object InitialHoles { get { return this[nameof(InitialHoles)]; } set { this[nameof(InitialHoles)] = value; } }
        public Object SelectedHoles { get { return this[nameof(SelectedHoles)]; } set { this[nameof(SelectedHoles)] = value; } }
        public Object SuccessfulFills { get { return this[nameof(SuccessfulFills)]; } set { this[nameof(SuccessfulFills)] = value; } }
        public Object FailedFills { get { return this[nameof(FailedFills)]; } set { this[nameof(FailedFills)] = value; } }
        public Object RemainingHoles { get { return this[nameof(RemainingHoles)]; } set { this[nameof(RemainingHoles)] = value; } }
    }
    public class HoleFillOperatorFactory : Object
    {
        public HoleFillOperatorFactory(nint addr) : base(addr) { }
        public HoleFillTool FillTool { get { return this[nameof(FillTool)].As<HoleFillTool>(); } set { this["FillTool"] = value; } }
    }
    public class HoleFillTool : SingleSelectionMeshEditingTool
    {
        public HoleFillTool(nint addr) : base(addr) { }
        public SmoothHoleFillProperties SmoothHoleFillProperties { get { return this[nameof(SmoothHoleFillProperties)].As<SmoothHoleFillProperties>(); } set { this["SmoothHoleFillProperties"] = value; } }
        public HoleFillToolProperties Properties { get { return this[nameof(Properties)].As<HoleFillToolProperties>(); } set { this["Properties"] = value; } }
        public HoleFillToolActions Actions { get { return this[nameof(Actions)].As<HoleFillToolActions>(); } set { this["Actions"] = value; } }
        public HoleFillStatisticsProperties Statistics { get { return this[nameof(Statistics)].As<HoleFillStatisticsProperties>(); } set { this["Statistics"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public PolygonSelectionMechanic SelectionMechanic { get { return this[nameof(SelectionMechanic)].As<PolygonSelectionMechanic>(); } set { this["SelectionMechanic"] = value; } }
    }
    public class LatticeDeformerToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public LatticeDeformerToolBuilder(nint addr) : base(addr) { }
    }
    public class LatticeDeformerToolProperties : InteractiveToolPropertySet
    {
        public LatticeDeformerToolProperties(nint addr) : base(addr) { }
        public int XAxisResolution { get { return this[nameof(XAxisResolution)].GetValue<int>(); } set { this[nameof(XAxisResolution)].SetValue<int>(value); } }
        public int YAxisResolution { get { return this[nameof(YAxisResolution)].GetValue<int>(); } set { this[nameof(YAxisResolution)].SetValue<int>(value); } }
        public int ZAxisResolution { get { return this[nameof(ZAxisResolution)].GetValue<int>(); } set { this[nameof(ZAxisResolution)].SetValue<int>(value); } }
        public float Padding { get { return this[nameof(Padding)].GetValue<float>(); } set { this[nameof(Padding)].SetValue<float>(value); } }
        public ELatticeInterpolationType InterpolationType { get { return (ELatticeInterpolationType)this[nameof(InterpolationType)].GetValue<int>(); } set { this[nameof(InterpolationType)].SetValue<int>((int)value); } }
        public bool bDeformNormals { get { return this[nameof(bDeformNormals)].Flag; } set { this[nameof(bDeformNormals)].Flag = value; } }
        public bool bCanChangeResolution { get { return this[nameof(bCanChangeResolution)].Flag; } set { this[nameof(bCanChangeResolution)].Flag = value; } }
        public EToolContextCoordinateSystem GizmoCoordinateSystem { get { return (EToolContextCoordinateSystem)this[nameof(GizmoCoordinateSystem)].GetValue<int>(); } set { this[nameof(GizmoCoordinateSystem)].SetValue<int>((int)value); } }
        public bool bSetPivotMode { get { return this[nameof(bSetPivotMode)].Flag; } set { this[nameof(bSetPivotMode)].Flag = value; } }
        public bool bSoftDeformation { get { return this[nameof(bSoftDeformation)].Flag; } set { this[nameof(bSoftDeformation)].Flag = value; } }
        public void Constrain() { Invoke(nameof(Constrain)); }
        public void ClearConstraints() { Invoke(nameof(ClearConstraints)); }
    }
    public class LatticeDeformerOperatorFactory : Object
    {
        public LatticeDeformerOperatorFactory(nint addr) : base(addr) { }
        public LatticeDeformerTool LatticeDeformerTool { get { return this[nameof(LatticeDeformerTool)].As<LatticeDeformerTool>(); } set { this["LatticeDeformerTool"] = value; } }
    }
    public class LatticeDeformerTool : SingleSelectionMeshEditingTool
    {
        public LatticeDeformerTool(nint addr) : base(addr) { }
        public LatticeControlPointsMechanic ControlPointsMechanic { get { return this[nameof(ControlPointsMechanic)].As<LatticeControlPointsMechanic>(); } set { this["ControlPointsMechanic"] = value; } }
        public LatticeDeformerToolProperties Settings { get { return this[nameof(Settings)].As<LatticeDeformerToolProperties>(); } set { this["Settings"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public bool bLatticeDeformed { get { return this[nameof(bLatticeDeformed)].Flag; } set { this[nameof(bLatticeDeformed)].Flag = value; } }
    }
    public class MeshAttributePaintToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public MeshAttributePaintToolBuilder(nint addr) : base(addr) { }
    }
    public class MeshAttributePaintBrushOperationProperties : InteractiveToolPropertySet
    {
        public MeshAttributePaintBrushOperationProperties(nint addr) : base(addr) { }
        public EBrushActionMode BrushAction { get { return (EBrushActionMode)this[nameof(BrushAction)].GetValue<int>(); } set { this[nameof(BrushAction)].SetValue<int>((int)value); } }
    }
    public class MeshAttributePaintToolProperties : InteractiveToolPropertySet
    {
        public MeshAttributePaintToolProperties(nint addr) : base(addr) { }
        public Object Attribute { get { return this[nameof(Attribute)]; } set { this[nameof(Attribute)] = value; } }
        public Array<Object> GetAttributeNames() { return Invoke<Array<Object>>(nameof(GetAttributeNames)); }
    }
    public class MeshAttributePaintEditActions : InteractiveToolPropertySet
    {
        public MeshAttributePaintEditActions(nint addr) : base(addr) { }
    }
    public class MeshAttributePaintTool : DynamicMeshBrushTool
    {
        public MeshAttributePaintTool(nint addr) : base(addr) { }
        public MeshAttributePaintBrushOperationProperties BrushActionProps { get { return this[nameof(BrushActionProps)].As<MeshAttributePaintBrushOperationProperties>(); } set { this["BrushActionProps"] = value; } }
        public MeshAttributePaintToolProperties AttribProps { get { return this[nameof(AttribProps)].As<MeshAttributePaintToolProperties>(); } set { this["AttribProps"] = value; } }
    }
    public class MeshBoundaryToolBase : SingleSelectionMeshEditingTool
    {
        public MeshBoundaryToolBase(nint addr) : base(addr) { }
        public PolygonSelectionMechanic SelectionMechanic { get { return this[nameof(SelectionMechanic)].As<PolygonSelectionMechanic>(); } set { this["SelectionMechanic"] = value; } }
    }
    public class MeshGroupPaintToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public MeshGroupPaintToolBuilder(nint addr) : base(addr) { }
    }
    public class GroupPaintBrushFilterProperties : InteractiveToolPropertySet
    {
        public GroupPaintBrushFilterProperties(nint addr) : base(addr) { }
        public EMeshGroupPaintBrushType PrimaryBrushType { get { return (EMeshGroupPaintBrushType)this[nameof(PrimaryBrushType)].GetValue<int>(); } set { this[nameof(PrimaryBrushType)].SetValue<int>((int)value); } }
        public EMeshGroupPaintInteractionType SubToolType { get { return (EMeshGroupPaintInteractionType)this[nameof(SubToolType)].GetValue<int>(); } set { this[nameof(SubToolType)].SetValue<int>((int)value); } }
        public float BrushSize { get { return this[nameof(BrushSize)].GetValue<float>(); } set { this[nameof(BrushSize)].SetValue<float>(value); } }
        public EMeshGroupPaintBrushAreaType BrushAreaMode { get { return (EMeshGroupPaintBrushAreaType)this[nameof(BrushAreaMode)].GetValue<int>(); } set { this[nameof(BrushAreaMode)].SetValue<int>((int)value); } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
        public int SetGroup { get { return this[nameof(SetGroup)].GetValue<int>(); } set { this[nameof(SetGroup)].SetValue<int>(value); } }
        public bool bOnlySetUngrouped { get { return this[nameof(bOnlySetUngrouped)].Flag; } set { this[nameof(bOnlySetUngrouped)].Flag = value; } }
        public int EraseGroup { get { return this[nameof(EraseGroup)].GetValue<int>(); } set { this[nameof(EraseGroup)].SetValue<int>(value); } }
        public bool bOnlyEraseCurrent { get { return this[nameof(bOnlyEraseCurrent)].Flag; } set { this[nameof(bOnlyEraseCurrent)].Flag = value; } }
        public float AngleThreshold { get { return this[nameof(AngleThreshold)].GetValue<float>(); } set { this[nameof(AngleThreshold)].SetValue<float>(value); } }
        public bool bUVSeams { get { return this[nameof(bUVSeams)].Flag; } set { this[nameof(bUVSeams)].Flag = value; } }
        public bool bNormalSeams { get { return this[nameof(bNormalSeams)].Flag; } set { this[nameof(bNormalSeams)].Flag = value; } }
        public EMeshGroupPaintVisibilityType VisibilityFilter { get { return (EMeshGroupPaintVisibilityType)this[nameof(VisibilityFilter)].GetValue<int>(); } set { this[nameof(VisibilityFilter)].SetValue<int>((int)value); } }
        public int MinTriVertCount { get { return this[nameof(MinTriVertCount)].GetValue<int>(); } set { this[nameof(MinTriVertCount)].SetValue<int>(value); } }
    }
    public class MeshGroupPaintToolActionPropertySet : InteractiveToolPropertySet
    {
        public MeshGroupPaintToolActionPropertySet(nint addr) : base(addr) { }
    }
    public class MeshGroupPaintToolFreezeActions : MeshGroupPaintToolActionPropertySet
    {
        public MeshGroupPaintToolFreezeActions(nint addr) : base(addr) { }
        public void UnfreezeAll() { Invoke(nameof(UnfreezeAll)); }
        public void ShrinkCurrent() { Invoke(nameof(ShrinkCurrent)); }
        public void GrowCurrent() { Invoke(nameof(GrowCurrent)); }
        public void FreezeOthers() { Invoke(nameof(FreezeOthers)); }
        public void FreezeCurrent() { Invoke(nameof(FreezeCurrent)); }
        public void FloodFillCurrent() { Invoke(nameof(FloodFillCurrent)); }
        public void ClearCurrent() { Invoke(nameof(ClearCurrent)); }
        public void ClearAll() { Invoke(nameof(ClearAll)); }
    }
    public class MeshSculptToolBase : MeshSurfacePointTool
    {
        public MeshSculptToolBase(nint addr) : base(addr) { }
        public SculptBrushProperties BrushProperties { get { return this[nameof(BrushProperties)].As<SculptBrushProperties>(); } set { this["BrushProperties"] = value; } }
        public WorkPlaneProperties GizmoProperties { get { return this[nameof(GizmoProperties)].As<WorkPlaneProperties>(); } set { this["GizmoProperties"] = value; } }
        public Object BrushOpPropSets { get { return this[nameof(BrushOpPropSets)]; } set { this[nameof(BrushOpPropSets)] = value; } }
        public Object SecondaryBrushOpPropSets { get { return this[nameof(SecondaryBrushOpPropSets)]; } set { this[nameof(SecondaryBrushOpPropSets)] = value; } }
        public MeshEditingViewProperties ViewProperties { get { return this[nameof(ViewProperties)].As<MeshEditingViewProperties>(); } set { this["ViewProperties"] = value; } }
        public MaterialInstanceDynamic ActiveOverrideMaterial { get { return this[nameof(ActiveOverrideMaterial)].As<MaterialInstanceDynamic>(); } set { this["ActiveOverrideMaterial"] = value; } }
        public BrushStampIndicator BrushIndicator { get { return this[nameof(BrushIndicator)].As<BrushStampIndicator>(); } set { this["BrushIndicator"] = value; } }
        public bool bIsVolumetricIndicator { get { return this[nameof(bIsVolumetricIndicator)].Flag; } set { this[nameof(bIsVolumetricIndicator)].Flag = value; } }
        public MaterialInstanceDynamic BrushIndicatorMaterial { get { return this[nameof(BrushIndicatorMaterial)].As<MaterialInstanceDynamic>(); } set { this["BrushIndicatorMaterial"] = value; } }
        public PreviewMesh BrushIndicatorMesh { get { return this[nameof(BrushIndicatorMesh)].As<PreviewMesh>(); } set { this["BrushIndicatorMesh"] = value; } }
        public CombinedTransformGizmo PlaneTransformGizmo { get { return this[nameof(PlaneTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PlaneTransformGizmo"] = value; } }
        public TransformProxy PlaneTransformProxy { get { return this[nameof(PlaneTransformProxy)].As<TransformProxy>(); } set { this["PlaneTransformProxy"] = value; } }
    }
    public class MeshGroupPaintTool : MeshSculptToolBase
    {
        public MeshGroupPaintTool(nint addr) : base(addr) { }
        public PolygroupLayersProperties PolygroupLayerProperties { get { return this[nameof(PolygroupLayerProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayerProperties"] = value; } }
        public GroupPaintBrushFilterProperties FilterProperties { get { return this[nameof(FilterProperties)].As<GroupPaintBrushFilterProperties>(); } set { this["FilterProperties"] = value; } }
        public GroupPaintBrushOpProps PaintBrushOpProperties { get { return this[nameof(PaintBrushOpProperties)].As<GroupPaintBrushOpProps>(); } set { this["PaintBrushOpProperties"] = value; } }
        public GroupEraseBrushOpProps EraseBrushOpProperties { get { return this[nameof(EraseBrushOpProperties)].As<GroupEraseBrushOpProps>(); } set { this["EraseBrushOpProperties"] = value; } }
        public MeshGroupPaintToolFreezeActions FreezeActions { get { return this[nameof(FreezeActions)].As<MeshGroupPaintToolFreezeActions>(); } set { this["FreezeActions"] = value; } }
        public PolyLassoMarqueeMechanic PolyLassoMechanic { get { return this[nameof(PolyLassoMechanic)].As<PolyLassoMarqueeMechanic>(); } set { this["PolyLassoMechanic"] = value; } }
        public InternalToolFrameworkActor PreviewMeshActor { get { return this[nameof(PreviewMeshActor)].As<InternalToolFrameworkActor>(); } set { this["PreviewMeshActor"] = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
        public MeshElementsVisualizer MeshElementsDisplay { get { return this[nameof(MeshElementsDisplay)].As<MeshElementsVisualizer>(); } set { this["MeshElementsDisplay"] = value; } }
    }
    public class MeshInspectorToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public MeshInspectorToolBuilder(nint addr) : base(addr) { }
    }
    public class MeshInspectorProperties : InteractiveToolPropertySet
    {
        public MeshInspectorProperties(nint addr) : base(addr) { }
        public bool bWireframe { get { return this[nameof(bWireframe)].Flag; } set { this[nameof(bWireframe)].Flag = value; } }
        public bool bBoundaryEdges { get { return this[nameof(bBoundaryEdges)].Flag; } set { this[nameof(bBoundaryEdges)].Flag = value; } }
        public bool bBowtieVertices { get { return this[nameof(bBowtieVertices)].Flag; } set { this[nameof(bBowtieVertices)].Flag = value; } }
        public bool bPolygonBorders { get { return this[nameof(bPolygonBorders)].Flag; } set { this[nameof(bPolygonBorders)].Flag = value; } }
        public bool bUVSeams { get { return this[nameof(bUVSeams)].Flag; } set { this[nameof(bUVSeams)].Flag = value; } }
        public bool bUVBowties { get { return this[nameof(bUVBowties)].Flag; } set { this[nameof(bUVBowties)].Flag = value; } }
        public bool bMissingUVs { get { return this[nameof(bMissingUVs)].Flag; } set { this[nameof(bMissingUVs)].Flag = value; } }
        public bool bNormalSeams { get { return this[nameof(bNormalSeams)].Flag; } set { this[nameof(bNormalSeams)].Flag = value; } }
        public bool bNormalVectors { get { return this[nameof(bNormalVectors)].Flag; } set { this[nameof(bNormalVectors)].Flag = value; } }
        public bool bTangentVectors { get { return this[nameof(bTangentVectors)].Flag; } set { this[nameof(bTangentVectors)].Flag = value; } }
        public float NormalLength { get { return this[nameof(NormalLength)].GetValue<float>(); } set { this[nameof(NormalLength)].SetValue<float>(value); } }
        public float TangentLength { get { return this[nameof(TangentLength)].GetValue<float>(); } set { this[nameof(TangentLength)].SetValue<float>(value); } }
    }
    public class MeshInspectorTool : SingleSelectionMeshEditingTool
    {
        public MeshInspectorTool(nint addr) : base(addr) { }
        public MeshInspectorProperties Settings { get { return this[nameof(Settings)].As<MeshInspectorProperties>(); } set { this["Settings"] = value; } }
        public ExistingMeshMaterialProperties MaterialSettings { get { return this[nameof(MaterialSettings)].As<ExistingMeshMaterialProperties>(); } set { this["MaterialSettings"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public LineSetComponent DrawnLineSet { get { return this[nameof(DrawnLineSet)].As<LineSetComponent>(); } set { this["DrawnLineSet"] = value; } }
        public MaterialInterface DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInterface>(); } set { this["DefaultMaterial"] = value; } }
    }
    public class MeshSelectionToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public MeshSelectionToolBuilder(nint addr) : base(addr) { }
    }
    public class MeshSelectionToolActionPropertySet : InteractiveToolPropertySet
    {
        public MeshSelectionToolActionPropertySet(nint addr) : base(addr) { }
    }
    public class MeshSelectionEditActions : MeshSelectionToolActionPropertySet
    {
        public MeshSelectionEditActions(nint addr) : base(addr) { }
        public void Shrink() { Invoke(nameof(Shrink)); }
        public void SelectAll() { Invoke(nameof(SelectAll)); }
        public void OptimizeBorder() { Invoke(nameof(OptimizeBorder)); }
        public void LargestTriCountPart() { Invoke(nameof(LargestTriCountPart)); }
        public void LargestAreaPart() { Invoke(nameof(LargestAreaPart)); }
        public void Invert() { Invoke(nameof(Invert)); }
        public void Grow() { Invoke(nameof(Grow)); }
        public void FloodFill() { Invoke(nameof(FloodFill)); }
        public void Clear() { Invoke(nameof(Clear)); }
    }
    public class MeshSelectionMeshEditActions : MeshSelectionToolActionPropertySet
    {
        public MeshSelectionMeshEditActions(nint addr) : base(addr) { }
        public void SmoothBorder() { Invoke(nameof(SmoothBorder)); }
        public void Separate() { Invoke(nameof(Separate)); }
        public void FlipNormals() { Invoke(nameof(FlipNormals)); }
        public void Duplicate() { Invoke(nameof(Duplicate)); }
        public void Disconnect() { Invoke(nameof(Disconnect)); }
        public void Delete() { Invoke(nameof(Delete)); }
        public void CreatePolygroup() { Invoke(nameof(CreatePolygroup)); }
    }
    public class MeshSelectionToolProperties : InteractiveToolPropertySet
    {
        public MeshSelectionToolProperties(nint addr) : base(addr) { }
        public EMeshSelectionToolPrimaryMode SelectionMode { get { return (EMeshSelectionToolPrimaryMode)this[nameof(SelectionMode)].GetValue<int>(); } set { this[nameof(SelectionMode)].SetValue<int>((int)value); } }
        public float AngleTolerance { get { return this[nameof(AngleTolerance)].GetValue<float>(); } set { this[nameof(AngleTolerance)].SetValue<float>(value); } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
        public bool bShowPoints { get { return this[nameof(bShowPoints)].Flag; } set { this[nameof(bShowPoints)].Flag = value; } }
        public EMeshFacesColorMode FaceColorMode { get { return (EMeshFacesColorMode)this[nameof(FaceColorMode)].GetValue<int>(); } set { this[nameof(FaceColorMode)].SetValue<int>((int)value); } }
    }
    public class MeshSelectionTool : DynamicMeshBrushTool
    {
        public MeshSelectionTool(nint addr) : base(addr) { }
        public MeshSelectionToolProperties SelectionProps { get { return this[nameof(SelectionProps)].As<MeshSelectionToolProperties>(); } set { this["SelectionProps"] = value; } }
        public MeshSelectionEditActions SelectionActions { get { return this[nameof(SelectionActions)].As<MeshSelectionEditActions>(); } set { this["SelectionActions"] = value; } }
        public MeshSelectionToolActionPropertySet EditActions { get { return this[nameof(EditActions)].As<MeshSelectionToolActionPropertySet>(); } set { this["EditActions"] = value; } }
        public MeshStatisticsProperties MeshStatisticsProperties { get { return this[nameof(MeshStatisticsProperties)].As<MeshStatisticsProperties>(); } set { this["MeshStatisticsProperties"] = value; } }
        public MeshElementsVisualizer MeshElementsDisplay { get { return this[nameof(MeshElementsDisplay)].As<MeshElementsVisualizer>(); } set { this["MeshElementsDisplay"] = value; } }
        public MeshUVChannelProperties UVChannelProperties { get { return this[nameof(UVChannelProperties)].As<MeshUVChannelProperties>(); } set { this["UVChannelProperties"] = value; } }
        public PolygroupLayersProperties PolygroupLayerProperties { get { return this[nameof(PolygroupLayerProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayerProperties"] = value; } }
        public MeshSelectionSet Selection { get { return this[nameof(Selection)].As<MeshSelectionSet>(); } set { this["Selection"] = value; } }
        public Array<Actor> SpawnedActors { get { return new Array<Actor>(this[nameof(SpawnedActors)].Address); } }
    }
    public class MeshSpaceDeformerToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public MeshSpaceDeformerToolBuilder(nint addr) : base(addr) { }
    }
    public class MeshSpaceDeformerToolProperties : InteractiveToolPropertySet
    {
        public MeshSpaceDeformerToolProperties(nint addr) : base(addr) { }
        public ENonlinearOperationType SelectedOperationType { get { return (ENonlinearOperationType)this[nameof(SelectedOperationType)].GetValue<int>(); } set { this[nameof(SelectedOperationType)].SetValue<int>((int)value); } }
        public float UpperBoundsInterval { get { return this[nameof(UpperBoundsInterval)].GetValue<float>(); } set { this[nameof(UpperBoundsInterval)].SetValue<float>(value); } }
        public float LowerBoundsInterval { get { return this[nameof(LowerBoundsInterval)].GetValue<float>(); } set { this[nameof(LowerBoundsInterval)].SetValue<float>(value); } }
        public float BendDegrees { get { return this[nameof(BendDegrees)].GetValue<float>(); } set { this[nameof(BendDegrees)].SetValue<float>(value); } }
        public float TwistDegrees { get { return this[nameof(TwistDegrees)].GetValue<float>(); } set { this[nameof(TwistDegrees)].SetValue<float>(value); } }
        public EFlareProfileType FlareProfileType { get { return (EFlareProfileType)this[nameof(FlareProfileType)].GetValue<int>(); } set { this[nameof(FlareProfileType)].SetValue<int>((int)value); } }
        public float FlarePercentY { get { return this[nameof(FlarePercentY)].GetValue<float>(); } set { this[nameof(FlarePercentY)].SetValue<float>(value); } }
        public bool bLockXAndYFlaring { get { return this[nameof(bLockXAndYFlaring)].Flag; } set { this[nameof(bLockXAndYFlaring)].Flag = value; } }
        public float FlarePercentX { get { return this[nameof(FlarePercentX)].GetValue<float>(); } set { this[nameof(FlarePercentX)].SetValue<float>(value); } }
        public bool bLockBottom { get { return this[nameof(bLockBottom)].Flag; } set { this[nameof(bLockBottom)].Flag = value; } }
        public bool bShowOriginalMesh { get { return this[nameof(bShowOriginalMesh)].Flag; } set { this[nameof(bShowOriginalMesh)].Flag = value; } }
        public bool bDrawVisualization { get { return this[nameof(bDrawVisualization)].Flag; } set { this[nameof(bDrawVisualization)].Flag = value; } }
        public bool bAlignToNormalOnCtrlClick { get { return this[nameof(bAlignToNormalOnCtrlClick)].Flag; } set { this[nameof(bAlignToNormalOnCtrlClick)].Flag = value; } }
    }
    public class MeshSpaceDeformerToolActionPropertySet : InteractiveToolPropertySet
    {
        public MeshSpaceDeformerToolActionPropertySet(nint addr) : base(addr) { }
        public void ShiftToCenter() { Invoke(nameof(ShiftToCenter)); }
    }
    public class SpaceDeformerOperatorFactory : Object
    {
        public SpaceDeformerOperatorFactory(nint addr) : base(addr) { }
        public MeshSpaceDeformerTool SpaceDeformerTool { get { return this[nameof(SpaceDeformerTool)].As<MeshSpaceDeformerTool>(); } set { this["SpaceDeformerTool"] = value; } }
    }
    public class MeshSpaceDeformerTool : SingleSelectionMeshEditingTool
    {
        public MeshSpaceDeformerTool(nint addr) : base(addr) { }
        public MeshSpaceDeformerToolProperties Settings { get { return this[nameof(Settings)].As<MeshSpaceDeformerToolProperties>(); } set { this["Settings"] = value; } }
        public MeshSpaceDeformerToolActionPropertySet ToolActions { get { return this[nameof(ToolActions)].As<MeshSpaceDeformerToolActionPropertySet>(); } set { this["ToolActions"] = value; } }
        public GizmoTransformChangeStateTarget StateTarget { get { return this[nameof(StateTarget)].As<GizmoTransformChangeStateTarget>(); } set { this["StateTarget"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public PreviewMesh OriginalMeshPreview { get { return this[nameof(OriginalMeshPreview)].As<PreviewMesh>(); } set { this["OriginalMeshPreview"] = value; } }
        public IntervalGizmo IntervalGizmo { get { return this[nameof(IntervalGizmo)].As<IntervalGizmo>(); } set { this["IntervalGizmo"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public GizmoLocalFloatParameterSource UpIntervalSource { get { return this[nameof(UpIntervalSource)].As<GizmoLocalFloatParameterSource>(); } set { this["UpIntervalSource"] = value; } }
        public GizmoLocalFloatParameterSource DownIntervalSource { get { return this[nameof(DownIntervalSource)].As<GizmoLocalFloatParameterSource>(); } set { this["DownIntervalSource"] = value; } }
        public GizmoLocalFloatParameterSource ForwardIntervalSource { get { return this[nameof(ForwardIntervalSource)].As<GizmoLocalFloatParameterSource>(); } set { this["ForwardIntervalSource"] = value; } }
    }
    public class MeshVertexSculptToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public MeshVertexSculptToolBuilder(nint addr) : base(addr) { }
    }
    public class VertexBrushSculptProperties : InteractiveToolPropertySet
    {
        public VertexBrushSculptProperties(nint addr) : base(addr) { }
        public EMeshVertexSculptBrushType PrimaryBrushType { get { return (EMeshVertexSculptBrushType)this[nameof(PrimaryBrushType)].GetValue<int>(); } set { this[nameof(PrimaryBrushType)].SetValue<int>((int)value); } }
        public EMeshSculptFalloffType PrimaryFalloffType { get { return (EMeshSculptFalloffType)this[nameof(PrimaryFalloffType)].GetValue<int>(); } set { this[nameof(PrimaryFalloffType)].SetValue<int>((int)value); } }
        public EMeshVertexSculptBrushFilterType BrushFilter { get { return (EMeshVertexSculptBrushFilterType)this[nameof(BrushFilter)].GetValue<int>(); } set { this[nameof(BrushFilter)].SetValue<int>((int)value); } }
        public bool bFreezeTarget { get { return this[nameof(bFreezeTarget)].Flag; } set { this[nameof(bFreezeTarget)].Flag = value; } }
        public Object Tool { get { return this[nameof(Tool)]; } set { this[nameof(Tool)] = value; } }
    }
    public class VertexBrushAlphaProperties : InteractiveToolPropertySet
    {
        public VertexBrushAlphaProperties(nint addr) : base(addr) { }
        public Texture2D Alpha { get { return this[nameof(Alpha)].As<Texture2D>(); } set { this["Alpha"] = value; } }
        public float RotationAngle { get { return this[nameof(RotationAngle)].GetValue<float>(); } set { this[nameof(RotationAngle)].SetValue<float>(value); } }
        public bool bRandomize { get { return this[nameof(bRandomize)].Flag; } set { this[nameof(bRandomize)].Flag = value; } }
        public float RandomRange { get { return this[nameof(RandomRange)].GetValue<float>(); } set { this[nameof(RandomRange)].SetValue<float>(value); } }
    }
    public class MeshSymmetryProperties : InteractiveToolPropertySet
    {
        public MeshSymmetryProperties(nint addr) : base(addr) { }
        public bool bEnableSymmetry { get { return this[nameof(bEnableSymmetry)].Flag; } set { this[nameof(bEnableSymmetry)].Flag = value; } }
        public bool bSymmetryCanBeEnabled { get { return this[nameof(bSymmetryCanBeEnabled)].Flag; } set { this[nameof(bSymmetryCanBeEnabled)].Flag = value; } }
    }
    public class MeshVertexSculptTool : MeshSculptToolBase
    {
        public MeshVertexSculptTool(nint addr) : base(addr) { }
        public VertexBrushSculptProperties SculptProperties { get { return this[nameof(SculptProperties)].As<VertexBrushSculptProperties>(); } set { this["SculptProperties"] = value; } }
        public VertexBrushAlphaProperties AlphaProperties { get { return this[nameof(AlphaProperties)].As<VertexBrushAlphaProperties>(); } set { this["AlphaProperties"] = value; } }
        public Texture2D BrushAlpha { get { return this[nameof(BrushAlpha)].As<Texture2D>(); } set { this["BrushAlpha"] = value; } }
        public MeshSymmetryProperties SymmetryProperties { get { return this[nameof(SymmetryProperties)].As<MeshSymmetryProperties>(); } set { this["SymmetryProperties"] = value; } }
        public InternalToolFrameworkActor PreviewMeshActor { get { return this[nameof(PreviewMeshActor)].As<InternalToolFrameworkActor>(); } set { this["PreviewMeshActor"] = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
    }
    public class MirrorToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public MirrorToolBuilder(nint addr) : base(addr) { }
    }
    public class MirrorToolProperties : InteractiveToolPropertySet
    {
        public MirrorToolProperties(nint addr) : base(addr) { }
        public EMirrorOperationMode OperationMode { get { return (EMirrorOperationMode)this[nameof(OperationMode)].GetValue<int>(); } set { this[nameof(OperationMode)].SetValue<int>((int)value); } }
        public bool bCropAlongMirrorPlaneFirst { get { return this[nameof(bCropAlongMirrorPlaneFirst)].Flag; } set { this[nameof(bCropAlongMirrorPlaneFirst)].Flag = value; } }
        public bool bWeldVerticesOnMirrorPlane { get { return this[nameof(bWeldVerticesOnMirrorPlane)].Flag; } set { this[nameof(bWeldVerticesOnMirrorPlane)].Flag = value; } }
        public double PlaneTolerance { get { return this[nameof(PlaneTolerance)].GetValue<double>(); } set { this[nameof(PlaneTolerance)].SetValue<double>(value); } }
        public bool bAllowBowtieVertexCreation { get { return this[nameof(bAllowBowtieVertexCreation)].Flag; } set { this[nameof(bAllowBowtieVertexCreation)].Flag = value; } }
        public EMirrorCtrlClickBehavior CtrlClickBehavior { get { return (EMirrorCtrlClickBehavior)this[nameof(CtrlClickBehavior)].GetValue<int>(); } set { this[nameof(CtrlClickBehavior)].SetValue<int>((int)value); } }
        public bool bButtonsOnlyChangeOrientation { get { return this[nameof(bButtonsOnlyChangeOrientation)].Flag; } set { this[nameof(bButtonsOnlyChangeOrientation)].Flag = value; } }
        public bool bShowPreview { get { return this[nameof(bShowPreview)].Flag; } set { this[nameof(bShowPreview)].Flag = value; } }
        public EMirrorSaveMode SaveMode { get { return (EMirrorSaveMode)this[nameof(SaveMode)].GetValue<int>(); } set { this[nameof(SaveMode)].SetValue<int>((int)value); } }
    }
    public class MirrorOperatorFactory : Object
    {
        public MirrorOperatorFactory(nint addr) : base(addr) { }
        public MirrorTool MirrorTool { get { return this[nameof(MirrorTool)].As<MirrorTool>(); } set { this["MirrorTool"] = value; } }
    }
    public class MirrorToolActionPropertySet : InteractiveToolPropertySet
    {
        public MirrorToolActionPropertySet(nint addr) : base(addr) { }
        public void Up() { Invoke(nameof(Up)); }
        public void ShiftToCenter() { Invoke(nameof(ShiftToCenter)); }
        public void Right() { Invoke(nameof(Right)); }
        public void Left() { Invoke(nameof(Left)); }
        public void Forward() { Invoke(nameof(Forward)); }
        public void Down() { Invoke(nameof(Down)); }
        public void Backward() { Invoke(nameof(Backward)); }
    }
    public class MirrorTool : MultiSelectionMeshEditingTool
    {
        public MirrorTool(nint addr) : base(addr) { }
        public MirrorToolProperties Settings { get { return this[nameof(Settings)].As<MirrorToolProperties>(); } set { this["Settings"] = value; } }
        public MirrorToolActionPropertySet ToolActions { get { return this[nameof(ToolActions)].As<MirrorToolActionPropertySet>(); } set { this["ToolActions"] = value; } }
        public Array<DynamicMeshReplacementChangeTarget> MeshesToMirror { get { return new Array<DynamicMeshReplacementChangeTarget>(this[nameof(MeshesToMirror)].Address); } }
        public Array<MeshOpPreviewWithBackgroundCompute> Previews { get { return new Array<MeshOpPreviewWithBackgroundCompute>(this[nameof(Previews)].Address); } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
    }
    public class OffsetMeshToolProperties : InteractiveToolPropertySet
    {
        public OffsetMeshToolProperties(nint addr) : base(addr) { }
        public EOffsetMeshToolOffsetType OffsetType { get { return (EOffsetMeshToolOffsetType)this[nameof(OffsetType)].GetValue<int>(); } set { this[nameof(OffsetType)].SetValue<int>((int)value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public bool bCreateShell { get { return this[nameof(bCreateShell)].Flag; } set { this[nameof(bCreateShell)].Flag = value; } }
    }
    public class OffsetWeightMapSetProperties : WeightMapSetProperties
    {
        public OffsetWeightMapSetProperties(nint addr) : base(addr) { }
        public float minDistance { get { return this[nameof(minDistance)].GetValue<float>(); } set { this[nameof(minDistance)].SetValue<float>(value); } }
    }
    public class IterativeOffsetProperties : InteractiveToolPropertySet
    {
        public IterativeOffsetProperties(nint addr) : base(addr) { }
        public int Steps { get { return this[nameof(Steps)].GetValue<int>(); } set { this[nameof(Steps)].SetValue<int>(value); } }
        public bool bOffsetBoundaries { get { return this[nameof(bOffsetBoundaries)].Flag; } set { this[nameof(bOffsetBoundaries)].Flag = value; } }
        public float SmoothingPerStep { get { return this[nameof(SmoothingPerStep)].GetValue<float>(); } set { this[nameof(SmoothingPerStep)].SetValue<float>(value); } }
        public bool bReprojectSmooth { get { return this[nameof(bReprojectSmooth)].Flag; } set { this[nameof(bReprojectSmooth)].Flag = value; } }
    }
    public class ImplicitOffsetProperties : InteractiveToolPropertySet
    {
        public ImplicitOffsetProperties(nint addr) : base(addr) { }
        public float Smoothness { get { return this[nameof(Smoothness)].GetValue<float>(); } set { this[nameof(Smoothness)].SetValue<float>(value); } }
        public bool bPreserveUVs { get { return this[nameof(bPreserveUVs)].Flag; } set { this[nameof(bPreserveUVs)].Flag = value; } }
    }
    public class OffsetMeshTool : BaseMeshProcessingTool
    {
        public OffsetMeshTool(nint addr) : base(addr) { }
        public OffsetMeshToolProperties OffsetProperties { get { return this[nameof(OffsetProperties)].As<OffsetMeshToolProperties>(); } set { this["OffsetProperties"] = value; } }
        public IterativeOffsetProperties IterativeProperties { get { return this[nameof(IterativeProperties)].As<IterativeOffsetProperties>(); } set { this["IterativeProperties"] = value; } }
        public ImplicitOffsetProperties ImplicitProperties { get { return this[nameof(ImplicitProperties)].As<ImplicitOffsetProperties>(); } set { this["ImplicitProperties"] = value; } }
        public OffsetWeightMapSetProperties WeightMapProperties { get { return this[nameof(WeightMapProperties)].As<OffsetWeightMapSetProperties>(); } set { this["WeightMapProperties"] = value; } }
    }
    public class OffsetMeshToolBuilder : BaseMeshProcessingToolBuilder
    {
        public OffsetMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class PhysicsObjectToolPropertySet : InteractiveToolPropertySet
    {
        public PhysicsObjectToolPropertySet(nint addr) : base(addr) { }
        public Object ObjectName { get { return this[nameof(ObjectName)]; } set { this[nameof(ObjectName)] = value; } }
        public ECollisionGeometryMode CollisionType { get { return (ECollisionGeometryMode)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public Array<PhysicsSphereData> Spheres { get { return new Array<PhysicsSphereData>(this[nameof(Spheres)].Address); } }
        public Array<PhysicsBoxData> Boxes { get { return new Array<PhysicsBoxData>(this[nameof(Boxes)].Address); } }
        public Array<PhysicsCapsuleData> Capsules { get { return new Array<PhysicsCapsuleData>(this[nameof(Capsules)].Address); } }
        public Array<PhysicsConvexData> Convexes { get { return new Array<PhysicsConvexData>(this[nameof(Convexes)].Address); } }
        public Array<PhysicsLevelSetData> LevelSets { get { return new Array<PhysicsLevelSetData>(this[nameof(LevelSets)].Address); } }
    }
    public class CollisionGeometryVisualizationProperties : InteractiveToolPropertySet
    {
        public CollisionGeometryVisualizationProperties(nint addr) : base(addr) { }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public bool bShowHidden { get { return this[nameof(bShowHidden)].Flag; } set { this[nameof(bShowHidden)].Flag = value; } }
        public bool bRandomColors { get { return this[nameof(bRandomColors)].Flag; } set { this[nameof(bRandomColors)].Flag = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
    }
    public class ExtractCollisionGeometryToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public ExtractCollisionGeometryToolBuilder(nint addr) : base(addr) { }
    }
    public class ExtractCollisionToolProperties : InteractiveToolPropertySet
    {
        public ExtractCollisionToolProperties(nint addr) : base(addr) { }
        public EExtractCollisionOutputType CollisionType { get { return (EExtractCollisionOutputType)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public bool bWeldEdges { get { return this[nameof(bWeldEdges)].Flag; } set { this[nameof(bWeldEdges)].Flag = value; } }
        public bool bOutputSeparateMeshes { get { return this[nameof(bOutputSeparateMeshes)].Flag; } set { this[nameof(bOutputSeparateMeshes)].Flag = value; } }
        public bool bShowPreview { get { return this[nameof(bShowPreview)].Flag; } set { this[nameof(bShowPreview)].Flag = value; } }
        public bool bShowInputMesh { get { return this[nameof(bShowInputMesh)].Flag; } set { this[nameof(bShowInputMesh)].Flag = value; } }
    }
    public class ExtractCollisionGeometryTool : SingleSelectionMeshEditingTool
    {
        public ExtractCollisionGeometryTool(nint addr) : base(addr) { }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public ExtractCollisionToolProperties Settings { get { return this[nameof(Settings)].As<ExtractCollisionToolProperties>(); } set { this["Settings"] = value; } }
        public CollisionGeometryVisualizationProperties VizSettings { get { return this[nameof(VizSettings)].As<CollisionGeometryVisualizationProperties>(); } set { this["VizSettings"] = value; } }
        public PhysicsObjectToolPropertySet ObjectProps { get { return this[nameof(ObjectProps)].As<PhysicsObjectToolPropertySet>(); } set { this["ObjectProps"] = value; } }
        public PreviewGeometry PreviewElements { get { return this[nameof(PreviewElements)].As<PreviewGeometry>(); } set { this["PreviewElements"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
    }
    public class PhysicsInspectorToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public PhysicsInspectorToolBuilder(nint addr) : base(addr) { }
    }
    public class PhysicsInspectorTool : MultiSelectionMeshEditingTool
    {
        public PhysicsInspectorTool(nint addr) : base(addr) { }
        public CollisionGeometryVisualizationProperties VizSettings { get { return this[nameof(VizSettings)].As<CollisionGeometryVisualizationProperties>(); } set { this["VizSettings"] = value; } }
        public Array<PhysicsObjectToolPropertySet> ObjectData { get { return new Array<PhysicsObjectToolPropertySet>(this[nameof(ObjectData)].Address); } }
        public MaterialInterface LineMaterial { get { return this[nameof(LineMaterial)].As<MaterialInterface>(); } set { this["LineMaterial"] = value; } }
        public Array<PreviewGeometry> PreviewElements { get { return new Array<PreviewGeometry>(this[nameof(PreviewElements)].Address); } }
    }
    public class SetCollisionGeometryToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public SetCollisionGeometryToolBuilder(nint addr) : base(addr) { }
    }
    public class SetCollisionGeometryToolProperties : InteractiveToolPropertySet
    {
        public SetCollisionGeometryToolProperties(nint addr) : base(addr) { }
        public ECollisionGeometryType GeometryType { get { return (ECollisionGeometryType)this[nameof(GeometryType)].GetValue<int>(); } set { this[nameof(GeometryType)].SetValue<int>((int)value); } }
        public ESetCollisionGeometryInputMode InputMode { get { return (ESetCollisionGeometryInputMode)this[nameof(InputMode)].GetValue<int>(); } set { this[nameof(InputMode)].SetValue<int>((int)value); } }
        public bool bUseWorldSpace { get { return this[nameof(bUseWorldSpace)].Flag; } set { this[nameof(bUseWorldSpace)].Flag = value; } }
        public bool bRemoveContained { get { return this[nameof(bRemoveContained)].Flag; } set { this[nameof(bRemoveContained)].Flag = value; } }
        public bool bEnableMaxCount { get { return this[nameof(bEnableMaxCount)].Flag; } set { this[nameof(bEnableMaxCount)].Flag = value; } }
        public int MaxCount { get { return this[nameof(MaxCount)].GetValue<int>(); } set { this[nameof(MaxCount)].SetValue<int>(value); } }
        public float MinThickness { get { return this[nameof(MinThickness)].GetValue<float>(); } set { this[nameof(MinThickness)].SetValue<float>(value); } }
        public bool bDetectBoxes { get { return this[nameof(bDetectBoxes)].Flag; } set { this[nameof(bDetectBoxes)].Flag = value; } }
        public bool bDetectSpheres { get { return this[nameof(bDetectSpheres)].Flag; } set { this[nameof(bDetectSpheres)].Flag = value; } }
        public bool bDetectCapsules { get { return this[nameof(bDetectCapsules)].Flag; } set { this[nameof(bDetectCapsules)].Flag = value; } }
        public bool bSimplifyHulls { get { return this[nameof(bSimplifyHulls)].Flag; } set { this[nameof(bSimplifyHulls)].Flag = value; } }
        public int HullTargetFaceCount { get { return this[nameof(HullTargetFaceCount)].GetValue<int>(); } set { this[nameof(HullTargetFaceCount)].SetValue<int>(value); } }
        public int MaxHullsPerMesh { get { return this[nameof(MaxHullsPerMesh)].GetValue<int>(); } set { this[nameof(MaxHullsPerMesh)].SetValue<int>(value); } }
        public float ConvexDecompositionSearchFactor { get { return this[nameof(ConvexDecompositionSearchFactor)].GetValue<float>(); } set { this[nameof(ConvexDecompositionSearchFactor)].SetValue<float>(value); } }
        public float AddHullsErrorTolerance { get { return this[nameof(AddHullsErrorTolerance)].GetValue<float>(); } set { this[nameof(AddHullsErrorTolerance)].SetValue<float>(value); } }
        public float MinPartThickness { get { return this[nameof(MinPartThickness)].GetValue<float>(); } set { this[nameof(MinPartThickness)].SetValue<float>(value); } }
        public bool bSimplifyPolygons { get { return this[nameof(bSimplifyPolygons)].Flag; } set { this[nameof(bSimplifyPolygons)].Flag = value; } }
        public float HullTolerance { get { return this[nameof(HullTolerance)].GetValue<float>(); } set { this[nameof(HullTolerance)].SetValue<float>(value); } }
        public EProjectedHullAxis SweepAxis { get { return (EProjectedHullAxis)this[nameof(SweepAxis)].GetValue<int>(); } set { this[nameof(SweepAxis)].SetValue<int>((int)value); } }
        public int LevelSetResolution { get { return this[nameof(LevelSetResolution)].GetValue<int>(); } set { this[nameof(LevelSetResolution)].SetValue<int>(value); } }
        public bool bAppendToExisting { get { return this[nameof(bAppendToExisting)].Flag; } set { this[nameof(bAppendToExisting)].Flag = value; } }
        public ECollisionGeometryMode SetCollisionType { get { return (ECollisionGeometryMode)this[nameof(SetCollisionType)].GetValue<int>(); } set { this[nameof(SetCollisionType)].SetValue<int>((int)value); } }
    }
    public class SetCollisionGeometryTool : MultiSelectionMeshEditingTool
    {
        public SetCollisionGeometryTool(nint addr) : base(addr) { }
        public SetCollisionGeometryToolProperties Settings { get { return this[nameof(Settings)].As<SetCollisionGeometryToolProperties>(); } set { this["Settings"] = value; } }
        public PolygroupLayersProperties PolygroupLayerProperties { get { return this[nameof(PolygroupLayerProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayerProperties"] = value; } }
        public CollisionGeometryVisualizationProperties VizSettings { get { return this[nameof(VizSettings)].As<CollisionGeometryVisualizationProperties>(); } set { this["VizSettings"] = value; } }
        public PhysicsObjectToolPropertySet CollisionProps { get { return this[nameof(CollisionProps)].As<PhysicsObjectToolPropertySet>(); } set { this["CollisionProps"] = value; } }
        public MaterialInterface LineMaterial { get { return this[nameof(LineMaterial)].As<MaterialInterface>(); } set { this["LineMaterial"] = value; } }
        public PreviewGeometry PreviewGeom { get { return this[nameof(PreviewGeom)].As<PreviewGeometry>(); } set { this["PreviewGeom"] = value; } }
    }
    public class PlaneCutToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public PlaneCutToolBuilder(nint addr) : base(addr) { }
    }
    public class AcceptOutputProperties : InteractiveToolPropertySet
    {
        public AcceptOutputProperties(nint addr) : base(addr) { }
        public bool bExportSeparatedPiecesAsNewMeshAssets { get { return this[nameof(bExportSeparatedPiecesAsNewMeshAssets)].Flag; } set { this[nameof(bExportSeparatedPiecesAsNewMeshAssets)].Flag = value; } }
    }
    public class PlaneCutToolProperties : InteractiveToolPropertySet
    {
        public PlaneCutToolProperties(nint addr) : base(addr) { }
        public bool bKeepBothHalves { get { return this[nameof(bKeepBothHalves)].Flag; } set { this[nameof(bKeepBothHalves)].Flag = value; } }
        public float SpacingBetweenHalves { get { return this[nameof(SpacingBetweenHalves)].GetValue<float>(); } set { this[nameof(SpacingBetweenHalves)].SetValue<float>(value); } }
        public bool bShowPreview { get { return this[nameof(bShowPreview)].Flag; } set { this[nameof(bShowPreview)].Flag = value; } }
        public bool bFillCutHole { get { return this[nameof(bFillCutHole)].Flag; } set { this[nameof(bFillCutHole)].Flag = value; } }
        public bool bFillSpans { get { return this[nameof(bFillSpans)].Flag; } set { this[nameof(bFillSpans)].Flag = value; } }
    }
    public class PlaneCutOperatorFactory : Object
    {
        public PlaneCutOperatorFactory(nint addr) : base(addr) { }
        public PlaneCutTool CutTool { get { return this[nameof(CutTool)].As<PlaneCutTool>(); } set { this["CutTool"] = value; } }
    }
    public class PlaneCutTool : MultiSelectionMeshEditingTool
    {
        public PlaneCutTool(nint addr) : base(addr) { }
        public PlaneCutToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<PlaneCutToolProperties>(); } set { this["BasicProperties"] = value; } }
        public AcceptOutputProperties AcceptProperties { get { return this[nameof(AcceptProperties)].As<AcceptOutputProperties>(); } set { this["AcceptProperties"] = value; } }
        public Array<MeshOpPreviewWithBackgroundCompute> Previews { get { return new Array<MeshOpPreviewWithBackgroundCompute>(this[nameof(Previews)].Address); } }
        public Array<DynamicMeshReplacementChangeTarget> MeshesToCut { get { return new Array<DynamicMeshReplacementChangeTarget>(this[nameof(MeshesToCut)].Address); } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
        public void FlipPlane() { Invoke(nameof(FlipPlane)); }
        public void Cut() { Invoke(nameof(Cut)); }
    }
    public class ProjectToTargetToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public ProjectToTargetToolBuilder(nint addr) : base(addr) { }
    }
    public class RemeshMeshToolProperties : RemeshProperties
    {
        public RemeshMeshToolProperties(nint addr) : base(addr) { }
        public int TargetTriangleCount { get { return this[nameof(TargetTriangleCount)].GetValue<int>(); } set { this[nameof(TargetTriangleCount)].SetValue<int>(value); } }
        public ERemeshSmoothingType SmoothingType { get { return (ERemeshSmoothingType)this[nameof(SmoothingType)].GetValue<int>(); } set { this[nameof(SmoothingType)].SetValue<int>((int)value); } }
        public bool bDiscardAttributes { get { return this[nameof(bDiscardAttributes)].Flag; } set { this[nameof(bDiscardAttributes)].Flag = value; } }
        public bool bShowGroupColors { get { return this[nameof(bShowGroupColors)].Flag; } set { this[nameof(bShowGroupColors)].Flag = value; } }
        public ERemeshType RemeshType { get { return (ERemeshType)this[nameof(RemeshType)].GetValue<int>(); } set { this[nameof(RemeshType)].SetValue<int>((int)value); } }
        public int RemeshIterations { get { return this[nameof(RemeshIterations)].GetValue<int>(); } set { this[nameof(RemeshIterations)].SetValue<int>(value); } }
        public int MaxRemeshIterations { get { return this[nameof(MaxRemeshIterations)].GetValue<int>(); } set { this[nameof(MaxRemeshIterations)].SetValue<int>(value); } }
        public int ExtraProjectionIterations { get { return this[nameof(ExtraProjectionIterations)].GetValue<int>(); } set { this[nameof(ExtraProjectionIterations)].SetValue<int>(value); } }
        public bool bUseTargetEdgeLength { get { return this[nameof(bUseTargetEdgeLength)].Flag; } set { this[nameof(bUseTargetEdgeLength)].Flag = value; } }
        public float TargetEdgeLength { get { return this[nameof(TargetEdgeLength)].GetValue<float>(); } set { this[nameof(TargetEdgeLength)].SetValue<float>(value); } }
        public bool bReproject { get { return this[nameof(bReproject)].Flag; } set { this[nameof(bReproject)].Flag = value; } }
        public bool bReprojectConstraints { get { return this[nameof(bReprojectConstraints)].Flag; } set { this[nameof(bReprojectConstraints)].Flag = value; } }
        public float BoundaryCornerAngleThreshold { get { return this[nameof(BoundaryCornerAngleThreshold)].GetValue<float>(); } set { this[nameof(BoundaryCornerAngleThreshold)].SetValue<float>(value); } }
    }
    public class ProjectToTargetToolProperties : RemeshMeshToolProperties
    {
        public ProjectToTargetToolProperties(nint addr) : base(addr) { }
        public bool bWorldSpace { get { return this[nameof(bWorldSpace)].Flag; } set { this[nameof(bWorldSpace)].Flag = value; } }
        public bool bParallel { get { return this[nameof(bParallel)].Flag; } set { this[nameof(bParallel)].Flag = value; } }
        public int FaceProjectionPassesPerRemeshIteration { get { return this[nameof(FaceProjectionPassesPerRemeshIteration)].GetValue<int>(); } set { this[nameof(FaceProjectionPassesPerRemeshIteration)].SetValue<int>(value); } }
        public float SurfaceProjectionSpeed { get { return this[nameof(SurfaceProjectionSpeed)].GetValue<float>(); } set { this[nameof(SurfaceProjectionSpeed)].SetValue<float>(value); } }
        public float NormalAlignmentSpeed { get { return this[nameof(NormalAlignmentSpeed)].GetValue<float>(); } set { this[nameof(NormalAlignmentSpeed)].SetValue<float>(value); } }
        public bool bSmoothInFillAreas { get { return this[nameof(bSmoothInFillAreas)].Flag; } set { this[nameof(bSmoothInFillAreas)].Flag = value; } }
        public float FillAreaDistanceMultiplier { get { return this[nameof(FillAreaDistanceMultiplier)].GetValue<float>(); } set { this[nameof(FillAreaDistanceMultiplier)].SetValue<float>(value); } }
        public float FillAreaSmoothMultiplier { get { return this[nameof(FillAreaSmoothMultiplier)].GetValue<float>(); } set { this[nameof(FillAreaSmoothMultiplier)].SetValue<float>(value); } }
    }
    public class RemeshMeshTool : MultiSelectionMeshEditingTool
    {
        public RemeshMeshTool(nint addr) : base(addr) { }
        public RemeshMeshToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<RemeshMeshToolProperties>(); } set { this["BasicProperties"] = value; } }
        public MeshStatisticsProperties MeshStatisticsProperties { get { return this[nameof(MeshStatisticsProperties)].As<MeshStatisticsProperties>(); } set { this["MeshStatisticsProperties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public MeshElementsVisualizer MeshElementsDisplay { get { return this[nameof(MeshElementsDisplay)].As<MeshElementsVisualizer>(); } set { this["MeshElementsDisplay"] = value; } }
    }
    public class ProjectToTargetTool : RemeshMeshTool
    {
        public ProjectToTargetTool(nint addr) : base(addr) { }
    }
    public class MeshAnalysisProperties : InteractiveToolPropertySet
    {
        public MeshAnalysisProperties(nint addr) : base(addr) { }
        public Object SurfaceArea { get { return this[nameof(SurfaceArea)]; } set { this[nameof(SurfaceArea)] = value; } }
        public Object Volume { get { return this[nameof(Volume)]; } set { this[nameof(Volume)] = value; } }
    }
    public class MeshStatisticsProperties : InteractiveToolPropertySet
    {
        public MeshStatisticsProperties(nint addr) : base(addr) { }
        public Object Mesh { get { return this[nameof(Mesh)]; } set { this[nameof(Mesh)] = value; } }
        public Object UV { get { return this[nameof(UV)]; } set { this[nameof(UV)] = value; } }
        public Object Attributes { get { return this[nameof(Attributes)]; } set { this[nameof(Attributes)] = value; } }
    }
    public class RemeshMeshToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public RemeshMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class RemoveOccludedTrianglesToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public RemoveOccludedTrianglesToolBuilder(nint addr) : base(addr) { }
    }
    public class RemoveOccludedTrianglesToolProperties : InteractiveToolPropertySet
    {
        public RemoveOccludedTrianglesToolProperties(nint addr) : base(addr) { }
        public EOcclusionCalculationUIMode OcclusionTestMethod { get { return (EOcclusionCalculationUIMode)this[nameof(OcclusionTestMethod)].GetValue<int>(); } set { this[nameof(OcclusionTestMethod)].SetValue<int>((int)value); } }
        public EOcclusionTriangleSamplingUIMode TriangleSampling { get { return (EOcclusionTriangleSamplingUIMode)this[nameof(TriangleSampling)].GetValue<int>(); } set { this[nameof(TriangleSampling)].SetValue<int>((int)value); } }
        public double WindingIsoValue { get { return this[nameof(WindingIsoValue)].GetValue<double>(); } set { this[nameof(WindingIsoValue)].SetValue<double>(value); } }
        public int AddRandomRays { get { return this[nameof(AddRandomRays)].GetValue<int>(); } set { this[nameof(AddRandomRays)].SetValue<int>(value); } }
        public int AddTriangleSamples { get { return this[nameof(AddTriangleSamples)].GetValue<int>(); } set { this[nameof(AddTriangleSamples)].SetValue<int>(value); } }
        public bool bOnlySelfOcclude { get { return this[nameof(bOnlySelfOcclude)].Flag; } set { this[nameof(bOnlySelfOcclude)].Flag = value; } }
        public int ShrinkRemoval { get { return this[nameof(ShrinkRemoval)].GetValue<int>(); } set { this[nameof(ShrinkRemoval)].SetValue<int>(value); } }
        public double MinAreaIsland { get { return this[nameof(MinAreaIsland)].GetValue<double>(); } set { this[nameof(MinAreaIsland)].SetValue<double>(value); } }
        public int MinTriCountIsland { get { return this[nameof(MinTriCountIsland)].GetValue<int>(); } set { this[nameof(MinTriCountIsland)].SetValue<int>(value); } }
        public EOccludedAction action { get { return (EOccludedAction)this[nameof(action)].GetValue<int>(); } set { this[nameof(action)].SetValue<int>((int)value); } }
    }
    public class RemoveOccludedTrianglesAdvancedProperties : InteractiveToolPropertySet
    {
        public RemoveOccludedTrianglesAdvancedProperties(nint addr) : base(addr) { }
    }
    public class RemoveOccludedTrianglesOperatorFactory : Object
    {
        public RemoveOccludedTrianglesOperatorFactory(nint addr) : base(addr) { }
        public RemoveOccludedTrianglesTool Tool { get { return this[nameof(Tool)].As<RemoveOccludedTrianglesTool>(); } set { this["Tool"] = value; } }
    }
    public class RemoveOccludedTrianglesTool : MultiSelectionMeshEditingTool
    {
        public RemoveOccludedTrianglesTool(nint addr) : base(addr) { }
        public RemoveOccludedTrianglesToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<RemoveOccludedTrianglesToolProperties>(); } set { this["BasicProperties"] = value; } }
        public PolygroupLayersProperties PolygroupLayersProperties { get { return this[nameof(PolygroupLayersProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayersProperties"] = value; } }
        public RemoveOccludedTrianglesAdvancedProperties AdvancedProperties { get { return this[nameof(AdvancedProperties)].As<RemoveOccludedTrianglesAdvancedProperties>(); } set { this["AdvancedProperties"] = value; } }
        public Array<MeshOpPreviewWithBackgroundCompute> Previews { get { return new Array<MeshOpPreviewWithBackgroundCompute>(this[nameof(Previews)].Address); } }
        public Array<PreviewMesh> PreviewCopies { get { return new Array<PreviewMesh>(this[nameof(PreviewCopies)].Address); } }
    }
    public class RevolveBoundaryToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public RevolveBoundaryToolBuilder(nint addr) : base(addr) { }
    }
    public class RevolveBoundaryOperatorFactory : Object
    {
        public RevolveBoundaryOperatorFactory(nint addr) : base(addr) { }
        public RevolveBoundaryTool RevolveBoundaryTool { get { return this[nameof(RevolveBoundaryTool)].As<RevolveBoundaryTool>(); } set { this["RevolveBoundaryTool"] = value; } }
    }
    public class RevolveBoundaryToolProperties : RevolveProperties
    {
        public RevolveBoundaryToolProperties(nint addr) : base(addr) { }
        public ERevolvePropertiesCapFillMode CapFillMode { get { return (ERevolvePropertiesCapFillMode)this[nameof(CapFillMode)].GetValue<int>(); } set { this[nameof(CapFillMode)].SetValue<int>((int)value); } }
        public bool bDisplayInputMesh { get { return this[nameof(bDisplayInputMesh)].Flag; } set { this[nameof(bDisplayInputMesh)].Flag = value; } }
        public Vector AxisOrigin { get { return this[nameof(AxisOrigin)].As<Vector>(); } set { this["AxisOrigin"] = value; } }
        public Vector2D AxisOrientation { get { return this[nameof(AxisOrientation)].As<Vector2D>(); } set { this["AxisOrientation"] = value; } }
    }
    public class RevolveBoundaryTool : MeshBoundaryToolBase
    {
        public RevolveBoundaryTool(nint addr) : base(addr) { }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public RevolveBoundaryToolProperties Settings { get { return this[nameof(Settings)].As<RevolveBoundaryToolProperties>(); } set { this["Settings"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class SculptBrushProperties : InteractiveToolPropertySet
    {
        public SculptBrushProperties(nint addr) : base(addr) { }
        public BrushToolRadius BrushSize { get { return this[nameof(BrushSize)].As<BrushToolRadius>(); } set { this["BrushSize"] = value; } }
        public float BrushFalloffAmount { get { return this[nameof(BrushFalloffAmount)].GetValue<float>(); } set { this[nameof(BrushFalloffAmount)].SetValue<float>(value); } }
        public bool bShowFalloff { get { return this[nameof(bShowFalloff)].Flag; } set { this[nameof(bShowFalloff)].Flag = value; } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
        public float FlowRate { get { return this[nameof(FlowRate)].GetValue<float>(); } set { this[nameof(FlowRate)].SetValue<float>(value); } }
        public float Spacing { get { return this[nameof(Spacing)].GetValue<float>(); } set { this[nameof(Spacing)].SetValue<float>(value); } }
        public float Lazyness { get { return this[nameof(Lazyness)].GetValue<float>(); } set { this[nameof(Lazyness)].SetValue<float>(value); } }
        public bool bShowPerBrushProps { get { return this[nameof(bShowPerBrushProps)].Flag; } set { this[nameof(bShowPerBrushProps)].Flag = value; } }
        public bool bShowLazyness { get { return this[nameof(bShowLazyness)].Flag; } set { this[nameof(bShowLazyness)].Flag = value; } }
        public bool bShowFlowRate { get { return this[nameof(bShowFlowRate)].Flag; } set { this[nameof(bShowFlowRate)].Flag = value; } }
        public bool bShowSpacing { get { return this[nameof(bShowSpacing)].Flag; } set { this[nameof(bShowSpacing)].Flag = value; } }
    }
    public class KelvinBrushProperties : InteractiveToolPropertySet
    {
        public KelvinBrushProperties(nint addr) : base(addr) { }
        public float FalloffDistance { get { return this[nameof(FalloffDistance)].GetValue<float>(); } set { this[nameof(FalloffDistance)].SetValue<float>(value); } }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public float Incompressiblity { get { return this[nameof(Incompressiblity)].GetValue<float>(); } set { this[nameof(Incompressiblity)].SetValue<float>(value); } }
        public int BrushSteps { get { return this[nameof(BrushSteps)].GetValue<int>(); } set { this[nameof(BrushSteps)].SetValue<int>(value); } }
    }
    public class WorkPlaneProperties : InteractiveToolPropertySet
    {
        public WorkPlaneProperties(nint addr) : base(addr) { }
        public bool bPropertySetEnabled { get { return this[nameof(bPropertySetEnabled)].Flag; } set { this[nameof(bPropertySetEnabled)].Flag = value; } }
        public bool bShowGizmo { get { return this[nameof(bShowGizmo)].Flag; } set { this[nameof(bShowGizmo)].Flag = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class SculptMaxBrushProperties : InteractiveToolPropertySet
    {
        public SculptMaxBrushProperties(nint addr) : base(addr) { }
        public float MaxHeight { get { return this[nameof(MaxHeight)].GetValue<float>(); } set { this[nameof(MaxHeight)].SetValue<float>(value); } }
        public bool bFreezeCurrentHeight { get { return this[nameof(bFreezeCurrentHeight)].Flag; } set { this[nameof(bFreezeCurrentHeight)].Flag = value; } }
    }
    public class SeamSculptToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public SeamSculptToolBuilder(nint addr) : base(addr) { }
    }
    public class SeamSculptToolProperties : InteractiveToolPropertySet
    {
        public SeamSculptToolProperties(nint addr) : base(addr) { }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
    }
    public class SeamSculptTool : DynamicMeshBrushTool
    {
        public SeamSculptTool(nint addr) : base(addr) { }
        public SeamSculptToolProperties Settings { get { return this[nameof(Settings)].As<SeamSculptToolProperties>(); } set { this["Settings"] = value; } }
        public PreviewGeometry PreviewGeom { get { return this[nameof(PreviewGeom)].As<PreviewGeometry>(); } set { this["PreviewGeom"] = value; } }
    }
    public class SelfUnionMeshesToolProperties : InteractiveToolPropertySet
    {
        public SelfUnionMeshesToolProperties(nint addr) : base(addr) { }
        public bool bTrimFlaps { get { return this[nameof(bTrimFlaps)].Flag; } set { this[nameof(bTrimFlaps)].Flag = value; } }
        public bool bTryFixHoles { get { return this[nameof(bTryFixHoles)].Flag; } set { this[nameof(bTryFixHoles)].Flag = value; } }
        public bool bTryCollapseEdges { get { return this[nameof(bTryCollapseEdges)].Flag; } set { this[nameof(bTryCollapseEdges)].Flag = value; } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
        public bool bShowNewBoundaryEdges { get { return this[nameof(bShowNewBoundaryEdges)].Flag; } set { this[nameof(bShowNewBoundaryEdges)].Flag = value; } }
        public bool bOnlyUseFirstMeshMaterials { get { return this[nameof(bOnlyUseFirstMeshMaterials)].Flag; } set { this[nameof(bOnlyUseFirstMeshMaterials)].Flag = value; } }
    }
    public class SelfUnionMeshesTool : BaseCreateFromSelectedTool
    {
        public SelfUnionMeshesTool(nint addr) : base(addr) { }
        public SelfUnionMeshesToolProperties Properties { get { return this[nameof(Properties)].As<SelfUnionMeshesToolProperties>(); } set { this["Properties"] = value; } }
        public LineSetComponent DrawnLineSet { get { return this[nameof(DrawnLineSet)].As<LineSetComponent>(); } set { this["DrawnLineSet"] = value; } }
    }
    public class SelfUnionMeshesToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public SelfUnionMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class SkinWeightsBindingToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public SkinWeightsBindingToolBuilder(nint addr) : base(addr) { }
    }
    public class SkinWeightsBindingToolProperties : InteractiveToolPropertySet
    {
        public SkinWeightsBindingToolProperties(nint addr) : base(addr) { }
        public BoneReference CurrentBone { get { return this[nameof(CurrentBone)].As<BoneReference>(); } set { this["CurrentBone"] = value; } }
        public ESkinWeightsBindType BindingType { get { return (ESkinWeightsBindType)this[nameof(BindingType)].GetValue<int>(); } set { this[nameof(BindingType)].SetValue<int>((int)value); } }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public int MaxInfluences { get { return this[nameof(MaxInfluences)].GetValue<int>(); } set { this[nameof(MaxInfluences)].SetValue<int>(value); } }
        public int VoxelResolution { get { return this[nameof(VoxelResolution)].GetValue<int>(); } set { this[nameof(VoxelResolution)].SetValue<int>(value); } }
    }
    public class SkinWeightsBindingTool : MultiSelectionMeshEditingTool
    {
        public SkinWeightsBindingTool(nint addr) : base(addr) { }
        public SkinWeightsBindingToolProperties Properties { get { return this[nameof(Properties)].As<SkinWeightsBindingToolProperties>(); } set { this["Properties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class SkinWeightsPaintToolBuilder : MeshSurfacePointMeshEditingToolBuilder
    {
        public SkinWeightsPaintToolBuilder(nint addr) : base(addr) { }
    }
    public class SkinWeightsPaintToolProperties : InteractiveToolPropertySet
    {
        public SkinWeightsPaintToolProperties(nint addr) : base(addr) { }
        public BoneReference CurrentBone { get { return this[nameof(CurrentBone)].As<BoneReference>(); } set { this["CurrentBone"] = value; } }
    }
    public class SkinWeightsPaintTool : DynamicMeshBrushTool
    {
        public SkinWeightsPaintTool(nint addr) : base(addr) { }
        public SkinWeightsPaintToolProperties ToolProps { get { return this[nameof(ToolProps)].As<SkinWeightsPaintToolProperties>(); } set { this["ToolProps"] = value; } }
    }
    public class SmoothMeshToolProperties : InteractiveToolPropertySet
    {
        public SmoothMeshToolProperties(nint addr) : base(addr) { }
        public ESmoothMeshToolSmoothType SmoothingType { get { return (ESmoothMeshToolSmoothType)this[nameof(SmoothingType)].GetValue<int>(); } set { this[nameof(SmoothingType)].SetValue<int>((int)value); } }
    }
    public class IterativeSmoothProperties : InteractiveToolPropertySet
    {
        public IterativeSmoothProperties(nint addr) : base(addr) { }
        public float SmoothingPerStep { get { return this[nameof(SmoothingPerStep)].GetValue<float>(); } set { this[nameof(SmoothingPerStep)].SetValue<float>(value); } }
        public int Steps { get { return this[nameof(Steps)].GetValue<int>(); } set { this[nameof(Steps)].SetValue<int>(value); } }
        public bool bSmoothBoundary { get { return this[nameof(bSmoothBoundary)].Flag; } set { this[nameof(bSmoothBoundary)].Flag = value; } }
    }
    public class DiffusionSmoothProperties : InteractiveToolPropertySet
    {
        public DiffusionSmoothProperties(nint addr) : base(addr) { }
        public float SmoothingPerStep { get { return this[nameof(SmoothingPerStep)].GetValue<float>(); } set { this[nameof(SmoothingPerStep)].SetValue<float>(value); } }
        public int Steps { get { return this[nameof(Steps)].GetValue<int>(); } set { this[nameof(Steps)].SetValue<int>(value); } }
        public bool bPreserveUVs { get { return this[nameof(bPreserveUVs)].Flag; } set { this[nameof(bPreserveUVs)].Flag = value; } }
    }
    public class ImplicitSmoothProperties : InteractiveToolPropertySet
    {
        public ImplicitSmoothProperties(nint addr) : base(addr) { }
        public float SmoothSpeed { get { return this[nameof(SmoothSpeed)].GetValue<float>(); } set { this[nameof(SmoothSpeed)].SetValue<float>(value); } }
        public float Smoothness { get { return this[nameof(Smoothness)].GetValue<float>(); } set { this[nameof(Smoothness)].SetValue<float>(value); } }
        public bool bPreserveUVs { get { return this[nameof(bPreserveUVs)].Flag; } set { this[nameof(bPreserveUVs)].Flag = value; } }
        public float VolumeCorrection { get { return this[nameof(VolumeCorrection)].GetValue<float>(); } set { this[nameof(VolumeCorrection)].SetValue<float>(value); } }
    }
    public class SmoothWeightMapSetProperties : WeightMapSetProperties
    {
        public SmoothWeightMapSetProperties(nint addr) : base(addr) { }
        public float MinSmoothMultiplier { get { return this[nameof(MinSmoothMultiplier)].GetValue<float>(); } set { this[nameof(MinSmoothMultiplier)].SetValue<float>(value); } }
    }
    public class SmoothMeshTool : BaseMeshProcessingTool
    {
        public SmoothMeshTool(nint addr) : base(addr) { }
        public SmoothMeshToolProperties SmoothProperties { get { return this[nameof(SmoothProperties)].As<SmoothMeshToolProperties>(); } set { this["SmoothProperties"] = value; } }
        public IterativeSmoothProperties IterativeProperties { get { return this[nameof(IterativeProperties)].As<IterativeSmoothProperties>(); } set { this["IterativeProperties"] = value; } }
        public DiffusionSmoothProperties DiffusionProperties { get { return this[nameof(DiffusionProperties)].As<DiffusionSmoothProperties>(); } set { this["DiffusionProperties"] = value; } }
        public ImplicitSmoothProperties ImplicitProperties { get { return this[nameof(ImplicitProperties)].As<ImplicitSmoothProperties>(); } set { this["ImplicitProperties"] = value; } }
        public SmoothWeightMapSetProperties WeightMapProperties { get { return this[nameof(WeightMapProperties)].As<SmoothWeightMapSetProperties>(); } set { this["WeightMapProperties"] = value; } }
    }
    public class SmoothMeshToolBuilder : BaseMeshProcessingToolBuilder
    {
        public SmoothMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class SplitMeshesToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public SplitMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class SplitMeshesToolProperties : InteractiveToolPropertySet
    {
        public SplitMeshesToolProperties(nint addr) : base(addr) { }
        public bool bTransferMaterials { get { return this[nameof(bTransferMaterials)].Flag; } set { this[nameof(bTransferMaterials)].Flag = value; } }
    }
    public class SplitMeshesTool : MultiSelectionMeshEditingTool
    {
        public SplitMeshesTool(nint addr) : base(addr) { }
        public SplitMeshesToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<SplitMeshesToolProperties>(); } set { this["BasicProperties"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
    }
    public class TransferMeshToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public TransferMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class TransferMeshToolProperties : InteractiveToolPropertySet
    {
        public TransferMeshToolProperties(nint addr) : base(addr) { }
        public bool bTransferMaterials { get { return this[nameof(bTransferMaterials)].Flag; } set { this[nameof(bTransferMaterials)].Flag = value; } }
        public Object SourceLOD { get { return this[nameof(SourceLOD)]; } set { this[nameof(SourceLOD)] = value; } }
        public Object TargetLod { get { return this[nameof(TargetLod)]; } set { this[nameof(TargetLod)] = value; } }
        public bool bIsStaticMeshSource { get { return this[nameof(bIsStaticMeshSource)].Flag; } set { this[nameof(bIsStaticMeshSource)].Flag = value; } }
        public Array<Object> SourceLODNamesList { get { return new Array<Object>(this[nameof(SourceLODNamesList)].Address); } }
        public Array<Object> TargetLODNamesList { get { return new Array<Object>(this[nameof(TargetLODNamesList)].Address); } }
        public bool bIsStaticMeshTarget { get { return this[nameof(bIsStaticMeshTarget)].Flag; } set { this[nameof(bIsStaticMeshTarget)].Flag = value; } }
        public Array<Object> GetTargetLODNamesFunc() { return Invoke<Array<Object>>(nameof(GetTargetLODNamesFunc)); }
        public Array<Object> GetSourceLODNamesFunc() { return Invoke<Array<Object>>(nameof(GetSourceLODNamesFunc)); }
    }
    public class TransferMeshTool : MultiSelectionMeshEditingTool
    {
        public TransferMeshTool(nint addr) : base(addr) { }
        public TransferMeshToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<TransferMeshToolProperties>(); } set { this["BasicProperties"] = value; } }
    }
    public class TransformMeshesToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public TransformMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class TransformMeshesToolProperties : InteractiveToolPropertySet
    {
        public TransformMeshesToolProperties(nint addr) : base(addr) { }
        public ETransformMeshesTransformMode TransformMode { get { return (ETransformMeshesTransformMode)this[nameof(TransformMode)].GetValue<int>(); } set { this[nameof(TransformMode)].SetValue<int>((int)value); } }
        public bool bApplyToInstances { get { return this[nameof(bApplyToInstances)].Flag; } set { this[nameof(bApplyToInstances)].Flag = value; } }
        public bool bSetPivotMode { get { return this[nameof(bSetPivotMode)].Flag; } set { this[nameof(bSetPivotMode)].Flag = value; } }
        public bool bEnableSnapDragging { get { return this[nameof(bEnableSnapDragging)].Flag; } set { this[nameof(bEnableSnapDragging)].Flag = value; } }
        public ETransformMeshesSnapDragSource SnapDragSource { get { return (ETransformMeshesSnapDragSource)this[nameof(SnapDragSource)].GetValue<int>(); } set { this[nameof(SnapDragSource)].SetValue<int>((int)value); } }
        public ETransformMeshesSnapDragRotationMode RotationMode { get { return (ETransformMeshesSnapDragRotationMode)this[nameof(RotationMode)].GetValue<int>(); } set { this[nameof(RotationMode)].SetValue<int>((int)value); } }
        public bool bHaveInstances { get { return this[nameof(bHaveInstances)].Flag; } set { this[nameof(bHaveInstances)].Flag = value; } }
    }
    public class TransformMeshesTool : MultiSelectionMeshEditingTool
    {
        public TransformMeshesTool(nint addr) : base(addr) { }
        public TransformMeshesToolProperties TransformProps { get { return this[nameof(TransformProps)].As<TransformMeshesToolProperties>(); } set { this["TransformProps"] = value; } }
        public Array<TransformMeshesTarget> ActiveGizmos { get { return new Array<TransformMeshesTarget>(this[nameof(ActiveGizmos)].Address); } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
    }
    public class VolumeToMeshToolBuilder : InteractiveToolBuilder
    {
        public VolumeToMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class VolumeToMeshToolProperties : InteractiveToolPropertySet
    {
        public VolumeToMeshToolProperties(nint addr) : base(addr) { }
        public bool bWeldEdges { get { return this[nameof(bWeldEdges)].Flag; } set { this[nameof(bWeldEdges)].Flag = value; } }
        public bool bAutoRepair { get { return this[nameof(bAutoRepair)].Flag; } set { this[nameof(bAutoRepair)].Flag = value; } }
        public bool bOptimizeMesh { get { return this[nameof(bOptimizeMesh)].Flag; } set { this[nameof(bOptimizeMesh)].Flag = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
    }
    public class VolumeToMeshTool : InteractiveTool
    {
        public VolumeToMeshTool(nint addr) : base(addr) { }
        public VolumeToMeshToolProperties Settings { get { return this[nameof(Settings)].As<VolumeToMeshToolProperties>(); } set { this["Settings"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public Object TargetVolume { get { return this[nameof(TargetVolume)]; } set { this[nameof(TargetVolume)] = value; } }
        public LineSetComponent VolumeEdgesSet { get { return this[nameof(VolumeEdgesSet)].As<LineSetComponent>(); } set { this["VolumeEdgesSet"] = value; } }
    }
    public class VoxelBlendMeshesToolProperties : InteractiveToolPropertySet
    {
        public VoxelBlendMeshesToolProperties(nint addr) : base(addr) { }
        public double BlendPower { get { return this[nameof(BlendPower)].GetValue<double>(); } set { this[nameof(BlendPower)].SetValue<double>(value); } }
        public double BlendFalloff { get { return this[nameof(BlendFalloff)].GetValue<double>(); } set { this[nameof(BlendFalloff)].SetValue<double>(value); } }
        public EVoxelBlendOperation Operation { get { return (EVoxelBlendOperation)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public bool bVoxWrap { get { return this[nameof(bVoxWrap)].Flag; } set { this[nameof(bVoxWrap)].Flag = value; } }
        public bool bRemoveInternalsAfterVoxWrap { get { return this[nameof(bRemoveInternalsAfterVoxWrap)].Flag; } set { this[nameof(bRemoveInternalsAfterVoxWrap)].Flag = value; } }
        public double ThickenShells { get { return this[nameof(ThickenShells)].GetValue<double>(); } set { this[nameof(ThickenShells)].SetValue<double>(value); } }
    }
    public class VoxelBlendMeshesTool : BaseVoxelTool
    {
        public VoxelBlendMeshesTool(nint addr) : base(addr) { }
        public VoxelBlendMeshesToolProperties BlendProperties { get { return this[nameof(BlendProperties)].As<VoxelBlendMeshesToolProperties>(); } set { this["BlendProperties"] = value; } }
    }
    public class VoxelBlendMeshesToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public VoxelBlendMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class VoxelMorphologyMeshesToolProperties : InteractiveToolPropertySet
    {
        public VoxelMorphologyMeshesToolProperties(nint addr) : base(addr) { }
        public EMorphologyOperation Operation { get { return (EMorphologyOperation)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public double Distance { get { return this[nameof(Distance)].GetValue<double>(); } set { this[nameof(Distance)].SetValue<double>(value); } }
        public bool bVoxWrap { get { return this[nameof(bVoxWrap)].Flag; } set { this[nameof(bVoxWrap)].Flag = value; } }
        public bool bRemoveInternalsAfterVoxWrap { get { return this[nameof(bRemoveInternalsAfterVoxWrap)].Flag; } set { this[nameof(bRemoveInternalsAfterVoxWrap)].Flag = value; } }
        public double ThickenShells { get { return this[nameof(ThickenShells)].GetValue<double>(); } set { this[nameof(ThickenShells)].SetValue<double>(value); } }
    }
    public class VoxelMorphologyMeshesTool : BaseVoxelTool
    {
        public VoxelMorphologyMeshesTool(nint addr) : base(addr) { }
        public VoxelMorphologyMeshesToolProperties MorphologyProperties { get { return this[nameof(MorphologyProperties)].As<VoxelMorphologyMeshesToolProperties>(); } set { this["MorphologyProperties"] = value; } }
    }
    public class VoxelMorphologyMeshesToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public VoxelMorphologyMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class VoxelSolidifyMeshesToolProperties : InteractiveToolPropertySet
    {
        public VoxelSolidifyMeshesToolProperties(nint addr) : base(addr) { }
        public double WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<double>(); } set { this[nameof(WindingThreshold)].SetValue<double>(value); } }
        public double ExtendBounds { get { return this[nameof(ExtendBounds)].GetValue<double>(); } set { this[nameof(ExtendBounds)].SetValue<double>(value); } }
        public int SurfaceSearchSteps { get { return this[nameof(SurfaceSearchSteps)].GetValue<int>(); } set { this[nameof(SurfaceSearchSteps)].SetValue<int>(value); } }
        public bool bSolidAtBoundaries { get { return this[nameof(bSolidAtBoundaries)].Flag; } set { this[nameof(bSolidAtBoundaries)].Flag = value; } }
        public bool bApplyThickenShells { get { return this[nameof(bApplyThickenShells)].Flag; } set { this[nameof(bApplyThickenShells)].Flag = value; } }
        public double ThickenShells { get { return this[nameof(ThickenShells)].GetValue<double>(); } set { this[nameof(ThickenShells)].SetValue<double>(value); } }
    }
    public class VoxelSolidifyMeshesTool : BaseVoxelTool
    {
        public VoxelSolidifyMeshesTool(nint addr) : base(addr) { }
        public VoxelSolidifyMeshesToolProperties SolidifyProperties { get { return this[nameof(SolidifyProperties)].As<VoxelSolidifyMeshesToolProperties>(); } set { this["SolidifyProperties"] = value; } }
    }
    public class VoxelSolidifyMeshesToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public VoxelSolidifyMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class WeldMeshEdgesToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public WeldMeshEdgesToolBuilder(nint addr) : base(addr) { }
    }
    public class WeldMeshEdgesToolProperties : InteractiveToolPropertySet
    {
        public WeldMeshEdgesToolProperties(nint addr) : base(addr) { }
        public float Tolerance { get { return this[nameof(Tolerance)].GetValue<float>(); } set { this[nameof(Tolerance)].SetValue<float>(value); } }
        public bool bOnlyUnique { get { return this[nameof(bOnlyUnique)].Flag; } set { this[nameof(bOnlyUnique)].Flag = value; } }
        public bool bResolveTJunctions { get { return this[nameof(bResolveTJunctions)].Flag; } set { this[nameof(bResolveTJunctions)].Flag = value; } }
        public int InitialEdges { get { return this[nameof(InitialEdges)].GetValue<int>(); } set { this[nameof(InitialEdges)].SetValue<int>(value); } }
        public int RemainingEdges { get { return this[nameof(RemainingEdges)].GetValue<int>(); } set { this[nameof(RemainingEdges)].SetValue<int>(value); } }
    }
    public class WeldMeshEdgesOperatorFactory : Object
    {
        public WeldMeshEdgesOperatorFactory(nint addr) : base(addr) { }
        public WeldMeshEdgesTool WeldMeshEdgesTool { get { return this[nameof(WeldMeshEdgesTool)].As<WeldMeshEdgesTool>(); } set { this["WeldMeshEdgesTool"] = value; } }
    }
    public class WeldMeshEdgesTool : SingleSelectionMeshEditingTool
    {
        public WeldMeshEdgesTool(nint addr) : base(addr) { }
        public WeldMeshEdgesToolProperties Settings { get { return this[nameof(Settings)].As<WeldMeshEdgesToolProperties>(); } set { this["Settings"] = value; } }
        public MeshOpPreviewWithBackgroundCompute PreviewCompute { get { return this[nameof(PreviewCompute)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["PreviewCompute"] = value; } }
        public MeshElementsVisualizer MeshElementsDisplay { get { return this[nameof(MeshElementsDisplay)].As<MeshElementsVisualizer>(); } set { this["MeshElementsDisplay"] = value; } }
        public WeldMeshEdgesOperatorFactory OperatorFactory { get { return this[nameof(OperatorFactory)].As<WeldMeshEdgesOperatorFactory>(); } set { this["OperatorFactory"] = value; } }
    }
    public enum EBakeNormalSpace : int
    {
        Tangent = 0,
        Object = 1,
        EBakeNormalSpace_MAX = 2,
    }
    public enum EBakeCurvatureTypeMode : int
    {
        MeanAverage = 0,
        Max = 1,
        Min = 2,
        Gaussian = 3,
    }
    public enum EBakeCurvatureColorMode : int
    {
        Grayscale = 0,
        RedBlue = 1,
        RedGreenBlue = 2,
        EBakeCurvatureColorMode_MAX = 3,
    }
    public enum EBakeCurvatureClampMode : int
    {
        None = 0,
        OnlyPositive = 1,
        OnlyNegative = 2,
        EBakeCurvatureClampMode_MAX = 3,
    }
    public enum EPlaneBrushSideMode : int
    {
        BothSides = 0,
        PushDown = 1,
        PullTowards = 2,
        EPlaneBrushSideMode_MAX = 3,
    }
    public enum EPatternToolShape : int
    {
        Line = 0,
        Grid = 1,
        Circle = 2,
        EPatternToolShape_MAX = 3,
    }
    public enum EPatternToolSingleAxis : int
    {
        XAxis = 0,
        YAxis = 1,
        ZAxis = 2,
        EPatternToolSingleAxis_MAX = 3,
    }
    public enum EPatternToolSinglePlane : int
    {
        XYPlane = 0,
        XZPlane = 1,
        YZPlane = 2,
        EPatternToolSinglePlane_MAX = 3,
    }
    public enum EPatternToolAxisSpacingMode : int
    {
        ByCount = 0,
        StepSize = 1,
        Packed = 2,
        EPatternToolAxisSpacingMode_MAX = 3,
    }
    public enum EMeshBoundaryConstraint : int
    {
        Fixed = 7,
        Refine = 5,
        Free = 1,
        EMeshBoundaryConstraint_MAX = 8,
    }
    public enum EGroupBoundaryConstraint : int
    {
        Fixed = 7,
        Refine = 5,
        Free = 1,
        Ignore = 0,
        EGroupBoundaryConstraint_MAX = 8,
    }
    public enum EMaterialBoundaryConstraint : int
    {
        Fixed = 7,
        Refine = 5,
        Free = 1,
        Ignore = 0,
        EMaterialBoundaryConstraint_MAX = 8,
    }
    public enum EAlignObjectsAlignTypes : int
    {
        Pivots = 0,
        BoundingBoxes = 1,
        EAlignObjectsAlignTypes_MAX = 2,
    }
    public enum EAlignObjectsAlignToOptions : int
    {
        FirstSelected = 0,
        LastSelected = 1,
        Combined = 2,
        EAlignObjectsAlignToOptions_MAX = 3,
    }
    public enum EAlignObjectsBoxPoint : int
    {
        Center = 0,
        Bottom = 1,
        Top = 2,
        Left = 3,
        Right = 4,
        Front = 5,
        Back = 6,
        Min = 7,
        Max = 8,
    }
    public enum EBakeTextureResolution : int
    {
        Resolution16 = 16,
        Resolution32 = 32,
        Resolution64 = 64,
        Resolution128 = 128,
        Resolution256 = 256,
        Resolution512 = 512,
        Resolution1024 = 1024,
        Resolution2048 = 2048,
        Resolution4096 = 4096,
        Resolution8192 = 8192,
        EBakeTextureResolution_MAX = 8193,
    }
    public enum EBakeTextureBitDepth : int
    {
        ChannelBits8 = 0,
        ChannelBits16 = 1,
        EBakeTextureBitDepth_MAX = 2,
    }
    public enum EBakeTextureSamplesPerPixel : int
    {
        Sample1 = 1,
        Sample4 = 4,
        Sample16 = 16,
        Sample64 = 64,
        Sample256 = 256,
        EBakeTextureSamplesPerPixel_MAX = 257,
    }
    public enum EBakeMapType : int
    {
        None = 0,
        TangentSpaceNormal = 1,
        ObjectSpaceNormal = 2,
        FaceNormal = 4,
        BentNormal = 8,
        Position = 16,
        Curvature = 32,
        AmbientOcclusion = 64,
        Texture = 128,
        MultiTexture = 256,
        VertexColor = 512,
        MaterialID = 1024,
        All = 2047,
        EBakeMapType_MAX = 2048,
    }
    public enum EBakeVertexOutput : int
    {
        RGBA = 0,
        PerChannel = 1,
        EBakeVertexOutput_MAX = 2,
    }
    public enum EBakeVertexChannel : int
    {
        R = 0,
        G = 1,
        B = 2,
        A = 3,
        RGBA = 4,
        EBakeVertexChannel_MAX = 5,
    }
    public enum EBakeScaleMethod : int
    {
        BakeFullScale = 0,
        BakeNonuniformScale = 1,
        DoNotBakeScale = 2,
        EBakeScaleMethod_MAX = 3,
    }
    public enum EConvertToPolygonsMode : int
    {
        FaceNormalDeviation = 0,
        FindPolygons = 1,
        FromUVIslands = 2,
        FromNormalSeams = 3,
        FromConnectedTris = 4,
        FromFurthestPointSampling = 5,
        CopyFromLayer = 6,
        EConvertToPolygonsMode_MAX = 7,
    }
    public enum ECubeGridToolFaceSelectionMode : int
    {
        OutsideBasedOnNormal = 0,
        InsideBasedOnNormal = 1,
        OutsideBasedOnViewRay = 2,
        InsideBasedOnViewRay = 3,
        ECubeGridToolFaceSelectionMode_MAX = 4,
    }
    public enum ECubeGridToolAction : int
    {
        NoAction = 0,
        Push = 1,
        Pull = 2,
        Flip = 3,
        SlideForward = 4,
        SlideBack = 5,
        DecreaseGridPower = 6,
        IncreaseGridPower = 7,
        CornerMode = 8,
        ResetFromActor = 9,
        Done = 10,
        Cancel = 11,
        ECubeGridToolAction_MAX = 12,
    }
    public enum EGroupTopologyDeformationStrategy : int
    {
        Linear = 0,
        Laplacian = 1,
        EGroupTopologyDeformationStrategy_MAX = 2,
    }
    public enum EWeightScheme : int
    {
        Uniform = 0,
        Umbrella = 1,
        Valence = 2,
        MeanValue = 3,
        Cotangent = 4,
        ClampedCotangent = 5,
        IDTCotangent = 6,
        EWeightScheme_MAX = 7,
    }
    public enum EQuickTransformerMode : int
    {
        AxisTranslation = 0,
        AxisRotation = 1,
        EQuickTransformerMode_MAX = 2,
    }
    public enum EDisplaceMeshToolDisplaceType : int
    {
        Constant = 0,
        DisplacementMap = 1,
        RandomNoise = 2,
        PerlinNoise = 3,
        SineWave = 4,
        EDisplaceMeshToolDisplaceType_MAX = 5,
    }
    public enum EDisplaceMeshToolSubdivisionType : int
    {
        Flat = 0,
        PNTriangles = 1,
        EDisplaceMeshToolSubdivisionType_MAX = 2,
    }
    public enum EDisplaceMeshToolTriangleSelectionType : int
    {
        None = 0,
        Material = 1,
        EDisplaceMeshToolTriangleSelectionType_MAX = 2,
    }
    public enum EDisplaceMeshToolChannelType : int
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Alpha = 3,
        EDisplaceMeshToolChannelType_MAX = 4,
    }
    public enum EDrawPolyPathWidthMode : int
    {
        Fixed = 0,
        Interactive = 1,
        EDrawPolyPathWidthMode_MAX = 2,
    }
    public enum EDrawPolyPathRadiusMode : int
    {
        Fixed = 0,
        Interactive = 1,
        EDrawPolyPathRadiusMode_MAX = 2,
    }
    public enum EDrawPolyPathExtrudeMode : int
    {
        Flat = 0,
        Fixed = 1,
        Interactive = 2,
        RampFixed = 3,
        RampInteractive = 4,
        EDrawPolyPathExtrudeMode_MAX = 5,
    }
    public enum EDrawPolyPathExtrudeDirection : int
    {
        SelectionNormal = 0,
        WorldX = 1,
        WorldY = 2,
        WorldZ = 3,
        LocalX = 4,
        LocalY = 5,
        LocalZ = 6,
        EDrawPolyPathExtrudeDirection_MAX = 7,
    }
    public enum EDynamicMeshSculptBrushType : int
    {
        Move = 0,
        PullKelvin = 1,
        PullSharpKelvin = 2,
        Smooth = 3,
        Offset = 4,
        SculptView = 5,
        SculptMax = 6,
        Inflate = 7,
        ScaleKelvin = 8,
        Pinch = 9,
        TwistKelvin = 10,
        Flatten = 11,
        Plane = 12,
        PlaneViewAligned = 13,
        FixedPlane = 14,
        Resample = 15,
        LastValue = 16,
        EDynamicMeshSculptBrushType_MAX = 17,
    }
    public enum EEditPivotSnapDragRotationMode : int
    {
        Ignore = 0,
        Align = 1,
        AlignFlipped = 2,
        LastValue = 3,
        EEditPivotSnapDragRotationMode_MAX = 4,
    }
    public enum EEditPivotToolActions : int
    {
        NoAction = 0,
        Center = 1,
        Bottom = 2,
        Top = 3,
        Left = 4,
        Right = 5,
        Front = 6,
        Back = 7,
        WorldOrigin = 8,
        EEditPivotToolActions_MAX = 9,
    }
    public enum EHoleFillToolActions : int
    {
        NoAction = 0,
        SelectAll = 1,
        ClearSelection = 2,
        EHoleFillToolActions_MAX = 3,
    }
    public enum ELatticeInterpolationType : int
    {
        Linear = 0,
        Cubic = 1,
        ELatticeInterpolationType_MAX = 2,
    }
    public enum ELatticeDeformerToolAction : int
    {
        NoAction = 0,
        Constrain = 1,
        ClearConstraints = 2,
        ELatticeDeformerToolAction_MAX = 3,
    }
    public enum EBrushActionMode : int
    {
        Paint = 0,
        FloodFill = 1,
        EBrushActionMode_MAX = 2,
    }
    public enum EMeshAttributePaintToolActions : int
    {
        NoAction = 0,
        EMeshAttributePaintToolActions_MAX = 1,
    }
    public enum EMeshGroupPaintInteractionType : int
    {
        Brush = 0,
        Fill = 1,
        GroupFill = 2,
        PolyLasso = 3,
        LastValue = 4,
        EMeshGroupPaintInteractionType_MAX = 5,
    }
    public enum EMeshGroupPaintBrushType : int
    {
        Paint = 0,
        Erase = 1,
        LastValue = 2,
        EMeshGroupPaintBrushType_MAX = 3,
    }
    public enum EMeshGroupPaintBrushAreaType : int
    {
        Connected = 0,
        Volumetric = 1,
        EMeshGroupPaintBrushAreaType_MAX = 2,
    }
    public enum EMeshGroupPaintVisibilityType : int
    {
        None = 0,
        FrontFacing = 1,
        Unoccluded = 2,
        EMeshGroupPaintVisibilityType_MAX = 3,
    }
    public enum EMeshGroupPaintToolActions : int
    {
        NoAction = 0,
        ClearFrozen = 1,
        FreezeCurrent = 2,
        FreezeOthers = 3,
        GrowCurrent = 4,
        ShrinkCurrent = 5,
        ClearCurrent = 6,
        FloodFillCurrent = 7,
        ClearAll = 8,
        EMeshGroupPaintToolActions_MAX = 9,
    }
    public enum EMeshSelectionToolActions : int
    {
        NoAction = 0,
        SelectAll = 1,
        ClearSelection = 2,
        InvertSelection = 3,
        GrowSelection = 4,
        ShrinkSelection = 5,
        ExpandToConnected = 6,
        SelectLargestComponentByTriCount = 7,
        SelectLargestComponentByArea = 8,
        OptimizeSelection = 9,
        DeleteSelected = 10,
        DisconnectSelected = 11,
        SeparateSelected = 12,
        DuplicateSelected = 13,
        FlipSelected = 14,
        CreateGroup = 15,
        SmoothBoundary = 16,
        CycleSelectionMode = 17,
        CycleViewMode = 18,
        EMeshSelectionToolActions_MAX = 19,
    }
    public enum EMeshSelectionToolPrimaryMode : int
    {
        Brush = 0,
        VolumetricBrush = 1,
        AngleFiltered = 2,
        Visible = 3,
        AllConnected = 4,
        AllInGroup = 5,
        ByMaterial = 6,
        ByUVIsland = 7,
        AllWithinAngle = 8,
        EMeshSelectionToolPrimaryMode_MAX = 9,
    }
    public enum EMeshFacesColorMode : int
    {
        None = 0,
        ByGroup = 1,
        ByMaterialID = 2,
        ByUVIsland = 3,
        EMeshFacesColorMode_MAX = 4,
    }
    public enum ENonlinearOperationType : int
    {
        Bend = 0,
        Flare = 1,
        Twist = 2,
        ENonlinearOperationType_MAX = 3,
    }
    public enum EFlareProfileType : int
    {
        SinMode = 0,
        SinSquaredMode = 1,
        TriangleMode = 2,
        EFlareProfileType_MAX = 3,
    }
    public enum EMeshSpaceDeformerToolAction : int
    {
        NoAction = 0,
        ShiftToCenter = 1,
        EMeshSpaceDeformerToolAction_MAX = 2,
    }
    public enum EMeshVertexSculptBrushType : int
    {
        Move = 0,
        PullKelvin = 1,
        PullSharpKelvin = 2,
        Smooth = 3,
        SmoothFill = 4,
        Offset = 5,
        SculptView = 6,
        SculptMax = 7,
        Inflate = 8,
        ScaleKelvin = 9,
        Pinch = 10,
        TwistKelvin = 11,
        Flatten = 12,
        Plane = 13,
        PlaneViewAligned = 14,
        FixedPlane = 15,
        LastValue = 16,
        EMeshVertexSculptBrushType_MAX = 17,
    }
    public enum EMeshVertexSculptBrushFilterType : int
    {
        None = 0,
        Component = 1,
        PolyGroup = 2,
        EMeshVertexSculptBrushFilterType_MAX = 3,
    }
    public enum EMirrorSaveMode : int
    {
        UpdateAssets = 0,
        CreateNewAssets = 1,
        EMirrorSaveMode_MAX = 2,
    }
    public enum EMirrorOperationMode : int
    {
        MirrorAndAppend = 0,
        MirrorExisting = 1,
        EMirrorOperationMode_MAX = 2,
    }
    public enum EMirrorCtrlClickBehavior : int
    {
        Reposition = 0,
        RepositionAndReorient = 1,
        EMirrorCtrlClickBehavior_MAX = 2,
    }
    public enum EMirrorToolAction : int
    {
        NoAction = 0,
        ShiftToCenter = 1,
        Left = 2,
        Right = 3,
        Up = 4,
        Down = 5,
        Forward = 6,
        Backward = 7,
        EMirrorToolAction_MAX = 8,
    }
    public enum EOffsetMeshToolOffsetType : int
    {
        Iterative = 0,
        Implicit = 1,
        EOffsetMeshToolOffsetType_MAX = 2,
    }
    public enum ECollisionGeometryMode : int
    {
        Default = 0,
        SimpleAndComplex = 1,
        UseSimpleAsComplex = 2,
        UseComplexAsSimple = 3,
        ECollisionGeometryMode_MAX = 4,
    }
    public enum EExtractCollisionOutputType : int
    {
        Simple = 0,
        Complex = 1,
        EExtractCollisionOutputType_MAX = 2,
    }
    public enum ESetCollisionGeometryInputMode : int
    {
        CombineAll = 0,
        PerInputObject = 1,
        PerMeshComponent = 2,
        PerMeshGroup = 3,
        ESetCollisionGeometryInputMode_MAX = 4,
    }
    public enum ECollisionGeometryType : int
    {
        KeepExisting = 0,
        AlignedBoxes = 1,
        OrientedBoxes = 2,
        MinimalSpheres = 3,
        Capsules = 4,
        ConvexHulls = 5,
        SweptHulls = 6,
        LevelSets = 7,
        MinVolume = 10,
        None = 11,
        ECollisionGeometryType_MAX = 12,
    }
    public enum EProjectedHullAxis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        SmallestBoxDimension = 3,
        SmallestVolume = 4,
        EProjectedHullAxis_MAX = 5,
    }
    public enum EPlaneCutToolActions : int
    {
        NoAction = 0,
        Cut = 1,
        FlipPlane = 2,
        EPlaneCutToolActions_MAX = 3,
    }
    public enum EOcclusionTriangleSamplingUIMode : int
    {
        Vertices = 0,
        VerticesAndCentroids = 1,
        EOcclusionTriangleSamplingUIMode_MAX = 2,
    }
    public enum EOcclusionCalculationUIMode : int
    {
        GeneralizedWindingNumber = 0,
        RaycastOcclusionSamples = 1,
        EOcclusionCalculationUIMode_MAX = 2,
    }
    public enum EOccludedAction : int
    {
        Remove = 0,
        SetNewGroup = 1,
        EOccludedAction_MAX = 2,
    }
    public enum EBrushToolSizeType : int
    {
        Adaptive = 0,
        World = 1,
        EBrushToolSizeType_MAX = 2,
    }
    public enum EMeshSculptFalloffType : int
    {
        Smooth = 0,
        Linear = 1,
        Inverse = 2,
        Round = 3,
        BoxSmooth = 4,
        BoxLinear = 5,
        BoxInverse = 6,
        BoxRound = 7,
        LastValue = 8,
        EMeshSculptFalloffType_MAX = 9,
    }
    public enum ESkinWeightsBindType : int
    {
        DirectDistance = 0,
        GeodesicVoxel = 3,
        ESkinWeightsBindType_MAX = 4,
    }
    public enum ESmoothMeshToolSmoothType : int
    {
        Iterative = 0,
        Implicit = 1,
        Diffusion = 2,
        ESmoothMeshToolSmoothType_MAX = 3,
    }
    public enum ETransformMeshesTransformMode : int
    {
        SharedGizmo = 0,
        SharedGizmoLocal = 1,
        PerObjectGizmo = 2,
        LastValue = 3,
        ETransformMeshesTransformMode_MAX = 4,
    }
    public enum ETransformMeshesSnapDragSource : int
    {
        ClickPoint = 0,
        Pivot = 1,
        LastValue = 2,
        ETransformMeshesSnapDragSource_MAX = 3,
    }
    public enum ETransformMeshesSnapDragRotationMode : int
    {
        Ignore = 0,
        Align = 1,
        AlignFlipped = 2,
        LastValue = 3,
        ETransformMeshesSnapDragRotationMode_MAX = 4,
    }
    public enum EVoxelBlendOperation : int
    {
        Union = 0,
        Subtract = 1,
        EVoxelBlendOperation_MAX = 2,
    }
    public class BakeMultiMeshDetailProperties : Object
    {
        public BakeMultiMeshDetailProperties(nint addr) : base(addr) { }
        public StaticMesh SourceMesh { get { return this[nameof(SourceMesh)].As<StaticMesh>(); } set { this["SourceMesh"] = value; } }
        public Texture2D SourceTexture { get { return this[nameof(SourceTexture)].As<Texture2D>(); } set { this["SourceTexture"] = value; } }
        public int SourceTextureUVLayer { get { return this[nameof(SourceTextureUVLayer)].GetValue<int>(); } set { this[nameof(SourceTextureUVLayer)].SetValue<int>(value); } }
    }
    public class PerlinLayerProperties : Object
    {
        public PerlinLayerProperties(nint addr) : base(addr) { }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Intensity { get { return this[nameof(Intensity)].GetValue<float>(); } set { this[nameof(Intensity)].SetValue<float>(value); } }
    }
    public class EditPivotTarget : Object
    {
        public EditPivotTarget(nint addr) : base(addr) { }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
    }
    public class PhysicsSphereData : Object
    {
        public PhysicsSphereData(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public KShapeElem Element { get { return this[nameof(Element)].As<KShapeElem>(); } set { this["Element"] = value; } }
    }
    public class PhysicsBoxData : Object
    {
        public PhysicsBoxData(nint addr) : base(addr) { }
        public Vector Dimensions { get { return this[nameof(Dimensions)].As<Vector>(); } set { this["Dimensions"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public KShapeElem Element { get { return this[nameof(Element)].As<KShapeElem>(); } set { this["Element"] = value; } }
    }
    public class PhysicsCapsuleData : Object
    {
        public PhysicsCapsuleData(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public KShapeElem Element { get { return this[nameof(Element)].As<KShapeElem>(); } set { this["Element"] = value; } }
    }
    public class PhysicsConvexData : Object
    {
        public PhysicsConvexData(nint addr) : base(addr) { }
        public int NumVertices { get { return this[nameof(NumVertices)].GetValue<int>(); } set { this[nameof(NumVertices)].SetValue<int>(value); } }
        public int NumFaces { get { return this[nameof(NumFaces)].GetValue<int>(); } set { this[nameof(NumFaces)].SetValue<int>(value); } }
        public KShapeElem Element { get { return this[nameof(Element)].As<KShapeElem>(); } set { this["Element"] = value; } }
    }
    public class PhysicsLevelSetData : Object
    {
        public PhysicsLevelSetData(nint addr) : base(addr) { }
        public KShapeElem Element { get { return this[nameof(Element)].As<KShapeElem>(); } set { this["Element"] = value; } }
    }
    public class BrushToolRadius : Object
    {
        public BrushToolRadius(nint addr) : base(addr) { }
        public EBrushToolSizeType SizeType { get { return (EBrushToolSizeType)this[nameof(SizeType)].GetValue<int>(); } set { this[nameof(SizeType)].SetValue<int>((int)value); } }
        public float AdaptiveSize { get { return this[nameof(AdaptiveSize)].GetValue<float>(); } set { this[nameof(AdaptiveSize)].SetValue<float>(value); } }
        public float WorldRadius { get { return this[nameof(WorldRadius)].GetValue<float>(); } set { this[nameof(WorldRadius)].SetValue<float>(value); } }
    }
    public class TransformMeshesTarget : Object
    {
        public TransformMeshesTarget(nint addr) : base(addr) { }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
    }
}
