using System;

namespace ConsoleApplication
{
    public static class NumbersSum {
        public static void Start() {
            Console.Write("Number to calculate : ");
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = 0; i < n; i++) {
                Console.Write("Number {0} : ", i+1);
                int number = int.Parse(Console.ReadLine());
                sum += number;
            } 

            Console.WriteLine("The sum of tne nubmers is {0}", sum);
        }
    } 
}