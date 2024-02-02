using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MediaPlateSDK
{
    public class MediaPlateAssetUserData : AssetUserData
    {
        public MediaPlateAssetUserData(nint addr) : base(addr) { }
    }
    public class MediaPlate : Actor
    {
        public MediaPlate(nint addr) : base(addr) { }
        public MediaPlateComponent MediaPlateComponent { get { return this[nameof(MediaPlateComponent)].As<MediaPlateComponent>(); } set { this["MediaPlateComponent"] = value; } }
        public StaticMeshComponent StaticMeshComponent { get { return this[nameof(StaticMeshComponent)].As<StaticMeshComponent>(); } set { this["StaticMeshComponent"] = value; } }
    }
    public class MediaPlateComponent : ActorComponent
    {
        public MediaPlateComponent(nint addr) : base(addr) { }
        public bool bPlayOnOpen { get { return this[nameof(bPlayOnOpen)].Flag; } set { this[nameof(bPlayOnOpen)].Flag = value; } }
        public bool bAutoPlay { get { return this[nameof(bAutoPlay)].Flag; } set { this[nameof(bAutoPlay)].Flag = value; } }
        public bool bEnableAudio { get { return this[nameof(bEnableAudio)].Flag; } set { this[nameof(bEnableAudio)].Flag = value; } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public bool bIsAspectRatioAuto { get { return this[nameof(bIsAspectRatioAuto)].Flag; } set { this[nameof(bIsAspectRatioAuto)].Flag = value; } }
        public MediaSoundComponent SoundComponent { get { return this[nameof(SoundComponent)].As<MediaSoundComponent>(); } set { this["SoundComponent"] = value; } }
        public StaticMeshComponent StaticMeshComponent { get { return this[nameof(StaticMeshComponent)].As<StaticMeshComponent>(); } set { this["StaticMeshComponent"] = value; } }
        public Array<StaticMeshComponent> Letterboxes { get { return new Array<StaticMeshComponent>(this[nameof(Letterboxes)].Address); } }
        public MediaPlaylist MediaPlaylist { get { return this[nameof(MediaPlaylist)].As<MediaPlaylist>(); } set { this["MediaPlaylist"] = value; } }
        public int PlaylistIndex { get { return this[nameof(PlaylistIndex)].GetValue<int>(); } set { this[nameof(PlaylistIndex)].SetValue<int>(value); } }
        public MediaSourceCacheSettings CacheSettings { get { return this[nameof(CacheSettings)].As<MediaSourceCacheSettings>(); } set { this["CacheSettings"] = value; } }
        public bool bIsMediaPlatePlaying { get { return this[nameof(bIsMediaPlatePlaying)].Flag; } set { this[nameof(bIsMediaPlatePlaying)].Flag = value; } }
        public bool bPlayOnlyWhenVisible { get { return this[nameof(bPlayOnlyWhenVisible)].Flag; } set { this[nameof(bPlayOnlyWhenVisible)].Flag = value; } }
        public bool bLoop { get { return this[nameof(bLoop)].Flag; } set { this[nameof(bLoop)].Flag = value; } }
        public EMediaTextureVisibleMipsTiles VisibleMipsTilesCalculations { get { return (EMediaTextureVisibleMipsTiles)this[nameof(VisibleMipsTilesCalculations)].GetValue<int>(); } set { this[nameof(VisibleMipsTilesCalculations)].SetValue<int>((int)value); } }
        public float MipMapBias { get { return this[nameof(MipMapBias)].GetValue<float>(); } set { this[nameof(MipMapBias)].SetValue<float>(value); } }
        public float LetterboxAspectRatio { get { return this[nameof(LetterboxAspectRatio)].GetValue<float>(); } set { this[nameof(LetterboxAspectRatio)].SetValue<float>(value); } }
        public Vector2D MeshRange { get { return this[nameof(MeshRange)].As<Vector2D>(); } set { this["MeshRange"] = value; } }
        public MediaTexture MediaTexture { get { return this[nameof(MediaTexture)].As<MediaTexture>(); } set { this["MediaTexture"] = value; } }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public void SetPlayOnlyWhenVisible(bool bInPlayOnlyWhenVisible) { Invoke(nameof(SetPlayOnlyWhenVisible), bInPlayOnlyWhenVisible); }
        public void SetMeshRange(Vector2D InMeshRange) { Invoke(nameof(SetMeshRange), InMeshRange); }
        public void SetLoop(bool bInLoop) { Invoke(nameof(SetLoop), bInLoop); }
        public void SetLetterboxAspectRatio(float AspectRatio) { Invoke(nameof(SetLetterboxAspectRatio), AspectRatio); }
        public bool Seek(Timespan Time) { return Invoke<bool>(nameof(Seek), Time); }
        public bool Rewind() { return Invoke<bool>(nameof(Rewind)); }
        public void Play() { Invoke(nameof(Play)); }
        public void Pause() { Invoke(nameof(Pause)); }
        public void Open() { Invoke(nameof(Open)); }
        public void OnMediaOpened(Object DeviceUrl) { Invoke(nameof(OnMediaOpened), DeviceUrl); }
        public void OnMediaEnd() { Invoke(nameof(OnMediaEnd)); }
        public bool IsMediaPlatePlaying() { return Invoke<bool>(nameof(IsMediaPlatePlaying)); }
        public Vector2D GetMeshRange() { return Invoke<Vector2D>(nameof(GetMeshRange)); }
        public MediaTexture GetMediaTexture() { return Invoke<MediaTexture>(nameof(GetMediaTexture)); }
        public MediaPlayer GetMediaPlayer() { return Invoke<MediaPlayer>(nameof(GetMediaPlayer)); }
        public bool GetLoop() { return Invoke<bool>(nameof(GetLoop)); }
        public float GetLetterboxAspectRatio() { return Invoke<float>(nameof(GetLetterboxAspectRatio)); }
        public void Close() { Invoke(nameof(Close)); }
    }
}
