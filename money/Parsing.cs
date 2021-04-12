using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Parsing : ParseRates
    {
        public void Parse(ref string content, USD dollar, RUB rubl,EUR euro)
        {
            var arr = content
                .Replace("[", "").Replace("]", "")
                .Replace("{", "")
                .Replace("}", "")
                .Replace("\"personal_data\":", "")
                .Split(new string[] { ",\"" },
                    StringSplitOptions.None);

            if (arr.Count() <= 1)
                throw new ArgumentException("Сервис не вернул данных");

            foreach (string prop in arr)
            {
                string value = prop.Replace("\"", "").Replace(@"\", "");
                var propArr = value.Split(':');

                if (propArr[0].Equals("USD_in"))
                    dollar.Rate_in = double.Parse(propArr[1], CultureInfo.InvariantCulture);
                else if (propArr[0].Equals("USD_out"))
                    dollar.Rate_out = double.Parse(propArr[1], CultureInfo.InvariantCulture);
                else if (propArr[0].Equals("RUB_in"))
                    rubl.Rate_in = double.Parse(propArr[1], CultureInfo.InvariantCulture);
                else if (propArr[0].Equals("RUB_out"))
                    rubl.Rate_out = double.Parse(propArr[1], CultureInfo.InvariantCulture);
                else if (propArr[0].Equals("EUR_in"))
                    euro.Rate_in = double.Parse(propArr[1], CultureInfo.InvariantCulture);
                else if (propArr[0].Equals("EUR_out"))
                    euro.Rate_out = double.Parse(propArr[1], CultureInfo.InvariantCulture);

                if (dollar.Rate_in != 0 && dollar.Rate_out != 0 && rubl.Rate_in != 0 && rubl.Rate_out != 0 && euro.Rate_in != 0 && euro.Rate_out != 0)
                    break;
            }

        }

        public override void ShowInfo()
        {

        }
    }
}
