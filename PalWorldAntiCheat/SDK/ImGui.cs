using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImGuiSDK
{
    public class ImGuiInputHandler : Object
    {
        public ImGuiInputHandler(nint addr) : base(addr) { }
    }
    public class ImGuiSettings : Object
    {
        public ImGuiSettings(nint addr) : base(addr) { }
        public SoftClassPath ImGuiInputHandlerClass { get { return this[nameof(ImGuiInputHandlerClass)].As<SoftClassPath>(); } set { this["ImGuiInputHandlerClass"] = value; } }
        public bool bShareKeyboardInput { get { return this[nameof(bShareKeyboardInput)].Flag; } set { this[nameof(bShareKeyboardInput)].Flag = value; } }
        public bool bShareGamepadInput { get { return this[nameof(bShareGamepadInput)].Flag; } set { this[nameof(bShareGamepadInput)].Flag = value; } }
        public bool bShareMouseInput { get { return this[nameof(bShareMouseInput)].Flag; } set { this[nameof(bShareMouseInput)].Flag = value; } }
        public bool bUseSoftwareCursor { get { return this[nameof(bUseSoftwareCursor)].Flag; } set { this[nameof(bUseSoftwareCursor)].Flag = value; } }
        public ImGuiKeyInfo ToggleInput { get { return this[nameof(ToggleInput)].As<ImGuiKeyInfo>(); } set { this["ToggleInput"] = value; } }
        public ImGuiCanvasSizeInfo CanvasSize { get { return this[nameof(CanvasSize)].As<ImGuiCanvasSizeInfo>(); } set { this["CanvasSize"] = value; } }
        public ImGuiDPIScaleInfo DPIScale { get { return this[nameof(DPIScale)].As<ImGuiDPIScaleInfo>(); } set { this["DPIScale"] = value; } }
    }
    public enum EImGuiCanvasSizeType : int
    {
        Custom = 0,
        Desktop = 1,
        Viewport = 2,
        EImGuiCanvasSizeType_MAX = 3,
    }
    public enum EImGuiDPIScaleMethod : int
    {
        ImGui = 0,
        Slate = 1,
        EImGuiDPIScaleMethod_MAX = 2,
    }
    public class ImGuiKeyInfo : Object
    {
        public ImGuiKeyInfo(nint addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public ECheckBoxState Shift { get { return (ECheckBoxState)this[nameof(Shift)].GetValue<int>(); } set { this[nameof(Shift)].SetValue<int>((int)value); } }
        public ECheckBoxState Ctrl { get { return (ECheckBoxState)this[nameof(Ctrl)].GetValue<int>(); } set { this[nameof(Ctrl)].SetValue<int>((int)value); } }
        public ECheckBoxState Alt { get { return (ECheckBoxState)this[nameof(Alt)].GetValue<int>(); } set { this[nameof(Alt)].SetValue<int>((int)value); } }
        public ECheckBoxState Cmd { get { return (ECheckBoxState)this[nameof(Cmd)].GetValue<int>(); } set { this[nameof(Cmd)].SetValue<int>((int)value); } }
    }
    public class ImGuiCanvasSizeInfo : Object
    {
        public ImGuiCanvasSizeInfo(nint addr) : base(addr) { }
        public EImGuiCanvasSizeType SizeType { get { return (EImGuiCanvasSizeType)this[nameof(SizeType)].GetValue<int>(); } set { this[nameof(SizeType)].SetValue<int>((int)value); } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public bool bExtendToViewport { get { return this[nameof(bExtendToViewport)].Flag; } set { this[nameof(bExtendToViewport)].Flag = value; } }
    }
    public class ImGuiDPIScaleInfo : Object
    {
        public ImGuiDPIScaleInfo(nint addr) : base(addr) { }
        public EImGuiDPIScaleMethod ScalingMethod { get { return (EImGuiDPIScaleMethod)this[nameof(ScalingMethod)].GetValue<int>(); } set { this[nameof(ScalingMethod)].SetValue<int>((int)value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public RuntimeFloatCurve DPICurve { get { return this[nameof(DPICurve)].As<RuntimeFloatCurve>(); } set { this["DPICurve"] = value; } }
        public bool bScaleWithCurve { get { return this[nameof(bScaleWithCurve)].Flag; } set { this[nameof(bScaleWithCurve)].Flag = value; } }
    }
}
