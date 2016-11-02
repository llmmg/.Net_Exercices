using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Time t = new Time(System.DateTime.Now.Hour, System.DateTime.Now.Minute);
            Console.WriteLine("Temps écoulé ce jour: " + t + " minutes");
            Console.WriteLine("Heures écoulées ce jour:(H)" + t.Hours + "==(Min)" + t.Minutes);

            Console.WriteLine("test" + (float)t.Minutes / 60);
            Console.WriteLine("test" + 180 % 60+" and "+180/60);

            Time t2 = new Time(12, 3);
            bool b1 = (t == t2);
            bool b2 = (t != t2);
            Console.WriteLine("Is t==t2? " + b1 + " and is t!=t2? " + b2);
            */

            Time t1 = new Time(8, 25);
            Time t2 = 180; //3h
            int m1 = (int)t1;
            Console.WriteLine($"t1={t1} \nand t2={t2} \nand m1={m1}");
            Time t3 = t1 + 45;

            Console.ReadKey();
        }
    }
    public struct Time
    {
        private readonly int minutes;
        private readonly int hours;

        public int Hours { get { return hours; } }
        public int Minutes { get { return minutes; } }

        public Time(int h, int m)
        {
            this.minutes = m;
            this.hours = h + m / 60;
        }
        public override String ToString()
        {
            return (this.hours.ToString("D2") + ":" + this.minutes.ToString("D2"));
        }

        //Operators overload
        public static Boolean operator== (Time t1, Time t2)
        {
            if (t1.hours == t2.hours && t1.minutes == t2.minutes)
                return true;
            return false;
        }
        public static Boolean operator!= (Time t1, Time t2)
        {
            if (t1.hours == t2.hours && t1.minutes == t2.minutes)
                return false;
            return true;
        }

        //Convertion operators
        //int to Time
        public static implicit operator Time(int minutes)
        {
            int hours = 0;
            int min = 0;
            if (minutes > 59)
            {
                hours = minutes / 60;
                min = minutes % 60;
            }else
            {
                hours = 0;
                min = minutes;
            }
            return new Time(hours, min);
        }
        public static implicit operator int(Time t)
        {
            int min = t.hours*60;
            min += t.minutes;

            return min;
        }
    }
}
