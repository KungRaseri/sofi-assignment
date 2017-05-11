using System;
using System.Collections.Generic;
using System.Text;

namespace SofiAssignment.Tests.Models
{
    public class MovieBase
    {
        public bool Adult { get; set; }
        public string Backdrop_Path { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_Path { get; set; }
        public string Release_Date { get; set; }
        public List<int> Genre_Ids { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double Vote_Average { get; set; }
        public int Vote_Count { get; set; }
        public string Original_Language { get; set; }
        public string Original_Title { get; set; }
        public int Id { get; set; }

    }
}
