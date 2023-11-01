namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "barış fırat arslan";
            Console.WriteLine(ad.ToTitleCase());

            int number = 16;
            Console.WriteLine(number.GetSquare());
            Console.WriteLine(number.GetSquareRoot());
            Console.WriteLine(number.GetPower(3));

            DateTime dateTime = new DateTime(2024, 1, 1);
            Console.WriteLine(dateTime.GetTotalWorkDays());




        }
    }
}