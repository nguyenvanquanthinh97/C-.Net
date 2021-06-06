using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book {Isbn = "1111", Title = "C# Advanced"};

            var books = new GenericList<Book>();
            books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var number = new Nullable<int>();
            Console.WriteLine("Has Value: {0}", number.HasValue());
            Console.WriteLine("Value: {0}", number.GetValueOrDefault());
        }
    }
}
