using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract class Location
    {
        public Location(String name) { Name = name; }
        public Location[] Exits;
        public string Name { get; private set; }
        public virtual string Description
        {
            get
            {
                string description = "You're staanding in the " + Name + ". Yousee exits to the following places: ";
                for(int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1) description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
