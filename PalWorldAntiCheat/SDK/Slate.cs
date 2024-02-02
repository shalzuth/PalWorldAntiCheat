using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.SlateCoreSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SlateSDK
{
    public class ToolMenuBase : Object
    {
        public ToolMenuBase(nint addr) : base(addr) { }
    }
    public class SlateSettings : Object
    {
        public SlateSettings(nint addr) : base(addr) { }
        public bool bExplicitCanvasChildZOrder { get { return this[nameof(bExplicitCanvasChildZOrder)].Flag; } set { this[nameof(bExplicitCanvasChildZOrder)].Flag = value; } }
    }
    public class ButtonWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ButtonWidgetStyle(nint addr) : base(addr) { }
        public ButtonStyle ButtonStyle { get { return this[nameof(ButtonStyle)].As<ButtonStyle>(); } set { this["ButtonStyle"] = value; } }
    }
    public class CheckBoxWidgetStyle : SlateWidgetStyleContainerBase
    {
        public CheckBoxWidgetStyle(nint addr) : base(addr) { }
        public CheckBoxStyle CheckBoxStyle { get { return this[nameof(CheckBoxStyle)].As<CheckBoxStyle>(); } set { this["CheckBoxStyle"] = value; } }
    }
    public class ComboBoxWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ComboBoxWidgetStyle(nint addr) : base(addr) { }
        public ComboBoxStyle ComboBoxStyle { get { return this[nameof(ComboBoxStyle)].As<ComboBoxStyle>(); } set { this["ComboBoxStyle"] = value; } }
    }
    public class ComboButtonWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ComboButtonWidgetStyle(nint addr) : base(addr) { }
        public ComboButtonStyle ComboButtonStyle { get { return this[nameof(ComboButtonStyle)].As<ComboButtonStyle>(); } set { this["ComboButtonStyle"] = value; } }
    }
    public class EditableTextBoxWidgetStyle : SlateWidgetStyleContainerBase
    {
        public EditableTextBoxWidgetStyle(nint addr) : base(addr) { }
        public EditableTextBoxStyle EditableTextBoxStyle { get { return this[nameof(EditableTextBoxStyle)].As<EditableTextBoxStyle>(); } set { this["EditableTextBoxStyle"] = value; } }
    }
    public class EditableTextWidgetStyle : SlateWidgetStyleContainerBase
    {
        public EditableTextWidgetStyle(nint addr) : base(addr) { }
        public EditableTextStyle EditableTextStyle { get { return this[nameof(EditableTextStyle)].As<EditableTextStyle>(); } set { this["EditableTextStyle"] = value; } }
    }
    public class ProgressWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ProgressWidgetStyle(nint addr) : base(addr) { }
        public ProgressBarStyle ProgressBarStyle { get { return this[nameof(ProgressBarStyle)].As<ProgressBarStyle>(); } set { this["ProgressBarStyle"] = value; } }
    }
    public class ScrollBarWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ScrollBarWidgetStyle(nint addr) : base(addr) { }
        public ScrollBarStyle ScrollBarStyle { get { return this[nameof(ScrollBarStyle)].As<ScrollBarStyle>(); } set { this["ScrollBarStyle"] = value; } }
    }
    public class ScrollBoxWidgetStyle : SlateWidgetStyleContainerBase
    {
        public ScrollBoxWidgetStyle(nint addr) : base(addr) { }
        public ScrollBoxStyle ScrollBoxStyle { get { return this[nameof(ScrollBoxStyle)].As<ScrollBoxStyle>(); } set { this["ScrollBoxStyle"] = value; } }
    }
    public class SpinBoxWidgetStyle : SlateWidgetStyleContainerBase
    {
        public SpinBoxWidgetStyle(nint addr) : base(addr) { }
        public SpinBoxStyle SpinBoxStyle { get { return this[nameof(SpinBoxStyle)].As<SpinBoxStyle>(); } set { this["SpinBoxStyle"] = value; } }
    }
    public class TextBlockWidgetStyle : SlateWidgetStyleContainerBase
    {
        public TextBlockWidgetStyle(nint addr) : base(addr) { }
        public TextBlockStyle TextBlockStyle { get { return this[nameof(TextBlockStyle)].As<TextBlockStyle>(); } set { this["TextBlockStyle"] = value; } }
    }
    public enum ETextJustify : int
    {
        Left = 0,
        Center = 1,
        Right = 2,
        ETextJustify_MAX = 3,
    }
    public enum ETextFlowDirection : int
    {
        Auto = 0,
        LeftToRight = 1,
        RightToLeft = 2,
        ETextFlowDirection_MAX = 3,
    }
    public enum EVirtualKeyboardDismissAction : int
    {
        TextChangeOnDismiss = 0,
        TextCommitOnAccept = 1,
        TextCommitOnDismiss = 2,
        EVirtualKeyboardDismissAction_MAX = 3,
    }
    public enum EVirtualKeyboardTrigger : int
    {
        OnFocusByPointer = 0,
        OnAllFocusEvents = 1,
        EVirtualKeyboardTrigger_MAX = 2,
    }
    public class VirtualKeyboardOptions : Object
    {
        public VirtualKeyboardOptions(nint addr) : base(addr) { }
        public bool bEnableAutocorrect { get { return this[nameof(bEnableAutocorrect)].Flag; } set { this[nameof(bEnableAutocorrect)].Flag = value; } }
    }
    public class InputChord : Object
    {
        public InputChord(nint addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public bool bShift { get { return this[nameof(bShift)].Flag; } set { this[nameof(bShift)].Flag = value; } }
        public bool bCtrl { get { return this[nameof(bCtrl)].Flag; } set { this[nameof(bCtrl)].Flag = value; } }
        public bool bAlt { get { return this[nameof(bAlt)].Flag; } set { this[nameof(bAlt)].Flag = value; } }
        public bool bCmd { get { return this[nameof(bCmd)].Flag; } set { this[nameof(bCmd)].Flag = value; } }
    }
    public enum ETextWrappingPolicy : int
    {
        DefaultWrapping = 0,
        AllowPerCharacterWrapping = 1,
        ETextWrappingPolicy_MAX = 2,
    }
    public class Anchors : Object
    {
        public Anchors(nint addr) : base(addr) { }
        public Vector2D Minimum { get { return this[nameof(Minimum)].As<Vector2D>(); } set { this["Minimum"] = value; } }
        public Vector2D Maximum { get { return this[nameof(Maximum)].As<Vector2D>(); } set { this["Maximum"] = value; } }
    }
    public enum ESelectionMode : int
    {
        None = 0,
        Single = 1,
        SingleToggle = 2,
        Multi = 3,
        ESelectionMode_MAX = 4,
    }
    public enum ETableViewMode : int
    {
        List = 0,
        Tile = 1,
        Tree = 2,
        ETableViewMode_MAX = 3,
    }
    public enum EMultiBoxType : int
    {
        MenuBar = 0,
        ToolBar = 1,
        VerticalToolBar = 2,
        SlimHorizontalToolBar = 3,
        UniformToolBar = 4,
        Menu = 5,
        ButtonRow = 6,
        EMultiBoxType_MAX = 7,
    }
    public enum EMultiBlockType : int
    {
        None = 0,
        ButtonRow = 1,
        EditableText = 2,
        Heading = 3,
        MenuEntry = 4,
        Separator = 5,
        ToolBarButton = 6,
        ToolBarComboButton = 7,
        Widget = 8,
        EMultiBlockType_MAX = 9,
    }
    public enum EDescendantScrollDestination : int
    {
        IntoView = 0,
        TopOrLeft = 1,
        Center = 2,
        BottomOrRight = 3,
        EDescendantScrollDestination_MAX = 4,
    }
    public enum EScrollWhenFocusChanges : int
    {
        NoScroll = 0,
        InstantScroll = 1,
        AnimatedScroll = 2,
        EScrollWhenFocusChanges_MAX = 3,
    }
    public enum ECustomizedToolMenuVisibility : int
    {
        None = 0,
        Visible = 1,
        Hidden = 2,
        ECustomizedToolMenuVisibility_MAX = 3,
    }
    public enum EUserInterfaceActionType : int
    {
        None = 0,
        Button = 1,
        ToggleButton = 2,
        RadioButton = 3,
        Check = 4,
        CollapsedButton = 5,
        EUserInterfaceActionType_MAX = 6,
    }
    public enum EMultipleKeyBindingIndex : int
    {
        Primary = 0,
        Secondary = 1,
        NumChords = 2,
        EMultipleKeyBindingIndex_MAX = 3,
    }
    public enum EStretchDirection : int
    {
        Both = 0,
        DownOnly = 1,
        UpOnly = 2,
        EStretchDirection_MAX = 3,
    }
    public enum EStretch : int
    {
        None = 0,
        Fill = 1,
        ScaleToFit = 2,
        ScaleToFitX = 3,
        ScaleToFitY = 4,
        ScaleToFill = 5,
        ScaleBySafeZone = 6,
        UserSpecified = 7,
        UserSpecifiedWithClipping = 8,
        EStretch_MAX = 9,
    }
    public enum EProgressBarFillType : int
    {
        LeftToRight = 0,
        RightToLeft = 1,
        FillFromCenter = 2,
        FillFromCenterHorizontal = 3,
        FillFromCenterVertical = 4,
        TopToBottom = 5,
        BottomToTop = 6,
        EProgressBarFillType_MAX = 7,
    }
    public enum EProgressBarFillStyle : int
    {
        Mask = 0,
        Scale = 1,
        EProgressBarFillStyle_MAX = 2,
    }
    public enum EListItemAlignment : int
    {
        EvenlyDistributed = 0,
        EvenlySize = 1,
        EvenlyWide = 2,
        LeftAligned = 3,
        RightAligned = 4,
        CenterAligned = 5,
        Fill = 6,
        EListItemAlignment_MAX = 7,
    }
    public class CustomizedToolMenuEntry : Object
    {
        public CustomizedToolMenuEntry(nint addr) : base(addr) { }
        public ECustomizedToolMenuVisibility Visibility { get { return (ECustomizedToolMenuVisibility)this[nameof(Visibility)].GetValue<int>(); } set { this[nameof(Visibility)].SetValue<int>((int)value); } }
    }
    public class CustomizedToolMenuSection : Object
    {
        public CustomizedToolMenuSection(nint addr) : base(addr) { }
        public ECustomizedToolMenuVisibility Visibility { get { return (ECustomizedToolMenuVisibility)this[nameof(Visibility)].GetValue<int>(); } set { this[nameof(Visibility)].SetValue<int>((int)value); } }
    }
    public class CustomizedToolMenuNameArray : Object
    {
        public CustomizedToolMenuNameArray(nint addr) : base(addr) { }
        public Array<Object> Names { get { return new Array<Object>(this[nameof(Names)].Address); } }
    }
    public class CustomizedToolMenu : Object
    {
        public CustomizedToolMenu(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Entries { get { return this[nameof(Entries)]; } set { this[nameof(Entries)] = value; } }
        public Object Sections { get { return this[nameof(Sections)]; } set { this[nameof(Sections)] = value; } }
        public Object EntryOrder { get { return this[nameof(EntryOrder)]; } set { this[nameof(EntryOrder)] = value; } }
        public Array<Object> SectionOrder { get { return new Array<Object>(this[nameof(SectionOrder)].Address); } }
    }
}
