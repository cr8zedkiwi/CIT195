namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> food = new HashSet<string>();
            food.Add("rice");
            food.Add("noodles");
            food.Add("steak");
            food.Add("pizza");
            food.Add("crackers");

            HashSet<string> bestfood = new HashSet<string>();
            bestfood.Add("cake");
            bestfood.Add("icecream");
            bestfood.Add("pie");
            bestfood.Add("candy");
            bestfood.Add("muffins");

            HashSet<string> badfood = new HashSet<string>();
            badfood.Add("sushi");
            badfood.Add("lard");
            badfood.Add("ants");
            badfood.Add("noodles");
            badfood.Add("crackers");

            Console.WriteLine("Combined list of better and bad food");
            food.UnionWith(bestfood);
            foreach (string ran in food)
            {
                Console.WriteLine(ran);
            }
            Console.WriteLine();

            Console.WriteLine("food that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = food;
            bothLists.IntersectWith(badfood);
            foreach (string language in bothLists)
            {
                Console.WriteLine(language);
            }
        }
    }
}