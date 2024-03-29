using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class famousPeople
{
    public string Name { get; set; }
    public int? BirthYear { get; set; } = null;
    public int? DeathYear { get; set; } = null;
}
class Program
{
    public static void Main(string[] args)
    {
        IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
                };

        var birth19 = stemPeople.Where(s => s.BirthYear > 1900);
        Console.WriteLine("People born after 1900:");
        foreach (var str in birth19)
        {
            Console.WriteLine($"{str.Name}");
        }

        IEnumerable < string > allpeople = stemPeople.Where(s => s.Name.Contains("ll"))
                .Select(s => s.Name);   
        Console.WriteLine("\nPeople with 2 lowercase l's in their name:");
        foreach (string s in allpeople) 
        {
            Console.WriteLine(s);    
        }

        var countBirth = stemPeople.Count(s => s.BirthYear > 1950);
        Console.WriteLine("\nThe amount of people born after 1950:");
        Console.Write(countBirth);


        var between = stemPeople.Where(s => s.BirthYear > 1920 && s.BirthYear < 2000);
        Console.WriteLine();
        Console.WriteLine("\nPeople born between 1920 and 2000:");
        foreach (var s in between)
        {
            Console.WriteLine($"{s.Name}");
        }
        var countBetween = stemPeople.Count(s => s.BirthYear > 1920 && s.BirthYear < 2000);
        Console.WriteLine();
        Console.WriteLine($"There are {countBetween} people born between 1920 and 2000");

        Console.WriteLine();

        Console.WriteLine("This is all the people in order of their birth year:");
        var ageOrder = from s in stemPeople
                       orderby s.BirthYear
                       select s;
        foreach (var s in ageOrder) 
        {
            Console.WriteLine(s.Name);
        }


        var deathbetween = stemPeople.Where(s => s.DeathYear > 1960 && s.DeathYear < 2015);
        var order = from s in deathbetween
                  orderby s.DeathYear
                  select s;
        Console.WriteLine();
        Console.WriteLine("\nPeople who died between 1960 and 2015");
        foreach(var s in order)
        {
            Console.WriteLine(s.Name);
        }

    }
}