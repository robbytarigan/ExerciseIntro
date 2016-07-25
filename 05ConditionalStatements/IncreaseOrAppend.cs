using System;

namespace ConditionalStatements
{
    public static class IncreaseOrAppend {
        public static void Start() {
            Console.Write("Choose to enter integer (I), double (D), or string (S)): ");

            char c = char.Parse(Console.ReadLine());

            Console.Write("Enter input : ");
            string input = Console.ReadLine();
            Console.Write("Result = ");
            switch (char.ToLowerInvariant(c)) {
                case 'i':
                    int i = int.Parse(input);
                    Console.WriteLine(i + 1);
                    break;
                case 'd':
                    double d = double.Parse(input);
                    Console.WriteLine(d + 1);
                    break;
                case 's':
                    Console.WriteLine(input + "*");
                    break;
                default:
                    Console.WriteLine("not valid!");
                    break; 
            }
        }
    }
}