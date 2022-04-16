using GameBussiness.Adapters;
using GameBussiness.Concrete;
using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.IdentitiyId = "12345678909";
            customer1.FirstName = "Firdevs";
            customer1.LastName = "İnal";
            customer1.DateOfBirth = new DateTime(2004, 11, 09);

            Customer customer2 = new Customer();
            customer2.IdentitiyId = "098642822122";
            customer2.FirstName = "Hamza";
            customer2.LastName = "Bay";
            customer2.DateOfBirth = new DateTime(2001, 09, 15);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "assassin's creed";
            game1.Price = 350;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Witcher3: Wild Hunt";
            game2.Price = 250;

            Game game3 = new Game();
            game3.Id = 3;
            game3.GameName = "Dark Souls";
            game3.Price = 600;

            Game game4 = new Game();
            game4.Id = 4;
            game4.GameName = "Elden Ring";
            game4.Price = 500 ;

            Game game5 = new Game();
            game5.Id = 5;
            game5.GameName = "Skyrim";
            game5.Price = 400;

            List<Game> games = new List<Game> { game1, game2, game3, game4, game5 };
            ICampaignService summerCampaign = new SummerCampaign();
            ICampaignService winterCampaign = new WinterCampaign();

            BaseGameManager gameManager = new BaseGameManager();
            gameManager.GameSales(games, customer1, summerCampaign);

        }
    }
}
