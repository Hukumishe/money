using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class USD : ParseRates
    {
        public USD()
        {
            Rate_in = 0;
            Rate_out = 0;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Покупка доллара: " + Rate_in);
            Console.WriteLine("Продажа доллара: " + Rate_out);
            Console.WriteLine("-----------------------------");
        }
    }
}
