using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 + 45 = " + Calc.Getsub(3, 45));
            Console.WriteLine("3 + 4 + 60 = " + Calc.Getsub(3, 4,60));
            Console.WriteLine("7.5 + 20.4 = " + Calc.Getsub(7.5, 20.4));



        }
    }
}
