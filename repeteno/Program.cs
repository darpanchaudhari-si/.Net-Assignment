namespace repeteno
{
    internal class Program
    {
        static int CountOccurrences(string text, char character)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == character)
                    count++;
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Enter a line of text: ");
            string lineOfText = Console.ReadLine();

            Console.Write("Enter the character to count: ");
            char characterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int result = CountOccurrences(lineOfText, characterToCount);
            Console.WriteLine($"The character '{characterToCount}' occurs {result} time(s) in the text.");
        }
    }
    






    
}