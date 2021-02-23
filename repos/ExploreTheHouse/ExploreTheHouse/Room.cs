using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class Room : Location
    {
        public override string Description => base.Description;

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        private string decoration ; 

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = name; 
            name = "You see " + decoration;
        }
       
    }
}
