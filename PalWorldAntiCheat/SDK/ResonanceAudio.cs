using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.AudioExtensionsSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ResonanceAudioSDK
{
    public class ResonanceAudioSoundfieldSettings : SoundfieldEncodingSettingsBase
    {
        public ResonanceAudioSoundfieldSettings(nint addr) : base(addr) { }
        public EResonanceRenderMode RenderMode { get { return (EResonanceRenderMode)this[nameof(RenderMode)].GetValue<int>(); } set { this[nameof(RenderMode)].SetValue<int>((int)value); } }
    }
    public class ResonanceAudioBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public ResonanceAudioBlueprintFunctionLibrary(nint addr) : base(addr) { }
        public void SetGlobalReverbPreset(ResonanceAudioReverbPluginPreset InPreset) { Invoke(nameof(SetGlobalReverbPreset), InPreset); }
        public ResonanceAudioReverbPluginPreset GetGlobalReverbPreset() { return Invoke<ResonanceAudioReverbPluginPreset>(nameof(GetGlobalReverbPreset)); }
    }
    public class ResonanceAudioDirectivityVisualizer : Actor
    {
        public ResonanceAudioDirectivityVisualizer(nint addr) : base(addr) { }
        public Material Material { get { return this[nameof(Material)].As<Material>(); } set { this["Material"] = value; } }
        public ResonanceAudioSpatializationSourceSettings Settings { get { return this[nameof(Settings)].As<ResonanceAudioSpatializationSourceSettings>(); } set { this["Settings"] = value; } }
    }
    public class ResonanceAudioReverbPluginPreset : SoundEffectSubmixPreset
    {
        public ResonanceAudioReverbPluginPreset(nint addr) : base(addr) { }
        public ResonanceAudioReverbPluginSettings Settings { get { return this[nameof(Settings)].As<ResonanceAudioReverbPluginSettings>(); } set { this["Settings"] = value; } }
        public void SetRoomRotation(Quat InRotation) { Invoke(nameof(SetRoomRotation), InRotation); }
        public void SetRoomPosition(Vector InPosition) { Invoke(nameof(SetRoomPosition), InPosition); }
        public void SetRoomMaterials(Array<ERaMaterialName> InMaterials) { Invoke(nameof(SetRoomMaterials), InMaterials); }
        public void SetRoomDimensions(Vector InDimensions) { Invoke(nameof(SetRoomDimensions), InDimensions); }
        public void SetReverbTimeModifier(float InReverbTimeModifier) { Invoke(nameof(SetReverbTimeModifier), InReverbTimeModifier); }
        public void SetReverbGain(float InReverbGain) { Invoke(nameof(SetReverbGain), InReverbGain); }
        public void SetReverbBrightness(float InReverbBrightness) { Invoke(nameof(SetReverbBrightness), InReverbBrightness); }
        public void SetReflectionScalar(float InReflectionScalar) { Invoke(nameof(SetReflectionScalar), InReflectionScalar); }
        public void SetEnableRoomEffects(bool bInEnableRoomEffects) { Invoke(nameof(SetEnableRoomEffects), bInEnableRoomEffects); }
    }
    public class ResonanceAudioSettings : Object
    {
        public ResonanceAudioSettings(nint addr) : base(addr) { }
        public SoftObjectPath OutputSubmix { get { return this[nameof(OutputSubmix)].As<SoftObjectPath>(); } set { this["OutputSubmix"] = value; } }
        public ERaQualityMode QualityMode { get { return (ERaQualityMode)this[nameof(QualityMode)].GetValue<int>(); } set { this[nameof(QualityMode)].SetValue<int>((int)value); } }
        public SoftObjectPath GlobalReverbPreset { get { return this[nameof(GlobalReverbPreset)].As<SoftObjectPath>(); } set { this["GlobalReverbPreset"] = value; } }
        public SoftObjectPath GlobalSourcePreset { get { return this[nameof(GlobalSourcePreset)].As<SoftObjectPath>(); } set { this["GlobalSourcePreset"] = value; } }
    }
    public class ResonanceAudioSpatializationSourceSettings : SpatializationPluginSourceSettingsBase
    {
        public ResonanceAudioSpatializationSourceSettings(nint addr) : base(addr) { }
        public ERaSpatializationMethod SpatializationMethod { get { return (ERaSpatializationMethod)this[nameof(SpatializationMethod)].GetValue<int>(); } set { this[nameof(SpatializationMethod)].SetValue<int>((int)value); } }
        public float Pattern { get { return this[nameof(Pattern)].GetValue<float>(); } set { this[nameof(Pattern)].SetValue<float>(value); } }
        public float Sharpness { get { return this[nameof(Sharpness)].GetValue<float>(); } set { this[nameof(Sharpness)].SetValue<float>(value); } }
        public bool bToggleVisualization { get { return this[nameof(bToggleVisualization)].Flag; } set { this[nameof(bToggleVisualization)].Flag = value; } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public float Spread { get { return this[nameof(Spread)].GetValue<float>(); } set { this[nameof(Spread)].SetValue<float>(value); } }
        public ERaDistanceRolloffModel Rolloff { get { return (ERaDistanceRolloffModel)this[nameof(Rolloff)].GetValue<int>(); } set { this[nameof(Rolloff)].SetValue<int>((int)value); } }
        public float minDistance { get { return this[nameof(minDistance)].GetValue<float>(); } set { this[nameof(minDistance)].SetValue<float>(value); } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public void SetSoundSourceSpread(float InSpread) { Invoke(nameof(SetSoundSourceSpread), InSpread); }
        public void SetSoundSourceDirectivity(float InPattern, float InSharpness) { Invoke(nameof(SetSoundSourceDirectivity), InPattern, InSharpness); }
    }
    public enum EResonanceRenderMode : int
    {
        StereoPanning = 0,
        BinauralLowQuality = 1,
        BinauralMediumQuality = 2,
        BinauralHighQuality = 3,
        RoomEffectsOnly = 4,
        EResonanceRenderMode_MAX = 5,
    }
    public enum ERaQualityMode : int
    {
        STEREO_PANNING = 0,
        BINAURAL_LOW = 1,
        BINAURAL_MEDIUM = 2,
        BINAURAL_HIGH = 3,
        ERaQualityMode_MAX = 4,
    }
    public enum ERaSpatializationMethod : int
    {
        STEREO_PANNING = 0,
        HRTF = 1,
        ERaSpatializationMethod_MAX = 2,
    }
    public enum ERaDistanceRolloffModel : int
    {
        LOGARITHMIC = 0,
        LINEAR = 1,
        NONE = 2,
        ERaDistanceRolloffModel_MAX = 3,
    }
    public enum ERaMaterialName : int
    {
        TRANSPARENT = 0,
        ACOUSTIC_CEILING_TILES = 1,
        BRICK_BARE = 2,
        BRICK_PAINTED = 3,
        CONCRETE_BLOCK_COARSE = 4,
        CONCRETE_BLOCK_PAINTED = 5,
        CURTAIN_HEAVY = 6,
        FIBER_GLASS_INSULATION = 7,
        GLASS_THIN = 8,
        GLASS_THICK = 9,
        GRASS = 10,
        LINOLEUM_ON_CONCRETE = 11,
        MARBLE = 12,
        METAL = 13,
        PARQUET_ONCONCRETE = 14,
        PLASTER_ROUGH = 15,
        PLASTER_SMOOTH = 16,
        PLYWOOD_PANEL = 17,
        POLISHED_CONCRETE_OR_TILE = 18,
        SHEETROCK = 19,
        WATER_OR_ICE_SURFACE = 20,
        WOOD_CEILING = 21,
        WOOD_PANEL = 22,
        UNIFORM = 23,
        ERaMaterialName_MAX = 24,
    }
    public class ResonanceAudioReverbPluginSettings : Object
    {
        public ResonanceAudioReverbPluginSettings(nint addr) : base(addr) { }
        public bool bEnableRoomEffects { get { return this[nameof(bEnableRoomEffects)].Flag; } set { this[nameof(bEnableRoomEffects)].Flag = value; } }
        public bool bGetTransformFromAudioVolume { get { return this[nameof(bGetTransformFromAudioVolume)].Flag; } set { this[nameof(bGetTransformFromAudioVolume)].Flag = value; } }
        public Vector RoomPosition { get { return this[nameof(RoomPosition)].As<Vector>(); } set { this["RoomPosition"] = value; } }
        public Quat RoomRotation { get { return this[nameof(RoomRotation)].As<Quat>(); } set { this["RoomRotation"] = value; } }
        public Vector RoomDimensions { get { return this[nameof(RoomDimensions)].As<Vector>(); } set { this["RoomDimensions"] = value; } }
        public ERaMaterialName LeftWallMaterial { get { return (ERaMaterialName)this[nameof(LeftWallMaterial)].GetValue<int>(); } set { this[nameof(LeftWallMaterial)].SetValue<int>((int)value); } }
        public ERaMaterialName RightWallMaterial { get { return (ERaMaterialName)this[nameof(RightWallMaterial)].GetValue<int>(); } set { this[nameof(RightWallMaterial)].SetValue<int>((int)value); } }
        public ERaMaterialName FloorMaterial { get { return (ERaMaterialName)this[nameof(FloorMaterial)].GetValue<int>(); } set { this[nameof(FloorMaterial)].SetValue<int>((int)value); } }
        public ERaMaterialName CeilingMaterial { get { return (ERaMaterialName)this[nameof(CeilingMaterial)].GetValue<int>(); } set { this[nameof(CeilingMaterial)].SetValue<int>((int)value); } }
        public ERaMaterialName FrontWallMaterial { get { return (ERaMaterialName)this[nameof(FrontWallMaterial)].GetValue<int>(); } set { this[nameof(FrontWallMaterial)].SetValue<int>((int)value); } }
        public ERaMaterialName BackWallMaterial { get { return (ERaMaterialName)this[nameof(BackWallMaterial)].GetValue<int>(); } set { this[nameof(BackWallMaterial)].SetValue<int>((int)value); } }
        public float ReflectionScalar { get { return this[nameof(ReflectionScalar)].GetValue<float>(); } set { this[nameof(ReflectionScalar)].SetValue<float>(value); } }
        public float ReverbGain { get { return this[nameof(ReverbGain)].GetValue<float>(); } set { this[nameof(ReverbGain)].SetValue<float>(value); } }
        public float ReverbTimeModifier { get { return this[nameof(ReverbTimeModifier)].GetValue<float>(); } set { this[nameof(ReverbTimeModifier)].SetValue<float>(value); } }
        public float ReverbBrightness { get { return this[nameof(ReverbBrightness)].GetValue<float>(); } set { this[nameof(ReverbBrightness)].SetValue<float>(value); } }
    }
}
