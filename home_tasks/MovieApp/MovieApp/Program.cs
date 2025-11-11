using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Interfaces;
namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager manager = new MovieManager();
            //Movie movie_1 = new Movie("Inception", 2010, Genre.SciFi, false);
            //Movie movie_2 = new Movie("The Godfather", 1972, Genre.Drama, true);

            //List<Movie> movies = new List<Movie> { movie_1, movie_2 };
            List<Movie> movies = manager.ShowAllMovies();
            //movies.Add(new Movie("The Dark Knight", 2008, Genre.Action, false));
            movies[0].MarkAsUnwatched(movies);
            manager.UpdateMovies(movies);
            movies.ForEach(movie => movie.DisplayInfo());
        }
    }
}
