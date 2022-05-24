namespace GameCore;

public class Core
{
    private List<Player> players = new ();
    private List<Tile> heapTiles = new ();
    private List<List<Tile>> map = new();
    private List<Terrain> terrains = new();
    private bool standardRules = true;
    private Random random;
    private Tile currentTile;
    
    public Core(bool standardRules = true)
    {
        this.standardRules = standardRules;
        random = new Random();
    }

    public void addTile(Tile tile = null)
    {
        if (tile == null)
            tile = currentTile;

        if (tile != currentTile && standardRules)
            throw new ArgumentException("You can send only current tile to addTile if standard rules are enabled "); // TODO: create more understandable text for exeception
    }

    public Tile getTile(bool removeFromHeap = true)
    {
        if (standardRules && currentTile != null)
            throw new Exception(""); // TODO: explain exception properly
            
        int i = random.Next(0,heapTiles.Count);
        currentTile = heapTiles[i];
        
        if (removeFromHeap)
            heapTiles.RemoveAt(i);
            
        return currentTile;
    }

    public void addTile()
    {
        addTile(currentTile);
    }

    public void addWorker()
    {

    }
    public String getJson()
    {
        return "";
    }
}