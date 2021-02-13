using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class Outside
    {
        private bool hot;

        public Outside(string name) : base(name)
        {
            if (hot) { name = "It' very hot here."; }
        }

    }
}
