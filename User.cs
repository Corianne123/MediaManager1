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

        private List<Media> SharedMedia { get; set; } = new List<Media>();

        public  User(string name,Library library)
        { 
            this.Name = name; 
            Library = library;
        }

        public void Share(Media media,User user)
        {
            if(IsAvailable(media))
            {
                if (IsOwned(media))
                {
                    user.SharedMedia.Add(media);
                    SharedMedia.Add(media);
                } else
                {
                    throw new NotOwnedException();
                }
            } else
            {
                throw new NotAvailableException();
            }

            

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
            if (((Library.medias.Contains(media)) && (!SharedMedia.Contains(media))) || ((!Library.medias.Contains(media)) && (SharedMedia.Contains(media))))
            {
                return true;
            }
            else
            {
                return false;
            } 

        }

        public bool IsOwned(Media media)
        {
                return Library.medias.Contains(media);
        }



    }
}
