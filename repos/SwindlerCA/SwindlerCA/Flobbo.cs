using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwindlerCA
{
    class Flobbo
    {
        private string zap; 
        public Flobbo(string zap) { this.zap = zap; }


        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                zap = "green purple";
                return true;
            } else
            {
                sw.WriteLine(zap);
                sw.Close();
                return true;
            }
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "red orange";
            return true;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }

    }

}
