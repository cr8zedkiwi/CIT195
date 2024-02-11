using System;

namespace myProject
{
    class fitness
    {
        private int _Id;
        private string _Title;
        private static int _Workouts = 0;

        public fitness()
        {
            _Id = 0;
            _Title = "";
        }

        public fitness(int id, string title)
        {
            _Id = id;
            _Title = title;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public int GetWork()
        {
            return _Workouts;
        }

        public void SetWork()
        {
            _Workouts++;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a workout plan to get you in shape!");
            fitness number1 = new fitness();
            number1.SetWork();
            number1.SetId(1);
            number1.SetTitle("Bench Press");

            fitness number2 = new fitness();
            number2.SetWork();
            Console.WriteLine("Please enter a random number!");
            number2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter a exercise");
            number2.SetTitle(Console.ReadLine());

            fitness number3 = new fitness(2, "Star Wars");
            number3.SetWork();

            Console.WriteLine("Please enter your favorite number");
            int workoutID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a workout you enjoy");
            string workoutTitle = Console.ReadLine();

            fitness number4 = new fitness(workoutID, workoutTitle);
            number4.SetWork();

            Console.WriteLine($"There are {number1.GetWork()} workouts to do today!");
            displayWorkout(number1);
            displayWorkout(number2);
            displayWorkout(number3);
            displayWorkout(number4);
        }

        static void displayWorkout(fitness number)
        {
            Console.WriteLine("Here is a workout");
            Console.WriteLine($"Amount of sets for this workout: {number.GetId()}");
            Console.WriteLine($"Workout name {number.GetTitle()}");
        }
    }
}