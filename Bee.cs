using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class Bee
    {
        protected string Job { get; }
        protected virtual float CostPerShift { get; }

        public Bee(string job)
        {
            Job = job;

        }

        protected void WorkNextShift(float amount)
        {
            if (HoneyVault.ConsumeHoney(amount))
            {
                DoJob();
            }

        }
        protected virtual void DoJob()
        {

        }

    }
}
