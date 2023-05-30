namespace HuluMoviesAndTV.Core.Entity
{
    public class ReleaseYear : BaseEntity
    {
        public int Year { get; set; }

        public virtual ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}