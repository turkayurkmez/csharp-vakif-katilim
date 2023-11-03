namespace MemoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(GC.GetTotalMemory(true));
            doIt();
            Console.WriteLine(GC.GetTotalMemory(true));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(true));
            //GC.Collect(1, GCCollectionMode.Forced);
            //Console.WriteLine(GC.GetTotalMemory(true));

        }

        static void doIt()
        {
            var a = new int[1000000];
        }
    }
}