namespace GameCore;

public class TownFeature : TileFeature
{
    private bool shield;
    
    public TownFeature(bool left, bool up, bool right, bool down, Tile initialTile, bool shield = false) : base(left, up, right, down, initialTile, TerrainType.Town)
    {
        this.shield = shield;

        terrain = new Town(borders.Count, shield ? 1 : 0);
        terrain.tiles.Add(tile);
    }

    public override bool canConnectTo(TileFeature feature, Side side)
    {
        if (!borders.Contains(side))
            return true;
        if (!feature.borders.Contains(side))
            return true;
        return feature.type == TerrainType.Town;
    }

    public override void connectTo(TileFeature feature, Side side)
    {
        if (!borders.Contains(side))
            return;
        if (!feature.borders.Contains(side))
            return;
        if (feature.type != TerrainType.Town)
            throw new ArgumentException("Cannot connect Town to " + feature.type);

        terrain.connectTo(feature.terrain);
        feature.terrain = terrain;   
        
    }
}