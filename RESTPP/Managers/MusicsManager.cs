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
        
        public IEnumerable<Music> GetAll()
        {
            return new List<Music>(data);
        }
    }
}
