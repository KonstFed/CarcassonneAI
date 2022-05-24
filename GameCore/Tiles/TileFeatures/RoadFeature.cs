namespace GameCore;

public class RoadFeature : TileFeature
{
    public RoadFeature(bool left, bool up, bool right, bool down, Tile initialTile) : base(left, up, right, down, initialTile, TerrainType.Road)
    {
        terrain = new Road();
        terrain.tiles.Add(tile);
    }

    public override bool canConnectTo(TileFeature feature, Side side)
    {
        if (!borders.Contains(side))
            return true;
        if (!feature.borders.Contains(side))
            return true;
        return feature.type == TerrainType.Road;
    }

    public override void connectTo(TileFeature feature, Side side)
    {
        if (!borders.Contains(side))
            return;
        if (!feature.borders.Contains(side))
            return;
        if (feature.type != TerrainType.Road)
            throw new ArgumentException("Cannot connect Road to " + feature.type);
        
        terrain.connectTo(feature.terrain);
        feature.terrain = terrain;   
        
    }
}