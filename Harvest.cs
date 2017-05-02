using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            float vegPrice = float.Parse(Console.ReadLine());
            float frPrice = float.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());
            float totalEarnings = (vegPrice * kgVegetables + frPrice*kgFruits)/1.94f;
            Console.WriteLine(totalEarnings);
            
        }
    }
}
