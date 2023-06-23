using System.Security.Cryptography;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();

                Student student = new Student();

                student.FirstName = data[0];
                student.LastName = data[1];
                student.Age = int.Parse(data[2]);
                student.HomeTown = data[3];

                students.Add(student);
            }

            string cityNameToPrint = Console.ReadLine();

            foreach (Student student in students)
            {
                if (cityNameToPrint == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set;}
    }
}