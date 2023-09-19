﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarządzane_ulem
{
    public class Queen : Bee
    {
        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;

        }

        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i =0; i< workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyUnitConsumtionRate();
            shiftNumber++;
            string report = "Report zmiany nr: " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyUnitConsumtionRate();
                if (workers[i].DidYouFinish())
                    report += "Robotnica nr: " + (i + 1) + " zakończyła swoje zadanie \r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Robotnica nr: " + (i + 1) + " nie pracjue \r\n";
                else
                    if (workers[i].ShiftLeft > 0)
                    report += "Robotnica nr: " + (i + 1) + " robi " + workers[i].CurrentJob + " jeszcze przez " + workers[i].ShiftLeft + " zmiany \r\n";
                else report += "Robotnica nr: " + (i + 1) + " zakończy " + workers[i].CurrentJob + " po tej zmianie \r\n";
            }
            report += "Całkowite spożycie miodu: " + honeyConsumed + " jednostek \r\n";

            return report;
        }

    }
}
