using System;

abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public abstract double CalculateBonus();

    public void DisplayDetails()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Salary: ${Salary}");
        Console.WriteLine($"Calculated Bonus: ${CalculateBonus()}");
        Console.WriteLine();
    }
}

class Manager : Employee
{
    public override double CalculateBonus()
    {
        return Salary * 0.15; 
    }
}

class Developer : Employee
{
    public override double CalculateBonus()
    {
        return Salary * 0.10; 
    }
}

class SalesPerson : Employee
{
    public override double CalculateBonus()
    {
        return Salary * 0.12; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        Console.WriteLine("Enter Manager Details:");
        manager.Name = Console.ReadLine();
        manager.EmployeeID = Convert.ToInt32(Console.ReadLine());
        manager.Salary = Convert.ToDouble(Console.ReadLine());

        Developer developer = new Developer();
        Console.WriteLine("Enter Developer Details:");
        developer.Name = Console.ReadLine();
        developer.EmployeeID = Convert.ToInt32(Console.ReadLine());
        developer.Salary = Convert.ToDouble(Console.ReadLine());

        SalesPerson salesPerson = new SalesPerson();
        Console.WriteLine("Enter SalesPerson Details:");
        salesPerson.Name = Console.ReadLine();
        salesPerson.EmployeeID = Convert.ToInt32(Console.ReadLine());
        salesPerson.Salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nManager Details:");
        manager.DisplayDetails();

        Console.WriteLine("Developer Details:");
        developer.DisplayDetails();

        Console.WriteLine("SalesPerson Details:");
        salesPerson.DisplayDetails();
    }
}
