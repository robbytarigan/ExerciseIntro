using System;

namespace ConsoleApplication
{
    public static class GreatestOfFive {
        public static void Start()  {
            Console.WriteLine("Enter five numbers : ");

            float[] numbers = new float[5];
            for (int i = 1; i <= 5; i++) {
                float number;
                do {                
                    Console.Write("Number {0} : ", i);
                } while (!float.TryParse(Console.ReadLine(), out number));
                numbers[i-1] = number;
            }

            float greatest = numbers[0];
            for (int i =1; i< 5; i++) {
                if (numbers[i] > greatest) {
                    greatest = numbers[i];
                }
            }

            Console.WriteLine("The greatest number of them is {0}.", greatest);
        }
    }
}