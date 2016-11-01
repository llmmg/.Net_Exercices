using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    abstract class Vehicle
    {
        protected int rentDays;
        protected Boolean available;
        protected int dailyRate;
        protected String name;

        public bool isAvailable
        {
            get { return available; }
        }
        public int DailyRate
        {
            get { return dailyRate; }
        }
        public String Name
        {
            get { return name; }
        }

        public virtual void rent()
        {
            rentDays = 0;
            available = false;
        }
        public virtual void ride(double km) {
            //nothing to do for ATV
        }
        public void sleep()
        {
            rentDays++;
        }

        public abstract double giveBack();
        
        //specialise cost/km in childs class (car,boat)
        public virtual void Show()
        {
            Console.WriteLine("\n----"+this.name+"-----");
            Console.WriteLine("Daily cost:"+this.dailyRate);
            Console.WriteLine("available? "+isAvailable);
        }


    }
}
