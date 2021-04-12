using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class RUB : ParseRates
    {
        public override void ShowInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Покупка рубля: " + Rate_in);
            Console.WriteLine("Продажа рубля: " + Rate_out);
            Console.WriteLine("-----------------------------");
        }
    }
}
