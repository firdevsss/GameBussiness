using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Concrete
{
    public class WinterCampaignDiscountManager : IDiscountManager
    {
        int ListNumber = 1;
        int SelectedItem, SelectedItem1, SelectedItem2;
        string IsApproved;


        public void DoDiscount(List<Game> games, Customer customer)
        {
            foreach (Game _game in games)
            {
                Console.WriteLine(ListNumber +" /---/"+ _game.GameName+"/---/"+ _game.Price+"$");
                ListNumber++;
            }
            Console.WriteLine("SATIN ALINACAK 1. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            double priceOfGame1 = games[SelectedItem - 1].Price;

            Console.WriteLine("SATIN ALINACAK 2. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem1 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame2 = games[SelectedItem2 - 1].Price;

            Console.WriteLine("SATIN ALINACAK 3. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem2 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame3 = games[SelectedItem2 - 1].Price;

            double totalPrice = priceOfGame1 + priceOfGame2 + priceOfGame3;

            IsApproved = Console.ReadLine();
            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyunlar satın alındı. Kütüphaneye göz atabilirsin! \n");
                    customer.Balance = customer.Balance - totalPrice;
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
                double discountedPrice = (_game.Price) - ((_game.Price * 10) / 100);
                discountedPrice = (double)System.Math.Round(discountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.GameName + " --> " + _game.Price + "$  YERİNE SADECE "
                    + "--> " + discountedPrice + "$");
                ListNumber++;
            }
            Console.WriteLine("SATIN ALINACAK 1. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            double priceOfGame1 = games[SelectedItem - 1].Price;

            Console.WriteLine("SATIN ALINACAK 2. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem1 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame2 = games[SelectedItem2 - 1].Price;

            Console.WriteLine("SATIN ALINACAK 3. OYUNUN NUMARASINI SEÇİNİZ!");
            SelectedItem2 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame3 = games[SelectedItem2 - 1].Price;

            double totalPrice = priceOfGame1 + priceOfGame2 + priceOfGame3;


            Console.WriteLine("Seçtiğiniz oyunlar : " + games[SelectedItem - 1].GameName + " , " + games[SelectedItem1 - 1].GameName + " ve " + games[SelectedItem2 - 1].GameName);
            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + "$  Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");

            IsApproved = Console.ReadLine();
            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyunlar satın alındı. Kütüphaneye göz atabilirsin! \n");
                    customer.Balance = customer.Balance - totalPrice;
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
            foreach (Game _game in games)
            {
                Console.WriteLine(ListNumber + " - " + _game.GameName + " --> " + _game.Price + "$");
                ListNumber++;
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
