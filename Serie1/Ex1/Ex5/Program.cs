using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                int index = 0;
              
                using (StreamReader sr = new StreamReader(@"../../../../../Mesures.txt"))
                {
                    String line = "";
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        Console.Write(line + ", ");
                        if (++index % 10 == 0) Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(" \n Press something to continue");
            Console.ReadKey();
        }
    }
}
