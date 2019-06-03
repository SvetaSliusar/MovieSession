using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSession.Dal
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Description { get; set; }        
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }

        public virtual IReadOnlyCollection<Genre> Genres { get; set; }

        public Movie()
        {
            Genres = new List<Genre>();
        }
    }
}
