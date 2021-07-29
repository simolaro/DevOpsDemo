using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penduins Can't fly!");
        }
        public override string ToString()
        {
            return "A penguin named " + base.Name; 
        }
    }
}
