using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.InteractiveToolsFrameworkSDK
{
    public class InteractiveToolPropertySet : Object
    {
        public InteractiveToolPropertySet(nint addr) : base(addr) { }
        public Object CachedPropertiesMap { get { return this[nameof(CachedPropertiesMap)]; } set { this[nameof(CachedPropertiesMap)] = value; } }
        public bool bIsPropertySetEnabled { get { return this[nameof(bIsPropertySetEnabled)].Flag; } set { this[nameof(bIsPropertySetEnabled)].Flag = value; } }
    }
    public class InteractiveToolBuilder : Object
    {
        public InteractiveToolBuilder(nint addr) : base(addr) { }
    }
    public class InteractiveToolWithToolTargetsBuilder : InteractiveToolBuilder
    {
        public InteractiveToolWithToolTargetsBuilder(nint addr) : base(addr) { }
    }
    public class InteractiveTool : Object
    {
        public InteractiveTool(nint addr) : base(addr) { }
        public InputBehaviorSet InputBehaviors { get { return this[nameof(InputBehaviors)].As<InputBehaviorSet>(); } set { this["InputBehaviors"] = value; } }
        public Array<Object> ToolPropertyObjects { get { return new Array<Object>(this[nameof(ToolPropertyObjects)].Address); } }
    }
    public class MultiSelectionTool : InteractiveTool
    {
        public MultiSelectionTool(nint addr) : base(addr) { }
        public Array<ToolTarget> Targets { get { return new Array<ToolTarget>(this[nameof(Targets)].Address); } }
    }
    public class SingleClickTool : InteractiveTool
    {
        public SingleClickTool(nint addr) : base(addr) { }
    }
    public class SingleSelectionTool : InteractiveTool
    {
        public SingleSelectionTool(nint addr) : base(addr) { }
        public ToolTarget Target { get { return this[nameof(Target)].As<ToolTarget>(); } set { this["Target"] = value; } }
    }
    public class MeshSurfacePointToolBuilder : InteractiveToolWithToolTargetsBuilder
    {
        public MeshSurfacePointToolBuilder(nint addr) : base(addr) { }
    }
    public class MeshSurfacePointTool : SingleSelectionTool
    {
        public MeshSurfacePointTool(nint addr) : base(addr) { }
        public Object TargetWorld { get { return this[nameof(TargetWorld)]; } set { this[nameof(TargetWorld)] = value; } }
    }
    public class BaseBrushTool : MeshSurfacePointTool
    {
        public BaseBrushTool(nint addr) : base(addr) { }
        public BrushBaseProperties BrushProperties { get { return this[nameof(BrushProperties)].As<BrushBaseProperties>(); } set { this["BrushProperties"] = value; } }
        public bool bInBrushStroke { get { return this[nameof(bInBrushStroke)].Flag; } set { this[nameof(bInBrushStroke)].Flag = value; } }
        public float WorldToLocalScale { get { return this[nameof(WorldToLocalScale)].GetValue<float>(); } set { this[nameof(WorldToLocalScale)].SetValue<float>(value); } }
        public BrushStampData LastBrushStamp { get { return this[nameof(LastBrushStamp)].As<BrushStampData>(); } set { this["LastBrushStamp"] = value; } }
        public Object PropertyClass { get { return this[nameof(PropertyClass)]; } set { this[nameof(PropertyClass)] = value; } }
        public BrushStampIndicator BrushStampIndicator { get { return this[nameof(BrushStampIndicator)].As<BrushStampIndicator>(); } set { this["BrushStampIndicator"] = value; } }
    }
    public class InteractiveCommand : Object
    {
        public InteractiveCommand(nint addr) : base(addr) { }
    }
    public class InteractionMechanic : Object
    {
        public InteractionMechanic(nint addr) : base(addr) { }
    }
    public class InteractiveCommandArguments : Object
    {
        public InteractiveCommandArguments(nint addr) : base(addr) { }
    }
    public class InternalToolFrameworkActor : Actor
    {
        public InternalToolFrameworkActor(nint addr) : base(addr) { }
        public bool bIsSelectableInEditor { get { return this[nameof(bIsSelectableInEditor)].Flag; } set { this[nameof(bIsSelectableInEditor)].Flag = value; } }
    }
    public class SceneSnappingManager : Object
    {
        public SceneSnappingManager(nint addr) : base(addr) { }
    }
    public class AssetBackedTarget : Interface
    {
        public AssetBackedTarget(nint addr) : base(addr) { }
    }
    public class GizmoBaseComponent : PrimitiveComponent
    {
        public GizmoBaseComponent(nint addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public float HoverSizeMultiplier { get { return this[nameof(HoverSizeMultiplier)].GetValue<float>(); } set { this[nameof(HoverSizeMultiplier)].SetValue<float>(value); } }
        public float PixelHitDistanceThreshold { get { return this[nameof(PixelHitDistanceThreshold)].GetValue<float>(); } set { this[nameof(PixelHitDistanceThreshold)].SetValue<float>(value); } }
        public GizmoViewContext GizmoViewContext { get { return this[nameof(GizmoViewContext)].As<GizmoViewContext>(); } set { this["GizmoViewContext"] = value; } }
        public void UpdateWorldLocalState(bool bWorldIn) { Invoke(nameof(UpdateWorldLocalState), bWorldIn); }
        public void UpdateHoverState(bool bHoveringIn) { Invoke(nameof(UpdateHoverState), bHoveringIn); }
    }
    public class GizmoElementBase : Object
    {
        public GizmoElementBase(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool bEnabledForPerspectiveProjection { get { return this[nameof(bEnabledForPerspectiveProjection)].Flag; } set { this[nameof(bEnabledForPerspectiveProjection)].Flag = value; } }
        public bool bEnabledForOrthographicProjection { get { return this[nameof(bEnabledForOrthographicProjection)].Flag; } set { this[nameof(bEnabledForOrthographicProjection)].Flag = value; } }
        public bool bEnabledForDefaultState { get { return this[nameof(bEnabledForDefaultState)].Flag; } set { this[nameof(bEnabledForDefaultState)].Flag = value; } }
        public bool bEnabledForHoveringState { get { return this[nameof(bEnabledForHoveringState)].Flag; } set { this[nameof(bEnabledForHoveringState)].Flag = value; } }
        public bool bEnabledForInteractingState { get { return this[nameof(bEnabledForInteractingState)].Flag; } set { this[nameof(bEnabledForInteractingState)].Flag = value; } }
        public uint PartIdentifier { get { return this[nameof(PartIdentifier)].GetValue<uint>(); } set { this[nameof(PartIdentifier)].SetValue<uint>(value); } }
        public GizmoElementMeshRenderStateAttributes MeshRenderAttributes { get { return this[nameof(MeshRenderAttributes)].As<GizmoElementMeshRenderStateAttributes>(); } set { this["MeshRenderAttributes"] = value; } }
        public EGizmoElementState ElementState { get { return (EGizmoElementState)this[nameof(ElementState)].GetValue<int>(); } set { this[nameof(ElementState)].SetValue<int>((int)value); } }
        public EGizmoElementInteractionState ElementInteractionState { get { return (EGizmoElementInteractionState)this[nameof(ElementInteractionState)].GetValue<int>(); } set { this[nameof(ElementInteractionState)].SetValue<int>((int)value); } }
        public EGizmoElementViewDependentType ViewDependentType { get { return (EGizmoElementViewDependentType)this[nameof(ViewDependentType)].GetValue<int>(); } set { this[nameof(ViewDependentType)].SetValue<int>((int)value); } }
        public Vector ViewDependentAxis { get { return this[nameof(ViewDependentAxis)].As<Vector>(); } set { this["ViewDependentAxis"] = value; } }
        public float ViewDependentAngleTol { get { return this[nameof(ViewDependentAngleTol)].GetValue<float>(); } set { this[nameof(ViewDependentAngleTol)].SetValue<float>(value); } }
        public float ViewDependentAxialMaxCosAngleTol { get { return this[nameof(ViewDependentAxialMaxCosAngleTol)].GetValue<float>(); } set { this[nameof(ViewDependentAxialMaxCosAngleTol)].SetValue<float>(value); } }
        public float ViewDependentPlanarMinCosAngleTol { get { return this[nameof(ViewDependentPlanarMinCosAngleTol)].GetValue<float>(); } set { this[nameof(ViewDependentPlanarMinCosAngleTol)].SetValue<float>(value); } }
        public EGizmoElementViewAlignType ViewAlignType { get { return (EGizmoElementViewAlignType)this[nameof(ViewAlignType)].GetValue<int>(); } set { this[nameof(ViewAlignType)].SetValue<int>((int)value); } }
        public Vector ViewAlignAxis { get { return this[nameof(ViewAlignAxis)].As<Vector>(); } set { this["ViewAlignAxis"] = value; } }
        public Vector ViewAlignNormal { get { return this[nameof(ViewAlignNormal)].As<Vector>(); } set { this["ViewAlignNormal"] = value; } }
        public float ViewAlignAxialAngleTol { get { return this[nameof(ViewAlignAxialAngleTol)].GetValue<float>(); } set { this[nameof(ViewAlignAxialAngleTol)].SetValue<float>(value); } }
        public float ViewAlignAxialMaxCosAngleTol { get { return this[nameof(ViewAlignAxialMaxCosAngleTol)].GetValue<float>(); } set { this[nameof(ViewAlignAxialMaxCosAngleTol)].SetValue<float>(value); } }
        public float PixelHitDistanceThreshold { get { return this[nameof(PixelHitDistanceThreshold)].GetValue<float>(); } set { this[nameof(PixelHitDistanceThreshold)].SetValue<float>(value); } }
    }
    public class GizmoElementLineBase : GizmoElementBase
    {
        public GizmoElementLineBase(nint addr) : base(addr) { }
        public GizmoElementLineRenderStateAttributes LineRenderAttributes { get { return this[nameof(LineRenderAttributes)].As<GizmoElementLineRenderStateAttributes>(); } set { this["LineRenderAttributes"] = value; } }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public bool bScreenSpaceLine { get { return this[nameof(bScreenSpaceLine)].Flag; } set { this[nameof(bScreenSpaceLine)].Flag = value; } }
        public float HoverLineThicknessMultiplier { get { return this[nameof(HoverLineThicknessMultiplier)].GetValue<float>(); } set { this[nameof(HoverLineThicknessMultiplier)].SetValue<float>(value); } }
        public float InteractLineThicknessMultiplier { get { return this[nameof(InteractLineThicknessMultiplier)].GetValue<float>(); } set { this[nameof(InteractLineThicknessMultiplier)].SetValue<float>(value); } }
    }
    public class GizmoElementCircleBase : GizmoElementLineBase
    {
        public GizmoElementCircleBase(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Axis0 { get { return this[nameof(Axis0)].As<Vector>(); } set { this["Axis0"] = value; } }
        public Vector Axis1 { get { return this[nameof(Axis1)].As<Vector>(); } set { this["Axis1"] = value; } }
        public double Radius { get { return this[nameof(Radius)].GetValue<double>(); } set { this[nameof(Radius)].SetValue<double>(value); } }
        public int NumSegments { get { return this[nameof(NumSegments)].GetValue<int>(); } set { this[nameof(NumSegments)].SetValue<int>(value); } }
        public EGizmoElementPartialType PartialType { get { return (EGizmoElementPartialType)this[nameof(PartialType)].GetValue<int>(); } set { this[nameof(PartialType)].SetValue<int>((int)value); } }
        public double PartialStartAngle { get { return this[nameof(PartialStartAngle)].GetValue<double>(); } set { this[nameof(PartialStartAngle)].SetValue<double>(value); } }
        public double PartialEndAngle { get { return this[nameof(PartialEndAngle)].GetValue<double>(); } set { this[nameof(PartialEndAngle)].SetValue<double>(value); } }
        public double PartialViewDependentMaxCosTol { get { return this[nameof(PartialViewDependentMaxCosTol)].GetValue<double>(); } set { this[nameof(PartialViewDependentMaxCosTol)].SetValue<double>(value); } }
    }
    public class GizmoElementArc : GizmoElementCircleBase
    {
        public GizmoElementArc(nint addr) : base(addr) { }
        public double InnerRadius { get { return this[nameof(InnerRadius)].GetValue<double>(); } set { this[nameof(InnerRadius)].SetValue<double>(value); } }
    }
    public class InteractiveGizmoBuilder : Object
    {
        public InteractiveGizmoBuilder(nint addr) : base(addr) { }
    }
    public class ToolContextTransactionProvider : Interface
    {
        public ToolContextTransactionProvider(nint addr) : base(addr) { }
    }
    public class ToolFrameworkComponent : Interface
    {
        public ToolFrameworkComponent(nint addr) : base(addr) { }
    }
    public class InteractiveToolCameraFocusAPI : Interface
    {
        public InteractiveToolCameraFocusAPI(nint addr) : base(addr) { }
    }
    public class InteractiveToolNestedAcceptCancelAPI : Interface
    {
        public InteractiveToolNestedAcceptCancelAPI(nint addr) : base(addr) { }
    }
    public class InteractiveToolExclusiveToolAPI : Interface
    {
        public InteractiveToolExclusiveToolAPI(nint addr) : base(addr) { }
    }
    public class MaterialProvider : Interface
    {
        public MaterialProvider(nint addr) : base(addr) { }
    }
    public class MeshDescriptionCommitter : Interface
    {
        public MeshDescriptionCommitter(nint addr) : base(addr) { }
    }
    public class MeshDescriptionProvider : Interface
    {
        public MeshDescriptionProvider(nint addr) : base(addr) { }
    }
    public class GizmoBaseVec2ParameterSource : Object
    {
        public GizmoBaseVec2ParameterSource(nint addr) : base(addr) { }
    }
    public class GizmoLocalVec2ParameterSource : GizmoBaseVec2ParameterSource
    {
        public GizmoLocalVec2ParameterSource(nint addr) : base(addr) { }
        public Vector2D Value { get { return this[nameof(Value)].As<Vector2D>(); } set { this["Value"] = value; } }
        public GizmoVec2ParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoVec2ParameterChange>(); } set { this["LastChange"] = value; } }
    }
    public class GizmoBaseFloatParameterSource : Object
    {
        public GizmoBaseFloatParameterSource(nint addr) : base(addr) { }
    }
    public class GizmoAxisTranslationParameterSource : GizmoBaseFloatParameterSource
    {
        public GizmoAxisTranslationParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public float Parameter { get { return this[nameof(Parameter)].GetValue<float>(); } set { this[nameof(Parameter)].SetValue<float>(value); } }
        public GizmoFloatParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoFloatParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurTranslationAxis { get { return this[nameof(CurTranslationAxis)].As<Vector>(); } set { this["CurTranslationAxis"] = value; } }
        public Vector CurTranslationOrigin { get { return this[nameof(CurTranslationOrigin)].As<Vector>(); } set { this["CurTranslationOrigin"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class GizmoPlaneTranslationParameterSource : GizmoBaseVec2ParameterSource
    {
        public GizmoPlaneTranslationParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public Vector2D Parameter { get { return this[nameof(Parameter)].As<Vector2D>(); } set { this["Parameter"] = value; } }
        public GizmoVec2ParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoVec2ParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurTranslationOrigin { get { return this[nameof(CurTranslationOrigin)].As<Vector>(); } set { this["CurTranslationOrigin"] = value; } }
        public Vector CurTranslationNormal { get { return this[nameof(CurTranslationNormal)].As<Vector>(); } set { this["CurTranslationNormal"] = value; } }
        public Vector CurTranslationAxisX { get { return this[nameof(CurTranslationAxisX)].As<Vector>(); } set { this["CurTranslationAxisX"] = value; } }
        public Vector CurTranslationAxisY { get { return this[nameof(CurTranslationAxisY)].As<Vector>(); } set { this["CurTranslationAxisY"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class GizmoAxisRotationParameterSource : GizmoBaseFloatParameterSource
    {
        public GizmoAxisRotationParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public float Angle { get { return this[nameof(Angle)].GetValue<float>(); } set { this[nameof(Angle)].SetValue<float>(value); } }
        public GizmoFloatParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoFloatParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurRotationAxis { get { return this[nameof(CurRotationAxis)].As<Vector>(); } set { this["CurRotationAxis"] = value; } }
        public Vector CurRotationOrigin { get { return this[nameof(CurRotationOrigin)].As<Vector>(); } set { this["CurRotationOrigin"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class GizmoUniformScaleParameterSource : GizmoBaseVec2ParameterSource
    {
        public GizmoUniformScaleParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public float ScaleMultiplier { get { return this[nameof(ScaleMultiplier)].GetValue<float>(); } set { this[nameof(ScaleMultiplier)].SetValue<float>(value); } }
        public Vector2D Parameter { get { return this[nameof(Parameter)].As<Vector2D>(); } set { this["Parameter"] = value; } }
        public GizmoVec2ParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoVec2ParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurScaleOrigin { get { return this[nameof(CurScaleOrigin)].As<Vector>(); } set { this["CurScaleOrigin"] = value; } }
        public Vector CurScaleNormal { get { return this[nameof(CurScaleNormal)].As<Vector>(); } set { this["CurScaleNormal"] = value; } }
        public Vector CurScaleAxisX { get { return this[nameof(CurScaleAxisX)].As<Vector>(); } set { this["CurScaleAxisX"] = value; } }
        public Vector CurScaleAxisY { get { return this[nameof(CurScaleAxisY)].As<Vector>(); } set { this["CurScaleAxisY"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class GizmoAxisScaleParameterSource : GizmoBaseFloatParameterSource
    {
        public GizmoAxisScaleParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public float ScaleMultiplier { get { return this[nameof(ScaleMultiplier)].GetValue<float>(); } set { this[nameof(ScaleMultiplier)].SetValue<float>(value); } }
        public bool bClampToZero { get { return this[nameof(bClampToZero)].Flag; } set { this[nameof(bClampToZero)].Flag = value; } }
        public float Parameter { get { return this[nameof(Parameter)].GetValue<float>(); } set { this[nameof(Parameter)].SetValue<float>(value); } }
        public GizmoFloatParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoFloatParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurScaleAxis { get { return this[nameof(CurScaleAxis)].As<Vector>(); } set { this["CurScaleAxis"] = value; } }
        public Vector CurScaleOrigin { get { return this[nameof(CurScaleOrigin)].As<Vector>(); } set { this["CurScaleOrigin"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class GizmoPlaneScaleParameterSource : GizmoBaseVec2ParameterSource
    {
        public GizmoPlaneScaleParameterSource(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object TransformSource { get { return this[nameof(TransformSource)]; } set { this[nameof(TransformSource)] = value; } }
        public float ScaleMultiplier { get { return this[nameof(ScaleMultiplier)].GetValue<float>(); } set { this[nameof(ScaleMultiplier)].SetValue<float>(value); } }
        public bool bUseEqualScaling { get { return this[nameof(bUseEqualScaling)].Flag; } set { this[nameof(bUseEqualScaling)].Flag = value; } }
        public bool bClampToZero { get { return this[nameof(bClampToZero)].Flag; } set { this[nameof(bClampToZero)].Flag = value; } }
        public Vector2D Parameter { get { return this[nameof(Parameter)].As<Vector2D>(); } set { this["Parameter"] = value; } }
        public GizmoVec2ParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoVec2ParameterChange>(); } set { this["LastChange"] = value; } }
        public Vector CurScaleOrigin { get { return this[nameof(CurScaleOrigin)].As<Vector>(); } set { this["CurScaleOrigin"] = value; } }
        public Vector CurScaleNormal { get { return this[nameof(CurScaleNormal)].As<Vector>(); } set { this["CurScaleNormal"] = value; } }
        public Vector CurScaleAxisX { get { return this[nameof(CurScaleAxisX)].As<Vector>(); } set { this["CurScaleAxisX"] = value; } }
        public Vector CurScaleAxisY { get { return this[nameof(CurScaleAxisY)].As<Vector>(); } set { this["CurScaleAxisY"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
    }
    public class PhysicsDataSource : Interface
    {
        public PhysicsDataSource(nint addr) : base(addr) { }
    }
    public class PrimitiveComponentBackedTarget : Interface
    {
        public PrimitiveComponentBackedTarget(nint addr) : base(addr) { }
    }
    public class SkeletalMeshBackedTarget : AssetBackedTarget
    {
        public SkeletalMeshBackedTarget(nint addr) : base(addr) { }
    }
    public class StaticMeshBackedTarget : AssetBackedTarget
    {
        public StaticMeshBackedTarget(nint addr) : base(addr) { }
    }
    public class InputBehavior : Object
    {
        public InputBehavior(nint addr) : base(addr) { }
    }
    public class AnyButtonInputBehavior : InputBehavior
    {
        public AnyButtonInputBehavior(nint addr) : base(addr) { }
    }
    public class ClickDragInputBehavior : AnyButtonInputBehavior
    {
        public ClickDragInputBehavior(nint addr) : base(addr) { }
        public bool bUpdateModifiersDuringDrag { get { return this[nameof(bUpdateModifiersDuringDrag)].Flag; } set { this[nameof(bUpdateModifiersDuringDrag)].Flag = value; } }
    }
    public class LocalClickDragInputBehavior : ClickDragInputBehavior
    {
        public LocalClickDragInputBehavior(nint addr) : base(addr) { }
    }
    public class KeyAsModifierInputBehavior : InputBehavior
    {
        public KeyAsModifierInputBehavior(nint addr) : base(addr) { }
    }
    public class MouseHoverBehavior : InputBehavior
    {
        public MouseHoverBehavior(nint addr) : base(addr) { }
    }
    public class LocalMouseHoverBehavior : MouseHoverBehavior
    {
        public LocalMouseHoverBehavior(nint addr) : base(addr) { }
    }
    public class MouseWheelInputBehavior : AnyButtonInputBehavior
    {
        public MouseWheelInputBehavior(nint addr) : base(addr) { }
    }
    public class MultiClickSequenceInputBehavior : AnyButtonInputBehavior
    {
        public MultiClickSequenceInputBehavior(nint addr) : base(addr) { }
    }
    public class SingleClickInputBehavior : AnyButtonInputBehavior
    {
        public SingleClickInputBehavior(nint addr) : base(addr) { }
        public bool HitTestOnRelease { get { return this[nameof(HitTestOnRelease)].Flag; } set { this[nameof(HitTestOnRelease)].Flag = value; } }
    }
    public class LocalSingleClickInputBehavior : SingleClickInputBehavior
    {
        public LocalSingleClickInputBehavior(nint addr) : base(addr) { }
    }
    public class SingleClickOrDragInputBehavior : AnyButtonInputBehavior
    {
        public SingleClickOrDragInputBehavior(nint addr) : base(addr) { }
        public bool bBeginDragIfClickTargetNotHit { get { return this[nameof(bBeginDragIfClickTargetNotHit)].Flag; } set { this[nameof(bBeginDragIfClickTargetNotHit)].Flag = value; } }
        public float ClickDistanceThreshold { get { return this[nameof(ClickDistanceThreshold)].GetValue<float>(); } set { this[nameof(ClickDistanceThreshold)].SetValue<float>(value); } }
    }
    public class SingleKeyCaptureBehavior : InputBehavior
    {
        public SingleKeyCaptureBehavior(nint addr) : base(addr) { }
    }
    public class WidgetBaseBehavior : Interface
    {
        public WidgetBaseBehavior(nint addr) : base(addr) { }
    }
    public class AxisAngleGizmoBuilder : InteractiveGizmoBuilder
    {
        public AxisAngleGizmoBuilder(nint addr) : base(addr) { }
    }
    public class InteractiveGizmo : Object
    {
        public InteractiveGizmo(nint addr) : base(addr) { }
        public InputBehaviorSet InputBehaviors { get { return this[nameof(InputBehaviors)].As<InputBehaviorSet>(); } set { this["InputBehaviors"] = value; } }
    }
    public class AxisAngleGizmo : InteractiveGizmo
    {
        public AxisAngleGizmo(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object AngleSource { get { return this[nameof(AngleSource)]; } set { this[nameof(AngleSource)] = value; } }
        public Object HitTarget { get { return this[nameof(HitTarget)]; } set { this[nameof(HitTarget)] = value; } }
        public Object StateTarget { get { return this[nameof(StateTarget)]; } set { this[nameof(StateTarget)] = value; } }
        public ClickDragInputBehavior MouseBehavior { get { return this[nameof(MouseBehavior)].As<ClickDragInputBehavior>(); } set { this["MouseBehavior"] = value; } }
        public bool bInInteraction { get { return this[nameof(bInInteraction)].Flag; } set { this[nameof(bInInteraction)].Flag = value; } }
        public Vector RotationOrigin { get { return this[nameof(RotationOrigin)].As<Vector>(); } set { this["RotationOrigin"] = value; } }
        public Vector RotationAxis { get { return this[nameof(RotationAxis)].As<Vector>(); } set { this["RotationAxis"] = value; } }
        public Vector RotationPlaneX { get { return this[nameof(RotationPlaneX)].As<Vector>(); } set { this["RotationPlaneX"] = value; } }
        public Vector RotationPlaneY { get { return this[nameof(RotationPlaneY)].As<Vector>(); } set { this["RotationPlaneY"] = value; } }
        public Vector InteractionStartPoint { get { return this[nameof(InteractionStartPoint)].As<Vector>(); } set { this["InteractionStartPoint"] = value; } }
        public Vector InteractionCurPoint { get { return this[nameof(InteractionCurPoint)].As<Vector>(); } set { this["InteractionCurPoint"] = value; } }
        public float InteractionStartAngle { get { return this[nameof(InteractionStartAngle)].GetValue<float>(); } set { this[nameof(InteractionStartAngle)].SetValue<float>(value); } }
        public float InteractionCurAngle { get { return this[nameof(InteractionCurAngle)].GetValue<float>(); } set { this[nameof(InteractionCurAngle)].SetValue<float>(value); } }
    }
    public class AxisPositionGizmoBuilder : InteractiveGizmoBuilder
    {
        public AxisPositionGizmoBuilder(nint addr) : base(addr) { }
    }
    public class AxisPositionGizmo : InteractiveGizmo
    {
        public AxisPositionGizmo(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object ParameterSource { get { return this[nameof(ParameterSource)]; } set { this[nameof(ParameterSource)] = value; } }
        public GizmoViewContext GizmoViewContext { get { return this[nameof(GizmoViewContext)].As<GizmoViewContext>(); } set { this["GizmoViewContext"] = value; } }
        public Object HitTarget { get { return this[nameof(HitTarget)]; } set { this[nameof(HitTarget)] = value; } }
        public Object StateTarget { get { return this[nameof(StateTarget)]; } set { this[nameof(StateTarget)] = value; } }
        public ClickDragInputBehavior MouseBehavior { get { return this[nameof(MouseBehavior)].As<ClickDragInputBehavior>(); } set { this["MouseBehavior"] = value; } }
        public bool bEnableSignedAxis { get { return this[nameof(bEnableSignedAxis)].Flag; } set { this[nameof(bEnableSignedAxis)].Flag = value; } }
        public bool bInInteraction { get { return this[nameof(bInInteraction)].Flag; } set { this[nameof(bInInteraction)].Flag = value; } }
        public Vector InteractionOrigin { get { return this[nameof(InteractionOrigin)].As<Vector>(); } set { this["InteractionOrigin"] = value; } }
        public Vector InteractionAxis { get { return this[nameof(InteractionAxis)].As<Vector>(); } set { this["InteractionAxis"] = value; } }
        public Vector InteractionStartPoint { get { return this[nameof(InteractionStartPoint)].As<Vector>(); } set { this["InteractionStartPoint"] = value; } }
        public Vector InteractionCurPoint { get { return this[nameof(InteractionCurPoint)].As<Vector>(); } set { this["InteractionCurPoint"] = value; } }
        public float InteractionStartParameter { get { return this[nameof(InteractionStartParameter)].GetValue<float>(); } set { this[nameof(InteractionStartParameter)].SetValue<float>(value); } }
        public float InteractionCurParameter { get { return this[nameof(InteractionCurParameter)].GetValue<float>(); } set { this[nameof(InteractionCurParameter)].SetValue<float>(value); } }
        public float ParameterSign { get { return this[nameof(ParameterSign)].GetValue<float>(); } set { this[nameof(ParameterSign)].SetValue<float>(value); } }
    }
    public class GizmoConstantAxisSource : Object
    {
        public GizmoConstantAxisSource(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
    }
    public class GizmoConstantFrameAxisSource : Object
    {
        public GizmoConstantFrameAxisSource(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public Vector TangentX { get { return this[nameof(TangentX)].As<Vector>(); } set { this["TangentX"] = value; } }
        public Vector TangentY { get { return this[nameof(TangentY)].As<Vector>(); } set { this["TangentY"] = value; } }
    }
    public class GizmoWorldAxisSource : Object
    {
        public GizmoWorldAxisSource(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public int AxisIndex { get { return this[nameof(AxisIndex)].GetValue<int>(); } set { this[nameof(AxisIndex)].SetValue<int>(value); } }
    }
    public class GizmoComponentAxisSource : Object
    {
        public GizmoComponentAxisSource(nint addr) : base(addr) { }
        public SceneComponent Component { get { return this[nameof(Component)].As<SceneComponent>(); } set { this["Component"] = value; } }
        public int AxisIndex { get { return this[nameof(AxisIndex)].GetValue<int>(); } set { this[nameof(AxisIndex)].SetValue<int>(value); } }
        public bool bLocalAxes { get { return this[nameof(bLocalAxes)].Flag; } set { this[nameof(bLocalAxes)].Flag = value; } }
    }
    public class BrushStampIndicatorBuilder : InteractiveGizmoBuilder
    {
        public BrushStampIndicatorBuilder(nint addr) : base(addr) { }
    }
    public class BrushStampIndicator : InteractiveGizmo
    {
        public BrushStampIndicator(nint addr) : base(addr) { }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public float BrushRadius { get { return this[nameof(BrushRadius)].GetValue<float>(); } set { this[nameof(BrushRadius)].SetValue<float>(value); } }
        public float BrushFalloff { get { return this[nameof(BrushFalloff)].GetValue<float>(); } set { this[nameof(BrushFalloff)].SetValue<float>(value); } }
        public Vector BrushPosition { get { return this[nameof(BrushPosition)].As<Vector>(); } set { this["BrushPosition"] = value; } }
        public Vector BrushNormal { get { return this[nameof(BrushNormal)].As<Vector>(); } set { this["BrushNormal"] = value; } }
        public bool bDrawIndicatorLines { get { return this[nameof(bDrawIndicatorLines)].Flag; } set { this[nameof(bDrawIndicatorLines)].Flag = value; } }
        public bool bDrawRadiusCircle { get { return this[nameof(bDrawRadiusCircle)].Flag; } set { this[nameof(bDrawRadiusCircle)].Flag = value; } }
        public int SampleStepCount { get { return this[nameof(SampleStepCount)].GetValue<int>(); } set { this[nameof(SampleStepCount)].SetValue<int>(value); } }
        public LinearColor LineColor { get { return this[nameof(LineColor)].As<LinearColor>(); } set { this["LineColor"] = value; } }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public bool bDepthTested { get { return this[nameof(bDepthTested)].Flag; } set { this[nameof(bDepthTested)].Flag = value; } }
        public bool bDrawSecondaryLines { get { return this[nameof(bDrawSecondaryLines)].Flag; } set { this[nameof(bDrawSecondaryLines)].Flag = value; } }
        public float SecondaryLineThickness { get { return this[nameof(SecondaryLineThickness)].GetValue<float>(); } set { this[nameof(SecondaryLineThickness)].SetValue<float>(value); } }
        public LinearColor SecondaryLineColor { get { return this[nameof(SecondaryLineColor)].As<LinearColor>(); } set { this["SecondaryLineColor"] = value; } }
        public PrimitiveComponent AttachedComponent { get { return this[nameof(AttachedComponent)].As<PrimitiveComponent>(); } set { this["AttachedComponent"] = value; } }
    }
    public class GizmoActor : InternalToolFrameworkActor
    {
        public GizmoActor(nint addr) : base(addr) { }
    }
    public class CombinedTransformGizmoActor : GizmoActor
    {
        public CombinedTransformGizmoActor(nint addr) : base(addr) { }
        public PrimitiveComponent TranslateX { get { return this[nameof(TranslateX)].As<PrimitiveComponent>(); } set { this["TranslateX"] = value; } }
        public PrimitiveComponent TranslateY { get { return this[nameof(TranslateY)].As<PrimitiveComponent>(); } set { this["TranslateY"] = value; } }
        public PrimitiveComponent TranslateZ { get { return this[nameof(TranslateZ)].As<PrimitiveComponent>(); } set { this["TranslateZ"] = value; } }
        public PrimitiveComponent TranslateYZ { get { return this[nameof(TranslateYZ)].As<PrimitiveComponent>(); } set { this["TranslateYZ"] = value; } }
        public PrimitiveComponent TranslateXZ { get { return this[nameof(TranslateXZ)].As<PrimitiveComponent>(); } set { this["TranslateXZ"] = value; } }
        public PrimitiveComponent TranslateXY { get { return this[nameof(TranslateXY)].As<PrimitiveComponent>(); } set { this["TranslateXY"] = value; } }
        public PrimitiveComponent RotateX { get { return this[nameof(RotateX)].As<PrimitiveComponent>(); } set { this["RotateX"] = value; } }
        public PrimitiveComponent RotateY { get { return this[nameof(RotateY)].As<PrimitiveComponent>(); } set { this["RotateY"] = value; } }
        public PrimitiveComponent RotateZ { get { return this[nameof(RotateZ)].As<PrimitiveComponent>(); } set { this["RotateZ"] = value; } }
        public PrimitiveComponent UniformScale { get { return this[nameof(UniformScale)].As<PrimitiveComponent>(); } set { this["UniformScale"] = value; } }
        public PrimitiveComponent AxisScaleX { get { return this[nameof(AxisScaleX)].As<PrimitiveComponent>(); } set { this["AxisScaleX"] = value; } }
        public PrimitiveComponent AxisScaleY { get { return this[nameof(AxisScaleY)].As<PrimitiveComponent>(); } set { this["AxisScaleY"] = value; } }
        public PrimitiveComponent AxisScaleZ { get { return this[nameof(AxisScaleZ)].As<PrimitiveComponent>(); } set { this["AxisScaleZ"] = value; } }
        public PrimitiveComponent PlaneScaleYZ { get { return this[nameof(PlaneScaleYZ)].As<PrimitiveComponent>(); } set { this["PlaneScaleYZ"] = value; } }
        public PrimitiveComponent PlaneScaleXZ { get { return this[nameof(PlaneScaleXZ)].As<PrimitiveComponent>(); } set { this["PlaneScaleXZ"] = value; } }
        public PrimitiveComponent PlaneScaleXY { get { return this[nameof(PlaneScaleXY)].As<PrimitiveComponent>(); } set { this["PlaneScaleXY"] = value; } }
    }
    public class CombinedTransformGizmoBuilder : InteractiveGizmoBuilder
    {
        public CombinedTransformGizmoBuilder(nint addr) : base(addr) { }
    }
    public class CombinedTransformGizmo : InteractiveGizmo
    {
        public CombinedTransformGizmo(nint addr) : base(addr) { }
        public TransformProxy ActiveTarget { get { return this[nameof(ActiveTarget)].As<TransformProxy>(); } set { this["ActiveTarget"] = value; } }
        public bool bSnapToWorldGrid { get { return this[nameof(bSnapToWorldGrid)].Flag; } set { this[nameof(bSnapToWorldGrid)].Flag = value; } }
        public bool bGridSizeIsExplicit { get { return this[nameof(bGridSizeIsExplicit)].Flag; } set { this[nameof(bGridSizeIsExplicit)].Flag = value; } }
        public Vector ExplicitGridSize { get { return this[nameof(ExplicitGridSize)].As<Vector>(); } set { this["ExplicitGridSize"] = value; } }
        public bool bRotationGridSizeIsExplicit { get { return this[nameof(bRotationGridSizeIsExplicit)].Flag; } set { this[nameof(bRotationGridSizeIsExplicit)].Flag = value; } }
        public Rotator ExplicitRotationGridSize { get { return this[nameof(ExplicitRotationGridSize)].As<Rotator>(); } set { this["ExplicitRotationGridSize"] = value; } }
        public bool bSnapToWorldRotGrid { get { return this[nameof(bSnapToWorldRotGrid)].Flag; } set { this[nameof(bSnapToWorldRotGrid)].Flag = value; } }
        public bool bUseContextCoordinateSystem { get { return this[nameof(bUseContextCoordinateSystem)].Flag; } set { this[nameof(bUseContextCoordinateSystem)].Flag = value; } }
        public EToolContextCoordinateSystem CurrentCoordinateSystem { get { return (EToolContextCoordinateSystem)this[nameof(CurrentCoordinateSystem)].GetValue<int>(); } set { this[nameof(CurrentCoordinateSystem)].SetValue<int>((int)value); } }
        public Array<PrimitiveComponent> ActiveComponents { get { return new Array<PrimitiveComponent>(this[nameof(ActiveComponents)].Address); } }
        public Array<PrimitiveComponent> NonuniformScaleComponents { get { return new Array<PrimitiveComponent>(this[nameof(NonuniformScaleComponents)].Address); } }
        public Array<InteractiveGizmo> ActiveGizmos { get { return new Array<InteractiveGizmo>(this[nameof(ActiveGizmos)].Address); } }
        public GizmoConstantFrameAxisSource CameraAxisSource { get { return this[nameof(CameraAxisSource)].As<GizmoConstantFrameAxisSource>(); } set { this["CameraAxisSource"] = value; } }
        public GizmoComponentAxisSource AxisXSource { get { return this[nameof(AxisXSource)].As<GizmoComponentAxisSource>(); } set { this["AxisXSource"] = value; } }
        public GizmoComponentAxisSource AxisYSource { get { return this[nameof(AxisYSource)].As<GizmoComponentAxisSource>(); } set { this["AxisYSource"] = value; } }
        public GizmoComponentAxisSource AxisZSource { get { return this[nameof(AxisZSource)].As<GizmoComponentAxisSource>(); } set { this["AxisZSource"] = value; } }
        public GizmoComponentAxisSource UnitAxisXSource { get { return this[nameof(UnitAxisXSource)].As<GizmoComponentAxisSource>(); } set { this["UnitAxisXSource"] = value; } }
        public GizmoComponentAxisSource UnitAxisYSource { get { return this[nameof(UnitAxisYSource)].As<GizmoComponentAxisSource>(); } set { this["UnitAxisYSource"] = value; } }
        public GizmoComponentAxisSource UnitAxisZSource { get { return this[nameof(UnitAxisZSource)].As<GizmoComponentAxisSource>(); } set { this["UnitAxisZSource"] = value; } }
        public GizmoTransformChangeStateTarget StateTarget { get { return this[nameof(StateTarget)].As<GizmoTransformChangeStateTarget>(); } set { this["StateTarget"] = value; } }
    }
    public class GizmoArrowComponent : GizmoBaseComponent
    {
        public GizmoArrowComponent(nint addr) : base(addr) { }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public float Gap { get { return this[nameof(Gap)].GetValue<float>(); } set { this[nameof(Gap)].SetValue<float>(value); } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
    }
    public class GizmoBoxComponent : GizmoBaseComponent
    {
        public GizmoBoxComponent(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Vector Dimensions { get { return this[nameof(Dimensions)].As<Vector>(); } set { this["Dimensions"] = value; } }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public bool bRemoveHiddenLines { get { return this[nameof(bRemoveHiddenLines)].Flag; } set { this[nameof(bRemoveHiddenLines)].Flag = value; } }
        public bool bEnableAxisFlip { get { return this[nameof(bEnableAxisFlip)].Flag; } set { this[nameof(bEnableAxisFlip)].Flag = value; } }
    }
    public class GizmoCircleComponent : GizmoBaseComponent
    {
        public GizmoCircleComponent(nint addr) : base(addr) { }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
        public int NumSides { get { return this[nameof(NumSides)].GetValue<int>(); } set { this[nameof(NumSides)].SetValue<int>(value); } }
        public bool bViewAligned { get { return this[nameof(bViewAligned)].Flag; } set { this[nameof(bViewAligned)].Flag = value; } }
        public bool bDrawFullCircle { get { return this[nameof(bDrawFullCircle)].Flag; } set { this[nameof(bDrawFullCircle)].Flag = value; } }
        public bool bOnlyAllowFrontFacingHits { get { return this[nameof(bOnlyAllowFrontFacingHits)].Flag; } set { this[nameof(bOnlyAllowFrontFacingHits)].Flag = value; } }
    }
    public class GizmoElementArrow : GizmoElementBase
    {
        public GizmoElementArrow(nint addr) : base(addr) { }
        public GizmoElementCylinder CylinderElement { get { return this[nameof(CylinderElement)].As<GizmoElementCylinder>(); } set { this["CylinderElement"] = value; } }
        public GizmoElementCone ConeElement { get { return this[nameof(ConeElement)].As<GizmoElementCone>(); } set { this["ConeElement"] = value; } }
        public GizmoElementBox BoxElement { get { return this[nameof(BoxElement)].As<GizmoElementBox>(); } set { this["BoxElement"] = value; } }
        public Vector Base { get { return this[nameof(Base)].As<Vector>(); } set { this["Base"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public Vector SideDirection { get { return this[nameof(SideDirection)].As<Vector>(); } set { this["SideDirection"] = value; } }
        public float BodyLength { get { return this[nameof(BodyLength)].GetValue<float>(); } set { this[nameof(BodyLength)].SetValue<float>(value); } }
        public float BodyRadius { get { return this[nameof(BodyRadius)].GetValue<float>(); } set { this[nameof(BodyRadius)].SetValue<float>(value); } }
        public float HeadLength { get { return this[nameof(HeadLength)].GetValue<float>(); } set { this[nameof(HeadLength)].SetValue<float>(value); } }
        public float HeadRadius { get { return this[nameof(HeadRadius)].GetValue<float>(); } set { this[nameof(HeadRadius)].SetValue<float>(value); } }
        public int NumSides { get { return this[nameof(NumSides)].GetValue<int>(); } set { this[nameof(NumSides)].SetValue<int>(value); } }
        public EGizmoElementArrowHeadType HeadType { get { return (EGizmoElementArrowHeadType)this[nameof(HeadType)].GetValue<int>(); } set { this[nameof(HeadType)].SetValue<int>((int)value); } }
    }
    public class GizmoElementBox : GizmoElementBase
    {
        public GizmoElementBox(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Dimensions { get { return this[nameof(Dimensions)].As<Vector>(); } set { this["Dimensions"] = value; } }
        public Vector UpDirection { get { return this[nameof(UpDirection)].As<Vector>(); } set { this["UpDirection"] = value; } }
        public Vector SideDirection { get { return this[nameof(SideDirection)].As<Vector>(); } set { this["SideDirection"] = value; } }
    }
    public class GizmoElementCircle : GizmoElementCircleBase
    {
        public GizmoElementCircle(nint addr) : base(addr) { }
        public bool bDrawMesh { get { return this[nameof(bDrawMesh)].Flag; } set { this[nameof(bDrawMesh)].Flag = value; } }
        public bool bDrawLine { get { return this[nameof(bDrawLine)].Flag; } set { this[nameof(bDrawLine)].Flag = value; } }
        public bool bHitMesh { get { return this[nameof(bHitMesh)].Flag; } set { this[nameof(bHitMesh)].Flag = value; } }
        public bool bHitLine { get { return this[nameof(bHitLine)].Flag; } set { this[nameof(bHitLine)].Flag = value; } }
    }
    public class GizmoElementCone : GizmoElementBase
    {
        public GizmoElementCone(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int NumSides { get { return this[nameof(NumSides)].GetValue<int>(); } set { this[nameof(NumSides)].SetValue<int>(value); } }
    }
    public class GizmoElementCylinder : GizmoElementBase
    {
        public GizmoElementCylinder(nint addr) : base(addr) { }
        public Vector Base { get { return this[nameof(Base)].As<Vector>(); } set { this["Base"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int NumSides { get { return this[nameof(NumSides)].GetValue<int>(); } set { this[nameof(NumSides)].SetValue<int>(value); } }
    }
    public class GizmoElementGroup : GizmoElementLineBase
    {
        public GizmoElementGroup(nint addr) : base(addr) { }
        public bool bConstantScale { get { return this[nameof(bConstantScale)].Flag; } set { this[nameof(bConstantScale)].Flag = value; } }
        public bool bHitOwner { get { return this[nameof(bHitOwner)].Flag; } set { this[nameof(bHitOwner)].Flag = value; } }
        public Array<GizmoElementBase> Elements { get { return new Array<GizmoElementBase>(this[nameof(Elements)].Address); } }
    }
    public class GizmoElementHitTarget : Object
    {
        public GizmoElementHitTarget(nint addr) : base(addr) { }
        public GizmoElementBase GizmoElement { get { return this[nameof(GizmoElement)].As<GizmoElementBase>(); } set { this["GizmoElement"] = value; } }
        public GizmoViewContext GizmoViewContext { get { return this[nameof(GizmoViewContext)].As<GizmoViewContext>(); } set { this["GizmoViewContext"] = value; } }
        public TransformProxy GizmoTransformProxy { get { return this[nameof(GizmoTransformProxy)].As<TransformProxy>(); } set { this["GizmoTransformProxy"] = value; } }
    }
    public class GizmoElementHitMultiTarget : Object
    {
        public GizmoElementHitMultiTarget(nint addr) : base(addr) { }
        public GizmoElementBase GizmoElement { get { return this[nameof(GizmoElement)].As<GizmoElementBase>(); } set { this["GizmoElement"] = value; } }
        public GizmoViewContext GizmoViewContext { get { return this[nameof(GizmoViewContext)].As<GizmoViewContext>(); } set { this["GizmoViewContext"] = value; } }
        public TransformProxy GizmoTransformProxy { get { return this[nameof(GizmoTransformProxy)].As<TransformProxy>(); } set { this["GizmoTransformProxy"] = value; } }
    }
    public class GizmoElementRectangle : GizmoElementLineBase
    {
        public GizmoElementRectangle(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public Vector UpDirection { get { return this[nameof(UpDirection)].As<Vector>(); } set { this["UpDirection"] = value; } }
        public Vector SideDirection { get { return this[nameof(SideDirection)].As<Vector>(); } set { this["SideDirection"] = value; } }
        public bool bDrawMesh { get { return this[nameof(bDrawMesh)].Flag; } set { this[nameof(bDrawMesh)].Flag = value; } }
        public bool bDrawLine { get { return this[nameof(bDrawLine)].Flag; } set { this[nameof(bDrawLine)].Flag = value; } }
        public bool bHitMesh { get { return this[nameof(bHitMesh)].Flag; } set { this[nameof(bHitMesh)].Flag = value; } }
        public bool bHitLine { get { return this[nameof(bHitLine)].Flag; } set { this[nameof(bHitLine)].Flag = value; } }
    }
    public class GizmoElementTorus : GizmoElementCircleBase
    {
        public GizmoElementTorus(nint addr) : base(addr) { }
        public double InnerRadius { get { return this[nameof(InnerRadius)].GetValue<double>(); } set { this[nameof(InnerRadius)].SetValue<double>(value); } }
        public int NumInnerSlices { get { return this[nameof(NumInnerSlices)].GetValue<int>(); } set { this[nameof(NumInnerSlices)].SetValue<int>(value); } }
        public bool bEndCaps { get { return this[nameof(bEndCaps)].Flag; } set { this[nameof(bEndCaps)].Flag = value; } }
    }
    public class GizmoTransformSource : Interface
    {
        public GizmoTransformSource(nint addr) : base(addr) { }
        public void SetTransform(Transform NewTransform) { Invoke(nameof(SetTransform), NewTransform); }
        public Transform GetTransform() { return Invoke<Transform>(nameof(GetTransform)); }
    }
    public class GizmoAxisSource : Interface
    {
        public GizmoAxisSource(nint addr) : base(addr) { }
        public bool HasTangentVectors() { return Invoke<bool>(nameof(HasTangentVectors)); }
        public void GetTangentVectors(Vector TangentXOut, Vector TangentYOut) { Invoke(nameof(GetTangentVectors), TangentXOut, TangentYOut); }
        public Vector GetOrigin() { return Invoke<Vector>(nameof(GetOrigin)); }
        public Vector GetDirection() { return Invoke<Vector>(nameof(GetDirection)); }
    }
    public class GizmoClickTarget : Interface
    {
        public GizmoClickTarget(nint addr) : base(addr) { }
        public void UpdateInteractingState(bool bInteracting) { Invoke(nameof(UpdateInteractingState), bInteracting); }
        public void UpdateHoverState(bool bHovering) { Invoke(nameof(UpdateHoverState), bHovering); }
    }
    public class GizmoClickMultiTarget : Interface
    {
        public GizmoClickMultiTarget(nint addr) : base(addr) { }
        public void UpdateInteractingState(bool bInteracting, uint InPartIdentifier) { Invoke(nameof(UpdateInteractingState), bInteracting, InPartIdentifier); }
        public void UpdateHoverState(bool bHovering, uint InPartIdentifier) { Invoke(nameof(UpdateHoverState), bHovering, InPartIdentifier); }
        public void UpdateHittableState(bool bHittable, uint InPartIdentifier) { Invoke(nameof(UpdateHittableState), bHittable, InPartIdentifier); }
    }
    public class GizmoRenderTarget : Interface
    {
        public GizmoRenderTarget(nint addr) : base(addr) { }
    }
    public class GizmoRenderMultiTarget : Interface
    {
        public GizmoRenderMultiTarget(nint addr) : base(addr) { }
        public void UpdateVisibilityState(bool bVisible, uint InPartIdentifier) { Invoke(nameof(UpdateVisibilityState), bVisible, InPartIdentifier); }
    }
    public class GizmoStateTarget : Interface
    {
        public GizmoStateTarget(nint addr) : base(addr) { }
        public void EndUpdate() { Invoke(nameof(EndUpdate)); }
        public void BeginUpdate() { Invoke(nameof(BeginUpdate)); }
    }
    public class GizmoFloatParameterSource : Interface
    {
        public GizmoFloatParameterSource(nint addr) : base(addr) { }
        public void SetParameter(float NewValue) { Invoke(nameof(SetParameter), NewValue); }
        public float GetParameter() { return Invoke<float>(nameof(GetParameter)); }
        public void EndModify() { Invoke(nameof(EndModify)); }
        public void BeginModify() { Invoke(nameof(BeginModify)); }
    }
    public class GizmoVec2ParameterSource : Interface
    {
        public GizmoVec2ParameterSource(nint addr) : base(addr) { }
        public void SetParameter(Vector2D NewValue) { Invoke(nameof(SetParameter), NewValue); }
        public Vector2D GetParameter() { return Invoke<Vector2D>(nameof(GetParameter)); }
        public void EndModify() { Invoke(nameof(EndModify)); }
        public void BeginModify() { Invoke(nameof(BeginModify)); }
    }
    public class GizmoLineHandleComponent : GizmoBaseComponent
    {
        public GizmoLineHandleComponent(nint addr) : base(addr) { }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float HandleSize { get { return this[nameof(HandleSize)].GetValue<float>(); } set { this[nameof(HandleSize)].SetValue<float>(value); } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
        public bool bImageScale { get { return this[nameof(bImageScale)].Flag; } set { this[nameof(bImageScale)].Flag = value; } }
    }
    public class GizmoRectangleComponent : GizmoBaseComponent
    {
        public GizmoRectangleComponent(nint addr) : base(addr) { }
        public Vector DirectionX { get { return this[nameof(DirectionX)].As<Vector>(); } set { this["DirectionX"] = value; } }
        public Vector DirectionY { get { return this[nameof(DirectionY)].As<Vector>(); } set { this["DirectionY"] = value; } }
        public bool bOrientYAccordingToCamera { get { return this[nameof(bOrientYAccordingToCamera)].Flag; } set { this[nameof(bOrientYAccordingToCamera)].Flag = value; } }
        public float OffsetX { get { return this[nameof(OffsetX)].GetValue<float>(); } set { this[nameof(OffsetX)].SetValue<float>(value); } }
        public float OffsetY { get { return this[nameof(OffsetY)].GetValue<float>(); } set { this[nameof(OffsetY)].SetValue<float>(value); } }
        public float LengthX { get { return this[nameof(LengthX)].GetValue<float>(); } set { this[nameof(LengthX)].SetValue<float>(value); } }
        public float LengthY { get { return this[nameof(LengthY)].GetValue<float>(); } set { this[nameof(LengthY)].SetValue<float>(value); } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
        public byte SegmentFlags { get { return this[nameof(SegmentFlags)].GetValue<byte>(); } set { this[nameof(SegmentFlags)].SetValue<byte>(value); } }
    }
    public class GizmoViewContext : Object
    {
        public GizmoViewContext(nint addr) : base(addr) { }
    }
    public class GizmoLambdaHitTarget : Object
    {
        public GizmoLambdaHitTarget(nint addr) : base(addr) { }
    }
    public class GizmoComponentHitTarget : Object
    {
        public GizmoComponentHitTarget(nint addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
    }
    public class IntervalGizmoActor : GizmoActor
    {
        public IntervalGizmoActor(nint addr) : base(addr) { }
        public GizmoLineHandleComponent UpIntervalComponent { get { return this[nameof(UpIntervalComponent)].As<GizmoLineHandleComponent>(); } set { this["UpIntervalComponent"] = value; } }
        public GizmoLineHandleComponent DownIntervalComponent { get { return this[nameof(DownIntervalComponent)].As<GizmoLineHandleComponent>(); } set { this["DownIntervalComponent"] = value; } }
        public GizmoLineHandleComponent ForwardIntervalComponent { get { return this[nameof(ForwardIntervalComponent)].As<GizmoLineHandleComponent>(); } set { this["ForwardIntervalComponent"] = value; } }
    }
    public class IntervalGizmoBuilder : InteractiveGizmoBuilder
    {
        public IntervalGizmoBuilder(nint addr) : base(addr) { }
    }
    public class IntervalGizmo : InteractiveGizmo
    {
        public IntervalGizmo(nint addr) : base(addr) { }
        public GizmoTransformChangeStateTarget StateTarget { get { return this[nameof(StateTarget)].As<GizmoTransformChangeStateTarget>(); } set { this["StateTarget"] = value; } }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public Array<PrimitiveComponent> ActiveComponents { get { return new Array<PrimitiveComponent>(this[nameof(ActiveComponents)].Address); } }
        public Array<InteractiveGizmo> ActiveGizmos { get { return new Array<InteractiveGizmo>(this[nameof(ActiveGizmos)].Address); } }
        public GizmoComponentAxisSource AxisYSource { get { return this[nameof(AxisYSource)].As<GizmoComponentAxisSource>(); } set { this["AxisYSource"] = value; } }
        public GizmoComponentAxisSource AxisZSource { get { return this[nameof(AxisZSource)].As<GizmoComponentAxisSource>(); } set { this["AxisZSource"] = value; } }
    }
    public class GizmoAxisIntervalParameterSource : GizmoBaseFloatParameterSource
    {
        public GizmoAxisIntervalParameterSource(nint addr) : base(addr) { }
        //public Object FloatParameterSource { get { return this[nameof(FloatParameterSource)]; } set { this[nameof(FloatParameterSource)] = value; } }
        public float MinParameter { get { return this[nameof(MinParameter)].GetValue<float>(); } set { this[nameof(MinParameter)].SetValue<float>(value); } }
        public float MaxParameter { get { return this[nameof(MaxParameter)].GetValue<float>(); } set { this[nameof(MaxParameter)].SetValue<float>(value); } }
    }
    public class GizmoLocalFloatParameterSource : GizmoBaseFloatParameterSource
    {
        public GizmoLocalFloatParameterSource(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public GizmoFloatParameterChange LastChange { get { return this[nameof(LastChange)].As<GizmoFloatParameterChange>(); } set { this["LastChange"] = value; } }
    }
    public class PlanePositionGizmoBuilder : InteractiveGizmoBuilder
    {
        public PlanePositionGizmoBuilder(nint addr) : base(addr) { }
    }
    public class PlanePositionGizmo : InteractiveGizmo
    {
        public PlanePositionGizmo(nint addr) : base(addr) { }
        public Object AxisSource { get { return this[nameof(AxisSource)]; } set { this[nameof(AxisSource)] = value; } }
        public Object ParameterSource { get { return this[nameof(ParameterSource)]; } set { this[nameof(ParameterSource)] = value; } }
        public Object HitTarget { get { return this[nameof(HitTarget)]; } set { this[nameof(HitTarget)] = value; } }
        public Object StateTarget { get { return this[nameof(StateTarget)]; } set { this[nameof(StateTarget)] = value; } }
        public ClickDragInputBehavior MouseBehavior { get { return this[nameof(MouseBehavior)].As<ClickDragInputBehavior>(); } set { this["MouseBehavior"] = value; } }
        public bool bEnableSignedAxis { get { return this[nameof(bEnableSignedAxis)].Flag; } set { this[nameof(bEnableSignedAxis)].Flag = value; } }
        public bool bFlipX { get { return this[nameof(bFlipX)].Flag; } set { this[nameof(bFlipX)].Flag = value; } }
        public bool bFlipY { get { return this[nameof(bFlipY)].Flag; } set { this[nameof(bFlipY)].Flag = value; } }
        public bool bInInteraction { get { return this[nameof(bInInteraction)].Flag; } set { this[nameof(bInInteraction)].Flag = value; } }
        public Vector InteractionOrigin { get { return this[nameof(InteractionOrigin)].As<Vector>(); } set { this["InteractionOrigin"] = value; } }
        public Vector InteractionNormal { get { return this[nameof(InteractionNormal)].As<Vector>(); } set { this["InteractionNormal"] = value; } }
        public Vector InteractionAxisX { get { return this[nameof(InteractionAxisX)].As<Vector>(); } set { this["InteractionAxisX"] = value; } }
        public Vector InteractionAxisY { get { return this[nameof(InteractionAxisY)].As<Vector>(); } set { this["InteractionAxisY"] = value; } }
        public Vector InteractionStartPoint { get { return this[nameof(InteractionStartPoint)].As<Vector>(); } set { this["InteractionStartPoint"] = value; } }
        public Vector InteractionCurPoint { get { return this[nameof(InteractionCurPoint)].As<Vector>(); } set { this["InteractionCurPoint"] = value; } }
        public Vector2D InteractionStartParameter { get { return this[nameof(InteractionStartParameter)].As<Vector2D>(); } set { this["InteractionStartParameter"] = value; } }
        public Vector2D InteractionCurParameter { get { return this[nameof(InteractionCurParameter)].As<Vector2D>(); } set { this["InteractionCurParameter"] = value; } }
        public Vector2D ParameterSigns { get { return this[nameof(ParameterSigns)].As<Vector2D>(); } set { this["ParameterSigns"] = value; } }
    }
    public class RepositionableTransformGizmoBuilder : CombinedTransformGizmoBuilder
    {
        public RepositionableTransformGizmoBuilder(nint addr) : base(addr) { }
    }
    public class RepositionableTransformGizmo : CombinedTransformGizmo
    {
        public RepositionableTransformGizmo(nint addr) : base(addr) { }
        public GizmoTransformChangeStateTarget RepositionStateTarget { get { return this[nameof(RepositionStateTarget)].As<GizmoTransformChangeStateTarget>(); } set { this["RepositionStateTarget"] = value; } }
    }
    public class ScalableSphereGizmoBuilder : InteractiveGizmoBuilder
    {
        public ScalableSphereGizmoBuilder(nint addr) : base(addr) { }
    }
    public class ScalableSphereGizmo : InteractiveGizmo
    {
        public ScalableSphereGizmo(nint addr) : base(addr) { }
        public float HitErrorThreshold { get { return this[nameof(HitErrorThreshold)].GetValue<float>(); } set { this[nameof(HitErrorThreshold)].SetValue<float>(value); } }
        public Object TransactionDescription { get { return this[nameof(TransactionDescription)]; } set { this[nameof(TransactionDescription)] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public bool bIsHovering { get { return this[nameof(bIsHovering)].Flag; } set { this[nameof(bIsHovering)].Flag = value; } }
        public bool bIsDragging { get { return this[nameof(bIsDragging)].Flag; } set { this[nameof(bIsDragging)].Flag = value; } }
        public TransformProxy ActiveTarget { get { return this[nameof(ActiveTarget)].As<TransformProxy>(); } set { this["ActiveTarget"] = value; } }
        public Vector ActiveAxis { get { return this[nameof(ActiveAxis)].As<Vector>(); } set { this["ActiveAxis"] = value; } }
        public Vector DragStartWorldPosition { get { return this[nameof(DragStartWorldPosition)].As<Vector>(); } set { this["DragStartWorldPosition"] = value; } }
        public Vector DragCurrentPositionProjected { get { return this[nameof(DragCurrentPositionProjected)].As<Vector>(); } set { this["DragCurrentPositionProjected"] = value; } }
        public float InteractionStartParameter { get { return this[nameof(InteractionStartParameter)].GetValue<float>(); } set { this[nameof(InteractionStartParameter)].SetValue<float>(value); } }
    }
    public class ScalableSphereGizmoInputBehavior : AnyButtonInputBehavior
    {
        public ScalableSphereGizmoInputBehavior(nint addr) : base(addr) { }
    }
    public class GizmoNilStateTarget : Object
    {
        public GizmoNilStateTarget(nint addr) : base(addr) { }
    }
    public class GizmoLambdaStateTarget : Object
    {
        public GizmoLambdaStateTarget(nint addr) : base(addr) { }
    }
    public class GizmoObjectModifyStateTarget : Object
    {
        public GizmoObjectModifyStateTarget(nint addr) : base(addr) { }
        public Object TransactionManager { get { return this[nameof(TransactionManager)]; } set { this[nameof(TransactionManager)] = value; } }
    }
    public class GizmoTransformChangeStateTarget : Object
    {
        public GizmoTransformChangeStateTarget(nint addr) : base(addr) { }
        public Object TransactionManager { get { return this[nameof(TransactionManager)]; } set { this[nameof(TransactionManager)] = value; } }
    }
    public class CombinedTransformGizmoContextObject : Object
    {
        public CombinedTransformGizmoContextObject(nint addr) : base(addr) { }
    }
    public class TransformProxy : Object
    {
        public TransformProxy(nint addr) : base(addr) { }
        public bool bRotatePerObject { get { return this[nameof(bRotatePerObject)].Flag; } set { this[nameof(bRotatePerObject)].Flag = value; } }
        public bool bSetPivotMode { get { return this[nameof(bSetPivotMode)].Flag; } set { this[nameof(bSetPivotMode)].Flag = value; } }
        public Transform SharedTransform { get { return this[nameof(SharedTransform)].As<Transform>(); } set { this["SharedTransform"] = value; } }
        public Transform InitialSharedTransform { get { return this[nameof(InitialSharedTransform)].As<Transform>(); } set { this["InitialSharedTransform"] = value; } }
    }
    public class GizmoBaseTransformSource : Object
    {
        public GizmoBaseTransformSource(nint addr) : base(addr) { }
    }
    public class GizmoComponentWorldTransformSource : GizmoBaseTransformSource
    {
        public GizmoComponentWorldTransformSource(nint addr) : base(addr) { }
        public SceneComponent Component { get { return this[nameof(Component)].As<SceneComponent>(); } set { this["Component"] = value; } }
        public bool bModifyComponentOnTransform { get { return this[nameof(bModifyComponentOnTransform)].Flag; } set { this[nameof(bModifyComponentOnTransform)].Flag = value; } }
    }
    public class GizmoScaledTransformSource : GizmoBaseTransformSource
    {
        public GizmoScaledTransformSource(nint addr) : base(addr) { }
        public Object ChildTransformSource { get { return this[nameof(ChildTransformSource)]; } set { this[nameof(ChildTransformSource)] = value; } }
    }
    public class GizmoTransformProxyTransformSource : GizmoBaseTransformSource
    {
        public GizmoTransformProxyTransformSource(nint addr) : base(addr) { }
        public TransformProxy Proxy { get { return this[nameof(Proxy)].As<TransformProxy>(); } set { this["Proxy"] = value; } }
    }
    public class GizmoScaledAndUnscaledTransformSources : GizmoBaseTransformSource
    {
        public GizmoScaledAndUnscaledTransformSources(nint addr) : base(addr) { }
        public Object ScaledTransformSource { get { return this[nameof(ScaledTransformSource)]; } set { this[nameof(ScaledTransformSource)] = value; } }
        public Object UnscaledTransformSource { get { return this[nameof(UnscaledTransformSource)]; } set { this[nameof(UnscaledTransformSource)] = value; } }
    }
    public class BrushBaseProperties : InteractiveToolPropertySet
    {
        public BrushBaseProperties(nint addr) : base(addr) { }
        public float BrushSize { get { return this[nameof(BrushSize)].GetValue<float>(); } set { this[nameof(BrushSize)].SetValue<float>(value); } }
        public bool bSpecifyRadius { get { return this[nameof(bSpecifyRadius)].Flag; } set { this[nameof(bSpecifyRadius)].Flag = value; } }
        public float BrushRadius { get { return this[nameof(BrushRadius)].GetValue<float>(); } set { this[nameof(BrushRadius)].SetValue<float>(value); } }
        public float BrushStrength { get { return this[nameof(BrushStrength)].GetValue<float>(); } set { this[nameof(BrushStrength)].SetValue<float>(value); } }
        public float BrushFalloffAmount { get { return this[nameof(BrushFalloffAmount)].GetValue<float>(); } set { this[nameof(BrushFalloffAmount)].SetValue<float>(value); } }
        public bool bShowStrength { get { return this[nameof(bShowStrength)].Flag; } set { this[nameof(bShowStrength)].Flag = value; } }
        public bool bShowFalloff { get { return this[nameof(bShowFalloff)].Flag; } set { this[nameof(bShowFalloff)].Flag = value; } }
    }
    public class ClickDragToolBuilder : InteractiveToolBuilder
    {
        public ClickDragToolBuilder(nint addr) : base(addr) { }
    }
    public class ClickDragTool : InteractiveTool
    {
        public ClickDragTool(nint addr) : base(addr) { }
    }
    public class SingleClickToolBuilder : InteractiveToolBuilder
    {
        public SingleClickToolBuilder(nint addr) : base(addr) { }
    }
    public class ContextObjectStore : Object
    {
        public ContextObjectStore(nint addr) : base(addr) { }
        public Array<Object> ContextObjects { get { return new Array<Object>(this[nameof(ContextObjects)].Address); } }
    }
    public class InputBehaviorSet : Object
    {
        public InputBehaviorSet(nint addr) : base(addr) { }
        public Array<BehaviorInfo> Behaviors { get { return new Array<BehaviorInfo>(this[nameof(Behaviors)].Address); } }
    }
    public class InputBehaviorSource : Interface
    {
        public InputBehaviorSource(nint addr) : base(addr) { }
    }
    public class LocalInputBehaviorSource : Object
    {
        public LocalInputBehaviorSource(nint addr) : base(addr) { }
    }
    public class InputRouter : Object
    {
        public InputRouter(nint addr) : base(addr) { }
        public bool bAutoInvalidateOnHover { get { return this[nameof(bAutoInvalidateOnHover)].Flag; } set { this[nameof(bAutoInvalidateOnHover)].Flag = value; } }
        public bool bAutoInvalidateOnCapture { get { return this[nameof(bAutoInvalidateOnCapture)].Flag; } set { this[nameof(bAutoInvalidateOnCapture)].Flag = value; } }
        public InputBehaviorSet ActiveInputBehaviors { get { return this[nameof(ActiveInputBehaviors)].As<InputBehaviorSet>(); } set { this["ActiveInputBehaviors"] = value; } }
    }
    public class InteractiveGizmoManager : Object
    {
        public InteractiveGizmoManager(nint addr) : base(addr) { }
        public Array<ActiveGizmo> ActiveGizmos { get { return new Array<ActiveGizmo>(this[nameof(ActiveGizmos)].Address); } }
        public Object GizmoBuilders { get { return this[nameof(GizmoBuilders)]; } set { this[nameof(GizmoBuilders)] = value; } }
    }
    public class InteractiveToolManager : Object
    {
        public InteractiveToolManager(nint addr) : base(addr) { }
        public InteractiveTool ActiveLeftTool { get { return this[nameof(ActiveLeftTool)].As<InteractiveTool>(); } set { this["ActiveLeftTool"] = value; } }
        public InteractiveTool ActiveRightTool { get { return this[nameof(ActiveRightTool)].As<InteractiveTool>(); } set { this["ActiveRightTool"] = value; } }
        public Object ToolBuilders { get { return this[nameof(ToolBuilders)]; } set { this[nameof(ToolBuilders)] = value; } }
    }
    public class InteractiveToolsContext : Object
    {
        public InteractiveToolsContext(nint addr) : base(addr) { }
        public InputRouter InputRouter { get { return this[nameof(InputRouter)].As<InputRouter>(); } set { this["InputRouter"] = value; } }
        public ToolTargetManager TargetManager { get { return this[nameof(TargetManager)].As<ToolTargetManager>(); } set { this["TargetManager"] = value; } }
        public InteractiveToolManager ToolManager { get { return this[nameof(ToolManager)].As<InteractiveToolManager>(); } set { this["ToolManager"] = value; } }
        public InteractiveGizmoManager GizmoManager { get { return this[nameof(GizmoManager)].As<InteractiveGizmoManager>(); } set { this["GizmoManager"] = value; } }
        public ContextObjectStore ContextObjectStore { get { return this[nameof(ContextObjectStore)].As<ContextObjectStore>(); } set { this["ContextObjectStore"] = value; } }
        public Object ToolManagerClass { get { return this[nameof(ToolManagerClass)]; } set { this[nameof(ToolManagerClass)] = value; } }
    }
    public class SelectionSet : Object
    {
        public SelectionSet(nint addr) : base(addr) { }
    }
    public class MeshSelectionSet : SelectionSet
    {
        public MeshSelectionSet(nint addr) : base(addr) { }
        public Array<int> Vertices { get { return new Array<int>(this[nameof(Vertices)].Address); } }
        public Array<int> Edges { get { return new Array<int>(this[nameof(Edges)].Address); } }
        public Array<int> Faces { get { return new Array<int>(this[nameof(Faces)].Address); } }
        public Array<int> Groups { get { return new Array<int>(this[nameof(Groups)].Address); } }
    }
    public class ToolTargetManager : Object
    {
        public ToolTargetManager(nint addr) : base(addr) { }
        public Array<ToolTargetFactory> Factories { get { return new Array<ToolTargetFactory>(this[nameof(Factories)].Address); } }
    }
    public class ToolTarget : Object
    {
        public ToolTarget(nint addr) : base(addr) { }
    }
    public class PrimitiveComponentToolTarget : ToolTarget
    {
        public PrimitiveComponentToolTarget(nint addr) : base(addr) { }
    }
    public class ToolTargetFactory : Object
    {
        public ToolTargetFactory(nint addr) : base(addr) { }
    }
    public class PrimitiveComponentToolTargetFactory : ToolTargetFactory
    {
        public PrimitiveComponentToolTargetFactory(nint addr) : base(addr) { }
    }
    public enum EGizmoElementState : int
    {
        None = 0,
        Visible = 2,
        Hittable = 4,
        VisibleAndHittable = 6,
        EGizmoElementState_MAX = 7,
    }
    public enum EGizmoElementInteractionState : int
    {
        None = 0,
        Hovering = 1,
        Interacting = 2,
        EGizmoElementInteractionState_MAX = 3,
    }
    public enum EGizmoElementViewDependentType : int
    {
        None = 0,
        Axis = 1,
        Plane = 2,
        EGizmoElementViewDependentType_MAX = 3,
    }
    public enum EGizmoElementViewAlignType : int
    {
        None = 0,
        PointOnly = 1,
        PointEye = 2,
        PointScreen = 3,
        Axial = 4,
        EGizmoElementViewAlignType_MAX = 5,
    }
    public enum EGizmoElementPartialType : int
    {
        None = 0,
        Partial = 1,
        PartialViewDependent = 2,
        EGizmoElementPartialType_MAX = 3,
    }
    public enum EStandardToolContextMaterials : int
    {
        VertexColorMaterial = 1,
        EStandardToolContextMaterials_MAX = 2,
    }
    public enum EToolContextCoordinateSystem : int
    {
        World = 0,
        Local = 1,
        EToolContextCoordinateSystem_MAX = 2,
    }
    public enum EToolMessageLevel : int
    {
        Internal = 0,
        UserMessage = 1,
        UserNotification = 2,
        UserWarning = 3,
        UserError = 4,
        EToolMessageLevel_MAX = 5,
    }
    public enum ESelectedObjectsModificationType : int
    {
        Replace = 0,
        Add = 1,
        Remove = 2,
        Clear = 3,
        ESelectedObjectsModificationType_MAX = 4,
    }
    public enum EViewInteractionState : int
    {
        None = 0,
        Hovered = 1,
        Focused = 2,
        EViewInteractionState_MAX = 3,
    }
    public enum EGizmoElementArrowHeadType : int
    {
        Cone = 0,
        Cube = 1,
        EGizmoElementArrowHeadType_MAX = 2,
    }
    public enum EInputCaptureSide : int
    {
        None = 0,
        Left = 1,
        Right = 2,
        Both = 3,
        Any = 99,
        EInputCaptureSide_MAX = 100,
    }
    public enum EInputCaptureRequestType : int
    {
        Begin = 1,
        Ignore = 2,
        EInputCaptureRequestType_MAX = 3,
    }
    public enum EInputCaptureState : int
    {
        Begin = 1,
        Continue = 2,
        End = 3,
        Ignore = 4,
        EInputCaptureState_MAX = 5,
    }
    public enum EInputDevices : int
    {
        None = 0,
        Keyboard = 1,
        Mouse = 2,
        Gamepad = 4,
        OculusTouch = 8,
        HTCViveWands = 16,
        AnySpatialDevice = 24,
        TabletFingers = 1024,
        EInputDevices_MAX = 1025,
    }
    public enum ETransformGizmoSubElements : int
    {
        None = 0,
        TranslateAxisX = 2,
        TranslateAxisY = 4,
        TranslateAxisZ = 8,
        TranslateAllAxes = 14,
        TranslatePlaneXY = 16,
        TranslatePlaneXZ = 32,
        TranslatePlaneYZ = 64,
        TranslateAllPlanes = 112,
        RotateAxisX = 128,
        RotateAxisY = 256,
        RotateAxisZ = 512,
        RotateAllAxes = 896,
        ScaleAxisX = 1024,
        ScaleAxisY = 2048,
        ScaleAxisZ = 4096,
        ScaleAllAxes = 7168,
        ScalePlaneYZ = 8192,
        ScalePlaneXZ = 16384,
        ScalePlaneXY = 32768,
        ScaleAllPlanes = 57344,
        ScaleUniform = 65536,
        StandardTranslateRotate = 1022,
        TranslateRotateUniformScale = 66558,
        FullTranslateRotateScale = 131070,
        ETransformGizmoSubElements_MAX = 131071,
    }
    public enum EToolSide : int
    {
        Left = 1,
        Mouse = 1,
        Right = 2,
        EToolSide_MAX = 3,
    }
    public enum EToolChangeTrackingMode : int
    {
        NoChangeTracking = 1,
        UndoToExit = 2,
        FullUndoRedo = 3,
        EToolChangeTrackingMode_MAX = 4,
    }
    public enum ESceneSnapQueryType : int
    {
        Position = 1,
        Rotation = 2,
        ESceneSnapQueryType_MAX = 3,
    }
    public enum ESceneSnapQueryTargetType : int
    {
        None = 0,
        MeshVertex = 1,
        MeshEdge = 2,
        Grid = 4,
        All = 7,
        ESceneSnapQueryTargetType_MAX = 8,
    }
    public class GizmoElementColorAttribute : Object
    {
        public GizmoElementColorAttribute(nint addr) : base(addr) { }
        public LinearColor Value { get { return this[nameof(Value)].As<LinearColor>(); } set { this["Value"] = value; } }
        public bool bHasValue { get { return this[nameof(bHasValue)].Flag; } set { this[nameof(bHasValue)].Flag = value; } }
        public bool bOverridesChildState { get { return this[nameof(bOverridesChildState)].Flag; } set { this[nameof(bOverridesChildState)].Flag = value; } }
    }
    public class GizmoElementMaterialAttribute : Object
    {
        public GizmoElementMaterialAttribute(nint addr) : base(addr) { }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
        public bool bOverridesChildState { get { return this[nameof(bOverridesChildState)].Flag; } set { this[nameof(bOverridesChildState)].Flag = value; } }
    }
    public class GizmoElementMeshRenderStateAttributes : Object
    {
        public GizmoElementMeshRenderStateAttributes(nint addr) : base(addr) { }
        public GizmoElementMaterialAttribute Material { get { return this[nameof(Material)].As<GizmoElementMaterialAttribute>(); } set { this["Material"] = value; } }
        public GizmoElementMaterialAttribute HoverMaterial { get { return this[nameof(HoverMaterial)].As<GizmoElementMaterialAttribute>(); } set { this["HoverMaterial"] = value; } }
        public GizmoElementMaterialAttribute InteractMaterial { get { return this[nameof(InteractMaterial)].As<GizmoElementMaterialAttribute>(); } set { this["InteractMaterial"] = value; } }
        public GizmoElementColorAttribute VertexColor { get { return this[nameof(VertexColor)].As<GizmoElementColorAttribute>(); } set { this["VertexColor"] = value; } }
        public GizmoElementColorAttribute HoverVertexColor { get { return this[nameof(HoverVertexColor)].As<GizmoElementColorAttribute>(); } set { this["HoverVertexColor"] = value; } }
        public GizmoElementColorAttribute InteractVertexColor { get { return this[nameof(InteractVertexColor)].As<GizmoElementColorAttribute>(); } set { this["InteractVertexColor"] = value; } }
    }
    public class GizmoElementLineRenderStateAttributes : Object
    {
        public GizmoElementLineRenderStateAttributes(nint addr) : base(addr) { }
        public GizmoElementColorAttribute LineColor { get { return this[nameof(LineColor)].As<GizmoElementColorAttribute>(); } set { this["LineColor"] = value; } }
        public GizmoElementColorAttribute HoverLineColor { get { return this[nameof(HoverLineColor)].As<GizmoElementColorAttribute>(); } set { this["HoverLineColor"] = value; } }
        public GizmoElementColorAttribute InteractLineColor { get { return this[nameof(InteractLineColor)].As<GizmoElementColorAttribute>(); } set { this["InteractLineColor"] = value; } }
    }
    public class GizmoVec2ParameterChange : Object
    {
        public GizmoVec2ParameterChange(nint addr) : base(addr) { }
        public Vector2D InitialValue { get { return this[nameof(InitialValue)].As<Vector2D>(); } set { this["InitialValue"] = value; } }
        public Vector2D CurrentValue { get { return this[nameof(CurrentValue)].As<Vector2D>(); } set { this["CurrentValue"] = value; } }
    }
    public class GizmoFloatParameterChange : Object
    {
        public GizmoFloatParameterChange(nint addr) : base(addr) { }
        public float InitialValue { get { return this[nameof(InitialValue)].GetValue<float>(); } set { this[nameof(InitialValue)].SetValue<float>(value); } }
        public float CurrentValue { get { return this[nameof(CurrentValue)].GetValue<float>(); } set { this[nameof(CurrentValue)].SetValue<float>(value); } }
    }
    public class BrushStampData : Object
    {
        public BrushStampData(nint addr) : base(addr) { }
    }
    public class BehaviorInfo : Object
    {
        public BehaviorInfo(nint addr) : base(addr) { }
        public InputBehavior Behavior { get { return this[nameof(Behavior)].As<InputBehavior>(); } set { this["Behavior"] = value; } }
    }
    public class InputRayHit : Object
    {
        public InputRayHit(nint addr) : base(addr) { }
    }
    public class ActiveGizmo : Object
    {
        public ActiveGizmo(nint addr) : base(addr) { }
        public InteractiveGizmo Gizmo { get { return this[nameof(Gizmo)].As<InteractiveGizmo>(); } set { this["Gizmo"] = value; } }
    }
}
