using System;

namespace GameProjects
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, BirthYear = 1993, FirstName = "OGUZHAN", LastName = "BILGIC", IdentityNumber = 12345 };
            Gamer gamer2 = new Gamer { Id = 2, BirthYear = 1995, FirstName = "ASLI", LastName = "GUNDOGDU", IdentityNumber = 54321 };


            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer1);

            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager1.Add(gamer2);
            Console.WriteLine("Hello World!");

            CampaingManager campaingManager = new CampaingManager();
            Campaign campaign = new Campaign();
            campaign.Id = 101;
            campaign.Name = "Kış indirimi";
            campaign.Rate = "%20";
            campaign = campaingManager.Add(campaign); 
            
            

            GamerManager gameManager = new GamerManager(new NewEStateUserValidationManager());
            Game game = new Game();
            game.Id = 100;
            game.Name = "Fm2021";
            game.Price = 199;
            gameManager.Add(gamer1);
            

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.SatisYap(game, campaign, gamer1);

            campaign = campaingManager.Update(new Campaign { Id = 101, Name = "Son Firsatlar", Rate = "%15" });
            gameSaleManager.SatisYap(game, campaign, gamer2);

            campaingManager.Remove(campaign);
            


        }
    }

    
}
