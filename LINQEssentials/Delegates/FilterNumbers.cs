namespace Delegates
{
    public static class FilterNumbers
    {
        //public delegate bool Criteria(int number);


        public static int[] Filter(int[] numbers, Func<int, bool> criteria)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (criteria(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers.ToArray();
        }
    }
}
