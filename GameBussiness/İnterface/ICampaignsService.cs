using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface ICampaignsService
    {
        void Add(List<Game> games, Customer customer, ICampaignService campaignService);
        void Update(List<Game> games, Customer customer, ICampaignService campaignService);
        void Delete(List<Game> games, Customer customer, ICampaignService campaignService);
    }
}
