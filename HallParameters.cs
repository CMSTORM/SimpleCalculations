using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = (double.Parse(Console.ReadLine()))*100;
            double widht  = (double.Parse(Console.ReadLine()))*100;
            if ((3 <= height  ||  height <= 100) && (3<=widht || widht <= 100))
            {
                double rows = Math.Truncate(height / 120);
                double columns = Math.Truncate((widht - 100) / 70);
                double totalWorkPlace = rows * columns - 3;
                Console.WriteLine(Math.Round(totalWorkPlace));
            }
            
        }
    }
}
