using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Models
{
    public class Profile
    {
        public string Username { get; set; }
        public List<Playlist> Playlists { get; set; }
        public int TotalListeningHours { get; set; }
        public DateTime LastSongPlayedTime { get; set; }

        public Profile(string username)
        {
            Username = username;
            Playlists = new List<Playlist>();
            TotalListeningHours = 0;
            LastSongPlayedTime = DateTime.MinValue;
        }

        public void UpdateLastSongPlayedTime()
        {
            LastSongPlayedTime = DateTime.UtcNow;
        }
    }

}
