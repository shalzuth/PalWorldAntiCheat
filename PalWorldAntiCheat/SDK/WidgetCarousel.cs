using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.WidgetCarouselSDK
{
    public class WidgetCarouselNavigationButtonStyle : SlateWidgetStyle
    {
        public WidgetCarouselNavigationButtonStyle(nint addr) : base(addr) { }
        public ButtonStyle InnerButtonStyle { get { return this[nameof(InnerButtonStyle)].As<ButtonStyle>(); } set { this["InnerButtonStyle"] = value; } }
        public SlateBrush NavigationButtonLeftImage { get { return this[nameof(NavigationButtonLeftImage)].As<SlateBrush>(); } set { this["NavigationButtonLeftImage"] = value; } }
        public SlateBrush NavigationButtonRightImage { get { return this[nameof(NavigationButtonRightImage)].As<SlateBrush>(); } set { this["NavigationButtonRightImage"] = value; } }
    }
    public class WidgetCarouselNavigationBarStyle : SlateWidgetStyle
    {
        public WidgetCarouselNavigationBarStyle(nint addr) : base(addr) { }
        public SlateBrush HighlightBrush { get { return this[nameof(HighlightBrush)].As<SlateBrush>(); } set { this["HighlightBrush"] = value; } }
        public ButtonStyle LeftButtonStyle { get { return this[nameof(LeftButtonStyle)].As<ButtonStyle>(); } set { this["LeftButtonStyle"] = value; } }
        public ButtonStyle CenterButtonStyle { get { return this[nameof(CenterButtonStyle)].As<ButtonStyle>(); } set { this["CenterButtonStyle"] = value; } }
        public ButtonStyle RightButtonStyle { get { return this[nameof(RightButtonStyle)].As<ButtonStyle>(); } set { this["RightButtonStyle"] = value; } }
    }
}
