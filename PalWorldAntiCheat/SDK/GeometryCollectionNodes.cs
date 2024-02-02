using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DataflowCoreSDK;
using SDK.Script.ChaosSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryCollectionNodesSDK
{
    public enum EMakeBoxDataTypeEnum : int
    {
        Dataflow_MakeBox_DataType_MinMax = 0,
        Dataflow_MakeBox_DataType_CenterSize = 1,
        Dataflow_Max = 2,
    }
    public enum EFloatToIntFunctionEnum : int
    {
        Dataflow_FloatToInt_Function_Floor = 0,
        Dataflow_FloatToInt_Function_Ceil = 1,
        Dataflow_FloatToInt_Function_Round = 2,
        Dataflow_FloatToInt_Function_Truncate = 3,
        Dataflow_Max = 4,
    }
    public enum EMathConstantsEnum : int
    {
        Dataflow_MathConstants_Pi = 0,
        Dataflow_MathConstants_HalfPi = 1,
        Dataflow_MathConstants_TwoPi = 2,
        Dataflow_MathConstants_FourPi = 3,
        Dataflow_MathConstants_InvPi = 4,
        Dataflow_MathConstants_InvTwoPi = 5,
        Dataflow_MathConstants_Sqrt2 = 6,
        Dataflow_MathConstants_InvSqrt2 = 7,
        Dataflow_MathConstants_Sqrt3 = 8,
        Dataflow_MathConstants_InvSqrt3 = 9,
        Dataflow_FloatToInt_Function_E = 10,
        Dataflow_FloatToInt_Function_Gamma = 11,
        Dataflow_FloatToInt_Function_GoldenRatio = 12,
        Dataflow_FloatToInt_Function_ZeroTolerance = 13,
        Dataflow_Max = 14,
    }
    public class CloseGeometryOnCollectionDataflowNode : DataflowNode
    {
        public CloseGeometryOnCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class SkeletalMeshToCollectionDataflowNode : DataflowNode
    {
        public SkeletalMeshToCollectionDataflowNode(nint addr) : base(addr) { }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class GenerateTetrahedralCollectionDataflowNodes : DataflowNode
    {
        public GenerateTetrahedralCollectionDataflowNodes(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class GetCollectionAssetDataflowNode : DataflowNode
    {
        public GetCollectionAssetDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Output { get { return this[nameof(Output)].As<ManagedArrayCollection>(); } set { this["Output"] = value; } }
    }
    public class ExampleCollectionEditDataflowNode : DataflowNode
    {
        public ExampleCollectionEditDataflowNode(nint addr) : base(addr) { }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class SetCollectionAssetDataflowNode : DataflowNode
    {
        public SetCollectionAssetDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class ResetGeometryCollectionDataflowNode : DataflowNode
    {
        public ResetGeometryCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class PrintStringDataflowNode : DataflowNode
    {
        public PrintStringDataflowNode(nint addr) : base(addr) { }
        public bool PrintToScreen { get { return this[nameof(PrintToScreen)].Flag; } set { this[nameof(PrintToScreen)].Flag = value; } }
        public bool PrintToLog { get { return this[nameof(PrintToLog)].Flag; } set { this[nameof(PrintToLog)].Flag = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class LogStringDataflowNode : DataflowNode
    {
        public LogStringDataflowNode(nint addr) : base(addr) { }
        public bool PrintToLog { get { return this[nameof(PrintToLog)].Flag; } set { this[nameof(PrintToLog)].Flag = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class MakeLiteralStringDataflowNode : DataflowNode
    {
        public MakeLiteralStringDataflowNode(nint addr) : base(addr) { }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class BoundingBoxDataflowNode : DataflowNode
    {
        public BoundingBoxDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
    }
    public class ExpandBoundingBoxDataflowNode : DataflowNode
    {
        public ExpandBoundingBoxDataflowNode(nint addr) : base(addr) { }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector HalfExtents { get { return this[nameof(HalfExtents)].As<Vector>(); } set { this["HalfExtents"] = value; } }
        public float Volume { get { return this[nameof(Volume)].GetValue<float>(); } set { this[nameof(Volume)].SetValue<float>(value); } }
    }
    public class VectorToStringDataflowNode : DataflowNode
    {
        public VectorToStringDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class FloatToStringDataflowNode : DataflowNode
    {
        public FloatToStringDataflowNode(nint addr) : base(addr) { }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class MakePointsDataflowNode : DataflowNode
    {
        public MakePointsDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> Point { get { return new Array<Vector>(this[nameof(Point)].Address); } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class MakeBoxDataflowNode : DataflowNode
    {
        public MakeBoxDataflowNode(nint addr) : base(addr) { }
        public EMakeBoxDataTypeEnum DataType { get { return (EMakeBoxDataTypeEnum)this[nameof(DataType)].GetValue<int>(); } set { this[nameof(DataType)].SetValue<int>((int)value); } }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Size { get { return this[nameof(Size)].As<Vector>(); } set { this["Size"] = value; } }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
    }
    public class UniformScatterPointsDataflowNode : DataflowNode
    {
        public UniformScatterPointsDataflowNode(nint addr) : base(addr) { }
        public int MinNumberOfPoints { get { return this[nameof(MinNumberOfPoints)].GetValue<int>(); } set { this[nameof(MinNumberOfPoints)].SetValue<int>(value); } }
        public int MaxNumberOfPoints { get { return this[nameof(MaxNumberOfPoints)].GetValue<int>(); } set { this[nameof(MaxNumberOfPoints)].SetValue<int>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class RadialScatterPointsDataflowNode : DataflowNode
    {
        public RadialScatterPointsDataflowNode(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int AngularSteps { get { return this[nameof(AngularSteps)].GetValue<int>(); } set { this[nameof(AngularSteps)].SetValue<int>(value); } }
        public int RadialSteps { get { return this[nameof(RadialSteps)].GetValue<int>(); } set { this[nameof(RadialSteps)].SetValue<int>(value); } }
        public float AngleOffset { get { return this[nameof(AngleOffset)].GetValue<float>(); } set { this[nameof(AngleOffset)].SetValue<float>(value); } }
        public float Variability { get { return this[nameof(Variability)].GetValue<float>(); } set { this[nameof(Variability)].SetValue<float>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class MakeLiteralFloatDataflowNode : DataflowNode
    {
        public MakeLiteralFloatDataflowNode(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
    }
    public class MakeLiteralIntDataflowNode : DataflowNode
    {
        public MakeLiteralIntDataflowNode(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
    }
    public class MakeLiteralBoolDataflowNode : DataflowNode
    {
        public MakeLiteralBoolDataflowNode(nint addr) : base(addr) { }
        public bool Value { get { return this[nameof(Value)].Flag; } set { this[nameof(Value)].Flag = value; } }
        //public bool bool { get { return this[nameof(bool)].Flag; } set { this[nameof(bool)].Flag = value; } }
    }
    public class MakeLiteralVectorDataflowNode : DataflowNode
    {
        public MakeLiteralVectorDataflowNode(nint addr) : base(addr) { }
        public Vector Value { get { return this[nameof(Value)].As<Vector>(); } set { this["Value"] = value; } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class IntToStringDataflowNode : DataflowNode
    {
        public IntToStringDataflowNode(nint addr) : base(addr) { }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class BoolToStringDataflowNode : DataflowNode
    {
        public BoolToStringDataflowNode(nint addr) : base(addr) { }
        //public bool bool { get { return this[nameof(bool)].Flag; } set { this[nameof(bool)].Flag = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class ExpandVectorDataflowNode : DataflowNode
    {
        public ExpandVectorDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
    }
    public class IntToFloatDataflowNode : DataflowNode
    {
        public IntToFloatDataflowNode(nint addr) : base(addr) { }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
    }
    public class VoronoiFractureDataflowNode : DataflowNode
    {
        public VoronoiFractureDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float ChanceToFracture { get { return this[nameof(ChanceToFracture)].GetValue<float>(); } set { this[nameof(ChanceToFracture)].SetValue<float>(value); } }
        public bool GroupFracture { get { return this[nameof(GroupFracture)].Flag; } set { this[nameof(GroupFracture)].Flag = value; } }
        public float Grout { get { return this[nameof(Grout)].GetValue<float>(); } set { this[nameof(Grout)].SetValue<float>(value); } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Persistence { get { return this[nameof(Persistence)].GetValue<float>(); } set { this[nameof(Persistence)].SetValue<float>(value); } }
        public float Lacunarity { get { return this[nameof(Lacunarity)].GetValue<float>(); } set { this[nameof(Lacunarity)].SetValue<float>(value); } }
        public int OctaveNumber { get { return this[nameof(OctaveNumber)].GetValue<int>(); } set { this[nameof(OctaveNumber)].SetValue<int>(value); } }
        public float PointSpacing { get { return this[nameof(PointSpacing)].GetValue<float>(); } set { this[nameof(PointSpacing)].SetValue<float>(value); } }
        public bool AddSamplesForCollision { get { return this[nameof(AddSamplesForCollision)].Flag; } set { this[nameof(AddSamplesForCollision)].Flag = value; } }
        public float CollisionSampleSpacing { get { return this[nameof(CollisionSampleSpacing)].GetValue<float>(); } set { this[nameof(CollisionSampleSpacing)].SetValue<float>(value); } }
    }
    public class StringAppendDataflowNode : DataflowNode
    {
        public StringAppendDataflowNode(nint addr) : base(addr) { }
        public Object String1 { get { return this[nameof(String1)]; } set { this[nameof(String1)] = value; } }
        public Object String2 { get { return this[nameof(String2)]; } set { this[nameof(String2)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class RandomFloatDataflowNode : DataflowNode
    {
        public RandomFloatDataflowNode(nint addr) : base(addr) { }
        public bool Deterministic { get { return this[nameof(Deterministic)].Flag; } set { this[nameof(Deterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
    }
    public class RandomFloatInRangeDataflowNode : DataflowNode
    {
        public RandomFloatInRangeDataflowNode(nint addr) : base(addr) { }
        public bool Deterministic { get { return this[nameof(Deterministic)].Flag; } set { this[nameof(Deterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
    }
    public class RandomUnitVectorDataflowNode : DataflowNode
    {
        public RandomUnitVectorDataflowNode(nint addr) : base(addr) { }
        public bool Deterministic { get { return this[nameof(Deterministic)].Flag; } set { this[nameof(Deterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class RandomUnitVectorInConeDataflowNode : DataflowNode
    {
        public RandomUnitVectorInConeDataflowNode(nint addr) : base(addr) { }
        public bool Deterministic { get { return this[nameof(Deterministic)].Flag; } set { this[nameof(Deterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Vector ConeDirection { get { return this[nameof(ConeDirection)].As<Vector>(); } set { this["ConeDirection"] = value; } }
        public float ConeHalfAngle { get { return this[nameof(ConeHalfAngle)].GetValue<float>(); } set { this[nameof(ConeHalfAngle)].SetValue<float>(value); } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class RadiansToDegreesDataflowNode : DataflowNode
    {
        public RadiansToDegreesDataflowNode(nint addr) : base(addr) { }
        public float Radians { get { return this[nameof(Radians)].GetValue<float>(); } set { this[nameof(Radians)].SetValue<float>(value); } }
        public float Degrees { get { return this[nameof(Degrees)].GetValue<float>(); } set { this[nameof(Degrees)].SetValue<float>(value); } }
    }
    public class DegreesToRadiansDataflowNode : DataflowNode
    {
        public DegreesToRadiansDataflowNode(nint addr) : base(addr) { }
        public float Degrees { get { return this[nameof(Degrees)].GetValue<float>(); } set { this[nameof(Degrees)].SetValue<float>(value); } }
        public float Radians { get { return this[nameof(Radians)].GetValue<float>(); } set { this[nameof(Radians)].SetValue<float>(value); } }
    }
    public class ExplodedViewDataflowNode : DataflowNode
    {
        public ExplodedViewDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float UniformScale { get { return this[nameof(UniformScale)].GetValue<float>(); } set { this[nameof(UniformScale)].SetValue<float>(value); } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
    }
    public class CreateNonOverlappingConvexHullsDataflowNode : DataflowNode
    {
        public CreateNonOverlappingConvexHullsDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float CanRemoveFraction { get { return this[nameof(CanRemoveFraction)].GetValue<float>(); } set { this[nameof(CanRemoveFraction)].SetValue<float>(value); } }
        public float CanExceedFraction { get { return this[nameof(CanExceedFraction)].GetValue<float>(); } set { this[nameof(CanExceedFraction)].SetValue<float>(value); } }
        public float SimplificationDistanceThreshold { get { return this[nameof(SimplificationDistanceThreshold)].GetValue<float>(); } set { this[nameof(SimplificationDistanceThreshold)].SetValue<float>(value); } }
    }
    public class PlaneCutterDataflowNode : DataflowNode
    {
        public PlaneCutterDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public int NumPlanes { get { return this[nameof(NumPlanes)].GetValue<int>(); } set { this[nameof(NumPlanes)].SetValue<int>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float Grout { get { return this[nameof(Grout)].GetValue<float>(); } set { this[nameof(Grout)].SetValue<float>(value); } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Persistence { get { return this[nameof(Persistence)].GetValue<float>(); } set { this[nameof(Persistence)].SetValue<float>(value); } }
        public float Lacunarity { get { return this[nameof(Lacunarity)].GetValue<float>(); } set { this[nameof(Lacunarity)].SetValue<float>(value); } }
        public int OctaveNumber { get { return this[nameof(OctaveNumber)].GetValue<int>(); } set { this[nameof(OctaveNumber)].SetValue<int>(value); } }
        public float PointSpacing { get { return this[nameof(PointSpacing)].GetValue<float>(); } set { this[nameof(PointSpacing)].SetValue<float>(value); } }
        public bool AddSamplesForCollision { get { return this[nameof(AddSamplesForCollision)].Flag; } set { this[nameof(AddSamplesForCollision)].Flag = value; } }
        public float CollisionSampleSpacing { get { return this[nameof(CollisionSampleSpacing)].GetValue<float>(); } set { this[nameof(CollisionSampleSpacing)].SetValue<float>(value); } }
    }
    public class HashStringDataflowNode : DataflowNode
    {
        public HashStringDataflowNode(nint addr) : base(addr) { }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public int Hash { get { return this[nameof(Hash)].GetValue<int>(); } set { this[nameof(Hash)].SetValue<int>(value); } }
    }
    public class HashVectorDataflowNode : DataflowNode
    {
        public HashVectorDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public int Hash { get { return this[nameof(Hash)].GetValue<int>(); } set { this[nameof(Hash)].SetValue<int>(value); } }
    }
    public class FloatToIntDataflowNode : DataflowNode
    {
        public FloatToIntDataflowNode(nint addr) : base(addr) { }
        public EFloatToIntFunctionEnum Function { get { return (EFloatToIntFunctionEnum)this[nameof(Function)].GetValue<int>(); } set { this[nameof(Function)].SetValue<int>((int)value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
    }
    public class MathConstantsDataflowNode : DataflowNode
    {
        public MathConstantsDataflowNode(nint addr) : base(addr) { }
        public EMathConstantsEnum Constant { get { return (EMathConstantsEnum)this[nameof(Constant)].GetValue<int>(); } set { this[nameof(Constant)].SetValue<int>((int)value); } }
        //public float float { get { return this[nameof(float)].GetValue<float>(); } set { this[nameof(float)].SetValue<float>(value); } }
    }
}
