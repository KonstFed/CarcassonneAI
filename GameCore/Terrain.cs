namespace GameCore
{
    public enum TerrainType
    {
        Town,
        Road,
        Field
    }

    public abstract class Terrain
    {
        public TerrainType type;
        public List<Tile> tiles = new ();
        public Dictionary<int,int> workers = new ();
        
    }
}