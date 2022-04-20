﻿using System;
using Academy.TestConsole.Constants;

namespace Academy.TestConsole
{
    internal class Program
    {
        public const string ConsoleName = "Test Console";
        public const int IntConstant1 = 12;
        const bool BoolConstant1 = false;

        static void Main(string[] args)
        {
            string[] test0;
            string[] test1 = new string[0];

            //Console.WriteLine(args[0]);

            string concatArgs2 = string.Join(", ", args);
            string concatArgs2NoSeparatore = string.Concat(args);
            Console.WriteLine(concatArgs2);

            //int, double, decimal, float
            //string
            //bool
            //enum

            var MyStringList2 = new string[] { "wer" , "ert"};
            var MyStringList3 = new string[3] { "wer", "ert", "asd" };

            int length = MyStringList3.Length; //3
            string pos0 = MyStringList3[0]; //"wer"
            string pos1 = MyStringList3[1]; //"ert"
            string pos2 = MyStringList3[2]; //"asd"

            MyStringList3.SetValue("ertertert", 0);
            //MyStringList3.SetValue("ertertert", 5); non si può fare l'indice (5) è maggiore della capienza (3) della array

            string myString3 = null;
            string nullString = null;
            string myString2 = ConsoleName;
            myString3 = "stringa 3";

            var result = myString2 + myString3;
            result = string.Concat("ss", "www");

            //string.IsNullOrEmpty() metodo associato al tipo
            bool isNull = string.IsNullOrEmpty(nullString);

            // isNull.ToString() metodo associato all'istanza
            var boolToString = isNull.ToString();

            //bool hasC = myString3.Contains(nullString);
            int indexA = myString3.IndexOf("a");


            //formattazione e composite string

            string format = "Posizione X {1}, test test Xamarin";
            string resultFormat = format.Replace("X", "NewString");

            format = "Posizione {0} {1:C}, test test {0}{0} {2}";
            resultFormat = string.Format(format, "zero", 12, "X");

            resultFormat = $"Posizione {isNull} {myString3}, test test {234324:C}";

            Console.WriteLine("nullString is null? " + isNull);
            Console.WriteLine(result);
            Console.WriteLine("a is on position " + indexA);

            myString3 = "";

            int a = 12;
            int b = 8;
            var c = (a + b) * a;
            var d = c / a;
            double e = Math.Pow(a, 2);


            string aS = a.ToString(); // 12 => "12"
            // 12 =>  € 12.00
            aS = a.ToString("C");
            aS = a.ToString("C4");
            // 12 => 12.0
            aS = a.ToString("##.0");

            //percencentuale
            aS = a.ToString("P");


            Console.ReadKey();
        }
    }
}
