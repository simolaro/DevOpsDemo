using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ScaryScary : FunnyFunny, IScaryClown  
    {
        //public string ScaryThingIHave;
        private int numberOfScaryThings;

        //string IScaryClown.ScaryThingIHave { get; }

        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders" ; }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("You can't have my " + base.funnyThingIHave );
        }

        public ScaryScary(string funnyThingIHave,  int numberOfscaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfscaryThings;
            
        }
    }
}
