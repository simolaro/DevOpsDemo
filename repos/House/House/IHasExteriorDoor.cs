using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; set; }
        string DoorLocation { get; set; }
    }
}
