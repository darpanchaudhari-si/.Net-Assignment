using inheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected internal string Department { get; set; }

        protected double CollegeFee { get; set; }

        public virtual void DisplayStudentsDetails()//virtual is used for override
        {
            Console.WriteLine($"Id :{Id}\t Name : {Name} \tDepartmemnt : {Department}");
        }
    }
    // child class Student 
    class DaySchloar : student
    {
        public DaySchloar() { Console.WriteLine("From DaySchlor"); }

        public DaySchloar(int busRoute, double busFee, int id, string name, string department, double collegFee) : base (id, name, department, collegFee)
        {
            Console.WriteLine("from parent student");
            BusRoute = busRoute;
            busFee = busFee;
        }
        public int BusRoute { get; set; }
        public double BusFee { get; set; }


        public double CalculateFees()
        {
            CollegeFee = CollegeFee + BusFee;
            return CollegeFee;
        }
        public override void DisplayStudentsDetails()// only child class will get
        {
            base.DisplayStudentsDetails();// all the details of student display
            Console.WriteLine($"Bus Route : {BusRoute} Total Fee :{CalculateFees()}");
        }
    }
    class Hostellar : student
    {
        public double RoomNo { get; set; }
        public double RoomFee { get; set; }
        public double MessFee { get; set; }

       


        public double CalculateFees()
        {
           CollegeFee = CollegeFee + RoomFee + MessFee;
           return CollegeFee;
        }
        public override void DisplayStudentsDetails()
        {
            Console.WriteLine($"Room Fee:{RoomFee}\t Total Fee :{CalculateFees()}");
        }

    }
}
