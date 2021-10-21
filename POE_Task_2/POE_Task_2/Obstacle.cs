using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    class Obstacle : Tile
    {
        public Obstacle(int x , int y) : base(x, y) 
        {
            this.symbol = "X";
        }
        
    }
}
