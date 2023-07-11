using System.Collections.Generic;

namespace Music2.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Release> Releases { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }

}
