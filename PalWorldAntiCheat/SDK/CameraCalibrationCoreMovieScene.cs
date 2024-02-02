using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.CameraCalibrationCoreSDK;
namespace SDK.Script.CameraCalibrationCoreMovieSceneSDK
{
    public class MovieSceneLensComponentSection : MovieSceneHookSection
    {
        public MovieSceneLensComponentSection(nint addr) : base(addr) { }
        public bool bReapplyNodalOffset { get { return this[nameof(bReapplyNodalOffset)].Flag; } set { this[nameof(bReapplyNodalOffset)].Flag = value; } }
        public LensFile OverrideLensFile { get { return this[nameof(OverrideLensFile)].As<LensFile>(); } set { this["OverrideLensFile"] = value; } }
        public LensFile CachedLensFile { get { return this[nameof(CachedLensFile)].As<LensFile>(); } set { this["CachedLensFile"] = value; } }
        public Array<MovieSceneFloatChannel> DistortionParameterChannels { get { return new Array<MovieSceneFloatChannel>(this[nameof(DistortionParameterChannels)].Address); } }
        public Array<MovieSceneFloatChannel> FxFyChannels { get { return new Array<MovieSceneFloatChannel>(this[nameof(FxFyChannels)].Address); } }
        public Array<MovieSceneFloatChannel> ImageCenterChannels { get { return new Array<MovieSceneFloatChannel>(this[nameof(ImageCenterChannels)].Address); } }
    }
    public class MovieSceneLensComponentTrack : MovieSceneNameableTrack
    {
        public MovieSceneLensComponentTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
}
