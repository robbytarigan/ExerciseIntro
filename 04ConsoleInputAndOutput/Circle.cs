using System;

namespace ConsoleApplication {
    public static class Circle {
        public static void Start() {
            Console.Write("Enter circle radius : ");
            var r = float.Parse(Console.ReadLine());

            Console.WriteLine("Circumference = {0,10:N2}", 2 * Math.PI * r);
            Console.WriteLine("         Area = {0,10:N2}", Math.PI * r * r);
        }
    }
}