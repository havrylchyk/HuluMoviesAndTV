using HuluMoviesAndTV.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluMoviesAndTV.Core.Context
{
    public class MoviesAndShowsContext: DbContext
    {
        public DbSet<MovieAndShow> MovieAndShows => Set<MovieAndShow>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Director> Directors => Set<Director>();
        public DbSet<Listened> Listeneds => Set<Listened>();
        public DbSet<ProgramType> ProgramTypes => Set<ProgramType>();
        public DbSet<Rating> Ratings => Set<Rating>();
        public DbSet<ReleaseYear> ReleaseYears => Set<ReleaseYear>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HuluDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
