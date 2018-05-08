using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        //data members
        private string title;
        private string category;

        //properties
        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        //Default constructor
        public Movie()
            {
            title = "Movie Title";
            }

        public Movie(string movTitle, string movCategory)
        {
            title = movTitle;
            category = movCategory;
        }
        
        //overloaded constructor
        public void printInfo()
        {
            //Console.WriteLine($"Title: {Title}\nCategory: {Category}");

            Console.WriteLine(Title);


        }

    }
}
