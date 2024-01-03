using SpotifyProjectClassLibrary.Data;
using SpotifyProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Repositories
{
    public class ArtistRepository
    {
        private readonly CSVContext _csvContext;
        private readonly string _filePath;

        public ArtistRepository(CSVContext csvContext, string filePath)
        {
            _csvContext = csvContext;
            _filePath = filePath;
        }

        public List<Artist> GetAllArtists()
        {
            return _csvContext.ReadCSVFile<Artist>(_filePath);
        }

        // Metodi aggiuntivi se necessario
    }

}
