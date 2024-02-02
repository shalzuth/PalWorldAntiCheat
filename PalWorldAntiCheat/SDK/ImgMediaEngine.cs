using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImgMediaEngineSDK
{
    public class ImgMediaPlaybackComponent : ActorComponent
    {
        public ImgMediaPlaybackComponent(nint addr) : base(addr) { }
        public float LODBias { get { return this[nameof(LODBias)].GetValue<float>(); } set { this[nameof(LODBias)].SetValue<float>(value); } }
    }
}
