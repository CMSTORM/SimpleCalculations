using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            DateTime theDay = DateTime.Parse(Console.ReadLine());
            DateTime after1000 = theDay.AddDays(1000);
            Console.WriteLine(after1000.ToShortDateString());
            Console.ReadLine();


        }
    }
}
