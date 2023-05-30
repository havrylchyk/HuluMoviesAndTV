using HuluMoviesAndTV.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace HuluMoviesAndTV.Core.Context
{
    public class MoviesAndShowsContext : DbContext
    {
        public DbSet<MovieAndShow> MovieAndShows {get; set;}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Listened> Listeneds { get; set; }
        public DbSet<ProgramType> ProgramTypes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ReleaseYear> ReleaseYears { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HuluDb;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

    }
}
