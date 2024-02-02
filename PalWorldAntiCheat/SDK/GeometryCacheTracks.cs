using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.GeometryCacheSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryCacheTracksSDK
{
    public class MovieSceneGeometryCacheSection : MovieSceneSection
    {
        public MovieSceneGeometryCacheSection(nint addr) : base(addr) { }
        public MovieSceneGeometryCacheParams Params { get { return this[nameof(Params)].As<MovieSceneGeometryCacheParams>(); } set { this["Params"] = value; } }
    }
    public class MovieSceneGeometryCacheTrack : MovieSceneNameableTrack
    {
        public MovieSceneGeometryCacheTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> AnimationSections { get { return new Array<MovieSceneSection>(this[nameof(AnimationSections)].Address); } }
    }
    public class MovieSceneGeometryCacheParams : Object
    {
        public MovieSceneGeometryCacheParams(nint addr) : base(addr) { }
        public GeometryCache GeometryCacheAsset { get { return this[nameof(GeometryCacheAsset)].As<GeometryCache>(); } set { this["GeometryCacheAsset"] = value; } }
        public FrameNumber FirstLoopStartFrameOffset { get { return this[nameof(FirstLoopStartFrameOffset)].As<FrameNumber>(); } set { this["FirstLoopStartFrameOffset"] = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public FrameNumber EndFrameOffset { get { return this[nameof(EndFrameOffset)].As<FrameNumber>(); } set { this["EndFrameOffset"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bReverse { get { return this[nameof(bReverse)].Flag; } set { this[nameof(bReverse)].Flag = value; } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float EndOffset { get { return this[nameof(EndOffset)].GetValue<float>(); } set { this[nameof(EndOffset)].SetValue<float>(value); } }
        public SoftObjectPath GeometryCache { get { return this[nameof(GeometryCache)].As<SoftObjectPath>(); } set { this["GeometryCache"] = value; } }
    }
    public class MovieSceneGeometryCacheSectionTemplateParameters : MovieSceneGeometryCacheParams
    {
        public MovieSceneGeometryCacheSectionTemplateParameters(nint addr) : base(addr) { }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
        public FrameNumber SectionEndTime { get { return this[nameof(SectionEndTime)].As<FrameNumber>(); } set { this["SectionEndTime"] = value; } }
    }
    public class MovieSceneGeometryCacheSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneGeometryCacheSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneGeometryCacheSectionTemplateParameters Params { get { return this[nameof(Params)].As<MovieSceneGeometryCacheSectionTemplateParameters>(); } set { this["Params"] = value; } }
    }
}
