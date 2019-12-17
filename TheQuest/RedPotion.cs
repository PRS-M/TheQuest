using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location) { }

        public bool Used { get; private set; }

        public override string Name => "Red Potion";

        public override void Attack(Direction direction, Random random)
        {
            if (!Used)
            {
                game.IncreasePlayerHealth(10, random);
                Used = true;
            }
        }
    }
}
