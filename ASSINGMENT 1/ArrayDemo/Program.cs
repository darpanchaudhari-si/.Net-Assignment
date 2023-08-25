using System.ComponentModel.Design;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the total no of students");

            int num = Convert.ToInt32(Console.ReadLine());

            int[] marklist = new int[num];
            for (int i =0;i<marklist.Length;i++)
            {
                Console.WriteLine($"Enter mark for student {i + 1}");
                marklist[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < marklist.Length; i++) 
            {
                Console.WriteLine(marklist[i]);
            }*/

           /* Console.WriteLine("Enter the total no of reg vhecial");

           int num = Convert.ToInt32(Console.ReadLine());

           int[] regno = new int[num];
           for (int i =0;i<regno.Length;i++)
           {
               Console.WriteLine($"Enter the no for reg vhecial {i + 1}");
               regno[i] = Convert.ToInt32(Console.ReadLine());
           }
           for (int i = 0; i < regno.Length; i++) 
           {
               Console.WriteLine(regno[i]);
           }*/

            Console.WriteLine("Enter the total no of students");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of studnets");
            string s = Console.ReadLine();

            Console.WriteLine("Score of studnet out of 100");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int[] marklist = new int[num];
            for (int i = 0; i < marklist.Length; i++)

            {
                Console.WriteLine($"Enter mark for student {i + 1}");
                marklist[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (s2 >= 91 && s2 <= 100) ;
            {
                Console.WriteLine("A grade" + num);
            }
            else if (s2 >= 81 && s2 <== 90);
            {
                Console.WriteLine("B grade" + num);
            }
            else if
                (s2 >= 71 && s2 <== 80);
            {
                Console.WriteLine("c grade" + num);
            }
            else if (s2 >= 61 && s2 <== 70);
            {
                Console.WriteLine("d grade" + num);
            }
            else if (s2 >= 51 && s2 <== 60);
            {
                Console.WriteLine("e grade" + num);
            }
            else if (s2 >= 41 && s2 <== 50);
            {
                Console.WriteLine("f grade" + num);
            }

            for (int i = 0; i < marklist.Length; i++)
            {
                Console.WriteLine(marklist[i]);
            }
            





        }
    }
}