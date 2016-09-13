using System;

namespace Loops {
    public static class SumOfFormulaA {
        public static void Start() {
            Console.Write("n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x : ");
            int x = int.Parse(Console.ReadLine());

            decimal result = 1;

            for (int i = 1; i <= n; i++) {
                decimal current = 1;
                for (int j = 1; j <= 1; j++) {
                    current *= ((decimal)j/x);
                }                

                result += current;
            }

            Console.WriteLine("Result = {0}", result);
        }
    }
}