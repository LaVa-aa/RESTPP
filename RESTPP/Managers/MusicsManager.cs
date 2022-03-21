using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTPP.Models;

namespace RESTPP.Managers
{
    public class MusicsManager
    {
        public static int nextId=1;

        private static readonly List<Music> data = new List<Music>
        {
            new Music {Id = nextId++, Title = "first", Artist = "la", PublishingYear = 1369},
            new Music {Id = nextId++, Title = "second", Artist = "ob", PublishingYear = 1999},

        };

        public IEnumerable<Music> GetAll(string title = null, string artist = null)
        {
           // return new List<Music>(data);

            List<Music> musics = new List<Music>(data);
            if (title != null)
            {
                musics = musics.FindAll(music => music.Title != null && music.Title.StartsWith(title));
            }

            if (artist != null)
            {
                musics = musics.FindAll(music => music.Artist != null && music.Artist.StartsWith(artist));
            }

            return musics;
        }
    }
}
