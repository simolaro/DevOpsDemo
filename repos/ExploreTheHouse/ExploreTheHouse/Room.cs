using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class Room : Location
    {
        public string decoration;

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }

        public Room(string name, string decoration) : base(name) 
        {
            // Description = name;
            this.decoration = decoration; 
            
        }
       
    }
}
