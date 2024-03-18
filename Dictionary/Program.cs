namespace WorkingWithDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> foodsList = new Dictionary<string, string>();

            foodsList.Add("green", "Pear");
            foodsList.Add("red", "Apple");
            foodsList.Add("purple", "Egg Plant");
            foodsList.Add("white", "Coconut");
            foodsList.Add("orange", "Orange");

            Console.WriteLine("foodsList Keys");
            Dictionary<string, string>.KeyCollection keys = foodsList.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("foodsList Values");
            Dictionary<string, string>.ValueCollection values = foodsList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("foodsList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in foodsList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            foodsList.Remove("orange");

            Console.WriteLine("Removed food from list:");
            foreach (KeyValuePair<string, string> kvp in foodsList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();

        }

    }
}