using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5},
                new Book() {Title = "ASP.NET MVC", Price = 9.99f},
                new Book() {Title = "ASP.NET Web API", Price = 12},
                new Book() {Title = "C# Advanced Topics", Price = 7},
                new Book() {Title = "C# Advanced Topics", Price = 9}
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();

            //var _cheapBooks =
            //    from book in books where book.Price < 10 orderby book.Title select book;


            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

            // LINQ Extensions Methods
            //books.Where();
            //books.Single();
            //books.SingleOrDefault();

            //books.First();
            //books.FirstOrDefault();

            //books.Last();
            //books.LastOrDefault();

            //books.Min();
            //books.Max();
            //books.Count();
            //books.Sum();
            //books.Average();

            //books.Skip(5).Take(3);
        }

        public static void LogBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + "\t" + book.Price);
            }
        }
    }
}
