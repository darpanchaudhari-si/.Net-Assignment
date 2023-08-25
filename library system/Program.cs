using System.Collections.Specialized;
using System.Net.Http.Headers;

namespace library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book();
            b1.Author = "Hanya Yangaga";
            b1.Quantity = 5;
            b1.Genere = "fiction";
            b1.Title = "a little life";
            book b2 = new book();
            b2.Author = "colleeen hoover";
            b2.Quantity = 5;
            b2.Genere = "Love story";
            b2.Title = "It Starts wth us";
            book b3 = new book();
            b3.Author = "j.k.Rowling";
            b3.Quantity = 5;
            b3.Genere = "fun";
            b3.Title = "Harry porter";
            book b4 = new book();
            b4.Author = "abdul kalam";
            b4.Quantity = 5;
            b4.Genere = "Motivation";
            b4.Title = "the books of wings";

            b1.Display();
            b2.Display();
            b3.Display();
            b4.Display();

        }
    }
}