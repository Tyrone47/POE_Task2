﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_2
{
    class Mage : Enemy
    {

        public Mage(int x, int y) : base(x, y, 5, 5, "M")
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return MovementEnum.NOMOVEMENT;
        }

        public override bool CheckRange(Character target)
        {
            //M : denote Mage
            /**
             *  M : Denote Mage
             *  E : Denote Enemy
             *  
             *  M (x,y)  ------> Top/North E (x , y + 1)       Distance is 1
             *           ------> Bottom/South E (x , y -1)     Distance is 1
             *           ------> Right/East E (x + 1 , y)      Distance is 1
             *           ------> Left/West E  (x - 1, y)       Distance is 1
             *           ------> North East E  (x + 1 , y + 1) Distance is 2
             *           ------> South East E  (x + 1 , y -1 ) Distance is 2
             *           ------> North West E (x - 1 , y + 1)  Distance is 2
             *           ------> South West E (x - 1 , y - 1)  Distance is 2
             **/


            if (target.GetType() == typeof(Enemy))
            {
                int distance = this.DistanceTo(target);
                if (distance == 1 || distance == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
