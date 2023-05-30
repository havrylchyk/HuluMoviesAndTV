namespace HuluMoviesAndTV.Core.Entity
{
    public class Rating : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}