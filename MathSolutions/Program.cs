namespace Assignment8ex2
{
    public class MathSolutions
    {

        /*public double GetSum(double x, double y)
        {
            return x + y;
        }
        */
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            //Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            //action delegate
            Action<double, double> calcSum = delegate (double x, double y) { Console.WriteLine($" {num1} + {num2} = {x + y}"); };
            calcSum(num1, num2);

            //Console.WriteLine($" {num1} x {num2} = {answer.GetProduct(num1, num2)}");
            //func delegate
            Func < double, double, double > calcProduct = delegate (double x, double y) { return x * y; };
            Console.WriteLine($" {num1} x {num2} = " + calcProduct(num1, num2));

            //answer.GetSmaller(num1, num2);
            //New custom delegate and I went with another anonymous action delegate
            Action<double, double> compare = delegate (double x, double y) {GetSmaller(num1, num2);};
            compare(num1, num2);
        }
    }
}

