using System;

namespace ConsoleApplication
{
    public static class Remainder {
        public static void Start() {
            Console.Write(" Low limit : ");
            var low = int.Parse(Console.ReadLine());
            Console.Write("High limit : ");
            var high = int.Parse(Console.ReadLine());

            Optimized(low, high);
            // NonOptimized(low, high);
            Console.WriteLine();
        }

        private static void NonOptimized(int low, int high) {
            for (int i = low; i <= high; i++) {
                if ((i % 5 == 5) || (i % 5 == 0)) {
                    Console.Write("{0}, ", i);
                }
            }
        }

        private static void Optimized(int low, int high) {
            int i = low;
            while (i % 5 > 0) {
                i++;
            }

            for (int j = i; j <= high; j+=5) {
                Console.Write("{0}, ", j);
            }
        }
    }
}