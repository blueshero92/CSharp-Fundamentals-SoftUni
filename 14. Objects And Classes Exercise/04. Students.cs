namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List <Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                string firstName = command[0];
                string lastName = command[1];
                decimal grade = decimal.Parse(command[2]);

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);

            }

            List<Student> orderedStudentList = new List<Student> (students.OrderByDescending(x => x.Grade));

            Console.WriteLine(string.Join(Environment.NewLine, orderedStudentList));

            
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
}