using System.Collections.Generic;

namespace Stores
{
    public class CheeseShop : IShop<Cheese>
    {

        private Dictionary<string, Cheese> _inventory =
            new Dictionary<string, Cheese>();

        private Dictionary<string, double> _prices =
            new Dictionary<string, double>();

        public void AddProductToSell(
            string name, double price, Cheese product)
        {
            _inventory.Add(name, product);
            _prices.Add(name, price);
        }

        public Cheese Sell(string name, double payment)
        {
            double price = _prices[name];
            if (payment >= price)
            {
                return _inventory[name];
            }
            throw new System.Exception("Not enough money!");
        }
    }
}