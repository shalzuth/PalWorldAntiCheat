using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.AudioExtensionsSDK;
namespace SDK.Script.SoundFieldsSDK
{
    public class AmbisonicsEncodingSettings : SoundfieldEncodingSettingsBase
    {
        public AmbisonicsEncodingSettings(nint addr) : base(addr) { }
        public int AmbisonicsOrder { get { return this[nameof(AmbisonicsOrder)].GetValue<int>(); } set { this[nameof(AmbisonicsOrder)].SetValue<int>(value); } }
    }
}
