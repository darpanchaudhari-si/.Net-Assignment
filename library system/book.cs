using System;
using static System.Console;

namespace library_system
{
    internal class book
    {
        string title;
        string author;
        string genere;
        int quantity;

        public string Title
        {
            get { return title; }
            set { title = value; }

        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set {
                if (value> 0)
                { Console.WriteLine("Books are aviable in the library"); }
                else
                {
                  Console.WriteLine("books are not aviable"); 
                }

                

            }
        }
        public string Genere
        {
            get { return genere; }  
            set { genere = value; }
        }
        public book (string title, string author, string genere)
        {
            this.title = title;
            this.author = author;
            this.genere = genere;
            this.quantity = 0;

        }
        public void Display()
        {
            Console.WriteLine($" Book is {title} written by {author}of{genere} and {quantity}aviable");
        }
}
