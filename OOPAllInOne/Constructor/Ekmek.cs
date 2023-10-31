namespace Constructor
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this("Beyaz", 1)
        {
            //Adet = 1;
            //Tur = "Beyaz";
        }

        public Ekmek(int adet) : this("Beyaz", adet)
        {
            //Adet = adet;
        }

        public Ekmek(string tur, int adet)
        {
            Tur = tur;
            Adet = adet;
        }



    }
}
