using System;
using System.Diagnostics.Metrics;

namespace FunwithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> food = new List<string> { "Pizza", "Pie", "Cake", "Taco", "tea" };

            Console.WriteLine($"There original list has {food.Count()} food");
            string[] memberArr = new string[] { "Kale", "Cucumber", "Beans" };
            food.AddRange(memberArr);
            Console.WriteLine($"The new list now has {food.Count()} food");

            Console.WriteLine("-------Original List--------");
            for (int i = 0; i < food.Count(); i++)
                Console.WriteLine(food[i]);

            food.Remove(food[4]);
            food.RemoveRange(3, 2); 

            Console.WriteLine($"The revised list now has {food.Count()} food");
            Console.WriteLine("-------Revised List--------");
            for (int i = 0; i < food.Count(); i++)
                Console.WriteLine(food[i]);

            food.Remove("Pizza");
            food.Sort();
            Console.WriteLine("-------Sorted List--------");
            foreach (string m in food)
                Console.WriteLine(m);
            food.Reverse();
            Console.WriteLine("-------Reverse Sorted List--------");
            foreach (string m in food)
                Console.WriteLine(m);


        }
    }
}