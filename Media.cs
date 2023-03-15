using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public abstract class Media
    {
        public string Title;

        public List<Genre> Genres;

        public User ShareWith { get; set; }


        public Media(string title,Genre type)
        {
            Title = title;
            Genres = new List<Genre>();
            Genres.Add(type);
        }

        public Media(string title,List<Genre> type)
        {
            Title = title;
            Genres = type;

        }

    }
}
