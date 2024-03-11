class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

    public Student(int id)
    {
        Id = id;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public static void Main()
    {
        Student s = new Student(1);
        s.FirstName = "Billy";
        s.LastName = "Bob";

        Student s2 = new Student(2, "Riley", "Ridingtin");

        Console.WriteLine($"Student1:");
        Console.WriteLine($"ID: {s.Id}");
        Console.WriteLine($"First Name: {s.FirstName}");
        Console.WriteLine($"Last Name: {s.LastName}");
        Console.WriteLine(s2);
        Console.WriteLine($"Student2:");
        Console.WriteLine($"ID: {s2.Id}");
        Console.WriteLine($"First Name: {s2.FirstName}");
        Console.WriteLine($"Last Name: {s2.LastName}");
    }
}