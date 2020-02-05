using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2
{
    class CleanCar:Car
    {
        public CleanCar()
        {
            passengers = generator.Next(1, 3);  //Detta ger oss en random på hur många passagerare som kommer sitta i bilen.

            contrabandAmount = 0;

        }
    }
}
