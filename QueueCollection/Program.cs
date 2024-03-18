using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> food = new Queue<string>();


            food.Enqueue("Pizza");
            food.Enqueue("Burger");
            food.Enqueue("Taco");
            food.Enqueue("Doritos");
            food.Enqueue("Fries");


            string specificItem = "Taco";
            bool containsItem = food.Contains(specificItem);
            Console.WriteLine("Does the queue contain tacos?" + containsItem);

            string removedItem = food.Dequeue();
            Console.WriteLine("Item removed" + removedItem);
            
            Console.WriteLine($"Here are your {food.Count()} foods");
            foreach (var m in food)
            {
                Console.WriteLine(m);
            }
        }
    }
}