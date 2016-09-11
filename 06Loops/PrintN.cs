using System;

namespace Loops
{
    public static class PrintN
    {
        public static void Start()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
    }
}
