namespace Encapsulation
{
    public class Product
    {
        private double price;

        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("değer negatif olamaz");
            }
            this.price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;

        //C# 1.0:
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public int Stock { get; private set; }

    }
}
