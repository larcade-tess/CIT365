using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDSMovies.Models
{
    public class LDSMoviesContext : DbContext
    {
        public LDSMoviesContext (DbContextOptions<LDSMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMovies.Models.movie> movie { get; set; }
        public object Movie { get; internal set; }
    }
}
