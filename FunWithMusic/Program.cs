using System;
using System.Runtime.InteropServices;

namespace music
{
    class Program
    {
        enum Genre
        {
            Country,
            HipHop,
            Pop,
            Rock,
            Metal
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private Genre? Genre;
            public Music(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title=title;
            }
            public void setLength(double length)
            {
                Length=length;
            }
            public void setValues(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("What artist made this song?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is this song from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is this song?");
            double tempLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("C - Country\nH - HipHop\nP - Pop\nR - Rock\nM - Metal");
            Genre tempGenre = Genre.Country;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'S':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum,tempLength, tempGenre);
            Music moreMusic = music;
            moreMusic.setTitle("Come Together");
            moreMusic.setLength(4.2);
            Console.WriteLine("Here's movie #2");
            Console.WriteLine($"{moreMusic.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here's movie #1");
            Console.WriteLine($"{music.Display()}");

        }
    }
}
