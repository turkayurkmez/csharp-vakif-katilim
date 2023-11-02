namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCart productCart = new ProductCart();
            productCart.Add(new Product { Id = 1, Name = null, Price = 100, Quantity = 1 });
            productCart.Add(new Product { Id = 2, Name = "Product B", Price = 150, Quantity = 1 });
            productCart.Add(new Product { Id = 3, Name = "Product C", Price = 300, Quantity = 1 });

            productCart.ShowAll();
            Console.WriteLine(productCart.GetTotal());
            productCart.Add(new Product { Id = 1, Name = "Product A", Price = 100, Quantity = 1 });

            productCart.ShowAll();
            Console.WriteLine(productCart.GetTotal());

            var product = new Product { Id = 1, Name = "Product A", Price = 100, Quantity = 1 };
            var newPrice = 50 + product;
            Console.WriteLine(newPrice);

            Console.WriteLine(productCart[3]);
            Console.WriteLine(productCart["Product B"]);



        }
    }
}