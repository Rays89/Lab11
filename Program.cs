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

            bool usercontinue = true;
            while (usercontinue == true)
            {
                Console.WriteLine("What category are you interested in?");
                string category = Console.ReadLine();

                foreach (Movie movie in MovieList)
                {
                    if (category.ToLower() == movie.Category.ToLower())
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

