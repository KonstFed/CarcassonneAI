namespace GameCore
{
    public class Tile
    {
        public Terrain[] borders;
        public Tile()
        {
            borders = new Terrain[4];
        }
    }
}