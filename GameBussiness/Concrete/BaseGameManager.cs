using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Concrete
{
    public class BaseGameManager : IGameSaleService
    {
        public void GameSales(List<Game> games, Customer customer, ICampaignService campaign)
        {
            campaign.Add(games, customer);
            //campaign.Update(games, customer);
            //campaign.Delete(games, customer);
        }
    }
}
