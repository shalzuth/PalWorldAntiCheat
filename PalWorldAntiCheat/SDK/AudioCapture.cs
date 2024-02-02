using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.AudioMixerSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioCaptureSDK
{
    public class AudioCapture : AudioGenerator
    {
        public AudioCapture(nint addr) : base(addr) { }
        public void StopCapturingAudio() { Invoke(nameof(StopCapturingAudio)); }
        public void StartCapturingAudio() { Invoke(nameof(StartCapturingAudio)); }
        public bool IsCapturingAudio() { return Invoke<bool>(nameof(IsCapturingAudio)); }
        public bool GetAudioCaptureDeviceInfo(AudioCaptureDeviceInfo OutInfo) { return Invoke<bool>(nameof(GetAudioCaptureDeviceInfo), OutInfo); }
    }
    public class AudioCaptureFunctionLibrary : BlueprintFunctionLibrary
    {
        public AudioCaptureFunctionLibrary(nint addr) : base(addr) { }
        public AudioCapture CreateAudioCapture() { return Invoke<AudioCapture>(nameof(CreateAudioCapture)); }
    }
    public class AudioCaptureBlueprintLibrary : BlueprintFunctionLibrary
    {
        public AudioCaptureBlueprintLibrary(nint addr) : base(addr) { }
        public void GetAvailableAudioInputDevices(Object WorldContextObject, Object OnObtainDevicesEvent) { Invoke(nameof(GetAvailableAudioInputDevices), WorldContextObject, OnObtainDevicesEvent); }
        public Object Conv_AudioInputDeviceInfoToString(AudioInputDeviceInfo Info) { return Invoke<Object>(nameof(Conv_AudioInputDeviceInfoToString), Info); }
    }
    public class AudioCaptureComponent : SynthComponent
    {
        public AudioCaptureComponent(nint addr) : base(addr) { }
        public int JitterLatencyFrames { get { return this[nameof(JitterLatencyFrames)].GetValue<int>(); } set { this[nameof(JitterLatencyFrames)].SetValue<int>(value); } }
    }
    public class AudioInputDeviceInfo : Object
    {
        public AudioInputDeviceInfo(nint addr) : base(addr) { }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public Object DeviceID { get { return this[nameof(DeviceID)]; } set { this[nameof(DeviceID)] = value; } }
        public int InputChannels { get { return this[nameof(InputChannels)].GetValue<int>(); } set { this[nameof(InputChannels)].SetValue<int>(value); } }
        public int PreferredSampleRate { get { return this[nameof(PreferredSampleRate)].GetValue<int>(); } set { this[nameof(PreferredSampleRate)].SetValue<int>(value); } }
        public bool bSupportsHardwareAEC { get { return this[nameof(bSupportsHardwareAEC)].Flag; } set { this[nameof(bSupportsHardwareAEC)].Flag = value; } }
    }
    public class AudioCaptureDeviceInfo : Object
    {
        public AudioCaptureDeviceInfo(nint addr) : base(addr) { }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public int NumInputChannels { get { return this[nameof(NumInputChannels)].GetValue<int>(); } set { this[nameof(NumInputChannels)].SetValue<int>(value); } }
        public int SampleRate { get { return this[nameof(SampleRate)].GetValue<int>(); } set { this[nameof(SampleRate)].SetValue<int>(value); } }
    }
}
