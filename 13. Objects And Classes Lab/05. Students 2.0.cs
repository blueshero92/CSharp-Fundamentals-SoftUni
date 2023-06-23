using System.Security.Cryptography;

namespace _05._Students_2._0
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

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];

                Student newStudent = new Student(firstName, lastName, age, homeTown);

                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                newStudent.Age = age;
                newStudent.HomeTown = homeTown;

                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student == null)
                {
                    students.Add(newStudent);                             
                }
                else
                {
                    student.HomeTown = homeTown;
                    student.Age = age;
                }
                
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
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}