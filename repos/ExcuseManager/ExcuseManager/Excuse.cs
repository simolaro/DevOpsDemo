using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcuseManager
{
    class Excuse
    {
        public string Description;
        public string Results;
        public DateTime LastUsed;
        public string ExcusePath;

        public bool formChanged; 


        public string OpenFile(OpenFileDialog openFile)
        {
            StreamReader sr = new StreamReader(openFile.FileName);
            this.ExcusePath = openFile.FileName;
            this.Description = openFile.SafeFileName.Replace(".txt", "");
            //this.Results = sr.ReadToEnd();
            this.Description = sr.ReadLine();
            this.Results = sr.ReadLine();
            this.LastUsed = DateTime.Parse(sr.ReadLine());

            sr.Close();

            return "OK"; 
        }

        public string Save(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(this.Description);
                sw.WriteLine(this.Results);
                sw.WriteLine(this.LastUsed);
                sw.Close();
            }

            string message = "Excuse Written";
            string title = "Message";
            MessageBox.Show(message, title);

            return fileName;
        }

        // first load
        public Excuse(  string parmDescription,
                        string parmResult,
                        DateTime parmLastUsed,
                        string parmExcusePath)
        {
            this.Description = parmDescription;
            this.Results = parmResult;
            this.LastUsed = parmLastUsed;
            this.ExcusePath = parmExcusePath;
        }

        // opening a file
        public Excuse(OpenFileDialog openFile)
        {
            StreamReader sr = new StreamReader(openFile.FileName);
            this.ExcusePath = openFile.FileName;
            this.Description = openFile.SafeFileName.Replace(".txt", ""); 

            this.Description = sr.ReadLine();
            this.Results = sr.ReadLine();
            this.LastUsed = DateTime.Parse(sr.ReadLine());

            sr.Close();
        }

        // random excuse
        public Excuse()
        {
            // Extraire un excuse au hasard
            
            // Mettre à jour les champs
        }


    }
}
