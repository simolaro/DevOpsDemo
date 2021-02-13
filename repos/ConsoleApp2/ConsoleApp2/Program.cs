using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class TallGuy : IClown 
        {
            public string Name;
            public int Height; 
            public void TalkAboutYourself()
            {
                Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
            }

            public string FunnyThingIHave
            {
                get { return "big shoes"; }
            }

            public void Honk()
            {
                Console.WriteLine("Honk honk!");
            }
        }

        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown ;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary; 
            someOtherScaryClown.Honk();
            Console.WriteLine(someOtherScaryClown.ScaryThingIHave);
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();

            // TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            // tallGuy.TalkAboutYourself();
            
        }
    }
}
