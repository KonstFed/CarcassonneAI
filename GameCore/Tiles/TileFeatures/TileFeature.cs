namespace GameCore;

public abstract class TileFeature
{
    public Tile tile;
    public TerrainType type;
    public Terrain terrain;
    public List<Side> borders = new();

    protected TileFeature(bool left, bool up, bool right, bool down, Tile tile, TerrainType type)
    {
        this.tile = tile;
        this.type = type;
        if (left)
            borders.Add(Side.Left);
        if (up)
            borders.Add(Side.Up);
        if (right)
            borders.Add(Side.Right);
        if (down)
            borders.Add(Side.Down);
    }

    public abstract bool canConnectTo(TileFeature feature, Side side);
    public abstract void connectTo(TileFeature feature, Side side);

}