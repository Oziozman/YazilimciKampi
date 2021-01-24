using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCredit : ICreditManager
    {
        public void DoItSomething() 
        {
            throw new NotImplementedException();
        }

        public void calculate()
        {
            Console.WriteLine("Mortgage payment plan has been calculated");
        }
    }
}
