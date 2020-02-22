using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace movie_tracker_wf2
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime DateSeen { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
}