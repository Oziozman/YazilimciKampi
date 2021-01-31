using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class GameSaleManager : IGameSaleService
    {
        public void SatisYap(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "isimli oyuncuya" + " " + game.Name + " " + "oyununu" + " " + campaign.Name + " " + "kapsamında" + " " + campaign.Rate + " " + "oranında" + " " + "satılmiştir." + "\n" + "iyi oyunlar");
        }
    }

    public class Game
    {
    }
}
