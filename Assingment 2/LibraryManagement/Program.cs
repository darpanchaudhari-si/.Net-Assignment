using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    internal class Program
    {
        class Book
        {
            public string Title { get; }
            public string Author { get; }
            public string Genre { get; }
            public int QuantityAvailable { get; set; }

            public Book(string title, string author, string genre, int quantityAvailable)
            {
                Title = title;
                Author = author;
                Genre = genre;
                QuantityAvailable = quantityAvailable;
            }
        }

        class Library
        {
            private List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
            }

            public void DisplayBookList()
            {
                Console.WriteLine("Book List:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
                Console.WriteLine();
            }

            public List<Book> SearchBooksByTitle(string title)
            {
                return books.Where(book => book.Title.ToLower().Contains(title.ToLower())).ToList();
            }

            public List<Book> SearchBooksByAuthor(string author)
            {
                return books.Where(book => book.Author.ToLower().Contains(author.ToLower())).ToList();
            }
        }

        class Detail
        {
            static void Main(string[] args)
            {
                Library library = new Library();

                while (true)
                {
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Display Book List");
                    Console.WriteLine("3. Search Books by Title");
                    Console.WriteLine("4. Search Books by Author");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();
                            Console.Write("Enter Quantity Available: ");
                            int quantityAvailable = int.Parse(Console.ReadLine());
                            Book book = new Book(title, author, genre, quantityAvailable);
                            library.AddBook(book);
                            Console.WriteLine("Book added to library.\n");
                            break;

                        case 2:
                            library.DisplayBookList();
                            break;

                        case 3:
                            Console.Write("Enter Title to Search: ");
                            string searchTitle = Console.ReadLine();
                            List<Book> titleResults = library.SearchBooksByTitle(searchTitle);
                            DisplaySearchResults(titleResults);
                            break;

                        case 4:
                            Console.Write("Enter Author to Search: ");
                            string searchAuthor = Console.ReadLine();
                            List<Book> authorResults = library.SearchBooksByAuthor(searchAuthor);
                            DisplaySearchResults(authorResults);
                            break;

                        case 5:
                            Console.WriteLine("Exiting program...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.\n");
                            break;
                    }
                }
            }
        }


        static void DisplaySearchResults(List<Book> results)
            {
                if (results.Count == 0)
                {
                    Console.WriteLine("No matching books found.\n");
                }
                else
                {
                    Console.WriteLine("Search Results:");
                    foreach (var book in results)
                    {
                        Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                    }
                    Console.WriteLine();
                }
            }
    }

}

    

