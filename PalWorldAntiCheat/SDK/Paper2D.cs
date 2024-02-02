using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.Paper2DSDK
{
    public class PaperCharacter : Character
    {
        public PaperCharacter(nint addr) : base(addr) { }
        public PaperFlipbookComponent Sprite { get { return this[nameof(Sprite)].As<PaperFlipbookComponent>(); } set { this["Sprite"] = value; } }
    }
    public class PaperFlipbook : Object
    {
        public PaperFlipbook(nint addr) : base(addr) { }
        public float FramesPerSecond { get { return this[nameof(FramesPerSecond)].GetValue<float>(); } set { this[nameof(FramesPerSecond)].SetValue<float>(value); } }
        public Array<PaperFlipbookKeyFrame> KeyFrames { get { return new Array<PaperFlipbookKeyFrame>(this[nameof(KeyFrames)].Address); } }
        public MaterialInterface DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInterface>(); } set { this["DefaultMaterial"] = value; } }
        public byte CollisionSource { get { return this[nameof(CollisionSource)].GetValue<byte>(); } set { this[nameof(CollisionSource)].SetValue<byte>(value); } }
        public bool IsValidKeyFrameIndex(int Index) { return Invoke<bool>(nameof(IsValidKeyFrameIndex), Index); }
        public float GetTotalDuration() { return Invoke<float>(nameof(GetTotalDuration)); }
        public PaperSprite GetSpriteAtTime(float Time, bool bClampToEnds) { return Invoke<PaperSprite>(nameof(GetSpriteAtTime), Time, bClampToEnds); }
        public PaperSprite GetSpriteAtFrame(int FrameIndex) { return Invoke<PaperSprite>(nameof(GetSpriteAtFrame), FrameIndex); }
        public int GetNumKeyFrames() { return Invoke<int>(nameof(GetNumKeyFrames)); }
        public int GetNumFrames() { return Invoke<int>(nameof(GetNumFrames)); }
        public int GetKeyFrameIndexAtTime(float Time, bool bClampToEnds) { return Invoke<int>(nameof(GetKeyFrameIndexAtTime), Time, bClampToEnds); }
    }
    public class PaperFlipbookActor : Actor
    {
        public PaperFlipbookActor(nint addr) : base(addr) { }
        public PaperFlipbookComponent RenderComponent { get { return this[nameof(RenderComponent)].As<PaperFlipbookComponent>(); } set { this["RenderComponent"] = value; } }
    }
    public class PaperFlipbookComponent : MeshComponent
    {
        public PaperFlipbookComponent(nint addr) : base(addr) { }
        public PaperFlipbook SourceFlipbook { get { return this[nameof(SourceFlipbook)].As<PaperFlipbook>(); } set { this["SourceFlipbook"] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public bool bReversePlayback { get { return this[nameof(bReversePlayback)].Flag; } set { this[nameof(bReversePlayback)].Flag = value; } }
        public bool bPlaying { get { return this[nameof(bPlaying)].Flag; } set { this[nameof(bPlaying)].Flag = value; } }
        public float AccumulatedTime { get { return this[nameof(AccumulatedTime)].GetValue<float>(); } set { this[nameof(AccumulatedTime)].SetValue<float>(value); } }
        public int CachedFrameIndex { get { return this[nameof(CachedFrameIndex)].GetValue<int>(); } set { this[nameof(CachedFrameIndex)].SetValue<int>(value); } }
        public LinearColor SpriteColor { get { return this[nameof(SpriteColor)].As<LinearColor>(); } set { this["SpriteColor"] = value; } }
        public BodySetup CachedBodySetup { get { return this[nameof(CachedBodySetup)].As<BodySetup>(); } set { this["CachedBodySetup"] = value; } }
        public Object OnFinishedPlaying { get { return this[nameof(OnFinishedPlaying)]; } set { this[nameof(OnFinishedPlaying)] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetSpriteColor(LinearColor NewColor) { Invoke(nameof(SetSpriteColor), NewColor); }
        public void SetPlayRate(float NewRate) { Invoke(nameof(SetPlayRate), NewRate); }
        public void SetPlaybackPositionInFrames(int NewFramePosition, bool bFireEvents) { Invoke(nameof(SetPlaybackPositionInFrames), NewFramePosition, bFireEvents); }
        public void SetPlaybackPosition(float NewPosition, bool bFireEvents) { Invoke(nameof(SetPlaybackPosition), NewPosition, bFireEvents); }
        public void SetNewTime(float NewTime) { Invoke(nameof(SetNewTime), NewTime); }
        public void SetLooping(bool bNewLooping) { Invoke(nameof(SetLooping), bNewLooping); }
        public bool SetFlipbook(PaperFlipbook NewFlipbook) { return Invoke<bool>(nameof(SetFlipbook), NewFlipbook); }
        public void ReverseFromEnd() { Invoke(nameof(ReverseFromEnd)); }
        public void Reverse() { Invoke(nameof(Reverse)); }
        public void PlayFromStart() { Invoke(nameof(PlayFromStart)); }
        public void Play() { Invoke(nameof(Play)); }
        public void OnRep_SourceFlipbook(PaperFlipbook OldFlipbook) { Invoke(nameof(OnRep_SourceFlipbook), OldFlipbook); }
        public bool IsReversing() { return Invoke<bool>(nameof(IsReversing)); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
        public bool IsLooping() { return Invoke<bool>(nameof(IsLooping)); }
        public LinearColor GetSpriteColor() { return Invoke<LinearColor>(nameof(GetSpriteColor)); }
        public float GetPlayRate() { return Invoke<float>(nameof(GetPlayRate)); }
        public int GetPlaybackPositionInFrames() { return Invoke<int>(nameof(GetPlaybackPositionInFrames)); }
        public float GetPlaybackPosition() { return Invoke<float>(nameof(GetPlaybackPosition)); }
        public int GetFlipbookLengthInFrames() { return Invoke<int>(nameof(GetFlipbookLengthInFrames)); }
        public float GetFlipbookLength() { return Invoke<float>(nameof(GetFlipbookLength)); }
        public float GetFlipbookFramerate() { return Invoke<float>(nameof(GetFlipbookFramerate)); }
        public PaperFlipbook GetFlipbook() { return Invoke<PaperFlipbook>(nameof(GetFlipbook)); }
    }
    public class PaperGroupedSpriteActor : Actor
    {
        public PaperGroupedSpriteActor(nint addr) : base(addr) { }
        public PaperGroupedSpriteComponent RenderComponent { get { return this[nameof(RenderComponent)].As<PaperGroupedSpriteComponent>(); } set { this["RenderComponent"] = value; } }
    }
    public class PaperGroupedSpriteComponent : MeshComponent
    {
        public PaperGroupedSpriteComponent(nint addr) : base(addr) { }
        public Array<MaterialInterface> InstanceMaterials { get { return new Array<MaterialInterface>(this[nameof(InstanceMaterials)].Address); } }
        public Array<SpriteInstanceData> PerInstanceSpriteData { get { return new Array<SpriteInstanceData>(this[nameof(PerInstanceSpriteData)].Address); } }
        public bool UpdateInstanceTransform(int InstanceIndex, Transform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport) { return Invoke<bool>(nameof(UpdateInstanceTransform), InstanceIndex, NewInstanceTransform, bWorldSpace, bMarkRenderStateDirty, bTeleport); }
        public bool UpdateInstanceColor(int InstanceIndex, LinearColor NewInstanceColor, bool bMarkRenderStateDirty) { return Invoke<bool>(nameof(UpdateInstanceColor), InstanceIndex, NewInstanceColor, bMarkRenderStateDirty); }
        public void SortInstancesAlongAxis(Vector WorldSpaceSortAxis) { Invoke(nameof(SortInstancesAlongAxis), WorldSpaceSortAxis); }
        public bool RemoveInstance(int InstanceIndex) { return Invoke<bool>(nameof(RemoveInstance), InstanceIndex); }
        public bool GetInstanceTransform(int InstanceIndex, Transform OutInstanceTransform, bool bWorldSpace) { return Invoke<bool>(nameof(GetInstanceTransform), InstanceIndex, OutInstanceTransform, bWorldSpace); }
        public int GetInstanceCount() { return Invoke<int>(nameof(GetInstanceCount)); }
        public void ClearInstances() { Invoke(nameof(ClearInstances)); }
        public int AddInstance(Transform Transform, PaperSprite Sprite, bool bWorldSpace, LinearColor Color) { return Invoke<int>(nameof(AddInstance), Transform, Sprite, bWorldSpace, Color); }
    }
    public class PaperRuntimeSettings : Object
    {
        public PaperRuntimeSettings(nint addr) : base(addr) { }
        public bool bEnableSpriteAtlasGroups { get { return this[nameof(bEnableSpriteAtlasGroups)].Flag; } set { this[nameof(bEnableSpriteAtlasGroups)].Flag = value; } }
        public bool bEnableTerrainSplineEditing { get { return this[nameof(bEnableTerrainSplineEditing)].Flag; } set { this[nameof(bEnableTerrainSplineEditing)].Flag = value; } }
        public bool bResizeSpriteDataToMatchTextures { get { return this[nameof(bResizeSpriteDataToMatchTextures)].Flag; } set { this[nameof(bResizeSpriteDataToMatchTextures)].Flag = value; } }
    }
    public class PaperSprite : Object
    {
        public PaperSprite(nint addr) : base(addr) { }
        public Array<Texture> AdditionalSourceTextures { get { return new Array<Texture>(this[nameof(AdditionalSourceTextures)].Address); } }
        public Vector2D BakedSourceUV { get { return this[nameof(BakedSourceUV)].As<Vector2D>(); } set { this["BakedSourceUV"] = value; } }
        public Vector2D BakedSourceDimension { get { return this[nameof(BakedSourceDimension)].As<Vector2D>(); } set { this["BakedSourceDimension"] = value; } }
        public Texture2D BakedSourceTexture { get { return this[nameof(BakedSourceTexture)].As<Texture2D>(); } set { this["BakedSourceTexture"] = value; } }
        public MaterialInterface DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInterface>(); } set { this["DefaultMaterial"] = value; } }
        public MaterialInterface AlternateMaterial { get { return this[nameof(AlternateMaterial)].As<MaterialInterface>(); } set { this["AlternateMaterial"] = value; } }
        public Array<PaperSpriteSocket> Sockets { get { return new Array<PaperSpriteSocket>(this[nameof(Sockets)].Address); } }
        public byte SpriteCollisionDomain { get { return this[nameof(SpriteCollisionDomain)].GetValue<byte>(); } set { this[nameof(SpriteCollisionDomain)].SetValue<byte>(value); } }
        public float PixelsPerUnrealUnit { get { return this[nameof(PixelsPerUnrealUnit)].GetValue<float>(); } set { this[nameof(PixelsPerUnrealUnit)].SetValue<float>(value); } }
        public BodySetup BodySetup { get { return this[nameof(BodySetup)].As<BodySetup>(); } set { this["BodySetup"] = value; } }
        public int AlternateMaterialSplitIndex { get { return this[nameof(AlternateMaterialSplitIndex)].GetValue<int>(); } set { this[nameof(AlternateMaterialSplitIndex)].SetValue<int>(value); } }
        public Array<Vector4> BakedRenderData { get { return new Array<Vector4>(this[nameof(BakedRenderData)].Address); } }
    }
    public class PaperSpriteActor : Actor
    {
        public PaperSpriteActor(nint addr) : base(addr) { }
        public PaperSpriteComponent RenderComponent { get { return this[nameof(RenderComponent)].As<PaperSpriteComponent>(); } set { this["RenderComponent"] = value; } }
    }
    public class PaperSpriteAtlas : Object
    {
        public PaperSpriteAtlas(nint addr) : base(addr) { }
    }
    public class PaperSpriteBlueprintLibrary : BlueprintFunctionLibrary
    {
        public PaperSpriteBlueprintLibrary(nint addr) : base(addr) { }
        public SlateBrush MakeBrushFromSprite(PaperSprite Sprite, int Width, int Height) { return Invoke<SlateBrush>(nameof(MakeBrushFromSprite), Sprite, Width, Height); }
    }
    public class PaperSpriteComponent : MeshComponent
    {
        public PaperSpriteComponent(nint addr) : base(addr) { }
        public PaperSprite SourceSprite { get { return this[nameof(SourceSprite)].As<PaperSprite>(); } set { this["SourceSprite"] = value; } }
        public MaterialInterface MaterialOverride { get { return this[nameof(MaterialOverride)].As<MaterialInterface>(); } set { this["MaterialOverride"] = value; } }
        public LinearColor SpriteColor { get { return this[nameof(SpriteColor)].As<LinearColor>(); } set { this["SpriteColor"] = value; } }
        public void SetSpriteColor(LinearColor NewColor) { Invoke(nameof(SetSpriteColor), NewColor); }
        public bool SetSprite(PaperSprite NewSprite) { return Invoke<bool>(nameof(SetSprite), NewSprite); }
        public PaperSprite GetSprite() { return Invoke<PaperSprite>(nameof(GetSprite)); }
    }
    public class PaperTileLayer : Object
    {
        public PaperTileLayer(nint addr) : base(addr) { }
        public Object LayerName { get { return this[nameof(LayerName)]; } set { this[nameof(LayerName)] = value; } }
        public int LayerWidth { get { return this[nameof(LayerWidth)].GetValue<int>(); } set { this[nameof(LayerWidth)].SetValue<int>(value); } }
        public int LayerHeight { get { return this[nameof(LayerHeight)].GetValue<int>(); } set { this[nameof(LayerHeight)].SetValue<int>(value); } }
        public bool bHiddenInGame { get { return this[nameof(bHiddenInGame)].Flag; } set { this[nameof(bHiddenInGame)].Flag = value; } }
        public bool bLayerCollides { get { return this[nameof(bLayerCollides)].Flag; } set { this[nameof(bLayerCollides)].Flag = value; } }
        public bool bOverrideCollisionThickness { get { return this[nameof(bOverrideCollisionThickness)].Flag; } set { this[nameof(bOverrideCollisionThickness)].Flag = value; } }
        public bool bOverrideCollisionOffset { get { return this[nameof(bOverrideCollisionOffset)].Flag; } set { this[nameof(bOverrideCollisionOffset)].Flag = value; } }
        public float CollisionThicknessOverride { get { return this[nameof(CollisionThicknessOverride)].GetValue<float>(); } set { this[nameof(CollisionThicknessOverride)].SetValue<float>(value); } }
        public float CollisionOffsetOverride { get { return this[nameof(CollisionOffsetOverride)].GetValue<float>(); } set { this[nameof(CollisionOffsetOverride)].SetValue<float>(value); } }
        public LinearColor LayerColor { get { return this[nameof(LayerColor)].As<LinearColor>(); } set { this["LayerColor"] = value; } }
        public int AllocatedWidth { get { return this[nameof(AllocatedWidth)].GetValue<int>(); } set { this[nameof(AllocatedWidth)].SetValue<int>(value); } }
        public int AllocatedHeight { get { return this[nameof(AllocatedHeight)].GetValue<int>(); } set { this[nameof(AllocatedHeight)].SetValue<int>(value); } }
        public Array<PaperTileInfo> AllocatedCells { get { return new Array<PaperTileInfo>(this[nameof(AllocatedCells)].Address); } }
        public PaperTileSet TileSet { get { return this[nameof(TileSet)].As<PaperTileSet>(); } set { this["TileSet"] = value; } }
        public Array<int> AllocatedGrid { get { return new Array<int>(this[nameof(AllocatedGrid)].Address); } }
    }
    public class PaperTileMap : Object
    {
        public PaperTileMap(nint addr) : base(addr) { }
        public int MapWidth { get { return this[nameof(MapWidth)].GetValue<int>(); } set { this[nameof(MapWidth)].SetValue<int>(value); } }
        public int MapHeight { get { return this[nameof(MapHeight)].GetValue<int>(); } set { this[nameof(MapHeight)].SetValue<int>(value); } }
        public int TileWidth { get { return this[nameof(TileWidth)].GetValue<int>(); } set { this[nameof(TileWidth)].SetValue<int>(value); } }
        public int TileHeight { get { return this[nameof(TileHeight)].GetValue<int>(); } set { this[nameof(TileHeight)].SetValue<int>(value); } }
        public float PixelsPerUnrealUnit { get { return this[nameof(PixelsPerUnrealUnit)].GetValue<float>(); } set { this[nameof(PixelsPerUnrealUnit)].SetValue<float>(value); } }
        public float SeparationPerTileX { get { return this[nameof(SeparationPerTileX)].GetValue<float>(); } set { this[nameof(SeparationPerTileX)].SetValue<float>(value); } }
        public float SeparationPerTileY { get { return this[nameof(SeparationPerTileY)].GetValue<float>(); } set { this[nameof(SeparationPerTileY)].SetValue<float>(value); } }
        public float SeparationPerLayer { get { return this[nameof(SeparationPerLayer)].GetValue<float>(); } set { this[nameof(SeparationPerLayer)].SetValue<float>(value); } }
        public Object SelectedTileSet { get { return this[nameof(SelectedTileSet)]; } set { this[nameof(SelectedTileSet)] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public Array<PaperTileLayer> TileLayers { get { return new Array<PaperTileLayer>(this[nameof(TileLayers)].Address); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public byte SpriteCollisionDomain { get { return this[nameof(SpriteCollisionDomain)].GetValue<byte>(); } set { this[nameof(SpriteCollisionDomain)].SetValue<byte>(value); } }
        public byte ProjectionMode { get { return this[nameof(ProjectionMode)].GetValue<byte>(); } set { this[nameof(ProjectionMode)].SetValue<byte>(value); } }
        public int HexSideLength { get { return this[nameof(HexSideLength)].GetValue<int>(); } set { this[nameof(HexSideLength)].SetValue<int>(value); } }
        public BodySetup BodySetup { get { return this[nameof(BodySetup)].As<BodySetup>(); } set { this["BodySetup"] = value; } }
        public int LayerNameIndex { get { return this[nameof(LayerNameIndex)].GetValue<int>(); } set { this[nameof(LayerNameIndex)].SetValue<int>(value); } }
    }
    public class PaperTileMapActor : Actor
    {
        public PaperTileMapActor(nint addr) : base(addr) { }
        public PaperTileMapComponent RenderComponent { get { return this[nameof(RenderComponent)].As<PaperTileMapComponent>(); } set { this["RenderComponent"] = value; } }
    }
    public class PaperTileMapComponent : MeshComponent
    {
        public PaperTileMapComponent(nint addr) : base(addr) { }
        public int MapWidth { get { return this[nameof(MapWidth)].GetValue<int>(); } set { this[nameof(MapWidth)].SetValue<int>(value); } }
        public int MapHeight { get { return this[nameof(MapHeight)].GetValue<int>(); } set { this[nameof(MapHeight)].SetValue<int>(value); } }
        public int TileWidth { get { return this[nameof(TileWidth)].GetValue<int>(); } set { this[nameof(TileWidth)].SetValue<int>(value); } }
        public int TileHeight { get { return this[nameof(TileHeight)].GetValue<int>(); } set { this[nameof(TileHeight)].SetValue<int>(value); } }
        public PaperTileSet DefaultLayerTileSet { get { return this[nameof(DefaultLayerTileSet)].As<PaperTileSet>(); } set { this["DefaultLayerTileSet"] = value; } }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public Array<PaperTileLayer> TileLayers { get { return new Array<PaperTileLayer>(this[nameof(TileLayers)].Address); } }
        public LinearColor TileMapColor { get { return this[nameof(TileMapColor)].As<LinearColor>(); } set { this["TileMapColor"] = value; } }
        public int UseSingleLayerIndex { get { return this[nameof(UseSingleLayerIndex)].GetValue<int>(); } set { this[nameof(UseSingleLayerIndex)].SetValue<int>(value); } }
        public bool bUseSingleLayer { get { return this[nameof(bUseSingleLayer)].Flag; } set { this[nameof(bUseSingleLayer)].Flag = value; } }
        public PaperTileMap TileMap { get { return this[nameof(TileMap)].As<PaperTileMap>(); } set { this["TileMap"] = value; } }
        public void SetTileMapColor(LinearColor NewColor) { Invoke(nameof(SetTileMapColor), NewColor); }
        public bool SetTileMap(PaperTileMap NewTileMap) { return Invoke<bool>(nameof(SetTileMap), NewTileMap); }
        public void SetTile(int X, int Y, int Layer, PaperTileInfo NewValue) { Invoke(nameof(SetTile), X, Y, Layer, NewValue); }
        public void SetLayerColor(LinearColor NewColor, int Layer) { Invoke(nameof(SetLayerColor), NewColor, Layer); }
        public void SetLayerCollision(int Layer, bool bHasCollision, bool bOverrideThickness, float CustomThickness, bool bOverrideOffset, float CustomOffset, bool bRebuildCollision) { Invoke(nameof(SetLayerCollision), Layer, bHasCollision, bOverrideThickness, CustomThickness, bOverrideOffset, CustomOffset, bRebuildCollision); }
        public void SetDefaultCollisionThickness(float Thickness, bool bRebuildCollision) { Invoke(nameof(SetDefaultCollisionThickness), Thickness, bRebuildCollision); }
        public void ResizeMap(int NewWidthInTiles, int NewHeightInTiles) { Invoke(nameof(ResizeMap), NewWidthInTiles, NewHeightInTiles); }
        public void RebuildCollision() { Invoke(nameof(RebuildCollision)); }
        public bool OwnsTileMap() { return Invoke<bool>(nameof(OwnsTileMap)); }
        public void MakeTileMapEditable() { Invoke(nameof(MakeTileMapEditable)); }
        public void GetTilePolygon(int TileX, int TileY, Array<Vector> Points, int LayerIndex, bool bWorldSpace) { Invoke(nameof(GetTilePolygon), TileX, TileY, Points, LayerIndex, bWorldSpace); }
        public LinearColor GetTileMapColor() { return Invoke<LinearColor>(nameof(GetTileMapColor)); }
        public Vector GetTileCornerPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace) { return Invoke<Vector>(nameof(GetTileCornerPosition), TileX, TileY, LayerIndex, bWorldSpace); }
        public Vector GetTileCenterPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace) { return Invoke<Vector>(nameof(GetTileCenterPosition), TileX, TileY, LayerIndex, bWorldSpace); }
        public PaperTileInfo GetTile(int X, int Y, int Layer) { return Invoke<PaperTileInfo>(nameof(GetTile), X, Y, Layer); }
        public void GetMapSize(int MapWidth, int MapHeight, int NumLayers) { Invoke(nameof(GetMapSize), MapWidth, MapHeight, NumLayers); }
        public LinearColor GetLayerColor(int Layer) { return Invoke<LinearColor>(nameof(GetLayerColor), Layer); }
        public void CreateNewTileMap(int MapWidth, int MapHeight, int TileWidth, int TileHeight, float PixelsPerUnrealUnit, bool bCreateLayer) { Invoke(nameof(CreateNewTileMap), MapWidth, MapHeight, TileWidth, TileHeight, PixelsPerUnrealUnit, bCreateLayer); }
        public PaperTileLayer AddNewLayer() { return Invoke<PaperTileLayer>(nameof(AddNewLayer)); }
    }
    public class PaperTileSet : Object
    {
        public PaperTileSet(nint addr) : base(addr) { }
        public IntPoint TileSize { get { return this[nameof(TileSize)].As<IntPoint>(); } set { this["TileSize"] = value; } }
        public Texture2D TileSheet { get { return this[nameof(TileSheet)].As<Texture2D>(); } set { this["TileSheet"] = value; } }
        public Array<Texture> AdditionalSourceTextures { get { return new Array<Texture>(this[nameof(AdditionalSourceTextures)].Address); } }
        public IntMargin BorderMargin { get { return this[nameof(BorderMargin)].As<IntMargin>(); } set { this["BorderMargin"] = value; } }
        public IntPoint PerTileSpacing { get { return this[nameof(PerTileSpacing)].As<IntPoint>(); } set { this["PerTileSpacing"] = value; } }
        public IntPoint DrawingOffset { get { return this[nameof(DrawingOffset)].As<IntPoint>(); } set { this["DrawingOffset"] = value; } }
        public int WidthInTiles { get { return this[nameof(WidthInTiles)].GetValue<int>(); } set { this[nameof(WidthInTiles)].SetValue<int>(value); } }
        public int HeightInTiles { get { return this[nameof(HeightInTiles)].GetValue<int>(); } set { this[nameof(HeightInTiles)].SetValue<int>(value); } }
        public int AllocatedWidth { get { return this[nameof(AllocatedWidth)].GetValue<int>(); } set { this[nameof(AllocatedWidth)].SetValue<int>(value); } }
        public int AllocatedHeight { get { return this[nameof(AllocatedHeight)].GetValue<int>(); } set { this[nameof(AllocatedHeight)].SetValue<int>(value); } }
        public Array<PaperTileMetadata> PerTileData { get { return new Array<PaperTileMetadata>(this[nameof(PerTileData)].Address); } }
        public Array<PaperTileSetTerrain> Terrains { get { return new Array<PaperTileSetTerrain>(this[nameof(Terrains)].Address); } }
        public int TileWidth { get { return this[nameof(TileWidth)].GetValue<int>(); } set { this[nameof(TileWidth)].SetValue<int>(value); } }
        public int TileHeight { get { return this[nameof(TileHeight)].GetValue<int>(); } set { this[nameof(TileHeight)].SetValue<int>(value); } }
        public int Margin { get { return this[nameof(Margin)].GetValue<int>(); } set { this[nameof(Margin)].SetValue<int>(value); } }
        public int Spacing { get { return this[nameof(Spacing)].GetValue<int>(); } set { this[nameof(Spacing)].SetValue<int>(value); } }
    }
    public class MaterialExpressionSpriteTextureSampler : MaterialExpressionTextureSampleParameter2D
    {
        public MaterialExpressionSpriteTextureSampler(nint addr) : base(addr) { }
        public bool bSampleAdditionalTextures { get { return this[nameof(bSampleAdditionalTextures)].Flag; } set { this[nameof(bSampleAdditionalTextures)].Flag = value; } }
        public int AdditionalSlotIndex { get { return this[nameof(AdditionalSlotIndex)].GetValue<int>(); } set { this[nameof(AdditionalSlotIndex)].SetValue<int>(value); } }
        public Object SlotDisplayName { get { return this[nameof(SlotDisplayName)]; } set { this[nameof(SlotDisplayName)] = value; } }
    }
    public class PaperTerrainActor : Actor
    {
        public PaperTerrainActor(nint addr) : base(addr) { }
        public SceneComponent DummyRoot { get { return this[nameof(DummyRoot)].As<SceneComponent>(); } set { this["DummyRoot"] = value; } }
        public PaperTerrainSplineComponent SplineComponent { get { return this[nameof(SplineComponent)].As<PaperTerrainSplineComponent>(); } set { this["SplineComponent"] = value; } }
        public PaperTerrainComponent RenderComponent { get { return this[nameof(RenderComponent)].As<PaperTerrainComponent>(); } set { this["RenderComponent"] = value; } }
    }
    public class PaperTerrainComponent : PrimitiveComponent
    {
        public PaperTerrainComponent(nint addr) : base(addr) { }
        public PaperTerrainMaterial TerrainMaterial { get { return this[nameof(TerrainMaterial)].As<PaperTerrainMaterial>(); } set { this["TerrainMaterial"] = value; } }
        public bool bClosedSpline { get { return this[nameof(bClosedSpline)].Flag; } set { this[nameof(bClosedSpline)].Flag = value; } }
        public bool bFilledSpline { get { return this[nameof(bFilledSpline)].Flag; } set { this[nameof(bFilledSpline)].Flag = value; } }
        public PaperTerrainSplineComponent AssociatedSpline { get { return this[nameof(AssociatedSpline)].As<PaperTerrainSplineComponent>(); } set { this["AssociatedSpline"] = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public float SegmentOverlapAmount { get { return this[nameof(SegmentOverlapAmount)].GetValue<float>(); } set { this[nameof(SegmentOverlapAmount)].SetValue<float>(value); } }
        public LinearColor TerrainColor { get { return this[nameof(TerrainColor)].As<LinearColor>(); } set { this["TerrainColor"] = value; } }
        public int ReparamStepsPerSegment { get { return this[nameof(ReparamStepsPerSegment)].GetValue<int>(); } set { this[nameof(ReparamStepsPerSegment)].SetValue<int>(value); } }
        public byte SpriteCollisionDomain { get { return this[nameof(SpriteCollisionDomain)].GetValue<byte>(); } set { this[nameof(SpriteCollisionDomain)].SetValue<byte>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public BodySetup CachedBodySetup { get { return this[nameof(CachedBodySetup)].As<BodySetup>(); } set { this["CachedBodySetup"] = value; } }
        public void SetTerrainColor(LinearColor NewColor) { Invoke(nameof(SetTerrainColor), NewColor); }
    }
    public class PaperTerrainMaterial : DataAsset
    {
        public PaperTerrainMaterial(nint addr) : base(addr) { }
        public Array<PaperTerrainMaterialRule> Rules { get { return new Array<PaperTerrainMaterialRule>(this[nameof(Rules)].Address); } }
        public PaperSprite InteriorFill { get { return this[nameof(InteriorFill)].As<PaperSprite>(); } set { this["InteriorFill"] = value; } }
    }
    public class PaperTerrainSplineComponent : SplineComponent
    {
        public PaperTerrainSplineComponent(nint addr) : base(addr) { }
    }
    public class TileMapBlueprintLibrary : BlueprintFunctionLibrary
    {
        public TileMapBlueprintLibrary(nint addr) : base(addr) { }
        public PaperTileInfo MakeTile(int TileIndex, PaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD) { return Invoke<PaperTileInfo>(nameof(MakeTile), TileIndex, TileSet, bFlipH, bFlipV, bFlipD); }
        public Object GetTileUserData(PaperTileInfo Tile) { return Invoke<Object>(nameof(GetTileUserData), Tile); }
        public Transform GetTileTransform(PaperTileInfo Tile) { return Invoke<Transform>(nameof(GetTileTransform), Tile); }
        public void BreakTile(PaperTileInfo Tile, int TileIndex, PaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD) { Invoke(nameof(BreakTile), Tile, TileIndex, TileSet, bFlipH, bFlipV, bFlipD); }
    }
    public enum ESpriteCollisionMode : int
    {
        None = 0,
        Use2DPhysics = 1,
        Use3DPhysics = 2,
        ESpriteCollisionMode_MAX = 3,
    }
    public enum ESpriteShapeType : int
    {
        Box = 0,
        Circle = 1,
        Polygon = 2,
        ESpriteShapeType_MAX = 3,
    }
    public enum ESpritePolygonMode : int
    {
        SourceBoundingBox = 0,
        TightBoundingBox = 1,
        ShrinkWrapped = 2,
        FullyCustom = 3,
        Diced = 4,
        ESpritePolygonMode_MAX = 5,
    }
    public enum ESpritePivotMode : int
    {
        Top_Left = 0,
        Top_Center = 1,
        Top_Right = 2,
        Center_Left = 3,
        Center_Center = 4,
        Center_Right = 5,
        Bottom_Left = 6,
        Bottom_Center = 7,
        Bottom_Right = 8,
        Custom = 9,
        ESpritePivotMode_MAX = 10,
    }
    public enum EFlipbookCollisionMode : int
    {
        NoCollision = 0,
        FirstFrameCollision = 1,
        EachFrameCollision = 2,
        EFlipbookCollisionMode_MAX = 3,
    }
    public enum EPaperSpriteAtlasPadding : int
    {
        DilateBorder = 0,
        PadWithZero = 1,
        EPaperSpriteAtlasPadding_MAX = 2,
    }
    public enum ETileMapProjectionMode : int
    {
        Orthogonal = 0,
        IsometricDiamond = 1,
        IsometricStaggered = 2,
        HexagonalStaggered = 3,
        ETileMapProjectionMode_MAX = 4,
    }
    public class IntMargin : Object
    {
        public IntMargin(nint addr) : base(addr) { }
        public int Left { get { return this[nameof(Left)].GetValue<int>(); } set { this[nameof(Left)].SetValue<int>(value); } }
        public int Top { get { return this[nameof(Top)].GetValue<int>(); } set { this[nameof(Top)].SetValue<int>(value); } }
        public int Right { get { return this[nameof(Right)].GetValue<int>(); } set { this[nameof(Right)].SetValue<int>(value); } }
        public int Bottom { get { return this[nameof(Bottom)].GetValue<int>(); } set { this[nameof(Bottom)].SetValue<int>(value); } }
    }
    public class SpriteDrawCallRecord : Object
    {
        public SpriteDrawCallRecord(nint addr) : base(addr) { }
        public Vector Destination { get { return this[nameof(Destination)].As<Vector>(); } set { this["Destination"] = value; } }
        public Texture BaseTexture { get { return this[nameof(BaseTexture)].As<Texture>(); } set { this["BaseTexture"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
    }
    public class SpriteGeometryShape : Object
    {
        public SpriteGeometryShape(nint addr) : base(addr) { }
        public ESpriteShapeType ShapeType { get { return (ESpriteShapeType)this[nameof(ShapeType)].GetValue<int>(); } set { this[nameof(ShapeType)].SetValue<int>((int)value); } }
        public Array<Vector2D> Vertices { get { return new Array<Vector2D>(this[nameof(Vertices)].Address); } }
        public Vector2D BoxSize { get { return this[nameof(BoxSize)].As<Vector2D>(); } set { this["BoxSize"] = value; } }
        public Vector2D BoxPosition { get { return this[nameof(BoxPosition)].As<Vector2D>(); } set { this["BoxPosition"] = value; } }
        public float Rotation { get { return this[nameof(Rotation)].GetValue<float>(); } set { this[nameof(Rotation)].SetValue<float>(value); } }
        public bool bNegativeWinding { get { return this[nameof(bNegativeWinding)].Flag; } set { this[nameof(bNegativeWinding)].Flag = value; } }
    }
    public class SpriteGeometryCollection : Object
    {
        public SpriteGeometryCollection(nint addr) : base(addr) { }
        public Array<SpriteGeometryShape> Shapes { get { return new Array<SpriteGeometryShape>(this[nameof(Shapes)].Address); } }
        public byte GeometryType { get { return this[nameof(GeometryType)].GetValue<byte>(); } set { this[nameof(GeometryType)].SetValue<byte>(value); } }
        public int PixelsPerSubdivisionX { get { return this[nameof(PixelsPerSubdivisionX)].GetValue<int>(); } set { this[nameof(PixelsPerSubdivisionX)].SetValue<int>(value); } }
        public int PixelsPerSubdivisionY { get { return this[nameof(PixelsPerSubdivisionY)].GetValue<int>(); } set { this[nameof(PixelsPerSubdivisionY)].SetValue<int>(value); } }
        public bool bAvoidVertexMerging { get { return this[nameof(bAvoidVertexMerging)].Flag; } set { this[nameof(bAvoidVertexMerging)].Flag = value; } }
        public float AlphaThreshold { get { return this[nameof(AlphaThreshold)].GetValue<float>(); } set { this[nameof(AlphaThreshold)].SetValue<float>(value); } }
        public float DetailAmount { get { return this[nameof(DetailAmount)].GetValue<float>(); } set { this[nameof(DetailAmount)].SetValue<float>(value); } }
        public float SimplifyEpsilon { get { return this[nameof(SimplifyEpsilon)].GetValue<float>(); } set { this[nameof(SimplifyEpsilon)].SetValue<float>(value); } }
    }
    public class SpriteAssetInitParameters : Object
    {
        public SpriteAssetInitParameters(nint addr) : base(addr) { }
    }
    public class PaperFlipbookKeyFrame : Object
    {
        public PaperFlipbookKeyFrame(nint addr) : base(addr) { }
        public PaperSprite Sprite { get { return this[nameof(Sprite)].As<PaperSprite>(); } set { this["Sprite"] = value; } }
        public int FrameRun { get { return this[nameof(FrameRun)].GetValue<int>(); } set { this[nameof(FrameRun)].SetValue<int>(value); } }
    }
    public class SpriteInstanceData : Object
    {
        public SpriteInstanceData(nint addr) : base(addr) { }
        public Matrix Transform { get { return this[nameof(Transform)].As<Matrix>(); } set { this["Transform"] = value; } }
        public PaperSprite SourceSprite { get { return this[nameof(SourceSprite)].As<PaperSprite>(); } set { this["SourceSprite"] = value; } }
        public Color VertexColor { get { return this[nameof(VertexColor)].As<Color>(); } set { this["VertexColor"] = value; } }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
    }
    public class PaperSpriteSocket : Object
    {
        public PaperSpriteSocket(nint addr) : base(addr) { }
        public Transform LocalTransform { get { return this[nameof(LocalTransform)].As<Transform>(); } set { this["LocalTransform"] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class PaperSpriteAtlasSlot : Object
    {
        public PaperSpriteAtlasSlot(nint addr) : base(addr) { }
        public Object SpriteRef { get { return this[nameof(SpriteRef)]; } set { this[nameof(SpriteRef)] = value; } }
        public int AtlasIndex { get { return this[nameof(AtlasIndex)].GetValue<int>(); } set { this[nameof(AtlasIndex)].SetValue<int>(value); } }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
    }
    public class PaperTileInfo : Object
    {
        public PaperTileInfo(nint addr) : base(addr) { }
        public PaperTileSet TileSet { get { return this[nameof(TileSet)].As<PaperTileSet>(); } set { this["TileSet"] = value; } }
        public int PackedTileIndex { get { return this[nameof(PackedTileIndex)].GetValue<int>(); } set { this[nameof(PackedTileIndex)].SetValue<int>(value); } }
    }
    public class PaperTileMetadata : Object
    {
        public PaperTileMetadata(nint addr) : base(addr) { }
        public Object UserDataName { get { return this[nameof(UserDataName)]; } set { this[nameof(UserDataName)] = value; } }
        public SpriteGeometryCollection CollisionData { get { return this[nameof(CollisionData)].As<SpriteGeometryCollection>(); } set { this["CollisionData"] = value; } }
        public byte TerrainMembership { get { return this[nameof(TerrainMembership)].GetValue<byte>(); } set { this[nameof(TerrainMembership)].SetValue<byte>(value); } }
    }
    public class PaperTileSetTerrain : Object
    {
        public PaperTileSetTerrain(nint addr) : base(addr) { }
        public Object TerrainName { get { return this[nameof(TerrainName)]; } set { this[nameof(TerrainName)] = value; } }
        public int CenterTileIndex { get { return this[nameof(CenterTileIndex)].GetValue<int>(); } set { this[nameof(CenterTileIndex)].SetValue<int>(value); } }
    }
    public class PaperTerrainMaterialRule : Object
    {
        public PaperTerrainMaterialRule(nint addr) : base(addr) { }
        public PaperSprite StartCap { get { return this[nameof(StartCap)].As<PaperSprite>(); } set { this["StartCap"] = value; } }
        public Array<PaperSprite> Body { get { return new Array<PaperSprite>(this[nameof(Body)].Address); } }
        public PaperSprite EndCap { get { return this[nameof(EndCap)].As<PaperSprite>(); } set { this["EndCap"] = value; } }
        public float MinimumAngle { get { return this[nameof(MinimumAngle)].GetValue<float>(); } set { this[nameof(MinimumAngle)].SetValue<float>(value); } }
        public float MaximumAngle { get { return this[nameof(MaximumAngle)].GetValue<float>(); } set { this[nameof(MaximumAngle)].SetValue<float>(value); } }
        public bool bEnableCollision { get { return this[nameof(bEnableCollision)].Flag; } set { this[nameof(bEnableCollision)].Flag = value; } }
        public float CollisionOffset { get { return this[nameof(CollisionOffset)].GetValue<float>(); } set { this[nameof(CollisionOffset)].SetValue<float>(value); } }
        public int DrawOrder { get { return this[nameof(DrawOrder)].GetValue<int>(); } set { this[nameof(DrawOrder)].SetValue<int>(value); } }
    }
}
