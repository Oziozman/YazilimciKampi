using System;
using TheGameArchitect.Abstract;
using TheGameArchitect.Adapters;
using TheGameArchitect.Entities;

namespace TheGameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
           class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("TheGame Platformuna hoşgeldiniz..\n");

                Console.WriteLine("Oyuncu işlemleri....");
                IPlayer player = new GoldPlayer()
                {
                    Id = 1,
                    FirstName = "Dilek",
                    LastName = "Şen",
                    DateOfBirth = new DateTime(1995, 8, 20),
                    NationalityId = "1111111",
                    AuthorityId = 1
                };

                PlayerManager playerManager = new PlayerManager(new EdevletServiceAdapter());
                playerManager.Add(player);
                playerManager.Update(player);
                playerManager.Delete(player);


                Console.WriteLine("\nKampanya işlemleri....");
                Campaign campaign = new Campaign() { CampaignName = "Yeni Yıl İndirimi", DiscountAmount = 29.99, Id = 1 };
                CampaignManager campaignManager = new CampaignManager();
                campaignManager.Add(campaign);
                campaignManager.Update(campaign);
                campaignManager.Delete(campaign);


                Console.WriteLine("\n\nKampanyasız satış....");

                Game game = new Game()
                {
                    Id = 1,
                    GameName = "Patlat Kazan",
                    GamePoint = 4.9
                };

                ISale sale = new CreditCard()
                {
                    Id = 1,
                    SaleMethodName = "Akbank Kredi Kartı",
                    CardNumber = "1111 2222",
                    Cvv = "322",
                    SaleAmount = 100
                };
                SaleManager saleManager = new SaleManager();
                saleManager.Sell(player, sale, game);

                Console.WriteLine("\n\nKampanyalı satış....");
                saleManager.Sell(player, sale, game, campaign);

                Console.WriteLine("\n\nSistemden çıkış yapıldı.");

            }
        }
    }
}
