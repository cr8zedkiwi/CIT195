﻿using System;

namespace greatAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int lives = 0, magic = 0, health = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is the name of your character? ");
            string name = Console.ReadLine();
            initValues(ref lives, ref magic, ref health, r);
            while (lives > 0 && magic > 0 && health > 0 && win == false)
            {
                direction = chooseDirection();

                if (direction == 1)
                    actions(r.Next(4), ref lives, ref magic, ref health);
                else
                    actions(r.Next(10), ref lives, ref magic, ref health);
                checkResults(ref round, ref lives, ref magic, ref health, ref win);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully completing your journey!");
            else if (lives <= 0)
                Console.WriteLine("You lost too many lives and did not complete your journey");
            else if (magic <= 0)
                Console.WriteLine("You don't have any magic left and cannot complete your journey");
            else
                Console.WriteLine("You are in poor health and had to stop your journey before it's completion");

        }

        private static void checkResults(ref int round, ref int lives, ref int magic, ref int health, ref bool win)
        {
            round++;
            Console.WriteLine("~~~~~~~~~Round " + round + "~~~~~~~~~");
            Console.WriteLine("Lives: " + lives + "  " + "Magic: " + magic + "  " + "Health: " + health );
        }


        private static void actions(int v, ref int lives, ref int magic, ref int health)
        {
            switch (v)
            {
                case 0:
                    Console.WriteLine("You met three bears who were not happy that their porridge was gone.");
                    Console.WriteLine("You lose 1 unit of health and 1 unit of magic");
                    health -= 1;
                    magic -= 1;

                    break;

                case 1:
                    Console.WriteLine("You were abducted by flying monkeys and had to be rescued by a young girl and a dog");
                    Console.WriteLine("You lost 2 units of health and magic and 1 life");
                    health -= 2;
                    magic -= 2;
                    lives -= 1;

                    break;

                case 2:
                    Console.WriteLine("You Wandered into a thick forest full of mythical creatures. Unlucky for you they want your pocket change and will do anything to get it.");
                    Console.WriteLine("You lost 2 health and a unit of magic in order to escape the creatures. You no longer have pocket change.");
                    health -= 2;
                    magic -= 1;

                    break;

                case 3:
                    Console.WriteLine("You meet 3 dark hooded gentleman in front of a shady hole in the wall. You approach them with confidence");
                    Console.WriteLine("The men are impressed with your confidence and grant you a free life. You leave unharmed and with a extra life.");
                    lives += 1;

                    break;

                case 4:
                    Console.WriteLine("You trip on a long branch and lose 2 magic points");
                    magic -= 1;

                    break;

                case 5:
                    Console.WriteLine("You saved a fellow traveler from a headless horseman.");
                    Console.WriteLine("The traveler granted you 2 units of health, magic and lives");
                    health += 2;
                    magic += 2;
                    lives += 2;

                    break;

                case 6:
                    Console.WriteLine("You babysat for a women who lived in a house that resembled a shoe (she had a lot of kids).");
                    Console.WriteLine("You gain 3 units of health and magic");
                    health += 3;
                    magic += 3;
                    break;

                case 7:
                    Console.WriteLine("You climb a tower and save a princess from her evil mom");
                    Console.WriteLine("She thanks you by offering 3 health points and 3 magic points. You accept her thanks and keep adventuring");
                    health += 3;
                    magic += 3;

                    break;

                case 8:
                    Console.WriteLine("You are jumped by 3 elves and take 4 health points");
                    health -= 4;

                    break;

                case 9:
                    Console.WriteLine("You stumble upon weird stump that oddly looks angry. So you kick it naturally");
                    Console.WriteLine("It bites your foot and you take 1 life it was a mean bite");
                    lives -= 1; 
                    
                    break;

                default:
                    Console.WriteLine("You saved a unicorn from a mean wizard.");
                    Console.WriteLine("You gain 2 lives and 2 units of magic");
                    magic += 2;
                    lives += 2;

                    break;
            }
        }

        private static int chooseDirection()
        {
            Console.WriteLine("You have come to a crossroad, enter 1 to travel left and a 2 to travel right");
            int direction = int.Parse(Console.ReadLine());
            while (direction != 1 && direction != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for left or a 2 for right");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }

        private static void initValues(ref int lives, ref int magic, ref int health, Random r)
        {
            lives = r.Next(10) + 1;
            magic = r.Next(15) + 5;
            health = r.Next(14) + 5;
            return;
        }
    }
}