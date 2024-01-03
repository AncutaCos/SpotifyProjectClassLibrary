using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace SpotifyProjectClassLibrary.Data
{
    public class CSVContext
    {
        // Metodo per leggere i dati da un file CSV
        public List<T> ReadCSVFile<T>(string filePath) where T : class
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<T>();
                return new List<T>(records);
            }
        }
    }
}
