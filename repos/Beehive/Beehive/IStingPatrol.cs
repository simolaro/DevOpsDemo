using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }

    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}

