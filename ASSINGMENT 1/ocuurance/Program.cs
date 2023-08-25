using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class String
    {
        public static void Main()
        {
            /*Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Grade");
            char grade= Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Name:{name}\nAge:{age}\nGrade:{grade}");
            Console.WriteLine("");*/


            //Program to find occurance of specific character
            string sent = "Sportz Interactive";
            int count = 0;
            Console.WriteLine("Enter character whose occurance you wish to see:");
            char find = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < sent.Length; i++)
            {
                if (sent[i] == find)
                {
                    count++;
                }
            }
            Console.WriteLine($"Occurance of character {find} is {count}");
            Console.WriteLine("\n");

            //Reverse a string
            Console.WriteLine("Reverse a string");
            char[] charArray = sent.ToCharArray();
            var resultstring = new string(charArray.Reverse().ToArray());
            Console.WriteLine($"{resultstring}");
            Console.WriteLine("\n");

            //Substring
            Console.WriteLine($"{sent.Substring(1, 6)}");
            Console.WriteLine("\n");

            //Compare Substrings
            string substring1 = "sportz interactive";
            string substring2 = "SPORTZ INTERACTIVE";

            Console.WriteLine($"Comaprison considering case: {substring1 == substring2}");
            Console.WriteLine($"Comparison without considering case: {substring1.ToLower() == substring2.ToLower()}");

        }

    }
}