namespace BuiltinInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Id = 1, Name = "Türkay", Score = 58 };
            Student student1 = new Student() { Id = 2, Name = "Kübra", Score = 88 };
            Student student2 = new Student() { Id = 3, Name = "Onur", Score = 75 };

            ClassRoom classRoom = new ClassRoom();
            classRoom.Add(student);
            classRoom.Add(student1);
            classRoom.Add(student2);

            classRoom.Sort();

            foreach (var stu in classRoom)
            {
                Console.WriteLine($"{stu.Name}\t{stu.Id}\t{stu.Score}");

            }






        }
    }
}