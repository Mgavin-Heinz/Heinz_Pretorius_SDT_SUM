using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LusukamaSelamani
{
    public class ConsoleApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the structure of a C# Application demo!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine("Program structure demonstrated: ");
            Console.WriteLine("1. using System : imports functionality");
            Console.WriteLine("2. namespace : organize code");
            Console.WriteLine("3. class Program : container for code");
            Console.WriteLine("4. Main() : entry point of program");
            Console.WriteLine("5. Comments : explain logic and documentation");

            Console.WriteLine();
            Console.WriteLine("Program Executed successfully!");

        }
    }
}
