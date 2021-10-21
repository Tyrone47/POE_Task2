using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    public enum MovementEnum
    {
        NOMOVEMENT,
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public enum Directions
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }
    public abstract class Character : Tile
    {


        protected int HP;
        protected int maxHP;
        protected int damage;

        public int GetHP()
        {
            return HP;

        }
        public void SetHP(int hP)
        {
            this.HP = hP;
        }
        public int GetMaxHP()
        {
            return HP;

        }

        public void SetMaxHP(int maxiHp)
        {
            this.maxHP = maxiHp;

        }
        public int GetDamage()
        {
            return damage;

        }
        public void SetDamage(int damage)
        {
            this.damage = damage;

        }


        protected Tile[] characterVision;
     
        public Tile[] GetCharacterVision() 
        {
            return this.characterVision;
        }

        public void  SetCharacterVision(Tile tile,int position)
        {
            //0 Represents THe North side,
            //1 is the south,
            //2 is tnhe east and
            //west is 3
            if ( 0 <= position && position <= this.characterVision.Length - 1)
            {
                this.characterVision[position] = tile;
            }
           
        }

        public Character (int xPos , int yPos , string symbol) : base(xPos, yPos) {
            this.symbol = symbol;
            this.characterVision = new Tile[4];
        }

        public virtual void Attack(Character target) { }
        

        public bool isDead ()
        {
            
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            return false;//To implement

        }

        private int DistanceTo(Character target)
        {
            return 0;//To implement
        }
        public void Move(MovementEnum move)
        {
            if (move == MovementEnum.UP)
            {
                this.y++;
            }
            else if(move == MovementEnum.DOWN)
            {
                this.y--;
            }
            else if(move == MovementEnum.LEFT)
            {
                this.y--;

            }
            else if(move == MovementEnum.RIGHT)
            {
                this.y++;
            }
            
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);
        

        
        public abstract override string ToString();

    }
}
