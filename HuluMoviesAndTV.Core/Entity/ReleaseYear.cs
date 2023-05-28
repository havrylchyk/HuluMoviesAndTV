namespace HuluMoviesAndTV.Core.Entity
{
    public class ReleaseYear : BaseEntity
    {
        public DateTime Year { get; set; }

        public ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}