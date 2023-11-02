namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //int number = (int)arrayList[0];

            List<string> list = new List<string>();

            Dictionary<string, string> plates = new Dictionary<string, string>();
            plates.Add("01", "Adana");
            plates.Add("02", "Adıyaman");
            plates.Add("03", "Afyon");
            plates.Add("04", "Ağrı");

            var city = plates["01"];
            Console.WriteLine(city);

            /*
             * FIFO: First in First out
             * LIFO: Last in First Out
             
             */
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("info@vakifkatilim.com.tr");
            queue.Enqueue("testUser@vakifkatilim.com.tr");
            queue.Enqueue("admin@vakifkatilim.com.tr");

            while (queue.Count > 0)
            {
                string mail = queue.Dequeue();
                Console.WriteLine(mail);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            var result1 = divideWithObject(14, 3);
            Console.WriteLine($"bölüm sonucu: {result1.Result}, kalan: {result1.Modula}");

            var result2 = divideWithTuple(14, 3);
            Console.WriteLine($"bölüm sonucu: {result2.Item1}, kalan: {result2.Item2}");

            var tuple = Tuple.Create<int, int, string, byte, char, bool, double, Tuple<int, int>>(1, 2, "", 3, 'a', false, 1.0, Tuple.Create<int, int>(3, 5));



        }


        static int divide(int x, int y)
        {
            return x / y;
        }

        static int divide(int x, int y, out int modula)
        {
            modula = x % y;
            return x / y;
        }

        static DivisionResult divideWithObject(int x, int y) => new DivisionResult
        {
            Modula = x % y,
            Result = x / y
        };

        static Tuple<int, int> divideWithTuple(int x, int y)
        {
            Tuple<int, int> tuple = Tuple.Create(x / y, x % y);
            return tuple;

        }




    }


    public class DivisionResult
    {
        public int Result { get; set; }
        public int Modula { get; set; }
    }
}