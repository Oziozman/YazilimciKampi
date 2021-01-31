using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }
    }
}
