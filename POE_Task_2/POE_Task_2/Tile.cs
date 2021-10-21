using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    public enum TileType //TileEnum
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
    }

    /// <summary>
    /// An abstract class that g
    /// </summary>
    public abstract class Tile 
    {
        protected int x ;
        /// <summary>
        /// Returns the x Position of a Tile
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return this.x;
            
        }

        public void setX(int x)
        {
            this.x = x;
        }


        protected int y;

        public int getY()
        { 
            return this.y;
        }

        public void setY(int y)
        {
            this.y = y;
        }


        protected string symbol { get; set; }
        

        public Tile(int xAxis, int yAxis)
        {
            this.x = xAxis;
            this.x = yAxis;          
            this.symbol = "";
        }  
    }
}
