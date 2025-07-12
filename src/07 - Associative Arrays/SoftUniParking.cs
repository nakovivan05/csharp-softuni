using System;
using System.Collections.Generic;


namespace SoftUniCSharpAssociativeArrays
{
    public class SoftUniParking
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var registrations = new Dictionary<string, string>();
            var drivers = new List<string>();
            string input;
            for (int i = 0; i < numberOfCommands; i++)
            {
                input = Console.ReadLine();
                string[] command = input.Split(' ').ToArray();
                string username = command[1];
                if (command[0] == "register")
                {
                    string licensePlateNumber = command[2];
                    if (registrations.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");

                    }
                    else
                    {
                        registrations[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        drivers.Add(username);
                    }
                }
                else if( command[0] == "unregister")
                {
                    if(!registrations.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registrations.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                        drivers.Remove(username);
                    }
                }

            }
            foreach(var d in drivers)
            {
                Console.WriteLine($"{d} => {registrations[d]}");
            }
        }
    }

}
