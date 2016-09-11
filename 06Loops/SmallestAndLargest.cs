using System;

namespace Loops
{
    public static class SmallestAndLargest {
        public static void Start() {
            Console.Write("Number of series : ");
            int n = int.Parse(Console.ReadLine());

            int smallest = int.MaxValue, largest = int.MinValue;
            for (int i = 0; i < n; i++) {
                Console.Write("Number {0,4} : ", i+1);
                int c = int.Parse(Console.ReadLine());

                if (c < smallest) {
                    smallest = c;
                }

                if (c > largest) {
                    largest = c;
                }
            }

            Console.WriteLine("The smallest is {0} and the largest is {1}.", smallest, largest);
        }
    }
}