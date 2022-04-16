using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface ICampaignService
    {
        void Add(List<Game> games, Customer customer);
        void Update(List<Game> games, Customer customer);
        void Delete(List<Game> games, Customer customer);
    }
}
