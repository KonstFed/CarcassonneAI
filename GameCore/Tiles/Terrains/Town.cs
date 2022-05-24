namespace GameCore;

public class Town: Terrain
{
    public int openBorders;
    public bool closed;
    public int shields;

    public Town(int openBorders, int shields = 0)
    {
        this.openBorders = openBorders;
        this.shields = shields;
        closed = openBorders == 0;
    }

    public override void connectTo(Terrain terrain)
    {
        throw new NotImplementedException();
    }
}