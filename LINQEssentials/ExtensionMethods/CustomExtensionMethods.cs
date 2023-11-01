namespace ExtensionMethods
{
    public static class CustomExtensionMethods
    {
        public static string ToTitleCase(this string value)
        {
            var splits = value.Split(' ');
            List<string> newWords = new List<string>();
            foreach (var word in splits)
            {
                var newWord = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                newWords.Add(newWord);

            }

            return string.Join(" ", newWords.ToArray());
        }

        public static double GetSquare(this int value) => Math.Pow(value, 2);
        public static double GetPower(this int value, int power) => Math.Pow(value, power);

        public static double GetSquareRoot(this int value) => Math.Sqrt(value);

        public static int GetTotalWorkDays(this DateTime value)
        {
            var totalWorkDays = 0;
            for (DateTime start = new DateTime(value.Year, 1, 1); start <= new DateTime(value.Year, 12, 31); start = start.AddDays(1))
            {
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    totalWorkDays++;
                }
            }

            return totalWorkDays;
        }
    }
}
