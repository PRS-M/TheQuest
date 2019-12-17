using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name => "Sword";

        public override void Attack(Direction direction, Random random)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (!DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        if(!DamageEnemy(Direction.Right, 10, 3, random))
                        {
                            DamageEnemy(Direction.Left, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Down:
                    if (!DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        if (!DamageEnemy(Direction.Left, 10, 3, random))
                        {
                            DamageEnemy(Direction.Right, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Left:
                    if (!DamageEnemy(Direction.Left, 10, 3, random))
                    {
                        if (!DamageEnemy(Direction.Up, 10, 3, random))
                        {
                            DamageEnemy(Direction.Down, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Right:
                    if (!DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        if (!DamageEnemy(Direction.Down, 10, 3, random))
                        {
                            DamageEnemy(Direction.Up, 10, 3, random);
                        }
                    }
                    break;

            }
        }
    }
}
