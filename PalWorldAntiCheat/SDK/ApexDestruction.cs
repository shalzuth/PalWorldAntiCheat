using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ApexDestructionSDK
{
    public class DestructibleActor : Actor
    {
        public DestructibleActor(nint addr) : base(addr) { }
        public DestructibleComponent DestructibleComponent { get { return this[nameof(DestructibleComponent)].As<DestructibleComponent>(); } set { this["DestructibleComponent"] = value; } }
        public Object OnActorFracture { get { return this[nameof(OnActorFracture)]; } set { this[nameof(OnActorFracture)] = value; } }
    }
    public class DestructibleComponent : SkinnedMeshComponent
    {
        public DestructibleComponent(nint addr) : base(addr) { }
        public bool bFractureEffectOverride { get { return this[nameof(bFractureEffectOverride)].Flag; } set { this[nameof(bFractureEffectOverride)].Flag = value; } }
        public Array<FractureEffect> FractureEffects { get { return new Array<FractureEffect>(this[nameof(FractureEffects)].Address); } }
        public bool bEnableHardSleeping { get { return this[nameof(bEnableHardSleeping)].Flag; } set { this[nameof(bEnableHardSleeping)].Flag = value; } }
        public float LargeChunkThreshold { get { return this[nameof(LargeChunkThreshold)].GetValue<float>(); } set { this[nameof(LargeChunkThreshold)].SetValue<float>(value); } }
        public Object OnComponentFracture { get { return this[nameof(OnComponentFracture)]; } set { this[nameof(OnComponentFracture)] = value; } }
        public void SetDestructibleMesh(DestructibleMesh NewMesh) { Invoke(nameof(SetDestructibleMesh), NewMesh); }
        public DestructibleMesh GetDestructibleMesh() { return Invoke<DestructibleMesh>(nameof(GetDestructibleMesh)); }
        public void ApplyRadiusDamage(float BaseDamage, Vector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage) { Invoke(nameof(ApplyRadiusDamage), BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage); }
        public void ApplyDamage(float DamageAmount, Vector HitLocation, Vector ImpulseDir, float ImpulseStrength) { Invoke(nameof(ApplyDamage), DamageAmount, HitLocation, ImpulseDir, ImpulseStrength); }
    }
    public class DestructibleFractureSettings : Object
    {
        public DestructibleFractureSettings(nint addr) : base(addr) { }
        public int CellSiteCount { get { return this[nameof(CellSiteCount)].GetValue<int>(); } set { this[nameof(CellSiteCount)].SetValue<int>(value); } }
        public FractureMaterial FractureMaterialDesc { get { return this[nameof(FractureMaterialDesc)].As<FractureMaterial>(); } set { this["FractureMaterialDesc"] = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public Array<Vector> VoronoiSites { get { return new Array<Vector>(this[nameof(VoronoiSites)].Address); } }
        public int OriginalSubmeshCount { get { return this[nameof(OriginalSubmeshCount)].GetValue<int>(); } set { this[nameof(OriginalSubmeshCount)].SetValue<int>(value); } }
        public Array<MaterialInterface> Materials { get { return new Array<MaterialInterface>(this[nameof(Materials)].Address); } }
        public Array<DestructibleChunkParameters> ChunkParameters { get { return new Array<DestructibleChunkParameters>(this[nameof(ChunkParameters)].Address); } }
    }
    public class DestructibleMesh : SkeletalMesh
    {
        public DestructibleMesh(nint addr) : base(addr) { }
        public DestructibleParameters DefaultDestructibleParameters { get { return this[nameof(DefaultDestructibleParameters)].As<DestructibleParameters>(); } set { this["DefaultDestructibleParameters"] = value; } }
        public Array<FractureEffect> FractureEffects { get { return new Array<FractureEffect>(this[nameof(FractureEffects)].Address); } }
    }
    public enum EImpactDamageOverride : int
    {
        IDO_None = 0,
        IDO_On = 1,
        IDO_Off = 2,
        IDO_MAX = 3,
    }
    public class FractureMaterial : Object
    {
        public FractureMaterial(nint addr) : base(addr) { }
        public Vector2D UVScale { get { return this[nameof(UVScale)].As<Vector2D>(); } set { this["UVScale"] = value; } }
        public Vector2D UVOffset { get { return this[nameof(UVOffset)].As<Vector2D>(); } set { this["UVOffset"] = value; } }
        public Vector Tangent { get { return this[nameof(Tangent)].As<Vector>(); } set { this["Tangent"] = value; } }
        public float UAngle { get { return this[nameof(UAngle)].GetValue<float>(); } set { this[nameof(UAngle)].SetValue<float>(value); } }
        public int InteriorElementIndex { get { return this[nameof(InteriorElementIndex)].GetValue<int>(); } set { this[nameof(InteriorElementIndex)].SetValue<int>(value); } }
    }
    public class DestructibleChunkParameters : Object
    {
        public DestructibleChunkParameters(nint addr) : base(addr) { }
        public bool bIsSupportChunk { get { return this[nameof(bIsSupportChunk)].Flag; } set { this[nameof(bIsSupportChunk)].Flag = value; } }
        public bool bDoNotFracture { get { return this[nameof(bDoNotFracture)].Flag; } set { this[nameof(bDoNotFracture)].Flag = value; } }
        public bool bDoNotDamage { get { return this[nameof(bDoNotDamage)].Flag; } set { this[nameof(bDoNotDamage)].Flag = value; } }
        public bool bDoNotCrumble { get { return this[nameof(bDoNotCrumble)].Flag; } set { this[nameof(bDoNotCrumble)].Flag = value; } }
    }
    public class DestructibleDepthParameters : Object
    {
        public DestructibleDepthParameters(nint addr) : base(addr) { }
        public byte ImpactDamageOverride { get { return this[nameof(ImpactDamageOverride)].GetValue<byte>(); } set { this[nameof(ImpactDamageOverride)].SetValue<byte>(value); } }
    }
    public class DestructibleParametersFlag : Object
    {
        public DestructibleParametersFlag(nint addr) : base(addr) { }
        public bool bAccumulateDamage { get { return this[nameof(bAccumulateDamage)].Flag; } set { this[nameof(bAccumulateDamage)].Flag = value; } }
        public bool bAssetDefinedSupport { get { return this[nameof(bAssetDefinedSupport)].Flag; } set { this[nameof(bAssetDefinedSupport)].Flag = value; } }
        public bool bWorldSupport { get { return this[nameof(bWorldSupport)].Flag; } set { this[nameof(bWorldSupport)].Flag = value; } }
        public bool bDebrisTimeout { get { return this[nameof(bDebrisTimeout)].Flag; } set { this[nameof(bDebrisTimeout)].Flag = value; } }
        public bool bDebrisMaxSeparation { get { return this[nameof(bDebrisMaxSeparation)].Flag; } set { this[nameof(bDebrisMaxSeparation)].Flag = value; } }
        public bool bCrumbleSmallestChunks { get { return this[nameof(bCrumbleSmallestChunks)].Flag; } set { this[nameof(bCrumbleSmallestChunks)].Flag = value; } }
        public bool bAccurateRaycasts { get { return this[nameof(bAccurateRaycasts)].Flag; } set { this[nameof(bAccurateRaycasts)].Flag = value; } }
        public bool bUseValidBounds { get { return this[nameof(bUseValidBounds)].Flag; } set { this[nameof(bUseValidBounds)].Flag = value; } }
        public bool bFormExtendedStructures { get { return this[nameof(bFormExtendedStructures)].Flag; } set { this[nameof(bFormExtendedStructures)].Flag = value; } }
    }
    public class DestructibleDamageParameters : Object
    {
        public DestructibleDamageParameters(nint addr) : base(addr) { }
        public float DamageThreshold { get { return this[nameof(DamageThreshold)].GetValue<float>(); } set { this[nameof(DamageThreshold)].SetValue<float>(value); } }
        public float DamageSpread { get { return this[nameof(DamageSpread)].GetValue<float>(); } set { this[nameof(DamageSpread)].SetValue<float>(value); } }
        public bool bEnableImpactDamage { get { return this[nameof(bEnableImpactDamage)].Flag; } set { this[nameof(bEnableImpactDamage)].Flag = value; } }
        public float ImpactDamage { get { return this[nameof(ImpactDamage)].GetValue<float>(); } set { this[nameof(ImpactDamage)].SetValue<float>(value); } }
        public int DefaultImpactDamageDepth { get { return this[nameof(DefaultImpactDamageDepth)].GetValue<int>(); } set { this[nameof(DefaultImpactDamageDepth)].SetValue<int>(value); } }
        public bool bCustomImpactResistance { get { return this[nameof(bCustomImpactResistance)].Flag; } set { this[nameof(bCustomImpactResistance)].Flag = value; } }
        public float ImpactResistance { get { return this[nameof(ImpactResistance)].GetValue<float>(); } set { this[nameof(ImpactResistance)].SetValue<float>(value); } }
    }
    public class DestructibleDebrisParameters : Object
    {
        public DestructibleDebrisParameters(nint addr) : base(addr) { }
        public float DebrisLifetimeMin { get { return this[nameof(DebrisLifetimeMin)].GetValue<float>(); } set { this[nameof(DebrisLifetimeMin)].SetValue<float>(value); } }
        public float DebrisLifetimeMax { get { return this[nameof(DebrisLifetimeMax)].GetValue<float>(); } set { this[nameof(DebrisLifetimeMax)].SetValue<float>(value); } }
        public float DebrisMaxSeparationMin { get { return this[nameof(DebrisMaxSeparationMin)].GetValue<float>(); } set { this[nameof(DebrisMaxSeparationMin)].SetValue<float>(value); } }
        public float DebrisMaxSeparationMax { get { return this[nameof(DebrisMaxSeparationMax)].GetValue<float>(); } set { this[nameof(DebrisMaxSeparationMax)].SetValue<float>(value); } }
        public Box ValidBounds { get { return this[nameof(ValidBounds)].As<Box>(); } set { this["ValidBounds"] = value; } }
    }
    public class DestructibleAdvancedParameters : Object
    {
        public DestructibleAdvancedParameters(nint addr) : base(addr) { }
        public float DamageCap { get { return this[nameof(DamageCap)].GetValue<float>(); } set { this[nameof(DamageCap)].SetValue<float>(value); } }
        public float ImpactVelocityThreshold { get { return this[nameof(ImpactVelocityThreshold)].GetValue<float>(); } set { this[nameof(ImpactVelocityThreshold)].SetValue<float>(value); } }
        public float MaxChunkSpeed { get { return this[nameof(MaxChunkSpeed)].GetValue<float>(); } set { this[nameof(MaxChunkSpeed)].SetValue<float>(value); } }
        public float FractureImpulseScale { get { return this[nameof(FractureImpulseScale)].GetValue<float>(); } set { this[nameof(FractureImpulseScale)].SetValue<float>(value); } }
    }
    public class DestructibleSpecialHierarchyDepths : Object
    {
        public DestructibleSpecialHierarchyDepths(nint addr) : base(addr) { }
        public int SupportDepth { get { return this[nameof(SupportDepth)].GetValue<int>(); } set { this[nameof(SupportDepth)].SetValue<int>(value); } }
        public int MinimumFractureDepth { get { return this[nameof(MinimumFractureDepth)].GetValue<int>(); } set { this[nameof(MinimumFractureDepth)].SetValue<int>(value); } }
        public bool bEnableDebris { get { return this[nameof(bEnableDebris)].Flag; } set { this[nameof(bEnableDebris)].Flag = value; } }
        public int DebrisDepth { get { return this[nameof(DebrisDepth)].GetValue<int>(); } set { this[nameof(DebrisDepth)].SetValue<int>(value); } }
        public int EssentialDepth { get { return this[nameof(EssentialDepth)].GetValue<int>(); } set { this[nameof(EssentialDepth)].SetValue<int>(value); } }
    }
    public class DestructibleParameters : Object
    {
        public DestructibleParameters(nint addr) : base(addr) { }
        public DestructibleDamageParameters DamageParameters { get { return this[nameof(DamageParameters)].As<DestructibleDamageParameters>(); } set { this["DamageParameters"] = value; } }
        public DestructibleDebrisParameters DebrisParameters { get { return this[nameof(DebrisParameters)].As<DestructibleDebrisParameters>(); } set { this["DebrisParameters"] = value; } }
        public DestructibleAdvancedParameters AdvancedParameters { get { return this[nameof(AdvancedParameters)].As<DestructibleAdvancedParameters>(); } set { this["AdvancedParameters"] = value; } }
        public DestructibleSpecialHierarchyDepths SpecialHierarchyDepths { get { return this[nameof(SpecialHierarchyDepths)].As<DestructibleSpecialHierarchyDepths>(); } set { this["SpecialHierarchyDepths"] = value; } }
        public Array<DestructibleDepthParameters> DepthParameters { get { return new Array<DestructibleDepthParameters>(this[nameof(DepthParameters)].Address); } }
        public DestructibleParametersFlag Flags { get { return this[nameof(Flags)].As<DestructibleParametersFlag>(); } set { this["Flags"] = value; } }
    }
}
