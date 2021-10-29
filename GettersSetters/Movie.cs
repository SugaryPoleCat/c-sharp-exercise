namespace GettersSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

        //public Movie()
        //{
        //    Console.WriteLine("Title: " + title + "\n" + "Director: " + director + "\n" + "Rating: " + rating);
        //}

        public string Rating
        {
            get { return rating; }
            set
            {
                // value represents anything that gets poassed into  SET
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "ER")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
