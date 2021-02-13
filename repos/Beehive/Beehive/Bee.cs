using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Bee : IStingPatrol
    {
        public int AlertLevel => throw new NotImplementedException();

        public int StingerLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool LookForEnemies()
        {
            //throw new NotImplementedException();
            return true; 
        }

        public int SharpenStinger(int length)
        {
            //throw new NotImplementedException();
            return 1; 
        }
    }
}
