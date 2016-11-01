using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Boat : Vehicle, IEngine
    {
        private double consumption;
        private double tankCapacity;
        private double tankLevel;//in percent [0-100]
        private double kilometerCoast;
        private double kmTraveled;

        public Boat(String name, double consumption, double tanklevel)
        {
            this.name = name;
            this.consumption = consumption;
            this.tankLevel=tanklevel;

            this.available = true;
            this.dailyRate = 500;
            this.kilometerCoast = 2.50;
            this.kmTraveled = 0;
            this.tankCapacity = 500;
        }
        public override double giveBack()
        {
            double coast = rentDays * dailyRate + kilometerCoast * kmTraveled;

            this.available = true;
            this.rentDays = 0;
            return coast;
        }
        public override void ride(double km)
        {
            this.kmTraveled += km;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Cost per kilometers: " + this.kilometerCoast);
        }
        public override void rent()
        {
            base.rent();
            this.kmTraveled = 0;
        }

        public void showGPSPosition()
        {
            Console.WriteLine("pas de signal, PERDU!");
        }

        public bool startEngine()
        {
            if (this.tankLevel >= 0)
                return true;

            return false;
        }

        public double drive(double dist)
        {
            //equals 1%
            double unit = 1 / tankCapacity;

            //because tanklevel is in %, it's needed to convert the capacity
            //consumed(Liters) in percent of the tankCapacity 

            this.tankLevel -= 100*unit*(dist * this.consumption/100);
            this.kmTraveled += dist;

            //Console.WriteLine("there's: " + this.tankLevel + "% left");

            return dist;
        }

        public void fillTank()
        {
            this.tankLevel = 100;
        }
    }
}
