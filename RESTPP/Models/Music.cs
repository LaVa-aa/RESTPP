using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace RESTPP.Models
{
    public class Music
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Artist { get; set; }
        public int PublishingYear { get; set; }

        public Music()
        {

        }
        
        public Music(int id, string title, string artist, int publishingYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            PublishingYear = publishingYear;
        }
    }
}
