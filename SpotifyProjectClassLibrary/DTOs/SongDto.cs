using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.DTOs
{
    public class SongDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PlayCount { get; set; }
        // Altre proprietà possono essere aggiunte a seconda dei requisiti
    }

}
