using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.FSR2TemporalUpscalingSDK
{
    public class FSR2Settings : DeveloperSettings
    {
        public FSR2Settings(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool AutoExposure { get { return this[nameof(AutoExposure)].Flag; } set { this[nameof(AutoExposure)].Flag = value; } }
        public bool EnabledInEditorViewport { get { return this[nameof(EnabledInEditorViewport)].Flag; } set { this[nameof(EnabledInEditorViewport)].Flag = value; } }
        public bool UseSSRExperimentalDenoiser { get { return this[nameof(UseSSRExperimentalDenoiser)].Flag; } set { this[nameof(UseSSRExperimentalDenoiser)].Flag = value; } }
        public bool UseNativeDX12 { get { return this[nameof(UseNativeDX12)].Flag; } set { this[nameof(UseNativeDX12)].Flag = value; } }
        public bool UseNativeVulkan { get { return this[nameof(UseNativeVulkan)].Flag; } set { this[nameof(UseNativeVulkan)].Flag = value; } }
        public EFSR2QualityMode QualityMode { get { return (EFSR2QualityMode)this[nameof(QualityMode)].GetValue<int>(); } set { this[nameof(QualityMode)].SetValue<int>((int)value); } }
        public EFSR2HistoryFormat HistoryFormat { get { return (EFSR2HistoryFormat)this[nameof(HistoryFormat)].GetValue<int>(); } set { this[nameof(HistoryFormat)].SetValue<int>((int)value); } }
        public EFSR2DeDitherMode DeDither { get { return (EFSR2DeDitherMode)this[nameof(DeDither)].GetValue<int>(); } set { this[nameof(DeDither)].SetValue<int>((int)value); } }
        public float Sharpness { get { return this[nameof(Sharpness)].GetValue<float>(); } set { this[nameof(Sharpness)].SetValue<float>(value); } }
        public bool AdjustMipBias { get { return this[nameof(AdjustMipBias)].Flag; } set { this[nameof(AdjustMipBias)].Flag = value; } }
        public bool ReactiveMask { get { return this[nameof(ReactiveMask)].Flag; } set { this[nameof(ReactiveMask)].Flag = value; } }
        public bool ForceVertexDeformationOutputsVelocity { get { return this[nameof(ForceVertexDeformationOutputsVelocity)].Flag; } set { this[nameof(ForceVertexDeformationOutputsVelocity)].Flag = value; } }
        public EFSR2LandscapeHISMMode ForceLandscapeHISMMobility { get { return (EFSR2LandscapeHISMMode)this[nameof(ForceLandscapeHISMMobility)].GetValue<int>(); } set { this[nameof(ForceLandscapeHISMMobility)].SetValue<int>((int)value); } }
        public float ReflectionScale { get { return this[nameof(ReflectionScale)].GetValue<float>(); } set { this[nameof(ReflectionScale)].SetValue<float>(value); } }
        public float ReflectionLuminanceBias { get { return this[nameof(ReflectionLuminanceBias)].GetValue<float>(); } set { this[nameof(ReflectionLuminanceBias)].SetValue<float>(value); } }
        public float RoughnessScale { get { return this[nameof(RoughnessScale)].GetValue<float>(); } set { this[nameof(RoughnessScale)].SetValue<float>(value); } }
        public float RoughnessBias { get { return this[nameof(RoughnessBias)].GetValue<float>(); } set { this[nameof(RoughnessBias)].SetValue<float>(value); } }
        public float RoughnessMaxDistance { get { return this[nameof(RoughnessMaxDistance)].GetValue<float>(); } set { this[nameof(RoughnessMaxDistance)].SetValue<float>(value); } }
        public bool ReactiveMaskRoughnessForceMaxDistance { get { return this[nameof(ReactiveMaskRoughnessForceMaxDistance)].Flag; } set { this[nameof(ReactiveMaskRoughnessForceMaxDistance)].Flag = value; } }
        public float TranslucencyBias { get { return this[nameof(TranslucencyBias)].GetValue<float>(); } set { this[nameof(TranslucencyBias)].SetValue<float>(value); } }
        public float TranslucencyLuminanceBias { get { return this[nameof(TranslucencyLuminanceBias)].GetValue<float>(); } set { this[nameof(TranslucencyLuminanceBias)].SetValue<float>(value); } }
        public float TranslucencyMaxDistance { get { return this[nameof(TranslucencyMaxDistance)].GetValue<float>(); } set { this[nameof(TranslucencyMaxDistance)].SetValue<float>(value); } }
        public float PreDOFTranslucencyScale { get { return this[nameof(PreDOFTranslucencyScale)].GetValue<float>(); } set { this[nameof(PreDOFTranslucencyScale)].SetValue<float>(value); } }
        public bool PreDOFTranslucencyMax { get { return this[nameof(PreDOFTranslucencyMax)].Flag; } set { this[nameof(PreDOFTranslucencyMax)].Flag = value; } }
        public byte ReactiveShadingModelID { get { return this[nameof(ReactiveShadingModelID)].GetValue<byte>(); } set { this[nameof(ReactiveShadingModelID)].SetValue<byte>(value); } }
        public float ForceReactiveMaterialValue { get { return this[nameof(ForceReactiveMaterialValue)].GetValue<float>(); } set { this[nameof(ForceReactiveMaterialValue)].SetValue<float>(value); } }
        public float ReactiveHistoryTranslucencyBias { get { return this[nameof(ReactiveHistoryTranslucencyBias)].GetValue<float>(); } set { this[nameof(ReactiveHistoryTranslucencyBias)].SetValue<float>(value); } }
        public float ReactiveHistoryTranslucencyLumaBias { get { return this[nameof(ReactiveHistoryTranslucencyLumaBias)].GetValue<float>(); } set { this[nameof(ReactiveHistoryTranslucencyLumaBias)].SetValue<float>(value); } }
    }
    public enum EFSR2QualityMode : int
    {
        Unused = 0,
        Quality = 1,
        Balanced = 2,
        Performance = 3,
        UltraPerformance = 4,
        EFSR2QualityMode_MAX = 5,
    }
    public enum EFSR2HistoryFormat : int
    {
        FloatRGBA = 0,
        FloatR11G11B10 = 1,
        EFSR2HistoryFormat_MAX = 2,
    }
    public enum EFSR2DeDitherMode : int
    {
        Off = 0,
        Full = 1,
        HairOnly = 2,
        EFSR2DeDitherMode_MAX = 3,
    }
    public enum EFSR2LandscapeHISMMode : int
    {
        Off = 0,
        AllStatic = 1,
        StaticWPO = 2,
        EFSR2LandscapeHISMMode_MAX = 3,
    }
}
