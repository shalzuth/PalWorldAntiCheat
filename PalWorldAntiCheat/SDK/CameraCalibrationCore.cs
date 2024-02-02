using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.ProceduralMeshComponentSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CinematicCameraSDK;
namespace SDK.Script.CameraCalibrationCoreSDK
{
    public class CalibrationPointComponent : ProceduralMeshComponent
    {
        public CalibrationPointComponent(nint addr) : base(addr) { }
        public Object SubPoints { get { return this[nameof(SubPoints)]; } set { this[nameof(SubPoints)] = value; } }
        public bool bVisualizePointsInEditor { get { return this[nameof(bVisualizePointsInEditor)].Flag; } set { this[nameof(bVisualizePointsInEditor)].Flag = value; } }
        public float PointVisualizationScale { get { return this[nameof(PointVisualizationScale)].GetValue<float>(); } set { this[nameof(PointVisualizationScale)].SetValue<float>(value); } }
        public byte VisualizationShape { get { return this[nameof(VisualizationShape)].GetValue<byte>(); } set { this[nameof(VisualizationShape)].SetValue<byte>(value); } }
        public void RebuildVertices() { Invoke(nameof(RebuildVertices)); }
        public bool NamespacedSubpointName(Object InSubpointName, Object OutNamespacedName) { return Invoke<bool>(nameof(NamespacedSubpointName), InSubpointName, OutNamespacedName); }
        public bool GetWorldLocation(Object InPointName, Vector OutLocation) { return Invoke<bool>(nameof(GetWorldLocation), InPointName, OutLocation); }
        public void GetNamespacedPointNames(Array<Object> OutNamespacedNames) { Invoke(nameof(GetNamespacedPointNames), OutNamespacedNames); }
    }
    public class CameraCalibrationCheckerboard : Actor
    {
        public CameraCalibrationCheckerboard(nint addr) : base(addr) { }
        public SceneComponent Root { get { return this[nameof(Root)].As<SceneComponent>(); } set { this["Root"] = value; } }
        public CalibrationPointComponent TopLeft { get { return this[nameof(TopLeft)].As<CalibrationPointComponent>(); } set { this["TopLeft"] = value; } }
        public CalibrationPointComponent TopRight { get { return this[nameof(TopRight)].As<CalibrationPointComponent>(); } set { this["TopRight"] = value; } }
        public CalibrationPointComponent BottomLeft { get { return this[nameof(BottomLeft)].As<CalibrationPointComponent>(); } set { this["BottomLeft"] = value; } }
        public CalibrationPointComponent BottomRight { get { return this[nameof(BottomRight)].As<CalibrationPointComponent>(); } set { this["BottomRight"] = value; } }
        public CalibrationPointComponent Center { get { return this[nameof(Center)].As<CalibrationPointComponent>(); } set { this["Center"] = value; } }
        public int NumCornerRows { get { return this[nameof(NumCornerRows)].GetValue<int>(); } set { this[nameof(NumCornerRows)].SetValue<int>(value); } }
        public int NumCornerCols { get { return this[nameof(NumCornerCols)].GetValue<int>(); } set { this[nameof(NumCornerCols)].SetValue<int>(value); } }
        public float SquareSideLength { get { return this[nameof(SquareSideLength)].GetValue<float>(); } set { this[nameof(SquareSideLength)].SetValue<float>(value); } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
        public StaticMesh CubeMesh { get { return this[nameof(CubeMesh)].As<StaticMesh>(); } set { this["CubeMesh"] = value; } }
        public MaterialInterface OddCubeMaterial { get { return this[nameof(OddCubeMaterial)].As<MaterialInterface>(); } set { this["OddCubeMaterial"] = value; } }
        public MaterialInterface EvenCubeMaterial { get { return this[nameof(EvenCubeMaterial)].As<MaterialInterface>(); } set { this["EvenCubeMaterial"] = value; } }
        public void Rebuild() { Invoke(nameof(Rebuild)); }
    }
    public class CameraCalibrationSettings : DeveloperSettings
    {
        public CameraCalibrationSettings(nint addr) : base(addr) { }
        public Object StartupLensFile { get { return this[nameof(StartupLensFile)]; } set { this[nameof(StartupLensFile)] = value; } }
        public IntPoint DisplacementMapResolution { get { return this[nameof(DisplacementMapResolution)].As<IntPoint>(); } set { this["DisplacementMapResolution"] = value; } }
        public float CalibrationInputTolerance { get { return this[nameof(CalibrationInputTolerance)].GetValue<float>(); } set { this[nameof(CalibrationInputTolerance)].SetValue<float>(value); } }
        public Object DefaultUndistortionDisplacementMaterials { get { return this[nameof(DefaultUndistortionDisplacementMaterials)]; } set { this[nameof(DefaultUndistortionDisplacementMaterials)] = value; } }
        public Object DefaultDistortionDisplacementMaterials { get { return this[nameof(DefaultDistortionDisplacementMaterials)]; } set { this[nameof(DefaultDistortionDisplacementMaterials)] = value; } }
        public Object DefaultDistortionMaterials { get { return this[nameof(DefaultDistortionMaterials)]; } set { this[nameof(DefaultDistortionMaterials)] = value; } }
        public bool bEnableCalibrationDatasetImportExport { get { return this[nameof(bEnableCalibrationDatasetImportExport)].Flag; } set { this[nameof(bEnableCalibrationDatasetImportExport)].Flag = value; } }
    }
    public class CameraCalibrationEditorSettings : DeveloperSettings
    {
        public CameraCalibrationEditorSettings(nint addr) : base(addr) { }
    }
    public class CameraCalibrationStep : Object
    {
        public CameraCalibrationStep(nint addr) : base(addr) { }
    }
    public class CameraCalibrationSubsystem : EngineSubsystem
    {
        public CameraCalibrationSubsystem(nint addr) : base(addr) { }
        public LensFile DefaultLensFile { get { return this[nameof(DefaultLensFile)].As<LensFile>(); } set { this["DefaultLensFile"] = value; } }
        public Object LensModelMap { get { return this[nameof(LensModelMap)]; } set { this[nameof(LensModelMap)] = value; } }
        public Object CameraNodalOffsetAlgosMap { get { return this[nameof(CameraNodalOffsetAlgosMap)]; } set { this[nameof(CameraNodalOffsetAlgosMap)] = value; } }
        public Object CameraImageCenterAlgosMap { get { return this[nameof(CameraImageCenterAlgosMap)]; } set { this[nameof(CameraImageCenterAlgosMap)] = value; } }
        public Object CameraCalibrationStepsMap { get { return this[nameof(CameraCalibrationStepsMap)]; } set { this[nameof(CameraCalibrationStepsMap)] = value; } }
        public void UnregisterDistortionModelHandler(CineCameraComponent Component, LensDistortionModelHandlerBase Handler) { Invoke(nameof(UnregisterDistortionModelHandler), Component, Handler); }
        public void SetDefaultLensFile(LensFile NewDefaultLensFile) { Invoke(nameof(SetDefaultLensFile), NewDefaultLensFile); }
        public Object GetRegisteredLensModel(Object ModelName) { return Invoke<Object>(nameof(GetRegisteredLensModel), ModelName); }
        public Array<Object> GetOverlayMaterialNames() { return Invoke<Array<Object>>(nameof(GetOverlayMaterialNames)); }
        public MaterialInterface GetOverlayMaterial(Object OverlayName) { return Invoke<MaterialInterface>(nameof(GetOverlayMaterial), OverlayName); }
        public LensFile GetLensFile(LensFilePicker Picker) { return Invoke<LensFile>(nameof(GetLensFile), Picker); }
        public Array<LensDistortionModelHandlerBase> GetDistortionModelHandlers(CineCameraComponent Component) { return Invoke<Array<LensDistortionModelHandlerBase>>(nameof(GetDistortionModelHandlers), Component); }
        public LensFile GetDefaultLensFile() { return Invoke<LensFile>(nameof(GetDefaultLensFile)); }
        public Array<Object> GetCameraNodalOffsetAlgos() { return Invoke<Array<Object>>(nameof(GetCameraNodalOffsetAlgos)); }
        public Object GetCameraNodalOffsetAlgo(Object Name) { return Invoke<Object>(nameof(GetCameraNodalOffsetAlgo), Name); }
        public Array<Object> GetCameraImageCenterAlgos() { return Invoke<Array<Object>>(nameof(GetCameraImageCenterAlgos)); }
        public Object GetCameraImageCenterAlgo(Object Name) { return Invoke<Object>(nameof(GetCameraImageCenterAlgo), Name); }
        public Array<Object> GetCameraCalibrationSteps() { return Invoke<Array<Object>>(nameof(GetCameraCalibrationSteps)); }
        public Object GetCameraCalibrationStep(Object Name) { return Invoke<Object>(nameof(GetCameraCalibrationStep), Name); }
        public LensDistortionModelHandlerBase FindOrCreateDistortionModelHandler(DistortionHandlerPicker DistortionHandlerPicker, Object LensModelClass) { return Invoke<LensDistortionModelHandlerBase>(nameof(FindOrCreateDistortionModelHandler), DistortionHandlerPicker, LensModelClass); }
        public LensDistortionModelHandlerBase FindDistortionModelHandler(DistortionHandlerPicker DistortionHandlerPicker, bool bUpdatePicker) { return Invoke<LensDistortionModelHandlerBase>(nameof(FindDistortionModelHandler), DistortionHandlerPicker, bUpdatePicker); }
    }
    public class CameraImageCenterAlgo : Object
    {
        public CameraImageCenterAlgo(nint addr) : base(addr) { }
    }
    public class CameraLensDistortionAlgo : Object
    {
        public CameraLensDistortionAlgo(nint addr) : base(addr) { }
    }
    public class CameraNodalOffsetAlgo : Object
    {
        public CameraNodalOffsetAlgo(nint addr) : base(addr) { }
    }
    public class LensComponent : ActorComponent
    {
        public LensComponent(nint addr) : base(addr) { }
        public LensFilePicker LensFilePicker { get { return this[nameof(LensFilePicker)].As<LensFilePicker>(); } set { this["LensFilePicker"] = value; } }
        public EFIZEvaluationMode EvaluationMode { get { return (EFIZEvaluationMode)this[nameof(EvaluationMode)].GetValue<int>(); } set { this[nameof(EvaluationMode)].SetValue<int>((int)value); } }
        public ComponentReference TargetCameraComponent { get { return this[nameof(TargetCameraComponent)].As<ComponentReference>(); } set { this["TargetCameraComponent"] = value; } }
        public LensFileEvaluationInputs EvalInputs { get { return this[nameof(EvalInputs)].As<LensFileEvaluationInputs>(); } set { this["EvalInputs"] = value; } }
        public EDistortionSource DistortionStateSource { get { return (EDistortionSource)this[nameof(DistortionStateSource)].GetValue<int>(); } set { this[nameof(DistortionStateSource)].SetValue<int>((int)value); } }
        public bool bApplyDistortion { get { return this[nameof(bApplyDistortion)].Flag; } set { this[nameof(bApplyDistortion)].Flag = value; } }
        public Object LensModel { get { return this[nameof(LensModel)]; } set { this[nameof(LensModel)] = value; } }
        public LensDistortionState DistortionState { get { return this[nameof(DistortionState)].As<LensDistortionState>(); } set { this["DistortionState"] = value; } }
        public bool bScaleOverscan { get { return this[nameof(bScaleOverscan)].Flag; } set { this[nameof(bScaleOverscan)].Flag = value; } }
        public float OverscanMultiplier { get { return this[nameof(OverscanMultiplier)].GetValue<float>(); } set { this[nameof(OverscanMultiplier)].SetValue<float>(value); } }
        public EFilmbackOverrideSource FilmbackOverride { get { return (EFilmbackOverrideSource)this[nameof(FilmbackOverride)].GetValue<int>(); } set { this[nameof(FilmbackOverride)].SetValue<int>((int)value); } }
        public CameraFilmbackSettings CroppedFilmback { get { return this[nameof(CroppedFilmback)].As<CameraFilmbackSettings>(); } set { this["CroppedFilmback"] = value; } }
        public bool bApplyNodalOffsetOnTick { get { return this[nameof(bApplyNodalOffsetOnTick)].Flag; } set { this[nameof(bApplyNodalOffsetOnTick)].Flag = value; } }
        public Transform OriginalTrackedComponentTransform { get { return this[nameof(OriginalTrackedComponentTransform)].As<Transform>(); } set { this["OriginalTrackedComponentTransform"] = value; } }
        public bool bIsDistortionSetup { get { return this[nameof(bIsDistortionSetup)].Flag; } set { this[nameof(bIsDistortionSetup)].Flag = value; } }
        public float OriginalFocalLength { get { return this[nameof(OriginalFocalLength)].GetValue<float>(); } set { this[nameof(OriginalFocalLength)].SetValue<float>(value); } }
        public MaterialInstanceDynamic LastDistortionMID { get { return this[nameof(LastDistortionMID)].As<MaterialInstanceDynamic>(); } set { this["LastDistortionMID"] = value; } }
        public CineCameraComponent LastCameraComponent { get { return this[nameof(LastCameraComponent)].As<CineCameraComponent>(); } set { this["LastCameraComponent"] = value; } }
        public Object LensDistortionHandlerMap { get { return this[nameof(LensDistortionHandlerMap)]; } set { this[nameof(LensDistortionHandlerMap)] = value; } }
        public Object TrackedComponent { get { return this[nameof(TrackedComponent)]; } set { this[nameof(TrackedComponent)] = value; } }
        public Object TrackedComponentName { get { return this[nameof(TrackedComponentName)]; } set { this[nameof(TrackedComponentName)] = value; } }
        public bool WasNodalOffsetAppliedThisTick() { return Invoke<bool>(nameof(WasNodalOffsetAppliedThisTick)); }
        public bool WasDistortionEvaluated() { return Invoke<bool>(nameof(WasDistortionEvaluated)); }
        public bool ShouldApplyNodalOffsetOnTick() { return Invoke<bool>(nameof(ShouldApplyNodalOffsetOnTick)); }
        public bool ShouldApplyDistortion() { return Invoke<bool>(nameof(ShouldApplyDistortion)); }
        public void SetOverscanMultiplier(float Multiplier) { Invoke(nameof(SetOverscanMultiplier), Multiplier); }
        public void SetLensModel(Object Model) { Invoke(nameof(SetLensModel), Model); }
        public void SetLensFilePicker(LensFilePicker LensFile) { Invoke(nameof(SetLensFilePicker), LensFile); }
        public void SetLensFile(LensFile LensFile) { Invoke(nameof(SetLensFile), LensFile); }
        public void SetFIZEvaluationMode(EFIZEvaluationMode Mode) { Invoke(nameof(SetFIZEvaluationMode), Mode); }
        public void SetFilmbackOverrideSetting(EFilmbackOverrideSource Setting) { Invoke(nameof(SetFilmbackOverrideSetting), Setting); }
        public void SetDistortionState(LensDistortionState State) { Invoke(nameof(SetDistortionState), State); }
        public void SetDistortionSource(EDistortionSource Source) { Invoke(nameof(SetDistortionSource), Source); }
        public void SetCroppedFilmback(CameraFilmbackSettings Filmback) { Invoke(nameof(SetCroppedFilmback), Filmback); }
        public void SetApplyNodalOffsetOnTick(bool bApplyNodalOffset) { Invoke(nameof(SetApplyNodalOffsetOnTick), bApplyNodalOffset); }
        public void SetApplyDistortion(bool bApply) { Invoke(nameof(SetApplyDistortion), bApply); }
        public float GetOverscanMultiplier() { return Invoke<float>(nameof(GetOverscanMultiplier)); }
        public float GetOriginalFocalLength() { return Invoke<float>(nameof(GetOriginalFocalLength)); }
        public Object GetLensModel() { return Invoke<Object>(nameof(GetLensModel)); }
        public LensFilePicker GetLensFilePicker() { return Invoke<LensFilePicker>(nameof(GetLensFilePicker)); }
        public LensFileEvaluationInputs GetLensFileEvaluationInputs() { return Invoke<LensFileEvaluationInputs>(nameof(GetLensFileEvaluationInputs)); }
        public LensFile GetLensFile() { return Invoke<LensFile>(nameof(GetLensFile)); }
        public EFIZEvaluationMode GetFIZEvaluationMode() { return Invoke<EFIZEvaluationMode>(nameof(GetFIZEvaluationMode)); }
        public EFilmbackOverrideSource GetFilmbackOverrideSetting() { return Invoke<EFilmbackOverrideSource>(nameof(GetFilmbackOverrideSetting)); }
        public LensDistortionState GetDistortionState() { return Invoke<LensDistortionState>(nameof(GetDistortionState)); }
        public EDistortionSource GetDistortionSource() { return Invoke<EDistortionSource>(nameof(GetDistortionSource)); }
        public CameraFilmbackSettings GetCroppedFilmback() { return Invoke<CameraFilmbackSettings>(nameof(GetCroppedFilmback)); }
        public void ClearDistortionState() { Invoke(nameof(ClearDistortionState)); }
        public void ApplyNodalOffset(SceneComponent ComponentToOffset, bool bUseManualInputs, float ManualFocusInput, float ManualZoomInput) { Invoke(nameof(ApplyNodalOffset), ComponentToOffset, bUseManualInputs, ManualFocusInput, ManualZoomInput); }
    }
    public class LensDistortionModelHandlerBase : Object
    {
        public LensDistortionModelHandlerBase(nint addr) : base(addr) { }
        public Object LensModelClass { get { return this[nameof(LensModelClass)]; } set { this[nameof(LensModelClass)] = value; } }
        public MaterialInstanceDynamic DistortionPostProcessMID { get { return this[nameof(DistortionPostProcessMID)].As<MaterialInstanceDynamic>(); } set { this["DistortionPostProcessMID"] = value; } }
        public LensDistortionState CurrentState { get { return this[nameof(CurrentState)].As<LensDistortionState>(); } set { this["CurrentState"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public float OverscanFactor { get { return this[nameof(OverscanFactor)].GetValue<float>(); } set { this[nameof(OverscanFactor)].SetValue<float>(value); } }
        public MaterialInstanceDynamic UndistortionDisplacementMapMID { get { return this[nameof(UndistortionDisplacementMapMID)].As<MaterialInstanceDynamic>(); } set { this["UndistortionDisplacementMapMID"] = value; } }
        public MaterialInstanceDynamic DistortionDisplacementMapMID { get { return this[nameof(DistortionDisplacementMapMID)].As<MaterialInstanceDynamic>(); } set { this["DistortionDisplacementMapMID"] = value; } }
        public TextureRenderTarget2D UndistortionDisplacementMapRT { get { return this[nameof(UndistortionDisplacementMapRT)].As<TextureRenderTarget2D>(); } set { this["UndistortionDisplacementMapRT"] = value; } }
        public TextureRenderTarget2D DistortionDisplacementMapRT { get { return this[nameof(DistortionDisplacementMapRT)].As<TextureRenderTarget2D>(); } set { this["DistortionDisplacementMapRT"] = value; } }
        public Guid DistortionProducerID { get { return this[nameof(DistortionProducerID)].As<Guid>(); } set { this["DistortionProducerID"] = value; } }
        public void SetDistortionState(LensDistortionState InNewState) { Invoke(nameof(SetDistortionState), InNewState); }
        public bool IsModelSupported(Object ModelToSupport) { return Invoke<bool>(nameof(IsModelSupported), ModelToSupport); }
        public TextureRenderTarget2D GetUndistortionDisplacementMap() { return Invoke<TextureRenderTarget2D>(nameof(GetUndistortionDisplacementMap)); }
        public TextureRenderTarget2D GetDistortionDisplacementMap() { return Invoke<TextureRenderTarget2D>(nameof(GetDistortionDisplacementMap)); }
    }
    public class LensFile : Object
    {
        public LensFile(nint addr) : base(addr) { }
        public LensInfo LensInfo { get { return this[nameof(LensInfo)].As<LensInfo>(); } set { this["LensInfo"] = value; } }
        public ELensDataMode DataMode { get { return (ELensDataMode)this[nameof(DataMode)].GetValue<int>(); } set { this[nameof(DataMode)].SetValue<int>((int)value); } }
        public Object UserMetadata { get { return this[nameof(UserMetadata)]; } set { this[nameof(UserMetadata)] = value; } }
        public EncodersTable EncodersTable { get { return this[nameof(EncodersTable)].As<EncodersTable>(); } set { this["EncodersTable"] = value; } }
        public DistortionTable DistortionTable { get { return this[nameof(DistortionTable)].As<DistortionTable>(); } set { this["DistortionTable"] = value; } }
        public FocalLengthTable FocalLengthTable { get { return this[nameof(FocalLengthTable)].As<FocalLengthTable>(); } set { this["FocalLengthTable"] = value; } }
        public ImageCenterTable ImageCenterTable { get { return this[nameof(ImageCenterTable)].As<ImageCenterTable>(); } set { this["ImageCenterTable"] = value; } }
        public NodalOffsetTable NodalOffsetTable { get { return this[nameof(NodalOffsetTable)].As<NodalOffsetTable>(); } set { this["NodalOffsetTable"] = value; } }
        public STMapTable STMapTable { get { return this[nameof(STMapTable)].As<STMapTable>(); } set { this["STMapTable"] = value; } }
        public Array<TextureRenderTarget2D> UndistortionDisplacementMapHolders { get { return new Array<TextureRenderTarget2D>(this[nameof(UndistortionDisplacementMapHolders)].Address); } }
        public Array<TextureRenderTarget2D> DistortionDisplacementMapHolders { get { return new Array<TextureRenderTarget2D>(this[nameof(DistortionDisplacementMapHolders)].Address); } }
        public void RemoveZoomPoint(ELensDataCategory InDataCategory, float InFocus, float InZoom) { Invoke(nameof(RemoveZoomPoint), InDataCategory, InFocus, InZoom); }
        public void RemoveFocusPoint(ELensDataCategory InDataCategory, float InFocus) { Invoke(nameof(RemoveFocusPoint), InDataCategory, InFocus); }
        public bool HasSamples(ELensDataCategory InDataCategory) { return Invoke<bool>(nameof(HasSamples), InDataCategory); }
        public bool HasIrisEncoderMapping() { return Invoke<bool>(nameof(HasIrisEncoderMapping)); }
        public bool HasFocusEncoderMapping() { return Invoke<bool>(nameof(HasFocusEncoderMapping)); }
        public int GetTotalPointNum(ELensDataCategory InDataCategory) { return Invoke<int>(nameof(GetTotalPointNum), InDataCategory); }
        public Array<STMapPointInfo> GetSTMapPoints() { return Invoke<Array<STMapPointInfo>>(nameof(GetSTMapPoints)); }
        public bool GetSTMapPoint(float InFocus, float InZoom, STMapInfo OutSTMapInfo) { return Invoke<bool>(nameof(GetSTMapPoint), InFocus, InZoom, OutSTMapInfo); }
        public Array<NodalOffsetPointInfo> GetNodalOffsetPoints() { return Invoke<Array<NodalOffsetPointInfo>>(nameof(GetNodalOffsetPoints)); }
        public bool GetNodalOffsetPoint(float InFocus, float InZoom, NodalPointOffset OutNodalPointOffset) { return Invoke<bool>(nameof(GetNodalOffsetPoint), InFocus, InZoom, OutNodalPointOffset); }
        public Array<ImageCenterPointInfo> GetImageCenterPoints() { return Invoke<Array<ImageCenterPointInfo>>(nameof(GetImageCenterPoints)); }
        public bool GetImageCenterPoint(float InFocus, float InZoom, ImageCenterInfo OutImageCenterInfo) { return Invoke<bool>(nameof(GetImageCenterPoint), InFocus, InZoom, OutImageCenterInfo); }
        public Array<FocalLengthPointInfo> GetFocalLengthPoints() { return Invoke<Array<FocalLengthPointInfo>>(nameof(GetFocalLengthPoints)); }
        public bool GetFocalLengthPoint(float InFocus, float InZoom, FocalLengthInfo OutFocalLengthInfo) { return Invoke<bool>(nameof(GetFocalLengthPoint), InFocus, InZoom, OutFocalLengthInfo); }
        public Array<DistortionPointInfo> GetDistortionPoints() { return Invoke<Array<DistortionPointInfo>>(nameof(GetDistortionPoints)); }
        public bool GetDistortionPoint(float InFocus, float InZoom, DistortionInfo OutDistortionInfo) { return Invoke<bool>(nameof(GetDistortionPoint), InFocus, InZoom, OutDistortionInfo); }
        public float EvaluateNormalizedIris(float InNormalizedValue) { return Invoke<float>(nameof(EvaluateNormalizedIris), InNormalizedValue); }
        public float EvaluateNormalizedFocus(float InNormalizedValue) { return Invoke<float>(nameof(EvaluateNormalizedFocus), InNormalizedValue); }
        public bool EvaluateNodalPointOffset(float InFocus, float InZoom, NodalPointOffset OutEvaluatedValue) { return Invoke<bool>(nameof(EvaluateNodalPointOffset), InFocus, InZoom, OutEvaluatedValue); }
        public bool EvaluateImageCenterParameters(float InFocus, float InZoom, ImageCenterInfo OutEvaluatedValue) { return Invoke<bool>(nameof(EvaluateImageCenterParameters), InFocus, InZoom, OutEvaluatedValue); }
        public bool EvaluateFocalLength(float InFocus, float InZoom, FocalLengthInfo OutEvaluatedValue) { return Invoke<bool>(nameof(EvaluateFocalLength), InFocus, InZoom, OutEvaluatedValue); }
        public bool EvaluateDistortionParameters(float InFocus, float InZoom, DistortionInfo OutEvaluatedValue) { return Invoke<bool>(nameof(EvaluateDistortionParameters), InFocus, InZoom, OutEvaluatedValue); }
        public bool EvaluateDistortionData(float InFocus, float InZoom, Vector2D InFilmback, LensDistortionModelHandlerBase InLensHandler) { return Invoke<bool>(nameof(EvaluateDistortionData), InFocus, InZoom, InFilmback, InLensHandler); }
        public void ClearData(ELensDataCategory InDataCategory) { Invoke(nameof(ClearData), InDataCategory); }
        public void ClearAll() { Invoke(nameof(ClearAll)); }
        public void AddSTMapPoint(float NewFocus, float NewZoom, STMapInfo newPoint) { Invoke(nameof(AddSTMapPoint), NewFocus, NewZoom, newPoint); }
        public void AddNodalOffsetPoint(float NewFocus, float NewZoom, NodalPointOffset newPoint) { Invoke(nameof(AddNodalOffsetPoint), NewFocus, NewZoom, newPoint); }
        public void AddImageCenterPoint(float NewFocus, float NewZoom, ImageCenterInfo newPoint) { Invoke(nameof(AddImageCenterPoint), NewFocus, NewZoom, newPoint); }
        public void AddFocalLengthPoint(float NewFocus, float NewZoom, FocalLengthInfo NewFocalLength) { Invoke(nameof(AddFocalLengthPoint), NewFocus, NewZoom, NewFocalLength); }
        public void AddDistortionPoint(float NewFocus, float NewZoom, DistortionInfo newPoint, FocalLengthInfo NewFocalLength) { Invoke(nameof(AddDistortionPoint), NewFocus, NewZoom, newPoint, NewFocalLength); }
    }
    public class LensModel : Object
    {
        public LensModel(nint addr) : base(addr) { }
    }
    public class SphericalLensDistortionModelHandler : LensDistortionModelHandlerBase
    {
        public SphericalLensDistortionModelHandler(nint addr) : base(addr) { }
    }
    public class SphericalLensModel : LensModel
    {
        public SphericalLensModel(nint addr) : base(addr) { }
    }
    public enum ECalibratedMapPixelOrigin : int
    {
        TopLeft = 0,
        BottomLeft = 1,
        MAX = 2,
    }
    public enum ECalibratedMapChannels : int
    {
        RG = 0,
        BA = 1,
        None = 2,
        MAX = 3,
    }
    public enum ECalibrationPointVisualization : int
    {
        CalibrationPointVisualizationCube = 0,
        CalibrationPointVisualizationPyramid = 1,
        ECalibrationPointVisualization_MAX = 2,
    }
    public enum ELensDisplayUnit : int
    {
        Millimeters = 0,
        Pixels = 1,
        Normalized = 2,
        ELensDisplayUnit_MAX = 3,
    }
    public enum EFIZEvaluationMode : int
    {
        UseLiveLink = 0,
        UseCameraSettings = 1,
        UseRecordedValues = 2,
        DoNotEvaluate = 3,
        EFIZEvaluationMode_MAX = 4,
    }
    public enum EFilmbackOverrideSource : int
    {
        LensFile = 0,
        CroppedFilmbackSetting = 1,
        DoNotOverride = 2,
        EFilmbackOverrideSource_MAX = 3,
    }
    public enum EDistortionSource : int
    {
        LensFile = 0,
        LiveLinkLensSubject = 1,
        Manual = 2,
        EDistortionSource_MAX = 3,
    }
    public enum ELensDataMode : int
    {
        Parameters = 0,
        STMap = 1,
        ELensDataMode_MAX = 2,
    }
    public enum ELensDataCategory : int
    {
        Focus = 0,
        Iris = 1,
        Zoom = 2,
        Distortion = 3,
        ImageCenter = 4,
        STMap = 5,
        NodalOffset = 6,
        ELensDataCategory_MAX = 7,
    }
    public class BaseFocusPoint : Object
    {
        public BaseFocusPoint(nint addr) : base(addr) { }
    }
    public class BaseLensTable : Object
    {
        public BaseLensTable(nint addr) : base(addr) { }
        public Object LensFile { get { return this[nameof(LensFile)]; } set { this[nameof(LensFile)] = value; } }
    }
    public class CalibratedMapFormat : Object
    {
        public CalibratedMapFormat(nint addr) : base(addr) { }
        public ECalibratedMapPixelOrigin PixelOrigin { get { return (ECalibratedMapPixelOrigin)this[nameof(PixelOrigin)].GetValue<int>(); } set { this[nameof(PixelOrigin)].SetValue<int>((int)value); } }
        public ECalibratedMapChannels UndistortionChannels { get { return (ECalibratedMapChannels)this[nameof(UndistortionChannels)].GetValue<int>(); } set { this[nameof(UndistortionChannels)].SetValue<int>((int)value); } }
        public ECalibratedMapChannels DistortionChannels { get { return (ECalibratedMapChannels)this[nameof(DistortionChannels)].GetValue<int>(); } set { this[nameof(DistortionChannels)].SetValue<int>((int)value); } }
    }
    public class LensDataCategoryEditorColor : Object
    {
        public LensDataCategoryEditorColor(nint addr) : base(addr) { }
        public Color Focus { get { return this[nameof(Focus)].As<Color>(); } set { this["Focus"] = value; } }
        public Color Iris { get { return this[nameof(Iris)].As<Color>(); } set { this["Iris"] = value; } }
        public Color Zoom { get { return this[nameof(Zoom)].As<Color>(); } set { this["Zoom"] = value; } }
        public Color Distortion { get { return this[nameof(Distortion)].As<Color>(); } set { this["Distortion"] = value; } }
        public Color ImageCenter { get { return this[nameof(ImageCenter)].As<Color>(); } set { this["ImageCenter"] = value; } }
        public Color STMap { get { return this[nameof(STMap)].As<Color>(); } set { this["STMap"] = value; } }
        public Color NodalOffset { get { return this[nameof(NodalOffset)].As<Color>(); } set { this["NodalOffset"] = value; } }
    }
    public class DistortionHandlerPicker : Object
    {
        public DistortionHandlerPicker(nint addr) : base(addr) { }
        public CineCameraComponent TargetCameraComponent { get { return this[nameof(TargetCameraComponent)].As<CineCameraComponent>(); } set { this["TargetCameraComponent"] = value; } }
        public Guid DistortionProducerID { get { return this[nameof(DistortionProducerID)].As<Guid>(); } set { this["DistortionProducerID"] = value; } }
        public Object HandlerDisplayName { get { return this[nameof(HandlerDisplayName)]; } set { this[nameof(HandlerDisplayName)] = value; } }
    }
    public class DistortionZoomPoint : Object
    {
        public DistortionZoomPoint(nint addr) : base(addr) { }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public DistortionInfo DistortionInfo { get { return this[nameof(DistortionInfo)].As<DistortionInfo>(); } set { this["DistortionInfo"] = value; } }
    }
    public class DistortionInfo : Object
    {
        public DistortionInfo(nint addr) : base(addr) { }
        public Array<float> Parameters { get { return new Array<float>(this[nameof(Parameters)].Address); } }
    }
    public class DistortionFocusPoint : BaseFocusPoint
    {
        public DistortionFocusPoint(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public RichCurve MapBlendingCurve { get { return this[nameof(MapBlendingCurve)].As<RichCurve>(); } set { this["MapBlendingCurve"] = value; } }
        public Array<DistortionZoomPoint> ZoomPoints { get { return new Array<DistortionZoomPoint>(this[nameof(ZoomPoints)].Address); } }
    }
    public class DistortionTable : BaseLensTable
    {
        public DistortionTable(nint addr) : base(addr) { }
        public Array<DistortionFocusPoint> FocusPoints { get { return new Array<DistortionFocusPoint>(this[nameof(FocusPoints)].Address); } }
    }
    public class EncodersTable : Object
    {
        public EncodersTable(nint addr) : base(addr) { }
        public RichCurve Focus { get { return this[nameof(Focus)].As<RichCurve>(); } set { this["Focus"] = value; } }
        public RichCurve Iris { get { return this[nameof(Iris)].As<RichCurve>(); } set { this["Iris"] = value; } }
    }
    public class FocalLengthZoomPoint : Object
    {
        public FocalLengthZoomPoint(nint addr) : base(addr) { }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public FocalLengthInfo FocalLengthInfo { get { return this[nameof(FocalLengthInfo)].As<FocalLengthInfo>(); } set { this["FocalLengthInfo"] = value; } }
        public bool bIsCalibrationPoint { get { return this[nameof(bIsCalibrationPoint)].Flag; } set { this[nameof(bIsCalibrationPoint)].Flag = value; } }
    }
    public class FocalLengthInfo : Object
    {
        public FocalLengthInfo(nint addr) : base(addr) { }
        public Vector2D FxFy { get { return this[nameof(FxFy)].As<Vector2D>(); } set { this["FxFy"] = value; } }
    }
    public class FocalLengthFocusPoint : BaseFocusPoint
    {
        public FocalLengthFocusPoint(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public RichCurve Fx { get { return this[nameof(Fx)].As<RichCurve>(); } set { this["Fx"] = value; } }
        public RichCurve Fy { get { return this[nameof(Fy)].As<RichCurve>(); } set { this["Fy"] = value; } }
        public Array<FocalLengthZoomPoint> ZoomPoints { get { return new Array<FocalLengthZoomPoint>(this[nameof(ZoomPoints)].Address); } }
    }
    public class FocalLengthTable : BaseLensTable
    {
        public FocalLengthTable(nint addr) : base(addr) { }
        public Array<FocalLengthFocusPoint> FocusPoints { get { return new Array<FocalLengthFocusPoint>(this[nameof(FocusPoints)].Address); } }
    }
    public class ImageCenterFocusPoint : BaseFocusPoint
    {
        public ImageCenterFocusPoint(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public RichCurve Cx { get { return this[nameof(Cx)].As<RichCurve>(); } set { this["Cx"] = value; } }
        public RichCurve Cy { get { return this[nameof(Cy)].As<RichCurve>(); } set { this["Cy"] = value; } }
    }
    public class ImageCenterTable : BaseLensTable
    {
        public ImageCenterTable(nint addr) : base(addr) { }
        public Array<ImageCenterFocusPoint> FocusPoints { get { return new Array<ImageCenterFocusPoint>(this[nameof(FocusPoints)].Address); } }
    }
    public class LensInfo : Object
    {
        public LensInfo(nint addr) : base(addr) { }
        public Object LensModelName { get { return this[nameof(LensModelName)]; } set { this[nameof(LensModelName)] = value; } }
        public Object LensSerialNumber { get { return this[nameof(LensSerialNumber)]; } set { this[nameof(LensSerialNumber)] = value; } }
        public Object LensModel { get { return this[nameof(LensModel)]; } set { this[nameof(LensModel)] = value; } }
        public Vector2D SensorDimensions { get { return this[nameof(SensorDimensions)].As<Vector2D>(); } set { this["SensorDimensions"] = value; } }
        public IntPoint ImageDimensions { get { return this[nameof(ImageDimensions)].As<IntPoint>(); } set { this["ImageDimensions"] = value; } }
    }
    public class STMapInfo : Object
    {
        public STMapInfo(nint addr) : base(addr) { }
        public Texture DistortionMap { get { return this[nameof(DistortionMap)].As<Texture>(); } set { this["DistortionMap"] = value; } }
        public CalibratedMapFormat MapFormat { get { return this[nameof(MapFormat)].As<CalibratedMapFormat>(); } set { this["MapFormat"] = value; } }
    }
    public class ImageCenterInfo : Object
    {
        public ImageCenterInfo(nint addr) : base(addr) { }
        public Vector2D PrincipalPoint { get { return this[nameof(PrincipalPoint)].As<Vector2D>(); } set { this["PrincipalPoint"] = value; } }
    }
    public class NodalPointOffset : Object
    {
        public NodalPointOffset(nint addr) : base(addr) { }
        public Vector LocationOffset { get { return this[nameof(LocationOffset)].As<Vector>(); } set { this["LocationOffset"] = value; } }
        public Quat RotationOffset { get { return this[nameof(RotationOffset)].As<Quat>(); } set { this["RotationOffset"] = value; } }
    }
    public class DistortionData : Object
    {
        public DistortionData(nint addr) : base(addr) { }
        public Array<Vector2D> DistortedUVs { get { return new Array<Vector2D>(this[nameof(DistortedUVs)].Address); } }
        public float OverscanFactor { get { return this[nameof(OverscanFactor)].GetValue<float>(); } set { this[nameof(OverscanFactor)].SetValue<float>(value); } }
    }
    public class DataTablePointInfoBase : Object
    {
        public DataTablePointInfoBase(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
    }
    public class DistortionPointInfo : DataTablePointInfoBase
    {
        public DistortionPointInfo(nint addr) : base(addr) { }
        public DistortionInfo DistortionInfo { get { return this[nameof(DistortionInfo)].As<DistortionInfo>(); } set { this["DistortionInfo"] = value; } }
    }
    public class FocalLengthPointInfo : DataTablePointInfoBase
    {
        public FocalLengthPointInfo(nint addr) : base(addr) { }
        public FocalLengthInfo FocalLengthInfo { get { return this[nameof(FocalLengthInfo)].As<FocalLengthInfo>(); } set { this["FocalLengthInfo"] = value; } }
    }
    public class STMapPointInfo : DataTablePointInfoBase
    {
        public STMapPointInfo(nint addr) : base(addr) { }
        public STMapInfo STMapInfo { get { return this[nameof(STMapInfo)].As<STMapInfo>(); } set { this["STMapInfo"] = value; } }
    }
    public class ImageCenterPointInfo : DataTablePointInfoBase
    {
        public ImageCenterPointInfo(nint addr) : base(addr) { }
        public ImageCenterInfo ImageCenterInfo { get { return this[nameof(ImageCenterInfo)].As<ImageCenterInfo>(); } set { this["ImageCenterInfo"] = value; } }
    }
    public class NodalOffsetPointInfo : DataTablePointInfoBase
    {
        public NodalOffsetPointInfo(nint addr) : base(addr) { }
        public NodalPointOffset NodalPointOffset { get { return this[nameof(NodalPointOffset)].As<NodalPointOffset>(); } set { this["NodalPointOffset"] = value; } }
    }
    public class LensDistortionState : Object
    {
        public LensDistortionState(nint addr) : base(addr) { }
        public DistortionInfo DistortionInfo { get { return this[nameof(DistortionInfo)].As<DistortionInfo>(); } set { this["DistortionInfo"] = value; } }
        public FocalLengthInfo FocalLengthInfo { get { return this[nameof(FocalLengthInfo)].As<FocalLengthInfo>(); } set { this["FocalLengthInfo"] = value; } }
        public ImageCenterInfo ImageCenter { get { return this[nameof(ImageCenter)].As<ImageCenterInfo>(); } set { this["ImageCenter"] = value; } }
    }
    public class LensFilePicker : Object
    {
        public LensFilePicker(nint addr) : base(addr) { }
        public bool bUseDefaultLensFile { get { return this[nameof(bUseDefaultLensFile)].Flag; } set { this[nameof(bUseDefaultLensFile)].Flag = value; } }
        public LensFile LensFile { get { return this[nameof(LensFile)].As<LensFile>(); } set { this["LensFile"] = value; } }
    }
    public class LensFileEvaluationInputs : Object
    {
        public LensFileEvaluationInputs(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public float Iris { get { return this[nameof(Iris)].GetValue<float>(); } set { this[nameof(Iris)].SetValue<float>(value); } }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public CameraFilmbackSettings Filmback { get { return this[nameof(Filmback)].As<CameraFilmbackSettings>(); } set { this["Filmback"] = value; } }
        public bool bIsValid { get { return this[nameof(bIsValid)].Flag; } set { this[nameof(bIsValid)].Flag = value; } }
    }
    public class NodalOffsetFocusPoint : BaseFocusPoint
    {
        public NodalOffsetFocusPoint(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public RichCurve LocationOffset { get { return this[nameof(LocationOffset)].As<RichCurve>(); } set { this["LocationOffset"] = value; } }
        public RichCurve RotationOffset { get { return this[nameof(RotationOffset)].As<RichCurve>(); } set { this["RotationOffset"] = value; } }
    }
    public class NodalOffsetTable : BaseLensTable
    {
        public NodalOffsetTable(nint addr) : base(addr) { }
        public Array<NodalOffsetFocusPoint> FocusPoints { get { return new Array<NodalOffsetFocusPoint>(this[nameof(FocusPoints)].Address); } }
    }
    public class SphericalDistortionParameters : Object
    {
        public SphericalDistortionParameters(nint addr) : base(addr) { }
        public float K1 { get { return this[nameof(K1)].GetValue<float>(); } set { this[nameof(K1)].SetValue<float>(value); } }
        public float K2 { get { return this[nameof(K2)].GetValue<float>(); } set { this[nameof(K2)].SetValue<float>(value); } }
        public float K3 { get { return this[nameof(K3)].GetValue<float>(); } set { this[nameof(K3)].SetValue<float>(value); } }
        public float P1 { get { return this[nameof(P1)].GetValue<float>(); } set { this[nameof(P1)].SetValue<float>(value); } }
        public float P2 { get { return this[nameof(P2)].GetValue<float>(); } set { this[nameof(P2)].SetValue<float>(value); } }
    }
    public class DerivedDistortionData : Object
    {
        public DerivedDistortionData(nint addr) : base(addr) { }
        public DistortionData DistortionData { get { return this[nameof(DistortionData)].As<DistortionData>(); } set { this["DistortionData"] = value; } }
        public TextureRenderTarget2D UndistortionDisplacementMap { get { return this[nameof(UndistortionDisplacementMap)].As<TextureRenderTarget2D>(); } set { this["UndistortionDisplacementMap"] = value; } }
        public TextureRenderTarget2D DistortionDisplacementMap { get { return this[nameof(DistortionDisplacementMap)].As<TextureRenderTarget2D>(); } set { this["DistortionDisplacementMap"] = value; } }
    }
    public class STMapZoomPoint : Object
    {
        public STMapZoomPoint(nint addr) : base(addr) { }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public STMapInfo STMapInfo { get { return this[nameof(STMapInfo)].As<STMapInfo>(); } set { this["STMapInfo"] = value; } }
        public DerivedDistortionData DerivedDistortionData { get { return this[nameof(DerivedDistortionData)].As<DerivedDistortionData>(); } set { this["DerivedDistortionData"] = value; } }
        public bool bIsCalibrationPoint { get { return this[nameof(bIsCalibrationPoint)].Flag; } set { this[nameof(bIsCalibrationPoint)].Flag = value; } }
    }
    public class STMapFocusPoint : BaseFocusPoint
    {
        public STMapFocusPoint(nint addr) : base(addr) { }
        public float Focus { get { return this[nameof(Focus)].GetValue<float>(); } set { this[nameof(Focus)].SetValue<float>(value); } }
        public RichCurve MapBlendingCurve { get { return this[nameof(MapBlendingCurve)].As<RichCurve>(); } set { this["MapBlendingCurve"] = value; } }
        public Array<STMapZoomPoint> ZoomPoints { get { return new Array<STMapZoomPoint>(this[nameof(ZoomPoints)].Address); } }
    }
    public class STMapTable : BaseLensTable
    {
        public STMapTable(nint addr) : base(addr) { }
        public Array<STMapFocusPoint> FocusPoints { get { return new Array<STMapFocusPoint>(this[nameof(FocusPoints)].Address); } }
    }
}
