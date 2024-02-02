using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AudioExtensionsSDK
{
    public class SoundfieldEncodingSettingsBase : Object
    {
        public SoundfieldEncodingSettingsBase(nint addr) : base(addr) { }
    }
    public class SpatializationPluginSourceSettingsBase : Object
    {
        public SpatializationPluginSourceSettingsBase(nint addr) : base(addr) { }
    }
    public class SourceDataOverridePluginSourceSettingsBase : Object
    {
        public SourceDataOverridePluginSourceSettingsBase(nint addr) : base(addr) { }
    }
    public class OcclusionPluginSourceSettingsBase : Object
    {
        public OcclusionPluginSourceSettingsBase(nint addr) : base(addr) { }
    }
    public class ReverbPluginSourceSettingsBase : Object
    {
        public ReverbPluginSourceSettingsBase(nint addr) : base(addr) { }
    }
    public class AudioParameterControllerInterface : Interface
    {
        public AudioParameterControllerInterface(nint addr) : base(addr) { }
        public void SetTriggerParameter(Object InName) { Invoke(nameof(SetTriggerParameter), InName); }
        public void SetStringParameter(Object InName, Object InValue) { Invoke(nameof(SetStringParameter), InName, InValue); }
        public void SetStringArrayParameter(Object InName, Array<Object> InValue) { Invoke(nameof(SetStringArrayParameter), InName, InValue); }
        public void SetParameters_Blueprint(Array<AudioParameter> InParameters) { Invoke(nameof(SetParameters_Blueprint), InParameters); }
        public void SetObjectParameter(Object InName, Object InValue) { Invoke(nameof(SetObjectParameter), InName, InValue); }
        public void SetObjectArrayParameter(Object InName, Array<Object> InValue) { Invoke(nameof(SetObjectArrayParameter), InName, InValue); }
        public void SetIntParameter(Object InName, int inInt) { Invoke(nameof(SetIntParameter), InName, inInt); }
        public void SetIntArrayParameter(Object InName, Array<int> InValue) { Invoke(nameof(SetIntArrayParameter), InName, InValue); }
        public void SetFloatParameter(Object InName, float InFloat) { Invoke(nameof(SetFloatParameter), InName, InFloat); }
        public void SetFloatArrayParameter(Object InName, Array<float> InValue) { Invoke(nameof(SetFloatArrayParameter), InName, InValue); }
        public void SetBoolParameter(Object InName, bool InBool) { Invoke(nameof(SetBoolParameter), InName, InBool); }
        public void SetBoolArrayParameter(Object InName, Array<bool> InValue) { Invoke(nameof(SetBoolArrayParameter), InName, InValue); }
        public void ResetParameters() { Invoke(nameof(ResetParameters)); }
    }
    public class AudioCodecEncoderSettings : Object
    {
        public AudioCodecEncoderSettings(nint addr) : base(addr) { }
        public int Version { get { return this[nameof(Version)].GetValue<int>(); } set { this[nameof(Version)].SetValue<int>(value); } }
    }
    public class AudioEndpointSettingsBase : Object
    {
        public AudioEndpointSettingsBase(nint addr) : base(addr) { }
    }
    public class DummyEndpointSettings : AudioEndpointSettingsBase
    {
        public DummyEndpointSettings(nint addr) : base(addr) { }
    }
    public class SoundModulatorBase : Object
    {
        public SoundModulatorBase(nint addr) : base(addr) { }
    }
    public class SoundfieldEndpointSettingsBase : Object
    {
        public SoundfieldEndpointSettingsBase(nint addr) : base(addr) { }
    }
    public class SoundfieldEffectSettingsBase : Object
    {
        public SoundfieldEffectSettingsBase(nint addr) : base(addr) { }
    }
    public class SoundfieldEffectBase : Object
    {
        public SoundfieldEffectBase(nint addr) : base(addr) { }
        public SoundfieldEffectSettingsBase Settings { get { return this[nameof(Settings)].As<SoundfieldEffectSettingsBase>(); } set { this["Settings"] = value; } }
    }
    public class WaveformTransformationBase : Object
    {
        public WaveformTransformationBase(nint addr) : base(addr) { }
    }
    public class WaveformTransformationChain : Object
    {
        public WaveformTransformationChain(nint addr) : base(addr) { }
        public Array<WaveformTransformationBase> Transformations { get { return new Array<WaveformTransformationBase>(this[nameof(Transformations)].Address); } }
    }
    public class AudioPcmEncoderSettings : AudioCodecEncoderSettings
    {
        public AudioPcmEncoderSettings(nint addr) : base(addr) { }
        public EPcmBitDepthConversion BitDepthConversion { get { return (EPcmBitDepthConversion)this[nameof(BitDepthConversion)].GetValue<int>(); } set { this[nameof(BitDepthConversion)].SetValue<int>((int)value); } }
    }
    public enum EAudioParameterType : int
    {
        None = 0,
        Boolean = 1,
        Integer = 2,
        Float = 3,
        String = 4,
        Object = 5,
        NoneArray = 6,
        BooleanArray = 7,
        IntegerArray = 8,
        FloatArray = 9,
        StringArray = 10,
        ObjectArray = 11,
        COUNT = 12,
        EAudioParameterType_MAX = 13,
    }
    public enum EPcmBitDepthConversion : int
    {
        SameAsSource = 0,
        Int16 = 1,
        Float32 = 2,
        EPcmBitDepthConversion_MAX = 3,
    }
    public class AudioParameter : Object
    {
        public AudioParameter(nint addr) : base(addr) { }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
        //public float FloatParam { get { return this[nameof(FloatParam)].GetValue<float>(); } set { this[nameof(FloatParam)].SetValue<float>(value); } }
        public bool BoolParam { get { return this[nameof(BoolParam)].Flag; } set { this[nameof(BoolParam)].Flag = value; } }
        public int IntParam { get { return this[nameof(IntParam)].GetValue<int>(); } set { this[nameof(IntParam)].SetValue<int>(value); } }
        public Object ObjectParam { get { return this[nameof(ObjectParam)].As<Object>(); } set { this["ObjectParam"] = value; } }
        public Object StringParam { get { return this[nameof(StringParam)]; } set { this[nameof(StringParam)] = value; } }
        public Array<float> ArrayFloatParam { get { return new Array<float>(this[nameof(ArrayFloatParam)].Address); } }
        public Array<bool> ArrayBoolParam { get { return new Array<bool>(this[nameof(ArrayBoolParam)].Address); } }
        public Array<int> ArrayIntParam { get { return new Array<int>(this[nameof(ArrayIntParam)].Address); } }
        public Array<Object> ArrayObjectParam { get { return new Array<Object>(this[nameof(ArrayObjectParam)].Address); } }
        public Array<Object> ArrayStringParam { get { return new Array<Object>(this[nameof(ArrayStringParam)].Address); } }
        public EAudioParameterType ParamType { get { return (EAudioParameterType)this[nameof(ParamType)].GetValue<int>(); } set { this[nameof(ParamType)].SetValue<int>((int)value); } }
        public Object TypeName { get { return this[nameof(TypeName)]; } set { this[nameof(TypeName)] = value; } }
    }
}
