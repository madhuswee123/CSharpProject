using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms for the Fibonacci series: ");
            int terms = int.Parse(Console.ReadLine());

            if (terms <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                long first = 0, second = 1, next;
                Console.WriteLine("Fibonacci Series:");

                for (int i = 1; i <= terms; i++)
                {
                    Console.Write(first + " ");
                    next = first + second;
                    first = second;
                    second = next;
                }
            }
        }
    }
}
