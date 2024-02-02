using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.FieldSystemEngineSDK
{
    public class FieldSystemActor : Actor
    {
        public FieldSystemActor(nint addr) : base(addr) { }
        public FieldSystemComponent FieldSystemComponent { get { return this[nameof(FieldSystemComponent)].As<FieldSystemComponent>(); } set { this["FieldSystemComponent"] = value; } }
    }
    public class FieldSystem : Object
    {
        public FieldSystem(nint addr) : base(addr) { }
    }
    public class FieldSystemComponent : PrimitiveComponent
    {
        public FieldSystemComponent(nint addr) : base(addr) { }
        public FieldSystem FieldSystem { get { return this[nameof(FieldSystem)].As<FieldSystem>(); } set { this["FieldSystem"] = value; } }
        public bool bIsWorldField { get { return this[nameof(bIsWorldField)].Flag; } set { this[nameof(bIsWorldField)].Flag = value; } }
        public bool bIsChaosField { get { return this[nameof(bIsChaosField)].Flag; } set { this[nameof(bIsChaosField)].Flag = value; } }
        public Array<Object> SupportedSolvers { get { return new Array<Object>(this[nameof(SupportedSolvers)].Address); } }
        public FieldObjectCommands ConstructionCommands { get { return this[nameof(ConstructionCommands)].As<FieldObjectCommands>(); } set { this["ConstructionCommands"] = value; } }
        public FieldObjectCommands BufferCommands { get { return this[nameof(BufferCommands)].As<FieldObjectCommands>(); } set { this["BufferCommands"] = value; } }
        public void ResetFieldSystem() { Invoke(nameof(ResetFieldSystem)); }
        public void RemovePersistentFields() { Invoke(nameof(RemovePersistentFields)); }
        public void ApplyUniformVectorFalloffForce(bool Enabled, Vector Position, Vector Direction, float Radius, float Magnitude) { Invoke(nameof(ApplyUniformVectorFalloffForce), Enabled, Position, Direction, Radius, Magnitude); }
        public void ApplyStrainField(bool Enabled, Vector Position, float Radius, float Magnitude, int Iterations) { Invoke(nameof(ApplyStrainField), Enabled, Position, Radius, Magnitude, Iterations); }
        public void ApplyStayDynamicField(bool Enabled, Vector Position, float Radius) { Invoke(nameof(ApplyStayDynamicField), Enabled, Position, Radius); }
        public void ApplyRadialVectorFalloffForce(bool Enabled, Vector Position, float Radius, float Magnitude) { Invoke(nameof(ApplyRadialVectorFalloffForce), Enabled, Position, Radius, Magnitude); }
        public void ApplyRadialForce(bool Enabled, Vector Position, float Magnitude) { Invoke(nameof(ApplyRadialForce), Enabled, Position, Magnitude); }
        public void ApplyPhysicsField(bool Enabled, byte Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(ApplyPhysicsField), Enabled, Target, MetaData, Field); }
        public void ApplyLinearForce(bool Enabled, Vector Direction, float Magnitude) { Invoke(nameof(ApplyLinearForce), Enabled, Direction, Magnitude); }
        public void AddPersistentField(bool Enabled, byte Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(AddPersistentField), Enabled, Target, MetaData, Field); }
        public void AddFieldCommand(bool Enabled, byte Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(AddFieldCommand), Enabled, Target, MetaData, Field); }
    }
    public class FieldSystemMetaData : ActorComponent
    {
        public FieldSystemMetaData(nint addr) : base(addr) { }
    }
    public class FieldSystemMetaDataIteration : FieldSystemMetaData
    {
        public FieldSystemMetaDataIteration(nint addr) : base(addr) { }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public FieldSystemMetaDataIteration SetMetaDataIteration(int Iterations) { return Invoke<FieldSystemMetaDataIteration>(nameof(SetMetaDataIteration), Iterations); }
    }
    public class FieldSystemMetaDataProcessingResolution : FieldSystemMetaData
    {
        public FieldSystemMetaDataProcessingResolution(nint addr) : base(addr) { }
        public byte ResolutionType { get { return this[nameof(ResolutionType)].GetValue<byte>(); } set { this[nameof(ResolutionType)].SetValue<byte>(value); } }
        public FieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(byte ResolutionType) { return Invoke<FieldSystemMetaDataProcessingResolution>(nameof(SetMetaDataaProcessingResolutionType), ResolutionType); }
    }
    public class FieldSystemMetaDataFilter : FieldSystemMetaData
    {
        public FieldSystemMetaDataFilter(nint addr) : base(addr) { }
        public byte FilterType { get { return this[nameof(FilterType)].GetValue<byte>(); } set { this[nameof(FilterType)].SetValue<byte>(value); } }
        public byte ObjectType { get { return this[nameof(ObjectType)].GetValue<byte>(); } set { this[nameof(ObjectType)].SetValue<byte>(value); } }
        public byte PositionType { get { return this[nameof(PositionType)].GetValue<byte>(); } set { this[nameof(PositionType)].SetValue<byte>(value); } }
        public FieldSystemMetaDataFilter SetMetaDataFilterType(byte FilterType, byte ObjectType, byte PositionType) { return Invoke<FieldSystemMetaDataFilter>(nameof(SetMetaDataFilterType), FilterType, ObjectType, PositionType); }
    }
    public class FieldNodeBase : ActorComponent
    {
        public FieldNodeBase(nint addr) : base(addr) { }
    }
    public class FieldNodeInt : FieldNodeBase
    {
        public FieldNodeInt(nint addr) : base(addr) { }
    }
    public class FieldNodeFloat : FieldNodeBase
    {
        public FieldNodeFloat(nint addr) : base(addr) { }
    }
    public class FieldNodeVector : FieldNodeBase
    {
        public FieldNodeVector(nint addr) : base(addr) { }
    }
    public class UniformInteger : FieldNodeInt
    {
        public UniformInteger(nint addr) : base(addr) { }
        public int Magnitude { get { return this[nameof(Magnitude)].GetValue<int>(); } set { this[nameof(Magnitude)].SetValue<int>(value); } }
        public UniformInteger SetUniformInteger(int Magnitude) { return Invoke<UniformInteger>(nameof(SetUniformInteger), Magnitude); }
    }
    public class RadialIntMask : FieldNodeInt
    {
        public RadialIntMask(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public int InteriorValue { get { return this[nameof(InteriorValue)].GetValue<int>(); } set { this[nameof(InteriorValue)].SetValue<int>(value); } }
        public int ExteriorValue { get { return this[nameof(ExteriorValue)].GetValue<int>(); } set { this[nameof(ExteriorValue)].SetValue<int>(value); } }
        public byte SetMaskCondition { get { return this[nameof(SetMaskCondition)].GetValue<byte>(); } set { this[nameof(SetMaskCondition)].SetValue<byte>(value); } }
        public RadialIntMask SetRadialIntMask(float Radius, Vector Position, int InteriorValue, int ExteriorValue, byte SetMaskConditionIn) { return Invoke<RadialIntMask>(nameof(SetRadialIntMask), Radius, Position, InteriorValue, ExteriorValue, SetMaskConditionIn); }
    }
    public class UniformScalar : FieldNodeFloat
    {
        public UniformScalar(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public UniformScalar SetUniformScalar(float Magnitude) { return Invoke<UniformScalar>(nameof(SetUniformScalar), Magnitude); }
    }
    public class WaveScalar : FieldNodeFloat
    {
        public WaveScalar(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public float WaveLength { get { return this[nameof(WaveLength)].GetValue<float>(); } set { this[nameof(WaveLength)].SetValue<float>(value); } }
        public float Period { get { return this[nameof(Period)].GetValue<float>(); } set { this[nameof(Period)].SetValue<float>(value); } }
        public byte Function { get { return this[nameof(Function)].GetValue<byte>(); } set { this[nameof(Function)].SetValue<byte>(value); } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public WaveScalar SetWaveScalar(float Magnitude, Vector Position, float WaveLength, float Period, float Time, byte Function, byte Falloff) { return Invoke<WaveScalar>(nameof(SetWaveScalar), Magnitude, Position, WaveLength, Period, Time, Function, Falloff); }
    }
    public class RadialFalloff : FieldNodeFloat
    {
        public RadialFalloff(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public RadialFalloff SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, Vector Position, byte Falloff) { return Invoke<RadialFalloff>(nameof(SetRadialFalloff), Magnitude, MinRange, MaxRange, Default, Radius, Position, Falloff); }
    }
    public class PlaneFalloff : FieldNodeFloat
    {
        public PlaneFalloff(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public PlaneFalloff SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, Vector Position, Vector Normal, byte Falloff) { return Invoke<PlaneFalloff>(nameof(SetPlaneFalloff), Magnitude, MinRange, MaxRange, Default, Distance, Position, Normal, Falloff); }
    }
    public class BoxFalloff : FieldNodeFloat
    {
        public BoxFalloff(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public BoxFalloff SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, Transform Transform, byte Falloff) { return Invoke<BoxFalloff>(nameof(SetBoxFalloff), Magnitude, MinRange, MaxRange, Default, Transform, Falloff); }
    }
    public class NoiseField : FieldNodeFloat
    {
        public NoiseField(nint addr) : base(addr) { }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public NoiseField SetNoiseField(float MinRange, float MaxRange, Transform Transform) { return Invoke<NoiseField>(nameof(SetNoiseField), MinRange, MaxRange, Transform); }
    }
    public class UniformVector : FieldNodeVector
    {
        public UniformVector(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public UniformVector SetUniformVector(float Magnitude, Vector Direction) { return Invoke<UniformVector>(nameof(SetUniformVector), Magnitude, Direction); }
    }
    public class RadialVector : FieldNodeVector
    {
        public RadialVector(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public RadialVector SetRadialVector(float Magnitude, Vector Position) { return Invoke<RadialVector>(nameof(SetRadialVector), Magnitude, Position); }
    }
    public class RandomVector : FieldNodeVector
    {
        public RandomVector(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public RandomVector SetRandomVector(float Magnitude) { return Invoke<RandomVector>(nameof(SetRandomVector), Magnitude); }
    }
    public class OperatorField : FieldNodeBase
    {
        public OperatorField(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public FieldNodeBase RightField { get { return this[nameof(RightField)].As<FieldNodeBase>(); } set { this["RightField"] = value; } }
        public FieldNodeBase LeftField { get { return this[nameof(LeftField)].As<FieldNodeBase>(); } set { this["LeftField"] = value; } }
        public byte Operation { get { return this[nameof(Operation)].GetValue<byte>(); } set { this[nameof(Operation)].SetValue<byte>(value); } }
        public OperatorField SetOperatorField(float Magnitude, FieldNodeBase LeftField, FieldNodeBase RightField, byte Operation) { return Invoke<OperatorField>(nameof(SetOperatorField), Magnitude, LeftField, RightField, Operation); }
    }
    public class ToIntegerField : FieldNodeInt
    {
        public ToIntegerField(nint addr) : base(addr) { }
        //public FieldNodeFloat FloatField { get { return this[nameof(FloatField)].As<FieldNodeFloat>(); } set { this["FloatField"] = value; } }
        public ToIntegerField SetToIntegerField(FieldNodeFloat FloatField) { return Invoke<ToIntegerField>(nameof(SetToIntegerField), FloatField); }
    }
    public class ToFloatField : FieldNodeFloat
    {
        public ToFloatField(nint addr) : base(addr) { }
        public FieldNodeInt IntField { get { return this[nameof(IntField)].As<FieldNodeInt>(); } set { this["IntField"] = value; } }
        public ToFloatField SetToFloatField(FieldNodeInt IntegerField) { return Invoke<ToFloatField>(nameof(SetToFloatField), IntegerField); }
    }
    public class CullingField : FieldNodeBase
    {
        public CullingField(nint addr) : base(addr) { }
        public FieldNodeBase Culling { get { return this[nameof(Culling)].As<FieldNodeBase>(); } set { this["Culling"] = value; } }
        public FieldNodeBase Field { get { return this[nameof(Field)].As<FieldNodeBase>(); } set { this["Field"] = value; } }
        public byte Operation { get { return this[nameof(Operation)].GetValue<byte>(); } set { this[nameof(Operation)].SetValue<byte>(value); } }
        public CullingField SetCullingField(FieldNodeBase Culling, FieldNodeBase Field, byte Operation) { return Invoke<CullingField>(nameof(SetCullingField), Culling, Field, Operation); }
    }
    public class ReturnResultsTerminal : FieldNodeBase
    {
        public ReturnResultsTerminal(nint addr) : base(addr) { }
        public ReturnResultsTerminal SetReturnResultsTerminal() { return Invoke<ReturnResultsTerminal>(nameof(SetReturnResultsTerminal)); }
    }
    public class FieldObjectCommands : Object
    {
        public FieldObjectCommands(nint addr) : base(addr) { }
        public Array<Object> TargetNames { get { return new Array<Object>(this[nameof(TargetNames)].Address); } }
        public Array<FieldNodeBase> RootNodes { get { return new Array<FieldNodeBase>(this[nameof(RootNodes)].Address); } }
        public Array<FieldSystemMetaData> MetaDatas { get { return new Array<FieldSystemMetaData>(this[nameof(MetaDatas)].Address); } }
    }
}
