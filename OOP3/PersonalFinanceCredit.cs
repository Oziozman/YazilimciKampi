using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCredit : ICreditManager
    {
        public void DoItSomething()
        {
            throw new NotImplementedException();
        }

        public void calculate()  
        {
            Console.WriteLine("Personal finance credit payment plan has been calculated");
        }
    }
}
