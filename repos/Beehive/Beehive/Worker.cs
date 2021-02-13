using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Worker
    {
        private string currentJob;
        public string CurrentJob
        {
            get { return currentJob; }
        }
        public int ShiftsLeft
        {
            get { return shiftsTOWork - shiftsWorked; }
        }

        private string[] jobsICanDo;
        private int shiftsTOWork;
        private int shiftsWorked;

        public bool DoThisJob(string job, int numberOfShift)
        {
            if (String.IsNullOrEmpty(currentJob))
            {

                foreach (string a in jobsICanDo)
                {
                    if (a == job)
                    {
                        currentJob = job;
                        shiftsTOWork = numberOfShift;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (!String.IsNullOrEmpty(CurrentJob))
            {
                shiftsWorked += 1;
                if (shiftsWorked > shiftsTOWork )
                {
                    shiftsTOWork = 0;
                    shiftsWorked = 0;
                    currentJob = null;
                    return true;
                }
            }

            return false;

        }

        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
        }
    }
}

