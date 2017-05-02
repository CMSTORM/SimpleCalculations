using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            double playGround = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchHeight = double.Parse(Console.ReadLine());

            double playGroundArea = playGround * playGround;
            double areaToCover = playGroundArea - benchHeight * benchWidth;
            double tileSize = tileHeight * tileWidth;

            double tileNeed = areaToCover / tileSize;
            Console.WriteLine(tileNeed);
            Console.WriteLine(tileNeed * 0.2);
           




        }
    }
}
