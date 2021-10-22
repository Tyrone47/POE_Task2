﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_2
{
    public abstract class Enemy : Character
    {
        protected Random random;

        public Enemy(int x , int y , int damage, int maxHP , string symbol) : base(x, y, symbol )
        {
            this.damage = damage;
            this.maxHP = maxHP;

        }
        public override string ToString()
        {
            return typeof(Enemy).Name + " at[ " + this.x + "," + this.y + "] (Amount + " + this.damage + ")";
        }
    }
}
