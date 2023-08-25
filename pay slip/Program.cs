namespace pay_slip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type num of hrs");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("amt for working per hr");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 * num2;
            Console.WriteLine("this is package" +num3);
            double gross = num3 * 0.05;
            Console.WriteLine("this is deducted amount" +gross);

            double num5 = gross -(+num3);
            Console.WriteLine( "total inhand salary" +num5);
        }
    }
}