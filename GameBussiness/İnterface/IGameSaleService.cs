using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface IGameSaleService
    {
        void GameSales(List<Game> games,Customer customer,ICampaignService campaign);
    }
}
