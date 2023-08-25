using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

namespace carproject
{
    internal class Employee
    {
        int id;
        double salary;
        double basicpay;
        string name;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Basicpay
        {
            get { return basicpay; }
            set
            {
                if (value < 1000)
                { basicpay = value; }
                else
                {
                    basicpay = value;
                }
            }
        }
        public double Salary
        {
            get { return salary; }
        }
        public void calculateSalary(double bpay, double deduction)
        {
            this.salary = bpay - deduction;
        }


    }
}

