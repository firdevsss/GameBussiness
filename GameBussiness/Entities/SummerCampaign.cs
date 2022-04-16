using DocumentFormat.OpenXml.Drawing;
using GameBussiness.Concrete;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameBussiness.Entities
{
    public class SummerCampaign : ICampaignService
    {
        public void Add(List<Game> games, Customer customer)
        {
            Console.WriteLine("Yaz'a özel tüm oyunlarda %45 indirim");
            SummerCampaignDiscountManager discountManager = new SummerCampaignDiscountManager();
            discountManager.DoDiscount(games, customer);
        }

        public void Delete(List<Game> games, Customer customer)
        {
            Console.WriteLine("Yaz'a özel indirim sona erdi");
            SummerCampaignDiscountManager noDiscountManager = new SummerCampaignDiscountManager();
            noDiscountManager.NoDiscount(games, customer);
        }

        public void Update(List<Game> games, Customer customer)
        {
            Console.WriteLine("Yaz'a özel ½45 indirime ½5 daha!!");
            SummerCampaignDiscountManager moreDiscountManager = new SummerCampaignDiscountManager();
            moreDiscountManager.MoreDiscount(games, customer);
        }
    }
}
