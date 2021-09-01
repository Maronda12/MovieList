using System;
using System.Collections.Generic;
using System.Linq;



namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {


            //Each movie should be represented by an object of type Movie.
            //List of movies
            List<Movie> movies = new List<Movie>();

            Movie m1 = new Movie("CHERRY", Category.Drama);
            movies.Add(m1);

            Movie m2 = new Movie("Pulp Fiction", Category.Drama);
            movies.Add(m2);

            Movie m3 = new Movie("Training Day", Category.Drama);
            movies.Add(m3);

            Movie m4 = new Movie("Toy Story", Category.Animated);
            movies.Add(m4);

            Movie m5 = new Movie("Cars", Category.Animated);
            movies.Add(m5);

            Movie m6 = new Movie("A Quiet Place", Category.Horror);
            movies.Add(m6);

            Movie m7 = new Movie("SAW", Category.Horror);
            movies.Add(m7);

            Movie m8 = new Movie("TENET", Category.Scifi);
            movies.Add(m8);

            Movie m9 = new Movie("INTERSTELLAR", Category.Scifi);
            movies.Add(m9);

            Movie m10 = new Movie("STAR WARS : The Rise of Skywalker", Category.Scifi);
            movies.Add(m10);


            bool goOn = true;

            while (goOn == true)
            {

            Console.WriteLine("Welcome to our Movie List!!");
            Console.WriteLine("Here are the categories available.");
            Category[] acceptedCategories = (Category[])Enum.GetValues(typeof(Category));

            

                //Prints Categories
                for (int i = 0; i < acceptedCategories.Length; i++)
                {
                Console.WriteLine($"{i}: {acceptedCategories[i]}");
                }

                //Prints movie title in category
                List<Movie> categoryMovies = new List<Movie>();
                int input = GetCategoryIndex();
                Category inputCategory = (Category)acceptedCategories[input];

                foreach (Movie m in movies)
                {
                    if (m.category == inputCategory)
                    {
                        categoryMovies.Add(m);
                    }
                }
                List<Movie> sortedMovies = categoryMovies.OrderBy(x => x.Title).ToList();

                foreach (Movie m in sortedMovies)
                {
                    Console.WriteLine(m.Title);
                }

                goOn = GetContinue();
            }
        }
        //User Input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().Trim();
            if (input == "")
            {
                input = GetUserInput("Not acceptable input. Try again.");
            }
            return input;
        }
        //Validation
        public static int GetCategoryIndex()
        {
            string input = GetUserInput("Please enter the index for the Category you would like to see.");
            int output = -1;

            try
            {
                output = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a number listed above.");
                output = GetCategoryIndex();

            }
            return output;
        }

        //Continue Method
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");

                return GetContinue();
            }
        }


    }
}