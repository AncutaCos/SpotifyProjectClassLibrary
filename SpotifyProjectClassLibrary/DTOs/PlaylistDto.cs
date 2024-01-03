using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.DTOs
{
    public class PlaylistDto
    {
        public string Title { get; set; }
        public List<SongDto> Songs { get; set; }

        public PlaylistDto()
        {
            Songs = new List<SongDto>();
        }
    }

}
