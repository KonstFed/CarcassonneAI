namespace GameCore;

public class Tile
{
    public List<TileFeature> features = new();

    public Tile()
    {
        
    }

    public void addRoad(bool left, bool up, bool right, bool down)
    {
        features.Add(new RoadFeature(left, up, right, down, this));
    }
    
    public void addTown(bool left, bool up, bool right, bool down, bool shield = false)
    {
        features.Add(new TownFeature(left, up, right, down, this, shield));
    }

    public void addField(bool left, bool up, bool right, bool down, List<FieldHalfBorder> halfBorders = null)
    {
        features.Add(new FieldFeature(left, up, right, down, this, halfBorders));
    }

    public static List<Tile> getStartingTiles()
    {
        List<Tile> tiles = new();

        Tile tile = new();
        tile.addTown(true, true, true, true, true);
        tiles.Add(tile);

        for (int i = 0; i < 5; i++)
        {
            tile = new();
            tile.addTown(true, false, false, false);
            tile.addField(false, true, true, true);
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addTown(false, true, true, true);
            tile.addField(true, false, false, false);
            tiles.Add(tile);
        }
        
        tile = new();
        tile.addTown(false, true, true, true, true);
        tile.addField(true, false, false, false);
        tiles.Add(tile);
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addTown(true, true, false, false);
            tile.addField(false, false, true, true);
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 2; i++)
        {
            tile = new();
            tile.addTown(true, true, false, false, true);
            tile.addField(false, false, true, true);
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addTown(true, false, false, false);
            tile.addTown(false, false, true, false);
            tile.addField(false, true, false, true);
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 2; i++)
        {
            tile = new();
            tile.addTown(true, false, false, false);
            tile.addTown(false, true, false, false);
            tile.addField(false, false, true, true);
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 2; i++)
        {
            tile = new();
            tile.addTown(true, false, true, false, true);
            tile.addField(false, true, false, false);
            tile.addField(false, false, false, true);
            tiles.Add(tile);
        }
        
        tile = new();
        tile.addTown(true, false, true, false);
        tile.addField(false, true, false, false);
        tile.addField(false, false, false, true);
        tiles.Add(tile);

        for (int i = 0; i < 8; i++)
        {
            tile = new();
            tile.addRoad(true, false, true, false);
            tile.addField(false, true, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_up, FieldHalfBorder.right_up});
            tile.addField(false, false, false, true, new List<FieldHalfBorder> { FieldHalfBorder.left_down, FieldHalfBorder.right_down});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 9; i++)
        {
            tile = new();
            tile.addRoad(true, true, false, false);
            tile.addField(false, false, true, true, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.left_down});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tiles.Add(tile);
        }

        for (int i = 0; i < 4; i++)
        {
            tile = new();
            tile.addRoad(true, false, false, false);
            tile.addRoad(false, true, false, false);
            tile.addRoad(false, false, true, false);
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.right_up});
            tile.addField(false, false, false, true, new List<FieldHalfBorder> { FieldHalfBorder.left_down, FieldHalfBorder.right_down});
            tiles.Add(tile);
        }
        
        tile = new();
        tile.addRoad(true, false, false, false);
        tile.addRoad(false, true, false, false);
        tile.addRoad(false, false, true, false);
        tile.addRoad(false, false, false, true);
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.right_up});
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.right_down, FieldHalfBorder.down_right});
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.down_left, FieldHalfBorder.left_down});
        tiles.Add(tile);
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addRoad(true, true, false, false);
            tile.addTown(false, false, true, true);
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.left_down});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 2; i++)
        {
            tile = new();
            tile.addRoad(true, true, false, false);
            tile.addTown(false, false, true, true, true);
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.left_down});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 2; i++)
        {
            tile = new();
            tile.addRoad(true, false, false, false);
            tile.addTown(false, true, true, true, true);
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_down});
            tiles.Add(tile);
        }
        
        tile = new();
        tile.addRoad(true, false, false, false);
        tile.addTown(false, true, true, true);
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_up});
        tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_down});
        tiles.Add(tile);
        
        for (int i = 0; i < 4; i++)
        {
            tile = new();
            tile.addRoad(true, false, true, false);
            tile.addTown(false, false, false, true);
            tile.addField(false, true, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_up, FieldHalfBorder.right_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_down, FieldHalfBorder.right_down});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addRoad(false, true, true, false);
            tile.addTown(false, false, false, true);
            tile.addField(true, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.right_down});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.right_up});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addRoad(true, true, false, false);
            tile.addTown(false, false, false, true);
            tile.addField(false, false, true, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.left_down});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tiles.Add(tile);
        }
        
        for (int i = 0; i < 3; i++)
        {
            tile = new();
            tile.addRoad(true, false, false, false);
            tile.addRoad(false, true, false, false);
            tile.addRoad(false, false, true, false);
            tile.addTown(false, false, false, true);
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_left, FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.up_right, FieldHalfBorder.left_up});
            tile.addField(false, false, false, false, new List<FieldHalfBorder> { FieldHalfBorder.left_down, FieldHalfBorder.right_down});
            tiles.Add(tile);
        }

        return tiles;
    }
}