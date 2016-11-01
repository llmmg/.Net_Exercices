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
            int num1, num2;
            decimal result;

            Begin:

            Console.WriteLine("DIVISION. Entrez 2 nombres, je calcule le quotient");
            Console.WriteLine("Entrez le 1er nombre: ");
            
            try 
            {
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entrez le 2ème nombre: ");

                num2 = Convert.ToInt32(Console.ReadLine()); result = (decimal)num1 / (decimal)num2; Console.WriteLine("Divide : " + result.ToString());

            } catch(Exception e)
            {
                Console.WriteLine(e.GetType());
                
                if(e.GetType()==typeof(FormatException))
                {
                    Console.WriteLine("Veuillez entrer uniquement des chiffres!");

                    //pour le fun
                    goto Begin;

                }else if(e.GetType()==typeof(DivideByZeroException))
                {
                    Console.WriteLine("Division par zéro!");
                }
            }

            Console.ReadLine();
        }
    }
}
