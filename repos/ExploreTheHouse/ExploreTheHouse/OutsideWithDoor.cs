using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name) : base(name)
        {
        }
        // The DoorLocation property goes hier
        // The read-only DoorDescription property goes here
        public string DoorDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DoorLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
