using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    interface IEngine
    {
        void showGPSPosition();
        bool startEngine();
        double drive(double dist);
        void fillTank();

    }
}
