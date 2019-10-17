using System.Collections.Generic;
using System;

namespace Stores {
    public class WhatShop : IShop<IShop<List<DateTime>>>
    {
        public void AddProductToSell(string name, double price, IShop<List<DateTime>> product)
        {
            throw new System.NotImplementedException();
        }

        public IShop<List<DateTime>> Sell(string name, double payment)
        {
            throw new System.NotImplementedException();
        }
    }
}