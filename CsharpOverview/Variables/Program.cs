namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * primitif - ilkel
             * kompleks - karmaşık
             */
            byte smallNumber = 255;

            sbyte negative = -128;


            short maxShort = -32768;

            UInt16 unsignedShort = 65535;

            double pi = 3.14;
            float fPi = 3.14f;
            decimal dPi = 3.14M;

            char letter = 't';
            string word = "Türkay";//C#'a ait
            String word2 = "Türkay";//.NET'e ait!


            bool isError = false;
            bool isSuccess = false;
            do
            {

                try
                {
                    isError = false;
                    Console.WriteLine("Lütfen bir sayı giriniz");
                    int value = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bir sayı daha girin:");
                    int anotherValue = Convert.ToInt32(Console.ReadLine());
                    checked
                    {
                        byte byteValue = (byte)value;
                        byte anotherByte = (byte)anotherValue;
                        Console.WriteLine("Değer: " + byteValue);
                        int divisionResult = byteValue / anotherByte;
                        Console.WriteLine($"Bölüm sonucu: {divisionResult}");
                        Console.WriteLine(string.Format("Bölüm sonucu:{0} ", divisionResult));

                    }
                    isSuccess = true;
                }
                catch (OverflowException)
                {
                    isError = true;
                    Console.WriteLine("Lütfen, byte sınırlarında bir değer girin!");
                }
                catch (FormatException)
                {
                    isError = true;
                    Console.WriteLine("Lütfen sadece sayı giriniz...");
                }
                catch (DivideByZeroException)
                {
                    isError = true;
                    Console.WriteLine("Tam sayılar, 0'a bölünemez.");
                }
                catch (Exception e)
                {
                    isError = true;
                    Console.WriteLine($"Bir hata oluştu. Hata mesajı:{e.Message}");
                }
            } while (!isSuccess);









        }
    }
}