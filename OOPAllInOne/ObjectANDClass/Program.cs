namespace ObjectANDClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer musteri1 = new Customer();
            musteri1.Name = "Türkay";
            musteri1.Age = 43;

            Customer musteri2 = musteri1;
            musteri2.Name = "Şeyma";

            Console.WriteLine(musteri1.Name);
        }
    }
}