using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.ArtistFolder
{
    public class ArtistListItem
    {
       
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
