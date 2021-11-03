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
            if (move == MovementEnum.UP )
            {
                int currentX = hero.getX();
                int currentY= hero.getY();
                
               
                if (hero.GetCharacterVision()[0].Equals(new Gold(currentX, currentY + 1)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[0];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());

                }
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

                if (hero.GetCharacterVision()[1].Equals(new Gold(currentX,currentY - 1)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[1];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
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

                if (hero.GetCharacterVision()[2].Equals(new Gold(currentX - 1, currentY)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[2];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
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

                if(hero.GetCharacterVision()[3].Equals(new Gold(currentX + 1, currentY )))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[3];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
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
        private void MoveEnemy(Goblin goblin , MovementEnum direction)
        {
            MovementEnum move = this.map.GetHero().ReturnMove(direction);
            if (move == MovementEnum.UP)
            {
                int currentX = goblin.getX();
                int currentY = goblin.getY();
                goblin.setY(currentY + 1);
                this.map.placeTileOnMap(goblin);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
            }
            else if (move == MovementEnum.DOWN)
            {
                int currentX = goblin.getX();
                int currentY = goblin.getY();
                goblin.setY(currentY - 1);
                this.map.placeTileOnMap(goblin);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
            }
            else if (move == MovementEnum.LEFT)
            {
                int currentX = goblin.getX();
                int currentY = goblin.getY();           
                goblin.setX(currentX - 1);
                this.map.placeTileOnMap(goblin);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();   
            }
            else if (move == MovementEnum.RIGHT)
            {
                int currentX = goblin.getX();
                int currentY = goblin.getY();
                goblin.setX(currentX + 1);
                this.map.placeTileOnMap(goblin);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();      
            }    
        }
        public void MoveEnemies()
        {
            
            for (int i = 0; i < this.map.GetEnemyArray().Length; i++)
            {
                if (this.map.GetEnemyArray()[i].GetType() == typeof(Goblin))
                {
                    Random randomMove = new Random();
                    MovementEnum  move = (MovementEnum)randomMove.Next(0, 5);

                    this.MoveEnemy((Goblin)this.map.GetEnemyArray()[i], move);
                }
            }
        }
        public void EnemyAttack()
        {
         
            for (int i = 0; i < this.map.GetEnemyArray().Length; i++)
            {
                for (int j = 0; j < this.map.GetEnemyArray()[i].GetCharacterVision().Length; j++)
                {
                    Character target = (Character)this.map.GetEnemyArray()[i].GetCharacterVision()[j];
                    this.map.GetEnemyArray()[i].Attack(target);
                }   
            }
        }
    }
}
