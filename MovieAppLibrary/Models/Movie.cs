using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Services;

namespace MovieAppLibrary.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }

        public Movie() { }

        public Movie(string id, string title, string genre, int releaseYear)
        {
            Id = id;
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
        }
    }
}
