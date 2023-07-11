using System.Collections.Generic;
using System;

namespace Music2.Models
{
    public class Release
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }

}
