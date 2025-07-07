using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftUniCSharpClassesAndObjects
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
    class Program
    {
        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string input = Console.ReadLine();
                string[] studentInfo = input.Split(' ').ToArray();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student>sortedStudents = students.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

}

