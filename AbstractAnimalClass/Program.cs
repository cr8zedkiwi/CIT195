using System;
using System.Xml.Linq;

namespace Games
{
    abstract class Game
    {
        public abstract string Name { get; set; }
 
        public abstract string Describe();
        public string Greetings()
        {
            return "Hello Friend!";
        }
    }

    class Program
    {
        class boardgames : Game
        {
            public override string Name { get; set; }
            public string Type { get; set; }

            public int Rate { get; set; }

            public boardgames()
            {
                Name = string.Empty;
                Type = string.Empty;
                Rate = 0;
            }
            public boardgames(string name, string type, int rate)
            {
                Name = name;
                Type = type;
                Rate = rate;
            }

            public override string Describe()
            {
                return "One of My favorite Games is a " + Type + "\nThe name of it is " + Name + "\nI would rate it a " + Rate + "out of 10";
            }

        }
        static void Main(string[] args)
        {
            boardgames sorry = new boardgames();
            sorry.Name = "Sorry";
            sorry.Type = "Board Game";
            sorry.Rate = 8;
            Console.WriteLine(sorry.Greetings());
            Console.WriteLine(sorry.Describe());


            boardgames monopoly = new boardgames("monopoly", "Board Game", 10);
            Console.WriteLine(monopoly.Describe());
        }
    }
}
