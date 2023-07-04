using System.Security.Cryptography.X509Certificates;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Dictionary <string, Student> students = new Dictionary<string, Student> ();

            for (int i = 0; i < commandsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                Student student = new Student(studentName);

                if(!students.ContainsKey(studentName))
                {
                    students.Add(studentName, student);
                }

                students[studentName].Grades.Add(grade);                
                
            }

            foreach (KeyValuePair<string, Student> kvp in students)
            {   
                if(kvp.Value.Grades.Average() >= 4.50m)
                {
                    Console.WriteLine(kvp.Value);                
                }
            }
        }

    }

    class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public string Name { get; set; }

        public List<decimal> Grades { get; set; }             

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }
}