using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Models
{
    public class Playlist
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string title)
        {
            Title = title;
            Songs = new List<Song>();
        }
    }

}
