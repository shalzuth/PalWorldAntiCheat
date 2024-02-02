using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.CinematicCameraSDK
{
    public class CineCameraSettings : DeveloperSettings
    {
        public CineCameraSettings(nint addr) : base(addr) { }
        public Object DefaultLensPresetName { get { return this[nameof(DefaultLensPresetName)]; } set { this[nameof(DefaultLensPresetName)] = value; } }
        public float DefaultLensFocalLength { get { return this[nameof(DefaultLensFocalLength)].GetValue<float>(); } set { this[nameof(DefaultLensFocalLength)].SetValue<float>(value); } }
        public float DefaultLensFStop { get { return this[nameof(DefaultLensFStop)].GetValue<float>(); } set { this[nameof(DefaultLensFStop)].SetValue<float>(value); } }
        public Array<NamedLensPreset> LensPresets { get { return new Array<NamedLensPreset>(this[nameof(LensPresets)].Address); } }
        public Object DefaultFilmbackPreset { get { return this[nameof(DefaultFilmbackPreset)]; } set { this[nameof(DefaultFilmbackPreset)] = value; } }
        public Array<NamedFilmbackPreset> FilmbackPresets { get { return new Array<NamedFilmbackPreset>(this[nameof(FilmbackPresets)].Address); } }
        public Object DefaultCropPresetName { get { return this[nameof(DefaultCropPresetName)]; } set { this[nameof(DefaultCropPresetName)] = value; } }
        public Array<NamedPlateCropPreset> CropPresets { get { return new Array<NamedPlateCropPreset>(this[nameof(CropPresets)].Address); } }
        public void SetLensPresets(Array<NamedLensPreset> InLensPresets) { Invoke(nameof(SetLensPresets), InLensPresets); }
        public void SetFilmbackPresets(Array<NamedFilmbackPreset> InFilmbackPresets) { Invoke(nameof(SetFilmbackPresets), InFilmbackPresets); }
        public void SetDefaultLensPresetName(Object InDefaultLensPresetName) { Invoke(nameof(SetDefaultLensPresetName), InDefaultLensPresetName); }
        public void SetDefaultLensFStop(float InDefaultLensFStop) { Invoke(nameof(SetDefaultLensFStop), InDefaultLensFStop); }
        public void SetDefaultLensFocalLength(float InDefaultLensFocalLength) { Invoke(nameof(SetDefaultLensFocalLength), InDefaultLensFocalLength); }
        public void SetDefaultFilmbackPreset(Object InDefaultFilmbackPreset) { Invoke(nameof(SetDefaultFilmbackPreset), InDefaultFilmbackPreset); }
        public void SetDefaultCropPresetName(Object InDefaultCropPresetName) { Invoke(nameof(SetDefaultCropPresetName), InDefaultCropPresetName); }
        public void SetCropPresets(Array<NamedPlateCropPreset> InCropPresets) { Invoke(nameof(SetCropPresets), InCropPresets); }
        public Array<Object> GetLensPresetNames() { return Invoke<Array<Object>>(nameof(GetLensPresetNames)); }
        public bool GetLensPresetByName(Object PresetName, CameraLensSettings LensSettings) { return Invoke<bool>(nameof(GetLensPresetByName), PresetName, LensSettings); }
        public Array<Object> GetFilmbackPresetNames() { return Invoke<Array<Object>>(nameof(GetFilmbackPresetNames)); }
        public bool GetFilmbackPresetByName(Object PresetName, CameraFilmbackSettings FilmbackSettings) { return Invoke<bool>(nameof(GetFilmbackPresetByName), PresetName, FilmbackSettings); }
        public Array<Object> GetCropPresetNames() { return Invoke<Array<Object>>(nameof(GetCropPresetNames)); }
        public bool GetCropPresetByName(Object PresetName, PlateCropSettings CropSettings) { return Invoke<bool>(nameof(GetCropPresetByName), PresetName, CropSettings); }
        public CineCameraSettings GetCineCameraSettings() { return Invoke<CineCameraSettings>(nameof(GetCineCameraSettings)); }
    }
    public class CameraRig_Crane : Actor
    {
        public CameraRig_Crane(nint addr) : base(addr) { }
        public float CranePitch { get { return this[nameof(CranePitch)].GetValue<float>(); } set { this[nameof(CranePitch)].SetValue<float>(value); } }
        public float CraneYaw { get { return this[nameof(CraneYaw)].GetValue<float>(); } set { this[nameof(CraneYaw)].SetValue<float>(value); } }
        public float CraneArmLength { get { return this[nameof(CraneArmLength)].GetValue<float>(); } set { this[nameof(CraneArmLength)].SetValue<float>(value); } }
        public bool bLockMountPitch { get { return this[nameof(bLockMountPitch)].Flag; } set { this[nameof(bLockMountPitch)].Flag = value; } }
        public bool bLockMountYaw { get { return this[nameof(bLockMountYaw)].Flag; } set { this[nameof(bLockMountYaw)].Flag = value; } }
        public SceneComponent TransformComponent { get { return this[nameof(TransformComponent)].As<SceneComponent>(); } set { this["TransformComponent"] = value; } }
        public SceneComponent CraneYawControl { get { return this[nameof(CraneYawControl)].As<SceneComponent>(); } set { this["CraneYawControl"] = value; } }
        public SceneComponent CranePitchControl { get { return this[nameof(CranePitchControl)].As<SceneComponent>(); } set { this["CranePitchControl"] = value; } }
        public SceneComponent CraneCameraMount { get { return this[nameof(CraneCameraMount)].As<SceneComponent>(); } set { this["CraneCameraMount"] = value; } }
    }
    public class CameraRig_Rail : Actor
    {
        public CameraRig_Rail(nint addr) : base(addr) { }
        public float CurrentPositionOnRail { get { return this[nameof(CurrentPositionOnRail)].GetValue<float>(); } set { this[nameof(CurrentPositionOnRail)].SetValue<float>(value); } }
        public bool bLockOrientationToRail { get { return this[nameof(bLockOrientationToRail)].Flag; } set { this[nameof(bLockOrientationToRail)].Flag = value; } }
        public SceneComponent TransformComponent { get { return this[nameof(TransformComponent)].As<SceneComponent>(); } set { this["TransformComponent"] = value; } }
        public SplineComponent RailSplineComponent { get { return this[nameof(RailSplineComponent)].As<SplineComponent>(); } set { this["RailSplineComponent"] = value; } }
        public SceneComponent RailCameraMount { get { return this[nameof(RailCameraMount)].As<SceneComponent>(); } set { this["RailCameraMount"] = value; } }
        public SplineComponent GetRailSplineComponent() { return Invoke<SplineComponent>(nameof(GetRailSplineComponent)); }
    }
    public class CineCameraActor : CameraActor
    {
        public CineCameraActor(nint addr) : base(addr) { }
        public CameraLookatTrackingSettings LookatTrackingSettings { get { return this[nameof(LookatTrackingSettings)].As<CameraLookatTrackingSettings>(); } set { this["LookatTrackingSettings"] = value; } }
        public CineCameraComponent GetCineCameraComponent() { return Invoke<CineCameraComponent>(nameof(GetCineCameraComponent)); }
    }
    public class CineCameraComponent : CameraComponent
    {
        public CineCameraComponent(nint addr) : base(addr) { }
        public CameraFilmbackSettings FilmbackSettings { get { return this[nameof(FilmbackSettings)].As<CameraFilmbackSettings>(); } set { this["FilmbackSettings"] = value; } }
        public CameraFilmbackSettings Filmback { get { return this[nameof(Filmback)].As<CameraFilmbackSettings>(); } set { this["Filmback"] = value; } }
        public CameraLensSettings LensSettings { get { return this[nameof(LensSettings)].As<CameraLensSettings>(); } set { this["LensSettings"] = value; } }
        public CameraFocusSettings FocusSettings { get { return this[nameof(FocusSettings)].As<CameraFocusSettings>(); } set { this["FocusSettings"] = value; } }
        public PlateCropSettings CropSettings { get { return this[nameof(CropSettings)].As<PlateCropSettings>(); } set { this["CropSettings"] = value; } }
        public float CurrentFocalLength { get { return this[nameof(CurrentFocalLength)].GetValue<float>(); } set { this[nameof(CurrentFocalLength)].SetValue<float>(value); } }
        public float CurrentAperture { get { return this[nameof(CurrentAperture)].GetValue<float>(); } set { this[nameof(CurrentAperture)].SetValue<float>(value); } }
        public float CurrentFocusDistance { get { return this[nameof(CurrentFocusDistance)].GetValue<float>(); } set { this[nameof(CurrentFocusDistance)].SetValue<float>(value); } }
        public bool bOverride_CustomNearClippingPlane { get { return this[nameof(bOverride_CustomNearClippingPlane)].Flag; } set { this[nameof(bOverride_CustomNearClippingPlane)].Flag = value; } }
        public float CustomNearClippingPlane { get { return this[nameof(CustomNearClippingPlane)].GetValue<float>(); } set { this[nameof(CustomNearClippingPlane)].SetValue<float>(value); } }
        public Array<NamedFilmbackPreset> FilmbackPresets { get { return new Array<NamedFilmbackPreset>(this[nameof(FilmbackPresets)].Address); } }
        public Array<NamedLensPreset> LensPresets { get { return new Array<NamedLensPreset>(this[nameof(LensPresets)].Address); } }
        public Object DefaultFilmbackPresetName { get { return this[nameof(DefaultFilmbackPresetName)]; } set { this[nameof(DefaultFilmbackPresetName)] = value; } }
        public Object DefaultFilmbackPreset { get { return this[nameof(DefaultFilmbackPreset)]; } set { this[nameof(DefaultFilmbackPreset)] = value; } }
        public Object DefaultLensPresetName { get { return this[nameof(DefaultLensPresetName)]; } set { this[nameof(DefaultLensPresetName)] = value; } }
        public float DefaultLensFocalLength { get { return this[nameof(DefaultLensFocalLength)].GetValue<float>(); } set { this[nameof(DefaultLensFocalLength)].SetValue<float>(value); } }
        public float DefaultLensFStop { get { return this[nameof(DefaultLensFStop)].GetValue<float>(); } set { this[nameof(DefaultLensFStop)].SetValue<float>(value); } }
        public void SetLensSettings(CameraLensSettings NewLensSettings) { Invoke(nameof(SetLensSettings), NewLensSettings); }
        public void SetLensPresetByName(Object InPresetName) { Invoke(nameof(SetLensPresetByName), InPresetName); }
        public void SetFocusSettings(CameraFocusSettings NewFocusSettings) { Invoke(nameof(SetFocusSettings), NewFocusSettings); }
        public void SetFilmbackPresetByName(Object InPresetName) { Invoke(nameof(SetFilmbackPresetByName), InPresetName); }
        public void SetFilmback(CameraFilmbackSettings NewFilmback) { Invoke(nameof(SetFilmback), NewFilmback); }
        public void SetCurrentFocalLength(float InFocalLength) { Invoke(nameof(SetCurrentFocalLength), InFocalLength); }
        public void SetCurrentAperture(float NewCurrentAperture) { Invoke(nameof(SetCurrentAperture), NewCurrentAperture); }
        public void SetCropSettings(PlateCropSettings NewCropSettings) { Invoke(nameof(SetCropSettings), NewCropSettings); }
        public void SetCropPresetByName(Object InPresetName) { Invoke(nameof(SetCropPresetByName), InPresetName); }
        public float GetVerticalFieldOfView() { return Invoke<float>(nameof(GetVerticalFieldOfView)); }
        public Array<NamedLensPreset> GetLensPresetsCopy() { return Invoke<Array<NamedLensPreset>>(nameof(GetLensPresetsCopy)); }
        public Object GetLensPresetName() { return Invoke<Object>(nameof(GetLensPresetName)); }
        public float GetHorizontalFieldOfView() { return Invoke<float>(nameof(GetHorizontalFieldOfView)); }
        public Array<NamedFilmbackPreset> GetFilmbackPresetsCopy() { return Invoke<Array<NamedFilmbackPreset>>(nameof(GetFilmbackPresetsCopy)); }
        public Object GetFilmbackPresetName() { return Invoke<Object>(nameof(GetFilmbackPresetName)); }
        public Object GetDefaultFilmbackPresetName() { return Invoke<Object>(nameof(GetDefaultFilmbackPresetName)); }
        public Object GetCropPresetName() { return Invoke<Object>(nameof(GetCropPresetName)); }
    }
    public enum ECameraFocusMethod : int
    {
        DoNotOverride = 0,
        Manual = 1,
        Tracking = 2,
        Disable = 3,
        MAX = 4,
    }
    public class CameraFilmbackSettings : Object
    {
        public CameraFilmbackSettings(nint addr) : base(addr) { }
        public float SensorWidth { get { return this[nameof(SensorWidth)].GetValue<float>(); } set { this[nameof(SensorWidth)].SetValue<float>(value); } }
        public float SensorHeight { get { return this[nameof(SensorHeight)].GetValue<float>(); } set { this[nameof(SensorHeight)].SetValue<float>(value); } }
        public float SensorAspectRatio { get { return this[nameof(SensorAspectRatio)].GetValue<float>(); } set { this[nameof(SensorAspectRatio)].SetValue<float>(value); } }
    }
    public class NamedFilmbackPreset : Object
    {
        public NamedFilmbackPreset(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public CameraFilmbackSettings FilmbackSettings { get { return this[nameof(FilmbackSettings)].As<CameraFilmbackSettings>(); } set { this["FilmbackSettings"] = value; } }
    }
    public class CameraLensSettings : Object
    {
        public CameraLensSettings(nint addr) : base(addr) { }
        public float MinFocalLength { get { return this[nameof(MinFocalLength)].GetValue<float>(); } set { this[nameof(MinFocalLength)].SetValue<float>(value); } }
        public float MaxFocalLength { get { return this[nameof(MaxFocalLength)].GetValue<float>(); } set { this[nameof(MaxFocalLength)].SetValue<float>(value); } }
        public float MinFStop { get { return this[nameof(MinFStop)].GetValue<float>(); } set { this[nameof(MinFStop)].SetValue<float>(value); } }
        public float MaxFStop { get { return this[nameof(MaxFStop)].GetValue<float>(); } set { this[nameof(MaxFStop)].SetValue<float>(value); } }
        public float MinimumFocusDistance { get { return this[nameof(MinimumFocusDistance)].GetValue<float>(); } set { this[nameof(MinimumFocusDistance)].SetValue<float>(value); } }
        public float SqueezeFactor { get { return this[nameof(SqueezeFactor)].GetValue<float>(); } set { this[nameof(SqueezeFactor)].SetValue<float>(value); } }
        public int DiaphragmBladeCount { get { return this[nameof(DiaphragmBladeCount)].GetValue<int>(); } set { this[nameof(DiaphragmBladeCount)].SetValue<int>(value); } }
    }
    public class NamedLensPreset : Object
    {
        public NamedLensPreset(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public CameraLensSettings LensSettings { get { return this[nameof(LensSettings)].As<CameraLensSettings>(); } set { this["LensSettings"] = value; } }
    }
    public class PlateCropSettings : Object
    {
        public PlateCropSettings(nint addr) : base(addr) { }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
    }
    public class NamedPlateCropPreset : Object
    {
        public NamedPlateCropPreset(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public PlateCropSettings CropSettings { get { return this[nameof(CropSettings)].As<PlateCropSettings>(); } set { this["CropSettings"] = value; } }
    }
    public class CameraTrackingFocusSettings : Object
    {
        public CameraTrackingFocusSettings(nint addr) : base(addr) { }
        public Object ActorToTrack { get { return this[nameof(ActorToTrack)]; } set { this[nameof(ActorToTrack)] = value; } }
        public Vector RelativeOffset { get { return this[nameof(RelativeOffset)].As<Vector>(); } set { this["RelativeOffset"] = value; } }
        public bool bDrawDebugTrackingFocusPoint { get { return this[nameof(bDrawDebugTrackingFocusPoint)].Flag; } set { this[nameof(bDrawDebugTrackingFocusPoint)].Flag = value; } }
    }
    public class CameraFocusSettings : Object
    {
        public CameraFocusSettings(nint addr) : base(addr) { }
        public ECameraFocusMethod FocusMethod { get { return (ECameraFocusMethod)this[nameof(FocusMethod)].GetValue<int>(); } set { this[nameof(FocusMethod)].SetValue<int>((int)value); } }
        public float ManualFocusDistance { get { return this[nameof(ManualFocusDistance)].GetValue<float>(); } set { this[nameof(ManualFocusDistance)].SetValue<float>(value); } }
        public CameraTrackingFocusSettings TrackingFocusSettings { get { return this[nameof(TrackingFocusSettings)].As<CameraTrackingFocusSettings>(); } set { this["TrackingFocusSettings"] = value; } }
        public bool bSmoothFocusChanges { get { return this[nameof(bSmoothFocusChanges)].Flag; } set { this[nameof(bSmoothFocusChanges)].Flag = value; } }
        public float FocusSmoothingInterpSpeed { get { return this[nameof(FocusSmoothingInterpSpeed)].GetValue<float>(); } set { this[nameof(FocusSmoothingInterpSpeed)].SetValue<float>(value); } }
        public float FocusOffset { get { return this[nameof(FocusOffset)].GetValue<float>(); } set { this[nameof(FocusOffset)].SetValue<float>(value); } }
    }
    public class CameraLookatTrackingSettings : Object
    {
        public CameraLookatTrackingSettings(nint addr) : base(addr) { }
        public bool bEnableLookAtTracking { get { return this[nameof(bEnableLookAtTracking)].Flag; } set { this[nameof(bEnableLookAtTracking)].Flag = value; } }
        public bool bDrawDebugLookAtTrackingPosition { get { return this[nameof(bDrawDebugLookAtTrackingPosition)].Flag; } set { this[nameof(bDrawDebugLookAtTrackingPosition)].Flag = value; } }
        public float LookAtTrackingInterpSpeed { get { return this[nameof(LookAtTrackingInterpSpeed)].GetValue<float>(); } set { this[nameof(LookAtTrackingInterpSpeed)].SetValue<float>(value); } }
        public Object ActorToTrack { get { return this[nameof(ActorToTrack)]; } set { this[nameof(ActorToTrack)] = value; } }
        public Vector RelativeOffset { get { return this[nameof(RelativeOffset)].As<Vector>(); } set { this["RelativeOffset"] = value; } }
        public bool bAllowRoll { get { return this[nameof(bAllowRoll)].Flag; } set { this[nameof(bAllowRoll)].Flag = value; } }
    }
}
