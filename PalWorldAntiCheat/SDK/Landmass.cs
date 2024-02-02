using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.LandmassSDK
{
    public enum EBrushFalloffMode : int
    {
        Angle = 0,
        Width = 1,
        EBrushFalloffMode_MAX = 2,
    }
    public enum EBrushBlendType : int
    {
        AlphaBlend = 0,
        Min = 1,
        Max = 2,
        Additive = 3,
    }
    public class BrushEffectBlurring : Object
    {
        public BrushEffectBlurring(nint addr) : base(addr) { }
        public bool bBlurShape { get { return this[nameof(bBlurShape)].Flag; } set { this[nameof(bBlurShape)].Flag = value; } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
    }
    public class BrushEffectCurlNoise : Object
    {
        public BrushEffectCurlNoise(nint addr) : base(addr) { }
        public float Curl1Amount { get { return this[nameof(Curl1Amount)].GetValue<float>(); } set { this[nameof(Curl1Amount)].SetValue<float>(value); } }
        public float Curl2Amount { get { return this[nameof(Curl2Amount)].GetValue<float>(); } set { this[nameof(Curl2Amount)].SetValue<float>(value); } }
        public float Curl1Tiling { get { return this[nameof(Curl1Tiling)].GetValue<float>(); } set { this[nameof(Curl1Tiling)].SetValue<float>(value); } }
        public float Curl2Tiling { get { return this[nameof(Curl2Tiling)].GetValue<float>(); } set { this[nameof(Curl2Tiling)].SetValue<float>(value); } }
    }
    public class BrushEffectCurves : Object
    {
        public BrushEffectCurves(nint addr) : base(addr) { }
        public bool bUseCurveChannel { get { return this[nameof(bUseCurveChannel)].Flag; } set { this[nameof(bUseCurveChannel)].Flag = value; } }
        public CurveFloat ElevationCurveAsset { get { return this[nameof(ElevationCurveAsset)].As<CurveFloat>(); } set { this["ElevationCurveAsset"] = value; } }
        public float ChannelEdgeOffset { get { return this[nameof(ChannelEdgeOffset)].GetValue<float>(); } set { this[nameof(ChannelEdgeOffset)].SetValue<float>(value); } }
        public float ChannelDepth { get { return this[nameof(ChannelDepth)].GetValue<float>(); } set { this[nameof(ChannelDepth)].SetValue<float>(value); } }
        public float CurveRampWidth { get { return this[nameof(CurveRampWidth)].GetValue<float>(); } set { this[nameof(CurveRampWidth)].SetValue<float>(value); } }
    }
    public class BrushEffectDisplacement : Object
    {
        public BrushEffectDisplacement(nint addr) : base(addr) { }
        public float DisplacementHeight { get { return this[nameof(DisplacementHeight)].GetValue<float>(); } set { this[nameof(DisplacementHeight)].SetValue<float>(value); } }
        public float DisplacementTiling { get { return this[nameof(DisplacementTiling)].GetValue<float>(); } set { this[nameof(DisplacementTiling)].SetValue<float>(value); } }
        public Texture2D Texture { get { return this[nameof(Texture)].As<Texture2D>(); } set { this["Texture"] = value; } }
        public float Midpoint { get { return this[nameof(Midpoint)].GetValue<float>(); } set { this[nameof(Midpoint)].SetValue<float>(value); } }
        public LinearColor Channel { get { return this[nameof(Channel)].As<LinearColor>(); } set { this["Channel"] = value; } }
        public float WeightmapInfluence { get { return this[nameof(WeightmapInfluence)].GetValue<float>(); } set { this[nameof(WeightmapInfluence)].SetValue<float>(value); } }
    }
    public class BrushEffectSmoothBlending : Object
    {
        public BrushEffectSmoothBlending(nint addr) : base(addr) { }
        public float InnerSmoothDistance { get { return this[nameof(InnerSmoothDistance)].GetValue<float>(); } set { this[nameof(InnerSmoothDistance)].SetValue<float>(value); } }
        public float OuterSmoothDistance { get { return this[nameof(OuterSmoothDistance)].GetValue<float>(); } set { this[nameof(OuterSmoothDistance)].SetValue<float>(value); } }
    }
    public class BrushEffectTerracing : Object
    {
        public BrushEffectTerracing(nint addr) : base(addr) { }
        public float TerraceAlpha { get { return this[nameof(TerraceAlpha)].GetValue<float>(); } set { this[nameof(TerraceAlpha)].SetValue<float>(value); } }
        public float TerraceSpacing { get { return this[nameof(TerraceSpacing)].GetValue<float>(); } set { this[nameof(TerraceSpacing)].SetValue<float>(value); } }
        public float TerraceSmoothness { get { return this[nameof(TerraceSmoothness)].GetValue<float>(); } set { this[nameof(TerraceSmoothness)].SetValue<float>(value); } }
        public float MaskLength { get { return this[nameof(MaskLength)].GetValue<float>(); } set { this[nameof(MaskLength)].SetValue<float>(value); } }
        public float MaskStartOffset { get { return this[nameof(MaskStartOffset)].GetValue<float>(); } set { this[nameof(MaskStartOffset)].SetValue<float>(value); } }
    }
    public class LandmassBrushEffectsList : Object
    {
        public LandmassBrushEffectsList(nint addr) : base(addr) { }
        public BrushEffectBlurring Blurring { get { return this[nameof(Blurring)].As<BrushEffectBlurring>(); } set { this["Blurring"] = value; } }
        public BrushEffectCurlNoise CurlNoise { get { return this[nameof(CurlNoise)].As<BrushEffectCurlNoise>(); } set { this["CurlNoise"] = value; } }
        public BrushEffectDisplacement Displacement { get { return this[nameof(Displacement)].As<BrushEffectDisplacement>(); } set { this["Displacement"] = value; } }
        public BrushEffectSmoothBlending SmoothBlending { get { return this[nameof(SmoothBlending)].As<BrushEffectSmoothBlending>(); } set { this["SmoothBlending"] = value; } }
        public BrushEffectTerracing Terracing { get { return this[nameof(Terracing)].As<BrushEffectTerracing>(); } set { this["Terracing"] = value; } }
    }
    public class LandmassFalloffSettings : Object
    {
        public LandmassFalloffSettings(nint addr) : base(addr) { }
        public EBrushFalloffMode FalloffMode { get { return (EBrushFalloffMode)this[nameof(FalloffMode)].GetValue<int>(); } set { this[nameof(FalloffMode)].SetValue<int>((int)value); } }
        public float FalloffAngle { get { return this[nameof(FalloffAngle)].GetValue<float>(); } set { this[nameof(FalloffAngle)].SetValue<float>(value); } }
        public float FalloffWidth { get { return this[nameof(FalloffWidth)].GetValue<float>(); } set { this[nameof(FalloffWidth)].SetValue<float>(value); } }
        public float EdgeOffset { get { return this[nameof(EdgeOffset)].GetValue<float>(); } set { this[nameof(EdgeOffset)].SetValue<float>(value); } }
        public float ZOffset { get { return this[nameof(ZOffset)].GetValue<float>(); } set { this[nameof(ZOffset)].SetValue<float>(value); } }
    }
    public class LandmassTerrainCarvingSettings : Object
    {
        public LandmassTerrainCarvingSettings(nint addr) : base(addr) { }
        public EBrushBlendType BlendMode { get { return (EBrushBlendType)this[nameof(BlendMode)].GetValue<int>(); } set { this[nameof(BlendMode)].SetValue<int>((int)value); } }
        public bool bInvertShape { get { return this[nameof(bInvertShape)].Flag; } set { this[nameof(bInvertShape)].Flag = value; } }
        public LandmassFalloffSettings FalloffSettings { get { return this[nameof(FalloffSettings)].As<LandmassFalloffSettings>(); } set { this["FalloffSettings"] = value; } }
        public LandmassBrushEffectsList Effects { get { return this[nameof(Effects)].As<LandmassBrushEffectsList>(); } set { this["Effects"] = value; } }
        public int Priority { get { return this[nameof(Priority)].GetValue<int>(); } set { this[nameof(Priority)].SetValue<int>(value); } }
    }
}
