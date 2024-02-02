using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.EyeTrackerSDK
{
    public class EyeTrackerFunctionLibrary : BlueprintFunctionLibrary
    {
        public EyeTrackerFunctionLibrary(nint addr) : base(addr) { }
        public void SetEyeTrackedPlayer(PlayerController PlayerController) { Invoke(nameof(SetEyeTrackedPlayer), PlayerController); }
        public bool IsStereoGazeDataAvailable() { return Invoke<bool>(nameof(IsStereoGazeDataAvailable)); }
        public bool IsEyeTrackerConnected() { return Invoke<bool>(nameof(IsEyeTrackerConnected)); }
        public bool GetStereoGazeData(EyeTrackerStereoGazeData OutGazeData) { return Invoke<bool>(nameof(GetStereoGazeData), OutGazeData); }
        public bool GetGazeData(EyeTrackerGazeData OutGazeData) { return Invoke<bool>(nameof(GetGazeData), OutGazeData); }
    }
    public enum EEyeTrackerStatus : int
    {
        NotConnected = 0,
        NotTracking = 1,
        Tracking = 2,
        EEyeTrackerStatus_MAX = 3,
    }
    public class EyeTrackerGazeData : Object
    {
        public EyeTrackerGazeData(nint addr) : base(addr) { }
        public Vector GazeOrigin { get { return this[nameof(GazeOrigin)].As<Vector>(); } set { this["GazeOrigin"] = value; } }
        public Vector GazeDirection { get { return this[nameof(GazeDirection)].As<Vector>(); } set { this["GazeDirection"] = value; } }
        public Vector FixationPoint { get { return this[nameof(FixationPoint)].As<Vector>(); } set { this["FixationPoint"] = value; } }
        public float ConfidenceValue { get { return this[nameof(ConfidenceValue)].GetValue<float>(); } set { this[nameof(ConfidenceValue)].SetValue<float>(value); } }
        public bool bIsLeftEyeBlink { get { return this[nameof(bIsLeftEyeBlink)].Flag; } set { this[nameof(bIsLeftEyeBlink)].Flag = value; } }
        public bool bIsRightEyeBlink { get { return this[nameof(bIsRightEyeBlink)].Flag; } set { this[nameof(bIsRightEyeBlink)].Flag = value; } }
        public float LeftPupilDiameter { get { return this[nameof(LeftPupilDiameter)].GetValue<float>(); } set { this[nameof(LeftPupilDiameter)].SetValue<float>(value); } }
        public float RightPupilDiameter { get { return this[nameof(RightPupilDiameter)].GetValue<float>(); } set { this[nameof(RightPupilDiameter)].SetValue<float>(value); } }
    }
    public class EyeTrackerStereoGazeData : Object
    {
        public EyeTrackerStereoGazeData(nint addr) : base(addr) { }
        public Vector LeftEyeOrigin { get { return this[nameof(LeftEyeOrigin)].As<Vector>(); } set { this["LeftEyeOrigin"] = value; } }
        public Vector LeftEyeDirection { get { return this[nameof(LeftEyeDirection)].As<Vector>(); } set { this["LeftEyeDirection"] = value; } }
        public Vector RightEyeOrigin { get { return this[nameof(RightEyeOrigin)].As<Vector>(); } set { this["RightEyeOrigin"] = value; } }
        public Vector RightEyeDirection { get { return this[nameof(RightEyeDirection)].As<Vector>(); } set { this["RightEyeDirection"] = value; } }
        public Vector FixationPoint { get { return this[nameof(FixationPoint)].As<Vector>(); } set { this["FixationPoint"] = value; } }
        public float ConfidenceValue { get { return this[nameof(ConfidenceValue)].GetValue<float>(); } set { this[nameof(ConfidenceValue)].SetValue<float>(value); } }
    }
}
