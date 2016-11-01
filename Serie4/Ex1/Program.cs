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
            Time t = new Time(System.DateTime.Now.Hour,System.DateTime.Now.Minute);
            Console.WriteLine("Temps écoulé ce jour: "+t+" minutes");
            Console.WriteLine("Heures écoulées ce jour:" + t + ")");

            Console.ReadKey();
        }
    }
    public struct Time
    {
        private readonly int minutes;
        public readonly int Hours { get { return hours; }  }

        public Time(int h, int m)
        {
            this.minutes = 60 * h + m;
            this.hours = h + m/60;
        }
        public override String ToString()
        {
            return (minutes.ToString());
        }
    }
}
