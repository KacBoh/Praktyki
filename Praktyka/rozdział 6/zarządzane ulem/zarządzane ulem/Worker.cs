using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace zarządzane_ulem
{
    public class Worker
    {
        public Worker(string[] jobsICanDo) 
        {
            this.jobsICanDo = jobsICanDo;
        }

        public int ShiftLeft
        {
            get
            {
                return ShiftsToWork - ShiftsWorked;
            }
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        private string[] jobsICanDo;
        private int ShiftsToWork;
        private int ShiftsWorked;

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if(!String.IsNullOrEmpty(currentJob))
            {
                return false;
            }

            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.ShiftsToWork = numberOfShifts;
                    ShiftsWorked = 0;
                    return true;

                }
                
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if(String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            ShiftsWorked++;
            if(ShiftsWorked > ShiftsToWork)
            {
                ShiftsWorked = 0;
                ShiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else return false;
        }

    }
}
