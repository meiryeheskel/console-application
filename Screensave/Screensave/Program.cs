using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensave
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Console.WriteLine("Please enter Circle X location, Y location, Color, Radius: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();
            int radius= int.Parse(Console.ReadLine());

            circle1.CircleInfo(x,y,color,radius);

            Square square1 = new Square();
            Console.WriteLine("Please enter Square X location, Y location, Color, Radius: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            string color1 = Console.ReadLine();
            int side = int.Parse(Console.ReadLine());

            square1.SquareInfo(x1, y1, color1, side);

        }
    }
}
