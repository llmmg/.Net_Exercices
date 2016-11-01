using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.Is64BitOperatingSystem==true?"this operating system is 64 bits": "this operating system is not 64 bits");
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.UserDomainName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.Version);
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
