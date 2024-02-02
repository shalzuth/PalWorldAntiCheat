using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AudioMixerSDK;
using SDK.Script.EngineSDK;
using SDK.Script.MediaUtilsSDK;
namespace SDK.Script.MediaAssetsSDK
{
    public class MediaSource : Object
    {
        public MediaSource(nint addr) : base(addr) { }
        public bool Validate() { return Invoke<bool>(nameof(Validate)); }
        public void SetMediaOptionString(Object Key, Object Value) { Invoke(nameof(SetMediaOptionString), Key, Value); }
        public void SetMediaOptionInt64(Object Key, long Value) { Invoke(nameof(SetMediaOptionInt64), Key, Value); }
        public void SetMediaOptionFloat(Object Key, float Value) { Invoke(nameof(SetMediaOptionFloat), Key, Value); }
        public void SetMediaOptionBool(Object Key, bool Value) { Invoke(nameof(SetMediaOptionBool), Key, Value); }
        public Object GetUrl() { return Invoke<Object>(nameof(GetUrl)); }
    }
    public class BaseMediaSource : MediaSource
    {
        public BaseMediaSource(nint addr) : base(addr) { }
        public Object PlayerName { get { return this[nameof(PlayerName)]; } set { this[nameof(PlayerName)] = value; } }
    }
    public class MediaPlayerProxyInterface : Interface
    {
        public MediaPlayerProxyInterface(nint addr) : base(addr) { }
    }
    public class MediaSoundComponent : SynthComponent
    {
        public MediaSoundComponent(nint addr) : base(addr) { }
        public EMediaSoundChannels Channels { get { return (EMediaSoundChannels)this[nameof(Channels)].GetValue<int>(); } set { this[nameof(Channels)].SetValue<int>((int)value); } }
        public bool DynamicRateAdjustment { get { return this[nameof(DynamicRateAdjustment)].Flag; } set { this[nameof(DynamicRateAdjustment)].Flag = value; } }
        public float RateAdjustmentFactor { get { return this[nameof(RateAdjustmentFactor)].GetValue<float>(); } set { this[nameof(RateAdjustmentFactor)].SetValue<float>(value); } }
        public FloatRange RateAdjustmentRange { get { return this[nameof(RateAdjustmentRange)].As<FloatRange>(); } set { this["RateAdjustmentRange"] = value; } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public void SetSpectralAnalysisSettings(Array<float> InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize) { Invoke(nameof(SetSpectralAnalysisSettings), InFrequenciesToAnalyze, InFFTSize); }
        public void SetMediaPlayer(MediaPlayer NewMediaPlayer) { Invoke(nameof(SetMediaPlayer), NewMediaPlayer); }
        public void SetEnvelopeFollowingsettings(int AttackTimeMsec, int ReleaseTimeMsec) { Invoke(nameof(SetEnvelopeFollowingsettings), AttackTimeMsec, ReleaseTimeMsec); }
        public void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled) { Invoke(nameof(SetEnableSpectralAnalysis), bInSpectralAnalysisEnabled); }
        public void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing) { Invoke(nameof(SetEnableEnvelopeFollowing), bInEnvelopeFollowing); }
        public Array<MediaSoundComponentSpectralData> GetSpectralData() { return Invoke<Array<MediaSoundComponentSpectralData>>(nameof(GetSpectralData)); }
        public Array<MediaSoundComponentSpectralData> GetNormalizedSpectralData() { return Invoke<Array<MediaSoundComponentSpectralData>>(nameof(GetNormalizedSpectralData)); }
        public MediaPlayer GetMediaPlayer() { return Invoke<MediaPlayer>(nameof(GetMediaPlayer)); }
        public float GetEnvelopeValue() { return Invoke<float>(nameof(GetEnvelopeValue)); }
        public bool BP_GetAttenuationSettingsToApply(SoundAttenuationSettings OutAttenuationSettings) { return Invoke<bool>(nameof(BP_GetAttenuationSettingsToApply), OutAttenuationSettings); }
    }
    public class MediaTexture : Texture
    {
        public MediaTexture(nint addr) : base(addr) { }
        public byte AddressX { get { return this[nameof(AddressX)].GetValue<byte>(); } set { this[nameof(AddressX)].SetValue<byte>(value); } }
        public byte AddressY { get { return this[nameof(AddressY)].GetValue<byte>(); } set { this[nameof(AddressY)].SetValue<byte>(value); } }
        public bool AutoClear { get { return this[nameof(AutoClear)].Flag; } set { this[nameof(AutoClear)].Flag = value; } }
        public LinearColor ClearColor { get { return this[nameof(ClearColor)].As<LinearColor>(); } set { this["ClearColor"] = value; } }
        public bool EnableGenMips { get { return this[nameof(EnableGenMips)].Flag; } set { this[nameof(EnableGenMips)].Flag = value; } }
        public byte NumMips { get { return this[nameof(NumMips)].GetValue<byte>(); } set { this[nameof(NumMips)].SetValue<byte>(value); } }
        public bool NewStyleOutput { get { return this[nameof(NewStyleOutput)].Flag; } set { this[nameof(NewStyleOutput)].Flag = value; } }
        public byte OutputFormat { get { return this[nameof(OutputFormat)].GetValue<byte>(); } set { this[nameof(OutputFormat)].SetValue<byte>(value); } }
        public float CurrentAspectRatio { get { return this[nameof(CurrentAspectRatio)].GetValue<float>(); } set { this[nameof(CurrentAspectRatio)].SetValue<float>(value); } }
        public byte CurrentOrientation { get { return this[nameof(CurrentOrientation)].GetValue<byte>(); } set { this[nameof(CurrentOrientation)].SetValue<byte>(value); } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public void UpdateResource() { Invoke(nameof(UpdateResource)); }
        public void SetMediaPlayer(MediaPlayer NewMediaPlayer) { Invoke(nameof(SetMediaPlayer), NewMediaPlayer); }
        public int GetWidth() { return Invoke<int>(nameof(GetWidth)); }
        public int GetTextureNumMips() { return Invoke<int>(nameof(GetTextureNumMips)); }
        public MediaPlayer GetMediaPlayer() { return Invoke<MediaPlayer>(nameof(GetMediaPlayer)); }
        public int GetHeight() { return Invoke<int>(nameof(GetHeight)); }
        public float GetAspectRatio() { return Invoke<float>(nameof(GetAspectRatio)); }
    }
    public class FileMediaSource : BaseMediaSource
    {
        public FileMediaSource(nint addr) : base(addr) { }
        public Object FilePath { get { return this[nameof(FilePath)]; } set { this[nameof(FilePath)] = value; } }
        public bool PrecacheFile { get { return this[nameof(PrecacheFile)].Flag; } set { this[nameof(PrecacheFile)].Flag = value; } }
        public void SetFilePath(Object Path) { Invoke(nameof(SetFilePath), Path); }
    }
    public class MediaComponent : ActorComponent
    {
        public MediaComponent(nint addr) : base(addr) { }
        public MediaTexture MediaTexture { get { return this[nameof(MediaTexture)].As<MediaTexture>(); } set { this["MediaTexture"] = value; } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public MediaTexture GetMediaTexture() { return Invoke<MediaTexture>(nameof(GetMediaTexture)); }
        public MediaPlayer GetMediaPlayer() { return Invoke<MediaPlayer>(nameof(GetMediaPlayer)); }
    }
    public class MediaTimeStampInfo : Object
    {
        public MediaTimeStampInfo(nint addr) : base(addr) { }
        public Timespan Time { get { return this[nameof(Time)].As<Timespan>(); } set { this["Time"] = value; } }
        public long SequenceIndex { get { return this[nameof(SequenceIndex)].GetValue<long>(); } set { this[nameof(SequenceIndex)].SetValue<long>(value); } }
    }
    public class MediaPlayer : Object
    {
        public MediaPlayer(nint addr) : base(addr) { }
        public Object OnEndReached { get { return this[nameof(OnEndReached)]; } set { this[nameof(OnEndReached)] = value; } }
        public Object OnMediaClosed { get { return this[nameof(OnMediaClosed)]; } set { this[nameof(OnMediaClosed)] = value; } }
        public Object OnMediaOpened { get { return this[nameof(OnMediaOpened)]; } set { this[nameof(OnMediaOpened)] = value; } }
        public Object OnMediaOpenFailed { get { return this[nameof(OnMediaOpenFailed)]; } set { this[nameof(OnMediaOpenFailed)] = value; } }
        public Object OnPlaybackResumed { get { return this[nameof(OnPlaybackResumed)]; } set { this[nameof(OnPlaybackResumed)] = value; } }
        public Object OnPlaybackSuspended { get { return this[nameof(OnPlaybackSuspended)]; } set { this[nameof(OnPlaybackSuspended)] = value; } }
        public Object OnSeekCompleted { get { return this[nameof(OnSeekCompleted)]; } set { this[nameof(OnSeekCompleted)] = value; } }
        public Object OnTracksChanged { get { return this[nameof(OnTracksChanged)]; } set { this[nameof(OnTracksChanged)] = value; } }
        public Timespan CacheAhead { get { return this[nameof(CacheAhead)].As<Timespan>(); } set { this["CacheAhead"] = value; } }
        public Timespan CacheBehind { get { return this[nameof(CacheBehind)].As<Timespan>(); } set { this["CacheBehind"] = value; } }
        public Timespan CacheBehindGame { get { return this[nameof(CacheBehindGame)].As<Timespan>(); } set { this["CacheBehindGame"] = value; } }
        public bool NativeAudioOut { get { return this[nameof(NativeAudioOut)].Flag; } set { this[nameof(NativeAudioOut)].Flag = value; } }
        public bool PlayOnOpen { get { return this[nameof(PlayOnOpen)].Flag; } set { this[nameof(PlayOnOpen)].Flag = value; } }
        public bool Shuffle { get { return this[nameof(Shuffle)].Flag; } set { this[nameof(Shuffle)].Flag = value; } }
        public bool Loop { get { return this[nameof(Loop)].Flag; } set { this[nameof(Loop)].Flag = value; } }
        public MediaPlaylist Playlist { get { return this[nameof(Playlist)].As<MediaPlaylist>(); } set { this["Playlist"] = value; } }
        public int PlaylistIndex { get { return this[nameof(PlaylistIndex)].GetValue<int>(); } set { this[nameof(PlaylistIndex)].SetValue<int>(value); } }
        public Timespan TimeDelay { get { return this[nameof(TimeDelay)].As<Timespan>(); } set { this["TimeDelay"] = value; } }
        public float HorizontalFieldOfView { get { return this[nameof(HorizontalFieldOfView)].GetValue<float>(); } set { this[nameof(HorizontalFieldOfView)].SetValue<float>(value); } }
        public float VerticalFieldOfView { get { return this[nameof(VerticalFieldOfView)].GetValue<float>(); } set { this[nameof(VerticalFieldOfView)].SetValue<float>(value); } }
        public Rotator ViewRotation { get { return this[nameof(ViewRotation)].As<Rotator>(); } set { this["ViewRotation"] = value; } }
        public Guid PlayerGuid { get { return this[nameof(PlayerGuid)].As<Guid>(); } set { this["PlayerGuid"] = value; } }
        public bool SupportsSeeking() { return Invoke<bool>(nameof(SupportsSeeking)); }
        public bool SupportsScrubbing() { return Invoke<bool>(nameof(SupportsScrubbing)); }
        public bool SupportsRate(float Rate, bool Unthinned) { return Invoke<bool>(nameof(SupportsRate), Rate, Unthinned); }
        public bool SetViewRotation(Rotator Rotation, bool Absolute) { return Invoke<bool>(nameof(SetViewRotation), Rotation, Absolute); }
        public bool SetViewField(float Horizontal, float Vertical, bool Absolute) { return Invoke<bool>(nameof(SetViewField), Horizontal, Vertical, Absolute); }
        public bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate) { return Invoke<bool>(nameof(SetVideoTrackFrameRate), TrackIndex, FormatIndex, FrameRate); }
        public bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex) { return Invoke<bool>(nameof(SetTrackFormat), TrackType, TrackIndex, FormatIndex); }
        public void SetTimeDelay(Timespan TimeDelay) { Invoke(nameof(SetTimeDelay), TimeDelay); }
        public bool SetRate(float Rate) { return Invoke<bool>(nameof(SetRate), Rate); }
        public bool SetNativeVolume(float Volume) { return Invoke<bool>(nameof(SetNativeVolume), Volume); }
        public void SetMediaOptions(MediaSource Options) { Invoke(nameof(SetMediaOptions), Options); }
        public bool SetLooping(bool Looping) { return Invoke<bool>(nameof(SetLooping), Looping); }
        public void SetDesiredPlayerName(Object PlayerName) { Invoke(nameof(SetDesiredPlayerName), PlayerName); }
        public void SetBlockOnTime(Timespan Time) { Invoke(nameof(SetBlockOnTime), Time); }
        public bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex) { return Invoke<bool>(nameof(SelectTrack), TrackType, TrackIndex); }
        public bool Seek(Timespan Time) { return Invoke<bool>(nameof(Seek), Time); }
        public bool Rewind() { return Invoke<bool>(nameof(Rewind)); }
        public bool Reopen() { return Invoke<bool>(nameof(Reopen)); }
        public bool Previous() { return Invoke<bool>(nameof(Previous)); }
        public void PlayAndSeek() { Invoke(nameof(PlayAndSeek)); }
        public bool Play() { return Invoke<bool>(nameof(Play)); }
        public bool Pause() { return Invoke<bool>(nameof(Pause)); }
        public bool OpenUrl(Object URL) { return Invoke<bool>(nameof(OpenUrl), URL); }
        public bool OpenSourceWithOptions(MediaSource MediaSource, MediaPlayerOptions Options) { return Invoke<bool>(nameof(OpenSourceWithOptions), MediaSource, Options); }
        public void OpenSourceLatent(Object WorldContextObject, LatentActionInfo LatentInfo, MediaSource MediaSource, MediaPlayerOptions Options, bool bSuccess) { Invoke(nameof(OpenSourceLatent), WorldContextObject, LatentInfo, MediaSource, Options, bSuccess); }
        public bool OpenSource(MediaSource MediaSource) { return Invoke<bool>(nameof(OpenSource), MediaSource); }
        public bool OpenPlaylistIndex(MediaPlaylist InPlaylist, int Index) { return Invoke<bool>(nameof(OpenPlaylistIndex), InPlaylist, Index); }
        public bool OpenPlaylist(MediaPlaylist InPlaylist) { return Invoke<bool>(nameof(OpenPlaylist), InPlaylist); }
        public bool OpenFile(Object FilePath) { return Invoke<bool>(nameof(OpenFile), FilePath); }
        public bool Next() { return Invoke<bool>(nameof(Next)); }
        public bool IsReady() { return Invoke<bool>(nameof(IsReady)); }
        public bool IsPreparing() { return Invoke<bool>(nameof(IsPreparing)); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
        public bool IsLooping() { return Invoke<bool>(nameof(IsLooping)); }
        public bool IsConnecting() { return Invoke<bool>(nameof(IsConnecting)); }
        public bool IsClosed() { return Invoke<bool>(nameof(IsClosed)); }
        public bool IsBuffering() { return Invoke<bool>(nameof(IsBuffering)); }
        public bool HasError() { return Invoke<bool>(nameof(HasError)); }
        public Rotator GetViewRotation() { return Invoke<Rotator>(nameof(GetViewRotation)); }
        public Object GetVideoTrackType(int TrackIndex, int FormatIndex) { return Invoke<Object>(nameof(GetVideoTrackType), TrackIndex, FormatIndex); }
        public FloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex) { return Invoke<FloatRange>(nameof(GetVideoTrackFrameRates), TrackIndex, FormatIndex); }
        public float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex) { return Invoke<float>(nameof(GetVideoTrackFrameRate), TrackIndex, FormatIndex); }
        public IntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex) { return Invoke<IntPoint>(nameof(GetVideoTrackDimensions), TrackIndex, FormatIndex); }
        public float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex) { return Invoke<float>(nameof(GetVideoTrackAspectRatio), TrackIndex, FormatIndex); }
        public float GetVerticalFieldOfView() { return Invoke<float>(nameof(GetVerticalFieldOfView)); }
        public Object GetUrl() { return Invoke<Object>(nameof(GetUrl)); }
        public Object GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex) { return Invoke<Object>(nameof(GetTrackLanguage), TrackType, TrackIndex); }
        public int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex) { return Invoke<int>(nameof(GetTrackFormat), TrackType, TrackIndex); }
        public Object GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex) { return Invoke<Object>(nameof(GetTrackDisplayName), TrackType, TrackIndex); }
        public MediaTimeStampInfo GetTimeStamp() { return Invoke<MediaTimeStampInfo>(nameof(GetTimeStamp)); }
        public Timespan GetTimeDelay() { return Invoke<Timespan>(nameof(GetTimeDelay)); }
        public Timespan GetTime() { return Invoke<Timespan>(nameof(GetTime)); }
        public void GetSupportedRates(Array<FloatRange> OutRates, bool Unthinned) { Invoke(nameof(GetSupportedRates), OutRates, Unthinned); }
        public int GetSelectedTrack(EMediaPlayerTrack TrackType) { return Invoke<int>(nameof(GetSelectedTrack), TrackType); }
        public float GetRate() { return Invoke<float>(nameof(GetRate)); }
        public int GetPlaylistIndex() { return Invoke<int>(nameof(GetPlaylistIndex)); }
        public MediaPlaylist GetPlaylist() { return Invoke<MediaPlaylist>(nameof(GetPlaylist)); }
        public Object GetPlayerName() { return Invoke<Object>(nameof(GetPlayerName)); }
        public int GetNumTracks(EMediaPlayerTrack TrackType) { return Invoke<int>(nameof(GetNumTracks), TrackType); }
        public int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex) { return Invoke<int>(nameof(GetNumTrackFormats), TrackType, TrackIndex); }
        public Object GetMediaName() { return Invoke<Object>(nameof(GetMediaName)); }
        public float GetHorizontalFieldOfView() { return Invoke<float>(nameof(GetHorizontalFieldOfView)); }
        public Timespan GetDuration() { return Invoke<Timespan>(nameof(GetDuration)); }
        public Object GetDesiredPlayerName() { return Invoke<Object>(nameof(GetDesiredPlayerName)); }
        public Object GetAudioTrackType(int TrackIndex, int FormatIndex) { return Invoke<Object>(nameof(GetAudioTrackType), TrackIndex, FormatIndex); }
        public int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex) { return Invoke<int>(nameof(GetAudioTrackSampleRate), TrackIndex, FormatIndex); }
        public int GetAudioTrackChannels(int TrackIndex, int FormatIndex) { return Invoke<int>(nameof(GetAudioTrackChannels), TrackIndex, FormatIndex); }
        public void Close() { Invoke(nameof(Close)); }
        public bool CanPlayUrl(Object URL) { return Invoke<bool>(nameof(CanPlayUrl), URL); }
        public bool CanPlaySource(MediaSource MediaSource) { return Invoke<bool>(nameof(CanPlaySource), MediaSource); }
        public bool CanPause() { return Invoke<bool>(nameof(CanPause)); }
    }
    public class MediaPlaylist : Object
    {
        public MediaPlaylist(nint addr) : base(addr) { }
        public Array<MediaSource> Items { get { return new Array<MediaSource>(this[nameof(Items)].Address); } }
        public bool Replace(int Index, MediaSource Replacement) { return Invoke<bool>(nameof(Replace), Index, Replacement); }
        public bool RemoveAt(int Index) { return Invoke<bool>(nameof(RemoveAt), Index); }
        public bool Remove(MediaSource MediaSource) { return Invoke<bool>(nameof(Remove), MediaSource); }
        public int Num() { return Invoke<int>(nameof(Num)); }
        public void Insert(MediaSource MediaSource, int Index) { Invoke(nameof(Insert), MediaSource, Index); }
        public MediaSource GetRandom(int OutIndex) { return Invoke<MediaSource>(nameof(GetRandom), OutIndex); }
        public MediaSource GetPrevious(int InOutIndex) { return Invoke<MediaSource>(nameof(GetPrevious), InOutIndex); }
        public MediaSource GetNext(int InOutIndex) { return Invoke<MediaSource>(nameof(GetNext), InOutIndex); }
        public MediaSource Get(int Index) { return Invoke<MediaSource>(nameof(Get), Index); }
        public bool AddUrl(Object URL) { return Invoke<bool>(nameof(AddUrl), URL); }
        public bool AddFile(Object FilePath) { return Invoke<bool>(nameof(AddFile), FilePath); }
        public bool Add(MediaSource MediaSource) { return Invoke<bool>(nameof(Add), MediaSource); }
    }
    public class PlatformMediaSource : MediaSource
    {
        public PlatformMediaSource(nint addr) : base(addr) { }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
    }
    public class StreamMediaSource : BaseMediaSource
    {
        public StreamMediaSource(nint addr) : base(addr) { }
        public Object StreamUrl { get { return this[nameof(StreamUrl)]; } set { this[nameof(StreamUrl)] = value; } }
    }
    public class TimeSynchronizableMediaSource : BaseMediaSource
    {
        public TimeSynchronizableMediaSource(nint addr) : base(addr) { }
        public bool bUseTimeSynchronization { get { return this[nameof(bUseTimeSynchronization)].Flag; } set { this[nameof(bUseTimeSynchronization)].Flag = value; } }
        public int FrameDelay { get { return this[nameof(FrameDelay)].GetValue<int>(); } set { this[nameof(FrameDelay)].SetValue<int>(value); } }
        public double TimeDelay { get { return this[nameof(TimeDelay)].GetValue<double>(); } set { this[nameof(TimeDelay)].SetValue<double>(value); } }
        public bool bAutoDetectInput { get { return this[nameof(bAutoDetectInput)].Flag; } set { this[nameof(bAutoDetectInput)].Flag = value; } }
    }
    public class MediaBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public MediaBlueprintFunctionLibrary(nint addr) : base(addr) { }
        public void EnumerateWebcamCaptureDevices(Array<MediaCaptureDevice> OutDevices, int Filter) { Invoke(nameof(EnumerateWebcamCaptureDevices), OutDevices, Filter); }
        public void EnumerateVideoCaptureDevices(Array<MediaCaptureDevice> OutDevices, int Filter) { Invoke(nameof(EnumerateVideoCaptureDevices), OutDevices, Filter); }
        public void EnumerateAudioCaptureDevices(Array<MediaCaptureDevice> OutDevices, int Filter) { Invoke(nameof(EnumerateAudioCaptureDevices), OutDevices, Filter); }
    }
    public enum EMediaSoundChannels : int
    {
        Mono = 0,
        Stereo = 1,
        Surround = 2,
        EMediaSoundChannels_MAX = 3,
    }
    public enum EMediaSoundComponentFFTSize : int
    {
        Min_65 = 0,
        Small_257 = 1,
        Medium_513 = 2,
        Large_1025 = 3,
        EMediaSoundComponentFFTSize_MAX = 4,
    }
    public enum MediaTextureOutputFormat : int
    {
        MTOF_Default = 0,
        MTOF_SRGB_LINOUT = 1,
        MTOF_MAX = 2,
    }
    public enum MediaTextureOrientation : int
    {
        MTORI_Original = 0,
        MTORI_CW90 = 1,
        MTORI_CW180 = 2,
        MTORI_CW270 = 3,
        MTORI_MAX = 4,
    }
    public enum EMediaPlayerTrack : int
    {
        Audio = 0,
        Caption = 1,
        Metadata = 2,
        Script = 3,
        Subtitle = 4,
        Text = 5,
        Video = 6,
        EMediaPlayerTrack_MAX = 7,
    }
    public enum EMediaTextureVisibleMipsTiles : int
    {
        None = 0,
        Plane = 1,
        Sphere = 2,
        EMediaTextureVisibleMipsTiles_MAX = 3,
    }
    public enum EMediaAudioCaptureDeviceFilter : int
    {
        None = 0,
        Card = 1,
        Microphone = 2,
        Software = 4,
        Unknown = 8,
        EMediaAudioCaptureDeviceFilter_MAX = 9,
    }
    public enum EMediaVideoCaptureDeviceFilter : int
    {
        None = 0,
        Card = 1,
        Software = 2,
        Unknown = 4,
        Webcam = 8,
        EMediaVideoCaptureDeviceFilter_MAX = 9,
    }
    public enum EMediaWebcamCaptureDeviceFilter : int
    {
        None = 0,
        DepthSensor = 1,
        Front = 2,
        Rear = 4,
        Unknown = 8,
        EMediaWebcamCaptureDeviceFilter_MAX = 9,
    }
    public class MediaSoundComponentSpectralData : Object
    {
        public MediaSoundComponentSpectralData(nint addr) : base(addr) { }
        public float FrequencyHz { get { return this[nameof(FrequencyHz)].GetValue<float>(); } set { this[nameof(FrequencyHz)].SetValue<float>(value); } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
    }
    public class MediaSourceCacheSettings : Object
    {
        public MediaSourceCacheSettings(nint addr) : base(addr) { }
        public bool bOverride { get { return this[nameof(bOverride)].Flag; } set { this[nameof(bOverride)].Flag = value; } }
        public float TimeToLookAhead { get { return this[nameof(TimeToLookAhead)].GetValue<float>(); } set { this[nameof(TimeToLookAhead)].SetValue<float>(value); } }
    }
    public class MediaCaptureDevice : Object
    {
        public MediaCaptureDevice(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
    }
}
