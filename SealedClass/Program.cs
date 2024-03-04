using System;
namespace Employees
{ 
interface IEmployee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Methods
    public string Fullname();
    public double Pay();
}
class program { 

class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public string Fullname()
    {
        return FirstName + " " + LastName;
    }

    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }
}

sealed class Executive : Employee
{
    public string Title { get; set; }
    public int Salary { get; set; }

    public Executive()
    {
        Title = string.Empty;
        Salary = 0;
    }

    public Executive(string title, int salary)
    {
        Title = title;
        Salary = salary;
    }

    public override double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }
}

        class Program
        {
            static void Main(string[] args)
            {

                Employee george = new Employee(5, "George", "Jetson");
                Console.WriteLine(george.Pay());


                Employee fred = new Employee(10, "Fred", "Flintstone");
                Console.WriteLine(fred.Fullname());
                Console.WriteLine(fred.Pay());

                Executive barney = new Executive();
                barney.Id = 20;
                barney.FirstName = "Barney";
                barney.LastName = "Rubble";
                barney.Title = "CEO";
                barney.Salary = 780000;
                Console.WriteLine(barney.Fullname());
                Console.WriteLine(barney.Pay());

            }
        }
    }
}