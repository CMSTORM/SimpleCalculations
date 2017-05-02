using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalConverter
{

            

  class CurrencyConverter2
        {
        static void Main()
        {
            double theNumber = double.Parse(Console.ReadLine());
            string firstValue = Console.ReadLine().ToUpper();
            string secondValue = Console.ReadLine().ToUpper();
            var currencies = new Dictionary<string, double>() {
                { "BGN", 1       },
                { "USD", 1.79549 },
                { "EUR", 1.99583  },
                { "GBP", 1.79549 }
            };
            double result =(currencies[firstValue] / currencies[secondValue]) * theNumber;
            Console.WriteLine(Math.Round(result,2));

            }

        }


    }
  

