using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensave
{
    class Circle
    {

        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : 0; }
        }
        public Circle()
        {
            Console.WriteLine("A circle was created.");
        }
        public void CircleInfo(int x,int y,string color,int radius)
        {
            Console.WriteLine("Circle Info:");
            Console.WriteLine("The X coordinate is {0} and the Y coordinate is {1}",x,y);
            Console.WriteLine("The circle color is {0}",color);
            Console.WriteLine("The Circle area is: {0}",CircleArea(radius));
            Console.WriteLine("The Circle Perimeter is {0}",CirclePerimeter(radius));
        }
        public double CircleArea(int radius)
        {
            return Math.PI * radius * radius;
        }
        public double CirclePerimeter (int radius)
        {
            return 2 * Math.PI * radius;
        }

    }
}
