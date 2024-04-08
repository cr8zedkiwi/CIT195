using System;

namespace List
{
    public class SurvivalList
    {
        public string Inventory { get; set; }
        public double Amount { get; set; }
        public string? Category { get; set; }


        public static SurvivalList operator ++(SurvivalList obj)
        {
            obj.Amount++;
            Console.WriteLine(obj.Amount);
            return obj;
        }

        public static SurvivalList operator --(SurvivalList obj)
        {
            obj.Amount--;
            return obj;
        }

        public static SurvivalList operator +(SurvivalList obj, double amountToAdd)
        {
            obj.Amount += amountToAdd;
            return obj;
        }

        public static SurvivalList operator -(SurvivalList obj, double amountToSubtract)
        {
            obj.Amount -= amountToSubtract;
            return obj;

        }

        public static bool operator >(SurvivalList left, SurvivalList right)
        {
            bool larger = false;
            if (left.Amount > right.Amount)
                larger = true;
            return larger;
        }

        public static bool operator <(SurvivalList left, SurvivalList right)
        {
            bool smaller = false;
            if (left.Amount < right.Amount)
                smaller = true;
            return smaller;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SurvivalList[] mySurvivalList = new SurvivalList[100];
            for (int i = 0; i < mySurvivalList.Length; i++)
            {
                mySurvivalList[i] = new SurvivalList();
            }
            int selection = Menu();
            int index = 0, entry = 0;
            string ans = "";
            while (selection != 6)
            {
                switch (selection)
                {
                    case 1:
                        if (index < 100)
                        {
                            Console.Write("Inventory Category (Food, Weapons, Potions?): ");
                            mySurvivalList[index].Category = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Inventory: ");
                            mySurvivalList[index].Inventory = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Amount: ");
                            mySurvivalList[index].Amount = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            index++;
                        }
                        else
                            Console.WriteLine("You have too many SurvivalList entries - see programming");
                        break;
                    case 2:
                        for (int i = 0; i < mySurvivalList.Length; i++)
                        {
                            if (mySurvivalList[i].Inventory != "" && mySurvivalList[i].Inventory != null)
                            {
                                Console.WriteLine($"Category: {mySurvivalList[i].Category}");
                                Console.WriteLine($"Inventory: {mySurvivalList[i].Inventory}");
                                Console.WriteLine($"Amount: {mySurvivalList[i].Amount}");
                            }
                        }
                        break;
                    case 3:
                        entry = pickEntry(index);
                        Console.Write("Change Inventory Category (Food, Weapons, Potions) Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            Console.Write("Category? ");
                            mySurvivalList[entry].Category = Console.ReadLine();
                        }
                        Console.WriteLine();
                        Console.Write("Change Inventory Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            Console.Write("Inventory: ");
                            mySurvivalList[entry].Inventory = Console.ReadLine();
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        entry = pickEntry(index);

                        Console.Write("Increase Amount by 1?  Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            mySurvivalList[entry]++;
                            Console.WriteLine();
                            break;
                        }

                        Console.Write("Decrease Amount by 1?  Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            mySurvivalList[entry]--;
                            Console.WriteLine();
                            break;
                        }

                        Console.Write("Increase Amount by > 1?  Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            Console.Write("Enter the Amount: ");
                            int hr;
                            while (!int.TryParse(Console.ReadLine(), out hr))
                                Console.WriteLine($"Please a number");
                            mySurvivalList[entry] += hr;
                            Console.WriteLine();
                            break;
                        }

                        Console.Write("Decrease Amount by > 1?  Y for Yes ");
                        ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                        {
                            Console.Write("Enter the Amount: ");
                            int hr;
                            while (!int.TryParse(Console.ReadLine(), out hr))
                                Console.WriteLine($"Please a number");
                            mySurvivalList[entry] -= hr;
                            Console.WriteLine();
                            break;
                        }

                        break;
                    case 5:
                        SurvivalList totalFood = new SurvivalList();
                        totalFood.Category = "Food Category";
                        totalFood.Inventory = "Total Food Amount";
                        SurvivalList totalWeapons = new SurvivalList();
                        totalWeapons.Category = "Weapons Category";
                        totalWeapons.Inventory = "Total Weapons Amount";
                        SurvivalList totalPotions = new SurvivalList();
                        totalPotions.Category = "Potions Category";
                        totalPotions.Inventory = "Total Potions Amount";
                        for (int i = 0; i < mySurvivalList.Length; i++)
                        {
                            switch (mySurvivalList[i].Category)
                            {
                                case "Food":
                                    totalFood.Amount += mySurvivalList[i].Amount;
                                    break;
                                case "Weapons":
                                    totalWeapons.Amount += mySurvivalList[i].Amount;
                                    break;
                                case "Potions":
                                    totalPotions.Amount += mySurvivalList[i].Amount;
                                    break;
                            }
                        }
                        Console.WriteLine("Total Amount by Category");
                        // calls operator >
                        if (totalFood > totalWeapons && totalFood > totalPotions)
                        {
                            Console.WriteLine("The largest number of Amount was spent on Food!");
                            Console.WriteLine($"Your total Food Amount = {totalFood.Amount}");
                            Console.WriteLine($"Your total Weapons Amount = {totalWeapons.Amount}");
                            Console.WriteLine($"Your total Potions Amount = {totalPotions.Amount}");
                        }
                        // calls operator >
                        else if (totalWeapons > totalFood && totalWeapons > totalPotions)
                        {
                            Console.WriteLine("The largest number of Amount was spent on Weapons");
                            Console.WriteLine($"Your total Weapons Amount = {totalWeapons.Amount}");
                            Console.WriteLine($"Your total Food Amount = {totalFood.Amount}");
                            Console.WriteLine($"Your total Potions Amount = {totalPotions.Amount}");
                        }
                        else
                        {
                            Console.WriteLine("The largest number of Amount was spent on Potions activities");
                            Console.WriteLine($"Your total Potions Amount = {totalPotions.Amount}");
                            Console.WriteLine($"Your total Weapons Amount = {totalWeapons.Amount}");
                            Console.WriteLine($"Your total Food Amount = {totalFood.Amount}");
                        }
                        break;
                    default:
                        Console.WriteLine("You made an invalid selection, please try again");
                        break;
                }
                selection = Menu();

            }
        }
        public static int Menu()
        {
            int choice = 0;
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1 - Add an entry");
            Console.WriteLine("2 - Print All");
            Console.WriteLine("3 - Change category or Inventory");
            Console.WriteLine("4 - Adjust Amount");
            Console.WriteLine("5 - Total categories and compare");
            Console.WriteLine("6 - Quit");
            while (!int.TryParse(Console.ReadLine(), out choice))
                Console.WriteLine("Please select 1 - 6");
            return choice;
        }
        public static int pickEntry(int index)
        {
            Console.WriteLine("What entry would you like to change?");
            Console.WriteLine($"1 through {index}");
            int entry;
            while (!int.TryParse(Console.ReadLine(), out entry))
                Console.WriteLine($"Please select 1 - {index}");
            entry -= 1;
            return entry;
        }
    }
}