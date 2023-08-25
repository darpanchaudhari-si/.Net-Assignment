using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace DelegateDemo
// step1; declare a delegate
{
    delegate void GreetingDelegate(string str);
    public delegate void Del <T>(T item);
    public delegate T calculatorDelegate<T>(T x, T y); 
    delegate int calculatordelegate(int x, int y);
    internal class Program
    {
        static bool IsEligible(int age)
        {
            if (age >=18)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Func<double,double,double> res1=(x,y) =>
            {
                return x + y;
            }

            Action<string> Welcome = (name) => Console.WriteLine("Hello" + name);
            Console.WriteLine(res1 (3.4,2.2));
            Welcome("Darpan");
            calculator calculator = new calculator();
            Predicate<int> result = IsEligible;
            func<int, int, int> addresult = calculator.Add;
            Func<string, string, string> concateResult = calculator.concate;




            calculatordelegate<int> del1 = calculator.Add;
            calculatordelegate<double> del2 = calculator.AddDouble;

            calculatordelegate<string> del3 = calculator.concate;

            //Console.WriteLine("Enter the arithmatic operateor");
            //Char op = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter the operand 1");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the operand 2");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //calculatordelegate calDel = null;
            //try
            //{
            //    switch (op)
            //    {
            //        case '+':
            //            calDel = calculator.Add;
            //            break;
            //        case '-':
            //            calDel = calculator.Sub;
            //            break;
            //        case '*':
            //            calDel = calculator.Mul;
            //            break;
            //        case '/':
            //            calDel = calculator.Div;
            //            break;

            //    }

            //    DisplayResult(num1, num2, calDel);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
        //    GreetingDelegate del;
        //    Console.WriteLine("Enter your name");
        //    string name = Console.ReadLine();
        //    // step 2 ;careate an instance and bind a method with same signature

        //    Console.WriteLine("Enter Login or LogOut");
        //    string choice = Console.ReadLine();

        //    if (choice.Equals("Login")) ;
        //    {
        //        del = DisplayWelcome;
        //        del(name);
        //    }
        //    else
        //    {
        //        del = DisplyThankYou;
        //        del(name);
        //    }


        //    GreetingDelegate greet = DisplayWelcome;
        //    // multicate Deligate
        //    greet += DisplayMessage;
        //    // step 3; call the deligate by pasing a parametr if any
        //    greet("Darpan");

        //    // remove a method from delegate 
        //    greet -= DisplayMessage;

        //    GreetingDelegate greetingDelegate = DisplayThankYou;
        //    greet("sai");
        //}
        //static void DisplayWelcome(string name)
        //{
        //    Console.WriteLine($"Hello {name} Welcome !");
        //}
        //static void DisplayMessage(string name)
        //{
        //    Console.WriteLine($"Hello {name} Have a nice  day!");
        //}
        //static void DisplayThankYou(string name) 
        //{
        //    Console.WriteLine($"hello {name} ThankYou !");
        //}


        public void DisplayResult(int x, int y, calculatordelegate<int> del)
        {
            int result = del(x, y);
            Console.WriteLine($"The result of is =" + result);
        }
    }
}
