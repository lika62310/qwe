using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class Movie
    {
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }

        public Movie(string title, double duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }
    }
}
