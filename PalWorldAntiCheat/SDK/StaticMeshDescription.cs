using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MeshDescriptionSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.StaticMeshDescriptionSDK
{
    public class StaticMeshDescription : MeshDescriptionBase
    {
        public StaticMeshDescription(nint addr) : base(addr) { }
        public void SetVertexInstanceUV(VertexInstanceID VertexInstanceID, Vector2D UV, int UVIndex) { Invoke(nameof(SetVertexInstanceUV), VertexInstanceID, UV, UVIndex); }
        public void SetPolygonGroupMaterialSlotName(PolygonGroupID PolygonGroupID, Object SlotName) { Invoke(nameof(SetPolygonGroupMaterialSlotName), PolygonGroupID, SlotName); }
        public Vector2D GetVertexInstanceUV(VertexInstanceID VertexInstanceID, int UVIndex) { return Invoke<Vector2D>(nameof(GetVertexInstanceUV), VertexInstanceID, UVIndex); }
        public void CreateCube(Vector Center, Vector HalfExtents, PolygonGroupID PolygonGroup, PolygonID PolygonID_PlusX, PolygonID PolygonID_MinusX, PolygonID PolygonID_PlusY, PolygonID PolygonID_MinusY, PolygonID PolygonID_PlusZ, PolygonID PolygonID_MinusZ) { Invoke(nameof(CreateCube), Center, HalfExtents, PolygonGroup, PolygonID_PlusX, PolygonID_MinusX, PolygonID_PlusY, PolygonID_MinusY, PolygonID_PlusZ, PolygonID_MinusZ); }
    }
    public class UVMapSettings : Object
    {
        public UVMapSettings(nint addr) : base(addr) { }
        public Vector Size { get { return this[nameof(Size)].As<Vector>(); } set { this["Size"] = value; } }
        public Vector2D UVTile { get { return this[nameof(UVTile)].As<Vector2D>(); } set { this["UVTile"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
    }
}
