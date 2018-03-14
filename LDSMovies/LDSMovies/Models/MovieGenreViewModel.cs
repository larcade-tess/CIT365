using LDSMovies.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}