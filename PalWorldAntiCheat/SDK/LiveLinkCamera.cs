using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.LiveLinkComponentsSDK;
using SDK.Script.CameraCalibrationCoreSDK;
namespace SDK.Script.LiveLinkCameraSDK
{
    public class LiveLinkCameraController : LiveLinkControllerBase
    {
        public LiveLinkCameraController(nint addr) : base(addr) { }
        public bool bUseCameraRange { get { return this[nameof(bUseCameraRange)].Flag; } set { this[nameof(bUseCameraRange)].Flag = value; } }
        public LensFilePicker LensFilePicker { get { return this[nameof(LensFilePicker)].As<LensFilePicker>(); } set { this["LensFilePicker"] = value; } }
        public LiveLinkCameraControllerUpdateFlags UpdateFlags { get { return this[nameof(UpdateFlags)].As<LiveLinkCameraControllerUpdateFlags>(); } set { this["UpdateFlags"] = value; } }
    }
    public class LiveLinkCameraControllerUpdateFlags : Object
    {
        public LiveLinkCameraControllerUpdateFlags(nint addr) : base(addr) { }
        public bool bApplyFieldOfView { get { return this[nameof(bApplyFieldOfView)].Flag; } set { this[nameof(bApplyFieldOfView)].Flag = value; } }
        public bool bApplyAspectRatio { get { return this[nameof(bApplyAspectRatio)].Flag; } set { this[nameof(bApplyAspectRatio)].Flag = value; } }
        public bool bApplyFocalLength { get { return this[nameof(bApplyFocalLength)].Flag; } set { this[nameof(bApplyFocalLength)].Flag = value; } }
        public bool bApplyProjectionMode { get { return this[nameof(bApplyProjectionMode)].Flag; } set { this[nameof(bApplyProjectionMode)].Flag = value; } }
        public bool bApplyFilmBack { get { return this[nameof(bApplyFilmBack)].Flag; } set { this[nameof(bApplyFilmBack)].Flag = value; } }
        public bool bApplyAperture { get { return this[nameof(bApplyAperture)].Flag; } set { this[nameof(bApplyAperture)].Flag = value; } }
        public bool bApplyFocusDistance { get { return this[nameof(bApplyFocusDistance)].Flag; } set { this[nameof(bApplyFocusDistance)].Flag = value; } }
    }
}
