using System;
using System.Collections.Generic;

namespace onlineStore
{
    internal class Program
    {
        class product
        {
            public string Name { get; }
            public decimal Price { get; }
            public string Category { get; }
            public int Quantityinstock { get; }

            public product(string name, decimal price, string category, int quantityinstock)
            {
                Name = name;
                Price = price;
                Category = category;
                Quantityinstock = quantityinstock;
            }

            
        }

        class Store
        {
            private List<product> products = new List<product>();

            public void AddProduct(product product)
            {
                products.Add(product);
            }
            public void DisplayproductList()
            {
                Console.WriteLine("Product List :");
                foreach (product product in products)
                {
                    Console.WriteLine($"name:{product.Name},price:{product.Price},category:{product.Category},quantityinstock:{product.Quantityinstock}");
                }
                Console.WriteLine();
            }
            public List<product> SearchproductByName(string Name)
            {
                return products.Where(product => product.Name == Name).ToList();
            }
            public decimal TotalCost
            {
                get
                {
                    decimal total = 0;
                    foreach (var product in products)
                    {
                        total += product.Price * product.Quantityinstock;
                    }
                    return total;
                }

            }        
            class Detail
            {
                static void Main(string[] args)
                {
                    Store store = new Store();
                    product Products;
                    while(true)
                    {
                        Console.WriteLine("1.Add Product");
                        Console.WriteLine("2.Display List Product");
                        Console.WriteLine("3.calculate total value Product");
                        Console.WriteLine("4.Exit");
                        Console.WriteLine("Enter Your Choice:");
                        int choice = int.Parse(Console.ReadLine());

                        switch(choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Product name: ");
                                string Title = Console.ReadLine();
                                Console.WriteLine("Enter product price ");
                                decimal Price = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Enyter Total Quantity of product");
                                int Quantityinstock=Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the category of the product");
                                string productCategory = Console.ReadLine();
                                
                                product product = new product(Title, Price,productCategory, Quantityinstock);
                                store.AddProduct(product);
                                Console.WriteLine("product added to cart.\n");
                                break;

                            case 2:
                                store.DisplayproductList();
                                break;
                          

                            default:
                                Console.WriteLine("Invalid Choice.Please select a valid choice of product\n");
                                break;


                        }

                    }
                }
            }
        }
    }
}