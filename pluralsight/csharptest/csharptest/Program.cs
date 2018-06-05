using System;
using System.Collections.Generic;

namespace csharptest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string[] array = {
            //"civic",
            //"deified",
            //"deleveled",
            //"devoved",
            //"dewed",
            //"Hannah",
            //"kayak",
            //"level",
            //"madam",
            //"racecar",
            //"radar",
            //"redder",
            //"refer",
            //"repaper",
            //"reviver",
            //"rotator",
            //"rotor",
            //"sagas",
            //"solos",
            //"sexes",
            //"stats",
            //"tenet",

            //"Dot",
            //"Net",
            //"Perls",
            //"Is",
            //"Not",
            //"A",
            //"Palindrome",
            //"" };

            //foreach (string element in array){
            //    Console.WriteLine("{0} = {1} ", element, palindrome(element));
            //}

            //nonRepeatedCharacter("Terrafict");
            //Console.WriteLine(factorial(5));
            //fibHardcoded(5);
            Console.WriteLine(fibonnaci(6));       
        }

        public static int factorial(int n)
        {
            if (n == 1) return n;
            else
            {
                return n * factorial(n - 1);
            }
        }

        public static void fibHardcoded(int n)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.Write(a + " " + b);

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;

            }
        }

        public static int fibonnaci(int n)
        {
            if (n == 0){
                return 0;
            }
            else if (n ==1){
                return 1;
            }
            else{
                return fibonnaci(n - 1) + fibonnaci(n - 2);
            }
        }


        public static int[] reverseIntArray(int[] input)
        {
            int[] newArray = new int[input.Length];
            int index = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                newArray[index] += input[i];
                Console.WriteLine("Index: " + index + " " + newArray[index]);
                index++;
            }
            return newArray;
        }

        public static string[] reverseStringArray(string[] input)
        {
            string[] newArray = new string[input.Length];
            int index = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                newArray[index] += input[i];
                index++;
            }
            return newArray;
        }

        public static void reverseElement(string[] input)
        {
            string[] newArray = new string[input.Length];
            int index = 0;
            string word = "";
            foreach (string element in input)
            {
                for (int i = element.Length - 1; i >= 0; i--)
                {
                    word += element[i];
                }
                newArray[index] += word;
                word = "";
                Console.WriteLine(newArray[index] + " " + "Index" + index);
                index++;

            }
            //return newArray;
            Console.WriteLine("Break");
        }

        public static string longestWord(string input)
        {
            int longestcount = 0;
            string longestword = "";

            string[] words = input.Split(' ');
            foreach (string s in words)
            {
                if (s.Length > longestcount)
                {
                    longestcount = s.Length;
                    longestword = s;
                }
            }
            return longestword;

        }

        public static bool palindrome(string input)
        {
            int max = input.Length - 1;
            int min = 0;
            int mid = input.Length / 2;
            for (int i = min; i <= max; i++)
            {
                if (input[i] != input[max])
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }

        public static Dictionary<string, int> nonRepeatedCharacter(string input)
        {
            input = input.ToLower();
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!newDict.ContainsKey(input[i].ToString()))
                {
                    newDict.Add(input[i].ToString(), +1);
                }
                else
                {
                    newDict[input[i].ToString()] += 1;
                }
            }
            foreach (KeyValuePair<string, int> key in newDict)
            {
                if (key.Value == 1)
                {
                    Console.WriteLine(key);
                }
            }
            return newDict;
        }
    }
}


