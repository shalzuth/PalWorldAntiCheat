using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.MovieSceneTracksSDK;
namespace SDK.Script.TakeMovieSceneSDK
{
    public class MovieSceneTakeSection : MovieSceneSection
    {
        public MovieSceneTakeSection(nint addr) : base(addr) { }
        public MovieSceneIntegerChannel HoursCurve { get { return this[nameof(HoursCurve)].As<MovieSceneIntegerChannel>(); } set { this["HoursCurve"] = value; } }
        public MovieSceneIntegerChannel MinutesCurve { get { return this[nameof(MinutesCurve)].As<MovieSceneIntegerChannel>(); } set { this["MinutesCurve"] = value; } }
        public MovieSceneIntegerChannel SecondsCurve { get { return this[nameof(SecondsCurve)].As<MovieSceneIntegerChannel>(); } set { this["SecondsCurve"] = value; } }
        public MovieSceneIntegerChannel FramesCurve { get { return this[nameof(FramesCurve)].As<MovieSceneIntegerChannel>(); } set { this["FramesCurve"] = value; } }
        public MovieSceneFloatChannel SubFramesCurve { get { return this[nameof(SubFramesCurve)].As<MovieSceneFloatChannel>(); } set { this["SubFramesCurve"] = value; } }
        public MovieSceneStringChannel Slate { get { return this[nameof(Slate)].As<MovieSceneStringChannel>(); } set { this["Slate"] = value; } }
    }
    public class MovieSceneTakeSettings : Object
    {
        public MovieSceneTakeSettings(nint addr) : base(addr) { }
        public Object HoursName { get { return this[nameof(HoursName)]; } set { this[nameof(HoursName)] = value; } }
        public Object MinutesName { get { return this[nameof(MinutesName)]; } set { this[nameof(MinutesName)] = value; } }
        public Object SecondsName { get { return this[nameof(SecondsName)]; } set { this[nameof(SecondsName)] = value; } }
        public Object FramesName { get { return this[nameof(FramesName)]; } set { this[nameof(FramesName)] = value; } }
        public Object SubFramesName { get { return this[nameof(SubFramesName)]; } set { this[nameof(SubFramesName)] = value; } }
        public Object SlateName { get { return this[nameof(SlateName)]; } set { this[nameof(SlateName)] = value; } }
    }
    public class MovieSceneTakeTrack : MovieSceneNameableTrack
    {
        public MovieSceneTakeTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
}
