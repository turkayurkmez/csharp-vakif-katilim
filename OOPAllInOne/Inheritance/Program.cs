namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Asci asci = new Asci();
            DomatesCorbasi domatesCorbasi = new DomatesCorbasi { Ad = "Domates Çorbası", PismeSuresi = 15 };
            Kurufasulye kurufasulye = new Kurufasulye { Ad = "Kuru fasulye", PismeSuresi = 30 };
            Tulumba tulumba = new Tulumba { Ad = "Tulumba tatlısı", PismeSuresi = 8 };

            asci.Pisir(domatesCorbasi);
            asci.Pisir(kurufasulye);
            asci.Pisir(tulumba);
        }
    }
}