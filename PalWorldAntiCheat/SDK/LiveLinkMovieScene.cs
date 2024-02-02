using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.LiveLinkInterfaceSDK;
using SDK.Script.MovieSceneTracksSDK;
namespace SDK.Script.LiveLinkMovieSceneSDK
{
    public class MovieSceneLiveLinkSection : MovieSceneSection
    {
        public MovieSceneLiveLinkSection(nint addr) : base(addr) { }
        public LiveLinkSubjectPreset SubjectPreset { get { return this[nameof(SubjectPreset)].As<LiveLinkSubjectPreset>(); } set { this["SubjectPreset"] = value; } }
        public Array<bool> ChannelMask { get { return new Array<bool>(this[nameof(ChannelMask)].Address); } }
        public Array<MovieSceneLiveLinkSubSection> SubSections { get { return new Array<MovieSceneLiveLinkSubSection>(this[nameof(SubSections)].Address); } }
        public Object SubjectName { get { return this[nameof(SubjectName)]; } set { this[nameof(SubjectName)] = value; } }
        public LiveLinkFrameData TemplateToPush { get { return this[nameof(TemplateToPush)].As<LiveLinkFrameData>(); } set { this["TemplateToPush"] = value; } }
        public LiveLinkRefSkeleton RefSkeleton { get { return this[nameof(RefSkeleton)].As<LiveLinkRefSkeleton>(); } set { this["RefSkeleton"] = value; } }
        public Array<Object> CurveNames { get { return new Array<Object>(this[nameof(CurveNames)].Address); } }
        public Array<MovieSceneFloatChannel> PropertyFloatChannels { get { return new Array<MovieSceneFloatChannel>(this[nameof(PropertyFloatChannels)].Address); } }
    }
    public class MovieSceneLiveLinkSubSection : Object
    {
        public MovieSceneLiveLinkSubSection(nint addr) : base(addr) { }
        public LiveLinkSubSectionData SubSectionData { get { return this[nameof(SubSectionData)].As<LiveLinkSubSectionData>(); } set { this["SubSectionData"] = value; } }
        public Object SubjectRole { get { return this[nameof(SubjectRole)]; } set { this[nameof(SubjectRole)] = value; } }
    }
    public class MovieSceneLiveLinkSubSectionAnimation : MovieSceneLiveLinkSubSection
    {
        public MovieSceneLiveLinkSubSectionAnimation(nint addr) : base(addr) { }
    }
    public class MovieSceneLiveLinkSubSectionBasicRole : MovieSceneLiveLinkSubSection
    {
        public MovieSceneLiveLinkSubSectionBasicRole(nint addr) : base(addr) { }
    }
    public class MovieSceneLiveLinkSubSectionProperties : MovieSceneLiveLinkSubSection
    {
        public MovieSceneLiveLinkSubSectionProperties(nint addr) : base(addr) { }
    }
    public class MovieSceneLiveLinkTrack : MovieScenePropertyTrack
    {
        public MovieSceneLiveLinkTrack(nint addr) : base(addr) { }
        public Object TrackRole { get { return this[nameof(TrackRole)]; } set { this[nameof(TrackRole)] = value; } }
    }
    public class MovieSceneLiveLinkSectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneLiveLinkSectionTemplate(nint addr) : base(addr) { }
        public LiveLinkSubjectPreset SubjectPreset { get { return this[nameof(SubjectPreset)].As<LiveLinkSubjectPreset>(); } set { this["SubjectPreset"] = value; } }
        public Array<bool> ChannelMask { get { return new Array<bool>(this[nameof(ChannelMask)].Address); } }
        public Array<LiveLinkSubSectionData> SubSectionsData { get { return new Array<LiveLinkSubSectionData>(this[nameof(SubSectionsData)].Address); } }
    }
    public class LiveLinkSubSectionData : Object
    {
        public LiveLinkSubSectionData(nint addr) : base(addr) { }
        public Array<LiveLinkPropertyData> Properties { get { return new Array<LiveLinkPropertyData>(this[nameof(Properties)].Address); } }
    }
    public class LiveLinkPropertyData : Object
    {
        public LiveLinkPropertyData(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        //public Array<MovieSceneFloatChannel> FloatChannel { get { return new Array<MovieSceneFloatChannel>(this[nameof(FloatChannel)].Address); } }
        public Array<MovieSceneStringChannel> StringChannel { get { return new Array<MovieSceneStringChannel>(this[nameof(StringChannel)].Address); } }
        public Array<MovieSceneIntegerChannel> IntegerChannel { get { return new Array<MovieSceneIntegerChannel>(this[nameof(IntegerChannel)].Address); } }
        public Array<MovieSceneBoolChannel> BoolChannel { get { return new Array<MovieSceneBoolChannel>(this[nameof(BoolChannel)].Address); } }
        public Array<MovieSceneByteChannel> ByteChannel { get { return new Array<MovieSceneByteChannel>(this[nameof(ByteChannel)].Address); } }
    }
}
