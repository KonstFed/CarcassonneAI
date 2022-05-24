namespace GameCore;

public class Road: Terrain 
{
    public Tile start;
    public Tile end;
    public int openEnds;

    public Road()
    {
        
    }

    public override void connectTo(Terrain terrain)
    {
        throw new NotImplementedException();
    }
}