using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    /// <summary>
    /// VTT...
    /// </summary>
    class ATV : Vehicle
    {
        public ATV(String name) {
            this.name = name;
            this.dailyRate = 30;
            this.available = true;
        }
        public override double giveBack()
        {
            double coast = dailyRate * rentDays;
            available = true;
            rentDays = 0;

            return coast;
        }
    }
}
