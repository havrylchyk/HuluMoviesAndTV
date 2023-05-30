namespace HuluMoviesAndTV.Core.Entity
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}