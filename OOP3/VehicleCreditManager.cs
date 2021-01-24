using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void DoItSomething()
        {
            throw new NotImplementedException(); 
        }

        public void calculate()
        {
            Console.WriteLine("Vehicle credit payment plan has been calculated");
        }
    }
}
