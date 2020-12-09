using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.ArtistFolder
{
    public class ArtistDetail
    {
        
        public int ArtistId { get; set; }
        public Guid OwnerId { get; set; }
        public string ArtistName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public object ModifiedUtc { get; set; }
    }
}
