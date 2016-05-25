using System;
// using System.Numerics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // PrintIntegrals();
            PrintReals();                       
        }
        
        private static void PrintIntegrals() 
        {
            ushort a = 52130; 
            sbyte b = -115; 
            uint c = 4825932; 
            byte d = 97; 
            short e = -10000; 
            ushort f = 20000; 
            byte g = 224; 
            int h = 970700000; 
            byte i = 112; 
            sbyte j = -44; 
            int k = -1000000; 
            ushort l = 1990; 
            ulong m = 123456789123456789;
            
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);
            System.Console.WriteLine(g);
            System.Console.WriteLine(h);
            System.Console.WriteLine(i);
            System.Console.WriteLine(j);
            System.Console.WriteLine(k);
            System.Console.WriteLine(l);
            System.Console.WriteLine(m);
        }
        
        private static void PrintReals() 
        {
            float a1 = 5F;
            double a2 = 5;
            decimal a3 = 5;
             
            float b1 = -5.01F;
            double b2 = -5.01;
            decimal b3 = -5.01M;
                         
            double c1 = 34.567839023;
            decimal c2 = 34.567839023M;
             
            float d1 = 12.345F;
            double d2 = 12.345;
            decimal d3 = 12.345M;
             
            double e1 = 8923.1234857;
            decimal e2 = 8923.1234857M;
             
            decimal f = 3456.091124875956542151256683467M; // none as this will also be rounded
            
            // BigRational g = new BigRational(BigInteger.Parse("3456091124875956542151256683467"), BigInteger.Parse("1000000000000000000000000000"));
            
            System.Console.WriteLine("{0}, {1}, {2}", a1, a2, a3);
            System.Console.WriteLine("{0}, {1}, {2}", b1, b2, b3);
            System.Console.WriteLine("{0}, {1}", c1, c2);
            System.Console.WriteLine("{0}, {1}, {2}", d1, d2, d3);
            System.Console.WriteLine("{0}, {1}", e1, e2);
            System.Console.WriteLine(f);
            // System.Console.WriteLine(g);
        }
    }
}
