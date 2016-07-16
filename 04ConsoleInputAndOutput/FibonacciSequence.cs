using System;
using System.Numerics;

namespace ConsoleApplication
{
    public static class FibonacciSequence {
        public static void Start() {
            Console.Write("0, 1");
            BigInteger prevNumber = 0, currentNumber = 1, nextNumber = 0;
            byte count = 2;

            do {
                nextNumber = prevNumber + currentNumber;
                prevNumber = currentNumber;
                currentNumber = nextNumber;
                Console.Write(", {0}", currentNumber);
            } while (count++ < 100);
            
            Console.WriteLine();
        }
    }
}