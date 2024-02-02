using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.RigVMSDK
{
    public class RigVMUserWorkflowOptions : Object
    {
        public RigVMUserWorkflowOptions(nint addr) : base(addr) { }
        public Object Subject { get { return this[nameof(Subject)].As<Object>(); } set { this["Subject"] = value; } }
        public RigVMUserWorkflow Workflow { get { return this[nameof(Workflow)].As<RigVMUserWorkflow>(); } set { this["Workflow"] = value; } }
        public bool RequiresDialog() { return Invoke<bool>(nameof(RequiresDialog)); }
        public void ReportWarning(Object InMessage) { Invoke(nameof(ReportWarning), InMessage); }
        public void ReportInfo(Object InMessage) { Invoke(nameof(ReportInfo), InMessage); }
        public void ReportError(Object InMessage) { Invoke(nameof(ReportError), InMessage); }
        public bool IsValid() { return Invoke<bool>(nameof(IsValid)); }
    }
    public class RigVM : Object
    {
        public RigVM(nint addr) : base(addr) { }
        public RigVMMemoryStorage WorkMemoryStorageObject { get { return this[nameof(WorkMemoryStorageObject)].As<RigVMMemoryStorage>(); } set { this["WorkMemoryStorageObject"] = value; } }
        public RigVMMemoryStorage LiteralMemoryStorageObject { get { return this[nameof(LiteralMemoryStorageObject)].As<RigVMMemoryStorage>(); } set { this["LiteralMemoryStorageObject"] = value; } }
        public RigVMMemoryStorage DebugMemoryStorageObject { get { return this[nameof(DebugMemoryStorageObject)].As<RigVMMemoryStorage>(); } set { this["DebugMemoryStorageObject"] = value; } }
        public RigVMByteCode ByteCodeStorage { get { return this[nameof(ByteCodeStorage)].As<RigVMByteCode>(); } set { this["ByteCodeStorage"] = value; } }
        public RigVMInstructionArray Instructions { get { return this[nameof(Instructions)].As<RigVMInstructionArray>(); } set { this["Instructions"] = value; } }
        public RigVMExtendedExecuteContext Context { get { return this[nameof(Context)].As<RigVMExtendedExecuteContext>(); } set { this["Context"] = value; } }
        public uint NumExecutions { get { return this[nameof(NumExecutions)].GetValue<uint>(); } set { this[nameof(NumExecutions)].SetValue<uint>(value); } }
        public Array<Object> FunctionNamesStorage { get { return new Array<Object>(this[nameof(FunctionNamesStorage)].Address); } }
        public Array<RigVMParameter> Parameters { get { return new Array<RigVMParameter>(this[nameof(Parameters)].Address); } }
        public Object ParametersNameMap { get { return this[nameof(ParametersNameMap)]; } set { this[nameof(ParametersNameMap)] = value; } }
        public RigVM DeferredVMToCopy { get { return this[nameof(DeferredVMToCopy)].As<RigVM>(); } set { this["DeferredVMToCopy"] = value; } }
        public void SetParameterValueVector2D(Object InParameterName, Vector2D InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueVector2D), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueVector(Object InParameterName, Vector InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueVector), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueTransform(Object InParameterName, Transform InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueTransform), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueString(Object InParameterName, Object InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueString), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueQuat(Object InParameterName, Quat InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueQuat), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueName(Object InParameterName, Object InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueName), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueInt(Object InParameterName, int InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueInt), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueFloat(Object InParameterName, float InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueFloat), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueDouble(Object InParameterName, double InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueDouble), InParameterName, InValue, InArrayIndex); }
        public void SetParameterValueBool(Object InParameterName, bool InValue, int InArrayIndex) { Invoke(nameof(SetParameterValueBool), InParameterName, InValue, InArrayIndex); }
        public RigVMStatistics GetStatistics() { return Invoke<RigVMStatistics>(nameof(GetStatistics)); }
        public Object GetRigVMFunctionName(int InFunctionIndex) { return Invoke<Object>(nameof(GetRigVMFunctionName), InFunctionIndex); }
        public Vector2D GetParameterValueVector2D(Object InParameterName, int InArrayIndex) { return Invoke<Vector2D>(nameof(GetParameterValueVector2D), InParameterName, InArrayIndex); }
        public Vector GetParameterValueVector(Object InParameterName, int InArrayIndex) { return Invoke<Vector>(nameof(GetParameterValueVector), InParameterName, InArrayIndex); }
        public Transform GetParameterValueTransform(Object InParameterName, int InArrayIndex) { return Invoke<Transform>(nameof(GetParameterValueTransform), InParameterName, InArrayIndex); }
        public Object GetParameterValueString(Object InParameterName, int InArrayIndex) { return Invoke<Object>(nameof(GetParameterValueString), InParameterName, InArrayIndex); }
        public Quat GetParameterValueQuat(Object InParameterName, int InArrayIndex) { return Invoke<Quat>(nameof(GetParameterValueQuat), InParameterName, InArrayIndex); }
        public Object GetParameterValueName(Object InParameterName, int InArrayIndex) { return Invoke<Object>(nameof(GetParameterValueName), InParameterName, InArrayIndex); }
        public int GetParameterValueInt(Object InParameterName, int InArrayIndex) { return Invoke<int>(nameof(GetParameterValueInt), InParameterName, InArrayIndex); }
        public float GetParameterValueFloat(Object InParameterName, int InArrayIndex) { return Invoke<float>(nameof(GetParameterValueFloat), InParameterName, InArrayIndex); }
        public double GetParameterValueDouble(Object InParameterName, int InArrayIndex) { return Invoke<double>(nameof(GetParameterValueDouble), InParameterName, InArrayIndex); }
        public bool GetParameterValueBool(Object InParameterName, int InArrayIndex) { return Invoke<bool>(nameof(GetParameterValueBool), InParameterName, InArrayIndex); }
        public bool Execute(Object InEntryName) { return Invoke<bool>(nameof(Execute), InEntryName); }
        public int AddRigVMFunction(ScriptStruct InRigVMStruct, Object InMethodName) { return Invoke<int>(nameof(AddRigVMFunction), InRigVMStruct, InMethodName); }
    }
    public class RigVMMemoryStorageGeneratorClass : Class
    {
        public RigVMMemoryStorageGeneratorClass(nint addr) : base(addr) { }
    }
    public class RigVMMemoryStorage : Object
    {
        public RigVMMemoryStorage(nint addr) : base(addr) { }
    }
    public class RigVMNativized : RigVM
    {
        public RigVMNativized(nint addr) : base(addr) { }
    }
    public class RigVMRuntimeSettings : Object
    {
        public RigVMRuntimeSettings(nint addr) : base(addr) { }
        public int MaximumArraySize { get { return this[nameof(MaximumArraySize)].GetValue<int>(); } set { this[nameof(MaximumArraySize)].SetValue<int>(value); } }
    }
    public enum ERigVMPinDirection : int
    {
        Input = 0,
        Output = 1,
        IO = 2,
        Visible = 3,
        Hidden = 4,
        Invalid = 5,
        ERigVMPinDirection_MAX = 6,
    }
    public enum ERigVMBreakpointAction : int
    {
        None = 0,
        Resume = 1,
        StepOver = 2,
        StepInto = 3,
        StepOut = 4,
        Max = 5,
    }
    public enum ERigVMParameterType : int
    {
        Input = 0,
        Output = 1,
        Invalid = 2,
        ERigVMParameterType_MAX = 3,
    }
    public enum ERigVMOpCode : int
    {
        Execute_0_Operands = 0,
        Execute_1_Operands = 1,
        Execute_2_Operands = 2,
        Execute_3_Operands = 3,
        Execute_4_Operands = 4,
        Execute_5_Operands = 5,
        Execute_6_Operands = 6,
        Execute_7_Operands = 7,
        Execute_8_Operands = 8,
        Execute_9_Operands = 9,
        Execute_10_Operands = 10,
        Execute_11_Operands = 11,
        Execute_12_Operands = 12,
        Execute_13_Operands = 13,
        Execute_14_Operands = 14,
        Execute_15_Operands = 15,
        Execute_16_Operands = 16,
        Execute_17_Operands = 17,
        Execute_18_Operands = 18,
        Execute_19_Operands = 19,
        Execute_20_Operands = 20,
        Execute_21_Operands = 21,
        Execute_22_Operands = 22,
        Execute_23_Operands = 23,
        Execute_24_Operands = 24,
        Execute_25_Operands = 25,
        Execute_26_Operands = 26,
        Execute_27_Operands = 27,
        Execute_28_Operands = 28,
        Execute_29_Operands = 29,
        Execute_30_Operands = 30,
        Execute_31_Operands = 31,
        Execute_32_Operands = 32,
        Execute_33_Operands = 33,
        Execute_34_Operands = 34,
        Execute_35_Operands = 35,
        Execute_36_Operands = 36,
        Execute_37_Operands = 37,
        Execute_38_Operands = 38,
        Execute_39_Operands = 39,
        Execute_40_Operands = 40,
        Execute_41_Operands = 41,
        Execute_42_Operands = 42,
        Execute_43_Operands = 43,
        Execute_44_Operands = 44,
        Execute_45_Operands = 45,
        Execute_46_Operands = 46,
        Execute_47_Operands = 47,
        Execute_48_Operands = 48,
        Execute_49_Operands = 49,
        Execute_50_Operands = 50,
        Execute_51_Operands = 51,
        Execute_52_Operands = 52,
        Execute_53_Operands = 53,
        Execute_54_Operands = 54,
        Execute_55_Operands = 55,
        Execute_56_Operands = 56,
        Execute_57_Operands = 57,
        Execute_58_Operands = 58,
        Execute_59_Operands = 59,
        Execute_60_Operands = 60,
        Execute_61_Operands = 61,
        Execute_62_Operands = 62,
        Execute_63_Operands = 63,
        Execute_64_Operands = 64,
        Zero = 65,
        BoolFalse = 66,
        BoolTrue = 67,
        Copy = 68,
        Increment = 69,
        Decrement = 70,
        Equals = 71,
        NotEquals = 72,
        JumpAbsolute = 73,
        JumpForward = 74,
        JumpBackward = 75,
        JumpAbsoluteIf = 76,
        JumpForwardIf = 77,
        JumpBackwardIf = 78,
        ChangeType = 79,
        Exit = 80,
        BeginBlock = 81,
        EndBlock = 82,
        ArrayReset = 83,
        ArrayGetNum = 84,
        ArraySetNum = 85,
        ArrayGetAtIndex = 86,
        ArraySetAtIndex = 87,
        ArrayAdd = 88,
        ArrayInsert = 89,
        ArrayRemove = 90,
        ArrayFind = 91,
        ArrayAppend = 92,
        ArrayClone = 93,
        ArrayIterator = 94,
        ArrayUnion = 95,
        ArrayDifference = 96,
        ArrayIntersection = 97,
        ArrayReverse = 98,
        InvokeEntry = 99,
        Invalid = 100,
        FirstArrayOpCode = 83,
        LastArrayOpCode = 98,
        ERigVMOpCode_MAX = 101,
    }
    public enum ERigVMCopyType : int
    {
        Default = 0,
        FloatToDouble = 1,
        DoubleToFloat = 2,
        ERigVMCopyType_MAX = 3,
    }
    public enum ERigVMMemoryType : int
    {
        Work = 0,
        Literal = 1,
        External = 2,
        Debug = 3,
        Invalid = 4,
        ERigVMMemoryType_MAX = 5,
    }
    public enum ERigVMRegisterType : int
    {
        Plain = 0,
        String = 1,
        Name = 2,
        Struct = 3,
        Invalid = 4,
        ERigVMRegisterType_MAX = 5,
    }
    public enum ERigVMUserWorkflowType : int
    {
        Invalid = 0,
        NodeContext = 1,
        PinContext = 2,
        OnPinDefaultChanged = 4,
        All = 7,
        ERigVMUserWorkflowType_MAX = 8,
    }
    public class RigVMStruct : Object
    {
        public RigVMStruct(nint addr) : base(addr) { }
    }
    public class RigVMExecuteContext : Object
    {
        public RigVMExecuteContext(nint addr) : base(addr) { }
    }
    public class RigVMDispatchFactory : Object
    {
        public RigVMDispatchFactory(nint addr) : base(addr) { }
    }
    public class RigVMUnknownType : Object
    {
        public RigVMUnknownType(nint addr) : base(addr) { }
        public uint Hash { get { return this[nameof(Hash)].GetValue<uint>(); } set { this[nameof(Hash)].SetValue<uint>(value); } }
    }
    public class RigVMMemoryStatistics : Object
    {
        public RigVMMemoryStatistics(nint addr) : base(addr) { }
        public int RegisterCount { get { return this[nameof(RegisterCount)].GetValue<int>(); } set { this[nameof(RegisterCount)].SetValue<int>(value); } }
        public int DataBytes { get { return this[nameof(DataBytes)].GetValue<int>(); } set { this[nameof(DataBytes)].SetValue<int>(value); } }
        public int TotalBytes { get { return this[nameof(TotalBytes)].GetValue<int>(); } set { this[nameof(TotalBytes)].SetValue<int>(value); } }
    }
    public class RigVMByteCodeStatistics : Object
    {
        public RigVMByteCodeStatistics(nint addr) : base(addr) { }
        public int InstructionCount { get { return this[nameof(InstructionCount)].GetValue<int>(); } set { this[nameof(InstructionCount)].SetValue<int>(value); } }
        public int DataBytes { get { return this[nameof(DataBytes)].GetValue<int>(); } set { this[nameof(DataBytes)].SetValue<int>(value); } }
    }
    public class RigVMStatistics : Object
    {
        public RigVMStatistics(nint addr) : base(addr) { }
        public int BytesForCDO { get { return this[nameof(BytesForCDO)].GetValue<int>(); } set { this[nameof(BytesForCDO)].SetValue<int>(value); } }
        public int BytesPerInstance { get { return this[nameof(BytesPerInstance)].GetValue<int>(); } set { this[nameof(BytesPerInstance)].SetValue<int>(value); } }
        public RigVMMemoryStatistics LiteralMemory { get { return this[nameof(LiteralMemory)].As<RigVMMemoryStatistics>(); } set { this["LiteralMemory"] = value; } }
        public RigVMMemoryStatistics WorkMemory { get { return this[nameof(WorkMemory)].As<RigVMMemoryStatistics>(); } set { this["WorkMemory"] = value; } }
        public RigVMMemoryStatistics DebugMemory { get { return this[nameof(DebugMemory)].As<RigVMMemoryStatistics>(); } set { this["DebugMemory"] = value; } }
        public int BytesForCaching { get { return this[nameof(BytesForCaching)].GetValue<int>(); } set { this[nameof(BytesForCaching)].SetValue<int>(value); } }
        public RigVMByteCodeStatistics ByteCode { get { return this[nameof(ByteCode)].As<RigVMByteCodeStatistics>(); } set { this["ByteCode"] = value; } }
    }
    public class RigVMParameter : Object
    {
        public RigVMParameter(nint addr) : base(addr) { }
        public ERigVMParameterType Type { get { return (ERigVMParameterType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int RegisterIndex { get { return this[nameof(RegisterIndex)].GetValue<int>(); } set { this[nameof(RegisterIndex)].SetValue<int>(value); } }
        public Object CPPType { get { return this[nameof(CPPType)]; } set { this[nameof(CPPType)] = value; } }
        public ScriptStruct ScriptStruct { get { return this[nameof(ScriptStruct)].As<ScriptStruct>(); } set { this["ScriptStruct"] = value; } }
        public Object ScriptStructPath { get { return this[nameof(ScriptStructPath)]; } set { this[nameof(ScriptStructPath)] = value; } }
    }
    public class RigVMBaseOp : Object
    {
        public RigVMBaseOp(nint addr) : base(addr) { }
    }
    public class RigVMExecuteOp : RigVMBaseOp
    {
        public RigVMExecuteOp(nint addr) : base(addr) { }
    }
    public class RigVMUnaryOp : RigVMBaseOp
    {
        public RigVMUnaryOp(nint addr) : base(addr) { }
    }
    public class RigVMBinaryOp : RigVMBaseOp
    {
        public RigVMBinaryOp(nint addr) : base(addr) { }
    }
    public class RigVMTernaryOp : RigVMBaseOp
    {
        public RigVMTernaryOp(nint addr) : base(addr) { }
    }
    public class RigVMQuaternaryOp : RigVMBaseOp
    {
        public RigVMQuaternaryOp(nint addr) : base(addr) { }
    }
    public class RigVMQuinaryOp : RigVMBaseOp
    {
        public RigVMQuinaryOp(nint addr) : base(addr) { }
    }
    public class RigVMSenaryOp : RigVMBaseOp
    {
        public RigVMSenaryOp(nint addr) : base(addr) { }
    }
    public class RigVMCopyOp : RigVMBaseOp
    {
        public RigVMCopyOp(nint addr) : base(addr) { }
    }
    public class RigVMComparisonOp : RigVMBaseOp
    {
        public RigVMComparisonOp(nint addr) : base(addr) { }
    }
    public class RigVMJumpOp : RigVMBaseOp
    {
        public RigVMJumpOp(nint addr) : base(addr) { }
    }
    public class RigVMJumpIfOp : RigVMUnaryOp
    {
        public RigVMJumpIfOp(nint addr) : base(addr) { }
    }
    public class RigVMChangeTypeOp : RigVMUnaryOp
    {
        public RigVMChangeTypeOp(nint addr) : base(addr) { }
    }
    public class RigVMInvokeEntryOp : RigVMBaseOp
    {
        public RigVMInvokeEntryOp(nint addr) : base(addr) { }
    }
    public class RigVMInstruction : Object
    {
        public RigVMInstruction(nint addr) : base(addr) { }
        public ulong ByteCodeIndex { get { return this[nameof(ByteCodeIndex)].GetValue<ulong>(); } set { this[nameof(ByteCodeIndex)].SetValue<ulong>(value); } }
        public ERigVMOpCode OpCode { get { return (ERigVMOpCode)this[nameof(OpCode)].GetValue<int>(); } set { this[nameof(OpCode)].SetValue<int>((int)value); } }
        public byte OperandAlignment { get { return this[nameof(OperandAlignment)].GetValue<byte>(); } set { this[nameof(OperandAlignment)].SetValue<byte>(value); } }
    }
    public class RigVMInstructionArray : Object
    {
        public RigVMInstructionArray(nint addr) : base(addr) { }
        public Array<RigVMInstruction> Instructions { get { return new Array<RigVMInstruction>(this[nameof(Instructions)].Address); } }
    }
    public class RigVMByteCodeEntry : Object
    {
        public RigVMByteCodeEntry(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int InstructionIndex { get { return this[nameof(InstructionIndex)].GetValue<int>(); } set { this[nameof(InstructionIndex)].SetValue<int>(value); } }
    }
    public class RigVMByteCode : Object
    {
        public RigVMByteCode(nint addr) : base(addr) { }
        public Array<byte> ByteCode { get { return new Array<byte>(this[nameof(ByteCode)].Address); } }
        public int NumInstructions { get { return this[nameof(NumInstructions)].GetValue<int>(); } set { this[nameof(NumInstructions)].SetValue<int>(value); } }
        public Array<RigVMByteCodeEntry> Entries { get { return new Array<RigVMByteCodeEntry>(this[nameof(Entries)].Address); } }
    }
    public class RigVMBreakpoint : Object
    {
        public RigVMBreakpoint(nint addr) : base(addr) { }
    }
    public class RigVMDebugInfo : Object
    {
        public RigVMDebugInfo(nint addr) : base(addr) { }
    }
    public class RigVMSlice : Object
    {
        public RigVMSlice(nint addr) : base(addr) { }
    }
    public class RigVMExtendedExecuteContext : Object
    {
        public RigVMExtendedExecuteContext(nint addr) : base(addr) { }
    }
    public class RigVMOperand : Object
    {
        public RigVMOperand(nint addr) : base(addr) { }
        public ERigVMMemoryType MemoryType { get { return (ERigVMMemoryType)this[nameof(MemoryType)].GetValue<int>(); } set { this[nameof(MemoryType)].SetValue<int>((int)value); } }
        public ushort RegisterIndex { get { return this[nameof(RegisterIndex)].GetValue<ushort>(); } set { this[nameof(RegisterIndex)].SetValue<ushort>(value); } }
        public ushort RegisterOffset { get { return this[nameof(RegisterOffset)].GetValue<ushort>(); } set { this[nameof(RegisterOffset)].SetValue<ushort>(value); } }
    }
    public class RigVMRegister : Object
    {
        public RigVMRegister(nint addr) : base(addr) { }
        public ERigVMRegisterType Type { get { return (ERigVMRegisterType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public uint ByteIndex { get { return this[nameof(ByteIndex)].GetValue<uint>(); } set { this[nameof(ByteIndex)].SetValue<uint>(value); } }
        public ushort ElementSize { get { return this[nameof(ElementSize)].GetValue<ushort>(); } set { this[nameof(ElementSize)].SetValue<ushort>(value); } }
        public ushort ElementCount { get { return this[nameof(ElementCount)].GetValue<ushort>(); } set { this[nameof(ElementCount)].SetValue<ushort>(value); } }
        public ushort SliceCount { get { return this[nameof(SliceCount)].GetValue<ushort>(); } set { this[nameof(SliceCount)].SetValue<ushort>(value); } }
        public byte AlignmentBytes { get { return this[nameof(AlignmentBytes)].GetValue<byte>(); } set { this[nameof(AlignmentBytes)].SetValue<byte>(value); } }
        public ushort TrailingBytes { get { return this[nameof(TrailingBytes)].GetValue<ushort>(); } set { this[nameof(TrailingBytes)].SetValue<ushort>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int ScriptStructIndex { get { return this[nameof(ScriptStructIndex)].GetValue<int>(); } set { this[nameof(ScriptStructIndex)].SetValue<int>(value); } }
        public bool bIsArray { get { return this[nameof(bIsArray)].Flag; } set { this[nameof(bIsArray)].Flag = value; } }
        public bool bIsDynamic { get { return this[nameof(bIsDynamic)].Flag; } set { this[nameof(bIsDynamic)].Flag = value; } }
    }
    public class RigVMRegisterOffset : Object
    {
        public RigVMRegisterOffset(nint addr) : base(addr) { }
        public Array<int> Segments { get { return new Array<int>(this[nameof(Segments)].Address); } }
        public ERigVMRegisterType Type { get { return (ERigVMRegisterType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object CPPType { get { return this[nameof(CPPType)]; } set { this[nameof(CPPType)] = value; } }
        public ScriptStruct ScriptStruct { get { return this[nameof(ScriptStruct)].As<ScriptStruct>(); } set { this["ScriptStruct"] = value; } }
        public ScriptStruct ParentScriptStruct { get { return this[nameof(ParentScriptStruct)].As<ScriptStruct>(); } set { this["ParentScriptStruct"] = value; } }
        public int ArrayIndex { get { return this[nameof(ArrayIndex)].GetValue<int>(); } set { this[nameof(ArrayIndex)].SetValue<int>(value); } }
        public ushort ElementSize { get { return this[nameof(ElementSize)].GetValue<ushort>(); } set { this[nameof(ElementSize)].SetValue<ushort>(value); } }
        public Object CachedSegmentPath { get { return this[nameof(CachedSegmentPath)]; } set { this[nameof(CachedSegmentPath)] = value; } }
    }
    public class RigVMMemoryContainer : Object
    {
        public RigVMMemoryContainer(nint addr) : base(addr) { }
        public bool bUseNameMap { get { return this[nameof(bUseNameMap)].Flag; } set { this[nameof(bUseNameMap)].Flag = value; } }
        public ERigVMMemoryType MemoryType { get { return (ERigVMMemoryType)this[nameof(MemoryType)].GetValue<int>(); } set { this[nameof(MemoryType)].SetValue<int>((int)value); } }
        public Array<RigVMRegister> Registers { get { return new Array<RigVMRegister>(this[nameof(Registers)].Address); } }
        public Array<RigVMRegisterOffset> RegisterOffsets { get { return new Array<RigVMRegisterOffset>(this[nameof(RegisterOffsets)].Address); } }
        public Array<byte> Data { get { return new Array<byte>(this[nameof(Data)].Address); } }
        public Array<ScriptStruct> ScriptStructs { get { return new Array<ScriptStruct>(this[nameof(ScriptStructs)].Address); } }
        public Object NameMap { get { return this[nameof(NameMap)]; } set { this[nameof(NameMap)] = value; } }
        public bool bEncounteredErrorDuringLoad { get { return this[nameof(bEncounteredErrorDuringLoad)].Flag; } set { this[nameof(bEncounteredErrorDuringLoad)].Flag = value; } }
    }
    public class RigVMTemplateArgumentType : Object
    {
        public RigVMTemplateArgumentType(nint addr) : base(addr) { }
        public Object CPPType { get { return this[nameof(CPPType)]; } set { this[nameof(CPPType)] = value; } }
        public Object CPPTypeObject { get { return this[nameof(CPPTypeObject)].As<Object>(); } set { this["CPPTypeObject"] = value; } }
    }
    public class RigVMUserWorkflow : Object
    {
        public RigVMUserWorkflow(nint addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Tooltip { get { return this[nameof(Tooltip)]; } set { this[nameof(Tooltip)] = value; } }
        public ERigVMUserWorkflowType Type { get { return (ERigVMUserWorkflowType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object PerformDynamicDelegate { get { return this[nameof(PerformDynamicDelegate)]; } set { this[nameof(PerformDynamicDelegate)] = value; } }
        public Object OptionsClass { get { return this[nameof(OptionsClass)].As<Object>(); } set { this["OptionsClass"] = value; } } // ClassPtrProperty
    }
}
