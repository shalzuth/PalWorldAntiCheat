using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieRenderPipelineCoreSDK;
namespace SDK.Script.FSR2MovieRenderPipelineSDK
{
    public class FSR2MoviePipelineSettings : MoviePipelineViewFamilySetting
    {
        public FSR2MoviePipelineSettings(nint addr) : base(addr) { }
        public EFSR2MoviePipelineQuality FSR2Quality { get { return (EFSR2MoviePipelineQuality)this[nameof(FSR2Quality)].GetValue<int>(); } set { this[nameof(FSR2Quality)].SetValue<int>((int)value); } }
    }
    public enum EFSR2MoviePipelineQuality : int
    {
        Unused = 0,
        Quality = 1,
        Balanced = 2,
        Performance = 3,
        UltraPerformance = 4,
        EFSR2MoviePipelineQuality_MAX = 5,
    }
}
