using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.UMGSDK;
using SDK.Script.NiagaraSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.NiagaraUIRendererSDK
{
    public class NiagaraSystemWidget : Widget
    {
        public NiagaraSystemWidget(nint addr) : base(addr) { }
        public NiagaraSystem NiagaraSystemReference { get { return this[nameof(NiagaraSystemReference)].As<NiagaraSystem>(); } set { this["NiagaraSystemReference"] = value; } }
        public Object MaterialRemapList { get { return this[nameof(MaterialRemapList)]; } set { this[nameof(MaterialRemapList)] = value; } }
        public bool AutoActivate { get { return this[nameof(AutoActivate)].Flag; } set { this[nameof(AutoActivate)].Flag = value; } }
        public bool TickWhenPaused { get { return this[nameof(TickWhenPaused)].Flag; } set { this[nameof(TickWhenPaused)].Flag = value; } }
        public Vector2D DesiredWidgetSize { get { return this[nameof(DesiredWidgetSize)].As<Vector2D>(); } set { this["DesiredWidgetSize"] = value; } }
        public bool FakeDepthScale { get { return this[nameof(FakeDepthScale)].Flag; } set { this[nameof(FakeDepthScale)].Flag = value; } }
        public float FakeDepthScaleDistance { get { return this[nameof(FakeDepthScaleDistance)].GetValue<float>(); } set { this[nameof(FakeDepthScaleDistance)].SetValue<float>(value); } }
        public bool ShowDebugSystemInWorld { get { return this[nameof(ShowDebugSystemInWorld)].Flag; } set { this[nameof(ShowDebugSystemInWorld)].Flag = value; } }
        public bool DisableWarnings { get { return this[nameof(DisableWarnings)].Flag; } set { this[nameof(DisableWarnings)].Flag = value; } }
        public NiagaraUIActor NiagaraActor { get { return this[nameof(NiagaraActor)].As<NiagaraUIActor>(); } set { this["NiagaraActor"] = value; } }
        public NiagaraUIComponent NiagaraComponent { get { return this[nameof(NiagaraComponent)].As<NiagaraUIComponent>(); } set { this["NiagaraComponent"] = value; } }
        public void UpdateTickWhenPaused(bool NewTickWhenPaused) { Invoke(nameof(UpdateTickWhenPaused), NewTickWhenPaused); }
        public void UpdateNiagaraSystemReference(NiagaraSystem NewNiagaraSystem) { Invoke(nameof(UpdateNiagaraSystemReference), NewNiagaraSystem); }
        public void SetRemapMaterial(MaterialInterface OriginalMaterial, MaterialInterface RemapMaterial) { Invoke(nameof(SetRemapMaterial), OriginalMaterial, RemapMaterial); }
        public void SetDesiredWidgetSize(Vector2D NewDesiredSize) { Invoke(nameof(SetDesiredWidgetSize), NewDesiredSize); }
        public MaterialInterface GetRemapMaterial(MaterialInterface OriginalMaterial) { return Invoke<MaterialInterface>(nameof(GetRemapMaterial), OriginalMaterial); }
        public NiagaraUIComponent GetNiagaraComponent() { return Invoke<NiagaraUIComponent>(nameof(GetNiagaraComponent)); }
        public void DeactivateSystem() { Invoke(nameof(DeactivateSystem)); }
        public void ActivateSystem(bool Reset) { Invoke(nameof(ActivateSystem), Reset); }
    }
    public class NiagaraUIActor : Actor
    {
        public NiagaraUIActor(nint addr) : base(addr) { }
    }
    public class NiagaraUIComponent : NiagaraComponent
    {
        public NiagaraUIComponent(nint addr) : base(addr) { }
    }
}
