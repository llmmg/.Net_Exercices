using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {

        /// <summary>
        /// Retourne un tableau de tableau avec en première indice (finalTab[0][]) les valeur paires
        /// et en seconde positions(finalTab[1][]) les valeurs impaires
        /// 
        /// Prend un tableau d'entiers en paramètres
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int[][] PairImpair(int[] tab)
        {
            int i = 0;
            int y = 0;

            foreach (int var in tab)
            {
                if(var%2==0)
                {
                    //paire
                    i++;
                }else
                {
                    //impaire
                    y++;
                }
                
            }

            int[][] finalTab = new int[2][];

            finalTab[0] = new int[i];
            finalTab[1] = new int[y];
            i = 0;
            y = 0;
            for(int a=0;a<tab.Length;a++)
            {
                if(tab[a]%2==0)
                {
                    finalTab[0][i] = tab[a];
                    i++;
                }
                else
                {
                    finalTab[1][y] = tab[a];
                    y++;
                }
            }

            return finalTab;
        }
        static void Main(string[] args)
        {
            int[] tableau = new int[20];

            Random rnd = new Random();
            //remplissage du tableau avec des valeurs aléatoires
            for(int i=0;i<tableau.Length;i++)
            {
                tableau[i] = rnd.Next(0, 100);
            }
            Console.WriteLine("Valeurs à séparer: \n");
            foreach(int var in tableau)
            {
                Console.Write(var+" ");
            }
            Console.WriteLine();

            //récuperation du tableau de tableau (valeurs paires et impaires)
            int [][] returnTab = PairImpair(tableau);

            Console.WriteLine("Appel de PairImpair:");

            Console.Write("Paire: ");
            foreach(int values in returnTab[0])
            {
                Console.Write(values + " ");
            }

            Console.Write("Imparie: ");
            foreach (int values in returnTab[1])
            {
                Console.Write(values + " ");
            }

            Console.WriteLine("\nEnd, type something to leave:");
            Console.ReadKey();
        }
    }
}