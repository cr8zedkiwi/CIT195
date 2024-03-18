namespace PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            PriorityQueue<string, int> item = new PriorityQueue<string, int>();

            item.Enqueue("bike", 1);
            item.Enqueue("shoe", 2);
            item.Enqueue("pens", 4);
            item.Enqueue("lamp", 3);
            item.Enqueue("couch", 5);


            while (item.Count > 0)
            {
                var highp = item.Peek();
                Console.WriteLine("Highest priority item:" + highp);
                highp = item.Dequeue();
                Console.WriteLine("You have this many items left:" + item.Count);
            }       
        }
    }
}