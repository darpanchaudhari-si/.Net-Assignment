namespace checkcredit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int creditLimit = 10000; 

            
            Console.Write("Enter the purchase price: ");
            double purchasePrice = double.Parse(Console.ReadLine());

            
            if (purchasePrice > creditLimit)
            {
                Console.WriteLine("Error: Purchase price exceeds the credit limit of $" + creditLimit);
            }
            else
            {
                Console.WriteLine("Approved");
            }
        }
    }
}