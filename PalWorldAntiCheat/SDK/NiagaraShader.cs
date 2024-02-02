using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.NiagaraShaderSDK
{
    public class NiagaraScriptBase : Object
    {
        public NiagaraScriptBase(nint addr) : base(addr) { }
    }
    public enum ENiagaraMipMapGenerationType : int
    {
        Unfiltered = 0,
        Linear = 1,
        Blur1 = 2,
        Blur2 = 3,
        Blur3 = 4,
        Blur4 = 5,
        ENiagaraMipMapGenerationType_MAX = 6,
    }
    public enum ENiagaraGpuDispatchType : int
    {
        OneD = 0,
        TwoD = 1,
        ThreeD = 2,
        Custom = 3,
        ENiagaraGpuDispatchType_MAX = 4,
    }
    public enum ENiagaraSimStageExecuteBehavior : int
    {
        Always = 0,
        OnSimulationReset = 1,
        NotOnSimulationReset = 2,
        ENiagaraSimStageExecuteBehavior_MAX = 3,
    }
    public enum FNiagaraCompileEventSeverity : int
    {
        Log = 0,
        Display = 1,
        Warning = 2,
        Error = 3,
        FNiagaraCompileEventSeverity_MAX = 4,
    }
    public enum FNiagaraCompileEventSource : int
    {
        Unset = 0,
        ScriptDependency = 1,
        FNiagaraCompileEventSource_MAX = 2,
    }
    public class SimulationStageMetaData : Object
    {
        public SimulationStageMetaData(nint addr) : base(addr) { }
        public Object SimulationStageName { get { return this[nameof(SimulationStageName)]; } set { this[nameof(SimulationStageName)] = value; } }
        public Object EnabledBinding { get { return this[nameof(EnabledBinding)]; } set { this[nameof(EnabledBinding)] = value; } }
        public Object ElementCountXBinding { get { return this[nameof(ElementCountXBinding)]; } set { this[nameof(ElementCountXBinding)] = value; } }
        public Object ElementCountYBinding { get { return this[nameof(ElementCountYBinding)]; } set { this[nameof(ElementCountYBinding)] = value; } }
        public Object ElementCountZBinding { get { return this[nameof(ElementCountZBinding)]; } set { this[nameof(ElementCountZBinding)] = value; } }
        public Object IterationSource { get { return this[nameof(IterationSource)]; } set { this[nameof(IterationSource)] = value; } }
        public ENiagaraSimStageExecuteBehavior ExecuteBehavior { get { return (ENiagaraSimStageExecuteBehavior)this[nameof(ExecuteBehavior)].GetValue<int>(); } set { this[nameof(ExecuteBehavior)].SetValue<int>((int)value); } }
        public bool bWritesParticles { get { return this[nameof(bWritesParticles)].Flag; } set { this[nameof(bWritesParticles)].Flag = value; } }
        public bool bPartialParticleUpdate { get { return this[nameof(bPartialParticleUpdate)].Flag; } set { this[nameof(bPartialParticleUpdate)].Flag = value; } }
        public bool bParticleIterationStateEnabled { get { return this[nameof(bParticleIterationStateEnabled)].Flag; } set { this[nameof(bParticleIterationStateEnabled)].Flag = value; } }
        public bool bOverrideElementCount { get { return this[nameof(bOverrideElementCount)].Flag; } set { this[nameof(bOverrideElementCount)].Flag = value; } }
        public Object ParticleIterationStateBinding { get { return this[nameof(ParticleIterationStateBinding)]; } set { this[nameof(ParticleIterationStateBinding)] = value; } }
        public IntPoint ParticleIterationStateRange { get { return this[nameof(ParticleIterationStateRange)].As<IntPoint>(); } set { this["ParticleIterationStateRange"] = value; } }
        public Array<Object> OutputDestinations { get { return new Array<Object>(this[nameof(OutputDestinations)].Address); } }
        public Array<Object> InputDataInterfaces { get { return new Array<Object>(this[nameof(InputDataInterfaces)].Address); } }
        public int NumIterations { get { return this[nameof(NumIterations)].GetValue<int>(); } set { this[nameof(NumIterations)].SetValue<int>(value); } }
        public Object NumIterationsBinding { get { return this[nameof(NumIterationsBinding)]; } set { this[nameof(NumIterationsBinding)] = value; } }
        public ENiagaraGpuDispatchType GpuDispatchType { get { return (ENiagaraGpuDispatchType)this[nameof(GpuDispatchType)].GetValue<int>(); } set { this[nameof(GpuDispatchType)].SetValue<int>((int)value); } }
        public IntVector GpuDispatchNumThreads { get { return this[nameof(GpuDispatchNumThreads)].As<IntVector>(); } set { this["GpuDispatchNumThreads"] = value; } }
    }
    public class NiagaraShaderScriptParametersMetadata : Object
    {
        public NiagaraShaderScriptParametersMetadata(nint addr) : base(addr) { }
        public Array<NiagaraDataInterfaceGPUParamInfo> DataInterfaceParamInfo { get { return new Array<NiagaraDataInterfaceGPUParamInfo>(this[nameof(DataInterfaceParamInfo)].Address); } }
        public Array<Object> LooseMetadataNames { get { return new Array<Object>(this[nameof(LooseMetadataNames)].Address); } }
        public bool bExternalConstantsInterpolated { get { return this[nameof(bExternalConstantsInterpolated)].Flag; } set { this[nameof(bExternalConstantsInterpolated)].Flag = value; } }
        public Array<NiagaraShaderScriptExternalConstant> ExternalConstants { get { return new Array<NiagaraShaderScriptExternalConstant>(this[nameof(ExternalConstants)].Address); } }
    }
    public class NiagaraShaderScriptExternalConstant : Object
    {
        public NiagaraShaderScriptExternalConstant(nint addr) : base(addr) { }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class NiagaraDataInterfaceGPUParamInfo : Object
    {
        public NiagaraDataInterfaceGPUParamInfo(nint addr) : base(addr) { }
        public Object DataInterfaceHLSLSymbol { get { return this[nameof(DataInterfaceHLSLSymbol)]; } set { this[nameof(DataInterfaceHLSLSymbol)] = value; } }
        public Object DIClassName { get { return this[nameof(DIClassName)]; } set { this[nameof(DIClassName)] = value; } }
        public uint ShaderParametersOffset { get { return this[nameof(ShaderParametersOffset)].GetValue<uint>(); } set { this[nameof(ShaderParametersOffset)].SetValue<uint>(value); } }
        public Array<NiagaraDataInterfaceGeneratedFunction> GeneratedFunctions { get { return new Array<NiagaraDataInterfaceGeneratedFunction>(this[nameof(GeneratedFunctions)].Address); } }
    }
    public class NiagaraDataInterfaceGeneratedFunction : Object
    {
        public NiagaraDataInterfaceGeneratedFunction(nint addr) : base(addr) { }
    }
    public class NiagaraCompileEvent : Object
    {
        public NiagaraCompileEvent(nint addr) : base(addr) { }
        public FNiagaraCompileEventSeverity Severity { get { return (FNiagaraCompileEventSeverity)this[nameof(Severity)].GetValue<int>(); } set { this[nameof(Severity)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
        public Object ShortDescription { get { return this[nameof(ShortDescription)]; } set { this[nameof(ShortDescription)] = value; } }
        public bool bDismissable { get { return this[nameof(bDismissable)].Flag; } set { this[nameof(bDismissable)].Flag = value; } }
        public Guid NodeGuid { get { return this[nameof(NodeGuid)].As<Guid>(); } set { this["NodeGuid"] = value; } }
        public Guid PinGuid { get { return this[nameof(PinGuid)].As<Guid>(); } set { this["PinGuid"] = value; } }
        public Array<Guid> StackGuids { get { return new Array<Guid>(this[nameof(StackGuids)].Address); } }
        public FNiagaraCompileEventSource Source { get { return (FNiagaraCompileEventSource)this[nameof(Source)].GetValue<int>(); } set { this[nameof(Source)].SetValue<int>((int)value); } }
    }
}
