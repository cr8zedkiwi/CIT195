using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;

namespace BookStore
{
    class program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore bookstore = new(1, "The Women", "Kristin Hannah", 22);
            Console.WriteLine(bookstore);
            Bookstore bookstore2 = new(2, "Fourth Wing", "Rebecca Yarros", 34);
            Console.WriteLine(bookstore2);
            Bookstore bookstore3 = new(3, "Iron Flame", "Rebecca Yarros", 30);
            Console.WriteLine(bookstore3);
        }
    }
}