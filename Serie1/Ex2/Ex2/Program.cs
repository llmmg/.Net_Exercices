using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
      
        public static double fX(double x)
        {
            return x;
        }
        public static double fX2(double x)
        {
            return x*x;
        }
        public static double fXeSin(double x)
        {
            return Math.Exp(-Math.Sin(x));
        }
        public static double fXmax(double x1, double x2, double x3)
        {
            return Math.Max(x1, Math.Max(x2, x3));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("X    f(x)    g(x)    h(x)    i(x)");

            for (double i = -2.0; i < 2.0; i += 0.1)
            {
                Console.WriteLine(Math.Round(i,3) + "   " + Math.Round(fX(i),3) + "   " + Math.Round(fX2(i),3) + "   " + Math.Round(fXeSin(i),3) + "   " + Math.Round(fXmax(fX(i), fX2(i), fXeSin(i)),3));
            }
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
