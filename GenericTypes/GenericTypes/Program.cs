namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing:
            //object o = new Random();
            ////unboxing:
            //string value = (string)o;

            setValue(6);
            setValue("naber?");

            PointGeneric<byte> pointGeneric = new PointGeneric<byte>();
            pointGeneric.X = 150;
            pointGeneric.Y = 125;

            Console.WriteLine(pointGeneric);
            pointGeneric.Reset();
            Console.WriteLine(pointGeneric);


        }

        static object setValue(object o)
        {
            Console.WriteLine(o);
            return o;
        }
    }
}