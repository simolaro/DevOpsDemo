using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class RoomWithDoor : IHasExteriorDoor
    {
        private string v1;
        private string v2;
        private string v3;

        public RoomWithDoor(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        // The DoorLocation property goes hier
        // The read-only DoorDescription property goes here
        public string DoorDescription { get ; set ; }
        public string DoorLocation { get ; set ; }
    }
}
