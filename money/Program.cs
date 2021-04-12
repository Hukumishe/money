using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string answer = wc.DownloadString("https://belarusbank.by/api/kursExchange");
            USD dollar = new USD();
            RUB rubl = new RUB();
            EUR euro = new EUR();

            ParseRates babki;
            Parsing money = new Parsing();
            money.Parse(ref answer, dollar, rubl, euro);
            dollar.ShowInfo();
            rubl.ShowInfo();
            euro.ShowInfo();
            
        }
    }
}
