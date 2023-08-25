namespace inheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student s1 = new DaySchloar();
            Console.WriteLine("--------------------------");
            student h1 = new Hostellar();
                
            //Employee e1 = new Employee(101,"darpan");
            //Employee e2 = new Employee(101, "darpan");
            //Employee e3 = new Employee(103, "sai");

            //Console.WriteLine(e1.Equals(e2));
            //Console.WriteLine(e1.Equals(e3));

            //Hostellar m1 = new Hostellar();
            //Console.WriteLine(m1);
            //student s1 = new DaySchloar();
            //Console.WriteLine(s1);

            //string s2 = "Hello";
            //    Console.WriteLine(s2);

            //Console.WriteLine(e1.ToString());
            //Console.WriteLine(e1);

            //Console.WriteLine(e2.ToString());
            //Console.WriteLine(e2);


            // Employee e3 = e2;

            // Console.WriteLine(e1.Equals(e2));
            // Console.WriteLine(e3.Equals(e2));

            // Console.WriteLine("----------------------------");
            // string s1 = new string("hello");
            // string s2 = new string("hii");
            // string s3 = s2;
            //Console.WriteLine(s1.Equals(s2));
            // Console.WriteLine(s3.Equals(s2));












            //student student;
            //Console.WriteLine("Enter 1 for DayScholer and 2 for Hosteller");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        {
            //            student = new DaySchloar();
            //            if (student is DaySchloar dayschloar)
            //            {
            //                dayschloar.Name = "Darpan";// public class
            //                dayschloar.Id = 1;// public class
            //                dayschloar.Department = "IT";// public class
            //                dayschloar.BusRoute = 622;// override class
            //                dayschloar.BusFee = 3000;// override class
            //                dayschloar.DisplayStudentsDetails();
            //            }
            //            break;
            //        }
            //        case 2:
            //        {
            //            student = new Hostellar();
            //            if (student is Hostellar hostellar)
            //            {
            //                hostellar.RoomNo = 101;// override class
            //                hostellar.RoomFee = 3000;// override class
            //                hostellar.MessFee = 4000;// override class
            //                hostellar.DisplayStudentsDetails();
            //            }
            //            break;

            //        }
            //        default: Console.WriteLine("wrong Choice");
            //        break;
        }
            //DaySchloar d1 = new DaySchloar();
            //d1.Id = 101;
            //d1.Name = "Darpan";
            //d1.Department = "IT";
            //if (d1 is DaySchloar)
            //{

            //    d1.BusRoute = 622;
            //    d1.BusFee = 3000;
            //}

            
            //d1.DisplayStudentsDetails();

            //Hostellar m1 = new Hostellar();
            //m1.Id = 102;
            //m1.Name = "Yash";
            //m1.Department = "CS";
            //m1.HostleFee = 16000;
            //m1.DisplayStudentsDetails();

            //Console.ReadLine();
        
    }
}