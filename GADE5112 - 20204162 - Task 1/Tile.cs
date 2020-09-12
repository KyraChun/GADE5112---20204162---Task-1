using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Tile
    {
        protected string positionX
        { get; set; }

        protected string positionY
        { get; set; }

        public enum TileType
        {
            HeroTile,
            EnemyTile,
            GoldTile,
            WeaponTile,
        }

        public Tile()
        {
            TileType HeroTile = H;
            TileType EnemyTile = G;
            TileType GoldTile;
            TileType WeaponTile;
        }
    }

    class Obstacle : Tile
    {
        public Obstacle(Tile)
        {
            positionY;
            positionX;

        }
    }

    class EmptyTile : Tile
    {
        public EmptyTile(Tile)
        {
            positionY;
            positionX;

        }
    }
}
