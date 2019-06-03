using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MovieSession.Dal
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual IReadOnlyCollection<Genre> SubGenres { get; set; }

        public Genre()
        {
            SubGenres = new List<Genre>();
        }
    }
}
