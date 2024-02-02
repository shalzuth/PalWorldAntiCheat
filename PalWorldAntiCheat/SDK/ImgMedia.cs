using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImgMediaSDK
{
    public class ImgMediaSource : BaseMediaSource
    {
        public ImgMediaSource(nint addr) : base(addr) { }
        public bool IsPathRelativeToProjectRoot { get { return this[nameof(IsPathRelativeToProjectRoot)].Flag; } set { this[nameof(IsPathRelativeToProjectRoot)].Flag = value; } }
        public FrameRate FrameRateOverride { get { return this[nameof(FrameRateOverride)].As<FrameRate>(); } set { this["FrameRateOverride"] = value; } }
        public Object ProxyOverride { get { return this[nameof(ProxyOverride)]; } set { this[nameof(ProxyOverride)] = value; } }
        public bool bFillGapsInSequence { get { return this[nameof(bFillGapsInSequence)].Flag; } set { this[nameof(bFillGapsInSequence)].Flag = value; } }
        public DirectoryPath SequencePath { get { return this[nameof(SequencePath)].As<DirectoryPath>(); } set { this["SequencePath"] = value; } }
        public void SetTokenizedSequencePath(Object Path) { Invoke(nameof(SetTokenizedSequencePath), Path); }
        public void SetSequencePath(Object Path) { Invoke(nameof(SetSequencePath), Path); }
        public void SetMipLevelDistance(float Distance) { Invoke(nameof(SetMipLevelDistance), Distance); }
        public void RemoveTargetObject(Actor InActor) { Invoke(nameof(RemoveTargetObject), InActor); }
        public void RemoveGlobalCamera(Actor InActor) { Invoke(nameof(RemoveGlobalCamera), InActor); }
        public Object GetSequencePath() { return Invoke<Object>(nameof(GetSequencePath)); }
        public void GetProxies(Array<Object> OutProxies) { Invoke(nameof(GetProxies), OutProxies); }
        public void AddTargetObject(Actor InActor) { Invoke(nameof(AddTargetObject), InActor); }
        public void AddGlobalCamera(Actor InActor) { Invoke(nameof(AddGlobalCamera), InActor); }
    }
    public class ImgMediaSourceCustomizationSequenceProxy : Object
    {
        public ImgMediaSourceCustomizationSequenceProxy(nint addr) : base(addr) { }
    }
}
