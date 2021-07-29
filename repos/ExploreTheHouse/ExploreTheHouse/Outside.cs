﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class Outside : Location
    {
        private bool hot;
        

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description { 
            get {
                String newDescription = base.Description;
                if (hot)
                    newDescription += " It's very hot.";
                return newDescription;
            }
        }

    }
}
