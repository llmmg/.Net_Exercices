/*
 * Serie 02_4 Faite à l'arrache avec un ou deux bugs, sans respect des conventions ni des bonnes pratiques
 *  de codage C#...
 * 
 * 
 * 
 *  Hmm il y aura bien un étudiant pour corriger et sécuriser tout ça!
 *  dette technologique hmm ? jamais entendu ça!
 *  
 *  (c) ???? 2016
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie02_4
{
    class Program
    {
        static void publicationDesdonnees() { Console.ReadKey(); }
        static void Main(string[] args)
        {
int POSITIONSTABELLE = -1;
                                                                        int[] values=new int[100];
                                                                   string nf = Console.ReadLine();
            System.IO.StreamReader sr = new System.IO.StreamReader(nf, System.Text.Encoding.ASCII);
                                                           string fc = sr.ReadToEnd(); sr.Close();
                      string [] zeilen = fc.Split('\n');   int[] données = new int[zeilen.Length];
            foreach (var v in zeilen)

                                                                  données[++POSITIONSTABELLE] = System.Convert.ToInt32(v);
            foreach (var muestra in données)
                Console.Write($"{muestra}, "); Console.WriteLine("");
            int[] tableaudesdonneesfiltrees = new int[64];
            for (Int16 idnex =0; idnex<-2 + données.GetLength(0);idnex++)
            {
                tableaudesdonneesfiltrees[idnex] = données[idnex] / (données[idnex + 1] - données[idnex + 2]);
            }
            foreach (var v in tableaudesdonneesfiltrees) { Console.Write($"{v}, "); } Console.WriteLine("");
            int[] tableauAenregistrer = tableaudesdonneesfiltrees;










            /*
                        ||
                        ||
                        ||
                        ||          FIN DU CODE (en bas)
                        ||
                        ||
                        VV   
            */








            System.IO.StreamWriter sr_ = new System.IO.StreamWriter("test.txt");
            foreach (var v in tableauAenregistrer)
                sr_.WriteLine(v);
            sr_.Close();
            publicationDesdonnees();
        }
    }
}

/*
            sr = new System.IO.StreamReader(nomFichier, textfilesEncoding);
            string fileContent = sr.ReadToEnd();
            sr.Close(); // free the file
                        // 2. split the records line by line
            string[] lines = fileContent.Split('\n');
            int n = 0;
            foreach (string line in lines)
                n += AddLoadedMember(line);
            sbMessage.Text = n + "members successfully  loaded";
 */
