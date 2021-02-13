using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen
    {
        private Worker[] workers ;
        private int shiftNumber = 0 ;

        public bool AssignWork(string job, int numberOfShift)
        {
            // Vérifier s'il y a un travailleurs disponible pour la tâche
            for (int x = 0; x < workers.Length ; x++)
            {
                if (workers[x].DoThisJob(job, numberOfShift)) { return true; }
            }

            return false;
        }

        public string WorkTheNextShift(string report)
        {
            // Générer le rapport
            shiftNumber++;
            report = "Report for shift #" + shiftNumber + "\r\n";
            for (int workerNumber = 0; workerNumber < workers.Length ; workerNumber++)
            {
                // Vérifier si le worker a quelque chose à faire
                if (String.IsNullOrEmpty(workers[workerNumber].CurrentJob))
                { report += "Worker #" + (workerNumber + 1) + " is not working." + Environment.NewLine; }

                else if (workers[workerNumber].DidYouFinish())
                {
                    // worker has finished - était en train de travailler sur quelque chose
                    report += "Worker #" + (workerNumber + 1) + " finished the job." + Environment.NewLine;
                    report += "Worker #" + (workerNumber + 1) + " is not working." + Environment.NewLine;
                }
                else
                {
                    // worker hasn't finished
                    report += "Worker #" + (workerNumber + 1) + " is doing " + workers[workerNumber].CurrentJob + " for " +
                    workers[workerNumber].ShiftsLeft + Environment.NewLine;
                }
                
            }

            return report;
        }

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
    }

    

}
