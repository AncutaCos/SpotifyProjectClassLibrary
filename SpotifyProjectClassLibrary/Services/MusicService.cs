using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Services
{
    public class MusicService
    {
        public readonly SongRepository _songRepository;

        public MusicService(SongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public List<Song> GetAllSongs()
        {
            return _songRepository.GetAllSongs();
        }

        // Aggiungi qui altri metodi, come ricerca di canzoni, filtraggio per genere, ecc.
    }

}
