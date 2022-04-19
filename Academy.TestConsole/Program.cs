using System;

namespace Academy.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, double, decimal, float
            //string
            //bool
            //enum


            string myString3 = null;
            string nullString = null;
            string myString2 = "test ";
            myString3 = "stringa 3";

            var result = myString2 + myString3;
            result = string.Concat("ss", "www");

            bool isNull = string.IsNullOrEmpty(nullString);

            var boolToString = isNull.ToString();

            //bool hasC = myString3.Contains(nullString);
            int indexA = myString3.IndexOf("a");

            Console.WriteLine("nullString is null? " + isNull);
            Console.WriteLine(result);
            Console.WriteLine("a is on position " + indexA);

            myString3 = "";

            int a = 12;
            int b = 8;
            var c = (a + b) * a;
            var d = c / a;
            var e = Math.Pow(a, 2);
            
            

            Console.ReadKey();
        }
    }
}
