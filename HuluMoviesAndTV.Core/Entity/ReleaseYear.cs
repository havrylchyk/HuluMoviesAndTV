namespace HuluMoviesAndTV.Core.Entity
{
    public class ReleaseYear : BaseEntity
    {
        public int Year { get; set; }

        public ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}