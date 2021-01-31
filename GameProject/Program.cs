using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer = new GamerManager(new UserValidationManager());
            gamer.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Oguzhan", LastName = "Bilgic", IdentityNumber = 12345 });

            
        }
    }
}
