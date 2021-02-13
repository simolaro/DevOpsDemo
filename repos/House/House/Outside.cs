using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House 
{
    class Outside : Location 
    {
        private bool hot;

        public Outside(string name) : base(name)
        {
            if (hot) { name = "It' very hot here.";  }
        }

    }
}
