using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FunnyFunny : IClown
    {
        protected string funnyThingIHave; 
        public string FunnyThingIHave
        {
            get { return "Hi kids! I have " + funnyThingIHave; }
        }

        public FunnyFunny(string funnyThingIHave)
        { this.funnyThingIHave = funnyThingIHave; }
        

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }

        
    }
}
