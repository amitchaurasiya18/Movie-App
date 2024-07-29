using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLibrary.Exceptions
{
    public class MovieNotFound : Exception
    {
        public MovieNotFound(string message) : base(message) { }
    }
}
