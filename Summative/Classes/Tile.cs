using GoblinSlayer.Classes.Tiles.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinSlayer
{
    [Serializable]
    // Base class for tiles.
    public abstract class Tile
    {
        //Variables
        protected int x;
        protected int y;
        protected char symbol;


        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON,
            EMPTY,
            LEADER,
        }

        //Constructor
        public Tile(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        //Accessors
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool acquired
        {
            get;
            internal set;
        }

        public char getSymbol { get; set; }
    }
}
