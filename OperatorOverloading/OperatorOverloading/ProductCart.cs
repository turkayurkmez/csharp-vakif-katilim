namespace OperatorOverloading
{
    public class ProductCart
    {
        private List<Product> products = null;

        public ProductCart()
        {
            //products null ise (??), yeni instance al ve products'a ata:
            this.products ??= new List<Product>();

        }

        public void Add(Product product)
        {
            var existingProduct = products?.Find(p => p.Id == product.Id);
            if (existingProduct is not null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                products?.Add(product);
            }


        }

        public double GetTotal()
        {
            var result = new Product();
            double total = 0;

            //products ??= new List<Product>();
            //var collection = products ?? throw new ArgumentNullException(paramName: nameof(products), message: "products koleksiyonu null olamaz!");
            //alternatif:
            //...
            ArgumentNullException.ThrowIfNull(products);
            //var collection = products;
            //...

            //if (products is not null)
            //{
            foreach (var product in products)
            {
                total += result + product;
            }
            //}



            return total;

        }

        public Product? this[int id]
        {
            get { return products?.FirstOrDefault(p => p.Id == id); }

        }

        public Product? this[string name]
        {
            get { return products.FirstOrDefault(p => p.Name == name); }

        }

        public void ShowAll() => products?.ForEach(p => Console.WriteLine(p));
    }
}
