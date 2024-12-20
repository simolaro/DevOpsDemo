﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
     
        // The DoorLocation property goes hier
        // The read-only DoorDescription property goes here
        public string DoorDescription { get ; private set ; }
        public Location DoorLocation { get ; set ; }

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + DoorDescription + ".";
            }
        }
    }
}
