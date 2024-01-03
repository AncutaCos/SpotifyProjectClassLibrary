using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Services
{
    public class AlbumService
    {
        private readonly AlbumRepository _albumRepository;

        public AlbumService(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public List<Album> GetAllAlbums()
        {
            return _albumRepository.GetAllAlbums();
        }

        // Altri metodi per la gestione degli album
    }

}
