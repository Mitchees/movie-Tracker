using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
Author: Mitchell Aninyang
*/

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
