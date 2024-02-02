using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.UObjectPluginSDK
{
    public class MyPluginObject : Object
    {
        public MyPluginObject(nint addr) : base(addr) { }
        public MyPluginStruct MyStruct { get { return this[nameof(MyStruct)].As<MyPluginStruct>(); } set { this["MyStruct"] = value; } }
    }
    public class MyPluginStruct : Object
    {
        public MyPluginStruct(nint addr) : base(addr) { }
        public Object TestString { get { return this[nameof(TestString)]; } set { this[nameof(TestString)] = value; } }
    }
}
