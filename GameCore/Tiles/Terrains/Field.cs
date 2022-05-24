namespace GameCore;

public class Field : Terrain
{
    public List<Town> towns = new ();

    public Field()
    {
            
    }

    public override void connectTo(Terrain terrain)
    {
        throw new NotImplementedException();
    }
}