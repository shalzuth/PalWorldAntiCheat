using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.CustomMeshComponentSDK
{
    public class CustomMeshComponent : MeshComponent
    {
        public CustomMeshComponent(nint addr) : base(addr) { }
        public bool SetCustomMeshTriangles(Array<CustomMeshTriangle> Triangles) { return Invoke<bool>(nameof(SetCustomMeshTriangles), Triangles); }
        public void ClearCustomMeshTriangles() { Invoke(nameof(ClearCustomMeshTriangles)); }
        public void AddCustomMeshTriangles(Array<CustomMeshTriangle> Triangles) { Invoke(nameof(AddCustomMeshTriangles), Triangles); }
    }
    public class CustomMeshTriangle : Object
    {
        public CustomMeshTriangle(nint addr) : base(addr) { }
        public Vector Vertex0 { get { return this[nameof(Vertex0)].As<Vector>(); } set { this["Vertex0"] = value; } }
        public Vector Vertex1 { get { return this[nameof(Vertex1)].As<Vector>(); } set { this["Vertex1"] = value; } }
        public Vector Vertex2 { get { return this[nameof(Vertex2)].As<Vector>(); } set { this["Vertex2"] = value; } }
    }
}
