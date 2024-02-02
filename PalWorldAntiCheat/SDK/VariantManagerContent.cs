using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.VariantManagerContentSDK
{
    public class LevelVariantSets : Object
    {
        public LevelVariantSets(nint addr) : base(addr) { }
        public Object DirectorClass { get { return this[nameof(DirectorClass)].As<Object>(); } set { this["DirectorClass"] = value; } } // ClassPtrProperty
        public Array<VariantSet> VariantSets { get { return new Array<VariantSet>(this[nameof(VariantSets)].Address); } }
        public VariantSet GetVariantSetByName(Object VariantSetName) { return Invoke<VariantSet>(nameof(GetVariantSetByName), VariantSetName); }
        public VariantSet GetVariantSet(int VariantSetIndex) { return Invoke<VariantSet>(nameof(GetVariantSet), VariantSetIndex); }
        public int GetNumVariantSets() { return Invoke<int>(nameof(GetNumVariantSets)); }
    }
    public class LevelVariantSetsActor : Actor
    {
        public LevelVariantSetsActor(nint addr) : base(addr) { }
        public SoftObjectPath LevelVariantSets { get { return this[nameof(LevelVariantSets)].As<SoftObjectPath>(); } set { this["LevelVariantSets"] = value; } }
        public Object DirectorInstances { get { return this[nameof(DirectorInstances)]; } set { this[nameof(DirectorInstances)] = value; } }
        public bool SwitchOnVariantByName(Object VariantSetName, Object VariantName) { return Invoke<bool>(nameof(SwitchOnVariantByName), VariantSetName, VariantName); }
        public bool SwitchOnVariantByIndex(int VariantSetIndex, int VariantIndex) { return Invoke<bool>(nameof(SwitchOnVariantByIndex), VariantSetIndex, VariantIndex); }
        public void SetLevelVariantSets(LevelVariantSets InVariantSets) { Invoke(nameof(SetLevelVariantSets), InVariantSets); }
        public LevelVariantSets GetLevelVariantSets(bool bLoad) { return Invoke<LevelVariantSets>(nameof(GetLevelVariantSets), bLoad); }
    }
    public class LevelVariantSetsFunctionDirector : Object
    {
        public LevelVariantSetsFunctionDirector(nint addr) : base(addr) { }
    }
    public class PropertyValue : Object
    {
        public PropertyValue(nint addr) : base(addr) { }
        public Array<Object> Properties { get { return new Array<Object>(this[nameof(Properties)].Address); } }
        public Array<int> PropertyIndices { get { return new Array<int>(this[nameof(PropertyIndices)].Address); } }
        public Array<CapturedPropSegment> CapturedPropSegments { get { return new Array<CapturedPropSegment>(this[nameof(CapturedPropSegments)].Address); } }
        public Object FullDisplayString { get { return this[nameof(FullDisplayString)]; } set { this[nameof(FullDisplayString)] = value; } }
        public Object PropertySetterName { get { return this[nameof(PropertySetterName)]; } set { this[nameof(PropertySetterName)] = value; } }
        public Object PropertySetterParameterDefaults { get { return this[nameof(PropertySetterParameterDefaults)]; } set { this[nameof(PropertySetterParameterDefaults)] = value; } }
        public bool bHasRecordedData { get { return this[nameof(bHasRecordedData)].Flag; } set { this[nameof(bHasRecordedData)].Flag = value; } }
        public Object LeafPropertyClass { get { return this[nameof(LeafPropertyClass)].As<Object>(); } set { this["LeafPropertyClass"] = value; } } // ClassPtrProperty
        public Array<byte> ValueBytes { get { return new Array<byte>(this[nameof(ValueBytes)].Address); } }
        public EPropertyValueCategory PropCategory { get { return (EPropertyValueCategory)this[nameof(PropCategory)].GetValue<int>(); } set { this[nameof(PropCategory)].SetValue<int>((int)value); } }
        public bool HasRecordedData() { return Invoke<bool>(nameof(HasRecordedData)); }
        public Object GetPropertyTooltip() { return Invoke<Object>(nameof(GetPropertyTooltip)); }
        public Object GetFullDisplayString() { return Invoke<Object>(nameof(GetFullDisplayString)); }
    }
    public class PropertyValueTransform : PropertyValue
    {
        public PropertyValueTransform(nint addr) : base(addr) { }
    }
    public class PropertyValueVisibility : PropertyValue
    {
        public PropertyValueVisibility(nint addr) : base(addr) { }
    }
    public class PropertyValueColor : PropertyValue
    {
        public PropertyValueColor(nint addr) : base(addr) { }
    }
    public class PropertyValueMaterial : PropertyValue
    {
        public PropertyValueMaterial(nint addr) : base(addr) { }
    }
    public class PropertyValueOption : PropertyValue
    {
        public PropertyValueOption(nint addr) : base(addr) { }
    }
    public class PropertyValueSoftObject : PropertyValue
    {
        public PropertyValueSoftObject(nint addr) : base(addr) { }
    }
    public class SwitchActor : Actor
    {
        public SwitchActor(nint addr) : base(addr) { }
        public SceneComponent SceneComponent { get { return this[nameof(SceneComponent)].As<SceneComponent>(); } set { this["SceneComponent"] = value; } }
        public int LastSelectedOption { get { return this[nameof(LastSelectedOption)].GetValue<int>(); } set { this[nameof(LastSelectedOption)].SetValue<int>(value); } }
        public void SelectOption(int OptionIndex) { Invoke(nameof(SelectOption), OptionIndex); }
        public int GetSelectedOption() { return Invoke<int>(nameof(GetSelectedOption)); }
        public Array<Actor> GetOptions() { return Invoke<Array<Actor>>(nameof(GetOptions)); }
    }
    public class Variant : Object
    {
        public Variant(nint addr) : base(addr) { }
        public Array<VariantDependency> Dependencies { get { return new Array<VariantDependency>(this[nameof(Dependencies)].Address); } }
        public Object DisplayText { get { return this[nameof(DisplayText)]; } set { this[nameof(DisplayText)] = value; } }
        public Array<VariantObjectBinding> ObjectBindings { get { return new Array<VariantObjectBinding>(this[nameof(ObjectBindings)].Address); } }
        public Texture2D Thumbnail { get { return this[nameof(Thumbnail)].As<Texture2D>(); } set { this["Thumbnail"] = value; } }
        public void SwitchOn() { Invoke(nameof(SwitchOn)); }
        public void SetThumbnailFromTexture(Texture2D NewThumbnail) { Invoke(nameof(SetThumbnailFromTexture), NewThumbnail); }
        public void SetThumbnailFromFile(Object FilePath) { Invoke(nameof(SetThumbnailFromFile), FilePath); }
        public void SetThumbnailFromEditorViewport() { Invoke(nameof(SetThumbnailFromEditorViewport)); }
        public void SetThumbnailFromCamera(Object WorldContextObject, Transform CameraTransform, float FOVDegrees, float MinZ, float Gamma) { Invoke(nameof(SetThumbnailFromCamera), WorldContextObject, CameraTransform, FOVDegrees, MinZ, Gamma); }
        public void SetDisplayText(Object NewDisplayText) { Invoke(nameof(SetDisplayText), NewDisplayText); }
        public void SetDependency(int Index, VariantDependency Dependency) { Invoke(nameof(SetDependency), Index, Dependency); }
        public bool IsActive() { return Invoke<bool>(nameof(IsActive)); }
        public Texture2D GetThumbnail() { return Invoke<Texture2D>(nameof(GetThumbnail)); }
        public VariantSet GetParent() { return Invoke<VariantSet>(nameof(GetParent)); }
        public int GetNumDependencies() { return Invoke<int>(nameof(GetNumDependencies)); }
        public int GetNumActors() { return Invoke<int>(nameof(GetNumActors)); }
        public Object GetDisplayText() { return Invoke<Object>(nameof(GetDisplayText)); }
        public Array<Variant> GetDependents(LevelVariantSets LevelVariantSets, bool bOnlyEnabledDependencies) { return Invoke<Array<Variant>>(nameof(GetDependents), LevelVariantSets, bOnlyEnabledDependencies); }
        public VariantDependency GetDependency(int Index) { return Invoke<VariantDependency>(nameof(GetDependency), Index); }
        public Actor GetActor(int ActorIndex) { return Invoke<Actor>(nameof(GetActor), ActorIndex); }
        public void DeleteDependency(int Index) { Invoke(nameof(DeleteDependency), Index); }
        public int AddDependency(VariantDependency Dependency) { return Invoke<int>(nameof(AddDependency), Dependency); }
    }
    public class VariantObjectBinding : Object
    {
        public VariantObjectBinding(nint addr) : base(addr) { }
        public Object CachedActorLabel { get { return this[nameof(CachedActorLabel)]; } set { this[nameof(CachedActorLabel)] = value; } }
        public SoftObjectPath ObjectPtr { get { return this[nameof(ObjectPtr)].As<SoftObjectPath>(); } set { this["ObjectPtr"] = value; } }
        public Object LazyObjectPtr { get { return this[nameof(LazyObjectPtr)]; } set { this[nameof(LazyObjectPtr)] = value; } }
        public Array<PropertyValue> CapturedProperties { get { return new Array<PropertyValue>(this[nameof(CapturedProperties)].Address); } }
        public Array<FunctionCaller> FunctionCallers { get { return new Array<FunctionCaller>(this[nameof(FunctionCallers)].Address); } }
    }
    public class VariantSet : Object
    {
        public VariantSet(nint addr) : base(addr) { }
        public Object DisplayText { get { return this[nameof(DisplayText)]; } set { this[nameof(DisplayText)] = value; } }
        public bool bExpanded { get { return this[nameof(bExpanded)].Flag; } set { this[nameof(bExpanded)].Flag = value; } }
        public Array<Variant> Variants { get { return new Array<Variant>(this[nameof(Variants)].Address); } }
        public Texture2D Thumbnail { get { return this[nameof(Thumbnail)].As<Texture2D>(); } set { this["Thumbnail"] = value; } }
        public void SetThumbnailFromTexture(Texture2D NewThumbnail) { Invoke(nameof(SetThumbnailFromTexture), NewThumbnail); }
        public void SetThumbnailFromFile(Object FilePath) { Invoke(nameof(SetThumbnailFromFile), FilePath); }
        public void SetThumbnailFromEditorViewport() { Invoke(nameof(SetThumbnailFromEditorViewport)); }
        public void SetThumbnailFromCamera(Object WorldContextObject, Transform CameraTransform, float FOVDegrees, float MinZ, float Gamma) { Invoke(nameof(SetThumbnailFromCamera), WorldContextObject, CameraTransform, FOVDegrees, MinZ, Gamma); }
        public void SetDisplayText(Object NewDisplayText) { Invoke(nameof(SetDisplayText), NewDisplayText); }
        public Variant GetVariantByName(Object VariantName) { return Invoke<Variant>(nameof(GetVariantByName), VariantName); }
        public Variant GetVariant(int VariantIndex) { return Invoke<Variant>(nameof(GetVariant), VariantIndex); }
        public Texture2D GetThumbnail() { return Invoke<Texture2D>(nameof(GetThumbnail)); }
        public LevelVariantSets GetParent() { return Invoke<LevelVariantSets>(nameof(GetParent)); }
        public int GetNumVariants() { return Invoke<int>(nameof(GetNumVariants)); }
        public Object GetDisplayText() { return Invoke<Object>(nameof(GetDisplayText)); }
    }
    public enum EPropertyValueCategory : int
    {
        Undefined = 0,
        Generic = 1,
        RelativeLocation = 2,
        RelativeRotation = 4,
        RelativeScale3D = 8,
        Visibility = 16,
        Material = 32,
        Color = 64,
        Option = 128,
        EPropertyValueCategory_MAX = 129,
    }
    public class FunctionCaller : Object
    {
        public FunctionCaller(nint addr) : base(addr) { }
        public Object FunctionName { get { return this[nameof(FunctionName)]; } set { this[nameof(FunctionName)] = value; } }
    }
    public class CapturedPropSegment : Object
    {
        public CapturedPropSegment(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public int PropertyIndex { get { return this[nameof(PropertyIndex)].GetValue<int>(); } set { this[nameof(PropertyIndex)].SetValue<int>(value); } }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
    }
    public class VariantDependency : Object
    {
        public VariantDependency(nint addr) : base(addr) { }
        public Object VariantSet { get { return this[nameof(VariantSet)]; } set { this[nameof(VariantSet)] = value; } }
        public Object Variant { get { return this[nameof(Variant)]; } set { this[nameof(Variant)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
}
