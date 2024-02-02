using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.NetCoreSDK
{
    public class NetAnalyticsAggregatorConfig : Object
    {
        public NetAnalyticsAggregatorConfig(nint addr) : base(addr) { }
        public Array<NetAnalyticsDataConfig> NetAnalyticsData { get { return new Array<NetAnalyticsDataConfig>(this[nameof(NetAnalyticsData)].Address); } }
    }
    public class StatePerObjectConfig : Object
    {
        public StatePerObjectConfig(nint addr) : base(addr) { }
        public Object PerObjectConfigSection { get { return this[nameof(PerObjectConfigSection)]; } set { this[nameof(PerObjectConfigSection)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class EscalationManagerConfig : StatePerObjectConfig
    {
        public EscalationManagerConfig(nint addr) : base(addr) { }
        public Array<Object> EscalationSeverity { get { return new Array<Object>(this[nameof(EscalationSeverity)].Address); } }
    }
    public enum ENetworkFailure : int
    {
        NetDriverAlreadyExists = 0,
        NetDriverCreateFailure = 1,
        NetDriverListenFailure = 2,
        ConnectionLost = 3,
        ConnectionTimeout = 4,
        FailureReceived = 5,
        OutdatedClient = 6,
        OutdatedServer = 7,
        PendingConnectionFailure = 8,
        NetGuidMismatch = 9,
        NetChecksumMismatch = 10,
        ENetworkFailure_MAX = 11,
    }
    public class FastArraySerializer : Object
    {
        public FastArraySerializer(nint addr) : base(addr) { }
        public int ArrayReplicationKey { get { return this[nameof(ArrayReplicationKey)].GetValue<int>(); } set { this[nameof(ArrayReplicationKey)].SetValue<int>(value); } }
        public EFastArraySerializerDeltaFlags DeltaFlags { get { return (EFastArraySerializerDeltaFlags)this[nameof(DeltaFlags)].GetValue<int>(); } set { this[nameof(DeltaFlags)].SetValue<int>((int)value); } }
    }
    public enum EFastArraySerializerDeltaFlags : int
    {
        None = 0,
        HasBeenSerialized = 1,
        HasDeltaBeenRequested = 2,
        IsUsingDeltaSerialization = 4,
        EFastArraySerializerDeltaFlags_MAX = 5,
    }
    public class FastArraySerializerItem : Object
    {
        public FastArraySerializerItem(nint addr) : base(addr) { }
        public int ReplicationID { get { return this[nameof(ReplicationID)].GetValue<int>(); } set { this[nameof(ReplicationID)].SetValue<int>(value); } }
        public int ReplicationKey { get { return this[nameof(ReplicationKey)].GetValue<int>(); } set { this[nameof(ReplicationKey)].SetValue<int>(value); } }
        public int MostRecentArrayReplicationKey { get { return this[nameof(MostRecentArrayReplicationKey)].GetValue<int>(); } set { this[nameof(MostRecentArrayReplicationKey)].SetValue<int>(value); } }
    }
    public enum ENetCloseResult : int
    {
        NetDriverAlreadyExists = 0,
        NetDriverCreateFailure = 1,
        NetDriverListenFailure = 2,
        ConnectionLost = 3,
        ConnectionTimeout = 4,
        FailureReceived = 5,
        OutdatedClient = 6,
        OutdatedServer = 7,
        PendingConnectionFailure = 8,
        NetGuidMismatch = 9,
        NetChecksumMismatch = 10,
        SecurityMalformedPacket = 11,
        SecurityInvalidData = 12,
        SecurityClosed = 13,
        Unknown = 14,
        Success = 15,
        Extended = 16,
        HostClosedConnection = 17,
        Disconnect = 18,
        Upgrade = 19,
        PreLoginFailure = 20,
        JoinFailure = 21,
        JoinSplitFailure = 22,
        AddressResolutionFailed = 23,
        RPCDoS = 24,
        Cleanup = 25,
        MissingLevelPackage = 26,
        PacketHandlerIncomingError = 27,
        ZeroLastByte = 28,
        ZeroSize = 29,
        ReadHeaderFail = 30,
        ReadHeaderExtraFail = 31,
        AckSequenceMismatch = 32,
        BunchBadChannelIndex = 33,
        BunchChannelNameFail = 34,
        BunchWrongChannelType = 35,
        BunchHeaderOverflow = 36,
        BunchDataOverflow = 37,
        BunchServerPackageMapExports = 38,
        BunchPrematureControlChannel = 39,
        BunchPrematureChannel = 40,
        BunchPrematureControlClose = 41,
        UnknownChannelType = 42,
        PrematureSend = 43,
        CorruptData = 44,
        SocketSendFailure = 45,
        BadChildConnectionIndex = 46,
        LogLimitInstant = 47,
        LogLimitSustained = 48,
        EncryptionFailure = 49,
        EncryptionTokenMissing = 50,
        ReceivedNetGUIDBunchFail = 51,
        MaxReliableExceeded = 52,
        ReceivedNextBunchFail = 53,
        ReceivedNextBunchQueueFail = 54,
        PartialInitialReliableDestroy = 55,
        PartialMergeReliableDestroy = 56,
        PartialInitialNonByteAligned = 57,
        PartialNonByteAligned = 58,
        PartialFinalPackageMapExports = 59,
        PartialTooLarge = 60,
        AlreadyOpen = 61,
        ReliableBeforeOpen = 62,
        ReliableBufferOverflow = 63,
        RPCReliableBufferOverflow = 64,
        ControlChannelClose = 65,
        ControlChannelEndianCheck = 66,
        ControlChannelPlayerChannelFail = 67,
        ControlChannelMessageUnknown = 68,
        ControlChannelMessageFail = 69,
        ControlChannelMessagePayloadFail = 70,
        ControlChannelBunchOverflowed = 71,
        ControlChannelQueueBunchOverflowed = 72,
        ClientHasMustBeMappedGUIDs = 73,
        ClientSentDestructionInfo = 74,
        UnregisteredMustBeMappedGUID = 75,
        ObjectReplicatorReceivedBunchFail = 76,
        ContentBlockFail = 77,
        ContentBlockHeaderRepLayoutFail = 78,
        ContentBlockHeaderIsActorFail = 79,
        ContentBlockHeaderObjFail = 80,
        ContentBlockHeaderPrematureEnd = 81,
        ContentBlockHeaderSubObjectActor = 82,
        ContentBlockHeaderBadParent = 83,
        ContentBlockHeaderInvalidCreate = 84,
        ContentBlockHeaderStablyNamedFail = 85,
        ContentBlockHeaderNoSubObjectClass = 86,
        ContentBlockHeaderUObjectSubObject = 87,
        ContentBlockHeaderAActorSubObject = 88,
        ContentBlockHeaderFail = 89,
        ContentBlockPayloadBitsFail = 90,
        FieldHeaderRepIndex = 91,
        FieldHeaderBadRepIndex = 92,
        FieldHeaderPayloadBitsFail = 93,
        FieldPayloadFail = 94,
        BeaconControlFlowError = 95,
        BeaconUnableToParsePacket = 96,
        BeaconAuthenticationFailure = 97,
        BeaconLoginInvalidIdError = 98,
        BeaconLoginInvalidAuthHandlerError = 99,
        BeaconAuthError = 100,
        BeaconSpawnClientWorldPackageNameError = 101,
        BeaconSpawnExistingActorError = 102,
        BeaconSpawnFailureError = 103,
        BeaconSpawnNetGUIDAckNoActor = 104,
        BeaconSpawnNetGUIDAckNoHost = 105,
        BeaconSpawnUnexpectedError = 106,
        FaultDisconnect = 107,
        NotRecoverable = 108,
        ENetCloseResult_MAX = 109,
    }
    public class NetAnalyticsDataConfig : Object
    {
        public NetAnalyticsDataConfig(nint addr) : base(addr) { }
        public Object DataName { get { return this[nameof(DataName)]; } set { this[nameof(DataName)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class StateStruct : Object
    {
        public StateStruct(nint addr) : base(addr) { }
        public Object StateName { get { return this[nameof(StateName)]; } set { this[nameof(StateName)] = value; } }
    }
    public class EscalationState : StateStruct
    {
        public EscalationState(nint addr) : base(addr) { }
        public bool bLogEscalate { get { return this[nameof(bLogEscalate)].Flag; } set { this[nameof(bLogEscalate)].Flag = value; } }
        public bool bDormant { get { return this[nameof(bDormant)].Flag; } set { this[nameof(bDormant)].Flag = value; } }
        public short CooloffTime { get { return this[nameof(CooloffTime)].GetValue<short>(); } set { this[nameof(CooloffTime)].SetValue<short>(value); } }
        public short AutoEscalateTime { get { return this[nameof(AutoEscalateTime)].GetValue<short>(); } set { this[nameof(AutoEscalateTime)].SetValue<short>(value); } }
        public byte HighestTimePeriod { get { return this[nameof(HighestTimePeriod)].GetValue<byte>(); } set { this[nameof(HighestTimePeriod)].SetValue<byte>(value); } }
        public Array<byte> AllTimePeriods { get { return new Array<byte>(this[nameof(AllTimePeriods)].Address); } }
    }
    public class NetFaultState : EscalationState
    {
        public NetFaultState(nint addr) : base(addr) { }
        public bool bCloseConnection { get { return this[nameof(bCloseConnection)].Flag; } set { this[nameof(bCloseConnection)].Flag = value; } }
        public short EscalateQuotaFaultsPerPeriod { get { return this[nameof(EscalateQuotaFaultsPerPeriod)].GetValue<short>(); } set { this[nameof(EscalateQuotaFaultsPerPeriod)].SetValue<short>(value); } }
        public byte EscalateQuotaFaultPercentPerPeriod { get { return this[nameof(EscalateQuotaFaultPercentPerPeriod)].GetValue<byte>(); } set { this[nameof(EscalateQuotaFaultPercentPerPeriod)].SetValue<byte>(value); } }
        public short DescalateQuotaFaultsPerPeriod { get { return this[nameof(DescalateQuotaFaultsPerPeriod)].GetValue<short>(); } set { this[nameof(DescalateQuotaFaultsPerPeriod)].SetValue<short>(value); } }
        public byte DescalateQuotaFaultPercentPerPeriod { get { return this[nameof(DescalateQuotaFaultPercentPerPeriod)].GetValue<byte>(); } set { this[nameof(DescalateQuotaFaultPercentPerPeriod)].SetValue<byte>(value); } }
        public byte EscalateQuotaTimePeriod { get { return this[nameof(EscalateQuotaTimePeriod)].GetValue<byte>(); } set { this[nameof(EscalateQuotaTimePeriod)].SetValue<byte>(value); } }
    }
}
