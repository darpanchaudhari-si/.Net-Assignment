using System;
namespace inventory_sysytem_for_online_store
{
    internal class Program
    {   class Product
        {
            public string ProductID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int QuantityInStock { get; set; }

            public virtual void DisplayDetails()
            {
                Console.WriteLine($"Product ID: {ProductID}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Price: ${Price}");
                Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
            }
        }

        class Electronics : Product
        {
            public string Brand { get; set; }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Brand: {Brand}");
            }
        }

        class Clothing : Product
        {
            public string Size { get; set; }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Size: {Size}");
            }
        }

        class Books : Product
        {
            public string Author { get; set; }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Author: {Author}");
            }
        }

        class detail
        {
            static void Main(string[] args)
            {
                Electronics laptop = new Electronics
                {
                    ProductID = "E001",
                    Name = "Laptop",
                    Price = 800,
                    QuantityInStock = 10,
                    Brand = "Dell"
                };

                Clothing tShirt = new Clothing
                {
                    ProductID = "C001",
                    Name = "T-Shirt",
                    Price = 20,
                    QuantityInStock = 50,
                    Size = "Medium"
                };

                Books harryPotter = new Books
                {
                    ProductID = "B001",
                    Name = "Harry Potter and the Sorcerer's Stone",
                    Price = 15,
                    QuantityInStock = 20,
                    Author = "J.K. Rowling"
                };

                Console.WriteLine("Electronics:");
                laptop.DisplayDetails();
                Console.WriteLine();

                Console.WriteLine("Clothing:");
                tShirt.DisplayDetails();
                Console.WriteLine();

                Console.WriteLine("Books:");
                harryPotter.DisplayDetails();
            }
        }

    }
}
