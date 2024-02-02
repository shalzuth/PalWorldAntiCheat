using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.InputCoreSDK;
namespace SDK.Script.HeadMountedDisplaySDK
{
    public class HandKeypointConversion : BlueprintFunctionLibrary
    {
        public HandKeypointConversion(nint addr) : base(addr) { }
        public int Conv_HandKeypointToInt32(EHandKeypoint Input) { return Invoke<int>(nameof(Conv_HandKeypointToInt32), Input); }
    }
    public class HeadMountedDisplayFunctionLibrary : BlueprintFunctionLibrary
    {
        public HeadMountedDisplayFunctionLibrary(nint addr) : base(addr) { }
        public void UpdateExternalTrackingHMDPosition(Transform ExternalTrackingTransform) { Invoke(nameof(UpdateExternalTrackingHMDPosition), ExternalTrackingTransform); }
        public void SetXRTimedInputActionDelegate(Object ActionName, Object InDelegate) { Invoke(nameof(SetXRTimedInputActionDelegate), ActionName, InDelegate); }
        public void SetXRDisconnectDelegate(Object InDisconnectedDelegate) { Invoke(nameof(SetXRDisconnectDelegate), InDisconnectedDelegate); }
        public void SetWorldToMetersScale(Object WorldContext, float NewScale) { Invoke(nameof(SetWorldToMetersScale), WorldContext, NewScale); }
        public void SetTrackingOrigin(byte Origin) { Invoke(nameof(SetTrackingOrigin), Origin); }
        public void SetSpectatorScreenTexture(Texture InTexture) { Invoke(nameof(SetSpectatorScreenTexture), InTexture); }
        public void SetSpectatorScreenModeTexturePlusEyeLayout(Vector2D EyeRectMin, Vector2D EyeRectMax, Vector2D TextureRectMin, Vector2D TextureRectMax, bool bDrawEyeFirst, bool bClearBlack, bool bUseAlpha) { Invoke(nameof(SetSpectatorScreenModeTexturePlusEyeLayout), EyeRectMin, EyeRectMax, TextureRectMin, TextureRectMax, bDrawEyeFirst, bClearBlack, bUseAlpha); }
        public void SetSpectatorScreenMode(ESpectatorScreenMode Mode) { Invoke(nameof(SetSpectatorScreenMode), Mode); }
        public void SetClippingPlanes(float Near, float Far) { Invoke(nameof(SetClippingPlanes), Near, Far); }
        public void ResetOrientationAndPosition(float Yaw, byte Options) { Invoke(nameof(ResetOrientationAndPosition), Yaw, Options); }
        public bool IsSpectatorScreenModeControllable() { return Invoke<bool>(nameof(IsSpectatorScreenModeControllable)); }
        public bool IsInLowPersistenceMode() { return Invoke<bool>(nameof(IsInLowPersistenceMode)); }
        public bool IsHeadMountedDisplayEnabled() { return Invoke<bool>(nameof(IsHeadMountedDisplayEnabled)); }
        public bool IsHeadMountedDisplayConnected() { return Invoke<bool>(nameof(IsHeadMountedDisplayConnected)); }
        public bool IsDeviceTracking(XRDeviceId XRDeviceId) { return Invoke<bool>(nameof(IsDeviceTracking), XRDeviceId); }
        public bool HasValidTrackingPosition() { return Invoke<bool>(nameof(HasValidTrackingPosition)); }
        public int GetXRSystemFlags() { return Invoke<int>(nameof(GetXRSystemFlags)); }
        public float GetWorldToMetersScale(Object WorldContext) { return Invoke<float>(nameof(GetWorldToMetersScale), WorldContext); }
        public void GetVRFocusState(bool bUseFocus, bool bHasFocus) { Invoke(nameof(GetVRFocusState), bUseFocus, bHasFocus); }
        public Object GetVersionString() { return Invoke<Object>(nameof(GetVersionString)); }
        public Transform GetTrackingToWorldTransform(Object WorldContext) { return Invoke<Transform>(nameof(GetTrackingToWorldTransform), WorldContext); }
        public void GetTrackingSensorParameters(Vector Origin, Rotator Rotation, float LeftFOV, float RightFOV, float TopFOV, float BottomFOV, float Distance, float NearPlane, float FarPlane, bool IsActive, int Index) { Invoke(nameof(GetTrackingSensorParameters), Origin, Rotation, LeftFOV, RightFOV, TopFOV, BottomFOV, Distance, NearPlane, FarPlane, IsActive, Index); }
        public bool GetTrackingOriginTransform(byte Origin, Transform OutTransform) { return Invoke<bool>(nameof(GetTrackingOriginTransform), Origin, OutTransform); }
        public byte GetTrackingOrigin() { return Invoke<byte>(nameof(GetTrackingOrigin)); }
        public void GetPositionalTrackingCameraParameters(Vector CameraOrigin, Rotator CameraRotation, float HFOV, float VFOV, float CameraDistance, float NearPlane, float FarPlane) { Invoke(nameof(GetPositionalTrackingCameraParameters), CameraOrigin, CameraRotation, HFOV, VFOV, CameraDistance, NearPlane, FarPlane); }
        public bool GetPlayAreaRect(Transform OutTransform, Vector2D OutRect) { return Invoke<bool>(nameof(GetPlayAreaRect), OutTransform, OutRect); }
        public Vector2D GetPlayAreaBounds(byte Origin) { return Invoke<Vector2D>(nameof(GetPlayAreaBounds), Origin); }
        public float GetPixelDensity() { return Invoke<float>(nameof(GetPixelDensity)); }
        public void GetOrientationAndPosition(Rotator DeviceRotation, Vector DevicePosition) { Invoke(nameof(GetOrientationAndPosition), DeviceRotation, DevicePosition); }
        public int GetNumOfTrackingSensors() { return Invoke<int>(nameof(GetNumOfTrackingSensors)); }
        public void GetMotionControllerData(Object WorldContext, EControllerHand Hand, XRMotionControllerData MotionControllerData) { Invoke(nameof(GetMotionControllerData), WorldContext, Hand, MotionControllerData); }
        public byte GetHMDWornState() { return Invoke<byte>(nameof(GetHMDWornState)); }
        public Object GetHMDDeviceName() { return Invoke<Object>(nameof(GetHMDDeviceName)); }
        public void GetHMDData(Object WorldContext, XRHMDData HMDData) { Invoke(nameof(GetHMDData), WorldContext, HMDData); }
        public void GetDeviceWorldPose(Object WorldContext, XRDeviceId XRDeviceId, bool bIsTracked, Rotator Orientation, bool bHasPositionalTracking, Vector Position) { Invoke(nameof(GetDeviceWorldPose), WorldContext, XRDeviceId, bIsTracked, Orientation, bHasPositionalTracking, Position); }
        public void GetDevicePose(XRDeviceId XRDeviceId, bool bIsTracked, Rotator Orientation, bool bHasPositionalTracking, Vector Position) { Invoke(nameof(GetDevicePose), XRDeviceId, bIsTracked, Orientation, bHasPositionalTracking, Position); }
        public bool GetCurrentInteractionProfile(EControllerHand Hand, Object InteractionProfile) { return Invoke<bool>(nameof(GetCurrentInteractionProfile), Hand, InteractionProfile); }
        public bool GetControllerTransformForTime(Object WorldContext, int ControllerIndex, Object MotionSource, Timespan Time, bool bTimeWasUsed, Rotator Orientation, Vector Position, bool bProvidedLinearVelocity, Vector LinearVelocity, bool bProvidedAngularVelocity, Vector AngularVelocityRadPerSec, bool bProvidedLinearAcceleration, Vector LinearAcceleration) { return Invoke<bool>(nameof(GetControllerTransformForTime), WorldContext, ControllerIndex, MotionSource, Time, bTimeWasUsed, Orientation, Position, bProvidedLinearVelocity, LinearVelocity, bProvidedAngularVelocity, AngularVelocityRadPerSec, bProvidedLinearAcceleration, LinearAcceleration); }
        public Array<XRDeviceId> EnumerateTrackedDevices(Object SystemId, EXRTrackedDeviceType DeviceType) { return Invoke<Array<XRDeviceId>>(nameof(EnumerateTrackedDevices), SystemId, DeviceType); }
        public void EnableLowPersistenceMode(bool bEnable) { Invoke(nameof(EnableLowPersistenceMode), bEnable); }
        public bool EnableHMD(bool bEnable) { return Invoke<bool>(nameof(EnableHMD), bEnable); }
        public void DisconnectRemoteXRDevice() { Invoke(nameof(DisconnectRemoteXRDevice)); }
        public byte ConnectRemoteXRDevice(Object ipAddress, int BitRate) { return Invoke<byte>(nameof(ConnectRemoteXRDevice), ipAddress, BitRate); }
        public bool ConfigureGestures(XRGestureConfig GestureConfig) { return Invoke<bool>(nameof(ConfigureGestures), GestureConfig); }
        public void ClearXRTimedInputActionDelegate(Object ActionPath) { Invoke(nameof(ClearXRTimedInputActionDelegate), ActionPath); }
        public void CalibrateExternalTrackingToHMD(Transform ExternalTrackingTransform) { Invoke(nameof(CalibrateExternalTrackingToHMD), ExternalTrackingTransform); }
        public void BreakKey(Key InKey, Object InteractionProfile, EControllerHand Hand, Object MotionSource, Object Indentifier, Object Component) { Invoke(nameof(BreakKey), InKey, InteractionProfile, Hand, MotionSource, Indentifier, Component); }
    }
    public class MotionControllerComponent : PrimitiveComponent
    {
        public MotionControllerComponent(nint addr) : base(addr) { }
        public int PlayerIndex { get { return this[nameof(PlayerIndex)].GetValue<int>(); } set { this[nameof(PlayerIndex)].SetValue<int>(value); } }
        public EControllerHand Hand { get { return (EControllerHand)this[nameof(Hand)].GetValue<int>(); } set { this[nameof(Hand)].SetValue<int>((int)value); } }
        public Object MotionSource { get { return this[nameof(MotionSource)]; } set { this[nameof(MotionSource)] = value; } }
        public bool bDisableLowLatencyUpdate { get { return this[nameof(bDisableLowLatencyUpdate)].Flag; } set { this[nameof(bDisableLowLatencyUpdate)].Flag = value; } }
        public ETrackingStatus CurrentTrackingStatus { get { return (ETrackingStatus)this[nameof(CurrentTrackingStatus)].GetValue<int>(); } set { this[nameof(CurrentTrackingStatus)].SetValue<int>((int)value); } }
        public bool bDisplayDeviceModel { get { return this[nameof(bDisplayDeviceModel)].Flag; } set { this[nameof(bDisplayDeviceModel)].Flag = value; } }
        public Object DisplayModelSource { get { return this[nameof(DisplayModelSource)]; } set { this[nameof(DisplayModelSource)] = value; } }
        public StaticMesh CustomDisplayMesh { get { return this[nameof(CustomDisplayMesh)].As<StaticMesh>(); } set { this["CustomDisplayMesh"] = value; } }
        public Array<MaterialInterface> DisplayMeshMaterialOverrides { get { return new Array<MaterialInterface>(this[nameof(DisplayMeshMaterialOverrides)].Address); } }
        public PrimitiveComponent DisplayComponent { get { return this[nameof(DisplayComponent)].As<PrimitiveComponent>(); } set { this["DisplayComponent"] = value; } }
        public void SetTrackingSource(EControllerHand NewSource) { Invoke(nameof(SetTrackingSource), NewSource); }
        public void SetTrackingMotionSource(Object NewSource) { Invoke(nameof(SetTrackingMotionSource), NewSource); }
        public void SetShowDeviceModel(bool bShowControllerModel) { Invoke(nameof(SetShowDeviceModel), bShowControllerModel); }
        public void SetDisplayModelSource(Object NewDisplayModelSource) { Invoke(nameof(SetDisplayModelSource), NewDisplayModelSource); }
        public void SetCustomDisplayMesh(StaticMesh NewDisplayMesh) { Invoke(nameof(SetCustomDisplayMesh), NewDisplayMesh); }
        public void SetAssociatedPlayerIndex(int NewPlayer) { Invoke(nameof(SetAssociatedPlayerIndex), NewPlayer); }
        public void OnMotionControllerUpdated() { Invoke(nameof(OnMotionControllerUpdated)); }
        public bool IsTracked() { return Invoke<bool>(nameof(IsTracked)); }
        public EControllerHand GetTrackingSource() { return Invoke<EControllerHand>(nameof(GetTrackingSource)); }
        public float GetParameterValue(Object InName, bool bValueFound) { return Invoke<float>(nameof(GetParameterValue), InName, bValueFound); }
        public Vector GetHandJointPosition(int jointIndex, bool bValueFound) { return Invoke<Vector>(nameof(GetHandJointPosition), jointIndex, bValueFound); }
    }
    public class MotionTrackedDeviceFunctionLibrary : BlueprintFunctionLibrary
    {
        public MotionTrackedDeviceFunctionLibrary(nint addr) : base(addr) { }
        public void SetIsControllerMotionTrackingEnabledByDefault(bool Enable) { Invoke(nameof(SetIsControllerMotionTrackingEnabledByDefault), Enable); }
        public bool IsMotionTrackingEnabledForSource(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForSource), PlayerIndex, SourceName); }
        public bool IsMotionTrackingEnabledForDevice(int PlayerIndex, EControllerHand Hand) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForDevice), PlayerIndex, Hand); }
        public bool IsMotionTrackingEnabledForComponent(MotionControllerComponent MotionControllerComponent) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForComponent), MotionControllerComponent); }
        public bool IsMotionTrackedDeviceCountManagementNecessary() { return Invoke<bool>(nameof(IsMotionTrackedDeviceCountManagementNecessary)); }
        public bool IsMotionSourceTracking(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(IsMotionSourceTracking), PlayerIndex, SourceName); }
        public int GetMotionTrackingEnabledControllerCount() { return Invoke<int>(nameof(GetMotionTrackingEnabledControllerCount)); }
        public int GetMaximumMotionTrackedControllerCount() { return Invoke<int>(nameof(GetMaximumMotionTrackedControllerCount)); }
        public Object GetActiveTrackingSystemName() { return Invoke<Object>(nameof(GetActiveTrackingSystemName)); }
        public Array<Object> EnumerateMotionSources() { return Invoke<Array<Object>>(nameof(EnumerateMotionSources)); }
        public bool EnableMotionTrackingOfSource(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(EnableMotionTrackingOfSource), PlayerIndex, SourceName); }
        public bool EnableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand) { return Invoke<bool>(nameof(EnableMotionTrackingOfDevice), PlayerIndex, Hand); }
        public bool EnableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent) { return Invoke<bool>(nameof(EnableMotionTrackingForComponent), MotionControllerComponent); }
        public void DisableMotionTrackingOfSource(int PlayerIndex, Object SourceName) { Invoke(nameof(DisableMotionTrackingOfSource), PlayerIndex, SourceName); }
        public void DisableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand) { Invoke(nameof(DisableMotionTrackingOfDevice), PlayerIndex, Hand); }
        public void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) { Invoke(nameof(DisableMotionTrackingOfControllersForPlayer), PlayerIndex); }
        public void DisableMotionTrackingOfAllControllers() { Invoke(nameof(DisableMotionTrackingOfAllControllers)); }
        public void DisableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent) { Invoke(nameof(DisableMotionTrackingForComponent), MotionControllerComponent); }
    }
    public class VRNotificationsComponent : ActorComponent
    {
        public VRNotificationsComponent(nint addr) : base(addr) { }
        public Object HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate { get { return this[nameof(HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate)]; } set { this[nameof(HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate)] = value; } }
        public Object HMDTrackingInitializedDelegate { get { return this[nameof(HMDTrackingInitializedDelegate)]; } set { this[nameof(HMDTrackingInitializedDelegate)] = value; } }
        public Object HMDRecenteredDelegate { get { return this[nameof(HMDRecenteredDelegate)]; } set { this[nameof(HMDRecenteredDelegate)] = value; } }
        public Object HMDLostDelegate { get { return this[nameof(HMDLostDelegate)]; } set { this[nameof(HMDLostDelegate)] = value; } }
        public Object HMDReconnectedDelegate { get { return this[nameof(HMDReconnectedDelegate)]; } set { this[nameof(HMDReconnectedDelegate)] = value; } }
        public Object HMDConnectCanceledDelegate { get { return this[nameof(HMDConnectCanceledDelegate)]; } set { this[nameof(HMDConnectCanceledDelegate)] = value; } }
        public Object HMDPutOnHeadDelegate { get { return this[nameof(HMDPutOnHeadDelegate)]; } set { this[nameof(HMDPutOnHeadDelegate)] = value; } }
        public Object HMDRemovedFromHeadDelegate { get { return this[nameof(HMDRemovedFromHeadDelegate)]; } set { this[nameof(HMDRemovedFromHeadDelegate)] = value; } }
        public Object VRControllerRecenteredDelegate { get { return this[nameof(VRControllerRecenteredDelegate)]; } set { this[nameof(VRControllerRecenteredDelegate)] = value; } }
        public Object XRTrackingOriginChangedDelegate { get { return this[nameof(XRTrackingOriginChangedDelegate)]; } set { this[nameof(XRTrackingOriginChangedDelegate)] = value; } }
        public Object XRPlayAreaChangedDelegate { get { return this[nameof(XRPlayAreaChangedDelegate)]; } set { this[nameof(XRPlayAreaChangedDelegate)] = value; } }
    }
    public class XRAssetFunctionLibrary : BlueprintFunctionLibrary
    {
        public XRAssetFunctionLibrary(nint addr) : base(addr) { }
        public PrimitiveComponent AddNamedDeviceVisualizationComponentBlocking(Actor Target, Object SystemName, Object DeviceName, bool bManualAttachment, Transform RelativeTransform, XRDeviceId XRDeviceId) { return Invoke<PrimitiveComponent>(nameof(AddNamedDeviceVisualizationComponentBlocking), Target, SystemName, DeviceName, bManualAttachment, RelativeTransform, XRDeviceId); }
        public PrimitiveComponent AddDeviceVisualizationComponentBlocking(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform) { return Invoke<PrimitiveComponent>(nameof(AddDeviceVisualizationComponentBlocking), Target, XRDeviceId, bManualAttachment, RelativeTransform); }
    }
    public class AsyncTask_LoadXRDeviceVisComponent : BlueprintAsyncActionBase
    {
        public AsyncTask_LoadXRDeviceVisComponent(nint addr) : base(addr) { }
        public Object OnModelLoaded { get { return this[nameof(OnModelLoaded)]; } set { this[nameof(OnModelLoaded)] = value; } }
        public Object OnLoadFailure { get { return this[nameof(OnLoadFailure)]; } set { this[nameof(OnLoadFailure)] = value; } }
        public PrimitiveComponent SpawnedComponent { get { return this[nameof(SpawnedComponent)].As<PrimitiveComponent>(); } set { this["SpawnedComponent"] = value; } }
        public AsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(Actor Target, Object SystemName, Object DeviceName, bool bManualAttachment, Transform RelativeTransform, XRDeviceId XRDeviceId, PrimitiveComponent NewComponent) { return Invoke<AsyncTask_LoadXRDeviceVisComponent>(nameof(AddNamedDeviceVisualizationComponentAsync), Target, SystemName, DeviceName, bManualAttachment, RelativeTransform, XRDeviceId, NewComponent); }
        public AsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform, PrimitiveComponent NewComponent) { return Invoke<AsyncTask_LoadXRDeviceVisComponent>(nameof(AddDeviceVisualizationComponentAsync), Target, XRDeviceId, bManualAttachment, RelativeTransform, NewComponent); }
    }
    public class XRLoadingScreenFunctionLibrary : BlueprintFunctionLibrary
    {
        public XRLoadingScreenFunctionLibrary(nint addr) : base(addr) { }
        public void ShowLoadingScreen() { Invoke(nameof(ShowLoadingScreen)); }
        public void SetLoadingScreen(Texture Texture, Vector2D Scale, Vector Offset, bool bShowLoadingMovie, bool bShowOnSet) { Invoke(nameof(SetLoadingScreen), Texture, Scale, Offset, bShowLoadingMovie, bShowOnSet); }
        public void HideLoadingScreen() { Invoke(nameof(HideLoadingScreen)); }
        public void ClearLoadingScreenSplashes() { Invoke(nameof(ClearLoadingScreenSplashes)); }
        public void AddLoadingScreenSplash(Texture Texture, Vector Translation, Rotator Rotation, Vector2D Size, Rotator DeltaRotation, bool bClearBeforeAdd) { Invoke(nameof(AddLoadingScreenSplash), Texture, Translation, Rotation, Size, DeltaRotation, bClearBeforeAdd); }
    }
    public enum EOrientPositionSelector : int
    {
        Orientation = 0,
        Position = 1,
        OrientationAndPosition = 2,
        EOrientPositionSelector_MAX = 3,
    }
    public enum EHMDTrackingOrigin : int
    {
        Floor = 0,
        Eye = 1,
        Stage = 2,
        EHMDTrackingOrigin_MAX = 3,
    }
    public enum EHMDWornState : int
    {
        Unknown = 0,
        Worn = 1,
        NotWorn = 2,
        EHMDWornState_MAX = 3,
    }
    public enum EXRDeviceConnectionResult : int
    {
        NoTrackingSystem = 0,
        FeatureNotSupported = 1,
        NoValidViewport = 2,
        MiscFailure = 3,
        Success = 4,
        EXRDeviceConnectionResult_MAX = 5,
    }
    public enum EXRSystemFlags : int
    {
        NoFlags = 0,
        IsAR = 1,
        IsTablet = 2,
        IsHeadMounted = 4,
        SupportsHandTracking = 8,
        EXRSystemFlags_MAX = 9,
    }
    public enum ESpectatorScreenMode : int
    {
        Disabled = 0,
        SingleEyeLetterboxed = 1,
        Undistorted = 2,
        Distorted = 3,
        SingleEye = 4,
        SingleEyeCroppedToFill = 5,
        Texture = 6,
        TexturePlusEye = 7,
        ESpectatorScreenMode_MAX = 8,
    }
    public enum EXRTrackedDeviceType : int
    {
        HeadMountedDisplay = 0,
        Controller = 1,
        TrackingReference = 2,
        Other = 3,
        Invalid = 254,
        Any = 255,
        EXRTrackedDeviceType_MAX = 256,
    }
    public enum EHandKeypoint : int
    {
        Palm = 0,
        Wrist = 1,
        ThumbMetacarpal = 2,
        ThumbProximal = 3,
        ThumbDistal = 4,
        ThumbTip = 5,
        IndexMetacarpal = 6,
        IndexProximal = 7,
        IndexIntermediate = 8,
        IndexDistal = 9,
        IndexTip = 10,
        MiddleMetacarpal = 11,
        MiddleProximal = 12,
        MiddleIntermediate = 13,
        MiddleDistal = 14,
        MiddleTip = 15,
        RingMetacarpal = 16,
        RingProximal = 17,
        RingIntermediate = 18,
        RingDistal = 19,
        RingTip = 20,
        LittleMetacarpal = 21,
        LittleProximal = 22,
        LittleIntermediate = 23,
        LittleDistal = 24,
        LittleTip = 25,
        EHandKeypoint_MAX = 26,
    }
    public enum EXRVisualType : int
    {
        Controller = 0,
        Hand = 1,
        EXRVisualType_MAX = 2,
    }
    public enum ETrackingStatus : int
    {
        NotTracked = 0,
        InertialOnly = 1,
        Tracked = 2,
        ETrackingStatus_MAX = 3,
    }
    public enum ESpatialInputGestureAxis : int
    {
        None = 0,
        Manipulation = 1,
        Navigation = 2,
        NavigationRails = 3,
        ESpatialInputGestureAxis_MAX = 4,
    }
    public class XRHMDData : Object
    {
        public XRHMDData(nint addr) : base(addr) { }
        public bool bValid { get { return this[nameof(bValid)].Flag; } set { this[nameof(bValid)].Flag = value; } }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public Guid ApplicationInstanceID { get { return this[nameof(ApplicationInstanceID)].As<Guid>(); } set { this["ApplicationInstanceID"] = value; } }
        public ETrackingStatus TrackingStatus { get { return (ETrackingStatus)this[nameof(TrackingStatus)].GetValue<int>(); } set { this[nameof(TrackingStatus)].SetValue<int>((int)value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class XRMotionControllerData : Object
    {
        public XRMotionControllerData(nint addr) : base(addr) { }
        public bool bValid { get { return this[nameof(bValid)].Flag; } set { this[nameof(bValid)].Flag = value; } }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public Guid ApplicationInstanceID { get { return this[nameof(ApplicationInstanceID)].As<Guid>(); } set { this["ApplicationInstanceID"] = value; } }
        public EXRVisualType DeviceVisualType { get { return (EXRVisualType)this[nameof(DeviceVisualType)].GetValue<int>(); } set { this[nameof(DeviceVisualType)].SetValue<int>((int)value); } }
        public EControllerHand HandIndex { get { return (EControllerHand)this[nameof(HandIndex)].GetValue<int>(); } set { this[nameof(HandIndex)].SetValue<int>((int)value); } }
        public ETrackingStatus TrackingStatus { get { return (ETrackingStatus)this[nameof(TrackingStatus)].GetValue<int>(); } set { this[nameof(TrackingStatus)].SetValue<int>((int)value); } }
        public Vector GripPosition { get { return this[nameof(GripPosition)].As<Vector>(); } set { this["GripPosition"] = value; } }
        public Quat GripRotation { get { return this[nameof(GripRotation)].As<Quat>(); } set { this["GripRotation"] = value; } }
        public Vector AimPosition { get { return this[nameof(AimPosition)].As<Vector>(); } set { this["AimPosition"] = value; } }
        public Quat AimRotation { get { return this[nameof(AimRotation)].As<Quat>(); } set { this["AimRotation"] = value; } }
        public Array<Vector> HandKeyPositions { get { return new Array<Vector>(this[nameof(HandKeyPositions)].Address); } }
        public Array<Quat> HandKeyRotations { get { return new Array<Quat>(this[nameof(HandKeyRotations)].Address); } }
        public Array<float> HandKeyRadii { get { return new Array<float>(this[nameof(HandKeyRadii)].Address); } }
        public bool bIsGrasped { get { return this[nameof(bIsGrasped)].Flag; } set { this[nameof(bIsGrasped)].Flag = value; } }
    }
    public class XRGestureConfig : Object
    {
        public XRGestureConfig(nint addr) : base(addr) { }
        public bool bTap { get { return this[nameof(bTap)].Flag; } set { this[nameof(bTap)].Flag = value; } }
        public bool bHold { get { return this[nameof(bHold)].Flag; } set { this[nameof(bHold)].Flag = value; } }
        public ESpatialInputGestureAxis AxisGesture { get { return (ESpatialInputGestureAxis)this[nameof(AxisGesture)].GetValue<int>(); } set { this[nameof(AxisGesture)].SetValue<int>((int)value); } }
        public bool bNavigationAxisX { get { return this[nameof(bNavigationAxisX)].Flag; } set { this[nameof(bNavigationAxisX)].Flag = value; } }
        public bool bNavigationAxisY { get { return this[nameof(bNavigationAxisY)].Flag; } set { this[nameof(bNavigationAxisY)].Flag = value; } }
        public bool bNavigationAxisZ { get { return this[nameof(bNavigationAxisZ)].Flag; } set { this[nameof(bNavigationAxisZ)].Flag = value; } }
    }
    public class XRDeviceId : Object
    {
        public XRDeviceId(nint addr) : base(addr) { }
        public Object SystemName { get { return this[nameof(SystemName)]; } set { this[nameof(SystemName)] = value; } }
        public int DeviceID { get { return this[nameof(DeviceID)].GetValue<int>(); } set { this[nameof(DeviceID)].SetValue<int>(value); } }
    }
}
