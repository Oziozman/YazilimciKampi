using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    interface ICampaingService
    {
          Campaign Add(Campaign campaign);
    }

    public class Campaign
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Rate { get; internal set; }
    }
}
