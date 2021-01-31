using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    interface IGameSaleService
    {
        void SatisYap(Game game, Campaign campaign, Gamer gamer); 
    }
}
