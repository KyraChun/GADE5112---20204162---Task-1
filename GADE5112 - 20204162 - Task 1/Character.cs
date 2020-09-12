using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Character : Tile
    {
        protected char[,] tileArray = { };

        public int characterHP
        { get; set; }
        protected int characterMaxHP
        { get; set; }
        public int characterDamaged
        { get; set; }

        public Character()
        {

        }

        public enum Movement
        {
            NoMovement,
            Up = ConsoleKey.UpArrow,
            Down = ConsoleKey.DownArrow,
            Left = ConsoleKey.LeftArrow,
            Right = ConsoleKey.RightArrow,
        }

        public virtual void Attack()
        {
            if (char1 attacks char2)
            {
                char2HP - char1Dam;
            }
        }
        public bool IsDead()
        {
            if (char1HP == 0)
            {
                bool == true;
            }
            return true;
        }
        public virtual bool CheckRange()
        {

            return;
        }
        private int DistanceTo()
        {
            return;
        }
        public void Move()
        {

        }
        //public abstract Movement ReturnMove()
        //{
        //    // abstract
        //    return;
        //}
        public abstract override ToString()
        {

        }
    }
}
