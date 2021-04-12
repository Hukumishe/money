using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class EUR : ParseRates
    {
        public override void ShowInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Покупка евро: " + Rate_in);
            Console.WriteLine("Продажа евро: " + Rate_out);
            Console.WriteLine("-----------------------------");
        }
    }
}
