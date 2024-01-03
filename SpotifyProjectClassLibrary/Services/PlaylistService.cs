using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Services
{
    public class PlaylistService
    {
        private readonly PlaylistRepository _playlistRepository;

        public PlaylistService(PlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public List<Playlist> GetAllPlaylists()
        {
            return _playlistRepository.GetAllPlaylists();
        }

        // Altri metodi per la gestione delle playlist
    }

}
