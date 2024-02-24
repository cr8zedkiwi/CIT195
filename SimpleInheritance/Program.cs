using Inheritance;
using System;
using System.Drawing;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";
        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
            Console.WriteLine("");
        }

    }

    class Cat : Animal
    {
        public string Name;
        public int Age;
        public string Color;

        public Cat() 
        {
            Name = "";
            Age = 0;
            Color = "";
        }

        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void display()
        {
            Console.WriteLine("Cat Information...");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine("");
        }
    }

    class Rat : Animal
    {
        public string Name;
        public int Age;
        public string Color;
        public Rat()
        {
            Name = "";
            Age = 0;
            Color = "";
        }

        public Rat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void display()
        {
            Console.WriteLine("Rat Information...");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine("");
        }
    }
}


    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor

            Cat myCat = new Cat();
            myCat.Name = "Peanut";
            myCat.Age = 3;
            myCat.Color = "Brown Tabby";
            myCat.display();

            //derived class object using parameterized constructor
            Cat myCat2 = new Cat("Skittles", 4, "White");
            myCat2.display();



            Rat myRat = new Rat();
            myRat.Name = "Whiskers";
            myRat.Age = 1;
            myRat.Color = "White";
            myRat.display();


            Rat myRat2 = new Rat("Snickles", 2, "Black");
            myRat2.display();

        }

    }
