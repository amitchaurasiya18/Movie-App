using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Exceptions;
using MovieAppLibrary.Models;
using MovieAppLibrary.Services;

namespace MovieAppLibrary.Repository
{
    public class MovieManager : Movie
    {        
        private static List<Movie> movies = new List<Movie>();

        public MovieManager() { 
            movies = SerialiseDeserialise.Deserialize();
        }
        public static void AddMovie()
        {
            try
            {
                Movie movie = new Movie();
                if (movies.Count > 2)
                    throw new CapacityFull("Movie store's capacity is full.");
                
                Console.Write("Enter movie title : ");
                movie.Title = Console.ReadLine();

                Console.Write("Enter movie genre : ");
                movie.Genre = Console.ReadLine();

                Console.Write("Enter movie release year (yyyy) : ");
                movie.ReleaseYear = int.Parse(Console.ReadLine());
                
                if (movie.ReleaseYear < 1888)
                    throw new MovieYearNotFound("This year is before the release of first movie");
                
                movie.Id = movie.Title.Substring(0, 2) + movie.Genre.Substring(0,2) + movie.ReleaseYear.ToString().Substring(2,2);

                Console.WriteLine($"Movie Id : {movie.Id}");

                movies.Add(movie);
                SerialiseDeserialise.Serialize(movies);
                Console.WriteLine("\nMovie Added successfully.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void DisplayMovie()
        {
            try
            {
                if (!movies.Any())
                    throw new StoreEmpty("Movie Store is Empty. Please add some movies");
                
                Console.Write($"Enter movie ID to get details : ");
                string movieId = Console.ReadLine();
                bool foundMovie = false;
                foreach (Movie movie in movies)
                {
                    if (movie.Id == movieId)
                    {
                        Console.WriteLine($"\n-----Movie Found-----");
                        Console.WriteLine($"Movie Id : {movie.Id}");
                        Console.WriteLine($"Movie Title : {movie.Title}");
                        Console.WriteLine($"Movie Genre : {movie.Genre}");
                        Console.WriteLine($"Movie Release Year : {movie.ReleaseYear}");
                        Console.WriteLine();
                        foundMovie = true;
                    }
                }
                SerialiseDeserialise.Serialize(movies);
                if (!foundMovie)
                    throw new MovieNotFound("\nMovie Not Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void DeleteMovie()
        {
            try
            {
                if (!movies.Any())
                    throw new StoreEmpty("Movie Store is Empty. Please add some movies");                    
                
                Console.Write($"Enter movie ID to get details : ");
                string movieId = Console.ReadLine();
                bool movieDeleted = false;
                foreach (Movie movie in movies)
                {
                    if (movie.Id == movieId)
                    {
                        movies.Remove(movie);
                        movieDeleted = true;
                        Console.WriteLine("\nMovie deleted successfully.");
                    }
                }
                SerialiseDeserialise.Serialize(movies);
                if (!movieDeleted)
                    throw new MovieNotFound("Movie Not Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
