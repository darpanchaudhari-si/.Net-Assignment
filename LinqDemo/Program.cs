using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace LinqDemo
{
    internal class Program
    {

        public static void Linq1()
        {
            int[] numbers = new int[] { 5, 7, 9, 4, 6, 1, 2, 8, 0, 3 };
            var result = from num in numbers where num % 2 == 1 orderby num select num;// where num%2 ==1
            foreach (var item in result)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var res1 = employeeList.Where(e => e.salary >= 50000);
            var res2 = employeeList.OrderBy(e => e.salary);

            foreach(Employee e in res1)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\nsorted by salary");
            foreach (Employee e in res2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            

        }
        public static void Linq2()
        {
            int[] numbers = new int[] { 11, 2, 28, 25, 17, 39, 14, 66, 11, 2, 28, 40, 33 };
            // query syntax
            // var result = from num in numbers where num < 30 orderby  num select num;
            //methods
            var result = numbers.Where(x => x < 30).OrderBy(x => x).Distinct();
            // hybrid

        }
        public static void Linq3()
        {
            int[] numbers = new int[] { 11, 2, 28, 25, 17, 39, 14, 66, 11, 2, 28, 40, 33 };

            var result = numbers.Where(x => x < 30).OrderBy(x => x).Distinct();
            foreach (var item in numbers)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine();
        }
        public static void Linq4()
        {
            var numbers = from num in Enumerable.Range(100, 50)
                          select new { Number = num, oddEven = num % 2 == 0 ? "Even" : "odd" };

            foreach (var item in numbers)
            {
                Console.WriteLine(item + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static void Linq6()
        {
            string[] fruits = { "Cherry", "plum", "Apple", "orange", "Blueberry", "pear", "peach" };
            var result = (from f in fruits where f[0] == '0' select f);
            //var result = fruits.Where(x => x.StartsWith("o"));
            //var result = fruits.Single(s => s[0] == 'p');
            Console.WriteLine(result);
            foreach (var f in fruits)
            {
                Console.WriteLine(f[0] + "\t");
            }
            Console.WriteLine();
        }

        private static List<Employee> employeeList = new List<Employee>()
        {
            new Employee(){Id  = 1 ,Name= "darpan",Department ="Fiannce",Salary= 30000},
            new Employee(){Id  = 2 ,Name= "Sai",Department ="IT",Salary= 40000},
            new Employee(){Id  = 3 ,Name= "Yash",Department ="CS",Salary= 50000},
            new Employee(){Id  = 4 ,Name= "Ashu",Department ="HR",Salary= 60000},
            new Employee(){Id  = 5 ,Name= "Jayesh",Department ="Sales",Salary= 70000},
        };
        
        
    }
}