using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.PlacementToolsSDK
{
    public class PlacementToolBase : Actor
    {
        public PlacementToolBase(nint addr) : base(addr) { }
        public bool isInEditor { get { return this[nameof(isInEditor)].Flag; } set { this[nameof(isInEditor)].Flag = value; } }
        public SceneComponent SceneComponent { get { return this[nameof(SceneComponent)].As<SceneComponent>(); } set { this["SceneComponent"] = value; } }
        public BillboardComponent EasySelectBillboard { get { return this[nameof(EasySelectBillboard)].As<BillboardComponent>(); } set { this["EasySelectBillboard"] = value; } }
        public RandomStream RandomStream { get { return this[nameof(RandomStream)].As<RandomStream>(); } set { this["RandomStream"] = value; } }
        public LinearDistribution DistributionCurve { get { return this[nameof(DistributionCurve)].As<LinearDistribution>(); } set { this["DistributionCurve"] = value; } }
        public byte PlacementMode { get { return this[nameof(PlacementMode)].GetValue<byte>(); } set { this[nameof(PlacementMode)].SetValue<byte>(value); } }
        public byte PlacementStyle { get { return this[nameof(PlacementStyle)].GetValue<byte>(); } set { this[nameof(PlacementStyle)].SetValue<byte>(value); } }
        public Array<PlacementItem> PlacementItems { get { return new Array<PlacementItem>(this[nameof(PlacementItems)].Address); } }
        public Directions SurfaceDirection { get { return this[nameof(SurfaceDirection)].As<Directions>(); } set { this["SurfaceDirection"] = value; } }
        public int Amount { get { return this[nameof(Amount)].GetValue<int>(); } set { this[nameof(Amount)].SetValue<int>(value); } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public Transform Offset { get { return this[nameof(Offset)].As<Transform>(); } set { this["Offset"] = value; } }
        public bool bRandomizeRotation { get { return this[nameof(bRandomizeRotation)].Flag; } set { this[nameof(bRandomizeRotation)].Flag = value; } }
        public Rotator RotationMin { get { return this[nameof(RotationMin)].As<Rotator>(); } set { this["RotationMin"] = value; } }
        public Rotator RotationMax { get { return this[nameof(RotationMax)].As<Rotator>(); } set { this["RotationMax"] = value; } }
        public bool bRandomizeScale { get { return this[nameof(bRandomizeScale)].Flag; } set { this[nameof(bRandomizeScale)].Flag = value; } }
        public bool bUniformScale { get { return this[nameof(bUniformScale)].Flag; } set { this[nameof(bUniformScale)].Flag = value; } }
        public Vector ScaleMin { get { return this[nameof(ScaleMin)].As<Vector>(); } set { this["ScaleMin"] = value; } }
        public Vector ScaleMax { get { return this[nameof(ScaleMax)].As<Vector>(); } set { this["ScaleMax"] = value; } }
        public bool bRotateToSurface { get { return this[nameof(bRotateToSurface)].Flag; } set { this[nameof(bRotateToSurface)].Flag = value; } }
        public bool bAdjustToSurface { get { return this[nameof(bAdjustToSurface)].Flag; } set { this[nameof(bAdjustToSurface)].Flag = value; } }
        public bool bAvoidOverlapBounds { get { return this[nameof(bAvoidOverlapBounds)].Flag; } set { this[nameof(bAvoidOverlapBounds)].Flag = value; } }
        public bool bDeleteChildrenWhenDeleted { get { return this[nameof(bDeleteChildrenWhenDeleted)].Flag; } set { this[nameof(bDeleteChildrenWhenDeleted)].Flag = value; } }
        public bool bHideBrush { get { return this[nameof(bHideBrush)].Flag; } set { this[nameof(bHideBrush)].Flag = value; } }
        public void RandomizeSeed() { Invoke(nameof(RandomizeSeed)); }
        public void Generate() { Invoke(nameof(Generate)); }
    }
    public class BoxPlacement : PlacementToolBase
    {
        public BoxPlacement(nint addr) : base(addr) { }
        public Vector BoxExtent { get { return this[nameof(BoxExtent)].As<Vector>(); } set { this["BoxExtent"] = value; } }
        public BoxComponent BoxBrush { get { return this[nameof(BoxBrush)].As<BoxComponent>(); } set { this["BoxBrush"] = value; } }
        public Directions FadeDirection { get { return this[nameof(FadeDirection)].As<Directions>(); } set { this["FadeDirection"] = value; } }
        public byte TraceChannel { get { return this[nameof(TraceChannel)].GetValue<byte>(); } set { this[nameof(TraceChannel)].SetValue<byte>(value); } }
        public Array<Object> NotPlaceOnActorTags { get { return new Array<Object>(this[nameof(NotPlaceOnActorTags)].Address); } }
    }
    public class SpherePlacement : PlacementToolBase
    {
        public SpherePlacement(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public SphereComponent SphereBrush { get { return this[nameof(SphereBrush)].As<SphereComponent>(); } set { this["SphereBrush"] = value; } }
        public byte FadeDirection { get { return this[nameof(FadeDirection)].GetValue<byte>(); } set { this[nameof(FadeDirection)].SetValue<byte>(value); } }
        public byte TraceChannel { get { return this[nameof(TraceChannel)].GetValue<byte>(); } set { this[nameof(TraceChannel)].SetValue<byte>(value); } }
        public Array<Object> NotPlaceOnActorTags { get { return new Array<Object>(this[nameof(NotPlaceOnActorTags)].Address); } }
    }
    public enum EPlacementMode : int
    {
        Free = 0,
        Surface = 1,
        EPlacementMode_MAX = 2,
    }
    public enum EPlacementStyle : int
    {
        Fade = 0,
        FadeOut = 1,
        FadeIn = 2,
        CustomFade = 3,
        Random = 4,
        EPlacementStyle_MAX = 5,
    }
    public enum EItemType : int
    {
        Actor = 0,
        StaticMesh = 1,
        EItemType_MAX = 2,
    }
    public enum EFadeAxis : int
    {
        All = 0,
        X = 1,
        Y = 2,
        Z = 3,
        EFadeAxis_MAX = 4,
    }
    public class Directions : Object
    {
        public Directions(nint addr) : base(addr) { }
        public bool xDown { get { return this[nameof(xDown)].Flag; } set { this[nameof(xDown)].Flag = value; } }
        public bool xUp { get { return this[nameof(xUp)].Flag; } set { this[nameof(xUp)].Flag = value; } }
        public bool yDown { get { return this[nameof(yDown)].Flag; } set { this[nameof(yDown)].Flag = value; } }
        public bool yUp { get { return this[nameof(yUp)].Flag; } set { this[nameof(yUp)].Flag = value; } }
        public bool zDown { get { return this[nameof(zDown)].Flag; } set { this[nameof(zDown)].Flag = value; } }
        public bool zUp { get { return this[nameof(zUp)].Flag; } set { this[nameof(zUp)].Flag = value; } }
    }
    public class PlacementItem : Object
    {
        public PlacementItem(nint addr) : base(addr) { }
        public byte ItemType { get { return this[nameof(ItemType)].GetValue<byte>(); } set { this[nameof(ItemType)].SetValue<byte>(value); } }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public StaticMesh Mesh { get { return this[nameof(Mesh)].As<StaticMesh>(); } set { this["Mesh"] = value; } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
    }
    public class LinearDistribution : Object
    {
        public LinearDistribution(nint addr) : base(addr) { }
        public Array<Vector2D> CurvePoints { get { return new Array<Vector2D>(this[nameof(CurvePoints)].Address); } }
    }
}
