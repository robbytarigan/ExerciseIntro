using System;

namespace Loops {
    public static class MatrixOfNumbers {
        public static void Start() {
            byte n = 0;
            do {
                Console.Write("Enter n < 20 : ");
                n = byte.Parse(Console.ReadLine());
            } while (n >= 20);

            for (byte i = 1; i <= n; i++) {
                for (byte j = i; j < n + i; j++) {
                    Console.Write("{0,2} ", j);
                }
                Console.WriteLine();                
            }
        }
    }
}