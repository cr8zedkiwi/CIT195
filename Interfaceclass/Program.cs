using System;
namespace VideoGames
{
    interface Characters
    {
        //Properties
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Program
    {
        class Game : Characters
        {
            //Properties
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            //Parameterized Constructor
            public Game(string title, string firstName, string lastName)
            {
                Title = title;
                FirstName = firstName;
                LastName = lastName;
            }
            //how I print data
            public string Fullname()
            {
                return "Video Game Title: " + Title + "\n" + "Character First Name: " + FirstName + " " + "\nCharacter Last Name: " + LastName;
            }

        }
        //my main method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Video Game Title:");
            string gameTitle = Console.ReadLine();

            Console.WriteLine("Enter the Character's First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the Character's Last Name:");
            string lastName = Console.ReadLine();

            Game character = new Game(gameTitle, firstName, lastName);
            Console.WriteLine(character.Fullname());

            //Space between data
            Console.WriteLine();

            Game steve = new Game("Minecraft", "Steve", "No Last Name");
            Console.WriteLine(steve.Fullname());

        }
    }
}