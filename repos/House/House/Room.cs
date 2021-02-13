using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Room : Location 
    {
        private string decoration;

        public Room(string name) : base(name)
        {
            name = "You see " + decoration;
        }
    }
}
