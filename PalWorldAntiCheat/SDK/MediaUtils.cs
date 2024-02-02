using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MediaUtilsSDK
{
    public enum EMediaPlayerOptionBooleanOverride : int
    {
        UseMediaPlayerSetting = 0,
        Enabled = 1,
        Disabled = 2,
        EMediaPlayerOptionBooleanOverride_MAX = 3,
    }
    public class MediaPlayerTrackOptions : Object
    {
        public MediaPlayerTrackOptions(nint addr) : base(addr) { }
        public int Audio { get { return this[nameof(Audio)].GetValue<int>(); } set { this[nameof(Audio)].SetValue<int>(value); } }
        public int Caption { get { return this[nameof(Caption)].GetValue<int>(); } set { this[nameof(Caption)].SetValue<int>(value); } }
        public int MetaData { get { return this[nameof(MetaData)].GetValue<int>(); } set { this[nameof(MetaData)].SetValue<int>(value); } }
        public int Script { get { return this[nameof(Script)].GetValue<int>(); } set { this[nameof(Script)].SetValue<int>(value); } }
        public int Subtitle { get { return this[nameof(Subtitle)].GetValue<int>(); } set { this[nameof(Subtitle)].SetValue<int>(value); } }
        public int Text { get { return this[nameof(Text)].GetValue<int>(); } set { this[nameof(Text)].SetValue<int>(value); } }
        public int Video { get { return this[nameof(Video)].GetValue<int>(); } set { this[nameof(Video)].SetValue<int>(value); } }
    }
    public class MediaPlayerOptions : Object
    {
        public MediaPlayerOptions(nint addr) : base(addr) { }
        public MediaPlayerTrackOptions Tracks { get { return this[nameof(Tracks)].As<MediaPlayerTrackOptions>(); } set { this["Tracks"] = value; } }
        public Timespan SeekTime { get { return this[nameof(SeekTime)].As<Timespan>(); } set { this["SeekTime"] = value; } }
        public EMediaPlayerOptionBooleanOverride PlayOnOpen { get { return (EMediaPlayerOptionBooleanOverride)this[nameof(PlayOnOpen)].GetValue<int>(); } set { this[nameof(PlayOnOpen)].SetValue<int>((int)value); } }
        public EMediaPlayerOptionBooleanOverride Loop { get { return (EMediaPlayerOptionBooleanOverride)this[nameof(Loop)].GetValue<int>(); } set { this[nameof(Loop)].SetValue<int>((int)value); } }
    }
}
