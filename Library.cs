﻿using System;
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
        public List<Media> medias { get; set; }
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
           int nb = 0;
            foreach(var item in medias)
            { 
                if (item is Book)
                    nb++; 
            }
            return nb; 
        }

        public int CountComics()
        {
            int nb = 0;
            foreach (var item in medias)
            {
                if (item is Comic)
                    nb++;
            }
            return nb;
        }

        public int CountMovies()
        {
            int nb = 0;
            foreach (var item in medias)
            {
                if (item is Movie)
                    nb++;
            }
            return nb;
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


        public void AddMedia(Media a)
        {
            if (medias != null)
            {
                if (medias.FindAll(p => p.Title == a.Title).Any())
                {
                    throw new DuplicateException("Title already exists", a.Title);
                }
                else
                {

                    this.medias.Add(a);
                }
            } else
            {
                medias = new List<Media>();
                this.medias.Add(a);
            }


        }

        public void AddMedia(List<Media> list)
        {
            if (medias != null) { 
                foreach (Media a in list)
                {
                    if (medias.FindAll(media => media.Title == a.Title).Any())
                    {
                        throw new DuplicateException("Title already exists", a.Title);
                    }
                }
                foreach (Media a in list)
                {
                    this.medias.Add(a);
                }
            } else
            {
                medias = list;
            }

        }

    }
}