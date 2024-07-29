using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLibrary.Exceptions
{
    public class CapacityFull : Exception
    {
        public CapacityFull(string message) : base(message) { }
    }
}
