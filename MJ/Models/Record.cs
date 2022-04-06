using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRecords.Models
{
    public class Record
    {
        public string Title { get; set; }
        public int Id { get; set; }

        public string ArtistName { get; set; }

        public Record()
        {

        }

        public Record(string title, int id, string artiststName)
        {
            Title = title;
            Id = id;
            ArtistName = artiststName;
        }
    }
}
