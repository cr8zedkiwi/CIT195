public class Program
{

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double Tuition { get; set; }
    }
    public class StudentClubs
    {
        public int StudentID { get; set; }
        public string ClubName { get; set; }
    }
    public class StudentGPA
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }
    }
    public static void Main()
    {

        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 5, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 6, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 7, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
        };
        // Student GPA Collection
        IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };
        // Club collection
        IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
        };
        var groupedGPA = from s in studentGPAList
                         group s by s.GPA;
        foreach (var groupGPA in groupedGPA)
        {
            Console.WriteLine();
            Console.WriteLine("GPA Group: " + groupGPA.Key);
            foreach (StudentGPA s in groupGPA)
            {
                Console.WriteLine("Student ID: " + s.StudentID);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        var sortedClub = from s in studentClubList
                         orderby s.ClubName
                         group s by s.ClubName;
        foreach (var sortClub in sortedClub)
        {
            Console.WriteLine();
            Console.WriteLine("Club: " + sortClub.Key);
            foreach (StudentClubs s in sortClub)
            {
                Console.WriteLine("Student ID: " + s.StudentID);
            }
        }

        var countGPA = studentGPAList.Count(s=>s.GPA >= 2.5 && s.GPA <= 4.0);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The number of students with a GPA between 2.5 and 4.0 is: " + countGPA);

        Console.WriteLine();
        Console.WriteLine();

        var avgTuition = studentList.Average(s=>s.Tuition);
        Console.WriteLine("The average tuition of all the students is " + String.Format("{0:F}", avgTuition));

        Console.WriteLine();
        Console.WriteLine();

        var maxTuition = studentList.Max(s=>s.Tuition);
        var topStudent = studentList.FirstOrDefault(s => s.Tuition == maxTuition);

        if(topStudent != null)
        {
            Console.WriteLine(topStudent.StudentName);
            Console.WriteLine(topStudent.Major);
            Console.WriteLine(topStudent.Tuition);
        }

        Console.WriteLine();
        Console.WriteLine();

        var innerjoin = studentList.Join(studentGPAList,
            student => student.StudentID,
            GPA => GPA.StudentID,
            (student, GPA) => new
            {
                StudentName = student.StudentName,
                Major = student.Major,
                GPA = GPA.GPA
            });
        Console.WriteLine("Student list and their GPA:");
        foreach(var s in innerjoin)
        {
            Console.WriteLine($"Name: {s.StudentName}  \tMajor: {s.Major}\tGPA: {s.GPA}");
            Console.WriteLine();
        }


        var anotherjoin = studentList.Join(studentClubList,
            student => student.StudentID,
            club => club.StudentID,
            (student, club) => new
            {
                StudentName = student.StudentName,
                ClubName = club.ClubName
            })
            .Where(sc => sc.ClubName == "Game");

        Console.WriteLine("Students in the game club:");
        foreach (var s in anotherjoin)
        {
            Console.WriteLine(s.StudentName);
        }
    }
}
