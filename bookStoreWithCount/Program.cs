using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _Transactions = 0;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public int GetTrans()
        {
            return _Transactions;
        }

        public void SetTrans()
        {
            _Transactions++;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            book number1 = new book();
            number1.SetTrans();
            number1.SetId(0);
            number1.SetTitle("The Forester");
            number1.SetAuthor("Jimmy James");

            book number2 = new book();
            number2.SetTrans();
            Console.WriteLine("Please enter the book ID number");
            number2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Title");
            number2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Author");
            number2.SetAuthor(Console.ReadLine());

            book number3 = new book(2, "Star Wars", "Jake Bob");
            number3.SetTrans();

            Console.WriteLine("Please enter the book ID number");
            int bookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title");
            string bookTITLE = Console.ReadLine();
            Console.WriteLine("Please enter the author");
            string bookAUTHOR = Console.ReadLine();
            book number4 = new book(bookID, bookTITLE, bookAUTHOR);
            number4.SetTrans();

            Console.WriteLine($"There are {number1.GetTrans()} new books!");
            displayBooks(number1);
            displayBooks(number2);
            displayBooks(number3);
            displayBooks(number4);
        }

        static void displayBooks(book number)
        {
            Console.WriteLine("Here is a book");
            Console.WriteLine($"Book ID: {number.GetId()}");
            Console.WriteLine($"Book Title: {number.GetTitle()}");
            Console.WriteLine($"Book Author: {number.GetAuthor()}");
        }
    }
}