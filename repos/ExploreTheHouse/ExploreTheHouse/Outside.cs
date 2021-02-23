using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTheHouse
{
    class Outside : Location
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

        private bool hot;

        public Outside(string name) : base(name)
        {
            if (hot) { name = "It' very hot here."; }
        }

    }
}
