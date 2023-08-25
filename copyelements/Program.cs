namespace copyelements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sourceArray = { 1, 2, 3, 4, 5 };

            // Create a new array with the same size as the source array
            int[] destinationArray = new int[sourceArray.Length];

            // Copy the elements from the source array to the destination array
            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            // Print the original array
            Console.WriteLine("Original Array:");
            PrintArray(sourceArray);

            // Print the copied array
            Console.WriteLine("Copied Array:");
            PrintArray(destinationArray);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
    
