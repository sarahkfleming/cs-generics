namespace Stores {
    public class CheeseBasketShop : IShop<Basket<Cheese>>
    {
        public void AddProductToSell(string name, double price, Basket<Cheese> product)
        {
            throw new System.NotImplementedException();
        }

        public Basket<Cheese> Sell(string name, double payment)
        {
            throw new System.NotImplementedException();
        }
    }
}