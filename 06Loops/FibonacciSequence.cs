using System;

namespace Loops
{
    public static class FibonacciSequence {
        public static void Start()  {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Print the first N Fibonacci numbers: ");
            int  previousNumber = 0, currentNumber = 0, nextNumber = 1;
            for (int i = 1; i <= n; i++) {                
                Console.Write("{0} ", nextNumber);
                previousNumber = currentNumber;
                currentNumber = nextNumber;
                nextNumber = currentNumber + previousNumber;                                
            }

            Console.WriteLine();
        }
    }
}