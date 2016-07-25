using System;

namespace ConditionalStatements {
    public static class ZeroSumSubset {
        public static void Start() {
            Console.WriteLine("Enter five numbers : ");
            int[] numbers = new int[5];
            for (int n = 0;  n < numbers.Length; n++) {
                Console.Write("Number {0} : ", n + 1);
                numbers[n] = int.Parse(Console.ReadLine());
            }

            for (int n = 0; n < numbers.Length; n++) {
                if (numbers[n] == 0) {
                    Console.WriteLine("Solution found: {0}", numbers[n]);
                }
            }

            int i = 0, j = 1, k = 2, l = 3, m = 4;
            Check2(numbers, i, j);
            Check2(numbers, i, k);
            Check2(numbers, i, l);
            Check2(numbers, i, m);
            Check2(numbers, j, k);
            Check2(numbers, j, l);
            Check2(numbers, j, m);
            Check2(numbers, k, l);
            Check2(numbers, k, m);
            Check2(numbers, l, m);          

            Check3(numbers, i, j, k);
            Check3(numbers, i, j, l);
            Check3(numbers, i, j, m);
            Check3(numbers, i, k, l);
            Check3(numbers, i, k, m);
            Check3(numbers, i, l, m);
            Check3(numbers, j, k, l);
            Check3(numbers, j, k, m);
            Check3(numbers, j, l, m);
            Check3(numbers, k, l, m);

            Check4(numbers, i, j, k, l);
            Check4(numbers, i, j, k, m);
            Check4(numbers, i, j, l, m);
            Check4(numbers, i, k, l, m);
            Check4(numbers, j, k, l, m);

            Check5(numbers, i, j, k, l, m);
                        
        }

        private static void Check2(int[] numbers, int i1, int i2) {
            if ((numbers[i1] + numbers[i2]) == 0) {
                Console.WriteLine("Solution found: {0}, {1}", numbers[i1], numbers[i2]);
            }
        }

        private static void Check3(int[] numbers, int i1, int i2, int i3) {
            if ((numbers[i1] + numbers[i2] + numbers[i3]) == 0) {
                Console.WriteLine("Solution found: {0}, {1}, {2}", numbers[i1], numbers[i2], numbers[i3]);
            }
        }

        private static void Check4(int[] numbers, int i1, int i2, int i3, int i4) {
            if ((numbers[i1] + numbers[i2] + numbers[i3] + numbers[i4]) == 0) {
                Console.WriteLine("Solution found: {0}, {1}, {2}, {3}", numbers[i1], numbers[i2], numbers[i3], numbers[i4]);
            }
        }

        private static void Check5(int[] numbers, int i1, int i2, int i3, int i4, int i5) {
            if ((numbers[i1] + numbers[i2] + numbers[i3] + numbers[i4] + numbers[i5]) == 0) {
                Console.WriteLine("Solution found: {0}, {1}, {2}, {3}, {4}", numbers[i1], numbers[i2], numbers[i3], numbers[i4], numbers[i5]);
            }
        }
    }
}