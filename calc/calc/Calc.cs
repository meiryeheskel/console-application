using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    static class Calc
    {
       public static int Getsub(int x,int y)
        {
            return x + y;
        }
        public static int Getsub(int x, int y,int z)
        {
            return x + y + z;
        }
        public static double Getsub(double x, double y)
        {
            return x + y;
        }
        static Calc()
        {
            Console.WriteLine("The calc application was first used at {0}", DateTime.Now);
        }
        
    }
}
