using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Models
{
    public class Album
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, string genre)
        {
            Title = title;
            Genre = genre;
            Songs = new List<Song>();
        }
    }

}
