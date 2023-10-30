namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] cities = { "Ankara", "Bursa", "Bayburt", "Yozgat" };
            List<string> cities = new List<string>() { "Ankara", "Bursa", "Bayburt", "Yozgat" };

            //string[] sehirler = new string[4];

            Console.WriteLine("Aradığınız şehri giriniz");
            string searchingCity = Console.ReadLine();

            // bool isFinded = false;
            int index = findCityInCollection(cities, searchingCity);
            bool isFinded = isCityExistInCollection(cities, searchingCity);


            string state = isFinded ? "var" : "yok";
            Console.WriteLine($"{searchingCity} listede {state}. Index değeri: {index}");


            //if (isFinded)
            //{
            //    Console.WriteLine($"{searchingCity} listede var");
            //}
            //else
            //{
            //    Console.WriteLine($"{searchingCity} listede yok");
            //}




        }


        static bool isCityExistInCollection(List<string> cities, string searchingCity)
        {
            bool isFinded = false;
            foreach (var city in cities)
            {
                if (searchingCity == city)
                {
                    isFinded = true;
                    break;
                }
            }

            return isFinded;
        }

        static int findCityInCollection(List<string> cities, string searchingCity)
        {
            bool isFinded = false;
            int index = 0;
            for (int i = 0; i < cities.Count; i++)
            {
                if (searchingCity == cities[i])
                {
                    isFinded = true;
                    index = i;
                    break;
                }
            }
            return index;
        }


    }
}