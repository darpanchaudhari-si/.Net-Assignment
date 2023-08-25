namespace reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
       {
            Console.WriteLine("Enter the numbers in array");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("enter the reverse no");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length-1; i >=0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}