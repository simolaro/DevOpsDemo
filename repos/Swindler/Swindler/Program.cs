using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swindler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter sw = new StreamWriter(folder + @"\secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genious secret plan by The Swindler");
            sw.Write("I'll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall") { location = "downtown";  }
                else { location = "the mall"; }
            }
            sw.Close();


            StreamReader reader = new StreamReader(folder + @"\secret_plan.txt");
            StreamWriter writer = new StreamWriter(folder + @"\emailToCaptainAmazing.txt");

            writer.WriteLine("To: CaptainAmazing@objecville.net");
            writer.WriteLine("From: Commissionerg@objecville.net");
            writer.WriteLine("Subject: Can you save the day...again ?");
            writer.WriteLine();
            writer.WriteLine("We've discoverd the Swindler's plan:");

            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();

        }
    }
}
