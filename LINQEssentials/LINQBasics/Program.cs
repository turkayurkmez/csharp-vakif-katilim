namespace LINQBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * LINQ: Language INtegrated Query
             */
            var customers = new List<Customer>
            {
                new Customer{ Id=1, Name="Öznur", LastName="Karaburun", Age=26},
                new Customer{ Id=2, Name="Türkay", LastName="Ürkmez", Age=43},
                new Customer{ Id=3, Name="Şeyma", LastName="Yıldız", Age=28},
                new Customer{ Id=4, Name="Ali", LastName="Akat", Age=30}
            };

            //var number = 5.3M;

            var customersStartWithA = from customer in customers
                                      where customer.Age < 30
                                      orderby customer.Age
                                      select new { AdSoyad = customer.Name + " " + customer.LastName, Yas = customer.Age };




            var customersForAge = customers.Where(customer => customer.Age < 30)
                                           .Select(customer => new { AdSoyad = customer.Name + " " + customer.LastName, Yas = customer.Age })
                                           .OrderByDescending(cust => cust.Yas)
                                           .ToList();

            customersForAge.ForEach(customer => Console.WriteLine(string.Format("{0}, {1} yaşında.", customer.AdSoyad, customer.Yas)));
            Console.WriteLine();

        }
    }
}