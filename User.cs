using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public class User
    {
        public string Name { get; set; }
        public Library Library { get; set; }

        private List<Media> OwnedMedia { get; set; } = new List<Media>();

        private List<Media> SharedMedia { get; set; } = new List<Media>();

        public  User(string name,Library library)
        { 
            this.Name = name; 
            Library = library;
            OwnedMedia = Library.medias;
        }

        public void Share(Media media,User user)
        {
                
            SharedMedia.Add(media);

        }

        public bool IsShared(Media media)
        {
            if (SharedMedia.Contains(media))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool IsAvailable(Media media)
        {
            if (OwnedMedia != null)
            {
                if ((OwnedMedia.Contains(media)) && (!SharedMedia.Contains(media)))
                {
                    return true;
                } else if ((!OwnedMedia.Contains(media)) && (SharedMedia.Contains(media)))
                {
                    return true;
                } else
                {
                    return false;
                } 
            }
            else
            {
                if (SharedMedia.Contains(media))
                {
                    return true;
                } else
                {
                    return false;
                }
                
            }

        }

        public bool IsOwned(Media media)
        {
            if (OwnedMedia != null)
            {
                return OwnedMedia.Contains(media);
            } else
            { 
                return false;
            }
            

        }



    }
}
