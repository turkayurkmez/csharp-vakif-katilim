namespace WhatIsReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type stringType = typeof(string);
            showAllMethodsInType(stringType);
            showAllPropertyInType(stringType);
        }

        private static void showAllPropertyInType(Type type)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"{type.Name} tipinin property'leri");
            type.GetProperties().ToList().ForEach(t => Console.WriteLine($"{t.Name} {t.PropertyType.Name}"));
        }

        private static void showAllMethodsInType(Type type)
        {
            Console.WriteLine("-------------- --------------------");
            Console.WriteLine($"{type.Name} tipinin metotları");
            type.GetMethods().ToList().ForEach(m =>
            {
                Console.WriteLine($"{m.Name} {m.ReturnType.Name} ({string.Join(',', m.GetParameters().Select(p => p.Name))})");
            });

        }
    }
}