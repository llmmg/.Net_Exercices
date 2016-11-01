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
            Console.WriteLine("Heures écoulées ce jour:(H)" + t.Hours + "==(Min)"+t.Minutes);

            Console.WriteLine("test" + (float)t.Minutes/60);
            
            Console.ReadKey();
        }
    }
    public struct Time
    {
        private readonly int minutes;
        private readonly int hours;
      
        public int Hours { get { return hours; }  }
        public int Minutes { get { return minutes; } }

        public Time(int h, int m)
        {
            this.minutes =m;
            this.hours = h + m/60;
        }
        public override String ToString()
        {
            return (this.hours.ToString("D2")+":"+this.minutes.ToString("D2"));
        }
    }
}
