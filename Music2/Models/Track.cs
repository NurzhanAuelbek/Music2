using System.Collections.Generic;

namespace Music2.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public virtual ICollection<Artist> Authors { get; set; }
        public virtual ICollection<Artist> Performers { get; set; }
        public string Lyrics { get; set; }
        public int ReleaseId { get; set; }
        public virtual Release Release { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }

}
