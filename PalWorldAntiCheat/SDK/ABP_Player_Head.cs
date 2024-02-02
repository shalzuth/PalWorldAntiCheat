using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.AnimGraphRuntimeSDK;
namespace SDK.Game.Pal.Blueprint.Character.Player.ABP_Player_HeadSDK
{
    public class AnimBlueprintGeneratedConstantData : AnimBlueprintConstantData
    {
        public AnimBlueprintGeneratedConstantData(nint addr) : base(addr) { }
        //public Object __NameProperty { get { return this[nameof(__NameProperty)]; } set { this[nameof(__NameProperty)] = value; } }
        //public Object __NameProperty { get { return this[nameof(__NameProperty)]; } set { this[nameof(__NameProperty)] = value; } }
        //public Object __NameProperty { get { return this[nameof(__NameProperty)]; } set { this[nameof(__NameProperty)] = value; } }
        //public BlendProfile __BlendProfile { get { return this[nameof(__BlendProfile)].As<BlendProfile>(); } set { this["__BlendProfile"] = value; } }
        //public CurveFloat __CurveFloat { get { return this[nameof(__CurveFloat)].As<CurveFloat>(); } set { this["__CurveFloat"] = value; } }
        //public bool __BoolProperty { get { return this[nameof(__BoolProperty)].Flag; } set { this[nameof(__BoolProperty)].Flag = value; } }
        //public EAlphaBlendOption __EnumProperty { get { return (EAlphaBlendOption)this[nameof(__EnumProperty)].GetValue<int>(); } set { this[nameof(__EnumProperty)].SetValue<int>((int)value); } }
        //public EBlendListTransitionType __EnumProperty { get { return (EBlendListTransitionType)this[nameof(__EnumProperty)].GetValue<int>(); } set { this[nameof(__EnumProperty)].SetValue<int>((int)value); } }
        //public Array<float> __ArrayProperty { get { return new Array<float>(this[nameof(__ArrayProperty)].Address); } }
        //public AnimNodeFunctionRef __StructProperty { get { return this[nameof(__StructProperty)].As<AnimNodeFunctionRef>(); } set { this["__StructProperty"] = value; } }
        public AnimSubsystem_PropertyAccess AnimBlueprintExtension_PropertyAccess { get { return this[nameof(AnimBlueprintExtension_PropertyAccess)].As<AnimSubsystem_PropertyAccess>(); } set { this["AnimBlueprintExtension_PropertyAccess"] = value; } }
        public AnimSubsystem_Base AnimBlueprintExtension_Base { get { return this[nameof(AnimBlueprintExtension_Base)].As<AnimSubsystem_Base>(); } set { this["AnimBlueprintExtension_Base"] = value; } }
    }
    public class AnimBlueprintGeneratedMutableData : AnimBlueprintMutableData
    {
        public AnimBlueprintGeneratedMutableData(nint addr) : base(addr) { }
        //public bool __BoolProperty { get { return this[nameof(__BoolProperty)].Flag; } set { this[nameof(__BoolProperty)].Flag = value; } }
    }
}
