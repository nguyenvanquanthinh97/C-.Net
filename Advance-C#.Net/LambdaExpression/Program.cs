using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>
            {
                new Book{Title = "Title 1", Price = 7},
                new Book{Title = "Title 2", Price = 9},
                new Book{Title = "Title 3", Price = 12}
            };
        }

        public List<Book> GetBooks() => _books;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda Function:
            // number => number * number;
            Func<int, int> square = number => number * number;

            const int factor = 5;
            Func<int, int> multiple = number => number * factor;

            Console.WriteLine(square(5));
            Console.WriteLine(multiple(7));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
