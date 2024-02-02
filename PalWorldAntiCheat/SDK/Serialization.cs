using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SerializationSDK
{
    public class StructSerializerNumericTestStruct : Object
    {
        public StructSerializerNumericTestStruct(nint addr) : base(addr) { }
        public byte Int8 { get { return this[nameof(Int8)].GetValue<byte>(); } set { this[nameof(Int8)].SetValue<byte>(value); } }
        public short Int16 { get { return this[nameof(Int16)].GetValue<short>(); } set { this[nameof(Int16)].SetValue<short>(value); } }
        public int int32 { get { return this[nameof(int32)].GetValue<int>(); } set { this[nameof(int32)].SetValue<int>(value); } }
        public long Int64 { get { return this[nameof(Int64)].GetValue<long>(); } set { this[nameof(Int64)].SetValue<long>(value); } }
        public byte uint8 { get { return this[nameof(uint8)].GetValue<byte>(); } set { this[nameof(uint8)].SetValue<byte>(value); } }
        public ushort uint16 { get { return this[nameof(uint16)].GetValue<ushort>(); } set { this[nameof(uint16)].SetValue<ushort>(value); } }
        public uint uint32 { get { return this[nameof(uint32)].GetValue<uint>(); } set { this[nameof(uint32)].SetValue<uint>(value); } }
        public ulong UInt64 { get { return this[nameof(UInt64)].GetValue<ulong>(); } set { this[nameof(UInt64)].SetValue<ulong>(value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
        public double Double { get { return this[nameof(Double)].GetValue<double>(); } set { this[nameof(Double)].SetValue<double>(value); } }
    }
    public class StructSerializerBooleanTestStruct : Object
    {
        public StructSerializerBooleanTestStruct(nint addr) : base(addr) { }
        public bool BoolFalse { get { return this[nameof(BoolFalse)].Flag; } set { this[nameof(BoolFalse)].Flag = value; } }
        public bool BoolTrue { get { return this[nameof(BoolTrue)].Flag; } set { this[nameof(BoolTrue)].Flag = value; } }
        public bool Bitfield0 { get { return this[nameof(Bitfield0)].Flag; } set { this[nameof(Bitfield0)].Flag = value; } }
        public bool Bitfield1 { get { return this[nameof(Bitfield1)].Flag; } set { this[nameof(Bitfield1)].Flag = value; } }
        public bool Bitfield2Set { get { return this[nameof(Bitfield2Set)].Flag; } set { this[nameof(Bitfield2Set)].Flag = value; } }
        public bool Bitfield3 { get { return this[nameof(Bitfield3)].Flag; } set { this[nameof(Bitfield3)].Flag = value; } }
        public bool Bitfield4Set { get { return this[nameof(Bitfield4Set)].Flag; } set { this[nameof(Bitfield4Set)].Flag = value; } }
        public bool Bitfield5Set { get { return this[nameof(Bitfield5Set)].Flag; } set { this[nameof(Bitfield5Set)].Flag = value; } }
        public bool Bitfield6 { get { return this[nameof(Bitfield6)].Flag; } set { this[nameof(Bitfield6)].Flag = value; } }
        public bool Bitfield7Set { get { return this[nameof(Bitfield7Set)].Flag; } set { this[nameof(Bitfield7Set)].Flag = value; } }
    }
    public class StructSerializerObjectTestStruct : Object
    {
        public StructSerializerObjectTestStruct(nint addr) : base(addr) { }
        public Object RawClass { get { return this[nameof(RawClass)].As<Object>(); } set { this["RawClass"] = value; } } // ClassPtrProperty
        public Object WrappedClass { get { return this[nameof(WrappedClass)].As<Object>(); } set { this["WrappedClass"] = value; } } // ClassPtrProperty
        public Object SubClass { get { return this[nameof(SubClass)]; } set { this[nameof(SubClass)] = value; } }
        public Object SoftClass { get { return this[nameof(SoftClass)]; } set { this[nameof(SoftClass)] = value; } }
        public Object RawObject { get { return this[nameof(RawObject)].As<Object>(); } set { this["RawObject"] = value; } }
        public Object WrappedObject { get { return this[nameof(WrappedObject)].As<Object>(); } set { this["WrappedObject"] = value; } }
        public Object WeakObject { get { return this[nameof(WeakObject)]; } set { this[nameof(WeakObject)] = value; } }
        public Object SoftObject { get { return this[nameof(SoftObject)]; } set { this[nameof(SoftObject)] = value; } }
        public SoftClassPath ClassPath { get { return this[nameof(ClassPath)].As<SoftClassPath>(); } set { this["ClassPath"] = value; } }
        public SoftObjectPath ObjectPath { get { return this[nameof(ObjectPath)].As<SoftObjectPath>(); } set { this["ObjectPath"] = value; } }
    }
    public class StructSerializerBuiltinTestStruct : Object
    {
        public StructSerializerBuiltinTestStruct(nint addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public Vector4 Vector4 { get { return this[nameof(Vector4)].As<Vector4>(); } set { this["Vector4"] = value; } }
        public Rotator Rotator { get { return this[nameof(Rotator)].As<Rotator>(); } set { this["Rotator"] = value; } }
        public Quat Quat { get { return this[nameof(Quat)].As<Quat>(); } set { this["Quat"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
    }
    public class StructSerializerLWCTypesTest : Object
    {
        public StructSerializerLWCTypesTest(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public Vector2D Vector2D { get { return this[nameof(Vector2D)].As<Vector2D>(); } set { this["Vector2D"] = value; } }
        public Vector4 Vector4 { get { return this[nameof(Vector4)].As<Vector4>(); } set { this["Vector4"] = value; } }
        public Matrix Matrix { get { return this[nameof(Matrix)].As<Matrix>(); } set { this["Matrix"] = value; } }
        public Plane Plane { get { return this[nameof(Plane)].As<Plane>(); } set { this["Plane"] = value; } }
        public Quat Quat { get { return this[nameof(Quat)].As<Quat>(); } set { this["Quat"] = value; } }
        public Rotator Rotator { get { return this[nameof(Rotator)].As<Rotator>(); } set { this["Rotator"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
        public Box2D Box2D { get { return this[nameof(Box2D)].As<Box2D>(); } set { this["Box2D"] = value; } }
        public BoxSphereBounds BoxSphereBounds { get { return this[nameof(BoxSphereBounds)].As<BoxSphereBounds>(); } set { this["BoxSphereBounds"] = value; } }
        public OrientedBox OrientedBox { get { return this[nameof(OrientedBox)].As<OrientedBox>(); } set { this["OrientedBox"] = value; } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
        public double Double { get { return this[nameof(Double)].GetValue<double>(); } set { this[nameof(Double)].SetValue<double>(value); } }
        public Array<Vector> VectorArray { get { return new Array<Vector>(this[nameof(VectorArray)].Address); } }
        public Object StrToVec { get { return this[nameof(StrToVec)]; } set { this[nameof(StrToVec)] = value; } }
        public Object VectorSet { get { return this[nameof(VectorSet)]; } set { this[nameof(VectorSet)] = value; } }
    }
    public class OrientedBoxFloat : Object
    {
        public OrientedBoxFloat(nint addr) : base(addr) { }
        public Vector3f Center { get { return this[nameof(Center)].As<Vector3f>(); } set { this["Center"] = value; } }
        public Vector3f AxisX { get { return this[nameof(AxisX)].As<Vector3f>(); } set { this["AxisX"] = value; } }
        public Vector3f AxisY { get { return this[nameof(AxisY)].As<Vector3f>(); } set { this["AxisY"] = value; } }
        public Vector3f AxisZ { get { return this[nameof(AxisZ)].As<Vector3f>(); } set { this["AxisZ"] = value; } }
        public float ExtentX { get { return this[nameof(ExtentX)].GetValue<float>(); } set { this[nameof(ExtentX)].SetValue<float>(value); } }
        public float ExtentY { get { return this[nameof(ExtentY)].GetValue<float>(); } set { this[nameof(ExtentY)].SetValue<float>(value); } }
        public float ExtentZ { get { return this[nameof(ExtentZ)].GetValue<float>(); } set { this[nameof(ExtentZ)].SetValue<float>(value); } }
    }
    public class StructSerializerNonLWCTypesTest : Object
    {
        public StructSerializerNonLWCTypesTest(nint addr) : base(addr) { }
        public Vector3f Vector { get { return this[nameof(Vector)].As<Vector3f>(); } set { this["Vector"] = value; } }
        public Vector2f Vector2D { get { return this[nameof(Vector2D)].As<Vector2f>(); } set { this["Vector2D"] = value; } }
        public Vector4f Vector4 { get { return this[nameof(Vector4)].As<Vector4f>(); } set { this["Vector4"] = value; } }
        public Matrix44f Matrix { get { return this[nameof(Matrix)].As<Matrix44f>(); } set { this["Matrix"] = value; } }
        public Plane4f Plane { get { return this[nameof(Plane)].As<Plane4f>(); } set { this["Plane"] = value; } }
        public Quat4f Quat { get { return this[nameof(Quat)].As<Quat4f>(); } set { this["Quat"] = value; } }
        public Rotator3f Rotator { get { return this[nameof(Rotator)].As<Rotator3f>(); } set { this["Rotator"] = value; } }
        public Transform3f Transform { get { return this[nameof(Transform)].As<Transform3f>(); } set { this["Transform"] = value; } }
        public Box3f Box { get { return this[nameof(Box)].As<Box3f>(); } set { this["Box"] = value; } }
        public Box2f Box2D { get { return this[nameof(Box2D)].As<Box2f>(); } set { this["Box2D"] = value; } }
        public BoxSphereBounds3f BoxSphereBounds { get { return this[nameof(BoxSphereBounds)].As<BoxSphereBounds3f>(); } set { this["BoxSphereBounds"] = value; } }
        public OrientedBoxFloat OrientedBox { get { return this[nameof(OrientedBox)].As<OrientedBoxFloat>(); } set { this["OrientedBox"] = value; } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
        public double Double { get { return this[nameof(Double)].GetValue<double>(); } set { this[nameof(Double)].SetValue<double>(value); } }
        public Array<Vector3f> VectorArray { get { return new Array<Vector3f>(this[nameof(VectorArray)].Address); } }
        public Object StrToVec { get { return this[nameof(StrToVec)]; } set { this[nameof(StrToVec)] = value; } }
        public Object VectorSet { get { return this[nameof(VectorSet)]; } set { this[nameof(VectorSet)] = value; } }
    }
    public class StructSerializerByteArray : Object
    {
        public StructSerializerByteArray(nint addr) : base(addr) { }
        public int Dummy1 { get { return this[nameof(Dummy1)].GetValue<int>(); } set { this[nameof(Dummy1)].SetValue<int>(value); } }
        public Array<byte> ByteArray { get { return new Array<byte>(this[nameof(ByteArray)].Address); } }
        public int Dummy2 { get { return this[nameof(Dummy2)].GetValue<int>(); } set { this[nameof(Dummy2)].SetValue<int>(value); } }
        public Array<byte> Int8Array { get { return new Array<byte>(this[nameof(Int8Array)].Address); } }
        public int Dummy3 { get { return this[nameof(Dummy3)].GetValue<int>(); } set { this[nameof(Dummy3)].SetValue<int>(value); } }
    }
    public class StructSerializerArrayTestStruct : Object
    {
        public StructSerializerArrayTestStruct(nint addr) : base(addr) { }
        public Array<int> Int32Array { get { return new Array<int>(this[nameof(Int32Array)].Address); } }
        public Array<byte> ByteArray { get { return new Array<byte>(this[nameof(ByteArray)].Address); } }
        public int StaticSingleElement { get { return this[nameof(StaticSingleElement)].GetValue<int>(); } set { this[nameof(StaticSingleElement)].SetValue<int>(value); } }
        public int StaticInt32Array { get { return this[nameof(StaticInt32Array)].GetValue<int>(); } set { this[nameof(StaticInt32Array)].SetValue<int>(value); } }
        public float StaticFloatArray { get { return this[nameof(StaticFloatArray)].GetValue<float>(); } set { this[nameof(StaticFloatArray)].SetValue<float>(value); } }
        public Array<Vector> VectorArray { get { return new Array<Vector>(this[nameof(VectorArray)].Address); } }
        public Array<StructSerializerBuiltinTestStruct> StructArray { get { return new Array<StructSerializerBuiltinTestStruct>(this[nameof(StructArray)].Address); } }
    }
    public class StructSerializerMapTestStruct : Object
    {
        public StructSerializerMapTestStruct(nint addr) : base(addr) { }
        public Object IntToStr { get { return this[nameof(IntToStr)]; } set { this[nameof(IntToStr)] = value; } }
        public Object StrToStr { get { return this[nameof(StrToStr)]; } set { this[nameof(StrToStr)] = value; } }
        public Object StrToVec { get { return this[nameof(StrToVec)]; } set { this[nameof(StrToVec)] = value; } }
        public Object StrToStruct { get { return this[nameof(StrToStruct)]; } set { this[nameof(StrToStruct)] = value; } }
    }
    public class StructSerializerSetTestStruct : Object
    {
        public StructSerializerSetTestStruct(nint addr) : base(addr) { }
        public Object StrSet { get { return this[nameof(StrSet)]; } set { this[nameof(StrSet)] = value; } }
        public Object IntSet { get { return this[nameof(IntSet)]; } set { this[nameof(IntSet)] = value; } }
        public Object NameSet { get { return this[nameof(NameSet)]; } set { this[nameof(NameSet)] = value; } }
        public Object StructSet { get { return this[nameof(StructSet)]; } set { this[nameof(StructSet)] = value; } }
    }
    public class StructSerializerTestStruct : Object
    {
        public StructSerializerTestStruct(nint addr) : base(addr) { }
        public StructSerializerNumericTestStruct Numerics { get { return this[nameof(Numerics)].As<StructSerializerNumericTestStruct>(); } set { this["Numerics"] = value; } }
        public StructSerializerBooleanTestStruct Booleans { get { return this[nameof(Booleans)].As<StructSerializerBooleanTestStruct>(); } set { this["Booleans"] = value; } }
        public StructSerializerObjectTestStruct Objects { get { return this[nameof(Objects)].As<StructSerializerObjectTestStruct>(); } set { this["Objects"] = value; } }
        public StructSerializerBuiltinTestStruct Builtins { get { return this[nameof(Builtins)].As<StructSerializerBuiltinTestStruct>(); } set { this["Builtins"] = value; } }
        public StructSerializerArrayTestStruct Arrays { get { return this[nameof(Arrays)].As<StructSerializerArrayTestStruct>(); } set { this["Arrays"] = value; } }
        public StructSerializerMapTestStruct Maps { get { return this[nameof(Maps)].As<StructSerializerMapTestStruct>(); } set { this["Maps"] = value; } }
        public StructSerializerSetTestStruct Sets { get { return this[nameof(Sets)].As<StructSerializerSetTestStruct>(); } set { this["Sets"] = value; } }
        public StructSerializerLWCTypesTest LWCTypes { get { return this[nameof(LWCTypes)].As<StructSerializerLWCTypesTest>(); } set { this["LWCTypes"] = value; } }
    }
}
