using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.JsonUtilitiesSDK
{
    public class JsonUtilitiesDummyObject : Object
    {
        public JsonUtilitiesDummyObject(nint addr) : base(addr) { }
    }
    public class JsonObjectWrapper : Object
    {
        public JsonObjectWrapper(nint addr) : base(addr) { }
        public Object JsonString { get { return this[nameof(JsonString)]; } set { this[nameof(JsonString)] = value; } }
    }
}
