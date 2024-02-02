using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TypedElementRuntimeSDK
{
    public class TypedElementSelectionSetLibrary : Object
    {
        public TypedElementSelectionSetLibrary(nint addr) : base(addr) { }
        //public bool SetSelectionFromList(TypedElementSelectionSet SelectionSet, ScriptTypedElementListProxy ElementList, TypedElementSelectionOptions SelectionOptions) { return Invoke<bool>(nameof(SetSelectionFromList), SelectionSet, ElementList, SelectionOptions); }
        //public bool SelectElementsFromList(TypedElementSelectionSet SelectionSet, ScriptTypedElementListProxy ElementList, TypedElementSelectionOptions SelectionOptions) { return Invoke<bool>(nameof(SelectElementsFromList), SelectionSet, ElementList, SelectionOptions); }
        //public ScriptTypedElementListProxy GetNormalizedSelection(TypedElementSelectionSet SelectionSet, TypedElementSelectionNormalizationOptions NormalizationOptions) { return Invoke<ScriptTypedElementListProxy>(nameof(GetNormalizedSelection), SelectionSet, NormalizationOptions); }
        //public ScriptTypedElementListProxy GetNormalizedElementList(TypedElementSelectionSet SelectionSet, ScriptTypedElementListProxy ElementList, TypedElementSelectionNormalizationOptions NormalizationOptions) { return Invoke<ScriptTypedElementListProxy>(nameof(GetNormalizedElementList), SelectionSet, ElementList, NormalizationOptions); }
        //public bool DeselectElementsFromList(TypedElementSelectionSet SelectionSet, ScriptTypedElementListProxy ElementList, TypedElementSelectionOptions SelectionOptions) { return Invoke<bool>(nameof(DeselectElementsFromList), SelectionSet, ElementList, SelectionOptions); }
    }
    public class TypedElementSelectionSet : Object
    {
        public TypedElementSelectionSet(nint addr) : base(addr) { }
        public Object OnPreSelectionChange { get { return this[nameof(OnPreSelectionChange)]; } set { this[nameof(OnPreSelectionChange)] = value; } }
        public Object OnSelectionChange { get { return this[nameof(OnSelectionChange)]; } set { this[nameof(OnSelectionChange)] = value; } }
        //public bool SetSelection(Array<ScriptTypedElementHandle> InElementHandles, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(SetSelection), InElementHandles, InSelectionOptions); }
        //public bool SelectElements(Array<ScriptTypedElementHandle> InElementHandles, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(SelectElements), InElementHandles, InSelectionOptions); }
        //public bool SelectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(SelectElement), InElementHandle, InSelectionOptions); }
        public void RestoreSelectionState(TypedElementSelectionSetState InSelectionState) { Invoke(nameof(RestoreSelectionState), InSelectionState); }
        public void OnPreChangeDynamic__DelegateSignature(TypedElementSelectionSet SelectionSet) { Invoke(nameof(OnPreChangeDynamic__DelegateSignature), SelectionSet); }
        public void OnChangeDynamic__DelegateSignature(TypedElementSelectionSet SelectionSet) { Invoke(nameof(OnChangeDynamic__DelegateSignature), SelectionSet); }
        //public Array<ScriptTypedElementHandle> K2_GetSelectedElementHandles(Object InBaseInterfaceType) { return Invoke<Array<ScriptTypedElementHandle>>(nameof(K2_GetSelectedElementHandles), InBaseInterfaceType); }
        //public bool IsElementSelected(ScriptTypedElementHandle InElementHandle, TypedElementIsSelectedOptions InSelectionOptions) { return Invoke<bool>(nameof(IsElementSelected), InElementHandle, InSelectionOptions); }
        public bool HasSelectedObjects(Object InRequiredClass) { return Invoke<bool>(nameof(HasSelectedObjects), InRequiredClass); }
        public bool HasSelectedElements(Object InBaseInterfaceType) { return Invoke<bool>(nameof(HasSelectedElements), InBaseInterfaceType); }
        public Object GetTopSelectedObject(Object InRequiredClass) { return Invoke<Object>(nameof(GetTopSelectedObject), InRequiredClass); }
        //public ScriptTypedElementHandle GetSelectionElement(ScriptTypedElementHandle InElementHandle, ETypedElementSelectionMethod InSelectionMethod) { return Invoke<ScriptTypedElementHandle>(nameof(GetSelectionElement), InElementHandle, InSelectionMethod); }
        public Array<Object> GetSelectedObjects(Object InRequiredClass) { return Invoke<Array<Object>>(nameof(GetSelectedObjects), InRequiredClass); }
        public int GetNumSelectedElements() { return Invoke<int>(nameof(GetNumSelectedElements)); }
        public TypedElementSelectionSetState GetCurrentSelectionState() { return Invoke<TypedElementSelectionSetState>(nameof(GetCurrentSelectionState)); }
        public Object GetBottomSelectedObject(Object InRequiredClass) { return Invoke<Object>(nameof(GetBottomSelectedObject), InRequiredClass); }
        //public bool DeselectElements(Array<ScriptTypedElementHandle> InElementHandles, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(DeselectElements), InElementHandles, InSelectionOptions); }
        //public bool DeselectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(DeselectElement), InElementHandle, InSelectionOptions); }
        public int CountSelectedObjects(Object InRequiredClass) { return Invoke<int>(nameof(CountSelectedObjects), InRequiredClass); }
        public int CountSelectedElements(Object InBaseInterfaceType) { return Invoke<int>(nameof(CountSelectedElements), InBaseInterfaceType); }
        public bool ClearSelection(TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(ClearSelection), InSelectionOptions); }
        //public bool CanSelectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(CanSelectElement), InElementHandle, InSelectionOptions); }
        //public bool CanDeselectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(CanDeselectElement), InElementHandle, InSelectionOptions); }
        //public bool AllowSelectionModifiers(ScriptTypedElementHandle InElementHandle) { return Invoke<bool>(nameof(AllowSelectionModifiers), InElementHandle); }
    }
    public class TypedElementAssetDataInterface : Interface
    {
        public TypedElementAssetDataInterface(nint addr) : base(addr) { }
        //public AssetData GetAssetData(ScriptTypedElementHandle InElementHandle) { return Invoke<AssetData>(nameof(GetAssetData), InElementHandle); }
        //public Array<AssetData> GetAllReferencedAssetDatas(ScriptTypedElementHandle InElementHandle) { return Invoke<Array<AssetData>>(nameof(GetAllReferencedAssetDatas), InElementHandle); }
    }
    public class TypedElementHierarchyInterface : Interface
    {
        public TypedElementHierarchyInterface(nint addr) : base(addr) { }
        //public ScriptTypedElementHandle GetParentElement(ScriptTypedElementHandle InElementHandle, bool bAllowCreate) { return Invoke<ScriptTypedElementHandle>(nameof(GetParentElement), InElementHandle, bAllowCreate); }
        //public void GetChildElements(ScriptTypedElementHandle InElementHandle, Array<ScriptTypedElementHandle> OutElementHandles, bool bAllowCreate) { Invoke(nameof(GetChildElements), InElementHandle, OutElementHandles, bAllowCreate); }
    }
    public class TypedElementObjectInterface : Interface
    {
        public TypedElementObjectInterface(nint addr) : base(addr) { }
        //public Object GetObjectClass(ScriptTypedElementHandle InElementHandle) { return Invoke<Object>(nameof(GetObjectClass), InElementHandle); }
        //public Object GetObject(ScriptTypedElementHandle InElementHandle) { return Invoke<Object>(nameof(GetObject), InElementHandle); }
    }
    public class TypedElementSelectionInterface : Interface
    {
        public TypedElementSelectionInterface(nint addr) : base(addr) { }
        //public bool SelectElement(ScriptTypedElementHandle InElementHandle, ScriptTypedElementListProxy InSelectionSet, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(SelectElement), InElementHandle, InSelectionSet, InSelectionOptions); }
        //public bool IsElementSelected(ScriptTypedElementHandle InElementHandle, ScriptTypedElementListProxy InSelectionSet, TypedElementIsSelectedOptions InSelectionOptions) { return Invoke<bool>(nameof(IsElementSelected), InElementHandle, InSelectionSet, InSelectionOptions); }
        //public ScriptTypedElementHandle GetSelectionElement(ScriptTypedElementHandle InElementHandle, ScriptTypedElementListProxy InCurrentSelection, ETypedElementSelectionMethod InSelectionMethod) { return Invoke<ScriptTypedElementHandle>(nameof(GetSelectionElement), InElementHandle, InCurrentSelection, InSelectionMethod); }
        //public bool DeselectElement(ScriptTypedElementHandle InElementHandle, ScriptTypedElementListProxy InSelectionSet, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(DeselectElement), InElementHandle, InSelectionSet, InSelectionOptions); }
        //public bool CanSelectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(CanSelectElement), InElementHandle, InSelectionOptions); }
        //public bool CanDeselectElement(ScriptTypedElementHandle InElementHandle, TypedElementSelectionOptions InSelectionOptions) { return Invoke<bool>(nameof(CanDeselectElement), InElementHandle, InSelectionOptions); }
        //public bool AllowSelectionModifiers(ScriptTypedElementHandle InElementHandle, ScriptTypedElementListProxy InSelectionSet) { return Invoke<bool>(nameof(AllowSelectionModifiers), InElementHandle, InSelectionSet); }
    }
    public class TypedElementSelectionOptions : Object
    {
        public TypedElementSelectionOptions(nint addr) : base(addr) { }
        public bool bAllowHidden { get { return this[nameof(bAllowHidden)].Flag; } set { this[nameof(bAllowHidden)].Flag = value; } }
        public bool bAllowGroups { get { return this[nameof(bAllowGroups)].Flag; } set { this[nameof(bAllowGroups)].Flag = value; } }
        public bool bAllowLegacyNotifications { get { return this[nameof(bAllowLegacyNotifications)].Flag; } set { this[nameof(bAllowLegacyNotifications)].Flag = value; } }
        public bool bWarnIfLocked { get { return this[nameof(bWarnIfLocked)].Flag; } set { this[nameof(bWarnIfLocked)].Flag = value; } }
        public ETypedElementChildInclusionMethod ChildElementInclusionMethod { get { return (ETypedElementChildInclusionMethod)this[nameof(ChildElementInclusionMethod)].GetValue<int>(); } set { this[nameof(ChildElementInclusionMethod)].SetValue<int>((int)value); } }
    }
    public enum ETypedElementChildInclusionMethod : int
    {
        None = 0,
        Immediate = 1,
        Recursive = 2,
        ETypedElementChildInclusionMethod_MAX = 3,
    }
    public class TypedElementSelectionSetState : Object
    {
        public TypedElementSelectionSetState(nint addr) : base(addr) { }
        public Object CreatedFromSelectionSet { get { return this[nameof(CreatedFromSelectionSet)]; } set { this[nameof(CreatedFromSelectionSet)] = value; } }
    }
    public enum ETypedElementSelectionMethod : int
    {
        Primary = 0,
        Secondary = 1,
        ETypedElementSelectionMethod_MAX = 2,
    }
    public class TypedElementIsSelectedOptions : Object
    {
        public TypedElementIsSelectedOptions(nint addr) : base(addr) { }
        public bool bAllowIndirect { get { return this[nameof(bAllowIndirect)].Flag; } set { this[nameof(bAllowIndirect)].Flag = value; } }
    }
    public class TypedElementSelectionNormalizationOptions : Object
    {
        public TypedElementSelectionNormalizationOptions(nint addr) : base(addr) { }
        public bool bExpandGroups { get { return this[nameof(bExpandGroups)].Flag; } set { this[nameof(bExpandGroups)].Flag = value; } }
        public bool bFollowAttachment { get { return this[nameof(bFollowAttachment)].Flag; } set { this[nameof(bFollowAttachment)].Flag = value; } }
    }
}
