using System;
public class Animal<T>
{
    public T data;

    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> AnimalName = new Animal<string>("Lion");

        Animal<string> AnimalHabitat = new Animal<string>("Lion's Den");
  
        Animal<bool> endangered = new Animal<bool>(false);

        Animal<bool> extinct = new Animal<bool>(false);

        Animal<int> averageLifespan = new Animal<int>(12);

        Console.WriteLine("Animal Name:" + AnimalName.getAnimal());
        Console.WriteLine("Animal Habitat:" + AnimalHabitat.getAnimal());
        Console.WriteLine("Endangered:" + endangered.getAnimal());
        Console.WriteLine("Extinct:" + extinct.getAnimal());
        Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal());
    }
}