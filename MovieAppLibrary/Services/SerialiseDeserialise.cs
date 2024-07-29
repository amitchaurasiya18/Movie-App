using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Models;
using Newtonsoft.Json;

namespace MovieAppLibrary.Services
{
    public class SerialiseDeserialise
    {
        public static void Serialize(List<Movie> movies)
        {
            File.WriteAllText("MovieDatabase.json", JsonConvert.SerializeObject(movies, Newtonsoft.Json.Formatting.Indented));
        }

        public static List<Movie> Deserialize()
        {
            List<Movie> movies = new List<Movie>();
            string fileName = "MovieDatabase.json";
            if (File.Exists(fileName))
            {
                string fileData = File.ReadAllText(fileName);
                var deserialsedMovie = JsonConvert.DeserializeObject<Movie[]>(fileData);

                if (deserialsedMovie != null)
                {
                    for (int i = 0; i < deserialsedMovie.Length; i++)
                    {
                        movies.Add(deserialsedMovie[i]);
                    }
                }
            }
            else
            {
                File.WriteAllText("MovieDatabase.json", JsonConvert.SerializeObject(movies));
            }
            return movies;
        }
    }
}
