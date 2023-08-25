using System;
namespace Shape_Hierarchy_using_Interfaces
{
    internal class Program
    {
        



    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Circle:");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Triangle:");
            Console.WriteLine($"Side A: {SideA}");
            Console.WriteLine($"Side B: {SideB}");
            Console.WriteLine($"Side C: {SideC}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Detail
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Hierarchy Program");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");

            Console.Write("Enter your choice (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Circle circle = new Circle();
                    Console.Write("Enter the radius of the circle: ");
                    circle.Radius = double.Parse(Console.ReadLine());
                    circle.DisplayDetails();
                    break;

                case 2:
                    Rectangle rectangle = new Rectangle();
                    Console.Write("Enter the width of the rectangle: ");
                    rectangle.Width = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the rectangle: ");
                    rectangle.Height = double.Parse(Console.ReadLine());
                    rectangle.DisplayDetails();
                    break;

                case 3:
                    Triangle triangle = new Triangle();
                    Console.Write("Enter the length of side A: ");
                    triangle.SideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side B: ");
                    triangle.SideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side C: ");
                    triangle.SideC = double.Parse(Console.ReadLine());
                    triangle.DisplayDetails();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }


}
}