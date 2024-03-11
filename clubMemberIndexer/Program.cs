using System.Drawing;
using System.Net;
class Program
{
    public const int Size = 15;  // global variable
    class ClubMembers
    {
        private string[] clubmembers = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers()
        {
            for (int i = 0; i < Size; i++)
            {
                clubmembers[i] = string.Empty;
            }
            ClubType = string.Empty;
            ClubLocation = string.Empty;
            MeetingDate = string.Empty;
        }

        public string this[int index]
        {
            get
            {
                string inde;

                if (index >= 0 && index <= Size - 1)
                {
                    inde = clubmembers[index];
                }
                else
                {
                    inde = "";
                }

                return (inde);
            }
            set
            {
                if (index >= 0 && index <= Size - 1)
                {
                    clubmembers[index] = value;
                }
            }

        }
    }

        static void Main(string[] args)
        {
        ClubMembers club = new ClubMembers();

       
        club[0] = "John Doe";
        club[1] = "Alice Smith";
        club[2] = "Bob Johnson";

      
        club.ClubType = "Book Club";
        club.ClubLocation = "Library";
        club.MeetingDate = "Every Friday";

    
        Console.WriteLine("Club Type: " + club.ClubType);
        Console.WriteLine("Club Location: " + club.ClubLocation);
        Console.WriteLine("Meeting Date: " + club.MeetingDate);
        Console.WriteLine("Members:");



        for (int i = 0; i < Size; i++)
        {
            if (!string.IsNullOrEmpty(club[i]))
            {
                Console.WriteLine(club[i]);
            }
        }
    }
}
