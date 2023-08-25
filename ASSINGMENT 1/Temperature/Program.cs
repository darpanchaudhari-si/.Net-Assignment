using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Temprature
    {
        public int Sum(int[] arr)
        {
            int suum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suum += arr[i];
            }
            return suum;
        }
        public void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Main()
        {
            int[] temp = new int[10];
            bool value = true;
            int j = 0;
            int i = 0;
            Console.WriteLine("Enter value of Temperature:");

            while (value)
            {
                j = Convert.ToInt32(Console.ReadLine());
                if (j >= 20 & j <= 130)
                {
                    temp[i] = j;
                    i++;
                }
                else if (j == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter valid Tempreature Value.");
                }
            }
            Temprature t1 = new Temprature();
            Console.WriteLine($"All the Temperature Variations of the Day");
            for (int k = 0; k < i; k++)
            {
                Console.WriteLine(temp[k]);
            }

        }
    }
}