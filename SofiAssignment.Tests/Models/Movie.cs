using System.Collections.Generic;

namespace SofiAssignment.Tests.Models
{
    public class Movie : MovieBase
    {
        public Collection Belongs_To_Collection { get; set; }
        public int Budget { get; set; }
        public List<Genre> Genres { get; set; }
        public string Homepage { get; set; }
        public string Imdb_Id { get; set; }
        public List<ProductionCompany> Production_Companies { get; set; }
        public List<ProductionCountry> Production_Countries { get; set; }
        public double Revenue { get; set; }
        public int Runtime { get; set; }
        public List<Language> Spoken_Languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
    }
}