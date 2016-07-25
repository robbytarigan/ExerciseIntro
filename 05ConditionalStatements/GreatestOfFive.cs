using System;

namespace ConditionalStatements
{
    public static class GreatestOfFive {
        public static void Start() {
            int[] numbers = new int[5];
            
            for (int i =0; i < numbers.Length; i++) {
                Console.Write("Enter number {0} : ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            

            int greatest = numbers[0];
            for (byte i = 1; i <  numbers.Length; i++) {
                if (numbers[i] > greatest) {
                    greatest = numbers[i];
                }
            }

            Console.WriteLine("The greatest number is {0}", greatest);
        }
    }
}