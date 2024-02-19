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
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
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
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {


                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of your favorite song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("What artist made this song?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What album is this song from?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("How long is this song?");
                    collection[i].setLength(double.Parse(Console.ReadLine()));
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
                    collection[i].setGenre(tempGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}
