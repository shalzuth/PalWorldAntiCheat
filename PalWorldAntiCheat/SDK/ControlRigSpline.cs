using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.ControlRigSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ControlRigSplineSDK
{
    public enum ESplineType : int
    {
        BSpline = 0,
        Hermite = 1,
        Max = 2,
    }
    public class ControlRigSplineImpl : Object
    {
        public ControlRigSplineImpl(nint addr) : base(addr) { }
    }
    public class ControlRigSpline : Object
    {
        public ControlRigSpline(nint addr) : base(addr) { }
    }
    public class RigUnit_ControlRigSplineBase : RigUnit
    {
        public RigUnit_ControlRigSplineBase(nint addr) : base(addr) { }
    }
    public class RigUnit_ControlRigSplineFromPoints : RigUnit_ControlRigSplineBase
    {
        public RigUnit_ControlRigSplineFromPoints(nint addr) : base(addr) { }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public ESplineType SplineMode { get { return (ESplineType)this[nameof(SplineMode)].GetValue<int>(); } set { this[nameof(SplineMode)].SetValue<int>((int)value); } }
        public int SamplesPerSegment { get { return this[nameof(SamplesPerSegment)].GetValue<int>(); } set { this[nameof(SamplesPerSegment)].SetValue<int>(value); } }
        public float Compression { get { return this[nameof(Compression)].GetValue<float>(); } set { this[nameof(Compression)].SetValue<float>(value); } }
        public float Stretch { get { return this[nameof(Stretch)].GetValue<float>(); } set { this[nameof(Stretch)].SetValue<float>(value); } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
    }
    public class RigUnit_SetSplinePoints : RigUnitMutable
    {
        public RigUnit_SetSplinePoints(nint addr) : base(addr) { }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
    }
    public class RigUnit_PositionFromControlRigSpline : RigUnit_ControlRigSplineBase
    {
        public RigUnit_PositionFromControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public float U { get { return this[nameof(U)].GetValue<float>(); } set { this[nameof(U)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
    }
    public class RigUnit_TransformFromControlRigSpline : RigUnit_ControlRigSplineBase
    {
        public RigUnit_TransformFromControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public Vector UpVector { get { return this[nameof(UpVector)].As<Vector>(); } set { this["UpVector"] = value; } }
        public float Roll { get { return this[nameof(Roll)].GetValue<float>(); } set { this[nameof(Roll)].SetValue<float>(value); } }
        public float U { get { return this[nameof(U)].GetValue<float>(); } set { this[nameof(U)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
    }
    public class RigUnit_TangentFromControlRigSpline : RigUnit_ControlRigSplineBase
    {
        public RigUnit_TangentFromControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public float U { get { return this[nameof(U)].GetValue<float>(); } set { this[nameof(U)].SetValue<float>(value); } }
        public Vector Tangent { get { return this[nameof(Tangent)].As<Vector>(); } set { this["Tangent"] = value; } }
    }
    public class RigUnit_DrawControlRigSpline : RigUnitMutable
    {
        public RigUnit_DrawControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public float Thickness { get { return this[nameof(Thickness)].GetValue<float>(); } set { this[nameof(Thickness)].SetValue<float>(value); } }
        public int Detail { get { return this[nameof(Detail)].GetValue<int>(); } set { this[nameof(Detail)].SetValue<int>(value); } }
    }
    public class RigUnit_GetLengthControlRigSpline : RigUnit
    {
        public RigUnit_GetLengthControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public float Length { get { return this[nameof(Length)].GetValue<float>(); } set { this[nameof(Length)].SetValue<float>(value); } }
    }
    public class RigUnit_FitChainToSplineCurve : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_FitChainToSplineCurve(nint addr) : base(addr) { }
        public RigElementKeyCollection Items { get { return this[nameof(Items)].As<RigElementKeyCollection>(); } set { this["Items"] = value; } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public EControlRigCurveAlignment Alignment { get { return (EControlRigCurveAlignment)this[nameof(Alignment)].GetValue<int>(); } set { this[nameof(Alignment)].SetValue<int>((int)value); } }
        public float Minimum { get { return this[nameof(Minimum)].GetValue<float>(); } set { this[nameof(Minimum)].SetValue<float>(value); } }
        public float Maximum { get { return this[nameof(Maximum)].GetValue<float>(); } set { this[nameof(Maximum)].SetValue<float>(value); } }
        public int SamplingPrecision { get { return this[nameof(SamplingPrecision)].GetValue<int>(); } set { this[nameof(SamplingPrecision)].SetValue<int>(value); } }
        public Vector PrimaryAxis { get { return this[nameof(PrimaryAxis)].As<Vector>(); } set { this["PrimaryAxis"] = value; } }
        public Vector SecondaryAxis { get { return this[nameof(SecondaryAxis)].As<Vector>(); } set { this["SecondaryAxis"] = value; } }
        public Vector PoleVectorPosition { get { return this[nameof(PoleVectorPosition)].As<Vector>(); } set { this["PoleVectorPosition"] = value; } }
        public Array<RigUnit_FitChainToCurve_Rotation> Rotations { get { return new Array<RigUnit_FitChainToCurve_Rotation>(this[nameof(Rotations)].Address); } }
        public EControlRigAnimEasingType RotationEaseType { get { return (EControlRigAnimEasingType)this[nameof(RotationEaseType)].GetValue<int>(); } set { this[nameof(RotationEaseType)].SetValue<int>((int)value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool bPropagateToChildren { get { return this[nameof(bPropagateToChildren)].Flag; } set { this[nameof(bPropagateToChildren)].Flag = value; } }
        public RigUnit_FitChainToCurve_DebugSettings DebugSettings { get { return this[nameof(DebugSettings)].As<RigUnit_FitChainToCurve_DebugSettings>(); } set { this["DebugSettings"] = value; } }
        public RigUnit_FitChainToCurve_WorkData WorkData { get { return this[nameof(WorkData)].As<RigUnit_FitChainToCurve_WorkData>(); } set { this["WorkData"] = value; } }
    }
    public class RigUnit_FitChainToSplineCurveItemArray : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_FitChainToSplineCurveItemArray(nint addr) : base(addr) { }
        public Array<RigElementKey> Items { get { return new Array<RigElementKey>(this[nameof(Items)].Address); } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public EControlRigCurveAlignment Alignment { get { return (EControlRigCurveAlignment)this[nameof(Alignment)].GetValue<int>(); } set { this[nameof(Alignment)].SetValue<int>((int)value); } }
        public float Minimum { get { return this[nameof(Minimum)].GetValue<float>(); } set { this[nameof(Minimum)].SetValue<float>(value); } }
        public float Maximum { get { return this[nameof(Maximum)].GetValue<float>(); } set { this[nameof(Maximum)].SetValue<float>(value); } }
        public int SamplingPrecision { get { return this[nameof(SamplingPrecision)].GetValue<int>(); } set { this[nameof(SamplingPrecision)].SetValue<int>(value); } }
        public Vector PrimaryAxis { get { return this[nameof(PrimaryAxis)].As<Vector>(); } set { this["PrimaryAxis"] = value; } }
        public Vector SecondaryAxis { get { return this[nameof(SecondaryAxis)].As<Vector>(); } set { this["SecondaryAxis"] = value; } }
        public Vector PoleVectorPosition { get { return this[nameof(PoleVectorPosition)].As<Vector>(); } set { this["PoleVectorPosition"] = value; } }
        public Array<RigUnit_FitChainToCurve_Rotation> Rotations { get { return new Array<RigUnit_FitChainToCurve_Rotation>(this[nameof(Rotations)].Address); } }
        public EControlRigAnimEasingType RotationEaseType { get { return (EControlRigAnimEasingType)this[nameof(RotationEaseType)].GetValue<int>(); } set { this[nameof(RotationEaseType)].SetValue<int>((int)value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool bPropagateToChildren { get { return this[nameof(bPropagateToChildren)].Flag; } set { this[nameof(bPropagateToChildren)].Flag = value; } }
        public RigUnit_FitChainToCurve_DebugSettings DebugSettings { get { return this[nameof(DebugSettings)].As<RigUnit_FitChainToCurve_DebugSettings>(); } set { this["DebugSettings"] = value; } }
        public RigUnit_FitChainToCurve_WorkData WorkData { get { return this[nameof(WorkData)].As<RigUnit_FitChainToCurve_WorkData>(); } set { this["WorkData"] = value; } }
    }
    public class RigUnit_FitSplineCurveToChain : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_FitSplineCurveToChain(nint addr) : base(addr) { }
        public RigElementKeyCollection Items { get { return this[nameof(Items)].As<RigElementKeyCollection>(); } set { this["Items"] = value; } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
    }
    public class RigUnit_FitSplineCurveToChainItemArray : RigUnit_HighlevelBaseMutable
    {
        public RigUnit_FitSplineCurveToChainItemArray(nint addr) : base(addr) { }
        public Array<RigElementKey> Items { get { return new Array<RigElementKey>(this[nameof(Items)].Address); } }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
    }
    public class RigUnit_ClosestParameterFromControlRigSpline : RigUnit_ControlRigSplineBase
    {
        public RigUnit_ClosestParameterFromControlRigSpline(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public float U { get { return this[nameof(U)].GetValue<float>(); } set { this[nameof(U)].SetValue<float>(value); } }
    }
    public class RigUnit_ParameterAtPercentage : RigUnit_ControlRigSplineBase
    {
        public RigUnit_ParameterAtPercentage(nint addr) : base(addr) { }
        public ControlRigSpline Spline { get { return this[nameof(Spline)].As<ControlRigSpline>(); } set { this["Spline"] = value; } }
        public float Percentage { get { return this[nameof(Percentage)].GetValue<float>(); } set { this[nameof(Percentage)].SetValue<float>(value); } }
        public float U { get { return this[nameof(U)].GetValue<float>(); } set { this[nameof(U)].SetValue<float>(value); } }
    }
}
