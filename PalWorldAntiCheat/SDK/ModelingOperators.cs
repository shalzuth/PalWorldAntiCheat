using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.InteractiveToolsFrameworkSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ModelingOperatorsSDK
{
    public class RecomputeUVsToolProperties : InteractiveToolPropertySet
    {
        public RecomputeUVsToolProperties(nint addr) : base(addr) { }
        public bool bEnablePolygroupSupport { get { return this[nameof(bEnablePolygroupSupport)].Flag; } set { this[nameof(bEnablePolygroupSupport)].Flag = value; } }
        public ERecomputeUVsPropertiesIslandMode IslandGeneration { get { return (ERecomputeUVsPropertiesIslandMode)this[nameof(IslandGeneration)].GetValue<int>(); } set { this[nameof(IslandGeneration)].SetValue<int>((int)value); } }
        public ERecomputeUVsPropertiesUnwrapType UnwrapType { get { return (ERecomputeUVsPropertiesUnwrapType)this[nameof(UnwrapType)].GetValue<int>(); } set { this[nameof(UnwrapType)].SetValue<int>((int)value); } }
        public ERecomputeUVsToolOrientationMode AutoRotation { get { return (ERecomputeUVsToolOrientationMode)this[nameof(AutoRotation)].GetValue<int>(); } set { this[nameof(AutoRotation)].SetValue<int>((int)value); } }
        public bool bPreserveIrregularity { get { return this[nameof(bPreserveIrregularity)].Flag; } set { this[nameof(bPreserveIrregularity)].Flag = value; } }
        public int SmoothingSteps { get { return this[nameof(SmoothingSteps)].GetValue<int>(); } set { this[nameof(SmoothingSteps)].SetValue<int>(value); } }
        public float SmoothingAlpha { get { return this[nameof(SmoothingAlpha)].GetValue<float>(); } set { this[nameof(SmoothingAlpha)].SetValue<float>(value); } }
        public float MergingDistortionThreshold { get { return this[nameof(MergingDistortionThreshold)].GetValue<float>(); } set { this[nameof(MergingDistortionThreshold)].SetValue<float>(value); } }
        public float MergingAngleThreshold { get { return this[nameof(MergingAngleThreshold)].GetValue<float>(); } set { this[nameof(MergingAngleThreshold)].SetValue<float>(value); } }
        public ERecomputeUVsPropertiesLayoutType LayoutType { get { return (ERecomputeUVsPropertiesLayoutType)this[nameof(LayoutType)].GetValue<int>(); } set { this[nameof(LayoutType)].SetValue<int>((int)value); } }
        public int TextureResolution { get { return this[nameof(TextureResolution)].GetValue<int>(); } set { this[nameof(TextureResolution)].SetValue<int>(value); } }
        public float NormalizeScale { get { return this[nameof(NormalizeScale)].GetValue<float>(); } set { this[nameof(NormalizeScale)].SetValue<float>(value); } }
    }
    public class UVLayoutProperties : InteractiveToolPropertySet
    {
        public UVLayoutProperties(nint addr) : base(addr) { }
        public EUVLayoutType LayoutType { get { return (EUVLayoutType)this[nameof(LayoutType)].GetValue<int>(); } set { this[nameof(LayoutType)].SetValue<int>((int)value); } }
        public int TextureResolution { get { return this[nameof(TextureResolution)].GetValue<int>(); } set { this[nameof(TextureResolution)].SetValue<int>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public Vector2D Translation { get { return this[nameof(Translation)].As<Vector2D>(); } set { this["Translation"] = value; } }
        public bool bAllowFlips { get { return this[nameof(bAllowFlips)].Flag; } set { this[nameof(bAllowFlips)].Flag = value; } }
    }
    public class RecomputeUVsOpFactory : Object
    {
        public RecomputeUVsOpFactory(nint addr) : base(addr) { }
        public RecomputeUVsToolProperties Settings { get { return this[nameof(Settings)].As<RecomputeUVsToolProperties>(); } set { this["Settings"] = value; } }
    }
    public class UVLayoutOperatorFactory : Object
    {
        public UVLayoutOperatorFactory(nint addr) : base(addr) { }
        public UVLayoutProperties Settings { get { return this[nameof(Settings)].As<UVLayoutProperties>(); } set { this["Settings"] = value; } }
    }
    public enum ERecomputeUVsPropertiesUnwrapType : int
    {
        ExpMap = 0,
        Conformal = 1,
        SpectralConformal = 2,
        IslandMerging = 3,
        ERecomputeUVsPropertiesUnwrapType_MAX = 4,
    }
    public enum ERecomputeUVsPropertiesIslandMode : int
    {
        PolyGroups = 0,
        ExistingUVs = 1,
        ERecomputeUVsPropertiesIslandMode_MAX = 2,
    }
    public enum ERecomputeUVsToolOrientationMode : int
    {
        None = 0,
        MinBounds = 1,
        ERecomputeUVsToolOrientationMode_MAX = 2,
    }
    public enum ERecomputeUVsPropertiesLayoutType : int
    {
        None = 0,
        Repack = 1,
        NormalizeToBounds = 2,
        NormalizeToWorld = 3,
        ERecomputeUVsPropertiesLayoutType_MAX = 4,
    }
    public enum EUVLayoutType : int
    {
        Transform = 0,
        Stack = 1,
        Repack = 2,
        EUVLayoutType_MAX = 3,
    }
    public enum ENormalCalculationMethod : int
    {
        AreaWeighted = 0,
        AngleWeighted = 1,
        AreaAngleWeighting = 2,
        ENormalCalculationMethod_MAX = 3,
    }
    public enum ESplitNormalMethod : int
    {
        UseExistingTopology = 0,
        FaceNormalThreshold = 1,
        FaceGroupID = 2,
        PerTriangle = 3,
        PerVertex = 4,
        ESplitNormalMethod_MAX = 5,
    }
    public enum EHoleFillOpFillType : int
    {
        TriangleFan = 0,
        PolygonEarClipping = 1,
        Planar = 2,
        Minimal = 3,
        Smooth = 4,
        EHoleFillOpFillType_MAX = 5,
    }
    public enum ERemeshType : int
    {
        Standard = 0,
        FullPass = 1,
        NormalFlow = 2,
        ERemeshType_MAX = 3,
    }
    public enum ERemeshSmoothingType : int
    {
        Uniform = 0,
        Cotangent = 1,
        MeanValue = 2,
        ERemeshSmoothingType_MAX = 3,
    }
    public enum ECSGOperation : int
    {
        DifferenceAB = 0,
        DifferenceBA = 1,
        Intersect = 2,
        Union = 3,
        ECSGOperation_MAX = 4,
    }
    public enum ETrimOperation : int
    {
        TrimA = 0,
        TrimB = 1,
        ETrimOperation_MAX = 2,
    }
    public enum ETrimSide : int
    {
        RemoveInside = 0,
        RemoveOutside = 1,
        ETrimSide_MAX = 2,
    }
    public enum EMorphologyOperation : int
    {
        Dilate = 0,
        Contract = 1,
        Close = 2,
        Open = 3,
        EMorphologyOperation_MAX = 4,
    }
    public enum EUVProjectionMethod : int
    {
        Box = 0,
        Cylinder = 1,
        Plane = 2,
        ExpMap = 3,
        EUVProjectionMethod_MAX = 4,
    }
}
