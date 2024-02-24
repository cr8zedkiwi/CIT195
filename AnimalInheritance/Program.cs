class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
    public void setColor(string color) 
    {
        this.color = color;    
    }

    public virtual string getColor()
    { 
        return this.color; 
    }
}

class Lion : Animal
{
    private string Height;
    private int Age;
    private string Weight;

    public void setHeight(string height)
    {
        this.Height = height;
    }
    public virtual string getHeight()
    {
        return this.Height;
    }
    public void setWeight(string weight)
    {
        this.Weight = weight;
    }
    public virtual string getWeight()
    {
        return this.Weight;
    }

    public void setAge(int age)
    {
        this.Age = age;
    }
    public virtual int getAge()
    {
        return this.Age;
    }

    public override string getName()
    {
        return base.getName();
    }

    public override string getType()
    {
        return type;
    }

    static void Main(string[] args)
    {
        Animal cat = new Animal();
        cat.setName("Peanut");
        cat.setType("Cat");
        cat.setColor("Brown Tabby");

        Console.WriteLine("Animal Information...");
        Console.WriteLine($"My name is {cat.getName()}");
        Console.WriteLine($"I am a {cat.getType()}");
        Console.WriteLine($"I am a lovely {cat.color} color");
        Console.WriteLine();

        Lion lion = new Lion();
        lion.setName("Lenny");
        lion.setType("Barbary Lion");
        lion.color = "beige";
        lion.setWeight("200 LBS");
        lion.setHeight("4 FT");
        lion.setAge(9);

        Console.WriteLine("Lion Information...");
        Console.WriteLine($"My name is {lion.getName()}");
        Console.WriteLine($"I am a {lion.getType()}");
        Console.WriteLine($"I am a lovely {lion.color} color");
        Console.WriteLine($"I am {lion.getAge()} years old");
        Console.WriteLine($"I weigh a impressive {lion.getWeight()}");
        Console.WriteLine($"I stand at {lion.getHeight()}");

        Console.ReadLine();

    }
}