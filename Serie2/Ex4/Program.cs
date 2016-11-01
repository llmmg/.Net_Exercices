
using System;
using System.Text;
using System.IO;

namespace Ex4
{
    class Program
    {
        static void publyData(int[] valuesToStore)
        {
            StreamWriter destinationFile = new StreamWriter("test.txt");

            foreach (var v in valuesToStore)
            {
                destinationFile.WriteLine(v);
            }
            destinationFile.Close();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            
            int position = 0;

            Console.WriteLine("file path: ");
            try
            {
                string filePath = Console.ReadLine();
                StreamReader sr = new StreamReader(filePath, Encoding.ASCII);
                string file = sr.ReadToEnd();
                sr.Close();

                string[] lines = file.Split('\n');
                int[] datas = new int[lines.Length];

                foreach (var v in lines)
                {
                    datas[position] = Convert.ToInt32(v);
                    position++;
                }

                foreach (var sample in datas)
                {
                    Console.WriteLine($"{sample},");
                }

                int[] filteredDatas = new int[datas.Length - 2];

                for (Int16 index = 0; index < (datas.Length - 2); index++)
                {
                    filteredDatas[index] = datas[index] / (datas[index + 1] - datas[index + 2]);
                }

                Console.WriteLine("Result:");

                foreach (var v in filteredDatas)
                {
                    Console.WriteLine($"{v},");
                }

                int[] toRecValues = filteredDatas;

                publyData(toRecValues);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not Found! Incorect file path");
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: division by 0");
                Console.ReadKey();
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("File not Found! Incorect directory path");
                Console.ReadKey();
            }catch(FormatException e)
            {
                Console.WriteLine(e.GetType());
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.ReadKey();
            }

        }
    }
}
