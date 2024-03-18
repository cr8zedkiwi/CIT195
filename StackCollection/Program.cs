using System;
using System.Collections.Generic;

class StackExample
{
    static void Main()
    {
        Stack<string> food = new Stack<string>();
        food.Push("pizza");
        food.Push("taco");
        food.Push("burgers");
        food.Push("fries");
        food.Push("oranges");

        string itemToCheck = "fries";
        bool containsItem = food.Contains(itemToCheck);
        Console.WriteLine(containsItem ? $"The food contains the item: {itemToCheck}" : $"The food does not contain the item: {itemToCheck}");

        string removedItem = food.Pop();
        if (removedItem != null)
        {
            Console.WriteLine($"Removed item: {removedItem}");
        }

        Console.WriteLine($"Count of items in the food: {food.Count}");
        Console.WriteLine("Items in the food:");
        foreach (var item in food)
        {
            Console.WriteLine(item);
        }
    }
}