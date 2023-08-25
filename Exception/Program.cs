using System.Linq.Expressions;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;

                Console.WriteLine("the result is" + result);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Something Went Wrong ");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally Will Always get Executed");
            }
            Console.WriteLine("Some other procesing goes here");
            
        }
        

        
    }
}