using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        //public string Decoration { get; }

        // The DoorLocation property goes hier
        // The read-only DoorDescription property goes here
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        { 
            DoorDescription = doorDescription;
        }
    }
}
