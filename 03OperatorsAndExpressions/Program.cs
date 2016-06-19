using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Side: ");
            var side = float.Parse(Console.ReadLine());
        
            Console.WriteLine("Enter Height");
            var height = float.Parse(Console.ReadLine());
        
            Console.WriteLine("Perimeter\t: {0}", 2 * (side + height));
            Console.WriteLine("Area\t\t: {0}", side * height);
        }
    }
}
