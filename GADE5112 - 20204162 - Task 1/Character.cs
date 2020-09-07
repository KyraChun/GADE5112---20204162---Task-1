using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Character : Tile
    {
        public int HP;
        public int maxHP;
        public int damaged;

        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right,
        }

        public virtual void Attack()
        {

        }
        public bool IsDead()
        {

        }
        public virtual bool CheckRange()
        {

        }
        private int DistanceTo()
        {

        }
        public void Move()
        {

        }
        public  Movement ReturnMove()
        {
           // abstract
        }
        public abstract override ToString()
        {

        }
    }
}
