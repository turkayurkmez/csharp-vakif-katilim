namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            double priceFromUser = -10;
            //if (priceFromUser>0)
            //{
            //    product.Price = priceFromUser;
            //}

            product.SetPrice(priceFromUser);
            product.Name = "Ray-Ban Gözlük";

            product.Description = "Description";

        }
    }
}