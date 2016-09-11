using System;

namespace Loops
{
    public static class NotDivisableN {
        public static void Start() {
            Console.Write("Enter N : ");                        
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (i % (3*7) > 0) {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();
        }
    }
}