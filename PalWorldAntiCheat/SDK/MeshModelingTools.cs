using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.InteractiveToolsFrameworkSDK;
using SDK.Script.ModelingComponentsSDK;
using SDK.Script.ModelingOperatorsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MeshModelingToolsSDK
{
    public class RevolveProperties : InteractiveToolPropertySet
    {
        public RevolveProperties(nint addr) : base(addr) { }
        public double RevolveDegreesClamped { get { return this[nameof(RevolveDegreesClamped)].GetValue<double>(); } set { this[nameof(RevolveDegreesClamped)].SetValue<double>(value); } }
        public double RevolveDegrees { get { return this[nameof(RevolveDegrees)].GetValue<double>(); } set { this[nameof(RevolveDegrees)].SetValue<double>(value); } }
        public double RevolveDegreesOffset { get { return this[nameof(RevolveDegreesOffset)].GetValue<double>(); } set { this[nameof(RevolveDegreesOffset)].SetValue<double>(value); } }
        public double StepsMaxDegrees { get { return this[nameof(StepsMaxDegrees)].GetValue<double>(); } set { this[nameof(StepsMaxDegrees)].SetValue<double>(value); } }
        public bool bExplicitSteps { get { return this[nameof(bExplicitSteps)].Flag; } set { this[nameof(bExplicitSteps)].Flag = value; } }
        public int NumExplicitSteps { get { return this[nameof(NumExplicitSteps)].GetValue<int>(); } set { this[nameof(NumExplicitSteps)].SetValue<int>(value); } }
        public double HeightOffsetPerDegree { get { return this[nameof(HeightOffsetPerDegree)].GetValue<double>(); } set { this[nameof(HeightOffsetPerDegree)].SetValue<double>(value); } }
        public bool bReverseRevolutionDirection { get { return this[nameof(bReverseRevolutionDirection)].Flag; } set { this[nameof(bReverseRevolutionDirection)].Flag = value; } }
        public bool bFlipMesh { get { return this[nameof(bFlipMesh)].Flag; } set { this[nameof(bFlipMesh)].Flag = value; } }
        public bool bSharpNormals { get { return this[nameof(bSharpNormals)].Flag; } set { this[nameof(bSharpNormals)].Flag = value; } }
        public double SharpNormalsDegreeThreshold { get { return this[nameof(SharpNormalsDegreeThreshold)].GetValue<double>(); } set { this[nameof(SharpNormalsDegreeThreshold)].SetValue<double>(value); } }
        public bool bPathAtMidpointOfStep { get { return this[nameof(bPathAtMidpointOfStep)].Flag; } set { this[nameof(bPathAtMidpointOfStep)].Flag = value; } }
        public ERevolvePropertiesPolygroupMode PolygroupMode { get { return (ERevolvePropertiesPolygroupMode)this[nameof(PolygroupMode)].GetValue<int>(); } set { this[nameof(PolygroupMode)].SetValue<int>((int)value); } }
        public ERevolvePropertiesQuadSplit QuadSplitMode { get { return (ERevolvePropertiesQuadSplit)this[nameof(QuadSplitMode)].GetValue<int>(); } set { this[nameof(QuadSplitMode)].SetValue<int>((int)value); } }
    }
    public class DeleteGeometrySelectionCommand : GeometrySelectionEditCommand
    {
        public DeleteGeometrySelectionCommand(nint addr) : base(addr) { }
    }
    public class PolyEditActivityContext : Object
    {
        public PolyEditActivityContext(nint addr) : base(addr) { }
        public PolyEditCommonProperties CommonProperties { get { return this[nameof(CommonProperties)].As<PolyEditCommonProperties>(); } set { this["CommonProperties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public PolygonSelectionMechanic SelectionMechanic { get { return this[nameof(SelectionMechanic)].As<PolygonSelectionMechanic>(); } set { this["SelectionMechanic"] = value; } }
    }
    public class AddPrimitiveToolBuilder : InteractiveToolBuilder
    {
        public AddPrimitiveToolBuilder(nint addr) : base(addr) { }
    }
    public class ProceduralShapeToolProperties : InteractiveToolPropertySet
    {
        public ProceduralShapeToolProperties(nint addr) : base(addr) { }
        public EMakeMeshPolygroupMode PolygroupMode { get { return (EMakeMeshPolygroupMode)this[nameof(PolygroupMode)].GetValue<int>(); } set { this[nameof(PolygroupMode)].SetValue<int>((int)value); } }
        public EMakeMeshPlacementType TargetSurface { get { return (EMakeMeshPlacementType)this[nameof(TargetSurface)].GetValue<int>(); } set { this[nameof(TargetSurface)].SetValue<int>((int)value); } }
        public EMakeMeshPivotLocation PivotLocation { get { return (EMakeMeshPivotLocation)this[nameof(PivotLocation)].GetValue<int>(); } set { this[nameof(PivotLocation)].SetValue<int>((int)value); } }
        public float Rotation { get { return this[nameof(Rotation)].GetValue<float>(); } set { this[nameof(Rotation)].SetValue<float>(value); } }
        public bool bAlignToNormal { get { return this[nameof(bAlignToNormal)].Flag; } set { this[nameof(bAlignToNormal)].Flag = value; } }
        public bool bShowGizmo { get { return this[nameof(bShowGizmo)].Flag; } set { this[nameof(bShowGizmo)].Flag = value; } }
        public bool bShowGizmoOptions { get { return this[nameof(bShowGizmoOptions)].Flag; } set { this[nameof(bShowGizmoOptions)].Flag = value; } }
    }
    public class ProceduralBoxToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralBoxToolProperties(nint addr) : base(addr) { }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public int WidthSubdivisions { get { return this[nameof(WidthSubdivisions)].GetValue<int>(); } set { this[nameof(WidthSubdivisions)].SetValue<int>(value); } }
        public int DepthSubdivisions { get { return this[nameof(DepthSubdivisions)].GetValue<int>(); } set { this[nameof(DepthSubdivisions)].SetValue<int>(value); } }
        public int HeightSubdivisions { get { return this[nameof(HeightSubdivisions)].GetValue<int>(); } set { this[nameof(HeightSubdivisions)].SetValue<int>(value); } }
    }
    public class ProceduralRectangleToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralRectangleToolProperties(nint addr) : base(addr) { }
        public EProceduralRectType RectangleType { get { return (EProceduralRectType)this[nameof(RectangleType)].GetValue<int>(); } set { this[nameof(RectangleType)].SetValue<int>((int)value); } }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public int WidthSubdivisions { get { return this[nameof(WidthSubdivisions)].GetValue<int>(); } set { this[nameof(WidthSubdivisions)].SetValue<int>(value); } }
        public int DepthSubdivisions { get { return this[nameof(DepthSubdivisions)].GetValue<int>(); } set { this[nameof(DepthSubdivisions)].SetValue<int>(value); } }
        public float CornerRadius { get { return this[nameof(CornerRadius)].GetValue<float>(); } set { this[nameof(CornerRadius)].SetValue<float>(value); } }
        public int CornerSlices { get { return this[nameof(CornerSlices)].GetValue<int>(); } set { this[nameof(CornerSlices)].SetValue<int>(value); } }
    }
    public class ProceduralDiscToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralDiscToolProperties(nint addr) : base(addr) { }
        public EProceduralDiscType DiscType { get { return (EProceduralDiscType)this[nameof(DiscType)].GetValue<int>(); } set { this[nameof(DiscType)].SetValue<int>((int)value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public int RadialSubdivisions { get { return this[nameof(RadialSubdivisions)].GetValue<int>(); } set { this[nameof(RadialSubdivisions)].SetValue<int>(value); } }
        public float HoleRadius { get { return this[nameof(HoleRadius)].GetValue<float>(); } set { this[nameof(HoleRadius)].SetValue<float>(value); } }
    }
    public class ProceduralTorusToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralTorusToolProperties(nint addr) : base(addr) { }
        public float MajorRadius { get { return this[nameof(MajorRadius)].GetValue<float>(); } set { this[nameof(MajorRadius)].SetValue<float>(value); } }
        public float MinorRadius { get { return this[nameof(MinorRadius)].GetValue<float>(); } set { this[nameof(MinorRadius)].SetValue<float>(value); } }
        public int MajorSlices { get { return this[nameof(MajorSlices)].GetValue<int>(); } set { this[nameof(MajorSlices)].SetValue<int>(value); } }
        public int MinorSlices { get { return this[nameof(MinorSlices)].GetValue<int>(); } set { this[nameof(MinorSlices)].SetValue<int>(value); } }
    }
    public class ProceduralCylinderToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralCylinderToolProperties(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public int HeightSubdivisions { get { return this[nameof(HeightSubdivisions)].GetValue<int>(); } set { this[nameof(HeightSubdivisions)].SetValue<int>(value); } }
    }
    public class ProceduralConeToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralConeToolProperties(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public int HeightSubdivisions { get { return this[nameof(HeightSubdivisions)].GetValue<int>(); } set { this[nameof(HeightSubdivisions)].SetValue<int>(value); } }
    }
    public class ProceduralArrowToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralArrowToolProperties(nint addr) : base(addr) { }
        public float ShaftRadius { get { return this[nameof(ShaftRadius)].GetValue<float>(); } set { this[nameof(ShaftRadius)].SetValue<float>(value); } }
        public float ShaftHeight { get { return this[nameof(ShaftHeight)].GetValue<float>(); } set { this[nameof(ShaftHeight)].SetValue<float>(value); } }
        public float HeadRadius { get { return this[nameof(HeadRadius)].GetValue<float>(); } set { this[nameof(HeadRadius)].SetValue<float>(value); } }
        public float HeadHeight { get { return this[nameof(HeadHeight)].GetValue<float>(); } set { this[nameof(HeadHeight)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public int HeightSubdivisions { get { return this[nameof(HeightSubdivisions)].GetValue<int>(); } set { this[nameof(HeightSubdivisions)].SetValue<int>(value); } }
    }
    public class ProceduralSphereToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralSphereToolProperties(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public EProceduralSphereType SubdivisionType { get { return (EProceduralSphereType)this[nameof(SubdivisionType)].GetValue<int>(); } set { this[nameof(SubdivisionType)].SetValue<int>((int)value); } }
        public int Subdivisions { get { return this[nameof(Subdivisions)].GetValue<int>(); } set { this[nameof(Subdivisions)].SetValue<int>(value); } }
        public int HorizontalSlices { get { return this[nameof(HorizontalSlices)].GetValue<int>(); } set { this[nameof(HorizontalSlices)].SetValue<int>(value); } }
        public int VerticalSlices { get { return this[nameof(VerticalSlices)].GetValue<int>(); } set { this[nameof(VerticalSlices)].SetValue<int>(value); } }
    }
    public class ProceduralStairsToolProperties : ProceduralShapeToolProperties
    {
        public ProceduralStairsToolProperties(nint addr) : base(addr) { }
        public EProceduralStairsType StairsType { get { return (EProceduralStairsType)this[nameof(StairsType)].GetValue<int>(); } set { this[nameof(StairsType)].SetValue<int>((int)value); } }
        public int NumSteps { get { return this[nameof(NumSteps)].GetValue<int>(); } set { this[nameof(NumSteps)].SetValue<int>(value); } }
        public float StepWidth { get { return this[nameof(StepWidth)].GetValue<float>(); } set { this[nameof(StepWidth)].SetValue<float>(value); } }
        public float StepHeight { get { return this[nameof(StepHeight)].GetValue<float>(); } set { this[nameof(StepHeight)].SetValue<float>(value); } }
        public float StepDepth { get { return this[nameof(StepDepth)].GetValue<float>(); } set { this[nameof(StepDepth)].SetValue<float>(value); } }
        public float CurveAngle { get { return this[nameof(CurveAngle)].GetValue<float>(); } set { this[nameof(CurveAngle)].SetValue<float>(value); } }
        public float SpiralAngle { get { return this[nameof(SpiralAngle)].GetValue<float>(); } set { this[nameof(SpiralAngle)].SetValue<float>(value); } }
        public float InnerRadius { get { return this[nameof(InnerRadius)].GetValue<float>(); } set { this[nameof(InnerRadius)].SetValue<float>(value); } }
    }
    public class AddPrimitiveTool : SingleClickTool
    {
        public AddPrimitiveTool(nint addr) : base(addr) { }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public ProceduralShapeToolProperties ShapeSettings { get { return this[nameof(ShapeSettings)].As<ProceduralShapeToolProperties>(); } set { this["ShapeSettings"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public CombinedTransformGizmo Gizmo { get { return this[nameof(Gizmo)].As<CombinedTransformGizmo>(); } set { this["Gizmo"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
    }
    public class AddBoxPrimitiveTool : AddPrimitiveTool
    {
        public AddBoxPrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddCylinderPrimitiveTool : AddPrimitiveTool
    {
        public AddCylinderPrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddConePrimitiveTool : AddPrimitiveTool
    {
        public AddConePrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddRectanglePrimitiveTool : AddPrimitiveTool
    {
        public AddRectanglePrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddDiscPrimitiveTool : AddPrimitiveTool
    {
        public AddDiscPrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddTorusPrimitiveTool : AddPrimitiveTool
    {
        public AddTorusPrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddArrowPrimitiveTool : AddPrimitiveTool
    {
        public AddArrowPrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddSpherePrimitiveTool : AddPrimitiveTool
    {
        public AddSpherePrimitiveTool(nint addr) : base(addr) { }
    }
    public class AddStairsPrimitiveTool : AddPrimitiveTool
    {
        public AddStairsPrimitiveTool(nint addr) : base(addr) { }
    }
    public class CombineMeshesToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public CombineMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class CombineMeshesToolProperties : InteractiveToolPropertySet
    {
        public CombineMeshesToolProperties(nint addr) : base(addr) { }
        public bool bIsDuplicateMode { get { return this[nameof(bIsDuplicateMode)].Flag; } set { this[nameof(bIsDuplicateMode)].Flag = value; } }
        public EBaseCreateFromSelectedTargetType OutputWriteTo { get { return (EBaseCreateFromSelectedTargetType)this[nameof(OutputWriteTo)].GetValue<int>(); } set { this[nameof(OutputWriteTo)].SetValue<int>((int)value); } }
        public Object OutputNewName { get { return this[nameof(OutputNewName)]; } set { this[nameof(OutputNewName)] = value; } }
        public Object OutputExistingName { get { return this[nameof(OutputExistingName)]; } set { this[nameof(OutputExistingName)] = value; } }
    }
    public class CombineMeshesTool : MultiSelectionMeshEditingTool
    {
        public CombineMeshesTool(nint addr) : base(addr) { }
        public CombineMeshesToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<CombineMeshesToolProperties>(); } set { this["BasicProperties"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public OnAcceptHandleSourcesPropertiesBase HandleSourceProperties { get { return this[nameof(HandleSourceProperties)].As<OnAcceptHandleSourcesPropertiesBase>(); } set { this["HandleSourceProperties"] = value; } }
    }
    public class CSGMeshesToolProperties : InteractiveToolPropertySet
    {
        public CSGMeshesToolProperties(nint addr) : base(addr) { }
        public ECSGOperation Operation { get { return (ECSGOperation)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public bool bTryFixHoles { get { return this[nameof(bTryFixHoles)].Flag; } set { this[nameof(bTryFixHoles)].Flag = value; } }
        public bool bTryCollapseEdges { get { return this[nameof(bTryCollapseEdges)].Flag; } set { this[nameof(bTryCollapseEdges)].Flag = value; } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
        public bool bShowNewBoundaries { get { return this[nameof(bShowNewBoundaries)].Flag; } set { this[nameof(bShowNewBoundaries)].Flag = value; } }
        public bool bShowSubtractedMesh { get { return this[nameof(bShowSubtractedMesh)].Flag; } set { this[nameof(bShowSubtractedMesh)].Flag = value; } }
        public float SubtractedMeshOpacity { get { return this[nameof(SubtractedMeshOpacity)].GetValue<float>(); } set { this[nameof(SubtractedMeshOpacity)].SetValue<float>(value); } }
        public LinearColor SubtractedMeshColor { get { return this[nameof(SubtractedMeshColor)].As<LinearColor>(); } set { this["SubtractedMeshColor"] = value; } }
        public bool bUseFirstMeshMaterials { get { return this[nameof(bUseFirstMeshMaterials)].Flag; } set { this[nameof(bUseFirstMeshMaterials)].Flag = value; } }
    }
    public class TrimMeshesToolProperties : InteractiveToolPropertySet
    {
        public TrimMeshesToolProperties(nint addr) : base(addr) { }
        public ETrimOperation WhichMesh { get { return (ETrimOperation)this[nameof(WhichMesh)].GetValue<int>(); } set { this[nameof(WhichMesh)].SetValue<int>((int)value); } }
        public ETrimSide TrimSide { get { return (ETrimSide)this[nameof(TrimSide)].GetValue<int>(); } set { this[nameof(TrimSide)].SetValue<int>((int)value); } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
        public bool bShowTrimmingMesh { get { return this[nameof(bShowTrimmingMesh)].Flag; } set { this[nameof(bShowTrimmingMesh)].Flag = value; } }
        public float OpacityOfTrimmingMesh { get { return this[nameof(OpacityOfTrimmingMesh)].GetValue<float>(); } set { this[nameof(OpacityOfTrimmingMesh)].SetValue<float>(value); } }
        public LinearColor ColorOfTrimmingMesh { get { return this[nameof(ColorOfTrimmingMesh)].As<LinearColor>(); } set { this["ColorOfTrimmingMesh"] = value; } }
    }
    public class CSGMeshesTool : BaseCreateFromSelectedTool
    {
        public CSGMeshesTool(nint addr) : base(addr) { }
        public CSGMeshesToolProperties CSGProperties { get { return this[nameof(CSGProperties)].As<CSGMeshesToolProperties>(); } set { this["CSGProperties"] = value; } }
        public TrimMeshesToolProperties TrimProperties { get { return this[nameof(TrimProperties)].As<TrimMeshesToolProperties>(); } set { this["TrimProperties"] = value; } }
        public Array<PreviewMesh> OriginalMeshPreviews { get { return new Array<PreviewMesh>(this[nameof(OriginalMeshPreviews)].Address); } }
        public MaterialInstanceDynamic PreviewsGhostMaterial { get { return this[nameof(PreviewsGhostMaterial)].As<MaterialInstanceDynamic>(); } set { this["PreviewsGhostMaterial"] = value; } }
        public LineSetComponent DrawnLineSet { get { return this[nameof(DrawnLineSet)].As<LineSetComponent>(); } set { this["DrawnLineSet"] = value; } }
    }
    public class CSGMeshesToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public CSGMeshesToolBuilder(nint addr) : base(addr) { }
    }
    public class CutMeshWithMeshToolProperties : InteractiveToolPropertySet
    {
        public CutMeshWithMeshToolProperties(nint addr) : base(addr) { }
        public bool bTryFixHoles { get { return this[nameof(bTryFixHoles)].Flag; } set { this[nameof(bTryFixHoles)].Flag = value; } }
        public bool bTryCollapseEdges { get { return this[nameof(bTryCollapseEdges)].Flag; } set { this[nameof(bTryCollapseEdges)].Flag = value; } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
        public bool bShowNewBoundaries { get { return this[nameof(bShowNewBoundaries)].Flag; } set { this[nameof(bShowNewBoundaries)].Flag = value; } }
        public bool bUseFirstMeshMaterials { get { return this[nameof(bUseFirstMeshMaterials)].Flag; } set { this[nameof(bUseFirstMeshMaterials)].Flag = value; } }
    }
    public class CutMeshWithMeshTool : BaseCreateFromSelectedTool
    {
        public CutMeshWithMeshTool(nint addr) : base(addr) { }
        public CutMeshWithMeshToolProperties CutProperties { get { return this[nameof(CutProperties)].As<CutMeshWithMeshToolProperties>(); } set { this["CutProperties"] = value; } }
        public PreviewMesh IntersectPreviewMesh { get { return this[nameof(IntersectPreviewMesh)].As<PreviewMesh>(); } set { this["IntersectPreviewMesh"] = value; } }
        public LineSetComponent DrawnLineSet { get { return this[nameof(DrawnLineSet)].As<LineSetComponent>(); } set { this["DrawnLineSet"] = value; } }
    }
    public class CutMeshWithMeshToolBuilder : BaseCreateFromSelectedToolBuilder
    {
        public CutMeshWithMeshToolBuilder(nint addr) : base(addr) { }
    }
    public class DrawAndRevolveToolBuilder : InteractiveToolBuilder
    {
        public DrawAndRevolveToolBuilder(nint addr) : base(addr) { }
    }
    public class RevolveToolProperties : RevolveProperties
    {
        public RevolveToolProperties(nint addr) : base(addr) { }
        public ERevolvePropertiesCapFillMode CapFillMode { get { return (ERevolvePropertiesCapFillMode)this[nameof(CapFillMode)].GetValue<int>(); } set { this[nameof(CapFillMode)].SetValue<int>((int)value); } }
        public bool bClosePathToAxis { get { return this[nameof(bClosePathToAxis)].Flag; } set { this[nameof(bClosePathToAxis)].Flag = value; } }
        public Vector DrawPlaneOrigin { get { return this[nameof(DrawPlaneOrigin)].As<Vector>(); } set { this["DrawPlaneOrigin"] = value; } }
        public Rotator DrawPlaneOrientation { get { return this[nameof(DrawPlaneOrientation)].As<Rotator>(); } set { this["DrawPlaneOrientation"] = value; } }
        public bool bEnableSnapping { get { return this[nameof(bEnableSnapping)].Flag; } set { this[nameof(bEnableSnapping)].Flag = value; } }
        public bool bAllowedToEditDrawPlane { get { return this[nameof(bAllowedToEditDrawPlane)].Flag; } set { this[nameof(bAllowedToEditDrawPlane)].Flag = value; } }
    }
    public class RevolveOperatorFactory : Object
    {
        public RevolveOperatorFactory(nint addr) : base(addr) { }
        public DrawAndRevolveTool RevolveTool { get { return this[nameof(RevolveTool)].As<DrawAndRevolveTool>(); } set { this["RevolveTool"] = value; } }
    }
    public class DrawAndRevolveTool : InteractiveTool
    {
        public DrawAndRevolveTool(nint addr) : base(addr) { }
        public CurveControlPointsMechanic ControlPointsMechanic { get { return this[nameof(ControlPointsMechanic)].As<CurveControlPointsMechanic>(); } set { this["ControlPointsMechanic"] = value; } }
        public ConstructionPlaneMechanic PlaneMechanic { get { return this[nameof(PlaneMechanic)].As<ConstructionPlaneMechanic>(); } set { this["PlaneMechanic"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public RevolveToolProperties Settings { get { return this[nameof(Settings)].As<RevolveToolProperties>(); } set { this["Settings"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class DrawPolygonToolBuilder : InteractiveToolBuilder
    {
        public DrawPolygonToolBuilder(nint addr) : base(addr) { }
    }
    public class DrawPolygonToolStandardProperties : InteractiveToolPropertySet
    {
        public DrawPolygonToolStandardProperties(nint addr) : base(addr) { }
        public EDrawPolygonDrawMode PolygonDrawMode { get { return (EDrawPolygonDrawMode)this[nameof(PolygonDrawMode)].GetValue<int>(); } set { this[nameof(PolygonDrawMode)].SetValue<int>((int)value); } }
        public bool bAllowSelfIntersections { get { return this[nameof(bAllowSelfIntersections)].Flag; } set { this[nameof(bAllowSelfIntersections)].Flag = value; } }
        public float FeatureSizeRatio { get { return this[nameof(FeatureSizeRatio)].GetValue<float>(); } set { this[nameof(FeatureSizeRatio)].SetValue<float>(value); } }
        public int RadialSlices { get { return this[nameof(RadialSlices)].GetValue<int>(); } set { this[nameof(RadialSlices)].SetValue<int>(value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public bool bShowGridGizmo { get { return this[nameof(bShowGridGizmo)].Flag; } set { this[nameof(bShowGridGizmo)].Flag = value; } }
        public EDrawPolygonExtrudeMode ExtrudeMode { get { return (EDrawPolygonExtrudeMode)this[nameof(ExtrudeMode)].GetValue<int>(); } set { this[nameof(ExtrudeMode)].SetValue<int>((int)value); } }
        public float ExtrudeHeight { get { return this[nameof(ExtrudeHeight)].GetValue<float>(); } set { this[nameof(ExtrudeHeight)].SetValue<float>(value); } }
    }
    public class DrawPolygonToolSnapProperties : InteractiveToolPropertySet
    {
        public DrawPolygonToolSnapProperties(nint addr) : base(addr) { }
        public bool bEnableSnapping { get { return this[nameof(bEnableSnapping)].Flag; } set { this[nameof(bEnableSnapping)].Flag = value; } }
        public bool bSnapToWorldGrid { get { return this[nameof(bSnapToWorldGrid)].Flag; } set { this[nameof(bSnapToWorldGrid)].Flag = value; } }
        public bool bSnapToVertices { get { return this[nameof(bSnapToVertices)].Flag; } set { this[nameof(bSnapToVertices)].Flag = value; } }
        public bool bSnapToEdges { get { return this[nameof(bSnapToEdges)].Flag; } set { this[nameof(bSnapToEdges)].Flag = value; } }
        public bool bSnapToAxes { get { return this[nameof(bSnapToAxes)].Flag; } set { this[nameof(bSnapToAxes)].Flag = value; } }
        public bool bSnapToLengths { get { return this[nameof(bSnapToLengths)].Flag; } set { this[nameof(bSnapToLengths)].Flag = value; } }
        public bool bSnapToSurfaces { get { return this[nameof(bSnapToSurfaces)].Flag; } set { this[nameof(bSnapToSurfaces)].Flag = value; } }
        public float SnapToSurfacesOffset { get { return this[nameof(SnapToSurfacesOffset)].GetValue<float>(); } set { this[nameof(SnapToSurfacesOffset)].SetValue<float>(value); } }
    }
    public class DrawPolygonTool : InteractiveTool
    {
        public DrawPolygonTool(nint addr) : base(addr) { }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public DrawPolygonToolStandardProperties PolygonProperties { get { return this[nameof(PolygonProperties)].As<DrawPolygonToolStandardProperties>(); } set { this["PolygonProperties"] = value; } }
        public DrawPolygonToolSnapProperties SnapProperties { get { return this[nameof(SnapProperties)].As<DrawPolygonToolSnapProperties>(); } set { this["SnapProperties"] = value; } }
        public NewMeshMaterialProperties MaterialProperties { get { return this[nameof(MaterialProperties)].As<NewMeshMaterialProperties>(); } set { this["MaterialProperties"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public CombinedTransformGizmo PlaneTransformGizmo { get { return this[nameof(PlaneTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PlaneTransformGizmo"] = value; } }
        public TransformProxy PlaneTransformProxy { get { return this[nameof(PlaneTransformProxy)].As<TransformProxy>(); } set { this["PlaneTransformProxy"] = value; } }
        public PlaneDistanceFromHitMechanic HeightMechanic { get { return this[nameof(HeightMechanic)].As<PlaneDistanceFromHitMechanic>(); } set { this["HeightMechanic"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
    }
    public class EditMeshPolygonsToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public EditMeshPolygonsToolBuilder(nint addr) : base(addr) { }
    }
    public class PolyEditCommonProperties : InteractiveToolPropertySet
    {
        public PolyEditCommonProperties(nint addr) : base(addr) { }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public bool bShowSelectableCorners { get { return this[nameof(bShowSelectableCorners)].Flag; } set { this[nameof(bShowSelectableCorners)].Flag = value; } }
        public bool bGizmoVisible { get { return this[nameof(bGizmoVisible)].Flag; } set { this[nameof(bGizmoVisible)].Flag = value; } }
        public ELocalFrameMode LocalFrameMode { get { return (ELocalFrameMode)this[nameof(LocalFrameMode)].GetValue<int>(); } set { this[nameof(LocalFrameMode)].SetValue<int>((int)value); } }
        public bool bLockRotation { get { return this[nameof(bLockRotation)].Flag; } set { this[nameof(bLockRotation)].Flag = value; } }
        public bool bLocalCoordSystem { get { return this[nameof(bLocalCoordSystem)].Flag; } set { this[nameof(bLocalCoordSystem)].Flag = value; } }
    }
    public class EditMeshPolygonsActionModeToolBuilder : EditMeshPolygonsToolBuilder
    {
        public EditMeshPolygonsActionModeToolBuilder(nint addr) : base(addr) { }
    }
    public class EditMeshPolygonsSelectionModeToolBuilder : EditMeshPolygonsToolBuilder
    {
        public EditMeshPolygonsSelectionModeToolBuilder(nint addr) : base(addr) { }
    }
    public class EditMeshPolygonsToolActionPropertySet : InteractiveToolPropertySet
    {
        public EditMeshPolygonsToolActionPropertySet(nint addr) : base(addr) { }
    }
    public class PolyEditTopologyProperties : EditMeshPolygonsToolActionPropertySet
    {
        public PolyEditTopologyProperties(nint addr) : base(addr) { }
        public bool bAddExtraCorners { get { return this[nameof(bAddExtraCorners)].Flag; } set { this[nameof(bAddExtraCorners)].Flag = value; } }
        public double ExtraCornerAngleThresholdDegrees { get { return this[nameof(ExtraCornerAngleThresholdDegrees)].GetValue<double>(); } set { this[nameof(ExtraCornerAngleThresholdDegrees)].SetValue<double>(value); } }
        public void RegenerateExtraCorners() { Invoke(nameof(RegenerateExtraCorners)); }
    }
    public class EditMeshPolygonsToolActions : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolActions(nint addr) : base(addr) { }
        public void SimplifyByGroups() { Invoke(nameof(SimplifyByGroups)); }
        public void Retriangulate() { Invoke(nameof(Retriangulate)); }
        public void RecalcNormals() { Invoke(nameof(RecalcNormals)); }
        public void PushPull() { Invoke(nameof(PushPull)); }
        public void Outset() { Invoke(nameof(Outset)); }
        public void Offset() { Invoke(nameof(Offset)); }
        public void Merge() { Invoke(nameof(Merge)); }
        public void Inset() { Invoke(nameof(Inset)); }
        public void InsertEdgeLoop() { Invoke(nameof(InsertEdgeLoop)); }
        public void InsertEdge() { Invoke(nameof(InsertEdge)); }
        public void Flip() { Invoke(nameof(Flip)); }
        public void Extrude() { Invoke(nameof(Extrude)); }
        public void Duplicate() { Invoke(nameof(Duplicate)); }
        public void Disconnect() { Invoke(nameof(Disconnect)); }
        public void Delete() { Invoke(nameof(Delete)); }
        public void Decompose() { Invoke(nameof(Decompose)); }
        public void CutFaces() { Invoke(nameof(CutFaces)); }
        public void Bevel() { Invoke(nameof(Bevel)); }
    }
    public class EditMeshPolygonsToolActions_Triangles : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolActions_Triangles(nint addr) : base(addr) { }
        public void RecalcNormals() { Invoke(nameof(RecalcNormals)); }
        public void PushPull() { Invoke(nameof(PushPull)); }
        public void Poke() { Invoke(nameof(Poke)); }
        public void Outset() { Invoke(nameof(Outset)); }
        public void Offset() { Invoke(nameof(Offset)); }
        public void Inset() { Invoke(nameof(Inset)); }
        public void Flip() { Invoke(nameof(Flip)); }
        public void Extrude() { Invoke(nameof(Extrude)); }
        public void Duplicate() { Invoke(nameof(Duplicate)); }
        public void Disconnect() { Invoke(nameof(Disconnect)); }
        public void Delete() { Invoke(nameof(Delete)); }
        public void CutFaces() { Invoke(nameof(CutFaces)); }
    }
    public class EditMeshPolygonsToolUVActions : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolUVActions(nint addr) : base(addr) { }
        public void PlanarProjection() { Invoke(nameof(PlanarProjection)); }
    }
    public class EditMeshPolygonsToolEdgeActions : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolEdgeActions(nint addr) : base(addr) { }
        public void Weld() { Invoke(nameof(Weld)); }
        public void Straighten() { Invoke(nameof(Straighten)); }
        public void FillHole() { Invoke(nameof(FillHole)); }
        public void Bridge() { Invoke(nameof(Bridge)); }
        public void Bevel() { Invoke(nameof(Bevel)); }
    }
    public class EditMeshPolygonsToolEdgeActions_Triangles : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolEdgeActions_Triangles(nint addr) : base(addr) { }
        public void Weld() { Invoke(nameof(Weld)); }
        public void Split() { Invoke(nameof(Split)); }
        public void Flip() { Invoke(nameof(Flip)); }
        public void FillHole() { Invoke(nameof(FillHole)); }
        public void Collapse() { Invoke(nameof(Collapse)); }
    }
    public class EditMeshPolygonsToolCancelAction : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolCancelAction(nint addr) : base(addr) { }
        public void Done() { Invoke(nameof(Done)); }
    }
    public class EditMeshPolygonsToolAcceptCancelAction : EditMeshPolygonsToolActionPropertySet
    {
        public EditMeshPolygonsToolAcceptCancelAction(nint addr) : base(addr) { }
        public void Cancel() { Invoke(nameof(Cancel)); }
        public void Apply() { Invoke(nameof(Apply)); }
    }
    public class EditMeshPolygonsTool : SingleSelectionMeshEditingTool
    {
        public EditMeshPolygonsTool(nint addr) : base(addr) { }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public PolyEditCommonProperties CommonProps { get { return this[nameof(CommonProps)].As<PolyEditCommonProperties>(); } set { this["CommonProps"] = value; } }
        public EditMeshPolygonsToolActions EditActions { get { return this[nameof(EditActions)].As<EditMeshPolygonsToolActions>(); } set { this["EditActions"] = value; } }
        public EditMeshPolygonsToolActions_Triangles EditActions_Triangles { get { return this[nameof(EditActions_Triangles)].As<EditMeshPolygonsToolActions_Triangles>(); } set { this["EditActions_Triangles"] = value; } }
        public EditMeshPolygonsToolEdgeActions EditEdgeActions { get { return this[nameof(EditEdgeActions)].As<EditMeshPolygonsToolEdgeActions>(); } set { this["EditEdgeActions"] = value; } }
        public EditMeshPolygonsToolEdgeActions_Triangles EditEdgeActions_Triangles { get { return this[nameof(EditEdgeActions_Triangles)].As<EditMeshPolygonsToolEdgeActions_Triangles>(); } set { this["EditEdgeActions_Triangles"] = value; } }
        public EditMeshPolygonsToolUVActions EditUVActions { get { return this[nameof(EditUVActions)].As<EditMeshPolygonsToolUVActions>(); } set { this["EditUVActions"] = value; } }
        public EditMeshPolygonsToolCancelAction CancelAction { get { return this[nameof(CancelAction)].As<EditMeshPolygonsToolCancelAction>(); } set { this["CancelAction"] = value; } }
        public EditMeshPolygonsToolAcceptCancelAction AcceptCancelAction { get { return this[nameof(AcceptCancelAction)].As<EditMeshPolygonsToolAcceptCancelAction>(); } set { this["AcceptCancelAction"] = value; } }
        public PolyEditTopologyProperties TopologyProperties { get { return this[nameof(TopologyProperties)].As<PolyEditTopologyProperties>(); } set { this["TopologyProperties"] = value; } }
        public PolyEditExtrudeActivity ExtrudeActivity { get { return this[nameof(ExtrudeActivity)].As<PolyEditExtrudeActivity>(); } set { this["ExtrudeActivity"] = value; } }
        public PolyEditInsetOutsetActivity InsetOutsetActivity { get { return this[nameof(InsetOutsetActivity)].As<PolyEditInsetOutsetActivity>(); } set { this["InsetOutsetActivity"] = value; } }
        public PolyEditCutFacesActivity CutFacesActivity { get { return this[nameof(CutFacesActivity)].As<PolyEditCutFacesActivity>(); } set { this["CutFacesActivity"] = value; } }
        public PolyEditPlanarProjectionUVActivity PlanarProjectionUVActivity { get { return this[nameof(PlanarProjectionUVActivity)].As<PolyEditPlanarProjectionUVActivity>(); } set { this["PlanarProjectionUVActivity"] = value; } }
        public PolyEditInsertEdgeActivity InsertEdgeActivity { get { return this[nameof(InsertEdgeActivity)].As<PolyEditInsertEdgeActivity>(); } set { this["InsertEdgeActivity"] = value; } }
        public PolyEditInsertEdgeLoopActivity InsertEdgeLoopActivity { get { return this[nameof(InsertEdgeLoopActivity)].As<PolyEditInsertEdgeLoopActivity>(); } set { this["InsertEdgeLoopActivity"] = value; } }
        public PolyEditBevelEdgeActivity BevelEdgeActivity { get { return this[nameof(BevelEdgeActivity)].As<PolyEditBevelEdgeActivity>(); } set { this["BevelEdgeActivity"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
        public PolygonSelectionMechanic SelectionMechanic { get { return this[nameof(SelectionMechanic)].As<PolygonSelectionMechanic>(); } set { this["SelectionMechanic"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
    }
    public class NewMeshMaterialProperties : InteractiveToolPropertySet
    {
        public NewMeshMaterialProperties(nint addr) : base(addr) { }
        public Object Material { get { return this[nameof(Material)]; } set { this[nameof(Material)] = value; } }
        public float UVScale { get { return this[nameof(UVScale)].GetValue<float>(); } set { this[nameof(UVScale)].SetValue<float>(value); } }
        public bool bWorldSpaceUVScale { get { return this[nameof(bWorldSpaceUVScale)].Flag; } set { this[nameof(bWorldSpaceUVScale)].Flag = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public bool bShowExtendedOptions { get { return this[nameof(bShowExtendedOptions)].Flag; } set { this[nameof(bShowExtendedOptions)].Flag = value; } }
    }
    public class ExistingMeshMaterialProperties : InteractiveToolPropertySet
    {
        public ExistingMeshMaterialProperties(nint addr) : base(addr) { }
        public ESetMeshMaterialMode MaterialMode { get { return (ESetMeshMaterialMode)this[nameof(MaterialMode)].GetValue<int>(); } set { this[nameof(MaterialMode)].SetValue<int>((int)value); } }
        public float CheckerDensity { get { return this[nameof(CheckerDensity)].GetValue<float>(); } set { this[nameof(CheckerDensity)].SetValue<float>(value); } }
        public MaterialInterface OverrideMaterial { get { return this[nameof(OverrideMaterial)].As<MaterialInterface>(); } set { this["OverrideMaterial"] = value; } }
        public Object UVChannel { get { return this[nameof(UVChannel)]; } set { this[nameof(UVChannel)] = value; } }
        public Array<Object> UVChannelNamesList { get { return new Array<Object>(this[nameof(UVChannelNamesList)].Address); } }
        public MaterialInstanceDynamic CheckerMaterial { get { return this[nameof(CheckerMaterial)].As<MaterialInstanceDynamic>(); } set { this["CheckerMaterial"] = value; } }
        public Array<Object> GetUVChannelNamesFunc() { return Invoke<Array<Object>>(nameof(GetUVChannelNamesFunc)); }
    }
    public class MeshEditingViewProperties : InteractiveToolPropertySet
    {
        public MeshEditingViewProperties(nint addr) : base(addr) { }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public EMeshEditingMaterialModes MaterialMode { get { return (EMeshEditingMaterialModes)this[nameof(MaterialMode)].GetValue<int>(); } set { this[nameof(MaterialMode)].SetValue<int>((int)value); } }
        public bool bFlatShading { get { return this[nameof(bFlatShading)].Flag; } set { this[nameof(bFlatShading)].Flag = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public Texture2D Image { get { return this[nameof(Image)].As<Texture2D>(); } set { this["Image"] = value; } }
        public double Opacity { get { return this[nameof(Opacity)].GetValue<double>(); } set { this[nameof(Opacity)].SetValue<double>(value); } }
        public LinearColor TransparentMaterialColor { get { return this[nameof(TransparentMaterialColor)].As<LinearColor>(); } set { this["TransparentMaterialColor"] = value; } }
        public bool bTwoSided { get { return this[nameof(bTwoSided)].Flag; } set { this[nameof(bTwoSided)].Flag = value; } }
        public Object CustomMaterial { get { return this[nameof(CustomMaterial)]; } set { this[nameof(CustomMaterial)] = value; } }
    }
    public class MeshUVChannelProperties : InteractiveToolPropertySet
    {
        public MeshUVChannelProperties(nint addr) : base(addr) { }
        public Object UVChannel { get { return this[nameof(UVChannel)]; } set { this[nameof(UVChannel)] = value; } }
        public Array<Object> UVChannelNamesList { get { return new Array<Object>(this[nameof(UVChannelNamesList)].Address); } }
        public Array<Object> GetUVChannelNamesFunc() { return Invoke<Array<Object>>(nameof(GetUVChannelNamesFunc)); }
    }
    public class RecomputeUVsToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public RecomputeUVsToolBuilder(nint addr) : base(addr) { }
    }
    public class RecomputeUVsTool : SingleSelectionMeshEditingTool
    {
        public RecomputeUVsTool(nint addr) : base(addr) { }
        public MeshUVChannelProperties UVChannelProperties { get { return this[nameof(UVChannelProperties)].As<MeshUVChannelProperties>(); } set { this["UVChannelProperties"] = value; } }
        public RecomputeUVsToolProperties Settings { get { return this[nameof(Settings)].As<RecomputeUVsToolProperties>(); } set { this["Settings"] = value; } }
        public PolygroupLayersProperties PolygroupLayerProperties { get { return this[nameof(PolygroupLayerProperties)].As<PolygroupLayersProperties>(); } set { this["PolygroupLayerProperties"] = value; } }
        public ExistingMeshMaterialProperties MaterialSettings { get { return this[nameof(MaterialSettings)].As<ExistingMeshMaterialProperties>(); } set { this["MaterialSettings"] = value; } }
        public bool bCreateUVLayoutViewOnSetup { get { return this[nameof(bCreateUVLayoutViewOnSetup)].Flag; } set { this[nameof(bCreateUVLayoutViewOnSetup)].Flag = value; } }
        public UVLayoutPreview UVLayoutView { get { return this[nameof(UVLayoutView)].As<UVLayoutPreview>(); } set { this["UVLayoutView"] = value; } }
        public RecomputeUVsOpFactory RecomputeUVsOpFactory { get { return this[nameof(RecomputeUVsOpFactory)].As<RecomputeUVsOpFactory>(); } set { this["RecomputeUVsOpFactory"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class PolyEditBevelEdgeProperties : InteractiveToolPropertySet
    {
        public PolyEditBevelEdgeProperties(nint addr) : base(addr) { }
        public double BevelDistance { get { return this[nameof(BevelDistance)].GetValue<double>(); } set { this[nameof(BevelDistance)].SetValue<double>(value); } }
    }
    public class PolyEditBevelEdgeActivity : InteractiveToolActivity
    {
        public PolyEditBevelEdgeActivity(nint addr) : base(addr) { }
        public PolyEditBevelEdgeProperties BevelProperties { get { return this[nameof(BevelProperties)].As<PolyEditBevelEdgeProperties>(); } set { this["BevelProperties"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class PolyEditCutProperties : InteractiveToolPropertySet
    {
        public PolyEditCutProperties(nint addr) : base(addr) { }
        public EPolyEditCutPlaneOrientation Orientation { get { return (EPolyEditCutPlaneOrientation)this[nameof(Orientation)].GetValue<int>(); } set { this[nameof(Orientation)].SetValue<int>((int)value); } }
        public bool bSnapToVertices { get { return this[nameof(bSnapToVertices)].Flag; } set { this[nameof(bSnapToVertices)].Flag = value; } }
    }
    public class PolyEditCutFacesActivity : InteractiveToolActivity
    {
        public PolyEditCutFacesActivity(nint addr) : base(addr) { }
        public PolyEditCutProperties CutProperties { get { return this[nameof(CutProperties)].As<PolyEditCutProperties>(); } set { this["CutProperties"] = value; } }
        public PolyEditPreviewMesh EditPreview { get { return this[nameof(EditPreview)].As<PolyEditPreviewMesh>(); } set { this["EditPreview"] = value; } }
        public CollectSurfacePathMechanic SurfacePathMechanic { get { return this[nameof(SurfacePathMechanic)].As<CollectSurfacePathMechanic>(); } set { this["SurfacePathMechanic"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class PolyEditExtrudeProperties : InteractiveToolPropertySet
    {
        public PolyEditExtrudeProperties(nint addr) : base(addr) { }
        public EPolyEditExtrudeDistanceMode DistanceMode { get { return (EPolyEditExtrudeDistanceMode)this[nameof(DistanceMode)].GetValue<int>(); } set { this[nameof(DistanceMode)].SetValue<int>((int)value); } }
        public double Distance { get { return this[nameof(Distance)].GetValue<double>(); } set { this[nameof(Distance)].SetValue<double>(value); } }
        public EPolyEditExtrudeDirection Direction { get { return (EPolyEditExtrudeDirection)this[nameof(Direction)].GetValue<int>(); } set { this[nameof(Direction)].SetValue<int>((int)value); } }
        public EPolyEditExtrudeDirection MeasureDirection { get { return (EPolyEditExtrudeDirection)this[nameof(MeasureDirection)].GetValue<int>(); } set { this[nameof(MeasureDirection)].SetValue<int>((int)value); } }
        public bool bShellsToSolids { get { return this[nameof(bShellsToSolids)].Flag; } set { this[nameof(bShellsToSolids)].Flag = value; } }
        public EPolyEditExtrudeModeOptions DirectionMode { get { return (EPolyEditExtrudeModeOptions)this[nameof(DirectionMode)].GetValue<int>(); } set { this[nameof(DirectionMode)].SetValue<int>((int)value); } }
        public double MaxDistanceScaleFactor { get { return this[nameof(MaxDistanceScaleFactor)].GetValue<double>(); } set { this[nameof(MaxDistanceScaleFactor)].SetValue<double>(value); } }
        public bool bUseColinearityForSettingBorderGroups { get { return this[nameof(bUseColinearityForSettingBorderGroups)].Flag; } set { this[nameof(bUseColinearityForSettingBorderGroups)].Flag = value; } }
    }
    public class PolyEditOffsetProperties : InteractiveToolPropertySet
    {
        public PolyEditOffsetProperties(nint addr) : base(addr) { }
        public EPolyEditExtrudeDistanceMode DistanceMode { get { return (EPolyEditExtrudeDistanceMode)this[nameof(DistanceMode)].GetValue<int>(); } set { this[nameof(DistanceMode)].SetValue<int>((int)value); } }
        public double Distance { get { return this[nameof(Distance)].GetValue<double>(); } set { this[nameof(Distance)].SetValue<double>(value); } }
        public EPolyEditOffsetModeOptions DirectionMode { get { return (EPolyEditOffsetModeOptions)this[nameof(DirectionMode)].GetValue<int>(); } set { this[nameof(DirectionMode)].SetValue<int>((int)value); } }
        public double MaxDistanceScaleFactor { get { return this[nameof(MaxDistanceScaleFactor)].GetValue<double>(); } set { this[nameof(MaxDistanceScaleFactor)].SetValue<double>(value); } }
        public bool bShellsToSolids { get { return this[nameof(bShellsToSolids)].Flag; } set { this[nameof(bShellsToSolids)].Flag = value; } }
        public EPolyEditExtrudeDirection MeasureDirection { get { return (EPolyEditExtrudeDirection)this[nameof(MeasureDirection)].GetValue<int>(); } set { this[nameof(MeasureDirection)].SetValue<int>((int)value); } }
        public bool bUseColinearityForSettingBorderGroups { get { return this[nameof(bUseColinearityForSettingBorderGroups)].Flag; } set { this[nameof(bUseColinearityForSettingBorderGroups)].Flag = value; } }
    }
    public class PolyEditPushPullProperties : InteractiveToolPropertySet
    {
        public PolyEditPushPullProperties(nint addr) : base(addr) { }
        public EPolyEditExtrudeDistanceMode DistanceMode { get { return (EPolyEditExtrudeDistanceMode)this[nameof(DistanceMode)].GetValue<int>(); } set { this[nameof(DistanceMode)].SetValue<int>((int)value); } }
        public double Distance { get { return this[nameof(Distance)].GetValue<double>(); } set { this[nameof(Distance)].SetValue<double>(value); } }
        public EPolyEditPushPullModeOptions DirectionMode { get { return (EPolyEditPushPullModeOptions)this[nameof(DirectionMode)].GetValue<int>(); } set { this[nameof(DirectionMode)].SetValue<int>((int)value); } }
        public double MaxDistanceScaleFactor { get { return this[nameof(MaxDistanceScaleFactor)].GetValue<double>(); } set { this[nameof(MaxDistanceScaleFactor)].SetValue<double>(value); } }
        public bool bShellsToSolids { get { return this[nameof(bShellsToSolids)].Flag; } set { this[nameof(bShellsToSolids)].Flag = value; } }
        public EPolyEditExtrudeDirection MeasureDirection { get { return (EPolyEditExtrudeDirection)this[nameof(MeasureDirection)].GetValue<int>(); } set { this[nameof(MeasureDirection)].SetValue<int>((int)value); } }
        public bool bUseColinearityForSettingBorderGroups { get { return this[nameof(bUseColinearityForSettingBorderGroups)].Flag; } set { this[nameof(bUseColinearityForSettingBorderGroups)].Flag = value; } }
    }
    public class PolyEditExtrudeActivity : InteractiveToolActivity
    {
        public PolyEditExtrudeActivity(nint addr) : base(addr) { }
        public PolyEditExtrudeProperties ExtrudeProperties { get { return this[nameof(ExtrudeProperties)].As<PolyEditExtrudeProperties>(); } set { this["ExtrudeProperties"] = value; } }
        public PolyEditOffsetProperties OffsetProperties { get { return this[nameof(OffsetProperties)].As<PolyEditOffsetProperties>(); } set { this["OffsetProperties"] = value; } }
        public PolyEditPushPullProperties PushPullProperties { get { return this[nameof(PushPullProperties)].As<PolyEditPushPullProperties>(); } set { this["PushPullProperties"] = value; } }
        public PlaneDistanceFromHitMechanic ExtrudeHeightMechanic { get { return this[nameof(ExtrudeHeightMechanic)].As<PlaneDistanceFromHitMechanic>(); } set { this["ExtrudeHeightMechanic"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class GroupEdgeInsertionProperties : InteractiveToolPropertySet
    {
        public GroupEdgeInsertionProperties(nint addr) : base(addr) { }
        public EGroupEdgeInsertionMode InsertionMode { get { return (EGroupEdgeInsertionMode)this[nameof(InsertionMode)].GetValue<int>(); } set { this[nameof(InsertionMode)].SetValue<int>((int)value); } }
        public double VertexTolerance { get { return this[nameof(VertexTolerance)].GetValue<double>(); } set { this[nameof(VertexTolerance)].SetValue<double>(value); } }
    }
    public class PolyEditInsertEdgeActivity : InteractiveToolActivity
    {
        public PolyEditInsertEdgeActivity(nint addr) : base(addr) { }
        public GroupEdgeInsertionProperties Settings { get { return this[nameof(Settings)].As<GroupEdgeInsertionProperties>(); } set { this["Settings"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class EdgeLoopInsertionProperties : InteractiveToolPropertySet
    {
        public EdgeLoopInsertionProperties(nint addr) : base(addr) { }
        public EEdgeLoopPositioningMode PositionMode { get { return (EEdgeLoopPositioningMode)this[nameof(PositionMode)].GetValue<int>(); } set { this[nameof(PositionMode)].SetValue<int>((int)value); } }
        public EEdgeLoopInsertionMode InsertionMode { get { return (EEdgeLoopInsertionMode)this[nameof(InsertionMode)].GetValue<int>(); } set { this[nameof(InsertionMode)].SetValue<int>((int)value); } }
        public int NumLoops { get { return this[nameof(NumLoops)].GetValue<int>(); } set { this[nameof(NumLoops)].SetValue<int>(value); } }
        public double ProportionOffset { get { return this[nameof(ProportionOffset)].GetValue<double>(); } set { this[nameof(ProportionOffset)].SetValue<double>(value); } }
        public double DistanceOffset { get { return this[nameof(DistanceOffset)].GetValue<double>(); } set { this[nameof(DistanceOffset)].SetValue<double>(value); } }
        public bool bInteractive { get { return this[nameof(bInteractive)].Flag; } set { this[nameof(bInteractive)].Flag = value; } }
        public bool bFlipOffsetDirection { get { return this[nameof(bFlipOffsetDirection)].Flag; } set { this[nameof(bFlipOffsetDirection)].Flag = value; } }
        public bool bHighlightProblemGroups { get { return this[nameof(bHighlightProblemGroups)].Flag; } set { this[nameof(bHighlightProblemGroups)].Flag = value; } }
        public double VertexTolerance { get { return this[nameof(VertexTolerance)].GetValue<double>(); } set { this[nameof(VertexTolerance)].SetValue<double>(value); } }
    }
    public class PolyEditInsertEdgeLoopActivity : InteractiveToolActivity
    {
        public PolyEditInsertEdgeLoopActivity(nint addr) : base(addr) { }
        public EdgeLoopInsertionProperties Settings { get { return this[nameof(Settings)].As<EdgeLoopInsertionProperties>(); } set { this["Settings"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class PolyEditInsetOutsetProperties : InteractiveToolPropertySet
    {
        public PolyEditInsetOutsetProperties(nint addr) : base(addr) { }
        public float Softness { get { return this[nameof(Softness)].GetValue<float>(); } set { this[nameof(Softness)].SetValue<float>(value); } }
        public bool bBoundaryOnly { get { return this[nameof(bBoundaryOnly)].Flag; } set { this[nameof(bBoundaryOnly)].Flag = value; } }
        public float AreaScale { get { return this[nameof(AreaScale)].GetValue<float>(); } set { this[nameof(AreaScale)].SetValue<float>(value); } }
        public bool bReproject { get { return this[nameof(bReproject)].Flag; } set { this[nameof(bReproject)].Flag = value; } }
        public bool bOutset { get { return this[nameof(bOutset)].Flag; } set { this[nameof(bOutset)].Flag = value; } }
    }
    public class PolyEditInsetOutsetActivity : InteractiveToolActivity
    {
        public PolyEditInsetOutsetActivity(nint addr) : base(addr) { }
        public PolyEditInsetOutsetProperties Settings { get { return this[nameof(Settings)].As<PolyEditInsetOutsetProperties>(); } set { this["Settings"] = value; } }
        public PolyEditPreviewMesh EditPreview { get { return this[nameof(EditPreview)].As<PolyEditPreviewMesh>(); } set { this["EditPreview"] = value; } }
        public SpatialCurveDistanceMechanic CurveDistMechanic { get { return this[nameof(CurveDistMechanic)].As<SpatialCurveDistanceMechanic>(); } set { this["CurveDistMechanic"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class PolyEditSetUVProperties : InteractiveToolPropertySet
    {
        public PolyEditSetUVProperties(nint addr) : base(addr) { }
        public bool bShowMaterial { get { return this[nameof(bShowMaterial)].Flag; } set { this[nameof(bShowMaterial)].Flag = value; } }
    }
    public class PolyEditPlanarProjectionUVActivity : InteractiveToolActivity
    {
        public PolyEditPlanarProjectionUVActivity(nint addr) : base(addr) { }
        public PolyEditSetUVProperties SetUVProperties { get { return this[nameof(SetUVProperties)].As<PolyEditSetUVProperties>(); } set { this["SetUVProperties"] = value; } }
        public PolyEditPreviewMesh EditPreview { get { return this[nameof(EditPreview)].As<PolyEditPreviewMesh>(); } set { this["EditPreview"] = value; } }
        public CollectSurfacePathMechanic SurfacePathMechanic { get { return this[nameof(SurfacePathMechanic)].As<CollectSurfacePathMechanic>(); } set { this["SurfacePathMechanic"] = value; } }
        public PolyEditActivityContext ActivityContext { get { return this[nameof(ActivityContext)].As<PolyEditActivityContext>(); } set { this["ActivityContext"] = value; } }
    }
    public class UVLayoutToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public UVLayoutToolBuilder(nint addr) : base(addr) { }
    }
    public class UVLayoutTool : MultiSelectionMeshEditingTool
    {
        public UVLayoutTool(nint addr) : base(addr) { }
        public MeshUVChannelProperties UVChannelProperties { get { return this[nameof(UVChannelProperties)].As<MeshUVChannelProperties>(); } set { this["UVChannelProperties"] = value; } }
        public UVLayoutProperties BasicProperties { get { return this[nameof(BasicProperties)].As<UVLayoutProperties>(); } set { this["BasicProperties"] = value; } }
        public ExistingMeshMaterialProperties MaterialSettings { get { return this[nameof(MaterialSettings)].As<ExistingMeshMaterialProperties>(); } set { this["MaterialSettings"] = value; } }
        public Array<MeshOpPreviewWithBackgroundCompute> Previews { get { return new Array<MeshOpPreviewWithBackgroundCompute>(this[nameof(Previews)].Address); } }
        public Array<UVLayoutOperatorFactory> Factories { get { return new Array<UVLayoutOperatorFactory>(this[nameof(Factories)].Address); } }
        public UVLayoutPreview UVLayoutView { get { return this[nameof(UVLayoutView)].As<UVLayoutPreview>(); } set { this["UVLayoutView"] = value; } }
    }
    public class UVProjectionToolBuilder : SingleSelectionMeshEditingToolBuilder
    {
        public UVProjectionToolBuilder(nint addr) : base(addr) { }
    }
    public class UVProjectionToolEditActions : InteractiveToolPropertySet
    {
        public UVProjectionToolEditActions(nint addr) : base(addr) { }
        public void Reset() { Invoke(nameof(Reset)); }
        public void AutoFitAlign() { Invoke(nameof(AutoFitAlign)); }
        public void AutoFit() { Invoke(nameof(AutoFit)); }
    }
    public class UVProjectionToolProperties : InteractiveToolPropertySet
    {
        public UVProjectionToolProperties(nint addr) : base(addr) { }
        public EUVProjectionMethod ProjectionType { get { return (EUVProjectionMethod)this[nameof(ProjectionType)].GetValue<int>(); } set { this[nameof(ProjectionType)].SetValue<int>((int)value); } }
        public Vector Dimensions { get { return this[nameof(Dimensions)].As<Vector>(); } set { this["Dimensions"] = value; } }
        public bool bUniformDimensions { get { return this[nameof(bUniformDimensions)].Flag; } set { this[nameof(bUniformDimensions)].Flag = value; } }
        public EUVProjectionToolInitializationMode Initialization { get { return (EUVProjectionToolInitializationMode)this[nameof(Initialization)].GetValue<int>(); } set { this[nameof(Initialization)].SetValue<int>((int)value); } }
        public float CylinderSplitAngle { get { return this[nameof(CylinderSplitAngle)].GetValue<float>(); } set { this[nameof(CylinderSplitAngle)].SetValue<float>(value); } }
        public float ExpMapNormalBlending { get { return this[nameof(ExpMapNormalBlending)].GetValue<float>(); } set { this[nameof(ExpMapNormalBlending)].SetValue<float>(value); } }
        public int ExpMapSmoothingSteps { get { return this[nameof(ExpMapSmoothingSteps)].GetValue<int>(); } set { this[nameof(ExpMapSmoothingSteps)].SetValue<int>(value); } }
        public float ExpMapSmoothingAlpha { get { return this[nameof(ExpMapSmoothingAlpha)].GetValue<float>(); } set { this[nameof(ExpMapSmoothingAlpha)].SetValue<float>(value); } }
        public float Rotation { get { return this[nameof(Rotation)].GetValue<float>(); } set { this[nameof(Rotation)].SetValue<float>(value); } }
        public Vector2D Scale { get { return this[nameof(Scale)].As<Vector2D>(); } set { this["Scale"] = value; } }
        public Vector2D Translation { get { return this[nameof(Translation)].As<Vector2D>(); } set { this["Translation"] = value; } }
        public Vector SavedDimensions { get { return this[nameof(SavedDimensions)].As<Vector>(); } set { this["SavedDimensions"] = value; } }
        public bool bSavedUniformDimensions { get { return this[nameof(bSavedUniformDimensions)].Flag; } set { this[nameof(bSavedUniformDimensions)].Flag = value; } }
        public Transform SavedTransform { get { return this[nameof(SavedTransform)].As<Transform>(); } set { this["SavedTransform"] = value; } }
    }
    public class UVProjectionOperatorFactory : Object
    {
        public UVProjectionOperatorFactory(nint addr) : base(addr) { }
        public UVProjectionTool Tool { get { return this[nameof(Tool)].As<UVProjectionTool>(); } set { this["Tool"] = value; } }
    }
    public class UVProjectionTool : SingleSelectionMeshEditingTool
    {
        public UVProjectionTool(nint addr) : base(addr) { }
        public MeshUVChannelProperties UVChannelProperties { get { return this[nameof(UVChannelProperties)].As<MeshUVChannelProperties>(); } set { this["UVChannelProperties"] = value; } }
        public UVProjectionToolProperties BasicProperties { get { return this[nameof(BasicProperties)].As<UVProjectionToolProperties>(); } set { this["BasicProperties"] = value; } }
        public UVProjectionToolEditActions EditActions { get { return this[nameof(EditActions)].As<UVProjectionToolEditActions>(); } set { this["EditActions"] = value; } }
        public ExistingMeshMaterialProperties MaterialSettings { get { return this[nameof(MaterialSettings)].As<ExistingMeshMaterialProperties>(); } set { this["MaterialSettings"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public MaterialInstanceDynamic CheckerMaterial { get { return this[nameof(CheckerMaterial)].As<MaterialInstanceDynamic>(); } set { this["CheckerMaterial"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public UVProjectionOperatorFactory OperatorFactory { get { return this[nameof(OperatorFactory)].As<UVProjectionOperatorFactory>(); } set { this["OperatorFactory"] = value; } }
        public PreviewGeometry EdgeRenderer { get { return this[nameof(EdgeRenderer)].As<PreviewGeometry>(); } set { this["EdgeRenderer"] = value; } }
        public SingleClickInputBehavior ClickToSetPlaneBehavior { get { return this[nameof(ClickToSetPlaneBehavior)].As<SingleClickInputBehavior>(); } set { this["ClickToSetPlaneBehavior"] = value; } }
    }
    public enum EMakeMeshPlacementType : int
    {
        GroundPlane = 0,
        OnScene = 1,
        EMakeMeshPlacementType_MAX = 2,
    }
    public enum EMakeMeshPivotLocation : int
    {
        Base = 0,
        Centered = 1,
        Top = 2,
        EMakeMeshPivotLocation_MAX = 3,
    }
    public enum EMakeMeshPolygroupMode : int
    {
        PerShape = 0,
        PerFace = 1,
        PerQuad = 2,
        EMakeMeshPolygroupMode_MAX = 3,
    }
    public enum EProceduralRectType : int
    {
        Rectangle = 0,
        RoundedRectangle = 1,
        EProceduralRectType_MAX = 2,
    }
    public enum EProceduralDiscType : int
    {
        Disc = 0,
        PuncturedDisc = 1,
        EProceduralDiscType_MAX = 2,
    }
    public enum EProceduralSphereType : int
    {
        LatLong = 0,
        Box = 1,
        EProceduralSphereType_MAX = 2,
    }
    public enum EProceduralStairsType : int
    {
        Linear = 0,
        Floating = 1,
        Curved = 2,
        Spiral = 3,
        EProceduralStairsType_MAX = 4,
    }
    public enum EDrawPolygonDrawMode : int
    {
        Freehand = 0,
        Circle = 1,
        Square = 2,
        Rectangle = 3,
        RoundedRectangle = 4,
        Ring = 5,
        EDrawPolygonDrawMode_MAX = 6,
    }
    public enum EDrawPolygonExtrudeMode : int
    {
        Flat = 0,
        Fixed = 1,
        Interactive = 2,
        EDrawPolygonExtrudeMode_MAX = 3,
    }
    public enum ELocalFrameMode : int
    {
        FromObject = 0,
        FromGeometry = 1,
        ELocalFrameMode_MAX = 2,
    }
    public enum EEditMeshPolygonsToolActions : int
    {
        NoAction = 0,
        AcceptCurrent = 1,
        CancelCurrent = 2,
        Extrude = 3,
        PushPull = 4,
        Offset = 5,
        Inset = 6,
        Outset = 7,
        BevelFaces = 8,
        InsertEdge = 9,
        InsertEdgeLoop = 10,
        Complete = 11,
        PlaneCut = 12,
        Merge = 13,
        Delete = 14,
        CutFaces = 15,
        RecalculateNormals = 16,
        FlipNormals = 17,
        Retriangulate = 18,
        Decompose = 19,
        Disconnect = 20,
        Duplicate = 21,
        CollapseEdge = 22,
        WeldEdges = 23,
        StraightenEdge = 24,
        FillHole = 25,
        BridgeEdges = 26,
        BevelEdges = 27,
        PlanarProjectionUV = 28,
        SimplifyByGroups = 29,
        RegenerateExtraCorners = 30,
        PokeSingleFace = 31,
        SplitSingleEdge = 32,
        FlipSingleEdge = 33,
        CollapseSingleEdge = 34,
        EEditMeshPolygonsToolActions_MAX = 35,
    }
    public enum EEditMeshPolygonsToolSelectionMode : int
    {
        Faces = 0,
        Edges = 1,
        Vertices = 2,
        Loops = 3,
        Rings = 4,
        FacesEdgesVertices = 5,
        EEditMeshPolygonsToolSelectionMode_MAX = 6,
    }
    public enum ESetMeshMaterialMode : int
    {
        Original = 0,
        Checkerboard = 1,
        Override = 2,
        ESetMeshMaterialMode_MAX = 3,
    }
    public enum EMeshEditingMaterialModes : int
    {
        ExistingMaterial = 0,
        Diffuse = 1,
        Grey = 2,
        Soft = 3,
        Transparent = 4,
        TangentNormal = 5,
        VertexColor = 6,
        CustomImage = 7,
        Custom = 8,
        EMeshEditingMaterialModes_MAX = 9,
    }
    public enum ERevolvePropertiesCapFillMode : int
    {
        None = 0,
        CenterFan = 1,
        Delaunay = 2,
        EarClipping = 3,
        ERevolvePropertiesCapFillMode_MAX = 4,
    }
    public enum ERevolvePropertiesPolygroupMode : int
    {
        PerShape = 0,
        PerFace = 1,
        PerRevolveStep = 2,
        PerPathSegment = 3,
        ERevolvePropertiesPolygroupMode_MAX = 4,
    }
    public enum ERevolvePropertiesQuadSplit : int
    {
        Uniform = 0,
        Compact = 1,
        ERevolvePropertiesQuadSplit_MAX = 2,
    }
    public enum EPolyEditCutPlaneOrientation : int
    {
        FaceNormals = 0,
        ViewDirection = 1,
        EPolyEditCutPlaneOrientation_MAX = 2,
    }
    public enum EPolyEditExtrudeDirection : int
    {
        SelectionNormal = 0,
        WorldX = 1,
        WorldY = 2,
        WorldZ = 3,
        LocalX = 4,
        LocalY = 5,
        LocalZ = 6,
        EPolyEditExtrudeDirection_MAX = 7,
    }
    public enum EPolyEditExtrudeDistanceMode : int
    {
        ClickInViewport = 0,
        Fixed = 1,
        EPolyEditExtrudeDistanceMode_MAX = 2,
    }
    public enum EPolyEditExtrudeModeOptions : int
    {
        SingleDirection = 3,
        SelectedTriangleNormals = 0,
        SelectedTriangleNormalsEven = 1,
        EPolyEditExtrudeModeOptions_MAX = 4,
    }
    public enum EPolyEditOffsetModeOptions : int
    {
        VertexNormals = 2,
        SelectedTriangleNormals = 0,
        SelectedTriangleNormalsEven = 1,
        EPolyEditOffsetModeOptions_MAX = 3,
    }
    public enum EPolyEditPushPullModeOptions : int
    {
        SelectedTriangleNormals = 0,
        SelectedTriangleNormalsEven = 1,
        SingleDirection = 3,
        VertexNormals = 2,
        EPolyEditPushPullModeOptions_MAX = 4,
    }
    public enum EGroupEdgeInsertionMode : int
    {
        Retriangulate = 0,
        PlaneCut = 1,
        EGroupEdgeInsertionMode_MAX = 2,
    }
    public enum EEdgeLoopPositioningMode : int
    {
        Even = 0,
        ProportionOffset = 1,
        DistanceOffset = 2,
        EEdgeLoopPositioningMode_MAX = 3,
    }
    public enum EEdgeLoopInsertionMode : int
    {
        Retriangulate = 0,
        PlaneCut = 1,
        EEdgeLoopInsertionMode_MAX = 2,
    }
    public enum EUVProjectionToolActions : int
    {
        NoAction = 0,
        AutoFit = 1,
        AutoFitAlign = 2,
        Reset = 3,
        EUVProjectionToolActions_MAX = 4,
    }
    public enum EUVProjectionToolInitializationMode : int
    {
        Default = 0,
        UsePrevious = 1,
        AutoFit = 2,
        AutoFitAlign = 3,
        EUVProjectionToolInitializationMode_MAX = 4,
    }
}
