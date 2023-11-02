namespace OperatorOverloading
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static double operator +(double price, Product p1)
        {
            return p1.Price + price;
        }
        public static double operator -(double price, Product p1)
        {
            return p1.Price - price;
        }

        public static double operator +(Product p1, Product p2)
        {
            return (p1.Price * p1.Quantity) + (p2.Price * p2.Quantity);
        }

        public static double operator -(Product p1, Product p2)
        {
            return (p1.Price * p1.Quantity) - (p2.Price * p2.Quantity);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !p1.Equals(p2);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here

            return Id;
        }

        public override string ToString()
        {
            return $"{Name}\t{Price}\t{Quantity} ";
        }

    }
}
