namespace MovieLab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Movie List Application!");
        List <Movie> movies = new List<Movie>();
        
        movies.Add(new Movie("Get Out", "Horror"));
        movies.Add(new Movie("Black Dynamite", "Action"));
        movies.Add(new Movie("Friday", "Comedy"));
        movies.Add(new Movie("Memoir of a Snail", "Drama"));
        movies.Add(new Movie("Wendell & Wild", "Comedy"));
        movies.Add(new Movie("Robot Dreams", "Comedy"));
        movies.Add(new Movie("Aqua Teen Forever: Plantasm", "Comedy"));
        movies.Add(new Movie("Queen & Slim", "Romance"));
        movies.Add(new Movie("The Glass Castle", "Drama"));
        movies.Add(new Movie("Sinners", "Action"));
        
        // INITIALIZE ALL VARIABLES THAT WOULD BE USED BELOW:
        string userChoice = "y";
            
        while (userChoice == "y")
        {
            Console.WriteLine("There are " + movies.Count + " movies in this list.");
            Console.WriteLine("What category are you interested in?");
            string userCategory = Console.ReadLine();

            int matches = 0;

            foreach (Movie movie in movies)
            {
                if (movie.Category.ToLower() == userCategory.ToLower())
                {
                    Console.WriteLine(movie.Title);
                    matches = matches + 1;
                }
            }

            if (matches == 0)
            {
                Console.WriteLine("No movies found in that category.");
            }

            Console.WriteLine("Do you want to search again? (y/n)");
            userChoice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Goodbye!");
    }
}