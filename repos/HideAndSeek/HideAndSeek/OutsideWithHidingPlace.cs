using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class OutsideWithHidingPlace : Outside, IHasHidingPlace
    {
        public string HidingPlace { get; private set;  } 
        
        public OutsideWithHidingPlace (string name, bool hot, string hidingPlace) : base(name, hot)
        {
            this.HidingPlace = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Hiding in " + HidingPlace + ".";
            }
        }
    }
}
