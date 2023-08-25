namespace Shoppingbill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Mobile");
            Console.WriteLine("2.Cloths");
            Console.WriteLine("3.Accesaries");

            Console.WriteLine("Enter the price of 1st item");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of 2st item");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of 3st item");
            int choice3 = Convert.ToInt32(Console.ReadLine());

            int sum = choice1 + choice2 + choice3;
            double total = sum * 0.05;
            Console.WriteLine( "the amt is " + total.ToString());
                
        }
    }
}