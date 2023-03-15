using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public class Comic: Media
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public List<Genre> Genres { get; set; }
        public Comic(string title, string author, Genre type) : base(title, type)
        {
            Author = author;
        }
        public Comic(string title, string author, List<Genre> type) : base(title, type)
        {
            Author = author;

        }
    }
}
