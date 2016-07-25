using System;

namespace ConditionalStatements {
    public static class ObjectEquals {
        public static void Start() {
            string str = "beer";

            string anotherStr = str;

            string thirdStr = "be" + "e" + "r";

            Console.WriteLine("str = {0}", str);

            Console.WriteLine("anotherStr = {0}", anotherStr);

            Console.WriteLine("thirdStr = {0}", thirdStr);

            Console.WriteLine(str == anotherStr); // True - same object

            Console.WriteLine(str == thirdStr); // True - equal objects

            Console.WriteLine((object)str == (object)anotherStr); // True

            Console.WriteLine((object)str == (object)thirdStr); // False
        }
    }
}