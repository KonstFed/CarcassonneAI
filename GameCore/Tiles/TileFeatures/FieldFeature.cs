using System.Diagnostics;

namespace GameCore;

public class FieldFeature : TileFeature
{
    public List<FieldHalfBorder> halfBorders;

    public FieldFeature(bool left, bool up, bool right, bool down, Tile tile, List<FieldHalfBorder> halfBorders = null) : base(left, up, right, down, tile, TerrainType.Field)
    {
        if (halfBorders == null)
            halfBorders = new List<FieldHalfBorder>();
        this.halfBorders = halfBorders;
        
        terrain = new Field();
        terrain.tiles.Add(tile);
    }

    public override bool canConnectTo(TileFeature feature, Side side)
    {
        throw new NotImplementedException();
    }

    public override void connectTo(TileFeature feature, Side side)
    {
        throw new NotImplementedException();
    }
}