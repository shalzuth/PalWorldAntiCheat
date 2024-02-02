using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneTracksSDK;
using SDK.Script.MovieSceneSDK;
namespace SDK.Script.ChaosCachingSDK
{
    public class ChaosCacheCollection : Object
    {
        public ChaosCacheCollection(nint addr) : base(addr) { }
        public Array<ChaosCache> Caches { get { return new Array<ChaosCache>(this[nameof(Caches)].Address); } }
    }
    public class ChaosCacheManager : Actor
    {
        public ChaosCacheManager(nint addr) : base(addr) { }
        public ChaosCacheCollection CacheCollection { get { return this[nameof(CacheCollection)].As<ChaosCacheCollection>(); } set { this["CacheCollection"] = value; } }
        public ECacheMode CacheMode { get { return (ECacheMode)this[nameof(CacheMode)].GetValue<int>(); } set { this[nameof(CacheMode)].SetValue<int>((int)value); } }
        public EStartMode StartMode { get { return (EStartMode)this[nameof(StartMode)].GetValue<int>(); } set { this[nameof(StartMode)].SetValue<int>((int)value); } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public Array<ObservedComponent> ObservedComponents { get { return new Array<ObservedComponent>(this[nameof(ObservedComponents)].Address); } }
        public void TriggerComponentByCache(Object InCacheName) { Invoke(nameof(TriggerComponentByCache), InCacheName); }
        public void TriggerComponent(PrimitiveComponent InComponent) { Invoke(nameof(TriggerComponent), InComponent); }
        public void TriggerAll() { Invoke(nameof(TriggerAll)); }
        public void SetStartTime(float InStartTime) { Invoke(nameof(SetStartTime), InStartTime); }
        public void ResetSingleTransform(int InIndex) { Invoke(nameof(ResetSingleTransform), InIndex); }
        public void ResetAllComponentTransforms() { Invoke(nameof(ResetAllComponentTransforms)); }
    }
    public class ChaosCachePlayer : ChaosCacheManager
    {
        public ChaosCachePlayer(nint addr) : base(addr) { }
    }
    public class ChaosCache : Object
    {
        public ChaosCache(nint addr) : base(addr) { }
        public float RecordedDuration { get { return this[nameof(RecordedDuration)].GetValue<float>(); } set { this[nameof(RecordedDuration)].SetValue<float>(value); } }
        public uint NumRecordedFrames { get { return this[nameof(NumRecordedFrames)].GetValue<uint>(); } set { this[nameof(NumRecordedFrames)].SetValue<uint>(value); } }
        public Array<int> TrackToParticle { get { return new Array<int>(this[nameof(TrackToParticle)].Address); } }
        public Array<PerParticleCacheData> ParticleTracks { get { return new Array<PerParticleCacheData>(this[nameof(ParticleTracks)].Address); } }
        public Object ChannelsTracks { get { return this[nameof(ChannelsTracks)]; } set { this[nameof(ChannelsTracks)] = value; } }
        public Object CurveData { get { return this[nameof(CurveData)]; } set { this[nameof(CurveData)] = value; } }
        public Object EventTracks { get { return this[nameof(EventTracks)]; } set { this[nameof(EventTracks)] = value; } }
        public CacheSpawnableTemplate Spawnable { get { return this[nameof(Spawnable)].As<CacheSpawnableTemplate>(); } set { this["Spawnable"] = value; } }
        public Guid AdapterGuid { get { return this[nameof(AdapterGuid)].As<Guid>(); } set { this["AdapterGuid"] = value; } }
        public int Version { get { return this[nameof(Version)].GetValue<int>(); } set { this[nameof(Version)].SetValue<int>(value); } }
    }
    public class MovieSceneChaosCacheSection : MovieSceneBaseCacheSection
    {
        public MovieSceneChaosCacheSection(nint addr) : base(addr) { }
        public MovieSceneChaosCacheParams Params { get { return this[nameof(Params)].As<MovieSceneChaosCacheParams>(); } set { this["Params"] = value; } }
    }
    public class MovieSceneChaosCacheTrack : MovieSceneNameableTrack
    {
        public MovieSceneChaosCacheTrack(nint addr) : base(addr) { }
        public Array<MovieSceneSection> AnimationSections { get { return new Array<MovieSceneSection>(this[nameof(AnimationSections)].Address); } }
    }
    public enum ECacheMode : int
    {
        None = 0,
        Play = 1,
        Record = 2,
        ECacheMode_MAX = 3,
    }
    public enum EStartMode : int
    {
        Timed = 0,
        Triggered = 1,
        EStartMode_MAX = 2,
    }
    public class CacheEventBase : Object
    {
        public CacheEventBase(nint addr) : base(addr) { }
    }
    public class CacheEventTrack : Object
    {
        public CacheEventTrack(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public ScriptStruct Struct { get { return this[nameof(Struct)].As<ScriptStruct>(); } set { this["Struct"] = value; } }
        public Array<float> TimeStamps { get { return new Array<float>(this[nameof(TimeStamps)].Address); } }
    }
    public class ObservedComponent : Object
    {
        public ObservedComponent(nint addr) : base(addr) { }
        public Object CacheName { get { return this[nameof(CacheName)]; } set { this[nameof(CacheName)] = value; } }
        public ComponentReference ComponentRef { get { return this[nameof(ComponentRef)].As<ComponentReference>(); } set { this["ComponentRef"] = value; } }
        public SoftComponentReference SoftComponentRef { get { return this[nameof(SoftComponentRef)].As<SoftComponentReference>(); } set { this["SoftComponentRef"] = value; } }
        public bool bIsSimulating { get { return this[nameof(bIsSimulating)].Flag; } set { this[nameof(bIsSimulating)].Flag = value; } }
    }
    public class ParticleTransformTrack : Object
    {
        public ParticleTransformTrack(nint addr) : base(addr) { }
        public RawAnimSequenceTrack RawTransformTrack { get { return this[nameof(RawTransformTrack)].As<RawAnimSequenceTrack>(); } set { this["RawTransformTrack"] = value; } }
        public float BeginOffset { get { return this[nameof(BeginOffset)].GetValue<float>(); } set { this[nameof(BeginOffset)].SetValue<float>(value); } }
        public bool bDeactivateOnEnd { get { return this[nameof(bDeactivateOnEnd)].Flag; } set { this[nameof(bDeactivateOnEnd)].Flag = value; } }
        public Array<float> KeyTimestamps { get { return new Array<float>(this[nameof(KeyTimestamps)].Address); } }
    }
    public class PerParticleCacheData : Object
    {
        public PerParticleCacheData(nint addr) : base(addr) { }
        public ParticleTransformTrack TransformData { get { return this[nameof(TransformData)].As<ParticleTransformTrack>(); } set { this["TransformData"] = value; } }
        public Object CurveData { get { return this[nameof(CurveData)]; } set { this[nameof(CurveData)] = value; } }
    }
    public class CacheSpawnableTemplate : Object
    {
        public CacheSpawnableTemplate(nint addr) : base(addr) { }
        public Object DuplicatedTemplate { get { return this[nameof(DuplicatedTemplate)].As<Object>(); } set { this["DuplicatedTemplate"] = value; } }
        public Transform InitialTransform { get { return this[nameof(InitialTransform)].As<Transform>(); } set { this["InitialTransform"] = value; } }
        public Transform ComponentTransform { get { return this[nameof(ComponentTransform)].As<Transform>(); } set { this["ComponentTransform"] = value; } }
    }
    public class RichCurves : Object
    {
        public RichCurves(nint addr) : base(addr) { }
        public Array<RichCurve> RichCurves_value { get { return new Array<RichCurve>(this[nameof(RichCurves)].Address); } }
    }
    public class EnableStateEvent : CacheEventBase
    {
        public EnableStateEvent(nint addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public bool bEnable { get { return this[nameof(bEnable)].Flag; } set { this[nameof(bEnable)].Flag = value; } }
    }
    public class BreakingEvent : CacheEventBase
    {
        public BreakingEvent(nint addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public Vector BoundingBoxMin { get { return this[nameof(BoundingBoxMin)].As<Vector>(); } set { this["BoundingBoxMin"] = value; } }
        public Vector BoundingBoxMax { get { return this[nameof(BoundingBoxMax)].As<Vector>(); } set { this["BoundingBoxMax"] = value; } }
    }
    public class CollisionEvent : CacheEventBase
    {
        public CollisionEvent(nint addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector AccumulatedImpulse { get { return this[nameof(AccumulatedImpulse)].As<Vector>(); } set { this["AccumulatedImpulse"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector Velocity1 { get { return this[nameof(Velocity1)].As<Vector>(); } set { this["Velocity1"] = value; } }
        public Vector Velocity2 { get { return this[nameof(Velocity2)].As<Vector>(); } set { this["Velocity2"] = value; } }
        public Vector DeltaVelocity1 { get { return this[nameof(DeltaVelocity1)].As<Vector>(); } set { this["DeltaVelocity1"] = value; } }
        public Vector DeltaVelocity2 { get { return this[nameof(DeltaVelocity2)].As<Vector>(); } set { this["DeltaVelocity2"] = value; } }
        public Vector AngularVelocity1 { get { return this[nameof(AngularVelocity1)].As<Vector>(); } set { this["AngularVelocity1"] = value; } }
        public Vector AngularVelocity2 { get { return this[nameof(AngularVelocity2)].As<Vector>(); } set { this["AngularVelocity2"] = value; } }
        public float Mass1 { get { return this[nameof(Mass1)].GetValue<float>(); } set { this[nameof(Mass1)].SetValue<float>(value); } }
        public float Mass2 { get { return this[nameof(Mass2)].GetValue<float>(); } set { this[nameof(Mass2)].SetValue<float>(value); } }
        public float PenetrationDepth { get { return this[nameof(PenetrationDepth)].GetValue<float>(); } set { this[nameof(PenetrationDepth)].SetValue<float>(value); } }
    }
    public class TrailingEvent : CacheEventBase
    {
        public TrailingEvent(nint addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public Vector BoundingBoxMin { get { return this[nameof(BoundingBoxMin)].As<Vector>(); } set { this["BoundingBoxMin"] = value; } }
        public Vector BoundingBoxMax { get { return this[nameof(BoundingBoxMax)].As<Vector>(); } set { this["BoundingBoxMax"] = value; } }
    }
    public class MovieSceneChaosCacheParams : MovieSceneBaseCacheParams
    {
        public MovieSceneChaosCacheParams(nint addr) : base(addr) { }
        public ChaosCacheCollection CacheCollection { get { return this[nameof(CacheCollection)].As<ChaosCacheCollection>(); } set { this["CacheCollection"] = value; } }
    }
    public class MovieSceneChaosCacheSectionTemplateParameters : MovieSceneBaseCacheSectionTemplateParameters
    {
        public MovieSceneChaosCacheSectionTemplateParameters(nint addr) : base(addr) { }
        public MovieSceneChaosCacheParams ChaosCacheParams { get { return this[nameof(ChaosCacheParams)].As<MovieSceneChaosCacheParams>(); } set { this["ChaosCacheParams"] = value; } }
    }
    public class MovieSceneChaosCacheSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneChaosCacheSectionTemplate(nint addr) : base(addr) { }
        public MovieSceneChaosCacheSectionTemplateParameters Params { get { return this[nameof(Params)].As<MovieSceneChaosCacheSectionTemplateParameters>(); } set { this["Params"] = value; } }
    }
}
