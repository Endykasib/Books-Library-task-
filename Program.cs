using System;
using System.Collections.Generic;
using static Books_Library_task.Program;
using static System.Net.WebRequestMethods;

namespace Books_Library_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///////Library library = new Library();
            //bool running = true;

            //while (running)
            //{
            //    Console.WriteLine("\n===== Library Menu =====");
            //    Console.WriteLine("1- Add Book");
            //    Console.WriteLine("2- Search Book");
            //    Console.WriteLine("3- Borrow Book");
            //    Console.WriteLine("4- Return Book");
            //    Console.WriteLine("5- Check Availability");
            //    Console.WriteLine("6- Exit");
            //    Console.Write("Choose option: ");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter Title: ");
            //            string title = Console.ReadLine();

            //            Console.Write("Enter Author: ");
            //            string author = Console.ReadLine();

            //            Console.Write("Enter ISBN: ");
            //            string isbn = Console.ReadLine();

            //            Book newBook = new Book(title, author, isbn);
            //            library.AddBook(newBook);
            //            break;

            //        case "2":
            //            Console.Write("Enter Title or Author to search: ");
            //            string searchValue = Console.ReadLine();

            //            Book foundBook = library.SearchBook(searchValue);

            //            if (foundBook != null)
            //            {
            //                Console.WriteLine($"Found: {foundBook.Title} by {foundBook.Author}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Book not found.");
            //            }
            //            break;

            //        case "3":
            //            Console.Write("Enter Title or Author to borrow: ");
            //            string borrowValue = Console.ReadLine();
            //            library.BorrowBook(borrowValue);
            //            break;

            //        case "4":
            //            Console.Write("Enter Title or Author to return: ");
            //            string returnValue = Console.ReadLine();
            //            library.ReturnBook(returnValue);
            //            break;

            //        case "5":
            //            Console.Write("Enter Title or Author to check availability: ");
            //            string checkValue = Console.ReadLine();

            //            Book checkBook = library.SearchBook(checkValue);

            //            if (checkBook != null)
            //            {
            //                if (checkBook.Availability)
            //                    Console.WriteLine("Book is available.");
            //                else
            //                    Console.WriteLine("Book is borrowed.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Book not found.");
            //            }
            //            break;

            //        case "6":
            //            running = false;
            //            Console.WriteLine("Goodbye ");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice.");
            //            break;
            // }
            Library library = new Library();

            Book b1 = new Book("The Great lands", "john fred", "109");
            Book b2 = new Book("The Nightmare", " Chris Johnson", "110");

            library.AddBook(b1);
            library.AddBook(b2);

            library.BorrowBook("The Great lands");
            library.ReturnBook("The Great lands");

            string choice = Console.ReadLine();

        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public bool Availability { get; set; }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                Availability = true;
            }
        }
        public class Library
        {
       
            private List<Book> books = new();

            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine($"{book.Title} added successfully.");
            }
            
            public Book SearchBook(string value)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Title == value ||
                        books[i].Author == value)
                    {
                        return books[i];
                    }
                }

                return null; 
            }
       
            public void BorrowBook(string input)
            {
                Book book = SearchBook(input);

                if (book == null)
                {
                    Console.WriteLine("Book not found.");
                }
                else if (!book.Availability)
                {
                    Console.WriteLine("Book is already borrowed.");
                }
                else
                {
                    book.Availability = false;
                    Console.WriteLine("Book borrowed successfully.");
                }
            }

           //
            public void ReturnBook(string input)
            {
                Book book = SearchBook(input);

                if (book == null)
                {
                    Console.WriteLine("Book not found.");
                }
                else if (book.Availability)
                {
                    Console.WriteLine("Book is already available.");
                }
                else
                {
                    book.Availability = true;
                    Console.WriteLine("Book returned successfully.");
                }
            }
        }
    }
}

