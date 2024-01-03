using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.DTOs
{
    public class ProfileDto
    {
        public string Username { get; set; }
        public List<PlaylistDto> Playlists { get; set; }
        public int TotalListeningHours { get; set; }
        // Aggiungi altri campi se necessari

        public ProfileDto()
        {
            Playlists = new List<PlaylistDto>();
        }
    }

}
