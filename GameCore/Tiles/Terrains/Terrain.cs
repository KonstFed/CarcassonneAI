namespace GameCore;

public abstract class Terrain
{
    public TerrainType type;
    public List<Tile> tiles = new ();
    public Dictionary<int,int> workers = new ();

    public abstract void connectTo(Terrain terrain);
}