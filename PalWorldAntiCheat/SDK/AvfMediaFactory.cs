using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.AvfMediaFactorySDK
{
    public class AvfMediaSettings : Object
    {
        public AvfMediaSettings(nint addr) : base(addr) { }
        public bool NativeAudioOut { get { return this[nameof(NativeAudioOut)].Flag; } set { this[nameof(NativeAudioOut)].Flag = value; } }
    }
}
