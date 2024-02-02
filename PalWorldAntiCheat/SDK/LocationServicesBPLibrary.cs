using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.LocationServicesBPLibrarySDK
{
    public class LocationServices : BlueprintFunctionLibrary
    {
        public LocationServices(nint addr) : base(addr) { }
        public bool StopLocationServices() { return Invoke<bool>(nameof(StopLocationServices)); }
        public bool StartLocationServices() { return Invoke<bool>(nameof(StartLocationServices)); }
        public bool IsLocationAccuracyAvailable(ELocationAccuracy accuracy) { return Invoke<bool>(nameof(IsLocationAccuracyAvailable), accuracy); }
        public bool InitLocationServices(ELocationAccuracy accuracy, float UpdateFrequency, float MinDistanceFilter) { return Invoke<bool>(nameof(InitLocationServices), accuracy, UpdateFrequency, MinDistanceFilter); }
        public LocationServicesImpl GetLocationServicesImpl() { return Invoke<LocationServicesImpl>(nameof(GetLocationServicesImpl)); }
        public LocationServicesData GetLastKnownLocation() { return Invoke<LocationServicesData>(nameof(GetLastKnownLocation)); }
        public bool AreLocationServicesEnabled() { return Invoke<bool>(nameof(AreLocationServicesEnabled)); }
    }
    public class LocationServicesImpl : Object
    {
        public LocationServicesImpl(nint addr) : base(addr) { }
        public Object OnLocationChanged { get { return this[nameof(OnLocationChanged)]; } set { this[nameof(OnLocationChanged)] = value; } }
    }
    public class LocationServicesData : Object
    {
        public LocationServicesData(nint addr) : base(addr) { }
        public float Timestamp { get { return this[nameof(Timestamp)].GetValue<float>(); } set { this[nameof(Timestamp)].SetValue<float>(value); } }
        public float Longitude { get { return this[nameof(Longitude)].GetValue<float>(); } set { this[nameof(Longitude)].SetValue<float>(value); } }
        public float Latitude { get { return this[nameof(Latitude)].GetValue<float>(); } set { this[nameof(Latitude)].SetValue<float>(value); } }
        public float HorizontalAccuracy { get { return this[nameof(HorizontalAccuracy)].GetValue<float>(); } set { this[nameof(HorizontalAccuracy)].SetValue<float>(value); } }
        public float VerticalAccuracy { get { return this[nameof(VerticalAccuracy)].GetValue<float>(); } set { this[nameof(VerticalAccuracy)].SetValue<float>(value); } }
        public float Altitude { get { return this[nameof(Altitude)].GetValue<float>(); } set { this[nameof(Altitude)].SetValue<float>(value); } }
    }
    public enum ELocationAccuracy : int
    {
        LA_ThreeKilometers = 0,
        LA_OneKilometer = 1,
        LA_HundredMeters = 2,
        LA_TenMeters = 3,
        LA_Best = 4,
        LA_Navigation = 5,
        LA_MAX = 6,
    }
}
