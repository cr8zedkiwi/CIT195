using System;

namespace WorkingWithLambdaExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            var y = Convert.ToDouble(Console.ReadLine());


            Func<double, double, double> sum = (double a, double b) => a + b;
            Func<double, double, double> result = (double a, double b) => a * b;

            var largerValue = Math.Max(x, y);

            Console.WriteLine($"The sum is: {sum(x, y)}");
            Console.WriteLine($"The multiplication is: {result(x, y)}");
            Console.WriteLine($"The larger value is: {largerValue}");
        }
    }
}