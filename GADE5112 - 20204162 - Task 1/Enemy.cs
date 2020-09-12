using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Enemy : Character
    {
        protected Random random = new Random();

        public Enemy(int EnemyHP, int EnemyDamage)
        {
            int enemyHP = EnemyHP;
            int enemyDamage = EnemyDamage;
            string enemySymbol;
            int positionX;
            int positionY;
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Age;
            //EnemyClassName at [X, Y] (Amount DMG)
        }
    }
}
