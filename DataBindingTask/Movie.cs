using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingTask
{
    class Movie
    {
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }
        public List<string> Genre { get; set; }
        public int Rating { get; set; }
    }
}
