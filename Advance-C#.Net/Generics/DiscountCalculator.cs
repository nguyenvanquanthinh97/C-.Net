namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscound(TProduct product)
        {
            return product.Price;
        }
    }
}