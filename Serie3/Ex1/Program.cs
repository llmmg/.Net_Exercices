using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        delegate void testDelegate(String s1, String s2, String s3);
        static void testEquals(String s1, String s2, String s3)
        {
            Console.WriteLine("s1.Equals(s1) " + s1.Equals(s1));
            Console.WriteLine("s1.Equals(s2) " + s1.Equals(s2));
            Console.WriteLine("s1.Equals(s3) " + s1.Equals(s3));
            Console.WriteLine("s2.Equals(s3) " + s2.Equals(s3));
            Console.WriteLine("s3.Equals(s2) " + s3.Equals(s2));
            Console.WriteLine("s3.Equals(s3) " + s3.Equals(s3));
        }
        static void testCompareTo(String s1, String s2, String s3)
        {
            Console.WriteLine("s1.CompareTo(s1) " + s1.CompareTo(s1));
            Console.WriteLine("s1.CompareTo(s2) " + s1.CompareTo(s2));
            Console.WriteLine("s1.CompareTo(s3) " + s1.CompareTo(s3));
            Console.WriteLine("s2.CompareTo(s3) " + s2.CompareTo(s3));
            Console.WriteLine("s3.CompareTo(s2) " + s3.CompareTo(s2));
            Console.WriteLine("s3.CompareTo(s3) " + s3.CompareTo(s3));
        }
        static void testReferenceEqual(String s1, String s2, String s3)
        {
            Console.WriteLine("ReferenceEquals(s1,s1) " + ReferenceEquals(s1, s1));
            Console.WriteLine("ReferenceEquals(s1,s2) " + ReferenceEquals(s1, s2));
            Console.WriteLine("ReferenceEquals(s1,s3) " + ReferenceEquals(s1, s3));
            Console.WriteLine("ReferenceEquals(s2,s3) " + ReferenceEquals(s2, s3));
            Console.WriteLine("ReferenceEquals(s3,s2) " + ReferenceEquals(s3, s2));
            Console.WriteLine("ReferenceEquals(s3,s3) " + ReferenceEquals(s3, s3));
        }
        static void executeTests(String s1, String s2, String s3)
        {
            testDelegate testing;

            //Equals tests
            testing = testEquals;
            testing(s1, s2, s3);

            //CompareTo tests
            testing = testCompareTo;
            testing(s1, s2, s3);

            //ReferenceEqual tests
            testing = testReferenceEqual;
            testing(s1, s2, s3);
        }
        static void Main(string[] args)
        {
            String s1 = "Hello World";
            String s2 = "Hello World";
            String s3 = s1;

            executeTests(s1, s2, s3);

            s3 += '!';

            executeTests(s1, s2, s3);

            /*
                Une fois s3 modifier, sa référence sur s1 est perdue
                et donc toutes les comparaisons entre s1|s2 et s3 retournes false.
                De plus, la valeur de s3 ne correspond plus à celle de s1 et s2
             */
            Console.ReadKey();
        }
    }
}
