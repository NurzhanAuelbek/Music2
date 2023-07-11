using static Microsoft.EntityFrameworkCore.Internal.AsyncLock;
using System.Collections.Generic;

namespace Music2.Models
{
	public class AudioTrack
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ARtis { get; set; }
		public string Album { get; set; }
		public string FilePath { get; set; }
	}

}
