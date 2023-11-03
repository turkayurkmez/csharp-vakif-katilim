using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id=1, Name="Türkay Ürkmez", Score=50 },
                new Student { Id=2, Name="Mustafa Keleş", Score=75 },
                new Student { Id=3, Name="Nebiha  Demir", Score=80 },

            };

            //serialize(students);
            //Console.WriteLine("Test");

            List<Student> deserializedStudents = deseralize("students.xml");
            deserializedStudents.ForEach(st => Console.WriteLine(st.Name));
        }

        private static List<Student> deseralize(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using FileStream xmlStream = new FileStream(path, FileMode.Open);
            List<Student> students = (List<Student>)xmlSerializer.Deserialize(xmlStream);
            return students;

        }

        private static void serialize(List<Student> students)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using FileStream fileStream = new FileStream("students.xml", FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, students);

        }
    }
}