using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.SocketSubsystemEOSSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.OnlineSubsystemEOSSDK
{
    public class NetDriverEOS : NetDriverEOSBase
    {
        public NetDriverEOS(nint addr) : base(addr) { }
    }
    public class EOSArtifactSettings : DataAsset
    {
        public EOSArtifactSettings(nint addr) : base(addr) { }
    }
    public class EOSSettings : RuntimeOptionsBase
    {
        public EOSSettings(nint addr) : base(addr) { }
        public Object CacheDir { get { return this[nameof(CacheDir)]; } set { this[nameof(CacheDir)] = value; } }
        public Object DefaultArtifactName { get { return this[nameof(DefaultArtifactName)]; } set { this[nameof(DefaultArtifactName)] = value; } }
        public int TickBudgetInMilliseconds { get { return this[nameof(TickBudgetInMilliseconds)].GetValue<int>(); } set { this[nameof(TickBudgetInMilliseconds)].SetValue<int>(value); } }
        public bool bEnableOverlay { get { return this[nameof(bEnableOverlay)].Flag; } set { this[nameof(bEnableOverlay)].Flag = value; } }
        public bool bEnableSocialOverlay { get { return this[nameof(bEnableSocialOverlay)].Flag; } set { this[nameof(bEnableSocialOverlay)].Flag = value; } }
        public bool bEnableEditorOverlay { get { return this[nameof(bEnableEditorOverlay)].Flag; } set { this[nameof(bEnableEditorOverlay)].Flag = value; } }
        public bool bShouldEnforceBeingLaunchedByEGS { get { return this[nameof(bShouldEnforceBeingLaunchedByEGS)].Flag; } set { this[nameof(bShouldEnforceBeingLaunchedByEGS)].Flag = value; } }
        public Array<Object> TitleStorageTags { get { return new Array<Object>(this[nameof(TitleStorageTags)].Address); } }
        public int TitleStorageReadChunkLength { get { return this[nameof(TitleStorageReadChunkLength)].GetValue<int>(); } set { this[nameof(TitleStorageReadChunkLength)].SetValue<int>(value); } }
        public Array<ArtifactSettings> Artifacts { get { return new Array<ArtifactSettings>(this[nameof(Artifacts)].Address); } }
        public bool bUseEAS { get { return this[nameof(bUseEAS)].Flag; } set { this[nameof(bUseEAS)].Flag = value; } }
        public bool bUseEOSConnect { get { return this[nameof(bUseEOSConnect)].Flag; } set { this[nameof(bUseEOSConnect)].Flag = value; } }
        public bool bMirrorStatsToEOS { get { return this[nameof(bMirrorStatsToEOS)].Flag; } set { this[nameof(bMirrorStatsToEOS)].Flag = value; } }
        public bool bMirrorAchievementsToEOS { get { return this[nameof(bMirrorAchievementsToEOS)].Flag; } set { this[nameof(bMirrorAchievementsToEOS)].Flag = value; } }
        public bool bUseEOSSessions { get { return this[nameof(bUseEOSSessions)].Flag; } set { this[nameof(bUseEOSSessions)].Flag = value; } }
        public bool bMirrorPresenceToEAS { get { return this[nameof(bMirrorPresenceToEAS)].Flag; } set { this[nameof(bMirrorPresenceToEAS)].Flag = value; } }
        public bool bUseDeviceIdLogin { get { return this[nameof(bUseDeviceIdLogin)].Flag; } set { this[nameof(bUseDeviceIdLogin)].Flag = value; } }
        public bool bOverrideDedicatedServer { get { return this[nameof(bOverrideDedicatedServer)].Flag; } set { this[nameof(bOverrideDedicatedServer)].Flag = value; } }
    }
    public class ArtifactSettings : Object
    {
        public ArtifactSettings(nint addr) : base(addr) { }
        public Object ArtifactName { get { return this[nameof(ArtifactName)]; } set { this[nameof(ArtifactName)] = value; } }
        public Object ClientId { get { return this[nameof(ClientId)]; } set { this[nameof(ClientId)] = value; } }
        public Object ClientSecret { get { return this[nameof(ClientSecret)]; } set { this[nameof(ClientSecret)] = value; } }
        public Object ProductId { get { return this[nameof(ProductId)]; } set { this[nameof(ProductId)] = value; } }
        public Object SandboxId { get { return this[nameof(SandboxId)]; } set { this[nameof(SandboxId)] = value; } }
        public Object DeploymentId { get { return this[nameof(DeploymentId)]; } set { this[nameof(DeploymentId)] = value; } }
        public Object EncryptionKey { get { return this[nameof(EncryptionKey)]; } set { this[nameof(EncryptionKey)] = value; } }
    }
}
