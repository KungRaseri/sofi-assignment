using System;
using System.Collections.Generic;
using System.Text;

namespace SofiAssignment.Tests.Models
{
    public class MoviePageResult
    {
        public int Page { get; set; }
        public MovieBase[] Results { get; set; }
        public int Total_Results { get; set; }
        public int Total_Pages { get; set; }
    }
}
