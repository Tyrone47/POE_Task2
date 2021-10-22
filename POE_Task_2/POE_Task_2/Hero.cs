using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_2
{
    class Hero : Character
    {
        
        public Hero(int x, int y, int hP, string symbol) : base(x, y,symbol )
        {
            this.HP = hP;
            this.maxHP = hP;
            this.damage = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move )
        {

            if (move == MovementEnum.UP && this.characterVision[this.y + 1].Equals(new EmptyTile(this.x, this.y + 1)))
            {
                return move;

            }
            else if (move == MovementEnum.DOWN && this.characterVision[this.y - 1].Equals(new EmptyTile(this.x, this.y - 1)))
            {
                return move;

            }
            else if (move == MovementEnum.LEFT && this.characterVision[this.x - 1].Equals(new EmptyTile(this.x - 1, this.y )))
            {

                return move;
            }
            else if (move == MovementEnum.RIGHT && this.characterVision[this.x + 1].Equals(new EmptyTile(this.x + 1, this.y)))
            {

                return move;
            }
            return MovementEnum.NOMOVEMENT;
        }

        public override string ToString()
        {
            string playerStats = "";
            playerStats += " Player Stats: " + System.Environment.NewLine;
            playerStats += " HP: " + this.HP + "/" + this.maxHP + System.Environment.NewLine;
            playerStats += "Damage: " + this.damage + System.Environment.NewLine;
            playerStats += "[" + this.x + ", " + this.y + "]" + System.Environment.NewLine;

            return playerStats;               
        }

    }
}
