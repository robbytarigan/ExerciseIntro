using System;

namespace ConsoleApplication
{
    public static class SumFive {
        public static void Start() {
            Console.WriteLine("Enter five integer numbers : ");

            int[] numbers = new int[5];
            for (int i = 1; i <= 5; i++) {
                int number;
                do {                
                    Console.Write("Number {0} : ", i);
                } while (!int.TryParse(Console.ReadLine(), out number));
                numbers[i-1] = number;
            }

            int sum = 0;
            for (int i = 0; i < 5; i++) {
                sum += numbers[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}