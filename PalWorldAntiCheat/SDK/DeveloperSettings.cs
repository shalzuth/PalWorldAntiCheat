using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.DeveloperSettingsSDK
{
    public class DeveloperSettings : Object
    {
        public DeveloperSettings(nint addr) : base(addr) { }
    }
    public class PlatformSettings : Object
    {
        public PlatformSettings(nint addr) : base(addr) { }
    }
    public class DeveloperSettingsBackedByCVars : DeveloperSettings
    {
        public DeveloperSettingsBackedByCVars(nint addr) : base(addr) { }
    }
    public class PlatformSettingsManager : Object
    {
        public PlatformSettingsManager(nint addr) : base(addr) { }
        public Object SettingsMap { get { return this[nameof(SettingsMap)]; } set { this[nameof(SettingsMap)] = value; } }
    }
    public class PerPlatformSettings : Object
    {
        public PerPlatformSettings(nint addr) : base(addr) { }
        public Array<PlatformSettings> Settings { get { return new Array<PlatformSettings>(this[nameof(Settings)].Address); } }
    }
    public class PlatformSettingsInstances : Object
    {
        public PlatformSettingsInstances(nint addr) : base(addr) { }
        public PlatformSettings PlatformInstance { get { return this[nameof(PlatformInstance)].As<PlatformSettings>(); } set { this["PlatformInstance"] = value; } }
        public Object OtherPlatforms { get { return this[nameof(OtherPlatforms)]; } set { this[nameof(OtherPlatforms)] = value; } }
    }
}
