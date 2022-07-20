using System;
using System.Linq;

namespace FirstRequirement
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = new ConsoleWrapper();
            string firstName = ReadName("First Name:", c);
            string lastName = ReadName("Last Name:", c);
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(firstName + " " + lastName);
                else if (i % 3 == 0)
                    Console.WriteLine(firstName);
                else if (i % 5 == 0)
                    Console.WriteLine(lastName);
                else
                    Console.WriteLine(i);
            }
        }

        public static string ReadName(string message, IConsole cons)
        {
            cons.WriteLine(message);
            string name = cons.ReadLine();

            while (string.IsNullOrWhiteSpace(name) || name.All(char.IsDigit) || !name.All(char.IsLetter))
            {
                cons.WriteLine("Invalid value!");
                cons.WriteLine(message);
                name = cons.ReadLine();
            }

            return name;
        }
    }
}
