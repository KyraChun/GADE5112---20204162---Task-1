using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    class Goblin : Enemy
    {
        public Goblin(int enemyHP, int enemyDamage) : base (enemyHP, enemyDamage)
        {
            enemyHP = 10;
            enemyDamage = 1;
        }

        //public override string ReturnMove()

    }
}
