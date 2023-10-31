using System.Collections;

namespace BuiltinInterface
{
    public class Student : IComparable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        public int CompareTo(object? obj)
        {
            var that = (Student)obj;
            if (this.Score > that.Score)
            {
                return 1;
            }
            else if (this.Score < that.Score)
            {
                return -1;
            }
            return 0;
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        public List<Student> Sort()
        {
            students.Sort();
            return students;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
