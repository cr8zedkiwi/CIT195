using System;

namespace frogAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int lives = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            var streetsCrossed = 0;
            Console.Write("What is the name of your frog? ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome froggy " + name + " Your mission is to cross 30 streets 3... 2... 1... GO");
            initValues(ref lives, r);
            while (lives > 0  && win == false)
            {
                direction = chooseDirection();

                if (direction == 1)
                    actions(r.Next(4), ref lives);
                else
                    actions(r.Next(5), ref lives);
                checkResults(ref round, ref lives, ref win, ref streetsCrossed);

                if (streetsCrossed == 30)
                    win = true;
            }
            if (win)
                Console.WriteLine("Congratulations on successfully completing your journey!");
            else if (lives <= 0)
                Console.WriteLine("You lost too many lives and did not complete your journey");

        }

        private static void checkResults(ref int round, ref int lives, ref bool win, ref int streetsCrossed)
        {
            streetsCrossed++;
            round++;
            Console.WriteLine("~~~~~~~~~Streets Crossed " + round + "~~~~~~~~~");
            Console.WriteLine("Lives Remaining: " + lives);
        }


        private static void actions(int v, ref int lives)
        {
            switch (v)
            {
                case 0:
                    Console.WriteLine("Some kid found you in the middle of the street and helped you across");
                    Console.WriteLine("You crossed a street gain a life!");
                    lives += 1;

                    break;

                case 1:
                    Console.WriteLine("You crossed a street gain a life!");
                    lives += 1;

                    break;

                case 2:
                    Console.WriteLine("You got in front of a semi and became a street pancake");
                    Console.WriteLine("you lost 2 lives");
                    lives -= 2;

                    break;

                case 3:
                    Console.WriteLine("You trip on a long branch and got smacked by a biker");
                    lives -= 1;

                    break;

                case 4:
                    Console.WriteLine("You were to slow and got hit by a car. Lose a life");
                    lives -= 1;

                    break;

                default:
                    Console.WriteLine("You crossed a special golden street");
                    Console.WriteLine("You gain 2 lives");
                    lives += 2;

                    break;
            }
        }

        private static int chooseDirection()
        {
            Console.WriteLine("You have come to a street, enter 1 to attempt to cross or 2 to find another street");
            int direction = int.Parse(Console.ReadLine());
            while (direction != 1 && direction != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for cross or a 2 for new street");
                direction = int.Parse(Console.ReadLine());
            }

            return direction;
        }

        private static void initValues(ref int lives, Random r)
        {
            lives = r.Next(10) + 1;

            return;
        }
    }
}