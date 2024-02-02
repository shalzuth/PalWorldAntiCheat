using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.InteractiveToolsFrameworkSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.GeometryFrameworkSDK;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.ModelingComponentsSDK
{
    public class MultiSelectionMeshEditingToolBuilder : InteractiveToolWithToolTargetsBuilder
    {
        public MultiSelectionMeshEditingToolBuilder(nint addr) : base(addr) { }
    }
    public class MultiSelectionMeshEditingTool : MultiSelectionTool
    {
        public MultiSelectionMeshEditingTool(nint addr) : base(addr) { }
        public Object TargetWorld { get { return this[nameof(TargetWorld)]; } set { this[nameof(TargetWorld)] = value; } }
    }
    public class SingleSelectionMeshEditingToolBuilder : InteractiveToolWithToolTargetsBuilder
    {
        public SingleSelectionMeshEditingToolBuilder(nint addr) : base(addr) { }
    }
    public class SingleSelectionMeshEditingTool : SingleSelectionTool
    {
        public SingleSelectionMeshEditingTool(nint addr) : base(addr) { }
        public Object TargetWorld { get { return this[nameof(TargetWorld)]; } set { this[nameof(TargetWorld)] = value; } }
        public PersistentMeshSelection InputSelection { get { return this[nameof(InputSelection)].As<PersistentMeshSelection>(); } set { this["InputSelection"] = value; } }
    }
    public class MeshSurfacePointMeshEditingToolBuilder : MeshSurfacePointToolBuilder
    {
        public MeshSurfacePointMeshEditingToolBuilder(nint addr) : base(addr) { }
    }
    public class WeightMapSetProperties : InteractiveToolPropertySet
    {
        public WeightMapSetProperties(nint addr) : base(addr) { }
        public Object WeightMap { get { return this[nameof(WeightMap)]; } set { this[nameof(WeightMap)] = value; } }
        public Array<Object> WeightMapsList { get { return new Array<Object>(this[nameof(WeightMapsList)].Address); } }
        public bool bInvertWeightMap { get { return this[nameof(bInvertWeightMap)].Flag; } set { this[nameof(bInvertWeightMap)].Flag = value; } }
        public Array<Object> GetWeightMapsFunc() { return Invoke<Array<Object>>(nameof(GetWeightMapsFunc)); }
    }
    public class BaseMeshProcessingTool : SingleSelectionTool
    {
        public BaseMeshProcessingTool(nint addr) : base(addr) { }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
    }
    public class BaseMeshProcessingToolBuilder : InteractiveToolWithToolTargetsBuilder
    {
        public BaseMeshProcessingToolBuilder(nint addr) : base(addr) { }
    }
    public class BaseCreateFromSelectedTool : MultiSelectionMeshEditingTool
    {
        public BaseCreateFromSelectedTool(nint addr) : base(addr) { }
        public TransformInputsToolProperties TransformProperties { get { return this[nameof(TransformProperties)].As<TransformInputsToolProperties>(); } set { this["TransformProperties"] = value; } }
        public CreateMeshObjectTypeProperties OutputTypeProperties { get { return this[nameof(OutputTypeProperties)].As<CreateMeshObjectTypeProperties>(); } set { this["OutputTypeProperties"] = value; } }
        public BaseCreateFromSelectedHandleSourceProperties HandleSourcesProperties { get { return this[nameof(HandleSourcesProperties)].As<BaseCreateFromSelectedHandleSourceProperties>(); } set { this["HandleSourcesProperties"] = value; } }
        public MeshOpPreviewWithBackgroundCompute Preview { get { return this[nameof(Preview)].As<MeshOpPreviewWithBackgroundCompute>(); } set { this["Preview"] = value; } }
        public Array<TransformProxy> TransformProxies { get { return new Array<TransformProxy>(this[nameof(TransformProxies)].Address); } }
        public Array<CombinedTransformGizmo> TransformGizmos { get { return new Array<CombinedTransformGizmo>(this[nameof(TransformGizmos)].Address); } }
    }
    public class BaseCreateFromSelectedToolBuilder : MultiSelectionMeshEditingToolBuilder
    {
        public BaseCreateFromSelectedToolBuilder(nint addr) : base(addr) { }
    }
    public class BaseVoxelTool : BaseCreateFromSelectedTool
    {
        public BaseVoxelTool(nint addr) : base(addr) { }
        public VoxelProperties VoxProperties { get { return this[nameof(VoxProperties)].As<VoxelProperties>(); } set { this["VoxProperties"] = value; } }
    }
    public class GeometrySelectionEditCommand : InteractiveCommand
    {
        public GeometrySelectionEditCommand(nint addr) : base(addr) { }
    }
    public class InteractiveToolActivity : InteractionMechanic
    {
        public InteractiveToolActivity(nint addr) : base(addr) { }
    }
    public class DynamicMeshCommitter : Interface
    {
        public DynamicMeshCommitter(nint addr) : base(addr) { }
    }
    public class DynamicMeshProvider : Interface
    {
        public DynamicMeshProvider(nint addr) : base(addr) { }
    }
    public class PersistentDynamicMeshSource : Interface
    {
        public PersistentDynamicMeshSource(nint addr) : base(addr) { }
    }
    public class GeometrySelectionManager : Object
    {
        public GeometrySelectionManager(nint addr) : base(addr) { }
        public GeometrySelectionEditCommandArguments SelectionArguments { get { return this[nameof(SelectionArguments)].As<GeometrySelectionEditCommandArguments>(); } set { this["SelectionArguments"] = value; } }
        public InteractiveToolsContext ToolsContext { get { return this[nameof(ToolsContext)].As<InteractiveToolsContext>(); } set { this["ToolsContext"] = value; } }
        public PersistentMeshSelection OldSelection { get { return this[nameof(OldSelection)].As<PersistentMeshSelection>(); } set { this["OldSelection"] = value; } }
    }
    public class ToolActivityHost : Interface
    {
        public ToolActivityHost(nint addr) : base(addr) { }
    }
    public class GeometrySelectionEditCommandArguments : InteractiveCommandArguments
    {
        public GeometrySelectionEditCommandArguments(nint addr) : base(addr) { }
    }
    public class VoxelProperties : InteractiveToolPropertySet
    {
        public VoxelProperties(nint addr) : base(addr) { }
        public int VoxelCount { get { return this[nameof(VoxelCount)].GetValue<int>(); } set { this[nameof(VoxelCount)].SetValue<int>(value); } }
        public bool bAutoSimplify { get { return this[nameof(bAutoSimplify)].Flag; } set { this[nameof(bAutoSimplify)].Flag = value; } }
        public bool bRemoveInternalSurfaces { get { return this[nameof(bRemoveInternalSurfaces)].Flag; } set { this[nameof(bRemoveInternalSurfaces)].Flag = value; } }
        public double SimplifyMaxErrorFactor { get { return this[nameof(SimplifyMaxErrorFactor)].GetValue<double>(); } set { this[nameof(SimplifyMaxErrorFactor)].SetValue<double>(value); } }
        public double CubeRootMinComponentVolume { get { return this[nameof(CubeRootMinComponentVolume)].GetValue<double>(); } set { this[nameof(CubeRootMinComponentVolume)].SetValue<double>(value); } }
    }
    public class OnAcceptHandleSourcesPropertiesBase : InteractiveToolPropertySet
    {
        public OnAcceptHandleSourcesPropertiesBase(nint addr) : base(addr) { }
    }
    public class OnAcceptHandleSourcesProperties : OnAcceptHandleSourcesPropertiesBase
    {
        public OnAcceptHandleSourcesProperties(nint addr) : base(addr) { }
        public EHandleSourcesMethod HandleInputs { get { return (EHandleSourcesMethod)this[nameof(HandleInputs)].GetValue<int>(); } set { this[nameof(HandleInputs)].SetValue<int>((int)value); } }
    }
    public class BaseCreateFromSelectedHandleSourceProperties : OnAcceptHandleSourcesProperties
    {
        public BaseCreateFromSelectedHandleSourceProperties(nint addr) : base(addr) { }
        public EBaseCreateFromSelectedTargetType OutputWriteTo { get { return (EBaseCreateFromSelectedTargetType)this[nameof(OutputWriteTo)].GetValue<int>(); } set { this[nameof(OutputWriteTo)].SetValue<int>((int)value); } }
        public Object OutputNewName { get { return this[nameof(OutputNewName)]; } set { this[nameof(OutputNewName)] = value; } }
        public Object OutputExistingName { get { return this[nameof(OutputExistingName)]; } set { this[nameof(OutputExistingName)] = value; } }
    }
    public class TransformInputsToolProperties : InteractiveToolPropertySet
    {
        public TransformInputsToolProperties(nint addr) : base(addr) { }
        public bool bShowTransformGizmo { get { return this[nameof(bShowTransformGizmo)].Flag; } set { this[nameof(bShowTransformGizmo)].Flag = value; } }
    }
    public class DynamicMeshReplacementChangeTarget : Object
    {
        public DynamicMeshReplacementChangeTarget(nint addr) : base(addr) { }
    }
    public class OctreeDynamicMeshComponent : BaseDynamicMeshComponent
    {
        public OctreeDynamicMeshComponent(nint addr) : base(addr) { }
        public DynamicMesh MeshObject { get { return this[nameof(MeshObject)].As<DynamicMesh>(); } set { this["MeshObject"] = value; } }
        public void SetDynamicMesh(DynamicMesh NewMesh) { Invoke(nameof(SetDynamicMesh), NewMesh); }
    }
    public class LineSetComponent : MeshComponent
    {
        public LineSetComponent(nint addr) : base(addr) { }
        public MaterialInterface LineMaterial { get { return this[nameof(LineMaterial)].As<MaterialInterface>(); } set { this["LineMaterial"] = value; } }
        public BoxSphereBounds Bounds { get { return this[nameof(Bounds)].As<BoxSphereBounds>(); } set { this["Bounds"] = value; } }
        public bool bBoundsDirty { get { return this[nameof(bBoundsDirty)].Flag; } set { this[nameof(bBoundsDirty)].Flag = value; } }
    }
    public class MeshElementsVisualizerProperties : InteractiveToolPropertySet
    {
        public MeshElementsVisualizerProperties(nint addr) : base(addr) { }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
        public bool bShowBorders { get { return this[nameof(bShowBorders)].Flag; } set { this[nameof(bShowBorders)].Flag = value; } }
        public bool bShowUVSeams { get { return this[nameof(bShowUVSeams)].Flag; } set { this[nameof(bShowUVSeams)].Flag = value; } }
        public bool bShowNormalSeams { get { return this[nameof(bShowNormalSeams)].Flag; } set { this[nameof(bShowNormalSeams)].Flag = value; } }
        public bool bShowColorSeams { get { return this[nameof(bShowColorSeams)].Flag; } set { this[nameof(bShowColorSeams)].Flag = value; } }
        public float ThicknessScale { get { return this[nameof(ThicknessScale)].GetValue<float>(); } set { this[nameof(ThicknessScale)].SetValue<float>(value); } }
        public Color WireframeColor { get { return this[nameof(WireframeColor)].As<Color>(); } set { this["WireframeColor"] = value; } }
        public Color BoundaryEdgeColor { get { return this[nameof(BoundaryEdgeColor)].As<Color>(); } set { this["BoundaryEdgeColor"] = value; } }
        public Color UVSeamColor { get { return this[nameof(UVSeamColor)].As<Color>(); } set { this["UVSeamColor"] = value; } }
        public Color NormalSeamColor { get { return this[nameof(NormalSeamColor)].As<Color>(); } set { this["NormalSeamColor"] = value; } }
        public Color ColorSeamColor { get { return this[nameof(ColorSeamColor)].As<Color>(); } set { this["ColorSeamColor"] = value; } }
        public float DepthBias { get { return this[nameof(DepthBias)].GetValue<float>(); } set { this[nameof(DepthBias)].SetValue<float>(value); } }
        public bool bAdjustDepthBiasUsingMeshSize { get { return this[nameof(bAdjustDepthBiasUsingMeshSize)].Flag; } set { this[nameof(bAdjustDepthBiasUsingMeshSize)].Flag = value; } }
    }
    public class PreviewGeometry : Object
    {
        public PreviewGeometry(nint addr) : base(addr) { }
        public PreviewGeometryActor ParentActor { get { return this[nameof(ParentActor)].As<PreviewGeometryActor>(); } set { this["ParentActor"] = value; } }
        public Object LineSets { get { return this[nameof(LineSets)]; } set { this[nameof(LineSets)] = value; } }
        public Object PointSets { get { return this[nameof(PointSets)]; } set { this[nameof(PointSets)] = value; } }
        public bool SetPointSetVisibility(Object PointSetIdentifier, bool bVisible) { return Invoke<bool>(nameof(SetPointSetVisibility), PointSetIdentifier, bVisible); }
        public bool SetPointSetMaterial(Object PointSetIdentifier, MaterialInterface NewMaterial) { return Invoke<bool>(nameof(SetPointSetMaterial), PointSetIdentifier, NewMaterial); }
        public bool SetLineSetVisibility(Object LineSetIdentifier, bool bVisible) { return Invoke<bool>(nameof(SetLineSetVisibility), LineSetIdentifier, bVisible); }
        public bool SetLineSetMaterial(Object LineSetIdentifier, MaterialInterface NewMaterial) { return Invoke<bool>(nameof(SetLineSetMaterial), LineSetIdentifier, NewMaterial); }
        public void SetAllPointSetsMaterial(MaterialInterface Material) { Invoke(nameof(SetAllPointSetsMaterial), Material); }
        public void SetAllLineSetsMaterial(MaterialInterface Material) { Invoke(nameof(SetAllLineSetsMaterial), Material); }
        public bool RemovePointSet(Object PointSetIdentifier, bool bDestroy) { return Invoke<bool>(nameof(RemovePointSet), PointSetIdentifier, bDestroy); }
        public bool RemoveLineSet(Object LineSetIdentifier, bool bDestroy) { return Invoke<bool>(nameof(RemoveLineSet), LineSetIdentifier, bDestroy); }
        public void RemoveAllPointSets(bool bDestroy) { Invoke(nameof(RemoveAllPointSets), bDestroy); }
        public void RemoveAllLineSets(bool bDestroy) { Invoke(nameof(RemoveAllLineSets), bDestroy); }
        public PreviewGeometryActor GetActor() { return Invoke<PreviewGeometryActor>(nameof(GetActor)); }
        public PointSetComponent FindPointSet(Object PointSetIdentifier) { return Invoke<PointSetComponent>(nameof(FindPointSet), PointSetIdentifier); }
        public LineSetComponent FindLineSet(Object LineSetIdentifier) { return Invoke<LineSetComponent>(nameof(FindLineSet), LineSetIdentifier); }
        public void Disconnect() { Invoke(nameof(Disconnect)); }
        public void CreateInWorld(World World, Transform WithTransform) { Invoke(nameof(CreateInWorld), World, WithTransform); }
        public PointSetComponent AddPointSet(Object PointSetIdentifier) { return Invoke<PointSetComponent>(nameof(AddPointSet), PointSetIdentifier); }
        public LineSetComponent AddLineSet(Object LineSetIdentifier) { return Invoke<LineSetComponent>(nameof(AddLineSet), LineSetIdentifier); }
    }
    public class MeshElementsVisualizer : PreviewGeometry
    {
        public MeshElementsVisualizer(nint addr) : base(addr) { }
        public MeshElementsVisualizerProperties Settings { get { return this[nameof(Settings)].As<MeshElementsVisualizerProperties>(); } set { this["Settings"] = value; } }
        public MeshWireframeComponent WireframeComponent { get { return this[nameof(WireframeComponent)].As<MeshWireframeComponent>(); } set { this["WireframeComponent"] = value; } }
    }
    public class MeshWireframeComponent : MeshComponent
    {
        public MeshWireframeComponent(nint addr) : base(addr) { }
        public float LineDepthBias { get { return this[nameof(LineDepthBias)].GetValue<float>(); } set { this[nameof(LineDepthBias)].SetValue<float>(value); } }
        public float LineDepthBiasSizeScale { get { return this[nameof(LineDepthBiasSizeScale)].GetValue<float>(); } set { this[nameof(LineDepthBiasSizeScale)].SetValue<float>(value); } }
        public float ThicknessScale { get { return this[nameof(ThicknessScale)].GetValue<float>(); } set { this[nameof(ThicknessScale)].SetValue<float>(value); } }
        public bool bEnableWireframe { get { return this[nameof(bEnableWireframe)].Flag; } set { this[nameof(bEnableWireframe)].Flag = value; } }
        public Color WireframeColor { get { return this[nameof(WireframeColor)].As<Color>(); } set { this["WireframeColor"] = value; } }
        public float WireframeThickness { get { return this[nameof(WireframeThickness)].GetValue<float>(); } set { this[nameof(WireframeThickness)].SetValue<float>(value); } }
        public bool bEnableBoundaryEdges { get { return this[nameof(bEnableBoundaryEdges)].Flag; } set { this[nameof(bEnableBoundaryEdges)].Flag = value; } }
        public Color BoundaryEdgeColor { get { return this[nameof(BoundaryEdgeColor)].As<Color>(); } set { this["BoundaryEdgeColor"] = value; } }
        public float BoundaryEdgeThickness { get { return this[nameof(BoundaryEdgeThickness)].GetValue<float>(); } set { this[nameof(BoundaryEdgeThickness)].SetValue<float>(value); } }
        public bool bEnableUVSeams { get { return this[nameof(bEnableUVSeams)].Flag; } set { this[nameof(bEnableUVSeams)].Flag = value; } }
        public Color UVSeamColor { get { return this[nameof(UVSeamColor)].As<Color>(); } set { this["UVSeamColor"] = value; } }
        public float UVSeamThickness { get { return this[nameof(UVSeamThickness)].GetValue<float>(); } set { this[nameof(UVSeamThickness)].SetValue<float>(value); } }
        public bool bEnableNormalSeams { get { return this[nameof(bEnableNormalSeams)].Flag; } set { this[nameof(bEnableNormalSeams)].Flag = value; } }
        public Color NormalSeamColor { get { return this[nameof(NormalSeamColor)].As<Color>(); } set { this["NormalSeamColor"] = value; } }
        public float NormalSeamThickness { get { return this[nameof(NormalSeamThickness)].GetValue<float>(); } set { this[nameof(NormalSeamThickness)].SetValue<float>(value); } }
        public bool bEnableColorSeams { get { return this[nameof(bEnableColorSeams)].Flag; } set { this[nameof(bEnableColorSeams)].Flag = value; } }
        public Color ColorSeamColor { get { return this[nameof(ColorSeamColor)].As<Color>(); } set { this["ColorSeamColor"] = value; } }
        public float ColorSeamThickness { get { return this[nameof(ColorSeamThickness)].GetValue<float>(); } set { this[nameof(ColorSeamThickness)].SetValue<float>(value); } }
        public MaterialInterface LineMaterial { get { return this[nameof(LineMaterial)].As<MaterialInterface>(); } set { this["LineMaterial"] = value; } }
        public BoxSphereBounds LocalBounds { get { return this[nameof(LocalBounds)].As<BoxSphereBounds>(); } set { this["LocalBounds"] = value; } }
    }
    public class PointSetComponent : MeshComponent
    {
        public PointSetComponent(nint addr) : base(addr) { }
        public MaterialInterface PointMaterial { get { return this[nameof(PointMaterial)].As<MaterialInterface>(); } set { this["PointMaterial"] = value; } }
        public BoxSphereBounds Bounds { get { return this[nameof(Bounds)].As<BoxSphereBounds>(); } set { this["Bounds"] = value; } }
        public bool bBoundsDirty { get { return this[nameof(bBoundsDirty)].Flag; } set { this[nameof(bBoundsDirty)].Flag = value; } }
    }
    public class PreviewMesh : Object
    {
        public PreviewMesh(nint addr) : base(addr) { }
        public bool bBuildSpatialDataStructure { get { return this[nameof(bBuildSpatialDataStructure)].Flag; } set { this[nameof(bBuildSpatialDataStructure)].Flag = value; } }
        public DynamicMeshComponent DynamicMeshComponent { get { return this[nameof(DynamicMeshComponent)].As<DynamicMeshComponent>(); } set { this["DynamicMeshComponent"] = value; } }
    }
    public class PolyEditPreviewMesh : PreviewMesh
    {
        public PolyEditPreviewMesh(nint addr) : base(addr) { }
    }
    public class PreviewGeometryActor : InternalToolFrameworkActor
    {
        public PreviewGeometryActor(nint addr) : base(addr) { }
    }
    public class TriangleSetComponent : MeshComponent
    {
        public TriangleSetComponent(nint addr) : base(addr) { }
        public BoxSphereBounds Bounds { get { return this[nameof(Bounds)].As<BoxSphereBounds>(); } set { this["Bounds"] = value; } }
        public bool bBoundsDirty { get { return this[nameof(bBoundsDirty)].Flag; } set { this[nameof(bBoundsDirty)].Flag = value; } }
    }
    public class UVLayoutPreviewProperties : InteractiveToolPropertySet
    {
        public UVLayoutPreviewProperties(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public EUVLayoutPreviewSide Side { get { return (EUVLayoutPreviewSide)this[nameof(Side)].GetValue<int>(); } set { this[nameof(Side)].SetValue<int>((int)value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public Vector2D Offset { get { return this[nameof(Offset)].As<Vector2D>(); } set { this["Offset"] = value; } }
        public bool bShowWireframe { get { return this[nameof(bShowWireframe)].Flag; } set { this[nameof(bShowWireframe)].Flag = value; } }
    }
    public class UVLayoutPreview : Object
    {
        public UVLayoutPreview(nint addr) : base(addr) { }
        public UVLayoutPreviewProperties Settings { get { return this[nameof(Settings)].As<UVLayoutPreviewProperties>(); } set { this["Settings"] = value; } }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public TriangleSetComponent TriangleComponent { get { return this[nameof(TriangleComponent)].As<TriangleSetComponent>(); } set { this["TriangleComponent"] = value; } }
        public bool bShowBackingRectangle { get { return this[nameof(bShowBackingRectangle)].Flag; } set { this[nameof(bShowBackingRectangle)].Flag = value; } }
        public MaterialInterface BackingRectangleMaterial { get { return this[nameof(BackingRectangleMaterial)].As<MaterialInterface>(); } set { this["BackingRectangleMaterial"] = value; } }
    }
    public class CollectSurfacePathMechanic : InteractionMechanic
    {
        public CollectSurfacePathMechanic(nint addr) : base(addr) { }
    }
    public class ConstructionPlaneMechanic : InteractionMechanic
    {
        public ConstructionPlaneMechanic(nint addr) : base(addr) { }
        public CombinedTransformGizmo PlaneTransformGizmo { get { return this[nameof(PlaneTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PlaneTransformGizmo"] = value; } }
        public TransformProxy PlaneTransformProxy { get { return this[nameof(PlaneTransformProxy)].As<TransformProxy>(); } set { this["PlaneTransformProxy"] = value; } }
        public SingleClickInputBehavior ClickToSetPlaneBehavior { get { return this[nameof(ClickToSetPlaneBehavior)].As<SingleClickInputBehavior>(); } set { this["ClickToSetPlaneBehavior"] = value; } }
    }
    public class CurveControlPointsMechanic : InteractionMechanic
    {
        public CurveControlPointsMechanic(nint addr) : base(addr) { }
        public SingleClickInputBehavior ClickBehavior { get { return this[nameof(ClickBehavior)].As<SingleClickInputBehavior>(); } set { this["ClickBehavior"] = value; } }
        public MouseHoverBehavior HoverBehavior { get { return this[nameof(HoverBehavior)].As<MouseHoverBehavior>(); } set { this["HoverBehavior"] = value; } }
        public PreviewGeometryActor PreviewGeometryActor { get { return this[nameof(PreviewGeometryActor)].As<PreviewGeometryActor>(); } set { this["PreviewGeometryActor"] = value; } }
        public PointSetComponent DrawnControlPoints { get { return this[nameof(DrawnControlPoints)].As<PointSetComponent>(); } set { this["DrawnControlPoints"] = value; } }
        public LineSetComponent DrawnControlSegments { get { return this[nameof(DrawnControlSegments)].As<LineSetComponent>(); } set { this["DrawnControlSegments"] = value; } }
        public PointSetComponent PreviewPoint { get { return this[nameof(PreviewPoint)].As<PointSetComponent>(); } set { this["PreviewPoint"] = value; } }
        public LineSetComponent PreviewSegment { get { return this[nameof(PreviewSegment)].As<LineSetComponent>(); } set { this["PreviewSegment"] = value; } }
        public TransformProxy PointTransformProxy { get { return this[nameof(PointTransformProxy)].As<TransformProxy>(); } set { this["PointTransformProxy"] = value; } }
        public CombinedTransformGizmo PointTransformGizmo { get { return this[nameof(PointTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PointTransformGizmo"] = value; } }
    }
    public class DragAlignmentMechanic : InteractionMechanic
    {
        public DragAlignmentMechanic(nint addr) : base(addr) { }
    }
    public class LatticeControlPointsMechanic : InteractionMechanic
    {
        public LatticeControlPointsMechanic(nint addr) : base(addr) { }
        public PreviewGeometryActor PreviewGeometryActor { get { return this[nameof(PreviewGeometryActor)].As<PreviewGeometryActor>(); } set { this["PreviewGeometryActor"] = value; } }
        public PointSetComponent DrawnControlPoints { get { return this[nameof(DrawnControlPoints)].As<PointSetComponent>(); } set { this["DrawnControlPoints"] = value; } }
        public LineSetComponent DrawnLatticeEdges { get { return this[nameof(DrawnLatticeEdges)].As<LineSetComponent>(); } set { this["DrawnLatticeEdges"] = value; } }
        public TransformProxy PointTransformProxy { get { return this[nameof(PointTransformProxy)].As<TransformProxy>(); } set { this["PointTransformProxy"] = value; } }
        public CombinedTransformGizmo PointTransformGizmo { get { return this[nameof(PointTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PointTransformGizmo"] = value; } }
        public RectangleMarqueeMechanic MarqueeMechanic { get { return this[nameof(MarqueeMechanic)].As<RectangleMarqueeMechanic>(); } set { this["MarqueeMechanic"] = value; } }
    }
    public class PlaneDistanceFromHitMechanic : InteractionMechanic
    {
        public PlaneDistanceFromHitMechanic(nint addr) : base(addr) { }
    }
    public class PolyLassoMarqueeMechanic : InteractionMechanic
    {
        public PolyLassoMarqueeMechanic(nint addr) : base(addr) { }
        public float SpacingTolerance { get { return this[nameof(SpacingTolerance)].GetValue<float>(); } set { this[nameof(SpacingTolerance)].SetValue<float>(value); } }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public LinearColor LineColor { get { return this[nameof(LineColor)].As<LinearColor>(); } set { this["LineColor"] = value; } }
        public LinearColor ClosedColor { get { return this[nameof(ClosedColor)].As<LinearColor>(); } set { this["ClosedColor"] = value; } }
        public bool bEnableFreehandPolygons { get { return this[nameof(bEnableFreehandPolygons)].Flag; } set { this[nameof(bEnableFreehandPolygons)].Flag = value; } }
        public bool bEnableMultiClickPolygons { get { return this[nameof(bEnableMultiClickPolygons)].Flag; } set { this[nameof(bEnableMultiClickPolygons)].Flag = value; } }
        public ClickDragInputBehavior ClickDragBehavior { get { return this[nameof(ClickDragBehavior)].As<ClickDragInputBehavior>(); } set { this["ClickDragBehavior"] = value; } }
        public MouseHoverBehavior HoverBehavior { get { return this[nameof(HoverBehavior)].As<MouseHoverBehavior>(); } set { this["HoverBehavior"] = value; } }
    }
    public class RectangleMarqueeMechanic : InteractionMechanic
    {
        public RectangleMarqueeMechanic(nint addr) : base(addr) { }
        public bool bUseExternalClickDragBehavior { get { return this[nameof(bUseExternalClickDragBehavior)].Flag; } set { this[nameof(bUseExternalClickDragBehavior)].Flag = value; } }
        public bool bUseExternalUpdateCameraState { get { return this[nameof(bUseExternalUpdateCameraState)].Flag; } set { this[nameof(bUseExternalUpdateCameraState)].Flag = value; } }
        public double OnDragRectangleChangedDeferredThreshold { get { return this[nameof(OnDragRectangleChangedDeferredThreshold)].GetValue<double>(); } set { this[nameof(OnDragRectangleChangedDeferredThreshold)].SetValue<double>(value); } }
        public ClickDragInputBehavior ClickDragBehavior { get { return this[nameof(ClickDragBehavior)].As<ClickDragInputBehavior>(); } set { this["ClickDragBehavior"] = value; } }
    }
    public class SpaceCurveDeformationMechanicPropertySet : InteractiveToolPropertySet
    {
        public SpaceCurveDeformationMechanicPropertySet(nint addr) : base(addr) { }
        public ESpaceCurveControlPointTransformMode TransformMode { get { return (ESpaceCurveControlPointTransformMode)this[nameof(TransformMode)].GetValue<int>(); } set { this[nameof(TransformMode)].SetValue<int>((int)value); } }
        public ESpaceCurveControlPointOriginMode TransformOrigin { get { return (ESpaceCurveControlPointOriginMode)this[nameof(TransformOrigin)].GetValue<int>(); } set { this[nameof(TransformOrigin)].SetValue<int>((int)value); } }
        public float Softness { get { return this[nameof(Softness)].GetValue<float>(); } set { this[nameof(Softness)].SetValue<float>(value); } }
        public ESpaceCurveControlPointFalloffType SoftFalloff { get { return (ESpaceCurveControlPointFalloffType)this[nameof(SoftFalloff)].GetValue<int>(); } set { this[nameof(SoftFalloff)].SetValue<int>((int)value); } }
    }
    public class SpaceCurveDeformationMechanic : InteractionMechanic
    {
        public SpaceCurveDeformationMechanic(nint addr) : base(addr) { }
        public SingleClickInputBehavior ClickBehavior { get { return this[nameof(ClickBehavior)].As<SingleClickInputBehavior>(); } set { this["ClickBehavior"] = value; } }
        public MouseHoverBehavior HoverBehavior { get { return this[nameof(HoverBehavior)].As<MouseHoverBehavior>(); } set { this["HoverBehavior"] = value; } }
        public SpaceCurveDeformationMechanicPropertySet TransformProperties { get { return this[nameof(TransformProperties)].As<SpaceCurveDeformationMechanicPropertySet>(); } set { this["TransformProperties"] = value; } }
        public PreviewGeometryActor PreviewGeometryActor { get { return this[nameof(PreviewGeometryActor)].As<PreviewGeometryActor>(); } set { this["PreviewGeometryActor"] = value; } }
        public PointSetComponent RenderPoints { get { return this[nameof(RenderPoints)].As<PointSetComponent>(); } set { this["RenderPoints"] = value; } }
        public LineSetComponent RenderSegments { get { return this[nameof(RenderSegments)].As<LineSetComponent>(); } set { this["RenderSegments"] = value; } }
        public TransformProxy PointTransformProxy { get { return this[nameof(PointTransformProxy)].As<TransformProxy>(); } set { this["PointTransformProxy"] = value; } }
        public CombinedTransformGizmo PointTransformGizmo { get { return this[nameof(PointTransformGizmo)].As<CombinedTransformGizmo>(); } set { this["PointTransformGizmo"] = value; } }
    }
    public class SpatialCurveDistanceMechanic : InteractionMechanic
    {
        public SpatialCurveDistanceMechanic(nint addr) : base(addr) { }
    }
    public class MeshOpPreviewWithBackgroundCompute : Object
    {
        public MeshOpPreviewWithBackgroundCompute(nint addr) : base(addr) { }
        public PreviewMesh PreviewMesh { get { return this[nameof(PreviewMesh)].As<PreviewMesh>(); } set { this["PreviewMesh"] = value; } }
        public Array<MaterialInterface> StandardMaterials { get { return new Array<MaterialInterface>(this[nameof(StandardMaterials)].Address); } }
        public MaterialInterface OverrideMaterial { get { return this[nameof(OverrideMaterial)].As<MaterialInterface>(); } set { this["OverrideMaterial"] = value; } }
        public MaterialInterface WorkingMaterial { get { return this[nameof(WorkingMaterial)].As<MaterialInterface>(); } set { this["WorkingMaterial"] = value; } }
        public MaterialInterface SecondaryMaterial { get { return this[nameof(SecondaryMaterial)].As<MaterialInterface>(); } set { this["SecondaryMaterial"] = value; } }
        public Object PreviewWorld { get { return this[nameof(PreviewWorld)]; } set { this[nameof(PreviewWorld)] = value; } }
    }
    public class ModelingComponentsSettings : DeveloperSettings
    {
        public ModelingComponentsSettings(nint addr) : base(addr) { }
        public bool bEnableRayTracingWhileEditing { get { return this[nameof(bEnableRayTracingWhileEditing)].Flag; } set { this[nameof(bEnableRayTracingWhileEditing)].Flag = value; } }
        public bool bEnableRayTracing { get { return this[nameof(bEnableRayTracing)].Flag; } set { this[nameof(bEnableRayTracing)].Flag = value; } }
        public bool bEnableCollision { get { return this[nameof(bEnableCollision)].Flag; } set { this[nameof(bEnableCollision)].Flag = value; } }
        public byte CollisionMode { get { return this[nameof(CollisionMode)].GetValue<byte>(); } set { this[nameof(CollisionMode)].SetValue<byte>(value); } }
    }
    public class ModelingObjectsCreationAPI : Object
    {
        public ModelingObjectsCreationAPI(nint addr) : base(addr) { }
        public CreateTextureObjectResult CreateTextureObject(CreateTextureObjectParams CreateTexParams) { return Invoke<CreateTextureObjectResult>(nameof(CreateTextureObject), CreateTexParams); }
        public CreateMeshObjectResult CreateMeshObject(CreateMeshObjectParams CreateMeshParams) { return Invoke<CreateMeshObjectResult>(nameof(CreateMeshObject), CreateMeshParams); }
    }
    public class PreviewMeshActor : InternalToolFrameworkActor
    {
        public PreviewMeshActor(nint addr) : base(addr) { }
    }
    public class CreateMeshObjectTypeProperties : InteractiveToolPropertySet
    {
        public CreateMeshObjectTypeProperties(nint addr) : base(addr) { }
        public Object OutputType { get { return this[nameof(OutputType)]; } set { this[nameof(OutputType)] = value; } }
        public Object VolumeType { get { return this[nameof(VolumeType)]; } set { this[nameof(VolumeType)] = value; } }
        public Array<Object> OutputTypeNamesList { get { return new Array<Object>(this[nameof(OutputTypeNamesList)].Address); } }
        public bool bShowVolumeList { get { return this[nameof(bShowVolumeList)].Flag; } set { this[nameof(bShowVolumeList)].Flag = value; } }
        public bool ShouldShowPropertySet() { return Invoke<bool>(nameof(ShouldShowPropertySet)); }
        public Array<Object> GetOutputTypeNamesFunc() { return Invoke<Array<Object>>(nameof(GetOutputTypeNamesFunc)); }
        public ECreateObjectTypeHint GetCurrentCreateMeshType() { return Invoke<ECreateObjectTypeHint>(nameof(GetCurrentCreateMeshType)); }
    }
    public class OnAcceptHandleSourcesPropertiesSingle : OnAcceptHandleSourcesPropertiesBase
    {
        public OnAcceptHandleSourcesPropertiesSingle(nint addr) : base(addr) { }
        public EHandleSourcesMethod HandleInputs { get { return (EHandleSourcesMethod)this[nameof(HandleInputs)].GetValue<int>(); } set { this[nameof(HandleInputs)].SetValue<int>((int)value); } }
    }
    public class PolygroupLayersProperties : InteractiveToolPropertySet
    {
        public PolygroupLayersProperties(nint addr) : base(addr) { }
        public Object ActiveGroupLayer { get { return this[nameof(ActiveGroupLayer)]; } set { this[nameof(ActiveGroupLayer)] = value; } }
        public Array<Object> GroupLayersList { get { return new Array<Object>(this[nameof(GroupLayersList)].Address); } }
        public Array<Object> GetGroupLayersFunc() { return Invoke<Array<Object>>(nameof(GetGroupLayersFunc)); }
    }
    public class PersistentMeshSelection : Object
    {
        public PersistentMeshSelection(nint addr) : base(addr) { }
    }
    public class PersistentMeshSelectionManager : Object
    {
        public PersistentMeshSelectionManager(nint addr) : base(addr) { }
        public InteractiveToolsContext ParentContext { get { return this[nameof(ParentContext)].As<InteractiveToolsContext>(); } set { this["ParentContext"] = value; } }
        public PersistentMeshSelection ActiveSelection { get { return this[nameof(ActiveSelection)].As<PersistentMeshSelection>(); } set { this["ActiveSelection"] = value; } }
        public PreviewGeometry SelectionDisplay { get { return this[nameof(SelectionDisplay)].As<PreviewGeometry>(); } set { this["SelectionDisplay"] = value; } }
    }
    public class PolygonSelectionMechanicProperties : InteractiveToolPropertySet
    {
        public PolygonSelectionMechanicProperties(nint addr) : base(addr) { }
        public bool bSelectVertices { get { return this[nameof(bSelectVertices)].Flag; } set { this[nameof(bSelectVertices)].Flag = value; } }
        public bool bSelectEdges { get { return this[nameof(bSelectEdges)].Flag; } set { this[nameof(bSelectEdges)].Flag = value; } }
        public bool bSelectFaces { get { return this[nameof(bSelectFaces)].Flag; } set { this[nameof(bSelectFaces)].Flag = value; } }
        public bool bSelectEdgeLoops { get { return this[nameof(bSelectEdgeLoops)].Flag; } set { this[nameof(bSelectEdgeLoops)].Flag = value; } }
        public bool bSelectEdgeRings { get { return this[nameof(bSelectEdgeRings)].Flag; } set { this[nameof(bSelectEdgeRings)].Flag = value; } }
        public bool bHitBackFaces { get { return this[nameof(bHitBackFaces)].Flag; } set { this[nameof(bHitBackFaces)].Flag = value; } }
        public bool bEnableMarquee { get { return this[nameof(bEnableMarquee)].Flag; } set { this[nameof(bEnableMarquee)].Flag = value; } }
        public bool bMarqueeIgnoreOcclusion { get { return this[nameof(bMarqueeIgnoreOcclusion)].Flag; } set { this[nameof(bMarqueeIgnoreOcclusion)].Flag = value; } }
        public bool bPreferProjectedElement { get { return this[nameof(bPreferProjectedElement)].Flag; } set { this[nameof(bPreferProjectedElement)].Flag = value; } }
        public bool bSelectDownRay { get { return this[nameof(bSelectDownRay)].Flag; } set { this[nameof(bSelectDownRay)].Flag = value; } }
        public bool bIgnoreOcclusion { get { return this[nameof(bIgnoreOcclusion)].Flag; } set { this[nameof(bIgnoreOcclusion)].Flag = value; } }
        public void SelectAll() { Invoke(nameof(SelectAll)); }
        public void InvertSelection() { Invoke(nameof(InvertSelection)); }
    }
    public class PolygonSelectionMechanic : InteractionMechanic
    {
        public PolygonSelectionMechanic(nint addr) : base(addr) { }
        public PolygonSelectionMechanicProperties Properties { get { return this[nameof(Properties)].As<PolygonSelectionMechanicProperties>(); } set { this["Properties"] = value; } }
        public MouseHoverBehavior HoverBehavior { get { return this[nameof(HoverBehavior)].As<MouseHoverBehavior>(); } set { this["HoverBehavior"] = value; } }
        public SingleClickOrDragInputBehavior ClickOrDragBehavior { get { return this[nameof(ClickOrDragBehavior)].As<SingleClickOrDragInputBehavior>(); } set { this["ClickOrDragBehavior"] = value; } }
        public RectangleMarqueeMechanic MarqueeMechanic { get { return this[nameof(MarqueeMechanic)].As<RectangleMarqueeMechanic>(); } set { this["MarqueeMechanic"] = value; } }
        public PreviewGeometryActor PreviewGeometryActor { get { return this[nameof(PreviewGeometryActor)].As<PreviewGeometryActor>(); } set { this["PreviewGeometryActor"] = value; } }
        public TriangleSetComponent DrawnTriangleSetComponent { get { return this[nameof(DrawnTriangleSetComponent)].As<TriangleSetComponent>(); } set { this["DrawnTriangleSetComponent"] = value; } }
        public MaterialInterface HighlightedFaceMaterial { get { return this[nameof(HighlightedFaceMaterial)].As<MaterialInterface>(); } set { this["HighlightedFaceMaterial"] = value; } }
    }
    public class ModelingSceneSnappingManager : SceneSnappingManager
    {
        public ModelingSceneSnappingManager(nint addr) : base(addr) { }
        public InteractiveToolsContext ParentContext { get { return this[nameof(ParentContext)].As<InteractiveToolsContext>(); } set { this["ParentContext"] = value; } }
    }
    public class MultiTransformer : Object
    {
        public MultiTransformer(nint addr) : base(addr) { }
        public InteractiveGizmoManager GizmoManager { get { return this[nameof(GizmoManager)].As<InteractiveGizmoManager>(); } set { this["GizmoManager"] = value; } }
        public CombinedTransformGizmo TransformGizmo { get { return this[nameof(TransformGizmo)].As<CombinedTransformGizmo>(); } set { this["TransformGizmo"] = value; } }
        public TransformProxy TransformProxy { get { return this[nameof(TransformProxy)].As<TransformProxy>(); } set { this["TransformProxy"] = value; } }
        public DragAlignmentMechanic DragAlignmentMechanic { get { return this[nameof(DragAlignmentMechanic)].As<DragAlignmentMechanic>(); } set { this["DragAlignmentMechanic"] = value; } }
    }
    public enum EBaseCreateFromSelectedTargetType : int
    {
        NewObject = 0,
        FirstInputObject = 1,
        LastInputObject = 2,
        EBaseCreateFromSelectedTargetType_MAX = 3,
    }
    public enum EUVLayoutPreviewSide : int
    {
        Left = 0,
        Right = 1,
        EUVLayoutPreviewSide_MAX = 2,
    }
    public enum ESpaceCurveControlPointTransformMode : int
    {
        Shared = 0,
        PerVertex = 1,
        ESpaceCurveControlPointTransformMode_MAX = 2,
    }
    public enum ESpaceCurveControlPointOriginMode : int
    {
        Shared = 0,
        First = 1,
        Last = 2,
        ESpaceCurveControlPointOriginMode_MAX = 3,
    }
    public enum ESpaceCurveControlPointFalloffType : int
    {
        Linear = 0,
        Smooth = 1,
        ESpaceCurveControlPointFalloffType_MAX = 2,
    }
    public enum ECreateModelingObjectResult : int
    {
        Ok = 0,
        Cancelled = 1,
        Failed_Unknown = 2,
        Failed_NoAPIFound = 3,
        Failed_InvalidWorld = 4,
        Failed_InvalidMesh = 5,
        Failed_InvalidTexture = 6,
        Failed_AssetCreationFailed = 7,
        Failed_ActorCreationFailed = 8,
        ECreateModelingObjectResult_MAX = 9,
    }
    public enum ECreateMeshObjectSourceMeshType : int
    {
        MeshDescription = 0,
        DynamicMesh = 1,
        ECreateMeshObjectSourceMeshType_MAX = 2,
    }
    public enum ECreateObjectTypeHint : int
    {
        Undefined = 0,
        StaticMesh = 1,
        Volume = 2,
        DynamicMeshActor = 3,
        ECreateObjectTypeHint_MAX = 4,
    }
    public enum EHandleSourcesMethod : int
    {
        DeleteSources = 0,
        HideSources = 1,
        KeepSources = 2,
        KeepFirstSource = 3,
        KeepLastSource = 4,
        EHandleSourcesMethod_MAX = 5,
    }
    public enum EMultiTransformerMode : int
    {
        DefaultGizmo = 1,
        QuickAxisTranslation = 2,
        EMultiTransformerMode_MAX = 3,
    }
    public class ModelingToolsAxisFilter : Object
    {
        public ModelingToolsAxisFilter(nint addr) : base(addr) { }
        public bool bAxisX { get { return this[nameof(bAxisX)].Flag; } set { this[nameof(bAxisX)].Flag = value; } }
        public bool bAxisY { get { return this[nameof(bAxisY)].Flag; } set { this[nameof(bAxisY)].Flag = value; } }
        public bool bAxisZ { get { return this[nameof(bAxisZ)].Flag; } set { this[nameof(bAxisZ)].Flag = value; } }
    }
    public class RenderableTriangleVertex : Object
    {
        public RenderableTriangleVertex(nint addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector2D UV { get { return this[nameof(UV)].As<Vector2D>(); } set { this["UV"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
    }
    public class RenderableTriangle : Object
    {
        public RenderableTriangle(nint addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public RenderableTriangleVertex Vertex0 { get { return this[nameof(Vertex0)].As<RenderableTriangleVertex>(); } set { this["Vertex0"] = value; } }
        public RenderableTriangleVertex Vertex1 { get { return this[nameof(Vertex1)].As<RenderableTriangleVertex>(); } set { this["Vertex1"] = value; } }
        public RenderableTriangleVertex Vertex2 { get { return this[nameof(Vertex2)].As<RenderableTriangleVertex>(); } set { this["Vertex2"] = value; } }
    }
    public class CreateMeshObjectParams : Object
    {
        public CreateMeshObjectParams(nint addr) : base(addr) { }
        public PrimitiveComponent SourceComponent { get { return this[nameof(SourceComponent)].As<PrimitiveComponent>(); } set { this["SourceComponent"] = value; } }
        public ECreateObjectTypeHint TypeHint { get { return (ECreateObjectTypeHint)this[nameof(TypeHint)].GetValue<int>(); } set { this[nameof(TypeHint)].SetValue<int>((int)value); } }
        public Object TypeHintClass { get { return this[nameof(TypeHintClass)].As<Object>(); } set { this["TypeHintClass"] = value; } } // ClassPtrProperty
        public int TypeHintExtended { get { return this[nameof(TypeHintExtended)].GetValue<int>(); } set { this[nameof(TypeHintExtended)].SetValue<int>(value); } }
        public World TargetWorld { get { return this[nameof(TargetWorld)].As<World>(); } set { this["TargetWorld"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Object BaseName { get { return this[nameof(BaseName)]; } set { this[nameof(BaseName)] = value; } }
        public Array<MaterialInterface> Materials { get { return new Array<MaterialInterface>(this[nameof(Materials)].Address); } }
        public Array<MaterialInterface> AssetMaterials { get { return new Array<MaterialInterface>(this[nameof(AssetMaterials)].Address); } }
        public bool bEnableCollision { get { return this[nameof(bEnableCollision)].Flag; } set { this[nameof(bEnableCollision)].Flag = value; } }
        public byte CollisionMode { get { return this[nameof(CollisionMode)].GetValue<byte>(); } set { this[nameof(CollisionMode)].SetValue<byte>(value); } }
        public bool bEnableRaytracingSupport { get { return this[nameof(bEnableRaytracingSupport)].Flag; } set { this[nameof(bEnableRaytracingSupport)].Flag = value; } }
        public bool bEnableRecomputeNormals { get { return this[nameof(bEnableRecomputeNormals)].Flag; } set { this[nameof(bEnableRecomputeNormals)].Flag = value; } }
        public bool bEnableRecomputeTangents { get { return this[nameof(bEnableRecomputeTangents)].Flag; } set { this[nameof(bEnableRecomputeTangents)].Flag = value; } }
        public bool bEnableNanite { get { return this[nameof(bEnableNanite)].Flag; } set { this[nameof(bEnableNanite)].Flag = value; } }
        public float NaniteProxyTrianglePercent { get { return this[nameof(NaniteProxyTrianglePercent)].GetValue<float>(); } set { this[nameof(NaniteProxyTrianglePercent)].SetValue<float>(value); } }
        public MeshNaniteSettings NaniteSettings { get { return this[nameof(NaniteSettings)].As<MeshNaniteSettings>(); } set { this["NaniteSettings"] = value; } }
    }
    public class CreateMeshObjectResult : Object
    {
        public CreateMeshObjectResult(nint addr) : base(addr) { }
        public ECreateModelingObjectResult ResultCode { get { return (ECreateModelingObjectResult)this[nameof(ResultCode)].GetValue<int>(); } set { this[nameof(ResultCode)].SetValue<int>((int)value); } }
        public Actor NewActor { get { return this[nameof(NewActor)].As<Actor>(); } set { this["NewActor"] = value; } }
        public PrimitiveComponent NewComponent { get { return this[nameof(NewComponent)].As<PrimitiveComponent>(); } set { this["NewComponent"] = value; } }
        public Object NewAsset { get { return this[nameof(NewAsset)].As<Object>(); } set { this["NewAsset"] = value; } }
    }
    public class CreateTextureObjectParams : Object
    {
        public CreateTextureObjectParams(nint addr) : base(addr) { }
        public int TypeHintExtended { get { return this[nameof(TypeHintExtended)].GetValue<int>(); } set { this[nameof(TypeHintExtended)].SetValue<int>(value); } }
        public World TargetWorld { get { return this[nameof(TargetWorld)].As<World>(); } set { this["TargetWorld"] = value; } }
        public Object StoreRelativeToObject { get { return this[nameof(StoreRelativeToObject)].As<Object>(); } set { this["StoreRelativeToObject"] = value; } }
        public Object BaseName { get { return this[nameof(BaseName)]; } set { this[nameof(BaseName)] = value; } }
        public Texture2D GeneratedTransientTexture { get { return this[nameof(GeneratedTransientTexture)].As<Texture2D>(); } set { this["GeneratedTransientTexture"] = value; } }
    }
    public class CreateTextureObjectResult : Object
    {
        public CreateTextureObjectResult(nint addr) : base(addr) { }
        public ECreateModelingObjectResult ResultCode { get { return (ECreateModelingObjectResult)this[nameof(ResultCode)].GetValue<int>(); } set { this[nameof(ResultCode)].SetValue<int>((int)value); } }
        public Object NewAsset { get { return this[nameof(NewAsset)].As<Object>(); } set { this["NewAsset"] = value; } }
    }
}
