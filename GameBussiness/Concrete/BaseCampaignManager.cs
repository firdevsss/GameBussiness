using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Concrete
{
    public class BaseCampaignManager : ICampaignsService
    {
        public void Add(List<Game> games, Customer customer, ICampaignService campaignService)
        {
            campaignService.Add(games , customer);
        }

        public void Delete(List<Game> games, Customer customer, ICampaignService campaignService)
        {
            campaignService.Update(games, customer);
        }

        public void Update(List<Game> games, Customer customer, ICampaignService campaignService)
        {
            campaignService.Delete(games, customer);
        }
    }
}
