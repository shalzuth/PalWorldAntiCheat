using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ProceduralMeshComponentSDK
{
    public class ProceduralMeshComponent : MeshComponent
    {
        public ProceduralMeshComponent(nint addr) : base(addr) { }
        public bool bUseComplexAsSimpleCollision { get { return this[nameof(bUseComplexAsSimpleCollision)].Flag; } set { this[nameof(bUseComplexAsSimpleCollision)].Flag = value; } }
        public bool bUseAsyncCooking { get { return this[nameof(bUseAsyncCooking)].Flag; } set { this[nameof(bUseAsyncCooking)].Flag = value; } }
        public BodySetup ProcMeshBodySetup { get { return this[nameof(ProcMeshBodySetup)].As<BodySetup>(); } set { this["ProcMeshBodySetup"] = value; } }
        public Array<ProcMeshSection> ProcMeshSections { get { return new Array<ProcMeshSection>(this[nameof(ProcMeshSections)].Address); } }
        public Array<KConvexElem> CollisionConvexElems { get { return new Array<KConvexElem>(this[nameof(CollisionConvexElems)].Address); } }
        public BoxSphereBounds LocalBounds { get { return this[nameof(LocalBounds)].As<BoxSphereBounds>(); } set { this["LocalBounds"] = value; } }
        public Array<BodySetup> AsyncBodySetupQueue { get { return new Array<BodySetup>(this[nameof(AsyncBodySetupQueue)].Address); } }
        public void UpdateMeshSection_LinearColor(int SectionIndex, Array<Vector> Vertices, Array<Vector> normals, Array<Vector2D> UV0, Array<Vector2D> UV1, Array<Vector2D> UV2, Array<Vector2D> UV3, Array<LinearColor> VertexColors, Array<ProcMeshTangent> Tangents, bool bSRGBConversion) { Invoke(nameof(UpdateMeshSection_LinearColor), SectionIndex, Vertices, normals, UV0, UV1, UV2, UV3, VertexColors, Tangents, bSRGBConversion); }
        public void UpdateMeshSection(int SectionIndex, Array<Vector> Vertices, Array<Vector> normals, Array<Vector2D> UV0, Array<Color> VertexColors, Array<ProcMeshTangent> Tangents) { Invoke(nameof(UpdateMeshSection), SectionIndex, Vertices, normals, UV0, VertexColors, Tangents); }
        public void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility) { Invoke(nameof(SetMeshSectionVisible), SectionIndex, bNewVisibility); }
        public bool IsMeshSectionVisible(int SectionIndex) { return Invoke<bool>(nameof(IsMeshSectionVisible), SectionIndex); }
        public int GetNumSections() { return Invoke<int>(nameof(GetNumSections)); }
        public void CreateMeshSection_LinearColor(int SectionIndex, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<Vector2D> UV0, Array<Vector2D> UV1, Array<Vector2D> UV2, Array<Vector2D> UV3, Array<LinearColor> VertexColors, Array<ProcMeshTangent> Tangents, bool bCreateCollision, bool bSRGBConversion) { Invoke(nameof(CreateMeshSection_LinearColor), SectionIndex, Vertices, Triangles, normals, UV0, UV1, UV2, UV3, VertexColors, Tangents, bCreateCollision, bSRGBConversion); }
        public void CreateMeshSection(int SectionIndex, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<Vector2D> UV0, Array<Color> VertexColors, Array<ProcMeshTangent> Tangents, bool bCreateCollision) { Invoke(nameof(CreateMeshSection), SectionIndex, Vertices, Triangles, normals, UV0, VertexColors, Tangents, bCreateCollision); }
        public void ClearMeshSection(int SectionIndex) { Invoke(nameof(ClearMeshSection), SectionIndex); }
        public void ClearCollisionConvexMeshes() { Invoke(nameof(ClearCollisionConvexMeshes)); }
        public void ClearAllMeshSections() { Invoke(nameof(ClearAllMeshSections)); }
        public void AddCollisionConvexMesh(Array<Vector> ConvexVerts) { Invoke(nameof(AddCollisionConvexMesh), ConvexVerts); }
    }
    public class KismetProceduralMeshLibrary : BlueprintFunctionLibrary
    {
        public KismetProceduralMeshLibrary(nint addr) : base(addr) { }
        public void SliceProceduralMesh(ProceduralMeshComponent InProcMesh, Vector PlanePosition, Vector PlaneNormal, bool bCreateOtherHalf, ProceduralMeshComponent OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, MaterialInterface CapMaterial) { Invoke(nameof(SliceProceduralMesh), InProcMesh, PlanePosition, PlaneNormal, bCreateOtherHalf, OutOtherHalfProcMesh, CapOption, CapMaterial); }
        public void GetSectionFromStaticMesh(StaticMesh InMesh, int LODIndex, int SectionIndex, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<Vector2D> UVs, Array<ProcMeshTangent> Tangents) { Invoke(nameof(GetSectionFromStaticMesh), InMesh, LODIndex, SectionIndex, Vertices, Triangles, normals, UVs, Tangents); }
        public void GetSectionFromProceduralMesh(ProceduralMeshComponent InProcMesh, int SectionIndex, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<Vector2D> UVs, Array<ProcMeshTangent> Tangents) { Invoke(nameof(GetSectionFromProceduralMesh), InProcMesh, SectionIndex, Vertices, Triangles, normals, UVs, Tangents); }
        public void GenerateBoxMesh(Vector BoxRadius, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> normals, Array<Vector2D> UVs, Array<ProcMeshTangent> Tangents) { Invoke(nameof(GenerateBoxMesh), BoxRadius, Vertices, Triangles, normals, UVs, Tangents); }
        public void CreateGridMeshWelded(int NumX, int NumY, Array<int> Triangles, Array<Vector> Vertices, Array<Vector2D> UVs, float GridSpacing) { Invoke(nameof(CreateGridMeshWelded), NumX, NumY, Triangles, Vertices, UVs, GridSpacing); }
        public void CreateGridMeshTriangles(int NumX, int NumY, bool bWinding, Array<int> Triangles) { Invoke(nameof(CreateGridMeshTriangles), NumX, NumY, bWinding, Triangles); }
        public void CreateGridMeshSplit(int NumX, int NumY, Array<int> Triangles, Array<Vector> Vertices, Array<Vector2D> UVs, Array<Vector2D> UV1s, float GridSpacing) { Invoke(nameof(CreateGridMeshSplit), NumX, NumY, Triangles, Vertices, UVs, UV1s, GridSpacing); }
        public void CopyProceduralMeshFromStaticMeshComponent(StaticMeshComponent StaticMeshComponent, int LODIndex, ProceduralMeshComponent ProcMeshComponent, bool bCreateCollision) { Invoke(nameof(CopyProceduralMeshFromStaticMeshComponent), StaticMeshComponent, LODIndex, ProcMeshComponent, bCreateCollision); }
        public void ConvertQuadToTriangles(Array<int> Triangles, int Vert0, int Vert1, int Vert2, int Vert3) { Invoke(nameof(ConvertQuadToTriangles), Triangles, Vert0, Vert1, Vert2, Vert3); }
        public void CalculateTangentsForMesh(Array<Vector> Vertices, Array<int> Triangles, Array<Vector2D> UVs, Array<Vector> normals, Array<ProcMeshTangent> Tangents) { Invoke(nameof(CalculateTangentsForMesh), Vertices, Triangles, UVs, normals, Tangents); }
    }
    public enum EProcMeshSliceCapOption : int
    {
        NoCap = 0,
        CreateNewSectionForCap = 1,
        UseLastSectionForCap = 2,
        EProcMeshSliceCapOption_MAX = 3,
    }
    public class ProcMeshTangent : Object
    {
        public ProcMeshTangent(nint addr) : base(addr) { }
        public Vector TangentX { get { return this[nameof(TangentX)].As<Vector>(); } set { this["TangentX"] = value; } }
        public bool bFlipTangentY { get { return this[nameof(bFlipTangentY)].Flag; } set { this[nameof(bFlipTangentY)].Flag = value; } }
    }
    public class ProcMeshVertex : Object
    {
        public ProcMeshVertex(nint addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public ProcMeshTangent Tangent { get { return this[nameof(Tangent)].As<ProcMeshTangent>(); } set { this["Tangent"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public Vector2D UV0 { get { return this[nameof(UV0)].As<Vector2D>(); } set { this["UV0"] = value; } }
        public Vector2D UV1 { get { return this[nameof(UV1)].As<Vector2D>(); } set { this["UV1"] = value; } }
        public Vector2D UV2 { get { return this[nameof(UV2)].As<Vector2D>(); } set { this["UV2"] = value; } }
        public Vector2D UV3 { get { return this[nameof(UV3)].As<Vector2D>(); } set { this["UV3"] = value; } }
    }
    public class ProcMeshSection : Object
    {
        public ProcMeshSection(nint addr) : base(addr) { }
        public Array<ProcMeshVertex> ProcVertexBuffer { get { return new Array<ProcMeshVertex>(this[nameof(ProcVertexBuffer)].Address); } }
        public Array<uint> ProcIndexBuffer { get { return new Array<uint>(this[nameof(ProcIndexBuffer)].Address); } }
        public Box SectionLocalBox { get { return this[nameof(SectionLocalBox)].As<Box>(); } set { this["SectionLocalBox"] = value; } }
        public bool bEnableCollision { get { return this[nameof(bEnableCollision)].Flag; } set { this[nameof(bEnableCollision)].Flag = value; } }
        public bool bSectionVisible { get { return this[nameof(bSectionVisible)].Flag; } set { this[nameof(bSectionVisible)].Flag = value; } }
    }
}
