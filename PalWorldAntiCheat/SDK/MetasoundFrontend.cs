using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MetasoundFrontendSDK
{
    public enum EMetasoundFrontendVertexAccessType : int
    {
        Reference = 0,
        Value = 1,
        Unset = 2,
        EMetasoundFrontendVertexAccessType_MAX = 3,
    }
    public enum EMetasoundFrontendClassType : int
    {
        External = 0,
        Graph = 1,
        Input = 2,
        Output = 3,
        Literal = 4,
        Variable = 5,
        VariableDeferredAccessor = 6,
        VariableAccessor = 7,
        VariableMutator = 8,
        Template = 9,
        Invalid = 10,
        EMetasoundFrontendClassType_MAX = 11,
    }
    public enum EMetasoundFrontendNodeStyleDisplayVisibility : int
    {
        Visible = 0,
        Hidden = 1,
        EMetasoundFrontendNodeStyleDisplayVisibility_MAX = 2,
    }
    public enum EMetasoundFrontendLiteralType : int
    {
        None = 0,
        Boolean = 1,
        Integer = 2,
        Float = 3,
        String = 4,
        UObject = 5,
        NoneArray = 6,
        BooleanArray = 7,
        IntegerArray = 8,
        FloatArray = 9,
        StringArray = 10,
        UObjectArray = 11,
        Invalid = 12,
        EMetasoundFrontendLiteralType_MAX = 13,
    }
    public class MetasoundFrontendVersionNumber : Object
    {
        public MetasoundFrontendVersionNumber(nint addr) : base(addr) { }
        public int Major { get { return this[nameof(Major)].GetValue<int>(); } set { this[nameof(Major)].SetValue<int>(value); } }
        public int Minor { get { return this[nameof(Minor)].GetValue<int>(); } set { this[nameof(Minor)].SetValue<int>(value); } }
    }
    public class MetasoundFrontendVersion : Object
    {
        public MetasoundFrontendVersion(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public MetasoundFrontendVersionNumber Number { get { return this[nameof(Number)].As<MetasoundFrontendVersionNumber>(); } set { this["Number"] = value; } }
    }
    public class MetasoundFrontendVertex : Object
    {
        public MetasoundFrontendVertex(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object TypeName { get { return this[nameof(TypeName)]; } set { this[nameof(TypeName)] = value; } }
        public Guid VertexID { get { return this[nameof(VertexID)].As<Guid>(); } set { this["VertexID"] = value; } }
    }
    public class MetasoundFrontendVertexLiteral : Object
    {
        public MetasoundFrontendVertexLiteral(nint addr) : base(addr) { }
        public Guid VertexID { get { return this[nameof(VertexID)].As<Guid>(); } set { this["VertexID"] = value; } }
        public MetasoundFrontendLiteral Value { get { return this[nameof(Value)].As<MetasoundFrontendLiteral>(); } set { this["Value"] = value; } }
    }
    public class MetasoundFrontendLiteral : Object
    {
        public MetasoundFrontendLiteral(nint addr) : base(addr) { }
        public EMetasoundFrontendLiteralType Type { get { return (EMetasoundFrontendLiteralType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int AsNumDefault { get { return this[nameof(AsNumDefault)].GetValue<int>(); } set { this[nameof(AsNumDefault)].SetValue<int>(value); } }
        public Array<bool> AsBoolean { get { return new Array<bool>(this[nameof(AsBoolean)].Address); } }
        public Array<int> AsInteger { get { return new Array<int>(this[nameof(AsInteger)].Address); } }
        public Array<float> AsFloat { get { return new Array<float>(this[nameof(AsFloat)].Address); } }
        public Array<Object> AsString { get { return new Array<Object>(this[nameof(AsString)].Address); } }
        public Array<Object> AsUObject { get { return new Array<Object>(this[nameof(AsUObject)].Address); } }
    }
    public class MetasoundFrontendVariable : Object
    {
        public MetasoundFrontendVariable(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object TypeName { get { return this[nameof(TypeName)]; } set { this[nameof(TypeName)] = value; } }
        public MetasoundFrontendLiteral Literal { get { return this[nameof(Literal)].As<MetasoundFrontendLiteral>(); } set { this["Literal"] = value; } }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Guid VariableNodeID { get { return this[nameof(VariableNodeID)].As<Guid>(); } set { this["VariableNodeID"] = value; } }
        public Guid MutatorNodeID { get { return this[nameof(MutatorNodeID)].As<Guid>(); } set { this["MutatorNodeID"] = value; } }
        public Array<Guid> AccessorNodeIDs { get { return new Array<Guid>(this[nameof(AccessorNodeIDs)].Address); } }
        public Array<Guid> DeferredAccessorNodeIDs { get { return new Array<Guid>(this[nameof(DeferredAccessorNodeIDs)].Address); } }
    }
    public class MetasoundFrontendNodeInterface : Object
    {
        public MetasoundFrontendNodeInterface(nint addr) : base(addr) { }
        public Array<MetasoundFrontendVertex> Inputs { get { return new Array<MetasoundFrontendVertex>(this[nameof(Inputs)].Address); } }
        public Array<MetasoundFrontendVertex> Outputs { get { return new Array<MetasoundFrontendVertex>(this[nameof(Outputs)].Address); } }
        public Array<MetasoundFrontendVertex> Environment { get { return new Array<MetasoundFrontendVertex>(this[nameof(Environment)].Address); } }
    }
    public class MetasoundFrontendNodeStyleDisplay : Object
    {
        public MetasoundFrontendNodeStyleDisplay(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendNodeStyle : Object
    {
        public MetasoundFrontendNodeStyle(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendNode : Object
    {
        public MetasoundFrontendNode(nint addr) : base(addr) { }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Guid ClassID { get { return this[nameof(ClassID)].As<Guid>(); } set { this["ClassID"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public MetasoundFrontendNodeInterface Interface { get { return this[nameof(Interface)].As<MetasoundFrontendNodeInterface>(); } set { this["Interface"] = value; } }
        public Array<MetasoundFrontendVertexLiteral> InputLiterals { get { return new Array<MetasoundFrontendVertexLiteral>(this[nameof(InputLiterals)].Address); } }
    }
    public class MetasoundFrontendEdge : Object
    {
        public MetasoundFrontendEdge(nint addr) : base(addr) { }
        public Guid FromNodeID { get { return this[nameof(FromNodeID)].As<Guid>(); } set { this["FromNodeID"] = value; } }
        public Guid FromVertexID { get { return this[nameof(FromVertexID)].As<Guid>(); } set { this["FromVertexID"] = value; } }
        public Guid ToNodeID { get { return this[nameof(ToNodeID)].As<Guid>(); } set { this["ToNodeID"] = value; } }
        public Guid ToVertexID { get { return this[nameof(ToVertexID)].As<Guid>(); } set { this["ToVertexID"] = value; } }
    }
    public class MetasoundFrontendEdgeStyleLiteralColorPair : Object
    {
        public MetasoundFrontendEdgeStyleLiteralColorPair(nint addr) : base(addr) { }
        public MetasoundFrontendLiteral Value { get { return this[nameof(Value)].As<MetasoundFrontendLiteral>(); } set { this["Value"] = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
    }
    public class MetasoundFrontendEdgeStyle : Object
    {
        public MetasoundFrontendEdgeStyle(nint addr) : base(addr) { }
        public Guid NodeID { get { return this[nameof(NodeID)].As<Guid>(); } set { this["NodeID"] = value; } }
        public Object OutputName { get { return this[nameof(OutputName)]; } set { this[nameof(OutputName)] = value; } }
        public Array<MetasoundFrontendEdgeStyleLiteralColorPair> LiteralColorPairs { get { return new Array<MetasoundFrontendEdgeStyleLiteralColorPair>(this[nameof(LiteralColorPairs)].Address); } }
    }
    public class MetasoundFrontendGraphStyle : Object
    {
        public MetasoundFrontendGraphStyle(nint addr) : base(addr) { }
        public bool bIsGraphEditable { get { return this[nameof(bIsGraphEditable)].Flag; } set { this[nameof(bIsGraphEditable)].Flag = value; } }
        public Array<MetasoundFrontendEdgeStyle> EdgeStyles { get { return new Array<MetasoundFrontendEdgeStyle>(this[nameof(EdgeStyles)].Address); } }
    }
    public class MetasoundFrontendGraph : Object
    {
        public MetasoundFrontendGraph(nint addr) : base(addr) { }
        public Array<MetasoundFrontendNode> Nodes { get { return new Array<MetasoundFrontendNode>(this[nameof(Nodes)].Address); } }
        public Array<MetasoundFrontendEdge> Edges { get { return new Array<MetasoundFrontendEdge>(this[nameof(Edges)].Address); } }
        public Array<MetasoundFrontendVariable> Variables { get { return new Array<MetasoundFrontendVariable>(this[nameof(Variables)].Address); } }
    }
    public class MetasoundFrontendVertexMetadata : Object
    {
        public MetasoundFrontendVertexMetadata(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendClassVertex : MetasoundFrontendVertex
    {
        public MetasoundFrontendClassVertex(nint addr) : base(addr) { }
        public Guid NodeID { get { return this[nameof(NodeID)].As<Guid>(); } set { this["NodeID"] = value; } }
        public EMetasoundFrontendVertexAccessType AccessType { get { return (EMetasoundFrontendVertexAccessType)this[nameof(AccessType)].GetValue<int>(); } set { this[nameof(AccessType)].SetValue<int>((int)value); } }
    }
    public class MetasoundFrontendClassStyleDisplay : Object
    {
        public MetasoundFrontendClassStyleDisplay(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendClassInput : MetasoundFrontendClassVertex
    {
        public MetasoundFrontendClassInput(nint addr) : base(addr) { }
        public MetasoundFrontendLiteral DefaultLiteral { get { return this[nameof(DefaultLiteral)].As<MetasoundFrontendLiteral>(); } set { this["DefaultLiteral"] = value; } }
    }
    public class MetasoundFrontendClassVariable : MetasoundFrontendClassVertex
    {
        public MetasoundFrontendClassVariable(nint addr) : base(addr) { }
        public MetasoundFrontendLiteral DefaultLiteral { get { return this[nameof(DefaultLiteral)].As<MetasoundFrontendLiteral>(); } set { this["DefaultLiteral"] = value; } }
    }
    public class MetasoundFrontendClassOutput : MetasoundFrontendClassVertex
    {
        public MetasoundFrontendClassOutput(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendClassEnvironmentVariable : Object
    {
        public MetasoundFrontendClassEnvironmentVariable(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object TypeName { get { return this[nameof(TypeName)]; } set { this[nameof(TypeName)] = value; } }
        public bool bIsRequired { get { return this[nameof(bIsRequired)].Flag; } set { this[nameof(bIsRequired)].Flag = value; } }
    }
    public class MetasoundFrontendInterfaceStyle : Object
    {
        public MetasoundFrontendInterfaceStyle(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendClassInterface : Object
    {
        public MetasoundFrontendClassInterface(nint addr) : base(addr) { }
        public Array<MetasoundFrontendClassInput> Inputs { get { return new Array<MetasoundFrontendClassInput>(this[nameof(Inputs)].Address); } }
        public Array<MetasoundFrontendClassOutput> Outputs { get { return new Array<MetasoundFrontendClassOutput>(this[nameof(Outputs)].Address); } }
        public Array<MetasoundFrontendClassEnvironmentVariable> Environment { get { return new Array<MetasoundFrontendClassEnvironmentVariable>(this[nameof(Environment)].Address); } }
        public Guid ChangeID { get { return this[nameof(ChangeID)].As<Guid>(); } set { this["ChangeID"] = value; } }
    }
    public class MetasoundFrontendInterface : MetasoundFrontendClassInterface
    {
        public MetasoundFrontendInterface(nint addr) : base(addr) { }
        public MetasoundFrontendVersion Version { get { return this[nameof(Version)].As<MetasoundFrontendVersion>(); } set { this["Version"] = value; } }
    }
    public class MetasoundFrontendClassName : Object
    {
        public MetasoundFrontendClassName(nint addr) : base(addr) { }
        public Object Namespace { get { return this[nameof(Namespace)]; } set { this[nameof(Namespace)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Variant { get { return this[nameof(Variant)]; } set { this[nameof(Variant)] = value; } }
    }
    public class MetasoundFrontendClassMetadata : Object
    {
        public MetasoundFrontendClassMetadata(nint addr) : base(addr) { }
        public MetasoundFrontendClassName ClassName { get { return this[nameof(ClassName)].As<MetasoundFrontendClassName>(); } set { this["ClassName"] = value; } }
        public MetasoundFrontendVersionNumber Version { get { return this[nameof(Version)].As<MetasoundFrontendVersionNumber>(); } set { this["Version"] = value; } }
        public EMetasoundFrontendClassType Type { get { return (EMetasoundFrontendClassType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bIsDeprecated { get { return this[nameof(bIsDeprecated)].Flag; } set { this[nameof(bIsDeprecated)].Flag = value; } }
        public bool bAutoUpdateManagesInterface { get { return this[nameof(bAutoUpdateManagesInterface)].Flag; } set { this[nameof(bAutoUpdateManagesInterface)].Flag = value; } }
        public Guid ChangeID { get { return this[nameof(ChangeID)].As<Guid>(); } set { this["ChangeID"] = value; } }
    }
    public class MetasoundFrontendClassStyle : Object
    {
        public MetasoundFrontendClassStyle(nint addr) : base(addr) { }
    }
    public class MetasoundFrontendClass : Object
    {
        public MetasoundFrontendClass(nint addr) : base(addr) { }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public MetasoundFrontendClassMetadata MetaData { get { return this[nameof(MetaData)].As<MetasoundFrontendClassMetadata>(); } set { this["MetaData"] = value; } }
        public MetasoundFrontendClassInterface Interface { get { return this[nameof(Interface)].As<MetasoundFrontendClassInterface>(); } set { this["Interface"] = value; } }
    }
    public class MetasoundFrontendGraphClassPresetOptions : Object
    {
        public MetasoundFrontendGraphClassPresetOptions(nint addr) : base(addr) { }
        public bool bIsPreset { get { return this[nameof(bIsPreset)].Flag; } set { this[nameof(bIsPreset)].Flag = value; } }
        public Object InputsInheritingDefault { get { return this[nameof(InputsInheritingDefault)]; } set { this[nameof(InputsInheritingDefault)] = value; } }
    }
    public class MetasoundFrontendGraphClass : MetasoundFrontendClass
    {
        public MetasoundFrontendGraphClass(nint addr) : base(addr) { }
        public MetasoundFrontendGraph Graph { get { return this[nameof(Graph)].As<MetasoundFrontendGraph>(); } set { this["Graph"] = value; } }
        public MetasoundFrontendGraphClassPresetOptions PresetOptions { get { return this[nameof(PresetOptions)].As<MetasoundFrontendGraphClassPresetOptions>(); } set { this["PresetOptions"] = value; } }
    }
    public class MetasoundFrontendDocumentMetadata : Object
    {
        public MetasoundFrontendDocumentMetadata(nint addr) : base(addr) { }
        public MetasoundFrontendVersion Version { get { return this[nameof(Version)].As<MetasoundFrontendVersion>(); } set { this["Version"] = value; } }
    }
    public class MetasoundFrontendDocument : Object
    {
        public MetasoundFrontendDocument(nint addr) : base(addr) { }
        public MetasoundFrontendDocumentMetadata MetaData { get { return this[nameof(MetaData)].As<MetasoundFrontendDocumentMetadata>(); } set { this["MetaData"] = value; } }
        public Object Interfaces { get { return this[nameof(Interfaces)]; } set { this[nameof(Interfaces)] = value; } }
        public MetasoundFrontendGraphClass RootGraph { get { return this[nameof(RootGraph)].As<MetasoundFrontendGraphClass>(); } set { this["RootGraph"] = value; } }
        public Array<MetasoundFrontendGraphClass> Subgraphs { get { return new Array<MetasoundFrontendGraphClass>(this[nameof(Subgraphs)].Address); } }
        public Array<MetasoundFrontendClass> Dependencies { get { return new Array<MetasoundFrontendClass>(this[nameof(Dependencies)].Address); } }
        public MetasoundFrontendVersion ArchetypeVersion { get { return this[nameof(ArchetypeVersion)].As<MetasoundFrontendVersion>(); } set { this["ArchetypeVersion"] = value; } }
        public Array<MetasoundFrontendVersion> InterfaceVersions { get { return new Array<MetasoundFrontendVersion>(this[nameof(InterfaceVersions)].Address); } }
    }
}
