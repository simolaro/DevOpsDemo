using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwindlerCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
            //StreamWriter sw = new StreamWriter(@"C:\Users\simon\Downloads\secret_plan.txt");
            //sw.WriteLine("How I'll defeat Captain Amazing");
            //sw.WriteLine("Another genious secret plan by The Swindler");
            //sw.Write("I'll create an army of clones and ");
            //sw.WriteLine("unleash them upon the citizens of Objectville.");
            //string location = "the mall";
            //for (int number = 0; number <= 6; number++)
            // {
            //     sw.WriteLine("Clone #{0} attacks {1}", number, location);
            //     if (location == "the mall") { location = "downtown"; }
            //     else { location = "the mall"; }
            // }
            // sw.Close();


        }

    }



}
