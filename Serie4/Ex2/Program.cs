using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        //no nullable lists
        static void addToList<T1>(ref List<T1> list, T1 data) where T1 : struct 
        {
            list.Add(data);
        }

        //nullable lists
        static void addToListString<T1>(ref List<T1> list, T1 data) where T1 : class 
        {
            list.Add(data);
        }

        //get data from file. return a list of objects (generic?)
        static void getData(out List<object> listObject)
        {
            List<string> listString = new List<string>();
            List<double> listDouble = new List<double>();
            List<char> listChar = new List<char>();
            List<int> listInt = new List<int>();

            int valueInt;
            double valueDouble;
            char valueChar;
            string valueString;

            string[] lines = System.IO.File.ReadAllLines("../../divers.txt");
            System.Console.WriteLine("\nContents of the file:");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
                if (Int32.TryParse(lines[i], out valueInt))            
                {
                    //ints
                    addToList(ref listInt, valueInt);
                }
                else if (Double.TryParse(lines[i], out valueDouble))   
                {
                    //Doubles
                    addToList(ref listDouble, valueDouble);
                }
                else if (Char.TryParse(lines[i], out valueChar))      
                {
                    //Chars
                    addToList(ref listChar, valueChar);
                }
                else if (lines[i].Length != 0)                        
                {
                    // Strings
                    valueString = lines[i];
                    addToListString(ref listString, valueString);
                }
                else                                                 
                {
                    //empty lines
                    //string is nullable
                    listString.Add("NA"); 
                }
            }
            listObject = new List<object>();
            listObject.Add(listInt);
            listObject.Add(listDouble);
            listObject.Add(listChar);
            listObject.Add(listString);
        }

        static void Main(string[] args)
        {
            List<object> myList;
            getData(out myList);

            Console.WriteLine("\nDisplay list content+type:");
            foreach(IList specList in myList)
            {
                Console.WriteLine(specList.GetType().ToString().Substring(41).Split(']')[0]);
                foreach (var elem in specList)
                {
                    Console.WriteLine("\t\t{0}", elem);
                }
                    
            }
            Console.ReadKey();

        }
    }

}
