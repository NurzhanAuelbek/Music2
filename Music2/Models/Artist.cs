using static Microsoft.EntityFrameworkCore.Internal.AsyncLock;
using System.Collections.Generic;

namespace Music2.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public virtual ICollection<Release> Releases { get; set; }
    }

}
