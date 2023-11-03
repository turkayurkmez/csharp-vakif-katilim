namespace introduceDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            dynamic generator = new Random();
            int value = generator.Next(1, 10);
            Console.WriteLine(value);
            generator = "nasılsın";
            Console.WriteLine(generator.ToUpper());

            var result = getData(5);
            Console.WriteLine(result);


        }

        public dynamic Data { get; set; }

        static dynamic getData(dynamic param)
        {
            return param *= 2;
        }



    }
}