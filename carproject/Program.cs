namespace carproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car c1 = new Car("royal","Black");// object 
            c1.Speed = 30; 
           /* Car c2 = new Car("Jack","Red", 60);
            Car c3 = new Car( "audi","Black",80);
            c3.CarName = "Brown";
            Console.WriteLine("the color of c3 is" + c3.CarName);*/
            /*c1.Display();
            /*c2.Display();
            c3.Display();*/

                Employee e1 = new Employee();
                e1.Name = "darpan";
                e1.Basicpay = 5000;

                e1.calculateSalary(e1.Basicpay, 1000);

                Console.WriteLine($"{e1.Name}'s Salary is Rs.{e1.Salary}");

                Console.ReadKey();
        }
    }
}