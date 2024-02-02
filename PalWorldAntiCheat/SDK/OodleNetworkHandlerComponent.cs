using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.OodleNetworkHandlerComponentSDK
{
    public class OodleNetworkTrainerCommandlet : Commandlet
    {
        public OodleNetworkTrainerCommandlet(nint addr) : base(addr) { }
        public bool bCompressionTest { get { return this[nameof(bCompressionTest)].Flag; } set { this[nameof(bCompressionTest)].Flag = value; } }
        public bool bWriteV5Dictionaries { get { return this[nameof(bWriteV5Dictionaries)].Flag; } set { this[nameof(bWriteV5Dictionaries)].Flag = value; } }
        public int HashTableSize { get { return this[nameof(HashTableSize)].GetValue<int>(); } set { this[nameof(HashTableSize)].SetValue<int>(value); } }
        public int DictionarySize { get { return this[nameof(DictionarySize)].GetValue<int>(); } set { this[nameof(DictionarySize)].SetValue<int>(value); } }
        public int DictionaryTrials { get { return this[nameof(DictionaryTrials)].GetValue<int>(); } set { this[nameof(DictionaryTrials)].SetValue<int>(value); } }
        public int TrialRandomness { get { return this[nameof(TrialRandomness)].GetValue<int>(); } set { this[nameof(TrialRandomness)].SetValue<int>(value); } }
        public int TrialGenerations { get { return this[nameof(TrialGenerations)].GetValue<int>(); } set { this[nameof(TrialGenerations)].SetValue<int>(value); } }
        public bool bNoTrials { get { return this[nameof(bNoTrials)].Flag; } set { this[nameof(bNoTrials)].Flag = value; } }
    }
    public enum EOodleNetworkEnableMode : int
    {
        AlwaysEnabled = 0,
        WhenCompressedPacketReceived = 1,
        EOodleNetworkEnableMode_MAX = 2,
    }
    public enum EOodleNetResult : int
    {
        Unknown = 0,
        Success = 1,
        OodleDecodeFailed = 2,
        OodleSerializePayloadFail = 3,
        OodleBadDecompressedLength = 4,
        OodleNoDictionary = 5,
        EOodleNetResult_MAX = 6,
    }
}
