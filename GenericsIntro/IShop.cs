namespace Stores
{
    public interface IShop<TProduct>
    {
        void AddProductToSell(
            string name, double price, TProduct product);
        TProduct Sell(string name, double payment);
    }
}