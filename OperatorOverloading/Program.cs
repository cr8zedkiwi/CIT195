namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }

        public static Calculator operator ++(Calculator obj)
        {
            obj.number++;
            Console.WriteLine(obj.number);
            return obj;
        }

        public static Calculator operator --(Calculator obj)
        {
            obj.number = --obj.number;
            return obj;
        }

        public static bool operator >(Calculator left, Calculator right)
        {
            bool larger = false;
            if (left.number > right.number) 
            {
                larger = true;
            }
            return larger;
        }

        public static bool operator <(Calculator left, Calculator right) 
        {
            bool smaller = false;
            if (left.number < right.number)
                smaller = true;
            return smaller;
        }

        public static Calculator operator +(Calculator obj1 , Calculator obj2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = obj1.number + obj2.number;
            return Calc3;
        }

        public static Calculator operator -(Calculator obj) 
        {
            obj.number = -obj.number;
            return obj;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            Calculator n1 = new Calculator();
            Calculator[] numbers = new Calculator[10];
            n1.number = r.Next(1, 100);
            Console.WriteLine("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator();
                numbers[i].number = r.Next(1, 100); 
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();
            Console.WriteLine("New Numbers +1 or -1= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);

            Console.WriteLine($"Numbers + {numToAdd.number} = ");


            for(int i = 0; i < numbers.Length;i++)
            {
                numbers[i] = numbers[i] + numToAdd;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object to subtract
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            // Using operator -, subtract numToSub.number from each element in the array
            // Print the results
            Console.Write($"Numbers - {numToSub.number}= ");

            // Insert a for loop that subtracts numToSub from numbers[i]
            for (int i = 0; i < numbers.Length;i++)
            {
                numbers[i] += numToSub;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object for comparison
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            // Using operator > and operator <, compare each element to numToCompare.number
            // print if the element is higher, lower or equal to the number you are comparing to
            Console.WriteLine($"Numbers above or below {numToCompare.number}");

            for(int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] > numToCompare) 
                {
                    Console.WriteLine($"{numbers[i].number} is higher than");
                }
                else if (numbers[i] < numToCompare) 
                {
                    Console.WriteLine($"{numbers[i].number} is lower");
                }
                else
                {
                    Console.WriteLine($"{numbers[i].number} is equal");
                }
                   
            }
        }
    }
}