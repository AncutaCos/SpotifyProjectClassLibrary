using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(string name, string genre)
        {
            Name = name;
            Genre = genre;
            Albums = new List<Album>();
        }
    }

}
