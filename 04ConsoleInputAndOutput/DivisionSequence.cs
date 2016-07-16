using System;
using System.Numerics;

namespace ConsoleApplication
{
    public static class DivisionSequence {
        public static void Start()  {
            float result = 1, sequence = 0;
            bool positive = true;
            int n = 2;

            do {                
                sequence = 1F / n;                
                if (positive) {
                    result += sequence;
                } else {
                    result -= sequence;
                }

                positive = !positive;     
                n++;          
            } while (sequence > 0.001F);

            Console.WriteLine("The result of sequence is {0:N3} after counting up to {1}.", result, n);          
        }
    }
}