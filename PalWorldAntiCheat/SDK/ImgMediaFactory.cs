using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ImgMediaFactorySDK
{
    public class ImgMediaSettings : Object
    {
        public ImgMediaSettings(nint addr) : base(addr) { }
        public FrameRate DefaultFrameRate { get { return this[nameof(DefaultFrameRate)].As<FrameRate>(); } set { this["DefaultFrameRate"] = value; } }
        public float CacheBehindPercentage { get { return this[nameof(CacheBehindPercentage)].GetValue<float>(); } set { this[nameof(CacheBehindPercentage)].SetValue<float>(value); } }
        public float CacheSizeGB { get { return this[nameof(CacheSizeGB)].GetValue<float>(); } set { this[nameof(CacheSizeGB)].SetValue<float>(value); } }
        public int CacheThreads { get { return this[nameof(CacheThreads)].GetValue<int>(); } set { this[nameof(CacheThreads)].SetValue<int>(value); } }
        public int CacheThreadStackSizeKB { get { return this[nameof(CacheThreadStackSizeKB)].GetValue<int>(); } set { this[nameof(CacheThreadStackSizeKB)].SetValue<int>(value); } }
        public float GlobalCacheSizeGB { get { return this[nameof(GlobalCacheSizeGB)].GetValue<float>(); } set { this[nameof(GlobalCacheSizeGB)].SetValue<float>(value); } }
        public bool UseGlobalCache { get { return this[nameof(UseGlobalCache)].Flag; } set { this[nameof(UseGlobalCache)].Flag = value; } }
        public uint ExrDecoderThreads { get { return this[nameof(ExrDecoderThreads)].GetValue<uint>(); } set { this[nameof(ExrDecoderThreads)].SetValue<uint>(value); } }
        public Object DefaultProxy { get { return this[nameof(DefaultProxy)]; } set { this[nameof(DefaultProxy)] = value; } }
        public bool UseDefaultProxy { get { return this[nameof(UseDefaultProxy)].Flag; } set { this[nameof(UseDefaultProxy)].Flag = value; } }
    }
}
