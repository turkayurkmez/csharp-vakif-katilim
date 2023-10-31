namespace Inheritance
{
    public class Yemek
    {
        public Yemek(int sure)
        {
            PismeSuresi = sure;
        }
        public int PismeSuresi { get; set; }
        public List<string> Malzemeler { get; set; }
        public double Price { get; set; }

        public string Ad { get; set; }

        public void Pisir()
        {
            Console.WriteLine(string.Format("{0} yemeği {1} dakikada pişti", Ad, PismeSuresi));
        }

        public virtual void SunumYap()
        {
            Console.WriteLine(string.Format("{0} yemeği yanında pilav ile sunuldu", Ad));
        }

    }

    public class Corba : Yemek
    {
        public Corba() : base(15)
        {

        }
        public bool TereyagOlurMu { get; set; }
        public bool LimonLazim { get; set; }
    }

    public class DomatesCorbasi : Corba
    {
        public bool KasarliMi { get; set; }
    }
    public class SuluYemek : Yemek
    {
        public SuluYemek() : base(30)
        {

        }
        public int SoganMiktari { get; set; }
    }

    public class Kurufasulye : SuluYemek
    {
    }

    public class Tulumba : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine(string.Format("{0} tatlısı yanında dondurma ile sunuldu", Ad));
        }
        public Tulumba() : base(8)
        {

        }

    }

}
