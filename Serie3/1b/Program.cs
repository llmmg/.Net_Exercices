using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex1b
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("../../../../discours.txt");

            Dictionary<char, int> histogram = new Dictionary<char, int>();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (char c in alphabet)
            {
                histogram.Add(c, 0);
            }

            //convert text to lowercase
            text=text.ToLower();

            foreach(char c in text)
            {
                if(histogram.ContainsKey(c))
                    histogram[c]++;
            }

            int temp = 0;
            char mostRecurentChar='a';
            foreach(char c in alphabet)
            {
                if (histogram[c] > histogram[mostRecurentChar])
                {
                    temp = histogram[c];
                    mostRecurentChar = c;
                }

            }

            Console.WriteLine("Most recurent character: "+mostRecurentChar+" with:"+temp+" emergence");

            Console.ReadKey();
        }
    }
}
