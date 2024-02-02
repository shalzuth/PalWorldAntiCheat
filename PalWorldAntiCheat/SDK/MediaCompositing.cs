using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.MovieSceneTracksSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MediaCompositingSDK
{
    public class MovieSceneMediaPlayerPropertySection : MovieSceneSection
    {
        public MovieSceneMediaPlayerPropertySection(nint addr) : base(addr) { }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
        public bool bLoop { get { return this[nameof(bLoop)].Flag; } set { this[nameof(bLoop)].Flag = value; } }
    }
    public class MovieSceneMediaPlayerPropertyTrack : MovieScenePropertyTrack
    {
        public MovieSceneMediaPlayerPropertyTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneMediaSection : MovieSceneSection
    {
        public MovieSceneMediaSection(nint addr) : base(addr) { }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public MediaTexture MediaTexture { get { return this[nameof(MediaTexture)].As<MediaTexture>(); } set { this["MediaTexture"] = value; } }
        public MediaSoundComponent MediaSoundComponent { get { return this[nameof(MediaSoundComponent)].As<MediaSoundComponent>(); } set { this["MediaSoundComponent"] = value; } }
        public bool bUseExternalMediaPlayer { get { return this[nameof(bUseExternalMediaPlayer)].Flag; } set { this[nameof(bUseExternalMediaPlayer)].Flag = value; } }
        public MediaPlayer ExternalMediaPlayer { get { return this[nameof(ExternalMediaPlayer)].As<MediaPlayer>(); } set { this["ExternalMediaPlayer"] = value; } }
        public MediaSourceCacheSettings CacheSettings { get { return this[nameof(CacheSettings)].As<MediaSourceCacheSettings>(); } set { this["CacheSettings"] = value; } }
        public bool bHasMediaPlayerProxy { get { return this[nameof(bHasMediaPlayerProxy)].Flag; } set { this[nameof(bHasMediaPlayerProxy)].Flag = value; } }
    }
    public class MovieSceneMediaTrack : MovieSceneNameableTrack
    {
        public MovieSceneMediaTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> MediaSections { get { return new Array<MovieSceneSection>(this[nameof(MediaSections)].Address); } }
    }
    public class MovieSceneMediaPlayerPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneMediaPlayerPropertySectionTemplate(nint addr) : base(addr) { }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
        public FrameNumber SectionStartFrame { get { return this[nameof(SectionStartFrame)].As<FrameNumber>(); } set { this["SectionStartFrame"] = value; } }
        public bool bLoop { get { return this[nameof(bLoop)].Flag; } set { this[nameof(bLoop)].Flag = value; } }
    }
    public class MovieSceneMediaSectionParams : Object
    {
        public MovieSceneMediaSectionParams(nint addr) : base(addr) { }
        public MediaSoundComponent MediaSoundComponent { get { return this[nameof(MediaSoundComponent)].As<MediaSoundComponent>(); } set { this["MediaSoundComponent"] = value; } }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
        public MediaTexture MediaTexture { get { return this[nameof(MediaTexture)].As<MediaTexture>(); } set { this["MediaTexture"] = value; } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public FrameNumber SectionStartFrame { get { return this[nameof(SectionStartFrame)].As<FrameNumber>(); } set { this["SectionStartFrame"] = value; } }
        public FrameNumber SectionEndFrame { get { return this[nameof(SectionEndFrame)].As<FrameNumber>(); } set { this["SectionEndFrame"] = value; } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
    }
    public class MovieSceneMediaSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneMediaSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneMediaSectionParams Params { get { return this[nameof(Params)].As<MovieSceneMediaSectionParams>(); } set { this["Params"] = value; } }
    }
}
