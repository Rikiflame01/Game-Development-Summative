using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinSlayer
{
    //Simply denotes an empty tile
    [Serializable]
    public class EmptyTile : Tile
    {
        //Constructor for subclass
        public EmptyTile(int x, int y, char symbol) : base(x, y, symbol)
        {

        }
    }
}
