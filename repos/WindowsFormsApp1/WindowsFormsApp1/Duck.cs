using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Duck
    {
        public int Size;
        public KindOfDuck Kind; 

        public Duck()
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size=17},
                new Duck() {Kind = KindOfDuck.Muscovy, Size=18},
                new Duck() {Kind = KindOfDuck.Decoy ,  Size=14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size=11},
                new Duck() {Kind = KindOfDuck.Mallard, Size=14},
                new Duck() {Kind = KindOfDuck.Decoy ,  Size=13}
            };
            // This keeps the output from disappearing before you can read it
            Console.ReadKey();
        }
    }

    enum KindOfDuck { Mallard, Muscovy, Decoy }
}
