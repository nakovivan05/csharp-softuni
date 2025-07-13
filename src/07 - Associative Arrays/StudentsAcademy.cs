using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCSharpAssociativeArrays
{
    public class StudentsAcademy
    {
        static void Main()
        {
            var grades = new Dictionary<string, List<double>>();
            var students = new List<string>();
            int pairOfRows = int.Parse(Console.ReadLine());
            for (int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!grades.ContainsKey(studentName))
                {
                    grades[studentName] = new List<double>();
                    students.Add(studentName);
                }
                grades[studentName].Add(studentGrade);
            }
            foreach(var grade in grades)
            {
                double average = grade.Value.Average();
                if(average >= 4.5)
                {
                    Console.WriteLine($"{grade.Key} -> {average:F2}");
                }
            }
        }
    }
}
