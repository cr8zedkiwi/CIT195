using System;

class Program
{
    static Random rand = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of random values to generate:");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 99); 
        }

        Console.WriteLine("Your random numbers are:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int addResult = Add(numbers);
        int multiplyResult = Multiply(numbers);

        Console.WriteLine($"Total of numbers added: {addResult}");
        Console.WriteLine($"Total of numbers multiplied: {multiplyResult}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1; 
        foreach (int num in numbers)
        {
            total *= num;
        }
        return total;
    }
}