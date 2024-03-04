using System;

interface IClub
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Methods
    string Fullname();
    string Information();
}

class ClubMember : IClub
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public ClubMember() { }

    public ClubMember(int id, string firstName, string lastName, int age, string email, string phone)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
        Phone = phone;
    }

    public string Fullname()
    {
        return FirstName + " " + LastName;
    }

    public string Information()
    {
        return "Age: " + Age + "\nEmail: " + Email + "\nPhone: " + Phone;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClubMember fred = new ClubMember(10, "Fred", "Flintstone", 50, "fred@example.com", "1234568888");
        Console.WriteLine(fred.Fullname());
        Console.WriteLine(fred.Information());

        ClubMember barney = new ClubMember();
        barney.Id = 20;
        barney.FirstName = "Barney";
        barney.LastName = "Rubble";
        barney.Age = 40;
        barney.Email = "barney@example.com";
        barney.Phone = "0987658881";
        Console.WriteLine();
        Console.WriteLine(barney.Fullname());
        Console.WriteLine(barney.Information());
    }
}