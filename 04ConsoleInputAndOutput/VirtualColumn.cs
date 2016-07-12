using System;

namespace ConsoleApplication
{
    public static class VirtualColumn {
        public static void Start()  {
            Console.Write("            Number one (integer) : ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("  Number two (positive fraction) : ");
            var num2 = float.Parse(Console.ReadLine());
            Console.Write("Number three (negative fraction) : ");
            var num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Formatted numbers are : 0x{0,-8:X}|{1,-10:N2}|{2,-10:N2}", num1, num2, num3);
        }
    }
}