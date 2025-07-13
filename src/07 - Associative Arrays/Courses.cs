using System;
using System.Collections.Generic;


namespace SoftUniCSharpAssociativeArrays
{
    public class Courses
    {
        static void Main()
        {
            var courses = new Dictionary<string,List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseInformation = input.Split(" : ").ToArray();
                string courseName = courseInformation[0];
                string courseParticipant = courseInformation[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(courseParticipant);

            }
            foreach(var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach(var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
