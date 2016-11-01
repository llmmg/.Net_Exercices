using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        delegate void processDelegate(ref int var);
        public static void add(ref int var)
        {
            var += 1;
        }
        public static void mult(ref int var)
        {
            var *= 2;
        }
        public static void less(ref int var)
        {
            var -= 4;
        }
        public static string printMenu(ref int var)
        {
     
            Console.WriteLine("VALEUR=" + var);
            Console.WriteLine("1. Ajouter 1");
            Console.WriteLine("2. Multipluer par 2");
            Console.WriteLine("3. Soustraire 4");
            Console.WriteLine("4. Quitter");
            Console.WriteLine("Votre choix(1-4):");
            string answere = Console.ReadLine();
            return answere;
                                              
        }
        static void Main(string[] args)
        {
            processDelegate compute;
            int var=0;
            string answer;
            do
            {
                answer = printMenu(ref var);
                switch (answer)
                {
                    case "1":
                        compute = add;
                        compute(ref var);
                        break;
                    case "2":
                        compute = mult;
                        compute(ref var);
                        break;
                    case "3":
                        compute = less;
                        compute(ref var);
                        break;
                    case "4":
                        Console.WriteLine("++");
                        break;
                    default:
                        Console.WriteLine("Erreur d'entrée");
                        break;
                }
            } while (answer != "4");
        }
    }
}
