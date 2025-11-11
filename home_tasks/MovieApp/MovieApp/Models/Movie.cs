using MovieApp.Interfaces;
using MovieApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    class Movie: Media,IPlayable
    {
        public bool Watched { get; set; }
        public Genre Genre { get; set; }

        public Movie(string title, int year, Genre genre, bool watched)
        {
            Title = title;
            Year = year;
            Genre = genre;
            Watched = watched;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}, Genre: {Genre}, Watched: {Watched}");
        }

        public void Play()
        {
            Console.WriteLine($"Playing {Title}...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Title} stopped");
        }

        
        public void MarkAsWatched(List<Movie> movies)
        {
            if(Watched)
            {
                Console.WriteLine($"{Title} is already marked as watched.");
                return;
            }
            else
            {
                Watched = true;
                Console.WriteLine($"{Title} marked as watched successfully.");
            }
            MovieManager.SaveMovies(movies);

        }

        public void MarkAsUnwatched(List<Movie> movies)
        {
            if(Watched)
            {
                Watched = false;
                Console.WriteLine($"{Title} marked as unwatched successfully.");
            }
            else
            {
                Console.WriteLine($"{Title} is already marked as unwatched.");
            }
            MovieManager.SaveMovies(movies);
        }
    }
}
