using System;

namespace ConsoleApplication
{
    public static class Greater {
        public static void Start() {
            Console.Write("Number 1 : ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2 : ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Solution 1 : {0}", num1 > num2 ? num1 : num2);
            Console.WriteLine("Solution 2 : {0}", Math.Max(num1, num2));
            Console.WriteLine("Solution 3 : {0}", (num1 + num2 + Math.Abs(num1-num2))/2);
            Console.WriteLine("Solution 4 : {0}", num1 - ((num1 - num2) & ((num1 - num2) >> 31)));
        }
    }
}