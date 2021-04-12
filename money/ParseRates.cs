using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    abstract class ParseRates
    {
        public double Rate_in { get; set; }
        public double Rate_out { get; set; }





        public abstract void ShowInfo();

    }
}
