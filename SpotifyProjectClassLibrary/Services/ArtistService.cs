using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Services
{
    public class ArtistService
    {
        private readonly ArtistRepository _artistRepository;

        public ArtistService(ArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public List<Artist> GetAllArtists()
        {
            return _artistRepository.GetAllArtists();
        }

        // Altri metodi per la gestione degli artisti
    }

}
