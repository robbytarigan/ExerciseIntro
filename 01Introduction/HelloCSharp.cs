using System;

class HelloCSharp
{
    static void Main()
    {        
        Console.WriteLine("Enter your current age: ");
        string s = Console.ReadLine();
        int currentAge = int.Parse(s);
        Console.WriteLine("Your age after 10 years: {0}", currentAge + 10);
    }
}
