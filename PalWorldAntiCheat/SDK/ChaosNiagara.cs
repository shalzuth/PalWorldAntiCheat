using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.NiagaraSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.GeometryCollectionEngineSDK;
namespace SDK.Script.ChaosNiagaraSDK
{
    public class NiagaraDataInterfaceChaosDestruction : NiagaraDataInterface
    {
        public NiagaraDataInterfaceChaosDestruction(nint addr) : base(addr) { }
        public Object ChaosSolverActorSet { get { return this[nameof(ChaosSolverActorSet)]; } set { this[nameof(ChaosSolverActorSet)] = value; } }
        public EDataSourceTypeEnum DataSourceType { get { return (EDataSourceTypeEnum)this[nameof(DataSourceType)].GetValue<int>(); } set { this[nameof(DataSourceType)].SetValue<int>((int)value); } }
        public int DataProcessFrequency { get { return this[nameof(DataProcessFrequency)].GetValue<int>(); } set { this[nameof(DataProcessFrequency)].SetValue<int>(value); } }
        public int MaxNumberOfDataEntriesToSpawn { get { return this[nameof(MaxNumberOfDataEntriesToSpawn)].GetValue<int>(); } set { this[nameof(MaxNumberOfDataEntriesToSpawn)].SetValue<int>(value); } }
        public bool DoSpawn { get { return this[nameof(DoSpawn)].Flag; } set { this[nameof(DoSpawn)].Flag = value; } }
        public Vector2D SpawnMultiplierMinMax { get { return this[nameof(SpawnMultiplierMinMax)].As<Vector2D>(); } set { this["SpawnMultiplierMinMax"] = value; } }
        public float SpawnChance { get { return this[nameof(SpawnChance)].GetValue<float>(); } set { this[nameof(SpawnChance)].SetValue<float>(value); } }
        public Vector2D ImpulseToSpawnMinMax { get { return this[nameof(ImpulseToSpawnMinMax)].As<Vector2D>(); } set { this["ImpulseToSpawnMinMax"] = value; } }
        public Vector2D SpeedToSpawnMinMax { get { return this[nameof(SpeedToSpawnMinMax)].As<Vector2D>(); } set { this["SpeedToSpawnMinMax"] = value; } }
        public Vector2D MassToSpawnMinMax { get { return this[nameof(MassToSpawnMinMax)].As<Vector2D>(); } set { this["MassToSpawnMinMax"] = value; } }
        public Vector2D ExtentMinToSpawnMinMax { get { return this[nameof(ExtentMinToSpawnMinMax)].As<Vector2D>(); } set { this["ExtentMinToSpawnMinMax"] = value; } }
        public Vector2D ExtentMaxToSpawnMinMax { get { return this[nameof(ExtentMaxToSpawnMinMax)].As<Vector2D>(); } set { this["ExtentMaxToSpawnMinMax"] = value; } }
        public Vector2D VolumeToSpawnMinMax { get { return this[nameof(VolumeToSpawnMinMax)].As<Vector2D>(); } set { this["VolumeToSpawnMinMax"] = value; } }
        public Vector2D SolverTimeToSpawnMinMax { get { return this[nameof(SolverTimeToSpawnMinMax)].As<Vector2D>(); } set { this["SolverTimeToSpawnMinMax"] = value; } }
        public int SurfaceTypeToSpawn { get { return this[nameof(SurfaceTypeToSpawn)].GetValue<int>(); } set { this[nameof(SurfaceTypeToSpawn)].SetValue<int>(value); } }
        public ELocationFilteringModeEnum LocationFilteringMode { get { return (ELocationFilteringModeEnum)this[nameof(LocationFilteringMode)].GetValue<int>(); } set { this[nameof(LocationFilteringMode)].SetValue<int>((int)value); } }
        public ELocationXToSpawnEnum LocationXToSpawn { get { return (ELocationXToSpawnEnum)this[nameof(LocationXToSpawn)].GetValue<int>(); } set { this[nameof(LocationXToSpawn)].SetValue<int>((int)value); } }
        public Vector2D LocationXToSpawnMinMax { get { return this[nameof(LocationXToSpawnMinMax)].As<Vector2D>(); } set { this["LocationXToSpawnMinMax"] = value; } }
        public ELocationYToSpawnEnum LocationYToSpawn { get { return (ELocationYToSpawnEnum)this[nameof(LocationYToSpawn)].GetValue<int>(); } set { this[nameof(LocationYToSpawn)].SetValue<int>((int)value); } }
        public Vector2D LocationYToSpawnMinMax { get { return this[nameof(LocationYToSpawnMinMax)].As<Vector2D>(); } set { this["LocationYToSpawnMinMax"] = value; } }
        public ELocationZToSpawnEnum LocationZToSpawn { get { return (ELocationZToSpawnEnum)this[nameof(LocationZToSpawn)].GetValue<int>(); } set { this[nameof(LocationZToSpawn)].SetValue<int>((int)value); } }
        public Vector2D LocationZToSpawnMinMax { get { return this[nameof(LocationZToSpawnMinMax)].As<Vector2D>(); } set { this["LocationZToSpawnMinMax"] = value; } }
        public float TrailMinSpeedToSpawn { get { return this[nameof(TrailMinSpeedToSpawn)].GetValue<float>(); } set { this[nameof(TrailMinSpeedToSpawn)].SetValue<float>(value); } }
        public EDataSortTypeEnum DataSortingType { get { return (EDataSortTypeEnum)this[nameof(DataSortingType)].GetValue<int>(); } set { this[nameof(DataSortingType)].SetValue<int>((int)value); } }
        public bool bGetExternalCollisionData { get { return this[nameof(bGetExternalCollisionData)].Flag; } set { this[nameof(bGetExternalCollisionData)].Flag = value; } }
        public bool DoSpatialHash { get { return this[nameof(DoSpatialHash)].Flag; } set { this[nameof(DoSpatialHash)].Flag = value; } }
        public Vector SpatialHashVolumeMin { get { return this[nameof(SpatialHashVolumeMin)].As<Vector>(); } set { this["SpatialHashVolumeMin"] = value; } }
        public Vector SpatialHashVolumeMax { get { return this[nameof(SpatialHashVolumeMax)].As<Vector>(); } set { this["SpatialHashVolumeMax"] = value; } }
        public Vector SpatialHashVolumeCellSize { get { return this[nameof(SpatialHashVolumeCellSize)].As<Vector>(); } set { this["SpatialHashVolumeCellSize"] = value; } }
        public int MaxDataPerCell { get { return this[nameof(MaxDataPerCell)].GetValue<int>(); } set { this[nameof(MaxDataPerCell)].SetValue<int>(value); } }
        public bool bApplyMaterialsFilter { get { return this[nameof(bApplyMaterialsFilter)].Flag; } set { this[nameof(bApplyMaterialsFilter)].Flag = value; } }
        public Object ChaosBreakingMaterialSet { get { return this[nameof(ChaosBreakingMaterialSet)]; } set { this[nameof(ChaosBreakingMaterialSet)] = value; } }
        public bool bGetExternalBreakingData { get { return this[nameof(bGetExternalBreakingData)].Flag; } set { this[nameof(bGetExternalBreakingData)].Flag = value; } }
        public bool bGetExternalTrailingData { get { return this[nameof(bGetExternalTrailingData)].Flag; } set { this[nameof(bGetExternalTrailingData)].Flag = value; } }
        public Vector2D RandomPositionMagnitudeMinMax { get { return this[nameof(RandomPositionMagnitudeMinMax)].As<Vector2D>(); } set { this["RandomPositionMagnitudeMinMax"] = value; } }
        public float InheritedVelocityMultiplier { get { return this[nameof(InheritedVelocityMultiplier)].GetValue<float>(); } set { this[nameof(InheritedVelocityMultiplier)].SetValue<float>(value); } }
        public ERandomVelocityGenerationTypeEnum RandomVelocityGenerationType { get { return (ERandomVelocityGenerationTypeEnum)this[nameof(RandomVelocityGenerationType)].GetValue<int>(); } set { this[nameof(RandomVelocityGenerationType)].SetValue<int>((int)value); } }
        public Vector2D RandomVelocityMagnitudeMinMax { get { return this[nameof(RandomVelocityMagnitudeMinMax)].As<Vector2D>(); } set { this["RandomVelocityMagnitudeMinMax"] = value; } }
        public float SpreadAngleMax { get { return this[nameof(SpreadAngleMax)].GetValue<float>(); } set { this[nameof(SpreadAngleMax)].SetValue<float>(value); } }
        public Vector VelocityOffsetMin { get { return this[nameof(VelocityOffsetMin)].As<Vector>(); } set { this["VelocityOffsetMin"] = value; } }
        public Vector VelocityOffsetMax { get { return this[nameof(VelocityOffsetMax)].As<Vector>(); } set { this["VelocityOffsetMax"] = value; } }
        public Vector2D FinalVelocityMagnitudeMinMax { get { return this[nameof(FinalVelocityMagnitudeMinMax)].As<Vector2D>(); } set { this["FinalVelocityMagnitudeMinMax"] = value; } }
        public float MaxLatency { get { return this[nameof(MaxLatency)].GetValue<float>(); } set { this[nameof(MaxLatency)].SetValue<float>(value); } }
        public EDebugTypeEnum DebugType { get { return (EDebugTypeEnum)this[nameof(DebugType)].GetValue<int>(); } set { this[nameof(DebugType)].SetValue<int>((int)value); } }
        public int LastSpawnedPointID { get { return this[nameof(LastSpawnedPointID)].GetValue<int>(); } set { this[nameof(LastSpawnedPointID)].SetValue<int>(value); } }
        public float LastSpawnTime { get { return this[nameof(LastSpawnTime)].GetValue<float>(); } set { this[nameof(LastSpawnTime)].SetValue<float>(value); } }
        public float SolverTime { get { return this[nameof(SolverTime)].GetValue<float>(); } set { this[nameof(SolverTime)].SetValue<float>(value); } }
        public float TimeStampOfLastProcessedData { get { return this[nameof(TimeStampOfLastProcessedData)].GetValue<float>(); } set { this[nameof(TimeStampOfLastProcessedData)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceGeometryCollection : NiagaraDataInterface
    {
        public NiagaraDataInterfaceGeometryCollection(nint addr) : base(addr) { }
        public GeometryCollectionActor GeometryCollectionActor { get { return this[nameof(GeometryCollectionActor)].As<GeometryCollectionActor>(); } set { this["GeometryCollectionActor"] = value; } }
    }
    public class NiagaraDataInterfacePhysicsField : NiagaraDataInterface
    {
        public NiagaraDataInterfacePhysicsField(nint addr) : base(addr) { }
    }
    public enum EDataSortTypeEnum : int
    {
        ChaosNiagara_DataSortType_NoSorting = 0,
        ChaosNiagara_DataSortType_RandomShuffle = 1,
        ChaosNiagara_DataSortType_SortByMassMaxToMin = 2,
        ChaosNiagara_DataSortType_SortByMassMinToMax = 3,
        ChaosNiagara_Max = 4,
    }
    public enum ERandomVelocityGenerationTypeEnum : int
    {
        ChaosNiagara_RandomVelocityGenerationType_RandomDistribution = 0,
        ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers = 1,
        ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased = 2,
        ChaosNiagara_Max = 3,
    }
    public enum EDebugTypeEnum : int
    {
        ChaosNiagara_DebugType_NoDebug = 0,
        ChaosNiagara_DebugType_ColorBySolver = 1,
        ChaosNiagara_DebugType_ColorByParticleIndex = 2,
        ChaosNiagara_Max = 3,
    }
    public enum EDataSourceTypeEnum : int
    {
        ChaosNiagara_DataSourceType_Collision = 0,
        ChaosNiagara_DataSourceType_Breaking = 1,
        ChaosNiagara_DataSourceType_Trailing = 2,
        ChaosNiagara_Max = 3,
    }
    public enum ELocationFilteringModeEnum : int
    {
        ChaosNiagara_LocationFilteringMode_Inclusive = 0,
        ChaosNiagara_LocationFilteringMode_Exclusive = 1,
        ChaosNiagara_Max = 2,
    }
    public enum ELocationXToSpawnEnum : int
    {
        ChaosNiagara_LocationXToSpawn_None = 0,
        ChaosNiagara_LocationXToSpawn_Min = 1,
        ChaosNiagara_LocationXToSpawn_Max = 2,
        ChaosNiagara_LocationXToSpawn_MinMax = 3,
        ChaosNiagara_Max = 4,
    }
    public enum ELocationYToSpawnEnum : int
    {
        ChaosNiagara_LocationYToSpawn_None = 0,
        ChaosNiagara_LocationYToSpawn_Min = 1,
        ChaosNiagara_LocationYToSpawn_Max = 2,
        ChaosNiagara_LocationYToSpawn_MinMax = 3,
        ChaosNiagara_Max = 4,
    }
    public enum ELocationZToSpawnEnum : int
    {
        ChaosNiagara_LocationZToSpawn_None = 0,
        ChaosNiagara_LocationZToSpawn_Min = 1,
        ChaosNiagara_LocationZToSpawn_Max = 2,
        ChaosNiagara_LocationZToSpawn_MinMax = 3,
        ChaosNiagara_Max = 4,
    }
    public class ChaosDestructionEvent : Object
    {
        public ChaosDestructionEvent(nint addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float ExtentMin { get { return this[nameof(ExtentMin)].GetValue<float>(); } set { this[nameof(ExtentMin)].SetValue<float>(value); } }
        public float ExtentMax { get { return this[nameof(ExtentMax)].GetValue<float>(); } set { this[nameof(ExtentMax)].SetValue<float>(value); } }
        public int ParticleID { get { return this[nameof(ParticleID)].GetValue<int>(); } set { this[nameof(ParticleID)].SetValue<int>(value); } }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
        public int Type { get { return this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>(value); } }
    }
}
