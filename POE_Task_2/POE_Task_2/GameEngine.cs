using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_2
{
    public class GameEngine 
    {
        private Map map;

        public Map GetMap()
        {
            return this.map;
        }

        public  GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies, int goldDrops)
        {
            this.map = new Map(minWidth, maxWidth, minHeight, maxHeight, numOfEnemies, goldDrops);
             
        }

        public bool MovePlayer (MovementEnum direction)
        {
            Hero hero = this.map.GetHero();

               
            MovementEnum move = this.map.GetHero().ReturnMove(direction);
            if (move == MovementEnum.UP)
            {
                int currentX = hero.getX();
                int currentY= hero.getY();
                hero.setY(currentY + 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if(move == MovementEnum.DOWN)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();
                hero.setY(currentY - 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if (move == MovementEnum.LEFT)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();
                hero.setX(currentX - 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if (move == MovementEnum.RIGHT)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();
                hero.setX(currentX + 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            
            return this.map.ToString(); 
        }

    }
}
