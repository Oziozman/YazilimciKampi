using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameSimulation.Abstract
{
    class SaleManager
    {
        public void Sell(IPlayer player, ISale sale, Game game)
        {
            Console.WriteLine("Sayın " + player.FirstName + " " + player.LastName + ", sepetinizde bulunan " +
                game.GameName + " ürünü için " +
                sale.SaleMethodName + " yöntemiyle " + sale.SaleAmount + "TL tutarında alışverişiniz tamamlanmıştır.");
        }

        public void Sell(IPlayer player, ISale sale, Game game, Campaign campaign)
        {
            Console.WriteLine("Sayın " + player.FirstName + " " + player.LastName + ", sepetinizde bulunan " +
                game.GameName + " ürünü için " +
                sale.SaleMethodName + " yöntemiyle " + sale.SaleAmount + "TL tutarında alışverişiniz tamamlanmıştır.\t" +
                campaign.CampaignName + " kampanyasından faydalandınız."
                );
        }
    }
}
