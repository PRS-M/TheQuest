using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name => "Mace";

        public override void Attack(Direction direction, Random random)
        {
            // Conditions to be further developed
            DamageEnemy(Direction.Right, 20, 6, random);
            DamageEnemy(Direction.Down, 20, 6, random);
            DamageEnemy(Direction.Left, 20, 6, random);
            DamageEnemy(Direction.Up, 20, 6, random);
        }
    }
}
