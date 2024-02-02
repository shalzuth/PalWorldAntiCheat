using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.CoreUObjectSDK
{
    public class Interface : Object
    {
        public Interface(nint addr) : base(addr) { }
    }
    public class Package : Object
    {
        public Package(nint addr) : base(addr) { }
    }
    public class Field : Object
    {
        public Field(nint addr) : base(addr) { }
    }
    public class Struct : Field
    {
        public Struct(nint addr) : base(addr) { }
    }
    public class Class : Struct
    {
        public Class(nint addr) : base(addr) { }
    }
    public class GCObjectReferencer : Object
    {
        public GCObjectReferencer(nint addr) : base(addr) { }
    }
    public class TextBuffer : Object
    {
        public TextBuffer(nint addr) : base(addr) { }
    }
    public class ScriptStruct : Struct
    {
        public ScriptStruct(nint addr) : base(addr) { }
    }
    public class Function : Struct
    {
        public Function(nint addr) : base(addr) { }
    }
    public class DelegateFunction : Function
    {
        public DelegateFunction(nint addr) : base(addr) { }
    }
    public class SparseDelegateFunction : DelegateFunction
    {
        public SparseDelegateFunction(nint addr) : base(addr) { }
    }
    public class DynamicClass : Class
    {
        public DynamicClass(nint addr) : base(addr) { }
    }
    public class PackageMap : Object
    {
        public PackageMap(nint addr) : base(addr) { }
    }
    public class Enum : Field
    {
        public Enum(nint addr) : base(addr) { }
    }
    public class LinkerPlaceholderClass : Class
    {
        public LinkerPlaceholderClass(nint addr) : base(addr) { }
    }
    public class LinkerPlaceholderExportObject : Object
    {
        public LinkerPlaceholderExportObject(nint addr) : base(addr) { }
    }
    public class LinkerPlaceholderFunction : Function
    {
        public LinkerPlaceholderFunction(nint addr) : base(addr) { }
    }
    public class MetaData : Object
    {
        public MetaData(nint addr) : base(addr) { }
    }
    public class ObjectRedirector : Object
    {
        public ObjectRedirector(nint addr) : base(addr) { }
    }
    public class Property : Field
    {
        public Property(nint addr) : base(addr) { }
    }
    public class EnumProperty : Property
    {
        public EnumProperty(nint addr) : base(addr) { }
    }
    public class ArrayProperty : Property
    {
        public ArrayProperty(nint addr) : base(addr) { }
    }
    public class ObjectPropertyBase : Property
    {
        public ObjectPropertyBase(nint addr) : base(addr) { }
    }
    public class BoolProperty : Property
    {
        public BoolProperty(nint addr) : base(addr) { }
    }
    public class NumericProperty : Property
    {
        public NumericProperty(nint addr) : base(addr) { }
    }
    public class ByteProperty : NumericProperty
    {
        public ByteProperty(nint addr) : base(addr) { }
    }
    public class ObjectProperty : ObjectPropertyBase
    {
        public ObjectProperty(nint addr) : base(addr) { }
    }
    public class ClassProperty : ObjectProperty
    {
        public ClassProperty(nint addr) : base(addr) { }
    }
    public class DelegateProperty : Property
    {
        public DelegateProperty(nint addr) : base(addr) { }
    }
    public class DoubleProperty : NumericProperty
    {
        public DoubleProperty(nint addr) : base(addr) { }
    }
    public class FloatProperty : NumericProperty
    {
        public FloatProperty(nint addr) : base(addr) { }
    }
    public class IntProperty : NumericProperty
    {
        public IntProperty(nint addr) : base(addr) { }
    }
    public class Int8Property : NumericProperty
    {
        public Int8Property(nint addr) : base(addr) { }
    }
    public class Int16Property : NumericProperty
    {
        public Int16Property(nint addr) : base(addr) { }
    }
    public class Int64Property : NumericProperty
    {
        public Int64Property(nint addr) : base(addr) { }
    }
    public class InterfaceProperty : Property
    {
        public InterfaceProperty(nint addr) : base(addr) { }
    }
    public class LazyObjectProperty : ObjectPropertyBase
    {
        public LazyObjectProperty(nint addr) : base(addr) { }
    }
    public class MapProperty : Property
    {
        public MapProperty(nint addr) : base(addr) { }
    }
    public class MulticastDelegateProperty : Property
    {
        public MulticastDelegateProperty(nint addr) : base(addr) { }
    }
    public class MulticastInlineDelegateProperty : MulticastDelegateProperty
    {
        public MulticastInlineDelegateProperty(nint addr) : base(addr) { }
    }
    public class MulticastSparseDelegateProperty : MulticastDelegateProperty
    {
        public MulticastSparseDelegateProperty(nint addr) : base(addr) { }
    }
    public class NameProperty : Property
    {
        public NameProperty(nint addr) : base(addr) { }
    }
    public class SetProperty : Property
    {
        public SetProperty(nint addr) : base(addr) { }
    }
    public class SoftObjectProperty : ObjectPropertyBase
    {
        public SoftObjectProperty(nint addr) : base(addr) { }
    }
    public class SoftClassProperty : SoftObjectProperty
    {
        public SoftClassProperty(nint addr) : base(addr) { }
    }
    public class StrProperty : Property
    {
        public StrProperty(nint addr) : base(addr) { }
    }
    public class StructProperty : Property
    {
        public StructProperty(nint addr) : base(addr) { }
    }
    public class UInt16Property : NumericProperty
    {
        public UInt16Property(nint addr) : base(addr) { }
    }
    public class UInt32Property : NumericProperty
    {
        public UInt32Property(nint addr) : base(addr) { }
    }
    public class UInt64Property : NumericProperty
    {
        public UInt64Property(nint addr) : base(addr) { }
    }
    public class WeakObjectProperty : ObjectPropertyBase
    {
        public WeakObjectProperty(nint addr) : base(addr) { }
    }
    public class TextProperty : Property
    {
        public TextProperty(nint addr) : base(addr) { }
    }
    public class PropertyWrapper : Object
    {
        public PropertyWrapper(nint addr) : base(addr) { }
    }
    public class MulticastDelegatePropertyWrapper : PropertyWrapper
    {
        public MulticastDelegatePropertyWrapper(nint addr) : base(addr) { }
    }
    public class MulticastInlineDelegatePropertyWrapper : MulticastDelegatePropertyWrapper
    {
        public MulticastInlineDelegatePropertyWrapper(nint addr) : base(addr) { }
    }
    public class Default__ScriptStruct : Object
    {
        public Default__ScriptStruct(nint addr) : base(addr) { }
    }
    public class ARFilter : Object
    {
        public ARFilter(nint addr) : base(addr) { }
        public Array<Object> PackageNames { get { return new Array<Object>(this[nameof(PackageNames)].Address); } }
        public Array<Object> PackagePaths { get { return new Array<Object>(this[nameof(PackagePaths)].Address); } }
        public Array<SoftObjectPath> SoftObjectPaths { get { return new Array<SoftObjectPath>(this[nameof(SoftObjectPaths)].Address); } }
        public Array<Object> ClassNames { get { return new Array<Object>(this[nameof(ClassNames)].Address); } }
        public Array<TopLevelAssetPath> ClassPaths { get { return new Array<TopLevelAssetPath>(this[nameof(ClassPaths)].Address); } }
        public Object RecursiveClassesExclusionSet { get { return this[nameof(RecursiveClassesExclusionSet)]; } set { this[nameof(RecursiveClassesExclusionSet)] = value; } }
        public Object RecursiveClassPathsExclusionSet { get { return this[nameof(RecursiveClassPathsExclusionSet)]; } set { this[nameof(RecursiveClassPathsExclusionSet)] = value; } }
        public bool bRecursivePaths { get { return this[nameof(bRecursivePaths)].Flag; } set { this[nameof(bRecursivePaths)].Flag = value; } }
        public bool bRecursiveClasses { get { return this[nameof(bRecursiveClasses)].Flag; } set { this[nameof(bRecursiveClasses)].Flag = value; } }
        public bool bIncludeOnlyOnDiskAssets { get { return this[nameof(bIncludeOnlyOnDiskAssets)].Flag; } set { this[nameof(bIncludeOnlyOnDiskAssets)].Flag = value; } }
    }
    public class TopLevelAssetPath : Object
    {
        public TopLevelAssetPath(nint addr) : base(addr) { }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
    }
    public class SoftObjectPath : Object
    {
        public SoftObjectPath(nint addr) : base(addr) { }
        public TopLevelAssetPath AssetPath { get { return this[nameof(AssetPath)].As<TopLevelAssetPath>(); } set { this["AssetPath"] = value; } }
        public Object SubPathString { get { return this[nameof(SubPathString)]; } set { this[nameof(SubPathString)] = value; } }
    }
    public class AssetBundleData : Object
    {
        public AssetBundleData(nint addr) : base(addr) { }
        public Array<AssetBundleEntry> Bundles { get { return new Array<AssetBundleEntry>(this[nameof(Bundles)].Address); } }
    }
    public class AssetBundleEntry : Object
    {
        public AssetBundleEntry(nint addr) : base(addr) { }
        public Object BundleName { get { return this[nameof(BundleName)]; } set { this[nameof(BundleName)] = value; } }
        public Array<TopLevelAssetPath> AssetPaths { get { return new Array<TopLevelAssetPath>(this[nameof(AssetPaths)].Address); } }
    }
    public class AssetData : Object
    {
        public AssetData(nint addr) : base(addr) { }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public Object PackagePath { get { return this[nameof(PackagePath)]; } set { this[nameof(PackagePath)] = value; } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public Object AssetClass { get { return this[nameof(AssetClass)]; } set { this[nameof(AssetClass)] = value; } }
        public TopLevelAssetPath AssetClassPath { get { return this[nameof(AssetClassPath)].As<TopLevelAssetPath>(); } set { this["AssetClassPath"] = value; } }
    }
    public class AutomationEvent : Object
    {
        public AutomationEvent(nint addr) : base(addr) { }
        public EAutomationEventType Type { get { return (EAutomationEventType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public Guid Artifact { get { return this[nameof(Artifact)].As<Guid>(); } set { this["Artifact"] = value; } }
    }
    public class Guid : Object
    {
        public Guid(nint addr) : base(addr) { }
        public int A { get { return this[nameof(A)].GetValue<int>(); } set { this[nameof(A)].SetValue<int>(value); } }
        public int B { get { return this[nameof(B)].GetValue<int>(); } set { this[nameof(B)].SetValue<int>(value); } }
        public int C { get { return this[nameof(C)].GetValue<int>(); } set { this[nameof(C)].SetValue<int>(value); } }
        public int D { get { return this[nameof(D)].GetValue<int>(); } set { this[nameof(D)].SetValue<int>(value); } }
    }
    public enum EAutomationEventType : int
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        EAutomationEventType_MAX = 3,
    }
    public enum Default__Enum : int
    {
    }
    public class AutomationExecutionEntry : Object
    {
        public AutomationExecutionEntry(nint addr) : base(addr) { }
        public AutomationEvent Event { get { return this[nameof(Event)].As<AutomationEvent>(); } set { this["Event"] = value; } }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public int LineNumber { get { return this[nameof(LineNumber)].GetValue<int>(); } set { this[nameof(LineNumber)].SetValue<int>(value); } }
        public DateTime Timestamp { get { return this[nameof(Timestamp)].As<DateTime>(); } set { this["Timestamp"] = value; } }
    }
    public class DateTime : Object
    {
        public DateTime(nint addr) : base(addr) { }
    }
    public class Box : Object
    {
        public Box(nint addr) : base(addr) { }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public byte IsValid { get { return this[nameof(IsValid)].GetValue<byte>(); } set { this[nameof(IsValid)].SetValue<byte>(value); } }
    }
    public class Vector : Object
    {
        public Vector(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
    }
    public class Box2D : Object
    {
        public Box2D(nint addr) : base(addr) { }
        public Vector2D Min { get { return this[nameof(Min)].As<Vector2D>(); } set { this["Min"] = value; } }
        public Vector2D Max { get { return this[nameof(Max)].As<Vector2D>(); } set { this["Max"] = value; } }
        public byte bIsValid { get { return this[nameof(bIsValid)].GetValue<byte>(); } set { this[nameof(bIsValid)].SetValue<byte>(value); } }
    }
    public class Vector2D : Object
    {
        public Vector2D(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
    }
    public class Box2f : Object
    {
        public Box2f(nint addr) : base(addr) { }
        public Vector2f Min { get { return this[nameof(Min)].As<Vector2f>(); } set { this["Min"] = value; } }
        public Vector2f Max { get { return this[nameof(Max)].As<Vector2f>(); } set { this["Max"] = value; } }
        public byte bIsValid { get { return this[nameof(bIsValid)].GetValue<byte>(); } set { this[nameof(bIsValid)].SetValue<byte>(value); } }
    }
    public class Vector2f : Object
    {
        public Vector2f(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
    }
    public class Box3d : Object
    {
        public Box3d(nint addr) : base(addr) { }
        public Vector3d Min { get { return this[nameof(Min)].As<Vector3d>(); } set { this["Min"] = value; } }
        public Vector3d Max { get { return this[nameof(Max)].As<Vector3d>(); } set { this["Max"] = value; } }
        public byte IsValid { get { return this[nameof(IsValid)].GetValue<byte>(); } set { this[nameof(IsValid)].SetValue<byte>(value); } }
    }
    public class Vector3d : Object
    {
        public Vector3d(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
    }
    public class Box3f : Object
    {
        public Box3f(nint addr) : base(addr) { }
        public Vector3f Min { get { return this[nameof(Min)].As<Vector3f>(); } set { this["Min"] = value; } }
        public Vector3f Max { get { return this[nameof(Max)].As<Vector3f>(); } set { this["Max"] = value; } }
        public byte IsValid { get { return this[nameof(IsValid)].GetValue<byte>(); } set { this[nameof(IsValid)].SetValue<byte>(value); } }
    }
    public class Vector3f : Object
    {
        public Vector3f(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
    }
    public class BoxSphereBounds : Object
    {
        public BoxSphereBounds(nint addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Vector BoxExtent { get { return this[nameof(BoxExtent)].As<Vector>(); } set { this["BoxExtent"] = value; } }
        public double SphereRadius { get { return this[nameof(SphereRadius)].GetValue<double>(); } set { this[nameof(SphereRadius)].SetValue<double>(value); } }
    }
    public class BoxSphereBounds3d : Object
    {
        public BoxSphereBounds3d(nint addr) : base(addr) { }
        public Vector3d Origin { get { return this[nameof(Origin)].As<Vector3d>(); } set { this["Origin"] = value; } }
        public Vector3d BoxExtent { get { return this[nameof(BoxExtent)].As<Vector3d>(); } set { this["BoxExtent"] = value; } }
        public double SphereRadius { get { return this[nameof(SphereRadius)].GetValue<double>(); } set { this[nameof(SphereRadius)].SetValue<double>(value); } }
    }
    public class BoxSphereBounds3f : Object
    {
        public BoxSphereBounds3f(nint addr) : base(addr) { }
        public Vector3f Origin { get { return this[nameof(Origin)].As<Vector3f>(); } set { this["Origin"] = value; } }
        public Vector3f BoxExtent { get { return this[nameof(BoxExtent)].As<Vector3f>(); } set { this["BoxExtent"] = value; } }
        public float SphereRadius { get { return this[nameof(SphereRadius)].GetValue<float>(); } set { this[nameof(SphereRadius)].SetValue<float>(value); } }
    }
    public class Color : Object
    {
        public Color(nint addr) : base(addr) { }
        public byte B { get { return this[nameof(B)].GetValue<byte>(); } set { this[nameof(B)].SetValue<byte>(value); } }
        public byte G { get { return this[nameof(G)].GetValue<byte>(); } set { this[nameof(G)].SetValue<byte>(value); } }
        public byte R { get { return this[nameof(R)].GetValue<byte>(); } set { this[nameof(R)].SetValue<byte>(value); } }
        public byte A { get { return this[nameof(A)].GetValue<byte>(); } set { this[nameof(A)].SetValue<byte>(value); } }
    }
    public class DirectoryPath : Object
    {
        public DirectoryPath(nint addr) : base(addr) { }
        public Object Path { get { return this[nameof(Path)]; } set { this[nameof(Path)] = value; } }
    }
    public class DoubleRange : Object
    {
        public DoubleRange(nint addr) : base(addr) { }
        public DoubleRangeBound LowerBound { get { return this[nameof(LowerBound)].As<DoubleRangeBound>(); } set { this["LowerBound"] = value; } }
        public DoubleRangeBound UpperBound { get { return this[nameof(UpperBound)].As<DoubleRangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class DoubleRangeBound : Object
    {
        public DoubleRangeBound(nint addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public double Value { get { return this[nameof(Value)].GetValue<double>(); } set { this[nameof(Value)].SetValue<double>(value); } }
    }
    public enum ERangeBoundTypes : int
    {
        Exclusive = 0,
        Inclusive = 1,
        Open = 2,
        ERangeBoundTypes_MAX = 3,
    }
    public class FallbackStruct : Object
    {
        public FallbackStruct(nint addr) : base(addr) { }
    }
    public class FilePath : Object
    {
        public FilePath(nint addr) : base(addr) { }
        public Object FilePath_value { get { return this[nameof(FilePath)]; } set { this[nameof(FilePath)] = value; } }
    }
    public class FloatInterval : Object
    {
        public FloatInterval(nint addr) : base(addr) { }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
    }
    public class FloatRange : Object
    {
        public FloatRange(nint addr) : base(addr) { }
        public FloatRangeBound LowerBound { get { return this[nameof(LowerBound)].As<FloatRangeBound>(); } set { this["LowerBound"] = value; } }
        public FloatRangeBound UpperBound { get { return this[nameof(UpperBound)].As<FloatRangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class FloatRangeBound : Object
    {
        public FloatRangeBound(nint addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class FrameNumber : Object
    {
        public FrameNumber(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class FrameNumberRange : Object
    {
        public FrameNumberRange(nint addr) : base(addr) { }
        public FrameNumberRangeBound LowerBound { get { return this[nameof(LowerBound)].As<FrameNumberRangeBound>(); } set { this["LowerBound"] = value; } }
        public FrameNumberRangeBound UpperBound { get { return this[nameof(UpperBound)].As<FrameNumberRangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class FrameNumberRangeBound : Object
    {
        public FrameNumberRangeBound(nint addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public FrameNumber Value { get { return this[nameof(Value)].As<FrameNumber>(); } set { this["Value"] = value; } }
    }
    public class FrameRate : Object
    {
        public FrameRate(nint addr) : base(addr) { }
        public int Numerator { get { return this[nameof(Numerator)].GetValue<int>(); } set { this[nameof(Numerator)].SetValue<int>(value); } }
        public int Denominator { get { return this[nameof(Denominator)].GetValue<int>(); } set { this[nameof(Denominator)].SetValue<int>(value); } }
    }
    public class FrameTime : Object
    {
        public FrameTime(nint addr) : base(addr) { }
        public FrameNumber FrameNumber { get { return this[nameof(FrameNumber)].As<FrameNumber>(); } set { this["FrameNumber"] = value; } }
        public float SubFrame { get { return this[nameof(SubFrame)].GetValue<float>(); } set { this[nameof(SubFrame)].SetValue<float>(value); } }
    }
    public class InputDeviceId : Object
    {
        public InputDeviceId(nint addr) : base(addr) { }
        public int InternalId { get { return this[nameof(InternalId)].GetValue<int>(); } set { this[nameof(InternalId)].SetValue<int>(value); } }
    }
    public class Int32Interval : Object
    {
        public Int32Interval(nint addr) : base(addr) { }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
    }
    public class Int32Point : Object
    {
        public Int32Point(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class Int32Range : Object
    {
        public Int32Range(nint addr) : base(addr) { }
        public Int32RangeBound LowerBound { get { return this[nameof(LowerBound)].As<Int32RangeBound>(); } set { this["LowerBound"] = value; } }
        public Int32RangeBound UpperBound { get { return this[nameof(UpperBound)].As<Int32RangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class Int32RangeBound : Object
    {
        public Int32RangeBound(nint addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class Int32Vector : Object
    {
        public Int32Vector(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Z { get { return this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>(value); } }
    }
    public class Int32Vector2 : Object
    {
        public Int32Vector2(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class Int32Vector4 : Object
    {
        public Int32Vector4(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Z { get { return this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>(value); } }
        public int W { get { return this[nameof(W)].GetValue<int>(); } set { this[nameof(W)].SetValue<int>(value); } }
    }
    public class Int64Point : Object
    {
        public Int64Point(nint addr) : base(addr) { }
        public long X { get { return this[nameof(X)].GetValue<long>(); } set { this[nameof(X)].SetValue<long>(value); } }
        public long Y { get { return this[nameof(Y)].GetValue<long>(); } set { this[nameof(Y)].SetValue<long>(value); } }
    }
    public class Int64Vector : Object
    {
        public Int64Vector(nint addr) : base(addr) { }
        public long X { get { return this[nameof(X)].GetValue<long>(); } set { this[nameof(X)].SetValue<long>(value); } }
        public long Y { get { return this[nameof(Y)].GetValue<long>(); } set { this[nameof(Y)].SetValue<long>(value); } }
        public long Z { get { return this[nameof(Z)].GetValue<long>(); } set { this[nameof(Z)].SetValue<long>(value); } }
    }
    public class Int64Vector2 : Object
    {
        public Int64Vector2(nint addr) : base(addr) { }
        public long X { get { return this[nameof(X)].GetValue<long>(); } set { this[nameof(X)].SetValue<long>(value); } }
        public long Y { get { return this[nameof(Y)].GetValue<long>(); } set { this[nameof(Y)].SetValue<long>(value); } }
    }
    public class Int64Vector4 : Object
    {
        public Int64Vector4(nint addr) : base(addr) { }
        public long X { get { return this[nameof(X)].GetValue<long>(); } set { this[nameof(X)].SetValue<long>(value); } }
        public long Y { get { return this[nameof(Y)].GetValue<long>(); } set { this[nameof(Y)].SetValue<long>(value); } }
        public long Z { get { return this[nameof(Z)].GetValue<long>(); } set { this[nameof(Z)].SetValue<long>(value); } }
        public long W { get { return this[nameof(W)].GetValue<long>(); } set { this[nameof(W)].SetValue<long>(value); } }
    }
    public class InterpCurveFloat : Object
    {
        public InterpCurveFloat(nint addr) : base(addr) { }
        public Array<InterpCurvePointFloat> Points { get { return new Array<InterpCurvePointFloat>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointFloat : Object
    {
        public InterpCurvePointFloat(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public float OutVal { get { return this[nameof(OutVal)].GetValue<float>(); } set { this[nameof(OutVal)].SetValue<float>(value); } }
        public float ArriveTangent { get { return this[nameof(ArriveTangent)].GetValue<float>(); } set { this[nameof(ArriveTangent)].SetValue<float>(value); } }
        public float LeaveTangent { get { return this[nameof(LeaveTangent)].GetValue<float>(); } set { this[nameof(LeaveTangent)].SetValue<float>(value); } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public enum EInterpCurveMode : int
    {
        CIM_Linear = 0,
        CIM_CurveAuto = 1,
        CIM_Constant = 2,
        CIM_CurveUser = 3,
        CIM_CurveBreak = 4,
        CIM_CurveAutoClamped = 5,
        CIM_MAX = 6,
    }
    public class InterpCurveLinearColor : Object
    {
        public InterpCurveLinearColor(nint addr) : base(addr) { }
        public Array<InterpCurvePointLinearColor> Points { get { return new Array<InterpCurvePointLinearColor>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointLinearColor : Object
    {
        public InterpCurvePointLinearColor(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public LinearColor OutVal { get { return this[nameof(OutVal)].As<LinearColor>(); } set { this["OutVal"] = value; } }
        public LinearColor ArriveTangent { get { return this[nameof(ArriveTangent)].As<LinearColor>(); } set { this["ArriveTangent"] = value; } }
        public LinearColor LeaveTangent { get { return this[nameof(LeaveTangent)].As<LinearColor>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class LinearColor : Object
    {
        public LinearColor(nint addr) : base(addr) { }
        public float R { get { return this[nameof(R)].GetValue<float>(); } set { this[nameof(R)].SetValue<float>(value); } }
        public float G { get { return this[nameof(G)].GetValue<float>(); } set { this[nameof(G)].SetValue<float>(value); } }
        public float B { get { return this[nameof(B)].GetValue<float>(); } set { this[nameof(B)].SetValue<float>(value); } }
        public float A { get { return this[nameof(A)].GetValue<float>(); } set { this[nameof(A)].SetValue<float>(value); } }
    }
    public class InterpCurvePointQuat : Object
    {
        public InterpCurvePointQuat(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Quat OutVal { get { return this[nameof(OutVal)].As<Quat>(); } set { this["OutVal"] = value; } }
        public Quat ArriveTangent { get { return this[nameof(ArriveTangent)].As<Quat>(); } set { this["ArriveTangent"] = value; } }
        public Quat LeaveTangent { get { return this[nameof(LeaveTangent)].As<Quat>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class Quat : Object
    {
        public Quat(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class InterpCurvePointTwoVectors : Object
    {
        public InterpCurvePointTwoVectors(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public TwoVectors OutVal { get { return this[nameof(OutVal)].As<TwoVectors>(); } set { this["OutVal"] = value; } }
        public TwoVectors ArriveTangent { get { return this[nameof(ArriveTangent)].As<TwoVectors>(); } set { this["ArriveTangent"] = value; } }
        public TwoVectors LeaveTangent { get { return this[nameof(LeaveTangent)].As<TwoVectors>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class TwoVectors : Object
    {
        public TwoVectors(nint addr) : base(addr) { }
        public Vector v1 { get { return this[nameof(v1)].As<Vector>(); } set { this["v1"] = value; } }
        public Vector v2 { get { return this[nameof(v2)].As<Vector>(); } set { this["v2"] = value; } }
    }
    public class InterpCurvePointVector : Object
    {
        public InterpCurvePointVector(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Vector OutVal { get { return this[nameof(OutVal)].As<Vector>(); } set { this["OutVal"] = value; } }
        public Vector ArriveTangent { get { return this[nameof(ArriveTangent)].As<Vector>(); } set { this["ArriveTangent"] = value; } }
        public Vector LeaveTangent { get { return this[nameof(LeaveTangent)].As<Vector>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurvePointVector2D : Object
    {
        public InterpCurvePointVector2D(nint addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Vector2D OutVal { get { return this[nameof(OutVal)].As<Vector2D>(); } set { this["OutVal"] = value; } }
        public Vector2D ArriveTangent { get { return this[nameof(ArriveTangent)].As<Vector2D>(); } set { this["ArriveTangent"] = value; } }
        public Vector2D LeaveTangent { get { return this[nameof(LeaveTangent)].As<Vector2D>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveQuat : Object
    {
        public InterpCurveQuat(nint addr) : base(addr) { }
        public Array<InterpCurvePointQuat> Points { get { return new Array<InterpCurvePointQuat>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurveTwoVectors : Object
    {
        public InterpCurveTwoVectors(nint addr) : base(addr) { }
        public Array<InterpCurvePointTwoVectors> Points { get { return new Array<InterpCurvePointTwoVectors>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurveVector : Object
    {
        public InterpCurveVector(nint addr) : base(addr) { }
        public Array<InterpCurvePointVector> Points { get { return new Array<InterpCurvePointVector>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurveVector2D : Object
    {
        public InterpCurveVector2D(nint addr) : base(addr) { }
        public Array<InterpCurvePointVector2D> Points { get { return new Array<InterpCurvePointVector2D>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class IntPoint : Object
    {
        public IntPoint(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class IntVector : Object
    {
        public IntVector(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Z { get { return this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>(value); } }
    }
    public class IntVector2 : Object
    {
        public IntVector2(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class IntVector4 : Object
    {
        public IntVector4(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Z { get { return this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>(value); } }
        public int W { get { return this[nameof(W)].GetValue<int>(); } set { this[nameof(W)].SetValue<int>(value); } }
    }
    public class Matrix : Object
    {
        public Matrix(nint addr) : base(addr) { }
        public Plane XPlane { get { return this[nameof(XPlane)].As<Plane>(); } set { this["XPlane"] = value; } }
        public Plane YPlane { get { return this[nameof(YPlane)].As<Plane>(); } set { this["YPlane"] = value; } }
        public Plane ZPlane { get { return this[nameof(ZPlane)].As<Plane>(); } set { this["ZPlane"] = value; } }
        public Plane WPlane { get { return this[nameof(WPlane)].As<Plane>(); } set { this["WPlane"] = value; } }
    }
    public class Plane : Vector
    {
        public Plane(nint addr) : base(addr) { }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class Matrix44d : Object
    {
        public Matrix44d(nint addr) : base(addr) { }
        public Plane4d XPlane { get { return this[nameof(XPlane)].As<Plane4d>(); } set { this["XPlane"] = value; } }
        public Plane4d YPlane { get { return this[nameof(YPlane)].As<Plane4d>(); } set { this["YPlane"] = value; } }
        public Plane4d ZPlane { get { return this[nameof(ZPlane)].As<Plane4d>(); } set { this["ZPlane"] = value; } }
        public Plane4d WPlane { get { return this[nameof(WPlane)].As<Plane4d>(); } set { this["WPlane"] = value; } }
    }
    public class Plane4d : Vector3d
    {
        public Plane4d(nint addr) : base(addr) { }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class Matrix44f : Object
    {
        public Matrix44f(nint addr) : base(addr) { }
        public Plane4f XPlane { get { return this[nameof(XPlane)].As<Plane4f>(); } set { this["XPlane"] = value; } }
        public Plane4f YPlane { get { return this[nameof(YPlane)].As<Plane4f>(); } set { this["YPlane"] = value; } }
        public Plane4f ZPlane { get { return this[nameof(ZPlane)].As<Plane4f>(); } set { this["ZPlane"] = value; } }
        public Plane4f WPlane { get { return this[nameof(WPlane)].As<Plane4f>(); } set { this["WPlane"] = value; } }
    }
    public class Plane4f : Vector3f
    {
        public Plane4f(nint addr) : base(addr) { }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public class OrientedBox : Object
    {
        public OrientedBox(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector AxisX { get { return this[nameof(AxisX)].As<Vector>(); } set { this["AxisX"] = value; } }
        public Vector AxisY { get { return this[nameof(AxisY)].As<Vector>(); } set { this["AxisY"] = value; } }
        public Vector AxisZ { get { return this[nameof(AxisZ)].As<Vector>(); } set { this["AxisZ"] = value; } }
        public double ExtentX { get { return this[nameof(ExtentX)].GetValue<double>(); } set { this[nameof(ExtentX)].SetValue<double>(value); } }
        public double ExtentY { get { return this[nameof(ExtentY)].GetValue<double>(); } set { this[nameof(ExtentY)].SetValue<double>(value); } }
        public double ExtentZ { get { return this[nameof(ExtentZ)].GetValue<double>(); } set { this[nameof(ExtentZ)].SetValue<double>(value); } }
    }
    public class PackedNormal : Object
    {
        public PackedNormal(nint addr) : base(addr) { }
        public byte X { get { return this[nameof(X)].GetValue<byte>(); } set { this[nameof(X)].SetValue<byte>(value); } }
        public byte Y { get { return this[nameof(Y)].GetValue<byte>(); } set { this[nameof(Y)].SetValue<byte>(value); } }
        public byte Z { get { return this[nameof(Z)].GetValue<byte>(); } set { this[nameof(Z)].SetValue<byte>(value); } }
        public byte W { get { return this[nameof(W)].GetValue<byte>(); } set { this[nameof(W)].SetValue<byte>(value); } }
    }
    public class PackedRGB10A2N : Object
    {
        public PackedRGB10A2N(nint addr) : base(addr) { }
        public int Packed { get { return this[nameof(Packed)].GetValue<int>(); } set { this[nameof(Packed)].SetValue<int>(value); } }
    }
    public class PackedRGBA16N : Object
    {
        public PackedRGBA16N(nint addr) : base(addr) { }
        public int XY { get { return this[nameof(XY)].GetValue<int>(); } set { this[nameof(XY)].SetValue<int>(value); } }
        public int ZW { get { return this[nameof(ZW)].GetValue<int>(); } set { this[nameof(ZW)].SetValue<int>(value); } }
    }
    public class PlatformInputDeviceState : Object
    {
        public PlatformInputDeviceState(nint addr) : base(addr) { }
        public PlatformUserId OwningPlatformUser { get { return this[nameof(OwningPlatformUser)].As<PlatformUserId>(); } set { this["OwningPlatformUser"] = value; } }
        public EInputDeviceConnectionState ConnectionState { get { return (EInputDeviceConnectionState)this[nameof(ConnectionState)].GetValue<int>(); } set { this[nameof(ConnectionState)].SetValue<int>((int)value); } }
    }
    public enum EInputDeviceConnectionState : int
    {
        Invalid = 0,
        Unknown = 1,
        Disconnected = 2,
        Connected = 3,
        EInputDeviceConnectionState_MAX = 4,
    }
    public class PlatformUserId : Object
    {
        public PlatformUserId(nint addr) : base(addr) { }
        public int InternalId { get { return this[nameof(InternalId)].GetValue<int>(); } set { this[nameof(InternalId)].SetValue<int>(value); } }
    }
    public class PolyglotTextData : Object
    {
        public PolyglotTextData(nint addr) : base(addr) { }
        public ELocalizedTextSourceCategory Category { get { return (ELocalizedTextSourceCategory)this[nameof(Category)].GetValue<int>(); } set { this[nameof(Category)].SetValue<int>((int)value); } }
        public Object NativeCulture { get { return this[nameof(NativeCulture)]; } set { this[nameof(NativeCulture)] = value; } }
        public Object Namespace { get { return this[nameof(Namespace)]; } set { this[nameof(Namespace)] = value; } }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object NativeString { get { return this[nameof(NativeString)]; } set { this[nameof(NativeString)] = value; } }
        public Object LocalizedStrings { get { return this[nameof(LocalizedStrings)]; } set { this[nameof(LocalizedStrings)] = value; } }
        public bool bIsMinimalPatch { get { return this[nameof(bIsMinimalPatch)].Flag; } set { this[nameof(bIsMinimalPatch)].Flag = value; } }
        public Object CachedText { get { return this[nameof(CachedText)]; } set { this[nameof(CachedText)] = value; } }
    }
    public enum ELocalizedTextSourceCategory : int
    {
        Game = 0,
        Engine = 1,
        Editor = 2,
        ELocalizedTextSourceCategory_MAX = 3,
    }
    public class PrimaryAssetId : Object
    {
        public PrimaryAssetId(nint addr) : base(addr) { }
        public PrimaryAssetType PrimaryAssetType { get { return this[nameof(PrimaryAssetType)].As<PrimaryAssetType>(); } set { this["PrimaryAssetType"] = value; } }
        public Object PrimaryAssetName { get { return this[nameof(PrimaryAssetName)]; } set { this[nameof(PrimaryAssetName)] = value; } }
    }
    public class PrimaryAssetType : Object
    {
        public PrimaryAssetType(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class QualifiedFrameTime : Object
    {
        public QualifiedFrameTime(nint addr) : base(addr) { }
        public FrameTime Time { get { return this[nameof(Time)].As<FrameTime>(); } set { this["Time"] = value; } }
        public FrameRate Rate { get { return this[nameof(Rate)].As<FrameRate>(); } set { this["Rate"] = value; } }
    }
    public class Quat4d : Object
    {
        public Quat4d(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class Quat4f : Object
    {
        public Quat4f(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public class RandomStream : Object
    {
        public RandomStream(nint addr) : base(addr) { }
        public int InitialSeed { get { return this[nameof(InitialSeed)].GetValue<int>(); } set { this[nameof(InitialSeed)].SetValue<int>(value); } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
    }
    public class Rotator : Object
    {
        public Rotator(nint addr) : base(addr) { }
        public double Pitch { get { return this[nameof(Pitch)].GetValue<double>(); } set { this[nameof(Pitch)].SetValue<double>(value); } }
        public double Yaw { get { return this[nameof(Yaw)].GetValue<double>(); } set { this[nameof(Yaw)].SetValue<double>(value); } }
        public double Roll { get { return this[nameof(Roll)].GetValue<double>(); } set { this[nameof(Roll)].SetValue<double>(value); } }
    }
    public class Rotator3d : Object
    {
        public Rotator3d(nint addr) : base(addr) { }
        public double Pitch { get { return this[nameof(Pitch)].GetValue<double>(); } set { this[nameof(Pitch)].SetValue<double>(value); } }
        public double Yaw { get { return this[nameof(Yaw)].GetValue<double>(); } set { this[nameof(Yaw)].SetValue<double>(value); } }
        public double Roll { get { return this[nameof(Roll)].GetValue<double>(); } set { this[nameof(Roll)].SetValue<double>(value); } }
    }
    public class Rotator3f : Object
    {
        public Rotator3f(nint addr) : base(addr) { }
        public float Pitch { get { return this[nameof(Pitch)].GetValue<float>(); } set { this[nameof(Pitch)].SetValue<float>(value); } }
        public float Yaw { get { return this[nameof(Yaw)].GetValue<float>(); } set { this[nameof(Yaw)].SetValue<float>(value); } }
        public float Roll { get { return this[nameof(Roll)].GetValue<float>(); } set { this[nameof(Roll)].SetValue<float>(value); } }
    }
    public class SoftClassPath : SoftObjectPath
    {
        public SoftClassPath(nint addr) : base(addr) { }
    }
    public class TemplateString : Object
    {
        public TemplateString(nint addr) : base(addr) { }
        public Object Template { get { return this[nameof(Template)]; } set { this[nameof(Template)] = value; } }
    }
    public class TestUninitializedScriptStructMembersTest : Object
    {
        public TestUninitializedScriptStructMembersTest(nint addr) : base(addr) { }
        public Object UninitializedObjectReference { get { return this[nameof(UninitializedObjectReference)].As<Object>(); } set { this["UninitializedObjectReference"] = value; } }
        public Object InitializedObjectReference { get { return this[nameof(InitializedObjectReference)].As<Object>(); } set { this["InitializedObjectReference"] = value; } }
        public float UnusedValue { get { return this[nameof(UnusedValue)].GetValue<float>(); } set { this[nameof(UnusedValue)].SetValue<float>(value); } }
    }
    public class Timecode : Object
    {
        public Timecode(nint addr) : base(addr) { }
        public int Hours { get { return this[nameof(Hours)].GetValue<int>(); } set { this[nameof(Hours)].SetValue<int>(value); } }
        public int Minutes { get { return this[nameof(Minutes)].GetValue<int>(); } set { this[nameof(Minutes)].SetValue<int>(value); } }
        public int Seconds { get { return this[nameof(Seconds)].GetValue<int>(); } set { this[nameof(Seconds)].SetValue<int>(value); } }
        public int Frames { get { return this[nameof(Frames)].GetValue<int>(); } set { this[nameof(Frames)].SetValue<int>(value); } }
        public bool bDropFrameFormat { get { return this[nameof(bDropFrameFormat)].Flag; } set { this[nameof(bDropFrameFormat)].Flag = value; } }
    }
    public class Timespan : Object
    {
        public Timespan(nint addr) : base(addr) { }
    }
    public class Transform : Object
    {
        public Transform(nint addr) : base(addr) { }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public Vector Scale3D { get { return this[nameof(Scale3D)].As<Vector>(); } set { this["Scale3D"] = value; } }
    }
    public class Transform3d : Object
    {
        public Transform3d(nint addr) : base(addr) { }
        public Quat4d Rotation { get { return this[nameof(Rotation)].As<Quat4d>(); } set { this["Rotation"] = value; } }
        public Vector3d Translation { get { return this[nameof(Translation)].As<Vector3d>(); } set { this["Translation"] = value; } }
        public Vector3d Scale3D { get { return this[nameof(Scale3D)].As<Vector3d>(); } set { this["Scale3D"] = value; } }
    }
    public class Transform3f : Object
    {
        public Transform3f(nint addr) : base(addr) { }
        public Quat4f Rotation { get { return this[nameof(Rotation)].As<Quat4f>(); } set { this["Rotation"] = value; } }
        public Vector3f Translation { get { return this[nameof(Translation)].As<Vector3f>(); } set { this["Translation"] = value; } }
        public Vector3f Scale3D { get { return this[nameof(Scale3D)].As<Vector3f>(); } set { this["Scale3D"] = value; } }
    }
    public class Uint32Point : Object
    {
        public Uint32Point(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class Uint32Vector : Object
    {
        public Uint32Vector(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
        public uint Z { get { return this[nameof(Z)].GetValue<uint>(); } set { this[nameof(Z)].SetValue<uint>(value); } }
    }
    public class Uint32Vector2 : Object
    {
        public Uint32Vector2(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
    }
    public class Uint32Vector4 : Object
    {
        public Uint32Vector4(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
        public uint Z { get { return this[nameof(Z)].GetValue<uint>(); } set { this[nameof(Z)].SetValue<uint>(value); } }
        public uint W { get { return this[nameof(W)].GetValue<uint>(); } set { this[nameof(W)].SetValue<uint>(value); } }
    }
    public class Uint64Point : Object
    {
        public Uint64Point(nint addr) : base(addr) { }
        public long X { get { return this[nameof(X)].GetValue<long>(); } set { this[nameof(X)].SetValue<long>(value); } }
        public long Y { get { return this[nameof(Y)].GetValue<long>(); } set { this[nameof(Y)].SetValue<long>(value); } }
    }
    public class Uint64Vector : Object
    {
        public Uint64Vector(nint addr) : base(addr) { }
        public ulong X { get { return this[nameof(X)].GetValue<ulong>(); } set { this[nameof(X)].SetValue<ulong>(value); } }
        public ulong Y { get { return this[nameof(Y)].GetValue<ulong>(); } set { this[nameof(Y)].SetValue<ulong>(value); } }
        public ulong Z { get { return this[nameof(Z)].GetValue<ulong>(); } set { this[nameof(Z)].SetValue<ulong>(value); } }
    }
    public class Uint64Vector2 : Object
    {
        public Uint64Vector2(nint addr) : base(addr) { }
        public ulong X { get { return this[nameof(X)].GetValue<ulong>(); } set { this[nameof(X)].SetValue<ulong>(value); } }
        public ulong Y { get { return this[nameof(Y)].GetValue<ulong>(); } set { this[nameof(Y)].SetValue<ulong>(value); } }
    }
    public class Uint64Vector4 : Object
    {
        public Uint64Vector4(nint addr) : base(addr) { }
        public ulong X { get { return this[nameof(X)].GetValue<ulong>(); } set { this[nameof(X)].SetValue<ulong>(value); } }
        public ulong Y { get { return this[nameof(Y)].GetValue<ulong>(); } set { this[nameof(Y)].SetValue<ulong>(value); } }
        public ulong Z { get { return this[nameof(Z)].GetValue<ulong>(); } set { this[nameof(Z)].SetValue<ulong>(value); } }
        public ulong W { get { return this[nameof(W)].GetValue<ulong>(); } set { this[nameof(W)].SetValue<ulong>(value); } }
    }
    public class UintPoint : Object
    {
        public UintPoint(nint addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class UintVector : Object
    {
        public UintVector(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
        public uint Z { get { return this[nameof(Z)].GetValue<uint>(); } set { this[nameof(Z)].SetValue<uint>(value); } }
    }
    public class UintVector2 : Object
    {
        public UintVector2(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
    }
    public class UintVector4 : Object
    {
        public UintVector4(nint addr) : base(addr) { }
        public uint X { get { return this[nameof(X)].GetValue<uint>(); } set { this[nameof(X)].SetValue<uint>(value); } }
        public uint Y { get { return this[nameof(Y)].GetValue<uint>(); } set { this[nameof(Y)].SetValue<uint>(value); } }
        public uint Z { get { return this[nameof(Z)].GetValue<uint>(); } set { this[nameof(Z)].SetValue<uint>(value); } }
        public uint W { get { return this[nameof(W)].GetValue<uint>(); } set { this[nameof(W)].SetValue<uint>(value); } }
    }
    public class Vector4 : Object
    {
        public Vector4(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class Vector4d : Object
    {
        public Vector4d(nint addr) : base(addr) { }
        public double X { get { return this[nameof(X)].GetValue<double>(); } set { this[nameof(X)].SetValue<double>(value); } }
        public double Y { get { return this[nameof(Y)].GetValue<double>(); } set { this[nameof(Y)].SetValue<double>(value); } }
        public double Z { get { return this[nameof(Z)].GetValue<double>(); } set { this[nameof(Z)].SetValue<double>(value); } }
        public double W { get { return this[nameof(W)].GetValue<double>(); } set { this[nameof(W)].SetValue<double>(value); } }
    }
    public class Vector4f : Object
    {
        public Vector4f(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public enum EMouseCursor : int
    {
        None = 0,
        Default = 1,
        TextEditBeam = 2,
        ResizeLeftRight = 3,
        ResizeUpDown = 4,
        ResizeSouthEast = 5,
        ResizeSouthWest = 6,
        CardinalCross = 7,
        Crosshairs = 8,
        Hand = 9,
        GrabHand = 10,
        GrabHandClosed = 11,
        SlashedCircle = 12,
        EyeDropper = 13,
        EMouseCursor_MAX = 14,
    }
    public enum ELifetimeCondition : int
    {
        COND_None = 0,
        COND_InitialOnly = 1,
        COND_OwnerOnly = 2,
        COND_SkipOwner = 3,
        COND_SimulatedOnly = 4,
        COND_AutonomousOnly = 5,
        COND_SimulatedOrPhysics = 6,
        COND_InitialOrOwner = 7,
        COND_Custom = 8,
        COND_ReplayOrOwner = 9,
        COND_ReplayOnly = 10,
        COND_SimulatedOnlyNoReplay = 11,
        COND_SimulatedOrPhysicsNoReplay = 12,
        COND_SkipReplay = 13,
        COND_Never = 15,
        COND_NetGroup = 16,
        COND_Max = 17,
    }
    public enum ESearchCase : int
    {
        CaseSensitive = 0,
        IgnoreCase = 1,
        ESearchCase_MAX = 2,
    }
    public enum ESearchDir : int
    {
        FromStart = 0,
        FromEnd = 1,
        ESearchDir_MAX = 2,
    }
    public enum ELogTimes : int
    {
        None = 0,
        UTC = 1,
        SinceGStartTime = 2,
        Local = 3,
        ELogTimes_MAX = 4,
    }
    public enum EAxis : int
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
        EAxis_MAX = 4,
    }
    public enum EAxisList : int
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        Screen = 8,
        XY = 3,
        XZ = 5,
        YZ = 6,
        XYZ = 7,
        All = 15,
        ZRotation = 6,
        Rotate2D = 8,
        EAxisList_MAX = 16,
    }
    public enum EPixelFormat : int
    {
        PF_Unknown = 0,
        PF_A32B32G32R32F = 1,
        PF_B8G8R8A8 = 2,
        PF_G8 = 3,
        PF_G16 = 4,
        PF_DXT1 = 5,
        PF_DXT3 = 6,
        PF_DXT5 = 7,
        PF_UYVY = 8,
        PF_FloatRGB = 9,
        PF_FloatRGBA = 10,
        PF_DepthStencil = 11,
        PF_ShadowDepth = 12,
        PF_R32_FLOAT = 13,
        PF_G16R16 = 14,
        PF_G16R16F = 15,
        PF_G16R16F_FILTER = 16,
        PF_G32R32F = 17,
        PF_A2B10G10R10 = 18,
        PF_A16B16G16R16 = 19,
        PF_D24 = 20,
        PF_R16F = 21,
        PF_R16F_FILTER = 22,
        PF_BC5 = 23,
        PF_V8U8 = 24,
        PF_A1 = 25,
        PF_FloatR11G11B10 = 26,
        PF_A8 = 27,
        PF_R32_UINT = 28,
        PF_R32_SINT = 29,
        PF_PVRTC2 = 30,
        PF_PVRTC4 = 31,
        PF_R16_UINT = 32,
        PF_R16_SINT = 33,
        PF_R16G16B16A16_UINT = 34,
        PF_R16G16B16A16_SINT = 35,
        PF_R5G6B5_UNORM = 36,
        PF_R8G8B8A8 = 37,
        PF_A8R8G8B8 = 38,
        PF_BC4 = 39,
        PF_R8G8 = 40,
        PF_ATC_RGB = 41,
        PF_ATC_RGBA_E = 42,
        PF_ATC_RGBA_I = 43,
        PF_X24_G8 = 44,
        PF_ETC1 = 45,
        PF_ETC2_RGB = 46,
        PF_ETC2_RGBA = 47,
        PF_R32G32B32A32_UINT = 48,
        PF_R16G16_UINT = 49,
        PF_ASTC_4x4 = 50,
        PF_ASTC_6x6 = 51,
        PF_ASTC_8x8 = 52,
        PF_ASTC_10x10 = 53,
        PF_ASTC_12x12 = 54,
        PF_BC6H = 55,
        PF_BC7 = 56,
        PF_R8_UINT = 57,
        PF_L8 = 58,
        PF_XGXR8 = 59,
        PF_R8G8B8A8_UINT = 60,
        PF_R8G8B8A8_SNORM = 61,
        PF_R16G16B16A16_UNORM = 62,
        PF_R16G16B16A16_SNORM = 63,
        PF_PLATFORM_HDR_1 = 64,
        PF_PLATFORM_HDR_2 = 65,
        PF_PLATFORM_HDR_3 = 66,
        PF_NV12 = 67,
        PF_R32G32_UINT = 68,
        PF_ETC2_R11_EAC = 69,
        PF_ETC2_RG11_EAC = 70,
        PF_R8 = 71,
        PF_B5G5R5A1_UNORM = 72,
        PF_G16R16_SNORM = 78,
        PF_R8G8_UINT = 79,
        PF_R32G32B32_UINT = 80,
        PF_R32G32B32_SINT = 81,
        PF_R32G32B32F = 82,
        PF_R8_SINT = 83,
        PF_R64_UINT = 84,
        PF_R9G9B9EXP5 = 85,
        PF_MAX = 86,
    }
    public enum EUnit : int
    {
        Micrometers = 0,
        Millimeters = 1,
        Centimeters = 2,
        Meters = 3,
        Kilometers = 4,
        Inches = 5,
        Feet = 6,
        Yards = 7,
        Miles = 8,
        Lightyears = 9,
        Degrees = 10,
        Radians = 11,
        CentimetersPerSecond = 12,
        MetersPerSecond = 13,
        KilometersPerHour = 14,
        MilesPerHour = 15,
        Celsius = 16,
        Farenheit = 17,
        Kelvin = 18,
        Micrograms = 19,
        Milligrams = 20,
        Grams = 21,
        Kilograms = 22,
        MetricTons = 23,
        Ounces = 24,
        Pounds = 25,
        Stones = 26,
        Newtons = 27,
        PoundsForce = 28,
        KilogramsForce = 29,
        Hertz = 30,
        Kilohertz = 31,
        Megahertz = 32,
        Gigahertz = 33,
        RevolutionsPerMinute = 34,
        Bytes = 35,
        Kilobytes = 36,
        Megabytes = 37,
        Gigabytes = 38,
        Terabytes = 39,
        Lumens = 40,
        Milliseconds = 46,
        Seconds = 47,
        Minutes = 48,
        Hours = 49,
        Days = 50,
        Months = 51,
        Years = 52,
        Multiplier = 55,
        Percentage = 54,
        Unspecified = 56,
        EUnit_MAX = 57,
    }
    public enum EPropertyAccessChangeNotifyMode : int
    {
        Default = 0,
        Never = 1,
        Always = 2,
        EPropertyAccessChangeNotifyMode_MAX = 3,
    }
    public enum EAppReturnType : int
    {
        No = 0,
        Yes = 1,
        YesAll = 2,
        NoAll = 3,
        Cancel = 4,
        Ok = 5,
        Retry = 6,
        Continue = 7,
        EAppReturnType_MAX = 8,
    }
    public enum EAppMsgType : int
    {
        Ok = 0,
        YesNo = 1,
        OkCancel = 2,
        YesNoCancel = 3,
        CancelRetryContinue = 4,
        YesNoYesAllNoAll = 5,
        YesNoYesAllNoAllCancel = 6,
        YesNoYesAll = 7,
        EAppMsgType_MAX = 8,
    }
    public enum EDataValidationResult : int
    {
        Invalid = 0,
        Valid = 1,
        NotValidated = 2,
        EDataValidationResult_MAX = 3,
    }
    public class Default__Class : Object
    {
        public Default__Class(nint addr) : base(addr) { }
    }
    public enum Default__EnumProperty : int
    {
    }
    public class Default__ClassProperty : Object
    {
        public Default__ClassProperty(nint addr) : base(addr) { }
    }
}
