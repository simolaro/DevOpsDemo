using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 6)
        { }

        public override void Move(Random random)
        {
            
        }
    }
}
