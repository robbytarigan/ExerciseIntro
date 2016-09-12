using System;
using System.Numerics;

namespace Loops {
    public static class NTimesKDividedByDifferenceFactorials {
        public static void Start() {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            
            int k = 0;
            do {
                Console.Write("K : ");
                k = int.Parse(Console.ReadLine());
            } while( k <=1 || k >= n);

            var result = new BigInteger(1);

            for (int i = 1; i <= n; i++) {
                result *= i;
            }

            for (int i = 1; i <= k; i++) {
                result *= i;
            }

            for (int i = 1; i <= (n-k); i++) {
                result /= i;
            }

            Console.WriteLine("Result is {0}.", result);
        }

        public static void Start2() {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            
            int k = 0;
            do {
                Console.Write("K : ");
                k = int.Parse(Console.ReadLine());
            } while( k <=1 || k >= n);

            var result = new BigInteger(1);

            var denominator = n - k;

            for (int i = 1; i <= k; i++) {
                result *= i;
            }

            for (int i = denominator + 1; i <= n; i++) {
                result *= i;
            }

            Console.WriteLine("Result is {0}.", result);
            
        }
    }
}