using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.MovieSceneSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneTracksSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.SequencerScriptingSDK
{
    public class MovieSceneScriptingKey : Object
    {
        public MovieSceneScriptingKey(nint addr) : base(addr) { }
    }
    public class MovieSceneScriptingActorReferenceKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingActorReferenceKey(nint addr) : base(addr) { }
        public void SetValue(MovieSceneObjectBindingID InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public MovieSceneObjectBindingID GetValue() { return Invoke<MovieSceneObjectBindingID>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingChannel : Object
    {
        public MovieSceneScriptingChannel(nint addr) : base(addr) { }
        public Object ChannelName { get { return this[nameof(ChannelName)]; } set { this[nameof(ChannelName)] = value; } }
    }
    public class MovieSceneScriptingActorReferenceChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingActorReferenceChannel(nint addr) : base(addr) { }
        public void SetDefault(MovieSceneObjectBindingID InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public MovieSceneObjectBindingID GetDefault() { return Invoke<MovieSceneObjectBindingID>(nameof(GetDefault)); }
        public MovieSceneScriptingActorReferenceKey AddKey(FrameNumber InTime, MovieSceneObjectBindingID NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingActorReferenceKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneScriptingBoolKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingBoolKey(nint addr) : base(addr) { }
        public void SetValue(bool InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public bool GetValue() { return Invoke<bool>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingBoolChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingBoolChannel(nint addr) : base(addr) { }
        public void SetDefault(bool InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public int GetNumKeys() { return Invoke<int>(nameof(GetNumKeys)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public bool GetDefault() { return Invoke<bool>(nameof(GetDefault)); }
        public Array<bool> EvaluateKeys(SequencerScriptingRange Range, FrameRate FrameRate) { return Invoke<Array<bool>>(nameof(EvaluateKeys), Range, FrameRate); }
        public SequencerScriptingRange ComputeEffectiveRange() { return Invoke<SequencerScriptingRange>(nameof(ComputeEffectiveRange)); }
        public MovieSceneScriptingBoolKey AddKey(FrameNumber InTime, bool NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingBoolKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneScriptingByteKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingByteKey(nint addr) : base(addr) { }
        public void SetValue(byte InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public byte GetValue() { return Invoke<byte>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingByteChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingByteChannel(nint addr) : base(addr) { }
        public void SetDefault(byte InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public byte GetDefault() { return Invoke<byte>(nameof(GetDefault)); }
        public MovieSceneScriptingByteKey AddKey(FrameNumber InTime, byte NewValue, float SubFrame, ESequenceTimeUnit TimeUnit, EMovieSceneKeyInterpolation InInterpolation) { return Invoke<MovieSceneScriptingByteKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit, InInterpolation); }
    }
    public class MovieSceneScriptingDoubleKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingDoubleKey(nint addr) : base(addr) { }
        public void SetValue(double InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public void SetTangentWeightMode(byte InNewValue) { Invoke(nameof(SetTangentWeightMode), InNewValue); }
        public void SetTangentMode(byte InNewValue) { Invoke(nameof(SetTangentMode), InNewValue); }
        public void SetLeaveTangentWeight(float InNewValue) { Invoke(nameof(SetLeaveTangentWeight), InNewValue); }
        public void SetLeaveTangent(float InNewValue) { Invoke(nameof(SetLeaveTangent), InNewValue); }
        public void SetInterpolationMode(byte InNewValue) { Invoke(nameof(SetInterpolationMode), InNewValue); }
        public void SetArriveTangentWeight(float InNewValue) { Invoke(nameof(SetArriveTangentWeight), InNewValue); }
        public void SetArriveTangent(float InNewValue) { Invoke(nameof(SetArriveTangent), InNewValue); }
        public double GetValue() { return Invoke<double>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
        public byte GetTangentWeightMode() { return Invoke<byte>(nameof(GetTangentWeightMode)); }
        public byte GetTangentMode() { return Invoke<byte>(nameof(GetTangentMode)); }
        public float GetLeaveTangentWeight() { return Invoke<float>(nameof(GetLeaveTangentWeight)); }
        public float GetLeaveTangent() { return Invoke<float>(nameof(GetLeaveTangent)); }
        public byte GetInterpolationMode() { return Invoke<byte>(nameof(GetInterpolationMode)); }
        public float GetArriveTangentWeight() { return Invoke<float>(nameof(GetArriveTangentWeight)); }
        public float GetArriveTangent() { return Invoke<float>(nameof(GetArriveTangent)); }
    }
    public class MovieSceneScriptingDoubleChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingDoubleChannel(nint addr) : base(addr) { }
        public void SetPreInfinityExtrapolation(byte InExtrapolation) { Invoke(nameof(SetPreInfinityExtrapolation), InExtrapolation); }
        public void SetPostInfinityExtrapolation(byte InExtrapolation) { Invoke(nameof(SetPostInfinityExtrapolation), InExtrapolation); }
        public void SetDefault(double InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public byte GetPreInfinityExtrapolation() { return Invoke<byte>(nameof(GetPreInfinityExtrapolation)); }
        public byte GetPostInfinityExtrapolation() { return Invoke<byte>(nameof(GetPostInfinityExtrapolation)); }
        public int GetNumKeys() { return Invoke<int>(nameof(GetNumKeys)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public double GetDefault() { return Invoke<double>(nameof(GetDefault)); }
        public Array<double> EvaluateKeys(SequencerScriptingRange Range, FrameRate FrameRate) { return Invoke<Array<double>>(nameof(EvaluateKeys), Range, FrameRate); }
        public SequencerScriptingRange ComputeEffectiveRange() { return Invoke<SequencerScriptingRange>(nameof(ComputeEffectiveRange)); }
        public MovieSceneScriptingDoubleKey AddKey(FrameNumber InTime, double NewValue, float SubFrame, ESequenceTimeUnit TimeUnit, EMovieSceneKeyInterpolation InInterpolation) { return Invoke<MovieSceneScriptingDoubleKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit, InInterpolation); }
    }
    public class MovieSceneScriptingEventKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingEventKey(nint addr) : base(addr) { }
        public void SetValue(MovieSceneEvent InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public MovieSceneEvent GetValue() { return Invoke<MovieSceneEvent>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingEventChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingEventChannel(nint addr) : base(addr) { }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public MovieSceneScriptingEventKey AddKey(FrameNumber InTime, MovieSceneEvent NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingEventKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneScriptingFloatKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingFloatKey(nint addr) : base(addr) { }
        public void SetValue(float InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public void SetTangentWeightMode(byte InNewValue) { Invoke(nameof(SetTangentWeightMode), InNewValue); }
        public void SetTangentMode(byte InNewValue) { Invoke(nameof(SetTangentMode), InNewValue); }
        public void SetLeaveTangentWeight(float InNewValue) { Invoke(nameof(SetLeaveTangentWeight), InNewValue); }
        public void SetLeaveTangent(float InNewValue) { Invoke(nameof(SetLeaveTangent), InNewValue); }
        public void SetInterpolationMode(byte InNewValue) { Invoke(nameof(SetInterpolationMode), InNewValue); }
        public void SetArriveTangentWeight(float InNewValue) { Invoke(nameof(SetArriveTangentWeight), InNewValue); }
        public void SetArriveTangent(float InNewValue) { Invoke(nameof(SetArriveTangent), InNewValue); }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
        public byte GetTangentWeightMode() { return Invoke<byte>(nameof(GetTangentWeightMode)); }
        public byte GetTangentMode() { return Invoke<byte>(nameof(GetTangentMode)); }
        public float GetLeaveTangentWeight() { return Invoke<float>(nameof(GetLeaveTangentWeight)); }
        public float GetLeaveTangent() { return Invoke<float>(nameof(GetLeaveTangent)); }
        public byte GetInterpolationMode() { return Invoke<byte>(nameof(GetInterpolationMode)); }
        public float GetArriveTangentWeight() { return Invoke<float>(nameof(GetArriveTangentWeight)); }
        public float GetArriveTangent() { return Invoke<float>(nameof(GetArriveTangent)); }
    }
    public class MovieSceneScriptingActualFloatKey : MovieSceneScriptingFloatKey
    {
        public MovieSceneScriptingActualFloatKey(nint addr) : base(addr) { }
    }
    public class MovieSceneScriptingDoubleAsFloatKey : MovieSceneScriptingFloatKey
    {
        public MovieSceneScriptingDoubleAsFloatKey(nint addr) : base(addr) { }
    }
    public class MovieSceneScriptingFloatChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingFloatChannel(nint addr) : base(addr) { }
        public void SetPreInfinityExtrapolation(byte InExtrapolation) { Invoke(nameof(SetPreInfinityExtrapolation), InExtrapolation); }
        public void SetPostInfinityExtrapolation(byte InExtrapolation) { Invoke(nameof(SetPostInfinityExtrapolation), InExtrapolation); }
        public void SetDefault(float InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public byte GetPreInfinityExtrapolation() { return Invoke<byte>(nameof(GetPreInfinityExtrapolation)); }
        public byte GetPostInfinityExtrapolation() { return Invoke<byte>(nameof(GetPostInfinityExtrapolation)); }
        public int GetNumKeys() { return Invoke<int>(nameof(GetNumKeys)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public float GetDefault() { return Invoke<float>(nameof(GetDefault)); }
        public Array<float> EvaluateKeys(SequencerScriptingRange Range, FrameRate FrameRate) { return Invoke<Array<float>>(nameof(EvaluateKeys), Range, FrameRate); }
        public SequencerScriptingRange ComputeEffectiveRange() { return Invoke<SequencerScriptingRange>(nameof(ComputeEffectiveRange)); }
        public MovieSceneScriptingFloatKey AddKey(FrameNumber InTime, float NewValue, float SubFrame, ESequenceTimeUnit TimeUnit, EMovieSceneKeyInterpolation InInterpolation) { return Invoke<MovieSceneScriptingFloatKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit, InInterpolation); }
    }
    public class MovieSceneScriptingIntegerKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingIntegerKey(nint addr) : base(addr) { }
        public void SetValue(int InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public int GetValue() { return Invoke<int>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingIntegerChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingIntegerChannel(nint addr) : base(addr) { }
        public void SetDefault(int InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public int GetDefault() { return Invoke<int>(nameof(GetDefault)); }
        public MovieSceneScriptingIntegerKey AddKey(FrameNumber InTime, int NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingIntegerKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneScriptingObjectPathKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingObjectPathKey(nint addr) : base(addr) { }
        public void SetValue(Object InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public Object GetValue() { return Invoke<Object>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingObjectPathChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingObjectPathChannel(nint addr) : base(addr) { }
        public void SetDefault(Object InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public Object GetDefault() { return Invoke<Object>(nameof(GetDefault)); }
        public MovieSceneScriptingObjectPathKey AddKey(FrameNumber InTime, Object NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingObjectPathKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneScriptingStringKey : MovieSceneScriptingKey
    {
        public MovieSceneScriptingStringKey(nint addr) : base(addr) { }
        public void SetValue(Object InNewValue) { Invoke(nameof(SetValue), InNewValue); }
        public void SetTime(FrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit) { Invoke(nameof(SetTime), NewFrameNumber, SubFrame, TimeUnit); }
        public Object GetValue() { return Invoke<Object>(nameof(GetValue)); }
        public FrameTime GetTime(ESequenceTimeUnit TimeUnit) { return Invoke<FrameTime>(nameof(GetTime), TimeUnit); }
    }
    public class MovieSceneScriptingStringChannel : MovieSceneScriptingChannel
    {
        public MovieSceneScriptingStringChannel(nint addr) : base(addr) { }
        public void SetDefault(Object InDefaultValue) { Invoke(nameof(SetDefault), InDefaultValue); }
        public void RemoveKey(MovieSceneScriptingKey Key) { Invoke(nameof(RemoveKey), Key); }
        public void RemoveDefault() { Invoke(nameof(RemoveDefault)); }
        public bool HasDefault() { return Invoke<bool>(nameof(HasDefault)); }
        public Array<MovieSceneScriptingKey> GetKeys() { return Invoke<Array<MovieSceneScriptingKey>>(nameof(GetKeys)); }
        public Object GetDefault() { return Invoke<Object>(nameof(GetDefault)); }
        public MovieSceneScriptingStringKey AddKey(FrameNumber InTime, Object NewValue, float SubFrame, ESequenceTimeUnit TimeUnit) { return Invoke<MovieSceneScriptingStringKey>(nameof(AddKey), InTime, NewValue, SubFrame, TimeUnit); }
    }
    public class MovieSceneBindingExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneBindingExtensions(nint addr) : base(addr) { }
        public void SetParent(MovieSceneBindingProxy InBinding, MovieSceneBindingProxy InParentBinding) { Invoke(nameof(SetParent), InBinding, InParentBinding); }
        public void SetName(MovieSceneBindingProxy InBinding, Object InName) { Invoke(nameof(SetName), InBinding, InName); }
        public void SetDisplayName(MovieSceneBindingProxy InBinding, Object InDisplayName) { Invoke(nameof(SetDisplayName), InBinding, InDisplayName); }
        public void RemoveTrack(MovieSceneBindingProxy InBinding, MovieSceneTrack TrackToRemove) { Invoke(nameof(RemoveTrack), InBinding, TrackToRemove); }
        public void Remove(MovieSceneBindingProxy InBinding) { Invoke(nameof(Remove), InBinding); }
        public void MoveBindingContents(MovieSceneBindingProxy SourceBindingId, MovieSceneBindingProxy DestinationBindingId) { Invoke(nameof(MoveBindingContents), SourceBindingId, DestinationBindingId); }
        public bool IsValid(MovieSceneBindingProxy InBinding) { return Invoke<bool>(nameof(IsValid), InBinding); }
        public Array<MovieSceneTrack> GetTracks(MovieSceneBindingProxy InBinding) { return Invoke<Array<MovieSceneTrack>>(nameof(GetTracks), InBinding); }
        public Object GetPossessedObjectClass(MovieSceneBindingProxy InBinding) { return Invoke<Object>(nameof(GetPossessedObjectClass), InBinding); }
        public MovieSceneBindingProxy GetParent(MovieSceneBindingProxy InBinding) { return Invoke<MovieSceneBindingProxy>(nameof(GetParent), InBinding); }
        public Object GetObjectTemplate(MovieSceneBindingProxy InBinding) { return Invoke<Object>(nameof(GetObjectTemplate), InBinding); }
        public Object GetName(MovieSceneBindingProxy InBinding) { return Invoke<Object>(nameof(GetName), InBinding); }
        public Guid GetId(MovieSceneBindingProxy InBinding) { return Invoke<Guid>(nameof(GetId), InBinding); }
        public Object GetDisplayName(MovieSceneBindingProxy InBinding) { return Invoke<Object>(nameof(GetDisplayName), InBinding); }
        public Array<MovieSceneBindingProxy> GetChildPossessables(MovieSceneBindingProxy InBinding) { return Invoke<Array<MovieSceneBindingProxy>>(nameof(GetChildPossessables), InBinding); }
        public Array<MovieSceneTrack> FindTracksByType(MovieSceneBindingProxy InBinding, Object TrackType) { return Invoke<Array<MovieSceneTrack>>(nameof(FindTracksByType), InBinding, TrackType); }
        public Array<MovieSceneTrack> FindTracksByExactType(MovieSceneBindingProxy InBinding, Object TrackType) { return Invoke<Array<MovieSceneTrack>>(nameof(FindTracksByExactType), InBinding, TrackType); }
        public MovieSceneTrack AddTrack(MovieSceneBindingProxy InBinding, Object TrackType) { return Invoke<MovieSceneTrack>(nameof(AddTrack), InBinding, TrackType); }
    }
    public class MovieSceneEventTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneEventTrackExtensions(nint addr) : base(addr) { }
        public Object GetBoundObjectPropertyClass(MovieSceneEvent EventKey) { return Invoke<Object>(nameof(GetBoundObjectPropertyClass), EventKey); }
        public MovieSceneEventTriggerSection AddEventTriggerSection(MovieSceneEventTrack InTrack) { return Invoke<MovieSceneEventTriggerSection>(nameof(AddEventTriggerSection), InTrack); }
        public MovieSceneEventRepeaterSection AddEventRepeaterSection(MovieSceneEventTrack InTrack) { return Invoke<MovieSceneEventRepeaterSection>(nameof(AddEventRepeaterSection), InTrack); }
    }
    public class MovieSceneFolderExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneFolderExtensions(nint addr) : base(addr) { }
        public bool SetFolderName(MovieSceneFolder Folder, Object InFolderName) { return Invoke<bool>(nameof(SetFolderName), Folder, InFolderName); }
        public bool SetFolderColor(MovieSceneFolder Folder, Color InFolderColor) { return Invoke<bool>(nameof(SetFolderColor), Folder, InFolderColor); }
        public bool RemoveChildObjectBinding(MovieSceneFolder Folder, MovieSceneBindingProxy InObjectBinding) { return Invoke<bool>(nameof(RemoveChildObjectBinding), Folder, InObjectBinding); }
        public bool RemoveChildMasterTrack(MovieSceneFolder Folder, MovieSceneTrack InMasterTrack) { return Invoke<bool>(nameof(RemoveChildMasterTrack), Folder, InMasterTrack); }
        public bool RemoveChildFolder(MovieSceneFolder TargetFolder, MovieSceneFolder FolderToRemove) { return Invoke<bool>(nameof(RemoveChildFolder), TargetFolder, FolderToRemove); }
        public Object GetFolderName(MovieSceneFolder Folder) { return Invoke<Object>(nameof(GetFolderName), Folder); }
        public Color GetFolderColor(MovieSceneFolder Folder) { return Invoke<Color>(nameof(GetFolderColor), Folder); }
        public Array<MovieSceneBindingProxy> GetChildObjectBindings(MovieSceneFolder Folder) { return Invoke<Array<MovieSceneBindingProxy>>(nameof(GetChildObjectBindings), Folder); }
        public Array<MovieSceneTrack> GetChildMasterTracks(MovieSceneFolder Folder) { return Invoke<Array<MovieSceneTrack>>(nameof(GetChildMasterTracks), Folder); }
        public Array<MovieSceneFolder> GetChildFolders(MovieSceneFolder Folder) { return Invoke<Array<MovieSceneFolder>>(nameof(GetChildFolders), Folder); }
        public bool AddChildObjectBinding(MovieSceneFolder Folder, MovieSceneBindingProxy InObjectBinding) { return Invoke<bool>(nameof(AddChildObjectBinding), Folder, InObjectBinding); }
        public bool AddChildMasterTrack(MovieSceneFolder Folder, MovieSceneTrack InMasterTrack) { return Invoke<bool>(nameof(AddChildMasterTrack), Folder, InMasterTrack); }
        public bool AddChildFolder(MovieSceneFolder TargetFolder, MovieSceneFolder FolderToAdd) { return Invoke<bool>(nameof(AddChildFolder), TargetFolder, FolderToAdd); }
    }
    public class MovieSceneMaterialTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneMaterialTrackExtensions(nint addr) : base(addr) { }
        public void SetMaterialIndex(MovieSceneComponentMaterialTrack Track, int MaterialIndex) { Invoke(nameof(SetMaterialIndex), Track, MaterialIndex); }
        public int GetMaterialIndex(MovieSceneComponentMaterialTrack Track) { return Invoke<int>(nameof(GetMaterialIndex), Track); }
    }
    public class MovieScenePrimitiveMaterialTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieScenePrimitiveMaterialTrackExtensions(nint addr) : base(addr) { }
        public void SetMaterialIndex(MovieScenePrimitiveMaterialTrack Track, int MaterialIndex) { Invoke(nameof(SetMaterialIndex), Track, MaterialIndex); }
        public int GetMaterialIndex(MovieScenePrimitiveMaterialTrack Track) { return Invoke<int>(nameof(GetMaterialIndex), Track); }
    }
    public class MovieScenePropertyTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieScenePropertyTrackExtensions(nint addr) : base(addr) { }
        public void SetPropertyNameAndPath(MovieScenePropertyTrack Track, Object InPropertyName, Object InPropertyPath) { Invoke(nameof(SetPropertyNameAndPath), Track, InPropertyName, InPropertyPath); }
        public void SetObjectPropertyClass(MovieSceneObjectPropertyTrack Track, Object PropertyClass) { Invoke(nameof(SetObjectPropertyClass), Track, PropertyClass); }
        public void SetByteTrackEnum(MovieSceneByteTrack Track, Enum InEnum) { Invoke(nameof(SetByteTrackEnum), Track, InEnum); }
        public Object GetUniqueTrackName(MovieScenePropertyTrack Track) { return Invoke<Object>(nameof(GetUniqueTrackName), Track); }
        public Object GetPropertyPath(MovieScenePropertyTrack Track) { return Invoke<Object>(nameof(GetPropertyPath), Track); }
        public Object GetPropertyName(MovieScenePropertyTrack Track) { return Invoke<Object>(nameof(GetPropertyName), Track); }
        public Object GetObjectPropertyClass(MovieSceneObjectPropertyTrack Track) { return Invoke<Object>(nameof(GetObjectPropertyClass), Track); }
        public Enum GetByteTrackEnum(MovieSceneByteTrack Track) { return Invoke<Enum>(nameof(GetByteTrackEnum), Track); }
    }
    public class MovieSceneSectionExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneSectionExtensions(nint addr) : base(addr) { }
        public void SetStartFrameSeconds(MovieSceneSection Section, float StartTime) { Invoke(nameof(SetStartFrameSeconds), Section, StartTime); }
        public void SetStartFrameBounded(MovieSceneSection Section, bool bIsBounded) { Invoke(nameof(SetStartFrameBounded), Section, bIsBounded); }
        public void SetStartFrame(MovieSceneSection Section, int StartFrame) { Invoke(nameof(SetStartFrame), Section, StartFrame); }
        public void SetRangeSeconds(MovieSceneSection Section, float StartTime, float EndTime) { Invoke(nameof(SetRangeSeconds), Section, StartTime, EndTime); }
        public void SetRange(MovieSceneSection Section, int StartFrame, int EndFrame) { Invoke(nameof(SetRange), Section, StartFrame, EndFrame); }
        public void SetEndFrameSeconds(MovieSceneSection Section, float EndTime) { Invoke(nameof(SetEndFrameSeconds), Section, EndTime); }
        public void SetEndFrameBounded(MovieSceneSection Section, bool bIsBounded) { Invoke(nameof(SetEndFrameBounded), Section, bIsBounded); }
        public void SetEndFrame(MovieSceneSection Section, int EndFrame) { Invoke(nameof(SetEndFrame), Section, EndFrame); }
        public bool HasStartFrame(MovieSceneSection Section) { return Invoke<bool>(nameof(HasStartFrame), Section); }
        public bool HasEndFrame(MovieSceneSection Section) { return Invoke<bool>(nameof(HasEndFrame), Section); }
        public float GetStartFrameSeconds(MovieSceneSection Section) { return Invoke<float>(nameof(GetStartFrameSeconds), Section); }
        public int GetStartFrame(MovieSceneSection Section) { return Invoke<int>(nameof(GetStartFrame), Section); }
        public int GetParentSequenceFrame(MovieSceneSubSection Section, int InFrame, MovieSceneSequence ParentSequence) { return Invoke<int>(nameof(GetParentSequenceFrame), Section, InFrame, ParentSequence); }
        public float GetEndFrameSeconds(MovieSceneSection Section) { return Invoke<float>(nameof(GetEndFrameSeconds), Section); }
        public int GetEndFrame(MovieSceneSection Section) { return Invoke<int>(nameof(GetEndFrame), Section); }
        public Array<MovieSceneScriptingChannel> GetChannelsByType(MovieSceneSection Section, Object ChannelType) { return Invoke<Array<MovieSceneScriptingChannel>>(nameof(GetChannelsByType), Section, ChannelType); }
        public Array<MovieSceneScriptingChannel> GetChannels(MovieSceneSection Section) { return Invoke<Array<MovieSceneScriptingChannel>>(nameof(GetChannels), Section); }
        public float GetAutoSizeStartFrameSeconds(MovieSceneSection Section) { return Invoke<float>(nameof(GetAutoSizeStartFrameSeconds), Section); }
        public int GetAutoSizeStartFrame(MovieSceneSection Section) { return Invoke<int>(nameof(GetAutoSizeStartFrame), Section); }
        public bool GetAutoSizeHasStartFrame(MovieSceneSection Section) { return Invoke<bool>(nameof(GetAutoSizeHasStartFrame), Section); }
        public bool GetAutoSizeHasEndFrame(MovieSceneSection Section) { return Invoke<bool>(nameof(GetAutoSizeHasEndFrame), Section); }
        public float GetAutoSizeEndFrameSeconds(MovieSceneSection Section) { return Invoke<float>(nameof(GetAutoSizeEndFrameSeconds), Section); }
        public int GetAutoSizeEndFrame(MovieSceneSection Section) { return Invoke<int>(nameof(GetAutoSizeEndFrame), Section); }
        public Array<MovieSceneScriptingChannel> GetAllChannels(MovieSceneSection Section) { return Invoke<Array<MovieSceneScriptingChannel>>(nameof(GetAllChannels), Section); }
        public Array<MovieSceneScriptingChannel> FindChannelsByType(MovieSceneSection Section, Object ChannelType) { return Invoke<Array<MovieSceneScriptingChannel>>(nameof(FindChannelsByType), Section, ChannelType); }
    }
    public class MovieSceneSequenceExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneSequenceExtensions(nint addr) : base(addr) { }
        public void SortMarkedFrames(MovieSceneSequence Sequence) { Invoke(nameof(SortMarkedFrames), Sequence); }
        public void SetWorkRangeStart(MovieSceneSequence InSequence, float StartTimeInSeconds) { Invoke(nameof(SetWorkRangeStart), InSequence, StartTimeInSeconds); }
        public void SetWorkRangeEnd(MovieSceneSequence InSequence, float EndTimeInSeconds) { Invoke(nameof(SetWorkRangeEnd), InSequence, EndTimeInSeconds); }
        public void SetViewRangeStart(MovieSceneSequence InSequence, float StartTimeInSeconds) { Invoke(nameof(SetViewRangeStart), InSequence, StartTimeInSeconds); }
        public void SetViewRangeEnd(MovieSceneSequence InSequence, float EndTimeInSeconds) { Invoke(nameof(SetViewRangeEnd), InSequence, EndTimeInSeconds); }
        public void SetTickResolutionDirectly(MovieSceneSequence Sequence, FrameRate TickResolution) { Invoke(nameof(SetTickResolutionDirectly), Sequence, TickResolution); }
        public void SetTickResolution(MovieSceneSequence Sequence, FrameRate TickResolution) { Invoke(nameof(SetTickResolution), Sequence, TickResolution); }
        public void SetReadOnly(MovieSceneSequence Sequence, bool bInReadOnly) { Invoke(nameof(SetReadOnly), Sequence, bInReadOnly); }
        public void SetPlaybackStartSeconds(MovieSceneSequence Sequence, float StartTime) { Invoke(nameof(SetPlaybackStartSeconds), Sequence, StartTime); }
        public void SetPlaybackStart(MovieSceneSequence Sequence, int StartFrame) { Invoke(nameof(SetPlaybackStart), Sequence, StartFrame); }
        public void SetPlaybackEndSeconds(MovieSceneSequence Sequence, float EndTime) { Invoke(nameof(SetPlaybackEndSeconds), Sequence, EndTime); }
        public void SetPlaybackEnd(MovieSceneSequence Sequence, int EndFrame) { Invoke(nameof(SetPlaybackEnd), Sequence, EndFrame); }
        public void SetMarkedFrame(MovieSceneSequence Sequence, int InMarkIndex, FrameNumber InFrameNumber) { Invoke(nameof(SetMarkedFrame), Sequence, InMarkIndex, InFrameNumber); }
        public void SetEvaluationType(MovieSceneSequence InSequence, EMovieSceneEvaluationType InEvaluationType) { Invoke(nameof(SetEvaluationType), InSequence, InEvaluationType); }
        public void SetDisplayRate(MovieSceneSequence Sequence, FrameRate DisplayRate) { Invoke(nameof(SetDisplayRate), Sequence, DisplayRate); }
        public void SetClockSource(MovieSceneSequence InSequence, EUpdateClockSource InClockSource) { Invoke(nameof(SetClockSource), InSequence, InClockSource); }
        public MovieSceneBindingProxy ResolveBindingID(MovieSceneSequence MasterSequence, MovieSceneObjectBindingID InObjectBindingID) { return Invoke<MovieSceneBindingProxy>(nameof(ResolveBindingID), MasterSequence, InObjectBindingID); }
        public void RemoveRootFolderFromSequence(MovieSceneSequence Sequence, MovieSceneFolder Folder) { Invoke(nameof(RemoveRootFolderFromSequence), Sequence, Folder); }
        public bool RemoveMasterTrack(MovieSceneSequence Sequence, MovieSceneTrack MasterTrack) { return Invoke<bool>(nameof(RemoveMasterTrack), Sequence, MasterTrack); }
        public SequencerScriptingRange MakeRangeSeconds(MovieSceneSequence Sequence, float StartTime, float Duration) { return Invoke<SequencerScriptingRange>(nameof(MakeRangeSeconds), Sequence, StartTime, Duration); }
        public SequencerScriptingRange MakeRange(MovieSceneSequence Sequence, int StartFrame, int Duration) { return Invoke<SequencerScriptingRange>(nameof(MakeRange), Sequence, StartFrame, Duration); }
        public MovieSceneObjectBindingID MakeBindingID(MovieSceneSequence MasterSequence, MovieSceneBindingProxy InBinding, EMovieSceneObjectBindingSpace space) { return Invoke<MovieSceneObjectBindingID>(nameof(MakeBindingID), MasterSequence, InBinding, space); }
        public Array<Object> LocateBoundObjects(MovieSceneSequence Sequence, MovieSceneBindingProxy InBinding, Object Context) { return Invoke<Array<Object>>(nameof(LocateBoundObjects), Sequence, InBinding, Context); }
        public bool IsReadOnly(MovieSceneSequence Sequence) { return Invoke<bool>(nameof(IsReadOnly), Sequence); }
        public float GetWorkRangeStart(MovieSceneSequence InSequence) { return Invoke<float>(nameof(GetWorkRangeStart), InSequence); }
        public float GetWorkRangeEnd(MovieSceneSequence InSequence) { return Invoke<float>(nameof(GetWorkRangeEnd), InSequence); }
        public float GetViewRangeStart(MovieSceneSequence InSequence) { return Invoke<float>(nameof(GetViewRangeStart), InSequence); }
        public float GetViewRangeEnd(MovieSceneSequence InSequence) { return Invoke<float>(nameof(GetViewRangeEnd), InSequence); }
        public Timecode GetTimecodeSource(MovieSceneSequence Sequence) { return Invoke<Timecode>(nameof(GetTimecodeSource), Sequence); }
        public FrameRate GetTickResolution(MovieSceneSequence Sequence) { return Invoke<FrameRate>(nameof(GetTickResolution), Sequence); }
        public Array<MovieSceneBindingProxy> GetSpawnables(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneBindingProxy>>(nameof(GetSpawnables), Sequence); }
        public Array<MovieSceneFolder> GetRootFoldersInSequence(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneFolder>>(nameof(GetRootFoldersInSequence), Sequence); }
        public Array<MovieSceneBindingProxy> GetPossessables(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneBindingProxy>>(nameof(GetPossessables), Sequence); }
        public MovieSceneObjectBindingID GetPortableBindingID(MovieSceneSequence MasterSequence, MovieSceneSequence DestinationSequence, MovieSceneBindingProxy InBinding) { return Invoke<MovieSceneObjectBindingID>(nameof(GetPortableBindingID), MasterSequence, DestinationSequence, InBinding); }
        public float GetPlaybackStartSeconds(MovieSceneSequence Sequence) { return Invoke<float>(nameof(GetPlaybackStartSeconds), Sequence); }
        public int GetPlaybackStart(MovieSceneSequence Sequence) { return Invoke<int>(nameof(GetPlaybackStart), Sequence); }
        public SequencerScriptingRange GetPlaybackRange(MovieSceneSequence Sequence) { return Invoke<SequencerScriptingRange>(nameof(GetPlaybackRange), Sequence); }
        public float GetPlaybackEndSeconds(MovieSceneSequence Sequence) { return Invoke<float>(nameof(GetPlaybackEndSeconds), Sequence); }
        public int GetPlaybackEnd(MovieSceneSequence Sequence) { return Invoke<int>(nameof(GetPlaybackEnd), Sequence); }
        public MovieScene GetMovieScene(MovieSceneSequence Sequence) { return Invoke<MovieScene>(nameof(GetMovieScene), Sequence); }
        public Array<MovieSceneTrack> GetMasterTracks(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneTrack>>(nameof(GetMasterTracks), Sequence); }
        public Array<MovieSceneMarkedFrame> GetMarkedFrames(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneMarkedFrame>>(nameof(GetMarkedFrames), Sequence); }
        public EMovieSceneEvaluationType GetEvaluationType(MovieSceneSequence InSequence) { return Invoke<EMovieSceneEvaluationType>(nameof(GetEvaluationType), InSequence); }
        public FrameRate GetDisplayRate(MovieSceneSequence Sequence) { return Invoke<FrameRate>(nameof(GetDisplayRate), Sequence); }
        public EUpdateClockSource GetClockSource(MovieSceneSequence InSequence) { return Invoke<EUpdateClockSource>(nameof(GetClockSource), InSequence); }
        public Array<MovieSceneBindingProxy> GetBindings(MovieSceneSequence Sequence) { return Invoke<Array<MovieSceneBindingProxy>>(nameof(GetBindings), Sequence); }
        public MovieSceneObjectBindingID GetBindingID(MovieSceneBindingProxy InBinding) { return Invoke<MovieSceneObjectBindingID>(nameof(GetBindingID), InBinding); }
        public int FindNextMarkedFrame(MovieSceneSequence Sequence, FrameNumber InFrameNumber, bool bForward) { return Invoke<int>(nameof(FindNextMarkedFrame), Sequence, InFrameNumber, bForward); }
        public Array<MovieSceneTrack> FindMasterTracksByType(MovieSceneSequence Sequence, Object TrackType) { return Invoke<Array<MovieSceneTrack>>(nameof(FindMasterTracksByType), Sequence, TrackType); }
        public Array<MovieSceneTrack> FindMasterTracksByExactType(MovieSceneSequence Sequence, Object TrackType) { return Invoke<Array<MovieSceneTrack>>(nameof(FindMasterTracksByExactType), Sequence, TrackType); }
        public int FindMarkedFrameByLabel(MovieSceneSequence Sequence, Object InLabel) { return Invoke<int>(nameof(FindMarkedFrameByLabel), Sequence, InLabel); }
        public int FindMarkedFrameByFrameNumber(MovieSceneSequence Sequence, FrameNumber InFrameNumber) { return Invoke<int>(nameof(FindMarkedFrameByFrameNumber), Sequence, InFrameNumber); }
        public MovieSceneBindingProxy FindBindingByName(MovieSceneSequence Sequence, Object Name) { return Invoke<MovieSceneBindingProxy>(nameof(FindBindingByName), Sequence, Name); }
        public MovieSceneBindingProxy FindBindingById(MovieSceneSequence Sequence, Guid BindingId) { return Invoke<MovieSceneBindingProxy>(nameof(FindBindingById), Sequence, BindingId); }
        public void DeleteMarkedFrames(MovieSceneSequence Sequence) { Invoke(nameof(DeleteMarkedFrames), Sequence); }
        public void DeleteMarkedFrame(MovieSceneSequence Sequence, int DeleteIndex) { Invoke(nameof(DeleteMarkedFrame), Sequence, DeleteIndex); }
        public MovieSceneBindingProxy AddSpawnableFromInstance(MovieSceneSequence Sequence, Object ObjectToSpawn) { return Invoke<MovieSceneBindingProxy>(nameof(AddSpawnableFromInstance), Sequence, ObjectToSpawn); }
        public MovieSceneBindingProxy AddSpawnableFromClass(MovieSceneSequence Sequence, Object ClassToSpawn) { return Invoke<MovieSceneBindingProxy>(nameof(AddSpawnableFromClass), Sequence, ClassToSpawn); }
        public MovieSceneFolder AddRootFolderToSequence(MovieSceneSequence Sequence, Object NewFolderName) { return Invoke<MovieSceneFolder>(nameof(AddRootFolderToSequence), Sequence, NewFolderName); }
        public MovieSceneBindingProxy AddPossessable(MovieSceneSequence Sequence, Object ObjectToPossess) { return Invoke<MovieSceneBindingProxy>(nameof(AddPossessable), Sequence, ObjectToPossess); }
        public MovieSceneTrack AddMasterTrack(MovieSceneSequence Sequence, Object TrackType) { return Invoke<MovieSceneTrack>(nameof(AddMasterTrack), Sequence, TrackType); }
        public int AddMarkedFrame(MovieSceneSequence Sequence, MovieSceneMarkedFrame InMarkedFrame) { return Invoke<int>(nameof(AddMarkedFrame), Sequence, InMarkedFrame); }
    }
    public class MovieSceneTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneTrackExtensions(nint addr) : base(addr) { }
        public void SetTrackRowDisplayName(MovieSceneTrack Track, Object InName, int RowIndex) { Invoke(nameof(SetTrackRowDisplayName), Track, InName, RowIndex); }
        public void SetSortingOrder(MovieSceneTrack Track, int SortingOrder) { Invoke(nameof(SetSortingOrder), Track, SortingOrder); }
        public void SetSectionToKey(MovieSceneTrack Track, MovieSceneSection Section) { Invoke(nameof(SetSectionToKey), Track, Section); }
        public void SetDisplayName(MovieSceneTrack Track, Object InName) { Invoke(nameof(SetDisplayName), Track, InName); }
        public void SetColorTint(MovieSceneTrack Track, Color ColorTint) { Invoke(nameof(SetColorTint), Track, ColorTint); }
        public void RemoveSection(MovieSceneTrack Track, MovieSceneSection Section) { Invoke(nameof(RemoveSection), Track, Section); }
        public Object GetTrackRowDisplayName(MovieSceneTrack Track, int RowIndex) { return Invoke<Object>(nameof(GetTrackRowDisplayName), Track, RowIndex); }
        public int GetSortingOrder(MovieSceneTrack Track) { return Invoke<int>(nameof(GetSortingOrder), Track); }
        public MovieSceneSection GetSectionToKey(MovieSceneTrack Track) { return Invoke<MovieSceneSection>(nameof(GetSectionToKey), Track); }
        public Array<MovieSceneSection> GetSections(MovieSceneTrack Track) { return Invoke<Array<MovieSceneSection>>(nameof(GetSections), Track); }
        public Object GetDisplayName(MovieSceneTrack Track) { return Invoke<Object>(nameof(GetDisplayName), Track); }
        public Color GetColorTint(MovieSceneTrack Track) { return Invoke<Color>(nameof(GetColorTint), Track); }
        public MovieSceneSection AddSection(MovieSceneTrack Track) { return Invoke<MovieSceneSection>(nameof(AddSection), Track); }
    }
    public class MovieSceneFloatVectorTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneFloatVectorTrackExtensions(nint addr) : base(addr) { }
        public void SetNumChannelsUsed(MovieSceneFloatVectorTrack Track, int InNumChannelsUsed) { Invoke(nameof(SetNumChannelsUsed), Track, InNumChannelsUsed); }
        public int GetNumChannelsUsed(MovieSceneFloatVectorTrack Track) { return Invoke<int>(nameof(GetNumChannelsUsed), Track); }
    }
    public class MovieSceneDoubleVectorTrackExtensions : BlueprintFunctionLibrary
    {
        public MovieSceneDoubleVectorTrackExtensions(nint addr) : base(addr) { }
        public void SetNumChannelsUsed(MovieSceneDoubleVectorTrack Track, int InNumChannelsUsed) { Invoke(nameof(SetNumChannelsUsed), Track, InNumChannelsUsed); }
        public int GetNumChannelsUsed(MovieSceneDoubleVectorTrack Track) { return Invoke<int>(nameof(GetNumChannelsUsed), Track); }
    }
    public class SequencerScriptingRangeExtensions : BlueprintFunctionLibrary
    {
        public SequencerScriptingRangeExtensions(nint addr) : base(addr) { }
        public void SetStartSeconds(SequencerScriptingRange Range, float Start) { Invoke(nameof(SetStartSeconds), Range, Start); }
        public void SetStartFrame(SequencerScriptingRange Range, int Start) { Invoke(nameof(SetStartFrame), Range, Start); }
        public void SetEndSeconds(SequencerScriptingRange Range, float End) { Invoke(nameof(SetEndSeconds), Range, End); }
        public void SetEndFrame(SequencerScriptingRange Range, int End) { Invoke(nameof(SetEndFrame), Range, End); }
        public void RemoveStart(SequencerScriptingRange Range) { Invoke(nameof(RemoveStart), Range); }
        public void RemoveEnd(SequencerScriptingRange Range) { Invoke(nameof(RemoveEnd), Range); }
        public bool HasStart(SequencerScriptingRange Range) { return Invoke<bool>(nameof(HasStart), Range); }
        public bool HasEnd(SequencerScriptingRange Range) { return Invoke<bool>(nameof(HasEnd), Range); }
        public float GetStartSeconds(SequencerScriptingRange Range) { return Invoke<float>(nameof(GetStartSeconds), Range); }
        public int GetStartFrame(SequencerScriptingRange Range) { return Invoke<int>(nameof(GetStartFrame), Range); }
        public float GetEndSeconds(SequencerScriptingRange Range) { return Invoke<float>(nameof(GetEndSeconds), Range); }
        public int GetEndFrame(SequencerScriptingRange Range) { return Invoke<int>(nameof(GetEndFrame), Range); }
    }
    public enum ESequenceTimeUnit : int
    {
        DisplayRate = 0,
        TickResolution = 1,
        ESequenceTimeUnit_MAX = 2,
    }
    public class SequencerScriptingRange : Object
    {
        public SequencerScriptingRange(nint addr) : base(addr) { }
        public bool bHasStart { get { return this[nameof(bHasStart)].Flag; } set { this[nameof(bHasStart)].Flag = value; } }
        public bool bHasEnd { get { return this[nameof(bHasEnd)].Flag; } set { this[nameof(bHasEnd)].Flag = value; } }
        public int InclusiveStart { get { return this[nameof(InclusiveStart)].GetValue<int>(); } set { this[nameof(InclusiveStart)].SetValue<int>(value); } }
        public int ExclusiveEnd { get { return this[nameof(ExclusiveEnd)].GetValue<int>(); } set { this[nameof(ExclusiveEnd)].SetValue<int>(value); } }
        public FrameRate InternalRate { get { return this[nameof(InternalRate)].As<FrameRate>(); } set { this["InternalRate"] = value; } }
    }
}
