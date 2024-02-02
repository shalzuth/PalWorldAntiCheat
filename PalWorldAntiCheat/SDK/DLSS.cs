using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.DLSSSDK
{
    public class DLSSOverrideSettings : Object
    {
        public DLSSOverrideSettings(nint addr) : base(addr) { }
        public EDLSSSettingOverride EnableDLSSInEditorViewportsOverride { get { return (EDLSSSettingOverride)this[nameof(EnableDLSSInEditorViewportsOverride)].GetValue<int>(); } set { this[nameof(EnableDLSSInEditorViewportsOverride)].SetValue<int>((int)value); } }
        public EDLSSSettingOverride EnableDLSSInPlayInEditorViewportsOverride { get { return (EDLSSSettingOverride)this[nameof(EnableDLSSInPlayInEditorViewportsOverride)].GetValue<int>(); } set { this[nameof(EnableDLSSInPlayInEditorViewportsOverride)].SetValue<int>((int)value); } }
        public bool bShowDLSSIncompatiblePluginsToolsWarnings { get { return this[nameof(bShowDLSSIncompatiblePluginsToolsWarnings)].Flag; } set { this[nameof(bShowDLSSIncompatiblePluginsToolsWarnings)].Flag = value; } }
        public EDLSSSettingOverride ShowDLSSSDebugOnScreenMessages { get { return (EDLSSSettingOverride)this[nameof(ShowDLSSSDebugOnScreenMessages)].GetValue<int>(); } set { this[nameof(ShowDLSSSDebugOnScreenMessages)].SetValue<int>((int)value); } }
    }
    public class DLSSSettings : Object
    {
        public DLSSSettings(nint addr) : base(addr) { }
        public bool bEnableDLSSD3D12 { get { return this[nameof(bEnableDLSSD3D12)].Flag; } set { this[nameof(bEnableDLSSD3D12)].Flag = value; } }
        public bool bEnableDLSSD3D11 { get { return this[nameof(bEnableDLSSD3D11)].Flag; } set { this[nameof(bEnableDLSSD3D11)].Flag = value; } }
        public bool bEnableDLSSVulkan { get { return this[nameof(bEnableDLSSVulkan)].Flag; } set { this[nameof(bEnableDLSSVulkan)].Flag = value; } }
        public bool bEnableDLSSInEditorViewports { get { return this[nameof(bEnableDLSSInEditorViewports)].Flag; } set { this[nameof(bEnableDLSSInEditorViewports)].Flag = value; } }
        public bool bEnableDLSSInPlayInEditorViewports { get { return this[nameof(bEnableDLSSInPlayInEditorViewports)].Flag; } set { this[nameof(bEnableDLSSInPlayInEditorViewports)].Flag = value; } }
        public bool bShowDLSSSDebugOnScreenMessages { get { return this[nameof(bShowDLSSSDebugOnScreenMessages)].Flag; } set { this[nameof(bShowDLSSSDebugOnScreenMessages)].Flag = value; } }
        public Object GenericDLSSBinaryPath { get { return this[nameof(GenericDLSSBinaryPath)]; } set { this[nameof(GenericDLSSBinaryPath)] = value; } }
        public bool bGenericDLSSBinaryExists { get { return this[nameof(bGenericDLSSBinaryExists)].Flag; } set { this[nameof(bGenericDLSSBinaryExists)].Flag = value; } }
        public uint NVIDIANGXApplicationId { get { return this[nameof(NVIDIANGXApplicationId)].GetValue<uint>(); } set { this[nameof(NVIDIANGXApplicationId)].SetValue<uint>(value); } }
        public Object CustomDLSSBinaryPath { get { return this[nameof(CustomDLSSBinaryPath)]; } set { this[nameof(CustomDLSSBinaryPath)] = value; } }
        public bool bCustomDLSSBinaryExists { get { return this[nameof(bCustomDLSSBinaryExists)].Flag; } set { this[nameof(bCustomDLSSBinaryExists)].Flag = value; } }
        public bool bAllowOTAUpdate { get { return this[nameof(bAllowOTAUpdate)].Flag; } set { this[nameof(bAllowOTAUpdate)].Flag = value; } }
        public bool bShowDLSSIncompatiblePluginsToolsWarnings { get { return this[nameof(bShowDLSSIncompatiblePluginsToolsWarnings)].Flag; } set { this[nameof(bShowDLSSIncompatiblePluginsToolsWarnings)].Flag = value; } }
        public EDLSSPreset DLAAPreset { get { return (EDLSSPreset)this[nameof(DLAAPreset)].GetValue<int>(); } set { this[nameof(DLAAPreset)].SetValue<int>((int)value); } }
        public EDLSSPreset DLSSQualityPreset { get { return (EDLSSPreset)this[nameof(DLSSQualityPreset)].GetValue<int>(); } set { this[nameof(DLSSQualityPreset)].SetValue<int>((int)value); } }
        public EDLSSPreset DLSSBalancedPreset { get { return (EDLSSPreset)this[nameof(DLSSBalancedPreset)].GetValue<int>(); } set { this[nameof(DLSSBalancedPreset)].SetValue<int>((int)value); } }
        public EDLSSPreset DLSSPerformancePreset { get { return (EDLSSPreset)this[nameof(DLSSPerformancePreset)].GetValue<int>(); } set { this[nameof(DLSSPerformancePreset)].SetValue<int>((int)value); } }
        public EDLSSPreset DLSSUltraPerformancePreset { get { return (EDLSSPreset)this[nameof(DLSSUltraPerformancePreset)].GetValue<int>(); } set { this[nameof(DLSSUltraPerformancePreset)].SetValue<int>((int)value); } }
    }
    public enum EDLSSSettingOverride : int
    {
        Enabled = 0,
        Disabled = 1,
        UseProjectSettings = 2,
        EDLSSSettingOverride_MAX = 3,
    }
    public enum EDLSSPreset : int
    {
        Default = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        EDLSSPreset_MAX = 8,
    }
}
