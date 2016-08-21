using System;
using System.Collections.Generic;

namespace MusicStore.Models
{
    public class Artist
    {

        public int ArtistID { get; set; }

        public String ArtistName { get; set; }

        public virtual List<Album> Albums { get; set; }

    }
}