using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.WaveTableSDK
{
    public class WaveTableBank : Object
    {
        public WaveTableBank(nint addr) : base(addr) { }
        public EWaveTableResolution Resolution { get { return (EWaveTableResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public bool bBipolar { get { return this[nameof(bBipolar)].Flag; } set { this[nameof(bBipolar)].Flag = value; } }
        public Array<WaveTableBankEntry> Entries { get { return new Array<WaveTableBankEntry>(this[nameof(Entries)].Address); } }
    }
    public enum EWaveTableResolution : int
    {
        None = 0,
        Res_9 = 3,
        Res_17 = 4,
        Res_33 = 5,
        Res_65 = 6,
        Res_129 = 7,
        Res_257 = 8,
        Res_513 = 9,
        Res_1025 = 10,
        Res_2049 = 11,
        Res_4097 = 12,
        Res_Max = 12,
        Maximum = 13,
        EWaveTableResolution_MAX = 14,
    }
    public enum EWaveTableCurve : int
    {
        Linear = 0,
        Linear_Inv = 1,
        Exp = 2,
        Exp_Inverse = 3,
        Log = 4,
        Sin = 5,
        Sin_Full = 6,
        SCurve = 7,
        Shared = 8,
        Custom = 9,
        File = 10,
        Count = 11,
        EWaveTableCurve_MAX = 12,
    }
    public class WaveTableBankEntry : Object
    {
        public WaveTableBankEntry(nint addr) : base(addr) { }
        public WaveTableTransform Transform { get { return this[nameof(Transform)].As<WaveTableTransform>(); } set { this["Transform"] = value; } }
    }
    public class WaveTableTransform : Object
    {
        public WaveTableTransform(nint addr) : base(addr) { }
        public EWaveTableCurve Curve { get { return (EWaveTableCurve)this[nameof(Curve)].GetValue<int>(); } set { this[nameof(Curve)].SetValue<int>((int)value); } }
        public float Scalar { get { return this[nameof(Scalar)].GetValue<float>(); } set { this[nameof(Scalar)].SetValue<float>(value); } }
        public RichCurve CurveCustom { get { return this[nameof(CurveCustom)].As<RichCurve>(); } set { this["CurveCustom"] = value; } }
        public CurveFloat CurveShared { get { return this[nameof(CurveShared)].As<CurveFloat>(); } set { this["CurveShared"] = value; } }
        public Array<float> WaveTable { get { return new Array<float>(this[nameof(WaveTable)].Address); } }
    }
    public class WaveTableSettings : Object
    {
        public WaveTableSettings(nint addr) : base(addr) { }
        public FilePath FilePath { get { return this[nameof(FilePath)].As<FilePath>(); } set { this["FilePath"] = value; } }
        public int ChannelIndex { get { return this[nameof(ChannelIndex)].GetValue<int>(); } set { this[nameof(ChannelIndex)].SetValue<int>(value); } }
        public float Phase { get { return this[nameof(Phase)].GetValue<float>(); } set { this[nameof(Phase)].SetValue<float>(value); } }
        public float Top { get { return this[nameof(Top)].GetValue<float>(); } set { this[nameof(Top)].SetValue<float>(value); } }
        public float Tail { get { return this[nameof(Tail)].GetValue<float>(); } set { this[nameof(Tail)].SetValue<float>(value); } }
        public float FadeIn { get { return this[nameof(FadeIn)].GetValue<float>(); } set { this[nameof(FadeIn)].SetValue<float>(value); } }
        public float FadeOut { get { return this[nameof(FadeOut)].GetValue<float>(); } set { this[nameof(FadeOut)].SetValue<float>(value); } }
        public bool bNormalize { get { return this[nameof(bNormalize)].Flag; } set { this[nameof(bNormalize)].Flag = value; } }
        public bool bRemoveOffset { get { return this[nameof(bRemoveOffset)].Flag; } set { this[nameof(bRemoveOffset)].Flag = value; } }
        public Array<float> SourcePCMData { get { return new Array<float>(this[nameof(SourcePCMData)].Address); } }
    }
}
