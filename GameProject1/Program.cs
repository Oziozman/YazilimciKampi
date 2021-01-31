using System;


namespace GameProject1
{
    internal class Program
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
        }
    }

    internal class NewEStateUserValidationManager
    {
        public NewEStateUserValidationManager()
        {
        }
    }
}
