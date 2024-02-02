using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImageWriteQueueSDK
{
    public class ImageWriteBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ImageWriteBlueprintLibrary(nint addr) : base(addr) { }
        public void ExportToDisk(Texture Texture, Object Filename, ImageWriteOptions Options) { Invoke(nameof(ExportToDisk), Texture, Filename, Options); }
    }
    public enum EDesiredImageFormat : int
    {
        PNG = 0,
        JPG = 1,
        BMP = 2,
        EXR = 3,
        EDesiredImageFormat_MAX = 4,
    }
    public class ImageWriteOptions : Object
    {
        public ImageWriteOptions(nint addr) : base(addr) { }
        public EDesiredImageFormat Format { get { return (EDesiredImageFormat)this[nameof(Format)].GetValue<int>(); } set { this[nameof(Format)].SetValue<int>((int)value); } }
        public Object OnComplete { get { return this[nameof(OnComplete)]; } set { this[nameof(OnComplete)] = value; } }
        public int CompressionQuality { get { return this[nameof(CompressionQuality)].GetValue<int>(); } set { this[nameof(CompressionQuality)].SetValue<int>(value); } }
        public bool bOverwriteFile { get { return this[nameof(bOverwriteFile)].Flag; } set { this[nameof(bOverwriteFile)].Flag = value; } }
        public bool bAsync { get { return this[nameof(bAsync)].Flag; } set { this[nameof(bAsync)].Flag = value; } }
    }
}
