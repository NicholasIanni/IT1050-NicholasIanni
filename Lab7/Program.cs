using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "Ianni";
            book.Title = "Get Rich Quick";
            book.Year = 2020;

            book.Display();
        }
    }
}
