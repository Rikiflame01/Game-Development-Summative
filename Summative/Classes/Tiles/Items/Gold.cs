using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinSlayer.Classes.Tiles.Items
{
    [Serializable]
    public class Gold : Item
    {
        private int goldNum;


        private Random random = new Random();

        public int MaxGoldNum
        {
            get { return goldNum; }
            set { goldNum = value; }
        }

        //max gold value.
        public Gold(int x, int y) : base(x, y, 'G') 
        {
            goldNum = 5;
        }

        public override string ToString()
        {
            return $"$ located at [{this.x}, {this.y}]";
        }
    }
}
