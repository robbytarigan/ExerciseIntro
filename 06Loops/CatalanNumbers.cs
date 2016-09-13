using System;
using System.Numerics;

namespace Loops {
    public static class CatalanNumbers {
        public static void Start() {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());

            BigInteger result = new BigInteger(1);

            for (int i = 1; i <= 2 * n; i++) {
                result *= i;
            }

            for (int i = 1; i <= n; i++) {
                result /= (i*i);
            }

            result /= (n+1);

            Console.WriteLine("Result = {0}", result);
        }        
    }
}