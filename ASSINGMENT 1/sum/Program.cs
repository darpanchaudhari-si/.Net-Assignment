namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nFind sum of all elements of array:\n");
            

            Console.Write("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("new integer n");
            int a = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("the sum of arrays are");
                int sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }






}

    }
}