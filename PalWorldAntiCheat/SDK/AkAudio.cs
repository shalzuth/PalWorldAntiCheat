using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.UMGSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.PhysicsCoreSDK;
namespace SDK.Script.AkAudioSDK
{
    public class AkPortalComponent : SceneComponent
    {
        public AkPortalComponent(nint addr) : base(addr) { }
        public bool bDynamic { get { return this[nameof(bDynamic)].Flag; } set { this[nameof(bDynamic)].Flag = value; } }
        public AkAcousticPortalState InitialState { get { return (AkAcousticPortalState)this[nameof(InitialState)].GetValue<int>(); } set { this[nameof(InitialState)].SetValue<int>((int)value); } }
        public float ObstructionRefreshInterval { get { return this[nameof(ObstructionRefreshInterval)].GetValue<float>(); } set { this[nameof(ObstructionRefreshInterval)].SetValue<float>(value); } }
        public byte ObstructionCollisionChannel { get { return this[nameof(ObstructionCollisionChannel)].GetValue<byte>(); } set { this[nameof(ObstructionCollisionChannel)].SetValue<byte>(value); } }
        public bool PortalPlacementValid() { return Invoke<bool>(nameof(PortalPlacementValid)); }
        public void OpenPortal() { Invoke(nameof(OpenPortal)); }
        public PrimitiveComponent GetPrimitiveParent() { return Invoke<PrimitiveComponent>(nameof(GetPrimitiveParent)); }
        public AkAcousticPortalState GetCurrentState() { return Invoke<AkAcousticPortalState>(nameof(GetCurrentState)); }
        public void ClosePortal() { Invoke(nameof(ClosePortal)); }
    }
    public class AkAcousticPortal : Volume
    {
        public AkAcousticPortal(nint addr) : base(addr) { }
        public AkPortalComponent Portal { get { return this[nameof(Portal)].As<AkPortalComponent>(); } set { this["Portal"] = value; } }
        public AkAcousticPortalState InitialState { get { return (AkAcousticPortalState)this[nameof(InitialState)].GetValue<int>(); } set { this[nameof(InitialState)].SetValue<int>((int)value); } }
        public bool bRequiresStateMigration { get { return this[nameof(bRequiresStateMigration)].Flag; } set { this[nameof(bRequiresStateMigration)].Flag = value; } }
        public void OpenPortal() { Invoke(nameof(OpenPortal)); }
        public AkAcousticPortalState GetCurrentState() { return Invoke<AkAcousticPortalState>(nameof(GetCurrentState)); }
        public void ClosePortal() { Invoke(nameof(ClosePortal)); }
    }
    public class AkAudioType : Object
    {
        public AkAudioType(nint addr) : base(addr) { }
        public uint ShortID { get { return this[nameof(ShortID)].GetValue<uint>(); } set { this[nameof(ShortID)].SetValue<uint>(value); } }
        public Array<Object> UserData { get { return new Array<Object>(this[nameof(UserData)].Address); } }
    }
    public class AkAcousticTexture : AkAudioType
    {
        public AkAcousticTexture(nint addr) : base(addr) { }
    }
    public class AkAcousticTextureSetComponent : SceneComponent
    {
        public AkAcousticTextureSetComponent(nint addr) : base(addr) { }
    }
    public class AkAmbientSound : Actor
    {
        public AkAmbientSound(nint addr) : base(addr) { }
        public AkAudioEvent AkAudioEvent { get { return this[nameof(AkAudioEvent)].As<AkAudioEvent>(); } set { this["AkAudioEvent"] = value; } }
        public AkComponent AkComponent { get { return this[nameof(AkComponent)].As<AkComponent>(); } set { this["AkComponent"] = value; } }
        public bool StopWhenOwnerIsDestroyed { get { return this[nameof(StopWhenOwnerIsDestroyed)].Flag; } set { this[nameof(StopWhenOwnerIsDestroyed)].Flag = value; } }
        public bool AutoPost { get { return this[nameof(AutoPost)].Flag; } set { this[nameof(AutoPost)].Flag = value; } }
        public void StopAmbientSound() { Invoke(nameof(StopAmbientSound)); }
        public void StartAmbientSound() { Invoke(nameof(StartAmbientSound)); }
    }
    public class AkAndroidInitializationSettings : Object
    {
        public AkAndroidInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkAndroidAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAndroidAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkPlatformInfo : Object
    {
        public AkPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkAndroidPlatformInfo : AkPlatformInfo
    {
        public AkAndroidPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkAssetBase : AkAudioType
    {
        public AkAssetBase(nint addr) : base(addr) { }
        public AkAssetPlatformData PlatformAssetData { get { return this[nameof(PlatformAssetData)].As<AkAssetPlatformData>(); } set { this["PlatformAssetData"] = value; } }
    }
    public class AkAssetData : Object
    {
        public AkAssetData(nint addr) : base(addr) { }
        public uint CachedHash { get { return this[nameof(CachedHash)].GetValue<uint>(); } set { this[nameof(CachedHash)].SetValue<uint>(value); } }
        public Object BankLanguage { get { return this[nameof(BankLanguage)]; } set { this[nameof(BankLanguage)] = value; } }
    }
    public class AkAssetDataWithMedia : AkAssetData
    {
        public AkAssetDataWithMedia(nint addr) : base(addr) { }
        public Array<AkMediaAsset> MediaList { get { return new Array<AkMediaAsset>(this[nameof(MediaList)].Address); } }
    }
    public class AkAssetPlatformData : Object
    {
        public AkAssetPlatformData(nint addr) : base(addr) { }
        public AkAssetData CurrentAssetData { get { return this[nameof(CurrentAssetData)].As<AkAssetData>(); } set { this["CurrentAssetData"] = value; } }
    }
    public class AkAssetDataSwitchContainerData : Object
    {
        public AkAssetDataSwitchContainerData(nint addr) : base(addr) { }
        public Object GroupValue { get { return this[nameof(GroupValue)]; } set { this[nameof(GroupValue)] = value; } }
        public AkGroupValue DefaultGroupValue { get { return this[nameof(DefaultGroupValue)].As<AkGroupValue>(); } set { this["DefaultGroupValue"] = value; } }
        public Array<AkMediaAsset> MediaList { get { return new Array<AkMediaAsset>(this[nameof(MediaList)].Address); } }
        public Array<AkAssetDataSwitchContainerData> Children { get { return new Array<AkAssetDataSwitchContainerData>(this[nameof(Children)].Address); } }
    }
    public class AkAssetDataSwitchContainer : AkAssetDataWithMedia
    {
        public AkAssetDataSwitchContainer(nint addr) : base(addr) { }
        public Array<AkAssetDataSwitchContainerData> SwitchContainers { get { return new Array<AkAssetDataSwitchContainerData>(this[nameof(SwitchContainers)].Address); } }
        public AkGroupValue DefaultGroupValue { get { return this[nameof(DefaultGroupValue)].As<AkGroupValue>(); } set { this["DefaultGroupValue"] = value; } }
    }
    public class AkAudioEventData : AkAssetDataSwitchContainer
    {
        public AkAudioEventData(nint addr) : base(addr) { }
        public float MaxAttenuationRadius { get { return this[nameof(MaxAttenuationRadius)].GetValue<float>(); } set { this[nameof(MaxAttenuationRadius)].SetValue<float>(value); } }
        public bool IsInfinite { get { return this[nameof(IsInfinite)].Flag; } set { this[nameof(IsInfinite)].Flag = value; } }
        public float MinimumDuration { get { return this[nameof(MinimumDuration)].GetValue<float>(); } set { this[nameof(MinimumDuration)].SetValue<float>(value); } }
        public float MaximumDuration { get { return this[nameof(MaximumDuration)].GetValue<float>(); } set { this[nameof(MaximumDuration)].SetValue<float>(value); } }
        public Object LocalizedMedia { get { return this[nameof(LocalizedMedia)]; } set { this[nameof(LocalizedMedia)] = value; } }
        public Object PostedEvents { get { return this[nameof(PostedEvents)]; } set { this[nameof(PostedEvents)] = value; } }
        public Object UserDefinedSends { get { return this[nameof(UserDefinedSends)]; } set { this[nameof(UserDefinedSends)] = value; } }
        public Object PostedTriggers { get { return this[nameof(PostedTriggers)]; } set { this[nameof(PostedTriggers)] = value; } }
        public Object GroupValues { get { return this[nameof(GroupValues)]; } set { this[nameof(GroupValues)] = value; } }
    }
    public class AkAudioBank : AkAssetBase
    {
        public AkAudioBank(nint addr) : base(addr) { }
        public bool AutoLoad { get { return this[nameof(AutoLoad)].Flag; } set { this[nameof(AutoLoad)].Flag = value; } }
        public Object LocalizedPlatformAssetDataMap { get { return this[nameof(LocalizedPlatformAssetDataMap)]; } set { this[nameof(LocalizedPlatformAssetDataMap)] = value; } }
        public Object LinkedAkEvents { get { return this[nameof(LinkedAkEvents)]; } set { this[nameof(LinkedAkEvents)] = value; } }
        public AkAssetPlatformData CurrentLocalizedPlatformAssetData { get { return this[nameof(CurrentLocalizedPlatformAssetData)].As<AkAssetPlatformData>(); } set { this["CurrentLocalizedPlatformAssetData"] = value; } }
    }
    public class AkAudioEvent : AkAssetBase
    {
        public AkAudioEvent(nint addr) : base(addr) { }
        public Object LocalizedPlatformAssetDataMap { get { return this[nameof(LocalizedPlatformAssetDataMap)]; } set { this[nameof(LocalizedPlatformAssetDataMap)] = value; } }
        public AkAudioBank RequiredBank { get { return this[nameof(RequiredBank)].As<AkAudioBank>(); } set { this["RequiredBank"] = value; } }
        public AkAssetPlatformData CurrentLocalizedPlatformData { get { return this[nameof(CurrentLocalizedPlatformData)].As<AkAssetPlatformData>(); } set { this["CurrentLocalizedPlatformData"] = value; } }
        public float MaxAttenuationRadius { get { return this[nameof(MaxAttenuationRadius)].GetValue<float>(); } set { this[nameof(MaxAttenuationRadius)].SetValue<float>(value); } }
        public bool IsInfinite { get { return this[nameof(IsInfinite)].Flag; } set { this[nameof(IsInfinite)].Flag = value; } }
        public float MinimumDuration { get { return this[nameof(MinimumDuration)].GetValue<float>(); } set { this[nameof(MinimumDuration)].SetValue<float>(value); } }
        public float MaximumDuration { get { return this[nameof(MaximumDuration)].GetValue<float>(); } set { this[nameof(MaximumDuration)].SetValue<float>(value); } }
        public float GetMinimumDuration() { return Invoke<float>(nameof(GetMinimumDuration)); }
        public float GetMaximumDuration() { return Invoke<float>(nameof(GetMaximumDuration)); }
        public float GetMaxAttenuationRadius() { return Invoke<float>(nameof(GetMaxAttenuationRadius)); }
        public bool GetIsInfinite() { return Invoke<bool>(nameof(GetIsInfinite)); }
    }
    public class AkGameObject : SceneComponent
    {
        public AkGameObject(nint addr) : base(addr) { }
        public AkAudioEvent AkAudioEvent { get { return this[nameof(AkAudioEvent)].As<AkAudioEvent>(); } set { this["AkAudioEvent"] = value; } }
        public Object EventName { get { return this[nameof(EventName)]; } set { this[nameof(EventName)] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetRTPCValue(AkRtpc RTPCValue, float Value, int InterpolationTimeMs, Object RTPC) { Invoke(nameof(SetRTPCValue), RTPCValue, Value, InterpolationTimeMs, RTPC); }
        public void PostAssociatedAkEventAsync(Object WorldContextObject, int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo, int PlayingID) { Invoke(nameof(PostAssociatedAkEventAsync), WorldContextObject, CallbackMask, PostEventCallback, ExternalSources, LatentInfo, PlayingID); }
        public int PostAssociatedAkEvent(int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources) { return Invoke<int>(nameof(PostAssociatedAkEvent), CallbackMask, PostEventCallback, ExternalSources); }
        public void PostAkEventAsync(Object WorldContextObject, AkAudioEvent AkEvent, int PlayingID, int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { Invoke(nameof(PostAkEventAsync), WorldContextObject, AkEvent, PlayingID, CallbackMask, PostEventCallback, ExternalSources, LatentInfo); }
        public int PostAkEvent(AkAudioEvent AkEvent, int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources, Object in_EventName) { return Invoke<int>(nameof(PostAkEvent), AkEvent, CallbackMask, PostEventCallback, ExternalSources, in_EventName); }
        public void GetRTPCValue(AkRtpc RTPCValue, ERTPCValueType InputValueType, float Value, ERTPCValueType OutputValueType, Object RTPC, int PlayingID) { Invoke(nameof(GetRTPCValue), RTPCValue, InputValueType, Value, OutputValueType, RTPC, PlayingID); }
    }
    public class AkComponent : AkGameObject
    {
        public AkComponent(nint addr) : base(addr) { }
        public bool bUseSpatialAudio { get { return this[nameof(bUseSpatialAudio)].Flag; } set { this[nameof(bUseSpatialAudio)].Flag = value; } }
        public byte OcclusionCollisionChannel { get { return this[nameof(OcclusionCollisionChannel)].GetValue<byte>(); } set { this[nameof(OcclusionCollisionChannel)].SetValue<byte>(value); } }
        public bool EnableSpotReflectors { get { return this[nameof(EnableSpotReflectors)].Flag; } set { this[nameof(EnableSpotReflectors)].Flag = value; } }
        public float OuterRadius { get { return this[nameof(OuterRadius)].GetValue<float>(); } set { this[nameof(OuterRadius)].SetValue<float>(value); } }
        public float InnerRadius { get { return this[nameof(InnerRadius)].GetValue<float>(); } set { this[nameof(InnerRadius)].SetValue<float>(value); } }
        public AkAuxBus EarlyReflectionAuxBus { get { return this[nameof(EarlyReflectionAuxBus)].As<AkAuxBus>(); } set { this["EarlyReflectionAuxBus"] = value; } }
        public Object EarlyReflectionAuxBusName { get { return this[nameof(EarlyReflectionAuxBusName)]; } set { this[nameof(EarlyReflectionAuxBusName)] = value; } }
        public int EarlyReflectionOrder { get { return this[nameof(EarlyReflectionOrder)].GetValue<int>(); } set { this[nameof(EarlyReflectionOrder)].SetValue<int>(value); } }
        public float EarlyReflectionBusSendGain { get { return this[nameof(EarlyReflectionBusSendGain)].GetValue<float>(); } set { this[nameof(EarlyReflectionBusSendGain)].SetValue<float>(value); } }
        public float EarlyReflectionMaxPathLength { get { return this[nameof(EarlyReflectionMaxPathLength)].GetValue<float>(); } set { this[nameof(EarlyReflectionMaxPathLength)].SetValue<float>(value); } }
        public float roomReverbAuxBusGain { get { return this[nameof(roomReverbAuxBusGain)].GetValue<float>(); } set { this[nameof(roomReverbAuxBusGain)].SetValue<float>(value); } }
        public int diffractionMaxEdges { get { return this[nameof(diffractionMaxEdges)].GetValue<int>(); } set { this[nameof(diffractionMaxEdges)].SetValue<int>(value); } }
        public int diffractionMaxPaths { get { return this[nameof(diffractionMaxPaths)].GetValue<int>(); } set { this[nameof(diffractionMaxPaths)].SetValue<int>(value); } }
        public float diffractionMaxPathLength { get { return this[nameof(diffractionMaxPathLength)].GetValue<float>(); } set { this[nameof(diffractionMaxPathLength)].SetValue<float>(value); } }
        public bool DrawFirstOrderReflections { get { return this[nameof(DrawFirstOrderReflections)].Flag; } set { this[nameof(DrawFirstOrderReflections)].Flag = value; } }
        public bool DrawSecondOrderReflections { get { return this[nameof(DrawSecondOrderReflections)].Flag; } set { this[nameof(DrawSecondOrderReflections)].Flag = value; } }
        public bool DrawHigherOrderReflections { get { return this[nameof(DrawHigherOrderReflections)].Flag; } set { this[nameof(DrawHigherOrderReflections)].Flag = value; } }
        public bool DrawDiffraction { get { return this[nameof(DrawDiffraction)].Flag; } set { this[nameof(DrawDiffraction)].Flag = value; } }
        public bool StopWhenOwnerDestroyed { get { return this[nameof(StopWhenOwnerDestroyed)].Flag; } set { this[nameof(StopWhenOwnerDestroyed)].Flag = value; } }
        public float AttenuationScalingFactor { get { return this[nameof(AttenuationScalingFactor)].GetValue<float>(); } set { this[nameof(AttenuationScalingFactor)].SetValue<float>(value); } }
        public float OcclusionRefreshInterval { get { return this[nameof(OcclusionRefreshInterval)].GetValue<float>(); } set { this[nameof(OcclusionRefreshInterval)].SetValue<float>(value); } }
        public bool bUseReverbVolumes { get { return this[nameof(bUseReverbVolumes)].Flag; } set { this[nameof(bUseReverbVolumes)].Flag = value; } }
        public void UseReverbVolumes(bool inUseReverbVolumes) { Invoke(nameof(UseReverbVolumes), inUseReverbVolumes); }
        public void UseEarlyReflections(AkAuxBus AuxBus, int Order, float BusSendGain, float MaxPathLength, bool SpotReflectors, Object AuxBusName) { Invoke(nameof(UseEarlyReflections), AuxBus, Order, BusSendGain, MaxPathLength, SpotReflectors, AuxBusName); }
        public void SetSwitch(AkSwitchValue SwitchValue, Object SwitchGroup, Object SwitchState) { Invoke(nameof(SetSwitch), SwitchValue, SwitchGroup, SwitchState); }
        public void SetStopWhenOwnerDestroyed(bool bStopWhenOwnerDestroyed) { Invoke(nameof(SetStopWhenOwnerDestroyed), bStopWhenOwnerDestroyed); }
        public void SetOutputBusVolume(float BusVolume) { Invoke(nameof(SetOutputBusVolume), BusVolume); }
        public void SetListeners(Array<AkComponent> Listeners) { Invoke(nameof(SetListeners), Listeners); }
        public void SetGameObjectRadius(float in_outerRadius, float in_innerRadius) { Invoke(nameof(SetGameObjectRadius), in_outerRadius, in_innerRadius); }
        public void SetEarlyReflectionsVolume(float SendVolume) { Invoke(nameof(SetEarlyReflectionsVolume), SendVolume); }
        public void SetEarlyReflectionsAuxBus(Object AuxBusName) { Invoke(nameof(SetEarlyReflectionsAuxBus), AuxBusName); }
        public void SetAttenuationScalingFactor(float Value) { Invoke(nameof(SetAttenuationScalingFactor), Value); }
        public void PostTrigger(AkTrigger TriggerValue, Object Trigger) { Invoke(nameof(PostTrigger), TriggerValue, Trigger); }
        public void PostAssociatedAkEventAndWaitForEndAsync(int PlayingID, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { Invoke(nameof(PostAssociatedAkEventAndWaitForEndAsync), PlayingID, ExternalSources, LatentInfo); }
        public int PostAssociatedAkEventAndWaitForEnd(Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { return Invoke<int>(nameof(PostAssociatedAkEventAndWaitForEnd), ExternalSources, LatentInfo); }
        public int PostAkEventByName(Object in_EventName) { return Invoke<int>(nameof(PostAkEventByName), in_EventName); }
        public void PostAkEventAndWaitForEndAsync(AkAudioEvent AkEvent, int PlayingID, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { Invoke(nameof(PostAkEventAndWaitForEndAsync), AkEvent, PlayingID, ExternalSources, LatentInfo); }
        public int PostAkEventAndWaitForEnd(AkAudioEvent AkEvent, Object in_EventName, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { return Invoke<int>(nameof(PostAkEventAndWaitForEnd), AkEvent, in_EventName, ExternalSources, LatentInfo); }
        public float GetAttenuationRadius() { return Invoke<float>(nameof(GetAttenuationRadius)); }
    }
    public class AkAudioInputComponent : AkComponent
    {
        public AkAudioInputComponent(nint addr) : base(addr) { }
        public int PostAssociatedAudioInputEvent() { return Invoke<int>(nameof(PostAssociatedAudioInputEvent)); }
    }
    public class AkAuxBus : AkAssetBase
    {
        public AkAuxBus(nint addr) : base(addr) { }
        public AkAudioBank RequiredBank { get { return this[nameof(RequiredBank)].As<AkAudioBank>(); } set { this["RequiredBank"] = value; } }
    }
    public class AkCheckBox : ContentWidget
    {
        public AkCheckBox(nint addr) : base(addr) { }
        public ECheckBoxState CheckedState { get { return (ECheckBoxState)this[nameof(CheckedState)].GetValue<int>(); } set { this[nameof(CheckedState)].SetValue<int>((int)value); } }
        public Object CheckedStateDelegate { get { return this[nameof(CheckedStateDelegate)]; } set { this[nameof(CheckedStateDelegate)] = value; } }
        public CheckBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<CheckBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public AkBoolPropertyToControl ThePropertyToControl { get { return this[nameof(ThePropertyToControl)].As<AkBoolPropertyToControl>(); } set { this["ThePropertyToControl"] = value; } }
        public AkWwiseItemToControl ItemToControl { get { return this[nameof(ItemToControl)].As<AkWwiseItemToControl>(); } set { this["ItemToControl"] = value; } }
        public Object AkOnCheckStateChanged { get { return this[nameof(AkOnCheckStateChanged)]; } set { this[nameof(AkOnCheckStateChanged)] = value; } }
        public Object OnItemDropped { get { return this[nameof(OnItemDropped)]; } set { this[nameof(OnItemDropped)] = value; } }
        public Object OnPropertyDropped { get { return this[nameof(OnPropertyDropped)]; } set { this[nameof(OnPropertyDropped)] = value; } }
        public void SetIsChecked(bool InIsChecked) { Invoke(nameof(SetIsChecked), InIsChecked); }
        public void SetCheckedState(ECheckBoxState InCheckedState) { Invoke(nameof(SetCheckedState), InCheckedState); }
        public void SetAkItemId(Guid ItemId) { Invoke(nameof(SetAkItemId), ItemId); }
        public void SetAkBoolProperty(Object ItemProperty) { Invoke(nameof(SetAkBoolProperty), ItemProperty); }
        public bool IsPressed() { return Invoke<bool>(nameof(IsPressed)); }
        public bool IsChecked() { return Invoke<bool>(nameof(IsChecked)); }
        public ECheckBoxState GetCheckedState() { return Invoke<ECheckBoxState>(nameof(GetCheckedState)); }
        public Object GetAkProperty() { return Invoke<Object>(nameof(GetAkProperty)); }
        public Guid GetAkItemId() { return Invoke<Guid>(nameof(GetAkItemId)); }
    }
    public class DrawPortalComponent : PrimitiveComponent
    {
        public DrawPortalComponent(nint addr) : base(addr) { }
    }
    public class DrawRoomComponent : PrimitiveComponent
    {
        public DrawRoomComponent(nint addr) : base(addr) { }
    }
    public class AkFolder : AkAudioType
    {
        public AkFolder(nint addr) : base(addr) { }
        public Object UnrealFolderPath { get { return this[nameof(UnrealFolderPath)]; } set { this[nameof(UnrealFolderPath)] = value; } }
        public Object WwiseFolderPath { get { return this[nameof(WwiseFolderPath)]; } set { this[nameof(WwiseFolderPath)] = value; } }
    }
    public class AkGameplayStatics : BlueprintFunctionLibrary
    {
        public AkGameplayStatics(nint addr) : base(addr) { }
        public void UseReverbVolumes(bool inUseReverbVolumes, Actor Actor) { Invoke(nameof(UseReverbVolumes), inUseReverbVolumes, Actor); }
        public void UseEarlyReflections(Actor Actor, AkAuxBus AuxBus, int Order, float BusSendGain, float MaxPathLength, bool SpotReflectors, Object AuxBusName) { Invoke(nameof(UseEarlyReflections), Actor, AuxBus, Order, BusSendGain, MaxPathLength, SpotReflectors, AuxBusName); }
        public void UnloadBankByName(Object BankName) { Invoke(nameof(UnloadBankByName), BankName); }
        public void UnloadBankAsync(AkAudioBank Bank, Object BankUnloadedCallback) { Invoke(nameof(UnloadBankAsync), Bank, BankUnloadedCallback); }
        public void UnloadBank(AkAudioBank Bank, Object BankName, LatentActionInfo LatentInfo, Object WorldContextObject) { Invoke(nameof(UnloadBank), Bank, BankName, LatentInfo, WorldContextObject); }
        public void StopProfilerCapture() { Invoke(nameof(StopProfilerCapture)); }
        public void StopOutputCapture() { Invoke(nameof(StopOutputCapture)); }
        public void StopAllAmbientSounds(Object WorldContextObject) { Invoke(nameof(StopAllAmbientSounds), WorldContextObject); }
        public void StopAll() { Invoke(nameof(StopAll)); }
        public void StopActor(Actor Actor) { Invoke(nameof(StopActor), Actor); }
        public void StartProfilerCapture(Object Filename) { Invoke(nameof(StartProfilerCapture), Filename); }
        public void StartOutputCapture(Object Filename) { Invoke(nameof(StartOutputCapture), Filename); }
        public void StartAllAmbientSounds(Object WorldContextObject) { Invoke(nameof(StartAllAmbientSounds), WorldContextObject); }
        public AkComponent SpawnAkComponentAtLocation(Object WorldContextObject, AkAudioEvent AkEvent, Vector Location, Rotator Orientation, bool AutoPost, Object EventName, bool AutoDestroy) { return Invoke<AkComponent>(nameof(SpawnAkComponentAtLocation), WorldContextObject, AkEvent, Location, Orientation, AutoPost, EventName, AutoDestroy); }
        public void SetSwitch(AkSwitchValue SwitchValue, Actor Actor, Object SwitchGroup, Object SwitchState) { Invoke(nameof(SetSwitch), SwitchValue, Actor, SwitchGroup, SwitchState); }
        public void SetState(AkStateValue StateValue, Object StateGroup, Object State) { Invoke(nameof(SetState), StateValue, StateGroup, State); }
        public void SetSpeakerAngles(Array<float> SpeakerAngles, float HeightAngle, Object DeviceShareset) { Invoke(nameof(SetSpeakerAngles), SpeakerAngles, HeightAngle, DeviceShareset); }
        public void SetRTPCValue(AkRtpc RTPCValue, float Value, int InterpolationTimeMs, Actor Actor, Object RTPC) { Invoke(nameof(SetRTPCValue), RTPCValue, Value, InterpolationTimeMs, Actor, RTPC); }
        public void SetReflectionsOrder(int Order, bool RefreshPaths) { Invoke(nameof(SetReflectionsOrder), Order, RefreshPaths); }
        public void SetPortalToPortalObstruction(AkPortalComponent PortalComponent0, AkPortalComponent PortalComponent1, float ObstructionValue) { Invoke(nameof(SetPortalToPortalObstruction), PortalComponent0, PortalComponent1, ObstructionValue); }
        public void SetPortalObstructionAndOcclusion(AkPortalComponent PortalComponent, float ObstructionValue, float OcclusionValue) { Invoke(nameof(SetPortalObstructionAndOcclusion), PortalComponent, ObstructionValue, OcclusionValue); }
        public void SetPanningRule(PanningRule PanRule) { Invoke(nameof(SetPanningRule), PanRule); }
        public void SetOutputBusVolume(float BusVolume, Actor Actor) { Invoke(nameof(SetOutputBusVolume), BusVolume, Actor); }
        public void SetOcclusionScalingFactor(float ScalingFactor) { Invoke(nameof(SetOcclusionScalingFactor), ScalingFactor); }
        public void SetOcclusionRefreshInterval(float RefreshInterval, Actor Actor) { Invoke(nameof(SetOcclusionRefreshInterval), RefreshInterval, Actor); }
        public void SetMultiplePositions(AkComponent GameObjectAkComponent, Array<Transform> Positions, AkMultiPositionType MultiPositionType) { Invoke(nameof(SetMultiplePositions), GameObjectAkComponent, Positions, MultiPositionType); }
        public void SetMultipleChannelMaskEmitterPositions(AkComponent GameObjectAkComponent, Array<AkChannelMask> ChannelMasks, Array<Transform> Positions, AkMultiPositionType MultiPositionType) { Invoke(nameof(SetMultipleChannelMaskEmitterPositions), GameObjectAkComponent, ChannelMasks, Positions, MultiPositionType); }
        public void SetMultipleChannelEmitterPositions(AkComponent GameObjectAkComponent, Array<AkChannelConfiguration> ChannelMasks, Array<Transform> Positions, AkMultiPositionType MultiPositionType) { Invoke(nameof(SetMultipleChannelEmitterPositions), GameObjectAkComponent, ChannelMasks, Positions, MultiPositionType); }
        public void SetGameObjectToPortalObstruction(AkComponent GameObjectAkComponent, AkPortalComponent PortalComponent, float ObstructionValue) { Invoke(nameof(SetGameObjectToPortalObstruction), GameObjectAkComponent, PortalComponent, ObstructionValue); }
        public void SetCurrentAudioCultureAsync(Object AudioCulture, Object Completed) { Invoke(nameof(SetCurrentAudioCultureAsync), AudioCulture, Completed); }
        public void SetCurrentAudioCulture(Object AudioCulture, LatentActionInfo LatentInfo, Object WorldContextObject) { Invoke(nameof(SetCurrentAudioCulture), AudioCulture, LatentInfo, WorldContextObject); }
        public void SetBusConfig(Object BusName, AkChannelConfiguration ChannelConfiguration) { Invoke(nameof(SetBusConfig), BusName, ChannelConfiguration); }
        public void ResetRTPCValue(AkRtpc RTPCValue, int InterpolationTimeMs, Actor Actor, Object RTPC) { Invoke(nameof(ResetRTPCValue), RTPCValue, InterpolationTimeMs, Actor, RTPC); }
        public void ReplaceMainOutput(AkOutputSettings MainOutputSettings) { Invoke(nameof(ReplaceMainOutput), MainOutputSettings); }
        public void PostTrigger(AkTrigger TriggerValue, Actor Actor, Object Trigger) { Invoke(nameof(PostTrigger), TriggerValue, Actor, Trigger); }
        public void PostEventByName(Object EventName, Actor Actor, bool bStopWhenAttachedToDestroyed) { Invoke(nameof(PostEventByName), EventName, Actor, bStopWhenAttachedToDestroyed); }
        public int PostEventAttached(AkAudioEvent AkEvent, Actor Actor, Object AttachPointName, bool bStopWhenAttachedToDestroyed, Object EventName) { return Invoke<int>(nameof(PostEventAttached), AkEvent, Actor, AttachPointName, bStopWhenAttachedToDestroyed, EventName); }
        public void PostEventAtLocationByName(Object EventName, Vector Location, Rotator Orientation, Object WorldContextObject) { Invoke(nameof(PostEventAtLocationByName), EventName, Location, Orientation, WorldContextObject); }
        public int PostEventAtLocation(AkAudioEvent AkEvent, Vector Location, Rotator Orientation, Object EventName, Object WorldContextObject) { return Invoke<int>(nameof(PostEventAtLocation), AkEvent, Location, Orientation, EventName, WorldContextObject); }
        public int PostEvent(AkAudioEvent AkEvent, Actor Actor, int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed, Object EventName) { return Invoke<int>(nameof(PostEvent), AkEvent, Actor, CallbackMask, PostEventCallback, ExternalSources, bStopWhenAttachedToDestroyed, EventName); }
        public void PostAndWaitForEndOfEventAsync(AkAudioEvent AkEvent, Actor Actor, int PlayingID, bool bStopWhenAttachedToDestroyed, Array<AkExternalSourceInfo> ExternalSources, LatentActionInfo LatentInfo) { Invoke(nameof(PostAndWaitForEndOfEventAsync), AkEvent, Actor, PlayingID, bStopWhenAttachedToDestroyed, ExternalSources, LatentInfo); }
        public int PostAndWaitForEndOfEvent(AkAudioEvent AkEvent, Actor Actor, bool bStopWhenAttachedToDestroyed, Array<AkExternalSourceInfo> ExternalSources, Object EventName, LatentActionInfo LatentInfo) { return Invoke<int>(nameof(PostAndWaitForEndOfEvent), AkEvent, Actor, bStopWhenAttachedToDestroyed, ExternalSources, EventName, LatentInfo); }
        public void LoadInitBank() { Invoke(nameof(LoadInitBank)); }
        public void LoadBanks(Array<AkAudioBank> SoundBanks, bool SynchronizeSoundBanks) { Invoke(nameof(LoadBanks), SoundBanks, SynchronizeSoundBanks); }
        public void LoadBankByName(Object BankName) { Invoke(nameof(LoadBankByName), BankName); }
        public void LoadBankAsync(AkAudioBank Bank, Object BankLoadedCallback) { Invoke(nameof(LoadBankAsync), Bank, BankLoadedCallback); }
        public void LoadBank(AkAudioBank Bank, Object BankName, LatentActionInfo LatentInfo, Object WorldContextObject) { Invoke(nameof(LoadBank), Bank, BankName, LatentInfo, WorldContextObject); }
        public bool IsGame(Object WorldContextObject) { return Invoke<bool>(nameof(IsGame), WorldContextObject); }
        public bool IsEditor() { return Invoke<bool>(nameof(IsEditor)); }
        public void GetSpeakerAngles(Array<float> SpeakerAngles, float HeightAngle, Object DeviceShareset) { Invoke(nameof(GetSpeakerAngles), SpeakerAngles, HeightAngle, DeviceShareset); }
        public void GetRTPCValue(AkRtpc RTPCValue, int PlayingID, ERTPCValueType InputValueType, float Value, ERTPCValueType OutputValueType, Actor Actor, Object RTPC) { Invoke(nameof(GetRTPCValue), RTPCValue, PlayingID, InputValueType, Value, OutputValueType, Actor, RTPC); }
        public float GetOcclusionScalingFactor() { return Invoke<float>(nameof(GetOcclusionScalingFactor)); }
        public Object GetCurrentAudioCulture() { return Invoke<Object>(nameof(GetCurrentAudioCulture)); }
        public Array<Object> GetAvailableAudioCultures() { return Invoke<Array<Object>>(nameof(GetAvailableAudioCultures)); }
        public Object GetAkMediaAssetUserData(AkMediaAsset Instance, Object Type) { return Invoke<Object>(nameof(GetAkMediaAssetUserData), Instance, Type); }
        public AkComponent GetAkComponent(SceneComponent AttachToComponent, bool ComponentCreated, Object AttachPointName, Vector Location, byte LocationType) { return Invoke<AkComponent>(nameof(GetAkComponent), AttachToComponent, ComponentCreated, AttachPointName, Location, LocationType); }
        public Object GetAkAudioTypeUserData(AkAudioType Instance, Object Type) { return Invoke<Object>(nameof(GetAkAudioTypeUserData), Instance, Type); }
        public void ExecuteActionOnPlayingID(AkActionOnEventType ActionType, int PlayingID, int TransitionDuration, EAkCurveInterpolation FadeCurve) { Invoke(nameof(ExecuteActionOnPlayingID), ActionType, PlayingID, TransitionDuration, FadeCurve); }
        public void ExecuteActionOnEvent(AkAudioEvent AkEvent, AkActionOnEventType ActionType, Actor Actor, int TransitionDuration, EAkCurveInterpolation FadeCurve, int PlayingID) { Invoke(nameof(ExecuteActionOnEvent), AkEvent, ActionType, Actor, TransitionDuration, FadeCurve, PlayingID); }
        public void ClearBanks() { Invoke(nameof(ClearBanks)); }
        public void CancelEventCallback(Object PostEventCallback) { Invoke(nameof(CancelEventCallback), PostEventCallback); }
        public void AddOutputCaptureMarker(Object MarkerText) { Invoke(nameof(AddOutputCaptureMarker), MarkerText); }
    }
    public class AkCallbackInfo : Object
    {
        public AkCallbackInfo(nint addr) : base(addr) { }
        public AkComponent AkComponent { get { return this[nameof(AkComponent)].As<AkComponent>(); } set { this["AkComponent"] = value; } }
    }
    public class AkEventCallbackInfo : AkCallbackInfo
    {
        public AkEventCallbackInfo(nint addr) : base(addr) { }
        public int PlayingID { get { return this[nameof(PlayingID)].GetValue<int>(); } set { this[nameof(PlayingID)].SetValue<int>(value); } }
        public int EventID { get { return this[nameof(EventID)].GetValue<int>(); } set { this[nameof(EventID)].SetValue<int>(value); } }
    }
    public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
    {
        public AkMIDIEventCallbackInfo(nint addr) : base(addr) { }
        public EAkMidiEventType GetType() { return Invoke<EAkMidiEventType>(nameof(GetType)); }
        public bool GetProgramChange(AkMidiProgramChange AsProgramChange) { return Invoke<bool>(nameof(GetProgramChange), AsProgramChange); }
        public bool GetPitchBend(AkMidiPitchBend AsPitchBend) { return Invoke<bool>(nameof(GetPitchBend), AsPitchBend); }
        public bool GetNoteOn(AkMidiNoteOnOff AsNoteOn) { return Invoke<bool>(nameof(GetNoteOn), AsNoteOn); }
        public bool GetNoteOff(AkMidiNoteOnOff AsNoteOff) { return Invoke<bool>(nameof(GetNoteOff), AsNoteOff); }
        public bool GetNoteAftertouch(AkMidiNoteAftertouch AsNoteAftertouch) { return Invoke<bool>(nameof(GetNoteAftertouch), AsNoteAftertouch); }
        public bool GetGeneric(AkMidiGeneric AsGeneric) { return Invoke<bool>(nameof(GetGeneric), AsGeneric); }
        public bool GetChannelAftertouch(AkMidiChannelAftertouch AsChannelAftertouch) { return Invoke<bool>(nameof(GetChannelAftertouch), AsChannelAftertouch); }
        public byte GetChannel() { return Invoke<byte>(nameof(GetChannel)); }
        public bool GetCc(AkMidiCc AsCc) { return Invoke<bool>(nameof(GetCc), AsCc); }
    }
    public class AkMarkerCallbackInfo : AkEventCallbackInfo
    {
        public AkMarkerCallbackInfo(nint addr) : base(addr) { }
        public int Identifier { get { return this[nameof(Identifier)].GetValue<int>(); } set { this[nameof(Identifier)].SetValue<int>(value); } }
        public int Position { get { return this[nameof(Position)].GetValue<int>(); } set { this[nameof(Position)].SetValue<int>(value); } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
    }
    public class AkDurationCallbackInfo : AkEventCallbackInfo
    {
        public AkDurationCallbackInfo(nint addr) : base(addr) { }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float EstimatedDuration { get { return this[nameof(EstimatedDuration)].GetValue<float>(); } set { this[nameof(EstimatedDuration)].SetValue<float>(value); } }
        public int AudioNodeID { get { return this[nameof(AudioNodeID)].GetValue<int>(); } set { this[nameof(AudioNodeID)].SetValue<int>(value); } }
        public int MediaID { get { return this[nameof(MediaID)].GetValue<int>(); } set { this[nameof(MediaID)].SetValue<int>(value); } }
        public bool bStreaming { get { return this[nameof(bStreaming)].Flag; } set { this[nameof(bStreaming)].Flag = value; } }
    }
    public class AkMusicSyncCallbackInfo : AkCallbackInfo
    {
        public AkMusicSyncCallbackInfo(nint addr) : base(addr) { }
        public int PlayingID { get { return this[nameof(PlayingID)].GetValue<int>(); } set { this[nameof(PlayingID)].SetValue<int>(value); } }
        public AkSegmentInfo SegmentInfo { get { return this[nameof(SegmentInfo)].As<AkSegmentInfo>(); } set { this["SegmentInfo"] = value; } }
        public EAkCallbackType MusicSyncType { get { return (EAkCallbackType)this[nameof(MusicSyncType)].GetValue<int>(); } set { this[nameof(MusicSyncType)].SetValue<int>((int)value); } }
        public Object UserCueName { get { return this[nameof(UserCueName)]; } set { this[nameof(UserCueName)] = value; } }
    }
    public class AkGeometryComponent : AkAcousticTextureSetComponent
    {
        public AkGeometryComponent(nint addr) : base(addr) { }
        public AkMeshType MeshType { get { return (AkMeshType)this[nameof(MeshType)].GetValue<int>(); } set { this[nameof(MeshType)].SetValue<int>((int)value); } }
        public int LOD { get { return this[nameof(LOD)].GetValue<int>(); } set { this[nameof(LOD)].SetValue<int>(value); } }
        public float WeldingThreshold { get { return this[nameof(WeldingThreshold)].GetValue<float>(); } set { this[nameof(WeldingThreshold)].SetValue<float>(value); } }
        public Object StaticMeshSurfaceOverride { get { return this[nameof(StaticMeshSurfaceOverride)]; } set { this[nameof(StaticMeshSurfaceOverride)] = value; } }
        public AkGeometrySurfaceOverride CollisionMeshSurfaceOverride { get { return this[nameof(CollisionMeshSurfaceOverride)].As<AkGeometrySurfaceOverride>(); } set { this["CollisionMeshSurfaceOverride"] = value; } }
        public bool bEnableDiffraction { get { return this[nameof(bEnableDiffraction)].Flag; } set { this[nameof(bEnableDiffraction)].Flag = value; } }
        public bool bEnableDiffractionOnBoundaryEdges { get { return this[nameof(bEnableDiffractionOnBoundaryEdges)].Flag; } set { this[nameof(bEnableDiffractionOnBoundaryEdges)].Flag = value; } }
        public Actor AssociatedRoom { get { return this[nameof(AssociatedRoom)].As<Actor>(); } set { this["AssociatedRoom"] = value; } }
        public AkGeometryData GeometryData { get { return this[nameof(GeometryData)].As<AkGeometryData>(); } set { this["GeometryData"] = value; } }
        public Object SurfaceAreas { get { return this[nameof(SurfaceAreas)]; } set { this[nameof(SurfaceAreas)] = value; } }
        public void UpdateGeometry() { Invoke(nameof(UpdateGeometry)); }
        public void SendGeometry() { Invoke(nameof(SendGeometry)); }
        public void RemoveGeometry() { Invoke(nameof(RemoveGeometry)); }
        public void ConvertMesh() { Invoke(nameof(ConvertMesh)); }
    }
    public class AkGroupValue : AkAudioType
    {
        public AkGroupValue(nint addr) : base(addr) { }
        public Array<Object> MediaDependencies { get { return new Array<Object>(this[nameof(MediaDependencies)].Address); } }
        public uint GroupShortID { get { return this[nameof(GroupShortID)].GetValue<uint>(); } set { this[nameof(GroupShortID)].SetValue<uint>(value); } }
    }
    public class AkHololensInitializationSettings : Object
    {
        public AkHololensInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkHololensAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkHololensAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkHololensPlatformInfo : AkPlatformInfo
    {
        public AkHololensPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkInitBankAssetData : AkAssetDataWithMedia
    {
        public AkInitBankAssetData(nint addr) : base(addr) { }
        public Array<AkPluginInfo> PluginInfos { get { return new Array<AkPluginInfo>(this[nameof(PluginInfos)].Address); } }
    }
    public class AkInitBank : AkAssetBase
    {
        public AkInitBank(nint addr) : base(addr) { }
        public Array<Object> AvailableAudioCultures { get { return new Array<Object>(this[nameof(AvailableAudioCultures)].Address); } }
        public Object DefaultLanguage { get { return this[nameof(DefaultLanguage)]; } set { this[nameof(DefaultLanguage)] = value; } }
    }
    public class AkIOSInitializationSettings : Object
    {
        public AkIOSInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkAudioSession AudioSession { get { return this[nameof(AudioSession)].As<AkAudioSession>(); } set { this["AudioSession"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
    }
    public class AkIOSPlatformInfo : AkPlatformInfo
    {
        public AkIOSPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkItemBoolPropertiesConv : BlueprintFunctionLibrary
    {
        public AkItemBoolPropertiesConv(nint addr) : base(addr) { }
        public Object Conv_FAkBoolPropertyToControlToText(AkBoolPropertyToControl INAkBoolPropertyToControl) { return Invoke<Object>(nameof(Conv_FAkBoolPropertyToControlToText), INAkBoolPropertyToControl); }
        public Object Conv_FAkBoolPropertyToControlToString(AkBoolPropertyToControl INAkBoolPropertyToControl) { return Invoke<Object>(nameof(Conv_FAkBoolPropertyToControlToString), INAkBoolPropertyToControl); }
    }
    public class AkItemBoolProperties : Widget
    {
        public AkItemBoolProperties(nint addr) : base(addr) { }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnPropertyDragged { get { return this[nameof(OnPropertyDragged)]; } set { this[nameof(OnPropertyDragged)] = value; } }
        public void SetSearchText(Object newText) { Invoke(nameof(SetSearchText), newText); }
        public Object GetSelectedProperty() { return Invoke<Object>(nameof(GetSelectedProperty)); }
        public Object GetSearchText() { return Invoke<Object>(nameof(GetSearchText)); }
    }
    public class AkItemPropertiesConv : BlueprintFunctionLibrary
    {
        public AkItemPropertiesConv(nint addr) : base(addr) { }
        public Object Conv_FAkPropertyToControlToText(AkPropertyToControl INAkPropertyToControl) { return Invoke<Object>(nameof(Conv_FAkPropertyToControlToText), INAkPropertyToControl); }
        public Object Conv_FAkPropertyToControlToString(AkPropertyToControl INAkPropertyToControl) { return Invoke<Object>(nameof(Conv_FAkPropertyToControlToString), INAkPropertyToControl); }
    }
    public class AkItemProperties : Widget
    {
        public AkItemProperties(nint addr) : base(addr) { }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnPropertyDragged { get { return this[nameof(OnPropertyDragged)]; } set { this[nameof(OnPropertyDragged)] = value; } }
        public void SetSearchText(Object newText) { Invoke(nameof(SetSearchText), newText); }
        public Object GetSelectedProperty() { return Invoke<Object>(nameof(GetSelectedProperty)); }
        public Object GetSearchText() { return Invoke<Object>(nameof(GetSearchText)); }
    }
    public class AkLateReverbComponent : SceneComponent
    {
        public AkLateReverbComponent(nint addr) : base(addr) { }
        public bool bEnable { get { return this[nameof(bEnable)].Flag; } set { this[nameof(bEnable)].Flag = value; } }
        public float SendLevel { get { return this[nameof(SendLevel)].GetValue<float>(); } set { this[nameof(SendLevel)].SetValue<float>(value); } }
        public float FadeRate { get { return this[nameof(FadeRate)].GetValue<float>(); } set { this[nameof(FadeRate)].SetValue<float>(value); } }
        public float Priority { get { return this[nameof(Priority)].GetValue<float>(); } set { this[nameof(Priority)].SetValue<float>(value); } }
        public bool AutoAssignAuxBus { get { return this[nameof(AutoAssignAuxBus)].Flag; } set { this[nameof(AutoAssignAuxBus)].Flag = value; } }
        public AkAuxBus AuxBus { get { return this[nameof(AuxBus)].As<AkAuxBus>(); } set { this["AuxBus"] = value; } }
        public Object AuxBusName { get { return this[nameof(AuxBusName)]; } set { this[nameof(AuxBusName)] = value; } }
        public AkAuxBus AuxBusManual { get { return this[nameof(AuxBusManual)].As<AkAuxBus>(); } set { this["AuxBusManual"] = value; } }
        public void AssociateAkTextureSetComponent(AkAcousticTextureSetComponent textureSetComponent) { Invoke(nameof(AssociateAkTextureSetComponent), textureSetComponent); }
    }
    public class AkLinuxInitializationSettings : Object
    {
        public AkLinuxInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkAdvancedInitializationSettingsWithMultiCoreRendering AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAdvancedInitializationSettingsWithMultiCoreRendering>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkLinuxPlatformInfo : AkPlatformInfo
    {
        public AkLinuxPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkMacInitializationSettings : Object
    {
        public AkMacInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkAdvancedInitializationSettingsWithMultiCoreRendering AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAdvancedInitializationSettingsWithMultiCoreRendering>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkMacPlatformInfo : AkPlatformInfo
    {
        public AkMacPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkMediaAssetData : Object
    {
        public AkMediaAssetData(nint addr) : base(addr) { }
        public bool IsStreamed { get { return this[nameof(IsStreamed)].Flag; } set { this[nameof(IsStreamed)].Flag = value; } }
        public bool UseDeviceMemory { get { return this[nameof(UseDeviceMemory)].Flag; } set { this[nameof(UseDeviceMemory)].Flag = value; } }
        public Object Language { get { return this[nameof(Language)]; } set { this[nameof(Language)] = value; } }
        public Object AssetPlatform { get { return this[nameof(AssetPlatform)]; } set { this[nameof(AssetPlatform)] = value; } }
    }
    public class AkMediaAsset : Object
    {
        public AkMediaAsset(nint addr) : base(addr) { }
        public uint ID { get { return this[nameof(ID)].GetValue<uint>(); } set { this[nameof(ID)].SetValue<uint>(value); } }
        public Object MediaName { get { return this[nameof(MediaName)]; } set { this[nameof(MediaName)] = value; } }
        public bool AutoLoad { get { return this[nameof(AutoLoad)].Flag; } set { this[nameof(AutoLoad)].Flag = value; } }
        public Array<Object> UserData { get { return new Array<Object>(this[nameof(UserData)].Address); } }
        public Object Language { get { return this[nameof(Language)]; } set { this[nameof(Language)] = value; } }
        public AkMediaAssetData CurrentMediaAssetData { get { return this[nameof(CurrentMediaAssetData)].As<AkMediaAssetData>(); } set { this["CurrentMediaAssetData"] = value; } }
    }
    public class AkLocalizedMediaAsset : AkMediaAsset
    {
        public AkLocalizedMediaAsset(nint addr) : base(addr) { }
    }
    public class AkExternalMediaAsset : AkMediaAsset
    {
        public AkExternalMediaAsset(nint addr) : base(addr) { }
    }
    public class AkPlatformInitialisationSettingsBase : Interface
    {
        public AkPlatformInitialisationSettingsBase(nint addr) : base(addr) { }
    }
    public class AkPS4InitializationSettings : Object
    {
        public AkPS4InitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettings CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettings>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkPS4AdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkPS4AdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkPS4PlatformInfo : AkPlatformInfo
    {
        public AkPS4PlatformInfo(nint addr) : base(addr) { }
    }
    public class AkReverbVolume : Volume
    {
        public AkReverbVolume(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public AkAuxBus AuxBus { get { return this[nameof(AuxBus)].As<AkAuxBus>(); } set { this["AuxBus"] = value; } }
        public Object AuxBusName { get { return this[nameof(AuxBusName)]; } set { this[nameof(AuxBusName)] = value; } }
        public float SendLevel { get { return this[nameof(SendLevel)].GetValue<float>(); } set { this[nameof(SendLevel)].SetValue<float>(value); } }
        public float FadeRate { get { return this[nameof(FadeRate)].GetValue<float>(); } set { this[nameof(FadeRate)].SetValue<float>(value); } }
        public float Priority { get { return this[nameof(Priority)].GetValue<float>(); } set { this[nameof(Priority)].SetValue<float>(value); } }
        public AkLateReverbComponent LateReverbComponent { get { return this[nameof(LateReverbComponent)].As<AkLateReverbComponent>(); } set { this["LateReverbComponent"] = value; } }
    }
    public class AkRoomComponent : AkGameObject
    {
        public AkRoomComponent(nint addr) : base(addr) { }
        public bool bEnable { get { return this[nameof(bEnable)].Flag; } set { this[nameof(bEnable)].Flag = value; } }
        public bool bDynamic { get { return this[nameof(bDynamic)].Flag; } set { this[nameof(bDynamic)].Flag = value; } }
        public float Priority { get { return this[nameof(Priority)].GetValue<float>(); } set { this[nameof(Priority)].SetValue<float>(value); } }
        public float WallOcclusion { get { return this[nameof(WallOcclusion)].GetValue<float>(); } set { this[nameof(WallOcclusion)].SetValue<float>(value); } }
        public float AuxSendLevel { get { return this[nameof(AuxSendLevel)].GetValue<float>(); } set { this[nameof(AuxSendLevel)].SetValue<float>(value); } }
        public bool AutoPost { get { return this[nameof(AutoPost)].Flag; } set { this[nameof(AutoPost)].Flag = value; } }
        public AkAcousticTextureSetComponent GeometryComponent { get { return this[nameof(GeometryComponent)].As<AkAcousticTextureSetComponent>(); } set { this["GeometryComponent"] = value; } }
        public void SetGeometryComponent(AkAcousticTextureSetComponent textureSetComponent) { Invoke(nameof(SetGeometryComponent), textureSetComponent); }
        public PrimitiveComponent GetPrimitiveParent() { return Invoke<PrimitiveComponent>(nameof(GetPrimitiveParent)); }
    }
    public class AkRtpc : AkAudioType
    {
        public AkRtpc(nint addr) : base(addr) { }
    }
    public class AkSettings : Object
    {
        public AkSettings(nint addr) : base(addr) { }
        public byte MaxSimultaneousReverbVolumes { get { return this[nameof(MaxSimultaneousReverbVolumes)].GetValue<byte>(); } set { this[nameof(MaxSimultaneousReverbVolumes)].SetValue<byte>(value); } }
        public FilePath WwiseProjectPath { get { return this[nameof(WwiseProjectPath)].As<FilePath>(); } set { this["WwiseProjectPath"] = value; } }
        public DirectoryPath WwiseSoundDataFolder { get { return this[nameof(WwiseSoundDataFolder)].As<DirectoryPath>(); } set { this["WwiseSoundDataFolder"] = value; } }
        public bool bAutoConnectToWAAPI { get { return this[nameof(bAutoConnectToWAAPI)].Flag; } set { this[nameof(bAutoConnectToWAAPI)].Flag = value; } }
        public byte DefaultOcclusionCollisionChannel { get { return this[nameof(DefaultOcclusionCollisionChannel)].GetValue<byte>(); } set { this[nameof(DefaultOcclusionCollisionChannel)].SetValue<byte>(value); } }
        public byte DefaultFitToGeometryCollisionChannel { get { return this[nameof(DefaultFitToGeometryCollisionChannel)].GetValue<byte>(); } set { this[nameof(DefaultFitToGeometryCollisionChannel)].SetValue<byte>(value); } }
        public Object AkGeometryMap { get { return this[nameof(AkGeometryMap)]; } set { this[nameof(AkGeometryMap)] = value; } }
        public float GlobalDecayAbsorption { get { return this[nameof(GlobalDecayAbsorption)].GetValue<float>(); } set { this[nameof(GlobalDecayAbsorption)].SetValue<float>(value); } }
        public Object DefaultReverbAuxBus { get { return this[nameof(DefaultReverbAuxBus)]; } set { this[nameof(DefaultReverbAuxBus)] = value; } }
        public Object EnvironmentDecayAuxBusMap { get { return this[nameof(EnvironmentDecayAuxBusMap)]; } set { this[nameof(EnvironmentDecayAuxBusMap)] = value; } }
        public Object HFDampingName { get { return this[nameof(HFDampingName)]; } set { this[nameof(HFDampingName)] = value; } }
        public Object DecayEstimateName { get { return this[nameof(DecayEstimateName)]; } set { this[nameof(DecayEstimateName)] = value; } }
        public Object TimeToFirstReflectionName { get { return this[nameof(TimeToFirstReflectionName)]; } set { this[nameof(TimeToFirstReflectionName)] = value; } }
        public Object HFDampingRTPC { get { return this[nameof(HFDampingRTPC)]; } set { this[nameof(HFDampingRTPC)] = value; } }
        public Object DecayEstimateRTPC { get { return this[nameof(DecayEstimateRTPC)]; } set { this[nameof(DecayEstimateRTPC)] = value; } }
        public Object TimeToFirstReflectionRTPC { get { return this[nameof(TimeToFirstReflectionRTPC)]; } set { this[nameof(TimeToFirstReflectionRTPC)] = value; } }
        public Object AudioInputEvent { get { return this[nameof(AudioInputEvent)]; } set { this[nameof(AudioInputEvent)] = value; } }
        public Object AcousticTextureParamsMap { get { return this[nameof(AcousticTextureParamsMap)]; } set { this[nameof(AcousticTextureParamsMap)] = value; } }
        public bool SplitSwitchContainerMedia { get { return this[nameof(SplitSwitchContainerMedia)].Flag; } set { this[nameof(SplitSwitchContainerMedia)].Flag = value; } }
        public bool SplitMediaPerFolder { get { return this[nameof(SplitMediaPerFolder)].Flag; } set { this[nameof(SplitMediaPerFolder)].Flag = value; } }
        public bool UseEventBasedPackaging { get { return this[nameof(UseEventBasedPackaging)].Flag; } set { this[nameof(UseEventBasedPackaging)].Flag = value; } }
        public bool EnableAutomaticAssetSynchronization { get { return this[nameof(EnableAutomaticAssetSynchronization)].Flag; } set { this[nameof(EnableAutomaticAssetSynchronization)].Flag = value; } }
        public Object CommandletCommitMessage { get { return this[nameof(CommandletCommitMessage)]; } set { this[nameof(CommandletCommitMessage)] = value; } }
        public Object UnrealCultureToWwiseCulture { get { return this[nameof(UnrealCultureToWwiseCulture)]; } set { this[nameof(UnrealCultureToWwiseCulture)] = value; } }
        public bool AskedToUseNewAssetManagement { get { return this[nameof(AskedToUseNewAssetManagement)].Flag; } set { this[nameof(AskedToUseNewAssetManagement)].Flag = value; } }
        public bool bEnableMultiCoreRendering { get { return this[nameof(bEnableMultiCoreRendering)].Flag; } set { this[nameof(bEnableMultiCoreRendering)].Flag = value; } }
        public bool MigratedEnableMultiCoreRendering { get { return this[nameof(MigratedEnableMultiCoreRendering)].Flag; } set { this[nameof(MigratedEnableMultiCoreRendering)].Flag = value; } }
        public bool FixupRedirectorsDuringMigration { get { return this[nameof(FixupRedirectorsDuringMigration)].Flag; } set { this[nameof(FixupRedirectorsDuringMigration)].Flag = value; } }
        public DirectoryPath WwiseWindowsInstallationPath { get { return this[nameof(WwiseWindowsInstallationPath)].As<DirectoryPath>(); } set { this["WwiseWindowsInstallationPath"] = value; } }
        public FilePath WwiseMacInstallationPath { get { return this[nameof(WwiseMacInstallationPath)].As<FilePath>(); } set { this["WwiseMacInstallationPath"] = value; } }
        public Object DefaultAkComponentClass { get { return this[nameof(DefaultAkComponentClass)]; } set { this[nameof(DefaultAkComponentClass)] = value; } }
    }
    public class AkSettingsPerUser : Object
    {
        public AkSettingsPerUser(nint addr) : base(addr) { }
        public DirectoryPath WwiseWindowsInstallationPath { get { return this[nameof(WwiseWindowsInstallationPath)].As<DirectoryPath>(); } set { this["WwiseWindowsInstallationPath"] = value; } }
        public FilePath WwiseMacInstallationPath { get { return this[nameof(WwiseMacInstallationPath)].As<FilePath>(); } set { this["WwiseMacInstallationPath"] = value; } }
        public bool EnableAutomaticAssetSynchronization { get { return this[nameof(EnableAutomaticAssetSynchronization)].Flag; } set { this[nameof(EnableAutomaticAssetSynchronization)].Flag = value; } }
        public Object WaapiIPAddress { get { return this[nameof(WaapiIPAddress)]; } set { this[nameof(WaapiIPAddress)] = value; } }
        public uint WaapiPort { get { return this[nameof(WaapiPort)].GetValue<uint>(); } set { this[nameof(WaapiPort)].SetValue<uint>(value); } }
        public bool bAutoConnectToWAAPI { get { return this[nameof(bAutoConnectToWAAPI)].Flag; } set { this[nameof(bAutoConnectToWAAPI)].Flag = value; } }
        public bool AutoSyncSelection { get { return this[nameof(AutoSyncSelection)].Flag; } set { this[nameof(AutoSyncSelection)].Flag = value; } }
        public bool SuppressWwiseProjectPathWarnings { get { return this[nameof(SuppressWwiseProjectPathWarnings)].Flag; } set { this[nameof(SuppressWwiseProjectPathWarnings)].Flag = value; } }
        public bool SoundDataGenerationSkipLanguage { get { return this[nameof(SoundDataGenerationSkipLanguage)].Flag; } set { this[nameof(SoundDataGenerationSkipLanguage)].Flag = value; } }
    }
    public class AkSlider : Widget
    {
        public AkSlider(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public SliderStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SliderStyle>(); } set { this["WidgetStyle"] = value; } }
        public byte Orientation { get { return this[nameof(Orientation)].GetValue<byte>(); } set { this[nameof(Orientation)].SetValue<byte>(value); } }
        public LinearColor SliderBarColor { get { return this[nameof(SliderBarColor)].As<LinearColor>(); } set { this["SliderBarColor"] = value; } }
        public LinearColor SliderHandleColor { get { return this[nameof(SliderHandleColor)].As<LinearColor>(); } set { this["SliderHandleColor"] = value; } }
        public bool IndentHandle { get { return this[nameof(IndentHandle)].Flag; } set { this[nameof(IndentHandle)].Flag = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public bool IsFocusable { get { return this[nameof(IsFocusable)].Flag; } set { this[nameof(IsFocusable)].Flag = value; } }
        public AkPropertyToControl ThePropertyToControl { get { return this[nameof(ThePropertyToControl)].As<AkPropertyToControl>(); } set { this["ThePropertyToControl"] = value; } }
        public AkWwiseItemToControl ItemToControl { get { return this[nameof(ItemToControl)].As<AkWwiseItemToControl>(); } set { this["ItemToControl"] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public Object OnItemDropped { get { return this[nameof(OnItemDropped)]; } set { this[nameof(OnItemDropped)] = value; } }
        public Object OnPropertyDropped { get { return this[nameof(OnPropertyDropped)]; } set { this[nameof(OnPropertyDropped)] = value; } }
        public void SetValue(float InValue) { Invoke(nameof(SetValue), InValue); }
        public void SetStepSize(float InValue) { Invoke(nameof(SetStepSize), InValue); }
        public void SetSliderHandleColor(LinearColor InValue) { Invoke(nameof(SetSliderHandleColor), InValue); }
        public void SetSliderBarColor(LinearColor InValue) { Invoke(nameof(SetSliderBarColor), InValue); }
        public void SetLocked(bool InValue) { Invoke(nameof(SetLocked), InValue); }
        public void SetIndentHandle(bool InValue) { Invoke(nameof(SetIndentHandle), InValue); }
        public void SetAkSliderItemProperty(Object ItemProperty) { Invoke(nameof(SetAkSliderItemProperty), ItemProperty); }
        public void SetAkSliderItemId(Guid ItemId) { Invoke(nameof(SetAkSliderItemId), ItemId); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public Object GetAkSliderItemProperty() { return Invoke<Object>(nameof(GetAkSliderItemProperty)); }
        public Guid GetAkSliderItemId() { return Invoke<Guid>(nameof(GetAkSliderItemId)); }
    }
    public class AkSpatialAudioVolume : Volume
    {
        public AkSpatialAudioVolume(nint addr) : base(addr) { }
        public AkSurfaceReflectorSetComponent SurfaceReflectorSet { get { return this[nameof(SurfaceReflectorSet)].As<AkSurfaceReflectorSetComponent>(); } set { this["SurfaceReflectorSet"] = value; } }
        public AkLateReverbComponent LateReverb { get { return this[nameof(LateReverb)].As<AkLateReverbComponent>(); } set { this["LateReverb"] = value; } }
        public AkRoomComponent Room { get { return this[nameof(Room)].As<AkRoomComponent>(); } set { this["Room"] = value; } }
    }
    public class AkSpotReflector : Actor
    {
        public AkSpotReflector(nint addr) : base(addr) { }
        public AkAuxBus EarlyReflectionAuxBus { get { return this[nameof(EarlyReflectionAuxBus)].As<AkAuxBus>(); } set { this["EarlyReflectionAuxBus"] = value; } }
        public Object EarlyReflectionAuxBusName { get { return this[nameof(EarlyReflectionAuxBusName)]; } set { this[nameof(EarlyReflectionAuxBusName)] = value; } }
        public AkAcousticTexture AcousticTexture { get { return this[nameof(AcousticTexture)].As<AkAcousticTexture>(); } set { this["AcousticTexture"] = value; } }
        public float DistanceScalingFactor { get { return this[nameof(DistanceScalingFactor)].GetValue<float>(); } set { this[nameof(DistanceScalingFactor)].SetValue<float>(value); } }
        public float Level { get { return this[nameof(Level)].GetValue<float>(); } set { this[nameof(Level)].SetValue<float>(value); } }
    }
    public class AkStateValue : AkGroupValue
    {
        public AkStateValue(nint addr) : base(addr) { }
    }
    public class AkSubmixInputComponent : AkAudioInputComponent
    {
        public AkSubmixInputComponent(nint addr) : base(addr) { }
        public SoundSubmix SubmixToRecord { get { return this[nameof(SubmixToRecord)].As<SoundSubmix>(); } set { this["SubmixToRecord"] = value; } }
    }
    public class AkSurfaceReflectorSetComponent : AkAcousticTextureSetComponent
    {
        public AkSurfaceReflectorSetComponent(nint addr) : base(addr) { }
        public bool bEnableSurfaceReflectors { get { return this[nameof(bEnableSurfaceReflectors)].Flag; } set { this[nameof(bEnableSurfaceReflectors)].Flag = value; } }
        public Array<AkSurfacePoly> AcousticPolys { get { return new Array<AkSurfacePoly>(this[nameof(AcousticPolys)].Address); } }
        public bool bEnableDiffraction { get { return this[nameof(bEnableDiffraction)].Flag; } set { this[nameof(bEnableDiffraction)].Flag = value; } }
        public bool bEnableDiffractionOnBoundaryEdges { get { return this[nameof(bEnableDiffractionOnBoundaryEdges)].Flag; } set { this[nameof(bEnableDiffractionOnBoundaryEdges)].Flag = value; } }
        public Actor AssociatedRoom { get { return this[nameof(AssociatedRoom)].As<Actor>(); } set { this["AssociatedRoom"] = value; } }
        public void UpdateSurfaceReflectorSet() { Invoke(nameof(UpdateSurfaceReflectorSet)); }
        public void SendSurfaceReflectorSet() { Invoke(nameof(SendSurfaceReflectorSet)); }
        public void RemoveSurfaceReflectorSet() { Invoke(nameof(RemoveSurfaceReflectorSet)); }
    }
    public class AkSwitchInitializationSettings : Object
    {
        public AkSwitchInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithCommSelection CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithCommSelection>(); } set { this["CommunicationSettings"] = value; } }
        public AkAdvancedInitializationSettingsWithMultiCoreRendering AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAdvancedInitializationSettingsWithMultiCoreRendering>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkSwitchPlatformInfo : AkPlatformInfo
    {
        public AkSwitchPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkSwitchValue : AkGroupValue
    {
        public AkSwitchValue(nint addr) : base(addr) { }
    }
    public class AkTrigger : AkAudioType
    {
        public AkTrigger(nint addr) : base(addr) { }
    }
    public class AkTVOSInitializationSettings : Object
    {
        public AkTVOSInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkAudioSession AudioSession { get { return this[nameof(AudioSession)].As<AkAudioSession>(); } set { this["AudioSession"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
    }
    public class AkTVOSPlatformInfo : AkPlatformInfo
    {
        public AkTVOSPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWaapiCalls : BlueprintFunctionLibrary
    {
        public AkWaapiCalls(nint addr) : base(addr) { }
        public AKWaapiJsonObject Unsubscribe(AkWaapiSubscriptionId SubscriptionId, bool UnsubscriptionDone) { return Invoke<AKWaapiJsonObject>(nameof(Unsubscribe), SubscriptionId, UnsubscriptionDone); }
        public AKWaapiJsonObject SubscribeToWaapi(AkWaapiUri WaapiUri, AKWaapiJsonObject WaapiOptions, Object Callback, AkWaapiSubscriptionId SubscriptionId, bool SubscriptionDone) { return Invoke<AKWaapiJsonObject>(nameof(SubscribeToWaapi), WaapiUri, WaapiOptions, Callback, SubscriptionId, SubscriptionDone); }
        public void SetSubscriptionID(AkWaapiSubscriptionId Subscription, int ID) { Invoke(nameof(SetSubscriptionID), Subscription, ID); }
        public bool RegisterWaapiProjectLoadedCallback(Object Callback) { return Invoke<bool>(nameof(RegisterWaapiProjectLoadedCallback), Callback); }
        public bool RegisterWaapiConnectionLostCallback(Object Callback) { return Invoke<bool>(nameof(RegisterWaapiConnectionLostCallback), Callback); }
        public int GetSubscriptionID(AkWaapiSubscriptionId Subscription) { return Invoke<int>(nameof(GetSubscriptionID), Subscription); }
        public Object Conv_FAkWaapiSubscriptionIdToText(AkWaapiSubscriptionId INAkWaapiSubscriptionId) { return Invoke<Object>(nameof(Conv_FAkWaapiSubscriptionIdToText), INAkWaapiSubscriptionId); }
        public Object Conv_FAkWaapiSubscriptionIdToString(AkWaapiSubscriptionId INAkWaapiSubscriptionId) { return Invoke<Object>(nameof(Conv_FAkWaapiSubscriptionIdToString), INAkWaapiSubscriptionId); }
        public AKWaapiJsonObject CallWaapi(AkWaapiUri WaapiUri, AKWaapiJsonObject WaapiArgs, AKWaapiJsonObject WaapiOptions) { return Invoke<AKWaapiJsonObject>(nameof(CallWaapi), WaapiUri, WaapiArgs, WaapiOptions); }
    }
    public class SAkWaapiFieldNamesConv : BlueprintFunctionLibrary
    {
        public SAkWaapiFieldNamesConv(nint addr) : base(addr) { }
        public Object Conv_FAkWaapiFieldNamesToText(AkWaapiFieldNames INAkWaapiFieldNames) { return Invoke<Object>(nameof(Conv_FAkWaapiFieldNamesToText), INAkWaapiFieldNames); }
        public Object Conv_FAkWaapiFieldNamesToString(AkWaapiFieldNames INAkWaapiFieldNames) { return Invoke<Object>(nameof(Conv_FAkWaapiFieldNamesToString), INAkWaapiFieldNames); }
    }
    public class AkWaapiJsonManager : BlueprintFunctionLibrary
    {
        public AkWaapiJsonManager(nint addr) : base(addr) { }
        public AKWaapiJsonObject SetStringField(AkWaapiFieldNames FieldName, Object FieldValue, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetStringField), FieldName, FieldValue, Target); }
        public AKWaapiJsonObject SetObjectField(AkWaapiFieldNames FieldName, AKWaapiJsonObject FieldValue, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetObjectField), FieldName, FieldValue, Target); }
        public AKWaapiJsonObject SetNumberField(AkWaapiFieldNames FieldName, float FieldValue, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetNumberField), FieldName, FieldValue, Target); }
        public AKWaapiJsonObject SetBoolField(AkWaapiFieldNames FieldName, bool FieldValue, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetBoolField), FieldName, FieldValue, Target); }
        public AKWaapiJsonObject SetArrayStringFields(AkWaapiFieldNames FieldName, Array<Object> FieldStringValues, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetArrayStringFields), FieldName, FieldStringValues, Target); }
        public AKWaapiJsonObject SetArrayObjectFields(AkWaapiFieldNames FieldName, Array<AKWaapiJsonObject> FieldObjectValues, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(SetArrayObjectFields), FieldName, FieldObjectValues, Target); }
        public Object GetStringField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<Object>(nameof(GetStringField), FieldName, Target); }
        public AKWaapiJsonObject GetObjectField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<AKWaapiJsonObject>(nameof(GetObjectField), FieldName, Target); }
        public float GetNumberField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<float>(nameof(GetNumberField), FieldName, Target); }
        public int GetIntegerField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<int>(nameof(GetIntegerField), FieldName, Target); }
        public bool GetBoolField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<bool>(nameof(GetBoolField), FieldName, Target); }
        public Array<AKWaapiJsonObject> GetArrayField(AkWaapiFieldNames FieldName, AKWaapiJsonObject Target) { return Invoke<Array<AKWaapiJsonObject>>(nameof(GetArrayField), FieldName, Target); }
        public Object Conv_FAKWaapiJsonObjectToText(AKWaapiJsonObject INAKWaapiJsonObject) { return Invoke<Object>(nameof(Conv_FAKWaapiJsonObjectToText), INAKWaapiJsonObject); }
        public Object Conv_FAKWaapiJsonObjectToString(AKWaapiJsonObject INAKWaapiJsonObject) { return Invoke<Object>(nameof(Conv_FAKWaapiJsonObjectToString), INAKWaapiJsonObject); }
    }
    public class AkWaapiUriConv : BlueprintFunctionLibrary
    {
        public AkWaapiUriConv(nint addr) : base(addr) { }
        public Object Conv_FAkWaapiUriToText(AkWaapiUri INAkWaapiUri) { return Invoke<Object>(nameof(Conv_FAkWaapiUriToText), INAkWaapiUri); }
        public Object Conv_FAkWaapiUriToString(AkWaapiUri INAkWaapiUri) { return Invoke<Object>(nameof(Conv_FAkWaapiUriToString), INAkWaapiUri); }
    }
    public class AkWindowsInitializationSettings : Object
    {
        public AkWindowsInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkWindowsAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkWindowsAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkWin32PlatformInfo : AkPlatformInfo
    {
        public AkWin32PlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWin64PlatformInfo : AkPlatformInfo
    {
        public AkWin64PlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWindowsPlatformInfo : AkWin64PlatformInfo
    {
        public AkWindowsPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWinGDKInitializationSettings : Object
    {
        public AkWinGDKInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettingsWithSampleRate CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettingsWithSampleRate>(); } set { this["CommonSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkWinGDKAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkWinGDKAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkWinAnvilInitializationSettings : AkWinGDKInitializationSettings
    {
        public AkWinAnvilInitializationSettings(nint addr) : base(addr) { }
    }
    public class AkWinGDKPlatformInfo : AkPlatformInfo
    {
        public AkWinGDKPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWinAnvilPlatformInfo : AkWinGDKPlatformInfo
    {
        public AkWinAnvilPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkWwiseTree : Widget
    {
        public AkWwiseTree(nint addr) : base(addr) { }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnItemDragged { get { return this[nameof(OnItemDragged)]; } set { this[nameof(OnItemDragged)] = value; } }
        public void SetSearchText(Object newText) { Invoke(nameof(SetSearchText), newText); }
        public AkWwiseObjectDetails GetSelectedItem() { return Invoke<AkWwiseObjectDetails>(nameof(GetSelectedItem)); }
        public Object GetSearchText() { return Invoke<Object>(nameof(GetSearchText)); }
    }
    public class AkWwiseTreeSelector : Widget
    {
        public AkWwiseTreeSelector(nint addr) : base(addr) { }
        public Object OnSelectionChanged { get { return this[nameof(OnSelectionChanged)]; } set { this[nameof(OnSelectionChanged)] = value; } }
        public Object OnItemDragged { get { return this[nameof(OnItemDragged)]; } set { this[nameof(OnItemDragged)] = value; } }
    }
    public class AkXboxOneGDKInitializationSettings : Object
    {
        public AkXboxOneGDKInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettings CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettings>(); } set { this["CommonSettings"] = value; } }
        public AkXboxOneGDKApuHeapInitializationSettings ApuHeapSettings { get { return this[nameof(ApuHeapSettings)].As<AkXboxOneGDKApuHeapInitializationSettings>(); } set { this["ApuHeapSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkXboxOneGDKAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkXboxOneGDKAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkXboxOneAnvilInitializationSettings : AkXboxOneGDKInitializationSettings
    {
        public AkXboxOneAnvilInitializationSettings(nint addr) : base(addr) { }
    }
    public class AkXB1InitializationSettings : AkXboxOneGDKInitializationSettings
    {
        public AkXB1InitializationSettings(nint addr) : base(addr) { }
    }
    public class AkXboxOneGDKPlatformInfo : AkPlatformInfo
    {
        public AkXboxOneGDKPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkXboxOneAnvilPlatformInfo : AkXboxOneGDKPlatformInfo
    {
        public AkXboxOneAnvilPlatformInfo(nint addr) : base(addr) { }
    }
    public class AkXB1PlatformInfo : AkXboxOneGDKPlatformInfo
    {
        public AkXB1PlatformInfo(nint addr) : base(addr) { }
    }
    public class AkXboxOneInitializationSettings : Object
    {
        public AkXboxOneInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettings CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettings>(); } set { this["CommonSettings"] = value; } }
        public AkXboxOneApuHeapInitializationSettings ApuHeapSettings { get { return this[nameof(ApuHeapSettings)].As<AkXboxOneApuHeapInitializationSettings>(); } set { this["ApuHeapSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkXboxOneAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkXboxOneAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkXboxOnePlatformInfo : AkPlatformInfo
    {
        public AkXboxOnePlatformInfo(nint addr) : base(addr) { }
    }
    public class AkXSXInitializationSettings : Object
    {
        public AkXSXInitializationSettings(nint addr) : base(addr) { }
        public AkCommonInitializationSettings CommonSettings { get { return this[nameof(CommonSettings)].As<AkCommonInitializationSettings>(); } set { this["CommonSettings"] = value; } }
        public AkXSXApuHeapInitializationSettings ApuHeapSettings { get { return this[nameof(ApuHeapSettings)].As<AkXSXApuHeapInitializationSettings>(); } set { this["ApuHeapSettings"] = value; } }
        public AkCommunicationSettingsWithSystemInitialization CommunicationSettings { get { return this[nameof(CommunicationSettings)].As<AkCommunicationSettingsWithSystemInitialization>(); } set { this["CommunicationSettings"] = value; } }
        public AkXSXAdvancedInitializationSettings AdvancedSettings { get { return this[nameof(AdvancedSettings)].As<AkXSXAdvancedInitializationSettings>(); } set { this["AdvancedSettings"] = value; } }
        public void MigrateMultiCoreRendering(bool NewValue) { Invoke(nameof(MigrateMultiCoreRendering), NewValue); }
    }
    public class AkMPXInitializationSettings : AkXSXInitializationSettings
    {
        public AkMPXInitializationSettings(nint addr) : base(addr) { }
    }
    public class AkXSXPlatformInfo : AkPlatformInfo
    {
        public AkXSXPlatformInfo(nint addr) : base(addr) { }
    }
    public class MovieSceneAkAudioEventSection : MovieSceneSection
    {
        public MovieSceneAkAudioEventSection(nint addr) : base(addr) { }
        public AkAudioEvent Event { get { return this[nameof(Event)].As<AkAudioEvent>(); } set { this["Event"] = value; } }
        public bool RetriggerEvent { get { return this[nameof(RetriggerEvent)].Flag; } set { this[nameof(RetriggerEvent)].Flag = value; } }
        public int ScrubTailLengthMs { get { return this[nameof(ScrubTailLengthMs)].GetValue<int>(); } set { this[nameof(ScrubTailLengthMs)].SetValue<int>(value); } }
        public bool StopAtSectionEnd { get { return this[nameof(StopAtSectionEnd)].Flag; } set { this[nameof(StopAtSectionEnd)].Flag = value; } }
        public Object EventName { get { return this[nameof(EventName)]; } set { this[nameof(EventName)] = value; } }
        public float MaxSourceDuration { get { return this[nameof(MaxSourceDuration)].GetValue<float>(); } set { this[nameof(MaxSourceDuration)].SetValue<float>(value); } }
        public Object MaxDurationSourceID { get { return this[nameof(MaxDurationSourceID)]; } set { this[nameof(MaxDurationSourceID)] = value; } }
    }
    public class MovieSceneAkTrack : MovieSceneTrack
    {
        public MovieSceneAkTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
        public bool bIsAMasterTrack { get { return this[nameof(bIsAMasterTrack)].Flag; } set { this[nameof(bIsAMasterTrack)].Flag = value; } }
    }
    public class MovieSceneAkAudioEventTrack : MovieSceneAkTrack
    {
        public MovieSceneAkAudioEventTrack(nint addr) : base(addr) { }
    }
    public class MovieSceneAkAudioRTPCSection : MovieSceneSection
    {
        public MovieSceneAkAudioRTPCSection(nint addr) : base(addr) { }
        public AkRtpc RTPC { get { return this[nameof(RTPC)].As<AkRtpc>(); } set { this["RTPC"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        //public RichCurve FloatCurve { get { return this[nameof(FloatCurve)].As<RichCurve>(); } set { this["FloatCurve"] = value; } }
        //public MovieSceneFloatChannelSerializationHelper FloatChannelSerializationHelper { get { return this[nameof(FloatChannelSerializationHelper)].As<MovieSceneFloatChannelSerializationHelper>(); } set { this["FloatChannelSerializationHelper"] = value; } }
        public MovieSceneFloatChannel RTPCChannel { get { return this[nameof(RTPCChannel)].As<MovieSceneFloatChannel>(); } set { this["RTPCChannel"] = value; } }
    }
    public class MovieSceneAkAudioRTPCTrack : MovieSceneAkTrack
    {
        public MovieSceneAkAudioRTPCTrack(nint addr) : base(addr) { }
    }
    public class PostEventAsync : BlueprintAsyncActionBase
    {
        public PostEventAsync(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public PostEventAsync PostEventAsync_value(Object WorldContextObject, AkAudioEvent AkEvent, Actor Actor, int CallbackMask, Object PostEventCallback, Array<AkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed) { return Invoke<PostEventAsync>(nameof(PostEventAsync_value), WorldContextObject, AkEvent, Actor, CallbackMask, PostEventCallback, ExternalSources, bStopWhenAttachedToDestroyed); }
        public void PollPostEventFuture() { Invoke(nameof(PollPostEventFuture)); }
    }
    public class PostEventAtLocationAsync : BlueprintAsyncActionBase
    {
        public PostEventAtLocationAsync(nint addr) : base(addr) { }
        public Object Completed { get { return this[nameof(Completed)]; } set { this[nameof(Completed)] = value; } }
        public PostEventAtLocationAsync PostEventAtLocationAsync_value(Object WorldContextObject, AkAudioEvent AkEvent, Vector Location, Rotator Orientation) { return Invoke<PostEventAtLocationAsync>(nameof(PostEventAtLocationAsync_value), WorldContextObject, AkEvent, Location, Orientation); }
        public void PollPostEventFuture() { Invoke(nameof(PollPostEventFuture)); }
    }
    public enum EAkResult : int
    {
        NotImplemented = 0,
        Success = 1,
        Fail = 2,
        PartialSuccess = 3,
        NotCompatible = 4,
        AlreadyConnected = 5,
        InvalidFile = 7,
        AudioFileHeaderTooLarge = 8,
        MaxReached = 9,
        InvalidID = 14,
        IDNotFound = 15,
        InvalidInstanceID = 16,
        NoMoreData = 17,
        InvalidStateGroup = 20,
        ChildAlreadyHasAParent = 21,
        InvalidLanguage = 22,
        CannotAddItseflAsAChild = 23,
        InvalidParameter = 31,
        ElementAlreadyInList = 35,
        PathNotFound = 36,
        PathNoVertices = 37,
        PathNotRunning = 38,
        PathNotPaused = 39,
        PathNodeAlreadyInList = 40,
        PathNodeNotInList = 41,
        DataNeeded = 43,
        NoDataNeeded = 44,
        DataReady = 45,
        NoDataReady = 46,
        InsufficientMemory = 52,
        Cancelled = 53,
        UnknownBankID = 54,
        BankReadError = 56,
        InvalidSwitchType = 57,
        FormatNotReady = 63,
        WrongBankVersion = 64,
        FileNotFound = 66,
        DeviceNotReady = 67,
        BankAlreadyLoaded = 69,
        RenderedFX = 71,
        ProcessNeeded = 72,
        ProcessDone = 73,
        MemManagerNotInitialized = 74,
        StreamMgrNotInitialized = 75,
        SSEInstructionsNotSupported = 76,
        Busy = 77,
        UnsupportedChannelConfig = 78,
        PluginMediaNotAvailable = 79,
        MustBeVirtualized = 80,
        CommandTooLarge = 81,
        RejectedByFilter = 82,
        InvalidCustomPlatformName = 83,
        DLLCannotLoad = 84,
        DLLPathNotFound = 85,
        NoJavaVM = 86,
        OpenSLError = 87,
        PluginNotRegistered = 88,
        DataAlignmentError = 89,
        EAkResult_MAX = 90,
    }
    public enum EAkCallbackType : int
    {
        EndOfEvent = 0,
        Marker = 2,
        Duration = 3,
        Starvation = 5,
        MusicPlayStarted = 7,
        MusicSyncBeat = 8,
        MusicSyncBar = 9,
        MusicSyncEntry = 10,
        MusicSyncExit = 11,
        MusicSyncGrid = 12,
        MusicSyncUserCue = 13,
        MusicSyncPoint = 14,
        MIDIEvent = 16,
        EAkCallbackType_MAX = 17,
    }
    public class AKWaapiJsonObject : Object
    {
        public AKWaapiJsonObject(nint addr) : base(addr) { }
    }
    public class AkWaapiSubscriptionId : Object
    {
        public AkWaapiSubscriptionId(nint addr) : base(addr) { }
    }
    public enum EAkAndroidAudioAPI : int
    {
        AAudio = 0,
        OpenSL_ES = 1,
        EAkAndroidAudioAPI_MAX = 2,
    }
    public enum EAkAudioSessionCategory : int
    {
        Ambient = 0,
        SoloAmbient = 1,
        PlayAndRecord = 2,
        EAkAudioSessionCategory_MAX = 3,
    }
    public enum EAkAudioSessionCategoryOptions : int
    {
        MixWithOthers = 0,
        DuckOthers = 1,
        AllowBluetooth = 2,
        DefaultToSpeaker = 3,
        EAkAudioSessionCategoryOptions_MAX = 4,
    }
    public enum EAkAudioSessionMode : int
    {
        Default = 0,
        VoiceChat = 1,
        GameChat = 2,
        VideoRecording = 3,
        Measurement = 4,
        MoviePlayback = 5,
        VideoChat = 6,
        EAkAudioSessionMode_MAX = 7,
    }
    public enum EReflectionFilterBits : int
    {
        Wall = 0,
        Ceiling = 1,
        Floor = 2,
        EReflectionFilterBits_MAX = 3,
    }
    public enum EAkAudioContext : int
    {
        Foreign = 0,
        GameplayAudio = 1,
        EditorAudio = 2,
        AlwaysActive = 3,
        EAkAudioContext_MAX = 4,
    }
    public enum PanningRule : int
    {
        PanningRule_Speakers = 0,
        PanningRule_Headphones = 1,
        PanningRule_MAX = 2,
    }
    public enum AkAcousticPortalState : int
    {
        Closed = 0,
        Open = 1,
        AkAcousticPortalState_MAX = 2,
    }
    public enum AkChannelConfiguration : int
    {
        Ak_Parent = 0,
        Ak_MainMix = 1,
        Ak_Passthrough = 2,
        Ak_LFE = 3,
        AK_Audio_Objects = 4,
        Ak_1_1 = 5,
        Ak_2_1 = 6,
        Ak_2_2 = 7,
        Ak_3_1 = 8,
        Ak_3_2 = 9,
        Ak_4_1 = 10,
        Ak_4_2 = 11,
        Ak_5_1 = 12,
        Ak_5_2 = 13,
        Ak_7_2 = 14,
        Ak_5_1_3 = 15,
        Ak_7_1_3 = 16,
        Ak_7_1_5 = 17,
        Ak_Auro_9_2 = 18,
        Ak_Auro_10_2 = 19,
        Ak_Auro_11_2 = 20,
        Ak_Auro_13_2 = 21,
        Ak_Ambisonics_1st_order = 22,
        Ak_Ambisonics_2nd_order = 23,
        Ak_Ambisonics_3rd_order = 24,
        Ak_Ambisonics_4th_order = 25,
        Ak_Ambisonics_5th_order = 26,
        AkChannelConfiguration_MAX = 27,
    }
    public enum AkSpeakerConfiguration : int
    {
        Ak_Speaker_Front_Left = 1,
        Ak_Speaker_Front_Right = 2,
        Ak_Speaker_Front_Center = 4,
        Ak_Speaker_Low_Frequency = 8,
        Ak_Speaker_Back_Left = 16,
        Ak_Speaker_Back_Right = 32,
        Ak_Speaker_Back_Center = 256,
        Ak_Speaker_Side_Left = 512,
        Ak_Speaker_Side_Right = 1024,
        Ak_Speaker_Top = 2048,
        Ak_Speaker_Height_Front_Left = 4096,
        Ak_Speaker_Height_Front_Center = 8192,
        Ak_Speaker_Height_Front_Right = 16384,
        Ak_Speaker_Height_Back_Left = 32768,
        Ak_Speaker_Height_Back_Center = 65536,
        Ak_Speaker_Height_Back_Right = 131072,
        Ak_Speaker_MAX = 131073,
    }
    public enum AkMultiPositionType : int
    {
        SingleSource = 0,
        MultiSources = 1,
        MultiDirections = 2,
        AkMultiPositionType_MAX = 3,
    }
    public enum AkActionOnEventType : int
    {
        Stop = 0,
        Pause = 1,
        Resume = 2,
        Break = 3,
        ReleaseEnvelope = 4,
        AkActionOnEventType_MAX = 5,
    }
    public enum EAkCurveInterpolation : int
    {
        Log3 = 0,
        Sine = 1,
        Log1 = 2,
        InvSCurve = 3,
        Linear = 4,
        SCurve = 5,
        Exp1 = 6,
        SineRecip = 7,
        Exp3 = 8,
        LastFadeCurve = 8,
        Constant = 9,
        EAkCurveInterpolation_MAX = 10,
    }
    public enum ERTPCValueType : int
    {
        Default = 0,
        Global = 1,
        GameObject = 2,
        PlayingID = 3,
        Unavailable = 4,
        ERTPCValueType_MAX = 5,
    }
    public enum EAkMidiEventType : int
    {
        AkMidiEventTypeInvalid = 0,
        AkMidiEventTypeNoteOff = 128,
        AkMidiEventTypeNoteOn = 144,
        AkMidiEventTypeNoteAftertouch = 160,
        AkMidiEventTypeController = 176,
        AkMidiEventTypeProgramChange = 192,
        AkMidiEventTypeChannelAftertouch = 208,
        AkMidiEventTypePitchBend = 224,
        AkMidiEventTypeSysex = 240,
        AkMidiEventTypeEscape = 247,
        AkMidiEventTypeMeta = 255,
        EAkMidiEventType_MAX = 256,
    }
    public enum EAkMidiCcValues : int
    {
        AkMidiCcBankSelectCoarse = 0,
        AkMidiCcModWheelCoarse = 1,
        AkMidiCcBreathCtrlCoarse = 2,
        AkMidiCcCtrl3Coarse = 3,
        AkMidiCcFootPedalCoarse = 4,
        AkMidiCcPortamentoCoarse = 5,
        AkMidiCcDataEntryCoarse = 6,
        AkMidiCcVolumeCoarse = 7,
        AkMidiCcBalanceCoarse = 8,
        AkMidiCcCtrl9Coarse = 9,
        AkMidiCcPanPositionCoarse = 10,
        AkMidiCcExpressionCoarse = 11,
        AkMidiCcEffectCtrl1Coarse = 12,
        AkMidiCcEffectCtrl2Coarse = 13,
        AkMidiCcCtrl14Coarse = 14,
        AkMidiCcCtrl15Coarse = 15,
        AkMidiCcGenSlider1 = 16,
        AkMidiCcGenSlider2 = 17,
        AkMidiCcGenSlider3 = 18,
        AkMidiCcGenSlider4 = 19,
        AkMidiCcCtrl20Coarse = 20,
        AkMidiCcCtrl21Coarse = 21,
        AkMidiCcCtrl22Coarse = 22,
        AkMidiCcCtrl23Coarse = 23,
        AkMidiCcCtrl24Coarse = 24,
        AkMidiCcCtrl25Coarse = 25,
        AkMidiCcCtrl26Coarse = 26,
        AkMidiCcCtrl27Coarse = 27,
        AkMidiCcCtrl28Coarse = 28,
        AkMidiCcCtrl29Coarse = 29,
        AkMidiCcCtrl30Coarse = 30,
        AkMidiCcCtrl31Coarse = 31,
        AkMidiCcBankSelectFine = 32,
        AkMidiCcModWheelFine = 33,
        AkMidiCcBreathCtrlFine = 34,
        AkMidiCcCtrl3Fine = 35,
        AkMidiCcFootPedalFine = 36,
        AkMidiCcPortamentoFine = 37,
        AkMidiCcDataEntryFine = 38,
        AkMidiCcVolumeFine = 39,
        AkMidiCcBalanceFine = 40,
        AkMidiCcCtrl9Fine = 41,
        AkMidiCcPanPositionFine = 42,
        AkMidiCcExpressionFine = 43,
        AkMidiCcEffectCtrl1Fine = 44,
        AkMidiCcEffectCtrl2Fine = 45,
        AkMidiCcCtrl14Fine = 46,
        AkMidiCcCtrl15Fine = 47,
        AkMidiCcCtrl20Fine = 52,
        AkMidiCcCtrl21Fine = 53,
        AkMidiCcCtrl22Fine = 54,
        AkMidiCcCtrl23Fine = 55,
        AkMidiCcCtrl24Fine = 56,
        AkMidiCcCtrl25Fine = 57,
        AkMidiCcCtrl26Fine = 58,
        AkMidiCcCtrl27Fine = 59,
        AkMidiCcCtrl28Fine = 60,
        AkMidiCcCtrl29Fine = 61,
        AkMidiCcCtrl30Fine = 62,
        AkMidiCcCtrl31Fine = 63,
        AkMidiCcHoldPedal = 64,
        AkMidiCcPortamentoOnOff = 65,
        AkMidiCcSustenutoPedal = 66,
        AkMidiCcSoftPedal = 67,
        AkMidiCcLegatoPedal = 68,
        AkMidiCcHoldPedal2 = 69,
        AkMidiCcSoundVariation = 70,
        AkMidiCcSoundTimbre = 71,
        AkMidiCcSoundReleaseTime = 72,
        AkMidiCcSoundAttackTime = 73,
        AkMidiCcSoundBrightness = 74,
        AkMidiCcSoundCtrl6 = 75,
        AkMidiCcSoundCtrl7 = 76,
        AkMidiCcSoundCtrl8 = 77,
        AkMidiCcSoundCtrl9 = 78,
        AkMidiCcSoundCtrl10 = 79,
        AkMidiCcGeneralButton1 = 80,
        AkMidiCcGeneralButton2 = 81,
        AkMidiCcGeneralButton3 = 82,
        AkMidiCcGeneralButton4 = 83,
        AkMidiCcReverbLevel = 91,
        AkMidiCcTremoloLevel = 92,
        AkMidiCcChorusLevel = 93,
        AkMidiCcCelesteLevel = 94,
        AkMidiCcPhaserLevel = 95,
        AkMidiCcDataButtonP1 = 96,
        AkMidiCcDataButtonM1 = 97,
        AkMidiCcNonRegisterCoarse = 98,
        AkMidiCcNonRegisterFine = 99,
        AkMidiCcAllSoundOff = 120,
        AkMidiCcAllControllersOff = 121,
        AkMidiCcLocalKeyboard = 122,
        AkMidiCcAllNotesOff = 123,
        AkMidiCcOmniModeOff = 124,
        AkMidiCcOmniModeOn = 125,
        AkMidiCcOmniMonophonicOn = 126,
        AkMidiCcOmniPolyphonicOn = 127,
        EAkMidiCcValues_MAX = 128,
    }
    public enum AkCodecId : int
    {
        None = 0,
        PCM = 1,
        ADPCM = 2,
        XMA = 3,
        Vorbis = 4,
        AAC = 10,
        ATRAC9 = 12,
        OpusNX = 17,
        AkOpus = 19,
        AkOpusWEM = 20,
        AkCodecId_MAX = 21,
    }
    public enum AkMeshType : int
    {
        StaticMesh = 0,
        CollisionMesh = 1,
        AkMeshType_MAX = 2,
    }
    public enum EAkPanningRule : int
    {
        Speakers = 0,
        Headphones = 1,
        EAkPanningRule_MAX = 2,
    }
    public enum EAkChannelConfigType : int
    {
        Anonymous = 0,
        Standard = 1,
        Ambisonic = 2,
        EAkChannelConfigType_MAX = 3,
    }
    public enum EAkChannelMask : int
    {
        FrontLeft = 0,
        FrontRight = 1,
        FrontCenter = 2,
        LowFrequency = 3,
        BackLeft = 4,
        BackRight = 5,
        BackCenter = 8,
        SideLeft = 9,
        SideRight = 10,
        Top = 11,
        HeightFrontLeft = 12,
        HeightFrontCenter = 13,
        HeightFrontRight = 14,
        HeightBackLeft = 15,
        HeightBackCenter = 16,
        HeightBackRight = 17,
        EAkChannelMask_MAX = 18,
    }
    public enum EAkCommSystem : int
    {
        Socket = 0,
        HTCS = 1,
        EAkCommSystem_MAX = 2,
    }
    public enum EAkFitToGeometryMode : int
    {
        OrientedBox = 0,
        AlignedBox = 1,
        ConvexPolyhedron = 2,
        EAkFitToGeometryMode_MAX = 3,
    }
    public class AkAdvancedInitializationSettings : Object
    {
        public AkAdvancedInitializationSettings(nint addr) : base(addr) { }
        public uint IO_MemorySize { get { return this[nameof(IO_MemorySize)].GetValue<uint>(); } set { this[nameof(IO_MemorySize)].SetValue<uint>(value); } }
        public uint IO_Granularity { get { return this[nameof(IO_Granularity)].GetValue<uint>(); } set { this[nameof(IO_Granularity)].SetValue<uint>(value); } }
        public float TargetAutoStreamBufferLength { get { return this[nameof(TargetAutoStreamBufferLength)].GetValue<float>(); } set { this[nameof(TargetAutoStreamBufferLength)].SetValue<float>(value); } }
        public bool UseStreamCache { get { return this[nameof(UseStreamCache)].Flag; } set { this[nameof(UseStreamCache)].Flag = value; } }
        public uint MaximumPinnedBytesInCache { get { return this[nameof(MaximumPinnedBytesInCache)].GetValue<uint>(); } set { this[nameof(MaximumPinnedBytesInCache)].SetValue<uint>(value); } }
        public bool EnableGameSyncPreparation { get { return this[nameof(EnableGameSyncPreparation)].Flag; } set { this[nameof(EnableGameSyncPreparation)].Flag = value; } }
        public uint ContinuousPlaybackLookAhead { get { return this[nameof(ContinuousPlaybackLookAhead)].GetValue<uint>(); } set { this[nameof(ContinuousPlaybackLookAhead)].SetValue<uint>(value); } }
        public uint MonitorQueuePoolSize { get { return this[nameof(MonitorQueuePoolSize)].GetValue<uint>(); } set { this[nameof(MonitorQueuePoolSize)].SetValue<uint>(value); } }
        public uint MaximumHardwareTimeoutMs { get { return this[nameof(MaximumHardwareTimeoutMs)].GetValue<uint>(); } set { this[nameof(MaximumHardwareTimeoutMs)].SetValue<uint>(value); } }
        public bool DebugOutOfRangeCheckEnabled { get { return this[nameof(DebugOutOfRangeCheckEnabled)].Flag; } set { this[nameof(DebugOutOfRangeCheckEnabled)].Flag = value; } }
        public float DebugOutOfRangeLimit { get { return this[nameof(DebugOutOfRangeLimit)].GetValue<float>(); } set { this[nameof(DebugOutOfRangeLimit)].SetValue<float>(value); } }
    }
    public class AkAdvancedInitializationSettingsWithMultiCoreRendering : AkAdvancedInitializationSettings
    {
        public AkAdvancedInitializationSettingsWithMultiCoreRendering(nint addr) : base(addr) { }
        public bool EnableMultiCoreRendering { get { return this[nameof(EnableMultiCoreRendering)].Flag; } set { this[nameof(EnableMultiCoreRendering)].Flag = value; } }
    }
    public class AkAndroidAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkAndroidAdvancedInitializationSettings(nint addr) : base(addr) { }
        public uint AudioAPI { get { return this[nameof(AudioAPI)].GetValue<uint>(); } set { this[nameof(AudioAPI)].SetValue<uint>(value); } }
        public bool RoundFrameSizeToHardwareSize { get { return this[nameof(RoundFrameSizeToHardwareSize)].Flag; } set { this[nameof(RoundFrameSizeToHardwareSize)].Flag = value; } }
    }
    public class AkAudioSession : Object
    {
        public AkAudioSession(nint addr) : base(addr) { }
        public EAkAudioSessionCategory AudioSessionCategory { get { return (EAkAudioSessionCategory)this[nameof(AudioSessionCategory)].GetValue<int>(); } set { this[nameof(AudioSessionCategory)].SetValue<int>((int)value); } }
        public uint AudioSessionCategoryOptions { get { return this[nameof(AudioSessionCategoryOptions)].GetValue<uint>(); } set { this[nameof(AudioSessionCategoryOptions)].SetValue<uint>(value); } }
        public EAkAudioSessionMode AudioSessionMode { get { return (EAkAudioSessionMode)this[nameof(AudioSessionMode)].GetValue<int>(); } set { this[nameof(AudioSessionMode)].SetValue<int>((int)value); } }
    }
    public class AkChannelMask : Object
    {
        public AkChannelMask(nint addr) : base(addr) { }
        public int ChannelMask { get { return this[nameof(ChannelMask)].GetValue<int>(); } set { this[nameof(ChannelMask)].SetValue<int>(value); } }
    }
    public class AkOutputSettings : Object
    {
        public AkOutputSettings(nint addr) : base(addr) { }
        public Object AudioDeviceSharesetName { get { return this[nameof(AudioDeviceSharesetName)]; } set { this[nameof(AudioDeviceSharesetName)] = value; } }
        public int IdDevice { get { return this[nameof(IdDevice)].GetValue<int>(); } set { this[nameof(IdDevice)].SetValue<int>(value); } }
        public PanningRule PanRule { get { return (PanningRule)this[nameof(PanRule)].GetValue<int>(); } set { this[nameof(PanRule)].SetValue<int>((int)value); } }
        public AkChannelConfiguration ChannelConfig { get { return (AkChannelConfiguration)this[nameof(ChannelConfig)].GetValue<int>(); } set { this[nameof(ChannelConfig)].SetValue<int>((int)value); } }
    }
    public class AkMidiEventBase : Object
    {
        public AkMidiEventBase(nint addr) : base(addr) { }
        public EAkMidiEventType Type { get { return (EAkMidiEventType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public byte Chan { get { return this[nameof(Chan)].GetValue<byte>(); } set { this[nameof(Chan)].SetValue<byte>(value); } }
    }
    public class AkMidiGeneric : AkMidiEventBase
    {
        public AkMidiGeneric(nint addr) : base(addr) { }
        public byte Param1 { get { return this[nameof(Param1)].GetValue<byte>(); } set { this[nameof(Param1)].SetValue<byte>(value); } }
        public byte Param2 { get { return this[nameof(Param2)].GetValue<byte>(); } set { this[nameof(Param2)].SetValue<byte>(value); } }
    }
    public class AkMidiNoteOnOff : AkMidiEventBase
    {
        public AkMidiNoteOnOff(nint addr) : base(addr) { }
        public byte Note { get { return this[nameof(Note)].GetValue<byte>(); } set { this[nameof(Note)].SetValue<byte>(value); } }
        public byte Velocity { get { return this[nameof(Velocity)].GetValue<byte>(); } set { this[nameof(Velocity)].SetValue<byte>(value); } }
    }
    public class AkMidiCc : AkMidiEventBase
    {
        public AkMidiCc(nint addr) : base(addr) { }
        public EAkMidiCcValues Cc { get { return (EAkMidiCcValues)this[nameof(Cc)].GetValue<int>(); } set { this[nameof(Cc)].SetValue<int>((int)value); } }
        public byte Value { get { return this[nameof(Value)].GetValue<byte>(); } set { this[nameof(Value)].SetValue<byte>(value); } }
    }
    public class AkMidiPitchBend : AkMidiEventBase
    {
        public AkMidiPitchBend(nint addr) : base(addr) { }
        public byte ValueLsb { get { return this[nameof(ValueLsb)].GetValue<byte>(); } set { this[nameof(ValueLsb)].SetValue<byte>(value); } }
        public byte ValueMsb { get { return this[nameof(ValueMsb)].GetValue<byte>(); } set { this[nameof(ValueMsb)].SetValue<byte>(value); } }
        public int FullValue { get { return this[nameof(FullValue)].GetValue<int>(); } set { this[nameof(FullValue)].SetValue<int>(value); } }
    }
    public class AkMidiNoteAftertouch : AkMidiEventBase
    {
        public AkMidiNoteAftertouch(nint addr) : base(addr) { }
        public byte Note { get { return this[nameof(Note)].GetValue<byte>(); } set { this[nameof(Note)].SetValue<byte>(value); } }
        public byte Value { get { return this[nameof(Value)].GetValue<byte>(); } set { this[nameof(Value)].SetValue<byte>(value); } }
    }
    public class AkMidiChannelAftertouch : AkMidiEventBase
    {
        public AkMidiChannelAftertouch(nint addr) : base(addr) { }
        public byte Value { get { return this[nameof(Value)].GetValue<byte>(); } set { this[nameof(Value)].SetValue<byte>(value); } }
    }
    public class AkMidiProgramChange : AkMidiEventBase
    {
        public AkMidiProgramChange(nint addr) : base(addr) { }
        public byte ProgramNum { get { return this[nameof(ProgramNum)].GetValue<byte>(); } set { this[nameof(ProgramNum)].SetValue<byte>(value); } }
    }
    public class AkSegmentInfo : Object
    {
        public AkSegmentInfo(nint addr) : base(addr) { }
        public int CurrentPosition { get { return this[nameof(CurrentPosition)].GetValue<int>(); } set { this[nameof(CurrentPosition)].SetValue<int>(value); } }
        public int PreEntryDuration { get { return this[nameof(PreEntryDuration)].GetValue<int>(); } set { this[nameof(PreEntryDuration)].SetValue<int>(value); } }
        public int ActiveDuration { get { return this[nameof(ActiveDuration)].GetValue<int>(); } set { this[nameof(ActiveDuration)].SetValue<int>(value); } }
        public int PostExitDuration { get { return this[nameof(PostExitDuration)].GetValue<int>(); } set { this[nameof(PostExitDuration)].SetValue<int>(value); } }
        public int RemainingLookAheadTime { get { return this[nameof(RemainingLookAheadTime)].GetValue<int>(); } set { this[nameof(RemainingLookAheadTime)].SetValue<int>(value); } }
        public float BeatDuration { get { return this[nameof(BeatDuration)].GetValue<float>(); } set { this[nameof(BeatDuration)].SetValue<float>(value); } }
        public float BarDuration { get { return this[nameof(BarDuration)].GetValue<float>(); } set { this[nameof(BarDuration)].SetValue<float>(value); } }
        public float GridDuration { get { return this[nameof(GridDuration)].GetValue<float>(); } set { this[nameof(GridDuration)].SetValue<float>(value); } }
        public float GridOffset { get { return this[nameof(GridOffset)].GetValue<float>(); } set { this[nameof(GridOffset)].SetValue<float>(value); } }
    }
    public class AkExternalSourceInfo : Object
    {
        public AkExternalSourceInfo(nint addr) : base(addr) { }
        public Object ExternalSrcName { get { return this[nameof(ExternalSrcName)]; } set { this[nameof(ExternalSrcName)] = value; } }
        public AkCodecId CodecID { get { return (AkCodecId)this[nameof(CodecID)].GetValue<int>(); } set { this[nameof(CodecID)].SetValue<int>((int)value); } }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public AkExternalMediaAsset ExternalSourceAsset { get { return this[nameof(ExternalSourceAsset)].As<AkExternalMediaAsset>(); } set { this["ExternalSourceAsset"] = value; } }
        public bool IsStreamed { get { return this[nameof(IsStreamed)].Flag; } set { this[nameof(IsStreamed)].Flag = value; } }
    }
    public class AkGeometrySurfaceOverride : Object
    {
        public AkGeometrySurfaceOverride(nint addr) : base(addr) { }
        public AkAcousticTexture AcousticTexture { get { return this[nameof(AcousticTexture)].As<AkAcousticTexture>(); } set { this["AcousticTexture"] = value; } }
        public bool bEnableOcclusionOverride { get { return this[nameof(bEnableOcclusionOverride)].Flag; } set { this[nameof(bEnableOcclusionOverride)].Flag = value; } }
        public float OcclusionValue { get { return this[nameof(OcclusionValue)].GetValue<float>(); } set { this[nameof(OcclusionValue)].SetValue<float>(value); } }
        public float SurfaceArea { get { return this[nameof(SurfaceArea)].GetValue<float>(); } set { this[nameof(SurfaceArea)].SetValue<float>(value); } }
    }
    public class AkAcousticSurface : Object
    {
        public AkAcousticSurface(nint addr) : base(addr) { }
        public uint Texture { get { return this[nameof(Texture)].GetValue<uint>(); } set { this[nameof(Texture)].SetValue<uint>(value); } }
        public float Occlusion { get { return this[nameof(Occlusion)].GetValue<float>(); } set { this[nameof(Occlusion)].SetValue<float>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class AkTriangle : Object
    {
        public AkTriangle(nint addr) : base(addr) { }
        public ushort Point0 { get { return this[nameof(Point0)].GetValue<ushort>(); } set { this[nameof(Point0)].SetValue<ushort>(value); } }
        public ushort point1 { get { return this[nameof(point1)].GetValue<ushort>(); } set { this[nameof(point1)].SetValue<ushort>(value); } }
        public ushort point2 { get { return this[nameof(point2)].GetValue<ushort>(); } set { this[nameof(point2)].SetValue<ushort>(value); } }
        public ushort Surface { get { return this[nameof(Surface)].GetValue<ushort>(); } set { this[nameof(Surface)].SetValue<ushort>(value); } }
    }
    public class AkGeometryData : Object
    {
        public AkGeometryData(nint addr) : base(addr) { }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<AkAcousticSurface> Surfaces { get { return new Array<AkAcousticSurface>(this[nameof(Surfaces)].Address); } }
        public Array<AkTriangle> Triangles { get { return new Array<AkTriangle>(this[nameof(Triangles)].Address); } }
        public Array<PhysicalMaterial> ToOverrideAcousticTexture { get { return new Array<PhysicalMaterial>(this[nameof(ToOverrideAcousticTexture)].Address); } }
        public Array<PhysicalMaterial> ToOverrideOcclusion { get { return new Array<PhysicalMaterial>(this[nameof(ToOverrideOcclusion)].Address); } }
    }
    public class AkHololensAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkHololensAdvancedInitializationSettings(nint addr) : base(addr) { }
        public bool UseHeadMountedDisplayAudioDevice { get { return this[nameof(UseHeadMountedDisplayAudioDevice)].Flag; } set { this[nameof(UseHeadMountedDisplayAudioDevice)].Flag = value; } }
    }
    public class AkPluginInfo : Object
    {
        public AkPluginInfo(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public uint PluginID { get { return this[nameof(PluginID)].GetValue<uint>(); } set { this[nameof(PluginID)].SetValue<uint>(value); } }
        public Object dll { get { return this[nameof(dll)]; } set { this[nameof(dll)] = value; } }
    }
    public class AkMainOutputSettings : Object
    {
        public AkMainOutputSettings(nint addr) : base(addr) { }
        public Object AudioDeviceShareset { get { return this[nameof(AudioDeviceShareset)]; } set { this[nameof(AudioDeviceShareset)] = value; } }
        public uint DeviceID { get { return this[nameof(DeviceID)].GetValue<uint>(); } set { this[nameof(DeviceID)].SetValue<uint>(value); } }
        public EAkPanningRule PanningRule { get { return (EAkPanningRule)this[nameof(PanningRule)].GetValue<int>(); } set { this[nameof(PanningRule)].SetValue<int>((int)value); } }
        public EAkChannelConfigType ChannelConfigType { get { return (EAkChannelConfigType)this[nameof(ChannelConfigType)].GetValue<int>(); } set { this[nameof(ChannelConfigType)].SetValue<int>((int)value); } }
        public uint ChannelMask { get { return this[nameof(ChannelMask)].GetValue<uint>(); } set { this[nameof(ChannelMask)].SetValue<uint>(value); } }
        public uint NumberOfChannels { get { return this[nameof(NumberOfChannels)].GetValue<uint>(); } set { this[nameof(NumberOfChannels)].SetValue<uint>(value); } }
    }
    public class AkSpatialAudioSettings : Object
    {
        public AkSpatialAudioSettings(nint addr) : base(addr) { }
        public uint MaxSoundPropagationDepth { get { return this[nameof(MaxSoundPropagationDepth)].GetValue<uint>(); } set { this[nameof(MaxSoundPropagationDepth)].SetValue<uint>(value); } }
        public float MovementThreshold { get { return this[nameof(MovementThreshold)].GetValue<float>(); } set { this[nameof(MovementThreshold)].SetValue<float>(value); } }
        public uint NumberOfPrimaryRays { get { return this[nameof(NumberOfPrimaryRays)].GetValue<uint>(); } set { this[nameof(NumberOfPrimaryRays)].SetValue<uint>(value); } }
        public uint ReflectionOrder { get { return this[nameof(ReflectionOrder)].GetValue<uint>(); } set { this[nameof(ReflectionOrder)].SetValue<uint>(value); } }
        public float MaximumPathLength { get { return this[nameof(MaximumPathLength)].GetValue<float>(); } set { this[nameof(MaximumPathLength)].SetValue<float>(value); } }
        public float CPULimitPercentage { get { return this[nameof(CPULimitPercentage)].GetValue<float>(); } set { this[nameof(CPULimitPercentage)].SetValue<float>(value); } }
        public bool EnableDiffractionOnReflections { get { return this[nameof(EnableDiffractionOnReflections)].Flag; } set { this[nameof(EnableDiffractionOnReflections)].Flag = value; } }
        public bool EnableGeometricDiffractionAndTransmission { get { return this[nameof(EnableGeometricDiffractionAndTransmission)].Flag; } set { this[nameof(EnableGeometricDiffractionAndTransmission)].Flag = value; } }
        public bool CalcEmitterVirtualPosition { get { return this[nameof(CalcEmitterVirtualPosition)].Flag; } set { this[nameof(CalcEmitterVirtualPosition)].Flag = value; } }
        public bool UseObstruction { get { return this[nameof(UseObstruction)].Flag; } set { this[nameof(UseObstruction)].Flag = value; } }
        public bool UseOcclusion { get { return this[nameof(UseOcclusion)].Flag; } set { this[nameof(UseOcclusion)].Flag = value; } }
    }
    public class AkCommunicationSettings : Object
    {
        public AkCommunicationSettings(nint addr) : base(addr) { }
        public uint PoolSize { get { return this[nameof(PoolSize)].GetValue<uint>(); } set { this[nameof(PoolSize)].SetValue<uint>(value); } }
        public ushort DiscoveryBroadcastPort { get { return this[nameof(DiscoveryBroadcastPort)].GetValue<ushort>(); } set { this[nameof(DiscoveryBroadcastPort)].SetValue<ushort>(value); } }
        public ushort CommandPort { get { return this[nameof(CommandPort)].GetValue<ushort>(); } set { this[nameof(CommandPort)].SetValue<ushort>(value); } }
        public ushort NotificationPort { get { return this[nameof(NotificationPort)].GetValue<ushort>(); } set { this[nameof(NotificationPort)].SetValue<ushort>(value); } }
        public Object NetworkName { get { return this[nameof(NetworkName)]; } set { this[nameof(NetworkName)] = value; } }
    }
    public class AkCommunicationSettingsWithSystemInitialization : AkCommunicationSettings
    {
        public AkCommunicationSettingsWithSystemInitialization(nint addr) : base(addr) { }
        public bool InitializeSystemComms { get { return this[nameof(InitializeSystemComms)].Flag; } set { this[nameof(InitializeSystemComms)].Flag = value; } }
    }
    public class AkCommunicationSettingsWithCommSelection : AkCommunicationSettings
    {
        public AkCommunicationSettingsWithCommSelection(nint addr) : base(addr) { }
        public EAkCommSystem CommunicationSystem { get { return (EAkCommSystem)this[nameof(CommunicationSystem)].GetValue<int>(); } set { this[nameof(CommunicationSystem)].SetValue<int>((int)value); } }
    }
    public class AkCommonInitializationSettings : Object
    {
        public AkCommonInitializationSettings(nint addr) : base(addr) { }
        public uint MaximumNumberOfMemoryPools { get { return this[nameof(MaximumNumberOfMemoryPools)].GetValue<uint>(); } set { this[nameof(MaximumNumberOfMemoryPools)].SetValue<uint>(value); } }
        public uint MaximumNumberOfPositioningPaths { get { return this[nameof(MaximumNumberOfPositioningPaths)].GetValue<uint>(); } set { this[nameof(MaximumNumberOfPositioningPaths)].SetValue<uint>(value); } }
        public uint CommandQueueSize { get { return this[nameof(CommandQueueSize)].GetValue<uint>(); } set { this[nameof(CommandQueueSize)].SetValue<uint>(value); } }
        public uint SamplesPerFrame { get { return this[nameof(SamplesPerFrame)].GetValue<uint>(); } set { this[nameof(SamplesPerFrame)].SetValue<uint>(value); } }
        public AkMainOutputSettings MainOutputSettings { get { return this[nameof(MainOutputSettings)].As<AkMainOutputSettings>(); } set { this["MainOutputSettings"] = value; } }
        public float StreamingLookAheadRatio { get { return this[nameof(StreamingLookAheadRatio)].GetValue<float>(); } set { this[nameof(StreamingLookAheadRatio)].SetValue<float>(value); } }
        public ushort NumberOfRefillsInVoice { get { return this[nameof(NumberOfRefillsInVoice)].GetValue<ushort>(); } set { this[nameof(NumberOfRefillsInVoice)].SetValue<ushort>(value); } }
        public AkSpatialAudioSettings SpatialAudioSettings { get { return this[nameof(SpatialAudioSettings)].As<AkSpatialAudioSettings>(); } set { this["SpatialAudioSettings"] = value; } }
    }
    public class AkCommonInitializationSettingsWithSampleRate : AkCommonInitializationSettings
    {
        public AkCommonInitializationSettingsWithSampleRate(nint addr) : base(addr) { }
        public uint SampleRate { get { return this[nameof(SampleRate)].GetValue<uint>(); } set { this[nameof(SampleRate)].SetValue<uint>(value); } }
    }
    public class AkBoolPropertyToControl : Object
    {
        public AkBoolPropertyToControl(nint addr) : base(addr) { }
        public Object ItemProperty { get { return this[nameof(ItemProperty)]; } set { this[nameof(ItemProperty)] = value; } }
    }
    public class AkPropertyToControl : Object
    {
        public AkPropertyToControl(nint addr) : base(addr) { }
        public Object ItemProperty { get { return this[nameof(ItemProperty)]; } set { this[nameof(ItemProperty)] = value; } }
    }
    public class AkPS4AdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkPS4AdvancedInitializationSettings(nint addr) : base(addr) { }
        public uint ACPBatchBufferSize { get { return this[nameof(ACPBatchBufferSize)].GetValue<uint>(); } set { this[nameof(ACPBatchBufferSize)].SetValue<uint>(value); } }
        public bool UseHardwareCodecLowLatencyMode { get { return this[nameof(UseHardwareCodecLowLatencyMode)].Flag; } set { this[nameof(UseHardwareCodecLowLatencyMode)].Flag = value; } }
    }
    public class AkReverbDescriptor : Object
    {
        public AkReverbDescriptor(nint addr) : base(addr) { }
    }
    public class AkGeometrySurfacePropertiesToMap : Object
    {
        public AkGeometrySurfacePropertiesToMap(nint addr) : base(addr) { }
        public Object AcousticTexture { get { return this[nameof(AcousticTexture)]; } set { this[nameof(AcousticTexture)] = value; } }
        public float OcclusionValue { get { return this[nameof(OcclusionValue)].GetValue<float>(); } set { this[nameof(OcclusionValue)].SetValue<float>(value); } }
    }
    public class AkAcousticTextureParams : Object
    {
        public AkAcousticTextureParams(nint addr) : base(addr) { }
        public Vector4 AbsorptionValues { get { return this[nameof(AbsorptionValues)].As<Vector4>(); } set { this["AbsorptionValues"] = value; } }
    }
    public class AkWwiseObjectDetails : Object
    {
        public AkWwiseObjectDetails(nint addr) : base(addr) { }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
        public Object ItemPath { get { return this[nameof(ItemPath)]; } set { this[nameof(ItemPath)] = value; } }
        public Object ItemId { get { return this[nameof(ItemId)]; } set { this[nameof(ItemId)] = value; } }
    }
    public class AkWwiseItemToControl : Object
    {
        public AkWwiseItemToControl(nint addr) : base(addr) { }
        public AkWwiseObjectDetails ItemPicked { get { return this[nameof(ItemPicked)].As<AkWwiseObjectDetails>(); } set { this["ItemPicked"] = value; } }
        public Object ItemPath { get { return this[nameof(ItemPath)]; } set { this[nameof(ItemPath)] = value; } }
    }
    public class AkSurfaceEdgeVerts : Object
    {
        public AkSurfaceEdgeVerts(nint addr) : base(addr) { }
    }
    public class AkSurfaceEdgeInfo : Object
    {
        public AkSurfaceEdgeInfo(nint addr) : base(addr) { }
    }
    public class AkSurfacePoly : Object
    {
        public AkSurfacePoly(nint addr) : base(addr) { }
        public AkAcousticTexture Texture { get { return this[nameof(Texture)].As<AkAcousticTexture>(); } set { this["Texture"] = value; } }
        public float Occlusion { get { return this[nameof(Occlusion)].GetValue<float>(); } set { this[nameof(Occlusion)].SetValue<float>(value); } }
        public bool EnableSurface { get { return this[nameof(EnableSurface)].Flag; } set { this[nameof(EnableSurface)].Flag = value; } }
        public float SurfaceArea { get { return this[nameof(SurfaceArea)].GetValue<float>(); } set { this[nameof(SurfaceArea)].SetValue<float>(value); } }
    }
    public class AkWaapiFieldNames : Object
    {
        public AkWaapiFieldNames(nint addr) : base(addr) { }
        public Object FieldName { get { return this[nameof(FieldName)]; } set { this[nameof(FieldName)] = value; } }
    }
    public class AkWaapiUri : Object
    {
        public AkWaapiUri(nint addr) : base(addr) { }
        public Object Uri { get { return this[nameof(Uri)]; } set { this[nameof(Uri)] = value; } }
    }
    public class AkWindowsAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkWindowsAdvancedInitializationSettings(nint addr) : base(addr) { }
        public bool UseHeadMountedDisplayAudioDevice { get { return this[nameof(UseHeadMountedDisplayAudioDevice)].Flag; } set { this[nameof(UseHeadMountedDisplayAudioDevice)].Flag = value; } }
        public uint MaxSystemAudioObjects { get { return this[nameof(MaxSystemAudioObjects)].GetValue<uint>(); } set { this[nameof(MaxSystemAudioObjects)].SetValue<uint>(value); } }
    }
    public class AkWinGDKAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkWinGDKAdvancedInitializationSettings(nint addr) : base(addr) { }
        public bool UseHeadMountedDisplayAudioDevice { get { return this[nameof(UseHeadMountedDisplayAudioDevice)].Flag; } set { this[nameof(UseHeadMountedDisplayAudioDevice)].Flag = value; } }
    }
    public class AkXboxOneGDKAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkXboxOneGDKAdvancedInitializationSettings(nint addr) : base(addr) { }
        public ushort MaximumNumberOfXMAVoices { get { return this[nameof(MaximumNumberOfXMAVoices)].GetValue<ushort>(); } set { this[nameof(MaximumNumberOfXMAVoices)].SetValue<ushort>(value); } }
        public bool UseHardwareCodecLowLatencyMode { get { return this[nameof(UseHardwareCodecLowLatencyMode)].Flag; } set { this[nameof(UseHardwareCodecLowLatencyMode)].Flag = value; } }
    }
    public class AkXboxOneGDKApuHeapInitializationSettings : Object
    {
        public AkXboxOneGDKApuHeapInitializationSettings(nint addr) : base(addr) { }
        public uint CachedSize { get { return this[nameof(CachedSize)].GetValue<uint>(); } set { this[nameof(CachedSize)].SetValue<uint>(value); } }
        public uint NonCachedSize { get { return this[nameof(NonCachedSize)].GetValue<uint>(); } set { this[nameof(NonCachedSize)].SetValue<uint>(value); } }
    }
    public class AkXboxOneAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkXboxOneAdvancedInitializationSettings(nint addr) : base(addr) { }
        public ushort MaximumNumberOfXMAVoices { get { return this[nameof(MaximumNumberOfXMAVoices)].GetValue<ushort>(); } set { this[nameof(MaximumNumberOfXMAVoices)].SetValue<ushort>(value); } }
        public bool UseHardwareCodecLowLatencyMode { get { return this[nameof(UseHardwareCodecLowLatencyMode)].Flag; } set { this[nameof(UseHardwareCodecLowLatencyMode)].Flag = value; } }
    }
    public class AkXboxOneApuHeapInitializationSettings : Object
    {
        public AkXboxOneApuHeapInitializationSettings(nint addr) : base(addr) { }
        public uint CachedSize { get { return this[nameof(CachedSize)].GetValue<uint>(); } set { this[nameof(CachedSize)].SetValue<uint>(value); } }
        public uint NonCachedSize { get { return this[nameof(NonCachedSize)].GetValue<uint>(); } set { this[nameof(NonCachedSize)].SetValue<uint>(value); } }
    }
    public class AkXSXAdvancedInitializationSettings : AkAdvancedInitializationSettingsWithMultiCoreRendering
    {
        public AkXSXAdvancedInitializationSettings(nint addr) : base(addr) { }
        public ushort MaximumNumberOfXMAVoices { get { return this[nameof(MaximumNumberOfXMAVoices)].GetValue<ushort>(); } set { this[nameof(MaximumNumberOfXMAVoices)].SetValue<ushort>(value); } }
        public bool UseHardwareCodecLowLatencyMode { get { return this[nameof(UseHardwareCodecLowLatencyMode)].Flag; } set { this[nameof(UseHardwareCodecLowLatencyMode)].Flag = value; } }
        public ushort MaximumNumberOfOpusVoices { get { return this[nameof(MaximumNumberOfOpusVoices)].GetValue<ushort>(); } set { this[nameof(MaximumNumberOfOpusVoices)].SetValue<ushort>(value); } }
    }
    public class AkXSXApuHeapInitializationSettings : Object
    {
        public AkXSXApuHeapInitializationSettings(nint addr) : base(addr) { }
        public uint CachedSize { get { return this[nameof(CachedSize)].GetValue<uint>(); } set { this[nameof(CachedSize)].SetValue<uint>(value); } }
        public uint NonCachedSize { get { return this[nameof(NonCachedSize)].GetValue<uint>(); } set { this[nameof(NonCachedSize)].SetValue<uint>(value); } }
    }
    public class MovieSceneAkAudioEventTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneAkAudioEventTemplate(nint addr) : base(addr) { }
        public MovieSceneAkAudioEventSection Section { get { return this[nameof(Section)].As<MovieSceneAkAudioEventSection>(); } set { this["Section"] = value; } }
    }
    public class MovieSceneAkAudioRTPCTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneAkAudioRTPCTemplate(nint addr) : base(addr) { }
        public MovieSceneAkAudioRTPCSection Section { get { return this[nameof(Section)].As<MovieSceneAkAudioRTPCSection>(); } set { this["Section"] = value; } }
    }
    public class MovieSceneTangentDataSerializationHelper : Object
    {
        public MovieSceneTangentDataSerializationHelper(nint addr) : base(addr) { }
        public float ArriveTangent { get { return this[nameof(ArriveTangent)].GetValue<float>(); } set { this[nameof(ArriveTangent)].SetValue<float>(value); } }
        public float LeaveTangent { get { return this[nameof(LeaveTangent)].GetValue<float>(); } set { this[nameof(LeaveTangent)].SetValue<float>(value); } }
        public byte TangentWeightMode { get { return this[nameof(TangentWeightMode)].GetValue<byte>(); } set { this[nameof(TangentWeightMode)].SetValue<byte>(value); } }
        public float ArriveTangentWeight { get { return this[nameof(ArriveTangentWeight)].GetValue<float>(); } set { this[nameof(ArriveTangentWeight)].SetValue<float>(value); } }
        public float LeaveTangentWeight { get { return this[nameof(LeaveTangentWeight)].GetValue<float>(); } set { this[nameof(LeaveTangentWeight)].SetValue<float>(value); } }
    }
    public class MovieSceneFloatValueSerializationHelper : Object
    {
        public MovieSceneFloatValueSerializationHelper(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
        public byte TangentMode { get { return this[nameof(TangentMode)].GetValue<byte>(); } set { this[nameof(TangentMode)].SetValue<byte>(value); } }
        public MovieSceneTangentDataSerializationHelper Tangent { get { return this[nameof(Tangent)].As<MovieSceneTangentDataSerializationHelper>(); } set { this["Tangent"] = value; } }
    }
    public class MovieSceneFloatChannelSerializationHelper : Object
    {
        public MovieSceneFloatChannelSerializationHelper(nint addr) : base(addr) { }
        public byte PreInfinityExtrap { get { return this[nameof(PreInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PreInfinityExtrap)].SetValue<byte>(value); } }
        public byte PostInfinityExtrap { get { return this[nameof(PostInfinityExtrap)].GetValue<byte>(); } set { this[nameof(PostInfinityExtrap)].SetValue<byte>(value); } }
        public Array<int> Times { get { return new Array<int>(this[nameof(Times)].Address); } }
        public Array<MovieSceneFloatValueSerializationHelper> Values { get { return new Array<MovieSceneFloatValueSerializationHelper>(this[nameof(Values)].Address); } }
        public float DefaultValue { get { return this[nameof(DefaultValue)].GetValue<float>(); } set { this[nameof(DefaultValue)].SetValue<float>(value); } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
    }
}
