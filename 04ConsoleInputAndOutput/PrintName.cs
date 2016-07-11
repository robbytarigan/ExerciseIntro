using System;

namespace ConsoleApplication
{
    public static class PrintName
    {
        public static void Start()
        {
            Console.Write("Please enter your first name: ");

            string firstName = Console.ReadLine();



            Console.Write("Please enter your last name: ");

            string lastName = Console.ReadLine();



            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);

        }
    }
}