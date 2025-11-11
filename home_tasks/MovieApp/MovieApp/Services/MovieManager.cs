using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Models;
using Newtonsoft.Json;

namespace MovieApp.Services
{
    sealed class MovieManager
    {
        public static string path = "C:\\Users\\DELL\\Desktop\\MovieApp\\MovieApp\\Data\\movie.json";

        public void UpdateMovies(List<Movie> movies)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    string json = JsonConvert.SerializeObject(movies, Formatting.Indented);
                    writer.WriteLine(json);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public List<Movie> ShowAllMovies()
        {
            try
            {
                string result;
                using (StreamReader reader = new StreamReader(path))
                {
                    result = reader.ReadToEnd();
                }
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(result);
                return movies;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public static void SaveMovies(List<Movie> movies)
        {
            string json = JsonConvert.SerializeObject(movies, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
