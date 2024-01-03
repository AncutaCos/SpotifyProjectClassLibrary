using SpotifyProjectClassLibrary.Data;
using SpotifyProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Repositories
{
    public class AlbumRepository
    {
        private readonly CSVContext _csvContext;
        private readonly string _filePath;

        public AlbumRepository(CSVContext csvContext, string filePath)
        {
            _csvContext = csvContext;
            _filePath = filePath;
        }

        public List<Album> GetAllAlbums()
        {
            return _csvContext.ReadCSVFile<Album>(_filePath);
        }

        // Metodi aggiuntivi se necessario
    }

}
