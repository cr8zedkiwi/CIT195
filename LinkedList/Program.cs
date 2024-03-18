using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] foods =
            { "Pizza", "Burger", "Fries", "Cheese", "Potato" };
        LinkedList<string> foodsList = new LinkedList<string>(foods);
        Console.WriteLine("Original foods list");
        foreach (string food in foodsList)
        {
            Console.WriteLine(food);
        }
        Console.WriteLine();



        LinkedListNode<string> targetLocation = foodsList.Find("Pizza");
        Console.WriteLine("The current foods in the list after Pizza is {0}", targetLocation.Next.Value);
        Console.WriteLine();
        LinkedListNode<string> target = foodsList.Find("Cheese");
        Console.WriteLine("The current foods last in the list is {0}", target.Next.Value);
        Console.WriteLine();
        foodsList.AddAfter(target, "Meatballs");
        Console.WriteLine("New Food List Added Meatballs:");
        foreach (string food in foodsList) 
        {
            Console.WriteLine(food);
        }
        
        Console.WriteLine();
        foodsList.RemoveLast();
        Console.WriteLine("There are this many left in the list:" + foodsList.Count);
        Console.WriteLine("New Food List Deleted Potato:");
        foreach (string food in foodsList)
        {
            Console.WriteLine(food);
        }
    }
}
