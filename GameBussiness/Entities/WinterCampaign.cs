using GameBussiness.Concrete;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Entities
{
    public class WinterCampaign : ICampaignService
    {
        public void Add(List<Game> games, Customer customer)
        {
            Console.WriteLine("Kışa Özel indirimler! 1 oyun alana 2. Bedava!!");
            WinterCampaignDiscountManager discountManager = new WinterCampaignDiscountManager();
            discountManager.DoDiscount(games, customer);
        }

        public void Delete(List<Game> games, Customer customer)
        {
            Console.WriteLine("Kışa Özel indirimler sona erdi");
            WinterCampaignDiscountManager discountManager = new WinterCampaignDiscountManager();
            discountManager.NoDiscount(games, customer);
        }

        public void Update(List<Game> games, Customer customer)
        {
            Console.WriteLine("Kışa Özel indirimler! 1 oyun alana 2. Bedava!!+½30 indirim eklendi !!");
            WinterCampaignDiscountManager discountManager = new WinterCampaignDiscountManager();
            discountManager.MoreDiscount(games, customer);
        }
    }
}
