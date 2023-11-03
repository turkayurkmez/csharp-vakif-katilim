using CustomAttributes;
using System.Reflection;

namespace usingCustomAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var executiveFiles = Directory.GetFiles(@"C:\Users\turka\source\repos\Kurumsal\Vakıf Katılım\CSharp\Attributes\usingCustomAttribute\bin\Debug\net7.0", "*.exe");

            var assembly = Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetTypes())
            {
                developerInfoLog(type);
            }

        }

        private static void developerInfoLog(Type type)
        {
            Console.WriteLine("Yazılımcı bilgileri geliyor....");
            Attribute[] attributes = Attribute.GetCustomAttributes(type);
            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute developerInfoAttribute = (DeveloperInfoAttribute)attribute;
                    Console.WriteLine($"Yazılımcı: {developerInfoAttribute.Name}\nAçıklama:{developerInfoAttribute.Description}");
                }
            }
        }
    }
}