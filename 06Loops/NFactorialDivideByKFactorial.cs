using System;
using System.Numerics;

namespace Loops
{
    public static class NFactorialDivideByKFactorial {
        public static void Start() {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            
            int k = 0;
            do {
                Console.Write("K : ");
                k = int.Parse(Console.ReadLine());
            } while( k <=1 || k >= n);

            var result = new BigInteger(1);
            for (int i = 2; i <=n; i++) {
                result*=i;
            }

            for (int i =2; i <= k; i++) {
                result/=i;
            }

            Console.WriteLine("Result = {0}", result);
        }
    }
}
