using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teamMembers = new List<string>();

            // Taking input from user
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter the name of team member {i + 1}: ");
                teamMembers.Add(Console.ReadLine());
            }

            Console.WriteLine("\nTeam Members:");
            foreach (string member in teamMembers)
            {
                Console.WriteLine(member);
               // Console.ReadLine();
            }
            // Finding the longest name
            string longestName = teamMembers.OrderByDescending(name => name.Length).FirstOrDefault();
            Console.WriteLine($"\nThe longest name in the team is: {longestName}");
        }
    }
}
