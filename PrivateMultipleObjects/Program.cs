using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace privatemultiplobjects
{
    class VideoGames
    {
        private string Title;
        private string Type;
        private int Year;

        public VideoGames()
        {
            Title = string.Empty;
            Type = string.Empty;
            Year = 0;
        }
        public VideoGames(string title, string type, int year)
        {
            Title = title;
            Type = type;
            Year = year;
        }

        public string getTitle() { return Title; }
        public string getType() { return Type; }
        public int getYear() { return Year; }
        public void setTitle(string title) { Title = title; }
        public void setType(string type) { Type = type; }
        public void setYear(int year) { Year = year; }

        public virtual void addChange()
        {
            Console.Write("Title=");
            setTitle(Console.ReadLine());
            Console.Write("Type=");
            setType(Console.ReadLine());
            Console.Write("Year of Release=");
            setYear(int.Parse(Console.ReadLine()));
        }
        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"    Title: {getTitle()}");
            Console.WriteLine($"    Type: {getType()} {getYear()}");
            Console.WriteLine($"    Release Year: {getYear()}");
        }
    }
    class BoardGames : VideoGames
    {
        private double Rating;
        private string Description;

        public BoardGames()
            : base()
        {
            Description = string.Empty;
            Rating = 0;
        }
        public BoardGames(string title, string type, int year, double rating, string description)
            : base(title, type, year)
        {
            Rating = rating;
            Description = description;
        }
        public void setRating(double rating) { Rating = rating; }
        public void setDescription(string description) { Description = description; }
        public double getRating() { return Rating; }
        public string getDescription() { return Description; }
        public override void addChange()
        {
            base.addChange();
            Console.Write("rating=");
            setRating(double.Parse(Console.ReadLine()));
            Console.Write("Description=");
            setDescription(Console.ReadLine());
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"  Rating: {getRating()}");
            Console.WriteLine($"Description: {getDescription()}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the max amount of Video Games do you want to enter?");
            int maxGames;
            while (!int.TryParse(Console.ReadLine(), out maxGames))
                Console.WriteLine("Please enter a whole number");
 
            VideoGames[] games = new VideoGames[maxGames];
            Console.WriteLine("What is the max amount of Board Games do you want to enter?");
            int maxBGames;
            while (!int.TryParse(Console.ReadLine(), out maxBGames))
                Console.WriteLine("Please enter a whole number");

            BoardGames[] brdGames = new BoardGames[maxBGames];

            int choice, rec, type;
            int vgamesCounter = 0, brdGamesCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for Board Games or 2 for Video Games");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for Board Games or 2 for Video Games");
                try
                {
                    switch (choice)
                    {
                        case 1:
                            if (type == 1)
                            {
                                if (brdGamesCounter <= maxBGames)
                                {
                                    brdGames[brdGamesCounter] = new BoardGames();
                                    brdGames[brdGamesCounter].addChange();
                                    brdGamesCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of Board Games has been added");

                            }
                            else
                            {
                                if (vgamesCounter <= maxGames)
                                {
                                    games[vgamesCounter] = new VideoGames();
                                    games[vgamesCounter].addChange();
                                    vgamesCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of Video Games has been added");
                            }

                            break;
                        case 2: //Change
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;  // subtract 1 because array index begins at 0
                            if (type == 1) //Manager
                            {
                                while (rec > brdGamesCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                brdGames[rec].addChange();
                            }
                            else // Employee
                            {
                                while (rec > vgamesCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                games[rec].addChange();
                            }
                            break;
                        case 3:
                            if (type == 1)
                            {
                                for (int i = 0; i < brdGamesCounter; i++)
                                    brdGames[i].print();
                            }
                            else
                            {
                                for (int i = 0; i < vgamesCounter; i++)
                                    games[i].print();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }


                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();

            }
        }


        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}
