using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.EngineSettingsSDK
{
    public class ConsoleSettings : Object
    {
        public ConsoleSettings(nint addr) : base(addr) { }
        public int MaxScrollbackSize { get { return this[nameof(MaxScrollbackSize)].GetValue<int>(); } set { this[nameof(MaxScrollbackSize)].SetValue<int>(value); } }
        public Array<AutoCompleteCommand> ManualAutoCompleteList { get { return new Array<AutoCompleteCommand>(this[nameof(ManualAutoCompleteList)].Address); } }
        public Array<Object> AutoCompleteMapPaths { get { return new Array<Object>(this[nameof(AutoCompleteMapPaths)].Address); } }
        public float BackgroundOpacityPercentage { get { return this[nameof(BackgroundOpacityPercentage)].GetValue<float>(); } set { this[nameof(BackgroundOpacityPercentage)].SetValue<float>(value); } }
        public bool bOrderTopToBottom { get { return this[nameof(bOrderTopToBottom)].Flag; } set { this[nameof(bOrderTopToBottom)].Flag = value; } }
        public bool bDisplayHelpInAutoComplete { get { return this[nameof(bDisplayHelpInAutoComplete)].Flag; } set { this[nameof(bDisplayHelpInAutoComplete)].Flag = value; } }
        public Color InputColor { get { return this[nameof(InputColor)].As<Color>(); } set { this["InputColor"] = value; } }
        public Color HistoryColor { get { return this[nameof(HistoryColor)].As<Color>(); } set { this["HistoryColor"] = value; } }
        public Color AutoCompleteCommandColor { get { return this[nameof(AutoCompleteCommandColor)].As<Color>(); } set { this["AutoCompleteCommandColor"] = value; } }
        public Color AutoCompleteCVarColor { get { return this[nameof(AutoCompleteCVarColor)].As<Color>(); } set { this["AutoCompleteCVarColor"] = value; } }
        public Color AutoCompleteFadedColor { get { return this[nameof(AutoCompleteFadedColor)].As<Color>(); } set { this["AutoCompleteFadedColor"] = value; } }
    }
    public class GameMapsSettings : Object
    {
        public GameMapsSettings(nint addr) : base(addr) { }
        public Object LocalMapOptions { get { return this[nameof(LocalMapOptions)]; } set { this[nameof(LocalMapOptions)] = value; } }
        public SoftObjectPath TransitionMap { get { return this[nameof(TransitionMap)].As<SoftObjectPath>(); } set { this["TransitionMap"] = value; } }
        public bool bUseSplitscreen { get { return this[nameof(bUseSplitscreen)].Flag; } set { this[nameof(bUseSplitscreen)].Flag = value; } }
        public byte TwoPlayerSplitscreenLayout { get { return this[nameof(TwoPlayerSplitscreenLayout)].GetValue<byte>(); } set { this[nameof(TwoPlayerSplitscreenLayout)].SetValue<byte>(value); } }
        public byte ThreePlayerSplitscreenLayout { get { return this[nameof(ThreePlayerSplitscreenLayout)].GetValue<byte>(); } set { this[nameof(ThreePlayerSplitscreenLayout)].SetValue<byte>(value); } }
        public EFourPlayerSplitScreenType FourPlayerSplitscreenLayout { get { return (EFourPlayerSplitScreenType)this[nameof(FourPlayerSplitscreenLayout)].GetValue<int>(); } set { this[nameof(FourPlayerSplitscreenLayout)].SetValue<int>((int)value); } }
        public bool bOffsetPlayerGamepadIds { get { return this[nameof(bOffsetPlayerGamepadIds)].Flag; } set { this[nameof(bOffsetPlayerGamepadIds)].Flag = value; } }
        public SoftClassPath GameInstanceClass { get { return this[nameof(GameInstanceClass)].As<SoftClassPath>(); } set { this["GameInstanceClass"] = value; } }
        public SoftObjectPath GameDefaultMap { get { return this[nameof(GameDefaultMap)].As<SoftObjectPath>(); } set { this["GameDefaultMap"] = value; } }
        public SoftObjectPath ServerDefaultMap { get { return this[nameof(ServerDefaultMap)].As<SoftObjectPath>(); } set { this["ServerDefaultMap"] = value; } }
        public SoftClassPath GlobalDefaultGameMode { get { return this[nameof(GlobalDefaultGameMode)].As<SoftClassPath>(); } set { this["GlobalDefaultGameMode"] = value; } }
        public SoftClassPath GlobalDefaultServerGameMode { get { return this[nameof(GlobalDefaultServerGameMode)].As<SoftClassPath>(); } set { this["GlobalDefaultServerGameMode"] = value; } }
        public Array<GameModeName> GameModeMapPrefixes { get { return new Array<GameModeName>(this[nameof(GameModeMapPrefixes)].Address); } }
        public Array<GameModeName> GameModeClassAliases { get { return new Array<GameModeName>(this[nameof(GameModeClassAliases)].Address); } }
        public void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer) { Invoke(nameof(SetSkipAssigningGamepadToPlayer1), bSkipFirstPlayer); }
        public bool GetSkipAssigningGamepadToPlayer1() { return Invoke<bool>(nameof(GetSkipAssigningGamepadToPlayer1)); }
        public GameMapsSettings GetGameMapsSettings() { return Invoke<GameMapsSettings>(nameof(GetGameMapsSettings)); }
    }
    public class GameNetworkManagerSettings : Object
    {
        public GameNetworkManagerSettings(nint addr) : base(addr) { }
        public int MinDynamicBandwidth { get { return this[nameof(MinDynamicBandwidth)].GetValue<int>(); } set { this[nameof(MinDynamicBandwidth)].SetValue<int>(value); } }
        public int MaxDynamicBandwidth { get { return this[nameof(MaxDynamicBandwidth)].GetValue<int>(); } set { this[nameof(MaxDynamicBandwidth)].SetValue<int>(value); } }
        public int TotalNetBandwidth { get { return this[nameof(TotalNetBandwidth)].GetValue<int>(); } set { this[nameof(TotalNetBandwidth)].SetValue<int>(value); } }
        public int BadPingThreshold { get { return this[nameof(BadPingThreshold)].GetValue<int>(); } set { this[nameof(BadPingThreshold)].SetValue<int>(value); } }
        public bool bIsStandbyCheckingEnabled { get { return this[nameof(bIsStandbyCheckingEnabled)].Flag; } set { this[nameof(bIsStandbyCheckingEnabled)].Flag = value; } }
        public float StandbyRxCheatTime { get { return this[nameof(StandbyRxCheatTime)].GetValue<float>(); } set { this[nameof(StandbyRxCheatTime)].SetValue<float>(value); } }
        public float StandbyTxCheatTime { get { return this[nameof(StandbyTxCheatTime)].GetValue<float>(); } set { this[nameof(StandbyTxCheatTime)].SetValue<float>(value); } }
        public float PercentMissingForRxStandby { get { return this[nameof(PercentMissingForRxStandby)].GetValue<float>(); } set { this[nameof(PercentMissingForRxStandby)].SetValue<float>(value); } }
        public float PercentMissingForTxStandby { get { return this[nameof(PercentMissingForTxStandby)].GetValue<float>(); } set { this[nameof(PercentMissingForTxStandby)].SetValue<float>(value); } }
        public float PercentForBadPing { get { return this[nameof(PercentForBadPing)].GetValue<float>(); } set { this[nameof(PercentForBadPing)].SetValue<float>(value); } }
        public float JoinInProgressStandbyWaitTime { get { return this[nameof(JoinInProgressStandbyWaitTime)].GetValue<float>(); } set { this[nameof(JoinInProgressStandbyWaitTime)].SetValue<float>(value); } }
    }
    public class GameSessionSettings : Object
    {
        public GameSessionSettings(nint addr) : base(addr) { }
        public int MaxSpectators { get { return this[nameof(MaxSpectators)].GetValue<int>(); } set { this[nameof(MaxSpectators)].SetValue<int>(value); } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public bool bRequiresPushToTalk { get { return this[nameof(bRequiresPushToTalk)].Flag; } set { this[nameof(bRequiresPushToTalk)].Flag = value; } }
    }
    public class GeneralEngineSettings : Object
    {
        public GeneralEngineSettings(nint addr) : base(addr) { }
    }
    public class GeneralProjectSettings : Object
    {
        public GeneralProjectSettings(nint addr) : base(addr) { }
        public Object CompanyName { get { return this[nameof(CompanyName)]; } set { this[nameof(CompanyName)] = value; } }
        public Object CompanyDistinguishedName { get { return this[nameof(CompanyDistinguishedName)]; } set { this[nameof(CompanyDistinguishedName)] = value; } }
        public Object CopyrightNotice { get { return this[nameof(CopyrightNotice)]; } set { this[nameof(CopyrightNotice)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Homepage { get { return this[nameof(Homepage)]; } set { this[nameof(Homepage)] = value; } }
        public Object LicensingTerms { get { return this[nameof(LicensingTerms)]; } set { this[nameof(LicensingTerms)] = value; } }
        public Object PrivacyPolicy { get { return this[nameof(PrivacyPolicy)]; } set { this[nameof(PrivacyPolicy)] = value; } }
        public Guid ProjectID { get { return this[nameof(ProjectID)].As<Guid>(); } set { this["ProjectID"] = value; } }
        public Object ProjectName { get { return this[nameof(ProjectName)]; } set { this[nameof(ProjectName)] = value; } }
        public Object ProjectVersion { get { return this[nameof(ProjectVersion)]; } set { this[nameof(ProjectVersion)] = value; } }
        public Object SupportContact { get { return this[nameof(SupportContact)]; } set { this[nameof(SupportContact)] = value; } }
        public Object ProjectDisplayedTitle { get { return this[nameof(ProjectDisplayedTitle)]; } set { this[nameof(ProjectDisplayedTitle)] = value; } }
        public Object ProjectDebugTitleInfo { get { return this[nameof(ProjectDebugTitleInfo)]; } set { this[nameof(ProjectDebugTitleInfo)] = value; } }
        public bool bShouldWindowPreserveAspectRatio { get { return this[nameof(bShouldWindowPreserveAspectRatio)].Flag; } set { this[nameof(bShouldWindowPreserveAspectRatio)].Flag = value; } }
        public bool bUseBorderlessWindow { get { return this[nameof(bUseBorderlessWindow)].Flag; } set { this[nameof(bUseBorderlessWindow)].Flag = value; } }
        public bool bStartInVR { get { return this[nameof(bStartInVR)].Flag; } set { this[nameof(bStartInVR)].Flag = value; } }
        public bool bAllowWindowResize { get { return this[nameof(bAllowWindowResize)].Flag; } set { this[nameof(bAllowWindowResize)].Flag = value; } }
        public bool bAllowClose { get { return this[nameof(bAllowClose)].Flag; } set { this[nameof(bAllowClose)].Flag = value; } }
        public bool bAllowMaximize { get { return this[nameof(bAllowMaximize)].Flag; } set { this[nameof(bAllowMaximize)].Flag = value; } }
        public bool bAllowMinimize { get { return this[nameof(bAllowMinimize)].Flag; } set { this[nameof(bAllowMinimize)].Flag = value; } }
        public float EyeOffsetForFakeStereoRenderingDevice { get { return this[nameof(EyeOffsetForFakeStereoRenderingDevice)].GetValue<float>(); } set { this[nameof(EyeOffsetForFakeStereoRenderingDevice)].SetValue<float>(value); } }
        public float FOVForFakeStereoRenderingDevice { get { return this[nameof(FOVForFakeStereoRenderingDevice)].GetValue<float>(); } set { this[nameof(FOVForFakeStereoRenderingDevice)].SetValue<float>(value); } }
    }
    public class HudSettings : Object
    {
        public HudSettings(nint addr) : base(addr) { }
        public bool bShowHUD { get { return this[nameof(bShowHUD)].Flag; } set { this[nameof(bShowHUD)].Flag = value; } }
        public Array<Object> DebugDisplay { get { return new Array<Object>(this[nameof(DebugDisplay)].Address); } }
    }
    public enum ETwoPlayerSplitScreenType : int
    {
        Horizontal = 0,
        Vertical = 1,
        ETwoPlayerSplitScreenType_MAX = 2,
    }
    public enum EThreePlayerSplitScreenType : int
    {
        FavorTop = 0,
        FavorBottom = 1,
        Vertical = 2,
        Horizontal = 3,
        EThreePlayerSplitScreenType_MAX = 4,
    }
    public enum EFourPlayerSplitScreenType : int
    {
        Grid = 0,
        Vertical = 1,
        Horizontal = 2,
        EFourPlayerSplitScreenType_MAX = 3,
    }
    public enum ESubLevelStripMode : int
    {
        ExactClass = 0,
        IsChildOf = 1,
        ESubLevelStripMode_MAX = 2,
    }
    public class AutoCompleteCommand : Object
    {
        public AutoCompleteCommand(nint addr) : base(addr) { }
        public Object Command { get { return this[nameof(Command)]; } set { this[nameof(Command)] = value; } }
        public Object Desc { get { return this[nameof(Desc)]; } set { this[nameof(Desc)] = value; } }
    }
    public class GameModeName : Object
    {
        public GameModeName(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public SoftClassPath GameMode { get { return this[nameof(GameMode)].As<SoftClassPath>(); } set { this["GameMode"] = value; } }
    }
    public class TemplateMapInfoOverride : Object
    {
        public TemplateMapInfoOverride(nint addr) : base(addr) { }
        public SoftObjectPath Thumbnail { get { return this[nameof(Thumbnail)].As<SoftObjectPath>(); } set { this["Thumbnail"] = value; } }
        public SoftObjectPath Map { get { return this[nameof(Map)].As<SoftObjectPath>(); } set { this["Map"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
    }
}
