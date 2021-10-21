using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    class Map
    {
        private Tile[,] tileMap;

        private Hero hero;

        private Enemy[] enemyArray;

        private int width;

        private int height;

        private  Random random;

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
      
        
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
      



        public Map( int minWidth , int maxWidth, int minHeight , int maxHeight , int numOfEnemies)
        {
            this.random = new Random();

            this.height = this.random.Next(minHeight, maxHeight + 1);
            this.width = this.random.Next(minWidth, maxWidth + 1);
            this.tileMap = new Tile[this.width,this.height];

            //This fills up the left side of the boarder Only.

            for (int j = 0; j < this.height; j++) 
            {
                Obstacle obstacle = new Obstacle(0, j);
                this.tileMap[0, j] = obstacle;
            }

            //This fills up the right side of the boarder only.
            //
            for (int j = 0; j < this.height; j++)
            {
                Obstacle obstacle = new Obstacle(this.width - 1, j);
                this.tileMap[this.width - 1, j] = obstacle;
            }

            //This fills up the bottom side of the boarder only.
            for (int i = 0; i < this.width; i++)
            {
                Obstacle obstacle = new Obstacle(i, 0);
                this.tileMap[i, 0] = obstacle;
            }

            //This fills up the top side of the boarder only.

            for (int i = 0; i < this.width; i++)
            {
                Obstacle obstacle = new Obstacle(i, this.height - 1);
                this.tileMap[i, this.height -1] = obstacle;
            }

            //This fills up the rest of the map with empty tiles
            for (int i = 1; i < this.width - 2; i++)
            {
                for (int j = 1; j < this.height - 2; j++)
                {
                    EmptyTile emptyTile = new EmptyTile(i, j);
                    this.tileMap[i, j] = emptyTile;              
                }
            }

            // Creates the hero in the tie class.
            this.hero = (Hero)this.Create(TileType.Hero);

            //Creates enemies in the class.
            
            this.enemyArray = new Enemy[numOfEnemies];
            for (int i = 0; i < numOfEnemies; i++)
            {
                this.enemyArray[i] = (Enemy)this.Create(TileType.Enemy);
            }

        }
        
        public void UpdateVision()
        {
            int xPos = this.hero.getX();
            int yPos = this.hero.getY();

            //update vision of hero
            this.hero.SetCharacterVision(this.tileMap[xPos, yPos + 1], 0);
            //South
            this.hero.SetCharacterVision(this.tileMap[xPos, yPos - 1], 1);
            //East
            this.hero.SetCharacterVision(this.tileMap[xPos + 1, yPos], 2);
            //West
            this.hero.SetCharacterVision(this.tileMap[xPos - 1, yPos], 3);

            //update enemy vision
            for (int i = 0; i < this.enemyArray.Length; i++)
            {
                 xPos = this.enemyArray[i].getX();
                 yPos = this.enemyArray[i].getY() ;

                //North
                this.enemyArray[i].SetCharacterVision(this.tileMap[xPos, yPos + 1], 0);
                //South
                this.enemyArray[i].SetCharacterVision(this.tileMap[xPos, yPos - 1], 1);
                //East
                this.enemyArray[i].SetCharacterVision(this.tileMap[xPos + 1, yPos ], 2);
                //West
                this.enemyArray[i].SetCharacterVision(this.tileMap[xPos - 1, yPos], 3);
            }
            
        }

        private Tile Create(TileType tileType)// 
        {
            if (tileType == TileType.Hero)
            {
                int x = this.random.Next(1, this.width - 2);
                int y = this.random.Next(1, this.height - 2);
                while (!this.tileMap[x,y].Equals( new EmptyTile(x,y)))
                {
                     x = this.random.Next(1, this.width - 2);
                     y = this.random.Next(1, this.height - 2);
                }
                Hero hero = new Hero(x, y, 3, "H");
                this.tileMap[x, y] = hero;
                return hero;
            }
            else if (tileType == TileType.Enemy)
            {
                int x = this.random.Next(1, this.width - 2);
                int y = this.random.Next(1, this.height - 2);
                while (!this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                {
                    x = this.random.Next(1, this.width - 2);
                    y = this.random.Next(1, this.height - 2);
                }
                Enemy goblin = new Goblin(x, y);
                this.tileMap[x, y] = goblin;
                return goblin;

            }
            return new EmptyTile(0,0);
        }
    }
}
