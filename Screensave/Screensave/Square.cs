using System;

namespace Screensave
{

    class Square
    {
        private int side;

        public int Side
        {
            get { return side; }
            set { side = value > 0 ? value : 0; }
        }
        public Square()
        {
            Console.WriteLine("A Square was created.");
        }
        public void SquareInfo(int x, int y, string color, int side)
        {
            Console.WriteLine("Square Info:");
            Console.WriteLine("The X coordinate is {0} and the Y coordinate is {1}", x, y);
            Console.WriteLine("The Square color is {0}", color);
            Console.WriteLine("The Square area is: {0}", SquareArea(side));
            Console.WriteLine("The Square Perimeter is {0}", SquarePerimeter(side));
        }
        public double SquareArea(int side)
        {
            return side * side;
        }
        public double SquarePerimeter(int side)
        {
            return 4 * side;
        }

    }
}

