﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int  GenreId { get; set; }
        public virtual int  ArtistId { get; set; }
    }
}