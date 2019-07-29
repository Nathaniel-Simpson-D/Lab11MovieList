using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MovieList_NateS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = InitializeList();
            string[] genres = { "Horror", "SciFi", "Fantasy", "Comidie", "Animation" };
            Console.WriteLine("Welcome to Generic-Theater-Website.");
            while (true)
            {
                Console.WriteLine("Would you like to see all avalable movies, search by genre, or Exit?(1/2/3)");
                int choice = Validator.GetIntChoice(1, 3);
                if (choice == 0)
                {
                    Console.Clear();
                    PrintMovies(movies, genres);
                }
                else if (choice == 1)
                {
                    Console.Clear();
                    SearchGenre(movies, genres);
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    bool conf = Validator.GetYN("Are you Sure?");

                    if (conf)
                    {
                        Validator.EndProgram("Goodbye, come again.");
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Sorry Not a Choice!");
                }
            }
        }
        public static List<Movie> InitializeList()
        {
            List<Movie> movies = new List<Movie>()
            {
            new Movie("Alien","Horror SciFi"),
            new Movie("Evil Dead", "Comidie Fantasy"),
            new Movie("Halloween", "Horror"),
            new Movie("IT", "Horror"),
            new Movie("Lion King", "Animation"),
            new Movie("Lord of The Rings", "Fantasy"),
            new Movie("Mulan", "Animation"),
            new Movie("Pacific Rim", "SciFi"),
            new Movie("Space Jam", "SciFi Comidie"),
            new Movie("Star Wars: A New Hope", "SciFi Fantasy"),
             };
            return movies;
        }
        public static void PrintMovies(List<Movie> movies ,string[] str)
        {
            
            foreach (string genre in str)
            {
                Console.WriteLine(genre);
                foreach (Movie m in movies)
                {
                    if (m.Genre.Contains(genre))
                    {
                        Console.WriteLine($"     {m.Title}");

                    }
                }
            }
            Console.WriteLine("Press ENTER to return to menue");
            while (Console.ReadKey(true).Key!=ConsoleKey.Enter)
            {

            }
            Console.Clear();
            

        }
        public static void SearchGenre(List<Movie> movies, string[] str)
        {
            Console.WriteLine("Choose your genre.");
            int i = 1;
            foreach (string s in str)
            {
                Console.WriteLine($"{i}: {s}");
                i++;
            }

            int choice = Validator.GetIntChoice(1, str.Length);
            Console.Clear();
            foreach (Movie m in movies)
            {
                if (m.Genre.Contains(str[choice]))
                {
                    Console.WriteLine($"{m.Title,5}");

                }
            }
            Console.WriteLine("Press ENTER to return to menue");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }
            Console.Clear();
        }

    }
}
