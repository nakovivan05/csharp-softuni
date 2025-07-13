using System;
using System.Collections.Generic;



namespace SoftUniCSharpAssociativeArrays
{
    public class CompanyUsers
    {
        static void Main()
        {
            var companyEmployees = new Dictionary<string, List<string>>();
            var companyNames = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[]newEmployee = input.Split(" -> ").ToArray();
                string companyName = newEmployee[0];
                string employeeID = newEmployee[1];
                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees[companyName] = new List<string>();
                    companyNames.Add(companyName);
                }
                if (!companyEmployees[companyName].Contains(employeeID))
                {
                    companyEmployees[companyName].Add(employeeID);
                }
            }
            foreach(var company in companyNames)
            {
                Console.WriteLine(company);
                foreach (var employee in companyEmployees[company])
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
