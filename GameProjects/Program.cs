using System;

namespace GameProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1993, FirstName = "OGUZHAN", LastName = "BILGIC", IdentityNumber = 12345 });

            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager1.Add(new Gamer { Id = 2, BirthYear = 1995, FirstName = "ASLI", LastName = "GUNDOGDU", IdentityNumber = 54321 });
            Console.WriteLine("Hello World!");

            CampaingManager campaingManager = new CampaingManager();
            Campaign campaign = new Campaign();
            campaign.Id = 101;
            campaign.Name = "Kış indirimi";
            campaign.Rate = "%20";
            campaignManager.Add(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game();
            game.Id = 100;
            game.Name = "Fm2021";
            game.Price = 199;
            gameManager.Add(game);
            Console.ReadLine();

            GameSaleMangaer gameSaleMangaer = new GameSaleMangaer();
            gameSaleMangaer.SatisYap(game, campaign, player);
        }
    }
}
