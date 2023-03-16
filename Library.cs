using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public  class Library
    {
        public List<Media> medias { get; set; } = new List<Media>();
        public string Name { get; set; }

        public Library(string name)
        {
            Name = name;
        }

        public int Count ()
        {
           return this.medias.Count;
        }

        public int CountBooks () {

            List<Media> list = medias.FindAll(x => x is Book);
            return list.Count; 
        }

        public int CountComics()
        {
            List<Media> list = medias.FindAll(x => x is Comic);
            return list.Count;
        }

        public int CountMovies()
        {
            List<Media> list = medias.FindAll(x => x is Movie);
            return list.Count;
        }

        public bool Contains(Media media)
        {
            return medias.Contains(media);
        }

        public void RemoveMedia(Media media)
        {
            medias.Remove(media);
        }

        public void RemoveMedia(List<Media> mediaList)
        {
            foreach (Media a in mediaList)
            {
                this.RemoveMedia(a);

            }

        }

        public List<Media> FindByGenre(Genre genre)
        {
            List<Media> list = medias.FindAll(x => x.Genres.Contains(genre));

            return list;
        }

        public List<Media> FindByTitle(string title)
        {
            List<Media> list = medias.FindAll(x => x.Title.StartsWith(title));

            return list;
        }


        public void AddMedia(Media m)
        {
            if (medias.FindAll(p => p.Title == m.Title).Any())
            {
                throw new DuplicateException("Title already exists", m.Title);
            }
             this.medias.Add(m);
        }

        public void AddMedia(List<Media> list)
        {
            foreach (Media m in list)
            {
                if (medias.FindAll(media => media.Title == m.Title).Any())
                {
                    throw new DuplicateException("Title already exists", m.Title);
                }
            }
            foreach (Media m in list)
            {
                this.medias.Add(m);
            }

        }

    }
}
