using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.TemplateSequenceSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GameplayCamerasSDK
{
    public class LegacyCameraShake : CameraShakeBase
    {
        public LegacyCameraShake(nint addr) : base(addr) { }
        public float OscillationDuration { get { return this[nameof(OscillationDuration)].GetValue<float>(); } set { this[nameof(OscillationDuration)].SetValue<float>(value); } }
        public float OscillationBlendInTime { get { return this[nameof(OscillationBlendInTime)].GetValue<float>(); } set { this[nameof(OscillationBlendInTime)].SetValue<float>(value); } }
        public float OscillationBlendOutTime { get { return this[nameof(OscillationBlendOutTime)].GetValue<float>(); } set { this[nameof(OscillationBlendOutTime)].SetValue<float>(value); } }
        public ROscillator RotOscillation { get { return this[nameof(RotOscillation)].As<ROscillator>(); } set { this["RotOscillation"] = value; } }
        public VOscillator LocOscillation { get { return this[nameof(LocOscillation)].As<VOscillator>(); } set { this["LocOscillation"] = value; } }
        public FOscillator FOVOscillation { get { return this[nameof(FOVOscillation)].As<FOscillator>(); } set { this["FOVOscillation"] = value; } }
        public float AnimPlayRate { get { return this[nameof(AnimPlayRate)].GetValue<float>(); } set { this[nameof(AnimPlayRate)].SetValue<float>(value); } }
        public float AnimScale { get { return this[nameof(AnimScale)].GetValue<float>(); } set { this[nameof(AnimScale)].SetValue<float>(value); } }
        public float AnimBlendInTime { get { return this[nameof(AnimBlendInTime)].GetValue<float>(); } set { this[nameof(AnimBlendInTime)].SetValue<float>(value); } }
        public float AnimBlendOutTime { get { return this[nameof(AnimBlendOutTime)].GetValue<float>(); } set { this[nameof(AnimBlendOutTime)].SetValue<float>(value); } }
        public float RandomAnimSegmentDuration { get { return this[nameof(RandomAnimSegmentDuration)].GetValue<float>(); } set { this[nameof(RandomAnimSegmentDuration)].SetValue<float>(value); } }
        public CameraAnimationSequence AnimSequence { get { return this[nameof(AnimSequence)].As<CameraAnimationSequence>(); } set { this["AnimSequence"] = value; } }
        public bool bRandomAnimSegment { get { return this[nameof(bRandomAnimSegment)].Flag; } set { this[nameof(bRandomAnimSegment)].Flag = value; } }
        public float OscillatorTimeRemaining { get { return this[nameof(OscillatorTimeRemaining)].GetValue<float>(); } set { this[nameof(OscillatorTimeRemaining)].SetValue<float>(value); } }
        public SequenceCameraShakePattern SequenceShakePattern { get { return this[nameof(SequenceShakePattern)].As<SequenceCameraShakePattern>(); } set { this["SequenceShakePattern"] = value; } }
        public LegacyCameraShake StartLegacyCameraShakeFromSource(PlayerCameraManager PlayerCameraManager, Object ShakeClass, CameraShakeSourceComponent SourceComponent, float Scale, ECameraShakePlaySpace PlaySpace, Rotator UserPlaySpaceRot) { return Invoke<LegacyCameraShake>(nameof(StartLegacyCameraShakeFromSource), PlayerCameraManager, ShakeClass, SourceComponent, Scale, PlaySpace, UserPlaySpaceRot); }
        public LegacyCameraShake StartLegacyCameraShake(PlayerCameraManager PlayerCameraManager, Object ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, Rotator UserPlaySpaceRot) { return Invoke<LegacyCameraShake>(nameof(StartLegacyCameraShake), PlayerCameraManager, ShakeClass, Scale, PlaySpace, UserPlaySpaceRot); }
        public void ReceiveStopShake(bool bImmediately) { Invoke(nameof(ReceiveStopShake), bImmediately); }
        public void ReceivePlayShake(float Scale) { Invoke(nameof(ReceivePlayShake), Scale); }
        public bool ReceiveIsFinished() { return Invoke<bool>(nameof(ReceiveIsFinished)); }
        public void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, MinimalViewInfo POV, MinimalViewInfo ModifiedPOV) { Invoke(nameof(BlueprintUpdateCameraShake), DeltaTime, Alpha, POV, ModifiedPOV); }
    }
    public class LegacyCameraShakePattern : CameraShakePattern
    {
        public LegacyCameraShakePattern(nint addr) : base(addr) { }
    }
    public class LegacyCameraShakeFunctionLibrary : BlueprintFunctionLibrary
    {
        public LegacyCameraShakeFunctionLibrary(nint addr) : base(addr) { }
        public LegacyCameraShake Conv_LegacyCameraShake(CameraShakeBase CameraShake) { return Invoke<LegacyCameraShake>(nameof(Conv_LegacyCameraShake), CameraShake); }
    }
    public class CameraAnimationCameraModifier : CameraModifier
    {
        public CameraAnimationCameraModifier(nint addr) : base(addr) { }
        public Array<ActiveCameraAnimationInfo> ActiveAnimations { get { return new Array<ActiveCameraAnimationInfo>(this[nameof(ActiveAnimations)].Address); } }
        public ushort NextInstanceSerialNumber { get { return this[nameof(NextInstanceSerialNumber)].GetValue<ushort>(); } set { this[nameof(NextInstanceSerialNumber)].SetValue<ushort>(value); } }
        public void StopCameraAnimation(CameraAnimationHandle Handle, bool bImmediate) { Invoke(nameof(StopCameraAnimation), Handle, bImmediate); }
        public void StopAllCameraAnimationsOf(CameraAnimationSequence Sequence, bool bImmediate) { Invoke(nameof(StopAllCameraAnimationsOf), Sequence, bImmediate); }
        public void StopAllCameraAnimations(bool bImmediate) { Invoke(nameof(StopAllCameraAnimations), bImmediate); }
        public CameraAnimationHandle PlayCameraAnimation(CameraAnimationSequence Sequence, CameraAnimationParams Params) { return Invoke<CameraAnimationHandle>(nameof(PlayCameraAnimation), Sequence, Params); }
        public bool IsCameraAnimationActive(CameraAnimationHandle Handle) { return Invoke<bool>(nameof(IsCameraAnimationActive), Handle); }
        public CameraAnimationCameraModifier GetCameraAnimationCameraModifierFromPlayerController(PlayerController PlayerController) { return Invoke<CameraAnimationCameraModifier>(nameof(GetCameraAnimationCameraModifierFromPlayerController), PlayerController); }
        public CameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(Object WorldContextObject, int ControllerId) { return Invoke<CameraAnimationCameraModifier>(nameof(GetCameraAnimationCameraModifierFromID), WorldContextObject, ControllerId); }
        public CameraAnimationCameraModifier GetCameraAnimationCameraModifier(Object WorldContextObject, int PlayerIndex) { return Invoke<CameraAnimationCameraModifier>(nameof(GetCameraAnimationCameraModifier), WorldContextObject, PlayerIndex); }
    }
    public class GameplayCamerasFunctionLibrary : BlueprintFunctionLibrary
    {
        public GameplayCamerasFunctionLibrary(nint addr) : base(addr) { }
        public ECameraShakePlaySpace Conv_CameraShakePlaySpace(ECameraAnimationPlaySpace CameraAnimationPlaySpace) { return Invoke<ECameraShakePlaySpace>(nameof(Conv_CameraShakePlaySpace), CameraAnimationPlaySpace); }
        public ECameraAnimationPlaySpace Conv_CameraAnimationPlaySpace(ECameraShakePlaySpace CameraShakePlaySpace) { return Invoke<ECameraAnimationPlaySpace>(nameof(Conv_CameraAnimationPlaySpace), CameraShakePlaySpace); }
        public CameraAnimationCameraModifier Conv_CameraAnimationCameraModifier(PlayerCameraManager PlayerCameraManager) { return Invoke<CameraAnimationCameraModifier>(nameof(Conv_CameraAnimationCameraModifier), PlayerCameraManager); }
    }
    public class CompositeCameraShakePattern : CameraShakePattern
    {
        public CompositeCameraShakePattern(nint addr) : base(addr) { }
        public Array<CameraShakePattern> ChildPatterns { get { return new Array<CameraShakePattern>(this[nameof(ChildPatterns)].Address); } }
    }
    public class DefaultCameraShakeBase : CameraShakeBase
    {
        public DefaultCameraShakeBase(nint addr) : base(addr) { }
    }
    public class GameplayCamerasSubsystem : WorldSubsystem
    {
        public GameplayCamerasSubsystem(nint addr) : base(addr) { }
        public void StopCameraAnimation(PlayerController PlayerController, CameraAnimationHandle Handle, bool bImmediate) { Invoke(nameof(StopCameraAnimation), PlayerController, Handle, bImmediate); }
        public void StopAllCameraAnimationsOf(PlayerController PlayerController, CameraAnimationSequence Sequence, bool bImmediate) { Invoke(nameof(StopAllCameraAnimationsOf), PlayerController, Sequence, bImmediate); }
        public void StopAllCameraAnimations(PlayerController PlayerController, bool bImmediate) { Invoke(nameof(StopAllCameraAnimations), PlayerController, bImmediate); }
        public CameraAnimationHandle PlayCameraAnimation(PlayerController PlayerController, CameraAnimationSequence Sequence, CameraAnimationParams Params) { return Invoke<CameraAnimationHandle>(nameof(PlayCameraAnimation), PlayerController, Sequence, Params); }
        public bool IsCameraAnimationActive(PlayerController PlayerController, CameraAnimationHandle Handle) { return Invoke<bool>(nameof(IsCameraAnimationActive), PlayerController, Handle); }
    }
    public class SimpleCameraShakePattern : CameraShakePattern
    {
        public SimpleCameraShakePattern(nint addr) : base(addr) { }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
    }
    public class PerlinNoiseCameraShakePattern : SimpleCameraShakePattern
    {
        public PerlinNoiseCameraShakePattern(nint addr) : base(addr) { }
        public float LocationAmplitudeMultiplier { get { return this[nameof(LocationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(LocationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float LocationFrequencyMultiplier { get { return this[nameof(LocationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(LocationFrequencyMultiplier)].SetValue<float>(value); } }
        public PerlinNoiseShaker X { get { return this[nameof(X)].As<PerlinNoiseShaker>(); } set { this["X"] = value; } }
        public PerlinNoiseShaker Y { get { return this[nameof(Y)].As<PerlinNoiseShaker>(); } set { this["Y"] = value; } }
        public PerlinNoiseShaker Z { get { return this[nameof(Z)].As<PerlinNoiseShaker>(); } set { this["Z"] = value; } }
        public float RotationAmplitudeMultiplier { get { return this[nameof(RotationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(RotationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float RotationFrequencyMultiplier { get { return this[nameof(RotationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(RotationFrequencyMultiplier)].SetValue<float>(value); } }
        public PerlinNoiseShaker Pitch { get { return this[nameof(Pitch)].As<PerlinNoiseShaker>(); } set { this["Pitch"] = value; } }
        public PerlinNoiseShaker Yaw { get { return this[nameof(Yaw)].As<PerlinNoiseShaker>(); } set { this["Yaw"] = value; } }
        public PerlinNoiseShaker Roll { get { return this[nameof(Roll)].As<PerlinNoiseShaker>(); } set { this["Roll"] = value; } }
        public PerlinNoiseShaker FOV { get { return this[nameof(FOV)].As<PerlinNoiseShaker>(); } set { this["FOV"] = value; } }
    }
    public class TestCameraShake : CameraShakeBase
    {
        public TestCameraShake(nint addr) : base(addr) { }
    }
    public class ConstantCameraShakePattern : SimpleCameraShakePattern
    {
        public ConstantCameraShakePattern(nint addr) : base(addr) { }
        public Vector LocationOffset { get { return this[nameof(LocationOffset)].As<Vector>(); } set { this["LocationOffset"] = value; } }
        public Rotator RotationOffset { get { return this[nameof(RotationOffset)].As<Rotator>(); } set { this["RotationOffset"] = value; } }
    }
    public class WaveOscillatorCameraShakePattern : SimpleCameraShakePattern
    {
        public WaveOscillatorCameraShakePattern(nint addr) : base(addr) { }
        public float LocationAmplitudeMultiplier { get { return this[nameof(LocationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(LocationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float LocationFrequencyMultiplier { get { return this[nameof(LocationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(LocationFrequencyMultiplier)].SetValue<float>(value); } }
        public WaveOscillator X { get { return this[nameof(X)].As<WaveOscillator>(); } set { this["X"] = value; } }
        public WaveOscillator Y { get { return this[nameof(Y)].As<WaveOscillator>(); } set { this["Y"] = value; } }
        public WaveOscillator Z { get { return this[nameof(Z)].As<WaveOscillator>(); } set { this["Z"] = value; } }
        public float RotationAmplitudeMultiplier { get { return this[nameof(RotationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(RotationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float RotationFrequencyMultiplier { get { return this[nameof(RotationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(RotationFrequencyMultiplier)].SetValue<float>(value); } }
        public WaveOscillator Pitch { get { return this[nameof(Pitch)].As<WaveOscillator>(); } set { this["Pitch"] = value; } }
        public WaveOscillator Yaw { get { return this[nameof(Yaw)].As<WaveOscillator>(); } set { this["Yaw"] = value; } }
        public WaveOscillator Roll { get { return this[nameof(Roll)].As<WaveOscillator>(); } set { this["Roll"] = value; } }
        public WaveOscillator FOV { get { return this[nameof(FOV)].As<WaveOscillator>(); } set { this["FOV"] = value; } }
    }
    public enum EOscillatorWaveform : int
    {
        SineWave = 0,
        PerlinNoise = 1,
        EOscillatorWaveform_MAX = 2,
    }
    public enum EInitialOscillatorOffset : int
    {
        EOO_OffsetRandom = 0,
        EOO_OffsetZero = 1,
        EOO_MAX = 2,
    }
    public enum ECameraAnimationPlaySpace : int
    {
        CameraLocal = 0,
        World = 1,
        UserDefined = 2,
        ECameraAnimationPlaySpace_MAX = 3,
    }
    public enum ECameraAnimationEasingType : int
    {
        Linear = 0,
        Sinusoidal = 1,
        Quadratic = 2,
        Cubic = 3,
        Quartic = 4,
        Quintic = 5,
        Exponential = 6,
        Circular = 7,
        ECameraAnimationEasingType_MAX = 8,
    }
    public enum EInitialWaveOscillatorOffsetType : int
    {
        Random = 0,
        Zero = 1,
        EInitialWaveOscillatorOffsetType_MAX = 2,
    }
    public class FOscillator : Object
    {
        public FOscillator(nint addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public byte InitialOffset { get { return this[nameof(InitialOffset)].GetValue<byte>(); } set { this[nameof(InitialOffset)].SetValue<byte>(value); } }
        public EOscillatorWaveform Waveform { get { return (EOscillatorWaveform)this[nameof(Waveform)].GetValue<int>(); } set { this[nameof(Waveform)].SetValue<int>((int)value); } }
    }
    public class ROscillator : Object
    {
        public ROscillator(nint addr) : base(addr) { }
        public FOscillator Pitch { get { return this[nameof(Pitch)].As<FOscillator>(); } set { this["Pitch"] = value; } }
        public FOscillator Yaw { get { return this[nameof(Yaw)].As<FOscillator>(); } set { this["Yaw"] = value; } }
        public FOscillator Roll { get { return this[nameof(Roll)].As<FOscillator>(); } set { this["Roll"] = value; } }
    }
    public class VOscillator : Object
    {
        public VOscillator(nint addr) : base(addr) { }
        public FOscillator X { get { return this[nameof(X)].As<FOscillator>(); } set { this["X"] = value; } }
        public FOscillator Y { get { return this[nameof(Y)].As<FOscillator>(); } set { this["Y"] = value; } }
        public FOscillator Z { get { return this[nameof(Z)].As<FOscillator>(); } set { this["Z"] = value; } }
    }
    public class CameraAnimationParams : Object
    {
        public CameraAnimationParams(nint addr) : base(addr) { }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public ECameraAnimationEasingType EaseInType { get { return (ECameraAnimationEasingType)this[nameof(EaseInType)].GetValue<int>(); } set { this[nameof(EaseInType)].SetValue<int>((int)value); } }
        public float EaseInDuration { get { return this[nameof(EaseInDuration)].GetValue<float>(); } set { this[nameof(EaseInDuration)].SetValue<float>(value); } }
        public ECameraAnimationEasingType EaseOutType { get { return (ECameraAnimationEasingType)this[nameof(EaseOutType)].GetValue<int>(); } set { this[nameof(EaseOutType)].SetValue<int>((int)value); } }
        public float EaseOutDuration { get { return this[nameof(EaseOutDuration)].GetValue<float>(); } set { this[nameof(EaseOutDuration)].SetValue<float>(value); } }
        public bool bLoop { get { return this[nameof(bLoop)].Flag; } set { this[nameof(bLoop)].Flag = value; } }
        public bool bRandomStartTime { get { return this[nameof(bRandomStartTime)].Flag; } set { this[nameof(bRandomStartTime)].Flag = value; } }
        public float DurationOverride { get { return this[nameof(DurationOverride)].GetValue<float>(); } set { this[nameof(DurationOverride)].SetValue<float>(value); } }
        public ECameraAnimationPlaySpace PlaySpace { get { return (ECameraAnimationPlaySpace)this[nameof(PlaySpace)].GetValue<int>(); } set { this[nameof(PlaySpace)].SetValue<int>((int)value); } }
        public Rotator UserPlaySpaceRot { get { return this[nameof(UserPlaySpaceRot)].As<Rotator>(); } set { this["UserPlaySpaceRot"] = value; } }
    }
    public class CameraAnimationHandle : Object
    {
        public CameraAnimationHandle(nint addr) : base(addr) { }
    }
    public class ActiveCameraAnimationInfo : Object
    {
        public ActiveCameraAnimationInfo(nint addr) : base(addr) { }
        public CameraAnimationSequence Sequence { get { return this[nameof(Sequence)].As<CameraAnimationSequence>(); } set { this["Sequence"] = value; } }
        public CameraAnimationParams Params { get { return this[nameof(Params)].As<CameraAnimationParams>(); } set { this["Params"] = value; } }
        public CameraAnimationHandle Handle { get { return this[nameof(Handle)].As<CameraAnimationHandle>(); } set { this["Handle"] = value; } }
        public CameraAnimationSequencePlayer Player { get { return this[nameof(Player)].As<CameraAnimationSequencePlayer>(); } set { this["Player"] = value; } }
        public CameraAnimationSequenceCameraStandIn CameraStandIn { get { return this[nameof(CameraStandIn)].As<CameraAnimationSequenceCameraStandIn>(); } set { this["CameraStandIn"] = value; } }
        public float EaseInCurrentTime { get { return this[nameof(EaseInCurrentTime)].GetValue<float>(); } set { this[nameof(EaseInCurrentTime)].SetValue<float>(value); } }
        public float EaseOutCurrentTime { get { return this[nameof(EaseOutCurrentTime)].GetValue<float>(); } set { this[nameof(EaseOutCurrentTime)].SetValue<float>(value); } }
        public bool bIsEasingIn { get { return this[nameof(bIsEasingIn)].Flag; } set { this[nameof(bIsEasingIn)].Flag = value; } }
        public bool bIsEasingOut { get { return this[nameof(bIsEasingOut)].Flag; } set { this[nameof(bIsEasingOut)].Flag = value; } }
    }
    public class PerlinNoiseShaker : Object
    {
        public PerlinNoiseShaker(nint addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
    }
    public class WaveOscillator : Object
    {
        public WaveOscillator(nint addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public EInitialWaveOscillatorOffsetType InitialOffsetType { get { return (EInitialWaveOscillatorOffsetType)this[nameof(InitialOffsetType)].GetValue<int>(); } set { this[nameof(InitialOffsetType)].SetValue<int>((int)value); } }
    }
}
