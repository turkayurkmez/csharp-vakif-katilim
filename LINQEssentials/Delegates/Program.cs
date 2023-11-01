namespace Delegates
{
    internal class Program
    {

        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //.NET 1.1 
            var evenResult = FilterNumbers.Filter(numbers, evenNumbers);
            show(evenResult);

            //.NET 2.0:
            var oddResult = FilterNumbers.Filter(numbers, delegate (int number) { return number % 2 == 1; });
            show(oddResult);
            //.NET 3.5
            var smallThanFive = FilterNumbers.Filter(numbers, number => number < 5);
            show(smallThanFive);
            //.NET 4.0

            alternativeShow(smallThanFive);

        }

        private static void alternativeShow(int[] smallThanFive)
        {
            smallThanFive.ToList()
                         .ForEach(n => Console.Write(n + "-"));
        }

        static bool evenNumbers(int number)
        {
            return number % 2 == 0;
        }



        private static void show(int[] result)
        {
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}