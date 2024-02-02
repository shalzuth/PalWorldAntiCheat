using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.AudioMixerSDK;
using SDK.Script.AudioExtensionsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.UMGSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.SynthesisSDK
{
    public class AudioImpulseResponse : Object
    {
        public AudioImpulseResponse(nint addr) : base(addr) { }
        public Array<float> ImpulseResponse { get { return new Array<float>(this[nameof(ImpulseResponse)].Address); } }
        public int NumChannels { get { return this[nameof(NumChannels)].GetValue<int>(); } set { this[nameof(NumChannels)].SetValue<int>(value); } }
        public int SampleRate { get { return this[nameof(SampleRate)].GetValue<int>(); } set { this[nameof(SampleRate)].SetValue<int>(value); } }
        public float NormalizationVolumeDb { get { return this[nameof(NormalizationVolumeDb)].GetValue<float>(); } set { this[nameof(NormalizationVolumeDb)].SetValue<float>(value); } }
        public bool bTrueStereo { get { return this[nameof(bTrueStereo)].Flag; } set { this[nameof(bTrueStereo)].Flag = value; } }
        public Array<float> IRData { get { return new Array<float>(this[nameof(IRData)].Address); } }
    }
    public class ModularSynthPresetBank : Object
    {
        public ModularSynthPresetBank(nint addr) : base(addr) { }
        public Array<ModularSynthPresetBankEntry> Presets { get { return new Array<ModularSynthPresetBankEntry>(this[nameof(Presets)].Address); } }
    }
    public class ModularSynthLibrary : BlueprintFunctionLibrary
    {
        public ModularSynthLibrary(nint addr) : base(addr) { }
        public void AddModularSynthPresetToBankAsset(ModularSynthPresetBank InBank, ModularSynthPreset Preset, Object PresetName) { Invoke(nameof(AddModularSynthPresetToBankAsset), InBank, Preset, PresetName); }
    }
    public class ModularSynthComponent : SynthComponent
    {
        public ModularSynthComponent(nint addr) : base(addr) { }
        public int VoiceCount { get { return this[nameof(VoiceCount)].GetValue<int>(); } set { this[nameof(VoiceCount)].SetValue<int>(value); } }
        public void SetSynthPreset(ModularSynthPreset SynthPreset) { Invoke(nameof(SetSynthPreset), SynthPreset); }
        public void SetSustainGain(float SustainGain) { Invoke(nameof(SetSustainGain), SustainGain); }
        public void SetStereoDelayWetlevel(float DelayWetlevel) { Invoke(nameof(SetStereoDelayWetlevel), DelayWetlevel); }
        public void SetStereoDelayTime(float DelayTimeMsec) { Invoke(nameof(SetStereoDelayTime), DelayTimeMsec); }
        public void SetStereoDelayRatio(float DelayRatio) { Invoke(nameof(SetStereoDelayRatio), DelayRatio); }
        public void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode) { Invoke(nameof(SetStereoDelayMode), StereoDelayMode); }
        public void SetStereoDelayIsEnabled(bool StereoDelayEnabled) { Invoke(nameof(SetStereoDelayIsEnabled), StereoDelayEnabled); }
        public void SetStereoDelayFeedback(float DelayFeedback) { Invoke(nameof(SetStereoDelayFeedback), DelayFeedback); }
        public void SetSpread(float Spread) { Invoke(nameof(SetSpread), Spread); }
        public void SetReleaseTime(float ReleaseTimeMsec) { Invoke(nameof(SetReleaseTime), ReleaseTimeMsec); }
        public void SetPortamento(float Portamento) { Invoke(nameof(SetPortamento), Portamento); }
        public void SetPitchBend(float PitchBend) { Invoke(nameof(SetPitchBend), PitchBend); }
        public void SetPan(float Pan) { Invoke(nameof(SetPan), Pan); }
        public void SetOscType(int OscIndex, ESynth1OscType OscType) { Invoke(nameof(SetOscType), OscIndex, OscType); }
        public void SetOscSync(bool bIsSynced) { Invoke(nameof(SetOscSync), bIsSynced); }
        public void SetOscSemitones(int OscIndex, float Semitones) { Invoke(nameof(SetOscSemitones), OscIndex, Semitones); }
        public void SetOscPulsewidth(int OscIndex, float Pulsewidth) { Invoke(nameof(SetOscPulsewidth), OscIndex, Pulsewidth); }
        public void SetOscOctave(int OscIndex, float Octave) { Invoke(nameof(SetOscOctave), OscIndex, Octave); }
        public void SetOscGainMod(int OscIndex, float OscGainMod) { Invoke(nameof(SetOscGainMod), OscIndex, OscGainMod); }
        public void SetOscGain(int OscIndex, float OscGain) { Invoke(nameof(SetOscGain), OscIndex, OscGain); }
        public void SetOscFrequencyMod(int OscIndex, float OscFreqMod) { Invoke(nameof(SetOscFrequencyMod), OscIndex, OscFreqMod); }
        public void SetOscCents(int OscIndex, float Cents) { Invoke(nameof(SetOscCents), OscIndex, Cents); }
        public void SetModEnvSustainGain(float SustainGain) { Invoke(nameof(SetModEnvSustainGain), SustainGain); }
        public void SetModEnvReleaseTime(float Release) { Invoke(nameof(SetModEnvReleaseTime), Release); }
        public void SetModEnvPatch(ESynthModEnvPatch InPatchType) { Invoke(nameof(SetModEnvPatch), InPatchType); }
        public void SetModEnvInvert(bool bInvert) { Invoke(nameof(SetModEnvInvert), bInvert); }
        public void SetModEnvDepth(float Depth) { Invoke(nameof(SetModEnvDepth), Depth); }
        public void SetModEnvDecayTime(float DecayTimeMsec) { Invoke(nameof(SetModEnvDecayTime), DecayTimeMsec); }
        public void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType) { Invoke(nameof(SetModEnvBiasPatch), InPatchType); }
        public void SetModEnvBiasInvert(bool bInvert) { Invoke(nameof(SetModEnvBiasInvert), bInvert); }
        public void SetModEnvAttackTime(float AttackTimeMsec) { Invoke(nameof(SetModEnvAttackTime), AttackTimeMsec); }
        public void SetLFOType(int LFOIndex, ESynthLFOType LFOType) { Invoke(nameof(SetLFOType), LFOIndex, LFOType); }
        public void SetLFOPatch(int LFOIndex, ESynthLFOPatchType LFOPatchType) { Invoke(nameof(SetLFOPatch), LFOIndex, LFOPatchType); }
        public void SetLFOMode(int LFOIndex, ESynthLFOMode LFOMode) { Invoke(nameof(SetLFOMode), LFOIndex, LFOMode); }
        public void SetLFOGainMod(int LFOIndex, float GainMod) { Invoke(nameof(SetLFOGainMod), LFOIndex, GainMod); }
        public void SetLFOGain(int LFOIndex, float Gain) { Invoke(nameof(SetLFOGain), LFOIndex, Gain); }
        public void SetLFOFrequencyMod(int LFOIndex, float FrequencyModHz) { Invoke(nameof(SetLFOFrequencyMod), LFOIndex, FrequencyModHz); }
        public void SetLFOFrequency(int LFOIndex, float FrequencyHz) { Invoke(nameof(SetLFOFrequency), LFOIndex, FrequencyHz); }
        public void SetGainDb(float GainDb) { Invoke(nameof(SetGainDb), GainDb); }
        public void SetFilterType(ESynthFilterType FilterType) { Invoke(nameof(SetFilterType), FilterType); }
        public void SetFilterQMod(float FilterQ) { Invoke(nameof(SetFilterQMod), FilterQ); }
        public void SetFilterQ(float FilterQ) { Invoke(nameof(SetFilterQ), FilterQ); }
        public void SetFilterFrequencyMod(float FilterFrequencyHz) { Invoke(nameof(SetFilterFrequencyMod), FilterFrequencyHz); }
        public void SetFilterFrequency(float FilterFrequencyHz) { Invoke(nameof(SetFilterFrequency), FilterFrequencyHz); }
        public void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm) { Invoke(nameof(SetFilterAlgorithm), FilterAlgorithm); }
        public void SetEnableUnison(bool EnableUnison) { Invoke(nameof(SetEnableUnison), EnableUnison); }
        public void SetEnableRetrigger(bool RetriggerEnabled) { Invoke(nameof(SetEnableRetrigger), RetriggerEnabled); }
        public void SetEnablePolyphony(bool bEnablePolyphony) { Invoke(nameof(SetEnablePolyphony), bEnablePolyphony); }
        public bool SetEnablePatch(PatchId PatchId, bool bIsEnabled) { return Invoke<bool>(nameof(SetEnablePatch), PatchId, bIsEnabled); }
        public void SetEnableLegato(bool LegatoEnabled) { Invoke(nameof(SetEnableLegato), LegatoEnabled); }
        public void SetDecayTime(float DecayTimeMsec) { Invoke(nameof(SetDecayTime), DecayTimeMsec); }
        public void SetChorusFrequency(float Frequency) { Invoke(nameof(SetChorusFrequency), Frequency); }
        public void SetChorusFeedback(float Feedback) { Invoke(nameof(SetChorusFeedback), Feedback); }
        public void SetChorusEnabled(bool EnableChorus) { Invoke(nameof(SetChorusEnabled), EnableChorus); }
        public void SetChorusDepth(float Depth) { Invoke(nameof(SetChorusDepth), Depth); }
        public void SetAttackTime(float AttackTimeMsec) { Invoke(nameof(SetAttackTime), AttackTimeMsec); }
        public void NoteOn(float Note, int Velocity, float Duration) { Invoke(nameof(NoteOn), Note, Velocity, Duration); }
        public void NoteOff(float Note, bool bAllNotesOff, bool bKillAllNotes) { Invoke(nameof(NoteOff), Note, bAllNotesOff, bKillAllNotes); }
        public PatchId CreatePatch(ESynth1PatchSource PatchSource, Array<Synth1PatchCable> PatchCables, bool bEnableByDefault) { return Invoke<PatchId>(nameof(CreatePatch), PatchSource, PatchCables, bEnableByDefault); }
    }
    public class SourceEffectBitCrusherPreset : SoundEffectSourcePreset
    {
        public SourceEffectBitCrusherPreset(nint addr) : base(addr) { }
        public SourceEffectBitCrusherSettings Settings { get { return this[nameof(Settings)].As<SourceEffectBitCrusherSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectBitCrusherBaseSettings Settings) { Invoke(nameof(SetSettings), Settings); }
        public void SetSampleRateModulators(Object InModulators) { Invoke(nameof(SetSampleRateModulators), InModulators); }
        public void SetSampleRateModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetSampleRateModulator), Modulator); }
        public void SetSampleRate(float SampleRate) { Invoke(nameof(SetSampleRate), SampleRate); }
        public void SetModulationSettings(SourceEffectBitCrusherSettings ModulationSettings) { Invoke(nameof(SetModulationSettings), ModulationSettings); }
        public void SetBits(float Bits) { Invoke(nameof(SetBits), Bits); }
        public void SetBitModulators(Object InModulators) { Invoke(nameof(SetBitModulators), InModulators); }
        public void SetBitModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetBitModulator), Modulator); }
    }
    public class SourceEffectChorusPreset : SoundEffectSourcePreset
    {
        public SourceEffectChorusPreset(nint addr) : base(addr) { }
        public SourceEffectChorusSettings Settings { get { return this[nameof(Settings)].As<SourceEffectChorusSettings>(); } set { this["Settings"] = value; } }
        public void SetWetModulators(Object Modulators) { Invoke(nameof(SetWetModulators), Modulators); }
        public void SetWetModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetWetModulator), Modulator); }
        public void SetWet(float WetAmount) { Invoke(nameof(SetWet), WetAmount); }
        public void SetSpreadModulators(Object Modulators) { Invoke(nameof(SetSpreadModulators), Modulators); }
        public void SetSpreadModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetSpreadModulator), Modulator); }
        public void SetSpread(float Spread) { Invoke(nameof(SetSpread), Spread); }
        public void SetSettings(SourceEffectChorusBaseSettings Settings) { Invoke(nameof(SetSettings), Settings); }
        public void SetModulationSettings(SourceEffectChorusSettings ModulationSettings) { Invoke(nameof(SetModulationSettings), ModulationSettings); }
        public void SetFrequencyModulators(Object Modulators) { Invoke(nameof(SetFrequencyModulators), Modulators); }
        public void SetFrequencyModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetFrequencyModulator), Modulator); }
        public void SetFrequency(float Frequency) { Invoke(nameof(SetFrequency), Frequency); }
        public void SetFeedbackModulators(Object Modulators) { Invoke(nameof(SetFeedbackModulators), Modulators); }
        public void SetFeedbackModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetFeedbackModulator), Modulator); }
        public void SetFeedback(float Feedback) { Invoke(nameof(SetFeedback), Feedback); }
        public void SetDryModulators(Object Modulators) { Invoke(nameof(SetDryModulators), Modulators); }
        public void SetDryModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetDryModulator), Modulator); }
        public void SetDry(float DryAmount) { Invoke(nameof(SetDry), DryAmount); }
        public void SetDepthModulators(Object Modulators) { Invoke(nameof(SetDepthModulators), Modulators); }
        public void SetDepthModulator(SoundModulatorBase Modulator) { Invoke(nameof(SetDepthModulator), Modulator); }
        public void SetDepth(float Depth) { Invoke(nameof(SetDepth), Depth); }
    }
    public class SourceEffectConvolutionReverbPreset : SoundEffectSourcePreset
    {
        public SourceEffectConvolutionReverbPreset(nint addr) : base(addr) { }
        public AudioImpulseResponse ImpulseResponse { get { return this[nameof(ImpulseResponse)].As<AudioImpulseResponse>(); } set { this["ImpulseResponse"] = value; } }
        public SourceEffectConvolutionReverbSettings Settings { get { return this[nameof(Settings)].As<SourceEffectConvolutionReverbSettings>(); } set { this["Settings"] = value; } }
        public ESubmixEffectConvolutionReverbBlockSize blockSize { get { return (ESubmixEffectConvolutionReverbBlockSize)this[nameof(blockSize)].GetValue<int>(); } set { this[nameof(blockSize)].SetValue<int>((int)value); } }
        public bool bEnableHardwareAcceleration { get { return this[nameof(bEnableHardwareAcceleration)].Flag; } set { this[nameof(bEnableHardwareAcceleration)].Flag = value; } }
        public void SetSettings(SourceEffectConvolutionReverbSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetImpulseResponse(AudioImpulseResponse InImpulseResponse) { Invoke(nameof(SetImpulseResponse), InImpulseResponse); }
    }
    public class SourceEffectDynamicsProcessorPreset : SoundEffectSourcePreset
    {
        public SourceEffectDynamicsProcessorPreset(nint addr) : base(addr) { }
        public SourceEffectDynamicsProcessorSettings Settings { get { return this[nameof(Settings)].As<SourceEffectDynamicsProcessorSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectDynamicsProcessorSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class EnvelopeFollowerListener : ActorComponent
    {
        public EnvelopeFollowerListener(nint addr) : base(addr) { }
        public Object OnEnvelopeFollowerUpdate { get { return this[nameof(OnEnvelopeFollowerUpdate)]; } set { this[nameof(OnEnvelopeFollowerUpdate)] = value; } }
    }
    public class SourceEffectEnvelopeFollowerPreset : SoundEffectSourcePreset
    {
        public SourceEffectEnvelopeFollowerPreset(nint addr) : base(addr) { }
        public SourceEffectEnvelopeFollowerSettings Settings { get { return this[nameof(Settings)].As<SourceEffectEnvelopeFollowerSettings>(); } set { this["Settings"] = value; } }
        public void UnregisterEnvelopeFollowerListener(EnvelopeFollowerListener EnvelopeFollowerListener) { Invoke(nameof(UnregisterEnvelopeFollowerListener), EnvelopeFollowerListener); }
        public void SetSettings(SourceEffectEnvelopeFollowerSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void RegisterEnvelopeFollowerListener(EnvelopeFollowerListener EnvelopeFollowerListener) { Invoke(nameof(RegisterEnvelopeFollowerListener), EnvelopeFollowerListener); }
    }
    public class SourceEffectEQPreset : SoundEffectSourcePreset
    {
        public SourceEffectEQPreset(nint addr) : base(addr) { }
        public SourceEffectEQSettings Settings { get { return this[nameof(Settings)].As<SourceEffectEQSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectEQSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectFilterPreset : SoundEffectSourcePreset
    {
        public SourceEffectFilterPreset(nint addr) : base(addr) { }
        public SourceEffectFilterSettings Settings { get { return this[nameof(Settings)].As<SourceEffectFilterSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectFilterSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectFoldbackDistortionPreset : SoundEffectSourcePreset
    {
        public SourceEffectFoldbackDistortionPreset(nint addr) : base(addr) { }
        public SourceEffectFoldbackDistortionSettings Settings { get { return this[nameof(Settings)].As<SourceEffectFoldbackDistortionSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectFoldbackDistortionSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectMidSideSpreaderPreset : SoundEffectSourcePreset
    {
        public SourceEffectMidSideSpreaderPreset(nint addr) : base(addr) { }
        public SourceEffectMidSideSpreaderSettings Settings { get { return this[nameof(Settings)].As<SourceEffectMidSideSpreaderSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectMidSideSpreaderSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectMotionFilterPreset : SoundEffectSourcePreset
    {
        public SourceEffectMotionFilterPreset(nint addr) : base(addr) { }
        public SourceEffectMotionFilterSettings Settings { get { return this[nameof(Settings)].As<SourceEffectMotionFilterSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectMotionFilterSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectPannerPreset : SoundEffectSourcePreset
    {
        public SourceEffectPannerPreset(nint addr) : base(addr) { }
        public SourceEffectPannerSettings Settings { get { return this[nameof(Settings)].As<SourceEffectPannerSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectPannerSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectPhaserPreset : SoundEffectSourcePreset
    {
        public SourceEffectPhaserPreset(nint addr) : base(addr) { }
        public SourceEffectPhaserSettings Settings { get { return this[nameof(Settings)].As<SourceEffectPhaserSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectPhaserSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectRingModulationPreset : SoundEffectSourcePreset
    {
        public SourceEffectRingModulationPreset(nint addr) : base(addr) { }
        public SourceEffectRingModulationSettings Settings { get { return this[nameof(Settings)].As<SourceEffectRingModulationSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectRingModulationSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectSimpleDelayPreset : SoundEffectSourcePreset
    {
        public SourceEffectSimpleDelayPreset(nint addr) : base(addr) { }
        public SourceEffectSimpleDelaySettings Settings { get { return this[nameof(Settings)].As<SourceEffectSimpleDelaySettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectSimpleDelaySettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectStereoDelayPreset : SoundEffectSourcePreset
    {
        public SourceEffectStereoDelayPreset(nint addr) : base(addr) { }
        public SourceEffectStereoDelaySettings Settings { get { return this[nameof(Settings)].As<SourceEffectStereoDelaySettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectStereoDelaySettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SourceEffectWaveShaperPreset : SoundEffectSourcePreset
    {
        public SourceEffectWaveShaperPreset(nint addr) : base(addr) { }
        public SourceEffectWaveShaperSettings Settings { get { return this[nameof(Settings)].As<SourceEffectWaveShaperSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SourceEffectWaveShaperSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SubmixEffectConvolutionReverbPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectConvolutionReverbPreset(nint addr) : base(addr) { }
        public AudioImpulseResponse ImpulseResponse { get { return this[nameof(ImpulseResponse)].As<AudioImpulseResponse>(); } set { this["ImpulseResponse"] = value; } }
        public SubmixEffectConvolutionReverbSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectConvolutionReverbSettings>(); } set { this["Settings"] = value; } }
        public ESubmixEffectConvolutionReverbBlockSize blockSize { get { return (ESubmixEffectConvolutionReverbBlockSize)this[nameof(blockSize)].GetValue<int>(); } set { this[nameof(blockSize)].SetValue<int>((int)value); } }
        public bool bEnableHardwareAcceleration { get { return this[nameof(bEnableHardwareAcceleration)].Flag; } set { this[nameof(bEnableHardwareAcceleration)].Flag = value; } }
        public void SetSettings(SubmixEffectConvolutionReverbSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetImpulseResponse(AudioImpulseResponse InImpulseResponse) { Invoke(nameof(SetImpulseResponse), InImpulseResponse); }
    }
    public class SubmixEffectDelayStatics : BlueprintFunctionLibrary
    {
        public SubmixEffectDelayStatics(nint addr) : base(addr) { }
        public SubmixEffectDelaySettings SetMaximumDelayLength(SubmixEffectDelaySettings DelaySettings, float MaximumDelayLength) { return Invoke<SubmixEffectDelaySettings>(nameof(SetMaximumDelayLength), DelaySettings, MaximumDelayLength); }
        public SubmixEffectDelaySettings SetInterpolationTime(SubmixEffectDelaySettings DelaySettings, float InterpolationTime) { return Invoke<SubmixEffectDelaySettings>(nameof(SetInterpolationTime), DelaySettings, InterpolationTime); }
        public SubmixEffectDelaySettings SetDelayLength(SubmixEffectDelaySettings DelaySettings, float DelayLength) { return Invoke<SubmixEffectDelaySettings>(nameof(SetDelayLength), DelaySettings, DelayLength); }
    }
    public class SubmixEffectDelayPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectDelayPreset(nint addr) : base(addr) { }
        public SubmixEffectDelaySettings Settings { get { return this[nameof(Settings)].As<SubmixEffectDelaySettings>(); } set { this["Settings"] = value; } }
        public SubmixEffectDelaySettings DynamicSettings { get { return this[nameof(DynamicSettings)].As<SubmixEffectDelaySettings>(); } set { this["DynamicSettings"] = value; } }
        public void SetSettings(SubmixEffectDelaySettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetInterpolationTime(float Time) { Invoke(nameof(SetInterpolationTime), Time); }
        public void SetDelay(float Length) { Invoke(nameof(SetDelay), Length); }
        public void SetDefaultSettings(SubmixEffectDelaySettings InSettings) { Invoke(nameof(SetDefaultSettings), InSettings); }
        public float GetMaxDelayInMilliseconds() { return Invoke<float>(nameof(GetMaxDelayInMilliseconds)); }
    }
    public class SubmixEffectFilterPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectFilterPreset(nint addr) : base(addr) { }
        public SubmixEffectFilterSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectFilterSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectFilterSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetFilterType(ESubmixFilterType InType) { Invoke(nameof(SetFilterType), InType); }
        public void SetFilterQMod(float InQ) { Invoke(nameof(SetFilterQMod), InQ); }
        public void SetFilterQ(float InQ) { Invoke(nameof(SetFilterQ), InQ); }
        public void SetFilterCutoffFrequencyMod(float InFrequency) { Invoke(nameof(SetFilterCutoffFrequencyMod), InFrequency); }
        public void SetFilterCutoffFrequency(float InFrequency) { Invoke(nameof(SetFilterCutoffFrequency), InFrequency); }
        public void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm) { Invoke(nameof(SetFilterAlgorithm), InAlgorithm); }
    }
    public class SubmixEffectFlexiverbPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectFlexiverbPreset(nint addr) : base(addr) { }
        public SubmixEffectFlexiverbSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectFlexiverbSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectFlexiverbSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SubmixEffectMultibandCompressorPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectMultibandCompressorPreset(nint addr) : base(addr) { }
        public SubmixEffectMultibandCompressorSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectMultibandCompressorSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectMultibandCompressorSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetExternalSubmix(SoundSubmix Submix) { Invoke(nameof(SetExternalSubmix), Submix); }
        public void SetAudioBus(AudioBus AudioBus) { Invoke(nameof(SetAudioBus), AudioBus); }
        public void ResetKey() { Invoke(nameof(ResetKey)); }
    }
    public class SubmixEffectStereoDelayPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectStereoDelayPreset(nint addr) : base(addr) { }
        public SubmixEffectStereoDelaySettings Settings { get { return this[nameof(Settings)].As<SubmixEffectStereoDelaySettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectStereoDelaySettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SubmixEffectTapDelayPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectTapDelayPreset(nint addr) : base(addr) { }
        public SubmixEffectTapDelaySettings Settings { get { return this[nameof(Settings)].As<SubmixEffectTapDelaySettings>(); } set { this["Settings"] = value; } }
        public void SetTap(int TapId, TapDelayInfo TapInfo) { Invoke(nameof(SetTap), TapId, TapInfo); }
        public void SetSettings(SubmixEffectTapDelaySettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetInterpolationTime(float Time) { Invoke(nameof(SetInterpolationTime), Time); }
        public void RemoveTap(int TapId) { Invoke(nameof(RemoveTap), TapId); }
        public void GetTapIds(Array<int> TapIds) { Invoke(nameof(GetTapIds), TapIds); }
        public void GetTap(int TapId, TapDelayInfo TapInfo) { Invoke(nameof(GetTap), TapId, TapInfo); }
        public float GetMaxDelayInMilliseconds() { return Invoke<float>(nameof(GetMaxDelayInMilliseconds)); }
        public void AddTap(int TapId) { Invoke(nameof(AddTap), TapId); }
    }
    public class GranularSynth : SynthComponent
    {
        public GranularSynth(nint addr) : base(addr) { }
        public SoundWave GranulatedSoundWave { get { return this[nameof(GranulatedSoundWave)].As<SoundWave>(); } set { this["GranulatedSoundWave"] = value; } }
        public void SetSustainGain(float SustainGain) { Invoke(nameof(SetSustainGain), SustainGain); }
        public void SetSoundWave(SoundWave InSoundWave) { Invoke(nameof(SetSoundWave), InSoundWave); }
        public void SetScrubMode(bool bScrubMode) { Invoke(nameof(SetScrubMode), bScrubMode); }
        public void SetReleaseTimeMsec(float ReleaseTimeMsec) { Invoke(nameof(SetReleaseTimeMsec), ReleaseTimeMsec); }
        public void SetPlayheadTime(float InPositionSec, float LerpTimeSec, EGranularSynthSeekType SeekType) { Invoke(nameof(SetPlayheadTime), InPositionSec, LerpTimeSec, SeekType); }
        public void SetPlaybackSpeed(float InPlayheadRate) { Invoke(nameof(SetPlaybackSpeed), InPlayheadRate); }
        public void SetGrainVolume(float BaseVolume, Vector2D VolumeRange) { Invoke(nameof(SetGrainVolume), BaseVolume, VolumeRange); }
        public void SetGrainsPerSecond(float InGrainsPerSecond) { Invoke(nameof(SetGrainsPerSecond), InGrainsPerSecond); }
        public void SetGrainProbability(float InGrainProbability) { Invoke(nameof(SetGrainProbability), InGrainProbability); }
        public void SetGrainPitch(float BasePitch, Vector2D PitchRange) { Invoke(nameof(SetGrainPitch), BasePitch, PitchRange); }
        public void SetGrainPan(float BasePan, Vector2D PanRange) { Invoke(nameof(SetGrainPan), BasePan, PanRange); }
        public void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType) { Invoke(nameof(SetGrainEnvelopeType), EnvelopeType); }
        public void SetGrainDuration(float BaseDurationMsec, Vector2D DurationRange) { Invoke(nameof(SetGrainDuration), BaseDurationMsec, DurationRange); }
        public void SetDecayTime(float DecayTimeMsec) { Invoke(nameof(SetDecayTime), DecayTimeMsec); }
        public void SetAttackTime(float AttackTimeMsec) { Invoke(nameof(SetAttackTime), AttackTimeMsec); }
        public void NoteOn(float Note, int Velocity, float Duration) { Invoke(nameof(NoteOn), Note, Velocity, Duration); }
        public void NoteOff(float Note, bool bKill) { Invoke(nameof(NoteOff), Note, bKill); }
        public bool IsLoaded() { return Invoke<bool>(nameof(IsLoaded)); }
        public float GetSampleDuration() { return Invoke<float>(nameof(GetSampleDuration)); }
        public float GetCurrentPlayheadTime() { return Invoke<float>(nameof(GetCurrentPlayheadTime)); }
    }
    public class MonoWaveTableSynthPreset : Object
    {
        public MonoWaveTableSynthPreset(nint addr) : base(addr) { }
        public Object PresetName { get { return this[nameof(PresetName)]; } set { this[nameof(PresetName)] = value; } }
        public bool bLockKeyframesToGridBool { get { return this[nameof(bLockKeyframesToGridBool)].Flag; } set { this[nameof(bLockKeyframesToGridBool)].Flag = value; } }
        public int LockKeyframesToGrid { get { return this[nameof(LockKeyframesToGrid)].GetValue<int>(); } set { this[nameof(LockKeyframesToGrid)].SetValue<int>(value); } }
        public int WaveTableResolution { get { return this[nameof(WaveTableResolution)].GetValue<int>(); } set { this[nameof(WaveTableResolution)].SetValue<int>(value); } }
        public Array<RuntimeFloatCurve> WaveTable { get { return new Array<RuntimeFloatCurve>(this[nameof(WaveTable)].Address); } }
        public bool bNormalizeWaveTables { get { return this[nameof(bNormalizeWaveTables)].Flag; } set { this[nameof(bNormalizeWaveTables)].Flag = value; } }
    }
    public class SynthComponentMonoWaveTable : SynthComponent
    {
        public SynthComponentMonoWaveTable(nint addr) : base(addr) { }
        public Object OnTableAltered { get { return this[nameof(OnTableAltered)]; } set { this[nameof(OnTableAltered)] = value; } }
        public Object OnNumTablesChanged { get { return this[nameof(OnNumTablesChanged)]; } set { this[nameof(OnNumTablesChanged)] = value; } }
        public MonoWaveTableSynthPreset CurrentPreset { get { return this[nameof(CurrentPreset)].As<MonoWaveTableSynthPreset>(); } set { this["CurrentPreset"] = value; } }
        public void SetWaveTablePosition(float InPosition) { Invoke(nameof(SetWaveTablePosition), InPosition); }
        public void SetSustainPedalState(bool InSustainPedalState) { Invoke(nameof(SetSustainPedalState), InSustainPedalState); }
        public void SetPosLfoType(ESynthLFOType InLfoType) { Invoke(nameof(SetPosLfoType), InLfoType); }
        public void SetPosLfoFrequency(float InLfoFrequency) { Invoke(nameof(SetPosLfoFrequency), InLfoFrequency); }
        public void SetPosLfoDepth(float InLfoDepth) { Invoke(nameof(SetPosLfoDepth), InLfoDepth); }
        public void SetPositionEnvelopeSustainGain(float InSustainGain) { Invoke(nameof(SetPositionEnvelopeSustainGain), InSustainGain); }
        public void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec) { Invoke(nameof(SetPositionEnvelopeReleaseTime), InReleaseTimeMsec); }
        public void SetPositionEnvelopeInvert(bool bInInvert) { Invoke(nameof(SetPositionEnvelopeInvert), bInInvert); }
        public void SetPositionEnvelopeDepth(float InDepth) { Invoke(nameof(SetPositionEnvelopeDepth), InDepth); }
        public void SetPositionEnvelopeDecayTime(float InDecayTimeMsec) { Invoke(nameof(SetPositionEnvelopeDecayTime), InDecayTimeMsec); }
        public void SetPositionEnvelopeBiasInvert(bool bInBiasInvert) { Invoke(nameof(SetPositionEnvelopeBiasInvert), bInBiasInvert); }
        public void SetPositionEnvelopeBiasDepth(float InDepth) { Invoke(nameof(SetPositionEnvelopeBiasDepth), InDepth); }
        public void SetPositionEnvelopeAttackTime(float InAttackTimeMsec) { Invoke(nameof(SetPositionEnvelopeAttackTime), InAttackTimeMsec); }
        public void SetLowPassFilterResonance(float InNewQ) { Invoke(nameof(SetLowPassFilterResonance), InNewQ); }
        public void SetFrequencyWithMidiNote(float InMidiNote) { Invoke(nameof(SetFrequencyWithMidiNote), InMidiNote); }
        public void SetFrequencyPitchBend(float FrequencyOffsetCents) { Invoke(nameof(SetFrequencyPitchBend), FrequencyOffsetCents); }
        public void SetFrequency(float FrequencyHz) { Invoke(nameof(SetFrequency), FrequencyHz); }
        public void SetFilterEnvelopeSustainGain(float InSustainGain) { Invoke(nameof(SetFilterEnvelopeSustainGain), InSustainGain); }
        public void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec) { Invoke(nameof(SetFilterEnvelopeReleaseTime), InReleaseTimeMsec); }
        public void SetFilterEnvelopenDecayTime(float InDecayTimeMsec) { Invoke(nameof(SetFilterEnvelopenDecayTime), InDecayTimeMsec); }
        public void SetFilterEnvelopeInvert(bool bInInvert) { Invoke(nameof(SetFilterEnvelopeInvert), bInInvert); }
        public void SetFilterEnvelopeDepth(float InDepth) { Invoke(nameof(SetFilterEnvelopeDepth), InDepth); }
        public void SetFilterEnvelopeBiasInvert(bool bInBiasInvert) { Invoke(nameof(SetFilterEnvelopeBiasInvert), bInBiasInvert); }
        public void SetFilterEnvelopeBiasDepth(float InDepth) { Invoke(nameof(SetFilterEnvelopeBiasDepth), InDepth); }
        public void SetFilterEnvelopeAttackTime(float InAttackTimeMsec) { Invoke(nameof(SetFilterEnvelopeAttackTime), InAttackTimeMsec); }
        public bool SetCurveValue(int TableIndex, int KeyframeIndex, float NewValue) { return Invoke<bool>(nameof(SetCurveValue), TableIndex, KeyframeIndex, NewValue); }
        public bool SetCurveTangent(int TableIndex, float InNewTangent) { return Invoke<bool>(nameof(SetCurveTangent), TableIndex, InNewTangent); }
        public bool SetCurveInterpolationType(CurveInterpolationType InterpolationType, int TableIndex) { return Invoke<bool>(nameof(SetCurveInterpolationType), InterpolationType, TableIndex); }
        public void SetAmpEnvelopeSustainGain(float InSustainGain) { Invoke(nameof(SetAmpEnvelopeSustainGain), InSustainGain); }
        public void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec) { Invoke(nameof(SetAmpEnvelopeReleaseTime), InReleaseTimeMsec); }
        public void SetAmpEnvelopeInvert(bool bInInvert) { Invoke(nameof(SetAmpEnvelopeInvert), bInInvert); }
        public void SetAmpEnvelopeDepth(float InDepth) { Invoke(nameof(SetAmpEnvelopeDepth), InDepth); }
        public void SetAmpEnvelopeDecayTime(float InDecayTimeMsec) { Invoke(nameof(SetAmpEnvelopeDecayTime), InDecayTimeMsec); }
        public void SetAmpEnvelopeBiasInvert(bool bInBiasInvert) { Invoke(nameof(SetAmpEnvelopeBiasInvert), bInBiasInvert); }
        public void SetAmpEnvelopeBiasDepth(float InDepth) { Invoke(nameof(SetAmpEnvelopeBiasDepth), InDepth); }
        public void SetAmpEnvelopeAttackTime(float InAttackTimeMsec) { Invoke(nameof(SetAmpEnvelopeAttackTime), InAttackTimeMsec); }
        public void RefreshWaveTable(int Index) { Invoke(nameof(RefreshWaveTable), Index); }
        public void RefreshAllWaveTables() { Invoke(nameof(RefreshAllWaveTables)); }
        public void NoteOn(float InMidiNote, float InVelocity) { Invoke(nameof(NoteOn), InMidiNote, InVelocity); }
        public void NoteOff(float InMidiNote) { Invoke(nameof(NoteOff), InMidiNote); }
        public int GetNumTableEntries() { return Invoke<int>(nameof(GetNumTableEntries)); }
        public int GetMaxTableIndex() { return Invoke<int>(nameof(GetMaxTableIndex)); }
        public Array<float> GetKeyFrameValuesForTable(float TableIndex) { return Invoke<Array<float>>(nameof(GetKeyFrameValuesForTable), TableIndex); }
        public float GetCurveTangent(int TableIndex) { return Invoke<float>(nameof(GetCurveTangent), TableIndex); }
    }
    public class SynthComponentToneGenerator : SynthComponent
    {
        public SynthComponentToneGenerator(nint addr) : base(addr) { }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Volume { get { return this[nameof(Volume)].GetValue<float>(); } set { this[nameof(Volume)].SetValue<float>(value); } }
        public RuntimeFloatCurve DistanceAttenuationCurve { get { return this[nameof(DistanceAttenuationCurve)].As<RuntimeFloatCurve>(); } set { this["DistanceAttenuationCurve"] = value; } }
        public Vector2D DistanceRange { get { return this[nameof(DistanceRange)].As<Vector2D>(); } set { this["DistanceRange"] = value; } }
        public float AttenuationDbAtMaxRange { get { return this[nameof(AttenuationDbAtMaxRange)].GetValue<float>(); } set { this[nameof(AttenuationDbAtMaxRange)].SetValue<float>(value); } }
        public void SetVolume(float InVolume) { Invoke(nameof(SetVolume), InVolume); }
        public void SetFrequency(float InFrequency) { Invoke(nameof(SetFrequency), InFrequency); }
    }
    public class SynthSamplePlayer : SynthComponent
    {
        public SynthSamplePlayer(nint addr) : base(addr) { }
        public SoundWave SoundWave { get { return this[nameof(SoundWave)].As<SoundWave>(); } set { this["SoundWave"] = value; } }
        public Object OnSampleLoaded { get { return this[nameof(OnSampleLoaded)]; } set { this[nameof(OnSampleLoaded)] = value; } }
        public Object OnSamplePlaybackProgress { get { return this[nameof(OnSamplePlaybackProgress)]; } set { this[nameof(OnSamplePlaybackProgress)] = value; } }
        public void SetSoundWave(SoundWave InSoundWave) { Invoke(nameof(SetSoundWave), InSoundWave); }
        public void SetScrubTimeWidth(float InScrubTimeWidthSec) { Invoke(nameof(SetScrubTimeWidth), InScrubTimeWidthSec); }
        public void SetScrubMode(bool bScrubMode) { Invoke(nameof(SetScrubMode), bScrubMode); }
        public void SetPitch(float InPitch, float TimeSec) { Invoke(nameof(SetPitch), InPitch, TimeSec); }
        public void SeekToTime(float TimeSec, ESamplePlayerSeekType SeekType, bool bWrap) { Invoke(nameof(SeekToTime), TimeSec, SeekType, bWrap); }
        public bool IsLoaded() { return Invoke<bool>(nameof(IsLoaded)); }
        public float GetSampleDuration() { return Invoke<float>(nameof(GetSampleDuration)); }
        public float GetCurrentPlaybackProgressTime() { return Invoke<float>(nameof(GetCurrentPlaybackProgressTime)); }
        public float GetCurrentPlaybackProgressPercent() { return Invoke<float>(nameof(GetCurrentPlaybackProgressPercent)); }
    }
    public class SynthesisUtilitiesBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public SynthesisUtilitiesBlueprintFunctionLibrary(nint addr) : base(addr) { }
        public float GetLogFrequency(float InLinearValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax) { return Invoke<float>(nameof(GetLogFrequency), InLinearValue, InDomainMin, InDomainMax, InRangeMin, InRangeMax); }
        public float GetLinearFrequency(float InLogFrequencyValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax) { return Invoke<float>(nameof(GetLinearFrequency), InLogFrequencyValue, InDomainMin, InDomainMax, InRangeMin, InRangeMax); }
    }
    public class Synth2DSlider : Widget
    {
        public Synth2DSlider(nint addr) : base(addr) { }
        public float ValueX { get { return this[nameof(ValueX)].GetValue<float>(); } set { this[nameof(ValueX)].SetValue<float>(value); } }
        public float ValueY { get { return this[nameof(ValueY)].GetValue<float>(); } set { this[nameof(ValueY)].SetValue<float>(value); } }
        public Object ValueXDelegate { get { return this[nameof(ValueXDelegate)]; } set { this[nameof(ValueXDelegate)] = value; } }
        public Object ValueYDelegate { get { return this[nameof(ValueYDelegate)]; } set { this[nameof(ValueYDelegate)] = value; } }
        public Synth2DSliderStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<Synth2DSliderStyle>(); } set { this["WidgetStyle"] = value; } }
        public LinearColor SliderHandleColor { get { return this[nameof(SliderHandleColor)].As<LinearColor>(); } set { this["SliderHandleColor"] = value; } }
        public bool IndentHandle { get { return this[nameof(IndentHandle)].Flag; } set { this[nameof(IndentHandle)].Flag = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public Object OnMouseCaptureBegin { get { return this[nameof(OnMouseCaptureBegin)]; } set { this[nameof(OnMouseCaptureBegin)] = value; } }
        public Object OnMouseCaptureEnd { get { return this[nameof(OnMouseCaptureEnd)]; } set { this[nameof(OnMouseCaptureEnd)] = value; } }
        public Object OnControllerCaptureBegin { get { return this[nameof(OnControllerCaptureBegin)]; } set { this[nameof(OnControllerCaptureBegin)] = value; } }
        public Object OnControllerCaptureEnd { get { return this[nameof(OnControllerCaptureEnd)]; } set { this[nameof(OnControllerCaptureEnd)] = value; } }
        public Object OnValueChangedX { get { return this[nameof(OnValueChangedX)]; } set { this[nameof(OnValueChangedX)] = value; } }
        public Object OnValueChangedY { get { return this[nameof(OnValueChangedY)]; } set { this[nameof(OnValueChangedY)] = value; } }
        public void SetValue(Vector2D InValue) { Invoke(nameof(SetValue), InValue); }
        public void SetStepSize(float InValue) { Invoke(nameof(SetStepSize), InValue); }
        public void SetSliderHandleColor(LinearColor InValue) { Invoke(nameof(SetSliderHandleColor), InValue); }
        public void SetLocked(bool InValue) { Invoke(nameof(SetLocked), InValue); }
        public void SetIndentHandle(bool InValue) { Invoke(nameof(SetIndentHandle), InValue); }
        public Vector2D GetValue() { return Invoke<Vector2D>(nameof(GetValue)); }
    }
    public class SynthKnob : Widget
    {
        public SynthKnob(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public float MouseSpeed { get { return this[nameof(MouseSpeed)].GetValue<float>(); } set { this[nameof(MouseSpeed)].SetValue<float>(value); } }
        public float MouseFineTuneSpeed { get { return this[nameof(MouseFineTuneSpeed)].GetValue<float>(); } set { this[nameof(MouseFineTuneSpeed)].SetValue<float>(value); } }
        public bool ShowTooltipInfo { get { return this[nameof(ShowTooltipInfo)].Flag; } set { this[nameof(ShowTooltipInfo)].Flag = value; } }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public Object ParameterUnits { get { return this[nameof(ParameterUnits)]; } set { this[nameof(ParameterUnits)] = value; } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public SynthKnobStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SynthKnobStyle>(); } set { this["WidgetStyle"] = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public Object OnMouseCaptureBegin { get { return this[nameof(OnMouseCaptureBegin)]; } set { this[nameof(OnMouseCaptureBegin)] = value; } }
        public Object OnMouseCaptureEnd { get { return this[nameof(OnMouseCaptureEnd)]; } set { this[nameof(OnMouseCaptureEnd)] = value; } }
        public Object OnControllerCaptureBegin { get { return this[nameof(OnControllerCaptureBegin)]; } set { this[nameof(OnControllerCaptureBegin)] = value; } }
        public Object OnControllerCaptureEnd { get { return this[nameof(OnControllerCaptureEnd)]; } set { this[nameof(OnControllerCaptureEnd)] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public void SetValue(float InValue) { Invoke(nameof(SetValue), InValue); }
        public void SetStepSize(float InValue) { Invoke(nameof(SetStepSize), InValue); }
        public void SetLocked(bool InValue) { Invoke(nameof(SetLocked), InValue); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
    }
    public enum ESynth1OscType : int
    {
        Sine = 0,
        Saw = 1,
        Triangle = 2,
        Square = 3,
        Noise = 4,
        Count = 5,
        ESynth1OscType_MAX = 6,
    }
    public enum ESynthLFOType : int
    {
        Sine = 0,
        UpSaw = 1,
        DownSaw = 2,
        Square = 3,
        Triangle = 4,
        Exponential = 5,
        RandomSampleHold = 6,
        Count = 7,
        ESynthLFOType_MAX = 8,
    }
    public enum ESynthLFOMode : int
    {
        Sync = 0,
        OneShot = 1,
        Free = 2,
        Count = 3,
        ESynthLFOMode_MAX = 4,
    }
    public enum ESynthLFOPatchType : int
    {
        PatchToNone = 0,
        PatchToGain = 1,
        PatchToOscFreq = 2,
        PatchToFilterFreq = 3,
        PatchToFilterQ = 4,
        PatchToOscPulseWidth = 5,
        PatchToOscPan = 6,
        PatchLFO1ToLFO2Frequency = 7,
        PatchLFO1ToLFO2Gain = 8,
        Count = 9,
        ESynthLFOPatchType_MAX = 10,
    }
    public enum ESynthModEnvPatch : int
    {
        PatchToNone = 0,
        PatchToOscFreq = 1,
        PatchToFilterFreq = 2,
        PatchToFilterQ = 3,
        PatchToLFO1Gain = 4,
        PatchToLFO2Gain = 5,
        PatchToLFO1Freq = 6,
        PatchToLFO2Freq = 7,
        Count = 8,
        ESynthModEnvPatch_MAX = 9,
    }
    public enum ESynthModEnvBiasPatch : int
    {
        PatchToNone = 0,
        PatchToOscFreq = 1,
        PatchToFilterFreq = 2,
        PatchToFilterQ = 3,
        PatchToLFO1Gain = 4,
        PatchToLFO2Gain = 5,
        PatchToLFO1Freq = 6,
        PatchToLFO2Freq = 7,
        Count = 8,
        ESynthModEnvBiasPatch_MAX = 9,
    }
    public enum ESynthFilterType : int
    {
        LowPass = 0,
        HighPass = 1,
        BandPass = 2,
        BandStop = 3,
        Count = 4,
        ESynthFilterType_MAX = 5,
    }
    public enum ESynthFilterAlgorithm : int
    {
        OnePole = 0,
        StateVariable = 1,
        Ladder = 2,
        Count = 3,
        ESynthFilterAlgorithm_MAX = 4,
    }
    public enum ESynthStereoDelayMode : int
    {
        Normal = 0,
        Cross = 1,
        PingPong = 2,
        Count = 3,
        ESynthStereoDelayMode_MAX = 4,
    }
    public enum ESynth1PatchSource : int
    {
        LFO1 = 0,
        LFO2 = 1,
        Envelope = 2,
        BiasEnvelope = 3,
        Count = 4,
        ESynth1PatchSource_MAX = 5,
    }
    public enum ESynth1PatchDestination : int
    {
        Osc1Gain = 0,
        Osc1Frequency = 1,
        Osc1Pulsewidth = 2,
        Osc2Gain = 3,
        Osc2Frequency = 4,
        Osc2Pulsewidth = 5,
        FilterFrequency = 6,
        FilterQ = 7,
        Gain = 8,
        Pan = 9,
        LFO1Frequency = 10,
        LFO1Gain = 11,
        LFO2Frequency = 12,
        LFO2Gain = 13,
        Count = 14,
        ESynth1PatchDestination_MAX = 15,
    }
    public enum ESubmixEffectConvolutionReverbBlockSize : int
    {
        BlockSize256 = 0,
        BlockSize512 = 1,
        BlockSize1024 = 2,
        ESubmixEffectConvolutionReverbBlockSize_MAX = 3,
    }
    public enum ESourceEffectDynamicsProcessorType : int
    {
        Compressor = 0,
        Limiter = 1,
        Expander = 2,
        Gate = 3,
        UpwardsCompressor = 4,
        Count = 5,
        ESourceEffectDynamicsProcessorType_MAX = 6,
    }
    public enum ESourceEffectDynamicsPeakMode : int
    {
        MeanSquared = 0,
        RootMeanSquared = 1,
        Peak = 2,
        Count = 3,
        ESourceEffectDynamicsPeakMode_MAX = 4,
    }
    public enum EEnvelopeFollowerPeakMode : int
    {
        MeanSquared = 0,
        RootMeanSquared = 1,
        Peak = 2,
        Count = 3,
        EEnvelopeFollowerPeakMode_MAX = 4,
    }
    public enum ESourceEffectFilterCircuit : int
    {
        OnePole = 0,
        StateVariable = 1,
        Ladder = 2,
        Count = 3,
        ESourceEffectFilterCircuit_MAX = 4,
    }
    public enum ESourceEffectFilterType : int
    {
        LowPass = 0,
        HighPass = 1,
        BandPass = 2,
        BandStop = 3,
        Count = 4,
        ESourceEffectFilterType_MAX = 5,
    }
    public enum ESourceEffectFilterParam : int
    {
        FilterFrequency = 0,
        FilterResonance = 1,
        Count = 2,
        ESourceEffectFilterParam_MAX = 3,
    }
    public enum EStereoChannelMode : int
    {
        MidSide = 0,
        LeftRight = 1,
        count = 2,
        EStereoChannelMode_MAX = 3,
    }
    public enum ESourceEffectMotionFilterModSource : int
    {
        DistanceFromListener = 0,
        SpeedRelativeToListener = 1,
        SpeedOfSourceEmitter = 2,
        SpeedOfListener = 3,
        SpeedOfAngleDelta = 4,
        Count = 5,
        ESourceEffectMotionFilterModSource_MAX = 6,
    }
    public enum ESourceEffectMotionFilterModDestination : int
    {
        FilterACutoffFrequency = 0,
        FilterAResonance = 1,
        FilterAOutputVolumeDB = 2,
        FilterBCutoffFrequency = 3,
        FilterBResonance = 4,
        FilterBOutputVolumeDB = 5,
        FilterMix = 6,
        Count = 7,
        ESourceEffectMotionFilterModDestination_MAX = 8,
    }
    public enum ESourceEffectMotionFilterTopology : int
    {
        SerialMode = 0,
        ParallelMode = 1,
        Count = 2,
        ESourceEffectMotionFilterTopology_MAX = 3,
    }
    public enum ESourceEffectMotionFilterCircuit : int
    {
        OnePole = 0,
        StateVariable = 1,
        Ladder = 2,
        Count = 3,
        ESourceEffectMotionFilterCircuit_MAX = 4,
    }
    public enum ESourceEffectMotionFilterType : int
    {
        LowPass = 0,
        HighPass = 1,
        BandPass = 2,
        BandStop = 3,
        Count = 4,
        ESourceEffectMotionFilterType_MAX = 5,
    }
    public enum EPhaserLFOType : int
    {
        Sine = 0,
        UpSaw = 1,
        DownSaw = 2,
        Square = 3,
        Triangle = 4,
        Exponential = 5,
        RandomSampleHold = 6,
        Count = 7,
        EPhaserLFOType_MAX = 8,
    }
    public enum ERingModulatorTypeSourceEffect : int
    {
        Sine = 0,
        Saw = 1,
        Triangle = 2,
        Square = 3,
        Count = 4,
        ERingModulatorTypeSourceEffect_MAX = 5,
    }
    public enum EStereoDelaySourceEffect : int
    {
        Normal = 0,
        Cross = 1,
        PingPong = 2,
        Count = 3,
        EStereoDelaySourceEffect_MAX = 4,
    }
    public enum EStereoDelayFiltertype : int
    {
        Lowpass = 0,
        Highpass = 1,
        Bandpass = 2,
        Notch = 3,
        Count = 4,
        EStereoDelayFiltertype_MAX = 5,
    }
    public enum ESubmixFilterType : int
    {
        LowPass = 0,
        HighPass = 1,
        BandPass = 2,
        BandStop = 3,
        Count = 4,
        ESubmixFilterType_MAX = 5,
    }
    public enum ESubmixFilterAlgorithm : int
    {
        OnePole = 0,
        StateVariable = 1,
        Ladder = 2,
        Count = 3,
        ESubmixFilterAlgorithm_MAX = 4,
    }
    public enum ETapLineMode : int
    {
        SendToChannel = 0,
        Panning = 1,
        Disabled = 2,
        ETapLineMode_MAX = 3,
    }
    public enum EGranularSynthEnvelopeType : int
    {
        Rectangular = 0,
        Triangle = 1,
        DownwardTriangle = 2,
        UpwardTriangle = 3,
        ExponentialDecay = 4,
        ExponentialIncrease = 5,
        Gaussian = 6,
        Hanning = 7,
        Lanczos = 8,
        Cosine = 9,
        CosineSquared = 10,
        Welch = 11,
        Blackman = 12,
        BlackmanHarris = 13,
        Count = 14,
        EGranularSynthEnvelopeType_MAX = 15,
    }
    public enum EGranularSynthSeekType : int
    {
        FromBeginning = 0,
        FromCurrentPosition = 1,
        Count = 2,
        EGranularSynthSeekType_MAX = 3,
    }
    public enum CurveInterpolationType : int
    {
        AUTOINTERP = 0,
        LINEAR = 1,
        CONSTANT = 2,
        CurveInterpolationType_MAX = 3,
    }
    public enum ESamplePlayerSeekType : int
    {
        FromBeginning = 0,
        FromCurrentPosition = 1,
        FromEnd = 2,
        Count = 3,
        ESamplePlayerSeekType_MAX = 4,
    }
    public enum ESynthKnobSize : int
    {
        Medium = 0,
        Large = 1,
        Count = 2,
        ESynthKnobSize_MAX = 3,
    }
    public enum ESynthSlateSizeType : int
    {
        Small = 0,
        Medium = 1,
        Large = 2,
        Count = 3,
        ESynthSlateSizeType_MAX = 4,
    }
    public enum ESynthSlateColorStyle : int
    {
        Light = 0,
        Dark = 1,
        Count = 2,
        ESynthSlateColorStyle_MAX = 3,
    }
    public class Synth1PatchCable : Object
    {
        public Synth1PatchCable(nint addr) : base(addr) { }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public ESynth1PatchDestination Destination { get { return (ESynth1PatchDestination)this[nameof(Destination)].GetValue<int>(); } set { this[nameof(Destination)].SetValue<int>((int)value); } }
    }
    public class PatchId : Object
    {
        public PatchId(nint addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
    }
    public class EpicSynth1Patch : Object
    {
        public EpicSynth1Patch(nint addr) : base(addr) { }
        public ESynth1PatchSource PatchSource { get { return (ESynth1PatchSource)this[nameof(PatchSource)].GetValue<int>(); } set { this[nameof(PatchSource)].SetValue<int>((int)value); } }
        public Array<Synth1PatchCable> PatchCables { get { return new Array<Synth1PatchCable>(this[nameof(PatchCables)].Address); } }
    }
    public class ModularSynthPreset : TableRowBase
    {
        public ModularSynthPreset(nint addr) : base(addr) { }
        public bool bEnablePolyphony { get { return this[nameof(bEnablePolyphony)].Flag; } set { this[nameof(bEnablePolyphony)].Flag = value; } }
        public ESynth1OscType Osc1Type { get { return (ESynth1OscType)this[nameof(Osc1Type)].GetValue<int>(); } set { this[nameof(Osc1Type)].SetValue<int>((int)value); } }
        public float Osc1Gain { get { return this[nameof(Osc1Gain)].GetValue<float>(); } set { this[nameof(Osc1Gain)].SetValue<float>(value); } }
        public float Osc1Octave { get { return this[nameof(Osc1Octave)].GetValue<float>(); } set { this[nameof(Osc1Octave)].SetValue<float>(value); } }
        public float Osc1Semitones { get { return this[nameof(Osc1Semitones)].GetValue<float>(); } set { this[nameof(Osc1Semitones)].SetValue<float>(value); } }
        public float Osc1Cents { get { return this[nameof(Osc1Cents)].GetValue<float>(); } set { this[nameof(Osc1Cents)].SetValue<float>(value); } }
        public float Osc1PulseWidth { get { return this[nameof(Osc1PulseWidth)].GetValue<float>(); } set { this[nameof(Osc1PulseWidth)].SetValue<float>(value); } }
        public ESynth1OscType Osc2Type { get { return (ESynth1OscType)this[nameof(Osc2Type)].GetValue<int>(); } set { this[nameof(Osc2Type)].SetValue<int>((int)value); } }
        public float Osc2Gain { get { return this[nameof(Osc2Gain)].GetValue<float>(); } set { this[nameof(Osc2Gain)].SetValue<float>(value); } }
        public float Osc2Octave { get { return this[nameof(Osc2Octave)].GetValue<float>(); } set { this[nameof(Osc2Octave)].SetValue<float>(value); } }
        public float Osc2Semitones { get { return this[nameof(Osc2Semitones)].GetValue<float>(); } set { this[nameof(Osc2Semitones)].SetValue<float>(value); } }
        public float Osc2Cents { get { return this[nameof(Osc2Cents)].GetValue<float>(); } set { this[nameof(Osc2Cents)].SetValue<float>(value); } }
        public float Osc2PulseWidth { get { return this[nameof(Osc2PulseWidth)].GetValue<float>(); } set { this[nameof(Osc2PulseWidth)].SetValue<float>(value); } }
        public float Portamento { get { return this[nameof(Portamento)].GetValue<float>(); } set { this[nameof(Portamento)].SetValue<float>(value); } }
        public bool bEnableUnison { get { return this[nameof(bEnableUnison)].Flag; } set { this[nameof(bEnableUnison)].Flag = value; } }
        public bool bEnableOscillatorSync { get { return this[nameof(bEnableOscillatorSync)].Flag; } set { this[nameof(bEnableOscillatorSync)].Flag = value; } }
        public float Spread { get { return this[nameof(Spread)].GetValue<float>(); } set { this[nameof(Spread)].SetValue<float>(value); } }
        public float Pan { get { return this[nameof(Pan)].GetValue<float>(); } set { this[nameof(Pan)].SetValue<float>(value); } }
        public float LFO1Frequency { get { return this[nameof(LFO1Frequency)].GetValue<float>(); } set { this[nameof(LFO1Frequency)].SetValue<float>(value); } }
        public float LFO1Gain { get { return this[nameof(LFO1Gain)].GetValue<float>(); } set { this[nameof(LFO1Gain)].SetValue<float>(value); } }
        public ESynthLFOType LFO1Type { get { return (ESynthLFOType)this[nameof(LFO1Type)].GetValue<int>(); } set { this[nameof(LFO1Type)].SetValue<int>((int)value); } }
        public ESynthLFOMode LFO1Mode { get { return (ESynthLFOMode)this[nameof(LFO1Mode)].GetValue<int>(); } set { this[nameof(LFO1Mode)].SetValue<int>((int)value); } }
        public ESynthLFOPatchType LFO1PatchType { get { return (ESynthLFOPatchType)this[nameof(LFO1PatchType)].GetValue<int>(); } set { this[nameof(LFO1PatchType)].SetValue<int>((int)value); } }
        public float LFO2Frequency { get { return this[nameof(LFO2Frequency)].GetValue<float>(); } set { this[nameof(LFO2Frequency)].SetValue<float>(value); } }
        public float LFO2Gain { get { return this[nameof(LFO2Gain)].GetValue<float>(); } set { this[nameof(LFO2Gain)].SetValue<float>(value); } }
        public ESynthLFOType LFO2Type { get { return (ESynthLFOType)this[nameof(LFO2Type)].GetValue<int>(); } set { this[nameof(LFO2Type)].SetValue<int>((int)value); } }
        public ESynthLFOMode LFO2Mode { get { return (ESynthLFOMode)this[nameof(LFO2Mode)].GetValue<int>(); } set { this[nameof(LFO2Mode)].SetValue<int>((int)value); } }
        public ESynthLFOPatchType LFO2PatchType { get { return (ESynthLFOPatchType)this[nameof(LFO2PatchType)].GetValue<int>(); } set { this[nameof(LFO2PatchType)].SetValue<int>((int)value); } }
        public float GainDb { get { return this[nameof(GainDb)].GetValue<float>(); } set { this[nameof(GainDb)].SetValue<float>(value); } }
        public float AttackTime { get { return this[nameof(AttackTime)].GetValue<float>(); } set { this[nameof(AttackTime)].SetValue<float>(value); } }
        public float DecayTime { get { return this[nameof(DecayTime)].GetValue<float>(); } set { this[nameof(DecayTime)].SetValue<float>(value); } }
        public float SustainGain { get { return this[nameof(SustainGain)].GetValue<float>(); } set { this[nameof(SustainGain)].SetValue<float>(value); } }
        public float ReleaseTime { get { return this[nameof(ReleaseTime)].GetValue<float>(); } set { this[nameof(ReleaseTime)].SetValue<float>(value); } }
        public ESynthModEnvPatch ModEnvPatchType { get { return (ESynthModEnvPatch)this[nameof(ModEnvPatchType)].GetValue<int>(); } set { this[nameof(ModEnvPatchType)].SetValue<int>((int)value); } }
        public ESynthModEnvBiasPatch ModEnvBiasPatchType { get { return (ESynthModEnvBiasPatch)this[nameof(ModEnvBiasPatchType)].GetValue<int>(); } set { this[nameof(ModEnvBiasPatchType)].SetValue<int>((int)value); } }
        public bool bInvertModulationEnvelope { get { return this[nameof(bInvertModulationEnvelope)].Flag; } set { this[nameof(bInvertModulationEnvelope)].Flag = value; } }
        public bool bInvertModulationEnvelopeBias { get { return this[nameof(bInvertModulationEnvelopeBias)].Flag; } set { this[nameof(bInvertModulationEnvelopeBias)].Flag = value; } }
        public float ModulationEnvelopeDepth { get { return this[nameof(ModulationEnvelopeDepth)].GetValue<float>(); } set { this[nameof(ModulationEnvelopeDepth)].SetValue<float>(value); } }
        public float ModulationEnvelopeAttackTime { get { return this[nameof(ModulationEnvelopeAttackTime)].GetValue<float>(); } set { this[nameof(ModulationEnvelopeAttackTime)].SetValue<float>(value); } }
        public float ModulationEnvelopeDecayTime { get { return this[nameof(ModulationEnvelopeDecayTime)].GetValue<float>(); } set { this[nameof(ModulationEnvelopeDecayTime)].SetValue<float>(value); } }
        public float ModulationEnvelopeSustainGain { get { return this[nameof(ModulationEnvelopeSustainGain)].GetValue<float>(); } set { this[nameof(ModulationEnvelopeSustainGain)].SetValue<float>(value); } }
        public float ModulationEnvelopeReleaseTime { get { return this[nameof(ModulationEnvelopeReleaseTime)].GetValue<float>(); } set { this[nameof(ModulationEnvelopeReleaseTime)].SetValue<float>(value); } }
        public bool bLegato { get { return this[nameof(bLegato)].Flag; } set { this[nameof(bLegato)].Flag = value; } }
        public bool bRetrigger { get { return this[nameof(bRetrigger)].Flag; } set { this[nameof(bRetrigger)].Flag = value; } }
        public float FilterFrequency { get { return this[nameof(FilterFrequency)].GetValue<float>(); } set { this[nameof(FilterFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
        public ESynthFilterType FilterType { get { return (ESynthFilterType)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public ESynthFilterAlgorithm FilterAlgorithm { get { return (ESynthFilterAlgorithm)this[nameof(FilterAlgorithm)].GetValue<int>(); } set { this[nameof(FilterAlgorithm)].SetValue<int>((int)value); } }
        public bool bStereoDelayEnabled { get { return this[nameof(bStereoDelayEnabled)].Flag; } set { this[nameof(bStereoDelayEnabled)].Flag = value; } }
        public ESynthStereoDelayMode StereoDelayMode { get { return (ESynthStereoDelayMode)this[nameof(StereoDelayMode)].GetValue<int>(); } set { this[nameof(StereoDelayMode)].SetValue<int>((int)value); } }
        public float StereoDelayTime { get { return this[nameof(StereoDelayTime)].GetValue<float>(); } set { this[nameof(StereoDelayTime)].SetValue<float>(value); } }
        public float StereoDelayFeedback { get { return this[nameof(StereoDelayFeedback)].GetValue<float>(); } set { this[nameof(StereoDelayFeedback)].SetValue<float>(value); } }
        public float StereoDelayWetlevel { get { return this[nameof(StereoDelayWetlevel)].GetValue<float>(); } set { this[nameof(StereoDelayWetlevel)].SetValue<float>(value); } }
        public float StereoDelayRatio { get { return this[nameof(StereoDelayRatio)].GetValue<float>(); } set { this[nameof(StereoDelayRatio)].SetValue<float>(value); } }
        public bool bChorusEnabled { get { return this[nameof(bChorusEnabled)].Flag; } set { this[nameof(bChorusEnabled)].Flag = value; } }
        public float ChorusDepth { get { return this[nameof(ChorusDepth)].GetValue<float>(); } set { this[nameof(ChorusDepth)].SetValue<float>(value); } }
        public float ChorusFeedback { get { return this[nameof(ChorusFeedback)].GetValue<float>(); } set { this[nameof(ChorusFeedback)].SetValue<float>(value); } }
        public float ChorusFrequency { get { return this[nameof(ChorusFrequency)].GetValue<float>(); } set { this[nameof(ChorusFrequency)].SetValue<float>(value); } }
        public Array<EpicSynth1Patch> Patches { get { return new Array<EpicSynth1Patch>(this[nameof(Patches)].Address); } }
    }
    public class ModularSynthPresetBankEntry : Object
    {
        public ModularSynthPresetBankEntry(nint addr) : base(addr) { }
        public Object PresetName { get { return this[nameof(PresetName)]; } set { this[nameof(PresetName)] = value; } }
        public ModularSynthPreset Preset { get { return this[nameof(Preset)].As<ModularSynthPreset>(); } set { this["Preset"] = value; } }
    }
    public class SourceEffectBitCrusherBaseSettings : Object
    {
        public SourceEffectBitCrusherBaseSettings(nint addr) : base(addr) { }
        public float SampleRate { get { return this[nameof(SampleRate)].GetValue<float>(); } set { this[nameof(SampleRate)].SetValue<float>(value); } }
        public float BitDepth { get { return this[nameof(BitDepth)].GetValue<float>(); } set { this[nameof(BitDepth)].SetValue<float>(value); } }
    }
    public class SourceEffectBitCrusherSettings : Object
    {
        public SourceEffectBitCrusherSettings(nint addr) : base(addr) { }
        public float CrushedSampleRate { get { return this[nameof(CrushedSampleRate)].GetValue<float>(); } set { this[nameof(CrushedSampleRate)].SetValue<float>(value); } }
        public SoundModulationDestinationSettings SampleRateModulation { get { return this[nameof(SampleRateModulation)].As<SoundModulationDestinationSettings>(); } set { this["SampleRateModulation"] = value; } }
        public float CrushedBits { get { return this[nameof(CrushedBits)].GetValue<float>(); } set { this[nameof(CrushedBits)].SetValue<float>(value); } }
        public SoundModulationDestinationSettings BitModulation { get { return this[nameof(BitModulation)].As<SoundModulationDestinationSettings>(); } set { this["BitModulation"] = value; } }
    }
    public class SourceEffectChorusBaseSettings : Object
    {
        public SourceEffectChorusBaseSettings(nint addr) : base(addr) { }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public float Spread { get { return this[nameof(Spread)].GetValue<float>(); } set { this[nameof(Spread)].SetValue<float>(value); } }
    }
    public class SourceEffectChorusSettings : Object
    {
        public SourceEffectChorusSettings(nint addr) : base(addr) { }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public float Spread { get { return this[nameof(Spread)].GetValue<float>(); } set { this[nameof(Spread)].SetValue<float>(value); } }
        public SoundModulationDestinationSettings DepthModulation { get { return this[nameof(DepthModulation)].As<SoundModulationDestinationSettings>(); } set { this["DepthModulation"] = value; } }
        public SoundModulationDestinationSettings FrequencyModulation { get { return this[nameof(FrequencyModulation)].As<SoundModulationDestinationSettings>(); } set { this["FrequencyModulation"] = value; } }
        public SoundModulationDestinationSettings FeedbackModulation { get { return this[nameof(FeedbackModulation)].As<SoundModulationDestinationSettings>(); } set { this["FeedbackModulation"] = value; } }
        public SoundModulationDestinationSettings WetModulation { get { return this[nameof(WetModulation)].As<SoundModulationDestinationSettings>(); } set { this["WetModulation"] = value; } }
        public SoundModulationDestinationSettings DryModulation { get { return this[nameof(DryModulation)].As<SoundModulationDestinationSettings>(); } set { this["DryModulation"] = value; } }
        public SoundModulationDestinationSettings SpreadModulation { get { return this[nameof(SpreadModulation)].As<SoundModulationDestinationSettings>(); } set { this["SpreadModulation"] = value; } }
    }
    public class SourceEffectConvolutionReverbSettings : Object
    {
        public SourceEffectConvolutionReverbSettings(nint addr) : base(addr) { }
        public float NormalizationVolumeDb { get { return this[nameof(NormalizationVolumeDb)].GetValue<float>(); } set { this[nameof(NormalizationVolumeDb)].SetValue<float>(value); } }
        public float WetVolumeDb { get { return this[nameof(WetVolumeDb)].GetValue<float>(); } set { this[nameof(WetVolumeDb)].SetValue<float>(value); } }
        public float DryVolumeDb { get { return this[nameof(DryVolumeDb)].GetValue<float>(); } set { this[nameof(DryVolumeDb)].SetValue<float>(value); } }
        public bool bBypass { get { return this[nameof(bBypass)].Flag; } set { this[nameof(bBypass)].Flag = value; } }
    }
    public class SourceEffectDynamicsProcessorSettings : Object
    {
        public SourceEffectDynamicsProcessorSettings(nint addr) : base(addr) { }
        public ESourceEffectDynamicsProcessorType DynamicsProcessorType { get { return (ESourceEffectDynamicsProcessorType)this[nameof(DynamicsProcessorType)].GetValue<int>(); } set { this[nameof(DynamicsProcessorType)].SetValue<int>((int)value); } }
        public ESourceEffectDynamicsPeakMode PeakMode { get { return (ESourceEffectDynamicsPeakMode)this[nameof(PeakMode)].GetValue<int>(); } set { this[nameof(PeakMode)].SetValue<int>((int)value); } }
        public float LookAheadMsec { get { return this[nameof(LookAheadMsec)].GetValue<float>(); } set { this[nameof(LookAheadMsec)].SetValue<float>(value); } }
        public float AttackTimeMsec { get { return this[nameof(AttackTimeMsec)].GetValue<float>(); } set { this[nameof(AttackTimeMsec)].SetValue<float>(value); } }
        public float ReleaseTimeMsec { get { return this[nameof(ReleaseTimeMsec)].GetValue<float>(); } set { this[nameof(ReleaseTimeMsec)].SetValue<float>(value); } }
        public float ThresholdDb { get { return this[nameof(ThresholdDb)].GetValue<float>(); } set { this[nameof(ThresholdDb)].SetValue<float>(value); } }
        public float Ratio { get { return this[nameof(Ratio)].GetValue<float>(); } set { this[nameof(Ratio)].SetValue<float>(value); } }
        public float KneeBandwidthDb { get { return this[nameof(KneeBandwidthDb)].GetValue<float>(); } set { this[nameof(KneeBandwidthDb)].SetValue<float>(value); } }
        public float InputGainDb { get { return this[nameof(InputGainDb)].GetValue<float>(); } set { this[nameof(InputGainDb)].SetValue<float>(value); } }
        public float OutputGainDb { get { return this[nameof(OutputGainDb)].GetValue<float>(); } set { this[nameof(OutputGainDb)].SetValue<float>(value); } }
        public bool bStereoLinked { get { return this[nameof(bStereoLinked)].Flag; } set { this[nameof(bStereoLinked)].Flag = value; } }
        public bool bAnalogMode { get { return this[nameof(bAnalogMode)].Flag; } set { this[nameof(bAnalogMode)].Flag = value; } }
    }
    public class SourceEffectEnvelopeFollowerSettings : Object
    {
        public SourceEffectEnvelopeFollowerSettings(nint addr) : base(addr) { }
        public float AttackTime { get { return this[nameof(AttackTime)].GetValue<float>(); } set { this[nameof(AttackTime)].SetValue<float>(value); } }
        public float ReleaseTime { get { return this[nameof(ReleaseTime)].GetValue<float>(); } set { this[nameof(ReleaseTime)].SetValue<float>(value); } }
        public EEnvelopeFollowerPeakMode PeakMode { get { return (EEnvelopeFollowerPeakMode)this[nameof(PeakMode)].GetValue<int>(); } set { this[nameof(PeakMode)].SetValue<int>((int)value); } }
        public bool bIsAnalogMode { get { return this[nameof(bIsAnalogMode)].Flag; } set { this[nameof(bIsAnalogMode)].Flag = value; } }
    }
    public class SourceEffectEQBand : Object
    {
        public SourceEffectEQBand(nint addr) : base(addr) { }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Bandwidth { get { return this[nameof(Bandwidth)].GetValue<float>(); } set { this[nameof(Bandwidth)].SetValue<float>(value); } }
        public float GainDb { get { return this[nameof(GainDb)].GetValue<float>(); } set { this[nameof(GainDb)].SetValue<float>(value); } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class SourceEffectEQSettings : Object
    {
        public SourceEffectEQSettings(nint addr) : base(addr) { }
        public Array<SourceEffectEQBand> EQBands { get { return new Array<SourceEffectEQBand>(this[nameof(EQBands)].Address); } }
    }
    public class SourceEffectFilterAudioBusModulationSettings : Object
    {
        public SourceEffectFilterAudioBusModulationSettings(nint addr) : base(addr) { }
        public AudioBus AudioBus { get { return this[nameof(AudioBus)].As<AudioBus>(); } set { this["AudioBus"] = value; } }
        public int EnvelopeFollowerAttackTimeMsec { get { return this[nameof(EnvelopeFollowerAttackTimeMsec)].GetValue<int>(); } set { this[nameof(EnvelopeFollowerAttackTimeMsec)].SetValue<int>(value); } }
        public int EnvelopeFollowerReleaseTimeMsec { get { return this[nameof(EnvelopeFollowerReleaseTimeMsec)].GetValue<int>(); } set { this[nameof(EnvelopeFollowerReleaseTimeMsec)].SetValue<int>(value); } }
        public float EnvelopeGainMultiplier { get { return this[nameof(EnvelopeGainMultiplier)].GetValue<float>(); } set { this[nameof(EnvelopeGainMultiplier)].SetValue<float>(value); } }
        public ESourceEffectFilterParam FilterParam { get { return (ESourceEffectFilterParam)this[nameof(FilterParam)].GetValue<int>(); } set { this[nameof(FilterParam)].SetValue<int>((int)value); } }
        public float MinFrequencyModulation { get { return this[nameof(MinFrequencyModulation)].GetValue<float>(); } set { this[nameof(MinFrequencyModulation)].SetValue<float>(value); } }
        public float MaxFrequencyModulation { get { return this[nameof(MaxFrequencyModulation)].GetValue<float>(); } set { this[nameof(MaxFrequencyModulation)].SetValue<float>(value); } }
        public float MinResonanceModulation { get { return this[nameof(MinResonanceModulation)].GetValue<float>(); } set { this[nameof(MinResonanceModulation)].SetValue<float>(value); } }
        public float MaxResonanceModulation { get { return this[nameof(MaxResonanceModulation)].GetValue<float>(); } set { this[nameof(MaxResonanceModulation)].SetValue<float>(value); } }
    }
    public class SourceEffectFilterSettings : Object
    {
        public SourceEffectFilterSettings(nint addr) : base(addr) { }
        public ESourceEffectFilterCircuit FilterCircuit { get { return (ESourceEffectFilterCircuit)this[nameof(FilterCircuit)].GetValue<int>(); } set { this[nameof(FilterCircuit)].SetValue<int>((int)value); } }
        public ESourceEffectFilterType FilterType { get { return (ESourceEffectFilterType)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public float CutoffFrequency { get { return this[nameof(CutoffFrequency)].GetValue<float>(); } set { this[nameof(CutoffFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
        public Array<SourceEffectFilterAudioBusModulationSettings> AudioBusModulation { get { return new Array<SourceEffectFilterAudioBusModulationSettings>(this[nameof(AudioBusModulation)].Address); } }
    }
    public class SourceEffectFoldbackDistortionSettings : Object
    {
        public SourceEffectFoldbackDistortionSettings(nint addr) : base(addr) { }
        public float InputGainDb { get { return this[nameof(InputGainDb)].GetValue<float>(); } set { this[nameof(InputGainDb)].SetValue<float>(value); } }
        public float ThresholdDb { get { return this[nameof(ThresholdDb)].GetValue<float>(); } set { this[nameof(ThresholdDb)].SetValue<float>(value); } }
        public float OutputGainDb { get { return this[nameof(OutputGainDb)].GetValue<float>(); } set { this[nameof(OutputGainDb)].SetValue<float>(value); } }
    }
    public class SourceEffectMidSideSpreaderSettings : Object
    {
        public SourceEffectMidSideSpreaderSettings(nint addr) : base(addr) { }
        public float SpreadAmount { get { return this[nameof(SpreadAmount)].GetValue<float>(); } set { this[nameof(SpreadAmount)].SetValue<float>(value); } }
        public EStereoChannelMode InputMode { get { return (EStereoChannelMode)this[nameof(InputMode)].GetValue<int>(); } set { this[nameof(InputMode)].SetValue<int>((int)value); } }
        public EStereoChannelMode OutputMode { get { return (EStereoChannelMode)this[nameof(OutputMode)].GetValue<int>(); } set { this[nameof(OutputMode)].SetValue<int>((int)value); } }
        public bool bEqualPower { get { return this[nameof(bEqualPower)].Flag; } set { this[nameof(bEqualPower)].Flag = value; } }
    }
    public class SourceEffectIndividualFilterSettings : Object
    {
        public SourceEffectIndividualFilterSettings(nint addr) : base(addr) { }
        public ESourceEffectMotionFilterCircuit FilterCircuit { get { return (ESourceEffectMotionFilterCircuit)this[nameof(FilterCircuit)].GetValue<int>(); } set { this[nameof(FilterCircuit)].SetValue<int>((int)value); } }
        public ESourceEffectMotionFilterType FilterType { get { return (ESourceEffectMotionFilterType)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public float CutoffFrequency { get { return this[nameof(CutoffFrequency)].GetValue<float>(); } set { this[nameof(CutoffFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
    }
    public class SourceEffectMotionFilterModulationSettings : Object
    {
        public SourceEffectMotionFilterModulationSettings(nint addr) : base(addr) { }
        public ESourceEffectMotionFilterModSource ModulationSource { get { return (ESourceEffectMotionFilterModSource)this[nameof(ModulationSource)].GetValue<int>(); } set { this[nameof(ModulationSource)].SetValue<int>((int)value); } }
        public Vector2D ModulationInputRange { get { return this[nameof(ModulationInputRange)].As<Vector2D>(); } set { this["ModulationInputRange"] = value; } }
        public Vector2D ModulationOutputMinimumRange { get { return this[nameof(ModulationOutputMinimumRange)].As<Vector2D>(); } set { this["ModulationOutputMinimumRange"] = value; } }
        public Vector2D ModulationOutputMaximumRange { get { return this[nameof(ModulationOutputMaximumRange)].As<Vector2D>(); } set { this["ModulationOutputMaximumRange"] = value; } }
        public float UpdateEaseMS { get { return this[nameof(UpdateEaseMS)].GetValue<float>(); } set { this[nameof(UpdateEaseMS)].SetValue<float>(value); } }
    }
    public class SourceEffectMotionFilterSettings : Object
    {
        public SourceEffectMotionFilterSettings(nint addr) : base(addr) { }
        public ESourceEffectMotionFilterTopology MotionFilterTopology { get { return (ESourceEffectMotionFilterTopology)this[nameof(MotionFilterTopology)].GetValue<int>(); } set { this[nameof(MotionFilterTopology)].SetValue<int>((int)value); } }
        public float MotionFilterMix { get { return this[nameof(MotionFilterMix)].GetValue<float>(); } set { this[nameof(MotionFilterMix)].SetValue<float>(value); } }
        public SourceEffectIndividualFilterSettings FilterASettings { get { return this[nameof(FilterASettings)].As<SourceEffectIndividualFilterSettings>(); } set { this["FilterASettings"] = value; } }
        public SourceEffectIndividualFilterSettings FilterBSettings { get { return this[nameof(FilterBSettings)].As<SourceEffectIndividualFilterSettings>(); } set { this["FilterBSettings"] = value; } }
        public Object ModulationMappings { get { return this[nameof(ModulationMappings)]; } set { this[nameof(ModulationMappings)] = value; } }
        public float DryVolumeDb { get { return this[nameof(DryVolumeDb)].GetValue<float>(); } set { this[nameof(DryVolumeDb)].SetValue<float>(value); } }
    }
    public class SourceEffectPannerSettings : Object
    {
        public SourceEffectPannerSettings(nint addr) : base(addr) { }
        public float Spread { get { return this[nameof(Spread)].GetValue<float>(); } set { this[nameof(Spread)].SetValue<float>(value); } }
        public float Pan { get { return this[nameof(Pan)].GetValue<float>(); } set { this[nameof(Pan)].SetValue<float>(value); } }
    }
    public class SourceEffectPhaserSettings : Object
    {
        public SourceEffectPhaserSettings(nint addr) : base(addr) { }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public EPhaserLFOType LFOType { get { return (EPhaserLFOType)this[nameof(LFOType)].GetValue<int>(); } set { this[nameof(LFOType)].SetValue<int>((int)value); } }
        public bool UseQuadraturePhase { get { return this[nameof(UseQuadraturePhase)].Flag; } set { this[nameof(UseQuadraturePhase)].Flag = value; } }
    }
    public class SourceEffectRingModulationSettings : Object
    {
        public SourceEffectRingModulationSettings(nint addr) : base(addr) { }
        public ERingModulatorTypeSourceEffect ModulatorType { get { return (ERingModulatorTypeSourceEffect)this[nameof(ModulatorType)].GetValue<int>(); } set { this[nameof(ModulatorType)].SetValue<int>((int)value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Depth { get { return this[nameof(Depth)].GetValue<float>(); } set { this[nameof(Depth)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public AudioBus AudioBusModulator { get { return this[nameof(AudioBusModulator)].As<AudioBus>(); } set { this["AudioBusModulator"] = value; } }
    }
    public class SourceEffectSimpleDelaySettings : Object
    {
        public SourceEffectSimpleDelaySettings(nint addr) : base(addr) { }
        public float SpeedOfSound { get { return this[nameof(SpeedOfSound)].GetValue<float>(); } set { this[nameof(SpeedOfSound)].SetValue<float>(value); } }
        public float DelayAmount { get { return this[nameof(DelayAmount)].GetValue<float>(); } set { this[nameof(DelayAmount)].SetValue<float>(value); } }
        public float DryAmount { get { return this[nameof(DryAmount)].GetValue<float>(); } set { this[nameof(DryAmount)].SetValue<float>(value); } }
        public float WetAmount { get { return this[nameof(WetAmount)].GetValue<float>(); } set { this[nameof(WetAmount)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public bool bDelayBasedOnDistance { get { return this[nameof(bDelayBasedOnDistance)].Flag; } set { this[nameof(bDelayBasedOnDistance)].Flag = value; } }
        public bool bUseDistanceOverride { get { return this[nameof(bUseDistanceOverride)].Flag; } set { this[nameof(bUseDistanceOverride)].Flag = value; } }
    }
    public class SourceEffectStereoDelaySettings : Object
    {
        public SourceEffectStereoDelaySettings(nint addr) : base(addr) { }
        public EStereoDelaySourceEffect DelayMode { get { return (EStereoDelaySourceEffect)this[nameof(DelayMode)].GetValue<int>(); } set { this[nameof(DelayMode)].SetValue<int>((int)value); } }
        public float DelayTimeMsec { get { return this[nameof(DelayTimeMsec)].GetValue<float>(); } set { this[nameof(DelayTimeMsec)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public float DelayRatio { get { return this[nameof(DelayRatio)].GetValue<float>(); } set { this[nameof(DelayRatio)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public bool bFilterEnabled { get { return this[nameof(bFilterEnabled)].Flag; } set { this[nameof(bFilterEnabled)].Flag = value; } }
        public EStereoDelayFiltertype FilterType { get { return (EStereoDelayFiltertype)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public float FilterFrequency { get { return this[nameof(FilterFrequency)].GetValue<float>(); } set { this[nameof(FilterFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
    }
    public class SourceEffectWaveShaperSettings : Object
    {
        public SourceEffectWaveShaperSettings(nint addr) : base(addr) { }
        public float Amount { get { return this[nameof(Amount)].GetValue<float>(); } set { this[nameof(Amount)].SetValue<float>(value); } }
        public float OutputGainDb { get { return this[nameof(OutputGainDb)].GetValue<float>(); } set { this[nameof(OutputGainDb)].SetValue<float>(value); } }
    }
    public class SubmixEffectConvolutionReverbSettings : Object
    {
        public SubmixEffectConvolutionReverbSettings(nint addr) : base(addr) { }
        public float NormalizationVolumeDb { get { return this[nameof(NormalizationVolumeDb)].GetValue<float>(); } set { this[nameof(NormalizationVolumeDb)].SetValue<float>(value); } }
        public float WetVolumeDb { get { return this[nameof(WetVolumeDb)].GetValue<float>(); } set { this[nameof(WetVolumeDb)].SetValue<float>(value); } }
        public float DryVolumeDb { get { return this[nameof(DryVolumeDb)].GetValue<float>(); } set { this[nameof(DryVolumeDb)].SetValue<float>(value); } }
        public bool bBypass { get { return this[nameof(bBypass)].Flag; } set { this[nameof(bBypass)].Flag = value; } }
        public bool bMixInputChannelFormatToImpulseResponseFormat { get { return this[nameof(bMixInputChannelFormatToImpulseResponseFormat)].Flag; } set { this[nameof(bMixInputChannelFormatToImpulseResponseFormat)].Flag = value; } }
        public bool bMixReverbOutputToOutputChannelFormat { get { return this[nameof(bMixReverbOutputToOutputChannelFormat)].Flag; } set { this[nameof(bMixReverbOutputToOutputChannelFormat)].Flag = value; } }
        public float SurroundRearChannelBleedDb { get { return this[nameof(SurroundRearChannelBleedDb)].GetValue<float>(); } set { this[nameof(SurroundRearChannelBleedDb)].SetValue<float>(value); } }
        public bool bInvertRearChannelBleedPhase { get { return this[nameof(bInvertRearChannelBleedPhase)].Flag; } set { this[nameof(bInvertRearChannelBleedPhase)].Flag = value; } }
        public bool bSurroundRearChannelFlip { get { return this[nameof(bSurroundRearChannelFlip)].Flag; } set { this[nameof(bSurroundRearChannelFlip)].Flag = value; } }
        public float SurroundRearChannelBleedAmount { get { return this[nameof(SurroundRearChannelBleedAmount)].GetValue<float>(); } set { this[nameof(SurroundRearChannelBleedAmount)].SetValue<float>(value); } }
        public AudioImpulseResponse ImpulseResponse { get { return this[nameof(ImpulseResponse)].As<AudioImpulseResponse>(); } set { this["ImpulseResponse"] = value; } }
        public bool AllowHardwareAcceleration { get { return this[nameof(AllowHardwareAcceleration)].Flag; } set { this[nameof(AllowHardwareAcceleration)].Flag = value; } }
    }
    public class SubmixEffectDelaySettings : Object
    {
        public SubmixEffectDelaySettings(nint addr) : base(addr) { }
        public float MaximumDelayLength { get { return this[nameof(MaximumDelayLength)].GetValue<float>(); } set { this[nameof(MaximumDelayLength)].SetValue<float>(value); } }
        public float InterpolationTime { get { return this[nameof(InterpolationTime)].GetValue<float>(); } set { this[nameof(InterpolationTime)].SetValue<float>(value); } }
        public float DelayLength { get { return this[nameof(DelayLength)].GetValue<float>(); } set { this[nameof(DelayLength)].SetValue<float>(value); } }
    }
    public class SubmixEffectFilterSettings : Object
    {
        public SubmixEffectFilterSettings(nint addr) : base(addr) { }
        public ESubmixFilterType FilterType { get { return (ESubmixFilterType)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public ESubmixFilterAlgorithm FilterAlgorithm { get { return (ESubmixFilterAlgorithm)this[nameof(FilterAlgorithm)].GetValue<int>(); } set { this[nameof(FilterAlgorithm)].SetValue<int>((int)value); } }
        public float FilterFrequency { get { return this[nameof(FilterFrequency)].GetValue<float>(); } set { this[nameof(FilterFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
    }
    public class SubmixEffectFlexiverbSettings : Object
    {
        public SubmixEffectFlexiverbSettings(nint addr) : base(addr) { }
        public float PreDelay { get { return this[nameof(PreDelay)].GetValue<float>(); } set { this[nameof(PreDelay)].SetValue<float>(value); } }
        public float DecayTime { get { return this[nameof(DecayTime)].GetValue<float>(); } set { this[nameof(DecayTime)].SetValue<float>(value); } }
        public float RoomDampening { get { return this[nameof(RoomDampening)].GetValue<float>(); } set { this[nameof(RoomDampening)].SetValue<float>(value); } }
        public int Complexity { get { return this[nameof(Complexity)].GetValue<int>(); } set { this[nameof(Complexity)].SetValue<int>(value); } }
    }
    public class DynamicsBandSettings : Object
    {
        public DynamicsBandSettings(nint addr) : base(addr) { }
        public float CrossoverTopFrequency { get { return this[nameof(CrossoverTopFrequency)].GetValue<float>(); } set { this[nameof(CrossoverTopFrequency)].SetValue<float>(value); } }
        public float AttackTimeMsec { get { return this[nameof(AttackTimeMsec)].GetValue<float>(); } set { this[nameof(AttackTimeMsec)].SetValue<float>(value); } }
        public float ReleaseTimeMsec { get { return this[nameof(ReleaseTimeMsec)].GetValue<float>(); } set { this[nameof(ReleaseTimeMsec)].SetValue<float>(value); } }
        public float ThresholdDb { get { return this[nameof(ThresholdDb)].GetValue<float>(); } set { this[nameof(ThresholdDb)].SetValue<float>(value); } }
        public float Ratio { get { return this[nameof(Ratio)].GetValue<float>(); } set { this[nameof(Ratio)].SetValue<float>(value); } }
        public float KneeBandwidthDb { get { return this[nameof(KneeBandwidthDb)].GetValue<float>(); } set { this[nameof(KneeBandwidthDb)].SetValue<float>(value); } }
        public float InputGainDb { get { return this[nameof(InputGainDb)].GetValue<float>(); } set { this[nameof(InputGainDb)].SetValue<float>(value); } }
        public float OutputGainDb { get { return this[nameof(OutputGainDb)].GetValue<float>(); } set { this[nameof(OutputGainDb)].SetValue<float>(value); } }
    }
    public class SubmixEffectMultibandCompressorSettings : Object
    {
        public SubmixEffectMultibandCompressorSettings(nint addr) : base(addr) { }
        public ESubmixEffectDynamicsProcessorType DynamicsProcessorType { get { return (ESubmixEffectDynamicsProcessorType)this[nameof(DynamicsProcessorType)].GetValue<int>(); } set { this[nameof(DynamicsProcessorType)].SetValue<int>((int)value); } }
        public ESubmixEffectDynamicsPeakMode PeakMode { get { return (ESubmixEffectDynamicsPeakMode)this[nameof(PeakMode)].GetValue<int>(); } set { this[nameof(PeakMode)].SetValue<int>((int)value); } }
        public ESubmixEffectDynamicsChannelLinkMode LinkMode { get { return (ESubmixEffectDynamicsChannelLinkMode)this[nameof(LinkMode)].GetValue<int>(); } set { this[nameof(LinkMode)].SetValue<int>((int)value); } }
        public float LookAheadMsec { get { return this[nameof(LookAheadMsec)].GetValue<float>(); } set { this[nameof(LookAheadMsec)].SetValue<float>(value); } }
        public bool bAnalogMode { get { return this[nameof(bAnalogMode)].Flag; } set { this[nameof(bAnalogMode)].Flag = value; } }
        public bool bFourPole { get { return this[nameof(bFourPole)].Flag; } set { this[nameof(bFourPole)].Flag = value; } }
        public bool bBypass { get { return this[nameof(bBypass)].Flag; } set { this[nameof(bBypass)].Flag = value; } }
        public ESubmixEffectDynamicsKeySource KeySource { get { return (ESubmixEffectDynamicsKeySource)this[nameof(KeySource)].GetValue<int>(); } set { this[nameof(KeySource)].SetValue<int>((int)value); } }
        public AudioBus ExternalAudioBus { get { return this[nameof(ExternalAudioBus)].As<AudioBus>(); } set { this["ExternalAudioBus"] = value; } }
        public SoundSubmix ExternalSubmix { get { return this[nameof(ExternalSubmix)].As<SoundSubmix>(); } set { this["ExternalSubmix"] = value; } }
        public float KeyGainDb { get { return this[nameof(KeyGainDb)].GetValue<float>(); } set { this[nameof(KeyGainDb)].SetValue<float>(value); } }
        public bool bKeyAudition { get { return this[nameof(bKeyAudition)].Flag; } set { this[nameof(bKeyAudition)].Flag = value; } }
        public Array<DynamicsBandSettings> Bands { get { return new Array<DynamicsBandSettings>(this[nameof(Bands)].Address); } }
    }
    public class SubmixEffectStereoDelaySettings : Object
    {
        public SubmixEffectStereoDelaySettings(nint addr) : base(addr) { }
        public EStereoDelaySourceEffect DelayMode { get { return (EStereoDelaySourceEffect)this[nameof(DelayMode)].GetValue<int>(); } set { this[nameof(DelayMode)].SetValue<int>((int)value); } }
        public float DelayTimeMsec { get { return this[nameof(DelayTimeMsec)].GetValue<float>(); } set { this[nameof(DelayTimeMsec)].SetValue<float>(value); } }
        public float Feedback { get { return this[nameof(Feedback)].GetValue<float>(); } set { this[nameof(Feedback)].SetValue<float>(value); } }
        public float DelayRatio { get { return this[nameof(DelayRatio)].GetValue<float>(); } set { this[nameof(DelayRatio)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public bool bFilterEnabled { get { return this[nameof(bFilterEnabled)].Flag; } set { this[nameof(bFilterEnabled)].Flag = value; } }
        public EStereoDelayFiltertype FilterType { get { return (EStereoDelayFiltertype)this[nameof(FilterType)].GetValue<int>(); } set { this[nameof(FilterType)].SetValue<int>((int)value); } }
        public float FilterFrequency { get { return this[nameof(FilterFrequency)].GetValue<float>(); } set { this[nameof(FilterFrequency)].SetValue<float>(value); } }
        public float FilterQ { get { return this[nameof(FilterQ)].GetValue<float>(); } set { this[nameof(FilterQ)].SetValue<float>(value); } }
    }
    public class TapDelayInfo : Object
    {
        public TapDelayInfo(nint addr) : base(addr) { }
        public ETapLineMode TapLineMode { get { return (ETapLineMode)this[nameof(TapLineMode)].GetValue<int>(); } set { this[nameof(TapLineMode)].SetValue<int>((int)value); } }
        public float DelayLength { get { return this[nameof(DelayLength)].GetValue<float>(); } set { this[nameof(DelayLength)].SetValue<float>(value); } }
        public float Gain { get { return this[nameof(Gain)].GetValue<float>(); } set { this[nameof(Gain)].SetValue<float>(value); } }
        public int OutputChannel { get { return this[nameof(OutputChannel)].GetValue<int>(); } set { this[nameof(OutputChannel)].SetValue<int>(value); } }
        public float PanInDegrees { get { return this[nameof(PanInDegrees)].GetValue<float>(); } set { this[nameof(PanInDegrees)].SetValue<float>(value); } }
        public int TapId { get { return this[nameof(TapId)].GetValue<int>(); } set { this[nameof(TapId)].SetValue<int>(value); } }
    }
    public class SubmixEffectTapDelaySettings : Object
    {
        public SubmixEffectTapDelaySettings(nint addr) : base(addr) { }
        public float MaximumDelayLength { get { return this[nameof(MaximumDelayLength)].GetValue<float>(); } set { this[nameof(MaximumDelayLength)].SetValue<float>(value); } }
        public float InterpolationTime { get { return this[nameof(InterpolationTime)].GetValue<float>(); } set { this[nameof(InterpolationTime)].SetValue<float>(value); } }
        public Array<TapDelayInfo> Taps { get { return new Array<TapDelayInfo>(this[nameof(Taps)].Address); } }
    }
    public class Synth2DSliderStyle : SlateWidgetStyle
    {
        public Synth2DSliderStyle(nint addr) : base(addr) { }
        public SlateBrush NormalThumbImage { get { return this[nameof(NormalThumbImage)].As<SlateBrush>(); } set { this["NormalThumbImage"] = value; } }
        public SlateBrush DisabledThumbImage { get { return this[nameof(DisabledThumbImage)].As<SlateBrush>(); } set { this["DisabledThumbImage"] = value; } }
        public SlateBrush NormalBarImage { get { return this[nameof(NormalBarImage)].As<SlateBrush>(); } set { this["NormalBarImage"] = value; } }
        public SlateBrush DisabledBarImage { get { return this[nameof(DisabledBarImage)].As<SlateBrush>(); } set { this["DisabledBarImage"] = value; } }
        public SlateBrush BackgroundImage { get { return this[nameof(BackgroundImage)].As<SlateBrush>(); } set { this["BackgroundImage"] = value; } }
        public float BarThickness { get { return this[nameof(BarThickness)].GetValue<float>(); } set { this[nameof(BarThickness)].SetValue<float>(value); } }
    }
    public class SynthKnobStyle : SlateWidgetStyle
    {
        public SynthKnobStyle(nint addr) : base(addr) { }
        public SlateBrush LargeKnob { get { return this[nameof(LargeKnob)].As<SlateBrush>(); } set { this["LargeKnob"] = value; } }
        public SlateBrush LargeKnobOverlay { get { return this[nameof(LargeKnobOverlay)].As<SlateBrush>(); } set { this["LargeKnobOverlay"] = value; } }
        public SlateBrush MediumKnob { get { return this[nameof(MediumKnob)].As<SlateBrush>(); } set { this["MediumKnob"] = value; } }
        public SlateBrush MediumKnobOverlay { get { return this[nameof(MediumKnobOverlay)].As<SlateBrush>(); } set { this["MediumKnobOverlay"] = value; } }
        public float MinValueAngle { get { return this[nameof(MinValueAngle)].GetValue<float>(); } set { this[nameof(MinValueAngle)].SetValue<float>(value); } }
        public float MaxValueAngle { get { return this[nameof(MaxValueAngle)].GetValue<float>(); } set { this[nameof(MaxValueAngle)].SetValue<float>(value); } }
        public ESynthKnobSize KnobSize { get { return (ESynthKnobSize)this[nameof(KnobSize)].GetValue<int>(); } set { this[nameof(KnobSize)].SetValue<int>((int)value); } }
    }
    public class SynthSlateStyle : SlateWidgetStyle
    {
        public SynthSlateStyle(nint addr) : base(addr) { }
        public ESynthSlateSizeType SizeType { get { return (ESynthSlateSizeType)this[nameof(SizeType)].GetValue<int>(); } set { this[nameof(SizeType)].SetValue<int>((int)value); } }
        public ESynthSlateColorStyle ColorStyle { get { return (ESynthSlateColorStyle)this[nameof(ColorStyle)].GetValue<int>(); } set { this[nameof(ColorStyle)].SetValue<int>((int)value); } }
    }
}
