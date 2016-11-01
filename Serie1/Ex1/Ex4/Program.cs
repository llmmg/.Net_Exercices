using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("square root of:");
                double value = Convert.ToDouble(Console.ReadLine());
                double root = value;
                double realRoot = Math.Sqrt(value);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int iter = 0;
                while(root-realRoot>=value*Math.Pow(10,-9))
                {
                    root = (root + value / root) / 2;
                    iter++;
                    Console.WriteLine("iteration:"+iter+"=>"+root);

                }
                watch.Stop();
                Console.WriteLine("time:" + watch.Elapsed + " in " + iter + "iterations." + " Root=" + root);
                Console.WriteLine("Error:" + (root - realRoot));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
