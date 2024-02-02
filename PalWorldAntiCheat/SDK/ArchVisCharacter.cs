using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ArchVisCharacterSDK
{
    public class ArchVisCharacter : Character
    {
        public ArchVisCharacter(nint addr) : base(addr) { }
        public Object LookUpAxisName { get { return this[nameof(LookUpAxisName)]; } set { this[nameof(LookUpAxisName)] = value; } }
        public Object LookUpAtRateAxisName { get { return this[nameof(LookUpAtRateAxisName)]; } set { this[nameof(LookUpAtRateAxisName)] = value; } }
        public Object TurnAxisName { get { return this[nameof(TurnAxisName)]; } set { this[nameof(TurnAxisName)] = value; } }
        public Object TurnAtRateAxisName { get { return this[nameof(TurnAtRateAxisName)]; } set { this[nameof(TurnAtRateAxisName)] = value; } }
        public Object MoveForwardAxisName { get { return this[nameof(MoveForwardAxisName)]; } set { this[nameof(MoveForwardAxisName)] = value; } }
        public Object MoveRightAxisName { get { return this[nameof(MoveRightAxisName)]; } set { this[nameof(MoveRightAxisName)] = value; } }
        public float MouseSensitivityScale_Pitch { get { return this[nameof(MouseSensitivityScale_Pitch)].GetValue<float>(); } set { this[nameof(MouseSensitivityScale_Pitch)].SetValue<float>(value); } }
        public float MouseSensitivityScale_Yaw { get { return this[nameof(MouseSensitivityScale_Yaw)].GetValue<float>(); } set { this[nameof(MouseSensitivityScale_Yaw)].SetValue<float>(value); } }
    }
    public class ArchVisCharMovementComponent : CharacterMovementComponent
    {
        public ArchVisCharMovementComponent(nint addr) : base(addr) { }
        public Rotator RotationalAcceleration { get { return this[nameof(RotationalAcceleration)].As<Rotator>(); } set { this["RotationalAcceleration"] = value; } }
        public Rotator RotationalDeceleration { get { return this[nameof(RotationalDeceleration)].As<Rotator>(); } set { this["RotationalDeceleration"] = value; } }
        public Rotator MaxRotationalVelocity { get { return this[nameof(MaxRotationalVelocity)].As<Rotator>(); } set { this["MaxRotationalVelocity"] = value; } }
        public float MinPitch { get { return this[nameof(MinPitch)].GetValue<float>(); } set { this[nameof(MinPitch)].SetValue<float>(value); } }
        public float MaxPitch { get { return this[nameof(MaxPitch)].GetValue<float>(); } set { this[nameof(MaxPitch)].SetValue<float>(value); } }
        public float WalkingFriction { get { return this[nameof(WalkingFriction)].GetValue<float>(); } set { this[nameof(WalkingFriction)].SetValue<float>(value); } }
        public float WalkingSpeed { get { return this[nameof(WalkingSpeed)].GetValue<float>(); } set { this[nameof(WalkingSpeed)].SetValue<float>(value); } }
        public float WalkingAcceleration { get { return this[nameof(WalkingAcceleration)].GetValue<float>(); } set { this[nameof(WalkingAcceleration)].SetValue<float>(value); } }
    }
}
