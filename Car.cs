using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2
{
    class Car
    {
        public static Random generator = new Random();

        public int passengers;

        public int contrabandAmount;

        public bool alreadyChecked;
        
        public bool Examine()
        {
            int contraband = 1;

            if (contraband > contrabandAmount) //Detta kontrolerar vilka bilar som har stöldgodids eller inte.
            {
                return true; //ifall contrabrand är större än contraband amount så kommer bilen få gå fritt. 
            }
            else
            {
                return false; 
            }

        }
    }
}
