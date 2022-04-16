using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Concrete
{
    public class SummerCampaignDiscountManager : IDiscountManager
    {
        int ListNumber = 1;
        int SelectedItem;
        string IsApproved;
        public void DoDiscount(List<Game> games, Customer customer)
        {
            foreach (Game _game in games)
            {
                double discountedPrice = (_game.Price) - ((_game.Price * 30) / 100);
                discountedPrice = (double)System.Math.Round(discountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.GameName + " --> " + _game.Price + "$  YERİNE SADECE "
                    + "--> " + discountedPrice + "$");
                ListNumber++;

            }

            Console.WriteLine("\n SATIN ALMAK İSTEDİĞİNİZ OYUNUN NUMARASINI GİRİNİZ !");
            SelectedItem = Convert.ToInt32(Console.ReadLine());

            double discountedPriceInSale = (games[SelectedItem - 1].Price) - ((games[SelectedItem - 1].Price * 30) / 100);
            discountedPriceInSale = (double)System.Math.Round(discountedPriceInSale, 2);

            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].GameName);
            Console.WriteLine("Ödenecek tutar : " + discountedPriceInSale + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    customer.Balance = customer.Balance - discountedPriceInSale;
                    Console.WriteLine("-------Kalan Bakiye :" + customer.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }



        }

        public void MoreDiscount(List<Game> games, Customer customer)
        {
            foreach (Game _game in games)
            {
                double discountedPrice = (_game.Price) - ((_game.Price * 30) / 100);
                double newDiscountedPrice = discountedPrice - ((discountedPrice * 10) / 100);
                newDiscountedPrice = (double)System.Math.Round(newDiscountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.GameName + " --> " + _game.Price + "$  YERİNE SADECE "
                    + "--> " + newDiscountedPrice + "$");
                ListNumber++;
            }
            Console.WriteLine("\n SATIN ALMAK İSTEDİĞİNİZ OYUNUN NUMARASINI GİRİNİZ!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());

            double discountedPriceInSale = (games[SelectedItem - 1].Price) - ((games[SelectedItem - 1].Price * 30) / 100);
            double newDiscountedPriceInSale = (discountedPriceInSale - ((discountedPriceInSale * 10) / 100));
            newDiscountedPriceInSale = (double)System.Math.Round(newDiscountedPriceInSale, 2);

            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].GameName);
            Console.WriteLine("Ödenecek tutar : " + newDiscountedPriceInSale + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    customer.Balance = customer.Balance - newDiscountedPriceInSale;
                    Console.WriteLine("-------Kalan Bakiye :" + customer.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }
        }

        public void NoDiscount(List<Game> games, Customer customer)
        {
            int i = 1;
            foreach (Game _game in games)
            {
                Console.WriteLine(i + " - " + _game.GameName + " --> " + _game.Price + "$");
                i++;
            }
            Console.WriteLine("\n SATIN ALMAK İSTEDİĞİNİZ OYUNUN NUMARASINI GİRİNİZ!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].GameName);
            Console.WriteLine("Ödenecek tutar : " + games[SelectedItem - 1].Price + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    customer.Balance = customer.Balance - games[SelectedItem - 1].Price;
                    Console.WriteLine("-------Kalan Bakiye :" + customer.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }
        }
    }
}
