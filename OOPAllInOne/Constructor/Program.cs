namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Ekmek ekmek = new Ekmek("Kepek", 2);
            Ekmek trabzon = new Ekmek { Adet = 2, Tur = "Trabzon Ekmeği" };
        }
    }
}