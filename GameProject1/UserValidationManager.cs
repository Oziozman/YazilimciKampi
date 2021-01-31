using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class program   
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1993,
                FirstName = "OGUZHAN",
                LastName = "BILGIC",
                IdentityNumber = 12345
            });
            Console.WriteLine("Hello World!"); 
        }
    }
}
