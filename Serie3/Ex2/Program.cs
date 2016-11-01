using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame brdGms = new BoardGame();

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("THE BOARD");
            foreach(char c in alphabet)
            {
                Console.Write(c); 
            }
            Console.WriteLine();
            foreach(char c in alphabet)
            {
                if (brdGms[c])
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                    
            }

            Console.WriteLine("\n\nTHE PAWNS");

            //TODO: print where are the pawns (0,letter 1,letter...)
            int i = 0;
            foreach (char c in alphabet)
            {
                if (brdGms[c])
                    Console.Write(i++ + ": " + c+"   ");
            }

            Console.ReadKey();

        }
    }
}
