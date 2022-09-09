using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVCmovies.Data
{
    public class MVCmoviesContext : DbContext
    {
        public MVCmoviesContext (DbContextOptions<MVCmoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
