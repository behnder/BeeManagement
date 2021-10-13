using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class Queen : Bee
    {
        protected override float CostPerShift => base.CostPerShift = 1;
        public Queen() : base("Queen")
        {

        }
        
    }
}
