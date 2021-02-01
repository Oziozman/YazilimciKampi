using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    public class CampaingManager : ICampaingService
    {
        public Campaign Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");

            return campaign;


        }
        public Campaign Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Guncellendi");

            return campaign;

             
        }
        public void Remove(Campaign campaign) 
        {
            Console.WriteLine("Kampanya Silindi"); 

            


        }

    }
}
