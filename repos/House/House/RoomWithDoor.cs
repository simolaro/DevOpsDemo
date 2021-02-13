using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class RoomWithDoor : Room, IHasExteriorDoor 
    {
        public RoomWithDoor(string name) : base(name)
        {
        }

        public string DoorDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DoorLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
