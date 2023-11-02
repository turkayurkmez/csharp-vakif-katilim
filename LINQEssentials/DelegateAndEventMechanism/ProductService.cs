namespace DelegateAndEventMechanism
{

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductCreatedEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Owner { get; set; }
    }

    public class ProductService
    {
        //public delegate void ProductCreatedEventHandler(object sender, ProductCreatedEventArgs e);

        public event EventHandler<ProductCreatedEventArgs> ProductCreated;
        public void Create(Product product)
        {
            ProductCreatedEventArgs args = new ProductCreatedEventArgs()
            {
                CreatedTime = DateTime.Now,
                Owner = "türkay",
                Product = product
            };

            OnProductCreated(args);
        }

        void OnProductCreated(ProductCreatedEventArgs args)
        {
            if (ProductCreated is not null)
            {
                ProductCreated(this, args);
            }
        }
    }
}
