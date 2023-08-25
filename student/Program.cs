namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            detail student1 = new detail();
           
            Console.WriteLine("Enter the student name");
            student1.Name = Console.ReadLine();
            Console.WriteLine("Enter the student course c# or ASP.NET");
            student1.Course = Console.ReadLine();

            student1.Display();
           
            Console.ReadLine();
            
        }
    }
}