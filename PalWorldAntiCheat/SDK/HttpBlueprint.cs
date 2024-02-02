using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.HttpBlueprintSDK
{
    public class HttpBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public HttpBlueprintFunctionLibrary(nint addr) : base(addr) { }
        public bool RemoveHeader(HttpHeader HeaderObject, Object HeaderToRemove) { return Invoke<bool>(nameof(RemoveHeader), HeaderObject, HeaderToRemove); }
        public void MakeRequestHeader(Object Headers, HttpHeader OutHeader) { Invoke(nameof(MakeRequestHeader), Headers, OutHeader); }
        public bool GetHeaderValue(HttpHeader HeaderObject, Object HeaderName, Object OutHeaderValue) { return Invoke<bool>(nameof(GetHeaderValue), HeaderObject, HeaderName, OutHeaderValue); }
        public Object GetAllHeaders_Map(HttpHeader HeaderObject) { return Invoke<Object>(nameof(GetAllHeaders_Map), HeaderObject); }
        public Array<Object> GetAllHeaders(HttpHeader HeaderObject) { return Invoke<Array<Object>>(nameof(GetAllHeaders), HeaderObject); }
        public void AddHeader(HttpHeader HeaderObject, Object NewHeader, Object NewHeaderValue) { Invoke(nameof(AddHeader), HeaderObject, NewHeader, NewHeaderValue); }
    }
    public enum EHttpVerbs : int
    {
        Post = 0,
        Put = 1,
        Delete = 2,
        Patch = 3,
        Get = 4,
        MAX = 255,
    }
    public enum ERequestPresets : int
    {
        Json = 0,
        Http = 1,
        Url = 2,
        Custom = 3,
        ERequestPresets_MAX = 4,
    }
    public class HttpHeader : Object
    {
        public HttpHeader(nint addr) : base(addr) { }
        public Object Headers { get { return this[nameof(Headers)]; } set { this[nameof(Headers)] = value; } }
    }
}
