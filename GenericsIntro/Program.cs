using System;
using System.Collections.Generic;

namespace Stores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheese gouda = new Cheese() {
                Name = "gouda",
                AgeInMonths = 42,
                IsVegan = false,
                Country = "Brazil"
            };

            Cheese chao = new Cheese() {
                Name = "chao",
                AgeInMonths = 1,
                IsVegan = true,
                Country = "USofA"
            };

            Cheese cheddar = new Cheese() {
                Name = "cheddar",
                AgeInMonths = 10,
                IsVegan = false,
                Country = "England"
            };

            CheeseShop shop = new CheeseShop();
            shop.AddProductToSell("gouda", 25.99, gouda);
            shop.AddProductToSell("chao", 5.99, chao);
            shop.AddProductToSell("cheddar", 402.98, cheddar);

            Cheese someCheese = shop.Sell("chao", 23.42);

            Console.WriteLine(someCheese.Name);


            Wine merlot = new Wine() {
                Name = "merlot",
                Color = "red",
                AgeInYears = 11,
                AlcoholPercentage = 15.1
            };

            WineShop wineShop = new WineShop();
            wineShop.AddProductToSell("merlot", 1_000_000.99, merlot);
            wineShop.Sell("merlot", 22.00);



            List<string> someStrings = new List<string>();
            List<IShop<Cheese>> ishopList = new List<IShop<Cheese>>();

            Dictionary<string, Cheese> dictOfCheese = 
                new Dictionary<string, Cheese>();
        }
    }
}
