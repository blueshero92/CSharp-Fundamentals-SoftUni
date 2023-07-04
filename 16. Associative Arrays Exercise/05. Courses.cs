using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitted = command.Split(" : ");

                string courseName = splitted[0];
                string studentName = splitted[1];

                Course course = new Course(courseName);

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, course);
                }

                //courses[courseName].Students.Add(studentName);
                courses[courseName].AddStudent(studentName);
                
            }

            foreach (KeyValuePair<string, Course> kvp in courses)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }

    class Course
    {
        public Course(string name)
        {
            Name = name;
            Students = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Students { get; set; }

        public void AddStudent(string studentName)
        {
            Students.Add(studentName);
        }

        public override string ToString()
        {
            string result = $"{Name}: {Students.Count}\n";

            foreach (string student in Students)
            {
                result += $"-- {student}\n";
            }

            return result.Trim();
        }
    }
}