using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SunPositionSDK
{
    public class SunPositionFunctionLibrary : BlueprintFunctionLibrary
    {
        public SunPositionFunctionLibrary(nint addr) : base(addr) { }
        public void GetSunPosition(float Latitude, float Longitude, float TimeZone, bool bIsDaylightSavingTime, int Year, int Month, int Day, int Hours, int Minutes, int Seconds, SunPositionData SunPositionData) { Invoke(nameof(GetSunPosition), Latitude, Longitude, TimeZone, bIsDaylightSavingTime, Year, Month, Day, Hours, Minutes, Seconds, SunPositionData); }
    }
    public class SunPositionData : Object
    {
        public SunPositionData(nint addr) : base(addr) { }
        public float Elevation { get { return this[nameof(Elevation)].GetValue<float>(); } set { this[nameof(Elevation)].SetValue<float>(value); } }
        public float CorrectedElevation { get { return this[nameof(CorrectedElevation)].GetValue<float>(); } set { this[nameof(CorrectedElevation)].SetValue<float>(value); } }
        public float Azimuth { get { return this[nameof(Azimuth)].GetValue<float>(); } set { this[nameof(Azimuth)].SetValue<float>(value); } }
        public Timespan SunriseTime { get { return this[nameof(SunriseTime)].As<Timespan>(); } set { this["SunriseTime"] = value; } }
        public Timespan SunsetTime { get { return this[nameof(SunsetTime)].As<Timespan>(); } set { this["SunsetTime"] = value; } }
        public Timespan SolarNoon { get { return this[nameof(SolarNoon)].As<Timespan>(); } set { this["SolarNoon"] = value; } }
    }
}
