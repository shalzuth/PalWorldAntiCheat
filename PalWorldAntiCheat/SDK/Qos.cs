using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.QosSDK
{
    public class QosBeaconClient : OnlineBeaconClient
    {
        public QosBeaconClient(nint addr) : base(addr) { }
        public void ServerQosRequest(Object InSessionId) { Invoke(nameof(ServerQosRequest), InSessionId); }
        public void ClientQosResponse(EQosResponseType Response) { Invoke(nameof(ClientQosResponse), Response); }
    }
    public class QosBeaconHost : OnlineBeaconHostObject
    {
        public QosBeaconHost(nint addr) : base(addr) { }
    }
    public class QosEvaluator : Object
    {
        public QosEvaluator(nint addr) : base(addr) { }
        public bool bInProgress { get { return this[nameof(bInProgress)].Flag; } set { this[nameof(bInProgress)].Flag = value; } }
        public bool bCancelOperation { get { return this[nameof(bCancelOperation)].Flag; } set { this[nameof(bCancelOperation)].Flag = value; } }
        public Array<DatacenterQosInstance> Datacenters { get { return new Array<DatacenterQosInstance>(this[nameof(Datacenters)].Address); } }
    }
    public class QosRegionManager : Object
    {
        public QosRegionManager(nint addr) : base(addr) { }
        public int NumTestsPerRegion { get { return this[nameof(NumTestsPerRegion)].GetValue<int>(); } set { this[nameof(NumTestsPerRegion)].SetValue<int>(value); } }
        public float PingTimeout { get { return this[nameof(PingTimeout)].GetValue<float>(); } set { this[nameof(PingTimeout)].SetValue<float>(value); } }
        public bool bEnableSubspaceBiasOrder { get { return this[nameof(bEnableSubspaceBiasOrder)].Flag; } set { this[nameof(bEnableSubspaceBiasOrder)].Flag = value; } }
        public Object SubspaceDelimiter { get { return this[nameof(SubspaceDelimiter)]; } set { this[nameof(SubspaceDelimiter)] = value; } }
        public Array<QosRegionInfo> RegionDefinitions { get { return new Array<QosRegionInfo>(this[nameof(RegionDefinitions)].Address); } }
        public Array<QosDatacenterInfo> DatacenterDefinitions { get { return new Array<QosDatacenterInfo>(this[nameof(DatacenterDefinitions)].Address); } }
        public DateTime LastCheckTimestamp { get { return this[nameof(LastCheckTimestamp)].As<DateTime>(); } set { this["LastCheckTimestamp"] = value; } }
        public QosEvaluator Evaluator { get { return this[nameof(Evaluator)].As<QosEvaluator>(); } set { this["Evaluator"] = value; } }
        public EQosCompletionResult QosEvalResult { get { return (EQosCompletionResult)this[nameof(QosEvalResult)].GetValue<int>(); } set { this[nameof(QosEvalResult)].SetValue<int>((int)value); } }
        public Array<RegionQosInstance> RegionOptions { get { return new Array<RegionQosInstance>(this[nameof(RegionOptions)].Address); } }
        public Object ForceRegionId { get { return this[nameof(ForceRegionId)]; } set { this[nameof(ForceRegionId)] = value; } }
        public bool bRegionForcedViaCommandline { get { return this[nameof(bRegionForcedViaCommandline)].Flag; } set { this[nameof(bRegionForcedViaCommandline)].Flag = value; } }
        public Object SelectedRegionId { get { return this[nameof(SelectedRegionId)]; } set { this[nameof(SelectedRegionId)] = value; } }
    }
    public enum EQosResponseType : int
    {
        NoResponse = 0,
        Success = 1,
        Failure = 2,
        EQosResponseType_MAX = 3,
    }
    public enum EQosDatacenterResult : int
    {
        Invalid = 0,
        Success = 1,
        Incomplete = 2,
        EQosDatacenterResult_MAX = 3,
    }
    public enum EQosCompletionResult : int
    {
        Invalid = 0,
        Success = 1,
        Failure = 2,
        Canceled = 3,
        EQosCompletionResult_MAX = 4,
    }
    public class QosSubspaceComparisonParams : Object
    {
        public QosSubspaceComparisonParams(nint addr) : base(addr) { }
        public int MaxNonSubspacePingMs { get { return this[nameof(MaxNonSubspacePingMs)].GetValue<int>(); } set { this[nameof(MaxNonSubspacePingMs)].SetValue<int>(value); } }
        public int MinSubspacePingMs { get { return this[nameof(MinSubspacePingMs)].GetValue<int>(); } set { this[nameof(MinSubspacePingMs)].SetValue<int>(value); } }
        public int ConstantMaxToleranceMs { get { return this[nameof(ConstantMaxToleranceMs)].GetValue<int>(); } set { this[nameof(ConstantMaxToleranceMs)].SetValue<int>(value); } }
        public float ScaledMaxTolerancePct { get { return this[nameof(ScaledMaxTolerancePct)].GetValue<float>(); } set { this[nameof(ScaledMaxTolerancePct)].SetValue<float>(value); } }
    }
    public class QosPingServerInfo : Object
    {
        public QosPingServerInfo(nint addr) : base(addr) { }
        public Object Address { get { return this[nameof(Address)]; } set { this[nameof(Address)] = value; } }
        public int Port { get { return this[nameof(Port)].GetValue<int>(); } set { this[nameof(Port)].SetValue<int>(value); } }
    }
    public class QosDatacenterInfo : Object
    {
        public QosDatacenterInfo(nint addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object regionId { get { return this[nameof(regionId)]; } set { this[nameof(regionId)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Array<QosPingServerInfo> Servers { get { return new Array<QosPingServerInfo>(this[nameof(Servers)].Address); } }
    }
    public class QosRegionInfo : Object
    {
        public QosRegionInfo(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object regionId { get { return this[nameof(regionId)]; } set { this[nameof(regionId)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool bAutoAssignable { get { return this[nameof(bAutoAssignable)].Flag; } set { this[nameof(bAutoAssignable)].Flag = value; } }
        public bool bAllowSubspaceBias { get { return this[nameof(bAllowSubspaceBias)].Flag; } set { this[nameof(bAllowSubspaceBias)].Flag = value; } }
        public QosSubspaceComparisonParams SubspaceBiasParams { get { return this[nameof(SubspaceBiasParams)].As<QosSubspaceComparisonParams>(); } set { this["SubspaceBiasParams"] = value; } }
    }
    public class DatacenterQosInstance : Object
    {
        public DatacenterQosInstance(nint addr) : base(addr) { }
        public QosDatacenterInfo Definition { get { return this[nameof(Definition)].As<QosDatacenterInfo>(); } set { this["Definition"] = value; } }
        public EQosDatacenterResult Result { get { return (EQosDatacenterResult)this[nameof(Result)].GetValue<int>(); } set { this[nameof(Result)].SetValue<int>((int)value); } }
        public int AvgPingMs { get { return this[nameof(AvgPingMs)].GetValue<int>(); } set { this[nameof(AvgPingMs)].SetValue<int>(value); } }
        public Array<int> PingResults { get { return new Array<int>(this[nameof(PingResults)].Address); } }
        public DateTime LastCheckTimestamp { get { return this[nameof(LastCheckTimestamp)].As<DateTime>(); } set { this["LastCheckTimestamp"] = value; } }
        public bool bUsable { get { return this[nameof(bUsable)].Flag; } set { this[nameof(bUsable)].Flag = value; } }
    }
    public class RegionQosInstance : Object
    {
        public RegionQosInstance(nint addr) : base(addr) { }
        public QosRegionInfo Definition { get { return this[nameof(Definition)].As<QosRegionInfo>(); } set { this["Definition"] = value; } }
        public Array<DatacenterQosInstance> DatacenterOptions { get { return new Array<DatacenterQosInstance>(this[nameof(DatacenterOptions)].Address); } }
    }
}
