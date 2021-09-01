using System;

namespace MovieList
{
    public enum Category
    {
        Animated,
        Drama,
        Horror,
        Scifi,

    }

    public class Movie
    {
        //Field - Property

        //I could not figure out how to get program running once switched to private.
        
        public string Title { get; set; }
        public Category category { get; set; }


        //Constructor
        public Movie(string title, Category category)
        {
            Title = title;
            this.category = category;
        }
    }

}
        







