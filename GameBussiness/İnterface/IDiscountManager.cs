using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface IDiscountManager
    {
        void DoDiscount(List<Game> games, Customer customer);
        void NoDiscount(List<Game> games, Customer customer);
        void MoreDiscount(List<Game> games, Customer customer);
    }
}
