namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<string, string> foodList = new SortedList<string, string>();
            //add the elements in sortedlist  
            foodList.Add("Green", "Pear");
            foodList.Add("Red", "Apple");
            foodList.Add("Brown", "Coconut");
            foodList.Add("Purple", "EggPlant");
            foodList.Add("White", "Rice");
            //display the elements of the sortedlist  
            Console.WriteLine("The items in my sorted food list are:");
            foreach (KeyValuePair<string, string> bl in foodList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
            Console.WriteLine("What color is your favorite food?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            //check for value in list
            if (foodList.ContainsValue(color))
                Console.WriteLine($"{color} is one of the colors in your list already");
            else
            {
                if (foodList.ContainsKey(food))
                {
                    Console.WriteLine($"You can only have one food this color: {food} ");
                }
                else
                {
                    foodList.Add(food, color);
                    Console.WriteLine("{color} {food} was added to your list");
                }
            }
            foodList.Remove("Red");
            Console.WriteLine();
            Console.WriteLine("New List removing apple:");
            foreach (KeyValuePair<string, string> bl in foodList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
        }
    }
}