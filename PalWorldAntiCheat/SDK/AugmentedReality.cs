using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MRMeshSDK;
namespace SDK.Script.AugmentedRealitySDK
{
    public class ARActor : Actor
    {
        public ARActor(nint addr) : base(addr) { }
        public ARComponent AddARComponent(Object InComponentClass, Guid NativeID) { return Invoke<ARComponent>(nameof(AddARComponent), InComponentClass, NativeID); }
    }
    public class ARBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ARBlueprintLibrary(nint addr) : base(addr) { }
        public void UnpinComponent(SceneComponent ComponentToUnpin) { Invoke(nameof(UnpinComponent), ComponentToUnpin); }
        public bool ToggleARCapture(bool bOnOff, EARCaptureType CaptureType) { return Invoke<bool>(nameof(ToggleARCapture), bOnOff, CaptureType); }
        public void StopARSession() { Invoke(nameof(StopARSession)); }
        public void StartARSession(ARSessionConfig SessionConfig) { Invoke(nameof(StartARSession), SessionConfig); }
        public void SetEnabledXRCamera(bool bOnOff) { Invoke(nameof(SetEnabledXRCamera), bOnOff); }
        public void SetARWorldScale(float InWorldScale) { Invoke(nameof(SetARWorldScale), InWorldScale); }
        public void SetARWorldOriginLocationAndRotation(Vector OriginLocation, Rotator OriginRotation, bool bIsTransformInWorldSpace, bool bMaintainUpDirection) { Invoke(nameof(SetARWorldOriginLocationAndRotation), OriginLocation, OriginRotation, bIsTransformInWorldSpace, bMaintainUpDirection); }
        public void SetAlignmentTransform(Transform InAlignmentTransform) { Invoke(nameof(SetAlignmentTransform), InAlignmentTransform); }
        public bool SaveARPinToLocalStore(Object InSaveName, ARPin InPin) { return Invoke<bool>(nameof(SaveARPinToLocalStore), InSaveName, InPin); }
        public IntPoint ResizeXRCamera(IntPoint InSize) { return Invoke<IntPoint>(nameof(ResizeXRCamera), InSize); }
        public void RemovePin(ARPin PinToRemove) { Invoke(nameof(RemovePin), PinToRemove); }
        public void RemoveARPinFromLocalStore(Object InSaveName) { Invoke(nameof(RemoveARPinFromLocalStore), InSaveName); }
        public void RemoveAllARPinsFromLocalStore() { Invoke(nameof(RemoveAllARPinsFromLocalStore)); }
        public ARPin PinComponentToTraceResult(SceneComponent ComponentToPin, ARTraceResult TraceResult, Object DebugName) { return Invoke<ARPin>(nameof(PinComponentToTraceResult), ComponentToPin, TraceResult, DebugName); }
        public bool PinComponentToARPin(SceneComponent ComponentToPin, ARPin Pin) { return Invoke<bool>(nameof(PinComponentToARPin), ComponentToPin, Pin); }
        public ARPin PinComponent(SceneComponent ComponentToPin, Transform PinToWorldTransform, ARTrackedGeometry TrackedGeometry, Object DebugName) { return Invoke<ARPin>(nameof(PinComponent), ComponentToPin, PinToWorldTransform, TrackedGeometry, DebugName); }
        public void PauseARSession() { Invoke(nameof(PauseARSession)); }
        public Object LoadARPinsFromLocalStore() { return Invoke<Object>(nameof(LoadARPinsFromLocalStore)); }
        public Array<ARTraceResult> LineTraceTrackedObjects3D(Vector Start, Vector End, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon) { return Invoke<Array<ARTraceResult>>(nameof(LineTraceTrackedObjects3D), Start, End, bTestFeaturePoints, bTestGroundPlane, bTestPlaneExtents, bTestPlaneBoundaryPolygon); }
        public Array<ARTraceResult> LineTraceTrackedObjects(Vector2D ScreenCoord, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon) { return Invoke<Array<ARTraceResult>>(nameof(LineTraceTrackedObjects), ScreenCoord, bTestFeaturePoints, bTestGroundPlane, bTestPlaneExtents, bTestPlaneBoundaryPolygon); }
        public bool IsSessionTypeSupported(EARSessionType SessionType) { return Invoke<bool>(nameof(IsSessionTypeSupported), SessionType); }
        public bool IsSessionTrackingFeatureSupported(EARSessionType SessionType, EARSessionTrackingFeature SessionTrackingFeature) { return Invoke<bool>(nameof(IsSessionTrackingFeatureSupported), SessionType, SessionTrackingFeature); }
        public bool IsSceneReconstructionSupported(EARSessionType SessionType, EARSceneReconstruction SceneReconstructionMethod) { return Invoke<bool>(nameof(IsSceneReconstructionSupported), SessionType, SceneReconstructionMethod); }
        public bool IsARSupported() { return Invoke<bool>(nameof(IsARSupported)); }
        public bool IsARPinLocalStoreSupported() { return Invoke<bool>(nameof(IsARPinLocalStoreSupported)); }
        public bool IsARPinLocalStoreReady() { return Invoke<bool>(nameof(IsARPinLocalStoreReady)); }
        public EARWorldMappingState GetWorldMappingStatus() { return Invoke<EARWorldMappingState>(nameof(GetWorldMappingStatus)); }
        public EARTrackingQualityReason GetTrackingQualityReason() { return Invoke<EARTrackingQualityReason>(nameof(GetTrackingQualityReason)); }
        public EARTrackingQuality GetTrackingQuality() { return Invoke<EARTrackingQuality>(nameof(GetTrackingQuality)); }
        public Array<ARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType) { return Invoke<Array<ARVideoFormat>>(nameof(GetSupportedVideoFormats), SessionType); }
        public ARSessionConfig GetSessionConfig() { return Invoke<ARSessionConfig>(nameof(GetSessionConfig)); }
        public Array<Vector> GetPointCloud() { return Invoke<Array<Vector>>(nameof(GetPointCloud)); }
        public ARTexture GetPersonSegmentationImage() { return Invoke<ARTexture>(nameof(GetPersonSegmentationImage)); }
        public ARTexture GetPersonSegmentationDepthImage() { return Invoke<ARTexture>(nameof(GetPersonSegmentationDepthImage)); }
        public bool GetObjectClassificationAtLocation(Vector InWorldLocation, EARObjectClassification OutClassification, Vector OutClassificationLocation, float MaxLocationDiff) { return Invoke<bool>(nameof(GetObjectClassificationAtLocation), InWorldLocation, OutClassification, OutClassificationLocation, MaxLocationDiff); }
        public int GetNumberOfTrackedFacesSupported() { return Invoke<int>(nameof(GetNumberOfTrackedFacesSupported)); }
        public ARLightEstimate GetCurrentLightEstimate() { return Invoke<ARLightEstimate>(nameof(GetCurrentLightEstimate)); }
        public bool GetCameraIntrinsics(ARCameraIntrinsics OutCameraIntrinsics) { return Invoke<bool>(nameof(GetCameraIntrinsics), OutCameraIntrinsics); }
        public ARTextureCameraImage GetCameraImage() { return Invoke<ARTextureCameraImage>(nameof(GetCameraImage)); }
        public ARTextureCameraDepth GetCameraDepth() { return Invoke<ARTextureCameraDepth>(nameof(GetCameraDepth)); }
        public float GetARWorldScale() { return Invoke<float>(nameof(GetARWorldScale)); }
        public ARTexture GetARTexture(EARTextureType TextureType) { return Invoke<ARTexture>(nameof(GetARTexture), TextureType); }
        public ARSessionStatus GetARSessionStatus() { return Invoke<ARSessionStatus>(nameof(GetARSessionStatus)); }
        public Array<ARTrackedPose> GetAllTrackedPoses() { return Invoke<Array<ARTrackedPose>>(nameof(GetAllTrackedPoses)); }
        public Array<ARTrackedPoint> GetAllTrackedPoints() { return Invoke<Array<ARTrackedPoint>>(nameof(GetAllTrackedPoints)); }
        public Array<ARPlaneGeometry> GetAllTrackedPlanes() { return Invoke<Array<ARPlaneGeometry>>(nameof(GetAllTrackedPlanes)); }
        public Array<ARTrackedImage> GetAllTrackedImages() { return Invoke<Array<ARTrackedImage>>(nameof(GetAllTrackedImages)); }
        public Array<AREnvironmentCaptureProbe> GetAllTrackedEnvironmentCaptureProbes() { return Invoke<Array<AREnvironmentCaptureProbe>>(nameof(GetAllTrackedEnvironmentCaptureProbes)); }
        public Array<ARPose2D> GetAllTracked2DPoses() { return Invoke<Array<ARPose2D>>(nameof(GetAllTracked2DPoses)); }
        public Array<ARPin> GetAllPins() { return Invoke<Array<ARPin>>(nameof(GetAllPins)); }
        public Array<ARTrackedGeometry> GetAllGeometriesByClass(Object GeometryClass) { return Invoke<Array<ARTrackedGeometry>>(nameof(GetAllGeometriesByClass), GeometryClass); }
        public Array<ARTrackedGeometry> GetAllGeometries() { return Invoke<Array<ARTrackedGeometry>>(nameof(GetAllGeometries)); }
        public Transform GetAlignmentTransform() { return Invoke<Transform>(nameof(GetAlignmentTransform)); }
        public Array<ARTrackedPoint> FindTrackedPointsByName(Object PointName) { return Invoke<Array<ARTrackedPoint>>(nameof(FindTrackedPointsByName), PointName); }
        public void DebugDrawTrackedGeometry(ARTrackedGeometry TrackedGeometry, Object WorldContextObject, LinearColor Color, float OutlineThickness, float PersistForSeconds) { Invoke(nameof(DebugDrawTrackedGeometry), TrackedGeometry, WorldContextObject, Color, OutlineThickness, PersistForSeconds); }
        public void DebugDrawPin(ARPin ARPin, Object WorldContextObject, LinearColor Color, float Scale, float PersistForSeconds) { Invoke(nameof(DebugDrawPin), ARPin, WorldContextObject, Color, Scale, PersistForSeconds); }
        public void CalculateClosestIntersection(Array<Vector> StartPoints, Array<Vector> EndPoints, Vector ClosestIntersection) { Invoke(nameof(CalculateClosestIntersection), StartPoints, EndPoints, ClosestIntersection); }
        public void CalculateAlignmentTransform(Transform TransformInFirstCoordinateSystem, Transform TransformInSecondCoordinateSystem, Transform AlignmentTransform) { Invoke(nameof(CalculateAlignmentTransform), TransformInFirstCoordinateSystem, TransformInSecondCoordinateSystem, AlignmentTransform); }
        public bool AddTrackedPointWithName(Transform WorldTransform, Object PointName, bool bDeletePointsWithSameName) { return Invoke<bool>(nameof(AddTrackedPointWithName), WorldTransform, PointName, bDeletePointsWithSameName); }
        public ARCandidateImage AddRuntimeCandidateImage(ARSessionConfig SessionConfig, Texture2D CandidateTexture, Object FriendlyName, float PhysicalWidth) { return Invoke<ARCandidateImage>(nameof(AddRuntimeCandidateImage), SessionConfig, CandidateTexture, FriendlyName, PhysicalWidth); }
        public bool AddManualEnvironmentCaptureProbe(Vector Location, Vector Extent) { return Invoke<bool>(nameof(AddManualEnvironmentCaptureProbe), Location, Extent); }
    }
    public class ARTraceResultLibrary : BlueprintFunctionLibrary
    {
        public ARTraceResultLibrary(nint addr) : base(addr) { }
        public ARTrackedGeometry GetTrackedGeometry(ARTraceResult TraceResult) { return Invoke<ARTrackedGeometry>(nameof(GetTrackedGeometry), TraceResult); }
        public EARLineTraceChannels GetTraceChannel(ARTraceResult TraceResult) { return Invoke<EARLineTraceChannels>(nameof(GetTraceChannel), TraceResult); }
        public Transform GetLocalTransform(ARTraceResult TraceResult) { return Invoke<Transform>(nameof(GetLocalTransform), TraceResult); }
        public Transform GetLocalToWorldTransform(ARTraceResult TraceResult) { return Invoke<Transform>(nameof(GetLocalToWorldTransform), TraceResult); }
        public Transform GetLocalToTrackingTransform(ARTraceResult TraceResult) { return Invoke<Transform>(nameof(GetLocalToTrackingTransform), TraceResult); }
        public float GetDistanceFromCamera(ARTraceResult TraceResult) { return Invoke<float>(nameof(GetDistanceFromCamera), TraceResult); }
    }
    public class ARBaseAsyncTaskBlueprintProxy : BlueprintAsyncActionBase
    {
        public ARBaseAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
    }
    public class ARSaveWorldAsyncTaskBlueprintProxy : ARBaseAsyncTaskBlueprintProxy
    {
        public ARSaveWorldAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailed { get { return this[nameof(OnFailed)]; } set { this[nameof(OnFailed)] = value; } }
        public ARSaveWorldAsyncTaskBlueprintProxy ARSaveWorld(Object WorldContextObject) { return Invoke<ARSaveWorldAsyncTaskBlueprintProxy>(nameof(ARSaveWorld), WorldContextObject); }
    }
    public class ARGetCandidateObjectAsyncTaskBlueprintProxy : ARBaseAsyncTaskBlueprintProxy
    {
        public ARGetCandidateObjectAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailed { get { return this[nameof(OnFailed)]; } set { this[nameof(OnFailed)] = value; } }
        public ARGetCandidateObjectAsyncTaskBlueprintProxy ARGetCandidateObject(Object WorldContextObject, Vector Location, Vector Extent) { return Invoke<ARGetCandidateObjectAsyncTaskBlueprintProxy>(nameof(ARGetCandidateObject), WorldContextObject, Location, Extent); }
    }
    public class ARComponent : SceneComponent
    {
        public ARComponent(nint addr) : base(addr) { }
        public Guid NativeID { get { return this[nameof(NativeID)].As<Guid>(); } set { this["NativeID"] = value; } }
        public bool bUseDefaultReplication { get { return this[nameof(bUseDefaultReplication)].Flag; } set { this[nameof(bUseDefaultReplication)].Flag = value; } }
        public MaterialInterface DefaultMeshMaterial { get { return this[nameof(DefaultMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultMeshMaterial"] = value; } }
        public MaterialInterface DefaultWireframeMeshMaterial { get { return this[nameof(DefaultWireframeMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultWireframeMeshMaterial"] = value; } }
        public MRMeshComponent MRMeshComponent { get { return this[nameof(MRMeshComponent)].As<MRMeshComponent>(); } set { this["MRMeshComponent"] = value; } }
        public ARTrackedGeometry MyTrackedGeometry { get { return this[nameof(MyTrackedGeometry)].As<ARTrackedGeometry>(); } set { this["MyTrackedGeometry"] = value; } }
        public void UpdateVisualization() { Invoke(nameof(UpdateVisualization)); }
        public void SetNativeID(Guid NativeID) { Invoke(nameof(SetNativeID), NativeID); }
        public void ReceiveRemove() { Invoke(nameof(ReceiveRemove)); }
        public void OnRep_Payload() { Invoke(nameof(OnRep_Payload)); }
        public MRMeshComponent GetMRMesh() { return Invoke<MRMeshComponent>(nameof(GetMRMesh)); }
    }
    public class ARPlaneComponent : ARComponent
    {
        public ARPlaneComponent(nint addr) : base(addr) { }
        public ARPlaneUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARPlaneUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode) { Invoke(nameof(SetPlaneComponentDebugMode), NewDebugMode); }
        public void SetObjectClassificationDebugColors(Object InColors) { Invoke(nameof(SetObjectClassificationDebugColors), InColors); }
        public void ServerUpdatePayload(ARPlaneUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARPlaneUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARPlaneUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
        public Object GetObjectClassificationDebugColors() { return Invoke<Object>(nameof(GetObjectClassificationDebugColors)); }
    }
    public class ARPointComponent : ARComponent
    {
        public ARPointComponent(nint addr) : base(addr) { }
        public ARPointUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARPointUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void ServerUpdatePayload(ARPointUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARPointUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARPointUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARFaceComponent : ARComponent
    {
        public ARFaceComponent(nint addr) : base(addr) { }
        public EARFaceTransformMixing TransformSetting { get { return (EARFaceTransformMixing)this[nameof(TransformSetting)].GetValue<int>(); } set { this[nameof(TransformSetting)].SetValue<int>((int)value); } }
        public bool bUpdateVertexNormal { get { return this[nameof(bUpdateVertexNormal)].Flag; } set { this[nameof(bUpdateVertexNormal)].Flag = value; } }
        public bool bFaceOutOfScreen { get { return this[nameof(bFaceOutOfScreen)].Flag; } set { this[nameof(bFaceOutOfScreen)].Flag = value; } }
        public ARFaceUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARFaceUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetFaceComponentDebugMode(EFaceComponentDebugMode NewDebugMode) { Invoke(nameof(SetFaceComponentDebugMode), NewDebugMode); }
        public void ServerUpdatePayload(ARFaceUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARFaceUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARFaceUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARImageComponent : ARComponent
    {
        public ARImageComponent(nint addr) : base(addr) { }
        public ARImageUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARImageUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetImageComponentDebugMode(EImageComponentDebugMode NewDebugMode) { Invoke(nameof(SetImageComponentDebugMode), NewDebugMode); }
        public void ServerUpdatePayload(ARImageUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARImageUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARImageUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARQRCodeComponent : ARComponent
    {
        public ARQRCodeComponent(nint addr) : base(addr) { }
        public ARQRCodeUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARQRCodeUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetQRCodeComponentDebugMode(EQRCodeComponentDebugMode NewDebugMode) { Invoke(nameof(SetQRCodeComponentDebugMode), NewDebugMode); }
        public void ServerUpdatePayload(ARQRCodeUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARQRCodeUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARQRCodeUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARPoseComponent : ARComponent
    {
        public ARPoseComponent(nint addr) : base(addr) { }
        public ARPoseUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARPoseUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetPoseComponentDebugMode(EPoseComponentDebugMode NewDebugMode) { Invoke(nameof(SetPoseComponentDebugMode), NewDebugMode); }
        public void ServerUpdatePayload(ARPoseUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARPoseUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARPoseUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class AREnvironmentProbeComponent : ARComponent
    {
        public AREnvironmentProbeComponent(nint addr) : base(addr) { }
        public AREnvironmentProbeUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<AREnvironmentProbeUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void ServerUpdatePayload(AREnvironmentProbeUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(AREnvironmentProbeUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(AREnvironmentProbeUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARObjectComponent : ARComponent
    {
        public ARObjectComponent(nint addr) : base(addr) { }
        public ARObjectUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARObjectUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void ServerUpdatePayload(ARObjectUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARObjectUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARObjectUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARMeshComponent : ARComponent
    {
        public ARMeshComponent(nint addr) : base(addr) { }
        public ARMeshUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARMeshUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void ServerUpdatePayload(ARMeshUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARMeshUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARMeshUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARGeoAnchorComponent : ARComponent
    {
        public ARGeoAnchorComponent(nint addr) : base(addr) { }
        public ARGeoAnchorUpdatePayload ReplicatedPayload { get { return this[nameof(ReplicatedPayload)].As<ARGeoAnchorUpdatePayload>(); } set { this["ReplicatedPayload"] = value; } }
        public void SetGeoAnchorComponentDebugMode(EGeoAnchorComponentDebugMode NewDebugMode) { Invoke(nameof(SetGeoAnchorComponentDebugMode), NewDebugMode); }
        public void ServerUpdatePayload(ARGeoAnchorUpdatePayload NewPayload) { Invoke(nameof(ServerUpdatePayload), NewPayload); }
        public void ReceiveUpdate(ARGeoAnchorUpdatePayload Payload) { Invoke(nameof(ReceiveUpdate), Payload); }
        public void ReceiveAdd(ARGeoAnchorUpdatePayload Payload) { Invoke(nameof(ReceiveAdd), Payload); }
    }
    public class ARDependencyHandler : Object
    {
        public ARDependencyHandler(nint addr) : base(addr) { }
        public void StartARSessionLatent(Object WorldContextObject, ARSessionConfig SessionConfig, LatentActionInfo LatentInfo) { Invoke(nameof(StartARSessionLatent), WorldContextObject, SessionConfig, LatentInfo); }
        public void RequestARSessionPermission(Object WorldContextObject, ARSessionConfig SessionConfig, LatentActionInfo LatentInfo, EARServicePermissionRequestResult OutPermissionResult) { Invoke(nameof(RequestARSessionPermission), WorldContextObject, SessionConfig, LatentInfo, OutPermissionResult); }
        public void InstallARService(Object WorldContextObject, LatentActionInfo LatentInfo, EARServiceInstallRequestResult OutInstallResult) { Invoke(nameof(InstallARService), WorldContextObject, LatentInfo, OutInstallResult); }
        public ARDependencyHandler GetARDependencyHandler() { return Invoke<ARDependencyHandler>(nameof(GetARDependencyHandler)); }
        public void CheckARServiceAvailability(Object WorldContextObject, LatentActionInfo LatentInfo, EARServiceAvailability OutAvailability) { Invoke(nameof(CheckARServiceAvailability), WorldContextObject, LatentInfo, OutAvailability); }
    }
    public class ARGeoTrackingSupport : Object
    {
        public ARGeoTrackingSupport(nint addr) : base(addr) { }
        public ARGeoTrackingSupport GetGeoTrackingSupport() { return Invoke<ARGeoTrackingSupport>(nameof(GetGeoTrackingSupport)); }
        public EARGeoTrackingStateReason GetGeoTrackingStateReason() { return Invoke<EARGeoTrackingStateReason>(nameof(GetGeoTrackingStateReason)); }
        public EARGeoTrackingState GetGeoTrackingState() { return Invoke<EARGeoTrackingState>(nameof(GetGeoTrackingState)); }
        public EARGeoTrackingAccuracy GetGeoTrackingAccuracy() { return Invoke<EARGeoTrackingAccuracy>(nameof(GetGeoTrackingAccuracy)); }
        public bool AddGeoAnchorAtLocationWithAltitude(float Longitude, float Latitude, float AltitudeMeters, Object OptionalAnchorName) { return Invoke<bool>(nameof(AddGeoAnchorAtLocationWithAltitude), Longitude, Latitude, AltitudeMeters, OptionalAnchorName); }
        public bool AddGeoAnchorAtLocation(float Longitude, float Latitude, Object OptionalAnchorName) { return Invoke<bool>(nameof(AddGeoAnchorAtLocation), Longitude, Latitude, OptionalAnchorName); }
    }
    public class CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : ARBaseAsyncTaskBlueprintProxy
    {
        public CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailed { get { return this[nameof(OnFailed)]; } set { this[nameof(OnFailed)] = value; } }
        public void GeoTrackingAvailabilityDelegate__DelegateSignature(bool bIsAvailable, Object Error) { Invoke(nameof(GeoTrackingAvailabilityDelegate__DelegateSignature), bIsAvailable, Error); }
        public CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailabilityAtLocation(Object WorldContextObject, float Longitude, float Latitude) { return Invoke<CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy>(nameof(CheckGeoTrackingAvailabilityAtLocation), WorldContextObject, Longitude, Latitude); }
        public CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailability(Object WorldContextObject) { return Invoke<CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy>(nameof(CheckGeoTrackingAvailability), WorldContextObject); }
    }
    public class GetGeoLocationAsyncTaskBlueprintProxy : ARBaseAsyncTaskBlueprintProxy
    {
        public GetGeoLocationAsyncTaskBlueprintProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailed { get { return this[nameof(OnFailed)]; } set { this[nameof(OnFailed)] = value; } }
        public void GetGeoLocationDelegate__DelegateSignature(float Longitude, float Latitude, float Altitude, Object Error) { Invoke(nameof(GetGeoLocationDelegate__DelegateSignature), Longitude, Latitude, Altitude, Error); }
        public GetGeoLocationAsyncTaskBlueprintProxy GetGeoLocationAtWorldPosition(Object WorldContextObject, Vector WorldPosition) { return Invoke<GetGeoLocationAsyncTaskBlueprintProxy>(nameof(GetGeoLocationAtWorldPosition), WorldContextObject, WorldPosition); }
    }
    public class ARLifeCycleComponent : SceneComponent
    {
        public ARLifeCycleComponent(nint addr) : base(addr) { }
        public Object OnARActorSpawnedDelegate { get { return this[nameof(OnARActorSpawnedDelegate)]; } set { this[nameof(OnARActorSpawnedDelegate)] = value; } }
        public Object OnARActorToBeDestroyedDelegate { get { return this[nameof(OnARActorToBeDestroyedDelegate)]; } set { this[nameof(OnARActorToBeDestroyedDelegate)] = value; } }
        public void ServerSpawnARActor(Object ComponentClass, Guid NativeID) { Invoke(nameof(ServerSpawnARActor), ComponentClass, NativeID); }
        public void ServerDestroyARActor(ARActor Actor) { Invoke(nameof(ServerDestroyARActor), Actor); }
        public void InstanceARActorToBeDestroyedDelegate__DelegateSignature(ARActor Actor) { Invoke(nameof(InstanceARActorToBeDestroyedDelegate__DelegateSignature), Actor); }
        public void InstanceARActorSpawnedDelegate__DelegateSignature(Object ComponentClass, Guid NativeID, ARActor SpawnedActor) { Invoke(nameof(InstanceARActorSpawnedDelegate__DelegateSignature), ComponentClass, NativeID, SpawnedActor); }
    }
    public class ARLightEstimate : Object
    {
        public ARLightEstimate(nint addr) : base(addr) { }
    }
    public class ARBasicLightEstimate : ARLightEstimate
    {
        public ARBasicLightEstimate(nint addr) : base(addr) { }
        public float AmbientIntensityLumens { get { return this[nameof(AmbientIntensityLumens)].GetValue<float>(); } set { this[nameof(AmbientIntensityLumens)].SetValue<float>(value); } }
        public float AmbientColorTemperatureKelvin { get { return this[nameof(AmbientColorTemperatureKelvin)].GetValue<float>(); } set { this[nameof(AmbientColorTemperatureKelvin)].SetValue<float>(value); } }
        public LinearColor AmbientColor { get { return this[nameof(AmbientColor)].As<LinearColor>(); } set { this["AmbientColor"] = value; } }
        public float GetAmbientIntensityLumens() { return Invoke<float>(nameof(GetAmbientIntensityLumens)); }
        public float GetAmbientColorTemperatureKelvin() { return Invoke<float>(nameof(GetAmbientColorTemperatureKelvin)); }
        public LinearColor GetAmbientColor() { return Invoke<LinearColor>(nameof(GetAmbientColor)); }
    }
    public class AROriginActor : Actor
    {
        public AROriginActor(nint addr) : base(addr) { }
    }
    public class ARPin : Object
    {
        public ARPin(nint addr) : base(addr) { }
        public ARTrackedGeometry TrackedGeometry { get { return this[nameof(TrackedGeometry)].As<ARTrackedGeometry>(); } set { this["TrackedGeometry"] = value; } }
        public SceneComponent PinnedComponent { get { return this[nameof(PinnedComponent)].As<SceneComponent>(); } set { this["PinnedComponent"] = value; } }
        public Transform LocalToTrackingTransform { get { return this[nameof(LocalToTrackingTransform)].As<Transform>(); } set { this["LocalToTrackingTransform"] = value; } }
        public Transform LocalToAlignedTrackingTransform { get { return this[nameof(LocalToAlignedTrackingTransform)].As<Transform>(); } set { this["LocalToAlignedTrackingTransform"] = value; } }
        public EARTrackingState TrackingState { get { return (EARTrackingState)this[nameof(TrackingState)].GetValue<int>(); } set { this[nameof(TrackingState)].SetValue<int>((int)value); } }
        public Object OnARTrackingStateChanged { get { return this[nameof(OnARTrackingStateChanged)]; } set { this[nameof(OnARTrackingStateChanged)] = value; } }
        public Object OnARTransformUpdated { get { return this[nameof(OnARTransformUpdated)]; } set { this[nameof(OnARTransformUpdated)] = value; } }
        public EARTrackingState GetTrackingState() { return Invoke<EARTrackingState>(nameof(GetTrackingState)); }
        public ARTrackedGeometry GetTrackedGeometry() { return Invoke<ARTrackedGeometry>(nameof(GetTrackedGeometry)); }
        public SceneComponent GetPinnedComponent() { return Invoke<SceneComponent>(nameof(GetPinnedComponent)); }
        public Transform GetLocalToWorldTransform() { return Invoke<Transform>(nameof(GetLocalToWorldTransform)); }
        public Transform GetLocalToTrackingTransform() { return Invoke<Transform>(nameof(GetLocalToTrackingTransform)); }
        public Object GetDebugName() { return Invoke<Object>(nameof(GetDebugName)); }
        public void DebugDraw(World World, LinearColor Color, float Scale, float PersistForSeconds) { Invoke(nameof(DebugDraw), World, Color, Scale, PersistForSeconds); }
    }
    public class ARSessionConfig : DataAsset
    {
        public ARSessionConfig(nint addr) : base(addr) { }
        public bool bGenerateMeshDataFromTrackedGeometry { get { return this[nameof(bGenerateMeshDataFromTrackedGeometry)].Flag; } set { this[nameof(bGenerateMeshDataFromTrackedGeometry)].Flag = value; } }
        public bool bGenerateCollisionForMeshData { get { return this[nameof(bGenerateCollisionForMeshData)].Flag; } set { this[nameof(bGenerateCollisionForMeshData)].Flag = value; } }
        public bool bGenerateNavMeshForMeshData { get { return this[nameof(bGenerateNavMeshForMeshData)].Flag; } set { this[nameof(bGenerateNavMeshForMeshData)].Flag = value; } }
        public bool bUseMeshDataForOcclusion { get { return this[nameof(bUseMeshDataForOcclusion)].Flag; } set { this[nameof(bUseMeshDataForOcclusion)].Flag = value; } }
        public bool bRenderMeshDataInWireframe { get { return this[nameof(bRenderMeshDataInWireframe)].Flag; } set { this[nameof(bRenderMeshDataInWireframe)].Flag = value; } }
        public bool bTrackSceneObjects { get { return this[nameof(bTrackSceneObjects)].Flag; } set { this[nameof(bTrackSceneObjects)].Flag = value; } }
        public bool bUsePersonSegmentationForOcclusion { get { return this[nameof(bUsePersonSegmentationForOcclusion)].Flag; } set { this[nameof(bUsePersonSegmentationForOcclusion)].Flag = value; } }
        public bool bUseSceneDepthForOcclusion { get { return this[nameof(bUseSceneDepthForOcclusion)].Flag; } set { this[nameof(bUseSceneDepthForOcclusion)].Flag = value; } }
        public bool bUseAutomaticImageScaleEstimation { get { return this[nameof(bUseAutomaticImageScaleEstimation)].Flag; } set { this[nameof(bUseAutomaticImageScaleEstimation)].Flag = value; } }
        public bool bUseStandardOnboardingUX { get { return this[nameof(bUseStandardOnboardingUX)].Flag; } set { this[nameof(bUseStandardOnboardingUX)].Flag = value; } }
        public EARWorldAlignment WorldAlignment { get { return (EARWorldAlignment)this[nameof(WorldAlignment)].GetValue<int>(); } set { this[nameof(WorldAlignment)].SetValue<int>((int)value); } }
        public EARSessionType SessionType { get { return (EARSessionType)this[nameof(SessionType)].GetValue<int>(); } set { this[nameof(SessionType)].SetValue<int>((int)value); } }
        public EARPlaneDetectionMode PlaneDetectionMode { get { return (EARPlaneDetectionMode)this[nameof(PlaneDetectionMode)].GetValue<int>(); } set { this[nameof(PlaneDetectionMode)].SetValue<int>((int)value); } }
        public bool bHorizontalPlaneDetection { get { return this[nameof(bHorizontalPlaneDetection)].Flag; } set { this[nameof(bHorizontalPlaneDetection)].Flag = value; } }
        public bool bVerticalPlaneDetection { get { return this[nameof(bVerticalPlaneDetection)].Flag; } set { this[nameof(bVerticalPlaneDetection)].Flag = value; } }
        public bool bEnableAutoFocus { get { return this[nameof(bEnableAutoFocus)].Flag; } set { this[nameof(bEnableAutoFocus)].Flag = value; } }
        public EARLightEstimationMode LightEstimationMode { get { return (EARLightEstimationMode)this[nameof(LightEstimationMode)].GetValue<int>(); } set { this[nameof(LightEstimationMode)].SetValue<int>((int)value); } }
        public EARFrameSyncMode FrameSyncMode { get { return (EARFrameSyncMode)this[nameof(FrameSyncMode)].GetValue<int>(); } set { this[nameof(FrameSyncMode)].SetValue<int>((int)value); } }
        public bool bEnableAutomaticCameraOverlay { get { return this[nameof(bEnableAutomaticCameraOverlay)].Flag; } set { this[nameof(bEnableAutomaticCameraOverlay)].Flag = value; } }
        public bool bEnableAutomaticCameraTracking { get { return this[nameof(bEnableAutomaticCameraTracking)].Flag; } set { this[nameof(bEnableAutomaticCameraTracking)].Flag = value; } }
        public bool bResetCameraTracking { get { return this[nameof(bResetCameraTracking)].Flag; } set { this[nameof(bResetCameraTracking)].Flag = value; } }
        public bool bResetTrackedObjects { get { return this[nameof(bResetTrackedObjects)].Flag; } set { this[nameof(bResetTrackedObjects)].Flag = value; } }
        public Array<ARCandidateImage> CandidateImages { get { return new Array<ARCandidateImage>(this[nameof(CandidateImages)].Address); } }
        public int MaxNumSimultaneousImagesTracked { get { return this[nameof(MaxNumSimultaneousImagesTracked)].GetValue<int>(); } set { this[nameof(MaxNumSimultaneousImagesTracked)].SetValue<int>(value); } }
        public EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType { get { return (EAREnvironmentCaptureProbeType)this[nameof(EnvironmentCaptureProbeType)].GetValue<int>(); } set { this[nameof(EnvironmentCaptureProbeType)].SetValue<int>((int)value); } }
        public Array<byte> WorldMapData { get { return new Array<byte>(this[nameof(WorldMapData)].Address); } }
        public Array<ARCandidateObject> CandidateObjects { get { return new Array<ARCandidateObject>(this[nameof(CandidateObjects)].Address); } }
        public ARVideoFormat DesiredVideoFormat { get { return this[nameof(DesiredVideoFormat)].As<ARVideoFormat>(); } set { this["DesiredVideoFormat"] = value; } }
        public bool bUseOptimalVideoFormat { get { return this[nameof(bUseOptimalVideoFormat)].Flag; } set { this[nameof(bUseOptimalVideoFormat)].Flag = value; } }
        public EARFaceTrackingDirection FaceTrackingDirection { get { return (EARFaceTrackingDirection)this[nameof(FaceTrackingDirection)].GetValue<int>(); } set { this[nameof(FaceTrackingDirection)].SetValue<int>((int)value); } }
        public EARFaceTrackingUpdate FaceTrackingUpdate { get { return (EARFaceTrackingUpdate)this[nameof(FaceTrackingUpdate)].GetValue<int>(); } set { this[nameof(FaceTrackingUpdate)].SetValue<int>((int)value); } }
        public int MaxNumberOfTrackedFaces { get { return this[nameof(MaxNumberOfTrackedFaces)].GetValue<int>(); } set { this[nameof(MaxNumberOfTrackedFaces)].SetValue<int>(value); } }
        public Array<byte> SerializedARCandidateImageDatabase { get { return new Array<byte>(this[nameof(SerializedARCandidateImageDatabase)].Address); } }
        public EARSessionTrackingFeature EnabledSessionTrackingFeature { get { return (EARSessionTrackingFeature)this[nameof(EnabledSessionTrackingFeature)].GetValue<int>(); } set { this[nameof(EnabledSessionTrackingFeature)].SetValue<int>((int)value); } }
        public EARSceneReconstruction SceneReconstructionMethod { get { return (EARSceneReconstruction)this[nameof(SceneReconstructionMethod)].GetValue<int>(); } set { this[nameof(SceneReconstructionMethod)].SetValue<int>((int)value); } }
        public Object PlaneComponentClass { get { return this[nameof(PlaneComponentClass)]; } set { this[nameof(PlaneComponentClass)] = value; } }
        public Object PointComponentClass { get { return this[nameof(PointComponentClass)]; } set { this[nameof(PointComponentClass)] = value; } }
        public Object FaceComponentClass { get { return this[nameof(FaceComponentClass)]; } set { this[nameof(FaceComponentClass)] = value; } }
        public Object ImageComponentClass { get { return this[nameof(ImageComponentClass)]; } set { this[nameof(ImageComponentClass)] = value; } }
        public Object QRCodeComponentClass { get { return this[nameof(QRCodeComponentClass)]; } set { this[nameof(QRCodeComponentClass)] = value; } }
        public Object PoseComponentClass { get { return this[nameof(PoseComponentClass)]; } set { this[nameof(PoseComponentClass)] = value; } }
        public Object EnvironmentProbeComponentClass { get { return this[nameof(EnvironmentProbeComponentClass)]; } set { this[nameof(EnvironmentProbeComponentClass)] = value; } }
        public Object ObjectComponentClass { get { return this[nameof(ObjectComponentClass)]; } set { this[nameof(ObjectComponentClass)] = value; } }
        public Object MeshComponentClass { get { return this[nameof(MeshComponentClass)]; } set { this[nameof(MeshComponentClass)] = value; } }
        public Object GeoAnchorComponentClass { get { return this[nameof(GeoAnchorComponentClass)]; } set { this[nameof(GeoAnchorComponentClass)] = value; } }
        public MaterialInterface DefaultMeshMaterial { get { return this[nameof(DefaultMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultMeshMaterial"] = value; } }
        public MaterialInterface DefaultWireframeMeshMaterial { get { return this[nameof(DefaultWireframeMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultWireframeMeshMaterial"] = value; } }
        public bool ShouldResetTrackedObjects() { return Invoke<bool>(nameof(ShouldResetTrackedObjects)); }
        public bool ShouldResetCameraTracking() { return Invoke<bool>(nameof(ShouldResetCameraTracking)); }
        public bool ShouldRenderCameraOverlay() { return Invoke<bool>(nameof(ShouldRenderCameraOverlay)); }
        public bool ShouldEnableCameraTracking() { return Invoke<bool>(nameof(ShouldEnableCameraTracking)); }
        public bool ShouldEnableAutoFocus() { return Invoke<bool>(nameof(ShouldEnableAutoFocus)); }
        public void SetWorldMapData(Array<byte> WorldMapData) { Invoke(nameof(SetWorldMapData), WorldMapData); }
        public void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature) { Invoke(nameof(SetSessionTrackingFeatureToEnable), InSessionTrackingFeature); }
        public void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod) { Invoke(nameof(SetSceneReconstructionMethod), InSceneReconstructionMethod); }
        public void SetResetTrackedObjects(bool bNewValue) { Invoke(nameof(SetResetTrackedObjects), bNewValue); }
        public void SetResetCameraTracking(bool bNewValue) { Invoke(nameof(SetResetCameraTracking), bNewValue); }
        public void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate) { Invoke(nameof(SetFaceTrackingUpdate), InUpdate); }
        public void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection) { Invoke(nameof(SetFaceTrackingDirection), InDirection); }
        public void SetEnableAutoFocus(bool bNewValue) { Invoke(nameof(SetEnableAutoFocus), bNewValue); }
        public void SetDesiredVideoFormat(ARVideoFormat NewFormat) { Invoke(nameof(SetDesiredVideoFormat), NewFormat); }
        public void SetCandidateObjectList(Array<ARCandidateObject> InCandidateObjects) { Invoke(nameof(SetCandidateObjectList), InCandidateObjects); }
        public Array<byte> GetWorldMapData() { return Invoke<Array<byte>>(nameof(GetWorldMapData)); }
        public EARWorldAlignment GetWorldAlignment() { return Invoke<EARWorldAlignment>(nameof(GetWorldAlignment)); }
        public EARSessionType GetSessionType() { return Invoke<EARSessionType>(nameof(GetSessionType)); }
        public EARSceneReconstruction GetSceneReconstructionMethod() { return Invoke<EARSceneReconstruction>(nameof(GetSceneReconstructionMethod)); }
        public EARPlaneDetectionMode GetPlaneDetectionMode() { return Invoke<EARPlaneDetectionMode>(nameof(GetPlaneDetectionMode)); }
        public int GetMaxNumSimultaneousImagesTracked() { return Invoke<int>(nameof(GetMaxNumSimultaneousImagesTracked)); }
        public EARLightEstimationMode GetLightEstimationMode() { return Invoke<EARLightEstimationMode>(nameof(GetLightEstimationMode)); }
        public EARFrameSyncMode GetFrameSyncMode() { return Invoke<EARFrameSyncMode>(nameof(GetFrameSyncMode)); }
        public EARFaceTrackingUpdate GetFaceTrackingUpdate() { return Invoke<EARFaceTrackingUpdate>(nameof(GetFaceTrackingUpdate)); }
        public EARFaceTrackingDirection GetFaceTrackingDirection() { return Invoke<EARFaceTrackingDirection>(nameof(GetFaceTrackingDirection)); }
        public EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType() { return Invoke<EAREnvironmentCaptureProbeType>(nameof(GetEnvironmentCaptureProbeType)); }
        public EARSessionTrackingFeature GetEnabledSessionTrackingFeature() { return Invoke<EARSessionTrackingFeature>(nameof(GetEnabledSessionTrackingFeature)); }
        public ARVideoFormat GetDesiredVideoFormat() { return Invoke<ARVideoFormat>(nameof(GetDesiredVideoFormat)); }
        public Array<ARCandidateObject> GetCandidateObjectList() { return Invoke<Array<ARCandidateObject>>(nameof(GetCandidateObjectList)); }
        public Array<ARCandidateImage> GetCandidateImageList() { return Invoke<Array<ARCandidateImage>>(nameof(GetCandidateImageList)); }
        public void AddCandidateObject(ARCandidateObject CandidateObject) { Invoke(nameof(AddCandidateObject), CandidateObject); }
        public void AddCandidateImage(ARCandidateImage NewCandidateImage) { Invoke(nameof(AddCandidateImage), NewCandidateImage); }
    }
    public class ARSharedWorldGameMode : GameMode
    {
        public ARSharedWorldGameMode(nint addr) : base(addr) { }
        public int BufferSizePerChunk { get { return this[nameof(BufferSizePerChunk)].GetValue<int>(); } set { this[nameof(BufferSizePerChunk)].SetValue<int>(value); } }
        public void SetPreviewImageData(Array<byte> ImageData) { Invoke(nameof(SetPreviewImageData), ImageData); }
        public void SetARWorldSharingIsReady() { Invoke(nameof(SetARWorldSharingIsReady)); }
        public void SetARSharedWorldData(Array<byte> ARWorldData) { Invoke(nameof(SetARSharedWorldData), ARWorldData); }
        public ARSharedWorldGameState GetARSharedWorldGameState() { return Invoke<ARSharedWorldGameState>(nameof(GetARSharedWorldGameState)); }
    }
    public class ARSharedWorldGameState : GameState
    {
        public ARSharedWorldGameState(nint addr) : base(addr) { }
        public Array<byte> PreviewImageData { get { return new Array<byte>(this[nameof(PreviewImageData)].Address); } }
        public Array<byte> ARWorldData { get { return new Array<byte>(this[nameof(ARWorldData)].Address); } }
        public int PreviewImageBytesTotal { get { return this[nameof(PreviewImageBytesTotal)].GetValue<int>(); } set { this[nameof(PreviewImageBytesTotal)].SetValue<int>(value); } }
        public int ARWorldBytesTotal { get { return this[nameof(ARWorldBytesTotal)].GetValue<int>(); } set { this[nameof(ARWorldBytesTotal)].SetValue<int>(value); } }
        public int PreviewImageBytesDelivered { get { return this[nameof(PreviewImageBytesDelivered)].GetValue<int>(); } set { this[nameof(PreviewImageBytesDelivered)].SetValue<int>(value); } }
        public int ARWorldBytesDelivered { get { return this[nameof(ARWorldBytesDelivered)].GetValue<int>(); } set { this[nameof(ARWorldBytesDelivered)].SetValue<int>(value); } }
        public void K2_OnARWorldMapIsReady() { Invoke(nameof(K2_OnARWorldMapIsReady)); }
    }
    public class ARSharedWorldPlayerController : PlayerController
    {
        public ARSharedWorldPlayerController(nint addr) : base(addr) { }
        public void ServerMarkReadyForReceiving() { Invoke(nameof(ServerMarkReadyForReceiving)); }
        public void ClientUpdatePreviewImageData(int Offset, Array<byte> Buffer) { Invoke(nameof(ClientUpdatePreviewImageData), Offset, Buffer); }
        public void ClientUpdateARWorldData(int Offset, Array<byte> Buffer) { Invoke(nameof(ClientUpdateARWorldData), Offset, Buffer); }
        public void ClientInitSharedWorld(int PreviewImageSize, int ARWorldDataSize) { Invoke(nameof(ClientInitSharedWorld), PreviewImageSize, ARWorldDataSize); }
    }
    public class ARSkyLight : SkyLight
    {
        public ARSkyLight(nint addr) : base(addr) { }
        public AREnvironmentCaptureProbe CaptureProbe { get { return this[nameof(CaptureProbe)].As<AREnvironmentCaptureProbe>(); } set { this["CaptureProbe"] = value; } }
        public void SetEnvironmentCaptureProbe(AREnvironmentCaptureProbe InCaptureProbe) { Invoke(nameof(SetEnvironmentCaptureProbe), InCaptureProbe); }
    }
    public class ARTexture : Texture
    {
        public ARTexture(nint addr) : base(addr) { }
        public EARTextureType TextureType { get { return (EARTextureType)this[nameof(TextureType)].GetValue<int>(); } set { this[nameof(TextureType)].SetValue<int>((int)value); } }
        public float Timestamp { get { return this[nameof(Timestamp)].GetValue<float>(); } set { this[nameof(Timestamp)].SetValue<float>(value); } }
        public Guid ExternalTextureGuid { get { return this[nameof(ExternalTextureGuid)].As<Guid>(); } set { this["ExternalTextureGuid"] = value; } }
        public Vector2D Size { get { return this[nameof(Size)].As<Vector2D>(); } set { this["Size"] = value; } }
    }
    public class ARTextureCameraImage : ARTexture
    {
        public ARTextureCameraImage(nint addr) : base(addr) { }
    }
    public class ARTextureCameraDepth : ARTexture
    {
        public ARTextureCameraDepth(nint addr) : base(addr) { }
        public EARDepthQuality DepthQuality { get { return (EARDepthQuality)this[nameof(DepthQuality)].GetValue<int>(); } set { this[nameof(DepthQuality)].SetValue<int>((int)value); } }
        public EARDepthAccuracy DepthAccuracy { get { return (EARDepthAccuracy)this[nameof(DepthAccuracy)].GetValue<int>(); } set { this[nameof(DepthAccuracy)].SetValue<int>((int)value); } }
        public bool bIsTemporallySmoothed { get { return this[nameof(bIsTemporallySmoothed)].Flag; } set { this[nameof(bIsTemporallySmoothed)].Flag = value; } }
    }
    public class AREnvironmentCaptureProbeTexture : TextureCube
    {
        public AREnvironmentCaptureProbeTexture(nint addr) : base(addr) { }
        public EARTextureType TextureType { get { return (EARTextureType)this[nameof(TextureType)].GetValue<int>(); } set { this[nameof(TextureType)].SetValue<int>((int)value); } }
        public float Timestamp { get { return this[nameof(Timestamp)].GetValue<float>(); } set { this[nameof(Timestamp)].SetValue<float>(value); } }
        public Guid ExternalTextureGuid { get { return this[nameof(ExternalTextureGuid)].As<Guid>(); } set { this["ExternalTextureGuid"] = value; } }
        public Vector2D Size { get { return this[nameof(Size)].As<Vector2D>(); } set { this["Size"] = value; } }
    }
    public class ARTraceResultDummy : Object
    {
        public ARTraceResultDummy(nint addr) : base(addr) { }
    }
    public class ARTrackedGeometry : Object
    {
        public ARTrackedGeometry(nint addr) : base(addr) { }
        public Guid UniqueId { get { return this[nameof(UniqueId)].As<Guid>(); } set { this["UniqueId"] = value; } }
        public Transform LocalToTrackingTransform { get { return this[nameof(LocalToTrackingTransform)].As<Transform>(); } set { this["LocalToTrackingTransform"] = value; } }
        public Transform LocalToAlignedTrackingTransform { get { return this[nameof(LocalToAlignedTrackingTransform)].As<Transform>(); } set { this["LocalToAlignedTrackingTransform"] = value; } }
        public EARTrackingState TrackingState { get { return (EARTrackingState)this[nameof(TrackingState)].GetValue<int>(); } set { this[nameof(TrackingState)].SetValue<int>((int)value); } }
        public MRMeshComponent UnderlyingMesh { get { return this[nameof(UnderlyingMesh)].As<MRMeshComponent>(); } set { this["UnderlyingMesh"] = value; } }
        public EARObjectClassification ObjectClassification { get { return (EARObjectClassification)this[nameof(ObjectClassification)].GetValue<int>(); } set { this[nameof(ObjectClassification)].SetValue<int>((int)value); } }
        public EARSpatialMeshUsageFlags SpatialMeshUsageFlags { get { return (EARSpatialMeshUsageFlags)this[nameof(SpatialMeshUsageFlags)].GetValue<int>(); } set { this[nameof(SpatialMeshUsageFlags)].SetValue<int>((int)value); } }
        public int LastUpdateFrameNumber { get { return this[nameof(LastUpdateFrameNumber)].GetValue<int>(); } set { this[nameof(LastUpdateFrameNumber)].SetValue<int>(value); } }
        public Object DebugName { get { return this[nameof(DebugName)]; } set { this[nameof(DebugName)] = value; } }
        public bool IsTracked() { return Invoke<bool>(nameof(IsTracked)); }
        public bool HasSpatialMeshUsageFlag(EARSpatialMeshUsageFlags InFlag) { return Invoke<bool>(nameof(HasSpatialMeshUsageFlag), InFlag); }
        public MRMeshComponent GetUnderlyingMesh() { return Invoke<MRMeshComponent>(nameof(GetUnderlyingMesh)); }
        public EARTrackingState GetTrackingState() { return Invoke<EARTrackingState>(nameof(GetTrackingState)); }
        public EARObjectClassification GetObjectClassification() { return Invoke<EARObjectClassification>(nameof(GetObjectClassification)); }
        public Object GetName() { return Invoke<Object>(nameof(GetName)); }
        public Transform GetLocalToWorldTransform() { return Invoke<Transform>(nameof(GetLocalToWorldTransform)); }
        public Transform GetLocalToTrackingTransform() { return Invoke<Transform>(nameof(GetLocalToTrackingTransform)); }
        public float GetLastUpdateTimestamp() { return Invoke<float>(nameof(GetLastUpdateTimestamp)); }
        public int GetLastUpdateFrameNumber() { return Invoke<int>(nameof(GetLastUpdateFrameNumber)); }
        public Object GetDebugName() { return Invoke<Object>(nameof(GetDebugName)); }
    }
    public class ARPlaneGeometry : ARTrackedGeometry
    {
        public ARPlaneGeometry(nint addr) : base(addr) { }
        public EARPlaneOrientation Orientation { get { return (EARPlaneOrientation)this[nameof(Orientation)].GetValue<int>(); } set { this[nameof(Orientation)].SetValue<int>((int)value); } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Extent { get { return this[nameof(Extent)].As<Vector>(); } set { this["Extent"] = value; } }
        public Array<Vector> BoundaryPolygon { get { return new Array<Vector>(this[nameof(BoundaryPolygon)].Address); } }
        public ARPlaneGeometry SubsumedBy { get { return this[nameof(SubsumedBy)].As<ARPlaneGeometry>(); } set { this["SubsumedBy"] = value; } }
        public ARPlaneGeometry GetSubsumedBy() { return Invoke<ARPlaneGeometry>(nameof(GetSubsumedBy)); }
        public EARPlaneOrientation GetOrientation() { return Invoke<EARPlaneOrientation>(nameof(GetOrientation)); }
        public Vector GetExtent() { return Invoke<Vector>(nameof(GetExtent)); }
        public Vector GetCenter() { return Invoke<Vector>(nameof(GetCenter)); }
        public Array<Vector> GetBoundaryPolygonInLocalSpace() { return Invoke<Array<Vector>>(nameof(GetBoundaryPolygonInLocalSpace)); }
    }
    public class ARTrackedPoint : ARTrackedGeometry
    {
        public ARTrackedPoint(nint addr) : base(addr) { }
    }
    public class ARTrackedImage : ARTrackedGeometry
    {
        public ARTrackedImage(nint addr) : base(addr) { }
        public ARCandidateImage DetectedImage { get { return this[nameof(DetectedImage)].As<ARCandidateImage>(); } set { this["DetectedImage"] = value; } }
        public Vector2D EstimatedSize { get { return this[nameof(EstimatedSize)].As<Vector2D>(); } set { this["EstimatedSize"] = value; } }
        public Vector2D GetEstimateSize() { return Invoke<Vector2D>(nameof(GetEstimateSize)); }
        public ARCandidateImage GetDetectedImage() { return Invoke<ARCandidateImage>(nameof(GetDetectedImage)); }
    }
    public class ARTrackedQRCode : ARTrackedImage
    {
        public ARTrackedQRCode(nint addr) : base(addr) { }
        public Object QRCode { get { return this[nameof(QRCode)]; } set { this[nameof(QRCode)] = value; } }
        public int Version { get { return this[nameof(Version)].GetValue<int>(); } set { this[nameof(Version)].SetValue<int>(value); } }
    }
    public class ARFaceGeometry : ARTrackedGeometry
    {
        public ARFaceGeometry(nint addr) : base(addr) { }
        public Vector LookAtTarget { get { return this[nameof(LookAtTarget)].As<Vector>(); } set { this["LookAtTarget"] = value; } }
        public bool bIsTracked { get { return this[nameof(bIsTracked)].Flag; } set { this[nameof(bIsTracked)].Flag = value; } }
        public Object BlendShapes { get { return this[nameof(BlendShapes)]; } set { this[nameof(BlendShapes)] = value; } }
        public Transform LeftEyeTransform { get { return this[nameof(LeftEyeTransform)].As<Transform>(); } set { this["LeftEyeTransform"] = value; } }
        public Transform RightEyeTransform { get { return this[nameof(RightEyeTransform)].As<Transform>(); } set { this["RightEyeTransform"] = value; } }
        public Transform GetWorldSpaceEyeTransform(EAREye Eye) { return Invoke<Transform>(nameof(GetWorldSpaceEyeTransform), Eye); }
        public Transform GetLocalSpaceEyeTransform(EAREye Eye) { return Invoke<Transform>(nameof(GetLocalSpaceEyeTransform), Eye); }
        public float GetBlendShapeValue(EARFaceBlendShape BlendShape) { return Invoke<float>(nameof(GetBlendShapeValue), BlendShape); }
        public Object GetBlendShapes() { return Invoke<Object>(nameof(GetBlendShapes)); }
    }
    public class AREnvironmentCaptureProbe : ARTrackedGeometry
    {
        public AREnvironmentCaptureProbe(nint addr) : base(addr) { }
        public Vector Extent { get { return this[nameof(Extent)].As<Vector>(); } set { this["Extent"] = value; } }
        public AREnvironmentCaptureProbeTexture EnvironmentCaptureTexture { get { return this[nameof(EnvironmentCaptureTexture)].As<AREnvironmentCaptureProbeTexture>(); } set { this["EnvironmentCaptureTexture"] = value; } }
        public Vector GetExtent() { return Invoke<Vector>(nameof(GetExtent)); }
        public AREnvironmentCaptureProbeTexture GetEnvironmentCaptureTexture() { return Invoke<AREnvironmentCaptureProbeTexture>(nameof(GetEnvironmentCaptureTexture)); }
    }
    public class ARTrackedObject : ARTrackedGeometry
    {
        public ARTrackedObject(nint addr) : base(addr) { }
        public ARCandidateObject DetectedObject { get { return this[nameof(DetectedObject)].As<ARCandidateObject>(); } set { this["DetectedObject"] = value; } }
        public ARCandidateObject GetDetectedObject() { return Invoke<ARCandidateObject>(nameof(GetDetectedObject)); }
    }
    public class ARTrackedPose : ARTrackedGeometry
    {
        public ARTrackedPose(nint addr) : base(addr) { }
        public ARPose3D TrackedPose { get { return this[nameof(TrackedPose)].As<ARPose3D>(); } set { this["TrackedPose"] = value; } }
        public ARPose3D GetTrackedPoseData() { return Invoke<ARPose3D>(nameof(GetTrackedPoseData)); }
    }
    public class ARMeshGeometry : ARTrackedGeometry
    {
        public ARMeshGeometry(nint addr) : base(addr) { }
        public bool GetObjectClassificationAtLocation(Vector InWorldLocation, EARObjectClassification OutClassification, Vector OutClassificationLocation, float MaxLocationDiff) { return Invoke<bool>(nameof(GetObjectClassificationAtLocation), InWorldLocation, OutClassification, OutClassificationLocation, MaxLocationDiff); }
    }
    public class ARGeoAnchor : ARTrackedGeometry
    {
        public ARGeoAnchor(nint addr) : base(addr) { }
        public float GetLongitude() { return Invoke<float>(nameof(GetLongitude)); }
        public float GetLatitude() { return Invoke<float>(nameof(GetLatitude)); }
        public EARAltitudeSource GetAltitudeSource() { return Invoke<EARAltitudeSource>(nameof(GetAltitudeSource)); }
        public float GetAltitudeMeters() { return Invoke<float>(nameof(GetAltitudeMeters)); }
    }
    public class ARTrackableNotifyComponent : ActorComponent
    {
        public ARTrackableNotifyComponent(nint addr) : base(addr) { }
        public Object OnAddTrackedGeometry { get { return this[nameof(OnAddTrackedGeometry)]; } set { this[nameof(OnAddTrackedGeometry)] = value; } }
        public Object OnUpdateTrackedGeometry { get { return this[nameof(OnUpdateTrackedGeometry)]; } set { this[nameof(OnUpdateTrackedGeometry)] = value; } }
        public Object OnRemoveTrackedGeometry { get { return this[nameof(OnRemoveTrackedGeometry)]; } set { this[nameof(OnRemoveTrackedGeometry)] = value; } }
        public Object OnAddTrackedPlane { get { return this[nameof(OnAddTrackedPlane)]; } set { this[nameof(OnAddTrackedPlane)] = value; } }
        public Object OnUpdateTrackedPlane { get { return this[nameof(OnUpdateTrackedPlane)]; } set { this[nameof(OnUpdateTrackedPlane)] = value; } }
        public Object OnRemoveTrackedPlane { get { return this[nameof(OnRemoveTrackedPlane)]; } set { this[nameof(OnRemoveTrackedPlane)] = value; } }
        public Object OnAddTrackedPoint { get { return this[nameof(OnAddTrackedPoint)]; } set { this[nameof(OnAddTrackedPoint)] = value; } }
        public Object OnUpdateTrackedPoint { get { return this[nameof(OnUpdateTrackedPoint)]; } set { this[nameof(OnUpdateTrackedPoint)] = value; } }
        public Object OnRemoveTrackedPoint { get { return this[nameof(OnRemoveTrackedPoint)]; } set { this[nameof(OnRemoveTrackedPoint)] = value; } }
        public Object OnAddTrackedImage { get { return this[nameof(OnAddTrackedImage)]; } set { this[nameof(OnAddTrackedImage)] = value; } }
        public Object OnUpdateTrackedImage { get { return this[nameof(OnUpdateTrackedImage)]; } set { this[nameof(OnUpdateTrackedImage)] = value; } }
        public Object OnRemoveTrackedImage { get { return this[nameof(OnRemoveTrackedImage)]; } set { this[nameof(OnRemoveTrackedImage)] = value; } }
        public Object OnAddTrackedFace { get { return this[nameof(OnAddTrackedFace)]; } set { this[nameof(OnAddTrackedFace)] = value; } }
        public Object OnUpdateTrackedFace { get { return this[nameof(OnUpdateTrackedFace)]; } set { this[nameof(OnUpdateTrackedFace)] = value; } }
        public Object OnRemoveTrackedFace { get { return this[nameof(OnRemoveTrackedFace)]; } set { this[nameof(OnRemoveTrackedFace)] = value; } }
        public Object OnAddTrackedEnvProbe { get { return this[nameof(OnAddTrackedEnvProbe)]; } set { this[nameof(OnAddTrackedEnvProbe)] = value; } }
        public Object OnUpdateTrackedEnvProbe { get { return this[nameof(OnUpdateTrackedEnvProbe)]; } set { this[nameof(OnUpdateTrackedEnvProbe)] = value; } }
        public Object OnRemoveTrackedEnvProbe { get { return this[nameof(OnRemoveTrackedEnvProbe)]; } set { this[nameof(OnRemoveTrackedEnvProbe)] = value; } }
        public Object OnAddTrackedObject { get { return this[nameof(OnAddTrackedObject)]; } set { this[nameof(OnAddTrackedObject)] = value; } }
        public Object OnUpdateTrackedObject { get { return this[nameof(OnUpdateTrackedObject)]; } set { this[nameof(OnUpdateTrackedObject)] = value; } }
        public Object OnRemoveTrackedObject { get { return this[nameof(OnRemoveTrackedObject)]; } set { this[nameof(OnRemoveTrackedObject)] = value; } }
    }
    public class ARTypesDummyClass : Object
    {
        public ARTypesDummyClass(nint addr) : base(addr) { }
    }
    public class ARCandidateImage : DataAsset
    {
        public ARCandidateImage(nint addr) : base(addr) { }
        public Texture2D CandidateTexture { get { return this[nameof(CandidateTexture)].As<Texture2D>(); } set { this["CandidateTexture"] = value; } }
        public Object FriendlyName { get { return this[nameof(FriendlyName)]; } set { this[nameof(FriendlyName)] = value; } }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
        public EARCandidateImageOrientation Orientation { get { return (EARCandidateImageOrientation)this[nameof(Orientation)].GetValue<int>(); } set { this[nameof(Orientation)].SetValue<int>((int)value); } }
        public float GetPhysicalWidth() { return Invoke<float>(nameof(GetPhysicalWidth)); }
        public float GetPhysicalHeight() { return Invoke<float>(nameof(GetPhysicalHeight)); }
        public EARCandidateImageOrientation GetOrientation() { return Invoke<EARCandidateImageOrientation>(nameof(GetOrientation)); }
        public Object GetFriendlyName() { return Invoke<Object>(nameof(GetFriendlyName)); }
        public Texture2D GetCandidateTexture() { return Invoke<Texture2D>(nameof(GetCandidateTexture)); }
    }
    public class ARCandidateObject : DataAsset
    {
        public ARCandidateObject(nint addr) : base(addr) { }
        public Array<byte> CandidateObjectData { get { return new Array<byte>(this[nameof(CandidateObjectData)].Address); } }
        public Object FriendlyName { get { return this[nameof(FriendlyName)]; } set { this[nameof(FriendlyName)] = value; } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public void SetFriendlyName(Object NewName) { Invoke(nameof(SetFriendlyName), NewName); }
        public void SetCandidateObjectData(Array<byte> InCandidateObject) { Invoke(nameof(SetCandidateObjectData), InCandidateObject); }
        public void SetBoundingBox(Box InBoundingBox) { Invoke(nameof(SetBoundingBox), InBoundingBox); }
        public Object GetFriendlyName() { return Invoke<Object>(nameof(GetFriendlyName)); }
        public Array<byte> GetCandidateObjectData() { return Invoke<Array<byte>>(nameof(GetCandidateObjectData)); }
        public Box GetBoundingBox() { return Invoke<Box>(nameof(GetBoundingBox)); }
    }
    public enum EARTrackingState : int
    {
        Unknown = 0,
        Tracking = 1,
        NotTracking = 2,
        StoppedTracking = 3,
        EARTrackingState_MAX = 4,
    }
    public enum EARSessionConfigFlags : int
    {
        None = 0,
        GenerateMeshData = 1,
        RenderMeshDataInWireframe = 2,
        GenerateCollisionForMeshData = 4,
        GenerateNavMeshForMeshData = 8,
        UseMeshDataForOcclusion = 16,
        EARSessionConfigFlags_MAX = 17,
    }
    public enum EPlaneComponentDebugMode : int
    {
        None = 0,
        ShowNetworkRole = 1,
        ShowClassification = 2,
        EPlaneComponentDebugMode_MAX = 3,
    }
    public enum EFaceComponentDebugMode : int
    {
        None = 0,
        ShowEyeVectors = 1,
        ShowFaceMesh = 2,
        EFaceComponentDebugMode_MAX = 3,
    }
    public enum EARFaceTransformMixing : int
    {
        ComponentOnly = 0,
        ComponentLocationTrackedRotation = 1,
        ComponentWithTracked = 2,
        TrackingOnly = 3,
        EARFaceTransformMixing_MAX = 4,
    }
    public enum EImageComponentDebugMode : int
    {
        None = 0,
        ShowDetectedImage = 1,
        EImageComponentDebugMode_MAX = 2,
    }
    public enum EQRCodeComponentDebugMode : int
    {
        None = 0,
        ShowQRCode = 1,
        EQRCodeComponentDebugMode_MAX = 2,
    }
    public enum EPoseComponentDebugMode : int
    {
        None = 0,
        ShowSkeleton = 1,
        EPoseComponentDebugMode_MAX = 2,
    }
    public enum EGeoAnchorComponentDebugMode : int
    {
        None = 0,
        ShowGeoData = 1,
        EGeoAnchorComponentDebugMode_MAX = 2,
    }
    public enum EARServiceAvailability : int
    {
        UnknownError = 0,
        UnknownChecking = 1,
        UnknownTimedOut = 2,
        UnsupportedDeviceNotCapable = 3,
        SupportedNotInstalled = 4,
        SupportedVersionTooOld = 5,
        SupportedInstalled = 6,
        EARServiceAvailability_MAX = 7,
    }
    public enum EARServiceInstallRequestResult : int
    {
        Installed = 0,
        DeviceNotCompatible = 1,
        UserDeclinedInstallation = 2,
        FatalError = 3,
        EARServiceInstallRequestResult_MAX = 4,
    }
    public enum EARServicePermissionRequestResult : int
    {
        Granted = 0,
        Denied = 1,
        EARServicePermissionRequestResult_MAX = 2,
    }
    public enum EARGeoTrackingState : int
    {
        Initializing = 0,
        Localized = 1,
        Localizing = 2,
        NotAvailable = 3,
        EARGeoTrackingState_MAX = 4,
    }
    public enum EARGeoTrackingStateReason : int
    {
        None = 0,
        NotAvailableAtLocation = 1,
        NeedLocationPermissions = 2,
        DevicePointedTooLow = 3,
        WorldTrackingUnstable = 4,
        WaitingForLocation = 5,
        GeoDataNotLoaded = 6,
        VisualLocalizationFailed = 7,
        WaitingForAvailabilityCheck = 8,
        EARGeoTrackingStateReason_MAX = 9,
    }
    public enum EARGeoTrackingAccuracy : int
    {
        Undetermined = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        EARGeoTrackingAccuracy_MAX = 4,
    }
    public enum EARWorldAlignment : int
    {
        Gravity = 0,
        GravityAndHeading = 1,
        Camera = 2,
        EARWorldAlignment_MAX = 3,
    }
    public enum EARSessionType : int
    {
        None = 0,
        Orientation = 1,
        World = 2,
        Face = 3,
        Image = 4,
        ObjectScanning = 5,
        PoseTracking = 6,
        GeoTracking = 7,
        EARSessionType_MAX = 8,
    }
    public enum EARPlaneDetectionMode : int
    {
        None = 0,
        HorizontalPlaneDetection = 1,
        VerticalPlaneDetection = 2,
        EARPlaneDetectionMode_MAX = 3,
    }
    public enum EARLightEstimationMode : int
    {
        None = 0,
        AmbientLightEstimate = 1,
        DirectionalLightEstimate = 2,
        EARLightEstimationMode_MAX = 3,
    }
    public enum EARFrameSyncMode : int
    {
        SyncTickWithCameraImage = 0,
        SyncTickWithoutCameraImage = 1,
        EARFrameSyncMode_MAX = 2,
    }
    public enum EAREnvironmentCaptureProbeType : int
    {
        None = 0,
        Manual = 1,
        Automatic = 2,
        EAREnvironmentCaptureProbeType_MAX = 3,
    }
    public enum EARFaceTrackingUpdate : int
    {
        CurvesAndGeo = 0,
        CurvesOnly = 1,
        EARFaceTrackingUpdate_MAX = 2,
    }
    public enum EARSessionTrackingFeature : int
    {
        None = 0,
        PoseDetection2D = 1,
        PersonSegmentation = 2,
        PersonSegmentationWithDepth = 3,
        SceneDepth = 4,
        SmoothedSceneDepth = 5,
        EARSessionTrackingFeature_MAX = 6,
    }
    public enum EARSceneReconstruction : int
    {
        None = 0,
        MeshOnly = 1,
        MeshWithClassification = 2,
        EARSceneReconstruction_MAX = 3,
    }
    public enum EARTextureType : int
    {
        Unknown = 0,
        CameraImage = 1,
        CameraDepth = 2,
        EnvironmentCapture = 3,
        PersonSegmentationImage = 4,
        PersonSegmentationDepth = 5,
        SceneDepthMap = 6,
        SceneDepthConfidenceMap = 7,
        EARTextureType_MAX = 8,
    }
    public enum EARDepthQuality : int
    {
        Unkown = 0,
        Low = 1,
        High = 2,
        EARDepthQuality_MAX = 3,
    }
    public enum EARDepthAccuracy : int
    {
        Unkown = 0,
        Approximate = 1,
        Accurate = 2,
        EARDepthAccuracy_MAX = 3,
    }
    public enum EARFaceTrackingDirection : int
    {
        FaceRelative = 0,
        FaceMirrored = 1,
        EARFaceTrackingDirection_MAX = 2,
    }
    public enum EARFaceBlendShape : int
    {
        EyeBlinkLeft = 0,
        EyeLookDownLeft = 1,
        EyeLookInLeft = 2,
        EyeLookOutLeft = 3,
        EyeLookUpLeft = 4,
        EyeSquintLeft = 5,
        EyeWideLeft = 6,
        EyeBlinkRight = 7,
        EyeLookDownRight = 8,
        EyeLookInRight = 9,
        EyeLookOutRight = 10,
        EyeLookUpRight = 11,
        EyeSquintRight = 12,
        EyeWideRight = 13,
        JawForward = 14,
        JawLeft = 15,
        JawRight = 16,
        JawOpen = 17,
        MouthClose = 18,
        MouthFunnel = 19,
        MouthPucker = 20,
        MouthLeft = 21,
        MouthRight = 22,
        MouthSmileLeft = 23,
        MouthSmileRight = 24,
        MouthFrownLeft = 25,
        MouthFrownRight = 26,
        MouthDimpleLeft = 27,
        MouthDimpleRight = 28,
        MouthStretchLeft = 29,
        MouthStretchRight = 30,
        MouthRollLower = 31,
        MouthRollUpper = 32,
        MouthShrugLower = 33,
        MouthShrugUpper = 34,
        MouthPressLeft = 35,
        MouthPressRight = 36,
        MouthLowerDownLeft = 37,
        MouthLowerDownRight = 38,
        MouthUpperUpLeft = 39,
        MouthUpperUpRight = 40,
        BrowDownLeft = 41,
        BrowDownRight = 42,
        BrowInnerUp = 43,
        BrowOuterUpLeft = 44,
        BrowOuterUpRight = 45,
        CheekPuff = 46,
        CheekSquintLeft = 47,
        CheekSquintRight = 48,
        NoseSneerLeft = 49,
        NoseSneerRight = 50,
        TongueOut = 51,
        HeadYaw = 52,
        HeadPitch = 53,
        HeadRoll = 54,
        LeftEyeYaw = 55,
        LeftEyePitch = 56,
        LeftEyeRoll = 57,
        RightEyeYaw = 58,
        RightEyePitch = 59,
        RightEyeRoll = 60,
        MAX = 61,
    }
    public enum EAREye : int
    {
        LeftEye = 0,
        RightEye = 1,
        EAREye_MAX = 2,
    }
    public enum EARCaptureType : int
    {
        Camera = 0,
        QRCode = 1,
        SpatialMapping = 2,
        SceneUnderstanding = 3,
        HandMesh = 4,
        EARCaptureType_MAX = 5,
    }
    public enum EARLineTraceChannels : int
    {
        None = 0,
        FeaturePoint = 1,
        GroundPlane = 2,
        PlaneUsingExtent = 4,
        PlaneUsingBoundaryPolygon = 8,
        EARLineTraceChannels_MAX = 9,
    }
    public enum EARTrackingQuality : int
    {
        NotTracking = 0,
        OrientationOnly = 1,
        OrientationAndPosition = 2,
        EARTrackingQuality_MAX = 3,
    }
    public enum EARTrackingQualityReason : int
    {
        None = 0,
        Initializing = 1,
        Relocalizing = 2,
        ExcessiveMotion = 3,
        InsufficientFeatures = 4,
        InsufficientLight = 5,
        BadState = 6,
        EARTrackingQualityReason_MAX = 7,
    }
    public enum EARSessionStatus : int
    {
        NotStarted = 0,
        Running = 1,
        NotSupported = 2,
        FatalError = 3,
        PermissionNotGranted = 4,
        UnsupportedConfiguration = 5,
        Other = 6,
        EARSessionStatus_MAX = 7,
    }
    public enum EARWorldMappingState : int
    {
        NotAvailable = 0,
        StillMappingNotRelocalizable = 1,
        StillMappingRelocalizable = 2,
        Mapped = 3,
        EARWorldMappingState_MAX = 4,
    }
    public enum EARPlaneOrientation : int
    {
        Horizontal = 0,
        Vertical = 1,
        Diagonal = 2,
        EARPlaneOrientation_MAX = 3,
    }
    public enum EARObjectClassification : int
    {
        NotApplicable = 0,
        Unknown = 1,
        Wall = 2,
        Ceiling = 3,
        Floor = 4,
        Table = 5,
        Seat = 6,
        Face = 7,
        Image = 8,
        World = 9,
        SceneObject = 10,
        HandMesh = 11,
        Door = 12,
        Window = 13,
        EARObjectClassification_MAX = 14,
    }
    public enum EARSpatialMeshUsageFlags : int
    {
        NotApplicable = 0,
        Visible = 1,
        Collision = 2,
        EARSpatialMeshUsageFlags_MAX = 3,
    }
    public enum EARJointTransformSpace : int
    {
        Model = 0,
        ParentJoint = 1,
        EARJointTransformSpace_MAX = 2,
    }
    public enum EARAltitudeSource : int
    {
        Precise = 0,
        Coarse = 1,
        UserDefined = 2,
        Unknown = 3,
        EARAltitudeSource_MAX = 4,
    }
    public enum EARCandidateImageOrientation : int
    {
        Landscape = 0,
        Portrait = 1,
        EARCandidateImageOrientation_MAX = 2,
    }
    public class TrackedGeometryGroup : Object
    {
        public TrackedGeometryGroup(nint addr) : base(addr) { }
        public ARActor ARActor { get { return this[nameof(ARActor)].As<ARActor>(); } set { this["ARActor"] = value; } }
        public ARComponent ARComponent { get { return this[nameof(ARComponent)].As<ARComponent>(); } set { this["ARComponent"] = value; } }
        public ARTrackedGeometry TrackedGeometry { get { return this[nameof(TrackedGeometry)].As<ARTrackedGeometry>(); } set { this["TrackedGeometry"] = value; } }
    }
    public class ARSessionPayload : Object
    {
        public ARSessionPayload(nint addr) : base(addr) { }
        public int ConfigFlags { get { return this[nameof(ConfigFlags)].GetValue<int>(); } set { this[nameof(ConfigFlags)].SetValue<int>(value); } }
        public MaterialInterface DefaultMeshMaterial { get { return this[nameof(DefaultMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultMeshMaterial"] = value; } }
        public MaterialInterface DefaultWireframeMeshMaterial { get { return this[nameof(DefaultWireframeMeshMaterial)].As<MaterialInterface>(); } set { this["DefaultWireframeMeshMaterial"] = value; } }
    }
    public class ARPlaneUpdatePayload : Object
    {
        public ARPlaneUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Extents { get { return this[nameof(Extents)].As<Vector>(); } set { this["Extents"] = value; } }
        public Array<Vector> BoundaryVertices { get { return new Array<Vector>(this[nameof(BoundaryVertices)].Address); } }
        public EARObjectClassification ObjectClassification { get { return (EARObjectClassification)this[nameof(ObjectClassification)].GetValue<int>(); } set { this[nameof(ObjectClassification)].SetValue<int>((int)value); } }
    }
    public class ARPointUpdatePayload : Object
    {
        public ARPointUpdatePayload(nint addr) : base(addr) { }
    }
    public class ARFaceUpdatePayload : Object
    {
        public ARFaceUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Vector LeftEyePosition { get { return this[nameof(LeftEyePosition)].As<Vector>(); } set { this["LeftEyePosition"] = value; } }
        public Vector RightEyePosition { get { return this[nameof(RightEyePosition)].As<Vector>(); } set { this["RightEyePosition"] = value; } }
        public Vector LookAtTarget { get { return this[nameof(LookAtTarget)].As<Vector>(); } set { this["LookAtTarget"] = value; } }
    }
    public class ARImageUpdatePayload : Object
    {
        public ARImageUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public ARCandidateImage DetectedImage { get { return this[nameof(DetectedImage)].As<ARCandidateImage>(); } set { this["DetectedImage"] = value; } }
        public Vector2D EstimatedSize { get { return this[nameof(EstimatedSize)].As<Vector2D>(); } set { this["EstimatedSize"] = value; } }
    }
    public class ARQRCodeUpdatePayload : Object
    {
        public ARQRCodeUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public Vector Extents { get { return this[nameof(Extents)].As<Vector>(); } set { this["Extents"] = value; } }
        public Object QRCode { get { return this[nameof(QRCode)]; } set { this[nameof(QRCode)] = value; } }
    }
    public class ARPoseUpdatePayload : Object
    {
        public ARPoseUpdatePayload(nint addr) : base(addr) { }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public Array<Transform> JointTransforms { get { return new Array<Transform>(this[nameof(JointTransforms)].Address); } }
    }
    public class AREnvironmentProbeUpdatePayload : Object
    {
        public AREnvironmentProbeUpdatePayload(nint addr) : base(addr) { }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
    }
    public class ARObjectUpdatePayload : Object
    {
        public ARObjectUpdatePayload(nint addr) : base(addr) { }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
    }
    public class ARMeshUpdatePayload : Object
    {
        public ARMeshUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public EARObjectClassification ObjectClassification { get { return (EARObjectClassification)this[nameof(ObjectClassification)].GetValue<int>(); } set { this[nameof(ObjectClassification)].SetValue<int>((int)value); } }
    }
    public class ARGeoAnchorUpdatePayload : Object
    {
        public ARGeoAnchorUpdatePayload(nint addr) : base(addr) { }
        public ARSessionPayload SessionPayload { get { return this[nameof(SessionPayload)].As<ARSessionPayload>(); } set { this["SessionPayload"] = value; } }
        public Transform WorldTransform { get { return this[nameof(WorldTransform)].As<Transform>(); } set { this["WorldTransform"] = value; } }
        public float Longitude { get { return this[nameof(Longitude)].GetValue<float>(); } set { this[nameof(Longitude)].SetValue<float>(value); } }
        public float Latitude { get { return this[nameof(Latitude)].GetValue<float>(); } set { this[nameof(Latitude)].SetValue<float>(value); } }
        public float AltitudeMeters { get { return this[nameof(AltitudeMeters)].GetValue<float>(); } set { this[nameof(AltitudeMeters)].SetValue<float>(value); } }
        public EARAltitudeSource AltitudeSource { get { return (EARAltitudeSource)this[nameof(AltitudeSource)].GetValue<int>(); } set { this[nameof(AltitudeSource)].SetValue<int>((int)value); } }
        public Object AnchorName { get { return this[nameof(AnchorName)]; } set { this[nameof(AnchorName)] = value; } }
    }
    public class ARSharedWorldReplicationState : Object
    {
        public ARSharedWorldReplicationState(nint addr) : base(addr) { }
        public int PreviewImageOffset { get { return this[nameof(PreviewImageOffset)].GetValue<int>(); } set { this[nameof(PreviewImageOffset)].SetValue<int>(value); } }
        public int ARWorldOffset { get { return this[nameof(ARWorldOffset)].GetValue<int>(); } set { this[nameof(ARWorldOffset)].SetValue<int>(value); } }
    }
    public class ARTraceResult : Object
    {
        public ARTraceResult(nint addr) : base(addr) { }
        public float DistanceFromCamera { get { return this[nameof(DistanceFromCamera)].GetValue<float>(); } set { this[nameof(DistanceFromCamera)].SetValue<float>(value); } }
        public EARLineTraceChannels TraceChannel { get { return (EARLineTraceChannels)this[nameof(TraceChannel)].GetValue<int>(); } set { this[nameof(TraceChannel)].SetValue<int>((int)value); } }
        public Transform LocalTransform { get { return this[nameof(LocalTransform)].As<Transform>(); } set { this["LocalTransform"] = value; } }
        public ARTrackedGeometry TrackedGeometry { get { return this[nameof(TrackedGeometry)].As<ARTrackedGeometry>(); } set { this["TrackedGeometry"] = value; } }
    }
    public class ARSessionStatus : Object
    {
        public ARSessionStatus(nint addr) : base(addr) { }
        public Object AdditionalInfo { get { return this[nameof(AdditionalInfo)]; } set { this[nameof(AdditionalInfo)] = value; } }
        public EARSessionStatus Status { get { return (EARSessionStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
    }
    public class ARVideoFormat : Object
    {
        public ARVideoFormat(nint addr) : base(addr) { }
        public int fps { get { return this[nameof(fps)].GetValue<int>(); } set { this[nameof(fps)].SetValue<int>(value); } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
    }
    public class ARSkeletonDefinition : Object
    {
        public ARSkeletonDefinition(nint addr) : base(addr) { }
        public int NumJoints { get { return this[nameof(NumJoints)].GetValue<int>(); } set { this[nameof(NumJoints)].SetValue<int>(value); } }
        public Array<Object> JointNames { get { return new Array<Object>(this[nameof(JointNames)].Address); } }
        public Array<int> ParentIndices { get { return new Array<int>(this[nameof(ParentIndices)].Address); } }
    }
    public class ARPose2D : Object
    {
        public ARPose2D(nint addr) : base(addr) { }
        public ARSkeletonDefinition SkeletonDefinition { get { return this[nameof(SkeletonDefinition)].As<ARSkeletonDefinition>(); } set { this["SkeletonDefinition"] = value; } }
        public Array<Vector2D> JointLocations { get { return new Array<Vector2D>(this[nameof(JointLocations)].Address); } }
        public Array<bool> IsJointTracked { get { return new Array<bool>(this[nameof(IsJointTracked)].Address); } }
    }
    public class ARPose3D : Object
    {
        public ARPose3D(nint addr) : base(addr) { }
        public ARSkeletonDefinition SkeletonDefinition { get { return this[nameof(SkeletonDefinition)].As<ARSkeletonDefinition>(); } set { this["SkeletonDefinition"] = value; } }
        public Array<Transform> JointTransforms { get { return new Array<Transform>(this[nameof(JointTransforms)].Address); } }
        public Array<bool> IsJointTracked { get { return new Array<bool>(this[nameof(IsJointTracked)].Address); } }
        public EARJointTransformSpace JointTransformSpace { get { return (EARJointTransformSpace)this[nameof(JointTransformSpace)].GetValue<int>(); } set { this[nameof(JointTransformSpace)].SetValue<int>((int)value); } }
    }
    public class ARCameraIntrinsics : Object
    {
        public ARCameraIntrinsics(nint addr) : base(addr) { }
        public IntPoint ImageResolution { get { return this[nameof(ImageResolution)].As<IntPoint>(); } set { this["ImageResolution"] = value; } }
        public Vector2D FocalLength { get { return this[nameof(FocalLength)].As<Vector2D>(); } set { this["FocalLength"] = value; } }
        public Vector2D PrincipalPoint { get { return this[nameof(PrincipalPoint)].As<Vector2D>(); } set { this["PrincipalPoint"] = value; } }
    }
}
