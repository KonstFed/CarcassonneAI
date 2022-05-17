using System;

namespace GameCore
{
    public class Core
    {
        private List<Player> players = new ();
        private List<Tile> heapTiles = new ();
        private List<List<Tile>> map = new();
        private List<Terrain> terrains = new();
        private bool standartRules = true;
        private System.Random random;
        private Tile currentTile;
        public Core(bool standartRules = true)
        {
            this.standartRules = standartRules;
            random = new System.Random();
        }

        public void addTile(Tile tile = null)
        {
            if (tile == null)
                tile = currentTile;

            if (tile != currentTile && standartRules)
                throw new ArgumentException("You can send only current tile to addTile if standart rules are enabled "); // TODO: create more understandable text for exeception
        }

        public Tile getTile(bool removeFromHeap = true)
        {
            if (standartRules && currentTile != null)
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
}