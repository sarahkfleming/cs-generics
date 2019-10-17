using System.Collections.Generic;

namespace Stores
{
    public class WineShop : IShop<Wine>
    {
        private Dictionary<string, Wine> _inventory = new Dictionary<string, Wine>();
        private double _price = 15.99;

        public void AddProductToSell(string name, double price, Wine wine)
        {
            _inventory.Add(name, wine);
        }

        public Wine Sell(string name, double payment)
        {
            if (payment >= _price)
            {
                return _inventory[name];
            }
            throw new System.Exception("Not enough money");
        }
    }
}