using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public IEnumerable<Album> List { get; set; }
        public Album Album { get; set; }
    }
}