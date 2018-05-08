using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        public static object Movies { get; private set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();

            Console.WriteLine("There are 10 movies in the list");



            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Star Wars", "Scifi"));
            MovieList.Add(new Movie("Night Shift", "Romance"));
            MovieList.Add(new Movie("shrek", "Animated"));
            MovieList.Add(new Movie("Halloween", "Horor"));
            MovieList.Add(new Movie("Titanic", "Drama"));
            MovieList.Add(new Movie("Fight Club", "Drama"));
            MovieList.Add(new Movie("Transformers", "Scifi"));
            MovieList.Add(new Movie("Pacific Rim", "Scifi"));
            MovieList.Add(new Movie("I follows", "Horror"));
            MovieList.Add(new Movie("In the dark", "Horror"));

            string[] category = { "Scifi", "Horror", "Drama", "Animated", "Romance" };

            bool usercontinue = true;

            while (usercontinue == true)
            {
                Console.WriteLine("What category are you interested in? (1)Scifi,(2)Horror, (3)Drama, (4)Animated, (5)Romance");


                int Moviepick;
                while(!int.TryParse(Console.ReadLine(), out Moviepick ) || Moviepick < 1 || Moviepick > 5)
                {
                    Console.WriteLine("Hey, thats not valid");
                }
                foreach (Movie movie in MovieList)
                {
                    if (movie.Category.ToLower() == category[Moviepick - 1].ToLower())
                    {
                        movie.printInfo();


                    }

                }

                Console.WriteLine("Would you like to continue? (y/n):");
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    usercontinue = true;
                }
                else
                {
                    usercontinue =false;
                   Console.WriteLine(" Bye");

                }

            }

        }

    }
    }

