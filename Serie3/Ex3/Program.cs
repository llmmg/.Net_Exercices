using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        public static void doUse(Vehicle vehicle)
        {
            vehicle.rent();
            vehicle.ride(30);
            vehicle.sleep();
            vehicle.ride(30);

            vehicle.sleep();
        }
        static void Main(string[] args)
        {

            Vehicle[] park= {
                new ATV("Scott"),
                new Boat("Zodiac",5,100),
                new Car("Catheram super seven",10,90),
                new Car("Chevrollet camaro",20,95),
                new Boat("Beneteau",1,20)};

            doUse(park[0]);

            park[0].sleep();
            park[0].sleep();

            doUse(park[1]);
            doUse(park[2]);
            doUse(park[3]);
            doUse(park[4]);

            foreach (Vehicle b in park)
            {
                b.Show();
            }

            foreach(Vehicle v in park)
            {
                Console.WriteLine("Give back of " + v.Name + " Coast=" + v.giveBack());
            }

            Console.WriteLine("\n Boats:");

            foreach (Vehicle v in park)
            {
                if (v is Boat)
                    v.Show();
            }

            //----------PART B------------

            Console.WriteLine("\n---------------PART B--------------\n");

            Vehicle[] parc2 = { new ATV("Scott Downhil King"),
                                new Boat("Zodiac T1000",55,100),
                                new Car("Audi R8",20,100),
                                new Boat("Yacht MK III",6,100)
            };

            parc2[0].rent();
            parc2[1].rent();
            parc2[2].rent();
            parc2[3].rent();

            /*Boat boat = parc2[1] as Boat;
            boat.drive(30);
            Car c = parc2[3] as Car;
            c.drive(60);*/

            foreach(Vehicle v in parc2)
            {
                if(v is IEngine)
                {
                    v.Show();
                    double dist=0;
                    while (((IEngine)v).startEngine())
                    {                      
                        dist+=((IEngine)v).drive(1);
                    }
                    Console.WriteLine(dist+" km done before you run out of fuel");
                    ((IEngine)v).fillTank();
                    Console.WriteLine("total rent coast="+v.giveBack());
                }
            }

           

            //double conso = parc2[1].drive(234);
                        
            Console.ReadKey();
        }
    }
}
