using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.OpenColorIOSDK
{
    public class OpenColorIOSettings : DeveloperSettings
    {
        public OpenColorIOSettings(nint addr) : base(addr) { }
        public bool bUseLegacyProcessor { get { return this[nameof(bUseLegacyProcessor)].Flag; } set { this[nameof(bUseLegacyProcessor)].Flag = value; } }
        public bool bUse32fLUT { get { return this[nameof(bUse32fLUT)].Flag; } set { this[nameof(bUse32fLUT)].Flag = value; } }
    }
    public class OpenColorIOBlueprintLibrary : BlueprintFunctionLibrary
    {
        public OpenColorIOBlueprintLibrary(nint addr) : base(addr) { }
        public bool ApplyColorSpaceTransform(Object WorldContextObject, OpenColorIOColorConversionSettings ConversionSettings, Texture InputTexture, TextureRenderTarget2D OutputRenderTarget) { return Invoke<bool>(nameof(ApplyColorSpaceTransform), WorldContextObject, ConversionSettings, InputTexture, OutputRenderTarget); }
    }
    public class OpenColorIOColorTransform : Object
    {
        public OpenColorIOColorTransform(nint addr) : base(addr) { }
        public OpenColorIOConfiguration ConfigurationOwner { get { return this[nameof(ConfigurationOwner)].As<OpenColorIOConfiguration>(); } set { this["ConfigurationOwner"] = value; } }
        public bool bIsDisplayViewType { get { return this[nameof(bIsDisplayViewType)].Flag; } set { this[nameof(bIsDisplayViewType)].Flag = value; } }
        public Object SourceColorSpace { get { return this[nameof(SourceColorSpace)]; } set { this[nameof(SourceColorSpace)] = value; } }
        public Object DestinationColorSpace { get { return this[nameof(DestinationColorSpace)]; } set { this[nameof(DestinationColorSpace)] = value; } }
        public Object Display { get { return this[nameof(Display)]; } set { this[nameof(Display)] = value; } }
        public Object View { get { return this[nameof(View)]; } set { this[nameof(View)] = value; } }
        public EOpenColorIOViewTransformDirection DisplayViewDirection { get { return (EOpenColorIOViewTransformDirection)this[nameof(DisplayViewDirection)].GetValue<int>(); } set { this[nameof(DisplayViewDirection)].SetValue<int>((int)value); } }
        public Object Textures { get { return this[nameof(Textures)]; } set { this[nameof(Textures)] = value; } }
    }
    public class OpenColorIOConfiguration : Object
    {
        public OpenColorIOConfiguration(nint addr) : base(addr) { }
        public FilePath ConfigurationFile { get { return this[nameof(ConfigurationFile)].As<FilePath>(); } set { this["ConfigurationFile"] = value; } }
        public Array<OpenColorIOColorSpace> DesiredColorSpaces { get { return new Array<OpenColorIOColorSpace>(this[nameof(DesiredColorSpaces)].Address); } }
        public Array<OpenColorIODisplayView> DesiredDisplayViews { get { return new Array<OpenColorIODisplayView>(this[nameof(DesiredDisplayViews)].Address); } }
        public Array<OpenColorIOColorTransform> ColorTransforms { get { return new Array<OpenColorIOColorTransform>(this[nameof(ColorTransforms)].Address); } }
    }
    public class OpenColorIODisplayExtensionWrapper : Object
    {
        public OpenColorIODisplayExtensionWrapper(nint addr) : base(addr) { }
        public void SetSceneExtensionIsActiveFunctions(Array<SceneViewExtensionIsActiveFunctor> IsActiveFunctions) { Invoke(nameof(SetSceneExtensionIsActiveFunctions), IsActiveFunctions); }
        public void SetSceneExtensionIsActiveFunction(SceneViewExtensionIsActiveFunctor IsActiveFunction) { Invoke(nameof(SetSceneExtensionIsActiveFunction), IsActiveFunction); }
        public void SetOpenColorIOConfiguration(OpenColorIODisplayConfiguration InDisplayConfiguration) { Invoke(nameof(SetOpenColorIOConfiguration), InDisplayConfiguration); }
        public void RemoveSceneExtension() { Invoke(nameof(RemoveSceneExtension)); }
        public OpenColorIODisplayExtensionWrapper CreateOpenColorIODisplayExtension(OpenColorIODisplayConfiguration InDisplayConfiguration, SceneViewExtensionIsActiveFunctor IsActiveFunction) { return Invoke<OpenColorIODisplayExtensionWrapper>(nameof(CreateOpenColorIODisplayExtension), InDisplayConfiguration, IsActiveFunction); }
        public OpenColorIODisplayExtensionWrapper CreateInGameOpenColorIODisplayExtension(OpenColorIODisplayConfiguration InDisplayConfiguration) { return Invoke<OpenColorIODisplayExtensionWrapper>(nameof(CreateInGameOpenColorIODisplayExtension), InDisplayConfiguration); }
    }
    public enum EOpenColorIOViewTransformDirection : int
    {
        Forward = 0,
        Inverse = 1,
        EOpenColorIOViewTransformDirection_MAX = 2,
    }
    public class OpenColorIOColorSpace : Object
    {
        public OpenColorIOColorSpace(nint addr) : base(addr) { }
        public Object ColorSpaceName { get { return this[nameof(ColorSpaceName)]; } set { this[nameof(ColorSpaceName)] = value; } }
        public int ColorSpaceIndex { get { return this[nameof(ColorSpaceIndex)].GetValue<int>(); } set { this[nameof(ColorSpaceIndex)].SetValue<int>(value); } }
        public Object FamilyName { get { return this[nameof(FamilyName)]; } set { this[nameof(FamilyName)] = value; } }
    }
    public class OpenColorIODisplayView : Object
    {
        public OpenColorIODisplayView(nint addr) : base(addr) { }
        public Object Display { get { return this[nameof(Display)]; } set { this[nameof(Display)] = value; } }
        public Object View { get { return this[nameof(View)]; } set { this[nameof(View)] = value; } }
    }
    public class OpenColorIOColorConversionSettings : Object
    {
        public OpenColorIOColorConversionSettings(nint addr) : base(addr) { }
        public OpenColorIOConfiguration ConfigurationSource { get { return this[nameof(ConfigurationSource)].As<OpenColorIOConfiguration>(); } set { this["ConfigurationSource"] = value; } }
        public OpenColorIOColorSpace SourceColorSpace { get { return this[nameof(SourceColorSpace)].As<OpenColorIOColorSpace>(); } set { this["SourceColorSpace"] = value; } }
        public OpenColorIOColorSpace DestinationColorSpace { get { return this[nameof(DestinationColorSpace)].As<OpenColorIOColorSpace>(); } set { this["DestinationColorSpace"] = value; } }
        public OpenColorIODisplayView DestinationDisplayView { get { return this[nameof(DestinationDisplayView)].As<OpenColorIODisplayView>(); } set { this["DestinationDisplayView"] = value; } }
        public EOpenColorIOViewTransformDirection DisplayViewDirection { get { return (EOpenColorIOViewTransformDirection)this[nameof(DisplayViewDirection)].GetValue<int>(); } set { this[nameof(DisplayViewDirection)].SetValue<int>((int)value); } }
    }
    public class OpenColorIODisplayConfiguration : Object
    {
        public OpenColorIODisplayConfiguration(nint addr) : base(addr) { }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public OpenColorIOColorConversionSettings ColorConfiguration { get { return this[nameof(ColorConfiguration)].As<OpenColorIOColorConversionSettings>(); } set { this["ColorConfiguration"] = value; } }
    }
}
