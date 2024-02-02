using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.SpreadSheetToCsvSDK
{
    public class SpreadSheetImpoter : Object
    {
        public SpreadSheetImpoter(nint addr) : base(addr) { }
        public Object OnGetResult { get { return this[nameof(OnGetResult)]; } set { this[nameof(OnGetResult)] = value; } }
        public Object ErrorLogger { get { return this[nameof(ErrorLogger)]; } set { this[nameof(ErrorLogger)] = value; } }
        public DataTable TargetDataTable { get { return this[nameof(TargetDataTable)].As<DataTable>(); } set { this["TargetDataTable"] = value; } }
        public Array<int> IgnoreRowIndexes { get { return new Array<int>(this[nameof(IgnoreRowIndexes)].Address); } }
        public Object AutoUniqueIdColumnName { get { return this[nameof(AutoUniqueIdColumnName)]; } set { this[nameof(AutoUniqueIdColumnName)] = value; } }
        public Object RowNameHashColumnName { get { return this[nameof(RowNameHashColumnName)]; } set { this[nameof(RowNameHashColumnName)] = value; } }
        public Array<Object> MetaTagText_IgnoreRow { get { return new Array<Object>(this[nameof(MetaTagText_IgnoreRow)].Address); } }
        public Object BlueprintName2ObjectPathColumnNameMap { get { return this[nameof(BlueprintName2ObjectPathColumnNameMap)]; } set { this[nameof(BlueprintName2ObjectPathColumnNameMap)] = value; } }
        public Object BlueprintNamePrefix { get { return this[nameof(BlueprintNamePrefix)]; } set { this[nameof(BlueprintNamePrefix)] = value; } }
        public bool bNoticeMessageAtNewRecordImported { get { return this[nameof(bNoticeMessageAtNewRecordImported)].Flag; } set { this[nameof(bNoticeMessageAtNewRecordImported)].Flag = value; } }
        public Object ToCsvStringForLocalizedText(Object pickCultureName) { return Invoke<Object>(nameof(ToCsvStringForLocalizedText), pickCultureName); }
        public Object ToCsvString() { return Invoke<Object>(nameof(ToCsvString)); }
        public void PostProcessImport(bool bAppliedPostProcess) { Invoke(nameof(PostProcessImport), bAppliedPostProcess); }
        public bool IsExistNewRecord() { return Invoke<bool>(nameof(IsExistNewRecord)); }
        public SpreadSheetImpoter GetRequest(Object sheetId, Object sheetName, Object Key) { return Invoke<SpreadSheetImpoter>(nameof(GetRequest), sheetId, sheetName, Key); }
        public bool FromString(Object Data) { return Invoke<bool>(nameof(FromString), Data); }
        public Object CreateSheetUrlString(Object sheetId, Object sheetNameId) { return Invoke<Object>(nameof(CreateSheetUrlString), sheetId, sheetNameId); }
        public SpreadSheetImpoter Create() { return Invoke<SpreadSheetImpoter>(nameof(Create)); }
    }
    public class SpreadSheetUtility : Object
    {
        public SpreadSheetUtility(nint addr) : base(addr) { }
    }
    public enum EFetchResult : int
    {
        Success = 0,
        HttpFailed = 1,
        JSONParsingFailed = 2,
        EFetchResult_MAX = 3,
    }
}
