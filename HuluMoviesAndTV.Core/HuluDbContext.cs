using HuluMoviesAndTV.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluMoviesAndTV.Core
{
    public class HuluDbContext : DbContext
    {
        public DbSet<MovieAndShow> MovieAndShows { get; set; }
        public DbSet<ProgramType> ProgramTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Listened> Listeneds { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ReleaseYear> ReleaseYears { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HuluDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
