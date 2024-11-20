using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class BluePotion : Weapon
    {
        public BluePotion(Game game, Point location): base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            // ajout du code...
            throw new NotImplementedException();
        }
    }
}
