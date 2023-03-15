using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public class Movie : Media
    {
        public string Title { get; set; }

        public string Director { get; set; }
        public List<Genre> Genres { get; set; }
        public Movie(string title, string director, Genre type) : base(title,type)
        {
            Director = director;
        }
        public Movie(string title, string director, List<Genre> type) : base(title, type)
        {
            Director = director;

        }
    }
}
