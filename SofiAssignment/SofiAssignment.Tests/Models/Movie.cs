using System.Collections.Generic;

namespace SofiAssignment.Tests
{
    public class Movie
    {
        public bool Adult { get; set; }
        public bool BackdropPath { get; set; }
        public Collection BelongsToCollection { get; set; }
        public int Budget { get; set; }
        public List<Genre> Genres { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string PosterPath { get; set; }
        public List<ProductionCompany> ProductionCompanies { get; set; }
        public List<ProductionCountry> ProductionCountries { get; set; }
        public string ReleaseDate { get; set; }
        public double Revenue { get; set; }
        public int Runtime { get; set; }
        public List<Language> SpokenLanguages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverate { get; set; }
        public int VoteCount { get; set; }
    }
}