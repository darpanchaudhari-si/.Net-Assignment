namespace methodsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 10;
             int b = 20;
             Console.WriteLine($"Before swapping a: {a},b{b}");
             swap(ref a, ref b);
             Console.WriteLine($"After swapping a{a}, b:{b}");
         }
         static void swap(ref int x, ref int y)
         {
             Console.WriteLine("\n--------------------------------");
             Console.WriteLine($"Inside swap Before swapping a: {x},b{y}");
             int temp ;
             temp = x;
             x = y;
             y = temp;
             Console.WriteLine($"Inside Swap After Swapping a:{x}, b:{y}");
             Console.WriteLine("--------------------\n");*/

            /*static void main(string[] args)
            {
                double grosspay;
                double netpay = calculatesalary(5000, 2000, out grosspay);

                Console.WriteLine($"net pay :{netpay} , gross pay={grosspay}");
            }
            static double calculatesalary(double bpay ,double allowances,out double grosspay)
            {
                grosspay = bpay + allowances;
                double netpay = bpay - (bpay * 0.30);
                return netpay;
            }*/


            // name parameter and optional parameter

           /* Display(marks: 34.5, name: "darpan");
            Console.ReadLine();

        }

        public static void Display(double marks, string name, int age = 10)
        {
            Console.WriteLine($"Name is {name} ,age is {age}");
        }*/

        // params parameter 

        CalculateBill("Darpan",150 ,450);
        CalculateBill("Sai",100,130 ,450);
        CalculateBill("Yash",150,56,98,450);
        Console.ReadLine();
        }

    public static void CalculateBill(string name,params double[] pricelist)
    {
        double totalAmount = 0;
        for (int i=0; i< pricelist.Length; i++)
            {
                totalAmount =totalAmount + pricelist[i];

            }
        Console.WriteLine($"Bill of {name} : rs: {totalAmount}\n);
    }













    }
}